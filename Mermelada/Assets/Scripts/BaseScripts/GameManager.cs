using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Variables
    
    public static GameManager _GameManager;

    public bool paused = false;

    #endregion

    #region Unity Methods

    void Awake()
    {
        if (_GameManager != null)
        {
            Destroy(gameObject);
        }
        else
        {
            _GameManager = this;
        }
        DontDestroyOnLoad(gameObject);
    }
    
    
    #endregion
}
