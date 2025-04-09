/*Hudson Ream
 * 4/9/2025
 * fades text away over time
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Fadewithtime : MonoBehaviour
{
    public float time;
    public TextMeshProUGUI textMeshPro;
    private float alpha = 1;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(alpha >= 0)
        {
            alpha -= Time.deltaTime / time;
        }
        
        textMeshPro.color = new Color(textMeshPro.color.r, textMeshPro.color.g, textMeshPro.color.b, alpha);
    }
}
