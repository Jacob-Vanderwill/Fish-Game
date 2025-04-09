/*
 * Jacob Vanderwill
 * Created: 3/17/25
 * Last Altered 3/17/25
 * Create a script to load the Fish Collection scene
 */
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public void LevelLoad()
    {
        SceneManager.LoadScene("Jacob Test");
    }
}
