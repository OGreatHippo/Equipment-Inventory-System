using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempInputSystem : MonoBehaviour
{
    public GameObject Inventory;

    public bool isOpen = false;

    // Update is called once per frame
    void Update()
    {
        OpenInventory();
    }

    private void OpenInventory()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            isOpen = !isOpen;

            Inventory.SetActive(isOpen);
        }
    }
}
