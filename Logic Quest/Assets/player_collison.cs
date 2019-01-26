using UnityEngine;

public class player_collison : MonoBehaviour
{
    void OnCollisionEnter (Collision collisionInfo){
    Debug.Log(collisionInfo.collider.name);
    }

}
