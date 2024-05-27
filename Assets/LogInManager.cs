using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogInManager : MonoBehaviour
{
    public InputField inputPassword;
    public Text MSJ;
    string ContraseñaDef = "Tobi123";

    public void SaludoEnConsola()
    {
        string ContraseñaIngre = inputPassword.text;
        if (ContraseñaIngre==ContraseñaDef)
        {
            
            Debug.Log("Acceso Correcto");
        }
        else
        {
            Debug.Log("Acceso Denegado");
        }
    }
}
