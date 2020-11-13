using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeStuff : MonoBehaviour
{

    public Button Reg;
    public Button Login;
    // Start is called before the first frame update
    void Start()
    {
        Reg.onClick.AddListener(() =>
        {
            MainStuff.Instance.SetRegisterActive();
        });

        Login.onClick.AddListener(() =>
        {
            MainStuff.Instance.SetLoginActive();
        });
    }

}
