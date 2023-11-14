using UnityEngine;
using UnityEngine.UI;

public class DesaturationImage : DesaturationComponent
{
    private bool _desaturationActive;
    private Material _desaturationMaterial;
    private Material _cachedMaterial;

    private void Awake()
    {
        _desaturationMaterial = Resources.Load<Material>("DesaturateMaterial");
    }

    public override void Desaturate(bool desaturationActive)
    {
        var image = GetComponent<Image>();
        if(image == null)
        {
            return;
        }

        if(!_desaturationActive)
        {
            _cachedMaterial = image.material;
        }

        image.material = desaturationActive ? _desaturationMaterial : _cachedMaterial;
        _desaturationActive = desaturationActive;
    }

}