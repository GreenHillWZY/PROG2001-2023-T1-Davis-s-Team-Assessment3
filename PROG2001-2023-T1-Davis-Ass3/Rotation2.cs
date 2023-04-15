using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation2 : MonoBehaviour
{       public void rightRotation()
        {
            transform.Rotate(new Vector3(0, 1, 0), 1500 * Time.deltaTime);
        } 
}
