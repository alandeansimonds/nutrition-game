using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ImportText : MonoBehaviour {

    public Text musicCreditsText;
    public TextAsset musicCreditsTextAsset;
	
    // Use this for initialization
	void Start () {
        musicCreditsText.text = musicCreditsTextAsset.text;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
