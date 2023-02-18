/*
               File: WWDespBodega
        Description: Work With Despacho Bodega
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/23/2023 1:6:31.19
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
   public class wwdespbodega : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public wwdespbodega( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public wwdespbodega( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_empId ,
                           short aP1_ageID ,
                           String aP2_usucod )
      {
         this.AV17empId = aP0_empId;
         this.AV18ageID = aP1_ageID;
         this.AV19usucod = aP2_usucod;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridxdesp") == 0 )
            {
               nRC_GXsfl_40 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_40_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_40_idx = GetNextPar( );
               AV14Update = GetNextPar( );
               edtavUpdate_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext, !bGXsfl_40_Refreshing);
               AV23actionUpdate = GetNextPar( );
               edtavActionupdate_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavActionupdate_Internalname, "Tooltiptext", edtavActionupdate_Tooltiptext, !bGXsfl_40_Refreshing);
               edtavActionupdate_Jsonclick = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavActionupdate_Internalname, "Jsonclick", edtavActionupdate_Jsonclick, !bGXsfl_40_Refreshing);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGridxdesp_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Gridxdesp") == 0 )
            {
               subGridxdesp_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
               AV13DespBodOpId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV21clientDsc = GetNextPar( );
               AV26Pgmname = GetNextPar( );
               AV14Update = GetNextPar( );
               edtavUpdate_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext, !bGXsfl_40_Refreshing);
               AV23actionUpdate = GetNextPar( );
               edtavActionupdate_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavActionupdate_Internalname, "Tooltiptext", edtavActionupdate_Tooltiptext, !bGXsfl_40_Refreshing);
               edtavActionupdate_Jsonclick = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavActionupdate_Internalname, "Jsonclick", edtavActionupdate_Jsonclick, !bGXsfl_40_Refreshing);
               AV19usucod = GetNextPar( );
               AV17empId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV18ageID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGridxdesp_refresh( subGridxdesp_Rows, AV13DespBodOpId, AV21clientDsc, AV26Pgmname, AV14Update, AV23actionUpdate, AV19usucod, AV17empId, AV18ageID) ;
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Griddesp") == 0 )
            {
               nRC_GXsfl_61 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_61_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_61_idx = GetNextPar( );
               AV22display = GetNextPar( );
               edtavDisplay_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Tooltiptext", edtavDisplay_Tooltiptext, !bGXsfl_61_Refreshing);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGriddesp_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Griddesp") == 0 )
            {
               subGriddesp_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
               AV13DespBodOpId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV21clientDsc = GetNextPar( );
               AV26Pgmname = GetNextPar( );
               AV22display = GetNextPar( );
               edtavDisplay_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Tooltiptext", edtavDisplay_Tooltiptext, !bGXsfl_61_Refreshing);
               AV19usucod = GetNextPar( );
               AV17empId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV18ageID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGriddesp_refresh( subGriddesp_Rows, AV13DespBodOpId, AV21clientDsc, AV26Pgmname, AV22display, AV19usucod, AV17empId, AV18ageID) ;
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
               AV17empId = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17empId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17empId), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV17empId), "ZZZ9"), context));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV18ageID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ageID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18ageID), 4, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV18ageID), "ZZZ9"), context));
                  AV19usucod = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19usucod", AV19usucod);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV19usucod, "")), context));
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
            PA5U2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV26Pgmname = "WWDespBodega";
               context.Gx_err = 0;
               WS5U2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE5U2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2023123163158", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("wwdespbodega.aspx") + "?" + UrlEncode("" +AV17empId) + "," + UrlEncode("" +AV18ageID) + "," + UrlEncode(StringUtil.RTrim(AV19usucod))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vDESPBODOPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13DespBodOpId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCLIENTDSC", StringUtil.RTrim( AV21clientDsc));
         GxWebStd.gx_hidden_field( context, "GXH_vDESPBODOPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13DespBodOpId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCLIENTDSC", StringUtil.RTrim( AV21clientDsc));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_40", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_40), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_61", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_61), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV26Pgmname));
         GxWebStd.gx_hidden_field( context, "vUSUCOD", StringUtil.RTrim( AV19usucod));
         GxWebStd.gx_hidden_field( context, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV19usucod, "")), context));
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17empId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV17empId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18ageID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV18ageID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "GRIDXDESP_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDXDESP_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRIDDESP_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDDESP_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRIDXDESP_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDXDESP_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRIDDESP_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDDESP_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRIDXDESP_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridxdesp_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TAB1_Class", StringUtil.RTrim( Tab1_Class));
         GxWebStd.gx_hidden_field( context, "TAB1_Pagecount", StringUtil.LTrim( StringUtil.NToC( (decimal)(Tab1_Pagecount), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TAB1_Historymanagement", StringUtil.BoolToStr( Tab1_Historymanagement));
         GxWebStd.gx_hidden_field( context, "vUPDATE_Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
         GxWebStd.gx_hidden_field( context, "vACTIONUPDATE_Tooltiptext", StringUtil.RTrim( edtavActionupdate_Tooltiptext));
         GxWebStd.gx_hidden_field( context, "vACTIONUPDATE_Jsonclick", StringUtil.RTrim( edtavActionupdate_Jsonclick));
      }

      protected void RenderHtmlCloseForm5U2( )
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
         return "WWDespBodega" ;
      }

      public override String GetPgmdesc( )
      {
         return "Work With Despacho Bodega" ;
      }

      protected void WB5U0( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabletop_Internalname, 1, 0, "px", 0, "px", "TableTopSearch", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-7 col-sm-2 col-sm-offset-1", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitletext_Internalname, "Despacho Bodegas", "", "", lblTitletext_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "SubTitle", 0, "", 1, 1, 0, "HLP_WWDespBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-5 col-sm-3 col-sm-push-6 WWActionsCell", "Right", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "BtnNew";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(40), 2, 0)+","+"null"+");", "Agregar", bttBtninsert_Jsonclick, 5, "Agregar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWDespBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 col-sm-pull-3", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavDespbodopid_Internalname, "Desp Bod Op Id", "col-sm-3 FilterSearchAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_40_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavDespbodopid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13DespBodOpId), 4, 0, ",", "")), ((edtavDespbodopid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13DespBodOpId), "ZZZ9")) : context.localUtil.Format( (decimal)(AV13DespBodOpId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "Nro. Orden", edtavDespbodopid_Jsonclick, 0, "FilterSearchAttribute", "", "", "", "", 1, edtavDespbodopid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WWDespBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridcell_Internalname, 1, 0, "px", 0, "px", "col-xs-12 ViewGridCellAdvanced", "left", "top", "", "", "div");
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
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable1_Internalname, 1, 0, "px", 0, "px", "TableTopSearch", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClientdsc_Internalname, "client Dsc", "col-sm-3 FilterSearchAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_40_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClientdsc_Internalname, StringUtil.RTrim( AV21clientDsc), StringUtil.RTrim( context.localUtil.Format( AV21clientDsc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "Cliente", edtavClientdsc_Jsonclick, 0, "FilterSearchAttribute", "", "", "", "", 1, edtavClientdsc_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWDespBodega.htm");
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
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"TAB1Container"+"\"></div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB1Container"+"title1"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTabpage1_title_Internalname, "Por Despachar", "", "", lblTabpage1_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_WWDespBodega.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "TabPage1") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB1Container"+"panel1"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabpage1table_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            GridxdespContainer.SetWrapped(nGXWrapped);
            if ( GridxdespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"GridxdespContainer"+"DivS\" data-gxgridid=\"40\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGridxdesp_Internalname, subGridxdesp_Internalname, "", "WorkWith", 0, "", "", 1, 2, sStyleString, "", "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGridxdesp_Backcolorstyle == 0 )
               {
                  subGridxdesp_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGridxdesp_Class) > 0 )
                  {
                     subGridxdesp_Linesclass = subGridxdesp_Class+"Title";
                  }
               }
               else
               {
                  subGridxdesp_Titlebackstyle = 1;
                  if ( subGridxdesp_Backcolorstyle == 1 )
                  {
                     subGridxdesp_Titlebackcolor = subGridxdesp_Allbackcolor;
                     if ( StringUtil.Len( subGridxdesp_Class) > 0 )
                     {
                        subGridxdesp_Linesclass = subGridxdesp_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGridxdesp_Class) > 0 )
                     {
                        subGridxdesp_Linesclass = subGridxdesp_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Emp ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Empresa") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Age ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Age Dsc") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Bod Cod") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Bodega") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Nro.") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(120), 4, 0))+"px"+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Nro. Orden") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Cliente ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(130), 4, 0))+"px"+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "RUC/CI") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Cliente") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ImageAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ImageAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               GridxdespContainer.AddObjectProperty("GridName", "Gridxdesp");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  GridxdespContainer = new GXWebGrid( context);
               }
               else
               {
                  GridxdespContainer.Clear();
               }
               GridxdespContainer.SetWrapped(nGXWrapped);
               GridxdespContainer.AddObjectProperty("GridName", "Gridxdesp");
               GridxdespContainer.AddObjectProperty("Header", subGridxdesp_Header);
               GridxdespContainer.AddObjectProperty("Class", "WorkWith");
               GridxdespContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               GridxdespContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               GridxdespContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridxdesp_Backcolorstyle), 1, 0, ".", "")));
               GridxdespContainer.AddObjectProperty("CmpContext", "");
               GridxdespContainer.AddObjectProperty("InMasterPage", "false");
               GridxdespColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridxdespColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ".", "")));
               GridxdespContainer.AddColumnProperties(GridxdespColumn);
               GridxdespColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridxdespColumn.AddObjectProperty("Value", A44empdsc);
               GridxdespContainer.AddColumnProperties(GridxdespColumn);
               GridxdespColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridxdespColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A2AgeID), 4, 0, ".", "")));
               GridxdespContainer.AddColumnProperties(GridxdespColumn);
               GridxdespColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridxdespColumn.AddObjectProperty("Value", StringUtil.RTrim( A46AgeDsc));
               GridxdespContainer.AddColumnProperties(GridxdespColumn);
               GridxdespColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridxdespColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A42BodCod), 4, 0, ".", "")));
               GridxdespContainer.AddColumnProperties(GridxdespColumn);
               GridxdespColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridxdespColumn.AddObjectProperty("Value", StringUtil.RTrim( A217BodDsc));
               GridxdespContainer.AddColumnProperties(GridxdespColumn);
               GridxdespColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridxdespColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A353DespBodNro), 4, 0, ".", "")));
               GridxdespContainer.AddColumnProperties(GridxdespColumn);
               GridxdespColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridxdespColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A22OrdenID), 4, 0, ".", "")));
               GridxdespContainer.AddColumnProperties(GridxdespColumn);
               GridxdespColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridxdespColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A5ClienteID), 4, 0, ".", "")));
               GridxdespContainer.AddColumnProperties(GridxdespColumn);
               GridxdespColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridxdespColumn.AddObjectProperty("Value", StringUtil.RTrim( A56ClienteRUC));
               GridxdespContainer.AddColumnProperties(GridxdespColumn);
               GridxdespColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridxdespColumn.AddObjectProperty("Value", StringUtil.RTrim( A57ClienteDsc));
               GridxdespContainer.AddColumnProperties(GridxdespColumn);
               GridxdespColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridxdespColumn.AddObjectProperty("Value", context.convertURL( AV14Update));
               GridxdespColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridxdespColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridxdespContainer.AddColumnProperties(GridxdespColumn);
               GridxdespColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridxdespColumn.AddObjectProperty("Value", context.convertURL( AV23actionUpdate));
               GridxdespColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavActionupdate_Tooltiptext));
               GridxdespColumn.AddObjectProperty("Jsonclick", StringUtil.RTrim( edtavActionupdate_Jsonclick));
               GridxdespContainer.AddColumnProperties(GridxdespColumn);
               GridxdespContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridxdesp_Selectedindex), 4, 0, ".", "")));
               GridxdespContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridxdesp_Allowselection), 1, 0, ".", "")));
               GridxdespContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridxdesp_Selectioncolor), 9, 0, ".", "")));
               GridxdespContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridxdesp_Allowhovering), 1, 0, ".", "")));
               GridxdespContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridxdesp_Hoveringcolor), 9, 0, ".", "")));
               GridxdespContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridxdesp_Allowcollapsing), 1, 0, ".", "")));
               GridxdespContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridxdesp_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 40 )
         {
            wbEnd = 0;
            nRC_GXsfl_40 = (short)(nGXsfl_40_idx-1);
            if ( GridxdespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               GridxdespContainer.AddObjectProperty("GRIDXDESP_nEOF", GRIDXDESP_nEOF);
               GridxdespContainer.AddObjectProperty("GRIDXDESP_nFirstRecordOnPage", GRIDXDESP_nFirstRecordOnPage);
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"GridxdespContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridxdesp", GridxdespContainer);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridxdespContainerData", GridxdespContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridxdespContainerData"+"V", GridxdespContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GridxdespContainerData"+"V"+"\" value='"+GridxdespContainer.GridValuesHidden()+"'/>") ;
               }
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB1Container"+"title2"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTabpage2_title_Internalname, "Despachado", "", "", lblTabpage2_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_WWDespBodega.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "TabPage2") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB1Container"+"panel2"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabpage2table_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            GriddespContainer.SetWrapped(nGXWrapped);
            if ( GriddespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"GriddespContainer"+"DivS\" data-gxgridid=\"61\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGriddesp_Internalname, subGriddesp_Internalname, "", "WorkWith", 0, "", "", 1, 2, sStyleString, "", "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGriddesp_Backcolorstyle == 0 )
               {
                  subGriddesp_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGriddesp_Class) > 0 )
                  {
                     subGriddesp_Linesclass = subGriddesp_Class+"Title";
                  }
               }
               else
               {
                  subGriddesp_Titlebackstyle = 1;
                  if ( subGriddesp_Backcolorstyle == 1 )
                  {
                     subGriddesp_Titlebackcolor = subGriddesp_Allbackcolor;
                     if ( StringUtil.Len( subGriddesp_Class) > 0 )
                     {
                        subGriddesp_Linesclass = subGriddesp_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGriddesp_Class) > 0 )
                     {
                        subGriddesp_Linesclass = subGriddesp_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Emp ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Empresa") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Age ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Age Dsc") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Bod Cod") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Bodega") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Nro.") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(120), 4, 0))+"px"+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Nro. Orden") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Cliente ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(130), 4, 0))+"px"+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "RUC/CI") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Cliente") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ImageAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ImageAttribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               GriddespContainer.AddObjectProperty("GridName", "Griddesp");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  GriddespContainer = new GXWebGrid( context);
               }
               else
               {
                  GriddespContainer.Clear();
               }
               GriddespContainer.SetWrapped(nGXWrapped);
               GriddespContainer.AddObjectProperty("GridName", "Griddesp");
               GriddespContainer.AddObjectProperty("Header", subGriddesp_Header);
               GriddespContainer.AddObjectProperty("Class", "WorkWith");
               GriddespContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               GriddespContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               GriddespContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriddesp_Backcolorstyle), 1, 0, ".", "")));
               GriddespContainer.AddObjectProperty("CmpContext", "");
               GriddespContainer.AddObjectProperty("InMasterPage", "false");
               GriddespColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GriddespColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ".", "")));
               GriddespContainer.AddColumnProperties(GriddespColumn);
               GriddespColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GriddespColumn.AddObjectProperty("Value", A44empdsc);
               GriddespContainer.AddColumnProperties(GriddespColumn);
               GriddespColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GriddespColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A2AgeID), 4, 0, ".", "")));
               GriddespContainer.AddColumnProperties(GriddespColumn);
               GriddespColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GriddespColumn.AddObjectProperty("Value", StringUtil.RTrim( A46AgeDsc));
               GriddespContainer.AddColumnProperties(GriddespColumn);
               GriddespColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GriddespColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A42BodCod), 4, 0, ".", "")));
               GriddespContainer.AddColumnProperties(GriddespColumn);
               GriddespColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GriddespColumn.AddObjectProperty("Value", StringUtil.RTrim( A217BodDsc));
               GriddespContainer.AddColumnProperties(GriddespColumn);
               GriddespColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GriddespColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A353DespBodNro), 4, 0, ".", "")));
               GriddespContainer.AddColumnProperties(GriddespColumn);
               GriddespColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GriddespColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A22OrdenID), 4, 0, ".", "")));
               GriddespContainer.AddColumnProperties(GriddespColumn);
               GriddespColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GriddespColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A5ClienteID), 4, 0, ".", "")));
               GriddespContainer.AddColumnProperties(GriddespColumn);
               GriddespColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GriddespColumn.AddObjectProperty("Value", StringUtil.RTrim( A56ClienteRUC));
               GriddespContainer.AddColumnProperties(GriddespColumn);
               GriddespColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GriddespColumn.AddObjectProperty("Value", StringUtil.RTrim( A57ClienteDsc));
               GriddespContainer.AddColumnProperties(GriddespColumn);
               GriddespColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GriddespColumn.AddObjectProperty("Value", context.convertURL( AV22display));
               GriddespColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GriddespColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GriddespContainer.AddColumnProperties(GriddespColumn);
               GriddespColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GriddespColumn.AddObjectProperty("Value", context.convertURL( AV15Delete));
               GriddespContainer.AddColumnProperties(GriddespColumn);
               GriddespContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriddesp_Selectedindex), 4, 0, ".", "")));
               GriddespContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriddesp_Allowselection), 1, 0, ".", "")));
               GriddespContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriddesp_Selectioncolor), 9, 0, ".", "")));
               GriddespContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriddesp_Allowhovering), 1, 0, ".", "")));
               GriddespContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriddesp_Hoveringcolor), 9, 0, ".", "")));
               GriddespContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriddesp_Allowcollapsing), 1, 0, ".", "")));
               GriddespContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriddesp_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 61 )
         {
            wbEnd = 0;
            nRC_GXsfl_61 = (short)(nGXsfl_61_idx-1);
            if ( GriddespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               GriddespContainer.AddObjectProperty("GRIDDESP_nEOF", GRIDDESP_nEOF);
               GriddespContainer.AddObjectProperty("GRIDDESP_nFirstRecordOnPage", GRIDDESP_nFirstRecordOnPage);
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"GriddespContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Griddesp", GriddespContainer);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GriddespContainerData", GriddespContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GriddespContainerData"+"V", GriddespContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GriddespContainerData"+"V"+"\" value='"+GriddespContainer.GridValuesHidden()+"'/>") ;
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
               if ( GridxdespContainer.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  GridxdespContainer.AddObjectProperty("GRIDXDESP_nEOF", GRIDXDESP_nEOF);
                  GridxdespContainer.AddObjectProperty("GRIDXDESP_nFirstRecordOnPage", GRIDXDESP_nFirstRecordOnPage);
                  sStyleString = "";
                  context.WriteHtmlText( "<div id=\""+"GridxdespContainer"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridxdesp", GridxdespContainer);
                  if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "GridxdespContainerData", GridxdespContainer.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "GridxdespContainerData"+"V", GridxdespContainer.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GridxdespContainerData"+"V"+"\" value='"+GridxdespContainer.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         if ( wbEnd == 61 )
         {
            wbEnd = 0;
            if ( isFullAjaxMode( ) )
            {
               if ( GriddespContainer.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  GriddespContainer.AddObjectProperty("GRIDDESP_nEOF", GRIDDESP_nEOF);
                  GriddespContainer.AddObjectProperty("GRIDDESP_nFirstRecordOnPage", GRIDDESP_nFirstRecordOnPage);
                  sStyleString = "";
                  context.WriteHtmlText( "<div id=\""+"GriddespContainer"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Griddesp", GriddespContainer);
                  if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "GriddespContainerData", GriddespContainer.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "GriddespContainerData"+"V", GriddespContainer.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GriddespContainerData"+"V"+"\" value='"+GriddespContainer.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START5U2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "Work With Despacho Bodega", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP5U0( ) ;
      }

      protected void WS5U2( )
      {
         START5U2( ) ;
         EVT5U2( ) ;
      }

      protected void EVT5U2( )
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
                           E115U2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRIDXDESPPAGING") == 0 )
                        {
                           context.wbHandled = 1;
                           sEvt = cgiGet( "GRIDXDESPPAGING");
                           if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                           {
                              subgridxdesp_firstpage( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                           {
                              subgridxdesp_previouspage( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                           {
                              subgridxdesp_nextpage( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                           {
                              subgridxdesp_lastpage( ) ;
                           }
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRIDDESPPAGING") == 0 )
                        {
                           context.wbHandled = 1;
                           sEvt = cgiGet( "GRIDDESPPAGING");
                           if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                           {
                              subgriddesp_firstpage( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                           {
                              subgriddesp_previouspage( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                           {
                              subgriddesp_nextpage( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                           {
                              subgriddesp_lastpage( ) ;
                           }
                           dynload_actions( ) ;
                        }
                     }
                     else
                     {
                        sEvtType = StringUtil.Right( sEvt, 4);
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                        if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 14), "GRIDXDESP.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 14), "'CHANGESTATUS'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 14), "'CHANGESTATUS'") == 0 ) )
                        {
                           nGXsfl_40_idx = (short)(NumberUtil.Val( sEvtType, "."));
                           sGXsfl_40_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_40_idx), 4, 0)), 4, "0");
                           SubsflControlProps_402( ) ;
                           A1EmpID = (short)(context.localUtil.CToN( cgiGet( edtEmpID_Internalname), ",", "."));
                           A44empdsc = StringUtil.Upper( cgiGet( edtempdsc_Internalname));
                           n44empdsc = false;
                           A2AgeID = (short)(context.localUtil.CToN( cgiGet( edtAgeID_Internalname), ",", "."));
                           A46AgeDsc = cgiGet( edtAgeDsc_Internalname);
                           n46AgeDsc = false;
                           A42BodCod = (short)(context.localUtil.CToN( cgiGet( edtBodCod_Internalname), ",", "."));
                           A217BodDsc = StringUtil.Upper( cgiGet( edtBodDsc_Internalname));
                           n217BodDsc = false;
                           A353DespBodNro = (short)(context.localUtil.CToN( cgiGet( edtDespBodNro_Internalname), ",", "."));
                           A22OrdenID = (short)(context.localUtil.CToN( cgiGet( edtOrdenID_Internalname), ",", "."));
                           A5ClienteID = (short)(context.localUtil.CToN( cgiGet( edtClienteID_Internalname), ",", "."));
                           A56ClienteRUC = cgiGet( edtClienteRUC_Internalname);
                           n56ClienteRUC = false;
                           A57ClienteDsc = cgiGet( edtClienteDsc_Internalname);
                           n57ClienteDsc = false;
                           AV14Update = cgiGet( edtavUpdate_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV14Update)) ? AV27Update_GXI : context.convertURL( context.PathToRelativeUrl( AV14Update))), !bGXsfl_40_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV14Update), true);
                           AV23actionUpdate = cgiGet( edtavActionupdate_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavActionupdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV23actionUpdate)) ? AV28Actionupdate_GXI : context.convertURL( context.PathToRelativeUrl( AV23actionUpdate))), !bGXsfl_40_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavActionupdate_Internalname, "SrcSet", context.GetImageSrcSet( AV23actionUpdate), true);
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E125U2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E135U2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRIDXDESP.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E145U2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "'CHANGESTATUS'") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: 'changeStatus' */
                                 E155U2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    Rfr0gs = false;
                                    /* Set Refresh If Despbodopid Changed */
                                    if ( ( context.localUtil.CToN( cgiGet( "GXH_vDESPBODOPID"), ",", ".") != Convert.ToDecimal( AV13DespBodOpId )) )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Clientdsc Changed */
                                    if ( StringUtil.StrCmp(cgiGet( "GXH_vCLIENTDSC"), AV21clientDsc) != 0 )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Despbodopid Changed */
                                    if ( ( context.localUtil.CToN( cgiGet( "GXH_vDESPBODOPID"), ",", ".") != Convert.ToDecimal( AV13DespBodOpId )) )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Clientdsc Changed */
                                    if ( StringUtil.StrCmp(cgiGet( "GXH_vCLIENTDSC"), AV21clientDsc) != 0 )
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
                        else if ( StringUtil.StrCmp(StringUtil.Left( sEvt, 13), "GRIDDESP.LOAD") == 0 )
                        {
                           nGXsfl_61_idx = (short)(NumberUtil.Val( sEvtType, "."));
                           sGXsfl_61_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_61_idx), 4, 0)), 4, "0");
                           SubsflControlProps_613( ) ;
                           A1EmpID = (short)(context.localUtil.CToN( cgiGet( edtEmpID_Internalname), ",", "."));
                           A44empdsc = StringUtil.Upper( cgiGet( edtempdsc_Internalname));
                           n44empdsc = false;
                           A2AgeID = (short)(context.localUtil.CToN( cgiGet( edtAgeID_Internalname), ",", "."));
                           A46AgeDsc = cgiGet( edtAgeDsc_Internalname);
                           n46AgeDsc = false;
                           A42BodCod = (short)(context.localUtil.CToN( cgiGet( edtBodCod_Internalname), ",", "."));
                           A217BodDsc = StringUtil.Upper( cgiGet( edtBodDsc_Internalname));
                           n217BodDsc = false;
                           A353DespBodNro = (short)(context.localUtil.CToN( cgiGet( edtDespBodNro_Internalname), ",", "."));
                           A22OrdenID = (short)(context.localUtil.CToN( cgiGet( edtOrdenID_Internalname), ",", "."));
                           A5ClienteID = (short)(context.localUtil.CToN( cgiGet( edtClienteID_Internalname), ",", "."));
                           A56ClienteRUC = cgiGet( edtClienteRUC_Internalname);
                           n56ClienteRUC = false;
                           A57ClienteDsc = cgiGet( edtClienteDsc_Internalname);
                           n57ClienteDsc = false;
                           AV22display = cgiGet( edtavDisplay_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV22display)) ? AV29Display_GXI : context.convertURL( context.PathToRelativeUrl( AV22display))), !bGXsfl_61_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV22display), true);
                           AV15Delete = cgiGet( edtavDelete_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV15Delete)) ? AV30Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV15Delete))), !bGXsfl_61_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV15Delete), true);
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "GRIDDESP.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E165U3 ();
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

      protected void WE5U2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm5U2( ) ;
            }
         }
      }

      protected void PA5U2( )
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
               GX_FocusControl = edtavDespbodopid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGridxdesp_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_402( ) ;
         while ( nGXsfl_40_idx <= nRC_GXsfl_40 )
         {
            sendrow_402( ) ;
            nGXsfl_40_idx = (short)(((subGridxdesp_Islastpage==1)&&(nGXsfl_40_idx+1>subGridxdesp_Recordsperpage( )) ? 1 : nGXsfl_40_idx+1));
            sGXsfl_40_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_40_idx), 4, 0)), 4, "0");
            SubsflControlProps_402( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridxdespContainer));
         /* End function gxnrGridxdesp_newrow */
      }

      protected void gxnrGriddesp_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_613( ) ;
         while ( nGXsfl_61_idx <= nRC_GXsfl_61 )
         {
            sendrow_613( ) ;
            nGXsfl_61_idx = (short)(((subGriddesp_Islastpage==1)&&(nGXsfl_61_idx+1>subGriddesp_Recordsperpage( )) ? 1 : nGXsfl_61_idx+1));
            sGXsfl_61_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_61_idx), 4, 0)), 4, "0");
            SubsflControlProps_613( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GriddespContainer));
         /* End function gxnrGriddesp_newrow */
      }

      protected void gxgrGridxdesp_refresh( int subGridxdesp_Rows ,
                                            short AV13DespBodOpId ,
                                            String AV21clientDsc ,
                                            String AV26Pgmname ,
                                            String AV14Update ,
                                            String AV23actionUpdate ,
                                            String AV19usucod ,
                                            short AV17empId ,
                                            short AV18ageID )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRIDXDESP_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridxdesp_Rows), 6, 0, ".", "")));
         GRIDXDESP_nCurrentRecord = 0;
         RF5U2( ) ;
         /* End function gxgrGridxdesp_refresh */
      }

      protected void gxgrGriddesp_refresh( int subGriddesp_Rows ,
                                           short AV13DespBodOpId ,
                                           String AV21clientDsc ,
                                           String AV26Pgmname ,
                                           String AV22display ,
                                           String AV19usucod ,
                                           short AV17empId ,
                                           short AV18ageID )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRIDDESP_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriddesp_Rows), 6, 0, ".", "")));
         /* Execute user event: Refresh */
         E135U2 ();
         GRIDDESP_nCurrentRecord = 0;
         RF5U3( ) ;
         /* End function gxgrGriddesp_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_DESPBODNRO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A353DespBodNro), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "DESPBODNRO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A353DespBodNro), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_ORDENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A22OrdenID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "ORDENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A22OrdenID), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_CLIENTEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A5ClienteID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "CLIENTEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A5ClienteID), 4, 0, ".", "")));
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
         RF5U2( ) ;
         RF5U3( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV26Pgmname = "WWDespBodega";
         context.Gx_err = 0;
      }

      protected void RF5U2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridxdespContainer.ClearRows();
         }
         wbStart = 40;
         /* Execute user event: Refresh */
         E135U2 ();
         nGXsfl_40_idx = 1;
         sGXsfl_40_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_40_idx), 4, 0)), 4, "0");
         SubsflControlProps_402( ) ;
         bGXsfl_40_Refreshing = true;
         GridxdespContainer.AddObjectProperty("GridName", "Gridxdesp");
         GridxdespContainer.AddObjectProperty("CmpContext", "");
         GridxdespContainer.AddObjectProperty("InMasterPage", "false");
         GridxdespContainer.AddObjectProperty("Class", "WorkWith");
         GridxdespContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         GridxdespContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         GridxdespContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridxdesp_Backcolorstyle), 1, 0, ".", "")));
         GridxdespContainer.PageSize = subGridxdesp_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_402( ) ;
            GXPagingFrom2 = (int)(((subGridxdesp_Rows==0) ? 0 : GRIDXDESP_nFirstRecordOnPage));
            GXPagingTo2 = ((subGridxdesp_Rows==0) ? 10000 : subGridxdesp_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV13DespBodOpId ,
                                                 AV21clientDsc ,
                                                 A22OrdenID ,
                                                 A57ClienteDsc ,
                                                 A402DespachadoOK } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV21clientDsc = StringUtil.PadR( StringUtil.RTrim( AV21clientDsc), 50, "%");
            /* Using cursor H005U2 */
            pr_default.execute(0, new Object[] {AV13DespBodOpId, lV21clientDsc, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_40_idx = 1;
            sGXsfl_40_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_40_idx), 4, 0)), 4, "0");
            SubsflControlProps_402( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGridxdesp_Rows == 0 ) || ( GRIDXDESP_nCurrentRecord < subGridxdesp_Recordsperpage( ) ) ) ) )
            {
               A402DespachadoOK = H005U2_A402DespachadoOK[0];
               n402DespachadoOK = H005U2_n402DespachadoOK[0];
               A57ClienteDsc = H005U2_A57ClienteDsc[0];
               n57ClienteDsc = H005U2_n57ClienteDsc[0];
               A56ClienteRUC = H005U2_A56ClienteRUC[0];
               n56ClienteRUC = H005U2_n56ClienteRUC[0];
               A5ClienteID = H005U2_A5ClienteID[0];
               A22OrdenID = H005U2_A22OrdenID[0];
               A353DespBodNro = H005U2_A353DespBodNro[0];
               A217BodDsc = H005U2_A217BodDsc[0];
               n217BodDsc = H005U2_n217BodDsc[0];
               A42BodCod = H005U2_A42BodCod[0];
               A46AgeDsc = H005U2_A46AgeDsc[0];
               n46AgeDsc = H005U2_n46AgeDsc[0];
               A2AgeID = H005U2_A2AgeID[0];
               A44empdsc = H005U2_A44empdsc[0];
               n44empdsc = H005U2_n44empdsc[0];
               A1EmpID = H005U2_A1EmpID[0];
               A44empdsc = H005U2_A44empdsc[0];
               n44empdsc = H005U2_n44empdsc[0];
               A46AgeDsc = H005U2_A46AgeDsc[0];
               n46AgeDsc = H005U2_n46AgeDsc[0];
               A57ClienteDsc = H005U2_A57ClienteDsc[0];
               n57ClienteDsc = H005U2_n57ClienteDsc[0];
               A56ClienteRUC = H005U2_A56ClienteRUC[0];
               n56ClienteRUC = H005U2_n56ClienteRUC[0];
               A217BodDsc = H005U2_A217BodDsc[0];
               n217BodDsc = H005U2_n217BodDsc[0];
               E145U2 ();
               pr_default.readNext(0);
            }
            GRIDXDESP_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRIDXDESP_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDXDESP_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 40;
            WB5U0( ) ;
         }
         bGXsfl_40_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes5U2( )
      {
         GxWebStd.gx_hidden_field( context, "vUSUCOD", StringUtil.RTrim( AV19usucod));
         GxWebStd.gx_hidden_field( context, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV19usucod, "")), context));
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17empId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV17empId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18ageID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV18ageID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_DESPBODNRO"+"_"+sGXsfl_40_idx, GetSecureSignedToken( sGXsfl_40_idx, context.localUtil.Format( (decimal)(A353DespBodNro), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_ORDENID"+"_"+sGXsfl_40_idx, GetSecureSignedToken( sGXsfl_40_idx, context.localUtil.Format( (decimal)(A22OrdenID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_CLIENTEID"+"_"+sGXsfl_40_idx, GetSecureSignedToken( sGXsfl_40_idx, context.localUtil.Format( (decimal)(A5ClienteID), "ZZZ9"), context));
      }

      protected void RF5U3( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GriddespContainer.ClearRows();
         }
         wbStart = 61;
         nGXsfl_61_idx = 1;
         sGXsfl_61_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_61_idx), 4, 0)), 4, "0");
         SubsflControlProps_613( ) ;
         bGXsfl_61_Refreshing = true;
         GriddespContainer.AddObjectProperty("GridName", "Griddesp");
         GriddespContainer.AddObjectProperty("CmpContext", "");
         GriddespContainer.AddObjectProperty("InMasterPage", "false");
         GriddespContainer.AddObjectProperty("Class", "WorkWith");
         GriddespContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         GriddespContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         GriddespContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriddesp_Backcolorstyle), 1, 0, ".", "")));
         GriddespContainer.PageSize = subGriddesp_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_613( ) ;
            GXPagingFrom3 = (int)(((10==0) ? 0 : GRIDDESP_nFirstRecordOnPage));
            GXPagingTo3 = ((10==0) ? 10000 : subGriddesp_Recordsperpage( )+1);
            pr_default.dynParam(1, new Object[]{ new Object[]{
                                                 AV13DespBodOpId ,
                                                 AV21clientDsc ,
                                                 A22OrdenID ,
                                                 A57ClienteDsc ,
                                                 A402DespachadoOK } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV21clientDsc = StringUtil.PadR( StringUtil.RTrim( AV21clientDsc), 50, "%");
            /* Using cursor H005U3 */
            pr_default.execute(1, new Object[] {AV13DespBodOpId, lV21clientDsc, GXPagingFrom3, GXPagingTo3, GXPagingTo3});
            nGXsfl_61_idx = 1;
            sGXsfl_61_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_61_idx), 4, 0)), 4, "0");
            SubsflControlProps_613( ) ;
            while ( ( (pr_default.getStatus(1) != 101) ) && ( ( ( 10 == 0 ) || ( GRIDDESP_nCurrentRecord < subGriddesp_Recordsperpage( ) ) ) ) )
            {
               A402DespachadoOK = H005U3_A402DespachadoOK[0];
               n402DespachadoOK = H005U3_n402DespachadoOK[0];
               A57ClienteDsc = H005U3_A57ClienteDsc[0];
               n57ClienteDsc = H005U3_n57ClienteDsc[0];
               A56ClienteRUC = H005U3_A56ClienteRUC[0];
               n56ClienteRUC = H005U3_n56ClienteRUC[0];
               A5ClienteID = H005U3_A5ClienteID[0];
               A22OrdenID = H005U3_A22OrdenID[0];
               A353DespBodNro = H005U3_A353DespBodNro[0];
               A217BodDsc = H005U3_A217BodDsc[0];
               n217BodDsc = H005U3_n217BodDsc[0];
               A42BodCod = H005U3_A42BodCod[0];
               A46AgeDsc = H005U3_A46AgeDsc[0];
               n46AgeDsc = H005U3_n46AgeDsc[0];
               A2AgeID = H005U3_A2AgeID[0];
               A44empdsc = H005U3_A44empdsc[0];
               n44empdsc = H005U3_n44empdsc[0];
               A1EmpID = H005U3_A1EmpID[0];
               A44empdsc = H005U3_A44empdsc[0];
               n44empdsc = H005U3_n44empdsc[0];
               A46AgeDsc = H005U3_A46AgeDsc[0];
               n46AgeDsc = H005U3_n46AgeDsc[0];
               A57ClienteDsc = H005U3_A57ClienteDsc[0];
               n57ClienteDsc = H005U3_n57ClienteDsc[0];
               A56ClienteRUC = H005U3_A56ClienteRUC[0];
               n56ClienteRUC = H005U3_n56ClienteRUC[0];
               A217BodDsc = H005U3_A217BodDsc[0];
               n217BodDsc = H005U3_n217BodDsc[0];
               E165U3 ();
               pr_default.readNext(1);
            }
            GRIDDESP_nEOF = (short)(((pr_default.getStatus(1) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRIDDESP_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDDESP_nEOF), 1, 0, ".", "")));
            pr_default.close(1);
            wbEnd = 61;
            WB5U0( ) ;
         }
         bGXsfl_61_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes5U3( )
      {
      }

      protected int subGridxdesp_Pagecount( )
      {
         GRIDXDESP_nRecordCount = subGridxdesp_Recordcount( );
         if ( ((int)((GRIDXDESP_nRecordCount) % (subGridxdesp_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRIDXDESP_nRecordCount/ (decimal)(subGridxdesp_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRIDXDESP_nRecordCount/ (decimal)(subGridxdesp_Recordsperpage( ))))+1) ;
      }

      protected int subGridxdesp_Recordcount( )
      {
         pr_default.dynParam(2, new Object[]{ new Object[]{
                                              AV13DespBodOpId ,
                                              AV21clientDsc ,
                                              A22OrdenID ,
                                              A57ClienteDsc ,
                                              A402DespachadoOK } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV21clientDsc = StringUtil.PadR( StringUtil.RTrim( AV21clientDsc), 50, "%");
         /* Using cursor H005U4 */
         pr_default.execute(2, new Object[] {AV13DespBodOpId, lV21clientDsc});
         GRIDXDESP_nRecordCount = H005U4_AGRIDXDESP_nRecordCount[0];
         pr_default.close(2);
         return (int)(GRIDXDESP_nRecordCount) ;
      }

      protected int subGridxdesp_Recordsperpage( )
      {
         if ( subGridxdesp_Rows > 0 )
         {
            return subGridxdesp_Rows*1 ;
         }
         else
         {
            return (int)(-1) ;
         }
      }

      protected int subGridxdesp_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRIDXDESP_nFirstRecordOnPage/ (decimal)(subGridxdesp_Recordsperpage( ))))+1) ;
      }

      protected short subgridxdesp_firstpage( )
      {
         GRIDXDESP_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRIDXDESP_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDXDESP_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGridxdesp_refresh( subGridxdesp_Rows, AV13DespBodOpId, AV21clientDsc, AV26Pgmname, AV14Update, AV23actionUpdate, AV19usucod, AV17empId, AV18ageID) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgridxdesp_nextpage( )
      {
         GRIDXDESP_nRecordCount = subGridxdesp_Recordcount( );
         if ( ( GRIDXDESP_nRecordCount >= subGridxdesp_Recordsperpage( ) ) && ( GRIDXDESP_nEOF == 0 ) )
         {
            GRIDXDESP_nFirstRecordOnPage = (long)(GRIDXDESP_nFirstRecordOnPage+subGridxdesp_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRIDXDESP_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDXDESP_nFirstRecordOnPage), 15, 0, ".", "")));
         GridxdespContainer.AddObjectProperty("GRIDXDESP_nFirstRecordOnPage", GRIDXDESP_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGridxdesp_refresh( subGridxdesp_Rows, AV13DespBodOpId, AV21clientDsc, AV26Pgmname, AV14Update, AV23actionUpdate, AV19usucod, AV17empId, AV18ageID) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRIDXDESP_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgridxdesp_previouspage( )
      {
         if ( GRIDXDESP_nFirstRecordOnPage >= subGridxdesp_Recordsperpage( ) )
         {
            GRIDXDESP_nFirstRecordOnPage = (long)(GRIDXDESP_nFirstRecordOnPage-subGridxdesp_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRIDXDESP_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDXDESP_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGridxdesp_refresh( subGridxdesp_Rows, AV13DespBodOpId, AV21clientDsc, AV26Pgmname, AV14Update, AV23actionUpdate, AV19usucod, AV17empId, AV18ageID) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgridxdesp_lastpage( )
      {
         GRIDXDESP_nRecordCount = subGridxdesp_Recordcount( );
         if ( GRIDXDESP_nRecordCount > subGridxdesp_Recordsperpage( ) )
         {
            if ( ((int)((GRIDXDESP_nRecordCount) % (subGridxdesp_Recordsperpage( )))) == 0 )
            {
               GRIDXDESP_nFirstRecordOnPage = (long)(GRIDXDESP_nRecordCount-subGridxdesp_Recordsperpage( ));
            }
            else
            {
               GRIDXDESP_nFirstRecordOnPage = (long)(GRIDXDESP_nRecordCount-((int)((GRIDXDESP_nRecordCount) % (subGridxdesp_Recordsperpage( )))));
            }
         }
         else
         {
            GRIDXDESP_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRIDXDESP_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDXDESP_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGridxdesp_refresh( subGridxdesp_Rows, AV13DespBodOpId, AV21clientDsc, AV26Pgmname, AV14Update, AV23actionUpdate, AV19usucod, AV17empId, AV18ageID) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgridxdesp_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRIDXDESP_nFirstRecordOnPage = (long)(subGridxdesp_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRIDXDESP_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRIDXDESP_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDXDESP_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGridxdesp_refresh( subGridxdesp_Rows, AV13DespBodOpId, AV21clientDsc, AV26Pgmname, AV14Update, AV23actionUpdate, AV19usucod, AV17empId, AV18ageID) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected int subGriddesp_Pagecount( )
      {
         GRIDDESP_nRecordCount = subGriddesp_Recordcount( );
         if ( ((int)((GRIDDESP_nRecordCount) % (subGriddesp_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRIDDESP_nRecordCount/ (decimal)(subGriddesp_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRIDDESP_nRecordCount/ (decimal)(subGriddesp_Recordsperpage( ))))+1) ;
      }

      protected int subGriddesp_Recordcount( )
      {
         pr_default.dynParam(3, new Object[]{ new Object[]{
                                              AV13DespBodOpId ,
                                              AV21clientDsc ,
                                              A22OrdenID ,
                                              A57ClienteDsc ,
                                              A402DespachadoOK } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV21clientDsc = StringUtil.PadR( StringUtil.RTrim( AV21clientDsc), 50, "%");
         /* Using cursor H005U5 */
         pr_default.execute(3, new Object[] {AV13DespBodOpId, lV21clientDsc});
         GRIDDESP_nRecordCount = H005U5_AGRIDDESP_nRecordCount[0];
         pr_default.close(3);
         return (int)(GRIDDESP_nRecordCount) ;
      }

      protected int subGriddesp_Recordsperpage( )
      {
         return (int)(10*1) ;
      }

      protected int subGriddesp_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRIDDESP_nFirstRecordOnPage/ (decimal)(subGriddesp_Recordsperpage( ))))+1) ;
      }

      protected short subgriddesp_firstpage( )
      {
         GRIDDESP_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRIDDESP_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDDESP_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGriddesp_refresh( subGriddesp_Rows, AV13DespBodOpId, AV21clientDsc, AV26Pgmname, AV22display, AV19usucod, AV17empId, AV18ageID) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgriddesp_nextpage( )
      {
         GRIDDESP_nRecordCount = subGriddesp_Recordcount( );
         if ( ( GRIDDESP_nRecordCount >= subGriddesp_Recordsperpage( ) ) && ( GRIDDESP_nEOF == 0 ) )
         {
            GRIDDESP_nFirstRecordOnPage = (long)(GRIDDESP_nFirstRecordOnPage+subGriddesp_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRIDDESP_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDDESP_nFirstRecordOnPage), 15, 0, ".", "")));
         GriddespContainer.AddObjectProperty("GRIDDESP_nFirstRecordOnPage", GRIDDESP_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGriddesp_refresh( subGriddesp_Rows, AV13DespBodOpId, AV21clientDsc, AV26Pgmname, AV22display, AV19usucod, AV17empId, AV18ageID) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRIDDESP_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgriddesp_previouspage( )
      {
         if ( GRIDDESP_nFirstRecordOnPage >= subGriddesp_Recordsperpage( ) )
         {
            GRIDDESP_nFirstRecordOnPage = (long)(GRIDDESP_nFirstRecordOnPage-subGriddesp_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRIDDESP_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDDESP_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGriddesp_refresh( subGriddesp_Rows, AV13DespBodOpId, AV21clientDsc, AV26Pgmname, AV22display, AV19usucod, AV17empId, AV18ageID) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgriddesp_lastpage( )
      {
         GRIDDESP_nRecordCount = subGriddesp_Recordcount( );
         if ( GRIDDESP_nRecordCount > subGriddesp_Recordsperpage( ) )
         {
            if ( ((int)((GRIDDESP_nRecordCount) % (subGriddesp_Recordsperpage( )))) == 0 )
            {
               GRIDDESP_nFirstRecordOnPage = (long)(GRIDDESP_nRecordCount-subGriddesp_Recordsperpage( ));
            }
            else
            {
               GRIDDESP_nFirstRecordOnPage = (long)(GRIDDESP_nRecordCount-((int)((GRIDDESP_nRecordCount) % (subGriddesp_Recordsperpage( )))));
            }
         }
         else
         {
            GRIDDESP_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRIDDESP_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDDESP_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGriddesp_refresh( subGriddesp_Rows, AV13DespBodOpId, AV21clientDsc, AV26Pgmname, AV22display, AV19usucod, AV17empId, AV18ageID) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgriddesp_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRIDDESP_nFirstRecordOnPage = (long)(subGriddesp_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRIDDESP_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRIDDESP_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDDESP_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGriddesp_refresh( subGriddesp_Rows, AV13DespBodOpId, AV21clientDsc, AV26Pgmname, AV22display, AV19usucod, AV17empId, AV18ageID) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP5U0( )
      {
         /* Before Start, stand alone formulas. */
         AV26Pgmname = "WWDespBodega";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E125U2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavDespbodopid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavDespbodopid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vDESPBODOPID");
               GX_FocusControl = edtavDespbodopid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV13DespBodOpId = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13DespBodOpId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13DespBodOpId), 4, 0)));
            }
            else
            {
               AV13DespBodOpId = (short)(context.localUtil.CToN( cgiGet( edtavDespbodopid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13DespBodOpId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13DespBodOpId), 4, 0)));
            }
            AV21clientDsc = cgiGet( edtavClientdsc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21clientDsc", AV21clientDsc);
            /* Read saved values. */
            nRC_GXsfl_40 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_40"), ",", "."));
            nRC_GXsfl_61 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_61"), ",", "."));
            GRIDXDESP_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRIDXDESP_nFirstRecordOnPage"), ",", "."));
            GRIDDESP_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRIDDESP_nFirstRecordOnPage"), ",", "."));
            GRIDXDESP_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRIDXDESP_nEOF"), ",", "."));
            GRIDDESP_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRIDDESP_nEOF"), ",", "."));
            subGridxdesp_Rows = (int)(context.localUtil.CToN( cgiGet( "GRIDXDESP_Rows"), ",", "."));
            GxWebStd.gx_hidden_field( context, "GRIDXDESP_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridxdesp_Rows), 6, 0, ".", "")));
            Tab1_Class = cgiGet( "TAB1_Class");
            Tab1_Pagecount = (int)(context.localUtil.CToN( cgiGet( "TAB1_Pagecount"), ",", "."));
            Tab1_Historymanagement = StringUtil.StrToBool( cgiGet( "TAB1_Historymanagement"));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vDESPBODOPID"), ",", ".") != Convert.ToDecimal( AV13DespBodOpId )) )
            {
               GRIDXDESP_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCLIENTDSC"), AV21clientDsc) != 0 )
            {
               GRIDXDESP_nFirstRecordOnPage = 0;
            }
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vDESPBODOPID"), ",", ".") != Convert.ToDecimal( AV13DespBodOpId )) )
            {
               GRIDDESP_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCLIENTDSC"), AV21clientDsc) != 0 )
            {
               GRIDDESP_nFirstRecordOnPage = 0;
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
         E125U2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E125U2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV26Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV26Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         subGridxdesp_Rows = 10;
         GxWebStd.gx_hidden_field( context, "GRIDXDESP_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridxdesp_Rows), 6, 0, ".", "")));
         AV14Update = context.GetImagePath( "984dbb7e-3105-4d21-aee3-84a29ade1d38", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV14Update)) ? AV27Update_GXI : context.convertURL( context.PathToRelativeUrl( AV14Update))), !bGXsfl_40_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV14Update), true);
         AV27Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "984dbb7e-3105-4d21-aee3-84a29ade1d38", "", context.GetTheme( )));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV14Update)) ? AV27Update_GXI : context.convertURL( context.PathToRelativeUrl( AV14Update))), !bGXsfl_40_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV14Update), true);
         edtavUpdate_Tooltiptext = "Modificar";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext, !bGXsfl_40_Refreshing);
         AV23actionUpdate = context.GetImagePath( "/logos/update.png", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavActionupdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV23actionUpdate)) ? AV28Actionupdate_GXI : context.convertURL( context.PathToRelativeUrl( AV23actionUpdate))), !bGXsfl_40_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavActionupdate_Internalname, "SrcSet", context.GetImageSrcSet( AV23actionUpdate), true);
         AV28Actionupdate_GXI = GXDbFile.PathToUrl( "/logos/update.png");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavActionupdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV23actionUpdate)) ? AV28Actionupdate_GXI : context.convertURL( context.PathToRelativeUrl( AV23actionUpdate))), !bGXsfl_40_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavActionupdate_Internalname, "SrcSet", context.GetImageSrcSet( AV23actionUpdate), true);
         edtavActionupdate_Tooltiptext = "Cambiar Estado";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavActionupdate_Internalname, "Tooltiptext", edtavActionupdate_Tooltiptext, !bGXsfl_40_Refreshing);
         AV22display = context.GetImagePath( "/logos/view.png", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV22display)) ? AV29Display_GXI : context.convertURL( context.PathToRelativeUrl( AV22display))), !bGXsfl_61_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV22display), true);
         AV29Display_GXI = GXDbFile.PathToUrl( "/logos/view.png");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV22display)) ? AV29Display_GXI : context.convertURL( context.PathToRelativeUrl( AV22display))), !bGXsfl_61_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV22display), true);
         edtavDisplay_Tooltiptext = "Visualizar";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Tooltiptext", edtavDisplay_Tooltiptext, !bGXsfl_61_Refreshing);
         Form.Caption = "Despacho Bodegas";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         edtavActionupdate_Jsonclick = "confirm('Desea Cambiar de estado?')";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavActionupdate_Internalname, "Jsonclick", edtavActionupdate_Jsonclick, !bGXsfl_40_Refreshing);
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

      protected void E135U2( )
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

      private void E145U2( )
      {
         /* Gridxdesp_Load Routine */
         edtavUpdate_Link = formatLink("despbodega.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A1EmpID) + "," + UrlEncode("" +A2AgeID) + "," + UrlEncode("" +A353DespBodNro) + "," + UrlEncode("" +A22OrdenID) + "," + UrlEncode("" +A5ClienteID) + "," + UrlEncode(StringUtil.RTrim(AV19usucod));
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 40;
         }
         sendrow_402( ) ;
         GRIDXDESP_nCurrentRecord = (long)(GRIDXDESP_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_40_Refreshing )
         {
            context.DoAjaxLoad(40, GridxdespRow);
         }
         /*  Sending Event outputs  */
      }

      protected void E115U2( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("despbodega.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +AV17empId) + "," + UrlEncode("" +AV18ageID) + "," + UrlEncode("" +0) + "," + UrlEncode("" +0) + "," + UrlEncode("" +0) + "," + UrlEncode(StringUtil.RTrim(AV19usucod)));
         context.wjLocDisableFrm = 1;
      }

      protected void E155U2( )
      {
         /* 'changeStatus' Routine */
         new cambestadodespbod(context ).execute(  AV17empId,  AV18ageID,  A353DespBodNro,  A5ClienteID,  A22OrdenID) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17empId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17empId), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV17empId), "ZZZ9"), context));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ageID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18ageID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV18ageID), "ZZZ9"), context));
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV7HTTPRequest.Method, "GET") == 0 )
         {
            AV8GridState.FromXml(AV6Session.Get(AV26Pgmname+"GridState"), null, "GridState", "KBCalpesa22");
            if ( AV8GridState.gxTpr_Filtervalues.Count >= 1 )
            {
               AV13DespBodOpId = (short)(NumberUtil.Val( ((SdtGridState_FilterValue)AV8GridState.gxTpr_Filtervalues.Item(1)).gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13DespBodOpId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13DespBodOpId), 4, 0)));
            }
            if ( AV8GridState.gxTpr_Currentpage > 0 )
            {
               AV10GridPageCount = subGridxdesp_Pagecount( );
               if ( ( AV10GridPageCount > 0 ) && ( AV10GridPageCount < AV8GridState.gxTpr_Currentpage ) )
               {
                  subgridxdesp_gotopage( AV10GridPageCount) ;
               }
               else
               {
                  subgridxdesp_gotopage( AV8GridState.gxTpr_Currentpage) ;
               }
            }
         }
      }

      protected void S132( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV8GridState.FromXml(AV6Session.Get(AV26Pgmname+"GridState"), null, "GridState", "KBCalpesa22");
         AV8GridState.gxTpr_Currentpage = (short)(subGridxdesp_Currentpage( ));
         AV8GridState.gxTpr_Filtervalues.Clear();
         AV9GridStateFilterValue = new SdtGridState_FilterValue(context);
         AV9GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV13DespBodOpId), 4, 0);
         AV8GridState.gxTpr_Filtervalues.Add(AV9GridStateFilterValue, 0);
         AV6Session.Set(AV26Pgmname+"GridState", AV8GridState.ToXml(false, true, "GridState", "KBCalpesa22"));
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV11TrnContext = new SdtTransactionContext(context);
         AV11TrnContext.gxTpr_Callerobject = AV26Pgmname;
         AV11TrnContext.gxTpr_Callerondelete = true;
         AV11TrnContext.gxTpr_Callerurl = AV7HTTPRequest.ScriptName+"?"+AV7HTTPRequest.QueryString;
         AV11TrnContext.gxTpr_Transactionname = "DespBodega";
         AV6Session.Set("TrnContext", AV11TrnContext.ToXml(false, true, "TransactionContext", "KBCalpesa22"));
      }

      private void E165U3( )
      {
         /* Griddesp_Load Routine */
         edtavDisplay_Link = formatLink("despbodega.aspx") + "?" + UrlEncode(StringUtil.RTrim("DSP")) + "," + UrlEncode("" +A1EmpID) + "," + UrlEncode("" +A2AgeID) + "," + UrlEncode("" +A353DespBodNro) + "," + UrlEncode("" +A22OrdenID) + "," + UrlEncode("" +A5ClienteID) + "," + UrlEncode(StringUtil.RTrim(AV19usucod));
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 61;
         }
         sendrow_613( ) ;
         GRIDDESP_nCurrentRecord = (long)(GRIDDESP_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_61_Refreshing )
         {
            context.DoAjaxLoad(61, GriddespRow);
         }
         /*  Sending Event outputs  */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV17empId = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17empId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17empId), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV17empId), "ZZZ9"), context));
         AV18ageID = Convert.ToInt16(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ageID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18ageID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV18ageID), "ZZZ9"), context));
         AV19usucod = (String)getParm(obj,2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19usucod", AV19usucod);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV19usucod, "")), context));
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
         PA5U2( ) ;
         WS5U2( ) ;
         WE5U2( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ), true);
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2023123163710", true);
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
            context.AddJavascriptSource("wwdespbodega.js", "?2023123163712", false);
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
         edtempdsc_Internalname = "EMPDSC_"+sGXsfl_40_idx;
         edtAgeID_Internalname = "AGEID_"+sGXsfl_40_idx;
         edtAgeDsc_Internalname = "AGEDSC_"+sGXsfl_40_idx;
         edtBodCod_Internalname = "BODCOD_"+sGXsfl_40_idx;
         edtBodDsc_Internalname = "BODDSC_"+sGXsfl_40_idx;
         edtDespBodNro_Internalname = "DESPBODNRO_"+sGXsfl_40_idx;
         edtOrdenID_Internalname = "ORDENID_"+sGXsfl_40_idx;
         edtClienteID_Internalname = "CLIENTEID_"+sGXsfl_40_idx;
         edtClienteRUC_Internalname = "CLIENTERUC_"+sGXsfl_40_idx;
         edtClienteDsc_Internalname = "CLIENTEDSC_"+sGXsfl_40_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_40_idx;
         edtavActionupdate_Internalname = "vACTIONUPDATE_"+sGXsfl_40_idx;
      }

      protected void SubsflControlProps_fel_402( )
      {
         edtEmpID_Internalname = "EMPID_"+sGXsfl_40_fel_idx;
         edtempdsc_Internalname = "EMPDSC_"+sGXsfl_40_fel_idx;
         edtAgeID_Internalname = "AGEID_"+sGXsfl_40_fel_idx;
         edtAgeDsc_Internalname = "AGEDSC_"+sGXsfl_40_fel_idx;
         edtBodCod_Internalname = "BODCOD_"+sGXsfl_40_fel_idx;
         edtBodDsc_Internalname = "BODDSC_"+sGXsfl_40_fel_idx;
         edtDespBodNro_Internalname = "DESPBODNRO_"+sGXsfl_40_fel_idx;
         edtOrdenID_Internalname = "ORDENID_"+sGXsfl_40_fel_idx;
         edtClienteID_Internalname = "CLIENTEID_"+sGXsfl_40_fel_idx;
         edtClienteRUC_Internalname = "CLIENTERUC_"+sGXsfl_40_fel_idx;
         edtClienteDsc_Internalname = "CLIENTEDSC_"+sGXsfl_40_fel_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_40_fel_idx;
         edtavActionupdate_Internalname = "vACTIONUPDATE_"+sGXsfl_40_fel_idx;
      }

      protected void sendrow_402( )
      {
         SubsflControlProps_402( ) ;
         WB5U0( ) ;
         if ( ( subGridxdesp_Rows * 1 == 0 ) || ( nGXsfl_40_idx <= subGridxdesp_Recordsperpage( ) * 1 ) )
         {
            GridxdespRow = GXWebRow.GetNew(context,GridxdespContainer);
            if ( subGridxdesp_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGridxdesp_Backstyle = 0;
               if ( StringUtil.StrCmp(subGridxdesp_Class, "") != 0 )
               {
                  subGridxdesp_Linesclass = subGridxdesp_Class+"Odd";
               }
            }
            else if ( subGridxdesp_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGridxdesp_Backstyle = 0;
               subGridxdesp_Backcolor = subGridxdesp_Allbackcolor;
               if ( StringUtil.StrCmp(subGridxdesp_Class, "") != 0 )
               {
                  subGridxdesp_Linesclass = subGridxdesp_Class+"Uniform";
               }
            }
            else if ( subGridxdesp_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGridxdesp_Backstyle = 1;
               if ( StringUtil.StrCmp(subGridxdesp_Class, "") != 0 )
               {
                  subGridxdesp_Linesclass = subGridxdesp_Class+"Odd";
               }
               subGridxdesp_Backcolor = (int)(0x0);
            }
            else if ( subGridxdesp_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGridxdesp_Backstyle = 1;
               if ( ((int)(((nGXsfl_40_idx-1)/ (decimal)(1)) % (2))) == 0 )
               {
                  subGridxdesp_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGridxdesp_Class, "") != 0 )
                  {
                     subGridxdesp_Linesclass = subGridxdesp_Class+"Odd";
                  }
               }
               else
               {
                  subGridxdesp_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGridxdesp_Class, "") != 0 )
                  {
                     subGridxdesp_Linesclass = subGridxdesp_Class+"Even";
                  }
               }
            }
            if ( GridxdespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+"WorkWith"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_40_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridxdespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridxdespRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEmpID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEmpID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)40,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridxdespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridxdespRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempdsc_Internalname,(String)A44empdsc,StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtempdsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)40,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridxdespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridxdespRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAgeID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A2AgeID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A2AgeID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAgeID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)40,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridxdespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridxdespRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAgeDsc_Internalname,StringUtil.RTrim( A46AgeDsc),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAgeDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)40,(short)1,(short)-1,(short)-1,(bool)true,(String)"Descripcion",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridxdespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridxdespRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBodCod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A42BodCod), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A42BodCod), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBodCod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)40,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridxdespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridxdespRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBodDsc_Internalname,StringUtil.RTrim( A217BodDsc),StringUtil.RTrim( context.localUtil.Format( A217BodDsc, "@!")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBodDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)40,(short)1,(short)-1,(short)-1,(bool)true,(String)"nombres",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridxdespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridxdespRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodNro_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A353DespBodNro), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A353DespBodNro), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodNro_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWActionColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)40,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridxdespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            GridxdespRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A22OrdenID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A22OrdenID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenID_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)120,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)40,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridxdespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridxdespRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClienteID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A5ClienteID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A5ClienteID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtClienteID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)40,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridxdespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridxdespRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClienteRUC_Internalname,StringUtil.RTrim( A56ClienteRUC),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtClienteRUC_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)130,(String)"px",(short)17,(String)"px",(short)13,(short)0,(short)0,(short)40,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridxdespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridxdespRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClienteDsc_Internalname,StringUtil.RTrim( A57ClienteDsc),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtClienteDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)40,(short)1,(short)-1,(short)-1,(bool)true,(String)"Descripcion",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridxdespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ImageAttribute";
            StyleString = "";
            AV14Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV14Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV27Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV14Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV14Update)) ? AV27Update_GXI : context.PathToRelativeUrl( AV14Update));
            GridxdespRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV14Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridxdespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavActionupdate_Enabled!=0)&&(edtavActionupdate_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 53,'',false,'',40)\"" : " ");
            ClassString = "ImageAttribute";
            StyleString = "";
            AV23actionUpdate_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV23actionUpdate))&&String.IsNullOrEmpty(StringUtil.RTrim( AV28Actionupdate_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV23actionUpdate)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV23actionUpdate)) ? AV28Actionupdate_GXI : context.PathToRelativeUrl( AV23actionUpdate));
            GridxdespRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavActionupdate_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavActionupdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavActionupdate_Jsonclick,"'"+""+"'"+",false,"+"'"+"E\\'CHANGESTATUS\\'."+sGXsfl_40_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV23actionUpdate_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            send_integrity_lvl_hashes5U2( ) ;
            GridxdespContainer.AddRow(GridxdespRow);
            nGXsfl_40_idx = (short)(((subGridxdesp_Islastpage==1)&&(nGXsfl_40_idx+1>subGridxdesp_Recordsperpage( )) ? 1 : nGXsfl_40_idx+1));
            sGXsfl_40_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_40_idx), 4, 0)), 4, "0");
            SubsflControlProps_402( ) ;
         }
         /* End function sendrow_402 */
      }

      protected void SubsflControlProps_613( )
      {
         edtEmpID_Internalname = "EMPID_"+sGXsfl_40_idx;
         edtempdsc_Internalname = "EMPDSC_"+sGXsfl_40_idx;
         edtAgeID_Internalname = "AGEID_"+sGXsfl_40_idx;
         edtAgeDsc_Internalname = "AGEDSC_"+sGXsfl_40_idx;
         edtBodCod_Internalname = "BODCOD_"+sGXsfl_40_idx;
         edtBodDsc_Internalname = "BODDSC_"+sGXsfl_40_idx;
         edtDespBodNro_Internalname = "DESPBODNRO_"+sGXsfl_40_idx;
         edtOrdenID_Internalname = "ORDENID_"+sGXsfl_40_idx;
         edtClienteID_Internalname = "CLIENTEID_"+sGXsfl_40_idx;
         edtClienteRUC_Internalname = "CLIENTERUC_"+sGXsfl_40_idx;
         edtClienteDsc_Internalname = "CLIENTEDSC_"+sGXsfl_40_idx;
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_61_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_61_idx;
      }

      protected void SubsflControlProps_fel_613( )
      {
         edtEmpID_Internalname = "EMPID_"+sGXsfl_40_idx;
         edtempdsc_Internalname = "EMPDSC_"+sGXsfl_40_idx;
         edtAgeID_Internalname = "AGEID_"+sGXsfl_40_idx;
         edtAgeDsc_Internalname = "AGEDSC_"+sGXsfl_40_idx;
         edtBodCod_Internalname = "BODCOD_"+sGXsfl_40_idx;
         edtBodDsc_Internalname = "BODDSC_"+sGXsfl_40_idx;
         edtDespBodNro_Internalname = "DESPBODNRO_"+sGXsfl_40_idx;
         edtOrdenID_Internalname = "ORDENID_"+sGXsfl_40_idx;
         edtClienteID_Internalname = "CLIENTEID_"+sGXsfl_40_idx;
         edtClienteRUC_Internalname = "CLIENTERUC_"+sGXsfl_40_idx;
         edtClienteDsc_Internalname = "CLIENTEDSC_"+sGXsfl_40_idx;
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_61_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_61_fel_idx;
      }

      protected void sendrow_613( )
      {
         SubsflControlProps_613( ) ;
         WB5U0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_61_idx <= subGriddesp_Recordsperpage( ) * 1 ) )
         {
            GriddespRow = GXWebRow.GetNew(context,GriddespContainer);
            if ( subGriddesp_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGriddesp_Backstyle = 0;
               if ( StringUtil.StrCmp(subGriddesp_Class, "") != 0 )
               {
                  subGriddesp_Linesclass = subGriddesp_Class+"Odd";
               }
            }
            else if ( subGriddesp_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGriddesp_Backstyle = 0;
               subGriddesp_Backcolor = subGriddesp_Allbackcolor;
               if ( StringUtil.StrCmp(subGriddesp_Class, "") != 0 )
               {
                  subGriddesp_Linesclass = subGriddesp_Class+"Uniform";
               }
            }
            else if ( subGriddesp_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGriddesp_Backstyle = 1;
               if ( StringUtil.StrCmp(subGriddesp_Class, "") != 0 )
               {
                  subGriddesp_Linesclass = subGriddesp_Class+"Odd";
               }
               subGriddesp_Backcolor = (int)(0x0);
            }
            else if ( subGriddesp_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGriddesp_Backstyle = 1;
               if ( ((int)(((nGXsfl_61_idx-1)/ (decimal)(1)) % (2))) == 0 )
               {
                  subGriddesp_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGriddesp_Class, "") != 0 )
                  {
                     subGriddesp_Linesclass = subGriddesp_Class+"Odd";
                  }
               }
               else
               {
                  subGriddesp_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGriddesp_Class, "") != 0 )
                  {
                     subGriddesp_Linesclass = subGriddesp_Class+"Even";
                  }
               }
            }
            if ( GriddespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+"WorkWith"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_61_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GriddespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GriddespRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEmpID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEmpID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)61,(short)1,(short)-1,(short)0,(bool)false,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GriddespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GriddespRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempdsc_Internalname,(String)A44empdsc,StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtempdsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)61,(short)1,(short)-1,(short)-1,(bool)false,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GriddespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GriddespRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAgeID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A2AgeID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A2AgeID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAgeID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)61,(short)1,(short)-1,(short)0,(bool)false,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GriddespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GriddespRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAgeDsc_Internalname,StringUtil.RTrim( A46AgeDsc),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAgeDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)61,(short)1,(short)-1,(short)-1,(bool)false,(String)"Descripcion",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GriddespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GriddespRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBodCod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A42BodCod), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A42BodCod), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBodCod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)61,(short)1,(short)-1,(short)0,(bool)false,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GriddespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GriddespRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBodDsc_Internalname,StringUtil.RTrim( A217BodDsc),StringUtil.RTrim( context.localUtil.Format( A217BodDsc, "@!")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBodDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)61,(short)1,(short)-1,(short)-1,(bool)false,(String)"nombres",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GriddespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GriddespRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodNro_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A353DespBodNro), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A353DespBodNro), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodNro_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWActionColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)61,(short)1,(short)-1,(short)0,(bool)false,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GriddespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            GriddespRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A22OrdenID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A22OrdenID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenID_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)120,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)61,(short)1,(short)-1,(short)0,(bool)false,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GriddespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GriddespRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClienteID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A5ClienteID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A5ClienteID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtClienteID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)61,(short)1,(short)-1,(short)0,(bool)false,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GriddespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GriddespRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClienteRUC_Internalname,StringUtil.RTrim( A56ClienteRUC),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtClienteRUC_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)130,(String)"px",(short)17,(String)"px",(short)13,(short)0,(short)0,(short)61,(short)1,(short)-1,(short)-1,(bool)false,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GriddespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GriddespRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClienteDsc_Internalname,StringUtil.RTrim( A57ClienteDsc),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtClienteDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)61,(short)1,(short)-1,(short)-1,(bool)false,(String)"Descripcion",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GriddespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ImageAttribute";
            StyleString = "";
            AV22display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV22display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV29Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV22display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV22display)) ? AV29Display_GXI : context.PathToRelativeUrl( AV22display));
            GriddespRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV22display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GriddespContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ImageAttribute";
            StyleString = "";
            AV15Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV15Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV30Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV15Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV15Delete)) ? AV30Delete_GXI : context.PathToRelativeUrl( AV15Delete));
            GriddespRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)0,(short)0,(String)"",(String)"Eliminar",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV15Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            send_integrity_lvl_hashes5U3( ) ;
            GriddespContainer.AddRow(GriddespRow);
            nGXsfl_61_idx = (short)(((subGriddesp_Islastpage==1)&&(nGXsfl_61_idx+1>subGriddesp_Recordsperpage( )) ? 1 : nGXsfl_61_idx+1));
            sGXsfl_61_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_61_idx), 4, 0)), 4, "0");
            SubsflControlProps_613( ) ;
         }
         /* End function sendrow_613 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTitletext_Internalname = "TITLETEXT";
         bttBtninsert_Internalname = "BTNINSERT";
         edtavDespbodopid_Internalname = "vDESPBODOPID";
         divTabletop_Internalname = "TABLETOP";
         edtavClientdsc_Internalname = "vCLIENTDSC";
         divTable1_Internalname = "TABLE1";
         lblTabpage1_title_Internalname = "TABPAGE1_TITLE";
         edtEmpID_Internalname = "EMPID";
         edtempdsc_Internalname = "EMPDSC";
         edtAgeID_Internalname = "AGEID";
         edtAgeDsc_Internalname = "AGEDSC";
         edtBodCod_Internalname = "BODCOD";
         edtBodDsc_Internalname = "BODDSC";
         edtDespBodNro_Internalname = "DESPBODNRO";
         edtOrdenID_Internalname = "ORDENID";
         edtClienteID_Internalname = "CLIENTEID";
         edtClienteRUC_Internalname = "CLIENTERUC";
         edtClienteDsc_Internalname = "CLIENTEDSC";
         edtavUpdate_Internalname = "vUPDATE";
         edtavActionupdate_Internalname = "vACTIONUPDATE";
         divTabpage1table_Internalname = "TABPAGE1TABLE";
         lblTabpage2_title_Internalname = "TABPAGE2_TITLE";
         edtEmpID_Internalname = "EMPID";
         edtempdsc_Internalname = "EMPDSC";
         edtAgeID_Internalname = "AGEID";
         edtAgeDsc_Internalname = "AGEDSC";
         edtBodCod_Internalname = "BODCOD";
         edtBodDsc_Internalname = "BODDSC";
         edtDespBodNro_Internalname = "DESPBODNRO";
         edtOrdenID_Internalname = "ORDENID";
         edtClienteID_Internalname = "CLIENTEID";
         edtClienteRUC_Internalname = "CLIENTERUC";
         edtClienteDsc_Internalname = "CLIENTEDSC";
         edtavDisplay_Internalname = "vDISPLAY";
         edtavDelete_Internalname = "vDELETE";
         divTabpage2table_Internalname = "TABPAGE2TABLE";
         Tab1_Internalname = "TAB1";
         divGridtable_Internalname = "GRIDTABLE";
         divGridcell_Internalname = "GRIDCELL";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         subGridxdesp_Internalname = "GRIDXDESP";
         subGriddesp_Internalname = "GRIDDESP";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtavActionupdate_Visible = -1;
         edtavActionupdate_Enabled = 1;
         edtClienteDsc_Jsonclick = "";
         edtClienteRUC_Jsonclick = "";
         edtClienteID_Jsonclick = "";
         edtOrdenID_Jsonclick = "";
         edtDespBodNro_Jsonclick = "";
         edtBodDsc_Jsonclick = "";
         edtBodCod_Jsonclick = "";
         edtAgeDsc_Jsonclick = "";
         edtAgeID_Jsonclick = "";
         edtempdsc_Jsonclick = "";
         edtEmpID_Jsonclick = "";
         subGriddesp_Allowcollapsing = 0;
         subGriddesp_Allowselection = 0;
         edtavDisplay_Link = "";
         subGriddesp_Header = "";
         subGriddesp_Class = "WorkWith";
         subGriddesp_Backcolorstyle = 0;
         subGridxdesp_Allowcollapsing = 0;
         subGridxdesp_Allowselection = 0;
         edtavUpdate_Link = "";
         subGridxdesp_Header = "";
         subGridxdesp_Class = "WorkWith";
         subGridxdesp_Backcolorstyle = 0;
         edtavClientdsc_Jsonclick = "";
         edtavClientdsc_Enabled = 1;
         edtavDespbodopid_Jsonclick = "";
         edtavDespbodopid_Enabled = 1;
         Tab1_Historymanagement = Convert.ToBoolean( 0);
         Tab1_Pagecount = 2;
         Tab1_Class = "TabDespBod";
         Form.Caption = "Work With Despacho Bodega";
         subGriddesp_Rows = 10;
         edtavDisplay_Tooltiptext = "";
         subGridxdesp_Rows = 10;
         edtavActionupdate_Jsonclick = "";
         edtavActionupdate_Tooltiptext = "";
         edtavUpdate_Tooltiptext = "Modificar";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRIDXDESP_nFirstRecordOnPage'},{av:'GRIDXDESP_nEOF'},{av:'subGridxdesp_Rows',ctrl:'GRIDXDESP',prop:'Rows'},{av:'AV14Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV23actionUpdate',fld:'vACTIONUPDATE',pic:''},{av:'edtavActionupdate_Tooltiptext',ctrl:'vACTIONUPDATE',prop:'Tooltiptext'},{av:'edtavActionupdate_Jsonclick',ctrl:'vACTIONUPDATE',prop:'Jsonclick'},{av:'GRIDDESP_nFirstRecordOnPage'},{av:'GRIDDESP_nEOF'},{av:'subGriddesp_Rows',ctrl:'GRIDDESP',prop:'Rows'},{av:'AV21clientDsc',fld:'vCLIENTDSC',pic:''},{av:'AV22display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'AV26Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13DespBodOpId',fld:'vDESPBODOPID',pic:'ZZZ9'},{av:'AV19usucod',fld:'vUSUCOD',pic:'',hsh:true},{av:'AV17empId',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV18ageID',fld:'vAGEID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("GRIDXDESP.LOAD","{handler:'E145U2',iparms:[{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'A2AgeID',fld:'AGEID',pic:'ZZZ9'},{av:'A353DespBodNro',fld:'DESPBODNRO',pic:'ZZZ9',hsh:true},{av:'A22OrdenID',fld:'ORDENID',pic:'ZZZ9',hsh:true},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9',hsh:true},{av:'AV19usucod',fld:'vUSUCOD',pic:'',hsh:true}]");
         setEventMetadata("GRIDXDESP.LOAD",",oparms:[{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'}]}");
         setEventMetadata("GRIDDESP.LOAD","{handler:'E165U3',iparms:[{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'A2AgeID',fld:'AGEID',pic:'ZZZ9'},{av:'A353DespBodNro',fld:'DESPBODNRO',pic:'ZZZ9',hsh:true},{av:'A22OrdenID',fld:'ORDENID',pic:'ZZZ9',hsh:true},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9',hsh:true},{av:'AV19usucod',fld:'vUSUCOD',pic:'',hsh:true}]");
         setEventMetadata("GRIDDESP.LOAD",",oparms:[{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E115U2',iparms:[{av:'AV17empId',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV18ageID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'A353DespBodNro',fld:'DESPBODNRO',pic:'ZZZ9',hsh:true},{av:'A22OrdenID',fld:'ORDENID',pic:'ZZZ9',hsh:true},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9',hsh:true},{av:'AV19usucod',fld:'vUSUCOD',pic:'',hsh:true}]");
         setEventMetadata("'DOINSERT'",",oparms:[]}");
         setEventMetadata("'CHANGESTATUS'","{handler:'E155U2',iparms:[{av:'AV17empId',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV18ageID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'A353DespBodNro',fld:'DESPBODNRO',pic:'ZZZ9',hsh:true},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9',hsh:true},{av:'A22OrdenID',fld:'ORDENID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("'CHANGESTATUS'",",oparms:[]}");
         setEventMetadata("GRIDXDESP_FIRSTPAGE","{handler:'subgridxdesp_firstpage',iparms:[{av:'GRIDXDESP_nFirstRecordOnPage'},{av:'GRIDXDESP_nEOF'},{av:'subGridxdesp_Rows',ctrl:'GRIDXDESP',prop:'Rows'},{av:'AV21clientDsc',fld:'vCLIENTDSC',pic:''},{av:'AV14Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV23actionUpdate',fld:'vACTIONUPDATE',pic:''},{av:'edtavActionupdate_Tooltiptext',ctrl:'vACTIONUPDATE',prop:'Tooltiptext'},{av:'edtavActionupdate_Jsonclick',ctrl:'vACTIONUPDATE',prop:'Jsonclick'},{av:'AV19usucod',fld:'vUSUCOD',pic:'',hsh:true},{av:'AV17empId',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV18ageID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV26Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13DespBodOpId',fld:'vDESPBODOPID',pic:'ZZZ9'}]");
         setEventMetadata("GRIDXDESP_FIRSTPAGE",",oparms:[]}");
         setEventMetadata("GRIDXDESP_PREVPAGE","{handler:'subgridxdesp_previouspage',iparms:[{av:'GRIDXDESP_nFirstRecordOnPage'},{av:'GRIDXDESP_nEOF'},{av:'subGridxdesp_Rows',ctrl:'GRIDXDESP',prop:'Rows'},{av:'AV21clientDsc',fld:'vCLIENTDSC',pic:''},{av:'AV14Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV23actionUpdate',fld:'vACTIONUPDATE',pic:''},{av:'edtavActionupdate_Tooltiptext',ctrl:'vACTIONUPDATE',prop:'Tooltiptext'},{av:'edtavActionupdate_Jsonclick',ctrl:'vACTIONUPDATE',prop:'Jsonclick'},{av:'AV19usucod',fld:'vUSUCOD',pic:'',hsh:true},{av:'AV17empId',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV18ageID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV26Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13DespBodOpId',fld:'vDESPBODOPID',pic:'ZZZ9'}]");
         setEventMetadata("GRIDXDESP_PREVPAGE",",oparms:[]}");
         setEventMetadata("GRIDXDESP_NEXTPAGE","{handler:'subgridxdesp_nextpage',iparms:[{av:'GRIDXDESP_nFirstRecordOnPage'},{av:'GRIDXDESP_nEOF'},{av:'subGridxdesp_Rows',ctrl:'GRIDXDESP',prop:'Rows'},{av:'AV21clientDsc',fld:'vCLIENTDSC',pic:''},{av:'AV14Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV23actionUpdate',fld:'vACTIONUPDATE',pic:''},{av:'edtavActionupdate_Tooltiptext',ctrl:'vACTIONUPDATE',prop:'Tooltiptext'},{av:'edtavActionupdate_Jsonclick',ctrl:'vACTIONUPDATE',prop:'Jsonclick'},{av:'AV19usucod',fld:'vUSUCOD',pic:'',hsh:true},{av:'AV17empId',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV18ageID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV26Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13DespBodOpId',fld:'vDESPBODOPID',pic:'ZZZ9'}]");
         setEventMetadata("GRIDXDESP_NEXTPAGE",",oparms:[]}");
         setEventMetadata("GRIDXDESP_LASTPAGE","{handler:'subgridxdesp_lastpage',iparms:[{av:'GRIDXDESP_nFirstRecordOnPage'},{av:'GRIDXDESP_nEOF'},{av:'subGridxdesp_Rows',ctrl:'GRIDXDESP',prop:'Rows'},{av:'AV21clientDsc',fld:'vCLIENTDSC',pic:''},{av:'AV14Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV23actionUpdate',fld:'vACTIONUPDATE',pic:''},{av:'edtavActionupdate_Tooltiptext',ctrl:'vACTIONUPDATE',prop:'Tooltiptext'},{av:'edtavActionupdate_Jsonclick',ctrl:'vACTIONUPDATE',prop:'Jsonclick'},{av:'AV19usucod',fld:'vUSUCOD',pic:'',hsh:true},{av:'AV17empId',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV18ageID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV26Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13DespBodOpId',fld:'vDESPBODOPID',pic:'ZZZ9'}]");
         setEventMetadata("GRIDXDESP_LASTPAGE",",oparms:[]}");
         setEventMetadata("GRIDDESP_FIRSTPAGE","{handler:'subgriddesp_firstpage',iparms:[{av:'GRIDDESP_nFirstRecordOnPage'},{av:'GRIDDESP_nEOF'},{av:'subGriddesp_Rows',ctrl:'GRIDDESP',prop:'Rows'},{av:'AV21clientDsc',fld:'vCLIENTDSC',pic:''},{av:'AV22display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'AV19usucod',fld:'vUSUCOD',pic:'',hsh:true},{av:'AV17empId',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV18ageID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV26Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13DespBodOpId',fld:'vDESPBODOPID',pic:'ZZZ9'}]");
         setEventMetadata("GRIDDESP_FIRSTPAGE",",oparms:[]}");
         setEventMetadata("GRIDDESP_PREVPAGE","{handler:'subgriddesp_previouspage',iparms:[{av:'GRIDDESP_nFirstRecordOnPage'},{av:'GRIDDESP_nEOF'},{av:'subGriddesp_Rows',ctrl:'GRIDDESP',prop:'Rows'},{av:'AV21clientDsc',fld:'vCLIENTDSC',pic:''},{av:'AV22display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'AV19usucod',fld:'vUSUCOD',pic:'',hsh:true},{av:'AV17empId',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV18ageID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV26Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13DespBodOpId',fld:'vDESPBODOPID',pic:'ZZZ9'}]");
         setEventMetadata("GRIDDESP_PREVPAGE",",oparms:[]}");
         setEventMetadata("GRIDDESP_NEXTPAGE","{handler:'subgriddesp_nextpage',iparms:[{av:'GRIDDESP_nFirstRecordOnPage'},{av:'GRIDDESP_nEOF'},{av:'subGriddesp_Rows',ctrl:'GRIDDESP',prop:'Rows'},{av:'AV21clientDsc',fld:'vCLIENTDSC',pic:''},{av:'AV22display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'AV19usucod',fld:'vUSUCOD',pic:'',hsh:true},{av:'AV17empId',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV18ageID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV26Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13DespBodOpId',fld:'vDESPBODOPID',pic:'ZZZ9'}]");
         setEventMetadata("GRIDDESP_NEXTPAGE",",oparms:[]}");
         setEventMetadata("GRIDDESP_LASTPAGE","{handler:'subgriddesp_lastpage',iparms:[{av:'GRIDDESP_nFirstRecordOnPage'},{av:'GRIDDESP_nEOF'},{av:'subGriddesp_Rows',ctrl:'GRIDDESP',prop:'Rows'},{av:'AV21clientDsc',fld:'vCLIENTDSC',pic:''},{av:'AV22display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'AV19usucod',fld:'vUSUCOD',pic:'',hsh:true},{av:'AV17empId',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV18ageID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV26Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13DespBodOpId',fld:'vDESPBODOPID',pic:'ZZZ9'}]");
         setEventMetadata("GRIDDESP_LASTPAGE",",oparms:[]}");
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
         wcpOAV19usucod = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV14Update = "";
         AV23actionUpdate = "";
         AV21clientDsc = "";
         AV26Pgmname = "";
         GXKey = "";
         AV22display = "";
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
         lblTabpage1_title_Jsonclick = "";
         GridxdespContainer = new GXWebGrid( context);
         sStyleString = "";
         subGridxdesp_Linesclass = "";
         GridxdespColumn = new GXWebColumn();
         A44empdsc = "";
         A46AgeDsc = "";
         A217BodDsc = "";
         A56ClienteRUC = "";
         A57ClienteDsc = "";
         lblTabpage2_title_Jsonclick = "";
         GriddespContainer = new GXWebGrid( context);
         subGriddesp_Linesclass = "";
         GriddespColumn = new GXWebColumn();
         AV15Delete = "";
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV27Update_GXI = "";
         AV28Actionupdate_GXI = "";
         AV29Display_GXI = "";
         AV30Delete_GXI = "";
         scmdbuf = "";
         lV21clientDsc = "";
         A402DespachadoOK = "";
         H005U2_A402DespachadoOK = new String[] {""} ;
         H005U2_n402DespachadoOK = new bool[] {false} ;
         H005U2_A57ClienteDsc = new String[] {""} ;
         H005U2_n57ClienteDsc = new bool[] {false} ;
         H005U2_A56ClienteRUC = new String[] {""} ;
         H005U2_n56ClienteRUC = new bool[] {false} ;
         H005U2_A5ClienteID = new short[1] ;
         H005U2_A22OrdenID = new short[1] ;
         H005U2_A353DespBodNro = new short[1] ;
         H005U2_A217BodDsc = new String[] {""} ;
         H005U2_n217BodDsc = new bool[] {false} ;
         H005U2_A42BodCod = new short[1] ;
         H005U2_A46AgeDsc = new String[] {""} ;
         H005U2_n46AgeDsc = new bool[] {false} ;
         H005U2_A2AgeID = new short[1] ;
         H005U2_A44empdsc = new String[] {""} ;
         H005U2_n44empdsc = new bool[] {false} ;
         H005U2_A1EmpID = new short[1] ;
         H005U3_A402DespachadoOK = new String[] {""} ;
         H005U3_n402DespachadoOK = new bool[] {false} ;
         H005U3_A57ClienteDsc = new String[] {""} ;
         H005U3_n57ClienteDsc = new bool[] {false} ;
         H005U3_A56ClienteRUC = new String[] {""} ;
         H005U3_n56ClienteRUC = new bool[] {false} ;
         H005U3_A5ClienteID = new short[1] ;
         H005U3_A22OrdenID = new short[1] ;
         H005U3_A353DespBodNro = new short[1] ;
         H005U3_A217BodDsc = new String[] {""} ;
         H005U3_n217BodDsc = new bool[] {false} ;
         H005U3_A42BodCod = new short[1] ;
         H005U3_A46AgeDsc = new String[] {""} ;
         H005U3_n46AgeDsc = new bool[] {false} ;
         H005U3_A2AgeID = new short[1] ;
         H005U3_A44empdsc = new String[] {""} ;
         H005U3_n44empdsc = new bool[] {false} ;
         H005U3_A1EmpID = new short[1] ;
         H005U4_AGRIDXDESP_nRecordCount = new long[1] ;
         H005U5_AGRIDDESP_nRecordCount = new long[1] ;
         GridxdespRow = new GXWebRow();
         AV7HTTPRequest = new GxHttpRequest( context);
         AV8GridState = new SdtGridState(context);
         AV6Session = context.GetSession();
         AV9GridStateFilterValue = new SdtGridState_FilterValue(context);
         AV11TrnContext = new SdtTransactionContext(context);
         GriddespRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         sImgUrl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwdespbodega__default(),
            new Object[][] {
                new Object[] {
               H005U2_A402DespachadoOK, H005U2_n402DespachadoOK, H005U2_A57ClienteDsc, H005U2_n57ClienteDsc, H005U2_A56ClienteRUC, H005U2_n56ClienteRUC, H005U2_A5ClienteID, H005U2_A22OrdenID, H005U2_A353DespBodNro, H005U2_A217BodDsc,
               H005U2_n217BodDsc, H005U2_A42BodCod, H005U2_A46AgeDsc, H005U2_n46AgeDsc, H005U2_A2AgeID, H005U2_A44empdsc, H005U2_n44empdsc, H005U2_A1EmpID
               }
               , new Object[] {
               H005U3_A402DespachadoOK, H005U3_n402DespachadoOK, H005U3_A57ClienteDsc, H005U3_n57ClienteDsc, H005U3_A56ClienteRUC, H005U3_n56ClienteRUC, H005U3_A5ClienteID, H005U3_A22OrdenID, H005U3_A353DespBodNro, H005U3_A217BodDsc,
               H005U3_n217BodDsc, H005U3_A42BodCod, H005U3_A46AgeDsc, H005U3_n46AgeDsc, H005U3_A2AgeID, H005U3_A44empdsc, H005U3_n44empdsc, H005U3_A1EmpID
               }
               , new Object[] {
               H005U4_AGRIDXDESP_nRecordCount
               }
               , new Object[] {
               H005U5_AGRIDDESP_nRecordCount
               }
            }
         );
         AV26Pgmname = "WWDespBodega";
         /* GeneXus formulas. */
         AV26Pgmname = "WWDespBodega";
         context.Gx_err = 0;
      }

      private short AV17empId ;
      private short AV18ageID ;
      private short wcpOAV17empId ;
      private short wcpOAV18ageID ;
      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_40 ;
      private short nGXsfl_40_idx=1 ;
      private short nRC_GXsfl_61 ;
      private short GRIDXDESP_nEOF ;
      private short GRIDDESP_nEOF ;
      private short AV13DespBodOpId ;
      private short nGXsfl_61_idx=1 ;
      private short initialized ;
      private short nGXWrapped ;
      private short wbEnd ;
      private short wbStart ;
      private short subGridxdesp_Backcolorstyle ;
      private short subGridxdesp_Titlebackstyle ;
      private short A1EmpID ;
      private short A2AgeID ;
      private short A42BodCod ;
      private short A353DespBodNro ;
      private short A22OrdenID ;
      private short A5ClienteID ;
      private short subGridxdesp_Allowselection ;
      private short subGridxdesp_Allowhovering ;
      private short subGridxdesp_Allowcollapsing ;
      private short subGridxdesp_Collapsed ;
      private short subGriddesp_Backcolorstyle ;
      private short subGriddesp_Titlebackstyle ;
      private short subGriddesp_Allowselection ;
      private short subGriddesp_Allowhovering ;
      private short subGriddesp_Allowcollapsing ;
      private short subGriddesp_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short subGridxdesp_Backstyle ;
      private short subGriddesp_Backstyle ;
      private int subGridxdesp_Rows ;
      private int subGriddesp_Rows ;
      private int Tab1_Pagecount ;
      private int edtavDespbodopid_Enabled ;
      private int edtavClientdsc_Enabled ;
      private int subGridxdesp_Titlebackcolor ;
      private int subGridxdesp_Allbackcolor ;
      private int subGridxdesp_Selectedindex ;
      private int subGridxdesp_Selectioncolor ;
      private int subGridxdesp_Hoveringcolor ;
      private int subGriddesp_Titlebackcolor ;
      private int subGriddesp_Allbackcolor ;
      private int subGriddesp_Selectedindex ;
      private int subGriddesp_Selectioncolor ;
      private int subGriddesp_Hoveringcolor ;
      private int subGridxdesp_Islastpage ;
      private int subGriddesp_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int GXPagingFrom3 ;
      private int GXPagingTo3 ;
      private int AV10GridPageCount ;
      private int idxLst ;
      private int subGridxdesp_Backcolor ;
      private int edtavActionupdate_Enabled ;
      private int edtavActionupdate_Visible ;
      private int subGriddesp_Backcolor ;
      private long GRIDXDESP_nFirstRecordOnPage ;
      private long GRIDDESP_nFirstRecordOnPage ;
      private long GRIDXDESP_nCurrentRecord ;
      private long GRIDDESP_nCurrentRecord ;
      private long GRIDXDESP_nRecordCount ;
      private long GRIDDESP_nRecordCount ;
      private String AV19usucod ;
      private String wcpOAV19usucod ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavActionupdate_Tooltiptext ;
      private String edtavActionupdate_Jsonclick ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_40_idx="0001" ;
      private String edtavUpdate_Internalname ;
      private String edtavActionupdate_Internalname ;
      private String AV21clientDsc ;
      private String AV26Pgmname ;
      private String GXKey ;
      private String sGXsfl_61_idx="0001" ;
      private String edtavDisplay_Tooltiptext ;
      private String edtavDisplay_Internalname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String Tab1_Class ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String divTabletop_Internalname ;
      private String lblTitletext_Internalname ;
      private String lblTitletext_Jsonclick ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtninsert_Internalname ;
      private String bttBtninsert_Jsonclick ;
      private String edtavDespbodopid_Internalname ;
      private String edtavDespbodopid_Jsonclick ;
      private String divGridcell_Internalname ;
      private String divGridtable_Internalname ;
      private String divTable1_Internalname ;
      private String edtavClientdsc_Internalname ;
      private String edtavClientdsc_Jsonclick ;
      private String lblTabpage1_title_Internalname ;
      private String lblTabpage1_title_Jsonclick ;
      private String divTabpage1table_Internalname ;
      private String sStyleString ;
      private String subGridxdesp_Internalname ;
      private String subGridxdesp_Class ;
      private String subGridxdesp_Linesclass ;
      private String subGridxdesp_Header ;
      private String A46AgeDsc ;
      private String A217BodDsc ;
      private String A56ClienteRUC ;
      private String A57ClienteDsc ;
      private String edtavUpdate_Link ;
      private String lblTabpage2_title_Internalname ;
      private String lblTabpage2_title_Jsonclick ;
      private String divTabpage2table_Internalname ;
      private String subGriddesp_Internalname ;
      private String subGriddesp_Class ;
      private String subGriddesp_Linesclass ;
      private String subGriddesp_Header ;
      private String edtavDisplay_Link ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtEmpID_Internalname ;
      private String edtempdsc_Internalname ;
      private String edtAgeID_Internalname ;
      private String edtAgeDsc_Internalname ;
      private String edtBodCod_Internalname ;
      private String edtBodDsc_Internalname ;
      private String edtDespBodNro_Internalname ;
      private String edtOrdenID_Internalname ;
      private String edtClienteID_Internalname ;
      private String edtClienteRUC_Internalname ;
      private String edtClienteDsc_Internalname ;
      private String edtavDelete_Internalname ;
      private String scmdbuf ;
      private String lV21clientDsc ;
      private String A402DespachadoOK ;
      private String sGXsfl_40_fel_idx="0001" ;
      private String ROClassString ;
      private String edtEmpID_Jsonclick ;
      private String edtempdsc_Jsonclick ;
      private String edtAgeID_Jsonclick ;
      private String edtAgeDsc_Jsonclick ;
      private String edtBodCod_Jsonclick ;
      private String edtBodDsc_Jsonclick ;
      private String edtDespBodNro_Jsonclick ;
      private String edtOrdenID_Jsonclick ;
      private String edtClienteID_Jsonclick ;
      private String edtClienteRUC_Jsonclick ;
      private String edtClienteDsc_Jsonclick ;
      private String sImgUrl ;
      private String sGXsfl_61_fel_idx="0001" ;
      private String Tab1_Internalname ;
      private bool entryPointCalled ;
      private bool bGXsfl_40_Refreshing=false ;
      private bool bGXsfl_61_Refreshing=false ;
      private bool toggleJsOutput ;
      private bool Tab1_Historymanagement ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n44empdsc ;
      private bool n46AgeDsc ;
      private bool n217BodDsc ;
      private bool n56ClienteRUC ;
      private bool n57ClienteDsc ;
      private bool gxdyncontrolsrefreshing ;
      private bool n402DespachadoOK ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV14Update_IsBlob ;
      private bool AV23actionUpdate_IsBlob ;
      private bool AV22display_IsBlob ;
      private bool AV15Delete_IsBlob ;
      private String A44empdsc ;
      private String AV27Update_GXI ;
      private String AV28Actionupdate_GXI ;
      private String AV29Display_GXI ;
      private String AV30Delete_GXI ;
      private String AV14Update ;
      private String AV23actionUpdate ;
      private String AV22display ;
      private String AV15Delete ;
      private IGxSession AV6Session ;
      private GXWebGrid GridxdespContainer ;
      private GXWebGrid GriddespContainer ;
      private GXWebRow GridxdespRow ;
      private GXWebRow GriddespRow ;
      private GXWebColumn GridxdespColumn ;
      private GXWebColumn GriddespColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H005U2_A402DespachadoOK ;
      private bool[] H005U2_n402DespachadoOK ;
      private String[] H005U2_A57ClienteDsc ;
      private bool[] H005U2_n57ClienteDsc ;
      private String[] H005U2_A56ClienteRUC ;
      private bool[] H005U2_n56ClienteRUC ;
      private short[] H005U2_A5ClienteID ;
      private short[] H005U2_A22OrdenID ;
      private short[] H005U2_A353DespBodNro ;
      private String[] H005U2_A217BodDsc ;
      private bool[] H005U2_n217BodDsc ;
      private short[] H005U2_A42BodCod ;
      private String[] H005U2_A46AgeDsc ;
      private bool[] H005U2_n46AgeDsc ;
      private short[] H005U2_A2AgeID ;
      private String[] H005U2_A44empdsc ;
      private bool[] H005U2_n44empdsc ;
      private short[] H005U2_A1EmpID ;
      private String[] H005U3_A402DespachadoOK ;
      private bool[] H005U3_n402DespachadoOK ;
      private String[] H005U3_A57ClienteDsc ;
      private bool[] H005U3_n57ClienteDsc ;
      private String[] H005U3_A56ClienteRUC ;
      private bool[] H005U3_n56ClienteRUC ;
      private short[] H005U3_A5ClienteID ;
      private short[] H005U3_A22OrdenID ;
      private short[] H005U3_A353DespBodNro ;
      private String[] H005U3_A217BodDsc ;
      private bool[] H005U3_n217BodDsc ;
      private short[] H005U3_A42BodCod ;
      private String[] H005U3_A46AgeDsc ;
      private bool[] H005U3_n46AgeDsc ;
      private short[] H005U3_A2AgeID ;
      private String[] H005U3_A44empdsc ;
      private bool[] H005U3_n44empdsc ;
      private short[] H005U3_A1EmpID ;
      private long[] H005U4_AGRIDXDESP_nRecordCount ;
      private long[] H005U5_AGRIDDESP_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV7HTTPRequest ;
      private SdtGridState AV8GridState ;
      private SdtGridState_FilterValue AV9GridStateFilterValue ;
      private SdtTransactionContext AV11TrnContext ;
   }

   public class wwdespbodega__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H005U2( IGxContext context ,
                                             short AV13DespBodOpId ,
                                             String AV21clientDsc ,
                                             short A22OrdenID ,
                                             String A57ClienteDsc ,
                                             String A402DespachadoOK )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [5] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " T1.[DespachadoOK], T4.[ClienteDsc], T4.[ClienteRUC], T1.[ClienteID], T1.[OrdenID], T1.[DespBodNro], T5.[BodDsc], T1.[BodCod], T3.[AgeDsc], T1.[AgeID], T2.[empdsc], T1.[EmpID]";
         sFromString = " FROM (((([DespBodega] T1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID]) INNER JOIN [Agencias] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[AgeID] = T1.[AgeID]) INNER JOIN [Clientes] T4 WITH (NOLOCK) ON T4.[EmpID] = T1.[EmpID] AND T4.[ClienteID] = T1.[ClienteID]) INNER JOIN [Bodegas] T5 WITH (NOLOCK) ON T5.[EmpID] = T1.[EmpID] AND T5.[BodCod] = T1.[BodCod])";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (T1.[DespachadoOK] IS NULL or T1.[DespachadoOK] = '' or T1.[DespachadoOK] = 'N')";
         if ( ! (0==AV13DespBodOpId) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenID] >= @AV13DespBodOpId)";
         }
         else
         {
            GXv_int1[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV21clientDsc)) )
         {
            sWhereString = sWhereString + " and (T4.[ClienteDsc] like '%' + @lV21clientDsc + '%')";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         sOrderString = sOrderString + " ORDER BY T1.[DespBodNro]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H005U3( IGxContext context ,
                                             short AV13DespBodOpId ,
                                             String AV21clientDsc ,
                                             short A22OrdenID ,
                                             String A57ClienteDsc ,
                                             String A402DespachadoOK )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [5] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " T1.[DespachadoOK], T4.[ClienteDsc], T4.[ClienteRUC], T1.[ClienteID], T1.[OrdenID], T1.[DespBodNro], T5.[BodDsc], T1.[BodCod], T3.[AgeDsc], T1.[AgeID], T2.[empdsc], T1.[EmpID]";
         sFromString = " FROM (((([DespBodega] T1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID]) INNER JOIN [Agencias] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[AgeID] = T1.[AgeID]) INNER JOIN [Clientes] T4 WITH (NOLOCK) ON T4.[EmpID] = T1.[EmpID] AND T4.[ClienteID] = T1.[ClienteID]) INNER JOIN [Bodegas] T5 WITH (NOLOCK) ON T5.[EmpID] = T1.[EmpID] AND T5.[BodCod] = T1.[BodCod])";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (T1.[DespachadoOK] <> '')";
         if ( ! (0==AV13DespBodOpId) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenID] >= @AV13DespBodOpId)";
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV21clientDsc)) )
         {
            sWhereString = sWhereString + " and (T4.[ClienteDsc] like '%' + @lV21clientDsc + '%')";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         sOrderString = sOrderString + " ORDER BY T1.[DespBodNro]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom3" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo3" + " > 0 THEN " + "@GXPagingTo3" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H005U4( IGxContext context ,
                                             short AV13DespBodOpId ,
                                             String AV21clientDsc ,
                                             short A22OrdenID ,
                                             String A57ClienteDsc ,
                                             String A402DespachadoOK )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [2] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM (((([DespBodega] T1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID]) INNER JOIN [Agencias] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[AgeID] = T1.[AgeID]) INNER JOIN [Clientes] T4 WITH (NOLOCK) ON T4.[EmpID] = T1.[EmpID] AND T4.[ClienteID] = T1.[ClienteID]) INNER JOIN [Bodegas] T5 WITH (NOLOCK) ON T5.[EmpID] = T1.[EmpID] AND T5.[BodCod] = T1.[BodCod])";
         scmdbuf = scmdbuf + " WHERE (T1.[DespachadoOK] IS NULL or T1.[DespachadoOK] = '' or T1.[DespachadoOK] = 'N')";
         if ( ! (0==AV13DespBodOpId) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenID] >= @AV13DespBodOpId)";
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV21clientDsc)) )
         {
            sWhereString = sWhereString + " and (T4.[ClienteDsc] like '%' + @lV21clientDsc + '%')";
         }
         else
         {
            GXv_int5[1] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + "";
         GXv_Object6[0] = scmdbuf;
         GXv_Object6[1] = GXv_int5;
         return GXv_Object6 ;
      }

      protected Object[] conditional_H005U5( IGxContext context ,
                                             short AV13DespBodOpId ,
                                             String AV21clientDsc ,
                                             short A22OrdenID ,
                                             String A57ClienteDsc ,
                                             String A402DespachadoOK )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int7 ;
         GXv_int7 = new short [2] ;
         Object[] GXv_Object8 ;
         GXv_Object8 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM (((([DespBodega] T1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID]) INNER JOIN [Agencias] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[AgeID] = T1.[AgeID]) INNER JOIN [Clientes] T4 WITH (NOLOCK) ON T4.[EmpID] = T1.[EmpID] AND T4.[ClienteID] = T1.[ClienteID]) INNER JOIN [Bodegas] T5 WITH (NOLOCK) ON T5.[EmpID] = T1.[EmpID] AND T5.[BodCod] = T1.[BodCod])";
         scmdbuf = scmdbuf + " WHERE (T1.[DespachadoOK] <> '')";
         if ( ! (0==AV13DespBodOpId) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenID] >= @AV13DespBodOpId)";
         }
         else
         {
            GXv_int7[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV21clientDsc)) )
         {
            sWhereString = sWhereString + " and (T4.[ClienteDsc] like '%' + @lV21clientDsc + '%')";
         }
         else
         {
            GXv_int7[1] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + "";
         GXv_Object8[0] = scmdbuf;
         GXv_Object8[1] = GXv_int7;
         return GXv_Object8 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H005U2(context, (short)dynConstraints[0] , (String)dynConstraints[1] , (short)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] );
               case 1 :
                     return conditional_H005U3(context, (short)dynConstraints[0] , (String)dynConstraints[1] , (short)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] );
               case 2 :
                     return conditional_H005U4(context, (short)dynConstraints[0] , (String)dynConstraints[1] , (short)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] );
               case 3 :
                     return conditional_H005U5(context, (short)dynConstraints[0] , (String)dynConstraints[1] , (short)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] );
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH005U2 ;
          prmH005U2 = new Object[] {
          new Object[] {"@AV13DespBodOpId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV21clientDsc",SqlDbType.Char,50,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH005U3 ;
          prmH005U3 = new Object[] {
          new Object[] {"@AV13DespBodOpId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV21clientDsc",SqlDbType.Char,50,0} ,
          new Object[] {"@GXPagingFrom3",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo3",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo3",SqlDbType.Int,9,0}
          } ;
          Object[] prmH005U4 ;
          prmH005U4 = new Object[] {
          new Object[] {"@AV13DespBodOpId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV21clientDsc",SqlDbType.Char,50,0}
          } ;
          Object[] prmH005U5 ;
          prmH005U5 = new Object[] {
          new Object[] {"@AV13DespBodOpId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV21clientDsc",SqlDbType.Char,50,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H005U2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005U2,11,0,true,false )
             ,new CursorDef("H005U3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005U3,11,0,false,false )
             ,new CursorDef("H005U4", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005U4,1,0,true,false )
             ,new CursorDef("H005U5", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005U5,1,0,false,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getString(3, 13) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((short[]) buf[6])[0] = rslt.getShort(4) ;
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                ((short[]) buf[8])[0] = rslt.getShort(6) ;
                ((String[]) buf[9])[0] = rslt.getString(7, 40) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(7);
                ((short[]) buf[11])[0] = rslt.getShort(8) ;
                ((String[]) buf[12])[0] = rslt.getString(9, 50) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(9);
                ((short[]) buf[14])[0] = rslt.getShort(10) ;
                ((String[]) buf[15])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(11);
                ((short[]) buf[17])[0] = rslt.getShort(12) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getString(3, 13) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((short[]) buf[6])[0] = rslt.getShort(4) ;
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                ((short[]) buf[8])[0] = rslt.getShort(6) ;
                ((String[]) buf[9])[0] = rslt.getString(7, 40) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(7);
                ((short[]) buf[11])[0] = rslt.getShort(8) ;
                ((String[]) buf[12])[0] = rslt.getString(9, 50) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(9);
                ((short[]) buf[14])[0] = rslt.getShort(10) ;
                ((String[]) buf[15])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(11);
                ((short[]) buf[17])[0] = rslt.getShort(12) ;
                return;
             case 2 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
             case 3 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
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
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[5]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[6]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[7]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[8]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[9]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[5]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[6]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[7]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[8]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[9]);
                }
                return;
             case 2 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[2]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[3]);
                }
                return;
             case 3 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[2]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[3]);
                }
                return;
       }
    }

 }

}
