using UnityEngine;
using TMPro;
public class FPSDisplay : MonoBehaviour {

    public TMP_Text FpsText;

    private float pollingTime = 1f;
    private float time;
    private int frameCount;

    void Update()
    {
        time += Time.deltaTime;
        frameCount++;
        if (time >= pollingTime)
        {
            int frameRate = Mathf.RoundToInt(frameCount / time);

            FpsText.text = "FPS: " + frameRate.ToString();
            time -= pollingTime;
            frameCount = 0;

            if (frameRate <= 7)
            {
                FpsText.color = Color.red;
            }
            else if (frameRate <= 10)
            {
                FpsText.color = Color.yellow;
            }
            else if (frameRate <= 13)
            {
                FpsText.color = Color.green;
            }
            else if (frameRate <= 20)
            {
                FpsText.color = Color.white;
            }
            else
            {
                FpsText.color = Color.cyan;
            }
        }
    }
}