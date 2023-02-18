/*
               File: rptOrdenProduccionCostos
        Description: rpt Orden Produccion Costos
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/26/2022 20:15:25.10
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
   public class rptordenproduccioncostos : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public rptordenproduccioncostos( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public rptordenproduccioncostos( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_empID ,
                           short aP1_ageID ,
                           String aP2_userCod )
      {
         this.AV9empID = aP0_empID;
         this.AV5ageID = aP1_ageID;
         this.AV15userCod = aP2_userCod;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynavClienteid = new GXCombobox();
         dynavVendid = new GXCombobox();
         dynavProcid = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vCLIENTEID") == 0 )
            {
               AV9empID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9empID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9empID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9empID), "ZZZ9"), context));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvCLIENTEID2C2( AV9empID) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vVENDID") == 0 )
            {
               AV9empID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9empID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9empID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9empID), "ZZZ9"), context));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvVENDID2C2( AV9empID) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vPROCID") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvPROCID2C2( ) ;
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
               AV9empID = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9empID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9empID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9empID), "ZZZ9"), context));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV5ageID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5ageID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5ageID), 4, 0)));
                  AV15userCod = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15userCod", AV15userCod);
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
            PA2C2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0;
               GXVvPROCID_html2C2( ) ;
               GXVvCLIENTEID_html2C2( AV9empID) ;
               GXVvVENDID_html2C2( AV9empID) ;
               WS2C2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE2C2( ) ;
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
         context.SendWebValue( "rpt Orden Produccion Costos") ;
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
         context.AddJavascriptSource("gxcfg.js", "?2022102620152519", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("calendar-es.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("GXProgressIndicator/javascript/bootstrap-progressbar.js", "", false);
         context.AddJavascriptSource("GXProgressIndicator/GXProgressIndicatorRender.js", "", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("rptordenproduccioncostos.aspx") + "?" + UrlEncode("" +AV9empID) + "," + UrlEncode("" +AV5ageID) + "," + UrlEncode(StringUtil.RTrim(AV15userCod))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vERRORMESSAGE", AV10ErrorMessage);
         GxWebStd.gx_hidden_field( context, "vAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV5ageID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vUSERCOD", StringUtil.RTrim( AV15userCod));
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9empID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9empID), "ZZZ9"), context));
      }

      protected void RenderHtmlCloseForm2C2( )
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
         return "rptOrdenProduccionCostos" ;
      }

      public override String GetPgmdesc( )
      {
         return "rpt Orden Produccion Costos" ;
      }

      protected void WB2C0( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-lg-8 col-lg-offset-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable4_Internalname, 1, 0, "px", 0, "px", "FormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3 col-lg-7 col-lg-offset-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTop_Internalname, 1, 0, "px", 0, "px", "TableTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-lg-9 col-lg-offset-1", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Costeo x Orden", "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_rptOrdenProduccionCostos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-lg-7 col-lg-offset-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable2_Internalname, 1, 0, "px", 0, "px", "FormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-lg-9 col-lg-offset-3", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"INDICATOR1Container"+"\"></div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row TableRow", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 col-lg-4 col-lg-offset-3", "left", "Middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavFchdsd_Internalname, "Periodo", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavFchdsd_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavFchdsd_Internalname, context.localUtil.Format(AV11fchDsd, "99/99/9999"), context.localUtil.Format( AV11fchDsd, "99/99/9999"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,22);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavFchdsd_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavFchdsd_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_rptOrdenProduccionCostos.htm");
            GxWebStd.gx_bitmap( context, edtavFchdsd_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavFchdsd_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_rptOrdenProduccionCostos.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "Middle", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 col-lg-4 col-lg-offset-1", "left", "Middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavFchhasta_Internalname, "Fin", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavFchhasta_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavFchhasta_Internalname, context.localUtil.Format(AV12fchHasta, "99/99/9999"), context.localUtil.Format( AV12fchHasta, "99/99/9999"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,25);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavFchhasta_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavFchhasta_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_rptOrdenProduccionCostos.htm");
            GxWebStd.gx_bitmap( context, edtavFchhasta_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavFchhasta_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_rptOrdenProduccionCostos.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "Middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavOrdenid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavOrdenid_Internalname, "Orden ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdenid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrdenID), 4, 0, ",", "")), ((edtavOrdenid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrdenID), "ZZZ9")) : context.localUtil.Format( (decimal)(AV13OrdenID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdenid_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavOrdenid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_rptOrdenProduccionCostos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynavClienteid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavClienteid_Internalname, "Cliente", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavClienteid, dynavClienteid_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV7ClienteID), 4, 0)), 1, dynavClienteid_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dynavClienteid.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,35);\"", "", true, "HLP_rptOrdenProduccionCostos.htm");
            dynavClienteid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV7ClienteID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavClienteid_Internalname, "Values", (String)(dynavClienteid.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynavVendid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavVendid_Internalname, "Vendedor", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavVendid, dynavVendid_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV16vendID), 4, 0)), 1, dynavVendid_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dynavVendid.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,40);\"", "", true, "HLP_rptOrdenProduccionCostos.htm");
            dynavVendid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV16vendID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVendid_Internalname, "Values", (String)(dynavVendid.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynavProcid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavProcid_Internalname, "Proceso", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavProcid, dynavProcid_Internalname, StringUtil.RTrim( AV14procId), 1, dynavProcid_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavProcid.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", "", true, "HLP_rptOrdenProduccionCostos.htm");
            dynavProcid.CurrentValue = StringUtil.RTrim( AV14procId);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavProcid_Internalname, "Values", (String)(dynavProcid.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnok_Internalname, "", "Aceptar", bttBtnok_Jsonclick, 5, "Aceptar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'ACEPTAR\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_rptOrdenProduccionCostos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "Cancelar", bttBtncancel_Jsonclick, 7, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e112c1_client"+"'", TempTags, "", 2, "HLP_rptOrdenProduccionCostos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START2C2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "rpt Orden Produccion Costos", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP2C0( ) ;
      }

      protected void WS2C2( )
      {
         START2C2( ) ;
         EVT2C2( ) ;
      }

      protected void EVT2C2( )
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
                           E122C2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E132C2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Load */
                           E142C2 ();
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

      protected void WE2C2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm2C2( ) ;
            }
         }
      }

      protected void PA2C2( )
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
               GX_FocusControl = edtavFchdsd_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLVvCLIENTEID2C2( short AV9empID )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvCLIENTEID_data2C2( AV9empID) ;
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

      protected void GXVvCLIENTEID_html2C2( short AV9empID )
      {
         short gxdynajaxvalue ;
         GXDLVvCLIENTEID_data2C2( AV9empID) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavClienteid.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (short)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynavClienteid.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 4, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvCLIENTEID_data2C2( short AV9empID )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Todos");
         /* Using cursor H002C2 */
         pr_default.execute(0, new Object[] {AV9empID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(H002C2_A5ClienteID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H002C2_A57ClienteDsc[0]));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void GXDLVvVENDID2C2( short AV9empID )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvVENDID_data2C2( AV9empID) ;
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

      protected void GXVvVENDID_html2C2( short AV9empID )
      {
         short gxdynajaxvalue ;
         GXDLVvVENDID_data2C2( AV9empID) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavVendid.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (short)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynavVendid.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 4, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvVENDID_data2C2( short AV9empID )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Todos");
         /* Using cursor H002C3 */
         pr_default.execute(1, new Object[] {AV9empID});
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(H002C3_A9vendedorID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H002C3_A72vendedorDsc[0]));
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void GXDLVvPROCID2C2( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvPROCID_data2C2( ) ;
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

      protected void GXVvPROCID_html2C2( )
      {
         String gxdynajaxvalue ;
         GXDLVvPROCID_data2C2( ) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavProcid.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavProcid.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvPROCID_data2C2( )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("Todos");
         /* Using cursor H002C4 */
         pr_default.execute(2);
         while ( (pr_default.getStatus(2) != 101) )
         {
            gxdynajaxctrlcodr.Add(H002C4_A129ProcAbre[0]);
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H002C4_A128ProcDsc[0]));
            pr_default.readNext(2);
         }
         pr_default.close(2);
      }

      protected void send_integrity_hashes( )
      {
      }

      protected void clear_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
            GXVvPROCID_html2C2( ) ;
            GXVvCLIENTEID_html2C2( AV9empID) ;
            GXVvVENDID_html2C2( AV9empID) ;
            dynload_actions( ) ;
         }
      }

      protected void fix_multi_value_controls( )
      {
         if ( dynavClienteid.ItemCount > 0 )
         {
            AV7ClienteID = (short)(NumberUtil.Val( dynavClienteid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV7ClienteID), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ClienteID), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavClienteid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV7ClienteID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavClienteid_Internalname, "Values", dynavClienteid.ToJavascriptSource(), true);
         }
         if ( dynavVendid.ItemCount > 0 )
         {
            AV16vendID = (short)(NumberUtil.Val( dynavVendid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV16vendID), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16vendID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16vendID), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavVendid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV16vendID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVendid_Internalname, "Values", dynavVendid.ToJavascriptSource(), true);
         }
         if ( dynavProcid.ItemCount > 0 )
         {
            AV14procId = dynavProcid.getValidValue(AV14procId);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14procId", AV14procId);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavProcid.CurrentValue = StringUtil.RTrim( AV14procId);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavProcid_Internalname, "Values", dynavProcid.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF2C2( ) ;
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

      protected void RF2C2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E142C2 ();
            WB2C0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes2C2( )
      {
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9empID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9empID), "ZZZ9"), context));
      }

      protected void STRUP2C0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         GXVvPROCID_html2C2( ) ;
         GXVvCLIENTEID_html2C2( AV9empID) ;
         GXVvVENDID_html2C2( AV9empID) ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E132C2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( context.localUtil.VCDate( cgiGet( edtavFchdsd_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"fch Dsd"}), 1, "vFCHDSD");
               GX_FocusControl = edtavFchdsd_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV11fchDsd = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11fchDsd", context.localUtil.Format(AV11fchDsd, "99/99/9999"));
            }
            else
            {
               AV11fchDsd = context.localUtil.CToD( cgiGet( edtavFchdsd_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11fchDsd", context.localUtil.Format(AV11fchDsd, "99/99/9999"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavFchhasta_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"fch Hasta"}), 1, "vFCHHASTA");
               GX_FocusControl = edtavFchhasta_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV12fchHasta = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12fchHasta", context.localUtil.Format(AV12fchHasta, "99/99/9999"));
            }
            else
            {
               AV12fchHasta = context.localUtil.CToD( cgiGet( edtavFchhasta_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12fchHasta", context.localUtil.Format(AV12fchHasta, "99/99/9999"));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrdenid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrdenid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDENID");
               GX_FocusControl = edtavOrdenid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV13OrdenID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrdenID), 4, 0)));
            }
            else
            {
               AV13OrdenID = (short)(context.localUtil.CToN( cgiGet( edtavOrdenid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrdenID), 4, 0)));
            }
            dynavClienteid.CurrentValue = cgiGet( dynavClienteid_Internalname);
            AV7ClienteID = (short)(NumberUtil.Val( cgiGet( dynavClienteid_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ClienteID), 4, 0)));
            dynavVendid.CurrentValue = cgiGet( dynavVendid_Internalname);
            AV16vendID = (short)(NumberUtil.Val( cgiGet( dynavVendid_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16vendID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16vendID), 4, 0)));
            dynavProcid.CurrentValue = cgiGet( dynavProcid_Internalname);
            AV14procId = cgiGet( dynavProcid_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14procId", AV14procId);
            /* Read saved values. */
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            GXVvPROCID_html2C2( ) ;
            GXVvCLIENTEID_html2C2( AV9empID) ;
            GXVvVENDID_html2C2( AV9empID) ;
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void E122C2( )
      {
         /* 'Aceptar' Routine */
         new exclistaordenproduccioncostos(context ).execute(  AV9empID,  AV11fchDsd,  AV12fchHasta,  AV7ClienteID,  AV13OrdenID,  AV16vendID,  AV14procId, out  AV6archivo) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9empID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9empID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9empID), "ZZZ9"), context));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11fchDsd", context.localUtil.Format(AV11fchDsd, "99/99/9999"));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12fchHasta", context.localUtil.Format(AV12fchHasta, "99/99/9999"));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ClienteID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrdenID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16vendID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16vendID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14procId", AV14procId);
         if ( StringUtil.StrCmp(AV6archivo, "") != 0 )
         {
            GX_msglist.addItem("Proceso de Exportacion Finalizado... Por favor Verifique los Datos Exportados...");
            CallWebObject(formatLink(AV6archivo) );
            context.wjLocDisableFrm = 0;
         }
         else
         {
            GX_msglist.addItem(AV10ErrorMessage);
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E132C2 ();
         if (returnInSub) return;
      }

      protected void E132C2( )
      {
         /* Start Routine */
         AV8date = DateTimeUtil.ResetTime(DateTimeUtil.ServerNow( context, pr_default));
         AV11fchDsd = context.localUtil.YMDToD( DateTimeUtil.Year( AV8date), DateTimeUtil.Month( AV8date), 1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11fchDsd", context.localUtil.Format(AV11fchDsd, "99/99/9999"));
         AV12fchHasta = DateTimeUtil.DateEndOfMonth( AV11fchDsd);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12fchHasta", context.localUtil.Format(AV12fchHasta, "99/99/9999"));
      }

      protected void nextLoad( )
      {
      }

      protected void E142C2( )
      {
         /* Load Routine */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV9empID = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9empID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9empID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9empID), "ZZZ9"), context));
         AV5ageID = Convert.ToInt16(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5ageID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5ageID), 4, 0)));
         AV15userCod = (String)getParm(obj,2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15userCod", AV15userCod);
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
         PA2C2( ) ;
         WS2C2( ) ;
         WE2C2( ) ;
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
         AddStyleSheetFile("GXProgressIndicator/css/bootstrap-progressbar-3.0.1.css", "");
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022102620152642", true);
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
         context.AddJavascriptSource("rptordenproduccioncostos.js", "?2022102620152642", false);
         context.AddJavascriptSource("GXProgressIndicator/javascript/bootstrap-progressbar.js", "", false);
         context.AddJavascriptSource("GXProgressIndicator/GXProgressIndicatorRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         dynavClienteid.Name = "vCLIENTEID";
         dynavClienteid.WebTags = "";
         dynavVendid.Name = "vVENDID";
         dynavVendid.WebTags = "";
         dynavProcid.Name = "vPROCID";
         dynavProcid.WebTags = "";
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1";
         divTop_Internalname = "TOP";
         Indicator1_Internalname = "INDICATOR1";
         edtavFchdsd_Internalname = "vFCHDSD";
         edtavFchhasta_Internalname = "vFCHHASTA";
         edtavOrdenid_Internalname = "vORDENID";
         dynavClienteid_Internalname = "vCLIENTEID";
         dynavVendid_Internalname = "vVENDID";
         dynavProcid_Internalname = "vPROCID";
         divTable2_Internalname = "TABLE2";
         divTable4_Internalname = "TABLE4";
         bttBtnok_Internalname = "BTNOK";
         bttBtncancel_Internalname = "BTNCANCEL";
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
         dynavProcid_Jsonclick = "";
         dynavProcid.Enabled = 1;
         dynavVendid_Jsonclick = "";
         dynavVendid.Enabled = 1;
         dynavClienteid_Jsonclick = "";
         dynavClienteid.Enabled = 1;
         edtavOrdenid_Jsonclick = "";
         edtavOrdenid_Enabled = 1;
         edtavFchhasta_Jsonclick = "";
         edtavFchhasta_Enabled = 1;
         edtavFchdsd_Jsonclick = "";
         edtavFchdsd_Enabled = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'dynavProcid'},{av:'AV14procId',fld:'vPROCID',pic:''},{av:'AV9empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavClienteid'},{av:'AV7ClienteID',fld:'vCLIENTEID',pic:'ZZZ9'},{av:'dynavVendid'},{av:'AV16vendID',fld:'vVENDID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'dynavProcid'},{av:'AV14procId',fld:'vPROCID',pic:''},{av:'AV9empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavClienteid'},{av:'AV7ClienteID',fld:'vCLIENTEID',pic:'ZZZ9'},{av:'dynavVendid'},{av:'AV16vendID',fld:'vVENDID',pic:'ZZZ9'}]}");
         setEventMetadata("'ACEPTAR'","{handler:'E122C2',iparms:[{av:'AV11fchDsd',fld:'vFCHDSD',pic:''},{av:'AV12fchHasta',fld:'vFCHHASTA',pic:''},{av:'AV13OrdenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV10ErrorMessage',fld:'vERRORMESSAGE',pic:''},{av:'dynavProcid'},{av:'AV14procId',fld:'vPROCID',pic:''},{av:'AV9empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavClienteid'},{av:'AV7ClienteID',fld:'vCLIENTEID',pic:'ZZZ9'},{av:'dynavVendid'},{av:'AV16vendID',fld:'vVENDID',pic:'ZZZ9'}]");
         setEventMetadata("'ACEPTAR'",",oparms:[{av:'dynavProcid'},{av:'AV14procId',fld:'vPROCID',pic:''},{av:'AV9empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavClienteid'},{av:'AV7ClienteID',fld:'vCLIENTEID',pic:'ZZZ9'},{av:'dynavVendid'},{av:'AV16vendID',fld:'vVENDID',pic:'ZZZ9'}]}");
         setEventMetadata("'CANCELAR'","{handler:'E112C1',iparms:[{av:'dynavProcid'},{av:'AV14procId',fld:'vPROCID',pic:''},{av:'AV9empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavClienteid'},{av:'AV7ClienteID',fld:'vCLIENTEID',pic:'ZZZ9'},{av:'dynavVendid'},{av:'AV16vendID',fld:'vVENDID',pic:'ZZZ9'}]");
         setEventMetadata("'CANCELAR'",",oparms:[{av:'dynavProcid'},{av:'AV14procId',fld:'vPROCID',pic:''},{av:'AV9empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavClienteid'},{av:'AV7ClienteID',fld:'vCLIENTEID',pic:'ZZZ9'},{av:'dynavVendid'},{av:'AV16vendID',fld:'vVENDID',pic:'ZZZ9'}]}");
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
         wcpOAV15userCod = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         AV10ErrorMessage = "";
         GX_FocusControl = "";
         sPrefix = "";
         lblTextblock1_Jsonclick = "";
         TempTags = "";
         AV11fchDsd = DateTime.MinValue;
         AV12fchHasta = DateTime.MinValue;
         AV14procId = "";
         ClassString = "";
         StyleString = "";
         bttBtnok_Jsonclick = "";
         bttBtncancel_Jsonclick = "";
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         scmdbuf = "";
         H002C2_A5ClienteID = new short[1] ;
         H002C2_A57ClienteDsc = new String[] {""} ;
         H002C2_n57ClienteDsc = new bool[] {false} ;
         H002C2_A1EmpID = new short[1] ;
         H002C3_A9vendedorID = new short[1] ;
         H002C3_A72vendedorDsc = new String[] {""} ;
         H002C3_n72vendedorDsc = new bool[] {false} ;
         H002C3_A1EmpID = new short[1] ;
         H002C4_A20ProcID = new short[1] ;
         H002C4_A129ProcAbre = new String[] {""} ;
         H002C4_n129ProcAbre = new bool[] {false} ;
         H002C4_A128ProcDsc = new String[] {""} ;
         H002C4_n128ProcDsc = new bool[] {false} ;
         AV6archivo = "";
         AV8date = DateTime.MinValue;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.rptordenproduccioncostos__default(),
            new Object[][] {
                new Object[] {
               H002C2_A5ClienteID, H002C2_A57ClienteDsc, H002C2_n57ClienteDsc, H002C2_A1EmpID
               }
               , new Object[] {
               H002C3_A9vendedorID, H002C3_A72vendedorDsc, H002C3_n72vendedorDsc, H002C3_A1EmpID
               }
               , new Object[] {
               H002C4_A20ProcID, H002C4_A129ProcAbre, H002C4_n129ProcAbre, H002C4_A128ProcDsc, H002C4_n128ProcDsc
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV9empID ;
      private short AV5ageID ;
      private short wcpOAV9empID ;
      private short wcpOAV5ageID ;
      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short AV13OrdenID ;
      private short AV7ClienteID ;
      private short AV16vendID ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int edtavFchdsd_Enabled ;
      private int edtavFchhasta_Enabled ;
      private int edtavOrdenid_Enabled ;
      private int gxdynajaxindex ;
      private int idxLst ;
      private String AV15userCod ;
      private String wcpOAV15userCod ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String divTable4_Internalname ;
      private String divTop_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String divTable2_Internalname ;
      private String edtavFchdsd_Internalname ;
      private String TempTags ;
      private String edtavFchdsd_Jsonclick ;
      private String edtavFchhasta_Internalname ;
      private String edtavFchhasta_Jsonclick ;
      private String edtavOrdenid_Internalname ;
      private String edtavOrdenid_Jsonclick ;
      private String dynavClienteid_Internalname ;
      private String dynavClienteid_Jsonclick ;
      private String dynavVendid_Internalname ;
      private String dynavVendid_Jsonclick ;
      private String dynavProcid_Internalname ;
      private String dynavProcid_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtnok_Internalname ;
      private String bttBtnok_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String Indicator1_Internalname ;
      private DateTime AV11fchDsd ;
      private DateTime AV12fchHasta ;
      private DateTime AV8date ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private String AV10ErrorMessage ;
      private String AV14procId ;
      private String AV6archivo ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynavClienteid ;
      private GXCombobox dynavVendid ;
      private GXCombobox dynavProcid ;
      private IDataStoreProvider pr_default ;
      private short[] H002C2_A5ClienteID ;
      private String[] H002C2_A57ClienteDsc ;
      private bool[] H002C2_n57ClienteDsc ;
      private short[] H002C2_A1EmpID ;
      private short[] H002C3_A9vendedorID ;
      private String[] H002C3_A72vendedorDsc ;
      private bool[] H002C3_n72vendedorDsc ;
      private short[] H002C3_A1EmpID ;
      private short[] H002C4_A20ProcID ;
      private String[] H002C4_A129ProcAbre ;
      private bool[] H002C4_n129ProcAbre ;
      private String[] H002C4_A128ProcDsc ;
      private bool[] H002C4_n128ProcDsc ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class rptordenproduccioncostos__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH002C2 ;
          prmH002C2 = new Object[] {
          new Object[] {"@AV9empID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH002C3 ;
          prmH002C3 = new Object[] {
          new Object[] {"@AV9empID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH002C4 ;
          prmH002C4 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H002C2", "SELECT [ClienteID], [ClienteDsc], [EmpID] FROM [Clientes] WITH (NOLOCK) WHERE [EmpID] = @AV9empID ORDER BY [ClienteDsc] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002C2,0,0,true,false )
             ,new CursorDef("H002C3", "SELECT [vendedorID], [vendedorDsc], [EmpID] FROM [Vendedor] WITH (NOLOCK) WHERE [EmpID] = @AV9empID ORDER BY [vendedorDsc] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002C3,0,0,true,false )
             ,new CursorDef("H002C4", "SELECT [ProcID], [ProcAbre], [ProcDsc] FROM [Procesos] WITH (NOLOCK) ORDER BY [ProcDsc] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002C4,0,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 40) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
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
                return;
       }
    }

 }

}
