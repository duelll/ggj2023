using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBox : MonoBehaviour
{
    public GameObject text;
   
   
    void Start()
    {
        text.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        text.SetActive(true);
        Debug.Log("test");
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        text.SetActive(false);
    }

}
