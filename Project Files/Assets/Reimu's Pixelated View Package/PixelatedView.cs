using UnityEngine;

public class PixelatedView : MonoBehaviour
{
    RenderTexture renderTexture;

    [SerializeField]
    [Header("(Hover over this variable for a notice)")]
    [Tooltip("This variable can be edited during runtime only through scripts, and does not support changes from the Inspector.")]
    short _desiredPixelDensity = 128;

    public short desiredPixelDensity
    {
        get { return _desiredPixelDensity; }
        set
        {
            _desiredPixelDensity = value;
            renderTexture.height = value;
            renderTexture.width = (int)((float)Screen.currentResolution.width / (float)Screen.currentResolution.height * value);

            renderTexture.ApplyDynamicScale();
        }
    }

    void Awake()
    {
        renderTexture = GetComponent<Camera>().targetTexture;
        desiredPixelDensity = _desiredPixelDensity;
    }
}
