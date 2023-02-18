/*
               File: WWOrdenProduccion
        Description: Work With Orden Produccion
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/14/2023 1:18:52.74
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
   public class wwordenproduccion : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public wwordenproduccion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public wwordenproduccion( IGxContext context )
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
         this.AV13empID = aP0_empID;
         this.AV6ageID = aP1_ageID;
         this.AV34UserCod = aP2_UserCod;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavAnio = new GXCombobox();
         cmbavPeriod = new GXCombobox();
         dynavMarca = new GXCombobox();
         dynavModelo = new GXCombobox();
         dynavVendedor = new GXCombobox();
         dynavOrdenproceso = new GXCombobox();
         dynOrdenProceso = new GXCombobox();
         dynprotID = new GXCombobox();
         dynOrdenProceso = new GXCombobox();
         dynprotID = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"PROTID") == 0 )
            {
               AV13empID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13empID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13empID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV13empID), "ZZZ9"), context));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLAPROTID1K3( AV13empID) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vMARCA") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvMARCA1K2( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vMODELO") == 0 )
            {
               AV13empID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13empID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13empID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV13empID), "ZZZ9"), context));
               AV22marca = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22marca", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22marca), 4, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvMODELO1K2( AV13empID, AV22marca) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vVENDEDOR") == 0 )
            {
               AV13empID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13empID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13empID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV13empID), "ZZZ9"), context));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvVENDEDOR1K2( AV13empID) ;
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
               GXDLVvORDENPROCESO1K2( ) ;
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
               nRC_GXsfl_66 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_66_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_66_idx = GetNextPar( );
               AV12emails = GetNextPar( );
               edtavEmails_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEmails_Internalname, "Tooltiptext", edtavEmails_Tooltiptext, !bGXsfl_66_Refreshing);
               AV33Update = GetNextPar( );
               edtavUpdate_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext, !bGXsfl_66_Refreshing);
               edtavUpdate_Visible = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_66_Refreshing);
               AV10Delete = GetNextPar( );
               edtavDelete_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext, !bGXsfl_66_Refreshing);
               AV11display = GetNextPar( );
               edtavDisplay_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Tooltiptext", edtavDisplay_Tooltiptext, !bGXsfl_66_Refreshing);
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
               AV7anio = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV28period = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV26ordenID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV8ClienteDsc = GetNextPar( );
               AV37vehiculoPlaca = GetNextPar( );
               AV36vehiculoChasis = GetNextPar( );
               AV22marca = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV25modelo = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV38vendedor = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV27OrdenProceso = GetNextPar( );
               AV47Pgmname = GetNextPar( );
               AV12emails = GetNextPar( );
               edtavEmails_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEmails_Internalname, "Tooltiptext", edtavEmails_Tooltiptext, !bGXsfl_66_Refreshing);
               AV33Update = GetNextPar( );
               edtavUpdate_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext, !bGXsfl_66_Refreshing);
               edtavUpdate_Visible = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_66_Refreshing);
               AV10Delete = GetNextPar( );
               edtavDelete_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext, !bGXsfl_66_Refreshing);
               AV11display = GetNextPar( );
               edtavDisplay_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Tooltiptext", edtavDisplay_Tooltiptext, !bGXsfl_66_Refreshing);
               AV6ageID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV34UserCod = GetNextPar( );
               AV13empID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               A5ClienteID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV7anio, AV28period, AV26ordenID, AV8ClienteDsc, AV37vehiculoPlaca, AV36vehiculoChasis, AV22marca, AV25modelo, AV38vendedor, AV27OrdenProceso, AV47Pgmname, AV12emails, AV33Update, AV10Delete, AV11display, AV6ageID, AV34UserCod, AV13empID, A5ClienteID) ;
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridinac") == 0 )
            {
               nRC_GXsfl_90 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_90_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_90_idx = GetNextPar( );
               AV12emails = GetNextPar( );
               edtavEmails_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEmails_Internalname, "Tooltiptext", edtavEmails_Tooltiptext, !bGXsfl_66_Refreshing);
               AV33Update = GetNextPar( );
               edtavUpdate_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext, !bGXsfl_66_Refreshing);
               edtavUpdate_Visible = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_66_Refreshing);
               AV10Delete = GetNextPar( );
               edtavDelete_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext, !bGXsfl_66_Refreshing);
               AV11display = GetNextPar( );
               edtavDisplay_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Tooltiptext", edtavDisplay_Tooltiptext, !bGXsfl_66_Refreshing);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGridinac_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Gridinac") == 0 )
            {
               subGridinac_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
               AV7anio = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV28period = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV26ordenID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV8ClienteDsc = GetNextPar( );
               AV37vehiculoPlaca = GetNextPar( );
               AV36vehiculoChasis = GetNextPar( );
               AV22marca = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV25modelo = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV38vendedor = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV27OrdenProceso = GetNextPar( );
               AV47Pgmname = GetNextPar( );
               AV12emails = GetNextPar( );
               edtavEmails_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEmails_Internalname, "Tooltiptext", edtavEmails_Tooltiptext, !bGXsfl_66_Refreshing);
               AV33Update = GetNextPar( );
               edtavUpdate_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext, !bGXsfl_66_Refreshing);
               edtavUpdate_Visible = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_66_Refreshing);
               AV10Delete = GetNextPar( );
               edtavDelete_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext, !bGXsfl_66_Refreshing);
               AV11display = GetNextPar( );
               edtavDisplay_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Tooltiptext", edtavDisplay_Tooltiptext, !bGXsfl_66_Refreshing);
               AV6ageID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV34UserCod = GetNextPar( );
               AV13empID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               A5ClienteID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGridinac_refresh( subGridinac_Rows, AV7anio, AV28period, AV26ordenID, AV8ClienteDsc, AV37vehiculoPlaca, AV36vehiculoChasis, AV22marca, AV25modelo, AV38vendedor, AV27OrdenProceso, AV47Pgmname, AV12emails, AV33Update, AV10Delete, AV11display, AV6ageID, AV34UserCod, AV13empID, A5ClienteID) ;
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
               AV13empID = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13empID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13empID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV13empID), "ZZZ9"), context));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV6ageID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6ageID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6ageID), 4, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV6ageID), "ZZZ9"), context));
                  AV34UserCod = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34UserCod", AV34UserCod);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSERCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV34UserCod, "")), context));
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
            PA1K2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV47Pgmname = "WWOrdenProduccion";
               context.Gx_err = 0;
               GXVvMARCA_html1K2( ) ;
               GXVvORDENPROCESO_html1K2( ) ;
               GXVvMODELO_html1K2( AV13empID, AV22marca) ;
               GXVvVENDEDOR_html1K2( AV13empID) ;
               GXAPROTID_html1K3( AV13empID) ;
               WS1K2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE1K2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2023114118548", false);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("wwordenproduccion.aspx") + "?" + UrlEncode("" +AV13empID) + "," + UrlEncode("" +AV6ageID) + "," + UrlEncode(StringUtil.RTrim(AV34UserCod))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vANIO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7anio), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vPERIOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV28period), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV26ordenID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCLIENTEDSC", StringUtil.RTrim( AV8ClienteDsc));
         GxWebStd.gx_hidden_field( context, "GXH_vVEHICULOPLACA", AV37vehiculoPlaca);
         GxWebStd.gx_hidden_field( context, "GXH_vVEHICULOCHASIS", AV36vehiculoChasis);
         GxWebStd.gx_hidden_field( context, "GXH_vMARCA", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22marca), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vMODELO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25modelo), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vVENDEDOR", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV38vendedor), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDENPROCESO", AV27OrdenProceso);
         GxWebStd.gx_hidden_field( context, "GXH_vANIO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7anio), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vPERIOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV28period), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV26ordenID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCLIENTEDSC", StringUtil.RTrim( AV8ClienteDsc));
         GxWebStd.gx_hidden_field( context, "GXH_vVEHICULOPLACA", AV37vehiculoPlaca);
         GxWebStd.gx_hidden_field( context, "GXH_vVEHICULOCHASIS", AV36vehiculoChasis);
         GxWebStd.gx_hidden_field( context, "GXH_vMARCA", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22marca), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vMODELO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25modelo), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vVENDEDOR", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV38vendedor), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDENPROCESO", AV27OrdenProceso);
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_66", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_66), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_90", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_90), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV47Pgmname));
         GxWebStd.gx_hidden_field( context, "EMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6ageID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV6ageID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "CLIENTEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A5ClienteID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_CLIENTEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A5ClienteID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vUSERCOD", StringUtil.RTrim( AV34UserCod));
         GxWebStd.gx_hidden_field( context, "gxhash_vUSERCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV34UserCod, "")), context));
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRIDINAC_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDINAC_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRIDINAC_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDINAC_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13empID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV13empID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TABGRIDOP_Class", StringUtil.RTrim( Tabgridop_Class));
         GxWebStd.gx_hidden_field( context, "TABGRIDOP_Pagecount", StringUtil.LTrim( StringUtil.NToC( (decimal)(Tabgridop_Pagecount), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TABGRIDOP_Historymanagement", StringUtil.BoolToStr( Tabgridop_Historymanagement));
         GxWebStd.gx_hidden_field( context, "TBBUSAVANCED_Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(divTbbusavanced_Visible), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vEMAILS_Tooltiptext", StringUtil.RTrim( edtavEmails_Tooltiptext));
         GxWebStd.gx_hidden_field( context, "vUPDATE_Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
         GxWebStd.gx_hidden_field( context, "vUPDATE_Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Visible), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vDELETE_Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
         GxWebStd.gx_hidden_field( context, "vDISPLAY_Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
      }

      protected void RenderHtmlCloseForm1K2( )
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
         return "WWOrdenProduccion" ;
      }

      public override String GetPgmdesc( )
      {
         return "Work With Orden Produccion" ;
      }

      protected void WB1K0( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 ViewGridCellAdvanced", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabletop1_Internalname, 1, 0, "px", 0, "px", "TableTopSearch", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 col-lg-3 col-lg-offset-1", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitletext_Internalname, "Orden Produccion", "", "", lblTitletext_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "SubTitle", 0, "", 1, 1, 0, "HLP_WWOrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 col-lg-8 WWActionsCell", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavAnio_Internalname, "anio", " AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'" + sGXsfl_66_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavAnio, cmbavAnio_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV7anio), 4, 0)), 1, cmbavAnio_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbavAnio.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,13);\"", "", true, "HLP_WWOrdenProduccion.htm");
            cmbavAnio.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV7anio), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavAnio_Internalname, "Values", (String)(cmbavAnio.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            ClassString = "BtnNew";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(66), 2, 0)+","+"null"+");", "Agregar", bttBtninsert_Jsonclick, 5, "Agregar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWOrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbusavanzada_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(66), 2, 0)+","+"null"+");", bttBtnbusavanzada_Caption, bttBtnbusavanzada_Jsonclick, 7, bttBtnbusavanzada_Tooltiptext, "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e111k1_client"+"'", TempTags, "", 2, "HLP_WWOrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 col-lg-2 col-lg-offset-1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavPeriod_Internalname, "period", "col-sm-3 FilterComboAttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'" + sGXsfl_66_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavPeriod, cmbavPeriod_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV28period), 2, 0)), 1, cmbavPeriod_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVPERIOD.CLICK."+"'", "int", "", 1, cmbavPeriod.Enabled, 0, 0, 150, "px", 0, "", "", "FilterComboAttribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,21);\"", "", true, "HLP_WWOrdenProduccion.htm");
            cmbavPeriod.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV28period), 2, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPeriod_Internalname, "Values", (String)(cmbavPeriod.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 col-lg-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavOrdenid_Internalname, "orden ID", "col-sm-3 FilterSearchAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_66_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdenid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV26ordenID), 4, 0, ",", "")), ((edtavOrdenid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV26ordenID), "ZZZ9")) : context.localUtil.Format( (decimal)(AV26ordenID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,24);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "Nro", edtavOrdenid_Jsonclick, 0, "FilterSearchAttribute", "", "", "", "", 1, edtavOrdenid_Enabled, 0, "number", "1", 125, "px", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WWOrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 col-lg-3", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClientedsc_Internalname, "Cliente Dsc", "col-sm-3 FilterSearchAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'" + sGXsfl_66_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClientedsc_Internalname, StringUtil.RTrim( AV8ClienteDsc), StringUtil.RTrim( context.localUtil.Format( AV8ClienteDsc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,27);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "Cliente", edtavClientedsc_Jsonclick, 0, "FilterSearchAttribute", "", "", "", "", 1, edtavClientedsc_Enabled, 0, "text", "", 20, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWOrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVehiculoplaca_Internalname, "vehiculo Placa", "col-sm-3 FilterSearchAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'" + sGXsfl_66_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVehiculoplaca_Internalname, AV37vehiculoPlaca, StringUtil.RTrim( context.localUtil.Format( AV37vehiculoPlaca, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "# Placa", edtavVehiculoplaca_Jsonclick, 0, "FilterSearchAttribute", "", "", "", "", 1, edtavVehiculoplaca_Enabled, 0, "text", "", 150, "px", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWOrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVehiculochasis_Internalname, "vehiculo Chasis", "col-sm-3 FilterSearchAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'" + sGXsfl_66_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVehiculochasis_Internalname, AV36vehiculoChasis, StringUtil.RTrim( context.localUtil.Format( AV36vehiculoChasis, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "# Chasis", edtavVehiculochasis_Jsonclick, 0, "FilterSearchAttribute", "", "", "", "", 1, edtavVehiculochasis_Enabled, 0, "text", "", 180, "px", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWOrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 ViewGridCellAdvanced", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTbbusavanced_Internalname, divTbbusavanced_Visible, 0, "px", 0, "px", "TableTopSearch", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavMarca_Internalname, "marca", "col-sm-3 FilterComboAttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'" + sGXsfl_66_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavMarca, dynavMarca_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV22marca), 4, 0)), 1, dynavMarca_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dynavMarca.Enabled, 0, 0, 14, "em", 0, "", "", "FilterComboAttribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,40);\"", "", true, "HLP_WWOrdenProduccion.htm");
            dynavMarca.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV22marca), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavMarca_Internalname, "Values", (String)(dynavMarca.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavModelo_Internalname, "modelo", "col-sm-3 FilterComboAttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'" + sGXsfl_66_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavModelo, dynavModelo_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV25modelo), 4, 0)), 1, dynavModelo_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dynavModelo.Enabled, 0, 0, 14, "em", 0, "", "", "FilterComboAttribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", "", true, "HLP_WWOrdenProduccion.htm");
            dynavModelo.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV25modelo), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavModelo_Internalname, "Values", (String)(dynavModelo.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavVendedor_Internalname, "vendedor", "col-sm-3 FilterComboAttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_66_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavVendedor, dynavVendedor_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV38vendedor), 4, 0)), 1, dynavVendedor_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dynavVendedor.Enabled, 0, 0, 18, "em", 0, "", "", "FilterComboAttribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", "", true, "HLP_WWOrdenProduccion.htm");
            dynavVendedor.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV38vendedor), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVendedor_Internalname, "Values", (String)(dynavVendedor.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavOrdenproceso_Internalname, "Orden Proceso", "col-sm-3 FilterComboAttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'" + sGXsfl_66_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavOrdenproceso, dynavOrdenproceso_Internalname, StringUtil.RTrim( AV27OrdenProceso), 1, dynavOrdenproceso_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavOrdenproceso.Enabled, 0, 0, 25, "em", 0, "", "", "FilterComboAttribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "", true, "HLP_WWOrdenProduccion.htm");
            dynavOrdenproceso.CurrentValue = StringUtil.RTrim( AV27OrdenProceso);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavOrdenproceso_Internalname, "Values", (String)(dynavOrdenproceso.ToJavascriptSource()), true);
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
            GxWebStd.gx_label_ctrl( context, lblTabtodos_title_Internalname, "Activos", "", "", lblTabtodos_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_WWOrdenProduccion.htm");
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"66\">") ;
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(60), 4, 0))+"px"+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Año") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(60), 4, 0))+"px"+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Mes") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Fecha") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Nro.FACT") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Cliente") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(80), 4, 0))+"px"+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Orden") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "# Placa") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "# Chasis") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Tipo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "vendedor") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Proceso Actual") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Prototipo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+""+"\" "+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+""+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
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
               GridContainer.AddObjectProperty("CmpContext", "");
               GridContainer.AddObjectProperty("InMasterPage", "false");
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A25OrdenAnio), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A24OrdenPeriodo), 2, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A119OrdenFch, "99/99/9999"));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A106facturaNro), 8, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A57ClienteDsc));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A22OrdenID), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A68VehiculoPlaca);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A69VehiculoChasis);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A104tipOrdDsc));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A121VendedorSiglas);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A133OrdenProceso);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A10protID), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV33Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV12emails));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavEmails_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV11display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV10Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
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
         if ( wbEnd == 66 )
         {
            wbEnd = 0;
            nRC_GXsfl_66 = (short)(nGXsfl_66_idx-1);
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
            GxWebStd.gx_label_ctrl( context, lblTabinact_title_Internalname, "Inactivos", "", "", lblTabinact_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_WWOrdenProduccion.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "TabInact") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABGRIDOPContainer"+"panel2"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabpage2table_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            GridinacContainer.SetWrapped(nGXWrapped);
            if ( GridinacContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"GridinacContainer"+"DivS\" data-gxgridid=\"90\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGridinac_Internalname, subGridinac_Internalname, "", "WorkWith", 0, "", "", 1, 2, sStyleString, "", "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGridinac_Backcolorstyle == 0 )
               {
                  subGridinac_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGridinac_Class) > 0 )
                  {
                     subGridinac_Linesclass = subGridinac_Class+"Title";
                  }
               }
               else
               {
                  subGridinac_Titlebackstyle = 1;
                  if ( subGridinac_Backcolorstyle == 1 )
                  {
                     subGridinac_Titlebackcolor = subGridinac_Allbackcolor;
                     if ( StringUtil.Len( subGridinac_Class) > 0 )
                     {
                        subGridinac_Linesclass = subGridinac_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGridinac_Class) > 0 )
                     {
                        subGridinac_Linesclass = subGridinac_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(60), 4, 0))+"px"+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Año") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(60), 4, 0))+"px"+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Mes") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Fecha") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Nro.FACT") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Cliente") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Orden") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "# Placa") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "# Chasis") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Tipo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "vendedor") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Proceso Actual") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Prototipo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+""+"\" "+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+""+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+""+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+""+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               GridinacContainer.AddObjectProperty("GridName", "Gridinac");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  GridinacContainer = new GXWebGrid( context);
               }
               else
               {
                  GridinacContainer.Clear();
               }
               GridinacContainer.SetWrapped(nGXWrapped);
               GridinacContainer.AddObjectProperty("GridName", "Gridinac");
               GridinacContainer.AddObjectProperty("Header", subGridinac_Header);
               GridinacContainer.AddObjectProperty("Class", "WorkWith");
               GridinacContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               GridinacContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               GridinacContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridinac_Backcolorstyle), 1, 0, ".", "")));
               GridinacContainer.AddObjectProperty("CmpContext", "");
               GridinacContainer.AddObjectProperty("InMasterPage", "false");
               GridinacColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridinacColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A25OrdenAnio), 4, 0, ".", "")));
               GridinacContainer.AddColumnProperties(GridinacColumn);
               GridinacColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridinacColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A24OrdenPeriodo), 2, 0, ".", "")));
               GridinacContainer.AddColumnProperties(GridinacColumn);
               GridinacColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridinacColumn.AddObjectProperty("Value", context.localUtil.Format(A119OrdenFch, "99/99/9999"));
               GridinacContainer.AddColumnProperties(GridinacColumn);
               GridinacColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridinacColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A106facturaNro), 8, 0, ".", "")));
               GridinacContainer.AddColumnProperties(GridinacColumn);
               GridinacColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridinacColumn.AddObjectProperty("Value", StringUtil.RTrim( A57ClienteDsc));
               GridinacContainer.AddColumnProperties(GridinacColumn);
               GridinacColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridinacColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A22OrdenID), 4, 0, ".", "")));
               GridinacContainer.AddColumnProperties(GridinacColumn);
               GridinacColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridinacColumn.AddObjectProperty("Value", A68VehiculoPlaca);
               GridinacContainer.AddColumnProperties(GridinacColumn);
               GridinacColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridinacColumn.AddObjectProperty("Value", A69VehiculoChasis);
               GridinacContainer.AddColumnProperties(GridinacColumn);
               GridinacColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridinacColumn.AddObjectProperty("Value", StringUtil.RTrim( A104tipOrdDsc));
               GridinacContainer.AddColumnProperties(GridinacColumn);
               GridinacColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridinacColumn.AddObjectProperty("Value", A121VendedorSiglas);
               GridinacContainer.AddColumnProperties(GridinacColumn);
               GridinacColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridinacColumn.AddObjectProperty("Value", A133OrdenProceso);
               GridinacContainer.AddColumnProperties(GridinacColumn);
               GridinacColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridinacColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A10protID), 4, 0, ".", "")));
               GridinacContainer.AddColumnProperties(GridinacColumn);
               GridinacColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridinacColumn.AddObjectProperty("Value", context.convertURL( AV33Update));
               GridinacColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridinacColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridinacColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Visible), 5, 0, ".", "")));
               GridinacContainer.AddColumnProperties(GridinacColumn);
               GridinacColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridinacColumn.AddObjectProperty("Value", context.convertURL( AV12emails));
               GridinacColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavEmails_Tooltiptext));
               GridinacContainer.AddColumnProperties(GridinacColumn);
               GridinacColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridinacColumn.AddObjectProperty("Value", context.convertURL( AV11display));
               GridinacColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridinacColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridinacContainer.AddColumnProperties(GridinacColumn);
               GridinacColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridinacColumn.AddObjectProperty("Value", context.convertURL( AV10Delete));
               GridinacColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridinacColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridinacContainer.AddColumnProperties(GridinacColumn);
               GridinacContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridinac_Selectedindex), 4, 0, ".", "")));
               GridinacContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridinac_Allowselection), 1, 0, ".", "")));
               GridinacContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridinac_Selectioncolor), 9, 0, ".", "")));
               GridinacContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridinac_Allowhovering), 1, 0, ".", "")));
               GridinacContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridinac_Hoveringcolor), 9, 0, ".", "")));
               GridinacContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridinac_Allowcollapsing), 1, 0, ".", "")));
               GridinacContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridinac_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 90 )
         {
            wbEnd = 0;
            nRC_GXsfl_90 = (short)(nGXsfl_90_idx-1);
            if ( GridinacContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               GridinacContainer.AddObjectProperty("GRIDINAC_nEOF", GRIDINAC_nEOF);
               GridinacContainer.AddObjectProperty("GRIDINAC_nFirstRecordOnPage", GRIDINAC_nFirstRecordOnPage);
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"GridinacContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridinac", GridinacContainer);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridinacContainerData", GridinacContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridinacContainerData"+"V", GridinacContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GridinacContainerData"+"V"+"\" value='"+GridinacContainer.GridValuesHidden()+"'/>") ;
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
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavYear_Internalname, "year", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 110,'',false,'" + sGXsfl_66_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavYear_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV39year), 4, 0, ",", "")), ((edtavYear_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV39year), "ZZZ9")) : context.localUtil.Format( (decimal)(AV39year), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,110);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavYear_Jsonclick, 0, "Attribute", "", "", "", "", edtavYear_Visible, edtavYear_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WWOrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 66 )
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
         if ( wbEnd == 90 )
         {
            wbEnd = 0;
            if ( isFullAjaxMode( ) )
            {
               if ( GridinacContainer.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  GridinacContainer.AddObjectProperty("GRIDINAC_nEOF", GRIDINAC_nEOF);
                  GridinacContainer.AddObjectProperty("GRIDINAC_nFirstRecordOnPage", GRIDINAC_nFirstRecordOnPage);
                  sStyleString = "";
                  context.WriteHtmlText( "<div id=\""+"GridinacContainer"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridinac", GridinacContainer);
                  if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "GridinacContainerData", GridinacContainer.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "GridinacContainerData"+"V", GridinacContainer.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GridinacContainerData"+"V"+"\" value='"+GridinacContainer.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START1K2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "Work With Orden Produccion", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1K0( ) ;
      }

      protected void WS1K2( )
      {
         START1K2( ) ;
         EVT1K2( ) ;
      }

      protected void EVT1K2( )
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
                        else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: 'DoInsert' */
                           E121K2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "VPERIOD.CLICK") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E131K2 ();
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
                        else if ( StringUtil.StrCmp(sEvt, "GRIDINACPAGING") == 0 )
                        {
                           context.wbHandled = 1;
                           sEvt = cgiGet( "GRIDINACPAGING");
                           if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                           {
                              subgridinac_firstpage( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                           {
                              subgridinac_previouspage( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                           {
                              subgridinac_nextpage( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                           {
                              subgridinac_lastpage( ) ;
                           }
                           dynload_actions( ) ;
                        }
                     }
                     else
                     {
                        sEvtType = StringUtil.Right( sEvt, 4);
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                        if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 13), "VEMAILS.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 13), "VEMAILS.CLICK") == 0 ) )
                        {
                           nGXsfl_66_idx = (short)(NumberUtil.Val( sEvtType, "."));
                           sGXsfl_66_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_66_idx), 4, 0)), 4, "0");
                           SubsflControlProps_662( ) ;
                           A25OrdenAnio = (short)(context.localUtil.CToN( cgiGet( edtOrdenAnio_Internalname), ",", "."));
                           A24OrdenPeriodo = (short)(context.localUtil.CToN( cgiGet( edtOrdenPeriodo_Internalname), ",", "."));
                           A119OrdenFch = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtOrdenFch_Internalname), 0));
                           n119OrdenFch = false;
                           A106facturaNro = (int)(context.localUtil.CToN( cgiGet( edtfacturaNro_Internalname), ",", "."));
                           n106facturaNro = false;
                           A57ClienteDsc = cgiGet( edtClienteDsc_Internalname);
                           n57ClienteDsc = false;
                           A22OrdenID = (short)(context.localUtil.CToN( cgiGet( edtOrdenID_Internalname), ",", "."));
                           A68VehiculoPlaca = cgiGet( edtVehiculoPlaca_Internalname);
                           n68VehiculoPlaca = false;
                           A69VehiculoChasis = cgiGet( edtVehiculoChasis_Internalname);
                           n69VehiculoChasis = false;
                           A104tipOrdDsc = StringUtil.Upper( cgiGet( edttipOrdDsc_Internalname));
                           n104tipOrdDsc = false;
                           A121VendedorSiglas = cgiGet( edtVendedorSiglas_Internalname);
                           n121VendedorSiglas = false;
                           dynOrdenProceso.Name = dynOrdenProceso_Internalname;
                           dynOrdenProceso.CurrentValue = cgiGet( dynOrdenProceso_Internalname);
                           A133OrdenProceso = cgiGet( dynOrdenProceso_Internalname);
                           n133OrdenProceso = false;
                           dynprotID.Name = dynprotID_Internalname;
                           dynprotID.CurrentValue = cgiGet( dynprotID_Internalname);
                           A10protID = (short)(NumberUtil.Val( cgiGet( dynprotID_Internalname), "."));
                           AV33Update = cgiGet( edtavUpdate_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV33Update)) ? AV48Update_GXI : context.convertURL( context.PathToRelativeUrl( AV33Update))), !bGXsfl_66_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV33Update), true);
                           AV12emails = cgiGet( edtavEmails_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEmails_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV12emails)) ? AV46Emails_GXI : context.convertURL( context.PathToRelativeUrl( AV12emails))), !bGXsfl_66_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEmails_Internalname, "SrcSet", context.GetImageSrcSet( AV12emails), true);
                           AV11display = cgiGet( edtavDisplay_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV11display)) ? AV50Display_GXI : context.convertURL( context.PathToRelativeUrl( AV11display))), !bGXsfl_66_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV11display), true);
                           AV10Delete = cgiGet( edtavDelete_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV10Delete)) ? AV49Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV10Delete))), !bGXsfl_66_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV10Delete), true);
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E141K2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E151K2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E161K2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "VEMAILS.CLICK") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E171K2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    Rfr0gs = false;
                                    /* Set Refresh If Anio Changed */
                                    if ( ( context.localUtil.CToN( cgiGet( "GXH_vANIO"), ",", ".") != Convert.ToDecimal( AV7anio )) )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Period Changed */
                                    if ( ( context.localUtil.CToN( cgiGet( "GXH_vPERIOD"), ",", ".") != Convert.ToDecimal( AV28period )) )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Ordenid Changed */
                                    if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDENID"), ",", ".") != Convert.ToDecimal( AV26ordenID )) )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Clientedsc Changed */
                                    if ( StringUtil.StrCmp(cgiGet( "GXH_vCLIENTEDSC"), AV8ClienteDsc) != 0 )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Vehiculoplaca Changed */
                                    if ( StringUtil.StrCmp(cgiGet( "GXH_vVEHICULOPLACA"), AV37vehiculoPlaca) != 0 )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Vehiculochasis Changed */
                                    if ( StringUtil.StrCmp(cgiGet( "GXH_vVEHICULOCHASIS"), AV36vehiculoChasis) != 0 )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Marca Changed */
                                    if ( ( context.localUtil.CToN( cgiGet( "GXH_vMARCA"), ",", ".") != Convert.ToDecimal( AV22marca )) )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Modelo Changed */
                                    if ( ( context.localUtil.CToN( cgiGet( "GXH_vMODELO"), ",", ".") != Convert.ToDecimal( AV25modelo )) )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Vendedor Changed */
                                    if ( ( context.localUtil.CToN( cgiGet( "GXH_vVENDEDOR"), ",", ".") != Convert.ToDecimal( AV38vendedor )) )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Ordenproceso Changed */
                                    if ( StringUtil.StrCmp(cgiGet( "GXH_vORDENPROCESO"), AV27OrdenProceso) != 0 )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Anio Changed */
                                    if ( ( context.localUtil.CToN( cgiGet( "GXH_vANIO"), ",", ".") != Convert.ToDecimal( AV7anio )) )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Period Changed */
                                    if ( ( context.localUtil.CToN( cgiGet( "GXH_vPERIOD"), ",", ".") != Convert.ToDecimal( AV28period )) )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Ordenid Changed */
                                    if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDENID"), ",", ".") != Convert.ToDecimal( AV26ordenID )) )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Clientedsc Changed */
                                    if ( StringUtil.StrCmp(cgiGet( "GXH_vCLIENTEDSC"), AV8ClienteDsc) != 0 )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Vehiculoplaca Changed */
                                    if ( StringUtil.StrCmp(cgiGet( "GXH_vVEHICULOPLACA"), AV37vehiculoPlaca) != 0 )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Vehiculochasis Changed */
                                    if ( StringUtil.StrCmp(cgiGet( "GXH_vVEHICULOCHASIS"), AV36vehiculoChasis) != 0 )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Marca Changed */
                                    if ( ( context.localUtil.CToN( cgiGet( "GXH_vMARCA"), ",", ".") != Convert.ToDecimal( AV22marca )) )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Modelo Changed */
                                    if ( ( context.localUtil.CToN( cgiGet( "GXH_vMODELO"), ",", ".") != Convert.ToDecimal( AV25modelo )) )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Vendedor Changed */
                                    if ( ( context.localUtil.CToN( cgiGet( "GXH_vVENDEDOR"), ",", ".") != Convert.ToDecimal( AV38vendedor )) )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Ordenproceso Changed */
                                    if ( StringUtil.StrCmp(cgiGet( "GXH_vORDENPROCESO"), AV27OrdenProceso) != 0 )
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
                        else if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 13), "GRIDINAC.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 13), "VEMAILS.CLICK") == 0 ) )
                        {
                           nGXsfl_90_idx = (short)(NumberUtil.Val( sEvtType, "."));
                           sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx), 4, 0)), 4, "0");
                           SubsflControlProps_903( ) ;
                           A25OrdenAnio = (short)(context.localUtil.CToN( cgiGet( edtOrdenAnio_Internalname), ",", "."));
                           A24OrdenPeriodo = (short)(context.localUtil.CToN( cgiGet( edtOrdenPeriodo_Internalname), ",", "."));
                           A119OrdenFch = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtOrdenFch_Internalname), 0));
                           n119OrdenFch = false;
                           A106facturaNro = (int)(context.localUtil.CToN( cgiGet( edtfacturaNro_Internalname), ",", "."));
                           n106facturaNro = false;
                           A57ClienteDsc = cgiGet( edtClienteDsc_Internalname);
                           n57ClienteDsc = false;
                           A22OrdenID = (short)(context.localUtil.CToN( cgiGet( edtOrdenID_Internalname), ",", "."));
                           A68VehiculoPlaca = cgiGet( edtVehiculoPlaca_Internalname);
                           n68VehiculoPlaca = false;
                           A69VehiculoChasis = cgiGet( edtVehiculoChasis_Internalname);
                           n69VehiculoChasis = false;
                           A104tipOrdDsc = StringUtil.Upper( cgiGet( edttipOrdDsc_Internalname));
                           n104tipOrdDsc = false;
                           A121VendedorSiglas = cgiGet( edtVendedorSiglas_Internalname);
                           n121VendedorSiglas = false;
                           dynOrdenProceso.Name = dynOrdenProceso_Internalname;
                           dynOrdenProceso.CurrentValue = cgiGet( dynOrdenProceso_Internalname);
                           A133OrdenProceso = cgiGet( dynOrdenProceso_Internalname);
                           n133OrdenProceso = false;
                           dynprotID.Name = dynprotID_Internalname;
                           dynprotID.CurrentValue = cgiGet( dynprotID_Internalname);
                           A10protID = (short)(NumberUtil.Val( cgiGet( dynprotID_Internalname), "."));
                           AV33Update = cgiGet( edtavUpdate_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV33Update)) ? AV48Update_GXI : context.convertURL( context.PathToRelativeUrl( AV33Update))), !bGXsfl_66_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV33Update), true);
                           AV12emails = cgiGet( edtavEmails_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEmails_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV12emails)) ? AV46Emails_GXI : context.convertURL( context.PathToRelativeUrl( AV12emails))), !bGXsfl_66_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEmails_Internalname, "SrcSet", context.GetImageSrcSet( AV12emails), true);
                           AV11display = cgiGet( edtavDisplay_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV11display)) ? AV50Display_GXI : context.convertURL( context.PathToRelativeUrl( AV11display))), !bGXsfl_66_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV11display), true);
                           AV10Delete = cgiGet( edtavDelete_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV10Delete)) ? AV49Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV10Delete))), !bGXsfl_66_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV10Delete), true);
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "GRIDINAC.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E181K3 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "VEMAILS.CLICK") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E171K2 ();
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

      protected void WE1K2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm1K2( ) ;
            }
         }
      }

      protected void PA1K2( )
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
               GX_FocusControl = cmbavAnio_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         GXVvMODELO_html1K2( AV13empID, AV22marca) ;
         GXVvMODELO_html1K2( AV13empID, AV22marca) ;
         /* End function dynload_actions */
      }

      protected void GXDLAPROTID1K3( short AV13empID )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLAPROTID_data1K3( AV13empID) ;
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

      protected void GXAPROTID_html1K3( short AV13empID )
      {
         short gxdynajaxvalue ;
         GXDLAPROTID_data1K3( AV13empID) ;
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

      protected void GXDLAPROTID_data1K3( short AV13empID )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         /* Using cursor H001K2 */
         pr_default.execute(0, new Object[] {AV13empID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(H001K2_A10protID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H001K2_A74protDsc[0]));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void GXDLVvMARCA1K2( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvMARCA_data1K2( ) ;
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

      protected void GXVvMARCA_html1K2( )
      {
         short gxdynajaxvalue ;
         GXDLVvMARCA_data1K2( ) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavMarca.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (short)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynavMarca.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 4, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvMARCA_data1K2( )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Todos");
         /* Using cursor H001K3 */
         pr_default.execute(1);
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(H001K3_A6MarcaID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H001K3_A62MarcaDsc[0]));
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void GXDLVvMODELO1K2( short AV13empID ,
                                      short AV22marca )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvMODELO_data1K2( AV13empID, AV22marca) ;
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

      protected void GXVvMODELO_html1K2( short AV13empID ,
                                         short AV22marca )
      {
         short gxdynajaxvalue ;
         GXDLVvMODELO_data1K2( AV13empID, AV22marca) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavModelo.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (short)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynavModelo.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 4, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvMODELO_data1K2( short AV13empID ,
                                           short AV22marca )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Todos");
         /* Using cursor H001K4 */
         pr_default.execute(2, new Object[] {AV13empID, AV22marca});
         while ( (pr_default.getStatus(2) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(H001K4_A7ModeloID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H001K4_A64ModeloDsc[0]));
            pr_default.readNext(2);
         }
         pr_default.close(2);
      }

      protected void GXDLVvVENDEDOR1K2( short AV13empID )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvVENDEDOR_data1K2( AV13empID) ;
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

      protected void GXVvVENDEDOR_html1K2( short AV13empID )
      {
         short gxdynajaxvalue ;
         GXDLVvVENDEDOR_data1K2( AV13empID) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavVendedor.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (short)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynavVendedor.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 4, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvVENDEDOR_data1K2( short AV13empID )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Todos");
         /* Using cursor H001K5 */
         pr_default.execute(3, new Object[] {AV13empID});
         while ( (pr_default.getStatus(3) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(H001K5_A9vendedorID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H001K5_A72vendedorDsc[0]));
            pr_default.readNext(3);
         }
         pr_default.close(3);
      }

      protected void GXDLVvORDENPROCESO1K2( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvORDENPROCESO_data1K2( ) ;
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

      protected void GXVvORDENPROCESO_html1K2( )
      {
         String gxdynajaxvalue ;
         GXDLVvORDENPROCESO_data1K2( ) ;
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

      protected void GXDLVvORDENPROCESO_data1K2( )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("Todos");
         /* Using cursor H001K6 */
         pr_default.execute(4);
         while ( (pr_default.getStatus(4) != 101) )
         {
            gxdynajaxctrlcodr.Add(H001K6_A129ProcAbre[0]);
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H001K6_A128ProcDsc[0]));
            pr_default.readNext(4);
         }
         pr_default.close(4);
      }

      protected void gxnrGrid_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_662( ) ;
         while ( nGXsfl_66_idx <= nRC_GXsfl_66 )
         {
            sendrow_662( ) ;
            nGXsfl_66_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_66_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_66_idx+1));
            sGXsfl_66_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_66_idx), 4, 0)), 4, "0");
            SubsflControlProps_662( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxnrGridinac_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_903( ) ;
         while ( nGXsfl_90_idx <= nRC_GXsfl_90 )
         {
            sendrow_903( ) ;
            nGXsfl_90_idx = (short)(((subGridinac_Islastpage==1)&&(nGXsfl_90_idx+1>subGridinac_Recordsperpage( )) ? 1 : nGXsfl_90_idx+1));
            sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx), 4, 0)), 4, "0");
            SubsflControlProps_903( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridinacContainer));
         /* End function gxnrGridinac_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV7anio ,
                                       short AV28period ,
                                       short AV26ordenID ,
                                       String AV8ClienteDsc ,
                                       String AV37vehiculoPlaca ,
                                       String AV36vehiculoChasis ,
                                       short AV22marca ,
                                       short AV25modelo ,
                                       short AV38vendedor ,
                                       String AV27OrdenProceso ,
                                       String AV47Pgmname ,
                                       String AV12emails ,
                                       String AV33Update ,
                                       String AV10Delete ,
                                       String AV11display ,
                                       short AV6ageID ,
                                       String AV34UserCod ,
                                       short AV13empID ,
                                       short A5ClienteID )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF1K2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void gxgrGridinac_refresh( int subGridinac_Rows ,
                                           short AV7anio ,
                                           short AV28period ,
                                           short AV26ordenID ,
                                           String AV8ClienteDsc ,
                                           String AV37vehiculoPlaca ,
                                           String AV36vehiculoChasis ,
                                           short AV22marca ,
                                           short AV25modelo ,
                                           short AV38vendedor ,
                                           String AV27OrdenProceso ,
                                           String AV47Pgmname ,
                                           String AV12emails ,
                                           String AV33Update ,
                                           String AV10Delete ,
                                           String AV11display ,
                                           short AV6ageID ,
                                           String AV34UserCod ,
                                           short AV13empID ,
                                           short A5ClienteID )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRIDINAC_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridinac_Rows), 6, 0, ".", "")));
         /* Execute user event: Refresh */
         E151K2 ();
         GRIDINAC_nCurrentRecord = 0;
         RF1K3( ) ;
         /* End function gxgrGridinac_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_ORDENPERIODO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A24OrdenPeriodo), "Z9"), context));
         GxWebStd.gx_hidden_field( context, "ORDENPERIODO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A24OrdenPeriodo), 2, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_ORDENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A22OrdenID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "ORDENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A22OrdenID), 4, 0, ".", "")));
      }

      protected void clear_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
            GXVvMARCA_html1K2( ) ;
            GXVvORDENPROCESO_html1K2( ) ;
            GXVvMODELO_html1K2( AV13empID, AV22marca) ;
            GXVvVENDEDOR_html1K2( AV13empID) ;
            dynload_actions( ) ;
         }
      }

      protected void fix_multi_value_controls( )
      {
         if ( cmbavAnio.ItemCount > 0 )
         {
            AV7anio = (short)(NumberUtil.Val( cmbavAnio.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV7anio), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7anio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7anio), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavAnio.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV7anio), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavAnio_Internalname, "Values", cmbavAnio.ToJavascriptSource(), true);
         }
         if ( cmbavPeriod.ItemCount > 0 )
         {
            AV28period = (short)(NumberUtil.Val( cmbavPeriod.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV28period), 2, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28period", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28period), 2, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavPeriod.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV28period), 2, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPeriod_Internalname, "Values", cmbavPeriod.ToJavascriptSource(), true);
         }
         if ( dynavMarca.ItemCount > 0 )
         {
            AV22marca = (short)(NumberUtil.Val( dynavMarca.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV22marca), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22marca", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22marca), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavMarca.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV22marca), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavMarca_Internalname, "Values", dynavMarca.ToJavascriptSource(), true);
         }
         if ( dynavModelo.ItemCount > 0 )
         {
            AV25modelo = (short)(NumberUtil.Val( dynavModelo.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV25modelo), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25modelo", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25modelo), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavModelo.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV25modelo), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavModelo_Internalname, "Values", dynavModelo.ToJavascriptSource(), true);
         }
         if ( dynavVendedor.ItemCount > 0 )
         {
            AV38vendedor = (short)(NumberUtil.Val( dynavVendedor.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV38vendedor), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38vendedor", StringUtil.LTrim( StringUtil.Str( (decimal)(AV38vendedor), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavVendedor.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV38vendedor), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVendedor_Internalname, "Values", dynavVendedor.ToJavascriptSource(), true);
         }
         if ( dynavOrdenproceso.ItemCount > 0 )
         {
            AV27OrdenProceso = dynavOrdenproceso.getValidValue(AV27OrdenProceso);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27OrdenProceso", AV27OrdenProceso);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavOrdenproceso.CurrentValue = StringUtil.RTrim( AV27OrdenProceso);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavOrdenproceso_Internalname, "Values", dynavOrdenproceso.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF1K2( ) ;
         RF1K3( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV47Pgmname = "WWOrdenProduccion";
         context.Gx_err = 0;
      }

      protected void RF1K2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 66;
         /* Execute user event: Refresh */
         E151K2 ();
         nGXsfl_66_idx = 1;
         sGXsfl_66_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_66_idx), 4, 0)), 4, "0");
         SubsflControlProps_662( ) ;
         bGXsfl_66_Refreshing = true;
         GridContainer.AddObjectProperty("GridName", "Grid");
         GridContainer.AddObjectProperty("CmpContext", "");
         GridContainer.AddObjectProperty("InMasterPage", "false");
         GridContainer.AddObjectProperty("Class", "WorkWith");
         GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
         GridContainer.PageSize = subGrid_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_662( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(5, new Object[]{ new Object[]{
                                                 AV8ClienteDsc ,
                                                 AV37vehiculoPlaca ,
                                                 AV36vehiculoChasis ,
                                                 AV26ordenID ,
                                                 AV28period ,
                                                 AV22marca ,
                                                 AV25modelo ,
                                                 AV38vendedor ,
                                                 AV27OrdenProceso ,
                                                 AV7anio ,
                                                 A57ClienteDsc ,
                                                 A68VehiculoPlaca ,
                                                 A69VehiculoChasis ,
                                                 A22OrdenID ,
                                                 A24OrdenPeriodo ,
                                                 A26OrdenMarcaID ,
                                                 A117OrdenModeloID ,
                                                 A9vendedorID ,
                                                 A133OrdenProceso ,
                                                 A25OrdenAnio ,
                                                 A115OrdenEst } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT,
                                                 TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT,
                                                 TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV8ClienteDsc = StringUtil.PadR( StringUtil.RTrim( AV8ClienteDsc), 50, "%");
            lV37vehiculoPlaca = StringUtil.Concat( StringUtil.RTrim( AV37vehiculoPlaca), "%", "");
            lV36vehiculoChasis = StringUtil.Concat( StringUtil.RTrim( AV36vehiculoChasis), "%", "");
            /* Using cursor H001K7 */
            pr_default.execute(5, new Object[] {lV8ClienteDsc, lV37vehiculoPlaca, lV36vehiculoChasis, AV26ordenID, AV28period, AV22marca, AV25modelo, AV38vendedor, AV27OrdenProceso, AV7anio, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_66_idx = 1;
            sGXsfl_66_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_66_idx), 4, 0)), 4, "0");
            SubsflControlProps_662( ) ;
            while ( ( (pr_default.getStatus(5) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A8VehiculoID = H001K7_A8VehiculoID[0];
               A17tipOrdID = H001K7_A17tipOrdID[0];
               A115OrdenEst = H001K7_A115OrdenEst[0];
               n115OrdenEst = H001K7_n115OrdenEst[0];
               A1EmpID = H001K7_A1EmpID[0];
               A9vendedorID = H001K7_A9vendedorID[0];
               A117OrdenModeloID = H001K7_A117OrdenModeloID[0];
               A26OrdenMarcaID = H001K7_A26OrdenMarcaID[0];
               A10protID = H001K7_A10protID[0];
               A133OrdenProceso = H001K7_A133OrdenProceso[0];
               n133OrdenProceso = H001K7_n133OrdenProceso[0];
               A121VendedorSiglas = H001K7_A121VendedorSiglas[0];
               n121VendedorSiglas = H001K7_n121VendedorSiglas[0];
               A104tipOrdDsc = H001K7_A104tipOrdDsc[0];
               n104tipOrdDsc = H001K7_n104tipOrdDsc[0];
               A69VehiculoChasis = H001K7_A69VehiculoChasis[0];
               n69VehiculoChasis = H001K7_n69VehiculoChasis[0];
               A68VehiculoPlaca = H001K7_A68VehiculoPlaca[0];
               n68VehiculoPlaca = H001K7_n68VehiculoPlaca[0];
               A22OrdenID = H001K7_A22OrdenID[0];
               A57ClienteDsc = H001K7_A57ClienteDsc[0];
               n57ClienteDsc = H001K7_n57ClienteDsc[0];
               A106facturaNro = H001K7_A106facturaNro[0];
               n106facturaNro = H001K7_n106facturaNro[0];
               A119OrdenFch = H001K7_A119OrdenFch[0];
               n119OrdenFch = H001K7_n119OrdenFch[0];
               A24OrdenPeriodo = H001K7_A24OrdenPeriodo[0];
               A25OrdenAnio = H001K7_A25OrdenAnio[0];
               A5ClienteID = H001K7_A5ClienteID[0];
               A69VehiculoChasis = H001K7_A69VehiculoChasis[0];
               n69VehiculoChasis = H001K7_n69VehiculoChasis[0];
               A68VehiculoPlaca = H001K7_A68VehiculoPlaca[0];
               n68VehiculoPlaca = H001K7_n68VehiculoPlaca[0];
               A104tipOrdDsc = H001K7_A104tipOrdDsc[0];
               n104tipOrdDsc = H001K7_n104tipOrdDsc[0];
               A121VendedorSiglas = H001K7_A121VendedorSiglas[0];
               n121VendedorSiglas = H001K7_n121VendedorSiglas[0];
               A57ClienteDsc = H001K7_A57ClienteDsc[0];
               n57ClienteDsc = H001K7_n57ClienteDsc[0];
               E161K2 ();
               pr_default.readNext(5);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(5) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(5);
            wbEnd = 66;
            WB1K0( ) ;
         }
         bGXsfl_66_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes1K2( )
      {
         GxWebStd.gx_hidden_field( context, "vAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6ageID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV6ageID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vUSERCOD", StringUtil.RTrim( AV34UserCod));
         GxWebStd.gx_hidden_field( context, "gxhash_vUSERCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV34UserCod, "")), context));
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13empID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV13empID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "CLIENTEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A5ClienteID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_CLIENTEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A5ClienteID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_ORDENPERIODO"+"_"+sGXsfl_66_idx, GetSecureSignedToken( sGXsfl_66_idx, context.localUtil.Format( (decimal)(A24OrdenPeriodo), "Z9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_ORDENID"+"_"+sGXsfl_66_idx, GetSecureSignedToken( sGXsfl_66_idx, context.localUtil.Format( (decimal)(A22OrdenID), "ZZZ9"), context));
      }

      protected void RF1K3( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridinacContainer.ClearRows();
         }
         wbStart = 90;
         nGXsfl_90_idx = 1;
         sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx), 4, 0)), 4, "0");
         SubsflControlProps_903( ) ;
         bGXsfl_90_Refreshing = true;
         GridinacContainer.AddObjectProperty("GridName", "Gridinac");
         GridinacContainer.AddObjectProperty("CmpContext", "");
         GridinacContainer.AddObjectProperty("InMasterPage", "false");
         GridinacContainer.AddObjectProperty("Class", "WorkWith");
         GridinacContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         GridinacContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         GridinacContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridinac_Backcolorstyle), 1, 0, ".", "")));
         GridinacContainer.PageSize = subGridinac_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_903( ) ;
            GXPagingFrom3 = (int)(((10==0) ? 0 : GRIDINAC_nFirstRecordOnPage));
            GXPagingTo3 = ((10==0) ? 10000 : subGridinac_Recordsperpage( )+1);
            pr_default.dynParam(6, new Object[]{ new Object[]{
                                                 AV8ClienteDsc ,
                                                 AV37vehiculoPlaca ,
                                                 AV36vehiculoChasis ,
                                                 AV26ordenID ,
                                                 AV28period ,
                                                 AV22marca ,
                                                 AV25modelo ,
                                                 AV38vendedor ,
                                                 AV27OrdenProceso ,
                                                 AV7anio ,
                                                 A57ClienteDsc ,
                                                 A68VehiculoPlaca ,
                                                 A69VehiculoChasis ,
                                                 A22OrdenID ,
                                                 A24OrdenPeriodo ,
                                                 A26OrdenMarcaID ,
                                                 A117OrdenModeloID ,
                                                 A9vendedorID ,
                                                 A133OrdenProceso ,
                                                 A25OrdenAnio ,
                                                 A115OrdenEst } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT,
                                                 TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT,
                                                 TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV8ClienteDsc = StringUtil.PadR( StringUtil.RTrim( AV8ClienteDsc), 50, "%");
            lV37vehiculoPlaca = StringUtil.Concat( StringUtil.RTrim( AV37vehiculoPlaca), "%", "");
            lV36vehiculoChasis = StringUtil.Concat( StringUtil.RTrim( AV36vehiculoChasis), "%", "");
            /* Using cursor H001K8 */
            pr_default.execute(6, new Object[] {lV8ClienteDsc, lV37vehiculoPlaca, lV36vehiculoChasis, AV26ordenID, AV28period, AV22marca, AV25modelo, AV38vendedor, AV27OrdenProceso, AV7anio, GXPagingFrom3, GXPagingTo3, GXPagingTo3});
            nGXsfl_90_idx = 1;
            sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx), 4, 0)), 4, "0");
            SubsflControlProps_903( ) ;
            while ( ( (pr_default.getStatus(6) != 101) ) && ( ( ( 10 == 0 ) || ( GRIDINAC_nCurrentRecord < subGridinac_Recordsperpage( ) ) ) ) )
            {
               A8VehiculoID = H001K8_A8VehiculoID[0];
               A17tipOrdID = H001K8_A17tipOrdID[0];
               A115OrdenEst = H001K8_A115OrdenEst[0];
               n115OrdenEst = H001K8_n115OrdenEst[0];
               A9vendedorID = H001K8_A9vendedorID[0];
               A117OrdenModeloID = H001K8_A117OrdenModeloID[0];
               A26OrdenMarcaID = H001K8_A26OrdenMarcaID[0];
               A5ClienteID = H001K8_A5ClienteID[0];
               A1EmpID = H001K8_A1EmpID[0];
               A10protID = H001K8_A10protID[0];
               A133OrdenProceso = H001K8_A133OrdenProceso[0];
               n133OrdenProceso = H001K8_n133OrdenProceso[0];
               A121VendedorSiglas = H001K8_A121VendedorSiglas[0];
               n121VendedorSiglas = H001K8_n121VendedorSiglas[0];
               A104tipOrdDsc = H001K8_A104tipOrdDsc[0];
               n104tipOrdDsc = H001K8_n104tipOrdDsc[0];
               A69VehiculoChasis = H001K8_A69VehiculoChasis[0];
               n69VehiculoChasis = H001K8_n69VehiculoChasis[0];
               A68VehiculoPlaca = H001K8_A68VehiculoPlaca[0];
               n68VehiculoPlaca = H001K8_n68VehiculoPlaca[0];
               A22OrdenID = H001K8_A22OrdenID[0];
               A57ClienteDsc = H001K8_A57ClienteDsc[0];
               n57ClienteDsc = H001K8_n57ClienteDsc[0];
               A106facturaNro = H001K8_A106facturaNro[0];
               n106facturaNro = H001K8_n106facturaNro[0];
               A119OrdenFch = H001K8_A119OrdenFch[0];
               n119OrdenFch = H001K8_n119OrdenFch[0];
               A24OrdenPeriodo = H001K8_A24OrdenPeriodo[0];
               A25OrdenAnio = H001K8_A25OrdenAnio[0];
               A57ClienteDsc = H001K8_A57ClienteDsc[0];
               n57ClienteDsc = H001K8_n57ClienteDsc[0];
               A69VehiculoChasis = H001K8_A69VehiculoChasis[0];
               n69VehiculoChasis = H001K8_n69VehiculoChasis[0];
               A68VehiculoPlaca = H001K8_A68VehiculoPlaca[0];
               n68VehiculoPlaca = H001K8_n68VehiculoPlaca[0];
               A121VendedorSiglas = H001K8_A121VendedorSiglas[0];
               n121VendedorSiglas = H001K8_n121VendedorSiglas[0];
               A104tipOrdDsc = H001K8_A104tipOrdDsc[0];
               n104tipOrdDsc = H001K8_n104tipOrdDsc[0];
               GXAPROTID_html1K3( AV13empID) ;
               E181K3 ();
               pr_default.readNext(6);
            }
            GRIDINAC_nEOF = (short)(((pr_default.getStatus(6) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRIDINAC_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDINAC_nEOF), 1, 0, ".", "")));
            pr_default.close(6);
            wbEnd = 90;
            WB1K0( ) ;
         }
         bGXsfl_90_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes1K3( )
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
         pr_default.dynParam(7, new Object[]{ new Object[]{
                                              AV8ClienteDsc ,
                                              AV37vehiculoPlaca ,
                                              AV36vehiculoChasis ,
                                              AV26ordenID ,
                                              AV28period ,
                                              AV22marca ,
                                              AV25modelo ,
                                              AV38vendedor ,
                                              AV27OrdenProceso ,
                                              AV7anio ,
                                              A57ClienteDsc ,
                                              A68VehiculoPlaca ,
                                              A69VehiculoChasis ,
                                              A22OrdenID ,
                                              A24OrdenPeriodo ,
                                              A26OrdenMarcaID ,
                                              A117OrdenModeloID ,
                                              A9vendedorID ,
                                              A133OrdenProceso ,
                                              A25OrdenAnio ,
                                              A115OrdenEst } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT,
                                              TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV8ClienteDsc = StringUtil.PadR( StringUtil.RTrim( AV8ClienteDsc), 50, "%");
         lV37vehiculoPlaca = StringUtil.Concat( StringUtil.RTrim( AV37vehiculoPlaca), "%", "");
         lV36vehiculoChasis = StringUtil.Concat( StringUtil.RTrim( AV36vehiculoChasis), "%", "");
         /* Using cursor H001K9 */
         pr_default.execute(7, new Object[] {lV8ClienteDsc, lV37vehiculoPlaca, lV36vehiculoChasis, AV26ordenID, AV28period, AV22marca, AV25modelo, AV38vendedor, AV27OrdenProceso, AV7anio});
         GRID_nRecordCount = H001K9_AGRID_nRecordCount[0];
         pr_default.close(7);
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
            gxgrGrid_refresh( subGrid_Rows, AV7anio, AV28period, AV26ordenID, AV8ClienteDsc, AV37vehiculoPlaca, AV36vehiculoChasis, AV22marca, AV25modelo, AV38vendedor, AV27OrdenProceso, AV47Pgmname, AV12emails, AV33Update, AV10Delete, AV11display, AV6ageID, AV34UserCod, AV13empID, A5ClienteID) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV7anio, AV28period, AV26ordenID, AV8ClienteDsc, AV37vehiculoPlaca, AV36vehiculoChasis, AV22marca, AV25modelo, AV38vendedor, AV27OrdenProceso, AV47Pgmname, AV12emails, AV33Update, AV10Delete, AV11display, AV6ageID, AV34UserCod, AV13empID, A5ClienteID) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV7anio, AV28period, AV26ordenID, AV8ClienteDsc, AV37vehiculoPlaca, AV36vehiculoChasis, AV22marca, AV25modelo, AV38vendedor, AV27OrdenProceso, AV47Pgmname, AV12emails, AV33Update, AV10Delete, AV11display, AV6ageID, AV34UserCod, AV13empID, A5ClienteID) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV7anio, AV28period, AV26ordenID, AV8ClienteDsc, AV37vehiculoPlaca, AV36vehiculoChasis, AV22marca, AV25modelo, AV38vendedor, AV27OrdenProceso, AV47Pgmname, AV12emails, AV33Update, AV10Delete, AV11display, AV6ageID, AV34UserCod, AV13empID, A5ClienteID) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV7anio, AV28period, AV26ordenID, AV8ClienteDsc, AV37vehiculoPlaca, AV36vehiculoChasis, AV22marca, AV25modelo, AV38vendedor, AV27OrdenProceso, AV47Pgmname, AV12emails, AV33Update, AV10Delete, AV11display, AV6ageID, AV34UserCod, AV13empID, A5ClienteID) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected int subGridinac_Pagecount( )
      {
         GRIDINAC_nRecordCount = subGridinac_Recordcount( );
         if ( ((int)((GRIDINAC_nRecordCount) % (subGridinac_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRIDINAC_nRecordCount/ (decimal)(subGridinac_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRIDINAC_nRecordCount/ (decimal)(subGridinac_Recordsperpage( ))))+1) ;
      }

      protected int subGridinac_Recordcount( )
      {
         pr_default.dynParam(8, new Object[]{ new Object[]{
                                              AV8ClienteDsc ,
                                              AV37vehiculoPlaca ,
                                              AV36vehiculoChasis ,
                                              AV26ordenID ,
                                              AV28period ,
                                              AV22marca ,
                                              AV25modelo ,
                                              AV38vendedor ,
                                              AV27OrdenProceso ,
                                              AV7anio ,
                                              A57ClienteDsc ,
                                              A68VehiculoPlaca ,
                                              A69VehiculoChasis ,
                                              A22OrdenID ,
                                              A24OrdenPeriodo ,
                                              A26OrdenMarcaID ,
                                              A117OrdenModeloID ,
                                              A9vendedorID ,
                                              A133OrdenProceso ,
                                              A25OrdenAnio ,
                                              A115OrdenEst } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT,
                                              TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV8ClienteDsc = StringUtil.PadR( StringUtil.RTrim( AV8ClienteDsc), 50, "%");
         lV37vehiculoPlaca = StringUtil.Concat( StringUtil.RTrim( AV37vehiculoPlaca), "%", "");
         lV36vehiculoChasis = StringUtil.Concat( StringUtil.RTrim( AV36vehiculoChasis), "%", "");
         /* Using cursor H001K10 */
         pr_default.execute(8, new Object[] {lV8ClienteDsc, lV37vehiculoPlaca, lV36vehiculoChasis, AV26ordenID, AV28period, AV22marca, AV25modelo, AV38vendedor, AV27OrdenProceso, AV7anio});
         GRIDINAC_nRecordCount = H001K10_AGRIDINAC_nRecordCount[0];
         pr_default.close(8);
         return (int)(GRIDINAC_nRecordCount) ;
      }

      protected int subGridinac_Recordsperpage( )
      {
         return (int)(10*1) ;
      }

      protected int subGridinac_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRIDINAC_nFirstRecordOnPage/ (decimal)(subGridinac_Recordsperpage( ))))+1) ;
      }

      protected short subgridinac_firstpage( )
      {
         GRIDINAC_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRIDINAC_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDINAC_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGridinac_refresh( subGridinac_Rows, AV7anio, AV28period, AV26ordenID, AV8ClienteDsc, AV37vehiculoPlaca, AV36vehiculoChasis, AV22marca, AV25modelo, AV38vendedor, AV27OrdenProceso, AV47Pgmname, AV12emails, AV33Update, AV10Delete, AV11display, AV6ageID, AV34UserCod, AV13empID, A5ClienteID) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgridinac_nextpage( )
      {
         GRIDINAC_nRecordCount = subGridinac_Recordcount( );
         if ( ( GRIDINAC_nRecordCount >= subGridinac_Recordsperpage( ) ) && ( GRIDINAC_nEOF == 0 ) )
         {
            GRIDINAC_nFirstRecordOnPage = (long)(GRIDINAC_nFirstRecordOnPage+subGridinac_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRIDINAC_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDINAC_nFirstRecordOnPage), 15, 0, ".", "")));
         GridinacContainer.AddObjectProperty("GRIDINAC_nFirstRecordOnPage", GRIDINAC_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGridinac_refresh( subGridinac_Rows, AV7anio, AV28period, AV26ordenID, AV8ClienteDsc, AV37vehiculoPlaca, AV36vehiculoChasis, AV22marca, AV25modelo, AV38vendedor, AV27OrdenProceso, AV47Pgmname, AV12emails, AV33Update, AV10Delete, AV11display, AV6ageID, AV34UserCod, AV13empID, A5ClienteID) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRIDINAC_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgridinac_previouspage( )
      {
         if ( GRIDINAC_nFirstRecordOnPage >= subGridinac_Recordsperpage( ) )
         {
            GRIDINAC_nFirstRecordOnPage = (long)(GRIDINAC_nFirstRecordOnPage-subGridinac_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRIDINAC_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDINAC_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGridinac_refresh( subGridinac_Rows, AV7anio, AV28period, AV26ordenID, AV8ClienteDsc, AV37vehiculoPlaca, AV36vehiculoChasis, AV22marca, AV25modelo, AV38vendedor, AV27OrdenProceso, AV47Pgmname, AV12emails, AV33Update, AV10Delete, AV11display, AV6ageID, AV34UserCod, AV13empID, A5ClienteID) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgridinac_lastpage( )
      {
         GRIDINAC_nRecordCount = subGridinac_Recordcount( );
         if ( GRIDINAC_nRecordCount > subGridinac_Recordsperpage( ) )
         {
            if ( ((int)((GRIDINAC_nRecordCount) % (subGridinac_Recordsperpage( )))) == 0 )
            {
               GRIDINAC_nFirstRecordOnPage = (long)(GRIDINAC_nRecordCount-subGridinac_Recordsperpage( ));
            }
            else
            {
               GRIDINAC_nFirstRecordOnPage = (long)(GRIDINAC_nRecordCount-((int)((GRIDINAC_nRecordCount) % (subGridinac_Recordsperpage( )))));
            }
         }
         else
         {
            GRIDINAC_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRIDINAC_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDINAC_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGridinac_refresh( subGridinac_Rows, AV7anio, AV28period, AV26ordenID, AV8ClienteDsc, AV37vehiculoPlaca, AV36vehiculoChasis, AV22marca, AV25modelo, AV38vendedor, AV27OrdenProceso, AV47Pgmname, AV12emails, AV33Update, AV10Delete, AV11display, AV6ageID, AV34UserCod, AV13empID, A5ClienteID) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgridinac_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRIDINAC_nFirstRecordOnPage = (long)(subGridinac_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRIDINAC_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRIDINAC_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDINAC_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGridinac_refresh( subGridinac_Rows, AV7anio, AV28period, AV26ordenID, AV8ClienteDsc, AV37vehiculoPlaca, AV36vehiculoChasis, AV22marca, AV25modelo, AV38vendedor, AV27OrdenProceso, AV47Pgmname, AV12emails, AV33Update, AV10Delete, AV11display, AV6ageID, AV34UserCod, AV13empID, A5ClienteID) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP1K0( )
      {
         /* Before Start, stand alone formulas. */
         AV47Pgmname = "WWOrdenProduccion";
         context.Gx_err = 0;
         GXVvMARCA_html1K2( ) ;
         GXVvORDENPROCESO_html1K2( ) ;
         GXVvMODELO_html1K2( AV13empID, AV22marca) ;
         GXVvVENDEDOR_html1K2( AV13empID) ;
         GXAPROTID_html1K3( AV13empID) ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E141K2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            cmbavAnio.Name = cmbavAnio_Internalname;
            cmbavAnio.CurrentValue = cgiGet( cmbavAnio_Internalname);
            AV7anio = (short)(NumberUtil.Val( cgiGet( cmbavAnio_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7anio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7anio), 4, 0)));
            cmbavPeriod.Name = cmbavPeriod_Internalname;
            cmbavPeriod.CurrentValue = cgiGet( cmbavPeriod_Internalname);
            AV28period = (short)(NumberUtil.Val( cgiGet( cmbavPeriod_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28period", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28period), 2, 0)));
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrdenid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrdenid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDENID");
               GX_FocusControl = edtavOrdenid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV26ordenID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26ordenID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26ordenID), 4, 0)));
            }
            else
            {
               AV26ordenID = (short)(context.localUtil.CToN( cgiGet( edtavOrdenid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26ordenID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26ordenID), 4, 0)));
            }
            AV8ClienteDsc = cgiGet( edtavClientedsc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ClienteDsc", AV8ClienteDsc);
            AV37vehiculoPlaca = cgiGet( edtavVehiculoplaca_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37vehiculoPlaca", AV37vehiculoPlaca);
            AV36vehiculoChasis = cgiGet( edtavVehiculochasis_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36vehiculoChasis", AV36vehiculoChasis);
            dynavMarca.Name = dynavMarca_Internalname;
            dynavMarca.CurrentValue = cgiGet( dynavMarca_Internalname);
            AV22marca = (short)(NumberUtil.Val( cgiGet( dynavMarca_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22marca", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22marca), 4, 0)));
            dynavModelo.Name = dynavModelo_Internalname;
            dynavModelo.CurrentValue = cgiGet( dynavModelo_Internalname);
            AV25modelo = (short)(NumberUtil.Val( cgiGet( dynavModelo_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25modelo", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25modelo), 4, 0)));
            dynavVendedor.Name = dynavVendedor_Internalname;
            dynavVendedor.CurrentValue = cgiGet( dynavVendedor_Internalname);
            AV38vendedor = (short)(NumberUtil.Val( cgiGet( dynavVendedor_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38vendedor", StringUtil.LTrim( StringUtil.Str( (decimal)(AV38vendedor), 4, 0)));
            dynavOrdenproceso.Name = dynavOrdenproceso_Internalname;
            dynavOrdenproceso.CurrentValue = cgiGet( dynavOrdenproceso_Internalname);
            AV27OrdenProceso = cgiGet( dynavOrdenproceso_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27OrdenProceso", AV27OrdenProceso);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavYear_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavYear_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vYEAR");
               GX_FocusControl = edtavYear_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV39year = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39year", StringUtil.LTrim( StringUtil.Str( (decimal)(AV39year), 4, 0)));
            }
            else
            {
               AV39year = (short)(context.localUtil.CToN( cgiGet( edtavYear_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39year", StringUtil.LTrim( StringUtil.Str( (decimal)(AV39year), 4, 0)));
            }
            /* Read saved values. */
            nRC_GXsfl_66 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_66"), ",", "."));
            nRC_GXsfl_90 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_90"), ",", "."));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID_nFirstRecordOnPage"), ",", "."));
            GRIDINAC_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRIDINAC_nFirstRecordOnPage"), ",", "."));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID_nEOF"), ",", "."));
            GRIDINAC_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRIDINAC_nEOF"), ",", "."));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ",", "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Tabgridop_Class = cgiGet( "TABGRIDOP_Class");
            Tabgridop_Pagecount = (int)(context.localUtil.CToN( cgiGet( "TABGRIDOP_Pagecount"), ",", "."));
            Tabgridop_Historymanagement = StringUtil.StrToBool( cgiGet( "TABGRIDOP_Historymanagement"));
            /* Read subfile selected row values. */
            nGXsfl_66_idx = (short)(context.localUtil.CToN( cgiGet( subGrid_Internalname+"_ROW"), ",", "."));
            sGXsfl_66_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_66_idx), 4, 0)), 4, "0");
            SubsflControlProps_662( ) ;
            if ( nGXsfl_66_idx > 0 )
            {
               A25OrdenAnio = (short)(context.localUtil.CToN( cgiGet( edtOrdenAnio_Internalname), ",", "."));
               A24OrdenPeriodo = (short)(context.localUtil.CToN( cgiGet( edtOrdenPeriodo_Internalname), ",", "."));
               A119OrdenFch = context.localUtil.CToD( cgiGet( edtOrdenFch_Internalname), 2);
               n119OrdenFch = false;
               A106facturaNro = (int)(context.localUtil.CToN( cgiGet( edtfacturaNro_Internalname), ",", "."));
               n106facturaNro = false;
               A57ClienteDsc = cgiGet( edtClienteDsc_Internalname);
               n57ClienteDsc = false;
               A22OrdenID = (short)(context.localUtil.CToN( cgiGet( edtOrdenID_Internalname), ",", "."));
               A68VehiculoPlaca = cgiGet( edtVehiculoPlaca_Internalname);
               n68VehiculoPlaca = false;
               A69VehiculoChasis = cgiGet( edtVehiculoChasis_Internalname);
               n69VehiculoChasis = false;
               A104tipOrdDsc = StringUtil.Upper( cgiGet( edttipOrdDsc_Internalname));
               n104tipOrdDsc = false;
               A121VendedorSiglas = cgiGet( edtVendedorSiglas_Internalname);
               n121VendedorSiglas = false;
               dynOrdenProceso.Name = dynOrdenProceso_Internalname;
               dynOrdenProceso.CurrentValue = cgiGet( dynOrdenProceso_Internalname);
               A133OrdenProceso = cgiGet( dynOrdenProceso_Internalname);
               n133OrdenProceso = false;
               dynprotID.Name = dynprotID_Internalname;
               dynprotID.CurrentValue = cgiGet( dynprotID_Internalname);
               A10protID = (short)(NumberUtil.Val( cgiGet( dynprotID_Internalname), "."));
               AV33Update = cgiGet( edtavUpdate_Internalname);
               AV12emails = cgiGet( edtavEmails_Internalname);
               AV11display = cgiGet( edtavDisplay_Internalname);
               AV10Delete = cgiGet( edtavDelete_Internalname);
            }
            nGXsfl_90_idx = (short)(context.localUtil.CToN( cgiGet( subGridinac_Internalname+"_ROW"), ",", "."));
            sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx), 4, 0)), 4, "0");
            SubsflControlProps_903( ) ;
            if ( nGXsfl_90_idx > 0 )
            {
               A25OrdenAnio = (short)(context.localUtil.CToN( cgiGet( edtOrdenAnio_Internalname), ",", "."));
               A24OrdenPeriodo = (short)(context.localUtil.CToN( cgiGet( edtOrdenPeriodo_Internalname), ",", "."));
               A119OrdenFch = context.localUtil.CToD( cgiGet( edtOrdenFch_Internalname), 2);
               n119OrdenFch = false;
               A106facturaNro = (int)(context.localUtil.CToN( cgiGet( edtfacturaNro_Internalname), ",", "."));
               n106facturaNro = false;
               A57ClienteDsc = cgiGet( edtClienteDsc_Internalname);
               n57ClienteDsc = false;
               A22OrdenID = (short)(context.localUtil.CToN( cgiGet( edtOrdenID_Internalname), ",", "."));
               A68VehiculoPlaca = cgiGet( edtVehiculoPlaca_Internalname);
               n68VehiculoPlaca = false;
               A69VehiculoChasis = cgiGet( edtVehiculoChasis_Internalname);
               n69VehiculoChasis = false;
               A104tipOrdDsc = StringUtil.Upper( cgiGet( edttipOrdDsc_Internalname));
               n104tipOrdDsc = false;
               A121VendedorSiglas = cgiGet( edtVendedorSiglas_Internalname);
               n121VendedorSiglas = false;
               dynOrdenProceso.Name = dynOrdenProceso_Internalname;
               dynOrdenProceso.CurrentValue = cgiGet( dynOrdenProceso_Internalname);
               A133OrdenProceso = cgiGet( dynOrdenProceso_Internalname);
               n133OrdenProceso = false;
               dynprotID.Name = dynprotID_Internalname;
               dynprotID.CurrentValue = cgiGet( dynprotID_Internalname);
               A10protID = (short)(NumberUtil.Val( cgiGet( dynprotID_Internalname), "."));
               AV33Update = cgiGet( edtavUpdate_Internalname);
               AV12emails = cgiGet( edtavEmails_Internalname);
               AV11display = cgiGet( edtavDisplay_Internalname);
               AV10Delete = cgiGet( edtavDelete_Internalname);
            }
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vANIO"), ",", ".") != Convert.ToDecimal( AV7anio )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vPERIOD"), ",", ".") != Convert.ToDecimal( AV28period )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDENID"), ",", ".") != Convert.ToDecimal( AV26ordenID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCLIENTEDSC"), AV8ClienteDsc) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vVEHICULOPLACA"), AV37vehiculoPlaca) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vVEHICULOCHASIS"), AV36vehiculoChasis) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vMARCA"), ",", ".") != Convert.ToDecimal( AV22marca )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vMODELO"), ",", ".") != Convert.ToDecimal( AV25modelo )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vVENDEDOR"), ",", ".") != Convert.ToDecimal( AV38vendedor )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vORDENPROCESO"), AV27OrdenProceso) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vANIO"), ",", ".") != Convert.ToDecimal( AV7anio )) )
            {
               GRIDINAC_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vPERIOD"), ",", ".") != Convert.ToDecimal( AV28period )) )
            {
               GRIDINAC_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDENID"), ",", ".") != Convert.ToDecimal( AV26ordenID )) )
            {
               GRIDINAC_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCLIENTEDSC"), AV8ClienteDsc) != 0 )
            {
               GRIDINAC_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vVEHICULOPLACA"), AV37vehiculoPlaca) != 0 )
            {
               GRIDINAC_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vVEHICULOCHASIS"), AV36vehiculoChasis) != 0 )
            {
               GRIDINAC_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vMARCA"), ",", ".") != Convert.ToDecimal( AV22marca )) )
            {
               GRIDINAC_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vMODELO"), ",", ".") != Convert.ToDecimal( AV25modelo )) )
            {
               GRIDINAC_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vVENDEDOR"), ",", ".") != Convert.ToDecimal( AV38vendedor )) )
            {
               GRIDINAC_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vORDENPROCESO"), AV27OrdenProceso) != 0 )
            {
               GRIDINAC_nFirstRecordOnPage = 0;
            }
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E141K2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E141K2( )
      {
         /* Start Routine */
         AV12emails = context.GetImagePath( "/logos/mail.png", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEmails_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV12emails)) ? AV46Emails_GXI : context.convertURL( context.PathToRelativeUrl( AV12emails))), !bGXsfl_66_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEmails_Internalname, "SrcSet", context.GetImageSrcSet( AV12emails), true);
         AV46Emails_GXI = GXDbFile.PathToUrl( "/logos/mail.png");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEmails_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV12emails)) ? AV46Emails_GXI : context.convertURL( context.PathToRelativeUrl( AV12emails))), !bGXsfl_66_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEmails_Internalname, "SrcSet", context.GetImageSrcSet( AV12emails), true);
         edtavEmails_Tooltiptext = "Enviar Correo";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEmails_Internalname, "Tooltiptext", edtavEmails_Tooltiptext, !bGXsfl_66_Refreshing);
         /* Execute user subroutine: 'LOADANIO' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         divTbbusavanced_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTbbusavanced_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divTbbusavanced_Visible), 5, 0)), true);
         if ( ! new isauthorized(context).executeUdp(  AV47Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV47Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         subGrid_Rows = 10;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GXt_char1 = AV29rolUser;
         new obtrolusuario(context ).execute(  AV34UserCod, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34UserCod", AV34UserCod);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSERCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV34UserCod, "")), context));
         AV29rolUser = GXt_char1;
         if ( StringUtil.StrCmp(AV29rolUser, "ADM") == 0 )
         {
            AV33Update = context.GetImagePath( "/logos/edit_file.png", "", context.GetTheme( ));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV33Update)) ? AV48Update_GXI : context.convertURL( context.PathToRelativeUrl( AV33Update))), !bGXsfl_66_Refreshing);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV33Update), true);
            AV48Update_GXI = GXDbFile.PathToUrl( "/logos/edit_file.png");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV33Update)) ? AV48Update_GXI : context.convertURL( context.PathToRelativeUrl( AV33Update))), !bGXsfl_66_Refreshing);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV33Update), true);
            edtavUpdate_Tooltiptext = "Modificar";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext, !bGXsfl_66_Refreshing);
         }
         else
         {
            edtavUpdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_66_Refreshing);
         }
         AV10Delete = context.GetImagePath( "/logos/trash.png", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV10Delete)) ? AV49Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV10Delete))), !bGXsfl_66_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV10Delete), true);
         AV49Delete_GXI = GXDbFile.PathToUrl( "/logos/trash.png");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV10Delete)) ? AV49Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV10Delete))), !bGXsfl_66_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV10Delete), true);
         edtavDelete_Tooltiptext = "Eliminar";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext, !bGXsfl_66_Refreshing);
         AV11display = context.GetImagePath( "/logos/view.png", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV11display)) ? AV50Display_GXI : context.convertURL( context.PathToRelativeUrl( AV11display))), !bGXsfl_66_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV11display), true);
         AV50Display_GXI = GXDbFile.PathToUrl( "/logos/view.png");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV11display)) ? AV50Display_GXI : context.convertURL( context.PathToRelativeUrl( AV11display))), !bGXsfl_66_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV11display), true);
         edtavDisplay_Tooltiptext = "Visualizar";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Tooltiptext", edtavDisplay_Tooltiptext, !bGXsfl_66_Refreshing);
         Form.Caption = "Orden Produccion";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         /* Execute user subroutine: 'PREPARETRANSACTION' */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'LOADGRIDSTATE' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtavYear_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavYear_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavYear_Visible), 5, 0)), true);
      }

      protected void E151K2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         /* Execute user subroutine: 'SAVEGRIDSTATE' */
         S142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /*  Sending Event outputs  */
      }

      private void E161K2( )
      {
         /* Grid_Load Routine */
         edtavUpdate_Link = formatLink("ordenproduccion.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A1EmpID) + "," + UrlEncode("" +AV6ageID) + "," + UrlEncode("" +A5ClienteID) + "," + UrlEncode("" +A24OrdenPeriodo) + "," + UrlEncode("" +A25OrdenAnio) + "," + UrlEncode("" +A22OrdenID) + "," + UrlEncode(StringUtil.RTrim(AV34UserCod));
         edtavDelete_Link = formatLink("ordenproduccion.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A1EmpID) + "," + UrlEncode("" +AV6ageID) + "," + UrlEncode("" +A5ClienteID) + "," + UrlEncode("" +A24OrdenPeriodo) + "," + UrlEncode("" +A25OrdenAnio) + "," + UrlEncode("" +A22OrdenID) + "," + UrlEncode(StringUtil.RTrim(AV34UserCod));
         edtavDisplay_Link = formatLink("ordenproduccion.aspx") + "?" + UrlEncode(StringUtil.RTrim("DSP")) + "," + UrlEncode("" +A1EmpID) + "," + UrlEncode("" +AV6ageID) + "," + UrlEncode("" +A5ClienteID) + "," + UrlEncode("" +A24OrdenPeriodo) + "," + UrlEncode("" +A25OrdenAnio) + "," + UrlEncode("" +A22OrdenID) + "," + UrlEncode(StringUtil.RTrim(AV34UserCod));
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 66;
         }
         sendrow_662( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_66_Refreshing )
         {
            context.DoAjaxLoad(66, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void E121K2( )
      {
         /* 'DoInsert' Routine */
         if ( AV7anio > 0 )
         {
            CallWebObject(formatLink("ordenproduccion.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +AV13empID) + "," + UrlEncode("" +AV6ageID) + "," + UrlEncode("" +0) + "," + UrlEncode("" +0) + "," + UrlEncode("" +AV7anio) + "," + UrlEncode("" +0) + "," + UrlEncode(StringUtil.RTrim(AV34UserCod)));
            context.wjLocDisableFrm = 1;
         }
         else
         {
            GX_msglist.addItem("Seleccione un año..");
            GX_FocusControl = cmbavAnio_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            context.DoAjaxSetFocus(GX_FocusControl);
         }
      }

      protected void S132( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV20HTTPRequest.Method, "GET") == 0 )
         {
            AV18GridState.FromXml(AV30Session.Get(AV47Pgmname+"GridState"), null, "GridState", "KBCalpesa22");
            if ( AV18GridState.gxTpr_Filtervalues.Count >= 1 )
            {
               AV8ClienteDsc = ((SdtGridState_FilterValue)AV18GridState.gxTpr_Filtervalues.Item(1)).gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ClienteDsc", AV8ClienteDsc);
            }
            if ( AV18GridState.gxTpr_Currentpage > 0 )
            {
               AV17GridPageCount = subGrid_Pagecount( );
               AV40GridPageCount1 = subGridinac_Pagecount( );
               if ( ( ( AV17GridPageCount > 0 ) && ( AV17GridPageCount < AV18GridState.gxTpr_Currentpage ) ) || ( ( AV40GridPageCount1 > 0 ) && ( AV40GridPageCount1 < AV18GridState.gxTpr_Currentpage ) ) )
               {
                  subgrid_gotopage( AV17GridPageCount) ;
               }
               else
               {
                  subgrid_gotopage( AV18GridState.gxTpr_Currentpage) ;
               }
            }
         }
      }

      protected void S142( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV18GridState.FromXml(AV30Session.Get(AV47Pgmname+"GridState"), null, "GridState", "KBCalpesa22");
         AV18GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         AV18GridState.gxTpr_Filtervalues.Clear();
         AV19GridStateFilterValue = new SdtGridState_FilterValue(context);
         AV19GridStateFilterValue.gxTpr_Value = AV8ClienteDsc;
         AV18GridState.gxTpr_Filtervalues.Add(AV19GridStateFilterValue, 0);
         AV30Session.Set(AV47Pgmname+"GridState", AV18GridState.ToXml(false, true, "GridState", "KBCalpesa22"));
      }

      protected void S122( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV31TrnContext = new SdtTransactionContext(context);
         AV31TrnContext.gxTpr_Callerobject = AV47Pgmname;
         AV31TrnContext.gxTpr_Callerondelete = true;
         AV31TrnContext.gxTpr_Callerurl = AV20HTTPRequest.ScriptName+"?"+AV20HTTPRequest.QueryString;
         AV31TrnContext.gxTpr_Transactionname = "OrdenProduccion";
         AV30Session.Set("TrnContext", AV31TrnContext.ToXml(false, true, "TransactionContext", "KBCalpesa22"));
      }

      protected void E131K2( )
      {
         /* Period_Click Routine */
         AV16fechaAux = DateTimeUtil.ResetTime(DateTimeUtil.ServerNow( context, pr_default));
         AV9day = 1;
         AV39year = (short)(DateTimeUtil.Year( AV16fechaAux));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39year", StringUtil.LTrim( StringUtil.Str( (decimal)(AV39year), 4, 0)));
         AV14fchDesd = context.localUtil.YMDToD( AV39year, AV28period, AV9day);
         AV15fchHast = DateTimeUtil.DateEndOfMonth( AV14fchDesd);
         AV24mensj = "fecha: " + context.localUtil.DToC( AV14fchDesd, 4, "/") + " - " + context.localUtil.DToC( AV15fchHast, 4, "/") + " :" + StringUtil.Str( (decimal)(AV39year), 4, 0);
         /*  Sending Event outputs  */
      }

      protected void S112( )
      {
         /* 'LOADANIO' Routine */
         AV41currentYear = 2021;
         AV43fin = 5;
         cmbavAnio.removeAllItems();
         cmbavAnio.addItem("0", "Seleccionar", 0);
         AV42i = 1;
         while ( AV42i <= AV43fin )
         {
            cmbavAnio.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(AV41currentYear), 4, 0)), StringUtil.Str( (decimal)(AV41currentYear), 10, 0), 0);
            AV41currentYear = (short)(AV41currentYear+1);
            AV42i = (short)(AV42i+1);
         }
         AV7anio = (short)(DateTimeUtil.Year( DateTimeUtil.ServerNow( context, pr_default)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7anio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7anio), 4, 0)));
      }

      protected void E171K2( )
      {
         /* Emails_Click Routine */
         if ( new valexistcorreo(context).executeUdp(  AV34UserCod) )
         {
            CallWebObject(formatLink("enviarorden.aspx") + "?" + UrlEncode("" +AV13empID) + "," + UrlEncode("" +A22OrdenID) + "," + UrlEncode("" +A5ClienteID) + "," + UrlEncode(StringUtil.RTrim(AV34UserCod)));
            context.wjLocDisableFrm = 1;
         }
         else
         {
            GX_msglist.addItem("Lo sentimos, usted no tiene configurado correo para enviar esta orden# "+StringUtil.Str( (decimal)(A22OrdenID), 10, 0));
         }
      }

      private void E181K3( )
      {
         /* Gridinac_Load Routine */
         edtavUpdate_Link = formatLink("ordenproduccion.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A1EmpID) + "," + UrlEncode("" +AV6ageID) + "," + UrlEncode("" +A5ClienteID) + "," + UrlEncode("" +A24OrdenPeriodo) + "," + UrlEncode("" +A25OrdenAnio) + "," + UrlEncode("" +A22OrdenID) + "," + UrlEncode(StringUtil.RTrim(AV34UserCod));
         edtavDelete_Link = formatLink("ordenproduccion.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A1EmpID) + "," + UrlEncode("" +AV6ageID) + "," + UrlEncode("" +A5ClienteID) + "," + UrlEncode("" +A24OrdenPeriodo) + "," + UrlEncode("" +A25OrdenAnio) + "," + UrlEncode("" +A22OrdenID) + "," + UrlEncode(StringUtil.RTrim(AV34UserCod));
         edtavDisplay_Link = formatLink("ordenproduccion.aspx") + "?" + UrlEncode(StringUtil.RTrim("DSP")) + "," + UrlEncode("" +A1EmpID) + "," + UrlEncode("" +AV6ageID) + "," + UrlEncode("" +A5ClienteID) + "," + UrlEncode("" +A24OrdenPeriodo) + "," + UrlEncode("" +A25OrdenAnio) + "," + UrlEncode("" +A22OrdenID) + "," + UrlEncode(StringUtil.RTrim(AV34UserCod));
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 90;
         }
         sendrow_903( ) ;
         GRIDINAC_nCurrentRecord = (long)(GRIDINAC_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_90_Refreshing )
         {
            context.DoAjaxLoad(90, GridinacRow);
         }
         /*  Sending Event outputs  */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13empID = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13empID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13empID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV13empID), "ZZZ9"), context));
         AV6ageID = Convert.ToInt16(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6ageID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6ageID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV6ageID), "ZZZ9"), context));
         AV34UserCod = (String)getParm(obj,2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34UserCod", AV34UserCod);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSERCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV34UserCod, "")), context));
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
         PA1K2( ) ;
         WS1K2( ) ;
         WE1K2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2023114119196", true);
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
            context.AddJavascriptSource("wwordenproduccion.js", "?2023114119196", false);
            context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false);
            context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false);
            context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false);
            context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false);
            context.AddJavascriptSource("Tab/TabRender.js", "", false);
         }
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_662( )
      {
         edtOrdenAnio_Internalname = "ORDENANIO_"+sGXsfl_66_idx;
         edtOrdenPeriodo_Internalname = "ORDENPERIODO_"+sGXsfl_66_idx;
         edtOrdenFch_Internalname = "ORDENFCH_"+sGXsfl_66_idx;
         edtfacturaNro_Internalname = "FACTURANRO_"+sGXsfl_66_idx;
         edtClienteDsc_Internalname = "CLIENTEDSC_"+sGXsfl_66_idx;
         edtOrdenID_Internalname = "ORDENID_"+sGXsfl_66_idx;
         edtVehiculoPlaca_Internalname = "VEHICULOPLACA_"+sGXsfl_66_idx;
         edtVehiculoChasis_Internalname = "VEHICULOCHASIS_"+sGXsfl_66_idx;
         edttipOrdDsc_Internalname = "TIPORDDSC_"+sGXsfl_66_idx;
         edtVendedorSiglas_Internalname = "VENDEDORSIGLAS_"+sGXsfl_66_idx;
         dynOrdenProceso_Internalname = "ORDENPROCESO_"+sGXsfl_66_idx;
         dynprotID_Internalname = "PROTID_"+sGXsfl_66_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_66_idx;
         edtavEmails_Internalname = "vEMAILS_"+sGXsfl_66_idx;
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_66_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_66_idx;
      }

      protected void SubsflControlProps_fel_662( )
      {
         edtOrdenAnio_Internalname = "ORDENANIO_"+sGXsfl_66_fel_idx;
         edtOrdenPeriodo_Internalname = "ORDENPERIODO_"+sGXsfl_66_fel_idx;
         edtOrdenFch_Internalname = "ORDENFCH_"+sGXsfl_66_fel_idx;
         edtfacturaNro_Internalname = "FACTURANRO_"+sGXsfl_66_fel_idx;
         edtClienteDsc_Internalname = "CLIENTEDSC_"+sGXsfl_66_fel_idx;
         edtOrdenID_Internalname = "ORDENID_"+sGXsfl_66_fel_idx;
         edtVehiculoPlaca_Internalname = "VEHICULOPLACA_"+sGXsfl_66_fel_idx;
         edtVehiculoChasis_Internalname = "VEHICULOCHASIS_"+sGXsfl_66_fel_idx;
         edttipOrdDsc_Internalname = "TIPORDDSC_"+sGXsfl_66_fel_idx;
         edtVendedorSiglas_Internalname = "VENDEDORSIGLAS_"+sGXsfl_66_fel_idx;
         dynOrdenProceso_Internalname = "ORDENPROCESO_"+sGXsfl_66_fel_idx;
         dynprotID_Internalname = "PROTID_"+sGXsfl_66_fel_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_66_fel_idx;
         edtavEmails_Internalname = "vEMAILS_"+sGXsfl_66_fel_idx;
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_66_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_66_fel_idx;
      }

      protected void sendrow_662( )
      {
         SubsflControlProps_662( ) ;
         WB1K0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_66_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_66_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_66_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenAnio_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A25OrdenAnio), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A25OrdenAnio), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenAnio_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)60,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)66,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenPeriodo_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A24OrdenPeriodo), 2, 0, ",", "")),context.localUtil.Format( (decimal)(A24OrdenPeriodo), "Z9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenPeriodo_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)60,(String)"px",(short)17,(String)"px",(short)2,(short)0,(short)0,(short)66,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenFch_Internalname,context.localUtil.Format(A119OrdenFch, "99/99/9999"),context.localUtil.Format( A119OrdenFch, "99/99/9999"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenFch_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)66,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtfacturaNro_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A106facturaNro), 8, 0, ",", "")),context.localUtil.Format( (decimal)(A106facturaNro), "ZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtfacturaNro_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)66,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClienteDsc_Internalname,StringUtil.RTrim( A57ClienteDsc),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtClienteDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)66,(short)1,(short)-1,(short)-1,(bool)true,(String)"Descripcion",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A22OrdenID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A22OrdenID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)80,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)66,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVehiculoPlaca_Internalname,(String)A68VehiculoPlaca,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtVehiculoPlaca_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)66,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVehiculoChasis_Internalname,(String)A69VehiculoChasis,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtVehiculoChasis_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)66,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edttipOrdDsc_Internalname,StringUtil.RTrim( A104tipOrdDsc),StringUtil.RTrim( context.localUtil.Format( A104tipOrdDsc, "@!")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edttipOrdDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)66,(short)1,(short)-1,(short)-1,(bool)true,(String)"nombres",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVendedorSiglas_Internalname,(String)A121VendedorSiglas,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtVendedorSiglas_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)5,(short)0,(short)0,(short)66,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( dynOrdenProceso.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "ORDENPROCESO_" + sGXsfl_66_idx;
               dynOrdenProceso.Name = GXCCtl;
               dynOrdenProceso.WebTags = "";
               dynOrdenProceso.removeAllItems();
               /* Using cursor H001K11 */
               pr_default.execute(9);
               while ( (pr_default.getStatus(9) != 101) )
               {
                  dynOrdenProceso.addItem(H001K11_A129ProcAbre[0], H001K11_A128ProcDsc[0], 0);
                  pr_default.readNext(9);
               }
               pr_default.close(9);
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)dynOrdenProceso,(String)dynOrdenProceso_Internalname,StringUtil.RTrim( A133OrdenProceso),(short)1,(String)dynOrdenProceso_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn WWOptionalColumn",(String)"",(String)"",(String)"",(bool)true});
            dynOrdenProceso.CurrentValue = StringUtil.RTrim( A133OrdenProceso);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynOrdenProceso_Internalname, "Values", (String)(dynOrdenProceso.ToJavascriptSource()), !bGXsfl_66_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( dynprotID.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "PROTID_" + sGXsfl_66_idx;
               dynprotID.Name = GXCCtl;
               dynprotID.WebTags = "";
               dynprotID.removeAllItems();
               /* Using cursor H001K12 */
               pr_default.execute(10);
               while ( (pr_default.getStatus(10) != 101) )
               {
                  dynprotID.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(H001K12_A10protID[0]), 4, 0)), H001K12_A74protDsc[0], 0);
                  pr_default.readNext(10);
               }
               pr_default.close(10);
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)dynprotID,(String)dynprotID_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(A10protID), 4, 0)),(short)1,(String)dynprotID_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn WWOptionalColumn",(String)"",(String)"",(String)"",(bool)true});
            dynprotID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A10protID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynprotID_Internalname, "Values", (String)(dynprotID.ToJavascriptSource()), !bGXsfl_66_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "";
            StyleString = "";
            AV33Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV33Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV48Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV33Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV33Update)) ? AV48Update_GXI : context.PathToRelativeUrl( AV33Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavUpdate_Visible,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV33Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavEmails_Enabled!=0)&&(edtavEmails_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 80,'',false,'',66)\"" : " ");
            ClassString = "";
            StyleString = "";
            AV12emails_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV12emails))&&String.IsNullOrEmpty(StringUtil.RTrim( AV46Emails_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV12emails)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV12emails)) ? AV46Emails_GXI : context.PathToRelativeUrl( AV12emails));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavEmails_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavEmails_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavEmails_Jsonclick,"'"+""+"'"+",false,"+"'"+"EVEMAILS.CLICK."+sGXsfl_66_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV12emails_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "";
            StyleString = "";
            AV11display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV11display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV50Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV11display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV11display)) ? AV50Display_GXI : context.PathToRelativeUrl( AV11display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV11display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "";
            StyleString = "";
            AV10Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV10Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV49Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV10Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV10Delete)) ? AV49Delete_GXI : context.PathToRelativeUrl( AV10Delete));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)edtavDelete_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV10Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            send_integrity_lvl_hashes1K2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_66_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_66_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_66_idx+1));
            sGXsfl_66_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_66_idx), 4, 0)), 4, "0");
            SubsflControlProps_662( ) ;
         }
         /* End function sendrow_662 */
      }

      protected void SubsflControlProps_903( )
      {
         edtOrdenAnio_Internalname = "ORDENANIO_"+sGXsfl_66_idx;
         edtOrdenPeriodo_Internalname = "ORDENPERIODO_"+sGXsfl_66_idx;
         edtOrdenFch_Internalname = "ORDENFCH_"+sGXsfl_66_idx;
         edtfacturaNro_Internalname = "FACTURANRO_"+sGXsfl_66_idx;
         edtClienteDsc_Internalname = "CLIENTEDSC_"+sGXsfl_66_idx;
         edtOrdenID_Internalname = "ORDENID_"+sGXsfl_66_idx;
         edtVehiculoPlaca_Internalname = "VEHICULOPLACA_"+sGXsfl_66_idx;
         edtVehiculoChasis_Internalname = "VEHICULOCHASIS_"+sGXsfl_66_idx;
         edttipOrdDsc_Internalname = "TIPORDDSC_"+sGXsfl_66_idx;
         edtVendedorSiglas_Internalname = "VENDEDORSIGLAS_"+sGXsfl_66_idx;
         dynOrdenProceso_Internalname = "ORDENPROCESO_"+sGXsfl_66_idx;
         dynprotID_Internalname = "PROTID_"+sGXsfl_66_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_66_idx;
         edtavEmails_Internalname = "vEMAILS_"+sGXsfl_66_idx;
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_66_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_66_idx;
      }

      protected void SubsflControlProps_fel_903( )
      {
         edtOrdenAnio_Internalname = "ORDENANIO_"+sGXsfl_66_idx;
         edtOrdenPeriodo_Internalname = "ORDENPERIODO_"+sGXsfl_66_idx;
         edtOrdenFch_Internalname = "ORDENFCH_"+sGXsfl_66_idx;
         edtfacturaNro_Internalname = "FACTURANRO_"+sGXsfl_66_idx;
         edtClienteDsc_Internalname = "CLIENTEDSC_"+sGXsfl_66_idx;
         edtOrdenID_Internalname = "ORDENID_"+sGXsfl_66_idx;
         edtVehiculoPlaca_Internalname = "VEHICULOPLACA_"+sGXsfl_66_idx;
         edtVehiculoChasis_Internalname = "VEHICULOCHASIS_"+sGXsfl_66_idx;
         edttipOrdDsc_Internalname = "TIPORDDSC_"+sGXsfl_66_idx;
         edtVendedorSiglas_Internalname = "VENDEDORSIGLAS_"+sGXsfl_66_idx;
         dynOrdenProceso_Internalname = "ORDENPROCESO_"+sGXsfl_66_idx;
         dynprotID_Internalname = "PROTID_"+sGXsfl_66_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_66_idx;
         edtavEmails_Internalname = "vEMAILS_"+sGXsfl_66_idx;
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_66_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_66_idx;
      }

      protected void sendrow_903( )
      {
         SubsflControlProps_903( ) ;
         WB1K0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_90_idx <= subGridinac_Recordsperpage( ) * 1 ) )
         {
            GridinacRow = GXWebRow.GetNew(context,GridinacContainer);
            if ( subGridinac_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGridinac_Backstyle = 0;
               if ( StringUtil.StrCmp(subGridinac_Class, "") != 0 )
               {
                  subGridinac_Linesclass = subGridinac_Class+"Odd";
               }
            }
            else if ( subGridinac_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGridinac_Backstyle = 0;
               subGridinac_Backcolor = subGridinac_Allbackcolor;
               if ( StringUtil.StrCmp(subGridinac_Class, "") != 0 )
               {
                  subGridinac_Linesclass = subGridinac_Class+"Uniform";
               }
            }
            else if ( subGridinac_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGridinac_Backstyle = 1;
               if ( StringUtil.StrCmp(subGridinac_Class, "") != 0 )
               {
                  subGridinac_Linesclass = subGridinac_Class+"Odd";
               }
               subGridinac_Backcolor = (int)(0x0);
            }
            else if ( subGridinac_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGridinac_Backstyle = 1;
               if ( ((int)(((nGXsfl_90_idx-1)/ (decimal)(1)) % (2))) == 0 )
               {
                  subGridinac_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGridinac_Class, "") != 0 )
                  {
                     subGridinac_Linesclass = subGridinac_Class+"Odd";
                  }
               }
               else
               {
                  subGridinac_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGridinac_Class, "") != 0 )
                  {
                     subGridinac_Linesclass = subGridinac_Class+"Even";
                  }
               }
            }
            if ( GridinacContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+"WorkWith"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_90_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridinacContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridinacRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenAnio_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A25OrdenAnio), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A25OrdenAnio), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenAnio_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)60,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)90,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridinacContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridinacRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenPeriodo_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A24OrdenPeriodo), 2, 0, ",", "")),context.localUtil.Format( (decimal)(A24OrdenPeriodo), "Z9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenPeriodo_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)60,(String)"px",(short)17,(String)"px",(short)2,(short)0,(short)0,(short)90,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridinacContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridinacRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenFch_Internalname,context.localUtil.Format(A119OrdenFch, "99/99/9999"),context.localUtil.Format( A119OrdenFch, "99/99/9999"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenFch_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)90,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridinacContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridinacRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtfacturaNro_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A106facturaNro), 8, 0, ",", "")),context.localUtil.Format( (decimal)(A106facturaNro), "ZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtfacturaNro_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)90,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridinacContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridinacRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClienteDsc_Internalname,StringUtil.RTrim( A57ClienteDsc),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtClienteDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)90,(short)1,(short)-1,(short)-1,(bool)true,(String)"Descripcion",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridinacContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridinacRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A22OrdenID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A22OrdenID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)90,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridinacContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridinacRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVehiculoPlaca_Internalname,(String)A68VehiculoPlaca,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtVehiculoPlaca_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)90,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridinacContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridinacRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVehiculoChasis_Internalname,(String)A69VehiculoChasis,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtVehiculoChasis_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)90,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridinacContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridinacRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edttipOrdDsc_Internalname,StringUtil.RTrim( A104tipOrdDsc),StringUtil.RTrim( context.localUtil.Format( A104tipOrdDsc, "@!")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edttipOrdDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)90,(short)1,(short)-1,(short)-1,(bool)true,(String)"nombres",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridinacContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridinacRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVendedorSiglas_Internalname,(String)A121VendedorSiglas,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtVendedorSiglas_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)5,(short)0,(short)0,(short)90,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridinacContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( dynOrdenProceso.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "ORDENPROCESO_" + sGXsfl_66_idx;
               dynOrdenProceso.Name = GXCCtl;
               dynOrdenProceso.WebTags = "";
               dynOrdenProceso.removeAllItems();
               /* Using cursor H001K13 */
               pr_default.execute(11);
               while ( (pr_default.getStatus(11) != 101) )
               {
                  dynOrdenProceso.addItem(H001K13_A129ProcAbre[0], H001K13_A128ProcDsc[0], 0);
                  pr_default.readNext(11);
               }
               pr_default.close(11);
            }
            /* ComboBox */
            GridinacRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)dynOrdenProceso,(String)dynOrdenProceso_Internalname,StringUtil.RTrim( A133OrdenProceso),(short)1,(String)dynOrdenProceso_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn WWOptionalColumn",(String)"",(String)"",(String)"",(bool)true});
            dynOrdenProceso.CurrentValue = StringUtil.RTrim( A133OrdenProceso);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynOrdenProceso_Internalname, "Values", (String)(dynOrdenProceso.ToJavascriptSource()), !bGXsfl_66_Refreshing);
            /* Subfile cell */
            if ( GridinacContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( dynprotID.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "PROTID_" + sGXsfl_66_idx;
               dynprotID.Name = GXCCtl;
               dynprotID.WebTags = "";
               dynprotID.removeAllItems();
               /* Using cursor H001K14 */
               pr_default.execute(12);
               while ( (pr_default.getStatus(12) != 101) )
               {
                  dynprotID.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(H001K14_A10protID[0]), 4, 0)), H001K14_A74protDsc[0], 0);
                  pr_default.readNext(12);
               }
               pr_default.close(12);
            }
            /* ComboBox */
            GridinacRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)dynprotID,(String)dynprotID_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(A10protID), 4, 0)),(short)1,(String)dynprotID_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn WWOptionalColumn",(String)"",(String)"",(String)"",(bool)true});
            dynprotID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A10protID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynprotID_Internalname, "Values", (String)(dynprotID.ToJavascriptSource()), !bGXsfl_66_Refreshing);
            /* Subfile cell */
            if ( GridinacContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "";
            StyleString = "";
            AV33Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV33Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV48Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV33Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV33Update)) ? AV48Update_GXI : context.PathToRelativeUrl( AV33Update));
            GridinacRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavUpdate_Visible,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV33Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridinacContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavEmails_Enabled!=0)&&(edtavEmails_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 104,'',false,'',90)\"" : " ");
            ClassString = "";
            StyleString = "";
            AV12emails_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV12emails))&&String.IsNullOrEmpty(StringUtil.RTrim( AV46Emails_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV12emails)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV12emails)) ? AV46Emails_GXI : context.PathToRelativeUrl( AV12emails));
            GridinacRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavEmails_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavEmails_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavEmails_Jsonclick,"'"+""+"'"+",false,"+"'"+"EVEMAILS.CLICK."+sGXsfl_90_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV12emails_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridinacContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "";
            StyleString = "";
            AV11display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV11display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV50Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV11display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV11display)) ? AV50Display_GXI : context.PathToRelativeUrl( AV11display));
            GridinacRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV11display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridinacContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "";
            StyleString = "";
            AV10Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV10Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV49Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV10Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV10Delete)) ? AV49Delete_GXI : context.PathToRelativeUrl( AV10Delete));
            GridinacRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)edtavDelete_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV10Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            send_integrity_lvl_hashes1K3( ) ;
            GridinacContainer.AddRow(GridinacRow);
            nGXsfl_90_idx = (short)(((subGridinac_Islastpage==1)&&(nGXsfl_90_idx+1>subGridinac_Recordsperpage( )) ? 1 : nGXsfl_90_idx+1));
            sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx), 4, 0)), 4, "0");
            SubsflControlProps_903( ) ;
         }
         /* End function sendrow_903 */
      }

      protected void init_web_controls( )
      {
         cmbavAnio.Name = "vANIO";
         cmbavAnio.WebTags = "";
         if ( cmbavAnio.ItemCount > 0 )
         {
            AV7anio = (short)(NumberUtil.Val( cmbavAnio.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV7anio), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7anio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7anio), 4, 0)));
         }
         cmbavPeriod.Name = "vPERIOD";
         cmbavPeriod.WebTags = "";
         cmbavPeriod.addItem("0", "Todos", 0);
         cmbavPeriod.addItem("1", "Enero", 0);
         cmbavPeriod.addItem("2", "Febrero", 0);
         cmbavPeriod.addItem("3", "Marzo", 0);
         cmbavPeriod.addItem("4", "Abril", 0);
         cmbavPeriod.addItem("5", "Mayo", 0);
         cmbavPeriod.addItem("6", "Junio", 0);
         cmbavPeriod.addItem("7", "Julio", 0);
         cmbavPeriod.addItem("8", "Agosto", 0);
         cmbavPeriod.addItem("9", "Septiembre", 0);
         cmbavPeriod.addItem("10", "Octubre", 0);
         cmbavPeriod.addItem("11", "Noviembre", 0);
         cmbavPeriod.addItem("12", "Diciembre", 0);
         if ( cmbavPeriod.ItemCount > 0 )
         {
            AV28period = (short)(NumberUtil.Val( cmbavPeriod.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV28period), 2, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28period", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28period), 2, 0)));
         }
         dynavMarca.Name = "vMARCA";
         dynavMarca.WebTags = "";
         dynavModelo.Name = "vMODELO";
         dynavModelo.WebTags = "";
         dynavVendedor.Name = "vVENDEDOR";
         dynavVendedor.WebTags = "";
         dynavOrdenproceso.Name = "vORDENPROCESO";
         dynavOrdenproceso.WebTags = "";
         GXCCtl = "ORDENPROCESO_" + sGXsfl_66_idx;
         dynOrdenProceso.Name = GXCCtl;
         dynOrdenProceso.WebTags = "";
         dynOrdenProceso.removeAllItems();
         /* Using cursor H001K15 */
         pr_default.execute(13);
         while ( (pr_default.getStatus(13) != 101) )
         {
            dynOrdenProceso.addItem(H001K15_A129ProcAbre[0], H001K15_A128ProcDsc[0], 0);
            pr_default.readNext(13);
         }
         pr_default.close(13);
         GXCCtl = "PROTID_" + sGXsfl_66_idx;
         dynprotID.Name = GXCCtl;
         dynprotID.WebTags = "";
         dynprotID.removeAllItems();
         /* Using cursor H001K16 */
         pr_default.execute(14);
         while ( (pr_default.getStatus(14) != 101) )
         {
            dynprotID.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(H001K16_A10protID[0]), 4, 0)), H001K16_A74protDsc[0], 0);
            pr_default.readNext(14);
         }
         pr_default.close(14);
         GXCCtl = "ORDENPROCESO_" + sGXsfl_66_idx;
         dynOrdenProceso.Name = GXCCtl;
         dynOrdenProceso.WebTags = "";
         dynOrdenProceso.removeAllItems();
         /* Using cursor H001K17 */
         pr_default.execute(15);
         while ( (pr_default.getStatus(15) != 101) )
         {
            dynOrdenProceso.addItem(H001K17_A129ProcAbre[0], H001K17_A128ProcDsc[0], 0);
            pr_default.readNext(15);
         }
         pr_default.close(15);
         GXCCtl = "PROTID_" + sGXsfl_66_idx;
         dynprotID.Name = GXCCtl;
         dynprotID.WebTags = "";
         dynprotID.removeAllItems();
         /* Using cursor H001K18 */
         pr_default.execute(16);
         while ( (pr_default.getStatus(16) != 101) )
         {
            dynprotID.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(H001K18_A10protID[0]), 4, 0)), H001K18_A74protDsc[0], 0);
            pr_default.readNext(16);
         }
         pr_default.close(16);
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTitletext_Internalname = "TITLETEXT";
         cmbavAnio_Internalname = "vANIO";
         bttBtninsert_Internalname = "BTNINSERT";
         bttBtnbusavanzada_Internalname = "BTNBUSAVANZADA";
         cmbavPeriod_Internalname = "vPERIOD";
         edtavOrdenid_Internalname = "vORDENID";
         edtavClientedsc_Internalname = "vCLIENTEDSC";
         edtavVehiculoplaca_Internalname = "vVEHICULOPLACA";
         edtavVehiculochasis_Internalname = "vVEHICULOCHASIS";
         dynavMarca_Internalname = "vMARCA";
         dynavModelo_Internalname = "vMODELO";
         dynavVendedor_Internalname = "vVENDEDOR";
         dynavOrdenproceso_Internalname = "vORDENPROCESO";
         divTbbusavanced_Internalname = "TBBUSAVANCED";
         divTabletop1_Internalname = "TABLETOP1";
         lblTabtodos_title_Internalname = "TABTODOS_TITLE";
         edtOrdenAnio_Internalname = "ORDENANIO";
         edtOrdenPeriodo_Internalname = "ORDENPERIODO";
         edtOrdenFch_Internalname = "ORDENFCH";
         edtfacturaNro_Internalname = "FACTURANRO";
         edtClienteDsc_Internalname = "CLIENTEDSC";
         edtOrdenID_Internalname = "ORDENID";
         edtVehiculoPlaca_Internalname = "VEHICULOPLACA";
         edtVehiculoChasis_Internalname = "VEHICULOCHASIS";
         edttipOrdDsc_Internalname = "TIPORDDSC";
         edtVendedorSiglas_Internalname = "VENDEDORSIGLAS";
         dynOrdenProceso_Internalname = "ORDENPROCESO";
         dynprotID_Internalname = "PROTID";
         edtavUpdate_Internalname = "vUPDATE";
         edtavEmails_Internalname = "vEMAILS";
         edtavDisplay_Internalname = "vDISPLAY";
         edtavDelete_Internalname = "vDELETE";
         divTabgridoptable_Internalname = "TABGRIDOPTABLE";
         lblTabinact_title_Internalname = "TABINACT_TITLE";
         edtOrdenAnio_Internalname = "ORDENANIO";
         edtOrdenPeriodo_Internalname = "ORDENPERIODO";
         edtOrdenFch_Internalname = "ORDENFCH";
         edtfacturaNro_Internalname = "FACTURANRO";
         edtClienteDsc_Internalname = "CLIENTEDSC";
         edtOrdenID_Internalname = "ORDENID";
         edtVehiculoPlaca_Internalname = "VEHICULOPLACA";
         edtVehiculoChasis_Internalname = "VEHICULOCHASIS";
         edttipOrdDsc_Internalname = "TIPORDDSC";
         edtVendedorSiglas_Internalname = "VENDEDORSIGLAS";
         dynOrdenProceso_Internalname = "ORDENPROCESO";
         dynprotID_Internalname = "PROTID";
         edtavUpdate_Internalname = "vUPDATE";
         edtavEmails_Internalname = "vEMAILS";
         edtavDisplay_Internalname = "vDISPLAY";
         edtavDelete_Internalname = "vDELETE";
         divTabpage2table_Internalname = "TABPAGE2TABLE";
         Tabgridop_Internalname = "TABGRIDOP";
         divGridtable_Internalname = "GRIDTABLE";
         edtavYear_Internalname = "vYEAR";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         subGrid_Internalname = "GRID";
         subGridinac_Internalname = "GRIDINAC";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtavEmails_Jsonclick = "";
         edtavEmails_Visible = -1;
         edtavEmails_Enabled = 1;
         dynprotID_Jsonclick = "";
         dynOrdenProceso_Jsonclick = "";
         edtVendedorSiglas_Jsonclick = "";
         edttipOrdDsc_Jsonclick = "";
         edtVehiculoChasis_Jsonclick = "";
         edtVehiculoPlaca_Jsonclick = "";
         edtOrdenID_Jsonclick = "";
         edtClienteDsc_Jsonclick = "";
         edtfacturaNro_Jsonclick = "";
         edtOrdenFch_Jsonclick = "";
         edtOrdenPeriodo_Jsonclick = "";
         edtOrdenAnio_Jsonclick = "";
         edtavYear_Jsonclick = "";
         edtavYear_Enabled = 1;
         edtavYear_Visible = 1;
         subGridinac_Allowcollapsing = 0;
         subGridinac_Allowhovering = 0;
         subGridinac_Allowselection = 1;
         subGridinac_Header = "";
         subGridinac_Class = "WorkWith";
         subGridinac_Backcolorstyle = 0;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowhovering = 0;
         subGrid_Allowselection = 1;
         edtavDelete_Link = "";
         edtavDisplay_Link = "";
         edtavUpdate_Link = "";
         subGrid_Header = "";
         subGrid_Class = "WorkWith";
         subGrid_Backcolorstyle = 0;
         dynavOrdenproceso_Jsonclick = "";
         dynavOrdenproceso.Enabled = 1;
         dynavVendedor_Jsonclick = "";
         dynavVendedor.Enabled = 1;
         dynavModelo_Jsonclick = "";
         dynavModelo.Enabled = 1;
         dynavMarca_Jsonclick = "";
         dynavMarca.Enabled = 1;
         divTbbusavanced_Visible = 1;
         edtavVehiculochasis_Jsonclick = "";
         edtavVehiculochasis_Enabled = 1;
         edtavVehiculoplaca_Jsonclick = "";
         edtavVehiculoplaca_Enabled = 1;
         edtavClientedsc_Jsonclick = "";
         edtavClientedsc_Enabled = 1;
         edtavOrdenid_Jsonclick = "";
         edtavOrdenid_Enabled = 1;
         cmbavPeriod_Jsonclick = "";
         cmbavPeriod.Enabled = 1;
         bttBtnbusavanzada_Tooltiptext = "Ver Más>>";
         bttBtnbusavanzada_Caption = "Ver Más>>";
         cmbavAnio_Jsonclick = "";
         cmbavAnio.Enabled = 1;
         Tabgridop_Historymanagement = Convert.ToBoolean( 0);
         Tabgridop_Pagecount = 2;
         Tabgridop_Class = "WWTabCustom";
         Form.Caption = "Work With Orden Produccion";
         subGridinac_Rows = 10;
         subGrid_Rows = 10;
         edtavDisplay_Tooltiptext = "";
         edtavDelete_Tooltiptext = "";
         edtavUpdate_Visible = -1;
         edtavUpdate_Tooltiptext = "";
         edtavEmails_Tooltiptext = "";
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public void Validv_Marca( short GX_Parm1 ,
                                GXCombobox dynGX_Parm2 ,
                                GXCombobox dynGX_Parm3 )
      {
         AV13empID = GX_Parm1;
         dynavMarca = dynGX_Parm2;
         AV22marca = (short)(NumberUtil.Val( dynavMarca.CurrentValue, "."));
         dynavModelo = dynGX_Parm3;
         AV25modelo = (short)(NumberUtil.Val( dynavModelo.CurrentValue, "."));
         GXVvMODELO_html1K2( AV13empID, AV22marca) ;
         dynload_actions( ) ;
         if ( dynavModelo.ItemCount > 0 )
         {
            AV25modelo = (short)(NumberUtil.Val( dynavModelo.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV25modelo), 4, 0))), "."));
         }
         dynavModelo.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV25modelo), 4, 0));
         isValidOutput.Add(dynavModelo);
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'GRIDINAC_nFirstRecordOnPage'},{av:'GRIDINAC_nEOF'},{av:'subGridinac_Rows',ctrl:'GRIDINAC',prop:'Rows'},{av:'cmbavAnio'},{av:'AV7anio',fld:'vANIO',pic:'ZZZ9'},{av:'cmbavPeriod'},{av:'AV28period',fld:'vPERIOD',pic:'Z9'},{av:'AV26ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV37vehiculoPlaca',fld:'vVEHICULOPLACA',pic:''},{av:'AV36vehiculoChasis',fld:'vVEHICULOCHASIS',pic:''},{av:'AV12emails',fld:'vEMAILS',pic:''},{av:'edtavEmails_Tooltiptext',ctrl:'vEMAILS',prop:'Tooltiptext'},{av:'AV33Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV10Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'AV11display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'AV47Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8ClienteDsc',fld:'vCLIENTEDSC',pic:''},{av:'AV6ageID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV34UserCod',fld:'vUSERCOD',pic:'',hsh:true},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9',hsh:true},{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E161K2',iparms:[{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'AV6ageID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9',hsh:true},{av:'A24OrdenPeriodo',fld:'ORDENPERIODO',pic:'Z9',hsh:true},{av:'A25OrdenAnio',fld:'ORDENANIO',pic:'ZZZ9'},{av:'A22OrdenID',fld:'ORDENID',pic:'ZZZ9',hsh:true},{av:'AV34UserCod',fld:'vUSERCOD',pic:'',hsh:true},{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]}");
         setEventMetadata("GRIDINAC.LOAD","{handler:'E181K3',iparms:[{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'AV6ageID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9',hsh:true},{av:'A24OrdenPeriodo',fld:'ORDENPERIODO',pic:'Z9',hsh:true},{av:'A25OrdenAnio',fld:'ORDENANIO',pic:'ZZZ9'},{av:'A22OrdenID',fld:'ORDENID',pic:'ZZZ9',hsh:true},{av:'AV34UserCod',fld:'vUSERCOD',pic:'',hsh:true},{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]");
         setEventMetadata("GRIDINAC.LOAD",",oparms:[{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E121K2',iparms:[{av:'cmbavAnio'},{av:'AV7anio',fld:'vANIO',pic:'ZZZ9'},{av:'AV6ageID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9',hsh:true},{av:'A24OrdenPeriodo',fld:'ORDENPERIODO',pic:'Z9',hsh:true},{av:'A22OrdenID',fld:'ORDENID',pic:'ZZZ9',hsh:true},{av:'AV34UserCod',fld:'vUSERCOD',pic:'',hsh:true},{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]");
         setEventMetadata("'DOINSERT'",",oparms:[{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]}");
         setEventMetadata("VPERIOD.CLICK","{handler:'E131K2',iparms:[{av:'cmbavPeriod'},{av:'AV28period',fld:'vPERIOD',pic:'Z9'},{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]");
         setEventMetadata("VPERIOD.CLICK",",oparms:[{av:'AV39year',fld:'vYEAR',pic:'ZZZ9'},{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]}");
         setEventMetadata("VEMAILS.CLICK","{handler:'E171K2',iparms:[{av:'AV34UserCod',fld:'vUSERCOD',pic:'',hsh:true},{av:'A22OrdenID',fld:'ORDENID',pic:'ZZZ9',hsh:true},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9',hsh:true},{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]");
         setEventMetadata("VEMAILS.CLICK",",oparms:[{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]}");
         setEventMetadata("'BUSQUEDA'","{handler:'E111K1',iparms:[{av:'divTbbusavanced_Visible',ctrl:'TBBUSAVANCED',prop:'Visible'},{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]");
         setEventMetadata("'BUSQUEDA'",",oparms:[{av:'divTbbusavanced_Visible',ctrl:'TBBUSAVANCED',prop:'Visible'},{ctrl:'BTNBUSAVANZADA',prop:'Caption'},{ctrl:'BTNBUSAVANZADA',prop:'Tooltiptext'},{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]}");
         setEventMetadata("GRID_FIRSTPAGE","{handler:'subgrid_firstpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavAnio'},{av:'AV7anio',fld:'vANIO',pic:'ZZZ9'},{av:'cmbavPeriod'},{av:'AV28period',fld:'vPERIOD',pic:'Z9'},{av:'AV26ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV37vehiculoPlaca',fld:'vVEHICULOPLACA',pic:''},{av:'AV36vehiculoChasis',fld:'vVEHICULOCHASIS',pic:''},{av:'AV12emails',fld:'vEMAILS',pic:''},{av:'edtavEmails_Tooltiptext',ctrl:'vEMAILS',prop:'Tooltiptext'},{av:'AV33Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV10Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'AV11display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'AV6ageID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV34UserCod',fld:'vUSERCOD',pic:'',hsh:true},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9',hsh:true},{av:'AV47Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8ClienteDsc',fld:'vCLIENTEDSC',pic:''},{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]");
         setEventMetadata("GRID_FIRSTPAGE",",oparms:[{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]}");
         setEventMetadata("GRID_PREVPAGE","{handler:'subgrid_previouspage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavAnio'},{av:'AV7anio',fld:'vANIO',pic:'ZZZ9'},{av:'cmbavPeriod'},{av:'AV28period',fld:'vPERIOD',pic:'Z9'},{av:'AV26ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV37vehiculoPlaca',fld:'vVEHICULOPLACA',pic:''},{av:'AV36vehiculoChasis',fld:'vVEHICULOCHASIS',pic:''},{av:'AV12emails',fld:'vEMAILS',pic:''},{av:'edtavEmails_Tooltiptext',ctrl:'vEMAILS',prop:'Tooltiptext'},{av:'AV33Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV10Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'AV11display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'AV6ageID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV34UserCod',fld:'vUSERCOD',pic:'',hsh:true},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9',hsh:true},{av:'AV47Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8ClienteDsc',fld:'vCLIENTEDSC',pic:''},{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]");
         setEventMetadata("GRID_PREVPAGE",",oparms:[{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]}");
         setEventMetadata("GRID_NEXTPAGE","{handler:'subgrid_nextpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavAnio'},{av:'AV7anio',fld:'vANIO',pic:'ZZZ9'},{av:'cmbavPeriod'},{av:'AV28period',fld:'vPERIOD',pic:'Z9'},{av:'AV26ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV37vehiculoPlaca',fld:'vVEHICULOPLACA',pic:''},{av:'AV36vehiculoChasis',fld:'vVEHICULOCHASIS',pic:''},{av:'AV12emails',fld:'vEMAILS',pic:''},{av:'edtavEmails_Tooltiptext',ctrl:'vEMAILS',prop:'Tooltiptext'},{av:'AV33Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV10Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'AV11display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'AV6ageID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV34UserCod',fld:'vUSERCOD',pic:'',hsh:true},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9',hsh:true},{av:'AV47Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8ClienteDsc',fld:'vCLIENTEDSC',pic:''},{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]");
         setEventMetadata("GRID_NEXTPAGE",",oparms:[{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]}");
         setEventMetadata("GRID_LASTPAGE","{handler:'subgrid_lastpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavAnio'},{av:'AV7anio',fld:'vANIO',pic:'ZZZ9'},{av:'cmbavPeriod'},{av:'AV28period',fld:'vPERIOD',pic:'Z9'},{av:'AV26ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV37vehiculoPlaca',fld:'vVEHICULOPLACA',pic:''},{av:'AV36vehiculoChasis',fld:'vVEHICULOCHASIS',pic:''},{av:'AV12emails',fld:'vEMAILS',pic:''},{av:'edtavEmails_Tooltiptext',ctrl:'vEMAILS',prop:'Tooltiptext'},{av:'AV33Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV10Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'AV11display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'AV6ageID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV34UserCod',fld:'vUSERCOD',pic:'',hsh:true},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9',hsh:true},{av:'AV47Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8ClienteDsc',fld:'vCLIENTEDSC',pic:''},{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]");
         setEventMetadata("GRID_LASTPAGE",",oparms:[{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]}");
         setEventMetadata("GRIDINAC_FIRSTPAGE","{handler:'subgridinac_firstpage',iparms:[{av:'GRIDINAC_nFirstRecordOnPage'},{av:'GRIDINAC_nEOF'},{av:'subGridinac_Rows',ctrl:'GRIDINAC',prop:'Rows'},{av:'cmbavAnio'},{av:'AV7anio',fld:'vANIO',pic:'ZZZ9'},{av:'cmbavPeriod'},{av:'AV28period',fld:'vPERIOD',pic:'Z9'},{av:'AV26ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV37vehiculoPlaca',fld:'vVEHICULOPLACA',pic:''},{av:'AV36vehiculoChasis',fld:'vVEHICULOCHASIS',pic:''},{av:'AV12emails',fld:'vEMAILS',pic:''},{av:'edtavEmails_Tooltiptext',ctrl:'vEMAILS',prop:'Tooltiptext'},{av:'AV33Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV10Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'AV11display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'AV6ageID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV34UserCod',fld:'vUSERCOD',pic:'',hsh:true},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9',hsh:true},{av:'AV47Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8ClienteDsc',fld:'vCLIENTEDSC',pic:''},{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]");
         setEventMetadata("GRIDINAC_FIRSTPAGE",",oparms:[{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]}");
         setEventMetadata("GRIDINAC_PREVPAGE","{handler:'subgridinac_previouspage',iparms:[{av:'GRIDINAC_nFirstRecordOnPage'},{av:'GRIDINAC_nEOF'},{av:'subGridinac_Rows',ctrl:'GRIDINAC',prop:'Rows'},{av:'cmbavAnio'},{av:'AV7anio',fld:'vANIO',pic:'ZZZ9'},{av:'cmbavPeriod'},{av:'AV28period',fld:'vPERIOD',pic:'Z9'},{av:'AV26ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV37vehiculoPlaca',fld:'vVEHICULOPLACA',pic:''},{av:'AV36vehiculoChasis',fld:'vVEHICULOCHASIS',pic:''},{av:'AV12emails',fld:'vEMAILS',pic:''},{av:'edtavEmails_Tooltiptext',ctrl:'vEMAILS',prop:'Tooltiptext'},{av:'AV33Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV10Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'AV11display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'AV6ageID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV34UserCod',fld:'vUSERCOD',pic:'',hsh:true},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9',hsh:true},{av:'AV47Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8ClienteDsc',fld:'vCLIENTEDSC',pic:''},{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]");
         setEventMetadata("GRIDINAC_PREVPAGE",",oparms:[{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]}");
         setEventMetadata("GRIDINAC_NEXTPAGE","{handler:'subgridinac_nextpage',iparms:[{av:'GRIDINAC_nFirstRecordOnPage'},{av:'GRIDINAC_nEOF'},{av:'subGridinac_Rows',ctrl:'GRIDINAC',prop:'Rows'},{av:'cmbavAnio'},{av:'AV7anio',fld:'vANIO',pic:'ZZZ9'},{av:'cmbavPeriod'},{av:'AV28period',fld:'vPERIOD',pic:'Z9'},{av:'AV26ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV37vehiculoPlaca',fld:'vVEHICULOPLACA',pic:''},{av:'AV36vehiculoChasis',fld:'vVEHICULOCHASIS',pic:''},{av:'AV12emails',fld:'vEMAILS',pic:''},{av:'edtavEmails_Tooltiptext',ctrl:'vEMAILS',prop:'Tooltiptext'},{av:'AV33Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV10Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'AV11display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'AV6ageID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV34UserCod',fld:'vUSERCOD',pic:'',hsh:true},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9',hsh:true},{av:'AV47Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8ClienteDsc',fld:'vCLIENTEDSC',pic:''},{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]");
         setEventMetadata("GRIDINAC_NEXTPAGE",",oparms:[{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]}");
         setEventMetadata("GRIDINAC_LASTPAGE","{handler:'subgridinac_lastpage',iparms:[{av:'GRIDINAC_nFirstRecordOnPage'},{av:'GRIDINAC_nEOF'},{av:'subGridinac_Rows',ctrl:'GRIDINAC',prop:'Rows'},{av:'cmbavAnio'},{av:'AV7anio',fld:'vANIO',pic:'ZZZ9'},{av:'cmbavPeriod'},{av:'AV28period',fld:'vPERIOD',pic:'Z9'},{av:'AV26ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV37vehiculoPlaca',fld:'vVEHICULOPLACA',pic:''},{av:'AV36vehiculoChasis',fld:'vVEHICULOCHASIS',pic:''},{av:'AV12emails',fld:'vEMAILS',pic:''},{av:'edtavEmails_Tooltiptext',ctrl:'vEMAILS',prop:'Tooltiptext'},{av:'AV33Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV10Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'AV11display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'AV6ageID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV34UserCod',fld:'vUSERCOD',pic:'',hsh:true},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9',hsh:true},{av:'AV47Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8ClienteDsc',fld:'vCLIENTEDSC',pic:''},{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]");
         setEventMetadata("GRIDINAC_LASTPAGE",",oparms:[{av:'dynavMarca'},{av:'AV22marca',fld:'vMARCA',pic:'ZZZ9'},{av:'dynavOrdenproceso'},{av:'AV27OrdenProceso',fld:'vORDENPROCESO',pic:'@!'},{av:'AV13empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavModelo'},{av:'AV25modelo',fld:'vMODELO',pic:'ZZZ9'},{av:'dynavVendedor'},{av:'AV38vendedor',fld:'vVENDEDOR',pic:'ZZZ9'}]}");
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
         wcpOAV34UserCod = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV12emails = "";
         AV33Update = "";
         AV10Delete = "";
         AV11display = "";
         AV8ClienteDsc = "";
         AV37vehiculoPlaca = "";
         AV36vehiculoChasis = "";
         AV27OrdenProceso = "";
         AV47Pgmname = "";
         GXKey = "";
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
         bttBtnbusavanzada_Jsonclick = "";
         lblTabtodos_title_Jsonclick = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         A119OrdenFch = DateTime.MinValue;
         A57ClienteDsc = "";
         A68VehiculoPlaca = "";
         A69VehiculoChasis = "";
         A104tipOrdDsc = "";
         A121VendedorSiglas = "";
         A133OrdenProceso = "";
         lblTabinact_title_Jsonclick = "";
         GridinacContainer = new GXWebGrid( context);
         subGridinac_Linesclass = "";
         GridinacColumn = new GXWebColumn();
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV48Update_GXI = "";
         AV46Emails_GXI = "";
         AV50Display_GXI = "";
         AV49Delete_GXI = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         scmdbuf = "";
         H001K2_A10protID = new short[1] ;
         H001K2_A74protDsc = new String[] {""} ;
         H001K2_n74protDsc = new bool[] {false} ;
         H001K2_A1EmpID = new short[1] ;
         H001K3_A1EmpID = new short[1] ;
         H001K3_A6MarcaID = new short[1] ;
         H001K3_A62MarcaDsc = new String[] {""} ;
         H001K3_n62MarcaDsc = new bool[] {false} ;
         H001K4_A7ModeloID = new short[1] ;
         H001K4_A64ModeloDsc = new String[] {""} ;
         H001K4_n64ModeloDsc = new bool[] {false} ;
         H001K4_A1EmpID = new short[1] ;
         H001K4_A6MarcaID = new short[1] ;
         H001K5_A9vendedorID = new short[1] ;
         H001K5_A72vendedorDsc = new String[] {""} ;
         H001K5_n72vendedorDsc = new bool[] {false} ;
         H001K5_A1EmpID = new short[1] ;
         H001K5_A73vendedorEst = new String[] {""} ;
         H001K5_n73vendedorEst = new bool[] {false} ;
         H001K6_A20ProcID = new short[1] ;
         H001K6_A129ProcAbre = new String[] {""} ;
         H001K6_n129ProcAbre = new bool[] {false} ;
         H001K6_A128ProcDsc = new String[] {""} ;
         H001K6_n128ProcDsc = new bool[] {false} ;
         lV8ClienteDsc = "";
         lV37vehiculoPlaca = "";
         lV36vehiculoChasis = "";
         A115OrdenEst = "";
         H001K7_A8VehiculoID = new short[1] ;
         H001K7_A17tipOrdID = new short[1] ;
         H001K7_A115OrdenEst = new String[] {""} ;
         H001K7_n115OrdenEst = new bool[] {false} ;
         H001K7_A1EmpID = new short[1] ;
         H001K7_A9vendedorID = new short[1] ;
         H001K7_A117OrdenModeloID = new short[1] ;
         H001K7_A26OrdenMarcaID = new short[1] ;
         H001K7_A10protID = new short[1] ;
         H001K7_A133OrdenProceso = new String[] {""} ;
         H001K7_n133OrdenProceso = new bool[] {false} ;
         H001K7_A121VendedorSiglas = new String[] {""} ;
         H001K7_n121VendedorSiglas = new bool[] {false} ;
         H001K7_A104tipOrdDsc = new String[] {""} ;
         H001K7_n104tipOrdDsc = new bool[] {false} ;
         H001K7_A69VehiculoChasis = new String[] {""} ;
         H001K7_n69VehiculoChasis = new bool[] {false} ;
         H001K7_A68VehiculoPlaca = new String[] {""} ;
         H001K7_n68VehiculoPlaca = new bool[] {false} ;
         H001K7_A22OrdenID = new short[1] ;
         H001K7_A57ClienteDsc = new String[] {""} ;
         H001K7_n57ClienteDsc = new bool[] {false} ;
         H001K7_A106facturaNro = new int[1] ;
         H001K7_n106facturaNro = new bool[] {false} ;
         H001K7_A119OrdenFch = new DateTime[] {DateTime.MinValue} ;
         H001K7_n119OrdenFch = new bool[] {false} ;
         H001K7_A24OrdenPeriodo = new short[1] ;
         H001K7_A25OrdenAnio = new short[1] ;
         H001K7_A5ClienteID = new short[1] ;
         H001K8_A8VehiculoID = new short[1] ;
         H001K8_A17tipOrdID = new short[1] ;
         H001K8_A115OrdenEst = new String[] {""} ;
         H001K8_n115OrdenEst = new bool[] {false} ;
         H001K8_A9vendedorID = new short[1] ;
         H001K8_A117OrdenModeloID = new short[1] ;
         H001K8_A26OrdenMarcaID = new short[1] ;
         H001K8_A5ClienteID = new short[1] ;
         H001K8_A1EmpID = new short[1] ;
         H001K8_A10protID = new short[1] ;
         H001K8_A133OrdenProceso = new String[] {""} ;
         H001K8_n133OrdenProceso = new bool[] {false} ;
         H001K8_A121VendedorSiglas = new String[] {""} ;
         H001K8_n121VendedorSiglas = new bool[] {false} ;
         H001K8_A104tipOrdDsc = new String[] {""} ;
         H001K8_n104tipOrdDsc = new bool[] {false} ;
         H001K8_A69VehiculoChasis = new String[] {""} ;
         H001K8_n69VehiculoChasis = new bool[] {false} ;
         H001K8_A68VehiculoPlaca = new String[] {""} ;
         H001K8_n68VehiculoPlaca = new bool[] {false} ;
         H001K8_A22OrdenID = new short[1] ;
         H001K8_A57ClienteDsc = new String[] {""} ;
         H001K8_n57ClienteDsc = new bool[] {false} ;
         H001K8_A106facturaNro = new int[1] ;
         H001K8_n106facturaNro = new bool[] {false} ;
         H001K8_A119OrdenFch = new DateTime[] {DateTime.MinValue} ;
         H001K8_n119OrdenFch = new bool[] {false} ;
         H001K8_A24OrdenPeriodo = new short[1] ;
         H001K8_A25OrdenAnio = new short[1] ;
         H001K9_AGRID_nRecordCount = new long[1] ;
         H001K10_AGRIDINAC_nRecordCount = new long[1] ;
         AV29rolUser = "";
         GXt_char1 = "";
         GridRow = new GXWebRow();
         AV20HTTPRequest = new GxHttpRequest( context);
         AV18GridState = new SdtGridState(context);
         AV30Session = context.GetSession();
         AV19GridStateFilterValue = new SdtGridState_FilterValue(context);
         AV31TrnContext = new SdtTransactionContext(context);
         AV16fechaAux = DateTime.MinValue;
         AV14fchDesd = DateTime.MinValue;
         AV15fchHast = DateTime.MinValue;
         AV24mensj = "";
         GridinacRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         GXCCtl = "";
         H001K11_A20ProcID = new short[1] ;
         H001K11_A129ProcAbre = new String[] {""} ;
         H001K11_n129ProcAbre = new bool[] {false} ;
         H001K11_A128ProcDsc = new String[] {""} ;
         H001K11_n128ProcDsc = new bool[] {false} ;
         H001K12_A1EmpID = new short[1] ;
         H001K12_A10protID = new short[1] ;
         H001K12_A74protDsc = new String[] {""} ;
         H001K12_n74protDsc = new bool[] {false} ;
         sImgUrl = "";
         H001K13_A20ProcID = new short[1] ;
         H001K13_A129ProcAbre = new String[] {""} ;
         H001K13_n129ProcAbre = new bool[] {false} ;
         H001K13_A128ProcDsc = new String[] {""} ;
         H001K13_n128ProcDsc = new bool[] {false} ;
         H001K14_A1EmpID = new short[1] ;
         H001K14_A10protID = new short[1] ;
         H001K14_A74protDsc = new String[] {""} ;
         H001K14_n74protDsc = new bool[] {false} ;
         H001K15_A20ProcID = new short[1] ;
         H001K15_A129ProcAbre = new String[] {""} ;
         H001K15_n129ProcAbre = new bool[] {false} ;
         H001K15_A128ProcDsc = new String[] {""} ;
         H001K15_n128ProcDsc = new bool[] {false} ;
         H001K16_A1EmpID = new short[1] ;
         H001K16_A10protID = new short[1] ;
         H001K16_A74protDsc = new String[] {""} ;
         H001K16_n74protDsc = new bool[] {false} ;
         H001K17_A20ProcID = new short[1] ;
         H001K17_A129ProcAbre = new String[] {""} ;
         H001K17_n129ProcAbre = new bool[] {false} ;
         H001K17_A128ProcDsc = new String[] {""} ;
         H001K17_n128ProcDsc = new bool[] {false} ;
         H001K18_A1EmpID = new short[1] ;
         H001K18_A10protID = new short[1] ;
         H001K18_A74protDsc = new String[] {""} ;
         H001K18_n74protDsc = new bool[] {false} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwordenproduccion__default(),
            new Object[][] {
                new Object[] {
               H001K2_A10protID, H001K2_A74protDsc, H001K2_n74protDsc, H001K2_A1EmpID
               }
               , new Object[] {
               H001K3_A1EmpID, H001K3_A6MarcaID, H001K3_A62MarcaDsc, H001K3_n62MarcaDsc
               }
               , new Object[] {
               H001K4_A7ModeloID, H001K4_A64ModeloDsc, H001K4_n64ModeloDsc, H001K4_A1EmpID, H001K4_A6MarcaID
               }
               , new Object[] {
               H001K5_A9vendedorID, H001K5_A72vendedorDsc, H001K5_n72vendedorDsc, H001K5_A1EmpID, H001K5_A73vendedorEst, H001K5_n73vendedorEst
               }
               , new Object[] {
               H001K6_A20ProcID, H001K6_A129ProcAbre, H001K6_n129ProcAbre, H001K6_A128ProcDsc, H001K6_n128ProcDsc
               }
               , new Object[] {
               H001K7_A8VehiculoID, H001K7_A17tipOrdID, H001K7_A115OrdenEst, H001K7_n115OrdenEst, H001K7_A1EmpID, H001K7_A9vendedorID, H001K7_A117OrdenModeloID, H001K7_A26OrdenMarcaID, H001K7_A10protID, H001K7_A133OrdenProceso,
               H001K7_n133OrdenProceso, H001K7_A121VendedorSiglas, H001K7_n121VendedorSiglas, H001K7_A104tipOrdDsc, H001K7_n104tipOrdDsc, H001K7_A69VehiculoChasis, H001K7_n69VehiculoChasis, H001K7_A68VehiculoPlaca, H001K7_n68VehiculoPlaca, H001K7_A22OrdenID,
               H001K7_A57ClienteDsc, H001K7_n57ClienteDsc, H001K7_A106facturaNro, H001K7_n106facturaNro, H001K7_A119OrdenFch, H001K7_n119OrdenFch, H001K7_A24OrdenPeriodo, H001K7_A25OrdenAnio, H001K7_A5ClienteID
               }
               , new Object[] {
               H001K8_A8VehiculoID, H001K8_A17tipOrdID, H001K8_A115OrdenEst, H001K8_n115OrdenEst, H001K8_A9vendedorID, H001K8_A117OrdenModeloID, H001K8_A26OrdenMarcaID, H001K8_A5ClienteID, H001K8_A1EmpID, H001K8_A10protID,
               H001K8_A133OrdenProceso, H001K8_n133OrdenProceso, H001K8_A121VendedorSiglas, H001K8_n121VendedorSiglas, H001K8_A104tipOrdDsc, H001K8_n104tipOrdDsc, H001K8_A69VehiculoChasis, H001K8_n69VehiculoChasis, H001K8_A68VehiculoPlaca, H001K8_n68VehiculoPlaca,
               H001K8_A22OrdenID, H001K8_A57ClienteDsc, H001K8_n57ClienteDsc, H001K8_A106facturaNro, H001K8_n106facturaNro, H001K8_A119OrdenFch, H001K8_n119OrdenFch, H001K8_A24OrdenPeriodo, H001K8_A25OrdenAnio
               }
               , new Object[] {
               H001K9_AGRID_nRecordCount
               }
               , new Object[] {
               H001K10_AGRIDINAC_nRecordCount
               }
               , new Object[] {
               H001K11_A20ProcID, H001K11_A129ProcAbre, H001K11_n129ProcAbre, H001K11_A128ProcDsc, H001K11_n128ProcDsc
               }
               , new Object[] {
               H001K12_A1EmpID, H001K12_A10protID, H001K12_A74protDsc, H001K12_n74protDsc
               }
               , new Object[] {
               H001K13_A20ProcID, H001K13_A129ProcAbre, H001K13_n129ProcAbre, H001K13_A128ProcDsc, H001K13_n128ProcDsc
               }
               , new Object[] {
               H001K14_A1EmpID, H001K14_A10protID, H001K14_A74protDsc, H001K14_n74protDsc
               }
               , new Object[] {
               H001K15_A20ProcID, H001K15_A129ProcAbre, H001K15_n129ProcAbre, H001K15_A128ProcDsc, H001K15_n128ProcDsc
               }
               , new Object[] {
               H001K16_A1EmpID, H001K16_A10protID, H001K16_A74protDsc, H001K16_n74protDsc
               }
               , new Object[] {
               H001K17_A20ProcID, H001K17_A129ProcAbre, H001K17_n129ProcAbre, H001K17_A128ProcDsc, H001K17_n128ProcDsc
               }
               , new Object[] {
               H001K18_A1EmpID, H001K18_A10protID, H001K18_A74protDsc, H001K18_n74protDsc
               }
            }
         );
         AV47Pgmname = "WWOrdenProduccion";
         /* GeneXus formulas. */
         AV47Pgmname = "WWOrdenProduccion";
         context.Gx_err = 0;
      }

      private short AV13empID ;
      private short AV6ageID ;
      private short wcpOAV13empID ;
      private short wcpOAV6ageID ;
      private short nGotPars ;
      private short GxWebError ;
      private short AV22marca ;
      private short nRC_GXsfl_66 ;
      private short nGXsfl_66_idx=1 ;
      private short nRC_GXsfl_90 ;
      private short GRID_nEOF ;
      private short GRIDINAC_nEOF ;
      private short AV7anio ;
      private short AV28period ;
      private short AV26ordenID ;
      private short AV25modelo ;
      private short AV38vendedor ;
      private short A5ClienteID ;
      private short nGXsfl_90_idx=1 ;
      private short initialized ;
      private short nGXWrapped ;
      private short A1EmpID ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short A25OrdenAnio ;
      private short A24OrdenPeriodo ;
      private short A22OrdenID ;
      private short A10protID ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short subGridinac_Backcolorstyle ;
      private short subGridinac_Titlebackstyle ;
      private short subGridinac_Allowselection ;
      private short subGridinac_Allowhovering ;
      private short subGridinac_Allowcollapsing ;
      private short subGridinac_Collapsed ;
      private short AV39year ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short A26OrdenMarcaID ;
      private short A117OrdenModeloID ;
      private short A9vendedorID ;
      private short A8VehiculoID ;
      private short A17tipOrdID ;
      private short AV9day ;
      private short AV41currentYear ;
      private short AV43fin ;
      private short AV42i ;
      private short subGrid_Backstyle ;
      private short subGridinac_Backstyle ;
      private short wbTemp ;
      private int edtavUpdate_Visible ;
      private int divTbbusavanced_Visible ;
      private int subGrid_Rows ;
      private int subGridinac_Rows ;
      private int Tabgridop_Pagecount ;
      private int edtavOrdenid_Enabled ;
      private int edtavClientedsc_Enabled ;
      private int edtavVehiculoplaca_Enabled ;
      private int edtavVehiculochasis_Enabled ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int A106facturaNro ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int subGridinac_Titlebackcolor ;
      private int subGridinac_Allbackcolor ;
      private int subGridinac_Selectedindex ;
      private int subGridinac_Selectioncolor ;
      private int subGridinac_Hoveringcolor ;
      private int edtavYear_Enabled ;
      private int edtavYear_Visible ;
      private int gxdynajaxindex ;
      private int subGrid_Islastpage ;
      private int subGridinac_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int GXPagingFrom3 ;
      private int GXPagingTo3 ;
      private int AV17GridPageCount ;
      private int AV40GridPageCount1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavEmails_Enabled ;
      private int edtavEmails_Visible ;
      private int subGridinac_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long GRIDINAC_nFirstRecordOnPage ;
      private long GRID_nCurrentRecord ;
      private long GRIDINAC_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private long GRIDINAC_nRecordCount ;
      private String AV34UserCod ;
      private String wcpOAV34UserCod ;
      private String edtavEmails_Tooltiptext ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavDelete_Tooltiptext ;
      private String edtavDisplay_Tooltiptext ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_66_idx="0001" ;
      private String edtavEmails_Internalname ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String edtavDisplay_Internalname ;
      private String AV8ClienteDsc ;
      private String AV47Pgmname ;
      private String GXKey ;
      private String sGXsfl_90_idx="0001" ;
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
      private String cmbavAnio_Internalname ;
      private String TempTags ;
      private String cmbavAnio_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtninsert_Internalname ;
      private String bttBtninsert_Jsonclick ;
      private String bttBtnbusavanzada_Internalname ;
      private String bttBtnbusavanzada_Caption ;
      private String bttBtnbusavanzada_Jsonclick ;
      private String bttBtnbusavanzada_Tooltiptext ;
      private String cmbavPeriod_Internalname ;
      private String cmbavPeriod_Jsonclick ;
      private String edtavOrdenid_Internalname ;
      private String edtavOrdenid_Jsonclick ;
      private String edtavClientedsc_Internalname ;
      private String edtavClientedsc_Jsonclick ;
      private String edtavVehiculoplaca_Internalname ;
      private String edtavVehiculoplaca_Jsonclick ;
      private String edtavVehiculochasis_Internalname ;
      private String edtavVehiculochasis_Jsonclick ;
      private String divTbbusavanced_Internalname ;
      private String dynavMarca_Internalname ;
      private String dynavMarca_Jsonclick ;
      private String dynavModelo_Internalname ;
      private String dynavModelo_Jsonclick ;
      private String dynavVendedor_Internalname ;
      private String dynavVendedor_Jsonclick ;
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
      private String edtavUpdate_Link ;
      private String edtavDisplay_Link ;
      private String edtavDelete_Link ;
      private String lblTabinact_title_Internalname ;
      private String lblTabinact_title_Jsonclick ;
      private String divTabpage2table_Internalname ;
      private String subGridinac_Internalname ;
      private String subGridinac_Class ;
      private String subGridinac_Linesclass ;
      private String subGridinac_Header ;
      private String edtavYear_Internalname ;
      private String edtavYear_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtOrdenAnio_Internalname ;
      private String edtOrdenPeriodo_Internalname ;
      private String edtOrdenFch_Internalname ;
      private String edtfacturaNro_Internalname ;
      private String edtClienteDsc_Internalname ;
      private String edtOrdenID_Internalname ;
      private String edtVehiculoPlaca_Internalname ;
      private String edtVehiculoChasis_Internalname ;
      private String edttipOrdDsc_Internalname ;
      private String edtVendedorSiglas_Internalname ;
      private String dynOrdenProceso_Internalname ;
      private String dynprotID_Internalname ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String lV8ClienteDsc ;
      private String A115OrdenEst ;
      private String AV29rolUser ;
      private String GXt_char1 ;
      private String sGXsfl_66_fel_idx="0001" ;
      private String ROClassString ;
      private String edtOrdenAnio_Jsonclick ;
      private String edtOrdenPeriodo_Jsonclick ;
      private String edtOrdenFch_Jsonclick ;
      private String edtfacturaNro_Jsonclick ;
      private String edtClienteDsc_Jsonclick ;
      private String edtOrdenID_Jsonclick ;
      private String edtVehiculoPlaca_Jsonclick ;
      private String edtVehiculoChasis_Jsonclick ;
      private String edttipOrdDsc_Jsonclick ;
      private String edtVendedorSiglas_Jsonclick ;
      private String GXCCtl ;
      private String dynOrdenProceso_Jsonclick ;
      private String dynprotID_Jsonclick ;
      private String sImgUrl ;
      private String edtavEmails_Jsonclick ;
      private String Tabgridop_Internalname ;
      private DateTime A119OrdenFch ;
      private DateTime AV16fechaAux ;
      private DateTime AV14fchDesd ;
      private DateTime AV15fchHast ;
      private bool entryPointCalled ;
      private bool bGXsfl_66_Refreshing=false ;
      private bool toggleJsOutput ;
      private bool Tabgridop_Historymanagement ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n119OrdenFch ;
      private bool n106facturaNro ;
      private bool n57ClienteDsc ;
      private bool n68VehiculoPlaca ;
      private bool n69VehiculoChasis ;
      private bool n104tipOrdDsc ;
      private bool n121VendedorSiglas ;
      private bool n133OrdenProceso ;
      private bool gxdyncontrolsrefreshing ;
      private bool n115OrdenEst ;
      private bool bGXsfl_90_Refreshing=false ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV33Update_IsBlob ;
      private bool AV12emails_IsBlob ;
      private bool AV11display_IsBlob ;
      private bool AV10Delete_IsBlob ;
      private String AV24mensj ;
      private String AV37vehiculoPlaca ;
      private String AV36vehiculoChasis ;
      private String AV27OrdenProceso ;
      private String A68VehiculoPlaca ;
      private String A69VehiculoChasis ;
      private String A121VendedorSiglas ;
      private String A133OrdenProceso ;
      private String AV48Update_GXI ;
      private String AV46Emails_GXI ;
      private String AV50Display_GXI ;
      private String AV49Delete_GXI ;
      private String lV37vehiculoPlaca ;
      private String lV36vehiculoChasis ;
      private String AV12emails ;
      private String AV33Update ;
      private String AV10Delete ;
      private String AV11display ;
      private IGxSession AV30Session ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebGrid GridContainer ;
      private GXWebGrid GridinacContainer ;
      private GXWebRow GridRow ;
      private GXWebRow GridinacRow ;
      private GXWebColumn GridColumn ;
      private GXWebColumn GridinacColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavAnio ;
      private GXCombobox cmbavPeriod ;
      private GXCombobox dynavMarca ;
      private GXCombobox dynavModelo ;
      private GXCombobox dynavVendedor ;
      private GXCombobox dynavOrdenproceso ;
      private GXCombobox dynOrdenProceso ;
      private GXCombobox dynprotID ;
      private IDataStoreProvider pr_default ;
      private short[] H001K2_A10protID ;
      private String[] H001K2_A74protDsc ;
      private bool[] H001K2_n74protDsc ;
      private short[] H001K2_A1EmpID ;
      private short[] H001K3_A1EmpID ;
      private short[] H001K3_A6MarcaID ;
      private String[] H001K3_A62MarcaDsc ;
      private bool[] H001K3_n62MarcaDsc ;
      private short[] H001K4_A7ModeloID ;
      private String[] H001K4_A64ModeloDsc ;
      private bool[] H001K4_n64ModeloDsc ;
      private short[] H001K4_A1EmpID ;
      private short[] H001K4_A6MarcaID ;
      private short[] H001K5_A9vendedorID ;
      private String[] H001K5_A72vendedorDsc ;
      private bool[] H001K5_n72vendedorDsc ;
      private short[] H001K5_A1EmpID ;
      private String[] H001K5_A73vendedorEst ;
      private bool[] H001K5_n73vendedorEst ;
      private short[] H001K6_A20ProcID ;
      private String[] H001K6_A129ProcAbre ;
      private bool[] H001K6_n129ProcAbre ;
      private String[] H001K6_A128ProcDsc ;
      private bool[] H001K6_n128ProcDsc ;
      private short[] H001K7_A8VehiculoID ;
      private short[] H001K7_A17tipOrdID ;
      private String[] H001K7_A115OrdenEst ;
      private bool[] H001K7_n115OrdenEst ;
      private short[] H001K7_A1EmpID ;
      private short[] H001K7_A9vendedorID ;
      private short[] H001K7_A117OrdenModeloID ;
      private short[] H001K7_A26OrdenMarcaID ;
      private short[] H001K7_A10protID ;
      private String[] H001K7_A133OrdenProceso ;
      private bool[] H001K7_n133OrdenProceso ;
      private String[] H001K7_A121VendedorSiglas ;
      private bool[] H001K7_n121VendedorSiglas ;
      private String[] H001K7_A104tipOrdDsc ;
      private bool[] H001K7_n104tipOrdDsc ;
      private String[] H001K7_A69VehiculoChasis ;
      private bool[] H001K7_n69VehiculoChasis ;
      private String[] H001K7_A68VehiculoPlaca ;
      private bool[] H001K7_n68VehiculoPlaca ;
      private short[] H001K7_A22OrdenID ;
      private String[] H001K7_A57ClienteDsc ;
      private bool[] H001K7_n57ClienteDsc ;
      private int[] H001K7_A106facturaNro ;
      private bool[] H001K7_n106facturaNro ;
      private DateTime[] H001K7_A119OrdenFch ;
      private bool[] H001K7_n119OrdenFch ;
      private short[] H001K7_A24OrdenPeriodo ;
      private short[] H001K7_A25OrdenAnio ;
      private short[] H001K7_A5ClienteID ;
      private short[] H001K8_A8VehiculoID ;
      private short[] H001K8_A17tipOrdID ;
      private String[] H001K8_A115OrdenEst ;
      private bool[] H001K8_n115OrdenEst ;
      private short[] H001K8_A9vendedorID ;
      private short[] H001K8_A117OrdenModeloID ;
      private short[] H001K8_A26OrdenMarcaID ;
      private short[] H001K8_A5ClienteID ;
      private short[] H001K8_A1EmpID ;
      private short[] H001K8_A10protID ;
      private String[] H001K8_A133OrdenProceso ;
      private bool[] H001K8_n133OrdenProceso ;
      private String[] H001K8_A121VendedorSiglas ;
      private bool[] H001K8_n121VendedorSiglas ;
      private String[] H001K8_A104tipOrdDsc ;
      private bool[] H001K8_n104tipOrdDsc ;
      private String[] H001K8_A69VehiculoChasis ;
      private bool[] H001K8_n69VehiculoChasis ;
      private String[] H001K8_A68VehiculoPlaca ;
      private bool[] H001K8_n68VehiculoPlaca ;
      private short[] H001K8_A22OrdenID ;
      private String[] H001K8_A57ClienteDsc ;
      private bool[] H001K8_n57ClienteDsc ;
      private int[] H001K8_A106facturaNro ;
      private bool[] H001K8_n106facturaNro ;
      private DateTime[] H001K8_A119OrdenFch ;
      private bool[] H001K8_n119OrdenFch ;
      private short[] H001K8_A24OrdenPeriodo ;
      private short[] H001K8_A25OrdenAnio ;
      private long[] H001K9_AGRID_nRecordCount ;
      private long[] H001K10_AGRIDINAC_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short[] H001K11_A20ProcID ;
      private String[] H001K11_A129ProcAbre ;
      private bool[] H001K11_n129ProcAbre ;
      private String[] H001K11_A128ProcDsc ;
      private bool[] H001K11_n128ProcDsc ;
      private short[] H001K12_A1EmpID ;
      private short[] H001K12_A10protID ;
      private String[] H001K12_A74protDsc ;
      private bool[] H001K12_n74protDsc ;
      private short[] H001K13_A20ProcID ;
      private String[] H001K13_A129ProcAbre ;
      private bool[] H001K13_n129ProcAbre ;
      private String[] H001K13_A128ProcDsc ;
      private bool[] H001K13_n128ProcDsc ;
      private short[] H001K14_A1EmpID ;
      private short[] H001K14_A10protID ;
      private String[] H001K14_A74protDsc ;
      private bool[] H001K14_n74protDsc ;
      private short[] H001K15_A20ProcID ;
      private String[] H001K15_A129ProcAbre ;
      private bool[] H001K15_n129ProcAbre ;
      private String[] H001K15_A128ProcDsc ;
      private bool[] H001K15_n128ProcDsc ;
      private short[] H001K16_A1EmpID ;
      private short[] H001K16_A10protID ;
      private String[] H001K16_A74protDsc ;
      private bool[] H001K16_n74protDsc ;
      private short[] H001K17_A20ProcID ;
      private String[] H001K17_A129ProcAbre ;
      private bool[] H001K17_n129ProcAbre ;
      private String[] H001K17_A128ProcDsc ;
      private bool[] H001K17_n128ProcDsc ;
      private short[] H001K18_A1EmpID ;
      private short[] H001K18_A10protID ;
      private String[] H001K18_A74protDsc ;
      private bool[] H001K18_n74protDsc ;
      private GxHttpRequest AV20HTTPRequest ;
      private SdtGridState AV18GridState ;
      private SdtGridState_FilterValue AV19GridStateFilterValue ;
      private SdtTransactionContext AV31TrnContext ;
   }

   public class wwordenproduccion__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H001K7( IGxContext context ,
                                             String AV8ClienteDsc ,
                                             String AV37vehiculoPlaca ,
                                             String AV36vehiculoChasis ,
                                             short AV26ordenID ,
                                             short AV28period ,
                                             short AV22marca ,
                                             short AV25modelo ,
                                             short AV38vendedor ,
                                             String AV27OrdenProceso ,
                                             short AV7anio ,
                                             String A57ClienteDsc ,
                                             String A68VehiculoPlaca ,
                                             String A69VehiculoChasis ,
                                             short A22OrdenID ,
                                             short A24OrdenPeriodo ,
                                             short A26OrdenMarcaID ,
                                             short A117OrdenModeloID ,
                                             short A9vendedorID ,
                                             String A133OrdenProceso ,
                                             short A25OrdenAnio ,
                                             String A115OrdenEst )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [13] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " T1.[VehiculoID], T1.[tipOrdID], T1.[OrdenEst], T1.[EmpID], T1.[vendedorID], T1.[OrdenModeloID], T1.[OrdenMarcaID], T1.[protID], T1.[OrdenProceso], T4.[VendedorSiglas], T3.[tipOrdDsc], T2.[VehiculoChasis], T2.[VehiculoPlaca], T1.[OrdenID], T5.[ClienteDsc], T1.[facturaNro], T1.[OrdenFch], T1.[OrdenPeriodo], T1.[OrdenAnio], T1.[ClienteID]";
         sFromString = " FROM (((([OrdenProduccion] T1 WITH (NOLOCK) INNER JOIN [Vehiculos] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[VehiculoID] = T1.[VehiculoID]) INNER JOIN [TipoOrdenPro] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[tipOrdID] = T1.[tipOrdID]) INNER JOIN [Vendedor] T4 WITH (NOLOCK) ON T4.[EmpID] = T1.[EmpID] AND T4.[vendedorID] = T1.[vendedorID]) INNER JOIN [Clientes] T5 WITH (NOLOCK) ON T5.[EmpID] = T1.[EmpID] AND T5.[ClienteID] = T1.[ClienteID])";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (T1.[OrdenEst] = 'A')";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8ClienteDsc)) )
         {
            sWhereString = sWhereString + " and (T5.[ClienteDsc] like '%' + @lV8ClienteDsc + '%')";
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV37vehiculoPlaca)) )
         {
            sWhereString = sWhereString + " and (T2.[VehiculoPlaca] like '%' + @lV37vehiculoPlaca + '%')";
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV36vehiculoChasis)) )
         {
            sWhereString = sWhereString + " and (T2.[VehiculoChasis] like '%' + @lV36vehiculoChasis + '%')";
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ! (0==AV26ordenID) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenID] = @AV26ordenID)";
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( ! (0==AV28period) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenPeriodo] = @AV28period)";
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( ! (0==AV22marca) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenMarcaID] = @AV22marca)";
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( ! (0==AV25modelo) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenModeloID] = @AV25modelo)";
         }
         else
         {
            GXv_int2[6] = 1;
         }
         if ( ! (0==AV38vendedor) )
         {
            sWhereString = sWhereString + " and (T1.[vendedorID] = @AV38vendedor)";
         }
         else
         {
            GXv_int2[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV27OrdenProceso)) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenProceso] = @AV27OrdenProceso)";
         }
         else
         {
            GXv_int2[8] = 1;
         }
         if ( ! (0==AV7anio) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenAnio] = @AV7anio)";
         }
         else
         {
            GXv_int2[9] = 1;
         }
         sOrderString = sOrderString + " ORDER BY T1.[OrdenID], T1.[OrdenFch]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_H001K8( IGxContext context ,
                                             String AV8ClienteDsc ,
                                             String AV37vehiculoPlaca ,
                                             String AV36vehiculoChasis ,
                                             short AV26ordenID ,
                                             short AV28period ,
                                             short AV22marca ,
                                             short AV25modelo ,
                                             short AV38vendedor ,
                                             String AV27OrdenProceso ,
                                             short AV7anio ,
                                             String A57ClienteDsc ,
                                             String A68VehiculoPlaca ,
                                             String A69VehiculoChasis ,
                                             short A22OrdenID ,
                                             short A24OrdenPeriodo ,
                                             short A26OrdenMarcaID ,
                                             short A117OrdenModeloID ,
                                             short A9vendedorID ,
                                             String A133OrdenProceso ,
                                             short A25OrdenAnio ,
                                             String A115OrdenEst )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [13] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " T1.[VehiculoID], T1.[tipOrdID], T1.[OrdenEst], T1.[vendedorID], T1.[OrdenModeloID], T1.[OrdenMarcaID], T1.[ClienteID], T1.[EmpID], T1.[protID], T1.[OrdenProceso], T4.[VendedorSiglas], T5.[tipOrdDsc], T3.[VehiculoChasis], T3.[VehiculoPlaca], T1.[OrdenID], T2.[ClienteDsc], T1.[facturaNro], T1.[OrdenFch], T1.[OrdenPeriodo], T1.[OrdenAnio]";
         sFromString = " FROM (((([OrdenProduccion] T1 WITH (NOLOCK) INNER JOIN [Clientes] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[ClienteID] = T1.[ClienteID]) INNER JOIN [Vehiculos] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[VehiculoID] = T1.[VehiculoID]) INNER JOIN [Vendedor] T4 WITH (NOLOCK) ON T4.[EmpID] = T1.[EmpID] AND T4.[vendedorID] = T1.[vendedorID]) INNER JOIN [TipoOrdenPro] T5 WITH (NOLOCK) ON T5.[EmpID] = T1.[EmpID] AND T5.[tipOrdID] = T1.[tipOrdID])";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (T1.[OrdenEst] = 'I')";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8ClienteDsc)) )
         {
            sWhereString = sWhereString + " and (T2.[ClienteDsc] like '%' + @lV8ClienteDsc + '%')";
         }
         else
         {
            GXv_int4[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV37vehiculoPlaca)) )
         {
            sWhereString = sWhereString + " and (T3.[VehiculoPlaca] like '%' + @lV37vehiculoPlaca + '%')";
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV36vehiculoChasis)) )
         {
            sWhereString = sWhereString + " and (T3.[VehiculoChasis] like '%' + @lV36vehiculoChasis + '%')";
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( ! (0==AV26ordenID) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenID] = @AV26ordenID)";
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( ! (0==AV28period) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenPeriodo] = @AV28period)";
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( ! (0==AV22marca) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenMarcaID] = @AV22marca)";
         }
         else
         {
            GXv_int4[5] = 1;
         }
         if ( ! (0==AV25modelo) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenModeloID] = @AV25modelo)";
         }
         else
         {
            GXv_int4[6] = 1;
         }
         if ( ! (0==AV38vendedor) )
         {
            sWhereString = sWhereString + " and (T1.[vendedorID] = @AV38vendedor)";
         }
         else
         {
            GXv_int4[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV27OrdenProceso)) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenProceso] = @AV27OrdenProceso)";
         }
         else
         {
            GXv_int4[8] = 1;
         }
         if ( ! (0==AV7anio) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenAnio] = @AV7anio)";
         }
         else
         {
            GXv_int4[9] = 1;
         }
         sOrderString = sOrderString + " ORDER BY T1.[OrdenID], T1.[OrdenFch]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom3" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo3" + " > 0 THEN " + "@GXPagingTo3" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object5[0] = scmdbuf;
         GXv_Object5[1] = GXv_int4;
         return GXv_Object5 ;
      }

      protected Object[] conditional_H001K9( IGxContext context ,
                                             String AV8ClienteDsc ,
                                             String AV37vehiculoPlaca ,
                                             String AV36vehiculoChasis ,
                                             short AV26ordenID ,
                                             short AV28period ,
                                             short AV22marca ,
                                             short AV25modelo ,
                                             short AV38vendedor ,
                                             String AV27OrdenProceso ,
                                             short AV7anio ,
                                             String A57ClienteDsc ,
                                             String A68VehiculoPlaca ,
                                             String A69VehiculoChasis ,
                                             short A22OrdenID ,
                                             short A24OrdenPeriodo ,
                                             short A26OrdenMarcaID ,
                                             short A117OrdenModeloID ,
                                             short A9vendedorID ,
                                             String A133OrdenProceso ,
                                             short A25OrdenAnio ,
                                             String A115OrdenEst )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int6 ;
         GXv_int6 = new short [10] ;
         Object[] GXv_Object7 ;
         GXv_Object7 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM (((([OrdenProduccion] T1 WITH (NOLOCK) INNER JOIN [Vehiculos] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[VehiculoID] = T1.[VehiculoID]) INNER JOIN [TipoOrdenPro] T5 WITH (NOLOCK) ON T5.[EmpID] = T1.[EmpID] AND T5.[tipOrdID] = T1.[tipOrdID]) INNER JOIN [Vendedor] T4 WITH (NOLOCK) ON T4.[EmpID] = T1.[EmpID] AND T4.[vendedorID] = T1.[vendedorID]) INNER JOIN [Clientes] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[ClienteID] = T1.[ClienteID])";
         scmdbuf = scmdbuf + " WHERE (T1.[OrdenEst] = 'A')";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8ClienteDsc)) )
         {
            sWhereString = sWhereString + " and (T2.[ClienteDsc] like '%' + @lV8ClienteDsc + '%')";
         }
         else
         {
            GXv_int6[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV37vehiculoPlaca)) )
         {
            sWhereString = sWhereString + " and (T3.[VehiculoPlaca] like '%' + @lV37vehiculoPlaca + '%')";
         }
         else
         {
            GXv_int6[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV36vehiculoChasis)) )
         {
            sWhereString = sWhereString + " and (T3.[VehiculoChasis] like '%' + @lV36vehiculoChasis + '%')";
         }
         else
         {
            GXv_int6[2] = 1;
         }
         if ( ! (0==AV26ordenID) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenID] = @AV26ordenID)";
         }
         else
         {
            GXv_int6[3] = 1;
         }
         if ( ! (0==AV28period) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenPeriodo] = @AV28period)";
         }
         else
         {
            GXv_int6[4] = 1;
         }
         if ( ! (0==AV22marca) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenMarcaID] = @AV22marca)";
         }
         else
         {
            GXv_int6[5] = 1;
         }
         if ( ! (0==AV25modelo) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenModeloID] = @AV25modelo)";
         }
         else
         {
            GXv_int6[6] = 1;
         }
         if ( ! (0==AV38vendedor) )
         {
            sWhereString = sWhereString + " and (T1.[vendedorID] = @AV38vendedor)";
         }
         else
         {
            GXv_int6[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV27OrdenProceso)) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenProceso] = @AV27OrdenProceso)";
         }
         else
         {
            GXv_int6[8] = 1;
         }
         if ( ! (0==AV7anio) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenAnio] = @AV7anio)";
         }
         else
         {
            GXv_int6[9] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + "";
         GXv_Object7[0] = scmdbuf;
         GXv_Object7[1] = GXv_int6;
         return GXv_Object7 ;
      }

      protected Object[] conditional_H001K10( IGxContext context ,
                                              String AV8ClienteDsc ,
                                              String AV37vehiculoPlaca ,
                                              String AV36vehiculoChasis ,
                                              short AV26ordenID ,
                                              short AV28period ,
                                              short AV22marca ,
                                              short AV25modelo ,
                                              short AV38vendedor ,
                                              String AV27OrdenProceso ,
                                              short AV7anio ,
                                              String A57ClienteDsc ,
                                              String A68VehiculoPlaca ,
                                              String A69VehiculoChasis ,
                                              short A22OrdenID ,
                                              short A24OrdenPeriodo ,
                                              short A26OrdenMarcaID ,
                                              short A117OrdenModeloID ,
                                              short A9vendedorID ,
                                              String A133OrdenProceso ,
                                              short A25OrdenAnio ,
                                              String A115OrdenEst )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int8 ;
         GXv_int8 = new short [10] ;
         Object[] GXv_Object9 ;
         GXv_Object9 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM (((([OrdenProduccion] T1 WITH (NOLOCK) INNER JOIN [Clientes] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[ClienteID] = T1.[ClienteID]) INNER JOIN [Vehiculos] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[VehiculoID] = T1.[VehiculoID]) INNER JOIN [Vendedor] T4 WITH (NOLOCK) ON T4.[EmpID] = T1.[EmpID] AND T4.[vendedorID] = T1.[vendedorID]) INNER JOIN [TipoOrdenPro] T5 WITH (NOLOCK) ON T5.[EmpID] = T1.[EmpID] AND T5.[tipOrdID] = T1.[tipOrdID])";
         scmdbuf = scmdbuf + " WHERE (T1.[OrdenEst] = 'I')";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8ClienteDsc)) )
         {
            sWhereString = sWhereString + " and (T2.[ClienteDsc] like '%' + @lV8ClienteDsc + '%')";
         }
         else
         {
            GXv_int8[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV37vehiculoPlaca)) )
         {
            sWhereString = sWhereString + " and (T3.[VehiculoPlaca] like '%' + @lV37vehiculoPlaca + '%')";
         }
         else
         {
            GXv_int8[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV36vehiculoChasis)) )
         {
            sWhereString = sWhereString + " and (T3.[VehiculoChasis] like '%' + @lV36vehiculoChasis + '%')";
         }
         else
         {
            GXv_int8[2] = 1;
         }
         if ( ! (0==AV26ordenID) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenID] = @AV26ordenID)";
         }
         else
         {
            GXv_int8[3] = 1;
         }
         if ( ! (0==AV28period) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenPeriodo] = @AV28period)";
         }
         else
         {
            GXv_int8[4] = 1;
         }
         if ( ! (0==AV22marca) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenMarcaID] = @AV22marca)";
         }
         else
         {
            GXv_int8[5] = 1;
         }
         if ( ! (0==AV25modelo) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenModeloID] = @AV25modelo)";
         }
         else
         {
            GXv_int8[6] = 1;
         }
         if ( ! (0==AV38vendedor) )
         {
            sWhereString = sWhereString + " and (T1.[vendedorID] = @AV38vendedor)";
         }
         else
         {
            GXv_int8[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV27OrdenProceso)) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenProceso] = @AV27OrdenProceso)";
         }
         else
         {
            GXv_int8[8] = 1;
         }
         if ( ! (0==AV7anio) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenAnio] = @AV7anio)";
         }
         else
         {
            GXv_int8[9] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + "";
         GXv_Object9[0] = scmdbuf;
         GXv_Object9[1] = GXv_int8;
         return GXv_Object9 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 5 :
                     return conditional_H001K7(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (short)dynConstraints[5] , (short)dynConstraints[6] , (short)dynConstraints[7] , (String)dynConstraints[8] , (short)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (short)dynConstraints[13] , (short)dynConstraints[14] , (short)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (String)dynConstraints[18] , (short)dynConstraints[19] , (String)dynConstraints[20] );
               case 6 :
                     return conditional_H001K8(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (short)dynConstraints[5] , (short)dynConstraints[6] , (short)dynConstraints[7] , (String)dynConstraints[8] , (short)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (short)dynConstraints[13] , (short)dynConstraints[14] , (short)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (String)dynConstraints[18] , (short)dynConstraints[19] , (String)dynConstraints[20] );
               case 7 :
                     return conditional_H001K9(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (short)dynConstraints[5] , (short)dynConstraints[6] , (short)dynConstraints[7] , (String)dynConstraints[8] , (short)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (short)dynConstraints[13] , (short)dynConstraints[14] , (short)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (String)dynConstraints[18] , (short)dynConstraints[19] , (String)dynConstraints[20] );
               case 8 :
                     return conditional_H001K10(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (short)dynConstraints[5] , (short)dynConstraints[6] , (short)dynConstraints[7] , (String)dynConstraints[8] , (short)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (short)dynConstraints[13] , (short)dynConstraints[14] , (short)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (String)dynConstraints[18] , (short)dynConstraints[19] , (String)dynConstraints[20] );
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
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH001K2 ;
          prmH001K2 = new Object[] {
          new Object[] {"@AV13empID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH001K3 ;
          prmH001K3 = new Object[] {
          } ;
          Object[] prmH001K4 ;
          prmH001K4 = new Object[] {
          new Object[] {"@AV13empID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV22marca",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH001K5 ;
          prmH001K5 = new Object[] {
          new Object[] {"@AV13empID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH001K6 ;
          prmH001K6 = new Object[] {
          } ;
          Object[] prmH001K11 ;
          prmH001K11 = new Object[] {
          } ;
          Object[] prmH001K12 ;
          prmH001K12 = new Object[] {
          } ;
          Object[] prmH001K13 ;
          prmH001K13 = new Object[] {
          } ;
          Object[] prmH001K14 ;
          prmH001K14 = new Object[] {
          } ;
          Object[] prmH001K15 ;
          prmH001K15 = new Object[] {
          } ;
          Object[] prmH001K16 ;
          prmH001K16 = new Object[] {
          } ;
          Object[] prmH001K17 ;
          prmH001K17 = new Object[] {
          } ;
          Object[] prmH001K18 ;
          prmH001K18 = new Object[] {
          } ;
          Object[] prmH001K7 ;
          prmH001K7 = new Object[] {
          new Object[] {"@lV8ClienteDsc",SqlDbType.Char,50,0} ,
          new Object[] {"@lV37vehiculoPlaca",SqlDbType.VarChar,15,0} ,
          new Object[] {"@lV36vehiculoChasis",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV26ordenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV28period",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV22marca",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV25modelo",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV38vendedor",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV27OrdenProceso",SqlDbType.VarChar,5,0} ,
          new Object[] {"@AV7anio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH001K8 ;
          prmH001K8 = new Object[] {
          new Object[] {"@lV8ClienteDsc",SqlDbType.Char,50,0} ,
          new Object[] {"@lV37vehiculoPlaca",SqlDbType.VarChar,15,0} ,
          new Object[] {"@lV36vehiculoChasis",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV26ordenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV28period",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV22marca",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV25modelo",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV38vendedor",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV27OrdenProceso",SqlDbType.VarChar,5,0} ,
          new Object[] {"@AV7anio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GXPagingFrom3",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo3",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo3",SqlDbType.Int,9,0}
          } ;
          Object[] prmH001K9 ;
          prmH001K9 = new Object[] {
          new Object[] {"@lV8ClienteDsc",SqlDbType.Char,50,0} ,
          new Object[] {"@lV37vehiculoPlaca",SqlDbType.VarChar,15,0} ,
          new Object[] {"@lV36vehiculoChasis",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV26ordenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV28period",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV22marca",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV25modelo",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV38vendedor",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV27OrdenProceso",SqlDbType.VarChar,5,0} ,
          new Object[] {"@AV7anio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH001K10 ;
          prmH001K10 = new Object[] {
          new Object[] {"@lV8ClienteDsc",SqlDbType.Char,50,0} ,
          new Object[] {"@lV37vehiculoPlaca",SqlDbType.VarChar,15,0} ,
          new Object[] {"@lV36vehiculoChasis",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV26ordenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV28period",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV22marca",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV25modelo",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV38vendedor",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV27OrdenProceso",SqlDbType.VarChar,5,0} ,
          new Object[] {"@AV7anio",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001K2", "SELECT [protID], [protDsc], [EmpID] FROM [Prototipo] WITH (NOLOCK) WHERE [EmpID] = @AV13empID ORDER BY [protDsc] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001K2,0,0,true,false )
             ,new CursorDef("H001K3", "SELECT [EmpID], [MarcaID], [MarcaDsc] FROM [Marca] WITH (NOLOCK) ORDER BY [MarcaDsc] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001K3,0,0,true,false )
             ,new CursorDef("H001K4", "SELECT [ModeloID], [ModeloDsc], [EmpID], [MarcaID] FROM [MarcaModelo] WITH (NOLOCK) WHERE ([EmpID] = @AV13empID) AND ([MarcaID] = @AV22marca) ORDER BY [ModeloDsc] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001K4,0,0,true,false )
             ,new CursorDef("H001K5", "SELECT [vendedorID], [vendedorDsc], [EmpID], [vendedorEst] FROM [Vendedor] WITH (NOLOCK) WHERE ([EmpID] = @AV13empID) AND ([vendedorEst] = 'A') ORDER BY [vendedorDsc] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001K5,0,0,true,false )
             ,new CursorDef("H001K6", "SELECT [ProcID], [ProcAbre], [ProcDsc] FROM [Procesos] WITH (NOLOCK) ORDER BY [ProcDsc] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001K6,0,0,true,false )
             ,new CursorDef("H001K7", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001K7,11,0,true,false )
             ,new CursorDef("H001K8", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001K8,11,0,true,false )
             ,new CursorDef("H001K9", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001K9,1,0,true,false )
             ,new CursorDef("H001K10", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001K10,1,0,true,false )
             ,new CursorDef("H001K11", "SELECT [ProcID], [ProcAbre], [ProcDsc] FROM [Procesos] WITH (NOLOCK) ORDER BY [ProcDsc] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001K11,0,0,true,false )
             ,new CursorDef("H001K12", "SELECT [EmpID], [protID], [protDsc] FROM [Prototipo] WITH (NOLOCK) ORDER BY [protDsc] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001K12,0,0,true,false )
             ,new CursorDef("H001K13", "SELECT [ProcID], [ProcAbre], [ProcDsc] FROM [Procesos] WITH (NOLOCK) ORDER BY [ProcDsc] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001K13,0,0,true,false )
             ,new CursorDef("H001K14", "SELECT [EmpID], [protID], [protDsc] FROM [Prototipo] WITH (NOLOCK) ORDER BY [protDsc] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001K14,0,0,true,false )
             ,new CursorDef("H001K15", "SELECT [ProcID], [ProcAbre], [ProcDsc] FROM [Procesos] WITH (NOLOCK) ORDER BY [ProcDsc] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001K15,0,0,true,false )
             ,new CursorDef("H001K16", "SELECT [EmpID], [protID], [protDsc] FROM [Prototipo] WITH (NOLOCK) ORDER BY [protDsc] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001K16,0,0,true,false )
             ,new CursorDef("H001K17", "SELECT [ProcID], [ProcAbre], [ProcDsc] FROM [Procesos] WITH (NOLOCK) ORDER BY [ProcDsc] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001K17,0,0,true,false )
             ,new CursorDef("H001K18", "SELECT [EmpID], [protID], [protDsc] FROM [Prototipo] WITH (NOLOCK) ORDER BY [protDsc] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001K18,0,0,true,false )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((String[]) buf[4])[0] = rslt.getString(4, 1) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 40) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                ((short[]) buf[7])[0] = rslt.getShort(7) ;
                ((short[]) buf[8])[0] = rslt.getShort(8) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(9);
                ((String[]) buf[11])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(10);
                ((String[]) buf[13])[0] = rslt.getString(11, 40) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(11);
                ((String[]) buf[15])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(12);
                ((String[]) buf[17])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(13);
                ((short[]) buf[19])[0] = rslt.getShort(14) ;
                ((String[]) buf[20])[0] = rslt.getString(15, 50) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(15);
                ((int[]) buf[22])[0] = rslt.getInt(16) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(16);
                ((DateTime[]) buf[24])[0] = rslt.getGXDate(17) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(17);
                ((short[]) buf[26])[0] = rslt.getShort(18) ;
                ((short[]) buf[27])[0] = rslt.getShort(19) ;
                ((short[]) buf[28])[0] = rslt.getShort(20) ;
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                ((short[]) buf[7])[0] = rslt.getShort(7) ;
                ((short[]) buf[8])[0] = rslt.getShort(8) ;
                ((short[]) buf[9])[0] = rslt.getShort(9) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(10);
                ((String[]) buf[12])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(11);
                ((String[]) buf[14])[0] = rslt.getString(12, 40) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(12);
                ((String[]) buf[16])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(13);
                ((String[]) buf[18])[0] = rslt.getVarchar(14) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(14);
                ((short[]) buf[20])[0] = rslt.getShort(15) ;
                ((String[]) buf[21])[0] = rslt.getString(16, 50) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(16);
                ((int[]) buf[23])[0] = rslt.getInt(17) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(17);
                ((DateTime[]) buf[25])[0] = rslt.getGXDate(18) ;
                ((bool[]) buf[26])[0] = rslt.wasNull(18);
                ((short[]) buf[27])[0] = rslt.getShort(19) ;
                ((short[]) buf[28])[0] = rslt.getShort(20) ;
                return;
             case 7 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
             case 8 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 40) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                return;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                return;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 40) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                return;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 40) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                return;
             case 14 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                return;
             case 15 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 40) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                return;
             case 16 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
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
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 5 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[16]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[17]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[18]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[19]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[20]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[22]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[23]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[24]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[25]);
                }
                return;
             case 6 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[16]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[17]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[18]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[19]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[20]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[22]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[23]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[24]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[25]);
                }
                return;
             case 7 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[13]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[14]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[15]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[16]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[17]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[19]);
                }
                return;
             case 8 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[13]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[14]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[15]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[16]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[17]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[19]);
                }
                return;
       }
    }

 }

}
