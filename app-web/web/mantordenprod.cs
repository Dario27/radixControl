/*
               File: MantOrdenProd
        Description: Mant Orden Prod
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/14/2023 1:16:0.32
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
using GeneXus.Http.Server;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class mantordenprod : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public mantordenprod( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public mantordenprod( IGxContext context )
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
                           String aP2_UserCod )
      {
         this.AV14empID = aP0_empID;
         this.AV6ageID = aP1_ageID;
         this.AV37UserCod = aP2_UserCod;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynavOrdenproceso = new GXCombobox();
         chkavSelect = new GXCheckbox();
         dynOrdenProceso = new GXCombobox();
         dynprotID = new GXCombobox();
         chkavSelect1 = new GXCheckbox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vORDENPROCESO") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvORDENPROCESO2E2( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"PROTID") == 0 )
            {
               AV14empID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14empID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14empID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV14empID), "ZZZ9"), context));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLAPROTID2E2( AV14empID) ;
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid") == 0 )
            {
               nRC_GXsfl_40 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_40_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_40_idx = GetNextPar( );
               AV35Update = GetNextPar( );
               edtavUpdate_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext, !bGXsfl_40_Refreshing);
               chkavSelect.Enabled = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavSelect_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavSelect.Enabled), 5, 0)), !bGXsfl_40_Refreshing);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGrid_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid") == 0 )
            {
               subGrid_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
               AV25ordenID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV8ClienteDsc = GetNextPar( );
               AV26OrdenProceso = GetNextPar( );
               AV42Pgmname = GetNextPar( );
               AV35Update = GetNextPar( );
               edtavUpdate_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext, !bGXsfl_40_Refreshing);
               chkavSelect.Enabled = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavSelect_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavSelect.Enabled), 5, 0)), !bGXsfl_40_Refreshing);
               AV14empID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV16fecha = context.localUtil.ParseDateParm( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV25ordenID, AV8ClienteDsc, AV26OrdenProceso, AV42Pgmname, AV35Update, AV14empID, AV16fecha) ;
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridped") == 0 )
            {
               nRC_GXsfl_61 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_61_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_61_idx = GetNextPar( );
               AV36UpdatePed = GetNextPar( );
               edtavUpdateped_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdateped_Internalname, "Tooltiptext", edtavUpdateped_Tooltiptext, !bGXsfl_61_Refreshing);
               AV17GenDespach = GetNextPar( );
               edtavGendespach_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGendespach_Internalname, "Tooltiptext", edtavGendespach_Tooltiptext, !bGXsfl_61_Refreshing);
               chkavSelect1.Enabled = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavSelect1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavSelect1.Enabled), 5, 0)), !bGXsfl_61_Refreshing);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGridped_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Gridped") == 0 )
            {
               subGridped_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
               AV25ordenID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV8ClienteDsc = GetNextPar( );
               AV26OrdenProceso = GetNextPar( );
               AV42Pgmname = GetNextPar( );
               AV36UpdatePed = GetNextPar( );
               edtavUpdateped_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdateped_Internalname, "Tooltiptext", edtavUpdateped_Tooltiptext, !bGXsfl_61_Refreshing);
               AV17GenDespach = GetNextPar( );
               edtavGendespach_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGendespach_Internalname, "Tooltiptext", edtavGendespach_Tooltiptext, !bGXsfl_61_Refreshing);
               chkavSelect1.Enabled = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavSelect1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavSelect1.Enabled), 5, 0)), !bGXsfl_61_Refreshing);
               ajax_req_read_hidden_sdt(GetNextPar( ), AV29SDTPedidos);
               AV14empID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV16fecha = context.localUtil.ParseDateParm( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGridped_refresh( subGridped_Rows, AV25ordenID, AV8ClienteDsc, AV26OrdenProceso, AV42Pgmname, AV36UpdatePed, AV17GenDespach, AV29SDTPedidos, AV14empID, AV16fecha) ;
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
            if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
            {
               AV14empID = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14empID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14empID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV14empID), "ZZZ9"), context));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV6ageID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6ageID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6ageID), 4, 0)));
                  AV37UserCod = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37UserCod", AV37UserCod);
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
            PA2E2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV42Pgmname = "MantOrdenProd";
               context.Gx_err = 0;
               GXVvORDENPROCESO_html2E2( ) ;
               GXAPROTID_html2E2( AV14empID) ;
               WS2E2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE2E2( ) ;
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
         context.SendWebValue( Form.Caption) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2023114116044", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("calendar-es.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false);
         context.AddJavascriptSource("Tab/TabRender.js", "", false);
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = ((nGXWrapped==0) ? " data-HasEnter=\"false\" data-Skiponenter=\"false\"" : "");
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("mantordenprod.aspx") + "?" + UrlEncode("" +AV14empID) + "," + UrlEncode("" +AV6ageID) + "," + UrlEncode(StringUtil.RTrim(AV37UserCod))+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            context.WriteHtmlText( "<input type=\"submit\" style=\"display:none\">") ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "form-horizontal Form", true);
         }
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
         GxWebStd.gx_hidden_field( context, "GXH_vORDENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25ordenID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCLIENTEDSC", StringUtil.RTrim( AV8ClienteDsc));
         GxWebStd.gx_hidden_field( context, "GXH_vORDENPROCESO", AV26OrdenProceso);
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_40", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_40), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_61", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_61), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV42Pgmname));
         GxWebStd.gx_hidden_field( context, "vFECHA", context.localUtil.DToC( AV16fecha, 0, "/"));
         GxWebStd.gx_hidden_field( context, "gxhash_vFECHA", GetSecureSignedToken( "", AV16fecha, context));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vSDTPEDIDOS", AV29SDTPedidos);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vSDTPEDIDOS", AV29SDTPedidos);
         }
         GxWebStd.gx_hidden_field( context, "vAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6ageID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vUSERCOD", StringUtil.RTrim( AV37UserCod));
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPED_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDPED_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPED_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDPED_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14empID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV14empID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TABGRIDOP_Class", StringUtil.RTrim( Tabgridop_Class));
         GxWebStd.gx_hidden_field( context, "TABGRIDOP_Pagecount", StringUtil.LTrim( StringUtil.NToC( (decimal)(Tabgridop_Pagecount), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TABGRIDOP_Historymanagement", StringUtil.BoolToStr( Tabgridop_Historymanagement));
         GxWebStd.gx_hidden_field( context, "vUPDATE_Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
         GxWebStd.gx_hidden_field( context, "vSELECT_Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkavSelect.Enabled), 5, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm2E2( )
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
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "</form>") ;
         }
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
         return "MantOrdenProd" ;
      }

      public override String GetPgmdesc( )
      {
         return "Mant Orden Prod" ;
      }

      protected void WB2E0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            RenderHtmlHeaders( ) ;
            RenderHtmlOpenForm( ) ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "BodyContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 ViewGridCellAdvanced", "left", "Middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabletop1_Internalname, 1, 0, "px", 0, "px", "TableTopSearch", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 col-lg-3 col-lg-offset-1", "left", "Middle", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitletext_Internalname, "Orden Pedidos", "", "", lblTitletext_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "SubTitle", 0, "", 1, 1, 0, "HLP_MantOrdenProd.htm");
            GxWebStd.gx_div_end( context, "left", "Middle", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 WWActionsCell", "Right", "Middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "BtnNew";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(40), 2, 0)+","+"null"+");", "Agregar", bttBtninsert_Jsonclick, 7, "Agregar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e112e1_client"+"'", TempTags, "", 2, "HLP_MantOrdenProd.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Right", "Middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 col-lg-2 col-lg-offset-1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavOrdenid_Internalname, "orden ID", "col-sm-3 FilterSearchAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'" + sGXsfl_40_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdenid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25ordenID), 4, 0, ",", "")), ((edtavOrdenid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV25ordenID), "ZZZ9")) : context.localUtil.Format( (decimal)(AV25ordenID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,17);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "Nro", edtavOrdenid_Jsonclick, 0, "FilterSearchAttribute", "", "", "", "", 1, edtavOrdenid_Enabled, 0, "number", "1", 125, "px", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_MantOrdenProd.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 col-lg-3", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClientedsc_Internalname, "Cliente Dsc", "col-sm-3 FilterSearchAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'" + sGXsfl_40_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClientedsc_Internalname, StringUtil.RTrim( AV8ClienteDsc), StringUtil.RTrim( context.localUtil.Format( AV8ClienteDsc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,20);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "Cliente", edtavClientedsc_Jsonclick, 0, "FilterSearchAttribute", "", "", "", "", 1, edtavClientedsc_Enabled, 0, "text", "", 20, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_MantOrdenProd.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavOrdenproceso_Internalname, "Orden Proceso", "col-sm-3 FilterComboAttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'" + sGXsfl_40_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavOrdenproceso, dynavOrdenproceso_Internalname, StringUtil.RTrim( AV26OrdenProceso), 1, dynavOrdenproceso_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavOrdenproceso.Enabled, 0, 0, 25, "em", 0, "", "", "FilterComboAttribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,23);\"", "", true, "HLP_MantOrdenProd.htm");
            dynavOrdenproceso.CurrentValue = StringUtil.RTrim( AV26OrdenProceso);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavOrdenproceso_Internalname, "Values", (String)(dynavOrdenproceso.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "Middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridtable_Internalname, 1, 0, "px", 0, "px", "ContainerFluid WWAdvancedContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"TABGRIDOPContainer"+"\"></div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABGRIDOPContainer"+"title1"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTabtodos_title_Internalname, "Ordenes", "", "", lblTabtodos_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_MantOrdenProd.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "TabTodos") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABGRIDOPContainer"+"panel1"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabgridoptable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            GridContainer.SetWrapped(nGXWrapped);
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"40\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid_Internalname, subGrid_Internalname, "", "WorkWith", 0, "", "", 1, 2, sStyleString, "", "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid_Backcolorstyle == 0 )
               {
                  subGrid_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGrid_Class) > 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Title";
                  }
               }
               else
               {
                  subGrid_Titlebackstyle = 1;
                  if ( subGrid_Backcolorstyle == 1 )
                  {
                     subGrid_Titlebackcolor = subGrid_Allbackcolor;
                     if ( StringUtil.Len( subGrid_Class) > 0 )
                     {
                        subGrid_Linesclass = subGrid_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid_Class) > 0 )
                     {
                        subGrid_Linesclass = subGrid_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Emp ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(30), 4, 0))+"px"+" class=\""+"CheckBox"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(80), 4, 0))+"px"+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Orden") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Orden Periodo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Orden Anio") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Fecha") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Cliente ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Cliente") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Tipo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Proceso Actual") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Prototipo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+""+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+""+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               GridContainer.AddObjectProperty("GridName", "Grid");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  GridContainer = new GXWebGrid( context);
               }
               else
               {
                  GridContainer.Clear();
               }
               GridContainer.SetWrapped(nGXWrapped);
               GridContainer.AddObjectProperty("GridName", "Grid");
               GridContainer.AddObjectProperty("Header", subGrid_Header);
               GridContainer.AddObjectProperty("Class", "WorkWith");
               GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Sortable", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Sortable), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("CmpContext", "");
               GridContainer.AddObjectProperty("InMasterPage", "false");
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV30select), 1, 0, ".", "")));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkavSelect.Enabled), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A22OrdenID), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A24OrdenPeriodo), 2, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A25OrdenAnio), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A119OrdenFch, "99/99/9999"));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A5ClienteID), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A57ClienteDsc));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A104tipOrdDsc));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A133OrdenProceso);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A10protID), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV35Update));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV12display));
               GridContainer.AddColumnProperties(GridColumn);
               GridContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Selectedindex), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowselection), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Selectioncolor), 9, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowhovering), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Hoveringcolor), 9, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowcollapsing), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 40 )
         {
            wbEnd = 0;
            nRC_GXsfl_40 = (short)(nGXsfl_40_idx-1);
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               GridContainer.AddObjectProperty("GRID_nEOF", GRID_nEOF);
               GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid", GridContainer);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridContainerData", GridContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridContainerData"+"V", GridContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
               }
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABGRIDOPContainer"+"title2"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTabpage1_title_Internalname, "Pedidos", "", "", lblTabpage1_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_MantOrdenProd.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "TabPage1") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABGRIDOPContainer"+"panel2"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabpage1table_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            GridpedContainer.SetWrapped(nGXWrapped);
            if ( GridpedContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"GridpedContainer"+"DivS\" data-gxgridid=\"61\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGridped_Internalname, subGridped_Internalname, "", "WorkWith", 0, "", "", 1, 2, sStyleString, "", "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGridped_Backcolorstyle == 0 )
               {
                  subGridped_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGridped_Class) > 0 )
                  {
                     subGridped_Linesclass = subGridped_Class+"Title";
                  }
               }
               else
               {
                  subGridped_Titlebackstyle = 1;
                  if ( subGridped_Backcolorstyle == 1 )
                  {
                     subGridped_Titlebackcolor = subGridped_Allbackcolor;
                     if ( StringUtil.Len( subGridped_Class) > 0 )
                     {
                        subGridped_Linesclass = subGridped_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGridped_Class) > 0 )
                     {
                        subGridped_Linesclass = subGridped_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Emp ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(30), 4, 0))+"px"+" class=\""+"CheckBox"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(67), 4, 0))+"px"+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Nro.") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(100), 4, 0))+"px"+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Fecha") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(300), 4, 0))+"px"+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Descripcion") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Image"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Image"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               GridpedContainer.AddObjectProperty("GridName", "Gridped");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  GridpedContainer = new GXWebGrid( context);
               }
               else
               {
                  GridpedContainer.Clear();
               }
               GridpedContainer.SetWrapped(nGXWrapped);
               GridpedContainer.AddObjectProperty("GridName", "Gridped");
               GridpedContainer.AddObjectProperty("Header", subGridped_Header);
               GridpedContainer.AddObjectProperty("Class", "WorkWith");
               GridpedContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               GridpedContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               GridpedContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridped_Backcolorstyle), 1, 0, ".", "")));
               GridpedContainer.AddObjectProperty("CmpContext", "");
               GridpedContainer.AddObjectProperty("InMasterPage", "false");
               GridpedColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridpedColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ".", "")));
               GridpedContainer.AddColumnProperties(GridpedColumn);
               GridpedColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridpedColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV31select1), 1, 0, ".", "")));
               GridpedColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkavSelect1.Enabled), 5, 0, ".", "")));
               GridpedContainer.AddColumnProperties(GridpedColumn);
               GridpedColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridpedColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A39PedCod), 8, 0, ".", "")));
               GridpedContainer.AddColumnProperties(GridpedColumn);
               GridpedColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridpedColumn.AddObjectProperty("Value", context.localUtil.Format(A205PedFchReg, "99/99/9999"));
               GridpedContainer.AddColumnProperties(GridpedColumn);
               GridpedColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridpedColumn.AddObjectProperty("Value", StringUtil.RTrim( A204PedDescripcion));
               GridpedContainer.AddColumnProperties(GridpedColumn);
               GridpedColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridpedColumn.AddObjectProperty("Value", context.convertURL( AV36UpdatePed));
               GridpedColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdateped_Link));
               GridpedColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdateped_Tooltiptext));
               GridpedContainer.AddColumnProperties(GridpedColumn);
               GridpedColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridpedColumn.AddObjectProperty("Value", context.convertURL( AV17GenDespach));
               GridpedColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavGendespach_Tooltiptext));
               GridpedContainer.AddColumnProperties(GridpedColumn);
               GridpedContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridped_Selectedindex), 4, 0, ".", "")));
               GridpedContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridped_Allowselection), 1, 0, ".", "")));
               GridpedContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridped_Selectioncolor), 9, 0, ".", "")));
               GridpedContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridped_Allowhovering), 1, 0, ".", "")));
               GridpedContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridped_Hoveringcolor), 9, 0, ".", "")));
               GridpedContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridped_Allowcollapsing), 1, 0, ".", "")));
               GridpedContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridped_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 61 )
         {
            wbEnd = 0;
            nRC_GXsfl_61 = (short)(nGXsfl_61_idx-1);
            if ( GridpedContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               GridpedContainer.AddObjectProperty("GRIDPED_nEOF", GRIDPED_nEOF);
               GridpedContainer.AddObjectProperty("GRIDPED_nFirstRecordOnPage", GRIDPED_nFirstRecordOnPage);
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"GridpedContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridped", GridpedContainer);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridpedContainerData", GridpedContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridpedContainerData"+"V", GridpedContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GridpedContainerData"+"V"+"\" value='"+GridpedContainer.GridValuesHidden()+"'/>") ;
               }
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 40 )
         {
            wbEnd = 0;
            if ( isFullAjaxMode( ) )
            {
               if ( GridContainer.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  GridContainer.AddObjectProperty("GRID_nEOF", GRID_nEOF);
                  GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
                  sStyleString = "";
                  context.WriteHtmlText( "<div id=\""+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid", GridContainer);
                  if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "GridContainerData", GridContainer.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "GridContainerData"+"V", GridContainer.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         if ( wbEnd == 61 )
         {
            wbEnd = 0;
            if ( isFullAjaxMode( ) )
            {
               if ( GridpedContainer.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  GridpedContainer.AddObjectProperty("GRIDPED_nEOF", GRIDPED_nEOF);
                  GridpedContainer.AddObjectProperty("GRIDPED_nFirstRecordOnPage", GRIDPED_nFirstRecordOnPage);
                  sStyleString = "";
                  context.WriteHtmlText( "<div id=\""+"GridpedContainer"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridped", GridpedContainer);
                  if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "GridpedContainerData", GridpedContainer.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "GridpedContainerData"+"V", GridpedContainer.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GridpedContainerData"+"V"+"\" value='"+GridpedContainer.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START2E2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "Mant Orden Prod", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP2E0( ) ;
      }

      protected void WS2E2( )
      {
         START2E2( ) ;
         EVT2E2( ) ;
      }

      protected void EVT2E2( )
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
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRIDPAGING") == 0 )
                        {
                           context.wbHandled = 1;
                           sEvt = cgiGet( "GRIDPAGING");
                           if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                           {
                              subgrid_firstpage( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                           {
                              subgrid_previouspage( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                           {
                              subgrid_nextpage( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                           {
                              subgrid_lastpage( ) ;
                           }
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRIDPEDPAGING") == 0 )
                        {
                           context.wbHandled = 1;
                           sEvt = cgiGet( "GRIDPEDPAGING");
                           if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                           {
                              subgridped_firstpage( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                           {
                              subgridped_previouspage( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                           {
                              subgridped_nextpage( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                           {
                              subgridped_lastpage( ) ;
                           }
                           dynload_actions( ) ;
                        }
                     }
                     else
                     {
                        sEvtType = StringUtil.Right( sEvt, 4);
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                        if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 15), "'ORDENSELECTED'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 15), "'ORDENSELECTED'") == 0 ) )
                        {
                           nGXsfl_40_idx = (short)(NumberUtil.Val( sEvtType, "."));
                           sGXsfl_40_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_40_idx), 4, 0)), 4, "0");
                           SubsflControlProps_402( ) ;
                           A1EmpID = (short)(context.localUtil.CToN( cgiGet( edtEmpID_Internalname), ",", "."));
                           if ( ( ( ((StringUtil.StrCmp(cgiGet( chkavSelect_Internalname), "1")==0) ? 1 : 0) < 0 ) ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavSelect_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
                           {
                              GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vSELECT");
                              GX_FocusControl = chkavSelect_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                              wbErr = true;
                              AV30select = 0;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavSelect_Internalname, StringUtil.Str( (decimal)(AV30select), 1, 0));
                           }
                           else
                           {
                              AV30select = (short)(((StringUtil.StrCmp(cgiGet( chkavSelect_Internalname), "1")==0) ? 1 : 0));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavSelect_Internalname, StringUtil.Str( (decimal)(AV30select), 1, 0));
                           }
                           A22OrdenID = (short)(context.localUtil.CToN( cgiGet( edtOrdenID_Internalname), ",", "."));
                           A24OrdenPeriodo = (short)(context.localUtil.CToN( cgiGet( edtOrdenPeriodo_Internalname), ",", "."));
                           A25OrdenAnio = (short)(context.localUtil.CToN( cgiGet( edtOrdenAnio_Internalname), ",", "."));
                           A119OrdenFch = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtOrdenFch_Internalname), 0));
                           n119OrdenFch = false;
                           A5ClienteID = (short)(context.localUtil.CToN( cgiGet( edtClienteID_Internalname), ",", "."));
                           A57ClienteDsc = cgiGet( edtClienteDsc_Internalname);
                           n57ClienteDsc = false;
                           A104tipOrdDsc = StringUtil.Upper( cgiGet( edttipOrdDsc_Internalname));
                           n104tipOrdDsc = false;
                           dynOrdenProceso.Name = dynOrdenProceso_Internalname;
                           dynOrdenProceso.CurrentValue = cgiGet( dynOrdenProceso_Internalname);
                           A133OrdenProceso = cgiGet( dynOrdenProceso_Internalname);
                           n133OrdenProceso = false;
                           dynprotID.Name = dynprotID_Internalname;
                           dynprotID.CurrentValue = cgiGet( dynprotID_Internalname);
                           A10protID = (short)(NumberUtil.Val( cgiGet( dynprotID_Internalname), "."));
                           AV35Update = cgiGet( edtavUpdate_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV35Update)) ? AV43Update_GXI : context.convertURL( context.PathToRelativeUrl( AV35Update))), !bGXsfl_40_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV35Update), true);
                           AV12display = cgiGet( edtavDisplay_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV12display)) ? AV46Display_GXI : context.convertURL( context.PathToRelativeUrl( AV12display))), !bGXsfl_40_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV12display), true);
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E122E2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E132E2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E142E2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "'ORDENSELECTED'") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: 'OrdenSelected' */
                                 E152E2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    Rfr0gs = false;
                                    /* Set Refresh If Ordenid Changed */
                                    if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDENID"), ",", ".") != Convert.ToDecimal( AV25ordenID )) )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Clientedsc Changed */
                                    if ( StringUtil.StrCmp(cgiGet( "GXH_vCLIENTEDSC"), AV8ClienteDsc) != 0 )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Ordenproceso Changed */
                                    if ( StringUtil.StrCmp(cgiGet( "GXH_vORDENPROCESO"), AV26OrdenProceso) != 0 )
                                    {
                                       Rfr0gs = true;
                                    }
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
                              }
                           }
                           else
                           {
                           }
                        }
                        else if ( StringUtil.StrCmp(StringUtil.Left( sEvt, 12), "GRIDPED.LOAD") == 0 )
                        {
                           nGXsfl_61_idx = (short)(NumberUtil.Val( sEvtType, "."));
                           sGXsfl_61_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_61_idx), 4, 0)), 4, "0");
                           SubsflControlProps_613( ) ;
                           A1EmpID = (short)(context.localUtil.CToN( cgiGet( edtEmpID_Internalname), ",", "."));
                           AV31select1 = (short)(((StringUtil.StrCmp(cgiGet( chkavSelect1_Internalname), "1")==0) ? 1 : 0));
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavSelect1_Internalname, StringUtil.Str( (decimal)(AV31select1), 1, 0));
                           A39PedCod = (int)(context.localUtil.CToN( cgiGet( edtPedCod_Internalname), ",", "."));
                           A205PedFchReg = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtPedFchReg_Internalname), 0));
                           n205PedFchReg = false;
                           A204PedDescripcion = cgiGet( edtPedDescripcion_Internalname);
                           n204PedDescripcion = false;
                           AV36UpdatePed = cgiGet( edtavUpdateped_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdateped_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV36UpdatePed)) ? AV44Updateped_GXI : context.convertURL( context.PathToRelativeUrl( AV36UpdatePed))), !bGXsfl_61_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdateped_Internalname, "SrcSet", context.GetImageSrcSet( AV36UpdatePed), true);
                           AV17GenDespach = cgiGet( edtavGendespach_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGendespach_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV17GenDespach)) ? AV45Gendespach_GXI : context.convertURL( context.PathToRelativeUrl( AV17GenDespach))), !bGXsfl_61_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGendespach_Internalname, "SrcSet", context.GetImageSrcSet( AV17GenDespach), true);
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "GRIDPED.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E162E3 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
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

      protected void WE2E2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm2E2( ) ;
            }
         }
      }

      protected void PA2E2( )
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
               GX_FocusControl = edtavOrdenid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLVvORDENPROCESO2E2( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvORDENPROCESO_data2E2( ) ;
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

      protected void GXVvORDENPROCESO_html2E2( )
      {
         String gxdynajaxvalue ;
         GXDLVvORDENPROCESO_data2E2( ) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavOrdenproceso.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavOrdenproceso.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvORDENPROCESO_data2E2( )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("Todos");
         /* Using cursor H002E2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(H002E2_A129ProcAbre[0]);
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H002E2_A128ProcDsc[0]));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void GXDLAPROTID2E2( short AV14empID )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLAPROTID_data2E2( AV14empID) ;
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

      protected void GXAPROTID_html2E2( short AV14empID )
      {
         short gxdynajaxvalue ;
         GXDLAPROTID_data2E2( AV14empID) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynprotID.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (short)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynprotID.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 4, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLAPROTID_data2E2( short AV14empID )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         /* Using cursor H002E3 */
         pr_default.execute(1, new Object[] {AV14empID});
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(H002E3_A10protID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H002E3_A74protDsc[0]));
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void gxnrGrid_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_402( ) ;
         while ( nGXsfl_40_idx <= nRC_GXsfl_40 )
         {
            sendrow_402( ) ;
            nGXsfl_40_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_40_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_40_idx+1));
            sGXsfl_40_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_40_idx), 4, 0)), 4, "0");
            SubsflControlProps_402( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxnrGridped_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_613( ) ;
         while ( nGXsfl_61_idx <= nRC_GXsfl_61 )
         {
            sendrow_613( ) ;
            nGXsfl_61_idx = (short)(((subGridped_Islastpage==1)&&(nGXsfl_61_idx+1>subGridped_Recordsperpage( )) ? 1 : nGXsfl_61_idx+1));
            sGXsfl_61_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_61_idx), 4, 0)), 4, "0");
            SubsflControlProps_613( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridpedContainer));
         /* End function gxnrGridped_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV25ordenID ,
                                       String AV8ClienteDsc ,
                                       String AV26OrdenProceso ,
                                       String AV42Pgmname ,
                                       String AV35Update ,
                                       short AV14empID ,
                                       DateTime AV16fecha )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF2E2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void gxgrGridped_refresh( int subGridped_Rows ,
                                          short AV25ordenID ,
                                          String AV8ClienteDsc ,
                                          String AV26OrdenProceso ,
                                          String AV42Pgmname ,
                                          String AV36UpdatePed ,
                                          String AV17GenDespach ,
                                          GXBaseCollection<SdtSDTPedidos_SDTPedidosItem> AV29SDTPedidos ,
                                          short AV14empID ,
                                          DateTime AV16fecha )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRIDPED_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridped_Rows), 6, 0, ".", "")));
         /* Execute user event: Refresh */
         E132E2 ();
         GRIDPED_nCurrentRecord = 0;
         RF2E3( ) ;
         /* End function gxgrGridped_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_CLIENTEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A5ClienteID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "CLIENTEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A5ClienteID), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_ORDENPERIODO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A24OrdenPeriodo), "Z9"), context));
         GxWebStd.gx_hidden_field( context, "ORDENPERIODO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A24OrdenPeriodo), 2, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_ORDENANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A25OrdenAnio), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "ORDENANIO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A25OrdenAnio), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_ORDENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A22OrdenID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "ORDENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A22OrdenID), 4, 0, ".", "")));
      }

      protected void clear_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
            GXVvORDENPROCESO_html2E2( ) ;
            GXAPROTID_html2E2( AV14empID) ;
            dynload_actions( ) ;
         }
      }

      protected void fix_multi_value_controls( )
      {
         if ( dynavOrdenproceso.ItemCount > 0 )
         {
            AV26OrdenProceso = dynavOrdenproceso.getValidValue(AV26OrdenProceso);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26OrdenProceso", AV26OrdenProceso);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavOrdenproceso.CurrentValue = StringUtil.RTrim( AV26OrdenProceso);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavOrdenproceso_Internalname, "Values", dynavOrdenproceso.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF2E2( ) ;
         RF2E3( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV42Pgmname = "MantOrdenProd";
         context.Gx_err = 0;
      }

      protected void RF2E2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 40;
         /* Execute user event: Refresh */
         E132E2 ();
         nGXsfl_40_idx = 1;
         sGXsfl_40_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_40_idx), 4, 0)), 4, "0");
         SubsflControlProps_402( ) ;
         bGXsfl_40_Refreshing = true;
         GridContainer.AddObjectProperty("GridName", "Grid");
         GridContainer.AddObjectProperty("CmpContext", "");
         GridContainer.AddObjectProperty("InMasterPage", "false");
         GridContainer.AddObjectProperty("Class", "WorkWith");
         GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
         GridContainer.AddObjectProperty("Sortable", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Sortable), 1, 0, ".", "")));
         GridContainer.PageSize = subGrid_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_402( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(2, new Object[]{ new Object[]{
                                                 AV8ClienteDsc ,
                                                 AV25ordenID ,
                                                 AV26OrdenProceso ,
                                                 A57ClienteDsc ,
                                                 A22OrdenID ,
                                                 A133OrdenProceso ,
                                                 A1EmpID ,
                                                 AV14empID ,
                                                 A115OrdenEst } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.SHORT,
                                                 TypeConstants.STRING, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV8ClienteDsc = StringUtil.PadR( StringUtil.RTrim( AV8ClienteDsc), 50, "%");
            /* Using cursor H002E4 */
            pr_default.execute(2, new Object[] {AV14empID, lV8ClienteDsc, AV25ordenID, AV26OrdenProceso, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_40_idx = 1;
            sGXsfl_40_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_40_idx), 4, 0)), 4, "0");
            SubsflControlProps_402( ) ;
            while ( ( (pr_default.getStatus(2) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A17tipOrdID = H002E4_A17tipOrdID[0];
               A1EmpID = H002E4_A1EmpID[0];
               A115OrdenEst = H002E4_A115OrdenEst[0];
               n115OrdenEst = H002E4_n115OrdenEst[0];
               A10protID = H002E4_A10protID[0];
               A133OrdenProceso = H002E4_A133OrdenProceso[0];
               n133OrdenProceso = H002E4_n133OrdenProceso[0];
               A104tipOrdDsc = H002E4_A104tipOrdDsc[0];
               n104tipOrdDsc = H002E4_n104tipOrdDsc[0];
               A57ClienteDsc = H002E4_A57ClienteDsc[0];
               n57ClienteDsc = H002E4_n57ClienteDsc[0];
               A5ClienteID = H002E4_A5ClienteID[0];
               A119OrdenFch = H002E4_A119OrdenFch[0];
               n119OrdenFch = H002E4_n119OrdenFch[0];
               A25OrdenAnio = H002E4_A25OrdenAnio[0];
               A24OrdenPeriodo = H002E4_A24OrdenPeriodo[0];
               A22OrdenID = H002E4_A22OrdenID[0];
               A104tipOrdDsc = H002E4_A104tipOrdDsc[0];
               n104tipOrdDsc = H002E4_n104tipOrdDsc[0];
               A57ClienteDsc = H002E4_A57ClienteDsc[0];
               n57ClienteDsc = H002E4_n57ClienteDsc[0];
               E142E2 ();
               pr_default.readNext(2);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(2) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(2);
            wbEnd = 40;
            WB2E0( ) ;
         }
         bGXsfl_40_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes2E2( )
      {
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14empID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV14empID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_CLIENTEID"+"_"+sGXsfl_40_idx, GetSecureSignedToken( sGXsfl_40_idx, context.localUtil.Format( (decimal)(A5ClienteID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_ORDENPERIODO"+"_"+sGXsfl_40_idx, GetSecureSignedToken( sGXsfl_40_idx, context.localUtil.Format( (decimal)(A24OrdenPeriodo), "Z9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_ORDENANIO"+"_"+sGXsfl_40_idx, GetSecureSignedToken( sGXsfl_40_idx, context.localUtil.Format( (decimal)(A25OrdenAnio), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_ORDENID"+"_"+sGXsfl_40_idx, GetSecureSignedToken( sGXsfl_40_idx, context.localUtil.Format( (decimal)(A22OrdenID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vFECHA", context.localUtil.DToC( AV16fecha, 0, "/"));
         GxWebStd.gx_hidden_field( context, "gxhash_vFECHA", GetSecureSignedToken( "", AV16fecha, context));
      }

      protected void RF2E3( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridpedContainer.ClearRows();
         }
         wbStart = 61;
         nGXsfl_61_idx = 1;
         sGXsfl_61_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_61_idx), 4, 0)), 4, "0");
         SubsflControlProps_613( ) ;
         bGXsfl_61_Refreshing = true;
         GridpedContainer.AddObjectProperty("GridName", "Gridped");
         GridpedContainer.AddObjectProperty("CmpContext", "");
         GridpedContainer.AddObjectProperty("InMasterPage", "false");
         GridpedContainer.AddObjectProperty("Class", "WorkWith");
         GridpedContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         GridpedContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         GridpedContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridped_Backcolorstyle), 1, 0, ".", "")));
         GridpedContainer.PageSize = subGridped_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_613( ) ;
            GXPagingFrom3 = (int)(((10==0) ? 0 : GRIDPED_nFirstRecordOnPage));
            GXPagingTo3 = ((10==0) ? 10000 : subGridped_Recordsperpage( )+1);
            /* Using cursor H002E5 */
            pr_default.execute(3, new Object[] {GXPagingFrom3, GXPagingTo3});
            nGXsfl_61_idx = 1;
            sGXsfl_61_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_61_idx), 4, 0)), 4, "0");
            SubsflControlProps_613( ) ;
            while ( ( (pr_default.getStatus(3) != 101) ) && ( ( ( 10 == 0 ) || ( GRIDPED_nCurrentRecord < subGridped_Recordsperpage( ) ) ) ) )
            {
               A204PedDescripcion = H002E5_A204PedDescripcion[0];
               n204PedDescripcion = H002E5_n204PedDescripcion[0];
               A205PedFchReg = H002E5_A205PedFchReg[0];
               n205PedFchReg = H002E5_n205PedFchReg[0];
               A39PedCod = H002E5_A39PedCod[0];
               A1EmpID = H002E5_A1EmpID[0];
               E162E3 ();
               pr_default.readNext(3);
            }
            GRIDPED_nEOF = (short)(((pr_default.getStatus(3) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRIDPED_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDPED_nEOF), 1, 0, ".", "")));
            pr_default.close(3);
            wbEnd = 61;
            WB2E0( ) ;
         }
         bGXsfl_61_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes2E3( )
      {
      }

      protected int subGrid_Pagecount( )
      {
         GRID_nRecordCount = subGrid_Recordcount( );
         if ( ((int)((GRID_nRecordCount) % (subGrid_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID_nRecordCount/ (decimal)(subGrid_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID_nRecordCount/ (decimal)(subGrid_Recordsperpage( ))))+1) ;
      }

      protected int subGrid_Recordcount( )
      {
         pr_default.dynParam(4, new Object[]{ new Object[]{
                                              AV8ClienteDsc ,
                                              AV25ordenID ,
                                              AV26OrdenProceso ,
                                              A57ClienteDsc ,
                                              A22OrdenID ,
                                              A133OrdenProceso ,
                                              A1EmpID ,
                                              AV14empID ,
                                              A115OrdenEst } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.SHORT,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV8ClienteDsc = StringUtil.PadR( StringUtil.RTrim( AV8ClienteDsc), 50, "%");
         /* Using cursor H002E6 */
         pr_default.execute(4, new Object[] {AV14empID, lV8ClienteDsc, AV25ordenID, AV26OrdenProceso});
         GRID_nRecordCount = H002E6_AGRID_nRecordCount[0];
         pr_default.close(4);
         return (int)(GRID_nRecordCount) ;
      }

      protected int subGrid_Recordsperpage( )
      {
         if ( subGrid_Rows > 0 )
         {
            return subGrid_Rows*1 ;
         }
         else
         {
            return (int)(-1) ;
         }
      }

      protected int subGrid_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID_nFirstRecordOnPage/ (decimal)(subGrid_Recordsperpage( ))))+1) ;
      }

      protected short subgrid_firstpage( )
      {
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV25ordenID, AV8ClienteDsc, AV26OrdenProceso, AV42Pgmname, AV35Update, AV14empID, AV16fecha) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         GRID_nRecordCount = subGrid_Recordcount( );
         if ( ( GRID_nRecordCount >= subGrid_Recordsperpage( ) ) && ( GRID_nEOF == 0 ) )
         {
            GRID_nFirstRecordOnPage = (long)(GRID_nFirstRecordOnPage+subGrid_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV25ordenID, AV8ClienteDsc, AV26OrdenProceso, AV42Pgmname, AV35Update, AV14empID, AV16fecha) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         if ( GRID_nFirstRecordOnPage >= subGrid_Recordsperpage( ) )
         {
            GRID_nFirstRecordOnPage = (long)(GRID_nFirstRecordOnPage-subGrid_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV25ordenID, AV8ClienteDsc, AV26OrdenProceso, AV42Pgmname, AV35Update, AV14empID, AV16fecha) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         GRID_nRecordCount = subGrid_Recordcount( );
         if ( GRID_nRecordCount > subGrid_Recordsperpage( ) )
         {
            if ( ((int)((GRID_nRecordCount) % (subGrid_Recordsperpage( )))) == 0 )
            {
               GRID_nFirstRecordOnPage = (long)(GRID_nRecordCount-subGrid_Recordsperpage( ));
            }
            else
            {
               GRID_nFirstRecordOnPage = (long)(GRID_nRecordCount-((int)((GRID_nRecordCount) % (subGrid_Recordsperpage( )))));
            }
         }
         else
         {
            GRID_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV25ordenID, AV8ClienteDsc, AV26OrdenProceso, AV42Pgmname, AV35Update, AV14empID, AV16fecha) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRID_nFirstRecordOnPage = (long)(subGrid_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRID_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV25ordenID, AV8ClienteDsc, AV26OrdenProceso, AV42Pgmname, AV35Update, AV14empID, AV16fecha) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected int subGridped_Pagecount( )
      {
         GRIDPED_nRecordCount = subGridped_Recordcount( );
         if ( ((int)((GRIDPED_nRecordCount) % (subGridped_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRIDPED_nRecordCount/ (decimal)(subGridped_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRIDPED_nRecordCount/ (decimal)(subGridped_Recordsperpage( ))))+1) ;
      }

      protected int subGridped_Recordcount( )
      {
         /* Using cursor H002E7 */
         pr_default.execute(5);
         GRIDPED_nRecordCount = H002E7_AGRIDPED_nRecordCount[0];
         pr_default.close(5);
         return (int)(GRIDPED_nRecordCount) ;
      }

      protected int subGridped_Recordsperpage( )
      {
         return (int)(10*1) ;
      }

      protected int subGridped_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRIDPED_nFirstRecordOnPage/ (decimal)(subGridped_Recordsperpage( ))))+1) ;
      }

      protected short subgridped_firstpage( )
      {
         GRIDPED_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRIDPED_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDPED_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGridped_refresh( subGridped_Rows, AV25ordenID, AV8ClienteDsc, AV26OrdenProceso, AV42Pgmname, AV36UpdatePed, AV17GenDespach, AV29SDTPedidos, AV14empID, AV16fecha) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgridped_nextpage( )
      {
         GRIDPED_nRecordCount = subGridped_Recordcount( );
         if ( ( GRIDPED_nRecordCount >= subGridped_Recordsperpage( ) ) && ( GRIDPED_nEOF == 0 ) )
         {
            GRIDPED_nFirstRecordOnPage = (long)(GRIDPED_nFirstRecordOnPage+subGridped_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRIDPED_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDPED_nFirstRecordOnPage), 15, 0, ".", "")));
         GridpedContainer.AddObjectProperty("GRIDPED_nFirstRecordOnPage", GRIDPED_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGridped_refresh( subGridped_Rows, AV25ordenID, AV8ClienteDsc, AV26OrdenProceso, AV42Pgmname, AV36UpdatePed, AV17GenDespach, AV29SDTPedidos, AV14empID, AV16fecha) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRIDPED_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgridped_previouspage( )
      {
         if ( GRIDPED_nFirstRecordOnPage >= subGridped_Recordsperpage( ) )
         {
            GRIDPED_nFirstRecordOnPage = (long)(GRIDPED_nFirstRecordOnPage-subGridped_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRIDPED_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDPED_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGridped_refresh( subGridped_Rows, AV25ordenID, AV8ClienteDsc, AV26OrdenProceso, AV42Pgmname, AV36UpdatePed, AV17GenDespach, AV29SDTPedidos, AV14empID, AV16fecha) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgridped_lastpage( )
      {
         GRIDPED_nRecordCount = subGridped_Recordcount( );
         if ( GRIDPED_nRecordCount > subGridped_Recordsperpage( ) )
         {
            if ( ((int)((GRIDPED_nRecordCount) % (subGridped_Recordsperpage( )))) == 0 )
            {
               GRIDPED_nFirstRecordOnPage = (long)(GRIDPED_nRecordCount-subGridped_Recordsperpage( ));
            }
            else
            {
               GRIDPED_nFirstRecordOnPage = (long)(GRIDPED_nRecordCount-((int)((GRIDPED_nRecordCount) % (subGridped_Recordsperpage( )))));
            }
         }
         else
         {
            GRIDPED_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRIDPED_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDPED_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGridped_refresh( subGridped_Rows, AV25ordenID, AV8ClienteDsc, AV26OrdenProceso, AV42Pgmname, AV36UpdatePed, AV17GenDespach, AV29SDTPedidos, AV14empID, AV16fecha) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgridped_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRIDPED_nFirstRecordOnPage = (long)(subGridped_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRIDPED_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRIDPED_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDPED_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGridped_refresh( subGridped_Rows, AV25ordenID, AV8ClienteDsc, AV26OrdenProceso, AV42Pgmname, AV36UpdatePed, AV17GenDespach, AV29SDTPedidos, AV14empID, AV16fecha) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP2E0( )
      {
         /* Before Start, stand alone formulas. */
         AV42Pgmname = "MantOrdenProd";
         context.Gx_err = 0;
         GXVvORDENPROCESO_html2E2( ) ;
         GXAPROTID_html2E2( AV14empID) ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E122E2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrdenid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrdenid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDENID");
               GX_FocusControl = edtavOrdenid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV25ordenID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25ordenID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25ordenID), 4, 0)));
            }
            else
            {
               AV25ordenID = (short)(context.localUtil.CToN( cgiGet( edtavOrdenid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25ordenID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25ordenID), 4, 0)));
            }
            AV8ClienteDsc = cgiGet( edtavClientedsc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ClienteDsc", AV8ClienteDsc);
            dynavOrdenproceso.Name = dynavOrdenproceso_Internalname;
            dynavOrdenproceso.CurrentValue = cgiGet( dynavOrdenproceso_Internalname);
            AV26OrdenProceso = cgiGet( dynavOrdenproceso_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26OrdenProceso", AV26OrdenProceso);
            /* Read saved values. */
            nRC_GXsfl_40 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_40"), ",", "."));
            nRC_GXsfl_61 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_61"), ",", "."));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID_nFirstRecordOnPage"), ",", "."));
            GRIDPED_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRIDPED_nFirstRecordOnPage"), ",", "."));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID_nEOF"), ",", "."));
            GRIDPED_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRIDPED_nEOF"), ",", "."));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ",", "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Tabgridop_Class = cgiGet( "TABGRIDOP_Class");
            Tabgridop_Pagecount = (int)(context.localUtil.CToN( cgiGet( "TABGRIDOP_Pagecount"), ",", "."));
            Tabgridop_Historymanagement = StringUtil.StrToBool( cgiGet( "TABGRIDOP_Historymanagement"));
            /* Read subfile selected row values. */
            nGXsfl_40_idx = (short)(context.localUtil.CToN( cgiGet( subGrid_Internalname+"_ROW"), ",", "."));
            sGXsfl_40_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_40_idx), 4, 0)), 4, "0");
            SubsflControlProps_402( ) ;
            if ( nGXsfl_40_idx > 0 )
            {
               A1EmpID = (short)(context.localUtil.CToN( cgiGet( edtEmpID_Internalname), ",", "."));
               if ( ( ( ((StringUtil.StrCmp(cgiGet( chkavSelect_Internalname), "1")==0) ? 1 : 0) < 0 ) ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavSelect_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vSELECT");
                  GX_FocusControl = chkavSelect_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  AV30select = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavSelect_Internalname, StringUtil.Str( (decimal)(AV30select), 1, 0));
               }
               else
               {
                  AV30select = (short)(((StringUtil.StrCmp(cgiGet( chkavSelect_Internalname), "1")==0) ? 1 : 0));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavSelect_Internalname, StringUtil.Str( (decimal)(AV30select), 1, 0));
               }
               A22OrdenID = (short)(context.localUtil.CToN( cgiGet( edtOrdenID_Internalname), ",", "."));
               A24OrdenPeriodo = (short)(context.localUtil.CToN( cgiGet( edtOrdenPeriodo_Internalname), ",", "."));
               A25OrdenAnio = (short)(context.localUtil.CToN( cgiGet( edtOrdenAnio_Internalname), ",", "."));
               A119OrdenFch = context.localUtil.CToD( cgiGet( edtOrdenFch_Internalname), 2);
               n119OrdenFch = false;
               A5ClienteID = (short)(context.localUtil.CToN( cgiGet( edtClienteID_Internalname), ",", "."));
               A57ClienteDsc = cgiGet( edtClienteDsc_Internalname);
               n57ClienteDsc = false;
               A104tipOrdDsc = StringUtil.Upper( cgiGet( edttipOrdDsc_Internalname));
               n104tipOrdDsc = false;
               dynOrdenProceso.Name = dynOrdenProceso_Internalname;
               dynOrdenProceso.CurrentValue = cgiGet( dynOrdenProceso_Internalname);
               A133OrdenProceso = cgiGet( dynOrdenProceso_Internalname);
               n133OrdenProceso = false;
               dynprotID.Name = dynprotID_Internalname;
               dynprotID.CurrentValue = cgiGet( dynprotID_Internalname);
               A10protID = (short)(NumberUtil.Val( cgiGet( dynprotID_Internalname), "."));
               AV35Update = cgiGet( edtavUpdate_Internalname);
               AV12display = cgiGet( edtavDisplay_Internalname);
            }
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDENID"), ",", ".") != Convert.ToDecimal( AV25ordenID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCLIENTEDSC"), AV8ClienteDsc) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vORDENPROCESO"), AV26OrdenProceso) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            /* Check if conditions changed and reset current page numbers */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E122E2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E122E2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV42Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV42Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         subGrid_Rows = 10;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         AV35Update = context.GetImagePath( "/logos/addOrder.png", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV35Update)) ? AV43Update_GXI : context.convertURL( context.PathToRelativeUrl( AV35Update))), !bGXsfl_40_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV35Update), true);
         AV43Update_GXI = GXDbFile.PathToUrl( "/logos/addOrder.png");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV35Update)) ? AV43Update_GXI : context.convertURL( context.PathToRelativeUrl( AV35Update))), !bGXsfl_40_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV35Update), true);
         edtavUpdate_Tooltiptext = "Generar Pedido";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext, !bGXsfl_40_Refreshing);
         AV36UpdatePed = context.GetImagePath( "/logos/view.png", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdateped_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV36UpdatePed)) ? AV44Updateped_GXI : context.convertURL( context.PathToRelativeUrl( AV36UpdatePed))), !bGXsfl_61_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdateped_Internalname, "SrcSet", context.GetImageSrcSet( AV36UpdatePed), true);
         AV44Updateped_GXI = GXDbFile.PathToUrl( "/logos/view.png");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdateped_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV36UpdatePed)) ? AV44Updateped_GXI : context.convertURL( context.PathToRelativeUrl( AV36UpdatePed))), !bGXsfl_61_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdateped_Internalname, "SrcSet", context.GetImageSrcSet( AV36UpdatePed), true);
         edtavUpdateped_Tooltiptext = "Modificar";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdateped_Internalname, "Tooltiptext", edtavUpdateped_Tooltiptext, !bGXsfl_61_Refreshing);
         AV17GenDespach = context.GetImagePath( "/logos/done.png", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGendespach_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV17GenDespach)) ? AV45Gendespach_GXI : context.convertURL( context.PathToRelativeUrl( AV17GenDespach))), !bGXsfl_61_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGendespach_Internalname, "SrcSet", context.GetImageSrcSet( AV17GenDespach), true);
         AV45Gendespach_GXI = GXDbFile.PathToUrl( "/logos/done.png");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGendespach_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV17GenDespach)) ? AV45Gendespach_GXI : context.convertURL( context.PathToRelativeUrl( AV17GenDespach))), !bGXsfl_61_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGendespach_Internalname, "SrcSet", context.GetImageSrcSet( AV17GenDespach), true);
         edtavGendespach_Tooltiptext = "Generado";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGendespach_Internalname, "Tooltiptext", edtavGendespach_Tooltiptext, !bGXsfl_61_Refreshing);
         Form.Caption = "Orden Pedidos";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         chkavSelect.Enabled = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavSelect_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavSelect.Enabled), 5, 0)), !bGXsfl_40_Refreshing);
         chkavSelect1.Enabled = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavSelect1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavSelect1.Enabled), 5, 0)), !bGXsfl_61_Refreshing);
         AV16fecha = DateTimeUtil.ResetTime(DateTimeUtil.ServerNow( context, pr_default));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16fecha", context.localUtil.Format(AV16fecha, "99/99/9999"));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vFECHA", GetSecureSignedToken( "", AV16fecha, context));
         /* Execute user subroutine: 'PREPARETRANSACTION' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'LOADGRIDSTATE' */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E132E2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         /* Execute user subroutine: 'SAVEGRIDSTATE' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /*  Sending Event outputs  */
      }

      private void E142E2( )
      {
         /* Grid_Load Routine */
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 40;
         }
         sendrow_402( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_40_Refreshing )
         {
            context.DoAjaxLoad(40, GridRow);
         }
      }

      protected void E152E2( )
      {
         /* 'OrdenSelected' Routine */
         AV15estado = "A";
         GXt_int1 = (short)(AV27PedCod);
         new obtultcodped(context ).execute(  AV14empID, out  GXt_int1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14empID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14empID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV14empID), "ZZZ9"), context));
         AV27PedCod = GXt_int1;
         GXt_objcol_SdtSDTPedidos_SDTPedidosItem2 = AV29SDTPedidos;
         new dpordenesselect(context ).execute(  A1EmpID,  A5ClienteID,  A24OrdenPeriodo,  A25OrdenAnio,  A22OrdenID, out  GXt_objcol_SdtSDTPedidos_SDTPedidosItem2) ;
         AV29SDTPedidos = GXt_objcol_SdtSDTPedidos_SDTPedidosItem2;
         AV11desc = "PEDIDO GENERADO AUTOMATICAMENTE LA ORDEN #" + StringUtil.Str( (decimal)(A22OrdenID), 4, 0);
         new loadpedidos(context ).execute(  AV14empID,  AV27PedCod,  AV16fecha,  AV15estado,  AV11desc,  AV29SDTPedidos.Count,  AV29SDTPedidos) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14empID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14empID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV14empID), "ZZZ9"), context));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16fecha", context.localUtil.Format(AV16fecha, "99/99/9999"));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vFECHA", GetSecureSignedToken( "", AV16fecha, context));
         new actualizarordenpro(context ).execute(  A1EmpID,  A5ClienteID,  A24OrdenPeriodo,  A25OrdenAnio,  A22OrdenID,  AV27PedCod) ;
         CallWebObject(formatLink("ordenpedido.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A1EmpID) + "," + UrlEncode("" +AV27PedCod));
         context.wjLocDisableFrm = 1;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29SDTPedidos", AV29SDTPedidos);
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV22HTTPRequest.Method, "GET") == 0 )
         {
            AV20GridState.FromXml(AV32Session.Get(AV42Pgmname+"GridState"), null, "GridState", "KBCalpesa22");
            if ( AV20GridState.gxTpr_Filtervalues.Count >= 1 )
            {
               AV8ClienteDsc = ((SdtGridState_FilterValue)AV20GridState.gxTpr_Filtervalues.Item(1)).gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ClienteDsc", AV8ClienteDsc);
            }
            if ( AV20GridState.gxTpr_Currentpage > 0 )
            {
               AV18GridPageCount = subGrid_Pagecount( );
               if ( ( AV18GridPageCount > 0 ) && ( AV18GridPageCount < AV20GridState.gxTpr_Currentpage ) )
               {
                  subgrid_gotopage( AV18GridPageCount) ;
               }
               else
               {
                  subgrid_gotopage( AV20GridState.gxTpr_Currentpage) ;
               }
            }
         }
      }

      protected void S132( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV20GridState.FromXml(AV32Session.Get(AV42Pgmname+"GridState"), null, "GridState", "KBCalpesa22");
         AV20GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         AV20GridState.gxTpr_Filtervalues.Clear();
         AV21GridStateFilterValue = new SdtGridState_FilterValue(context);
         AV21GridStateFilterValue.gxTpr_Value = AV8ClienteDsc;
         AV20GridState.gxTpr_Filtervalues.Add(AV21GridStateFilterValue, 0);
         AV32Session.Set(AV42Pgmname+"GridState", AV20GridState.ToXml(false, true, "GridState", "KBCalpesa22"));
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV33TrnContext = new SdtTransactionContext(context);
         AV33TrnContext.gxTpr_Callerobject = AV42Pgmname;
         AV33TrnContext.gxTpr_Callerondelete = true;
         AV33TrnContext.gxTpr_Callerurl = AV22HTTPRequest.ScriptName+"?"+AV22HTTPRequest.QueryString;
         AV33TrnContext.gxTpr_Transactionname = "OrdenProduccion";
         AV32Session.Set("TrnContext", AV33TrnContext.ToXml(false, true, "TransactionContext", "KBCalpesa22"));
      }

      private void E162E3( )
      {
         /* Gridped_Load Routine */
         edtavUpdateped_Link = formatLink("ordenpedido.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A1EmpID) + "," + UrlEncode("" +A39PedCod);
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 61;
         }
         sendrow_613( ) ;
         GRIDPED_nCurrentRecord = (long)(GRIDPED_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_61_Refreshing )
         {
            context.DoAjaxLoad(61, GridpedRow);
         }
         /*  Sending Event outputs  */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV14empID = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14empID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14empID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV14empID), "ZZZ9"), context));
         AV6ageID = Convert.ToInt16(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6ageID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6ageID), 4, 0)));
         AV37UserCod = (String)getParm(obj,2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37UserCod", AV37UserCod);
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
         PA2E2( ) ;
         WS2E2( ) ;
         WE2E2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2023114116182", true);
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
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("messages.spa.js", "?"+GetCacheInvalidationToken( ), false);
            context.AddJavascriptSource("mantordenprod.js", "?2023114116183", false);
            context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false);
            context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false);
            context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false);
            context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false);
            context.AddJavascriptSource("Tab/TabRender.js", "", false);
         }
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_402( )
      {
         edtEmpID_Internalname = "EMPID_"+sGXsfl_40_idx;
         chkavSelect_Internalname = "vSELECT_"+sGXsfl_40_idx;
         edtOrdenID_Internalname = "ORDENID_"+sGXsfl_40_idx;
         edtOrdenPeriodo_Internalname = "ORDENPERIODO_"+sGXsfl_40_idx;
         edtOrdenAnio_Internalname = "ORDENANIO_"+sGXsfl_40_idx;
         edtOrdenFch_Internalname = "ORDENFCH_"+sGXsfl_40_idx;
         edtClienteID_Internalname = "CLIENTEID_"+sGXsfl_40_idx;
         edtClienteDsc_Internalname = "CLIENTEDSC_"+sGXsfl_40_idx;
         edttipOrdDsc_Internalname = "TIPORDDSC_"+sGXsfl_40_idx;
         dynOrdenProceso_Internalname = "ORDENPROCESO_"+sGXsfl_40_idx;
         dynprotID_Internalname = "PROTID_"+sGXsfl_40_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_40_idx;
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_40_idx;
      }

      protected void SubsflControlProps_fel_402( )
      {
         edtEmpID_Internalname = "EMPID_"+sGXsfl_40_fel_idx;
         chkavSelect_Internalname = "vSELECT_"+sGXsfl_40_fel_idx;
         edtOrdenID_Internalname = "ORDENID_"+sGXsfl_40_fel_idx;
         edtOrdenPeriodo_Internalname = "ORDENPERIODO_"+sGXsfl_40_fel_idx;
         edtOrdenAnio_Internalname = "ORDENANIO_"+sGXsfl_40_fel_idx;
         edtOrdenFch_Internalname = "ORDENFCH_"+sGXsfl_40_fel_idx;
         edtClienteID_Internalname = "CLIENTEID_"+sGXsfl_40_fel_idx;
         edtClienteDsc_Internalname = "CLIENTEDSC_"+sGXsfl_40_fel_idx;
         edttipOrdDsc_Internalname = "TIPORDDSC_"+sGXsfl_40_fel_idx;
         dynOrdenProceso_Internalname = "ORDENPROCESO_"+sGXsfl_40_fel_idx;
         dynprotID_Internalname = "PROTID_"+sGXsfl_40_fel_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_40_fel_idx;
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_40_fel_idx;
      }

      protected void sendrow_402( )
      {
         SubsflControlProps_402( ) ;
         WB2E0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_40_idx <= subGrid_Recordsperpage( ) * 1 ) )
         {
            GridRow = GXWebRow.GetNew(context,GridContainer);
            if ( subGrid_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid_Backstyle = 0;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Odd";
               }
            }
            else if ( subGrid_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid_Backstyle = 0;
               subGrid_Backcolor = subGrid_Allbackcolor;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Uniform";
               }
            }
            else if ( subGrid_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid_Backstyle = 1;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Odd";
               }
               subGrid_Backcolor = (int)(0x0);
            }
            else if ( subGrid_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid_Backstyle = 1;
               if ( ((int)(((nGXsfl_40_idx-1)/ (decimal)(1)) % (2))) == 0 )
               {
                  subGrid_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Odd";
                  }
               }
               else
               {
                  subGrid_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Even";
                  }
               }
            }
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+"WorkWith"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_40_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEmpID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEmpID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)40,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Check box */
            TempTags = " " + ((chkavSelect.Enabled!=0)&&(chkavSelect.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 42,'',false,'"+sGXsfl_40_idx+"',40)\"" : " ");
            ClassString = "CheckBox";
            StyleString = "";
            GridRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavSelect_Internalname,StringUtil.Str( (decimal)(AV30select), 1, 0),(String)"",(String)"",(short)-1,chkavSelect.Enabled,(String)"1",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn WWOptionalColumn",(String)"",TempTags+" onclick=\"gx.fn.checkboxClick(42, this, 1, 0);gx.evt.onchange(this, event);\" "});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A22OrdenID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A22OrdenID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)80,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)40,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenPeriodo_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A24OrdenPeriodo), 2, 0, ",", "")),context.localUtil.Format( (decimal)(A24OrdenPeriodo), "Z9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenPeriodo_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)2,(short)0,(short)0,(short)40,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenAnio_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A25OrdenAnio), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A25OrdenAnio), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenAnio_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)40,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenFch_Internalname,context.localUtil.Format(A119OrdenFch, "99/99/9999"),context.localUtil.Format( A119OrdenFch, "99/99/9999"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenFch_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)40,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClienteID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A5ClienteID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A5ClienteID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtClienteID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)40,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClienteDsc_Internalname,StringUtil.RTrim( A57ClienteDsc),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtClienteDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)40,(short)1,(short)-1,(short)-1,(bool)true,(String)"Descripcion",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edttipOrdDsc_Internalname,StringUtil.RTrim( A104tipOrdDsc),StringUtil.RTrim( context.localUtil.Format( A104tipOrdDsc, "@!")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edttipOrdDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)40,(short)1,(short)-1,(short)-1,(bool)true,(String)"nombres",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( dynOrdenProceso.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "ORDENPROCESO_" + sGXsfl_40_idx;
               dynOrdenProceso.Name = GXCCtl;
               dynOrdenProceso.WebTags = "";
               dynOrdenProceso.removeAllItems();
               /* Using cursor H002E8 */
               pr_default.execute(6);
               while ( (pr_default.getStatus(6) != 101) )
               {
                  dynOrdenProceso.addItem(H002E8_A129ProcAbre[0], H002E8_A128ProcDsc[0], 0);
                  pr_default.readNext(6);
               }
               pr_default.close(6);
               if ( dynOrdenProceso.ItemCount > 0 )
               {
                  A133OrdenProceso = dynOrdenProceso.getValidValue(A133OrdenProceso);
                  n133OrdenProceso = false;
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)dynOrdenProceso,(String)dynOrdenProceso_Internalname,StringUtil.RTrim( A133OrdenProceso),(short)1,(String)dynOrdenProceso_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn WWOptionalColumn",(String)"",(String)"",(String)"",(bool)true});
            dynOrdenProceso.CurrentValue = StringUtil.RTrim( A133OrdenProceso);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynOrdenProceso_Internalname, "Values", (String)(dynOrdenProceso.ToJavascriptSource()), !bGXsfl_40_Refreshing);
            GXAPROTID_html2E2( AV14empID) ;
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( dynprotID.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "PROTID_" + sGXsfl_40_idx;
               dynprotID.Name = GXCCtl;
               dynprotID.WebTags = "";
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)dynprotID,(String)dynprotID_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(A10protID), 4, 0)),(short)1,(String)dynprotID_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn WWOptionalColumn",(String)"",(String)"",(String)"",(bool)true});
            dynprotID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A10protID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynprotID_Internalname, "Values", (String)(dynprotID.ToJavascriptSource()), !bGXsfl_40_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavUpdate_Enabled!=0)&&(edtavUpdate_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 52,'',false,'',40)\"" : " ");
            ClassString = "";
            StyleString = "";
            AV35Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV35Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV43Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV35Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV35Update)) ? AV43Update_GXI : context.PathToRelativeUrl( AV35Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavUpdate_Jsonclick,"'"+""+"'"+",false,"+"'"+"E\\'ORDENSELECTED\\'."+sGXsfl_40_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV35Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "";
            StyleString = "";
            AV12display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV12display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV46Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV12display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV12display)) ? AV46Display_GXI : context.PathToRelativeUrl( AV12display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)0,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV12display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            send_integrity_lvl_hashes2E2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_40_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_40_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_40_idx+1));
            sGXsfl_40_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_40_idx), 4, 0)), 4, "0");
            SubsflControlProps_402( ) ;
         }
         /* End function sendrow_402 */
      }

      protected void SubsflControlProps_613( )
      {
         edtEmpID_Internalname = "EMPID_"+sGXsfl_40_idx;
         chkavSelect1_Internalname = "vSELECT1_"+sGXsfl_61_idx;
         edtPedCod_Internalname = "PEDCOD_"+sGXsfl_61_idx;
         edtPedFchReg_Internalname = "PEDFCHREG_"+sGXsfl_61_idx;
         edtPedDescripcion_Internalname = "PEDDESCRIPCION_"+sGXsfl_61_idx;
         edtavUpdateped_Internalname = "vUPDATEPED_"+sGXsfl_61_idx;
         edtavGendespach_Internalname = "vGENDESPACH_"+sGXsfl_61_idx;
      }

      protected void SubsflControlProps_fel_613( )
      {
         edtEmpID_Internalname = "EMPID_"+sGXsfl_40_idx;
         chkavSelect1_Internalname = "vSELECT1_"+sGXsfl_61_fel_idx;
         edtPedCod_Internalname = "PEDCOD_"+sGXsfl_61_fel_idx;
         edtPedFchReg_Internalname = "PEDFCHREG_"+sGXsfl_61_fel_idx;
         edtPedDescripcion_Internalname = "PEDDESCRIPCION_"+sGXsfl_61_fel_idx;
         edtavUpdateped_Internalname = "vUPDATEPED_"+sGXsfl_61_fel_idx;
         edtavGendespach_Internalname = "vGENDESPACH_"+sGXsfl_61_fel_idx;
      }

      protected void sendrow_613( )
      {
         SubsflControlProps_613( ) ;
         WB2E0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_61_idx <= subGridped_Recordsperpage( ) * 1 ) )
         {
            GridpedRow = GXWebRow.GetNew(context,GridpedContainer);
            if ( subGridped_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGridped_Backstyle = 0;
               if ( StringUtil.StrCmp(subGridped_Class, "") != 0 )
               {
                  subGridped_Linesclass = subGridped_Class+"Odd";
               }
            }
            else if ( subGridped_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGridped_Backstyle = 0;
               subGridped_Backcolor = subGridped_Allbackcolor;
               if ( StringUtil.StrCmp(subGridped_Class, "") != 0 )
               {
                  subGridped_Linesclass = subGridped_Class+"Uniform";
               }
            }
            else if ( subGridped_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGridped_Backstyle = 1;
               if ( StringUtil.StrCmp(subGridped_Class, "") != 0 )
               {
                  subGridped_Linesclass = subGridped_Class+"Odd";
               }
               subGridped_Backcolor = (int)(0x0);
            }
            else if ( subGridped_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGridped_Backstyle = 1;
               if ( ((int)(((nGXsfl_61_idx-1)/ (decimal)(1)) % (2))) == 0 )
               {
                  subGridped_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGridped_Class, "") != 0 )
                  {
                     subGridped_Linesclass = subGridped_Class+"Odd";
                  }
               }
               else
               {
                  subGridped_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGridped_Class, "") != 0 )
                  {
                     subGridped_Linesclass = subGridped_Class+"Even";
                  }
               }
            }
            if ( GridpedContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+"WorkWith"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_61_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridpedContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridpedRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEmpID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEmpID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)61,(short)1,(short)-1,(short)0,(bool)false,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridpedContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Check box */
            TempTags = " " + ((chkavSelect1.Enabled!=0)&&(chkavSelect1.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 63,'',false,'"+sGXsfl_61_idx+"',61)\"" : " ");
            ClassString = "CheckBox";
            StyleString = "";
            GridpedRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavSelect1_Internalname,StringUtil.Str( (decimal)(AV31select1), 1, 0),(String)"",(String)"",(short)-1,chkavSelect1.Enabled,(String)"1",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn WWOptionalColumn",(String)"",TempTags+" onclick=\"gx.fn.checkboxClick(63, this, 1, 0);gx.evt.onchange(this, event);\" "});
            /* Subfile cell */
            if ( GridpedContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridpedRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPedCod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A39PedCod), 8, 0, ",", "")),context.localUtil.Format( (decimal)(A39PedCod), "ZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPedCod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)67,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)61,(short)1,(short)-1,(short)0,(bool)false,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridpedContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            GridpedRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPedFchReg_Internalname,context.localUtil.Format(A205PedFchReg, "99/99/9999"),context.localUtil.Format( A205PedFchReg, "99/99/9999"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPedFchReg_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)100,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)61,(short)1,(short)-1,(short)0,(bool)false,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridpedContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridpedRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPedDescripcion_Internalname,StringUtil.RTrim( A204PedDescripcion),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPedDescripcion_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)300,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)61,(short)1,(short)-1,(short)-1,(bool)false,(String)"Descripcion",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridpedContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "Image";
            StyleString = "";
            AV36UpdatePed_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV36UpdatePed))&&String.IsNullOrEmpty(StringUtil.RTrim( AV44Updateped_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV36UpdatePed)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV36UpdatePed)) ? AV44Updateped_GXI : context.PathToRelativeUrl( AV36UpdatePed));
            GridpedRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdateped_Internalname,(String)sImgUrl,(String)edtavUpdateped_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavUpdateped_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV36UpdatePed_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridpedContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "Image";
            StyleString = "";
            AV17GenDespach_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV17GenDespach))&&String.IsNullOrEmpty(StringUtil.RTrim( AV45Gendespach_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV17GenDespach)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV17GenDespach)) ? AV45Gendespach_GXI : context.PathToRelativeUrl( AV17GenDespach));
            GridpedRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavGendespach_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)0,(String)"",(String)edtavGendespach_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV17GenDespach_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            send_integrity_lvl_hashes2E3( ) ;
            GridpedContainer.AddRow(GridpedRow);
            nGXsfl_61_idx = (short)(((subGridped_Islastpage==1)&&(nGXsfl_61_idx+1>subGridped_Recordsperpage( )) ? 1 : nGXsfl_61_idx+1));
            sGXsfl_61_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_61_idx), 4, 0)), 4, "0");
            SubsflControlProps_613( ) ;
         }
         /* End function sendrow_613 */
      }

      protected void init_web_controls( )
      {
         dynavOrdenproceso.Name = "vORDENPROCESO";
         dynavOrdenproceso.WebTags = "";
         GXCCtl = "vSELECT_" + sGXsfl_40_idx;
         chkavSelect.Name = GXCCtl;
         chkavSelect.WebTags = "";
         chkavSelect.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavSelect_Internalname, "TitleCaption", chkavSelect.Caption, !bGXsfl_40_Refreshing);
         chkavSelect.CheckedValue = "0";
         GXCCtl = "ORDENPROCESO_" + sGXsfl_40_idx;
         dynOrdenProceso.Name = GXCCtl;
         dynOrdenProceso.WebTags = "";
         dynOrdenProceso.removeAllItems();
         /* Using cursor H002E9 */
         pr_default.execute(7);
         while ( (pr_default.getStatus(7) != 101) )
         {
            dynOrdenProceso.addItem(H002E9_A129ProcAbre[0], H002E9_A128ProcDsc[0], 0);
            pr_default.readNext(7);
         }
         pr_default.close(7);
         if ( dynOrdenProceso.ItemCount > 0 )
         {
            A133OrdenProceso = dynOrdenProceso.getValidValue(A133OrdenProceso);
            n133OrdenProceso = false;
         }
         GXCCtl = "PROTID_" + sGXsfl_40_idx;
         dynprotID.Name = GXCCtl;
         dynprotID.WebTags = "";
         GXCCtl = "vSELECT1_" + sGXsfl_61_idx;
         chkavSelect1.Name = GXCCtl;
         chkavSelect1.WebTags = "";
         chkavSelect1.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavSelect1_Internalname, "TitleCaption", chkavSelect1.Caption, !bGXsfl_61_Refreshing);
         chkavSelect1.CheckedValue = "0";
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTitletext_Internalname = "TITLETEXT";
         bttBtninsert_Internalname = "BTNINSERT";
         edtavOrdenid_Internalname = "vORDENID";
         edtavClientedsc_Internalname = "vCLIENTEDSC";
         dynavOrdenproceso_Internalname = "vORDENPROCESO";
         divTabletop1_Internalname = "TABLETOP1";
         lblTabtodos_title_Internalname = "TABTODOS_TITLE";
         edtEmpID_Internalname = "EMPID";
         chkavSelect_Internalname = "vSELECT";
         edtOrdenID_Internalname = "ORDENID";
         edtOrdenPeriodo_Internalname = "ORDENPERIODO";
         edtOrdenAnio_Internalname = "ORDENANIO";
         edtOrdenFch_Internalname = "ORDENFCH";
         edtClienteID_Internalname = "CLIENTEID";
         edtClienteDsc_Internalname = "CLIENTEDSC";
         edttipOrdDsc_Internalname = "TIPORDDSC";
         dynOrdenProceso_Internalname = "ORDENPROCESO";
         dynprotID_Internalname = "PROTID";
         edtavUpdate_Internalname = "vUPDATE";
         edtavDisplay_Internalname = "vDISPLAY";
         divTabgridoptable_Internalname = "TABGRIDOPTABLE";
         lblTabpage1_title_Internalname = "TABPAGE1_TITLE";
         edtEmpID_Internalname = "EMPID";
         chkavSelect1_Internalname = "vSELECT1";
         edtPedCod_Internalname = "PEDCOD";
         edtPedFchReg_Internalname = "PEDFCHREG";
         edtPedDescripcion_Internalname = "PEDDESCRIPCION";
         edtavUpdateped_Internalname = "vUPDATEPED";
         edtavGendespach_Internalname = "vGENDESPACH";
         divTabpage1table_Internalname = "TABPAGE1TABLE";
         Tabgridop_Internalname = "TABGRIDOP";
         divGridtable_Internalname = "GRIDTABLE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         subGrid_Internalname = "GRID";
         subGridped_Internalname = "GRIDPED";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         chkavSelect1.Caption = "";
         chkavSelect.Caption = "";
         edtPedDescripcion_Jsonclick = "";
         edtPedFchReg_Jsonclick = "";
         edtPedCod_Jsonclick = "";
         chkavSelect1.Visible = -1;
         edtavUpdate_Jsonclick = "";
         edtavUpdate_Visible = -1;
         edtavUpdate_Enabled = 1;
         dynprotID_Jsonclick = "";
         dynOrdenProceso_Jsonclick = "";
         edttipOrdDsc_Jsonclick = "";
         edtClienteDsc_Jsonclick = "";
         edtClienteID_Jsonclick = "";
         edtOrdenFch_Jsonclick = "";
         edtOrdenAnio_Jsonclick = "";
         edtOrdenPeriodo_Jsonclick = "";
         edtOrdenID_Jsonclick = "";
         chkavSelect.Visible = -1;
         edtEmpID_Jsonclick = "";
         subGridped_Allowcollapsing = 0;
         subGridped_Allowselection = 0;
         edtavUpdateped_Link = "";
         subGridped_Header = "";
         subGridped_Class = "WorkWith";
         subGridped_Backcolorstyle = 0;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowhovering = 0;
         subGrid_Allowselection = 1;
         subGrid_Sortable = 0;
         subGrid_Header = "";
         subGrid_Class = "WorkWith";
         subGrid_Backcolorstyle = 0;
         dynavOrdenproceso_Jsonclick = "";
         dynavOrdenproceso.Enabled = 1;
         edtavClientedsc_Jsonclick = "";
         edtavClientedsc_Enabled = 1;
         edtavOrdenid_Jsonclick = "";
         edtavOrdenid_Enabled = 1;
         Tabgridop_Historymanagement = Convert.ToBoolean( 0);
         Tabgridop_Pagecount = 2;
         Tabgridop_Class = "WWTabCustom";
         Form.Caption = "Mant Orden Prod";
         subGridped_Rows = 10;
         chkavSelect1.Enabled = 0;
         edtavGendespach_Tooltiptext = "";
         edtavUpdateped_Tooltiptext = "";
         subGrid_Rows = 10;
         chkavSelect.Enabled = 1;
         edtavUpdate_Tooltiptext = "";
         context.GX_msglist.DisplayMode = 1;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV35Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'chkavSelect.Enabled',ctrl:'vSELECT',prop:'Enabled'},{av:'GRIDPED_nFirstRecordOnPage'},{av:'GRIDPED_nEOF'},{av:'subGridped_Rows',ctrl:'GRIDPED',prop:'Rows'},{av:'AV25ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV36UpdatePed',fld:'vUPDATEPED',pic:''},{av:'edtavUpdateped_Tooltiptext',ctrl:'vUPDATEPED',prop:'Tooltiptext'},{av:'AV17GenDespach',fld:'vGENDESPACH',pic:''},{av:'edtavGendespach_Tooltiptext',ctrl:'vGENDESPACH',prop:'Tooltiptext'},{av:'chkavSelect1.Enabled',ctrl:'vSELECT1',prop:'Enabled'},{av:'AV29SDTPedidos',fld:'vSDTPEDIDOS',pic:''},{av:'AV42Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8ClienteDsc',fld:'vCLIENTEDSC',pic:''},{av:'AV16fecha',fld:'vFECHA',pic:'',hsh:true},{av:'dynavOrdenproceso'},{av:'AV26OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV14empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'dynavOrdenproceso'},{av:'AV26OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV14empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E142E2',iparms:[{av:'dynavOrdenproceso'},{av:'AV26OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV14empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'dynavOrdenproceso'},{av:'AV26OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV14empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]}");
         setEventMetadata("'ORDENSELECTED'","{handler:'E152E2',iparms:[{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9',hsh:true},{av:'A24OrdenPeriodo',fld:'ORDENPERIODO',pic:'Z9',hsh:true},{av:'A25OrdenAnio',fld:'ORDENANIO',pic:'ZZZ9',hsh:true},{av:'A22OrdenID',fld:'ORDENID',pic:'ZZZ9',hsh:true},{av:'AV16fecha',fld:'vFECHA',pic:'',hsh:true},{av:'dynavOrdenproceso'},{av:'AV26OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV14empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]");
         setEventMetadata("'ORDENSELECTED'",",oparms:[{av:'AV29SDTPedidos',fld:'vSDTPEDIDOS',pic:''},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV26OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV14empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]}");
         setEventMetadata("GRIDPED.LOAD","{handler:'E162E3',iparms:[{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'A39PedCod',fld:'PEDCOD',pic:'ZZZZZZZ9'},{av:'AV29SDTPedidos',fld:'vSDTPEDIDOS',pic:''},{av:'dynavOrdenproceso'},{av:'AV26OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV14empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]");
         setEventMetadata("GRIDPED.LOAD",",oparms:[{av:'edtavUpdateped_Link',ctrl:'vUPDATEPED',prop:'Link'},{av:'dynavOrdenproceso'},{av:'AV26OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV14empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E112E1',iparms:[{av:'dynavOrdenproceso'},{av:'AV26OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV14empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]");
         setEventMetadata("'DOINSERT'",",oparms:[{av:'dynavOrdenproceso'},{av:'AV26OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV14empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]}");
         setEventMetadata("GRID_FIRSTPAGE","{handler:'subgrid_firstpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV25ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV35Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'chkavSelect.Enabled',ctrl:'vSELECT',prop:'Enabled'},{av:'AV16fecha',fld:'vFECHA',pic:'',hsh:true},{av:'AV42Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8ClienteDsc',fld:'vCLIENTEDSC',pic:''},{av:'dynavOrdenproceso'},{av:'AV26OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV14empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]");
         setEventMetadata("GRID_FIRSTPAGE",",oparms:[{av:'dynavOrdenproceso'},{av:'AV26OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV14empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]}");
         setEventMetadata("GRID_PREVPAGE","{handler:'subgrid_previouspage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV25ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV35Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'chkavSelect.Enabled',ctrl:'vSELECT',prop:'Enabled'},{av:'AV16fecha',fld:'vFECHA',pic:'',hsh:true},{av:'AV42Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8ClienteDsc',fld:'vCLIENTEDSC',pic:''},{av:'dynavOrdenproceso'},{av:'AV26OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV14empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]");
         setEventMetadata("GRID_PREVPAGE",",oparms:[{av:'dynavOrdenproceso'},{av:'AV26OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV14empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]}");
         setEventMetadata("GRID_NEXTPAGE","{handler:'subgrid_nextpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV25ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV35Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'chkavSelect.Enabled',ctrl:'vSELECT',prop:'Enabled'},{av:'AV16fecha',fld:'vFECHA',pic:'',hsh:true},{av:'AV42Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8ClienteDsc',fld:'vCLIENTEDSC',pic:''},{av:'dynavOrdenproceso'},{av:'AV26OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV14empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]");
         setEventMetadata("GRID_NEXTPAGE",",oparms:[{av:'dynavOrdenproceso'},{av:'AV26OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV14empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]}");
         setEventMetadata("GRID_LASTPAGE","{handler:'subgrid_lastpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV25ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV35Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'chkavSelect.Enabled',ctrl:'vSELECT',prop:'Enabled'},{av:'AV16fecha',fld:'vFECHA',pic:'',hsh:true},{av:'AV42Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8ClienteDsc',fld:'vCLIENTEDSC',pic:''},{av:'dynavOrdenproceso'},{av:'AV26OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV14empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]");
         setEventMetadata("GRID_LASTPAGE",",oparms:[{av:'dynavOrdenproceso'},{av:'AV26OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV14empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]}");
         setEventMetadata("GRIDPED_FIRSTPAGE","{handler:'subgridped_firstpage',iparms:[{av:'GRIDPED_nFirstRecordOnPage'},{av:'GRIDPED_nEOF'},{av:'subGridped_Rows',ctrl:'GRIDPED',prop:'Rows'},{av:'AV25ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV36UpdatePed',fld:'vUPDATEPED',pic:''},{av:'edtavUpdateped_Tooltiptext',ctrl:'vUPDATEPED',prop:'Tooltiptext'},{av:'AV17GenDespach',fld:'vGENDESPACH',pic:''},{av:'edtavGendespach_Tooltiptext',ctrl:'vGENDESPACH',prop:'Tooltiptext'},{av:'chkavSelect1.Enabled',ctrl:'vSELECT1',prop:'Enabled'},{av:'AV29SDTPedidos',fld:'vSDTPEDIDOS',pic:''},{av:'AV16fecha',fld:'vFECHA',pic:'',hsh:true},{av:'AV42Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8ClienteDsc',fld:'vCLIENTEDSC',pic:''},{av:'dynavOrdenproceso'},{av:'AV26OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV14empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]");
         setEventMetadata("GRIDPED_FIRSTPAGE",",oparms:[{av:'dynavOrdenproceso'},{av:'AV26OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV14empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]}");
         setEventMetadata("GRIDPED_PREVPAGE","{handler:'subgridped_previouspage',iparms:[{av:'GRIDPED_nFirstRecordOnPage'},{av:'GRIDPED_nEOF'},{av:'subGridped_Rows',ctrl:'GRIDPED',prop:'Rows'},{av:'AV25ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV36UpdatePed',fld:'vUPDATEPED',pic:''},{av:'edtavUpdateped_Tooltiptext',ctrl:'vUPDATEPED',prop:'Tooltiptext'},{av:'AV17GenDespach',fld:'vGENDESPACH',pic:''},{av:'edtavGendespach_Tooltiptext',ctrl:'vGENDESPACH',prop:'Tooltiptext'},{av:'chkavSelect1.Enabled',ctrl:'vSELECT1',prop:'Enabled'},{av:'AV29SDTPedidos',fld:'vSDTPEDIDOS',pic:''},{av:'AV16fecha',fld:'vFECHA',pic:'',hsh:true},{av:'AV42Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8ClienteDsc',fld:'vCLIENTEDSC',pic:''},{av:'dynavOrdenproceso'},{av:'AV26OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV14empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]");
         setEventMetadata("GRIDPED_PREVPAGE",",oparms:[{av:'dynavOrdenproceso'},{av:'AV26OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV14empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]}");
         setEventMetadata("GRIDPED_NEXTPAGE","{handler:'subgridped_nextpage',iparms:[{av:'GRIDPED_nFirstRecordOnPage'},{av:'GRIDPED_nEOF'},{av:'subGridped_Rows',ctrl:'GRIDPED',prop:'Rows'},{av:'AV25ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV36UpdatePed',fld:'vUPDATEPED',pic:''},{av:'edtavUpdateped_Tooltiptext',ctrl:'vUPDATEPED',prop:'Tooltiptext'},{av:'AV17GenDespach',fld:'vGENDESPACH',pic:''},{av:'edtavGendespach_Tooltiptext',ctrl:'vGENDESPACH',prop:'Tooltiptext'},{av:'chkavSelect1.Enabled',ctrl:'vSELECT1',prop:'Enabled'},{av:'AV29SDTPedidos',fld:'vSDTPEDIDOS',pic:''},{av:'AV16fecha',fld:'vFECHA',pic:'',hsh:true},{av:'AV42Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8ClienteDsc',fld:'vCLIENTEDSC',pic:''},{av:'dynavOrdenproceso'},{av:'AV26OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV14empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]");
         setEventMetadata("GRIDPED_NEXTPAGE",",oparms:[{av:'dynavOrdenproceso'},{av:'AV26OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV14empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]}");
         setEventMetadata("GRIDPED_LASTPAGE","{handler:'subgridped_lastpage',iparms:[{av:'GRIDPED_nFirstRecordOnPage'},{av:'GRIDPED_nEOF'},{av:'subGridped_Rows',ctrl:'GRIDPED',prop:'Rows'},{av:'AV25ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV36UpdatePed',fld:'vUPDATEPED',pic:''},{av:'edtavUpdateped_Tooltiptext',ctrl:'vUPDATEPED',prop:'Tooltiptext'},{av:'AV17GenDespach',fld:'vGENDESPACH',pic:''},{av:'edtavGendespach_Tooltiptext',ctrl:'vGENDESPACH',prop:'Tooltiptext'},{av:'chkavSelect1.Enabled',ctrl:'vSELECT1',prop:'Enabled'},{av:'AV29SDTPedidos',fld:'vSDTPEDIDOS',pic:''},{av:'AV16fecha',fld:'vFECHA',pic:'',hsh:true},{av:'AV42Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8ClienteDsc',fld:'vCLIENTEDSC',pic:''},{av:'dynavOrdenproceso'},{av:'AV26OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV14empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]");
         setEventMetadata("GRIDPED_LASTPAGE",",oparms:[{av:'dynavOrdenproceso'},{av:'AV26OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV14empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]}");
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
         wcpOAV37UserCod = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV35Update = "";
         AV8ClienteDsc = "";
         AV26OrdenProceso = "";
         AV42Pgmname = "";
         AV16fecha = DateTime.MinValue;
         GXKey = "";
         AV36UpdatePed = "";
         AV17GenDespach = "";
         AV29SDTPedidos = new GXBaseCollection<SdtSDTPedidos_SDTPedidosItem>( context, "SDTPedidosItem", "KBCalpesa22");
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         sPrefix = "";
         lblTitletext_Jsonclick = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtninsert_Jsonclick = "";
         lblTabtodos_title_Jsonclick = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         A119OrdenFch = DateTime.MinValue;
         A57ClienteDsc = "";
         A104tipOrdDsc = "";
         A133OrdenProceso = "";
         AV12display = "";
         lblTabpage1_title_Jsonclick = "";
         GridpedContainer = new GXWebGrid( context);
         subGridped_Linesclass = "";
         GridpedColumn = new GXWebColumn();
         A205PedFchReg = DateTime.MinValue;
         A204PedDescripcion = "";
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV43Update_GXI = "";
         AV46Display_GXI = "";
         AV44Updateped_GXI = "";
         AV45Gendespach_GXI = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         scmdbuf = "";
         H002E2_A20ProcID = new short[1] ;
         H002E2_A129ProcAbre = new String[] {""} ;
         H002E2_n129ProcAbre = new bool[] {false} ;
         H002E2_A128ProcDsc = new String[] {""} ;
         H002E2_n128ProcDsc = new bool[] {false} ;
         H002E3_A10protID = new short[1] ;
         H002E3_A74protDsc = new String[] {""} ;
         H002E3_n74protDsc = new bool[] {false} ;
         H002E3_A1EmpID = new short[1] ;
         lV8ClienteDsc = "";
         A115OrdenEst = "";
         H002E4_A17tipOrdID = new short[1] ;
         H002E4_A1EmpID = new short[1] ;
         H002E4_A115OrdenEst = new String[] {""} ;
         H002E4_n115OrdenEst = new bool[] {false} ;
         H002E4_A10protID = new short[1] ;
         H002E4_A133OrdenProceso = new String[] {""} ;
         H002E4_n133OrdenProceso = new bool[] {false} ;
         H002E4_A104tipOrdDsc = new String[] {""} ;
         H002E4_n104tipOrdDsc = new bool[] {false} ;
         H002E4_A57ClienteDsc = new String[] {""} ;
         H002E4_n57ClienteDsc = new bool[] {false} ;
         H002E4_A5ClienteID = new short[1] ;
         H002E4_A119OrdenFch = new DateTime[] {DateTime.MinValue} ;
         H002E4_n119OrdenFch = new bool[] {false} ;
         H002E4_A25OrdenAnio = new short[1] ;
         H002E4_A24OrdenPeriodo = new short[1] ;
         H002E4_A22OrdenID = new short[1] ;
         H002E5_A204PedDescripcion = new String[] {""} ;
         H002E5_n204PedDescripcion = new bool[] {false} ;
         H002E5_A205PedFchReg = new DateTime[] {DateTime.MinValue} ;
         H002E5_n205PedFchReg = new bool[] {false} ;
         H002E5_A39PedCod = new int[1] ;
         H002E5_A1EmpID = new short[1] ;
         H002E6_AGRID_nRecordCount = new long[1] ;
         H002E7_AGRIDPED_nRecordCount = new long[1] ;
         GridRow = new GXWebRow();
         AV15estado = "";
         GXt_objcol_SdtSDTPedidos_SDTPedidosItem2 = new GXBaseCollection<SdtSDTPedidos_SDTPedidosItem>( context, "SDTPedidosItem", "KBCalpesa22");
         AV11desc = "";
         AV22HTTPRequest = new GxHttpRequest( context);
         AV20GridState = new SdtGridState(context);
         AV32Session = context.GetSession();
         AV21GridStateFilterValue = new SdtGridState_FilterValue(context);
         AV33TrnContext = new SdtTransactionContext(context);
         GridpedRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         GXCCtl = "";
         H002E8_A20ProcID = new short[1] ;
         H002E8_A129ProcAbre = new String[] {""} ;
         H002E8_n129ProcAbre = new bool[] {false} ;
         H002E8_A128ProcDsc = new String[] {""} ;
         H002E8_n128ProcDsc = new bool[] {false} ;
         sImgUrl = "";
         H002E9_A20ProcID = new short[1] ;
         H002E9_A129ProcAbre = new String[] {""} ;
         H002E9_n129ProcAbre = new bool[] {false} ;
         H002E9_A128ProcDsc = new String[] {""} ;
         H002E9_n128ProcDsc = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.mantordenprod__default(),
            new Object[][] {
                new Object[] {
               H002E2_A20ProcID, H002E2_A129ProcAbre, H002E2_n129ProcAbre, H002E2_A128ProcDsc, H002E2_n128ProcDsc
               }
               , new Object[] {
               H002E3_A10protID, H002E3_A74protDsc, H002E3_n74protDsc, H002E3_A1EmpID
               }
               , new Object[] {
               H002E4_A17tipOrdID, H002E4_A1EmpID, H002E4_A115OrdenEst, H002E4_n115OrdenEst, H002E4_A10protID, H002E4_A133OrdenProceso, H002E4_n133OrdenProceso, H002E4_A104tipOrdDsc, H002E4_n104tipOrdDsc, H002E4_A57ClienteDsc,
               H002E4_n57ClienteDsc, H002E4_A5ClienteID, H002E4_A119OrdenFch, H002E4_n119OrdenFch, H002E4_A25OrdenAnio, H002E4_A24OrdenPeriodo, H002E4_A22OrdenID
               }
               , new Object[] {
               H002E5_A204PedDescripcion, H002E5_n204PedDescripcion, H002E5_A205PedFchReg, H002E5_n205PedFchReg, H002E5_A39PedCod, H002E5_A1EmpID
               }
               , new Object[] {
               H002E6_AGRID_nRecordCount
               }
               , new Object[] {
               H002E7_AGRIDPED_nRecordCount
               }
               , new Object[] {
               H002E8_A20ProcID, H002E8_A129ProcAbre, H002E8_n129ProcAbre, H002E8_A128ProcDsc, H002E8_n128ProcDsc
               }
               , new Object[] {
               H002E9_A20ProcID, H002E9_A129ProcAbre, H002E9_n129ProcAbre, H002E9_A128ProcDsc, H002E9_n128ProcDsc
               }
            }
         );
         AV42Pgmname = "MantOrdenProd";
         /* GeneXus formulas. */
         AV42Pgmname = "MantOrdenProd";
         context.Gx_err = 0;
      }

      private short AV14empID ;
      private short AV6ageID ;
      private short wcpOAV14empID ;
      private short wcpOAV6ageID ;
      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_40 ;
      private short nGXsfl_40_idx=1 ;
      private short nRC_GXsfl_61 ;
      private short GRID_nEOF ;
      private short GRIDPED_nEOF ;
      private short AV25ordenID ;
      private short nGXsfl_61_idx=1 ;
      private short initialized ;
      private short nGXWrapped ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short subGrid_Sortable ;
      private short A1EmpID ;
      private short AV30select ;
      private short A22OrdenID ;
      private short A24OrdenPeriodo ;
      private short A25OrdenAnio ;
      private short A5ClienteID ;
      private short A10protID ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short subGridped_Backcolorstyle ;
      private short subGridped_Titlebackstyle ;
      private short AV31select1 ;
      private short subGridped_Allowselection ;
      private short subGridped_Allowhovering ;
      private short subGridped_Allowcollapsing ;
      private short subGridped_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short A17tipOrdID ;
      private short GXt_int1 ;
      private short subGrid_Backstyle ;
      private short subGridped_Backstyle ;
      private int subGrid_Rows ;
      private int subGridped_Rows ;
      private int Tabgridop_Pagecount ;
      private int edtavOrdenid_Enabled ;
      private int edtavClientedsc_Enabled ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int subGridped_Titlebackcolor ;
      private int subGridped_Allbackcolor ;
      private int A39PedCod ;
      private int subGridped_Selectedindex ;
      private int subGridped_Selectioncolor ;
      private int subGridped_Hoveringcolor ;
      private int gxdynajaxindex ;
      private int subGrid_Islastpage ;
      private int subGridped_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int GXPagingFrom3 ;
      private int GXPagingTo3 ;
      private int AV27PedCod ;
      private int AV18GridPageCount ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavUpdate_Enabled ;
      private int edtavUpdate_Visible ;
      private int subGridped_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long GRIDPED_nFirstRecordOnPage ;
      private long GRID_nCurrentRecord ;
      private long GRIDPED_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private long GRIDPED_nRecordCount ;
      private String AV37UserCod ;
      private String wcpOAV37UserCod ;
      private String edtavUpdate_Tooltiptext ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_40_idx="0001" ;
      private String edtavUpdate_Internalname ;
      private String chkavSelect_Internalname ;
      private String AV8ClienteDsc ;
      private String AV42Pgmname ;
      private String GXKey ;
      private String sGXsfl_61_idx="0001" ;
      private String edtavUpdateped_Tooltiptext ;
      private String edtavUpdateped_Internalname ;
      private String edtavGendespach_Tooltiptext ;
      private String edtavGendespach_Internalname ;
      private String chkavSelect1_Internalname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String Tabgridop_Class ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String divTabletop1_Internalname ;
      private String lblTitletext_Internalname ;
      private String lblTitletext_Jsonclick ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtninsert_Internalname ;
      private String bttBtninsert_Jsonclick ;
      private String edtavOrdenid_Internalname ;
      private String edtavOrdenid_Jsonclick ;
      private String edtavClientedsc_Internalname ;
      private String edtavClientedsc_Jsonclick ;
      private String dynavOrdenproceso_Internalname ;
      private String dynavOrdenproceso_Jsonclick ;
      private String divGridtable_Internalname ;
      private String lblTabtodos_title_Internalname ;
      private String lblTabtodos_title_Jsonclick ;
      private String divTabgridoptable_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String subGrid_Header ;
      private String A57ClienteDsc ;
      private String A104tipOrdDsc ;
      private String lblTabpage1_title_Internalname ;
      private String lblTabpage1_title_Jsonclick ;
      private String divTabpage1table_Internalname ;
      private String subGridped_Internalname ;
      private String subGridped_Class ;
      private String subGridped_Linesclass ;
      private String subGridped_Header ;
      private String A204PedDescripcion ;
      private String edtavUpdateped_Link ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtEmpID_Internalname ;
      private String edtOrdenID_Internalname ;
      private String edtOrdenPeriodo_Internalname ;
      private String edtOrdenAnio_Internalname ;
      private String edtOrdenFch_Internalname ;
      private String edtClienteID_Internalname ;
      private String edtClienteDsc_Internalname ;
      private String edttipOrdDsc_Internalname ;
      private String dynOrdenProceso_Internalname ;
      private String dynprotID_Internalname ;
      private String edtavDisplay_Internalname ;
      private String edtPedCod_Internalname ;
      private String edtPedFchReg_Internalname ;
      private String edtPedDescripcion_Internalname ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String lV8ClienteDsc ;
      private String A115OrdenEst ;
      private String AV15estado ;
      private String AV11desc ;
      private String sGXsfl_40_fel_idx="0001" ;
      private String ROClassString ;
      private String edtEmpID_Jsonclick ;
      private String edtOrdenID_Jsonclick ;
      private String edtOrdenPeriodo_Jsonclick ;
      private String edtOrdenAnio_Jsonclick ;
      private String edtOrdenFch_Jsonclick ;
      private String edtClienteID_Jsonclick ;
      private String edtClienteDsc_Jsonclick ;
      private String edttipOrdDsc_Jsonclick ;
      private String GXCCtl ;
      private String dynOrdenProceso_Jsonclick ;
      private String dynprotID_Jsonclick ;
      private String sImgUrl ;
      private String edtavUpdate_Jsonclick ;
      private String sGXsfl_61_fel_idx="0001" ;
      private String edtPedCod_Jsonclick ;
      private String edtPedFchReg_Jsonclick ;
      private String edtPedDescripcion_Jsonclick ;
      private String Tabgridop_Internalname ;
      private DateTime AV16fecha ;
      private DateTime A119OrdenFch ;
      private DateTime A205PedFchReg ;
      private bool entryPointCalled ;
      private bool bGXsfl_40_Refreshing=false ;
      private bool bGXsfl_61_Refreshing=false ;
      private bool toggleJsOutput ;
      private bool Tabgridop_Historymanagement ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n119OrdenFch ;
      private bool n57ClienteDsc ;
      private bool n104tipOrdDsc ;
      private bool n133OrdenProceso ;
      private bool n205PedFchReg ;
      private bool n204PedDescripcion ;
      private bool gxdyncontrolsrefreshing ;
      private bool n115OrdenEst ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV35Update_IsBlob ;
      private bool AV12display_IsBlob ;
      private bool AV36UpdatePed_IsBlob ;
      private bool AV17GenDespach_IsBlob ;
      private String AV26OrdenProceso ;
      private String A133OrdenProceso ;
      private String AV43Update_GXI ;
      private String AV46Display_GXI ;
      private String AV44Updateped_GXI ;
      private String AV45Gendespach_GXI ;
      private String AV35Update ;
      private String AV36UpdatePed ;
      private String AV17GenDespach ;
      private String AV12display ;
      private IGxSession AV32Session ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXWebGrid GridContainer ;
      private GXWebGrid GridpedContainer ;
      private GXWebRow GridRow ;
      private GXWebRow GridpedRow ;
      private GXWebColumn GridColumn ;
      private GXWebColumn GridpedColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynavOrdenproceso ;
      private GXCheckbox chkavSelect ;
      private GXCombobox dynOrdenProceso ;
      private GXCombobox dynprotID ;
      private GXCheckbox chkavSelect1 ;
      private IDataStoreProvider pr_default ;
      private short[] H002E2_A20ProcID ;
      private String[] H002E2_A129ProcAbre ;
      private bool[] H002E2_n129ProcAbre ;
      private String[] H002E2_A128ProcDsc ;
      private bool[] H002E2_n128ProcDsc ;
      private short[] H002E3_A10protID ;
      private String[] H002E3_A74protDsc ;
      private bool[] H002E3_n74protDsc ;
      private short[] H002E3_A1EmpID ;
      private short[] H002E4_A17tipOrdID ;
      private short[] H002E4_A1EmpID ;
      private String[] H002E4_A115OrdenEst ;
      private bool[] H002E4_n115OrdenEst ;
      private short[] H002E4_A10protID ;
      private String[] H002E4_A133OrdenProceso ;
      private bool[] H002E4_n133OrdenProceso ;
      private String[] H002E4_A104tipOrdDsc ;
      private bool[] H002E4_n104tipOrdDsc ;
      private String[] H002E4_A57ClienteDsc ;
      private bool[] H002E4_n57ClienteDsc ;
      private short[] H002E4_A5ClienteID ;
      private DateTime[] H002E4_A119OrdenFch ;
      private bool[] H002E4_n119OrdenFch ;
      private short[] H002E4_A25OrdenAnio ;
      private short[] H002E4_A24OrdenPeriodo ;
      private short[] H002E4_A22OrdenID ;
      private String[] H002E5_A204PedDescripcion ;
      private bool[] H002E5_n204PedDescripcion ;
      private DateTime[] H002E5_A205PedFchReg ;
      private bool[] H002E5_n205PedFchReg ;
      private int[] H002E5_A39PedCod ;
      private short[] H002E5_A1EmpID ;
      private long[] H002E6_AGRID_nRecordCount ;
      private long[] H002E7_AGRIDPED_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short[] H002E8_A20ProcID ;
      private String[] H002E8_A129ProcAbre ;
      private bool[] H002E8_n129ProcAbre ;
      private String[] H002E8_A128ProcDsc ;
      private bool[] H002E8_n128ProcDsc ;
      private short[] H002E9_A20ProcID ;
      private String[] H002E9_A129ProcAbre ;
      private bool[] H002E9_n129ProcAbre ;
      private String[] H002E9_A128ProcDsc ;
      private bool[] H002E9_n128ProcDsc ;
      private GxHttpRequest AV22HTTPRequest ;
      private GXBaseCollection<SdtSDTPedidos_SDTPedidosItem> AV29SDTPedidos ;
      private GXBaseCollection<SdtSDTPedidos_SDTPedidosItem> GXt_objcol_SdtSDTPedidos_SDTPedidosItem2 ;
      private SdtGridState AV20GridState ;
      private SdtGridState_FilterValue AV21GridStateFilterValue ;
      private SdtTransactionContext AV33TrnContext ;
   }

   public class mantordenprod__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H002E4( IGxContext context ,
                                             String AV8ClienteDsc ,
                                             short AV25ordenID ,
                                             String AV26OrdenProceso ,
                                             String A57ClienteDsc ,
                                             short A22OrdenID ,
                                             String A133OrdenProceso ,
                                             short A1EmpID ,
                                             short AV14empID ,
                                             String A115OrdenEst )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " T1.[tipOrdID], T1.[EmpID], T1.[OrdenEst], T1.[protID], T1.[OrdenProceso], T2.[tipOrdDsc], T3.[ClienteDsc], T1.[ClienteID], T1.[OrdenFch], T1.[OrdenAnio], T1.[OrdenPeriodo], T1.[OrdenID]";
         sFromString = " FROM (([OrdenProduccion] T1 WITH (NOLOCK) INNER JOIN [TipoOrdenPro] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[tipOrdID] = T1.[tipOrdID]) INNER JOIN [Clientes] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[ClienteID] = T1.[ClienteID])";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (T1.[OrdenProceso] <> 'ENT')";
         sWhereString = sWhereString + " and (T1.[EmpID] = @AV14empID)";
         sWhereString = sWhereString + " and (T1.[OrdenEst] = 'A')";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8ClienteDsc)) )
         {
            sWhereString = sWhereString + " and (T3.[ClienteDsc] like '%' + @lV8ClienteDsc + '%')";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV25ordenID) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenID] = @AV25ordenID)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26OrdenProceso)) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenProceso] = @AV26OrdenProceso)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         sOrderString = sOrderString + " ORDER BY T1.[OrdenID], T1.[OrdenFch]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H002E6( IGxContext context ,
                                             String AV8ClienteDsc ,
                                             short AV25ordenID ,
                                             String AV26OrdenProceso ,
                                             String A57ClienteDsc ,
                                             short A22OrdenID ,
                                             String A133OrdenProceso ,
                                             short A1EmpID ,
                                             short AV14empID ,
                                             String A115OrdenEst )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [4] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM (([OrdenProduccion] T1 WITH (NOLOCK) INNER JOIN [TipoOrdenPro] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[tipOrdID] = T1.[tipOrdID]) INNER JOIN [Clientes] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[ClienteID] = T1.[ClienteID])";
         scmdbuf = scmdbuf + " WHERE (T1.[OrdenProceso] <> 'ENT')";
         scmdbuf = scmdbuf + " and (T1.[EmpID] = @AV14empID)";
         scmdbuf = scmdbuf + " and (T1.[OrdenEst] = 'A')";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8ClienteDsc)) )
         {
            sWhereString = sWhereString + " and (T2.[ClienteDsc] like '%' + @lV8ClienteDsc + '%')";
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ! (0==AV25ordenID) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenID] = @AV25ordenID)";
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26OrdenProceso)) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenProceso] = @AV26OrdenProceso)";
         }
         else
         {
            GXv_int5[3] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + "";
         GXv_Object6[0] = scmdbuf;
         GXv_Object6[1] = GXv_int5;
         return GXv_Object6 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 2 :
                     return conditional_H002E4(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (short)dynConstraints[4] , (String)dynConstraints[5] , (short)dynConstraints[6] , (short)dynConstraints[7] , (String)dynConstraints[8] );
               case 4 :
                     return conditional_H002E6(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (short)dynConstraints[4] , (String)dynConstraints[5] , (short)dynConstraints[6] , (short)dynConstraints[7] , (String)dynConstraints[8] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH002E2 ;
          prmH002E2 = new Object[] {
          } ;
          Object[] prmH002E3 ;
          prmH002E3 = new Object[] {
          new Object[] {"@AV14empID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH002E5 ;
          prmH002E5 = new Object[] {
          new Object[] {"@GXPagingFrom3",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo3",SqlDbType.Int,9,0}
          } ;
          Object[] prmH002E7 ;
          prmH002E7 = new Object[] {
          } ;
          Object[] prmH002E8 ;
          prmH002E8 = new Object[] {
          } ;
          Object[] prmH002E9 ;
          prmH002E9 = new Object[] {
          } ;
          Object[] prmH002E4 ;
          prmH002E4 = new Object[] {
          new Object[] {"@AV14empID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV8ClienteDsc",SqlDbType.Char,50,0} ,
          new Object[] {"@AV25ordenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV26OrdenProceso",SqlDbType.VarChar,5,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH002E6 ;
          prmH002E6 = new Object[] {
          new Object[] {"@AV14empID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV8ClienteDsc",SqlDbType.Char,50,0} ,
          new Object[] {"@AV25ordenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV26OrdenProceso",SqlDbType.VarChar,5,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002E2", "SELECT [ProcID], [ProcAbre], [ProcDsc] FROM [Procesos] WITH (NOLOCK) ORDER BY [ProcDsc] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002E2,0,0,true,false )
             ,new CursorDef("H002E3", "SELECT [protID], [protDsc], [EmpID] FROM [Prototipo] WITH (NOLOCK) WHERE [EmpID] = @AV14empID ORDER BY [protDsc] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002E3,0,0,true,false )
             ,new CursorDef("H002E4", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002E4,11,0,true,false )
             ,new CursorDef("H002E5", "SELECT [PedDescripcion], [PedFchReg], [PedCod], [EmpID] FROM [OrdenPedido] WITH (NOLOCK) ORDER BY [PedCod]  OFFSET @GXPagingFrom3 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo3 > 0 THEN @GXPagingTo3 ELSE 1e9 END) AS INTEGER) ROWS ONLY",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002E5,11,0,false,false )
             ,new CursorDef("H002E6", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002E6,1,0,true,false )
             ,new CursorDef("H002E7", "SELECT COUNT(*) FROM [OrdenPedido] WITH (NOLOCK) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002E7,1,0,false,false )
             ,new CursorDef("H002E8", "SELECT [ProcID], [ProcAbre], [ProcDsc] FROM [Procesos] WITH (NOLOCK) ORDER BY [ProcDsc] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002E8,0,0,true,false )
             ,new CursorDef("H002E9", "SELECT [ProcID], [ProcAbre], [ProcDsc] FROM [Procesos] WITH (NOLOCK) ORDER BY [ProcDsc] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002E9,0,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 40) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((String[]) buf[7])[0] = rslt.getString(6, 40) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                ((String[]) buf[9])[0] = rslt.getString(7, 50) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(7);
                ((short[]) buf[11])[0] = rslt.getShort(8) ;
                ((DateTime[]) buf[12])[0] = rslt.getGXDate(9) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(9);
                ((short[]) buf[14])[0] = rslt.getShort(10) ;
                ((short[]) buf[15])[0] = rslt.getShort(11) ;
                ((short[]) buf[16])[0] = rslt.getShort(12) ;
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((int[]) buf[4])[0] = rslt.getInt(3) ;
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                return;
             case 4 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
             case 5 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 40) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                return;
             case 7 :
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
       short sIdx ;
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 2 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[7]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[8]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[9]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[11]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[12]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[13]);
                }
                return;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                return;
             case 4 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[4]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[5]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[6]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                return;
       }
    }

 }

}
