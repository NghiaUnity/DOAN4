using UnityEngine;
using UnityEngine.SceneManagement; // Thêm dòng này để quản lý cảnh

public class SceneChanger : MonoBehaviour
{
    // Hàm này sẽ được gọi khi nhấn nút
    public void ChangeScene(string TraoDoiTrangbi)
    {
        // Chuyển đến cảnh mới
        SceneManager.LoadScene(TraoDoiTrangbi);
    }
}
