/*
 * Jacob Vanderwill
 * Created: N/A
 * Last Altered N/A
 * Create a script to load the Fish Excahnge scene
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FishExchangeButton : MonoBehaviour
{
    public void LoadFishExchange()
    {
        SceneManager.LoadScene("Jacob Fish Exchange Test");
    }
}
