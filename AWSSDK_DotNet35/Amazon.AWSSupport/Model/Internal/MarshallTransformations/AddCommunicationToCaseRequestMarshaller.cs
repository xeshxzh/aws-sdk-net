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

using Amazon.AWSSupport.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AWSSupport.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AddCommunicationToCase Request Marshaller
    /// </summary>       
    public class AddCommunicationToCaseRequestMarshaller : IMarshaller<IRequest, AddCommunicationToCaseRequest> 
    {
        public IRequest Marshall(AddCommunicationToCaseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AWSSupport");
            string target = "AWSSupport_20130415.AddCommunicationToCase";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                if(publicRequest.IsSetAttachmentSetId())
                {
                    writer.WritePropertyName("attachmentSetId");
                    writer.Write(publicRequest.AttachmentSetId);
                }

                if(publicRequest.IsSetCaseId())
                {
                    writer.WritePropertyName("caseId");
                    writer.Write(publicRequest.CaseId);
                }

                if(publicRequest.IsSetCcEmailAddresses())
                {
                    writer.WritePropertyName("ccEmailAddresses");
                    writer.WriteArrayStart();
                    foreach(var publicRequestCcEmailAddressesListValue in publicRequest.CcEmailAddresses)
                    {
                        writer.Write(publicRequestCcEmailAddressesListValue);
                    }
                    writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetCommunicationBody())
                {
                    writer.WritePropertyName("communicationBody");
                    writer.Write(publicRequest.CommunicationBody);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}