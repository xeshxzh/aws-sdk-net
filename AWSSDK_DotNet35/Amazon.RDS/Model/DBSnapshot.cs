/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// <para> Contains the result of a successful invocation of the following actions: </para>
    /// <ul>
    /// <li> CreateDBSnapshot </li>
    /// <li> DeleteDBSnapshot </li>
    /// 
    /// </ul>
    /// <para>This data type is used as a response element in the DescribeDBSnapshots action.</para>
    /// </summary>
    public class DBSnapshot
    {
        
        private string dBSnapshotIdentifier;
        private string dBInstanceIdentifier;
        private DateTime? snapshotCreateTime;
        private string engine;
        private int? allocatedStorage;
        private string status;
        private int? port;
        private string availabilityZone;
        private string vpcId;
        private DateTime? instanceCreateTime;
        private string masterUsername;
        private string engineVersion;
        private string licenseModel;
        private string snapshotType;
        private int? iops;
        private string optionGroupName;

        /// <summary>
        /// Specifies the identifier for the DB Snapshot.
        ///  
        /// </summary>
        public string DBSnapshotIdentifier
        {
            get { return this.dBSnapshotIdentifier; }
            set { this.dBSnapshotIdentifier = value; }
        }

        // Check to see if DBSnapshotIdentifier property is set
        internal bool IsSetDBSnapshotIdentifier()
        {
            return this.dBSnapshotIdentifier != null;
        }

        /// <summary>
        /// Specifies the the DBInstanceIdentifier of the DB Instance this DB Snapshot was created from.
        ///  
        /// </summary>
        public string DBInstanceIdentifier
        {
            get { return this.dBInstanceIdentifier; }
            set { this.dBInstanceIdentifier = value; }
        }

        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this.dBInstanceIdentifier != null;
        }

        /// <summary>
        /// Provides the time (UTC) when the snapshot was taken.
        ///  
        /// </summary>
        public DateTime SnapshotCreateTime
        {
            get { return this.snapshotCreateTime ?? default(DateTime); }
            set { this.snapshotCreateTime = value; }
        }

        // Check to see if SnapshotCreateTime property is set
        internal bool IsSetSnapshotCreateTime()
        {
            return this.snapshotCreateTime.HasValue;
        }

        /// <summary>
        /// Specifies the name of the database engine.
        ///  
        /// </summary>
        public string Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this.engine != null;
        }

        /// <summary>
        /// Specifies the allocated storage size in gigabytes (GB).
        ///  
        /// </summary>
        public int AllocatedStorage
        {
            get { return this.allocatedStorage ?? default(int); }
            set { this.allocatedStorage = value; }
        }

        // Check to see if AllocatedStorage property is set
        internal bool IsSetAllocatedStorage()
        {
            return this.allocatedStorage.HasValue;
        }

        /// <summary>
        /// Specifies the status of this DB Snapshot.
        ///  
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// Specifies the port that the database engine was listening on at the time of the snapshot.
        ///  
        /// </summary>
        public int Port
        {
            get { return this.port ?? default(int); }
            set { this.port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this.port.HasValue;
        }

        /// <summary>
        /// Specifies the name of the Availability Zone the DB Instance was located in at the time of the DB Snapshot.
        ///  
        /// </summary>
        public string AvailabilityZone
        {
            get { return this.availabilityZone; }
            set { this.availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;
        }

        /// <summary>
        /// Provides the Vpc Id associated with the DB Snapshot.
        ///  
        /// </summary>
        public string VpcId
        {
            get { return this.vpcId; }
            set { this.vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this.vpcId != null;
        }

        /// <summary>
        /// Specifies the time (UTC) when the snapshot was taken.
        ///  
        /// </summary>
        public DateTime InstanceCreateTime
        {
            get { return this.instanceCreateTime ?? default(DateTime); }
            set { this.instanceCreateTime = value; }
        }

        // Check to see if InstanceCreateTime property is set
        internal bool IsSetInstanceCreateTime()
        {
            return this.instanceCreateTime.HasValue;
        }

        /// <summary>
        /// Provides the master username for the DB Snapshot.
        ///  
        /// </summary>
        public string MasterUsername
        {
            get { return this.masterUsername; }
            set { this.masterUsername = value; }
        }

        // Check to see if MasterUsername property is set
        internal bool IsSetMasterUsername()
        {
            return this.masterUsername != null;
        }

        /// <summary>
        /// Specifies the version of the database engine.
        ///  
        /// </summary>
        public string EngineVersion
        {
            get { return this.engineVersion; }
            set { this.engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this.engineVersion != null;
        }

        /// <summary>
        /// License model information for the restored DB Instance.
        ///  
        /// </summary>
        public string LicenseModel
        {
            get { return this.licenseModel; }
            set { this.licenseModel = value; }
        }

        // Check to see if LicenseModel property is set
        internal bool IsSetLicenseModel()
        {
            return this.licenseModel != null;
        }

        /// <summary>
        /// Provides the type of the DB Snapshot.
        ///  
        /// </summary>
        public string SnapshotType
        {
            get { return this.snapshotType; }
            set { this.snapshotType = value; }
        }

        // Check to see if SnapshotType property is set
        internal bool IsSetSnapshotType()
        {
            return this.snapshotType != null;
        }

        /// <summary>
        /// Specifies the Provisioned IOPS (I/O operations per second) value of the DB Instance at the time of the snapshot.
        ///  
        /// </summary>
        public int Iops
        {
            get { return this.iops ?? default(int); }
            set { this.iops = value; }
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this.iops.HasValue;
        }

        /// <summary>
        /// Provides the option group name for the DB Snapshot.
        ///  
        /// </summary>
        public string OptionGroupName
        {
            get { return this.optionGroupName; }
            set { this.optionGroupName = value; }
        }

        // Check to see if OptionGroupName property is set
        internal bool IsSetOptionGroupName()
        {
            return this.optionGroupName != null;
        }
    }
}