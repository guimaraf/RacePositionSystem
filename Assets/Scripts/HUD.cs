using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Text[] text;
    public void HudUpdate(string textPosition)
    {
        text[0].text = textPosition;
    }
}
