/*!   GeneXus C# 15_0_12-126726 on 10/26/2022 20:12:58.73
*/
gx.evt.autoSkip=!1;gx.define("wcmenuhor1",!0,function(n){this.ServerClass="wcmenuhor1";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.SetStandaloneVars=function(){};this.e134c2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e144c2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var t=this.GXValidFnc;this.GXCtrlIds=[2,5];this.GXLastCtrlId=5;t[2]={id:2,fld:"TABLE1",grid:0};t[5]={id:5,fld:"MENUHOR",format:2,grid:0};this.AV5empcod=0;this.AV6agecod=0;this.AV7UsuCod="";this.Events={e134c2_client:["ENTER",!0],e144c2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[],[]];this.EvtParms.START=[[{av:"AV5empcod",fld:"vEMPCOD",pic:"ZZ9"},{av:"AV6agecod",fld:"vAGECOD",pic:"ZZ9"},{av:"AV7UsuCod",fld:"vUSUCOD",pic:""}],[{av:'gx.fn.getCtrlProperty("MENUHOR","Caption")',ctrl:"MENUHOR",prop:"Caption"}]];this.Initialize()})