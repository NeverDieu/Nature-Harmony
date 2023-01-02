using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectPlacement : MonoBehaviour
{
    public GameObject arbre_plaine, arbre_marais, arbre_d�sert, arbre_montagne,
    champignon_plaine, champignon_marais, champignon_d�sert, champignon_montagne,
    rocher_plaine, rocher_marais, rocher_d�sert, rocher_montagne,
    buisson_plaine, buisson_marais, buisson_d�sert, buisson_montagne,
    placeHolder, objectToDestroy;

    [SerializeField]
    private Button buttonArbres, buttonChampignons, buttonRochers, buttonBuissons, buttonPlaceHolder, buttonPlaceHolder1;
    //L'objet qui bouge
    public Transform moveThis;
    //Quel Layers le Raycast peut toucher
    public LayerMask hitLayers;
    //Un rendu de l'objet qui va �tre plac�
    [Header("Arbres")]
    public GameObject pr�rendu_arbre_plaine; public GameObject pr�rendu_arbre_marais; public GameObject pr�rendu_arbre_d�sert; public GameObject pr�rendu_arbre_montagne;
    [Header("Champignon")]
    public GameObject pr�rendu_champignon_plaine; public GameObject pr�rendu_champignon_marais; public GameObject pr�rendu_champignon_d�sert; public GameObject pr�rendu_champignon_montagne;
    [Header("Rocher")]
    public GameObject pr�rendu_rocher_plaine; public GameObject pr�rendu_rocher_marais; public GameObject pr�rendu_rocher_d�sert; public GameObject pr�rendu_rocher_montagne;
    [Header("Buisson")]
    public GameObject pr�rendu_buisson_plaine; public GameObject pr�rendu_buisson_marais; public GameObject pr�rendu_buisson_d�sert; public GameObject pr�rendu_buisson_montagne;
    //Quel tag l'objet a
    public string tak;

    GroupMaker leoTechMaker;

    Quaternion randomYRotation;

    Vector3 randomScale;

    RaycastHit hit;

    private Vector3 spawnPoint = new Vector3(0f, -1000f, 0f);

    private void Start()
    {
        buttonArbres.onClick.AddListener(Arbre);
        buttonChampignons.onClick.AddListener(Champignon);
        buttonRochers.onClick.AddListener(Rocher);
        buttonBuissons.onClick.AddListener(Buisson); 
    }

    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);


        moveThis = objectToDestroy.transform;

        if (Physics.Raycast(castPoint, out hit, Mathf.Infinity, hitLayers))
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                ObjectSpawner();
            }
            moveThis.transform.position = hit.point;
        }

        randomYRotation = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);
        randomScale = Vector3.one * Random.Range(0.75f, 1.25f);
    }

    public void Arbre()
    {
        Destroy(objectToDestroy);

        objectToDestroy = Instantiate(pr�rendu_arbre_plaine, spawnPoint, Quaternion.identity);

        tak = "Arbre";
    }

    public void Champignon()
    {
        Destroy(objectToDestroy);

        objectToDestroy = Instantiate(pr�rendu_champignon_plaine, spawnPoint, Quaternion.identity);

        tak = "Champignon";
    }

    public void Rocher()
    {
        Destroy(objectToDestroy);

        objectToDestroy = Instantiate(pr�rendu_rocher_plaine, spawnPoint, Quaternion.identity);

        tak = "Rocher";
    }

    public void Buisson()
    {
        Destroy(objectToDestroy);

        objectToDestroy = Instantiate(pr�rendu_buisson_plaine, spawnPoint, Quaternion.identity);

        tak = "Buisson";
    }

    private void ObjectSpawner()
    {
        if (objectToDestroy.tag == "Arbre")
        {
            if (hit.collider.name == "Plaine")
            {
                var leoTechMakerEnfant = Instantiate(arbre_plaine, hit.point, randomYRotation);
                leoTechMakerEnfant.transform.localScale = randomScale;
                leoTechMaker.array.Add(leoTechMakerEnfant.GetComponent<GroupMaker>());
                leoTechMaker.groupLength++;
            }
            else if (hit.collider.name == "Marais")
            {
                var leoTechMakerEnfant = Instantiate(arbre_marais, hit.point, randomYRotation);
                leoTechMakerEnfant.transform.localScale = randomScale;
                leoTechMaker.array.Add(leoTechMakerEnfant.GetComponent<GroupMaker>());
                leoTechMaker.groupLength++;
            }
            else if (hit.collider.name == "D�sert")
            {
                var leoTechMakerEnfant = Instantiate(arbre_d�sert, hit.point, randomYRotation);
                leoTechMakerEnfant.transform.localScale = randomScale;
                leoTechMaker.array.Add(leoTechMakerEnfant.GetComponent<GroupMaker>());
                leoTechMaker.groupLength++;
            }
            else if (hit.collider.name == "Montagne")
            {
                var leoTechMakerEnfant = Instantiate(arbre_montagne, hit.point, randomYRotation);
                leoTechMakerEnfant.transform.localScale = randomScale;
                leoTechMaker.array.Add(leoTechMakerEnfant.GetComponent<GroupMaker>());
                leoTechMaker.groupLength++;
            }
        }

        if (objectToDestroy.tag == "Champignon")
        {
            if (hit.collider.name == "Plaine")
            {
                var leoTechMakerEnfant = Instantiate(champignon_plaine, hit.point, randomYRotation);
                leoTechMakerEnfant.transform.localScale = randomScale;
                leoTechMaker.array.Add(leoTechMakerEnfant.GetComponent<GroupMaker>());
                leoTechMaker.groupLength++; ;
            }
            else if (hit.collider.name == "Marais")
            {
                var leoTechMakerEnfant = Instantiate(champignon_marais, hit.point, randomYRotation);
                leoTechMakerEnfant.transform.localScale = randomScale;
                leoTechMaker.array.Add(leoTechMakerEnfant.GetComponent<GroupMaker>());
                leoTechMaker.groupLength++;
            }
            else if (hit.collider.name == "D�sert")
            {
                var leoTechMakerEnfant = Instantiate(champignon_d�sert, hit.point, randomYRotation);
                leoTechMakerEnfant.transform.localScale = randomScale;
                leoTechMaker.array.Add(leoTechMakerEnfant.GetComponent<GroupMaker>());
                leoTechMaker.groupLength++;
            }
            else if (hit.collider.name == "Montagne")
            {
                var leoTechMakerEnfant = Instantiate(champignon_montagne, hit.point, randomYRotation);
                leoTechMakerEnfant.transform.localScale = randomScale;
                leoTechMaker.array.Add(leoTechMakerEnfant.GetComponent<GroupMaker>());
                leoTechMaker.groupLength++;
            }
        }

        if (objectToDestroy.tag == "Rocher")
        {
            if (hit.collider.name == "Plaine")
            {
                var leoTechMakerEnfant = Instantiate(rocher_plaine, hit.point, randomYRotation);
                leoTechMakerEnfant.transform.localScale = randomScale;
                leoTechMaker.array.Add(leoTechMakerEnfant.GetComponent<GroupMaker>());
                leoTechMaker.groupLength++;
            }
            else if (hit.collider.name == "Marais")
            {
                var leoTechMakerEnfant = Instantiate(rocher_marais, hit.point, randomYRotation);
                leoTechMakerEnfant.transform.localScale = randomScale;
                leoTechMaker.array.Add(leoTechMakerEnfant.GetComponent<GroupMaker>());
                leoTechMaker.groupLength++;
            }
            else if (hit.collider.name == "D�sert")
            {
                var leoTechMakerEnfant = Instantiate(rocher_d�sert, hit.point, randomYRotation);
                leoTechMakerEnfant.transform.localScale = randomScale;
                leoTechMaker.array.Add(leoTechMakerEnfant.GetComponent<GroupMaker>());
                leoTechMaker.groupLength++;
            }
            else if (hit.collider.name == "Montagne")
            {
                var leoTechMakerEnfant = Instantiate(rocher_montagne, hit.point, randomYRotation);
                leoTechMakerEnfant.transform.localScale = randomScale;
                leoTechMaker.array.Add(leoTechMakerEnfant.GetComponent<GroupMaker>());
                leoTechMaker.groupLength++;
            }
        }

        if (objectToDestroy.tag == "Buisson")
        {
            if (hit.collider.name == "Plaine")
            {
                var leoTechMakerEnfant = Instantiate(buisson_plaine, hit.point, randomYRotation);
                leoTechMakerEnfant.transform.localScale = randomScale;
                leoTechMaker.array.Add(leoTechMakerEnfant.GetComponent<GroupMaker>());
                leoTechMaker.groupLength++;
            }
            else if (hit.collider.name == "Marais")
            {
                var leoTechMakerEnfant = Instantiate(buisson_marais, hit.point, randomYRotation);
                leoTechMakerEnfant.transform.localScale = randomScale;
                leoTechMaker.array.Add(leoTechMakerEnfant.GetComponent<GroupMaker>());
                leoTechMaker.groupLength++;
            }
            else if (hit.collider.name == "D�sert")
            {
                var leoTechMakerEnfant = Instantiate(buisson_d�sert, hit.point, randomYRotation);
                leoTechMakerEnfant.transform.localScale = randomScale;
                leoTechMaker.array.Add(leoTechMakerEnfant.GetComponent<GroupMaker>());
                leoTechMaker.groupLength++;
            }
            else if (hit.collider.name == "Montagne")
            {
                var leoTechMakerEnfant = Instantiate(buisson_montagne, hit.point, randomYRotation);
                leoTechMakerEnfant.transform.localScale = randomScale;
                leoTechMaker.array.Add(leoTechMakerEnfant.GetComponent<GroupMaker>());
                leoTechMaker.groupLength++;
            }
        }
    }

    /*private void Pr�renduObjectSpawner()
    {
        while (hit.collider.name == "Plaine")
        {
            if (objectToDestroy.tag == "Arbre")
            {
                objectToDestroy = Instantiate(pr�rendu_arbre_plaine, hit.point, Quaternion.identity);
            }
            else if (objectToDestroy.tag == "Champignon")
            {
                objectToDestroy = Instantiate(pr�rendu_champignon_plaine, hit.point, Quaternion.identity);
            }
            else if (objectToDestroy.tag == "Rocher")
            {
                objectToDestroy = Instantiate(pr�rendu_rocher_plaine, hit.point, Quaternion.identity);
            }
            else if (objectToDestroy.tag == "Buisson")
            {
                objectToDestroy = Instantiate(pr�rendu_buisson_plaine, hit.point, Quaternion.identity);
            }
        }
        while(hit.collider.name == "Marais")
        {
            if (objectToDestroy.tag == "Arbre")
            {
                objectToDestroy = Instantiate(pr�rendu_arbre_marais, hit.point, Quaternion.identity);
            }
            else if (objectToDestroy.tag == "Champignon")
            {
                objectToDestroy = Instantiate(pr�rendu_champignon_marais, hit.point, Quaternion.identity);
            }
            else if (objectToDestroy.tag == "Rocher")
            {
                objectToDestroy = Instantiate(pr�rendu_rocher_marais, hit.point, Quaternion.identity);
            }
            else if (objectToDestroy.tag == "Buisson")
            {
                objectToDestroy = Instantiate(pr�rendu_buisson_marais, hit.point, Quaternion.identity);
            }
        }
        while (hit.collider.name == "D�sert")
        {
            if (objectToDestroy.tag == "Arbre")
            {
                objectToDestroy = Instantiate(pr�rendu_arbre_d�sert, hit.point, Quaternion.identity);
            }
            else if (objectToDestroy.tag == "Champignon")
            {
                objectToDestroy = Instantiate(pr�rendu_champignon_d�sert, hit.point, Quaternion.identity);
            }
            else if (objectToDestroy.tag == "Rocher")
            {
                objectToDestroy = Instantiate(pr�rendu_rocher_d�sert, hit.point, Quaternion.identity);
            }
            else if (objectToDestroy.tag == "Buisson")
            {
                objectToDestroy = Instantiate(pr�rendu_buisson_d�sert, hit.point, Quaternion.identity);
            }
        }
        while (hit.collider.name == "Montagne")
        {
            if (objectToDestroy.tag == "Arbre")
            {
                objectToDestroy = Instantiate(pr�rendu_arbre_montagne, hit.point, Quaternion.identity);
            }
            else if (objectToDestroy.tag == "Champignon")
            {
                objectToDestroy = Instantiate(pr�rendu_champignon_montagne, hit.point, Quaternion.identity);
            }
            else if (objectToDestroy.tag == "Rocher")
            {
                objectToDestroy = Instantiate(pr�rendu_rocher_montagne, hit.point, Quaternion.identity);
            }
            else if (objectToDestroy.tag == "Buisson")
            {
                objectToDestroy = Instantiate(pr�rendu_buisson_montagne, hit.point, Quaternion.identity);
            }
        }
        while (objectToDestroy.tag == "Arbre")
        {
            if (hit.collider.name == "Plaine")
            {
               objectToDestroy = Instantiate(arbre_plaine, hit.point, Quaternion.identity);
            }
            else if (hit.collider.name == "Marais")
            {
               objectToDestroy = Instantiate(arbre_marais, hit.point, Quaternion.identity);
            }
            else if (hit.collider.name == "D�sert")
            {
               objectToDestroy = Instantiate(arbre_d�sert, hit.point, Quaternion.identity);
            }
            else if (hit.collider.name == "Montagne")
            {
               objectToDestroy = Instantiate(arbre_montagne, hit.point, Quaternion.identity);
            }
        }

        while (objectToDestroy.tag == "Champignon")
        {
            if (hit.collider.name == "Plaine")
            {
                objectToDestroy = Instantiate(champignon_plaine, objectToDestroy.transform.position, Quaternion.identity);
            }
            else if (hit.collider.name == "Marais")
            {
                objectToDestroy = Instantiate(champignon_marais, objectToDestroy.transform.position, Quaternion.identity);
            }
            else if (hit.collider.name == "D�sert")
            {
                objectToDestroy = Instantiate(champignon_d�sert, objectToDestroy.transform.position, Quaternion.identity);
            }
            else if (hit.collider.name == "Montagne")
            {
                objectToDestroy = Instantiate(champignon_montagne, objectToDestroy.transform.position, Quaternion.identity);
            }
        }

        while (objectToDestroy.tag == "Rocher")
        {
            if (hit.collider.name == "Plaine")
            {
                objectToDestroy = Instantiate(rocher_plaine, objectToDestroy.transform.position, Quaternion.identity);
            }
            else if (hit.collider.name == "Marais")
            {
                objectToDestroy = Instantiate(rocher_marais, objectToDestroy.transform.position, Quaternion.identity);
            }
            else if (hit.collider.name == "D�sert")
            {
                objectToDestroy = Instantiate(rocher_d�sert, objectToDestroy.transform.position, Quaternion.identity);
            }
            else if (hit.collider.name == "Montagne")
            {
                objectToDestroy = Instantiate(rocher_montagne, objectToDestroy.transform.position, Quaternion.identity);
            }
        }

        while (objectToDestroy.tag == "Buisson")
        {
            if (hit.collider.name == "Plaine")
            {
                objectToDestroy = Instantiate(buisson_plaine, objectToDestroy.transform.position, Quaternion.identity);
            }
            else if (hit.collider.name == "Marais")
            {
                objectToDestroy = Instantiate(buisson_marais, objectToDestroy.transform.position, Quaternion.identity);
            }
            else if (hit.collider.name == "D�sert")
            {
                objectToDestroy = Instantiate(buisson_d�sert, objectToDestroy.transform.position, Quaternion.identity);
            }
            else if (hit.collider.name == "Montagne")
            {
                objectToDestroy = Instantiate(buisson_montagne, objectToDestroy.transform.position, Quaternion.identity);
            }
        }
    }*/
}
