using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Solution
{

    public class OOPExit : Identity
    {
        public GameObject YouWin;
        public string itemToOpen = "Key";
        public int itemAmountToOpen = 2;

        // กำหนดชื่อไอเท็มและจำนวนที่ต้องการใช้ในการเปิดทางออก
        public override bool Hit()
        {
            // ตรวจสอบว่าผู้เล่นมีไอเท็มที่ต้องการหรือไม่
            bool HasItemAmount = mapGenerator.player.inventory.HasItem(itemToOpen, itemAmountToOpen);

            if (HasItemAmount)
            {
                YouWin.SetActive(true);
                Debug.Log("You win");
                return true;
            }
            else
            {
                Debug.Log($"{itemAmountToOpen} amount of {itemToOpen} is needed to open the exit");
                return false;
            }
        }
    }
}