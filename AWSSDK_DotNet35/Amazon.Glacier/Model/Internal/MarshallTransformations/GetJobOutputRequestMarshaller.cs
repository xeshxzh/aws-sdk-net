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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glacier.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glacier.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Get Job Output Request Marshaller
    /// </summary>       
    internal class GetJobOutputRequestMarshaller : IMarshaller<IRequest, GetJobOutputRequest> 
    {
        

        public IRequest Marshall(GetJobOutputRequest getJobOutputRequest) 
        {

            IRequest request = new DefaultRequest(getJobOutputRequest, "AmazonGlacier");
            string target = "Glacier.GetJobOutput";
            request.Headers["X-Amz-Target"] = target;
            request.HttpMethod = "GET";
            if(getJobOutputRequest.IsSetRange())
                request.Headers.Add("Range", StringUtils.FromString(getJobOutputRequest.Range));

            
            string uriResourcePath = "/{accountId}/vaults/{vaultName}/jobs/{jobId}/output"; 
            if(getJobOutputRequest.IsSetAccountId())
                uriResourcePath = uriResourcePath.Replace("{accountId}", StringUtils.FromString(getJobOutputRequest.AccountId) ); 
            else
                uriResourcePath = uriResourcePath.Replace("{accountId}", "" ); 
            if(getJobOutputRequest.IsSetVaultName())
                uriResourcePath = uriResourcePath.Replace("{vaultName}", StringUtils.FromString(getJobOutputRequest.VaultName) ); 
            else
                uriResourcePath = uriResourcePath.Replace("{vaultName}", "" ); 
            if(getJobOutputRequest.IsSetJobId())
                uriResourcePath = uriResourcePath.Replace("{jobId}", StringUtils.FromString(getJobOutputRequest.JobId) ); 
            else
                uriResourcePath = uriResourcePath.Replace("{jobId}", "" ); 
            request.ResourcePath = uriResourcePath;
            
        
            request.UseQueryString = true;
        

            return request;
        }
    }
}
