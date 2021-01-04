using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nM_Paper : LifeEntity
{
    public int dropItem;
    private void Start()
    {
        this.HP = 50;
        this.MP = 1;
        this.CurrentHP = HP;
        this.AttackPower = 10;
    }
    public override void Dead()
    {
        base.Dead();
        ItemDrop(dropItem);
    }
}
