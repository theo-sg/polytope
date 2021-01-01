using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    /// <summary>
    /// the control scheme
    /// </summary>
    PlayerInputActions inputActions;

    /// <summary>
    /// the horizontal input axis
    /// </summary>
    public float LR;

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
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

    private void Update()
    {
        //TODO
    }
    
    /// <summary>
    /// perform the action of jumping
    /// </summary>
    /// <param name="context">input context</param>
    private void Jump(InputAction.CallbackContext context)
    {
        //TODO
        //remember the context argument is useful for determining jump type
    }
}
