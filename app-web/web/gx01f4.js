/*!   GeneXus C# 15_0_12-126726 on 10/26/2022 20:18:26.38
*/
gx.evt.autoSkip=!1;gx.define("gx01f4",!1,function(){var n,t;this.ServerClass="gx01f4";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV9pEmpID=gx.fn.getIntegerValue("vPEMPID",".");this.AV10pAgeID=gx.fn.getIntegerValue("vPAGEID",".");this.AV11pBodCod=gx.fn.getIntegerValue("vPBODCOD",".");this.AV12pinvCod=gx.fn.getIntegerValue("vPINVCOD",".");this.AV13pdetInvId=gx.fn.getIntegerValue("vPDETINVID",".");this.AV9pEmpID=gx.fn.getIntegerValue("vPEMPID",".");this.AV10pAgeID=gx.fn.getIntegerValue("vPAGEID",".");this.AV11pBodCod=gx.fn.getIntegerValue("vPBODCOD",".");this.AV12pinvCod=gx.fn.getIntegerValue("vPINVCOD",".")};this.e145b1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e115b1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("DETINVIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("DETINVIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCDETINVID","Visible",!0)):(gx.fn.setCtrlProperty("DETINVIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCDETINVID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("DETINVIDFILTERCONTAINER","Class")',ctrl:"DETINVIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCDETINVID","Visible")',ctrl:"vCDETINVID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e125b1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("DETINVCANTFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("DETINVCANTFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCDETINVCANT","Visible",!0)):(gx.fn.setCtrlProperty("DETINVCANTFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCDETINVCANT","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("DETINVCANTFILTERCONTAINER","Class")',ctrl:"DETINVCANTFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCDETINVCANT","Visible")',ctrl:"vCDETINVCANT",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e135b1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("DETINVCOSTOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("DETINVCOSTOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCDETINVCOSTO","Visible",!0)):(gx.fn.setCtrlProperty("DETINVCOSTOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCDETINVCOSTO","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("DETINVCOSTOFILTERCONTAINER","Class")',ctrl:"DETINVCOSTOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCDETINVCOSTO","Visible")',ctrl:"vCDETINVCOSTO",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e175b2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e185b1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,45,46,47,48,49,50,51,52,53,54,55,56,57];this.GXLastCtrlId=57;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",44,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx01f4",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",45,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(273,46,"DETINVID","Inv Id","","detInvId","int",0,"px",4,4,"right",null,[],273,"detInvId",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(274,47,"DETINVCANT","Cantidad","","detInvCant","int",0,"px",8,8,"right",null,[],274,"detInvCant",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(275,48,"DETINVCOSTO","Inv","","detInvCosto","decimal",0,"px",8,8,"right",null,[],275,"detInvCosto",!0,2,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(286,49,"PRDCOD","ID","","PrdCod","int",0,"px",4,4,"right",null,[],286,"PrdCod",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(341,50,"DETINVUNICOD","Uni Cod","","detInvUniCod","char",0,"px",3,3,"left",null,[],341,"detInvUniCod",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(1,51,"EMPID","Emp ID","","EmpID","int",0,"px",4,4,"right",null,[],1,"EmpID",!1,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(2,52,"AGEID","Age ID","","AgeID","int",0,"px",4,4,"right",null,[],2,"AgeID",!1,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(42,53,"BODCOD","Bod Cod","","BodCod","int",0,"px",4,4,"right",null,[],42,"BodCod",!1,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(264,54,"INVCOD","inv Cod","","invCod","int",0,"px",4,4,"right",null,[],264,"invCod",!1,0,!1,!1,"Attribute",1,"");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"DETINVIDFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLDETINVIDFILTER",format:1,grid:0,evt:"e115b1_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCDETINVID",gxz:"ZV6cdetInvId",gxold:"OV6cdetInvId",gxvar:"AV6cdetInvId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cdetInvId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cdetInvId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCDETINVID",gx.O.AV6cdetInvId,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cdetInvId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCDETINVID",".")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"DETINVCANTFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLDETINVCANTFILTER",format:1,grid:0,evt:"e125b1_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"int",len:8,dec:0,sign:!1,pic:"ZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCDETINVCANT",gxz:"ZV7cdetInvCant",gxold:"OV7cdetInvCant",gxvar:"AV7cdetInvCant",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cdetInvCant=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV7cdetInvCant=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCDETINVCANT",gx.O.AV7cdetInvCant,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cdetInvCant=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCDETINVCANT",".")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"DETINVCOSTOFILTERCONTAINER",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"LBLDETINVCOSTOFILTER",format:1,grid:0,evt:"e135b1_client"};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,lvl:0,type:"decimal",len:8,dec:2,sign:!1,pic:"ZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCDETINVCOSTO",gxz:"ZV8cdetInvCosto",gxold:"OV8cdetInvCosto",gxvar:"AV8cdetInvCosto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cdetInvCosto=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.ZV8cdetInvCosto=gx.fn.toDecimalValue(n,".",","))},v2c:function(){gx.fn.setDecimalValue("vCDETINVCOSTO",gx.O.AV8cdetInvCosto,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.AV8cdetInvCosto=this.val())},val:function(){return gx.fn.getDecimalValue("vCDETINVCOSTO",".",",")},nac:gx.falseFn};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"GRIDTABLE",grid:0};n[39]={id:39,fld:"",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"BTNTOGGLE",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[45]={id:45,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(44),gx.O.AV5LinkSelection,gx.O.AV17Linkselection_GXI)},c2v:function(){gx.O.AV17Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(44))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(44))},gxvar_GXI:"AV17Linkselection_GXI",nac:gx.falseFn};n[46]={id:46,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DETINVID",gxz:"Z273detInvId",gxold:"O273detInvId",gxvar:"A273detInvId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A273detInvId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z273detInvId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("DETINVID",n||gx.fn.currentGridRowImpl(44),gx.O.A273detInvId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A273detInvId=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("DETINVID",n||gx.fn.currentGridRowImpl(44),".")},nac:gx.falseFn};n[47]={id:47,lvl:2,type:"int",len:8,dec:0,sign:!1,pic:"ZZZZZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DETINVCANT",gxz:"Z274detInvCant",gxold:"O274detInvCant",gxvar:"A274detInvCant",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A274detInvCant=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z274detInvCant=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("DETINVCANT",n||gx.fn.currentGridRowImpl(44),gx.O.A274detInvCant,0)},c2v:function(){this.val()!==undefined&&(gx.O.A274detInvCant=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("DETINVCANT",n||gx.fn.currentGridRowImpl(44),".")},nac:gx.falseFn};n[48]={id:48,lvl:2,type:"decimal",len:8,dec:2,sign:!1,pic:"ZZZZ9.99",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DETINVCOSTO",gxz:"Z275detInvCosto",gxold:"O275detInvCosto",gxvar:"A275detInvCosto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A275detInvCosto=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z275detInvCosto=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("DETINVCOSTO",n||gx.fn.currentGridRowImpl(44),gx.O.A275detInvCosto,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A275detInvCosto=this.val())},val:function(n){return gx.fn.getGridDecimalValue("DETINVCOSTO",n||gx.fn.currentGridRowImpl(44),".",",")},nac:gx.falseFn};n[49]={id:49,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PRDCOD",gxz:"Z286PrdCod",gxold:"O286PrdCod",gxvar:"A286PrdCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A286PrdCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z286PrdCod=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("PRDCOD",n||gx.fn.currentGridRowImpl(44),gx.O.A286PrdCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A286PrdCod=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("PRDCOD",n||gx.fn.currentGridRowImpl(44),".")},nac:gx.falseFn};n[50]={id:50,lvl:2,type:"char",len:3,dec:0,sign:!1,ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DETINVUNICOD",gxz:"Z341detInvUniCod",gxold:"O341detInvUniCod",gxvar:"A341detInvUniCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A341detInvUniCod=n)},v2z:function(n){n!==undefined&&(gx.O.Z341detInvUniCod=n)},v2c:function(n){gx.fn.setGridControlValue("DETINVUNICOD",n||gx.fn.currentGridRowImpl(44),gx.O.A341detInvUniCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A341detInvUniCod=this.val())},val:function(n){return gx.fn.getGridControlValue("DETINVUNICOD",n||gx.fn.currentGridRowImpl(44))},nac:gx.falseFn};n[51]={id:51,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EMPID",gxz:"Z1EmpID",gxold:"O1EmpID",gxvar:"A1EmpID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A1EmpID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1EmpID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("EMPID",n||gx.fn.currentGridRowImpl(44),gx.O.A1EmpID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A1EmpID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("EMPID",n||gx.fn.currentGridRowImpl(44),".")},nac:gx.falseFn};n[52]={id:52,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"AGEID",gxz:"Z2AgeID",gxold:"O2AgeID",gxvar:"A2AgeID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A2AgeID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z2AgeID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("AGEID",n||gx.fn.currentGridRowImpl(44),gx.O.A2AgeID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A2AgeID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("AGEID",n||gx.fn.currentGridRowImpl(44),".")},nac:gx.falseFn};n[53]={id:53,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BODCOD",gxz:"Z42BodCod",gxold:"O42BodCod",gxvar:"A42BodCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A42BodCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z42BodCod=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("BODCOD",n||gx.fn.currentGridRowImpl(44),gx.O.A42BodCod,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A42BodCod=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("BODCOD",n||gx.fn.currentGridRowImpl(44),".")},nac:gx.falseFn};n[54]={id:54,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"INVCOD",gxz:"Z264invCod",gxold:"O264invCod",gxvar:"A264invCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A264invCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z264invCod=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("INVCOD",n||gx.fn.currentGridRowImpl(44),gx.O.A264invCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A264invCod=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("INVCOD",n||gx.fn.currentGridRowImpl(44),".")},nac:gx.falseFn};n[55]={id:55,fld:"",grid:0};n[56]={id:56,fld:"",grid:0};n[57]={id:57,fld:"BTN_CANCEL",grid:0};this.AV6cdetInvId=0;this.ZV6cdetInvId=0;this.OV6cdetInvId=0;this.AV7cdetInvCant=0;this.ZV7cdetInvCant=0;this.OV7cdetInvCant=0;this.AV8cdetInvCosto=0;this.ZV8cdetInvCosto=0;this.OV8cdetInvCosto=0;this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z273detInvId=0;this.O273detInvId=0;this.Z274detInvCant=0;this.O274detInvCant=0;this.Z275detInvCosto=0;this.O275detInvCosto=0;this.Z286PrdCod=0;this.O286PrdCod=0;this.Z341detInvUniCod="";this.O341detInvUniCod="";this.Z1EmpID=0;this.O1EmpID=0;this.Z2AgeID=0;this.O2AgeID=0;this.Z42BodCod=0;this.O42BodCod=0;this.Z264invCod=0;this.O264invCod=0;this.AV6cdetInvId=0;this.AV7cdetInvCant=0;this.AV8cdetInvCosto=0;this.AV9pEmpID=0;this.AV10pAgeID=0;this.AV11pBodCod=0;this.AV12pinvCod=0;this.AV13pdetInvId=0;this.AV5LinkSelection="";this.A273detInvId=0;this.A274detInvCant=0;this.A275detInvCosto=0;this.A286PrdCod=0;this.A341detInvUniCod="";this.A1EmpID=0;this.A2AgeID=0;this.A42BodCod=0;this.A264invCod=0;this.Events={e175b2_client:["ENTER",!0],e185b1_client:["CANCEL",!0],e145b1_client:["'TOGGLE'",!1],e115b1_client:["LBLDETINVIDFILTER.CLICK",!1],e125b1_client:["LBLDETINVCANTFILTER.CLICK",!1],e135b1_client:["LBLDETINVCOSTOFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cdetInvId",fld:"vCDETINVID",pic:"ZZZ9"},{av:"AV7cdetInvCant",fld:"vCDETINVCANT",pic:"ZZZZZZZ9"},{av:"AV8cdetInvCosto",fld:"vCDETINVCOSTO",pic:"ZZZZ9.99"},{av:"AV9pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV10pAgeID",fld:"vPAGEID",pic:"ZZZ9"},{av:"AV11pBodCod",fld:"vPBODCOD",pic:"ZZZ9"},{av:"AV12pinvCod",fld:"vPINVCOD",pic:"ZZZ9"}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLDETINVIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("DETINVIDFILTERCONTAINER","Class")',ctrl:"DETINVIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("DETINVIDFILTERCONTAINER","Class")',ctrl:"DETINVIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCDETINVID","Visible")',ctrl:"vCDETINVID",prop:"Visible"}]];this.EvtParms["LBLDETINVCANTFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("DETINVCANTFILTERCONTAINER","Class")',ctrl:"DETINVCANTFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("DETINVCANTFILTERCONTAINER","Class")',ctrl:"DETINVCANTFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCDETINVCANT","Visible")',ctrl:"vCDETINVCANT",prop:"Visible"}]];this.EvtParms["LBLDETINVCOSTOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("DETINVCOSTOFILTERCONTAINER","Class")',ctrl:"DETINVCOSTOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("DETINVCOSTOFILTERCONTAINER","Class")',ctrl:"DETINVCOSTOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCDETINVCOSTO","Visible")',ctrl:"vCDETINVCOSTO",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A273detInvId",fld:"DETINVID",pic:"ZZZ9",hsh:!0}],[{av:"AV13pdetInvId",fld:"vPDETINVID",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cdetInvId",fld:"vCDETINVID",pic:"ZZZ9"},{av:"AV7cdetInvCant",fld:"vCDETINVCANT",pic:"ZZZZZZZ9"},{av:"AV8cdetInvCosto",fld:"vCDETINVCOSTO",pic:"ZZZZ9.99"},{av:"AV9pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV10pAgeID",fld:"vPAGEID",pic:"ZZZ9"},{av:"AV11pBodCod",fld:"vPBODCOD",pic:"ZZZ9"},{av:"AV12pinvCod",fld:"vPINVCOD",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cdetInvId",fld:"vCDETINVID",pic:"ZZZ9"},{av:"AV7cdetInvCant",fld:"vCDETINVCANT",pic:"ZZZZZZZ9"},{av:"AV8cdetInvCosto",fld:"vCDETINVCOSTO",pic:"ZZZZ9.99"},{av:"AV9pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV10pAgeID",fld:"vPAGEID",pic:"ZZZ9"},{av:"AV11pBodCod",fld:"vPBODCOD",pic:"ZZZ9"},{av:"AV12pinvCod",fld:"vPINVCOD",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cdetInvId",fld:"vCDETINVID",pic:"ZZZ9"},{av:"AV7cdetInvCant",fld:"vCDETINVCANT",pic:"ZZZZZZZ9"},{av:"AV8cdetInvCosto",fld:"vCDETINVCOSTO",pic:"ZZZZ9.99"},{av:"AV9pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV10pAgeID",fld:"vPAGEID",pic:"ZZZ9"},{av:"AV11pBodCod",fld:"vPBODCOD",pic:"ZZZ9"},{av:"AV12pinvCod",fld:"vPINVCOD",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cdetInvId",fld:"vCDETINVID",pic:"ZZZ9"},{av:"AV7cdetInvCant",fld:"vCDETINVCANT",pic:"ZZZZZZZ9"},{av:"AV8cdetInvCosto",fld:"vCDETINVCOSTO",pic:"ZZZZ9.99"},{av:"AV9pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV10pAgeID",fld:"vPAGEID",pic:"ZZZ9"},{av:"AV11pBodCod",fld:"vPBODCOD",pic:"ZZZ9"},{av:"AV12pinvCod",fld:"vPINVCOD",pic:"ZZZ9"}],[]];this.setVCMap("AV9pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV10pAgeID","vPAGEID",0,"int",4,0);this.setVCMap("AV11pBodCod","vPBODCOD",0,"int",4,0);this.setVCMap("AV12pinvCod","vPINVCOD",0,"int",4,0);this.setVCMap("AV13pdetInvId","vPDETINVID",0,"int",4,0);this.setVCMap("AV9pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV10pAgeID","vPAGEID",0,"int",4,0);this.setVCMap("AV11pBodCod","vPBODCOD",0,"int",4,0);this.setVCMap("AV12pinvCod","vPINVCOD",0,"int",4,0);this.setVCMap("AV9pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV10pAgeID","vPAGEID",0,"int",4,0);this.setVCMap("AV11pBodCod","vPBODCOD",0,"int",4,0);this.setVCMap("AV12pinvCod","vPINVCOD",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar({rfrVar:"AV9pEmpID"});t.addRefreshingVar({rfrVar:"AV10pAgeID"});t.addRefreshingVar({rfrVar:"AV11pBodCod"});t.addRefreshingVar({rfrVar:"AV12pinvCod"});this.Initialize()});gx.createParentObj(gx01f4)