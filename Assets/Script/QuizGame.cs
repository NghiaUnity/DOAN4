using UnityEngine;
using UnityEngine.UI;

public class QuizGame : MonoBehaviour
{
    public Image gameOverImage;
    public Image youWinImage;
    public Text timerText;
    public Text correctAnswersText;
    public int totalQuestions = 8;
    public int correctAnswersRequired = 6;
    public float timeLimit = 600f;

    private int correctAnswers = 0;
    private float timeRemaining;
    private bool gameEnded = false;

    void Start()
    {
        timeRemaining = timeLimit;
        gameOverImage.gameObject.SetActive(false);
        youWinImage.gameObject.SetActive(false);
        UpdateCorrectAnswersText();
    }

    void Update()
    {
        if (gameEnded) return;

        timeRemaining -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (timeRemaining <= 0)
        {
            timeRemaining = 0;
            EndGame();
        }
    }

    public void AnswerQuestion(bool isCorrect)
    {
        if (isCorrect)
        {
            correctAnswers++;
            UpdateCorrectAnswersText();

            if (correctAnswers == totalQuestions)
            {
                ShowYouWin();
            }
        }
    }

    void EndGame()
    {
        gameEnded = true;
        timerText.gameObject.SetActive(false);
        if (correctAnswers < correctAnswersRequired)
        {
            ShowGameOver();
        }
    }

    void ShowGameOver()
    {
        gameOverImage.gameObject.SetActive(true);
    }

    void ShowYouWin()
    {
        youWinImage.gameObject.SetActive(true);
        Invoke("HideYouWin", 2f);
    }

    void HideYouWin()
    {
        youWinImage.gameObject.SetActive(false);
        gameEnded = true;
    }

    void UpdateCorrectAnswersText()
    {
        correctAnswersText.text = correctAnswers + "/" + totalQuestions;
    }
}
