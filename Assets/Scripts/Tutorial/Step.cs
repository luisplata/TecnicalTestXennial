using UnityEngine;

[CreateAssetMenu(menuName = "Custom/Step")]
public class Step : ScriptableObject
{
    [SerializeField] private Sprite imageOfStep;
    [TextArea]
    [SerializeField] private string textToStep;

    public Sprite GetImage()
    {
        return imageOfStep;
    }

    public string GetText()
    {
        return textToStep;
    }
}