using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour {


    public GameObject car;
    public Vector3 Pos;


	// Use this for initialization
	void Start () {
     
            Instantiate(car);
           
       
    }
	
	// Update is called once per frame
	void Update () {
		rb.AddForce (80,0,0);
	}
}
