using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotate : MonoBehaviour
{

    public float speed = 0.01f;
    float angle = 0.0f;


    // Update is called once per frame
    void Update()
    {
        angle = speed;
        this.transform.Rotate(Vector3.one, angle);
    }
}
