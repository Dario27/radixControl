/*!   GeneXus C# 15_0_12-126726 on 1/11/2023 0:42:58.84
*/
gx.evt.autoSkip=!1;gx.define("periodos",!1,function(){var n,t;this.ServerClass="periodos";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV18EmpID=gx.fn.getIntegerValue("vEMPID",".");this.AV19procesoCod=gx.fn.getControlValue("vPROCESOCOD");this.AV16Insert_PerUser=gx.fn.getControlValue("vINSERT_PERUSER");this.AV10usucod=gx.fn.getControlValue("vUSUCOD");this.A44empdsc=gx.fn.getControlValue("EMPDSC");this.A334PerUserName=gx.fn.getControlValue("PERUSERNAME");this.AV20Pgmname=gx.fn.getControlValue("vPGMNAME");this.Gx_mode=gx.fn.getControlValue("vMODE");this.AV14TrnContext=gx.fn.getControlValue("vTRNCONTEXT");this.AV9ageID=gx.fn.getIntegerValue("vAGEID",".")};this.Valid_Empid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Empid",["gx.O.A1EmpID","gx.O.A44empdsc"],["A44empdsc"]),!0};this.Valid_Procesocod=function(){try{var n=gx.util.balloon.getNew("PROCESOCOD");this.AnyError=0;this.refreshOutputs([{av:"AV18EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{ctrl:"EMPID"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"},{av:"AV10usucod",fld:"vUSUCOD",pic:"",hsh:!0},{ctrl:"PERUSER"},{av:"A333PerUser",fld:"PERUSER",pic:""}])}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Perfchcontrol=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Perfchcontrol",['gx.date.urlDate(gx.O.A328PerFchControl,"DMY4")',"gx.O.A1EmpID","gx.O.A327procesoCod","gx.O.A332PerMesActual","gx.O.A331PerAnioActual"],["A332PerMesActual","A331PerAnioActual"]),!0};this.Valid_Peruser=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Peruser",["gx.O.A333PerUser","gx.O.A334PerUserName"],["A334PerUserName"]),!0};this.Valid_Peranio=function(){try{if(gx.fn.currentGridRowImpl(75)===0)return!0;var n=gx.util.balloon.getNew("PERANIO",gx.fn.currentGridRowImpl(75));this.AnyError=0;this.sMode78=this.Gx_mode;this.Gx_mode=gx.fn.getGridRowMode(78,75);this.standaloneModal0Z78();this.standaloneNotModal0Z78();gx.fn.gridDuplicateKey(76)&&(n.setError(gx.text.format(gx.getMessage("GXM_1004"),"Per","","","","","","","","")),this.AnyError=gx.num.trunc(1,0));this.refreshOutputs([{av:"AV18EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{ctrl:"EMPID"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"},{av:"AV10usucod",fld:"vUSUCOD",pic:"",hsh:!0},{ctrl:"PERUSER"},{av:"A333PerUser",fld:"PERUSER",pic:""}])}catch(t){}try{return(this.Gx_mode=this.sMode78,n==null)?!0:n.show()}catch(t){}return!0};this.standaloneModal0Z78=function(){try{this.Gx_mode!="INS"?gx.fn.setCtrlProperty("PERANIO","Enabled",0):gx.fn.setCtrlProperty("PERANIO","Enabled",1)}catch(n){}return!0};this.standaloneNotModal0Z78=function(){return!0};this.e120z2_client=function(){return this.executeServerEvent("AFTER TRN",!0,null,!1,!1)};this.e130z77_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e140z77_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,76,77,78,79,80,81,82,83,84,85,86];this.GXLastCtrlId=86;this.Gridperiodos_perContainer=new gx.grid.grid(this,78,"Per",75,"Gridperiodos_per","Gridperiodos_per","Gridperiodos_perContainer",this.CmpContext,this.IsMasterPage,"periodos",[335],!1,1,!1,!0,5,!1,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Gridperiodos_perContainer;t.addSingleLineEdit(335,76,"PERANIO","Año","","PerAnio","int",0,"px",4,4,"right",null,[],335,"PerAnio",!0,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(336,77,"PERULTMES","Ultm. Mes","","PerUltMes","int",0,"px",2,2,"right",null,[],336,"PerUltMes",!0,0,!1,!1,"Attribute",1,"");this.Gridperiodos_perContainer.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TITLECONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TITLE",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"FORMCONTAINER",grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"TOOLBARCELL",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"BTN_FIRST",grid:0};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"BTN_PREVIOUS",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"BTN_NEXT",grid:0};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"BTN_LAST",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"BTN_SELECT",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Empid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Gridperiodos_perContainer],fld:"EMPID",gxz:"Z1EmpID",gxold:"O1EmpID",gxvar:"A1EmpID",ucs:[],op:[],ip:[34],nacdep:[],ctrltype:"dyncombo",v2v:function(n){n!==undefined&&(gx.O.A1EmpID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1EmpID=gx.num.intval(n))},v2c:function(){gx.fn.setComboBoxValue("EMPID",gx.O.A1EmpID);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A1EmpID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("EMPID",".")},nac:function(){return!(0==this.AV18EmpID)}};this.declareDomainHdlr(34,function(){});n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"TABLE2",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PERANIOACTUAL",gxz:"Z331PerAnioActual",gxold:"O331PerAnioActual",gxvar:"A331PerAnioActual",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A331PerAnioActual=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z331PerAnioActual=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("PERANIOACTUAL",gx.O.A331PerAnioActual,0)},c2v:function(){this.val()!==undefined&&(gx.O.A331PerAnioActual=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("PERANIOACTUAL",".")},nac:gx.falseFn};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"",grid:0};n[45]={id:45,lvl:0,type:"int",len:2,dec:0,sign:!1,pic:"Z9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PERMESACTUAL",gxz:"Z332PerMesActual",gxold:"O332PerMesActual",gxvar:"A332PerMesActual",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A332PerMesActual=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z332PerMesActual=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("PERMESACTUAL",gx.O.A332PerMesActual,0)},c2v:function(){this.val()!==undefined&&(gx.O.A332PerMesActual=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("PERMESACTUAL",".")},nac:gx.falseFn};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"TABLE1",grid:0};n[49]={id:49,fld:"",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,lvl:0,type:"svchar",len:10,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Procesocod,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Gridperiodos_perContainer],fld:"PROCESOCOD",gxz:"Z327procesoCod",gxold:"O327procesoCod",gxvar:"A327procesoCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A327procesoCod=n)},v2z:function(n){n!==undefined&&(gx.O.Z327procesoCod=n)},v2c:function(){gx.fn.setControlValue("PROCESOCOD",gx.O.A327procesoCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A327procesoCod=this.val())},val:function(){return gx.fn.getControlValue("PROCESOCOD")},nac:function(){return!(""==this.AV19procesoCod)}};n[53]={id:53,fld:"",grid:0};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"",grid:0};n[56]={id:56,lvl:0,type:"date",len:10,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Perfchcontrol,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PERFCHCONTROL",gxz:"Z328PerFchControl",gxold:"O328PerFchControl",gxvar:"A328PerFchControl",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/9999",dec:0},ucs:[],op:[41,45,56],ip:[41,45,52,34,56],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A328PerFchControl=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z328PerFchControl=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("PERFCHCONTROL",gx.O.A328PerFchControl,0)},c2v:function(){this.val()!==undefined&&(gx.O.A328PerFchControl=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("PERFCHCONTROL")},nac:gx.falseFn};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"",grid:0};n[59]={id:59,fld:"",grid:0};n[60]={id:60,fld:"",grid:0};n[61]={id:61,lvl:0,type:"int",len:2,dec:0,sign:!1,pic:"Z9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PERDIASPLAZO",gxz:"Z329PerDiasPlazo",gxold:"O329PerDiasPlazo",gxvar:"A329PerDiasPlazo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A329PerDiasPlazo=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z329PerDiasPlazo=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("PERDIASPLAZO",gx.O.A329PerDiasPlazo,0)},c2v:function(){this.val()!==undefined&&(gx.O.A329PerDiasPlazo=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("PERDIASPLAZO",".")},nac:gx.falseFn};n[62]={id:62,fld:"",grid:0};n[63]={id:63,fld:"",grid:0};n[64]={id:64,fld:"",grid:0};n[65]={id:65,fld:"",grid:0};n[66]={id:66,lvl:0,type:"char",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Peruser,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PERUSER",gxz:"Z333PerUser",gxold:"O333PerUser",gxvar:"A333PerUser",ucs:[],op:[],ip:[66],nacdep:[],ctrltype:"dyncombo",v2v:function(n){n!==undefined&&(gx.O.A333PerUser=n)},v2z:function(n){n!==undefined&&(gx.O.Z333PerUser=n)},v2c:function(){gx.fn.setComboBoxValue("PERUSER",gx.O.A333PerUser)},c2v:function(){this.val()!==undefined&&(gx.O.A333PerUser=this.val())},val:function(){return gx.fn.getControlValue("PERUSER")},nac:function(){return this.Gx_mode=="INS"&&!(""==this.AV16Insert_PerUser)}};n[67]={id:67,fld:"",grid:0};n[68]={id:68,fld:"",grid:0};n[69]={id:69,fld:"PERTABLE",grid:0};n[70]={id:70,fld:"",grid:0};n[71]={id:71,fld:"",grid:0};n[72]={id:72,fld:"TITLEPER",format:0,grid:0};n[73]={id:73,fld:"",grid:0};n[74]={id:74,fld:"",grid:0};n[76]={id:76,lvl:78,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,isacc:1,grid:75,gxgrid:this.Gridperiodos_perContainer,fnc:this.Valid_Peranio,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PERANIO",gxz:"Z335PerAnio",gxold:"O335PerAnio",gxvar:"A335PerAnio",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A335PerAnio=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z335PerAnio=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("PERANIO",n||gx.fn.currentGridRowImpl(75),gx.O.A335PerAnio,0)},c2v:function(){this.val()!==undefined&&(gx.O.A335PerAnio=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("PERANIO",n||gx.fn.currentGridRowImpl(75),".")},nac:gx.falseFn};n[77]={id:77,lvl:78,type:"int",len:2,dec:0,sign:!1,pic:"Z9",ro:0,isacc:1,grid:75,gxgrid:this.Gridperiodos_perContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PERULTMES",gxz:"Z336PerUltMes",gxold:"O336PerUltMes",gxvar:"A336PerUltMes",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A336PerUltMes=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z336PerUltMes=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("PERULTMES",n||gx.fn.currentGridRowImpl(75),gx.O.A336PerUltMes,0)},c2v:function(){this.val()!==undefined&&(gx.O.A336PerUltMes=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("PERULTMES",n||gx.fn.currentGridRowImpl(75),".")},nac:gx.falseFn};n[78]={id:78,fld:"",grid:0};n[79]={id:79,fld:"",grid:0};n[80]={id:80,fld:"",grid:0};n[81]={id:81,fld:"",grid:0};n[82]={id:82,fld:"BTN_ENTER",grid:0};n[83]={id:83,fld:"",grid:0};n[84]={id:84,fld:"BTN_CANCEL",grid:0};n[85]={id:85,fld:"",grid:0};n[86]={id:86,fld:"BTN_DELETE",grid:0};this.A1EmpID=0;this.Z1EmpID=0;this.O1EmpID=0;this.A331PerAnioActual=0;this.Z331PerAnioActual=0;this.O331PerAnioActual=0;this.A332PerMesActual=0;this.Z332PerMesActual=0;this.O332PerMesActual=0;this.A327procesoCod="";this.Z327procesoCod="";this.O327procesoCod="";this.A328PerFchControl=gx.date.nullDate();this.Z328PerFchControl=gx.date.nullDate();this.O328PerFchControl=gx.date.nullDate();this.A329PerDiasPlazo=0;this.Z329PerDiasPlazo=0;this.O329PerDiasPlazo=0;this.A333PerUser="";this.Z333PerUser="";this.O333PerUser="";this.Z335PerAnio=0;this.O335PerAnio=0;this.Z336PerUltMes=0;this.O336PerUltMes=0;this.A335PerAnio=0;this.A336PerUltMes=0;this.AV20Pgmname="";this.AV14TrnContext={CallerObject:"",CallerOnDelete:!1,CallerURL:"",TransactionName:"",Attributes:[]};this.AV16Insert_PerUser="";this.AV21GXV1=0;this.AV17TrnContextAtt={AttributeName:"",AttributeValue:""};this.AV19procesoCod="";this.AV18EmpID=0;this.AV9ageID=0;this.AV10usucod="";this.AV15WebSession={};this.A1EmpID=0;this.A327procesoCod="";this.A333PerUser="";this.A331PerAnioActual=0;this.A332PerMesActual=0;this.A44empdsc="";this.A328PerFchControl=gx.date.nullDate();this.A329PerDiasPlazo=0;this.A334PerUserName="";this.Gx_mode="";this.Events={e120z2_client:["AFTER TRN",!0],e130z77_client:["ENTER",!0],e140z77_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV19procesoCod",fld:"vPROCESOCOD",pic:"",hsh:!0},{av:"AV9ageID",fld:"vAGEID",pic:"ZZZ9",hsh:!0},{av:"AV18EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{ctrl:"EMPID"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"},{av:"AV10usucod",fld:"vUSUCOD",pic:"",hsh:!0},{ctrl:"PERUSER"},{av:"A333PerUser",fld:"PERUSER",pic:""}],[{av:"AV18EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{ctrl:"EMPID"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"},{av:"AV10usucod",fld:"vUSUCOD",pic:"",hsh:!0},{ctrl:"PERUSER"},{av:"A333PerUser",fld:"PERUSER",pic:""}]];this.EvtParms.REFRESH=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV9ageID",fld:"vAGEID",pic:"ZZZ9",hsh:!0},{av:"AV19procesoCod",fld:"vPROCESOCOD",pic:"",hsh:!0},{av:"AV16Insert_PerUser",fld:"vINSERT_PERUSER",pic:""},{av:"AV18EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{ctrl:"EMPID"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"},{av:"AV10usucod",fld:"vUSUCOD",pic:"",hsh:!0},{ctrl:"PERUSER"},{av:"A333PerUser",fld:"PERUSER",pic:""}],[{av:"AV18EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{ctrl:"EMPID"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"},{av:"AV10usucod",fld:"vUSUCOD",pic:"",hsh:!0},{ctrl:"PERUSER"},{av:"A333PerUser",fld:"PERUSER",pic:""}]];this.EvtParms.START=[[{av:"AV20Pgmname",fld:"vPGMNAME",pic:""},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV18EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{ctrl:"EMPID"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"},{av:"AV10usucod",fld:"vUSUCOD",pic:"",hsh:!0},{ctrl:"PERUSER"},{av:"A333PerUser",fld:"PERUSER",pic:""}],[{av:"AV14TrnContext",fld:"vTRNCONTEXT",pic:""},{av:"AV16Insert_PerUser",fld:"vINSERT_PERUSER",pic:""},{av:"AV21GXV1",fld:"vGXV1",pic:"99999999"},{av:"AV17TrnContextAtt",fld:"vTRNCONTEXTATT",pic:""},{av:"AV18EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{ctrl:"EMPID"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"},{av:"AV10usucod",fld:"vUSUCOD",pic:"",hsh:!0},{ctrl:"PERUSER"},{av:"A333PerUser",fld:"PERUSER",pic:""}]];this.EvtParms["AFTER TRN"]=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV14TrnContext",fld:"vTRNCONTEXT",pic:""},{av:"AV18EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{ctrl:"EMPID"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"},{av:"AV10usucod",fld:"vUSUCOD",pic:"",hsh:!0},{ctrl:"PERUSER"},{av:"A333PerUser",fld:"PERUSER",pic:""}],[{av:"AV18EmpID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{ctrl:"EMPID"},{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"},{av:"AV10usucod",fld:"vUSUCOD",pic:"",hsh:!0},{ctrl:"PERUSER"},{av:"A333PerUser",fld:"PERUSER",pic:""}]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("AV18EmpID","vEMPID",0,"int",4,0);this.setVCMap("AV19procesoCod","vPROCESOCOD",0,"svchar",10,0);this.setVCMap("AV16Insert_PerUser","vINSERT_PERUSER",0,"char",15,0);this.setVCMap("AV10usucod","vUSUCOD",0,"char",15,0);this.setVCMap("A44empdsc","EMPDSC",0,"svchar",100,0);this.setVCMap("A334PerUserName","PERUSERNAME",0,"svchar",40,0);this.setVCMap("AV20Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("Gx_mode","vMODE",0,"char",3,0);this.setVCMap("AV14TrnContext","vTRNCONTEXT",0,"TransactionContext",0,0);this.setVCMap("AV9ageID","vAGEID",0,"int",4,0);t.addPostingVar({rfrVar:"Gx_mode"});this.Initialize()});gx.createParentObj(periodos)