/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Appflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Appflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DestinationConnectorProperties Object
    /// </summary>  
    public class DestinationConnectorPropertiesUnmarshaller : IUnmarshaller<DestinationConnectorProperties, XmlUnmarshallerContext>, IUnmarshaller<DestinationConnectorProperties, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DestinationConnectorProperties IUnmarshaller<DestinationConnectorProperties, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DestinationConnectorProperties Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DestinationConnectorProperties unmarshalledObject = new DestinationConnectorProperties();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CustomConnector", targetDepth))
                {
                    var unmarshaller = CustomConnectorDestinationPropertiesUnmarshaller.Instance;
                    unmarshalledObject.CustomConnector = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomerProfiles", targetDepth))
                {
                    var unmarshaller = CustomerProfilesDestinationPropertiesUnmarshaller.Instance;
                    unmarshalledObject.CustomerProfiles = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EventBridge", targetDepth))
                {
                    var unmarshaller = EventBridgeDestinationPropertiesUnmarshaller.Instance;
                    unmarshalledObject.EventBridge = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Honeycode", targetDepth))
                {
                    var unmarshaller = HoneycodeDestinationPropertiesUnmarshaller.Instance;
                    unmarshalledObject.Honeycode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LookoutMetrics", targetDepth))
                {
                    var unmarshaller = LookoutMetricsDestinationPropertiesUnmarshaller.Instance;
                    unmarshalledObject.LookoutMetrics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Redshift", targetDepth))
                {
                    var unmarshaller = RedshiftDestinationPropertiesUnmarshaller.Instance;
                    unmarshalledObject.Redshift = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3", targetDepth))
                {
                    var unmarshaller = S3DestinationPropertiesUnmarshaller.Instance;
                    unmarshalledObject.S3 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Salesforce", targetDepth))
                {
                    var unmarshaller = SalesforceDestinationPropertiesUnmarshaller.Instance;
                    unmarshalledObject.Salesforce = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SAPOData", targetDepth))
                {
                    var unmarshaller = SAPODataDestinationPropertiesUnmarshaller.Instance;
                    unmarshalledObject.SAPOData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Snowflake", targetDepth))
                {
                    var unmarshaller = SnowflakeDestinationPropertiesUnmarshaller.Instance;
                    unmarshalledObject.Snowflake = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Upsolver", targetDepth))
                {
                    var unmarshaller = UpsolverDestinationPropertiesUnmarshaller.Instance;
                    unmarshalledObject.Upsolver = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Zendesk", targetDepth))
                {
                    var unmarshaller = ZendeskDestinationPropertiesUnmarshaller.Instance;
                    unmarshalledObject.Zendesk = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DestinationConnectorPropertiesUnmarshaller _instance = new DestinationConnectorPropertiesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DestinationConnectorPropertiesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}