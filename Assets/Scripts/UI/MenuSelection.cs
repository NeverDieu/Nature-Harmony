using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSelection : MonoBehaviour
{
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

    }
}
