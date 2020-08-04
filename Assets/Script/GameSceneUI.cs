using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneUI : MonoBehaviour
{
    public void OnStartGame()
    {
        LevelLoader.Load(LevelLoader.Scene.GameScreen);
    }
}
