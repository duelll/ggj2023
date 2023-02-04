using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    public string scene;

    void Start()
    {
        
    }

    public void Button start()
    {
        SceneManager.LoadScene(scene);
    }
}
