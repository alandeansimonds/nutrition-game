using System.Collections;
using UnityEngine;

public class addPhase02BiochemicalNotesTextToDB : MonoBehaviour {

	private string secretKey = "PineappleApplePen";
	public string addNotesURL = "http://www.mediocritygames.com/php/addScores.php?";
	public string playerUsername;
	public string phase02BiochemicalNotesString;

//	// Use this for initialization
//	void Start () {
//		playerUsername = MD5SUMStatic.playerUsernameStatic;
//	}
//	
//	IEnumerator PostScores(string user_name, string phase02BiochemicalNotesText)
//	{
//		//This connects to a server side php script that will add the name and score to a MySQL DB.
//		// Supply it with a string representing the players name and the players score.
//		string hash = MD5SUMStatic.Md5Sum(user_name + phase02BiochemicalNotesText + secretKey);
//
//		string post_url = addNotesURL + "user_name=" + WWW.EscapeURL(user_name) + "&phase02BiochemicalNotesText=" + WWW.EscapeURL(phase02BiochemicalNotesText) + "&hash=" + hash;
//
//		// Post the URL to the site and create a download object to get the result.
//		WWW hs_post = new WWW(post_url);
//		yield return hs_post; // Wait until the download is done
//
//		if (hs_post.error != null)
//		{
//			print("There was an error posting the information to the database: " + hs_post.error);
//		}
//	}
//
//	public void PostNotes() {
//	
//		StartCoroutine (PostScores(playerUsername, phase02BiochemicalNotesString));	
//	}
}
