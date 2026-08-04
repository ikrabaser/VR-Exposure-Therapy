using UnityEngine;

public class BreathingCamera : MonoBehaviour
{
    public Transform player;
    public Transform platformCenter;

    public float minBreathing = 0.01f;
    public float maxBreathing = 0.06f;

    public float breathingSpeed = 1.5f;
    public float maxFearDistance = 4f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.localPosition;
    }

    void Update()
    {
        float distance = Vector3.Distance(player.position, platformCenter.position);

        float stress = Mathf.Clamp01(distance / maxFearDistance);

        float breathingAmount = Mathf.Lerp(minBreathing, maxBreathing, stress);

        float offsetY = Mathf.Sin(Time.time * breathingSpeed) * breathingAmount;

        transform.localPosition = startPos + new Vector3(0, offsetY, 0);
    }
}