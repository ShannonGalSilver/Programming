using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assessment1
{
    public class EnemySpawner : MonoBehaviour
    {

        public GameObject[] enemies;
        public float spawnRate = 1f;
        public float spawnRadius = 5f;

        void Spawn()
        {
            //Sets the area of spawn
            Vector3 rand = Random.insideUnitSphere * spawnRadius;

            Vector3 position = transform.position + rand;

            int randIndex = Random.Range(0, enemies.Length);

            GameObject randEnemy = enemies[randIndex];

            GameObject clone = Instantiate(randEnemy);

            clone.transform.position = position;
        }

        void Start()
        {
            InvokeRepeating("Spawn", 0, spawnRate);
        }
    }
}