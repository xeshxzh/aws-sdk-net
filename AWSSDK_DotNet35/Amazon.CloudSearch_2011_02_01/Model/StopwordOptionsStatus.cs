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

namespace Amazon.CloudSearch_2011_02_01.Model
{
    /// <summary>
    /// <para>The stopword options configured for this search domain and the current status of those options.</para>
    /// </summary>
    public class StopwordOptionsStatus
    {
        
        private string options;
        private OptionStatus status;


        /// <summary>
        /// Lists stopwords serialized as a JSON document. The document has a single object with one property "stopwords" whose value is an array of
        /// strings. The maximum size of a stopwords document is 10 KB. Example: <c>{ "stopwords": ["a", "an", "the", "of"] }</c>
        ///  
        /// </summary>
        public string Options
        {
            get { return this.options; }
            set { this.options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this.options != null;
        }

        /// <summary>
        /// The status of an option, including when it was last updated and whether it is actively in use for searches.
        ///  
        /// </summary>
        public OptionStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }
    }
}
