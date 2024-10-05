using UnityEngine;
using UnityEngine.UI;

public class ExchangeManager : MonoBehaviour
{
    public GameObject confirmationPanel; // Panel chứa nút "Có" và "Không"
    public Button yesButton;             // Nút "Có"
    public Button noButton;              // Nút "Không"
    public GameObject Pannel;            // Panel chứa thông báo "Trao đổi thành công"

    void Start()
    {
        // Gắn sự kiện cho button "Có"
        yesButton.onClick.AddListener(OnYesButtonClick);

        // Gắn sự kiện cho button "Không"
        noButton.onClick.AddListener(OnNoButtonClick);

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
    }

    // Hàm xử lý khi nhấn nút "Không"
    void OnNoButtonClick()
    {
        // Ẩn panel xác nhận nếu cần
        confirmationPanel.SetActive(false);
    }
    
}
