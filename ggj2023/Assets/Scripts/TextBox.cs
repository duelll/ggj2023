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
    void OnCollisionStay2D(Collision2D collision)
    {
        text.SetActive(true);
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        text.SetActive(false);
    }

}
