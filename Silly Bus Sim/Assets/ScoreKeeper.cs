using System.Collections;
using System.Collections.Generic;
using System;
using TMPro;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
    {
    //[SerializeField] int score;
    [SerializeField] TextMeshProUGUI scoreText;
    int KidsLeft = 7;
    LevelManager levelManager;
    int score = 50;

    public ScoreKeeper()
    {
        //
    }

    void Awake()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    public int GetScore()
    {
        return score;
        //scoreText.text = Convert.ToInt32(score);
    }
    public void ModifyScore(int value)
    {
        score += value;
        Mathf.Clamp(score, 0, int.MaxValue);
        //Debug.Log(score);
    }
    public void ResetScore()
    {
        score = 0;
        Debug.Log(score);
    }
    public void EndGame()
    {
        Debug.Log("You delivered everyone!");
        // Pass on final score?
    }
    public void KidsLeftModifier(int KidsMod)
    {
        KidsLeft -= KidsMod;
        Mathf.Clamp(KidsLeft, 0, 7);
        Debug.Log(KidsLeft);
    }
    public int KidsLeftValue()
    {
        return KidsLeft;
    }
    public void KidsLeftZero()
    {
        if (KidsLeft == 0)
        {
            Debug.Log("Everyone's in school!");
            LevelManager.GoToGameOver();
        }
        else
        {
            return;
        }
    }

    }