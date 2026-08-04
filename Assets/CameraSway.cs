using UnityEngine;

public class CameraSway : MonoBehaviour
{
    public float baseSwayAmount = 0.01f;
    public float maxSwayAmount = 0.08f;
    public float swaySpeed = 1.5f;

    public float shakeAmount = 0.04f;
    public float shakeStartFear = 70f;

    [Range(0, 100)]
    public float fearLevel = 0f;

    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.localPosition;
    }

    void Update()
    {
        float fearMultiplier = fearLevel / 100f;
        float currentSwayAmount = Mathf.Lerp(baseSwayAmount, maxSwayAmount, fearMultiplier);

        float swayX = Mathf.Sin(Time.time * swaySpeed) * currentSwayAmount;
        float swayY = Mathf.Cos(Time.time * swaySpeed * 0.5f) * currentSwayAmount;

        Vector3 sway = new Vector3(swayX, swayY, 0);

        Vector3 shake = Vector3.zero;

        if (fearLevel >= shakeStartFear)
        {
            float shakeStrength = (fearLevel - shakeStartFear) / (100f - shakeStartFear);
            shake = Random.insideUnitSphere * shakeAmount * shakeStrength;
            shake.z = 0;
        }

        transform.localPosition = initialPosition + sway + shake;
    }
}