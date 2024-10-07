using UnityEngine;
using UnityEngine.SceneManagement; // Thêm dòng này để quản lý cảnh

public class SceneChanger2 : MonoBehaviour
{
    // Hàm này sẽ được gọi khi nhấn nút
    public void ChangeScene(string TrangcaNhan)
    {
        // Chuyển đến cảnh mới
        SceneManager.LoadScene(TrangcaNhan);
    }
}
