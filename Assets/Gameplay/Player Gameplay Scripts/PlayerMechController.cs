using UnityEngine;
using UnityEngine.InputSystem;
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

    // Start is called before the first frame update
    void Start()
    {
        mechRigidbody = GetComponent<Rigidbody>();
        camera = GetComponent<CameraScript>();
        mechSwapper = GetComponent<MechSwitcherManager>();

        playerInput = new Player();
        playerInput.InGame.Enable();

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

        Pause();

        Swap();
        Move();
    }

    void Move()
    {
        if (playerInput.InGame.Move.ReadValue<Vector2>() != Vector2.zero && mechRigidbody.velocity.magnitude < maxSpeed)
        {
            Vector3 direction = camera.GetDirection(playerInput.InGame.Move.ReadValue<Vector2>());
            mechRigidbody.AddForce(direction * MoveSpeed * Time.deltaTime);
        }
    }

    void Turn()
    {
        Quaternion rotation = Quaternion.Euler(0f, camera.thirdPersonVCam.transform.eulerAngles.y, 0f);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotationSpeed * RotationSmoothTime * Time.deltaTime);
    }

    void Swap()
    {
        if (playerInput.InGame.Combine.triggered && cool_count_down <= 0f)
        {
            mechSwapper.OnGetMech();
            cool_count_down = cooldownTime;
        }
    }

    void Pause()
    {
        if (playerInput.InGame.Pause.triggered && gameWorldManager.gameState == GAMESTATE.PLAY)
        {
            gameWorldManager.gameState = GAMESTATE.PAUSE;
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
    }
}
