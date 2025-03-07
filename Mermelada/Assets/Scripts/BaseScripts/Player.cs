using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;


public class Player : MonoBehaviour
{
    private GameManager _gameManager;

    public string playerName;

    public static Player _Player;
    
    void Awake()
    {
        _gameManager = FindObjectOfType<GameManager>();
        
        if (_Player != null)
        {
            Destroy(gameObject);
        }
        else
        {
            _Player = this;
        }
        DontDestroyOnLoad(gameObject);

    }

}
