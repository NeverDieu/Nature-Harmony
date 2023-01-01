using UnityEngine;
using System.Collections.Generic;

public class GroupFabricator : MonoBehaviour
{
    public List<GroupMaker> buddha;

    void Start()
    {
        buddha = new List<GroupMaker>();
        buddha.Add(gameObject.GetComponent<GroupMaker>());
    }

    private void Update()
    {
        if(GameObject.Find(buddha[buddha.Count].nameTag))
        {
            buddha.Clear();
            buddha.Add(GameObject.Find(buddha[buddha.Count].nameTag).GetComponent<GroupMaker>());
        }
    }

    public void GroupManager(GameObject group, int groupNumber)
    {
        //GameObject.Find(buddha[buddha.Count].nameTag).GetComponent<GroupMaker>().enabled = false;

        groupNumber++;

        group = new GameObject("Group " + groupNumber);

        group.AddComponent<SphereCollider>().isTrigger = true;
        group.GetComponent<SphereCollider>().radius = 10f;
        group.GetComponent<SphereCollider>().center = new Vector3(0f, 3f, 0f);
        

        group.transform.parent = gameObject.transform;
        buddha[buddha.Count].gameObject.transform.parent = group.transform;
    }
}
