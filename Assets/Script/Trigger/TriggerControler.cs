using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum QAType{
    Yen,
    Nghia
}
public class TriggerControler : MonoBehaviour
{
    public int questionId;
    public QAType qAtype;
    
    public void Trigger(){
        TriggerSystem.instance.OnQuestionTriggered(questionId, qAtype);
    }

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            Debug.Log("Trigger entered by: " + other.name);
        Trigger();
        }
    }

}
