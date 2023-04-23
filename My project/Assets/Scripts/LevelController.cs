using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        try
        {
            SceneManager.UnloadSceneAsync("MainMenu");
        }
        catch (Exception ex)
        {

        }
        try
        { 
            SceneManager.UnloadSceneAsync("LoseMenu");
        }
        catch (Exception ex)
        {

        }
    }
}
