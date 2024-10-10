using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger6_V2 : MonoBehaviour
{
    public void ChangeScene(string PlayGame)
    {
        SceneManager.LoadScene(PlayGame);
    }
}
