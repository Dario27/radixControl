/*!   GeneXus C# 15_0_12-126726 on 10/26/2022 20:16:9.76
*/
gx.evt.autoSkip=!1;gx.define("gx0050",!1,function(){var n,t;this.ServerClass="gx0050";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV13pEmpID=gx.fn.getIntegerValue("vPEMPID",".");this.AV14pClienteID=gx.fn.getIntegerValue("vPCLIENTEID",".")};this.e182j1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e112j1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("EMPIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("EMPIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCEMPID","Visible",!0)):(gx.fn.setCtrlProperty("EMPIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCEMPID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("EMPIDFILTERCONTAINER","Class")',ctrl:"EMPIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCEMPID","Visible")',ctrl:"vCEMPID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e122j1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("CLIENTEIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("CLIENTEIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCLIENTEID","Visible",!0)):(gx.fn.setCtrlProperty("CLIENTEIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCLIENTEID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CLIENTEIDFILTERCONTAINER","Class")',ctrl:"CLIENTEIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLIENTEID","Visible")',ctrl:"vCCLIENTEID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e132j1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("CLIENTERUCFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("CLIENTERUCFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCLIENTERUC","Visible",!0)):(gx.fn.setCtrlProperty("CLIENTERUCFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCLIENTERUC","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CLIENTERUCFILTERCONTAINER","Class")',ctrl:"CLIENTERUCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLIENTERUC","Visible")',ctrl:"vCCLIENTERUC",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e142j1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("CLIENTEDSCFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("CLIENTEDSCFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCLIENTEDSC","Visible",!0)):(gx.fn.setCtrlProperty("CLIENTEDSCFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCLIENTEDSC","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CLIENTEDSCFILTERCONTAINER","Class")',ctrl:"CLIENTEDSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLIENTEDSC","Visible")',ctrl:"vCCLIENTEDSC",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e152j1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("TIPCLIENTIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("TIPCLIENTIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCTIPCLIENTID","Visible",!0)):(gx.fn.setCtrlProperty("TIPCLIENTIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCTIPCLIENTID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("TIPCLIENTIDFILTERCONTAINER","Class")',ctrl:"TIPCLIENTIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCTIPCLIENTID","Visible")',ctrl:"vCTIPCLIENTID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e162j1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("CLIENTETELFFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("CLIENTETELFFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCLIENTETELF","Visible",!0)):(gx.fn.setCtrlProperty("CLIENTETELFFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCLIENTETELF","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CLIENTETELFFILTERCONTAINER","Class")',ctrl:"CLIENTETELFFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLIENTETELF","Visible")',ctrl:"vCCLIENTETELF",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e172j1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("CLIENTEESTFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("CLIENTEESTFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCLIENTEEST","Visible",!0)):(gx.fn.setCtrlProperty("CLIENTEESTFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCLIENTEEST","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CLIENTEESTFILTERCONTAINER","Class")',ctrl:"CLIENTEESTFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLIENTEEST","Visible")',ctrl:"vCCLIENTEEST",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e212j2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e222j1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,85,86,87,88,89,90,91,92,93,94,95];this.GXLastCtrlId=95;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",84,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0050",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",85,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(1,86,"EMPID","Emp ID","","EmpID","int",0,"px",4,4,"right",null,[],1,"EmpID",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(5,87,"CLIENTEID","ID","","ClienteID","int",0,"px",4,4,"right",null,[],5,"ClienteID",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(56,88,"CLIENTERUC","CI","","ClienteRUC","char",0,"px",13,13,"left",null,[],56,"ClienteRUC",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(57,89,"CLIENTEDSC","Razon Social","","ClienteDsc","char",0,"px",50,50,"left",null,[],57,"ClienteDsc",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(4,90,"TIPCLIENTID","Codigo","","TipClientID","int",0,"px",4,4,"right",null,[],4,"TipClientID",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(58,91,"CLIENTETELF","Telf","","ClienteTelf","svchar",0,"px",20,20,"left",null,[],58,"ClienteTelf",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(59,92,"CLIENTEEST","Est","","ClienteEst","char",0,"px",1,1,"left",null,[],59,"ClienteEst",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"EMPIDFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLEMPIDFILTER",format:1,grid:0,evt:"e112j1_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCEMPID",gxz:"ZV6cEmpID",gxold:"OV6cEmpID",gxvar:"AV6cEmpID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cEmpID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cEmpID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCEMPID",gx.O.AV6cEmpID,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cEmpID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCEMPID",".")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"CLIENTEIDFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLCLIENTEIDFILTER",format:1,grid:0,evt:"e122j1_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCCLIENTEID",gxz:"ZV7cClienteID",gxold:"OV7cClienteID",gxvar:"AV7cClienteID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cClienteID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV7cClienteID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCCLIENTEID",gx.O.AV7cClienteID,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cClienteID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCCLIENTEID",".")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"CLIENTERUCFILTERCONTAINER",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"LBLCLIENTERUCFILTER",format:1,grid:0,evt:"e132j1_client"};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,lvl:0,type:"char",len:13,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCCLIENTERUC",gxz:"ZV8cClienteRUC",gxold:"OV8cClienteRUC",gxvar:"AV8cClienteRUC",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cClienteRUC=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8cClienteRUC=n)},v2c:function(){gx.fn.setControlValue("vCCLIENTERUC",gx.O.AV8cClienteRUC,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cClienteRUC=this.val())},val:function(){return gx.fn.getControlValue("vCCLIENTERUC")},nac:gx.falseFn};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"CLIENTEDSCFILTERCONTAINER",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"LBLCLIENTEDSCFILTER",format:1,grid:0,evt:"e142j1_client"};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,lvl:0,type:"char",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCCLIENTEDSC",gxz:"ZV9cClienteDsc",gxold:"OV9cClienteDsc",gxvar:"AV9cClienteDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9cClienteDsc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV9cClienteDsc=n)},v2c:function(){gx.fn.setControlValue("vCCLIENTEDSC",gx.O.AV9cClienteDsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9cClienteDsc=this.val())},val:function(){return gx.fn.getControlValue("vCCLIENTEDSC")},nac:gx.falseFn};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"TIPCLIENTIDFILTERCONTAINER",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"LBLTIPCLIENTIDFILTER",format:1,grid:0,evt:"e152j1_client"};n[53]={id:53,fld:"",grid:0};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"",grid:0};n[56]={id:56,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCTIPCLIENTID",gxz:"ZV10cTipClientID",gxold:"OV10cTipClientID",gxvar:"AV10cTipClientID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10cTipClientID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV10cTipClientID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCTIPCLIENTID",gx.O.AV10cTipClientID,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10cTipClientID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCTIPCLIENTID",".")},nac:gx.falseFn};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"",grid:0};n[59]={id:59,fld:"CLIENTETELFFILTERCONTAINER",grid:0};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"LBLCLIENTETELFFILTER",format:1,grid:0,evt:"e162j1_client"};n[63]={id:63,fld:"",grid:0};n[64]={id:64,fld:"",grid:0};n[65]={id:65,fld:"",grid:0};n[66]={id:66,lvl:0,type:"svchar",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCCLIENTETELF",gxz:"ZV11cClienteTelf",gxold:"OV11cClienteTelf",gxvar:"AV11cClienteTelf",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV11cClienteTelf=n)},v2z:function(n){n!==undefined&&(gx.O.ZV11cClienteTelf=n)},v2c:function(){gx.fn.setControlValue("vCCLIENTETELF",gx.O.AV11cClienteTelf,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV11cClienteTelf=this.val())},val:function(){return gx.fn.getControlValue("vCCLIENTETELF")},nac:gx.falseFn};n[67]={id:67,fld:"",grid:0};n[68]={id:68,fld:"",grid:0};n[69]={id:69,fld:"CLIENTEESTFILTERCONTAINER",grid:0};n[70]={id:70,fld:"",grid:0};n[71]={id:71,fld:"",grid:0};n[72]={id:72,fld:"LBLCLIENTEESTFILTER",format:1,grid:0,evt:"e172j1_client"};n[73]={id:73,fld:"",grid:0};n[74]={id:74,fld:"",grid:0};n[75]={id:75,fld:"",grid:0};n[76]={id:76,lvl:0,type:"char",len:1,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCCLIENTEEST",gxz:"ZV12cClienteEst",gxold:"OV12cClienteEst",gxvar:"AV12cClienteEst",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV12cClienteEst=n)},v2z:function(n){n!==undefined&&(gx.O.ZV12cClienteEst=n)},v2c:function(){gx.fn.setControlValue("vCCLIENTEEST",gx.O.AV12cClienteEst,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV12cClienteEst=this.val())},val:function(){return gx.fn.getControlValue("vCCLIENTEEST")},nac:gx.falseFn};n[77]={id:77,fld:"",grid:0};n[78]={id:78,fld:"GRIDTABLE",grid:0};n[79]={id:79,fld:"",grid:0};n[80]={id:80,fld:"",grid:0};n[81]={id:81,fld:"BTNTOGGLE",grid:0};n[82]={id:82,fld:"",grid:0};n[83]={id:83,fld:"",grid:0};n[85]={id:85,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84),gx.O.AV5LinkSelection,gx.O.AV18Linkselection_GXI)},c2v:function(){gx.O.AV18Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(84))},gxvar_GXI:"AV18Linkselection_GXI",nac:gx.falseFn};n[86]={id:86,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EMPID",gxz:"Z1EmpID",gxold:"O1EmpID",gxvar:"A1EmpID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A1EmpID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1EmpID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("EMPID",n||gx.fn.currentGridRowImpl(84),gx.O.A1EmpID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A1EmpID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("EMPID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[87]={id:87,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CLIENTEID",gxz:"Z5ClienteID",gxold:"O5ClienteID",gxvar:"A5ClienteID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A5ClienteID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z5ClienteID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("CLIENTEID",n||gx.fn.currentGridRowImpl(84),gx.O.A5ClienteID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A5ClienteID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("CLIENTEID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[88]={id:88,lvl:2,type:"char",len:13,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CLIENTERUC",gxz:"Z56ClienteRUC",gxold:"O56ClienteRUC",gxvar:"A56ClienteRUC",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A56ClienteRUC=n)},v2z:function(n){n!==undefined&&(gx.O.Z56ClienteRUC=n)},v2c:function(n){gx.fn.setGridControlValue("CLIENTERUC",n||gx.fn.currentGridRowImpl(84),gx.O.A56ClienteRUC,0)},c2v:function(){this.val()!==undefined&&(gx.O.A56ClienteRUC=this.val())},val:function(n){return gx.fn.getGridControlValue("CLIENTERUC",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[89]={id:89,lvl:2,type:"char",len:50,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CLIENTEDSC",gxz:"Z57ClienteDsc",gxold:"O57ClienteDsc",gxvar:"A57ClienteDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A57ClienteDsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z57ClienteDsc=n)},v2c:function(n){gx.fn.setGridControlValue("CLIENTEDSC",n||gx.fn.currentGridRowImpl(84),gx.O.A57ClienteDsc,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A57ClienteDsc=this.val())},val:function(n){return gx.fn.getGridControlValue("CLIENTEDSC",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[90]={id:90,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"TIPCLIENTID",gxz:"Z4TipClientID",gxold:"O4TipClientID",gxvar:"A4TipClientID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A4TipClientID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z4TipClientID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("TIPCLIENTID",n||gx.fn.currentGridRowImpl(84),gx.O.A4TipClientID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A4TipClientID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("TIPCLIENTID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[91]={id:91,lvl:2,type:"svchar",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CLIENTETELF",gxz:"Z58ClienteTelf",gxold:"O58ClienteTelf",gxvar:"A58ClienteTelf",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A58ClienteTelf=n)},v2z:function(n){n!==undefined&&(gx.O.Z58ClienteTelf=n)},v2c:function(n){gx.fn.setGridControlValue("CLIENTETELF",n||gx.fn.currentGridRowImpl(84),gx.O.A58ClienteTelf,0)},c2v:function(){this.val()!==undefined&&(gx.O.A58ClienteTelf=this.val())},val:function(n){return gx.fn.getGridControlValue("CLIENTETELF",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[92]={id:92,lvl:2,type:"char",len:1,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CLIENTEEST",gxz:"Z59ClienteEst",gxold:"O59ClienteEst",gxvar:"A59ClienteEst",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A59ClienteEst=n)},v2z:function(n){n!==undefined&&(gx.O.Z59ClienteEst=n)},v2c:function(n){gx.fn.setGridControlValue("CLIENTEEST",n||gx.fn.currentGridRowImpl(84),gx.O.A59ClienteEst,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A59ClienteEst=this.val())},val:function(n){return gx.fn.getGridControlValue("CLIENTEEST",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[93]={id:93,fld:"",grid:0};n[94]={id:94,fld:"",grid:0};n[95]={id:95,fld:"BTN_CANCEL",grid:0};this.AV6cEmpID=0;this.ZV6cEmpID=0;this.OV6cEmpID=0;this.AV7cClienteID=0;this.ZV7cClienteID=0;this.OV7cClienteID=0;this.AV8cClienteRUC="";this.ZV8cClienteRUC="";this.OV8cClienteRUC="";this.AV9cClienteDsc="";this.ZV9cClienteDsc="";this.OV9cClienteDsc="";this.AV10cTipClientID=0;this.ZV10cTipClientID=0;this.OV10cTipClientID=0;this.AV11cClienteTelf="";this.ZV11cClienteTelf="";this.OV11cClienteTelf="";this.AV12cClienteEst="";this.ZV12cClienteEst="";this.OV12cClienteEst="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z1EmpID=0;this.O1EmpID=0;this.Z5ClienteID=0;this.O5ClienteID=0;this.Z56ClienteRUC="";this.O56ClienteRUC="";this.Z57ClienteDsc="";this.O57ClienteDsc="";this.Z4TipClientID=0;this.O4TipClientID=0;this.Z58ClienteTelf="";this.O58ClienteTelf="";this.Z59ClienteEst="";this.O59ClienteEst="";this.AV6cEmpID=0;this.AV7cClienteID=0;this.AV8cClienteRUC="";this.AV9cClienteDsc="";this.AV10cTipClientID=0;this.AV11cClienteTelf="";this.AV12cClienteEst="";this.AV13pEmpID=0;this.AV14pClienteID=0;this.AV5LinkSelection="";this.A1EmpID=0;this.A5ClienteID=0;this.A56ClienteRUC="";this.A57ClienteDsc="";this.A4TipClientID=0;this.A58ClienteTelf="";this.A59ClienteEst="";this.Events={e212j2_client:["ENTER",!0],e222j1_client:["CANCEL",!0],e182j1_client:["'TOGGLE'",!1],e112j1_client:["LBLEMPIDFILTER.CLICK",!1],e122j1_client:["LBLCLIENTEIDFILTER.CLICK",!1],e132j1_client:["LBLCLIENTERUCFILTER.CLICK",!1],e142j1_client:["LBLCLIENTEDSCFILTER.CLICK",!1],e152j1_client:["LBLTIPCLIENTIDFILTER.CLICK",!1],e162j1_client:["LBLCLIENTETELFFILTER.CLICK",!1],e172j1_client:["LBLCLIENTEESTFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cEmpID",fld:"vCEMPID",pic:"ZZZ9"},{av:"AV7cClienteID",fld:"vCCLIENTEID",pic:"ZZZ9"},{av:"AV8cClienteRUC",fld:"vCCLIENTERUC",pic:""},{av:"AV9cClienteDsc",fld:"vCCLIENTEDSC",pic:""},{av:"AV10cTipClientID",fld:"vCTIPCLIENTID",pic:"ZZZ9"},{av:"AV11cClienteTelf",fld:"vCCLIENTETELF",pic:""},{av:"AV12cClienteEst",fld:"vCCLIENTEEST",pic:""}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLEMPIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("EMPIDFILTERCONTAINER","Class")',ctrl:"EMPIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("EMPIDFILTERCONTAINER","Class")',ctrl:"EMPIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCEMPID","Visible")',ctrl:"vCEMPID",prop:"Visible"}]];this.EvtParms["LBLCLIENTEIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CLIENTEIDFILTERCONTAINER","Class")',ctrl:"CLIENTEIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CLIENTEIDFILTERCONTAINER","Class")',ctrl:"CLIENTEIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLIENTEID","Visible")',ctrl:"vCCLIENTEID",prop:"Visible"}]];this.EvtParms["LBLCLIENTERUCFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CLIENTERUCFILTERCONTAINER","Class")',ctrl:"CLIENTERUCFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CLIENTERUCFILTERCONTAINER","Class")',ctrl:"CLIENTERUCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLIENTERUC","Visible")',ctrl:"vCCLIENTERUC",prop:"Visible"}]];this.EvtParms["LBLCLIENTEDSCFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CLIENTEDSCFILTERCONTAINER","Class")',ctrl:"CLIENTEDSCFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CLIENTEDSCFILTERCONTAINER","Class")',ctrl:"CLIENTEDSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLIENTEDSC","Visible")',ctrl:"vCCLIENTEDSC",prop:"Visible"}]];this.EvtParms["LBLTIPCLIENTIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("TIPCLIENTIDFILTERCONTAINER","Class")',ctrl:"TIPCLIENTIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("TIPCLIENTIDFILTERCONTAINER","Class")',ctrl:"TIPCLIENTIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCTIPCLIENTID","Visible")',ctrl:"vCTIPCLIENTID",prop:"Visible"}]];this.EvtParms["LBLCLIENTETELFFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CLIENTETELFFILTERCONTAINER","Class")',ctrl:"CLIENTETELFFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CLIENTETELFFILTERCONTAINER","Class")',ctrl:"CLIENTETELFFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLIENTETELF","Visible")',ctrl:"vCCLIENTETELF",prop:"Visible"}]];this.EvtParms["LBLCLIENTEESTFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CLIENTEESTFILTERCONTAINER","Class")',ctrl:"CLIENTEESTFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CLIENTEESTFILTERCONTAINER","Class")',ctrl:"CLIENTEESTFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLIENTEEST","Visible")',ctrl:"vCCLIENTEEST",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9",hsh:!0},{av:"A5ClienteID",fld:"CLIENTEID",pic:"ZZZ9",hsh:!0}],[{av:"AV13pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV14pClienteID",fld:"vPCLIENTEID",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cEmpID",fld:"vCEMPID",pic:"ZZZ9"},{av:"AV7cClienteID",fld:"vCCLIENTEID",pic:"ZZZ9"},{av:"AV8cClienteRUC",fld:"vCCLIENTERUC",pic:""},{av:"AV9cClienteDsc",fld:"vCCLIENTEDSC",pic:""},{av:"AV10cTipClientID",fld:"vCTIPCLIENTID",pic:"ZZZ9"},{av:"AV11cClienteTelf",fld:"vCCLIENTETELF",pic:""},{av:"AV12cClienteEst",fld:"vCCLIENTEEST",pic:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cEmpID",fld:"vCEMPID",pic:"ZZZ9"},{av:"AV7cClienteID",fld:"vCCLIENTEID",pic:"ZZZ9"},{av:"AV8cClienteRUC",fld:"vCCLIENTERUC",pic:""},{av:"AV9cClienteDsc",fld:"vCCLIENTEDSC",pic:""},{av:"AV10cTipClientID",fld:"vCTIPCLIENTID",pic:"ZZZ9"},{av:"AV11cClienteTelf",fld:"vCCLIENTETELF",pic:""},{av:"AV12cClienteEst",fld:"vCCLIENTEEST",pic:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cEmpID",fld:"vCEMPID",pic:"ZZZ9"},{av:"AV7cClienteID",fld:"vCCLIENTEID",pic:"ZZZ9"},{av:"AV8cClienteRUC",fld:"vCCLIENTERUC",pic:""},{av:"AV9cClienteDsc",fld:"vCCLIENTEDSC",pic:""},{av:"AV10cTipClientID",fld:"vCTIPCLIENTID",pic:"ZZZ9"},{av:"AV11cClienteTelf",fld:"vCCLIENTETELF",pic:""},{av:"AV12cClienteEst",fld:"vCCLIENTEEST",pic:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cEmpID",fld:"vCEMPID",pic:"ZZZ9"},{av:"AV7cClienteID",fld:"vCCLIENTEID",pic:"ZZZ9"},{av:"AV8cClienteRUC",fld:"vCCLIENTERUC",pic:""},{av:"AV9cClienteDsc",fld:"vCCLIENTEDSC",pic:""},{av:"AV10cTipClientID",fld:"vCTIPCLIENTID",pic:"ZZZ9"},{av:"AV11cClienteTelf",fld:"vCCLIENTETELF",pic:""},{av:"AV12cClienteEst",fld:"vCCLIENTEEST",pic:""}],[]];this.setVCMap("AV13pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV14pClienteID","vPCLIENTEID",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);t.addRefreshingVar(this.GXValidFnc[66]);t.addRefreshingVar(this.GXValidFnc[76]);this.Initialize()});gx.createParentObj(gx0050)