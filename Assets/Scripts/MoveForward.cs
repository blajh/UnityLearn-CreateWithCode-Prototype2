using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // defining public fields
    public float speed = 40.0f;

    // Update is called once per frame
    void Update()
    {
        // Move object on Z axis with set speed
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
