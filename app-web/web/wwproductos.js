/*!   GeneXus C# 15_0_12-126726 on 10/29/2022 1:8:44.10
*/
gx.evt.autoSkip=!1;gx.define("wwproductos",!1,function(){var n,t;this.ServerClass="wwproductos";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV24Pgmname=gx.fn.getControlValue("vPGMNAME");this.AV17empId=gx.fn.getIntegerValue("vEMPID",".");this.AV18ageID=gx.fn.getIntegerValue("vAGEID",".");this.AV21prodPre=gx.fn.getIntegerValue("vPRODPRE",".");this.AV19usuCod=gx.fn.getControlValue("vUSUCOD");this.AV17empId=gx.fn.getIntegerValue("vEMPID",".");this.AV18ageID=gx.fn.getIntegerValue("vAGEID",".");this.AV24Pgmname=gx.fn.getControlValue("vPGMNAME")};this.e114d2_client=function(){return this.executeServerEvent("'DOINSERT'",!1,null,!1,!1)};this.e154d2_client=function(){return this.executeServerEvent("'PRECIOPRDUCTOS'",!0,arguments[0],!1,!1)};this.e164d2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e174d2_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,23,24,26,27,28,29,30,31,32,33];this.GXLastCtrlId=33;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",25,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"wwproductos",[],!1,1,!0,!1,0,!0,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.GridContainer;t.addSingleLineEdit(286,26,"PRDCOD","ID","","PrdCod","int",85,"px",4,4,"right",null,[],286,"PrdCod",!0,0,!1,!1,"Attribute",1,"WWActionColumn");t.addSingleLineEdit(309,27,"PRDNOMBRE","Articulo/Producto","","prdNombre","svchar",0,"px",80,80,"left",null,[],309,"prdNombre",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addComboBox(31,28,"TIPOPRODID","Tipo","tipoProdID","int",null,0,!0,!1,0,"px","WWColumn WWOptionalColumn");t.addComboBox(288,29,"PRDPRES","Presentacion","PrdPres","int",null,0,!0,!1,0,"px","WWColumn WWOptionalColumn");t.addSingleLineEdit(289,30,"PRDESTADO","Estado","","PrdEstado","char",0,"px",1,1,"left",null,[],289,"PrdEstado",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addBitmap("&Update","vUPDATE",31,0,"px",17,"px",null,"","","ImageAttribute","WWActionColumn");t.addBitmap("&Precioprd","vPRECIOPRD",32,0,"px",17,"px","e154d2_client","","","ImageAttribute","WWActionColumn");t.addBitmap("&Delete","vDELETE",33,0,"px",17,"px",null,"","","ImageAttribute","WWActionColumn");this.GridContainer.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLETOP",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TITLETEXT",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"",grid:0};n[13]={id:13,fld:"BTNINSERT",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"svchar",len:80,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vPRDDESCP",gxz:"ZV13PrdDescp",gxold:"OV13PrdDescp",gxvar:"AV13PrdDescp",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV13PrdDescp=n)},v2z:function(n){n!==undefined&&(gx.O.ZV13PrdDescp=n)},v2c:function(){gx.fn.setControlValue("vPRDDESCP",gx.O.AV13PrdDescp,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV13PrdDescp=this.val())},val:function(){return gx.fn.getControlValue("vPRDDESCP")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"GRIDCELL",grid:0};n[19]={id:19,fld:"GRIDTABLE",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[26]={id:26,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PRDCOD",gxz:"Z286PrdCod",gxold:"O286PrdCod",gxvar:"A286PrdCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A286PrdCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z286PrdCod=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("PRDCOD",n||gx.fn.currentGridRowImpl(25),gx.O.A286PrdCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A286PrdCod=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("PRDCOD",n||gx.fn.currentGridRowImpl(25),".")},nac:gx.falseFn};n[27]={id:27,lvl:2,type:"svchar",len:80,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PRDNOMBRE",gxz:"Z309prdNombre",gxold:"O309prdNombre",gxvar:"A309prdNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A309prdNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z309prdNombre=n)},v2c:function(n){gx.fn.setGridControlValue("PRDNOMBRE",n||gx.fn.currentGridRowImpl(25),gx.O.A309prdNombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.A309prdNombre=this.val())},val:function(n){return gx.fn.getGridControlValue("PRDNOMBRE",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[28]={id:28,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"TIPOPRODID",gxz:"Z31tipoProdID",gxold:"O31tipoProdID",gxvar:"A31tipoProdID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"dyncombo",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A31tipoProdID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z31tipoProdID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridComboBoxValue("TIPOPRODID",n||gx.fn.currentGridRowImpl(25),gx.O.A31tipoProdID);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A31tipoProdID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("TIPOPRODID",n||gx.fn.currentGridRowImpl(25),".")},nac:gx.falseFn};n[29]={id:29,lvl:2,type:"int",len:2,dec:0,sign:!1,pic:"Z9",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PRDPRES",gxz:"Z288PrdPres",gxold:"O288PrdPres",gxvar:"A288PrdPres",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A288PrdPres=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z288PrdPres=gx.num.intval(n))},v2c:function(n){gx.fn.setGridComboBoxValue("PRDPRES",n||gx.fn.currentGridRowImpl(25),gx.O.A288PrdPres)},c2v:function(){this.val()!==undefined&&(gx.O.A288PrdPres=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("PRDPRES",n||gx.fn.currentGridRowImpl(25),".")},nac:gx.falseFn};n[30]={id:30,lvl:2,type:"char",len:1,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PRDESTADO",gxz:"Z289PrdEstado",gxold:"O289PrdEstado",gxvar:"A289PrdEstado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A289PrdEstado=n)},v2z:function(n){n!==undefined&&(gx.O.Z289PrdEstado=n)},v2c:function(n){gx.fn.setGridControlValue("PRDESTADO",n||gx.fn.currentGridRowImpl(25),gx.O.A289PrdEstado,0)},c2v:function(){this.val()!==undefined&&(gx.O.A289PrdEstado=this.val())},val:function(n){return gx.fn.getGridControlValue("PRDESTADO",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[31]={id:31,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV14Update",gxold:"OV14Update",gxvar:"AV14Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV14Update=n)},v2z:function(n){n!==undefined&&(gx.O.ZV14Update=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vUPDATE",n||gx.fn.currentGridRowImpl(25),gx.O.AV14Update,gx.O.AV25Update_GXI)},c2v:function(){gx.O.AV25Update_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV14Update=this.val())},val:function(n){return gx.fn.getGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(25))},val_GXI:function(n){return gx.fn.getGridControlValue("vUPDATE_GXI",n||gx.fn.currentGridRowImpl(25))},gxvar_GXI:"AV25Update_GXI",nac:gx.falseFn};n[32]={id:32,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vPRECIOPRD",gxz:"ZV20precioPrd",gxold:"OV20precioPrd",gxvar:"AV20precioPrd",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV20precioPrd=n)},v2z:function(n){n!==undefined&&(gx.O.ZV20precioPrd=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vPRECIOPRD",n||gx.fn.currentGridRowImpl(25),gx.O.AV20precioPrd,gx.O.AV27Precioprd_GXI)},c2v:function(){gx.O.AV27Precioprd_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV20precioPrd=this.val())},val:function(n){return gx.fn.getGridControlValue("vPRECIOPRD",n||gx.fn.currentGridRowImpl(25))},val_GXI:function(n){return gx.fn.getGridControlValue("vPRECIOPRD_GXI",n||gx.fn.currentGridRowImpl(25))},gxvar_GXI:"AV27Precioprd_GXI",nac:gx.falseFn,evt:"e154d2_client"};n[33]={id:33,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV15Delete",gxold:"OV15Delete",gxvar:"AV15Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV15Delete=n)},v2z:function(n){n!==undefined&&(gx.O.ZV15Delete=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vDELETE",n||gx.fn.currentGridRowImpl(25),gx.O.AV15Delete,gx.O.AV26Delete_GXI)},c2v:function(){gx.O.AV26Delete_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV15Delete=this.val())},val:function(n){return gx.fn.getGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(25))},val_GXI:function(n){return gx.fn.getGridControlValue("vDELETE_GXI",n||gx.fn.currentGridRowImpl(25))},gxvar_GXI:"AV26Delete_GXI",nac:gx.falseFn};this.AV13PrdDescp="";this.ZV13PrdDescp="";this.OV13PrdDescp="";this.Z286PrdCod=0;this.O286PrdCod=0;this.Z309prdNombre="";this.O309prdNombre="";this.Z31tipoProdID=0;this.O31tipoProdID=0;this.Z288PrdPres=0;this.O288PrdPres=0;this.Z289PrdEstado="";this.O289PrdEstado="";this.ZV14Update="";this.OV14Update="";this.ZV20precioPrd="";this.OV20precioPrd="";this.ZV15Delete="";this.OV15Delete="";this.AV13PrdDescp="";this.AV17empId=0;this.AV18ageID=0;this.AV19usuCod="";this.A1EmpID=0;this.A2AgeID=0;this.A286PrdCod=0;this.A309prdNombre="";this.A31tipoProdID=0;this.A288PrdPres=0;this.A289PrdEstado="";this.AV14Update="";this.AV20precioPrd="";this.AV15Delete="";this.AV24Pgmname="";this.AV21prodPre=0;this.Events={e114d2_client:["'DOINSERT'",!0],e154d2_client:["'PRECIOPRDUCTOS'",!0],e164d2_client:["ENTER",!0],e174d2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"AV20precioPrd",fld:"vPRECIOPRD",pic:""},{av:'gx.fn.getCtrlProperty("vPRECIOPRD","Tooltiptext")',ctrl:"vPRECIOPRD",prop:"Tooltiptext"},{av:"AV24Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13PrdDescp",fld:"vPRDDESCP",pic:""},{av:"AV17empId",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{av:"AV18ageID",fld:"vAGEID",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms.START=[[{av:"AV24Pgmname",fld:"vPGMNAME",pic:""}],[{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{ctrl:"FORM",prop:"Caption"},{av:"AV20precioPrd",fld:"vPRECIOPRD",pic:""},{av:'gx.fn.getCtrlProperty("vPRECIOPRD","Tooltiptext")',ctrl:"vPRECIOPRD",prop:"Tooltiptext"},{av:"AV13PrdDescp",fld:"vPRDDESCP",pic:""}]];this.EvtParms["GRID.LOAD"]=[[{av:"AV17empId",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{av:"AV18ageID",fld:"vAGEID",pic:"ZZZ9",hsh:!0},{av:"A286PrdCod",fld:"PRDCOD",pic:"ZZZ9",hsh:!0}],[{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:"vUPDATE",prop:"Link"},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:"vDELETE",prop:"Link"}]];this.EvtParms["'DOINSERT'"]=[[{av:"AV17empId",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{av:"AV18ageID",fld:"vAGEID",pic:"ZZZ9",hsh:!0},{av:"A286PrdCod",fld:"PRDCOD",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms["'PRECIOPRDUCTOS'"]=[[{av:"AV21prodPre",fld:"vPRODPRE",pic:"ZZZ9"},{av:"AV17empId",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{av:"AV18ageID",fld:"vAGEID",pic:"ZZZ9",hsh:!0},{av:"A286PrdCod",fld:"PRDCOD",pic:"ZZZ9",hsh:!0}],[{av:'gx.fn.getCtrlProperty("vPRECIOPRD","Link")',ctrl:"vPRECIOPRD",prop:"Link"}]];this.EvtParms.GRID_FIRSTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV17empId",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{av:"AV18ageID",fld:"vAGEID",pic:"ZZZ9",hsh:!0},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"AV20precioPrd",fld:"vPRECIOPRD",pic:""},{av:'gx.fn.getCtrlProperty("vPRECIOPRD","Tooltiptext")',ctrl:"vPRECIOPRD",prop:"Tooltiptext"},{av:"AV24Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13PrdDescp",fld:"vPRDDESCP",pic:""}],[]];this.EvtParms.GRID_PREVPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV17empId",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{av:"AV18ageID",fld:"vAGEID",pic:"ZZZ9",hsh:!0},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"AV20precioPrd",fld:"vPRECIOPRD",pic:""},{av:'gx.fn.getCtrlProperty("vPRECIOPRD","Tooltiptext")',ctrl:"vPRECIOPRD",prop:"Tooltiptext"},{av:"AV24Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13PrdDescp",fld:"vPRDDESCP",pic:""}],[]];this.EvtParms.GRID_NEXTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV17empId",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{av:"AV18ageID",fld:"vAGEID",pic:"ZZZ9",hsh:!0},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"AV20precioPrd",fld:"vPRECIOPRD",pic:""},{av:'gx.fn.getCtrlProperty("vPRECIOPRD","Tooltiptext")',ctrl:"vPRECIOPRD",prop:"Tooltiptext"},{av:"AV24Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13PrdDescp",fld:"vPRDDESCP",pic:""}],[]];this.EvtParms.GRID_LASTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV17empId",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{av:"AV18ageID",fld:"vAGEID",pic:"ZZZ9",hsh:!0},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"AV20precioPrd",fld:"vPRECIOPRD",pic:""},{av:'gx.fn.getCtrlProperty("vPRECIOPRD","Tooltiptext")',ctrl:"vPRECIOPRD",prop:"Tooltiptext"},{av:"AV24Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13PrdDescp",fld:"vPRDDESCP",pic:""}],[]];this.setVCMap("AV24Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("AV17empId","vEMPID",0,"int",4,0);this.setVCMap("AV18ageID","vAGEID",0,"int",4,0);this.setVCMap("AV21prodPre","vPRODPRE",0,"int",4,0);this.setVCMap("AV19usuCod","vUSUCOD",0,"char",15,0);this.setVCMap("AV17empId","vEMPID",0,"int",4,0);this.setVCMap("AV18ageID","vAGEID",0,"int",4,0);this.setVCMap("AV24Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("AV17empId","vEMPID",0,"int",4,0);this.setVCMap("AV18ageID","vAGEID",0,"int",4,0);this.setVCMap("AV24Pgmname","vPGMNAME",0,"char",129,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar({rfrVar:"AV17empId"});t.addRefreshingVar({rfrVar:"AV18ageID"});t.addRefreshingVar({rfrVar:"AV24Pgmname"});t.addRefreshingVar({rfrVar:"AV14Update",rfrProp:"Value",gxAttId:"Update"});t.addRefreshingVar({rfrVar:"AV14Update",rfrProp:"Tooltiptext",gxAttId:"Update"});t.addRefreshingVar({rfrVar:"AV15Delete",rfrProp:"Value",gxAttId:"Delete"});t.addRefreshingVar({rfrVar:"AV15Delete",rfrProp:"Tooltiptext",gxAttId:"Delete"});t.addRefreshingVar({rfrVar:"AV20precioPrd",rfrProp:"Value",gxAttId:"Precioprd"});t.addRefreshingVar({rfrVar:"AV20precioPrd",rfrProp:"Tooltiptext",gxAttId:"Precioprd"});this.Initialize()});gx.createParentObj(wwproductos)