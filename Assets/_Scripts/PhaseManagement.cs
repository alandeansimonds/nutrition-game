using UnityEngine;
using System.Collections;

public class PhaseManagement : MonoBehaviour {
    
    public static int gamePhase = 1;

    // Used to indicate whether a new game should be loaded.
    // (Instead of checking the database for existing game state.)
    public static bool forceNewGame = false;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
