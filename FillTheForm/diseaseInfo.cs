using System;
using System.Collections.Generic;
using System.Text;

namespace FillTheForm.disease
{

    public class diseaseInfo
    {
        public Header header { get; set; }
        public Body body { get; set; }
    }

    public class Header
    {
        public int code { get; set; }
        public Message message { get; set; }
    }

    public class Message
    {
        public string title { get; set; }
        public string detail { get; set; }
    }

    public class Body
    {
        public Parameters parameters { get; set; }
        public Datastores dataStores { get; set; }
    }

    public class Parameters
    {
    }

    public class Datastores
    {
        public Si_Disease si_disease { get; set; }
    }

    public class Si_Disease
    {
        public int pageSize { get; set; }
        public int pageNumber { get; set; }
        public int recordCount { get; set; }
        public string name { get; set; }
        public string rowSetName { get; set; }
        public string condition { get; set; }
        public string[][] parameters { get; set; }
        public Context context { get; set; }
        public Metadata metaData { get; set; }
        public Rowset rowSet { get; set; }
    }

    public class Context
    {
        public string BUSINESS_ID { get; set; }
        public string BUSINESS_REQUEST_ID { get; set; }
        public string CUSTOMVPDPARA { get; set; }
    }

    public class Metadata
    {
        public ICDID ICDID { get; set; }
        public AREACODE AREACODE { get; set; }
        public PAYKINDCODE PAYKINDCODE { get; set; }
        public ICDCODE ICDCODE { get; set; }
        public ICDNAME ICDNAME { get; set; }
        public DISEASETYPE DISEASETYPE { get; set; }
        public DISEASESORT DISEASESORT { get; set; }
        public SPELLCODE SPELLCODE { get; set; }
        public WBCODE WBCODE { get; set; }
        public VALIDATEFLAG VALIDATEFLAG { get; set; }
        public REMARK REMARK { get; set; }
    }

    public class ICDID
    {
        public int dataType { get; set; }
    }

    public class AREACODE
    {
        public int dataType { get; set; }
    }

    public class PAYKINDCODE
    {
        public int dataType { get; set; }
    }

    public class ICDCODE
    {
        public int dataType { get; set; }
    }

    public class ICDNAME
    {
        public int dataType { get; set; }
    }

    public class DISEASETYPE
    {
        public int dataType { get; set; }
    }

    public class DISEASESORT
    {
        public int dataType { get; set; }
    }

    public class SPELLCODE
    {
        public int dataType { get; set; }
    }

    public class WBCODE
    {
        public int dataType { get; set; }
    }

    public class VALIDATEFLAG
    {
        public int dataType { get; set; }
    }

    public class REMARK
    {
        public int dataType { get; set; }
    }

    public class Rowset
    {
        public Primary[] primary { get; set; }
    }

    public class Primary
    {
        public string ICDID { get; set; }
        public string AREACODE { get; set; }
        public string PAYKINDCODE { get; set; }
        public string ICDCODE { get; set; }
        public string ICDNAME { get; set; }
        public string DISEASETYPE { get; set; }
        public string DISEASESORT { get; set; }
        public string SPELLCODE { get; set; }
        public object WBCODE { get; set; }
        public string VALIDATEFLAG { get; set; }
        public object REMARK { get; set; }
    }

}
