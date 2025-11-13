using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestionManager : MonoBehaviour
{
    public string[] m_Questions;
    public string[] m_CorrectAnswers;

    public TextMeshProUGUI m_QuestionText;
    public TMP_InputField m_inputField;

    private int m_CurrentQuestion = 0; 

    public void getQuestion(int questionNumber)
    {
        m_QuestionText.text = m_Questions[questionNumber-1];
    }

    public void checkAnswer()
    {
        if(m_inputField.text == m_CorrectAnswers[0])
        {
            Debug.Log("it worked");
            SceneManager.LoadScene("Victory");


        }
    }
}
