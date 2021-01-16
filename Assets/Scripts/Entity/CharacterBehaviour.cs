using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehaviour : MonoBehaviour
{
    //TODO - character class or scriptable object?

    //### object references ###
    Animator anim;

    GameObject dialogueBubble;

    //### object properties ###
    public new string name;
    //TODO - dialogue tree
    public string dialogue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //TODO - fix this whole system it is very messy
            dialogueBubble = GameObject.Instantiate(DialogueManager.Instance.dialogueBubblePrefab,
                                                    DialogueManager.Instance.canvas.transform);
            dialogueBubble.GetComponent<DialogueBehaviour>().Initialise(this);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(dialogueBubble);
            dialogueBubble = null;
        }
    }
}
