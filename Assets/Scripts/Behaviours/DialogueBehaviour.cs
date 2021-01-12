using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueBehaviour : MonoBehaviour
{
    //### object references ###
    public CharacterBehaviour character;
    Text text;

    public void Initialise(CharacterBehaviour character)
    {
        this.character = character;
        text.text = character.dialogue;
    }

    private void OnEnable()
    {
        text = GetComponentInChildren<Text>();
    }

    private void LateUpdate()
    {
        transform.position = Camera.main.WorldToScreenPoint(character.transform.position) + Vector3.up * 160f;
    }
}
