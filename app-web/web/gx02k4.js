/*!   GeneXus C# 15_0_12-126726 on 1/12/2023 22:36:37.9
*/
gx.evt.autoSkip=!1;gx.define("gx02k4",!1,function(){var n,t;this.ServerClass="gx02k4";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV9pEmpID=gx.fn.getIntegerValue("vPEMPID",".");this.AV10pAgeID=gx.fn.getIntegerValue("vPAGEID",".");this.AV11pDespBodNro=gx.fn.getIntegerValue("vPDESPBODNRO",".");this.AV12pOrdenID=gx.fn.getIntegerValue("vPORDENID",".");this.AV13pnroReg=gx.fn.getIntegerValue("vPNROREG",".");this.AV9pEmpID=gx.fn.getIntegerValue("vPEMPID",".");this.AV10pAgeID=gx.fn.getIntegerValue("vPAGEID",".");this.AV11pDespBodNro=gx.fn.getIntegerValue("vPDESPBODNRO",".");this.AV12pOrdenID=gx.fn.getIntegerValue("vPORDENID",".")};this.e145x1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e115x1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("NROREGFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("NROREGFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCNROREG","Visible",!0)):(gx.fn.setCtrlProperty("NROREGFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCNROREG","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("NROREGFILTERCONTAINER","Class")',ctrl:"NROREGFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCNROREG","Visible")',ctrl:"vCNROREG",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e125x1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("DESPBODCODPRDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("DESPBODCODPRDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCDESPBODCODPRD","Visible",!0)):(gx.fn.setCtrlProperty("DESPBODCODPRDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCDESPBODCODPRD","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("DESPBODCODPRDFILTERCONTAINER","Class")',ctrl:"DESPBODCODPRDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCDESPBODCODPRD","Visible")',ctrl:"vCDESPBODCODPRD",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e135x1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("DESPBODPRDNOMBREFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("DESPBODPRDNOMBREFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCDESPBODPRDNOMBRE","Visible",!0)):(gx.fn.setCtrlProperty("DESPBODPRDNOMBREFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCDESPBODPRDNOMBRE","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("DESPBODPRDNOMBREFILTERCONTAINER","Class")',ctrl:"DESPBODPRDNOMBREFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCDESPBODPRDNOMBRE","Visible")',ctrl:"vCDESPBODPRDNOMBRE",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e175x2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e185x1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60];this.GXLastCtrlId=60;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",44,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx02k4",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",45,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(400,46,"NROREG","Reg","","nroReg","int",0,"px",6,6,"right",null,[],400,"nroReg",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(355,47,"DESPBODCODPRD","Producto","","DespBodCodPrd","int",0,"px",4,4,"right",null,[],355,"DespBodCodPrd",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(356,48,"DESPBODPRDNOMBRE","Producto","","DespBodPrdNombre","char",0,"px",40,40,"left",null,[],356,"DespBodPrdNombre",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(357,49,"DESPBODCANT","Cantidad","","DespBodCant","decimal",0,"px",8,8,"right",null,[],357,"DespBodCant",!0,2,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(358,50,"DESPBODVALOR","Valor","","DespBodValor","decimal",0,"px",8,8,"right",null,[],358,"DespBodValor",!0,2,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(359,51,"DESPBODADESP","Despachar","","DespBodADesp","decimal",0,"px",8,8,"right",null,[],359,"DespBodADesp",!0,2,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(361,52,"DESPBODCATID","Id","","DespBodCatId","int",0,"px",4,4,"right",null,[],361,"DespBodCatId",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(392,53,"DESPBODOK","procesado","","DespBodOK","char",0,"px",1,1,"left",null,[],392,"DespBodOK",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(1,54,"EMPID","Emp ID","","EmpID","int",0,"px",4,4,"right",null,[],1,"EmpID",!1,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(2,55,"AGEID","Age ID","","AgeID","int",0,"px",4,4,"right",null,[],2,"AgeID",!1,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(353,56,"DESPBODNRO","Desp Bod Nro","","DespBodNro","int",0,"px",4,4,"right",null,[],353,"DespBodNro",!1,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(22,57,"ORDENID","Orden ID","","OrdenID","int",0,"px",4,4,"right",null,[],22,"OrdenID",!1,0,!1,!1,"Attribute",1,"");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"NROREGFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLNROREGFILTER",format:1,grid:0,evt:"e115x1_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:6,dec:0,sign:!1,pic:"ZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCNROREG",gxz:"ZV6cnroReg",gxold:"OV6cnroReg",gxvar:"AV6cnroReg",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cnroReg=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cnroReg=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCNROREG",gx.O.AV6cnroReg,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cnroReg=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCNROREG",".")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"DESPBODCODPRDFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLDESPBODCODPRDFILTER",format:1,grid:0,evt:"e125x1_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCDESPBODCODPRD",gxz:"ZV7cDespBodCodPrd",gxold:"OV7cDespBodCodPrd",gxvar:"AV7cDespBodCodPrd",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cDespBodCodPrd=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV7cDespBodCodPrd=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCDESPBODCODPRD",gx.O.AV7cDespBodCodPrd,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cDespBodCodPrd=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCDESPBODCODPRD",".")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"DESPBODPRDNOMBREFILTERCONTAINER",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"LBLDESPBODPRDNOMBREFILTER",format:1,grid:0,evt:"e135x1_client"};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,lvl:0,type:"char",len:40,dec:0,sign:!1,pic:"@!",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCDESPBODPRDNOMBRE",gxz:"ZV8cDespBodPrdNombre",gxold:"OV8cDespBodPrdNombre",gxvar:"AV8cDespBodPrdNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cDespBodPrdNombre=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8cDespBodPrdNombre=n)},v2c:function(){gx.fn.setControlValue("vCDESPBODPRDNOMBRE",gx.O.AV8cDespBodPrdNombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cDespBodPrdNombre=this.val())},val:function(){return gx.fn.getControlValue("vCDESPBODPRDNOMBRE")},nac:gx.falseFn};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"GRIDTABLE",grid:0};n[39]={id:39,fld:"",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"BTNTOGGLE",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[45]={id:45,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(44),gx.O.AV5LinkSelection,gx.O.AV17Linkselection_GXI)},c2v:function(){gx.O.AV17Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(44))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(44))},gxvar_GXI:"AV17Linkselection_GXI",nac:gx.falseFn};n[46]={id:46,lvl:2,type:"int",len:6,dec:0,sign:!1,pic:"ZZZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"NROREG",gxz:"Z400nroReg",gxold:"O400nroReg",gxvar:"A400nroReg",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A400nroReg=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z400nroReg=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("NROREG",n||gx.fn.currentGridRowImpl(44),gx.O.A400nroReg,0)},c2v:function(){this.val()!==undefined&&(gx.O.A400nroReg=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("NROREG",n||gx.fn.currentGridRowImpl(44),".")},nac:gx.falseFn};n[47]={id:47,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DESPBODCODPRD",gxz:"Z355DespBodCodPrd",gxold:"O355DespBodCodPrd",gxvar:"A355DespBodCodPrd",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A355DespBodCodPrd=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z355DespBodCodPrd=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("DESPBODCODPRD",n||gx.fn.currentGridRowImpl(44),gx.O.A355DespBodCodPrd,0)},c2v:function(){this.val()!==undefined&&(gx.O.A355DespBodCodPrd=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("DESPBODCODPRD",n||gx.fn.currentGridRowImpl(44),".")},nac:gx.falseFn};n[48]={id:48,lvl:2,type:"char",len:40,dec:0,sign:!1,pic:"@!",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DESPBODPRDNOMBRE",gxz:"Z356DespBodPrdNombre",gxold:"O356DespBodPrdNombre",gxvar:"A356DespBodPrdNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A356DespBodPrdNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z356DespBodPrdNombre=n)},v2c:function(n){gx.fn.setGridControlValue("DESPBODPRDNOMBRE",n||gx.fn.currentGridRowImpl(44),gx.O.A356DespBodPrdNombre,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A356DespBodPrdNombre=this.val())},val:function(n){return gx.fn.getGridControlValue("DESPBODPRDNOMBRE",n||gx.fn.currentGridRowImpl(44))},nac:gx.falseFn};n[49]={id:49,lvl:2,type:"decimal",len:8,dec:2,sign:!1,pic:"ZZZZ9.99",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DESPBODCANT",gxz:"Z357DespBodCant",gxold:"O357DespBodCant",gxvar:"A357DespBodCant",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A357DespBodCant=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z357DespBodCant=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("DESPBODCANT",n||gx.fn.currentGridRowImpl(44),gx.O.A357DespBodCant,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A357DespBodCant=this.val())},val:function(n){return gx.fn.getGridDecimalValue("DESPBODCANT",n||gx.fn.currentGridRowImpl(44),".",",")},nac:gx.falseFn};n[50]={id:50,lvl:2,type:"decimal",len:8,dec:2,sign:!1,pic:"ZZZZ9.99",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DESPBODVALOR",gxz:"Z358DespBodValor",gxold:"O358DespBodValor",gxvar:"A358DespBodValor",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A358DespBodValor=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z358DespBodValor=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("DESPBODVALOR",n||gx.fn.currentGridRowImpl(44),gx.O.A358DespBodValor,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A358DespBodValor=this.val())},val:function(n){return gx.fn.getGridDecimalValue("DESPBODVALOR",n||gx.fn.currentGridRowImpl(44),".",",")},nac:gx.falseFn};n[51]={id:51,lvl:2,type:"decimal",len:8,dec:2,sign:!1,pic:"ZZZZ9.99",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DESPBODADESP",gxz:"Z359DespBodADesp",gxold:"O359DespBodADesp",gxvar:"A359DespBodADesp",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A359DespBodADesp=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z359DespBodADesp=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("DESPBODADESP",n||gx.fn.currentGridRowImpl(44),gx.O.A359DespBodADesp,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A359DespBodADesp=this.val())},val:function(n){return gx.fn.getGridDecimalValue("DESPBODADESP",n||gx.fn.currentGridRowImpl(44),".",",")},nac:gx.falseFn};n[52]={id:52,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DESPBODCATID",gxz:"Z361DespBodCatId",gxold:"O361DespBodCatId",gxvar:"A361DespBodCatId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A361DespBodCatId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z361DespBodCatId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("DESPBODCATID",n||gx.fn.currentGridRowImpl(44),gx.O.A361DespBodCatId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A361DespBodCatId=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("DESPBODCATID",n||gx.fn.currentGridRowImpl(44),".")},nac:gx.falseFn};n[53]={id:53,lvl:2,type:"char",len:1,dec:0,sign:!1,ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DESPBODOK",gxz:"Z392DespBodOK",gxold:"O392DespBodOK",gxvar:"A392DespBodOK",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A392DespBodOK=n)},v2z:function(n){n!==undefined&&(gx.O.Z392DespBodOK=n)},v2c:function(n){gx.fn.setGridControlValue("DESPBODOK",n||gx.fn.currentGridRowImpl(44),gx.O.A392DespBodOK,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A392DespBodOK=this.val())},val:function(n){return gx.fn.getGridControlValue("DESPBODOK",n||gx.fn.currentGridRowImpl(44))},nac:gx.falseFn};n[54]={id:54,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EMPID",gxz:"Z1EmpID",gxold:"O1EmpID",gxvar:"A1EmpID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A1EmpID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1EmpID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("EMPID",n||gx.fn.currentGridRowImpl(44),gx.O.A1EmpID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A1EmpID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("EMPID",n||gx.fn.currentGridRowImpl(44),".")},nac:gx.falseFn};n[55]={id:55,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"AGEID",gxz:"Z2AgeID",gxold:"O2AgeID",gxvar:"A2AgeID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A2AgeID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z2AgeID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("AGEID",n||gx.fn.currentGridRowImpl(44),gx.O.A2AgeID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A2AgeID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("AGEID",n||gx.fn.currentGridRowImpl(44),".")},nac:gx.falseFn};n[56]={id:56,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DESPBODNRO",gxz:"Z353DespBodNro",gxold:"O353DespBodNro",gxvar:"A353DespBodNro",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A353DespBodNro=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z353DespBodNro=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("DESPBODNRO",n||gx.fn.currentGridRowImpl(44),gx.O.A353DespBodNro,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A353DespBodNro=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("DESPBODNRO",n||gx.fn.currentGridRowImpl(44),".")},nac:gx.falseFn};n[57]={id:57,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ORDENID",gxz:"Z22OrdenID",gxold:"O22OrdenID",gxvar:"A22OrdenID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A22OrdenID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z22OrdenID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ORDENID",n||gx.fn.currentGridRowImpl(44),gx.O.A22OrdenID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A22OrdenID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ORDENID",n||gx.fn.currentGridRowImpl(44),".")},nac:gx.falseFn};n[58]={id:58,fld:"",grid:0};n[59]={id:59,fld:"",grid:0};n[60]={id:60,fld:"BTN_CANCEL",grid:0};this.AV6cnroReg=0;this.ZV6cnroReg=0;this.OV6cnroReg=0;this.AV7cDespBodCodPrd=0;this.ZV7cDespBodCodPrd=0;this.OV7cDespBodCodPrd=0;this.AV8cDespBodPrdNombre="";this.ZV8cDespBodPrdNombre="";this.OV8cDespBodPrdNombre="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z400nroReg=0;this.O400nroReg=0;this.Z355DespBodCodPrd=0;this.O355DespBodCodPrd=0;this.Z356DespBodPrdNombre="";this.O356DespBodPrdNombre="";this.Z357DespBodCant=0;this.O357DespBodCant=0;this.Z358DespBodValor=0;this.O358DespBodValor=0;this.Z359DespBodADesp=0;this.O359DespBodADesp=0;this.Z361DespBodCatId=0;this.O361DespBodCatId=0;this.Z392DespBodOK="";this.O392DespBodOK="";this.Z1EmpID=0;this.O1EmpID=0;this.Z2AgeID=0;this.O2AgeID=0;this.Z353DespBodNro=0;this.O353DespBodNro=0;this.Z22OrdenID=0;this.O22OrdenID=0;this.AV6cnroReg=0;this.AV7cDespBodCodPrd=0;this.AV8cDespBodPrdNombre="";this.AV9pEmpID=0;this.AV10pAgeID=0;this.AV11pDespBodNro=0;this.AV12pOrdenID=0;this.AV13pnroReg=0;this.AV5LinkSelection="";this.A400nroReg=0;this.A355DespBodCodPrd=0;this.A356DespBodPrdNombre="";this.A357DespBodCant=0;this.A358DespBodValor=0;this.A359DespBodADesp=0;this.A361DespBodCatId=0;this.A392DespBodOK="";this.A1EmpID=0;this.A2AgeID=0;this.A353DespBodNro=0;this.A22OrdenID=0;this.Events={e175x2_client:["ENTER",!0],e185x1_client:["CANCEL",!0],e145x1_client:["'TOGGLE'",!1],e115x1_client:["LBLNROREGFILTER.CLICK",!1],e125x1_client:["LBLDESPBODCODPRDFILTER.CLICK",!1],e135x1_client:["LBLDESPBODPRDNOMBREFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cnroReg",fld:"vCNROREG",pic:"ZZZZZ9"},{av:"AV7cDespBodCodPrd",fld:"vCDESPBODCODPRD",pic:"ZZZ9"},{av:"AV8cDespBodPrdNombre",fld:"vCDESPBODPRDNOMBRE",pic:"@!"},{av:"AV9pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV10pAgeID",fld:"vPAGEID",pic:"ZZZ9"},{av:"AV11pDespBodNro",fld:"vPDESPBODNRO",pic:"ZZZ9"},{av:"AV12pOrdenID",fld:"vPORDENID",pic:"ZZZ9"}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLNROREGFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("NROREGFILTERCONTAINER","Class")',ctrl:"NROREGFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("NROREGFILTERCONTAINER","Class")',ctrl:"NROREGFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCNROREG","Visible")',ctrl:"vCNROREG",prop:"Visible"}]];this.EvtParms["LBLDESPBODCODPRDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("DESPBODCODPRDFILTERCONTAINER","Class")',ctrl:"DESPBODCODPRDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("DESPBODCODPRDFILTERCONTAINER","Class")',ctrl:"DESPBODCODPRDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCDESPBODCODPRD","Visible")',ctrl:"vCDESPBODCODPRD",prop:"Visible"}]];this.EvtParms["LBLDESPBODPRDNOMBREFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("DESPBODPRDNOMBREFILTERCONTAINER","Class")',ctrl:"DESPBODPRDNOMBREFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("DESPBODPRDNOMBREFILTERCONTAINER","Class")',ctrl:"DESPBODPRDNOMBREFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCDESPBODPRDNOMBRE","Visible")',ctrl:"vCDESPBODPRDNOMBRE",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A400nroReg",fld:"NROREG",pic:"ZZZZZ9",hsh:!0}],[{av:"AV13pnroReg",fld:"vPNROREG",pic:"ZZZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cnroReg",fld:"vCNROREG",pic:"ZZZZZ9"},{av:"AV7cDespBodCodPrd",fld:"vCDESPBODCODPRD",pic:"ZZZ9"},{av:"AV8cDespBodPrdNombre",fld:"vCDESPBODPRDNOMBRE",pic:"@!"},{av:"AV9pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV10pAgeID",fld:"vPAGEID",pic:"ZZZ9"},{av:"AV11pDespBodNro",fld:"vPDESPBODNRO",pic:"ZZZ9"},{av:"AV12pOrdenID",fld:"vPORDENID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cnroReg",fld:"vCNROREG",pic:"ZZZZZ9"},{av:"AV7cDespBodCodPrd",fld:"vCDESPBODCODPRD",pic:"ZZZ9"},{av:"AV8cDespBodPrdNombre",fld:"vCDESPBODPRDNOMBRE",pic:"@!"},{av:"AV9pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV10pAgeID",fld:"vPAGEID",pic:"ZZZ9"},{av:"AV11pDespBodNro",fld:"vPDESPBODNRO",pic:"ZZZ9"},{av:"AV12pOrdenID",fld:"vPORDENID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cnroReg",fld:"vCNROREG",pic:"ZZZZZ9"},{av:"AV7cDespBodCodPrd",fld:"vCDESPBODCODPRD",pic:"ZZZ9"},{av:"AV8cDespBodPrdNombre",fld:"vCDESPBODPRDNOMBRE",pic:"@!"},{av:"AV9pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV10pAgeID",fld:"vPAGEID",pic:"ZZZ9"},{av:"AV11pDespBodNro",fld:"vPDESPBODNRO",pic:"ZZZ9"},{av:"AV12pOrdenID",fld:"vPORDENID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cnroReg",fld:"vCNROREG",pic:"ZZZZZ9"},{av:"AV7cDespBodCodPrd",fld:"vCDESPBODCODPRD",pic:"ZZZ9"},{av:"AV8cDespBodPrdNombre",fld:"vCDESPBODPRDNOMBRE",pic:"@!"},{av:"AV9pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV10pAgeID",fld:"vPAGEID",pic:"ZZZ9"},{av:"AV11pDespBodNro",fld:"vPDESPBODNRO",pic:"ZZZ9"},{av:"AV12pOrdenID",fld:"vPORDENID",pic:"ZZZ9"}],[]];this.setVCMap("AV9pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV10pAgeID","vPAGEID",0,"int",4,0);this.setVCMap("AV11pDespBodNro","vPDESPBODNRO",0,"int",4,0);this.setVCMap("AV12pOrdenID","vPORDENID",0,"int",4,0);this.setVCMap("AV13pnroReg","vPNROREG",0,"int",6,0);this.setVCMap("AV9pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV10pAgeID","vPAGEID",0,"int",4,0);this.setVCMap("AV11pDespBodNro","vPDESPBODNRO",0,"int",4,0);this.setVCMap("AV12pOrdenID","vPORDENID",0,"int",4,0);this.setVCMap("AV9pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV10pAgeID","vPAGEID",0,"int",4,0);this.setVCMap("AV11pDespBodNro","vPDESPBODNRO",0,"int",4,0);this.setVCMap("AV12pOrdenID","vPORDENID",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar({rfrVar:"AV9pEmpID"});t.addRefreshingVar({rfrVar:"AV10pAgeID"});t.addRefreshingVar({rfrVar:"AV11pDespBodNro"});t.addRefreshingVar({rfrVar:"AV12pOrdenID"});this.Initialize()});gx.createParentObj(gx02k4)