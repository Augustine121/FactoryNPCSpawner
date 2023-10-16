using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public NPCFactory myFactory;
    public Dialoge dialoge;
    private INPC myFarmer;
    private INPC myBeggar;
    private INPC myShopowner;

    public void SpawnVillagers()
    {
        myBeggar = myFactory.GetNPC(NPCType.Beggar);
        myFarmer = myFactory.GetNPC(NPCType.Farmer);
        myShopowner = myFactory.GetNPC(NPCType.Shopowner);

        myBeggar.Speak(dialoge);
        myFarmer.Speak(dialoge);
        myShopowner.Speak(dialoge);
    }
}