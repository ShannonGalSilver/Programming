using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Use the namespace UI
using UnityEngine.UI;

namespace Assessment1
{
    public class PlayerController : MonoBehaviour
    {
        public float speed;

        public Text countText;
        public Text winText;


        //variable to hold rigidbody reference
        private Rigidbody rb;

        private int count;

        void Start()
        {
            rb = GetComponent<Rigidbody>();

            //Set the count and disply the count on screen
            count = 0;
            SetCountText();
            winText.text = "";
        }

        //FixedUpdate calculates physics
        void FixedUpdate()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            //Vector3 for the rb to say how the player moves
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            rb.AddForce(movement * speed);
        }

        // when the player collides with the pickups, increase the score by 1
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Pick Up"))
            {
                other.gameObject.SetActive(false);
                count = count + 1;
                SetCountText();
            }
        }

        void SetCountText()
        {
            countText.text = "Count: " + count.ToString();
            if (count >= 12)
            {
                winText.text = "You Win!";
            }
        }
    }
}