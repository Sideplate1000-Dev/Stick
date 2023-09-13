using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteHolder : MonoBehaviour
{
    public Sprite spriteToAssign;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
