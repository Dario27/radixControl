/*!   GeneXus C# 15_0_12-126726 on 11/27/2022 10:59:12.95
*/
gx.evt.autoSkip=!1;gx.define("wcpedidosop",!0,function(n){var t,i;this.ServerClass="wcpedidosop";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.A359DespBodADesp=gx.fn.getIntegerValue("DESPBODADESP",".");this.A1EmpID=gx.fn.getIntegerValue("EMPID",".");this.A2AgeID=gx.fn.getIntegerValue("AGEID",".");this.A42BodCod=gx.fn.getIntegerValue("BODCOD",".");this.AV7EmpID=gx.fn.getIntegerValue("vEMPID",".");this.AV6AgeID=gx.fn.getIntegerValue("vAGEID",".");this.AV8DespBodOpId=gx.fn.getIntegerValue("vDESPBODOPID",".");this.AV7EmpID=gx.fn.getIntegerValue("vEMPID",".");this.AV6AgeID=gx.fn.getIntegerValue("vAGEID",".");this.AV8DespBodOpId=gx.fn.getIntegerValue("vDESPBODOPID",".")};this.Valid_Despbodcodprd=function(){try{if(gx.fn.currentGridRowImpl(19)===0)return!0;var n=gx.util.balloon.getNew("DESPBODCODPRD",gx.fn.currentGridRowImpl(19));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Despbodcant=function(){try{if(gx.fn.currentGridRowImpl(19)===0)return!0;var n=gx.util.balloon.getNew("DESPBODCANT",gx.fn.currentGridRowImpl(19));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e115l2_client=function(){return this.executeServerEvent("'GENERARPEDOP'",!1,null,!1,!1)};this.e135l2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e145l2_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,16,17,18,20,21,22,23,24,25,26,27];this.GXLastCtrlId=27;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",19,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"wcpedidosop",[],!1,1,!1,!0,0,!1,!1,!1,"",0,"px",0,"px","Nueva fila",!1,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);i=this.Grid1Container;i.addSingleLineEdit(353,20,"DESPBODNRO","Nro","","DespBodNro","int",0,"px",4,4,"right",null,[],353,"DespBodNro",!0,0,!1,!1,"Attribute",1,"");i.addSingleLineEdit(355,21,"DESPBODCODPRD","Codigo","","DespBodCodPrd","int",0,"px",4,4,"right",null,[],355,"DespBodCodPrd",!0,0,!1,!1,"Attribute",1,"");i.addSingleLineEdit(356,22,"DESPBODPRDNOMBRE","Producto","","DespBodPrdNombre","char",0,"px",40,40,"left",null,[],356,"DespBodPrdNombre",!0,0,!1,!1,"Attribute",1,"");i.addSingleLineEdit(357,23,"DESPBODCANT","Cantidad","","DespBodCant","int",0,"px",6,6,"right",null,[],357,"DespBodCant",!0,0,!1,!1,"Attribute",1,"");i.addSingleLineEdit(358,24,"DESPBODVALOR","Valor","","DespBodValor","decimal",0,"px",8,8,"right",null,[],358,"DespBodValor",!0,2,!1,!1,"Attribute",1,"");i.addSingleLineEdit("Despbodadesp",25,"vDESPBODADESP","A Despachar","","DespBodADesp","int",0,"px",8,8,"right",null,[],"Despbodadesp","DespBodADesp",!0,0,!1,!1,"Attribute",1,"");i.addSingleLineEdit(362,26,"DESPBODDIF","Dif.","","DespBodDif","int",0,"px",4,4,"right",null,[],362,"DespBodDif",!0,0,!1,!1,"Attribute",1,"");i.addSingleLineEdit(360,27,"DESPBODSTOCK","Stock","","DespBodStock","decimal",0,"px",6,6,"right",null,[],360,"DespBodStock",!0,2,!1,!1,"Attribute",1,"");this.Grid1Container.emptyText="";this.setGrid(i);t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"TABLE1",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,fld:"",grid:0};t[12]={id:12,fld:"TBFLX",grid:0};t[13]={id:13,fld:"",grid:0};t[14]={id:14,fld:"GENERARPEDOP",grid:0};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"GENERARINV",grid:0};t[17]={id:17,fld:"",grid:0};t[18]={id:18,fld:"",grid:0};t[20]={id:20,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:19,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DESPBODNRO",gxz:"Z353DespBodNro",gxold:"O353DespBodNro",gxvar:"A353DespBodNro",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A353DespBodNro=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z353DespBodNro=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("DESPBODNRO",n||gx.fn.currentGridRowImpl(19),gx.O.A353DespBodNro,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A353DespBodNro=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("DESPBODNRO",n||gx.fn.currentGridRowImpl(19),".")},nac:gx.falseFn};t[21]={id:21,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:19,gxgrid:this.Grid1Container,fnc:this.Valid_Despbodcodprd,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DESPBODCODPRD",gxz:"Z355DespBodCodPrd",gxold:"O355DespBodCodPrd",gxvar:"A355DespBodCodPrd",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A355DespBodCodPrd=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z355DespBodCodPrd=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("DESPBODCODPRD",n||gx.fn.currentGridRowImpl(19),gx.O.A355DespBodCodPrd,0)},c2v:function(){this.val()!==undefined&&(gx.O.A355DespBodCodPrd=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("DESPBODCODPRD",n||gx.fn.currentGridRowImpl(19),".")},nac:gx.falseFn};t[22]={id:22,lvl:2,type:"char",len:40,dec:0,sign:!1,pic:"@!",ro:1,isacc:0,grid:19,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DESPBODPRDNOMBRE",gxz:"Z356DespBodPrdNombre",gxold:"O356DespBodPrdNombre",gxvar:"A356DespBodPrdNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A356DespBodPrdNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z356DespBodPrdNombre=n)},v2c:function(n){gx.fn.setGridControlValue("DESPBODPRDNOMBRE",n||gx.fn.currentGridRowImpl(19),gx.O.A356DespBodPrdNombre,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A356DespBodPrdNombre=this.val())},val:function(n){return gx.fn.getGridControlValue("DESPBODPRDNOMBRE",n||gx.fn.currentGridRowImpl(19))},nac:gx.falseFn};t[23]={id:23,lvl:2,type:"int",len:6,dec:0,sign:!1,pic:"ZZZZZ9",ro:1,isacc:0,grid:19,gxgrid:this.Grid1Container,fnc:this.Valid_Despbodcant,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DESPBODCANT",gxz:"Z357DespBodCant",gxold:"O357DespBodCant",gxvar:"A357DespBodCant",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A357DespBodCant=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z357DespBodCant=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("DESPBODCANT",n||gx.fn.currentGridRowImpl(19),gx.O.A357DespBodCant,0)},c2v:function(){this.val()!==undefined&&(gx.O.A357DespBodCant=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("DESPBODCANT",n||gx.fn.currentGridRowImpl(19),".")},nac:gx.falseFn};t[24]={id:24,lvl:2,type:"decimal",len:8,dec:2,sign:!1,pic:"ZZZZ9.99",ro:1,isacc:0,grid:19,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DESPBODVALOR",gxz:"Z358DespBodValor",gxold:"O358DespBodValor",gxvar:"A358DespBodValor",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A358DespBodValor=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z358DespBodValor=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("DESPBODVALOR",n||gx.fn.currentGridRowImpl(19),gx.O.A358DespBodValor,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A358DespBodValor=this.val())},val:function(n){return gx.fn.getGridDecimalValue("DESPBODVALOR",n||gx.fn.currentGridRowImpl(19),".",",")},nac:gx.falseFn};t[25]={id:25,lvl:2,type:"int",len:8,dec:0,sign:!1,pic:"ZZZZZZZ9",ro:1,isacc:0,grid:19,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDESPBODADESP",gxz:"ZV5DespBodADesp",gxold:"OV5DespBodADesp",gxvar:"AV5DespBodADesp",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.AV5DespBodADesp=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV5DespBodADesp=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("vDESPBODADESP",n||gx.fn.currentGridRowImpl(19),gx.O.AV5DespBodADesp,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV5DespBodADesp=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("vDESPBODADESP",n||gx.fn.currentGridRowImpl(19),".")},nac:gx.falseFn};t[26]={id:26,lvl:2,type:"int",len:4,dec:0,sign:!0,pic:"ZZZ9",ro:1,isacc:0,grid:19,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DESPBODDIF",gxz:"Z362DespBodDif",gxold:"O362DespBodDif",gxvar:"A362DespBodDif",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A362DespBodDif=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z362DespBodDif=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("DESPBODDIF",n||gx.fn.currentGridRowImpl(19),gx.O.A362DespBodDif,0)},c2v:function(){this.val()!==undefined&&(gx.O.A362DespBodDif=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("DESPBODDIF",n||gx.fn.currentGridRowImpl(19),".")},nac:gx.falseFn};t[27]={id:27,lvl:2,type:"decimal",len:6,dec:2,sign:!1,pic:"ZZ9.99",ro:1,isacc:0,grid:19,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DESPBODSTOCK",gxz:"Z360DespBodStock",gxold:"O360DespBodStock",gxvar:"A360DespBodStock",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A360DespBodStock=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z360DespBodStock=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("DESPBODSTOCK",n||gx.fn.currentGridRowImpl(19),gx.O.A360DespBodStock,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A360DespBodStock=this.val())},val:function(n){return gx.fn.getGridDecimalValue("DESPBODSTOCK",n||gx.fn.currentGridRowImpl(19),".",",")},nac:gx.falseFn};this.Z353DespBodNro=0;this.O353DespBodNro=0;this.Z355DespBodCodPrd=0;this.O355DespBodCodPrd=0;this.Z356DespBodPrdNombre="";this.O356DespBodPrdNombre="";this.Z357DespBodCant=0;this.O357DespBodCant=0;this.Z358DespBodValor=0;this.O358DespBodValor=0;this.ZV5DespBodADesp=0;this.OV5DespBodADesp=0;this.Z362DespBodDif=0;this.O362DespBodDif=0;this.Z360DespBodStock=0;this.O360DespBodStock=0;this.AV7EmpID=0;this.AV6AgeID=0;this.AV8DespBodOpId=0;this.A354DespBodOpId=0;this.A359DespBodADesp=0;this.A42BodCod=0;this.A2AgeID=0;this.A1EmpID=0;this.A353DespBodNro=0;this.A355DespBodCodPrd=0;this.A356DespBodPrdNombre="";this.A357DespBodCant=0;this.A358DespBodValor=0;this.AV5DespBodADesp=0;this.A362DespBodDif=0;this.A360DespBodStock=0;this.Events={e115l2_client:["'GENERARPEDOP'",!0],e135l2_client:["ENTER",!0],e145l2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{av:"AV7EmpID",fld:"vEMPID",pic:"ZZZ9"},{av:"AV6AgeID",fld:"vAGEID",pic:"ZZZ9"},{av:"AV8DespBodOpId",fld:"vDESPBODOPID",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.EvtParms["'GENERARPEDOP'"]=[[{av:"AV7EmpID",fld:"vEMPID",pic:"ZZZ9"},{av:"AV6AgeID",fld:"vAGEID",pic:"ZZZ9"},{av:"AV8DespBodOpId",fld:"vDESPBODOPID",pic:"ZZZ9"}],[]];this.setVCMap("A359DespBodADesp","DESPBODADESP",0,"int",8,0);this.setVCMap("A1EmpID","EMPID",0,"int",4,0);this.setVCMap("A2AgeID","AGEID",0,"int",4,0);this.setVCMap("A42BodCod","BODCOD",0,"int",4,0);this.setVCMap("AV7EmpID","vEMPID",0,"int",4,0);this.setVCMap("AV6AgeID","vAGEID",0,"int",4,0);this.setVCMap("AV8DespBodOpId","vDESPBODOPID",0,"int",4,0);this.setVCMap("AV7EmpID","vEMPID",0,"int",4,0);this.setVCMap("AV6AgeID","vAGEID",0,"int",4,0);this.setVCMap("AV8DespBodOpId","vDESPBODOPID",0,"int",4,0);this.setVCMap("AV7EmpID","vEMPID",0,"int",4,0);this.setVCMap("AV6AgeID","vAGEID",0,"int",4,0);this.setVCMap("AV8DespBodOpId","vDESPBODOPID",0,"int",4,0);i.addRefreshingVar({rfrVar:"AV7EmpID"});i.addRefreshingVar({rfrVar:"AV6AgeID"});i.addRefreshingVar({rfrVar:"AV8DespBodOpId"});this.Initialize()})