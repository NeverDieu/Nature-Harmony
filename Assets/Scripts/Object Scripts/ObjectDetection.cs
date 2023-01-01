using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDetection : MonoBehaviour
{
    [Header("Total")]
    public int objectNumberTotal;

    [Header("Arbres")]
    public int objectNumberArbres;

    [Header("Champignons")]
    public int objectNumberChampignons;

    [Header("Rochers")]
    public int objectNumberRochers;

    [Header("Buissons")]
    public int objectNumberBuissons;
    private void OnCollisionEnter(Collision collision)
    { 
        objectNumberTotal++;

        if (collision.collider.tag == "Arbre")
        {
            objectNumberArbres++;
        }
        else if (collision.collider.tag == "Champignon")
        {
            objectNumberChampignons++;
        }
        else if (collision.collider.tag == "Rocher")
        {
            objectNumberRochers++;
        }
        else if (collision.collider.tag == "Buisson")
        {
            objectNumberBuissons++;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        objectNumberTotal--;

        if (collision.collider.tag == "Arbre")
        {
            objectNumberArbres--;
        }
        else if (collision.collider.tag == "Champignon")
        {
            objectNumberChampignons--;
        }
        else if (collision.collider.tag == "Rocher")
        {
            objectNumberRochers--;
        }
        else if (collision.collider.tag == "Buisson")
        {
            objectNumberBuissons--;
        }
    }
}
