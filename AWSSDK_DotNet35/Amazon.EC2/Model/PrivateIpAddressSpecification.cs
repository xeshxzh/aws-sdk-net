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
    /// <para>Describes a secondary private IP address for a network interface.</para>
    /// </summary>
    public partial class PrivateIpAddressSpecification
    {
        
        private string privateIpAddress;
        private bool? primary;


        /// <summary>
        /// The private IP addresses.
        ///  
        /// </summary>
        public string PrivateIpAddress
        {
            get { return this.privateIpAddress; }
            set { this.privateIpAddress = value; }
        }

        // Check to see if PrivateIpAddress property is set
        internal bool IsSetPrivateIpAddress()
        {
            return this.privateIpAddress != null;
        }

        /// <summary>
        /// Indicates whether the private IP address is the primary private IP address.
        ///  
        /// </summary>
        public bool Primary
        {
            get { return this.primary ?? default(bool); }
            set { this.primary = value; }
        }

        // Check to see if Primary property is set
        internal bool IsSetPrimary()
        {
            return this.primary.HasValue;
        }
    }
}
