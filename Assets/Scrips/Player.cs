using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    public float Forcemultiplier;
    public float jumforce;
    public bool canjump;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        canjump = true;
    }

    // Update is called once per frame
    void Update()
    {
        //float horizontalforce = Input.GetAxis("Horizontal") * Forcemultiplier;
        //float verticalforce = Input.GetAxis("Vertical") * Forcemultiplier;

        //horizontalforce *= Time.deltaTime;
        //verticalforce *= Time.deltaTime;
        //transform.Translate(horizontalforce, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space) && canjump)
        {
            rb.AddForce(0f, jumforce, 0f, ForceMode.Impulse);
            canjump = false;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            canjump = true;
        }

        if (collision.gameObject.tag == "Enemy")
        {
            
        }
    }


}
