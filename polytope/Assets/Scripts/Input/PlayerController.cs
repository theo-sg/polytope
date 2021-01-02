using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class PlayerController : MonoBehaviour
{
    //### object references ###
    /// <summary>
    /// the control scheme
    /// </summary>
    PlayerInputActions inputActions;

    Rigidbody2D rb;

    /// <summary>
    /// the horizontal input axis
    /// </summary>
    float LR;

    //### player states ###
    public bool isGrounded;

    //### player initialisation variables ###
    public Vector2 movementScalar = new Vector2();

    /// <summary>
    /// initialises the input actions
    /// </summary>
    private void OnEnable()
    {
        inputActions = new PlayerInputActions();
        
        //set each relevant input action
        inputActions.Movement.AD.performed += ctx => LR = ctx.ReadValue<float>();
        inputActions.Movement.Space.performed += Jump;

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
        ApplyMotion();
    }

    /// <summary>
    /// applies motion to the rigidbody of the player
    /// </summary>
    private void ApplyMotion()
    {
        /*TODO 
         * - air steering
         * - more responsive movement
         */
        rb.velocity = new Vector2(Mathf.Lerp(rb.velocity.x, LR * movementScalar.x, 0.5f), rb.velocity.y);
    }
    
    /// <summary>
    /// perform the action of jumping
    /// </summary>
    /// <param name="context">input context</param>
    private void Jump(InputAction.CallbackContext context)
    {
        //TODO - implement variable jump height based on hold/press of space bar
        if (isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, movementScalar.y);
        }
    }

    /// <summary>
    /// check to see if the player is on the ground
    /// </summary>
    /// <returns>whether the player is grounded</returns>
    public bool TestForGround()
    {
        Debug.DrawRay(transform.position, Vector2.down * 0.51f, Color.red);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.51f, 1 << LayerMask.NameToLayer("Ground"));
        return (hit.collider != null) ? true : false;
    }

}
