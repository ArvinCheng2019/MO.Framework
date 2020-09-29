﻿using System;
using UnityEngine;

/// <summary>
/// 玩家信息
/// </summary>
public class PlayerData
{
    public Int64 UserId { get; set; }
    public string NickName { get; set; }
    public string HeadIcon { get; set; }
    public GameObject GameObject { get; set; }
    public bool IsLoad { get; set; }
    public float X { get; set; }
    public float Y { get; set; }
}