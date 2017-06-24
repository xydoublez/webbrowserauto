using System;
using System.Collections.Generic;
using System.Text;

namespace FillTheForm.undrug
{
  
    public class UnDrugInfo
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
        public Undruginfo undruginfo { get; set; }
        public Invo invo { get; set; }
    }

    public class Undruginfo
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
        public SI_UNDRUGINFO_ITEMID SI_UNDRUGINFO_ITEMID { get; set; }
        public SI_UNDRUGINFO_AREACODE SI_UNDRUGINFO_AREACODE { get; set; }
        public SI_UNDRUGINFO_CITYCODE SI_UNDRUGINFO_CITYCODE { get; set; }
        public SI_UNDRUGINFO_PAYKINDCODE SI_UNDRUGINFO_PAYKINDCODE { get; set; }
        public SI_UNDRUGINFO_PAYKINDNAME SI_UNDRUGINFO_PAYKINDNAME { get; set; }
        public SI_UNDRUGINFO_ITEMCODE SI_UNDRUGINFO_ITEMCODE { get; set; }
        public SI_UNDRUGINFO_ITEMNAME SI_UNDRUGINFO_ITEMNAME { get; set; }
        public SI_UNDRUGINFO_INVOCODE SI_UNDRUGINFO_INVOCODE { get; set; }
        public SI_UNDRUGINFO_FEEGRADE SI_UNDRUGINFO_FEEGRADE { get; set; }
        public SI_UNDRUGINFO_SPELLCODE SI_UNDRUGINFO_SPELLCODE { get; set; }
        public SI_UNDRUGINFO_WBCODE SI_UNDRUGINFO_WBCODE { get; set; }
        public SI_UNDRUGINFO_TOPSALEPRICE SI_UNDRUGINFO_TOPSALEPRICE { get; set; }
        public SI_UNDRUGINFO_PAYRATE SI_UNDRUGINFO_PAYRATE { get; set; }
        public SI_UNDRUGINFO_STARTDATE SI_UNDRUGINFO_STARTDATE { get; set; }
        public SI_UNDRUGINFO_ENDDATE SI_UNDRUGINFO_ENDDATE { get; set; }
        public SI_UNDRUGINFO_REMARK SI_UNDRUGINFO_REMARK { get; set; }
        public SI_UNDRUGINFO_HOSGRADE SI_UNDRUGINFO_HOSGRADE { get; set; }
        public SI_UNDRUGINFO_EXT1 SI_UNDRUGINFO_EXT1 { get; set; }
        public SI_UNDRUGINFO_EXT2 SI_UNDRUGINFO_EXT2 { get; set; }
        public SI_UNDRUGINFO_EXT3 SI_UNDRUGINFO_EXT3 { get; set; }
        public SI_UNDRUGINFO_EXT4 SI_UNDRUGINFO_EXT4 { get; set; }
        public SI_UNDRUGINFO_EXT5 SI_UNDRUGINFO_EXT5 { get; set; }
        public SI_UNDRUGINFO_EXT6 SI_UNDRUGINFO_EXT6 { get; set; }
    }

    public class SI_UNDRUGINFO_ITEMID
    {
        public int dataType { get; set; }
    }

    public class SI_UNDRUGINFO_AREACODE
    {
        public int dataType { get; set; }
    }

    public class SI_UNDRUGINFO_CITYCODE
    {
        public int dataType { get; set; }
    }

    public class SI_UNDRUGINFO_PAYKINDCODE
    {
        public int dataType { get; set; }
    }

    public class SI_UNDRUGINFO_PAYKINDNAME
    {
        public int dataType { get; set; }
    }

    public class SI_UNDRUGINFO_ITEMCODE
    {
        public int dataType { get; set; }
    }

    public class SI_UNDRUGINFO_ITEMNAME
    {
        public int dataType { get; set; }
    }

    public class SI_UNDRUGINFO_INVOCODE
    {
        public int dataType { get; set; }
    }

    public class SI_UNDRUGINFO_FEEGRADE
    {
        public int dataType { get; set; }
    }

    public class SI_UNDRUGINFO_SPELLCODE
    {
        public int dataType { get; set; }
    }

    public class SI_UNDRUGINFO_WBCODE
    {
        public int dataType { get; set; }
    }

    public class SI_UNDRUGINFO_TOPSALEPRICE
    {
        public int dataType { get; set; }
    }

    public class SI_UNDRUGINFO_PAYRATE
    {
        public int dataType { get; set; }
    }

    public class SI_UNDRUGINFO_STARTDATE
    {
        public int dataType { get; set; }
    }

    public class SI_UNDRUGINFO_ENDDATE
    {
        public int dataType { get; set; }
    }

    public class SI_UNDRUGINFO_REMARK
    {
        public int dataType { get; set; }
    }

    public class SI_UNDRUGINFO_HOSGRADE
    {
        public int dataType { get; set; }
    }

    public class SI_UNDRUGINFO_EXT1
    {
        public int dataType { get; set; }
    }

    public class SI_UNDRUGINFO_EXT2
    {
        public int dataType { get; set; }
    }

    public class SI_UNDRUGINFO_EXT3
    {
        public int dataType { get; set; }
    }

    public class SI_UNDRUGINFO_EXT4
    {
        public int dataType { get; set; }
    }

    public class SI_UNDRUGINFO_EXT5
    {
        public int dataType { get; set; }
    }

    public class SI_UNDRUGINFO_EXT6
    {
        public int dataType { get; set; }
    }

    public class Rowset
    {
        public Primary[] primary { get; set; }
    }

    public class Primary
    {
        public string SI_UNDRUGINFO_ITEMID { get; set; }
        public string SI_UNDRUGINFO_AREACODE { get; set; }
        public object SI_UNDRUGINFO_CITYCODE { get; set; }
        public string SI_UNDRUGINFO_PAYKINDCODE { get; set; }
        public string SI_UNDRUGINFO_PAYKINDNAME { get; set; }
        public string SI_UNDRUGINFO_ITEMCODE { get; set; }
        public string SI_UNDRUGINFO_ITEMNAME { get; set; }
        public string SI_UNDRUGINFO_INVOCODE { get; set; }
        public string SI_UNDRUGINFO_FEEGRADE { get; set; }
        public string SI_UNDRUGINFO_SPELLCODE { get; set; }
        public string SI_UNDRUGINFO_WBCODE { get; set; }
        public string SI_UNDRUGINFO_TOPSALEPRICE { get; set; }
        public string SI_UNDRUGINFO_PAYRATE { get; set; }
        public string SI_UNDRUGINFO_STARTDATE { get; set; }
        public string SI_UNDRUGINFO_ENDDATE { get; set; }
        public object SI_UNDRUGINFO_REMARK { get; set; }
        public object SI_UNDRUGINFO_HOSGRADE { get; set; }
        public object SI_UNDRUGINFO_EXT1 { get; set; }
        public object SI_UNDRUGINFO_EXT2 { get; set; }
        public object SI_UNDRUGINFO_EXT3 { get; set; }
        public object SI_UNDRUGINFO_EXT4 { get; set; }
        public object SI_UNDRUGINFO_EXT5 { get; set; }
        public string SI_UNDRUGINFO_EXT6 { get; set; }
    }

    public class Invo
    {
        public int pageSize { get; set; }
        public int pageNumber { get; set; }
        public int recordCount { get; set; }
        public string name { get; set; }
        public string rowSetName { get; set; }
        public string condition { get; set; }
        public string[][] parameters { get; set; }
        public Context1 context { get; set; }
        public Metadata1 metaData { get; set; }
        public Rowset1 rowSet { get; set; }
    }

    public class Context1
    {
        public string BUSINESS_ID { get; set; }
        public string BUSINESS_REQUEST_ID { get; set; }
        public string CUSTOMVPDPARA { get; set; }
    }

    public class Metadata1
    {
        public SUBJECTID SUBJECTID { get; set; }
        public AREACODE AREACODE { get; set; }
        public PAYKINDCODE PAYKINDCODE { get; set; }
        public SUBJECTCODE SUBJECTCODE { get; set; }
        public SUBJECTNAME SUBJECTNAME { get; set; }
        public CATECODE CATECODE { get; set; }
        public CATENAME CATENAME { get; set; }
    }

    public class SUBJECTID
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

    public class SUBJECTCODE
    {
        public int dataType { get; set; }
    }

    public class SUBJECTNAME
    {
        public int dataType { get; set; }
    }

    public class CATECODE
    {
        public int dataType { get; set; }
    }

    public class CATENAME
    {
        public int dataType { get; set; }
    }

    public class Rowset1
    {
        public object[] primary { get; set; }
    }

}
