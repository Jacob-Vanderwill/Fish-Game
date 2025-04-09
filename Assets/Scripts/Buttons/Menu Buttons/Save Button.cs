/*
 * Jacob Vanderwill
 * Created: 3/17/25
 * Last Altered 3/17/25
 * Create a script to save the game
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveButton : MonoBehaviour
{
    public void saveGame()
    {
        PlayerPrefs.Save();
    }
}
