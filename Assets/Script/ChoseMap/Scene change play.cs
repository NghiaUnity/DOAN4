﻿using UnityEngine;
using UnityEngine.SceneManagement; // Thêm dòng này để quản lý cảnh

public class Scenechangeplay : MonoBehaviour
{
    // Hàm này sẽ được gọi khi nhấn nút
    public void ChangeScene(string SampleScene)
    {
        // Chuyển đến cảnh mới
        SceneManager.LoadScene(SampleScene);
    }

}
