﻿using System;
using UnityEngine;


namespace ScriptableObjectArchitecture
{
    [Serializable]
    [CreateAssetMenu(
        fileName = "SignedByteGameEvent.asset",
        menuName = SOArchitecture_Utility.ADVANCED_GAME_EVENT + "sbyte",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_EVENTS + 15)]
    public sealed class SByteGameEvent : GameEventBase<sbyte>
    {
    }
}