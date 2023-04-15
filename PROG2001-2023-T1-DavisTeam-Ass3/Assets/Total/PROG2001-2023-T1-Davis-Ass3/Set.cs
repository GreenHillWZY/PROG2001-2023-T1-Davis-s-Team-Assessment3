using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Set : MonoBehaviour
{
    public GameObject setPanel;
    private bool isSetPanelActive = false;

    private Button setButton;

    void Start()
    {
        setButton = setPanel.GetComponent<Button>();
        if (setButton != null)
        {
            setButton.onClick.AddListener(SetPanelActive);
            Debug.Log("SetPanelActive has been registered to button click event.");
        }
        else
        {
            setButton = setPanel.AddComponent<Button>();
            setButton.onClick.AddListener(SetPanelActive);
            Debug.Log("Add Button component to setPanel and register SetPanelActive to button click event.");
        }

       
        isSetPanelActive = setPanel.activeSelf;
    }

    public void SetPanelActive()
    {
        if (setPanel != null)
        {
            if (!isSetPanelActive) 
            {
                setPanel.SetActive(true);
                isSetPanelActive = true;
                Debug.Log("Panel is open");
            }
            else 
            {
                setPanel.SetActive(false);
                isSetPanelActive = false;
                Debug.Log("Panel is closed");
            }
        }
        else
        {
            Debug.LogError("setPanel is null.");
        }
    }
}
