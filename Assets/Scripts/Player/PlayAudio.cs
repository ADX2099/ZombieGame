﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour {

    [SerializeField] AudioSource myAudio;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
            myAudio.Play();
		
	}
}
