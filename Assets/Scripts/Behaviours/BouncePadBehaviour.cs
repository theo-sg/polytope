using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePadBehaviour : MonoBehaviour
{
    [Range(1, 20)] public float strength = 10f;
    public bool omnidirectional = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Character"))
        {          
            Rigidbody2D rb = collision.collider.gameObject.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Bounce(rb);
            }
        }
    }

    /// <summary>
    /// applies a force to the contact rigidbody
    /// </summary>
    /// <param name="rb">the contact rigibody</param>
    private void Bounce(Rigidbody2D rb)
    {

        Vector2 k = rb.position - (Vector2) transform.position;
        //if the bounce pad is vertical only
        if (omnidirectional)
        {
            //¯\_(ツ)_/¯
            //apply force in direction k?
            //however it should maintain the primary direction of motion
        }
        else
        {
            //if the player is above the pad
            //this value is probably better off calculated to be honest as height of player / 2 + height of pad / 2
            //perhaps some standard player height = 0.9f
            //        vv
            if(k.y >= (this.GetComponent<BoxCollider2D>().size.y / 2) + (rb.GetComponent<CircleCollider2D>().radius))
            {
                rb.AddForce(Vector2.up * strength, ForceMode2D.Impulse);
            }
        }
    }
}
