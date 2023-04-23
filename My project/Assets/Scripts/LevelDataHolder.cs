using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDataHolder : MonoBehaviour
{
    private int LastLevel;
    private int CurrentLevel;
    public static LevelDataHolder Instance { get; private set; }
    private void Awake()
    {
        Initialize();
    }
    private void Update()
    {
        Debug.Log($"Last:{LastLevel}, Cur:{CurrentLevel}");
    }
    public int GetLastLevel()
    {
        return LastLevel;
    }
    public int GetCurrentLevel()
    {
        return CurrentLevel;
    }
    public void SetCurrentLevel(int levelNum)
    {
        LastLevel = CurrentLevel;
        CurrentLevel = levelNum;
    }

    private void Initialize()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        DontDestroyOnLoad(Instance);
    }
}
