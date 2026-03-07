using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
public class EnemyHealth : Health 
{
    public static int LivingEnemyCount;

    private void Awake() => LivingEnemyCount++;
    protected override void Die()
    {
        LivingEnemyCount--;
        base.Die();
        Debug.Log("Enemy died");

    }

}