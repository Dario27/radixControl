/*!   GeneXus C# 15_0_12-126726 on 10/29/2022 1:7:33.48
*/
gx.evt.autoSkip=!1;gx.define("tipoproducto",!1,function(){this.ServerClass="tipoproducto";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV7EmpID=gx.fn.getIntegerValue("vEMPID",".");this.AV8tipoProdID=gx.fn.getIntegerValue("vTIPOPRODID",".");this.AV12Pgmname=gx.fn.getControlValue("vPGMNAME");this.Gx_mode=gx.fn.getControlValue("vMODE");this.AV10TrnContext=gx.fn.getControlValue("vTRNCONTEXT")};this.Valid_Empid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Empid",["gx.O.A1EmpID","gx.O.A44empdsc"],["A44empdsc"]),!0};this.Valid_Tipoprodid=function(){try{var n=gx.util.balloon.getNew("TIPOPRODID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e120b2_client=function(){return this.executeServerEvent("AFTER TRN",!0,null,!1,!1)};this.e130b25_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e140b25_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64];this.GXLastCtrlId=64;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TITLECONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TITLE",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"FORMCONTAINER",grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"TOOLBARCELL",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"BTN_FIRST",grid:0};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"BTN_PREVIOUS",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"BTN_NEXT",grid:0};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"BTN_LAST",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"BTN_SELECT",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Empid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EMPID",gxz:"Z1EmpID",gxold:"O1EmpID",gxvar:"A1EmpID",ucs:[],op:[39],ip:[39,34],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A1EmpID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1EmpID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("EMPID",gx.O.A1EmpID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A1EmpID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("EMPID",".")},nac:function(){return!(0==this.AV7EmpID)}};this.declareDomainHdlr(34,function(){});n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,lvl:0,type:"svchar",len:100,dec:0,sign:!1,pic:"@!",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EMPDSC",gxz:"Z44empdsc",gxold:"O44empdsc",gxvar:"A44empdsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A44empdsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z44empdsc=n)},v2c:function(){gx.fn.setControlValue("EMPDSC",gx.O.A44empdsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A44empdsc=this.val())},val:function(){return gx.fn.getControlValue("EMPDSC")},nac:gx.falseFn};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Tipoprodid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"TIPOPRODID",gxz:"Z31tipoProdID",gxold:"O31tipoProdID",gxvar:"A31tipoProdID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A31tipoProdID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z31tipoProdID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("TIPOPRODID",gx.O.A31tipoProdID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A31tipoProdID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("TIPOPRODID",".")},nac:function(){return!(0==this.AV8tipoProdID)}};this.declareDomainHdlr(44,function(){});n[45]={id:45,fld:"",grid:0};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,lvl:0,type:"char",len:40,dec:0,sign:!1,pic:"@!",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"TIPOPRODDSC",gxz:"Z144tipoProdDsc",gxold:"O144tipoProdDsc",gxvar:"A144tipoProdDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A144tipoProdDsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z144tipoProdDsc=n)},v2c:function(){gx.fn.setControlValue("TIPOPRODDSC",gx.O.A144tipoProdDsc,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A144tipoProdDsc=this.val())},val:function(){return gx.fn.getControlValue("TIPOPRODDSC")},nac:gx.falseFn};this.declareDomainHdlr(49,function(){});n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"",grid:0};n[53]={id:53,fld:"",grid:0};n[54]={id:54,lvl:0,type:"char",len:1,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"TIPOPRODEST",gxz:"Z145tipoProdEst",gxold:"O145tipoProdEst",gxvar:"A145tipoProdEst",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A145tipoProdEst=n)},v2z:function(n){n!==undefined&&(gx.O.Z145tipoProdEst=n)},v2c:function(){gx.fn.setControlValue("TIPOPRODEST",gx.O.A145tipoProdEst,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A145tipoProdEst=this.val())},val:function(){return gx.fn.getControlValue("TIPOPRODEST")},nac:gx.falseFn};this.declareDomainHdlr(54,function(){});n[55]={id:55,fld:"",grid:0};n[56]={id:56,fld:"",grid:0};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"",grid:0};n[59]={id:59,fld:"BTN_ENTER",grid:0};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"BTN_CANCEL",grid:0};n[62]={id:62,fld:"",grid:0};n[63]={id:63,fld:"BTN_DELETE",grid:0};n[64]={id:64,fld:"PROMPT_1",grid:25};this.A1EmpID=0;this.Z1EmpID=0;this.O1EmpID=0;this.A44empdsc="";this.Z44empdsc="";this.O44empdsc="";this.A31tipoProdID=0;this.Z31tipoProdID=0;this.O31tipoProdID=0;this.A144tipoProdDsc="";this.Z144tipoProdDsc="";this.O144tipoProdDsc="";this.A145tipoProdEst="";this.Z145tipoProdEst="";this.O145tipoProdEst="";this.AV12Pgmname="";this.AV10TrnContext={CallerObject:"",CallerOnDelete:!1,CallerURL:"",TransactionName:"",Attributes:[]};this.AV7EmpID=0;this.AV8tipoProdID=0;this.AV11WebSession={};this.A1EmpID=0;this.A31tipoProdID=0;this.A44empdsc="";this.A144tipoProdDsc="";this.A145tipoProdEst="";this.Gx_mode="";this.Events={e120b2_client:["AFTER TRN",!0],e130b25_client:["ENTER",!0],e140b25_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV7EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{av:"AV8tipoProdID",fld:"vTIPOPRODID",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms.REFRESH=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV7EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{av:"AV8tipoProdID",fld:"vTIPOPRODID",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms.START=[[{av:"AV12Pgmname",fld:"vPGMNAME",pic:""}],[{av:"AV10TrnContext",fld:"vTRNCONTEXT",pic:""}]];this.EvtParms["AFTER TRN"]=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV10TrnContext",fld:"vTRNCONTEXT",pic:""}],[]];this.setPrompt("PROMPT_1",[34]);this.EnterCtrl=["BTN_ENTER"];this.setVCMap("AV7EmpID","vEMPID",0,"int",4,0);this.setVCMap("AV8tipoProdID","vTIPOPRODID",0,"int",4,0);this.setVCMap("AV12Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("Gx_mode","vMODE",0,"char",3,0);this.setVCMap("AV10TrnContext","vTRNCONTEXT",0,"TransactionContext",0,0);this.Initialize()});gx.createParentObj(tipoproducto)