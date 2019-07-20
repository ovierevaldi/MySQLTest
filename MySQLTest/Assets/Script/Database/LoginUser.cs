using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginUser : MonoBehaviour
{
    string LoginURL = "https://shiplightsstudio.000webhostapp.com/login_user.php";

    public string inputUsername, inputPassword;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            StartCoroutine(LoginToDatabase(inputUsername, inputPassword)); 
        }
    }

    IEnumerator LoginToDatabase(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("usernamePost", username);
        form.AddField("passwordPost", password);

        WWW www = new WWW(LoginURL, form);
        yield return www;

        Debug.Log(www.text);
    }
}
