using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class LoadingScreen : MonoBehaviour
{
    public Slider loadingBar;

    void Start()
    {
        StartCoroutine(LoadAsynchronously("MainScene"));
    }

    IEnumerator LoadAsynchronously(string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);

        while (!operation.isDone)
        {
            // Cập nhật giá trị của thanh tiến trình (progress bar)
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            loadingBar.value = progress;
            yield return null;
        }
    }
}
