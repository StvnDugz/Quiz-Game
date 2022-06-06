using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataController : MonoBehaviour
{
    public RoundData[] allRoundData;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("Menu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public RoundData GetCurrentRoundData()
    {
        return allRoundData[0];
    }
}
