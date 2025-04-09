/*
 * Jacob Vanderwill
 * Created: 3/27/25
 * Last Altered 3/27/25
 * Create a script to display depth Highscore
 */
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayDepthHighscore : MonoBehaviour
{
    private TextMeshProUGUI m_TextMeshProUGUI;

    private void Start()
    {
        m_TextMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        m_TextMeshProUGUI.text = "Highscore: " + PlayerPrefs.GetInt("DepthHighscore");
    }
}
