using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TileModifier : MonoBehaviour
{
    [SerializeField]
    private GameObject tile;

    [SerializeField]
    private Renderer rendu;

    [SerializeField]
    private Slider mySliderUI;

    [SerializeField]
    private Canvas myCanvasUI;

    [SerializeField]
    private Color color = Color.black;

    [Range(1, 10)]
    public int mySlider;

    static private Transform trSelect = null;

    [SerializeField]
    private bool isSelected = false;

    private void Start()
    {
        rendu = GetComponent<Renderer>();

        myCanvasUI = tile.GetComponentInChildren<Canvas>();
        mySliderUI = tile.GetComponentInChildren<Slider>();

        myCanvasUI.enabled = !myCanvasUI.enabled;

        mySliderUI.value = 1;
        mySliderUI.minValue = 1;
        mySliderUI.maxValue = 10;
    }

    private void OnMouseEnter()
    {
        if (isSelected != true)
        {
            rendu.material.color = Color.cyan;
        }
    }

    private void OnMouseExit()
    {
        if (isSelected != true)
        {
            rendu.material.color = Color.white;
        }
    }

    public void Scale(float scaleValue)
    {
        mySlider = Mathf.RoundToInt(scaleValue);
    }

    private void Update()
    {
        if(isSelected && transform != trSelect)
        {
            isSelected = false;
            rendu.material.color = Color.white;
            myCanvasUI.enabled = !myCanvasUI;
        }

        if (isSelected != false)
        {
            tile.transform.localScale = new Vector3(10f, mySlider, 10f);
            if (mySlider >= 1)
            {
                tile.transform.position = new Vector3(tile.transform.position.x, mySlider * 0.5f, tile.transform.position.z);
            }
        }

        if(Input.GetKeyDown("mouse 0") && isSelected != false)
        {
            Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(cast, out hit, 100f))
            {
                if(hit.collider.tag == "Canvas")
                {
                    rendu.material.color = Color.white;
                    Debug.Log("Dans le vide");
                }
            }
        }
    }

    private void OnMouseDown()
    {
        isSelected = true;
        trSelect = transform;
        rendu.material.color = color;
        myCanvasUI.enabled = !myCanvasUI.enabled;
    }
}
