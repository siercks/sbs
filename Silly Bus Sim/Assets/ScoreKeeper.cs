using System.Collections;
using System.Collections.Generic;
using System;
using TMPro;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
    {
    //[SerializeField] int score;
    //[SerializeField] TextMeshProUGUI scoreText;
    int KidsLeft = 3;
    LevelManager levelManager;
    int score = 0;
    float bonusTimer = 0f;

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
        PlayerPrefs.SetInt("Player Score", score);
        return score;
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
    public void EndGame(int score)
    {
        Debug.Log("You delivered everyone!");
        // This needed at all, after I used another method? Probably not.
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
    public int BonusTimer()
    {
        return (int)bonusTimer;
    }

    }