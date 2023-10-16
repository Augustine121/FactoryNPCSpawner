using UnityEngine;

public class Beggar : INPC
{
    public void Speak(Dialoge dialoge)
    {
        dialoge.Display("Spare some change?");
    }
}