/*!   GeneXus C# 15_0_12-126726 on 10/29/2022 1:9:32.22
*/
gx.evt.autoSkip=!1;gx.define("wwprodprecio",!1,function(){var n,t;this.ServerClass="wwprodprecio";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV24Pgmname=gx.fn.getControlValue("vPGMNAME");this.AV21fecha=gx.fn.getDateValue("vFECHA");this.AV17empId=gx.fn.getIntegerValue("vEMPID",".");this.AV18ageID=gx.fn.getIntegerValue("vAGEID",".");this.AV20prdCod=gx.fn.getIntegerValue("vPRDCOD",".");this.AV19usuCod=gx.fn.getControlValue("vUSUCOD");this.AV20prdCod=gx.fn.getIntegerValue("vPRDCOD",".");this.AV24Pgmname=gx.fn.getControlValue("vPGMNAME");this.AV21fecha=gx.fn.getDateValue("vFECHA")};this.Valid_Empid=function(){try{if(gx.fn.currentGridRowImpl(22)===0)return!0;var n=gx.util.balloon.getNew("EMPID",gx.fn.currentGridRowImpl(22));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Ageid=function(){try{if(gx.fn.currentGridRowImpl(22)===0)return!0;var n=gx.util.balloon.getNew("AGEID",gx.fn.currentGridRowImpl(22));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e114r2_client=function(){return this.executeServerEvent("'DOINSERT'",!1,null,!1,!1)};this.e154r2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e164r2_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,20,21,23,24,25,26,27,28,29,30,31,32,33];this.GXLastCtrlId=33;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",22,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"wwprodprecio",[],!1,1,!1,!0,0,!0,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.GridContainer;t.addSingleLineEdit(1,23,"EMPID","Emp ID","","EmpID","int",0,"px",4,4,"right",null,[],1,"EmpID",!1,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(44,24,"EMPDSC","Empresa","","empdsc","svchar",0,"px",100,80,"left",null,[],44,"empdsc",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(2,25,"AGEID","Age ID","","AgeID","int",0,"px",4,4,"right",null,[],2,"AgeID",!1,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(46,26,"AGEDSC","Agencia","","AgeDsc","char",0,"px",50,50,"left",null,[],46,"AgeDsc",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(302,27,"FECHA","Fecha Rgistro","","fecha","date",0,"px",8,8,"right",null,[],302,"fecha",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addComboBox(286,28,"PRDCOD","Producto","PrdCod","int",null,0,!0,!1,0,"px","WWColumn WWOptionalColumn");t.addSingleLineEdit(303,29,"VALANT","Anterior","","valAnt","decimal",0,"px",13,13,"right",null,[],303,"valAnt",!0,2,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(304,30,"VALOACT","Actual","","valoAct","decimal",0,"px",13,13,"right",null,[],304,"valoAct",!0,2,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(3,31,"USUCOD","Usuario","","UsuCod","char",0,"px",15,15,"left",null,[],3,"UsuCod",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addBitmap("&Update","vUPDATE",32,0,"px",17,"px",null,"","","ImageAttribute","WWActionColumn");t.addBitmap("&Delete","vDELETE",33,0,"px",17,"px",null,"","","ImageAttribute","WWActionColumn");this.GridContainer.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLETOP",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TITLETEXT",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"",grid:0};n[13]={id:13,fld:"BTNINSERT",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"GRIDCELL",grid:0};n[16]={id:16,fld:"GRIDTABLE",grid:0};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[23]={id:23,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:22,gxgrid:this.GridContainer,fnc:this.Valid_Empid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EMPID",gxz:"Z1EmpID",gxold:"O1EmpID",gxvar:"A1EmpID",ucs:[],op:[26,24],ip:[26,24,25,23],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A1EmpID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1EmpID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("EMPID",n||gx.fn.currentGridRowImpl(22),gx.O.A1EmpID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A1EmpID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("EMPID",n||gx.fn.currentGridRowImpl(22),".")},nac:gx.falseFn};n[24]={id:24,lvl:2,type:"svchar",len:100,dec:0,sign:!1,pic:"@!",ro:1,isacc:0,grid:22,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EMPDSC",gxz:"Z44empdsc",gxold:"O44empdsc",gxvar:"A44empdsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A44empdsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z44empdsc=n)},v2c:function(n){gx.fn.setGridControlValue("EMPDSC",n||gx.fn.currentGridRowImpl(22),gx.O.A44empdsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A44empdsc=this.val())},val:function(n){return gx.fn.getGridControlValue("EMPDSC",n||gx.fn.currentGridRowImpl(22))},nac:gx.falseFn};n[25]={id:25,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:22,gxgrid:this.GridContainer,fnc:this.Valid_Ageid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"AGEID",gxz:"Z2AgeID",gxold:"O2AgeID",gxvar:"A2AgeID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A2AgeID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z2AgeID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("AGEID",n||gx.fn.currentGridRowImpl(22),gx.O.A2AgeID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A2AgeID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("AGEID",n||gx.fn.currentGridRowImpl(22),".")},nac:gx.falseFn};n[26]={id:26,lvl:2,type:"char",len:50,dec:0,sign:!1,ro:1,isacc:0,grid:22,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"AGEDSC",gxz:"Z46AgeDsc",gxold:"O46AgeDsc",gxvar:"A46AgeDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A46AgeDsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z46AgeDsc=n)},v2c:function(n){gx.fn.setGridControlValue("AGEDSC",n||gx.fn.currentGridRowImpl(22),gx.O.A46AgeDsc,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A46AgeDsc=this.val())},val:function(n){return gx.fn.getGridControlValue("AGEDSC",n||gx.fn.currentGridRowImpl(22))},nac:gx.falseFn};n[27]={id:27,lvl:2,type:"date",len:8,dec:0,sign:!1,ro:1,isacc:0,grid:22,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"FECHA",gxz:"Z302fecha",gxold:"O302fecha",gxvar:"A302fecha",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A302fecha=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z302fecha=gx.fn.toDatetimeValue(n))},v2c:function(n){gx.fn.setGridControlValue("FECHA",n||gx.fn.currentGridRowImpl(22),gx.O.A302fecha,0)},c2v:function(){this.val()!==undefined&&(gx.O.A302fecha=gx.fn.toDatetimeValue(this.val()))},val:function(n){return gx.fn.getGridDateTimeValue("FECHA",n||gx.fn.currentGridRowImpl(22))},nac:gx.falseFn};n[28]={id:28,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:22,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PRDCOD",gxz:"Z286PrdCod",gxold:"O286PrdCod",gxvar:"A286PrdCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"dyncombo",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A286PrdCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z286PrdCod=gx.num.intval(n))},v2c:function(n){gx.fn.setGridComboBoxValue("PRDCOD",n||gx.fn.currentGridRowImpl(22),gx.O.A286PrdCod)},c2v:function(){this.val()!==undefined&&(gx.O.A286PrdCod=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("PRDCOD",n||gx.fn.currentGridRowImpl(22),".")},nac:gx.falseFn};n[29]={id:29,lvl:2,type:"decimal",len:10,dec:2,sign:!1,pic:"ZZ,ZZZ,ZZZ.ZZ",ro:1,isacc:0,grid:22,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VALANT",gxz:"Z303valAnt",gxold:"O303valAnt",gxvar:"A303valAnt",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A303valAnt=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z303valAnt=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("VALANT",n||gx.fn.currentGridRowImpl(22),gx.O.A303valAnt,2,",");typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A303valAnt=this.val())},val:function(n){return gx.fn.getGridDecimalValue("VALANT",n||gx.fn.currentGridRowImpl(22),".",",")},nac:gx.falseFn};n[30]={id:30,lvl:2,type:"decimal",len:10,dec:2,sign:!1,pic:"ZZ,ZZZ,ZZZ.ZZ",ro:1,isacc:0,grid:22,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VALOACT",gxz:"Z304valoAct",gxold:"O304valoAct",gxvar:"A304valoAct",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A304valoAct=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z304valoAct=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("VALOACT",n||gx.fn.currentGridRowImpl(22),gx.O.A304valoAct,2,",");typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A304valoAct=this.val())},val:function(n){return gx.fn.getGridDecimalValue("VALOACT",n||gx.fn.currentGridRowImpl(22),".",",")},nac:gx.falseFn};n[31]={id:31,lvl:2,type:"char",len:15,dec:0,sign:!1,ro:1,isacc:0,grid:22,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUCOD",gxz:"Z3UsuCod",gxold:"O3UsuCod",gxvar:"A3UsuCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A3UsuCod=n)},v2z:function(n){n!==undefined&&(gx.O.Z3UsuCod=n)},v2c:function(n){gx.fn.setGridControlValue("USUCOD",n||gx.fn.currentGridRowImpl(22),gx.O.A3UsuCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A3UsuCod=this.val())},val:function(n){return gx.fn.getGridControlValue("USUCOD",n||gx.fn.currentGridRowImpl(22))},nac:gx.falseFn};n[32]={id:32,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:22,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV14Update",gxold:"OV14Update",gxvar:"AV14Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV14Update=n)},v2z:function(n){n!==undefined&&(gx.O.ZV14Update=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vUPDATE",n||gx.fn.currentGridRowImpl(22),gx.O.AV14Update,gx.O.AV25Update_GXI)},c2v:function(){gx.O.AV25Update_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV14Update=this.val())},val:function(n){return gx.fn.getGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(22))},val_GXI:function(n){return gx.fn.getGridControlValue("vUPDATE_GXI",n||gx.fn.currentGridRowImpl(22))},gxvar_GXI:"AV25Update_GXI",nac:gx.falseFn};n[33]={id:33,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:22,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV15Delete",gxold:"OV15Delete",gxvar:"AV15Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV15Delete=n)},v2z:function(n){n!==undefined&&(gx.O.ZV15Delete=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vDELETE",n||gx.fn.currentGridRowImpl(22),gx.O.AV15Delete,gx.O.AV26Delete_GXI)},c2v:function(){gx.O.AV26Delete_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV15Delete=this.val())},val:function(n){return gx.fn.getGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(22))},val_GXI:function(n){return gx.fn.getGridControlValue("vDELETE_GXI",n||gx.fn.currentGridRowImpl(22))},gxvar_GXI:"AV26Delete_GXI",nac:gx.falseFn};this.Z1EmpID=0;this.O1EmpID=0;this.Z44empdsc="";this.O44empdsc="";this.Z2AgeID=0;this.O2AgeID=0;this.Z46AgeDsc="";this.O46AgeDsc="";this.Z302fecha=gx.date.nullDate();this.O302fecha=gx.date.nullDate();this.Z286PrdCod=0;this.O286PrdCod=0;this.Z303valAnt=0;this.O303valAnt=0;this.Z304valoAct=0;this.O304valoAct=0;this.Z3UsuCod="";this.O3UsuCod="";this.ZV14Update="";this.OV14Update="";this.ZV15Delete="";this.OV15Delete="";this.AV17empId=0;this.AV18ageID=0;this.AV20prdCod=0;this.AV19usuCod="";this.A1EmpID=0;this.A44empdsc="";this.A2AgeID=0;this.A46AgeDsc="";this.A302fecha=gx.date.nullDate();this.A286PrdCod=0;this.A303valAnt=0;this.A304valoAct=0;this.A3UsuCod="";this.AV14Update="";this.AV15Delete="";this.AV24Pgmname="";this.AV21fecha=gx.date.nullDate();this.Events={e114r2_client:["'DOINSERT'",!0],e154r2_client:["ENTER",!0],e164r2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV20prdCod",fld:"vPRDCOD",pic:"ZZZ9"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"AV24Pgmname",fld:"vPGMNAME",pic:""},{av:"AV21fecha",fld:"vFECHA",pic:"",hsh:!0}],[]];this.EvtParms.START=[[{av:"AV24Pgmname",fld:"vPGMNAME",pic:""}],[{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{ctrl:"FORM",prop:"Caption"},{av:"AV21fecha",fld:"vFECHA",pic:"",hsh:!0}]];this.EvtParms["GRID.LOAD"]=[[{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9",hsh:!0},{av:"A2AgeID",fld:"AGEID",pic:"ZZZ9",hsh:!0},{ctrl:"PRDCOD"},{av:"A286PrdCod",fld:"PRDCOD",pic:"ZZZ9",hsh:!0}],[{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:"vUPDATE",prop:"Link"},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:"vDELETE",prop:"Link"}]];this.EvtParms["'DOINSERT'"]=[[{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9",hsh:!0},{av:"A2AgeID",fld:"AGEID",pic:"ZZZ9",hsh:!0},{ctrl:"PRDCOD"},{av:"A286PrdCod",fld:"PRDCOD",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms.GRID_FIRSTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV20prdCod",fld:"vPRDCOD",pic:"ZZZ9"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"AV24Pgmname",fld:"vPGMNAME",pic:""},{av:"AV21fecha",fld:"vFECHA",pic:"",hsh:!0}],[]];this.EvtParms.GRID_PREVPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV20prdCod",fld:"vPRDCOD",pic:"ZZZ9"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"AV24Pgmname",fld:"vPGMNAME",pic:""},{av:"AV21fecha",fld:"vFECHA",pic:"",hsh:!0}],[]];this.EvtParms.GRID_NEXTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV20prdCod",fld:"vPRDCOD",pic:"ZZZ9"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"AV24Pgmname",fld:"vPGMNAME",pic:""},{av:"AV21fecha",fld:"vFECHA",pic:"",hsh:!0}],[]];this.EvtParms.GRID_LASTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV20prdCod",fld:"vPRDCOD",pic:"ZZZ9"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"AV24Pgmname",fld:"vPGMNAME",pic:""},{av:"AV21fecha",fld:"vFECHA",pic:"",hsh:!0}],[]];this.setVCMap("AV24Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("AV21fecha","vFECHA",0,"date",8,0);this.setVCMap("AV17empId","vEMPID",0,"int",4,0);this.setVCMap("AV18ageID","vAGEID",0,"int",4,0);this.setVCMap("AV20prdCod","vPRDCOD",0,"int",4,0);this.setVCMap("AV19usuCod","vUSUCOD",0,"char",15,0);this.setVCMap("AV20prdCod","vPRDCOD",0,"int",4,0);this.setVCMap("AV24Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("AV21fecha","vFECHA",0,"date",8,0);this.setVCMap("AV20prdCod","vPRDCOD",0,"int",4,0);this.setVCMap("AV24Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("AV21fecha","vFECHA",0,"date",8,0);t.addRefreshingVar({rfrVar:"AV20prdCod"});t.addRefreshingVar({rfrVar:"AV24Pgmname"});t.addRefreshingVar({rfrVar:"AV21fecha"});t.addRefreshingVar({rfrVar:"AV14Update",rfrProp:"Value",gxAttId:"Update"});t.addRefreshingVar({rfrVar:"AV14Update",rfrProp:"Tooltiptext",gxAttId:"Update"});t.addRefreshingVar({rfrVar:"AV15Delete",rfrProp:"Value",gxAttId:"Delete"});t.addRefreshingVar({rfrVar:"AV15Delete",rfrProp:"Tooltiptext",gxAttId:"Delete"});this.Initialize()});gx.createParentObj(wwprodprecio)