using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIdisplay : MonoBehaviour
{
    [Header("Score")]
    [SerializeField] TextMeshProUGUI scoreText;
    ScoreKeeper scoreKeeper;

    [Header("Kids Left")]
    [SerializeField] TextMeshProUGUI kidsLeftText;

    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    void Start()
    {
        //
    }

    void Update()
    {
        scoreText.text = scoreKeeper.GetScore().ToString();
        kidsLeftText.text = scoreKeeper.KidsLeftValue().ToString();
    }
}
