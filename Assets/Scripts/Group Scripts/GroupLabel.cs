using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GroupLabel : MonoBehaviour
{
    public Transform cam;

    private TextMeshPro label;
    private void Start()
    {
        cam = GameObject.Find("CameraPivot").transform;
        label = GetComponent<TextMeshPro>();
        
    }
    void LateUpdate()
    {
        label.rectTransform.LookAt(label.rectTransform.position + cam.forward);

        if (Input.GetMouseButton(1))
        {
            label.SetText("");
            gameObject.transform.position = new Vector3(0f, -1000f, 0f);
        }
    }
}

