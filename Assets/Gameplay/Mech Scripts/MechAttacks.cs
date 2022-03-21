using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechAttacks : MonoBehaviour, IMechAttackInterface
{
    public bool hasLeftAttack;
    public bool hasRightAttack;
    public bool canJump;
    public bool hasJetPack;

    public PlayerMechController mainMechController { get; set; }

    private void Start()
    {
        if (GetComponentInParent<PlayerMechController>() != null)
        {
            mainMechController = GetComponentInParent<PlayerMechController>();
            

            if (hasLeftAttack)
                mainMechController.leftAttack += LeftAttack;
            if (hasRightAttack)
                mainMechController.rightAttack += RightAttack;
        }
        return;
    }

    public void ResetAttacks()
    {
        mainMechController.leftAttack -= LeftAttack;
        mainMechController.rightAttack -= RightAttack;
    }

    public virtual void LeftAttack()
    {
        Debug.Log("Left Attack");
    }

    public virtual void RightAttack()
    {
        Debug.Log("Right Attack");
    }

    public virtual void Jump()
    {
        Debug.Log("Jumped!!!");
    }

    public virtual void JetPack()
    {
        Debug.Log("Jet Pack");
    }
}
