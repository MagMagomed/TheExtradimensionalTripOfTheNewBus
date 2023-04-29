using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public TMP_Text textMesh;
    public TMP_Text textButton;
    private bool isWon;
    public void onClickNext()
    {
        try
        {
            if(isWon)
            {
                Application.Quit();
            }
            var currentLevelNum = LevelDataHolder.Instance.GetCurrentLevel();

            currentLevelNum++;
            LevelDataHolder.Instance.SetCurrentLevel(currentLevelNum);

            SceneManager.LoadScene($"Level_{currentLevelNum}_1", LoadSceneMode.Additive);
            SceneManager.LoadScene($"Level_{currentLevelNum}_Finish", LoadSceneMode.Additive);

            var nextScene = SceneManager.GetSceneByName($"Level_{currentLevelNum}_1");
            if (!nextScene.IsValid())
            {
                textMesh.text = "It's all. You've won. \nCongratulations!";
                textButton.text = "Exit";
                isWon = true;
                return;
            }

            SceneManager.LoadScene($"PlayerScene", LoadSceneMode.Additive);
        }
        catch (Exception ex)
        {
            Application.Quit();
        }
    }
}
