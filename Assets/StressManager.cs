using UnityEngine;
using TMPro;

public class StressManager : MonoBehaviour
{
    public TextMeshProUGUI stressText;
    public CameraShake cameraShake;
    public FearEffect fearEffect;
    public HeartbeatController heartbeatController;
    public SessionLogger sessionLogger;
    public DifficultyManager difficultyManager;

    private int stressLevel = 5;

    void Start()
    {
        UpdateStressText();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            stressLevel--;
            stressLevel = Mathf.Clamp(stressLevel, 1, 10);
            UpdateStressText();
            sessionLogger.LogSessionData(stressLevel, difficultyManager.difficultyLevel, "Stress Decreased");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            stressLevel++;
            stressLevel = Mathf.Clamp(stressLevel, 1, 10);
            UpdateStressText();
            sessionLogger.LogSessionData(stressLevel, difficultyManager.difficultyLevel, "Stress Increased");
        }

        // Kamera titreme sistemi
        if (stressLevel >= 8)
        {
            cameraShake.isShaking = true;
        }
        else
        {
            cameraShake.isShaking = false;
        }
        fearEffect.UpdateFear(stressLevel);
        heartbeatController.UpdateHeartbeat(stressLevel);
    }

    void UpdateStressText()
    {
        stressText.text = "Stres Seviyesi: " + stressLevel;
    }
}