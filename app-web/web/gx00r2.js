/*!   GeneXus C# 15_0_12-126726 on 11/19/2022 22:53:45.18
*/
gx.evt.autoSkip=!1;gx.define("gx00r2",!1,function(){var n,t;this.ServerClass="gx00r2";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV11pEmpID=gx.fn.getIntegerValue("vPEMPID",".");this.AV12pcategID=gx.fn.getIntegerValue("vPCATEGID",".");this.AV13psubCatID=gx.fn.getIntegerValue("vPSUBCATID",".");this.AV11pEmpID=gx.fn.getIntegerValue("vPEMPID",".");this.AV12pcategID=gx.fn.getIntegerValue("vPCATEGID",".")};this.e162x1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e112x1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("SUBCATIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("SUBCATIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCSUBCATID","Visible",!0)):(gx.fn.setCtrlProperty("SUBCATIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCSUBCATID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("SUBCATIDFILTERCONTAINER","Class")',ctrl:"SUBCATIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCSUBCATID","Visible")',ctrl:"vCSUBCATID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e122x1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("SUBCATDSCFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("SUBCATDSCFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCSUBCATDSC","Visible",!0)):(gx.fn.setCtrlProperty("SUBCATDSCFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCSUBCATDSC","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("SUBCATDSCFILTERCONTAINER","Class")',ctrl:"SUBCATDSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCSUBCATDSC","Visible")',ctrl:"vCSUBCATDSC",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e132x1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("SUBCATPRECFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("SUBCATPRECFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCSUBCATPREC","Visible",!0)):(gx.fn.setCtrlProperty("SUBCATPRECFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCSUBCATPREC","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("SUBCATPRECFILTERCONTAINER","Class")',ctrl:"SUBCATPRECFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCSUBCATPREC","Visible")',ctrl:"vCSUBCATPREC",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e142x1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("SUBCATPESOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("SUBCATPESOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCSUBCATPESO","Visible",!0)):(gx.fn.setCtrlProperty("SUBCATPESOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCSUBCATPESO","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("SUBCATPESOFILTERCONTAINER","Class")',ctrl:"SUBCATPESOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCSUBCATPESO","Visible")',ctrl:"vCSUBCATPESO",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e152x1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("SUBCATDISPFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("SUBCATDISPFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCSUBCATDISP","Visible",!0)):(gx.fn.setCtrlProperty("SUBCATDISPFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCSUBCATDISP","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("SUBCATDISPFILTERCONTAINER","Class")',ctrl:"SUBCATDISPFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCSUBCATDISP","Visible")',ctrl:"vCSUBCATDISP",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e192x2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e202x1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,65,66,67,68,69,70,71,72,73,74,75,76,77];this.GXLastCtrlId=77;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",64,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00r2",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",65,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(33,66,"SUBCATID","Cat ID","","subCatID","int",0,"px",4,4,"right",null,[],33,"subCatID",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(148,67,"SUBCATDSC","Producto","","subCatDsc","char",0,"px",40,40,"left",null,[],148,"subCatDsc",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(150,68,"SUBCATPREC","Precio","","subCatPrec","decimal",0,"px",8,8,"right",null,[],150,"subCatPrec",!0,2,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(151,69,"SUBCATPESO","Peso","","subCatPeso","decimal",0,"px",8,8,"right",null,[],151,"subCatPeso",!0,2,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(211,70,"SUBCATDISP","Disponible","","subCatDisp","int",0,"px",8,8,"right",null,[],211,"subCatDisp",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(149,71,"SUBCATEST","Estado","","subCatEst","char",0,"px",1,1,"left",null,[],149,"subCatEst",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(363,72,"SUBCATIDPRD","Prd","","subCatIDPrd","int",0,"px",4,4,"right",null,[],363,"subCatIDPrd",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(1,73,"EMPID","Emp ID","","EmpID","int",0,"px",4,4,"right",null,[],1,"EmpID",!1,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(32,74,"CATEGID","Categ.ID","","categID","int",0,"px",4,4,"right",null,[],32,"categID",!1,0,!1,!1,"Attribute",1,"");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"SUBCATIDFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLSUBCATIDFILTER",format:1,grid:0,evt:"e112x1_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCSUBCATID",gxz:"ZV6csubCatID",gxold:"OV6csubCatID",gxvar:"AV6csubCatID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6csubCatID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6csubCatID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCSUBCATID",gx.O.AV6csubCatID,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6csubCatID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCSUBCATID",".")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"SUBCATDSCFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLSUBCATDSCFILTER",format:1,grid:0,evt:"e122x1_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"char",len:40,dec:0,sign:!1,pic:"@!",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCSUBCATDSC",gxz:"ZV7csubCatDsc",gxold:"OV7csubCatDsc",gxvar:"AV7csubCatDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7csubCatDsc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7csubCatDsc=n)},v2c:function(){gx.fn.setControlValue("vCSUBCATDSC",gx.O.AV7csubCatDsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7csubCatDsc=this.val())},val:function(){return gx.fn.getControlValue("vCSUBCATDSC")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"SUBCATPRECFILTERCONTAINER",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"LBLSUBCATPRECFILTER",format:1,grid:0,evt:"e132x1_client"};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,lvl:0,type:"decimal",len:8,dec:2,sign:!1,pic:"ZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCSUBCATPREC",gxz:"ZV8csubCatPrec",gxold:"OV8csubCatPrec",gxvar:"AV8csubCatPrec",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8csubCatPrec=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.ZV8csubCatPrec=gx.fn.toDecimalValue(n,".",","))},v2c:function(){gx.fn.setDecimalValue("vCSUBCATPREC",gx.O.AV8csubCatPrec,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.AV8csubCatPrec=this.val())},val:function(){return gx.fn.getDecimalValue("vCSUBCATPREC",".",",")},nac:gx.falseFn};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"SUBCATPESOFILTERCONTAINER",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"LBLSUBCATPESOFILTER",format:1,grid:0,evt:"e142x1_client"};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,lvl:0,type:"decimal",len:8,dec:2,sign:!1,pic:"ZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCSUBCATPESO",gxz:"ZV9csubCatPeso",gxold:"OV9csubCatPeso",gxvar:"AV9csubCatPeso",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9csubCatPeso=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.ZV9csubCatPeso=gx.fn.toDecimalValue(n,".",","))},v2c:function(){gx.fn.setDecimalValue("vCSUBCATPESO",gx.O.AV9csubCatPeso,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.AV9csubCatPeso=this.val())},val:function(){return gx.fn.getDecimalValue("vCSUBCATPESO",".",",")},nac:gx.falseFn};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"SUBCATDISPFILTERCONTAINER",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"LBLSUBCATDISPFILTER",format:1,grid:0,evt:"e152x1_client"};n[53]={id:53,fld:"",grid:0};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"",grid:0};n[56]={id:56,lvl:0,type:"int",len:8,dec:0,sign:!1,pic:"ZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCSUBCATDISP",gxz:"ZV10csubCatDisp",gxold:"OV10csubCatDisp",gxvar:"AV10csubCatDisp",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10csubCatDisp=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV10csubCatDisp=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCSUBCATDISP",gx.O.AV10csubCatDisp,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10csubCatDisp=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCSUBCATDISP",".")},nac:gx.falseFn};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"GRIDTABLE",grid:0};n[59]={id:59,fld:"",grid:0};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"BTNTOGGLE",grid:0};n[62]={id:62,fld:"",grid:0};n[63]={id:63,fld:"",grid:0};n[65]={id:65,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(64),gx.O.AV5LinkSelection,gx.O.AV17Linkselection_GXI)},c2v:function(){gx.O.AV17Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(64))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(64))},gxvar_GXI:"AV17Linkselection_GXI",nac:gx.falseFn};n[66]={id:66,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SUBCATID",gxz:"Z33subCatID",gxold:"O33subCatID",gxvar:"A33subCatID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A33subCatID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z33subCatID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("SUBCATID",n||gx.fn.currentGridRowImpl(64),gx.O.A33subCatID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A33subCatID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("SUBCATID",n||gx.fn.currentGridRowImpl(64),".")},nac:gx.falseFn};n[67]={id:67,lvl:2,type:"char",len:40,dec:0,sign:!1,pic:"@!",ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SUBCATDSC",gxz:"Z148subCatDsc",gxold:"O148subCatDsc",gxvar:"A148subCatDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A148subCatDsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z148subCatDsc=n)},v2c:function(n){gx.fn.setGridControlValue("SUBCATDSC",n||gx.fn.currentGridRowImpl(64),gx.O.A148subCatDsc,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A148subCatDsc=this.val())},val:function(n){return gx.fn.getGridControlValue("SUBCATDSC",n||gx.fn.currentGridRowImpl(64))},nac:gx.falseFn};n[68]={id:68,lvl:2,type:"decimal",len:8,dec:2,sign:!1,pic:"ZZZZ9.99",ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SUBCATPREC",gxz:"Z150subCatPrec",gxold:"O150subCatPrec",gxvar:"A150subCatPrec",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A150subCatPrec=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z150subCatPrec=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("SUBCATPREC",n||gx.fn.currentGridRowImpl(64),gx.O.A150subCatPrec,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A150subCatPrec=this.val())},val:function(n){return gx.fn.getGridDecimalValue("SUBCATPREC",n||gx.fn.currentGridRowImpl(64),".",",")},nac:gx.falseFn};n[69]={id:69,lvl:2,type:"decimal",len:8,dec:2,sign:!1,pic:"ZZZZ9.99",ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SUBCATPESO",gxz:"Z151subCatPeso",gxold:"O151subCatPeso",gxvar:"A151subCatPeso",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A151subCatPeso=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z151subCatPeso=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("SUBCATPESO",n||gx.fn.currentGridRowImpl(64),gx.O.A151subCatPeso,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A151subCatPeso=this.val())},val:function(n){return gx.fn.getGridDecimalValue("SUBCATPESO",n||gx.fn.currentGridRowImpl(64),".",",")},nac:gx.falseFn};n[70]={id:70,lvl:2,type:"int",len:8,dec:0,sign:!1,pic:"ZZZZZZZ9",ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SUBCATDISP",gxz:"Z211subCatDisp",gxold:"O211subCatDisp",gxvar:"A211subCatDisp",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A211subCatDisp=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z211subCatDisp=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("SUBCATDISP",n||gx.fn.currentGridRowImpl(64),gx.O.A211subCatDisp,0)},c2v:function(){this.val()!==undefined&&(gx.O.A211subCatDisp=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("SUBCATDISP",n||gx.fn.currentGridRowImpl(64),".")},nac:gx.falseFn};n[71]={id:71,lvl:2,type:"char",len:1,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SUBCATEST",gxz:"Z149subCatEst",gxold:"O149subCatEst",gxvar:"A149subCatEst",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A149subCatEst=n)},v2z:function(n){n!==undefined&&(gx.O.Z149subCatEst=n)},v2c:function(n){gx.fn.setGridControlValue("SUBCATEST",n||gx.fn.currentGridRowImpl(64),gx.O.A149subCatEst,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A149subCatEst=this.val())},val:function(n){return gx.fn.getGridControlValue("SUBCATEST",n||gx.fn.currentGridRowImpl(64))},nac:gx.falseFn};n[72]={id:72,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SUBCATIDPRD",gxz:"Z363subCatIDPrd",gxold:"O363subCatIDPrd",gxvar:"A363subCatIDPrd",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A363subCatIDPrd=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z363subCatIDPrd=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("SUBCATIDPRD",n||gx.fn.currentGridRowImpl(64),gx.O.A363subCatIDPrd,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A363subCatIDPrd=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("SUBCATIDPRD",n||gx.fn.currentGridRowImpl(64),".")},nac:gx.falseFn};n[73]={id:73,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EMPID",gxz:"Z1EmpID",gxold:"O1EmpID",gxvar:"A1EmpID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A1EmpID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1EmpID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("EMPID",n||gx.fn.currentGridRowImpl(64),gx.O.A1EmpID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A1EmpID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("EMPID",n||gx.fn.currentGridRowImpl(64),".")},nac:gx.falseFn};n[74]={id:74,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CATEGID",gxz:"Z32categID",gxold:"O32categID",gxvar:"A32categID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A32categID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z32categID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("CATEGID",n||gx.fn.currentGridRowImpl(64),gx.O.A32categID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A32categID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("CATEGID",n||gx.fn.currentGridRowImpl(64),".")},nac:gx.falseFn};n[75]={id:75,fld:"",grid:0};n[76]={id:76,fld:"",grid:0};n[77]={id:77,fld:"BTN_CANCEL",grid:0};this.AV6csubCatID=0;this.ZV6csubCatID=0;this.OV6csubCatID=0;this.AV7csubCatDsc="";this.ZV7csubCatDsc="";this.OV7csubCatDsc="";this.AV8csubCatPrec=0;this.ZV8csubCatPrec=0;this.OV8csubCatPrec=0;this.AV9csubCatPeso=0;this.ZV9csubCatPeso=0;this.OV9csubCatPeso=0;this.AV10csubCatDisp=0;this.ZV10csubCatDisp=0;this.OV10csubCatDisp=0;this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z33subCatID=0;this.O33subCatID=0;this.Z148subCatDsc="";this.O148subCatDsc="";this.Z150subCatPrec=0;this.O150subCatPrec=0;this.Z151subCatPeso=0;this.O151subCatPeso=0;this.Z211subCatDisp=0;this.O211subCatDisp=0;this.Z149subCatEst="";this.O149subCatEst="";this.Z363subCatIDPrd=0;this.O363subCatIDPrd=0;this.Z1EmpID=0;this.O1EmpID=0;this.Z32categID=0;this.O32categID=0;this.AV6csubCatID=0;this.AV7csubCatDsc="";this.AV8csubCatPrec=0;this.AV9csubCatPeso=0;this.AV10csubCatDisp=0;this.AV11pEmpID=0;this.AV12pcategID=0;this.AV13psubCatID=0;this.AV5LinkSelection="";this.A33subCatID=0;this.A148subCatDsc="";this.A150subCatPrec=0;this.A151subCatPeso=0;this.A211subCatDisp=0;this.A149subCatEst="";this.A363subCatIDPrd=0;this.A1EmpID=0;this.A32categID=0;this.Events={e192x2_client:["ENTER",!0],e202x1_client:["CANCEL",!0],e162x1_client:["'TOGGLE'",!1],e112x1_client:["LBLSUBCATIDFILTER.CLICK",!1],e122x1_client:["LBLSUBCATDSCFILTER.CLICK",!1],e132x1_client:["LBLSUBCATPRECFILTER.CLICK",!1],e142x1_client:["LBLSUBCATPESOFILTER.CLICK",!1],e152x1_client:["LBLSUBCATDISPFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6csubCatID",fld:"vCSUBCATID",pic:"ZZZ9"},{av:"AV7csubCatDsc",fld:"vCSUBCATDSC",pic:"@!"},{av:"AV8csubCatPrec",fld:"vCSUBCATPREC",pic:"ZZZZ9.99"},{av:"AV9csubCatPeso",fld:"vCSUBCATPESO",pic:"ZZZZ9.99"},{av:"AV10csubCatDisp",fld:"vCSUBCATDISP",pic:"ZZZZZZZ9"},{av:"AV11pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV12pcategID",fld:"vPCATEGID",pic:"ZZZ9"}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLSUBCATIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("SUBCATIDFILTERCONTAINER","Class")',ctrl:"SUBCATIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("SUBCATIDFILTERCONTAINER","Class")',ctrl:"SUBCATIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCSUBCATID","Visible")',ctrl:"vCSUBCATID",prop:"Visible"}]];this.EvtParms["LBLSUBCATDSCFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("SUBCATDSCFILTERCONTAINER","Class")',ctrl:"SUBCATDSCFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("SUBCATDSCFILTERCONTAINER","Class")',ctrl:"SUBCATDSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCSUBCATDSC","Visible")',ctrl:"vCSUBCATDSC",prop:"Visible"}]];this.EvtParms["LBLSUBCATPRECFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("SUBCATPRECFILTERCONTAINER","Class")',ctrl:"SUBCATPRECFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("SUBCATPRECFILTERCONTAINER","Class")',ctrl:"SUBCATPRECFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCSUBCATPREC","Visible")',ctrl:"vCSUBCATPREC",prop:"Visible"}]];this.EvtParms["LBLSUBCATPESOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("SUBCATPESOFILTERCONTAINER","Class")',ctrl:"SUBCATPESOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("SUBCATPESOFILTERCONTAINER","Class")',ctrl:"SUBCATPESOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCSUBCATPESO","Visible")',ctrl:"vCSUBCATPESO",prop:"Visible"}]];this.EvtParms["LBLSUBCATDISPFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("SUBCATDISPFILTERCONTAINER","Class")',ctrl:"SUBCATDISPFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("SUBCATDISPFILTERCONTAINER","Class")',ctrl:"SUBCATDISPFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCSUBCATDISP","Visible")',ctrl:"vCSUBCATDISP",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A33subCatID",fld:"SUBCATID",pic:"ZZZ9",hsh:!0}],[{av:"AV13psubCatID",fld:"vPSUBCATID",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6csubCatID",fld:"vCSUBCATID",pic:"ZZZ9"},{av:"AV7csubCatDsc",fld:"vCSUBCATDSC",pic:"@!"},{av:"AV8csubCatPrec",fld:"vCSUBCATPREC",pic:"ZZZZ9.99"},{av:"AV9csubCatPeso",fld:"vCSUBCATPESO",pic:"ZZZZ9.99"},{av:"AV10csubCatDisp",fld:"vCSUBCATDISP",pic:"ZZZZZZZ9"},{av:"AV11pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV12pcategID",fld:"vPCATEGID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6csubCatID",fld:"vCSUBCATID",pic:"ZZZ9"},{av:"AV7csubCatDsc",fld:"vCSUBCATDSC",pic:"@!"},{av:"AV8csubCatPrec",fld:"vCSUBCATPREC",pic:"ZZZZ9.99"},{av:"AV9csubCatPeso",fld:"vCSUBCATPESO",pic:"ZZZZ9.99"},{av:"AV10csubCatDisp",fld:"vCSUBCATDISP",pic:"ZZZZZZZ9"},{av:"AV11pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV12pcategID",fld:"vPCATEGID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6csubCatID",fld:"vCSUBCATID",pic:"ZZZ9"},{av:"AV7csubCatDsc",fld:"vCSUBCATDSC",pic:"@!"},{av:"AV8csubCatPrec",fld:"vCSUBCATPREC",pic:"ZZZZ9.99"},{av:"AV9csubCatPeso",fld:"vCSUBCATPESO",pic:"ZZZZ9.99"},{av:"AV10csubCatDisp",fld:"vCSUBCATDISP",pic:"ZZZZZZZ9"},{av:"AV11pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV12pcategID",fld:"vPCATEGID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6csubCatID",fld:"vCSUBCATID",pic:"ZZZ9"},{av:"AV7csubCatDsc",fld:"vCSUBCATDSC",pic:"@!"},{av:"AV8csubCatPrec",fld:"vCSUBCATPREC",pic:"ZZZZ9.99"},{av:"AV9csubCatPeso",fld:"vCSUBCATPESO",pic:"ZZZZ9.99"},{av:"AV10csubCatDisp",fld:"vCSUBCATDISP",pic:"ZZZZZZZ9"},{av:"AV11pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV12pcategID",fld:"vPCATEGID",pic:"ZZZ9"}],[]];this.setVCMap("AV11pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV12pcategID","vPCATEGID",0,"int",4,0);this.setVCMap("AV13psubCatID","vPSUBCATID",0,"int",4,0);this.setVCMap("AV11pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV12pcategID","vPCATEGID",0,"int",4,0);this.setVCMap("AV11pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV12pcategID","vPCATEGID",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);t.addRefreshingVar({rfrVar:"AV11pEmpID"});t.addRefreshingVar({rfrVar:"AV12pcategID"});this.Initialize()});gx.createParentObj(gx00r2)