using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {

	public static FollowCamera S; //Singleton Instance of this class
	public float easing = 0.05;
	private GameObject poi;
	private float  camZ;

	void Awake() {
		S = this;
		camZ = transform.position.z;
	}

	void FixedUpdate() {
		//check if poi is empty;

		if (poi == null) {
			return;
		}

		Vector3 destination = Vector3.Lerp (this.transform.position, poi.transform.position, easing);
		destination.z = camZ;
		transform.position = destination;
	}

}
