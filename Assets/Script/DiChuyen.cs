using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiChuyen : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 5f; // Tốc độ xoay
    private Animator animator;
    private Camera mainCamera;

    void Start()
    {
        animator = GetComponent<Animator>();
        mainCamera = Camera.main;
    }

    void Update()
    {
        float moveX = 0f;
        float moveY = 0f;

        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveX = 1f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            moveY = 1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f;
        }

        Vector3 move = new Vector3(moveX, 0f, moveY).normalized;
        Vector3 cameraForward = mainCamera.transform.forward;
        cameraForward.y = 0; 
        cameraForward.Normalize();

        Vector3 direction = cameraForward * moveY + mainCamera.transform.right * moveX;
        direction.y = 0;
        direction.Normalize();

        if (move != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }

        transform.position += direction * moveSpeed * Time.deltaTime * move.magnitude;
        
        
        animator.SetFloat("speed", move.magnitude * moveSpeed);
    }
}
