// Copyright © 2020 EPAM Systems, Inc. All Rights Reserved. All information contained herein is, and remains the
// property of EPAM Systems, Inc. and/or its suppliers and is protected by international intellectual
// property law. Dissemination of this information or reproduction of this material is strictly forbidden,
// unless prior written permission is obtained from EPAM Systems, Inc

#nullable enable

namespace Epam.GraphQL
{
#pragma warning disable CS0618 // Type or member is obsolete
    public interface IExecutionContextAccessor<TExecutionContext> : IUserContextAccessor<TExecutionContext>
#pragma warning restore CS0618 // Type or member is obsolete
    {
        TExecutionContext ExecutionContext { get; }
    }
}
