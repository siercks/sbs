using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using TMPro.EditorUtilities;
using TMPro.SpriteAssetUtilities;

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

    // Update is called once per frame
    void Update()
    {
        //scoreText.text = scoreKeeper.GetScore().ToString("000");
        scoreText.text = scoreKeeper.GetScore().ToString();
        kidsLeftText.text = scoreKeeper.KidsLeftValue().ToString();
    }
}
