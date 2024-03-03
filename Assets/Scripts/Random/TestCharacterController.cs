using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCharacterController : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float rotationSpeed = 3f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Player movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        if (movementDirection != Vector3.zero)
        {
            Quaternion lookRotation = Quaternion.LookRotation(movementDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, rotationSpeed * Time.deltaTime);
        }

        Vector3 movement = transform.forward * movementSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);

        // Player rotation based on mouse movement
        float mouseX = Input.GetAxis("Mouse X");
        Vector3 rotation = new Vector3(0f, mouseX, 0f) * rotationSpeed;
        rb.MoveRotation(rb.rotation * Quaternion.Euler(rotation));
    }
}
