using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour {


    public GameObject car;
     public Rigidbody rb;
    public Vector3 pos = new Vector3();
    public float spawnTime = 2f;
    public Transform[] spawnPoints;

	// Use this for initialization
	void Start () {

        InvokeRepeating("Spawn", spawnTime, spawnTime);
       /* rb = GetComponent<Rigidbody>();
        if (rb.transform.position.x >140)
        {
            Destroy(rb);
           // Instantiate(rb);
        }
       else
        {
            Update();
        }*/
    }


    void Spawn ()
    {
        if (car.transform.position.x > 140)
        {
            Destroy(car);

        }
        int spawnPointIndex = Random.Range(0, spawnPoints.Length); //indice de creación
        Instantiate(car, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);

    }

	
	// Update is called once per frame
	void Update () {
        //  Instantiate(rb);
        rb.AddForce (100 * Time.deltaTime,0,0 );
	}
}
