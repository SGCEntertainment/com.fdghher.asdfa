using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Item : MonoBehaviour
{
    [SerializeField] private string text;
    [SerializeField] private string text2;

    public void GetRes()
    {
        Panel.instance.SetRes(text, text2);
    }
}
