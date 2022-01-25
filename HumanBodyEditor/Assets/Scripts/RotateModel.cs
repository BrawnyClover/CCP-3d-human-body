using UnityEngine;

public class RotateModel
    : MonoBehaviour
{
    private float speed = 3f;

    void Update()
    {
        if (Input.GetMouseButton(0) && Input.mousePosition.x > 310)
        {
            
            //Debug.Log(Input.mousePosition.x + " "+ Input.mousePosition.y);
            transform.Rotate(0f, -Input.GetAxis("Mouse X") * speed, 0f, Space.World);
            transform.Rotate(-Input.GetAxis("Mouse Y") * speed, 0f, 0f);
        }
    }
}