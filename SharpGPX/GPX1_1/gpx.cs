using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Xml.Serialization;

namespace SharpGPX.GPX1_1
{
    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    public partial class gpxType
    {
        public gpxType()
        {
            metadata = new metadataType();
            rte = new rteTypeCollection();
            wpt = new wptTypeCollection();
            trk = new trkTypeCollection();
            versionField = "1.1";
        }
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    public partial class metadataType
    {
        public metadataType() => link = new linkTypeCollection();
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    [System.Diagnostics.DebuggerDisplay("{text} ({href})")]
    public partial class linkType
    {
        public linkType() { }

        public linkType(string link, string description = "")
        {
            href = link;
            text = description;
        }
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    [System.Diagnostics.DebuggerDisplay("{name} ({email})")]
    public partial class personType
    {
        public personType() { }

        public personType(string name, string email = "")
        {
            this.name = name;
            this.email = new emailType(email);
        }
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    [System.Diagnostics.DebuggerDisplay("{id}@{domain}")]
    public partial class emailType
    {
        public emailType() { }

        public emailType(string email)
        {
            if (string.IsNullOrEmpty(email)) return;

            var parts = email.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 2) return;

            id = parts[0];
            domain = parts[1];
        }
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    public partial class copyrightType
    {
        public copyrightType() { }

        public copyrightType(string author, string year = "", string license = "")
        {
            this.author = author;
            this.license = license;
            this.year = year;
        }
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    [System.Diagnostics.DebuggerDisplay("Bounds {maxlat},{maxlon},{minlat},{minlon}")]
    public partial class boundsType
    {
        public boundsType() { }

        public boundsType(decimal minlat, decimal maxlat, decimal minlon, decimal maxlon)
        {
            this.minlat = minlat;
            this.maxlat = maxlat;
            this.minlon = minlon;
            this.maxlon = maxlon;
        }

        /// <summary>
        /// Make a union of this bounds and the given bounds
        /// </summary>
        /// <returns></returns>
        public boundsType Union(boundsType other)
        {
            if (other == null || other.IsEmpty()) return this;
            if (this.IsEmpty()) return other;

            maxlat = Math.Max(maxlat, other.maxlat);
            maxlon = Math.Max(maxlon, other.maxlon);
            minlat = Math.Min(minlat, other.minlat);
            minlon = Math.Min(minlon, other.minlon);

            return this;
        }

        /// <summary>
        /// Is this an empty bounds
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => 
            maxlat == decimal.Zero &&
            minlat == decimal.Zero &&
            maxlon == decimal.Zero &&
            minlon == decimal.Zero;

        [XmlIgnore]
        public decimal Width => maxlon - minlon;

        [XmlIgnore]
        public decimal Height => maxlat - minlat;
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    [System.Diagnostics.DebuggerDisplay("{lat},{lon},{ele}")]
    public partial class wptType
    {
        public wptType()
        {
            timeSpecified = false;
            eleSpecified = false;
        }

        public wptType(double latitude, double longitude, double? elevation = null, DateTime? dateTime = null)
        {
            lat = (decimal)latitude;
            lon = (decimal)longitude;

            timeSpecified = dateTime.HasValue;
            if (dateTime.HasValue)
                time = dateTime.Value;

            eleSpecified = elevation.HasValue;
            if (elevation.HasValue)
                ele = (decimal)elevation.Value;
        }
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    [System.Diagnostics.DebuggerDisplay("{lat},{lon},{ele}")]
    public partial class ptType
    {
        public ptType()=> eleSpecified = false;

        public ptType(double latitude, double longitude, double? elevation = null, DateTime? dateTime = null)
        {
            lat = (decimal)latitude;
            lon = (decimal)longitude;
            eleSpecified = false;

            timeSpecified = dateTime.HasValue;
            if (dateTime.HasValue)
                time = dateTime.Value;

            eleSpecified = elevation.HasValue;
            if (elevation.HasValue)
                ele = (decimal)elevation.Value;
        }
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    [System.Diagnostics.DebuggerDisplay("{trkseg.Count} segments")]
    public partial class trkType
    {
        public trkType() => trkseg = new trksegTypeCollection();

        /// <summary>
        /// Get a boundsType that represents the bounds of this data
        /// </summary>
        /// <returns></returns>
        public boundsType GetBounds() => trkseg.GetBounds();
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    public partial class extensionsType
    {
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    [System.Diagnostics.DebuggerDisplay("{trkpt.Count} points")]
    public partial class trksegType
    {
        public trksegType() => trkpt = new wptTypeCollection();

        /// <summary>
        /// Get a boundsType that represents the bounds of this data
        /// </summary>
        /// <returns></returns>
        public boundsType GetBounds() => trkpt.GetBounds();
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    [System.Diagnostics.DebuggerDisplay("{rtept.Count} points")]
    public partial class rteType
    {
        public rteType() => rtept = new wptTypeCollection(); 

        /// <summary>
        /// Get a boundsType that represents the bounds of this data
        /// </summary>
        /// <returns></returns>
        public boundsType GetBounds() => rtept.GetBounds();
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    public partial class wptTypeCollection
    {
        public wptTypeCollection() { }

        public wptTypeCollection(IEnumerable<wptType> collection) : base(collection) { }

        /// <summary>
        /// Get a boundsType that represents the bounds of this data
        /// </summary>
        /// <returns></returns>
        public boundsType GetBounds() => Count == 0 ? new boundsType() : new boundsType(this.Min(x => x.lat), this.Max(x => x.lat), this.Min(x => x.lon), this.Max(x => x.lon));
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    public partial class rteTypeCollection
    {
        public rteTypeCollection() { }

        public rteTypeCollection(IEnumerable<rteType> collection) : base(collection) { }

        /// <summary>
        /// Get a boundsType that represents the bounds of this data
        /// </summary>
        /// <returns></returns>
        public boundsType GetBounds()
        {
            boundsType bounds = new boundsType();
            foreach (var rte in this)
                bounds = rte.rtept.GetBounds().Union(bounds);
            return bounds;
        }
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    public partial class trkTypeCollection
    {
        public trkTypeCollection() { }

        public trkTypeCollection(IEnumerable<trkType> collection) : base(collection) { }

        /// <summary>
        /// Get a boundsType that represents the bounds of this data
        /// </summary>
        /// <returns></returns>
        public boundsType GetBounds()
        {
            boundsType bounds = new boundsType();
            foreach (var trk in this)
                bounds = trk.trkseg.GetBounds().Union(bounds);
            return bounds;
        }
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    public partial class linkTypeCollection
    {
        public linkTypeCollection() { }

        public linkTypeCollection(IEnumerable<linkType> collection) : base(collection) { }
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    public partial class trksegTypeCollection
    {
        public trksegTypeCollection() { }

        public trksegTypeCollection(IEnumerable<trksegType> collection) : base(collection) { }

        /// <summary>
        /// Get a boundsType that represents the bounds of this data
        /// </summary>
        /// <returns></returns>
        public boundsType GetBounds()
        {
            boundsType bounds = new boundsType();
            foreach (var trkSeg in this)
                bounds = trkSeg.trkpt.GetBounds().Union(bounds);
            return bounds;
        }
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    public partial class ptTypeCollection
    {
        public ptTypeCollection() { }

        public ptTypeCollection(IEnumerable<ptType> collection) : base(collection) { }
    }
}
