﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
		GameObject[] musics = GameObject.FindGameObjectsWithTag ("Music");
		if (musics.Length > 1) {
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
