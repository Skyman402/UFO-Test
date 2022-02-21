using UnityEngine;
using UnityEngine.SceneManagement;

 public static class SceneLoader
{ 
    public static void NextScene()
    {
        if(SceneManager.sceneCountInBuildSettings > SceneManager.GetActiveScene().buildIndex + 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            GameData.PointsCount = 0;
        }
        else
        {
           var screen = Resources.Load("VictoryScreen");
           Object.Instantiate(screen);
        }
    }

    public static void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GameData.PointsCount = 0;
    }
}
