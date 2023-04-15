using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class help : MonoBehaviour
{
	public GameObject helpButton;
	public GameObject setButton;
	
	public void help1()
	{
		helpButton.SetActive(true);
		
	} 
	public void help2()
	{
		helpButton.SetActive(false);
		
	}
	
	public void help3()
	{
		setButton.SetActive(true);

	}
	public void help4()
	{
		setButton.SetActive(false);
	
	}
	
}
