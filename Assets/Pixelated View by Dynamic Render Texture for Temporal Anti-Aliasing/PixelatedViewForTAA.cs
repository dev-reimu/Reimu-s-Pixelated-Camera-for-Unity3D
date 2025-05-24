using UnityEngine;

public class PixelatedViewForTAA : MonoBehaviour
{
    private RenderTexture renderTexture;

    void Start()
    {
        renderTexture = GetComponent<Camera>().targetTexture;
        renderTexture.useDynamicScaleExplicit = true;
    }    

    void Update()
    {
        ScalableBufferManager.ResizeBuffers(0.1f, 0.1f);
        renderTexture.ApplyDynamicScale();
    }
}
