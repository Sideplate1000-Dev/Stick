using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript5 : MonoBehaviour
{
    public int gun;

    public void gunbang() {
         SceneManager.LoadScene(gun);
     }
    
}