using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class ExtraMenuOptions : MonoBehaviour {

	public Text copyrightText;
	public string companyNameTextString;
	public string urlString;
	public InputField playerNameInput;
	public static string playerUsernameStatic;

    // Use this for initialization
    void Start () {
		if (copyrightText != null) {
			copyrightText.text = companyNameTextString + " © "+ System.DateTime.Now.Year.ToString();
		}	 
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void OpenExternalLink () {
		Application.OpenURL(urlString);
	}

	public void SetPlayerUsername () {
		playerUsernameStatic = playerNameInput.text;
	}
}
