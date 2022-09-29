using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontrol : MonoBehaviour
{
    [SerializeField]private Transform player;
    
   private void LateUpdate()
    {
        transform.position = new Vector3(player.position.x, player.position.y, -10);
    }
}
