using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSelection : MonoBehaviour
{
    List<GameObject> UIelements;

    private void Start()
    {
        UIelements = new List<GameObject>();

        for (int i = 0; i < gameObject.transform.childCount; i++)
            UIelements.Add(GetComponent<Transform>().GetChild(i).gameObject);

        UIelements[5].SetActive(false);
    }
    public void PlayButton()
    {
        SceneManager.LoadScene("NatureHarmony", LoadSceneMode.Single);
    }

    public void OptionsButton()
    {

    }

    public void CreditsButton()
    {

    }

    public void QuitButton()
    {
        for (int i = 0; i < 5; i++)
            UIelements[i].SetActive(false);

        UIelements[5].SetActive(true);
    }

    public void OuiButton()
    {
        Debug.LogWarning("Application se quitte");
        Application.Quit();
    }

    public void NonButton()
    {
        for (int i = 0; i < 5; i++)
            UIelements[i].SetActive(true);

        UIelements[5].SetActive(false);
    }
}
