using UnityEngine;
using UnityEngine.UI;

public class Dialoge : MonoBehaviour
{
    public Text dialogeText;
    public void Display(string message)
    {
       dialogeText.text += message + '\n';
    }
}