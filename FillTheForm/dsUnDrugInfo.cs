using System;
using System.Collections.Generic;
using System.Text;

namespace FillTheForm.dsundrug
{
    /// <summary>
    /// 财务管理　收费项目管理实体类
    /// </summary>
    public class dsundruginfo
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
        public Dsundruginfo dsundruginfo { get; set; }
    }

    public class Dsundruginfo
    {
        public int pageSize { get; set; }
        public int pageNumber { get; set; }
        public int recordCount { get; set; }
        public string name { get; set; }
        public string rowSetName { get; set; }
        public string order { get; set; }
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
        public FIN_UNDRUGINFO_ITEMID FIN_UNDRUGINFO_ITEMID { get; set; }
        public FIN_UNDRUGINFO_ORGCODE FIN_UNDRUGINFO_ORGCODE { get; set; }
        public FIN_UNDRUGINFO_ITEMCODE FIN_UNDRUGINFO_ITEMCODE { get; set; }
        public FIN_UNDRUGINFO_ITEMNAME FIN_UNDRUGINFO_ITEMNAME { get; set; }
        public FIN_UNDRUGINFO_SPECS FIN_UNDRUGINFO_SPECS { get; set; }
        public FIN_UNDRUGINFO_SPELLCODE FIN_UNDRUGINFO_SPELLCODE { get; set; }
        public FIN_UNDRUGINFO_WBCODE FIN_UNDRUGINFO_WBCODE { get; set; }
        public FIN_UNDRUGINFO_UNITPRICE FIN_UNDRUGINFO_UNITPRICE { get; set; }
        public FIN_UNDRUGINFO_STOCKUNIT FIN_UNDRUGINFO_STOCKUNIT { get; set; }
        public FIN_UNDRUGINFO_FEECODE FIN_UNDRUGINFO_FEECODE { get; set; }
        public FIN_UNDRUGINFO_OUTINVOCODE FIN_UNDRUGINFO_OUTINVOCODE { get; set; }
        public FIN_UNDRUGINFO_ININVOCODE FIN_UNDRUGINFO_ININVOCODE { get; set; }
        public FIN_UNDRUGINFO_NHCENTERCODE FIN_UNDRUGINFO_NHCENTERCODE { get; set; }
        public FIN_UNDRUGINFO_ITEMSTATUS FIN_UNDRUGINFO_ITEMSTATUS { get; set; }
        public FIN_UNDRUGINFO_EXEDEPTCODE FIN_UNDRUGINFO_EXEDEPTCODE { get; set; }
        public FIN_UNDRUGINFO_EXEDEPTNAME FIN_UNDRUGINFO_EXEDEPTNAME { get; set; }
        public FIN_UNDRUGINFO_OPERCODE FIN_UNDRUGINFO_OPERCODE { get; set; }
        public FIN_UNDRUGINFO_OPERNAME FIN_UNDRUGINFO_OPERNAME { get; set; }
        public FIN_UNDRUGINFO_OPERTIME FIN_UNDRUGINFO_OPERTIME { get; set; }
        public FIN_UNDRUGINFO_NHCENTERNAME FIN_UNDRUGINFO_NHCENTERNAME { get; set; }
    }

    public class FIN_UNDRUGINFO_ITEMID
    {
        public int dataType { get; set; }
    }

    public class FIN_UNDRUGINFO_ORGCODE
    {
        public int dataType { get; set; }
    }

    public class FIN_UNDRUGINFO_ITEMCODE
    {
        public int dataType { get; set; }
    }

    public class FIN_UNDRUGINFO_ITEMNAME
    {
        public int dataType { get; set; }
    }

    public class FIN_UNDRUGINFO_SPECS
    {
        public int dataType { get; set; }
    }

    public class FIN_UNDRUGINFO_SPELLCODE
    {
        public int dataType { get; set; }
    }

    public class FIN_UNDRUGINFO_WBCODE
    {
        public int dataType { get; set; }
    }

    public class FIN_UNDRUGINFO_UNITPRICE
    {
        public int dataType { get; set; }
    }

    public class FIN_UNDRUGINFO_STOCKUNIT
    {
        public int dataType { get; set; }
    }

    public class FIN_UNDRUGINFO_FEECODE
    {
        public int dataType { get; set; }
    }

    public class FIN_UNDRUGINFO_OUTINVOCODE
    {
        public int dataType { get; set; }
    }

    public class FIN_UNDRUGINFO_ININVOCODE
    {
        public int dataType { get; set; }
    }

    public class FIN_UNDRUGINFO_NHCENTERCODE
    {
        public int dataType { get; set; }
    }

    public class FIN_UNDRUGINFO_ITEMSTATUS
    {
        public int dataType { get; set; }
    }

    public class FIN_UNDRUGINFO_EXEDEPTCODE
    {
        public int dataType { get; set; }
    }

    public class FIN_UNDRUGINFO_EXEDEPTNAME
    {
        public int dataType { get; set; }
    }

    public class FIN_UNDRUGINFO_OPERCODE
    {
        public int dataType { get; set; }
    }

    public class FIN_UNDRUGINFO_OPERNAME
    {
        public int dataType { get; set; }
    }

    public class FIN_UNDRUGINFO_OPERTIME
    {
        public int dataType { get; set; }
    }

    public class FIN_UNDRUGINFO_NHCENTERNAME
    {
        public int dataType { get; set; }
    }

    public class Rowset
    {
        public Primary[] primary { get; set; }
    }

    public class Primary
    {
        public string FIN_UNDRUGINFO_ITEMID { get; set; }
        public string FIN_UNDRUGINFO_ORGCODE { get; set; }
        public string FIN_UNDRUGINFO_ITEMCODE { get; set; }
        public string FIN_UNDRUGINFO_ITEMNAME { get; set; }
        public object FIN_UNDRUGINFO_SPECS { get; set; }
        public string FIN_UNDRUGINFO_SPELLCODE { get; set; }
        public string FIN_UNDRUGINFO_WBCODE { get; set; }
        public string FIN_UNDRUGINFO_UNITPRICE { get; set; }
        public string FIN_UNDRUGINFO_STOCKUNIT { get; set; }
        public string FIN_UNDRUGINFO_FEECODE { get; set; }
        public string FIN_UNDRUGINFO_OUTINVOCODE { get; set; }
        public string FIN_UNDRUGINFO_ININVOCODE { get; set; }
        public object FIN_UNDRUGINFO_NHCENTERCODE { get; set; }
        public string FIN_UNDRUGINFO_ITEMSTATUS { get; set; }
        public object FIN_UNDRUGINFO_EXEDEPTCODE { get; set; }
        public object FIN_UNDRUGINFO_EXEDEPTNAME { get; set; }
        public string FIN_UNDRUGINFO_OPERCODE { get; set; }
        public string FIN_UNDRUGINFO_OPERNAME { get; set; }
        public string FIN_UNDRUGINFO_OPERTIME { get; set; }
        public object FIN_UNDRUGINFO_NHCENTERNAME { get; set; }
    }

}
