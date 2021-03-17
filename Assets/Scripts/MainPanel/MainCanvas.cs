using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CardGame
{

    public class MainCanvas : MonoBehaviour
    {
        private UIManager uiManager;
        private GameObject Btn_StartGame;
        private GameObject Btn_ExitGame;

        // Start is called before the first frame update
        void Start()
        {
            uiManager = new UIManager();
            Btn_StartGame = GameObject.FindGameObjectWithTag("Btn_StartGame");
            Btn_ExitGame = GameObject.FindGameObjectWithTag("Btn_ExitGame");

            Button btn1 = Btn_StartGame.AddComponent<Button>();
            Button btn2 = Btn_ExitGame.AddComponent<Button>();

            btn1.onClick.AddListener(uiManager.ClickStartGame);
            btn2.onClick.AddListener(uiManager.ClickExitGame);
        }

    }
}
