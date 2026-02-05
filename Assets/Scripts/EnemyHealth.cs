using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
public class EnemyHealth : Health 
{
    protected override void Die()
    {
        base.Die();
        Debug.Log("Enemy died");
    }

}