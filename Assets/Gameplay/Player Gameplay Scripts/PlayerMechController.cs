using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using Cinemachine;
using UnityEngine.Animations;

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

    [Header("Rotation")]
    public float rotationSpeed = 5f;

    [Header("Mech Swapping/Combine cooldown")]
    [Tooltip("How much time cooldown should last")]
    public float cooldownTime = 2.0f;
    [Tooltip("How fast the time should count down")]
    public float cooldownRate = 0.5f;
    float cool_count_down;

    [Header("Game world Manager")]
    [SerializeField] GameWorldManagerScript gameWorldManager;

    public Animator _mechAnimator { get; set; }

    MechSwitcherManager mechSwapper;

    CameraScript camera;
    Rigidbody mechRigidbody;

    [Header("Input")]
    Player playerInput;
    bool isPaused = false;
    InputAction pauseAction;

    // Attack functions
    public UnityAction leftAttack;
    public UnityAction rightAttack;


    // Movement
    Vector3 movementVec;

    // Start is called before the first frame update
    void Start()
    {
        mechRigidbody = GetComponent<Rigidbody>();
        camera = GetComponent<CameraScript>();
        mechSwapper = GetComponent<MechSwitcherManager>();

        playerInput = new Player();
        playerInput.InGame.Enable();

        pauseAction = playerInput.InGame.Pause;
        

        cool_count_down = 0f;

        Cursor.lockState = CursorLockMode.Locked;
    }

    private void FixedUpdate()
    {
        Turn();
    }

    // Update is called once per frame
    void Update()
    {
        if (cool_count_down > 0f)
            cool_count_down -= cooldownRate * Time.deltaTime;
      
        Move();
    }

    public Vector3 AimVector()
    {
        Vector3 aim_vector = camera.thirdPersonVCam.transform.forward;
        return aim_vector;
    }

    public void OnMove(InputValue input)
    {
        Vector2 vector = input.Get<Vector2>();

        movementVec = new Vector3(vector.x, 0f, vector.y);
    }

    /// <summary>
    /// Attack for left side
    /// </summary>
    void OnLeftAttack()
    {
        if (leftAttack != null)
            leftAttack.Invoke();
    }

    /// <summary>
    /// Attack for Right side
    /// </summary>
    void OnRightAttack()
    {
        if (rightAttack != null)
            rightAttack.Invoke();
    }

    void Move()
    {
        if (movementVec != Vector3.zero && mechRigidbody.velocity.magnitude < maxSpeed)
        {
            Vector3 direction = camera.GetDirection(movementVec);
            mechRigidbody.AddForce(direction * MoveSpeed * Time.deltaTime);
        }
    }

    void Turn()
    {
        Quaternion rotation = Quaternion.Euler(0f, camera.thirdPersonVCam.transform.eulerAngles.y, 0f);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotationSpeed * RotationSmoothTime * Time.deltaTime);
    }

    public void OnCombine()
    {
        mechSwapper.OnGetMech();
        cool_count_down = cooldownTime;
    }

    void Pause()
    {
        gameWorldManager.gameState = GAMESTATE.PAUSE;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        isPaused = true;
    }

    void Resume()
    {
        gameWorldManager.gameState = GAMESTATE.PLAY;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        isPaused = false;
    }

    public void OnPause()
    {
        if (!isPaused)
            Pause();
        else
            Resume();
    }
}
