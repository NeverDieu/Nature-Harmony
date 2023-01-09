using UnityEngine;
using System.Collections.Generic;

public class GroupFabricator : MonoBehaviour
{
    public List<GameObject> groups;

    void Start()
    {
        groups = new List<GameObject>();
        //buddha.Add(gameObject.GetComponent<GameObject>());
    }

    private void Update()
    {

    }

    public void GroupManager(GameObject groupMaker, GameObject groupHierarchie, int groupNumber)
    { 
        var maker = groupMaker.GetComponent<GroupMaker>();

        string[] x = maker.nameTag.Split("_");
        string[] xx = x[1].Split("(Clone)");
        

        groupHierarchie = new GameObject();

        groups.Add(groupHierarchie);

        groupHierarchie.name = "Group of " + x[0] + " " + xx[0] + " " + groups.Count;

        groupHierarchie.tag = maker.tag;

        groupHierarchie.AddComponent<SphereCollider>().isTrigger = true;
        groupHierarchie.GetComponent<SphereCollider>().radius = 20f;

        groupHierarchie.AddComponent<GroupContainer>();

        foreach (GameObject element in maker.gameObjects)
        {
            element.transform.parent = groupHierarchie.transform;
        }

        groupHierarchie.transform.parent = gameObject.transform;
    }
}
