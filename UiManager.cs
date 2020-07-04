using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField]
    string sceneName;

    public GameObject covidAmigo;
    public GameObject covidUsuario;
    public GameObject enfermedadRespiratorio;
    public GameObject resfriado;
    public GameObject sintomas;

    public GameObject pregunta00;
    public GameObject pregunta01;
    public GameObject pregunta02;
    public GameObject pregunta0201;
    public GameObject pregunta03Boca;
    public GameObject pregunta03Axila;
    public GameObject pregunta04;
    public GameObject pregunta05;
    public GameObject pregunta06;
    public GameObject pregunta07;
    public GameObject pregunta08;
    public GameObject pregunta09;
    public GameObject pregunta10;
    public GameObject pregunta11;
    public GameObject pregunta12;
    public GameObject pregunta13;
    public GameObject pregunta14;
    public GameObject resultadosDeTodos;
    public Text text;

    public DataManager data;
    public Text countText;
    private int count;
    public bool pregunta0Si = false;


    public void Start()
    {
        count = 0;
    }
    public void Load()
    {
        SceneManager.LoadScene(sceneName);

    }

    public void PreguntaSi00()
    {
        pregunta00.SetActive(false);
        pregunta01.SetActive(true);
        pregunta0Si = true;
        count = count + 0;
        countText.text = "Count: " + count.ToString();
    }

    public void PreguntaNo00()
    {
        pregunta00.SetActive(false);
        pregunta01.SetActive(true);
        pregunta0Si = false;
        count = count + 0;
        countText.text = "Count: " + count.ToString();

    }

    public void PreguntaSi01()
    {
        pregunta01.SetActive(false);
        pregunta02.SetActive(true);
        countText.text = "Count: " + count.ToString();

    }

    public void PreguntaNo01()
    {
        pregunta01.SetActive(false);
        pregunta04.SetActive(true);
        countText.text = "Count: " + count.ToString();


    }

    public void PreguntaSi02()
    {
        pregunta02.SetActive(false);
        pregunta0201.SetActive(true);
        countText.text = "Count: " + count.ToString();
    }

    public void PreguntaNo02()
    {
        pregunta02.SetActive(false);
        pregunta04.SetActive(true);
        count = count + 2;
        countText.text = "Count: " + count.ToString();

    }

    public void PreguntaSi0201()
    {
        pregunta0201.SetActive(false);
        pregunta03Axila.SetActive(true);
        countText.text = "Count: " + count.ToString();

    }

    public void PreguntaNo0201()
    {
        pregunta0201.SetActive(false);
        pregunta03Boca.SetActive(true);
        countText.text = "Count: " + count.ToString();
    }

    public void Pregunta03boca()
    {
        pregunta03Boca.SetActive(false);
        pregunta04.SetActive(true);
        count = count + 4;
        countText.text = "Count: " + count.ToString();

    }

    public void Pregunta03Axila()
    {
        pregunta03Axila.SetActive(false);
        pregunta04.SetActive(true);
        count = count + 4;
        countText.text = "Count: " + count.ToString();

    }

    public void Pregunta03BocaO()
    {
        pregunta03Boca.SetActive(false);
        pregunta04.SetActive(true);
        count = count + 0;
        countText.text = "Count: " + count.ToString();
    }

    public void Pregunta03AxilaO()
    {
        pregunta03Axila.SetActive(false);
        pregunta04.SetActive(true);
        count = count + 0;
        countText.text = "Count: " + count.ToString();
    }

    public void PreguntaSi04()
    {
        pregunta04.SetActive(false);
        pregunta05.SetActive(true);
        count = count + 1;
        countText.text = "Count: " + count.ToString();
    }

    public void PreguntaNo04()
    {
        pregunta04.SetActive(false);
        pregunta06.SetActive(true);
        countText.text = "Count: " + count.ToString();
    }

    public void PreguntaSi05()
    {
        pregunta05.SetActive(false);
        pregunta06.SetActive(true);
        count = count + 3;
        countText.text = "Count: " + count.ToString();
    }

    public void PreguntaNo05()
    {
        pregunta05.SetActive(false);
        pregunta06.SetActive(true);
        countText.text = "Count: " + count.ToString();

    }

    public void PreguntaSi06()
    {
        pregunta06.SetActive(false);
        pregunta07.SetActive(true);
        count = count + 2;
        countText.text = "Count: " + count.ToString();
    }

    public void PreguntaNo06()
    {
        pregunta06.SetActive(false);
        pregunta07.SetActive(true);
        countText.text = "Count: " + count.ToString();
    }

    public void PreguntaAveces06()
    {
        pregunta06.SetActive(false);
        pregunta07.SetActive(true);
        count = count + 1;
        countText.text = "Count: " + count.ToString();
    }

    public void PreguntaSolo06()
    {
        pregunta06.SetActive(false);
        pregunta07.SetActive(true);
        countText.text = "Count: " + count.ToString();
    }

    public void PreguntaSi07()
    {
        pregunta07.SetActive(false);
        pregunta08.SetActive(true);
        countText.text = "Count: " + count.ToString();
    }

    public void PreguntaNo07()
    {
        pregunta07.SetActive(false);
        pregunta10.SetActive(true);
        countText.text = "Count: " + count.ToString();
    }

    public void Pregunta08Punzante()
    {
        pregunta08.SetActive(false);
        pregunta09.SetActive(true);
        countText.text = "Count: " + count.ToString();
    }

    public void Pregunta08Ardor()
    {
        pregunta08.SetActive(false);
        pregunta10.SetActive(true);
        count = count + 2;
        countText.text = "Count: " + count.ToString();
    }

    public void Pregunta09Pecho()
    {
        pregunta09.SetActive(false);
        pregunta10.SetActive(true);
        count = count + 3;
        countText.text = "Count: " + count.ToString();
    }

    public void Pregunta09brazos()
    {
        pregunta09.SetActive(false);
        pregunta10.SetActive(true);
        count = count + 4;
        countText.text = "Count: " + count.ToString();
    }

    public void Pregunta09espaldas()
    {
        pregunta09.SetActive(false);
        pregunta10.SetActive(true);
        count = count + 3;
        countText.text = "Count: " + count.ToString();
    }

    public void Pregunta09()
    {
        pregunta09.SetActive(false);
        pregunta10.SetActive(true);
        count = count + 5;
        countText.text = "Count: " + count.ToString();
    }

    public void PreguntaSi10()
    {
        pregunta10.SetActive(false);
        pregunta11.SetActive(true);
        countText.text = "Count: " + count.ToString();
    }

    public void PreguntaNo10()
    {
        pregunta10.SetActive(false);
        pregunta11.SetActive(true);
        count = count + 1;
        countText.text = "Count: " + count.ToString();
    }

    public void PreguntaSi11()
    {
        pregunta11.SetActive(false);
        pregunta12.SetActive(true);
        count = count + 2;
        countText.text = "Count: " + count.ToString();
    }

    public void PreguntaNo11()
    {
        pregunta11.SetActive(false);
        pregunta12.SetActive(true);
        countText.text = "Count: " + count.ToString();
    }

    public void PreguntaAveces11()
    {
        pregunta11.SetActive(false);
        pregunta12.SetActive(true);
        count = count + 1;
        countText.text = "Count: " + count.ToString();
    }

    public void PreguntaSolo12()
    {
        pregunta12.SetActive(false);
        pregunta13.SetActive(true);
        count = count + 2;
        countText.text = "Count: " + count.ToString();
    }

    public void PreguntaTodo12()
    {
        pregunta12.SetActive(false);
        pregunta13.SetActive(true);
        count = count + 1;
        countText.text = "Count: " + count.ToString();
    }


    public void PreguntaNo12()
    {
        pregunta12.SetActive(false);
        pregunta13.SetActive(true);
        countText.text = "Count: " + count.ToString();
    }

    public void PreguntaDiarrea13()
    {
        pregunta13.SetActive(false);
        pregunta14.SetActive(true);
        count = count + 1;
        countText.text = "Count: " + count.ToString();
    }

    public void PreguntaNauseas13()
    {
        pregunta13.SetActive(false);
        pregunta14.SetActive(true);
        count = count + 1;
        countText.text = "Count: " + count.ToString();
    }

    public void PreguntaNauseasDiarrea13()
    {
        pregunta13.SetActive(false);
        pregunta14.SetActive(true);
        count = count + 2;
        countText.text = "Count: " + count.ToString();
    }

    public void PreguntaNo13()
    {
        pregunta13.SetActive(false);
        pregunta14.SetActive(true);
        countText.text = "Count: " + count.ToString();
    }

    public void PreguntaSi14()
    {
        pregunta14.SetActive(false);
        count = count + 5;
        countText.text = "Count: " + count.ToString();
        AmigoPositivo();
        UsuarioPositivo();
        Resfriado();
        Sintomas();
    }

    public void PreguntaNo14()
    {
        pregunta14.SetActive(false);
        countText.text = "Count: " + count.ToString();
        AmigoPositivo();
        UsuarioPositivo();
        Resfriado();
        Sintomas();
    }
    public void Resultados()
    {
        sintomas.SetActive(true);
        resfriado.SetActive(false);
        covidAmigo.SetActive(false);
        covidUsuario.SetActive(false);

        data.exexucteTwice();
        switch (data.data.tieneCorona)
        {
            case PlayerData.estado.MUY_PROBABLE_AMIGO:
                text.text = "Positivo";
                break;
            case PlayerData.estado.MUY_PROBALE:
                text.text = "Positivo";
                break;
            case PlayerData.estado.RESFRIADO:
                text.text = "Resfriado";
                break;
            case PlayerData.estado.SINTOMAS:
                text.text = "Sintomas";
                break;
            default:
                break;
        }
        resultadosDeTodos.SetActive(true);
    }
    public void cambiarResultado()
    {
        switch (data.data.tieneCorona)
        {
            case PlayerData.estado.MUY_PROBABLE_AMIGO:
                text.text = "Positivo";
                break;
            case PlayerData.estado.MUY_PROBALE:
                text.text = "Positivo";
                break;
            case PlayerData.estado.RESFRIADO:
                text.text = "Resfriado";
                break;
            case PlayerData.estado.SINTOMAS:
                text.text = "Sintomas";
                break;
            default:
                break;
        }
    }

    void AmigoPositivo()
    {
        //countText.text = "Count: " + count.ToString();
        if (count <= 26 && pregunta0Si == true)
        {
            covidAmigo.SetActive(true);
            data.data = new PlayerData(PlayerData.estado.MUY_PROBABLE_AMIGO);
            data.UpdateCloudData(1);
        }
    }

    void UsuarioPositivo()
    {
        //countText.text = "Count: " + count.ToString();
        if (count <= 27 && pregunta0Si == false)
        {
            covidUsuario.SetActive(true);
            data.data = new PlayerData(PlayerData.estado.MUY_PROBALE);
            data.UpdateCloudData(1);
        }

    }

    void Resfriado()
    {
        //countText.text = "Count: " + count.ToString();
        if (count <= 17)
        {
            resfriado.SetActive(true);
            covidAmigo.SetActive(false);
            covidUsuario.SetActive(false);
            data.data = new PlayerData(PlayerData.estado.RESFRIADO);
            data.UpdateCloudData(1);
        }
    }

    void Sintomas()
    {
        countText.text = "Count: " + count.ToString();
        if (count <= 9)
        {
            sintomas.SetActive(true);
            resfriado.SetActive(false);
            covidAmigo.SetActive(false);
            covidUsuario.SetActive(false);
            data.data = new PlayerData(PlayerData.estado.SINTOMAS);
            data.UpdateCloudData(1);
        }
    }

    public void Restart()
    {
        count = 0;
        pregunta00.SetActive(true);
        countText.text = "Count: " + count.ToString();
        pregunta01.SetActive(false);
        pregunta02.SetActive(false);
        pregunta0201.SetActive(false);
        pregunta03Axila.SetActive(false);
        pregunta03Boca.SetActive(false);
        pregunta04.SetActive(false);
        pregunta05.SetActive(false);
        pregunta06.SetActive(false);
        pregunta07.SetActive(false);
        pregunta08.SetActive(false);
        pregunta09.SetActive(false);
        pregunta10.SetActive(false);
        pregunta11.SetActive(false);
        pregunta12.SetActive(false);
        pregunta13.SetActive(false);
        pregunta14.SetActive(false);
        sintomas.SetActive(false);
        resfriado.SetActive(false);
        covidAmigo.SetActive(false);
        covidUsuario.SetActive(false);

    }

}
