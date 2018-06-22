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

            //Makes the position of the spawn random
            Vector3 position = transform.position + rand;

            //Picks a random number between 0 and the number of enemies
            int randIndex = Random.Range(0, enemies.Length);

            //Calls the enemy gameobject
            GameObject randEnemy = enemies[randIndex];

            //Clones the enemy gameobject
            GameObject clone = Instantiate(randEnemy);

            clone.transform.position = position;

            Destroy(clone, 3.0f);
        }

        void Start()
        {
            InvokeRepeating("Spawn", 0, spawnRate);
        }
    }
}