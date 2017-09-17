using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour {

    public string damageTag;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnEnterCollision(Collision collision)
    {
        if(collision.collider.tag == damageTag)
        {
            print("hit by enemy ball");
        }
    }
}
