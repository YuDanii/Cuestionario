using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
//using Firebase.Path;
using Firebase.Unity.Editor;
using Firebase.Database;
using System.Threading.Tasks;

public class DataManager : MonoBehaviour
{
    public FireBasePathClass Path;

    public PlayerData data;
    [SerializeField]
    private GameObject User;
    [SerializeField]
    private GameObject obj2;
    [SerializeField]
    private bool tiene;
    DatabaseReference reference;

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
        
        data = new PlayerData(false);
    }


    public void CreateData()
    {
        data = new PlayerData(false);
        string name = User.GetComponent<AuthManager>().user.UserId;
        string json = JsonUtility.ToJson(data);
        //reference.Child("Users").SetRawJsonValueAsync(User.GetComponent<AuthManager>().displayName);

        reference.Child("Users").Child(name).Child("Data").SetRawJsonValueAsync(json);
        print("Data Created");


    }

    public void exexucteTwice()
    {
        UpdateGameData();
        UpdateGameData();

    }

    public void UpdateGameData() {
        //data = new PlayerData(false, false, false, User.GetComponent<AuthManager>().emailP);
        string name = User.GetComponent<AuthManager>().user.UserId;
        //var result = JsonUtility.FromJson<PlayerData>(reference.Child("User").Child(name).GetRawJsonValue());
        //data = result;
        Path = new FireBasePathClass();
        Path.ConstrucF(name, "Users");
        

        




        Task.Run(() => {

            var task = Path.GetReferenceFromRoot(reference).GetValueAsync();
            //var task = JsonUtility.FromJson<PlayerData>(reference.Child("Users").Child(name).Child("Data").GetRawJsonValueAsync());
            var result = task.Result;
            //data = new PlayerData(false, false, false, User.GetComponent<AuthManager>().emailP);
            if (result.HasChildren) {
                foreach (var child in result.Children) {
                    levelComp(child);
                    
                }
                
            }
        });

        Actualizese();

        
    }
        
    public void Actualizese(){
        if (tiene == true)
        {
            obj2.SetActive(true);
        }
    }

    public void levelComp(Firebase.Database.DataSnapshot snapShot) {

        var result = JsonUtility.FromJson<PlayerData>(snapShot.GetRawJsonValue());
        
        data = result;

        tiene = data.tieneCorona;
        
        


        //
        

    }

    public void UpdateCloudData(bool tiene)
    {
        //data = new PlayerData(false, false, false, User.GetComponent<AuthManager>().emailP);
        data.tieneCorona = tiene;
        string name = User.GetComponent<AuthManager>().user.UserId;
        string json = JsonUtility.ToJson(data);
        //reference.Child("Users").SetRawJsonValueAsync(User.GetComponent<AuthManager>().displayName);

        reference.Child("Users").Child(name).Child("Data").SetRawJsonValueAsync(json);
        print("Data Updated");


    }


}
