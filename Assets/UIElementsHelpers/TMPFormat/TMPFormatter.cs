using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TMPFormatter : MonoBehaviour
{
    public void SetFormat(TMPFormat tmpFormat)
    {
        var text = GetComponent<TextMeshProUGUI>();
        text.fontSize = tmpFormat.FontSize;
        text.fontStyle = tmpFormat.FontStyle;
        text.enableAutoSizing = tmpFormat.AutoSize;
        text.alignment = tmpFormat.TextAlignment;
        Camera.main.Render();
    }
}
