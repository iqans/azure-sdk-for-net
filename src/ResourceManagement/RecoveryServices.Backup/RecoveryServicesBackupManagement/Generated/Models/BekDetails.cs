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

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    /// <summary>
    /// BEK is bitlocker encrpytion key.
    /// </summary>
    public partial class BekDetails
    {
        private string _secretData;
        
        /// <summary>
        /// Optional. BEK data
        /// </summary>
        public string SecretData
        {
            get { return this._secretData; }
            set { this._secretData = value; }
        }
        
        private string _secretUrl;
        
        /// <summary>
        /// Optional. Secret is BEK
        /// </summary>
        public string SecretUrl
        {
            get { return this._secretUrl; }
            set { this._secretUrl = value; }
        }
        
        private string _secretVaultId;
        
        /// <summary>
        /// Optional. ID of the Key Vault where this Secret is stored
        /// </summary>
        public string SecretVaultId
        {
            get { return this._secretVaultId; }
            set { this._secretVaultId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the BekDetails class.
        /// </summary>
        public BekDetails()
        {
        }
    }
}
