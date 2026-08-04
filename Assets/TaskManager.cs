using UnityEngine;
using TMPro;

public class TaskManager : MonoBehaviour
{
    public TextMeshProUGUI taskText;

    public float taskDuration = 10f;
    private float remainingTime;
    private bool taskCompleted = false;

    void Start()
    {
        remainingTime = taskDuration;
        UpdateTaskText();
    }

    void Update()
    {
        if (taskCompleted)
            return;

        remainingTime -= Time.deltaTime;

        if (remainingTime <= 0)
        {
            remainingTime = 0;
            taskCompleted = true;
        }

        UpdateTaskText();
    }

    void UpdateTaskText()
    {
        if (taskCompleted)
        {
            taskText.text = "Görev tamamlandý";
        }
        else
        {
            taskText.text = "Görev: Platformda kal | Süre: " + Mathf.CeilToInt(remainingTime);
        }
    }
}