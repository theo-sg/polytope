using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    /// <summary>
    /// the currently followed object
    /// </summary>
    public Transform target;

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

    public void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, dampen);
    }
}
