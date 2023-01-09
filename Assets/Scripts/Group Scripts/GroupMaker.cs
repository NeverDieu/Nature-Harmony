using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupMaker : MonoBehaviour
{
    public string nameTag;

    public int id;

    public SphereCollider influence;

    private ObjectPlacement canvas;

    private GroupFabricator groupFabricator;

    private GameObject empty, groupHierarchie;

    //public Collider boxes;

    public int numberOfGroups;

    public bool isInGroup;

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
        empty = GameObject.Find("PlaceHolder");

        gameObjects = new List<GameObject>();

        gameObjects.Add(gameObject);
    }

    private void Update()
    {
        //GroupBounderies();
        
        if (groupLength < 3)
        {
            isInGroup = false;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        //Physics.IgnoreCollision(GetComponent<BoxCollider>(), other.GetComponent<BoxCollider>());

        if (influence.name == other.name)
        {
            var groupObjects = other.gameObject;
            var selfGrouper = gameObject;

            gameObjects.Add(groupObjects);

            groupLength += 1;

            if (groupLength >= 3)
            {
                isInGroup = true;

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
