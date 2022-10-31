using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class LevelManager : MonoBehaviour
{
    //ScoreKeeper scoreKeeper;
    AudioScript audioScript;
    public static GameObject musicObject;
    public LevelManager()
    {
        //
    }
    void Awake()
    {
        audioScript = FindObjectOfType<AudioScript>();
        //scoreKeeper = FindObjectOfType<ScoreKeeper>(); // I had this in here but do I need it? Trying now.
        //audioScript.MainMenuMusic();
    }
    void Start()
    {
        Invoke ("GoToMainMenu", 5f);
    }

    public static void LoadGame()
    {
        SceneManager.LoadScene("Level1"); // Level 1 is the second scene.
    }
    public static void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public static void GoToGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
    public static void GoToReading()
    {
        SceneManager.LoadScene("Reading");
        //DontDestroyOnLoad(musicObject);
    }
    public static void QuitGame()
    {
        Application.Quit();
    }
}
