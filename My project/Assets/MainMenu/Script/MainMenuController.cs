using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void onClickNext()
    {
        try
        {
            var currentLevelNum = LevelDataHolder.Instance.GetCurrentLevel();

            currentLevelNum++;

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
