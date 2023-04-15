using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Meun : MonoBehaviour
{
    public GameObject menuList;
    [SerializeField] private bool menuKeys = true;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (menuKeys)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {

                menuList.SetActive(true);
                menuKeys = false;
                Time.timeScale = (0);



            }
        } else if (Input.GetKeyDown(KeyCode.Escape)) {
            menuList.SetActive(false);
            menuKeys = true;
            Time.timeScale = (1);
        }
    }


    public void Ruturn() {
        menuList.SetActive(false);
        menuKeys = true;
        Time.timeScale = 1;
        
        }

    public void Restart()
        {
        SceneManager.LoadScene(0);
        Time.timeScale=1;
        }

    public void Exur()  
    {
        Application.Quit();
    }
    public void OPP()
    {
        menuList.SetActive(true);
        menuKeys = false;
        Time.timeScale = (0);
    }


}
