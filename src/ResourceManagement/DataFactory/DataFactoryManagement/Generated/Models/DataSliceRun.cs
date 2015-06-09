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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.DataFactories.Models;

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// A data slice run is unit of processing for a data slice.
    /// </summary>
    public partial class DataSliceRun
    {
        private IDictionary<string, string> _activityInputProperties;
        
        /// <summary>
        /// Optional. Container for all the input properties for the Activity
        /// </summary>
        public IDictionary<string, string> ActivityInputProperties
        {
            get { return this._activityInputProperties; }
            set { this._activityInputProperties = value; }
        }
        
        private string _activityName;
        
        /// <summary>
        /// Optional. Run activity name.
        /// </summary>
        public string ActivityName
        {
            get { return this._activityName; }
            set { this._activityName = value; }
        }
        
        private DateTime _batchTime;
        
        /// <summary>
        /// Optional. Start time for corresponding data slice.
        /// </summary>
        public DateTime BatchTime
        {
            get { return this._batchTime; }
            set { this._batchTime = value; }
        }
        
        private string _computeClusterName;
        
        /// <summary>
        /// Optional. The HDInsight cluster where the run was processed.
        /// </summary>
        public string ComputeClusterName
        {
            get { return this._computeClusterName; }
            set { this._computeClusterName = value; }
        }
        
        private DateTime _dataSliceEnd;
        
        /// <summary>
        /// Optional. End time for corresponding data slice.
        /// </summary>
        public DateTime DataSliceEnd
        {
            get { return this._dataSliceEnd; }
            set { this._dataSliceEnd = value; }
        }
        
        private DateTime _dataSliceStart;
        
        /// <summary>
        /// Optional. Start time for corresponding data slice.
        /// </summary>
        public DateTime DataSliceStart
        {
            get { return this._dataSliceStart; }
            set { this._dataSliceStart = value; }
        }
        
        private string _errorMessage;
        
        /// <summary>
        /// Optional. Error message retuned if failed.
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }
        
        private bool _hasLogs;
        
        /// <summary>
        /// Optional. Has compute logs.
        /// </summary>
        public bool HasLogs
        {
            get { return this._hasLogs; }
            set { this._hasLogs = value; }
        }
        
        private string _id;
        
        /// <summary>
        /// Optional. Run id.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private IList<RunRecordReference> _inputRunRecordReferences;
        
        /// <summary>
        /// Optional. The list of data slice runs that were input to this data
        /// slice run.
        /// </summary>
        public IList<RunRecordReference> InputRunRecordReferences
        {
            get { return this._inputRunRecordReferences; }
            set { this._inputRunRecordReferences = value; }
        }
        
        private string _logUri;
        
        /// <summary>
        /// Optional. Url to the Log files
        /// </summary>
        public string LogUri
        {
            get { return this._logUri; }
            set { this._logUri = value; }
        }
        
        private IList<RunRecordReference> _outputRunRecordReferences;
        
        /// <summary>
        /// Optional. The list of data slice runs that used this data slice run
        /// as input.
        /// </summary>
        public IList<RunRecordReference> OutputRunRecordReferences
        {
            get { return this._outputRunRecordReferences; }
            set { this._outputRunRecordReferences = value; }
        }
        
        private int _percentComplete;
        
        /// <summary>
        /// Optional. Run execution progress as a percentage value.
        /// </summary>
        public int PercentComplete
        {
            get { return this._percentComplete; }
            set { this._percentComplete = value; }
        }
        
        private string _pipelineName;
        
        /// <summary>
        /// Optional. Run pipeline name.
        /// </summary>
        public string PipelineName
        {
            get { return this._pipelineName; }
            set { this._pipelineName = value; }
        }
        
        private DateTime _processingEndTime;
        
        /// <summary>
        /// Optional. Time when run finished execution.
        /// </summary>
        public DateTime ProcessingEndTime
        {
            get { return this._processingEndTime; }
            set { this._processingEndTime = value; }
        }
        
        private DateTime _processingStartTime;
        
        /// <summary>
        /// Optional. Time when run began execution.
        /// </summary>
        public DateTime ProcessingStartTime
        {
            get { return this._processingStartTime; }
            set { this._processingStartTime = value; }
        }
        
        private IDictionary<string, string> _properties;
        
        /// <summary>
        /// Optional. Container for all the properties/associated generated by
        /// the Activity for a run and can be consumed by the same Activity or
        /// others.
        /// </summary>
        public IDictionary<string, string> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        private int _retryAttempt;
        
        /// <summary>
        /// Optional. Retry attempt number for run.
        /// </summary>
        public int RetryAttempt
        {
            get { return this._retryAttempt; }
            set { this._retryAttempt = value; }
        }
        
        private string _status;
        
        /// <summary>
        /// Optional. Run status.
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        private string _tableName;
        
        /// <summary>
        /// Optional. Run table name.
        /// </summary>
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }
        
        private DateTime _timestamp;
        
        /// <summary>
        /// Optional. Time when run was created.
        /// </summary>
        public DateTime Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Optional. Run record type.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DataSliceRun class.
        /// </summary>
        public DataSliceRun()
        {
            this.ActivityInputProperties = new LazyDictionary<string, string>();
            this.InputRunRecordReferences = new LazyList<RunRecordReference>();
            this.OutputRunRecordReferences = new LazyList<RunRecordReference>();
            this.Properties = new LazyDictionary<string, string>();
        }
    }
}
