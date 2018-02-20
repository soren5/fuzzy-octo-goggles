﻿using UnityEngine;
using System.Collections;
using System.Linq;
using System;

public class ProximityDetectorScript : DetectorScript {
	void Update () {
		GameObject[] blocks;
		float min, current;

		if (useAngle) {
			blocks = GetVisible ("Block");
		} else {
			blocks = GetAll ("Block");
		}

		numObjects = blocks.Length;		//not needed for anything, just for viewing on editor
		min = Mathf.Infinity;

		//Cycle below finds the minimum distance to a block
		foreach (GameObject block in blocks) {
			current = (transform.position - block.transform.position).sqrMagnitude;
			min = Mathf.Min (min, current);
		}

		// I'm not sure what I should be doing here, trying to mimic light function
		strength = 1.0f / (min + 1);
	}
}
