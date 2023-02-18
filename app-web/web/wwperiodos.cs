/*
               File: WWPeriodos
        Description: Work With Periodos
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/7/2023 16:2:1.95
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
   public class wwperiodos : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public wwperiodos( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public wwperiodos( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_empID ,
                           short aP1_ageId ,
                           String aP2_usucod )
      {
         this.AV17empID = aP0_empID;
         this.AV18ageId = aP1_ageId;
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
         cmbavPeranio = new GXCombobox();
         cmbPerMesActual = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid") == 0 )
            {
               nRC_GXsfl_26 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_26_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_26_idx = GetNextPar( );
               AV14Update = GetNextPar( );
               edtavUpdate_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext, !bGXsfl_26_Refreshing);
               AV20periodoDet = GetNextPar( );
               edtavPeriododet_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPeriododet_Internalname, "Tooltiptext", edtavPeriododet_Tooltiptext, !bGXsfl_26_Refreshing);
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
               AV21perAnio = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV26Pgmname = GetNextPar( );
               AV13PerFchControl = context.localUtil.ParseDateParm( GetNextPar( ));
               AV14Update = GetNextPar( );
               edtavUpdate_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext, !bGXsfl_26_Refreshing);
               AV20periodoDet = GetNextPar( );
               edtavPeriododet_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPeriododet_Internalname, "Tooltiptext", edtavPeriododet_Tooltiptext, !bGXsfl_26_Refreshing);
               AV18ageId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV19usucod = GetNextPar( );
               AV17empID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV21perAnio, AV26Pgmname, AV13PerFchControl, AV14Update, AV20periodoDet, AV18ageId, AV19usucod, AV17empID) ;
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
               AV17empID = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17empID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17empID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV17empID), "ZZZ9"), context));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV18ageId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ageId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18ageId), 4, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV18ageId), "ZZZ9"), context));
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
            PA512( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV26Pgmname = "WWPeriodos";
               context.Gx_err = 0;
               WS512( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE512( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202317162216", false);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("wwperiodos.aspx") + "?" + UrlEncode("" +AV17empID) + "," + UrlEncode("" +AV18ageId) + "," + UrlEncode(StringUtil.RTrim(AV19usucod))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vPERANIO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21perAnio), 4, 0, ",", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_26", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_26), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV26Pgmname));
         GxWebStd.gx_hidden_field( context, "vPERFCHCONTROL", context.localUtil.DToC( AV13PerFchControl, 0, "/"));
         GxWebStd.gx_hidden_field( context, "gxhash_vPERFCHCONTROL", GetSecureSignedToken( "", AV13PerFchControl, context));
         GxWebStd.gx_hidden_field( context, "vAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18ageId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV18ageId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vUSUCOD", StringUtil.RTrim( AV19usucod));
         GxWebStd.gx_hidden_field( context, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV19usucod, "")), context));
         GxWebStd.gx_hidden_field( context, "PERANIO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A335PerAnio), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17empID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV17empID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vUPDATE_Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
         GxWebStd.gx_hidden_field( context, "vPERIODODET_Tooltiptext", StringUtil.RTrim( edtavPeriododet_Tooltiptext));
      }

      protected void RenderHtmlCloseForm512( )
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
         return "WWPeriodos" ;
      }

      public override String GetPgmdesc( )
      {
         return "Work With Periodos" ;
      }

      protected void WB510( )
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
            GxWebStd.gx_label_ctrl( context, lblTitletext_Internalname, "Periodos", "", "", lblTitletext_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "SubTitle", 0, "", 1, 1, 0, "HLP_WWPeriodos.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(26), 2, 0)+","+"null"+");", "Agregar", bttBtninsert_Jsonclick, 5, "Agregar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPeriodos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 col-sm-pull-3", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'" + sGXsfl_26_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavPeranio, cmbavPeranio_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV21perAnio), 4, 0)), 1, cmbavPeranio_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbavPeranio.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,17);\"", "", true, "HLP_WWPeriodos.htm");
            cmbavPeranio.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV21perAnio), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPeranio_Internalname, "Values", (String)(cmbavPeranio.ToJavascriptSource()), true);
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
            /*  Grid Control  */
            GridContainer.SetWrapped(nGXWrapped);
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"26\">") ;
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Empresa") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Proceso") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Fch. Control") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Año") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Mes") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ImageAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ImageAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
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
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A44empdsc);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A327procesoCod);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A328PerFchControl, "99/99/9999"));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A331PerAnioActual), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A332PerMesActual), 2, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV14Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV20periodoDet));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavPeriododet_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavPeriododet_Tooltiptext));
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
         if ( wbEnd == 26 )
         {
            wbEnd = 0;
            nRC_GXsfl_26 = (short)(nGXsfl_26_idx-1);
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
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 26 )
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
         wbLoad = true;
      }

      protected void START512( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "Work With Periodos", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP510( ) ;
      }

      protected void WS512( )
      {
         START512( ) ;
         EVT512( ) ;
      }

      protected void EVT512( )
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
                           E11512 ();
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
                           dynload_actions( ) ;
                        }
                     }
                     else
                     {
                        sEvtType = StringUtil.Right( sEvt, 4);
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                        if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                        {
                           nGXsfl_26_idx = (short)(NumberUtil.Val( sEvtType, "."));
                           sGXsfl_26_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_26_idx), 4, 0)), 4, "0");
                           SubsflControlProps_262( ) ;
                           A1EmpID = (short)(context.localUtil.CToN( cgiGet( edtEmpID_Internalname), ",", "."));
                           A44empdsc = StringUtil.Upper( cgiGet( edtempdsc_Internalname));
                           n44empdsc = false;
                           A327procesoCod = cgiGet( edtprocesoCod_Internalname);
                           A328PerFchControl = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtPerFchControl_Internalname), 0));
                           n328PerFchControl = false;
                           A331PerAnioActual = (short)(context.localUtil.CToN( cgiGet( edtPerAnioActual_Internalname), ",", "."));
                           cmbPerMesActual.Name = cmbPerMesActual_Internalname;
                           cmbPerMesActual.CurrentValue = cgiGet( cmbPerMesActual_Internalname);
                           A332PerMesActual = (short)(NumberUtil.Val( cgiGet( cmbPerMesActual_Internalname), "."));
                           AV14Update = cgiGet( edtavUpdate_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV14Update)) ? AV27Update_GXI : context.convertURL( context.PathToRelativeUrl( AV14Update))), !bGXsfl_26_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV14Update), true);
                           AV20periodoDet = cgiGet( edtavPeriododet_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPeriododet_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV20periodoDet)) ? AV28Periododet_GXI : context.convertURL( context.PathToRelativeUrl( AV20periodoDet))), !bGXsfl_26_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPeriododet_Internalname, "SrcSet", context.GetImageSrcSet( AV20periodoDet), true);
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E12512 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E13512 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E14512 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    Rfr0gs = false;
                                    /* Set Refresh If Peranio Changed */
                                    if ( ( context.localUtil.CToN( cgiGet( "GXH_vPERANIO"), ",", ".") != Convert.ToDecimal( AV21perAnio )) )
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
                     }
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void WE512( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm512( ) ;
            }
         }
      }

      protected void PA512( )
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
               GX_FocusControl = cmbavPeranio_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_262( ) ;
         while ( nGXsfl_26_idx <= nRC_GXsfl_26 )
         {
            sendrow_262( ) ;
            nGXsfl_26_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_26_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_26_idx+1));
            sGXsfl_26_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_26_idx), 4, 0)), 4, "0");
            SubsflControlProps_262( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV21perAnio ,
                                       String AV26Pgmname ,
                                       DateTime AV13PerFchControl ,
                                       String AV14Update ,
                                       String AV20periodoDet ,
                                       short AV18ageId ,
                                       String AV19usucod ,
                                       short AV17empID )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF512( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_PROCESOCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A327procesoCod, "")), context));
         GxWebStd.gx_hidden_field( context, "PROCESOCOD", A327procesoCod);
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
         if ( cmbavPeranio.ItemCount > 0 )
         {
            AV21perAnio = (short)(NumberUtil.Val( cmbavPeranio.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV21perAnio), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21perAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21perAnio), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavPeranio.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV21perAnio), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPeranio_Internalname, "Values", cmbavPeranio.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF512( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV26Pgmname = "WWPeriodos";
         context.Gx_err = 0;
      }

      protected void RF512( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 26;
         /* Execute user event: Refresh */
         E13512 ();
         nGXsfl_26_idx = 1;
         sGXsfl_26_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_26_idx), 4, 0)), 4, "0");
         SubsflControlProps_262( ) ;
         bGXsfl_26_Refreshing = true;
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
            SubsflControlProps_262( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV21perAnio ,
                                                 A335PerAnio } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.SHORT
                                                 }
            } ) ;
            /* Using cursor H00512 */
            pr_default.execute(0, new Object[] {AV21perAnio, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_26_idx = 1;
            sGXsfl_26_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_26_idx), 4, 0)), 4, "0");
            SubsflControlProps_262( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A335PerAnio = H00512_A335PerAnio[0];
               A44empdsc = H00512_A44empdsc[0];
               n44empdsc = H00512_n44empdsc[0];
               A328PerFchControl = H00512_A328PerFchControl[0];
               n328PerFchControl = H00512_n328PerFchControl[0];
               A327procesoCod = H00512_A327procesoCod[0];
               A1EmpID = H00512_A1EmpID[0];
               A44empdsc = H00512_A44empdsc[0];
               n44empdsc = H00512_n44empdsc[0];
               A328PerFchControl = H00512_A328PerFchControl[0];
               n328PerFchControl = H00512_n328PerFchControl[0];
               GXt_int1 = A331PerAnioActual;
               new obtanio(context ).execute(  A1EmpID,  A327procesoCod,  A328PerFchControl, out  GXt_int1) ;
               A331PerAnioActual = GXt_int1;
               GXt_int1 = A332PerMesActual;
               new obtperiodos(context ).execute(  A1EmpID,  A327procesoCod,  A328PerFchControl, out  GXt_int1) ;
               A332PerMesActual = GXt_int1;
               E14512 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 26;
            WB510( ) ;
         }
         bGXsfl_26_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes512( )
      {
         GxWebStd.gx_hidden_field( context, "vPERFCHCONTROL", context.localUtil.DToC( AV13PerFchControl, 0, "/"));
         GxWebStd.gx_hidden_field( context, "gxhash_vPERFCHCONTROL", GetSecureSignedToken( "", AV13PerFchControl, context));
         GxWebStd.gx_hidden_field( context, "vAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18ageId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV18ageId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vUSUCOD", StringUtil.RTrim( AV19usucod));
         GxWebStd.gx_hidden_field( context, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV19usucod, "")), context));
         GxWebStd.gx_hidden_field( context, "gxhash_PROCESOCOD"+"_"+sGXsfl_26_idx, GetSecureSignedToken( sGXsfl_26_idx, StringUtil.RTrim( context.localUtil.Format( A327procesoCod, "")), context));
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17empID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV17empID), "ZZZ9"), context));
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
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV21perAnio ,
                                              A335PerAnio } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.SHORT
                                              }
         } ) ;
         /* Using cursor H00513 */
         pr_default.execute(1, new Object[] {AV21perAnio});
         GRID_nRecordCount = H00513_AGRID_nRecordCount[0];
         pr_default.close(1);
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
            gxgrGrid_refresh( subGrid_Rows, AV21perAnio, AV26Pgmname, AV13PerFchControl, AV14Update, AV20periodoDet, AV18ageId, AV19usucod, AV17empID) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV21perAnio, AV26Pgmname, AV13PerFchControl, AV14Update, AV20periodoDet, AV18ageId, AV19usucod, AV17empID) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV21perAnio, AV26Pgmname, AV13PerFchControl, AV14Update, AV20periodoDet, AV18ageId, AV19usucod, AV17empID) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV21perAnio, AV26Pgmname, AV13PerFchControl, AV14Update, AV20periodoDet, AV18ageId, AV19usucod, AV17empID) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV21perAnio, AV26Pgmname, AV13PerFchControl, AV14Update, AV20periodoDet, AV18ageId, AV19usucod, AV17empID) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP510( )
      {
         /* Before Start, stand alone formulas. */
         AV26Pgmname = "WWPeriodos";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E12512 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            cmbavPeranio.Name = cmbavPeranio_Internalname;
            cmbavPeranio.CurrentValue = cgiGet( cmbavPeranio_Internalname);
            AV21perAnio = (short)(NumberUtil.Val( cgiGet( cmbavPeranio_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21perAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21perAnio), 4, 0)));
            /* Read saved values. */
            nRC_GXsfl_26 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_26"), ",", "."));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID_nFirstRecordOnPage"), ",", "."));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID_nEOF"), ",", "."));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ",", "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vPERANIO"), ",", ".") != Convert.ToDecimal( AV21perAnio )) )
            {
               GRID_nFirstRecordOnPage = 0;
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
         E12512 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E12512( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV26Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV26Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         subGrid_Rows = 10;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         AV14Update = context.GetImagePath( "984dbb7e-3105-4d21-aee3-84a29ade1d38", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV14Update)) ? AV27Update_GXI : context.convertURL( context.PathToRelativeUrl( AV14Update))), !bGXsfl_26_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV14Update), true);
         AV27Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "984dbb7e-3105-4d21-aee3-84a29ade1d38", "", context.GetTheme( )));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV14Update)) ? AV27Update_GXI : context.convertURL( context.PathToRelativeUrl( AV14Update))), !bGXsfl_26_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV14Update), true);
         edtavUpdate_Tooltiptext = "Modificar";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext, !bGXsfl_26_Refreshing);
         AV20periodoDet = context.GetImagePath( "/logos/detPeriod.png", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPeriododet_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV20periodoDet)) ? AV28Periododet_GXI : context.convertURL( context.PathToRelativeUrl( AV20periodoDet))), !bGXsfl_26_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPeriododet_Internalname, "SrcSet", context.GetImageSrcSet( AV20periodoDet), true);
         AV28Periododet_GXI = GXDbFile.PathToUrl( "/logos/detPeriod.png");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPeriododet_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV20periodoDet)) ? AV28Periododet_GXI : context.convertURL( context.PathToRelativeUrl( AV20periodoDet))), !bGXsfl_26_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPeriododet_Internalname, "SrcSet", context.GetImageSrcSet( AV20periodoDet), true);
         edtavPeriododet_Tooltiptext = "Detalle Periodos";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPeriododet_Internalname, "Tooltiptext", edtavPeriododet_Tooltiptext, !bGXsfl_26_Refreshing);
         Form.Caption = "Periodos";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         /* Execute user subroutine: 'CARGARANIOS' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
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
      }

      protected void E13512( )
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

      private void E14512( )
      {
         /* Grid_Load Routine */
         edtavUpdate_Link = formatLink("periodos.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode(StringUtil.RTrim(A327procesoCod)) + "," + UrlEncode("" +A1EmpID) + "," + UrlEncode("" +AV18ageId) + "," + UrlEncode(StringUtil.RTrim(AV19usucod));
         edtavPeriododet_Link = formatLink("periodosdet.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A1EmpID) + "," + UrlEncode(StringUtil.RTrim(A327procesoCod)) + "," + UrlEncode("" +A335PerAnio);
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 26;
         }
         sendrow_262( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_26_Refreshing )
         {
            context.DoAjaxLoad(26, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void E11512( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("periodos.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode(StringUtil.RTrim("")) + "," + UrlEncode("" +AV17empID) + "," + UrlEncode("" +AV18ageId) + "," + UrlEncode(StringUtil.RTrim(AV19usucod)));
         context.wjLocDisableFrm = 1;
      }

      protected void S132( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV7HTTPRequest.Method, "GET") == 0 )
         {
            AV8GridState.FromXml(AV6Session.Get(AV26Pgmname+"GridState"), null, "GridState", "KBCalpesa22");
            if ( AV8GridState.gxTpr_Filtervalues.Count >= 1 )
            {
               AV13PerFchControl = context.localUtil.CToD( ((SdtGridState_FilterValue)AV8GridState.gxTpr_Filtervalues.Item(1)).gxTpr_Value, 4);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13PerFchControl", context.localUtil.Format(AV13PerFchControl, "99/99/9999"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vPERFCHCONTROL", GetSecureSignedToken( "", AV13PerFchControl, context));
            }
            if ( AV8GridState.gxTpr_Currentpage > 0 )
            {
               AV10GridPageCount = subGrid_Pagecount( );
               if ( ( AV10GridPageCount > 0 ) && ( AV10GridPageCount < AV8GridState.gxTpr_Currentpage ) )
               {
                  subgrid_gotopage( AV10GridPageCount) ;
               }
               else
               {
                  subgrid_gotopage( AV8GridState.gxTpr_Currentpage) ;
               }
            }
         }
      }

      protected void S142( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV8GridState.FromXml(AV6Session.Get(AV26Pgmname+"GridState"), null, "GridState", "KBCalpesa22");
         AV8GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         AV8GridState.gxTpr_Filtervalues.Clear();
         AV9GridStateFilterValue = new SdtGridState_FilterValue(context);
         AV9GridStateFilterValue.gxTpr_Value = context.localUtil.DToC( AV13PerFchControl, 4, "/");
         AV8GridState.gxTpr_Filtervalues.Add(AV9GridStateFilterValue, 0);
         AV6Session.Set(AV26Pgmname+"GridState", AV8GridState.ToXml(false, true, "GridState", "KBCalpesa22"));
      }

      protected void S122( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV11TrnContext = new SdtTransactionContext(context);
         AV11TrnContext.gxTpr_Callerobject = AV26Pgmname;
         AV11TrnContext.gxTpr_Callerondelete = true;
         AV11TrnContext.gxTpr_Callerurl = AV7HTTPRequest.ScriptName+"?"+AV7HTTPRequest.QueryString;
         AV11TrnContext.gxTpr_Transactionname = "Periodos";
         AV6Session.Set("TrnContext", AV11TrnContext.ToXml(false, true, "TransactionContext", "KBCalpesa22"));
      }

      protected void S112( )
      {
         /* 'CARGARANIOS' Routine */
         cmbavPeranio.removeAllItems();
         cmbavPeranio.addItem("0", "Todos", 0);
         AV22anioAct = 2021;
         AV23i = 1;
         while ( AV23i <= 5 )
         {
            cmbavPeranio.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(AV22anioAct), 4, 0)), StringUtil.Str( (decimal)(AV22anioAct), 4, 0), 0);
            AV22anioAct = (short)(AV22anioAct+1);
            AV23i = (short)(AV23i+1);
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV17empID = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17empID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17empID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV17empID), "ZZZ9"), context));
         AV18ageId = Convert.ToInt16(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ageId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18ageId), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV18ageId), "ZZZ9"), context));
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
         PA512( ) ;
         WS512( ) ;
         WE512( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202317162339", true);
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
            context.AddJavascriptSource("wwperiodos.js", "?202317162339", false);
         }
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_262( )
      {
         edtEmpID_Internalname = "EMPID_"+sGXsfl_26_idx;
         edtempdsc_Internalname = "EMPDSC_"+sGXsfl_26_idx;
         edtprocesoCod_Internalname = "PROCESOCOD_"+sGXsfl_26_idx;
         edtPerFchControl_Internalname = "PERFCHCONTROL_"+sGXsfl_26_idx;
         edtPerAnioActual_Internalname = "PERANIOACTUAL_"+sGXsfl_26_idx;
         cmbPerMesActual_Internalname = "PERMESACTUAL_"+sGXsfl_26_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_26_idx;
         edtavPeriododet_Internalname = "vPERIODODET_"+sGXsfl_26_idx;
      }

      protected void SubsflControlProps_fel_262( )
      {
         edtEmpID_Internalname = "EMPID_"+sGXsfl_26_fel_idx;
         edtempdsc_Internalname = "EMPDSC_"+sGXsfl_26_fel_idx;
         edtprocesoCod_Internalname = "PROCESOCOD_"+sGXsfl_26_fel_idx;
         edtPerFchControl_Internalname = "PERFCHCONTROL_"+sGXsfl_26_fel_idx;
         edtPerAnioActual_Internalname = "PERANIOACTUAL_"+sGXsfl_26_fel_idx;
         cmbPerMesActual_Internalname = "PERMESACTUAL_"+sGXsfl_26_fel_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_26_fel_idx;
         edtavPeriododet_Internalname = "vPERIODODET_"+sGXsfl_26_fel_idx;
      }

      protected void sendrow_262( )
      {
         SubsflControlProps_262( ) ;
         WB510( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_26_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_26_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_26_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEmpID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEmpID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)26,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempdsc_Internalname,(String)A44empdsc,StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtempdsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)26,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtprocesoCod_Internalname,(String)A327procesoCod,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtprocesoCod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)26,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPerFchControl_Internalname,context.localUtil.Format(A328PerFchControl, "99/99/9999"),context.localUtil.Format( A328PerFchControl, "99/99/9999"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPerFchControl_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)26,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPerAnioActual_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A331PerAnioActual), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A331PerAnioActual), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPerAnioActual_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)26,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            GXCCtl = "PERMESACTUAL_" + sGXsfl_26_idx;
            cmbPerMesActual.Name = GXCCtl;
            cmbPerMesActual.WebTags = "";
            cmbPerMesActual.addItem("1", "Enero", 0);
            cmbPerMesActual.addItem("2", "Febrero", 0);
            cmbPerMesActual.addItem("3", "Marzo", 0);
            cmbPerMesActual.addItem("4", "Abril", 0);
            cmbPerMesActual.addItem("5", "Mayo", 0);
            cmbPerMesActual.addItem("6", "Junio", 0);
            cmbPerMesActual.addItem("7", "Julio", 0);
            cmbPerMesActual.addItem("8", "Agosto", 0);
            cmbPerMesActual.addItem("9", "Septiembre", 0);
            cmbPerMesActual.addItem("10", "Octubre", 0);
            cmbPerMesActual.addItem("11", "Noviembre", 0);
            cmbPerMesActual.addItem("12", "Diciembre", 0);
            if ( cmbPerMesActual.ItemCount > 0 )
            {
               A332PerMesActual = (short)(NumberUtil.Val( cmbPerMesActual.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A332PerMesActual), 2, 0))), "."));
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbPerMesActual,(String)cmbPerMesActual_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(A332PerMesActual), 2, 0)),(short)1,(String)cmbPerMesActual_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)-1,(short)0,(short)1,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn WWOptionalColumn",(String)"",(String)"",(String)"",(bool)true});
            cmbPerMesActual.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A332PerMesActual), 2, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPerMesActual_Internalname, "Values", (String)(cmbPerMesActual.ToJavascriptSource()), !bGXsfl_26_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ImageAttribute";
            StyleString = "";
            AV14Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV14Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV27Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV14Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV14Update)) ? AV27Update_GXI : context.PathToRelativeUrl( AV14Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV14Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ImageAttribute";
            StyleString = "";
            AV20periodoDet_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV20periodoDet))&&String.IsNullOrEmpty(StringUtil.RTrim( AV28Periododet_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV20periodoDet)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV20periodoDet)) ? AV28Periododet_GXI : context.PathToRelativeUrl( AV20periodoDet));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavPeriododet_Internalname,(String)sImgUrl,(String)edtavPeriododet_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavPeriododet_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV20periodoDet_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            send_integrity_lvl_hashes512( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_26_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_26_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_26_idx+1));
            sGXsfl_26_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_26_idx), 4, 0)), 4, "0");
            SubsflControlProps_262( ) ;
         }
         /* End function sendrow_262 */
      }

      protected void init_web_controls( )
      {
         cmbavPeranio.Name = "vPERANIO";
         cmbavPeranio.WebTags = "";
         if ( cmbavPeranio.ItemCount > 0 )
         {
            AV21perAnio = (short)(NumberUtil.Val( cmbavPeranio.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV21perAnio), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21perAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21perAnio), 4, 0)));
         }
         GXCCtl = "PERMESACTUAL_" + sGXsfl_26_idx;
         cmbPerMesActual.Name = GXCCtl;
         cmbPerMesActual.WebTags = "";
         cmbPerMesActual.addItem("1", "Enero", 0);
         cmbPerMesActual.addItem("2", "Febrero", 0);
         cmbPerMesActual.addItem("3", "Marzo", 0);
         cmbPerMesActual.addItem("4", "Abril", 0);
         cmbPerMesActual.addItem("5", "Mayo", 0);
         cmbPerMesActual.addItem("6", "Junio", 0);
         cmbPerMesActual.addItem("7", "Julio", 0);
         cmbPerMesActual.addItem("8", "Agosto", 0);
         cmbPerMesActual.addItem("9", "Septiembre", 0);
         cmbPerMesActual.addItem("10", "Octubre", 0);
         cmbPerMesActual.addItem("11", "Noviembre", 0);
         cmbPerMesActual.addItem("12", "Diciembre", 0);
         if ( cmbPerMesActual.ItemCount > 0 )
         {
            A332PerMesActual = (short)(NumberUtil.Val( cmbPerMesActual.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A332PerMesActual), 2, 0))), "."));
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTitletext_Internalname = "TITLETEXT";
         bttBtninsert_Internalname = "BTNINSERT";
         cmbavPeranio_Internalname = "vPERANIO";
         divTabletop_Internalname = "TABLETOP";
         edtEmpID_Internalname = "EMPID";
         edtempdsc_Internalname = "EMPDSC";
         edtprocesoCod_Internalname = "PROCESOCOD";
         edtPerFchControl_Internalname = "PERFCHCONTROL";
         edtPerAnioActual_Internalname = "PERANIOACTUAL";
         cmbPerMesActual_Internalname = "PERMESACTUAL";
         edtavUpdate_Internalname = "vUPDATE";
         edtavPeriododet_Internalname = "vPERIODODET";
         divGridtable_Internalname = "GRIDTABLE";
         divGridcell_Internalname = "GRIDCELL";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         subGrid_Internalname = "GRID";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         cmbPerMesActual_Jsonclick = "";
         edtPerAnioActual_Jsonclick = "";
         edtPerFchControl_Jsonclick = "";
         edtprocesoCod_Jsonclick = "";
         edtempdsc_Jsonclick = "";
         edtEmpID_Jsonclick = "";
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavPeriododet_Link = "";
         edtavUpdate_Link = "";
         subGrid_Header = "";
         subGrid_Class = "WorkWith";
         subGrid_Backcolorstyle = 0;
         cmbavPeranio_Jsonclick = "";
         cmbavPeranio.Enabled = 1;
         Form.Caption = "Work With Periodos";
         subGrid_Rows = 10;
         edtavPeriododet_Tooltiptext = "";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPeranio'},{av:'AV21perAnio',fld:'vPERANIO',pic:'ZZZ9'},{av:'AV14Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV20periodoDet',fld:'vPERIODODET',pic:''},{av:'edtavPeriododet_Tooltiptext',ctrl:'vPERIODODET',prop:'Tooltiptext'},{av:'AV26Pgmname',fld:'vPGMNAME',pic:''},{av:'AV18ageId',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV19usucod',fld:'vUSUCOD',pic:'',hsh:true},{av:'AV17empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV13PerFchControl',fld:'vPERFCHCONTROL',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("GRID.LOAD","{handler:'E14512',iparms:[{av:'A327procesoCod',fld:'PROCESOCOD',pic:'',hsh:true},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'AV18ageId',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV19usucod',fld:'vUSUCOD',pic:'',hsh:true},{av:'A335PerAnio',fld:'PERANIO',pic:'ZZZ9'}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'edtavPeriododet_Link',ctrl:'vPERIODODET',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E11512',iparms:[{av:'A327procesoCod',fld:'PROCESOCOD',pic:'',hsh:true},{av:'AV17empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV18ageId',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV19usucod',fld:'vUSUCOD',pic:'',hsh:true}]");
         setEventMetadata("'DOINSERT'",",oparms:[]}");
         setEventMetadata("GRID_FIRSTPAGE","{handler:'subgrid_firstpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPeranio'},{av:'AV21perAnio',fld:'vPERANIO',pic:'ZZZ9'},{av:'AV14Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV20periodoDet',fld:'vPERIODODET',pic:''},{av:'edtavPeriododet_Tooltiptext',ctrl:'vPERIODODET',prop:'Tooltiptext'},{av:'AV18ageId',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV19usucod',fld:'vUSUCOD',pic:'',hsh:true},{av:'AV17empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV26Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13PerFchControl',fld:'vPERFCHCONTROL',pic:'',hsh:true}]");
         setEventMetadata("GRID_FIRSTPAGE",",oparms:[]}");
         setEventMetadata("GRID_PREVPAGE","{handler:'subgrid_previouspage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPeranio'},{av:'AV21perAnio',fld:'vPERANIO',pic:'ZZZ9'},{av:'AV14Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV20periodoDet',fld:'vPERIODODET',pic:''},{av:'edtavPeriododet_Tooltiptext',ctrl:'vPERIODODET',prop:'Tooltiptext'},{av:'AV18ageId',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV19usucod',fld:'vUSUCOD',pic:'',hsh:true},{av:'AV17empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV26Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13PerFchControl',fld:'vPERFCHCONTROL',pic:'',hsh:true}]");
         setEventMetadata("GRID_PREVPAGE",",oparms:[]}");
         setEventMetadata("GRID_NEXTPAGE","{handler:'subgrid_nextpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPeranio'},{av:'AV21perAnio',fld:'vPERANIO',pic:'ZZZ9'},{av:'AV14Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV20periodoDet',fld:'vPERIODODET',pic:''},{av:'edtavPeriododet_Tooltiptext',ctrl:'vPERIODODET',prop:'Tooltiptext'},{av:'AV18ageId',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV19usucod',fld:'vUSUCOD',pic:'',hsh:true},{av:'AV17empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV26Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13PerFchControl',fld:'vPERFCHCONTROL',pic:'',hsh:true}]");
         setEventMetadata("GRID_NEXTPAGE",",oparms:[]}");
         setEventMetadata("GRID_LASTPAGE","{handler:'subgrid_lastpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPeranio'},{av:'AV21perAnio',fld:'vPERANIO',pic:'ZZZ9'},{av:'AV14Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV20periodoDet',fld:'vPERIODODET',pic:''},{av:'edtavPeriododet_Tooltiptext',ctrl:'vPERIODODET',prop:'Tooltiptext'},{av:'AV18ageId',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV19usucod',fld:'vUSUCOD',pic:'',hsh:true},{av:'AV17empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV26Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13PerFchControl',fld:'vPERFCHCONTROL',pic:'',hsh:true}]");
         setEventMetadata("GRID_LASTPAGE",",oparms:[]}");
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
         AV20periodoDet = "";
         AV26Pgmname = "";
         AV13PerFchControl = DateTime.MinValue;
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
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         A44empdsc = "";
         A327procesoCod = "";
         A328PerFchControl = DateTime.MinValue;
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV27Update_GXI = "";
         AV28Periododet_GXI = "";
         scmdbuf = "";
         H00512_A335PerAnio = new short[1] ;
         H00512_A44empdsc = new String[] {""} ;
         H00512_n44empdsc = new bool[] {false} ;
         H00512_A328PerFchControl = new DateTime[] {DateTime.MinValue} ;
         H00512_n328PerFchControl = new bool[] {false} ;
         H00512_A327procesoCod = new String[] {""} ;
         H00512_A1EmpID = new short[1] ;
         H00513_AGRID_nRecordCount = new long[1] ;
         GridRow = new GXWebRow();
         AV7HTTPRequest = new GxHttpRequest( context);
         AV8GridState = new SdtGridState(context);
         AV6Session = context.GetSession();
         AV9GridStateFilterValue = new SdtGridState_FilterValue(context);
         AV11TrnContext = new SdtTransactionContext(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         GXCCtl = "";
         sImgUrl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwperiodos__default(),
            new Object[][] {
                new Object[] {
               H00512_A335PerAnio, H00512_A44empdsc, H00512_n44empdsc, H00512_A328PerFchControl, H00512_n328PerFchControl, H00512_A327procesoCod, H00512_A1EmpID
               }
               , new Object[] {
               H00513_AGRID_nRecordCount
               }
            }
         );
         AV26Pgmname = "WWPeriodos";
         /* GeneXus formulas. */
         AV26Pgmname = "WWPeriodos";
         context.Gx_err = 0;
      }

      private short AV17empID ;
      private short AV18ageId ;
      private short wcpOAV17empID ;
      private short wcpOAV18ageId ;
      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_26 ;
      private short nGXsfl_26_idx=1 ;
      private short GRID_nEOF ;
      private short AV21perAnio ;
      private short initialized ;
      private short nGXWrapped ;
      private short A335PerAnio ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short A1EmpID ;
      private short A331PerAnioActual ;
      private short A332PerMesActual ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short GXt_int1 ;
      private short AV22anioAct ;
      private short AV23i ;
      private short subGrid_Backstyle ;
      private int subGrid_Rows ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV10GridPageCount ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String AV19usucod ;
      private String wcpOAV19usucod ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavPeriododet_Tooltiptext ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_26_idx="0001" ;
      private String edtavUpdate_Internalname ;
      private String edtavPeriododet_Internalname ;
      private String AV26Pgmname ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
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
      private String cmbavPeranio_Internalname ;
      private String cmbavPeranio_Jsonclick ;
      private String divGridcell_Internalname ;
      private String divGridtable_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String subGrid_Header ;
      private String edtavUpdate_Link ;
      private String edtavPeriododet_Link ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtEmpID_Internalname ;
      private String edtempdsc_Internalname ;
      private String edtprocesoCod_Internalname ;
      private String edtPerFchControl_Internalname ;
      private String edtPerAnioActual_Internalname ;
      private String cmbPerMesActual_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_26_fel_idx="0001" ;
      private String ROClassString ;
      private String edtEmpID_Jsonclick ;
      private String edtempdsc_Jsonclick ;
      private String edtprocesoCod_Jsonclick ;
      private String edtPerFchControl_Jsonclick ;
      private String edtPerAnioActual_Jsonclick ;
      private String GXCCtl ;
      private String cmbPerMesActual_Jsonclick ;
      private String sImgUrl ;
      private DateTime AV13PerFchControl ;
      private DateTime A328PerFchControl ;
      private bool entryPointCalled ;
      private bool bGXsfl_26_Refreshing=false ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n44empdsc ;
      private bool n328PerFchControl ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV14Update_IsBlob ;
      private bool AV20periodoDet_IsBlob ;
      private String A44empdsc ;
      private String A327procesoCod ;
      private String AV27Update_GXI ;
      private String AV28Periododet_GXI ;
      private String AV14Update ;
      private String AV20periodoDet ;
      private IGxSession AV6Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavPeranio ;
      private GXCombobox cmbPerMesActual ;
      private IDataStoreProvider pr_default ;
      private short[] H00512_A335PerAnio ;
      private String[] H00512_A44empdsc ;
      private bool[] H00512_n44empdsc ;
      private DateTime[] H00512_A328PerFchControl ;
      private bool[] H00512_n328PerFchControl ;
      private String[] H00512_A327procesoCod ;
      private short[] H00512_A1EmpID ;
      private long[] H00513_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV7HTTPRequest ;
      private SdtGridState AV8GridState ;
      private SdtGridState_FilterValue AV9GridStateFilterValue ;
      private SdtTransactionContext AV11TrnContext ;
   }

   public class wwperiodos__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00512( IGxContext context ,
                                             short AV21perAnio ,
                                             short A335PerAnio )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [4] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " T1.[PerAnio], T2.[empdsc], T3.[PerFchControl], T1.[procesoCod], T1.[EmpID]";
         sFromString = " FROM (([PeriodosPer] T1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID]) INNER JOIN [Periodos] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[procesoCod] = T1.[procesoCod])";
         sOrderString = "";
         if ( ! (0==AV21perAnio) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PerAnio] = @AV21perAnio)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PerAnio] = @AV21perAnio)";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         sOrderString = sOrderString + " ORDER BY T3.[PerFchControl]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_H00513( IGxContext context ,
                                             short AV21perAnio ,
                                             short A335PerAnio )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [1] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM (([PeriodosPer] T1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID]) INNER JOIN [Periodos] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[procesoCod] = T1.[procesoCod])";
         if ( ! (0==AV21perAnio) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PerAnio] = @AV21perAnio)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PerAnio] = @AV21perAnio)";
            }
         }
         else
         {
            GXv_int4[0] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + "";
         GXv_Object5[0] = scmdbuf;
         GXv_Object5[1] = GXv_int4;
         return GXv_Object5 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H00512(context, (short)dynConstraints[0] , (short)dynConstraints[1] );
               case 1 :
                     return conditional_H00513(context, (short)dynConstraints[0] , (short)dynConstraints[1] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

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
          Object[] prmH00512 ;
          prmH00512 = new Object[] {
          new Object[] {"@AV21perAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00513 ;
          prmH00513 = new Object[] {
          new Object[] {"@AV21perAnio",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00512", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00512,11,0,true,false )
             ,new CursorDef("H00513", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00513,1,0,true,false )
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
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[6])[0] = rslt.getShort(5) ;
                return;
             case 1 :
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
                   stmt.SetParameter(sIdx, (short)parms[4]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[5]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[6]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[7]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[1]);
                }
                return;
       }
    }

 }

}
