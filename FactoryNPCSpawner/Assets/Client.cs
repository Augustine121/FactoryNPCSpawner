using UnityEngine;

public class Client : MonoBehaviour
{
    public NPCSpawner mySpawnerNPC;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            mySpawnerNPC.SpawnVillagers();
        }
    }
}