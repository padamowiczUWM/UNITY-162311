using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeL2 : MonoBehaviour
{
    public float speed = 10.0f;
    private Vector3 currentPosition;

    // Start is called before the first frame update
    void Start()
    {
        currentPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (Vector3.Distance(currentPosition, transform.position) >= 10.0f)
        {
            transform.Rotate(Vector3.up, 90.0f);
            currentPosition = transform.position;
        }
    }
}
