using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenario1 : MonoBehaviour
{
    public void OnLoginButtonClick()
    {
        SceneManager.LoadScene(2);
    }
}