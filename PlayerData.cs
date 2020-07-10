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
        SINTOMAS
    }
    public estado tieneCorona = estado.MUY_PROBALE;
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
