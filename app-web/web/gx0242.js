/*!   GeneXus C# 15_0_12-126726 on 10/26/2022 20:18:21.92
*/
gx.evt.autoSkip=!1;gx.define("gx0242",!1,function(){var n,t;this.ServerClass="gx0242";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV9pEmpID=gx.fn.getIntegerValue("vPEMPID",".");this.AV10pAgeID=gx.fn.getIntegerValue("vPAGEID",".");this.AV11pClaOCCod=gx.fn.getControlValue("vPCLAOCCOD");this.AV9pEmpID=gx.fn.getIntegerValue("vPEMPID",".");this.AV10pAgeID=gx.fn.getIntegerValue("vPAGEID",".")};this.e14561_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e11561_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("CLAOCCODFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("CLAOCCODFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCLAOCCOD","Visible",!0)):(gx.fn.setCtrlProperty("CLAOCCODFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCLAOCCOD","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CLAOCCODFILTERCONTAINER","Class")',ctrl:"CLAOCCODFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLAOCCOD","Visible")',ctrl:"vCCLAOCCOD",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e12561_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("CLAOCDSCFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("CLAOCDSCFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCLAOCDSC","Visible",!0)):(gx.fn.setCtrlProperty("CLAOCDSCFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCLAOCDSC","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CLAOCDSCFILTERCONTAINER","Class")',ctrl:"CLAOCDSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLAOCDSC","Visible")',ctrl:"vCCLAOCDSC",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e13561_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("CLAOCESTFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("CLAOCESTFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCLAOCEST","Visible",!0)):(gx.fn.setCtrlProperty("CLAOCESTFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCLAOCEST","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CLAOCESTFILTERCONTAINER","Class")',ctrl:"CLAOCESTFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLAOCEST","Visible")',ctrl:"vCCLAOCEST",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e17562_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e18561_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,45,46,47,48,49,50,51,52,53];this.GXLastCtrlId=53;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",44,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0242",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",45,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(321,46,"CLAOCCOD","Clase","","ClaOCCod","char",0,"px",3,3,"left",null,[],321,"ClaOCCod",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(322,47,"CLAOCDSC","Descripcion","","ClaOCDsc","char",0,"px",40,40,"left",null,[],322,"ClaOCDsc",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(323,48,"CLAOCEST","Estado","","ClaOCEst","char",0,"px",1,1,"left",null,[],323,"ClaOCEst",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(1,49,"EMPID","Emp ID","","EmpID","int",0,"px",4,4,"right",null,[],1,"EmpID",!1,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(2,50,"AGEID","Age ID","","AgeID","int",0,"px",4,4,"right",null,[],2,"AgeID",!1,0,!1,!1,"Attribute",1,"");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"CLAOCCODFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLCLAOCCODFILTER",format:1,grid:0,evt:"e11561_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"char",len:3,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCCLAOCCOD",gxz:"ZV6cClaOCCod",gxold:"OV6cClaOCCod",gxvar:"AV6cClaOCCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cClaOCCod=n)},v2z:function(n){n!==undefined&&(gx.O.ZV6cClaOCCod=n)},v2c:function(){gx.fn.setControlValue("vCCLAOCCOD",gx.O.AV6cClaOCCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cClaOCCod=this.val())},val:function(){return gx.fn.getControlValue("vCCLAOCCOD")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"CLAOCDSCFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLCLAOCDSCFILTER",format:1,grid:0,evt:"e12561_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"char",len:40,dec:0,sign:!1,pic:"@!",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCCLAOCDSC",gxz:"ZV7cClaOCDsc",gxold:"OV7cClaOCDsc",gxvar:"AV7cClaOCDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cClaOCDsc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7cClaOCDsc=n)},v2c:function(){gx.fn.setControlValue("vCCLAOCDSC",gx.O.AV7cClaOCDsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cClaOCDsc=this.val())},val:function(){return gx.fn.getControlValue("vCCLAOCDSC")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"CLAOCESTFILTERCONTAINER",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"LBLCLAOCESTFILTER",format:1,grid:0,evt:"e13561_client"};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,lvl:0,type:"char",len:1,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCCLAOCEST",gxz:"ZV8cClaOCEst",gxold:"OV8cClaOCEst",gxvar:"AV8cClaOCEst",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cClaOCEst=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8cClaOCEst=n)},v2c:function(){gx.fn.setControlValue("vCCLAOCEST",gx.O.AV8cClaOCEst,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cClaOCEst=this.val())},val:function(){return gx.fn.getControlValue("vCCLAOCEST")},nac:gx.falseFn};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"GRIDTABLE",grid:0};n[39]={id:39,fld:"",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"BTNTOGGLE",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[45]={id:45,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(44),gx.O.AV5LinkSelection,gx.O.AV15Linkselection_GXI)},c2v:function(){gx.O.AV15Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(44))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(44))},gxvar_GXI:"AV15Linkselection_GXI",nac:gx.falseFn};n[46]={id:46,lvl:2,type:"char",len:3,dec:0,sign:!1,ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CLAOCCOD",gxz:"Z321ClaOCCod",gxold:"O321ClaOCCod",gxvar:"A321ClaOCCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A321ClaOCCod=n)},v2z:function(n){n!==undefined&&(gx.O.Z321ClaOCCod=n)},v2c:function(n){gx.fn.setGridControlValue("CLAOCCOD",n||gx.fn.currentGridRowImpl(44),gx.O.A321ClaOCCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A321ClaOCCod=this.val())},val:function(n){return gx.fn.getGridControlValue("CLAOCCOD",n||gx.fn.currentGridRowImpl(44))},nac:gx.falseFn};n[47]={id:47,lvl:2,type:"char",len:40,dec:0,sign:!1,pic:"@!",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CLAOCDSC",gxz:"Z322ClaOCDsc",gxold:"O322ClaOCDsc",gxvar:"A322ClaOCDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A322ClaOCDsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z322ClaOCDsc=n)},v2c:function(n){gx.fn.setGridControlValue("CLAOCDSC",n||gx.fn.currentGridRowImpl(44),gx.O.A322ClaOCDsc,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A322ClaOCDsc=this.val())},val:function(n){return gx.fn.getGridControlValue("CLAOCDSC",n||gx.fn.currentGridRowImpl(44))},nac:gx.falseFn};n[48]={id:48,lvl:2,type:"char",len:1,dec:0,sign:!1,ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CLAOCEST",gxz:"Z323ClaOCEst",gxold:"O323ClaOCEst",gxvar:"A323ClaOCEst",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A323ClaOCEst=n)},v2z:function(n){n!==undefined&&(gx.O.Z323ClaOCEst=n)},v2c:function(n){gx.fn.setGridControlValue("CLAOCEST",n||gx.fn.currentGridRowImpl(44),gx.O.A323ClaOCEst,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A323ClaOCEst=this.val())},val:function(n){return gx.fn.getGridControlValue("CLAOCEST",n||gx.fn.currentGridRowImpl(44))},nac:gx.falseFn};n[49]={id:49,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EMPID",gxz:"Z1EmpID",gxold:"O1EmpID",gxvar:"A1EmpID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A1EmpID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1EmpID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("EMPID",n||gx.fn.currentGridRowImpl(44),gx.O.A1EmpID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A1EmpID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("EMPID",n||gx.fn.currentGridRowImpl(44),".")},nac:gx.falseFn};n[50]={id:50,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"AGEID",gxz:"Z2AgeID",gxold:"O2AgeID",gxvar:"A2AgeID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A2AgeID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z2AgeID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("AGEID",n||gx.fn.currentGridRowImpl(44),gx.O.A2AgeID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A2AgeID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("AGEID",n||gx.fn.currentGridRowImpl(44),".")},nac:gx.falseFn};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"",grid:0};n[53]={id:53,fld:"BTN_CANCEL",grid:0};this.AV6cClaOCCod="";this.ZV6cClaOCCod="";this.OV6cClaOCCod="";this.AV7cClaOCDsc="";this.ZV7cClaOCDsc="";this.OV7cClaOCDsc="";this.AV8cClaOCEst="";this.ZV8cClaOCEst="";this.OV8cClaOCEst="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z321ClaOCCod="";this.O321ClaOCCod="";this.Z322ClaOCDsc="";this.O322ClaOCDsc="";this.Z323ClaOCEst="";this.O323ClaOCEst="";this.Z1EmpID=0;this.O1EmpID=0;this.Z2AgeID=0;this.O2AgeID=0;this.AV6cClaOCCod="";this.AV7cClaOCDsc="";this.AV8cClaOCEst="";this.AV9pEmpID=0;this.AV10pAgeID=0;this.AV11pClaOCCod="";this.AV5LinkSelection="";this.A321ClaOCCod="";this.A322ClaOCDsc="";this.A323ClaOCEst="";this.A1EmpID=0;this.A2AgeID=0;this.Events={e17562_client:["ENTER",!0],e18561_client:["CANCEL",!0],e14561_client:["'TOGGLE'",!1],e11561_client:["LBLCLAOCCODFILTER.CLICK",!1],e12561_client:["LBLCLAOCDSCFILTER.CLICK",!1],e13561_client:["LBLCLAOCESTFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cClaOCCod",fld:"vCCLAOCCOD",pic:""},{av:"AV7cClaOCDsc",fld:"vCCLAOCDSC",pic:"@!"},{av:"AV8cClaOCEst",fld:"vCCLAOCEST",pic:""},{av:"AV9pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV10pAgeID",fld:"vPAGEID",pic:"ZZZ9"}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLCLAOCCODFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CLAOCCODFILTERCONTAINER","Class")',ctrl:"CLAOCCODFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CLAOCCODFILTERCONTAINER","Class")',ctrl:"CLAOCCODFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLAOCCOD","Visible")',ctrl:"vCCLAOCCOD",prop:"Visible"}]];this.EvtParms["LBLCLAOCDSCFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CLAOCDSCFILTERCONTAINER","Class")',ctrl:"CLAOCDSCFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CLAOCDSCFILTERCONTAINER","Class")',ctrl:"CLAOCDSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLAOCDSC","Visible")',ctrl:"vCCLAOCDSC",prop:"Visible"}]];this.EvtParms["LBLCLAOCESTFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CLAOCESTFILTERCONTAINER","Class")',ctrl:"CLAOCESTFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CLAOCESTFILTERCONTAINER","Class")',ctrl:"CLAOCESTFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLAOCEST","Visible")',ctrl:"vCCLAOCEST",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A321ClaOCCod",fld:"CLAOCCOD",pic:"",hsh:!0}],[{av:"AV11pClaOCCod",fld:"vPCLAOCCOD",pic:""}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cClaOCCod",fld:"vCCLAOCCOD",pic:""},{av:"AV7cClaOCDsc",fld:"vCCLAOCDSC",pic:"@!"},{av:"AV8cClaOCEst",fld:"vCCLAOCEST",pic:""},{av:"AV9pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV10pAgeID",fld:"vPAGEID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cClaOCCod",fld:"vCCLAOCCOD",pic:""},{av:"AV7cClaOCDsc",fld:"vCCLAOCDSC",pic:"@!"},{av:"AV8cClaOCEst",fld:"vCCLAOCEST",pic:""},{av:"AV9pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV10pAgeID",fld:"vPAGEID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cClaOCCod",fld:"vCCLAOCCOD",pic:""},{av:"AV7cClaOCDsc",fld:"vCCLAOCDSC",pic:"@!"},{av:"AV8cClaOCEst",fld:"vCCLAOCEST",pic:""},{av:"AV9pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV10pAgeID",fld:"vPAGEID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cClaOCCod",fld:"vCCLAOCCOD",pic:""},{av:"AV7cClaOCDsc",fld:"vCCLAOCDSC",pic:"@!"},{av:"AV8cClaOCEst",fld:"vCCLAOCEST",pic:""},{av:"AV9pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV10pAgeID",fld:"vPAGEID",pic:"ZZZ9"}],[]];this.setVCMap("AV9pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV10pAgeID","vPAGEID",0,"int",4,0);this.setVCMap("AV11pClaOCCod","vPCLAOCCOD",0,"char",3,0);this.setVCMap("AV9pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV10pAgeID","vPAGEID",0,"int",4,0);this.setVCMap("AV9pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV10pAgeID","vPAGEID",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar({rfrVar:"AV9pEmpID"});t.addRefreshingVar({rfrVar:"AV10pAgeID"});this.Initialize()});gx.createParentObj(gx0242)