
using System;
using UnityEngine;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour
{
    public Image Background;
    public Text ToolTipText;
    
    private float _timeout;
    private float _initialAlpha;

    void Start()
    {
        _initialAlpha = Background.color.a;
    }

    public void Display(string text)
    {
        var color = Background.color;
        color.a = _initialAlpha;
        Background.color = color;
        ToolTipText.text = text;
        _timeout = 0.1f;
    }

    void Update()
    {
        _timeout -= Time.deltaTime;

        if(_timeout <= 0)
        {
            Clear();
        }
    }

    public void Clear()
    {
        var color = Background.color;
        color.a = 0f;
        Background.color = color;
        ToolTipText.text = string.Empty;
    }
}