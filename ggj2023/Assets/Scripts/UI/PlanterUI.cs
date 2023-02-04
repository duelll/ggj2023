using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanterUI : MonoBehaviour
{

    public Sprite potatoOld;
    public Sprite potatoNew;

    public struct seed
    {
        public string type;
        public float timer;
        public Sprite oldImage;
        public Sprite newImage;
    }

    public enum plant
    {
        potato,
        carrot,
        cabbage
    }

    // Start is called before the first frame update
    void Start()
    {
        seed Potato;
        Potato.type = setType();
        Potato.timer = 20f;
        Potato.oldImage = potatoOld;
        Potato.newImage = potatoNew;
    }

    string setType()
    {
        return "a";
    }

    void updateImage(Sprite image)
    {

    }
}
