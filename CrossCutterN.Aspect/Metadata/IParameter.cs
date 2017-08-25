﻿// <copyright file="IParameter.cs" company="Cui Ziqiang">
// Copyright (c) 2017 Cui Ziqiang
// </copyright>

namespace CrossCutterN.Aspect.Metadata
{
    using System.Collections.Generic;
    using CrossCutterN.Base.Common;

    /// <summary>
    /// Parameter metadata interface.
    /// </summary>
    public interface IParameter : IHasId<string>, IHasSortKey<int>
    {
        /// <summary>
        /// Gets name of the parameter.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets type name of the parameter.
        /// </summary>
        string TypeName { get; }

        /// <summary>
        /// Gets sequence of the parameter in the method.
        /// </summary>
        int Sequence { get; }

        /// <summary>
        /// Gets custom attributes of the method.
        /// </summary>
        IReadOnlyCollection<ICustomAttribute> CustomAttributes { get; }
    }
}
