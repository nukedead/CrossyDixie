using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthLives : MonoBehaviour {
	public GameObject health1; //one live left
	public GameObject health2; //two live left
	public GameObject health3; //full health
	public GameObject gameOver; //gameover
	
	
	public static int health;


	// Use this for initialization
	void Start () {
		health = 3 ;
		health1.gameObject.SetActive(true);
		health2.gameObject.SetActive(true);
		health3.gameObject.SetActive(true);
		gameOver.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (health > 3)
			health = 3;
		
		switch (health){
		
		case 3:
		health1.gameObject.SetActive(true);
		health2.gameObject.SetActive(true);
		health3.gameObject.SetActive(true);
		break;
		
		case 2:
		health1.gameObject.SetActive(true);
		health2.gameObject.SetActive(true);
		health3.gameObject.SetActive(false);
		break;
		
		case 1:
		health1.gameObject.SetActive(true);
		health2.gameObject.SetActive(false);
		health3.gameObject.SetActive(false);
		break;
		
		case 0:
		health3.gameObject.SetActive(false);
		
		health1.gameObject.SetActive(false);
		health2.gameObject.SetActive(false);
		health3.gameObject.SetActive(false);
		gameOver.gameObject.SetActive(true);
		Time.timeScale = 0;
		break;
		
		
	}
	}
}
