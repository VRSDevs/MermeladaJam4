using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class LevelManager
{
    public static void GoToLogin()
    {
        SceneManager.LoadScene("Login");
        
    }
    public static void GoToMainMenu()
    {
        SceneManager.LoadScene("Inicio");
    }

    public static void GoToSceneName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    

}
