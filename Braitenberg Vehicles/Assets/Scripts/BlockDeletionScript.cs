﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDeletionScript : MonoBehaviour {
	void OnTriggerEnter(Collider c){
		Destroy (gameObject);
	}
}
