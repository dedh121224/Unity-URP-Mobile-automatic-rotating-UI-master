using UnityEngine;

public class GlobalSettings : MonoBehaviour
{
    public Canvas portraitCanvas;
    public Canvas landscapeCanvas;
    int frameCounter = 0;
    int frameInterval = 120;

    void Start()
    {
        // Check the initial screen orientation
        ScreenUtility.CheckOrientation(portraitCanvas, landscapeCanvas);
    }
    void Update()
    {
        frameCounter++;
        if (frameCounter >= frameInterval)
        {
            // trigger event
            frameCounter = 0; // reset frame counter
            ScreenUtility.CheckOrientation(portraitCanvas, landscapeCanvas);
            //Debug.Log(Screen.orientation);
            Debug.Log((string)System.DateTime.Now.ToString("mm:ss"));
        }
    }
}
