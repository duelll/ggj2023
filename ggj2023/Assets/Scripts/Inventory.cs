using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int potatoSeed;
    public int tomatoSeed;
    public int cabbageSeed;

    // Start is called before the first frame update
    void Start()
    {
        potatoSeed = 0;
        tomatoSeed = 0;
        cabbageSeed = 0;
    }

    public void addPotato()
    {
        potatoSeed++;
        Debug.Log("added potato. You have: " + potatoSeed.ToString());
    }

    public void removePotato()
    {
        potatoSeed--;
        Debug.Log("removed potato. You have: " + potatoSeed.ToString());
    }
}
