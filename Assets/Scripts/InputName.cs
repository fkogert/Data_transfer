using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputName : MonoBehaviour
{
    public TMP_InputField inputName;
    // Start is called before the first frame update
    void Start()
    {
        inputName.text = Manager.yourName;
    }
}
