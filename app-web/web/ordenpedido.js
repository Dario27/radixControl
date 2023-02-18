/*!   GeneXus C# 15_0_12-126726 on 11/19/2022 22:53:10.97
*/
gx.evt.autoSkip=!1;gx.define("ordenpedido",!1,function(){var n,t;this.ServerClass="ordenpedido";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV10EmpID=gx.fn.getIntegerValue("vEMPID",".");this.AV7PedCod=gx.fn.getIntegerValue("vPEDCOD",".");this.Gx_BScreen=gx.fn.getIntegerValue("vGXBSCREEN",".");this.AV11fecha=gx.fn.getDateValue("vFECHA");this.AV24Pgmname=gx.fn.getControlValue("vPGMNAME");this.Gx_mode=gx.fn.getControlValue("vMODE");this.A31tipoProdID=gx.fn.getIntegerValue("TIPOPRODID",".");this.AV20TrnContext=gx.fn.getControlValue("vTRNCONTEXT")};this.Valid_Empid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Empid",["gx.O.A1EmpID","gx.O.A44empdsc"],["A44empdsc"]),!0};this.Valid_Pedcod=function(){try{var n=gx.util.balloon.getNew("PEDCOD");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Pedfchreg=function(){try{var n=gx.util.balloon.getNew("PEDFCHREG");if(this.AnyError=0,!(new gx.date.gxdate("").compare(this.A205PedFchReg)==0||new gx.date.gxdate(this.A205PedFchReg).compare(gx.date.ymdtod(1753,01,01))>=0))try{n.setError("Campo Fecha Registro fuera de rango");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Pedultnro=function(){try{var n=gx.util.balloon.getNew("PEDULTNRO");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Opidsec=function(){try{if(gx.fn.currentGridRowImpl(73)===0)return!0;var n=gx.util.balloon.getNew("OPIDSEC",gx.fn.currentGridRowImpl(73));this.AnyError=0;this.sMode33=this.Gx_mode;this.Gx_mode=gx.fn.getGridRowMode(33,73);this.standaloneModal0D33();this.standaloneNotModal0D33();gx.fn.gridDuplicateKey(74)&&(n.setError(gx.text.format(gx.getMessage("GXM_1004"),"OPId","","","","","","","","")),this.AnyError=gx.num.trunc(1,0))}catch(t){}try{return(this.Gx_mode=this.sMode33,n==null)?!0:n.show()}catch(t){}return!0};this.Valid_Dettipoprodid=function(){try{this.sMode33=this.Gx_mode;this.Gx_mode=gx.fn.getGridRowMode(33,73);gx.ajax.validSrvEvt("dyncall","Valid_Dettipoprodid",["gx.O.A1EmpID","gx.O.A36detTipoProdID"],[])}finally{this.Gx_mode=this.sMode33}return!0};this.Valid_Categid=function(){try{this.sMode33=this.Gx_mode;this.Gx_mode=gx.fn.getGridRowMode(33,73);gx.ajax.validSrvEvt("dyncall","Valid_Categid",["gx.O.A1EmpID","gx.O.A32categID","gx.O.A146categDsc"],["A146categDsc"])}finally{this.Gx_mode=this.sMode33}return!0};this.Valid_Subcatid=function(){try{this.sMode33=this.Gx_mode;this.Gx_mode=gx.fn.getGridRowMode(33,73);gx.ajax.validSrvEvt("dyncall","Valid_Subcatid",["gx.O.A1EmpID","gx.O.A32categID","gx.O.A33subCatID","gx.O.A148subCatDsc","gx.num.urlDecimal(gx.O.A150subCatPrec,'.',',')","gx.num.urlDecimal(gx.O.A151subCatPeso,'.',',')","gx.O.A211subCatDisp"],["A148subCatDsc","A150subCatPrec","A151subCatPeso","A211subCatDisp"])}finally{this.Gx_mode=this.sMode33}return!0};this.Valid_Subcatdisp=function(){try{if(gx.fn.currentGridRowImpl(73)===0)return!0;var n=gx.util.balloon.getNew("SUBCATDISP",gx.fn.currentGridRowImpl(73));this.AnyError=0;this.sMode33=this.Gx_mode;this.Gx_mode=gx.fn.getGridRowMode(33,73)}catch(t){}try{return(this.Gx_mode=this.sMode33,n==null)?!0:n.show()}catch(t){}return!0};this.Valid_Cantdetped=function(){try{if(gx.fn.currentGridRowImpl(73)===0)return!0;var n=gx.util.balloon.getNew("CANTDETPED",gx.fn.currentGridRowImpl(73));this.AnyError=0;this.sMode33=this.Gx_mode;this.Gx_mode=gx.fn.getGridRowMode(33,73);try{this.A214PedDetSaldo=gx.num.round(this.A211subCatDisp-this.A212cantDetPed,0)}catch(t){}}catch(t){}try{return(this.Gx_mode=this.sMode33,n==null)?!0:n.show()}catch(t){}return!0};this.Valid_Cantdetaped=function(){try{if(gx.fn.currentGridRowImpl(73)===0)return!0;var n=gx.util.balloon.getNew("CANTDETAPED",gx.fn.currentGridRowImpl(73));this.AnyError=0;this.sMode33=this.Gx_mode;this.Gx_mode=gx.fn.getGridRowMode(33,73);try{this.A216PedTotal=this.A213cantDetaPed}catch(t){}}catch(t){}try{return(this.Gx_mode=this.sMode33,n==null)?!0:n.show()}catch(t){}return!0};this.standaloneModal0D33=function(){return this.A207PedUltNro=gx.num.trunc(gx.fn.serialRule("A207PedUltNro","A40OPIdSec",73,1,this),0),!0};this.standaloneNotModal0D33=function(){try{gx.fn.setCtrlProperty("OPIDSEC","Enabled",0)}catch(n){}try{gx.fn.setCtrlProperty("PEDULTNRO","Enabled",0)}catch(n){}try{gx.fn.setCtrlProperty("PEDULTNRO","Enabled",0)}catch(n){}return!0};this.e120d2_client=function(){return this.executeServerEvent("AFTER TRN",!0,null,!1,!1)};this.e130d32_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e140d32_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99];this.GXLastCtrlId=99;this.Gridordenpedido_opidContainer=new gx.grid.grid(this,33,"OPId",73,"Gridordenpedido_opid","Gridordenpedido_opid","Gridordenpedido_opidContainer",this.CmpContext,this.IsMasterPage,"ordenpedido",[40],!1,1,!1,!0,5,!1,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Gridordenpedido_opidContainer;t.addSingleLineEdit(40,74,"OPIDSEC","Nro","","OPIdSec","int",50,"px",8,8,"right",null,[],40,"OPIdSec",!0,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(36,75,"DETTIPOPRODID","Tipo","","detTipoProdID","int",0,"px",4,4,"right",null,[],36,"detTipoProdID",!0,0,!1,!1,"Attribute",1,"");t.addBitmap("prompt_36","PROMPT_36",97,0,"",0,"",null,"","","gx-prompt Image","");t.addSingleLineEdit(32,76,"CATEGID","Codigo","","categID","int",0,"px",4,4,"right",null,[],32,"categID",!0,0,!1,!1,"Attribute",1,"");t.addBitmap("prompt_32","PROMPT_32",98,0,"",0,"",null,"","","gx-prompt Image","");t.addSingleLineEdit(146,77,"CATEGDSC","Categoria","","categDsc","char",0,"px",40,40,"left",null,[],146,"categDsc",!0,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(33,78,"SUBCATID","CodSub.","","subCatID","int",0,"px",4,4,"right",null,[],33,"subCatID",!0,0,!1,!1,"Attribute",1,"");t.addBitmap("prompt_33","PROMPT_33",99,0,"",0,"",null,"","","gx-prompt Image","");t.addSingleLineEdit(148,79,"SUBCATDSC","Producto","","subCatDsc","char",0,"px",40,40,"left",null,[],148,"subCatDsc",!0,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(150,80,"SUBCATPREC","Precio","","subCatPrec","decimal",0,"px",8,8,"right",null,[],150,"subCatPrec",!0,2,!1,!1,"Attribute",1,"");t.addSingleLineEdit(151,81,"SUBCATPESO","Peso","","subCatPeso","decimal",0,"px",8,8,"right",null,[],151,"subCatPeso",!0,2,!1,!1,"Attribute",1,"");t.addSingleLineEdit(211,82,"SUBCATDISP","Stock","","subCatDisp","int",0,"px",8,8,"right",null,[],211,"subCatDisp",!0,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(212,83,"CANTDETPED","cantidad","","cantDetPed","decimal",0,"px",8,8,"right",null,[],212,"cantDetPed",!0,2,!1,!1,"Attribute",1,"");t.addSingleLineEdit(214,84,"PEDDETSALDO","Saldo","","PedDetSaldo","decimal",0,"px",9,9,"right",null,[],214,"PedDetSaldo",!0,2,!1,!1,"Attribute",1,"");t.addSingleLineEdit(213,85,"CANTDETAPED","a Pedir","","cantDetaPed","decimal",0,"px",8,8,"right",null,[],213,"cantDetaPed",!0,2,!1,!1,"Attribute",1,"");t.addSingleLineEdit(216,86,"PEDTOTAL","Total","","PedTotal","decimal",0,"px",8,8,"right",null,[],216,"PedTotal",!0,2,!1,!1,"Attribute",1,"");this.Gridordenpedido_opidContainer.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TITLECONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TITLE",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"FORMCONTAINER",grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"TOOLBARCELL",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"BTN_FIRST",grid:0};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"BTN_PREVIOUS",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"BTN_NEXT",grid:0};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"BTN_LAST",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"BTN_SELECT",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Empid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Gridordenpedido_opidContainer],fld:"EMPID",gxz:"Z1EmpID",gxold:"O1EmpID",gxvar:"A1EmpID",ucs:[],op:[39],ip:[39,34],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A1EmpID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1EmpID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("EMPID",gx.O.A1EmpID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A1EmpID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("EMPID",".")},nac:function(){return!(0==this.AV10EmpID)}};this.declareDomainHdlr(34,function(){});n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,lvl:0,type:"svchar",len:100,dec:0,sign:!1,pic:"@!",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EMPDSC",gxz:"Z44empdsc",gxold:"O44empdsc",gxvar:"A44empdsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A44empdsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z44empdsc=n)},v2c:function(){gx.fn.setControlValue("EMPDSC",gx.O.A44empdsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A44empdsc=this.val())},val:function(){return gx.fn.getControlValue("EMPDSC")},nac:gx.falseFn};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,lvl:0,type:"int",len:8,dec:0,sign:!1,pic:"ZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Pedcod,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Gridordenpedido_opidContainer],fld:"PEDCOD",gxz:"Z39PedCod",gxold:"O39PedCod",gxvar:"A39PedCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A39PedCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z39PedCod=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("PEDCOD",gx.O.A39PedCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A39PedCod=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("PEDCOD",".")},nac:function(){return!(0==this.AV7PedCod)}};n[45]={id:45,fld:"",grid:0};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,lvl:0,type:"char",len:50,dec:0,sign:!1,ro:0,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PEDDESCRIPCION",gxz:"Z204PedDescripcion",gxold:"O204PedDescripcion",gxvar:"A204PedDescripcion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A204PedDescripcion=n)},v2z:function(n){n!==undefined&&(gx.O.Z204PedDescripcion=n)},v2c:function(){gx.fn.setControlValue("PEDDESCRIPCION",gx.O.A204PedDescripcion,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A204PedDescripcion=this.val())},val:function(){return gx.fn.getControlValue("PEDDESCRIPCION")},nac:gx.falseFn};this.declareDomainHdlr(49,function(){});n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"",grid:0};n[53]={id:53,fld:"",grid:0};n[54]={id:54,lvl:0,type:"date",len:10,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Pedfchreg,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PEDFCHREG",gxz:"Z205PedFchReg",gxold:"O205PedFchReg",gxvar:"A205PedFchReg",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/9999",dec:0},ucs:[],op:[54],ip:[54],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A205PedFchReg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z205PedFchReg=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("PEDFCHREG",gx.O.A205PedFchReg,0)},c2v:function(){this.val()!==undefined&&(gx.O.A205PedFchReg=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("PEDFCHREG")},nac:gx.falseFn};n[55]={id:55,fld:"",grid:0};n[56]={id:56,fld:"",grid:0};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"",grid:0};n[59]={id:59,lvl:0,type:"char",len:1,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PEDEST",gxz:"Z206PedEst",gxold:"O206PedEst",gxvar:"A206PedEst",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",v2v:function(n){n!==undefined&&(gx.O.A206PedEst=n)},v2z:function(n){n!==undefined&&(gx.O.Z206PedEst=n)},v2c:function(){gx.fn.setCheckBoxValue("PEDEST",gx.O.A206PedEst,"A");typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A206PedEst=this.val())},val:function(){return gx.fn.getControlValue("PEDEST")},nac:gx.falseFn,values:["A","I"]};this.declareDomainHdlr(59,function(){});n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"",grid:0};n[63]={id:63,fld:"",grid:0};n[64]={id:64,lvl:0,type:"int",len:8,dec:0,sign:!1,pic:"ZZZZZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Pedultnro,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PEDULTNRO",gxz:"Z207PedUltNro",gxold:"O207PedUltNro",gxvar:"A207PedUltNro",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A207PedUltNro=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z207PedUltNro=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("PEDULTNRO",gx.O.A207PedUltNro,0)},c2v:function(){this.val()!==undefined&&(gx.O.A207PedUltNro=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("PEDULTNRO",".")},nac:gx.falseFn};n[65]={id:65,fld:"",grid:0};n[66]={id:66,fld:"",grid:0};n[67]={id:67,fld:"OPIDTABLE",grid:0};n[68]={id:68,fld:"",grid:0};n[69]={id:69,fld:"",grid:0};n[70]={id:70,fld:"TITLEOPID",format:0,grid:0};n[71]={id:71,fld:"",grid:0};n[72]={id:72,fld:"",grid:0};n[74]={id:74,lvl:33,type:"int",len:8,dec:0,sign:!1,pic:"ZZZZZZZ9",ro:1,isacc:1,grid:73,gxgrid:this.Gridordenpedido_opidContainer,fnc:this.Valid_Opidsec,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"OPIDSEC",gxz:"Z40OPIdSec",gxold:"O40OPIdSec",gxvar:"A40OPIdSec",ucs:[],op:[74,64],ip:[74,64],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A40OPIdSec=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z40OPIdSec=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("OPIDSEC",n||gx.fn.currentGridRowImpl(73),gx.O.A40OPIdSec,0)},c2v:function(){this.val()!==undefined&&(gx.O.A40OPIdSec=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("OPIDSEC",n||gx.fn.currentGridRowImpl(73),".")},nac:gx.falseFn};n[75]={id:75,lvl:33,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,isacc:1,grid:73,gxgrid:this.Gridordenpedido_opidContainer,fnc:this.Valid_Dettipoprodid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DETTIPOPRODID",gxz:"Z36detTipoProdID",gxold:"O36detTipoProdID",gxvar:"A36detTipoProdID",ucs:[],op:[],ip:[75,34],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A36detTipoProdID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z36detTipoProdID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("DETTIPOPRODID",n||gx.fn.currentGridRowImpl(73),gx.O.A36detTipoProdID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A36detTipoProdID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("DETTIPOPRODID",n||gx.fn.currentGridRowImpl(73),".")},nac:gx.falseFn};n[76]={id:76,lvl:33,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,isacc:1,grid:73,gxgrid:this.Gridordenpedido_opidContainer,fnc:this.Valid_Categid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CATEGID",gxz:"Z32categID",gxold:"O32categID",gxvar:"A32categID",ucs:[],op:[77],ip:[77,76,34],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A32categID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z32categID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("CATEGID",n||gx.fn.currentGridRowImpl(73),gx.O.A32categID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A32categID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("CATEGID",n||gx.fn.currentGridRowImpl(73),".")},nac:gx.falseFn};n[77]={id:77,lvl:33,type:"char",len:40,dec:0,sign:!1,pic:"@!",ro:1,isacc:1,grid:73,gxgrid:this.Gridordenpedido_opidContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CATEGDSC",gxz:"Z146categDsc",gxold:"O146categDsc",gxvar:"A146categDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A146categDsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z146categDsc=n)},v2c:function(n){gx.fn.setGridControlValue("CATEGDSC",n||gx.fn.currentGridRowImpl(73),gx.O.A146categDsc,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A146categDsc=this.val())},val:function(n){return gx.fn.getGridControlValue("CATEGDSC",n||gx.fn.currentGridRowImpl(73))},nac:gx.falseFn};n[78]={id:78,lvl:33,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,isacc:1,grid:73,gxgrid:this.Gridordenpedido_opidContainer,fnc:this.Valid_Subcatid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SUBCATID",gxz:"Z33subCatID",gxold:"O33subCatID",gxvar:"A33subCatID",ucs:[],op:[82,81,80,79],ip:[82,81,80,79,78,76,34],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A33subCatID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z33subCatID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("SUBCATID",n||gx.fn.currentGridRowImpl(73),gx.O.A33subCatID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A33subCatID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("SUBCATID",n||gx.fn.currentGridRowImpl(73),".")},nac:gx.falseFn};n[79]={id:79,lvl:33,type:"char",len:40,dec:0,sign:!1,pic:"@!",ro:1,isacc:1,grid:73,gxgrid:this.Gridordenpedido_opidContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SUBCATDSC",gxz:"Z148subCatDsc",gxold:"O148subCatDsc",gxvar:"A148subCatDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A148subCatDsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z148subCatDsc=n)},v2c:function(n){gx.fn.setGridControlValue("SUBCATDSC",n||gx.fn.currentGridRowImpl(73),gx.O.A148subCatDsc,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A148subCatDsc=this.val())},val:function(n){return gx.fn.getGridControlValue("SUBCATDSC",n||gx.fn.currentGridRowImpl(73))},nac:gx.falseFn};n[80]={id:80,lvl:33,type:"decimal",len:8,dec:2,sign:!1,pic:"ZZZZ9.99",ro:1,isacc:1,grid:73,gxgrid:this.Gridordenpedido_opidContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SUBCATPREC",gxz:"Z150subCatPrec",gxold:"O150subCatPrec",gxvar:"A150subCatPrec",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A150subCatPrec=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z150subCatPrec=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("SUBCATPREC",n||gx.fn.currentGridRowImpl(73),gx.O.A150subCatPrec,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A150subCatPrec=this.val())},val:function(n){return gx.fn.getGridDecimalValue("SUBCATPREC",n||gx.fn.currentGridRowImpl(73),".",",")},nac:gx.falseFn};n[81]={id:81,lvl:33,type:"decimal",len:8,dec:2,sign:!1,pic:"ZZZZ9.99",ro:1,isacc:1,grid:73,gxgrid:this.Gridordenpedido_opidContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SUBCATPESO",gxz:"Z151subCatPeso",gxold:"O151subCatPeso",gxvar:"A151subCatPeso",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A151subCatPeso=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z151subCatPeso=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("SUBCATPESO",n||gx.fn.currentGridRowImpl(73),gx.O.A151subCatPeso,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A151subCatPeso=this.val())},val:function(n){return gx.fn.getGridDecimalValue("SUBCATPESO",n||gx.fn.currentGridRowImpl(73),".",",")},nac:gx.falseFn};n[82]={id:82,lvl:33,type:"int",len:8,dec:0,sign:!1,pic:"ZZZZZZZ9",ro:1,isacc:1,grid:73,gxgrid:this.Gridordenpedido_opidContainer,fnc:this.Valid_Subcatdisp,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SUBCATDISP",gxz:"Z211subCatDisp",gxold:"O211subCatDisp",gxvar:"A211subCatDisp",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A211subCatDisp=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z211subCatDisp=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("SUBCATDISP",n||gx.fn.currentGridRowImpl(73),gx.O.A211subCatDisp,0)},c2v:function(){this.val()!==undefined&&(gx.O.A211subCatDisp=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("SUBCATDISP",n||gx.fn.currentGridRowImpl(73),".")},nac:gx.falseFn};n[83]={id:83,lvl:33,type:"decimal",len:8,dec:2,sign:!1,pic:"ZZZZ9.99",ro:0,isacc:1,grid:73,gxgrid:this.Gridordenpedido_opidContainer,fnc:this.Valid_Cantdetped,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CANTDETPED",gxz:"Z212cantDetPed",gxold:"O212cantDetPed",gxvar:"A212cantDetPed",ucs:[],op:[84],ip:[84,83,82],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A212cantDetPed=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z212cantDetPed=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("CANTDETPED",n||gx.fn.currentGridRowImpl(73),gx.O.A212cantDetPed,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A212cantDetPed=this.val())},val:function(n){return gx.fn.getGridDecimalValue("CANTDETPED",n||gx.fn.currentGridRowImpl(73),".",",")},nac:gx.falseFn};n[84]={id:84,lvl:33,type:"decimal",len:8,dec:2,sign:!0,pic:"ZZ,ZZ9.99",ro:1,isacc:1,grid:73,gxgrid:this.Gridordenpedido_opidContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PEDDETSALDO",gxz:"Z214PedDetSaldo",gxold:"O214PedDetSaldo",gxvar:"A214PedDetSaldo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A214PedDetSaldo=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z214PedDetSaldo=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("PEDDETSALDO",n||gx.fn.currentGridRowImpl(73),gx.O.A214PedDetSaldo,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A214PedDetSaldo=this.val())},val:function(n){return gx.fn.getGridDecimalValue("PEDDETSALDO",n||gx.fn.currentGridRowImpl(73),".",",")},nac:gx.falseFn};n[85]={id:85,lvl:33,type:"decimal",len:8,dec:2,sign:!1,pic:"ZZZZ9.99",ro:0,isacc:1,grid:73,gxgrid:this.Gridordenpedido_opidContainer,fnc:this.Valid_Cantdetaped,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CANTDETAPED",gxz:"Z213cantDetaPed",gxold:"O213cantDetaPed",gxvar:"A213cantDetaPed",ucs:[],op:[86],ip:[86,85],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A213cantDetaPed=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z213cantDetaPed=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("CANTDETAPED",n||gx.fn.currentGridRowImpl(73),gx.O.A213cantDetaPed,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A213cantDetaPed=this.val())},val:function(n){return gx.fn.getGridDecimalValue("CANTDETAPED",n||gx.fn.currentGridRowImpl(73),".",",")},nac:gx.falseFn};n[86]={id:86,lvl:33,type:"decimal",len:8,dec:2,sign:!0,pic:"ZZZZ9.99",ro:1,isacc:1,grid:73,gxgrid:this.Gridordenpedido_opidContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PEDTOTAL",gxz:"Z216PedTotal",gxold:"O216PedTotal",gxvar:"A216PedTotal",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A216PedTotal=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z216PedTotal=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("PEDTOTAL",n||gx.fn.currentGridRowImpl(73),gx.O.A216PedTotal,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A216PedTotal=this.val())},val:function(n){return gx.fn.getGridDecimalValue("PEDTOTAL",n||gx.fn.currentGridRowImpl(73),".",",")},nac:gx.falseFn};n[87]={id:87,fld:"",grid:0};n[88]={id:88,fld:"",grid:0};n[89]={id:89,fld:"",grid:0};n[90]={id:90,fld:"",grid:0};n[91]={id:91,fld:"BTN_ENTER",grid:0};n[92]={id:92,fld:"",grid:0};n[93]={id:93,fld:"BTN_CANCEL",grid:0};n[94]={id:94,fld:"",grid:0};n[95]={id:95,fld:"BTN_DELETE",grid:0};n[96]={id:96,fld:"PROMPT_1",grid:32};n[97]={id:97,fld:"PROMPT_36",grid:33};n[98]={id:98,fld:"PROMPT_32",grid:33};n[99]={id:99,fld:"PROMPT_33",grid:33};this.A1EmpID=0;this.Z1EmpID=0;this.O1EmpID=0;this.A44empdsc="";this.Z44empdsc="";this.O44empdsc="";this.A39PedCod=0;this.Z39PedCod=0;this.O39PedCod=0;this.A204PedDescripcion="";this.Z204PedDescripcion="";this.O204PedDescripcion="";this.A205PedFchReg=gx.date.nullDate();this.Z205PedFchReg=gx.date.nullDate();this.O205PedFchReg=gx.date.nullDate();this.A206PedEst="";this.Z206PedEst="";this.O206PedEst="";this.A207PedUltNro=0;this.Z207PedUltNro=0;this.O207PedUltNro=0;this.Z40OPIdSec=0;this.O40OPIdSec=0;this.Z36detTipoProdID=0;this.O36detTipoProdID=0;this.Z32categID=0;this.O32categID=0;this.Z146categDsc="";this.O146categDsc="";this.Z33subCatID=0;this.O33subCatID=0;this.Z148subCatDsc="";this.O148subCatDsc="";this.Z150subCatPrec=0;this.O150subCatPrec=0;this.Z151subCatPeso=0;this.O151subCatPeso=0;this.Z211subCatDisp=0;this.O211subCatDisp=0;this.Z212cantDetPed=0;this.O212cantDetPed=0;this.Z214PedDetSaldo=0;this.O214PedDetSaldo=0;this.Z213cantDetaPed=0;this.O213cantDetaPed=0;this.Z216PedTotal=0;this.O216PedTotal=0;this.A31tipoProdID=0;this.A40OPIdSec=0;this.A216PedTotal=0;this.A214PedDetSaldo=0;this.A36detTipoProdID=0;this.A32categID=0;this.A146categDsc="";this.A33subCatID=0;this.A148subCatDsc="";this.A150subCatPrec=0;this.A151subCatPeso=0;this.A211subCatDisp=0;this.A212cantDetPed=0;this.A213cantDetaPed=0;this.AV11fecha=gx.date.nullDate();this.AV24Pgmname="";this.AV20TrnContext={CallerObject:"",CallerOnDelete:!1,CallerURL:"",TransactionName:"",Attributes:[]};this.AV10EmpID=0;this.AV7PedCod=0;this.AV22WebSession={};this.A1EmpID=0;this.A39PedCod=0;this.Gx_BScreen=0;this.A44empdsc="";this.A204PedDescripcion="";this.A205PedFchReg=gx.date.nullDate();this.A206PedEst="";this.A207PedUltNro=0;this.Gx_mode="";this.Events={e120d2_client:["AFTER TRN",!0],e130d32_client:["ENTER",!0],e140d32_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV10EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{av:"AV7PedCod",fld:"vPEDCOD",pic:"ZZZZZZZ9",hsh:!0}],[]];this.EvtParms.REFRESH=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV10EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{av:"AV7PedCod",fld:"vPEDCOD",pic:"ZZZZZZZ9",hsh:!0},{av:"AV11fecha",fld:"vFECHA",pic:""}],[]];this.EvtParms.START=[[{av:"AV24Pgmname",fld:"vPGMNAME",pic:""}],[{av:"AV11fecha",fld:"vFECHA",pic:""},{av:"AV20TrnContext",fld:"vTRNCONTEXT",pic:""}]];this.EvtParms["AFTER TRN"]=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV20TrnContext",fld:"vTRNCONTEXT",pic:""}],[]];this.setPrompt("PROMPT_1",[34]);this.setPrompt("PROMPT_36",[75]);this.setPrompt("PROMPT_32",[76]);this.setPrompt("PROMPT_33",[78]);this.EnterCtrl=["BTN_ENTER"];this.setVCMap("AV10EmpID","vEMPID",0,"int",4,0);this.setVCMap("AV7PedCod","vPEDCOD",0,"int",8,0);this.setVCMap("Gx_BScreen","vGXBSCREEN",0,"int",1,0);this.setVCMap("AV11fecha","vFECHA",0,"date",8,0);this.setVCMap("AV24Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("Gx_mode","vMODE",0,"char",3,0);this.setVCMap("A31tipoProdID","TIPOPRODID",0,"int",4,0);this.setVCMap("AV20TrnContext","vTRNCONTEXT",0,"TransactionContext",0,0);t.addPostingVar(this.GXValidFnc[64]);t.addPostingVar({rfrVar:"Gx_BScreen"});this.Initialize();this.LvlOlds[32]=["O207PedUltNro"]});gx.createParentObj(ordenpedido)