using System.Collections.Generic;
using UnityEngine;

public class Translator : MonoBehaviour
{
    public Dictionary<string, Character> translator;
    
    public Character[] translate(string input)
    {
        string[] words = input.Split(" ");
        Character[] result = new Character[words.Length];
        for (int i = 0; i < words.Length; i++)
        {
            result[i] = translator[words[i]];
        }
        return result;
    }
}
