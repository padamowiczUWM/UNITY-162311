using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeLerp : MonoBehaviour
{
    public Transform target;
    public float lerpSpeed = 0.5f;

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, lerpSpeed * Time.deltaTime);
    }
}
