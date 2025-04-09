/*
 * Jacob Vanderwill
 * Created: 3/20/25
 * Last Altered 3/20/25
 * Create a script to change gameobject name on start
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeFishNameOnStart : MonoBehaviour
{
    public string Name;

    private void Start()
    {
        gameObject.name = Name;
    }
}
