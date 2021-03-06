/******************************************************************************* 
 *  Copyright 2008 Amazon Technologies, Inc.
 *  Licensed under the Apache License, Version 2.0 (the "License"); 
 *  
 *  You may not use this file except in compliance with the License. 
 *  You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 *  specific language governing permissions and limitations under the License.
 * ***************************************************************************** 
 *    __  _    _  ___ 
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 * 
 *  Amazon EC2 CSharp Library
 *  API Version: 2008-12-01
 *  Generated: Fri Dec 26 23:53:41 PST 2008 
 * 
 */

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text;


namespace Amazon.EC2.Model
{
    [XmlTypeAttribute(Namespace = "http://ec2.amazonaws.com/doc/2008-12-01/")]
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2008-12-01/", IsNullable = false)]
    public class DescribeVolumesResult
    {
    
        private  List<Volume> volumeField;


        /// <summary>
        /// Gets and sets the Volume property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Volume")]
        public List<Volume> Volume
        {
            get
            {
                if (this.volumeField == null)
                {
                    this.volumeField = new List<Volume>();
                }
                return this.volumeField;
            }
            set { this.volumeField =  value; }
        }



        /// <summary>
        /// Sets the Volume property
        /// </summary>
        /// <param name="list">Volume property</param>
        /// <returns>this instance</returns>
        public DescribeVolumesResult WithVolume(params Volume[] list)
        {
            foreach (Volume item in list)
            {
                Volume.Add(item);
            }
            return this;
        }          
 


        /// <summary>
        /// Checks if Volume property is set
        /// </summary>
        /// <returns>true if Volume property is set</returns>
        public Boolean IsSetVolume()
        {
            return (Volume.Count > 0);
        }




        /// <summary>
        /// XML fragment representation of this object
        /// </summary>
        /// <returns>XML fragment for this object.</returns>
        /// <remarks>
        /// Name for outer tag expected to be set by calling method. 
        /// This fragment returns inner properties representation only
        /// </remarks>


        protected internal String ToXMLFragment() {
            StringBuilder xml = new StringBuilder();
            List<Volume> volumeList = this.Volume;
            foreach (Volume volume in volumeList) {
                xml.Append("<Volume>");
                xml.Append(volume.ToXMLFragment());
                xml.Append("</Volume>");
            }
            return xml.ToString();
        }

        /**
         * 
         * Escape XML special characters
         */
        private String EscapeXML(String str) {
            StringBuilder sb = new StringBuilder();
            foreach (Char c in str)
            {
                switch (c) {
                case '&':
                    sb.Append("&amp;");
                    break;
                case '<':
                    sb.Append("&lt;");
                    break;
                case '>':
                    sb.Append("&gt;");
                    break;
                case '\'':
                    sb.Append("&#039;");
                    break;
                case '"':
                    sb.Append("&quot;");
                    break;
                default:
                    sb.Append(c);
                    break;
                }
            }
            return sb.ToString();
        }



    }

}