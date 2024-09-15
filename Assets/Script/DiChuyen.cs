using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiChuyen : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 5f; // Tốc độ xoay

    void Update()
    {
        float moveX = 0f;
        float moveY = 0f;
        Quaternion targetRotation = transform.rotation;

        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f;
            targetRotation = Quaternion.Euler(0, -90, 0); 
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveX = 1f;
            targetRotation = Quaternion.Euler(0, 90, 0); 
        }
        if (Input.GetKey(KeyCode.W))
        {
            moveY = 1f;
            targetRotation = Quaternion.Euler(0, 0, 0); 
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f;
            targetRotation = Quaternion.Euler(0, 180, 0); 
        }

        Vector3 move = new Vector3(moveX, 0f, moveY).normalized;
        transform.position += move * moveSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
}
