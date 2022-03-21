using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class MechSwitcherManager : MonoBehaviour
{
    public List<GameObject> swappableMechs;

    Animator mechAnimator;

    GameObject currentMech;
    GameObject duplicateMech;

    MechAttacks mechStateAttacks;

    // Start is called before the first frame update
    void Start()
    {
        if (swappableMechs.Count > 0)
            currentMech = swappableMechs[0];

        mechAnimator = GetComponent<Animator>();

        OnGetMech();
    }

    public Animator GetAnimator()
    {

        return null;
    }

    /// <summary>
    /// What to do upon changing Mech
    /// </summary>
    public void OnGetMech()
    {
        int current_index = swappableMechs.FindIndex(a => a == currentMech);

        if (current_index == swappableMechs.Count - 1)
        {
            currentMech = swappableMechs[0];
        }
        else
        {
            currentMech = swappableMechs[++current_index];
        }

        // Reset the attacks before getting new set of attacks
        if (GetComponent<MechAttacks>() != null)
            duplicateMech.GetComponent<MechAttacks>().ResetAttacks();

        Destroy(duplicateMech);
        duplicateMech = Instantiate(currentMech, transform);
        duplicateMech.transform.localPosition = Vector3.zero;

        if (duplicateMech.GetComponent<MechAttacks>() != null)
            mechStateAttacks = duplicateMech.GetComponent<MechAttacks>();
    }
}
