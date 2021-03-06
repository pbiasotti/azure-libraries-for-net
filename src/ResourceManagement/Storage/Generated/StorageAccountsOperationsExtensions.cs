// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Storage.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Storage;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for StorageAccountsOperations.
    /// </summary>
    public static partial class StorageAccountsOperationsExtensions
    {
            
            /// <summary>
            /// Checks that the storage account name is valid and is not already in use.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CheckNameAvailabilityResultInner> CheckNameAvailabilityAsync(this IStorageAccountsOperations operations, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckNameAvailabilityWithHttpMessagesAsync(name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            
            /// <summary>
            /// Asynchronously creates a new storage account with the specified parameters.
            /// If an account is already created and a subsequent create request is issued
            /// with different properties, the account properties will be updated. If an
            /// account is already created and a subsequent create or update request is
            /// issued with the exact same set of properties, the request will succeed.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='parameters'>
            /// The parameters to provide for the created account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageAccountInner> CreateAsync(this IStorageAccountsOperations operations, string resourceGroupName, string accountName, StorageAccountCreateParametersInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, accountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            
            /// <summary>
            /// Deletes a storage account in Microsoft Azure.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IStorageAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            
            /// <summary>
            /// Returns the properties for the specified storage account including but not
            /// limited to name, SKU name, location, and account status. The ListKeys
            /// operation should be used to retrieve storage keys.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageAccountInner> GetPropertiesAsync(this IStorageAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPropertiesWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            
            /// <summary>
            /// The update operation can be used to update the SKU, encryption, access
            /// tier, or tags for a storage account. It can also be used to map the account
            /// to a custom domain. Only one custom domain is supported per storage
            /// account; the replacement/change of custom domain is not supported. In order
            /// to replace an old custom domain, the old value must be cleared/unregistered
            /// before a new value can be set. The update of multiple properties is
            /// supported. This call does not change the storage keys for the account. If
            /// you want to change the storage account keys, use the regenerate keys
            /// operation. The location and name of the storage account cannot be changed
            /// after creation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='parameters'>
            /// The parameters to provide for the updated account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageAccountInner> UpdateAsync(this IStorageAccountsOperations operations, string resourceGroupName, string accountName, StorageAccountUpdateParametersInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, accountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            
            /// <summary>
            /// Lists all the storage accounts available under the subscription. Note that
            /// storage keys are not returned; use the ListKeys operation for this.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<StorageAccountInner>> ListAsync(this IStorageAccountsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            
            /// <summary>
            /// Lists all the storage accounts available under the given resource group.
            /// Note that storage keys are not returned; use the ListKeys operation for
            /// this.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<StorageAccountInner>> ListByResourceGroupAsync(this IStorageAccountsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            
            /// <summary>
            /// Lists the access keys for the specified storage account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageAccountListKeysResultInner> ListKeysAsync(this IStorageAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            
            /// <summary>
            /// Regenerates one of the access keys for the specified storage account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='keyName'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageAccountListKeysResultInner> RegenerateKeyAsync(this IStorageAccountsOperations operations, string resourceGroupName, string accountName, string keyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateKeyWithHttpMessagesAsync(resourceGroupName, accountName, keyName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            
            /// <summary>
            /// Asynchronously creates a new storage account with the specified parameters.
            /// If an account is already created and a subsequent create request is issued
            /// with different properties, the account properties will be updated. If an
            /// account is already created and a subsequent create or update request is
            /// issued with the exact same set of properties, the request will succeed.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='parameters'>
            /// The parameters to provide for the created account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageAccountInner> BeginCreateAsync(this IStorageAccountsOperations operations, string resourceGroupName, string accountName, StorageAccountCreateParametersInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, accountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
