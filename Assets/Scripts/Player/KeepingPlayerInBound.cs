using UnityEngine;

public class KeepingPlayerInBound : MonoBehaviour
{
    Vector3 newPosition;

    private void OnTriggerExit(Collider other)
    {
        if (other.tag != "player") return;
        Transform player = other.gameObject.transform.parent;
        Vector3 halfScale = transform.localScale / 2;

        // //bad code
        //if (player.position.x < -halfScale.x)
        //    newPosition.x = halfScale.x - 0.1f;
        //if (player.position.x > halfScale.x / 2)
        //    newPosition.x = -halfScale.x / 2 + 0.1f;
        //if (player.position.z < -halfScale.z / 2)
        //    newPosition.z = halfScale.y / 2 - 0.1f;
        //if (player.position.z > halfScale.z / 2)
        //    newPosition.z = -halfScale.z / 2 + 0.1f;

        // works because of Position (0,0,0) of Arena
        // also a hard teleport instead of wrapping
        newPosition.x = -Mathf.Clamp(player.position.x, -halfScale.x + 0.1f, halfScale.x - 0.1f);
        newPosition.z = -Mathf.Clamp(player.position.z, -halfScale.z + 0.1f, halfScale.z - 0.1f);

        // Wrapping
        //newPosition.x = Mathf.Repeat(player.position.x + halfScale.x,transform.localScale.x) - halfScale.x;
        //newPosition.z = Mathf.Repeat(player.position.z + halfScale.z, transform.localScale.z) - halfScale.z;

        player.position = newPosition;
    }
}
