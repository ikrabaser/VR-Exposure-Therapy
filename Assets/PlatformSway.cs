using UnityEngine;

public class PlatformSway : MonoBehaviour
{
    public float swayAmount = 0.5f;
    public float swaySpeed = 1f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float sway = Mathf.Sin(Time.time * swaySpeed) * swayAmount;

        transform.position = startPos + new Vector3(sway, 0, 0);
    }
}