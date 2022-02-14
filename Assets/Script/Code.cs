using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Code : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI EmailDisplay;
    [SerializeField] TextMeshProUGUI ConfirmEmailDisplay;
    [SerializeField] TextMeshProUGUI PasswordDisplay;

    [SerializeField] TMP_InputField EmailField;
    [SerializeField] TMP_InputField ConfirmEmailField;
    [SerializeField] TMP_InputField PasswordField;

    private string email, confirmEmail, password;

    float time = 0f;
    string text;

    // Start is called before the first frame update
    void Start()
    {
        ConfirmEmailField.onValueChanged.AddListener(delegate { ValidateConfirmEmail(); });
        PasswordField.onValueChanged.AddListener(delegate { ValidatePassword(); });
    }

    public void ValidateConfirmEmail()
    {
        if (Time.time - time < 0.01)
        {
            ConfirmEmailField.text = text;
        }
        else
        {
            //text = ConfirmEmailField.text;
            text = "";
        }
        time = Time.time;
    }

    public void ValidatePassword()
    {
        if (Time.time - time < 0.01)
        {
            PasswordField.text = text;
        }
        else
        {
            //text = ConfirmEmailField.text;
            text = "";
        }
        time = Time.time;
    }

    public void UpdateEmail(string email)
    {
        this.email = email;
    }

    public void UpdateConfirmEmail(string email)
    {
        this.confirmEmail = email;
    }

    public void UpdatePassword(string password)
    {
        this.password = password;
    }

    private void Update()
    {

    }

    public void OnSignUp()
    {
        EmailDisplay.text = "Email: " + this.email;
        ConfirmEmailDisplay.text = "Confirm Email: " + this.confirmEmail;
        PasswordDisplay.text = "Password: " + this.password;
    }
}
