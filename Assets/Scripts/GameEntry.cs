using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEntry : MonoBehaviour
{
    private Game game;
    private void Awake()
    {
        game = Game.Instance;
    }
}