using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
    {
    //[SerializeField] int score;
    int KidsLeft = 7;
    LevelManager levelManager;
    int score;

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
        if (KidsLeft == 5)
        {
            Debug.Log("Everyone's in school!");
            Debug.Log("This would take you to the Game Over screen... IF IT WOULD WORK!!!");
            //levelManager.QuitGame();
        }
        else
        {
            return;
        }
    }

    }