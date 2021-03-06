﻿using System;
using System.Collections.Generic;
using Intent.Metadata.Models;
using Intent.Modules.Common.Templates;

namespace Intent.Modelers.Domain.Api
{
    //internal class AssociationEnd : IAssociationEnd, IEquatable<AssociationEnd>
    //{
    //    private readonly Metadata.Models.IAssociationEnd _associationEnd;

    //    internal AssociationEnd(
    //        Metadata.Models.IAssociationEnd associationEnd, 
    //        IAssociation association,
    //        IDictionary<string, ClassModel> classCache)
    //    {
    //        _associationEnd = associationEnd;
    //        Association = association;
    //        Class = classCache.ContainsKey(_associationEnd.Element.UniqueKey()) ? classCache[_associationEnd.Element.UniqueKey()] : new ClassModel(_associationEnd.Element, classCache);
    //    }

    //    public IEnumerable<IStereotype> Stereotypes => _associationEnd.Stereotypes;
    //    public string Id => _associationEnd.Element.Id;
    //    public string Name => _associationEnd.Name;
    //    public string SpecializationType => _associationEnd.Element.SpecializationType;
    //    public bool IsNullable => _associationEnd.IsNullable;
    //    public bool IsCollection => _associationEnd.IsCollection;
    //    public IElement Element => _associationEnd.Element;

    //    public IEnumerable<ITypeReference> GenericTypeParameters => _associationEnd.GenericTypeParameters;
    //    public string Comment => _associationEnd.Comment;
    //    public IAssociation Association { get; }
    //    public ClassModel Class { get; }
    //    public bool IsNavigable => _associationEnd.IsNavigable;
    //    public string MinMultiplicity => _associationEnd.IsNullable ? "0" : "1";
    //    public string MaxMultiplicity => _associationEnd.IsCollection ? "*" : "1";

    //    public IAssociationEnd OtherEnd()
    //    {
    //        return Equals(Association.TargetEnd, this) ? Association.SourceEnd : Association.TargetEnd;
    //    }

    //    public override string ToString()
    //    {
    //        return $"{Name} ({Class.Name})";
    //    }

    //    public Multiplicity Multiplicity
    //    {
    //        get
    //        {
    //            if (MinMultiplicity == "0" && MaxMultiplicity == "1")
    //            {
    //                return Multiplicity.ZeroToOne;
    //            }
    //            if (MinMultiplicity == "1" && MaxMultiplicity == "1")
    //            {
    //                return Multiplicity.One;
    //            }
    //            return Multiplicity.Many;
    //        }
    //    }

    //    public static bool operator ==(AssociationEnd lhs, AssociationEnd rhs)
    //    {
    //        // Check for null.
    //        if (Object.ReferenceEquals(lhs, null))
    //        {
    //            if (Object.ReferenceEquals(rhs, null))
    //            {
    //                // null == null = true.
    //                return true;
    //            }

    //            // Only the left side is null.
    //            return false;
    //        }
    //        // Equals handles the case of null on right side.
    //        return lhs.Equals(rhs);
    //    }

    //    public static bool operator !=(AssociationEnd lhs, AssociationEnd rhs)
    //    {
    //        return !(lhs == rhs);
    //    }

    //    public bool Equals(AssociationEnd other)
    //    {
    //        //return string.Equals(Id, other.Element.Id);
    //        return Object.ReferenceEquals(this._associationEnd, other._associationEnd);
    //    }

    //    public override bool Equals(object obj)
    //    {
    //        if (Object.ReferenceEquals(null, obj)) return false;
    //        if (Object.ReferenceEquals(this, obj)) return true;
    //        if (obj.GetType() != this.GetType()) return false;
    //        return Equals((AssociationEnd)obj);
    //    }

    //    public override int GetHashCode()
    //    {
    //        return (Id != null ? Id.GetHashCode() : 0);
    //    }
    //}
}