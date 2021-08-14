using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace SerializationLibrary
{
    /* Both the XmlRootAttribute and JsonObject allow to set an alternate name
    (Entity) of both XML element and JsonObject, the element namespace; by
    default, the XmlSerializer and JsonSerializer use the class name. The attribute
    also allows you to set the XML and Json namespace for the element.  */

    /// <summary>
    /// Represent an entity object class
    /// </summary>
    [XmlRoot]
    [XmlType] 
    [JsonObject]
    [Serializable]
    public class Entity
    {
       
        /// <summary>
        /// General Entity constructor
        /// </summary>
        public Entity()
        {
        }


        /// <summary>
        /// Represent Constructor with three prameters
        /// </summary>
        /// <param name="id"></param>
        /// <param name="addresses"></param>
        /// <param name="identifiers"></param>
        public Entity(Guid id, List<Address> addresses, List<Identifier> identifiers)
        {
            Id = id;
        }

        /// <summary>
        /// Constructors with id parameter.
        /// </summary>
        /// <param name="id"></param>
        public Entity(Guid id)
        {
            Id = id;
        }
        /// <summary>
        /// Gets or sets a list of Identifiers object
        /// </summary>
        [XmlElement]
        [JsonProperty]
        public List<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or sets a Guid id 
        /// </summary>
        [XmlElement]
        [JsonProperty]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets a list of Identifiers object
        /// </summary>
        [XmlElement]
        [JsonProperty]
        public List<Identifier> Identifiers { get; set; }
    }
}
