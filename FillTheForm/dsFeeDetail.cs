using System;
using System.Collections.Generic;
using System.Text;

namespace FillTheForm
{

    public class dsFeeDetail
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
        public OPB_FEEDETAIL_FEEITEMID OPB_FEEDETAIL_FEEITEMID { get; set; }
        public OPB_FEEDETAIL_ORGCODE OPB_FEEDETAIL_ORGCODE { get; set; }
        public OPB_FEEDETAIL_REGID OPB_FEEDETAIL_REGID { get; set; }
        public OPB_FEEDETAIL_RECIPEID OPB_FEEDETAIL_RECIPEID { get; set; }
        public OPB_FEEDETAIL_SEQNO OPB_FEEDETAIL_SEQNO { get; set; }
        public OPB_FEEDETAIL_TRANSTYPE OPB_FEEDETAIL_TRANSTYPE { get; set; }
        public OPB_FEEDETAIL_REGDPCD OPB_FEEDETAIL_REGDPCD { get; set; }
        public OPB_FEEDETAIL_DOCTCODE OPB_FEEDETAIL_DOCTCODE { get; set; }
        public OPB_FEEDETAIL_GROUPID OPB_FEEDETAIL_GROUPID { get; set; }
        public OPB_FEEDETAIL_GROUPNAME OPB_FEEDETAIL_GROUPNAME { get; set; }
        public OPB_FEEDETAIL_ITEMID OPB_FEEDETAIL_ITEMID { get; set; }
        public OPB_FEEDETAIL_ITEMNAME OPB_FEEDETAIL_ITEMNAME { get; set; }
        public OPB_FEEDETAIL_DRUGFLAG OPB_FEEDETAIL_DRUGFLAG { get; set; }
        public OPB_FEEDETAIL_SPECS OPB_FEEDETAIL_SPECS { get; set; }
        public OPB_FEEDETAIL_DOSEMODELCODE OPB_FEEDETAIL_DOSEMODELCODE { get; set; }
        public OPB_FEEDETAIL_FEECODE OPB_FEEDETAIL_FEECODE { get; set; }
        public OPB_FEEDETAIL_UNITPRICE OPB_FEEDETAIL_UNITPRICE { get; set; }
        public OPB_FEEDETAIL_QTY OPB_FEEDETAIL_QTY { get; set; }
        public OPB_FEEDETAIL_DAYS OPB_FEEDETAIL_DAYS { get; set; }
        public OPB_FEEDETAIL_PACKQTY OPB_FEEDETAIL_PACKQTY { get; set; }
        public OPB_FEEDETAIL_PRICEUNIT OPB_FEEDETAIL_PRICEUNIT { get; set; }
        public OPB_FEEDETAIL_TOTCOST OPB_FEEDETAIL_TOTCOST { get; set; }
        public OPB_FEEDETAIL_OWNCOST OPB_FEEDETAIL_OWNCOST { get; set; }
        public OPB_FEEDETAIL_PAYCOST OPB_FEEDETAIL_PAYCOST { get; set; }
        public OPB_FEEDETAIL_PUBCOST OPB_FEEDETAIL_PUBCOST { get; set; }
        public OPB_FEEDETAIL_EXECDPCD OPB_FEEDETAIL_EXECDPCD { get; set; }
        public OPB_FEEDETAIL_EXECDPNM OPB_FEEDETAIL_EXECDPNM { get; set; }
        public OPB_FEEDETAIL_SICODE OPB_FEEDETAIL_SICODE { get; set; }
        public OPB_FEEDETAIL_ITEMGRADE OPB_FEEDETAIL_ITEMGRADE { get; set; }
        public OPB_FEEDETAIL_ITEMSTATUS OPB_FEEDETAIL_ITEMSTATUS { get; set; }
        public OPB_FEEDETAIL_INVOICEID OPB_FEEDETAIL_INVOICEID { get; set; }
        public OPB_FEEDETAIL_INVOCODE OPB_FEEDETAIL_INVOCODE { get; set; }
        public OPB_FEEDETAIL_FEEOPCD OPB_FEEDETAIL_FEEOPCD { get; set; }
        public OPB_FEEDETAIL_FEEDATE OPB_FEEDETAIL_FEEDATE { get; set; }
        public ITEMTYPE ITEMTYPE { get; set; }
        public INVONAME INVONAME { get; set; }
        public PRINTNO PRINTNO { get; set; }
        public DAYS DAYS { get; set; }
        public SCALRATION SCALRATION { get; set; }
        public OPB_FEEDETAIL_SENDFLAG OPB_FEEDETAIL_SENDFLAG { get; set; }
        public OPB_FEEDETAIL_RETURNQTY OPB_FEEDETAIL_RETURNQTY { get; set; }
        public RETURNCOST RETURNCOST { get; set; }
        public OPB_FEEDETAIL_DRUGTYPE OPB_FEEDETAIL_DRUGTYPE { get; set; }
        public QUITQTY QUITQTY { get; set; }
        public Changerecipeno changeRecipeNo { get; set; }
        public QUITPRICEUNIT QUITPRICEUNIT { get; set; }
        public ORDERID ORDERID { get; set; }
        public AKC228 AKC228 { get; set; }
        public AKE051 AKE051 { get; set; }
        public AKC268 AKC268 { get; set; }
        public ISSELFFLAG ISSELFFLAG { get; set; }
        public EXT1 EXT1 { get; set; }
        public EXT2 EXT2 { get; set; }
        public EXT3 EXT3 { get; set; }
        public HOSSERIAL HOSSERIAL { get; set; }
        public EXT4 EXT4 { get; set; }
        public EXT5 EXT5 { get; set; }
        public DOSEUNIT DOSEUNIT { get; set; }
        public BATCHNO BATCHNO { get; set; }
        public VALIDDATE VALIDDATE { get; set; }
    }

    public class OPB_FEEDETAIL_FEEITEMID
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_ORGCODE
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_REGID
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_RECIPEID
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_SEQNO
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_TRANSTYPE
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_REGDPCD
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_DOCTCODE
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_GROUPID
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_GROUPNAME
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_ITEMID
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_ITEMNAME
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_DRUGFLAG
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_SPECS
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_DOSEMODELCODE
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_FEECODE
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_UNITPRICE
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_QTY
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_DAYS
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_PACKQTY
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_PRICEUNIT
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_TOTCOST
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_OWNCOST
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_PAYCOST
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_PUBCOST
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_EXECDPCD
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_EXECDPNM
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_SICODE
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_ITEMGRADE
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_ITEMSTATUS
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_INVOICEID
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_INVOCODE
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_FEEOPCD
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_FEEDATE
    {
        public int dataType { get; set; }
    }

    public class ITEMTYPE
    {
        public int dataType { get; set; }
    }

    public class INVONAME
    {
        public int dataType { get; set; }
    }

    public class PRINTNO
    {
        public int dataType { get; set; }
    }

    public class DAYS
    {
        public int dataType { get; set; }
    }

    public class SCALRATION
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_SENDFLAG
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_RETURNQTY
    {
        public int dataType { get; set; }
    }

    public class RETURNCOST
    {
        public int dataType { get; set; }
    }

    public class OPB_FEEDETAIL_DRUGTYPE
    {
        public int dataType { get; set; }
    }

    public class QUITQTY
    {
        public int dataType { get; set; }
    }

    public class Changerecipeno
    {
        public int dataType { get; set; }
    }

    public class QUITPRICEUNIT
    {
        public int dataType { get; set; }
    }

    public class ORDERID
    {
        public int dataType { get; set; }
    }

    public class AKC228
    {
        public int dataType { get; set; }
    }

    public class AKE051
    {
        public int dataType { get; set; }
    }

    public class AKC268
    {
        public int dataType { get; set; }
    }

    public class ISSELFFLAG
    {
        public int dataType { get; set; }
    }

    public class EXT1
    {
        public int dataType { get; set; }
    }

    public class EXT2
    {
        public int dataType { get; set; }
    }

    public class EXT3
    {
        public int dataType { get; set; }
    }

    public class HOSSERIAL
    {
        public int dataType { get; set; }
    }

    public class EXT4
    {
        public int dataType { get; set; }
    }

    public class EXT5
    {
        public int dataType { get; set; }
    }

    public class DOSEUNIT
    {
        public int dataType { get; set; }
    }

    public class BATCHNO
    {
        public int dataType { get; set; }
    }

    public class VALIDDATE
    {
        public int dataType { get; set; }
    }

    public class Rowset
    {
        public List<Primary> primary { get; set; }
    }

    public class Primary
    {
        public string OPB_FEEDETAIL_FEEITEMID { get; set; }
        public string OPB_FEEDETAIL_ORGCODE { get; set; }
        public string OPB_FEEDETAIL_REGID { get; set; }
        public string OPB_FEEDETAIL_RECIPEID { get; set; }
        public string OPB_FEEDETAIL_SEQNO { get; set; }
        public string OPB_FEEDETAIL_TRANSTYPE { get; set; }
        public string OPB_FEEDETAIL_REGDPCD { get; set; }
        public string OPB_FEEDETAIL_DOCTCODE { get; set; }
        public object OPB_FEEDETAIL_GROUPID { get; set; }
        public object OPB_FEEDETAIL_GROUPNAME { get; set; }
        public string OPB_FEEDETAIL_ITEMID { get; set; }
        public string OPB_FEEDETAIL_ITEMNAME { get; set; }
        public string OPB_FEEDETAIL_DRUGFLAG { get; set; }
        public string OPB_FEEDETAIL_SPECS { get; set; }
        public string OPB_FEEDETAIL_DOSEMODELCODE { get; set; }
        public string OPB_FEEDETAIL_FEECODE { get; set; }
        public string OPB_FEEDETAIL_UNITPRICE { get; set; }
        public string OPB_FEEDETAIL_QTY { get; set; }
        public string OPB_FEEDETAIL_DAYS { get; set; }
        public string OPB_FEEDETAIL_PACKQTY { get; set; }
        public string OPB_FEEDETAIL_PRICEUNIT { get; set; }
        public string OPB_FEEDETAIL_TOTCOST { get; set; }
        public string OPB_FEEDETAIL_OWNCOST { get; set; }
        public string OPB_FEEDETAIL_PAYCOST { get; set; }
        public string OPB_FEEDETAIL_PUBCOST { get; set; }
        public string OPB_FEEDETAIL_EXECDPCD { get; set; }
        public string OPB_FEEDETAIL_EXECDPNM { get; set; }
        public object OPB_FEEDETAIL_SICODE { get; set; }
        public string OPB_FEEDETAIL_ITEMGRADE { get; set; }
        public string OPB_FEEDETAIL_ITEMSTATUS { get; set; }
        public string OPB_FEEDETAIL_INVOICEID { get; set; }
        public string OPB_FEEDETAIL_INVOCODE { get; set; }
        public string OPB_FEEDETAIL_FEEOPCD { get; set; }
        public string OPB_FEEDETAIL_FEEDATE { get; set; }
        public object ITEMTYPE { get; set; }
        public object INVONAME { get; set; }
        public object PRINTNO { get; set; }
        public object DAYS { get; set; }
        public string SCALRATION { get; set; }
        public string OPB_FEEDETAIL_SENDFLAG { get; set; }
        public object OPB_FEEDETAIL_RETURNQTY { get; set; }
        public object RETURNCOST { get; set; }
        public string OPB_FEEDETAIL_DRUGTYPE { get; set; }
        public object QUITQTY { get; set; }
        public object changeRecipeNo { get; set; }
        public object QUITPRICEUNIT { get; set; }
        public object ORDERID { get; set; }
        public object AKC228 { get; set; }
        public object AKE051 { get; set; }
        public object AKC268 { get; set; }
        public object ISSELFFLAG { get; set; }
        public object EXT1 { get; set; }
        public object EXT2 { get; set; }
        public object EXT3 { get; set; }
        public object HOSSERIAL { get; set; }
        public string EXT4 { get; set; }
        public object EXT5 { get; set; }
        public object DOSEUNIT { get; set; }
        public string BATCHNO { get; set; }
        public object VALIDDATE { get; set; }
    }

}
