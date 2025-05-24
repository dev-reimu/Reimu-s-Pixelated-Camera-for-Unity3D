using UnityEngine;

public class PixelatedView : MonoBehaviour
{
    RenderTexture renderTexture;

    [SerializeField] short _desiredPixelDensity = 128;
    public short desiredPixelDensity
    {
        get { return _desiredPixelDensity; }
        set
        {
            _desiredPixelDensity = value;

            renderTexture.Release();
            renderTexture.height = value;
            renderTexture.width = (int)((float)Screen.currentResolution.width / (float)Screen.currentResolution.height * value);
            renderTexture.Create();
        }
    }

    void Awake()
    {
        renderTexture = GetComponent<Camera>().targetTexture;
        desiredPixelDensity = _desiredPixelDensity;
    }

    #if UNITY_EDITOR
    void Update() => desiredPixelDensity = _desiredPixelDensity;
    #endif
}
