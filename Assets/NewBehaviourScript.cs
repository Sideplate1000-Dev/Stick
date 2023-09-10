using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public int game;

    public void StartGame() {
        SceneManager.LoadScene(game);
    }
}