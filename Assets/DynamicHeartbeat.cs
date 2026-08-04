using UnityEngine;

public class DynamicHeartbeat : MonoBehaviour
{
    public Transform player;
    public Transform platformCenter;

    public float maxFearDistance = 4f;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        float distance = Vector3.Distance(player.position, platformCenter.position);

        float stress = Mathf.Clamp01(distance / maxFearDistance);

        audioSource.pitch = Mathf.Lerp(0.8f, 1.5f, stress);

        audioSource.volume = Mathf.Lerp(0.1f, 0.6f, stress);
    }
}