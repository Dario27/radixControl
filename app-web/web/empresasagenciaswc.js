/*!   GeneXus C# 15_0_12-126726 on 11/19/2022 22:52:56.2
*/
gx.evt.autoSkip=!1;gx.define("empresasagenciaswc",!0,function(n){var t,i;this.ServerClass="empresasagenciaswc";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV6EmpID=gx.fn.getIntegerValue("vEMPID",".");this.AV6EmpID=gx.fn.getIntegerValue("vEMPID",".")};this.e110d2_client=function(){return this.executeServerEvent("'DOINSERT'",!1,null,!1,!1)};this.e140d2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e150d2_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,18,19,21,22,23,24,25,26,27,28,29,30,31];this.GXLastCtrlId=31;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",20,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"empresasagenciaswc",[],!1,1,!1,!0,0,!0,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);i=this.GridContainer;i.addSingleLineEdit(2,21,"AGEID","ID","","AgeID","int",0,"px",4,4,"right",null,[],2,"AgeID",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(46,22,"AGEDSC","Dsc","","AgeDsc","char",0,"px",50,50,"left",null,[],46,"AgeDsc",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");i.addSingleLineEdit(47,23,"AGEEST","Est","","AgeEst","char",0,"px",1,1,"left",null,[],47,"AgeEst",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(48,24,"AGEDIR","Dir","","AgeDir","char",0,"px",100,80,"left",null,[],48,"AgeDir",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(49,25,"AGETELF","Telf","","AgeTelf","char",0,"px",20,20,"left",null,[],49,"AgeTelf",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addBitmap("&Update","vUPDATE",26,0,"px",17,"px",null,"","","WWOptionalColumn","WWActionColumn");i.addBitmap("&Delete","vDELETE",27,0,"px",17,"px",null,"","","ActionAttribute","WWActionColumn");this.GridContainer.emptyText="";this.setGrid(i);t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"TABLETOP",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[9]={id:9,fld:"",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,fld:"BTNINSERT",grid:0};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"GRIDCELL",grid:0};t[14]={id:14,fld:"GRIDTABLE",grid:0};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[18]={id:18,fld:"",grid:0};t[19]={id:19,fld:"",grid:0};t[21]={id:21,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"AGEID",gxz:"Z2AgeID",gxold:"O2AgeID",gxvar:"A2AgeID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A2AgeID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z2AgeID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("AGEID",n||gx.fn.currentGridRowImpl(20),gx.O.A2AgeID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A2AgeID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("AGEID",n||gx.fn.currentGridRowImpl(20),".")},nac:gx.falseFn};t[22]={id:22,lvl:2,type:"char",len:50,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"AGEDSC",gxz:"Z46AgeDsc",gxold:"O46AgeDsc",gxvar:"A46AgeDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A46AgeDsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z46AgeDsc=n)},v2c:function(n){gx.fn.setGridControlValue("AGEDSC",n||gx.fn.currentGridRowImpl(20),gx.O.A46AgeDsc,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A46AgeDsc=this.val())},val:function(n){return gx.fn.getGridControlValue("AGEDSC",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[23]={id:23,lvl:2,type:"char",len:1,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"AGEEST",gxz:"Z47AgeEst",gxold:"O47AgeEst",gxvar:"A47AgeEst",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A47AgeEst=n)},v2z:function(n){n!==undefined&&(gx.O.Z47AgeEst=n)},v2c:function(n){gx.fn.setGridControlValue("AGEEST",n||gx.fn.currentGridRowImpl(20),gx.O.A47AgeEst,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A47AgeEst=this.val())},val:function(n){return gx.fn.getGridControlValue("AGEEST",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[24]={id:24,lvl:2,type:"char",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"AGEDIR",gxz:"Z48AgeDir",gxold:"O48AgeDir",gxvar:"A48AgeDir",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A48AgeDir=n)},v2z:function(n){n!==undefined&&(gx.O.Z48AgeDir=n)},v2c:function(n){gx.fn.setGridControlValue("AGEDIR",n||gx.fn.currentGridRowImpl(20),gx.O.A48AgeDir,0)},c2v:function(){this.val()!==undefined&&(gx.O.A48AgeDir=this.val())},val:function(n){return gx.fn.getGridControlValue("AGEDIR",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[25]={id:25,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"AGETELF",gxz:"Z49AgeTelf",gxold:"O49AgeTelf",gxvar:"A49AgeTelf",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A49AgeTelf=n)},v2z:function(n){n!==undefined&&(gx.O.Z49AgeTelf=n)},v2c:function(n){gx.fn.setGridControlValue("AGETELF",n||gx.fn.currentGridRowImpl(20),gx.O.A49AgeTelf,0)},c2v:function(){this.val()!==undefined&&(gx.O.A49AgeTelf=this.val())},val:function(n){return gx.fn.getGridControlValue("AGETELF",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[26]={id:26,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV11Update",gxold:"OV11Update",gxvar:"AV11Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV11Update=n)},v2z:function(n){n!==undefined&&(gx.O.ZV11Update=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vUPDATE",n||gx.fn.currentGridRowImpl(20),gx.O.AV11Update,gx.O.AV17Update_GXI)},c2v:function(){gx.O.AV17Update_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV11Update=this.val())},val:function(n){return gx.fn.getGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(20))},val_GXI:function(n){return gx.fn.getGridControlValue("vUPDATE_GXI",n||gx.fn.currentGridRowImpl(20))},gxvar_GXI:"AV17Update_GXI",nac:gx.falseFn};t[27]={id:27,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV12Delete",gxold:"OV12Delete",gxvar:"AV12Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV12Delete=n)},v2z:function(n){n!==undefined&&(gx.O.ZV12Delete=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vDELETE",n||gx.fn.currentGridRowImpl(20),gx.O.AV12Delete,gx.O.AV18Delete_GXI)},c2v:function(){gx.O.AV18Delete_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV12Delete=this.val())},val:function(n){return gx.fn.getGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(20))},val_GXI:function(n){return gx.fn.getGridControlValue("vDELETE_GXI",n||gx.fn.currentGridRowImpl(20))},gxvar_GXI:"AV18Delete_GXI",nac:gx.falseFn};t[28]={id:28,fld:"",grid:0};t[29]={id:29,fld:"",grid:0};t[30]={id:30,fld:"",grid:0};t[31]={id:31,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EMPID",gxz:"Z1EmpID",gxold:"O1EmpID",gxvar:"A1EmpID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A1EmpID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1EmpID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("EMPID",gx.O.A1EmpID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A1EmpID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("EMPID",".")},nac:gx.falseFn};this.declareDomainHdlr(31,function(){});this.Z2AgeID=0;this.O2AgeID=0;this.Z46AgeDsc="";this.O46AgeDsc="";this.Z47AgeEst="";this.O47AgeEst="";this.Z48AgeDir="";this.O48AgeDir="";this.Z49AgeTelf="";this.O49AgeTelf="";this.ZV11Update="";this.OV11Update="";this.ZV12Delete="";this.OV12Delete="";this.A1EmpID=0;this.Z1EmpID=0;this.O1EmpID=0;this.A1EmpID=0;this.AV6EmpID=0;this.A2AgeID=0;this.A46AgeDsc="";this.A47AgeEst="";this.A48AgeDir="";this.A49AgeTelf="";this.AV11Update="";this.AV12Delete="";this.Events={e110d2_client:["'DOINSERT'",!0],e140d2_client:["ENTER",!0],e150d2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6EmpID",fld:"vEMPID",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"sPrefix"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"}],[]];this.EvtParms.START=[[{av:"AV16Pgmname",fld:"vPGMNAME",pic:""},{av:"AV6EmpID",fld:"vEMPID",pic:"ZZZ9"}],[{ctrl:"GRID",prop:"Rows"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:'gx.fn.getCtrlProperty("EMPID","Visible")',ctrl:"EMPID",prop:"Visible"}]];this.EvtParms["GRID.LOAD"]=[[{av:"AV6EmpID",fld:"vEMPID",pic:"ZZZ9"},{av:"A2AgeID",fld:"AGEID",pic:"ZZZ9",hsh:!0},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"}],[{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:"vUPDATE",prop:"Link"},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:"vDELETE",prop:"Link"},{av:'gx.fn.getCtrlProperty("AGEDSC","Link")',ctrl:"AGEDSC",prop:"Link"}]];this.EvtParms["'DOINSERT'"]=[[{av:"AV6EmpID",fld:"vEMPID",pic:"ZZZ9"},{av:"A2AgeID",fld:"AGEID",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms.GRID_FIRSTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6EmpID",fld:"vEMPID",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.EvtParms.GRID_PREVPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6EmpID",fld:"vEMPID",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.EvtParms.GRID_NEXTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6EmpID",fld:"vEMPID",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.EvtParms.GRID_LASTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6EmpID",fld:"vEMPID",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.setVCMap("AV6EmpID","vEMPID",0,"int",4,0);this.setVCMap("AV6EmpID","vEMPID",0,"int",4,0);this.setVCMap("AV6EmpID","vEMPID",0,"int",4,0);i.addRefreshingVar({rfrVar:"AV6EmpID"});i.addRefreshingVar({rfrVar:"AV11Update",rfrProp:"Value",gxAttId:"Update"});i.addRefreshingVar({rfrVar:"AV11Update",rfrProp:"Tooltiptext",gxAttId:"Update"});i.addRefreshingVar({rfrVar:"AV12Delete",rfrProp:"Value",gxAttId:"Delete"});i.addRefreshingVar({rfrVar:"AV12Delete",rfrProp:"Tooltiptext",gxAttId:"Delete"});i.addRefreshingVar(this.GXValidFnc[31]);this.Initialize()})