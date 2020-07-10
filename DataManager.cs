using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using UnityEngine.UI;
using Firebase.Unity.Editor;
using Firebase.Database;
using System.Threading.Tasks;

public class DataManager : MonoBehaviour
{
    [System.Serializable]
    public class UserbaseSize
    {
        public int size;
    }
    public UserbaseSize userbaseSize;
    public FireBasePathClass Path;
    

    public PlayerData data;
    [SerializeField]
    private GameObject User;
    [SerializeField]
    private Text textToModify;
    public int tiene;
    DatabaseReference reference;
    public UiManager manager;

    // Start is called before the first frame update
    void Start()
    {
        data = new PlayerData();
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://orotest-ebc69.firebaseio.com/");
        reference = FirebaseDatabase.DefaultInstance.RootReference;
        data = new PlayerData();
    }

    public void LogedIn()
    {
        Path = new FireBasePathClass();
        UpdateGameData(false);
        UpdateGameData(false);
        //data = new PlayerData(PlayerData.estado.SINTOMAS);
        //StartCoroutine(waitToChargeData());
    }

    private IEnumerator waitToChargeData()
    {
        yield return new WaitForSeconds(2);
        exexucteTwice();
    }


    public void CreateData()
    {
        Path = new FireBasePathClass();
        //var snapShot = Path.GetReferenceFromRoot(reference).GetValueAsync();
        //userbaseSize = JsonUtility.FromJson<UserbaseSize>(snapShot.Result.Child("UserbaseSize").GetRawJsonValue());
        data = new PlayerData(PlayerData.estado.SINTOMAS);
        string name = User.GetComponent<AuthManager>().user.UserId;

        //string number = userbaseSize.size.ToString();
        //User.GetComponent<AuthManager>().UserNumber = userbaseSize.size;
        
        //userbaseSize.size++;
        
        
        string jsonData = JsonUtility.ToJson(data);
        //string jsonSize = JsonUtility.ToJson(userbaseSize);
        //reference.Child("Users").SetRawJsonValueAsync(User.GetComponent<AuthManager>().displayName);
        //reference.Child("UserbaseSize").SetRawJsonValueAsync(jsonSize);
        reference.Child("Users").Child(name).Child("Data").SetRawJsonValueAsync(jsonData);
        print("Data Created");


    }

    public void exexucteTwice()
    {
        UpdateGameData(true);
        UpdateGameData(true);
    }

    public void UpdateGameData(bool affectGame) {
        //data = new PlayerData(false, false, false, User.GetComponent<AuthManager>().emailP);
        string numeber = User.GetComponent<AuthManager>().user.UserId;
        //var result = JsonUtility.FromJson<PlayerData>(reference.Child("User").Child(name).GetRawJsonValue());
        //data = result;
        Path = new FireBasePathClass();
        Path.ConstrucF(numeber, "Users");
        

        




        Task.Run(() => {

            var task = Path.GetReferenceFromRoot(reference).GetValueAsync();
            //var task = JsonUtility.FromJson<PlayerData>(reference.Child("Users").Child(name).Child("Data").);
            var result = task.Result;
            if (result.HasChildren)
            {
                foreach (var child in result.Children)
                {
                    levelComp(child);
                    
                }

            }
            //data = new PlayerData(false, false, false, User.GetComponent<AuthManager>().emailP);
            
        });
        if (affectGame == true)
        {
            Actualizese();
        }

        
        


    }
        
    public void Actualizese(){
        switch (data.tieneCorona)
        {
            case PlayerData.estado.MUY_PROBABLE_AMIGO:
                textToModify.text = "Amigo Positivo";
                break;
            case PlayerData.estado.MUY_PROBALE:
                textToModify.text = "Positivo";
                break;
            case PlayerData.estado.RESFRIADO:
                textToModify.text = "Resfriado";
                break;
            case PlayerData.estado.SINTOMAS:
                textToModify.text = "Sintomas no relacionados al Covid-19";
                break;
            default:
                break;
        }
        Debug.Log("Game Updated");
    }

    public void levelComp(Firebase.Database.DataSnapshot snapShot) {

        var result = JsonUtility.FromJson<PlayerData>(snapShot.GetRawJsonValue());
        data = result;
        
        
        //Actualizese();






        //


    }

    public void UpdateCloudData(int tiene)
    {
        //data = new PlayerData(false, false, false, User.GetComponent<AuthManager>().emailP);
        //data.tieneCorona = tiene;
        string name = User.GetComponent<AuthManager>().user.UserId;

        string json = JsonUtility.ToJson(data);
        //reference.Child("Users").SetRawJsonValueAsync(User.GetComponent<AuthManager>().displayName);

        reference.Child("Users").Child(name).Child("Data").SetRawJsonValueAsync(json);
        print("Data Updated");


    }


}
