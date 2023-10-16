using UnityEngine;

public class Shopowner : INPC
{
    public void Speak(Dialoge dialoge)
    {
        dialoge.Display("Do you wish to purchase anything? Pleease?");
    }
}