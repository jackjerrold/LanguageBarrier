using UnityEngine;

public class speaker : MonoBehaviour
{
    public string sentance = "hi my name is tom";
    public Character[] chars;
    private Translator translator;
    public Canvas canvas;
    [SerializeField] private GameObject charObj;
    private void Start()
    {
        translator = FindFirstObjectByType<Translator>();
        chars = translator.translate(sentance);
        displayChars(canvas, new Vector2(6, 2), chars);
    }

    void displayChars(Canvas canva, Vector2 speachSize, Character[] chars)
    {
        for (int i = 0; i < chars.Length; i++)
        {
            GameObject display =  Instantiate(charObj);
            display.transform.SetParent(canva.transform, false);
            RectTransform rt = display.GetComponent<RectTransform>();
            rt.localPosition = new Vector2(i - speachSize.x/2 + 1, 0);
            rt.localScale = new Vector2(10, 10);
            activeChar AC = display.GetComponent<activeChar>();
            AC.character = chars[i];
        }
    }
}
