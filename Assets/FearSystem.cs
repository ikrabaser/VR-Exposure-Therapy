using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FearSystem : MonoBehaviour
{
    public Transform player;
    public Transform platformCenter;

    public Image vignetteOverlay;
    public Image stressOverlay;

    public AudioSource heartbeatAudio;

    public CameraSway cameraSway;

    public TMP_Text stressText;
    public TMP_Text statusText;
    public TMP_Text warningText;

    public Image breathingPanel;
    public TMP_Text breathingText;

    public float maxFearDistance = 4f;

    [Range(0, 100)]
    public float fearLevel;

    void Update()
    {
        float distanceFromCenter = Vector3.Distance(
            new Vector3(player.position.x, 0, player.position.z),
            new Vector3(platformCenter.position.x, 0, platformCenter.position.z)
        );

        fearLevel = Mathf.Clamp(distanceFromCenter / maxFearDistance * 100f, 0, 100);

        // BREATHING PANEL EFFECT
        if (breathingPanel != null)
        {
            Color panelColor = breathingPanel.color;
            panelColor.a = Mathf.Lerp(0.25f, 0.65f, fearLevel / 100f);
            breathingPanel.color = panelColor;
        }

        // BREATHING TEXT EFFECT
        if (breathingText != null)
        {
            Color textColor = breathingText.color;
            textColor.a = Mathf.Lerp(0.65f, 1f, fearLevel / 100f);
            breathingText.color = textColor;
        }

        // STRESS OVERLAY
        if (stressOverlay != null)
        {
            float alpha = Mathf.Lerp(0f, 0.18f, fearLevel / 100f);

            Color color = stressOverlay.color;
            color.a = alpha;

            stressOverlay.color = color;
        }

        // CAMERA SWAY
        if (cameraSway != null)
        {
            cameraSway.fearLevel = fearLevel;
        }

        // HEARTBEAT EFFECT
        if (heartbeatAudio != null)
        {
            heartbeatAudio.volume = Mathf.Lerp(0f, 0.7f, fearLevel / 100f);
            heartbeatAudio.pitch = Mathf.Lerp(0.8f, 1.4f, fearLevel / 100f);
        }

        // VIGNETTE EFFECT
        if (vignetteOverlay != null)
        {
            float alpha = Mathf.Lerp(0.03f, 0.28f, fearLevel / 100f);

            vignetteOverlay.color = new Color(0f, 0f, 0f, alpha);
        }

        // UI STRESS TEXT
        int stressValue = Mathf.RoundToInt(fearLevel / 10f);

        if (stressText != null)
        {
            stressText.text = "Stres Seviyesi: " + stressValue;
        }

        // STATUS TEXT
        if (statusText != null)
        {
            if (fearLevel < 35)
            {
                statusText.text = "Durum: Dengeli";
                statusText.color = new Color32(165, 231, 255, 255);
            }
            else if (fearLevel < 70)
            {
                statusText.text = "Durum: Gerilim Artýyor";
                statusText.color = new Color32(255, 180, 80, 255);
            }
            else
            {
                statusText.text = "Durum: Yüksek Stres";
                statusText.color = new Color32(255, 90, 90, 255);
            }
        }
        if (warningText != null)
        {
            Color warningColor = warningText.color;

            if (fearLevel > 65)
            {
                warningText.text = "Kenar bölgesindesin. Nefesini yavaþlat.";
                warningColor.a = Mathf.Lerp(warningColor.a, 1f, Time.deltaTime * 3f);
            }
            else
            {
                warningColor.a = Mathf.Lerp(warningColor.a, 0f, Time.deltaTime * 3f);
            }

            warningText.color = warningColor;
        }
    }
}