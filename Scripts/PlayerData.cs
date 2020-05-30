using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Unity.Editor;
using Firebase.Database;
[System.Serializable]
public class PlayerData


{

    public enum estado
    {
        MUY_PROBABLE_AMIGO,
        MUY_PROBALE,
        RESFRIADO,
        NO_ENFERMO,
        DATOS_INSUFICIENTES
    }
    public estado tieneCorona = estado.DATOS_INSUFICIENTES;
    public int puntuacion = 0;
    //public string Email;
    
    
    public PlayerData() {

    }

    public PlayerData(estado TieneCorona)
    {
        this.tieneCorona = TieneCorona;
        //this.Email = Email;
    }

    

}
