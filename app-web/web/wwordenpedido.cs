/*
               File: WWOrdenPedido
        Description: Orden Pedidoes
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/26/2022 20:15:15.2
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
   public class wwordenpedido : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public wwordenpedido( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public wwordenpedido( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid") == 0 )
            {
               nRC_GXsfl_53 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_53_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_53_idx = GetNextPar( );
               AV16Update = GetNextPar( );
               edtavUpdate_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext, !bGXsfl_53_Refreshing);
               AV17Delete = GetNextPar( );
               edtavDelete_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext, !bGXsfl_53_Refreshing);
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
               AV14PedCod = (int)(NumberUtil.Val( GetNextPar( ), "."));
               AV15PedDescripcion = GetNextPar( );
               AV13OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV18ADVANCED_LABEL_TEMPLATE = GetNextPar( );
               AV21Pgmname = GetNextPar( );
               AV16Update = GetNextPar( );
               edtavUpdate_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext, !bGXsfl_53_Refreshing);
               AV17Delete = GetNextPar( );
               edtavDelete_Tooltiptext = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext, !bGXsfl_53_Refreshing);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV14PedCod, AV15PedDescripcion, AV13OrderedBy, AV18ADVANCED_LABEL_TEMPLATE, AV21Pgmname, AV16Update, AV17Delete) ;
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
            PA1X2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV21Pgmname = "WWOrdenPedido";
               context.Gx_err = 0;
               WS1X2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE1X2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202210262015159", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("wwordenpedido.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vPEDCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14PedCod), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vPEDDESCRIPCION", StringUtil.RTrim( AV15PedDescripcion));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_53", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_53), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vADVANCED_LABEL_TEMPLATE", StringUtil.RTrim( AV18ADVANCED_LABEL_TEMPLATE));
         GxWebStd.gx_hidden_field( context, "gxhash_vADVANCED_LABEL_TEMPLATE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV18ADVANCED_LABEL_TEMPLATE, "")), context));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV21Pgmname));
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "FILTERSCONTAINER_Class", StringUtil.RTrim( divFilterscontainer_Class));
         GxWebStd.gx_hidden_field( context, "ORDERBYCONTAINER_Class", StringUtil.RTrim( divOrderbycontainer_Class));
         GxWebStd.gx_hidden_field( context, "PEDDESCRIPCIONFILTERCONTAINER_Class", StringUtil.RTrim( divPeddescripcionfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "vUPDATE_Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
         GxWebStd.gx_hidden_field( context, "vDELETE_Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
      }

      protected void RenderHtmlCloseForm1X2( )
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
         return "WWOrdenPedido" ;
      }

      public override String GetPgmdesc( )
      {
         return "Orden Pedidoes" ;
      }

      protected void WB1X0( )
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
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(53), 2, 0)+","+"null"+");", bttBtntoggle_Caption, bttBtntoggle_Jsonclick, 7, "Hide Filters", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e111x1_client"+"'", TempTags, "", 2, "HLP_WWOrdenPedido.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 col-sm-2", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitletext_Internalname, "Orden Pedidoes", "", "", lblTitletext_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "SubTitle", 0, "", 1, 1, 0, "HLP_WWOrdenPedido.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(53), 2, 0)+","+"null"+");", "Agregar", bttBtninsert_Jsonclick, 5, "Agregar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWOrdenPedido.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 col-sm-pull-5", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavPedcod_Internalname, "Ped Cod", "col-sm-3 FilterSearchAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'" + sGXsfl_53_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavPedcod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14PedCod), 8, 0, ",", "")), ((edtavPedcod_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV14PedCod), "ZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV14PedCod), "ZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,18);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPedcod_Jsonclick, 0, "FilterSearchAttribute", "", "", "", "", 1, edtavPedcod_Enabled, 0, "number", "1", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WWOrdenPedido.htm");
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
            GxWebStd.gx_div_start( context, divOrderbycontainer_Internalname, 1, 0, "px", 0, "px", divOrderbycontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblorderby_Internalname, lblLblorderby_Caption, "", "", lblLblorderby_Jsonclick, "'"+""+"'"+",false,"+"'"+"e121x1_client"+"'", "", "WWAdvancedLabel WWOrderByLabel", 7, "", 1, 1, 1, "HLP_WWOrdenPedido.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divOrderbycontainer2_Internalname, 1, 0, "px", 0, "px", "OrdersTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-lg-6 OrdersCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblOrderby1_Internalname, "PedCod", "", "", lblOrderby1_Jsonclick, "'"+""+"'"+",false,"+"'"+"EORDERBY1.CLICK."+"'", "", lblOrderby1_Class, 5, "", 1, 1, 0, "HLP_WWOrdenPedido.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-lg-6 OrdersCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblOrderby2_Internalname, "Descripcion", "", "", lblOrderby2_Jsonclick, "'"+""+"'"+",false,"+"'"+"EORDERBY2.CLICK."+"'", "", lblOrderby2_Class, 5, "", 1, 1, 0, "HLP_WWOrdenPedido.htm");
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
            GxWebStd.gx_div_start( context, divPeddescripcionfiltercontainer_Internalname, 1, 0, "px", 0, "px", divPeddescripcionfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblpeddescripcionfilter_Internalname, lblLblpeddescripcionfilter_Caption, "", "", lblLblpeddescripcionfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e131x1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_WWOrdenPedido.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 ViewAdvancedBarCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavPeddescripcion_Internalname, "Ped Descripcion", "col-sm-3 FilterComboAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'" + sGXsfl_53_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavPeddescripcion_Internalname, StringUtil.RTrim( AV15PedDescripcion), StringUtil.RTrim( context.localUtil.Format( AV15PedDescripcion, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPeddescripcion_Jsonclick, 0, "FilterComboAttribute", "", "", "", "", edtavPeddescripcion_Visible, edtavPeddescripcion_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWOrdenPedido.htm");
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"53\">") ;
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Emp ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Empresa") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Codigo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Descripcion") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Registro") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Estado") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Nro") ;
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
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A39PedCod), 8, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A204PedDescripcion));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtPedDescripcion_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A205PedFchReg, "99/99/9999"));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A206PedEst));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A207PedUltNro), 8, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV16Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV17Delete));
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
         if ( wbEnd == 53 )
         {
            wbEnd = 0;
            nRC_GXsfl_53 = (short)(nGXsfl_53_idx-1);
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
         if ( wbEnd == 53 )
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

      protected void START1X2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "Orden Pedidoes", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1X0( ) ;
      }

      protected void WS1X2( )
      {
         START1X2( ) ;
         EVT1X2( ) ;
      }

      protected void EVT1X2( )
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
                           E141X2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ORDERBY1.CLICK") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E151X2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ORDERBY2.CLICK") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E161X2 ();
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
                           nGXsfl_53_idx = (short)(NumberUtil.Val( sEvtType, "."));
                           sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_53_idx), 4, 0)), 4, "0");
                           SubsflControlProps_532( ) ;
                           A1EmpID = (short)(context.localUtil.CToN( cgiGet( edtEmpID_Internalname), ",", "."));
                           A44empdsc = StringUtil.Upper( cgiGet( edtempdsc_Internalname));
                           n44empdsc = false;
                           A39PedCod = (int)(context.localUtil.CToN( cgiGet( edtPedCod_Internalname), ",", "."));
                           A204PedDescripcion = cgiGet( edtPedDescripcion_Internalname);
                           n204PedDescripcion = false;
                           A205PedFchReg = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtPedFchReg_Internalname), 0));
                           n205PedFchReg = false;
                           A206PedEst = cgiGet( edtPedEst_Internalname);
                           n206PedEst = false;
                           A207PedUltNro = (int)(context.localUtil.CToN( cgiGet( edtPedUltNro_Internalname), ",", "."));
                           n207PedUltNro = false;
                           AV16Update = cgiGet( edtavUpdate_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV16Update)) ? AV22Update_GXI : context.convertURL( context.PathToRelativeUrl( AV16Update))), !bGXsfl_53_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV16Update), true);
                           AV17Delete = cgiGet( edtavDelete_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV17Delete)) ? AV23Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV17Delete))), !bGXsfl_53_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV17Delete), true);
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E171X2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E181X2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E191X2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    Rfr0gs = false;
                                    /* Set Refresh If Pedcod Changed */
                                    if ( ( context.localUtil.CToN( cgiGet( "GXH_vPEDCOD"), ",", ".") != Convert.ToDecimal( AV14PedCod )) )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Peddescripcion Changed */
                                    if ( StringUtil.StrCmp(cgiGet( "GXH_vPEDDESCRIPCION"), AV15PedDescripcion) != 0 )
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

      protected void WE1X2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm1X2( ) ;
            }
         }
      }

      protected void PA1X2( )
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
               GX_FocusControl = edtavPedcod_Internalname;
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
         SubsflControlProps_532( ) ;
         while ( nGXsfl_53_idx <= nRC_GXsfl_53 )
         {
            sendrow_532( ) ;
            nGXsfl_53_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_53_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_53_idx+1));
            sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_53_idx), 4, 0)), 4, "0");
            SubsflControlProps_532( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       int AV14PedCod ,
                                       String AV15PedDescripcion ,
                                       short AV13OrderedBy ,
                                       String AV18ADVANCED_LABEL_TEMPLATE ,
                                       String AV21Pgmname ,
                                       String AV16Update ,
                                       String AV17Delete )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF1X2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_EMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "EMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_PEDCOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A39PedCod), "ZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "PEDCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(A39PedCod), 8, 0, ".", "")));
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
         RF1X2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV21Pgmname = "WWOrdenPedido";
         context.Gx_err = 0;
      }

      protected void RF1X2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 53;
         /* Execute user event: Refresh */
         E181X2 ();
         nGXsfl_53_idx = 1;
         sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_53_idx), 4, 0)), 4, "0");
         SubsflControlProps_532( ) ;
         bGXsfl_53_Refreshing = true;
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
            SubsflControlProps_532( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV14PedCod ,
                                                 AV15PedDescripcion ,
                                                 A39PedCod ,
                                                 A204PedDescripcion ,
                                                 AV13OrderedBy } ,
                                                 new int[]{
                                                 TypeConstants.INT, TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT
                                                 }
            } ) ;
            lV15PedDescripcion = StringUtil.PadR( StringUtil.RTrim( AV15PedDescripcion), 50, "%");
            /* Using cursor H001X2 */
            pr_default.execute(0, new Object[] {AV14PedCod, lV15PedDescripcion, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_53_idx = 1;
            sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_53_idx), 4, 0)), 4, "0");
            SubsflControlProps_532( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A207PedUltNro = H001X2_A207PedUltNro[0];
               n207PedUltNro = H001X2_n207PedUltNro[0];
               A206PedEst = H001X2_A206PedEst[0];
               n206PedEst = H001X2_n206PedEst[0];
               A205PedFchReg = H001X2_A205PedFchReg[0];
               n205PedFchReg = H001X2_n205PedFchReg[0];
               A204PedDescripcion = H001X2_A204PedDescripcion[0];
               n204PedDescripcion = H001X2_n204PedDescripcion[0];
               A39PedCod = H001X2_A39PedCod[0];
               A44empdsc = H001X2_A44empdsc[0];
               n44empdsc = H001X2_n44empdsc[0];
               A1EmpID = H001X2_A1EmpID[0];
               A44empdsc = H001X2_A44empdsc[0];
               n44empdsc = H001X2_n44empdsc[0];
               E191X2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 53;
            WB1X0( ) ;
         }
         bGXsfl_53_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes1X2( )
      {
         GxWebStd.gx_hidden_field( context, "vADVANCED_LABEL_TEMPLATE", StringUtil.RTrim( AV18ADVANCED_LABEL_TEMPLATE));
         GxWebStd.gx_hidden_field( context, "gxhash_vADVANCED_LABEL_TEMPLATE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV18ADVANCED_LABEL_TEMPLATE, "")), context));
         GxWebStd.gx_hidden_field( context, "gxhash_EMPID"+"_"+sGXsfl_53_idx, GetSecureSignedToken( sGXsfl_53_idx, context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_PEDCOD"+"_"+sGXsfl_53_idx, GetSecureSignedToken( sGXsfl_53_idx, context.localUtil.Format( (decimal)(A39PedCod), "ZZZZZZZ9"), context));
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
                                              AV14PedCod ,
                                              AV15PedDescripcion ,
                                              A39PedCod ,
                                              A204PedDescripcion ,
                                              AV13OrderedBy } ,
                                              new int[]{
                                              TypeConstants.INT, TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT
                                              }
         } ) ;
         lV15PedDescripcion = StringUtil.PadR( StringUtil.RTrim( AV15PedDescripcion), 50, "%");
         /* Using cursor H001X3 */
         pr_default.execute(1, new Object[] {AV14PedCod, lV15PedDescripcion});
         GRID_nRecordCount = H001X3_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV14PedCod, AV15PedDescripcion, AV13OrderedBy, AV18ADVANCED_LABEL_TEMPLATE, AV21Pgmname, AV16Update, AV17Delete) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV14PedCod, AV15PedDescripcion, AV13OrderedBy, AV18ADVANCED_LABEL_TEMPLATE, AV21Pgmname, AV16Update, AV17Delete) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV14PedCod, AV15PedDescripcion, AV13OrderedBy, AV18ADVANCED_LABEL_TEMPLATE, AV21Pgmname, AV16Update, AV17Delete) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV14PedCod, AV15PedDescripcion, AV13OrderedBy, AV18ADVANCED_LABEL_TEMPLATE, AV21Pgmname, AV16Update, AV17Delete) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV14PedCod, AV15PedDescripcion, AV13OrderedBy, AV18ADVANCED_LABEL_TEMPLATE, AV21Pgmname, AV16Update, AV17Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP1X0( )
      {
         /* Before Start, stand alone formulas. */
         AV21Pgmname = "WWOrdenPedido";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E171X2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavPedcod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavPedcod_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vPEDCOD");
               GX_FocusControl = edtavPedcod_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV14PedCod = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14PedCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14PedCod), 8, 0)));
            }
            else
            {
               AV14PedCod = (int)(context.localUtil.CToN( cgiGet( edtavPedcod_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14PedCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14PedCod), 8, 0)));
            }
            AV15PedDescripcion = cgiGet( edtavPeddescripcion_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15PedDescripcion", AV15PedDescripcion);
            /* Read saved values. */
            nRC_GXsfl_53 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_53"), ",", "."));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID_nFirstRecordOnPage"), ",", "."));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID_nEOF"), ",", "."));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ",", "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vPEDCOD"), ",", ".") != Convert.ToDecimal( AV14PedCod )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vPEDDESCRIPCION"), AV15PedDescripcion) != 0 )
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
         E171X2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E171X2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV21Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV21Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         subGrid_Rows = 10;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         AV16Update = context.GetImagePath( "984dbb7e-3105-4d21-aee3-84a29ade1d38", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV16Update)) ? AV22Update_GXI : context.convertURL( context.PathToRelativeUrl( AV16Update))), !bGXsfl_53_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV16Update), true);
         AV22Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "984dbb7e-3105-4d21-aee3-84a29ade1d38", "", context.GetTheme( )));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV16Update)) ? AV22Update_GXI : context.convertURL( context.PathToRelativeUrl( AV16Update))), !bGXsfl_53_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV16Update), true);
         edtavUpdate_Tooltiptext = "Modificar";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext, !bGXsfl_53_Refreshing);
         AV17Delete = context.GetImagePath( "67c03cc7-261d-4b2f-aa3f-5825ef4786ff", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV17Delete)) ? AV23Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV17Delete))), !bGXsfl_53_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV17Delete), true);
         AV23Delete_GXI = GXDbFile.PathToUrl( context.GetImagePath( "67c03cc7-261d-4b2f-aa3f-5825ef4786ff", "", context.GetTheme( )));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV17Delete)) ? AV23Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV17Delete))), !bGXsfl_53_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV17Delete), true);
         edtavDelete_Tooltiptext = "Eliminar";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext, !bGXsfl_53_Refreshing);
         AV13OrderedBy = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
         edtavPeddescripcion_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPeddescripcion_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPeddescripcion_Visible), 5, 0)), true);
         Form.Caption = "Orden Pedidoes";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         AV18ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ADVANCED_LABEL_TEMPLATE", AV18ADVANCED_LABEL_TEMPLATE);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vADVANCED_LABEL_TEMPLATE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV18ADVANCED_LABEL_TEMPLATE, "")), context));
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

      protected void E151X2( )
      {
         /* Orderby1_Click Routine */
         AV13OrderedBy = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
         lblOrderby1_Class = "WWOrderItem"+" "+"WWOrderItemSelected";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblOrderby1_Internalname, "Class", lblOrderby1_Class, true);
         lblOrderby2_Class = "WWOrderItem";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblOrderby2_Internalname, "Class", lblOrderby2_Class, true);
         gxgrGrid_refresh( subGrid_Rows, AV14PedCod, AV15PedDescripcion, AV13OrderedBy, AV18ADVANCED_LABEL_TEMPLATE, AV21Pgmname, AV16Update, AV17Delete) ;
         /*  Sending Event outputs  */
      }

      protected void E161X2( )
      {
         /* Orderby2_Click Routine */
         AV13OrderedBy = 2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
         lblOrderby1_Class = "WWOrderItem";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblOrderby1_Internalname, "Class", lblOrderby1_Class, true);
         lblOrderby2_Class = "WWOrderItem"+" "+"WWOrderItemSelected";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblOrderby2_Internalname, "Class", lblOrderby2_Class, true);
         gxgrGrid_refresh( subGrid_Rows, AV14PedCod, AV15PedDescripcion, AV13OrderedBy, AV18ADVANCED_LABEL_TEMPLATE, AV21Pgmname, AV16Update, AV17Delete) ;
         /*  Sending Event outputs  */
      }

      protected void E181X2( )
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
         if ( AV13OrderedBy == 1 )
         {
            lblLblorderby_Caption = StringUtil.Format( AV18ADVANCED_LABEL_TEMPLATE, "Ordered By", "PedCod", "", "", "", "", "", "", "");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblLblorderby_Internalname, "Caption", lblLblorderby_Caption, true);
         }
         else if ( AV13OrderedBy == 2 )
         {
            lblLblorderby_Caption = StringUtil.Format( AV18ADVANCED_LABEL_TEMPLATE, "Ordered By", "Descripcion", "", "", "", "", "", "", "");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblLblorderby_Internalname, "Caption", lblLblorderby_Caption, true);
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV15PedDescripcion)) )
         {
            lblLblpeddescripcionfilter_Caption = "Descripcion";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblLblpeddescripcionfilter_Internalname, "Caption", lblLblpeddescripcionfilter_Caption, true);
         }
         else
         {
            lblLblpeddescripcionfilter_Caption = StringUtil.Format( AV18ADVANCED_LABEL_TEMPLATE, "Descripcion", AV15PedDescripcion, "", "", "", "", "", "", "");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblLblpeddescripcionfilter_Internalname, "Caption", lblLblpeddescripcionfilter_Caption, true);
         }
         /*  Sending Event outputs  */
      }

      private void E191X2( )
      {
         /* Grid_Load Routine */
         edtavUpdate_Link = formatLink("ordenpedido.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A1EmpID) + "," + UrlEncode("" +A39PedCod);
         edtavDelete_Link = formatLink("ordenpedido.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A1EmpID) + "," + UrlEncode("" +A39PedCod);
         edtPedDescripcion_Link = formatLink("viewordenpedido.aspx") + "?" + UrlEncode("" +A1EmpID) + "," + UrlEncode("" +A39PedCod) + "," + UrlEncode(StringUtil.RTrim(""));
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 53;
         }
         sendrow_532( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_53_Refreshing )
         {
            context.DoAjaxLoad(53, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void E141X2( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("ordenpedido.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV7HTTPRequest.Method, "GET") == 0 )
         {
            AV8GridState.FromXml(AV6Session.Get(AV21Pgmname+"GridState"), null, "GridState", "KBCalpesa22");
            if ( AV8GridState.gxTpr_Orderedby != 0 )
            {
               AV13OrderedBy = AV8GridState.gxTpr_Orderedby;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            }
            if ( AV8GridState.gxTpr_Filtervalues.Count >= 2 )
            {
               AV14PedCod = (int)(NumberUtil.Val( ((SdtGridState_FilterValue)AV8GridState.gxTpr_Filtervalues.Item(1)).gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14PedCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14PedCod), 8, 0)));
               AV15PedDescripcion = ((SdtGridState_FilterValue)AV8GridState.gxTpr_Filtervalues.Item(2)).gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15PedDescripcion", AV15PedDescripcion);
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
         AV8GridState.FromXml(AV6Session.Get(AV21Pgmname+"GridState"), null, "GridState", "KBCalpesa22");
         AV8GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         AV8GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV8GridState.gxTpr_Filtervalues.Clear();
         AV9GridStateFilterValue = new SdtGridState_FilterValue(context);
         AV9GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV14PedCod), 8, 0);
         AV8GridState.gxTpr_Filtervalues.Add(AV9GridStateFilterValue, 0);
         AV9GridStateFilterValue = new SdtGridState_FilterValue(context);
         AV9GridStateFilterValue.gxTpr_Value = AV15PedDescripcion;
         AV8GridState.gxTpr_Filtervalues.Add(AV9GridStateFilterValue, 0);
         AV6Session.Set(AV21Pgmname+"GridState", AV8GridState.ToXml(false, true, "GridState", "KBCalpesa22"));
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV11TrnContext = new SdtTransactionContext(context);
         AV11TrnContext.gxTpr_Callerobject = AV21Pgmname;
         AV11TrnContext.gxTpr_Callerondelete = true;
         AV11TrnContext.gxTpr_Callerurl = AV7HTTPRequest.ScriptName+"?"+AV7HTTPRequest.QueryString;
         AV11TrnContext.gxTpr_Transactionname = "OrdenPedido";
         AV6Session.Set("TrnContext", AV11TrnContext.ToXml(false, true, "TransactionContext", "KBCalpesa22"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
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
         PA1X2( ) ;
         WS1X2( ) ;
         WE1X2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022102620151591", true);
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
         context.AddJavascriptSource("wwordenpedido.js", "?2022102620151591", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_532( )
      {
         edtEmpID_Internalname = "EMPID_"+sGXsfl_53_idx;
         edtempdsc_Internalname = "EMPDSC_"+sGXsfl_53_idx;
         edtPedCod_Internalname = "PEDCOD_"+sGXsfl_53_idx;
         edtPedDescripcion_Internalname = "PEDDESCRIPCION_"+sGXsfl_53_idx;
         edtPedFchReg_Internalname = "PEDFCHREG_"+sGXsfl_53_idx;
         edtPedEst_Internalname = "PEDEST_"+sGXsfl_53_idx;
         edtPedUltNro_Internalname = "PEDULTNRO_"+sGXsfl_53_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_53_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_53_idx;
      }

      protected void SubsflControlProps_fel_532( )
      {
         edtEmpID_Internalname = "EMPID_"+sGXsfl_53_fel_idx;
         edtempdsc_Internalname = "EMPDSC_"+sGXsfl_53_fel_idx;
         edtPedCod_Internalname = "PEDCOD_"+sGXsfl_53_fel_idx;
         edtPedDescripcion_Internalname = "PEDDESCRIPCION_"+sGXsfl_53_fel_idx;
         edtPedFchReg_Internalname = "PEDFCHREG_"+sGXsfl_53_fel_idx;
         edtPedEst_Internalname = "PEDEST_"+sGXsfl_53_fel_idx;
         edtPedUltNro_Internalname = "PEDULTNRO_"+sGXsfl_53_fel_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_53_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_53_fel_idx;
      }

      protected void sendrow_532( )
      {
         SubsflControlProps_532( ) ;
         WB1X0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_53_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_53_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_53_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEmpID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEmpID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)53,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempdsc_Internalname,(String)A44empdsc,StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtempdsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)53,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPedCod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A39PedCod), 8, 0, ",", "")),context.localUtil.Format( (decimal)(A39PedCod), "ZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPedCod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)53,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPedDescripcion_Internalname,StringUtil.RTrim( A204PedDescripcion),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtPedDescripcion_Link,(String)"",(String)"",(String)"",(String)edtPedDescripcion_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)53,(short)1,(short)-1,(short)-1,(bool)true,(String)"Descripcion",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPedFchReg_Internalname,context.localUtil.Format(A205PedFchReg, "99/99/9999"),context.localUtil.Format( A205PedFchReg, "99/99/9999"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPedFchReg_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)53,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPedEst_Internalname,StringUtil.RTrim( A206PedEst),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPedEst_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)1,(short)0,(short)0,(short)53,(short)1,(short)-1,(short)-1,(bool)true,(String)"estado",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPedUltNro_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A207PedUltNro), 8, 0, ",", "")),context.localUtil.Format( (decimal)(A207PedUltNro), "ZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPedUltNro_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)53,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ImageAttribute";
            StyleString = "";
            AV16Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV16Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV22Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV16Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV16Update)) ? AV22Update_GXI : context.PathToRelativeUrl( AV16Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV16Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ImageAttribute";
            StyleString = "";
            AV17Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV17Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV23Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV17Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV17Delete)) ? AV23Delete_GXI : context.PathToRelativeUrl( AV17Delete));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)edtavDelete_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV17Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            send_integrity_lvl_hashes1X2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_53_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_53_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_53_idx+1));
            sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_53_idx), 4, 0)), 4, "0");
            SubsflControlProps_532( ) ;
         }
         /* End function sendrow_532 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtntoggle_Internalname = "BTNTOGGLE";
         lblTitletext_Internalname = "TITLETEXT";
         bttBtninsert_Internalname = "BTNINSERT";
         edtavPedcod_Internalname = "vPEDCOD";
         divTabletop_Internalname = "TABLETOP";
         lblLblorderby_Internalname = "LBLORDERBY";
         lblOrderby1_Internalname = "ORDERBY1";
         lblOrderby2_Internalname = "ORDERBY2";
         divOrderbycontainer2_Internalname = "ORDERBYCONTAINER2";
         divOrderbycontainer_Internalname = "ORDERBYCONTAINER";
         lblLblpeddescripcionfilter_Internalname = "LBLPEDDESCRIPCIONFILTER";
         edtavPeddescripcion_Internalname = "vPEDDESCRIPCION";
         divPeddescripcionfiltercontainer_Internalname = "PEDDESCRIPCIONFILTERCONTAINER";
         divFilterscontainer_Internalname = "FILTERSCONTAINER";
         edtEmpID_Internalname = "EMPID";
         edtempdsc_Internalname = "EMPDSC";
         edtPedCod_Internalname = "PEDCOD";
         edtPedDescripcion_Internalname = "PEDDESCRIPCION";
         edtPedFchReg_Internalname = "PEDFCHREG";
         edtPedEst_Internalname = "PEDEST";
         edtPedUltNro_Internalname = "PEDULTNRO";
         edtavUpdate_Internalname = "vUPDATE";
         edtavDelete_Internalname = "vDELETE";
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
         edtPedUltNro_Jsonclick = "";
         edtPedEst_Jsonclick = "";
         edtPedFchReg_Jsonclick = "";
         edtPedDescripcion_Jsonclick = "";
         edtPedCod_Jsonclick = "";
         edtempdsc_Jsonclick = "";
         edtEmpID_Jsonclick = "";
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavDelete_Link = "";
         edtavUpdate_Link = "";
         edtPedDescripcion_Link = "";
         subGrid_Header = "";
         subGrid_Class = "WorkWith";
         subGrid_Backcolorstyle = 0;
         divGridcell_Class = "col-xs-12 col-sm-9 col-md-10 WWGridCell";
         edtavPeddescripcion_Jsonclick = "";
         edtavPeddescripcion_Enabled = 1;
         edtavPeddescripcion_Visible = 1;
         lblLblpeddescripcionfilter_Caption = "Descripcion";
         lblOrderby2_Class = "WWOrderItem";
         lblOrderby1_Class = "WWOrderItem WWOrderItemSelected";
         lblLblorderby_Caption = "Ordered By";
         edtavPedcod_Jsonclick = "";
         edtavPedcod_Enabled = 1;
         bttBtntoggle_Class = "HideFiltersButton";
         bttBtntoggle_Caption = "Hide Filters";
         divPeddescripcionfiltercontainer_Class = "AdvancedContainerItem";
         divOrderbycontainer_Class = "AdvancedContainerItem";
         divFilterscontainer_Class = "AdvancedContainerVisible";
         Form.Caption = "Orden Pedidoes";
         subGrid_Rows = 10;
         edtavDelete_Tooltiptext = "Eliminar";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV16Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV17Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15PedDescripcion',fld:'vPEDDESCRIPCION',pic:''},{av:'AV21Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14PedCod',fld:'vPEDCOD',pic:'ZZZZZZZ9'},{av:'AV18ADVANCED_LABEL_TEMPLATE',fld:'vADVANCED_LABEL_TEMPLATE',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[{av:'lblLblorderby_Caption',ctrl:'LBLORDERBY',prop:'Caption'},{av:'lblLblpeddescripcionfilter_Caption',ctrl:'LBLPEDDESCRIPCIONFILTER',prop:'Caption'}]}");
         setEventMetadata("'TOGGLE'","{handler:'E111X1',iparms:[{av:'divFilterscontainer_Class',ctrl:'FILTERSCONTAINER',prop:'Class'}]");
         setEventMetadata("'TOGGLE'",",oparms:[{av:'divFilterscontainer_Class',ctrl:'FILTERSCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Caption'},{av:'divGridcell_Class',ctrl:'GRIDCELL',prop:'Class'}]}");
         setEventMetadata("LBLORDERBY.CLICK","{handler:'E121X1',iparms:[{av:'divOrderbycontainer_Class',ctrl:'ORDERBYCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLORDERBY.CLICK",",oparms:[{av:'divOrderbycontainer_Class',ctrl:'ORDERBYCONTAINER',prop:'Class'}]}");
         setEventMetadata("ORDERBY1.CLICK","{handler:'E151X2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14PedCod',fld:'vPEDCOD',pic:'ZZZZZZZ9'},{av:'AV15PedDescripcion',fld:'vPEDDESCRIPCION',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV18ADVANCED_LABEL_TEMPLATE',fld:'vADVANCED_LABEL_TEMPLATE',pic:'',hsh:true},{av:'AV21Pgmname',fld:'vPGMNAME',pic:''},{av:'AV16Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV17Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'}]");
         setEventMetadata("ORDERBY1.CLICK",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'lblOrderby1_Class',ctrl:'ORDERBY1',prop:'Class'},{av:'lblOrderby2_Class',ctrl:'ORDERBY2',prop:'Class'},{av:'lblLblorderby_Caption',ctrl:'LBLORDERBY',prop:'Caption'},{av:'lblLblpeddescripcionfilter_Caption',ctrl:'LBLPEDDESCRIPCIONFILTER',prop:'Caption'}]}");
         setEventMetadata("ORDERBY2.CLICK","{handler:'E161X2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14PedCod',fld:'vPEDCOD',pic:'ZZZZZZZ9'},{av:'AV15PedDescripcion',fld:'vPEDDESCRIPCION',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV18ADVANCED_LABEL_TEMPLATE',fld:'vADVANCED_LABEL_TEMPLATE',pic:'',hsh:true},{av:'AV21Pgmname',fld:'vPGMNAME',pic:''},{av:'AV16Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV17Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'}]");
         setEventMetadata("ORDERBY2.CLICK",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'lblOrderby1_Class',ctrl:'ORDERBY1',prop:'Class'},{av:'lblOrderby2_Class',ctrl:'ORDERBY2',prop:'Class'},{av:'lblLblorderby_Caption',ctrl:'LBLORDERBY',prop:'Caption'},{av:'lblLblpeddescripcionfilter_Caption',ctrl:'LBLPEDDESCRIPCIONFILTER',prop:'Caption'}]}");
         setEventMetadata("LBLPEDDESCRIPCIONFILTER.CLICK","{handler:'E131X1',iparms:[{av:'divPeddescripcionfiltercontainer_Class',ctrl:'PEDDESCRIPCIONFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLPEDDESCRIPCIONFILTER.CLICK",",oparms:[{av:'divPeddescripcionfiltercontainer_Class',ctrl:'PEDDESCRIPCIONFILTERCONTAINER',prop:'Class'},{av:'edtavPeddescripcion_Visible',ctrl:'vPEDDESCRIPCION',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E191X2',iparms:[{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9',hsh:true},{av:'A39PedCod',fld:'PEDCOD',pic:'ZZZZZZZ9',hsh:true}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'},{av:'edtPedDescripcion_Link',ctrl:'PEDDESCRIPCION',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E141X2',iparms:[{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9',hsh:true},{av:'A39PedCod',fld:'PEDCOD',pic:'ZZZZZZZ9',hsh:true}]");
         setEventMetadata("'DOINSERT'",",oparms:[]}");
         setEventMetadata("GRID_FIRSTPAGE","{handler:'subgrid_firstpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV16Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV17Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV18ADVANCED_LABEL_TEMPLATE',fld:'vADVANCED_LABEL_TEMPLATE',pic:'',hsh:true},{av:'AV15PedDescripcion',fld:'vPEDDESCRIPCION',pic:''},{av:'AV21Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14PedCod',fld:'vPEDCOD',pic:'ZZZZZZZ9'}]");
         setEventMetadata("GRID_FIRSTPAGE",",oparms:[{av:'lblLblorderby_Caption',ctrl:'LBLORDERBY',prop:'Caption'},{av:'lblLblpeddescripcionfilter_Caption',ctrl:'LBLPEDDESCRIPCIONFILTER',prop:'Caption'}]}");
         setEventMetadata("GRID_PREVPAGE","{handler:'subgrid_previouspage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV16Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV17Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV18ADVANCED_LABEL_TEMPLATE',fld:'vADVANCED_LABEL_TEMPLATE',pic:'',hsh:true},{av:'AV15PedDescripcion',fld:'vPEDDESCRIPCION',pic:''},{av:'AV21Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14PedCod',fld:'vPEDCOD',pic:'ZZZZZZZ9'}]");
         setEventMetadata("GRID_PREVPAGE",",oparms:[{av:'lblLblorderby_Caption',ctrl:'LBLORDERBY',prop:'Caption'},{av:'lblLblpeddescripcionfilter_Caption',ctrl:'LBLPEDDESCRIPCIONFILTER',prop:'Caption'}]}");
         setEventMetadata("GRID_NEXTPAGE","{handler:'subgrid_nextpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV16Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV17Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV18ADVANCED_LABEL_TEMPLATE',fld:'vADVANCED_LABEL_TEMPLATE',pic:'',hsh:true},{av:'AV15PedDescripcion',fld:'vPEDDESCRIPCION',pic:''},{av:'AV21Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14PedCod',fld:'vPEDCOD',pic:'ZZZZZZZ9'}]");
         setEventMetadata("GRID_NEXTPAGE",",oparms:[{av:'lblLblorderby_Caption',ctrl:'LBLORDERBY',prop:'Caption'},{av:'lblLblpeddescripcionfilter_Caption',ctrl:'LBLPEDDESCRIPCIONFILTER',prop:'Caption'}]}");
         setEventMetadata("GRID_LASTPAGE","{handler:'subgrid_lastpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV16Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV17Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV18ADVANCED_LABEL_TEMPLATE',fld:'vADVANCED_LABEL_TEMPLATE',pic:'',hsh:true},{av:'AV15PedDescripcion',fld:'vPEDDESCRIPCION',pic:''},{av:'AV21Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14PedCod',fld:'vPEDCOD',pic:'ZZZZZZZ9'}]");
         setEventMetadata("GRID_LASTPAGE",",oparms:[{av:'lblLblorderby_Caption',ctrl:'LBLORDERBY',prop:'Caption'},{av:'lblLblpeddescripcionfilter_Caption',ctrl:'LBLPEDDESCRIPCIONFILTER',prop:'Caption'}]}");
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
         AV16Update = "";
         AV17Delete = "";
         AV15PedDescripcion = "";
         AV18ADVANCED_LABEL_TEMPLATE = "";
         AV21Pgmname = "";
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
         lblLblorderby_Jsonclick = "";
         lblOrderby1_Jsonclick = "";
         lblOrderby2_Jsonclick = "";
         lblLblpeddescripcionfilter_Jsonclick = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         A44empdsc = "";
         A204PedDescripcion = "";
         A205PedFchReg = DateTime.MinValue;
         A206PedEst = "";
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV22Update_GXI = "";
         AV23Delete_GXI = "";
         scmdbuf = "";
         lV15PedDescripcion = "";
         H001X2_A207PedUltNro = new int[1] ;
         H001X2_n207PedUltNro = new bool[] {false} ;
         H001X2_A206PedEst = new String[] {""} ;
         H001X2_n206PedEst = new bool[] {false} ;
         H001X2_A205PedFchReg = new DateTime[] {DateTime.MinValue} ;
         H001X2_n205PedFchReg = new bool[] {false} ;
         H001X2_A204PedDescripcion = new String[] {""} ;
         H001X2_n204PedDescripcion = new bool[] {false} ;
         H001X2_A39PedCod = new int[1] ;
         H001X2_A44empdsc = new String[] {""} ;
         H001X2_n44empdsc = new bool[] {false} ;
         H001X2_A1EmpID = new short[1] ;
         H001X3_AGRID_nRecordCount = new long[1] ;
         GridRow = new GXWebRow();
         AV7HTTPRequest = new GxHttpRequest( context);
         AV8GridState = new SdtGridState(context);
         AV6Session = context.GetSession();
         AV9GridStateFilterValue = new SdtGridState_FilterValue(context);
         AV11TrnContext = new SdtTransactionContext(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         sImgUrl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwordenpedido__default(),
            new Object[][] {
                new Object[] {
               H001X2_A207PedUltNro, H001X2_n207PedUltNro, H001X2_A206PedEst, H001X2_n206PedEst, H001X2_A205PedFchReg, H001X2_n205PedFchReg, H001X2_A204PedDescripcion, H001X2_n204PedDescripcion, H001X2_A39PedCod, H001X2_A44empdsc,
               H001X2_n44empdsc, H001X2_A1EmpID
               }
               , new Object[] {
               H001X3_AGRID_nRecordCount
               }
            }
         );
         AV21Pgmname = "WWOrdenPedido";
         /* GeneXus formulas. */
         AV21Pgmname = "WWOrdenPedido";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_53 ;
      private short nGXsfl_53_idx=1 ;
      private short GRID_nEOF ;
      private short AV13OrderedBy ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short A1EmpID ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid_Backstyle ;
      private int subGrid_Rows ;
      private int AV14PedCod ;
      private int edtavPedcod_Enabled ;
      private int edtavPeddescripcion_Visible ;
      private int edtavPeddescripcion_Enabled ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int A39PedCod ;
      private int A207PedUltNro ;
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
      private String edtavUpdate_Tooltiptext ;
      private String edtavDelete_Tooltiptext ;
      private String divFilterscontainer_Class ;
      private String divOrderbycontainer_Class ;
      private String divPeddescripcionfiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_53_idx="0001" ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String AV15PedDescripcion ;
      private String AV18ADVANCED_LABEL_TEMPLATE ;
      private String AV21Pgmname ;
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
      private String edtavPedcod_Internalname ;
      private String edtavPedcod_Jsonclick ;
      private String divFilterscontainer_Internalname ;
      private String divOrderbycontainer_Internalname ;
      private String lblLblorderby_Internalname ;
      private String lblLblorderby_Caption ;
      private String lblLblorderby_Jsonclick ;
      private String divOrderbycontainer2_Internalname ;
      private String lblOrderby1_Internalname ;
      private String lblOrderby1_Jsonclick ;
      private String lblOrderby1_Class ;
      private String lblOrderby2_Internalname ;
      private String lblOrderby2_Jsonclick ;
      private String lblOrderby2_Class ;
      private String divPeddescripcionfiltercontainer_Internalname ;
      private String lblLblpeddescripcionfilter_Internalname ;
      private String lblLblpeddescripcionfilter_Caption ;
      private String lblLblpeddescripcionfilter_Jsonclick ;
      private String edtavPeddescripcion_Internalname ;
      private String edtavPeddescripcion_Jsonclick ;
      private String divGridcell_Internalname ;
      private String divGridcell_Class ;
      private String divGridtable_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String subGrid_Header ;
      private String A204PedDescripcion ;
      private String edtPedDescripcion_Link ;
      private String A206PedEst ;
      private String edtavUpdate_Link ;
      private String edtavDelete_Link ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtEmpID_Internalname ;
      private String edtempdsc_Internalname ;
      private String edtPedCod_Internalname ;
      private String edtPedDescripcion_Internalname ;
      private String edtPedFchReg_Internalname ;
      private String edtPedEst_Internalname ;
      private String edtPedUltNro_Internalname ;
      private String scmdbuf ;
      private String lV15PedDescripcion ;
      private String sGXsfl_53_fel_idx="0001" ;
      private String ROClassString ;
      private String edtEmpID_Jsonclick ;
      private String edtempdsc_Jsonclick ;
      private String edtPedCod_Jsonclick ;
      private String edtPedDescripcion_Jsonclick ;
      private String edtPedFchReg_Jsonclick ;
      private String edtPedEst_Jsonclick ;
      private String edtPedUltNro_Jsonclick ;
      private String sImgUrl ;
      private DateTime A205PedFchReg ;
      private bool entryPointCalled ;
      private bool bGXsfl_53_Refreshing=false ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n44empdsc ;
      private bool n204PedDescripcion ;
      private bool n205PedFchReg ;
      private bool n206PedEst ;
      private bool n207PedUltNro ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV16Update_IsBlob ;
      private bool AV17Delete_IsBlob ;
      private String A44empdsc ;
      private String AV22Update_GXI ;
      private String AV23Delete_GXI ;
      private String AV16Update ;
      private String AV17Delete ;
      private IGxSession AV6Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] H001X2_A207PedUltNro ;
      private bool[] H001X2_n207PedUltNro ;
      private String[] H001X2_A206PedEst ;
      private bool[] H001X2_n206PedEst ;
      private DateTime[] H001X2_A205PedFchReg ;
      private bool[] H001X2_n205PedFchReg ;
      private String[] H001X2_A204PedDescripcion ;
      private bool[] H001X2_n204PedDescripcion ;
      private int[] H001X2_A39PedCod ;
      private String[] H001X2_A44empdsc ;
      private bool[] H001X2_n44empdsc ;
      private short[] H001X2_A1EmpID ;
      private long[] H001X3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV7HTTPRequest ;
      private SdtGridState AV8GridState ;
      private SdtGridState_FilterValue AV9GridStateFilterValue ;
      private SdtTransactionContext AV11TrnContext ;
   }

   public class wwordenpedido__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H001X2( IGxContext context ,
                                             int AV14PedCod ,
                                             String AV15PedDescripcion ,
                                             int A39PedCod ,
                                             String A204PedDescripcion ,
                                             short AV13OrderedBy )
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
         sSelectString = " T1.[PedUltNro], T1.[PedEst], T1.[PedFchReg], T1.[PedDescripcion], T1.[PedCod], T2.[empdsc], T1.[EmpID]";
         sFromString = " FROM ([OrdenPedido] T1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID])";
         sOrderString = "";
         if ( ! (0==AV14PedCod) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedCod] = @AV14PedCod)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedCod] = @AV14PedCod)";
            }
         }
         else
         {
            GXv_int1[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV15PedDescripcion)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedDescripcion] like @lV15PedDescripcion)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedDescripcion] like @lV15PedDescripcion)";
            }
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( AV13OrderedBy == 1 )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedCod]";
         }
         else if ( AV13OrderedBy == 2 )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedDescripcion]";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY T1.[EmpID], T1.[PedCod]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H001X3( IGxContext context ,
                                             int AV14PedCod ,
                                             String AV15PedDescripcion ,
                                             int A39PedCod ,
                                             String A204PedDescripcion ,
                                             short AV13OrderedBy )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [2] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM ([OrdenPedido] T1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID])";
         if ( ! (0==AV14PedCod) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedCod] = @AV14PedCod)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedCod] = @AV14PedCod)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV15PedDescripcion)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedDescripcion] like @lV15PedDescripcion)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedDescripcion] like @lV15PedDescripcion)";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         if ( AV13OrderedBy == 1 )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( AV13OrderedBy == 2 )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( true )
         {
            scmdbuf = scmdbuf + "";
         }
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
                     return conditional_H001X2(context, (int)dynConstraints[0] , (String)dynConstraints[1] , (int)dynConstraints[2] , (String)dynConstraints[3] , (short)dynConstraints[4] );
               case 1 :
                     return conditional_H001X3(context, (int)dynConstraints[0] , (String)dynConstraints[1] , (int)dynConstraints[2] , (String)dynConstraints[3] , (short)dynConstraints[4] );
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
          Object[] prmH001X2 ;
          prmH001X2 = new Object[] {
          new Object[] {"@AV14PedCod",SqlDbType.Int,8,0} ,
          new Object[] {"@lV15PedDescripcion",SqlDbType.Char,50,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH001X3 ;
          prmH001X3 = new Object[] {
          new Object[] {"@AV14PedCod",SqlDbType.Int,8,0} ,
          new Object[] {"@lV15PedDescripcion",SqlDbType.Char,50,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001X2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001X2,11,0,true,false )
             ,new CursorDef("H001X3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001X3,1,0,true,false )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 1) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getString(4, 50) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((int[]) buf[8])[0] = rslt.getInt(5) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((short[]) buf[11])[0] = rslt.getShort(7) ;
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
                   stmt.SetParameter(sIdx, (int)parms[5]);
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
                   stmt.SetParameter(sIdx, (int)parms[2]);
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
