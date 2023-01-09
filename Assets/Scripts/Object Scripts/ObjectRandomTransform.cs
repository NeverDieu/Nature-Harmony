using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRandomTransform : MonoBehaviour
{
    Vector3 randomScale;

    Quaternion randomYRotation;
    void Start()
    {
        randomScale = Vector3.one * Random.Range(0.75f, 1.25f);
        randomYRotation = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);

        transform.localScale = randomScale;
        transform.localRotation = randomYRotation;
    }
}
