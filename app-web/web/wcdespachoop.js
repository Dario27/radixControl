/*!   GeneXus C# 15_0_12-126726 on 1/19/2023 22:34:3.58
*/
gx.evt.autoSkip=!1;gx.define("wcdespachoop",!0,function(n){var t,i;this.ServerClass="wcdespachoop";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.A1EmpID=gx.fn.getIntegerValue("EMPID",".");this.A2AgeID=gx.fn.getIntegerValue("AGEID",".");this.A42BodCod=gx.fn.getIntegerValue("BODCOD",".");this.AV7EmpID=gx.fn.getIntegerValue("vEMPID",".");this.AV6AgeID=gx.fn.getIntegerValue("vAGEID",".");this.AV16ClienteID=gx.fn.getIntegerValue("vCLIENTEID",".");this.AV17OrdenPeriodo=gx.fn.getIntegerValue("vORDENPERIODO",".");this.AV18OrdenAnio=gx.fn.getIntegerValue("vORDENANIO",".");this.AV8DespBodOpId=gx.fn.getIntegerValue("vDESPBODOPID",".");this.AV7EmpID=gx.fn.getIntegerValue("vEMPID",".");this.AV6AgeID=gx.fn.getIntegerValue("vAGEID",".");this.AV8DespBodOpId=gx.fn.getIntegerValue("vDESPBODOPID",".")};this.Valid_Despbodcodprd=function(){try{if(gx.fn.currentGridRowImpl(19)===0)return!0;var n=gx.util.balloon.getNew("DESPBODCODPRD",gx.fn.currentGridRowImpl(19));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Despbodcant=function(){try{if(gx.fn.currentGridRowImpl(19)===0)return!0;var n=gx.util.balloon.getNew("DESPBODCANT",gx.fn.currentGridRowImpl(19));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Despbodadesp=function(){try{if(gx.fn.currentGridRowImpl(19)===0)return!0;var n=gx.util.balloon.getNew("DESPBODADESP",gx.fn.currentGridRowImpl(19));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e115l1_client=function(){return this.clearMessages(),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e155l2_client=function(){return this.clearMessages(),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e125l1_client=function(){return this.clearMessages(),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e165l2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e175l2_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,16,17,18,20,21,22,23,24,25,26,27,28,29,30,31];this.GXLastCtrlId=31;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",19,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"wcdespachoop",[],!1,1,!1,!0,0,!1,!1,!1,"",0,"px",0,"px","Nueva fila",!1,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);i=this.Grid1Container;i.addCheckBox("Select",20,"vSELECT","","","select","int",1,0,null,!0,!1,40,"px","WWColumn WWOptionalColumn");i.addSingleLineEdit(400,21,"NROREG","Nro","","nroReg","int",50,"px",6,6,"right",null,[],400,"nroReg",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(355,22,"DESPBODCODPRD","Codigo","","DespBodCodPrd","int",65,"px",4,4,"right",null,[],355,"DespBodCodPrd",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(356,23,"DESPBODPRDNOMBRE","Producto","","DespBodPrdNombre","char",270,"px",40,40,"left",null,[],356,"DespBodPrdNombre",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(357,24,"DESPBODCANT","Cant.","","DespBodCant","decimal",80,"px",8,8,"right",null,[],357,"DespBodCant",!0,2,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(358,25,"DESPBODVALOR","Valor","","DespBodValor","decimal",80,"px",8,8,"right",null,[],358,"DespBodValor",!0,2,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit("Despbodadesp",26,"vDESPBODADESP","A Desp.","","DespBodADesp","decimal",0,"px",8,8,"right",null,[],"Despbodadesp","DespBodADesp",!0,2,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(362,27,"DESPBODDIF","Dif.","","DespBodDif","int",60,"px",4,4,"right",null,[],362,"DespBodDif",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(359,28,"DESPBODADESP","Desp.","","DespBodADesp","decimal",60,"px",8,8,"right",null,[],359,"DespBodADesp",!0,2,!1,!1,"AttributeBold",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(360,29,"DESPBODSTOCK","Stock","","DespBodStock","decimal",0,"px",6,6,"right",null,[],360,"DespBodStock",!0,2,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(376,30,"DESPBODDETALLE","Detalle","","DespBodDetalle","char",0,"px",50,50,"left",null,[],376,"DespBodDetalle",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addBitmap("&Despachado","vDESPACHADO",31,0,"px",17,"px",null,"","","ImageAttribute","WWActionColumn");this.Grid1Container.emptyText="No hay Data";this.setGrid(i);t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"TABLE1",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,fld:"",grid:0};t[12]={id:12,fld:"TBFLX",grid:0};t[13]={id:13,fld:"",grid:0};t[14]={id:14,fld:"ADDDESPOP",grid:0};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"GENERARINV",grid:0};t[17]={id:17,fld:"",grid:0};t[18]={id:18,fld:"",grid:0};t[20]={id:20,lvl:2,type:"int",len:1,dec:0,sign:!1,pic:"9",ro:1,isacc:0,grid:19,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSELECT",gxz:"ZV20select",gxold:"OV20select",gxvar:"AV20select",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.AV20select=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV20select=gx.num.intval(n))},v2c:function(n){gx.fn.setGridCheckBoxValue("vSELECT",n||gx.fn.currentGridRowImpl(19),gx.O.AV20select,"1")},c2v:function(){this.val()!==undefined&&(gx.O.AV20select=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("vSELECT",n||gx.fn.currentGridRowImpl(19),".")},nac:gx.falseFn,values:[1,0]};t[21]={id:21,lvl:2,type:"int",len:6,dec:0,sign:!1,pic:"ZZZZZ9",ro:1,isacc:0,grid:19,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"NROREG",gxz:"Z400nroReg",gxold:"O400nroReg",gxvar:"A400nroReg",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A400nroReg=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z400nroReg=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("NROREG",n||gx.fn.currentGridRowImpl(19),gx.O.A400nroReg,0)},c2v:function(){this.val()!==undefined&&(gx.O.A400nroReg=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("NROREG",n||gx.fn.currentGridRowImpl(19),".")},nac:gx.falseFn};t[22]={id:22,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:19,gxgrid:this.Grid1Container,fnc:this.Valid_Despbodcodprd,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DESPBODCODPRD",gxz:"Z355DespBodCodPrd",gxold:"O355DespBodCodPrd",gxvar:"A355DespBodCodPrd",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A355DespBodCodPrd=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z355DespBodCodPrd=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("DESPBODCODPRD",n||gx.fn.currentGridRowImpl(19),gx.O.A355DespBodCodPrd,0)},c2v:function(){this.val()!==undefined&&(gx.O.A355DespBodCodPrd=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("DESPBODCODPRD",n||gx.fn.currentGridRowImpl(19),".")},nac:gx.falseFn};t[23]={id:23,lvl:2,type:"char",len:40,dec:0,sign:!1,pic:"@!",ro:1,isacc:0,grid:19,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DESPBODPRDNOMBRE",gxz:"Z356DespBodPrdNombre",gxold:"O356DespBodPrdNombre",gxvar:"A356DespBodPrdNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A356DespBodPrdNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z356DespBodPrdNombre=n)},v2c:function(n){gx.fn.setGridControlValue("DESPBODPRDNOMBRE",n||gx.fn.currentGridRowImpl(19),gx.O.A356DespBodPrdNombre,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A356DespBodPrdNombre=this.val())},val:function(n){return gx.fn.getGridControlValue("DESPBODPRDNOMBRE",n||gx.fn.currentGridRowImpl(19))},nac:gx.falseFn};t[24]={id:24,lvl:2,type:"decimal",len:8,dec:2,sign:!1,pic:"ZZZZ9.99",ro:1,isacc:0,grid:19,gxgrid:this.Grid1Container,fnc:this.Valid_Despbodcant,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DESPBODCANT",gxz:"Z357DespBodCant",gxold:"O357DespBodCant",gxvar:"A357DespBodCant",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A357DespBodCant=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z357DespBodCant=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("DESPBODCANT",n||gx.fn.currentGridRowImpl(19),gx.O.A357DespBodCant,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A357DespBodCant=this.val())},val:function(n){return gx.fn.getGridDecimalValue("DESPBODCANT",n||gx.fn.currentGridRowImpl(19),".",",")},nac:gx.falseFn};t[25]={id:25,lvl:2,type:"decimal",len:8,dec:2,sign:!1,pic:"ZZZZ9.99",ro:1,isacc:0,grid:19,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DESPBODVALOR",gxz:"Z358DespBodValor",gxold:"O358DespBodValor",gxvar:"A358DespBodValor",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A358DespBodValor=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z358DespBodValor=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("DESPBODVALOR",n||gx.fn.currentGridRowImpl(19),gx.O.A358DespBodValor,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A358DespBodValor=this.val())},val:function(n){return gx.fn.getGridDecimalValue("DESPBODVALOR",n||gx.fn.currentGridRowImpl(19),".",",")},nac:gx.falseFn};t[26]={id:26,lvl:2,type:"decimal",len:8,dec:2,sign:!1,pic:"ZZZZ9.99",ro:1,isacc:0,grid:19,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:"e155l2_client",evt_cvcing:null,rgrid:[],fld:"vDESPBODADESP",gxz:"ZV5DespBodADesp",gxold:"OV5DespBodADesp",gxvar:"AV5DespBodADesp",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5DespBodADesp=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.ZV5DespBodADesp=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("vDESPBODADESP",n||gx.fn.currentGridRowImpl(19),gx.O.AV5DespBodADesp,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.AV5DespBodADesp=this.val())},val:function(n){return gx.fn.getGridDecimalValue("vDESPBODADESP",n||gx.fn.currentGridRowImpl(19),".",",")},nac:gx.falseFn};t[27]={id:27,lvl:2,type:"int",len:4,dec:0,sign:!0,pic:"ZZZ9",ro:1,isacc:0,grid:19,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DESPBODDIF",gxz:"Z362DespBodDif",gxold:"O362DespBodDif",gxvar:"A362DespBodDif",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A362DespBodDif=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z362DespBodDif=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("DESPBODDIF",n||gx.fn.currentGridRowImpl(19),gx.O.A362DespBodDif,0)},c2v:function(){this.val()!==undefined&&(gx.O.A362DespBodDif=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("DESPBODDIF",n||gx.fn.currentGridRowImpl(19),".")},nac:gx.falseFn};t[28]={id:28,lvl:2,type:"decimal",len:8,dec:2,sign:!1,pic:"ZZZZ9.99",ro:1,isacc:0,grid:19,gxgrid:this.Grid1Container,fnc:this.Valid_Despbodadesp,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DESPBODADESP",gxz:"Z359DespBodADesp",gxold:"O359DespBodADesp",gxvar:"A359DespBodADesp",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A359DespBodADesp=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z359DespBodADesp=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("DESPBODADESP",n||gx.fn.currentGridRowImpl(19),gx.O.A359DespBodADesp,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A359DespBodADesp=this.val())},val:function(n){return gx.fn.getGridDecimalValue("DESPBODADESP",n||gx.fn.currentGridRowImpl(19),".",",")},nac:gx.falseFn};t[29]={id:29,lvl:2,type:"decimal",len:6,dec:2,sign:!1,pic:"ZZ9.99",ro:1,isacc:0,grid:19,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DESPBODSTOCK",gxz:"Z360DespBodStock",gxold:"O360DespBodStock",gxvar:"A360DespBodStock",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A360DespBodStock=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z360DespBodStock=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("DESPBODSTOCK",n||gx.fn.currentGridRowImpl(19),gx.O.A360DespBodStock,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A360DespBodStock=this.val())},val:function(n){return gx.fn.getGridDecimalValue("DESPBODSTOCK",n||gx.fn.currentGridRowImpl(19),".",",")},nac:gx.falseFn};t[30]={id:30,lvl:2,type:"char",len:50,dec:0,sign:!1,ro:1,isacc:0,grid:19,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DESPBODDETALLE",gxz:"Z376DespBodDetalle",gxold:"O376DespBodDetalle",gxvar:"A376DespBodDetalle",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A376DespBodDetalle=n)},v2z:function(n){n!==undefined&&(gx.O.Z376DespBodDetalle=n)},v2c:function(n){gx.fn.setGridControlValue("DESPBODDETALLE",n||gx.fn.currentGridRowImpl(19),gx.O.A376DespBodDetalle,0)},c2v:function(){this.val()!==undefined&&(gx.O.A376DespBodDetalle=this.val())},val:function(n){return gx.fn.getGridControlValue("DESPBODDETALLE",n||gx.fn.currentGridRowImpl(19))},nac:gx.falseFn};t[31]={id:31,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:19,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDESPACHADO",gxz:"ZV23despachado",gxold:"OV23despachado",gxvar:"AV23despachado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV23despachado=n)},v2z:function(n){n!==undefined&&(gx.O.ZV23despachado=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vDESPACHADO",n||gx.fn.currentGridRowImpl(19),gx.O.AV23despachado,gx.O.AV27Despachado_GXI)},c2v:function(){gx.O.AV27Despachado_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV23despachado=this.val())},val:function(n){return gx.fn.getGridControlValue("vDESPACHADO",n||gx.fn.currentGridRowImpl(19))},val_GXI:function(n){return gx.fn.getGridControlValue("vDESPACHADO_GXI",n||gx.fn.currentGridRowImpl(19))},gxvar_GXI:"AV27Despachado_GXI",nac:gx.falseFn};this.ZV20select=0;this.OV20select=0;this.Z400nroReg=0;this.O400nroReg=0;this.Z355DespBodCodPrd=0;this.O355DespBodCodPrd=0;this.Z356DespBodPrdNombre="";this.O356DespBodPrdNombre="";this.Z357DespBodCant=0;this.O357DespBodCant=0;this.Z358DespBodValor=0;this.O358DespBodValor=0;this.ZV5DespBodADesp=0;this.OV5DespBodADesp=0;this.Z362DespBodDif=0;this.O362DespBodDif=0;this.Z359DespBodADesp=0;this.O359DespBodADesp=0;this.Z360DespBodStock=0;this.O360DespBodStock=0;this.Z376DespBodDetalle="";this.O376DespBodDetalle="";this.ZV23despachado="";this.OV23despachado="";this.AV7EmpID=0;this.AV6AgeID=0;this.AV16ClienteID=0;this.AV17OrdenPeriodo=0;this.AV18OrdenAnio=0;this.AV8DespBodOpId=0;this.A22OrdenID=0;this.A42BodCod=0;this.A2AgeID=0;this.A1EmpID=0;this.A353DespBodNro=0;this.A5ClienteID=0;this.AV20select=0;this.A400nroReg=0;this.A355DespBodCodPrd=0;this.A356DespBodPrdNombre="";this.A357DespBodCant=0;this.A358DespBodValor=0;this.AV5DespBodADesp=0;this.A362DespBodDif=0;this.A359DespBodADesp=0;this.A360DespBodStock=0;this.A376DespBodDetalle="";this.AV23despachado="";this.Events={e165l2_client:["ENTER",!0],e175l2_client:["CANCEL",!0],e115l1_client:["'ADDDESPBODEGA'",!1],e155l2_client:["VDESPBODADESP.CONTROLVALUECHANGED",!1],e125l1_client:["'GENERARDESP'",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{av:"AV7EmpID",fld:"vEMPID",pic:"ZZZ9"},{av:"AV6AgeID",fld:"vAGEID",pic:"ZZZ9"},{av:"AV8DespBodOpId",fld:"vDESPBODOPID",pic:"ZZZ9"},{av:'gx.fn.getCtrlProperty("vDESPBODADESP","Enabled")',ctrl:"vDESPBODADESP",prop:"Enabled"},{av:'gx.fn.getCtrlProperty("vSELECT","Enabled")',ctrl:"vSELECT",prop:"Enabled"},{av:"sPrefix"}],[]];this.EvtParms["'ADDDESPBODEGA'"]=[[],[]];this.EvtParms.START=[[],[{av:'gx.fn.getCtrlProperty("vDESPBODADESP","Enabled")',ctrl:"vDESPBODADESP",prop:"Enabled"},{av:'gx.fn.getCtrlProperty("vSELECT","Enabled")',ctrl:"vSELECT",prop:"Enabled"}]];this.EvtParms["VDESPBODADESP.CONTROLVALUECHANGED"]=[[],[]];this.EvtParms["'GENERARDESP'"]=[[],[]];this.setVCMap("A1EmpID","EMPID",0,"int",4,0);this.setVCMap("A2AgeID","AGEID",0,"int",4,0);this.setVCMap("A42BodCod","BODCOD",0,"int",4,0);this.setVCMap("AV7EmpID","vEMPID",0,"int",4,0);this.setVCMap("AV6AgeID","vAGEID",0,"int",4,0);this.setVCMap("AV16ClienteID","vCLIENTEID",0,"int",4,0);this.setVCMap("AV17OrdenPeriodo","vORDENPERIODO",0,"int",2,0);this.setVCMap("AV18OrdenAnio","vORDENANIO",0,"int",4,0);this.setVCMap("AV8DespBodOpId","vDESPBODOPID",0,"int",4,0);this.setVCMap("AV7EmpID","vEMPID",0,"int",4,0);this.setVCMap("AV6AgeID","vAGEID",0,"int",4,0);this.setVCMap("AV8DespBodOpId","vDESPBODOPID",0,"int",4,0);this.setVCMap("AV7EmpID","vEMPID",0,"int",4,0);this.setVCMap("AV6AgeID","vAGEID",0,"int",4,0);this.setVCMap("AV8DespBodOpId","vDESPBODOPID",0,"int",4,0);i.addRefreshingVar({rfrVar:"AV7EmpID"});i.addRefreshingVar({rfrVar:"AV6AgeID"});i.addRefreshingVar({rfrVar:"AV8DespBodOpId"});i.addRefreshingVar({rfrVar:"AV5DespBodADesp",rfrProp:"Enabled",gxAttId:"Despbodadesp"});i.addRefreshingVar({rfrVar:"AV20select",rfrProp:"Enabled",gxAttId:"Select"});this.Initialize()})