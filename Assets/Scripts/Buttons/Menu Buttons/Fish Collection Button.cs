/*
 * Jacob Vanderwill
 * Created: N/A
 * Last Altered N/A
 * Create a script to load the Fish Collection scene
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FishCollectionButton : MonoBehaviour
{
    public void LoadCollection()
    {
        SceneManager.LoadScene("Jacob Collection Test");
    }
}
