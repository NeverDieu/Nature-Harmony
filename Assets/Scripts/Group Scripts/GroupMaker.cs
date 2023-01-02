using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupMaker : MonoBehaviour
{
    public string nameTag;

    public SphereCollider influence;

    public ObjectPlacement canvas;

    private GroupFabricator groupFabricator;

    public GameObject empty, groupHierarchie;

    public int numberOfGroups;

    public bool isInGroup;

    public int groupLength;

    public List<GroupMaker> array;

    public List<Transform> transforms;

    [SerializeField]
    private List<BoxCollider> ignoreTerrain;

    void Start()
    {
        ignoreTerrain[0] = GameObject.Find("Plaine").GetComponent<BoxCollider>();
        ignoreTerrain[1] = GameObject.Find("Marais").GetComponent<BoxCollider>();
        ignoreTerrain[2] = GameObject.Find("Désert").GetComponent<BoxCollider>();
        ignoreTerrain[3] = GameObject.Find("Montagne").GetComponent<BoxCollider>();
        ignoreTerrain[4] = GetComponent<BoxCollider>();

        influence = gameObject.GetComponent<SphereCollider>();
        
        canvas = GameObject.Find("Canvas").GetComponentInChildren<ObjectPlacement>();
        groupHierarchie = GameObject.Find("groupHierarchie");
        nameTag = canvas.arbre_plaine.name + "(Clone)";
        groupLength++;

        groupHierarchie = GameObject.Find("Groups");
        empty = GameObject.Find("PlaceHolder");

        /*array = new List<GroupMaker>();
        array.Add(GetComponent<GroupMaker>());
        array[0] = GetComponent<GroupMaker>();*/

        transforms = new List<Transform>();
        transforms.Add(GetComponent<Transform>());
        transforms[0] = GetComponent<Transform>();

        Physics.IgnoreCollision(influence, ignoreTerrain[0]);
        Physics.IgnoreCollision(influence, ignoreTerrain[1]);
        Physics.IgnoreCollision(influence, ignoreTerrain[2]);
        Physics.IgnoreCollision(influence, ignoreTerrain[3]);
        Physics.IgnoreCollision(influence, ignoreTerrain[4]);
    }

    private void Update()
    {
        //GroupBounderies();
    }

    public void OnTriggerEnter(Collider other)
    {
        ignoreTerrain[5] = other.GetComponent<BoxCollider>();
        Physics.IgnoreCollision(influence, ignoreTerrain[5]);
        if (influence.name == nameTag)
        {
            array.Add(other.GetComponent<GroupMaker>());
            //array[0] = GetComponent<GroupMaker>();
            transforms.Add(other.GetComponent<Transform>());
            //transforms[0] = GetComponent<Transform>();
            groupLength++;

            if (groupLength >= 3 && groupLength <= 8)
            {
                isInGroup = true;
                //groupFabricator.GroupManager(empty, numberOfGroups);
                foreach (GroupMaker element in array)
                {
                    
                    element.groupLength = array.Count;
                    element.array = array;
                    element.transforms = transforms;
                    //element.GetComponent<SphereCollider>().enabled = false;
                    element.isInGroup = true;
                }
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        
        groupLength--;
        array.RemoveAt(groupLength);
        transforms.RemoveAt(groupLength);
        
        GroupMaker nulleBOUH;
        nulleBOUH = other.GetComponent<GroupMaker>();

        if (groupLength < 3)
        {
            foreach (GroupMaker element in array)
            {
                isInGroup = false;
            }
        }
    }

    private void GroupManager(GameObject group, int groupNumber)
    {   
        groupNumber++;

        group.transform.parent = groupHierarchie.transform;

        group = new GameObject("Group " + groupNumber);

        gameObject.transform.parent = group.transform;

        group.AddComponent<SphereCollider>().isTrigger = true;
        group.GetComponent<SphereCollider>().radius = 10f;
        //group.GetComponent<SphereCollider>().center = new Vector3(0f, 3f, 0f);
        

        var bound = new Bounds(transforms[0].position, Vector3.zero);

        bound.Encapsulate(transforms[0].position);

        group.transform.position = bound.center;
    }
}
