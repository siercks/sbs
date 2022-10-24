using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;



public class BusDriver : MonoBehaviour
{
    [SerializeField] float SteerSpeed = 125f;
    [SerializeField] float MoveSpeed = 7f; //SerializeField is an attribute
    //[SerializeField] int score = 0;
    //int KidsLeft = 7;
    Collision collision;
    ScoreKeeper scoreKeeper;
    private void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //transform.Translate(5, 25, 5);
        Debug.Log($"{scoreKeeper.GetScore()}, Kids Waiting For Bus: {scoreKeeper.KidsLeftValue()}");
        
    }

    // Update is called once per frame
    void Update()
    {
        float SteerAmount = Input.GetAxis("Horizontal") * SteerSpeed * Time.deltaTime; // Adding Time.deltaTime makes game behave same on different computers.
        float MoveAmount = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime; //Getting vertical axis sets front/rear speed. Perhaps changing this will allow bus to go slower to rear?
        transform.Rotate(0, 0, -SteerAmount);
        transform.Translate(0, MoveAmount, 0);
    }
}
