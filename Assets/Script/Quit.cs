using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    public GameObject pauseMenuPanel; // Panel chứa các button "Save game", "Quit", "Close"
    public GameObject confirmationPanel; // Panel xác nhận
    public Button pauseButton; // Button "Pause"
    public Button saveButton; // Button "Save game"
    public Button quitButton; // Button "Quit"
    public Button closeButton; // Button "Close"
    public Button yesButton; // Button "Có"
    public Button noButton; // Button "Không"

    void Start()
    {
        // Ẩn các panel khi bắt đầu
        pauseMenuPanel.SetActive(false);
        confirmationPanel.SetActive(false);

        // Gán sự kiện cho các button
        pauseButton.onClick.AddListener(ShowPauseMenu);
        saveButton.onClick.AddListener(SaveGame);
        quitButton.onClick.AddListener(ShowConfirmationPanel);
        closeButton.onClick.AddListener(ClosePauseMenu);
        yesButton.onClick.AddListener(OnYesButtonClicked);
        noButton.onClick.AddListener(OnNoButtonClicked);
    }

    void ShowPauseMenu()
    {
        pauseMenuPanel.SetActive(true);
    }

    void SaveGame()
    {
        // Thêm logic lưu game tại đây
        Debug.Log("Game đã được lưu!");
    }

    void ShowConfirmationPanel()
    {
        confirmationPanel.SetActive(true);
    }

    void ClosePauseMenu()
    {
        pauseMenuPanel.SetActive(false);
    }

    void OnYesButtonClicked()
    {
        SceneManager.LoadScene("PlayGame");
    }

    void OnNoButtonClicked()
    {
        confirmationPanel.SetActive(false);
    }
}
