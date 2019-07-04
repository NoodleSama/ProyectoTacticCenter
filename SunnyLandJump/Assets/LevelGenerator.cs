using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{


    public Transform player;
    public GameObject platformerPrephap;

    public GameObject SecondplatformerPrephap;
    public GameObject PlatformSpecial;

    public GameObject PlatformD;

    public float SminY = 10f;

    public float SMaxy = 30f;

      public float PminY = 10f;

    public float PMaxy = 30f;
    public int numberofPlatforms;
    public int numberofPlat1;
    public int numberofSpecialPlatforms;

     public int numberofDPlatforms;
    public float levelwidth = 3f;
    public float minY = 0.8f;

    public float Maxy = 2f;

    public float minYY = 2.3f;

    public float MaxYY = 3.1f;

    float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
        Vector3 spawnposition = new Vector3();
        for (int i = 0; i < numberofPlatforms; i++){
            spawnposition.y += Random.Range(minY,Maxy);
            spawnposition.x = Random.Range(-levelwidth, levelwidth);
            Instantiate(platformerPrephap, spawnposition, Quaternion.identity);;
        }
       
          
                 Vector3 anotherspawnposition = new Vector3();
        for (int i = 0; i < numberofPlat1; i++){
            anotherspawnposition.y += Random.Range(minY,Maxy);
            anotherspawnposition.x = Random.Range(-levelwidth, levelwidth);
            Instantiate(platformerPrephap, anotherspawnposition, Quaternion.identity);;
        }    
       

        Vector3 spawnposition1 = new Vector3();
        for (int i = 0; i < numberofSpecialPlatforms; i++){
            spawnposition1.y += Random.Range(SminY,SMaxy);
            spawnposition1.x = Random.Range(-levelwidth, levelwidth);
            Instantiate(PlatformSpecial, spawnposition1, Quaternion.identity);;
        }

         Vector3 spawnposition2 = new Vector3();
        for (int i = 0; i < numberofDPlatforms; i++){
            spawnposition2.y += Random.Range(PminY,PMaxy);
            spawnposition2.x = Random.Range(-levelwidth, levelwidth);
            Instantiate(PlatformD, spawnposition2, Quaternion.identity);;
        }

        

        
        
    }

    // Update is called once per frame
    void Update()
    {

       
    }
}
