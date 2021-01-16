using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KrakenBehaviour : MonoBehaviour
{
    /*
     * The K.R.A.K.E.N, or Kirchenhoff's Resonance Amplifier for Kinematic and Electrostatic Nodes
     * is the main multitool weapon in the game
     * it has a variety of different modes and models depending on which form it is currently in.
     * 
     * Red      -   ability to move objects through 3D space 
     * Blue     -   light weapon mode
     * Green    -   locomotion mode - grapple hook, etc.
     * Black    -   heavy weapon mode
     * 
     * different upgrades and features will be unlocked through the skill tree at skill terminals
     */

    //### object references ###
    PlayerController playerController;
    PlayerInputActions inputActions;

    //### object properties ###
    float scrollY;
    Vector2 mouseVector;
    [HideInInspector]   public float maxRotation = 150f;
    [Range(0, 1)]       public float dampening;

    private void OnEnable()
    {
        playerController = GetComponentInParent<PlayerController>();
        SetInputActions();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

    private void FixedUpdate()
    {
        SetRotation();
    }

    /// <summary>
    /// sets up the input listeners
    /// </summary>
    private void SetInputActions()
    {
        inputActions = new PlayerInputActions();
        inputActions.Movement.MousePos.performed += ctx => {    Vector3 k = Camera.main.ScreenToWorldPoint(ctx.ReadValue<Vector2>());
                                                                mouseVector = new Vector2(k.x - transform.position.x, k.y - transform.position.y).normalized; };
        inputActions.Tool.LMB.performed += ctx => { };
        inputActions.Tool.RMB.performed += ctx => { };
        inputActions.Tool.MMB.performed += ctx => { };
        inputActions.Tool.Scroll.performed += ctx => { scrollY = ctx.ReadValue<float>(); };

        inputActions.Enable();
    }

    private void SetRotation()
    { 
        float theta = -Mathf.Atan2(mouseVector.x, mouseVector.y) * Mathf.Rad2Deg;
        theta = Mathf.Clamp(theta, -maxRotation, maxRotation);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.AngleAxis(theta, Vector3.forward), dampening);
        transform.localScale = Vector3.Lerp(transform.localScale, new Vector3((theta < 0) ? 1 : -1, 1, 1), dampening);
    }
    
}

public enum KrakenMode
{
    KrakenRed,
    KrakenBlue,
    KrakenGreen,
    KrakenBlack
}
