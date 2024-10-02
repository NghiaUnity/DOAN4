using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiChuyen : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 5f; // Tốc độ xoay
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float moveX = 0f;
        float moveY = 0f;
        Quaternion targetRotation = transform.rotation;

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
        if (move != Vector3.zero)
        {
            targetRotation = Quaternion.LookRotation(move);
        }

        transform.position += move * moveSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        // Set the speed parameter in the Animator
        animator.SetFloat("speed", move.magnitude * moveSpeed);
    }
}
