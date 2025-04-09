/*
 * Jacob Vanderwill
 * Created: N/A
 * Last Altered N/A
 * Create a script to make sound when clicking
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlaySoundOnClick : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clicksound;
    public AudioClip hovermousesound;
    private void Update()
    {

    }
    public void OnPointerEnter()
    {
        audioSource.PlayOneShot(hovermousesound);
    }
    public void OnClick()
    {
        audioSource.PlayOneShot(clicksound);
    }
}
