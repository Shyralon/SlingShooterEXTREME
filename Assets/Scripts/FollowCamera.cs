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
		Vector3 destination;
		//check if poi is empty;

		if (poi == null) {
			destination=Vector3.zero;
		} else {
			//else if the poi exists
			//get its position
			destination = poi.transform.position;
			if(poi.tag == "projectile"){
			//check if poi is a projectile
			if(poi.GetComponent<Rigidbody>().IsSleeping()){
					poi=null;
					return;
			//check if resting (sleeping)
			//set it to null as default value
				}
			}
		}

		destination = Vector3.Lerp (this.transform.position, poi.transform.position, easing);
		destination.x = Mathf.Max (minXY.x, destination.x);
		destination.y = Mathf.Max (minXY.y, destination.y);
		destination.z = camZ;
		transform.position = destination;
		this.GetComponent<Camera>().orthographicSize = 10 + destination.y;
	}

}
