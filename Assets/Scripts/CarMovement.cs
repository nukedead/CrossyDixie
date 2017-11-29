using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour {


  //  public GameObject car;
    public Rigidbody rb;
    public Vector3 position = new Vector3();


	// Use this for initialization
	void Start () {
     
            Instantiate(rb);
      
        if (rb.transform.position.x >140)
        {
            Destroy(rb);
        }
        else
        {
            Update();
        }
    }
	
	// Update is called once per frame
	void Update () {
		rb.AddForce (20,0,0);
	}
}
