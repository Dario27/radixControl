/*
               File: WWHistPrecioProd
        Description: Work With Hist Precio Productos
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 11/19/2022 22:54:5.16
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
   public class wwhistprecioprod : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public wwhistprecioprod( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public wwhistprecioprod( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_empId ,
                           short aP1_ageId ,
                           String aP2_usucod )
      {
         this.AV20empId = aP0_empId;
         this.AV21ageId = aP1_ageId;
         this.AV22usucod = aP2_usucod;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbHistPeriodo = new GXCombobox();
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
               nRC_GXsfl_59 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_59_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_59_idx = GetNextPar( );
               AV14Update = GetNextPar( );
               edtavUpdate_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext, !bGXsfl_59_Refreshing);
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
               AV13detTipoProdDsc = GetNextPar( );
               AV17categDsc = GetNextPar( );
               AV18HistAnio = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV19subCatDsc = GetNextPar( );
               AV16ADVANCED_LABEL_TEMPLATE = GetNextPar( );
               AV28Pgmname = GetNextPar( );
               AV14Update = GetNextPar( );
               edtavUpdate_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext, !bGXsfl_59_Refreshing);
               AV20empId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV24anio = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV25mes = (short)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV13detTipoProdDsc, AV17categDsc, AV18HistAnio, AV19subCatDsc, AV16ADVANCED_LABEL_TEMPLATE, AV28Pgmname, AV14Update, AV20empId, AV24anio, AV25mes) ;
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
               AV20empId = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20empId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20empId), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV20empId), "ZZZ9"), context));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV21ageId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ageId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21ageId), 4, 0)));
                  AV22usucod = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22usucod", AV22usucod);
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
            PA3N2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV28Pgmname = "WWHistPrecioProd";
               context.Gx_err = 0;
               WS3N2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE3N2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202211192254524", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("wwhistprecioprod.aspx") + "?" + UrlEncode("" +AV20empId) + "," + UrlEncode("" +AV21ageId) + "," + UrlEncode(StringUtil.RTrim(AV22usucod))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vDETTIPOPRODDSC", StringUtil.RTrim( AV13detTipoProdDsc));
         GxWebStd.gx_hidden_field( context, "GXH_vCATEGDSC", StringUtil.RTrim( AV17categDsc));
         GxWebStd.gx_hidden_field( context, "GXH_vHISTANIO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18HistAnio), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vSUBCATDSC", StringUtil.RTrim( AV19subCatDsc));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_59", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_59), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vADVANCED_LABEL_TEMPLATE", StringUtil.RTrim( AV16ADVANCED_LABEL_TEMPLATE));
         GxWebStd.gx_hidden_field( context, "gxhash_vADVANCED_LABEL_TEMPLATE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV16ADVANCED_LABEL_TEMPLATE, "")), context));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV28Pgmname));
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV20empId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV20empId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vANIO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV24anio), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV24anio), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vMES", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25mes), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vMES", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV25mes), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21ageId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vUSUCOD", StringUtil.RTrim( AV22usucod));
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "FILTERSCONTAINER_Class", StringUtil.RTrim( divFilterscontainer_Class));
         GxWebStd.gx_hidden_field( context, "CATEGDSCFILTERCONTAINER_Class", StringUtil.RTrim( divCategdscfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "HISTANIOFILTERCONTAINER_Class", StringUtil.RTrim( divHistaniofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "SUBCATDSCFILTERCONTAINER_Class", StringUtil.RTrim( divSubcatdscfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "vUPDATE_Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
      }

      protected void RenderHtmlCloseForm3N2( )
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
         return "WWHistPrecioProd" ;
      }

      public override String GetPgmdesc( )
      {
         return "Work With Hist Precio Productos" ;
      }

      protected void WB3N0( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-2 ToggleCell", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"";
            ClassString = bttBtntoggle_Class;
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(59), 2, 0)+","+"null"+");", bttBtntoggle_Caption, bttBtntoggle_Jsonclick, 7, "Ocultar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e113n1_client"+"'", TempTags, "", 2, "HLP_WWHistPrecioProd.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 col-sm-2", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitletext_Internalname, "Hist Precio Productos", "", "", lblTitletext_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "SubTitle", 0, "", 1, 1, 0, "HLP_WWHistPrecioProd.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-4 col-sm-5 col-sm-push-3 WWActionsCell", "Right", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            ClassString = "BtnNew";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(59), 2, 0)+","+"null"+");", "Agregar", bttBtninsert_Jsonclick, 5, "Agregar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWHistPrecioProd.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 col-sm-pull-5", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavDettipoproddsc_Internalname, "det Tipo Prod Dsc", "col-sm-3 FilterSearchAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'" + sGXsfl_59_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavDettipoproddsc_Internalname, StringUtil.RTrim( AV13detTipoProdDsc), StringUtil.RTrim( context.localUtil.Format( AV13detTipoProdDsc, "@!")), TempTags+" onchange=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,18);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "det Tipo Prod Dsc", edtavDettipoproddsc_Jsonclick, 0, "FilterSearchAttribute", "", "", "", "", 1, edtavDettipoproddsc_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWHistPrecioProd.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 col-md-2 WWAdvancedBarCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divFilterscontainer_Internalname, 1, 0, "px", 0, "px", divFilterscontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCategdscfiltercontainer_Internalname, 1, 0, "px", 0, "px", divCategdscfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblcategdscfilter_Internalname, lblLblcategdscfilter_Caption, "", "", lblLblcategdscfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e123n1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_WWHistPrecioProd.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 ViewAdvancedBarCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCategdsc_Internalname, "categ Dsc", "col-sm-3 FilterComboAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'',false,'" + sGXsfl_59_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCategdsc_Internalname, StringUtil.RTrim( AV17categDsc), StringUtil.RTrim( context.localUtil.Format( AV17categDsc, "@!")), TempTags+" onchange=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,31);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCategdsc_Jsonclick, 0, "FilterComboAttribute", "", "", "", "", edtavCategdsc_Visible, edtavCategdsc_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWHistPrecioProd.htm");
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
            GxWebStd.gx_div_start( context, divHistaniofiltercontainer_Internalname, 1, 0, "px", 0, "px", divHistaniofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblhistaniofilter_Internalname, lblLblhistaniofilter_Caption, "", "", lblLblhistaniofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e133n1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_WWHistPrecioProd.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 ViewAdvancedBarCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavHistanio_Internalname, "Hist Anio", "col-sm-3 FilterComboAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'" + sGXsfl_59_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavHistanio_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18HistAnio), 4, 0, ",", "")), ((edtavHistanio_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV18HistAnio), "ZZZ9")) : context.localUtil.Format( (decimal)(AV18HistAnio), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,41);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavHistanio_Jsonclick, 0, "FilterComboAttribute", "", "", "", "", edtavHistanio_Visible, edtavHistanio_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WWHistPrecioProd.htm");
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
            GxWebStd.gx_div_start( context, divSubcatdscfiltercontainer_Internalname, 1, 0, "px", 0, "px", divSubcatdscfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblsubcatdscfilter_Internalname, lblLblsubcatdscfilter_Caption, "", "", lblLblsubcatdscfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e143n1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_WWHistPrecioProd.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 ViewAdvancedBarCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSubcatdsc_Internalname, "sub Cat Dsc", "col-sm-3 FilterComboAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'" + sGXsfl_59_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSubcatdsc_Internalname, StringUtil.RTrim( AV19subCatDsc), StringUtil.RTrim( context.localUtil.Format( AV19subCatDsc, "@!")), TempTags+" onchange=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSubcatdsc_Jsonclick, 0, "FilterComboAttribute", "", "", "", "", edtavSubcatdsc_Visible, edtavSubcatdsc_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWHistPrecioProd.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridcell_Internalname, 1, 0, "px", 0, "px", divGridcell_Class, "left", "top", "", "", "div");
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"59\">") ;
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Año") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Mes") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "tipoID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Tipo Producto") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Categ.ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Categoria") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "sub Cat ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Productos") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Estado") ;
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
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A227HistAnio), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A228HistPeriodo), 2, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A36detTipoProdID), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A173detTipoProdDsc));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A32categID), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A146categDsc));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A33subCatID), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A148subCatDsc));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A229HistEst));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV14Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
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
         if ( wbEnd == 59 )
         {
            wbEnd = 0;
            nRC_GXsfl_59 = (short)(nGXsfl_59_idx-1);
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
         if ( wbEnd == 59 )
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

      protected void START3N2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "Work With Hist Precio Productos", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP3N0( ) ;
      }

      protected void WS3N2( )
      {
         START3N2( ) ;
         EVT3N2( ) ;
      }

      protected void EVT3N2( )
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
                           E153N2 ();
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
                           nGXsfl_59_idx = (short)(NumberUtil.Val( sEvtType, "."));
                           sGXsfl_59_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_59_idx), 4, 0)), 4, "0");
                           SubsflControlProps_592( ) ;
                           A1EmpID = (short)(context.localUtil.CToN( cgiGet( edtEmpID_Internalname), ",", "."));
                           A227HistAnio = (short)(context.localUtil.CToN( cgiGet( edtHistAnio_Internalname), ",", "."));
                           cmbHistPeriodo.Name = cmbHistPeriodo_Internalname;
                           cmbHistPeriodo.CurrentValue = cgiGet( cmbHistPeriodo_Internalname);
                           A228HistPeriodo = (short)(NumberUtil.Val( cgiGet( cmbHistPeriodo_Internalname), "."));
                           A36detTipoProdID = (short)(context.localUtil.CToN( cgiGet( edtdetTipoProdID_Internalname), ",", "."));
                           A173detTipoProdDsc = StringUtil.Upper( cgiGet( edtdetTipoProdDsc_Internalname));
                           A32categID = (short)(context.localUtil.CToN( cgiGet( edtcategID_Internalname), ",", "."));
                           A146categDsc = StringUtil.Upper( cgiGet( edtcategDsc_Internalname));
                           n146categDsc = false;
                           A33subCatID = (short)(context.localUtil.CToN( cgiGet( edtsubCatID_Internalname), ",", "."));
                           A148subCatDsc = StringUtil.Upper( cgiGet( edtsubCatDsc_Internalname));
                           n148subCatDsc = false;
                           A229HistEst = cgiGet( edtHistEst_Internalname);
                           n229HistEst = false;
                           AV14Update = cgiGet( edtavUpdate_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV14Update)) ? AV29Update_GXI : context.convertURL( context.PathToRelativeUrl( AV14Update))), !bGXsfl_59_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV14Update), true);
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E163N2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E173N2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E183N2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    Rfr0gs = false;
                                    /* Set Refresh If Dettipoproddsc Changed */
                                    if ( StringUtil.StrCmp(cgiGet( "GXH_vDETTIPOPRODDSC"), AV13detTipoProdDsc) != 0 )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Categdsc Changed */
                                    if ( StringUtil.StrCmp(cgiGet( "GXH_vCATEGDSC"), AV17categDsc) != 0 )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Histanio Changed */
                                    if ( ( context.localUtil.CToN( cgiGet( "GXH_vHISTANIO"), ",", ".") != Convert.ToDecimal( AV18HistAnio )) )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Subcatdsc Changed */
                                    if ( StringUtil.StrCmp(cgiGet( "GXH_vSUBCATDSC"), AV19subCatDsc) != 0 )
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

      protected void WE3N2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm3N2( ) ;
            }
         }
      }

      protected void PA3N2( )
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
               GX_FocusControl = edtavDettipoproddsc_Internalname;
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
         SubsflControlProps_592( ) ;
         while ( nGXsfl_59_idx <= nRC_GXsfl_59 )
         {
            sendrow_592( ) ;
            nGXsfl_59_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_59_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_59_idx+1));
            sGXsfl_59_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_59_idx), 4, 0)), 4, "0");
            SubsflControlProps_592( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       String AV13detTipoProdDsc ,
                                       String AV17categDsc ,
                                       short AV18HistAnio ,
                                       String AV19subCatDsc ,
                                       String AV16ADVANCED_LABEL_TEMPLATE ,
                                       String AV28Pgmname ,
                                       String AV14Update ,
                                       short AV20empId ,
                                       short AV24anio ,
                                       short AV25mes )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF3N2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_DETTIPOPRODID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A36detTipoProdID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "DETTIPOPRODID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A36detTipoProdID), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_CATEGID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A32categID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "CATEGID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A32categID), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_SUBCATID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A33subCatID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "SUBCATID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A33subCatID), 4, 0, ".", "")));
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
         RF3N2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV28Pgmname = "WWHistPrecioProd";
         context.Gx_err = 0;
      }

      protected void RF3N2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 59;
         /* Execute user event: Refresh */
         E173N2 ();
         nGXsfl_59_idx = 1;
         sGXsfl_59_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_59_idx), 4, 0)), 4, "0");
         SubsflControlProps_592( ) ;
         bGXsfl_59_Refreshing = true;
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
            SubsflControlProps_592( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV13detTipoProdDsc ,
                                                 AV18HistAnio ,
                                                 AV17categDsc ,
                                                 AV19subCatDsc ,
                                                 A173detTipoProdDsc ,
                                                 A227HistAnio ,
                                                 A146categDsc ,
                                                 A148subCatDsc } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV13detTipoProdDsc = StringUtil.PadR( StringUtil.RTrim( AV13detTipoProdDsc), 40, "%");
            lV17categDsc = StringUtil.PadR( StringUtil.RTrim( AV17categDsc), 40, "%");
            lV19subCatDsc = StringUtil.PadR( StringUtil.RTrim( AV19subCatDsc), 40, "%");
            /* Using cursor H003N2 */
            pr_default.execute(0, new Object[] {lV13detTipoProdDsc, AV18HistAnio, lV17categDsc, lV19subCatDsc, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_59_idx = 1;
            sGXsfl_59_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_59_idx), 4, 0)), 4, "0");
            SubsflControlProps_592( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A229HistEst = H003N2_A229HistEst[0];
               n229HistEst = H003N2_n229HistEst[0];
               A148subCatDsc = H003N2_A148subCatDsc[0];
               n148subCatDsc = H003N2_n148subCatDsc[0];
               A33subCatID = H003N2_A33subCatID[0];
               A146categDsc = H003N2_A146categDsc[0];
               n146categDsc = H003N2_n146categDsc[0];
               A32categID = H003N2_A32categID[0];
               A173detTipoProdDsc = H003N2_A173detTipoProdDsc[0];
               A36detTipoProdID = H003N2_A36detTipoProdID[0];
               A228HistPeriodo = H003N2_A228HistPeriodo[0];
               A227HistAnio = H003N2_A227HistAnio[0];
               A1EmpID = H003N2_A1EmpID[0];
               A146categDsc = H003N2_A146categDsc[0];
               n146categDsc = H003N2_n146categDsc[0];
               A148subCatDsc = H003N2_A148subCatDsc[0];
               n148subCatDsc = H003N2_n148subCatDsc[0];
               E183N2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 59;
            WB3N0( ) ;
         }
         bGXsfl_59_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes3N2( )
      {
         GxWebStd.gx_hidden_field( context, "vADVANCED_LABEL_TEMPLATE", StringUtil.RTrim( AV16ADVANCED_LABEL_TEMPLATE));
         GxWebStd.gx_hidden_field( context, "gxhash_vADVANCED_LABEL_TEMPLATE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV16ADVANCED_LABEL_TEMPLATE, "")), context));
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV20empId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV20empId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vANIO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV24anio), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV24anio), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vMES", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25mes), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vMES", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV25mes), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_DETTIPOPRODID"+"_"+sGXsfl_59_idx, GetSecureSignedToken( sGXsfl_59_idx, context.localUtil.Format( (decimal)(A36detTipoProdID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_CATEGID"+"_"+sGXsfl_59_idx, GetSecureSignedToken( sGXsfl_59_idx, context.localUtil.Format( (decimal)(A32categID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_SUBCATID"+"_"+sGXsfl_59_idx, GetSecureSignedToken( sGXsfl_59_idx, context.localUtil.Format( (decimal)(A33subCatID), "ZZZ9"), context));
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
                                              AV13detTipoProdDsc ,
                                              AV18HistAnio ,
                                              AV17categDsc ,
                                              AV19subCatDsc ,
                                              A173detTipoProdDsc ,
                                              A227HistAnio ,
                                              A146categDsc ,
                                              A148subCatDsc } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV13detTipoProdDsc = StringUtil.PadR( StringUtil.RTrim( AV13detTipoProdDsc), 40, "%");
         lV17categDsc = StringUtil.PadR( StringUtil.RTrim( AV17categDsc), 40, "%");
         lV19subCatDsc = StringUtil.PadR( StringUtil.RTrim( AV19subCatDsc), 40, "%");
         /* Using cursor H003N3 */
         pr_default.execute(1, new Object[] {lV13detTipoProdDsc, AV18HistAnio, lV17categDsc, lV19subCatDsc});
         GRID_nRecordCount = H003N3_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV13detTipoProdDsc, AV17categDsc, AV18HistAnio, AV19subCatDsc, AV16ADVANCED_LABEL_TEMPLATE, AV28Pgmname, AV14Update, AV20empId, AV24anio, AV25mes) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV13detTipoProdDsc, AV17categDsc, AV18HistAnio, AV19subCatDsc, AV16ADVANCED_LABEL_TEMPLATE, AV28Pgmname, AV14Update, AV20empId, AV24anio, AV25mes) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV13detTipoProdDsc, AV17categDsc, AV18HistAnio, AV19subCatDsc, AV16ADVANCED_LABEL_TEMPLATE, AV28Pgmname, AV14Update, AV20empId, AV24anio, AV25mes) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV13detTipoProdDsc, AV17categDsc, AV18HistAnio, AV19subCatDsc, AV16ADVANCED_LABEL_TEMPLATE, AV28Pgmname, AV14Update, AV20empId, AV24anio, AV25mes) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV13detTipoProdDsc, AV17categDsc, AV18HistAnio, AV19subCatDsc, AV16ADVANCED_LABEL_TEMPLATE, AV28Pgmname, AV14Update, AV20empId, AV24anio, AV25mes) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP3N0( )
      {
         /* Before Start, stand alone formulas. */
         AV28Pgmname = "WWHistPrecioProd";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E163N2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV13detTipoProdDsc = StringUtil.Upper( cgiGet( edtavDettipoproddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13detTipoProdDsc", AV13detTipoProdDsc);
            AV17categDsc = StringUtil.Upper( cgiGet( edtavCategdsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17categDsc", AV17categDsc);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavHistanio_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavHistanio_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vHISTANIO");
               GX_FocusControl = edtavHistanio_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV18HistAnio = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18HistAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18HistAnio), 4, 0)));
            }
            else
            {
               AV18HistAnio = (short)(context.localUtil.CToN( cgiGet( edtavHistanio_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18HistAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18HistAnio), 4, 0)));
            }
            AV19subCatDsc = StringUtil.Upper( cgiGet( edtavSubcatdsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19subCatDsc", AV19subCatDsc);
            /* Read saved values. */
            nRC_GXsfl_59 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_59"), ",", "."));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID_nFirstRecordOnPage"), ",", "."));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID_nEOF"), ",", "."));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ",", "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( StringUtil.StrCmp(cgiGet( "GXH_vDETTIPOPRODDSC"), AV13detTipoProdDsc) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCATEGDSC"), AV17categDsc) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vHISTANIO"), ",", ".") != Convert.ToDecimal( AV18HistAnio )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vSUBCATDSC"), AV19subCatDsc) != 0 )
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
         E163N2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E163N2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV28Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV28Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         subGrid_Rows = 10;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         AV14Update = context.GetImagePath( "984dbb7e-3105-4d21-aee3-84a29ade1d38", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV14Update)) ? AV29Update_GXI : context.convertURL( context.PathToRelativeUrl( AV14Update))), !bGXsfl_59_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV14Update), true);
         AV29Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "984dbb7e-3105-4d21-aee3-84a29ade1d38", "", context.GetTheme( )));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV14Update)) ? AV29Update_GXI : context.convertURL( context.PathToRelativeUrl( AV14Update))), !bGXsfl_59_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV14Update), true);
         edtavUpdate_Tooltiptext = "Modificar";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext, !bGXsfl_59_Refreshing);
         edtavCategdsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavCategdsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavCategdsc_Visible), 5, 0)), true);
         edtavHistanio_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavHistanio_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavHistanio_Visible), 5, 0)), true);
         edtavSubcatdsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSubcatdsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSubcatdsc_Visible), 5, 0)), true);
         Form.Caption = "Hist Precio Productoss";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         AV16ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ADVANCED_LABEL_TEMPLATE", AV16ADVANCED_LABEL_TEMPLATE);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vADVANCED_LABEL_TEMPLATE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV16ADVANCED_LABEL_TEMPLATE, "")), context));
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
         AV23fecha = DateTimeUtil.ResetTime(DateTimeUtil.ServerNow( context, pr_default));
         AV24anio = (short)(DateTimeUtil.Year( AV23fecha));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24anio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24anio), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV24anio), "ZZZ9"), context));
         AV25mes = (short)(DateTimeUtil.Month( AV23fecha));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25mes", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25mes), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMES", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV25mes), "ZZZ9"), context));
      }

      protected void E173N2( )
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
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV17categDsc)) )
         {
            lblLblcategdscfilter_Caption = "Categoria";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblLblcategdscfilter_Internalname, "Caption", lblLblcategdscfilter_Caption, true);
         }
         else
         {
            lblLblcategdscfilter_Caption = StringUtil.Format( AV16ADVANCED_LABEL_TEMPLATE, "Categoria", AV17categDsc, "", "", "", "", "", "", "");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblLblcategdscfilter_Internalname, "Caption", lblLblcategdscfilter_Caption, true);
         }
         if ( (0==AV18HistAnio) )
         {
            lblLblhistaniofilter_Caption = "Año";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblLblhistaniofilter_Internalname, "Caption", lblLblhistaniofilter_Caption, true);
         }
         else
         {
            lblLblhistaniofilter_Caption = StringUtil.Format( AV16ADVANCED_LABEL_TEMPLATE, "Año", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18HistAnio), 4, 0)), "", "", "", "", "", "", "");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblLblhistaniofilter_Internalname, "Caption", lblLblhistaniofilter_Caption, true);
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV19subCatDsc)) )
         {
            lblLblsubcatdscfilter_Caption = "Subcategoria";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblLblsubcatdscfilter_Internalname, "Caption", lblLblsubcatdscfilter_Caption, true);
         }
         else
         {
            lblLblsubcatdscfilter_Caption = StringUtil.Format( AV16ADVANCED_LABEL_TEMPLATE, "Subcategoria", AV19subCatDsc, "", "", "", "", "", "", "");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblLblsubcatdscfilter_Internalname, "Caption", lblLblsubcatdscfilter_Caption, true);
         }
         /*  Sending Event outputs  */
      }

      private void E183N2( )
      {
         /* Grid_Load Routine */
         edtavUpdate_Link = formatLink("histprecioprod.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A1EmpID) + "," + UrlEncode("" +A227HistAnio) + "," + UrlEncode("" +A228HistPeriodo) + "," + UrlEncode("" +A36detTipoProdID) + "," + UrlEncode("" +A32categID) + "," + UrlEncode("" +A33subCatID);
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 59;
         }
         sendrow_592( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_59_Refreshing )
         {
            context.DoAjaxLoad(59, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void E153N2( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("histprecioprod.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +AV20empId) + "," + UrlEncode("" +AV24anio) + "," + UrlEncode("" +AV25mes) + "," + UrlEncode("" +0) + "," + UrlEncode("" +0) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV7HTTPRequest.Method, "GET") == 0 )
         {
            AV8GridState.FromXml(AV6Session.Get(AV28Pgmname+"GridState"), null, "GridState", "KBCalpesa22");
            if ( AV8GridState.gxTpr_Filtervalues.Count >= 4 )
            {
               AV13detTipoProdDsc = ((SdtGridState_FilterValue)AV8GridState.gxTpr_Filtervalues.Item(1)).gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13detTipoProdDsc", AV13detTipoProdDsc);
               AV17categDsc = ((SdtGridState_FilterValue)AV8GridState.gxTpr_Filtervalues.Item(2)).gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17categDsc", AV17categDsc);
               AV18HistAnio = (short)(NumberUtil.Val( ((SdtGridState_FilterValue)AV8GridState.gxTpr_Filtervalues.Item(3)).gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18HistAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18HistAnio), 4, 0)));
               AV19subCatDsc = ((SdtGridState_FilterValue)AV8GridState.gxTpr_Filtervalues.Item(4)).gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19subCatDsc", AV19subCatDsc);
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

      protected void S132( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV8GridState.FromXml(AV6Session.Get(AV28Pgmname+"GridState"), null, "GridState", "KBCalpesa22");
         AV8GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         AV8GridState.gxTpr_Filtervalues.Clear();
         AV9GridStateFilterValue = new SdtGridState_FilterValue(context);
         AV9GridStateFilterValue.gxTpr_Value = AV13detTipoProdDsc;
         AV8GridState.gxTpr_Filtervalues.Add(AV9GridStateFilterValue, 0);
         AV9GridStateFilterValue = new SdtGridState_FilterValue(context);
         AV9GridStateFilterValue.gxTpr_Value = AV17categDsc;
         AV8GridState.gxTpr_Filtervalues.Add(AV9GridStateFilterValue, 0);
         AV9GridStateFilterValue = new SdtGridState_FilterValue(context);
         AV9GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV18HistAnio), 4, 0);
         AV8GridState.gxTpr_Filtervalues.Add(AV9GridStateFilterValue, 0);
         AV9GridStateFilterValue = new SdtGridState_FilterValue(context);
         AV9GridStateFilterValue.gxTpr_Value = AV19subCatDsc;
         AV8GridState.gxTpr_Filtervalues.Add(AV9GridStateFilterValue, 0);
         AV6Session.Set(AV28Pgmname+"GridState", AV8GridState.ToXml(false, true, "GridState", "KBCalpesa22"));
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV11TrnContext = new SdtTransactionContext(context);
         AV11TrnContext.gxTpr_Callerobject = AV28Pgmname;
         AV11TrnContext.gxTpr_Callerondelete = true;
         AV11TrnContext.gxTpr_Callerurl = AV7HTTPRequest.ScriptName+"?"+AV7HTTPRequest.QueryString;
         AV11TrnContext.gxTpr_Transactionname = "HistPrecioProd";
         AV6Session.Set("TrnContext", AV11TrnContext.ToXml(false, true, "TransactionContext", "KBCalpesa22"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV20empId = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20empId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20empId), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV20empId), "ZZZ9"), context));
         AV21ageId = Convert.ToInt16(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ageId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21ageId), 4, 0)));
         AV22usucod = (String)getParm(obj,2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22usucod", AV22usucod);
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
         PA3N2( ) ;
         WS3N2( ) ;
         WE3N2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202211192254623", true);
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
         context.AddJavascriptSource("wwhistprecioprod.js", "?202211192254623", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_592( )
      {
         edtEmpID_Internalname = "EMPID_"+sGXsfl_59_idx;
         edtHistAnio_Internalname = "HISTANIO_"+sGXsfl_59_idx;
         cmbHistPeriodo_Internalname = "HISTPERIODO_"+sGXsfl_59_idx;
         edtdetTipoProdID_Internalname = "DETTIPOPRODID_"+sGXsfl_59_idx;
         edtdetTipoProdDsc_Internalname = "DETTIPOPRODDSC_"+sGXsfl_59_idx;
         edtcategID_Internalname = "CATEGID_"+sGXsfl_59_idx;
         edtcategDsc_Internalname = "CATEGDSC_"+sGXsfl_59_idx;
         edtsubCatID_Internalname = "SUBCATID_"+sGXsfl_59_idx;
         edtsubCatDsc_Internalname = "SUBCATDSC_"+sGXsfl_59_idx;
         edtHistEst_Internalname = "HISTEST_"+sGXsfl_59_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_59_idx;
      }

      protected void SubsflControlProps_fel_592( )
      {
         edtEmpID_Internalname = "EMPID_"+sGXsfl_59_fel_idx;
         edtHistAnio_Internalname = "HISTANIO_"+sGXsfl_59_fel_idx;
         cmbHistPeriodo_Internalname = "HISTPERIODO_"+sGXsfl_59_fel_idx;
         edtdetTipoProdID_Internalname = "DETTIPOPRODID_"+sGXsfl_59_fel_idx;
         edtdetTipoProdDsc_Internalname = "DETTIPOPRODDSC_"+sGXsfl_59_fel_idx;
         edtcategID_Internalname = "CATEGID_"+sGXsfl_59_fel_idx;
         edtcategDsc_Internalname = "CATEGDSC_"+sGXsfl_59_fel_idx;
         edtsubCatID_Internalname = "SUBCATID_"+sGXsfl_59_fel_idx;
         edtsubCatDsc_Internalname = "SUBCATDSC_"+sGXsfl_59_fel_idx;
         edtHistEst_Internalname = "HISTEST_"+sGXsfl_59_fel_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_59_fel_idx;
      }

      protected void sendrow_592( )
      {
         SubsflControlProps_592( ) ;
         WB3N0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_59_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_59_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_59_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEmpID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEmpID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)59,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtHistAnio_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A227HistAnio), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A227HistAnio), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtHistAnio_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)59,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbHistPeriodo.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "HISTPERIODO_" + sGXsfl_59_idx;
               cmbHistPeriodo.Name = GXCCtl;
               cmbHistPeriodo.WebTags = "";
               cmbHistPeriodo.addItem("1", "ENERO", 0);
               cmbHistPeriodo.addItem("2", "FEBRERO", 0);
               cmbHistPeriodo.addItem("3", "MARZO", 0);
               cmbHistPeriodo.addItem("4", "ABRIL", 0);
               cmbHistPeriodo.addItem("5", "MAYO", 0);
               cmbHistPeriodo.addItem("6", "JUNIO", 0);
               cmbHistPeriodo.addItem("7", "JULIO", 0);
               cmbHistPeriodo.addItem("8", "AGOSTO", 0);
               cmbHistPeriodo.addItem("9", "SEPTIEMBRE", 0);
               cmbHistPeriodo.addItem("10", "OCTUBRE", 0);
               cmbHistPeriodo.addItem("11", "NOVIEMBRE", 0);
               cmbHistPeriodo.addItem("12", "DICIEMBRE", 0);
               if ( cmbHistPeriodo.ItemCount > 0 )
               {
                  A228HistPeriodo = (short)(NumberUtil.Val( cmbHistPeriodo.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A228HistPeriodo), 2, 0))), "."));
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbHistPeriodo,(String)cmbHistPeriodo_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(A228HistPeriodo), 2, 0)),(short)1,(String)cmbHistPeriodo_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn WWOptionalColumn",(String)"",(String)"",(String)"",(bool)true});
            cmbHistPeriodo.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A228HistPeriodo), 2, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbHistPeriodo_Internalname, "Values", (String)(cmbHistPeriodo.ToJavascriptSource()), !bGXsfl_59_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtdetTipoProdID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A36detTipoProdID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A36detTipoProdID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtdetTipoProdID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)59,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtdetTipoProdDsc_Internalname,StringUtil.RTrim( A173detTipoProdDsc),StringUtil.RTrim( context.localUtil.Format( A173detTipoProdDsc, "@!")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtdetTipoProdDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)59,(short)1,(short)-1,(short)-1,(bool)true,(String)"nombres",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtcategID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A32categID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A32categID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtcategID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)59,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtcategDsc_Internalname,StringUtil.RTrim( A146categDsc),StringUtil.RTrim( context.localUtil.Format( A146categDsc, "@!")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtcategDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)59,(short)1,(short)-1,(short)-1,(bool)true,(String)"nombres",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtsubCatID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A33subCatID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A33subCatID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtsubCatID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)59,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtsubCatDsc_Internalname,StringUtil.RTrim( A148subCatDsc),StringUtil.RTrim( context.localUtil.Format( A148subCatDsc, "@!")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtsubCatDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)59,(short)1,(short)-1,(short)-1,(bool)true,(String)"nombres",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtHistEst_Internalname,StringUtil.RTrim( A229HistEst),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtHistEst_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)1,(short)0,(short)0,(short)59,(short)1,(short)-1,(short)-1,(bool)true,(String)"estado",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ImageAttribute";
            StyleString = "";
            AV14Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV14Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV29Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV14Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV14Update)) ? AV29Update_GXI : context.PathToRelativeUrl( AV14Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV14Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            send_integrity_lvl_hashes3N2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_59_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_59_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_59_idx+1));
            sGXsfl_59_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_59_idx), 4, 0)), 4, "0");
            SubsflControlProps_592( ) ;
         }
         /* End function sendrow_592 */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "HISTPERIODO_" + sGXsfl_59_idx;
         cmbHistPeriodo.Name = GXCCtl;
         cmbHistPeriodo.WebTags = "";
         cmbHistPeriodo.addItem("1", "ENERO", 0);
         cmbHistPeriodo.addItem("2", "FEBRERO", 0);
         cmbHistPeriodo.addItem("3", "MARZO", 0);
         cmbHistPeriodo.addItem("4", "ABRIL", 0);
         cmbHistPeriodo.addItem("5", "MAYO", 0);
         cmbHistPeriodo.addItem("6", "JUNIO", 0);
         cmbHistPeriodo.addItem("7", "JULIO", 0);
         cmbHistPeriodo.addItem("8", "AGOSTO", 0);
         cmbHistPeriodo.addItem("9", "SEPTIEMBRE", 0);
         cmbHistPeriodo.addItem("10", "OCTUBRE", 0);
         cmbHistPeriodo.addItem("11", "NOVIEMBRE", 0);
         cmbHistPeriodo.addItem("12", "DICIEMBRE", 0);
         if ( cmbHistPeriodo.ItemCount > 0 )
         {
            A228HistPeriodo = (short)(NumberUtil.Val( cmbHistPeriodo.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A228HistPeriodo), 2, 0))), "."));
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtntoggle_Internalname = "BTNTOGGLE";
         lblTitletext_Internalname = "TITLETEXT";
         bttBtninsert_Internalname = "BTNINSERT";
         edtavDettipoproddsc_Internalname = "vDETTIPOPRODDSC";
         divTabletop_Internalname = "TABLETOP";
         lblLblcategdscfilter_Internalname = "LBLCATEGDSCFILTER";
         edtavCategdsc_Internalname = "vCATEGDSC";
         divCategdscfiltercontainer_Internalname = "CATEGDSCFILTERCONTAINER";
         lblLblhistaniofilter_Internalname = "LBLHISTANIOFILTER";
         edtavHistanio_Internalname = "vHISTANIO";
         divHistaniofiltercontainer_Internalname = "HISTANIOFILTERCONTAINER";
         lblLblsubcatdscfilter_Internalname = "LBLSUBCATDSCFILTER";
         edtavSubcatdsc_Internalname = "vSUBCATDSC";
         divSubcatdscfiltercontainer_Internalname = "SUBCATDSCFILTERCONTAINER";
         divFilterscontainer_Internalname = "FILTERSCONTAINER";
         edtEmpID_Internalname = "EMPID";
         edtHistAnio_Internalname = "HISTANIO";
         cmbHistPeriodo_Internalname = "HISTPERIODO";
         edtdetTipoProdID_Internalname = "DETTIPOPRODID";
         edtdetTipoProdDsc_Internalname = "DETTIPOPRODDSC";
         edtcategID_Internalname = "CATEGID";
         edtcategDsc_Internalname = "CATEGDSC";
         edtsubCatID_Internalname = "SUBCATID";
         edtsubCatDsc_Internalname = "SUBCATDSC";
         edtHistEst_Internalname = "HISTEST";
         edtavUpdate_Internalname = "vUPDATE";
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
         edtHistEst_Jsonclick = "";
         edtsubCatDsc_Jsonclick = "";
         edtsubCatID_Jsonclick = "";
         edtcategDsc_Jsonclick = "";
         edtcategID_Jsonclick = "";
         edtdetTipoProdDsc_Jsonclick = "";
         edtdetTipoProdID_Jsonclick = "";
         cmbHistPeriodo_Jsonclick = "";
         edtHistAnio_Jsonclick = "";
         edtEmpID_Jsonclick = "";
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavUpdate_Link = "";
         subGrid_Header = "";
         subGrid_Class = "WorkWith";
         subGrid_Backcolorstyle = 0;
         divGridcell_Class = "col-xs-12 col-sm-9 col-md-10 WWGridCell";
         edtavSubcatdsc_Jsonclick = "";
         edtavSubcatdsc_Enabled = 1;
         edtavSubcatdsc_Visible = 1;
         lblLblsubcatdscfilter_Caption = "Subcategoria";
         edtavHistanio_Jsonclick = "";
         edtavHistanio_Enabled = 1;
         edtavHistanio_Visible = 1;
         lblLblhistaniofilter_Caption = "Año";
         edtavCategdsc_Jsonclick = "";
         edtavCategdsc_Enabled = 1;
         edtavCategdsc_Visible = 1;
         lblLblcategdscfilter_Caption = "Categoria";
         edtavDettipoproddsc_Jsonclick = "";
         edtavDettipoproddsc_Enabled = 1;
         bttBtntoggle_Class = "HideFiltersButton";
         bttBtntoggle_Caption = "Ocultar";
         divSubcatdscfiltercontainer_Class = "AdvancedContainerItem";
         divHistaniofiltercontainer_Class = "AdvancedContainerItem";
         divCategdscfiltercontainer_Class = "AdvancedContainerItem";
         divFilterscontainer_Class = "AdvancedContainerVisible";
         Form.Caption = "Work With Hist Precio Productos";
         subGrid_Rows = 10;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV17categDsc',fld:'vCATEGDSC',pic:'@!'},{av:'AV18HistAnio',fld:'vHISTANIO',pic:'ZZZ9'},{av:'AV19subCatDsc',fld:'vSUBCATDSC',pic:'@!'},{av:'AV28Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13detTipoProdDsc',fld:'vDETTIPOPRODDSC',pic:'@!'},{av:'AV20empId',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV16ADVANCED_LABEL_TEMPLATE',fld:'vADVANCED_LABEL_TEMPLATE',pic:'',hsh:true},{av:'AV24anio',fld:'vANIO',pic:'ZZZ9',hsh:true},{av:'AV25mes',fld:'vMES',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[{av:'lblLblcategdscfilter_Caption',ctrl:'LBLCATEGDSCFILTER',prop:'Caption'},{av:'lblLblhistaniofilter_Caption',ctrl:'LBLHISTANIOFILTER',prop:'Caption'},{av:'lblLblsubcatdscfilter_Caption',ctrl:'LBLSUBCATDSCFILTER',prop:'Caption'}]}");
         setEventMetadata("'TOGGLE'","{handler:'E113N1',iparms:[{av:'divFilterscontainer_Class',ctrl:'FILTERSCONTAINER',prop:'Class'}]");
         setEventMetadata("'TOGGLE'",",oparms:[{av:'divFilterscontainer_Class',ctrl:'FILTERSCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Caption'},{av:'divGridcell_Class',ctrl:'GRIDCELL',prop:'Class'}]}");
         setEventMetadata("LBLCATEGDSCFILTER.CLICK","{handler:'E123N1',iparms:[{av:'divCategdscfiltercontainer_Class',ctrl:'CATEGDSCFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLCATEGDSCFILTER.CLICK",",oparms:[{av:'divCategdscfiltercontainer_Class',ctrl:'CATEGDSCFILTERCONTAINER',prop:'Class'},{av:'edtavCategdsc_Visible',ctrl:'vCATEGDSC',prop:'Visible'}]}");
         setEventMetadata("LBLHISTANIOFILTER.CLICK","{handler:'E133N1',iparms:[{av:'divHistaniofiltercontainer_Class',ctrl:'HISTANIOFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLHISTANIOFILTER.CLICK",",oparms:[{av:'divHistaniofiltercontainer_Class',ctrl:'HISTANIOFILTERCONTAINER',prop:'Class'},{av:'edtavHistanio_Visible',ctrl:'vHISTANIO',prop:'Visible'}]}");
         setEventMetadata("LBLSUBCATDSCFILTER.CLICK","{handler:'E143N1',iparms:[{av:'divSubcatdscfiltercontainer_Class',ctrl:'SUBCATDSCFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLSUBCATDSCFILTER.CLICK",",oparms:[{av:'divSubcatdscfiltercontainer_Class',ctrl:'SUBCATDSCFILTERCONTAINER',prop:'Class'},{av:'edtavSubcatdsc_Visible',ctrl:'vSUBCATDSC',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E183N2',iparms:[{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'A227HistAnio',fld:'HISTANIO',pic:'ZZZ9'},{av:'cmbHistPeriodo'},{av:'A228HistPeriodo',fld:'HISTPERIODO',pic:'Z9'},{av:'A36detTipoProdID',fld:'DETTIPOPRODID',pic:'ZZZ9',hsh:true},{av:'A32categID',fld:'CATEGID',pic:'ZZZ9',hsh:true},{av:'A33subCatID',fld:'SUBCATID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E153N2',iparms:[{av:'AV20empId',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV24anio',fld:'vANIO',pic:'ZZZ9',hsh:true},{av:'AV25mes',fld:'vMES',pic:'ZZZ9',hsh:true},{av:'A36detTipoProdID',fld:'DETTIPOPRODID',pic:'ZZZ9',hsh:true},{av:'A32categID',fld:'CATEGID',pic:'ZZZ9',hsh:true},{av:'A33subCatID',fld:'SUBCATID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("'DOINSERT'",",oparms:[]}");
         setEventMetadata("GRID_FIRSTPAGE","{handler:'subgrid_firstpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV20empId',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV24anio',fld:'vANIO',pic:'ZZZ9',hsh:true},{av:'AV25mes',fld:'vMES',pic:'ZZZ9',hsh:true},{av:'AV17categDsc',fld:'vCATEGDSC',pic:'@!'},{av:'AV16ADVANCED_LABEL_TEMPLATE',fld:'vADVANCED_LABEL_TEMPLATE',pic:'',hsh:true},{av:'AV18HistAnio',fld:'vHISTANIO',pic:'ZZZ9'},{av:'AV19subCatDsc',fld:'vSUBCATDSC',pic:'@!'},{av:'AV28Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13detTipoProdDsc',fld:'vDETTIPOPRODDSC',pic:'@!'}]");
         setEventMetadata("GRID_FIRSTPAGE",",oparms:[{av:'lblLblcategdscfilter_Caption',ctrl:'LBLCATEGDSCFILTER',prop:'Caption'},{av:'lblLblhistaniofilter_Caption',ctrl:'LBLHISTANIOFILTER',prop:'Caption'},{av:'lblLblsubcatdscfilter_Caption',ctrl:'LBLSUBCATDSCFILTER',prop:'Caption'}]}");
         setEventMetadata("GRID_PREVPAGE","{handler:'subgrid_previouspage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV20empId',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV24anio',fld:'vANIO',pic:'ZZZ9',hsh:true},{av:'AV25mes',fld:'vMES',pic:'ZZZ9',hsh:true},{av:'AV17categDsc',fld:'vCATEGDSC',pic:'@!'},{av:'AV16ADVANCED_LABEL_TEMPLATE',fld:'vADVANCED_LABEL_TEMPLATE',pic:'',hsh:true},{av:'AV18HistAnio',fld:'vHISTANIO',pic:'ZZZ9'},{av:'AV19subCatDsc',fld:'vSUBCATDSC',pic:'@!'},{av:'AV28Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13detTipoProdDsc',fld:'vDETTIPOPRODDSC',pic:'@!'}]");
         setEventMetadata("GRID_PREVPAGE",",oparms:[{av:'lblLblcategdscfilter_Caption',ctrl:'LBLCATEGDSCFILTER',prop:'Caption'},{av:'lblLblhistaniofilter_Caption',ctrl:'LBLHISTANIOFILTER',prop:'Caption'},{av:'lblLblsubcatdscfilter_Caption',ctrl:'LBLSUBCATDSCFILTER',prop:'Caption'}]}");
         setEventMetadata("GRID_NEXTPAGE","{handler:'subgrid_nextpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV20empId',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV24anio',fld:'vANIO',pic:'ZZZ9',hsh:true},{av:'AV25mes',fld:'vMES',pic:'ZZZ9',hsh:true},{av:'AV17categDsc',fld:'vCATEGDSC',pic:'@!'},{av:'AV16ADVANCED_LABEL_TEMPLATE',fld:'vADVANCED_LABEL_TEMPLATE',pic:'',hsh:true},{av:'AV18HistAnio',fld:'vHISTANIO',pic:'ZZZ9'},{av:'AV19subCatDsc',fld:'vSUBCATDSC',pic:'@!'},{av:'AV28Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13detTipoProdDsc',fld:'vDETTIPOPRODDSC',pic:'@!'}]");
         setEventMetadata("GRID_NEXTPAGE",",oparms:[{av:'lblLblcategdscfilter_Caption',ctrl:'LBLCATEGDSCFILTER',prop:'Caption'},{av:'lblLblhistaniofilter_Caption',ctrl:'LBLHISTANIOFILTER',prop:'Caption'},{av:'lblLblsubcatdscfilter_Caption',ctrl:'LBLSUBCATDSCFILTER',prop:'Caption'}]}");
         setEventMetadata("GRID_LASTPAGE","{handler:'subgrid_lastpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV20empId',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV24anio',fld:'vANIO',pic:'ZZZ9',hsh:true},{av:'AV25mes',fld:'vMES',pic:'ZZZ9',hsh:true},{av:'AV17categDsc',fld:'vCATEGDSC',pic:'@!'},{av:'AV16ADVANCED_LABEL_TEMPLATE',fld:'vADVANCED_LABEL_TEMPLATE',pic:'',hsh:true},{av:'AV18HistAnio',fld:'vHISTANIO',pic:'ZZZ9'},{av:'AV19subCatDsc',fld:'vSUBCATDSC',pic:'@!'},{av:'AV28Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13detTipoProdDsc',fld:'vDETTIPOPRODDSC',pic:'@!'}]");
         setEventMetadata("GRID_LASTPAGE",",oparms:[{av:'lblLblcategdscfilter_Caption',ctrl:'LBLCATEGDSCFILTER',prop:'Caption'},{av:'lblLblhistaniofilter_Caption',ctrl:'LBLHISTANIOFILTER',prop:'Caption'},{av:'lblLblsubcatdscfilter_Caption',ctrl:'LBLSUBCATDSCFILTER',prop:'Caption'}]}");
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
         wcpOAV22usucod = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV14Update = "";
         AV13detTipoProdDsc = "";
         AV17categDsc = "";
         AV19subCatDsc = "";
         AV16ADVANCED_LABEL_TEMPLATE = "";
         AV28Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         sPrefix = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         lblTitletext_Jsonclick = "";
         bttBtninsert_Jsonclick = "";
         lblLblcategdscfilter_Jsonclick = "";
         lblLblhistaniofilter_Jsonclick = "";
         lblLblsubcatdscfilter_Jsonclick = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         A173detTipoProdDsc = "";
         A146categDsc = "";
         A148subCatDsc = "";
         A229HistEst = "";
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV29Update_GXI = "";
         scmdbuf = "";
         lV13detTipoProdDsc = "";
         lV17categDsc = "";
         lV19subCatDsc = "";
         H003N2_A229HistEst = new String[] {""} ;
         H003N2_n229HistEst = new bool[] {false} ;
         H003N2_A148subCatDsc = new String[] {""} ;
         H003N2_n148subCatDsc = new bool[] {false} ;
         H003N2_A33subCatID = new short[1] ;
         H003N2_A146categDsc = new String[] {""} ;
         H003N2_n146categDsc = new bool[] {false} ;
         H003N2_A32categID = new short[1] ;
         H003N2_A173detTipoProdDsc = new String[] {""} ;
         H003N2_A36detTipoProdID = new short[1] ;
         H003N2_A228HistPeriodo = new short[1] ;
         H003N2_A227HistAnio = new short[1] ;
         H003N2_A1EmpID = new short[1] ;
         H003N3_AGRID_nRecordCount = new long[1] ;
         AV23fecha = DateTime.MinValue;
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwhistprecioprod__default(),
            new Object[][] {
                new Object[] {
               H003N2_A229HistEst, H003N2_n229HistEst, H003N2_A148subCatDsc, H003N2_n148subCatDsc, H003N2_A33subCatID, H003N2_A146categDsc, H003N2_n146categDsc, H003N2_A32categID, H003N2_A173detTipoProdDsc, H003N2_A36detTipoProdID,
               H003N2_A228HistPeriodo, H003N2_A227HistAnio, H003N2_A1EmpID
               }
               , new Object[] {
               H003N3_AGRID_nRecordCount
               }
            }
         );
         AV28Pgmname = "WWHistPrecioProd";
         /* GeneXus formulas. */
         AV28Pgmname = "WWHistPrecioProd";
         context.Gx_err = 0;
      }

      private short AV20empId ;
      private short AV21ageId ;
      private short wcpOAV20empId ;
      private short wcpOAV21ageId ;
      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_59 ;
      private short nGXsfl_59_idx=1 ;
      private short GRID_nEOF ;
      private short AV18HistAnio ;
      private short AV24anio ;
      private short AV25mes ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short A1EmpID ;
      private short A227HistAnio ;
      private short A228HistPeriodo ;
      private short A36detTipoProdID ;
      private short A32categID ;
      private short A33subCatID ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid_Backstyle ;
      private int subGrid_Rows ;
      private int edtavDettipoproddsc_Enabled ;
      private int edtavCategdsc_Visible ;
      private int edtavCategdsc_Enabled ;
      private int edtavHistanio_Enabled ;
      private int edtavHistanio_Visible ;
      private int edtavSubcatdsc_Visible ;
      private int edtavSubcatdsc_Enabled ;
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
      private String AV22usucod ;
      private String wcpOAV22usucod ;
      private String edtavUpdate_Tooltiptext ;
      private String divFilterscontainer_Class ;
      private String divCategdscfiltercontainer_Class ;
      private String divHistaniofiltercontainer_Class ;
      private String divSubcatdscfiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_59_idx="0001" ;
      private String edtavUpdate_Internalname ;
      private String AV13detTipoProdDsc ;
      private String AV17categDsc ;
      private String AV19subCatDsc ;
      private String AV16ADVANCED_LABEL_TEMPLATE ;
      private String AV28Pgmname ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String divTabletop_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String bttBtntoggle_Class ;
      private String StyleString ;
      private String bttBtntoggle_Internalname ;
      private String bttBtntoggle_Caption ;
      private String bttBtntoggle_Jsonclick ;
      private String lblTitletext_Internalname ;
      private String lblTitletext_Jsonclick ;
      private String bttBtninsert_Internalname ;
      private String bttBtninsert_Jsonclick ;
      private String edtavDettipoproddsc_Internalname ;
      private String edtavDettipoproddsc_Jsonclick ;
      private String divFilterscontainer_Internalname ;
      private String divCategdscfiltercontainer_Internalname ;
      private String lblLblcategdscfilter_Internalname ;
      private String lblLblcategdscfilter_Caption ;
      private String lblLblcategdscfilter_Jsonclick ;
      private String edtavCategdsc_Internalname ;
      private String edtavCategdsc_Jsonclick ;
      private String divHistaniofiltercontainer_Internalname ;
      private String lblLblhistaniofilter_Internalname ;
      private String lblLblhistaniofilter_Caption ;
      private String lblLblhistaniofilter_Jsonclick ;
      private String edtavHistanio_Internalname ;
      private String edtavHistanio_Jsonclick ;
      private String divSubcatdscfiltercontainer_Internalname ;
      private String lblLblsubcatdscfilter_Internalname ;
      private String lblLblsubcatdscfilter_Caption ;
      private String lblLblsubcatdscfilter_Jsonclick ;
      private String edtavSubcatdsc_Internalname ;
      private String edtavSubcatdsc_Jsonclick ;
      private String divGridcell_Internalname ;
      private String divGridcell_Class ;
      private String divGridtable_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String subGrid_Header ;
      private String A173detTipoProdDsc ;
      private String A146categDsc ;
      private String A148subCatDsc ;
      private String A229HistEst ;
      private String edtavUpdate_Link ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtEmpID_Internalname ;
      private String edtHistAnio_Internalname ;
      private String cmbHistPeriodo_Internalname ;
      private String edtdetTipoProdID_Internalname ;
      private String edtdetTipoProdDsc_Internalname ;
      private String edtcategID_Internalname ;
      private String edtcategDsc_Internalname ;
      private String edtsubCatID_Internalname ;
      private String edtsubCatDsc_Internalname ;
      private String edtHistEst_Internalname ;
      private String scmdbuf ;
      private String lV13detTipoProdDsc ;
      private String lV17categDsc ;
      private String lV19subCatDsc ;
      private String sGXsfl_59_fel_idx="0001" ;
      private String ROClassString ;
      private String edtEmpID_Jsonclick ;
      private String edtHistAnio_Jsonclick ;
      private String GXCCtl ;
      private String cmbHistPeriodo_Jsonclick ;
      private String edtdetTipoProdID_Jsonclick ;
      private String edtdetTipoProdDsc_Jsonclick ;
      private String edtcategID_Jsonclick ;
      private String edtcategDsc_Jsonclick ;
      private String edtsubCatID_Jsonclick ;
      private String edtsubCatDsc_Jsonclick ;
      private String edtHistEst_Jsonclick ;
      private String sImgUrl ;
      private DateTime AV23fecha ;
      private bool entryPointCalled ;
      private bool bGXsfl_59_Refreshing=false ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n146categDsc ;
      private bool n148subCatDsc ;
      private bool n229HistEst ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV14Update_IsBlob ;
      private String AV29Update_GXI ;
      private String AV14Update ;
      private IGxSession AV6Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbHistPeriodo ;
      private IDataStoreProvider pr_default ;
      private String[] H003N2_A229HistEst ;
      private bool[] H003N2_n229HistEst ;
      private String[] H003N2_A148subCatDsc ;
      private bool[] H003N2_n148subCatDsc ;
      private short[] H003N2_A33subCatID ;
      private String[] H003N2_A146categDsc ;
      private bool[] H003N2_n146categDsc ;
      private short[] H003N2_A32categID ;
      private String[] H003N2_A173detTipoProdDsc ;
      private short[] H003N2_A36detTipoProdID ;
      private short[] H003N2_A228HistPeriodo ;
      private short[] H003N2_A227HistAnio ;
      private short[] H003N2_A1EmpID ;
      private long[] H003N3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV7HTTPRequest ;
      private SdtGridState AV8GridState ;
      private SdtGridState_FilterValue AV9GridStateFilterValue ;
      private SdtTransactionContext AV11TrnContext ;
   }

   public class wwhistprecioprod__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H003N2( IGxContext context ,
                                             String AV13detTipoProdDsc ,
                                             short AV18HistAnio ,
                                             String AV17categDsc ,
                                             String AV19subCatDsc ,
                                             String A173detTipoProdDsc ,
                                             short A227HistAnio ,
                                             String A146categDsc ,
                                             String A148subCatDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [7] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " T1.[HistEst], T3.[subCatDsc], T1.[subCatID], T2.[categDsc], T1.[categID], T1.[detTipoProdDsc], T1.[detTipoProdID], T1.[HistPeriodo], T1.[HistAnio], T1.[EmpID]";
         sFromString = " FROM (([HistPrecioProd] T1 WITH (NOLOCK) INNER JOIN [Categorias] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[categID] = T1.[categID]) INNER JOIN [CategoriassubCat] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[categID] = T1.[categID] AND T3.[subCatID] = T1.[subCatID])";
         sOrderString = "";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV13detTipoProdDsc)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[detTipoProdDsc] like @lV13detTipoProdDsc)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[detTipoProdDsc] like @lV13detTipoProdDsc)";
            }
         }
         else
         {
            GXv_int1[0] = 1;
         }
         if ( ! (0==AV18HistAnio) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[HistAnio] >= @AV18HistAnio)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[HistAnio] >= @AV18HistAnio)";
            }
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV17categDsc)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[categDsc] like @lV17categDsc)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[categDsc] like @lV17categDsc)";
            }
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV19subCatDsc)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[subCatDsc] like @lV19subCatDsc)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[subCatDsc] like @lV19subCatDsc)";
            }
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         sOrderString = sOrderString + " ORDER BY T1.[HistAnio], T1.[HistPeriodo]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H003N3( IGxContext context ,
                                             String AV13detTipoProdDsc ,
                                             short AV18HistAnio ,
                                             String AV17categDsc ,
                                             String AV19subCatDsc ,
                                             String A173detTipoProdDsc ,
                                             short A227HistAnio ,
                                             String A146categDsc ,
                                             String A148subCatDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [4] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM (([HistPrecioProd] T1 WITH (NOLOCK) INNER JOIN [Categorias] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[categID] = T1.[categID]) INNER JOIN [CategoriassubCat] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[categID] = T1.[categID] AND T3.[subCatID] = T1.[subCatID])";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV13detTipoProdDsc)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[detTipoProdDsc] like @lV13detTipoProdDsc)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[detTipoProdDsc] like @lV13detTipoProdDsc)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! (0==AV18HistAnio) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[HistAnio] >= @AV18HistAnio)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[HistAnio] >= @AV18HistAnio)";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV17categDsc)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[categDsc] like @lV17categDsc)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[categDsc] like @lV17categDsc)";
            }
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV19subCatDsc)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[subCatDsc] like @lV19subCatDsc)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[subCatDsc] like @lV19subCatDsc)";
            }
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + "";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H003N2(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (short)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] );
               case 1 :
                     return conditional_H003N3(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (short)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] );
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
          Object[] prmH003N2 ;
          prmH003N2 = new Object[] {
          new Object[] {"@lV13detTipoProdDsc",SqlDbType.Char,40,0} ,
          new Object[] {"@AV18HistAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV17categDsc",SqlDbType.Char,40,0} ,
          new Object[] {"@lV19subCatDsc",SqlDbType.Char,40,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH003N3 ;
          prmH003N3 = new Object[] {
          new Object[] {"@lV13detTipoProdDsc",SqlDbType.Char,40,0} ,
          new Object[] {"@AV18HistAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV17categDsc",SqlDbType.Char,40,0} ,
          new Object[] {"@lV19subCatDsc",SqlDbType.Char,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H003N2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003N2,11,0,true,false )
             ,new CursorDef("H003N3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003N3,1,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getString(2, 40) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((short[]) buf[4])[0] = rslt.getShort(3) ;
                ((String[]) buf[5])[0] = rslt.getString(4, 40) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                ((String[]) buf[8])[0] = rslt.getString(6, 40) ;
                ((short[]) buf[9])[0] = rslt.getShort(7) ;
                ((short[]) buf[10])[0] = rslt.getShort(8) ;
                ((short[]) buf[11])[0] = rslt.getShort(9) ;
                ((short[]) buf[12])[0] = rslt.getShort(10) ;
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
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[8]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[9]);
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
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[4]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[5]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[6]);
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
