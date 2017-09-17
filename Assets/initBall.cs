using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initBall : MonoBehaviour {
    public float initialForce;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().AddForce(0, 0, initialForce);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
