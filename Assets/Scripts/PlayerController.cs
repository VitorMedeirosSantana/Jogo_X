using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    void Start()
    {

    }

    // Update is called once per second
    void Update()
    {
        // Controle do usuario
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Aceleração do objeto
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Rotação do objeto
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

    }
}
