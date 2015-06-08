using UnityEngine;
using System.Collections;

public class ProjectileTrail : MonoBehaviour {
//singleton instance
	public static ProjectileTrail S;

	//public inspector fields
	public float minDist =0.1f;
	//internal fields
	private LineRenderer line;
	private int pointsCount;
	private GameObject _poi;
	private Vector3 lastPoint;

	void Awake(){
		S = this;

		//store the linerenderer component in a field
		line = this.GetComponent<LineRenderer> ();
		//initialize fields
		pointsCount = 0;
		//disable unitl needed
		line.enabled = false;
	}

	void FixedUpdate(){
		//if no poi has been set usw camera poi (if it follows a projectile)
		//now the poi definitely has a value and it's a porjectile
		//add a point
		AddPoint ();

	}

	void AddPoint(){
		Vector3 pt = _poi.transform.position;
		//if the point isn't far enough from the last one, do nothing
		//if we are dealing with the first (launch) point
		//else, not the first point
		lastPoint = pt;
	}
}

	//a property:looks to the outside like a field, but calls get/set internally
	public GameObject poi {
		get{
			return _poi;
		}
		
		set{
			//use "value" to acces new value of the property
			//set new value of _poi
			_poi = value;
			
			//heck if poi was set to something (and now to something new) 
			//reset the whole thingy
			if (_poi !=null){
				line.enabled=false;
				pointsCount=0;
				line.SetVertexCount (0);
			}
		}
