using UnityEngine;

public class PixelatedView : MonoBehaviour
{
    RenderTexture renderTexture;

    [SerializeField] int _desiredPixelDensity = 128;
    public int desiredPixelDensity
    {
        get { return _desiredPixelDensity; }
        set
        {
            renderTexture.Release();
            if (Screen.currentResolution.width > Screen.currentResolution.height)
            {
                _desiredPixelDensity = Mathf.Clamp(value, 1, Screen.currentResolution.height);
                renderTexture.width = Mathf.Clamp((int)((float)Screen.currentResolution.width / (float)Screen.currentResolution.height * _desiredPixelDensity), 1, Screen.currentResolution.width);
                renderTexture.height = _desiredPixelDensity;
            }
            else
            {
                _desiredPixelDensity = Mathf.Clamp(value, 1, Screen.currentResolution.width);
                renderTexture.width = _desiredPixelDensity;
                renderTexture.height = Mathf.Clamp((int)((float)Screen.currentResolution.height / (float)Screen.currentResolution.width * _desiredPixelDensity), 1, Screen.currentResolution.height);;
            }
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
