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
}
