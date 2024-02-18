using UnityEngine;

public class RandomColorTrailRenderer : MonoBehaviour
{
    public float changeInterval = 1f; // Interval between color changes (in seconds)
    public float colorLerpSpeed = 5f; // Speed of color change transition

    private TrailRenderer trailRenderer;
    private float nextColorChangeTime;
    private Color currentColor;
    private Color targetColor;

    void Start()
    {
        trailRenderer = GetComponent<TrailRenderer>();
        nextColorChangeTime = Time.deltaTime + changeInterval;
        currentColor = Random.ColorHSV();
        targetColor = Random.ColorHSV();
    }

    void Update()
    {
        if (Time.deltaTime >= nextColorChangeTime)
        {
            nextColorChangeTime += changeInterval;
            currentColor = trailRenderer.endColor;
            targetColor = Random.ColorHSV();
        }

        currentColor = Color.Lerp(currentColor, targetColor, Time.deltaTime * colorLerpSpeed);
        trailRenderer.startColor = currentColor;
        trailRenderer.endColor = currentColor;
    }
}