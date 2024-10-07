using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Thêm SceneManagement để sử dụng SceneManager

public class NewBehaviourScript : MonoBehaviour
{
    public Button Traodoitrangbi; // Nút button mà bạn muốn gán sự kiện

    void Start()
    {
        // Gắn sự kiện cho button "Traodoitrangbi"
        Traodoitrangbi.onClick.AddListener(OnCloseButtonClick);
    }

    // Hàm xử lý khi nhấn nút
    void OnCloseButtonClick()
    {
        // Chuyển đến scene có tên "TrangcaNhan"
        SceneManager.LoadScene("TrangcaNhan");
    }
}
