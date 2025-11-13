using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AnswerManager : MonoBehaviour
{
    public string m_AnswerText;
    public TextMeshProUGUI m_WorldText;

    public QuestionManager m_QuestionManagerRef; 
    // Start is called before the first frame update
    void Start()
    {
        if(m_WorldText == null)
        {
            m_WorldText.text = m_AnswerText;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if(collision.CompareTag("Player"))
    //    {

    //        if (correct)
    //        {
    //            GetComponen
    //            Debug.Log("Player chose the right answer");
    //        }
    //        else
    //        {
    //            Debug.Log("Player chose the wrong answer");
    //        }
    //    }
    //}
}
