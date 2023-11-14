using UnityEngine;
using UnityEngine.UI;

public class DesaturationDemoScript : MonoBehaviour
{
    [SerializeField] private Button _onOffDesaturationButton;
    [SerializeField] private Transform _target;
    private bool _isDesaturated;

    void Start()
    {
        _onOffDesaturationButton.onClick.AddListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        _isDesaturated = !_isDesaturated;
        Desaturation.Desaturate(_target, _isDesaturated);
    }
}
