using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        Vector3 hareket = Vector3.zero;

        if (Input.GetKey(KeyCode.W)) hareket += Vector3.forward;
        if (Input.GetKey(KeyCode.S)) hareket += Vector3.back;
        if (Input.GetKey(KeyCode.A)) hareket += Vector3.left;
        if (Input.GetKey(KeyCode.D)) hareket += Vector3.right;

        transform.position += hareket.normalized * speed * Time.deltaTime;
    }
}