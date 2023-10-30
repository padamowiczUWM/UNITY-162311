using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSmooth : MonoBehaviour
{
    public Transform target;
    float smoothTime = 0.3f;
    Vector3 velocity = Vector3.zero;

    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, target.position, ref velocity, smoothTime);
    }
}
