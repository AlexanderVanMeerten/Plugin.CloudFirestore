﻿using System;
namespace Plugin.CloudFirestore.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class IgnoredAttribute : Attribute
    {
    }
}
