/*!   GeneXus C# 15_0_12-126726 on 10/26/2022 20:17:19.56
*/
gx.evt.autoSkip=!1;gx.define("gx0081",!1,function(){var n,t;this.ServerClass="gx0081";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV12pEmpID=gx.fn.getIntegerValue("vPEMPID",".");this.AV13pVehiculoID=gx.fn.getIntegerValue("vPVEHICULOID",".");this.AV12pEmpID=gx.fn.getIntegerValue("vPEMPID",".")};this.e173i1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e113i1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("VEHICULOIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("VEHICULOIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCVEHICULOID","Visible",!0)):(gx.fn.setCtrlProperty("VEHICULOIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCVEHICULOID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("VEHICULOIDFILTERCONTAINER","Class")',ctrl:"VEHICULOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCVEHICULOID","Visible")',ctrl:"vCVEHICULOID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e123i1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("VEHICULODSCFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("VEHICULODSCFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCVEHICULODSC","Visible",!0)):(gx.fn.setCtrlProperty("VEHICULODSCFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCVEHICULODSC","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("VEHICULODSCFILTERCONTAINER","Class")',ctrl:"VEHICULODSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCVEHICULODSC","Visible")',ctrl:"vCVEHICULODSC",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e133i1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("MARCAIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("MARCAIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCMARCAID","Visible",!0)):(gx.fn.setCtrlProperty("MARCAIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCMARCAID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MARCAIDFILTERCONTAINER","Class")',ctrl:"MARCAIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMARCAID","Visible")',ctrl:"vCMARCAID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e143i1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("MODELOIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("MODELOIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCMODELOID","Visible",!0)):(gx.fn.setCtrlProperty("MODELOIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCMODELOID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MODELOIDFILTERCONTAINER","Class")',ctrl:"MODELOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMODELOID","Visible")',ctrl:"vCMODELOID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e153i1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("VEHICULOESTFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("VEHICULOESTFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCVEHICULOEST","Visible",!0)):(gx.fn.setCtrlProperty("VEHICULOESTFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCVEHICULOEST","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("VEHICULOESTFILTERCONTAINER","Class")',ctrl:"VEHICULOESTFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCVEHICULOEST","Visible")',ctrl:"vCVEHICULOEST",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e163i1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("VEHICULOPLACAFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("VEHICULOPLACAFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCVEHICULOPLACA","Visible",!0)):(gx.fn.setCtrlProperty("VEHICULOPLACAFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCVEHICULOPLACA","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("VEHICULOPLACAFILTERCONTAINER","Class")',ctrl:"VEHICULOPLACAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCVEHICULOPLACA","Visible")',ctrl:"vCVEHICULOPLACA",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e203i2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e213i1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,75,76,77,78,79,80,81,82,83,84,85,86];this.GXLastCtrlId=86;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",74,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0081",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",75,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(8,76,"VEHICULOID","ID","","VehiculoID","int",0,"px",4,4,"right",null,[],8,"VehiculoID",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(66,77,"VEHICULODSC","Descripcion","","VehiculoDsc","char",0,"px",50,50,"left",null,[],66,"VehiculoDsc",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(6,78,"MARCAID","Marca ID","","MarcaID","int",0,"px",4,4,"right",null,[],6,"MarcaID",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(7,79,"MODELOID","Modelo ID","","ModeloID","int",0,"px",4,4,"right",null,[],7,"ModeloID",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(67,80,"VEHICULOEST","Est","","VehiculoEst","char",0,"px",1,1,"left",null,[],67,"VehiculoEst",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(68,81,"VEHICULOPLACA","Placa","","VehiculoPlaca","svchar",0,"px",15,15,"left",null,[],68,"VehiculoPlaca",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(71,82,"VEHICULOCEDRESP","Responsable","","VehiculoCedResp","char",0,"px",13,13,"left",null,[],71,"VehiculoCedResp",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(1,83,"EMPID","Emp ID","","EmpID","int",0,"px",4,4,"right",null,[],1,"EmpID",!1,0,!1,!1,"Attribute",1,"");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"VEHICULOIDFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLVEHICULOIDFILTER",format:1,grid:0,evt:"e113i1_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCVEHICULOID",gxz:"ZV6cVehiculoID",gxold:"OV6cVehiculoID",gxvar:"AV6cVehiculoID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cVehiculoID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cVehiculoID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCVEHICULOID",gx.O.AV6cVehiculoID,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cVehiculoID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCVEHICULOID",".")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"VEHICULODSCFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLVEHICULODSCFILTER",format:1,grid:0,evt:"e123i1_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"char",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCVEHICULODSC",gxz:"ZV7cVehiculoDsc",gxold:"OV7cVehiculoDsc",gxvar:"AV7cVehiculoDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cVehiculoDsc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7cVehiculoDsc=n)},v2c:function(){gx.fn.setControlValue("vCVEHICULODSC",gx.O.AV7cVehiculoDsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cVehiculoDsc=this.val())},val:function(){return gx.fn.getControlValue("vCVEHICULODSC")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"MARCAIDFILTERCONTAINER",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"LBLMARCAIDFILTER",format:1,grid:0,evt:"e133i1_client"};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCMARCAID",gxz:"ZV8cMarcaID",gxold:"OV8cMarcaID",gxvar:"AV8cMarcaID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cMarcaID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV8cMarcaID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCMARCAID",gx.O.AV8cMarcaID,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cMarcaID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCMARCAID",".")},nac:gx.falseFn};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"MODELOIDFILTERCONTAINER",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"LBLMODELOIDFILTER",format:1,grid:0,evt:"e143i1_client"};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCMODELOID",gxz:"ZV9cModeloID",gxold:"OV9cModeloID",gxvar:"AV9cModeloID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9cModeloID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV9cModeloID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCMODELOID",gx.O.AV9cModeloID,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9cModeloID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCMODELOID",".")},nac:gx.falseFn};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"VEHICULOESTFILTERCONTAINER",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"LBLVEHICULOESTFILTER",format:1,grid:0,evt:"e153i1_client"};n[53]={id:53,fld:"",grid:0};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"",grid:0};n[56]={id:56,lvl:0,type:"char",len:1,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCVEHICULOEST",gxz:"ZV10cVehiculoEst",gxold:"OV10cVehiculoEst",gxvar:"AV10cVehiculoEst",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10cVehiculoEst=n)},v2z:function(n){n!==undefined&&(gx.O.ZV10cVehiculoEst=n)},v2c:function(){gx.fn.setControlValue("vCVEHICULOEST",gx.O.AV10cVehiculoEst,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10cVehiculoEst=this.val())},val:function(){return gx.fn.getControlValue("vCVEHICULOEST")},nac:gx.falseFn};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"",grid:0};n[59]={id:59,fld:"VEHICULOPLACAFILTERCONTAINER",grid:0};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"LBLVEHICULOPLACAFILTER",format:1,grid:0,evt:"e163i1_client"};n[63]={id:63,fld:"",grid:0};n[64]={id:64,fld:"",grid:0};n[65]={id:65,fld:"",grid:0};n[66]={id:66,lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCVEHICULOPLACA",gxz:"ZV11cVehiculoPlaca",gxold:"OV11cVehiculoPlaca",gxvar:"AV11cVehiculoPlaca",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV11cVehiculoPlaca=n)},v2z:function(n){n!==undefined&&(gx.O.ZV11cVehiculoPlaca=n)},v2c:function(){gx.fn.setControlValue("vCVEHICULOPLACA",gx.O.AV11cVehiculoPlaca,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV11cVehiculoPlaca=this.val())},val:function(){return gx.fn.getControlValue("vCVEHICULOPLACA")},nac:gx.falseFn};n[67]={id:67,fld:"",grid:0};n[68]={id:68,fld:"GRIDTABLE",grid:0};n[69]={id:69,fld:"",grid:0};n[70]={id:70,fld:"",grid:0};n[71]={id:71,fld:"BTNTOGGLE",grid:0};n[72]={id:72,fld:"",grid:0};n[73]={id:73,fld:"",grid:0};n[75]={id:75,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(74),gx.O.AV5LinkSelection,gx.O.AV17Linkselection_GXI)},c2v:function(){gx.O.AV17Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(74))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(74))},gxvar_GXI:"AV17Linkselection_GXI",nac:gx.falseFn};n[76]={id:76,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VEHICULOID",gxz:"Z8VehiculoID",gxold:"O8VehiculoID",gxvar:"A8VehiculoID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A8VehiculoID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z8VehiculoID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("VEHICULOID",n||gx.fn.currentGridRowImpl(74),gx.O.A8VehiculoID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A8VehiculoID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("VEHICULOID",n||gx.fn.currentGridRowImpl(74),".")},nac:gx.falseFn};n[77]={id:77,lvl:2,type:"char",len:50,dec:0,sign:!1,ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VEHICULODSC",gxz:"Z66VehiculoDsc",gxold:"O66VehiculoDsc",gxvar:"A66VehiculoDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A66VehiculoDsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z66VehiculoDsc=n)},v2c:function(n){gx.fn.setGridControlValue("VEHICULODSC",n||gx.fn.currentGridRowImpl(74),gx.O.A66VehiculoDsc,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A66VehiculoDsc=this.val())},val:function(n){return gx.fn.getGridControlValue("VEHICULODSC",n||gx.fn.currentGridRowImpl(74))},nac:gx.falseFn};n[78]={id:78,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"MARCAID",gxz:"Z6MarcaID",gxold:"O6MarcaID",gxvar:"A6MarcaID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A6MarcaID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z6MarcaID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("MARCAID",n||gx.fn.currentGridRowImpl(74),gx.O.A6MarcaID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A6MarcaID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("MARCAID",n||gx.fn.currentGridRowImpl(74),".")},nac:gx.falseFn};n[79]={id:79,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"MODELOID",gxz:"Z7ModeloID",gxold:"O7ModeloID",gxvar:"A7ModeloID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A7ModeloID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z7ModeloID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("MODELOID",n||gx.fn.currentGridRowImpl(74),gx.O.A7ModeloID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A7ModeloID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("MODELOID",n||gx.fn.currentGridRowImpl(74),".")},nac:gx.falseFn};n[80]={id:80,lvl:2,type:"char",len:1,dec:0,sign:!1,ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VEHICULOEST",gxz:"Z67VehiculoEst",gxold:"O67VehiculoEst",gxvar:"A67VehiculoEst",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A67VehiculoEst=n)},v2z:function(n){n!==undefined&&(gx.O.Z67VehiculoEst=n)},v2c:function(n){gx.fn.setGridControlValue("VEHICULOEST",n||gx.fn.currentGridRowImpl(74),gx.O.A67VehiculoEst,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A67VehiculoEst=this.val())},val:function(n){return gx.fn.getGridControlValue("VEHICULOEST",n||gx.fn.currentGridRowImpl(74))},nac:gx.falseFn};n[81]={id:81,lvl:2,type:"svchar",len:15,dec:0,sign:!1,ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VEHICULOPLACA",gxz:"Z68VehiculoPlaca",gxold:"O68VehiculoPlaca",gxvar:"A68VehiculoPlaca",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A68VehiculoPlaca=n)},v2z:function(n){n!==undefined&&(gx.O.Z68VehiculoPlaca=n)},v2c:function(n){gx.fn.setGridControlValue("VEHICULOPLACA",n||gx.fn.currentGridRowImpl(74),gx.O.A68VehiculoPlaca,0)},c2v:function(){this.val()!==undefined&&(gx.O.A68VehiculoPlaca=this.val())},val:function(n){return gx.fn.getGridControlValue("VEHICULOPLACA",n||gx.fn.currentGridRowImpl(74))},nac:gx.falseFn};n[82]={id:82,lvl:2,type:"char",len:13,dec:0,sign:!1,ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VEHICULOCEDRESP",gxz:"Z71VehiculoCedResp",gxold:"O71VehiculoCedResp",gxvar:"A71VehiculoCedResp",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A71VehiculoCedResp=n)},v2z:function(n){n!==undefined&&(gx.O.Z71VehiculoCedResp=n)},v2c:function(n){gx.fn.setGridControlValue("VEHICULOCEDRESP",n||gx.fn.currentGridRowImpl(74),gx.O.A71VehiculoCedResp,0)},c2v:function(){this.val()!==undefined&&(gx.O.A71VehiculoCedResp=this.val())},val:function(n){return gx.fn.getGridControlValue("VEHICULOCEDRESP",n||gx.fn.currentGridRowImpl(74))},nac:gx.falseFn};n[83]={id:83,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EMPID",gxz:"Z1EmpID",gxold:"O1EmpID",gxvar:"A1EmpID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A1EmpID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1EmpID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("EMPID",n||gx.fn.currentGridRowImpl(74),gx.O.A1EmpID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A1EmpID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("EMPID",n||gx.fn.currentGridRowImpl(74),".")},nac:gx.falseFn};n[84]={id:84,fld:"",grid:0};n[85]={id:85,fld:"",grid:0};n[86]={id:86,fld:"BTN_CANCEL",grid:0};this.AV6cVehiculoID=0;this.ZV6cVehiculoID=0;this.OV6cVehiculoID=0;this.AV7cVehiculoDsc="";this.ZV7cVehiculoDsc="";this.OV7cVehiculoDsc="";this.AV8cMarcaID=0;this.ZV8cMarcaID=0;this.OV8cMarcaID=0;this.AV9cModeloID=0;this.ZV9cModeloID=0;this.OV9cModeloID=0;this.AV10cVehiculoEst="";this.ZV10cVehiculoEst="";this.OV10cVehiculoEst="";this.AV11cVehiculoPlaca="";this.ZV11cVehiculoPlaca="";this.OV11cVehiculoPlaca="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z8VehiculoID=0;this.O8VehiculoID=0;this.Z66VehiculoDsc="";this.O66VehiculoDsc="";this.Z6MarcaID=0;this.O6MarcaID=0;this.Z7ModeloID=0;this.O7ModeloID=0;this.Z67VehiculoEst="";this.O67VehiculoEst="";this.Z68VehiculoPlaca="";this.O68VehiculoPlaca="";this.Z71VehiculoCedResp="";this.O71VehiculoCedResp="";this.Z1EmpID=0;this.O1EmpID=0;this.AV6cVehiculoID=0;this.AV7cVehiculoDsc="";this.AV8cMarcaID=0;this.AV9cModeloID=0;this.AV10cVehiculoEst="";this.AV11cVehiculoPlaca="";this.AV12pEmpID=0;this.AV13pVehiculoID=0;this.AV5LinkSelection="";this.A8VehiculoID=0;this.A66VehiculoDsc="";this.A6MarcaID=0;this.A7ModeloID=0;this.A67VehiculoEst="";this.A68VehiculoPlaca="";this.A71VehiculoCedResp="";this.A1EmpID=0;this.Events={e203i2_client:["ENTER",!0],e213i1_client:["CANCEL",!0],e173i1_client:["'TOGGLE'",!1],e113i1_client:["LBLVEHICULOIDFILTER.CLICK",!1],e123i1_client:["LBLVEHICULODSCFILTER.CLICK",!1],e133i1_client:["LBLMARCAIDFILTER.CLICK",!1],e143i1_client:["LBLMODELOIDFILTER.CLICK",!1],e153i1_client:["LBLVEHICULOESTFILTER.CLICK",!1],e163i1_client:["LBLVEHICULOPLACAFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cVehiculoID",fld:"vCVEHICULOID",pic:"ZZZ9"},{av:"AV7cVehiculoDsc",fld:"vCVEHICULODSC",pic:""},{av:"AV8cMarcaID",fld:"vCMARCAID",pic:"ZZZ9"},{av:"AV9cModeloID",fld:"vCMODELOID",pic:"ZZZ9"},{av:"AV10cVehiculoEst",fld:"vCVEHICULOEST",pic:""},{av:"AV11cVehiculoPlaca",fld:"vCVEHICULOPLACA",pic:""},{av:"AV12pEmpID",fld:"vPEMPID",pic:"ZZZ9"}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLVEHICULOIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("VEHICULOIDFILTERCONTAINER","Class")',ctrl:"VEHICULOIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("VEHICULOIDFILTERCONTAINER","Class")',ctrl:"VEHICULOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCVEHICULOID","Visible")',ctrl:"vCVEHICULOID",prop:"Visible"}]];this.EvtParms["LBLVEHICULODSCFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("VEHICULODSCFILTERCONTAINER","Class")',ctrl:"VEHICULODSCFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("VEHICULODSCFILTERCONTAINER","Class")',ctrl:"VEHICULODSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCVEHICULODSC","Visible")',ctrl:"vCVEHICULODSC",prop:"Visible"}]];this.EvtParms["LBLMARCAIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MARCAIDFILTERCONTAINER","Class")',ctrl:"MARCAIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MARCAIDFILTERCONTAINER","Class")',ctrl:"MARCAIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMARCAID","Visible")',ctrl:"vCMARCAID",prop:"Visible"}]];this.EvtParms["LBLMODELOIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MODELOIDFILTERCONTAINER","Class")',ctrl:"MODELOIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MODELOIDFILTERCONTAINER","Class")',ctrl:"MODELOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMODELOID","Visible")',ctrl:"vCMODELOID",prop:"Visible"}]];this.EvtParms["LBLVEHICULOESTFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("VEHICULOESTFILTERCONTAINER","Class")',ctrl:"VEHICULOESTFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("VEHICULOESTFILTERCONTAINER","Class")',ctrl:"VEHICULOESTFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCVEHICULOEST","Visible")',ctrl:"vCVEHICULOEST",prop:"Visible"}]];this.EvtParms["LBLVEHICULOPLACAFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("VEHICULOPLACAFILTERCONTAINER","Class")',ctrl:"VEHICULOPLACAFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("VEHICULOPLACAFILTERCONTAINER","Class")',ctrl:"VEHICULOPLACAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCVEHICULOPLACA","Visible")',ctrl:"vCVEHICULOPLACA",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A8VehiculoID",fld:"VEHICULOID",pic:"ZZZ9",hsh:!0}],[{av:"AV13pVehiculoID",fld:"vPVEHICULOID",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cVehiculoID",fld:"vCVEHICULOID",pic:"ZZZ9"},{av:"AV7cVehiculoDsc",fld:"vCVEHICULODSC",pic:""},{av:"AV8cMarcaID",fld:"vCMARCAID",pic:"ZZZ9"},{av:"AV9cModeloID",fld:"vCMODELOID",pic:"ZZZ9"},{av:"AV10cVehiculoEst",fld:"vCVEHICULOEST",pic:""},{av:"AV11cVehiculoPlaca",fld:"vCVEHICULOPLACA",pic:""},{av:"AV12pEmpID",fld:"vPEMPID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cVehiculoID",fld:"vCVEHICULOID",pic:"ZZZ9"},{av:"AV7cVehiculoDsc",fld:"vCVEHICULODSC",pic:""},{av:"AV8cMarcaID",fld:"vCMARCAID",pic:"ZZZ9"},{av:"AV9cModeloID",fld:"vCMODELOID",pic:"ZZZ9"},{av:"AV10cVehiculoEst",fld:"vCVEHICULOEST",pic:""},{av:"AV11cVehiculoPlaca",fld:"vCVEHICULOPLACA",pic:""},{av:"AV12pEmpID",fld:"vPEMPID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cVehiculoID",fld:"vCVEHICULOID",pic:"ZZZ9"},{av:"AV7cVehiculoDsc",fld:"vCVEHICULODSC",pic:""},{av:"AV8cMarcaID",fld:"vCMARCAID",pic:"ZZZ9"},{av:"AV9cModeloID",fld:"vCMODELOID",pic:"ZZZ9"},{av:"AV10cVehiculoEst",fld:"vCVEHICULOEST",pic:""},{av:"AV11cVehiculoPlaca",fld:"vCVEHICULOPLACA",pic:""},{av:"AV12pEmpID",fld:"vPEMPID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cVehiculoID",fld:"vCVEHICULOID",pic:"ZZZ9"},{av:"AV7cVehiculoDsc",fld:"vCVEHICULODSC",pic:""},{av:"AV8cMarcaID",fld:"vCMARCAID",pic:"ZZZ9"},{av:"AV9cModeloID",fld:"vCMODELOID",pic:"ZZZ9"},{av:"AV10cVehiculoEst",fld:"vCVEHICULOEST",pic:""},{av:"AV11cVehiculoPlaca",fld:"vCVEHICULOPLACA",pic:""},{av:"AV12pEmpID",fld:"vPEMPID",pic:"ZZZ9"}],[]];this.setVCMap("AV12pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV13pVehiculoID","vPVEHICULOID",0,"int",4,0);this.setVCMap("AV12pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV12pEmpID","vPEMPID",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);t.addRefreshingVar(this.GXValidFnc[66]);t.addRefreshingVar({rfrVar:"AV12pEmpID"});this.Initialize()});gx.createParentObj(gx0081)