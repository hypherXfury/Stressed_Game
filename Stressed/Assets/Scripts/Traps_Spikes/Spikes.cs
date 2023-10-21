using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    public GameObject Player;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player")
        {
            StartCoroutine(Dead());
        }
    }

    IEnumerator Dead()
    {
        FindObjectOfType<PlayerMovement>().animator.SetBool("run", false);
        FindObjectOfType<PlayerMovement>().animator.SetBool("grounded", true);
        FindObjectOfType<PlayerMovement>().rb2d.AddForce(new Vector2(-10f, 10), ForceMode2D.Impulse);
        FindObjectOfType<PlayerMovement>().enabled = false;

        yield return new WaitForSeconds(0.2f);
        Player.GetComponent<CircleCollider2D>().enabled = false;

        yield return new WaitForSeconds(1.8f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
