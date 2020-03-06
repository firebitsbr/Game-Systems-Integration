﻿using System;

namespace UnityEngine
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class SearchableEnumAttribute : PropertyAttribute
    { }
}