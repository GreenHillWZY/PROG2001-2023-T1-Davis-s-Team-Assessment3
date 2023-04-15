using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Zombierun : MonoBehaviour
{
	public int speed ;
	public void forward()
	{
		//向前
		transform.Translate(Vector3.forward*Time.deltaTime*speed);
	}
	public void back()
	{
		//向后
		transform.Translate(Vector3.back*Time.deltaTime*speed);
	}
	public void left()
	{
		//向左
		transform.Translate(Vector3.left*Time.deltaTime*speed);
	}
	public void right()
	{
		//向右
		transform.Translate(Vector3.right*Time.deltaTime*speed);
	}
	
	void Update()
	{
		float hor = Input.GetAxis("Horizontal");
		float ver = Input.GetAxis("Vertical");
		transform.position += transform.forward*5*ver*Time.deltaTime;
		transform.Rotate(transform.up*40*hor*Time.deltaTime);
	}
}