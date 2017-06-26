using System;
using System.Collections.Generic;
using System.Text;

namespace FillTheForm.compare
{
 
    /// <summary>
    /// 　对照信息实体类
    /// </summary>
    public class dsItemCompare
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
        public Dsitemcompare dsItemCompare { get; set; }
    }

    public class Dsitemcompare
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
        public FIN_ITEM_COMPARE_RELAID FIN_ITEM_COMPARE_RELAID { get; set; }
        public FIN_ITEM_COMPARE_ORGCODE FIN_ITEM_COMPARE_ORGCODE { get; set; }
        public FIN_ITEM_COMPARE_AREACODE FIN_ITEM_COMPARE_AREACODE { get; set; }
        public FIN_ITEM_COMPARE_PAYKINDCODE FIN_ITEM_COMPARE_PAYKINDCODE { get; set; }
        public FIN_ITEM_COMPARE_ITEMTYPE FIN_ITEM_COMPARE_ITEMTYPE { get; set; }
        public FIN_ITEM_COMPARE_ITEMID FIN_ITEM_COMPARE_ITEMID { get; set; }
        public FIN_ITEM_COMPARE_ITEMCODE FIN_ITEM_COMPARE_ITEMCODE { get; set; }
        public FIN_ITEM_COMPARE_ITEMNAME FIN_ITEM_COMPARE_ITEMNAME { get; set; }
        public FIN_ITEM_COMPARE_INVOCODE FIN_ITEM_COMPARE_INVOCODE { get; set; }
        public FIN_ITEM_COMPARE_FEEGRADE FIN_ITEM_COMPARE_FEEGRADE { get; set; }
        public FIN_ITEM_COMPARE_TOPSALEPRICE FIN_ITEM_COMPARE_TOPSALEPRICE { get; set; }
        public FIN_ITEM_COMPARE_PAYRATE FIN_ITEM_COMPARE_PAYRATE { get; set; }
        public FIN_ITEM_COMPARE_APPRFLAG FIN_ITEM_COMPARE_APPRFLAG { get; set; }
        public FIN_ITEM_COMPARE_EXT1 FIN_ITEM_COMPARE_EXT1 { get; set; }
        public FIN_ITEM_COMPARE_EXT2 FIN_ITEM_COMPARE_EXT2 { get; set; }
        public FIN_ITEM_COMPARE_EXT3 FIN_ITEM_COMPARE_EXT3 { get; set; }
        public FIN_ITEM_COMPARE_EXT4 FIN_ITEM_COMPARE_EXT4 { get; set; }
        public FIN_ITEM_COMPARE_EXT5 FIN_ITEM_COMPARE_EXT5 { get; set; }
        public FIN_ITEM_COMPARE_EXT6 FIN_ITEM_COMPARE_EXT6 { get; set; }
    }

    public class FIN_ITEM_COMPARE_RELAID
    {
        public int dataType { get; set; }
    }

    public class FIN_ITEM_COMPARE_ORGCODE
    {
        public int dataType { get; set; }
    }

    public class FIN_ITEM_COMPARE_AREACODE
    {
        public int dataType { get; set; }
    }

    public class FIN_ITEM_COMPARE_PAYKINDCODE
    {
        public int dataType { get; set; }
    }

    public class FIN_ITEM_COMPARE_ITEMTYPE
    {
        public int dataType { get; set; }
    }

    public class FIN_ITEM_COMPARE_ITEMID
    {
        public int dataType { get; set; }
    }

    public class FIN_ITEM_COMPARE_ITEMCODE
    {
        public int dataType { get; set; }
    }

    public class FIN_ITEM_COMPARE_ITEMNAME
    {
        public int dataType { get; set; }
    }

    public class FIN_ITEM_COMPARE_INVOCODE
    {
        public int dataType { get; set; }
    }

    public class FIN_ITEM_COMPARE_FEEGRADE
    {
        public int dataType { get; set; }
    }

    public class FIN_ITEM_COMPARE_TOPSALEPRICE
    {
        public int dataType { get; set; }
    }

    public class FIN_ITEM_COMPARE_PAYRATE
    {
        public int dataType { get; set; }
    }

    public class FIN_ITEM_COMPARE_APPRFLAG
    {
        public int dataType { get; set; }
    }

    public class FIN_ITEM_COMPARE_EXT1
    {
        public int dataType { get; set; }
    }

    public class FIN_ITEM_COMPARE_EXT2
    {
        public int dataType { get; set; }
    }

    public class FIN_ITEM_COMPARE_EXT3
    {
        public int dataType { get; set; }
    }

    public class FIN_ITEM_COMPARE_EXT4
    {
        public int dataType { get; set; }
    }

    public class FIN_ITEM_COMPARE_EXT5
    {
        public int dataType { get; set; }
    }

    public class FIN_ITEM_COMPARE_EXT6
    {
        public int dataType { get; set; }
    }

    public class Rowset
    {
        public Primary[] primary { get; set; }
    }

    public class Primary
    {
        public string FIN_ITEM_COMPARE_RELAID { get; set; }
        public string FIN_ITEM_COMPARE_ORGCODE { get; set; }
        public string FIN_ITEM_COMPARE_AREACODE { get; set; }
        public string FIN_ITEM_COMPARE_PAYKINDCODE { get; set; }
        public string FIN_ITEM_COMPARE_ITEMTYPE { get; set; }
        public string FIN_ITEM_COMPARE_ITEMID { get; set; }
        public string FIN_ITEM_COMPARE_ITEMCODE { get; set; }
        public string FIN_ITEM_COMPARE_ITEMNAME { get; set; }
        public string FIN_ITEM_COMPARE_INVOCODE { get; set; }
        public string FIN_ITEM_COMPARE_FEEGRADE { get; set; }
        public string FIN_ITEM_COMPARE_TOPSALEPRICE { get; set; }
        public string FIN_ITEM_COMPARE_PAYRATE { get; set; }
        public string FIN_ITEM_COMPARE_APPRFLAG { get; set; }
        public object FIN_ITEM_COMPARE_EXT1 { get; set; }
        public object FIN_ITEM_COMPARE_EXT2 { get; set; }
        public object FIN_ITEM_COMPARE_EXT3 { get; set; }
        public object FIN_ITEM_COMPARE_EXT4 { get; set; }
        public object FIN_ITEM_COMPARE_EXT5 { get; set; }
        public object FIN_ITEM_COMPARE_EXT6 { get; set; }
    }

}
