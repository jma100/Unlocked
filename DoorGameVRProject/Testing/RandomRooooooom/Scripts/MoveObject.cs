using UnityEngine;
using UnityEngine.VR;
using System;
using System.Collections;

using Gvr.Internal;

public class MoveObject : MonoBehaviour
{
    public GameObject obj;
    bool isMoving;
    public void MoveOn()
    {
        isMoving = true;
    }
    public void MoveOff()
    {
        isMoving = false;
    }
   
    void Update()
    {
        if (isMoving)
        {
            Quaternion ori = GvrController.Orientation;
            Vector3 vector = ori * Vector3.forward;
            obj.transform.position = new Vector3(vector.x, vector.y, vector.z);
        }
    }


    
}