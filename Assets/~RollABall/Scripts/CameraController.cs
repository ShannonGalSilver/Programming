using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RollABall
{
    public class CameraController : MonoBehaviour
    {

        public GameObject player;

        //holds set distance between camera and player
        private Vector3 offset;

        void Start()
        {
            offset = transform.position - player.transform.position;
        }

        // LateUpdate runs every frame but is guaranteed to run after all items have been processed in update
        void LateUpdate()
        {
            transform.position = player.transform.position + offset;
        }
    }
}