//lzq
//var jsonInfo = {
//    "queryCodeTxt": "0000008569",
//    "patientNameTxt": "马立花",
//    "sexcmb": "女",
//    "ageTxt": "67",
//    "freeCost": "0.00",
//    "cmbPayKind": "医保",
//    "mcardNoTxt": "",
//    "medicalTypeCmb": "11",
//    "diagnoseCmb": "",
//    "deptCmb": "",
//    "docCmb": "",
//    "patientFeeItemlist": {
//        "pageSize": 10,
//        "pageNumber": 1,
//        "recordCount": 109,
//        "name": "dsItemlist",
//        "rowSetName": "ncm.ipb.IPB_ITEMLIST",
//        "condition": null,
//        "parameters": [
//            [
//                "214667460",
//                "12"
//            ]
//        ],
//        "context": {
//            "BUSINESS_ID": "",
//            "BUSINESS_REQUEST_ID": "",
//            "CUSTOMVPDPARA": ""
//        },
//        "metaData": {
//            "BILLID": {
//                "dataType": 12
//            },
//            "CANCELDATE": {
//                "dataType": 12
//            },
//            "CANCELOPCD": {
//                "dataType": 12
//            },
//            "CHARGEID": {
//                "dataType": 12
//            },
//            "DAYS": {
//                "dataType": 12
//            },
//            "DOCTCODE": {
//                "dataType": 12
//            },
//            "DOSEMODELCODE": {
//                "dataType": 12
//            },
//            "DOSEUNIT": {
//                "dataType": 12
//            },
//            "DRUGTYPE": {
//                "dataType": 12
//            },
//            "EXT3": {
//                "dataType": 12
//            },
//            "EXT2": {
//                "dataType": 12
//            },
//            "EXEDEPTCODE": {
//                "dataType": 12
//            },
//            "FAKEBILLID": {
//                "dataType": 3
//            },
//            "FEECODE": {
//                "dataType": 12
//            },
//            "FEEDATE": {
//                "dataType": 12
//            },
//            "FEEOPCD": {
//                "dataType": 12
//            },
//            "GROUPID": {
//                "dataType": 12
//            },
//            "GROUPNAME": {
//                "dataType": 12
//            },
//            "INDEPTCODE": {
//                "dataType": 12
//            },
//            "INID": {
//                "dataType": 12
//            },
//            "INVOCODE": {
//                "dataType": 12
//            },
//            "ISDRUG": {
//                "dataType": 12
//            },
//            "ITEMGRADE": {
//                "dataType": 12
//            },
//            "ITEMID": {
//                "dataType": 12
//            },
//            "ITEMNAME": {
//                "dataType": 12
//            },
//            "ITEMSTATUS": {
//                "dataType": 12
//            },
//            "ORGCODE": {
//                "dataType": 12
//            },
//            "OWNCOST": {
//                "dataType": 3
//            },
//            "PACKQTY": {
//                "dataType": 3
//            },
//            "PAYCOST": {
//                "dataType": 3
//            },
//            "PRICEUNIT": {
//                "dataType": 12
//            },
//            "PUBCOST": {
//                "dataType": 3
//            },
//            "QTY": {
//                "dataType": 3
//            },
//            "SCALRATION": {
//                "dataType": 3
//            },
//            "SENDFLAG": {
//                "dataType": 12
//            },
//            "SICODE": {
//                "dataType": 12
//            },
//            "SPECS": {
//                "dataType": 12
//            },
//            "TOTCOST": {
//                "dataType": 3
//            },
//            "UNITPRICE": {
//                "dataType": 3
//            },
//            "UPLOADFLAG": {
//                "dataType": 12
//            },
//            "VALIDQTY": {
//                "dataType": 3
//            },
//            "VALIDDATE": {
//                "dataType": 91
//            },
//            "BATCHNO": {
//                "dataType": 12
//            }
//        },
//        "rowSet": {
//            "primary": [
//                {
//                    "BILLID": "",
//                    "CANCELDATE": "",
//                    "CANCELOPCD": "",
//                    "CHARGEID": "",
//                    "DAYS": "",
//                    "DOCTCODE": "001",
//                    "DOSEMODELCODE": "",
//                    "DOSEUNIT": "",
//                    "DRUGTYPE": "",
//                    "EXT3": "",
//                    "EXT2": "",
//                    "EXEDEPTCODE": "",
//                    "FAKEBILLID": "1",
//                    "FEECODE": "",
//                    "FEEDATE": "",
//                    "FEEOPCD": "001",
//                    "GROUPID": "",
//                    "GROUPNAME": "",
//                    "INDEPTCODE": "",
//                    "INID": "",
//                    "INVOCODE": "",
//                    "ISDRUG": "0",
//                    "ITEMGRADE": "1",
//                    "ITEMID": "11090001",
//                    "ITEMNAME": "一级医院普通床位费",
//                    "ITEMSTATUS": "1",
//                    "ORGCODE": "51049064",
//                    "OWNCOST": "10.00",
//                    "PACKQTY": "0",
//                    "PAYCOST": "0",
//                    "PRICEUNIT": "天",
//                    "PUBCOST": "0",
//                    "QTY": "1.00",
//                    "SCALRATION": "1",
//                    "SENDFLAG": "0",
//                    "SICODE": "",
//                    "SPECS": "",
//                    "TOTCOST": "10.00",
//                    "UNITPRICE": "10.0000",
//                    "UPLOADFLAG": "",
//                    "VALIDQTY": "1",
//                    "VALIDDATE": null,
//                    "BATCHNO": ""
//                }
//            ]
//        }
//    }
//};
//lzqaddjs
function zyInAutoFeePrice() {
    var feeChargePriceJson = eval('(' + jsonInfo + ')');
    setTimeout(function () {
        clearScreen();
        //1基本信息赋值
        unieap.byId('PATIENTNO').setValue(feeChargePriceJson.queryCodeTxt);
        queryInPatientInfoEx();
        bindFymx(feeChargePriceJson);

    }, 1000);

}
function zyInProcNext(idcard) {
    //调用C#的中方法获取信息，处理下一个
    setTimeout(function () {
        var json = window.external.getFeePriceInfoJson(idcard);
        zyInAutoFeePrice(json);
    }, 1000);
}
function bindFymx(feeChargePriceJson) {

    //2费用明细赋值
    var rowSet = dsItemlist.getRowSet();

    dsItemlist.getRowSet().reset();

    var patientFeeItemlist = feeChargePriceJson.patientFeeItemlist;
    dsItemlist.rowSet.primary = feeChargePriceJson.patientFeeItemlist.rowSet.primary;
    dsItemlist.addMetaData('meta', patientFeeItemlist.metaData);
    var rowCount = dsItemlist.getRowSet().getRowCount()
    for (var i = 0; i < rowCount; i++) {
        try {
            var exeDept = dsInPatientInfo.getRowSet().getRow(0).getItemValue("EXEDEPTCODE");
            if (exeDept == null) {
                exeDept = unieap.byId("DEPTCODE").getValue();
            }
            var feeCode = dsItemlist.getRowSet().getRow(i).getItemValue("FEECODE");
            dsItemlist.getRowSet().getRow(i).setItemValue('INVOCODE', feeCode);
            dsItemlist.getRowSet().getRow(i).setItemValue('INVOCODE', feeCode);
            dsItemlist.getRowSet().getRow(i).setItemValue('EXEDEPTCODE', exeDept);
            dsItemlist.getRowSet().getRow(i).setItemValue('INDEPTCODE', exeDept);
            dsItemlist.getRowSet().getRow(i).setItemValue('ORGCODE', orgcode); //医疗机构编码 
            dsItemlist.getRowSet().getRow(i).setItemValue('FAKEBILLID', i + 1);

        } catch (e) {
        }

        //如果药品
        if (dsItemlist.getRowSet().getRow(i).getItemValue('ISDRUG') == "1") {
            getStockListEx(dsItemlist.getRowSet().getRow(i).getItemValue('ITEMID'));
            try {
                dsItemlist.getRowSet().getRow(i).setItemValue('BATCHNO', dsStockList.getRowSet().getItemValue(0, "BATCHNO", "primary"));
            } catch (e) {
            }
        }

    }
    unieap.byId('patientFeeItemlistGrid').getBinding().setDataStore(dsItemlist);
    setTimeout(function () {
        reBindFymx();
    }, 50);

}
//重新绑定，获取相关必须的字段数据
function reBindFymx() {
    var rowCount = dsItemlist.getRowSet().getRowCount();
    for (var i = 0; i < rowCount; i++) {
        //设置可编辑状态
        unieap.byId("patientFeeItemlistGrid").getManager("EditManager").setEdit(i, "ITEMNAME");
        //触发按键事件，弹出字典列表
        dojo.query("#patientFeeItemlistGrid .u-form-textbox-input")[1].fireEvent("onkeyup")
        //双击字典列表的第一个选项
        dojo.query("#itemList .u-grid-row-table")[1].fireEvent("ondblclick")
    }

}
function sleep_ex(numberMillis) {
    var now = new Date();
    var exitTime = now.getTime() + numberMillis;
    while (true) {
        now = new Date();
        if (now.getTime() > exitTime)
            return;
    }
}

/* 通过药品编码获取该药品库存明细信息 */
function getStockListEx(drugId) {
    //定义httpService代理
    var httpService = new HttpService();
    //设置业务编号（即interaction编号）
    httpService.putBusinessRequestId("REQ-ZA-M-063-00");
    //设置传递的参数，药品id
    if (drugId == null || drugId == "") {
        //messagebox("请选择一条药品信息!", "211");
        return false;
    }

    httpService.putParameter("drugId", drugId);
    httpService.putParameter("storeCode", unieap.byId("DEPTCODE").getValue());
    httpService.putParameter("outputType", "5");
    httpService.setSync(true);
    //设置成功回调函数
    httpService.addEventListener(unieap.ResultEvent, getStockListResultEx);
    //设置失败回调函数
    //httpService.addEventListener(unieap.FaultEvent, getStockListError);
    //设置调用的action，以及调用的方法 	
    httpService.setRequestUrl("SiBusinessDelegateAction", "execute");
    //发送
    httpService.post();
}
/* 获取库存明细信息成功回调函数 */
function getStockListResultEx(dc) {
    debugger;
    //如果dataCenterObj不等于0，则标识查询失败	
    if (dc.getCode() != "0") {
        //messagebox(dc.getDetail(), "111");
        return;
    }

    //获取从后台传来的查询结果
    //药品库存信息列表
    dsStockList = dc.getDataStore("dsStockList");
    //获取用户当前编辑的行
    var currIndex = unieap.byId("patientFeeItemlistGrid").getManager("SelectionManager").getSelectedRowIndexs()[0];

    //判断用户选择的药品是否有库存
    if (dsStockList.getRowSet() == null || dsStockList.getRowSet().getRowCount() == 0) {
        //messagebox("该药品不存在库存明细记录或库存为0，请确认!", "111");
        unieap.byId("patientFeeItemlistGrid").getManager("EditManager").setEdit(currIndex, "OPB_FEEDETAIL_ITEMNAME");
        return false;
    }

    //获取用户选择的药品的库存状态
    var validState = dsStockList.getRowSet().getItemValue(0, "VALIDSTATE", "primary");
    //如果该药品已经停用了，则提示用户
    if (validState == "0") {
        //messagebox("该药品已经停用，不能出库!", "111");
        unieap.byId("patientFeeItemlistGrid").getManager("EditManager").setEdit(currIndex, "OPB_FEEDETAIL_ITEMNAME");
        return false;
    }

    //保存药品库存明细信息ds
    //设置map对象的键值
    var key = dsStockList.getRowSet().getItemValue(0, "DRUGID", "primary");
}


function queryInPatientInfoEx() {
    //	debugger;
    // 获取用户输入的住院号
    var code = unieap.byId("PATIENTNO").getText();
    // 给住院号补零
    code = pad(code, 10);
    unieap.byId("PATIENTNO").setText(code);
    // 以住院号和所属组织机构为条件，检索住院患者信息
    var httpService = new HttpService();
    httpService.putBusinessRequestId("REQ-ZA-M-001-00");
    var searchFiler = "";
    searchFiler = "ORGCODE=? AND PATIENTNO = ? ";

    //add tmpDs
    var dsQueryByID = new unieap.ds.DataStore("dsQueryByID");
    dsQueryByID.setRowSetName("ncm.ipr.IPR_INPATIENTINFO");

    dsQueryByID.resetCondition();
    dsQueryByID.setCondition(searchFiler);
    // 设置组织机构号
    dsQueryByID.insertConditionValue(orgcode, unieap.DATATYPES.STRING, 0);
    // 设置住院号
    dsQueryByID.insertConditionValue(code, unieap.DATATYPES.STRING, 0);
    httpService.putDataStore(dsQueryByID);
    httpService.addEventListener(unieap.ResultEvent, getQueryInPatientResultEx);
    //httpService.addEventListener(unieap.FaultEvent, getError);
    httpService.setSync(true);
    httpService.setRequestUrl("SiBusinessDelegateAction", "execute");
    httpService.post();
    dojo.stopEvent(event);
}
function getQueryInPatientResultEx(dc) {
    //	debugger;
    if (dc.getCode() != "0") {
        messagebox(dc.getDetail(), "211");
        unieap.byId("PATIENTNO").focus();
        return;
    }

    //住院患者信息byID
    var dsQueryByIDResult = dc.getDataStore("dsQueryByID")

    // 没有检索到数据的情况。    
    if (dsQueryByIDResult.getRowSet().getRowCount() == 0) {
        //messagebox("没有该患者的住院信息，请重新输入。", "111");
        unieap.byId("PATIENTNO").focus();
        return;
    }
    //2011 8 19 caoxue 添加  ： 如果返回结果为1条记录，则不执行form绑定、患者关张判断
    if (dsQueryByIDResult.getRowSet().getRowCount() == 1) {
        bindingPatientInfoDSEx(dsQueryByIDResult);
    }
}
function bindingPatientInfoDSEx(dsTemp) {
    //将唯一的患者信息的dstemp传入全局ds
    dsInPatientInfo.getRowSet().reset();
    dsInPatientInfo.getRowSet().addRow(dojo.clone(dsTemp.getRowSet().getRow(0).getData()));
    //重新绑定——否则ds中有值、但并未附到regform上
    unieap.byId('regForm').getBinding().bind(dsInPatientInfo.getRowSet().getRow(0));
    // 检索到的住院患者已关账的情况。
    if (dsInPatientInfo.getRowSet().getRow(0).getItemValue("STOPFLAG") == 1) {
        //messagebox("该患者已关账,请稍后操作。", "111");
        unieap.byId("PATIENTNO").focus();
        return;
    }
    if (alertCheckFlg == "0") {
        setPatientInfoResutltPage();
    } else {
        //默认为 提示 警戒线 —— DB无AlertFree或取不到都视为默认有提示
        if (Number(dsInPatientInfo.getRowSet().getRow(0).getItemValue("FREECOST")) - Number(dsInPatientInfo.getRowSet().getRow(0).getItemValue("ALERTCOST")) < 0) {
            checkFreeCost(1);
        } else {
            //2011-9-5 cx mod ：将方法移至setPatientInfoResutltPage()
            setPatientInfoResutltPage();
        }
    }
}