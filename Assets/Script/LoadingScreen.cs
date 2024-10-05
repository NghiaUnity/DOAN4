using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections; // Cần thiết cho Coroutine

public class LoadingSceneController : MonoBehaviour
{
    private void Start()
    {
        // Gọi Coroutine để load scene
        StartCoroutine(LoadLoginSceneAfterDelay());
    }

    private IEnumerator LoadLoginSceneAfterDelay()
    {
        // Chờ 5 giây
        yield return new WaitForSeconds(5f);

        // Chuyển đến cảnh login
        SceneManager.LoadScene("Login"); 
    }
}
