/*
 * Jacob Vanderwill
 * Created: 3/18/25
 * Last Altered 3/18/25
 * Create script to display coin count
 */
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[ExecuteInEditMode]
public class DisplayCoins : MonoBehaviour
{
    private TextMeshProUGUI TextMeshPro;

    private void Start()
    {
        TextMeshPro = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        TextMeshPro.text = "Coins: " + PlayerPrefs.GetInt("Coins");
    }
}