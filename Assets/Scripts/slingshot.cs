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
}
