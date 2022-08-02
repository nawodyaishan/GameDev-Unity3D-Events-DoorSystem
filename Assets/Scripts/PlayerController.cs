using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")] [SerializeField] private float moveSpeed;

    [SerializeField] private Transform orientation;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float verticalInput;

    private Vector3 moveDirection;
    private Rigidbody rb;
    [SerializeField] private float moveDirectionScale = 10f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Update()
    {
        MyInput();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    void MyInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    void MovePlayer()
    {
        // Calculating Movement Direction
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        // Add Force
        rb.AddForce(moveDirection.normalized * moveDirectionScale, ForceMode.Force);
    }
}