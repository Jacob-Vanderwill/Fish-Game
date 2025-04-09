/*
 * Jacob Vanderwill
 * Created: 3/26/25
 * Last Altered 3/26/25
 * Create a script to update net damage based on level
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateNETDamage : MonoBehaviour
{
    private DamageEnemy damage;

    private void Start()
    {
        damage = GetComponent<DamageEnemy>();

        var level = PlayerPrefs.GetInt("NetLevel");

        switch (level)
        {
            case 0:
                { damage.damage = 1; break; }
            case 1:
                { damage.damage = 3; break; }
            case 2:
                { damage.damage = 5; break; }
        }
    }
}
