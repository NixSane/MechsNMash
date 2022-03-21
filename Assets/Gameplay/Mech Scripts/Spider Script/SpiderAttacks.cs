using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderAttacks :  MechAttacks
{
    [Header("Crab bot properties")]
    public float shooting_rate = 0.3f;
    public float shootingRange = 50.0f;
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
        Shoot();
    }

    public override void RightAttack()
    {
        if (!hasRightAttack)
            LeftAttack();
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
