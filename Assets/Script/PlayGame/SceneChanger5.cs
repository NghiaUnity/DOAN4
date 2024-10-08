using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline; // Thêm dòng này để quản lý cảnh

public class SceneChanger1 : MonoBehaviour
{
    // Hàm này sẽ được gọi khi nhấn nút
    public void ChangeScene5(string Market)
    {
        // Chuyển đến cảnh mới
        SceneManager.LoadScene(Market);
    }
}
