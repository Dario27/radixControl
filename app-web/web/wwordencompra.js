/*!   GeneXus C# 15_0_12-126726 on 11/19/2022 22:54:13.35
*/
gx.evt.autoSkip=!1;gx.define("wwordencompra",!1,function(){var n,t;this.ServerClass="wwordencompra";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV27Pgmname=gx.fn.getControlValue("vPGMNAME");this.AV13OCompFch=gx.fn.getDateValue("vOCOMPFCH");this.AV21usucod=gx.fn.getControlValue("vUSUCOD");this.AV19empID=gx.fn.getIntegerValue("vEMPID",".");this.AV20ageID=gx.fn.getIntegerValue("vAGEID",".");this.AV27Pgmname=gx.fn.getControlValue("vPGMNAME");this.AV13OCompFch=gx.fn.getDateValue("vOCOMPFCH");this.AV21usucod=gx.fn.getControlValue("vUSUCOD")};this.Validv_Ocdesde=function(){try{var n=gx.util.balloon.getNew("vOCDESDE");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Validv_Ochasta=function(){try{var n=gx.util.balloon.getNew("vOCHASTA");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Empid=function(){try{if(gx.fn.currentGridRowImpl(35)===0)return!0;var n=gx.util.balloon.getNew("EMPID",gx.fn.currentGridRowImpl(35));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Ageid=function(){try{if(gx.fn.currentGridRowImpl(35)===0)return!0;var n=gx.util.balloon.getNew("AGEID",gx.fn.currentGridRowImpl(35));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Prvruc=function(){try{if(gx.fn.currentGridRowImpl(35)===0)return!0;var n=gx.util.balloon.getNew("PRVRUC",gx.fn.currentGridRowImpl(35));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Bodcod=function(){try{if(gx.fn.currentGridRowImpl(35)===0)return!0;var n=gx.util.balloon.getNew("BODCOD",gx.fn.currentGridRowImpl(35));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e115a2_client=function(){return this.executeServerEvent("'DOINSERT'",!1,null,!1,!1)};this.e155a2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e165a2_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,26,27,28,29,30,31,32,33,34,36,37,38,39,40,41,42,43,44,45,46,47,48];this.GXLastCtrlId=48;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",35,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"wwordencompra",[],!1,1,!1,!0,0,!0,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.GridContainer;t.addSingleLineEdit(1,36,"EMPID","Emp ID","","EmpID","int",0,"px",4,4,"right",null,[],1,"EmpID",!1,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(44,37,"EMPDSC","Empresa","","empdsc","svchar",0,"px",100,80,"left",null,[],44,"empdsc",!1,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(2,38,"AGEID","Age ID","","AgeID","int",0,"px",4,4,"right",null,[],2,"AgeID",!1,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(46,39,"AGEDSC","Agencia","","AgeDsc","char",0,"px",50,50,"left",null,[],46,"AgeDsc",!1,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(317,40,"OCOMPNRO","Nro","","OCompNro","int",0,"px",4,4,"right",null,[],317,"OCompNro",!0,0,!1,!1,"Attribute",1,"WWActionColumn");t.addSingleLineEdit(340,41,"OCOMPFCHOC","Fecha","","OCompFchOC","date",0,"px",10,10,"right",null,[],340,"OCompFchOC",!0,0,!1,!1,"DescriptionAttribute",1,"WWOptionalColumn");t.addSingleLineEdit(37,42,"PRVRUC","Ruc","","PrvRuc","char",0,"px",13,13,"left",null,[],37,"PrvRuc",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(184,43,"PRVDSC","Proveedor","","PrvDsc","svchar",0,"px",150,80,"left",null,[],184,"PrvDsc",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(311,44,"OCTIPOCOD","Tipo","","OcTipoCod","char",0,"px",3,3,"left",null,[],311,"OcTipoCod",!1,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(42,45,"BODCOD","Bod Cod","","BodCod","int",0,"px",4,4,"right",null,[],42,"BodCod",!1,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(217,46,"BODDSC","Nombre","","BodDsc","char",0,"px",40,40,"left",null,[],217,"BodDsc",!1,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addBitmap("&Update","vUPDATE",47,0,"px",17,"px",null,"","","ImageAttribute","WWActionColumn");t.addBitmap("&Delete","vDELETE",48,0,"px",17,"px",null,"","","ImageAttribute","WWActionColumn");this.GridContainer.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLETOP",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TITLETEXT",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"",grid:0};n[13]={id:13,fld:"BTNINSERT",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,lvl:0,type:"date",len:10,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Ocdesde,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vOCDESDE",gxz:"ZV22ocDesde",gxold:"OV22ocDesde",gxvar:"AV22ocDesde",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV22ocDesde=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV22ocDesde=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vOCDESDE",gx.O.AV22ocDesde,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV22ocDesde=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("vOCDESDE")},nac:gx.falseFn};n[18]={id:18,fld:"",grid:0};n[19]={id:19,lvl:0,type:"date",len:10,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Ochasta,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vOCHASTA",gxz:"ZV23ocHasta",gxold:"OV23ocHasta",gxvar:"AV23ocHasta",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV23ocHasta=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV23ocHasta=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vOCHASTA",gx.O.AV23ocHasta,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV23ocHasta=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("vOCHASTA")},nac:gx.falseFn};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"GRIDCELL",grid:0};n[22]={id:22,fld:"GRIDTABLE",grid:0};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"TBSEARCH",grid:0};n[29]={id:29,fld:"",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,lvl:0,type:"svchar",len:150,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vOCPRVDSC",gxz:"ZV17OcPrvDsc",gxold:"OV17OcPrvDsc",gxvar:"AV17OcPrvDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV17OcPrvDsc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV17OcPrvDsc=n)},v2c:function(){gx.fn.setControlValue("vOCPRVDSC",gx.O.AV17OcPrvDsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV17OcPrvDsc=this.val())},val:function(){return gx.fn.getControlValue("vOCPRVDSC")},nac:gx.falseFn};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[36]={id:36,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:35,gxgrid:this.GridContainer,fnc:this.Valid_Empid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EMPID",gxz:"Z1EmpID",gxold:"O1EmpID",gxvar:"A1EmpID",ucs:[],op:[19,17,46,39,37,43],ip:[46,39,37,43,19,17,45,38,36,42],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A1EmpID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1EmpID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("EMPID",n||gx.fn.currentGridRowImpl(35),gx.O.A1EmpID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A1EmpID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("EMPID",n||gx.fn.currentGridRowImpl(35),".")},nac:gx.falseFn};n[37]={id:37,lvl:2,type:"svchar",len:100,dec:0,sign:!1,pic:"@!",ro:1,isacc:0,grid:35,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EMPDSC",gxz:"Z44empdsc",gxold:"O44empdsc",gxvar:"A44empdsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A44empdsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z44empdsc=n)},v2c:function(n){gx.fn.setGridControlValue("EMPDSC",n||gx.fn.currentGridRowImpl(35),gx.O.A44empdsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A44empdsc=this.val())},val:function(n){return gx.fn.getGridControlValue("EMPDSC",n||gx.fn.currentGridRowImpl(35))},nac:gx.falseFn};n[38]={id:38,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:35,gxgrid:this.GridContainer,fnc:this.Valid_Ageid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"AGEID",gxz:"Z2AgeID",gxold:"O2AgeID",gxvar:"A2AgeID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A2AgeID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z2AgeID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("AGEID",n||gx.fn.currentGridRowImpl(35),gx.O.A2AgeID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A2AgeID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("AGEID",n||gx.fn.currentGridRowImpl(35),".")},nac:gx.falseFn};n[39]={id:39,lvl:2,type:"char",len:50,dec:0,sign:!1,ro:1,isacc:0,grid:35,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"AGEDSC",gxz:"Z46AgeDsc",gxold:"O46AgeDsc",gxvar:"A46AgeDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A46AgeDsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z46AgeDsc=n)},v2c:function(n){gx.fn.setGridControlValue("AGEDSC",n||gx.fn.currentGridRowImpl(35),gx.O.A46AgeDsc,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A46AgeDsc=this.val())},val:function(n){return gx.fn.getGridControlValue("AGEDSC",n||gx.fn.currentGridRowImpl(35))},nac:gx.falseFn};n[40]={id:40,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:35,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"OCOMPNRO",gxz:"Z317OCompNro",gxold:"O317OCompNro",gxvar:"A317OCompNro",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A317OCompNro=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z317OCompNro=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("OCOMPNRO",n||gx.fn.currentGridRowImpl(35),gx.O.A317OCompNro,0)},c2v:function(){this.val()!==undefined&&(gx.O.A317OCompNro=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("OCOMPNRO",n||gx.fn.currentGridRowImpl(35),".")},nac:gx.falseFn};n[41]={id:41,lvl:2,type:"date",len:10,dec:0,sign:!1,ro:1,isacc:0,grid:35,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"OCOMPFCHOC",gxz:"Z340OCompFchOC",gxold:"O340OCompFchOC",gxvar:"A340OCompFchOC",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A340OCompFchOC=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z340OCompFchOC=gx.fn.toDatetimeValue(n))},v2c:function(n){gx.fn.setGridControlValue("OCOMPFCHOC",n||gx.fn.currentGridRowImpl(35),gx.O.A340OCompFchOC,0)},c2v:function(){this.val()!==undefined&&(gx.O.A340OCompFchOC=gx.fn.toDatetimeValue(this.val()))},val:function(n){return gx.fn.getGridDateTimeValue("OCOMPFCHOC",n||gx.fn.currentGridRowImpl(35))},nac:gx.falseFn};n[42]={id:42,lvl:2,type:"char",len:13,dec:0,sign:!1,ro:1,isacc:0,grid:35,gxgrid:this.GridContainer,fnc:this.Valid_Prvruc,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PRVRUC",gxz:"Z37PrvRuc",gxold:"O37PrvRuc",gxvar:"A37PrvRuc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A37PrvRuc=n)},v2z:function(n){n!==undefined&&(gx.O.Z37PrvRuc=n)},v2c:function(n){gx.fn.setGridControlValue("PRVRUC",n||gx.fn.currentGridRowImpl(35),gx.O.A37PrvRuc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A37PrvRuc=this.val())},val:function(n){return gx.fn.getGridControlValue("PRVRUC",n||gx.fn.currentGridRowImpl(35))},nac:gx.falseFn};n[43]={id:43,lvl:2,type:"svchar",len:150,dec:0,sign:!1,ro:1,isacc:0,grid:35,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PRVDSC",gxz:"Z184PrvDsc",gxold:"O184PrvDsc",gxvar:"A184PrvDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A184PrvDsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z184PrvDsc=n)},v2c:function(n){gx.fn.setGridControlValue("PRVDSC",n||gx.fn.currentGridRowImpl(35),gx.O.A184PrvDsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A184PrvDsc=this.val())},val:function(n){return gx.fn.getGridControlValue("PRVDSC",n||gx.fn.currentGridRowImpl(35))},nac:gx.falseFn};n[44]={id:44,lvl:2,type:"char",len:3,dec:0,sign:!1,ro:1,isacc:0,grid:35,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"OCTIPOCOD",gxz:"Z311OcTipoCod",gxold:"O311OcTipoCod",gxvar:"A311OcTipoCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A311OcTipoCod=n)},v2z:function(n){n!==undefined&&(gx.O.Z311OcTipoCod=n)},v2c:function(n){gx.fn.setGridControlValue("OCTIPOCOD",n||gx.fn.currentGridRowImpl(35),gx.O.A311OcTipoCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A311OcTipoCod=this.val())},val:function(n){return gx.fn.getGridControlValue("OCTIPOCOD",n||gx.fn.currentGridRowImpl(35))},nac:gx.falseFn};n[45]={id:45,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:35,gxgrid:this.GridContainer,fnc:this.Valid_Bodcod,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BODCOD",gxz:"Z42BodCod",gxold:"O42BodCod",gxvar:"A42BodCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A42BodCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z42BodCod=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("BODCOD",n||gx.fn.currentGridRowImpl(35),gx.O.A42BodCod,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A42BodCod=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("BODCOD",n||gx.fn.currentGridRowImpl(35),".")},nac:gx.falseFn};n[46]={id:46,lvl:2,type:"char",len:40,dec:0,sign:!1,pic:"@!",ro:1,isacc:0,grid:35,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BODDSC",gxz:"Z217BodDsc",gxold:"O217BodDsc",gxvar:"A217BodDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A217BodDsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z217BodDsc=n)},v2c:function(n){gx.fn.setGridControlValue("BODDSC",n||gx.fn.currentGridRowImpl(35),gx.O.A217BodDsc,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A217BodDsc=this.val())},val:function(n){return gx.fn.getGridControlValue("BODDSC",n||gx.fn.currentGridRowImpl(35))},nac:gx.falseFn};n[47]={id:47,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:35,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV14Update",gxold:"OV14Update",gxvar:"AV14Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV14Update=n)},v2z:function(n){n!==undefined&&(gx.O.ZV14Update=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vUPDATE",n||gx.fn.currentGridRowImpl(35),gx.O.AV14Update,gx.O.AV28Update_GXI)},c2v:function(){gx.O.AV28Update_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV14Update=this.val())},val:function(n){return gx.fn.getGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(35))},val_GXI:function(n){return gx.fn.getGridControlValue("vUPDATE_GXI",n||gx.fn.currentGridRowImpl(35))},gxvar_GXI:"AV28Update_GXI",nac:gx.falseFn};n[48]={id:48,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:35,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV15Delete",gxold:"OV15Delete",gxvar:"AV15Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV15Delete=n)},v2z:function(n){n!==undefined&&(gx.O.ZV15Delete=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vDELETE",n||gx.fn.currentGridRowImpl(35),gx.O.AV15Delete,gx.O.AV29Delete_GXI)},c2v:function(){gx.O.AV29Delete_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV15Delete=this.val())},val:function(n){return gx.fn.getGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(35))},val_GXI:function(n){return gx.fn.getGridControlValue("vDELETE_GXI",n||gx.fn.currentGridRowImpl(35))},gxvar_GXI:"AV29Delete_GXI",nac:gx.falseFn};this.AV22ocDesde=gx.date.nullDate();this.ZV22ocDesde=gx.date.nullDate();this.OV22ocDesde=gx.date.nullDate();this.AV23ocHasta=gx.date.nullDate();this.ZV23ocHasta=gx.date.nullDate();this.OV23ocHasta=gx.date.nullDate();this.AV17OcPrvDsc="";this.ZV17OcPrvDsc="";this.OV17OcPrvDsc="";this.Z1EmpID=0;this.O1EmpID=0;this.Z44empdsc="";this.O44empdsc="";this.Z2AgeID=0;this.O2AgeID=0;this.Z46AgeDsc="";this.O46AgeDsc="";this.Z317OCompNro=0;this.O317OCompNro=0;this.Z340OCompFchOC=gx.date.nullDate();this.O340OCompFchOC=gx.date.nullDate();this.Z37PrvRuc="";this.O37PrvRuc="";this.Z184PrvDsc="";this.O184PrvDsc="";this.Z311OcTipoCod="";this.O311OcTipoCod="";this.Z42BodCod=0;this.O42BodCod=0;this.Z217BodDsc="";this.O217BodDsc="";this.ZV14Update="";this.OV14Update="";this.ZV15Delete="";this.OV15Delete="";this.AV22ocDesde=gx.date.nullDate();this.AV23ocHasta=gx.date.nullDate();this.AV17OcPrvDsc="";this.AV19empID=0;this.AV20ageID=0;this.AV21usucod="";this.A1EmpID=0;this.A44empdsc="";this.A2AgeID=0;this.A46AgeDsc="";this.A317OCompNro=0;this.A340OCompFchOC=gx.date.nullDate();this.A37PrvRuc="";this.A184PrvDsc="";this.A311OcTipoCod="";this.A42BodCod=0;this.A217BodDsc="";this.AV14Update="";this.AV15Delete="";this.AV27Pgmname="";this.AV13OCompFch=gx.date.nullDate();this.Events={e115a2_client:["'DOINSERT'",!0],e155a2_client:["ENTER",!0],e165a2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV22ocDesde",fld:"vOCDESDE",pic:""},{av:"AV23ocHasta",fld:"vOCHASTA",pic:""},{av:"AV17OcPrvDsc",fld:"vOCPRVDSC",pic:""},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"AV27Pgmname",fld:"vPGMNAME",pic:""},{av:"AV21usucod",fld:"vUSUCOD",pic:"",hsh:!0},{av:"AV19empID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{av:"AV20ageID",fld:"vAGEID",pic:"ZZZ9",hsh:!0},{av:"AV13OCompFch",fld:"vOCOMPFCH",pic:"",hsh:!0}],[]];this.EvtParms.START=[[{av:"AV27Pgmname",fld:"vPGMNAME",pic:""}],[{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{ctrl:"FORM",prop:"Caption"},{av:"AV22ocDesde",fld:"vOCDESDE",pic:""},{av:"AV23ocHasta",fld:"vOCHASTA",pic:""},{av:"AV13OCompFch",fld:"vOCOMPFCH",pic:"",hsh:!0}]];this.EvtParms["GRID.LOAD"]=[[{av:"A1EmpID",fld:"EMPID",pic:"ZZZ9"},{av:"A2AgeID",fld:"AGEID",pic:"ZZZ9"},{av:"A317OCompNro",fld:"OCOMPNRO",pic:"ZZZ9",hsh:!0},{av:"A311OcTipoCod",fld:"OCTIPOCOD",pic:"",hsh:!0},{av:"AV21usucod",fld:"vUSUCOD",pic:"",hsh:!0}],[{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:"vUPDATE",prop:"Link"},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:"vDELETE",prop:"Link"}]];this.EvtParms["'DOINSERT'"]=[[{av:"AV19empID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{av:"AV20ageID",fld:"vAGEID",pic:"ZZZ9",hsh:!0},{av:"A317OCompNro",fld:"OCOMPNRO",pic:"ZZZ9",hsh:!0},{av:"A311OcTipoCod",fld:"OCTIPOCOD",pic:"",hsh:!0},{av:"AV21usucod",fld:"vUSUCOD",pic:"",hsh:!0}],[]];this.EvtParms.GRID_FIRSTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV22ocDesde",fld:"vOCDESDE",pic:""},{av:"AV23ocHasta",fld:"vOCHASTA",pic:""},{av:"AV17OcPrvDsc",fld:"vOCPRVDSC",pic:""},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"AV21usucod",fld:"vUSUCOD",pic:"",hsh:!0},{av:"AV19empID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{av:"AV20ageID",fld:"vAGEID",pic:"ZZZ9",hsh:!0},{av:"AV27Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13OCompFch",fld:"vOCOMPFCH",pic:"",hsh:!0}],[]];this.EvtParms.GRID_PREVPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV22ocDesde",fld:"vOCDESDE",pic:""},{av:"AV23ocHasta",fld:"vOCHASTA",pic:""},{av:"AV17OcPrvDsc",fld:"vOCPRVDSC",pic:""},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"AV21usucod",fld:"vUSUCOD",pic:"",hsh:!0},{av:"AV19empID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{av:"AV20ageID",fld:"vAGEID",pic:"ZZZ9",hsh:!0},{av:"AV27Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13OCompFch",fld:"vOCOMPFCH",pic:"",hsh:!0}],[]];this.EvtParms.GRID_NEXTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV22ocDesde",fld:"vOCDESDE",pic:""},{av:"AV23ocHasta",fld:"vOCHASTA",pic:""},{av:"AV17OcPrvDsc",fld:"vOCPRVDSC",pic:""},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"AV21usucod",fld:"vUSUCOD",pic:"",hsh:!0},{av:"AV19empID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{av:"AV20ageID",fld:"vAGEID",pic:"ZZZ9",hsh:!0},{av:"AV27Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13OCompFch",fld:"vOCOMPFCH",pic:"",hsh:!0}],[]];this.EvtParms.GRID_LASTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV22ocDesde",fld:"vOCDESDE",pic:""},{av:"AV23ocHasta",fld:"vOCHASTA",pic:""},{av:"AV17OcPrvDsc",fld:"vOCPRVDSC",pic:""},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:"vDELETE",prop:"Tooltiptext"},{av:"AV21usucod",fld:"vUSUCOD",pic:"",hsh:!0},{av:"AV19empID",fld:"vEMPID",pic:"ZZZ9",hsh:!0},{av:"AV20ageID",fld:"vAGEID",pic:"ZZZ9",hsh:!0},{av:"AV27Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13OCompFch",fld:"vOCOMPFCH",pic:"",hsh:!0}],[]];this.setVCMap("AV27Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("AV13OCompFch","vOCOMPFCH",0,"date",8,0);this.setVCMap("AV21usucod","vUSUCOD",0,"char",15,0);this.setVCMap("AV19empID","vEMPID",0,"int",4,0);this.setVCMap("AV20ageID","vAGEID",0,"int",4,0);this.setVCMap("AV27Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("AV13OCompFch","vOCOMPFCH",0,"date",8,0);this.setVCMap("AV21usucod","vUSUCOD",0,"char",15,0);this.setVCMap("AV27Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("AV13OCompFch","vOCOMPFCH",0,"date",8,0);this.setVCMap("AV21usucod","vUSUCOD",0,"char",15,0);t.addRefreshingVar(this.GXValidFnc[17]);t.addRefreshingVar(this.GXValidFnc[19]);t.addRefreshingVar(this.GXValidFnc[32]);t.addRefreshingVar({rfrVar:"AV27Pgmname"});t.addRefreshingVar({rfrVar:"AV13OCompFch"});t.addRefreshingVar({rfrVar:"AV14Update",rfrProp:"Value",gxAttId:"Update"});t.addRefreshingVar({rfrVar:"AV14Update",rfrProp:"Tooltiptext",gxAttId:"Update"});t.addRefreshingVar({rfrVar:"AV15Delete",rfrProp:"Value",gxAttId:"Delete"});t.addRefreshingVar({rfrVar:"AV15Delete",rfrProp:"Tooltiptext",gxAttId:"Delete"});t.addRefreshingVar({rfrVar:"AV21usucod"});t.addRefreshingVar({rfrVar:"AV19empID"});t.addRefreshingVar({rfrVar:"AV20ageID"});this.Initialize()});gx.createParentObj(wwordencompra)