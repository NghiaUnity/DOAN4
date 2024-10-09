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
    
    public Image correctImage; 
    public Image incorrectImage; 
    public float displayDistance = 5f;

    public QuizGame quizGame;

    private bool isGuideButtonActive = false;
    private bool isUIPanelOpen = false;
    private bool questionAnswered = false; 

    void Start()
    {
        guideButton.SetActive(false);
        uiPanel.SetActive(false);
        correctImage.gameObject.SetActive(false); 
        incorrectImage.gameObject.SetActive(false); 
        closeButton.onClick.AddListener(CloseUIPanel); 
        buttonA.onClick.AddListener(ShowCorrect);
        buttonB.onClick.AddListener(ShowIncorrect);
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
        
        uiPanel.SetActive(true);
        isUIPanelOpen = true;
    }

    void CloseUIPanel()
    {
        
        uiPanel.SetActive(false);
        isUIPanelOpen = false; 
        correctImage.gameObject.SetActive(false);
        incorrectImage.gameObject.SetActive(false); 
    }

    void ShowCorrect()
    {
        
        correctImage.gameObject.SetActive(true); 

        questionAnswered = true;
        Invoke("CloseUIPanel", 2f);
    }

    void ShowIncorrect()
    {
        
        incorrectImage.gameObject.SetActive(true); 
        questionAnswered = true; 
        Invoke("CloseUIPanel", 2f); 
    }
}
