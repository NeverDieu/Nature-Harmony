using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupMaker : MonoBehaviour
{
    public string nameTag;

    public SphereCollider influence;

    private ObjectPlacement canvas;

    private GroupFabricator groupFabricator;

    private GameObject groupHierarchie;

    private int numberOfGroups;

    public int groupLength;

    public List<GameObject> gameObjects;

    void Start()
    {
        groupFabricator = GameObject.Find("Groups").GetComponent<GroupFabricator>();

        influence = gameObject.GetComponent<SphereCollider>();
        canvas = GameObject.Find("Canvas").GetComponentInChildren<ObjectPlacement>();

        nameTag = gameObject.name;
        groupLength = 1;

        groupHierarchie = GameObject.Find("Groups");

        gameObjects = new List<GameObject>();

        gameObjects.Add(gameObject);
    }

    public void OnTriggerEnter(Collider other)
    {

        if (gameObject.name.Contains(other.name))
        {
            var groupObjects = other.gameObject;
            var selfGrouper = gameObject;

            gameObjects.Add(groupObjects);

            Debug.Log(other);

            groupLength += 1;

            if (groupLength >= 3 && gameObjects.Count >= 3 && !other.GetComponent<MeshCollider>())
            {
                groupObjects.GetComponent<GroupMaker>().gameObjects = gameObjects;
                if (gameObjects[0] == other.gameObject)
                {
                    groupFabricator.GroupManager(selfGrouper, groupHierarchie, numberOfGroups);
                }
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (influence.name == other.name && groupLength >= 3)
        {
            gameObjects.Remove(gameObject);
            groupLength--;
        }
        else if (influence.name == other.name && groupLength < 3)
        {
            gameObjects.Remove(other.gameObject);
            groupLength--;
        }
    }
}
