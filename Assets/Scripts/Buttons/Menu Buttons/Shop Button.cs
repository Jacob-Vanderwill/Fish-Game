/*
 * Jacob Vanderwill
 * Created: 3/17/25
 * Last Altered 3/17/25
 * Create a script to load the Shop scene
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopButton : MonoBehaviour
{
    public void LoadShop()
    {
        SceneManager.LoadScene("Jacob Shop Test");
    }
}
