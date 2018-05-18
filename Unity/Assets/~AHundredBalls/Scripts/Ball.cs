using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AHundredBalls
{
    public class Ball : MonoBehaviour
    {
        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Contains("Bucket"))
            {
                transform.SetParent(collision.transform);
            }
        }
    }
}