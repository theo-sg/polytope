using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //### object references ###
    /// <summary>
    /// the currently followed object
    /// </summary>
    public Transform target;

    //### camera initialisation variables
    /// <summary>
    /// position offset to account for the 2D plane
    /// </summary>
    [HideInInspector]
    public Vector3 offset = new Vector3(0, 0, -10);

    /// <summary>
    /// interpolation factor
    /// </summary>
    [Range(0, 1)]
    public float dampen;

    //### singleton ###
    public static CameraController Instance;
    public void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        Instance = this;
    }

    public void FixedUpdate()
    {
        //interpolate the camera's position
        transform.position = Vector3.Lerp(transform.position, target.position + offset, dampen);
    }
}
