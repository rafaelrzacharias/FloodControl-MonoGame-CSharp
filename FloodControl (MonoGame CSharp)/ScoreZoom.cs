using Microsoft.Xna.Framework;

public class ScoreZoom
{
    public string Text;
    public Color DrawColor;
    private int displayCounter;
    private int maxDisplayCount = 30;
    private float scale = 0.4f;
    private float lastScaleAmount = 0.0f;
    private float scaleAmount = 0.4f;

    public float Scale
    {
        get { return scaleAmount * displayCounter; }
    }

    public bool IsComplete
    {
        get { return (displayCounter > maxDisplayCount); }
    }

    public ScoreZoom(string displayText, Color fontColor)
    {
        Text = displayText;
        DrawColor = fontColor;
        displayCounter = 0;
    }

    public void Update()
    {
        scale += lastScaleAmount + scaleAmount;
        lastScaleAmount += scaleAmount;
        displayCounter++;
    }
}