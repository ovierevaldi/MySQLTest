using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateUser : MonoBehaviour
{
    string CreateURL = "https://shiplightsstudio.000webhostapp.com/create_user.php";

    public string inputUsername, inputEmail, inputPassword;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CreateNewUser(inputUsername, inputEmail, inputPassword);
        }
    }

    IEnumerator CreateNewUser(string username, string email, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("usernamePost", username);
        form.AddField("emailPost", email);
        form.AddField("passwordPost", password);

        WWW www = new WWW(CreateURL, form);
        yield return www;
        Debug.Log(www.text);
    }
}
