using UnityEngine;
using System.Collections;

public class PlayRandomAmbience : MonoBehaviour {

    public AudioClip[] sounds;
    public AudioSource soundPlayer;

    // Use this for initialization
    void Start()
    {
        PlayNextSound();
    }

    // Update is called once per frame
    void Update () {
	
	}

    void PlayNextSound() {
        int randomSound = Random.Range(0, 25);
        if (randomSound < sounds.Length)
        {
            soundPlayer.clip = sounds[randomSound];
            soundPlayer.Play();
        }
        Invoke("PlayNextSound", soundPlayer.clip.length);

    }
}
