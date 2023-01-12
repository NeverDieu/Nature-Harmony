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
        for (int i = 1; i < 7; i++)
            UIelements[i].SetActive(false);

        UIelements[7].SetActive(true);
    }

    public void CreditsButton()
    {
        for (int i = 1; i < 6; i++)
            UIelements[i].SetActive(false);

        UIelements[6].SetActive(true);
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

    public void OptionsBack()
    {
        for (int i = 1; i < 7; i++)
            UIelements[i].SetActive(true);

        UIelements[5].SetActive(false);
        UIelements[6].SetActive(false);
        UIelements[7].SetActive(false);
    }
    public void CreditsBack()
    {
        for (int i = 1; i < 6; i++)
            UIelements[i].SetActive(true);

        UIelements[5].SetActive(false);
        UIelements[6].SetActive(false);
    }
}
