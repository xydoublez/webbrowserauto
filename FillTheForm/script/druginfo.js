

function zyGetDrugData() {
    unieap.byId("si_druginfoid").getBinding().grid.onItemChanged = function () {
        alert("onItemChanged");
    }

    var dic = [
        { "code": "371100", "name": "全部" },
        { "code": "371101", "name": "市辖区" },
        { "code": "371102", "name": "东港" },
        { "code": "371103", "name": "岚山" },
        { "code": "371104", "name": "开发区" },
        { "code": "371121", "name": "五莲" },
        { "code": "371122", "name": "莒县" },
        { "code": "371151", "name": "山海天旅游度假区" }
    ];
    //for (var i = 0; i < dic.length; i++) {
    //    zyGetDrugInfo(dic[0], dic[1]);
    //}
    zyGetDrugInfo(dic[0].code);
}
function zyGetDrugInfo(areaCode) {
    unieap.byId('paykindCodecmb').setValue("03");
    unieap.byId('SI_DRUGINFO_AREACODE').setValue(areaCode);
    //先同步
    zySync();
    query();
    setTimeout(function () {
        zyWriteDrugData();
        //var totalPage = parseInt(dojo.query("[dojoAttachPoint = 'totalPageNoNode']")[0].outerText.substring(1, 4));
        //alert(totalPage);
        //for (var i = 1; i < totalPage; i++) {

        //    dojo.query("[dojoAttachPoint = 'nextImageNode']")[0].click();
        //    while (true) {
        //        if (dojo.query("[dojoAttachPoint='pageNoNode']")[0].value == (i + 1)) {
        //            zyWriteDrugData();
        //            break;
        //        }
        //    }
        //}
        //window.external.OnWriteDrugInfoSucess();
    }, 1000);    
}
function sleep(numberMillis) {
    var now = new Date();
    var exitTime = now.getTime() + numberMillis;
    while (true) {
        now = new Date();
        if (now.getTime() > exitTime)
            return;
    }
}

function zyWriteDrugData() {
    var data = dojo.query('.u-grid-master-views .u-grid-text2');
    var count = dojo.query('.u-grid-master-views .u-grid-text2').length;
    var result = '';
    for (var i = 0; i < count; i += 15) {
        result += data.at(i)[0].outerText + ','
        result += data.at(i + 1)[0].outerText + ','
        result += data.at(i + 2)[0].outerText + ','
        result += data.at(i + 3)[0].outerText + ','
        result += data.at(i + 4)[0].outerText + ','
        result += data.at(i + 5)[0].outerText + ','
        result += data.at(i + 6)[0].outerText + ','
        result += data.at(i + 7)[0].outerText + ','
        result += data.at(i + 8)[0].outerText + ','
        result += data.at(i + 9)[0].outerText + ','
        result += data.at(i + 11)[0].outerText + ','
        result += data.at(i + 12)[0].outerText + ','
        result += data.at(i + 13)[0].outerText + ','
        result += data.at(i + 14)[0].outerText + ','
        result += '$'
    }
    window.external.WriteDrugInfoFile(result);
}
function zySync() {
    var payKindCode = unieap.byId('paykindCodecmb').getValue();
    var district = unieap.byId('SI_DRUGINFO_AREACODE').getValue();
    var httpService = new HttpService();
    httpService.putBusinessRequestId('REQ-ZA-M-051-00');
    httpService.putParameter('itemCode', '01');
    httpService.putParameter('payKindCode', payKindCode);
    httpService.putParameter('district', district);
    //设置成功回调函数
    httpService.addEventListener(unieap.ResultEvent, function () { });
    //设置失败回调函数
    httpService.addEventListener(unieap.FaultEvent, function () { });
    //设置调用的action，以及调用的方法
    httpService.setRequestUrl('SiBusinessDelegateAction', 'execute');
    //发送
    httpService.post();
}
