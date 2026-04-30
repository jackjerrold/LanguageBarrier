using System.Collections.Generic;
using UnityEngine;

public class CreateDitctionary : MonoBehaviour
{
    private string[] words = { "hi", "tree", "bread", "dog" };
    [SerializeField] private Sprite[] charSprites;
    public Dictionary translator;
    
    void Awake()
    {
        translator.translator = new Dictionary<string, Sprite>();

        for (int i = 0; i < words.Length; i++)
        {
            translator.translator.Add(words[i], charSprites[i]);
        }
    }

}
