using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanterUI : MonoBehaviour
{

    //public Sprite plantOld;
    //public Sprite plantNew;
    //public GameObject seedImage;
    [System.NonSerialized]    public int seedType = -1;
    [System.NonSerialized]    public string type = "null";
    [System.NonSerialized]    public float timer;

    //public struct seed
    //{
    //    public string type;
    //    public float timer;
    //    public Sprite oldImage;
    //    public Sprite newImage;
    //}

    //public enum plant
    //{
    //    potato,
    //    carrot,
    //    cabbage
    //}

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        //plant product = plant.potato;
        //seed plant;
        //plant.timer = 20f;
        //plant.oldImage = plantOld;
        //plant.newImage = plantNew;
    }


    public void getSeed(int _seedType)
    {

        string plant;
        switch (_seedType)
        {
            case 0:
                Debug.Log("am potat");
                plant = "potato";
                timer = 3f;
                break;
            case 1:
                plant = "carrot";
                timer = 20f;
                break;
            case 2:
                plant = "cabbage";
                timer = 30f;
                break;
            default:
                plant = "no plant";
                timer = 0f;
                break;
        }

        type = plant;
        seedType = _seedType;

        Debug.Log("seed is " + seedType.ToString());
    }
}
