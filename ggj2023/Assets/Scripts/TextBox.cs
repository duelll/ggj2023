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
    void OnTriggerStay2D(Collision2D collider)
    {
        text.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        text.SetActive(false);
    }

}
