using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationaryTarget : MonoBehaviour {

    public ScoreManager scoreManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter (Collision collision)
    {
        scoreManager.updateScore();
        AudioSource sound = GetComponent<AudioSource>();
        sound.Play();
        Vector3 pos = transform.position;
        pos.x += Random.Range(-3, 3);
        pos.y += Random.Range(-3, 3);
        transform.position = pos;
    }
}
