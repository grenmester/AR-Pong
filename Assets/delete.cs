using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete : MonoBehaviour
{
    private void Start()
    {
    }

    void OnCollisionEnter(Collision collision)
    {
            Destroy(gameObject);
    }
}
