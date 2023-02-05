using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Inventory inventory;


    private void OnTriggerStay2D(Collider2D collision)
    {
        inventory.addPotato();
        Destroy(gameObject);
    }

}
