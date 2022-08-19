using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
            Destroy(gameObject);
    }
    public void LoadScene(string sceneName) => SceneManager.LoadScene(sceneName);
    public void LoadFPSScene() => SceneManager.LoadScene(SceneNames.FPSScene);
    public void LoadDanceScene() => SceneManager.LoadScene(SceneNames.DanceScene);
}
