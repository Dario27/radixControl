/*!   GeneXus C# 15_0_12-126726 on 10/26/2022 20:17:9.73
*/
gx.evt.autoSkip=!1;gx.define("gx00b0",!1,function(){var n,t;this.ServerClass="gx00b0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV11pModCod=gx.fn.getIntegerValue("vPMODCOD",".");this.AV12pMenCod=gx.fn.getIntegerValue("vPMENCOD",".")};this.e163d1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e113d1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("MODCODFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("MODCODFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCMODCOD","Visible",!0)):(gx.fn.setCtrlProperty("MODCODFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCMODCOD","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MODCODFILTERCONTAINER","Class")',ctrl:"MODCODFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMODCOD","Visible")',ctrl:"vCMODCOD",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e123d1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("MENCODFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("MENCODFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCMENCOD","Visible",!0)):(gx.fn.setCtrlProperty("MENCODFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCMENCOD","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MENCODFILTERCONTAINER","Class")',ctrl:"MENCODFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMENCOD","Visible")',ctrl:"vCMENCOD",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e133d1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("MENDSCFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("MENDSCFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCMENDSC","Visible",!0)):(gx.fn.setCtrlProperty("MENDSCFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCMENDSC","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MENDSCFILTERCONTAINER","Class")',ctrl:"MENDSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMENDSC","Visible")',ctrl:"vCMENDSC",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e143d1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("MENLINKFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("MENLINKFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCMENLINK","Visible",!0)):(gx.fn.setCtrlProperty("MENLINKFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCMENLINK","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MENLINKFILTERCONTAINER","Class")',ctrl:"MENLINKFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMENLINK","Visible")',ctrl:"vCMENLINK",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e153d1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("MENICOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("MENICOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCMENICO","Visible",!0)):(gx.fn.setCtrlProperty("MENICOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCMENICO","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MENICOFILTERCONTAINER","Class")',ctrl:"MENICOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMENICO","Visible")',ctrl:"vCMENICO",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e193d2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e203d1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,65,66,67,68,69,70,71,72,73];this.GXLastCtrlId=73;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",64,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00b0",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",65,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(11,66,"MODCOD","Codigo","","ModCod","int",0,"px",4,4,"right",null,[],11,"ModCod",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(12,67,"MENCOD","Código de Menú","","MenCod","int",0,"px",4,4,"right",null,[],12,"MenCod",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(77,68,"MENDSC","Menu","","MenDsc","char",0,"px",30,30,"left",null,[],77,"MenDsc",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(78,69,"MENLINK","Link","","MenLink","char",0,"px",30,30,"left",null,[],78,"MenLink",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(79,70,"MENICO","Ico","","MenIco","char",0,"px",30,30,"left",null,[],79,"MenIco",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"MODCODFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLMODCODFILTER",format:1,grid:0,evt:"e113d1_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCMODCOD",gxz:"ZV6cModCod",gxold:"OV6cModCod",gxvar:"AV6cModCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cModCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cModCod=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCMODCOD",gx.O.AV6cModCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cModCod=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCMODCOD",".")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"MENCODFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLMENCODFILTER",format:1,grid:0,evt:"e123d1_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCMENCOD",gxz:"ZV7cMenCod",gxold:"OV7cMenCod",gxvar:"AV7cMenCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cMenCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV7cMenCod=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCMENCOD",gx.O.AV7cMenCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cMenCod=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCMENCOD",".")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"MENDSCFILTERCONTAINER",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"LBLMENDSCFILTER",format:1,grid:0,evt:"e133d1_client"};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,lvl:0,type:"char",len:30,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCMENDSC",gxz:"ZV8cMenDsc",gxold:"OV8cMenDsc",gxvar:"AV8cMenDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cMenDsc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8cMenDsc=n)},v2c:function(){gx.fn.setControlValue("vCMENDSC",gx.O.AV8cMenDsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cMenDsc=this.val())},val:function(){return gx.fn.getControlValue("vCMENDSC")},nac:gx.falseFn};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"MENLINKFILTERCONTAINER",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"LBLMENLINKFILTER",format:1,grid:0,evt:"e143d1_client"};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,lvl:0,type:"char",len:30,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCMENLINK",gxz:"ZV9cMenLink",gxold:"OV9cMenLink",gxvar:"AV9cMenLink",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9cMenLink=n)},v2z:function(n){n!==undefined&&(gx.O.ZV9cMenLink=n)},v2c:function(){gx.fn.setControlValue("vCMENLINK",gx.O.AV9cMenLink,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9cMenLink=this.val())},val:function(){return gx.fn.getControlValue("vCMENLINK")},nac:gx.falseFn};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"MENICOFILTERCONTAINER",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"LBLMENICOFILTER",format:1,grid:0,evt:"e153d1_client"};n[53]={id:53,fld:"",grid:0};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"",grid:0};n[56]={id:56,lvl:0,type:"char",len:30,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCMENICO",gxz:"ZV10cMenIco",gxold:"OV10cMenIco",gxvar:"AV10cMenIco",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10cMenIco=n)},v2z:function(n){n!==undefined&&(gx.O.ZV10cMenIco=n)},v2c:function(){gx.fn.setControlValue("vCMENICO",gx.O.AV10cMenIco,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10cMenIco=this.val())},val:function(){return gx.fn.getControlValue("vCMENICO")},nac:gx.falseFn};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"GRIDTABLE",grid:0};n[59]={id:59,fld:"",grid:0};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"BTNTOGGLE",grid:0};n[62]={id:62,fld:"",grid:0};n[63]={id:63,fld:"",grid:0};n[65]={id:65,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(64),gx.O.AV5LinkSelection,gx.O.AV16Linkselection_GXI)},c2v:function(){gx.O.AV16Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(64))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(64))},gxvar_GXI:"AV16Linkselection_GXI",nac:gx.falseFn};n[66]={id:66,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"MODCOD",gxz:"Z11ModCod",gxold:"O11ModCod",gxvar:"A11ModCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A11ModCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z11ModCod=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("MODCOD",n||gx.fn.currentGridRowImpl(64),gx.O.A11ModCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A11ModCod=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("MODCOD",n||gx.fn.currentGridRowImpl(64),".")},nac:gx.falseFn};n[67]={id:67,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"MENCOD",gxz:"Z12MenCod",gxold:"O12MenCod",gxvar:"A12MenCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A12MenCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z12MenCod=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("MENCOD",n||gx.fn.currentGridRowImpl(64),gx.O.A12MenCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A12MenCod=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("MENCOD",n||gx.fn.currentGridRowImpl(64),".")},nac:gx.falseFn};n[68]={id:68,lvl:2,type:"char",len:30,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"MENDSC",gxz:"Z77MenDsc",gxold:"O77MenDsc",gxvar:"A77MenDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A77MenDsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z77MenDsc=n)},v2c:function(n){gx.fn.setGridControlValue("MENDSC",n||gx.fn.currentGridRowImpl(64),gx.O.A77MenDsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A77MenDsc=this.val())},val:function(n){return gx.fn.getGridControlValue("MENDSC",n||gx.fn.currentGridRowImpl(64))},nac:gx.falseFn};n[69]={id:69,lvl:2,type:"char",len:30,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"MENLINK",gxz:"Z78MenLink",gxold:"O78MenLink",gxvar:"A78MenLink",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A78MenLink=n)},v2z:function(n){n!==undefined&&(gx.O.Z78MenLink=n)},v2c:function(n){gx.fn.setGridControlValue("MENLINK",n||gx.fn.currentGridRowImpl(64),gx.O.A78MenLink,0)},c2v:function(){this.val()!==undefined&&(gx.O.A78MenLink=this.val())},val:function(n){return gx.fn.getGridControlValue("MENLINK",n||gx.fn.currentGridRowImpl(64))},nac:gx.falseFn};n[70]={id:70,lvl:2,type:"char",len:30,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"MENICO",gxz:"Z79MenIco",gxold:"O79MenIco",gxvar:"A79MenIco",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A79MenIco=n)},v2z:function(n){n!==undefined&&(gx.O.Z79MenIco=n)},v2c:function(n){gx.fn.setGridControlValue("MENICO",n||gx.fn.currentGridRowImpl(64),gx.O.A79MenIco,0)},c2v:function(){this.val()!==undefined&&(gx.O.A79MenIco=this.val())},val:function(n){return gx.fn.getGridControlValue("MENICO",n||gx.fn.currentGridRowImpl(64))},nac:gx.falseFn};n[71]={id:71,fld:"",grid:0};n[72]={id:72,fld:"",grid:0};n[73]={id:73,fld:"BTN_CANCEL",grid:0};this.AV6cModCod=0;this.ZV6cModCod=0;this.OV6cModCod=0;this.AV7cMenCod=0;this.ZV7cMenCod=0;this.OV7cMenCod=0;this.AV8cMenDsc="";this.ZV8cMenDsc="";this.OV8cMenDsc="";this.AV9cMenLink="";this.ZV9cMenLink="";this.OV9cMenLink="";this.AV10cMenIco="";this.ZV10cMenIco="";this.OV10cMenIco="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z11ModCod=0;this.O11ModCod=0;this.Z12MenCod=0;this.O12MenCod=0;this.Z77MenDsc="";this.O77MenDsc="";this.Z78MenLink="";this.O78MenLink="";this.Z79MenIco="";this.O79MenIco="";this.AV6cModCod=0;this.AV7cMenCod=0;this.AV8cMenDsc="";this.AV9cMenLink="";this.AV10cMenIco="";this.AV11pModCod=0;this.AV12pMenCod=0;this.AV5LinkSelection="";this.A11ModCod=0;this.A12MenCod=0;this.A77MenDsc="";this.A78MenLink="";this.A79MenIco="";this.Events={e193d2_client:["ENTER",!0],e203d1_client:["CANCEL",!0],e163d1_client:["'TOGGLE'",!1],e113d1_client:["LBLMODCODFILTER.CLICK",!1],e123d1_client:["LBLMENCODFILTER.CLICK",!1],e133d1_client:["LBLMENDSCFILTER.CLICK",!1],e143d1_client:["LBLMENLINKFILTER.CLICK",!1],e153d1_client:["LBLMENICOFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cModCod",fld:"vCMODCOD",pic:"ZZZ9"},{av:"AV7cMenCod",fld:"vCMENCOD",pic:"ZZZ9"},{av:"AV8cMenDsc",fld:"vCMENDSC",pic:""},{av:"AV9cMenLink",fld:"vCMENLINK",pic:""},{av:"AV10cMenIco",fld:"vCMENICO",pic:""}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLMODCODFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MODCODFILTERCONTAINER","Class")',ctrl:"MODCODFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MODCODFILTERCONTAINER","Class")',ctrl:"MODCODFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMODCOD","Visible")',ctrl:"vCMODCOD",prop:"Visible"}]];this.EvtParms["LBLMENCODFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MENCODFILTERCONTAINER","Class")',ctrl:"MENCODFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MENCODFILTERCONTAINER","Class")',ctrl:"MENCODFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMENCOD","Visible")',ctrl:"vCMENCOD",prop:"Visible"}]];this.EvtParms["LBLMENDSCFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MENDSCFILTERCONTAINER","Class")',ctrl:"MENDSCFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MENDSCFILTERCONTAINER","Class")',ctrl:"MENDSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMENDSC","Visible")',ctrl:"vCMENDSC",prop:"Visible"}]];this.EvtParms["LBLMENLINKFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MENLINKFILTERCONTAINER","Class")',ctrl:"MENLINKFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MENLINKFILTERCONTAINER","Class")',ctrl:"MENLINKFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMENLINK","Visible")',ctrl:"vCMENLINK",prop:"Visible"}]];this.EvtParms["LBLMENICOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MENICOFILTERCONTAINER","Class")',ctrl:"MENICOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MENICOFILTERCONTAINER","Class")',ctrl:"MENICOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMENICO","Visible")',ctrl:"vCMENICO",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A11ModCod",fld:"MODCOD",pic:"ZZZ9",hsh:!0},{av:"A12MenCod",fld:"MENCOD",pic:"ZZZ9",hsh:!0}],[{av:"AV11pModCod",fld:"vPMODCOD",pic:"ZZZ9"},{av:"AV12pMenCod",fld:"vPMENCOD",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cModCod",fld:"vCMODCOD",pic:"ZZZ9"},{av:"AV7cMenCod",fld:"vCMENCOD",pic:"ZZZ9"},{av:"AV8cMenDsc",fld:"vCMENDSC",pic:""},{av:"AV9cMenLink",fld:"vCMENLINK",pic:""},{av:"AV10cMenIco",fld:"vCMENICO",pic:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cModCod",fld:"vCMODCOD",pic:"ZZZ9"},{av:"AV7cMenCod",fld:"vCMENCOD",pic:"ZZZ9"},{av:"AV8cMenDsc",fld:"vCMENDSC",pic:""},{av:"AV9cMenLink",fld:"vCMENLINK",pic:""},{av:"AV10cMenIco",fld:"vCMENICO",pic:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cModCod",fld:"vCMODCOD",pic:"ZZZ9"},{av:"AV7cMenCod",fld:"vCMENCOD",pic:"ZZZ9"},{av:"AV8cMenDsc",fld:"vCMENDSC",pic:""},{av:"AV9cMenLink",fld:"vCMENLINK",pic:""},{av:"AV10cMenIco",fld:"vCMENICO",pic:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cModCod",fld:"vCMODCOD",pic:"ZZZ9"},{av:"AV7cMenCod",fld:"vCMENCOD",pic:"ZZZ9"},{av:"AV8cMenDsc",fld:"vCMENDSC",pic:""},{av:"AV9cMenLink",fld:"vCMENLINK",pic:""},{av:"AV10cMenIco",fld:"vCMENICO",pic:""}],[]];this.setVCMap("AV11pModCod","vPMODCOD",0,"int",4,0);this.setVCMap("AV12pMenCod","vPMENCOD",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);this.Initialize()});gx.createParentObj(gx00b0)