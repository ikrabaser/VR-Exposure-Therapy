using UnityEngine;
using System.IO;

public class SessionLogger : MonoBehaviour
{
    private string filePath;

    void Start()
    {
        filePath = Application.dataPath + "/session_log.csv";

        if (!File.Exists(filePath))
        {
            File.WriteAllText(filePath,
                "Event,Stress,Difficulty,Time\n");
        }
    }

    public void LogSessionData(int stressLevel,
                               int difficultyLevel,
                               string eventName)
    {
        string logLine =
            eventName + "," +
            stressLevel + "," +
            difficultyLevel + "," +
            Time.time.ToString("F2") + "\n";

        File.AppendAllText(filePath, logLine);

        Debug.Log("Logged: " + logLine);
    }
}