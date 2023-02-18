/*
               File: rptStockBodega
        Description: rpt Stock Bodega
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 12/30/2022 12:38:24.9
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
   public class rptstockbodega : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public rptstockbodega( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public rptstockbodega( IGxContext context )
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
                           String aP2_usucod )
      {
         this.AV16EmpID = aP0_EmpID;
         this.AV17AgeID = aP1_AgeID;
         this.AV11usucod = aP2_usucod;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynavTipoprodid = new GXCombobox();
         dynavPrdcod = new GXCombobox();
         radavTiporpt = new GXRadio();
         radavFormato = new GXRadio();
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vTIPOPRODID") == 0 )
            {
               AV16EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16EmpID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV16EmpID), "ZZZ9"), context));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvTIPOPRODID5S2( AV16EmpID) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vPRDCOD") == 0 )
            {
               AV16EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16EmpID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV16EmpID), "ZZZ9"), context));
               AV17AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17AgeID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV17AgeID), "ZZZ9"), context));
               AV10tipoProdID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10tipoProdID), 4, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvPRDCOD5S2( AV16EmpID, AV17AgeID, AV10tipoProdID) ;
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
            else
            {
               if ( ! IsValidAjaxCall( false) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = gxfirstwebparm_bkp;
            }
            if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
            {
               AV16EmpID = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16EmpID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV16EmpID), "ZZZ9"), context));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV17AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17AgeID), 4, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV17AgeID), "ZZZ9"), context));
                  AV11usucod = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11usucod", AV11usucod);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV11usucod, "")), context));
               }
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
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
            ValidateSpaRequest();
            PA5S2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0;
               GXVvTIPOPRODID_html5S2( AV16EmpID) ;
               GXVvPRDCOD_html5S2( AV16EmpID, AV17AgeID, AV10tipoProdID) ;
               WS5S2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE5S2( ) ;
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
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( "rpt Stock Bodega") ;
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
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 126726), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("bootstrap/js/bootstrap.min.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxcfg.js", "?2022123012382420", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("calendar-es.js", "?"+context.GetBuildNumber( 126726), false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("rptstockbodega.aspx") + "?" + UrlEncode("" +AV16EmpID) + "," + UrlEncode("" +AV17AgeID) + "," + UrlEncode(StringUtil.RTrim(AV11usucod))+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" style=\"display:none\">") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "form-horizontal Form", true);
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
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
         GxWebStd.gx_hidden_field( context, "vBODCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18BodCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vUSUCOD", StringUtil.RTrim( AV11usucod));
         GxWebStd.gx_hidden_field( context, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV11usucod, "")), context));
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV16EmpID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17AgeID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV17AgeID), "ZZZ9"), context));
      }

      protected void RenderHtmlCloseForm5S2( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken((String)(sPrefix));
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

      public override String GetPgmname( )
      {
         return "rptStockBodega" ;
      }

      public override String GetPgmdesc( )
      {
         return "rpt Stock Bodega" ;
      }

      protected void WB5S0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            RenderHtmlHeaders( ) ;
            RenderHtmlOpenForm( ) ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "WWAdvancedContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-lg-6 col-lg-offset-3", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable1_Internalname, 1, 0, "px", 0, "px", "FormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable4_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-lg-9 col-lg-offset-1", "Center", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Stock Bodega", "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_rptStockBodega.htm");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable2_Internalname, 1, 0, "px", 0, "px", "FormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3 col-lg-12 col-lg-offset-0 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable3_Internalname, 1, 0, "px", 0, "px", "Flex", "left", "top", " "+"data-gx-flex"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "", "left", "top", "", "flex-grow::1;", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavFdesde_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavFdesde_Internalname, "Fechas ", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavFdesde_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavFdesde_Internalname, context.localUtil.Format(AV5fdesde, "99/99/9999"), context.localUtil.Format( AV5fdesde, "99/99/9999"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,22);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavFdesde_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavFdesde_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_rptStockBodega.htm");
            GxWebStd.gx_bitmap( context, edtavFdesde_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavFdesde_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_rptStockBodega.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "", "left", "top", "", "flex-grow::1;", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavFhasta_Internalname, "f Hasta", "col-sm-3 AttributePaddingLeftLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavFhasta_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavFhasta_Internalname, context.localUtil.Format(AV6fHasta, "99/99/9999"), context.localUtil.Format( AV6fHasta, "99/99/9999"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,25);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavFhasta_Jsonclick, 0, "AttributePaddingLeft", "", "", "", "", 1, edtavFhasta_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_rptStockBodega.htm");
            GxWebStd.gx_bitmap( context, edtavFhasta_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavFhasta_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_rptStockBodega.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynavTipoprodid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavTipoprodid_Internalname, "Tipo Producto", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavTipoprodid, dynavTipoprodid_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV10tipoProdID), 4, 0)), 1, dynavTipoprodid_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dynavTipoprodid.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,30);\"", "", true, "HLP_rptStockBodega.htm");
            dynavTipoprodid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV10tipoProdID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavTipoprodid_Internalname, "Values", (String)(dynavTipoprodid.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynavPrdcod_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavPrdcod_Internalname, "Productos", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavPrdcod, dynavPrdcod_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV7prdCod), 4, 0)), 1, dynavPrdcod_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dynavPrdcod.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,35);\"", "", true, "HLP_rptStockBodega.htm");
            dynavPrdcod.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV7prdCod), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavPrdcod_Internalname, "Values", (String)(dynavPrdcod.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable6_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+radavTiporpt_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, radavTiporpt_Internalname, "Tipo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Radio button */
            ClassString = "Attribute";
            StyleString = "";
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            GxWebStd.gx_radio_ctrl( context, radavTiporpt, radavTiporpt_Internalname, StringUtil.Str( (decimal)(AV13tipoRpt), 1, 0), "", 1, 1, 0, 0, StyleString, ClassString, "", "", 0, radavTiporpt_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", TempTags+" onclick=\"gx.evt.onchange(this, event);\" ", "HLP_rptStockBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, radavFormato_Internalname, "Formato", "col-sm-3 AttributePaddingLeftLabel", 0, true);
            /* Radio button */
            ClassString = "AttributePaddingLeft";
            StyleString = "";
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            GxWebStd.gx_radio_ctrl( context, radavFormato, radavFormato_Internalname, StringUtil.Str( (decimal)(AV20formato), 1, 0), "", 1, 1, 0, 0, StyleString, ClassString, "", "", 0, radavFormato_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", TempTags+" onclick=\"gx.evt.onchange(this, event);\" ", "HLP_rptStockBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 TableCellBtnActions", "Center", "Middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "", "Aceptar", bttButton1_Jsonclick, 5, "Aceptar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'ACEPTAR\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_rptStockBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttButton2_Internalname, "", "Cancelar", bttButton2_Jsonclick, 7, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e115s1_client"+"'", TempTags, "", 2, "HLP_rptStockBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "Middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START5S2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "rpt Stock Bodega", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP5S0( ) ;
      }

      protected void WS5S2( )
      {
         START5S2( ) ;
         EVT5S2( ) ;
      }

      protected void EVT5S2( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               sEvt = cgiGet( "_EventName");
               EvtGridId = cgiGet( "_EventGridId");
               EvtRowId = cgiGet( "_EventRowId");
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
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "'ACEPTAR'") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: 'Aceptar' */
                           E125S2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E135S2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Load */
                           E145S2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           if ( ! wbErr )
                           {
                              Rfr0gs = false;
                              if ( ! Rfr0gs )
                              {
                              }
                              dynload_actions( ) ;
                           }
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           dynload_actions( ) ;
                        }
                     }
                     else
                     {
                     }
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void WE5S2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm5S2( ) ;
            }
         }
      }

      protected void PA5S2( )
      {
         if ( nDonePA == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
            }
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            init_web_controls( ) ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = edtavFdesde_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         GXVvPRDCOD_html5S2( AV16EmpID, AV17AgeID, AV10tipoProdID) ;
         GXVvPRDCOD_html5S2( AV16EmpID, AV17AgeID, AV10tipoProdID) ;
         GXVvPRDCOD_html5S2( AV16EmpID, AV17AgeID, AV10tipoProdID) ;
         /* End function dynload_actions */
      }

      protected void GXDLVvTIPOPRODID5S2( short AV16EmpID )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvTIPOPRODID_data5S2( AV16EmpID) ;
         gxdynajaxindex = 1;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{\"c\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)))+"\",\"d\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1);
            gxwrpcisep = ",";
         }
         context.GX_webresponse.AddString("]");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GXVvTIPOPRODID_html5S2( short AV16EmpID )
      {
         short gxdynajaxvalue ;
         GXDLVvTIPOPRODID_data5S2( AV16EmpID) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavTipoprodid.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (short)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynavTipoprodid.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 4, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvTIPOPRODID_data5S2( short AV16EmpID )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Todos");
         /* Using cursor H005S2 */
         pr_default.execute(0, new Object[] {AV16EmpID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(H005S2_A31tipoProdID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H005S2_A144tipoProdDsc[0]));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void GXDLVvPRDCOD5S2( short AV16EmpID ,
                                      short AV17AgeID ,
                                      short AV10tipoProdID )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvPRDCOD_data5S2( AV16EmpID, AV17AgeID, AV10tipoProdID) ;
         gxdynajaxindex = 1;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{\"c\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)))+"\",\"d\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1);
            gxwrpcisep = ",";
         }
         context.GX_webresponse.AddString("]");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GXVvPRDCOD_html5S2( short AV16EmpID ,
                                         short AV17AgeID ,
                                         short AV10tipoProdID )
      {
         short gxdynajaxvalue ;
         GXDLVvPRDCOD_data5S2( AV16EmpID, AV17AgeID, AV10tipoProdID) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavPrdcod.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (short)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynavPrdcod.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 4, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvPRDCOD_data5S2( short AV16EmpID ,
                                           short AV17AgeID ,
                                           short AV10tipoProdID )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Todos");
         /* Using cursor H005S3 */
         pr_default.execute(1, new Object[] {AV16EmpID, AV17AgeID, AV10tipoProdID});
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(H005S3_A286PrdCod[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(H005S3_A309prdNombre[0]);
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void send_integrity_hashes( )
      {
      }

      protected void clear_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
            GXVvTIPOPRODID_html5S2( AV16EmpID) ;
            GXVvPRDCOD_html5S2( AV16EmpID, AV17AgeID, AV10tipoProdID) ;
            dynload_actions( ) ;
         }
      }

      protected void fix_multi_value_controls( )
      {
         if ( dynavTipoprodid.ItemCount > 0 )
         {
            AV10tipoProdID = (short)(NumberUtil.Val( dynavTipoprodid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV10tipoProdID), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10tipoProdID), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavTipoprodid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV10tipoProdID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavTipoprodid_Internalname, "Values", dynavTipoprodid.ToJavascriptSource(), true);
         }
         if ( dynavPrdcod.ItemCount > 0 )
         {
            AV7prdCod = (short)(NumberUtil.Val( dynavPrdcod.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV7prdCod), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7prdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7prdCod), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavPrdcod.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV7prdCod), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavPrdcod_Internalname, "Values", dynavPrdcod.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF5S2( ) ;
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

      protected void RF5S2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E145S2 ();
            WB5S0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes5S2( )
      {
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV16EmpID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17AgeID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV17AgeID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vUSUCOD", StringUtil.RTrim( AV11usucod));
         GxWebStd.gx_hidden_field( context, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV11usucod, "")), context));
      }

      protected void STRUP5S0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         GXVvTIPOPRODID_html5S2( AV16EmpID) ;
         GXVvPRDCOD_html5S2( AV16EmpID, AV17AgeID, AV10tipoProdID) ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E135S2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( context.localUtil.VCDate( cgiGet( edtavFdesde_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"fdesde"}), 1, "vFDESDE");
               GX_FocusControl = edtavFdesde_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV5fdesde = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5fdesde", context.localUtil.Format(AV5fdesde, "99/99/9999"));
            }
            else
            {
               AV5fdesde = context.localUtil.CToD( cgiGet( edtavFdesde_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5fdesde", context.localUtil.Format(AV5fdesde, "99/99/9999"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavFhasta_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"f Hasta"}), 1, "vFHASTA");
               GX_FocusControl = edtavFhasta_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6fHasta = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6fHasta", context.localUtil.Format(AV6fHasta, "99/99/9999"));
            }
            else
            {
               AV6fHasta = context.localUtil.CToD( cgiGet( edtavFhasta_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6fHasta", context.localUtil.Format(AV6fHasta, "99/99/9999"));
            }
            dynavTipoprodid.CurrentValue = cgiGet( dynavTipoprodid_Internalname);
            AV10tipoProdID = (short)(NumberUtil.Val( cgiGet( dynavTipoprodid_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10tipoProdID), 4, 0)));
            dynavPrdcod.CurrentValue = cgiGet( dynavPrdcod_Internalname);
            AV7prdCod = (short)(NumberUtil.Val( cgiGet( dynavPrdcod_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7prdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7prdCod), 4, 0)));
            if ( ( ( context.localUtil.CToN( cgiGet( radavTiporpt_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( radavTiporpt_Internalname), ",", ".") > Convert.ToDecimal( 9 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTIPORPT");
               wbErr = true;
               AV13tipoRpt = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13tipoRpt", StringUtil.Str( (decimal)(AV13tipoRpt), 1, 0));
            }
            else
            {
               AV13tipoRpt = (short)(context.localUtil.CToN( cgiGet( radavTiporpt_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13tipoRpt", StringUtil.Str( (decimal)(AV13tipoRpt), 1, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( radavFormato_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( radavFormato_Internalname), ",", ".") > Convert.ToDecimal( 9 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vFORMATO");
               wbErr = true;
               AV20formato = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20formato", StringUtil.Str( (decimal)(AV20formato), 1, 0));
            }
            else
            {
               AV20formato = (short)(context.localUtil.CToN( cgiGet( radavFormato_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20formato", StringUtil.Str( (decimal)(AV20formato), 1, 0));
            }
            /* Read saved values. */
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            GXVvTIPOPRODID_html5S2( AV16EmpID) ;
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void E125S2( )
      {
         /* 'Aceptar' Routine */
         if ( AV13tipoRpt == 1 )
         {
            if ( AV20formato == 1 )
            {
               CallWebObject(formatLink("apdfstockbodegaresumen.aspx") + "?" + UrlEncode(DateTimeUtil.FormatDateParm(AV5fdesde)) + "," + UrlEncode(DateTimeUtil.FormatDateParm(AV6fHasta)) + "," + UrlEncode("" +AV16EmpID) + "," + UrlEncode("" +AV17AgeID) + "," + UrlEncode("" +AV18BodCod) + "," + UrlEncode("" +AV7prdCod) + "," + UrlEncode(StringUtil.RTrim(AV11usucod)));
               context.wjLocDisableFrm = 0;
            }
            else
            {
               CallWebObject(formatLink("apdfstockbodega.aspx") + "?" + UrlEncode(DateTimeUtil.FormatDateParm(AV5fdesde)) + "," + UrlEncode(DateTimeUtil.FormatDateParm(AV6fHasta)) + "," + UrlEncode("" +AV16EmpID) + "," + UrlEncode("" +AV17AgeID) + "," + UrlEncode("" +AV18BodCod) + "," + UrlEncode("" +AV7prdCod) + "," + UrlEncode(StringUtil.RTrim(AV11usucod)));
               context.wjLocDisableFrm = 0;
            }
         }
         else
         {
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E135S2 ();
         if (returnInSub) return;
      }

      protected void E135S2( )
      {
         /* Start Routine */
         AV12fechaHoy = DateTimeUtil.ResetTime(DateTimeUtil.ServerNow( context, pr_default));
         AV5fdesde = context.localUtil.YMDToD( DateTimeUtil.Year( AV12fechaHoy), DateTimeUtil.Month( AV12fechaHoy), 1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5fdesde", context.localUtil.Format(AV5fdesde, "99/99/9999"));
         AV6fHasta = DateTimeUtil.DateEndOfMonth( AV5fdesde);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6fHasta", context.localUtil.Format(AV6fHasta, "99/99/9999"));
      }

      protected void nextLoad( )
      {
      }

      protected void E145S2( )
      {
         /* Load Routine */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV16EmpID = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16EmpID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV16EmpID), "ZZZ9"), context));
         AV17AgeID = Convert.ToInt16(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17AgeID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV17AgeID), "ZZZ9"), context));
         AV11usucod = (String)getParm(obj,2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11usucod", AV11usucod);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV11usucod, "")), context));
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
         PA5S2( ) ;
         WS5S2( ) ;
         WE5S2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ), true);
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022123012382532", true);
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
         context.AddJavascriptSource("messages.spa.js", "?"+GetCacheInvalidationToken( ), false);
         context.AddJavascriptSource("rptstockbodega.js", "?2022123012382532", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         dynavTipoprodid.Name = "vTIPOPRODID";
         dynavTipoprodid.WebTags = "";
         dynavPrdcod.Name = "vPRDCOD";
         dynavPrdcod.WebTags = "";
         radavTiporpt.Name = "vTIPORPT";
         radavTiporpt.WebTags = "";
         radavTiporpt.addItem("1", "Pdf", 0);
         radavTiporpt.addItem("2", "Excel", 0);
         radavFormato.Name = "vFORMATO";
         radavFormato.WebTags = "";
         radavFormato.addItem("1", "Resumen", 0);
         radavFormato.addItem("2", "Detallado", 0);
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1";
         divTable4_Internalname = "TABLE4";
         edtavFdesde_Internalname = "vFDESDE";
         edtavFhasta_Internalname = "vFHASTA";
         divTable3_Internalname = "TABLE3";
         dynavTipoprodid_Internalname = "vTIPOPRODID";
         dynavPrdcod_Internalname = "vPRDCOD";
         radavTiporpt_Internalname = "vTIPORPT";
         radavFormato_Internalname = "vFORMATO";
         divTable6_Internalname = "TABLE6";
         bttButton1_Internalname = "BUTTON1";
         bttButton2_Internalname = "BUTTON2";
         divTable2_Internalname = "TABLE2";
         divTable1_Internalname = "TABLE1";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         radavFormato_Jsonclick = "";
         radavTiporpt_Jsonclick = "";
         dynavPrdcod_Jsonclick = "";
         dynavPrdcod.Enabled = 1;
         dynavTipoprodid_Jsonclick = "";
         dynavTipoprodid.Enabled = 1;
         edtavFhasta_Jsonclick = "";
         edtavFhasta_Enabled = 1;
         edtavFdesde_Jsonclick = "";
         edtavFdesde_Enabled = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public void Validv_Tipoprodid( short GX_Parm1 ,
                                     short GX_Parm2 ,
                                     GXCombobox dynGX_Parm3 ,
                                     GXCombobox dynGX_Parm4 )
      {
         AV16EmpID = GX_Parm1;
         AV17AgeID = GX_Parm2;
         dynavTipoprodid = dynGX_Parm3;
         AV10tipoProdID = (short)(NumberUtil.Val( dynavTipoprodid.CurrentValue, "."));
         dynavPrdcod = dynGX_Parm4;
         AV7prdCod = (short)(NumberUtil.Val( dynavPrdcod.CurrentValue, "."));
         GXVvPRDCOD_html5S2( AV16EmpID, AV17AgeID, AV10tipoProdID) ;
         dynload_actions( ) ;
         if ( dynavPrdcod.ItemCount > 0 )
         {
            AV7prdCod = (short)(NumberUtil.Val( dynavPrdcod.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV7prdCod), 4, 0))), "."));
         }
         dynavPrdcod.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV7prdCod), 4, 0));
         isValidOutput.Add(dynavPrdcod);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV11usucod',fld:'vUSUCOD',pic:'',hsh:true},{av:'AV16EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavTipoprodid'},{av:'AV10tipoProdID',fld:'vTIPOPRODID',pic:'ZZZ9'},{av:'AV17AgeID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'dynavPrdcod'},{av:'AV7prdCod',fld:'vPRDCOD',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV16EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavTipoprodid'},{av:'AV10tipoProdID',fld:'vTIPOPRODID',pic:'ZZZ9'},{av:'AV17AgeID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'dynavPrdcod'},{av:'AV7prdCod',fld:'vPRDCOD',pic:'ZZZ9'}]}");
         setEventMetadata("'ACEPTAR'","{handler:'E125S2',iparms:[{av:'radavTiporpt'},{av:'AV13tipoRpt',fld:'vTIPORPT',pic:'9'},{av:'radavFormato'},{av:'AV20formato',fld:'vFORMATO',pic:'9'},{av:'AV5fdesde',fld:'vFDESDE',pic:''},{av:'AV6fHasta',fld:'vFHASTA',pic:''},{av:'AV18BodCod',fld:'vBODCOD',pic:'ZZZ9'},{av:'AV11usucod',fld:'vUSUCOD',pic:'',hsh:true},{av:'AV16EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavTipoprodid'},{av:'AV10tipoProdID',fld:'vTIPOPRODID',pic:'ZZZ9'},{av:'AV17AgeID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'dynavPrdcod'},{av:'AV7prdCod',fld:'vPRDCOD',pic:'ZZZ9'}]");
         setEventMetadata("'ACEPTAR'",",oparms:[{av:'AV16EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavTipoprodid'},{av:'AV10tipoProdID',fld:'vTIPOPRODID',pic:'ZZZ9'},{av:'AV17AgeID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'dynavPrdcod'},{av:'AV7prdCod',fld:'vPRDCOD',pic:'ZZZ9'}]}");
         setEventMetadata("'CANCEL'","{handler:'E115S1',iparms:[{av:'AV16EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavTipoprodid'},{av:'AV10tipoProdID',fld:'vTIPOPRODID',pic:'ZZZ9'},{av:'AV17AgeID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'dynavPrdcod'},{av:'AV7prdCod',fld:'vPRDCOD',pic:'ZZZ9'}]");
         setEventMetadata("'CANCEL'",",oparms:[{av:'AV16EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavTipoprodid'},{av:'AV10tipoProdID',fld:'vTIPOPRODID',pic:'ZZZ9'},{av:'AV17AgeID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'dynavPrdcod'},{av:'AV7prdCod',fld:'vPRDCOD',pic:'ZZZ9'}]}");
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
         wcpOAV11usucod = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         GX_FocusControl = "";
         sPrefix = "";
         lblTextblock1_Jsonclick = "";
         TempTags = "";
         AV5fdesde = DateTime.MinValue;
         AV6fHasta = DateTime.MinValue;
         ClassString = "";
         StyleString = "";
         bttButton1_Jsonclick = "";
         bttButton2_Jsonclick = "";
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         scmdbuf = "";
         H005S2_A31tipoProdID = new short[1] ;
         H005S2_A144tipoProdDsc = new String[] {""} ;
         H005S2_n144tipoProdDsc = new bool[] {false} ;
         H005S2_A1EmpID = new short[1] ;
         H005S3_A286PrdCod = new short[1] ;
         H005S3_A309prdNombre = new String[] {""} ;
         H005S3_n309prdNombre = new bool[] {false} ;
         H005S3_A1EmpID = new short[1] ;
         H005S3_A2AgeID = new short[1] ;
         H005S3_A31tipoProdID = new short[1] ;
         AV12fechaHoy = DateTime.MinValue;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.rptstockbodega__default(),
            new Object[][] {
                new Object[] {
               H005S2_A31tipoProdID, H005S2_A144tipoProdDsc, H005S2_n144tipoProdDsc, H005S2_A1EmpID
               }
               , new Object[] {
               H005S3_A286PrdCod, H005S3_A309prdNombre, H005S3_n309prdNombre, H005S3_A1EmpID, H005S3_A2AgeID, H005S3_A31tipoProdID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV16EmpID ;
      private short AV17AgeID ;
      private short wcpOAV16EmpID ;
      private short wcpOAV17AgeID ;
      private short nGotPars ;
      private short GxWebError ;
      private short AV10tipoProdID ;
      private short initialized ;
      private short AV18BodCod ;
      private short wbEnd ;
      private short wbStart ;
      private short AV7prdCod ;
      private short AV13tipoRpt ;
      private short AV20formato ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short wbTemp ;
      private int edtavFdesde_Enabled ;
      private int edtavFhasta_Enabled ;
      private int gxdynajaxindex ;
      private int idxLst ;
      private String AV11usucod ;
      private String wcpOAV11usucod ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String divTable1_Internalname ;
      private String divTable4_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String divTable2_Internalname ;
      private String divTable3_Internalname ;
      private String edtavFdesde_Internalname ;
      private String TempTags ;
      private String edtavFdesde_Jsonclick ;
      private String edtavFhasta_Internalname ;
      private String edtavFhasta_Jsonclick ;
      private String dynavTipoprodid_Internalname ;
      private String dynavTipoprodid_Jsonclick ;
      private String dynavPrdcod_Internalname ;
      private String dynavPrdcod_Jsonclick ;
      private String divTable6_Internalname ;
      private String radavTiporpt_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String radavTiporpt_Jsonclick ;
      private String radavFormato_Internalname ;
      private String radavFormato_Jsonclick ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private DateTime AV5fdesde ;
      private DateTime AV6fHasta ;
      private DateTime AV12fechaHoy ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynavTipoprodid ;
      private GXCombobox dynavPrdcod ;
      private GXRadio radavTiporpt ;
      private GXRadio radavFormato ;
      private IDataStoreProvider pr_default ;
      private short[] H005S2_A31tipoProdID ;
      private String[] H005S2_A144tipoProdDsc ;
      private bool[] H005S2_n144tipoProdDsc ;
      private short[] H005S2_A1EmpID ;
      private short[] H005S3_A286PrdCod ;
      private String[] H005S3_A309prdNombre ;
      private bool[] H005S3_n309prdNombre ;
      private short[] H005S3_A1EmpID ;
      private short[] H005S3_A2AgeID ;
      private short[] H005S3_A31tipoProdID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class rptstockbodega__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH005S2 ;
          prmH005S2 = new Object[] {
          new Object[] {"@AV16EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH005S3 ;
          prmH005S3 = new Object[] {
          new Object[] {"@AV16EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV17AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H005S2", "SELECT [tipoProdID], [tipoProdDsc], [EmpID] FROM [TipoProducto] WITH (NOLOCK) WHERE [EmpID] = @AV16EmpID ORDER BY [tipoProdDsc] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005S2,0,0,true,false )
             ,new CursorDef("H005S3", "SELECT [PrdCod], [prdNombre], [EmpID], [AgeID], [tipoProdID] FROM [Productos] WITH (NOLOCK) WHERE ([EmpID] = @AV16EmpID) AND ([AgeID] = @AV17AgeID) AND ([tipoProdID] = @AV10tipoProdID) ORDER BY [prdNombre] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005S3,0,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 40) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
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
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
       }
    }

 }

}
