using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject obstaculo1;
    public GameObject obstaculo2;
    int elejirObstaculo;
    public float tiempo;
    public float tiempoEntreSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       tiempo += Time.deltaTime;

        if (tiempo > tiempoEntreSpawn)
        {
            tiempo = 0;
            llamarEnemigo();
        }
    }

    void llamarEnemigo()
    {
        elejirObstaculo = Random.Range(0, 1);
        if (elejirObstaculo == 0)
        {
            Instantiate(obstaculo1);
        }

        if (elejirObstaculo == 1)
        {
            Instantiate(obstaculo2);
        }
    }
}
