/*
               File: Usuarios
        Description: Usuarios
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 2/12/2023 15:17:13.14
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
   public class usuarios : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
               AV7Usucod = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7Usucod", AV7Usucod);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV7Usucod, "")), context));
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
            Form.Meta.addItem("description", "Usuarios", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtUsuCod_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public usuarios( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public usuarios( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           String aP1_Usucod )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7Usucod = aP1_Usucod;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkUsuEst = new GXCheckbox();
         cmbUsuRol = new GXCombobox();
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
         if ( cmbUsuRol.ItemCount > 0 )
         {
            A53UsuRol = cmbUsuRol.getValidValue(A53UsuRol);
            n53UsuRol = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53UsuRol", A53UsuRol);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbUsuRol.CurrentValue = StringUtil.RTrim( A53UsuRol);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbUsuRol_Internalname, "Values", cmbUsuRol.ToJavascriptSource(), true);
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Usuarios", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Usuarios.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Usuarios.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Usuarios.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Usuarios.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Usuarios.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 5, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Usuarios.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuCod_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuCod_Internalname, "Nombre de Usuario", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsuCod_Internalname, StringUtil.RTrim( A3UsuCod), StringUtil.RTrim( context.localUtil.Format( A3UsuCod, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuCod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuCod_Enabled, 1, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Usuarios.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuName_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuName_Internalname, "Name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsuName_Internalname, A50UsuName, StringUtil.RTrim( context.localUtil.Format( A50UsuName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuName_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Usuarios.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuAlias_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuAlias_Internalname, "Alias", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsuAlias_Internalname, StringUtil.RTrim( A398UsuAlias), StringUtil.RTrim( context.localUtil.Format( A398UsuAlias, "@!")), TempTags+" onchange=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuAlias_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuAlias_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "nombres", "left", true, "HLP_Usuarios.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuPassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuPassword_Internalname, "Contraseña", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsuPassword_Internalname, StringUtil.RTrim( A51UsuPassword), StringUtil.RTrim( context.localUtil.Format( A51UsuPassword, "@!")), TempTags+" onchange=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\""+" "+"data-gx-password-reveal"+" "+"idenableshowpasswordhint=\"True\""+" ", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuPassword_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuPassword_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, -1, 0, 0, 1, 0, -1, true, "", "left", true, "HLP_Usuarios.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkUsuEst_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkUsuEst_Internalname, "Activo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkUsuEst_Internalname, A52UsuEst, "", "Activo", 1, chkUsuEst.Enabled, "A", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(54, this, 'A', 'I');gx.evt.onchange(this, event);\" ");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbUsuRol_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbUsuRol_Internalname, "Rol", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbUsuRol, cmbUsuRol_Internalname, StringUtil.RTrim( A53UsuRol), 1, cmbUsuRol_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbUsuRol.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", "", true, "HLP_Usuarios.htm");
            cmbUsuRol.CurrentValue = StringUtil.RTrim( A53UsuRol);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbUsuRol_Internalname, "Values", (String)(cmbUsuRol.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"TAB2Container"+"\"></div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB2Container"+"title1"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTabpage1_title_Internalname, "Datos Correo", "", "", lblTabpage1_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Usuarios.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "TabPage1") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB2Container"+"panel1"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divDatacorreo_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3 col-lg-12 col-lg-offset-0", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuCorreo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuCorreo_Internalname, "Correo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsuCorreo_Internalname, StringUtil.RTrim( A90UsuCorreo), StringUtil.RTrim( context.localUtil.Format( A90UsuCorreo, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,72);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuCorreo_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuCorreo_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Usuarios.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuClaveCorreo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuClaveCorreo_Internalname, "Clave Correo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsuClaveCorreo_Internalname, StringUtil.RTrim( A138UsuClaveCorreo), StringUtil.RTrim( context.localUtil.Format( A138UsuClaveCorreo, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,77);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuClaveCorreo_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuClaveCorreo_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, -1, 0, 0, 1, 0, -1, true, "", "left", true, "HLP_Usuarios.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB2Container"+"title2"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTabpage2_title_Internalname, "Datos Servidor", "", "", lblTabpage2_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Usuarios.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "TabPage2") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB2Container"+"panel2"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabpage2table_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuPuerto_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuPuerto_Internalname, "Puerto", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 87,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsuPuerto_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A92UsuPuerto), 4, 0, ",", "")), ((edtUsuPuerto_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A92UsuPuerto), "ZZZ9")) : context.localUtil.Format( (decimal)(A92UsuPuerto), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,87);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuPuerto_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuPuerto_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Usuarios.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuSMTP_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuSMTP_Internalname, "Servidor SMTP", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 92,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsuSMTP_Internalname, StringUtil.RTrim( A91UsuSMTP), StringUtil.RTrim( context.localUtil.Format( A91UsuSMTP, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,92);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuSMTP_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuSMTP_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Usuarios.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group Confirm", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 97,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Usuarios.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 99,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Usuarios.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 101,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Usuarios.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm0G3( ) ;
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
         E110G2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A3UsuCod = cgiGet( edtUsuCod_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
               A50UsuName = cgiGet( edtUsuName_Internalname);
               n50UsuName = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50UsuName", A50UsuName);
               n50UsuName = (String.IsNullOrEmpty(StringUtil.RTrim( A50UsuName)) ? true : false);
               A398UsuAlias = StringUtil.Upper( cgiGet( edtUsuAlias_Internalname));
               n398UsuAlias = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A398UsuAlias", A398UsuAlias);
               n398UsuAlias = (String.IsNullOrEmpty(StringUtil.RTrim( A398UsuAlias)) ? true : false);
               A51UsuPassword = StringUtil.Upper( cgiGet( edtUsuPassword_Internalname));
               n51UsuPassword = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51UsuPassword", A51UsuPassword);
               n51UsuPassword = (String.IsNullOrEmpty(StringUtil.RTrim( A51UsuPassword)) ? true : false);
               A52UsuEst = ((StringUtil.StrCmp(cgiGet( chkUsuEst_Internalname), "A")==0) ? "A" : "I");
               n52UsuEst = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52UsuEst", A52UsuEst);
               n52UsuEst = (String.IsNullOrEmpty(StringUtil.RTrim( A52UsuEst)) ? true : false);
               cmbUsuRol.CurrentValue = cgiGet( cmbUsuRol_Internalname);
               A53UsuRol = cgiGet( cmbUsuRol_Internalname);
               n53UsuRol = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53UsuRol", A53UsuRol);
               n53UsuRol = (String.IsNullOrEmpty(StringUtil.RTrim( A53UsuRol)) ? true : false);
               A90UsuCorreo = cgiGet( edtUsuCorreo_Internalname);
               n90UsuCorreo = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90UsuCorreo", A90UsuCorreo);
               n90UsuCorreo = (String.IsNullOrEmpty(StringUtil.RTrim( A90UsuCorreo)) ? true : false);
               A138UsuClaveCorreo = cgiGet( edtUsuClaveCorreo_Internalname);
               n138UsuClaveCorreo = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A138UsuClaveCorreo", A138UsuClaveCorreo);
               n138UsuClaveCorreo = (String.IsNullOrEmpty(StringUtil.RTrim( A138UsuClaveCorreo)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtUsuPuerto_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtUsuPuerto_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "USUPUERTO");
                  AnyError = 1;
                  GX_FocusControl = edtUsuPuerto_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A92UsuPuerto = 0;
                  n92UsuPuerto = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92UsuPuerto", StringUtil.LTrim( StringUtil.Str( (decimal)(A92UsuPuerto), 4, 0)));
               }
               else
               {
                  A92UsuPuerto = (short)(context.localUtil.CToN( cgiGet( edtUsuPuerto_Internalname), ",", "."));
                  n92UsuPuerto = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92UsuPuerto", StringUtil.LTrim( StringUtil.Str( (decimal)(A92UsuPuerto), 4, 0)));
               }
               n92UsuPuerto = ((0==A92UsuPuerto) ? true : false);
               A91UsuSMTP = cgiGet( edtUsuSMTP_Internalname);
               n91UsuSMTP = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91UsuSMTP", A91UsuSMTP);
               n91UsuSMTP = (String.IsNullOrEmpty(StringUtil.RTrim( A91UsuSMTP)) ? true : false);
               /* Read saved values. */
               Z3UsuCod = cgiGet( "Z3UsuCod");
               Z50UsuName = cgiGet( "Z50UsuName");
               n50UsuName = (String.IsNullOrEmpty(StringUtil.RTrim( A50UsuName)) ? true : false);
               Z51UsuPassword = cgiGet( "Z51UsuPassword");
               n51UsuPassword = (String.IsNullOrEmpty(StringUtil.RTrim( A51UsuPassword)) ? true : false);
               Z52UsuEst = cgiGet( "Z52UsuEst");
               n52UsuEst = (String.IsNullOrEmpty(StringUtil.RTrim( A52UsuEst)) ? true : false);
               Z53UsuRol = cgiGet( "Z53UsuRol");
               n53UsuRol = (String.IsNullOrEmpty(StringUtil.RTrim( A53UsuRol)) ? true : false);
               Z86UsuNivel = cgiGet( "Z86UsuNivel");
               n86UsuNivel = (String.IsNullOrEmpty(StringUtil.RTrim( A86UsuNivel)) ? true : false);
               Z89UsuObserv = cgiGet( "Z89UsuObserv");
               n89UsuObserv = (String.IsNullOrEmpty(StringUtil.RTrim( A89UsuObserv)) ? true : false);
               Z90UsuCorreo = cgiGet( "Z90UsuCorreo");
               n90UsuCorreo = (String.IsNullOrEmpty(StringUtil.RTrim( A90UsuCorreo)) ? true : false);
               Z138UsuClaveCorreo = cgiGet( "Z138UsuClaveCorreo");
               n138UsuClaveCorreo = (String.IsNullOrEmpty(StringUtil.RTrim( A138UsuClaveCorreo)) ? true : false);
               Z91UsuSMTP = cgiGet( "Z91UsuSMTP");
               n91UsuSMTP = (String.IsNullOrEmpty(StringUtil.RTrim( A91UsuSMTP)) ? true : false);
               Z92UsuPuerto = (short)(context.localUtil.CToN( cgiGet( "Z92UsuPuerto"), ",", "."));
               n92UsuPuerto = ((0==A92UsuPuerto) ? true : false);
               Z398UsuAlias = cgiGet( "Z398UsuAlias");
               n398UsuAlias = (String.IsNullOrEmpty(StringUtil.RTrim( A398UsuAlias)) ? true : false);
               A86UsuNivel = cgiGet( "Z86UsuNivel");
               n86UsuNivel = false;
               n86UsuNivel = (String.IsNullOrEmpty(StringUtil.RTrim( A86UsuNivel)) ? true : false);
               A89UsuObserv = cgiGet( "Z89UsuObserv");
               n89UsuObserv = false;
               n89UsuObserv = (String.IsNullOrEmpty(StringUtil.RTrim( A89UsuObserv)) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               AV7Usucod = cgiGet( "vUSUCOD");
               A86UsuNivel = cgiGet( "USUNIVEL");
               n86UsuNivel = (String.IsNullOrEmpty(StringUtil.RTrim( A86UsuNivel)) ? true : false);
               A89UsuObserv = cgiGet( "USUOBSERV");
               n89UsuObserv = (String.IsNullOrEmpty(StringUtil.RTrim( A89UsuObserv)) ? true : false);
               AV12Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               Tab2_Objectcall = cgiGet( "TAB2_Objectcall");
               Tab2_Enabled = StringUtil.StrToBool( cgiGet( "TAB2_Enabled"));
               Tab2_Class = cgiGet( "TAB2_Class");
               Tab2_Activepage = (int)(context.localUtil.CToN( cgiGet( "TAB2_Activepage"), ",", "."));
               Tab2_Activepagecontrolname = cgiGet( "TAB2_Activepagecontrolname");
               Tab2_Pagecount = (int)(context.localUtil.CToN( cgiGet( "TAB2_Pagecount"), ",", "."));
               Tab2_Historymanagement = StringUtil.StrToBool( cgiGet( "TAB2_Historymanagement"));
               Tab2_Visible = StringUtil.StrToBool( cgiGet( "TAB2_Visible"));
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Usuarios";
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A86UsuNivel, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A89UsuObserv, ""));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( StringUtil.StrCmp(A3UsuCod, Z3UsuCod) != 0 ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("usuarios:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GXUtil.WriteLog("usuarios:[SecurityCheckFailed value for]"+"UsuNivel:"+StringUtil.RTrim( context.localUtil.Format( A86UsuNivel, "")));
                  GXUtil.WriteLog("usuarios:[SecurityCheckFailed value for]"+"UsuObserv:"+StringUtil.RTrim( context.localUtil.Format( A89UsuObserv, "")));
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
                  A3UsuCod = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
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
                     sMode3 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode3;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound3 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0G0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "USUCOD");
                        AnyError = 1;
                        GX_FocusControl = edtUsuCod_Internalname;
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
                        E110G2 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: After Trn */
                        E120G2 ();
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
            E120G2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0G3( ) ;
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
            DisableAttributes0G3( ) ;
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

      protected void CONFIRM_0G0( )
      {
         BeforeValidate0G3( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0G3( ) ;
            }
            else
            {
               CheckExtendedTable0G3( ) ;
               CloseExtendedTableCursors0G3( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0G0( )
      {
      }

      protected void E110G2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV12Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "KBCalpesa22");
      }

      protected void E120G2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwusuarios.aspx") );
            context.wjLocDisableFrm = 1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            CallWebObject(formatLink("emails.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0) + "," + UrlEncode(StringUtil.RTrim(A3UsuCod)));
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0G3( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z50UsuName = T000G3_A50UsuName[0];
               Z51UsuPassword = T000G3_A51UsuPassword[0];
               Z52UsuEst = T000G3_A52UsuEst[0];
               Z53UsuRol = T000G3_A53UsuRol[0];
               Z86UsuNivel = T000G3_A86UsuNivel[0];
               Z89UsuObserv = T000G3_A89UsuObserv[0];
               Z90UsuCorreo = T000G3_A90UsuCorreo[0];
               Z138UsuClaveCorreo = T000G3_A138UsuClaveCorreo[0];
               Z91UsuSMTP = T000G3_A91UsuSMTP[0];
               Z92UsuPuerto = T000G3_A92UsuPuerto[0];
               Z398UsuAlias = T000G3_A398UsuAlias[0];
            }
            else
            {
               Z50UsuName = A50UsuName;
               Z51UsuPassword = A51UsuPassword;
               Z52UsuEst = A52UsuEst;
               Z53UsuRol = A53UsuRol;
               Z86UsuNivel = A86UsuNivel;
               Z89UsuObserv = A89UsuObserv;
               Z90UsuCorreo = A90UsuCorreo;
               Z138UsuClaveCorreo = A138UsuClaveCorreo;
               Z91UsuSMTP = A91UsuSMTP;
               Z92UsuPuerto = A92UsuPuerto;
               Z398UsuAlias = A398UsuAlias;
            }
         }
         if ( GX_JID == -4 )
         {
            Z3UsuCod = A3UsuCod;
            Z50UsuName = A50UsuName;
            Z51UsuPassword = A51UsuPassword;
            Z52UsuEst = A52UsuEst;
            Z53UsuRol = A53UsuRol;
            Z86UsuNivel = A86UsuNivel;
            Z89UsuObserv = A89UsuObserv;
            Z90UsuCorreo = A90UsuCorreo;
            Z138UsuClaveCorreo = A138UsuClaveCorreo;
            Z91UsuSMTP = A91UsuSMTP;
            Z92UsuPuerto = A92UsuPuerto;
            Z398UsuAlias = A398UsuAlias;
         }
      }

      protected void standaloneNotModal( )
      {
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7Usucod)) )
         {
            A3UsuCod = AV7Usucod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7Usucod)) )
         {
            edtUsuCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuCod_Enabled), 5, 0)), true);
         }
         else
         {
            edtUsuCod_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuCod_Enabled), 5, 0)), true);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7Usucod)) )
         {
            edtUsuCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuCod_Enabled), 5, 0)), true);
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
            AV12Pgmname = "Usuarios";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Pgmname", AV12Pgmname);
         }
      }

      protected void Load0G3( )
      {
         /* Using cursor T000G4 */
         pr_default.execute(2, new Object[] {A3UsuCod});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound3 = 1;
            A50UsuName = T000G4_A50UsuName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50UsuName", A50UsuName);
            n50UsuName = T000G4_n50UsuName[0];
            A51UsuPassword = T000G4_A51UsuPassword[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51UsuPassword", A51UsuPassword);
            n51UsuPassword = T000G4_n51UsuPassword[0];
            A52UsuEst = T000G4_A52UsuEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52UsuEst", A52UsuEst);
            n52UsuEst = T000G4_n52UsuEst[0];
            A53UsuRol = T000G4_A53UsuRol[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53UsuRol", A53UsuRol);
            n53UsuRol = T000G4_n53UsuRol[0];
            A86UsuNivel = T000G4_A86UsuNivel[0];
            n86UsuNivel = T000G4_n86UsuNivel[0];
            A89UsuObserv = T000G4_A89UsuObserv[0];
            n89UsuObserv = T000G4_n89UsuObserv[0];
            A90UsuCorreo = T000G4_A90UsuCorreo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90UsuCorreo", A90UsuCorreo);
            n90UsuCorreo = T000G4_n90UsuCorreo[0];
            A138UsuClaveCorreo = T000G4_A138UsuClaveCorreo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A138UsuClaveCorreo", A138UsuClaveCorreo);
            n138UsuClaveCorreo = T000G4_n138UsuClaveCorreo[0];
            A91UsuSMTP = T000G4_A91UsuSMTP[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91UsuSMTP", A91UsuSMTP);
            n91UsuSMTP = T000G4_n91UsuSMTP[0];
            A92UsuPuerto = T000G4_A92UsuPuerto[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92UsuPuerto", StringUtil.LTrim( StringUtil.Str( (decimal)(A92UsuPuerto), 4, 0)));
            n92UsuPuerto = T000G4_n92UsuPuerto[0];
            A398UsuAlias = T000G4_A398UsuAlias[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A398UsuAlias", A398UsuAlias);
            n398UsuAlias = T000G4_n398UsuAlias[0];
            ZM0G3( -4) ;
         }
         pr_default.close(2);
         OnLoadActions0G3( ) ;
      }

      protected void OnLoadActions0G3( )
      {
         AV12Pgmname = "Usuarios";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Pgmname", AV12Pgmname);
      }

      protected void CheckExtendedTable0G3( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV12Pgmname = "Usuarios";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Pgmname", AV12Pgmname);
      }

      protected void CloseExtendedTableCursors0G3( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0G3( )
      {
         /* Using cursor T000G5 */
         pr_default.execute(3, new Object[] {A3UsuCod});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound3 = 1;
         }
         else
         {
            RcdFound3 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000G3 */
         pr_default.execute(1, new Object[] {A3UsuCod});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0G3( 4) ;
            RcdFound3 = 1;
            A3UsuCod = T000G3_A3UsuCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
            A50UsuName = T000G3_A50UsuName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50UsuName", A50UsuName);
            n50UsuName = T000G3_n50UsuName[0];
            A51UsuPassword = T000G3_A51UsuPassword[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51UsuPassword", A51UsuPassword);
            n51UsuPassword = T000G3_n51UsuPassword[0];
            A52UsuEst = T000G3_A52UsuEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52UsuEst", A52UsuEst);
            n52UsuEst = T000G3_n52UsuEst[0];
            A53UsuRol = T000G3_A53UsuRol[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53UsuRol", A53UsuRol);
            n53UsuRol = T000G3_n53UsuRol[0];
            A86UsuNivel = T000G3_A86UsuNivel[0];
            n86UsuNivel = T000G3_n86UsuNivel[0];
            A89UsuObserv = T000G3_A89UsuObserv[0];
            n89UsuObserv = T000G3_n89UsuObserv[0];
            A90UsuCorreo = T000G3_A90UsuCorreo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90UsuCorreo", A90UsuCorreo);
            n90UsuCorreo = T000G3_n90UsuCorreo[0];
            A138UsuClaveCorreo = T000G3_A138UsuClaveCorreo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A138UsuClaveCorreo", A138UsuClaveCorreo);
            n138UsuClaveCorreo = T000G3_n138UsuClaveCorreo[0];
            A91UsuSMTP = T000G3_A91UsuSMTP[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91UsuSMTP", A91UsuSMTP);
            n91UsuSMTP = T000G3_n91UsuSMTP[0];
            A92UsuPuerto = T000G3_A92UsuPuerto[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92UsuPuerto", StringUtil.LTrim( StringUtil.Str( (decimal)(A92UsuPuerto), 4, 0)));
            n92UsuPuerto = T000G3_n92UsuPuerto[0];
            A398UsuAlias = T000G3_A398UsuAlias[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A398UsuAlias", A398UsuAlias);
            n398UsuAlias = T000G3_n398UsuAlias[0];
            Z3UsuCod = A3UsuCod;
            sMode3 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0G3( ) ;
            if ( AnyError == 1 )
            {
               RcdFound3 = 0;
               InitializeNonKey0G3( ) ;
            }
            Gx_mode = sMode3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound3 = 0;
            InitializeNonKey0G3( ) ;
            sMode3 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0G3( ) ;
         if ( RcdFound3 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound3 = 0;
         /* Using cursor T000G6 */
         pr_default.execute(4, new Object[] {A3UsuCod});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( StringUtil.StrCmp(T000G6_A3UsuCod[0], A3UsuCod) < 0 ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( StringUtil.StrCmp(T000G6_A3UsuCod[0], A3UsuCod) > 0 ) ) )
            {
               A3UsuCod = T000G6_A3UsuCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
               RcdFound3 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound3 = 0;
         /* Using cursor T000G7 */
         pr_default.execute(5, new Object[] {A3UsuCod});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( StringUtil.StrCmp(T000G7_A3UsuCod[0], A3UsuCod) > 0 ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( StringUtil.StrCmp(T000G7_A3UsuCod[0], A3UsuCod) < 0 ) ) )
            {
               A3UsuCod = T000G7_A3UsuCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
               RcdFound3 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0G3( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtUsuCod_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0G3( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound3 == 1 )
            {
               if ( StringUtil.StrCmp(A3UsuCod, Z3UsuCod) != 0 )
               {
                  A3UsuCod = Z3UsuCod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "USUCOD");
                  AnyError = 1;
                  GX_FocusControl = edtUsuCod_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtUsuCod_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0G3( ) ;
                  GX_FocusControl = edtUsuCod_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( StringUtil.StrCmp(A3UsuCod, Z3UsuCod) != 0 )
               {
                  /* Insert record */
                  GX_FocusControl = edtUsuCod_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0G3( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "USUCOD");
                     AnyError = 1;
                     GX_FocusControl = edtUsuCod_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtUsuCod_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0G3( ) ;
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
         if ( StringUtil.StrCmp(A3UsuCod, Z3UsuCod) != 0 )
         {
            A3UsuCod = Z3UsuCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "USUCOD");
            AnyError = 1;
            GX_FocusControl = edtUsuCod_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtUsuCod_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0G3( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000G2 */
            pr_default.execute(0, new Object[] {A3UsuCod});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Usuarios"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z50UsuName, T000G2_A50UsuName[0]) != 0 ) || ( StringUtil.StrCmp(Z51UsuPassword, T000G2_A51UsuPassword[0]) != 0 ) || ( StringUtil.StrCmp(Z52UsuEst, T000G2_A52UsuEst[0]) != 0 ) || ( StringUtil.StrCmp(Z53UsuRol, T000G2_A53UsuRol[0]) != 0 ) || ( StringUtil.StrCmp(Z86UsuNivel, T000G2_A86UsuNivel[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z89UsuObserv, T000G2_A89UsuObserv[0]) != 0 ) || ( StringUtil.StrCmp(Z90UsuCorreo, T000G2_A90UsuCorreo[0]) != 0 ) || ( StringUtil.StrCmp(Z138UsuClaveCorreo, T000G2_A138UsuClaveCorreo[0]) != 0 ) || ( StringUtil.StrCmp(Z91UsuSMTP, T000G2_A91UsuSMTP[0]) != 0 ) || ( Z92UsuPuerto != T000G2_A92UsuPuerto[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z398UsuAlias, T000G2_A398UsuAlias[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z50UsuName, T000G2_A50UsuName[0]) != 0 )
               {
                  GXUtil.WriteLog("usuarios:[seudo value changed for attri]"+"UsuName");
                  GXUtil.WriteLogRaw("Old: ",Z50UsuName);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A50UsuName[0]);
               }
               if ( StringUtil.StrCmp(Z51UsuPassword, T000G2_A51UsuPassword[0]) != 0 )
               {
                  GXUtil.WriteLog("usuarios:[seudo value changed for attri]"+"UsuPassword");
                  GXUtil.WriteLogRaw("Old: ",Z51UsuPassword);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A51UsuPassword[0]);
               }
               if ( StringUtil.StrCmp(Z52UsuEst, T000G2_A52UsuEst[0]) != 0 )
               {
                  GXUtil.WriteLog("usuarios:[seudo value changed for attri]"+"UsuEst");
                  GXUtil.WriteLogRaw("Old: ",Z52UsuEst);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A52UsuEst[0]);
               }
               if ( StringUtil.StrCmp(Z53UsuRol, T000G2_A53UsuRol[0]) != 0 )
               {
                  GXUtil.WriteLog("usuarios:[seudo value changed for attri]"+"UsuRol");
                  GXUtil.WriteLogRaw("Old: ",Z53UsuRol);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A53UsuRol[0]);
               }
               if ( StringUtil.StrCmp(Z86UsuNivel, T000G2_A86UsuNivel[0]) != 0 )
               {
                  GXUtil.WriteLog("usuarios:[seudo value changed for attri]"+"UsuNivel");
                  GXUtil.WriteLogRaw("Old: ",Z86UsuNivel);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A86UsuNivel[0]);
               }
               if ( StringUtil.StrCmp(Z89UsuObserv, T000G2_A89UsuObserv[0]) != 0 )
               {
                  GXUtil.WriteLog("usuarios:[seudo value changed for attri]"+"UsuObserv");
                  GXUtil.WriteLogRaw("Old: ",Z89UsuObserv);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A89UsuObserv[0]);
               }
               if ( StringUtil.StrCmp(Z90UsuCorreo, T000G2_A90UsuCorreo[0]) != 0 )
               {
                  GXUtil.WriteLog("usuarios:[seudo value changed for attri]"+"UsuCorreo");
                  GXUtil.WriteLogRaw("Old: ",Z90UsuCorreo);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A90UsuCorreo[0]);
               }
               if ( StringUtil.StrCmp(Z138UsuClaveCorreo, T000G2_A138UsuClaveCorreo[0]) != 0 )
               {
                  GXUtil.WriteLog("usuarios:[seudo value changed for attri]"+"UsuClaveCorreo");
                  GXUtil.WriteLogRaw("Old: ",Z138UsuClaveCorreo);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A138UsuClaveCorreo[0]);
               }
               if ( StringUtil.StrCmp(Z91UsuSMTP, T000G2_A91UsuSMTP[0]) != 0 )
               {
                  GXUtil.WriteLog("usuarios:[seudo value changed for attri]"+"UsuSMTP");
                  GXUtil.WriteLogRaw("Old: ",Z91UsuSMTP);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A91UsuSMTP[0]);
               }
               if ( Z92UsuPuerto != T000G2_A92UsuPuerto[0] )
               {
                  GXUtil.WriteLog("usuarios:[seudo value changed for attri]"+"UsuPuerto");
                  GXUtil.WriteLogRaw("Old: ",Z92UsuPuerto);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A92UsuPuerto[0]);
               }
               if ( StringUtil.StrCmp(Z398UsuAlias, T000G2_A398UsuAlias[0]) != 0 )
               {
                  GXUtil.WriteLog("usuarios:[seudo value changed for attri]"+"UsuAlias");
                  GXUtil.WriteLogRaw("Old: ",Z398UsuAlias);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A398UsuAlias[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Usuarios"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0G3( )
      {
         BeforeValidate0G3( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0G3( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0G3( 0) ;
            CheckOptimisticConcurrency0G3( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0G3( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0G3( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000G8 */
                     pr_default.execute(6, new Object[] {A3UsuCod, n50UsuName, A50UsuName, n51UsuPassword, A51UsuPassword, n52UsuEst, A52UsuEst, n53UsuRol, A53UsuRol, n86UsuNivel, A86UsuNivel, n89UsuObserv, A89UsuObserv, n90UsuCorreo, A90UsuCorreo, n138UsuClaveCorreo, A138UsuClaveCorreo, n91UsuSMTP, A91UsuSMTP, n92UsuPuerto, A92UsuPuerto, n398UsuAlias, A398UsuAlias});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("Usuarios") ;
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
                           ResetCaption0G0( ) ;
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
               Load0G3( ) ;
            }
            EndLevel0G3( ) ;
         }
         CloseExtendedTableCursors0G3( ) ;
      }

      protected void Update0G3( )
      {
         BeforeValidate0G3( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0G3( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0G3( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0G3( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0G3( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000G9 */
                     pr_default.execute(7, new Object[] {n50UsuName, A50UsuName, n51UsuPassword, A51UsuPassword, n52UsuEst, A52UsuEst, n53UsuRol, A53UsuRol, n86UsuNivel, A86UsuNivel, n89UsuObserv, A89UsuObserv, n90UsuCorreo, A90UsuCorreo, n138UsuClaveCorreo, A138UsuClaveCorreo, n91UsuSMTP, A91UsuSMTP, n92UsuPuerto, A92UsuPuerto, n398UsuAlias, A398UsuAlias, A3UsuCod});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("Usuarios") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Usuarios"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0G3( ) ;
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
            EndLevel0G3( ) ;
         }
         CloseExtendedTableCursors0G3( ) ;
      }

      protected void DeferredUpdate0G3( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0G3( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0G3( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0G3( ) ;
            AfterConfirm0G3( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0G3( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000G10 */
                  pr_default.execute(8, new Object[] {A3UsuCod});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("Usuarios") ;
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
         sMode3 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0G3( ) ;
         Gx_mode = sMode3;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0G3( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV12Pgmname = "Usuarios";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Pgmname", AV12Pgmname);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000G11 */
            pr_default.execute(9, new Object[] {A3UsuCod});
            if ( (pr_default.getStatus(9) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Periodos"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(9);
            /* Using cursor T000G12 */
            pr_default.execute(10, new Object[] {A3UsuCod});
            if ( (pr_default.getStatus(10) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Prod Precio"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(10);
            /* Using cursor T000G13 */
            pr_default.execute(11, new Object[] {A3UsuCod});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Level1"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(11);
            /* Using cursor T000G14 */
            pr_default.execute(12, new Object[] {A3UsuCod});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Emails"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(12);
         }
      }

      protected void EndLevel0G3( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0G3( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("usuarios",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0G0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("usuarios",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0G3( )
      {
         /* Scan By routine */
         /* Using cursor T000G15 */
         pr_default.execute(13);
         RcdFound3 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound3 = 1;
            A3UsuCod = T000G15_A3UsuCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0G3( )
      {
         /* Scan next routine */
         pr_default.readNext(13);
         RcdFound3 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound3 = 1;
            A3UsuCod = T000G15_A3UsuCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
         }
      }

      protected void ScanEnd0G3( )
      {
         pr_default.close(13);
      }

      protected void AfterConfirm0G3( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0G3( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0G3( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0G3( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0G3( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0G3( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0G3( )
      {
         edtUsuCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuCod_Enabled), 5, 0)), true);
         edtUsuName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuName_Enabled), 5, 0)), true);
         edtUsuAlias_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuAlias_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuAlias_Enabled), 5, 0)), true);
         edtUsuPassword_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuPassword_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuPassword_Enabled), 5, 0)), true);
         chkUsuEst.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkUsuEst_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkUsuEst.Enabled), 5, 0)), true);
         cmbUsuRol.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbUsuRol_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbUsuRol.Enabled), 5, 0)), true);
         edtUsuCorreo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuCorreo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuCorreo_Enabled), 5, 0)), true);
         edtUsuClaveCorreo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuClaveCorreo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuClaveCorreo_Enabled), 5, 0)), true);
         edtUsuPuerto_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuPuerto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuPuerto_Enabled), 5, 0)), true);
         edtUsuSMTP_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuSMTP_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuSMTP_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0G3( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0G0( )
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
         context.SendWebValue( "Usuarios") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20232121517197", false);
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
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "";
         bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("usuarios.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV7Usucod))+"\">") ;
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
         forbiddenHiddens = "hsh" + "Usuarios";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A86UsuNivel, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A89UsuObserv, ""));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("usuarios:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GXUtil.WriteLog("usuarios:[SendSecurityCheck value for]"+"UsuNivel:"+StringUtil.RTrim( context.localUtil.Format( A86UsuNivel, "")));
         GXUtil.WriteLog("usuarios:[SendSecurityCheck value for]"+"UsuObserv:"+StringUtil.RTrim( context.localUtil.Format( A89UsuObserv, "")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z3UsuCod", StringUtil.RTrim( Z3UsuCod));
         GxWebStd.gx_hidden_field( context, "Z50UsuName", Z50UsuName);
         GxWebStd.gx_hidden_field( context, "Z51UsuPassword", StringUtil.RTrim( Z51UsuPassword));
         GxWebStd.gx_hidden_field( context, "Z52UsuEst", StringUtil.RTrim( Z52UsuEst));
         GxWebStd.gx_hidden_field( context, "Z53UsuRol", StringUtil.RTrim( Z53UsuRol));
         GxWebStd.gx_hidden_field( context, "Z86UsuNivel", StringUtil.RTrim( Z86UsuNivel));
         GxWebStd.gx_hidden_field( context, "Z89UsuObserv", StringUtil.RTrim( Z89UsuObserv));
         GxWebStd.gx_hidden_field( context, "Z90UsuCorreo", StringUtil.RTrim( Z90UsuCorreo));
         GxWebStd.gx_hidden_field( context, "Z138UsuClaveCorreo", StringUtil.RTrim( Z138UsuClaveCorreo));
         GxWebStd.gx_hidden_field( context, "Z91UsuSMTP", StringUtil.RTrim( Z91UsuSMTP));
         GxWebStd.gx_hidden_field( context, "Z92UsuPuerto", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z92UsuPuerto), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z398UsuAlias", StringUtil.RTrim( Z398UsuAlias));
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
         GxWebStd.gx_hidden_field( context, "vEMAILID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11emailID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vUSUCOD", StringUtil.RTrim( AV7Usucod));
         GxWebStd.gx_hidden_field( context, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV7Usucod, "")), context));
         GxWebStd.gx_hidden_field( context, "USUNIVEL", StringUtil.RTrim( A86UsuNivel));
         GxWebStd.gx_hidden_field( context, "USUOBSERV", StringUtil.RTrim( A89UsuObserv));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV12Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "TAB2_Objectcall", StringUtil.RTrim( Tab2_Objectcall));
         GxWebStd.gx_hidden_field( context, "TAB2_Enabled", StringUtil.BoolToStr( Tab2_Enabled));
         GxWebStd.gx_hidden_field( context, "TAB2_Class", StringUtil.RTrim( Tab2_Class));
         GxWebStd.gx_hidden_field( context, "TAB2_Pagecount", StringUtil.LTrim( StringUtil.NToC( (decimal)(Tab2_Pagecount), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TAB2_Historymanagement", StringUtil.BoolToStr( Tab2_Historymanagement));
      }

      protected void RenderHtmlCloseForm0G3( )
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
         return "Usuarios" ;
      }

      public override String GetPgmdesc( )
      {
         return "Usuarios" ;
      }

      protected void InitializeNonKey0G3( )
      {
         A50UsuName = "";
         n50UsuName = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50UsuName", A50UsuName);
         n50UsuName = (String.IsNullOrEmpty(StringUtil.RTrim( A50UsuName)) ? true : false);
         A51UsuPassword = "";
         n51UsuPassword = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51UsuPassword", A51UsuPassword);
         n51UsuPassword = (String.IsNullOrEmpty(StringUtil.RTrim( A51UsuPassword)) ? true : false);
         A52UsuEst = "";
         n52UsuEst = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52UsuEst", A52UsuEst);
         n52UsuEst = (String.IsNullOrEmpty(StringUtil.RTrim( A52UsuEst)) ? true : false);
         A53UsuRol = "";
         n53UsuRol = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53UsuRol", A53UsuRol);
         n53UsuRol = (String.IsNullOrEmpty(StringUtil.RTrim( A53UsuRol)) ? true : false);
         A86UsuNivel = "";
         n86UsuNivel = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A86UsuNivel", A86UsuNivel);
         A89UsuObserv = "";
         n89UsuObserv = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A89UsuObserv", A89UsuObserv);
         A90UsuCorreo = "";
         n90UsuCorreo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90UsuCorreo", A90UsuCorreo);
         n90UsuCorreo = (String.IsNullOrEmpty(StringUtil.RTrim( A90UsuCorreo)) ? true : false);
         A138UsuClaveCorreo = "";
         n138UsuClaveCorreo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A138UsuClaveCorreo", A138UsuClaveCorreo);
         n138UsuClaveCorreo = (String.IsNullOrEmpty(StringUtil.RTrim( A138UsuClaveCorreo)) ? true : false);
         A91UsuSMTP = "";
         n91UsuSMTP = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91UsuSMTP", A91UsuSMTP);
         n91UsuSMTP = (String.IsNullOrEmpty(StringUtil.RTrim( A91UsuSMTP)) ? true : false);
         A92UsuPuerto = 0;
         n92UsuPuerto = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92UsuPuerto", StringUtil.LTrim( StringUtil.Str( (decimal)(A92UsuPuerto), 4, 0)));
         n92UsuPuerto = ((0==A92UsuPuerto) ? true : false);
         A398UsuAlias = "";
         n398UsuAlias = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A398UsuAlias", A398UsuAlias);
         n398UsuAlias = (String.IsNullOrEmpty(StringUtil.RTrim( A398UsuAlias)) ? true : false);
         Z50UsuName = "";
         Z51UsuPassword = "";
         Z52UsuEst = "";
         Z53UsuRol = "";
         Z86UsuNivel = "";
         Z89UsuObserv = "";
         Z90UsuCorreo = "";
         Z138UsuClaveCorreo = "";
         Z91UsuSMTP = "";
         Z92UsuPuerto = 0;
         Z398UsuAlias = "";
      }

      protected void InitAll0G3( )
      {
         A3UsuCod = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
         InitializeNonKey0G3( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202321215171938", true);
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
         context.AddJavascriptSource("usuarios.js", "?202321215171939", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false);
         context.AddJavascriptSource("Tab/TabRender.js", "", false);
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
         edtUsuCod_Internalname = "USUCOD";
         edtUsuName_Internalname = "USUNAME";
         edtUsuAlias_Internalname = "USUALIAS";
         edtUsuPassword_Internalname = "USUPASSWORD";
         chkUsuEst_Internalname = "USUEST";
         cmbUsuRol_Internalname = "USUROL";
         lblTabpage1_title_Internalname = "TABPAGE1_TITLE";
         edtUsuCorreo_Internalname = "USUCORREO";
         edtUsuClaveCorreo_Internalname = "USUCLAVECORREO";
         divDatacorreo_Internalname = "DATACORREO";
         lblTabpage2_title_Internalname = "TABPAGE2_TITLE";
         edtUsuPuerto_Internalname = "USUPUERTO";
         edtUsuSMTP_Internalname = "USUSMTP";
         divTabpage2table_Internalname = "TABPAGE2TABLE";
         Tab2_Internalname = "TAB2";
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
         Tab2_Historymanagement = Convert.ToBoolean( 0);
         Tab2_Pagecount = 2;
         Tab2_Class = "Tab";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtUsuSMTP_Jsonclick = "";
         edtUsuSMTP_Enabled = 1;
         edtUsuPuerto_Jsonclick = "";
         edtUsuPuerto_Enabled = 1;
         edtUsuClaveCorreo_Jsonclick = "";
         edtUsuClaveCorreo_Enabled = 1;
         edtUsuCorreo_Jsonclick = "";
         edtUsuCorreo_Enabled = 1;
         cmbUsuRol_Jsonclick = "";
         cmbUsuRol.Enabled = 1;
         chkUsuEst.Enabled = 1;
         edtUsuPassword_Jsonclick = "";
         edtUsuPassword_Enabled = 1;
         edtUsuAlias_Jsonclick = "";
         edtUsuAlias_Enabled = 1;
         edtUsuName_Jsonclick = "";
         edtUsuName_Enabled = 1;
         edtUsuCod_Jsonclick = "";
         edtUsuCod_Enabled = 1;
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
         chkUsuEst.Name = "USUEST";
         chkUsuEst.WebTags = "";
         chkUsuEst.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkUsuEst_Internalname, "TitleCaption", chkUsuEst.Caption, true);
         chkUsuEst.CheckedValue = "I";
         cmbUsuRol.Name = "USUROL";
         cmbUsuRol.WebTags = "";
         cmbUsuRol.addItem("", "Seleccionar", 0);
         cmbUsuRol.addItem("ADM", "ADMINISTRADOR", 0);
         cmbUsuRol.addItem("VEN", "VENDEDOR", 0);
         cmbUsuRol.addItem("BAS", "BASICO", 0);
         cmbUsuRol.addItem("SPR", "SUPERVISOR/A", 0);
         if ( cmbUsuRol.ItemCount > 0 )
         {
            A53UsuRol = cmbUsuRol.getValidValue(A53UsuRol);
            n53UsuRol = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53UsuRol", A53UsuRol);
         }
         /* End function init_web_controls */
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7Usucod',fld:'vUSUCOD',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7Usucod',fld:'vUSUCOD',pic:'',hsh:true},{av:'A86UsuNivel',fld:'USUNIVEL',pic:''},{av:'A89UsuObserv',fld:'USUOBSERV',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120G2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'AV11emailID',fld:'vEMAILID',pic:'ZZZ9'},{av:'A3UsuCod',fld:'USUCOD',pic:''}]");
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
         wcpOAV7Usucod = "";
         Z3UsuCod = "";
         Z50UsuName = "";
         Z51UsuPassword = "";
         Z52UsuEst = "";
         Z53UsuRol = "";
         Z86UsuNivel = "";
         Z89UsuObserv = "";
         Z90UsuCorreo = "";
         Z138UsuClaveCorreo = "";
         Z91UsuSMTP = "";
         Z398UsuAlias = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         A53UsuRol = "";
         lblTitle_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         A3UsuCod = "";
         A50UsuName = "";
         A398UsuAlias = "";
         A51UsuPassword = "";
         A52UsuEst = "";
         lblTabpage1_title_Jsonclick = "";
         A90UsuCorreo = "";
         A138UsuClaveCorreo = "";
         lblTabpage2_title_Jsonclick = "";
         A91UsuSMTP = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         A86UsuNivel = "";
         A89UsuObserv = "";
         AV12Pgmname = "";
         Tab2_Objectcall = "";
         Tab2_Activepagecontrolname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode3 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         T000G4_A3UsuCod = new String[] {""} ;
         T000G4_A50UsuName = new String[] {""} ;
         T000G4_n50UsuName = new bool[] {false} ;
         T000G4_A51UsuPassword = new String[] {""} ;
         T000G4_n51UsuPassword = new bool[] {false} ;
         T000G4_A52UsuEst = new String[] {""} ;
         T000G4_n52UsuEst = new bool[] {false} ;
         T000G4_A53UsuRol = new String[] {""} ;
         T000G4_n53UsuRol = new bool[] {false} ;
         T000G4_A86UsuNivel = new String[] {""} ;
         T000G4_n86UsuNivel = new bool[] {false} ;
         T000G4_A89UsuObserv = new String[] {""} ;
         T000G4_n89UsuObserv = new bool[] {false} ;
         T000G4_A90UsuCorreo = new String[] {""} ;
         T000G4_n90UsuCorreo = new bool[] {false} ;
         T000G4_A138UsuClaveCorreo = new String[] {""} ;
         T000G4_n138UsuClaveCorreo = new bool[] {false} ;
         T000G4_A91UsuSMTP = new String[] {""} ;
         T000G4_n91UsuSMTP = new bool[] {false} ;
         T000G4_A92UsuPuerto = new short[1] ;
         T000G4_n92UsuPuerto = new bool[] {false} ;
         T000G4_A398UsuAlias = new String[] {""} ;
         T000G4_n398UsuAlias = new bool[] {false} ;
         T000G5_A3UsuCod = new String[] {""} ;
         T000G3_A3UsuCod = new String[] {""} ;
         T000G3_A50UsuName = new String[] {""} ;
         T000G3_n50UsuName = new bool[] {false} ;
         T000G3_A51UsuPassword = new String[] {""} ;
         T000G3_n51UsuPassword = new bool[] {false} ;
         T000G3_A52UsuEst = new String[] {""} ;
         T000G3_n52UsuEst = new bool[] {false} ;
         T000G3_A53UsuRol = new String[] {""} ;
         T000G3_n53UsuRol = new bool[] {false} ;
         T000G3_A86UsuNivel = new String[] {""} ;
         T000G3_n86UsuNivel = new bool[] {false} ;
         T000G3_A89UsuObserv = new String[] {""} ;
         T000G3_n89UsuObserv = new bool[] {false} ;
         T000G3_A90UsuCorreo = new String[] {""} ;
         T000G3_n90UsuCorreo = new bool[] {false} ;
         T000G3_A138UsuClaveCorreo = new String[] {""} ;
         T000G3_n138UsuClaveCorreo = new bool[] {false} ;
         T000G3_A91UsuSMTP = new String[] {""} ;
         T000G3_n91UsuSMTP = new bool[] {false} ;
         T000G3_A92UsuPuerto = new short[1] ;
         T000G3_n92UsuPuerto = new bool[] {false} ;
         T000G3_A398UsuAlias = new String[] {""} ;
         T000G3_n398UsuAlias = new bool[] {false} ;
         T000G6_A3UsuCod = new String[] {""} ;
         T000G7_A3UsuCod = new String[] {""} ;
         T000G2_A3UsuCod = new String[] {""} ;
         T000G2_A50UsuName = new String[] {""} ;
         T000G2_n50UsuName = new bool[] {false} ;
         T000G2_A51UsuPassword = new String[] {""} ;
         T000G2_n51UsuPassword = new bool[] {false} ;
         T000G2_A52UsuEst = new String[] {""} ;
         T000G2_n52UsuEst = new bool[] {false} ;
         T000G2_A53UsuRol = new String[] {""} ;
         T000G2_n53UsuRol = new bool[] {false} ;
         T000G2_A86UsuNivel = new String[] {""} ;
         T000G2_n86UsuNivel = new bool[] {false} ;
         T000G2_A89UsuObserv = new String[] {""} ;
         T000G2_n89UsuObserv = new bool[] {false} ;
         T000G2_A90UsuCorreo = new String[] {""} ;
         T000G2_n90UsuCorreo = new bool[] {false} ;
         T000G2_A138UsuClaveCorreo = new String[] {""} ;
         T000G2_n138UsuClaveCorreo = new bool[] {false} ;
         T000G2_A91UsuSMTP = new String[] {""} ;
         T000G2_n91UsuSMTP = new bool[] {false} ;
         T000G2_A92UsuPuerto = new short[1] ;
         T000G2_n92UsuPuerto = new bool[] {false} ;
         T000G2_A398UsuAlias = new String[] {""} ;
         T000G2_n398UsuAlias = new bool[] {false} ;
         T000G11_A1EmpID = new short[1] ;
         T000G11_A327procesoCod = new String[] {""} ;
         T000G12_A1EmpID = new short[1] ;
         T000G12_A2AgeID = new short[1] ;
         T000G12_A310ProdPreID = new short[1] ;
         T000G12_A286PrdCod = new short[1] ;
         T000G13_A3UsuCod = new String[] {""} ;
         T000G13_A15empcod = new short[1] ;
         T000G13_A16agecod = new short[1] ;
         T000G13_A11ModCod = new short[1] ;
         T000G13_A12MenCod = new short[1] ;
         T000G13_A13SubCod = new short[1] ;
         T000G14_A29emailID = new short[1] ;
         T000G14_A3UsuCod = new String[] {""} ;
         T000G15_A3UsuCod = new String[] {""} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.usuarios__default(),
            new Object[][] {
                new Object[] {
               T000G2_A3UsuCod, T000G2_A50UsuName, T000G2_n50UsuName, T000G2_A51UsuPassword, T000G2_n51UsuPassword, T000G2_A52UsuEst, T000G2_n52UsuEst, T000G2_A53UsuRol, T000G2_n53UsuRol, T000G2_A86UsuNivel,
               T000G2_n86UsuNivel, T000G2_A89UsuObserv, T000G2_n89UsuObserv, T000G2_A90UsuCorreo, T000G2_n90UsuCorreo, T000G2_A138UsuClaveCorreo, T000G2_n138UsuClaveCorreo, T000G2_A91UsuSMTP, T000G2_n91UsuSMTP, T000G2_A92UsuPuerto,
               T000G2_n92UsuPuerto, T000G2_A398UsuAlias, T000G2_n398UsuAlias
               }
               , new Object[] {
               T000G3_A3UsuCod, T000G3_A50UsuName, T000G3_n50UsuName, T000G3_A51UsuPassword, T000G3_n51UsuPassword, T000G3_A52UsuEst, T000G3_n52UsuEst, T000G3_A53UsuRol, T000G3_n53UsuRol, T000G3_A86UsuNivel,
               T000G3_n86UsuNivel, T000G3_A89UsuObserv, T000G3_n89UsuObserv, T000G3_A90UsuCorreo, T000G3_n90UsuCorreo, T000G3_A138UsuClaveCorreo, T000G3_n138UsuClaveCorreo, T000G3_A91UsuSMTP, T000G3_n91UsuSMTP, T000G3_A92UsuPuerto,
               T000G3_n92UsuPuerto, T000G3_A398UsuAlias, T000G3_n398UsuAlias
               }
               , new Object[] {
               T000G4_A3UsuCod, T000G4_A50UsuName, T000G4_n50UsuName, T000G4_A51UsuPassword, T000G4_n51UsuPassword, T000G4_A52UsuEst, T000G4_n52UsuEst, T000G4_A53UsuRol, T000G4_n53UsuRol, T000G4_A86UsuNivel,
               T000G4_n86UsuNivel, T000G4_A89UsuObserv, T000G4_n89UsuObserv, T000G4_A90UsuCorreo, T000G4_n90UsuCorreo, T000G4_A138UsuClaveCorreo, T000G4_n138UsuClaveCorreo, T000G4_A91UsuSMTP, T000G4_n91UsuSMTP, T000G4_A92UsuPuerto,
               T000G4_n92UsuPuerto, T000G4_A398UsuAlias, T000G4_n398UsuAlias
               }
               , new Object[] {
               T000G5_A3UsuCod
               }
               , new Object[] {
               T000G6_A3UsuCod
               }
               , new Object[] {
               T000G7_A3UsuCod
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000G11_A1EmpID, T000G11_A327procesoCod
               }
               , new Object[] {
               T000G12_A1EmpID, T000G12_A2AgeID, T000G12_A310ProdPreID, T000G12_A286PrdCod
               }
               , new Object[] {
               T000G13_A3UsuCod, T000G13_A15empcod, T000G13_A16agecod, T000G13_A11ModCod, T000G13_A12MenCod, T000G13_A13SubCod
               }
               , new Object[] {
               T000G14_A29emailID, T000G14_A3UsuCod
               }
               , new Object[] {
               T000G15_A3UsuCod
               }
            }
         );
         AV12Pgmname = "Usuarios";
      }

      private short Z92UsuPuerto ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short A92UsuPuerto ;
      private short RcdFound3 ;
      private short AV11emailID ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtUsuCod_Enabled ;
      private int edtUsuName_Enabled ;
      private int edtUsuAlias_Enabled ;
      private int edtUsuPassword_Enabled ;
      private int edtUsuCorreo_Enabled ;
      private int edtUsuClaveCorreo_Enabled ;
      private int edtUsuPuerto_Enabled ;
      private int edtUsuSMTP_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int Tab2_Activepage ;
      private int Tab2_Pagecount ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String wcpOAV7Usucod ;
      private String Z3UsuCod ;
      private String Z51UsuPassword ;
      private String Z52UsuEst ;
      private String Z53UsuRol ;
      private String Z86UsuNivel ;
      private String Z89UsuObserv ;
      private String Z90UsuCorreo ;
      private String Z138UsuClaveCorreo ;
      private String Z91UsuSMTP ;
      private String Z398UsuAlias ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String AV7Usucod ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtUsuCod_Internalname ;
      private String A53UsuRol ;
      private String cmbUsuRol_Internalname ;
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
      private String A3UsuCod ;
      private String edtUsuCod_Jsonclick ;
      private String edtUsuName_Internalname ;
      private String edtUsuName_Jsonclick ;
      private String edtUsuAlias_Internalname ;
      private String A398UsuAlias ;
      private String edtUsuAlias_Jsonclick ;
      private String edtUsuPassword_Internalname ;
      private String A51UsuPassword ;
      private String edtUsuPassword_Jsonclick ;
      private String chkUsuEst_Internalname ;
      private String A52UsuEst ;
      private String cmbUsuRol_Jsonclick ;
      private String lblTabpage1_title_Internalname ;
      private String lblTabpage1_title_Jsonclick ;
      private String divDatacorreo_Internalname ;
      private String edtUsuCorreo_Internalname ;
      private String A90UsuCorreo ;
      private String edtUsuCorreo_Jsonclick ;
      private String edtUsuClaveCorreo_Internalname ;
      private String A138UsuClaveCorreo ;
      private String edtUsuClaveCorreo_Jsonclick ;
      private String lblTabpage2_title_Internalname ;
      private String lblTabpage2_title_Jsonclick ;
      private String divTabpage2table_Internalname ;
      private String edtUsuPuerto_Internalname ;
      private String edtUsuPuerto_Jsonclick ;
      private String edtUsuSMTP_Internalname ;
      private String A91UsuSMTP ;
      private String edtUsuSMTP_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String A86UsuNivel ;
      private String A89UsuObserv ;
      private String AV12Pgmname ;
      private String Tab2_Objectcall ;
      private String Tab2_Class ;
      private String Tab2_Activepagecontrolname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode3 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String Tab2_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n53UsuRol ;
      private bool n50UsuName ;
      private bool n398UsuAlias ;
      private bool n51UsuPassword ;
      private bool n52UsuEst ;
      private bool n90UsuCorreo ;
      private bool n138UsuClaveCorreo ;
      private bool n92UsuPuerto ;
      private bool n91UsuSMTP ;
      private bool n86UsuNivel ;
      private bool n89UsuObserv ;
      private bool Tab2_Enabled ;
      private bool Tab2_Historymanagement ;
      private bool Tab2_Visible ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private String Z50UsuName ;
      private String A50UsuName ;
      private IGxSession AV10WebSession ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCheckbox chkUsuEst ;
      private GXCombobox cmbUsuRol ;
      private IDataStoreProvider pr_default ;
      private String[] T000G4_A3UsuCod ;
      private String[] T000G4_A50UsuName ;
      private bool[] T000G4_n50UsuName ;
      private String[] T000G4_A51UsuPassword ;
      private bool[] T000G4_n51UsuPassword ;
      private String[] T000G4_A52UsuEst ;
      private bool[] T000G4_n52UsuEst ;
      private String[] T000G4_A53UsuRol ;
      private bool[] T000G4_n53UsuRol ;
      private String[] T000G4_A86UsuNivel ;
      private bool[] T000G4_n86UsuNivel ;
      private String[] T000G4_A89UsuObserv ;
      private bool[] T000G4_n89UsuObserv ;
      private String[] T000G4_A90UsuCorreo ;
      private bool[] T000G4_n90UsuCorreo ;
      private String[] T000G4_A138UsuClaveCorreo ;
      private bool[] T000G4_n138UsuClaveCorreo ;
      private String[] T000G4_A91UsuSMTP ;
      private bool[] T000G4_n91UsuSMTP ;
      private short[] T000G4_A92UsuPuerto ;
      private bool[] T000G4_n92UsuPuerto ;
      private String[] T000G4_A398UsuAlias ;
      private bool[] T000G4_n398UsuAlias ;
      private String[] T000G5_A3UsuCod ;
      private String[] T000G3_A3UsuCod ;
      private String[] T000G3_A50UsuName ;
      private bool[] T000G3_n50UsuName ;
      private String[] T000G3_A51UsuPassword ;
      private bool[] T000G3_n51UsuPassword ;
      private String[] T000G3_A52UsuEst ;
      private bool[] T000G3_n52UsuEst ;
      private String[] T000G3_A53UsuRol ;
      private bool[] T000G3_n53UsuRol ;
      private String[] T000G3_A86UsuNivel ;
      private bool[] T000G3_n86UsuNivel ;
      private String[] T000G3_A89UsuObserv ;
      private bool[] T000G3_n89UsuObserv ;
      private String[] T000G3_A90UsuCorreo ;
      private bool[] T000G3_n90UsuCorreo ;
      private String[] T000G3_A138UsuClaveCorreo ;
      private bool[] T000G3_n138UsuClaveCorreo ;
      private String[] T000G3_A91UsuSMTP ;
      private bool[] T000G3_n91UsuSMTP ;
      private short[] T000G3_A92UsuPuerto ;
      private bool[] T000G3_n92UsuPuerto ;
      private String[] T000G3_A398UsuAlias ;
      private bool[] T000G3_n398UsuAlias ;
      private String[] T000G6_A3UsuCod ;
      private String[] T000G7_A3UsuCod ;
      private String[] T000G2_A3UsuCod ;
      private String[] T000G2_A50UsuName ;
      private bool[] T000G2_n50UsuName ;
      private String[] T000G2_A51UsuPassword ;
      private bool[] T000G2_n51UsuPassword ;
      private String[] T000G2_A52UsuEst ;
      private bool[] T000G2_n52UsuEst ;
      private String[] T000G2_A53UsuRol ;
      private bool[] T000G2_n53UsuRol ;
      private String[] T000G2_A86UsuNivel ;
      private bool[] T000G2_n86UsuNivel ;
      private String[] T000G2_A89UsuObserv ;
      private bool[] T000G2_n89UsuObserv ;
      private String[] T000G2_A90UsuCorreo ;
      private bool[] T000G2_n90UsuCorreo ;
      private String[] T000G2_A138UsuClaveCorreo ;
      private bool[] T000G2_n138UsuClaveCorreo ;
      private String[] T000G2_A91UsuSMTP ;
      private bool[] T000G2_n91UsuSMTP ;
      private short[] T000G2_A92UsuPuerto ;
      private bool[] T000G2_n92UsuPuerto ;
      private String[] T000G2_A398UsuAlias ;
      private bool[] T000G2_n398UsuAlias ;
      private short[] T000G11_A1EmpID ;
      private String[] T000G11_A327procesoCod ;
      private short[] T000G12_A1EmpID ;
      private short[] T000G12_A2AgeID ;
      private short[] T000G12_A310ProdPreID ;
      private short[] T000G12_A286PrdCod ;
      private String[] T000G13_A3UsuCod ;
      private short[] T000G13_A15empcod ;
      private short[] T000G13_A16agecod ;
      private short[] T000G13_A11ModCod ;
      private short[] T000G13_A12MenCod ;
      private short[] T000G13_A13SubCod ;
      private short[] T000G14_A29emailID ;
      private String[] T000G14_A3UsuCod ;
      private String[] T000G15_A3UsuCod ;
      private SdtTransactionContext AV9TrnContext ;
   }

   public class usuarios__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT000G4 ;
          prmT000G4 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000G5 ;
          prmT000G5 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000G3 ;
          prmT000G3 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000G6 ;
          prmT000G6 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000G7 ;
          prmT000G7 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000G2 ;
          prmT000G2 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000G8 ;
          prmT000G8 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0} ,
          new Object[] {"@UsuName",SqlDbType.VarChar,40,0} ,
          new Object[] {"@UsuPassword",SqlDbType.Char,60,0} ,
          new Object[] {"@UsuEst",SqlDbType.Char,1,0} ,
          new Object[] {"@UsuRol",SqlDbType.Char,5,0} ,
          new Object[] {"@UsuNivel",SqlDbType.Char,1,0} ,
          new Object[] {"@UsuObserv",SqlDbType.Char,100,0} ,
          new Object[] {"@UsuCorreo",SqlDbType.Char,60,0} ,
          new Object[] {"@UsuClaveCorreo",SqlDbType.Char,60,0} ,
          new Object[] {"@UsuSMTP",SqlDbType.Char,50,0} ,
          new Object[] {"@UsuPuerto",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@UsuAlias",SqlDbType.Char,40,0}
          } ;
          Object[] prmT000G9 ;
          prmT000G9 = new Object[] {
          new Object[] {"@UsuName",SqlDbType.VarChar,40,0} ,
          new Object[] {"@UsuPassword",SqlDbType.Char,60,0} ,
          new Object[] {"@UsuEst",SqlDbType.Char,1,0} ,
          new Object[] {"@UsuRol",SqlDbType.Char,5,0} ,
          new Object[] {"@UsuNivel",SqlDbType.Char,1,0} ,
          new Object[] {"@UsuObserv",SqlDbType.Char,100,0} ,
          new Object[] {"@UsuCorreo",SqlDbType.Char,60,0} ,
          new Object[] {"@UsuClaveCorreo",SqlDbType.Char,60,0} ,
          new Object[] {"@UsuSMTP",SqlDbType.Char,50,0} ,
          new Object[] {"@UsuPuerto",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@UsuAlias",SqlDbType.Char,40,0} ,
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000G10 ;
          prmT000G10 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000G11 ;
          prmT000G11 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000G12 ;
          prmT000G12 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000G13 ;
          prmT000G13 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000G14 ;
          prmT000G14 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000G15 ;
          prmT000G15 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T000G2", "SELECT [UsuCod], [UsuName], [UsuPassword], [UsuEst], [UsuRol], [UsuNivel], [UsuObserv], [UsuCorreo], [UsuClaveCorreo], [UsuSMTP], [UsuPuerto], [UsuAlias] FROM [Usuarios] WITH (UPDLOCK) WHERE [UsuCod] = @UsuCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G2,1,0,true,false )
             ,new CursorDef("T000G3", "SELECT [UsuCod], [UsuName], [UsuPassword], [UsuEst], [UsuRol], [UsuNivel], [UsuObserv], [UsuCorreo], [UsuClaveCorreo], [UsuSMTP], [UsuPuerto], [UsuAlias] FROM [Usuarios] WITH (NOLOCK) WHERE [UsuCod] = @UsuCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G3,1,0,true,false )
             ,new CursorDef("T000G4", "SELECT TM1.[UsuCod], TM1.[UsuName], TM1.[UsuPassword], TM1.[UsuEst], TM1.[UsuRol], TM1.[UsuNivel], TM1.[UsuObserv], TM1.[UsuCorreo], TM1.[UsuClaveCorreo], TM1.[UsuSMTP], TM1.[UsuPuerto], TM1.[UsuAlias] FROM [Usuarios] TM1 WITH (NOLOCK) WHERE TM1.[UsuCod] = @UsuCod ORDER BY TM1.[UsuCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000G4,100,0,true,false )
             ,new CursorDef("T000G5", "SELECT [UsuCod] FROM [Usuarios] WITH (NOLOCK) WHERE [UsuCod] = @UsuCod  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000G5,1,0,true,false )
             ,new CursorDef("T000G6", "SELECT TOP 1 [UsuCod] FROM [Usuarios] WITH (NOLOCK) WHERE ( [UsuCod] > @UsuCod) ORDER BY [UsuCod]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000G6,1,0,true,true )
             ,new CursorDef("T000G7", "SELECT TOP 1 [UsuCod] FROM [Usuarios] WITH (NOLOCK) WHERE ( [UsuCod] < @UsuCod) ORDER BY [UsuCod] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000G7,1,0,true,true )
             ,new CursorDef("T000G8", "INSERT INTO [Usuarios]([UsuCod], [UsuName], [UsuPassword], [UsuEst], [UsuRol], [UsuNivel], [UsuObserv], [UsuCorreo], [UsuClaveCorreo], [UsuSMTP], [UsuPuerto], [UsuAlias]) VALUES(@UsuCod, @UsuName, @UsuPassword, @UsuEst, @UsuRol, @UsuNivel, @UsuObserv, @UsuCorreo, @UsuClaveCorreo, @UsuSMTP, @UsuPuerto, @UsuAlias)", GxErrorMask.GX_NOMASK,prmT000G8)
             ,new CursorDef("T000G9", "UPDATE [Usuarios] SET [UsuName]=@UsuName, [UsuPassword]=@UsuPassword, [UsuEst]=@UsuEst, [UsuRol]=@UsuRol, [UsuNivel]=@UsuNivel, [UsuObserv]=@UsuObserv, [UsuCorreo]=@UsuCorreo, [UsuClaveCorreo]=@UsuClaveCorreo, [UsuSMTP]=@UsuSMTP, [UsuPuerto]=@UsuPuerto, [UsuAlias]=@UsuAlias  WHERE [UsuCod] = @UsuCod", GxErrorMask.GX_NOMASK,prmT000G9)
             ,new CursorDef("T000G10", "DELETE FROM [Usuarios]  WHERE [UsuCod] = @UsuCod", GxErrorMask.GX_NOMASK,prmT000G10)
             ,new CursorDef("T000G11", "SELECT TOP 1 [EmpID], [procesoCod] FROM [Periodos] WITH (NOLOCK) WHERE [PerUser] = @UsuCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G11,1,0,true,true )
             ,new CursorDef("T000G12", "SELECT TOP 1 [EmpID], [AgeID], [ProdPreID], [PrdCod] FROM [ProdPrecio] WITH (NOLOCK) WHERE [UsuCod] = @UsuCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G12,1,0,true,true )
             ,new CursorDef("T000G13", "SELECT TOP 1 [UsuCod], [empcod], [agecod], [ModCod], [MenCod], [SubCod] FROM [PERMISOS] WITH (NOLOCK) WHERE [UsuCod] = @UsuCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G13,1,0,true,true )
             ,new CursorDef("T000G14", "SELECT TOP 1 [emailID], [UsuCod] FROM [Emails] WITH (NOLOCK) WHERE [UsuCod] = @UsuCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G14,1,0,true,true )
             ,new CursorDef("T000G15", "SELECT [UsuCod] FROM [Usuarios] WITH (NOLOCK) ORDER BY [UsuCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000G15,100,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 60) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 1) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getString(6, 1) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getString(7, 100) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((String[]) buf[13])[0] = rslt.getString(8, 60) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getString(9, 60) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((String[]) buf[17])[0] = rslt.getString(10, 50) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((short[]) buf[19])[0] = rslt.getShort(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((String[]) buf[21])[0] = rslt.getString(12, 40) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 60) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 1) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getString(6, 1) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getString(7, 100) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((String[]) buf[13])[0] = rslt.getString(8, 60) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getString(9, 60) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((String[]) buf[17])[0] = rslt.getString(10, 50) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((short[]) buf[19])[0] = rslt.getShort(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((String[]) buf[21])[0] = rslt.getString(12, 40) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 60) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 1) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getString(6, 1) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getString(7, 100) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((String[]) buf[13])[0] = rslt.getString(8, 60) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getString(9, 60) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((String[]) buf[17])[0] = rslt.getString(10, 50) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((short[]) buf[19])[0] = rslt.getShort(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((String[]) buf[21])[0] = rslt.getString(12, 40) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                return;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
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
                   stmt.setNull( 6 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 7 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[12]);
                }
                if ( (bool)parms[13] )
                {
                   stmt.setNull( 8 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[14]);
                }
                if ( (bool)parms[15] )
                {
                   stmt.setNull( 9 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[16]);
                }
                if ( (bool)parms[17] )
                {
                   stmt.setNull( 10 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(10, (String)parms[18]);
                }
                if ( (bool)parms[19] )
                {
                   stmt.setNull( 11 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(11, (short)parms[20]);
                }
                if ( (bool)parms[21] )
                {
                   stmt.setNull( 12 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(12, (String)parms[22]);
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
                   stmt.setNull( 5 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 6 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 7 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[13]);
                }
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 8 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[15]);
                }
                if ( (bool)parms[16] )
                {
                   stmt.setNull( 9 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[17]);
                }
                if ( (bool)parms[18] )
                {
                   stmt.setNull( 10 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(10, (short)parms[19]);
                }
                if ( (bool)parms[20] )
                {
                   stmt.setNull( 11 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(11, (String)parms[21]);
                }
                stmt.SetParameter(12, (String)parms[22]);
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
