using UnityEngine;

public class Farmer : INPC
{
    public void Speak(Dialoge dialoge)
    {
        dialoge.Display("You reap what you sow!");
    }
}