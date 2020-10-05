using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public CubeMovement cm;

    void OnCollisionEnter (Collision colInfo)
    {
        if(colInfo.collider.tag == "Obstacle")
        {
            cm.enabled = false;
        }
    }
}
