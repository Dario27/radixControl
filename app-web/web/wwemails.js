/*!   GeneXus C# 15_0_12-126726 on 1/11/2023 0:43:55.26
*/
gx.evt.autoSkip=!1;gx.define("wwemails",!1,function(){var n,t;this.ServerClass="wwemails";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV19Pgmname=gx.fn.getControlValue("vPGMNAME");this.AV19Pgmname=gx.fn.getControlValue("vPGMNAME")};this.Validv_Emailreg=function(){try{var n=gx.util.balloon.getNew("vEMAILREG");if(this.AnyError=0,!(new gx.date.gxdate("").compare(this.AV13emailReg)==0||new gx.date.gxdate(this.AV13emailReg).compare(gx.date.ymdtod(1753,01,01))>=0))try{n.setError("Campo email Reg fuera de rango");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Usucod=function(){try{if(gx.fn.currentGridRowImpl(25)===0)return!0;var n=gx.util.balloon.getNew("USUCOD",gx.fn.currentGridRowImpl(25));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e111o2_client=function(){return this.executeServerEvent("'DOINSERT'",!1,null,!1,!1)};this.e151o2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e161o2_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,23,24,26,27,28,29,30,31,32];this.GXLastCtrlId=32;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",25,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"wwemails",[],!1,1,!1,!0,0,!0,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.GridContainer;t.addSingleLineEdit(3,26,"USUCOD","Nombre de Usuario","","UsuCod","char",0,"px",15,15,"left",null,[],3,"UsuCod",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(50,27,"USUNAME","Usu Name","","UsuName","svchar",0,"px",40,40,"left",null,[],50,"UsuName",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(139,28,"EMAILREG","Reg","","emailReg","date",0,"px",8,8,"right",null,[],139,"emailReg",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(143,29,"EMAILULTNRO","Nro","","emailUltNro","int",0,"px",4,4,"right",null,[],143,"emailUltNro",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(29,30,"EMAILID","ID","","emailID","int",0,"px",4,4,"right",null,[],29,"emailID",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addBitmap("&Update","vUPDATE",31,0,"px",17,"px",null,"","","ImageAttribute","WWActionColumn");t.addBitmap("&Delete","vDELETE",32,0,"px",17,"px",null,"","","ImageAttribute","WWActionColumn");this.GridContainer.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLETOP",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TITLETEXT",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"",grid:0};n[13]={id:13,fld:"BTNINSERT",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"date",len:8,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Emailreg,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vEMAILREG",gxz:"ZV13emailReg",gxold:"OV13emailReg",gxvar:"AV13emailReg",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/99",dec:0},ucs:[],op:[16],ip:[16],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV13emailReg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV13emailReg=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vEMAILREG",gx.O.AV13emailReg,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV13emailReg=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("vEMAILREG")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"GRIDCELL",grid:0};n[19]={id:19,fld:"GRIDTABLE",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[26]={id:26,lvl:2,type:"char",len:15,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:this.Valid_Usucod,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUCOD",gxz:"Z3UsuCod",gxold:"O3UsuCod",gxvar:"A3UsuCod",ucs:[],op:[27],ip:[27,26],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A3UsuCod=n)},v2z:function(n){n!==undefined&&(gx.O.Z3UsuCod=n)},v2c:function(n){gx.fn.setGridControlValue("USUCOD",n||gx.fn.currentGridRowImpl(25),gx.O.A3UsuCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A3UsuCod=this.val())},val:function(n){return gx.fn.getGridControlValue("USUCOD",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[27]={id:27,lvl:2,type:"svchar",len:40,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUNAME",gxz:"Z50UsuName",gxold:"O50UsuName",gxvar:"A50UsuName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A50UsuName=n)},v2z:function(n){n!==undefined&&(gx.O.Z50UsuName=n)},v2c:function(n){gx.fn.setGridControlValue("USUNAME",n||gx.fn.currentGridRowImpl(25),gx.O.A50UsuName,0)},c2v:function(){this.val()!==undefined&&(gx.O.A50UsuName=this.val())},val:function(n){return gx.fn.getGridControlValue("USUNAME",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[28]={id:28,lvl:2,type:"date",len:8,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EMAILREG",gxz:"Z139emailReg",gxold:"O139emailReg",gxvar:"A139emailReg",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A139emailReg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z139emailReg=gx.fn.toDatetimeValue(n))},v2c:function(n){gx.fn.setGridControlValue("EMAILREG",n||gx.fn.currentGridRowImpl(25),gx.O.A139emailReg,0)},c2v:function(){this.val()!==undefined&&(gx.O.A139emailReg=gx.fn.toDatetimeValue(this.val()))},val:function(n){return gx.fn.getGridDateTimeValue("EMAILREG",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[29]={id:29,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EMAILULTNRO",gxz:"Z143emailUltNro",gxold:"O143emailUltNro",gxvar:"A143emailUltNro",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A143emailUltNro=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z143emailUltNro=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("EMAILULTNRO",n||gx.fn.currentGridRowImpl(25),gx.O.A143emailUltNro,0)},c2v:function(){this.val()!==undefined&&(gx.O.A143emailUltNro=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("EMAILULTNRO",n||gx.fn.currentGridRowImpl(25),".")},nac:gx.falseFn};n[30]={id:30,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EMAILID",gxz:"Z29emailID",gxold:"O29emailID",gxvar:"A29emailID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A29emailID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z29emailID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("EMAILID",n||gx.fn.currentGridRowImpl(25),gx.O.A29emailID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A29emailID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("EMAILID",n||gx.fn.currentGridRowImpl(25),".")},nac:gx.falseFn};n[31]={id:31,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV14Update",gxold:"OV14Update",gxvar:"AV14Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV14Update=n)},v2z:function(n){n!==undefined&&(gx.O.ZV14Update=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vUPDATE",n||gx.fn.currentGridRowImpl(25),gx.O.AV14Update,gx.O.A40000Update_GXI)},c2v:function(){gx.O.A40000Update_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV14Update=this.val())},val:function(n){return gx.fn.getGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(25))},val_GXI:function(n){return gx.fn.getGridControlValue("UPDATE_GXI",n||gx.fn.currentGridRowImpl(25))},gxvar_GXI:"A40000Update_GXI",nac:gx.falseFn};n[32]={id:32,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV15Delete",gxold:"OV15Delete",gxvar:"AV15Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV15Delete=n)},v2z:function(n){n!==undefined&&(gx.O.ZV15Delete=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vDELETE",n||gx.fn.currentGridRowImpl(25),gx.O.AV15Delete,gx.O.A40001Delete_GXI)},c2v:function(){gx.O.A40001Delete_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV15Delete=this.val())},val:function(n){return gx.fn.getGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(25))},val_GXI:function(n){return gx.fn.getGridControlValue("DELETE_GXI",n||gx.fn.currentGridRowImpl(25))},gxvar_GXI:"A40001Delete_GXI",nac:gx.falseFn};this.AV13emailReg=gx.date.nullDate();this.ZV13emailReg=gx.date.nullDate();this.OV13emailReg=gx.date.nullDate();this.Z3UsuCod="";this.O3UsuCod="";this.Z50UsuName="";this.O50UsuName="";this.Z139emailReg=gx.date.nullDate();this.O139emailReg=gx.date.nullDate();this.Z143emailUltNro=0;this.O143emailUltNro=0;this.Z29emailID=0;this.O29emailID=0;this.ZV14Update="";this.OV14Update="";this.ZV15Delete="";this.OV15Delete="";this.AV13emailReg=gx.date.nullDate();this.A3UsuCod="";this.A50UsuName="";this.A139emailReg=gx.date.nullDate();this.A143emailUltNro=0;this.A29emailID=0;this.AV14Update="";this.AV15Delete="";this.AV19Pgmname="";this.Events={e111o2_client:["'DOINSERT'",!0],e151o2_client:["ENTER",!0],e161o2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:"AV19Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13emailReg",fld:"vEMAILREG",pic:""}],[]];this.EvtParms.START=[[{av:"AV19Pgmname",fld:"vPGMNAME",pic:""}],[{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{ctrl:"FORM",prop:"Caption"},{av:"AV13emailReg",fld:"vEMAILREG",pic:""}]];this.EvtParms["GRID.LOAD"]=[[{av:"A29emailID",fld:"EMAILID",pic:"ZZZ9",hsh:!0},{av:"A3UsuCod",fld:"USUCOD",pic:"",hsh:!0}],[{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:"vUPDATE",prop:"Link"},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:"vDELETE",prop:"Link"}]];this.EvtParms["'DOINSERT'"]=[[{av:"A29emailID",fld:"EMAILID",pic:"ZZZ9",hsh:!0},{av:"A3UsuCod",fld:"USUCOD",pic:"",hsh:!0}],[]];this.EvtParms.GRID_FIRSTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:"AV19Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13emailReg",fld:"vEMAILREG",pic:""}],[]];this.EvtParms.GRID_PREVPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:"AV19Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13emailReg",fld:"vEMAILREG",pic:""}],[]];this.EvtParms.GRID_NEXTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:"AV19Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13emailReg",fld:"vEMAILREG",pic:""}],[]];this.EvtParms.GRID_LASTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:"AV19Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13emailReg",fld:"vEMAILREG",pic:""}],[]];this.setVCMap("AV19Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("AV19Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("AV19Pgmname","vPGMNAME",0,"char",129,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar({rfrVar:"AV19Pgmname"});t.addRefreshingVar({rfrVar:"AV14Update",rfrProp:"Value",gxAttId:"Update"});t.addRefreshingVar({rfrVar:"AV15Delete",rfrProp:"Value",gxAttId:"Delete"});this.Initialize()});gx.createParentObj(wwemails)