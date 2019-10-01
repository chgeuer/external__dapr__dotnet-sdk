// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Actions.Actors.Communication.Client
{
    using System;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    internal class ActorNonRemotingClient
    {                
        private readonly IActionsInteractor actionsInteractor;

        public ActorNonRemotingClient(IActionsInteractor actionsInteractor)
        {
            this.actionsInteractor = actionsInteractor;
        }
        
        /// <summary>
        /// Invokes an Actor method on Actions without remoting.
        /// </summary>
        /// <param name="actorType">Type of actor.</param>
        /// <param name="actorId">ActorId.</param>
        /// <param name="methodName">Method name to invoke.</param>
        /// <param name="jsonPayload">Serialized body.</param>
        /// <param name="cancellationToken">Cancels the operation.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public Task<Stream> InvokeActorMethodWithoutRemotingAsync(string actorType, string actorId, string methodName, string jsonPayload, CancellationToken cancellationToken = default)
        {
            return this.actionsInteractor.InvokeActorMethodWithoutRemotingAsync(actorType, actorId, methodName, jsonPayload, cancellationToken);
        }
    }
}
