using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    [Header("Main Menu Music")] 
    [SerializeField] AudioClip mainMenuMusic;
    [SerializeField] [Range(0f, 1f)] float mainMenuMusicVolume = 1f;

    [Header("Gameplay Music")]
    [SerializeField] AudioClip gameplayMusic;
    [SerializeField][Range(0f, 1f)] float gameplayMusicVolume = 1f;

    public GameObject musicObject;

    public void MainMenuMusic()
    {
        //PlayerPrefs.SetInt(mainMenuMusic);
        DontDestroyOnLoad(musicObject);
        AudioSource.PlayClipAtPoint(mainMenuMusic, Camera.main.transform.position, mainMenuMusicVolume);
    }
    public void GameplayMusic()
    {
        AudioSource.PlayClipAtPoint(gameplayMusic, Camera.main.transform.position, gameplayMusicVolume);
    }
}
