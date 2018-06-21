using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Assessment1
{
    public class Death : MonoBehaviour
    {
        public UnityEvent onDeath;
        //Get starting position of player
        public Vector3 startPosition;

        void OnTriggerEnter(Collider other)
        {
            // Check if the entity came into contact 
            // with a death object
            if (other.name.Contains("DeathZone") ||
               other.name.Contains("Enemy"))
            {
                // Fire off death event
                onDeath.Invoke();
                //put the player back to the starting posiiton
                other.gameObject.SetActive(false);
                transform.position = startPosition;
            }
        }
    }
}