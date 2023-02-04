using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garden : MonoBehaviour
{
    //public struct seed
    //{
    //    public string type;
    //    public float growTime;
    //    public Sprite;
    //};

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("eee");

        if (collision.tag == "planter")
        {
            Debug.Log("wonk");
            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("wonkaa");
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "planter")
        {
            Debug.Log("wonk");
            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("wonkaa");
            }
        }
        
    }
}
