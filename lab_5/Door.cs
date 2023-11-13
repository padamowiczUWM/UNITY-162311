using UnityEngine;

public class Door : MonoBehaviour
{
    public float slidingSpeed = 5f;
    public float openDistance = 1f;

    private bool isOpen = false;
    private Vector3 initialPosition;
    private Vector3 targetPosition;


    void Start()
    {
        initialPosition = transform.position;
        targetPosition = new Vector3(initialPosition.x + openDistance, initialPosition.y, initialPosition.z);
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, GameObject.Find("Player").transform.position);

        if (distanceToPlayer < openDistance)
        {
            isOpen = true;
        }
        else
        {
            isOpen = false;
        }

        if(isOpen)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, slidingSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, initialPosition, slidingSpeed * Time.deltaTime);
        }
    }
}