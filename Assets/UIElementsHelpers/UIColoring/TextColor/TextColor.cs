using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextColor : MonoBehaviour
{
    public void SetColor(Color color)
    {
        var tmpText = GetComponent<TextMeshProUGUI>();
        if (tmpText != null)
        {
            tmpText.color = color;
        }

        var text = GetComponent<Text>();
        if (text != null)
        {
            text.color = color;
        }

        if(tmpText == null && text == null)
        {
            Debug.LogErrorFormat("No text components found on {0}", transform.name);
        }

        Camera.main.Render();
    }
}
