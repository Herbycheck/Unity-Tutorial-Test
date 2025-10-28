using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] PlayerData data;

    private void Update()
    {
        transform.forward = data.lookPoint - new Vector3(transform.position.x,0,transform.position.z);
        
    }
}
