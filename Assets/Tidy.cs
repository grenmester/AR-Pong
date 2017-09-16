using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tidy : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter (Collision collision) {
        Destroy(gameObject);
	}
}
