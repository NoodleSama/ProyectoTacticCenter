using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    public float Smoothspeed = .3f;

    //public Vector3 offset;
    // Update is called once per frame
    void LateUpdate()
    {
      
      //Vector3 Desiredposition = target.position + offset;
        
       if (target.position.y > transform.position.y){
         Vector3 newpos = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, newpos, Smoothspeed * Time.deltaTime);
        }
    }
}
