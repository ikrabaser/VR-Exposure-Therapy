using UnityEngine;

public class FallZone : MonoBehaviour
{
    public Transform player;
    public Vector3 resetPosition = new Vector3(0, 21, 0);

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == player)
        {
            player.position = resetPosition;
        }
    }
}