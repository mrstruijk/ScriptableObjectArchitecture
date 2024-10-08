﻿using System;
using UnityEngine;


namespace ScriptableObjectArchitecture
{
    [Serializable]
    [CreateAssetMenu(
        fileName = "CharGameEvent.asset",
        menuName = SOArchitecture_Utility.ADVANCED_GAME_EVENT + "char",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_EVENTS + 7)]
    public sealed class CharGameEvent : GameEventBase<char>
    {
    }
}