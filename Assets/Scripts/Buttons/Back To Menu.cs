/*
 * Jacob Vanderwill
 * Created: 3/17/25
 * Last Altered 3/17/25
 * Create a script to load the Menu scene
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public void backToMenu()
    {
        SceneManager.LoadScene("Jacob Menu Test");
    }
}
