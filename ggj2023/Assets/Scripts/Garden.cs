using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garden : MonoBehaviour
{
    public PlanterUI UIData;
    public Inventory playerInventory;
    public GameObject oldImage;
    public GameObject newImage;
    public GameObject text;

    private bool growFlag = false;
    private bool grownPlant = false;
    private float countdown = 0.0f;

    void Awake()
    {
        UIData = GameObject.FindAnyObjectByType<PlanterUI>();
        playerInventory = GameObject.FindAnyObjectByType<Inventory>();
        text.SetActive(false);
        oldImage.SetActive(false);
        newImage.SetActive(false);
    }

    private void Update()
    {
        grow();
        if(growFlag)
        {
            countdown -= Time.deltaTime;
            if(countdown <= 0.0)
            {
                Debug.Log("Swap");
                growFlag = !growFlag;
                updateImage();
            }
        }
    }

    void grow()
    {
        //Debug.Log("grow func");
        if(UIData.seedType == 0 && !growFlag)
        {
            Debug.Log("Countdown...");
            oldImage.SetActive(true);
            growFlag = !growFlag;
            countdown = UIData.timer;

        }

        if (UIData.seedType < -1)
        {
            updateImage();
        }
    }

    void updateImage()
    {
        oldImage.SetActive(false);
        newImage.SetActive(true);
        grownPlant = !grownPlant;
        UIData.resetSeed();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(!growFlag)
        {
            text.SetActive(true);
        }

        if (grownPlant)
        {
            grownPlant = !grownPlant;
            playerInventory.addPotato();
            newImage.SetActive(false);
        }
        
        Debug.Log("touched planter");
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        text.SetActive(false);
    }
}
