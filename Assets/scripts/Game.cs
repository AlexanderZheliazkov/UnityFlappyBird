using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{

    public static Game instance;

    public float gameSpeed = 10;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ResetLeve()
    {
        SceneManager.LoadScene(0);
    }
}
