/*!   GeneXus C# 15_0_12-126726 on 10/29/2022 1:7:44.70
*/
gx.evt.autoSkip=!1;gx.define("prodxbodega",!1,function(){var n,t;this.ServerClass="prodxbodega";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV7stockAnio=gx.fn.getIntegerValue("vSTOCKANIO",".");this.AV8stockMes=gx.fn.getIntegerValue("vSTOCKMES",".");this.AV20mes=gx.fn.getIntegerValue("vMES",".");this.AV9EmpID=gx.fn.getIntegerValue("vEMPID",".");this.AV10AgeID=gx.fn.getIntegerValue("vAGEID",".");this.AV12BodCod=gx.fn.getIntegerValue("vBODCOD",".");this.AV18Insert_TipoInv=gx.fn.getControlValue("vINSERT_TIPOINV");this.AV19tipoInv=gx.fn.getControlValue("vTIPOINV");this.A223TipoInvSigno=gx.fn.getIntegerValue("TIPOINVSIGNO",".");this.AV21Pgmname=gx.fn.getControlValue("vPGMNAME");this.Gx_mode=gx.fn.getControlValue("vMODE");this.AV14TrnContext=gx.fn.getControlValue("vTRNCONTEXT")};this.Valid_Empid=function(){try{var n=gx.util.balloon.getNew("EMPID");this.AnyError=0;this.refreshOutputs([{av:"AV9EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{ctrl:"AGEID"},{av:"A2AgeID",fld:"AGEID",pic:"ZZZ9"},{ctrl:"EMPID"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"}])}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Ageid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Ageid",["gx.O.A1EmpID","gx.O.A2AgeID"],[]),!0};this.Valid_Stockanio=function(){try{var n=gx.util.balloon.getNew("STOCKANIO");this.AnyError=0;this.refreshOutputs([{av:"AV9EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{ctrl:"AGEID"},{av:"A2AgeID",fld:"AGEID",pic:"ZZZ9"},{ctrl:"EMPID"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"}])}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Stockmes=function(){try{var n=gx.util.balloon.getNew("STOCKMES");this.AnyError=0;this.refreshOutputs([{av:"AV9EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{ctrl:"AGEID"},{av:"A2AgeID",fld:"AGEID",pic:"ZZZ9"},{ctrl:"EMPID"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"}])}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Bodcod=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Bodcod",["gx.O.A1EmpID","gx.O.A42BodCod","gx.O.A217BodDsc"],["A217BodDsc"]),!0};this.Valid_Tipoinv=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Tipoinv",["gx.O.A43TipoInv","gx.O.A290stockAnio","gx.O.A291stockMes","gx.O.A1EmpID","gx.O.A2AgeID","gx.O.A42BodCod","gx.O.A219TipoInvMov","gx.O.A223TipoInvSigno","gx.O.A292stockBod","gx.num.urlDecimal(gx.O.A294ingBod,'.',',')","gx.num.urlDecimal(gx.O.A295egrBod,'.',',')"],["A219TipoInvMov","A223TipoInvSigno","A292stockBod","A294ingBod","A295egrBod"]),!0};this.Valid_Stockdetid=function(){try{if(gx.fn.currentGridRowImpl(101)===0)return!0;var n=gx.util.balloon.getNew("STOCKDETID",gx.fn.currentGridRowImpl(101));this.AnyError=0;this.sMode83=this.Gx_mode;this.Gx_mode=gx.fn.getGridRowMode(83,101);this.standaloneModal0U83();this.standaloneNotModal0U83();gx.fn.gridDuplicateKey(102)&&(n.setError(gx.text.format(gx.getMessage("GXM_1004"),"Tipo","","","","","","","","")),this.AnyError=gx.num.trunc(1,0));this.refreshOutputs([{av:"AV9EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{ctrl:"AGEID"},{av:"A2AgeID",fld:"AGEID",pic:"ZZZ9"},{ctrl:"EMPID"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"}])}catch(t){}try{return(this.Gx_mode=this.sMode83,n==null)?!0:n.show()}catch(t){}return!0};this.Valid_Prdcod=function(){try{this.sMode83=this.Gx_mode;this.Gx_mode=gx.fn.getGridRowMode(83,101);gx.ajax.validSrvEvt("dyncall","Valid_Prdcod",["gx.O.A1EmpID","gx.O.A2AgeID","gx.O.A286PrdCod","gx.O.A309prdNombre"],["A309prdNombre"])}finally{this.Gx_mode=this.sMode83}return!0};this.Valid_Cantidad=function(){try{if(gx.fn.currentGridRowImpl(101)===0)return!0;var n=gx.util.balloon.getNew("CANTIDAD",gx.fn.currentGridRowImpl(101));this.AnyError=0;this.sMode83=this.Gx_mode;this.Gx_mode=gx.fn.getGridRowMode(83,101);try{this.A301egrTipo=this.A223TipoInvSigno==-1?gx.num.trunc(this.A296cantidad,0):gx.num.trunc(0,0)}catch(t){}try{this.A295egrBod=gx.fn.sumFrm("A301egrTipo",0,".",",",101,gx.trueFn,[])}catch(t){}try{this.A300ingTipo=this.A223TipoInvSigno==1?gx.num.trunc(this.A296cantidad,0):gx.num.trunc(0,0)}catch(t){}try{this.A294ingBod=gx.fn.sumFrm("A300ingTipo",0,".",",",101,gx.trueFn,[])}catch(t){}this.refreshOutputs([{av:"AV9EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{ctrl:"AGEID"},{av:"A2AgeID",fld:"AGEID",pic:"ZZZ9"},{ctrl:"EMPID"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"}])}catch(t){}try{return(this.Gx_mode=this.sMode83,n==null)?!0:n.show()}catch(t){}return!0};this.Valid_Costo=function(){try{if(gx.fn.currentGridRowImpl(101)===0)return!0;var n=gx.util.balloon.getNew("COSTO",gx.fn.currentGridRowImpl(101));this.AnyError=0;this.sMode83=this.Gx_mode;this.Gx_mode=gx.fn.getGridRowMode(83,101);try{this.A299costUni=this.A296cantidad!=0?gx.num.round(this.A298costo/this.A296cantidad,2):0}catch(t){}this.refreshOutputs([{av:"AV9EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{ctrl:"AGEID"},{av:"A2AgeID",fld:"AGEID",pic:"ZZZ9"},{ctrl:"EMPID"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"}])}catch(t){}try{return(this.Gx_mode=this.sMode83,n==null)?!0:n.show()}catch(t){}return!0};this.Valid_Ingtipo=function(){try{if(gx.fn.currentGridRowImpl(101)===0)return!0;var n=gx.util.balloon.getNew("INGTIPO",gx.fn.currentGridRowImpl(101));this.AnyError=0;this.sMode83=this.Gx_mode;this.Gx_mode=gx.fn.getGridRowMode(83,101);this.refreshOutputs([{av:"AV9EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{ctrl:"AGEID"},{av:"A2AgeID",fld:"AGEID",pic:"ZZZ9"},{ctrl:"EMPID"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"}])}catch(t){}try{return(this.Gx_mode=this.sMode83,n==null)?!0:n.show()}catch(t){}return!0};this.Valid_Egrtipo=function(){try{if(gx.fn.currentGridRowImpl(101)===0)return!0;var n=gx.util.balloon.getNew("EGRTIPO",gx.fn.currentGridRowImpl(101));this.AnyError=0;this.sMode83=this.Gx_mode;this.Gx_mode=gx.fn.getGridRowMode(83,101);this.Gx_mode=="UPD";this.refreshOutputs([{av:"AV9EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{ctrl:"AGEID"},{av:"A2AgeID",fld:"AGEID",pic:"ZZZ9"},{ctrl:"EMPID"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"}])}catch(t){}try{return(this.Gx_mode=this.sMode83,n==null)?!0:n.show()}catch(t){}return!0};this.standaloneModal0U83=function(){try{this.Gx_mode!="INS"?gx.fn.setCtrlProperty("STOCKDETID","Enabled",0):gx.fn.setCtrlProperty("STOCKDETID","Enabled",1)}catch(n){}return!0};this.standaloneNotModal0U83=function(){try{gx.fn.setCtrlProperty("INGTIPO","Enabled",0)}catch(n){}try{gx.fn.setCtrlProperty("EGRTIPO","Enabled",0)}catch(n){}return!0};this.e120u2_client=function(){return this.executeServerEvent("AFTER TRN",!0,null,!1,!1)};this.e130u82_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e140u82_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100,102,103,104,105,106,107,108,109,110,111,112,113,114,115,116,117,118,119,120,121,122];this.GXLastCtrlId=122;this.Gridprodxbodega_tipoContainer=new gx.grid.grid(this,83,"Tipo",101,"Gridprodxbodega_tipo","Gridprodxbodega_tipo","Gridprodxbodega_tipoContainer",this.CmpContext,this.IsMasterPage,"prodxbodega",[348],!1,1,!1,!0,5,!1,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Gridprodxbodega_tipoContainer;t.addSingleLineEdit(348,102,"STOCKDETID","Nro.","","stockDetID","int",0,"px",4,4,"right",null,[],348,"stockDetID",!0,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(286,103,"PRDCOD","ID","","PrdCod","int",0,"px",4,4,"right",null,[],286,"PrdCod",!0,0,!1,!1,"Attribute",1,"");t.addBitmap("prompt_286","PROMPT_286",122,0,"",0,"",null,"","","gx-prompt Image","");t.addSingleLineEdit(309,104,"PRDNOMBRE","Nombre Articulo","","prdNombre","svchar",0,"px",80,80,"left",null,[],309,"prdNombre",!0,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(296,105,"CANTIDAD","cantidad","","cantidad","decimal",0,"px",9,9,"right",null,[],296,"cantidad",!0,2,!1,!1,"Attribute",1,"");t.addSingleLineEdit(297,106,"STOCK","stock","","stock","decimal",0,"px",9,9,"right",null,[],297,"stock",!0,2,!1,!1,"Attribute",1,"");t.addSingleLineEdit(298,107,"COSTO","costo","","costo","decimal",0,"px",13,13,"right",null,[],298,"costo",!0,2,!1,!1,"Attribute",1,"");t.addSingleLineEdit(299,108,"COSTUNI","Unitario","","costUni","decimal",0,"px",13,13,"right",null,[],299,"costUni",!0,2,!1,!1,"Attribute",1,"");t.addSingleLineEdit(300,109,"INGTIPO","Tipo","","ingTipo","int",0,"px",9,9,"right",null,[],300,"ingTipo",!1,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(301,110,"EGRTIPO","Tipo","","egrTipo","int",0,"px",9,9,"right",null,[],301,"egrTipo",!1,0,!1,!1,"Attribute",1,"");this.Gridprodxbodega_tipoContainer.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TITLECONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TITLE",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"FORMCONTAINER",grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"TOOLBARCELL",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"BTN_FIRST",grid:0};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"BTN_PREVIOUS",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"BTN_NEXT",grid:0};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"BTN_LAST",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"BTN_SELECT",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"SECTION1",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Empid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Gridprodxbodega_tipoContainer],fld:"EMPID",gxz:"Z1EmpID",gxold:"O1EmpID",gxvar:"A1EmpID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"dyncombo",v2v:function(n){n!==undefined&&(gx.O.A1EmpID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1EmpID=gx.num.intval(n))},v2c:function(){gx.fn.setComboBoxValue("EMPID",gx.O.A1EmpID);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A1EmpID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("EMPID",".")},nac:function(){return!(0==this.AV9EmpID)}};this.declareDomainHdlr(35,function(){});n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"SECTION2",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"",grid:0};n[40]={id:40,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Ageid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Gridprodxbodega_tipoContainer],fld:"AGEID",gxz:"Z2AgeID",gxold:"O2AgeID",gxvar:"A2AgeID",ucs:[],op:[],ip:[40,35],nacdep:[],ctrltype:"dyncombo",v2v:function(n){n!==undefined&&(gx.O.A2AgeID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z2AgeID=gx.num.intval(n))},v2c:function(){gx.fn.setComboBoxValue("AGEID",gx.O.A2AgeID);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A2AgeID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("AGEID",".")},nac:function(){return!(0==this.AV10AgeID)}};this.declareDomainHdlr(40,function(){});n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"SECTION3",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"",grid:0};n[45]={id:45,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Stockanio,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Gridprodxbodega_tipoContainer],fld:"STOCKANIO",gxz:"Z290stockAnio",gxold:"O290stockAnio",gxvar:"A290stockAnio",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A290stockAnio=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z290stockAnio=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("STOCKANIO",gx.O.A290stockAnio,0)},c2v:function(){this.val()!==undefined&&(gx.O.A290stockAnio=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("STOCKANIO",".")},nac:function(){return!(0==this.AV7stockAnio)}};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"SECTION4",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"",grid:0};n[50]={id:50,lvl:0,type:"int",len:2,dec:0,sign:!1,pic:"Z9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Stockmes,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Gridprodxbodega_tipoContainer],fld:"STOCKMES",gxz:"Z291stockMes",gxold:"O291stockMes",gxvar:"A291stockMes",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.A291stockMes=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z291stockMes=gx.num.intval(n))},v2c:function(){gx.fn.setComboBoxValue("STOCKMES",gx.O.A291stockMes)},c2v:function(){this.val()!==undefined&&(gx.O.A291stockMes=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("STOCKMES",".")},nac:function(){return!(0==this.AV8stockMes)}};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"",grid:0};n[53]={id:53,fld:"",grid:0};n[54]={id:54,fld:"",grid:0};n[55]={id:55,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Bodcod,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Gridprodxbodega_tipoContainer],fld:"BODCOD",gxz:"Z42BodCod",gxold:"O42BodCod",gxvar:"A42BodCod",ucs:[],op:[58],ip:[58,55,35],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A42BodCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z42BodCod=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BODCOD",gx.O.A42BodCod,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A42BodCod=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BODCOD",".")},nac:function(){return!(0==this.AV12BodCod)}};this.declareDomainHdlr(55,function(){});n[56]={id:56,fld:"",grid:0};n[57]={id:57,fld:"",grid:0};n[58]={id:58,lvl:0,type:"char",len:40,dec:0,sign:!1,pic:"@!",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BODDSC",gxz:"Z217BodDsc",gxold:"O217BodDsc",gxvar:"A217BodDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A217BodDsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z217BodDsc=n)},v2c:function(){gx.fn.setControlValue("BODDSC",gx.O.A217BodDsc,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A217BodDsc=this.val())},val:function(){return gx.fn.getControlValue("BODDSC")},nac:gx.falseFn};this.declareDomainHdlr(58,function(){});n[59]={id:59,fld:"",grid:0};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"",grid:0};n[63]={id:63,lvl:0,type:"char",len:4,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Tipoinv,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Gridprodxbodega_tipoContainer],fld:"TIPOINV",gxz:"Z43TipoInv",gxold:"O43TipoInv",gxvar:"A43TipoInv",ucs:[],op:[92,87,76,66],ip:[92,87,76,66,55,40,35,50,45,63],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A43TipoInv=n)},v2z:function(n){n!==undefined&&(gx.O.Z43TipoInv=n)},v2c:function(){gx.fn.setControlValue("TIPOINV",gx.O.A43TipoInv,0)},c2v:function(){this.val()!==undefined&&(gx.O.A43TipoInv=this.val())},val:function(){return gx.fn.getControlValue("TIPOINV")},nac:function(){return this.Gx_mode=="INS"&&!(""==this.AV18Insert_TipoInv)}};n[64]={id:64,fld:"",grid:0};n[65]={id:65,fld:"",grid:0};n[66]={id:66,lvl:0,type:"svchar",len:60,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"TIPOINVMOV",gxz:"Z219TipoInvMov",gxold:"O219TipoInvMov",gxvar:"A219TipoInvMov",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A219TipoInvMov=n)},v2z:function(n){n!==undefined&&(gx.O.Z219TipoInvMov=n)},v2c:function(){gx.fn.setControlValue("TIPOINVMOV",gx.O.A219TipoInvMov,0)},c2v:function(){this.val()!==undefined&&(gx.O.A219TipoInvMov=this.val())},val:function(){return gx.fn.getControlValue("TIPOINVMOV")},nac:gx.falseFn};n[67]={id:67,fld:"",grid:0};n[68]={id:68,fld:"",grid:0};n[69]={id:69,fld:"",grid:0};n[70]={id:70,fld:"",grid:0};n[71]={id:71,lvl:0,type:"svchar",len:80,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PRDSTOCKDSC",gxz:"Z307prdStockDsc",gxold:"O307prdStockDsc",gxvar:"A307prdStockDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A307prdStockDsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z307prdStockDsc=n)},v2c:function(){gx.fn.setControlValue("PRDSTOCKDSC",gx.O.A307prdStockDsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A307prdStockDsc=this.val())},val:function(){return gx.fn.getControlValue("PRDSTOCKDSC")},nac:gx.falseFn};n[72]={id:72,fld:"",grid:0};n[73]={id:73,fld:"",grid:0};n[74]={id:74,fld:"",grid:0};n[75]={id:75,fld:"",grid:0};n[76]={id:76,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"STOCKBOD",gxz:"Z292stockBod",gxold:"O292stockBod",gxvar:"A292stockBod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A292stockBod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z292stockBod=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("STOCKBOD",gx.O.A292stockBod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A292stockBod=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("STOCKBOD",".")},nac:gx.falseFn};n[77]={id:77,fld:"",grid:0};n[78]={id:78,fld:"",grid:0};n[79]={id:79,fld:"",grid:0};n[80]={id:80,fld:"",grid:0};n[81]={id:81,lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"INVFISICO",gxz:"Z293invFisico",gxold:"O293invFisico",gxvar:"A293invFisico",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A293invFisico=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z293invFisico=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("INVFISICO",gx.O.A293invFisico,0)},c2v:function(){this.val()!==undefined&&(gx.O.A293invFisico=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("INVFISICO",".")},nac:gx.falseFn};n[82]={id:82,fld:"",grid:0};n[83]={id:83,fld:"",grid:0};n[84]={id:84,fld:"SECTION5",grid:0};n[85]={id:85,fld:"",grid:0};n[86]={id:86,fld:"",grid:0};n[87]={id:87,lvl:0,type:"decimal",len:9,dec:2,sign:!1,pic:"ZZZZZ9.99",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"INGBOD",gxz:"Z294ingBod",gxold:"O294ingBod",gxvar:"A294ingBod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A294ingBod=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z294ingBod=gx.fn.toDecimalValue(n,".",","))},v2c:function(){gx.fn.setDecimalValue("INGBOD",gx.O.A294ingBod,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A294ingBod=this.val())},val:function(){return gx.fn.getDecimalValue("INGBOD",".",",")},nac:gx.falseFn};n[88]={id:88,fld:"",grid:0};n[89]={id:89,fld:"SECTION6",grid:0};n[90]={id:90,fld:"",grid:0};n[91]={id:91,fld:"",grid:0};n[92]={id:92,lvl:0,type:"decimal",len:9,dec:2,sign:!1,pic:"ZZZZZ9.99",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EGRBOD",gxz:"Z295egrBod",gxold:"O295egrBod",gxvar:"A295egrBod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A295egrBod=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z295egrBod=gx.fn.toDecimalValue(n,".",","))},v2c:function(){gx.fn.setDecimalValue("EGRBOD",gx.O.A295egrBod,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A295egrBod=this.val())},val:function(){return gx.fn.getDecimalValue("EGRBOD",".",",")},nac:gx.falseFn};n[93]={id:93,fld:"",grid:0};n[94]={id:94,fld:"",grid:0};n[95]={id:95,fld:"TIPOTABLE",grid:0};n[96]={id:96,fld:"",grid:0};n[97]={id:97,fld:"",grid:0};n[98]={id:98,fld:"TITLETIPO",format:0,grid:0};n[99]={id:99,fld:"",grid:0};n[100]={id:100,fld:"",grid:0};n[102]={id:102,lvl:83,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,isacc:1,grid:101,gxgrid:this.Gridprodxbodega_tipoContainer,fnc:this.Valid_Stockdetid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"STOCKDETID",gxz:"Z348stockDetID",gxold:"O348stockDetID",gxvar:"A348stockDetID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A348stockDetID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z348stockDetID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("STOCKDETID",n||gx.fn.currentGridRowImpl(101),gx.O.A348stockDetID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A348stockDetID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("STOCKDETID",n||gx.fn.currentGridRowImpl(101),".")},nac:gx.falseFn};n[103]={id:103,lvl:83,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,isacc:1,grid:101,gxgrid:this.Gridprodxbodega_tipoContainer,fnc:this.Valid_Prdcod,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PRDCOD",gxz:"Z286PrdCod",gxold:"O286PrdCod",gxvar:"A286PrdCod",ucs:[],op:[104],ip:[104,103,40,35],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A286PrdCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z286PrdCod=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("PRDCOD",n||gx.fn.currentGridRowImpl(101),gx.O.A286PrdCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A286PrdCod=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("PRDCOD",n||gx.fn.currentGridRowImpl(101),".")},nac:gx.falseFn};n[104]={id:104,lvl:83,type:"svchar",len:80,dec:0,sign:!1,ro:1,isacc:1,grid:101,gxgrid:this.Gridprodxbodega_tipoContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PRDNOMBRE",gxz:"Z309prdNombre",gxold:"O309prdNombre",gxvar:"A309prdNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A309prdNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z309prdNombre=n)},v2c:function(n){gx.fn.setGridControlValue("PRDNOMBRE",n||gx.fn.currentGridRowImpl(101),gx.O.A309prdNombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.A309prdNombre=this.val())},val:function(n){return gx.fn.getGridControlValue("PRDNOMBRE",n||gx.fn.currentGridRowImpl(101))},nac:gx.falseFn};n[105]={id:105,lvl:83,type:"decimal",len:9,dec:2,sign:!1,pic:"ZZZZZ9.99",ro:0,isacc:1,grid:101,gxgrid:this.Gridprodxbodega_tipoContainer,fnc:this.Valid_Cantidad,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CANTIDAD",gxz:"Z296cantidad",gxold:"O296cantidad",gxvar:"A296cantidad",ucs:[],op:[87,109,92,110],ip:[87,92,109,110,105],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A296cantidad=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z296cantidad=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("CANTIDAD",n||gx.fn.currentGridRowImpl(101),gx.O.A296cantidad,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A296cantidad=this.val())},val:function(n){return gx.fn.getGridDecimalValue("CANTIDAD",n||gx.fn.currentGridRowImpl(101),".",",")},nac:gx.falseFn};n[106]={id:106,lvl:83,type:"decimal",len:9,dec:2,sign:!1,pic:"ZZZZZ9.99",ro:0,isacc:1,grid:101,gxgrid:this.Gridprodxbodega_tipoContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"STOCK",gxz:"Z297stock",gxold:"O297stock",gxvar:"A297stock",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A297stock=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z297stock=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("STOCK",n||gx.fn.currentGridRowImpl(101),gx.O.A297stock,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A297stock=this.val())},val:function(n){return gx.fn.getGridDecimalValue("STOCK",n||gx.fn.currentGridRowImpl(101),".",",")},nac:gx.falseFn};n[107]={id:107,lvl:83,type:"decimal",len:10,dec:2,sign:!1,pic:"ZZ,ZZZ,ZZZ.ZZ",ro:0,isacc:1,grid:101,gxgrid:this.Gridprodxbodega_tipoContainer,fnc:this.Valid_Costo,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"COSTO",gxz:"Z298costo",gxold:"O298costo",gxvar:"A298costo",ucs:[],op:[108],ip:[108,105,107],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A298costo=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z298costo=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("COSTO",n||gx.fn.currentGridRowImpl(101),gx.O.A298costo,2,",");typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A298costo=this.val())},val:function(n){return gx.fn.getGridDecimalValue("COSTO",n||gx.fn.currentGridRowImpl(101),".",",")},nac:gx.falseFn};n[108]={id:108,lvl:83,type:"decimal",len:10,dec:2,sign:!1,pic:"ZZ,ZZZ,ZZZ.ZZ",ro:1,isacc:1,grid:101,gxgrid:this.Gridprodxbodega_tipoContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"COSTUNI",gxz:"Z299costUni",gxold:"O299costUni",gxvar:"A299costUni",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A299costUni=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z299costUni=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("COSTUNI",n||gx.fn.currentGridRowImpl(101),gx.O.A299costUni,2,",");typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A299costUni=this.val())},val:function(n){return gx.fn.getGridDecimalValue("COSTUNI",n||gx.fn.currentGridRowImpl(101),".",",")},nac:gx.falseFn};n[109]={id:109,lvl:83,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:1,grid:101,gxgrid:this.Gridprodxbodega_tipoContainer,fnc:this.Valid_Ingtipo,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"INGTIPO",gxz:"Z300ingTipo",gxold:"O300ingTipo",gxvar:"A300ingTipo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A300ingTipo=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z300ingTipo=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("INGTIPO",n||gx.fn.currentGridRowImpl(101),gx.O.A300ingTipo,0)},c2v:function(){this.val()!==undefined&&(gx.O.A300ingTipo=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("INGTIPO",n||gx.fn.currentGridRowImpl(101),".")},nac:gx.falseFn};n[110]={id:110,lvl:83,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:1,grid:101,gxgrid:this.Gridprodxbodega_tipoContainer,fnc:this.Valid_Egrtipo,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EGRTIPO",gxz:"Z301egrTipo",gxold:"O301egrTipo",gxvar:"A301egrTipo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A301egrTipo=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z301egrTipo=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("EGRTIPO",n||gx.fn.currentGridRowImpl(101),gx.O.A301egrTipo,0)},c2v:function(){this.val()!==undefined&&(gx.O.A301egrTipo=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("EGRTIPO",n||gx.fn.currentGridRowImpl(101),".")},nac:gx.falseFn};n[111]={id:111,fld:"",grid:0};n[112]={id:112,fld:"",grid:0};n[113]={id:113,fld:"",grid:0};n[114]={id:114,fld:"",grid:0};n[115]={id:115,fld:"BTN_ENTER",grid:0};n[116]={id:116,fld:"",grid:0};n[117]={id:117,fld:"BTN_CANCEL",grid:0};n[118]={id:118,fld:"",grid:0};n[119]={id:119,fld:"BTN_DELETE",grid:0};n[120]={id:120,fld:"PROMPT_1_42",grid:82};n[121]={id:121,fld:"PROMPT_43",grid:82};n[122]={id:122,fld:"PROMPT_286",grid:83};this.A1EmpID=0;this.Z1EmpID=0;this.O1EmpID=0;this.A2AgeID=0;this.Z2AgeID=0;this.O2AgeID=0;this.A290stockAnio=0;this.Z290stockAnio=0;this.O290stockAnio=0;this.A291stockMes=0;this.Z291stockMes=0;this.O291stockMes=0;this.A42BodCod=0;this.Z42BodCod=0;this.O42BodCod=0;this.A217BodDsc="";this.Z217BodDsc="";this.O217BodDsc="";this.A43TipoInv="";this.Z43TipoInv="";this.O43TipoInv="";this.A219TipoInvMov="";this.Z219TipoInvMov="";this.O219TipoInvMov="";this.A307prdStockDsc="";this.Z307prdStockDsc="";this.O307prdStockDsc="";this.A292stockBod=0;this.Z292stockBod=0;this.O292stockBod=0;this.A293invFisico=0;this.Z293invFisico=0;this.O293invFisico=0;this.A294ingBod=0;this.Z294ingBod=0;this.O294ingBod=0;this.A295egrBod=0;this.Z295egrBod=0;this.O295egrBod=0;this.Z348stockDetID=0;this.O348stockDetID=0;this.Z286PrdCod=0;this.O286PrdCod=0;this.Z309prdNombre="";this.O309prdNombre="";this.Z296cantidad=0;this.O296cantidad=0;this.Z297stock=0;this.O297stock=0;this.Z298costo=0;this.O298costo=0;this.Z299costUni=0;this.O299costUni=0;this.Z300ingTipo=0;this.O300ingTipo=0;this.Z301egrTipo=0;this.O301egrTipo=0;this.A348stockDetID=0;this.A286PrdCod=0;this.A309prdNombre="";this.A296cantidad=0;this.A297stock=0;this.A298costo=0;this.A299costUni=0;this.A300ingTipo=0;this.A301egrTipo=0;this.AV21Pgmname="";this.AV14TrnContext={CallerObject:"",CallerOnDelete:!1,CallerURL:"",TransactionName:"",Attributes:[]};this.AV18Insert_TipoInv="";this.AV22GXV1=0;this.AV17TrnContextAtt={AttributeName:"",AttributeValue:""};this.AV7stockAnio=0;this.AV8stockMes=0;this.AV9EmpID=0;this.AV10AgeID=0;this.AV12BodCod=0;this.AV19tipoInv="";this.AV15WebSession={};this.A290stockAnio=0;this.A291stockMes=0;this.A1EmpID=0;this.A2AgeID=0;this.A42BodCod=0;this.A43TipoInv="";this.AV20mes=0;this.A217BodDsc="";this.A219TipoInvMov="";this.A223TipoInvSigno=0;this.A307prdStockDsc="";this.A292stockBod=0;this.A293invFisico=0;this.A294ingBod=0;this.A295egrBod=0;this.Gx_mode="";this.Events={e120u2_client:["AFTER TRN",!0],e130u82_client:["ENTER",!0],e140u82_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV7stockAnio",fld:"vSTOCKANIO",pic:"ZZZ9",hsh:!0},{av:"AV8stockMes",fld:"vSTOCKMES",pic:"Z9",hsh:!0},{av:"AV10AgeID",fld:"vAGEID",pic:"ZZZ9",hsh:!0},{av:"AV12BodCod",fld:"vBODCOD",pic:"ZZZ9",hsh:!0},{av:"AV19tipoInv",fld:"vTIPOINV",pic:"",hsh:!0},{av:"AV9EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{ctrl:"AGEID"},{av:"A2AgeID",fld:"AGEID",pic:"ZZZ9"},{ctrl:"EMPID"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"}],[{av:"AV9EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{ctrl:"AGEID"},{av:"A2AgeID",fld:"AGEID",pic:"ZZZ9"},{ctrl:"EMPID"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"}]];this.EvtParms.REFRESH=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV7stockAnio",fld:"vSTOCKANIO",pic:"ZZZ9",hsh:!0},{av:"AV8stockMes",fld:"vSTOCKMES",pic:"Z9",hsh:!0},{av:"AV10AgeID",fld:"vAGEID",pic:"ZZZ9",hsh:!0},{av:"AV12BodCod",fld:"vBODCOD",pic:"ZZZ9",hsh:!0},{av:"AV19tipoInv",fld:"vTIPOINV",pic:"",hsh:!0},{av:"AV18Insert_TipoInv",fld:"vINSERT_TIPOINV",pic:""},{av:"AV9EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{ctrl:"AGEID"},{av:"A2AgeID",fld:"AGEID",pic:"ZZZ9"},{ctrl:"EMPID"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"}],[{av:"AV9EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{ctrl:"AGEID"},{av:"A2AgeID",fld:"AGEID",pic:"ZZZ9"},{ctrl:"EMPID"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"}]];this.EvtParms.START=[[{av:"AV21Pgmname",fld:"vPGMNAME",pic:""},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV9EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{ctrl:"AGEID"},{av:"A2AgeID",fld:"AGEID",pic:"ZZZ9"},{ctrl:"EMPID"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"}],[{av:"AV14TrnContext",fld:"vTRNCONTEXT",pic:""},{av:"AV18Insert_TipoInv",fld:"vINSERT_TIPOINV",pic:""},{av:"AV22GXV1",fld:"vGXV1",pic:"99999999"},{av:"AV17TrnContextAtt",fld:"vTRNCONTEXTATT",pic:""},{av:"AV9EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{ctrl:"AGEID"},{av:"A2AgeID",fld:"AGEID",pic:"ZZZ9"},{ctrl:"EMPID"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"}]];this.EvtParms["AFTER TRN"]=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV14TrnContext",fld:"vTRNCONTEXT",pic:""},{av:"AV9EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{ctrl:"AGEID"},{av:"A2AgeID",fld:"AGEID",pic:"ZZZ9"},{ctrl:"EMPID"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"}],[{av:"AV9EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{ctrl:"AGEID"},{av:"A2AgeID",fld:"AGEID",pic:"ZZZ9"},{ctrl:"EMPID"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"}]];this.setPrompt("PROMPT_1_42",[35,55]);this.setPrompt("PROMPT_43",[63]);this.setPrompt("PROMPT_286",[103]);this.EnterCtrl=["BTN_ENTER"];this.setVCMap("AV7stockAnio","vSTOCKANIO",0,"int",4,0);this.setVCMap("AV8stockMes","vSTOCKMES",0,"int",2,0);this.setVCMap("AV20mes","vMES",0,"int",2,0);this.setVCMap("AV9EmpID","vEMPID",0,"int",4,0);this.setVCMap("AV10AgeID","vAGEID",0,"int",4,0);this.setVCMap("AV12BodCod","vBODCOD",0,"int",4,0);this.setVCMap("AV18Insert_TipoInv","vINSERT_TIPOINV",0,"char",4,0);this.setVCMap("AV19tipoInv","vTIPOINV",0,"char",4,0);this.setVCMap("A223TipoInvSigno","TIPOINVSIGNO",0,"int",2,0);this.setVCMap("AV21Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("Gx_mode","vMODE",0,"char",3,0);this.setVCMap("AV14TrnContext","vTRNCONTEXT",0,"TransactionContext",0,0);t.addPostingVar({rfrVar:"Gx_mode"});this.Initialize();this.LvlOlds[82]=["O295egrBod","O294ingBod"];this.LvlOlds[83]=["O301egrTipo","O300ingTipo"]});gx.createParentObj(prodxbodega)