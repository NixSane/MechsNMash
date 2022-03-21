using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechAttacks : MonoBehaviour, IMechAttackInterface
{
    public bool hasLeftAttack;
    public bool hasRightAttack;

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
