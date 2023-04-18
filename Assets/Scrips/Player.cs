using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    public float Forcemultiplier;
    public float jumforce;
    public bool canjump;
    public bool isPower;
    public Text powerText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        canjump = true;
        isPower = false;
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
           if (isPower == true)
            {
                Destroy (collision.gameObject);
            } 
           else
            {
                SceneManager.LoadScene("Derrota");
            }
        }
    }

    public void powerActive()
    {
        isPower = true;
        powerText.text = "Poder Activo";
        Invoke("powerInactive",4f);
        Debug.Log("poder activo player");
    }

    public void powerInactive()
    {
      
        isPower = false;
        powerText.text = "";
        Debug.Log("poder inactivo player");
    }
}
