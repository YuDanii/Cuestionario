using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Unity.Editor;
using Firebase.Database;

public class PlayerData


{

    public bool tieneCorona = false;
    //public string Email;
    
    
    public PlayerData() {

    }

    public PlayerData(bool TieneCorona)
    {
        this.tieneCorona = TieneCorona;
        //this.Email = Email;
    }

    

}
