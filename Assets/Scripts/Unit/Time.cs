using System;
using UnityEngine;
using UnityEngine.UI;

public class TimeUtils : MonoBehaviour
{
    public Text text;

    public void Update()
    {
        text.text = DateTime.Now.ToString(("MM-dd HH:mm"));
    }
}