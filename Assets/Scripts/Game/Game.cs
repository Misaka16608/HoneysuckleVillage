using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    #region Singleton
    private static Game _instance;

    public static Game Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<Game>();
                if (_instance == null)
                {
                    GameObject singleton = new GameObject("GameSingleton");
                    _instance = singleton.AddComponent<Game>();
                    DontDestroyOnLoad(singleton);
                }
            }
            return _instance;
        }
    }
    #endregion



    #region UnityEvent
    public void OnDestroy()
    {
        _instance = null;
    }
    #endregion
}
