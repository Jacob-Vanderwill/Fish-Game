/*
 * Created: 3/13/25
 * Last Altered: 3/13/25
 * Create a scritpt to update oxygen (current) level
 */
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class OxygenProgressBar : MonoBehaviour
{
    public Image mask;

    public float MaxOxygen;
    public float Current;

    // Update is called once per frame
    void Update()
    {
        GetCurrentFill();
    }
    void GetCurrentFill()
    {
        float fillAmount = PlayerPrefs.GetFloat("OxygenLevelCurrent") / PlayerPrefs.GetFloat("OxygenTankSize");
        mask.fillAmount = fillAmount;
    }
}
