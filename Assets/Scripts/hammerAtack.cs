﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammerAtack : MonoBehaviour {

	public AudioSource audioHammer;
	public Animator anim;

	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButtonDown (0)) {
			anim.SetTrigger ("click");
			audioHammer.Play ();

		}
			
	}


}
