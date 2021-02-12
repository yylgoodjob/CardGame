using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    private void Awake()
    {
        //注册事件
        EventCenter.AddListener<int>(EventType.CLICKJUMPSCENE, ClickJumpScene);
        EventCenter.AddListener(EventType.CLICKEXIT, ClickExit);
    }

    private void OnDisable()
    {
        //销毁事件
        EventCenter.RemoveListener<int>(EventType.CLICKJUMPSCENE, ClickJumpScene);
        EventCenter.RemoveListener(EventType.CLICKEXIT, ClickExit);
    }
    /// <summary>
    /// 跳转场景
    /// </summary>
    /// <param name="n">场景序号</param>
    private void ClickJumpScene(int n)
    {
        SceneManager.LoadScene(n);
    }
    /// <summary>
    /// 退出游戏
    /// </summary>
    private void ClickExit()
    {
        Application.Quit();
    }
}
