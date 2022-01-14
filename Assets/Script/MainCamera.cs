using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public GameObject player;
    public float speed;
    private Vector3 playerPosition;
    private void Update()
    {
        if (player.gameObject != null)
        {
            playerPosition.Set(player.transform.position.x, player.transform.position.y, this.transform.position.z);

            this.transform.position = Vector3.Lerp(this.transform.position, playerPosition, speed * Time.deltaTime);
        }
    }


}
