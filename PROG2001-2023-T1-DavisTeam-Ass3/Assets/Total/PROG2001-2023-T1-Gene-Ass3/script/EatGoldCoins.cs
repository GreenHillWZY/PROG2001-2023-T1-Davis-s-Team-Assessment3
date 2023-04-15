using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EatGoldCoins : MonoBehaviour
{   
    AudioSource pickSou;
    private int score = 0;	
	public Text text;
	public GameObject winText;
	public GameObject retButton;
	public AudioClip picking,winning;
    // Start is called before the first frame update
    void Start()
    {
        pickSou = GetComponent<AudioSource>();		
    }
	void OnTriggerEnter(Collider collider)
    {
        //string name = collision.collider.name;
		//print(name);
		if(collider.tag == "pick up")
		{
			pickSou.clip = picking;
			pickSou.Play();
			score++;
			text.text = score.ToString();
			if(score == 13)
			{
				pickSou.clip = winning;
			    pickSou.Play();
				winText.SetActive(true);
				retButton.SetActive(true);
			}
			Destroy(collider.gameObject);
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
