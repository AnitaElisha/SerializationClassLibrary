using Newtonsoft.Json;
using System;
using System.Xml.Serialization;

namespace SerializationLibrary
{
    /* Both the XmlRootAttribute and JsonObject allow to set an alternate name
   (Address) of both XML element and JsonObject, the element namespace; by
   default, the XmlSerializer and JsonSerializer use the class name. The attribute
   also allows you to set the XML and Json namespace for the element.  */

    /// <summary>
    /// Represent address information of a person object
    /// </summary>
    [XmlRoot]
    [XmlType] // type of data will be xml
    [JsonObject]
    [Serializable]
    public class Address
    {
        [XmlElement]
        [JsonProperty]
        public string AddressLine { get; set; }
        [XmlElement]
        [JsonProperty]
        public string City { get; set; }
        [XmlElement]
        [JsonProperty]
        public string Country { get; set; }
        [XmlElement]
        [JsonProperty]
        public Guid EntityId { get; set; }
        [XmlElement]
        [JsonProperty]
        public string PostalCode { get; set; }
        [XmlElement]
        [JsonProperty]
        public string Province { get; set; }


        /// <summary>
        /// General Address constructor
        /// </summary>
        public Address()
        {
        }
        /// <summary>
        /// A Constructor Address with all parameters
        /// </summary>
        /// <param name="addressLine">Represent address line of the person</param>
        /// <param name="city">Represent city parameter</param>
        /// <param name="country">Represent country parameter</param>
        /// <param name="entityId">Represent entityId parameter for the person</param>
        /// <param name="postalCode">Represent postalCode of person's address</param>
        /// <param name="province">Represent province prameter</param>
        public Address(string addressLine, string city, string country, Guid entityId, string postalCode, string province)
        {
            this.AddressLine = addressLine;
            this.City = city;
            this.Country = country;
            this.EntityId = entityId;
            this.PostalCode = postalCode;
            this.Province = province;
        }

   
    }
    }
