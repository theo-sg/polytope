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

    //### player states ###
    private float LR;
    [Header("Player State")]
    [SerializeField]    private bool isGrounded;
    public bool IsGrounded
    {
        get { return isGrounded; }
        set
        {
            isGrounded = value;
            if (value == true)
            {
                canAttachToWall = true;
                DetachFromWall();
            }           
        }
    }
    [SerializeField]    private bool isAttachedToWall;
    [SerializeField]    private bool canAttachToWall = true;
    public PlayerState playerState;
    public PlayerWallState playerWallState;
  
    //### player properties ###
    private Vector2 groundCheckBox = new Vector2(0.3f, 0.2f);
    [HideInInspector]   public Vector2 movementScalar = new Vector2();
    [Header("Player Properties")]
    float groundDistance = 0.8f;
    float wallDistance = 0.31f;
    [Range(0, 1)]       public float airSteer = 0.1f;
    [Range(0, 1)]       public float groundSteer = 0.7f;
    [Range(1, 2)]       public float highJump = 1.4f;
    [Range(10, 50)]     public float wallJump = 25f;
    

    private void OnEnable()
    {
        SetInputActions();
        rb = GetComponent<Rigidbody2D>();        
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

    /// <summary>
    /// configures the inputs
    /// </summary>
    private void SetInputActions()
    {
        inputActions = new PlayerInputActions();
        
        inputActions.Movement.AD.performed += ctx => { LR = ctx.ReadValue<float>(); };
        inputActions.Movement.S.performed += ctx => { if (playerState == PlayerState.OnWall) { canAttachToWall = false; DetachFromWall(); } };
        inputActions.Movement.Space.performed += Jump;
        inputActions.Movement.HoldSpace.performed += Jump;
        inputActions.Enable();
    }

    private void FixedUpdate()
    {
        IsGrounded = TestForGround();
        playerState = SetState();
        playerWallState = TestForWalls();
        
        SetAttachmentToWall();
        ApplyMotion();
    }

    /// <summary>
    /// applies motion to the rigidbody of the player
    /// </summary>
    private void ApplyMotion()
    {
        if (!isAttachedToWall)
        {
            //if in the air, controls will feel more sluggish due to drag
            rb.velocity = new Vector2(Mathf.Lerp(rb.velocity.x, LR * movementScalar.x, (IsGrounded) ? groundSteer : airSteer),
                                        rb.velocity.y);
        }       
    }
        
    /// <summary>
    /// perform the action of jumping
    /// </summary>
    /// <param name="context">input context</param>
    private void Jump(InputAction.CallbackContext context)
    {
        //regular jump
        if (IsGrounded)
        {            
            rb.velocity = new Vector2(rb.velocity.x,
                          (context.interaction is HoldInteraction) ? movementScalar.y * highJump : movementScalar.y);
        }
        //wall jump
        else if (!IsGrounded && isAttachedToWall)
        {
            rb.velocity = new Vector2((playerWallState == PlayerWallState.Right) ? -wallJump : wallJump, 
                          movementScalar.y * 1.2f);

            canAttachToWall = true;

        }
    }

    /// <summary>
    /// set the current attached to wall state
    /// </summary>
    private void SetAttachmentToWall()
    {
        if (!IsGrounded && playerWallState != PlayerWallState.None)
        {
            AttachToWall();
        }
        //else if the player slips off the bottom of a wall
        else if (playerWallState == PlayerWallState.None && isAttachedToWall)
        {
            DetachFromWall();
            canAttachToWall = true;
        }                    
    }

    /// <summary>
    /// attach the player to a wall
    /// </summary>
    private void AttachToWall()
    {
        if(!isAttachedToWall && canAttachToWall)
        {
            isAttachedToWall = true;
            rb.velocity = new Vector2(0, 0);
            rb.gravityScale = 0.05f;
        }
    }

    /// <summary>
    /// detach the player from a wall
    /// </summary>
    private void DetachFromWall()
    {
        if (isAttachedToWall)
        {
            isAttachedToWall = false;
            rb.gravityScale = 1f;
        }        
    }

    /// <summary>
    /// check to see if the player is on the ground
    /// </summary>
    /// <returns>whether the player is grounded</returns>
    private bool TestForGround()
    {        
        RaycastHit2D hit = Physics2D.BoxCast(transform.position, groundCheckBox, 0, Vector2.down, groundDistance, 1 << LayerMask.NameToLayer("Ground"));       
        return (hit.collider != null) ? true : false;
    }

    /// <summary>
    /// tests whether the player is in contact with a wall
    /// </summary>
    /// <returns>the position of the wall (left, right or no wall)</returns>
    private PlayerWallState TestForWalls()
    {
        RaycastHit2D lHit = Physics2D.Raycast(transform.position, Vector2.left, wallDistance, 1 << LayerMask.NameToLayer("Ground"));
        RaycastHit2D rHit = Physics2D.Raycast(transform.position, Vector2.right, wallDistance, 1 << LayerMask.NameToLayer("Ground"));
        return (lHit.collider != null) ? PlayerWallState.Left : ( (rHit.collider != null) ? PlayerWallState.Right : PlayerWallState.None );
    }

    /// <summary>
    /// sets the player state 
    /// </summary>
    /// <returns>the current player state</returns>
    private PlayerState SetState()
    {
        if (isAttachedToWall)
        {
            return PlayerState.OnWall;
        }
        if (!IsGrounded)
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
    InAir,
    OnWall
}

public enum PlayerWallState
{
    Left,
    None,
    Right
}