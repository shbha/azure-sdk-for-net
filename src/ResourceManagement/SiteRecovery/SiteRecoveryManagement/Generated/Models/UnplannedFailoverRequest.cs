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
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The Unplanned failover request object.
    /// </summary>
    public partial class UnplannedFailoverRequest : FailoverRequest
    {
        private bool _sourceSiteOperations;
        
        /// <summary>
        /// Required. Value indicating whether source site operations are
        /// requested by the user.
        /// </summary>
        public bool SourceSiteOperations
        {
            get { return this._sourceSiteOperations; }
            set { this._sourceSiteOperations = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the UnplannedFailoverRequest class.
        /// </summary>
        public UnplannedFailoverRequest()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the UnplannedFailoverRequest class
        /// with required arguments.
        /// </summary>
        public UnplannedFailoverRequest(bool sourceSiteOperations)
            : this()
        {
            this.SourceSiteOperations = sourceSiteOperations;
        }
    }
}
