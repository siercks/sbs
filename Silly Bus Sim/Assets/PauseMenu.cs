using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    AudioScript audioScript;
    [SerializeField] GameObject ourPauseMenu; 
    // ourPauseMenu being serialized allows us to add the UI panel and toggle it off/on.
    private void Awake()
    {
        audioScript = GetComponent<AudioScript>();
    }
    public void PauseGame()
    {
        ourPauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ResumeGame()
    {
        ourPauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }
    public void Controls()
    {
        Debug.Log("Placeholder.");
    }
    public static void Quit()
    {
        Time.timeScale = 1f;
        Application.Quit();
    }
}
