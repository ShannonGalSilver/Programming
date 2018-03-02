using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

namespace GoneHome
{
    public class GameManager : MonoBehaviour
    {
        public void NextLevel()
        {
            Scene currentScene = SceneManager.GetActiveScene();

            SceneManager.LoadScene(currentScene.buildIndex + 1);
        }
        public void ResetLevel()
        {
            Enemy[] enemies = FindObjectsOfType<Enemy>();

            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].Reset();
            }

            Player player = FindObjectOfType<Player>();
            player.Reset();

            //Scene currentScene = SceneManager.GetActiveScene();
            //SceneManager.LoadScene(currentScene.buildIndex);
        }
    }
}