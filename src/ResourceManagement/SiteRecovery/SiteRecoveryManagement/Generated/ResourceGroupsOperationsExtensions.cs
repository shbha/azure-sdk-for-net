// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.RecoveryServices;
using Microsoft.Azure.Management.RecoveryServices.Models;

namespace Microsoft.Azure.Management.RecoveryServices
{
    public static partial class ResourceGroupsOperationsExtensions
    {
        /// <summary>
        /// Retrieve a list of Resource Groups
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.IResourceGroupsOperations.
        /// </param>
        /// <returns>
        /// The response model for the list resource group operation.
        /// </returns>
        public static ResourceGroupListResponse List(this IResourceGroupsOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IResourceGroupsOperations)s).ListAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve a list of Resource Groups
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.IResourceGroupsOperations.
        /// </param>
        /// <returns>
        /// The response model for the list resource group operation.
        /// </returns>
        public static Task<ResourceGroupListResponse> ListAsync(this IResourceGroupsOperations operations)
        {
            return operations.ListAsync(CancellationToken.None);
        }
    }
}
