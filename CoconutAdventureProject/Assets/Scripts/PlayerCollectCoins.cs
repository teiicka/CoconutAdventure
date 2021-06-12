using UnityEngine;

public class PlayerCollectCoins : MonoBehaviour
{
    public int points = 0;
    public int allPoints;

    private void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        Font myFont = (Font)Resources.Load("Fonts/Trashfort-vmAX7", typeof(Font));
        style.fontSize = 35;
        style.fontStyle = FontStyle.BoldAndItalic;
        style.normal.textColor = Color.black;
        style.font = myFont;
        GUI.Label(new Rect(20, 20, 200, 200), "Coins collected: " + points, style);

        GUI.Label(new Rect(1650, 20, 200, 200), "Total coins: " + allPoints, style);
    }

    public int getAllPoits()
    {
        return allPoints;
    }
}
