using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class PlayerController : MonoBehaviour
{
    //### object references ###
    PlayerInputActions inputActions;
    Rigidbody2D rb;
    float LR;

    [Header("Player State")]
    //### player states ###
    public bool isGrounded;
    public PlayerState playerState;
    public PlayerWallState playerWallState;
  
    //### player initialisation variables ###
    private Vector2 groundCheckBox = new Vector2(0.6f, 0.2f);
    [HideInInspector]   public Vector2 movementScalar = new Vector2();
    [Header("Player Variables")]
    [Range(0, 1)]       public float airSteer = 0.1f;
    [Range(0, 1)]       public float groundSteer = 0.7f;
    [Range(1, 2)]       public float highJump = 1.4f;
    [Range(10, 50)]     public float wallJump = 25f;
    

    /// <summary>
    /// initialises the input actions
    /// </summary>
    private void OnEnable()
    {
        //set each relevant input action
        inputActions = new PlayerInputActions();
        inputActions.Movement.AD.performed += ctx => LR = ctx.ReadValue<float>();
        inputActions.Movement.Space.performed += Jump;
        inputActions.Movement.HoldSpace.performed += Jump;
        inputActions.Enable();

        rb = GetComponent<Rigidbody2D>();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

    private void FixedUpdate()
    {
        isGrounded = TestForGround();
        playerWallState = TestForWalls();
        ApplyMotion();
        playerState = SetState();
    }

    /// <summary>
    /// applies motion to the rigidbody of the player
    /// </summary>
    private void ApplyMotion()
    {

        //if in the air, controls will feel more sluggish due to drag
        rb.velocity = new Vector2(  Mathf.Lerp(rb.velocity.x, LR * movementScalar.x, (isGrounded) ? groundSteer : airSteer), 
                                    rb.velocity.y );
    }
    
    /// <summary>
    /// perform the action of jumping
    /// </summary>
    /// <param name="context">input context</param>
    private void Jump(InputAction.CallbackContext context)
    {
        //regular jump
        if (isGrounded)
        {            
            rb.velocity = new Vector2(rb.velocity.x,
                          (context.interaction is HoldInteraction) ? movementScalar.y * highJump : movementScalar.y);
        }
        //wall jump
        else if (!isGrounded && playerWallState != PlayerWallState.None)
        {
            rb.velocity = new Vector2((playerWallState == PlayerWallState.Right) ? -wallJump : wallJump, 
                          movementScalar.y * 1.2f);

        }
    }

    /// <summary>
    /// check to see if the player is on the ground
    /// </summary>
    /// <returns>whether the player is grounded</returns>
    private bool TestForGround()
    {        
        RaycastHit2D hit = Physics2D.BoxCast(transform.position, groundCheckBox, 0, Vector2.down, 0.5f, 1 << LayerMask.NameToLayer("Ground"));       
        return (hit.collider != null) ? true : false;
    }

    /// <summary>
    /// tests whether the player is in contact with a wall
    /// </summary>
    /// <returns>the position of the wall (left, right or no wall)</returns>
    private PlayerWallState TestForWalls()
    {
        RaycastHit2D lHit = Physics2D.Raycast(transform.position, Vector2.left, 0.6f, 1 << LayerMask.NameToLayer("Ground"));
        RaycastHit2D rHit = Physics2D.Raycast(transform.position, Vector2.right, 0.6f, 1 << LayerMask.NameToLayer("Ground"));
        return (lHit.collider != null) ? PlayerWallState.Left : ( (rHit.collider != null) ? PlayerWallState.Right : PlayerWallState.None );
    }

    /// <summary>
    /// sets the player state 
    /// </summary>
    /// <returns>the current player state</returns>
    private PlayerState SetState()
    {
        if (!isGrounded)
        {
            return PlayerState.InAir;
        }
        else if (Mathf.Abs(LR) > 0)
        {
            return PlayerState.Walking;
        }
        else
        {
            return PlayerState.Idle;
        }
    }
}

public enum PlayerState
{
    Idle,
    Walking,
    InAir
}

public enum PlayerWallState
{
    Left,
    None,
    Right
}