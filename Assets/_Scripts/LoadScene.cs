using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour {

    private int sceneNumber;
    [SerializeField]
    private Image loadingProgressImage;
    [SerializeField]
    private Text loadingText;
    [SerializeField]
    private GameObject anyKeyText;
    [SerializeField]
    private GameObject rotatingCircleImage;

    void Start() {
        StartCoroutine("AsynchronousLoad", 2);
        anyKeyText.SetActive(false);
    }

    IEnumerator AsynchronousLoad(int sceneNumber)
    {
        yield return null;

        AsyncOperation ao = SceneManager.LoadSceneAsync(sceneNumber);
        ao.allowSceneActivation = false;

        while (!ao.isDone)
        {
            // [0, 0.9] > [0, 1]
            float progress = Mathf.Clamp01(ao.progress / 0.9f);
            loadingProgressImage.fillAmount = ao.progress / 0.9f;
            Debug.Log("Loading progress: " + (progress * 100) + "%");

            // Loading completed
            if (ao.progress == 0.9f)
            {
                rotatingCircleImage.SetActive(false);
                loadingText.text = "LOADING COMPLETE";
                anyKeyText.SetActive(true);
                if (Input.anyKeyDown) {
                    ao.allowSceneActivation = true;
                }                    
            }

            yield return null;
        }
    }
}
