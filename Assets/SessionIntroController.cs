using UnityEngine;

public class SessionIntroController : MonoBehaviour
{
    public GameObject introPanel;
    public GameObject hudPanel;
    public GameObject breathingPanel;
    public GameObject taskPanel;
    public MonoBehaviour movementScript;
    public MonoBehaviour lookScript;
    public TherapyProgression therapyProgression;
    public AudioSource heartbeatAudio;

    private bool started = false;

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        movementScript.enabled = false;
        lookScript.enabled = false;

        if (hudPanel != null)
            hudPanel.SetActive(false);

        if (breathingPanel != null)
            breathingPanel.SetActive(false);

        if (taskPanel != null)
            taskPanel.SetActive(false);

        if (therapyProgression != null)
            therapyProgression.sessionStarted = false;

    }

    void Update()
    {
        if (!started && (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space)))
        {
            StartSession();
        }
    }

    public void StartSession()
    {
        started = true;
        movementScript.enabled = true;
        lookScript.enabled = true;

        if (introPanel != null)
            introPanel.SetActive(false);

        if (hudPanel != null)
            hudPanel.SetActive(true);

        if (breathingPanel != null)
            breathingPanel.SetActive(true);

        if (taskPanel != null)
            taskPanel.SetActive(true);

        if (therapyProgression != null)
            therapyProgression.sessionStarted = true;

        if (heartbeatAudio != null)
        {
            heartbeatAudio.volume = 0f;
            heartbeatAudio.Play();
        }

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}