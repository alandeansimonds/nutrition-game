using UnityEngine;
using System.Collections;

public class PlayMusic : MonoBehaviour {

    public AudioClip[] music;
    public AudioSource musicPlayer;

	// Use this for initialization
	void Start () {
        PlayNextSong();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void PlayNextSong() {
        int randomSong = Random.Range(0, music.Length);
        musicPlayer.clip = music[randomSong];
        musicPlayer.Play();
        Invoke("PlayNextSong", musicPlayer.clip.length);
    }
}
