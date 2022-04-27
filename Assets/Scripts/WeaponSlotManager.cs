using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YS
{
    public class WeaponSlotManager : MonoBehaviour
    {
        WeaponHolderSlot leftHandSlot;
        WeaponHolderSlot rightHandSlot;

        private void Awake(){
            WeaponHolderSlot[] weaponHolderSlots = GetComponentsInChildren<WeaponHolderSlot>();
            foreach(WeaponHolderSlot weaponSlot in weaponHolderSlots){
                if(weaponSlot.isLeftHandSlot){
                    leftHandSlot = weaponSlot;
                }
                else{
                    rightHandSlot = weaponSlot;
                }
            }
        }

        public void LoadWeaponOnSlot(WeaponItem weaponItem, bool isLeft){
            if(isLeft){
                leftHandSlot.LoadWeaponModel(weaponItem);
            }else{
                rightHandSlot.LoadWeaponModel(weaponItem);
            }
        }
    }

}
