using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinalScorePassthru : MonoBehaviour
{
    [Header("Final Score")]
    [SerializeField] TextMeshProUGUI finalScoreText;
    ScoreKeeper scoreKeeper;

    void Awake()
    {
        //scoreKeeper = GetComponent<ScoreKeeper>();
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //scoreKeeper.GetScore();
        finalScoreText.text = scoreKeeper.GetScore().ToString();
    }
}
