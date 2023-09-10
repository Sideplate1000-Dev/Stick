using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript1 : MonoBehaviour
{
    public int boom_fail;

    public void fail() {
        SceneManager.LoadScene(boom_fail);
    }
}