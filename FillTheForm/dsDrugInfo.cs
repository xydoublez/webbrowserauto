using System;
using System.Collections.Generic;
using System.Text;

namespace FillTheForm.dsdrug
{
    /// <summary>
    /// 财务管理　药品字典实体类
    /// </summary>
    public class dsDrugInfo
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
        public Dsdruginfo dsDrugInfo { get; set; }
    }

    public class Dsdruginfo
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
        public PHA_DRUGINFO_DRUGID PHA_DRUGINFO_DRUGID { get; set; }
        public PHA_DRUGINFO_ORGCODE PHA_DRUGINFO_ORGCODE { get; set; }
        public PHA_DRUGINFO_DRUGCODE PHA_DRUGINFO_DRUGCODE { get; set; }
        public PHA_DRUGINFO_TRADENAME PHA_DRUGINFO_TRADENAME { get; set; }
        public PHA_DRUGINFO_SPELLCODE PHA_DRUGINFO_SPELLCODE { get; set; }
        public PHA_DRUGINFO_WBCODE PHA_DRUGINFO_WBCODE { get; set; }
        public PHA_DRUGINFO_REGULARNAME PHA_DRUGINFO_REGULARNAME { get; set; }
        public PHA_DRUGINFO_RSPELLCODE PHA_DRUGINFO_RSPELLCODE { get; set; }
        public PHA_DRUGINFO_RWBCODE PHA_DRUGINFO_RWBCODE { get; set; }
        public PHA_DRUGINFO_DRUGTYPE PHA_DRUGINFO_DRUGTYPE { get; set; }
        public PHA_DRUGINFO_DOSEMODELCODE PHA_DRUGINFO_DOSEMODELCODE { get; set; }
        public PHA_DRUGINFO_DRUGQUALITY PHA_DRUGINFO_DRUGQUALITY { get; set; }
        public PHA_DRUGINFO_PHYKIND PHA_DRUGINFO_PHYKIND { get; set; }
        public PHA_DRUGINFO_SPECS PHA_DRUGINFO_SPECS { get; set; }
        public PHA_DRUGINFO_DOSEUNIT PHA_DRUGINFO_DOSEUNIT { get; set; }
        public PHA_DRUGINFO_MINUNIT PHA_DRUGINFO_MINUNIT { get; set; }
        public PHA_DRUGINFO_BASEDOSE PHA_DRUGINFO_BASEDOSE { get; set; }
        public PHA_DRUGINFO_PACKUNIT PHA_DRUGINFO_PACKUNIT { get; set; }
        public PHA_DRUGINFO_PACKQTY PHA_DRUGINFO_PACKQTY { get; set; }
        public PHA_DRUGINFO_SALEPRICE PHA_DRUGINFO_SALEPRICE { get; set; }
        public PHA_DRUGINFO_WSPRICE PHA_DRUGINFO_WSPRICE { get; set; }
        public PHA_DRUGINFO_TOPSALEPRICE PHA_DRUGINFO_TOPSALEPRICE { get; set; }
        public PHA_DRUGINFO_PRODUCINGAREA PHA_DRUGINFO_PRODUCINGAREA { get; set; }
        public PHA_DRUGINFO_APPROVEINFO PHA_DRUGINFO_APPROVEINFO { get; set; }
        public PHA_DRUGINFO_FACID PHA_DRUGINFO_FACID { get; set; }
        public PHA_DRUGINFO_FEECODE PHA_DRUGINFO_FEECODE { get; set; }
        public PHA_DRUGINFO_OUTINVOCODE PHA_DRUGINFO_OUTINVOCODE { get; set; }
        public PHA_DRUGINFO_ININVOCODE PHA_DRUGINFO_ININVOCODE { get; set; }
        public PHA_DRUGINFO_CLINICSENDUNIT PHA_DRUGINFO_CLINICSENDUNIT { get; set; }
        public PHA_DRUGINFO_HOSSENDUNIT PHA_DRUGINFO_HOSSENDUNIT { get; set; }
        public PHA_DRUGINFO_ISVALID PHA_DRUGINFO_ISVALID { get; set; }
        public PHA_DRUGINFO_REMARK PHA_DRUGINFO_REMARK { get; set; }
        public PHA_DRUGINFO_OPERCODE PHA_DRUGINFO_OPERCODE { get; set; }
        public PHA_DRUGINFO_OPERNAME PHA_DRUGINFO_OPERNAME { get; set; }
        public PHA_DRUGINFO_OPERTIME PHA_DRUGINFO_OPERTIME { get; set; }
        public PHA_DRUGINFO_ISZERORATE PHA_DRUGINFO_ISZERORATE { get; set; }
    }

    public class PHA_DRUGINFO_DRUGID
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_ORGCODE
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_DRUGCODE
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_TRADENAME
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_SPELLCODE
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_WBCODE
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_REGULARNAME
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_RSPELLCODE
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_RWBCODE
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_DRUGTYPE
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_DOSEMODELCODE
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_DRUGQUALITY
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_PHYKIND
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_SPECS
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_DOSEUNIT
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_MINUNIT
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_BASEDOSE
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_PACKUNIT
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_PACKQTY
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_SALEPRICE
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_WSPRICE
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_TOPSALEPRICE
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_PRODUCINGAREA
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_APPROVEINFO
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_FACID
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_FEECODE
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_OUTINVOCODE
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_ININVOCODE
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_CLINICSENDUNIT
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_HOSSENDUNIT
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_ISVALID
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_REMARK
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_OPERCODE
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_OPERNAME
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_OPERTIME
    {
        public int dataType { get; set; }
    }

    public class PHA_DRUGINFO_ISZERORATE
    {
        public int dataType { get; set; }
    }

    public class Rowset
    {
        public Primary[] primary { get; set; }
    }

    public class Primary
    {
        public string PHA_DRUGINFO_DRUGID { get; set; }
        public string PHA_DRUGINFO_ORGCODE { get; set; }
        public string PHA_DRUGINFO_DRUGCODE { get; set; }
        public string PHA_DRUGINFO_TRADENAME { get; set; }
        public string PHA_DRUGINFO_SPELLCODE { get; set; }
        public string PHA_DRUGINFO_WBCODE { get; set; }
        public string PHA_DRUGINFO_REGULARNAME { get; set; }
        public string PHA_DRUGINFO_RSPELLCODE { get; set; }
        public string PHA_DRUGINFO_RWBCODE { get; set; }
        public string PHA_DRUGINFO_DRUGTYPE { get; set; }
        public string PHA_DRUGINFO_DOSEMODELCODE { get; set; }
        public object PHA_DRUGINFO_DRUGQUALITY { get; set; }
        public object PHA_DRUGINFO_PHYKIND { get; set; }
        public string PHA_DRUGINFO_SPECS { get; set; }
        public string PHA_DRUGINFO_DOSEUNIT { get; set; }
        public string PHA_DRUGINFO_MINUNIT { get; set; }
        public string PHA_DRUGINFO_BASEDOSE { get; set; }
        public string PHA_DRUGINFO_PACKUNIT { get; set; }
        public string PHA_DRUGINFO_PACKQTY { get; set; }
        public string PHA_DRUGINFO_SALEPRICE { get; set; }
        public object PHA_DRUGINFO_WSPRICE { get; set; }
        public object PHA_DRUGINFO_TOPSALEPRICE { get; set; }
        public object PHA_DRUGINFO_PRODUCINGAREA { get; set; }
        public object PHA_DRUGINFO_APPROVEINFO { get; set; }
        public object PHA_DRUGINFO_FACID { get; set; }
        public string PHA_DRUGINFO_FEECODE { get; set; }
        public string PHA_DRUGINFO_OUTINVOCODE { get; set; }
        public string PHA_DRUGINFO_ININVOCODE { get; set; }
        public string PHA_DRUGINFO_CLINICSENDUNIT { get; set; }
        public string PHA_DRUGINFO_HOSSENDUNIT { get; set; }
        public string PHA_DRUGINFO_ISVALID { get; set; }
        public object PHA_DRUGINFO_REMARK { get; set; }
        public string PHA_DRUGINFO_OPERCODE { get; set; }
        public string PHA_DRUGINFO_OPERNAME { get; set; }
        public string PHA_DRUGINFO_OPERTIME { get; set; }
        public object PHA_DRUGINFO_ISZERORATE { get; set; }
    }

}
