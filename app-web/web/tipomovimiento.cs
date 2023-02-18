/*
               File: TipoMovimiento
        Description: Tipo Movimiento
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 12/7/2022 0:51:17.92
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
using System.Runtime.Remoting;
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
   public class tipomovimiento : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
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
            Gx_mode = gxfirstwebparm;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV7TipoInv = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7TipoInv", AV7TipoInv);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vTIPOINV", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV7TipoInv, "")), context));
            }
         }
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
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
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "Tipo Movimiento", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtTipoInv_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public tipomovimiento( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public tipomovimiento( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           String aP1_TipoInv )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7TipoInv = aP1_TipoInv;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbTipoInvSigno = new GXCombobox();
         chkTipoInvEst = new GXCheckbox();
         radTipoInvUso = new GXRadio();
         radTipoInvTipo = new GXRadio();
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            ValidateSpaRequest();
            UserMain( ) ;
            if ( ! isFullAjaxMode( ) && ( nDynComponent == 0 ) )
            {
               Draw( ) ;
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

      protected void fix_multi_value_controls( )
      {
         if ( cmbTipoInvSigno.ItemCount > 0 )
         {
            A223TipoInvSigno = (short)(NumberUtil.Val( cmbTipoInvSigno.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0))), "."));
            n223TipoInvSigno = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223TipoInvSigno", StringUtil.LTrim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbTipoInvSigno.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTipoInvSigno_Internalname, "Values", cmbTipoInvSigno.ToJavascriptSource(), true);
         }
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            RenderHtmlHeaders( ) ;
            RenderHtmlOpenForm( ) ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "WWAdvancedContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTitlecontainer_Internalname, 1, 0, "px", 0, "px", "TableTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Tipo Movimiento", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_TipoMovimiento.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divFormcontainer_Internalname, 1, 0, "px", 0, "px", "FormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divToolbarcell_Internalname, 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3 ToolbarCellClass", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "btn-group", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"";
            ClassString = "BtnFirst";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_TipoMovimiento.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_TipoMovimiento.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_TipoMovimiento.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_TipoMovimiento.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 5, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_TipoMovimiento.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellAdvanced", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtTipoInv_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtTipoInv_Internalname, "Tipo ", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtTipoInv_Internalname, StringUtil.RTrim( A43TipoInv), StringUtil.RTrim( context.localUtil.Format( A43TipoInv, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtTipoInv_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtTipoInv_Enabled, 1, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_TipoMovimiento.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtTipoInvMov_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtTipoInvMov_Internalname, "Movimiento", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtTipoInvMov_Internalname, A219TipoInvMov, StringUtil.RTrim( context.localUtil.Format( A219TipoInvMov, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtTipoInvMov_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtTipoInvMov_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_TipoMovimiento.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbTipoInvSigno_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbTipoInvSigno_Internalname, "Signo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbTipoInvSigno, cmbTipoInvSigno_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0)), 1, cmbTipoInvSigno_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbTipoInvSigno.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "", true, "HLP_TipoMovimiento.htm");
            cmbTipoInvSigno.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTipoInvSigno_Internalname, "Values", (String)(cmbTipoInvSigno.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkTipoInvEst_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkTipoInvEst_Internalname, "Estado", "col-sm-3 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkTipoInvEst_Internalname, A220TipoInvEst, "", "Estado", 1, chkTipoInvEst.Enabled, "A", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(49, this, 'A', 'I');gx.evt.onchange(this, event);\" ");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 FormCell", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection2_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+radTipoInvUso_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, radTipoInvUso_Internalname, "Uso", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Radio button */
            ClassString = "Attribute";
            StyleString = "";
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'',0)\"";
            GxWebStd.gx_radio_ctrl( context, radTipoInvUso, radTipoInvUso_Internalname, StringUtil.RTrim( A222TipoInvUso), "", 1, radTipoInvUso.Enabled, 1, 1, StyleString, ClassString, "", "", 0, radTipoInvUso_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", TempTags+" onclick=\"gx.evt.onchange(this, event);\" ", "HLP_TipoMovimiento.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 FormCell", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection3_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+radTipoInvTipo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, radTipoInvTipo_Internalname, "Tipo", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Radio button */
            ClassString = "Attribute";
            StyleString = "";
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"";
            GxWebStd.gx_radio_ctrl( context, radTipoInvTipo, radTipoInvTipo_Internalname, StringUtil.RTrim( A224TipoInvTipo), "", 1, radTipoInvTipo.Enabled, 1, 1, StyleString, ClassString, "", "", 0, radTipoInvTipo_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", TempTags+" onclick=\"gx.evt.onchange(this, event);\" ", "HLP_TipoMovimiento.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group Confirm", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_TipoMovimiento.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_TipoMovimiento.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_TipoMovimiento.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm0N36( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void UserMainFullajax( )
      {
         INITENV( ) ;
         INITTRN( ) ;
         UserMain( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E110N2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A43TipoInv = cgiGet( edtTipoInv_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
               A219TipoInvMov = cgiGet( edtTipoInvMov_Internalname);
               n219TipoInvMov = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A219TipoInvMov", A219TipoInvMov);
               n219TipoInvMov = (String.IsNullOrEmpty(StringUtil.RTrim( A219TipoInvMov)) ? true : false);
               cmbTipoInvSigno.CurrentValue = cgiGet( cmbTipoInvSigno_Internalname);
               A223TipoInvSigno = (short)(NumberUtil.Val( cgiGet( cmbTipoInvSigno_Internalname), "."));
               n223TipoInvSigno = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223TipoInvSigno", StringUtil.LTrim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0)));
               n223TipoInvSigno = ((0==A223TipoInvSigno) ? true : false);
               A220TipoInvEst = ((StringUtil.StrCmp(cgiGet( chkTipoInvEst_Internalname), "A")==0) ? "A" : "I");
               n220TipoInvEst = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A220TipoInvEst", A220TipoInvEst);
               n220TipoInvEst = (String.IsNullOrEmpty(StringUtil.RTrim( A220TipoInvEst)) ? true : false);
               A222TipoInvUso = cgiGet( radTipoInvUso_Internalname);
               n222TipoInvUso = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A222TipoInvUso", A222TipoInvUso);
               n222TipoInvUso = (String.IsNullOrEmpty(StringUtil.RTrim( A222TipoInvUso)) ? true : false);
               A224TipoInvTipo = cgiGet( radTipoInvTipo_Internalname);
               n224TipoInvTipo = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A224TipoInvTipo", A224TipoInvTipo);
               n224TipoInvTipo = (String.IsNullOrEmpty(StringUtil.RTrim( A224TipoInvTipo)) ? true : false);
               /* Read saved values. */
               Z43TipoInv = cgiGet( "Z43TipoInv");
               Z219TipoInvMov = cgiGet( "Z219TipoInvMov");
               n219TipoInvMov = (String.IsNullOrEmpty(StringUtil.RTrim( A219TipoInvMov)) ? true : false);
               Z220TipoInvEst = cgiGet( "Z220TipoInvEst");
               n220TipoInvEst = (String.IsNullOrEmpty(StringUtil.RTrim( A220TipoInvEst)) ? true : false);
               Z221TipoInvActivo = cgiGet( "Z221TipoInvActivo");
               n221TipoInvActivo = (String.IsNullOrEmpty(StringUtil.RTrim( A221TipoInvActivo)) ? true : false);
               Z222TipoInvUso = cgiGet( "Z222TipoInvUso");
               n222TipoInvUso = (String.IsNullOrEmpty(StringUtil.RTrim( A222TipoInvUso)) ? true : false);
               Z223TipoInvSigno = (short)(context.localUtil.CToN( cgiGet( "Z223TipoInvSigno"), ",", "."));
               n223TipoInvSigno = ((0==A223TipoInvSigno) ? true : false);
               Z224TipoInvTipo = cgiGet( "Z224TipoInvTipo");
               n224TipoInvTipo = (String.IsNullOrEmpty(StringUtil.RTrim( A224TipoInvTipo)) ? true : false);
               A221TipoInvActivo = cgiGet( "Z221TipoInvActivo");
               n221TipoInvActivo = false;
               n221TipoInvActivo = (String.IsNullOrEmpty(StringUtil.RTrim( A221TipoInvActivo)) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               AV7TipoInv = cgiGet( "vTIPOINV");
               A221TipoInvActivo = cgiGet( "TIPOINVACTIVO");
               n221TipoInvActivo = (String.IsNullOrEmpty(StringUtil.RTrim( A221TipoInvActivo)) ? true : false);
               AV11Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "TipoMovimiento";
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A221TipoInvActivo, ""));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( StringUtil.StrCmp(A43TipoInv, Z43TipoInv) != 0 ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("tipomovimiento:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GXUtil.WriteLog("tipomovimiento:[SecurityCheckFailed value for]"+"TipoInvActivo:"+StringUtil.RTrim( context.localUtil.Format( A221TipoInvActivo, "")));
                  GxWebError = 1;
                  context.HttpContext.Response.StatusDescription = 403.ToString();
                  context.HttpContext.Response.StatusCode = 403;
                  context.WriteHtmlText( "<title>403 Forbidden</title>") ;
                  context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
                  context.WriteHtmlText( "<p /><hr />") ;
                  GXUtil.WriteLog("send_http_error_code " + 403.ToString());
                  AnyError = 1;
                  return  ;
               }
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  A43TipoInv = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
                  {
                     sMode36 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode36;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound36 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0N0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "TIPOINV");
                        AnyError = 1;
                        GX_FocusControl = edtTipoInv_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
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
                     if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: Start */
                        E110N2 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: After Trn */
                        E120N2 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                     {
                        context.wbHandled = 1;
                        if ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 )
                        {
                           btn_enter( ) ;
                        }
                        /* No code required for Cancel button. It is implemented as the Reset button. */
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

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E120N2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0N36( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         bttBtn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)), true);
         bttBtn_first_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_first_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_first_Visible), 5, 0)), true);
         bttBtn_previous_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_previous_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_previous_Visible), 5, 0)), true);
         bttBtn_next_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_next_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_next_Visible), 5, 0)), true);
         bttBtn_last_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_last_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_last_Visible), 5, 0)), true);
         bttBtn_select_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_select_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_select_Visible), 5, 0)), true);
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            bttBtn_delete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)), true);
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtn_enter_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)), true);
            }
            DisableAttributes0N36( ) ;
         }
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete", ""), 0, "", true);
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm", ""), 0, "", true);
            }
         }
      }

      protected void CONFIRM_0N0( )
      {
         BeforeValidate0N36( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0N36( ) ;
            }
            else
            {
               CheckExtendedTable0N36( ) ;
               CloseExtendedTableCursors0N36( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0N0( )
      {
      }

      protected void E110N2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV11Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "KBCalpesa22");
      }

      protected void E120N2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwtipomovimiento.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0N36( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z219TipoInvMov = T000N3_A219TipoInvMov[0];
               Z220TipoInvEst = T000N3_A220TipoInvEst[0];
               Z221TipoInvActivo = T000N3_A221TipoInvActivo[0];
               Z222TipoInvUso = T000N3_A222TipoInvUso[0];
               Z223TipoInvSigno = T000N3_A223TipoInvSigno[0];
               Z224TipoInvTipo = T000N3_A224TipoInvTipo[0];
            }
            else
            {
               Z219TipoInvMov = A219TipoInvMov;
               Z220TipoInvEst = A220TipoInvEst;
               Z221TipoInvActivo = A221TipoInvActivo;
               Z222TipoInvUso = A222TipoInvUso;
               Z223TipoInvSigno = A223TipoInvSigno;
               Z224TipoInvTipo = A224TipoInvTipo;
            }
         }
         if ( GX_JID == -4 )
         {
            Z43TipoInv = A43TipoInv;
            Z219TipoInvMov = A219TipoInvMov;
            Z220TipoInvEst = A220TipoInvEst;
            Z221TipoInvActivo = A221TipoInvActivo;
            Z222TipoInvUso = A222TipoInvUso;
            Z223TipoInvSigno = A223TipoInvSigno;
            Z224TipoInvTipo = A224TipoInvTipo;
         }
      }

      protected void standaloneNotModal( )
      {
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7TipoInv)) )
         {
            A43TipoInv = AV7TipoInv;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7TipoInv)) )
         {
            edtTipoInv_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoInv_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoInv_Enabled), 5, 0)), true);
         }
         else
         {
            edtTipoInv_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoInv_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoInv_Enabled), 5, 0)), true);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7TipoInv)) )
         {
            edtTipoInv_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoInv_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoInv_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)), true);
         }
         else
         {
            bttBtn_enter_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            AV11Pgmname = "TipoMovimiento";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Pgmname", AV11Pgmname);
         }
      }

      protected void Load0N36( )
      {
         /* Using cursor T000N4 */
         pr_default.execute(2, new Object[] {A43TipoInv});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound36 = 1;
            A219TipoInvMov = T000N4_A219TipoInvMov[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A219TipoInvMov", A219TipoInvMov);
            n219TipoInvMov = T000N4_n219TipoInvMov[0];
            A220TipoInvEst = T000N4_A220TipoInvEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A220TipoInvEst", A220TipoInvEst);
            n220TipoInvEst = T000N4_n220TipoInvEst[0];
            A221TipoInvActivo = T000N4_A221TipoInvActivo[0];
            n221TipoInvActivo = T000N4_n221TipoInvActivo[0];
            A222TipoInvUso = T000N4_A222TipoInvUso[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A222TipoInvUso", A222TipoInvUso);
            n222TipoInvUso = T000N4_n222TipoInvUso[0];
            A223TipoInvSigno = T000N4_A223TipoInvSigno[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223TipoInvSigno", StringUtil.LTrim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0)));
            n223TipoInvSigno = T000N4_n223TipoInvSigno[0];
            A224TipoInvTipo = T000N4_A224TipoInvTipo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A224TipoInvTipo", A224TipoInvTipo);
            n224TipoInvTipo = T000N4_n224TipoInvTipo[0];
            ZM0N36( -4) ;
         }
         pr_default.close(2);
         OnLoadActions0N36( ) ;
      }

      protected void OnLoadActions0N36( )
      {
         AV11Pgmname = "TipoMovimiento";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Pgmname", AV11Pgmname);
      }

      protected void CheckExtendedTable0N36( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV11Pgmname = "TipoMovimiento";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Pgmname", AV11Pgmname);
      }

      protected void CloseExtendedTableCursors0N36( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0N36( )
      {
         /* Using cursor T000N5 */
         pr_default.execute(3, new Object[] {A43TipoInv});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound36 = 1;
         }
         else
         {
            RcdFound36 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000N3 */
         pr_default.execute(1, new Object[] {A43TipoInv});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0N36( 4) ;
            RcdFound36 = 1;
            A43TipoInv = T000N3_A43TipoInv[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
            A219TipoInvMov = T000N3_A219TipoInvMov[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A219TipoInvMov", A219TipoInvMov);
            n219TipoInvMov = T000N3_n219TipoInvMov[0];
            A220TipoInvEst = T000N3_A220TipoInvEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A220TipoInvEst", A220TipoInvEst);
            n220TipoInvEst = T000N3_n220TipoInvEst[0];
            A221TipoInvActivo = T000N3_A221TipoInvActivo[0];
            n221TipoInvActivo = T000N3_n221TipoInvActivo[0];
            A222TipoInvUso = T000N3_A222TipoInvUso[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A222TipoInvUso", A222TipoInvUso);
            n222TipoInvUso = T000N3_n222TipoInvUso[0];
            A223TipoInvSigno = T000N3_A223TipoInvSigno[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223TipoInvSigno", StringUtil.LTrim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0)));
            n223TipoInvSigno = T000N3_n223TipoInvSigno[0];
            A224TipoInvTipo = T000N3_A224TipoInvTipo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A224TipoInvTipo", A224TipoInvTipo);
            n224TipoInvTipo = T000N3_n224TipoInvTipo[0];
            Z43TipoInv = A43TipoInv;
            sMode36 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0N36( ) ;
            if ( AnyError == 1 )
            {
               RcdFound36 = 0;
               InitializeNonKey0N36( ) ;
            }
            Gx_mode = sMode36;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound36 = 0;
            InitializeNonKey0N36( ) ;
            sMode36 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode36;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0N36( ) ;
         if ( RcdFound36 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound36 = 0;
         /* Using cursor T000N6 */
         pr_default.execute(4, new Object[] {A43TipoInv});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( StringUtil.StrCmp(T000N6_A43TipoInv[0], A43TipoInv) < 0 ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( StringUtil.StrCmp(T000N6_A43TipoInv[0], A43TipoInv) > 0 ) ) )
            {
               A43TipoInv = T000N6_A43TipoInv[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
               RcdFound36 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound36 = 0;
         /* Using cursor T000N7 */
         pr_default.execute(5, new Object[] {A43TipoInv});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( StringUtil.StrCmp(T000N7_A43TipoInv[0], A43TipoInv) > 0 ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( StringUtil.StrCmp(T000N7_A43TipoInv[0], A43TipoInv) < 0 ) ) )
            {
               A43TipoInv = T000N7_A43TipoInv[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
               RcdFound36 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0N36( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtTipoInv_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0N36( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound36 == 1 )
            {
               if ( StringUtil.StrCmp(A43TipoInv, Z43TipoInv) != 0 )
               {
                  A43TipoInv = Z43TipoInv;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "TIPOINV");
                  AnyError = 1;
                  GX_FocusControl = edtTipoInv_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtTipoInv_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0N36( ) ;
                  GX_FocusControl = edtTipoInv_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( StringUtil.StrCmp(A43TipoInv, Z43TipoInv) != 0 )
               {
                  /* Insert record */
                  GX_FocusControl = edtTipoInv_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0N36( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "TIPOINV");
                     AnyError = 1;
                     GX_FocusControl = edtTipoInv_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtTipoInv_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0N36( ) ;
                     if ( AnyError == 1 )
                     {
                        GX_FocusControl = "";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( StringUtil.StrCmp(A43TipoInv, Z43TipoInv) != 0 )
         {
            A43TipoInv = Z43TipoInv;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "TIPOINV");
            AnyError = 1;
            GX_FocusControl = edtTipoInv_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtTipoInv_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0N36( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000N2 */
            pr_default.execute(0, new Object[] {A43TipoInv});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TipoMovimiento"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z219TipoInvMov, T000N2_A219TipoInvMov[0]) != 0 ) || ( StringUtil.StrCmp(Z220TipoInvEst, T000N2_A220TipoInvEst[0]) != 0 ) || ( StringUtil.StrCmp(Z221TipoInvActivo, T000N2_A221TipoInvActivo[0]) != 0 ) || ( StringUtil.StrCmp(Z222TipoInvUso, T000N2_A222TipoInvUso[0]) != 0 ) || ( Z223TipoInvSigno != T000N2_A223TipoInvSigno[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z224TipoInvTipo, T000N2_A224TipoInvTipo[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z219TipoInvMov, T000N2_A219TipoInvMov[0]) != 0 )
               {
                  GXUtil.WriteLog("tipomovimiento:[seudo value changed for attri]"+"TipoInvMov");
                  GXUtil.WriteLogRaw("Old: ",Z219TipoInvMov);
                  GXUtil.WriteLogRaw("Current: ",T000N2_A219TipoInvMov[0]);
               }
               if ( StringUtil.StrCmp(Z220TipoInvEst, T000N2_A220TipoInvEst[0]) != 0 )
               {
                  GXUtil.WriteLog("tipomovimiento:[seudo value changed for attri]"+"TipoInvEst");
                  GXUtil.WriteLogRaw("Old: ",Z220TipoInvEst);
                  GXUtil.WriteLogRaw("Current: ",T000N2_A220TipoInvEst[0]);
               }
               if ( StringUtil.StrCmp(Z221TipoInvActivo, T000N2_A221TipoInvActivo[0]) != 0 )
               {
                  GXUtil.WriteLog("tipomovimiento:[seudo value changed for attri]"+"TipoInvActivo");
                  GXUtil.WriteLogRaw("Old: ",Z221TipoInvActivo);
                  GXUtil.WriteLogRaw("Current: ",T000N2_A221TipoInvActivo[0]);
               }
               if ( StringUtil.StrCmp(Z222TipoInvUso, T000N2_A222TipoInvUso[0]) != 0 )
               {
                  GXUtil.WriteLog("tipomovimiento:[seudo value changed for attri]"+"TipoInvUso");
                  GXUtil.WriteLogRaw("Old: ",Z222TipoInvUso);
                  GXUtil.WriteLogRaw("Current: ",T000N2_A222TipoInvUso[0]);
               }
               if ( Z223TipoInvSigno != T000N2_A223TipoInvSigno[0] )
               {
                  GXUtil.WriteLog("tipomovimiento:[seudo value changed for attri]"+"TipoInvSigno");
                  GXUtil.WriteLogRaw("Old: ",Z223TipoInvSigno);
                  GXUtil.WriteLogRaw("Current: ",T000N2_A223TipoInvSigno[0]);
               }
               if ( StringUtil.StrCmp(Z224TipoInvTipo, T000N2_A224TipoInvTipo[0]) != 0 )
               {
                  GXUtil.WriteLog("tipomovimiento:[seudo value changed for attri]"+"TipoInvTipo");
                  GXUtil.WriteLogRaw("Old: ",Z224TipoInvTipo);
                  GXUtil.WriteLogRaw("Current: ",T000N2_A224TipoInvTipo[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TipoMovimiento"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0N36( )
      {
         BeforeValidate0N36( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0N36( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0N36( 0) ;
            CheckOptimisticConcurrency0N36( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0N36( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0N36( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000N8 */
                     pr_default.execute(6, new Object[] {A43TipoInv, n219TipoInvMov, A219TipoInvMov, n220TipoInvEst, A220TipoInvEst, n221TipoInvActivo, A221TipoInvActivo, n222TipoInvUso, A222TipoInvUso, n223TipoInvSigno, A223TipoInvSigno, n224TipoInvTipo, A224TipoInvTipo});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("TipoMovimiento") ;
                     if ( (pr_default.getStatus(6) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption0N0( ) ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load0N36( ) ;
            }
            EndLevel0N36( ) ;
         }
         CloseExtendedTableCursors0N36( ) ;
      }

      protected void Update0N36( )
      {
         BeforeValidate0N36( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0N36( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0N36( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0N36( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0N36( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000N9 */
                     pr_default.execute(7, new Object[] {n219TipoInvMov, A219TipoInvMov, n220TipoInvEst, A220TipoInvEst, n221TipoInvActivo, A221TipoInvActivo, n222TipoInvUso, A222TipoInvUso, n223TipoInvSigno, A223TipoInvSigno, n224TipoInvTipo, A224TipoInvTipo, A43TipoInv});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("TipoMovimiento") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TipoMovimiento"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0N36( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1;
                              }
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel0N36( ) ;
         }
         CloseExtendedTableCursors0N36( ) ;
      }

      protected void DeferredUpdate0N36( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0N36( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0N36( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0N36( ) ;
            AfterConfirm0N36( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0N36( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000N10 */
                  pr_default.execute(8, new Object[] {A43TipoInv});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("TipoMovimiento") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                        {
                           if ( AnyError == 0 )
                           {
                              context.nUserReturn = 1;
                           }
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode36 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0N36( ) ;
         Gx_mode = sMode36;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0N36( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV11Pgmname = "TipoMovimiento";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Pgmname", AV11Pgmname);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000N11 */
            pr_default.execute(9, new Object[] {A43TipoInv});
            if ( (pr_default.getStatus(9) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"stock Det Egr"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(9);
            /* Using cursor T000N12 */
            pr_default.execute(10, new Object[] {A43TipoInv});
            if ( (pr_default.getStatus(10) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"TipoInv"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(10);
            /* Using cursor T000N13 */
            pr_default.execute(11, new Object[] {A43TipoInv});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Movimientos Inventario"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(11);
            /* Using cursor T000N14 */
            pr_default.execute(12, new Object[] {A43TipoInv});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Bod Tipo"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(12);
         }
      }

      protected void EndLevel0N36( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0N36( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("tipomovimiento",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0N0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("tipomovimiento",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0N36( )
      {
         /* Scan By routine */
         /* Using cursor T000N15 */
         pr_default.execute(13);
         RcdFound36 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound36 = 1;
            A43TipoInv = T000N15_A43TipoInv[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0N36( )
      {
         /* Scan next routine */
         pr_default.readNext(13);
         RcdFound36 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound36 = 1;
            A43TipoInv = T000N15_A43TipoInv[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
         }
      }

      protected void ScanEnd0N36( )
      {
         pr_default.close(13);
      }

      protected void AfterConfirm0N36( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0N36( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0N36( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0N36( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0N36( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0N36( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0N36( )
      {
         edtTipoInv_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoInv_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoInv_Enabled), 5, 0)), true);
         edtTipoInvMov_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoInvMov_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoInvMov_Enabled), 5, 0)), true);
         cmbTipoInvSigno.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTipoInvSigno_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbTipoInvSigno.Enabled), 5, 0)), true);
         chkTipoInvEst.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkTipoInvEst_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkTipoInvEst.Enabled), 5, 0)), true);
         radTipoInvUso.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, radTipoInvUso_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(radTipoInvUso.Enabled), 5, 0)), true);
         radTipoInvTipo.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, radTipoInvTipo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(radTipoInvTipo.Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0N36( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0N0( )
      {
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
         context.SendWebValue( "Tipo Movimiento") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20221270511930", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "";
         bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("tipomovimiento.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV7TipoInv))+"\">") ;
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
         forbiddenHiddens = "hsh" + "TipoMovimiento";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A221TipoInvActivo, ""));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("tipomovimiento:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GXUtil.WriteLog("tipomovimiento:[SendSecurityCheck value for]"+"TipoInvActivo:"+StringUtil.RTrim( context.localUtil.Format( A221TipoInvActivo, "")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z43TipoInv", StringUtil.RTrim( Z43TipoInv));
         GxWebStd.gx_hidden_field( context, "Z219TipoInvMov", Z219TipoInvMov);
         GxWebStd.gx_hidden_field( context, "Z220TipoInvEst", StringUtil.RTrim( Z220TipoInvEst));
         GxWebStd.gx_hidden_field( context, "Z221TipoInvActivo", StringUtil.RTrim( Z221TipoInvActivo));
         GxWebStd.gx_hidden_field( context, "Z222TipoInvUso", StringUtil.RTrim( Z222TipoInvUso));
         GxWebStd.gx_hidden_field( context, "Z223TipoInvSigno", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z223TipoInvSigno), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z224TipoInvTipo", StringUtil.RTrim( Z224TipoInvTipo));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vTIPOINV", StringUtil.RTrim( AV7TipoInv));
         GxWebStd.gx_hidden_field( context, "gxhash_vTIPOINV", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV7TipoInv, "")), context));
         GxWebStd.gx_hidden_field( context, "TIPOINVACTIVO", StringUtil.RTrim( A221TipoInvActivo));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV11Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void RenderHtmlCloseForm0N36( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken(sPrefix);
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
         return "TipoMovimiento" ;
      }

      public override String GetPgmdesc( )
      {
         return "Tipo Movimiento" ;
      }

      protected void InitializeNonKey0N36( )
      {
         A219TipoInvMov = "";
         n219TipoInvMov = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A219TipoInvMov", A219TipoInvMov);
         n219TipoInvMov = (String.IsNullOrEmpty(StringUtil.RTrim( A219TipoInvMov)) ? true : false);
         A220TipoInvEst = "";
         n220TipoInvEst = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A220TipoInvEst", A220TipoInvEst);
         n220TipoInvEst = (String.IsNullOrEmpty(StringUtil.RTrim( A220TipoInvEst)) ? true : false);
         A221TipoInvActivo = "";
         n221TipoInvActivo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A221TipoInvActivo", A221TipoInvActivo);
         A222TipoInvUso = "";
         n222TipoInvUso = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A222TipoInvUso", A222TipoInvUso);
         n222TipoInvUso = (String.IsNullOrEmpty(StringUtil.RTrim( A222TipoInvUso)) ? true : false);
         A223TipoInvSigno = 0;
         n223TipoInvSigno = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223TipoInvSigno", StringUtil.LTrim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0)));
         n223TipoInvSigno = ((0==A223TipoInvSigno) ? true : false);
         A224TipoInvTipo = "";
         n224TipoInvTipo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A224TipoInvTipo", A224TipoInvTipo);
         n224TipoInvTipo = (String.IsNullOrEmpty(StringUtil.RTrim( A224TipoInvTipo)) ? true : false);
         Z219TipoInvMov = "";
         Z220TipoInvEst = "";
         Z221TipoInvActivo = "";
         Z222TipoInvUso = "";
         Z223TipoInvSigno = 0;
         Z224TipoInvTipo = "";
      }

      protected void InitAll0N36( )
      {
         A43TipoInv = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
         InitializeNonKey0N36( ) ;
      }

      protected void StandaloneModalInsert( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20221270511937", true);
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
         context.AddJavascriptSource("tipomovimiento.js", "?20221270511938", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTitle_Internalname = "TITLE";
         divTitlecontainer_Internalname = "TITLECONTAINER";
         bttBtn_first_Internalname = "BTN_FIRST";
         bttBtn_previous_Internalname = "BTN_PREVIOUS";
         bttBtn_next_Internalname = "BTN_NEXT";
         bttBtn_last_Internalname = "BTN_LAST";
         bttBtn_select_Internalname = "BTN_SELECT";
         divToolbarcell_Internalname = "TOOLBARCELL";
         edtTipoInv_Internalname = "TIPOINV";
         edtTipoInvMov_Internalname = "TIPOINVMOV";
         cmbTipoInvSigno_Internalname = "TIPOINVSIGNO";
         chkTipoInvEst_Internalname = "TIPOINVEST";
         radTipoInvUso_Internalname = "TIPOINVUSO";
         divSection2_Internalname = "SECTION2";
         radTipoInvTipo_Internalname = "TIPOINVTIPO";
         divSection3_Internalname = "SECTION3";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
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
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         radTipoInvTipo_Jsonclick = "";
         radTipoInvTipo.Enabled = 1;
         radTipoInvUso_Jsonclick = "";
         radTipoInvUso.Enabled = 1;
         chkTipoInvEst.Enabled = 1;
         cmbTipoInvSigno_Jsonclick = "";
         cmbTipoInvSigno.Enabled = 1;
         edtTipoInvMov_Jsonclick = "";
         edtTipoInvMov_Enabled = 1;
         edtTipoInv_Jsonclick = "";
         edtTipoInv_Enabled = 1;
         bttBtn_select_Visible = 1;
         bttBtn_last_Visible = 1;
         bttBtn_next_Visible = 1;
         bttBtn_previous_Visible = 1;
         bttBtn_first_Visible = 1;
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void init_web_controls( )
      {
         cmbTipoInvSigno.Name = "TIPOINVSIGNO";
         cmbTipoInvSigno.WebTags = "";
         cmbTipoInvSigno.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 2, 0)), "Seleccionar", 0);
         cmbTipoInvSigno.addItem("1", "POSITIVO", 0);
         cmbTipoInvSigno.addItem("-1", "NEGATIVO", 0);
         if ( cmbTipoInvSigno.ItemCount > 0 )
         {
            A223TipoInvSigno = (short)(NumberUtil.Val( cmbTipoInvSigno.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0))), "."));
            n223TipoInvSigno = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223TipoInvSigno", StringUtil.LTrim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0)));
         }
         chkTipoInvEst.Name = "TIPOINVEST";
         chkTipoInvEst.WebTags = "";
         chkTipoInvEst.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkTipoInvEst_Internalname, "TitleCaption", chkTipoInvEst.Caption, true);
         chkTipoInvEst.CheckedValue = "I";
         radTipoInvUso.Name = "TIPOINVUSO";
         radTipoInvUso.WebTags = "";
         radTipoInvUso.addItem("I", "INVENTARIO", 0);
         radTipoInvUso.addItem("C", "COMPRAS", 0);
         radTipoInvUso.addItem("N", "NINGUNO", 0);
         radTipoInvTipo.Name = "TIPOINVTIPO";
         radTipoInvTipo.WebTags = "";
         radTipoInvTipo.addItem("C", "COMPRAS", 0);
         radTipoInvTipo.addItem("P", "PRODUCCION", 0);
         radTipoInvTipo.addItem("O", "OTROS ING/EGR", 0);
         /* End function init_web_controls */
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7TipoInv',fld:'vTIPOINV',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7TipoInv',fld:'vTIPOINV',pic:'',hsh:true},{av:'A221TipoInvActivo',fld:'TIPOINVACTIVO',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120N2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:''}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
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
         pr_default.close(1);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         wcpOAV7TipoInv = "";
         Z43TipoInv = "";
         Z219TipoInvMov = "";
         Z220TipoInvEst = "";
         Z221TipoInvActivo = "";
         Z222TipoInvUso = "";
         Z224TipoInvTipo = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         lblTitle_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         A43TipoInv = "";
         A219TipoInvMov = "";
         A220TipoInvEst = "";
         A222TipoInvUso = "";
         A224TipoInvTipo = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         A221TipoInvActivo = "";
         AV11Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode36 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         T000N4_A43TipoInv = new String[] {""} ;
         T000N4_A219TipoInvMov = new String[] {""} ;
         T000N4_n219TipoInvMov = new bool[] {false} ;
         T000N4_A220TipoInvEst = new String[] {""} ;
         T000N4_n220TipoInvEst = new bool[] {false} ;
         T000N4_A221TipoInvActivo = new String[] {""} ;
         T000N4_n221TipoInvActivo = new bool[] {false} ;
         T000N4_A222TipoInvUso = new String[] {""} ;
         T000N4_n222TipoInvUso = new bool[] {false} ;
         T000N4_A223TipoInvSigno = new short[1] ;
         T000N4_n223TipoInvSigno = new bool[] {false} ;
         T000N4_A224TipoInvTipo = new String[] {""} ;
         T000N4_n224TipoInvTipo = new bool[] {false} ;
         T000N5_A43TipoInv = new String[] {""} ;
         T000N3_A43TipoInv = new String[] {""} ;
         T000N3_A219TipoInvMov = new String[] {""} ;
         T000N3_n219TipoInvMov = new bool[] {false} ;
         T000N3_A220TipoInvEst = new String[] {""} ;
         T000N3_n220TipoInvEst = new bool[] {false} ;
         T000N3_A221TipoInvActivo = new String[] {""} ;
         T000N3_n221TipoInvActivo = new bool[] {false} ;
         T000N3_A222TipoInvUso = new String[] {""} ;
         T000N3_n222TipoInvUso = new bool[] {false} ;
         T000N3_A223TipoInvSigno = new short[1] ;
         T000N3_n223TipoInvSigno = new bool[] {false} ;
         T000N3_A224TipoInvTipo = new String[] {""} ;
         T000N3_n224TipoInvTipo = new bool[] {false} ;
         T000N6_A43TipoInv = new String[] {""} ;
         T000N7_A43TipoInv = new String[] {""} ;
         T000N2_A43TipoInv = new String[] {""} ;
         T000N2_A219TipoInvMov = new String[] {""} ;
         T000N2_n219TipoInvMov = new bool[] {false} ;
         T000N2_A220TipoInvEst = new String[] {""} ;
         T000N2_n220TipoInvEst = new bool[] {false} ;
         T000N2_A221TipoInvActivo = new String[] {""} ;
         T000N2_n221TipoInvActivo = new bool[] {false} ;
         T000N2_A222TipoInvUso = new String[] {""} ;
         T000N2_n222TipoInvUso = new bool[] {false} ;
         T000N2_A223TipoInvSigno = new short[1] ;
         T000N2_n223TipoInvSigno = new bool[] {false} ;
         T000N2_A224TipoInvTipo = new String[] {""} ;
         T000N2_n224TipoInvTipo = new bool[] {false} ;
         T000N11_A290stockAnio = new short[1] ;
         T000N11_A291stockMes = new short[1] ;
         T000N11_A1EmpID = new short[1] ;
         T000N11_A2AgeID = new short[1] ;
         T000N11_A42BodCod = new short[1] ;
         T000N11_A286PrdCod = new short[1] ;
         T000N11_A389stockDetIngID = new short[1] ;
         T000N12_A290stockAnio = new short[1] ;
         T000N12_A291stockMes = new short[1] ;
         T000N12_A1EmpID = new short[1] ;
         T000N12_A2AgeID = new short[1] ;
         T000N12_A42BodCod = new short[1] ;
         T000N12_A286PrdCod = new short[1] ;
         T000N12_A348stockDetID = new short[1] ;
         T000N13_A1EmpID = new short[1] ;
         T000N13_A2AgeID = new short[1] ;
         T000N13_A42BodCod = new short[1] ;
         T000N13_A264invCod = new short[1] ;
         T000N14_A1EmpID = new short[1] ;
         T000N14_A42BodCod = new short[1] ;
         T000N14_A285BodDetID = new short[1] ;
         T000N14_A43TipoInv = new String[] {""} ;
         T000N15_A43TipoInv = new String[] {""} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tipomovimiento__default(),
            new Object[][] {
                new Object[] {
               T000N2_A43TipoInv, T000N2_A219TipoInvMov, T000N2_n219TipoInvMov, T000N2_A220TipoInvEst, T000N2_n220TipoInvEst, T000N2_A221TipoInvActivo, T000N2_n221TipoInvActivo, T000N2_A222TipoInvUso, T000N2_n222TipoInvUso, T000N2_A223TipoInvSigno,
               T000N2_n223TipoInvSigno, T000N2_A224TipoInvTipo, T000N2_n224TipoInvTipo
               }
               , new Object[] {
               T000N3_A43TipoInv, T000N3_A219TipoInvMov, T000N3_n219TipoInvMov, T000N3_A220TipoInvEst, T000N3_n220TipoInvEst, T000N3_A221TipoInvActivo, T000N3_n221TipoInvActivo, T000N3_A222TipoInvUso, T000N3_n222TipoInvUso, T000N3_A223TipoInvSigno,
               T000N3_n223TipoInvSigno, T000N3_A224TipoInvTipo, T000N3_n224TipoInvTipo
               }
               , new Object[] {
               T000N4_A43TipoInv, T000N4_A219TipoInvMov, T000N4_n219TipoInvMov, T000N4_A220TipoInvEst, T000N4_n220TipoInvEst, T000N4_A221TipoInvActivo, T000N4_n221TipoInvActivo, T000N4_A222TipoInvUso, T000N4_n222TipoInvUso, T000N4_A223TipoInvSigno,
               T000N4_n223TipoInvSigno, T000N4_A224TipoInvTipo, T000N4_n224TipoInvTipo
               }
               , new Object[] {
               T000N5_A43TipoInv
               }
               , new Object[] {
               T000N6_A43TipoInv
               }
               , new Object[] {
               T000N7_A43TipoInv
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000N11_A290stockAnio, T000N11_A291stockMes, T000N11_A1EmpID, T000N11_A2AgeID, T000N11_A42BodCod, T000N11_A286PrdCod, T000N11_A389stockDetIngID
               }
               , new Object[] {
               T000N12_A290stockAnio, T000N12_A291stockMes, T000N12_A1EmpID, T000N12_A2AgeID, T000N12_A42BodCod, T000N12_A286PrdCod, T000N12_A348stockDetID
               }
               , new Object[] {
               T000N13_A1EmpID, T000N13_A2AgeID, T000N13_A42BodCod, T000N13_A264invCod
               }
               , new Object[] {
               T000N14_A1EmpID, T000N14_A42BodCod, T000N14_A285BodDetID, T000N14_A43TipoInv
               }
               , new Object[] {
               T000N15_A43TipoInv
               }
            }
         );
         AV11Pgmname = "TipoMovimiento";
      }

      private short Z223TipoInvSigno ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short A223TipoInvSigno ;
      private short RcdFound36 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtTipoInv_Enabled ;
      private int edtTipoInvMov_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String wcpOAV7TipoInv ;
      private String Z43TipoInv ;
      private String Z220TipoInvEst ;
      private String Z221TipoInvActivo ;
      private String Z222TipoInvUso ;
      private String Z224TipoInvTipo ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String AV7TipoInv ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtTipoInv_Internalname ;
      private String cmbTipoInvSigno_Internalname ;
      private String divMaintable_Internalname ;
      private String divTitlecontainer_Internalname ;
      private String lblTitle_Internalname ;
      private String lblTitle_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String divFormcontainer_Internalname ;
      private String divToolbarcell_Internalname ;
      private String TempTags ;
      private String bttBtn_first_Internalname ;
      private String bttBtn_first_Jsonclick ;
      private String bttBtn_previous_Internalname ;
      private String bttBtn_previous_Jsonclick ;
      private String bttBtn_next_Internalname ;
      private String bttBtn_next_Jsonclick ;
      private String bttBtn_last_Internalname ;
      private String bttBtn_last_Jsonclick ;
      private String bttBtn_select_Internalname ;
      private String bttBtn_select_Jsonclick ;
      private String A43TipoInv ;
      private String edtTipoInv_Jsonclick ;
      private String edtTipoInvMov_Internalname ;
      private String edtTipoInvMov_Jsonclick ;
      private String cmbTipoInvSigno_Jsonclick ;
      private String chkTipoInvEst_Internalname ;
      private String A220TipoInvEst ;
      private String divSection2_Internalname ;
      private String radTipoInvUso_Internalname ;
      private String A222TipoInvUso ;
      private String radTipoInvUso_Jsonclick ;
      private String divSection3_Internalname ;
      private String radTipoInvTipo_Internalname ;
      private String A224TipoInvTipo ;
      private String radTipoInvTipo_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String A221TipoInvActivo ;
      private String AV11Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode36 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n223TipoInvSigno ;
      private bool n219TipoInvMov ;
      private bool n220TipoInvEst ;
      private bool n222TipoInvUso ;
      private bool n224TipoInvTipo ;
      private bool n221TipoInvActivo ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private String Z219TipoInvMov ;
      private String A219TipoInvMov ;
      private IGxSession AV10WebSession ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbTipoInvSigno ;
      private GXCheckbox chkTipoInvEst ;
      private GXRadio radTipoInvUso ;
      private GXRadio radTipoInvTipo ;
      private IDataStoreProvider pr_default ;
      private String[] T000N4_A43TipoInv ;
      private String[] T000N4_A219TipoInvMov ;
      private bool[] T000N4_n219TipoInvMov ;
      private String[] T000N4_A220TipoInvEst ;
      private bool[] T000N4_n220TipoInvEst ;
      private String[] T000N4_A221TipoInvActivo ;
      private bool[] T000N4_n221TipoInvActivo ;
      private String[] T000N4_A222TipoInvUso ;
      private bool[] T000N4_n222TipoInvUso ;
      private short[] T000N4_A223TipoInvSigno ;
      private bool[] T000N4_n223TipoInvSigno ;
      private String[] T000N4_A224TipoInvTipo ;
      private bool[] T000N4_n224TipoInvTipo ;
      private String[] T000N5_A43TipoInv ;
      private String[] T000N3_A43TipoInv ;
      private String[] T000N3_A219TipoInvMov ;
      private bool[] T000N3_n219TipoInvMov ;
      private String[] T000N3_A220TipoInvEst ;
      private bool[] T000N3_n220TipoInvEst ;
      private String[] T000N3_A221TipoInvActivo ;
      private bool[] T000N3_n221TipoInvActivo ;
      private String[] T000N3_A222TipoInvUso ;
      private bool[] T000N3_n222TipoInvUso ;
      private short[] T000N3_A223TipoInvSigno ;
      private bool[] T000N3_n223TipoInvSigno ;
      private String[] T000N3_A224TipoInvTipo ;
      private bool[] T000N3_n224TipoInvTipo ;
      private String[] T000N6_A43TipoInv ;
      private String[] T000N7_A43TipoInv ;
      private String[] T000N2_A43TipoInv ;
      private String[] T000N2_A219TipoInvMov ;
      private bool[] T000N2_n219TipoInvMov ;
      private String[] T000N2_A220TipoInvEst ;
      private bool[] T000N2_n220TipoInvEst ;
      private String[] T000N2_A221TipoInvActivo ;
      private bool[] T000N2_n221TipoInvActivo ;
      private String[] T000N2_A222TipoInvUso ;
      private bool[] T000N2_n222TipoInvUso ;
      private short[] T000N2_A223TipoInvSigno ;
      private bool[] T000N2_n223TipoInvSigno ;
      private String[] T000N2_A224TipoInvTipo ;
      private bool[] T000N2_n224TipoInvTipo ;
      private short[] T000N11_A290stockAnio ;
      private short[] T000N11_A291stockMes ;
      private short[] T000N11_A1EmpID ;
      private short[] T000N11_A2AgeID ;
      private short[] T000N11_A42BodCod ;
      private short[] T000N11_A286PrdCod ;
      private short[] T000N11_A389stockDetIngID ;
      private short[] T000N12_A290stockAnio ;
      private short[] T000N12_A291stockMes ;
      private short[] T000N12_A1EmpID ;
      private short[] T000N12_A2AgeID ;
      private short[] T000N12_A42BodCod ;
      private short[] T000N12_A286PrdCod ;
      private short[] T000N12_A348stockDetID ;
      private short[] T000N13_A1EmpID ;
      private short[] T000N13_A2AgeID ;
      private short[] T000N13_A42BodCod ;
      private short[] T000N13_A264invCod ;
      private short[] T000N14_A1EmpID ;
      private short[] T000N14_A42BodCod ;
      private short[] T000N14_A285BodDetID ;
      private String[] T000N14_A43TipoInv ;
      private String[] T000N15_A43TipoInv ;
      private SdtTransactionContext AV9TrnContext ;
   }

   public class tipomovimiento__default : DataStoreHelperBase, IDataStoreHelper
   {
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
         ,new UpdateCursor(def[6])
         ,new UpdateCursor(def[7])
         ,new UpdateCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000N4 ;
          prmT000N4 = new Object[] {
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000N5 ;
          prmT000N5 = new Object[] {
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000N3 ;
          prmT000N3 = new Object[] {
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000N6 ;
          prmT000N6 = new Object[] {
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000N7 ;
          prmT000N7 = new Object[] {
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000N2 ;
          prmT000N2 = new Object[] {
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000N8 ;
          prmT000N8 = new Object[] {
          new Object[] {"@TipoInv",SqlDbType.Char,4,0} ,
          new Object[] {"@TipoInvMov",SqlDbType.VarChar,60,0} ,
          new Object[] {"@TipoInvEst",SqlDbType.Char,1,0} ,
          new Object[] {"@TipoInvActivo",SqlDbType.Char,1,0} ,
          new Object[] {"@TipoInvUso",SqlDbType.Char,1,0} ,
          new Object[] {"@TipoInvSigno",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@TipoInvTipo",SqlDbType.Char,1,0}
          } ;
          Object[] prmT000N9 ;
          prmT000N9 = new Object[] {
          new Object[] {"@TipoInvMov",SqlDbType.VarChar,60,0} ,
          new Object[] {"@TipoInvEst",SqlDbType.Char,1,0} ,
          new Object[] {"@TipoInvActivo",SqlDbType.Char,1,0} ,
          new Object[] {"@TipoInvUso",SqlDbType.Char,1,0} ,
          new Object[] {"@TipoInvSigno",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@TipoInvTipo",SqlDbType.Char,1,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000N10 ;
          prmT000N10 = new Object[] {
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000N11 ;
          prmT000N11 = new Object[] {
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000N12 ;
          prmT000N12 = new Object[] {
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000N13 ;
          prmT000N13 = new Object[] {
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000N14 ;
          prmT000N14 = new Object[] {
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000N15 ;
          prmT000N15 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T000N2", "SELECT [TipoInv], [TipoInvMov], [TipoInvEst], [TipoInvActivo], [TipoInvUso], [TipoInvSigno], [TipoInvTipo] FROM [TipoMovimiento] WITH (UPDLOCK) WHERE [TipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT000N2,1,0,true,false )
             ,new CursorDef("T000N3", "SELECT [TipoInv], [TipoInvMov], [TipoInvEst], [TipoInvActivo], [TipoInvUso], [TipoInvSigno], [TipoInvTipo] FROM [TipoMovimiento] WITH (NOLOCK) WHERE [TipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT000N3,1,0,true,false )
             ,new CursorDef("T000N4", "SELECT TM1.[TipoInv], TM1.[TipoInvMov], TM1.[TipoInvEst], TM1.[TipoInvActivo], TM1.[TipoInvUso], TM1.[TipoInvSigno], TM1.[TipoInvTipo] FROM [TipoMovimiento] TM1 WITH (NOLOCK) WHERE TM1.[TipoInv] = @TipoInv ORDER BY TM1.[TipoInv]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000N4,100,0,true,false )
             ,new CursorDef("T000N5", "SELECT [TipoInv] FROM [TipoMovimiento] WITH (NOLOCK) WHERE [TipoInv] = @TipoInv  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000N5,1,0,true,false )
             ,new CursorDef("T000N6", "SELECT TOP 1 [TipoInv] FROM [TipoMovimiento] WITH (NOLOCK) WHERE ( [TipoInv] > @TipoInv) ORDER BY [TipoInv]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000N6,1,0,true,true )
             ,new CursorDef("T000N7", "SELECT TOP 1 [TipoInv] FROM [TipoMovimiento] WITH (NOLOCK) WHERE ( [TipoInv] < @TipoInv) ORDER BY [TipoInv] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000N7,1,0,true,true )
             ,new CursorDef("T000N8", "INSERT INTO [TipoMovimiento]([TipoInv], [TipoInvMov], [TipoInvEst], [TipoInvActivo], [TipoInvUso], [TipoInvSigno], [TipoInvTipo]) VALUES(@TipoInv, @TipoInvMov, @TipoInvEst, @TipoInvActivo, @TipoInvUso, @TipoInvSigno, @TipoInvTipo)", GxErrorMask.GX_NOMASK,prmT000N8)
             ,new CursorDef("T000N9", "UPDATE [TipoMovimiento] SET [TipoInvMov]=@TipoInvMov, [TipoInvEst]=@TipoInvEst, [TipoInvActivo]=@TipoInvActivo, [TipoInvUso]=@TipoInvUso, [TipoInvSigno]=@TipoInvSigno, [TipoInvTipo]=@TipoInvTipo  WHERE [TipoInv] = @TipoInv", GxErrorMask.GX_NOMASK,prmT000N9)
             ,new CursorDef("T000N10", "DELETE FROM [TipoMovimiento]  WHERE [TipoInv] = @TipoInv", GxErrorMask.GX_NOMASK,prmT000N10)
             ,new CursorDef("T000N11", "SELECT TOP 1 [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod], [stockDetIngID] FROM [ProdStockBodegastockDetEgr] WITH (NOLOCK) WHERE [ingTipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT000N11,1,0,true,true )
             ,new CursorDef("T000N12", "SELECT TOP 1 [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod], [stockDetID] FROM [ProdxBodegaTipoInv] WITH (NOLOCK) WHERE [TipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT000N12,1,0,true,true )
             ,new CursorDef("T000N13", "SELECT TOP 1 [EmpID], [AgeID], [BodCod], [invCod] FROM [Inventario] WITH (NOLOCK) WHERE [TipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT000N13,1,0,true,true )
             ,new CursorDef("T000N14", "SELECT TOP 1 [EmpID], [BodCod], [BodDetID], [TipoInv] FROM [BodegasBodTipo] WITH (NOLOCK) WHERE [TipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT000N14,1,0,true,true )
             ,new CursorDef("T000N15", "SELECT [TipoInv] FROM [TipoMovimiento] WITH (NOLOCK) ORDER BY [TipoInv]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000N15,100,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 4) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 1) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 1) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getString(7, 1) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 4) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 1) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 1) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getString(7, 1) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 4) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 1) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 1) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getString(7, 1) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 4) ;
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 4) ;
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 4) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                return;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                return;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 4) ;
                return;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getString(1, 4) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 3 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 4 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 5 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 6 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(6, (short)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 7 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[12]);
                }
                return;
             case 7 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(5, (short)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 6 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[11]);
                }
                stmt.SetParameter(7, (String)parms[12]);
                return;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
       }
    }

 }

}
