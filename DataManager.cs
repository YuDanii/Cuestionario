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
    private GameObject obj2;
    public int tiene;
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
        Path = new FireBasePathClass();
        data = new PlayerData(PlayerData.estado.SINTOMAS);
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
        UpdateGameData();
        UpdateGameData();

    }

    public void UpdateGameData() {
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


        Actualizese();


    }
        
    public void Actualizese(){
        
    }

    public void levelComp(Firebase.Database.DataSnapshot snapShot) {

        var result = JsonUtility.FromJson<PlayerData>(snapShot.GetRawJsonValue());
        data = result;
        

        
        
        


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
