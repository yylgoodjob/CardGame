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

        // Start is called before the first frame update
        void Start()
        {
            uiManager = new UIManager();
            Btn_StartGame = GameObject.FindGameObjectWithTag("Btn_StartGame");

            Button btn1 = Btn_StartGame.AddComponent<Button>();

            btn1.onClick.AddListener(uiManager.ClickStartGame);
        }

    }
}
