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
    public static void LoadGame()
    {
        Debug.Log("Game main screen note");
        SceneManager.LoadScene("Level1"); // Level 1 is the second scene.
    }
    public static void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public static void GoToGameOver()
    {
        Debug.Log("This would take you to the Game Over screen... IF IT WOULD WORK!!!");
        SceneManager.LoadScene("GameOver");
    }
    public static void GoToReading()
    {
        Debug.Log("Reading screen note");
        SceneManager.LoadScene("Reading");
        // This is a placeholder until I add a Reading scene.
    }
    public static void QuitGame()
    {
        Debug.Log("Quit screen note");
        Debug.Log("You are quitting now.");
        Application.Quit();
    }
}
