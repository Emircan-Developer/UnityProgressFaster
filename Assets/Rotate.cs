using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float Y;
    public Camera cam;
    public int Sensivity;
    float x, y;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MouseFixer();
        rb.transform.Rotate(Vector3.up * x * (Sensivity * 10));
        cam.transform.localRotation = Quaternion.Euler(Y, 0, 0);
    }
    void MouseFixer()
    {
        x = Input.GetAxis("Mouse X");
        y = - Input.GetAxis("Mouse Y");
        Y += y * (Sensivity * 10);
        Y = Mathf.Clamp(Y, -45, 45);
    }
}
