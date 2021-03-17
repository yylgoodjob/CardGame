using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CardGame
{

    public class UIManager
    {
        private void Awake()
        {
            //注册事件
            EventCenter.AddListener<int>(EventType.CLICKJUMPSCENE, ClickJumpScene);
            EventCenter.AddListener(EventType.CLICKEXIT, ClickExit);
            EventCenter.AddListener<GameObject>(EventType.SHOWGAMEOBJECT, ShowGameObject);
            EventCenter.AddListener<GameObject>(EventType.HIDEGAMEOBJECT, HideGameObject);
        }

        private void OnDisable()
        {
            //销毁事件
            EventCenter.RemoveListener<int>(EventType.CLICKJUMPSCENE, ClickJumpScene);
            EventCenter.RemoveListener(EventType.CLICKEXIT, ClickExit);
            EventCenter.RemoveListener<GameObject>(EventType.SHOWGAMEOBJECT, ShowGameObject);
            EventCenter.RemoveListener<GameObject>(EventType.HIDEGAMEOBJECT, HideGameObject);
        }
        /// <summary>
        /// 显示物体
        /// </summary>
        /// <param name="go">要显示的物体</param>
        private void ShowGameObject(GameObject go)
        {
            go.SetActive(true);
        }

        /// <summary>
        /// 隐藏物体
        /// </summary>
        /// <param name="go">要隐藏的物体</param>
        private void HideGameObject(GameObject go)
        {
            go.SetActive(false);
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

        //对外开放的方法
        /// <summary>
        /// 开始游戏（切换场景1）
        /// </summary>
        public void ClickStartGame()
        {
            //场景一为进入游戏是的界面，后续可以更改TODO
            ClickJumpScene(1);
        }

        /// <summary>
        /// 退出游戏
        /// </summary>
        public void ClickExitGame()
        {
            Application.Quit();
        }
    }
}
