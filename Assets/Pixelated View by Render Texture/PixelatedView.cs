using System;
using UnityEngine;

public class PixelatedView : MonoBehaviour
{
    private RenderTexture renderTexture;

    [SerializeField] private Int16 desiredPixelDensity = 256;

    void Start()
    {
        renderTexture = GetComponent<Camera>().targetTexture;

        float nativeWidth = Screen.currentResolution.width;
        float nativeHeight = Screen.currentResolution.height;
        float aspectRatio = nativeWidth / nativeHeight;

        renderTexture.width = Mathf.RoundToInt(aspectRatio * (float)desiredPixelDensity);
        renderTexture.height = desiredPixelDensity;
    }
}
