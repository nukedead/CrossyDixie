
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveExtra : MonoBehaviour
{
    public float rush;

    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {

        float MomivientoHorizontal = Input.GetAxis("Horizontal");
        float MovimientoVertical = Input.GetAxis("Vertical");
        Vector3 Move = new Vector3(MomivientoHorizontal, 0.0f, MovimientoVertical);
        rb.AddForce(Move * -rush * Time.deltaTime);

    }

}