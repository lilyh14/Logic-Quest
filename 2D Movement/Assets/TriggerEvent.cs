using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
public string level = "scene2";

void OnTriggerEnter2D(Collider2D collider){
    if(collider.gameObject.tag == "Player"){
    Debug.Log("Test");
    //Application.LoadLevel(level);
    SceneManager.LoadScene(level);
        }
    }
}
