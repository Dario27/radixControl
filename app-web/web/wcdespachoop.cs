/*
               File: WCDespachoOP
        Description: WCDespacho OP
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/19/2023 22:34:2.64
       Program type: Callable routine
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class wcdespachoop : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public wcdespachoop( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
            context.SetDefaultTheme("Carmine");
         }
      }

      public wcdespachoop( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_EmpID ,
                           short aP1_AgeID ,
                           short aP2_ClienteID ,
                           short aP3_OrdenPeriodo ,
                           short aP4_OrdenAnio ,
                           short aP5_DespBodOpId )
      {
         this.AV7EmpID = aP0_EmpID;
         this.AV6AgeID = aP1_AgeID;
         this.AV16ClienteID = aP2_ClienteID;
         this.AV17OrdenPeriodo = aP3_OrdenPeriodo;
         this.AV18OrdenAnio = aP4_OrdenAnio;
         this.AV8DespBodOpId = aP5_DespBodOpId;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      public override void SetPrefix( String sPPrefix )
      {
         sPrefix = sPPrefix;
      }

      protected override void createObjects( )
      {
         chkavSelect = new GXCheckbox();
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
            if ( nGotPars == 0 )
            {
               entryPointCalled = false;
               gxfirstwebparm = GetNextPar( );
               gxfirstwebparm_bkp = gxfirstwebparm;
               gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm);
               if ( context.isSpaRequest( ) )
               {
                  disableJsOutput();
               }
               if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
               {
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  dyncall( GetNextPar( )) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "dyncomponent") == 0 )
               {
                  setAjaxEventMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  nDynComponent = 1;
                  sCompPrefix = GetNextPar( );
                  sSFPrefix = GetNextPar( );
                  AV7EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7EmpID), 4, 0)));
                  AV6AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6AgeID), 4, 0)));
                  AV16ClienteID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV16ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16ClienteID), 4, 0)));
                  AV17OrdenPeriodo = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV17OrdenPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17OrdenPeriodo), 2, 0)));
                  AV18OrdenAnio = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18OrdenAnio), 4, 0)));
                  AV8DespBodOpId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8DespBodOpId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8DespBodOpId), 4, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(short)AV7EmpID,(short)AV6AgeID,(short)AV16ClienteID,(short)AV17OrdenPeriodo,(short)AV18OrdenAnio,(short)AV8DespBodOpId});
                  componentstart();
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix);
                  componentdraw();
                  context.httpAjaxContext.ajax_rspEndCmp();
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
               {
                  setAjaxEventMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxfirstwebparm = GetNextPar( );
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxfullajaxEvt") == 0 )
               {
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxfirstwebparm = GetNextPar( );
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
               {
                  nRC_GXsfl_19 = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  nGXsfl_19_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  sGXsfl_19_idx = GetNextPar( );
                  sPrefix = GetNextPar( );
                  edtavDespbodadesp_Enabled = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDespbodadesp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDespbodadesp_Enabled), 5, 0)), !bGXsfl_19_Refreshing);
                  chkavSelect.Enabled = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, chkavSelect_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavSelect.Enabled), 5, 0)), !bGXsfl_19_Refreshing);
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxnrGrid1_newrow( ) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
               {
                  AV7EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV6AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV8DespBodOpId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  edtavDespbodadesp_Enabled = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDespbodadesp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDespbodadesp_Enabled), 5, 0)), !bGXsfl_19_Refreshing);
                  chkavSelect.Enabled = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, chkavSelect_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavSelect.Enabled), 5, 0)), !bGXsfl_19_Refreshing);
                  sPrefix = GetNextPar( );
                  init_default_properties( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxgrGrid1_refresh( AV7EmpID, AV6AgeID, AV8DespBodOpId, sPrefix) ;
                  GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
                  GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
                  return  ;
               }
               else
               {
                  if ( ! IsValidAjaxCall( false) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxfirstwebparm = gxfirstwebparm_bkp;
               }
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.IsLocalStorageSupported( ) )
            {
               context.PushCurrentUrl();
            }
         }
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               ValidateSpaRequest();
            }
            PA5L2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0;
               WS5L2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  if ( nDynComponent == 0 )
                  {
                     throw new System.Net.WebException("WebComponent is not allowed to run") ;
                  }
               }
            }
            if ( ( GxWebError == 0 ) && context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
               }
               if ( ! context.WillRedirect( ) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  if ( context.isAjaxRequest( ) )
                  {
                     disableOutput();
                  }
                  RenderHtmlHeaders( ) ;
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      protected void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      protected void RenderHtmlOpenForm( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
            context.WriteHtmlText( "<title>") ;
            context.SendWebValue( "WCDespacho OP") ;
            context.WriteHtmlTextNl( "</title>") ;
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
            if ( StringUtil.Len( sDynURL) > 0 )
            {
               context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
            }
            define_styles( ) ;
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 126726), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("bootstrap/js/bootstrap.min.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxcfg.js", "?20231192234272", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
            FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
            context.WriteHtmlText( "<body ") ;
            bodyStyle = "";
            if ( nGXWrapped == 0 )
            {
               bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
            }
            context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
            context.WriteHtmlText( FormProcess+">") ;
            context.skipLines(1);
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("wcdespachoop.aspx") + "?" + UrlEncode("" +AV7EmpID) + "," + UrlEncode("" +AV6AgeID) + "," + UrlEncode("" +AV16ClienteID) + "," + UrlEncode("" +AV17OrdenPeriodo) + "," + UrlEncode("" +AV18OrdenAnio) + "," + UrlEncode("" +AV8DespBodOpId)+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            context.WriteHtmlText( "<input type=\"submit\" style=\"display:none\">") ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, "FORM", "Class", "form-horizontal Form", true);
         }
         else
         {
            bool toggleHtmlOutput = isOutputEnabled( ) ;
            if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableOutput();
               }
            }
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gxwebcomponent-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            if ( toggleHtmlOutput )
            {
               if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableOutput();
                  }
               }
            }
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_GXsfl_19", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_19), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV7EmpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV7EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV6AgeID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV6AgeID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV16ClienteID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV16ClienteID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV17OrdenPeriodo", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV17OrdenPeriodo), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV18OrdenAnio", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV18OrdenAnio), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV8DespBodOpId", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV8DespBodOpId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6AgeID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vCLIENTEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16ClienteID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vORDENPERIODO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17OrdenPeriodo), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vORDENANIO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18OrdenAnio), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vDESPBODOPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8DespBodOpId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"EMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"AGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A2AgeID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"BODCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(A42BodCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vDESPBODADESP_Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDespbodadesp_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vSELECT_Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkavSelect.Enabled), 5, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm5L2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("wcdespachoop.js", "?20231192234276", false);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GX_FocusControl", GX_FocusControl);
         define_styles( ) ;
         SendSecurityToken(sPrefix);
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            SendAjaxEncryptionKey();
            SendComponentObjects();
            SendServerCommands();
            SendState();
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
            context.WriteHtmlTextNl( "</form>") ;
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
            include_jscripts( ) ;
            context.AddJavascriptSource("bootstrap/js/bootstrap.min.js", "?"+context.GetBuildNumber( 126726), false);
            context.WriteHtmlTextNl( "</body>") ;
            context.WriteHtmlTextNl( "</html>") ;
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
         }
         else
         {
            SendWebComponentState();
            context.WriteHtmlText( "</div>") ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
         }
      }

      public override String GetPgmname( )
      {
         return "WCDespachoOP" ;
      }

      public override String GetPgmdesc( )
      {
         return "WCDespacho OP" ;
      }

      protected void WB5L0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               RenderHtmlHeaders( ) ;
            }
            RenderHtmlOpenForm( ) ;
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "wcdespachoop.aspx");
            }
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable1_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, sPrefix, "false");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTbflx_Internalname, 1, 0, "px", 0, "px", "Flex", "left", "top", " "+"data-gx-flex"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "", "left", "top", "", "flex-grow::1;", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'" + sPrefix + "',false,'',0)\"";
            ClassString = "BtnAddRecords";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttAdddespop_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(19), 2, 0)+","+"null"+");", "Agregar", bttAdddespop_Jsonclick, 7, "Agregar", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e115l1_client"+"'", TempTags, "", 2, "HLP_WCDespachoOP.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "", "left", "top", "", "flex-grow::1;", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'" + sPrefix + "',false,'',0)\"";
            ClassString = "BtnProceso";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttGenerarinv_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(19), 2, 0)+","+"null"+");", "Despachar", bttGenerarinv_Jsonclick, 7, "Despachar", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e125l1_client"+"'", TempTags, "", 2, "HLP_WCDespachoOP.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+sPrefix+"Grid1Container"+"DivS\" data-gxgridid=\"19\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "WorkWith", 0, "", "", 1, 2, sStyleString, "", "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid1_Backcolorstyle == 0 )
               {
                  subGrid1_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGrid1_Class) > 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Title";
                  }
               }
               else
               {
                  subGrid1_Titlebackstyle = 1;
                  if ( subGrid1_Backcolorstyle == 1 )
                  {
                     subGrid1_Titlebackcolor = subGrid1_Allbackcolor;
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(40), 4, 0))+"px"+" class=\""+"CheckBox"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(50), 4, 0))+"px"+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Nro") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(65), 4, 0))+"px"+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Codigo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(270), 4, 0))+"px"+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Producto") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(80), 4, 0))+"px"+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Cant.") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(80), 4, 0))+"px"+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Valor") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "A Desp.") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(60), 4, 0))+"px"+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Dif.") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(60), 4, 0))+"px"+" class=\""+"AttributeBold"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Desp.") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Stock") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Detalle") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ImageAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               Grid1Container.AddObjectProperty("GridName", "Grid1");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  Grid1Container = new GXWebGrid( context);
               }
               else
               {
                  Grid1Container.Clear();
               }
               Grid1Container.SetWrapped(nGXWrapped);
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Header", subGrid1_Header);
               Grid1Container.AddObjectProperty("Class", "WorkWith");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Sortable", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Sortable), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", sPrefix);
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV20select), 1, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkavSelect.Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A400nroReg), 6, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A355DespBodCodPrd), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A356DespBodPrdNombre));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A357DespBodCant, 8, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A358DespBodValor, 8, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( AV5DespBodADesp, 8, 2, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDespbodadesp_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A362DespBodDif), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A359DespBodADesp, 8, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A360DespBodStock, 6, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A376DespBodDetalle));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV23despachado));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectedindex), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowselection), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowhovering), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowcollapsing), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 19 )
         {
            wbEnd = 0;
            nRC_GXsfl_19 = (short)(nGXsfl_19_idx-1);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+sPrefix+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Grid1", Grid1Container);
               if ( ! isAjaxCallMode( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"Grid1ContainerData", Grid1Container.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+sPrefix+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'/>") ;
               }
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 19 )
         {
            wbEnd = 0;
            if ( isFullAjaxMode( ) )
            {
               if ( Grid1Container.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  sStyleString = "";
                  context.WriteHtmlText( "<div id=\""+sPrefix+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Grid1", Grid1Container);
                  if ( ! isAjaxCallMode( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, sPrefix+"Grid1ContainerData", Grid1Container.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, sPrefix+"Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+sPrefix+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START5L2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
               Form.Meta.addItem("description", "WCDespacho OP", 0) ;
            }
            context.wjLoc = "";
            context.nUserReturn = 0;
            context.wbHandled = 0;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               sXEvt = cgiGet( "_EventName");
               if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
               {
               }
            }
         }
         wbErr = false;
         if ( ( StringUtil.Len( sPrefix) == 0 ) || ( nDraw == 1 ) )
         {
            if ( nDoneStart == 0 )
            {
               STRUP5L0( ) ;
            }
         }
      }

      protected void WS5L2( )
      {
         START5L2( ) ;
         EVT5L2( ) ;
      }

      protected void EVT5L2( )
      {
         sXEvt = cgiGet( "_EventName");
         if ( ( ( ( StringUtil.Len( sPrefix) == 0 ) ) || ( StringUtil.StringSearch( sXEvt, sPrefix, 1) > 0 ) ) && ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               if ( context.wbHandled == 0 )
               {
                  if ( StringUtil.Len( sPrefix) == 0 )
                  {
                     sEvt = cgiGet( "_EventName");
                     EvtGridId = cgiGet( "_EventGridId");
                     EvtRowId = cgiGet( "_EventRowId");
                  }
                  if ( StringUtil.Len( sEvt) > 0 )
                  {
                     sEvtType = StringUtil.Left( sEvt, 1);
                     sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1);
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5L0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5L0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5L0( ) ;
                              }
                              nGXsfl_19_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_19_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_19_idx), 4, 0)), 4, "0");
                              SubsflControlProps_192( ) ;
                              AV20select = (short)(((StringUtil.StrCmp(cgiGet( chkavSelect_Internalname), "1")==0) ? 1 : 0));
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, chkavSelect_Internalname, StringUtil.Str( (decimal)(AV20select), 1, 0));
                              A400nroReg = (int)(context.localUtil.CToN( cgiGet( edtnroReg_Internalname), ",", "."));
                              A355DespBodCodPrd = (short)(context.localUtil.CToN( cgiGet( edtDespBodCodPrd_Internalname), ",", "."));
                              n355DespBodCodPrd = false;
                              A356DespBodPrdNombre = StringUtil.Upper( cgiGet( edtDespBodPrdNombre_Internalname));
                              n356DespBodPrdNombre = false;
                              A357DespBodCant = context.localUtil.CToN( cgiGet( edtDespBodCant_Internalname), ",", ".");
                              n357DespBodCant = false;
                              A358DespBodValor = context.localUtil.CToN( cgiGet( edtDespBodValor_Internalname), ",", ".");
                              n358DespBodValor = false;
                              AV5DespBodADesp = context.localUtil.CToN( cgiGet( edtavDespbodadesp_Internalname), ",", ".");
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtavDespbodadesp_Internalname, StringUtil.LTrim( StringUtil.Str( AV5DespBodADesp, 8, 2)));
                              A362DespBodDif = (short)(context.localUtil.CToN( cgiGet( edtDespBodDif_Internalname), ",", "."));
                              A359DespBodADesp = context.localUtil.CToN( cgiGet( edtDespBodADesp_Internalname), ",", ".");
                              n359DespBodADesp = false;
                              A360DespBodStock = context.localUtil.CToN( cgiGet( edtDespBodStock_Internalname), ",", ".");
                              A376DespBodDetalle = cgiGet( edtDespBodDetalle_Internalname);
                              n376DespBodDetalle = false;
                              AV23despachado = cgiGet( edtavDespachado_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDespachado_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV23despachado)) ? AV27Despachado_GXI : context.convertURL( context.PathToRelativeUrl( AV23despachado))), !bGXsfl_19_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDespachado_Internalname, "SrcSet", context.GetImageSrcSet( AV23despachado), true);
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          /* Execute user event: Start */
                                          E135L2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          /* Execute user event: Load */
                                          E145L2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          if ( ! wbErr )
                                          {
                                             Rfr0gs = false;
                                             if ( ! Rfr0gs )
                                             {
                                             }
                                             dynload_actions( ) ;
                                          }
                                       }
                                    }
                                    /* No code required for Cancel button. It is implemented as the Reset button. */
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                                    {
                                       STRUP5L0( ) ;
                                    }
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                       }
                                    }
                                 }
                              }
                              else
                              {
                              }
                           }
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE5L2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm5L2( ) ;
            }
         }
      }

      protected void PA5L2( )
      {
         if ( nDonePA == 0 )
         {
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               initialize_properties( ) ;
            }
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
               {
                  gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
               }
            }
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableJsOutput();
               }
            }
            init_web_controls( ) ;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( toggleJsOutput )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableJsOutput();
                  }
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_192( ) ;
         while ( nGXsfl_19_idx <= nRC_GXsfl_19 )
         {
            sendrow_192( ) ;
            nGXsfl_19_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_19_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_19_idx+1));
            sGXsfl_19_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_19_idx), 4, 0)), 4, "0");
            SubsflControlProps_192( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Grid1Container));
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( short AV7EmpID ,
                                        short AV6AgeID ,
                                        short AV8DespBodOpId ,
                                        String sPrefix )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GRID1_nCurrentRecord = 0;
         RF5L2( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
      }

      protected void clear_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
            dynload_actions( ) ;
         }
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF5L2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF5L2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            Grid1Container.ClearRows();
         }
         wbStart = 19;
         nGXsfl_19_idx = 1;
         sGXsfl_19_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_19_idx), 4, 0)), 4, "0");
         SubsflControlProps_192( ) ;
         bGXsfl_19_Refreshing = true;
         Grid1Container.AddObjectProperty("GridName", "Grid1");
         Grid1Container.AddObjectProperty("CmpContext", sPrefix);
         Grid1Container.AddObjectProperty("InMasterPage", "false");
         Grid1Container.AddObjectProperty("Class", "WorkWith");
         Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
         Grid1Container.AddObjectProperty("Sortable", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Sortable), 1, 0, ".", "")));
         Grid1Container.PageSize = subGrid1_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_192( ) ;
            /* Using cursor H005L2 */
            pr_default.execute(0, new Object[] {AV7EmpID, AV6AgeID, AV8DespBodOpId});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A353DespBodNro = H005L2_A353DespBodNro[0];
               A5ClienteID = H005L2_A5ClienteID[0];
               A22OrdenID = H005L2_A22OrdenID[0];
               A376DespBodDetalle = H005L2_A376DespBodDetalle[0];
               n376DespBodDetalle = H005L2_n376DespBodDetalle[0];
               A358DespBodValor = H005L2_A358DespBodValor[0];
               n358DespBodValor = H005L2_n358DespBodValor[0];
               A356DespBodPrdNombre = H005L2_A356DespBodPrdNombre[0];
               n356DespBodPrdNombre = H005L2_n356DespBodPrdNombre[0];
               A400nroReg = H005L2_A400nroReg[0];
               A359DespBodADesp = H005L2_A359DespBodADesp[0];
               n359DespBodADesp = H005L2_n359DespBodADesp[0];
               A357DespBodCant = H005L2_A357DespBodCant[0];
               n357DespBodCant = H005L2_n357DespBodCant[0];
               A42BodCod = H005L2_A42BodCod[0];
               A355DespBodCodPrd = H005L2_A355DespBodCodPrd[0];
               n355DespBodCodPrd = H005L2_n355DespBodCodPrd[0];
               A2AgeID = H005L2_A2AgeID[0];
               A1EmpID = H005L2_A1EmpID[0];
               A42BodCod = H005L2_A42BodCod[0];
               GXt_decimal1 = A360DespBodStock;
               new prcbusstock(context ).execute(  (short)(DateTimeUtil.Year( DateTimeUtil.ServerNow( context, pr_default))),  (short)(DateTimeUtil.Month( DateTimeUtil.ServerNow( context, pr_default))),  A1EmpID,  A2AgeID,  A42BodCod,  A355DespBodCodPrd, out  GXt_decimal1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
               A360DespBodStock = GXt_decimal1;
               A362DespBodDif = (short)((A357DespBodCant-A359DespBodADesp));
               /* Execute user event: Load */
               E145L2 ();
               pr_default.readNext(0);
            }
            pr_default.close(0);
            wbEnd = 19;
            WB5L0( ) ;
         }
         bGXsfl_19_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes5L2( )
      {
      }

      protected int subGrid1_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected void STRUP5L0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E135L2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
            nRC_GXsfl_19 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_GXsfl_19"), ",", "."));
            wcpOAV7EmpID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV7EmpID"), ",", "."));
            wcpOAV6AgeID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV6AgeID"), ",", "."));
            wcpOAV16ClienteID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV16ClienteID"), ",", "."));
            wcpOAV17OrdenPeriodo = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV17OrdenPeriodo"), ",", "."));
            wcpOAV18OrdenAnio = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV18OrdenAnio"), ",", "."));
            wcpOAV8DespBodOpId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV8DespBodOpId"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E135L2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E135L2( )
      {
         /* Start Routine */
         edtavDespbodadesp_Enabled = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDespbodadesp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDespbodadesp_Enabled), 5, 0)), !bGXsfl_19_Refreshing);
         chkavSelect.Enabled = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, chkavSelect_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavSelect.Enabled), 5, 0)), !bGXsfl_19_Refreshing);
      }

      private void E145L2( )
      {
         /* Load Routine */
         sendrow_192( ) ;
         if ( isFullAjaxMode( ) && ! bGXsfl_19_Refreshing )
         {
            context.DoAjaxLoad(19, Grid1Row);
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV7EmpID = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7EmpID), 4, 0)));
         AV6AgeID = Convert.ToInt16(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6AgeID), 4, 0)));
         AV16ClienteID = Convert.ToInt16(getParm(obj,2));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV16ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16ClienteID), 4, 0)));
         AV17OrdenPeriodo = Convert.ToInt16(getParm(obj,3));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV17OrdenPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17OrdenPeriodo), 2, 0)));
         AV18OrdenAnio = Convert.ToInt16(getParm(obj,4));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18OrdenAnio), 4, 0)));
         AV8DespBodOpId = Convert.ToInt16(getParm(obj,5));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8DespBodOpId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8DespBodOpId), 4, 0)));
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA5L2( ) ;
         WS5L2( ) ;
         WE5L2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void componentbind( Object[] obj )
      {
         if ( IsUrlCreated( ) )
         {
            return  ;
         }
         sCtrlAV7EmpID = (String)((String)getParm(obj,0));
         sCtrlAV6AgeID = (String)((String)getParm(obj,1));
         sCtrlAV16ClienteID = (String)((String)getParm(obj,2));
         sCtrlAV17OrdenPeriodo = (String)((String)getParm(obj,3));
         sCtrlAV18OrdenAnio = (String)((String)getParm(obj,4));
         sCtrlAV8DespBodOpId = (String)((String)getParm(obj,5));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA5L2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "wcdespachoop", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA5L2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV7EmpID = Convert.ToInt16(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7EmpID), 4, 0)));
            AV6AgeID = Convert.ToInt16(getParm(obj,3));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6AgeID), 4, 0)));
            AV16ClienteID = Convert.ToInt16(getParm(obj,4));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV16ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16ClienteID), 4, 0)));
            AV17OrdenPeriodo = Convert.ToInt16(getParm(obj,5));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV17OrdenPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17OrdenPeriodo), 2, 0)));
            AV18OrdenAnio = Convert.ToInt16(getParm(obj,6));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18OrdenAnio), 4, 0)));
            AV8DespBodOpId = Convert.ToInt16(getParm(obj,7));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8DespBodOpId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8DespBodOpId), 4, 0)));
         }
         wcpOAV7EmpID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV7EmpID"), ",", "."));
         wcpOAV6AgeID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV6AgeID"), ",", "."));
         wcpOAV16ClienteID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV16ClienteID"), ",", "."));
         wcpOAV17OrdenPeriodo = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV17OrdenPeriodo"), ",", "."));
         wcpOAV18OrdenAnio = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV18OrdenAnio"), ",", "."));
         wcpOAV8DespBodOpId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV8DespBodOpId"), ",", "."));
         if ( ! GetJustCreated( ) && ( ( AV7EmpID != wcpOAV7EmpID ) || ( AV6AgeID != wcpOAV6AgeID ) || ( AV16ClienteID != wcpOAV16ClienteID ) || ( AV17OrdenPeriodo != wcpOAV17OrdenPeriodo ) || ( AV18OrdenAnio != wcpOAV18OrdenAnio ) || ( AV8DespBodOpId != wcpOAV8DespBodOpId ) ) )
         {
            setjustcreated();
         }
         wcpOAV7EmpID = AV7EmpID;
         wcpOAV6AgeID = AV6AgeID;
         wcpOAV16ClienteID = AV16ClienteID;
         wcpOAV17OrdenPeriodo = AV17OrdenPeriodo;
         wcpOAV18OrdenAnio = AV18OrdenAnio;
         wcpOAV8DespBodOpId = AV8DespBodOpId;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV7EmpID = cgiGet( sPrefix+"AV7EmpID_CTRL");
         if ( StringUtil.Len( sCtrlAV7EmpID) > 0 )
         {
            AV7EmpID = (short)(context.localUtil.CToN( cgiGet( sCtrlAV7EmpID), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7EmpID), 4, 0)));
         }
         else
         {
            AV7EmpID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"AV7EmpID_PARM"), ",", "."));
         }
         sCtrlAV6AgeID = cgiGet( sPrefix+"AV6AgeID_CTRL");
         if ( StringUtil.Len( sCtrlAV6AgeID) > 0 )
         {
            AV6AgeID = (short)(context.localUtil.CToN( cgiGet( sCtrlAV6AgeID), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6AgeID), 4, 0)));
         }
         else
         {
            AV6AgeID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"AV6AgeID_PARM"), ",", "."));
         }
         sCtrlAV16ClienteID = cgiGet( sPrefix+"AV16ClienteID_CTRL");
         if ( StringUtil.Len( sCtrlAV16ClienteID) > 0 )
         {
            AV16ClienteID = (short)(context.localUtil.CToN( cgiGet( sCtrlAV16ClienteID), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV16ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16ClienteID), 4, 0)));
         }
         else
         {
            AV16ClienteID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"AV16ClienteID_PARM"), ",", "."));
         }
         sCtrlAV17OrdenPeriodo = cgiGet( sPrefix+"AV17OrdenPeriodo_CTRL");
         if ( StringUtil.Len( sCtrlAV17OrdenPeriodo) > 0 )
         {
            AV17OrdenPeriodo = (short)(context.localUtil.CToN( cgiGet( sCtrlAV17OrdenPeriodo), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV17OrdenPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17OrdenPeriodo), 2, 0)));
         }
         else
         {
            AV17OrdenPeriodo = (short)(context.localUtil.CToN( cgiGet( sPrefix+"AV17OrdenPeriodo_PARM"), ",", "."));
         }
         sCtrlAV18OrdenAnio = cgiGet( sPrefix+"AV18OrdenAnio_CTRL");
         if ( StringUtil.Len( sCtrlAV18OrdenAnio) > 0 )
         {
            AV18OrdenAnio = (short)(context.localUtil.CToN( cgiGet( sCtrlAV18OrdenAnio), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18OrdenAnio), 4, 0)));
         }
         else
         {
            AV18OrdenAnio = (short)(context.localUtil.CToN( cgiGet( sPrefix+"AV18OrdenAnio_PARM"), ",", "."));
         }
         sCtrlAV8DespBodOpId = cgiGet( sPrefix+"AV8DespBodOpId_CTRL");
         if ( StringUtil.Len( sCtrlAV8DespBodOpId) > 0 )
         {
            AV8DespBodOpId = (short)(context.localUtil.CToN( cgiGet( sCtrlAV8DespBodOpId), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8DespBodOpId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8DespBodOpId), 4, 0)));
         }
         else
         {
            AV8DespBodOpId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"AV8DespBodOpId_PARM"), ",", "."));
         }
      }

      public override void componentprocess( String sPPrefix ,
                                             String sPSFPrefix ,
                                             String sCompEvt )
      {
         sCompPrefix = sPPrefix;
         sSFPrefix = sPSFPrefix;
         sPrefix = sCompPrefix + sSFPrefix;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         INITWEB( ) ;
         nDraw = 0;
         PA5L2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS5L2( ) ;
         if ( isFullAjaxMode( ) )
         {
            componentdraw();
         }
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override void componentstart( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
      }

      protected void WCStart( )
      {
         nDraw = 1;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WS5L2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"AV7EmpID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7EmpID), 4, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV7EmpID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV7EmpID_CTRL", StringUtil.RTrim( sCtrlAV7EmpID));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"AV6AgeID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6AgeID), 4, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV6AgeID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV6AgeID_CTRL", StringUtil.RTrim( sCtrlAV6AgeID));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"AV16ClienteID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16ClienteID), 4, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV16ClienteID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV16ClienteID_CTRL", StringUtil.RTrim( sCtrlAV16ClienteID));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"AV17OrdenPeriodo_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17OrdenPeriodo), 2, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV17OrdenPeriodo)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV17OrdenPeriodo_CTRL", StringUtil.RTrim( sCtrlAV17OrdenPeriodo));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"AV18OrdenAnio_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18OrdenAnio), 4, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV18OrdenAnio)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV18OrdenAnio_CTRL", StringUtil.RTrim( sCtrlAV18OrdenAnio));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"AV8DespBodOpId_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8DespBodOpId), 4, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV8DespBodOpId)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV8DespBodOpId_CTRL", StringUtil.RTrim( sCtrlAV8DespBodOpId));
         }
      }

      public override void componentdraw( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WCParametersSet( ) ;
         WE5L2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override String getstring( String sGXControl )
      {
         String sCtrlName ;
         if ( StringUtil.StrCmp(StringUtil.Substring( sGXControl, 1, 1), "&") == 0 )
         {
            sCtrlName = StringUtil.Substring( sGXControl, 2, StringUtil.Len( sGXControl)-1);
         }
         else
         {
            sCtrlName = sGXControl;
         }
         return cgiGet( sPrefix+"v"+StringUtil.Upper( sCtrlName)) ;
      }

      public override void componentjscripts( )
      {
         include_jscripts( ) ;
      }

      public override void componentthemes( )
      {
         define_styles( ) ;
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ), true);
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20231192234322", true);
            idxLst = (int)(idxLst+1);
         }
         if ( ! outputEnabled )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("wcdespachoop.js", "?20231192234322", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_192( )
      {
         chkavSelect_Internalname = sPrefix+"vSELECT_"+sGXsfl_19_idx;
         edtnroReg_Internalname = sPrefix+"NROREG_"+sGXsfl_19_idx;
         edtDespBodCodPrd_Internalname = sPrefix+"DESPBODCODPRD_"+sGXsfl_19_idx;
         edtDespBodPrdNombre_Internalname = sPrefix+"DESPBODPRDNOMBRE_"+sGXsfl_19_idx;
         edtDespBodCant_Internalname = sPrefix+"DESPBODCANT_"+sGXsfl_19_idx;
         edtDespBodValor_Internalname = sPrefix+"DESPBODVALOR_"+sGXsfl_19_idx;
         edtavDespbodadesp_Internalname = sPrefix+"vDESPBODADESP_"+sGXsfl_19_idx;
         edtDespBodDif_Internalname = sPrefix+"DESPBODDIF_"+sGXsfl_19_idx;
         edtDespBodADesp_Internalname = sPrefix+"DESPBODADESP_"+sGXsfl_19_idx;
         edtDespBodStock_Internalname = sPrefix+"DESPBODSTOCK_"+sGXsfl_19_idx;
         edtDespBodDetalle_Internalname = sPrefix+"DESPBODDETALLE_"+sGXsfl_19_idx;
         edtavDespachado_Internalname = sPrefix+"vDESPACHADO_"+sGXsfl_19_idx;
      }

      protected void SubsflControlProps_fel_192( )
      {
         chkavSelect_Internalname = sPrefix+"vSELECT_"+sGXsfl_19_fel_idx;
         edtnroReg_Internalname = sPrefix+"NROREG_"+sGXsfl_19_fel_idx;
         edtDespBodCodPrd_Internalname = sPrefix+"DESPBODCODPRD_"+sGXsfl_19_fel_idx;
         edtDespBodPrdNombre_Internalname = sPrefix+"DESPBODPRDNOMBRE_"+sGXsfl_19_fel_idx;
         edtDespBodCant_Internalname = sPrefix+"DESPBODCANT_"+sGXsfl_19_fel_idx;
         edtDespBodValor_Internalname = sPrefix+"DESPBODVALOR_"+sGXsfl_19_fel_idx;
         edtavDespbodadesp_Internalname = sPrefix+"vDESPBODADESP_"+sGXsfl_19_fel_idx;
         edtDespBodDif_Internalname = sPrefix+"DESPBODDIF_"+sGXsfl_19_fel_idx;
         edtDespBodADesp_Internalname = sPrefix+"DESPBODADESP_"+sGXsfl_19_fel_idx;
         edtDespBodStock_Internalname = sPrefix+"DESPBODSTOCK_"+sGXsfl_19_fel_idx;
         edtDespBodDetalle_Internalname = sPrefix+"DESPBODDETALLE_"+sGXsfl_19_fel_idx;
         edtavDespachado_Internalname = sPrefix+"vDESPACHADO_"+sGXsfl_19_fel_idx;
      }

      protected void sendrow_192( )
      {
         SubsflControlProps_192( ) ;
         WB5L0( ) ;
         Grid1Row = GXWebRow.GetNew(context,Grid1Container);
         if ( subGrid1_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGrid1_Backstyle = 0;
            if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
            {
               subGrid1_Linesclass = subGrid1_Class+"Odd";
            }
         }
         else if ( subGrid1_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGrid1_Backstyle = 0;
            subGrid1_Backcolor = subGrid1_Allbackcolor;
            if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
            {
               subGrid1_Linesclass = subGrid1_Class+"Uniform";
            }
         }
         else if ( subGrid1_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGrid1_Backstyle = 1;
            if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
            {
               subGrid1_Linesclass = subGrid1_Class+"Odd";
            }
            subGrid1_Backcolor = (int)(0x0);
         }
         else if ( subGrid1_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGrid1_Backstyle = 1;
            if ( ((int)(((nGXsfl_19_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGrid1_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd";
               }
            }
            else
            {
               subGrid1_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Even";
               }
            }
         }
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<tr ") ;
            context.WriteHtmlText( " class=\""+"WorkWith"+"\" style=\""+""+"\"") ;
            context.WriteHtmlText( " gxrow=\""+sGXsfl_19_idx+"\">") ;
         }
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
         }
         /* Check box */
         TempTags = " " + ((chkavSelect.Enabled!=0)&&(chkavSelect.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 20,'"+sPrefix+"',false,'"+sGXsfl_19_idx+"',19)\"" : " ");
         ClassString = "CheckBox";
         StyleString = "";
         Grid1Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavSelect_Internalname,StringUtil.Str( (decimal)(AV20select), 1, 0),(String)"",(String)"",(short)-1,chkavSelect.Enabled,(String)"1",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn WWOptionalColumn",(String)"",TempTags+" onclick=\"gx.fn.checkboxClick(20, this, 1, 0);gx.evt.onchange(this, event);\" "});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtnroReg_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A400nroReg), 6, 0, ",", "")),context.localUtil.Format( (decimal)(A400nroReg), "ZZZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtnroReg_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)50,(String)"px",(short)17,(String)"px",(short)6,(short)0,(short)0,(short)19,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodCodPrd_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A355DespBodCodPrd), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A355DespBodCodPrd), "ZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodCodPrd_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)65,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)19,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodPrdNombre_Internalname,StringUtil.RTrim( A356DespBodPrdNombre),StringUtil.RTrim( context.localUtil.Format( A356DespBodPrdNombre, "@!")),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodPrdNombre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)270,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)19,(short)1,(short)-1,(short)-1,(bool)true,(String)"nombres",(String)"left",(bool)true});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodCant_Internalname,StringUtil.LTrim( StringUtil.NToC( A357DespBodCant, 8, 2, ",", "")),context.localUtil.Format( A357DespBodCant, "ZZZZ9.99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodCant_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)80,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)19,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodValor_Internalname,StringUtil.LTrim( StringUtil.NToC( A358DespBodValor, 8, 2, ",", "")),context.localUtil.Format( A358DespBodValor, "ZZZZ9.99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodValor_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)80,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)19,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavDespbodadesp_Enabled!=0)&&(edtavDespbodadesp_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 26,'"+sPrefix+"',false,'"+sGXsfl_19_idx+"',19)\"" : " ");
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavDespbodadesp_Internalname,StringUtil.LTrim( StringUtil.NToC( AV5DespBodADesp, 8, 2, ",", "")),StringUtil.LTrim( context.localUtil.Format( AV5DespBodADesp, "ZZZZ9.99")),TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+((edtavDespbodadesp_Enabled!=0)&&(edtavDespbodadesp_Visible!=0) ? " onblur=\""+";gx.evt.onblur(this,26);\"" : " "),(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavDespbodadesp_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(int)edtavDespbodadesp_Enabled,(short)1,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)19,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodDif_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A362DespBodDif), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A362DespBodDif), "ZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodDif_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)60,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)19,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "AttributeBold";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodADesp_Internalname,StringUtil.LTrim( StringUtil.NToC( A359DespBodADesp, 8, 2, ",", "")),context.localUtil.Format( A359DespBodADesp, "ZZZZ9.99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodADesp_Jsonclick,(short)0,(String)"AttributeBold",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)60,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)19,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodStock_Internalname,StringUtil.LTrim( StringUtil.NToC( A360DespBodStock, 6, 2, ",", "")),context.localUtil.Format( A360DespBodStock, "ZZ9.99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodStock_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)6,(short)0,(short)0,(short)19,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodDetalle_Internalname,StringUtil.RTrim( A376DespBodDetalle),(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodDetalle_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)19,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
         }
         /* Static Bitmap Variable */
         ClassString = "ImageAttribute";
         StyleString = "";
         AV23despachado_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV23despachado))&&String.IsNullOrEmpty(StringUtil.RTrim( AV27Despachado_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV23despachado)));
         sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV23despachado)) ? AV27Despachado_GXI : context.PathToRelativeUrl( AV23despachado));
         Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDespachado_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)0,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV23despachado_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
         send_integrity_lvl_hashes5L2( ) ;
         Grid1Container.AddRow(Grid1Row);
         nGXsfl_19_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_19_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_19_idx+1));
         sGXsfl_19_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_19_idx), 4, 0)), 4, "0");
         SubsflControlProps_192( ) ;
         /* End function sendrow_192 */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "vSELECT_" + sGXsfl_19_idx;
         chkavSelect.Name = GXCCtl;
         chkavSelect.WebTags = "";
         chkavSelect.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, chkavSelect_Internalname, "TitleCaption", chkavSelect.Caption, !bGXsfl_19_Refreshing);
         chkavSelect.CheckedValue = "0";
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttAdddespop_Internalname = sPrefix+"ADDDESPOP";
         bttGenerarinv_Internalname = sPrefix+"GENERARINV";
         divTbflx_Internalname = sPrefix+"TBFLX";
         chkavSelect_Internalname = sPrefix+"vSELECT";
         edtnroReg_Internalname = sPrefix+"NROREG";
         edtDespBodCodPrd_Internalname = sPrefix+"DESPBODCODPRD";
         edtDespBodPrdNombre_Internalname = sPrefix+"DESPBODPRDNOMBRE";
         edtDespBodCant_Internalname = sPrefix+"DESPBODCANT";
         edtDespBodValor_Internalname = sPrefix+"DESPBODVALOR";
         edtavDespbodadesp_Internalname = sPrefix+"vDESPBODADESP";
         edtDespBodDif_Internalname = sPrefix+"DESPBODDIF";
         edtDespBodADesp_Internalname = sPrefix+"DESPBODADESP";
         edtDespBodStock_Internalname = sPrefix+"DESPBODSTOCK";
         edtDespBodDetalle_Internalname = sPrefix+"DESPBODDETALLE";
         edtavDespachado_Internalname = sPrefix+"vDESPACHADO";
         divTable1_Internalname = sPrefix+"TABLE1";
         divMaintable_Internalname = sPrefix+"MAINTABLE";
         Form.Internalname = sPrefix+"FORM";
         subGrid1_Internalname = sPrefix+"GRID1";
      }

      public override void initialize_properties( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.SetDefaultTheme("Carmine");
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         init_default_properties( ) ;
         chkavSelect.Caption = "";
         edtDespBodDetalle_Jsonclick = "";
         edtDespBodStock_Jsonclick = "";
         edtDespBodADesp_Jsonclick = "";
         edtDespBodDif_Jsonclick = "";
         edtavDespbodadesp_Jsonclick = "";
         edtavDespbodadesp_Visible = -1;
         edtDespBodValor_Jsonclick = "";
         edtDespBodCant_Jsonclick = "";
         edtDespBodPrdNombre_Jsonclick = "";
         edtDespBodCodPrd_Jsonclick = "";
         edtnroReg_Jsonclick = "";
         chkavSelect.Visible = -1;
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         subGrid1_Sortable = 0;
         subGrid1_Header = "";
         subGrid1_Class = "WorkWith";
         subGrid1_Backcolorstyle = 0;
         chkavSelect.Enabled = 0;
         edtavDespbodadesp_Enabled = 0;
         context.GX_msglist.DisplayMode = 1;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9'},{av:'AV6AgeID',fld:'vAGEID',pic:'ZZZ9'},{av:'AV8DespBodOpId',fld:'vDESPBODOPID',pic:'ZZZ9'},{av:'edtavDespbodadesp_Enabled',ctrl:'vDESPBODADESP',prop:'Enabled'},{av:'chkavSelect.Enabled',ctrl:'vSELECT',prop:'Enabled'},{av:'sPrefix'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'ADDDESPBODEGA'","{handler:'E115L1',iparms:[]");
         setEventMetadata("'ADDDESPBODEGA'",",oparms:[]}");
         setEventMetadata("'GENERARDESP'","{handler:'E125L1',iparms:[]");
         setEventMetadata("'GENERARDESP'",",oparms:[]}");
         return  ;
      }

      public override void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sPrefix = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         bttAdddespop_Jsonclick = "";
         bttGenerarinv_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         A356DespBodPrdNombre = "";
         A376DespBodDetalle = "";
         AV23despachado = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV27Despachado_GXI = "";
         scmdbuf = "";
         H005L2_A353DespBodNro = new short[1] ;
         H005L2_A5ClienteID = new short[1] ;
         H005L2_A22OrdenID = new short[1] ;
         H005L2_A376DespBodDetalle = new String[] {""} ;
         H005L2_n376DespBodDetalle = new bool[] {false} ;
         H005L2_A358DespBodValor = new decimal[1] ;
         H005L2_n358DespBodValor = new bool[] {false} ;
         H005L2_A356DespBodPrdNombre = new String[] {""} ;
         H005L2_n356DespBodPrdNombre = new bool[] {false} ;
         H005L2_A400nroReg = new int[1] ;
         H005L2_A359DespBodADesp = new decimal[1] ;
         H005L2_n359DespBodADesp = new bool[] {false} ;
         H005L2_A357DespBodCant = new decimal[1] ;
         H005L2_n357DespBodCant = new bool[] {false} ;
         H005L2_A42BodCod = new short[1] ;
         H005L2_A355DespBodCodPrd = new short[1] ;
         H005L2_n355DespBodCodPrd = new bool[] {false} ;
         H005L2_A2AgeID = new short[1] ;
         H005L2_A1EmpID = new short[1] ;
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV7EmpID = "";
         sCtrlAV6AgeID = "";
         sCtrlAV16ClienteID = "";
         sCtrlAV17OrdenPeriodo = "";
         sCtrlAV18OrdenAnio = "";
         sCtrlAV8DespBodOpId = "";
         ROClassString = "";
         sImgUrl = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wcdespachoop__default(),
            new Object[][] {
                new Object[] {
               H005L2_A353DespBodNro, H005L2_A5ClienteID, H005L2_A22OrdenID, H005L2_A376DespBodDetalle, H005L2_n376DespBodDetalle, H005L2_A358DespBodValor, H005L2_n358DespBodValor, H005L2_A356DespBodPrdNombre, H005L2_n356DespBodPrdNombre, H005L2_A400nroReg,
               H005L2_A359DespBodADesp, H005L2_n359DespBodADesp, H005L2_A357DespBodCant, H005L2_n357DespBodCant, H005L2_A42BodCod, H005L2_A355DespBodCodPrd, H005L2_n355DespBodCodPrd, H005L2_A2AgeID, H005L2_A1EmpID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV7EmpID ;
      private short AV6AgeID ;
      private short AV16ClienteID ;
      private short AV17OrdenPeriodo ;
      private short AV18OrdenAnio ;
      private short AV8DespBodOpId ;
      private short wcpOAV7EmpID ;
      private short wcpOAV6AgeID ;
      private short wcpOAV16ClienteID ;
      private short wcpOAV17OrdenPeriodo ;
      private short wcpOAV18OrdenAnio ;
      private short wcpOAV8DespBodOpId ;
      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short nRC_GXsfl_19 ;
      private short nGXsfl_19_idx=1 ;
      private short initialized ;
      private short A1EmpID ;
      private short A2AgeID ;
      private short A42BodCod ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Sortable ;
      private short AV20select ;
      private short A355DespBodCodPrd ;
      private short A362DespBodDif ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short A353DespBodNro ;
      private short A5ClienteID ;
      private short A22OrdenID ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private short GRID1_nEOF ;
      private int edtavDespbodadesp_Enabled ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int A400nroReg ;
      private int subGrid1_Selectedindex ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int subGrid1_Islastpage ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private int edtavDespbodadesp_Visible ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nFirstRecordOnPage ;
      private decimal A357DespBodCant ;
      private decimal A358DespBodValor ;
      private decimal AV5DespBodADesp ;
      private decimal A359DespBodADesp ;
      private decimal A360DespBodStock ;
      private decimal GXt_decimal1 ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_19_idx="0001" ;
      private String edtavDespbodadesp_Internalname ;
      private String chkavSelect_Internalname ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String divMaintable_Internalname ;
      private String divTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divTbflx_Internalname ;
      private String TempTags ;
      private String bttAdddespop_Internalname ;
      private String bttAdddespop_Jsonclick ;
      private String bttGenerarinv_Internalname ;
      private String bttGenerarinv_Jsonclick ;
      private String sStyleString ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String subGrid1_Header ;
      private String A356DespBodPrdNombre ;
      private String A376DespBodDetalle ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtnroReg_Internalname ;
      private String edtDespBodCodPrd_Internalname ;
      private String edtDespBodPrdNombre_Internalname ;
      private String edtDespBodCant_Internalname ;
      private String edtDespBodValor_Internalname ;
      private String edtDespBodDif_Internalname ;
      private String edtDespBodADesp_Internalname ;
      private String edtDespBodStock_Internalname ;
      private String edtDespBodDetalle_Internalname ;
      private String edtavDespachado_Internalname ;
      private String scmdbuf ;
      private String sCtrlAV7EmpID ;
      private String sCtrlAV6AgeID ;
      private String sCtrlAV16ClienteID ;
      private String sCtrlAV17OrdenPeriodo ;
      private String sCtrlAV18OrdenAnio ;
      private String sCtrlAV8DespBodOpId ;
      private String sGXsfl_19_fel_idx="0001" ;
      private String ROClassString ;
      private String edtnroReg_Jsonclick ;
      private String edtDespBodCodPrd_Jsonclick ;
      private String edtDespBodPrdNombre_Jsonclick ;
      private String edtDespBodCant_Jsonclick ;
      private String edtDespBodValor_Jsonclick ;
      private String edtavDespbodadesp_Jsonclick ;
      private String edtDespBodDif_Jsonclick ;
      private String edtDespBodADesp_Jsonclick ;
      private String edtDespBodStock_Jsonclick ;
      private String edtDespBodDetalle_Jsonclick ;
      private String sImgUrl ;
      private String GXCCtl ;
      private bool entryPointCalled ;
      private bool bGXsfl_19_Refreshing=false ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n355DespBodCodPrd ;
      private bool n356DespBodPrdNombre ;
      private bool n357DespBodCant ;
      private bool n358DespBodValor ;
      private bool n359DespBodADesp ;
      private bool n376DespBodDetalle ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV23despachado_IsBlob ;
      private String AV27Despachado_GXI ;
      private String AV23despachado ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCheckbox chkavSelect ;
      private IDataStoreProvider pr_default ;
      private short[] H005L2_A353DespBodNro ;
      private short[] H005L2_A5ClienteID ;
      private short[] H005L2_A22OrdenID ;
      private String[] H005L2_A376DespBodDetalle ;
      private bool[] H005L2_n376DespBodDetalle ;
      private decimal[] H005L2_A358DespBodValor ;
      private bool[] H005L2_n358DespBodValor ;
      private String[] H005L2_A356DespBodPrdNombre ;
      private bool[] H005L2_n356DespBodPrdNombre ;
      private int[] H005L2_A400nroReg ;
      private decimal[] H005L2_A359DespBodADesp ;
      private bool[] H005L2_n359DespBodADesp ;
      private decimal[] H005L2_A357DespBodCant ;
      private bool[] H005L2_n357DespBodCant ;
      private short[] H005L2_A42BodCod ;
      private short[] H005L2_A355DespBodCodPrd ;
      private bool[] H005L2_n355DespBodCodPrd ;
      private short[] H005L2_A2AgeID ;
      private short[] H005L2_A1EmpID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class wcdespachoop__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH005L2 ;
          prmH005L2 = new Object[] {
          new Object[] {"@AV7EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8DespBodOpId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H005L2", "SELECT T1.[DespBodNro], T1.[ClienteID], T1.[OrdenID], T1.[DespBodDetalle], T1.[DespBodValor], T1.[DespBodPrdNombre], T1.[nroReg], T1.[DespBodADesp], T1.[DespBodCant], T2.[BodCod], T1.[DespBodCodPrd], T1.[AgeID], T1.[EmpID] FROM ([DespBodegaprd] T1 WITH (NOLOCK) INNER JOIN [DespBodega] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[AgeID] = T1.[AgeID] AND T2.[DespBodNro] = T1.[DespBodNro] AND T2.[OrdenID] = T1.[OrdenID] AND T2.[ClienteID] = T1.[ClienteID]) WHERE (T1.[EmpID] = @AV7EmpID and T1.[AgeID] = @AV6AgeID) AND (T1.[OrdenID] = @AV8DespBodOpId) ORDER BY T1.[EmpID], T1.[AgeID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005L2,11,0,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((decimal[]) buf[5])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((String[]) buf[7])[0] = rslt.getString(6, 40) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                ((int[]) buf[9])[0] = rslt.getInt(7) ;
                ((decimal[]) buf[10])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(8);
                ((decimal[]) buf[12])[0] = rslt.getDecimal(9) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(9);
                ((short[]) buf[14])[0] = rslt.getShort(10) ;
                ((short[]) buf[15])[0] = rslt.getShort(11) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(11);
                ((short[]) buf[17])[0] = rslt.getShort(12) ;
                ((short[]) buf[18])[0] = rslt.getShort(13) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
       }
    }

 }

}
