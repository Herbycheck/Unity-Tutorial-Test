using System.Net.Security;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    //[SerializeField] Vector3 PlayerPosition;
    [SerializeField] float Speed;
    [SerializeField] float minX,maxX,minZ,maxZ;
    [SerializeField] float Cooldown;
    float lastTime;
    float cooldownTimer;
    Vector3 PlayerPosition;

    private void Start()
    {
        lastTime = Time.time;
        cooldownTimer = 0;
    }

    private void Update()
    {
        //if (lastTime + Cooldown < Time.time)
        //{
        //    float randomX = Random.Range(minX, maxX);
        //    float randomZ = Random.Range(minZ, maxZ);
        //    PlayerPosition = new Vector3(randomX, 0, randomZ);
        //    Debug.Log(PlayerPosition);
        //    lastTime = Time.time;
        //}

        if (cooldownTimer > Cooldown)
        {
            float randomX = Random.Range(minX, maxX);
            float randomZ = Random.Range(minZ, maxZ);
            PlayerPosition = new Vector3(randomX, 0, randomZ);
            Debug.Log(PlayerPosition);
            cooldownTimer = 0;
        }

        Vector3 direction = Vector3.Normalize(PlayerPosition - transform.position);
        direction.y = 0;
        //Debug.Log($"Direction: {direction}");
        if(direction.x != 0 && direction.z != 0)
        {
            transform.forward = direction;
            transform.position += direction * Time.deltaTime * Speed;
        }
        cooldownTimer += Time.deltaTime;
    }
}
