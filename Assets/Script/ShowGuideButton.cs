using UnityEngine;
using UnityEngine.UI;

public class ShowGuideButton : MonoBehaviour
{
    public Transform player;
    public Transform itemBox;
    public GameObject guideButton;
    public GameObject uiPanel;
    public Button closeButton; 
    public Button buttonA; 
    public Button buttonB; 
    public Button buttonC;
    public Button buttonD;
    public Text resultText; 
    public float displayDistance = 5f;

    private bool isGuideButtonActive = false;
    private bool isUIPanelOpen = false;
    private bool questionAnswered = false; 

    void Start()
    {
        guideButton.SetActive(false);
        uiPanel.SetActive(false);
        closeButton.onClick.AddListener(CloseUIPanel); 
        buttonA.onClick.AddListener(ShowCorrect);  // Chính xác
        buttonB.onClick.AddListener(ShowIncorrect); // Sai
        buttonD.onClick.AddListener(ShowIncorrect);
        buttonC.onClick.AddListener(ShowIncorrect);
    }

    void Update()
    {
        float distance = Vector3.Distance(player.position, itemBox.position);
        if (distance <= displayDistance)
        {
            guideButton.SetActive(true);
            isGuideButtonActive = true;
        }
        else
        {
            guideButton.SetActive(false);
            isGuideButtonActive = false;
        }

        if (isGuideButtonActive && Input.GetKeyDown(KeyCode.E) && !isUIPanelOpen && !questionAnswered)
        {
            OpenItemBox();
        }

        if (isUIPanelOpen && Input.GetKeyDown(KeyCode.Escape))
        {
            CloseUIPanel();
        }
    }

    void OpenItemBox()
    {
        Debug.Log("Mở câu hỏi ????");
        uiPanel.SetActive(true);
        isUIPanelOpen = true;
    }

    void CloseUIPanel()
    {
        Debug.Log("Đóng câu hỏi !!!");
        uiPanel.SetActive(false);
        isUIPanelOpen = false; 
    }

    void ShowCorrect()
    {
        resultText.text = "KHÔN GẦN = ĐẠT";
        questionAnswered = true;
        Invoke("CloseUIPanel", 2f);
    }

    void ShowIncorrect()
    {
        resultText.text = "NGU NHƯ THẰNG NGHĨA"; 
        questionAnswered = true; 
        Invoke("CloseUIPanel", 2f); 
    }
}
