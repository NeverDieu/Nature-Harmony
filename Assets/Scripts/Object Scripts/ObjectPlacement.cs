using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectPlacement : MonoBehaviour
{
    public GameObject arbre_plaine, arbre_marais, arbre_désert, arbre_montagne,
    champignon_plaine, champignon_marais, champignon_désert, champignon_montagne,
    rocher_plaine, rocher_marais, rocher_désert, rocher_montagne,
    buisson_plaine, buisson_marais, buisson_désert, buisson_montagne,
    fleur_plaine, fleur_marais, fleur_désert, fleur_montagne,
    placeHolder, objectToDestroy;

    //Quel Layers le Raycast peut toucher
    public LayerMask hitLayers;
    //Un rendu de l'objet qui va être placé
    [Header("Arbres")]
    public GameObject arbre_plaine_prérendu; public GameObject arbre_marais_prérendu; public GameObject arbre_désert_prérendu; public GameObject arbre_montagne_prérendu;
    [Header("Champignon")]
    public GameObject champignon_plaine_prérendu; public GameObject champignon_marais_prérendu; public GameObject champignon_désert_prérendu; public GameObject champignon_montagne_prérendu;
    [Header("Rocher")]
    public GameObject rocher_plaine_prérendu; public GameObject rocher_marais_prérendu; public GameObject rocher_désert_prérendu; public GameObject rocher_montagne_prérendu;
    [Header("Buisson")]
    public GameObject buisson_plaine_prérendu; public GameObject buisson_marais_prérendu; public GameObject buisson_désert_prérendu; public GameObject buisson_montagne_prérendu;
    [Header("Fleur")]
    public GameObject fleur_plaine_prérendu; public GameObject fleur_marais_prérendu; public GameObject fleur_désert_prérendu; public GameObject fleur_montagne_prérendu;

    private RaycastHit hit;

    private Vector3 spawnPoint = new Vector3(0f, -1000f, 0f);

    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);

        if (Physics.Raycast(castPoint, out hit, Mathf.Infinity, hitLayers))
        {
            if (Input.GetMouseButtonDown(0))
            {
                ObjectSpawner();
            }

            if (objectToDestroy != null)
            {
                gameObject.transform.position = hit.point;
                objectToDestroy.transform.position = hit.point;
            }
        }

        if (Input.GetMouseButton(1) && objectToDestroy != null)
        {
            var outLineMiami = GameObject.Find("Groups").GetComponent<GroupFabricator>().GetComponentInChildren<GroupContainer>();
            if (outLineMiami != null)
            {
                for (int i = 0; i < outLineMiami.targets.Count; i++)
                {
                    outLineMiami.GetComponentInChildren<Transform>().GetChild(i).GetComponentInChildren<Outline>().enabled = false;
                }
            }
            var labelCleaner = objectToDestroy.GetComponentInChildren<TextMeshPro>();
            labelCleaner.SetText("");
            objectToDestroy.SetActive(false);
        }
        else if (objectToDestroy != null)
        {
            objectToDestroy.SetActive(true);
        }
    }

    public void Arbre()
    {
        Destroy(objectToDestroy);

        objectToDestroy = Instantiate(arbre_plaine_prérendu, spawnPoint, Quaternion.identity);

        objectToDestroy.transform.parent = gameObject.transform;
    }

    public void Champignon()
    {
        Destroy(objectToDestroy);

        objectToDestroy = Instantiate(champignon_plaine_prérendu, spawnPoint, Quaternion.identity);

        objectToDestroy.transform.parent = gameObject.transform;
    }

    public void Rocher()
    {
        Destroy(objectToDestroy);

        objectToDestroy = Instantiate(rocher_plaine_prérendu, spawnPoint, Quaternion.identity);

        objectToDestroy.transform.parent = gameObject.transform;
    }

    public void Buisson()
    {
        Destroy(objectToDestroy);

        objectToDestroy = Instantiate(buisson_plaine_prérendu, spawnPoint, Quaternion.identity);

        objectToDestroy.transform.parent = gameObject.transform;
    }

    public void Fleur()
    {
        Destroy(objectToDestroy);

        objectToDestroy = Instantiate(fleur_plaine_prérendu, spawnPoint, Quaternion.identity);

        objectToDestroy.transform.parent = gameObject.transform;
    }

    private void ObjectSpawner()
    {
        if (objectToDestroy.CompareTag("Arbre"))
        {
            if (hit.collider.name == "Plaine")
            {
                Instantiate(arbre_plaine, hit.point, Quaternion.identity);
                FMODUnity.RuntimeManager.PlayOneShot("event:/Guitar/Guitar Plain/GP Feedbacks/Note/Note");
            }
            else if (hit.collider.name == "Marais")
            {
                Instantiate(arbre_marais, hit.point, Quaternion.identity);
                FMODUnity.RuntimeManager.PlayOneShot("event:/Guitar/Guitar Swamp/GS Feedbacks/Note/Note");

            }
            else if (hit.collider.name == "Désert")
            {
                Instantiate(arbre_désert, hit.point, Quaternion.identity);
                FMODUnity.RuntimeManager.PlayOneShot("event:/Guitar/Guitar Desert/GD Feedbacks/Note/Note");

            }
            else if (hit.collider.name == "Montagne")
            {
                Instantiate(arbre_montagne, hit.point, Quaternion.identity);
                FMODUnity.RuntimeManager.PlayOneShot("event:/Guitar/Guitar Mountain/GM Feedbacks/Note/Note");

            }
        }

        if (objectToDestroy.CompareTag("Champignon"))
        {
            if (hit.collider.name == "Plaine")
            {
               Instantiate(champignon_plaine, hit.point, Quaternion.identity);
               FMODUnity.RuntimeManager.PlayOneShot("event:/Piano/Piano Plain/PP Feedbacks/Note/Note");

            }
            else if (hit.collider.name == "Marais")
            {
                Instantiate(champignon_marais, hit.point, Quaternion.identity);
                FMODUnity.RuntimeManager.PlayOneShot("event:/Piano/Piano Swamp/PS Feedbacks/Note/Note");

            }
            else if (hit.collider.name == "Désert")
            {
                Instantiate(champignon_désert, hit.point, Quaternion.identity);
                FMODUnity.RuntimeManager.PlayOneShot("event:/Piano/Piano Desert/PD Feedbacks/Note/Note");

            }
            else if (hit.collider.name == "Montagne")
            {
                Instantiate(champignon_montagne, hit.point, Quaternion.identity);
                FMODUnity.RuntimeManager.PlayOneShot("event:/Piano/Piano Mountain/PM Feedbacks/Note/Note");

            }
        }

        if (objectToDestroy.CompareTag("Rocher"))
        {
            if (hit.collider.name == "Plaine")
            {
                Instantiate(rocher_plaine, hit.point, Quaternion.identity);
                FMODUnity.RuntimeManager.PlayOneShot("event:/Bass/Bass Plain/BP Feedbacks/Note/Note");
            }
            else if (hit.collider.name == "Marais")
            {
                Instantiate(rocher_marais, hit.point, Quaternion.identity);
                FMODUnity.RuntimeManager.PlayOneShot("event:/Bass/Bass Swamp/Bs Feedbacks/Note/Note");
            }
            else if (hit.collider.name == "Désert")
            {
                Instantiate(rocher_désert, hit.point, Quaternion.identity);
                FMODUnity.RuntimeManager.PlayOneShot("event:/Bass/Bass Desert/BD Feedbacks/Note/Note");
            }
            else if (hit.collider.name == "Montagne")
            {
                Instantiate(rocher_montagne, hit.point, Quaternion.identity);
                FMODUnity.RuntimeManager.PlayOneShot("event:/Bass/Bass Mountain/BM Feedbacks/Note/Note");
            }
        }

        if (objectToDestroy.CompareTag("Buisson"))
        {
            if (hit.collider.name == "Plaine")
            {
                Instantiate(buisson_plaine, hit.point, Quaternion.identity);
                FMODUnity.RuntimeManager.PlayOneShot("event:/Violin/Violin Plain/VP Feedbacks/Note/Note");
            }
            else if (hit.collider.name == "Marais")
            {
                Instantiate(buisson_marais, hit.point, Quaternion.identity);
                FMODUnity.RuntimeManager.PlayOneShot("event:/Violin/Violin Swamp/VS Feedbacks/Note/Note");
            }
            else if (hit.collider.name == "Désert")
            {
                Instantiate(buisson_désert, hit.point, Quaternion.identity);
                FMODUnity.RuntimeManager.PlayOneShot("event:/Violin/Violin Desert/VD Feedbacks/Note/Note");
            }
            else if (hit.collider.name == "Montagne")
            {
                Instantiate(buisson_montagne, hit.point, Quaternion.identity);
                FMODUnity.RuntimeManager.PlayOneShot("event:/Violin/Violin Mountain/VM Feedbacks/Note/Note");
            }
        }

        if (objectToDestroy.CompareTag("Fleur"))
        {
            if (hit.collider.name == "Plaine")
            {
                Instantiate(fleur_plaine, hit.point, Quaternion.identity);
                FMODUnity.RuntimeManager.PlayOneShot("event:/Piano/Piano Plain/PP Feedbacks/Note/Note");
            }
            else if (hit.collider.name == "Marais")
            {
                Instantiate(fleur_marais, hit.point, Quaternion.identity);
                FMODUnity.RuntimeManager.PlayOneShot("event:/Piano/Piano Swamp/PS Feedbacks/Note/Note");
            }
            else if (hit.collider.name == "Désert")
            {
                Instantiate(fleur_désert, hit.point, Quaternion.identity);
                FMODUnity.RuntimeManager.PlayOneShot("event:/Piano/Piano Desert/PD Feedbacks/Note/Note");
            }
            else if (hit.collider.name == "Montagne")
            {
                Instantiate(fleur_montagne, hit.point, Quaternion.identity);
                FMODUnity.RuntimeManager.PlayOneShot("event:/Piano/Piano Mountain/PM Feedbacks/Note/Note");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (objectToDestroy.CompareTag("Arbre"))
        {
            if (other.name == "Plaine")
            {
                Destroy(objectToDestroy);

                objectToDestroy = Instantiate(arbre_plaine_prérendu, spawnPoint, Quaternion.identity);

                objectToDestroy.transform.parent = gameObject.transform;
            }
            else if (other.name == "Marais")
            {
                Destroy(objectToDestroy);

                objectToDestroy = Instantiate(arbre_marais_prérendu, spawnPoint, Quaternion.identity);

                objectToDestroy.transform.parent = gameObject.transform;
            }
            else if (other.name == "Désert")
            {
                Destroy(objectToDestroy);

                objectToDestroy = Instantiate(arbre_désert_prérendu, spawnPoint, Quaternion.identity);

                objectToDestroy.transform.parent = gameObject.transform;
            }
            else if (other.name == "Montagne")
            {
                Destroy(objectToDestroy);

                objectToDestroy = Instantiate(arbre_montagne_prérendu, spawnPoint, Quaternion.identity);

                objectToDestroy.transform.parent = gameObject.transform;
            }
        }

        if (objectToDestroy.CompareTag("Champignon"))
        {
            if (other.name == "Plaine")
            {
                Destroy(objectToDestroy);

                objectToDestroy = Instantiate(champignon_plaine_prérendu, spawnPoint, Quaternion.identity);

                objectToDestroy.transform.parent = gameObject.transform;
            }
            else if (other.name == "Marais")
            {
                Destroy(objectToDestroy);

                objectToDestroy = Instantiate(champignon_marais_prérendu, spawnPoint, Quaternion.identity);

                objectToDestroy.transform.parent = gameObject.transform;
            }
            else if (other.name == "Désert")
            {
                Destroy(objectToDestroy);

                objectToDestroy = Instantiate(champignon_désert_prérendu, spawnPoint, Quaternion.identity);

                objectToDestroy.transform.parent = gameObject.transform;
            }
            else if (other.name == "Montagne")
            {
                Destroy(objectToDestroy);

                objectToDestroy = Instantiate(champignon_montagne_prérendu, spawnPoint, Quaternion.identity);

                objectToDestroy.transform.parent = gameObject.transform;
            }
        }

        if (objectToDestroy.CompareTag("Rocher"))
        {
            if (other.name == "Plaine")
            {
                Destroy(objectToDestroy);

                objectToDestroy = Instantiate(rocher_plaine_prérendu, spawnPoint, Quaternion.identity);

                objectToDestroy.transform.parent = gameObject.transform;
            }
            else if (other.name == "Marais")
            {
                Destroy(objectToDestroy);

                objectToDestroy = Instantiate(rocher_marais_prérendu, spawnPoint, Quaternion.identity);

                objectToDestroy.transform.parent = gameObject.transform;
            }
            else if (other.name == "Désert")
            {
                Destroy(objectToDestroy);

                objectToDestroy = Instantiate(rocher_désert_prérendu, spawnPoint, Quaternion.identity);

                objectToDestroy.transform.parent = gameObject.transform;
            }
            else if (other.name == "Montagne")
            {
                Destroy(objectToDestroy);

                objectToDestroy = Instantiate(rocher_montagne_prérendu, spawnPoint, Quaternion.identity);

                objectToDestroy.transform.parent = gameObject.transform;
            }
        }

        if (objectToDestroy.CompareTag("Buisson"))
        { 
            if (other.name == "Plaine")
            {
                Destroy(objectToDestroy);

                objectToDestroy = Instantiate(buisson_plaine_prérendu, spawnPoint, Quaternion.identity);

                objectToDestroy.transform.parent = gameObject.transform;
            }
            else if (other.name == "Marais")
            {
                Destroy(objectToDestroy);

                objectToDestroy = Instantiate(buisson_marais_prérendu, spawnPoint, Quaternion.identity);

                objectToDestroy.transform.parent = gameObject.transform;
            }
            else if (other.name == "Désert")
            {
                Destroy(objectToDestroy);

                objectToDestroy = Instantiate(buisson_désert_prérendu, spawnPoint, Quaternion.identity);

                objectToDestroy.transform.parent = gameObject.transform;
            }
            else if (other.name == "Montagne")
            {
                Destroy(objectToDestroy);

                objectToDestroy = Instantiate(buisson_montagne_prérendu, spawnPoint, Quaternion.identity);

                objectToDestroy.transform.parent = gameObject.transform;
            }
        }

        if (objectToDestroy.CompareTag("Fleur"))
        {
            if (other.name == "Plaine")
            {
                Destroy(objectToDestroy);

                objectToDestroy = Instantiate(fleur_plaine_prérendu, spawnPoint, Quaternion.identity);

                objectToDestroy.transform.parent = gameObject.transform;
            }
            else if (other.name == "Marais")
            {
                Destroy(objectToDestroy);

                objectToDestroy = Instantiate(fleur_marais_prérendu, spawnPoint, Quaternion.identity);

                objectToDestroy.transform.parent = gameObject.transform;
            }
            else if (other.name == "Désert")
            {
                Destroy(objectToDestroy);

                objectToDestroy = Instantiate(fleur_désert_prérendu, spawnPoint, Quaternion.identity);

                objectToDestroy.transform.parent = gameObject.transform;
            }
            else if (other.name == "Montagne")
            {
                Destroy(objectToDestroy);

                objectToDestroy = Instantiate(fleur_montagne_prérendu, spawnPoint, Quaternion.identity);

                objectToDestroy.transform.parent = gameObject.transform;
            }
        }
    }
}
