using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCameraControl : MonoBehaviour
{
    [Header("Camera Settings")]
    public Transform target; // The object you want to rotate (your camera or player character).
    public float sensitivity = 2.0f; // Mouse sensitivity for camera rotation.
    public float minimumX = -360.0f; // Minimum rotation in X-axis.
    public float maximumX = 360.0f;  // Maximum rotation in X-axis.
    public float minimumY = -90.0f;  // Minimum rotation in Y-axis.
    public float maximumY = 90.0f;   // Maximum rotation in Y-axis.

    private float rotationX = 0.0f;
    private float rotationY = 0.0f;

    void Start()
    {
        if (Application.isEditor)
        {
            Cursor.lockState = CursorLockMode.Locked; // Lock the cursor to the center of the screen.
            Cursor.visible = false; // Hide the cursor.
        }

    }

    void Update()
    {
        if (Application.isEditor)
        {
            // Get mouse input.
            float mouseX = Input.GetAxis("Mouse X") * sensitivity;
            float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

            // Calculate the new camera rotations.
            rotationX += mouseX;
            rotationY -= mouseY;

            // Clamp the rotations to the specified limits.
            rotationX = Mathf.Clamp(rotationX, minimumX, maximumX);
            rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

            // Apply rotations to the camera.
            target.rotation = Quaternion.Euler(rotationY, rotationX, 0);
        }
    }
}