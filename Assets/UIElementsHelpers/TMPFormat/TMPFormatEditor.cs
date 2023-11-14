using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(TMPFormatter))]
public class TMPFormatEditor : Editor
{
     public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        foreach(var tmpFormat in TMPFormatStorage.Data)
        {
             var buttonStyle = new GUIStyle(GUI.skin.button);
             if (GUILayout.Button(tmpFormat.Name, buttonStyle))
            {
                var targeFormatter = (TMPFormatter)target;
                targeFormatter.SetFormat(tmpFormat);
            }
        }
    }
}
#endif