using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenario2 : MonoBehaviour
{
    public void OnLoginButtonClick()
    {
        SceneManager.LoadScene(3);
    }
}