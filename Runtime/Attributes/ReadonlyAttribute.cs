using System;
using UnityEngine;

namespace Zerobject.Lattributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class ReadonlyAttribute : PropertyAttribute, ILattribute
    {
    }
}