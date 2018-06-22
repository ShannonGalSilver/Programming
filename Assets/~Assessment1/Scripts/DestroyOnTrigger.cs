using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assessment1
{
    public class DestroyOnTrigger : MonoBehaviour
    {
        public void OnTriggerEnter(Collider other)
        {
            Destroy(gameObject);

        }
    }
}