﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<MeshRenderer>().enabled =  false;
	}
	

}
