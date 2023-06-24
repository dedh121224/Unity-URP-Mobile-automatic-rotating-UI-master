using UnityEngine;
public static class ScreenUtility
{
    public static void CheckOrientation(Canvas portraitCanvas, Canvas landscapeCanvas)
    {
        // Get the current screen orientation
        ScreenOrientation currentOrientation = Screen.orientation;
        // Check if the current orientation is portrait or landscape
        if (currentOrientation == ScreenOrientation.Portrait || currentOrientation == ScreenOrientation.PortraitUpsideDown)
        {
            // Enable the portrait canvas and disable the landscape canvas
            portraitCanvas.enabled = true;
            landscapeCanvas.enabled = false;
        }
        else if (currentOrientation == ScreenOrientation.LandscapeLeft || currentOrientation == ScreenOrientation.LandscapeRight)
        {
            // Enable the landscape canvas and disable the portrait canvas
            portraitCanvas.enabled = false;
            landscapeCanvas.enabled = true;
        }
    }
}