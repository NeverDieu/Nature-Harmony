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

    string[] x;

    bool hotLine;
    private void Start()
    {
        randomColor = Random.ColorHSV();

        targets = new List<Transform>();

        groupHierarchie = GameObject.Find("Groups");

        var sphereCollider = GetComponent<SphereCollider>();

        childNumber = gameObject.transform.childCount;

        for (int i = 0; i < childNumber; i++)
        {
            x = GetComponentInChildren<Transform>().GetChild(i).GetComponent<GroupMaker>().name.Split("(Clone)");

            targets.Add(GetComponentInChildren<Transform>().GetChild(i));
            GetComponentInChildren<Transform>().GetChild(i).GetComponent<GroupMaker>().gameObjects.Clear();
            GetComponentInChildren<Transform>().GetChild(i).GetComponent<GroupMaker>().groupLength = 0;
            GetComponentInChildren<Transform>().GetChild(i).GetComponent<GroupMaker>().enabled = false;
            GetComponentInChildren<Transform>().GetChild(i).GetComponent<SphereCollider>().enabled = false;
            if (targets == null)
            {
                GameObject.Destroy(gameObject);
            }
            GetComponentInChildren<Transform>().GetChild(i).GetComponentInChildren<Outline>().OutlineMode = Outline.Mode.OutlineVisible;
            GetComponentInChildren<Transform>().GetChild(i).GetComponentInChildren<Outline>().OutlineColor = randomColor;
        }

        Vector3 centerPoint = GetCenterPoint();

        sphereCollider.center = centerPoint;
    }

    private void Update()
    {
        for (int i = 0; i < targets.Count; i++)
        {
            if (GetComponentInChildren<Transform>().GetChild(i) == null)
            {
                targets.Remove(GetComponentInChildren<Transform>().GetChild(i));
            }
        }

        if (hotLine == true)
        {
            for (int i = 0; i < targets.Count; i++)
                GetComponentInChildren<Transform>().GetChild(i).GetComponentInChildren<Outline>().enabled = true;
        }
        else
        {
            for (int i = 0; i < targets.Count; i++)
                GetComponentInChildren<Transform>().GetChild(i).GetComponentInChildren<Outline>().enabled = false;
        }

        if (Input.GetMouseButton(1))
        {
            hotLine = false;
            for (int i = 0; i < targets.Count; i++)
                GetComponentInChildren<Transform>().GetChild(i).GetComponentInChildren<Outline>().enabled = false;
        }

        if (targets.Count < 3)
        {
            for (int i = 0; i < targets.Count; i++)
            {
                GetComponentInChildren<Transform>().GetChild(i).parent = null;
            }
        }
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
        if (other.name.Contains(x[0]) && other.name.Contains("prérendu"))
        {
            label.enabled = true;
            label.SetText(gameObject.name);

            hotLine = true;
        }

        if (!other.name.Contains(x[0]) && other.name.Contains("prérendu"))
            hotLine = false;

        if (other.name.Contains(x[0]) && !other.name.Contains("prérendu"))
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
        if (other.name.Contains(x[0]) && other.name.Contains("prérendu"))
        {
            var label = other.GetComponentInChildren<TextMeshPro>();
            label.enabled = false;
            label.SetText("");

            hotLine = false;
        }
    }
}
