using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : EquippableModel, IWeapon
{

    void OnTriggerEnter(Collider col)
    {
        if (col.transform.root != transform.root)   // Stop hitting yourself!
        {
            if (col.tag == "Enemy")
            {
                Debug.Log("Hit: " + col.name);
            }
        }
    }

    public void PerformAttack()
    {
       
    }

    public void PerformAttack2()
    {
        
    }

}
