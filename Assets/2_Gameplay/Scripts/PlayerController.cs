using Gameplay.Assets._2_Gameplay.Scripts.So;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Gameplay
{
    [RequireComponent(typeof(Character))]
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private InputActionReference moveInput;
        [SerializeField] private InputActionReference jumpInput;
        [SerializeField] private float airborneSpeedMultiplier = .5f;

        private Character _character;
        private Coroutine _jumpCoroutine;

        //Added Scriptable objects with every movement

        [SerializeField] private SoJump jump;

        //[SerializeField] private SoSwim swim;
        //[SerializeField] private SoClimb climb;


        private void Awake()
        {
            _character = GetComponent<Character>();

        }

        private void OnEnable()
        {
            if (moveInput?.action != null)
            {
                moveInput.action.started += HandleMoveInput;
                moveInput.action.performed += HandleMoveInput;
                moveInput.action.canceled += HandleMoveInput;
            }
            if (jumpInput?.action != null)
                jumpInput.action.performed += HandleJumpInput;

            // added climbInput and swimInput 
            /*
             if (climbInput?.action != null)
             climbInput.action.performed += HandleClimbInput;
             */
            /*
            if (swimInput?.action != null)
            swimInput.action.performed += HandleSwimInput;
            */
        }
        private void OnDisable()
        {
            if (moveInput?.action != null)
            {
                moveInput.action.performed -= HandleMoveInput;
                moveInput.action.canceled -= HandleMoveInput;
            }
            if (jumpInput?.action != null)
                jumpInput.action.performed -= HandleJumpInput;
            // added climbInput and swimInput 

            /*
            if (climbInput?.action != null)
            climbInput.action.performed += HandleClimbInput;
            */
            /*
            if (swimInput?.action != null)
            swimInput.action.performed += HandleSwimInput;
            */
        }

        private void HandleMoveInput(InputAction.CallbackContext ctx)
        {
            var direction = ctx.ReadValue<Vector2>().ToHorizontalPlane();
            direction *= airborneSpeedMultiplier;
            _character?.SetDirection(direction);
        }

        private void HandleJumpInput(InputAction.CallbackContext ctx)
        {
            if (!jump.CanJump()) return;

            RunJumpCoroutine();
            jump.OnJump();

        }
        // added climb and swim functions in comments

        //HandleSwimInput 

        //HandleClimbInput
        private void RunJumpCoroutine()
        {
            if (_jumpCoroutine != null)
                StopCoroutine(_jumpCoroutine);
            _jumpCoroutine = StartCoroutine(_character.Jump());
        }

        private void OnCollisionEnter(Collision other)
        {
            foreach (var contact in other.contacts)
            {
                if (Vector3.Angle(contact.normal, Vector3.up) < 5)
                {
                    //call function Reset of SoJump to trigger in case player collision with ground 
                    if (jump is SoJump resettable)
                        resettable.Reset();
                }
            }
        }
    }
}