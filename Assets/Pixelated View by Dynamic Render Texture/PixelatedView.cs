using UnityEngine;

public class PixelatedView : MonoBehaviour
{
    private RenderTexture renderTexture;

    void Start()
    {
        renderTexture = GetComponent<Camera>().targetTexture;
        renderTexture.useDynamicScale = true;
    }    

    void Update()
    {
        ScalableBufferManager.ResizeBuffers(0.1f, 0.1f);
    }
}
