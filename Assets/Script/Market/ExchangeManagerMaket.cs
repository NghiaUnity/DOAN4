using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class ExchangeManagerMaket : MonoBehaviour
{
    public GameObject confirmationPanel; // Panel chứa nút "Có" và "Không"
    public Button yesButton;             // Nút "Có"
    public Button noButton;              // Nút "Không"
    public GameObject Pannel;            // Panel chứa thông báo "Trao đổi thành công"
    public Button X;                     // Nút "X"

    void Start()
    {
        // Gắn sự kiện cho button "Có"
        yesButton.onClick.AddListener(OnYesButtonClick);

        // Gắn sự kiện cho button "Không"
        noButton.onClick.AddListener(OnNoButtonClick);

        // Gắn sự kiện cho button "X"
        X.onClick.AddListener(OnCloseButtonClick);

        // Đảm bảo ban đầu Panel chứa thông báo bị ẩn
        Pannel.SetActive(false);
    }

    // Hàm xử lý khi nhấn nút "Có"
    void OnYesButtonClick()
    {
        // Ẩn panel xác nhận
        confirmationPanel.SetActive(false);

        // Hiển thị thông báo "Trao đổi thành công"
        Pannel.SetActive(true); // Bật Panel chứa thông báo

        // Bắt đầu quá trình đợi và chuyển cảnh sau khi hiển thị thông báo
        OnExchangeSuccess();
    }

    // Hàm xử lý khi nhấn nút "Không"
    void OnNoButtonClick()
    {
        // Ẩn panel xác nhận nếu cần
        confirmationPanel.SetActive(false);
    }
    
    // Hàm được gọi khi trao đổi thành công
    public void OnExchangeSuccess()
    {
        Debug.Log("Trao đổi thành công!");
        
        // Bắt đầu Coroutine để đợi và chuyển cảnh sau 1 giây
        StartCoroutine(WaitAndLoadScene(1f)); // Đợi 1 giây
    }

    // Coroutine để chờ một khoảng thời gian nhất định rồi chuyển cảnh
    IEnumerator WaitAndLoadScene(float waitTime)
    {
        yield return new WaitForSeconds(waitTime); // Đợi trong khoảng thời gian chỉ định
        SceneManager.LoadScene("Market"); // Chuyển đến cảnh chính
    }

    // Hàm xử lý khi nhấn nút "X"
    void OnCloseButtonClick()
    {
        // Quay lại scene cũ
        SceneManager.LoadScene("PlayGame");
    }
}
