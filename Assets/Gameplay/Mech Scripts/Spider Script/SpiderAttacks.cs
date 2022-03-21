using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderAttacks :  MechAttacks
{
    [Header("Crab bot properties")]
    public float shooting_rate = 0.3f;



    public override void LeftAttack()
    {
        Debug.Log("Crab shooting!!! Pew Pew");
    }

    public override void RightAttack()
    {
        if (!hasRightAttack)
            Debug.Log("No right attack");
        else
            LeftAttack();
    }

    void Shoot()
    {

    }
}
