using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Desaturation
{
    public static void Desaturate(Transform rootTransform, bool desaturationActive)
    {
        foreach (Transform child in rootTransform.GetComponentsInChildren<Transform>())
        {
            TryToDesaturateComponent<DesaturationImage, Image>(child, desaturationActive);
            TryToDesaturateComponent<DesaturationTMP, TextMeshProUGUI>(child, desaturationActive);
            TryToDesaturateComponent<DesaturationText, Text>(child, desaturationActive);
        }
    }

    private static void TryToDesaturateComponent<T, C>(Transform transform, bool desaturationActive)
    where T : DesaturationComponent
    where C : MonoBehaviour
    {
        var component = transform.GetComponent<C>();
        if (component != null)
        {
            AddDesaturateComponent<T>(transform, desaturationActive);
        }
    }

    private static void AddDesaturateComponent<T>(Transform transform, bool desaturationActive) where T : DesaturationComponent
    {
        // Dont desaturate this element
        var desaturationIgnore = transform.GetComponent<DesaturationIgnore>();
        if (desaturationIgnore != null)
        {
            return;
        }

        var component = transform.GetComponent<T>();
        if (component == null)
        {
            component = transform.AddComponent<T>();
        }
        component.Desaturate(desaturationActive);
    }

}
