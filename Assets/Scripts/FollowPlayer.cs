using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{    public GameObject player;
    private Vector3 offset = new Vector3(x: 15.1f, y: 0, z: 0);
        void LateUpdate()
        {
            transform.position = player.transform.position + offset;
        }
}
