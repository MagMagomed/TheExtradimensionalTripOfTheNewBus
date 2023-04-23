using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseMenuController : MonoBehaviour
{
    public void OnClickRestart()
    {
        try
        {
            var currentLevelNum = LevelDataHolder.Instance.GetCurrentLevel();

            LevelDataHolder.Instance.SetCurrentLevel(currentLevelNum);
            SceneManager.LoadScene($"Level_{currentLevelNum}_1", LoadSceneMode.Additive);
            SceneManager.LoadScene($"Level_{currentLevelNum}_Finish", LoadSceneMode.Additive);
            SceneManager.LoadScene($"PlayerScene", LoadSceneMode.Additive);
        }
        catch (Exception ex)
        {
            Application.Quit();
        }
    }
}
