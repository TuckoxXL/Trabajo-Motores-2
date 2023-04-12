using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    public float tiempovivo = 0f;
    public float tiempomaximodevida = 6f;
    public float velocidad = 8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(velocidad * (Time.deltaTime), 0, 0);
        tiempovivo += Time.deltaTime;

        if (tiempovivo >= tiempomaximodevida)
        {
            Destroy(this.gameObject);
        }
    }
}
