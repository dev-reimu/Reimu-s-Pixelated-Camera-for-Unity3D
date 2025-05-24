using System;
using UnityEngine;

public class PixelatedView : MonoBehaviour
{
    private RenderTexture renderTexture;

    [SerializeField] short desiredPixelDensity = 128;

    void Start()
    {
        renderTexture = GetComponent<Camera>().targetTexture;

        renderTexture.width = (int)((float)Screen.currentResolution.width / (float)Screen.currentResolution.height * desiredPixelDensity);
        renderTexture.height = desiredPixelDensity;

        renderTexture.ApplyDynamicScale();
    }
}
