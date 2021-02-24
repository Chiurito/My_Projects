using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Weapons/WeaponData")]
public class WeaponDataSO : ScriptableObject
{
    [field: SerializeField]
    [field: Range(0,100)]
    public int AmmoCapacity { get; set; } = 100;

    [field: SerializeField]
    public bool AutomaticFire { get; set; } = false;

    [field: SerializeField]
    [field: Range(0.1f, 2f)]
    public float WeaponDelay { get; set; } = 0.1f;

    [field: SerializeField]
    [field: Range(0, 10)]
    public float SpreadAngle { get; set; } = 5;

    [SerializeField]
    private bool multiBulletShoot = false;

    [SerializeField]
    [field: Range(1, 10)]
    private int bulletCount = 0;

    internal int GetBulletCountToSpawn()
    {
        if (multiBulletShoot == true)
        {
            return bulletCount;
        }
        return 1;
    }
}
