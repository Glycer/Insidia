using System;
using System.Collections;
using UnityEngine;

public class ChangeHealth : MonoBehaviour {

    /* As a placeholder, I'm referring to whatever script will carry health data
     * as 'StatScript'
     */

    public static Action</* StatScript, */ float> Damage;
    public static Action</* StatScript, */ float> Restore;

    void Start()
    {
        Damage += ApplyDamage;
        Restore += ApplyRestore;
    }

    void ApplyDamage(/* StatScript, */ float _damage)
    {
        //StatScript.health -= _damage;
    }

    void ApplyRestore(/* StatScript, */ float _restored)
    {
        //StatScript.health += _restored;
    }
}
