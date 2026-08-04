using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TherapyProgression : MonoBehaviour
{
    public Transform player;
    public Transform platformCenter;
    public FearSystem fearSystem;
    public AudioSource heartbeatAudio;
    public TMP_Text taskText;
    public TMP_Text sessionCompleteText;
    public bool sessionStarted = false;

    public float edgeDistance = 3f;

    private int stage = 0;

    private float timer = 0f;

    void Update()
    {
        if (!sessionStarted)
        {
            taskText.text = "";
            return;
        }
        float distance = Vector3.Distance(
            new Vector3(player.position.x, 0, player.position.z),
            new Vector3(platformCenter.position.x, 0, platformCenter.position.z)
        );

        // STAGE 0
        if (stage == 0)
        {
            timer += Time.deltaTime;

            taskText.text = "Görev: Platformda kal | Süre: " + Mathf.Ceil(timer);

            if (timer >= 10f)
            {
                stage = 1;
            }
        }

        // STAGE 1
        else if (stage == 1)
        {
            taskText.text = "Görev: Kenara yaklaþ";

            if (distance >= edgeDistance)
            {
                stage = 2;
                timer = 0f;
            }
        }

        // STAGE 2
        else if (stage == 2)
        {
            taskText.text = "Görev: Nefesini kontrol et";

            timer += Time.deltaTime;

            if (timer >= 5f)
            {
                stage = 3;
            }
        }

        // STAGE 3
        else if (stage == 3)
        {
            taskText.text = "Görev: Güvenli bölgeye dön";

            if (distance < 1.5f)
            {
                stage = 4;
            }
        }

        // STAGE 4
        else if (stage == 4)
        {
            taskText.text = "";

            if (sessionCompleteText != null)
            {
                Color color = sessionCompleteText.color;

                color.a = Mathf.Lerp(color.a, 1f, Time.deltaTime * 1.5f);

                sessionCompleteText.color = color;
            }

            if (fearSystem != null)
            {
                fearSystem.fearLevel = Mathf.Lerp(fearSystem.fearLevel, 0f, Time.deltaTime * 1.5f);
            }

            if (heartbeatAudio != null)
            {
                heartbeatAudio.volume = Mathf.Lerp(heartbeatAudio.volume, 0f, Time.deltaTime * 2f);
            }
        }
    }
}