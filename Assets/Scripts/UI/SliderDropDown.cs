using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderDropDown : MonoBehaviour
{
    [SerializeField]
    private Toggle myToggle;

    [SerializeField]
    private RectTransform panelTransform;

    [SerializeField]
    private Transform inventoryTransform;

    [SerializeField]
    private Image rightArrow, leftArrow;

    [SerializeField]
    private float speed = 200f;

    [SerializeField]
    private bool isActive;

    private Vector3 target;

    private void Update()
    {
        SlideOff();
    }

    public void SlideOff()
    {
        if (myToggle.isOn)
        {
            target = new Vector3(-352f, 87f, 0f);
            panelTransform.localPosition = Vector3.MoveTowards(panelTransform.localPosition, target, Time.deltaTime * speed);
            inventoryTransform.localPosition = Vector3.MoveTowards(inventoryTransform.localPosition, target, Time.deltaTime * speed);
            rightArrow.enabled = false;
            leftArrow.enabled = true;
        }
        else
        {
            target = new Vector3(-433f, 87f, 0f);
            panelTransform.localPosition = Vector3.MoveTowards(panelTransform.localPosition, target, Time.deltaTime * speed);
            inventoryTransform.localPosition = Vector3.MoveTowards(inventoryTransform.localPosition, target, Time.deltaTime * speed);
            rightArrow.enabled = true;
            leftArrow.enabled = false;

        }

    }
}
