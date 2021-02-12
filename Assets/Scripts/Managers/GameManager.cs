using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//管理游戏中的各种属性

public class GameManager : MonoBehaviour
{
    private UIManager uiManager;

    private void Start()
    {
        uiManager = new UIManager();
    }
}
