 using UnityEngine;
 using UnityEngine.UI;
 using System.Collections;
 using UnityEngine.SceneManagement;
 
 public class delay : MonoBehaviour {
 
    public int game;

    void start ()
    {
        Invoke("time", 5);
    }

    public void time()
    {
        SceneManager.LoadScene(game);
    }
 }