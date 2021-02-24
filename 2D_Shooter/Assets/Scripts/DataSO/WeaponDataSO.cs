using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Weapons/WeaponData")]
public class WeaponDataSO : ScriptableObject
{
    public int AmmoCapacity { get; internal set; }

    internal int GetBulletCountToSpawn()
    {
        throw new NotImplementedException();
    }
}