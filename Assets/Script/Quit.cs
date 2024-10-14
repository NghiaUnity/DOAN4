using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    public GameObject pauseMenuPanel; 
    public GameObject confirmationPanel; 
    public Button pauseButton; 
    public Button saveButton; 
    public Button quitButton;
    public Button closeButton; 
    public Button yesButton; 
    public Button noButton; 

    void Start()
    {
        
        pauseMenuPanel.SetActive(false);
        confirmationPanel.SetActive(false);

        
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
