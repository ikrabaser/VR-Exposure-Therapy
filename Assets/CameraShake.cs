using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float shakeAmount = 0.03f;
    public float shakeSpeed = 20f;
    public bool isShaking = false;

    private Vector3 targetPosition;

    void Start()
    {
        targetPosition = transform.localPosition;
    }

    void Update()
    {
        if (isShaking)
        {
            float x = Mathf.Sin(Time.time * shakeSpeed) * shakeAmount;
            float y = Mathf.Cos(Time.time * shakeSpeed) * shakeAmount;

            transform.localPosition =
                targetPosition + new Vector3(x, y, 0);
        }
        else
        {
            transform.localPosition = Vector3.Lerp(
                transform.localPosition,
                targetPosition,
                Time.deltaTime * 8f
            );
        }
    }
}