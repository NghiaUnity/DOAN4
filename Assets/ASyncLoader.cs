using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ASyncLoader : MonoBehaviour 
{
    [Header("Menu Screens")]
    [SerializeField] private GameObject loadingScreen;
    [SerializeField] private GameObject maninMenu;

    [Header("Slider")]
    [SerializeField] private Slider loadingSlider;

    public void LoadLevelBtn(string levelToload)
    {
        maninMenu.SetActive(false);
        loadingScreen.SetActive(true);

        StartCoroutine(LoadLevelASync(levelToload));

        //run the sync
    }

    IEnumerator LoadLevelASync(string levelToload)
    {
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(levelToload);

        while (!loadOperation.isDone)
        {
            float progressValue = Mathf.Clamp01(loadOperation.progress / 1f);
            loadingSlider.value = progressValue;
            Debug.Log("Loading progress: " + progressValue);

            yield return null;
        }
    }
}
