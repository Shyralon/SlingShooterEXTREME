using UnityEngine;
using System.Collections;

public class goal : MonoBehaviour {
	// static field accesible from anywhere
	//storing if goal was met
	public static bool GoalHit;

	//Trigger got entered
	void OnTriggerEnter(Collider other){
		//check if object entering is a projectile
		//set the static field to true

		if (other.gameObject.tag == "projectile") {
			GoalHit = true;
			Color c = this.gameObject.GetComponent<Renderer>().material.color;
			c.a = 1;
			c.r=200;
			this.gameObject.GetComponent<Renderer>().material.color;
		}
		//change appearance
	}

}
