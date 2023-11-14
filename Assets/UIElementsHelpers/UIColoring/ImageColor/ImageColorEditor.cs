using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
using UnityEngine.UI;
//
[CustomEditor(typeof(ImageColor))]
public class ImageColorEditor : Editor
{
    private const int _colorsInRow = 3;
    private int selectedButtonId = -1;
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        int index = 0;
        int j = 0;
        foreach (var colorData in Pallete.Colors)
        {
            if (index == 0)
            {
                GUILayout.BeginHorizontal();
            }

            var buttonStyle = new GUIStyle(GUI.skin.button);
            buttonStyle.fixedWidth = 140;
            Color color;
            ColorUtility.TryParseHtmlString(colorData.Value, out color);
            GUI.backgroundColor = color;
            buttonStyle.fontSize = j == selectedButtonId ? 17 : 13;

            if (GUILayout.Button(colorData.Key.ToString(), buttonStyle))
            {
                selectedButtonId = j;

                var targetImage = (ImageColor)target;
                targetImage.SetColor(color);
            }

            if (index == _colorsInRow - 1)
            {
                GUILayout.EndHorizontal();
            }

            index++;
            j++;
            if (index > _colorsInRow - 1)
            {
                index = 0;
            }
        }
    }
}
#endif