using UnityEngine;

public class FallReset : MonoBehaviour
{
    public AudioSource fallAudio;

    private Vector3 startPosition;
    private Quaternion startRotation;
    private Rigidbody rb;

    void Start()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (transform.position.y < 5f)
        {
            ResetPlayer();
        }
    }

    void ResetPlayer()
    {
        if (fallAudio != null)
        {
            fallAudio.Play();
        }

        if (rb != null)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }

        transform.position = startPosition;
        transform.rotation = startRotation;
    }
}