﻿using System.Collections;
using System.Reflection;
using UnityEngine;
using Type = System.Type;


public static class BaseReferenceHelper
{
    private const BindingFlags NonPublicBindingsFlag = BindingFlags.Instance | BindingFlags.NonPublic;
    private const string ConstantValueName = "_constantValue";


    public static Type GetReferenceType(FieldInfo fieldInfo)
    {
        return fieldInfo.FieldType;
    }


    public static Type GetValueType(FieldInfo fieldInfo)
    {
        var referenceType = GetReferenceType(fieldInfo);

        if (referenceType.IsArray)
        {
            referenceType = referenceType.GetElementType();
        }
        else if (IsList(referenceType))
        {
            Debug.Log("Is list!");
            referenceType = referenceType.GetGenericArguments()[0];
        }

        var constantValueField = referenceType.GetField(ConstantValueName, NonPublicBindingsFlag);

        return constantValueField.FieldType;
    }


    private static bool IsList(Type referenceType)
    {
        return typeof(IList).IsAssignableFrom(referenceType);
    }
}