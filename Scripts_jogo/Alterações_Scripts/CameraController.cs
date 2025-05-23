using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float mouseSensitivy = 100f;
    public Transform playerBody;
    private float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Trava o cursos para não enchergar
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivy * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivy * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation,-90f,90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f , 0f);
        playerBody.Rotate(Vector3.up*mouseX);
    }
}
