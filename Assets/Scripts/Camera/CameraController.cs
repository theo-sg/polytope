using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("Camera References")]
    //### object references ###
    /// <summary>
    /// the currently followed object
    /// </summary>
    public Transform target;

    [Header("Camera Properties")]
    //### object properties
    /// <summary>
    /// position offset to account for the 2D plane
    /// </summary>
    [HideInInspector] public Vector3 offset;
    /// <summary>
    /// interpolation factor
    /// </summary>
    [Range(0, 1)]       public float dampen;

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

    public void OnEnable()
    {
        offset = new Vector3(0, 1.4f, -10);
    }

    public void FixedUpdate()
    {
        //interpolate the camera's position
        transform.position = Vector3.Lerp(transform.position, target.position + offset, dampen);
    }
}
