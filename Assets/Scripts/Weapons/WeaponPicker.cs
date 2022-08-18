using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPicker : MonoBehaviour
{
    [SerializeField] private GameObject[] weapons;
    private WeaponPickerID weaponPickerID;
    private int weaponID;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == GameTags.Weapon)
        {
            weaponPickerID = other.gameObject.GetComponent<WeaponPickerID>();
            if (weaponPickerID)
            {
                weaponID = weaponPickerID.weaponID;
                ActivateWeapon(weaponID);
            }
        }
    }
    private void ActivateWeapon(int index)
    {
        foreach(GameObject weapon in weapons)
        {
            weapon.SetActive(false);
        }
        weapons[index].SetActive(true);
    }
}
