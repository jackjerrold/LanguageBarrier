using System.Collections.Generic;
using UnityEngine;

public class CreateDictionary : MonoBehaviour
{
    public Translator translator;

    private string[] words = { "hi", "my", "name", "is", "tom" };
    [SerializeField] private Sprite[] charSprites;

    public Dictionary<string, Character> dict;

    void Awake()
    {
        for (int i = charSprites.Length - 1; i > 0; i--)
        {
            int randomIndex = Random.Range(0, i + 1);
            (charSprites[i], charSprites[randomIndex]) = (charSprites[randomIndex], charSprites[i]);
        }

        dict = new Dictionary<string, Character>();

        for (int i = 0; i < words.Length; i++)
        {
            Character newchar = new Character();
            newchar.display = charSprites[i];
            dict.Add(words[i], newchar);
        }

        translator.translator = dict;

        Destroy(gameObject);
    }
}
