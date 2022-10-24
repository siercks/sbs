using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public LevelManager()
    {
        //
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("Level1"); // Level 1 is the second scene.
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void GoToGameOver()
    {
        Debug.Log("This would take you to the Game Over screen... IF IT WOULD WORK!!!");
        //SceneManager.LoadScene("GameOver");
    }
    public void GoToReading()
    {
        Debug.Log("This is a placeholder until I add a Reading scene.");
        // This is a placeholder until I add a Reading scene.
    }
    public void QuitGame()
    {
        Debug.Log("You are quitting now.");
        Application.Quit();
    }
}
