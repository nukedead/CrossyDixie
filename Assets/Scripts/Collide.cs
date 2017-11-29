using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    
public class Collide : MonoBehaviour {
    public Rigidbody Player1;



    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "car")
        {
            Destroy(col.gameObject);
            //DO SOMETHING!

        }
    }
}
