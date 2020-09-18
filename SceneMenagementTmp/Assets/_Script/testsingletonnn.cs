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
        GetComponent<Text>().text = GameApplicationMaganer.Instance.DIFFICULTY_LEVEL_NAMES[GameApplicationMaganer.Instance.DifficultyLevel];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
