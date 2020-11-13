using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegisterStuff : MonoBehaviour
{
    public InputField UsernameInput;
    public InputField PasswInput;
    public InputField extraField1;
    public Button RegButton;
    public Button LoginInsteadBtn;

    // Start is called before the first frame update
    void Start()
    {
        RegButton.onClick.AddListener(() =>
        {
            StartCoroutine(MainStuff.Instance.Web.RegisterUser(UsernameInput.text, PasswInput.text, extraField1.text));
        });

        LoginInsteadBtn.onClick.AddListener(() =>
        {
            MainStuff.Instance.SetHomeActive();
        });
    }
}
