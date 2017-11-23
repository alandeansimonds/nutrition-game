using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Unitycoding.LoginSystem{
	
	public class SendPhase02BiochemicalWhyToDB : MonoBehaviour {

		[SerializeField]
		private MenuOptions menuOptions;

		[SerializeField]
		private Button sendInfoButton;

		[SerializeField]
		private InputField phase02BiochemicalWhyInputBox;

		[SerializeField]
		private Button sendPlayerRatingsInfoButton;

		private string phase02BiochemicalWhyInputBoxSavedText;

		// Use this for initialization
		void Start () {
			string username = PlayerPrefs.GetString ("username");
			sendInfoButton.onClick.AddListener (delegate{
				LoginSystem.SendPhase2BiochemicalWhyInfo(username, phase02BiochemicalWhyInputBoxSavedText);
			});
			sendPlayerRatingsInfoButton.onClick.AddListener (delegate {
				LoginSystem.SendPlayerRatingInfo (username, menuOptions.phase02BiochemicalPlayerRating, menuOptions.phase02BiochemicalWhyPlayerRating, menuOptions.phase02MedicationPlayerRating, menuOptions.phase02MedicalHistoryPlayerRating, menuOptions.phase02AnthropometryPlayerRating, menuOptions.phase03ParsingPlayerRating, menuOptions.phase04ExamPlayerRating, menuOptions.phase05QualatativeDietPlayerRating, menuOptions.phase05QuantativeDietPlayerRating, menuOptions.phase05EnergyActualPlayerRating, menuOptions.phase05BodyWeightPlayerRating, menuOptions.phase06Part01PlayerRating, menuOptions.phase06EvidencePlayerRating, menuOptions.phase07SelectionRating, menuOptions.phase07FoodStrategiesRating, menuOptions.phase07EducationalStrategiesRating, menuOptions.phase08OverallGoalPlayerRating);
			});
		}

		// Update is called once per frame
		void Update () {

		}

		public void SavePhase02BiochemicalWhyInputBoxText() {
			phase02BiochemicalWhyInputBoxSavedText = phase02BiochemicalWhyInputBox.text;
		}
	}	
}