/*!   GeneXus C# 15_0_12-126726 on 1/11/2023 0:43:56.31
*/
gx.evt.autoSkip=!1;gx.define("wwusuarios",!1,function(){var n,t;this.ServerClass="wwusuarios";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV20Pgmname=gx.fn.getControlValue("vPGMNAME");this.A29emailID=gx.fn.getIntegerValue("EMAILID",".");this.AV20Pgmname=gx.fn.getControlValue("vPGMNAME")};this.Valid_Usucod=function(){try{if(gx.fn.currentGridRowImpl(25)===0)return!0;var n=gx.util.balloon.getNew("USUCOD",gx.fn.currentGridRowImpl(25));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e110s2_client=function(){return this.executeServerEvent("'DOINSERT'",!1,null,!1,!1)};this.e150s2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e160s2_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,23,24,26,27,28,29,30,31,32];this.GXLastCtrlId=32;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",25,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"wwusuarios",[],!1,1,!1,!0,0,!0,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.GridContainer;t.addSingleLineEdit(3,26,"USUCOD","Usucod","","UsuCod","char",0,"px",15,15,"left",null,[],3,"UsuCod",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(50,27,"USUNAME","Nombre","","UsuName","svchar",0,"px",40,40,"left",null,[],50,"UsuName",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(52,28,"USUEST","Estado","","UsuEst","char",0,"px",1,1,"left",null,[],52,"UsuEst",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addComboBox(53,29,"USUROL","Rol","UsuRol","char",null,0,!0,!1,0,"px","WWColumn WWOptionalColumn");t.addSingleLineEdit("Emails",30,"vEMAILS","","","emails","char",0,"px",20,20,"left",null,[],"Emails","emails",!0,0,!1,!1,"TextActionAttribute",1,"WWTextActionColumn");t.addBitmap("&Update","vUPDATE",31,0,"px",17,"px",null,"","","ImageAttribute","WWOptionalColumn WWColumn");t.addBitmap("&Delete","vDELETE",32,0,"px",17,"px",null,"","","ImageAttribute","WWOptionalColumn WWColumn");this.GridContainer.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLETOP",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TITLETEXT",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"",grid:0};n[13]={id:13,fld:"BTNINSERT",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vUSUNAME",gxz:"ZV16UsuName",gxold:"OV16UsuName",gxvar:"AV16UsuName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV16UsuName=n)},v2z:function(n){n!==undefined&&(gx.O.ZV16UsuName=n)},v2c:function(){gx.fn.setControlValue("vUSUNAME",gx.O.AV16UsuName,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV16UsuName=this.val())},val:function(){return gx.fn.getControlValue("vUSUNAME")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"GRIDCELL",grid:0};n[19]={id:19,fld:"GRIDTABLE",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[26]={id:26,lvl:2,type:"char",len:15,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:this.Valid_Usucod,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUCOD",gxz:"Z3UsuCod",gxold:"O3UsuCod",gxvar:"A3UsuCod",ucs:[],op:[27,28,29],ip:[27,28,29,26],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A3UsuCod=n)},v2z:function(n){n!==undefined&&(gx.O.Z3UsuCod=n)},v2c:function(n){gx.fn.setGridControlValue("USUCOD",n||gx.fn.currentGridRowImpl(25),gx.O.A3UsuCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A3UsuCod=this.val())},val:function(n){return gx.fn.getGridControlValue("USUCOD",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[27]={id:27,lvl:2,type:"svchar",len:40,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUNAME",gxz:"Z50UsuName",gxold:"O50UsuName",gxvar:"A50UsuName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A50UsuName=n)},v2z:function(n){n!==undefined&&(gx.O.Z50UsuName=n)},v2c:function(n){gx.fn.setGridControlValue("USUNAME",n||gx.fn.currentGridRowImpl(25),gx.O.A50UsuName,0)},c2v:function(){this.val()!==undefined&&(gx.O.A50UsuName=this.val())},val:function(n){return gx.fn.getGridControlValue("USUNAME",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[28]={id:28,lvl:2,type:"char",len:1,dec:0,sign:!1,pic:"@!",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUEST",gxz:"Z52UsuEst",gxold:"O52UsuEst",gxvar:"A52UsuEst",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A52UsuEst=n)},v2z:function(n){n!==undefined&&(gx.O.Z52UsuEst=n)},v2c:function(n){gx.fn.setGridControlValue("USUEST",n||gx.fn.currentGridRowImpl(25),gx.O.A52UsuEst,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A52UsuEst=this.val())},val:function(n){return gx.fn.getGridControlValue("USUEST",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[29]={id:29,lvl:2,type:"char",len:5,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUROL",gxz:"Z53UsuRol",gxold:"O53UsuRol",gxvar:"A53UsuRol",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A53UsuRol=n)},v2z:function(n){n!==undefined&&(gx.O.Z53UsuRol=n)},v2c:function(n){gx.fn.setGridComboBoxValue("USUROL",n||gx.fn.currentGridRowImpl(25),gx.O.A53UsuRol)},c2v:function(){this.val()!==undefined&&(gx.O.A53UsuRol=this.val())},val:function(n){return gx.fn.getGridControlValue("USUROL",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[30]={id:30,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vEMAILS",gxz:"ZV17emails",gxold:"OV17emails",gxvar:"AV17emails",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.AV17emails=n)},v2z:function(n){n!==undefined&&(gx.O.ZV17emails=n)},v2c:function(n){gx.fn.setGridControlValue("vEMAILS",n||gx.fn.currentGridRowImpl(25),gx.O.AV17emails,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV17emails=this.val())},val:function(n){return gx.fn.getGridControlValue("vEMAILS",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[31]={id:31,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV15Update",gxold:"OV15Update",gxvar:"AV15Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV15Update=n)},v2z:function(n){n!==undefined&&(gx.O.ZV15Update=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vUPDATE",n||gx.fn.currentGridRowImpl(25),gx.O.AV15Update,gx.O.AV21Update_GXI)},c2v:function(){gx.O.AV21Update_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV15Update=this.val())},val:function(n){return gx.fn.getGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(25))},val_GXI:function(n){return gx.fn.getGridControlValue("vUPDATE_GXI",n||gx.fn.currentGridRowImpl(25))},gxvar_GXI:"AV21Update_GXI",nac:gx.falseFn};n[32]={id:32,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV6Delete",gxold:"OV6Delete",gxvar:"AV6Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV6Delete=n)},v2z:function(n){n!==undefined&&(gx.O.ZV6Delete=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vDELETE",n||gx.fn.currentGridRowImpl(25),gx.O.AV6Delete,gx.O.AV22Delete_GXI)},c2v:function(){gx.O.AV22Delete_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV6Delete=this.val())},val:function(n){return gx.fn.getGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(25))},val_GXI:function(n){return gx.fn.getGridControlValue("vDELETE_GXI",n||gx.fn.currentGridRowImpl(25))},gxvar_GXI:"AV22Delete_GXI",nac:gx.falseFn};this.AV16UsuName="";this.ZV16UsuName="";this.OV16UsuName="";this.Z3UsuCod="";this.O3UsuCod="";this.Z50UsuName="";this.O50UsuName="";this.Z52UsuEst="";this.O52UsuEst="";this.Z53UsuRol="";this.O53UsuRol="";this.ZV17emails="";this.OV17emails="";this.ZV15Update="";this.OV15Update="";this.ZV6Delete="";this.OV6Delete="";this.AV16UsuName="";this.A29emailID=0;this.A3UsuCod="";this.A50UsuName="";this.A52UsuEst="";this.A53UsuRol="";this.AV17emails="";this.AV15Update="";this.AV6Delete="";this.AV20Pgmname="";this.Events={e110s2_client:["'DOINSERT'",!0],e150s2_client:["ENTER",!0],e160s2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV15Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV6Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"AV17emails",fld:"vEMAILS",pic:""},{av:"AV20Pgmname",fld:"vPGMNAME",pic:""},{av:"AV16UsuName",fld:"vUSUNAME",pic:""}],[]];this.EvtParms.START=[[{av:"AV20Pgmname",fld:"vPGMNAME",pic:""}],[{ctrl:"GRID",prop:"Rows"},{av:"AV15Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV6Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"AV17emails",fld:"vEMAILS",pic:""},{ctrl:"FORM",prop:"Caption"},{av:"AV16UsuName",fld:"vUSUNAME",pic:""}]];this.EvtParms["GRID.LOAD"]=[[{av:"A3UsuCod",fld:"USUCOD",pic:"",hsh:!0},{av:"A29emailID",fld:"EMAILID",pic:"ZZZ9"}],[{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:"vUPDATE",prop:"Link"},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:"vDELETE",prop:"Link"},{av:'gx.fn.getCtrlProperty("vEMAILS","Link")',ctrl:"vEMAILS",prop:"Link"}]];this.EvtParms["'DOINSERT'"]=[[{av:"A3UsuCod",fld:"USUCOD",pic:"",hsh:!0}],[]];this.EvtParms.GRID_FIRSTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV15Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV6Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"AV17emails",fld:"vEMAILS",pic:""},{av:"AV20Pgmname",fld:"vPGMNAME",pic:""},{av:"AV16UsuName",fld:"vUSUNAME",pic:""}],[]];this.EvtParms.GRID_PREVPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV15Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV6Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"AV17emails",fld:"vEMAILS",pic:""},{av:"AV20Pgmname",fld:"vPGMNAME",pic:""},{av:"AV16UsuName",fld:"vUSUNAME",pic:""}],[]];this.EvtParms.GRID_NEXTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV15Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV6Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"AV17emails",fld:"vEMAILS",pic:""},{av:"AV20Pgmname",fld:"vPGMNAME",pic:""},{av:"AV16UsuName",fld:"vUSUNAME",pic:""}],[]];this.EvtParms.GRID_LASTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV15Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV6Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"AV17emails",fld:"vEMAILS",pic:""},{av:"AV20Pgmname",fld:"vPGMNAME",pic:""},{av:"AV16UsuName",fld:"vUSUNAME",pic:""}],[]];this.setVCMap("AV20Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("A29emailID","EMAILID",0,"int",4,0);this.setVCMap("AV20Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("AV20Pgmname","vPGMNAME",0,"char",129,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar({rfrVar:"AV20Pgmname"});t.addRefreshingVar({rfrVar:"AV15Update",rfrProp:"Value",gxAttId:"Update"});t.addRefreshingVar({rfrVar:"AV15Update",rfrProp:"Tooltiptext",gxAttId:"Update"});t.addRefreshingVar({rfrVar:"AV6Delete",rfrProp:"Value",gxAttId:"Delete"});t.addRefreshingVar({rfrVar:"AV6Delete",rfrProp:"Tooltiptext",gxAttId:"Delete"});t.addRefreshingVar({rfrVar:"AV17emails",rfrProp:"Value",gxAttId:"Emails"});this.Initialize()});gx.createParentObj(wwusuarios)