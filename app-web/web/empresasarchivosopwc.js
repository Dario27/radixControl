/*!   GeneXus C# 15_0_12-126726 on 10/26/2022 20:13:31.57
*/
gx.evt.autoSkip=!1;gx.define("empresasarchivosopwc",!0,function(n){var t,i;this.ServerClass="empresasarchivosopwc";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV6EmpID=gx.fn.getIntegerValue("vEMPID",".");this.AV6EmpID=gx.fn.getIntegerValue("vEMPID",".")};this.e110l2_client=function(){return this.executeServerEvent("'DOINSERT'",!1,null,!1,!1)};this.e140l2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e150l2_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,18,19,21,22,23,24,25,26,27,28,29,30,31,32];this.GXLastCtrlId=32;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",20,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"empresasarchivosopwc",[],!1,1,!1,!0,0,!0,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);i=this.GridContainer;i.addSingleLineEdit(27,21,"ARCHSEC","Sec","","ArchSec","int",0,"px",4,4,"right",null,[],27,"ArchSec",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(22,22,"ORDENID","Nro. Orden","","OrdenID","int",0,"px",4,4,"right",null,[],22,"OrdenID",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(28,23,"ARCHCLIENTEID","Cliente ID","","ArchClienteID","int",0,"px",4,4,"right",null,[],28,"ArchClienteID",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addBlob(134,24,"ARCHURL","Url","ArchUrl","bitstr",0,60,0,"px","px",!0,!1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(135,25,"ARCHUSER","Vendedor","","ArchUser","char",0,"px",40,40,"left",null,[],135,"ArchUser",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");i.addSingleLineEdit(137,26,"ARCHNAME","Archivo","","ArchName","char",0,"px",40,40,"left",null,[],137,"ArchName",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addBitmap("&Update","vUPDATE",27,0,"px",17,"px",null,"","","WWOptionalColumn","WWActionColumn");i.addBitmap("&Delete","vDELETE",28,0,"px",17,"px",null,"","","ActionAttribute","WWActionColumn");this.GridContainer.emptyText="";this.setGrid(i);t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"TABLETOP",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[9]={id:9,fld:"",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,fld:"BTNINSERT",grid:0};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"GRIDCELL",grid:0};t[14]={id:14,fld:"GRIDTABLE",grid:0};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[18]={id:18,fld:"",grid:0};t[19]={id:19,fld:"",grid:0};t[21]={id:21,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ARCHSEC",gxz:"Z27ArchSec",gxold:"O27ArchSec",gxvar:"A27ArchSec",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A27ArchSec=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z27ArchSec=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ARCHSEC",n||gx.fn.currentGridRowImpl(20),gx.O.A27ArchSec,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A27ArchSec=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ARCHSEC",n||gx.fn.currentGridRowImpl(20),".")},nac:gx.falseFn};t[22]={id:22,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ORDENID",gxz:"Z22OrdenID",gxold:"O22OrdenID",gxvar:"A22OrdenID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A22OrdenID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z22OrdenID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ORDENID",n||gx.fn.currentGridRowImpl(20),gx.O.A22OrdenID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A22OrdenID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ORDENID",n||gx.fn.currentGridRowImpl(20),".")},nac:gx.falseFn};t[23]={id:23,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ARCHCLIENTEID",gxz:"Z28ArchClienteID",gxold:"O28ArchClienteID",gxvar:"A28ArchClienteID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A28ArchClienteID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z28ArchClienteID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ARCHCLIENTEID",n||gx.fn.currentGridRowImpl(20),gx.O.A28ArchClienteID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A28ArchClienteID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ARCHCLIENTEID",n||gx.fn.currentGridRowImpl(20),".")},nac:gx.falseFn};t[24]={id:24,lvl:2,type:"bitstr",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ARCHURL",gxz:"Z134ArchUrl",gxold:"O134ArchUrl",gxvar:"A134ArchUrl",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A134ArchUrl=n)},v2z:function(n){n!==undefined&&(gx.O.Z134ArchUrl=n)},v2c:function(n){gx.fn.setGridControlValue("ARCHURL",n||gx.fn.currentGridRowImpl(20),gx.O.A134ArchUrl,0)},c2v:function(){this.val()!==undefined&&(gx.O.A134ArchUrl=this.val())},val:function(n){return gx.fn.getGridControlValue("ARCHURL",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[25]={id:25,lvl:2,type:"char",len:40,dec:0,sign:!1,pic:"@!",ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ARCHUSER",gxz:"Z135ArchUser",gxold:"O135ArchUser",gxvar:"A135ArchUser",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A135ArchUser=n)},v2z:function(n){n!==undefined&&(gx.O.Z135ArchUser=n)},v2c:function(n){gx.fn.setGridControlValue("ARCHUSER",n||gx.fn.currentGridRowImpl(20),gx.O.A135ArchUser,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A135ArchUser=this.val())},val:function(n){return gx.fn.getGridControlValue("ARCHUSER",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[26]={id:26,lvl:2,type:"char",len:40,dec:0,sign:!1,pic:"@!",ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ARCHNAME",gxz:"Z137ArchName",gxold:"O137ArchName",gxvar:"A137ArchName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A137ArchName=n)},v2z:function(n){n!==undefined&&(gx.O.Z137ArchName=n)},v2c:function(n){gx.fn.setGridControlValue("ARCHNAME",n||gx.fn.currentGridRowImpl(20),gx.O.A137ArchName,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A137ArchName=this.val())},val:function(n){return gx.fn.getGridControlValue("ARCHNAME",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[27]={id:27,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV11Update",gxold:"OV11Update",gxvar:"AV11Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV11Update=n)},v2z:function(n){n!==undefined&&(gx.O.ZV11Update=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vUPDATE",n||gx.fn.currentGridRowImpl(20),gx.O.AV11Update,gx.O.AV17Update_GXI)},c2v:function(){gx.O.AV17Update_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV11Update=this.val())},val:function(n){return gx.fn.getGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(20))},val_GXI:function(n){return gx.fn.getGridControlValue("vUPDATE_GXI",n||gx.fn.currentGridRowImpl(20))},gxvar_GXI:"AV17Update_GXI",nac:gx.falseFn};t[28]={id:28,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV12Delete",gxold:"OV12Delete",gxvar:"AV12Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV12Delete=n)},v2z:function(n){n!==undefined&&(gx.O.ZV12Delete=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vDELETE",n||gx.fn.currentGridRowImpl(20),gx.O.AV12Delete,gx.O.AV18Delete_GXI)},c2v:function(){gx.O.AV18Delete_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV12Delete=this.val())},val:function(n){return gx.fn.getGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(20))},val_GXI:function(n){return gx.fn.getGridControlValue("vDELETE_GXI",n||gx.fn.currentGridRowImpl(20))},gxvar_GXI:"AV18Delete_GXI",nac:gx.falseFn};t[29]={id:29,fld:"",grid:0};t[30]={id:30,fld:"",grid:0};t[31]={id:31,fld:"",grid:0};t[32]={id:32,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EMPID",gxz:"Z1EmpID",gxold:"O1EmpID",gxvar:"A1EmpID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A1EmpID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1EmpID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("EMPID",gx.O.A1EmpID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A1EmpID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("EMPID",".")},nac:gx.falseFn};this.declareDomainHdlr(32,function(){});this.Z27ArchSec=0;this.O27ArchSec=0;this.Z22OrdenID=0;this.O22OrdenID=0;this.Z28ArchClienteID=0;this.O28ArchClienteID=0;this.Z134ArchUrl="";this.O134ArchUrl="";this.Z135ArchUser="";this.O135ArchUser="";this.Z137ArchName="";this.O137ArchName="";this.ZV11Update="";this.OV11Update="";this.ZV12Delete="";this.OV12Delete="";this.A1EmpID=0;this.Z1EmpID=0;this.O1EmpID=0;this.A1EmpID=0;this.AV6EmpID=0;this.A27ArchSec=0;this.A22OrdenID=0;this.A28ArchClienteID=0;this.A134ArchUrl="";this.A135ArchUser="";this.A137ArchName="";this.AV11Update="";this.AV12Delete="";this.Events={e110l2_client:["'DOINSERT'",!0],e140l2_client:["ENTER",!0],e150l2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6EmpID",fld:"vEMPID",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"sPrefix"}],[]];this.EvtParms.START=[[{av:"AV16Pgmname",fld:"vPGMNAME",pic:""},{av:"AV6EmpID",fld:"vEMPID",pic:"ZZZ9"}],[{ctrl:"GRID",prop:"Rows"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:'gx.fn.getCtrlProperty("EMPID","Visible")',ctrl:"EMPID",prop:"Visible"}]];this.EvtParms["GRID.LOAD"]=[[{av:"A27ArchSec",fld:"ARCHSEC",pic:"ZZZ9",hsh:!0},{av:"A22OrdenID",fld:"ORDENID",pic:"ZZZ9",hsh:!0},{av:"A28ArchClienteID",fld:"ARCHCLIENTEID",pic:"ZZZ9",hsh:!0}],[{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:"vUPDATE",prop:"Link"},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:"vDELETE",prop:"Link"}]];this.EvtParms["'DOINSERT'"]=[[{av:"A27ArchSec",fld:"ARCHSEC",pic:"ZZZ9",hsh:!0},{av:"A22OrdenID",fld:"ORDENID",pic:"ZZZ9",hsh:!0},{av:"A28ArchClienteID",fld:"ARCHCLIENTEID",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms.GRID_FIRSTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6EmpID",fld:"vEMPID",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"sPrefix"}],[]];this.EvtParms.GRID_PREVPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6EmpID",fld:"vEMPID",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"sPrefix"}],[]];this.EvtParms.GRID_NEXTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6EmpID",fld:"vEMPID",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"sPrefix"}],[]];this.EvtParms.GRID_LASTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6EmpID",fld:"vEMPID",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"sPrefix"}],[]];this.setVCMap("AV6EmpID","vEMPID",0,"int",4,0);this.setVCMap("AV6EmpID","vEMPID",0,"int",4,0);this.setVCMap("AV6EmpID","vEMPID",0,"int",4,0);i.addRefreshingVar({rfrVar:"AV6EmpID"});i.addRefreshingVar({rfrVar:"AV11Update",rfrProp:"Value",gxAttId:"Update"});i.addRefreshingVar({rfrVar:"AV11Update",rfrProp:"Tooltiptext",gxAttId:"Update"});i.addRefreshingVar({rfrVar:"AV12Delete",rfrProp:"Value",gxAttId:"Delete"});i.addRefreshingVar({rfrVar:"AV12Delete",rfrProp:"Tooltiptext",gxAttId:"Delete"});this.Initialize()})