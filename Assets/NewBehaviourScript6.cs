using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript6 : MonoBehaviour
{
    public int backstory;

    public void next() {
        SceneManager.LoadScene(backstory);
    }
}