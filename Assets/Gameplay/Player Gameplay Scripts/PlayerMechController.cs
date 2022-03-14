using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class PlayerMechController : MechController
{
    [Header("Cinemachine")]
    [Tooltip("The follow target set in the Cinemachine Virtual Camera that the camera will follow")]
    public GameObject CinemachineCameraTarget;
    [Tooltip("How far in degrees can you move the camera up")]
    public float TopClamp = 70.0f;
    [Tooltip("How far in degrees can you move the camera down")]
    public float BottomClamp = -30.0f;
    [Tooltip("Additional degress to override the camera. Useful for fine tuning camera position when locked")]
    public float CameraAngleOverride = 0.0f;
    [Tooltip("For locking the camera position on all axis")]
    public bool LockCameraPosition = false;

    [Header("Rigidbody")]
    public float maxSpeed = 30.0f;

    Rigidbody mechRigidbody;
    [SerializeField] CinemachineFreeLook cinemachineVirtual;

    [Header("Input")]
    [SerializeField] PlayerInput input;
    Player playerInput;

    // Start is called before the first frame update
    void Start()
    {
        mechRigidbody = GetComponent<Rigidbody>();

        if (cinemachineVirtual == null)
            cinemachineVirtual = FindObjectOfType<CinemachineFreeLook>();
        CinemachineCameraTarget = cinemachineVirtual.Follow.gameObject;

        playerInput = new Player();
        playerInput.InGame.Enable();
    }

    private void OnEnable()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (playerInput.InGame.Move.ReadValue<Vector2>() != Vector2.zero && mechRigidbody.velocity.magnitude < maxSpeed)
        {
            Vector3 direction = new Vector3(playerInput.InGame.Move.ReadValue<Vector2>().x, 0f, playerInput.InGame.Move.ReadValue<Vector2>().y);
            Debug.Log(direction);
            mechRigidbody.AddForce(direction * MoveSpeed, ForceMode.Force);
        }
    }

    //void OnMove(InputAction input)
    //{
    //    Vector3 direction = new Vector3(input.ReadValue<Vector2>().x, 0f, input.ReadValue<Vector2>().y);
    //    Debug.Log(direction);
    //    mechRigidbody.AddForce(direction * MoveSpeed);
    //}
}
