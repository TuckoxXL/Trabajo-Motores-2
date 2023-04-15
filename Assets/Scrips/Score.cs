using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public float scorenumero;
    public float scorSuma;

    // Start is called before the first frame update
    void Start()
    {
        scorenumero = 0f;
        scorSuma = 10f;
    }

    // Update is called once per frame
    void Update()
    {

        scoreText.text = "Score:" + (int)scorenumero;
        scorenumero += scorSuma * Time.deltaTime;
    }
}
