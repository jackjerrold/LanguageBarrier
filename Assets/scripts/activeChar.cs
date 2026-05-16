using System;
using UnityEngine;

public class activeChar : MonoBehaviour
{
    private SpriteRenderer sr;
    public Character character;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        while (character == null) { }
        sr.sprite = character.display;
        sr.color = Color.black;
    }

    private void Update()
    {
        
    }

    public void hover()
    {

    }
    
}
