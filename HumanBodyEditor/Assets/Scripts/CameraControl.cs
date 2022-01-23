using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float rotateSpeed = 10.0f;
    public float zoomSpeed = 10.0f;

    private Camera mainCamera;

    void Start()
    {
        mainCamera = GetComponent<Camera>();
    }

    void Update()
    {
        Zoom();
    }

    private void Zoom()
    {
        float unit = -(float)0.1;
        float distance = Input.GetAxis("Mouse ScrollWheel") * unit * zoomSpeed;
        if (distance != 0)
        {
            mainCamera.orthographicSize += distance;
            if (mainCamera.orthographicSize < 0) mainCamera.orthographicSize = (float)0.01;
        }
    }
}