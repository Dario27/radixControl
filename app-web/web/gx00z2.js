/*!   GeneXus C# 15_0_11-124690 on 6/28/2022 12:10:21.94
*/
gx.evt.autoSkip=!1;gx.define("gx00z2",!1,function(){var n,t;this.ServerClass="gx00z2";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV8pEmpID=gx.fn.getIntegerValue("vPEMPID",".");this.AV9pBodCod=gx.fn.getIntegerValue("vPBODCOD",".");this.AV10pTipoInv=gx.fn.getControlValue("vPTIPOINV");this.AV8pEmpID=gx.fn.getIntegerValue("vPEMPID",".");this.AV9pBodCod=gx.fn.getIntegerValue("vPBODCOD",".")};this.e13361_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),$.Deferred().resolve()};this.e11361_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("TIPOINVFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("TIPOINVFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCTIPOINV","Visible",!0)):(gx.fn.setCtrlProperty("TIPOINVFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCTIPOINV","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("TIPOINVFILTERCONTAINER","Class")',ctrl:"TIPOINVFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCTIPOINV","Visible")',ctrl:"vCTIPOINV",prop:"Visible"}]),$.Deferred().resolve()};this.e12361_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("BODTIPONROFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("BODTIPONROFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCBODTIPONRO","Visible",!0)):(gx.fn.setCtrlProperty("BODTIPONROFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCBODTIPONRO","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("BODTIPONROFILTERCONTAINER","Class")',ctrl:"BODTIPONROFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCBODTIPONRO","Visible")',ctrl:"vCBODTIPONRO",prop:"Visible"}]),$.Deferred().resolve()};this.e16362_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e17361_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,35,36,37,38,39,40,41,42];this.GXLastCtrlId=42;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",34,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00z2",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",35,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(43,36,"TIPOINV","Codigo","","TipoInv","char",0,"px",4,4,"left",null,[],43,"TipoInv",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(226,37,"BODTIPONRO","Nro","","BodTipoNro","int",0,"px",8,8,"right",null,[],226,"BodTipoNro",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(1,38,"EMPID","Emp ID","","EmpID","int",0,"px",4,4,"right",null,[],1,"EmpID",!1,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(42,39,"BODCOD","Bod Cod","","BodCod","int",0,"px",4,4,"right",null,[],42,"BodCod",!1,0,!1,!1,"Attribute",1,"");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TIPOINVFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLTIPOINVFILTER",format:1,grid:0,evt:"e11361_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"char",len:4,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCTIPOINV",gxz:"ZV6cTipoInv",gxold:"OV6cTipoInv",gxvar:"AV6cTipoInv",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cTipoInv=n)},v2z:function(n){n!==undefined&&(gx.O.ZV6cTipoInv=n)},v2c:function(){gx.fn.setControlValue("vCTIPOINV",gx.O.AV6cTipoInv,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cTipoInv=this.val())},val:function(){return gx.fn.getControlValue("vCTIPOINV")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"BODTIPONROFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLBODTIPONROFILTER",format:1,grid:0,evt:"e12361_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"int",len:8,dec:0,sign:!1,pic:"ZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCBODTIPONRO",gxz:"ZV7cBodTipoNro",gxold:"OV7cBodTipoNro",gxvar:"AV7cBodTipoNro",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cBodTipoNro=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV7cBodTipoNro=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCBODTIPONRO",gx.O.AV7cBodTipoNro,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cBodTipoNro=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCBODTIPONRO",".")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"GRIDTABLE",grid:0};n[29]={id:29,fld:"",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"BTNTOGGLE",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[35]={id:35,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(34),gx.O.AV5LinkSelection,gx.O.AV14Linkselection_GXI)},c2v:function(){gx.O.AV14Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(34))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(34))},gxvar_GXI:"AV14Linkselection_GXI",nac:gx.falseFn};n[36]={id:36,lvl:2,type:"char",len:4,dec:0,sign:!1,ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"TIPOINV",gxz:"Z43TipoInv",gxold:"O43TipoInv",gxvar:"A43TipoInv",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A43TipoInv=n)},v2z:function(n){n!==undefined&&(gx.O.Z43TipoInv=n)},v2c:function(n){gx.fn.setGridControlValue("TIPOINV",n||gx.fn.currentGridRowImpl(34),gx.O.A43TipoInv,0)},c2v:function(){this.val()!==undefined&&(gx.O.A43TipoInv=this.val())},val:function(n){return gx.fn.getGridControlValue("TIPOINV",n||gx.fn.currentGridRowImpl(34))},nac:gx.falseFn};n[37]={id:37,lvl:2,type:"int",len:8,dec:0,sign:!1,pic:"ZZZZZZZ9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BODTIPONRO",gxz:"Z226BodTipoNro",gxold:"O226BodTipoNro",gxvar:"A226BodTipoNro",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A226BodTipoNro=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z226BodTipoNro=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("BODTIPONRO",n||gx.fn.currentGridRowImpl(34),gx.O.A226BodTipoNro,0)},c2v:function(){this.val()!==undefined&&(gx.O.A226BodTipoNro=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("BODTIPONRO",n||gx.fn.currentGridRowImpl(34),".")},nac:gx.falseFn};n[38]={id:38,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EMPID",gxz:"Z1EmpID",gxold:"O1EmpID",gxvar:"A1EmpID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A1EmpID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1EmpID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("EMPID",n||gx.fn.currentGridRowImpl(34),gx.O.A1EmpID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A1EmpID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("EMPID",n||gx.fn.currentGridRowImpl(34),".")},nac:gx.falseFn};n[39]={id:39,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BODCOD",gxz:"Z42BodCod",gxold:"O42BodCod",gxvar:"A42BodCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A42BodCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z42BodCod=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("BODCOD",n||gx.fn.currentGridRowImpl(34),gx.O.A42BodCod,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A42BodCod=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("BODCOD",n||gx.fn.currentGridRowImpl(34),".")},nac:gx.falseFn};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"BTN_CANCEL",grid:0};this.AV6cTipoInv="";this.ZV6cTipoInv="";this.OV6cTipoInv="";this.AV7cBodTipoNro=0;this.ZV7cBodTipoNro=0;this.OV7cBodTipoNro=0;this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z43TipoInv="";this.O43TipoInv="";this.Z226BodTipoNro=0;this.O226BodTipoNro=0;this.Z1EmpID=0;this.O1EmpID=0;this.Z42BodCod=0;this.O42BodCod=0;this.AV6cTipoInv="";this.AV7cBodTipoNro=0;this.AV8pEmpID=0;this.AV9pBodCod=0;this.AV10pTipoInv="";this.AV5LinkSelection="";this.A43TipoInv="";this.A226BodTipoNro=0;this.A1EmpID=0;this.A42BodCod=0;this.Events={e16362_client:["ENTER",!0],e17361_client:["CANCEL",!0],e13361_client:["'TOGGLE'",!1],e11361_client:["LBLTIPOINVFILTER.CLICK",!1],e12361_client:["LBLBODTIPONROFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cTipoInv",fld:"vCTIPOINV",pic:""},{av:"AV7cBodTipoNro",fld:"vCBODTIPONRO",pic:"ZZZZZZZ9"},{av:"AV8pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV9pBodCod",fld:"vPBODCOD",pic:"ZZZ9"}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLTIPOINVFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("TIPOINVFILTERCONTAINER","Class")',ctrl:"TIPOINVFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("TIPOINVFILTERCONTAINER","Class")',ctrl:"TIPOINVFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCTIPOINV","Visible")',ctrl:"vCTIPOINV",prop:"Visible"}]];this.EvtParms["LBLBODTIPONROFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("BODTIPONROFILTERCONTAINER","Class")',ctrl:"BODTIPONROFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("BODTIPONROFILTERCONTAINER","Class")',ctrl:"BODTIPONROFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCBODTIPONRO","Visible")',ctrl:"vCBODTIPONRO",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A43TipoInv",fld:"TIPOINV",pic:"",hsh:!0}],[{av:"AV10pTipoInv",fld:"vPTIPOINV",pic:""}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cTipoInv",fld:"vCTIPOINV",pic:""},{av:"AV7cBodTipoNro",fld:"vCBODTIPONRO",pic:"ZZZZZZZ9"},{av:"AV8pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV9pBodCod",fld:"vPBODCOD",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cTipoInv",fld:"vCTIPOINV",pic:""},{av:"AV7cBodTipoNro",fld:"vCBODTIPONRO",pic:"ZZZZZZZ9"},{av:"AV8pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV9pBodCod",fld:"vPBODCOD",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cTipoInv",fld:"vCTIPOINV",pic:""},{av:"AV7cBodTipoNro",fld:"vCBODTIPONRO",pic:"ZZZZZZZ9"},{av:"AV8pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV9pBodCod",fld:"vPBODCOD",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cTipoInv",fld:"vCTIPOINV",pic:""},{av:"AV7cBodTipoNro",fld:"vCBODTIPONRO",pic:"ZZZZZZZ9"},{av:"AV8pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV9pBodCod",fld:"vPBODCOD",pic:"ZZZ9"}],[]];this.setVCMap("AV8pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV9pBodCod","vPBODCOD",0,"int",4,0);this.setVCMap("AV10pTipoInv","vPTIPOINV",0,"char",4,0);this.setVCMap("AV8pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV9pBodCod","vPBODCOD",0,"int",4,0);this.setVCMap("AV8pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV9pBodCod","vPBODCOD",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar({rfrVar:"AV8pEmpID"});t.addRefreshingVar({rfrVar:"AV9pBodCod"});this.Initialize()});gx.createParentObj(gx00z2)