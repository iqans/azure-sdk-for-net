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
using Microsoft.Azure;
using Microsoft.Azure.Management.RecoveryServices.Backup;
using Microsoft.Azure.Management.RecoveryServices.Backup.Models;

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    public static partial class FileFolderRestoreOperationsExtensions
    {
        /// <summary>
        /// Provisions an iSCSI connection which can be used to download a
        /// script which when run opens the file explorer displaying all
        /// recoverable files and folders. This is an asynchronous operation.
        /// To determine whether the backend service has finished processing
        /// the request, call Get Protected Item Operation Result API.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IFileFolderRestoreOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Common parameters to be used with the file folder restore
        /// APIs.
        /// </param>
        /// <param name='request'>
        /// Optional. File / folder restore request for the backup item.
        /// </param>
        /// <returns>
        /// Base recovery job response for all the asynchronous operations.
        /// </returns>
        public static BaseRecoveryServicesJobResponse Provision(this IFileFolderRestoreOperations operations, FileFolderRestoreParameters parameters, ProvisionILRRequest request)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IFileFolderRestoreOperations)s).ProvisionAsync(parameters, request);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Provisions an iSCSI connection which can be used to download a
        /// script which when run opens the file explorer displaying all
        /// recoverable files and folders. This is an asynchronous operation.
        /// To determine whether the backend service has finished processing
        /// the request, call Get Protected Item Operation Result API.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IFileFolderRestoreOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Common parameters to be used with the file folder restore
        /// APIs.
        /// </param>
        /// <param name='request'>
        /// Optional. File / folder restore request for the backup item.
        /// </param>
        /// <returns>
        /// Base recovery job response for all the asynchronous operations.
        /// </returns>
        public static Task<BaseRecoveryServicesJobResponse> ProvisionAsync(this IFileFolderRestoreOperations operations, FileFolderRestoreParameters parameters, ProvisionILRRequest request)
        {
            return operations.ProvisionAsync(parameters, request, CancellationToken.None);
        }
        
        /// <summary>
        /// Revokes an iSCSI connection which can be used to download a script
        /// which when run opens the file explorer displaying all recoverable
        /// files and folders. This is an asynchronous operation. To determine
        /// whether the backend service has finished processing the request,
        /// call --- API.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IFileFolderRestoreOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Common parameters to be used with the file folder restore
        /// APIs.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Revoke(this IFileFolderRestoreOperations operations, FileFolderRestoreParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IFileFolderRestoreOperations)s).RevokeAsync(parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Revokes an iSCSI connection which can be used to download a script
        /// which when run opens the file explorer displaying all recoverable
        /// files and folders. This is an asynchronous operation. To determine
        /// whether the backend service has finished processing the request,
        /// call --- API.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IFileFolderRestoreOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Common parameters to be used with the file folder restore
        /// APIs.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> RevokeAsync(this IFileFolderRestoreOperations operations, FileFolderRestoreParameters parameters)
        {
            return operations.RevokeAsync(parameters, CancellationToken.None);
        }
    }
}
