/*!   GeneXus C# 15_0_11-124690 on 9/11/2022 0:27:0.71
*/
gx.evt.autoSkip=!1;gx.define("gx01x0",!1,function(){var n,t;this.ServerClass="gx01x0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV13pEmpID=gx.fn.getIntegerValue("vPEMPID",".");this.AV14pAgeID=gx.fn.getIntegerValue("vPAGEID",".");this.AV15pPrdCod=gx.fn.getIntegerValue("vPPRDCOD",".")};this.Validv_Cfecha=function(){try{var n=gx.util.balloon.getNew("vCFECHA");if(this.AnyError=0,!(new gx.date.gxdate("").compare(this.AV9cfecha)==0||new gx.date.gxdate(this.AV9cfecha).compare(gx.date.ymdtod(1753,01,01))>=0))try{n.setError("Campo fecha fuera de rango");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e184t1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),$.Deferred().resolve()};this.e114t1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("EMPIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("EMPIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCEMPID","Visible",!0)):(gx.fn.setCtrlProperty("EMPIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCEMPID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("EMPIDFILTERCONTAINER","Class")',ctrl:"EMPIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCEMPID","Visible")',ctrl:"vCEMPID",prop:"Visible"}]),$.Deferred().resolve()};this.e124t1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("AGEIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("AGEIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCAGEID","Visible",!0)):(gx.fn.setCtrlProperty("AGEIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCAGEID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("AGEIDFILTERCONTAINER","Class")',ctrl:"AGEIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCAGEID","Visible")',ctrl:"vCAGEID",prop:"Visible"}]),$.Deferred().resolve()};this.e134t1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("PRDCODFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PRDCODFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPRDCOD","Visible",!0)):(gx.fn.setCtrlProperty("PRDCODFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPRDCOD","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PRDCODFILTERCONTAINER","Class")',ctrl:"PRDCODFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPRDCOD","Visible")',ctrl:"vCPRDCOD",prop:"Visible"}]),$.Deferred().resolve()};this.e144t1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("FECHAFILTERCONTAINER","Class")=="AdvancedContainerItem"?gx.fn.setCtrlProperty("FECHAFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"):gx.fn.setCtrlProperty("FECHAFILTERCONTAINER","Class","AdvancedContainerItem"),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("FECHAFILTERCONTAINER","Class")',ctrl:"FECHAFILTERCONTAINER",prop:"Class"}]),$.Deferred().resolve()};this.e154t1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("VALANTFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("VALANTFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCVALANT","Visible",!0)):(gx.fn.setCtrlProperty("VALANTFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCVALANT","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("VALANTFILTERCONTAINER","Class")',ctrl:"VALANTFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCVALANT","Visible")',ctrl:"vCVALANT",prop:"Visible"}]),$.Deferred().resolve()};this.e164t1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("VALOACTFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("VALOACTFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCVALOACT","Visible",!0)):(gx.fn.setCtrlProperty("VALOACTFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCVALOACT","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("VALOACTFILTERCONTAINER","Class")',ctrl:"VALOACTFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCVALOACT","Visible")',ctrl:"vCVALOACT",prop:"Visible"}]),$.Deferred().resolve()};this.e174t1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("USUCODFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("USUCODFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCUSUCOD","Visible",!0)):(gx.fn.setCtrlProperty("USUCODFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCUSUCOD","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("USUCODFILTERCONTAINER","Class")',ctrl:"USUCODFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSUCOD","Visible")',ctrl:"vCUSUCOD",prop:"Visible"}]),$.Deferred().resolve()};this.e214t2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e224t1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,85,86,87,88,89,90,91,92,93,94,95];this.GXLastCtrlId=95;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",84,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx01x0",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",85,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(1,86,"EMPID","Emp ID","","EmpID","int",0,"px",4,4,"right",null,[],1,"EmpID",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(2,87,"AGEID","Age ID","","AgeID","int",0,"px",4,4,"right",null,[],2,"AgeID",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(286,88,"PRDCOD","ID","","PrdCod","int",0,"px",4,4,"right",null,[],286,"PrdCod",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(302,89,"FECHA","fecha","","fecha","date",0,"px",8,8,"right",null,[],302,"fecha",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(303,90,"VALANT","Anterior","","valAnt","decimal",0,"px",13,13,"right",null,[],303,"valAnt",!0,2,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(304,91,"VALOACT","Actual","","valoAct","decimal",0,"px",13,13,"right",null,[],304,"valoAct",!0,2,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(3,92,"USUCOD","Nombre de Usuario","","UsuCod","char",0,"px",15,15,"left",null,[],3,"UsuCod",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"EMPIDFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLEMPIDFILTER",format:1,grid:0,evt:"e114t1_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCEMPID",gxz:"ZV6cEmpID",gxold:"OV6cEmpID",gxvar:"AV6cEmpID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cEmpID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cEmpID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCEMPID",gx.O.AV6cEmpID,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cEmpID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCEMPID",".")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"AGEIDFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLAGEIDFILTER",format:1,grid:0,evt:"e124t1_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCAGEID",gxz:"ZV7cAgeID",gxold:"OV7cAgeID",gxvar:"AV7cAgeID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cAgeID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV7cAgeID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCAGEID",gx.O.AV7cAgeID,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cAgeID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCAGEID",".")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"PRDCODFILTERCONTAINER",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"LBLPRDCODFILTER",format:1,grid:0,evt:"e134t1_client"};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCPRDCOD",gxz:"ZV8cPrdCod",gxold:"OV8cPrdCod",gxvar:"AV8cPrdCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cPrdCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV8cPrdCod=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCPRDCOD",gx.O.AV8cPrdCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cPrdCod=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCPRDCOD",".")},nac:gx.falseFn};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"FECHAFILTERCONTAINER",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"LBLFECHAFILTER",format:1,grid:0,evt:"e144t1_client"};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,lvl:0,type:"date",len:8,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Cfecha,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCFECHA",gxz:"ZV9cfecha",gxold:"OV9cfecha",gxvar:"AV9cfecha",dp:{f:-1,st:!1,wn:!1,mf:!1,pic:"99/99/99",dec:0},ucs:[],op:[46],ip:[46],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9cfecha=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV9cfecha=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vCFECHA",gx.O.AV9cfecha,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9cfecha=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("vCFECHA")},nac:gx.falseFn};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"VALANTFILTERCONTAINER",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"LBLVALANTFILTER",format:1,grid:0,evt:"e154t1_client"};n[53]={id:53,fld:"",grid:0};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"",grid:0};n[56]={id:56,lvl:0,type:"decimal",len:10,dec:2,sign:!1,pic:"ZZ,ZZZ,ZZZ.ZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCVALANT",gxz:"ZV10cvalAnt",gxold:"OV10cvalAnt",gxvar:"AV10cvalAnt",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10cvalAnt=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.ZV10cvalAnt=gx.fn.toDecimalValue(n,".",","))},v2c:function(){gx.fn.setDecimalValue("vCVALANT",gx.O.AV10cvalAnt,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.AV10cvalAnt=this.val())},val:function(){return gx.fn.getDecimalValue("vCVALANT",".",",")},nac:gx.falseFn};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"",grid:0};n[59]={id:59,fld:"VALOACTFILTERCONTAINER",grid:0};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"LBLVALOACTFILTER",format:1,grid:0,evt:"e164t1_client"};n[63]={id:63,fld:"",grid:0};n[64]={id:64,fld:"",grid:0};n[65]={id:65,fld:"",grid:0};n[66]={id:66,lvl:0,type:"decimal",len:10,dec:2,sign:!1,pic:"ZZ,ZZZ,ZZZ.ZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCVALOACT",gxz:"ZV11cvaloAct",gxold:"OV11cvaloAct",gxvar:"AV11cvaloAct",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV11cvaloAct=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.ZV11cvaloAct=gx.fn.toDecimalValue(n,".",","))},v2c:function(){gx.fn.setDecimalValue("vCVALOACT",gx.O.AV11cvaloAct,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.AV11cvaloAct=this.val())},val:function(){return gx.fn.getDecimalValue("vCVALOACT",".",",")},nac:gx.falseFn};n[67]={id:67,fld:"",grid:0};n[68]={id:68,fld:"",grid:0};n[69]={id:69,fld:"USUCODFILTERCONTAINER",grid:0};n[70]={id:70,fld:"",grid:0};n[71]={id:71,fld:"",grid:0};n[72]={id:72,fld:"LBLUSUCODFILTER",format:1,grid:0,evt:"e174t1_client"};n[73]={id:73,fld:"",grid:0};n[74]={id:74,fld:"",grid:0};n[75]={id:75,fld:"",grid:0};n[76]={id:76,lvl:0,type:"char",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCUSUCOD",gxz:"ZV12cUsuCod",gxold:"OV12cUsuCod",gxvar:"AV12cUsuCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV12cUsuCod=n)},v2z:function(n){n!==undefined&&(gx.O.ZV12cUsuCod=n)},v2c:function(){gx.fn.setControlValue("vCUSUCOD",gx.O.AV12cUsuCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV12cUsuCod=this.val())},val:function(){return gx.fn.getControlValue("vCUSUCOD")},nac:gx.falseFn};n[77]={id:77,fld:"",grid:0};n[78]={id:78,fld:"GRIDTABLE",grid:0};n[79]={id:79,fld:"",grid:0};n[80]={id:80,fld:"",grid:0};n[81]={id:81,fld:"BTNTOGGLE",grid:0};n[82]={id:82,fld:"",grid:0};n[83]={id:83,fld:"",grid:0};n[85]={id:85,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84),gx.O.AV5LinkSelection,gx.O.AV19Linkselection_GXI)},c2v:function(){gx.O.AV19Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(84))},gxvar_GXI:"AV19Linkselection_GXI",nac:gx.falseFn};n[86]={id:86,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EMPID",gxz:"Z1EmpID",gxold:"O1EmpID",gxvar:"A1EmpID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A1EmpID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1EmpID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("EMPID",n||gx.fn.currentGridRowImpl(84),gx.O.A1EmpID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A1EmpID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("EMPID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[87]={id:87,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"AGEID",gxz:"Z2AgeID",gxold:"O2AgeID",gxvar:"A2AgeID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A2AgeID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z2AgeID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("AGEID",n||gx.fn.currentGridRowImpl(84),gx.O.A2AgeID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A2AgeID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("AGEID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[88]={id:88,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PRDCOD",gxz:"Z286PrdCod",gxold:"O286PrdCod",gxvar:"A286PrdCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A286PrdCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z286PrdCod=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("PRDCOD",n||gx.fn.currentGridRowImpl(84),gx.O.A286PrdCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A286PrdCod=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("PRDCOD",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[89]={id:89,lvl:2,type:"date",len:8,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"FECHA",gxz:"Z302fecha",gxold:"O302fecha",gxvar:"A302fecha",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A302fecha=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z302fecha=gx.fn.toDatetimeValue(n))},v2c:function(n){gx.fn.setGridControlValue("FECHA",n||gx.fn.currentGridRowImpl(84),gx.O.A302fecha,0)},c2v:function(){this.val()!==undefined&&(gx.O.A302fecha=gx.fn.toDatetimeValue(this.val()))},val:function(n){return gx.fn.getGridDateTimeValue("FECHA",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[90]={id:90,lvl:2,type:"decimal",len:10,dec:2,sign:!1,pic:"ZZ,ZZZ,ZZZ.ZZ",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VALANT",gxz:"Z303valAnt",gxold:"O303valAnt",gxvar:"A303valAnt",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A303valAnt=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z303valAnt=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("VALANT",n||gx.fn.currentGridRowImpl(84),gx.O.A303valAnt,2,",");typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A303valAnt=this.val())},val:function(n){return gx.fn.getGridDecimalValue("VALANT",n||gx.fn.currentGridRowImpl(84),".",",")},nac:gx.falseFn};n[91]={id:91,lvl:2,type:"decimal",len:10,dec:2,sign:!1,pic:"ZZ,ZZZ,ZZZ.ZZ",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VALOACT",gxz:"Z304valoAct",gxold:"O304valoAct",gxvar:"A304valoAct",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A304valoAct=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z304valoAct=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("VALOACT",n||gx.fn.currentGridRowImpl(84),gx.O.A304valoAct,2,",");typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A304valoAct=this.val())},val:function(n){return gx.fn.getGridDecimalValue("VALOACT",n||gx.fn.currentGridRowImpl(84),".",",")},nac:gx.falseFn};n[92]={id:92,lvl:2,type:"char",len:15,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUCOD",gxz:"Z3UsuCod",gxold:"O3UsuCod",gxvar:"A3UsuCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A3UsuCod=n)},v2z:function(n){n!==undefined&&(gx.O.Z3UsuCod=n)},v2c:function(n){gx.fn.setGridControlValue("USUCOD",n||gx.fn.currentGridRowImpl(84),gx.O.A3UsuCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A3UsuCod=this.val())},val:function(n){return gx.fn.getGridControlValue("USUCOD",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[93]={id:93,fld:"",grid:0};n[94]={id:94,fld:"",grid:0};n[95]={id:95,fld:"BTN_CANCEL",grid:0};this.AV6cEmpID=0;this.ZV6cEmpID=0;this.OV6cEmpID=0;this.AV7cAgeID=0;this.ZV7cAgeID=0;this.OV7cAgeID=0;this.AV8cPrdCod=0;this.ZV8cPrdCod=0;this.OV8cPrdCod=0;this.AV9cfecha=gx.date.nullDate();this.ZV9cfecha=gx.date.nullDate();this.OV9cfecha=gx.date.nullDate();this.AV10cvalAnt=0;this.ZV10cvalAnt=0;this.OV10cvalAnt=0;this.AV11cvaloAct=0;this.ZV11cvaloAct=0;this.OV11cvaloAct=0;this.AV12cUsuCod="";this.ZV12cUsuCod="";this.OV12cUsuCod="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z1EmpID=0;this.O1EmpID=0;this.Z2AgeID=0;this.O2AgeID=0;this.Z286PrdCod=0;this.O286PrdCod=0;this.Z302fecha=gx.date.nullDate();this.O302fecha=gx.date.nullDate();this.Z303valAnt=0;this.O303valAnt=0;this.Z304valoAct=0;this.O304valoAct=0;this.Z3UsuCod="";this.O3UsuCod="";this.AV6cEmpID=0;this.AV7cAgeID=0;this.AV8cPrdCod=0;this.AV9cfecha=gx.date.nullDate();this.AV10cvalAnt=0;this.AV11cvaloAct=0;this.AV12cUsuCod="";this.AV13pEmpID=0;this.AV14pAgeID=0;this.AV15pPrdCod=0;this.AV5LinkSelection="";this.A1EmpID=0;this.A2AgeID=0;this.A286PrdCod=0;this.A302fecha=gx.date.nullDate();this.A303valAnt=0;this.A304valoAct=0;this.A3UsuCod="";this.Events={e214t2_client:["ENTER",!0],e224t1_client:["CANCEL",!0],e184t1_client:["'TOGGLE'",!1],e114t1_client:["LBLEMPIDFILTER.CLICK",!1],e124t1_client:["LBLAGEIDFILTER.CLICK",!1],e134t1_client:["LBLPRDCODFILTER.CLICK",!1],e144t1_client:["LBLFECHAFILTER.CLICK",!1],e154t1_client:["LBLVALANTFILTER.CLICK",!1],e164t1_client:["LBLVALOACTFILTER.CLICK",!1],e174t1_client:["LBLUSUCODFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cEmpID",fld:"vCEMPID",pic:"ZZZ9"},{av:"AV7cAgeID",fld:"vCAGEID",pic:"ZZZ9"},{av:"AV8cPrdCod",fld:"vCPRDCOD",pic:"ZZZ9"},{av:"AV9cfecha",fld:"vCFECHA",pic:""},{av:"AV10cvalAnt",fld:"vCVALANT",pic:"ZZ,ZZZ,ZZZ.ZZ"},{av:"AV11cvaloAct",fld:"vCVALOACT",pic:"ZZ,ZZZ,ZZZ.ZZ"},{av:"AV12cUsuCod",fld:"vCUSUCOD",pic:""}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLEMPIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("EMPIDFILTERCONTAINER","Class")',ctrl:"EMPIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("EMPIDFILTERCONTAINER","Class")',ctrl:"EMPIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCEMPID","Visible")',ctrl:"vCEMPID",prop:"Visible"}]];this.EvtParms["LBLAGEIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("AGEIDFILTERCONTAINER","Class")',ctrl:"AGEIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("AGEIDFILTERCONTAINER","Class")',ctrl:"AGEIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCAGEID","Visible")',ctrl:"vCAGEID",prop:"Visible"}]];this.EvtParms["LBLPRDCODFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PRDCODFILTERCONTAINER","Class")',ctrl:"PRDCODFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PRDCODFILTERCONTAINER","Class")',ctrl:"PRDCODFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPRDCOD","Visible")',ctrl:"vCPRDCOD",prop:"Visible"}]];this.EvtParms["LBLFECHAFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("FECHAFILTERCONTAINER","Class")',ctrl:"FECHAFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("FECHAFILTERCONTAINER","Class")',ctrl:"FECHAFILTERCONTAINER",prop:"Class"}]];this.EvtParms["LBLVALANTFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("VALANTFILTERCONTAINER","Class")',ctrl:"VALANTFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("VALANTFILTERCONTAINER","Class")',ctrl:"VALANTFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCVALANT","Visible")',ctrl:"vCVALANT",prop:"Visible"}]];this.EvtParms["LBLVALOACTFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("VALOACTFILTERCONTAINER","Class")',ctrl:"VALOACTFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("VALOACTFILTERCONTAINER","Class")',ctrl:"VALOACTFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCVALOACT","Visible")',ctrl:"vCVALOACT",prop:"Visible"}]];this.EvtParms["LBLUSUCODFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("USUCODFILTERCONTAINER","Class")',ctrl:"USUCODFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("USUCODFILTERCONTAINER","Class")',ctrl:"USUCODFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSUCOD","Visible")',ctrl:"vCUSUCOD",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9",hsh:!0},{av:"A2AgeID",fld:"AGEID",pic:"ZZZ9",hsh:!0},{av:"A286PrdCod",fld:"PRDCOD",pic:"ZZZ9",hsh:!0}],[{av:"AV13pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV14pAgeID",fld:"vPAGEID",pic:"ZZZ9"},{av:"AV15pPrdCod",fld:"vPPRDCOD",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cEmpID",fld:"vCEMPID",pic:"ZZZ9"},{av:"AV7cAgeID",fld:"vCAGEID",pic:"ZZZ9"},{av:"AV8cPrdCod",fld:"vCPRDCOD",pic:"ZZZ9"},{av:"AV9cfecha",fld:"vCFECHA",pic:""},{av:"AV10cvalAnt",fld:"vCVALANT",pic:"ZZ,ZZZ,ZZZ.ZZ"},{av:"AV11cvaloAct",fld:"vCVALOACT",pic:"ZZ,ZZZ,ZZZ.ZZ"},{av:"AV12cUsuCod",fld:"vCUSUCOD",pic:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cEmpID",fld:"vCEMPID",pic:"ZZZ9"},{av:"AV7cAgeID",fld:"vCAGEID",pic:"ZZZ9"},{av:"AV8cPrdCod",fld:"vCPRDCOD",pic:"ZZZ9"},{av:"AV9cfecha",fld:"vCFECHA",pic:""},{av:"AV10cvalAnt",fld:"vCVALANT",pic:"ZZ,ZZZ,ZZZ.ZZ"},{av:"AV11cvaloAct",fld:"vCVALOACT",pic:"ZZ,ZZZ,ZZZ.ZZ"},{av:"AV12cUsuCod",fld:"vCUSUCOD",pic:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cEmpID",fld:"vCEMPID",pic:"ZZZ9"},{av:"AV7cAgeID",fld:"vCAGEID",pic:"ZZZ9"},{av:"AV8cPrdCod",fld:"vCPRDCOD",pic:"ZZZ9"},{av:"AV9cfecha",fld:"vCFECHA",pic:""},{av:"AV10cvalAnt",fld:"vCVALANT",pic:"ZZ,ZZZ,ZZZ.ZZ"},{av:"AV11cvaloAct",fld:"vCVALOACT",pic:"ZZ,ZZZ,ZZZ.ZZ"},{av:"AV12cUsuCod",fld:"vCUSUCOD",pic:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cEmpID",fld:"vCEMPID",pic:"ZZZ9"},{av:"AV7cAgeID",fld:"vCAGEID",pic:"ZZZ9"},{av:"AV8cPrdCod",fld:"vCPRDCOD",pic:"ZZZ9"},{av:"AV9cfecha",fld:"vCFECHA",pic:""},{av:"AV10cvalAnt",fld:"vCVALANT",pic:"ZZ,ZZZ,ZZZ.ZZ"},{av:"AV11cvaloAct",fld:"vCVALOACT",pic:"ZZ,ZZZ,ZZZ.ZZ"},{av:"AV12cUsuCod",fld:"vCUSUCOD",pic:""}],[]];this.setVCMap("AV13pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV14pAgeID","vPAGEID",0,"int",4,0);this.setVCMap("AV15pPrdCod","vPPRDCOD",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);t.addRefreshingVar(this.GXValidFnc[66]);t.addRefreshingVar(this.GXValidFnc[76]);this.Initialize()});gx.createParentObj(gx01x0)