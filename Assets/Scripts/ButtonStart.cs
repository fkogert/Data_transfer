using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonStart : MonoBehaviour
{
    public TMP_InputField inputName;


    public void LoadGame()
    {
        Manager.yourName = inputName.text;
        SceneManager.LoadScene(1);
    }
}
