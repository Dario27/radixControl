/*!   GeneXus C# 15_0_12-126726 on 10/26/2022 20:14:8.4
*/
gx.evt.autoSkip=!1;gx.define("menu",!1,function(){var t,n,i;this.ServerClass="menu";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Modcod=function(){try{var n=gx.util.balloon.getNew("MODCOD");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Mencod=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Mencod",["gx.O.Gx_mode","gx.O.A11ModCod","gx.O.A12MenCod","gx.O.A77MenDsc","gx.O.A78MenLink","gx.O.A79MenIco"],["A77MenDsc","A78MenLink","A79MenIco","Gx_mode","Z11ModCod","Z12MenCod","Z77MenDsc","Z78MenLink","Z79MenIco","Grid1",["BTN_GET","Enabled"],["BTN_DELETE","Enabled"],["BTN_ENTER","Enabled"]]),!0};this.Valid_Subcod=function(){try{if(gx.fn.currentGridRowImpl(45)===0)return!0;var n=gx.util.balloon.getNew("SUBCOD",gx.fn.currentGridRowImpl(45));this.AnyError=0;this.sMode12=this.Gx_mode;this.Gx_mode=gx.fn.getGridRowMode(12,45);this.standaloneModal0O12();this.standaloneNotModal0O12();gx.fn.gridDuplicateKey(53)&&(n.setError(gx.text.format(gx.getMessage("GXM_1004"),"1","","","","","","","","")),this.AnyError=gx.num.trunc(1,0))}catch(t){}try{return(this.Gx_mode=this.sMode12,n==null)?!0:n.show()}catch(t){}return!0};this.standaloneModal0O12=function(){try{this.Gx_mode!="INS"?gx.fn.setCtrlProperty("SUBCOD","Enabled",0):gx.fn.setCtrlProperty("SUBCOD","Enabled",1)}catch(n){}return!0};this.standaloneNotModal0O12=function(){return!0};this.Valid_Sub1cod=function(){try{if(gx.fn.currentGridRowImpl(72)===0)return!0;var n=gx.util.balloon.getNew("SUB1COD",gx.fn.currentGridRowImpl(72));this.AnyError=0;this.sMode13=this.Gx_mode;this.Gx_mode=gx.fn.getGridRowMode(13,72);this.standaloneModal0O13();this.standaloneNotModal0O13();gx.fn.gridDuplicateKey(74)&&(n.setError(gx.text.format(gx.getMessage("GXM_1004"),"S1","","","","","","","","")),this.AnyError=gx.num.trunc(1,0))}catch(t){}try{return(this.Gx_mode=this.sMode13,n==null)?!0:n.show()}catch(t){}return!0};this.standaloneModal0O13=function(){try{this.Gx_mode!="INS"?gx.fn.setCtrlProperty("SUB1COD","Enabled",0):gx.fn.setCtrlProperty("SUB1COD","Enabled",1)}catch(n){}return!0};this.standaloneNotModal0O13=function(){return!0};this.e110o11_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e120o11_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];t=this.GXValidFnc;this.GXCtrlIds=[2,5,6,7,8,9,15,18,20,23,25,26,29,31,34,36,39,41,48,51,53,56,58,61,63,66,68,73,74,75,76,77,80,81,82];this.GXLastCtrlId=82;this.Grid1Container=new gx.grid.grid(this,12,"SUB",45,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"menu",[13],!0,1,!0,!0,5,!1,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!1,!1);n=this.Grid1Container;n.startRow("","","","","","");n.startCell("","","","","","","","","","");n.startTable("Table3",48,"0px");n.addHtmlCode("<tbody>");n.startRow("","","","","","");n.startCell("","","","","","","","","","");n.addTextBlock("TEXTBLOCK6",null,51);n.endCell();n.startCell("","","","","","","","","","");n.addSingleLineEdit(13,53,"SUBCOD","","","SubCod","int",4,"chr",4,4,"right",null,[],13,"SubCod",!0,0,!1,!1,"Attribute",1,"");n.endCell();n.endRow();n.startRow("","","","","","");n.startCell("","","","","","","","","","");n.addTextBlock("TEXTBLOCK7",null,56);n.endCell();n.startCell("","","","","","","","","","");n.addSingleLineEdit(80,58,"SUBDSC","","","SubDsc","char",30,"chr",30,30,"left",null,[],80,"SubDsc",!0,0,!1,!1,"Attribute",1,"");n.endCell();n.endRow();n.startRow("","","","","","");n.startCell("","","","","","","","","","");n.addTextBlock("TEXTBLOCK8",null,61);n.endCell();n.startCell("","","","","","","","","","");n.addSingleLineEdit(81,63,"SUBLINK","","","SubLink","char",30,"chr",30,30,"left",null,[],81,"SubLink",!0,0,!1,!1,"Attribute",1,"");n.endCell();n.endRow();n.startRow("","","","","","");n.startCell("","","","","","","","","","");n.addTextBlock("TEXTBLOCK9",null,66);n.endCell();n.startCell("","","","","","","","","","");n.addSingleLineEdit(82,68,"SUBETI","","","SubEti","char",30,"chr",30,30,"left",null,[],82,"SubEti",!0,0,!1,!1,"Attribute",1,"");n.endCell();n.endRow();n.startRow("","","","","","");n.startCell("","","","","","","","","","");n.endCell();n.startCell("","","","","","","","","","");this.Grid2Container=new gx.grid.grid(this,13,"S1",72,"Grid2","Grid2","Grid2Container",this.CmpContext,this.IsMasterPage,"menu",[14],!1,1,!1,!0,5,!1,!1,!1,"",0,"px",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!1,!1);i=this.Grid2Container;i.addSingleLineEdit("nRcdDeleted_13",73,"vNRCDDELETED_13","","","nRcdDeleted_13","int",0,"px",4,1,"right",null,[],"nRcdDeleted_13","nRcdDeleted_13",!0,0,!1,!1,"Attribute",1,"");i.addSingleLineEdit(14,74,"SUB1COD","Codigo","","Sub1Cod","int",0,"px",4,4,"right",null,[],14,"Sub1Cod",!0,0,!1,!1,"Attribute",1,"");i.addSingleLineEdit(83,75,"SUB1DSC","Sub1menu","","Sub1Dsc","char",0,"px",30,30,"left",null,[],83,"Sub1Dsc",!0,0,!1,!1,"Attribute",1,"");i.addSingleLineEdit(84,76,"SUB1LINK","Link","","Sub1Link","char",0,"px",30,30,"left",null,[],84,"Sub1Link",!0,0,!1,!1,"Attribute",1,"");i.addSingleLineEdit(85,77,"SUB1ETI","Etiqueta","","Sub1Eti","char",0,"px",30,30,"left",null,[],85,"Sub1Eti",!0,0,!1,!1,"Attribute",1,"");this.Grid2Container.emptyText="";n.addGrid(this.Grid2Container);n.endCell();n.endRow();n.addHtmlCode("<\/tbody>");n.endTable();n.endCell();n.endRow();this.Grid1Container.emptyText="";this.setGrid(n);t[2]={id:2,fld:"TABLE1",grid:0};t[5]={id:5,fld:"BTN_FIRST",grid:0};t[6]={id:6,fld:"BTN_PREVIOUS",grid:0};t[7]={id:7,fld:"BTN_NEXT",grid:0};t[8]={id:8,fld:"BTN_LAST",grid:0};t[9]={id:9,fld:"BTN_SELECT",grid:0};t[15]={id:15,fld:"TABLE2",grid:0};t[18]={id:18,fld:"TEXTBLOCK1",format:0,grid:0};t[20]={id:20,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Modcod,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container,this.Grid2Container],fld:"MODCOD",gxz:"Z11ModCod",gxold:"O11ModCod",gxvar:"A11ModCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A11ModCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z11ModCod=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("MODCOD",gx.O.A11ModCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A11ModCod=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("MODCOD",".")},nac:gx.falseFn};t[23]={id:23,fld:"TEXTBLOCK2",format:0,grid:0};t[25]={id:25,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Mencod,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container,this.Grid2Container],fld:"MENCOD",gxz:"Z12MenCod",gxold:"O12MenCod",gxvar:"A12MenCod",ucs:[],op:[41,36,31],ip:[41,36,31,25,20],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A12MenCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z12MenCod=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("MENCOD",gx.O.A12MenCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A12MenCod=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("MENCOD",".")},nac:gx.falseFn};t[26]={id:26,fld:"BTN_GET",grid:0};t[29]={id:29,fld:"TEXTBLOCK3",format:0,grid:0};t[31]={id:31,lvl:0,type:"char",len:30,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"MENDSC",gxz:"Z77MenDsc",gxold:"O77MenDsc",gxvar:"A77MenDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A77MenDsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z77MenDsc=n)},v2c:function(){gx.fn.setControlValue("MENDSC",gx.O.A77MenDsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A77MenDsc=this.val())},val:function(){return gx.fn.getControlValue("MENDSC")},nac:gx.falseFn};t[34]={id:34,fld:"TEXTBLOCK4",format:0,grid:0};t[36]={id:36,lvl:0,type:"char",len:30,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"MENLINK",gxz:"Z78MenLink",gxold:"O78MenLink",gxvar:"A78MenLink",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A78MenLink=n)},v2z:function(n){n!==undefined&&(gx.O.Z78MenLink=n)},v2c:function(){gx.fn.setControlValue("MENLINK",gx.O.A78MenLink,0)},c2v:function(){this.val()!==undefined&&(gx.O.A78MenLink=this.val())},val:function(){return gx.fn.getControlValue("MENLINK")},nac:gx.falseFn};t[39]={id:39,fld:"TEXTBLOCK5",format:0,grid:0};t[41]={id:41,lvl:0,type:"char",len:30,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"MENICO",gxz:"Z79MenIco",gxold:"O79MenIco",gxvar:"A79MenIco",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A79MenIco=n)},v2z:function(n){n!==undefined&&(gx.O.Z79MenIco=n)},v2c:function(){gx.fn.setControlValue("MENICO",gx.O.A79MenIco,0)},c2v:function(){this.val()!==undefined&&(gx.O.A79MenIco=this.val())},val:function(){return gx.fn.getControlValue("MENICO")},nac:gx.falseFn};t[48]={id:48,fld:"TABLE3",grid:45};t[51]={id:51,fld:"TEXTBLOCK6",format:0,grid:45};t[53]={id:53,lvl:12,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,isacc:1,grid:45,gxgrid:this.Grid1Container,fnc:this.Valid_Subcod,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid2Container],fld:"SUBCOD",gxz:"Z13SubCod",gxold:"O13SubCod",gxvar:"A13SubCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A13SubCod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z13SubCod=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("SUBCOD",n||gx.fn.currentGridRowImpl(45),gx.O.A13SubCod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A13SubCod=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("SUBCOD",n||gx.fn.currentGridRowImpl(45),".")},nac:gx.falseFn};t[56]={id:56,fld:"TEXTBLOCK7",format:0,grid:45};t[58]={id:58,lvl:12,type:"char",len:30,dec:0,sign:!1,ro:0,isacc:1,grid:45,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SUBDSC",gxz:"Z80SubDsc",gxold:"O80SubDsc",gxvar:"A80SubDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A80SubDsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z80SubDsc=n)},v2c:function(n){gx.fn.setGridControlValue("SUBDSC",n||gx.fn.currentGridRowImpl(45),gx.O.A80SubDsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A80SubDsc=this.val())},val:function(n){return gx.fn.getGridControlValue("SUBDSC",n||gx.fn.currentGridRowImpl(45))},nac:gx.falseFn};t[61]={id:61,fld:"TEXTBLOCK8",format:0,grid:45};t[63]={id:63,lvl:12,type:"char",len:30,dec:0,sign:!1,ro:0,isacc:1,grid:45,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SUBLINK",gxz:"Z81SubLink",gxold:"O81SubLink",gxvar:"A81SubLink",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A81SubLink=n)},v2z:function(n){n!==undefined&&(gx.O.Z81SubLink=n)},v2c:function(n){gx.fn.setGridControlValue("SUBLINK",n||gx.fn.currentGridRowImpl(45),gx.O.A81SubLink,0)},c2v:function(){this.val()!==undefined&&(gx.O.A81SubLink=this.val())},val:function(n){return gx.fn.getGridControlValue("SUBLINK",n||gx.fn.currentGridRowImpl(45))},nac:gx.falseFn};t[66]={id:66,fld:"TEXTBLOCK9",format:0,grid:45};t[68]={id:68,lvl:12,type:"char",len:30,dec:0,sign:!1,ro:0,isacc:1,grid:45,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SUBETI",gxz:"Z82SubEti",gxold:"O82SubEti",gxvar:"A82SubEti",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A82SubEti=n)},v2z:function(n){n!==undefined&&(gx.O.Z82SubEti=n)},v2c:function(n){gx.fn.setGridControlValue("SUBETI",n||gx.fn.currentGridRowImpl(45),gx.O.A82SubEti,0)},c2v:function(){this.val()!==undefined&&(gx.O.A82SubEti=this.val())},val:function(n){return gx.fn.getGridControlValue("SUBETI",n||gx.fn.currentGridRowImpl(45))},nac:gx.falseFn};t[73]={id:73,lvl:13,type:"int",len:4,dec:0,sign:!1,pic:"9999",ro:0,isacc:0,grid:72,gxgrid:this.Grid2Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vNRCDDELETED_13",gxz:"ZnRcdDeleted_13",gxold:"OnRcdDeleted_13",gxvar:"nRcdDeleted_13",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.nRcdDeleted_13=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZnRcdDeleted_13=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("vNRCDDELETED_13",n||gx.fn.currentGridRowImpl(72),gx.O.nRcdDeleted_13,0)},c2v:function(){this.val()!==undefined&&(gx.O.nRcdDeleted_13=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("vNRCDDELETED_13",n||gx.fn.currentGridRowImpl(72),".")},nac:gx.falseFn};t[74]={id:74,lvl:13,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,isacc:1,grid:72,gxgrid:this.Grid2Container,fnc:this.Valid_Sub1cod,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SUB1COD",gxz:"Z14Sub1Cod",gxold:"O14Sub1Cod",gxvar:"A14Sub1Cod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A14Sub1Cod=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z14Sub1Cod=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("SUB1COD",n||gx.fn.currentGridRowImpl(72),gx.O.A14Sub1Cod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A14Sub1Cod=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("SUB1COD",n||gx.fn.currentGridRowImpl(72),".")},nac:gx.falseFn};t[75]={id:75,lvl:13,type:"char",len:30,dec:0,sign:!1,ro:0,isacc:1,grid:72,gxgrid:this.Grid2Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SUB1DSC",gxz:"Z83Sub1Dsc",gxold:"O83Sub1Dsc",gxvar:"A83Sub1Dsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A83Sub1Dsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z83Sub1Dsc=n)},v2c:function(n){gx.fn.setGridControlValue("SUB1DSC",n||gx.fn.currentGridRowImpl(72),gx.O.A83Sub1Dsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A83Sub1Dsc=this.val())},val:function(n){return gx.fn.getGridControlValue("SUB1DSC",n||gx.fn.currentGridRowImpl(72))},nac:gx.falseFn};t[76]={id:76,lvl:13,type:"char",len:30,dec:0,sign:!1,ro:0,isacc:1,grid:72,gxgrid:this.Grid2Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SUB1LINK",gxz:"Z84Sub1Link",gxold:"O84Sub1Link",gxvar:"A84Sub1Link",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A84Sub1Link=n)},v2z:function(n){n!==undefined&&(gx.O.Z84Sub1Link=n)},v2c:function(n){gx.fn.setGridControlValue("SUB1LINK",n||gx.fn.currentGridRowImpl(72),gx.O.A84Sub1Link,0)},c2v:function(){this.val()!==undefined&&(gx.O.A84Sub1Link=this.val())},val:function(n){return gx.fn.getGridControlValue("SUB1LINK",n||gx.fn.currentGridRowImpl(72))},nac:gx.falseFn};t[77]={id:77,lvl:13,type:"char",len:30,dec:0,sign:!1,ro:0,isacc:1,grid:72,gxgrid:this.Grid2Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SUB1ETI",gxz:"Z85Sub1Eti",gxold:"O85Sub1Eti",gxvar:"A85Sub1Eti",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A85Sub1Eti=n)},v2z:function(n){n!==undefined&&(gx.O.Z85Sub1Eti=n)},v2c:function(n){gx.fn.setGridControlValue("SUB1ETI",n||gx.fn.currentGridRowImpl(72),gx.O.A85Sub1Eti,0)},c2v:function(){this.val()!==undefined&&(gx.O.A85Sub1Eti=this.val())},val:function(n){return gx.fn.getGridControlValue("SUB1ETI",n||gx.fn.currentGridRowImpl(72))},nac:gx.falseFn};t[80]={id:80,fld:"BTN_ENTER",grid:0};t[81]={id:81,fld:"BTN_CANCEL",grid:0};t[82]={id:82,fld:"BTN_DELETE",grid:0};this.A11ModCod=0;this.Z11ModCod=0;this.O11ModCod=0;this.A12MenCod=0;this.Z12MenCod=0;this.O12MenCod=0;this.A77MenDsc="";this.Z77MenDsc="";this.O77MenDsc="";this.A78MenLink="";this.Z78MenLink="";this.O78MenLink="";this.A79MenIco="";this.Z79MenIco="";this.O79MenIco="";this.Z13SubCod=0;this.O13SubCod=0;this.Z80SubDsc="";this.O80SubDsc="";this.Z81SubLink="";this.O81SubLink="";this.Z82SubEti="";this.O82SubEti="";this.ZnRcdDeleted_13=0;this.OnRcdDeleted_13=0;this.Z14Sub1Cod=0;this.O14Sub1Cod=0;this.Z83Sub1Dsc="";this.O83Sub1Dsc="";this.Z84Sub1Link="";this.O84Sub1Link="";this.Z85Sub1Eti="";this.O85Sub1Eti="";this.A14Sub1Cod=0;this.A83Sub1Dsc="";this.A84Sub1Link="";this.A85Sub1Eti="";this.A13SubCod=0;this.A80SubDsc="";this.A81SubLink="";this.A82SubEti="";this.A11ModCod=0;this.A12MenCod=0;this.A77MenDsc="";this.A78MenLink="";this.A79MenIco="";this.Events={e110o11_client:["ENTER",!0],e120o11_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("Gx_mode","vMODE",0,"char",3,0);n.addPostingVar({rfrVar:"Gx_mode"});i.addPostingVar({rfrVar:"Gx_mode"});this.Initialize()});gx.createParentObj(menu)