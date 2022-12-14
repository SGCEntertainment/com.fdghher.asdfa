using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Panel : MonoBehaviour
{
    public static Panel instance;

    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private TextMeshProUGUI text2;


    private void Awake()
    {
        instance = this;
    }

    public void SetRes(string t, string t2)
    {
        text.text = t;
        text2.text = t2;
    }
}
