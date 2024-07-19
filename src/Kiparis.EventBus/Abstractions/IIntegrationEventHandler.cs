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

using Kiparis.EventBus.Events;

namespace Kiparis.EventBus.Abstractions;

/// <summary>
/// Provides an interface for handling integration events of a specified type.
/// </summary>
/// <typeparam name="TIntegrationEvent">The type of integration event to handle.</typeparam>
public interface IIntegrationEventHandler<in TIntegrationEvent> : IIntegrationEventHandler
    where TIntegrationEvent : IntegrationEvent
{
    /// <summary>
    /// Handles the specified integration event.
    /// </summary>
    /// <param name="event">The integration event.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task Handle(TIntegrationEvent @event, CancellationToken cancellationToken);

    /// <inheritdoc />
    Task IIntegrationEventHandler.Handle(IntegrationEvent @event, CancellationToken cancellationToken) => Handle((TIntegrationEvent)@event, cancellationToken);
}

/// <summary>
/// Provides an interface for handling integration events.
/// </summary>
public interface IIntegrationEventHandler
{
    /// <summary>
    /// Handles the specified integration event.
    /// </summary>
    /// <param name="event">The integration event.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task Handle(IntegrationEvent @event, CancellationToken cancellationToken);
}
