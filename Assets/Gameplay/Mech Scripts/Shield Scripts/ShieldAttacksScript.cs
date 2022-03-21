using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldAttacksScript : MechAttacks 
{
    [Header("Shield bot properties")]
    public Transform ShieldBashBox;
    public Collider hitBox;

    public float attackDuration = 0.5f;
    float timer;
    

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

    public override void LeftAttack()
    {
        if (!hasLeftAttack)
            RightAttack();
    }

    public override void RightAttack()
    {
        StopAllCoroutines();
        StartCoroutine(Attack());
    }

    IEnumerator Attack()
    {
        while (timer > 0f)
        {
            timer -= Time.deltaTime;
        }

        timer = attackDuration;
        StopCoroutine(Attack());
        yield return null;
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject gameObject = other.gameObject;

        if (gameObject != this.gameObject && timer > 0f)
        {
            other.attachedRigidbody.AddExplosionForce(20f, transform.forward, 5f);
        }
    }
}
