using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintEeeeee : MonoBehaviour
{
    public void PrintTextAbstraction(string text) => PrintText(text);
    private void PrintText(string text) { Debug.Log(text); }
}
