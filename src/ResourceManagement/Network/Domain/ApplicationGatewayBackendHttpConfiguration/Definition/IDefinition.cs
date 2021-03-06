// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayBackendHttpConfiguration.Definition
{
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ChildResource.Definition;
    using Microsoft.Azure.Management.Network.Fluent.Models;
    using Microsoft.Azure.Management.Network.Fluent.HasProtocol.Definition;
    using Microsoft.Azure.Management.Network.Fluent.HasPort.Definition;

    /// <summary>
    /// The entirety of an application gateway backend HTTP configuration definition.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the parent application gateway definition to return to after attaching this definition.</typeparam>
    public interface IDefinition<ParentT>  :
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayBackendHttpConfiguration.Definition.IBlank<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayBackendHttpConfiguration.Definition.IWithAttach<ParentT>
    {
    }

    /// <summary>
    /// The stage of an application gateway backend HTTP configuration allowing to enable cookie based affinity.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the parent application gateway definition to return to after attaching this definition.</typeparam>
    public interface IWithAffinity<ParentT> 
    {
        /// <summary>
        /// Enables cookie based affinity.
        /// </summary>
        /// <return>The next stage of the update.</return>
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayBackendHttpConfiguration.Definition.IWithAttach<ParentT> WithCookieBasedAffinity();
    }

    /// <summary>
    /// The stage of an application gateway backend HTTP configuration allowing to associate an existing probe.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the parent application gateway definition to return to after attaching this definition.</typeparam>
    public interface IWithProbe<ParentT>  :
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayBackendHttpConfiguration.Definition.IWithProbeBeta<ParentT>
    {
    }

    /// <summary>
    /// The final stage of an application gateway backend HTTP configuration.
    /// At this stage, any remaining optional settings can be specified, or the definition
    /// can be attached to the parent application gateway definition using  WithAttach.attach().
    /// </summary>
    /// <typeparam name="ParentT">The stage of the parent application gateway definition to return to after attaching this definition.</typeparam>
    public interface IWithAttach<ParentT>  :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.ChildResource.Definition.IInDefinition<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayBackendHttpConfiguration.Definition.IWithPort<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayBackendHttpConfiguration.Definition.IWithAffinity<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayBackendHttpConfiguration.Definition.IWithProtocol<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayBackendHttpConfiguration.Definition.IWithRequestTimeout<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayBackendHttpConfiguration.Definition.IWithProbe<ParentT>
    {
    }

    /// <summary>
    /// The stage of an application gateway backend HTTP configuration allowing to specify the protocol.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the parent application gateway definition to return to after attaching this definition.</typeparam>
    public interface IWithProtocol<ParentT>  :
        Microsoft.Azure.Management.Network.Fluent.HasProtocol.Definition.IWithProtocol<Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayBackendHttpConfiguration.Definition.IWithAttach<ParentT>,Microsoft.Azure.Management.Network.Fluent.Models.ApplicationGatewayProtocol>
    {
    }

    /// <summary>
    /// The first stage of an application gateway backend HTTP configuration.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the parent application gateway definition to return to after attaching this definition.</typeparam>
    public interface IBlank<ParentT>  :
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayBackendHttpConfiguration.Definition.IWithAttach<ParentT>
    {
    }

    /// <summary>
    /// The stage of an application gateway backend HTTP configuration allowing to specify the request timeout.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the parent application gateway definition to return to after attaching this definition.</typeparam>
    public interface IWithRequestTimeout<ParentT> 
    {
        /// <summary>
        /// Specifies the request timeout.
        /// </summary>
        /// <param name="seconds">A number of seconds.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayBackendHttpConfiguration.Definition.IWithAttach<ParentT> WithRequestTimeout(int seconds);
    }

    /// <summary>
    /// The stage of an application gateway backend HTTP configuration allowing to specify the port number.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the parent application gateway definition to return to after attaching this definition.</typeparam>
    public interface IWithPort<ParentT>  :
        Microsoft.Azure.Management.Network.Fluent.HasPort.Definition.IWithPort<Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayBackendHttpConfiguration.Definition.IWithAttach<ParentT>>
    {
    }

    /// <summary>
    /// The stage of an application gateway backend HTTP configuration allowing to associate an existing probe.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the parent application gateway definition to return to after attaching this definition.</typeparam>
    public interface IWithProbeBeta<ParentT>  :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IBeta
    {
        /// <summary>
        /// Specifies an existing probe on this application gateway to associate with this backend.
        /// If the probe with the specified name does not yet exist, it must be defined separately in the optional part
        /// of the application gateway definition. This only adds a reference to the probe by its name.
        /// </summary>
        /// <param name="name">The name of an existing probe.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayBackendHttpConfiguration.Definition.IWithAttach<ParentT> WithProbe(string name);
    }
}