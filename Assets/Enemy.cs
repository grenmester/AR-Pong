using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public Rigidbody projectile;
    public float horiz_offset;
    public float y_offset;
    public float theta;
    public float shotForce;
    public float fireTime;
    private float startTime;

    void SpawnABall()
    {
        print("Firing at player");
        Vector3 pos = transform.position;
        Vector3 cameraPos = Camera.main.gameObject.transform.position;
        transform.rotation = Quaternion.LookRotation(cameraPos - pos);
        pos.y += y_offset;
        pos += transform.forward * horiz_offset;
        // Quaternion rot = transform.rotation;
        Quaternion rot = transform.rotation;
        rot.x += -1 * theta;
        Rigidbody shot = Instantiate(projectile, pos, rot) as Rigidbody;
        shot.AddForce(transform.forward * shotForce);
    }

    private void Start()
    {
        startTime = 0f;
    }

    private void Update()
    {
        if (Time.time - startTime > fireTime)
        {
            startTime = Time.time;
            SpawnABall();
        }
    }
}
