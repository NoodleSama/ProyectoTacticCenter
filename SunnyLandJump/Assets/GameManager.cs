using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    bool gamehasEnded = false;

    bool ObjectDestroyed = false;

    public GameObject Plataforma;
    public float restartDelay = 0.3f;
    public float DestroyedDelay = 0.1f;
      public void EndGame(){

          if (gamehasEnded == false){


              gamehasEnded = true;
              Debug.Log("GameOver");
              Invoke("restart",restartDelay);
          }
          
    }

  /*   public void DestruirObjeto(){

        if (ObjectDestroyed == false){

            ObjectDestroyed = true;
            
            Destruir();
            Debug.Log("Destruido");
            ObjectDestroyed = false;
        }
    }*/
    
    void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //void Destruir(){
      //  Destroy(Plataforma.gameObject);
        //Debug.Log("Ocupo esto");
    //}
}
