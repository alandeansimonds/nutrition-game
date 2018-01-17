﻿using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using System.Collections.Generic;
using System.Linq;
using System;
using UnityEngine.Networking;

namespace Unitycoding.LoginSystem
{
    public class LoginSystem : MonoBehaviour
    {

        // Stores the id of the user from the SQL database.  Used for future queries (i.e. saving and loading progress).
        public static int playerId = -1;

        private static LoginSystem m_Current;

        /// <summary>
        /// The LoginSystem singleton object. This object is set inside Awake()
        /// </summary>
        public static LoginSystem current
        {
            get
            {
                if (m_Current == null)
                {
                    LoginSystem.logger.LogError("Requires a LoginSystem. Create one from Tools > Unitycoding > Login System > Create > Login System!");
                }
                return m_Current;
            }
        }

        private static DebugFilter m_Logger;

        /// <summary>
        /// Gets the debug logger helper.
        /// </summary>
        /// <value>The logger.</value>
        public static DebugFilter logger
        {
            get
            {
                if (LoginSystem.m_Current != null && LoginSystem.m_Current.m_Settings != null)
                {
                    m_Logger = new DebugFilter(LoginSystem.Settings.logLevel, "[Login System]");
                }
                else
                {
                    m_Logger = new DebugFilter(DebugFilter.FilterLevel.Error, "[Login System]");
                }
                return m_Logger;
            }
        }

        [SerializeField]
        private LoginSettings m_Settings;

        /// <summary>
        /// Gets the settings LoginSystem settings. Configurate it inside the editor.
        /// </summary>
        /// <value>The settings.</value>
        public static LoginSettings Settings
        {
            get
            {
                if (LoginSystem.current != null && LoginSystem.current.m_Settings != null)
                {
                    return LoginSystem.current.m_Settings;
                }
                LoginSystem.logger.LogError("Please assign LoginSettings to the Login System!");
                return null;
            }
        }

        /// <summary>
        /// Don't destroy this object instance when loading new scenes.
        /// </summary>
        public bool dontDestroyOnLoad;

        public static List<PersistencePayload> progressToRestore;

        /// <summary>
        /// Awake is called when the script instance is being loaded.
        /// </summary>
        private void Awake()
        {
            if (LoginSystem.m_Current != null)
            {
                LoginSystem.logger.LogInfo("Multiple LoginSystems in scene...this is not supported. Destroying instance!");
                Destroy(gameObject);
                return;
            }
            else
            {
                LoginSystem.m_Current = this;
                if (dontDestroyOnLoad)
                {
                    DontDestroyOnLoad(gameObject);
                }
                LoginSystem.logger.LogInfo("LoginSystem instance set.");
            }
        }

        /// <summary>
        /// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
        /// </summary>
        private void Start()
        {
            if (Settings != null && Settings.loadLevelOnLogin)
            {
                if (string.IsNullOrEmpty(Settings.levelToLoad))
                {
                    LoginSystem.logger.LogWarning("Load level on login is checked, but the level to load is empty. Please enter a level name in the editor.");
                    return;
                }
                if (Settings.skipLogin)
                {
#if UNITY_4_6 || UNITY_4_7 || UNITY_5_0 || UNITY_5_1 || UNITY_5_2
					Application.LoadLevel(Settings.levelToLoad);
#else
                    UnityEngine.SceneManagement.SceneManager.LoadScene(Settings.levelToLoad);
#endif
                }
            }
        }

        /// <summary>
        /// Creates the account.
        /// </summary>
        /// <param name="username">Username.</param>
        /// <param name="password">Password.</param>
        /// <param name="email">Email.</param>
        public static void CreateAccount(string username, string password, string email)
        {
            if (LoginSystem.current != null)
            {
                LoginSystem.current.StartCoroutine(CreateAccountInternal(username, password, email));
            }
        }

        private static IEnumerator CreateAccountInternal(string username, string password, string email)
        {
            if (LoginSystem.Settings == null)
            {
                EventHandler.Execute("OnFailedToCreateAccount");
                yield break;
            }

            LoginSystem.logger.LogInfo("[CreateAccount]: Trying to register a new account with username: " + username + " and password: " + password + "!");

            WWWForm newForm = new WWWForm();
            newForm.AddField("name", username);
            newForm.AddField("password", password);
            newForm.AddField("email", email);

            WWW w = new WWW(LoginSystem.Settings.serverAddress + "/" + LoginSystem.Settings.createAccount, newForm);

            while (!w.isDone)
            {
                yield return new WaitForEndOfFrame();
            }

            if (w.error != null)
            {
                Debug.LogError(w.error);
            }

            bool res = w.text.Trim().Equals("true");
            if (res)
            {
                LoginSystem.logger.LogInfo("[CreateAccount] Account creation was successfull!");
                EventHandler.Execute("OnAccountCreated");
            }
            else
            {
                LoginSystem.logger.LogInfo("[CreateAccount] Failed to create account. Result: " + w.text);
                EventHandler.Execute("OnFailedToCreateAccount");
            }
        }

        /// <summary>
        /// Logs into the account.
        /// </summary>
        /// <param name="username">Username.</param>
        /// <param name="password">Password.</param>
        public static void LoginAccount(string username, string password)
        {
            if (LoginSystem.current != null)
            {
                LoginSystem.current.StartCoroutine(LoginAccountInternal(username, password));
            }
        }

        private static IEnumerator LoginAccountInternal(string username, string password)
        {
            if (LoginSystem.Settings == null)
            {
                EventHandler.Execute("OnFailedToLogin");
                yield break;
            }

            //LoginSystem.logger.LogInfo ("[LoginAccount] Trying to login using username: " + username + " and password: " + password + "!");
            LoginSystem.logger.LogInfo("[LoginAccount] Trying to login using username: " + username);

            WWWForm newForm = new WWWForm();
            newForm.AddField("name", username);
            newForm.AddField("password", password);
            //List<IMultipartFormSection> formData = new List<IMultipartFormSection>();
            //formData.Add(new MultipartFormDataSection("name=" + username + "&password=" + password));

            // Legacy:
            //WWW w = new WWW (LoginSystem.Settings.serverAddress + "/" + LoginSystem.Settings.login, newForm);
            UnityWebRequest w = UnityWebRequest.Post(LoginSystem.Settings.serverAddress + "/" + LoginSystem.Settings.login, newForm);
            //LoginSystem.logger.LogInfo("[LoginAccount] " + w.url);
            yield return w.SendWebRequest();

            while (!w.isDone)
            {
                yield return new WaitForEndOfFrame();
            }

            if (w.error != null)
            {
                Debug.LogError(w.error);
            }

            //bool res = w.text.Trim ().Equals ("true");
            //string response = w.text.Trim();
            string response = w.downloadHandler.text;
            //bool res = !response.Equals("-1");

            // This represents the id of the player within the SQL database.
            // It will be used for future queries involving saving and loading progress.
            int playerId = -1;

            // Extract the userId from the response.
            if (System.Int32.TryParse(response, out playerId))
            {
                PlayerPrefs.SetString(LoginSystem.Settings.accountKey, username);

                //if (System.Int32.TryParse(response, out playerId))
                if (playerId > 0)
                {
                    LoginSystem.playerId = playerId;
                    LoginSystem.logger.LogInfo("[LoginAccount] Login was successful!  PlayerId: " + playerId.ToString());
                    EventHandler.Execute("OnLogin");
                }
                else
                {
                    LoginSystem.playerId = playerId;
                    LoginSystem.logger.LogInfo("[LoginAccount] Failed to login. Error code: " + playerId);
                    EventHandler.Execute("OnFailedToLogin");
                }
            }
            else
            {
                LoginSystem.playerId = -1;
                LoginSystem.logger.LogInfo("[LoginAccount] Failed to login. Result: " + w.downloadHandler.text.Replace('\n', ' '));
                EventHandler.Execute("OnFailedToLogin");
            }
        }

        public static void LoadProgress()
        {
            if (LoginSystem.current != null)
            {
                LoginSystem.current.StartCoroutine(LoadProgressInternal());
            }
        }

        private static IEnumerator LoadProgressInternal()
        {
            // Clear any previously loaded progress.
            LoginSystem.progressToRestore = null;

            if (LoginSystem.Settings == null)
            {
                EventHandler.Execute("OnFailedToLoadProgress");
                yield break;
            }

            int playerId = LoginSystem.playerId;

            LoginSystem.logger.LogInfo("[LoadProgress] Trying to load using playerId: " + playerId.ToString());

            WWWForm newForm = new WWWForm();

            // Add playerId to form.
            newForm.AddField("playerId", playerId.ToString());

            WWW w = new WWW(LoginSystem.Settings.serverAddress + "/" + LoginSystem.Settings.loadPlayerProgress, newForm);

            while (!w.isDone)
            {
                yield return new WaitForEndOfFrame();
            }

            if (w.error != null)
            {
                Debug.LogError(w.error);
            }

            string response = w.text.Trim();
            bool res = !response.Equals("false");
            if (res)
            {
                // Existing data found.
                // Restore game from previous checkpoint.
                var result = from line in response.Split('\n')
                             let tokens = line.Split(',')
                             where tokens.Length >= 2
                             let datemName = tokens[0]
                             let datemValue = tokens[1]
                             select new PersistencePayload(datemName, datemValue);

                LoginSystem.progressToRestore = result.ToList();

                // DEBUG:
                LoginSystem.logger.LogInfo("[LoadProgress] Raw response: " + w.text);
                LoginSystem.logger.LogInfo("[LoadProgress] Records found:");
                foreach (PersistencePayload record in LoginSystem.progressToRestore)
                {
                    LoginSystem.logger.LogInfo("[LoadProgress] " + record.recordName + ": " + record.recordValue);
                }

                LoginSystem.logger.LogInfo("[LoadProgress] Load progress was successful!  PlayerId: " + playerId.ToString());
                EventHandler.Execute("OnLoadProgress");
            }
            else
            {
                // Log failure.
                // Game should just be loaded from the start.
                LoginSystem.logger.LogInfo("[LoadProgress] Failed to load progress. Result: " + w.text);
                EventHandler.Execute("OnFailedToLoadProgress");
            }
        }

        public static void SaveProgress(List<PersistencePayload> payload)
        {
            if (LoginSystem.current != null)
            {
                LoginSystem.current.StartCoroutine(SaveProgressInternal(payload));
            }
        }

        private static IEnumerator SaveProgressInternal(List<PersistencePayload> payload)
        {
            if (LoginSystem.Settings == null)
            {
                EventHandler.Execute("OnFailedToSaveProgress");
                yield break;
            }

            int playerId = LoginSystem.playerId;

            LoginSystem.logger.LogInfo("[SaveProgress] Trying to save using PlayerId: " + playerId.ToString());

            WWWForm newForm = new WWWForm();
            // Add payload to form.

            //newForm.AddField("name", username);
            //newForm.AddField("password", password);
            newForm.AddField("playerId", playerId.ToString());
            foreach (PersistencePayload record in payload)
            {
                newForm.AddField("recordName[]", record.recordName);
                newForm.AddField("recordValue[]", record.recordValue);
            }

            WWW w = new WWW(LoginSystem.Settings.serverAddress + "/" + LoginSystem.Settings.savePlayerProgress, newForm);

            while (!w.isDone)
            {
                yield return new WaitForEndOfFrame();
            }

            if (w.error != null)
            {
                Debug.LogError(w.error);
            }

            bool res = w.text.Trim().Equals("true");
            //string response = w.text.Trim();
            //bool res = !response.Equals("-1");
            if (res)
            {
                LoginSystem.logger.LogInfo("[SaveProgress] Save progress was successful!  PlayerId: " + playerId.ToString());
                EventHandler.Execute("OnSaveProgress");
            }
            else
            {
                // Log failure.
                // Game should continue anyway.
                LoginSystem.logger.LogInfo("[SaveProgress] Failed to save progress. Result: " + w.text);
                EventHandler.Execute("OnFailedToSaveProgress");
            }
        }

        //Added by ADS, is used to store info, need to add string for phase2BiochemicalWhyInfo from gamescreen
        public static void SendPhase2BiochemicalWhyInfo(string username, string phase02BiochemicalWhyInfo)
        {
            if (LoginSystem.current != null)
            {
                LoginSystem.current.StartCoroutine(SendPhase2BiochemicalWhyInfoInternal(username, phase02BiochemicalWhyInfo));
            }
        }

        private static IEnumerator SendPhase2BiochemicalWhyInfoInternal(string username, string phase02BiochemicalWhyInfo)
        {
            WWWForm newForm = new WWWForm();
            newForm.AddField("name", username);
            newForm.AddField("phase2BiochemicalWhyInfo", phase02BiochemicalWhyInfo);

            WWW w = new WWW(LoginSystem.Settings.serverAddress + "/" + LoginSystem.Settings.addPhase2BiochemicalWhyInfo, newForm);

            while (!w.isDone)
            {
                yield return new WaitForEndOfFrame();
            }
        }

        public static void SendPlayerRatingInfo(string username, string phase02BiochemicalPlayerRating, string phase02BiochemicalWhyPlayerRating, string phase02MedicationPlayerRating, string phase02MedicalHistoryPlayerRating, string phase02AnthropometryPlayerRating, string phase03ParsingPlayerRating, string phase04ExamPlayerRating, string phase05QualatativeDietPlayerRating, string phase05QuantativeDietPlayerRating, string phase05EnergyActualPlayerRating, string phase05BodyWeightPlayerRating, string phase06Part01PlayerRating, string phase06EvidencePlayerRating, string phase07SelectionRating, string phase07FoodStrategiesRating, string phase07EducationalStrategiesRating, string phase08OverallGoalPlayerRating)
        {
            if (LoginSystem.current != null)
            {
                LoginSystem.current.StartCoroutine(SendPlayerRatingInfoInternal(username, phase02BiochemicalPlayerRating, phase02BiochemicalWhyPlayerRating, phase02MedicationPlayerRating, phase02MedicalHistoryPlayerRating, phase02AnthropometryPlayerRating, phase03ParsingPlayerRating, phase04ExamPlayerRating, phase05QualatativeDietPlayerRating, phase05QuantativeDietPlayerRating, phase05EnergyActualPlayerRating, phase05BodyWeightPlayerRating, phase06Part01PlayerRating, phase06EvidencePlayerRating, phase07SelectionRating, phase07FoodStrategiesRating, phase07EducationalStrategiesRating, phase08OverallGoalPlayerRating));
            }
        }

        private static IEnumerator SendPlayerRatingInfoInternal(string username, string phase02BiochemicalPlayerRating, string phase02BiochemicalWhyPlayerRating, string phase02MedicationPlayerRating, string phase02MedicalHistoryPlayerRating, string phase02AnthropometryPlayerRating, string phase03ParsingPlayerRating, string phase04ExamPlayerRating, string phase05QualatativeDietPlayerRating, string phase05QuantativeDietPlayerRating, string phase05EnergyActualPlayerRating, string phase05BodyWeightPlayerRating, string phase06Part01PlayerRating, string phase06EvidencePlayerRating, string phase07SelectionRating, string phase07FoodStrategiesRating, string phase07EducationalStrategiesRating, string phase08OverallGoalPlayerRating)
        {
            WWWForm newForm = new WWWForm();
            newForm.AddField("name", username);
            newForm.AddField("phase02BiochemicalPlayerRating", phase02BiochemicalPlayerRating);
            newForm.AddField("phase02BiochemicalWhyPlayerRating", phase02BiochemicalWhyPlayerRating);
            newForm.AddField("phase02MedicationPlayerRating", phase02MedicationPlayerRating);
            newForm.AddField("phase02MedicalHistoryPlayerRating", phase02MedicalHistoryPlayerRating);
            newForm.AddField("phase02AnthropometryPlayerRating", phase02AnthropometryPlayerRating);
            newForm.AddField("phase03ParsingPlayerRating", phase03ParsingPlayerRating);
            newForm.AddField("phase04ExamPlayerRating", phase04ExamPlayerRating);
            newForm.AddField("phase05QualatativeDietPlayerRating", phase05QualatativeDietPlayerRating);
            newForm.AddField("phase05QuantativeDietPlayerRating", phase05QuantativeDietPlayerRating);
            newForm.AddField("phase05EnergyActualPlayerRating", phase05EnergyActualPlayerRating);
            newForm.AddField("phase05BodyWeightPlayerRating", phase05BodyWeightPlayerRating);
            newForm.AddField("phase06Part01PlayerRating", phase06Part01PlayerRating);
            newForm.AddField("phase06EvidencePlayerRating", phase06EvidencePlayerRating);
            newForm.AddField("phase07SelectionRating", phase07SelectionRating);
            newForm.AddField("phase07FoodStrategiesRating", phase07FoodStrategiesRating);
            newForm.AddField("phase07EducationalStrategiesRating", phase07EducationalStrategiesRating);
            newForm.AddField("phase08OverallGoalPlayerRating", phase08OverallGoalPlayerRating);

            WWW w = new WWW(LoginSystem.Settings.serverAddress + "/" + LoginSystem.Settings.addPlayerRatingInfo, newForm);

            while (!w.isDone)
            {
                yield return new WaitForEndOfFrame();
            }
        }
        /// <summary>
        /// Recovers the password.
        /// </summary>
        /// <param name="email">Email.</param>
        public static void RecoverPassword(string email)
        {
            if (LoginSystem.current != null)
            {
                LoginSystem.current.StartCoroutine(RecoverPasswordInternal(email));
            }
        }

        private static IEnumerator RecoverPasswordInternal(string email)
        {
            if (LoginSystem.Settings == null)
            {
                EventHandler.Execute("OnFailedToRecoverPassword");
                yield break;
            }

            LoginSystem.logger.LogInfo("[RecoverPassword] Trying to recover password using email: " + email + "!");

            WWWForm newForm = new WWWForm();
            newForm.AddField("email", email);

            WWW w = new WWW(LoginSystem.Settings.serverAddress + "/" + LoginSystem.Settings.recoverPassword, newForm);

            while (!w.isDone)
            {
                yield return new WaitForEndOfFrame();
            }

            if (w.error != null)
            {
                Debug.LogError(w.error);
            }

            bool res = w.text.Trim().Equals("true");
            if (res)
            {
                EventHandler.Execute("OnPasswordRecovered");
                LoginSystem.logger.LogInfo("[RecoverPassword] Password recovered successfull!");
            }
            else
            {
                LoginSystem.logger.LogInfo("[RecoverPassword] Failed to recover password. Result: " + w.text);
                EventHandler.Execute("OnFailedToRecoverPassword");
            }
        }

        /// <summary>
        /// Resets the password.
        /// </summary>
        /// <param name="username">Username.</param>
        /// <param name="password">Password.</param>
        public static void ResetPassword(string username, string password)
        {
            if (LoginSystem.current != null)
            {
                LoginSystem.current.StartCoroutine(ResetPasswordInternal(username, password));
            }
        }

        private static IEnumerator ResetPasswordInternal(string username, string password)
        {
            if (LoginSystem.Settings == null)
            {
                EventHandler.Execute("OnFailedToResetPassword");
                yield break;
            }

            LoginSystem.logger.LogInfo("[ResetPassword] Trying to reset password using username: " + username + " and password: " + password + "!");

            WWWForm newForm = new WWWForm();
            newForm.AddField("name", username);
            newForm.AddField("password", password);

            WWW w = new WWW(LoginSystem.Settings.serverAddress + "/" + LoginSystem.Settings.resetPassword, newForm);

            while (!w.isDone)
            {
                yield return new WaitForEndOfFrame();
            }

            if (w.error != null)
            {
                Debug.LogError(w.error);
            }

            bool res = w.text.Trim().Equals("true");
            if (res)
            {
                EventHandler.Execute("OnPasswordResetted");
            }
            else
            {
                LoginSystem.logger.LogInfo("Failed to reset password. Result: " + w.text);
                EventHandler.Execute("OnFailedToResetPassword");
            }
        }

        /// <summary>
        /// Validates the email.
        /// </summary>
        /// <returns><c>true</c>, if email was validated, <c>false</c> otherwise.</returns>
        /// <param name="email">Email.</param>
        public static bool ValidateEmail(string email)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            System.Text.RegularExpressions.Match match = regex.Match(email);
            if (match.Success)
            {
                LoginSystem.logger.LogInfo("Email validated was successfull for email: " + email + "!");
            }
            else
            {
                LoginSystem.logger.LogInfo("Email validation failed for email: " + email + "!");
            }

            return match.Success;
        }
    }
}