using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DesaturationTMP : DesaturationComponent
{
    private Color _cachedColor;
    private Color _grayScaleColor;
    private TextMeshProUGUI _text;

    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
        _cachedColor = _text.color;

        var grayscale = _text.color.grayscale;
        _grayScaleColor = new Color(grayscale, grayscale, grayscale);
    }

    public override void Desaturate(bool desaturationActive)
    {
      if (_text == null)
        {
            return;
        }

       _text.color = desaturationActive? _grayScaleColor : _cachedColor;
    }
}
