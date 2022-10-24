using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class Collision : MonoBehaviour
{
    //[SerializeField] int score = 0;
    //[SerializeField] int KidsLeft = 7;
    ScoreKeeper scoreKeeper;
    bool HasKid;
    // public ScoreKeeper myScoreKeeper; 
    // Workaround for the weird Unity "You are trying to create a MonoBehaviour using the 'new' keyword.  This is not allowed." error.
    // Still not viable.
    void Awake()
    {
        //levelManager = FindObjectOfType<LevelManager>();
        scoreKeeper = FindObjectOfType<ScoreKeeper>(); // This is correct and how it seems to be working just fine.
    }

    // This is to notify the player of any collisions.
    void OnCollisionEnter2D(Collision2D other)
    {
        //Removed this to focus on troubleshooting elsewhere.
        //int score = -10;
        //scoreKeeper.ModifyScore(score);
        //Debug.Log($"You goofed! Score: {scoreKeeper.GetScore()}");
        ////Add specific debug notes for boundary collisions.
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //scoreKeeper.GetScore();
        if (other.tag == "Person" && !HasKid)
        {
            Debug.Log("Time to take this kid to school!");
            HasKid = true;
            Destroy(other.gameObject);
        }

        if (other.tag == "School" && HasKid)
        {
            int value = 50;
            int KidsModInput = 1;
            scoreKeeper.ModifyScore(value);
            scoreKeeper.KidsLeftModifier(KidsModInput);
            Debug.Log($"Another kid in school! Score: {scoreKeeper.GetScore()}, Kids Left: {scoreKeeper.KidsLeftValue()}");
            HasKid = false;
            scoreKeeper.KidsLeftZero();

            }
        }
    }


