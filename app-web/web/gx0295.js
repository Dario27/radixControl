/*!   GeneXus C# 15_0_12-126726 on 10/28/2022 1:26:49.22
*/
gx.evt.autoSkip=!1;gx.define("gx0295",!1,function(){var n,t;this.ServerClass="gx0295";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV8pstockAnio=gx.fn.getIntegerValue("vPSTOCKANIO",".");this.AV9pstockMes=gx.fn.getIntegerValue("vPSTOCKMES",".");this.AV10pEmpID=gx.fn.getIntegerValue("vPEMPID",".");this.AV11pAgeID=gx.fn.getIntegerValue("vPAGEID",".");this.AV12pBodCod=gx.fn.getIntegerValue("vPBODCOD",".");this.AV13pstockDetID=gx.fn.getIntegerValue("vPSTOCKDETID",".");this.AV8pstockAnio=gx.fn.getIntegerValue("vPSTOCKANIO",".");this.AV9pstockMes=gx.fn.getIntegerValue("vPSTOCKMES",".");this.AV10pEmpID=gx.fn.getIntegerValue("vPEMPID",".");this.AV11pAgeID=gx.fn.getIntegerValue("vPAGEID",".");this.AV12pBodCod=gx.fn.getIntegerValue("vPBODCOD",".")};this.e135e1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e115e1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("STOCKDETIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("STOCKDETIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCSTOCKDETID","Visible",!0)):(gx.fn.setCtrlProperty("STOCKDETIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCSTOCKDETID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("STOCKDETIDFILTERCONTAINER","Class")',ctrl:"STOCKDETIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCSTOCKDETID","Visible")',ctrl:"vCSTOCKDETID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e125e1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("PRDCODFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PRDCODFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPRDCOD","Visible",!0)):(gx.fn.setCtrlProperty("PRDCODFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPRDCOD","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PRDCODFILTERCONTAINER","Class")',ctrl:"PRDCODFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPRDCOD","Visible")',ctrl:"vCPRDCOD",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e165e2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e175e1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,35,36,37,38,39,40,41,42,43,44,45,46,47,48];this.GXLastCtrlId=48;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",34,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0295",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",35,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(348,36,"STOCKDETID","Det ID","","stockDetID","int",0,"px",4,4,"right",null,[],348,"stockDetID",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(286,37,"PRDCOD","ID","","PrdCod","int",0,"px",4,4,"right",null,[],286,"PrdCod",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(296,38,"CANTIDAD","cantidad","","cantidad","decimal",0,"px",9,9,"right",null,[],296,"cantidad",!0,2,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(297,39,"STOCK","stock","","stock","decimal",0,"px",9,9,"right",null,[],297,"stock",!0,2,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(298,40,"COSTO","costo","","costo","decimal",0,"px",13,13,"right",null,[],298,"costo",!0,2,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(290,41,"STOCKANIO","Anio","","stockAnio","int",0,"px",4,4,"right",null,[],290,"stockAnio",!1,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(291,42,"STOCKMES","Mes","","stockMes","int",0,"px",2,2,"right",null,[],291,"stockMes",!1,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(1,43,"EMPID","Emp ID","","EmpID","int",0,"px",4,4,"right",null,[],1,"EmpID",!1,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(2,44,"AGEID","Age ID","","AgeID","int",0,"px",4,4,"right",null,[],2,"AgeID",!1,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(42,45,"BODCOD","Bod Cod","","BodCod","int",0,"px",4,4,"right",null,[],42,"BodCod",!1,0,!1,!1,"Attribute",1,"");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"STOCKDETIDFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLSTOCKDETIDFILTER",format:1,grid:0,evt:"e115e1_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCSTOCKDETID",gxz:"ZV6cstockDetID",gxold:"OV6cstockDetID",gxvar:"AV6cstockDetID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cstockDetID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cstockDetID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCSTOCKDETID",gx.O.AV6cstockDetID,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cstockDetID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCSTOCKDETID",".")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"PRDCODFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLPRDCODFILTER",format:1,grid:0,evt:"e125e1_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCPRDCOD",gxz:"ZV7cPrdCod",gxold:"OV7cPrdCod",gxvar:"AV7cPrdCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cPrdCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV7cPrdCod=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCPRDCOD",gx.O.AV7cPrdCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cPrdCod=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCPRDCOD",".")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"GRIDTABLE",grid:0};n[29]={id:29,fld:"",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"BTNTOGGLE",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[35]={id:35,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(34),gx.O.AV5LinkSelection,gx.O.AV17Linkselection_GXI)},c2v:function(){gx.O.AV17Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(34))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(34))},gxvar_GXI:"AV17Linkselection_GXI",nac:gx.falseFn};n[36]={id:36,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"STOCKDETID",gxz:"Z348stockDetID",gxold:"O348stockDetID",gxvar:"A348stockDetID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A348stockDetID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z348stockDetID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("STOCKDETID",n||gx.fn.currentGridRowImpl(34),gx.O.A348stockDetID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A348stockDetID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("STOCKDETID",n||gx.fn.currentGridRowImpl(34),".")},nac:gx.falseFn};n[37]={id:37,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PRDCOD",gxz:"Z286PrdCod",gxold:"O286PrdCod",gxvar:"A286PrdCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A286PrdCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z286PrdCod=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("PRDCOD",n||gx.fn.currentGridRowImpl(34),gx.O.A286PrdCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A286PrdCod=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("PRDCOD",n||gx.fn.currentGridRowImpl(34),".")},nac:gx.falseFn};n[38]={id:38,lvl:2,type:"decimal",len:9,dec:2,sign:!1,pic:"ZZZZZ9.99",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CANTIDAD",gxz:"Z296cantidad",gxold:"O296cantidad",gxvar:"A296cantidad",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A296cantidad=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z296cantidad=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("CANTIDAD",n||gx.fn.currentGridRowImpl(34),gx.O.A296cantidad,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A296cantidad=this.val())},val:function(n){return gx.fn.getGridDecimalValue("CANTIDAD",n||gx.fn.currentGridRowImpl(34),".",",")},nac:gx.falseFn};n[39]={id:39,lvl:2,type:"decimal",len:9,dec:2,sign:!1,pic:"ZZZZZ9.99",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"STOCK",gxz:"Z297stock",gxold:"O297stock",gxvar:"A297stock",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A297stock=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z297stock=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("STOCK",n||gx.fn.currentGridRowImpl(34),gx.O.A297stock,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A297stock=this.val())},val:function(n){return gx.fn.getGridDecimalValue("STOCK",n||gx.fn.currentGridRowImpl(34),".",",")},nac:gx.falseFn};n[40]={id:40,lvl:2,type:"decimal",len:10,dec:2,sign:!1,pic:"ZZ,ZZZ,ZZZ.ZZ",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"COSTO",gxz:"Z298costo",gxold:"O298costo",gxvar:"A298costo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A298costo=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z298costo=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("COSTO",n||gx.fn.currentGridRowImpl(34),gx.O.A298costo,2,",");typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A298costo=this.val())},val:function(n){return gx.fn.getGridDecimalValue("COSTO",n||gx.fn.currentGridRowImpl(34),".",",")},nac:gx.falseFn};n[41]={id:41,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"STOCKANIO",gxz:"Z290stockAnio",gxold:"O290stockAnio",gxvar:"A290stockAnio",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A290stockAnio=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z290stockAnio=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("STOCKANIO",n||gx.fn.currentGridRowImpl(34),gx.O.A290stockAnio,0)},c2v:function(){this.val()!==undefined&&(gx.O.A290stockAnio=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("STOCKANIO",n||gx.fn.currentGridRowImpl(34),".")},nac:gx.falseFn};n[42]={id:42,lvl:2,type:"int",len:2,dec:0,sign:!1,pic:"Z9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"STOCKMES",gxz:"Z291stockMes",gxold:"O291stockMes",gxvar:"A291stockMes",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A291stockMes=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z291stockMes=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("STOCKMES",n||gx.fn.currentGridRowImpl(34),gx.O.A291stockMes,0)},c2v:function(){this.val()!==undefined&&(gx.O.A291stockMes=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("STOCKMES",n||gx.fn.currentGridRowImpl(34),".")},nac:gx.falseFn};n[43]={id:43,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EMPID",gxz:"Z1EmpID",gxold:"O1EmpID",gxvar:"A1EmpID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A1EmpID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1EmpID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("EMPID",n||gx.fn.currentGridRowImpl(34),gx.O.A1EmpID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A1EmpID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("EMPID",n||gx.fn.currentGridRowImpl(34),".")},nac:gx.falseFn};n[44]={id:44,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"AGEID",gxz:"Z2AgeID",gxold:"O2AgeID",gxvar:"A2AgeID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A2AgeID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z2AgeID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("AGEID",n||gx.fn.currentGridRowImpl(34),gx.O.A2AgeID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A2AgeID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("AGEID",n||gx.fn.currentGridRowImpl(34),".")},nac:gx.falseFn};n[45]={id:45,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BODCOD",gxz:"Z42BodCod",gxold:"O42BodCod",gxvar:"A42BodCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A42BodCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z42BodCod=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("BODCOD",n||gx.fn.currentGridRowImpl(34),gx.O.A42BodCod,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A42BodCod=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("BODCOD",n||gx.fn.currentGridRowImpl(34),".")},nac:gx.falseFn};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"BTN_CANCEL",grid:0};this.AV6cstockDetID=0;this.ZV6cstockDetID=0;this.OV6cstockDetID=0;this.AV7cPrdCod=0;this.ZV7cPrdCod=0;this.OV7cPrdCod=0;this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z348stockDetID=0;this.O348stockDetID=0;this.Z286PrdCod=0;this.O286PrdCod=0;this.Z296cantidad=0;this.O296cantidad=0;this.Z297stock=0;this.O297stock=0;this.Z298costo=0;this.O298costo=0;this.Z290stockAnio=0;this.O290stockAnio=0;this.Z291stockMes=0;this.O291stockMes=0;this.Z1EmpID=0;this.O1EmpID=0;this.Z2AgeID=0;this.O2AgeID=0;this.Z42BodCod=0;this.O42BodCod=0;this.AV6cstockDetID=0;this.AV7cPrdCod=0;this.AV8pstockAnio=0;this.AV9pstockMes=0;this.AV10pEmpID=0;this.AV11pAgeID=0;this.AV12pBodCod=0;this.AV13pstockDetID=0;this.AV5LinkSelection="";this.A348stockDetID=0;this.A286PrdCod=0;this.A296cantidad=0;this.A297stock=0;this.A298costo=0;this.A290stockAnio=0;this.A291stockMes=0;this.A1EmpID=0;this.A2AgeID=0;this.A42BodCod=0;this.Events={e165e2_client:["ENTER",!0],e175e1_client:["CANCEL",!0],e135e1_client:["'TOGGLE'",!1],e115e1_client:["LBLSTOCKDETIDFILTER.CLICK",!1],e125e1_client:["LBLPRDCODFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cstockDetID",fld:"vCSTOCKDETID",pic:"ZZZ9"},{av:"AV7cPrdCod",fld:"vCPRDCOD",pic:"ZZZ9"},{av:"AV8pstockAnio",fld:"vPSTOCKANIO",pic:"ZZZ9"},{av:"AV9pstockMes",fld:"vPSTOCKMES",pic:"Z9"},{av:"AV10pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV11pAgeID",fld:"vPAGEID",pic:"ZZZ9"},{av:"AV12pBodCod",fld:"vPBODCOD",pic:"ZZZ9"}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLSTOCKDETIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("STOCKDETIDFILTERCONTAINER","Class")',ctrl:"STOCKDETIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("STOCKDETIDFILTERCONTAINER","Class")',ctrl:"STOCKDETIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCSTOCKDETID","Visible")',ctrl:"vCSTOCKDETID",prop:"Visible"}]];this.EvtParms["LBLPRDCODFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PRDCODFILTERCONTAINER","Class")',ctrl:"PRDCODFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PRDCODFILTERCONTAINER","Class")',ctrl:"PRDCODFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPRDCOD","Visible")',ctrl:"vCPRDCOD",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A348stockDetID",fld:"STOCKDETID",pic:"ZZZ9",hsh:!0}],[{av:"AV13pstockDetID",fld:"vPSTOCKDETID",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cstockDetID",fld:"vCSTOCKDETID",pic:"ZZZ9"},{av:"AV7cPrdCod",fld:"vCPRDCOD",pic:"ZZZ9"},{av:"AV8pstockAnio",fld:"vPSTOCKANIO",pic:"ZZZ9"},{av:"AV9pstockMes",fld:"vPSTOCKMES",pic:"Z9"},{av:"AV10pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV11pAgeID",fld:"vPAGEID",pic:"ZZZ9"},{av:"AV12pBodCod",fld:"vPBODCOD",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cstockDetID",fld:"vCSTOCKDETID",pic:"ZZZ9"},{av:"AV7cPrdCod",fld:"vCPRDCOD",pic:"ZZZ9"},{av:"AV8pstockAnio",fld:"vPSTOCKANIO",pic:"ZZZ9"},{av:"AV9pstockMes",fld:"vPSTOCKMES",pic:"Z9"},{av:"AV10pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV11pAgeID",fld:"vPAGEID",pic:"ZZZ9"},{av:"AV12pBodCod",fld:"vPBODCOD",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cstockDetID",fld:"vCSTOCKDETID",pic:"ZZZ9"},{av:"AV7cPrdCod",fld:"vCPRDCOD",pic:"ZZZ9"},{av:"AV8pstockAnio",fld:"vPSTOCKANIO",pic:"ZZZ9"},{av:"AV9pstockMes",fld:"vPSTOCKMES",pic:"Z9"},{av:"AV10pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV11pAgeID",fld:"vPAGEID",pic:"ZZZ9"},{av:"AV12pBodCod",fld:"vPBODCOD",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cstockDetID",fld:"vCSTOCKDETID",pic:"ZZZ9"},{av:"AV7cPrdCod",fld:"vCPRDCOD",pic:"ZZZ9"},{av:"AV8pstockAnio",fld:"vPSTOCKANIO",pic:"ZZZ9"},{av:"AV9pstockMes",fld:"vPSTOCKMES",pic:"Z9"},{av:"AV10pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV11pAgeID",fld:"vPAGEID",pic:"ZZZ9"},{av:"AV12pBodCod",fld:"vPBODCOD",pic:"ZZZ9"}],[]];this.setVCMap("AV8pstockAnio","vPSTOCKANIO",0,"int",4,0);this.setVCMap("AV9pstockMes","vPSTOCKMES",0,"int",2,0);this.setVCMap("AV10pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV11pAgeID","vPAGEID",0,"int",4,0);this.setVCMap("AV12pBodCod","vPBODCOD",0,"int",4,0);this.setVCMap("AV13pstockDetID","vPSTOCKDETID",0,"int",4,0);this.setVCMap("AV8pstockAnio","vPSTOCKANIO",0,"int",4,0);this.setVCMap("AV9pstockMes","vPSTOCKMES",0,"int",2,0);this.setVCMap("AV10pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV11pAgeID","vPAGEID",0,"int",4,0);this.setVCMap("AV12pBodCod","vPBODCOD",0,"int",4,0);this.setVCMap("AV8pstockAnio","vPSTOCKANIO",0,"int",4,0);this.setVCMap("AV9pstockMes","vPSTOCKMES",0,"int",2,0);this.setVCMap("AV10pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV11pAgeID","vPAGEID",0,"int",4,0);this.setVCMap("AV12pBodCod","vPBODCOD",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar({rfrVar:"AV8pstockAnio"});t.addRefreshingVar({rfrVar:"AV9pstockMes"});t.addRefreshingVar({rfrVar:"AV10pEmpID"});t.addRefreshingVar({rfrVar:"AV11pAgeID"});t.addRefreshingVar({rfrVar:"AV12pBodCod"});this.Initialize()});gx.createParentObj(gx0295)