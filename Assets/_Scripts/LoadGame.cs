using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public AudioSource soundManager;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("LoadNextLevel");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator LoadNextLevel()
    {
        yield return new WaitForSeconds(4);
        soundManager.Play();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }
}
