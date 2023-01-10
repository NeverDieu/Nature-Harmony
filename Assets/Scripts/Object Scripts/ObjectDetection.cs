using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDetection : MonoBehaviour
{
    private MeshCollider monCollider;

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

    private void Start()
    {
        monCollider = GetComponent<MeshCollider>();
    }

    private void Update()
    {
        if(objectNumberTotal < 0)
        {
            objectNumberTotal = 0;
        }
        if(objectNumberArbres < 0)
        {
            objectNumberArbres = 0;
        }
        if(objectNumberChampignons < 0)
        {
            objectNumberChampignons = 0;
        }
        if(objectNumberRochers < 0)
        {
            objectNumberChampignons = 0;
        }
        if(objectNumberBuissons < 0)
        {
            objectNumberBuissons = 0;
        }
    }

    public void OnTriggerEnter(Collider other)
    { 
        objectNumberTotal++;

        var var = other.GetComponent<SphereCollider>();
        var nom = other.name;

        if (var.CompareTag("Arbre"))
        {
            objectNumberArbres++;
            if (nom.Contains("plaine") && !gameObject.name.Contains("Plaine"))
            {
                Physics.IgnoreCollision(monCollider, var);
            }
            if (nom.Contains("marais") && !gameObject.name.Contains("Marais"))
            {
                Physics.IgnoreCollision(monCollider, var);
            }
            if (nom.Contains("d�sert") && !gameObject.name.Contains("D�sert"))
            {
                Physics.IgnoreCollision(monCollider, var);
            }
            if (nom.Contains("montagne") && !gameObject.name.Contains("Montagne"))
            {
                Physics.IgnoreCollision(monCollider, var);
            }

        }
        else if (var.CompareTag("Champignon"))
        {
            objectNumberChampignons++;
            Debug.Log(other.GetComponent<BoxCollider>());
            if (nom.Contains("plaine") && !gameObject.name.Contains("Plaine"))
            {
                Physics.IgnoreCollision(monCollider, var);
            }
            if (nom.Contains("marais") && !gameObject.name.Contains("Marais"))
            {
                Physics.IgnoreCollision(monCollider, var);
            }
            if (nom.Contains("d�sert") && !gameObject.name.Contains("D�sert"))
            {
                Physics.IgnoreCollision(monCollider, var);
            }
            if (nom.Contains("montagne") && !gameObject.name.Contains("Montagne"))
            {
                Physics.IgnoreCollision(monCollider, var);
            }
        }
        else if (var.CompareTag("Rocher"))
        {
            objectNumberRochers++;
            if (nom.Contains("plaine") && !gameObject.name.Contains("Plaine"))
            {
                Physics.IgnoreCollision(monCollider, var);
            }
            if (nom.Contains("marais") && !gameObject.name.Contains("Marais"))
            {
                Physics.IgnoreCollision(monCollider, var);
            }
            if (nom.Contains("d�sert") && !gameObject.name.Contains("D�sert"))
            {
                Physics.IgnoreCollision(monCollider, var);
            }
            if (nom.Contains("montagne") && !gameObject.name.Contains("Montagne"))
            {
                Physics.IgnoreCollision(monCollider, var);
            }
        }
        else if (var.CompareTag("Buisson"))
        {
            objectNumberBuissons++;
            if (nom.Contains("plaine") && !gameObject.name.Contains("Plaine"))
            {
                Physics.IgnoreCollision(monCollider, var);
            }
            if (nom.Contains("marais") && !gameObject.name.Contains("Marais"))
            {
                Physics.IgnoreCollision(monCollider, var);
            }
            if (nom.Contains("d�sert") && !gameObject.name.Contains("D�sert"))
            {
                Physics.IgnoreCollision(monCollider, var);
            }
            if (nom.Contains("montagne") && !gameObject.name.Contains("Montagne"))
            {
                Physics.IgnoreCollision(monCollider, var);
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        objectNumberTotal--;

        if (other.CompareTag("Arbre"))
        {
            objectNumberArbres--;
        }
        else if (other.CompareTag("Champignon"))
        {
            objectNumberChampignons--;
        }
        else if (other.CompareTag("Rocher"))
        {
            objectNumberRochers--;
        }
        else if (other.CompareTag("Buisson"))
        {
            objectNumberBuissons--;
        }
    }
}
