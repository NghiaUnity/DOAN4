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

    public void OnQuestionTriggered(int questionId){
        Debug.Log("Question triggered: " + questionId);
        // Xu li cau hoi o day

    }
}
