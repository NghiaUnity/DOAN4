using UnityEngine;
using UnityEngine.SceneManagement; // Thêm dòng này để quản lý cảnh

public class SceneChanger6 : MonoBehaviour
{
    // Hàm này sẽ được gọi khi nhấn nút
    public void ChangeScene(string PlayGame)
    {
        // Chuyển đến cảnh mới
        SceneManager.LoadScene(PlayGame);
    }
}
