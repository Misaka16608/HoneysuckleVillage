using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoneysuckleVillage.Games;

namespace HoneysuckleVillage
{
    public class GameEntry : MonoBehaviour
    {
        private Game game;
        private void Awake()
        {
            game = Game.Instance;
        }
    }
}

