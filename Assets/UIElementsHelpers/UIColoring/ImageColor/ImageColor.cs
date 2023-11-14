using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageColor : MonoBehaviour
{
   [SerializeField] private Color cachedColor;

    private void Awake()
    {
        var image = GetComponent<Image>();
        image.color = cachedColor;
    }

    public void SetColor(Color color)
    {
        var image = GetComponent<Image>();
        image.color = color;
        cachedColor = color;
        Camera.main.Render();
    }
}
