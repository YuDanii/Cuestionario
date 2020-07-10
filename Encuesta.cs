using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encuesta : MonoBehaviour
{
    public DataManager playerData;
    public bool pregunta0Si = false;
    // Start is called before the first frame update
    /*public void addPoints(int pointsToAdd)
    {
        playerData.data.puntuacion += pointsToAdd;
    }*/
    public void setP0Respuesta(bool respuesta)
    {
        pregunta0Si = respuesta;
    }

}
