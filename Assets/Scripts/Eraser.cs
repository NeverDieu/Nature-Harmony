using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eraser : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Arbre") || other.CompareTag("Champignon") || other.CompareTag("Rocher") || other.CompareTag("Buisson") || other.CompareTag("Fleur"))
        {
            Debug.Log("En collison");
            if (Input.GetMouseButton(0))
            {
                Destroy(other.gameObject);
            }
        }
    }
}
