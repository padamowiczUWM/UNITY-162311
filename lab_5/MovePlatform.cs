using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public float speed = 2.0f;
    public float destX = 6.0f;
    private Vector3 currentPosition;
    private int direction = 1;
    private bool playerOnPlatform = false;
    private CharacterController playerController;

    void Start()
    {
        currentPosition = transform.position;
    }

    void Update()
    {
        if (playerOnPlatform)
        {
            transform.Translate(Vector3.right * speed * direction * Time.deltaTime);
            playerController.Move(Vector3.right * speed * direction * Time.deltaTime);



            if ((direction == 1 && transform.position.x >= destX) || (direction == -1 && transform.position.x <= currentPosition.x))
            {
                direction *= -1;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player wszed³.");
            playerOnPlatform = true;
            playerController = other.GetComponent<CharacterController>();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player zszed³.");
            playerOnPlatform = false;
            playerController = null;
        }
    }
}