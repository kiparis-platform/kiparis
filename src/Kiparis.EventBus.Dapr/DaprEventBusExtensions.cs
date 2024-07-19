// SPDX-License-Identifier: BUSL-1.1
//
// Copyright (c) 2024 Parusnik-Belgorod, LLC. All rights reserved.
// Use of this software is govered by the Business Source License included
// in the LICENSE file of this repository and at www.mariadb.com/bsl11.
//
// ANY USE OF THE LICENSED WORK IN VIOLATION OF THIS LICENSE WILL AUTOMATICALLY
// TERMINATE YOUR RIGHTS UNDER THIS LICENSE FOR THE CURRENT AND ALL OTHER
// VERSIONS OF THE LICENSED WORK.
//
// THIS LICENSE DOES NOT GRANT YOU ANY RIGHT IN ANY TRADEMARK OR LOGO OF
// LICENSOR OR ITS AFFILIATES (PROVIDED THAT YOU MAY USE A TRADEMARK OR LOGO OF
// LICENSOR AS EXPRESSLY REQUIRED BY THIS LICENSE).
//
// TO THE EXTENT PERMITTED BY APPLICABLE LAW, THE LICENSED WORK IS PROVIDED ON
// AN “AS IS” BASIS. LICENSOR HEREBY DISCLAIMS ALL WARRANTIES AND CONDITIONS,
// EXPRESS OR IMPLIED, INCLUDING (WITHOUT LIMITATION) WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE, NON-INFRINGEMENT, AND
// TITLE.

using Kiparis.EventBus.Abstractions;
using Kiparis.EventBus.Dapr;
using Microsoft.Extensions.Hosting;

namespace Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Provides extension methods for adding the Dapr event bus to the application.
/// </summary>
public static class DaprEventBusExtensions
{
    /// <summary>
    /// Adds the Dapr event bus to the application.
    /// </summary>
    /// <param name="builder">The host builder.</param>
    /// <returns>The host builder.</returns>
    public static IHostApplicationBuilder AddDaprEventBus(this IHostApplicationBuilder builder)
    {
        builder.Services.AddSingleton<IEventBus, DaprEventBus>();
        
        return builder;
    }
}
