/*
               File: MantOrdenProduccion
        Description: Mant Orden Produccion
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/14/2023 1:15:58.49
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
   public class mantordenproduccion : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public mantordenproduccion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public mantordenproduccion( IGxContext context )
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
         this.AV10empID = aP0_empID;
         this.AV6ageID = aP1_ageID;
         this.AV26UserCod = aP2_UserCod;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavPeriod = new GXCombobox();
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
               nRC_GXsfl_38 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_38_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_38_idx = GetNextPar( );
               AV25Update = GetNextPar( );
               edtavUpdate_Visible = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_38_Refreshing);
               AV9Delete = GetNextPar( );
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
               AV20period = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV19ordenID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV7ClienteDsc = GetNextPar( );
               AV29vehiculoPlaca = GetNextPar( );
               AV28vehiculoChasis = GetNextPar( );
               AV26UserCod = GetNextPar( );
               AV34Pgmname = GetNextPar( );
               AV25Update = GetNextPar( );
               edtavUpdate_Visible = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_38_Refreshing);
               AV9Delete = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV20period, AV19ordenID, AV7ClienteDsc, AV29vehiculoPlaca, AV28vehiculoChasis, AV26UserCod, AV34Pgmname, AV25Update, AV9Delete) ;
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
               AV10empID = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10empID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10empID), 4, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV6ageID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6ageID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6ageID), 4, 0)));
                  AV26UserCod = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26UserCod", AV26UserCod);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSERCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV26UserCod, "")), context));
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
            PA292( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV34Pgmname = "MantOrdenProduccion";
               context.Gx_err = 0;
               edtavUpdate_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Enabled), 5, 0)), !bGXsfl_38_Refreshing);
               edtavDelete_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Enabled), 5, 0)), !bGXsfl_38_Refreshing);
               WS292( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE292( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20231141155857", false);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("mantordenproduccion.aspx") + "?" + UrlEncode("" +AV10empID) + "," + UrlEncode("" +AV6ageID) + "," + UrlEncode(StringUtil.RTrim(AV26UserCod))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vPERIOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV20period), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19ordenID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCLIENTEDSC", StringUtil.RTrim( AV7ClienteDsc));
         GxWebStd.gx_hidden_field( context, "GXH_vVEHICULOPLACA", AV29vehiculoPlaca);
         GxWebStd.gx_hidden_field( context, "GXH_vVEHICULOCHASIS", AV28vehiculoChasis);
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_38", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_38), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV34Pgmname));
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10empID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6ageID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vUSERCOD", StringUtil.RTrim( AV26UserCod));
         GxWebStd.gx_hidden_field( context, "gxhash_vUSERCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV26UserCod, "")), context));
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vUPDATE_Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Visible), 5, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm292( )
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
         return "MantOrdenProduccion" ;
      }

      public override String GetPgmdesc( )
      {
         return "Mant Orden Produccion" ;
      }

      protected void WB290( )
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
            GxWebStd.gx_label_ctrl( context, lblTitletext_Internalname, "Orden Produccion", "", "", lblTitletext_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "SubTitle", 0, "", 1, 1, 0, "HLP_MantOrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 WWActionsCell", "Right", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "BtnAdd";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(38), 2, 0)+","+"null"+");", "Agregar", bttBtninsert_Jsonclick, 7, "Agregar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e11291_client"+"'", TempTags, "", 2, "HLP_MantOrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 col-lg-2 col-lg-offset-1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavPeriod_Internalname, "period", "col-sm-3 FilterComboAttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'" + sGXsfl_38_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavPeriod, cmbavPeriod_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV20period), 2, 0)), 1, cmbavPeriod_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVPERIOD.CLICK."+"'", "int", "", 1, cmbavPeriod.Enabled, 0, 0, 0, "em", 0, "", "", "FilterComboAttribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,17);\"", "", true, "HLP_MantOrdenProduccion.htm");
            cmbavPeriod.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV20period), 2, 0));
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'" + sGXsfl_38_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdenid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19ordenID), 4, 0, ",", "")), ((edtavOrdenid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV19ordenID), "ZZZ9")) : context.localUtil.Format( (decimal)(AV19ordenID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,20);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "# Orden", edtavOrdenid_Jsonclick, 0, "FilterSearchAttribute", "", "", "", "", 1, edtavOrdenid_Enabled, 0, "number", "1", 125, "px", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_MantOrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClientedsc_Internalname, "Cliente Dsc", "col-sm-3 FilterSearchAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'" + sGXsfl_38_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClientedsc_Internalname, StringUtil.RTrim( AV7ClienteDsc), StringUtil.RTrim( context.localUtil.Format( AV7ClienteDsc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,23);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "Cliente", edtavClientedsc_Jsonclick, 0, "FilterSearchAttribute", "", "", "", "", 1, edtavClientedsc_Enabled, 0, "text", "", 20, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_MantOrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVehiculoplaca_Internalname, "vehiculo Placa", "col-sm-3 FilterSearchAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_38_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVehiculoplaca_Internalname, AV29vehiculoPlaca, StringUtil.RTrim( context.localUtil.Format( AV29vehiculoPlaca, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "# Placa", edtavVehiculoplaca_Jsonclick, 0, "FilterSearchAttribute", "", "", "", "", 1, edtavVehiculoplaca_Enabled, 0, "text", "", 150, "px", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_MantOrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVehiculochasis_Internalname, "vehiculo Chasis", "col-sm-3 FilterSearchAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_38_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVehiculochasis_Internalname, AV28vehiculoChasis, StringUtil.RTrim( context.localUtil.Format( AV28vehiculoChasis, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "# Chasis", edtavVehiculochasis_Jsonclick, 0, "FilterSearchAttribute", "", "", "", "", 1, edtavVehiculochasis_Enabled, 0, "text", "", 180, "px", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_MantOrdenProduccion.htm");
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
            /*  Grid Control  */
            GridContainer.SetWrapped(nGXWrapped);
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"38\">") ;
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Nro.FACT") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Cliente") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "nro. SEC") ;
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
               context.SendWebValue( "Prototipo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"TextActionAttribute"+"\" "+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"TextActionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
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
               GridColumn.AddObjectProperty("Value", A122protSiglas);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( AV25Update));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Enabled), 5, 0, ".", "")));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( AV9Delete));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Enabled), 5, 0, ".", "")));
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
         if ( wbEnd == 38 )
         {
            wbEnd = 0;
            nRC_GXsfl_38 = (short)(nGXsfl_38_idx-1);
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
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavYear_Internalname, "year", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'" + sGXsfl_38_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavYear_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV30year), 4, 0, ",", "")), ((edtavYear_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV30year), "ZZZ9")) : context.localUtil.Format( (decimal)(AV30year), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavYear_Jsonclick, 0, "Attribute", "", "", "", "", edtavYear_Visible, edtavYear_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_MantOrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 38 )
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

      protected void START292( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "Mant Orden Produccion", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP290( ) ;
      }

      protected void WS292( )
      {
         START292( ) ;
         EVT292( ) ;
      }

      protected void EVT292( )
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
                        else if ( StringUtil.StrCmp(sEvt, "VPERIOD.CLICK") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E12292 ();
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
                           nGXsfl_38_idx = (short)(NumberUtil.Val( sEvtType, "."));
                           sGXsfl_38_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_38_idx), 4, 0)), 4, "0");
                           SubsflControlProps_382( ) ;
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
                           A122protSiglas = cgiGet( edtprotSiglas_Internalname);
                           n122protSiglas = false;
                           AV25Update = cgiGet( edtavUpdate_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV25Update);
                           AV9Delete = cgiGet( edtavDelete_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV9Delete);
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E13292 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E14292 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E15292 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    Rfr0gs = false;
                                    /* Set Refresh If Period Changed */
                                    if ( ( context.localUtil.CToN( cgiGet( "GXH_vPERIOD"), ",", ".") != Convert.ToDecimal( AV20period )) )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Ordenid Changed */
                                    if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDENID"), ",", ".") != Convert.ToDecimal( AV19ordenID )) )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Clientedsc Changed */
                                    if ( StringUtil.StrCmp(cgiGet( "GXH_vCLIENTEDSC"), AV7ClienteDsc) != 0 )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Vehiculoplaca Changed */
                                    if ( StringUtil.StrCmp(cgiGet( "GXH_vVEHICULOPLACA"), AV29vehiculoPlaca) != 0 )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Vehiculochasis Changed */
                                    if ( StringUtil.StrCmp(cgiGet( "GXH_vVEHICULOCHASIS"), AV28vehiculoChasis) != 0 )
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

      protected void WE292( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm292( ) ;
            }
         }
      }

      protected void PA292( )
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
               GX_FocusControl = cmbavPeriod_Internalname;
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
         SubsflControlProps_382( ) ;
         while ( nGXsfl_38_idx <= nRC_GXsfl_38 )
         {
            sendrow_382( ) ;
            nGXsfl_38_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_38_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_38_idx+1));
            sGXsfl_38_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_38_idx), 4, 0)), 4, "0");
            SubsflControlProps_382( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV20period ,
                                       short AV19ordenID ,
                                       String AV7ClienteDsc ,
                                       String AV29vehiculoPlaca ,
                                       String AV28vehiculoChasis ,
                                       String AV26UserCod ,
                                       String AV34Pgmname ,
                                       String AV25Update ,
                                       String AV9Delete )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF292( ) ;
         /* End function gxgrGrid_refresh */
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
         if ( cmbavPeriod.ItemCount > 0 )
         {
            AV20period = (short)(NumberUtil.Val( cmbavPeriod.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV20period), 2, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20period", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20period), 2, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavPeriod.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV20period), 2, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPeriod_Internalname, "Values", cmbavPeriod.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF292( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV34Pgmname = "MantOrdenProduccion";
         context.Gx_err = 0;
         edtavUpdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Enabled), 5, 0)), !bGXsfl_38_Refreshing);
         edtavDelete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Enabled), 5, 0)), !bGXsfl_38_Refreshing);
      }

      protected void RF292( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 38;
         /* Execute user event: Refresh */
         E14292 ();
         nGXsfl_38_idx = 1;
         sGXsfl_38_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_38_idx), 4, 0)), 4, "0");
         SubsflControlProps_382( ) ;
         bGXsfl_38_Refreshing = true;
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
            SubsflControlProps_382( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV7ClienteDsc ,
                                                 AV29vehiculoPlaca ,
                                                 AV28vehiculoChasis ,
                                                 AV19ordenID ,
                                                 AV20period ,
                                                 AV26UserCod ,
                                                 A57ClienteDsc ,
                                                 A68VehiculoPlaca ,
                                                 A69VehiculoChasis ,
                                                 A22OrdenID ,
                                                 A24OrdenPeriodo ,
                                                 A116OrdenUser } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                                 TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV7ClienteDsc = StringUtil.PadR( StringUtil.RTrim( AV7ClienteDsc), 50, "%");
            lV29vehiculoPlaca = StringUtil.Concat( StringUtil.RTrim( AV29vehiculoPlaca), "%", "");
            lV28vehiculoChasis = StringUtil.Concat( StringUtil.RTrim( AV28vehiculoChasis), "%", "");
            /* Using cursor H00292 */
            pr_default.execute(0, new Object[] {lV7ClienteDsc, lV29vehiculoPlaca, lV28vehiculoChasis, AV19ordenID, AV20period, AV26UserCod, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_38_idx = 1;
            sGXsfl_38_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_38_idx), 4, 0)), 4, "0");
            SubsflControlProps_382( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A1EmpID = H00292_A1EmpID[0];
               A5ClienteID = H00292_A5ClienteID[0];
               A8VehiculoID = H00292_A8VehiculoID[0];
               A9vendedorID = H00292_A9vendedorID[0];
               A10protID = H00292_A10protID[0];
               A17tipOrdID = H00292_A17tipOrdID[0];
               A116OrdenUser = H00292_A116OrdenUser[0];
               n116OrdenUser = H00292_n116OrdenUser[0];
               A122protSiglas = H00292_A122protSiglas[0];
               n122protSiglas = H00292_n122protSiglas[0];
               A121VendedorSiglas = H00292_A121VendedorSiglas[0];
               n121VendedorSiglas = H00292_n121VendedorSiglas[0];
               A104tipOrdDsc = H00292_A104tipOrdDsc[0];
               n104tipOrdDsc = H00292_n104tipOrdDsc[0];
               A69VehiculoChasis = H00292_A69VehiculoChasis[0];
               n69VehiculoChasis = H00292_n69VehiculoChasis[0];
               A68VehiculoPlaca = H00292_A68VehiculoPlaca[0];
               n68VehiculoPlaca = H00292_n68VehiculoPlaca[0];
               A22OrdenID = H00292_A22OrdenID[0];
               A57ClienteDsc = H00292_A57ClienteDsc[0];
               n57ClienteDsc = H00292_n57ClienteDsc[0];
               A106facturaNro = H00292_A106facturaNro[0];
               n106facturaNro = H00292_n106facturaNro[0];
               A119OrdenFch = H00292_A119OrdenFch[0];
               n119OrdenFch = H00292_n119OrdenFch[0];
               A24OrdenPeriodo = H00292_A24OrdenPeriodo[0];
               A25OrdenAnio = H00292_A25OrdenAnio[0];
               A57ClienteDsc = H00292_A57ClienteDsc[0];
               n57ClienteDsc = H00292_n57ClienteDsc[0];
               A69VehiculoChasis = H00292_A69VehiculoChasis[0];
               n69VehiculoChasis = H00292_n69VehiculoChasis[0];
               A68VehiculoPlaca = H00292_A68VehiculoPlaca[0];
               n68VehiculoPlaca = H00292_n68VehiculoPlaca[0];
               A121VendedorSiglas = H00292_A121VendedorSiglas[0];
               n121VendedorSiglas = H00292_n121VendedorSiglas[0];
               A122protSiglas = H00292_A122protSiglas[0];
               n122protSiglas = H00292_n122protSiglas[0];
               A104tipOrdDsc = H00292_A104tipOrdDsc[0];
               n104tipOrdDsc = H00292_n104tipOrdDsc[0];
               E15292 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 38;
            WB290( ) ;
         }
         bGXsfl_38_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes292( )
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
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV7ClienteDsc ,
                                              AV29vehiculoPlaca ,
                                              AV28vehiculoChasis ,
                                              AV19ordenID ,
                                              AV20period ,
                                              AV26UserCod ,
                                              A57ClienteDsc ,
                                              A68VehiculoPlaca ,
                                              A69VehiculoChasis ,
                                              A22OrdenID ,
                                              A24OrdenPeriodo ,
                                              A116OrdenUser } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV7ClienteDsc = StringUtil.PadR( StringUtil.RTrim( AV7ClienteDsc), 50, "%");
         lV29vehiculoPlaca = StringUtil.Concat( StringUtil.RTrim( AV29vehiculoPlaca), "%", "");
         lV28vehiculoChasis = StringUtil.Concat( StringUtil.RTrim( AV28vehiculoChasis), "%", "");
         /* Using cursor H00293 */
         pr_default.execute(1, new Object[] {lV7ClienteDsc, lV29vehiculoPlaca, lV28vehiculoChasis, AV19ordenID, AV20period, AV26UserCod});
         GRID_nRecordCount = H00293_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV20period, AV19ordenID, AV7ClienteDsc, AV29vehiculoPlaca, AV28vehiculoChasis, AV26UserCod, AV34Pgmname, AV25Update, AV9Delete) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV20period, AV19ordenID, AV7ClienteDsc, AV29vehiculoPlaca, AV28vehiculoChasis, AV26UserCod, AV34Pgmname, AV25Update, AV9Delete) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV20period, AV19ordenID, AV7ClienteDsc, AV29vehiculoPlaca, AV28vehiculoChasis, AV26UserCod, AV34Pgmname, AV25Update, AV9Delete) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV20period, AV19ordenID, AV7ClienteDsc, AV29vehiculoPlaca, AV28vehiculoChasis, AV26UserCod, AV34Pgmname, AV25Update, AV9Delete) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV20period, AV19ordenID, AV7ClienteDsc, AV29vehiculoPlaca, AV28vehiculoChasis, AV26UserCod, AV34Pgmname, AV25Update, AV9Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP290( )
      {
         /* Before Start, stand alone formulas. */
         AV34Pgmname = "MantOrdenProduccion";
         context.Gx_err = 0;
         edtavUpdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Enabled), 5, 0)), !bGXsfl_38_Refreshing);
         edtavDelete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Enabled), 5, 0)), !bGXsfl_38_Refreshing);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E13292 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            cmbavPeriod.Name = cmbavPeriod_Internalname;
            cmbavPeriod.CurrentValue = cgiGet( cmbavPeriod_Internalname);
            AV20period = (short)(NumberUtil.Val( cgiGet( cmbavPeriod_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20period", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20period), 2, 0)));
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrdenid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrdenid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDENID");
               GX_FocusControl = edtavOrdenid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV19ordenID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ordenID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19ordenID), 4, 0)));
            }
            else
            {
               AV19ordenID = (short)(context.localUtil.CToN( cgiGet( edtavOrdenid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ordenID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19ordenID), 4, 0)));
            }
            AV7ClienteDsc = cgiGet( edtavClientedsc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ClienteDsc", AV7ClienteDsc);
            AV29vehiculoPlaca = cgiGet( edtavVehiculoplaca_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29vehiculoPlaca", AV29vehiculoPlaca);
            AV28vehiculoChasis = cgiGet( edtavVehiculochasis_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28vehiculoChasis", AV28vehiculoChasis);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavYear_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavYear_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vYEAR");
               GX_FocusControl = edtavYear_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV30year = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30year", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30year), 4, 0)));
            }
            else
            {
               AV30year = (short)(context.localUtil.CToN( cgiGet( edtavYear_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30year", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30year), 4, 0)));
            }
            /* Read saved values. */
            nRC_GXsfl_38 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_38"), ",", "."));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID_nFirstRecordOnPage"), ",", "."));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID_nEOF"), ",", "."));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ",", "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vPERIOD"), ",", ".") != Convert.ToDecimal( AV20period )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDENID"), ",", ".") != Convert.ToDecimal( AV19ordenID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCLIENTEDSC"), AV7ClienteDsc) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vVEHICULOPLACA"), AV29vehiculoPlaca) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vVEHICULOCHASIS"), AV28vehiculoChasis) != 0 )
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
         E13292 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E13292( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV34Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV34Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         subGrid_Rows = 10;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GXt_char1 = AV21rolUser;
         new obtrolusuario(context ).execute(  AV26UserCod, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26UserCod", AV26UserCod);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSERCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV26UserCod, "")), context));
         AV21rolUser = GXt_char1;
         if ( StringUtil.StrCmp(AV21rolUser, "ADM") == 0 )
         {
            AV25Update = "Modificar";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV25Update);
         }
         else
         {
            edtavUpdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_38_Refreshing);
         }
         AV9Delete = "Eliminar";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV9Delete);
         Form.Caption = "Orden Produccion";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
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
         edtavYear_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavYear_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavYear_Visible), 5, 0)), true);
      }

      protected void E14292( )
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

      private void E15292( )
      {
         /* Grid_Load Routine */
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 38;
         }
         sendrow_382( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_38_Refreshing )
         {
            context.DoAjaxLoad(38, GridRow);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV17HTTPRequest.Method, "GET") == 0 )
         {
            AV15GridState.FromXml(AV22Session.Get(AV34Pgmname+"GridState"), null, "GridState", "KBCalpesa22");
            if ( AV15GridState.gxTpr_Filtervalues.Count >= 1 )
            {
               AV7ClienteDsc = ((SdtGridState_FilterValue)AV15GridState.gxTpr_Filtervalues.Item(1)).gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ClienteDsc", AV7ClienteDsc);
            }
            if ( AV15GridState.gxTpr_Currentpage > 0 )
            {
               AV14GridPageCount = subGrid_Pagecount( );
               if ( ( AV14GridPageCount > 0 ) && ( AV14GridPageCount < AV15GridState.gxTpr_Currentpage ) )
               {
                  subgrid_gotopage( AV14GridPageCount) ;
               }
               else
               {
                  subgrid_gotopage( AV15GridState.gxTpr_Currentpage) ;
               }
            }
         }
      }

      protected void S132( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV15GridState.FromXml(AV22Session.Get(AV34Pgmname+"GridState"), null, "GridState", "KBCalpesa22");
         AV15GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         AV15GridState.gxTpr_Filtervalues.Clear();
         AV16GridStateFilterValue = new SdtGridState_FilterValue(context);
         AV16GridStateFilterValue.gxTpr_Value = AV7ClienteDsc;
         AV15GridState.gxTpr_Filtervalues.Add(AV16GridStateFilterValue, 0);
         AV22Session.Set(AV34Pgmname+"GridState", AV15GridState.ToXml(false, true, "GridState", "KBCalpesa22"));
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV23TrnContext = new SdtTransactionContext(context);
         AV23TrnContext.gxTpr_Callerobject = AV34Pgmname;
         AV23TrnContext.gxTpr_Callerondelete = true;
         AV23TrnContext.gxTpr_Callerurl = AV17HTTPRequest.ScriptName+"?"+AV17HTTPRequest.QueryString;
         AV23TrnContext.gxTpr_Transactionname = "OrdenProduccion";
         AV22Session.Set("TrnContext", AV23TrnContext.ToXml(false, true, "TransactionContext", "KBCalpesa22"));
      }

      protected void E12292( )
      {
         /* Period_Click Routine */
         AV13fechaAux = DateTimeUtil.ResetTime(DateTimeUtil.ServerNow( context, pr_default));
         AV8day = 1;
         AV30year = (short)(DateTimeUtil.Year( AV13fechaAux));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30year", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30year), 4, 0)));
         AV11fchDesd = context.localUtil.YMDToD( AV30year, AV20period, AV8day);
         AV12fchHast = DateTimeUtil.DateEndOfMonth( AV11fchDesd);
         AV31mensj = "fecha: " + context.localUtil.DToC( AV11fchDesd, 4, "/") + " - " + context.localUtil.DToC( AV12fchHast, 4, "/") + " :" + StringUtil.Str( (decimal)(AV30year), 4, 0);
         /*  Sending Event outputs  */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV10empID = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10empID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10empID), 4, 0)));
         AV6ageID = Convert.ToInt16(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6ageID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6ageID), 4, 0)));
         AV26UserCod = (String)getParm(obj,2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26UserCod", AV26UserCod);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSERCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV26UserCod, "")), context));
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
         PA292( ) ;
         WS292( ) ;
         WE292( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20231141155947", true);
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
            context.AddJavascriptSource("mantordenproduccion.js", "?20231141155947", false);
         }
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_382( )
      {
         edtOrdenAnio_Internalname = "ORDENANIO_"+sGXsfl_38_idx;
         edtOrdenPeriodo_Internalname = "ORDENPERIODO_"+sGXsfl_38_idx;
         edtOrdenFch_Internalname = "ORDENFCH_"+sGXsfl_38_idx;
         edtfacturaNro_Internalname = "FACTURANRO_"+sGXsfl_38_idx;
         edtClienteDsc_Internalname = "CLIENTEDSC_"+sGXsfl_38_idx;
         edtOrdenID_Internalname = "ORDENID_"+sGXsfl_38_idx;
         edtVehiculoPlaca_Internalname = "VEHICULOPLACA_"+sGXsfl_38_idx;
         edtVehiculoChasis_Internalname = "VEHICULOCHASIS_"+sGXsfl_38_idx;
         edttipOrdDsc_Internalname = "TIPORDDSC_"+sGXsfl_38_idx;
         edtVendedorSiglas_Internalname = "VENDEDORSIGLAS_"+sGXsfl_38_idx;
         edtprotSiglas_Internalname = "PROTSIGLAS_"+sGXsfl_38_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_38_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_38_idx;
      }

      protected void SubsflControlProps_fel_382( )
      {
         edtOrdenAnio_Internalname = "ORDENANIO_"+sGXsfl_38_fel_idx;
         edtOrdenPeriodo_Internalname = "ORDENPERIODO_"+sGXsfl_38_fel_idx;
         edtOrdenFch_Internalname = "ORDENFCH_"+sGXsfl_38_fel_idx;
         edtfacturaNro_Internalname = "FACTURANRO_"+sGXsfl_38_fel_idx;
         edtClienteDsc_Internalname = "CLIENTEDSC_"+sGXsfl_38_fel_idx;
         edtOrdenID_Internalname = "ORDENID_"+sGXsfl_38_fel_idx;
         edtVehiculoPlaca_Internalname = "VEHICULOPLACA_"+sGXsfl_38_fel_idx;
         edtVehiculoChasis_Internalname = "VEHICULOCHASIS_"+sGXsfl_38_fel_idx;
         edttipOrdDsc_Internalname = "TIPORDDSC_"+sGXsfl_38_fel_idx;
         edtVendedorSiglas_Internalname = "VENDEDORSIGLAS_"+sGXsfl_38_fel_idx;
         edtprotSiglas_Internalname = "PROTSIGLAS_"+sGXsfl_38_fel_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_38_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_38_fel_idx;
      }

      protected void sendrow_382( )
      {
         SubsflControlProps_382( ) ;
         WB290( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_38_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_38_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_38_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenAnio_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A25OrdenAnio), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A25OrdenAnio), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenAnio_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)60,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)38,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenPeriodo_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A24OrdenPeriodo), 2, 0, ",", "")),context.localUtil.Format( (decimal)(A24OrdenPeriodo), "Z9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenPeriodo_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)60,(String)"px",(short)17,(String)"px",(short)2,(short)0,(short)0,(short)38,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenFch_Internalname,context.localUtil.Format(A119OrdenFch, "99/99/9999"),context.localUtil.Format( A119OrdenFch, "99/99/9999"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenFch_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)38,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtfacturaNro_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A106facturaNro), 8, 0, ",", "")),context.localUtil.Format( (decimal)(A106facturaNro), "ZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtfacturaNro_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)38,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClienteDsc_Internalname,StringUtil.RTrim( A57ClienteDsc),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtClienteDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)38,(short)1,(short)-1,(short)-1,(bool)true,(String)"Descripcion",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A22OrdenID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A22OrdenID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)38,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVehiculoPlaca_Internalname,(String)A68VehiculoPlaca,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtVehiculoPlaca_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)38,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVehiculoChasis_Internalname,(String)A69VehiculoChasis,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtVehiculoChasis_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)38,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edttipOrdDsc_Internalname,StringUtil.RTrim( A104tipOrdDsc),StringUtil.RTrim( context.localUtil.Format( A104tipOrdDsc, "@!")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edttipOrdDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)38,(short)1,(short)-1,(short)-1,(bool)true,(String)"nombres",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVendedorSiglas_Internalname,(String)A121VendedorSiglas,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtVendedorSiglas_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)5,(short)0,(short)0,(short)38,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtprotSiglas_Internalname,(String)A122protSiglas,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtprotSiglas_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)5,(short)0,(short)0,(short)38,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "TextActionAttribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,StringUtil.RTrim( AV25Update),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavUpdate_Jsonclick,(short)0,(String)"TextActionAttribute",(String)"",(String)ROClassString,(String)"WWTextActionColumn",(String)"",(int)edtavUpdate_Visible,(int)edtavUpdate_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)38,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "TextActionAttribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,StringUtil.RTrim( AV9Delete),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavDelete_Jsonclick,(short)0,(String)"TextActionAttribute",(String)"",(String)ROClassString,(String)"WWTextActionColumn",(String)"",(short)-1,(int)edtavDelete_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)38,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes292( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_38_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_38_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_38_idx+1));
            sGXsfl_38_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_38_idx), 4, 0)), 4, "0");
            SubsflControlProps_382( ) ;
         }
         /* End function sendrow_382 */
      }

      protected void init_web_controls( )
      {
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
         cmbavPeriod.addItem("9", "Septiemnbre", 0);
         cmbavPeriod.addItem("10", "Octubre", 0);
         cmbavPeriod.addItem("11", "Noviembre", 0);
         cmbavPeriod.addItem("12", "Diciembre", 0);
         if ( cmbavPeriod.ItemCount > 0 )
         {
            AV20period = (short)(NumberUtil.Val( cmbavPeriod.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV20period), 2, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20period", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20period), 2, 0)));
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTitletext_Internalname = "TITLETEXT";
         bttBtninsert_Internalname = "BTNINSERT";
         cmbavPeriod_Internalname = "vPERIOD";
         edtavOrdenid_Internalname = "vORDENID";
         edtavClientedsc_Internalname = "vCLIENTEDSC";
         edtavVehiculoplaca_Internalname = "vVEHICULOPLACA";
         edtavVehiculochasis_Internalname = "vVEHICULOCHASIS";
         divTabletop1_Internalname = "TABLETOP1";
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
         edtprotSiglas_Internalname = "PROTSIGLAS";
         edtavUpdate_Internalname = "vUPDATE";
         edtavDelete_Internalname = "vDELETE";
         divGridtable_Internalname = "GRIDTABLE";
         edtavYear_Internalname = "vYEAR";
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
         edtavDelete_Jsonclick = "";
         edtavUpdate_Jsonclick = "";
         edtprotSiglas_Jsonclick = "";
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
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         subGrid_Header = "";
         edtavDelete_Enabled = 0;
         edtavUpdate_Enabled = 0;
         subGrid_Class = "WorkWith";
         subGrid_Backcolorstyle = 0;
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
         Form.Caption = "Mant Orden Produccion";
         subGrid_Rows = 10;
         edtavUpdate_Visible = -1;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPeriod'},{av:'AV20period',fld:'vPERIOD',pic:'Z9'},{av:'AV19ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV29vehiculoPlaca',fld:'vVEHICULOPLACA',pic:''},{av:'AV28vehiculoChasis',fld:'vVEHICULOCHASIS',pic:''},{av:'AV25Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV9Delete',fld:'vDELETE',pic:''},{av:'AV34Pgmname',fld:'vPGMNAME',pic:''},{av:'AV7ClienteDsc',fld:'vCLIENTEDSC',pic:''},{av:'AV26UserCod',fld:'vUSERCOD',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("GRID.LOAD","{handler:'E15292',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[]}");
         setEventMetadata("'DOINSERT'","{handler:'E11291',iparms:[]");
         setEventMetadata("'DOINSERT'",",oparms:[]}");
         setEventMetadata("VPERIOD.CLICK","{handler:'E12292',iparms:[{av:'cmbavPeriod'},{av:'AV20period',fld:'vPERIOD',pic:'Z9'}]");
         setEventMetadata("VPERIOD.CLICK",",oparms:[{av:'AV30year',fld:'vYEAR',pic:'ZZZ9'}]}");
         setEventMetadata("GRID_FIRSTPAGE","{handler:'subgrid_firstpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPeriod'},{av:'AV20period',fld:'vPERIOD',pic:'Z9'},{av:'AV19ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV29vehiculoPlaca',fld:'vVEHICULOPLACA',pic:''},{av:'AV28vehiculoChasis',fld:'vVEHICULOCHASIS',pic:''},{av:'AV26UserCod',fld:'vUSERCOD',pic:'',hsh:true},{av:'AV25Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV9Delete',fld:'vDELETE',pic:''},{av:'AV34Pgmname',fld:'vPGMNAME',pic:''},{av:'AV7ClienteDsc',fld:'vCLIENTEDSC',pic:''}]");
         setEventMetadata("GRID_FIRSTPAGE",",oparms:[]}");
         setEventMetadata("GRID_PREVPAGE","{handler:'subgrid_previouspage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPeriod'},{av:'AV20period',fld:'vPERIOD',pic:'Z9'},{av:'AV19ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV29vehiculoPlaca',fld:'vVEHICULOPLACA',pic:''},{av:'AV28vehiculoChasis',fld:'vVEHICULOCHASIS',pic:''},{av:'AV26UserCod',fld:'vUSERCOD',pic:'',hsh:true},{av:'AV25Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV9Delete',fld:'vDELETE',pic:''},{av:'AV34Pgmname',fld:'vPGMNAME',pic:''},{av:'AV7ClienteDsc',fld:'vCLIENTEDSC',pic:''}]");
         setEventMetadata("GRID_PREVPAGE",",oparms:[]}");
         setEventMetadata("GRID_NEXTPAGE","{handler:'subgrid_nextpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPeriod'},{av:'AV20period',fld:'vPERIOD',pic:'Z9'},{av:'AV19ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV29vehiculoPlaca',fld:'vVEHICULOPLACA',pic:''},{av:'AV28vehiculoChasis',fld:'vVEHICULOCHASIS',pic:''},{av:'AV26UserCod',fld:'vUSERCOD',pic:'',hsh:true},{av:'AV25Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV9Delete',fld:'vDELETE',pic:''},{av:'AV34Pgmname',fld:'vPGMNAME',pic:''},{av:'AV7ClienteDsc',fld:'vCLIENTEDSC',pic:''}]");
         setEventMetadata("GRID_NEXTPAGE",",oparms:[]}");
         setEventMetadata("GRID_LASTPAGE","{handler:'subgrid_lastpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPeriod'},{av:'AV20period',fld:'vPERIOD',pic:'Z9'},{av:'AV19ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV29vehiculoPlaca',fld:'vVEHICULOPLACA',pic:''},{av:'AV28vehiculoChasis',fld:'vVEHICULOCHASIS',pic:''},{av:'AV26UserCod',fld:'vUSERCOD',pic:'',hsh:true},{av:'AV25Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV9Delete',fld:'vDELETE',pic:''},{av:'AV34Pgmname',fld:'vPGMNAME',pic:''},{av:'AV7ClienteDsc',fld:'vCLIENTEDSC',pic:''}]");
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
         wcpOAV26UserCod = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV25Update = "";
         AV9Delete = "";
         AV7ClienteDsc = "";
         AV29vehiculoPlaca = "";
         AV28vehiculoChasis = "";
         AV34Pgmname = "";
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
         A119OrdenFch = DateTime.MinValue;
         A57ClienteDsc = "";
         A68VehiculoPlaca = "";
         A69VehiculoChasis = "";
         A104tipOrdDsc = "";
         A121VendedorSiglas = "";
         A122protSiglas = "";
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         lV7ClienteDsc = "";
         lV29vehiculoPlaca = "";
         lV28vehiculoChasis = "";
         A116OrdenUser = "";
         H00292_A1EmpID = new short[1] ;
         H00292_A5ClienteID = new short[1] ;
         H00292_A8VehiculoID = new short[1] ;
         H00292_A9vendedorID = new short[1] ;
         H00292_A10protID = new short[1] ;
         H00292_A17tipOrdID = new short[1] ;
         H00292_A116OrdenUser = new String[] {""} ;
         H00292_n116OrdenUser = new bool[] {false} ;
         H00292_A122protSiglas = new String[] {""} ;
         H00292_n122protSiglas = new bool[] {false} ;
         H00292_A121VendedorSiglas = new String[] {""} ;
         H00292_n121VendedorSiglas = new bool[] {false} ;
         H00292_A104tipOrdDsc = new String[] {""} ;
         H00292_n104tipOrdDsc = new bool[] {false} ;
         H00292_A69VehiculoChasis = new String[] {""} ;
         H00292_n69VehiculoChasis = new bool[] {false} ;
         H00292_A68VehiculoPlaca = new String[] {""} ;
         H00292_n68VehiculoPlaca = new bool[] {false} ;
         H00292_A22OrdenID = new short[1] ;
         H00292_A57ClienteDsc = new String[] {""} ;
         H00292_n57ClienteDsc = new bool[] {false} ;
         H00292_A106facturaNro = new int[1] ;
         H00292_n106facturaNro = new bool[] {false} ;
         H00292_A119OrdenFch = new DateTime[] {DateTime.MinValue} ;
         H00292_n119OrdenFch = new bool[] {false} ;
         H00292_A24OrdenPeriodo = new short[1] ;
         H00292_A25OrdenAnio = new short[1] ;
         H00293_AGRID_nRecordCount = new long[1] ;
         AV21rolUser = "";
         GXt_char1 = "";
         GridRow = new GXWebRow();
         AV17HTTPRequest = new GxHttpRequest( context);
         AV15GridState = new SdtGridState(context);
         AV22Session = context.GetSession();
         AV16GridStateFilterValue = new SdtGridState_FilterValue(context);
         AV23TrnContext = new SdtTransactionContext(context);
         AV13fechaAux = DateTime.MinValue;
         AV11fchDesd = DateTime.MinValue;
         AV12fchHast = DateTime.MinValue;
         AV31mensj = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.mantordenproduccion__default(),
            new Object[][] {
                new Object[] {
               H00292_A1EmpID, H00292_A5ClienteID, H00292_A8VehiculoID, H00292_A9vendedorID, H00292_A10protID, H00292_A17tipOrdID, H00292_A116OrdenUser, H00292_n116OrdenUser, H00292_A122protSiglas, H00292_n122protSiglas,
               H00292_A121VendedorSiglas, H00292_n121VendedorSiglas, H00292_A104tipOrdDsc, H00292_n104tipOrdDsc, H00292_A69VehiculoChasis, H00292_n69VehiculoChasis, H00292_A68VehiculoPlaca, H00292_n68VehiculoPlaca, H00292_A22OrdenID, H00292_A57ClienteDsc,
               H00292_n57ClienteDsc, H00292_A106facturaNro, H00292_n106facturaNro, H00292_A119OrdenFch, H00292_n119OrdenFch, H00292_A24OrdenPeriodo, H00292_A25OrdenAnio
               }
               , new Object[] {
               H00293_AGRID_nRecordCount
               }
            }
         );
         AV34Pgmname = "MantOrdenProduccion";
         /* GeneXus formulas. */
         AV34Pgmname = "MantOrdenProduccion";
         context.Gx_err = 0;
         edtavUpdate_Enabled = 0;
         edtavDelete_Enabled = 0;
      }

      private short AV10empID ;
      private short AV6ageID ;
      private short wcpOAV10empID ;
      private short wcpOAV6ageID ;
      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_38 ;
      private short nGXsfl_38_idx=1 ;
      private short GRID_nEOF ;
      private short AV20period ;
      private short AV19ordenID ;
      private short initialized ;
      private short nGXWrapped ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short A25OrdenAnio ;
      private short A24OrdenPeriodo ;
      private short A22OrdenID ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short AV30year ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short A1EmpID ;
      private short A5ClienteID ;
      private short A8VehiculoID ;
      private short A9vendedorID ;
      private short A10protID ;
      private short A17tipOrdID ;
      private short AV8day ;
      private short subGrid_Backstyle ;
      private int edtavUpdate_Visible ;
      private int subGrid_Rows ;
      private int edtavUpdate_Enabled ;
      private int edtavDelete_Enabled ;
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
      private int edtavYear_Enabled ;
      private int edtavYear_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV14GridPageCount ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String AV26UserCod ;
      private String wcpOAV26UserCod ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_38_idx="0001" ;
      private String AV25Update ;
      private String edtavUpdate_Internalname ;
      private String AV9Delete ;
      private String AV7ClienteDsc ;
      private String AV34Pgmname ;
      private String GXKey ;
      private String edtavDelete_Internalname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
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
      private String divGridtable_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String subGrid_Header ;
      private String A57ClienteDsc ;
      private String A104tipOrdDsc ;
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
      private String edtprotSiglas_Internalname ;
      private String scmdbuf ;
      private String lV7ClienteDsc ;
      private String A116OrdenUser ;
      private String AV21rolUser ;
      private String GXt_char1 ;
      private String sGXsfl_38_fel_idx="0001" ;
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
      private String edtprotSiglas_Jsonclick ;
      private String edtavUpdate_Jsonclick ;
      private String edtavDelete_Jsonclick ;
      private DateTime A119OrdenFch ;
      private DateTime AV13fechaAux ;
      private DateTime AV11fchDesd ;
      private DateTime AV12fchHast ;
      private bool entryPointCalled ;
      private bool bGXsfl_38_Refreshing=false ;
      private bool toggleJsOutput ;
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
      private bool n122protSiglas ;
      private bool gxdyncontrolsrefreshing ;
      private bool n116OrdenUser ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private String AV31mensj ;
      private String AV29vehiculoPlaca ;
      private String AV28vehiculoChasis ;
      private String A68VehiculoPlaca ;
      private String A69VehiculoChasis ;
      private String A121VendedorSiglas ;
      private String A122protSiglas ;
      private String lV29vehiculoPlaca ;
      private String lV28vehiculoChasis ;
      private IGxSession AV22Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavPeriod ;
      private IDataStoreProvider pr_default ;
      private short[] H00292_A1EmpID ;
      private short[] H00292_A5ClienteID ;
      private short[] H00292_A8VehiculoID ;
      private short[] H00292_A9vendedorID ;
      private short[] H00292_A10protID ;
      private short[] H00292_A17tipOrdID ;
      private String[] H00292_A116OrdenUser ;
      private bool[] H00292_n116OrdenUser ;
      private String[] H00292_A122protSiglas ;
      private bool[] H00292_n122protSiglas ;
      private String[] H00292_A121VendedorSiglas ;
      private bool[] H00292_n121VendedorSiglas ;
      private String[] H00292_A104tipOrdDsc ;
      private bool[] H00292_n104tipOrdDsc ;
      private String[] H00292_A69VehiculoChasis ;
      private bool[] H00292_n69VehiculoChasis ;
      private String[] H00292_A68VehiculoPlaca ;
      private bool[] H00292_n68VehiculoPlaca ;
      private short[] H00292_A22OrdenID ;
      private String[] H00292_A57ClienteDsc ;
      private bool[] H00292_n57ClienteDsc ;
      private int[] H00292_A106facturaNro ;
      private bool[] H00292_n106facturaNro ;
      private DateTime[] H00292_A119OrdenFch ;
      private bool[] H00292_n119OrdenFch ;
      private short[] H00292_A24OrdenPeriodo ;
      private short[] H00292_A25OrdenAnio ;
      private long[] H00293_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV17HTTPRequest ;
      private SdtGridState AV15GridState ;
      private SdtGridState_FilterValue AV16GridStateFilterValue ;
      private SdtTransactionContext AV23TrnContext ;
   }

   public class mantordenproduccion__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00292( IGxContext context ,
                                             String AV7ClienteDsc ,
                                             String AV29vehiculoPlaca ,
                                             String AV28vehiculoChasis ,
                                             short AV19ordenID ,
                                             short AV20period ,
                                             String AV26UserCod ,
                                             String A57ClienteDsc ,
                                             String A68VehiculoPlaca ,
                                             String A69VehiculoChasis ,
                                             short A22OrdenID ,
                                             short A24OrdenPeriodo ,
                                             String A116OrdenUser )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [9] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " T1.[EmpID], T1.[ClienteID], T1.[VehiculoID], T1.[vendedorID], T1.[protID], T1.[tipOrdID], T1.[OrdenUser], T5.[protSiglas], T4.[VendedorSiglas], T6.[tipOrdDsc], T3.[VehiculoChasis], T3.[VehiculoPlaca], T1.[OrdenID], T2.[ClienteDsc], T1.[facturaNro], T1.[OrdenFch], T1.[OrdenPeriodo], T1.[OrdenAnio]";
         sFromString = " FROM ((((([OrdenProduccion] T1 WITH (NOLOCK) INNER JOIN [Clientes] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[ClienteID] = T1.[ClienteID]) INNER JOIN [Vehiculos] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[VehiculoID] = T1.[VehiculoID]) INNER JOIN [Vendedor] T4 WITH (NOLOCK) ON T4.[EmpID] = T1.[EmpID] AND T4.[vendedorID] = T1.[vendedorID]) INNER JOIN [Prototipo] T5 WITH (NOLOCK) ON T5.[EmpID] = T1.[EmpID] AND T5.[protID] = T1.[protID]) INNER JOIN [TipoOrdenPro] T6 WITH (NOLOCK) ON T6.[EmpID] = T1.[EmpID] AND T6.[tipOrdID] = T1.[tipOrdID])";
         sOrderString = "";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7ClienteDsc)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[ClienteDsc] like '%' + @lV7ClienteDsc + '%')";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[ClienteDsc] like '%' + @lV7ClienteDsc + '%')";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV29vehiculoPlaca)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[VehiculoPlaca] like @lV29vehiculoPlaca)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[VehiculoPlaca] like @lV29vehiculoPlaca)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV28vehiculoChasis)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[VehiculoChasis] like @lV28vehiculoChasis)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[VehiculoChasis] like @lV28vehiculoChasis)";
            }
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ! (0==AV19ordenID) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[OrdenID] = @AV19ordenID)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[OrdenID] = @AV19ordenID)";
            }
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( ! (0==AV20period) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[OrdenPeriodo] = @AV20period)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[OrdenPeriodo] = @AV20period)";
            }
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( ( StringUtil.StrCmp(AV26UserCod, "ADM") != 0 ) || ( StringUtil.StrCmp(AV26UserCod, "CCALDERON") != 0 ) || ( StringUtil.StrCmp(AV26UserCod, "ECALDERON") != 0 ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[OrdenUser] = @AV26UserCod)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[OrdenUser] = @AV26UserCod)";
            }
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         sOrderString = sOrderString + " ORDER BY T1.[OrdenID], T1.[OrdenFch]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_H00293( IGxContext context ,
                                             String AV7ClienteDsc ,
                                             String AV29vehiculoPlaca ,
                                             String AV28vehiculoChasis ,
                                             short AV19ordenID ,
                                             short AV20period ,
                                             String AV26UserCod ,
                                             String A57ClienteDsc ,
                                             String A68VehiculoPlaca ,
                                             String A69VehiculoChasis ,
                                             short A22OrdenID ,
                                             short A24OrdenPeriodo ,
                                             String A116OrdenUser )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [6] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM ((((([OrdenProduccion] T1 WITH (NOLOCK) INNER JOIN [Clientes] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[ClienteID] = T1.[ClienteID]) INNER JOIN [Vehiculos] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[VehiculoID] = T1.[VehiculoID]) INNER JOIN [Vendedor] T4 WITH (NOLOCK) ON T4.[EmpID] = T1.[EmpID] AND T4.[vendedorID] = T1.[vendedorID]) INNER JOIN [Prototipo] T5 WITH (NOLOCK) ON T5.[EmpID] = T1.[EmpID] AND T5.[protID] = T1.[protID]) INNER JOIN [TipoOrdenPro] T6 WITH (NOLOCK) ON T6.[EmpID] = T1.[EmpID] AND T6.[tipOrdID] = T1.[tipOrdID])";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7ClienteDsc)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[ClienteDsc] like '%' + @lV7ClienteDsc + '%')";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[ClienteDsc] like '%' + @lV7ClienteDsc + '%')";
            }
         }
         else
         {
            GXv_int4[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV29vehiculoPlaca)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[VehiculoPlaca] like @lV29vehiculoPlaca)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[VehiculoPlaca] like @lV29vehiculoPlaca)";
            }
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV28vehiculoChasis)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[VehiculoChasis] like @lV28vehiculoChasis)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[VehiculoChasis] like @lV28vehiculoChasis)";
            }
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( ! (0==AV19ordenID) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[OrdenID] = @AV19ordenID)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[OrdenID] = @AV19ordenID)";
            }
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( ! (0==AV20period) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[OrdenPeriodo] = @AV20period)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[OrdenPeriodo] = @AV20period)";
            }
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( ( StringUtil.StrCmp(AV26UserCod, "ADM") != 0 ) || ( StringUtil.StrCmp(AV26UserCod, "CCALDERON") != 0 ) || ( StringUtil.StrCmp(AV26UserCod, "ECALDERON") != 0 ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[OrdenUser] = @AV26UserCod)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[OrdenUser] = @AV26UserCod)";
            }
         }
         else
         {
            GXv_int4[5] = 1;
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
                     return conditional_H00292(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (short)dynConstraints[9] , (short)dynConstraints[10] , (String)dynConstraints[11] );
               case 1 :
                     return conditional_H00293(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (short)dynConstraints[9] , (short)dynConstraints[10] , (String)dynConstraints[11] );
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
          Object[] prmH00292 ;
          prmH00292 = new Object[] {
          new Object[] {"@lV7ClienteDsc",SqlDbType.Char,50,0} ,
          new Object[] {"@lV29vehiculoPlaca",SqlDbType.VarChar,15,0} ,
          new Object[] {"@lV28vehiculoChasis",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV19ordenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV20period",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV26UserCod",SqlDbType.Char,15,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00293 ;
          prmH00293 = new Object[] {
          new Object[] {"@lV7ClienteDsc",SqlDbType.Char,50,0} ,
          new Object[] {"@lV29vehiculoPlaca",SqlDbType.VarChar,15,0} ,
          new Object[] {"@lV28vehiculoChasis",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV19ordenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV20period",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV26UserCod",SqlDbType.Char,15,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00292", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00292,11,0,true,false )
             ,new CursorDef("H00293", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00293,1,0,true,false )
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
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 40) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                ((String[]) buf[8])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((String[]) buf[10])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((String[]) buf[12])[0] = rslt.getString(10, 40) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                ((String[]) buf[14])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(11);
                ((String[]) buf[16])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(12);
                ((short[]) buf[18])[0] = rslt.getShort(13) ;
                ((String[]) buf[19])[0] = rslt.getString(14, 50) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(14);
                ((int[]) buf[21])[0] = rslt.getInt(15) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(15);
                ((DateTime[]) buf[23])[0] = rslt.getGXDate(16) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(16);
                ((short[]) buf[25])[0] = rslt.getShort(17) ;
                ((short[]) buf[26])[0] = rslt.getShort(18) ;
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
                   stmt.SetParameter(sIdx, (String)parms[9]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[12]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[13]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[15]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[16]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[17]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[6]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[8]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[9]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[10]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                return;
       }
    }

 }

}
