/*!   GeneXus C# 15_0_12-126726 on 10/26/2022 20:15:4.63
*/
gx.evt.autoSkip=!1;gx.define("viewtipocliente",!1,function(){var n,t;this.ServerClass="viewtipocliente";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV11LoadAllTabs=gx.fn.getControlValue("vLOADALLTABS");this.AV7SelectedTabCode=gx.fn.getControlValue("vSELECTEDTABCODE");this.AV12TipClientID=gx.fn.getIntegerValue("vTIPCLIENTID",".");this.AV6TabCode=gx.fn.getControlValue("vTABCODE");this.AV12TipClientID=gx.fn.getIntegerValue("vTIPCLIENTID",".");this.AV11LoadAllTabs=gx.fn.getControlValue("vLOADALLTABS");this.AV7SelectedTabCode=gx.fn.getControlValue("vSELECTEDTABCODE")};this.s112_client=function(){(this.AV11LoadAllTabs||this.AV7SelectedTabCode==""||this.AV7SelectedTabCode=="General")&&this.createWebComponent("Generalwc","TipoClienteGeneral",[this.AV12TipClientID]);(this.AV11LoadAllTabs||this.AV7SelectedTabCode=="Clientes")&&this.createWebComponent("Clienteswc","TipoClienteClientesWC",[this.AV12TipClientID])};this.e131e1_client=function(){return this.clearMessages(),this.AV7SelectedTabCode=this.TABContainer.ActivePageControlName,this.AV11LoadAllTabs=!1,this.s112_client(),this.refreshOutputs([{av:"AV7SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{ctrl:"GENERALWC"},{ctrl:"CLIENTESWC"}]),gx.$.Deferred().resolve()};this.e141e2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e151e2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,24,25,27,28,29,32,33,35,36,37];this.GXLastCtrlId=37;this.TABContainer=gx.uc.getNew(this,22,19,"Tab","TABContainer","Tab","TAB");t=this.TABContainer;t.setProp("Enabled","Enabled",!0,"boolean");t.setProp("ActivePage","Activepage","","int");t.setDynProp("ActivePageControlName","Activepagecontrolname","","char");t.setProp("PageCount","Pagecount",2,"num");t.setProp("Class","Class","WWTab","str");t.setProp("HistoryManagement","Historymanagement",!0,"bool");t.setProp("Visible","Visible",!0,"bool");t.setC2ShowFunction(function(n){n.show()});t.addEventHandler("TabChanged",this.e131e1_client);this.setUserControl(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLETOP",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"VIEWTITLE",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"VIEWALL",format:0,grid:0};n[12]={id:12,fld:"",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"TABTABLE_1",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,lvl:0,type:"char",len:50,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"TIPCLIENTDSC",gxz:"Z54TipClientDsc",gxold:"O54TipClientDsc",gxvar:"A54TipClientDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A54TipClientDsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z54TipClientDsc=n)},v2c:function(){gx.fn.setControlValue("TIPCLIENTDSC",gx.O.A54TipClientDsc,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A54TipClientDsc=this.val())},val:function(){return gx.fn.getControlValue("TIPCLIENTDSC")},nac:gx.falseFn};this.declareDomainHdlr(19,function(){});n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[24]={id:24,fld:"GENERAL_TITLE",format:0,grid:0};n[25]={id:25,fld:"",grid:0};n[27]={id:27,fld:"TABLEGENERAL",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"",grid:0};n[32]={id:32,fld:"CLIENTES_TITLE",format:0,grid:0};n[33]={id:33,fld:"",grid:0};n[35]={id:35,fld:"TABLECLIENTES",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};this.A54TipClientDsc="";this.Z54TipClientDsc="";this.O54TipClientDsc="";this.A54TipClientDsc="";this.AV12TipClientID=0;this.AV6TabCode="";this.A4TipClientID=0;this.AV11LoadAllTabs=!1;this.AV7SelectedTabCode="";this.Events={e141e2_client:["ENTER",!0],e151e2_client:["CANCEL",!0],e131e1_client:["TAB.TABCHANGED",!1]};this.EvtParms.REFRESH=[[{av:"AV12TipClientID",fld:"vTIPCLIENTID",pic:"ZZZ9",hsh:!0},{av:"AV6TabCode",fld:"vTABCODE",pic:"",hsh:!0},{av:"A54TipClientDsc",fld:"TIPCLIENTDSC",pic:""}],[]];this.EvtParms.START=[[{av:"AV15Pgmname",fld:"vPGMNAME",pic:""},{av:"A4TipClientID",fld:"TIPCLIENTID",pic:"ZZZ9"},{av:"AV12TipClientID",fld:"vTIPCLIENTID",pic:"ZZZ9",hsh:!0},{av:"A54TipClientDsc",fld:"TIPCLIENTDSC",pic:""},{av:"AV6TabCode",fld:"vTABCODE",pic:"",hsh:!0},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:"AV7SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""}],[{ctrl:"FORM",prop:"Caption"},{av:'gx.fn.getCtrlProperty("VIEWALL","Link")',ctrl:"VIEWALL",prop:"Link"},{av:'gx.fn.getCtrlProperty("VIEWALL","Visible")',ctrl:"VIEWALL",prop:"Visible"},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:"AV7SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"this.TABContainer.ActivePageControlName",ctrl:"TAB",prop:"ActivePageControlName"},{ctrl:"GENERALWC"},{ctrl:"CLIENTESWC"}]];this.EvtParms["TAB.TABCHANGED"]=[[{av:"this.TABContainer.ActivePageControlName",ctrl:"TAB",prop:"ActivePageControlName"},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:"AV7SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"AV12TipClientID",fld:"vTIPCLIENTID",pic:"ZZZ9",hsh:!0}],[{av:"AV7SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{ctrl:"GENERALWC"},{ctrl:"CLIENTESWC"}]];this.setVCMap("AV11LoadAllTabs","vLOADALLTABS",0,"boolean",4,0);this.setVCMap("AV7SelectedTabCode","vSELECTEDTABCODE",0,"char",50,0);this.setVCMap("AV12TipClientID","vTIPCLIENTID",0,"int",4,0);this.setVCMap("AV6TabCode","vTABCODE",0,"char",50,0);this.setVCMap("AV12TipClientID","vTIPCLIENTID",0,"int",4,0);this.setVCMap("AV11LoadAllTabs","vLOADALLTABS",0,"boolean",4,0);this.setVCMap("AV7SelectedTabCode","vSELECTEDTABCODE",0,"char",50,0);this.Initialize();this.setComponent({id:"GENERALWC",GXClass:null,Prefix:"W0030",lvl:1});this.setComponent({id:"CLIENTESWC",GXClass:null,Prefix:"W0038",lvl:1})});gx.createParentObj(viewtipocliente)