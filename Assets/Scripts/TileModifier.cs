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
    private Button myButtonUI;

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
        myButtonUI = GameObject.Find("Canvas").GetComponentInChildren<Button>();

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
        //Permet de selectionné une autre tuile en déselectionnant la précédente.
        if (gameObject.GetComponent<Renderer>().material.color == color && transform != trSelect)
        {
            isSelected = false;
            rendu.material.color = Color.white;
            myCanvasUI.enabled = !myCanvasUI.enabled;
            Debug.Log("Je fais chié");
        }


        if (isSelected == true && myCanvasUI.enabled == true)
        {
            tile.transform.localScale = new Vector3(10f, mySlider, 10f);
            if (mySlider >= 1)
            {
                tile.transform.position = new Vector3(tile.transform.position.x, mySlider * 0.5f, tile.transform.position.z);
            }
        }

/*        Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(cast, out hit, 100f))
        {
            if (hit.collider.tag == "Tile")
            { 
                this.rendu.material.color = Color.cyan;
            }
        }*/
    }

    //Permet de selectionné et déselectionné une tuile
    private void OnMouseDown()
    {
        if (gameObject.tag == "Tile")
        {
            if (gameObject.GetComponent<Renderer>().material.color == color && isSelected == true)
            {
                rendu.material.color = Color.white;
                isSelected = false;
                myCanvasUI.enabled = !myCanvasUI.enabled;
                Debug.Log("Déselectionné");
            }

            if (gameObject.GetComponent<Renderer>().material.color == Color.cyan && isSelected == false)
            {
                rendu.material.color = Color.black;
                isSelected = true;
                trSelect = transform;
                myCanvasUI.enabled = !myCanvasUI.enabled;
                Debug.Log("Selectionné");
            }
        }
    }
}
