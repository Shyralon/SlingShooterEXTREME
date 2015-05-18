using UnityEngine;
using System.Collections;

public class slingshot : MonoBehaviour {

	private GameObject launchpoint;

	void Awake(){
		Transform launchpointTrans = transform.Find("LaunchPoint");
		launchpoint = launchpointTrans.gameObject;
		launchpoint.SetActive (false);
	}

	void OnMouseEnter(){
	print ("Slingshotonmouseenterstuff");
		launchpoint.SetActive (true);
		     }

	void OnMouseExit(){
		print ("exitstuff");
		launchpoint.SetActive (false);
	}

	//void onMouseDown

	/*void Update(){
		if (!aimingmode)
			return;

		Vector3 mousePos2D = Input.mousePoisition;
		mousePos2D.z = -Camera.main.transform.position.z;
		Vector3 mousePos3D = Camera.main.ScreenToWorldPoint (mousePos2D);

		Vector3 mouseDelta = mousePos3D -launchPos;

		float maxMagnitude = this.Getcomponent<SphereCollider>().radius;
		mouseDelta = Vector3.ClampMagnitude(mouseDelta

		FollowCamera.S.poi = projectile;

} */
	