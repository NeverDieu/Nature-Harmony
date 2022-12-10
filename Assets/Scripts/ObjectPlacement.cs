using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectPlacement : MonoBehaviour
{
    public GameObject arbre_original, arbre_marais, champignon, objectToDestroy;

    [SerializeField]
    private Button buttonOriginal, buttonMarais, buttonChampignon;
    //the object to move
    public Transform moveThis;
    //the layers the ray can hit
    public LayerMask hitLayers;
    [SerializeField]
    private Renderer rendu;
    //Which tag the game object has
    public string tak;

    private Vector3 spawnPoint = new Vector3(0f, -1000f, 0f);

    private void Start()
    {
        buttonOriginal.onClick.AddListener(ArbreOriginal);
        buttonMarais.onClick.AddListener(ArbreMarais);
        buttonChampignon.onClick.AddListener(Champignon);
    }

    void Update()
    { 
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);
        RaycastHit hit;

        /*if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Destroy(objectToDestroy);
            objectToDestroy = Instantiate(arbre_original, moveThis);
            rendu = objectToDestroy.GetComponentInChildren<Renderer>();
            rendu.material.color = Color.cyan;

            tak = "Arbre";

            Debug.Log("Arbre originel");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            objectToDestroy = Instantiate(arbre_marais, moveThis);
            Destroy(objectToDestroy);
            objectToDestroy = Instantiate(arbre_marais, moveThis);
            rendu = objectToDestroy.GetComponentInChildren<Renderer>();
            rendu.material.color = Color.cyan;

            tak = "Arbre";

            Debug.Log("Arbre guitare");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Destroy(objectToDestroy);
            objectToDestroy = Instantiate(champignon, moveThis);
            rendu = objectToDestroy.GetComponentInChildren<Renderer>();
            rendu.material.color = Color.cyan;

            tak = "Champignon";

            Debug.Log("Champignon");
        }*/

        moveThis = objectToDestroy.transform;

        if (Physics.Raycast(castPoint, out hit, Mathf.Infinity, hitLayers))
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                objectToDestroy = Instantiate(objectToDestroy, hit.point, Quaternion.identity);
                rendu.material.color = Color.white;
            }
            moveThis.transform.position = hit.point;

            /*StartCoroutine(passiveMe(1));

            IEnumerator passiveMe(int secs)
            {
                yield return new WaitForSeconds(secs);
                Debug.Log(hit.collider.name);
            }*/
            
        }

    }

    public void ArbreOriginal()
    {
        
        /*Destroy(objectToDestroy);*/
        objectToDestroy = Instantiate(arbre_original, spawnPoint, Quaternion.identity);
        /*rendu = objectToDestroy.GetComponentInChildren<Renderer>();
        rendu.material.color = Color.cyan;*/

        tak = "Arbre";

        Debug.Log("Arbre originel");
    }

    public void ArbreMarais()
    {
       
        /*Destroy(objectToDestroy);*/
        objectToDestroy = Instantiate(arbre_marais, spawnPoint, Quaternion.identity);
        /*rendu = objectToDestroy.GetComponentInChildren<Renderer>();
        rendu.material.color = Color.cyan;*/

        tak = "Arbre";

        Debug.Log("Arbre marais");
    }

    public void Champignon()
    {
        
        /*Destroy(objectToDestroy);*/
        objectToDestroy = Instantiate(champignon, spawnPoint, Quaternion.identity);
        /*rendu = objectToDestroy.GetComponentInChildren<Renderer>();
        rendu.material.color = Color.cyan;*/

        tak = "Champignon";

        Debug.Log("Champignon");
    }
}
