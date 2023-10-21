using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject MainMenuUI, LevelSelectUI;
    public AudioSource audioSource;

    private void Awake() {
        MainMenuUI.SetActive(true);
        LevelSelectUI.SetActive(false);
    }
    public void Play()
    {

        MainMenuUI.SetActive(false);
        LevelSelectUI.SetActive(true);
    }
    public void goBack()
    {
        MainMenuUI.SetActive(true);
        LevelSelectUI.SetActive(false);
    }
    public void LevelSelect(int idx)
    {
        SceneManager.LoadScene(idx);
    }

    public void Music()
    {
        audioSource.enabled = !audioSource.enabled;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
