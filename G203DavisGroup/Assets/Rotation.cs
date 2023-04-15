using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void leftRotation()
    {
        transform.Rotate(new Vector3(0,1,0),-15 * Time.deltaTime);
    }
    public void rightRotation()
    {
        transform.Rotate(new Vector3(0, 1, 0),15 * Time.deltaTime);
    }
}
