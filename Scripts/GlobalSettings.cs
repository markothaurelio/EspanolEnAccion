using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalSettings : MonoBehaviour
{

    public static string lan = "english";

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(lan + SceneManager.GetActiveScene().buildIndex);
        
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            SceneManager.LoadScene(1);
        }
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
