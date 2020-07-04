using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;
public class AuthManager : MonoBehaviour
{
    public Firebase.Auth.FirebaseAuth auth;
    public Firebase.Auth.FirebaseUser user;
    
    public string emailP;
    public bool toSing;
    public bool toShow;
    public bool signedIn;
    public int UserNumber = 0;

    [SerializeField]
    private GameObject Data;
    [SerializeField]
    private GameObject UIManag;
    [SerializeField]
    private InputField InputFieldEmail = null;
    [SerializeField]
    private InputField InputFieldPassword = null;
    /*[SerializeField]
    private InputField InputFieldUserName = null;

    [SerializeField]
    private GameObject LogInGroup = null;
    [SerializeField]
    private GameObject RegisterGroup = null;*/
    [SerializeField]
    private GameObject GameMenu = null;
    [SerializeField]
    private GameObject FireBaseMenu = null;
    [SerializeField]
    private GameObject ErrorText = null;
    [SerializeField]
    private GameObject puntaje = null;

    [SerializeField]
    private GameObject restart = null;




    // Start is called before the first frame update
    void Start()
    {
        InitializeFirebase();
    }

    // Update is called once per frame


    void InitializeFirebase()
    {
        auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
        auth.StateChanged += AuthStateChanged;
        if (toSing == true) {
            auth.SignOut();
        }
        AuthStateChanged(this, null);
    }

    void AuthStateChanged(object sender, System.EventArgs eventArgs)
    {

        if (auth.CurrentUser != user)
        {
            signedIn = user != auth.CurrentUser && auth.CurrentUser != null;
            if (!signedIn)
            {
                //ShowError();
                Debug.Log("Signed out " + user.UserId);
            }
            if (!signedIn && user != null)
            {
                //ShowError();
                Debug.Log("Signed out " + user.UserId);
            }
            user = auth.CurrentUser;
            if (signedIn)
            {
                //string displayName = InputFieldUserName.text;
                //ErrorText.SetActive(false);
                //user.UserId = displayName;
                //displayName = user.DisplayName ?? "";
                Debug.Log("Signed in " + user.UserId);
                //displayName = InputFieldUserName.text;
                if (toShow == true)
                {
                    ShowGame();

                }
                
                Data.GetComponent<DataManager>().LogedIn();
                
            }
        }
    }

    public void CreateUser() {
        string email = InputFieldEmail.text;
        string password = InputFieldPassword.text;

        // newUser;


        auth.CreateUserWithEmailAndPasswordAsync(email, password).ContinueWith(task => {
            if (task.IsCanceled)
            {
                Debug.LogError("CreateUserWithEmailAndPasswordAsync was canceled.");
                return;
            }
            if (task.IsFaulted)
            {
                //ShowGame();
                Debug.LogError("CreateUserWithEmailAndPasswordAsync encountered an error: " + task.Exception);
                return;
            }

            // Firebase user has been created.
            Firebase.Auth.FirebaseUser newUser = task.Result;
            Debug.LogFormat("Firebase user created successfully: {0} ({1})", newUser.DisplayName, newUser.UserId);


        });

        /*if (task.IsFaulted) {

        }*/

    }

    public void LoginUser() {
        string email = InputFieldEmail.text;
        string password = InputFieldPassword.text;

        Firebase.Auth.FirebaseUser newUser;

        

        auth.SignInWithEmailAndPasswordAsync(email, password).ContinueWith(task => {
            if (task.IsCanceled)
            {
                Debug.LogError("SignInWithEmailAndPasswordAsync was canceled.");
                return;
            }
            if (task.IsFaulted)
            {
                Debug.LogError("SignInWithEmailAndPasswordAsync encountered an error: " + task.Exception);
                return;
            }

            newUser = task.Result;
            Debug.LogFormat("User signed in successfully: {0} ({1})", newUser.DisplayName, newUser.UserId);


        });


        emailP = email;
        AuthStateChanged(this, null);

    }

    /*public void ShowLogInGroup() {
        LogInGroup.SetActive(true);
        RegisterGroup.SetActive(false);
    }

    public void ShowRegisterGroup()
    {
        LogInGroup.SetActive(false);
        RegisterGroup.SetActive(true);
    }*/

    public void ShowGame()
    {
        Data.GetComponent<DataManager>().exexucteTwice();
        UIManag.GetComponent<UiManager>().cambiarResultado();
        GameMenu.SetActive(true);
        FireBaseMenu.SetActive(false);
        puntaje.SetActive(true);
        restart.SetActive(true);
    }

    /*public void ShowError() {
        //ErrorText.SetActive(true);
    }*/

    public Firebase.Auth.FirebaseUser GetUser() {
        return user;
    }


    /*public void Lvl1()
    {
        SceneManager.LoadScene("Lvl1");
        Time.timeScale = 1;
    }*/

}
