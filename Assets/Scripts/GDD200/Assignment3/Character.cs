using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Animations;

public class Character : MonoBehaviour
{
    public CharacterController characterController;
    public Animator animator;
    public Transform cam;
    private Vector3 playerVelocity;
    public float Speed = 5f;

    public float turnSmoothing = 0.1f;
    float turnSmoothVelocity;

    public float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;
    public bool groundedPlayer;

    public AudioSource footSteps;

    void Update()
    {

        //Movement to follow Camera
        //Brackey Video on Youtube was followed. 
        //Reverted "Invert" on camera input to change the camera direction to be more natural
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        Cursor.lockState = CursorLockMode.Locked;


        groundedPlayer = characterController.isGrounded;
 

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothing);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            characterController.Move(moveDir.normalized * Speed * Time.deltaTime);
        }
        if (direction.magnitude >= 0.1f)
        {
            animator.SetFloat("RunSpeed", 1f);
            footSteps.enabled = true;
        }
        else
        {
            animator.SetFloat("RunSpeed", 0f);
            footSteps.enabled = false;
        }

            if (Input.GetKey(KeyCode.Space) && groundedPlayer)
        {
            Debug.Log("Jumped");
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        characterController.Move(playerVelocity * Time.deltaTime);

    }
}
