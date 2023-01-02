using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public float zoomSensitivity = 20f;

    private float Z;

    private void Start()
    {
        Z = transform.localPosition.z;
    }
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Z += Input.GetAxis("Mouse ScrollWheel") * zoomSensitivity;

            Z = Mathf.Clamp(Z, -150f, -10f);

            transform.localPosition = new Vector3(0f, 0f, Z);
        }
    }
}
