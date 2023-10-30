using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float speed = 10f;
    public bool moveRight = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > 10f)
        {
            moveRight = false;
        }
        if (transform.position.x < 0f)
        {
            moveRight = true;
        }
        transform.Translate((moveRight ? Vector3.right: Vector3.left) * speed * Time.deltaTime);
    }
}
