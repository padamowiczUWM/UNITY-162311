using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{
    // ruch wokó³ osi Y bêdzie wykonywany na obiekcie gracza, wiêc
    // potrzebna nam referencja do niego (konkretnie jego komponentu Transform)
    public Transform player;
    public float mouseSensitivity = 100.0f;
    public float rotationX = 0f;
    public float rotationY = 0f;


    void Start()
    {
        // zablokowanie kursora na œrodku ekranu, oraz ukrycie kursora
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // pobieramy wartoœci dla obu osi ruchu myszy
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = -Input.GetAxis("Mouse Y");

        rotationY += mouseX * mouseSensitivity * Time.deltaTime;
        rotationX += mouseY * mouseSensitivity * Time.deltaTime;

        rotationX = Mathf.Clamp(rotationX, -90f, 90f);

        Quaternion localRotation = Quaternion.Euler(rotationX, rotationY, 0.0f);
        transform.rotation = localRotation;

    }
}