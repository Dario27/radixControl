/*!   GeneXus C# 15_0_12-126726 on 10/26/2022 20:16:4.78
*/
gx.evt.autoSkip=!1;gx.define("gx0060",!1,function(){var n,t;this.ServerClass="gx0060";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV10pEmpID=gx.fn.getIntegerValue("vPEMPID",".");this.AV11pMarcaID=gx.fn.getIntegerValue("vPMARCAID",".")};this.e152k1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e112k1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("EMPIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("EMPIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCEMPID","Visible",!0)):(gx.fn.setCtrlProperty("EMPIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCEMPID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("EMPIDFILTERCONTAINER","Class")',ctrl:"EMPIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCEMPID","Visible")',ctrl:"vCEMPID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e122k1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("MARCAIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("MARCAIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCMARCAID","Visible",!0)):(gx.fn.setCtrlProperty("MARCAIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCMARCAID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MARCAIDFILTERCONTAINER","Class")',ctrl:"MARCAIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMARCAID","Visible")',ctrl:"vCMARCAID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e132k1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("MARCADSCFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("MARCADSCFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCMARCADSC","Visible",!0)):(gx.fn.setCtrlProperty("MARCADSCFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCMARCADSC","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MARCADSCFILTERCONTAINER","Class")',ctrl:"MARCADSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMARCADSC","Visible")',ctrl:"vCMARCADSC",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e142k1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("MARCAESTFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("MARCAESTFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCMARCAEST","Visible",!0)):(gx.fn.setCtrlProperty("MARCAESTFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCMARCAEST","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MARCAESTFILTERCONTAINER","Class")',ctrl:"MARCAESTFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMARCAEST","Visible")',ctrl:"vCMARCAEST",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e182k2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e192k1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,55,56,57,58,59,60,61,62];this.GXLastCtrlId=62;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",54,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0060",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",55,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(1,56,"EMPID","Emp ID","","EmpID","int",0,"px",4,4,"right",null,[],1,"EmpID",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(6,57,"MARCAID","ID","","MarcaID","int",0,"px",4,4,"right",null,[],6,"MarcaID",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(62,58,"MARCADSC","Dsc","","MarcaDsc","char",0,"px",50,50,"left",null,[],62,"MarcaDsc",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(63,59,"MARCAEST","Est","","MarcaEst","char",0,"px",1,1,"left",null,[],63,"MarcaEst",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"EMPIDFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLEMPIDFILTER",format:1,grid:0,evt:"e112k1_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCEMPID",gxz:"ZV6cEmpID",gxold:"OV6cEmpID",gxvar:"AV6cEmpID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cEmpID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cEmpID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCEMPID",gx.O.AV6cEmpID,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cEmpID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCEMPID",".")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"MARCAIDFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLMARCAIDFILTER",format:1,grid:0,evt:"e122k1_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCMARCAID",gxz:"ZV7cMarcaID",gxold:"OV7cMarcaID",gxvar:"AV7cMarcaID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cMarcaID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV7cMarcaID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCMARCAID",gx.O.AV7cMarcaID,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cMarcaID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCMARCAID",".")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"MARCADSCFILTERCONTAINER",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"LBLMARCADSCFILTER",format:1,grid:0,evt:"e132k1_client"};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,lvl:0,type:"char",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCMARCADSC",gxz:"ZV8cMarcaDsc",gxold:"OV8cMarcaDsc",gxvar:"AV8cMarcaDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cMarcaDsc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8cMarcaDsc=n)},v2c:function(){gx.fn.setControlValue("vCMARCADSC",gx.O.AV8cMarcaDsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cMarcaDsc=this.val())},val:function(){return gx.fn.getControlValue("vCMARCADSC")},nac:gx.falseFn};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"MARCAESTFILTERCONTAINER",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"LBLMARCAESTFILTER",format:1,grid:0,evt:"e142k1_client"};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,lvl:0,type:"char",len:1,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCMARCAEST",gxz:"ZV9cMarcaEst",gxold:"OV9cMarcaEst",gxvar:"AV9cMarcaEst",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9cMarcaEst=n)},v2z:function(n){n!==undefined&&(gx.O.ZV9cMarcaEst=n)},v2c:function(){gx.fn.setControlValue("vCMARCAEST",gx.O.AV9cMarcaEst,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9cMarcaEst=this.val())},val:function(){return gx.fn.getControlValue("vCMARCAEST")},nac:gx.falseFn};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"GRIDTABLE",grid:0};n[49]={id:49,fld:"",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"BTNTOGGLE",grid:0};n[52]={id:52,fld:"",grid:0};n[53]={id:53,fld:"",grid:0};n[55]={id:55,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:54,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(54),gx.O.AV5LinkSelection,gx.O.AV15Linkselection_GXI)},c2v:function(){gx.O.AV15Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(54))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(54))},gxvar_GXI:"AV15Linkselection_GXI",nac:gx.falseFn};n[56]={id:56,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:54,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EMPID",gxz:"Z1EmpID",gxold:"O1EmpID",gxvar:"A1EmpID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A1EmpID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1EmpID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("EMPID",n||gx.fn.currentGridRowImpl(54),gx.O.A1EmpID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A1EmpID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("EMPID",n||gx.fn.currentGridRowImpl(54),".")},nac:gx.falseFn};n[57]={id:57,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:54,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"MARCAID",gxz:"Z6MarcaID",gxold:"O6MarcaID",gxvar:"A6MarcaID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A6MarcaID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z6MarcaID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("MARCAID",n||gx.fn.currentGridRowImpl(54),gx.O.A6MarcaID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A6MarcaID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("MARCAID",n||gx.fn.currentGridRowImpl(54),".")},nac:gx.falseFn};n[58]={id:58,lvl:2,type:"char",len:50,dec:0,sign:!1,ro:1,isacc:0,grid:54,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"MARCADSC",gxz:"Z62MarcaDsc",gxold:"O62MarcaDsc",gxvar:"A62MarcaDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A62MarcaDsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z62MarcaDsc=n)},v2c:function(n){gx.fn.setGridControlValue("MARCADSC",n||gx.fn.currentGridRowImpl(54),gx.O.A62MarcaDsc,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A62MarcaDsc=this.val())},val:function(n){return gx.fn.getGridControlValue("MARCADSC",n||gx.fn.currentGridRowImpl(54))},nac:gx.falseFn};n[59]={id:59,lvl:2,type:"char",len:1,dec:0,sign:!1,ro:1,isacc:0,grid:54,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"MARCAEST",gxz:"Z63MarcaEst",gxold:"O63MarcaEst",gxvar:"A63MarcaEst",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A63MarcaEst=n)},v2z:function(n){n!==undefined&&(gx.O.Z63MarcaEst=n)},v2c:function(n){gx.fn.setGridControlValue("MARCAEST",n||gx.fn.currentGridRowImpl(54),gx.O.A63MarcaEst,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A63MarcaEst=this.val())},val:function(n){return gx.fn.getGridControlValue("MARCAEST",n||gx.fn.currentGridRowImpl(54))},nac:gx.falseFn};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"BTN_CANCEL",grid:0};this.AV6cEmpID=0;this.ZV6cEmpID=0;this.OV6cEmpID=0;this.AV7cMarcaID=0;this.ZV7cMarcaID=0;this.OV7cMarcaID=0;this.AV8cMarcaDsc="";this.ZV8cMarcaDsc="";this.OV8cMarcaDsc="";this.AV9cMarcaEst="";this.ZV9cMarcaEst="";this.OV9cMarcaEst="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z1EmpID=0;this.O1EmpID=0;this.Z6MarcaID=0;this.O6MarcaID=0;this.Z62MarcaDsc="";this.O62MarcaDsc="";this.Z63MarcaEst="";this.O63MarcaEst="";this.AV6cEmpID=0;this.AV7cMarcaID=0;this.AV8cMarcaDsc="";this.AV9cMarcaEst="";this.AV10pEmpID=0;this.AV11pMarcaID=0;this.AV5LinkSelection="";this.A1EmpID=0;this.A6MarcaID=0;this.A62MarcaDsc="";this.A63MarcaEst="";this.Events={e182k2_client:["ENTER",!0],e192k1_client:["CANCEL",!0],e152k1_client:["'TOGGLE'",!1],e112k1_client:["LBLEMPIDFILTER.CLICK",!1],e122k1_client:["LBLMARCAIDFILTER.CLICK",!1],e132k1_client:["LBLMARCADSCFILTER.CLICK",!1],e142k1_client:["LBLMARCAESTFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cEmpID",fld:"vCEMPID",pic:"ZZZ9"},{av:"AV7cMarcaID",fld:"vCMARCAID",pic:"ZZZ9"},{av:"AV8cMarcaDsc",fld:"vCMARCADSC",pic:""},{av:"AV9cMarcaEst",fld:"vCMARCAEST",pic:""}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLEMPIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("EMPIDFILTERCONTAINER","Class")',ctrl:"EMPIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("EMPIDFILTERCONTAINER","Class")',ctrl:"EMPIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCEMPID","Visible")',ctrl:"vCEMPID",prop:"Visible"}]];this.EvtParms["LBLMARCAIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MARCAIDFILTERCONTAINER","Class")',ctrl:"MARCAIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MARCAIDFILTERCONTAINER","Class")',ctrl:"MARCAIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMARCAID","Visible")',ctrl:"vCMARCAID",prop:"Visible"}]];this.EvtParms["LBLMARCADSCFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MARCADSCFILTERCONTAINER","Class")',ctrl:"MARCADSCFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MARCADSCFILTERCONTAINER","Class")',ctrl:"MARCADSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMARCADSC","Visible")',ctrl:"vCMARCADSC",prop:"Visible"}]];this.EvtParms["LBLMARCAESTFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MARCAESTFILTERCONTAINER","Class")',ctrl:"MARCAESTFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MARCAESTFILTERCONTAINER","Class")',ctrl:"MARCAESTFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMARCAEST","Visible")',ctrl:"vCMARCAEST",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9",hsh:!0},{av:"A6MarcaID",fld:"MARCAID",pic:"ZZZ9",hsh:!0}],[{av:"AV10pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV11pMarcaID",fld:"vPMARCAID",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cEmpID",fld:"vCEMPID",pic:"ZZZ9"},{av:"AV7cMarcaID",fld:"vCMARCAID",pic:"ZZZ9"},{av:"AV8cMarcaDsc",fld:"vCMARCADSC",pic:""},{av:"AV9cMarcaEst",fld:"vCMARCAEST",pic:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cEmpID",fld:"vCEMPID",pic:"ZZZ9"},{av:"AV7cMarcaID",fld:"vCMARCAID",pic:"ZZZ9"},{av:"AV8cMarcaDsc",fld:"vCMARCADSC",pic:""},{av:"AV9cMarcaEst",fld:"vCMARCAEST",pic:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cEmpID",fld:"vCEMPID",pic:"ZZZ9"},{av:"AV7cMarcaID",fld:"vCMARCAID",pic:"ZZZ9"},{av:"AV8cMarcaDsc",fld:"vCMARCADSC",pic:""},{av:"AV9cMarcaEst",fld:"vCMARCAEST",pic:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cEmpID",fld:"vCEMPID",pic:"ZZZ9"},{av:"AV7cMarcaID",fld:"vCMARCAID",pic:"ZZZ9"},{av:"AV8cMarcaDsc",fld:"vCMARCADSC",pic:""},{av:"AV9cMarcaEst",fld:"vCMARCAEST",pic:""}],[]];this.setVCMap("AV10pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV11pMarcaID","vPMARCAID",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);this.Initialize()});gx.createParentObj(gx0060)