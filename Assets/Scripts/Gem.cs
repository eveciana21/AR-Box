using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    public string gemColor = "";
    [SerializeField] private Material _targetMaterial;
    private Color _originalColor;

    private void Start()
    {
        _originalColor = _targetMaterial.GetColor("_EmissionColor");

        _targetMaterial.SetColor("_EmissionColor", Color.black);
    }

    public void ChangeEmission(bool isEmitting)
    {
        if (isEmitting == true)
        {
            //make this gem emissive
            _targetMaterial.SetColor("_EmissionColor", _originalColor);
        }
        else
        {
            //make this gem unemissive
            _targetMaterial.SetColor("_EmissionColor", Color.black);
        }
    }
}

