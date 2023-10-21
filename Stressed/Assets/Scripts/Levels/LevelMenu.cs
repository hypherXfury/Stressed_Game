using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelMenu : MonoBehaviour
{
    public Button[] buttons;
   private void Awake() {
    int unlockLevel = PlayerPrefs.GetInt("Unlockedlevel",1);

    for (int i = 0; i < buttons.Length; i++)
    {
        buttons[i].interactable = false;
    }
    for (int i = 0; i < unlockLevel; i++)
    {
        buttons[i].interactable = true;
    }
   }

}
