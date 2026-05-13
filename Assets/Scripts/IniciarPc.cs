using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IniciarPc : MonoBehaviour, interacuar
{

    public bool MenuAbierto {get; private set;}
    public GameObject targetObject;
    
    public bool puedeinteract()
    {
        return !MenuAbierto;
    } 
    
    public void interact()
    {
        if (!puedeinteract()) return; 
        iniciapc(true);
    }


    private void iniciapc(bool abierto)
    {
        if (MenuAbierto = abierto)
        {

            targetObject.SetActive(true);

        }
    } 
    
    
}
