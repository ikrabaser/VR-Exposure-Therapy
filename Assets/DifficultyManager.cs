using UnityEngine;
using TMPro;

public class DifficultyManager : MonoBehaviour
{
    public GameObject highPlatform;

    public TextMeshProUGUI difficultyText;
    public TextMeshProUGUI statusText;

    public int stressLevel = 5;
    public int difficultyLevel = 3;
    private Vector3 targetPosition;

    void Start()
    {
        UpdateUI();
        targetPosition = highPlatform.transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            stressLevel--;
            stressLevel = Mathf.Clamp(stressLevel, 1, 10);

            AdjustDifficulty();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            stressLevel++;
            stressLevel = Mathf.Clamp(stressLevel, 1, 10);

            AdjustDifficulty();
        }
        highPlatform.transform.position =
    Vector3.Lerp(
        highPlatform.transform.position,
        targetPosition,
        Time.deltaTime * 2f
    );
    }

    void AdjustDifficulty()
    {
        Vector3 position = targetPosition;

        if (stressLevel <= 3)
        {
            difficultyLevel++;
            difficultyLevel = Mathf.Clamp(difficultyLevel, 1, 5);
            position.y += 2f;
        }
        else if (stressLevel >= 8)
        {
            difficultyLevel--;
            difficultyLevel = Mathf.Clamp(difficultyLevel, 1, 5);
            position.y -= 2f;
        }



        targetPosition = position;
        UpdateUI();
    }

    void UpdateUI()
    {
        difficultyText.text = "Zorluk Seviyesi: " + difficultyLevel;

        if (stressLevel <= 3)
        {
            statusText.text = "Durum: Stres düþük, zorluk artýrýlýyor";
        }
        else if (stressLevel >= 8)
        {
            statusText.text = "Durum: Stres yüksek, zorluk azaltýlýyor";
        }
        else
        {
            statusText.text = "Durum: Dengeli";
        }
    }
}