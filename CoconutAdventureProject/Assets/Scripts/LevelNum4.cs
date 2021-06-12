using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelNum4 : MonoBehaviour
{
    public void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        Font myFont = (Font)Resources.Load("Fonts/Trashfort-vmAX7", typeof(Font));
        style.fontSize = 40;
        style.fontStyle = FontStyle.BoldAndItalic;
        style.normal.textColor = Color.black;
        style.font = myFont;
        GUI.Label(new Rect(900, 20, 200, 200), "Level 4", style);
    }
}
