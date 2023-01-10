using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GroupContainer : MonoBehaviour
{
    public List<Transform> targets;

    GameObject groupHierarchie;

    Color randomColor;

    int childNumber;
    private void Start()
    {
        randomColor = Random.ColorHSV();

        targets = new List<Transform>();

        groupHierarchie = GameObject.Find("Groups");

        var sphereCollider = GetComponent<SphereCollider>();

        childNumber = gameObject.transform.childCount;

        for (int i = 0; i < childNumber; i++)
        {
            targets.Add(GetComponentInChildren<Transform>().GetChild(i));
            GetComponentInChildren<Transform>().GetChild(i).GetComponent<GroupMaker>().gameObjects.Clear();
            GetComponentInChildren<Transform>().GetChild(i).GetComponent<GroupMaker>().groupLength = 0;
            GetComponentInChildren<Transform>().GetChild(i).GetComponent<GroupMaker>().isInGroup = false;
            GetComponentInChildren<Transform>().GetChild(i).GetComponent<GroupMaker>().enabled = false;
            GetComponentInChildren<Transform>().GetChild(i).GetComponent<SphereCollider>().enabled = false;
            if (targets == null)
            {
                GameObject.Destroy(gameObject);
            }
            GetComponentInChildren<Transform>().GetChild(i).GetComponentInChildren<Outline>().OutlineColor = randomColor;
        }

        Vector3 centerPoint = GetCenterPoint();

        sphereCollider.center = centerPoint;
    }

    public Vector3 GetCenterPoint()
    {
        var bounds = new Bounds(targets[0].position, Vector3.zero);
        for (int i = 0; i < targets.Count; i++)
        {
            bounds.Encapsulate(targets[i].position);
        }

        return bounds.center;
    }

    private void OnTriggerEnter(Collider other)
    {
        var label = other.GetComponentInChildren<TextMeshPro>();
        if (other.CompareTag(gameObject.tag) && other.name.Contains("prérendu"))
        {
            
            label.enabled = true;
            label.SetText(gameObject.name);

            for(int i = 0; i < targets.Count; i++)
            GetComponentInChildren<Transform>().GetChild(i).GetComponentInChildren<Outline>().enabled = true;
        }

        if (other.CompareTag(gameObject.tag) && !other.name.Contains("prérendu"))
        {
            targets.Add(other.GetComponent<Transform>());
            other.transform.parent = groupHierarchie.transform;
            other.transform.parent = gameObject.transform;
            other.GetComponent<GroupMaker>().gameObjects.Clear();
            other.GetComponent<GroupMaker>().enabled = false;
            other.GetComponent<SphereCollider>().enabled = false;
            other.GetComponentInChildren<Outline>().OutlineColor = randomColor;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(gameObject.tag) && other.name.Contains("prérendu"))
        {
            var label = other.GetComponentInChildren<TextMeshPro>();
            label.enabled = false;
            label.SetText("");

            for (int i = 0; i < targets.Count; i++)
                GetComponentInChildren<Transform>().GetChild(i).GetComponentInChildren<Outline>().enabled = false;
        }
    }
}
