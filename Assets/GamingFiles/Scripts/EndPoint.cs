using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour
{
    public MidMenuScript victoryMenu;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.transform.tag == "Player")
        {
            EthanScript myPlayerScript = collider.GetComponent<EthanScript>();
            victoryMenu.ToggleEndMenu(GameStatusScript.score);
            GameStatusScript.InitializeStats();
            Destroy(collider.gameObject);
        }
    }
}
