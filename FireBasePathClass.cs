using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBasePathClass
{
    public string BasePath, DBVersion, ObjectTypeName;

    private string fullPath()
    {
        return DBVersion + "/" + BasePath + "/" + ObjectTypeName;
    }

    public void ConstrucF(string BasePath, string DBVersion)
    {
        this.BasePath = BasePath;
        this.DBVersion = DBVersion;
        //this.ObjectTypeName = ObjectTypeName;
    }

    public Firebase.Database.DatabaseReference GetReferenceFromRoot(Firebase.Database.DatabaseReference root)
    {
        var objectTypeName = ObjectTypeName;
        return root.Child(DBVersion).Child(BasePath)/*.Child(objectTypeName)*/;
    }

}
