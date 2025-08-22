using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{
    public string scenename;
 
 void OnTriggerEnter2D(Collider2D collision){
  if(collision.CompareTag("Player")){
   SceneManager.LoadScene(scenename);
   Debug.Log("puerta azul!");

  }
 }
}
