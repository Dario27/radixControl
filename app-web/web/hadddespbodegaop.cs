/*
               File: HAddDespBodegaOP
        Description: HAdd Desp Bodega OP
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/19/2023 22:34:24.35
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
   public class hadddespbodegaop : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public hadddespbodegaop( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public hadddespbodegaop( IGxContext context )
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
                           String aP2_usuCod )
      {
         this.AV9empID = aP0_empID;
         this.AV10ageId = aP1_ageId;
         this.AV11usuCod = aP2_usuCod;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavOrdenmes = new GXCombobox();
         cmbavOrdenid = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid2") == 0 )
            {
               nRC_GXsfl_32 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_32_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_32_idx = GetNextPar( );
               edtavAdespachar_Enabled = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAdespachar_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAdespachar_Enabled), 5, 0)), !bGXsfl_32_Refreshing);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGrid2_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid2") == 0 )
            {
               subGrid2_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
               AV5ordenID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV9empID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV10ageId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               edtavAdespachar_Enabled = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAdespachar_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAdespachar_Enabled), 5, 0)), !bGXsfl_32_Refreshing);
               A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               A22OrdenID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid2_refresh( subGrid2_Rows, AV5ordenID, AV9empID, AV10ageId, A1EmpID, A22OrdenID) ;
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
               AV9empID = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9empID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9empID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9empID), "ZZZ9"), context));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV10ageId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ageId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10ageId), 4, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10ageId), "ZZZ9"), context));
                  AV11usuCod = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11usuCod", AV11usuCod);
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
            PA5T2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0;
               WS5T2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE5T2( ) ;
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
         context.SendWebValue( "HAdd Desp Bodega OP") ;
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
         context.AddJavascriptSource("gxcfg.js", "?202311922342446", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("hadddespbodegaop.aspx") + "?" + UrlEncode("" +AV9empID) + "," + UrlEncode("" +AV10ageId) + "," + UrlEncode(StringUtil.RTrim(AV11usuCod))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vORDENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV5ordenID), 4, 0, ",", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_32", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_32), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "EMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_EMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9empID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9empID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "ORDENANIO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A25OrdenAnio), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ORDENPERIODO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A24OrdenPeriodo), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ORDENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A22OrdenID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_ORDENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A22OrdenID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "CLIENTEDSC", StringUtil.RTrim( A57ClienteDsc));
         GxWebStd.gx_hidden_field( context, "vAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10ageId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10ageId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vUSUCOD", StringUtil.RTrim( AV11usuCod));
         GxWebStd.gx_hidden_field( context, "GRID2_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID2_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID2_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID2_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vADESPACHAR_Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavAdespachar_Enabled), 5, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm5T2( )
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
         return "HAddDespBodegaOP" ;
      }

      public override String GetPgmdesc( )
      {
         return "HAdd Desp Bodega OP" ;
      }

      protected void WB5T0( )
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
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable1_Internalname, 1, 0, "px", 0, "px", "ToolbarMain", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Generar Despacho Orden", "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_HAddDespBodegaOP.htm");
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
            GxWebStd.gx_div_start( context, divTable2_Internalname, 1, 0, "px", 0, "px", "FormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavOrdenanio_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavOrdenanio_Internalname, "Año", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'" + sGXsfl_32_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdenanio_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6ordenAnio), 4, 0, ",", "")), ((edtavOrdenanio_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6ordenAnio), "ZZZ9")) : context.localUtil.Format( (decimal)(AV6ordenAnio), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,17);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdenanio_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavOrdenanio_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_HAddDespBodegaOP.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavOrdenmes_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavOrdenmes_Internalname, "Periodo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'" + sGXsfl_32_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavOrdenmes, cmbavOrdenmes_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV7ordenMes), 2, 0)), 1, cmbavOrdenmes_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVORDENMES.CLICK."+"'", "int", "", 1, cmbavOrdenmes.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,21);\"", "", true, "HLP_HAddDespBodegaOP.htm");
            cmbavOrdenmes.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV7ordenMes), 2, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavOrdenmes_Internalname, "Values", (String)(cmbavOrdenmes.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavOrdenid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavOrdenid_Internalname, "Nro. Orden", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_32_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavOrdenid, cmbavOrdenid_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV5ordenID), 4, 0)), 1, cmbavOrdenid_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVORDENID.CLICK."+"'", "int", "", 1, cmbavOrdenid.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,26);\"", "", true, "HLP_HAddDespBodegaOP.htm");
            cmbavOrdenid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV5ordenID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavOrdenid_Internalname, "Values", (String)(cmbavOrdenid.ToJavascriptSource()), true);
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
            GxWebStd.gx_div_start( context, divTable3_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            Grid2Container.SetWrapped(nGXWrapped);
            if ( Grid2Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"Grid2Container"+"DivS\" data-gxgridid=\"32\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid2_Internalname, subGrid2_Internalname, "", "WorkWith", 0, "", "", 1, 2, sStyleString, "", "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid2_Backcolorstyle == 0 )
               {
                  subGrid2_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGrid2_Class) > 0 )
                  {
                     subGrid2_Linesclass = subGrid2_Class+"Title";
                  }
               }
               else
               {
                  subGrid2_Titlebackstyle = 1;
                  if ( subGrid2_Backcolorstyle == 1 )
                  {
                     subGrid2_Titlebackcolor = subGrid2_Allbackcolor;
                     if ( StringUtil.Len( subGrid2_Class) > 0 )
                     {
                        subGrid2_Linesclass = subGrid2_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid2_Class) > 0 )
                     {
                        subGrid2_Linesclass = subGrid2_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Desp Bod Nro") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Cod. Producto") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Producto") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Cantidad") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Valor") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "a Despachar") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Detalle") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               Grid2Container.AddObjectProperty("GridName", "Grid2");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  Grid2Container = new GXWebGrid( context);
               }
               else
               {
                  Grid2Container.Clear();
               }
               Grid2Container.SetWrapped(nGXWrapped);
               Grid2Container.AddObjectProperty("GridName", "Grid2");
               Grid2Container.AddObjectProperty("Header", subGrid2_Header);
               Grid2Container.AddObjectProperty("Class", "WorkWith");
               Grid2Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid2Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid2Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Backcolorstyle), 1, 0, ".", "")));
               Grid2Container.AddObjectProperty("CmpContext", "");
               Grid2Container.AddObjectProperty("InMasterPage", "false");
               Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid2Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A353DespBodNro), 4, 0, ".", "")));
               Grid2Container.AddColumnProperties(Grid2Column);
               Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid2Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A355DespBodCodPrd), 4, 0, ".", "")));
               Grid2Container.AddColumnProperties(Grid2Column);
               Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid2Column.AddObjectProperty("Value", StringUtil.RTrim( A356DespBodPrdNombre));
               Grid2Container.AddColumnProperties(Grid2Column);
               Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid2Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A357DespBodCant, 8, 2, ".", "")));
               Grid2Container.AddColumnProperties(Grid2Column);
               Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid2Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A358DespBodValor, 8, 2, ".", "")));
               Grid2Container.AddColumnProperties(Grid2Column);
               Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid2Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( AV19aDespachar, 8, 2, ".", "")));
               Grid2Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavAdespachar_Enabled), 5, 0, ".", "")));
               Grid2Container.AddColumnProperties(Grid2Column);
               Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid2Column.AddObjectProperty("Value", StringUtil.RTrim( A376DespBodDetalle));
               Grid2Container.AddColumnProperties(Grid2Column);
               Grid2Container.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Selectedindex), 4, 0, ".", "")));
               Grid2Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Allowselection), 1, 0, ".", "")));
               Grid2Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Selectioncolor), 9, 0, ".", "")));
               Grid2Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Allowhovering), 1, 0, ".", "")));
               Grid2Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Hoveringcolor), 9, 0, ".", "")));
               Grid2Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Allowcollapsing), 1, 0, ".", "")));
               Grid2Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 32 )
         {
            wbEnd = 0;
            nRC_GXsfl_32 = (short)(nGXsfl_32_idx-1);
            if ( Grid2Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               Grid2Container.AddObjectProperty("GRID2_nEOF", GRID2_nEOF);
               Grid2Container.AddObjectProperty("GRID2_nFirstRecordOnPage", GRID2_nFirstRecordOnPage);
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"Grid2Container"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid2", Grid2Container);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid2ContainerData", Grid2Container.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid2ContainerData"+"V", Grid2Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid2ContainerData"+"V"+"\" value='"+Grid2Container.GridValuesHidden()+"'/>") ;
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
         if ( wbEnd == 32 )
         {
            wbEnd = 0;
            if ( isFullAjaxMode( ) )
            {
               if ( Grid2Container.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  Grid2Container.AddObjectProperty("GRID2_nEOF", GRID2_nEOF);
                  Grid2Container.AddObjectProperty("GRID2_nFirstRecordOnPage", GRID2_nFirstRecordOnPage);
                  sStyleString = "";
                  context.WriteHtmlText( "<div id=\""+"Grid2Container"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid2", Grid2Container);
                  if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "Grid2ContainerData", Grid2Container.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "Grid2ContainerData"+"V", Grid2Container.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid2ContainerData"+"V"+"\" value='"+Grid2Container.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START5T2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "HAdd Desp Bodega OP", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP5T0( ) ;
      }

      protected void WS5T2( )
      {
         START5T2( ) ;
         EVT5T2( ) ;
      }

      protected void EVT5T2( )
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
                        else if ( StringUtil.StrCmp(sEvt, "VORDENMES.CLICK") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E115T2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "VORDENID.CLICK") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E125T2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRID2PAGING") == 0 )
                        {
                           context.wbHandled = 1;
                           sEvt = cgiGet( "GRID2PAGING");
                           if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                           {
                              subgrid2_firstpage( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                           {
                              subgrid2_previouspage( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                           {
                              subgrid2_nextpage( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                           {
                              subgrid2_lastpage( ) ;
                           }
                           dynload_actions( ) ;
                        }
                     }
                     else
                     {
                        sEvtType = StringUtil.Right( sEvt, 4);
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                        if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                        {
                           nGXsfl_32_idx = (short)(NumberUtil.Val( sEvtType, "."));
                           sGXsfl_32_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_32_idx), 4, 0)), 4, "0");
                           SubsflControlProps_322( ) ;
                           A353DespBodNro = (short)(context.localUtil.CToN( cgiGet( edtDespBodNro_Internalname), ",", "."));
                           A355DespBodCodPrd = (short)(context.localUtil.CToN( cgiGet( edtDespBodCodPrd_Internalname), ",", "."));
                           n355DespBodCodPrd = false;
                           A356DespBodPrdNombre = StringUtil.Upper( cgiGet( edtDespBodPrdNombre_Internalname));
                           n356DespBodPrdNombre = false;
                           A357DespBodCant = context.localUtil.CToN( cgiGet( edtDespBodCant_Internalname), ",", ".");
                           n357DespBodCant = false;
                           A358DespBodValor = context.localUtil.CToN( cgiGet( edtDespBodValor_Internalname), ",", ".");
                           n358DespBodValor = false;
                           AV19aDespachar = context.localUtil.CToN( cgiGet( edtavAdespachar_Internalname), ",", ".");
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavAdespachar_Internalname, StringUtil.LTrim( StringUtil.Str( AV19aDespachar, 8, 2)));
                           A376DespBodDetalle = cgiGet( edtDespBodDetalle_Internalname);
                           n376DespBodDetalle = false;
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E135T2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E145T2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Load */
                                 E155T2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    Rfr0gs = false;
                                    /* Set Refresh If Ordenid Changed */
                                    if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDENID"), ",", ".") != Convert.ToDecimal( AV5ordenID )) )
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

      protected void WE5T2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm5T2( ) ;
            }
         }
      }

      protected void PA5T2( )
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
               GX_FocusControl = edtavOrdenanio_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid2_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_322( ) ;
         while ( nGXsfl_32_idx <= nRC_GXsfl_32 )
         {
            sendrow_322( ) ;
            nGXsfl_32_idx = (short)(((subGrid2_Islastpage==1)&&(nGXsfl_32_idx+1>subGrid2_Recordsperpage( )) ? 1 : nGXsfl_32_idx+1));
            sGXsfl_32_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_32_idx), 4, 0)), 4, "0");
            SubsflControlProps_322( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Grid2Container));
         /* End function gxnrGrid2_newrow */
      }

      protected void gxgrGrid2_refresh( int subGrid2_Rows ,
                                        short AV5ordenID ,
                                        short AV9empID ,
                                        short AV10ageId ,
                                        short A1EmpID ,
                                        short A22OrdenID )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID2_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Rows), 6, 0, ".", "")));
         GRID2_nCurrentRecord = 0;
         RF5T2( ) ;
         /* End function gxgrGrid2_refresh */
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
         if ( cmbavOrdenmes.ItemCount > 0 )
         {
            AV7ordenMes = (short)(NumberUtil.Val( cmbavOrdenmes.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV7ordenMes), 2, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ordenMes", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ordenMes), 2, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavOrdenmes.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV7ordenMes), 2, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavOrdenmes_Internalname, "Values", cmbavOrdenmes.ToJavascriptSource(), true);
         }
         if ( cmbavOrdenid.ItemCount > 0 )
         {
            AV5ordenID = (short)(NumberUtil.Val( cmbavOrdenid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV5ordenID), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5ordenID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5ordenID), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavOrdenid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV5ordenID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavOrdenid_Internalname, "Values", cmbavOrdenid.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF5T2( ) ;
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

      protected void RF5T2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            Grid2Container.ClearRows();
         }
         wbStart = 32;
         /* Execute user event: Refresh */
         E145T2 ();
         nGXsfl_32_idx = 1;
         sGXsfl_32_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_32_idx), 4, 0)), 4, "0");
         SubsflControlProps_322( ) ;
         bGXsfl_32_Refreshing = true;
         Grid2Container.AddObjectProperty("GridName", "Grid2");
         Grid2Container.AddObjectProperty("CmpContext", "");
         Grid2Container.AddObjectProperty("InMasterPage", "false");
         Grid2Container.AddObjectProperty("Class", "WorkWith");
         Grid2Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Grid2Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Grid2Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Backcolorstyle), 1, 0, ".", "")));
         Grid2Container.PageSize = subGrid2_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_322( ) ;
            GXPagingFrom2 = (int)(((10==0) ? 0 : GRID2_nFirstRecordOnPage));
            GXPagingTo2 = ((10==0) ? 10000 : subGrid2_Recordsperpage( )+1);
            /* Using cursor H005T2 */
            pr_default.execute(0, new Object[] {AV9empID, AV10ageId, AV5ordenID, GXPagingFrom2, GXPagingTo2});
            nGXsfl_32_idx = 1;
            sGXsfl_32_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_32_idx), 4, 0)), 4, "0");
            SubsflControlProps_322( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID2_nCurrentRecord < subGrid2_Recordsperpage( ) ) ) ) )
            {
               A22OrdenID = H005T2_A22OrdenID[0];
               A2AgeID = H005T2_A2AgeID[0];
               A1EmpID = H005T2_A1EmpID[0];
               A376DespBodDetalle = H005T2_A376DespBodDetalle[0];
               n376DespBodDetalle = H005T2_n376DespBodDetalle[0];
               A358DespBodValor = H005T2_A358DespBodValor[0];
               n358DespBodValor = H005T2_n358DespBodValor[0];
               A357DespBodCant = H005T2_A357DespBodCant[0];
               n357DespBodCant = H005T2_n357DespBodCant[0];
               A356DespBodPrdNombre = H005T2_A356DespBodPrdNombre[0];
               n356DespBodPrdNombre = H005T2_n356DespBodPrdNombre[0];
               A355DespBodCodPrd = H005T2_A355DespBodCodPrd[0];
               n355DespBodCodPrd = H005T2_n355DespBodCodPrd[0];
               A353DespBodNro = H005T2_A353DespBodNro[0];
               /* Execute user event: Load */
               E155T2 ();
               pr_default.readNext(0);
            }
            GRID2_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID2_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID2_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 32;
            WB5T0( ) ;
         }
         bGXsfl_32_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes5T2( )
      {
         GxWebStd.gx_hidden_field( context, "EMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_EMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9empID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9empID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "ORDENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A22OrdenID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_ORDENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A22OrdenID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10ageId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10ageId), "ZZZ9"), context));
      }

      protected int subGrid2_Pagecount( )
      {
         GRID2_nRecordCount = subGrid2_Recordcount( );
         if ( ((int)((GRID2_nRecordCount) % (subGrid2_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID2_nRecordCount/ (decimal)(subGrid2_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID2_nRecordCount/ (decimal)(subGrid2_Recordsperpage( ))))+1) ;
      }

      protected int subGrid2_Recordcount( )
      {
         /* Using cursor H005T3 */
         pr_default.execute(1, new Object[] {AV9empID, AV10ageId, AV5ordenID});
         GRID2_nRecordCount = H005T3_AGRID2_nRecordCount[0];
         pr_default.close(1);
         return (int)(GRID2_nRecordCount) ;
      }

      protected int subGrid2_Recordsperpage( )
      {
         return (int)(10*1) ;
      }

      protected int subGrid2_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID2_nFirstRecordOnPage/ (decimal)(subGrid2_Recordsperpage( ))))+1) ;
      }

      protected short subgrid2_firstpage( )
      {
         GRID2_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID2_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID2_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid2_refresh( subGrid2_Rows, AV5ordenID, AV9empID, AV10ageId, A1EmpID, A22OrdenID) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid2_nextpage( )
      {
         GRID2_nRecordCount = subGrid2_Recordcount( );
         if ( ( GRID2_nRecordCount >= subGrid2_Recordsperpage( ) ) && ( GRID2_nEOF == 0 ) )
         {
            GRID2_nFirstRecordOnPage = (long)(GRID2_nFirstRecordOnPage+subGrid2_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID2_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID2_nFirstRecordOnPage), 15, 0, ".", "")));
         Grid2Container.AddObjectProperty("GRID2_nFirstRecordOnPage", GRID2_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid2_refresh( subGrid2_Rows, AV5ordenID, AV9empID, AV10ageId, A1EmpID, A22OrdenID) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID2_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid2_previouspage( )
      {
         if ( GRID2_nFirstRecordOnPage >= subGrid2_Recordsperpage( ) )
         {
            GRID2_nFirstRecordOnPage = (long)(GRID2_nFirstRecordOnPage-subGrid2_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID2_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID2_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid2_refresh( subGrid2_Rows, AV5ordenID, AV9empID, AV10ageId, A1EmpID, A22OrdenID) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid2_lastpage( )
      {
         GRID2_nRecordCount = subGrid2_Recordcount( );
         if ( GRID2_nRecordCount > subGrid2_Recordsperpage( ) )
         {
            if ( ((int)((GRID2_nRecordCount) % (subGrid2_Recordsperpage( )))) == 0 )
            {
               GRID2_nFirstRecordOnPage = (long)(GRID2_nRecordCount-subGrid2_Recordsperpage( ));
            }
            else
            {
               GRID2_nFirstRecordOnPage = (long)(GRID2_nRecordCount-((int)((GRID2_nRecordCount) % (subGrid2_Recordsperpage( )))));
            }
         }
         else
         {
            GRID2_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID2_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID2_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid2_refresh( subGrid2_Rows, AV5ordenID, AV9empID, AV10ageId, A1EmpID, A22OrdenID) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid2_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRID2_nFirstRecordOnPage = (long)(subGrid2_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRID2_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID2_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID2_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid2_refresh( subGrid2_Rows, AV5ordenID, AV9empID, AV10ageId, A1EmpID, A22OrdenID) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP5T0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E135T2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrdenanio_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrdenanio_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDENANIO");
               GX_FocusControl = edtavOrdenanio_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6ordenAnio = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6ordenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6ordenAnio), 4, 0)));
            }
            else
            {
               AV6ordenAnio = (short)(context.localUtil.CToN( cgiGet( edtavOrdenanio_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6ordenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6ordenAnio), 4, 0)));
            }
            cmbavOrdenmes.Name = cmbavOrdenmes_Internalname;
            cmbavOrdenmes.CurrentValue = cgiGet( cmbavOrdenmes_Internalname);
            AV7ordenMes = (short)(NumberUtil.Val( cgiGet( cmbavOrdenmes_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ordenMes", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ordenMes), 2, 0)));
            cmbavOrdenid.Name = cmbavOrdenid_Internalname;
            cmbavOrdenid.CurrentValue = cgiGet( cmbavOrdenid_Internalname);
            AV5ordenID = (short)(NumberUtil.Val( cgiGet( cmbavOrdenid_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5ordenID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5ordenID), 4, 0)));
            /* Read saved values. */
            nRC_GXsfl_32 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_32"), ",", "."));
            GRID2_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID2_nFirstRecordOnPage"), ",", "."));
            GRID2_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID2_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDENID"), ",", ".") != Convert.ToDecimal( AV5ordenID )) )
            {
               GRID2_nFirstRecordOnPage = 0;
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
         E135T2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E135T2( )
      {
         /* Start Routine */
         AV6ordenAnio = (short)(DateTimeUtil.Year( DateTimeUtil.ServerNow( context, pr_default)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6ordenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6ordenAnio), 4, 0)));
         AV7ordenMes = (short)(DateTimeUtil.Month( DateTimeUtil.ServerNow( context, pr_default)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ordenMes", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ordenMes), 2, 0)));
         /* Execute user subroutine: 'LOADORDENCOMBO' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtavAdespachar_Enabled = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAdespachar_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAdespachar_Enabled), 5, 0)), !bGXsfl_32_Refreshing);
      }

      protected void E115T2( )
      {
         /* Ordenmes_Click Routine */
         /* Execute user subroutine: 'LOADORDENCOMBO' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /*  Sending Event outputs  */
         cmbavOrdenid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV5ordenID), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavOrdenid_Internalname, "Values", cmbavOrdenid.ToJavascriptSource(), true);
      }

      protected void S112( )
      {
         /* 'LOADORDENCOMBO' Routine */
         cmbavOrdenid.removeAllItems();
         cmbavOrdenid.addItem("0", "Seleccionar Orden", 0);
         /* Using cursor H005T4 */
         pr_default.execute(2, new Object[] {AV9empID, AV6ordenAnio, AV7ordenMes});
         while ( (pr_default.getStatus(2) != 101) )
         {
            A5ClienteID = H005T4_A5ClienteID[0];
            A24OrdenPeriodo = H005T4_A24OrdenPeriodo[0];
            A25OrdenAnio = H005T4_A25OrdenAnio[0];
            A1EmpID = H005T4_A1EmpID[0];
            A57ClienteDsc = H005T4_A57ClienteDsc[0];
            n57ClienteDsc = H005T4_n57ClienteDsc[0];
            A22OrdenID = H005T4_A22OrdenID[0];
            A57ClienteDsc = H005T4_A57ClienteDsc[0];
            n57ClienteDsc = H005T4_n57ClienteDsc[0];
            AV12OrdenDetalle = StringUtil.Str( (decimal)(A22OrdenID), 10, 0) + " - " + StringUtil.Trim( A57ClienteDsc);
            cmbavOrdenid.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)), AV12OrdenDetalle, 0);
            pr_default.readNext(2);
         }
         pr_default.close(2);
      }

      protected void E125T2( )
      {
         /* Ordenid_Click Routine */
         AV20IDOrden = AV5ordenID;
         GXt_objcol_SdtSDTOrdenItems_SDTOrdenItemsItem1 = AV13SDTOrdenItems;
         new dploaditemsop(context ).execute(  AV9empID,  AV6ordenAnio,  AV7ordenMes,  AV20IDOrden, out  GXt_objcol_SdtSDTOrdenItems_SDTOrdenItemsItem1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9empID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9empID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9empID), "ZZZ9"), context));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6ordenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6ordenAnio), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ordenMes", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ordenMes), 2, 0)));
         AV13SDTOrdenItems = GXt_objcol_SdtSDTOrdenItems_SDTOrdenItemsItem1;
         new prcadddespbodsdt(context ).execute(  AV9empID,  AV10ageId,  AV20IDOrden,  1,  AV13SDTOrdenItems) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9empID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9empID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9empID), "ZZZ9"), context));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ageId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10ageId), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10ageId), "ZZZ9"), context));
      }

      protected void E145T2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV8nro = 0;
      }

      private void E155T2( )
      {
         /* Load Routine */
         sendrow_322( ) ;
         GRID2_nCurrentRecord = (long)(GRID2_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_32_Refreshing )
         {
            context.DoAjaxLoad(32, Grid2Row);
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV9empID = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9empID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9empID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9empID), "ZZZ9"), context));
         AV10ageId = Convert.ToInt16(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ageId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10ageId), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10ageId), "ZZZ9"), context));
         AV11usuCod = (String)getParm(obj,2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11usuCod", AV11usuCod);
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
         PA5T2( ) ;
         WS5T2( ) ;
         WE5T2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202311922342579", true);
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
         context.AddJavascriptSource("hadddespbodegaop.js", "?202311922342580", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_322( )
      {
         edtDespBodNro_Internalname = "DESPBODNRO_"+sGXsfl_32_idx;
         edtDespBodCodPrd_Internalname = "DESPBODCODPRD_"+sGXsfl_32_idx;
         edtDespBodPrdNombre_Internalname = "DESPBODPRDNOMBRE_"+sGXsfl_32_idx;
         edtDespBodCant_Internalname = "DESPBODCANT_"+sGXsfl_32_idx;
         edtDespBodValor_Internalname = "DESPBODVALOR_"+sGXsfl_32_idx;
         edtavAdespachar_Internalname = "vADESPACHAR_"+sGXsfl_32_idx;
         edtDespBodDetalle_Internalname = "DESPBODDETALLE_"+sGXsfl_32_idx;
      }

      protected void SubsflControlProps_fel_322( )
      {
         edtDespBodNro_Internalname = "DESPBODNRO_"+sGXsfl_32_fel_idx;
         edtDespBodCodPrd_Internalname = "DESPBODCODPRD_"+sGXsfl_32_fel_idx;
         edtDespBodPrdNombre_Internalname = "DESPBODPRDNOMBRE_"+sGXsfl_32_fel_idx;
         edtDespBodCant_Internalname = "DESPBODCANT_"+sGXsfl_32_fel_idx;
         edtDespBodValor_Internalname = "DESPBODVALOR_"+sGXsfl_32_fel_idx;
         edtavAdespachar_Internalname = "vADESPACHAR_"+sGXsfl_32_fel_idx;
         edtDespBodDetalle_Internalname = "DESPBODDETALLE_"+sGXsfl_32_fel_idx;
      }

      protected void sendrow_322( )
      {
         SubsflControlProps_322( ) ;
         WB5T0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_32_idx <= subGrid2_Recordsperpage( ) * 1 ) )
         {
            Grid2Row = GXWebRow.GetNew(context,Grid2Container);
            if ( subGrid2_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid2_Backstyle = 0;
               if ( StringUtil.StrCmp(subGrid2_Class, "") != 0 )
               {
                  subGrid2_Linesclass = subGrid2_Class+"Odd";
               }
            }
            else if ( subGrid2_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid2_Backstyle = 0;
               subGrid2_Backcolor = subGrid2_Allbackcolor;
               if ( StringUtil.StrCmp(subGrid2_Class, "") != 0 )
               {
                  subGrid2_Linesclass = subGrid2_Class+"Uniform";
               }
            }
            else if ( subGrid2_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid2_Backstyle = 1;
               if ( StringUtil.StrCmp(subGrid2_Class, "") != 0 )
               {
                  subGrid2_Linesclass = subGrid2_Class+"Odd";
               }
               subGrid2_Backcolor = (int)(0x0);
            }
            else if ( subGrid2_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid2_Backstyle = 1;
               if ( ((int)(((nGXsfl_32_idx-1)/ (decimal)(1)) % (2))) == 0 )
               {
                  subGrid2_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid2_Class, "") != 0 )
                  {
                     subGrid2_Linesclass = subGrid2_Class+"Odd";
                  }
               }
               else
               {
                  subGrid2_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid2_Class, "") != 0 )
                  {
                     subGrid2_Linesclass = subGrid2_Class+"Even";
                  }
               }
            }
            if ( Grid2Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+"WorkWith"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_32_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid2Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid2Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodNro_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A353DespBodNro), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A353DespBodNro), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodNro_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)32,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid2Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid2Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodCodPrd_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A355DespBodCodPrd), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A355DespBodCodPrd), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodCodPrd_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)32,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid2Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid2Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodPrdNombre_Internalname,StringUtil.RTrim( A356DespBodPrdNombre),StringUtil.RTrim( context.localUtil.Format( A356DespBodPrdNombre, "@!")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodPrdNombre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)32,(short)1,(short)-1,(short)-1,(bool)true,(String)"nombres",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid2Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid2Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodCant_Internalname,StringUtil.LTrim( StringUtil.NToC( A357DespBodCant, 8, 2, ",", "")),context.localUtil.Format( A357DespBodCant, "ZZZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodCant_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)32,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid2Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid2Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodValor_Internalname,StringUtil.LTrim( StringUtil.NToC( A358DespBodValor, 8, 2, ",", "")),context.localUtil.Format( A358DespBodValor, "ZZZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodValor_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)32,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid2Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavAdespachar_Enabled!=0)&&(edtavAdespachar_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 38,'',false,'"+sGXsfl_32_idx+"',32)\"" : " ");
            ROClassString = "Attribute";
            Grid2Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavAdespachar_Internalname,StringUtil.LTrim( StringUtil.NToC( AV19aDespachar, 8, 2, ",", "")),StringUtil.LTrim( context.localUtil.Format( AV19aDespachar, "ZZZZ9.99")),TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+((edtavAdespachar_Enabled!=0)&&(edtavAdespachar_Visible!=0) ? " onblur=\""+";gx.evt.onblur(this,38);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavAdespachar_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(int)edtavAdespachar_Enabled,(short)1,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)32,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid2Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid2Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodDetalle_Internalname,StringUtil.RTrim( A376DespBodDetalle),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodDetalle_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)32,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes5T2( ) ;
            Grid2Container.AddRow(Grid2Row);
            nGXsfl_32_idx = (short)(((subGrid2_Islastpage==1)&&(nGXsfl_32_idx+1>subGrid2_Recordsperpage( )) ? 1 : nGXsfl_32_idx+1));
            sGXsfl_32_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_32_idx), 4, 0)), 4, "0");
            SubsflControlProps_322( ) ;
         }
         /* End function sendrow_322 */
      }

      protected void init_web_controls( )
      {
         cmbavOrdenmes.Name = "vORDENMES";
         cmbavOrdenmes.WebTags = "";
         cmbavOrdenmes.addItem("1", "ENERO", 0);
         cmbavOrdenmes.addItem("2", "FEBRERO", 0);
         cmbavOrdenmes.addItem("3", "MARZO", 0);
         cmbavOrdenmes.addItem("4", "ABRIL", 0);
         cmbavOrdenmes.addItem("5", "MAYO", 0);
         cmbavOrdenmes.addItem("6", "JUNIO", 0);
         cmbavOrdenmes.addItem("7", "JULIO", 0);
         cmbavOrdenmes.addItem("8", "AGOSTO", 0);
         cmbavOrdenmes.addItem("9", "SEPTIEMBRE", 0);
         cmbavOrdenmes.addItem("10", "OCTUBRE", 0);
         cmbavOrdenmes.addItem("11", "NOVIEMBRE", 0);
         cmbavOrdenmes.addItem("12", "DICIEMBRE", 0);
         if ( cmbavOrdenmes.ItemCount > 0 )
         {
            AV7ordenMes = (short)(NumberUtil.Val( cmbavOrdenmes.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV7ordenMes), 2, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ordenMes", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ordenMes), 2, 0)));
         }
         cmbavOrdenid.Name = "vORDENID";
         cmbavOrdenid.WebTags = "";
         if ( cmbavOrdenid.ItemCount > 0 )
         {
            AV5ordenID = (short)(NumberUtil.Val( cmbavOrdenid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV5ordenID), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5ordenID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5ordenID), 4, 0)));
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1";
         divTable1_Internalname = "TABLE1";
         edtavOrdenanio_Internalname = "vORDENANIO";
         cmbavOrdenmes_Internalname = "vORDENMES";
         cmbavOrdenid_Internalname = "vORDENID";
         divTable2_Internalname = "TABLE2";
         edtDespBodNro_Internalname = "DESPBODNRO";
         edtDespBodCodPrd_Internalname = "DESPBODCODPRD";
         edtDespBodPrdNombre_Internalname = "DESPBODPRDNOMBRE";
         edtDespBodCant_Internalname = "DESPBODCANT";
         edtDespBodValor_Internalname = "DESPBODVALOR";
         edtavAdespachar_Internalname = "vADESPACHAR";
         edtDespBodDetalle_Internalname = "DESPBODDETALLE";
         divTable3_Internalname = "TABLE3";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         subGrid2_Internalname = "GRID2";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtDespBodDetalle_Jsonclick = "";
         edtavAdespachar_Jsonclick = "";
         edtavAdespachar_Visible = -1;
         edtDespBodValor_Jsonclick = "";
         edtDespBodCant_Jsonclick = "";
         edtDespBodPrdNombre_Jsonclick = "";
         edtDespBodCodPrd_Jsonclick = "";
         edtDespBodNro_Jsonclick = "";
         subGrid2_Allowcollapsing = 0;
         subGrid2_Allowselection = 0;
         subGrid2_Header = "";
         subGrid2_Class = "WorkWith";
         subGrid2_Backcolorstyle = 0;
         cmbavOrdenid_Jsonclick = "";
         cmbavOrdenid.Enabled = 1;
         cmbavOrdenmes_Jsonclick = "";
         cmbavOrdenmes.Enabled = 1;
         edtavOrdenanio_Jsonclick = "";
         edtavOrdenanio_Enabled = 1;
         subGrid2_Rows = 10;
         edtavAdespachar_Enabled = 0;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID2_nFirstRecordOnPage'},{av:'GRID2_nEOF'},{av:'subGrid2_Rows',ctrl:'GRID2',prop:'Rows'},{av:'cmbavOrdenid'},{av:'AV5ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'edtavAdespachar_Enabled',ctrl:'vADESPACHAR',prop:'Enabled'},{av:'AV9empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV10ageId',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9',hsh:true},{av:'A22OrdenID',fld:'ORDENID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("VORDENMES.CLICK","{handler:'E115T2',iparms:[{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9',hsh:true},{av:'AV9empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'A25OrdenAnio',fld:'ORDENANIO',pic:'ZZZ9'},{av:'AV6ordenAnio',fld:'vORDENANIO',pic:'ZZZ9'},{av:'A24OrdenPeriodo',fld:'ORDENPERIODO',pic:'Z9'},{av:'cmbavOrdenmes'},{av:'AV7ordenMes',fld:'vORDENMES',pic:'Z9'},{av:'A22OrdenID',fld:'ORDENID',pic:'ZZZ9',hsh:true},{av:'A57ClienteDsc',fld:'CLIENTEDSC',pic:''}]");
         setEventMetadata("VORDENMES.CLICK",",oparms:[{av:'cmbavOrdenid'},{av:'AV5ordenID',fld:'vORDENID',pic:'ZZZ9'}]}");
         setEventMetadata("VORDENID.CLICK","{handler:'E125T2',iparms:[{av:'cmbavOrdenid'},{av:'AV5ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV9empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV6ordenAnio',fld:'vORDENANIO',pic:'ZZZ9'},{av:'cmbavOrdenmes'},{av:'AV7ordenMes',fld:'vORDENMES',pic:'Z9'},{av:'AV10ageId',fld:'vAGEID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("VORDENID.CLICK",",oparms:[]}");
         setEventMetadata("GRID2_FIRSTPAGE","{handler:'subgrid2_firstpage',iparms:[{av:'GRID2_nFirstRecordOnPage'},{av:'GRID2_nEOF'},{av:'subGrid2_Rows',ctrl:'GRID2',prop:'Rows'},{av:'cmbavOrdenid'},{av:'AV5ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV9empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV10ageId',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'edtavAdespachar_Enabled',ctrl:'vADESPACHAR',prop:'Enabled'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9',hsh:true},{av:'A22OrdenID',fld:'ORDENID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("GRID2_FIRSTPAGE",",oparms:[]}");
         setEventMetadata("GRID2_PREVPAGE","{handler:'subgrid2_previouspage',iparms:[{av:'GRID2_nFirstRecordOnPage'},{av:'GRID2_nEOF'},{av:'subGrid2_Rows',ctrl:'GRID2',prop:'Rows'},{av:'cmbavOrdenid'},{av:'AV5ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV9empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV10ageId',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'edtavAdespachar_Enabled',ctrl:'vADESPACHAR',prop:'Enabled'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9',hsh:true},{av:'A22OrdenID',fld:'ORDENID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("GRID2_PREVPAGE",",oparms:[]}");
         setEventMetadata("GRID2_NEXTPAGE","{handler:'subgrid2_nextpage',iparms:[{av:'GRID2_nFirstRecordOnPage'},{av:'GRID2_nEOF'},{av:'subGrid2_Rows',ctrl:'GRID2',prop:'Rows'},{av:'cmbavOrdenid'},{av:'AV5ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV9empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV10ageId',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'edtavAdespachar_Enabled',ctrl:'vADESPACHAR',prop:'Enabled'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9',hsh:true},{av:'A22OrdenID',fld:'ORDENID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("GRID2_NEXTPAGE",",oparms:[]}");
         setEventMetadata("GRID2_LASTPAGE","{handler:'subgrid2_lastpage',iparms:[{av:'GRID2_nFirstRecordOnPage'},{av:'GRID2_nEOF'},{av:'subGrid2_Rows',ctrl:'GRID2',prop:'Rows'},{av:'cmbavOrdenid'},{av:'AV5ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV9empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV10ageId',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'edtavAdespachar_Enabled',ctrl:'vADESPACHAR',prop:'Enabled'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9',hsh:true},{av:'A22OrdenID',fld:'ORDENID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("GRID2_LASTPAGE",",oparms:[]}");
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
         wcpOAV11usuCod = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         A57ClienteDsc = "";
         GX_FocusControl = "";
         sPrefix = "";
         lblTextblock1_Jsonclick = "";
         TempTags = "";
         Grid2Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid2_Linesclass = "";
         Grid2Column = new GXWebColumn();
         A356DespBodPrdNombre = "";
         A376DespBodDetalle = "";
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H005T2_A5ClienteID = new short[1] ;
         H005T2_A400nroReg = new int[1] ;
         H005T2_A22OrdenID = new short[1] ;
         H005T2_A2AgeID = new short[1] ;
         H005T2_A1EmpID = new short[1] ;
         H005T2_A376DespBodDetalle = new String[] {""} ;
         H005T2_n376DespBodDetalle = new bool[] {false} ;
         H005T2_A358DespBodValor = new decimal[1] ;
         H005T2_n358DespBodValor = new bool[] {false} ;
         H005T2_A357DespBodCant = new decimal[1] ;
         H005T2_n357DespBodCant = new bool[] {false} ;
         H005T2_A356DespBodPrdNombre = new String[] {""} ;
         H005T2_n356DespBodPrdNombre = new bool[] {false} ;
         H005T2_A355DespBodCodPrd = new short[1] ;
         H005T2_n355DespBodCodPrd = new bool[] {false} ;
         H005T2_A353DespBodNro = new short[1] ;
         H005T3_AGRID2_nRecordCount = new long[1] ;
         H005T4_A5ClienteID = new short[1] ;
         H005T4_A24OrdenPeriodo = new short[1] ;
         H005T4_A25OrdenAnio = new short[1] ;
         H005T4_A1EmpID = new short[1] ;
         H005T4_A57ClienteDsc = new String[] {""} ;
         H005T4_n57ClienteDsc = new bool[] {false} ;
         H005T4_A22OrdenID = new short[1] ;
         AV12OrdenDetalle = "";
         AV13SDTOrdenItems = new GXBaseCollection<SdtSDTOrdenItems_SDTOrdenItemsItem>( context, "SDTOrdenItemsItem", "KBCalpesa22");
         GXt_objcol_SdtSDTOrdenItems_SDTOrdenItemsItem1 = new GXBaseCollection<SdtSDTOrdenItems_SDTOrdenItemsItem>( context, "SDTOrdenItemsItem", "KBCalpesa22");
         Grid2Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.hadddespbodegaop__default(),
            new Object[][] {
                new Object[] {
               H005T2_A5ClienteID, H005T2_A400nroReg, H005T2_A22OrdenID, H005T2_A2AgeID, H005T2_A1EmpID, H005T2_A376DespBodDetalle, H005T2_n376DespBodDetalle, H005T2_A358DespBodValor, H005T2_n358DespBodValor, H005T2_A357DespBodCant,
               H005T2_n357DespBodCant, H005T2_A356DespBodPrdNombre, H005T2_n356DespBodPrdNombre, H005T2_A355DespBodCodPrd, H005T2_n355DespBodCodPrd, H005T2_A353DespBodNro
               }
               , new Object[] {
               H005T3_AGRID2_nRecordCount
               }
               , new Object[] {
               H005T4_A5ClienteID, H005T4_A24OrdenPeriodo, H005T4_A25OrdenAnio, H005T4_A1EmpID, H005T4_A57ClienteDsc, H005T4_n57ClienteDsc, H005T4_A22OrdenID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV9empID ;
      private short AV10ageId ;
      private short wcpOAV9empID ;
      private short wcpOAV10ageId ;
      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_32 ;
      private short nGXsfl_32_idx=1 ;
      private short GRID2_nEOF ;
      private short AV5ordenID ;
      private short A1EmpID ;
      private short A22OrdenID ;
      private short initialized ;
      private short A25OrdenAnio ;
      private short A24OrdenPeriodo ;
      private short wbEnd ;
      private short wbStart ;
      private short AV6ordenAnio ;
      private short AV7ordenMes ;
      private short subGrid2_Backcolorstyle ;
      private short subGrid2_Titlebackstyle ;
      private short A353DespBodNro ;
      private short A355DespBodCodPrd ;
      private short subGrid2_Allowselection ;
      private short subGrid2_Allowhovering ;
      private short subGrid2_Allowcollapsing ;
      private short subGrid2_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short A2AgeID ;
      private short A5ClienteID ;
      private short AV20IDOrden ;
      private short AV8nro ;
      private short nGXWrapped ;
      private short subGrid2_Backstyle ;
      private int edtavAdespachar_Enabled ;
      private int subGrid2_Rows ;
      private int edtavOrdenanio_Enabled ;
      private int subGrid2_Titlebackcolor ;
      private int subGrid2_Allbackcolor ;
      private int subGrid2_Selectedindex ;
      private int subGrid2_Selectioncolor ;
      private int subGrid2_Hoveringcolor ;
      private int subGrid2_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int idxLst ;
      private int subGrid2_Backcolor ;
      private int edtavAdespachar_Visible ;
      private long GRID2_nFirstRecordOnPage ;
      private long GRID2_nCurrentRecord ;
      private long GRID2_nRecordCount ;
      private decimal A357DespBodCant ;
      private decimal A358DespBodValor ;
      private decimal AV19aDespachar ;
      private String AV11usuCod ;
      private String wcpOAV11usuCod ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_32_idx="0001" ;
      private String edtavAdespachar_Internalname ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String A57ClienteDsc ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String divTable1_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String divTable2_Internalname ;
      private String edtavOrdenanio_Internalname ;
      private String TempTags ;
      private String edtavOrdenanio_Jsonclick ;
      private String cmbavOrdenmes_Internalname ;
      private String cmbavOrdenmes_Jsonclick ;
      private String cmbavOrdenid_Internalname ;
      private String cmbavOrdenid_Jsonclick ;
      private String divTable3_Internalname ;
      private String sStyleString ;
      private String subGrid2_Internalname ;
      private String subGrid2_Class ;
      private String subGrid2_Linesclass ;
      private String subGrid2_Header ;
      private String A356DespBodPrdNombre ;
      private String A376DespBodDetalle ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtDespBodNro_Internalname ;
      private String edtDespBodCodPrd_Internalname ;
      private String edtDespBodPrdNombre_Internalname ;
      private String edtDespBodCant_Internalname ;
      private String edtDespBodValor_Internalname ;
      private String edtDespBodDetalle_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_32_fel_idx="0001" ;
      private String ROClassString ;
      private String edtDespBodNro_Jsonclick ;
      private String edtDespBodCodPrd_Jsonclick ;
      private String edtDespBodPrdNombre_Jsonclick ;
      private String edtDespBodCant_Jsonclick ;
      private String edtDespBodValor_Jsonclick ;
      private String edtavAdespachar_Jsonclick ;
      private String edtDespBodDetalle_Jsonclick ;
      private bool entryPointCalled ;
      private bool bGXsfl_32_Refreshing=false ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n355DespBodCodPrd ;
      private bool n356DespBodPrdNombre ;
      private bool n357DespBodCant ;
      private bool n358DespBodValor ;
      private bool n376DespBodDetalle ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool n57ClienteDsc ;
      private bool gx_refresh_fired ;
      private String AV12OrdenDetalle ;
      private GXWebGrid Grid2Container ;
      private GXWebRow Grid2Row ;
      private GXWebColumn Grid2Column ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavOrdenmes ;
      private GXCombobox cmbavOrdenid ;
      private IDataStoreProvider pr_default ;
      private short[] H005T2_A5ClienteID ;
      private int[] H005T2_A400nroReg ;
      private short[] H005T2_A22OrdenID ;
      private short[] H005T2_A2AgeID ;
      private short[] H005T2_A1EmpID ;
      private String[] H005T2_A376DespBodDetalle ;
      private bool[] H005T2_n376DespBodDetalle ;
      private decimal[] H005T2_A358DespBodValor ;
      private bool[] H005T2_n358DespBodValor ;
      private decimal[] H005T2_A357DespBodCant ;
      private bool[] H005T2_n357DespBodCant ;
      private String[] H005T2_A356DespBodPrdNombre ;
      private bool[] H005T2_n356DespBodPrdNombre ;
      private short[] H005T2_A355DespBodCodPrd ;
      private bool[] H005T2_n355DespBodCodPrd ;
      private short[] H005T2_A353DespBodNro ;
      private long[] H005T3_AGRID2_nRecordCount ;
      private short[] H005T4_A5ClienteID ;
      private short[] H005T4_A24OrdenPeriodo ;
      private short[] H005T4_A25OrdenAnio ;
      private short[] H005T4_A1EmpID ;
      private String[] H005T4_A57ClienteDsc ;
      private bool[] H005T4_n57ClienteDsc ;
      private short[] H005T4_A22OrdenID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<SdtSDTOrdenItems_SDTOrdenItemsItem> AV13SDTOrdenItems ;
      private GXBaseCollection<SdtSDTOrdenItems_SDTOrdenItemsItem> GXt_objcol_SdtSDTOrdenItems_SDTOrdenItemsItem1 ;
   }

   public class hadddespbodegaop__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH005T2 ;
          prmH005T2 = new Object[] {
          new Object[] {"@AV9empID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10ageId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV5ordenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH005T3 ;
          prmH005T3 = new Object[] {
          new Object[] {"@AV9empID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10ageId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV5ordenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH005T4 ;
          prmH005T4 = new Object[] {
          new Object[] {"@AV9empID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6ordenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7ordenMes",SqlDbType.SmallInt,2,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H005T2", "SELECT [ClienteID], [nroReg], [OrdenID], [AgeID], [EmpID], [DespBodDetalle], [DespBodValor], [DespBodCant], [DespBodPrdNombre], [DespBodCodPrd], [DespBodNro] FROM [DespBodegaprd] WITH (NOLOCK) WHERE ([EmpID] = @AV9empID and [AgeID] = @AV10ageId) AND ([OrdenID] = @AV5ordenID) ORDER BY [EmpID], [AgeID]  OFFSET @GXPagingFrom2 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo2 > 0 THEN @GXPagingTo2 ELSE 1e9 END) AS INTEGER) ROWS ONLY",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005T2,11,0,true,false )
             ,new CursorDef("H005T3", "SELECT COUNT(*) FROM [DespBodegaprd] WITH (NOLOCK) WHERE ([EmpID] = @AV9empID and [AgeID] = @AV10ageId) AND ([OrdenID] = @AV5ordenID) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005T3,1,0,true,false )
             ,new CursorDef("H005T4", "SELECT T1.[ClienteID], T1.[OrdenPeriodo], T1.[OrdenAnio], T1.[EmpID], T2.[ClienteDsc], T1.[OrdenID] FROM ([OrdenProduccion] T1 WITH (NOLOCK) INNER JOIN [Clientes] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[ClienteID] = T1.[ClienteID]) WHERE (T1.[EmpID] = @AV9empID) AND (T1.[OrdenAnio] = @AV6ordenAnio) AND (T1.[OrdenPeriodo] = @AV7ordenMes) ORDER BY T1.[EmpID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005T4,100,0,false,false )
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
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 50) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((decimal[]) buf[7])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((decimal[]) buf[9])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(8);
                ((String[]) buf[11])[0] = rslt.getString(9, 40) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(9);
                ((short[]) buf[13])[0] = rslt.getShort(10) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(10);
                ((short[]) buf[15])[0] = rslt.getShort(11) ;
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 50) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
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
                stmt.SetParameter(4, (int)parms[3]);
                stmt.SetParameter(5, (int)parms[4]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
       }
    }

 }

}
