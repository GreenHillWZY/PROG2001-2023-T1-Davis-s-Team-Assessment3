using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Rigidbody player;
    private int score = 0;
    public Text text;
    public GameObject winText;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            player.velocity = new Vector3(5, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.velocity = new Vector3(-5, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            player.velocity = new Vector3(0, 0, 5);
        }
        if (Input.GetKey(KeyCode.S))
        {
            player.velocity = new Vector3(0, 0, -5);
        }
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.collider.tag == "food") {
            Destroy(collision.collider.gameObject);
        }
        }
    void OnTriggerEnter(Collider collider) {
        if (collider.tag == "food") {
            score++;
            text.text = score.ToString();
            if (score == 5) {
                winText.SetActive(true);
                }
            Destroy(collider.gameObject);

        }
    
    }
}
