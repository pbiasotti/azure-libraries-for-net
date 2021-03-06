// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Relay.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Relay;
    using Microsoft.Azure.Management.Relay.Fluent;
    using Microsoft.Rest;

    /// <summary>
    /// Exception thrown for an invalid response with ErrorResponse
    /// information.
    /// </summary>
    public class ErrorResponseException : RestException
    {
        /// <summary>
        /// Gets information about the associated HTTP request.
        /// </summary>
        public HttpRequestMessageWrapper Request { get; set; }

        /// <summary>
        /// Gets information about the associated HTTP response.
        /// </summary>
        public HttpResponseMessageWrapper Response { get; set; }

        /// <summary>
        /// Gets or sets the body object.
        /// </summary>
        public ErrorResponse Body { get; set; }

        /// <summary>
        /// Initializes a new instance of the ErrorResponseException class.
        /// </summary>
        public ErrorResponseException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ErrorResponseException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public ErrorResponseException(string message)
            : this(message, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ErrorResponseException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public ErrorResponseException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
