using UnityEngine;
using UnityEngine.SceneManagement; // Thêm dòng này để quản lý cảnh

public class SceneChanger3 : MonoBehaviour
{
    // Hàm này sẽ được gọi khi nhấn nút
    public void ChangeScene(string ChoseMap)
    {
        // Chuyển đến cảnh mới
        SceneManager.LoadScene(ChoseMap);
    }
}
