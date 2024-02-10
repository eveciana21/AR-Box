using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Examinable : MonoBehaviour
{
    private ExaminableManager _examinableManager;
    [SerializeField] public float examinedScaleOffset = 1f;

    void Start()
    {
        _examinableManager = FindObjectOfType<ExaminableManager>();
    }

    public void RequestExamine() // Requests for the object to be examined when selected
    {
        _examinableManager.PerformExamine(this);
    }

    public void RequestUnexamine() // Requests for the object to be unexamined when selected again
    {
        _examinableManager.PerformUnexamine();
    }
}

