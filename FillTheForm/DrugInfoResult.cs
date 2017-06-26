using System;
using System.Collections.Generic;
using System.Text;

namespace FillTheForm.drug
{

    public class DrugInfoResult
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
        public Druginfo druginfo { get; set; }
        public Invosubject invosubject { get; set; }
    }

    public class Druginfo
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

        public SI_DRUGINFO_DRUGID SI_DRUGINFO_DRUGID { get; set; }
        public SI_DRUGINFO_AREACODE SI_DRUGINFO_AREACODE { get; set; }
        public SI_DRUGINFO_PAYKINDCODE SI_DRUGINFO_PAYKINDCODE { get; set; }
        public SI_DRUGINFO_PAYKINDNAME SI_DRUGINFO_PAYKINDNAME { get; set; }
        public SI_DRUGINFO_CITYCODE SI_DRUGINFO_CITYCODE { get; set; }
        public SI_DRUGINFO_DRUGCODE SI_DRUGINFO_DRUGCODE { get; set; }
        public SI_DRUGINFO_TRADENAME SI_DRUGINFO_TRADENAME { get; set; }
        public SI_DRUGINFO_REGULARNAME SI_DRUGINFO_REGULARNAME { get; set; }
        public SI_DRUGINFO_ENGLISHNAME SI_DRUGINFO_ENGLISHNAME { get; set; }
        public SI_DRUGINFO_INVOCODE SI_DRUGINFO_INVOCODE { get; set; }
        public SI_DRUGINFO_SPELLCODE SI_DRUGINFO_SPELLCODE { get; set; }
        public SI_DRUGINFO_WBCODE SI_DRUGINFO_WBCODE { get; set; }
        public SI_DRUGINFO_FEEGRADE SI_DRUGINFO_FEEGRADE { get; set; }
        public SI_DRUGINFO_TOPSALEPRICE SI_DRUGINFO_TOPSALEPRICE { get; set; }
        public SI_DRUGINFO_PAYRATE SI_DRUGINFO_PAYRATE { get; set; }
        public SI_DRUGINFO_DOSEUNIT SI_DRUGINFO_DOSEUNIT { get; set; }
        public SI_DRUGINFO_DOSEMODELCODE SI_DRUGINFO_DOSEMODELCODE { get; set; }
        public SI_DRUGINFO_SPECS SI_DRUGINFO_SPECS { get; set; }
        public SI_DRUGINFO_PACKUNIT SI_DRUGINFO_PACKUNIT { get; set; }
        public SI_DRUGINFO_APPROVENO SI_DRUGINFO_APPROVENO { get; set; }
        public SI_DRUGINFO_LIMITDAYS SI_DRUGINFO_LIMITDAYS { get; set; }
        public SI_DRUGINFO_STARTDATE SI_DRUGINFO_STARTDATE { get; set; }
        public SI_DRUGINFO_ENDDATE SI_DRUGINFO_ENDDATE { get; set; }
        public SI_DRUGINFO_REMARK SI_DRUGINFO_REMARK { get; set; }
        public SI_DRUGINFO_CITYDRUGFLAG SI_DRUGINFO_CITYDRUGFLAG { get; set; }
        public SI_DRUGINFO_EXT1 SI_DRUGINFO_EXT1 { get; set; }
        public SI_DRUGINFO_EXT2 SI_DRUGINFO_EXT2 { get; set; }
        public SI_DRUGINFO_EXT3 SI_DRUGINFO_EXT3 { get; set; }
        public SI_DRUGINFO_EXT4 SI_DRUGINFO_EXT4 { get; set; }
        public SI_DRUGINFO_EXT5 SI_DRUGINFO_EXT5 { get; set; }
        public SI_DRUGINFO_EXT6 SI_DRUGINFO_EXT6 { get; set; }
    }

    public class SI_DRUGINFO_DRUGID
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_AREACODE
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_PAYKINDCODE
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_PAYKINDNAME
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_CITYCODE
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_DRUGCODE
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_TRADENAME
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_REGULARNAME
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_ENGLISHNAME
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_INVOCODE
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_SPELLCODE
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_WBCODE
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_FEEGRADE
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_TOPSALEPRICE
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_PAYRATE
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_DOSEUNIT
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_DOSEMODELCODE
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_SPECS
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_PACKUNIT
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_APPROVENO
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_LIMITDAYS
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_STARTDATE
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_ENDDATE
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_REMARK
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_CITYDRUGFLAG
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_EXT1
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_EXT2
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_EXT3
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_EXT4
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_EXT5
    {
        public int dataType { get; set; }
    }

    public class SI_DRUGINFO_EXT6
    {
        public int dataType { get; set; }
    }

    public class Rowset
    {
        public Primary[] primary { get; set; }
    }

    public class Primary
    {
        public string SI_DRUGINFO_DRUGID { get; set; }
        public string SI_DRUGINFO_AREACODE { get; set; }
        public string SI_DRUGINFO_PAYKINDCODE { get; set; }
        public string SI_DRUGINFO_PAYKINDNAME { get; set; }
        public object SI_DRUGINFO_CITYCODE { get; set; }
        public string SI_DRUGINFO_DRUGCODE { get; set; }
        public string SI_DRUGINFO_TRADENAME { get; set; }
        public string SI_DRUGINFO_REGULARNAME { get; set; }
        public object SI_DRUGINFO_ENGLISHNAME { get; set; }
        public string SI_DRUGINFO_INVOCODE { get; set; }
        public string SI_DRUGINFO_SPELLCODE { get; set; }
        public string SI_DRUGINFO_WBCODE { get; set; }
        public string SI_DRUGINFO_FEEGRADE { get; set; }
        public string SI_DRUGINFO_TOPSALEPRICE { get; set; }
        public string SI_DRUGINFO_PAYRATE { get; set; }
        public object SI_DRUGINFO_DOSEUNIT { get; set; }
        public string SI_DRUGINFO_DOSEMODELCODE { get; set; }
        public object SI_DRUGINFO_SPECS { get; set; }
        public object SI_DRUGINFO_PACKUNIT { get; set; }
        public object SI_DRUGINFO_APPROVENO { get; set; }
        public object SI_DRUGINFO_LIMITDAYS { get; set; }
        public string SI_DRUGINFO_STARTDATE { get; set; }
        public string SI_DRUGINFO_ENDDATE { get; set; }
        public object SI_DRUGINFO_REMARK { get; set; }
        public object SI_DRUGINFO_CITYDRUGFLAG { get; set; }
        public string SI_DRUGINFO_EXT1 { get; set; }
        public string SI_DRUGINFO_EXT2 { get; set; }
        public object SI_DRUGINFO_EXT3 { get; set; }
        public string SI_DRUGINFO_EXT4 { get; set; }
        public string SI_DRUGINFO_EXT5 { get; set; }
        public string SI_DRUGINFO_EXT6 { get; set; }
    }

    public class Invosubject
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
