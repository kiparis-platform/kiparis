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

namespace Kiparis.EventBus.Events;

/// <summary>
/// Represents an event that is published to the event bus.
/// </summary>
public record IntegrationEvent
{
    /// <summary>
    /// The unique identifier of the event.
    /// </summary>
    public Guid Id { get; private init; } = Guid.NewGuid();

    /// <summary>
    /// The date and time the event was created.
    /// </summary>
    public DateTime CreationDate { get; private init; } = DateTime.UtcNow;
}
