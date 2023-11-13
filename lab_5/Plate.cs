using UnityEngine;

public class Plate : MonoBehaviour
{
    public float jumpForce = 6.0f;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody rigidBody = other.GetComponent<Rigidbody>();

            if (rigidBody != null)
            {
                rigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }
}