using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mobile : MonoBehaviour
{
    public int speed;
    public void forward()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
    public void back()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    public void left()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
    public void right()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
}
