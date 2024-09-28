using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TriggerSystem : MonoBehaviour
{
    public static TriggerSystem instance;

    public QAConfig nghiaConfig;
    public QAConfig yenConfig;

    private void Awake() {
        if (instance == null) {
            instance = this;
        }else
        {
            Destroy(this);
        }
    }

    public void OnQuestionTriggered(int questionId, QAType qAType) {
        QAConfig selectedConfig = qAType == QAType.Yen ? yenConfig : nghiaConfig;
        QuestionAndAnswer question = selectedConfig.QandAs.Find(q => q.id == questionId);

        if (question != null) {
            Debug.Log("Question: " + question.question);
            foreach (var answer in question.ans) {
                Debug.Log("Answer: " + answer.ans + " | Correct: " + answer.isCorrectAns);
            }
        } else {
            Debug.Log("Question not found!");
        }
    }
}
