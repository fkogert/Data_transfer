using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Manager : MonoBehaviour
{
    static public Manager instance;
    string yourName = "Your Name";
    public TMP_InputField inputName;


    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);

        inputName = GameObject.Find("InputName").GetComponent<TMP_InputField>();
        Manager.instance.inputName = inputName;
        inputName.text = Manager.instance.yourName;



    }

    // Update is called once per frame
    void Update()
    {

    }


    public void GameExit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }




    public void LoadGame()
    {
        yourName = inputName.text;
        SceneManager.LoadScene(1);
    }




    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
}
