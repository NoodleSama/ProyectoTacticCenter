using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecamera : MonoBehaviour
{

    public Transform target;
    public float Smooth = 1f;

    private Vector3 currentveocity;
    // Start is called before the first frame update
    // Update is called once per frame
    void LateUpdate()
    {
       if(target.position.y > transform.position.y)
        {
            Vector3 newpos = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = Vector3.SmoothDamp(transform.position, newpos, ref currentveocity,  Smooth);
        }
    }
}
