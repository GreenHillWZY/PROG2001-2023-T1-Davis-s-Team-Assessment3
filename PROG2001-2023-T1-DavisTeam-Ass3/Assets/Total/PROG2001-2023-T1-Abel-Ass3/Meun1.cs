using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meun1 : MonoBehaviour
{
    private AudioSource menuAudio;
    private Slider auidoSlider;
    // Start is called before the first frame update
    void Start()
    {
        
        menuAudio = GameObject.FindGameObjectWithTag("food").transform.GetComponent<AudioSource>();
        auidoSlider = GameObject.FindGameObjectWithTag("menu").transform.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        VolumeControll();
    }
    public void VolumeControll()
    {
        menuAudio.volume = auidoSlider.value;
    }
}
