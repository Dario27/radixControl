/*!   GeneXus C# 15_0_12-126726 on 10/26/2022 20:17:50.54
*/
gx.evt.autoSkip=!1;gx.define("gx01g5",!1,function(){var n,t;this.ServerClass="gx01g5";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV8pEmpID=gx.fn.getIntegerValue("vPEMPID",".");this.AV9pClienteID=gx.fn.getIntegerValue("vPCLIENTEID",".");this.AV10pOrdenPeriodo=gx.fn.getIntegerValue("vPORDENPERIODO",".");this.AV11pOrdenAnio=gx.fn.getIntegerValue("vPORDENANIO",".");this.AV12pOrdenID=gx.fn.getIntegerValue("vPORDENID",".");this.AV13pOrdenObrID=gx.fn.getIntegerValue("vPORDENOBRID",".");this.AV14pObreID=gx.fn.getIntegerValue("vPOBREID",".");this.AV8pEmpID=gx.fn.getIntegerValue("vPEMPID",".");this.AV9pClienteID=gx.fn.getIntegerValue("vPCLIENTEID",".");this.AV10pOrdenPeriodo=gx.fn.getIntegerValue("vPORDENPERIODO",".");this.AV11pOrdenAnio=gx.fn.getIntegerValue("vPORDENANIO",".");this.AV12pOrdenID=gx.fn.getIntegerValue("vPORDENID",".")};this.e13481_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e11481_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ORDENOBRIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ORDENOBRIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCORDENOBRID","Visible",!0)):(gx.fn.setCtrlProperty("ORDENOBRIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCORDENOBRID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ORDENOBRIDFILTERCONTAINER","Class")',ctrl:"ORDENOBRIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCORDENOBRID","Visible")',ctrl:"vCORDENOBRID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e12481_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("OBREIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("OBREIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCOBREID","Visible",!0)):(gx.fn.setCtrlProperty("OBREIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCOBREID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("OBREIDFILTERCONTAINER","Class")',ctrl:"OBREIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCOBREID","Visible")',ctrl:"vCOBREID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e16482_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e17481_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,35,36,37,38,39,40,41,42,43,44,45,46,47];this.GXLastCtrlId=47;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",34,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx01g5",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",35,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(252,36,"ORDENOBRID","Obr ID","","OrdenObrID","int",0,"px",4,4,"right",null,[],252,"OrdenObrID",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(238,37,"OBREID","ID","","ObreID","int",0,"px",4,4,"right",null,[],238,"ObreID",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(253,38,"ORDENOBREMANOBRA","Obra","","OrdenObreManObra","svchar",0,"px",50,50,"left",null,[],253,"OrdenObreManObra",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(254,39,"ORDENOBREVALOR","Obra","","OrdenObreValor","decimal",0,"px",10,10,"right",null,[],254,"OrdenObreValor",!0,2,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(1,40,"EMPID","Emp ID","","EmpID","int",0,"px",4,4,"right",null,[],1,"EmpID",!1,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(5,41,"CLIENTEID","Cliente ID","","ClienteID","int",0,"px",4,4,"right",null,[],5,"ClienteID",!1,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(24,42,"ORDENPERIODO","Orden Periodo","","OrdenPeriodo","int",0,"px",2,2,"right",null,[],24,"OrdenPeriodo",!1,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(25,43,"ORDENANIO","Orden Anio","","OrdenAnio","int",0,"px",4,4,"right",null,[],25,"OrdenAnio",!1,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(22,44,"ORDENID","Orden ID","","OrdenID","int",0,"px",4,4,"right",null,[],22,"OrdenID",!1,0,!1,!1,"Attribute",1,"");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"ORDENOBRIDFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLORDENOBRIDFILTER",format:1,grid:0,evt:"e11481_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCORDENOBRID",gxz:"ZV6cOrdenObrID",gxold:"OV6cOrdenObrID",gxvar:"AV6cOrdenObrID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cOrdenObrID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cOrdenObrID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCORDENOBRID",gx.O.AV6cOrdenObrID,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cOrdenObrID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCORDENOBRID",".")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"OBREIDFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLOBREIDFILTER",format:1,grid:0,evt:"e12481_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCOBREID",gxz:"ZV7cObreID",gxold:"OV7cObreID",gxvar:"AV7cObreID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cObreID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV7cObreID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCOBREID",gx.O.AV7cObreID,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cObreID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCOBREID",".")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"GRIDTABLE",grid:0};n[29]={id:29,fld:"",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"BTNTOGGLE",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[35]={id:35,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(34),gx.O.AV5LinkSelection,gx.O.AV18Linkselection_GXI)},c2v:function(){gx.O.AV18Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(34))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(34))},gxvar_GXI:"AV18Linkselection_GXI",nac:gx.falseFn};n[36]={id:36,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ORDENOBRID",gxz:"Z252OrdenObrID",gxold:"O252OrdenObrID",gxvar:"A252OrdenObrID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A252OrdenObrID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z252OrdenObrID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ORDENOBRID",n||gx.fn.currentGridRowImpl(34),gx.O.A252OrdenObrID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A252OrdenObrID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ORDENOBRID",n||gx.fn.currentGridRowImpl(34),".")},nac:gx.falseFn};n[37]={id:37,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"OBREID",gxz:"Z238ObreID",gxold:"O238ObreID",gxvar:"A238ObreID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A238ObreID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z238ObreID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("OBREID",n||gx.fn.currentGridRowImpl(34),gx.O.A238ObreID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A238ObreID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("OBREID",n||gx.fn.currentGridRowImpl(34),".")},nac:gx.falseFn};n[38]={id:38,lvl:2,type:"svchar",len:50,dec:0,sign:!1,ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ORDENOBREMANOBRA",gxz:"Z253OrdenObreManObra",gxold:"O253OrdenObreManObra",gxvar:"A253OrdenObreManObra",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A253OrdenObreManObra=n)},v2z:function(n){n!==undefined&&(gx.O.Z253OrdenObreManObra=n)},v2c:function(n){gx.fn.setGridControlValue("ORDENOBREMANOBRA",n||gx.fn.currentGridRowImpl(34),gx.O.A253OrdenObreManObra,0)},c2v:function(){this.val()!==undefined&&(gx.O.A253OrdenObreManObra=this.val())},val:function(n){return gx.fn.getGridControlValue("ORDENOBREMANOBRA",n||gx.fn.currentGridRowImpl(34))},nac:gx.falseFn};n[39]={id:39,lvl:2,type:"decimal",len:10,dec:2,sign:!1,pic:"ZZZZZZ9.99",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ORDENOBREVALOR",gxz:"Z254OrdenObreValor",gxold:"O254OrdenObreValor",gxvar:"A254OrdenObreValor",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A254OrdenObreValor=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z254OrdenObreValor=gx.fn.toDecimalValue(n,".",","))},v2c:function(n){gx.fn.setGridDecimalValue("ORDENOBREVALOR",n||gx.fn.currentGridRowImpl(34),gx.O.A254OrdenObreValor,2,",")},c2v:function(){this.val()!==undefined&&(gx.O.A254OrdenObreValor=this.val())},val:function(n){return gx.fn.getGridDecimalValue("ORDENOBREVALOR",n||gx.fn.currentGridRowImpl(34),".",",")},nac:gx.falseFn};n[40]={id:40,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EMPID",gxz:"Z1EmpID",gxold:"O1EmpID",gxvar:"A1EmpID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A1EmpID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1EmpID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("EMPID",n||gx.fn.currentGridRowImpl(34),gx.O.A1EmpID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A1EmpID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("EMPID",n||gx.fn.currentGridRowImpl(34),".")},nac:gx.falseFn};n[41]={id:41,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CLIENTEID",gxz:"Z5ClienteID",gxold:"O5ClienteID",gxvar:"A5ClienteID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A5ClienteID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z5ClienteID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("CLIENTEID",n||gx.fn.currentGridRowImpl(34),gx.O.A5ClienteID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A5ClienteID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("CLIENTEID",n||gx.fn.currentGridRowImpl(34),".")},nac:gx.falseFn};n[42]={id:42,lvl:2,type:"int",len:2,dec:0,sign:!1,pic:"Z9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ORDENPERIODO",gxz:"Z24OrdenPeriodo",gxold:"O24OrdenPeriodo",gxvar:"A24OrdenPeriodo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A24OrdenPeriodo=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z24OrdenPeriodo=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ORDENPERIODO",n||gx.fn.currentGridRowImpl(34),gx.O.A24OrdenPeriodo,0)},c2v:function(){this.val()!==undefined&&(gx.O.A24OrdenPeriodo=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ORDENPERIODO",n||gx.fn.currentGridRowImpl(34),".")},nac:gx.falseFn};n[43]={id:43,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ORDENANIO",gxz:"Z25OrdenAnio",gxold:"O25OrdenAnio",gxvar:"A25OrdenAnio",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A25OrdenAnio=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z25OrdenAnio=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ORDENANIO",n||gx.fn.currentGridRowImpl(34),gx.O.A25OrdenAnio,0)},c2v:function(){this.val()!==undefined&&(gx.O.A25OrdenAnio=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ORDENANIO",n||gx.fn.currentGridRowImpl(34),".")},nac:gx.falseFn};n[44]={id:44,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ORDENID",gxz:"Z22OrdenID",gxold:"O22OrdenID",gxvar:"A22OrdenID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A22OrdenID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z22OrdenID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ORDENID",n||gx.fn.currentGridRowImpl(34),gx.O.A22OrdenID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A22OrdenID=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ORDENID",n||gx.fn.currentGridRowImpl(34),".")},nac:gx.falseFn};n[45]={id:45,fld:"",grid:0};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"BTN_CANCEL",grid:0};this.AV6cOrdenObrID=0;this.ZV6cOrdenObrID=0;this.OV6cOrdenObrID=0;this.AV7cObreID=0;this.ZV7cObreID=0;this.OV7cObreID=0;this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z252OrdenObrID=0;this.O252OrdenObrID=0;this.Z238ObreID=0;this.O238ObreID=0;this.Z253OrdenObreManObra="";this.O253OrdenObreManObra="";this.Z254OrdenObreValor=0;this.O254OrdenObreValor=0;this.Z1EmpID=0;this.O1EmpID=0;this.Z5ClienteID=0;this.O5ClienteID=0;this.Z24OrdenPeriodo=0;this.O24OrdenPeriodo=0;this.Z25OrdenAnio=0;this.O25OrdenAnio=0;this.Z22OrdenID=0;this.O22OrdenID=0;this.AV6cOrdenObrID=0;this.AV7cObreID=0;this.AV8pEmpID=0;this.AV9pClienteID=0;this.AV10pOrdenPeriodo=0;this.AV11pOrdenAnio=0;this.AV12pOrdenID=0;this.AV13pOrdenObrID=0;this.AV14pObreID=0;this.AV5LinkSelection="";this.A252OrdenObrID=0;this.A238ObreID=0;this.A253OrdenObreManObra="";this.A254OrdenObreValor=0;this.A1EmpID=0;this.A5ClienteID=0;this.A24OrdenPeriodo=0;this.A25OrdenAnio=0;this.A22OrdenID=0;this.Events={e16482_client:["ENTER",!0],e17481_client:["CANCEL",!0],e13481_client:["'TOGGLE'",!1],e11481_client:["LBLORDENOBRIDFILTER.CLICK",!1],e12481_client:["LBLOBREIDFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cOrdenObrID",fld:"vCORDENOBRID",pic:"ZZZ9"},{av:"AV7cObreID",fld:"vCOBREID",pic:"ZZZ9"},{av:"AV8pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV9pClienteID",fld:"vPCLIENTEID",pic:"ZZZ9"},{av:"AV10pOrdenPeriodo",fld:"vPORDENPERIODO",pic:"Z9"},{av:"AV11pOrdenAnio",fld:"vPORDENANIO",pic:"ZZZ9"},{av:"AV12pOrdenID",fld:"vPORDENID",pic:"ZZZ9"}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLORDENOBRIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ORDENOBRIDFILTERCONTAINER","Class")',ctrl:"ORDENOBRIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ORDENOBRIDFILTERCONTAINER","Class")',ctrl:"ORDENOBRIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCORDENOBRID","Visible")',ctrl:"vCORDENOBRID",prop:"Visible"}]];this.EvtParms["LBLOBREIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("OBREIDFILTERCONTAINER","Class")',ctrl:"OBREIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("OBREIDFILTERCONTAINER","Class")',ctrl:"OBREIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCOBREID","Visible")',ctrl:"vCOBREID",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A252OrdenObrID",fld:"ORDENOBRID",pic:"ZZZ9",hsh:!0},{av:"A238ObreID",fld:"OBREID",pic:"ZZZ9",hsh:!0}],[{av:"AV13pOrdenObrID",fld:"vPORDENOBRID",pic:"ZZZ9"},{av:"AV14pObreID",fld:"vPOBREID",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cOrdenObrID",fld:"vCORDENOBRID",pic:"ZZZ9"},{av:"AV7cObreID",fld:"vCOBREID",pic:"ZZZ9"},{av:"AV8pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV9pClienteID",fld:"vPCLIENTEID",pic:"ZZZ9"},{av:"AV10pOrdenPeriodo",fld:"vPORDENPERIODO",pic:"Z9"},{av:"AV11pOrdenAnio",fld:"vPORDENANIO",pic:"ZZZ9"},{av:"AV12pOrdenID",fld:"vPORDENID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cOrdenObrID",fld:"vCORDENOBRID",pic:"ZZZ9"},{av:"AV7cObreID",fld:"vCOBREID",pic:"ZZZ9"},{av:"AV8pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV9pClienteID",fld:"vPCLIENTEID",pic:"ZZZ9"},{av:"AV10pOrdenPeriodo",fld:"vPORDENPERIODO",pic:"Z9"},{av:"AV11pOrdenAnio",fld:"vPORDENANIO",pic:"ZZZ9"},{av:"AV12pOrdenID",fld:"vPORDENID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cOrdenObrID",fld:"vCORDENOBRID",pic:"ZZZ9"},{av:"AV7cObreID",fld:"vCOBREID",pic:"ZZZ9"},{av:"AV8pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV9pClienteID",fld:"vPCLIENTEID",pic:"ZZZ9"},{av:"AV10pOrdenPeriodo",fld:"vPORDENPERIODO",pic:"Z9"},{av:"AV11pOrdenAnio",fld:"vPORDENANIO",pic:"ZZZ9"},{av:"AV12pOrdenID",fld:"vPORDENID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cOrdenObrID",fld:"vCORDENOBRID",pic:"ZZZ9"},{av:"AV7cObreID",fld:"vCOBREID",pic:"ZZZ9"},{av:"AV8pEmpID",fld:"vPEMPID",pic:"ZZZ9"},{av:"AV9pClienteID",fld:"vPCLIENTEID",pic:"ZZZ9"},{av:"AV10pOrdenPeriodo",fld:"vPORDENPERIODO",pic:"Z9"},{av:"AV11pOrdenAnio",fld:"vPORDENANIO",pic:"ZZZ9"},{av:"AV12pOrdenID",fld:"vPORDENID",pic:"ZZZ9"}],[]];this.setVCMap("AV8pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV9pClienteID","vPCLIENTEID",0,"int",4,0);this.setVCMap("AV10pOrdenPeriodo","vPORDENPERIODO",0,"int",2,0);this.setVCMap("AV11pOrdenAnio","vPORDENANIO",0,"int",4,0);this.setVCMap("AV12pOrdenID","vPORDENID",0,"int",4,0);this.setVCMap("AV13pOrdenObrID","vPORDENOBRID",0,"int",4,0);this.setVCMap("AV14pObreID","vPOBREID",0,"int",4,0);this.setVCMap("AV8pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV9pClienteID","vPCLIENTEID",0,"int",4,0);this.setVCMap("AV10pOrdenPeriodo","vPORDENPERIODO",0,"int",2,0);this.setVCMap("AV11pOrdenAnio","vPORDENANIO",0,"int",4,0);this.setVCMap("AV12pOrdenID","vPORDENID",0,"int",4,0);this.setVCMap("AV8pEmpID","vPEMPID",0,"int",4,0);this.setVCMap("AV9pClienteID","vPCLIENTEID",0,"int",4,0);this.setVCMap("AV10pOrdenPeriodo","vPORDENPERIODO",0,"int",2,0);this.setVCMap("AV11pOrdenAnio","vPORDENANIO",0,"int",4,0);this.setVCMap("AV12pOrdenID","vPORDENID",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar({rfrVar:"AV8pEmpID"});t.addRefreshingVar({rfrVar:"AV9pClienteID"});t.addRefreshingVar({rfrVar:"AV10pOrdenPeriodo"});t.addRefreshingVar({rfrVar:"AV11pOrdenAnio"});t.addRefreshingVar({rfrVar:"AV12pOrdenID"});this.Initialize()});gx.createParentObj(gx01g5)