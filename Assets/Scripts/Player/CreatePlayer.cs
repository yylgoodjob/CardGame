using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayer : MonoBehaviour
{
    //TODO
    private int PeopleNumber = 4;//该属性后期需要更改，现在默认为4人，方便测试
    private GameObject PlayerPerfab;
    private ArrayList Players = new ArrayList();


    private void Awake()
    {
        PlayerPerfab = Resources.Load<GameObject>("Prefabs/TestPlayer");

        for (int i = 0; i < PeopleNumber; i++)
        {
            GameObject go = Instantiate(PlayerPerfab);
            Players.Add(go);
            go.transform.SetParent(this.transform);
        }
    }
}
