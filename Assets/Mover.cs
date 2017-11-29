
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    float a = 10f;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        Move();
    }
    
    void Move()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * a * Time.deltaTime);
        else if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * a * Time.deltaTime);
        else if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * a * Time.deltaTime);
        else if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * a * Time.deltaTime);
    }
}