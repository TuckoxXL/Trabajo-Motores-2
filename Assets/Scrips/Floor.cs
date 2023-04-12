using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public int offsetx = 10; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position -= new Vector3 (-8 * Time.deltaTime, 0, 0);

       if (transform.position.x < -offsetx)
        {
            transform.position = new Vector3 (10, transform.position.y, 0);
        }
    }
}
