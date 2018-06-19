using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
	public int direction = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(direction*2*Time.deltaTime, 0, 0);
		if(Random.Range(0.0f, 100.0f)>99){
        	//GetComponent<Rigidbody>().AddForce(transform.up*10 *45);
        }
	}
	public void Die(){
		Destroy(gameObject);
	}
	void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.tag != "Level")
       		direction = -direction; 
    }	
}
