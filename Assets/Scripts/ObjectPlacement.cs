using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPlacement : MonoBehaviour
{
    public GameObject arbre_original, arbre_marais, champignon, objectToDestroy;
    //the object to move
    public Transform moveThis;
    //the layers the ray can hit
    public LayerMask hitLayers;
    [SerializeField]
    private Renderer rendu;
    //public PlacedObject isPlaced;
    //Which tag the game object has
    public string tak;

    void Update()
    { 
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);
        RaycastHit hit;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {   
            Destroy(objectToDestroy);
            objectToDestroy = Instantiate(arbre_original, moveThis);
            rendu = objectToDestroy.GetComponentInChildren<Renderer>();
            rendu.material.color = Color.cyan;

            tak = "Arbre";

            Debug.Log("Arbre originel");
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            objectToDestroy = Instantiate(arbre_marais, moveThis);
            Destroy(objectToDestroy);
            objectToDestroy = Instantiate(arbre_marais, moveThis);
            rendu = objectToDestroy.GetComponentInChildren<Renderer>();
            rendu.material.color = Color.cyan;

            tak = "Arbre";

            Debug.Log("Arbre guitare");
        }

        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            Destroy(objectToDestroy);
            objectToDestroy = Instantiate(champignon, moveThis);
            rendu = objectToDestroy.GetComponentInChildren<Renderer>();
            rendu.material.color = Color.cyan;

            tak = "Champignon";

            Debug.Log("Champignon");
        }
        
        if (tak == "Arbre")
        {
            moveThis = objectToDestroy.transform;
        }

        if (tak == "Champignon")
        {
            moveThis = objectToDestroy.transform;
        }

        if (Physics.Raycast(castPoint, out hit, Mathf.Infinity, hitLayers))
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            { 
                objectToDestroy = Instantiate(objectToDestroy, hit.point, Quaternion.identity);
                rendu.material.color = Color.white;
            }
            moveThis.transform.position = hit.point;
        }
    }
}
