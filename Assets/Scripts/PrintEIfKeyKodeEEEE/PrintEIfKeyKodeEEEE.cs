using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PrintEIfKeyKodeEEEE : MonoBehaviour
{
    private PrintEeeeee PrintE;
    //[Inject] private PrintEeeeee PrintE; второй вариант(нужно уточнить норм или нет)
    
    [Inject]
    private void Construct(PrintEeeeee print) 
    {
        PrintE = print;
    }
    private void Update()
    {
        PrintSomeText();
    }

    private void PrintSomeText()
    {
        if(Input.GetKeyDown(KeyCode.E)) { PrintE.PrintTextAbstraction("Hello world!"); }
    }
}
