/*!   GeneXus C# 15_0_12-126726 on 10/26/2022 20:17:53.32
*/
gx.evt.autoSkip=!1;gx.define("gx01h2",!1,function(){var n,t;this.ServerClass="gx01h2";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV9pEmpID=gx.fn.getIntegerValue("vPEMPID",".");this.AV10pBodCod=gx.fn.getIntegerValue("vPBODCOD",".");this.AV11pBodDetID=gx.fn.getIntegerValue("vPBODDETID",".");this.AV12pTipoInv=gx.fn.getControlValue("vPTIPOINV");this.AV9pEmpID=gx.fn.getIntegerValue("vPEMPID",".");this.AV10pBodCod=gx.fn.getIntegerValue("vPBODCOD",".")};this.e144a1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e114a1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("BODDETIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("BODDETIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCBODDETID","Visible",!0)):(gx.fn.setCtrlProperty("BODDETIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCBODDETID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("BODDETIDFILTERCONTAINER","Class")',ctrl:"BODDETIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCBODDETID","Visible")',ctrl:"vCBODDETID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e124a1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("TIPOINVFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("TIPOINVFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCTIPOINV","Visible",!0)):(gx.fn.setCtrlProperty("TIPOINVFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCTIPOINV","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("TIPOINVFILTERCONTAINER","Class")',ctrl:"TIPOINVFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCTIPOINV","Visible")',ctrl:"vCTIPOINV",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e134a1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("BODTIPONROFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("BODTIPONROFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCBODTIPONRO","Visible",!0)):(gx.fn.setCtrlProperty("BODTIPONROFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCBODTIPONRO","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("BODTIPONROFILTERCONTAINER","Class")',ctrl:"BODTIPONROFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCBODTIPONRO","Visible")',ctrl:"vCBODTIPONRO",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e174a2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e184a1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,45,46,47,48,49,50,51,52,53];this.GXLastCtrlId=53;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",44,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx01h2",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",45,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(285,46,"BODDETID","Det ID","","BodDetID","int",0,"px",4,4,"right",null,[],285,"BodDetID",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(43,47,"TIPOINV","Codigo","","TipoInv","char",0,"px",4,4,"left",null,[],43,"TipoInv",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(226,48,"BODTIPONRO","Nro","","BodTipoNro","int",0,"px",8,8,"right",null,[],226,"BodTipoNro",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(1,49,"EMPID","Emp ID","","EmpID","int",0,"px",4,4,"right",null,[],1,"EmpID",!1,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(42,50,"BODCOD","Bod Cod","","BodCod","int",0,"px",4,4,"right",null,[],42,"BodCod",!1,0,!1,!1,"Attribute",1,"");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"BODDETIDFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLBODDETIDFILTER",format:1,grid:0,evt:"e114a1_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCBODDETID",gxz:"ZV6cBodDetID",gxold:"OV6cBodDetID",gxvar:"AV6cBodDetID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cBodDetID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cBodDetID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCBODDETID",gx.O.AV6cBodDetID,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cBodDetID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCBODDETID",".")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"TIPOINVFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLTIPOINVFILTER",format:1,grid:0,evt:"e124a1_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"char",len:4,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCTIPOINV",gxz:"ZV7cTipoInv",gxold:"OV7cTipoInv",gxvar:"AV7cTipoInv",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cTipoInv=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7cTipoInv=n)},v2c:function(){gx.fn.setControlValue("vCTIPOINV",gx.O.AV7cTipoInv,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cTipoInv=this.val())},val:function(){return gx.fn.getControlValue("vCTIPOINV")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"BODTIPONROFILTERCONTAINER",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"LBLBODTIPONROFILTER",format:1,grid:0,evt:"e134a1_client"};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,lvl:0,type:"int",len:8,dec:0,sign:!1,pic:"ZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCBODTIPONRO",gxz:"ZV8cBodTipoNro",gxold:"OV8cBodTipoNro",gxvar:"AV8cBodTipoNro",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cBodTipoNro=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV8cBodTipoNro=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCBODTIPONRO",gx.O.AV8cBodTipoNro,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cBodTipoNro=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCBODTIPONRO",".")},nac:gx.falseFn};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"GRIDTABLE",grid:0};n[39]={id:39,fld:"",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"BTNTOGGLE",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[45]={id:45,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(44),gx.O.AV5LinkSelection,gx.O.AV16Linkselection_GXI)},c2v:function(){gx.O.AV16Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(44))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(44))},gxvar_GXI:"AV16Linkselection_GXI",nac:gx.falseFn};n[46]={id:46,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BODDETID",gxz:"Z285BodDetID",gxold:"O285BodDetID",gxvar:"A285BodDetID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A285BodDetID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z285BodDetID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("BODDETID",n||gx.fn.currentGridRowImpl(44),gx.O.A285BodDetID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A285BodDetID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("BODDETID",n||gx.fn.currentGridRowImpl(44),".")},nac:gx.falseFn};n[47]={id:47,lvl:2,type:"char",len:4,dec:0,sign:!1,ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"TIPOINV",gxz:"Z43TipoInv",gxold:"O43TipoInv",gxvar:"A43TipoInv",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A43TipoInv=n)},v2z:function(n){n!==undefined&&(gx.O.Z43TipoInv=n)},v2c:function(n){gx.fn.setGridControlValue("TIPOINV",n||gx.fn.currentGridRowImpl(44),gx.O.A43TipoInv,0)},c2v:function(){this.val()!==undefined&&(gx.O.A43TipoInv=this.val())},val:function(n){return gx.fn.getGridControlValue("TIPOINV",n||gx.fn.currentGridRowImpl(44))},nac:gx.falseFn};n[48]={id:48,lvl:2,type:"int",len:8,dec:0,sign:!1,pic:"ZZZZZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BODTIPONRO",gxz:"Z226BodTipoNro",gxold:"O226BodTipoNro",gxvar:"A226BodTipoNro",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A226BodTipoNro=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z226BodTipoNro=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("BODTIPONRO",n||gx.fn.currentGridRowImpl(44),gx.O.A226BodTipoNro,0)},c2v:function(){this.val()!==undefined&&(gx.O.A226BodTipoNro=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("BODTIPONRO",n||gx.fn.currentGridRowImpl(44),".")},nac:gx.falseFn};n[49]={id:49,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EMPID",gxz:"Z1EmpID",gxold:"O1EmpID",gxvar:"A1EmpID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A1EmpID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1EmpID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("EMPID",n||gx.fn.currentGridRowImpl(44),gx.O.A1EmpID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A1EmpID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("EMPID",n||gx.fn.currentGridRowImpl(44),".")},nac:gx.falseFn};n[50]={id:50,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BODCOD",gxz:"Z42BodCod",gxold:"O42BodCod",gxvar:"A42BodCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A42BodCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z42BodCod=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("BODCOD",n||gx.fn.currentGridRowImpl(44),gx.O.A42BodCod,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A42BodCod=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("BODCOD",n||gx.fn.currentGridRowImpl(44),".")},nac:gx.falseFn};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"",grid:0};n[53]={id:53,fld:"BTN_CANCEL",grid:0};this.AV6cBodDetID=0;this.ZV6cBodDetID=0;this.OV6cBodDetID=0;this.AV7cTipoInv="";this.ZV7cTipoInv="";this.OV7cTipoInv="";this.AV8cBodTipoNro=0;this.ZV8cBodTipoNro=0;this.OV8cBodTipoNro=0;this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z285BodDetID=0;this.O285BodDetID=0;this.Z43TipoInv="";this.O43TipoInv="";this.Z226BodTipoNro=0;this.O226BodTipoNro=0;this.Z1EmpID=0;this.O1EmpID=0;this.Z42BodCod=0;this.O42BodCod=0;this.AV6cBodDetID=0;this.AV7cTipoInv="";this.AV8cBodTipoNro=0;this.AV9pEmpID=0;this.AV10pBodCod=0;this.AV11pBodDetID=0;this.AV12pTipoInv="";this.AV5LinkSelection="";this.A285BodDetID=0;this.A43TipoInv="";this.A226BodTipoNro=0;this.A1EmpID=0;this.A42BodCod=0;this.Events={e174a2_client:["ENTER",!0],e184a1_client:["CANCEL",!0],e144a1_client:["'TOGGLE'",!1],e114a1_client:["LBLBODDETIDFILTER.CLICK",!1],e124a1_client:["LBLTIPOINVFILTER.CLICK",!1],e134a1_client:["LBLBODTIPONROFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cBodDetID",fld:"vCBODDETID",pic:"ZZZ9"},{av:"AV7cTipoInv",fld:"vCTIPOINV",pic:""},{av:"AV8cBodTipoNro",fld:"vCBODTIPONRO",pic:"ZZZZZZZ9"},{av:"AV9pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV10pBodCod",fld:"vPBODCOD",pic:"ZZZ9"}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLBODDETIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("BODDETIDFILTERCONTAINER","Class")',ctrl:"BODDETIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("BODDETIDFILTERCONTAINER","Class")',ctrl:"BODDETIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCBODDETID","Visible")',ctrl:"vCBODDETID",prop:"Visible"}]];this.EvtParms["LBLTIPOINVFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("TIPOINVFILTERCONTAINER","Class")',ctrl:"TIPOINVFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("TIPOINVFILTERCONTAINER","Class")',ctrl:"TIPOINVFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCTIPOINV","Visible")',ctrl:"vCTIPOINV",prop:"Visible"}]];this.EvtParms["LBLBODTIPONROFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("BODTIPONROFILTERCONTAINER","Class")',ctrl:"BODTIPONROFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("BODTIPONROFILTERCONTAINER","Class")',ctrl:"BODTIPONROFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCBODTIPONRO","Visible")',ctrl:"vCBODTIPONRO",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A285BodDetID",fld:"BODDETID",pic:"ZZZ9",hsh:!0},{av:"A43TipoInv",fld:"TIPOINV",pic:"",hsh:!0}],[{av:"AV11pBodDetID",fld:"vPBODDETID",pic:"ZZZ9"},{av:"AV12pTipoInv",fld:"vPTIPOINV",pic:""}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cBodDetID",fld:"vCBODDETID",pic:"ZZZ9"},{av:"AV7cTipoInv",fld:"vCTIPOINV",pic:""},{av:"AV8cBodTipoNro",fld:"vCBODTIPONRO",pic:"ZZZZZZZ9"},{av:"AV9pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV10pBodCod",fld:"vPBODCOD",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cBodDetID",fld:"vCBODDETID",pic:"ZZZ9"},{av:"AV7cTipoInv",fld:"vCTIPOINV",pic:""},{av:"AV8cBodTipoNro",fld:"vCBODTIPONRO",pic:"ZZZZZZZ9"},{av:"AV9pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV10pBodCod",fld:"vPBODCOD",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cBodDetID",fld:"vCBODDETID",pic:"ZZZ9"},{av:"AV7cTipoInv",fld:"vCTIPOINV",pic:""},{av:"AV8cBodTipoNro",fld:"vCBODTIPONRO",pic:"ZZZZZZZ9"},{av:"AV9pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV10pBodCod",fld:"vPBODCOD",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cBodDetID",fld:"vCBODDETID",pic:"ZZZ9"},{av:"AV7cTipoInv",fld:"vCTIPOINV",pic:""},{av:"AV8cBodTipoNro",fld:"vCBODTIPONRO",pic:"ZZZZZZZ9"},{av:"AV9pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV10pBodCod",fld:"vPBODCOD",pic:"ZZZ9"}],[]];this.setVCMap("AV9pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV10pBodCod","vPBODCOD",0,"int",4,0);this.setVCMap("AV11pBodDetID","vPBODDETID",0,"int",4,0);this.setVCMap("AV12pTipoInv","vPTIPOINV",0,"char",4,0);this.setVCMap("AV9pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV10pBodCod","vPBODCOD",0,"int",4,0);this.setVCMap("AV9pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV10pBodCod","vPBODCOD",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar({rfrVar:"AV9pEmpID"});t.addRefreshingVar({rfrVar:"AV10pBodCod"});this.Initialize()});gx.createParentObj(gx01h2)