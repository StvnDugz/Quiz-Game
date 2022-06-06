using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour
{

    public Text answerText;

    private AnswerData answerData;

    // Use this for initialization
    void Start()
    {

    }

    public void Setup(AnswerData data)
    {
        answerData = data;
        answerText.text = answerData.answerText;
    }
}