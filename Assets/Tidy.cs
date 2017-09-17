using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tidy : MonoBehaviour {

    public float timeAlive;
    public string destroyTag;
    private void Start()
    {
        Destroy(gameObject, timeAlive);
    }

    void OnCollisionEnter (Collision collision) {
        if(collision.collider.tag == destroyTag)
        {
            Destroy(gameObject);
        }
    }
}
