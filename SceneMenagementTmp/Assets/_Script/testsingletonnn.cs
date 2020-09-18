using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class testsingletonnn : MonoBehaviour
{
    public Text gamescore;
    // Start is called before the first frame update
    void Start()
    {
        //gamescore.GetComponent<Text>().text = SingletonGameManager.Instance.GameScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        gamescore.text = "Game score : " + SingletonGameManager.Instance.GameScore.ToString();
    }
}
