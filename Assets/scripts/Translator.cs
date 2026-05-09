using System.Collections.Generic;
using UnityEngine;

public class Translator : MonoBehaviour
{
    public Dictionary<string, Character> translator;

    private void Start()
    {
        Debug.Log(translator.Count);
    }
}
