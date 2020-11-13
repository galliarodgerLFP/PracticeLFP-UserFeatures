//WORKS

using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class LoginStuff : MonoBehaviour
{
    public InputField UsernameInput;
    public InputField PasswInput;
    public Button LoginButton;
    public Button RegisterInsteadbtn;

    // Start is called before the first frame update
    void Start()
    {

        LoginButton.onClick.AddListener(() =>
        {
            StartCoroutine(MainStuff.Instance.Web.Login(UsernameInput.text, PasswInput.text));
            //can I add more stuff?
            //StartCoroutine(MainStuff.Instance.Web.GetUsers(UsernameInput.text));
        });

        RegisterInsteadbtn.onClick.AddListener(() =>
        {
            MainStuff.Instance.SetHomeActive();
        });
    }


}