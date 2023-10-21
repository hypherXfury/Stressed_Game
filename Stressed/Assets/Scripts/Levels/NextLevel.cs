using UnityEngine.SceneManagement;
using UnityEngine;
using Unity.VisualScripting;
using System.Collections;

public class NextLevel : MonoBehaviour
{
    
    public Animator animator;
   private void OnCollisionEnter2D(Collision2D other) {
    if(other.gameObject.CompareTag("Player"))
    {
        UnlockLevel();
        StartCoroutine(NextLevels());
    }
   }

   IEnumerator NextLevels()
   {
    animator.enabled = true;
    animator.Play("Transition");
    yield return new WaitForSeconds(1);
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    Debug.Log("Next level");
   }

   void UnlockLevel()
   {
    if(SceneManager.GetActiveScene().buildIndex >= PlayerPrefs.GetInt("ReachedIndex"))
    {
        PlayerPrefs.SetInt("ReacehdIndex", SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.SetInt("Unlockedlevel", PlayerPrefs.GetInt("Unlockedlevel",1 ) +1 );
        PlayerPrefs.Save();
    }
   }
}
