using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript3 : MonoBehaviour
{
    public int boom_fail;

    public void ded() {
         SceneManager.LoadScene(boom_fail);
     }
}