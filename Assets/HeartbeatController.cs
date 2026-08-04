using UnityEngine;

public class HeartbeatController : MonoBehaviour
{
    public AudioSource heartbeatAudio;

    public void UpdateHeartbeat(int stressLevel)
    {
        if (stressLevel >= 8)
        {
            if (!heartbeatAudio.isPlaying)
            {
                heartbeatAudio.Play();
            }

            heartbeatAudio.volume = Mathf.Lerp(heartbeatAudio.volume, 0.8f, Time.deltaTime * 2f);
        }
        else
        {
            heartbeatAudio.volume = Mathf.Lerp(heartbeatAudio.volume, 0f, Time.deltaTime * 2f);

            if (heartbeatAudio.volume < 0.05f && heartbeatAudio.isPlaying)
            {
                heartbeatAudio.Stop();
            }
        }
    }
}