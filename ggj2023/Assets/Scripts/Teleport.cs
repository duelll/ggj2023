using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject doorway;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

   private void OnTriggerEnter2D(Collider2D collision)
   {
        if(collision.tag == "Player")
     {
        player.transform.position = new Vector2(doorway.transform.position.x, doorway.transform.position.y);
     }
   }
}
