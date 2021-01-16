using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    //!-- dialogue class will be tree at some point
    //for prototyping this will be linear

    //### object references ###
    public GameObject dialogueBubblePrefab;
    [HideInInspector] public Canvas canvas;
    //### object properties ###

    //### singleton ###
    public static DialogueManager Instance;
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
        canvas = GameObject.FindObjectOfType<Canvas>();
    }

    //TODO - dialogue system is a mess at the moment, please clean this up future Theo :)
}
