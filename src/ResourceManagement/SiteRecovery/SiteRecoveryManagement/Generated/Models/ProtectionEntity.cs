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
using Microsoft.Azure;
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The definition of a ProtectionEntity object.
    /// </summary>
    public partial class ProtectionEntity : ResourceBaseExtended
    {
        private string _activeLocation;
        
        /// <summary>
        /// Required. Active location of protection entity.
        /// </summary>
        public string ActiveLocation
        {
            get { return this._activeLocation; }
            set { this._activeLocation = value; }
        }
        
        private bool _canCommit;
        
        /// <summary>
        /// Required. Inidicates if commit can be initiated or not
        /// </summary>
        public bool CanCommit
        {
            get { return this._canCommit; }
            set { this._canCommit = value; }
        }
        
        private bool _canFailover;
        
        /// <summary>
        /// Required. Inidicates if failover can be initiated or not
        /// </summary>
        public bool CanFailover
        {
            get { return this._canFailover; }
            set { this._canFailover = value; }
        }
        
        private bool _canReverseReplicate;
        
        /// <summary>
        /// Required. Inidicates if reverse replication can be initiated or not
        /// </summary>
        public bool CanReverseReplicate
        {
            get { return this._canReverseReplicate; }
            set { this._canReverseReplicate = value; }
        }
        
        private string _fabricObjectId;
        
        /// <summary>
        /// Required. Fabric ID of the object
        /// </summary>
        public string FabricObjectId
        {
            get { return this._fabricObjectId; }
            set { this._fabricObjectId = value; }
        }
        
        private string _friendlyName;
        
        /// <summary>
        /// Required. Friendly name
        /// </summary>
        public string FriendlyName
        {
            get { return this._friendlyName; }
            set { this._friendlyName = value; }
        }
        
        private bool _protected;
        
        /// <summary>
        /// Required. True if virtual machine is protected with ASR
        /// </summary>
        public bool Protected
        {
            get { return this._protected; }
            set { this._protected = value; }
        }
        
        private string _protectionContainerId;
        
        /// <summary>
        /// Required. Protection container ID of the object
        /// </summary>
        public string ProtectionContainerId
        {
            get { return this._protectionContainerId; }
            set { this._protectionContainerId = value; }
        }
        
        private ProtectionProfile _protectionProfile;
        
        /// <summary>
        /// Optional. Protection Profile
        /// </summary>
        public ProtectionProfile ProtectionProfile
        {
            get { return this._protectionProfile; }
            set { this._protectionProfile = value; }
        }
        
        private string _protectionStateDescription;
        
        /// <summary>
        /// Required. Protection state description of the protected entity
        /// </summary>
        public string ProtectionStateDescription
        {
            get { return this._protectionStateDescription; }
            set { this._protectionStateDescription = value; }
        }
        
        private string _replicationHealth;
        
        /// <summary>
        /// Required. Gets or sets the consolidated protection health for the
        /// VM taking any issues with SRS as well as all the replication units
        /// associated with the VM's replication group into account. This is a
        /// string representation of the ProtectionHealth enumeration
        /// </summary>
        public string ReplicationHealth
        {
            get { return this._replicationHealth; }
            set { this._replicationHealth = value; }
        }
        
        private string _replicationProvider;
        
        /// <summary>
        /// Required. Name of the Replication Provider used to protect the
        /// virtual machine. Null if not protected
        /// </summary>
        public string ReplicationProvider
        {
            get { return this._replicationProvider; }
            set { this._replicationProvider = value; }
        }
        
        private string _replicationProviderSettings;
        
        /// <summary>
        /// Required. The replication provider settings.
        /// </summary>
        public string ReplicationProviderSettings
        {
            get { return this._replicationProviderSettings; }
            set { this._replicationProviderSettings = value; }
        }
        
        private string _serverId;
        
        /// <summary>
        /// Required. Server ID of the object
        /// </summary>
        public string ServerId
        {
            get { return this._serverId; }
            set { this._serverId = value; }
        }
        
        private string _testFailoverStateDescription;
        
        /// <summary>
        /// Required. Test failover state description.
        /// </summary>
        public string TestFailoverStateDescription
        {
            get { return this._testFailoverStateDescription; }
            set { this._testFailoverStateDescription = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ProtectionEntity class.
        /// </summary>
        public ProtectionEntity()
        {
        }
    }
}
