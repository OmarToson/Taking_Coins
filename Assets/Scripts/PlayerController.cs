using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;

    public Text countText;
    public Text winText;

    private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        count = 0;
        SetCountText();
        winText.text = "";
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Vertical");
        float moveVertical = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);  //x , y ,z

        rb.AddForce(movement * speed);  //i don't put value pecause i won't it static 
        //i can press on player --> inspector--> player controller --> change speed
    }

    void OnTriggerEnter(Collider other)     //when the object touch collider
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);  //set player checkbox from inspector = false 

            count = count + 1;
            SetCountText();
        }
    }


    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 15)
        {
            winText.text = "You Win!";
        }
    }
}


