/*!   GeneXus C# 15_0_12-126726 on 10/26/2022 20:17:46.28
*/
gx.evt.autoSkip=!1;gx.define("gx01e4",!1,function(){var n,t;this.ServerClass="gx01e4";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV9pEmpID=gx.fn.getIntegerValue("vPEMPID",".");this.AV10pAgeID=gx.fn.getIntegerValue("vPAGEID",".");this.AV11pBodCod=gx.fn.getIntegerValue("vPBODCOD",".");this.AV12pinvCod=gx.fn.getIntegerValue("vPINVCOD",".");this.AV13pdetInvOcId=gx.fn.getIntegerValue("vPDETINVOCID",".");this.AV9pEmpID=gx.fn.getIntegerValue("vPEMPID",".");this.AV10pAgeID=gx.fn.getIntegerValue("vPAGEID",".");this.AV11pBodCod=gx.fn.getIntegerValue("vPBODCOD",".");this.AV12pinvCod=gx.fn.getIntegerValue("vPINVCOD",".")};this.e14461_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e11461_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("DETINVOCIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("DETINVOCIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCDETINVOCID","Visible",!0)):(gx.fn.setCtrlProperty("DETINVOCIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCDETINVOCID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("DETINVOCIDFILTERCONTAINER","Class")',ctrl:"DETINVOCIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCDETINVOCID","Visible")',ctrl:"vCDETINVOCID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e12461_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("DETINVOCNROFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("DETINVOCNROFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCDETINVOCNRO","Visible",!0)):(gx.fn.setCtrlProperty("DETINVOCNROFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCDETINVOCNRO","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("DETINVOCNROFILTERCONTAINER","Class")',ctrl:"DETINVOCNROFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCDETINVOCNRO","Visible")',ctrl:"vCDETINVOCNRO",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e13461_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("DETINVOCDOCFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("DETINVOCDOCFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCDETINVOCDOC","Visible",!0)):(gx.fn.setCtrlProperty("DETINVOCDOCFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCDETINVOCDOC","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("DETINVOCDOCFILTERCONTAINER","Class")',ctrl:"DETINVOCDOCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCDETINVOCDOC","Visible")',ctrl:"vCDETINVOCDOC",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e17462_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e18461_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,45,46,47,48,49,50,51,52,53,54,55,56];this.GXLastCtrlId=56;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",44,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx01e4",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",45,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(282,46,"DETINVOCID","Oc Id","","detInvOcId","int",0,"px",4,4,"right",null,[],282,"detInvOcId",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(283,47,"DETINVOCNRO","OCNro","","detInvOCNro","int",0,"px",8,8,"right",null,[],283,"detInvOCNro",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(284,48,"DETINVOCDOC","Documento","","detInvOcDoc","char",0,"px",3,3,"left",null,[],284,"detInvOcDoc",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(37,49,"PRVRUC","Ruc","","PrvRuc","char",0,"px",13,13,"left",null,[],37,"PrvRuc",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(1,50,"EMPID","Emp ID","","EmpID","int",0,"px",4,4,"right",null,[],1,"EmpID",!1,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(2,51,"AGEID","Age ID","","AgeID","int",0,"px",4,4,"right",null,[],2,"AgeID",!1,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(42,52,"BODCOD","Bod Cod","","BodCod","int",0,"px",4,4,"right",null,[],42,"BodCod",!1,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(264,53,"INVCOD","inv Cod","","invCod","int",0,"px",4,4,"right",null,[],264,"invCod",!1,0,!1,!1,"Attribute",1,"");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"DETINVOCIDFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLDETINVOCIDFILTER",format:1,grid:0,evt:"e11461_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCDETINVOCID",gxz:"ZV6cdetInvOcId",gxold:"OV6cdetInvOcId",gxvar:"AV6cdetInvOcId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cdetInvOcId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cdetInvOcId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCDETINVOCID",gx.O.AV6cdetInvOcId,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cdetInvOcId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCDETINVOCID",".")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"DETINVOCNROFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLDETINVOCNROFILTER",format:1,grid:0,evt:"e12461_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"int",len:8,dec:0,sign:!1,pic:"ZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCDETINVOCNRO",gxz:"ZV8cdetInvOCNro",gxold:"OV8cdetInvOCNro",gxvar:"AV8cdetInvOCNro",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cdetInvOCNro=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV8cdetInvOCNro=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCDETINVOCNRO",gx.O.AV8cdetInvOCNro,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cdetInvOCNro=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCDETINVOCNRO",".")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"DETINVOCDOCFILTERCONTAINER",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"LBLDETINVOCDOCFILTER",format:1,grid:0,evt:"e13461_client"};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,lvl:0,type:"char",len:3,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCDETINVOCDOC",gxz:"ZV15cdetInvOcDoc",gxold:"OV15cdetInvOcDoc",gxvar:"AV15cdetInvOcDoc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV15cdetInvOcDoc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV15cdetInvOcDoc=n)},v2c:function(){gx.fn.setControlValue("vCDETINVOCDOC",gx.O.AV15cdetInvOcDoc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV15cdetInvOcDoc=this.val())},val:function(){return gx.fn.getControlValue("vCDETINVOCDOC")},nac:gx.falseFn};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"GRIDTABLE",grid:0};n[39]={id:39,fld:"",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"BTNTOGGLE",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[45]={id:45,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(44),gx.O.AV5LinkSelection,gx.O.AV18Linkselection_GXI)},c2v:function(){gx.O.AV18Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(44))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(44))},gxvar_GXI:"AV18Linkselection_GXI",nac:gx.falseFn};n[46]={id:46,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DETINVOCID",gxz:"Z282detInvOcId",gxold:"O282detInvOcId",gxvar:"A282detInvOcId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A282detInvOcId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z282detInvOcId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("DETINVOCID",n||gx.fn.currentGridRowImpl(44),gx.O.A282detInvOcId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A282detInvOcId=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("DETINVOCID",n||gx.fn.currentGridRowImpl(44),".")},nac:gx.falseFn};n[47]={id:47,lvl:2,type:"int",len:8,dec:0,sign:!1,pic:"ZZZZZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DETINVOCNRO",gxz:"Z283detInvOCNro",gxold:"O283detInvOCNro",gxvar:"A283detInvOCNro",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A283detInvOCNro=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z283detInvOCNro=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("DETINVOCNRO",n||gx.fn.currentGridRowImpl(44),gx.O.A283detInvOCNro,0)},c2v:function(){this.val()!==undefined&&(gx.O.A283detInvOCNro=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("DETINVOCNRO",n||gx.fn.currentGridRowImpl(44),".")},nac:gx.falseFn};n[48]={id:48,lvl:2,type:"char",len:3,dec:0,sign:!1,ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DETINVOCDOC",gxz:"Z284detInvOcDoc",gxold:"O284detInvOcDoc",gxvar:"A284detInvOcDoc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A284detInvOcDoc=n)},v2z:function(n){n!==undefined&&(gx.O.Z284detInvOcDoc=n)},v2c:function(n){gx.fn.setGridControlValue("DETINVOCDOC",n||gx.fn.currentGridRowImpl(44),gx.O.A284detInvOcDoc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A284detInvOcDoc=this.val())},val:function(n){return gx.fn.getGridControlValue("DETINVOCDOC",n||gx.fn.currentGridRowImpl(44))},nac:gx.falseFn};n[49]={id:49,lvl:2,type:"char",len:13,dec:0,sign:!1,ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PRVRUC",gxz:"Z37PrvRuc",gxold:"O37PrvRuc",gxvar:"A37PrvRuc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A37PrvRuc=n)},v2z:function(n){n!==undefined&&(gx.O.Z37PrvRuc=n)},v2c:function(n){gx.fn.setGridControlValue("PRVRUC",n||gx.fn.currentGridRowImpl(44),gx.O.A37PrvRuc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A37PrvRuc=this.val())},val:function(n){return gx.fn.getGridControlValue("PRVRUC",n||gx.fn.currentGridRowImpl(44))},nac:gx.falseFn};n[50]={id:50,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EMPID",gxz:"Z1EmpID",gxold:"O1EmpID",gxvar:"A1EmpID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A1EmpID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1EmpID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("EMPID",n||gx.fn.currentGridRowImpl(44),gx.O.A1EmpID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A1EmpID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("EMPID",n||gx.fn.currentGridRowImpl(44),".")},nac:gx.falseFn};n[51]={id:51,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"AGEID",gxz:"Z2AgeID",gxold:"O2AgeID",gxvar:"A2AgeID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A2AgeID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z2AgeID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("AGEID",n||gx.fn.currentGridRowImpl(44),gx.O.A2AgeID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A2AgeID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("AGEID",n||gx.fn.currentGridRowImpl(44),".")},nac:gx.falseFn};n[52]={id:52,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BODCOD",gxz:"Z42BodCod",gxold:"O42BodCod",gxvar:"A42BodCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A42BodCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z42BodCod=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("BODCOD",n||gx.fn.currentGridRowImpl(44),gx.O.A42BodCod,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A42BodCod=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("BODCOD",n||gx.fn.currentGridRowImpl(44),".")},nac:gx.falseFn};n[53]={id:53,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"INVCOD",gxz:"Z264invCod",gxold:"O264invCod",gxvar:"A264invCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A264invCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z264invCod=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("INVCOD",n||gx.fn.currentGridRowImpl(44),gx.O.A264invCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A264invCod=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("INVCOD",n||gx.fn.currentGridRowImpl(44),".")},nac:gx.falseFn};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"",grid:0};n[56]={id:56,fld:"BTN_CANCEL",grid:0};this.AV6cdetInvOcId=0;this.ZV6cdetInvOcId=0;this.OV6cdetInvOcId=0;this.AV8cdetInvOCNro=0;this.ZV8cdetInvOCNro=0;this.OV8cdetInvOCNro=0;this.AV15cdetInvOcDoc="";this.ZV15cdetInvOcDoc="";this.OV15cdetInvOcDoc="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z282detInvOcId=0;this.O282detInvOcId=0;this.Z283detInvOCNro=0;this.O283detInvOCNro=0;this.Z284detInvOcDoc="";this.O284detInvOcDoc="";this.Z37PrvRuc="";this.O37PrvRuc="";this.Z1EmpID=0;this.O1EmpID=0;this.Z2AgeID=0;this.O2AgeID=0;this.Z42BodCod=0;this.O42BodCod=0;this.Z264invCod=0;this.O264invCod=0;this.AV6cdetInvOcId=0;this.AV8cdetInvOCNro=0;this.AV15cdetInvOcDoc="";this.AV9pEmpID=0;this.AV10pAgeID=0;this.AV11pBodCod=0;this.AV12pinvCod=0;this.AV13pdetInvOcId=0;this.AV5LinkSelection="";this.A282detInvOcId=0;this.A283detInvOCNro=0;this.A284detInvOcDoc="";this.A37PrvRuc="";this.A1EmpID=0;this.A2AgeID=0;this.A42BodCod=0;this.A264invCod=0;this.Events={e17462_client:["ENTER",!0],e18461_client:["CANCEL",!0],e14461_client:["'TOGGLE'",!1],e11461_client:["LBLDETINVOCIDFILTER.CLICK",!1],e12461_client:["LBLDETINVOCNROFILTER.CLICK",!1],e13461_client:["LBLDETINVOCDOCFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cdetInvOcId",fld:"vCDETINVOCID",pic:"ZZZ9"},{av:"AV8cdetInvOCNro",fld:"vCDETINVOCNRO",pic:"ZZZZZZZ9"},{av:"AV15cdetInvOcDoc",fld:"vCDETINVOCDOC",pic:""},{av:"AV9pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV10pAgeID",fld:"vPAGEID",pic:"ZZZ9"},{av:"AV11pBodCod",fld:"vPBODCOD",pic:"ZZZ9"},{av:"AV12pinvCod",fld:"vPINVCOD",pic:"ZZZ9"}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLDETINVOCIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("DETINVOCIDFILTERCONTAINER","Class")',ctrl:"DETINVOCIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("DETINVOCIDFILTERCONTAINER","Class")',ctrl:"DETINVOCIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCDETINVOCID","Visible")',ctrl:"vCDETINVOCID",prop:"Visible"}]];this.EvtParms["LBLDETINVOCNROFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("DETINVOCNROFILTERCONTAINER","Class")',ctrl:"DETINVOCNROFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("DETINVOCNROFILTERCONTAINER","Class")',ctrl:"DETINVOCNROFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCDETINVOCNRO","Visible")',ctrl:"vCDETINVOCNRO",prop:"Visible"}]];this.EvtParms["LBLDETINVOCDOCFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("DETINVOCDOCFILTERCONTAINER","Class")',ctrl:"DETINVOCDOCFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("DETINVOCDOCFILTERCONTAINER","Class")',ctrl:"DETINVOCDOCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCDETINVOCDOC","Visible")',ctrl:"vCDETINVOCDOC",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A282detInvOcId",fld:"DETINVOCID",pic:"ZZZ9",hsh:!0}],[{av:"AV13pdetInvOcId",fld:"vPDETINVOCID",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cdetInvOcId",fld:"vCDETINVOCID",pic:"ZZZ9"},{av:"AV8cdetInvOCNro",fld:"vCDETINVOCNRO",pic:"ZZZZZZZ9"},{av:"AV15cdetInvOcDoc",fld:"vCDETINVOCDOC",pic:""},{av:"AV9pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV10pAgeID",fld:"vPAGEID",pic:"ZZZ9"},{av:"AV11pBodCod",fld:"vPBODCOD",pic:"ZZZ9"},{av:"AV12pinvCod",fld:"vPINVCOD",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cdetInvOcId",fld:"vCDETINVOCID",pic:"ZZZ9"},{av:"AV8cdetInvOCNro",fld:"vCDETINVOCNRO",pic:"ZZZZZZZ9"},{av:"AV15cdetInvOcDoc",fld:"vCDETINVOCDOC",pic:""},{av:"AV9pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV10pAgeID",fld:"vPAGEID",pic:"ZZZ9"},{av:"AV11pBodCod",fld:"vPBODCOD",pic:"ZZZ9"},{av:"AV12pinvCod",fld:"vPINVCOD",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cdetInvOcId",fld:"vCDETINVOCID",pic:"ZZZ9"},{av:"AV8cdetInvOCNro",fld:"vCDETINVOCNRO",pic:"ZZZZZZZ9"},{av:"AV15cdetInvOcDoc",fld:"vCDETINVOCDOC",pic:""},{av:"AV9pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV10pAgeID",fld:"vPAGEID",pic:"ZZZ9"},{av:"AV11pBodCod",fld:"vPBODCOD",pic:"ZZZ9"},{av:"AV12pinvCod",fld:"vPINVCOD",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cdetInvOcId",fld:"vCDETINVOCID",pic:"ZZZ9"},{av:"AV8cdetInvOCNro",fld:"vCDETINVOCNRO",pic:"ZZZZZZZ9"},{av:"AV15cdetInvOcDoc",fld:"vCDETINVOCDOC",pic:""},{av:"AV9pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV10pAgeID",fld:"vPAGEID",pic:"ZZZ9"},{av:"AV11pBodCod",fld:"vPBODCOD",pic:"ZZZ9"},{av:"AV12pinvCod",fld:"vPINVCOD",pic:"ZZZ9"}],[]];this.setVCMap("AV9pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV10pAgeID","vPAGEID",0,"int",4,0);this.setVCMap("AV11pBodCod","vPBODCOD",0,"int",4,0);this.setVCMap("AV12pinvCod","vPINVCOD",0,"int",4,0);this.setVCMap("AV13pdetInvOcId","vPDETINVOCID",0,"int",4,0);this.setVCMap("AV9pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV10pAgeID","vPAGEID",0,"int",4,0);this.setVCMap("AV11pBodCod","vPBODCOD",0,"int",4,0);this.setVCMap("AV12pinvCod","vPINVCOD",0,"int",4,0);this.setVCMap("AV9pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV10pAgeID","vPAGEID",0,"int",4,0);this.setVCMap("AV11pBodCod","vPBODCOD",0,"int",4,0);this.setVCMap("AV12pinvCod","vPINVCOD",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar({rfrVar:"AV9pEmpID"});t.addRefreshingVar({rfrVar:"AV10pAgeID"});t.addRefreshingVar({rfrVar:"AV11pBodCod"});t.addRefreshingVar({rfrVar:"AV12pinvCod"});this.Initialize()});gx.createParentObj(gx01e4)