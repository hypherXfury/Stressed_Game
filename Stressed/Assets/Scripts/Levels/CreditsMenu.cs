using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsMenu : MonoBehaviour
{
    public void Replay()
    {
        SceneManager.LoadScene("Level01");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
