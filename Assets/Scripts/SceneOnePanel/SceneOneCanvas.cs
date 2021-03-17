using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CardGame
{

    public class SceneOneCanvas : MonoBehaviour
    {
        private UIManager uiManager;
        private GameObject BackGround;
        
        void Start()
        {
            uiManager = new UIManager();
            BackGround = GameObject.FindGameObjectWithTag("BackGround");
        }

    }
}
