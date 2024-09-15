using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/QAConfig", order = 1)]
public class QAConfig : ScriptableObject
{
    public List<QuestionAndAnswer> QandAs;
}

[Serializable]

public class QuestionAndAnswer{
    public int id;
    public string question;
    public List<AnswerConfig> ans;
    public string des;

}

[Serializable]
public class AnswerConfig{
    public string id;
    public string ans;
    public bool isCorrectAns;
    }
