using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objetoAspawnear;
    public float minX;
    public float maxX;
    public float Ypos;
    public float mintiempoSpawn = 3f;
    public float maxtiempoSpawn = 5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnObstaculo(Random.Range(mintiempoSpawn, maxtiempoSpawn), objetoAspawnear));
    }

    ArrayList Enemy; [HideInInspector] 

    private IEnumerator spawnObstaculo(float intervalo, GameObject obstaculo)
    {
        yield return new WaitForSeconds(intervalo);
        Instantiate(obstaculo, new Vector3(Random.Range(minX, maxX), Ypos, 0), Quaternion.identity);
        StartCoroutine(spawnObstaculo(intervalo, obstaculo));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
