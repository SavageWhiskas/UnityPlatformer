using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;


public class SignScript : MonoBehaviour
{
    private bool playerEntered  = false;
    public GameObject questionPanel; 
    // Start is called before the first frame update
    void Start()
    {
        questionPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerEntered && Input.GetKeyDown(KeyCode.E))
        {

            questionPanel.SetActive(!questionPanel.activeSelf);
            Debug.Log("Player opened sign");



        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerEntered = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerEntered = false;
            questionPanel.SetActive(false);
        }
    }





}


   

    
  
    

