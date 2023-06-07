using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class ManagerIO : MonoBehaviour
{
    string fileConfig = "config.ini";
    public BestScore bestScoreText;

    string[] textForSave = new string[2];
    string pathWithName;

    public void Awake()
    {
        pathWithName = Application.persistentDataPath + "/" + fileConfig;
        if (Manager.bestScore == 0) LoadConfig();
    }

    public void LoadConfig()
    {
        if (File.Exists(pathWithName))
        {
            textForSave = File.ReadAllLines(pathWithName);
            Manager.bestScoreName = textForSave[0];
            Manager.bestScore = Convert.ToInt32(textForSave[1]);
            bestScoreText.OutBestScore();
        }
    }




    public void SaveConfig()
    {
        textForSave[0] = Manager.bestScoreName;
        textForSave[1] = Manager.bestScore.ToString();
        File.WriteAllLines(pathWithName, textForSave);
    }
}
