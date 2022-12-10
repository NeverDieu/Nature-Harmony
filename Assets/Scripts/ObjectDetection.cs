using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDetection : MonoBehaviour
{
    public int objectNumber;

    [SerializeField]
    private Collider collisionneur;

    void Start()
    {
        collisionneur = GetComponent<Collider>();
    }

    private void OnCollisionEnter(Collision collision)
    { 
        Debug.Log("Objets en contact : " + collision.gameObject.tag);
        objectNumber++;
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Objets sortis : " + collision.gameObject.tag);
        objectNumber--;
    }
}
