/*!   GeneXus C# 15_0_11-124690 on 7/15/2022 0:34:13.19
*/
gx.evt.autoSkip=!1;gx.define("gx0171",!1,function(){var n,t;this.ServerClass="gx0171";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV10pUsuCod=gx.fn.getControlValue("vPUSUCOD");this.AV11pModCod=gx.fn.getIntegerValue("vPMODCOD",".");this.AV12pMenCod=gx.fn.getIntegerValue("vPMENCOD",".");this.AV13pSubCod=gx.fn.getIntegerValue("vPSUBCOD",".");this.AV10pUsuCod=gx.fn.getControlValue("vPUSUCOD")};this.e153u1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),$.Deferred().resolve()};this.e113u1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("MODCODFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("MODCODFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCMODCOD","Visible",!0)):(gx.fn.setCtrlProperty("MODCODFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCMODCOD","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MODCODFILTERCONTAINER","Class")',ctrl:"MODCODFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMODCOD","Visible")',ctrl:"vCMODCOD",prop:"Visible"}]),$.Deferred().resolve()};this.e123u1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("MENCODFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("MENCODFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCMENCOD","Visible",!0)):(gx.fn.setCtrlProperty("MENCODFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCMENCOD","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MENCODFILTERCONTAINER","Class")',ctrl:"MENCODFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMENCOD","Visible")',ctrl:"vCMENCOD",prop:"Visible"}]),$.Deferred().resolve()};this.e133u1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("SUBCODFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("SUBCODFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCSUBCOD","Visible",!0)):(gx.fn.setCtrlProperty("SUBCODFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCSUBCOD","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("SUBCODFILTERCONTAINER","Class")',ctrl:"SUBCODFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCSUBCOD","Visible")',ctrl:"vCSUBCOD",prop:"Visible"}]),$.Deferred().resolve()};this.e143u1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("PERMESTFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PERMESTFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPERMEST","Visible",!0)):(gx.fn.setCtrlProperty("PERMESTFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPERMEST","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PERMESTFILTERCONTAINER","Class")',ctrl:"PERMESTFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPERMEST","Visible")',ctrl:"vCPERMEST",prop:"Visible"}]),$.Deferred().resolve()};this.e183u2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e193u1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,55,56,57,58,59,60,61,62,63];this.GXLastCtrlId=63;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",54,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0171",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",55,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(11,56,"MODCOD","Codigo","","ModCod","int",0,"px",4,4,"right",null,[],11,"ModCod",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(12,57,"MENCOD","Código de Menú","","MenCod","int",0,"px",4,4,"right",null,[],12,"MenCod",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(13,58,"SUBCOD","Codigo","","SubCod","int",0,"px",4,4,"right",null,[],13,"SubCod",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(96,59,"PERMEST","Perm Est","","PermEst","char",0,"px",1,1,"left",null,[],96,"PermEst",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(3,60,"USUCOD","Nombre de Usuario","","UsuCod","char",0,"px",15,15,"left",null,[],3,"UsuCod",!1,0,!1,!1,"Attribute",1,"");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"MODCODFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLMODCODFILTER",format:1,grid:0,evt:"e113u1_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCMODCOD",gxz:"ZV6cModCod",gxold:"OV6cModCod",gxvar:"AV6cModCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cModCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cModCod=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCMODCOD",gx.O.AV6cModCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cModCod=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCMODCOD",".")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"MENCODFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLMENCODFILTER",format:1,grid:0,evt:"e123u1_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCMENCOD",gxz:"ZV7cMenCod",gxold:"OV7cMenCod",gxvar:"AV7cMenCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cMenCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV7cMenCod=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCMENCOD",gx.O.AV7cMenCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cMenCod=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCMENCOD",".")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"SUBCODFILTERCONTAINER",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"LBLSUBCODFILTER",format:1,grid:0,evt:"e133u1_client"};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCSUBCOD",gxz:"ZV8cSubCod",gxold:"OV8cSubCod",gxvar:"AV8cSubCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cSubCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV8cSubCod=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCSUBCOD",gx.O.AV8cSubCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cSubCod=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCSUBCOD",".")},nac:gx.falseFn};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"PERMESTFILTERCONTAINER",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"LBLPERMESTFILTER",format:1,grid:0,evt:"e143u1_client"};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,lvl:0,type:"char",len:1,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCPERMEST",gxz:"ZV9cPermEst",gxold:"OV9cPermEst",gxvar:"AV9cPermEst",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9cPermEst=n)},v2z:function(n){n!==undefined&&(gx.O.ZV9cPermEst=n)},v2c:function(){gx.fn.setControlValue("vCPERMEST",gx.O.AV9cPermEst,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9cPermEst=this.val())},val:function(){return gx.fn.getControlValue("vCPERMEST")},nac:gx.falseFn};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"GRIDTABLE",grid:0};n[49]={id:49,fld:"",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"BTNTOGGLE",grid:0};n[52]={id:52,fld:"",grid:0};n[53]={id:53,fld:"",grid:0};n[55]={id:55,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:54,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(54),gx.O.AV5LinkSelection,gx.O.AV17Linkselection_GXI)},c2v:function(){gx.O.AV17Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(54))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(54))},gxvar_GXI:"AV17Linkselection_GXI",nac:gx.falseFn};n[56]={id:56,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:54,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"MODCOD",gxz:"Z11ModCod",gxold:"O11ModCod",gxvar:"A11ModCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A11ModCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z11ModCod=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("MODCOD",n||gx.fn.currentGridRowImpl(54),gx.O.A11ModCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A11ModCod=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("MODCOD",n||gx.fn.currentGridRowImpl(54),".")},nac:gx.falseFn};n[57]={id:57,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:54,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"MENCOD",gxz:"Z12MenCod",gxold:"O12MenCod",gxvar:"A12MenCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A12MenCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z12MenCod=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("MENCOD",n||gx.fn.currentGridRowImpl(54),gx.O.A12MenCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A12MenCod=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("MENCOD",n||gx.fn.currentGridRowImpl(54),".")},nac:gx.falseFn};n[58]={id:58,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:54,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SUBCOD",gxz:"Z13SubCod",gxold:"O13SubCod",gxvar:"A13SubCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A13SubCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z13SubCod=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("SUBCOD",n||gx.fn.currentGridRowImpl(54),gx.O.A13SubCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A13SubCod=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("SUBCOD",n||gx.fn.currentGridRowImpl(54),".")},nac:gx.falseFn};n[59]={id:59,lvl:2,type:"char",len:1,dec:0,sign:!1,ro:1,isacc:0,grid:54,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PERMEST",gxz:"Z96PermEst",gxold:"O96PermEst",gxvar:"A96PermEst",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A96PermEst=n)},v2z:function(n){n!==undefined&&(gx.O.Z96PermEst=n)},v2c:function(n){gx.fn.setGridControlValue("PERMEST",n||gx.fn.currentGridRowImpl(54),gx.O.A96PermEst,0)},c2v:function(){this.val()!==undefined&&(gx.O.A96PermEst=this.val())},val:function(n){return gx.fn.getGridControlValue("PERMEST",n||gx.fn.currentGridRowImpl(54))},nac:gx.falseFn};n[60]={id:60,lvl:2,type:"char",len:15,dec:0,sign:!1,ro:1,isacc:0,grid:54,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUCOD",gxz:"Z3UsuCod",gxold:"O3UsuCod",gxvar:"A3UsuCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A3UsuCod=n)},v2z:function(n){n!==undefined&&(gx.O.Z3UsuCod=n)},v2c:function(n){gx.fn.setGridControlValue("USUCOD",n||gx.fn.currentGridRowImpl(54),gx.O.A3UsuCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A3UsuCod=this.val())},val:function(n){return gx.fn.getGridControlValue("USUCOD",n||gx.fn.currentGridRowImpl(54))},nac:gx.falseFn};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"",grid:0};n[63]={id:63,fld:"BTN_CANCEL",grid:0};this.AV6cModCod=0;this.ZV6cModCod=0;this.OV6cModCod=0;this.AV7cMenCod=0;this.ZV7cMenCod=0;this.OV7cMenCod=0;this.AV8cSubCod=0;this.ZV8cSubCod=0;this.OV8cSubCod=0;this.AV9cPermEst="";this.ZV9cPermEst="";this.OV9cPermEst="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z11ModCod=0;this.O11ModCod=0;this.Z12MenCod=0;this.O12MenCod=0;this.Z13SubCod=0;this.O13SubCod=0;this.Z96PermEst="";this.O96PermEst="";this.Z3UsuCod="";this.O3UsuCod="";this.AV6cModCod=0;this.AV7cMenCod=0;this.AV8cSubCod=0;this.AV9cPermEst="";this.AV10pUsuCod="";this.AV11pModCod=0;this.AV12pMenCod=0;this.AV13pSubCod=0;this.AV5LinkSelection="";this.A11ModCod=0;this.A12MenCod=0;this.A13SubCod=0;this.A96PermEst="";this.A3UsuCod="";this.Events={e183u2_client:["ENTER",!0],e193u1_client:["CANCEL",!0],e153u1_client:["'TOGGLE'",!1],e113u1_client:["LBLMODCODFILTER.CLICK",!1],e123u1_client:["LBLMENCODFILTER.CLICK",!1],e133u1_client:["LBLSUBCODFILTER.CLICK",!1],e143u1_client:["LBLPERMESTFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cModCod",fld:"vCMODCOD",pic:"ZZZ9"},{av:"AV7cMenCod",fld:"vCMENCOD",pic:"ZZZ9"},{av:"AV8cSubCod",fld:"vCSUBCOD",pic:"ZZZ9"},{av:"AV9cPermEst",fld:"vCPERMEST",pic:""},{av:"AV10pUsuCod",fld:"vPUSUCOD",pic:""}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLMODCODFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MODCODFILTERCONTAINER","Class")',ctrl:"MODCODFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MODCODFILTERCONTAINER","Class")',ctrl:"MODCODFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMODCOD","Visible")',ctrl:"vCMODCOD",prop:"Visible"}]];this.EvtParms["LBLMENCODFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MENCODFILTERCONTAINER","Class")',ctrl:"MENCODFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MENCODFILTERCONTAINER","Class")',ctrl:"MENCODFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMENCOD","Visible")',ctrl:"vCMENCOD",prop:"Visible"}]];this.EvtParms["LBLSUBCODFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("SUBCODFILTERCONTAINER","Class")',ctrl:"SUBCODFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("SUBCODFILTERCONTAINER","Class")',ctrl:"SUBCODFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCSUBCOD","Visible")',ctrl:"vCSUBCOD",prop:"Visible"}]];this.EvtParms["LBLPERMESTFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PERMESTFILTERCONTAINER","Class")',ctrl:"PERMESTFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PERMESTFILTERCONTAINER","Class")',ctrl:"PERMESTFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPERMEST","Visible")',ctrl:"vCPERMEST",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A11ModCod",fld:"MODCOD",pic:"ZZZ9",hsh:!0},{av:"A12MenCod",fld:"MENCOD",pic:"ZZZ9",hsh:!0},{av:"A13SubCod",fld:"SUBCOD",pic:"ZZZ9",hsh:!0}],[{av:"AV11pModCod",fld:"vPMODCOD",pic:"ZZZ9"},{av:"AV12pMenCod",fld:"vPMENCOD",pic:"ZZZ9"},{av:"AV13pSubCod",fld:"vPSUBCOD",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cModCod",fld:"vCMODCOD",pic:"ZZZ9"},{av:"AV7cMenCod",fld:"vCMENCOD",pic:"ZZZ9"},{av:"AV8cSubCod",fld:"vCSUBCOD",pic:"ZZZ9"},{av:"AV9cPermEst",fld:"vCPERMEST",pic:""},{av:"AV10pUsuCod",fld:"vPUSUCOD",pic:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cModCod",fld:"vCMODCOD",pic:"ZZZ9"},{av:"AV7cMenCod",fld:"vCMENCOD",pic:"ZZZ9"},{av:"AV8cSubCod",fld:"vCSUBCOD",pic:"ZZZ9"},{av:"AV9cPermEst",fld:"vCPERMEST",pic:""},{av:"AV10pUsuCod",fld:"vPUSUCOD",pic:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cModCod",fld:"vCMODCOD",pic:"ZZZ9"},{av:"AV7cMenCod",fld:"vCMENCOD",pic:"ZZZ9"},{av:"AV8cSubCod",fld:"vCSUBCOD",pic:"ZZZ9"},{av:"AV9cPermEst",fld:"vCPERMEST",pic:""},{av:"AV10pUsuCod",fld:"vPUSUCOD",pic:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cModCod",fld:"vCMODCOD",pic:"ZZZ9"},{av:"AV7cMenCod",fld:"vCMENCOD",pic:"ZZZ9"},{av:"AV8cSubCod",fld:"vCSUBCOD",pic:"ZZZ9"},{av:"AV9cPermEst",fld:"vCPERMEST",pic:""},{av:"AV10pUsuCod",fld:"vPUSUCOD",pic:""}],[]];this.setVCMap("AV10pUsuCod","vPUSUCOD",0,"char",15,0);this.setVCMap("AV11pModCod","vPMODCOD",0,"int",4,0);this.setVCMap("AV12pMenCod","vPMENCOD",0,"int",4,0);this.setVCMap("AV13pSubCod","vPSUBCOD",0,"int",4,0);this.setVCMap("AV10pUsuCod","vPUSUCOD",0,"char",15,0);this.setVCMap("AV10pUsuCod","vPUSUCOD",0,"char",15,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar({rfrVar:"AV10pUsuCod"});this.Initialize()});gx.createParentObj(gx0171)