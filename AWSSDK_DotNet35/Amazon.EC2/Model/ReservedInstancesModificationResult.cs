/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ReservedInstancesModificationResult
    {
        
        private string reservedInstancesId;
        private ReservedInstancesConfiguration targetConfiguration;


        /// <summary>
        /// The ID for the Reserved Instances that were created as part of the modification request. This field is only available when the modification
        /// is fulfilled.
        ///  
        /// </summary>
        public string ReservedInstancesId
        {
            get { return this.reservedInstancesId; }
            set { this.reservedInstancesId = value; }
        }

        // Check to see if ReservedInstancesId property is set
        internal bool IsSetReservedInstancesId()
        {
            return this.reservedInstancesId != null;
        }

        /// <summary>
        /// The target Reserved Instances configurations supplied as part of the modification request.
        ///  
        /// </summary>
        public ReservedInstancesConfiguration TargetConfiguration
        {
            get { return this.targetConfiguration; }
            set { this.targetConfiguration = value; }
        }

        // Check to see if TargetConfiguration property is set
        internal bool IsSetTargetConfiguration()
        {
            return this.targetConfiguration != null;
        }
    }
}
