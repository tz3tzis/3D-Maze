using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCamera : MonoBehaviour {
	
	public GameObject target ;


		[SerializeField]
		Camera rotationCamera;
		
		void Start(){
			
			target.transform.position =  new Vector3 (readFile.N,readFile.levels/2,readFile.N);
			rotationCamera.transform.position = new Vector3 (readFile.N*3,readFile.levels/2,readFile.N*2);

		}

		// Update is called once per frame
		void Update () {

			if (Camera.main == rotationCamera) {
				
				transform.LookAt (target.transform);
				transform.RotateAround (target.transform.position, Vector3.up, 10.0f * Time.deltaTime);

			}
		}

}
