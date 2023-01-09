using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMenuRotation : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.05f;

    private Vector3 Y;

    void FixedUpdate()
    {
        Y = new Vector3(0f, 1f * speed, 0f);

        transform.Rotate(Y, Space.World);
    }
}
