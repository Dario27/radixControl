/*!   GeneXus C# 15_0_12-126726 on 1/9/2023 12:20:5.60
*/
gx.evt.autoSkip=!1;gx.define("wwprodstockbodega",!1,function(){var n,t;this.ServerClass="wwprodstockbodega";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV22Pgmname=gx.fn.getControlValue("vPGMNAME");this.AV17empID=gx.fn.getIntegerValue("vEMPID",".");this.AV18ageId=gx.fn.getIntegerValue("vAGEID",".");this.AV19Usucod=gx.fn.getControlValue("vUSUCOD");this.AV22Pgmname=gx.fn.getControlValue("vPGMNAME")};this.Valid_Stockanio=function(){try{if(gx.fn.currentGridRowImpl(25)===0)return!0;var n=gx.util.balloon.getNew("STOCKANIO",gx.fn.currentGridRowImpl(25));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Stockmes=function(){try{if(gx.fn.currentGridRowImpl(25)===0)return!0;var n=gx.util.balloon.getNew("STOCKMES",gx.fn.currentGridRowImpl(25));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Empid=function(){try{if(gx.fn.currentGridRowImpl(25)===0)return!0;var n=gx.util.balloon.getNew("EMPID",gx.fn.currentGridRowImpl(25));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Ageid=function(){try{if(gx.fn.currentGridRowImpl(25)===0)return!0;var n=gx.util.balloon.getNew("AGEID",gx.fn.currentGridRowImpl(25));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Bodcod=function(){try{if(gx.fn.currentGridRowImpl(25)===0)return!0;var n=gx.util.balloon.getNew("BODCOD",gx.fn.currentGridRowImpl(25));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Prdcod=function(){try{if(gx.fn.currentGridRowImpl(25)===0)return!0;var n=gx.util.balloon.getNew("PRDCOD",gx.fn.currentGridRowImpl(25));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Invfisico=function(){try{if(gx.fn.currentGridRowImpl(25)===0)return!0;var n=gx.util.balloon.getNew("INVFISICO",gx.fn.currentGridRowImpl(25));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Ingbod=function(){try{if(gx.fn.currentGridRowImpl(25)===0)return!0;var n=gx.util.balloon.getNew("INGBOD",gx.fn.currentGridRowImpl(25));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Egrbod=function(){try{if(gx.fn.currentGridRowImpl(25)===0)return!0;var n=gx.util.balloon.getNew("EGRBOD",gx.fn.currentGridRowImpl(25));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e115i2_client=function(){return this.executeServerEvent("'DOINSERT'",!1,null,!1,!1)};this.e155i2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e165i2_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,23,24,26,27,28,29,30,31,32,33,34,35,36,37,38,39];this.GXLastCtrlId=39;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",25,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"wwprodstockbodega",[],!1,1,!1,!0,0,!0,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.GridContainer;t.addSingleLineEdit(290,26,"STOCKANIO","Anio","","stockAnio","int",0,"px",4,4,"right",null,[],290,"stockAnio",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addComboBox(291,27,"STOCKMES","Mes","stockMes","int",null,0,!0,!1,0,"px","WWColumn WWOptionalColumn");t.addSingleLineEdit(1,28,"EMPID","Emp ID","","EmpID","int",0,"px",4,4,"right",null,[],1,"EmpID",!1,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(2,29,"AGEID","Age ID","","AgeID","int",0,"px",4,4,"right",null,[],2,"AgeID",!1,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(42,30,"BODCOD","Bod Cod","","BodCod","int",0,"px",4,4,"right",null,[],42,"BodCod",!1,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(217,31,"BODDSC","Bodega","","BodDsc","char",0,"px",40,40,"left",null,[],217,"BodDsc",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(286,32,"PRDCOD","ID","","PrdCod","int",0,"px",4,4,"right",null,[],286,"PrdCod",!1,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(309,33,"PRDNOMBRE","Producto","","prdNombre","svchar",0,"px",80,80,"left",null,[],309,"prdNombre",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(292,34,"STOCKBOD","Exist.","","stockBod","decimal",0,"px",9,9,"right",null,[],292,"stockBod",!0,2,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(293,35,"INVFISICO","Inv. Fisico","","invFisico","decimal",0,"px",6,6,"right",null,[],293,"invFisico",!0,2,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(294,36,"INGBOD","Entradas","","ingBod","decimal",0,"px",9,9,"right",null,[],294,"ingBod",!0,2,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(295,37,"EGRBOD","Salidas","","egrBod","decimal",0,"px",9,9,"right",null,[],295,"egrBod",!0,2,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addBitmap("&Update","vUPDATE",38,0,"px",17,"px",null,"","","ImageAttribute","WWActionColumn");t.addBitmap("&Delete","vDELETE",39,0,"px",17,"px",null,"","","ImageAttribute","WWActionColumn");this.GridContainer.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLETOP",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TITLETEXT",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"",grid:0};n[13]={id:13,fld:"BTNINSERT",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"svchar",len:80,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vPRDNOMBRE",gxz:"ZV13prdNombre",gxold:"OV13prdNombre",gxvar:"AV13prdNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV13prdNombre=n)},v2z:function(n){n!==undefined&&(gx.O.ZV13prdNombre=n)},v2c:function(){gx.fn.setControlValue("vPRDNOMBRE",gx.O.AV13prdNombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV13prdNombre=this.val())},val:function(){return gx.fn.getControlValue("vPRDNOMBRE")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"GRIDCELL",grid:0};n[19]={id:19,fld:"GRIDTABLE",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[26]={id:26,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:this.Valid_Stockanio,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"STOCKANIO",gxz:"Z290stockAnio",gxold:"O290stockAnio",gxvar:"A290stockAnio",ucs:[],op:[34,36,37,33,31],ip:[34,33,31,37,36,35,27,26,32,29,30,28],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A290stockAnio=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z290stockAnio=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("STOCKANIO",n||gx.fn.currentGridRowImpl(25),gx.O.A290stockAnio,0)},c2v:function(){this.val()!==undefined&&(gx.O.A290stockAnio=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("STOCKANIO",n||gx.fn.currentGridRowImpl(25),".")},nac:gx.falseFn};n[27]={id:27,lvl:2,type:"int",len:2,dec:0,sign:!1,pic:"Z9",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:this.Valid_Stockmes,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"STOCKMES",gxz:"Z291stockMes",gxold:"O291stockMes",gxvar:"A291stockMes",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A291stockMes=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z291stockMes=gx.num.intval(n))},v2c:function(n){gx.fn.setGridComboBoxValue("STOCKMES",n||gx.fn.currentGridRowImpl(25),gx.O.A291stockMes)},c2v:function(){this.val()!==undefined&&(gx.O.A291stockMes=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("STOCKMES",n||gx.fn.currentGridRowImpl(25),".")},nac:gx.falseFn};n[28]={id:28,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:this.Valid_Empid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EMPID",gxz:"Z1EmpID",gxold:"O1EmpID",gxvar:"A1EmpID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A1EmpID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1EmpID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("EMPID",n||gx.fn.currentGridRowImpl(25),gx.O.A1EmpID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A1EmpID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("EMPID",n||gx.fn.currentGridRowImpl(25),".")},nac:gx.falseFn};n[29]={id:29,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:this.Valid_Ageid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"AGEID",gxz:"Z2AgeID",gxold:"O2AgeID",gxvar:"A2AgeID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A2AgeID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z2AgeID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("AGEID",n||gx.fn.currentGridRowImpl(25),gx.O.A2AgeID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A2AgeID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("AGEID",n||gx.fn.currentGridRowImpl(25),".")},nac:gx.falseFn};n[30]={id:30,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:this.Valid_Bodcod,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BODCOD",gxz:"Z42BodCod",gxold:"O42BodCod",gxvar:"A42BodCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A42BodCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z42BodCod=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("BODCOD",n||gx.fn.currentGridRowImpl(25),gx.O.A42BodCod,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A42BodCod=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("BODCOD",n||gx.fn.currentGridRowImpl(25),".")},nac:gx.falseFn};n[31]={id:31,lvl:2,type:"char",len:40,dec:0,sign:!1,pic:"@!",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BODDSC",gxz:"Z217BodDsc",gxold:"O217BodDsc",gxvar:"A217BodDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A217BodDsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z217BodDsc=n)},v2c:function(n){gx.fn.setGridControlValue("BODDSC",n||gx.fn.currentGridRowImpl(25),gx.O.A217BodDsc,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A217BodDsc=this.val())},val:function(n){return gx.fn.getGridControlValue("BODDSC",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[32]={id:32,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:this.Valid_Prdcod,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PRDCOD",gxz:"Z286PrdCod",gxold:"O286PrdCod",gxvar:"A286PrdCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A286PrdCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z286PrdCod=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("PRDCOD",n||gx.fn.currentGridRowImpl(25),gx.O.A286PrdCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A286PrdCod=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("PRDCOD",n||gx.fn.currentGridRowImpl(25),".")},nac:gx.falseFn};n[33]={id:33,lvl:2,type:"svchar",len:80,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PRDNOMBRE",gxz:"Z309prdNombre",gxold:"O309prdNombre",gxvar:"A309prdNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A309prdNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z309prdNombre=n)},v2c:function(n){gx.fn.setGridControlValue("PRDNOMBRE",n||gx.fn.currentGridRowImpl(25),gx.O.A309prdNombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.A309prdNombre=this.val())},val:function(n){return gx.fn.getGridControlValue("PRDNOMBRE",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[34]={id:34,lvl:2,type:"decimal",len:8,dec:2,sign:!1,pic:"ZZ.ZZ9.99",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"STOCKBOD",gxz:"Z292stockBod",gxold:"O292stockBod",gxvar:"A292stockBod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A292stockBod=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z292stockBod=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("STOCKBOD",n||gx.fn.currentGridRowImpl(25),gx.O.A292stockBod,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A292stockBod=this.val())},val:function(n){return gx.fn.getGridDecimalValue("STOCKBOD",n||gx.fn.currentGridRowImpl(25),".",",")},nac:gx.falseFn};n[35]={id:35,lvl:2,type:"decimal",len:6,dec:2,sign:!1,pic:"ZZ9.99",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:this.Valid_Invfisico,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"INVFISICO",gxz:"Z293invFisico",gxold:"O293invFisico",gxvar:"A293invFisico",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A293invFisico=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z293invFisico=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("INVFISICO",n||gx.fn.currentGridRowImpl(25),gx.O.A293invFisico,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A293invFisico=this.val())},val:function(n){return gx.fn.getGridDecimalValue("INVFISICO",n||gx.fn.currentGridRowImpl(25),".",",")},nac:gx.falseFn};n[36]={id:36,lvl:2,type:"decimal",len:9,dec:2,sign:!1,pic:"ZZZZZ9.99",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:this.Valid_Ingbod,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"INGBOD",gxz:"Z294ingBod",gxold:"O294ingBod",gxvar:"A294ingBod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A294ingBod=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z294ingBod=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("INGBOD",n||gx.fn.currentGridRowImpl(25),gx.O.A294ingBod,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A294ingBod=this.val())},val:function(n){return gx.fn.getGridDecimalValue("INGBOD",n||gx.fn.currentGridRowImpl(25),".",",")},nac:gx.falseFn};n[37]={id:37,lvl:2,type:"decimal",len:9,dec:2,sign:!1,pic:"ZZZZZ9.99",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:this.Valid_Egrbod,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EGRBOD",gxz:"Z295egrBod",gxold:"O295egrBod",gxvar:"A295egrBod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A295egrBod=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z295egrBod=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("EGRBOD",n||gx.fn.currentGridRowImpl(25),gx.O.A295egrBod,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A295egrBod=this.val())},val:function(n){return gx.fn.getGridDecimalValue("EGRBOD",n||gx.fn.currentGridRowImpl(25),".",",")},nac:gx.falseFn};n[38]={id:38,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV14Update",gxold:"OV14Update",gxvar:"AV14Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV14Update=n)},v2z:function(n){n!==undefined&&(gx.O.ZV14Update=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vUPDATE",n||gx.fn.currentGridRowImpl(25),gx.O.AV14Update,gx.O.AV23Update_GXI)},c2v:function(){gx.O.AV23Update_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV14Update=this.val())},val:function(n){return gx.fn.getGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(25))},val_GXI:function(n){return gx.fn.getGridControlValue("vUPDATE_GXI",n||gx.fn.currentGridRowImpl(25))},gxvar_GXI:"AV23Update_GXI",nac:gx.falseFn};n[39]={id:39,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV15Delete",gxold:"OV15Delete",gxvar:"AV15Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV15Delete=n)},v2z:function(n){n!==undefined&&(gx.O.ZV15Delete=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vDELETE",n||gx.fn.currentGridRowImpl(25),gx.O.AV15Delete,gx.O.AV24Delete_GXI)},c2v:function(){gx.O.AV24Delete_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV15Delete=this.val())},val:function(n){return gx.fn.getGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(25))},val_GXI:function(n){return gx.fn.getGridControlValue("vDELETE_GXI",n||gx.fn.currentGridRowImpl(25))},gxvar_GXI:"AV24Delete_GXI",nac:gx.falseFn};this.AV13prdNombre="";this.ZV13prdNombre="";this.OV13prdNombre="";this.Z290stockAnio=0;this.O290stockAnio=0;this.Z291stockMes=0;this.O291stockMes=0;this.Z1EmpID=0;this.O1EmpID=0;this.Z2AgeID=0;this.O2AgeID=0;this.Z42BodCod=0;this.O42BodCod=0;this.Z217BodDsc="";this.O217BodDsc="";this.Z286PrdCod=0;this.O286PrdCod=0;this.Z309prdNombre="";this.O309prdNombre="";this.Z292stockBod=0;this.O292stockBod=0;this.Z293invFisico=0;this.O293invFisico=0;this.Z294ingBod=0;this.O294ingBod=0;this.Z295egrBod=0;this.O295egrBod=0;this.ZV14Update="";this.OV14Update="";this.ZV15Delete="";this.OV15Delete="";this.AV13prdNombre="";this.AV17empID=0;this.AV18ageId=0;this.AV19Usucod="";this.A290stockAnio=0;this.A291stockMes=0;this.A1EmpID=0;this.A2AgeID=0;this.A42BodCod=0;this.A217BodDsc="";this.A286PrdCod=0;this.A309prdNombre="";this.A292stockBod=0;this.A293invFisico=0;this.A294ingBod=0;this.A295egrBod=0;this.AV14Update="";this.AV15Delete="";this.AV22Pgmname="";this.Events={e115i2_client:["'DOINSERT'",!0],e155i2_client:["ENTER",!0],e165i2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"AV22Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13prdNombre",fld:"vPRDNOMBRE",pic:""},{av:"AV17empID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{av:"AV18ageId",fld:"vAGEID",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms.START=[[{av:"AV22Pgmname",fld:"vPGMNAME",pic:""}],[{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{ctrl:"FORM",prop:"Caption"},{av:"AV13prdNombre",fld:"vPRDNOMBRE",pic:""}]];this.EvtParms["GRID.LOAD"]=[[{av:"A290stockAnio",fld:"STOCKANIO",pic:"ZZZ9",hsh:!0},{ctrl:"STOCKMES"},{av:"A291stockMes",fld:"STOCKMES",pic:"Z9",hsh:!0},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"},{av:"A2AgeID",fld:"AGEID",pic:"ZZZ9"},{av:"A42BodCod",fld:"BODCOD",pic:"ZZZ9",hsh:!0},{av:"A286PrdCod",fld:"PRDCOD",pic:"ZZZ9",hsh:!0}],[{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:"vUPDATE",prop:"Link"},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:"vDELETE",prop:"Link"}]];this.EvtParms["'DOINSERT'"]=[[{av:"A290stockAnio",fld:"STOCKANIO",pic:"ZZZ9",hsh:!0},{ctrl:"STOCKMES"},{av:"A291stockMes",fld:"STOCKMES",pic:"Z9",hsh:!0},{av:"AV17empID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{av:"AV18ageId",fld:"vAGEID",pic:"ZZZ9",hsh:!0},{av:"A42BodCod",fld:"BODCOD",pic:"ZZZ9",hsh:!0},{av:"A286PrdCod",fld:"PRDCOD",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms.GRID_FIRSTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"AV17empID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{av:"AV18ageId",fld:"vAGEID",pic:"ZZZ9",hsh:!0},{av:"AV22Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13prdNombre",fld:"vPRDNOMBRE",pic:""}],[]];this.EvtParms.GRID_PREVPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"AV17empID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{av:"AV18ageId",fld:"vAGEID",pic:"ZZZ9",hsh:!0},{av:"AV22Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13prdNombre",fld:"vPRDNOMBRE",pic:""}],[]];this.EvtParms.GRID_NEXTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"AV17empID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{av:"AV18ageId",fld:"vAGEID",pic:"ZZZ9",hsh:!0},{av:"AV22Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13prdNombre",fld:"vPRDNOMBRE",pic:""}],[]];this.EvtParms.GRID_LASTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"AV17empID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{av:"AV18ageId",fld:"vAGEID",pic:"ZZZ9",hsh:!0},{av:"AV22Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13prdNombre",fld:"vPRDNOMBRE",pic:""}],[]];this.setVCMap("AV22Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("AV17empID","vEMPID",0,"int",4,0);this.setVCMap("AV18ageId","vAGEID",0,"int",4,0);this.setVCMap("AV19Usucod","vUSUCOD",0,"char",15,0);this.setVCMap("AV22Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("AV22Pgmname","vPGMNAME",0,"char",129,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar({rfrVar:"AV22Pgmname"});t.addRefreshingVar({rfrVar:"AV14Update",rfrProp:"Value",gxAttId:"Update"});t.addRefreshingVar({rfrVar:"AV14Update",rfrProp:"Tooltiptext",gxAttId:"Update"});t.addRefreshingVar({rfrVar:"AV15Delete",rfrProp:"Value",gxAttId:"Delete"});t.addRefreshingVar({rfrVar:"AV15Delete",rfrProp:"Tooltiptext",gxAttId:"Delete"});t.addRefreshingVar({rfrVar:"AV17empID"});t.addRefreshingVar({rfrVar:"AV18ageId"});this.Initialize()});gx.createParentObj(wwprodstockbodega)