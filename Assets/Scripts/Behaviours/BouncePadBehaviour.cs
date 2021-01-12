using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePadBehaviour : MonoBehaviour
{
    [Header("Object Properties")]
    //### object properties ###
    [Range(2, 15)] public float strength = 10f;
    public bool omnidirectional = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Entity"))
        {          
            Rigidbody2D rb = collision.collider.gameObject.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Bounce(rb, collision.GetContact(0));
            }
        }        
    }

    /// <summary>
    /// applies a force to the contact rigidbody
    /// </summary>
    /// <param name="rb">the contact rigibody</param>
    private void Bounce(Rigidbody2D rb, ContactPoint2D ct)
    {
        Vector2 j = rb.position - ct.point;
        float x = rb.position.x - transform.position.x;
        
        Vector2 colliderSize = this.GetComponent<BoxCollider2D>().size;
        if (omnidirectional)
        {
            //¯\_(ツ)_/¯
            //apply force in direction k?
            //however it should maintain the primary direction of motion
        }
        else
        {
            //if the player is above the pad
            // |x| will be less than or equal to the width of the collider / 2
            // ky will be more than or equal to the height of the collider / 2
            if(Mathf.Abs(x) <= colliderSize.x / 2 && j.y >= colliderSize.y / 2)
            {
                rb.AddForce(Vector2.up * strength, ForceMode2D.Impulse);
            }
        }
    }
}
