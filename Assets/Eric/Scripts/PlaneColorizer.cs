using UnityEngine;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARPlane))]
public class PlaneColorizer : MonoBehaviour
{
    void OnEnable()
    {
        Color c = GameSettingsAR.selectedColor;
        c.a = 0.4f;
        GetComponent<MeshRenderer>().material.color = c;
    }
}

