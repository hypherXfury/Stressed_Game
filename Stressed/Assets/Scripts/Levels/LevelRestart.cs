using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;
using Cinemachine;
using Unity.VisualScripting;

public class LevelRestart : MonoBehaviour
{
    public CinemachineVirtualCamera cm;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player")
        {
            StartCoroutine(Restart());
        }
    }

    IEnumerator Restart()
    {
        cm.Follow = null;
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
