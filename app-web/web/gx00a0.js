/*!   GeneXus C# 15_0_12-126726 on 10/26/2022 20:16:14.25
*/
gx.evt.autoSkip=!1;gx.define("gx00a0",!1,function(){var n,t;this.ServerClass="gx00a0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV11pEmpID=gx.fn.getIntegerValue("vPEMPID",".");this.AV12pprotID=gx.fn.getIntegerValue("vPPROTID",".")};this.e162n1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e112n1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("EMPIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("EMPIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCEMPID","Visible",!0)):(gx.fn.setCtrlProperty("EMPIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCEMPID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("EMPIDFILTERCONTAINER","Class")',ctrl:"EMPIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCEMPID","Visible")',ctrl:"vCEMPID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e122n1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("PROTIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PROTIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPROTID","Visible",!0)):(gx.fn.setCtrlProperty("PROTIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPROTID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PROTIDFILTERCONTAINER","Class")',ctrl:"PROTIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROTID","Visible")',ctrl:"vCPROTID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e132n1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("PROTDSCFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PROTDSCFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPROTDSC","Visible",!0)):(gx.fn.setCtrlProperty("PROTDSCFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPROTDSC","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PROTDSCFILTERCONTAINER","Class")',ctrl:"PROTDSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROTDSC","Visible")',ctrl:"vCPROTDSC",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e142n1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("PROTSIGLASFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PROTSIGLASFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPROTSIGLAS","Visible",!0)):(gx.fn.setCtrlProperty("PROTSIGLASFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPROTSIGLAS","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PROTSIGLASFILTERCONTAINER","Class")',ctrl:"PROTSIGLASFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROTSIGLAS","Visible")',ctrl:"vCPROTSIGLAS",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e152n1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("PROTESTFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PROTESTFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPROTEST","Visible",!0)):(gx.fn.setCtrlProperty("PROTESTFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPROTEST","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PROTESTFILTERCONTAINER","Class")',ctrl:"PROTESTFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROTEST","Visible")',ctrl:"vCPROTEST",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e192n2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e202n1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,65,66,67,68,69,70,71,72,73];this.GXLastCtrlId=73;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",64,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00a0",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",65,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(1,66,"EMPID","Emp ID","","EmpID","int",0,"px",4,4,"right",null,[],1,"EmpID",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(10,67,"PROTID","ID","","protID","int",0,"px",4,4,"right",null,[],10,"protID",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(74,68,"PROTDSC","Prototipo","","protDsc","char",0,"px",50,50,"left",null,[],74,"protDsc",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(122,69,"PROTSIGLAS","Siglas","","protSiglas","svchar",0,"px",5,5,"left",null,[],122,"protSiglas",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(75,70,"PROTEST","Est","","protEst","char",0,"px",1,1,"left",null,[],75,"protEst",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"EMPIDFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLEMPIDFILTER",format:1,grid:0,evt:"e112n1_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCEMPID",gxz:"ZV6cEmpID",gxold:"OV6cEmpID",gxvar:"AV6cEmpID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cEmpID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cEmpID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCEMPID",gx.O.AV6cEmpID,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cEmpID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCEMPID",".")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"PROTIDFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLPROTIDFILTER",format:1,grid:0,evt:"e122n1_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCPROTID",gxz:"ZV7cprotID",gxold:"OV7cprotID",gxvar:"AV7cprotID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cprotID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV7cprotID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCPROTID",gx.O.AV7cprotID,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cprotID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCPROTID",".")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"PROTDSCFILTERCONTAINER",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"LBLPROTDSCFILTER",format:1,grid:0,evt:"e132n1_client"};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,lvl:0,type:"char",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCPROTDSC",gxz:"ZV8cprotDsc",gxold:"OV8cprotDsc",gxvar:"AV8cprotDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cprotDsc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8cprotDsc=n)},v2c:function(){gx.fn.setControlValue("vCPROTDSC",gx.O.AV8cprotDsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cprotDsc=this.val())},val:function(){return gx.fn.getControlValue("vCPROTDSC")},nac:gx.falseFn};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"PROTSIGLASFILTERCONTAINER",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"LBLPROTSIGLASFILTER",format:1,grid:0,evt:"e142n1_client"};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,lvl:0,type:"svchar",len:5,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCPROTSIGLAS",gxz:"ZV9cprotSiglas",gxold:"OV9cprotSiglas",gxvar:"AV9cprotSiglas",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9cprotSiglas=n)},v2z:function(n){n!==undefined&&(gx.O.ZV9cprotSiglas=n)},v2c:function(){gx.fn.setControlValue("vCPROTSIGLAS",gx.O.AV9cprotSiglas,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9cprotSiglas=this.val())},val:function(){return gx.fn.getControlValue("vCPROTSIGLAS")},nac:gx.falseFn};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"PROTESTFILTERCONTAINER",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"LBLPROTESTFILTER",format:1,grid:0,evt:"e152n1_client"};n[53]={id:53,fld:"",grid:0};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"",grid:0};n[56]={id:56,lvl:0,type:"char",len:1,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCPROTEST",gxz:"ZV10cprotEst",gxold:"OV10cprotEst",gxvar:"AV10cprotEst",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10cprotEst=n)},v2z:function(n){n!==undefined&&(gx.O.ZV10cprotEst=n)},v2c:function(){gx.fn.setControlValue("vCPROTEST",gx.O.AV10cprotEst,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10cprotEst=this.val())},val:function(){return gx.fn.getControlValue("vCPROTEST")},nac:gx.falseFn};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"GRIDTABLE",grid:0};n[59]={id:59,fld:"",grid:0};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"BTNTOGGLE",grid:0};n[62]={id:62,fld:"",grid:0};n[63]={id:63,fld:"",grid:0};n[65]={id:65,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(64),gx.O.AV5LinkSelection,gx.O.AV16Linkselection_GXI)},c2v:function(){gx.O.AV16Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(64))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(64))},gxvar_GXI:"AV16Linkselection_GXI",nac:gx.falseFn};n[66]={id:66,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EMPID",gxz:"Z1EmpID",gxold:"O1EmpID",gxvar:"A1EmpID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A1EmpID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1EmpID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("EMPID",n||gx.fn.currentGridRowImpl(64),gx.O.A1EmpID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A1EmpID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("EMPID",n||gx.fn.currentGridRowImpl(64),".")},nac:gx.falseFn};n[67]={id:67,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PROTID",gxz:"Z10protID",gxold:"O10protID",gxvar:"A10protID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A10protID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z10protID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("PROTID",n||gx.fn.currentGridRowImpl(64),gx.O.A10protID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A10protID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("PROTID",n||gx.fn.currentGridRowImpl(64),".")},nac:gx.falseFn};n[68]={id:68,lvl:2,type:"char",len:50,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PROTDSC",gxz:"Z74protDsc",gxold:"O74protDsc",gxvar:"A74protDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A74protDsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z74protDsc=n)},v2c:function(n){gx.fn.setGridControlValue("PROTDSC",n||gx.fn.currentGridRowImpl(64),gx.O.A74protDsc,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A74protDsc=this.val())},val:function(n){return gx.fn.getGridControlValue("PROTDSC",n||gx.fn.currentGridRowImpl(64))},nac:gx.falseFn};n[69]={id:69,lvl:2,type:"svchar",len:5,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PROTSIGLAS",gxz:"Z122protSiglas",gxold:"O122protSiglas",gxvar:"A122protSiglas",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A122protSiglas=n)},v2z:function(n){n!==undefined&&(gx.O.Z122protSiglas=n)},v2c:function(n){gx.fn.setGridControlValue("PROTSIGLAS",n||gx.fn.currentGridRowImpl(64),gx.O.A122protSiglas,0)},c2v:function(){this.val()!==undefined&&(gx.O.A122protSiglas=this.val())},val:function(n){return gx.fn.getGridControlValue("PROTSIGLAS",n||gx.fn.currentGridRowImpl(64))},nac:gx.falseFn};n[70]={id:70,lvl:2,type:"char",len:1,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PROTEST",gxz:"Z75protEst",gxold:"O75protEst",gxvar:"A75protEst",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A75protEst=n)},v2z:function(n){n!==undefined&&(gx.O.Z75protEst=n)},v2c:function(n){gx.fn.setGridControlValue("PROTEST",n||gx.fn.currentGridRowImpl(64),gx.O.A75protEst,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A75protEst=this.val())},val:function(n){return gx.fn.getGridControlValue("PROTEST",n||gx.fn.currentGridRowImpl(64))},nac:gx.falseFn};n[71]={id:71,fld:"",grid:0};n[72]={id:72,fld:"",grid:0};n[73]={id:73,fld:"BTN_CANCEL",grid:0};this.AV6cEmpID=0;this.ZV6cEmpID=0;this.OV6cEmpID=0;this.AV7cprotID=0;this.ZV7cprotID=0;this.OV7cprotID=0;this.AV8cprotDsc="";this.ZV8cprotDsc="";this.OV8cprotDsc="";this.AV9cprotSiglas="";this.ZV9cprotSiglas="";this.OV9cprotSiglas="";this.AV10cprotEst="";this.ZV10cprotEst="";this.OV10cprotEst="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z1EmpID=0;this.O1EmpID=0;this.Z10protID=0;this.O10protID=0;this.Z74protDsc="";this.O74protDsc="";this.Z122protSiglas="";this.O122protSiglas="";this.Z75protEst="";this.O75protEst="";this.AV6cEmpID=0;this.AV7cprotID=0;this.AV8cprotDsc="";this.AV9cprotSiglas="";this.AV10cprotEst="";this.AV11pEmpID=0;this.AV12pprotID=0;this.AV5LinkSelection="";this.A1EmpID=0;this.A10protID=0;this.A74protDsc="";this.A122protSiglas="";this.A75protEst="";this.Events={e192n2_client:["ENTER",!0],e202n1_client:["CANCEL",!0],e162n1_client:["'TOGGLE'",!1],e112n1_client:["LBLEMPIDFILTER.CLICK",!1],e122n1_client:["LBLPROTIDFILTER.CLICK",!1],e132n1_client:["LBLPROTDSCFILTER.CLICK",!1],e142n1_client:["LBLPROTSIGLASFILTER.CLICK",!1],e152n1_client:["LBLPROTESTFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cEmpID",fld:"vCEMPID",pic:"ZZZ9"},{av:"AV7cprotID",fld:"vCPROTID",pic:"ZZZ9"},{av:"AV8cprotDsc",fld:"vCPROTDSC",pic:""},{av:"AV9cprotSiglas",fld:"vCPROTSIGLAS",pic:""},{av:"AV10cprotEst",fld:"vCPROTEST",pic:""}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLEMPIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("EMPIDFILTERCONTAINER","Class")',ctrl:"EMPIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("EMPIDFILTERCONTAINER","Class")',ctrl:"EMPIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCEMPID","Visible")',ctrl:"vCEMPID",prop:"Visible"}]];this.EvtParms["LBLPROTIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PROTIDFILTERCONTAINER","Class")',ctrl:"PROTIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PROTIDFILTERCONTAINER","Class")',ctrl:"PROTIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROTID","Visible")',ctrl:"vCPROTID",prop:"Visible"}]];this.EvtParms["LBLPROTDSCFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PROTDSCFILTERCONTAINER","Class")',ctrl:"PROTDSCFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PROTDSCFILTERCONTAINER","Class")',ctrl:"PROTDSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROTDSC","Visible")',ctrl:"vCPROTDSC",prop:"Visible"}]];this.EvtParms["LBLPROTSIGLASFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PROTSIGLASFILTERCONTAINER","Class")',ctrl:"PROTSIGLASFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PROTSIGLASFILTERCONTAINER","Class")',ctrl:"PROTSIGLASFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROTSIGLAS","Visible")',ctrl:"vCPROTSIGLAS",prop:"Visible"}]];this.EvtParms["LBLPROTESTFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PROTESTFILTERCONTAINER","Class")',ctrl:"PROTESTFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PROTESTFILTERCONTAINER","Class")',ctrl:"PROTESTFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROTEST","Visible")',ctrl:"vCPROTEST",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9",hsh:!0},{av:"A10protID",fld:"PROTID",pic:"ZZZ9",hsh:!0}],[{av:"AV11pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV12pprotID",fld:"vPPROTID",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cEmpID",fld:"vCEMPID",pic:"ZZZ9"},{av:"AV7cprotID",fld:"vCPROTID",pic:"ZZZ9"},{av:"AV8cprotDsc",fld:"vCPROTDSC",pic:""},{av:"AV9cprotSiglas",fld:"vCPROTSIGLAS",pic:""},{av:"AV10cprotEst",fld:"vCPROTEST",pic:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cEmpID",fld:"vCEMPID",pic:"ZZZ9"},{av:"AV7cprotID",fld:"vCPROTID",pic:"ZZZ9"},{av:"AV8cprotDsc",fld:"vCPROTDSC",pic:""},{av:"AV9cprotSiglas",fld:"vCPROTSIGLAS",pic:""},{av:"AV10cprotEst",fld:"vCPROTEST",pic:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cEmpID",fld:"vCEMPID",pic:"ZZZ9"},{av:"AV7cprotID",fld:"vCPROTID",pic:"ZZZ9"},{av:"AV8cprotDsc",fld:"vCPROTDSC",pic:""},{av:"AV9cprotSiglas",fld:"vCPROTSIGLAS",pic:""},{av:"AV10cprotEst",fld:"vCPROTEST",pic:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cEmpID",fld:"vCEMPID",pic:"ZZZ9"},{av:"AV7cprotID",fld:"vCPROTID",pic:"ZZZ9"},{av:"AV8cprotDsc",fld:"vCPROTDSC",pic:""},{av:"AV9cprotSiglas",fld:"vCPROTSIGLAS",pic:""},{av:"AV10cprotEst",fld:"vCPROTEST",pic:""}],[]];this.setVCMap("AV11pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV12pprotID","vPPROTID",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);this.Initialize()});gx.createParentObj(gx00a0)