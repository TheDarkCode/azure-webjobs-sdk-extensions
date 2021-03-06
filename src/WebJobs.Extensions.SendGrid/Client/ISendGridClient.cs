﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Threading.Tasks;

namespace Microsoft.Azure.WebJobs.Extensions.Client
{
    internal interface ISendGridClient
    {
        Task SendMessageAsync(string mailJson);
    }
}
