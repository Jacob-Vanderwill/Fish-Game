/*
 * Jacob Vanderwill
 * Created: 3/18/25
 * Last Altered 3/18/25
 * Create a script to show Current Level
 */
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayCurrentLevel : MonoBehaviour
{
    [Tooltip("PlayerPrefs.GetInt(*string*)")]
    public string PlayerPrefsVariableName;

    private TextMeshProUGUI TextMeshPro;

    private void Start()
    {
        TextMeshPro = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        TextMeshPro.text = "Level: " + (PlayerPrefs.GetInt(PlayerPrefsVariableName) + 1);
    }
}
