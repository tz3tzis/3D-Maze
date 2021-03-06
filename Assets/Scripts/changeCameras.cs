using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class changeCameras : MonoBehaviour {

	[SerializeField]
	Camera firstPersonCamera;

	[SerializeField]
	Camera topCamera;

	[SerializeField]
	Camera rotationCamera;


	public GameObject target = null;
	private bool switchCam = false;
	private bool press = false;
	public GameObject cubeRed;


	void Start(){
		
		GameObject.Find("FPSController").GetComponent<FirstPersonController> ().enabled = false;
		firstPersonCamera.GetComponent<Camera> ().enabled = false;

		rotationCamera.GetComponent<Camera> ().enabled = false;

		topCamera.GetComponent<Camera> ().enabled = true;

		cubeRed =  (GameObject) Instantiate (Resources.Load("cubeRed"))  ;
		//cubeRed.GetComponent<Renderer>().material.color.a = 0.5f;


		Color temp = cubeRed.gameObject.GetComponent<Renderer> ().material.color;
		temp.a = 0.0f;
		cubeRed.gameObject.GetComponent<Renderer> ().material.color = temp;


		/*cubeGreen.GetComponent<Renderer>().material.color.a = 0.5;
		cubeBlue.GetComponent<Renderer>().material.color.a = 0.5;
		cubeBlack.GetComponent<Renderer>().material.color.a = 0.5;
		cubeT1.GetComponent<Renderer>().material.color.a = 0.5;
		cubeT2.GetComponent<Renderer>().material.color.a = 0.5;
		cubeT3.GetComponent<Renderer>().material.color.a = 0.5;*/


	}

	void Update (){

		if(Input.GetKeyDown(KeyCode.V)){
			
			if (switchCam) {
				
				GameObject.Find("FPSController").GetComponent<FirstPersonController> ().enabled = false;
				firstPersonCamera.GetComponent<Camera> ().enabled = false;

				topCamera.GetComponent<Camera> ().enabled = true;

				switchCam = !switchCam;

			} else {
				
				GameObject.Find("FPSController").GetComponent<FirstPersonController> ().enabled = true;
				firstPersonCamera.GetComponent<Camera> ().enabled = true;

				topCamera.GetComponent<Camera> ().enabled = false;

				switchCam = !switchCam;
			}
				
		}

		if (Input.GetKeyDown (KeyCode.R)) {
			
			press = !press;

			if (press) {

				rotationCamera.GetComponent<Camera> ().enabled = true;

				GameObject.Find("FPSController").GetComponent<FirstPersonController> ().enabled = false;
				firstPersonCamera.GetComponent<Camera> ().enabled = false;

				topCamera.GetComponent<Camera> ().enabled = false;

			}
		}
			
	}
}
