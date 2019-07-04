using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public Transform player;
    public Text Stext;

    // Update is called once per frame
    void Update()
    {
        Stext.text = player.position.y.ToString("0");
    }
}
