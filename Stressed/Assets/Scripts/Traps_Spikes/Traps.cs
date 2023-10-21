using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traps : MonoBehaviour
{
    public GameObject Spike;

    private void Awake() {
        Spike.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player")
        {
            Spike.SetActive(true);
        }
    }
}
