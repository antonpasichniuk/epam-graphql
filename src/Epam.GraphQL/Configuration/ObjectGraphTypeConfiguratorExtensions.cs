// Copyright © 2020 EPAM Systems, Inc. All Rights Reserved. All information contained herein is, and remains the
// property of EPAM Systems, Inc. and/or its suppliers and is protected by international intellectual
// property law. Dissemination of this information or reproduction of this material is strictly forbidden,
// unless prior written permission is obtained from EPAM Systems, Inc

using System;
using System.Linq;

#nullable enable

namespace Epam.GraphQL.Configuration
{
    internal static class ObjectGraphTypeConfiguratorExtensions
    {
        public static IField<TEntity, TExecutionContext> FindFieldByName<TEntity, TExecutionContext>(this IObjectGraphTypeConfigurator<TEntity, TExecutionContext> configurator, string name)
        {
            return configurator
                .Fields
                .FirstOrDefault(field => field.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
