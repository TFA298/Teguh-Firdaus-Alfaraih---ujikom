using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Main_Menu : MonoBehaviour
{
    public GameObject play_Button;
    public GameObject exit_Button;
    // Start is called before the first frame update
    void Start()
    {
        // SceneManager.LoadScene("Main_Menu");
        var button = play_Button.GetComponent<Button>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Play_Button(){
        
    }

    void Exit_Button(){
        EditorApplication.Exit(0);
    }
}
