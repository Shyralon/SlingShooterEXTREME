using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {

	public static FollowCamera S; //Singleton Instance of this class
	public float easing = 0.05;
	private GameObject poi;
	private float  camZ;
	Vector2 minXY;

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
		destination.x = Mathf.Max (minXY.x, destination.x);
		destination.y = Mathf.Max (minXY.y, destination.y);
		destination.z = camZ;
		transform.position = destination;
		this.GetComponent<Camera>().orthographicSize = 10 + destination.y;
	}

}
