using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript4 : MonoBehaviour
{
    public int birthday_ebd;

    public void birthday() {
         SceneManager.LoadScene(birthday_ebd);
     }
    
}