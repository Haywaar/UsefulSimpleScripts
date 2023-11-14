using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(TextColor))]
public class TextColorEditor : Editor
{
    private const int _colorsInRow = 3;
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        int index = 0;
        foreach (var colorData in Pallete.Colors)
        {
            if(index == 0)
            {
                GUILayout.BeginHorizontal();
            }

            var buttonStyle = new GUIStyle(GUI.skin.button);
            buttonStyle.fixedWidth = 100;
            Color color;
            ColorUtility.TryParseHtmlString(colorData.Value, out color);
            GUI.backgroundColor = color;
            if (GUILayout.Button(colorData.Key.ToString(), buttonStyle))
            {
                var targetImage = (TextColor)target;
                targetImage.SetColor(color);
            }

            if(index == _colorsInRow - 1)
            {
                GUILayout.EndHorizontal();
            }

            index++;
            if(index > _colorsInRow - 1)
            {
                index = 0;
            }
        }
    }
}
#endif