using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightAttacksScript : MechAttacks
{
    [Header("Crab bot properties")]
    public float shooting_rate = 0.3f;
    public float shootingRange = 3000f;
    public Transform ShootingPoint;

    void Start()
    {
        if (GetComponentInParent<PlayerMechController>() != null)
        {
            mainMechController = GetComponentInParent<PlayerMechController>();
            mainMechController.leftAttack += LeftAttack;
            mainMechController.rightAttack += RightAttack;
        }
        return;
    }

    private void FixedUpdate()
    {
        Debug.DrawRay(ShootingPoint.position, mainMechController.AimVector() * shootingRange, Color.blue);
    }

    public override void LeftAttack()
    {
        if (!hasLeftAttack)
            RightAttack();
    }

    public override void RightAttack()
    {
        Shoot();
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(ShootingPoint.position, mainMechController.AimVector(), out hit, shootingRange))
        {
            Debug.Log(hit.collider.name);
        }
    }
}
