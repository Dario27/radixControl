/*!   GeneXus C# 15_0_12-126726 on 1/14/2023 1:15:57.21
*/
gx.evt.autoSkip=!1;gx.define("procesosordenprod",!1,function(){var n,t;this.ServerClass="procesosordenprod";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.A115OrdenEst=gx.fn.getControlValue("ORDENEST");this.A57ClienteDsc=gx.fn.getControlValue("CLIENTEDSC");this.A22OrdenID=gx.fn.getIntegerValue("ORDENID",".");this.AV7empID=gx.fn.getIntegerValue("vEMPID",".");this.AV5ageID=gx.fn.getIntegerValue("vAGEID",".");this.AV10UsuCod=gx.fn.getControlValue("vUSUCOD");this.A115OrdenEst=gx.fn.getControlValue("ORDENEST");this.A57ClienteDsc=gx.fn.getControlValue("CLIENTEDSC");this.A22OrdenID=gx.fn.getIntegerValue("ORDENID",".");this.AV7empID=gx.fn.getIntegerValue("vEMPID",".")};this.e13282_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e14282_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,14,15,16,17,18,19];this.GXLastCtrlId=19;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",13,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"procesosordenprod",[],!1,1,!1,!0,0,!1,!1,!1,"",0,"px",0,"px","Nueva fila",!1,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addSingleLineEdit("Ordenid",14,"vORDENID","#Orden","","ordenID","int",0,"px",4,4,"right",null,[],"Ordenid","ordenID",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit("Clientedsc",15,"vCLIENTEDSC","Cliente","","clienteDsc","char",0,"px",50,50,"left",null,[],"Clientedsc","clienteDsc",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addCheckBox("Corte",16,"vCORTE","corte","","corte","char","S","N",null,!0,!1,0,"px","WWColumn WWOptionalColumn");t.addCheckBox("Estructura",17,"vESTRUCTURA","estructura","","estructura","char","S","N",null,!0,!1,0,"px","WWColumn WWOptionalColumn");t.addCheckBox("Doblado",18,"vDOBLADO","doblado","","doblado","char","S","N",null,!0,!1,0,"px","WWColumn WWOptionalColumn");t.addCheckBox("Forrado",19,"vFORRADO","forrado","","forrado","char","S","N",null,!0,!1,0,"px","WWColumn WWOptionalColumn");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLE1",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"SECTION1",grid:0};n[10]={id:10,fld:"TEXTBLOCK1",format:0,grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"",grid:0};n[14]={id:14,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:13,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vORDENID",gxz:"ZV8ordenID",gxold:"OV8ordenID",gxvar:"AV8ordenID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.AV8ordenID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV8ordenID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("vORDENID",n||gx.fn.currentGridRowImpl(13),gx.O.AV8ordenID,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8ordenID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("vORDENID",n||gx.fn.currentGridRowImpl(13),".")},nac:gx.falseFn};n[15]={id:15,lvl:2,type:"char",len:50,dec:0,sign:!1,ro:1,isacc:0,grid:13,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vCLIENTEDSC",gxz:"ZV6clienteDsc",gxold:"OV6clienteDsc",gxvar:"AV6clienteDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.AV6clienteDsc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV6clienteDsc=n)},v2c:function(n){gx.fn.setGridControlValue("vCLIENTEDSC",n||gx.fn.currentGridRowImpl(13),gx.O.AV6clienteDsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6clienteDsc=this.val())},val:function(n){return gx.fn.getGridControlValue("vCLIENTEDSC",n||gx.fn.currentGridRowImpl(13))},nac:gx.falseFn};n[16]={id:16,lvl:2,type:"char",len:1,dec:0,sign:!1,ro:1,isacc:0,grid:13,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vCORTE",gxz:"ZV9corte",gxold:"OV9corte",gxvar:"AV9corte",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV9corte=n)},v2z:function(n){n!==undefined&&(gx.O.ZV9corte=n)},v2c:function(n){gx.fn.setGridCheckBoxValue("vCORTE",n||gx.fn.currentGridRowImpl(13),gx.O.AV9corte,"S")},c2v:function(){this.val()!==undefined&&(gx.O.AV9corte=this.val())},val:function(n){return gx.fn.getGridControlValue("vCORTE",n||gx.fn.currentGridRowImpl(13))},nac:gx.falseFn,values:["S","N"]};n[17]={id:17,lvl:2,type:"char",len:1,dec:0,sign:!1,ro:1,isacc:0,grid:13,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vESTRUCTURA",gxz:"ZV11estructura",gxold:"OV11estructura",gxvar:"AV11estructura",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV11estructura=n)},v2z:function(n){n!==undefined&&(gx.O.ZV11estructura=n)},v2c:function(n){gx.fn.setGridCheckBoxValue("vESTRUCTURA",n||gx.fn.currentGridRowImpl(13),gx.O.AV11estructura,"S")},c2v:function(){this.val()!==undefined&&(gx.O.AV11estructura=this.val())},val:function(n){return gx.fn.getGridControlValue("vESTRUCTURA",n||gx.fn.currentGridRowImpl(13))},nac:gx.falseFn,values:["S","N"]};n[18]={id:18,lvl:2,type:"char",len:1,dec:0,sign:!1,ro:1,isacc:0,grid:13,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDOBLADO",gxz:"ZV12doblado",gxold:"OV12doblado",gxvar:"AV12doblado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV12doblado=n)},v2z:function(n){n!==undefined&&(gx.O.ZV12doblado=n)},v2c:function(n){gx.fn.setGridCheckBoxValue("vDOBLADO",n||gx.fn.currentGridRowImpl(13),gx.O.AV12doblado,"S")},c2v:function(){this.val()!==undefined&&(gx.O.AV12doblado=this.val())},val:function(n){return gx.fn.getGridControlValue("vDOBLADO",n||gx.fn.currentGridRowImpl(13))},nac:gx.falseFn,values:["S","N"]};n[19]={id:19,lvl:2,type:"char",len:1,dec:0,sign:!1,ro:1,isacc:0,grid:13,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vFORRADO",gxz:"ZV13forrado",gxold:"OV13forrado",gxvar:"AV13forrado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV13forrado=n)},v2z:function(n){n!==undefined&&(gx.O.ZV13forrado=n)},v2c:function(n){gx.fn.setGridCheckBoxValue("vFORRADO",n||gx.fn.currentGridRowImpl(13),gx.O.AV13forrado,"S")},c2v:function(){this.val()!==undefined&&(gx.O.AV13forrado=this.val())},val:function(n){return gx.fn.getGridControlValue("vFORRADO",n||gx.fn.currentGridRowImpl(13))},nac:gx.falseFn,values:["S","N"]};this.ZV8ordenID=0;this.OV8ordenID=0;this.ZV6clienteDsc="";this.OV6clienteDsc="";this.ZV9corte="";this.OV9corte="";this.ZV11estructura="";this.OV11estructura="";this.ZV12doblado="";this.OV12doblado="";this.ZV13forrado="";this.OV13forrado="";this.AV7empID=0;this.AV5ageID=0;this.AV10UsuCod="";this.AV8ordenID=0;this.AV6clienteDsc="";this.AV9corte="";this.AV11estructura="";this.AV12doblado="";this.AV13forrado="";this.A1EmpID=0;this.A115OrdenEst="";this.A57ClienteDsc="";this.A22OrdenID=0;this.A5ClienteID=0;this.Events={e13282_client:["ENTER",!0],e14282_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{av:'gx.fn.getCtrlProperty("vFORRADO","Enabled")',ctrl:"vFORRADO",prop:"Enabled"},{av:'gx.fn.getCtrlProperty("vDOBLADO","Enabled")',ctrl:"vDOBLADO",prop:"Enabled"},{av:'gx.fn.getCtrlProperty("vESTRUCTURA","Enabled")',ctrl:"vESTRUCTURA",prop:"Enabled"},{av:'gx.fn.getCtrlProperty("vCORTE","Enabled")',ctrl:"vCORTE",prop:"Enabled"},{av:"A115OrdenEst",fld:"ORDENEST",pic:""},{av:"A57ClienteDsc",fld:"CLIENTEDSC",pic:""},{av:"A22OrdenID",fld:"ORDENID",pic:"ZZZ9"},{av:"AV7empID",fld:"vEMPID",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms["GRID1.LOAD"]=[[{av:"A115OrdenEst",fld:"ORDENEST",pic:""},{av:"A57ClienteDsc",fld:"CLIENTEDSC",pic:""},{av:"A22OrdenID",fld:"ORDENID",pic:"ZZZ9"},{av:"AV7empID",fld:"vEMPID",pic:"ZZZ9",hsh:!0}],[{av:"AV6clienteDsc",fld:"vCLIENTEDSC",pic:""},{av:"AV8ordenID",fld:"vORDENID",pic:"ZZZ9"},{av:"AV13forrado",fld:"vFORRADO",pic:""},{av:"AV12doblado",fld:"vDOBLADO",pic:""},{av:"AV11estructura",fld:"vESTRUCTURA",pic:""},{av:"AV9corte",fld:"vCORTE",pic:""}]];this.EvtParms.START=[[],[{av:'gx.fn.getCtrlProperty("vFORRADO","Enabled")',ctrl:"vFORRADO",prop:"Enabled"},{av:'gx.fn.getCtrlProperty("vDOBLADO","Enabled")',ctrl:"vDOBLADO",prop:"Enabled"},{av:'gx.fn.getCtrlProperty("vESTRUCTURA","Enabled")',ctrl:"vESTRUCTURA",prop:"Enabled"},{av:'gx.fn.getCtrlProperty("vCORTE","Enabled")',ctrl:"vCORTE",prop:"Enabled"}]];this.setVCMap("A115OrdenEst","ORDENEST",0,"char",1,0);this.setVCMap("A57ClienteDsc","CLIENTEDSC",0,"char",50,0);this.setVCMap("A22OrdenID","ORDENID",0,"int",4,0);this.setVCMap("AV7empID","vEMPID",0,"int",4,0);this.setVCMap("AV5ageID","vAGEID",0,"int",4,0);this.setVCMap("AV10UsuCod","vUSUCOD",0,"char",15,0);this.setVCMap("A115OrdenEst","ORDENEST",0,"char",1,0);this.setVCMap("A57ClienteDsc","CLIENTEDSC",0,"char",50,0);this.setVCMap("A22OrdenID","ORDENID",0,"int",4,0);this.setVCMap("AV7empID","vEMPID",0,"int",4,0);this.setVCMap("A115OrdenEst","ORDENEST",0,"char",1,0);this.setVCMap("A57ClienteDsc","CLIENTEDSC",0,"char",50,0);this.setVCMap("A22OrdenID","ORDENID",0,"int",4,0);this.setVCMap("AV7empID","vEMPID",0,"int",4,0);t.addRefreshingVar({rfrVar:"AV13forrado",rfrProp:"Enabled",gxAttId:"Forrado"});t.addRefreshingVar({rfrVar:"AV12doblado",rfrProp:"Enabled",gxAttId:"Doblado"});t.addRefreshingVar({rfrVar:"AV11estructura",rfrProp:"Enabled",gxAttId:"Estructura"});t.addRefreshingVar({rfrVar:"AV9corte",rfrProp:"Enabled",gxAttId:"Corte"});t.addRefreshingVar({rfrVar:"A115OrdenEst"});t.addRefreshingVar({rfrVar:"A57ClienteDsc"});t.addRefreshingVar({rfrVar:"A22OrdenID"});t.addRefreshingVar({rfrVar:"AV7empID"});this.Initialize()});gx.createParentObj(procesosordenprod)