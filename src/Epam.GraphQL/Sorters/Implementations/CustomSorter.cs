// Copyright © 2020 EPAM Systems, Inc. All Rights Reserved. All information contained herein is, and remains the
// property of EPAM Systems, Inc. and/or its suppliers and is protected by international intellectual
// property law. Dissemination of this information or reproduction of this material is strictly forbidden,
// unless prior written permission is obtained from EPAM Systems, Inc

using System;
using System.Linq.Expressions;
using Epam.GraphQL.Diagnostics;
using GraphQL;

namespace Epam.GraphQL.Sorters.Implementations
{
    internal class CustomSorter<TEntity, TValueType, TExecutionContext> : ISorter<TExecutionContext>
    {
        private readonly Func<TExecutionContext, Expression<Func<TEntity, TValueType>>> _selectorFactory;

        public CustomSorter(MethodCallConfigurationContext configurationContext, string name, Expression<Func<TEntity, TValueType>> selector)
            : this(configurationContext, name, _ => selector)
        {
        }

        public CustomSorter(MethodCallConfigurationContext configurationContext, string name, Func<TExecutionContext, Expression<Func<TEntity, TValueType>>> selectorFactory)
        {
            ConfigurationContext = configurationContext;
            Name = name.ToCamelCase();
            _selectorFactory = selectorFactory;
        }

        public MethodCallConfigurationContext ConfigurationContext { get; }

        public string Name { get; }

        public bool IsGroupable => false;

        public LambdaExpression BuildExpression(TExecutionContext context) => _selectorFactory(context);
    }
}
