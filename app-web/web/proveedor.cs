/*
               File: Proveedor
        Description: Proveedor
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/26/2022 20:14:2.75
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
   public class proveedor : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
               AV7PrvRuc = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7PrvRuc", AV7PrvRuc);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vPRVRUC", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV7PrvRuc, "")), context));
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
            Form.Meta.addItem("description", "Proveedor", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtPrvRuc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public proveedor( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public proveedor( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           String aP1_PrvRuc )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7PrvRuc = aP1_PrvRuc;
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Proveedor", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Proveedor.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proveedor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proveedor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proveedor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proveedor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 5, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Proveedor.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPrvRuc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPrvRuc_Internalname, "Ruc", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPrvRuc_Internalname, StringUtil.RTrim( A37PrvRuc), StringUtil.RTrim( context.localUtil.Format( A37PrvRuc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPrvRuc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPrvRuc_Enabled, 1, "text", "", 13, "chr", 1, "row", 13, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Proveedor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPrvDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPrvDsc_Internalname, "Proveedor", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPrvDsc_Internalname, A184PrvDsc, StringUtil.RTrim( context.localUtil.Format( A184PrvDsc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPrvDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPrvDsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 150, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Proveedor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPrvDscCorta_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPrvDscCorta_Internalname, "Desc. Corta", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPrvDscCorta_Internalname, StringUtil.RTrim( A186PrvDscCorta), StringUtil.RTrim( context.localUtil.Format( A186PrvDscCorta, "@!")), TempTags+" onchange=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPrvDscCorta_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPrvDscCorta_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "nombres", "left", true, "HLP_Proveedor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPrvEmail_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPrvEmail_Internalname, "Email", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPrvEmail_Internalname, A187PrvEmail, StringUtil.RTrim( context.localUtil.Format( A187PrvEmail, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "mailto:"+A187PrvEmail, "", "", "", edtPrvEmail_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPrvEmail_Enabled, 0, "email", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, 0, true, "GeneXus\\Email", "left", true, "HLP_Proveedor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPrvTelf_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPrvTelf_Internalname, "Telefono", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            if ( context.isSmartDevice( ) )
            {
               gxphoneLink = "tel:" + StringUtil.RTrim( A188PrvTelf);
            }
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPrvTelf_Internalname, StringUtil.RTrim( A188PrvTelf), StringUtil.RTrim( context.localUtil.Format( A188PrvTelf, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", gxphoneLink, "", "", "", edtPrvTelf_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPrvTelf_Enabled, 0, "tel", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, 0, true, "GeneXus\\Phone", "left", true, "HLP_Proveedor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPrvContact_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPrvContact_Internalname, "Atencion", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPrvContact_Internalname, A189PrvContact, StringUtil.RTrim( context.localUtil.Format( A189PrvContact, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPrvContact_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPrvContact_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Proveedor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPrvEst_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPrvEst_Internalname, "Estado", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPrvEst_Internalname, StringUtil.RTrim( A185PrvEst), StringUtil.RTrim( context.localUtil.Format( A185PrvEst, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPrvEst_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPrvEst_Enabled, 0, "text", "", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, -1, true, "estado", "left", true, "HLP_Proveedor.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group Confirm", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proveedor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proveedor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proveedor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm0M31( ) ;
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
         E110M2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A37PrvRuc = cgiGet( edtPrvRuc_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PrvRuc", A37PrvRuc);
               A184PrvDsc = cgiGet( edtPrvDsc_Internalname);
               n184PrvDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184PrvDsc", A184PrvDsc);
               n184PrvDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A184PrvDsc)) ? true : false);
               A186PrvDscCorta = StringUtil.Upper( cgiGet( edtPrvDscCorta_Internalname));
               n186PrvDscCorta = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A186PrvDscCorta", A186PrvDscCorta);
               n186PrvDscCorta = (String.IsNullOrEmpty(StringUtil.RTrim( A186PrvDscCorta)) ? true : false);
               A187PrvEmail = cgiGet( edtPrvEmail_Internalname);
               n187PrvEmail = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187PrvEmail", A187PrvEmail);
               n187PrvEmail = (String.IsNullOrEmpty(StringUtil.RTrim( A187PrvEmail)) ? true : false);
               A188PrvTelf = cgiGet( edtPrvTelf_Internalname);
               n188PrvTelf = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A188PrvTelf", A188PrvTelf);
               n188PrvTelf = (String.IsNullOrEmpty(StringUtil.RTrim( A188PrvTelf)) ? true : false);
               A189PrvContact = cgiGet( edtPrvContact_Internalname);
               n189PrvContact = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A189PrvContact", A189PrvContact);
               n189PrvContact = (String.IsNullOrEmpty(StringUtil.RTrim( A189PrvContact)) ? true : false);
               A185PrvEst = cgiGet( edtPrvEst_Internalname);
               n185PrvEst = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185PrvEst", A185PrvEst);
               n185PrvEst = (String.IsNullOrEmpty(StringUtil.RTrim( A185PrvEst)) ? true : false);
               /* Read saved values. */
               Z37PrvRuc = cgiGet( "Z37PrvRuc");
               Z184PrvDsc = cgiGet( "Z184PrvDsc");
               n184PrvDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A184PrvDsc)) ? true : false);
               Z185PrvEst = cgiGet( "Z185PrvEst");
               n185PrvEst = (String.IsNullOrEmpty(StringUtil.RTrim( A185PrvEst)) ? true : false);
               Z186PrvDscCorta = cgiGet( "Z186PrvDscCorta");
               n186PrvDscCorta = (String.IsNullOrEmpty(StringUtil.RTrim( A186PrvDscCorta)) ? true : false);
               Z187PrvEmail = cgiGet( "Z187PrvEmail");
               n187PrvEmail = (String.IsNullOrEmpty(StringUtil.RTrim( A187PrvEmail)) ? true : false);
               Z188PrvTelf = cgiGet( "Z188PrvTelf");
               n188PrvTelf = (String.IsNullOrEmpty(StringUtil.RTrim( A188PrvTelf)) ? true : false);
               Z189PrvContact = cgiGet( "Z189PrvContact");
               n189PrvContact = (String.IsNullOrEmpty(StringUtil.RTrim( A189PrvContact)) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               AV7PrvRuc = cgiGet( "vPRVRUC");
               AV11Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Proveedor";
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( StringUtil.StrCmp(A37PrvRuc, Z37PrvRuc) != 0 ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("proveedor:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A37PrvRuc = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PrvRuc", A37PrvRuc);
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
                     sMode31 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode31;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound31 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0M0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "PRVRUC");
                        AnyError = 1;
                        GX_FocusControl = edtPrvRuc_Internalname;
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
                        E110M2 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: After Trn */
                        E120M2 ();
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
            E120M2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0M31( ) ;
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
            DisableAttributes0M31( ) ;
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

      protected void CONFIRM_0M0( )
      {
         BeforeValidate0M31( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0M31( ) ;
            }
            else
            {
               CheckExtendedTable0M31( ) ;
               CloseExtendedTableCursors0M31( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0M0( )
      {
      }

      protected void E110M2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV11Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "KBCalpesa22");
      }

      protected void E120M2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwproveedor.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0M31( short GX_JID )
      {
         if ( ( GX_JID == 5 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z184PrvDsc = T000M3_A184PrvDsc[0];
               Z185PrvEst = T000M3_A185PrvEst[0];
               Z186PrvDscCorta = T000M3_A186PrvDscCorta[0];
               Z187PrvEmail = T000M3_A187PrvEmail[0];
               Z188PrvTelf = T000M3_A188PrvTelf[0];
               Z189PrvContact = T000M3_A189PrvContact[0];
            }
            else
            {
               Z184PrvDsc = A184PrvDsc;
               Z185PrvEst = A185PrvEst;
               Z186PrvDscCorta = A186PrvDscCorta;
               Z187PrvEmail = A187PrvEmail;
               Z188PrvTelf = A188PrvTelf;
               Z189PrvContact = A189PrvContact;
            }
         }
         if ( GX_JID == -5 )
         {
            Z37PrvRuc = A37PrvRuc;
            Z184PrvDsc = A184PrvDsc;
            Z185PrvEst = A185PrvEst;
            Z186PrvDscCorta = A186PrvDscCorta;
            Z187PrvEmail = A187PrvEmail;
            Z188PrvTelf = A188PrvTelf;
            Z189PrvContact = A189PrvContact;
         }
      }

      protected void standaloneNotModal( )
      {
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7PrvRuc)) )
         {
            A37PrvRuc = AV7PrvRuc;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PrvRuc", A37PrvRuc);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7PrvRuc)) )
         {
            edtPrvRuc_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrvRuc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrvRuc_Enabled), 5, 0)), true);
         }
         else
         {
            edtPrvRuc_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrvRuc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrvRuc_Enabled), 5, 0)), true);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7PrvRuc)) )
         {
            edtPrvRuc_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrvRuc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrvRuc_Enabled), 5, 0)), true);
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
            AV11Pgmname = "Proveedor";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Pgmname", AV11Pgmname);
         }
      }

      protected void Load0M31( )
      {
         /* Using cursor T000M4 */
         pr_default.execute(2, new Object[] {A37PrvRuc});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound31 = 1;
            A184PrvDsc = T000M4_A184PrvDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184PrvDsc", A184PrvDsc);
            n184PrvDsc = T000M4_n184PrvDsc[0];
            A185PrvEst = T000M4_A185PrvEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185PrvEst", A185PrvEst);
            n185PrvEst = T000M4_n185PrvEst[0];
            A186PrvDscCorta = T000M4_A186PrvDscCorta[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A186PrvDscCorta", A186PrvDscCorta);
            n186PrvDscCorta = T000M4_n186PrvDscCorta[0];
            A187PrvEmail = T000M4_A187PrvEmail[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187PrvEmail", A187PrvEmail);
            n187PrvEmail = T000M4_n187PrvEmail[0];
            A188PrvTelf = T000M4_A188PrvTelf[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A188PrvTelf", A188PrvTelf);
            n188PrvTelf = T000M4_n188PrvTelf[0];
            A189PrvContact = T000M4_A189PrvContact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A189PrvContact", A189PrvContact);
            n189PrvContact = T000M4_n189PrvContact[0];
            ZM0M31( -5) ;
         }
         pr_default.close(2);
         OnLoadActions0M31( ) ;
      }

      protected void OnLoadActions0M31( )
      {
         AV11Pgmname = "Proveedor";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Pgmname", AV11Pgmname);
      }

      protected void CheckExtendedTable0M31( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV11Pgmname = "Proveedor";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Pgmname", AV11Pgmname);
         if ( ! ( GxRegex.IsMatch(A187PrvEmail,"^((\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*)|(\\s*))$") || String.IsNullOrEmpty(StringUtil.RTrim( A187PrvEmail)) ) )
         {
            GX_msglist.addItem("El valor de Prv Email no coincide con el patrón especificado", "OutOfRange", 1, "PRVEMAIL");
            AnyError = 1;
            GX_FocusControl = edtPrvEmail_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0M31( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0M31( )
      {
         /* Using cursor T000M5 */
         pr_default.execute(3, new Object[] {A37PrvRuc});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound31 = 1;
         }
         else
         {
            RcdFound31 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000M3 */
         pr_default.execute(1, new Object[] {A37PrvRuc});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0M31( 5) ;
            RcdFound31 = 1;
            A37PrvRuc = T000M3_A37PrvRuc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PrvRuc", A37PrvRuc);
            A184PrvDsc = T000M3_A184PrvDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184PrvDsc", A184PrvDsc);
            n184PrvDsc = T000M3_n184PrvDsc[0];
            A185PrvEst = T000M3_A185PrvEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185PrvEst", A185PrvEst);
            n185PrvEst = T000M3_n185PrvEst[0];
            A186PrvDscCorta = T000M3_A186PrvDscCorta[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A186PrvDscCorta", A186PrvDscCorta);
            n186PrvDscCorta = T000M3_n186PrvDscCorta[0];
            A187PrvEmail = T000M3_A187PrvEmail[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187PrvEmail", A187PrvEmail);
            n187PrvEmail = T000M3_n187PrvEmail[0];
            A188PrvTelf = T000M3_A188PrvTelf[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A188PrvTelf", A188PrvTelf);
            n188PrvTelf = T000M3_n188PrvTelf[0];
            A189PrvContact = T000M3_A189PrvContact[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A189PrvContact", A189PrvContact);
            n189PrvContact = T000M3_n189PrvContact[0];
            Z37PrvRuc = A37PrvRuc;
            sMode31 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0M31( ) ;
            if ( AnyError == 1 )
            {
               RcdFound31 = 0;
               InitializeNonKey0M31( ) ;
            }
            Gx_mode = sMode31;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound31 = 0;
            InitializeNonKey0M31( ) ;
            sMode31 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode31;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0M31( ) ;
         if ( RcdFound31 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound31 = 0;
         /* Using cursor T000M6 */
         pr_default.execute(4, new Object[] {A37PrvRuc});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( StringUtil.StrCmp(T000M6_A37PrvRuc[0], A37PrvRuc) < 0 ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( StringUtil.StrCmp(T000M6_A37PrvRuc[0], A37PrvRuc) > 0 ) ) )
            {
               A37PrvRuc = T000M6_A37PrvRuc[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PrvRuc", A37PrvRuc);
               RcdFound31 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound31 = 0;
         /* Using cursor T000M7 */
         pr_default.execute(5, new Object[] {A37PrvRuc});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( StringUtil.StrCmp(T000M7_A37PrvRuc[0], A37PrvRuc) > 0 ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( StringUtil.StrCmp(T000M7_A37PrvRuc[0], A37PrvRuc) < 0 ) ) )
            {
               A37PrvRuc = T000M7_A37PrvRuc[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PrvRuc", A37PrvRuc);
               RcdFound31 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0M31( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtPrvRuc_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0M31( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound31 == 1 )
            {
               if ( StringUtil.StrCmp(A37PrvRuc, Z37PrvRuc) != 0 )
               {
                  A37PrvRuc = Z37PrvRuc;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PrvRuc", A37PrvRuc);
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "PRVRUC");
                  AnyError = 1;
                  GX_FocusControl = edtPrvRuc_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtPrvRuc_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0M31( ) ;
                  GX_FocusControl = edtPrvRuc_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( StringUtil.StrCmp(A37PrvRuc, Z37PrvRuc) != 0 )
               {
                  /* Insert record */
                  GX_FocusControl = edtPrvRuc_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0M31( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "PRVRUC");
                     AnyError = 1;
                     GX_FocusControl = edtPrvRuc_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtPrvRuc_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0M31( ) ;
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
         if ( StringUtil.StrCmp(A37PrvRuc, Z37PrvRuc) != 0 )
         {
            A37PrvRuc = Z37PrvRuc;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PrvRuc", A37PrvRuc);
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "PRVRUC");
            AnyError = 1;
            GX_FocusControl = edtPrvRuc_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtPrvRuc_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0M31( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000M2 */
            pr_default.execute(0, new Object[] {A37PrvRuc});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Proveedor"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z184PrvDsc, T000M2_A184PrvDsc[0]) != 0 ) || ( StringUtil.StrCmp(Z185PrvEst, T000M2_A185PrvEst[0]) != 0 ) || ( StringUtil.StrCmp(Z186PrvDscCorta, T000M2_A186PrvDscCorta[0]) != 0 ) || ( StringUtil.StrCmp(Z187PrvEmail, T000M2_A187PrvEmail[0]) != 0 ) || ( StringUtil.StrCmp(Z188PrvTelf, T000M2_A188PrvTelf[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z189PrvContact, T000M2_A189PrvContact[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z184PrvDsc, T000M2_A184PrvDsc[0]) != 0 )
               {
                  GXUtil.WriteLog("proveedor:[seudo value changed for attri]"+"PrvDsc");
                  GXUtil.WriteLogRaw("Old: ",Z184PrvDsc);
                  GXUtil.WriteLogRaw("Current: ",T000M2_A184PrvDsc[0]);
               }
               if ( StringUtil.StrCmp(Z185PrvEst, T000M2_A185PrvEst[0]) != 0 )
               {
                  GXUtil.WriteLog("proveedor:[seudo value changed for attri]"+"PrvEst");
                  GXUtil.WriteLogRaw("Old: ",Z185PrvEst);
                  GXUtil.WriteLogRaw("Current: ",T000M2_A185PrvEst[0]);
               }
               if ( StringUtil.StrCmp(Z186PrvDscCorta, T000M2_A186PrvDscCorta[0]) != 0 )
               {
                  GXUtil.WriteLog("proveedor:[seudo value changed for attri]"+"PrvDscCorta");
                  GXUtil.WriteLogRaw("Old: ",Z186PrvDscCorta);
                  GXUtil.WriteLogRaw("Current: ",T000M2_A186PrvDscCorta[0]);
               }
               if ( StringUtil.StrCmp(Z187PrvEmail, T000M2_A187PrvEmail[0]) != 0 )
               {
                  GXUtil.WriteLog("proveedor:[seudo value changed for attri]"+"PrvEmail");
                  GXUtil.WriteLogRaw("Old: ",Z187PrvEmail);
                  GXUtil.WriteLogRaw("Current: ",T000M2_A187PrvEmail[0]);
               }
               if ( StringUtil.StrCmp(Z188PrvTelf, T000M2_A188PrvTelf[0]) != 0 )
               {
                  GXUtil.WriteLog("proveedor:[seudo value changed for attri]"+"PrvTelf");
                  GXUtil.WriteLogRaw("Old: ",Z188PrvTelf);
                  GXUtil.WriteLogRaw("Current: ",T000M2_A188PrvTelf[0]);
               }
               if ( StringUtil.StrCmp(Z189PrvContact, T000M2_A189PrvContact[0]) != 0 )
               {
                  GXUtil.WriteLog("proveedor:[seudo value changed for attri]"+"PrvContact");
                  GXUtil.WriteLogRaw("Old: ",Z189PrvContact);
                  GXUtil.WriteLogRaw("Current: ",T000M2_A189PrvContact[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Proveedor"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0M31( )
      {
         BeforeValidate0M31( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0M31( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0M31( 0) ;
            CheckOptimisticConcurrency0M31( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0M31( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0M31( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000M8 */
                     pr_default.execute(6, new Object[] {A37PrvRuc, n184PrvDsc, A184PrvDsc, n185PrvEst, A185PrvEst, n186PrvDscCorta, A186PrvDscCorta, n187PrvEmail, A187PrvEmail, n188PrvTelf, A188PrvTelf, n189PrvContact, A189PrvContact});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("Proveedor") ;
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
                           ResetCaption0M0( ) ;
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
               Load0M31( ) ;
            }
            EndLevel0M31( ) ;
         }
         CloseExtendedTableCursors0M31( ) ;
      }

      protected void Update0M31( )
      {
         BeforeValidate0M31( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0M31( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0M31( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0M31( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0M31( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000M9 */
                     pr_default.execute(7, new Object[] {n184PrvDsc, A184PrvDsc, n185PrvEst, A185PrvEst, n186PrvDscCorta, A186PrvDscCorta, n187PrvEmail, A187PrvEmail, n188PrvTelf, A188PrvTelf, n189PrvContact, A189PrvContact, A37PrvRuc});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("Proveedor") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Proveedor"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0M31( ) ;
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
            EndLevel0M31( ) ;
         }
         CloseExtendedTableCursors0M31( ) ;
      }

      protected void DeferredUpdate0M31( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0M31( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0M31( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0M31( ) ;
            AfterConfirm0M31( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0M31( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000M10 */
                  pr_default.execute(8, new Object[] {A37PrvRuc});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("Proveedor") ;
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
         sMode31 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0M31( ) ;
         Gx_mode = sMode31;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0M31( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV11Pgmname = "Proveedor";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Pgmname", AV11Pgmname);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000M11 */
            pr_default.execute(9, new Object[] {A37PrvRuc});
            if ( (pr_default.getStatus(9) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Orden Compra"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(9);
            /* Using cursor T000M12 */
            pr_default.execute(10, new Object[] {A37PrvRuc});
            if ( (pr_default.getStatus(10) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"det Inv Oc"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(10);
         }
      }

      protected void EndLevel0M31( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0M31( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("proveedor",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0M0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("proveedor",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0M31( )
      {
         /* Scan By routine */
         /* Using cursor T000M13 */
         pr_default.execute(11);
         RcdFound31 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound31 = 1;
            A37PrvRuc = T000M13_A37PrvRuc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PrvRuc", A37PrvRuc);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0M31( )
      {
         /* Scan next routine */
         pr_default.readNext(11);
         RcdFound31 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound31 = 1;
            A37PrvRuc = T000M13_A37PrvRuc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PrvRuc", A37PrvRuc);
         }
      }

      protected void ScanEnd0M31( )
      {
         pr_default.close(11);
      }

      protected void AfterConfirm0M31( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0M31( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0M31( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0M31( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0M31( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0M31( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0M31( )
      {
         edtPrvRuc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrvRuc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrvRuc_Enabled), 5, 0)), true);
         edtPrvDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrvDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrvDsc_Enabled), 5, 0)), true);
         edtPrvDscCorta_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrvDscCorta_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrvDscCorta_Enabled), 5, 0)), true);
         edtPrvEmail_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrvEmail_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrvEmail_Enabled), 5, 0)), true);
         edtPrvTelf_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrvTelf_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrvTelf_Enabled), 5, 0)), true);
         edtPrvContact_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrvContact_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrvContact_Enabled), 5, 0)), true);
         edtPrvEst_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrvEst_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrvEst_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0M31( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0M0( )
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
         context.SendWebValue( "Proveedor") ;
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
         context.AddJavascriptSource("gxcfg.js", "?202210262014418", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("proveedor.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV7PrvRuc))+"\">") ;
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
         forbiddenHiddens = "hsh" + "Proveedor";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("proveedor:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z37PrvRuc", StringUtil.RTrim( Z37PrvRuc));
         GxWebStd.gx_hidden_field( context, "Z184PrvDsc", Z184PrvDsc);
         GxWebStd.gx_hidden_field( context, "Z185PrvEst", StringUtil.RTrim( Z185PrvEst));
         GxWebStd.gx_hidden_field( context, "Z186PrvDscCorta", StringUtil.RTrim( Z186PrvDscCorta));
         GxWebStd.gx_hidden_field( context, "Z187PrvEmail", Z187PrvEmail);
         GxWebStd.gx_hidden_field( context, "Z188PrvTelf", StringUtil.RTrim( Z188PrvTelf));
         GxWebStd.gx_hidden_field( context, "Z189PrvContact", Z189PrvContact);
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
         GxWebStd.gx_hidden_field( context, "vPRVRUC", StringUtil.RTrim( AV7PrvRuc));
         GxWebStd.gx_hidden_field( context, "gxhash_vPRVRUC", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV7PrvRuc, "")), context));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV11Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void RenderHtmlCloseForm0M31( )
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
         return "Proveedor" ;
      }

      public override String GetPgmdesc( )
      {
         return "Proveedor" ;
      }

      protected void InitializeNonKey0M31( )
      {
         A184PrvDsc = "";
         n184PrvDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184PrvDsc", A184PrvDsc);
         n184PrvDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A184PrvDsc)) ? true : false);
         A185PrvEst = "";
         n185PrvEst = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185PrvEst", A185PrvEst);
         n185PrvEst = (String.IsNullOrEmpty(StringUtil.RTrim( A185PrvEst)) ? true : false);
         A186PrvDscCorta = "";
         n186PrvDscCorta = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A186PrvDscCorta", A186PrvDscCorta);
         n186PrvDscCorta = (String.IsNullOrEmpty(StringUtil.RTrim( A186PrvDscCorta)) ? true : false);
         A187PrvEmail = "";
         n187PrvEmail = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187PrvEmail", A187PrvEmail);
         n187PrvEmail = (String.IsNullOrEmpty(StringUtil.RTrim( A187PrvEmail)) ? true : false);
         A188PrvTelf = "";
         n188PrvTelf = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A188PrvTelf", A188PrvTelf);
         n188PrvTelf = (String.IsNullOrEmpty(StringUtil.RTrim( A188PrvTelf)) ? true : false);
         A189PrvContact = "";
         n189PrvContact = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A189PrvContact", A189PrvContact);
         n189PrvContact = (String.IsNullOrEmpty(StringUtil.RTrim( A189PrvContact)) ? true : false);
         Z184PrvDsc = "";
         Z185PrvEst = "";
         Z186PrvDscCorta = "";
         Z187PrvEmail = "";
         Z188PrvTelf = "";
         Z189PrvContact = "";
      }

      protected void InitAll0M31( )
      {
         A37PrvRuc = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PrvRuc", A37PrvRuc);
         InitializeNonKey0M31( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202210262014425", true);
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
         context.AddJavascriptSource("proveedor.js", "?202210262014425", false);
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
         edtPrvRuc_Internalname = "PRVRUC";
         edtPrvDsc_Internalname = "PRVDSC";
         edtPrvDscCorta_Internalname = "PRVDSCCORTA";
         edtPrvEmail_Internalname = "PRVEMAIL";
         edtPrvTelf_Internalname = "PRVTELF";
         edtPrvContact_Internalname = "PRVCONTACT";
         edtPrvEst_Internalname = "PRVEST";
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
         edtPrvEst_Jsonclick = "";
         edtPrvEst_Enabled = 1;
         edtPrvContact_Jsonclick = "";
         edtPrvContact_Enabled = 1;
         edtPrvTelf_Jsonclick = "";
         edtPrvTelf_Enabled = 1;
         edtPrvEmail_Jsonclick = "";
         edtPrvEmail_Enabled = 1;
         edtPrvDscCorta_Jsonclick = "";
         edtPrvDscCorta_Enabled = 1;
         edtPrvDsc_Jsonclick = "";
         edtPrvDsc_Enabled = 1;
         edtPrvRuc_Jsonclick = "";
         edtPrvRuc_Enabled = 1;
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
         /* End function init_web_controls */
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7PrvRuc',fld:'vPRVRUC',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7PrvRuc',fld:'vPRVRUC',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120M2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         wcpOAV7PrvRuc = "";
         Z37PrvRuc = "";
         Z184PrvDsc = "";
         Z185PrvEst = "";
         Z186PrvDscCorta = "";
         Z187PrvEmail = "";
         Z188PrvTelf = "";
         Z189PrvContact = "";
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
         A37PrvRuc = "";
         A184PrvDsc = "";
         A186PrvDscCorta = "";
         A187PrvEmail = "";
         gxphoneLink = "";
         A188PrvTelf = "";
         A189PrvContact = "";
         A185PrvEst = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         AV11Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode31 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         T000M4_A37PrvRuc = new String[] {""} ;
         T000M4_A184PrvDsc = new String[] {""} ;
         T000M4_n184PrvDsc = new bool[] {false} ;
         T000M4_A185PrvEst = new String[] {""} ;
         T000M4_n185PrvEst = new bool[] {false} ;
         T000M4_A186PrvDscCorta = new String[] {""} ;
         T000M4_n186PrvDscCorta = new bool[] {false} ;
         T000M4_A187PrvEmail = new String[] {""} ;
         T000M4_n187PrvEmail = new bool[] {false} ;
         T000M4_A188PrvTelf = new String[] {""} ;
         T000M4_n188PrvTelf = new bool[] {false} ;
         T000M4_A189PrvContact = new String[] {""} ;
         T000M4_n189PrvContact = new bool[] {false} ;
         T000M5_A37PrvRuc = new String[] {""} ;
         T000M3_A37PrvRuc = new String[] {""} ;
         T000M3_A184PrvDsc = new String[] {""} ;
         T000M3_n184PrvDsc = new bool[] {false} ;
         T000M3_A185PrvEst = new String[] {""} ;
         T000M3_n185PrvEst = new bool[] {false} ;
         T000M3_A186PrvDscCorta = new String[] {""} ;
         T000M3_n186PrvDscCorta = new bool[] {false} ;
         T000M3_A187PrvEmail = new String[] {""} ;
         T000M3_n187PrvEmail = new bool[] {false} ;
         T000M3_A188PrvTelf = new String[] {""} ;
         T000M3_n188PrvTelf = new bool[] {false} ;
         T000M3_A189PrvContact = new String[] {""} ;
         T000M3_n189PrvContact = new bool[] {false} ;
         T000M6_A37PrvRuc = new String[] {""} ;
         T000M7_A37PrvRuc = new String[] {""} ;
         T000M2_A37PrvRuc = new String[] {""} ;
         T000M2_A184PrvDsc = new String[] {""} ;
         T000M2_n184PrvDsc = new bool[] {false} ;
         T000M2_A185PrvEst = new String[] {""} ;
         T000M2_n185PrvEst = new bool[] {false} ;
         T000M2_A186PrvDscCorta = new String[] {""} ;
         T000M2_n186PrvDscCorta = new bool[] {false} ;
         T000M2_A187PrvEmail = new String[] {""} ;
         T000M2_n187PrvEmail = new bool[] {false} ;
         T000M2_A188PrvTelf = new String[] {""} ;
         T000M2_n188PrvTelf = new bool[] {false} ;
         T000M2_A189PrvContact = new String[] {""} ;
         T000M2_n189PrvContact = new bool[] {false} ;
         T000M11_A1EmpID = new short[1] ;
         T000M11_A2AgeID = new short[1] ;
         T000M11_A317OCompNro = new short[1] ;
         T000M11_A311OcTipoCod = new String[] {""} ;
         T000M12_A1EmpID = new short[1] ;
         T000M12_A2AgeID = new short[1] ;
         T000M12_A42BodCod = new short[1] ;
         T000M12_A264invCod = new short[1] ;
         T000M12_A282detInvOcId = new short[1] ;
         T000M13_A37PrvRuc = new String[] {""} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.proveedor__default(),
            new Object[][] {
                new Object[] {
               T000M2_A37PrvRuc, T000M2_A184PrvDsc, T000M2_n184PrvDsc, T000M2_A185PrvEst, T000M2_n185PrvEst, T000M2_A186PrvDscCorta, T000M2_n186PrvDscCorta, T000M2_A187PrvEmail, T000M2_n187PrvEmail, T000M2_A188PrvTelf,
               T000M2_n188PrvTelf, T000M2_A189PrvContact, T000M2_n189PrvContact
               }
               , new Object[] {
               T000M3_A37PrvRuc, T000M3_A184PrvDsc, T000M3_n184PrvDsc, T000M3_A185PrvEst, T000M3_n185PrvEst, T000M3_A186PrvDscCorta, T000M3_n186PrvDscCorta, T000M3_A187PrvEmail, T000M3_n187PrvEmail, T000M3_A188PrvTelf,
               T000M3_n188PrvTelf, T000M3_A189PrvContact, T000M3_n189PrvContact
               }
               , new Object[] {
               T000M4_A37PrvRuc, T000M4_A184PrvDsc, T000M4_n184PrvDsc, T000M4_A185PrvEst, T000M4_n185PrvEst, T000M4_A186PrvDscCorta, T000M4_n186PrvDscCorta, T000M4_A187PrvEmail, T000M4_n187PrvEmail, T000M4_A188PrvTelf,
               T000M4_n188PrvTelf, T000M4_A189PrvContact, T000M4_n189PrvContact
               }
               , new Object[] {
               T000M5_A37PrvRuc
               }
               , new Object[] {
               T000M6_A37PrvRuc
               }
               , new Object[] {
               T000M7_A37PrvRuc
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000M11_A1EmpID, T000M11_A2AgeID, T000M11_A317OCompNro, T000M11_A311OcTipoCod
               }
               , new Object[] {
               T000M12_A1EmpID, T000M12_A2AgeID, T000M12_A42BodCod, T000M12_A264invCod, T000M12_A282detInvOcId
               }
               , new Object[] {
               T000M13_A37PrvRuc
               }
            }
         );
         AV11Pgmname = "Proveedor";
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short RcdFound31 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtPrvRuc_Enabled ;
      private int edtPrvDsc_Enabled ;
      private int edtPrvDscCorta_Enabled ;
      private int edtPrvEmail_Enabled ;
      private int edtPrvTelf_Enabled ;
      private int edtPrvContact_Enabled ;
      private int edtPrvEst_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String wcpOAV7PrvRuc ;
      private String Z37PrvRuc ;
      private String Z185PrvEst ;
      private String Z186PrvDscCorta ;
      private String Z188PrvTelf ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String AV7PrvRuc ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtPrvRuc_Internalname ;
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
      private String A37PrvRuc ;
      private String edtPrvRuc_Jsonclick ;
      private String edtPrvDsc_Internalname ;
      private String edtPrvDsc_Jsonclick ;
      private String edtPrvDscCorta_Internalname ;
      private String A186PrvDscCorta ;
      private String edtPrvDscCorta_Jsonclick ;
      private String edtPrvEmail_Internalname ;
      private String edtPrvEmail_Jsonclick ;
      private String edtPrvTelf_Internalname ;
      private String gxphoneLink ;
      private String A188PrvTelf ;
      private String edtPrvTelf_Jsonclick ;
      private String edtPrvContact_Internalname ;
      private String edtPrvContact_Jsonclick ;
      private String edtPrvEst_Internalname ;
      private String A185PrvEst ;
      private String edtPrvEst_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String AV11Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode31 ;
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
      private bool n184PrvDsc ;
      private bool n186PrvDscCorta ;
      private bool n187PrvEmail ;
      private bool n188PrvTelf ;
      private bool n189PrvContact ;
      private bool n185PrvEst ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private String Z184PrvDsc ;
      private String Z187PrvEmail ;
      private String Z189PrvContact ;
      private String A184PrvDsc ;
      private String A187PrvEmail ;
      private String A189PrvContact ;
      private IGxSession AV10WebSession ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T000M4_A37PrvRuc ;
      private String[] T000M4_A184PrvDsc ;
      private bool[] T000M4_n184PrvDsc ;
      private String[] T000M4_A185PrvEst ;
      private bool[] T000M4_n185PrvEst ;
      private String[] T000M4_A186PrvDscCorta ;
      private bool[] T000M4_n186PrvDscCorta ;
      private String[] T000M4_A187PrvEmail ;
      private bool[] T000M4_n187PrvEmail ;
      private String[] T000M4_A188PrvTelf ;
      private bool[] T000M4_n188PrvTelf ;
      private String[] T000M4_A189PrvContact ;
      private bool[] T000M4_n189PrvContact ;
      private String[] T000M5_A37PrvRuc ;
      private String[] T000M3_A37PrvRuc ;
      private String[] T000M3_A184PrvDsc ;
      private bool[] T000M3_n184PrvDsc ;
      private String[] T000M3_A185PrvEst ;
      private bool[] T000M3_n185PrvEst ;
      private String[] T000M3_A186PrvDscCorta ;
      private bool[] T000M3_n186PrvDscCorta ;
      private String[] T000M3_A187PrvEmail ;
      private bool[] T000M3_n187PrvEmail ;
      private String[] T000M3_A188PrvTelf ;
      private bool[] T000M3_n188PrvTelf ;
      private String[] T000M3_A189PrvContact ;
      private bool[] T000M3_n189PrvContact ;
      private String[] T000M6_A37PrvRuc ;
      private String[] T000M7_A37PrvRuc ;
      private String[] T000M2_A37PrvRuc ;
      private String[] T000M2_A184PrvDsc ;
      private bool[] T000M2_n184PrvDsc ;
      private String[] T000M2_A185PrvEst ;
      private bool[] T000M2_n185PrvEst ;
      private String[] T000M2_A186PrvDscCorta ;
      private bool[] T000M2_n186PrvDscCorta ;
      private String[] T000M2_A187PrvEmail ;
      private bool[] T000M2_n187PrvEmail ;
      private String[] T000M2_A188PrvTelf ;
      private bool[] T000M2_n188PrvTelf ;
      private String[] T000M2_A189PrvContact ;
      private bool[] T000M2_n189PrvContact ;
      private short[] T000M11_A1EmpID ;
      private short[] T000M11_A2AgeID ;
      private short[] T000M11_A317OCompNro ;
      private String[] T000M11_A311OcTipoCod ;
      private short[] T000M12_A1EmpID ;
      private short[] T000M12_A2AgeID ;
      private short[] T000M12_A42BodCod ;
      private short[] T000M12_A264invCod ;
      private short[] T000M12_A282detInvOcId ;
      private String[] T000M13_A37PrvRuc ;
      private SdtTransactionContext AV9TrnContext ;
   }

   public class proveedor__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000M4 ;
          prmT000M4 = new Object[] {
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0}
          } ;
          Object[] prmT000M5 ;
          prmT000M5 = new Object[] {
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0}
          } ;
          Object[] prmT000M3 ;
          prmT000M3 = new Object[] {
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0}
          } ;
          Object[] prmT000M6 ;
          prmT000M6 = new Object[] {
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0}
          } ;
          Object[] prmT000M7 ;
          prmT000M7 = new Object[] {
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0}
          } ;
          Object[] prmT000M2 ;
          prmT000M2 = new Object[] {
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0}
          } ;
          Object[] prmT000M8 ;
          prmT000M8 = new Object[] {
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0} ,
          new Object[] {"@PrvDsc",SqlDbType.VarChar,150,0} ,
          new Object[] {"@PrvEst",SqlDbType.Char,1,0} ,
          new Object[] {"@PrvDscCorta",SqlDbType.Char,40,0} ,
          new Object[] {"@PrvEmail",SqlDbType.VarChar,100,0} ,
          new Object[] {"@PrvTelf",SqlDbType.Char,20,0} ,
          new Object[] {"@PrvContact",SqlDbType.VarChar,40,0}
          } ;
          Object[] prmT000M9 ;
          prmT000M9 = new Object[] {
          new Object[] {"@PrvDsc",SqlDbType.VarChar,150,0} ,
          new Object[] {"@PrvEst",SqlDbType.Char,1,0} ,
          new Object[] {"@PrvDscCorta",SqlDbType.Char,40,0} ,
          new Object[] {"@PrvEmail",SqlDbType.VarChar,100,0} ,
          new Object[] {"@PrvTelf",SqlDbType.Char,20,0} ,
          new Object[] {"@PrvContact",SqlDbType.VarChar,40,0} ,
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0}
          } ;
          Object[] prmT000M10 ;
          prmT000M10 = new Object[] {
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0}
          } ;
          Object[] prmT000M11 ;
          prmT000M11 = new Object[] {
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0}
          } ;
          Object[] prmT000M12 ;
          prmT000M12 = new Object[] {
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0}
          } ;
          Object[] prmT000M13 ;
          prmT000M13 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T000M2", "SELECT [PrvRuc], [PrvDsc], [PrvEst], [PrvDscCorta], [PrvEmail], [PrvTelf], [PrvContact] FROM [Proveedor] WITH (UPDLOCK) WHERE [PrvRuc] = @PrvRuc ",true, GxErrorMask.GX_NOMASK, false, this,prmT000M2,1,0,true,false )
             ,new CursorDef("T000M3", "SELECT [PrvRuc], [PrvDsc], [PrvEst], [PrvDscCorta], [PrvEmail], [PrvTelf], [PrvContact] FROM [Proveedor] WITH (NOLOCK) WHERE [PrvRuc] = @PrvRuc ",true, GxErrorMask.GX_NOMASK, false, this,prmT000M3,1,0,true,false )
             ,new CursorDef("T000M4", "SELECT TM1.[PrvRuc], TM1.[PrvDsc], TM1.[PrvEst], TM1.[PrvDscCorta], TM1.[PrvEmail], TM1.[PrvTelf], TM1.[PrvContact] FROM [Proveedor] TM1 WITH (NOLOCK) WHERE TM1.[PrvRuc] = @PrvRuc ORDER BY TM1.[PrvRuc]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000M4,100,0,true,false )
             ,new CursorDef("T000M5", "SELECT [PrvRuc] FROM [Proveedor] WITH (NOLOCK) WHERE [PrvRuc] = @PrvRuc  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000M5,1,0,true,false )
             ,new CursorDef("T000M6", "SELECT TOP 1 [PrvRuc] FROM [Proveedor] WITH (NOLOCK) WHERE ( [PrvRuc] > @PrvRuc) ORDER BY [PrvRuc]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000M6,1,0,true,true )
             ,new CursorDef("T000M7", "SELECT TOP 1 [PrvRuc] FROM [Proveedor] WITH (NOLOCK) WHERE ( [PrvRuc] < @PrvRuc) ORDER BY [PrvRuc] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000M7,1,0,true,true )
             ,new CursorDef("T000M8", "INSERT INTO [Proveedor]([PrvRuc], [PrvDsc], [PrvEst], [PrvDscCorta], [PrvEmail], [PrvTelf], [PrvContact]) VALUES(@PrvRuc, @PrvDsc, @PrvEst, @PrvDscCorta, @PrvEmail, @PrvTelf, @PrvContact)", GxErrorMask.GX_NOMASK,prmT000M8)
             ,new CursorDef("T000M9", "UPDATE [Proveedor] SET [PrvDsc]=@PrvDsc, [PrvEst]=@PrvEst, [PrvDscCorta]=@PrvDscCorta, [PrvEmail]=@PrvEmail, [PrvTelf]=@PrvTelf, [PrvContact]=@PrvContact  WHERE [PrvRuc] = @PrvRuc", GxErrorMask.GX_NOMASK,prmT000M9)
             ,new CursorDef("T000M10", "DELETE FROM [Proveedor]  WHERE [PrvRuc] = @PrvRuc", GxErrorMask.GX_NOMASK,prmT000M10)
             ,new CursorDef("T000M11", "SELECT TOP 1 [EmpID], [AgeID], [OCompNro], [OcTipoCod] FROM [OrdenCompra] WITH (NOLOCK) WHERE [PrvRuc] = @PrvRuc ",true, GxErrorMask.GX_NOMASK, false, this,prmT000M11,1,0,true,true )
             ,new CursorDef("T000M12", "SELECT TOP 1 [EmpID], [AgeID], [BodCod], [invCod], [detInvOcId] FROM [InventariodetInvOc] WITH (NOLOCK) WHERE [PrvRuc] = @PrvRuc ",true, GxErrorMask.GX_NOMASK, false, this,prmT000M12,1,0,true,true )
             ,new CursorDef("T000M13", "SELECT [PrvRuc] FROM [Proveedor] WITH (NOLOCK) ORDER BY [PrvRuc]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000M13,100,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 13) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 40) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getString(6, 20) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 13) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 40) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getString(6, 20) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 13) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 40) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getString(6, 20) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 13) ;
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 13) ;
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 13) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 3) ;
                return;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getString(1, 13) ;
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
                   stmt.setNull( 5 , SqlDbType.VarChar );
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
                   stmt.setNull( 7 , SqlDbType.VarChar );
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
                   stmt.setNull( 4 , SqlDbType.VarChar );
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
                   stmt.setNull( 6 , SqlDbType.VarChar );
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
       }
    }

 }

}
