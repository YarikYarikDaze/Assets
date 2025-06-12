using UnityEngine;

public enum CardColor
{
    RED,
    YELLOW,
    BLUE
}

[CreateAssetMenu(fileName = "Color", menuName = "Scriptable Objects/Color")]
public class ColorScript : ScriptableObject
{
    public Sprite sprite;
    public CardColor color;

}
