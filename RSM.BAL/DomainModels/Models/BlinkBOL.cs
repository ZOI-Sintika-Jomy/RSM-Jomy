using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BAL.DomainModels.Models
{
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("entries")]
    public class BlinkCallResponse
    {
        private entriesEntry[] entryField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("entry")]
        public entriesEntry[] entry
        {
            get
            {
                return this.entryField;
            }
            set
            {
                this.entryField = value;
            }
        }
        public string status { get; set; }
        public string errormsg { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class entriesEntry
    {
        private string senttimeField;
        private string messageField;
        private decimal callpriceField;
        private decimal callprice1Field;
        private decimal callprice2Field;
        private decimal targetpriceField;
        private decimal stoplosspriceField;
        private string closepriceField;
        private string statusField;
        private string advisorField;
        private string categoryField;
        private string subcategoryField;
        private string symbolField;
        private int idField;
        private string calltypeField;
        private decimal strikepriceField;
        private string optiontypeField;
        private string contractexpiryField;
        private string callexpiryField;
        private string isinField;
        private string segmentField;
        private string typeField;
        /// <remarks/>
        public string senttime
        {
            get
            {
                return this.senttimeField;
            }
            set
            {
                this.senttimeField = value;
            }
        }

        /// <remarks/>
        public string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }

        /// <remarks/>
        public decimal callprice
        {
            get
            {
                return this.callpriceField;
            }
            set
            {
                this.callpriceField = value;
            }
        }

        /// <remarks/>
        public decimal callprice1
        {
            get
            {
                return this.callprice1Field;
            }
            set
            {
                this.callprice1Field = value;
            }
        }

        /// <remarks/>
        public decimal callprice2
        {
            get
            {
                return this.callprice2Field;
            }
            set
            {
                this.callprice2Field = value;
            }
        }

        /// <remarks/>
        public decimal targetprice
        {
            get
            {
                return this.targetpriceField;
            }
            set
            {
                this.targetpriceField = value;
            }
        }

        /// <remarks/>
        public decimal stoplossprice
        {
            get
            {
                return this.stoplosspriceField;
            }
            set
            {
                this.stoplosspriceField = value;
            }
        }

        /// <remarks/>
        public string closeprice
        {
            get
            {
                return this.closepriceField;
            }
            set
            {
                this.closepriceField = value;
            }
        }

        /// <remarks/>
        public string status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public string advisor
        {
            get
            {
                return this.advisorField;
            }
            set
            {
                this.advisorField = value;
            }
        }

        /// <remarks/>
        public string category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        public string subcategory
        {
            get
            {
                return this.subcategoryField;
            }
            set
            {
                this.subcategoryField = value;
            }
        }

        /// <remarks/>
        public string symbol
        {
            get
            {
                return this.symbolField;
            }
            set
            {
                this.symbolField = value;
            }
        }

        /// <remarks/>
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string calltype
        {
            get
            {
                return this.calltypeField;
            }
            set
            {
                this.calltypeField = value;
            }
        }

        /// <remarks/>
        public decimal strikeprice
        {
            get
            {
                return this.strikepriceField;
            }
            set
            {
                this.strikepriceField = value;
            }
        }

        /// <remarks/>
        public string optiontype
        {
            get
            {
                return this.optiontypeField;
            }
            set
            {
                this.optiontypeField = value;
            }
        }

        /// <remarks/>
        public string contractexpiry
        {
            get
            {
                return this.contractexpiryField;
            }
            set
            {
                this.contractexpiryField = value;
            }
        }

        /// <remarks/>
        public string callexpiry
        {
            get
            {
                return this.callexpiryField;
            }
            set
            {
                this.callexpiryField = value;
            }
        }

        /// <remarks/>
        public string isin
        {
            get
            {
                return this.isinField;
            }
            set
            {
                this.isinField = value;
            }
        }

        /// <remarks/>
        public string segment
        {
            get
            {
                return this.segmentField;
            }
            set
            {
                this.segmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    public class BlinkCallRequest
    {
        public string clientID { get; set; }
        public string sessionID { get; set; }
    }

}
