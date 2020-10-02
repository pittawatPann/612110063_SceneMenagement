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
        GetComponent<Text>().text = SingletonGameApplicationManager.Instance.DIFFICULTY_LEVEL_NAMES[SingletonGameApplicationManager.Instance.DifficultyLevel];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
