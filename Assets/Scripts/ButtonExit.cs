using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class ButtonExit : MonoBehaviour
{
    public ManagerIO managerIO;
    public void GameExit()
    {
        managerIO.SaveConfig();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
