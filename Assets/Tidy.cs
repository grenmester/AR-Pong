using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tidy : MonoBehaviour {

    private void Start()
    {
        Destroy(gameObject, 5f);
    }

    // Use this for initialization
    void OnCollisionEnter (Collision collision) {
        Destroy(gameObject);
	}
}
