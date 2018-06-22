using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AHundredBalls
{
    public class Spawner : MonoBehaviour
    {
        public GameObject prefab;
        public float spawnDelay = 2f;
        public bool spawnRandomly = false;
        public float range = 10f;

      void OnDrawGizmos()
        {
            if (spawnRandomly)
            {
                Vector2 position = transform.position;
                float halfRange = range * 0.5f;
                Vector2 start = new Vector2(position.x - halfRange, position.y);
                Vector2 end = new Vector2(position.x + halfRange, position.y);
                Gizmos.DrawLine(start, end);
                               
            }
        }
        void Start()
        {
            StartCoroutine(Spawn());
        }

        IEnumerator Spawn()
        {
            yield return new WaitForSeconds(spawnDelay);

            Vector3 position = transform.position;
            
            if (spawnRandomly)
            {
                float halfRange = range * 0.5f;
                position.x += Random.Range(-range, range);
            }

            Instantiate(prefab, position, transform.rotation);

            StartCoroutine(Spawn());
        }
    }
}