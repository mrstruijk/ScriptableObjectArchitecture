﻿using System;
using UnityEngine;
using UnityEngine.Events;
using Object = UnityEngine.Object;


namespace ScriptableObjectArchitecture
{
    [Serializable]
    public class ObjectEvent : UnityEvent<Object>
    {
    }


    [CreateAssetMenu(
        fileName = "ObjectVariable.asset",
        menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "Object",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 1)]
    public class ObjectVariable : BaseVariable<Object, ObjectEvent>
    {
    }
}