//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by the BlueToque XsdCodeGenerator tool.
//     Tool Version:    2.19.418.0
//     Runtime Version: 4.0.30319.42000
//     Generated on:    2021-02-16 22:40:54
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated. For more information see http://BlueToque.ca
// </autogenerated>
//------------------------------------------------------------------------------

//	http://BlueToque.ca
// Workaround for bug http://lab.msdn.microsoft.com/productfeedback/viewfeedback.aspx?feedbackid=d457a36e-0ce8-4368-9a27-92762860d8e1
#pragma warning disable 1591
namespace SharpGPX.GPX1_1.Garmin {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.garmin.com/xmlschemas/GpxExtensions/v3")]
    [System.Xml.Serialization.XmlRootAttribute("WaypointExtension", Namespace="http://www.garmin.com/xmlschemas/GpxExtensions/v3", IsNullable=false)]
    public partial class WaypointExtension_t : System.ComponentModel.INotifyPropertyChanged {
        
        /// <summary />
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        /// <summary />
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
        
        /// <summary />
        private double proximityField;
        
        /// <remarks/>
        public double Proximity {
            get {
                return this.proximityField;
            }
            set {
                this.proximityField = value;
                this.RaisePropertyChanged("Proximity");
            }
        }
        
        /// <summary />
        private bool proximityFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProximitySpecified {
            get {
                return this.proximityFieldSpecified;
            }
            set {
                this.proximityFieldSpecified = value;
                this.RaisePropertyChanged("ProximitySpecified");
            }
        }
        
        /// <summary />
        private double temperatureField;
        
        /// <remarks/>
        public double Temperature {
            get {
                return this.temperatureField;
            }
            set {
                this.temperatureField = value;
                this.RaisePropertyChanged("Temperature");
            }
        }
        
        /// <summary />
        private bool temperatureFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TemperatureSpecified {
            get {
                return this.temperatureFieldSpecified;
            }
            set {
                this.temperatureFieldSpecified = value;
                this.RaisePropertyChanged("TemperatureSpecified");
            }
        }
        
        /// <summary />
        private double depthField;
        
        /// <remarks/>
        public double Depth {
            get {
                return this.depthField;
            }
            set {
                this.depthField = value;
                this.RaisePropertyChanged("Depth");
            }
        }
        
        /// <summary />
        private bool depthFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DepthSpecified {
            get {
                return this.depthFieldSpecified;
            }
            set {
                this.depthFieldSpecified = value;
                this.RaisePropertyChanged("DepthSpecified");
            }
        }
        
        /// <summary />
        private DisplayMode_t displayModeField;
        
        /// <remarks/>
        public DisplayMode_t DisplayMode {
            get {
                return this.displayModeField;
            }
            set {
                this.displayModeField = value;
                this.RaisePropertyChanged("DisplayMode");
            }
        }
        
        /// <summary />
        private bool displayModeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisplayModeSpecified {
            get {
                return this.displayModeFieldSpecified;
            }
            set {
                this.displayModeFieldSpecified = value;
                this.RaisePropertyChanged("DisplayModeSpecified");
            }
        }
        
        /// <summary />
        private string[] categoriesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Category", IsNullable=false)]
        public string[] Categories {
            get {
                return this.categoriesField;
            }
            set {
                this.categoriesField = value;
                this.RaisePropertyChanged("Categories");
            }
        }
        
        /// <summary />
        private Address_t addressField;
        
        /// <remarks/>
        public Address_t Address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
                this.RaisePropertyChanged("Address");
            }
        }
        
        /// <summary />
        private PhoneNumber_tCollection phoneNumberField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhoneNumber")]
        public PhoneNumber_tCollection PhoneNumber {
            get {
                return this.phoneNumberField;
            }
            set {
                this.phoneNumberField = value;
                this.RaisePropertyChanged("PhoneNumber");
            }
        }
        
        /// <summary />
        private Extensions_t extensionsField;
        
        /// <remarks/>
        public Extensions_t Extensions {
            get {
                return this.extensionsField;
            }
            set {
                this.extensionsField = value;
                this.RaisePropertyChanged("Extensions");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.garmin.com/xmlschemas/GpxExtensions/v3")]
    public enum DisplayMode_t {
        
        /// <remarks/>
        SymbolOnly,
        
        /// <remarks/>
        SymbolAndName,
        
        /// <remarks/>
        SymbolAndDescription,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.garmin.com/xmlschemas/GpxExtensions/v3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.garmin.com/xmlschemas/GpxExtensions/v3", IsNullable=true)]
    public partial class Address_t : System.ComponentModel.INotifyPropertyChanged {
        
        /// <summary />
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        /// <summary />
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
        
        /// <summary />
        private string[] streetAddressField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StreetAddress", DataType="token")]
        public string[] StreetAddress {
            get {
                return this.streetAddressField;
            }
            set {
                this.streetAddressField = value;
                this.RaisePropertyChanged("StreetAddress");
            }
        }
        
        /// <summary />
        private string cityField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string City {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
                this.RaisePropertyChanged("City");
            }
        }
        
        /// <summary />
        private string stateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string State {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
                this.RaisePropertyChanged("State");
            }
        }
        
        /// <summary />
        private string countryField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string Country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
                this.RaisePropertyChanged("Country");
            }
        }
        
        /// <summary />
        private string postalCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string PostalCode {
            get {
                return this.postalCodeField;
            }
            set {
                this.postalCodeField = value;
                this.RaisePropertyChanged("PostalCode");
            }
        }
        
        /// <summary />
        private Extensions_t extensionsField;
        
        /// <remarks/>
        public Extensions_t Extensions {
            get {
                return this.extensionsField;
            }
            set {
                this.extensionsField = value;
                this.RaisePropertyChanged("Extensions");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.garmin.com/xmlschemas/GpxExtensions/v3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.garmin.com/xmlschemas/GpxExtensions/v3", IsNullable=true)]
    public partial class Extensions_t : System.ComponentModel.INotifyPropertyChanged {
        
        /// <summary />
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        /// <summary />
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
        
        /// <summary />
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
                this.RaisePropertyChanged("Any");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.garmin.com/xmlschemas/GpxExtensions/v3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.garmin.com/xmlschemas/GpxExtensions/v3", IsNullable=true)]
    public partial class PhoneNumber_t : System.ComponentModel.INotifyPropertyChanged {
        
        /// <summary />
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        /// <summary />
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
        
        /// <summary />
        private string categoryField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string Category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
                this.RaisePropertyChanged("Category");
            }
        }
        
        /// <summary />
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType="token")]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.garmin.com/xmlschemas/GpxExtensions/v3")]
    [System.Xml.Serialization.XmlRootAttribute("RouteExtension", Namespace="http://www.garmin.com/xmlschemas/GpxExtensions/v3", IsNullable=false)]
    public partial class RouteExtension_t : System.ComponentModel.INotifyPropertyChanged {
        
        /// <summary />
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        /// <summary />
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
        
        /// <summary />
        private bool isAutoNamedField;
        
        /// <remarks/>
        public bool IsAutoNamed {
            get {
                return this.isAutoNamedField;
            }
            set {
                this.isAutoNamedField = value;
                this.RaisePropertyChanged("IsAutoNamed");
            }
        }
        
        /// <summary />
        private DisplayColor_t displayColorField;
        
        /// <remarks/>
        public DisplayColor_t DisplayColor {
            get {
                return this.displayColorField;
            }
            set {
                this.displayColorField = value;
                this.RaisePropertyChanged("DisplayColor");
            }
        }
        
        /// <summary />
        private bool displayColorFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisplayColorSpecified {
            get {
                return this.displayColorFieldSpecified;
            }
            set {
                this.displayColorFieldSpecified = value;
                this.RaisePropertyChanged("DisplayColorSpecified");
            }
        }
        
        /// <summary />
        private Extensions_t extensionsField;
        
        /// <remarks/>
        public Extensions_t Extensions {
            get {
                return this.extensionsField;
            }
            set {
                this.extensionsField = value;
                this.RaisePropertyChanged("Extensions");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.garmin.com/xmlschemas/GpxExtensions/v3")]
    public enum DisplayColor_t {
        
        /// <remarks/>
        Black,
        
        /// <remarks/>
        DarkRed,
        
        /// <remarks/>
        DarkGreen,
        
        /// <remarks/>
        DarkYellow,
        
        /// <remarks/>
        DarkBlue,
        
        /// <remarks/>
        DarkMagenta,
        
        /// <remarks/>
        DarkCyan,
        
        /// <remarks/>
        LightGray,
        
        /// <remarks/>
        DarkGray,
        
        /// <remarks/>
        Red,
        
        /// <remarks/>
        Green,
        
        /// <remarks/>
        Yellow,
        
        /// <remarks/>
        Blue,
        
        /// <remarks/>
        Magenta,
        
        /// <remarks/>
        Cyan,
        
        /// <remarks/>
        White,
        
        /// <remarks/>
        Transparent,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.garmin.com/xmlschemas/GpxExtensions/v3")]
    [System.Xml.Serialization.XmlRootAttribute("RoutePointExtension", Namespace="http://www.garmin.com/xmlschemas/GpxExtensions/v3", IsNullable=false)]
    public partial class RoutePointExtension_t : System.ComponentModel.INotifyPropertyChanged {
        
        /// <summary />
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        /// <summary />
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
        
        /// <summary />
        private byte[] subclassField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="hexBinary")]
        public byte[] Subclass {
            get {
                return this.subclassField;
            }
            set {
                this.subclassField = value;
                this.RaisePropertyChanged("Subclass");
            }
        }
        
        /// <summary />
        private AutoroutePoint_tCollection rptField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rpt")]
        public AutoroutePoint_tCollection rpt {
            get {
                return this.rptField;
            }
            set {
                this.rptField = value;
                this.RaisePropertyChanged("rpt");
            }
        }
        
        /// <summary />
        private Extensions_t extensionsField;
        
        /// <remarks/>
        public Extensions_t Extensions {
            get {
                return this.extensionsField;
            }
            set {
                this.extensionsField = value;
                this.RaisePropertyChanged("Extensions");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.garmin.com/xmlschemas/GpxExtensions/v3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.garmin.com/xmlschemas/GpxExtensions/v3", IsNullable=true)]
    public partial class AutoroutePoint_t : System.ComponentModel.INotifyPropertyChanged {
        
        /// <summary />
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        /// <summary />
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
        
        /// <summary />
        private byte[] subclassField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="hexBinary")]
        public byte[] Subclass {
            get {
                return this.subclassField;
            }
            set {
                this.subclassField = value;
                this.RaisePropertyChanged("Subclass");
            }
        }
        
        /// <summary />
        private decimal latField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal lat {
            get {
                return this.latField;
            }
            set {
                this.latField = value;
                this.RaisePropertyChanged("lat");
            }
        }
        
        /// <summary />
        private decimal lonField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal lon {
            get {
                return this.lonField;
            }
            set {
                this.lonField = value;
                this.RaisePropertyChanged("lon");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.garmin.com/xmlschemas/GpxExtensions/v3")]
    [System.Xml.Serialization.XmlRootAttribute("TrackExtension", Namespace="http://www.garmin.com/xmlschemas/GpxExtensions/v3", IsNullable=false)]
    public partial class TrackExtension_t : System.ComponentModel.INotifyPropertyChanged {
        
        /// <summary />
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        /// <summary />
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
        
        /// <summary />
        private DisplayColor_t displayColorField;
        
        /// <remarks/>
        public DisplayColor_t DisplayColor {
            get {
                return this.displayColorField;
            }
            set {
                this.displayColorField = value;
                this.RaisePropertyChanged("DisplayColor");
            }
        }
        
        /// <summary />
        private bool displayColorFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisplayColorSpecified {
            get {
                return this.displayColorFieldSpecified;
            }
            set {
                this.displayColorFieldSpecified = value;
                this.RaisePropertyChanged("DisplayColorSpecified");
            }
        }
        
        /// <summary />
        private Extensions_t extensionsField;
        
        /// <remarks/>
        public Extensions_t Extensions {
            get {
                return this.extensionsField;
            }
            set {
                this.extensionsField = value;
                this.RaisePropertyChanged("Extensions");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.garmin.com/xmlschemas/GpxExtensions/v3")]
    [System.Xml.Serialization.XmlRootAttribute("TrackPointExtension", Namespace="http://www.garmin.com/xmlschemas/GpxExtensions/v3", IsNullable=false)]
    public partial class TrackPointExtension_t : System.ComponentModel.INotifyPropertyChanged {
        
        /// <summary />
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        /// <summary />
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
        
        /// <summary />
        private double temperatureField;
        
        /// <remarks/>
        public double Temperature {
            get {
                return this.temperatureField;
            }
            set {
                this.temperatureField = value;
                this.RaisePropertyChanged("Temperature");
            }
        }
        
        /// <summary />
        private bool temperatureFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TemperatureSpecified {
            get {
                return this.temperatureFieldSpecified;
            }
            set {
                this.temperatureFieldSpecified = value;
                this.RaisePropertyChanged("TemperatureSpecified");
            }
        }
        
        /// <summary />
        private double depthField;
        
        /// <remarks/>
        public double Depth {
            get {
                return this.depthField;
            }
            set {
                this.depthField = value;
                this.RaisePropertyChanged("Depth");
            }
        }
        
        /// <summary />
        private bool depthFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DepthSpecified {
            get {
                return this.depthFieldSpecified;
            }
            set {
                this.depthFieldSpecified = value;
                this.RaisePropertyChanged("DepthSpecified");
            }
        }
        
        /// <summary />
        private Extensions_t extensionsField;
        
        /// <remarks/>
        public Extensions_t Extensions {
            get {
                return this.extensionsField;
            }
            set {
                this.extensionsField = value;
                this.RaisePropertyChanged("Extensions");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.garmin.com/xmlschemas/GpxExtensions/v3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.garmin.com/xmlschemas/GpxExtensions/v3", IsNullable=true)]
    public partial class Categories_t : System.ComponentModel.INotifyPropertyChanged {
        
        /// <summary />
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        /// <summary />
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
        
        /// <summary />
        private string[] categoryField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Category")]
        public string[] Category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
                this.RaisePropertyChanged("Category");
            }
        }
    }
    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.garmin.com/xmlschemas/GpxExtensions/v3")]
    public partial class PhoneNumber_tCollection : System.Collections.Generic.List<PhoneNumber_t> {
    }
    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.garmin.com/xmlschemas/GpxExtensions/v3")]
    public partial class AutoroutePoint_tCollection : System.Collections.Generic.List<AutoroutePoint_t> {
    }
}
#pragma warning restore 1591