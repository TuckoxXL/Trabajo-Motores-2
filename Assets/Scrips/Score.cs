using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public float scorenumero;
    public float scorSuma;
    public Player _Player;


    // Start is called before the first frame update
    void Start()
    {
        scorenumero = 0f;
        scorSuma = 10f;
        InvokeRepeating("power",11f,11f);
    }

    // Update is called once per frame
    void Update()
    {

        scoreText.text = "Score:" + (int)scorenumero;
        scorenumero += scorSuma * Time.deltaTime;

    }

    void power()
    {
        _Player.powerActive();
        Debug.Log("poder activo");
    }
}
