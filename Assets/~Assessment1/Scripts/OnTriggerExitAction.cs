using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;

namespace Assessment1
{
    public class OnTriggerExitAction : MonoBehaviour
    {
        public string nameContains = "Player";
        public UnityEvent onTrigger;
        void OnTriggerExit(Collider col)
        {
            if (col.name.Contains(nameContains))
            {
                onTrigger.Invoke();
            }
        }
    }
}