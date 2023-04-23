using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerController : MonoBehaviour
{
    public static SceneManagerController Instance { get; private set; }
    public KeyValuePair<string, string> sceneNameKeyValue;

    [System.Obsolete]
    private void Start()
    {
        Initialize();
        SceneManager.LoadScene("MainMenu");
    }
    [System.Obsolete]
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            sceneNameKeyValue = new KeyValuePair<string, string>($"Level_{LevelDataHolder.Instance.GetCurrentLevel()}_1", $"Level_{LevelDataHolder.Instance.GetCurrentLevel()}_2");
            if (SceneManager.GetAllScenes().Any(s => s.name == sceneNameKeyValue.Key))
            {
                SceneManager.UnloadSceneAsync(sceneNameKeyValue.Key, UnloadSceneOptions.None);
                SceneManager.LoadScene(sceneNameKeyValue.Value, LoadSceneMode.Additive);
            }
            else if (SceneManager.GetAllScenes().Any(s => s.name == sceneNameKeyValue.Value))
            {
                SceneManager.UnloadSceneAsync(sceneNameKeyValue.Value, UnloadSceneOptions.None);
                SceneManager.LoadScene(sceneNameKeyValue.Key, LoadSceneMode.Additive);
            }
        }
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
