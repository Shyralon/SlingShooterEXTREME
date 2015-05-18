using UnityEngine;
using System.Collections;

public class CloudCrafter : MonoBehaviour {

	public GameObject[] cloudPrefabs;
	public int NumberOfClouds = 40;
	public Vector3 PosMinX;
	public Vector3 PosMinY;
	public int MinX;
	public int MaxX;
	public int MinY;
	public int MaxY;
	public GameObject Cloud_0;
	public GameObject Cloud_1;
	public float CloudSpeed;
	public float ScaleMin;
	public float ScaleMax;
	public int variations = 4;

	private GameObject[] CloudInstances;
	private int[] Numbers;

	void Awake(){
	/*	for (int i=0; i== Numbers.Length-1; i++){
			Numbers[1]== Random.Range (0, variations);
		}

		for (int i=0; i==NumberOfClouds-1;i++){
			switch(variations){
			case 0:
				CloudInstances[i] = Instantiate(Cloud_0, new Vector3(Random(MinX, MaxX),Random(MinY, MaxY,0), Quaternion.identity);
				break;
			case 1:
				Instantiate(Cloud_1, new Vector3(Random(MinX, MaxX),Random(MinY, MaxY,0), Quaternion.identity);
				break;
			case 2:
				Instantiate(Cloud_2, new Vector3(Random(MinX, MaxX),Random(MinY, MaxY,0), Quaternion.identity);
				break;
			case 3:
				Instantiate(Cloud_3, new Vector3(Random(MinX, MaxX),Random(MinY, MaxY,0), Quaternion.identity);
				break;
			case 4:
				Instantiate(Cloud_4, new Vector3(Random(MinX, MaxX),Random(MinY, MaxY,0), Quaternion.identity);
				break;
			} 
		};*/
		//create array to hold cloud instances
		//find cloud anchor object
		//iterate through array
			//pick a random cloud prefab
			//instantiate cloud from prefab number, position it 
			//scale cloud
		//make cloud child of cloud anchor
		// add cloud to cloud array

		CloudInstances = new GameObject[NumberOfClouds];
		GameObject anchor = GameObject.Find ("Clouds");
		GameObject cloud;
		for (int i=0; i<NumberOfClouds;i++){
			int prefabNum=Random.Range (0, cloudPrefabs.Length-1);
			cloud =Instantiate(cloudPrefabs[prefabNum]);
			Vector3 cPos=Vector2 3.zero;
			cPos.x = Random.Range(PosMin.x, PosMax.x);
			// duplicate with y
			float scaleU = Random.value;
			float scaleVal = Mathf.Lerp (ScaleMin, ScaleMax, scaleU);
			cPos.y = Mathf.Lerp(PosMinY.y, cPos.y,scaleU);

			cPos.z = 100-90*scaleU

				//	cloud.Transform.position= cPos;
				//	cloud.transform.localScale=Vector3.one*scaleVal;
				//cloud.transform.parent=anchor.transform;

	}


}
