/*!   GeneXus C# 15_0_12-126726 on 10/29/2022 1:8:38.86
*/
gx.evt.autoSkip=!1;gx.define("gx0200",!1,function(){var n,t;this.ServerClass="gx0200";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV13pEmpID=gx.fn.getIntegerValue("vPEMPID",".");this.AV14pAgeID=gx.fn.getIntegerValue("vPAGEID",".");this.AV15pPrdCod=gx.fn.getIntegerValue("vPPRDCOD",".")};this.e184w1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e114w1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("EMPIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("EMPIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCEMPID","Visible",!0)):(gx.fn.setCtrlProperty("EMPIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCEMPID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("EMPIDFILTERCONTAINER","Class")',ctrl:"EMPIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCEMPID","Visible")',ctrl:"vCEMPID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e124w1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("AGEIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("AGEIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCAGEID","Visible",!0)):(gx.fn.setCtrlProperty("AGEIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCAGEID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("AGEIDFILTERCONTAINER","Class")',ctrl:"AGEIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCAGEID","Visible")',ctrl:"vCAGEID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e134w1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("PRDCODFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PRDCODFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPRDCOD","Visible",!0)):(gx.fn.setCtrlProperty("PRDCODFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPRDCOD","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PRDCODFILTERCONTAINER","Class")',ctrl:"PRDCODFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPRDCOD","Visible")',ctrl:"vCPRDCOD",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e144w1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("PRDPRESFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PRDPRESFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPRDPRES","Visible",!0)):(gx.fn.setCtrlProperty("PRDPRESFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPRDPRES","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PRDPRESFILTERCONTAINER","Class")',ctrl:"PRDPRESFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPRDPRES","Visible")',ctrl:"vCPRDPRES",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e154w1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("PRDESTADOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PRDESTADOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPRDESTADO","Visible",!0)):(gx.fn.setCtrlProperty("PRDESTADOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPRDESTADO","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PRDESTADOFILTERCONTAINER","Class")',ctrl:"PRDESTADOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPRDESTADO","Visible")',ctrl:"vCPRDESTADO",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e164w1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("PRDDESCCORTAFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PRDDESCCORTAFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPRDDESCCORTA","Visible",!0)):(gx.fn.setCtrlProperty("PRDDESCCORTAFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPRDDESCCORTA","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PRDDESCCORTAFILTERCONTAINER","Class")',ctrl:"PRDDESCCORTAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPRDDESCCORTA","Visible")',ctrl:"vCPRDDESCCORTA",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e174w1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("PRDTIPPRDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PRDTIPPRDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPRDTIPPRD","Visible",!0)):(gx.fn.setCtrlProperty("PRDTIPPRDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPRDTIPPRD","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PRDTIPPRDFILTERCONTAINER","Class")',ctrl:"PRDTIPPRDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPRDTIPPRD","Visible")',ctrl:"vCPRDTIPPRD",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e214w2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e224w1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,85,86,87,88,89,90,91,92,93,94,95,96];this.GXLastCtrlId=96;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",84,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0200",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",85,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(1,86,"EMPID","Emp ID","","EmpID","int",0,"px",4,4,"right",null,[],1,"EmpID",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(2,87,"AGEID","Age ID","","AgeID","int",0,"px",4,4,"right",null,[],2,"AgeID",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(286,88,"PRDCOD","ID","","PrdCod","int",0,"px",4,4,"right",null,[],286,"PrdCod",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(288,89,"PRDPRES","Presentacion","","PrdPres","int",0,"px",2,2,"right",null,[],288,"PrdPres",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(289,90,"PRDESTADO","Estado","","PrdEstado","char",0,"px",1,1,"left",null,[],289,"PrdEstado",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(306,91,"PRDDESCCORTA","Corta","","PrdDescCorta","svchar",0,"px",40,40,"left",null,[],306,"PrdDescCorta",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(308,92,"PRDTIPPRD","Producto","","PrdTipPrd","int",0,"px",1,1,"right",null,[],308,"PrdTipPrd",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(31,93,"TIPOPRODID","tipo Prod ID","","tipoProdID","int",0,"px",4,4,"right",null,[],31,"tipoProdID",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"EMPIDFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLEMPIDFILTER",format:1,grid:0,evt:"e114w1_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCEMPID",gxz:"ZV6cEmpID",gxold:"OV6cEmpID",gxvar:"AV6cEmpID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cEmpID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cEmpID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCEMPID",gx.O.AV6cEmpID,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cEmpID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCEMPID",".")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"AGEIDFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLAGEIDFILTER",format:1,grid:0,evt:"e124w1_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCAGEID",gxz:"ZV7cAgeID",gxold:"OV7cAgeID",gxvar:"AV7cAgeID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cAgeID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV7cAgeID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCAGEID",gx.O.AV7cAgeID,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cAgeID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCAGEID",".")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"PRDCODFILTERCONTAINER",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"LBLPRDCODFILTER",format:1,grid:0,evt:"e134w1_client"};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCPRDCOD",gxz:"ZV8cPrdCod",gxold:"OV8cPrdCod",gxvar:"AV8cPrdCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cPrdCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV8cPrdCod=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCPRDCOD",gx.O.AV8cPrdCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cPrdCod=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCPRDCOD",".")},nac:gx.falseFn};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"PRDPRESFILTERCONTAINER",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"LBLPRDPRESFILTER",format:1,grid:0,evt:"e144w1_client"};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,lvl:0,type:"int",len:2,dec:0,sign:!1,pic:"Z9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCPRDPRES",gxz:"ZV10cPrdPres",gxold:"OV10cPrdPres",gxvar:"AV10cPrdPres",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10cPrdPres=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV10cPrdPres=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCPRDPRES",gx.O.AV10cPrdPres,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10cPrdPres=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCPRDPRES",".")},nac:gx.falseFn};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"PRDESTADOFILTERCONTAINER",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"LBLPRDESTADOFILTER",format:1,grid:0,evt:"e154w1_client"};n[53]={id:53,fld:"",grid:0};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"",grid:0};n[56]={id:56,lvl:0,type:"char",len:1,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCPRDESTADO",gxz:"ZV11cPrdEstado",gxold:"OV11cPrdEstado",gxvar:"AV11cPrdEstado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV11cPrdEstado=n)},v2z:function(n){n!==undefined&&(gx.O.ZV11cPrdEstado=n)},v2c:function(){gx.fn.setControlValue("vCPRDESTADO",gx.O.AV11cPrdEstado,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV11cPrdEstado=this.val())},val:function(){return gx.fn.getControlValue("vCPRDESTADO")},nac:gx.falseFn};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"",grid:0};n[59]={id:59,fld:"PRDDESCCORTAFILTERCONTAINER",grid:0};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"LBLPRDDESCCORTAFILTER",format:1,grid:0,evt:"e164w1_client"};n[63]={id:63,fld:"",grid:0};n[64]={id:64,fld:"",grid:0};n[65]={id:65,fld:"",grid:0};n[66]={id:66,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCPRDDESCCORTA",gxz:"ZV12cPrdDescCorta",gxold:"OV12cPrdDescCorta",gxvar:"AV12cPrdDescCorta",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV12cPrdDescCorta=n)},v2z:function(n){n!==undefined&&(gx.O.ZV12cPrdDescCorta=n)},v2c:function(){gx.fn.setControlValue("vCPRDDESCCORTA",gx.O.AV12cPrdDescCorta,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV12cPrdDescCorta=this.val())},val:function(){return gx.fn.getControlValue("vCPRDDESCCORTA")},nac:gx.falseFn};n[67]={id:67,fld:"",grid:0};n[68]={id:68,fld:"",grid:0};n[69]={id:69,fld:"PRDTIPPRDFILTERCONTAINER",grid:0};n[70]={id:70,fld:"",grid:0};n[71]={id:71,fld:"",grid:0};n[72]={id:72,fld:"LBLPRDTIPPRDFILTER",format:1,grid:0,evt:"e174w1_client"};n[73]={id:73,fld:"",grid:0};n[74]={id:74,fld:"",grid:0};n[75]={id:75,fld:"",grid:0};n[76]={id:76,lvl:0,type:"int",len:1,dec:0,sign:!1,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCPRDTIPPRD",gxz:"ZV17cPrdTipPrd",gxold:"OV17cPrdTipPrd",gxvar:"AV17cPrdTipPrd",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV17cPrdTipPrd=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV17cPrdTipPrd=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCPRDTIPPRD",gx.O.AV17cPrdTipPrd,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV17cPrdTipPrd=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCPRDTIPPRD",".")},nac:gx.falseFn};n[77]={id:77,fld:"",grid:0};n[78]={id:78,fld:"GRIDTABLE",grid:0};n[79]={id:79,fld:"",grid:0};n[80]={id:80,fld:"",grid:0};n[81]={id:81,fld:"BTNTOGGLE",grid:0};n[82]={id:82,fld:"",grid:0};n[83]={id:83,fld:"",grid:0};n[85]={id:85,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84),gx.O.AV5LinkSelection,gx.O.AV20Linkselection_GXI)},c2v:function(){gx.O.AV20Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(84))},gxvar_GXI:"AV20Linkselection_GXI",nac:gx.falseFn};n[86]={id:86,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EMPID",gxz:"Z1EmpID",gxold:"O1EmpID",gxvar:"A1EmpID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A1EmpID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1EmpID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("EMPID",n||gx.fn.currentGridRowImpl(84),gx.O.A1EmpID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A1EmpID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("EMPID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[87]={id:87,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"AGEID",gxz:"Z2AgeID",gxold:"O2AgeID",gxvar:"A2AgeID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A2AgeID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z2AgeID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("AGEID",n||gx.fn.currentGridRowImpl(84),gx.O.A2AgeID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A2AgeID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("AGEID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[88]={id:88,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PRDCOD",gxz:"Z286PrdCod",gxold:"O286PrdCod",gxvar:"A286PrdCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A286PrdCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z286PrdCod=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("PRDCOD",n||gx.fn.currentGridRowImpl(84),gx.O.A286PrdCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A286PrdCod=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("PRDCOD",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[89]={id:89,lvl:2,type:"int",len:2,dec:0,sign:!1,pic:"Z9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PRDPRES",gxz:"Z288PrdPres",gxold:"O288PrdPres",gxvar:"A288PrdPres",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A288PrdPres=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z288PrdPres=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("PRDPRES",n||gx.fn.currentGridRowImpl(84),gx.O.A288PrdPres,0)},c2v:function(){this.val()!==undefined&&(gx.O.A288PrdPres=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("PRDPRES",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[90]={id:90,lvl:2,type:"char",len:1,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PRDESTADO",gxz:"Z289PrdEstado",gxold:"O289PrdEstado",gxvar:"A289PrdEstado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A289PrdEstado=n)},v2z:function(n){n!==undefined&&(gx.O.Z289PrdEstado=n)},v2c:function(n){gx.fn.setGridControlValue("PRDESTADO",n||gx.fn.currentGridRowImpl(84),gx.O.A289PrdEstado,0)},c2v:function(){this.val()!==undefined&&(gx.O.A289PrdEstado=this.val())},val:function(n){return gx.fn.getGridControlValue("PRDESTADO",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[91]={id:91,lvl:2,type:"svchar",len:40,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PRDDESCCORTA",gxz:"Z306PrdDescCorta",gxold:"O306PrdDescCorta",gxvar:"A306PrdDescCorta",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A306PrdDescCorta=n)},v2z:function(n){n!==undefined&&(gx.O.Z306PrdDescCorta=n)},v2c:function(n){gx.fn.setGridControlValue("PRDDESCCORTA",n||gx.fn.currentGridRowImpl(84),gx.O.A306PrdDescCorta,0)},c2v:function(){this.val()!==undefined&&(gx.O.A306PrdDescCorta=this.val())},val:function(n){return gx.fn.getGridControlValue("PRDDESCCORTA",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[92]={id:92,lvl:2,type:"int",len:1,dec:0,sign:!1,pic:"9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PRDTIPPRD",gxz:"Z308PrdTipPrd",gxold:"O308PrdTipPrd",gxvar:"A308PrdTipPrd",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A308PrdTipPrd=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z308PrdTipPrd=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("PRDTIPPRD",n||gx.fn.currentGridRowImpl(84),gx.O.A308PrdTipPrd,0)},c2v:function(){this.val()!==undefined&&(gx.O.A308PrdTipPrd=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("PRDTIPPRD",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[93]={id:93,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"TIPOPRODID",gxz:"Z31tipoProdID",gxold:"O31tipoProdID",gxvar:"A31tipoProdID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A31tipoProdID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z31tipoProdID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("TIPOPRODID",n||gx.fn.currentGridRowImpl(84),gx.O.A31tipoProdID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A31tipoProdID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("TIPOPRODID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[94]={id:94,fld:"",grid:0};n[95]={id:95,fld:"",grid:0};n[96]={id:96,fld:"BTN_CANCEL",grid:0};this.AV6cEmpID=0;this.ZV6cEmpID=0;this.OV6cEmpID=0;this.AV7cAgeID=0;this.ZV7cAgeID=0;this.OV7cAgeID=0;this.AV8cPrdCod=0;this.ZV8cPrdCod=0;this.OV8cPrdCod=0;this.AV10cPrdPres=0;this.ZV10cPrdPres=0;this.OV10cPrdPres=0;this.AV11cPrdEstado="";this.ZV11cPrdEstado="";this.OV11cPrdEstado="";this.AV12cPrdDescCorta="";this.ZV12cPrdDescCorta="";this.OV12cPrdDescCorta="";this.AV17cPrdTipPrd=0;this.ZV17cPrdTipPrd=0;this.OV17cPrdTipPrd=0;this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z1EmpID=0;this.O1EmpID=0;this.Z2AgeID=0;this.O2AgeID=0;this.Z286PrdCod=0;this.O286PrdCod=0;this.Z288PrdPres=0;this.O288PrdPres=0;this.Z289PrdEstado="";this.O289PrdEstado="";this.Z306PrdDescCorta="";this.O306PrdDescCorta="";this.Z308PrdTipPrd=0;this.O308PrdTipPrd=0;this.Z31tipoProdID=0;this.O31tipoProdID=0;this.AV6cEmpID=0;this.AV7cAgeID=0;this.AV8cPrdCod=0;this.AV10cPrdPres=0;this.AV11cPrdEstado="";this.AV12cPrdDescCorta="";this.AV17cPrdTipPrd=0;this.AV13pEmpID=0;this.AV14pAgeID=0;this.AV15pPrdCod=0;this.AV5LinkSelection="";this.A1EmpID=0;this.A2AgeID=0;this.A286PrdCod=0;this.A288PrdPres=0;this.A289PrdEstado="";this.A306PrdDescCorta="";this.A308PrdTipPrd=0;this.A31tipoProdID=0;this.Events={e214w2_client:["ENTER",!0],e224w1_client:["CANCEL",!0],e184w1_client:["'TOGGLE'",!1],e114w1_client:["LBLEMPIDFILTER.CLICK",!1],e124w1_client:["LBLAGEIDFILTER.CLICK",!1],e134w1_client:["LBLPRDCODFILTER.CLICK",!1],e144w1_client:["LBLPRDPRESFILTER.CLICK",!1],e154w1_client:["LBLPRDESTADOFILTER.CLICK",!1],e164w1_client:["LBLPRDDESCCORTAFILTER.CLICK",!1],e174w1_client:["LBLPRDTIPPRDFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cEmpID",fld:"vCEMPID",pic:"ZZZ9"},{av:"AV7cAgeID",fld:"vCAGEID",pic:"ZZZ9"},{av:"AV8cPrdCod",fld:"vCPRDCOD",pic:"ZZZ9"},{av:"AV10cPrdPres",fld:"vCPRDPRES",pic:"Z9"},{av:"AV11cPrdEstado",fld:"vCPRDESTADO",pic:""},{av:"AV12cPrdDescCorta",fld:"vCPRDDESCCORTA",pic:""},{av:"AV17cPrdTipPrd",fld:"vCPRDTIPPRD",pic:"9"}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLEMPIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("EMPIDFILTERCONTAINER","Class")',ctrl:"EMPIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("EMPIDFILTERCONTAINER","Class")',ctrl:"EMPIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCEMPID","Visible")',ctrl:"vCEMPID",prop:"Visible"}]];this.EvtParms["LBLAGEIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("AGEIDFILTERCONTAINER","Class")',ctrl:"AGEIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("AGEIDFILTERCONTAINER","Class")',ctrl:"AGEIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCAGEID","Visible")',ctrl:"vCAGEID",prop:"Visible"}]];this.EvtParms["LBLPRDCODFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PRDCODFILTERCONTAINER","Class")',ctrl:"PRDCODFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PRDCODFILTERCONTAINER","Class")',ctrl:"PRDCODFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPRDCOD","Visible")',ctrl:"vCPRDCOD",prop:"Visible"}]];this.EvtParms["LBLPRDPRESFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PRDPRESFILTERCONTAINER","Class")',ctrl:"PRDPRESFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PRDPRESFILTERCONTAINER","Class")',ctrl:"PRDPRESFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPRDPRES","Visible")',ctrl:"vCPRDPRES",prop:"Visible"}]];this.EvtParms["LBLPRDESTADOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PRDESTADOFILTERCONTAINER","Class")',ctrl:"PRDESTADOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PRDESTADOFILTERCONTAINER","Class")',ctrl:"PRDESTADOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPRDESTADO","Visible")',ctrl:"vCPRDESTADO",prop:"Visible"}]];this.EvtParms["LBLPRDDESCCORTAFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PRDDESCCORTAFILTERCONTAINER","Class")',ctrl:"PRDDESCCORTAFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PRDDESCCORTAFILTERCONTAINER","Class")',ctrl:"PRDDESCCORTAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPRDDESCCORTA","Visible")',ctrl:"vCPRDDESCCORTA",prop:"Visible"}]];this.EvtParms["LBLPRDTIPPRDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PRDTIPPRDFILTERCONTAINER","Class")',ctrl:"PRDTIPPRDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PRDTIPPRDFILTERCONTAINER","Class")',ctrl:"PRDTIPPRDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPRDTIPPRD","Visible")',ctrl:"vCPRDTIPPRD",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9",hsh:!0},{av:"A2AgeID",fld:"AGEID",pic:"ZZZ9",hsh:!0},{av:"A286PrdCod",fld:"PRDCOD",pic:"ZZZ9",hsh:!0}],[{av:"AV13pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV14pAgeID",fld:"vPAGEID",pic:"ZZZ9"},{av:"AV15pPrdCod",fld:"vPPRDCOD",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cEmpID",fld:"vCEMPID",pic:"ZZZ9"},{av:"AV7cAgeID",fld:"vCAGEID",pic:"ZZZ9"},{av:"AV8cPrdCod",fld:"vCPRDCOD",pic:"ZZZ9"},{av:"AV10cPrdPres",fld:"vCPRDPRES",pic:"Z9"},{av:"AV11cPrdEstado",fld:"vCPRDESTADO",pic:""},{av:"AV12cPrdDescCorta",fld:"vCPRDDESCCORTA",pic:""},{av:"AV17cPrdTipPrd",fld:"vCPRDTIPPRD",pic:"9"}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cEmpID",fld:"vCEMPID",pic:"ZZZ9"},{av:"AV7cAgeID",fld:"vCAGEID",pic:"ZZZ9"},{av:"AV8cPrdCod",fld:"vCPRDCOD",pic:"ZZZ9"},{av:"AV10cPrdPres",fld:"vCPRDPRES",pic:"Z9"},{av:"AV11cPrdEstado",fld:"vCPRDESTADO",pic:""},{av:"AV12cPrdDescCorta",fld:"vCPRDDESCCORTA",pic:""},{av:"AV17cPrdTipPrd",fld:"vCPRDTIPPRD",pic:"9"}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cEmpID",fld:"vCEMPID",pic:"ZZZ9"},{av:"AV7cAgeID",fld:"vCAGEID",pic:"ZZZ9"},{av:"AV8cPrdCod",fld:"vCPRDCOD",pic:"ZZZ9"},{av:"AV10cPrdPres",fld:"vCPRDPRES",pic:"Z9"},{av:"AV11cPrdEstado",fld:"vCPRDESTADO",pic:""},{av:"AV12cPrdDescCorta",fld:"vCPRDDESCCORTA",pic:""},{av:"AV17cPrdTipPrd",fld:"vCPRDTIPPRD",pic:"9"}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cEmpID",fld:"vCEMPID",pic:"ZZZ9"},{av:"AV7cAgeID",fld:"vCAGEID",pic:"ZZZ9"},{av:"AV8cPrdCod",fld:"vCPRDCOD",pic:"ZZZ9"},{av:"AV10cPrdPres",fld:"vCPRDPRES",pic:"Z9"},{av:"AV11cPrdEstado",fld:"vCPRDESTADO",pic:""},{av:"AV12cPrdDescCorta",fld:"vCPRDDESCCORTA",pic:""},{av:"AV17cPrdTipPrd",fld:"vCPRDTIPPRD",pic:"9"}],[]];this.setVCMap("AV13pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV14pAgeID","vPAGEID",0,"int",4,0);this.setVCMap("AV15pPrdCod","vPPRDCOD",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);t.addRefreshingVar(this.GXValidFnc[66]);t.addRefreshingVar(this.GXValidFnc[76]);this.Initialize()});gx.createParentObj(gx0200)