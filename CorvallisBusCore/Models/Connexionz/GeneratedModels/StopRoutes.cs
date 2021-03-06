﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;
using System.Linq;
using System.Collections.Generic;
using API.Models;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.33440.
// 

namespace API.Models
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:connexionz-co-nz")]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "RoutePositionET", Namespace = "urn:connexionz-co-nz", IsNullable = false)]
    public partial class RoutePosition
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Content", typeof(RoutePositionContent))]
        [System.Xml.Serialization.XmlElementAttribute("Platform", typeof(RoutePositionPlatform))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:connexionz-co-nz")]
    public partial class RoutePositionContent
    {

        private System.DateTime expiresField;

        private bool expiresFieldSpecified;

        private int maxArrivalScopeField;

        private bool maxArrivalScopeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime Expires
        {
            get
            {
                return this.expiresField;
            }
            set
            {
                this.expiresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpiresSpecified
        {
            get
            {
                return this.expiresFieldSpecified;
            }
            set
            {
                this.expiresFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int MaxArrivalScope
        {
            get
            {
                return this.maxArrivalScopeField;
            }
            set
            {
                this.maxArrivalScopeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxArrivalScopeSpecified
        {
            get
            {
                return this.maxArrivalScopeFieldSpecified;
            }
            set
            {
                this.maxArrivalScopeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:connexionz-co-nz")]
    public partial class RoutePositionPlatform
    {

        private RoutePositionPlatformRoute[] routeField;

        private string platformTagField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Route")]
        public RoutePositionPlatformRoute[] Route
        {
            get
            {
                return this.routeField;
            }
            set
            {
                this.routeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PlatformTag
        {
            get
            {
                return this.platformTagField;
            }
            set
            {
                this.platformTagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:connexionz-co-nz")]
    public partial class RoutePositionPlatformRoute
    {

        private RoutePositionPlatformRouteDestination destinationField;

        private string routeNoField;

        private bool routeNoFieldSpecified;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Destination")]
        public RoutePositionPlatformRouteDestination Destination
        {
            get
            {
                return this.destinationField;
            }
            set
            {
                this.destinationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RouteNo
        {
            get
            {
                return this.routeNoField;
            }
            set
            {
                this.routeNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RouteNoSpecified
        {
            get
            {
                return this.routeNoFieldSpecified;
            }
            set
            {
                this.routeNoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:connexionz-co-nz")]
    public partial class RoutePositionPlatformRouteDestination
    {

        private RoutePositionPlatformRouteDestinationTrip[] tripField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Trip")]
        public RoutePositionPlatformRouteDestinationTrip[] Trip
        {
            get
            {
                return this.tripField;
            }
            set
            {
                this.tripField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:connexionz-co-nz")]
    public partial class RoutePositionPlatformRouteDestinationTrip
    {

        private int eTAField;

        private bool eTAFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int ETA
        {
            get
            {
                return this.eTAField;
            }
            set
            {
                this.eTAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ETASpecified
        {
            get
            {
                return this.eTAFieldSpecified;
            }
            set
            {
                this.eTAFieldSpecified = value;
            }
        }
    }
}