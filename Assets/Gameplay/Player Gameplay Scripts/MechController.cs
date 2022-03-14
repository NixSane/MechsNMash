using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechController : MonoBehaviour
{
	[Header("Speed of General Movement")]
	[Tooltip("Move speed of the character in m/s")]
	public float MoveSpeed = 2.0f;
	[Tooltip("Sprint speed of the character in m/s")]
	public float SprintSpeed = 5.335f;
	[Tooltip("How fast the character turns to face movement direction")]
	[Range(0.0f, 0.3f)]
	public float RotationSmoothTime = 0.12f;
	[Tooltip("Acceleration and deceleration")]
	public float SpeedChangeRate = 10.0f;

	[Space(10)]
	[Tooltip("How high the Mech can jump")]
	public float JumpHeight = 1.2f;
	[Tooltip("Default gravity of rigid body is -9.81f, you this to modify attached rigidbody gravity")]
	public float Gravity = -15.0f;

	[Space(10)]
	[Tooltip("Time required to pass before being able to jump again. Set to 0f to instantly jump again")]
	public float JumpTimeout = 0.50f;
	[Tooltip("Time required to pass before entering the fall state. Useful for walking down stairs")]
	public float FallTimeout = 0.15f;

	[Header("Player Grounded")]
	[Tooltip("If the character is grounded or not. Not part of the CharacterController built in grounded check")]
	public bool Grounded = true;
	[Tooltip("Useful for rough ground")]
	public float GroundedOffset = -0.14f;
	[Tooltip("The radius of the grounded check. Should match the radius of the CharacterController")]
	public float GroundedRadius = 0.28f;
	[Tooltip("What layers the character uses as ground")]
	public LayerMask GroundLayers;


	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
