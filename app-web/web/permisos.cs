/*
               File: PERMISOS
        Description: PERMISOS
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/11/2023 0:42:50.26
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
   public class permisos : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_4") == 0 )
         {
            A11ModCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
            A12MenCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
            A13SubCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_4( A11ModCod, A12MenCod, A13SubCod) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridpermisos_level1item") == 0 )
         {
            nRC_GXsfl_48 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_48_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_48_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridpermisos_level1item_newrow( ) ;
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
            Form.Meta.addItem("description", "PERMISOS", 0) ;
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

      public permisos( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public permisos( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "PERMISOS", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_PERMISOS.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_PERMISOS.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_PERMISOS.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_PERMISOS.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_PERMISOS.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0030.aspx"+"',["+"{Ctrl:gx.dom.el('"+"USUCOD"+"'), id:'"+"USUCOD"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_PERMISOS.htm");
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
            GxWebStd.gx_single_line_edit( context, edtUsuCod_Internalname, StringUtil.RTrim( A3UsuCod), StringUtil.RTrim( context.localUtil.Format( A3UsuCod, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuCod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuCod_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_PERMISOS.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuNom_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuNom_Internalname, "Nombre", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtUsuNom_Internalname, StringUtil.RTrim( A87UsuNom), StringUtil.RTrim( context.localUtil.Format( A87UsuNom, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuNom_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuNom_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "nombres", "left", true, "HLP_PERMISOS.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLevel1table_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitlelevel1_Internalname, "Level1", "", "", lblTitlelevel1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_PERMISOS.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Gridpermisos_level1item( ) ;
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group Confirm", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_PERMISOS.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_PERMISOS.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_PERMISOS.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm0P3( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void gxdraw_Gridpermisos_level1item( )
      {
         /*  Grid Control  */
         Gridpermisos_level1itemContainer.AddObjectProperty("GridName", "Gridpermisos_level1item");
         Gridpermisos_level1itemContainer.AddObjectProperty("Header", subGridpermisos_level1item_Header);
         Gridpermisos_level1itemContainer.AddObjectProperty("Class", "Grid");
         Gridpermisos_level1itemContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridpermisos_level1itemContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridpermisos_level1itemContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridpermisos_level1item_Backcolorstyle), 1, 0, ".", "")));
         Gridpermisos_level1itemContainer.AddObjectProperty("CmpContext", "");
         Gridpermisos_level1itemContainer.AddObjectProperty("InMasterPage", "false");
         Gridpermisos_level1itemColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridpermisos_level1itemColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A15empcod), 3, 0, ".", "")));
         Gridpermisos_level1itemColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtempcod_Enabled), 5, 0, ".", "")));
         Gridpermisos_level1itemContainer.AddColumnProperties(Gridpermisos_level1itemColumn);
         Gridpermisos_level1itemColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridpermisos_level1itemColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A16agecod), 3, 0, ".", "")));
         Gridpermisos_level1itemColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtagecod_Enabled), 5, 0, ".", "")));
         Gridpermisos_level1itemContainer.AddColumnProperties(Gridpermisos_level1itemColumn);
         Gridpermisos_level1itemColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridpermisos_level1itemColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11ModCod), 4, 0, ".", "")));
         Gridpermisos_level1itemColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtModCod_Enabled), 5, 0, ".", "")));
         Gridpermisos_level1itemContainer.AddColumnProperties(Gridpermisos_level1itemColumn);
         Gridpermisos_level1itemColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridpermisos_level1itemColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A12MenCod), 4, 0, ".", "")));
         Gridpermisos_level1itemColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMenCod_Enabled), 5, 0, ".", "")));
         Gridpermisos_level1itemContainer.AddColumnProperties(Gridpermisos_level1itemColumn);
         Gridpermisos_level1itemColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridpermisos_level1itemColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A13SubCod), 4, 0, ".", "")));
         Gridpermisos_level1itemColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSubCod_Enabled), 5, 0, ".", "")));
         Gridpermisos_level1itemContainer.AddColumnProperties(Gridpermisos_level1itemColumn);
         Gridpermisos_level1itemColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridpermisos_level1itemContainer.AddColumnProperties(Gridpermisos_level1itemColumn);
         Gridpermisos_level1itemColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridpermisos_level1itemColumn.AddObjectProperty("Value", StringUtil.RTrim( A96PermEst));
         Gridpermisos_level1itemColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPermEst_Enabled), 5, 0, ".", "")));
         Gridpermisos_level1itemContainer.AddColumnProperties(Gridpermisos_level1itemColumn);
         Gridpermisos_level1itemContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridpermisos_level1item_Selectedindex), 4, 0, ".", "")));
         Gridpermisos_level1itemContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridpermisos_level1item_Allowselection), 1, 0, ".", "")));
         Gridpermisos_level1itemContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridpermisos_level1item_Selectioncolor), 9, 0, ".", "")));
         Gridpermisos_level1itemContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridpermisos_level1item_Allowhovering), 1, 0, ".", "")));
         Gridpermisos_level1itemContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridpermisos_level1item_Hoveringcolor), 9, 0, ".", "")));
         Gridpermisos_level1itemContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridpermisos_level1item_Allowcollapsing), 1, 0, ".", "")));
         Gridpermisos_level1itemContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridpermisos_level1item_Collapsed), 1, 0, ".", "")));
         nGXsfl_48_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount44 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_44 = 1;
               ScanStart0P44( ) ;
               while ( RcdFound44 != 0 )
               {
                  init_level_properties44( ) ;
                  getByPrimaryKey0P44( ) ;
                  AddRow0P44( ) ;
                  ScanNext0P44( ) ;
               }
               ScanEnd0P44( ) ;
               nBlankRcdCount44 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal0P44( ) ;
            standaloneModal0P44( ) ;
            sMode44 = Gx_mode;
            while ( nGXsfl_48_idx < nRC_GXsfl_48 )
            {
               bGXsfl_48_Refreshing = true;
               ReadRow0P44( ) ;
               edtempcod_Enabled = (int)(context.localUtil.CToN( cgiGet( "EMPCOD_"+sGXsfl_48_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempcod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempcod_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
               edtagecod_Enabled = (int)(context.localUtil.CToN( cgiGet( "AGECOD_"+sGXsfl_48_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtagecod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtagecod_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
               edtModCod_Enabled = (int)(context.localUtil.CToN( cgiGet( "MODCOD_"+sGXsfl_48_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtModCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtModCod_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
               edtMenCod_Enabled = (int)(context.localUtil.CToN( cgiGet( "MENCOD_"+sGXsfl_48_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMenCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMenCod_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
               edtSubCod_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCOD_"+sGXsfl_48_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSubCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSubCod_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
               edtPermEst_Enabled = (int)(context.localUtil.CToN( cgiGet( "PERMEST_"+sGXsfl_48_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPermEst_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPermEst_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
               imgprompt_11_12_13_Link = cgiGet( "PROMPT_11_12_13_"+sGXsfl_48_idx+"Link");
               if ( ( nRcdExists_44 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  standaloneModal0P44( ) ;
               }
               SendRow0P44( ) ;
               bGXsfl_48_Refreshing = false;
            }
            Gx_mode = sMode44;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount44 = 5;
            nRcdExists_44 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart0P44( ) ;
               while ( RcdFound44 != 0 )
               {
                  sGXsfl_48_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_48_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_4844( ) ;
                  init_level_properties44( ) ;
                  standaloneNotModal0P44( ) ;
                  getByPrimaryKey0P44( ) ;
                  standaloneModal0P44( ) ;
                  AddRow0P44( ) ;
                  ScanNext0P44( ) ;
               }
               ScanEnd0P44( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         sMode44 = Gx_mode;
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         sGXsfl_48_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_48_idx+1), 4, 0)), 4, "0");
         SubsflControlProps_4844( ) ;
         InitAll0P44( ) ;
         init_level_properties44( ) ;
         standaloneNotModal0P44( ) ;
         standaloneModal0P44( ) ;
         nRcdExists_44 = 0;
         nIsMod_44 = 0;
         nRcdDeleted_44 = 0;
         nBlankRcdCount44 = (short)(nBlankRcdUsr44+nBlankRcdCount44);
         fRowAdded = 0;
         while ( nBlankRcdCount44 > 0 )
         {
            AddRow0P44( ) ;
            if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
            {
               fRowAdded = 1;
               GX_FocusControl = edtempcod_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nBlankRcdCount44 = (short)(nBlankRcdCount44-1);
         }
         Gx_mode = sMode44;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridpermisos_level1itemContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridpermisos_level1item", Gridpermisos_level1itemContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridpermisos_level1itemContainerData", Gridpermisos_level1itemContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridpermisos_level1itemContainerData"+"V", Gridpermisos_level1itemContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridpermisos_level1itemContainerData"+"V"+"\" value='"+Gridpermisos_level1itemContainer.GridValuesHidden()+"'/>") ;
         }
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
               A87UsuNom = StringUtil.Upper( cgiGet( edtUsuNom_Internalname));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87UsuNom", A87UsuNom);
               /* Read saved values. */
               Z3UsuCod = cgiGet( "Z3UsuCod");
               Z50UsuName = cgiGet( "Z50UsuName");
               n50UsuName = (String.IsNullOrEmpty(StringUtil.RTrim( A50UsuName)) ? true : false);
               A50UsuName = cgiGet( "Z50UsuName");
               n50UsuName = false;
               n50UsuName = (String.IsNullOrEmpty(StringUtil.RTrim( A50UsuName)) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_48 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_48"), ",", "."));
               A50UsuName = cgiGet( "USUNAME");
               n50UsuName = (String.IsNullOrEmpty(StringUtil.RTrim( A50UsuName)) ? true : false);
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "PERMISOS";
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A50UsuName, ""));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( StringUtil.StrCmp(A3UsuCod, Z3UsuCod) != 0 ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("permisos:[SecurityCheckFailed value for]"+"UsuName:"+StringUtil.RTrim( context.localUtil.Format( A50UsuName, "")));
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
               /* Check if conditions changed and reset current page numbers */
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  A3UsuCod = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons_dsp( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  standaloneModal( ) ;
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
                     if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                     {
                        context.wbHandled = 1;
                        btn_enter( ) ;
                        /* No code required for Cancel button. It is implemented as the Reset button. */
                     }
                     else if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                     {
                        context.wbHandled = 1;
                        btn_first( ) ;
                     }
                     else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                     {
                        context.wbHandled = 1;
                        btn_previous( ) ;
                     }
                     else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                     {
                        context.wbHandled = 1;
                        btn_next( ) ;
                     }
                     else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                     {
                        context.wbHandled = 1;
                        btn_last( ) ;
                     }
                     else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                     {
                        context.wbHandled = 1;
                        btn_select( ) ;
                     }
                     else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                     {
                        context.wbHandled = 1;
                        btn_delete( ) ;
                     }
                     else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                     {
                        context.wbHandled = 1;
                        AfterKeyLoadScreen( ) ;
                     }
                  }
                  else
                  {
                     sEvtType = StringUtil.Right( sEvt, 4);
                     sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
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
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0P3( ) ;
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
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            bttBtn_delete_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         }
      }

      protected void disable_std_buttons_dsp( )
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
         bttBtn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)), true);
         }
         DisableAttributes0P3( ) ;
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

      protected void CONFIRM_0P44( )
      {
         nGXsfl_48_idx = 0;
         while ( nGXsfl_48_idx < nRC_GXsfl_48 )
         {
            ReadRow0P44( ) ;
            if ( ( nRcdExists_44 != 0 ) || ( nIsMod_44 != 0 ) )
            {
               GetKey0P44( ) ;
               if ( ( nRcdExists_44 == 0 ) && ( nRcdDeleted_44 == 0 ) )
               {
                  if ( RcdFound44 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate0P44( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0P44( ) ;
                        CloseExtendedTableCursors0P44( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "EMPCOD_" + sGXsfl_48_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtempcod_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound44 != 0 )
                  {
                     if ( nRcdDeleted_44 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey0P44( ) ;
                        Load0P44( ) ;
                        BeforeValidate0P44( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0P44( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_44 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate0P44( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0P44( ) ;
                              CloseExtendedTableCursors0P44( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_44 == 0 )
                     {
                        GXCCtl = "EMPCOD_" + sGXsfl_48_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtempcod_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtempcod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A15empcod), 3, 0, ",", ""))) ;
            ChangePostValue( edtagecod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A16agecod), 3, 0, ",", ""))) ;
            ChangePostValue( edtModCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A11ModCod), 4, 0, ",", ""))) ;
            ChangePostValue( edtMenCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A12MenCod), 4, 0, ",", ""))) ;
            ChangePostValue( edtSubCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A13SubCod), 4, 0, ",", ""))) ;
            ChangePostValue( edtPermEst_Internalname, StringUtil.RTrim( A96PermEst)) ;
            ChangePostValue( "ZT_"+"Z15empcod_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z15empcod), 3, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z16agecod_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z16agecod), 3, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z11ModCod_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11ModCod), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z12MenCod_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z12MenCod), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z13SubCod_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z13SubCod), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z96PermEst_"+sGXsfl_48_idx, StringUtil.RTrim( Z96PermEst)) ;
            ChangePostValue( "nRcdDeleted_44_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_44), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_44_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_44), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_44_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_44), 4, 0, ",", ""))) ;
            if ( nIsMod_44 != 0 )
            {
               ChangePostValue( "EMPCOD_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtempcod_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "AGECOD_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtagecod_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "MODCOD_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtModCod_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "MENCOD_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMenCod_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCOD_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSubCod_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PERMEST_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPermEst_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption0P0( )
      {
      }

      protected void ZM0P3( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z50UsuName = T000P6_A50UsuName[0];
            }
            else
            {
               Z50UsuName = A50UsuName;
            }
         }
         if ( GX_JID == -2 )
         {
            Z3UsuCod = A3UsuCod;
            Z50UsuName = A50UsuName;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
         A87UsuNom = A50UsuName;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87UsuNom", A87UsuNom);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            bttBtn_delete_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         }
         else
         {
            bttBtn_delete_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         }
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
      }

      protected void Load0P3( )
      {
         /* Using cursor T000P7 */
         pr_default.execute(5, new Object[] {A3UsuCod});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound3 = 1;
            A50UsuName = T000P7_A50UsuName[0];
            n50UsuName = T000P7_n50UsuName[0];
            ZM0P3( -2) ;
         }
         pr_default.close(5);
         OnLoadActions0P3( ) ;
      }

      protected void OnLoadActions0P3( )
      {
      }

      protected void CheckExtendedTable0P3( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors0P3( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0P3( )
      {
         /* Using cursor T000P8 */
         pr_default.execute(6, new Object[] {A3UsuCod});
         if ( (pr_default.getStatus(6) != 101) )
         {
            RcdFound3 = 1;
         }
         else
         {
            RcdFound3 = 0;
         }
         pr_default.close(6);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000P6 */
         pr_default.execute(4, new Object[] {A3UsuCod});
         if ( (pr_default.getStatus(4) != 101) )
         {
            ZM0P3( 2) ;
            RcdFound3 = 1;
            A3UsuCod = T000P6_A3UsuCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
            A50UsuName = T000P6_A50UsuName[0];
            n50UsuName = T000P6_n50UsuName[0];
            Z3UsuCod = A3UsuCod;
            sMode3 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0P3( ) ;
            if ( AnyError == 1 )
            {
               RcdFound3 = 0;
               InitializeNonKey0P3( ) ;
            }
            Gx_mode = sMode3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound3 = 0;
            InitializeNonKey0P3( ) ;
            sMode3 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(4);
      }

      protected void getEqualNoModal( )
      {
         GetKey0P3( ) ;
         if ( RcdFound3 == 0 )
         {
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound3 = 0;
         /* Using cursor T000P9 */
         pr_default.execute(7, new Object[] {A3UsuCod});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T000P9_A3UsuCod[0], A3UsuCod) < 0 ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T000P9_A3UsuCod[0], A3UsuCod) > 0 ) ) )
            {
               A3UsuCod = T000P9_A3UsuCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
               RcdFound3 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void move_previous( )
      {
         RcdFound3 = 0;
         /* Using cursor T000P10 */
         pr_default.execute(8, new Object[] {A3UsuCod});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T000P10_A3UsuCod[0], A3UsuCod) > 0 ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T000P10_A3UsuCod[0], A3UsuCod) < 0 ) ) )
            {
               A3UsuCod = T000P10_A3UsuCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
               RcdFound3 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0P3( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtUsuCod_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0P3( ) ;
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
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update0P3( ) ;
                  GX_FocusControl = edtUsuCod_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( StringUtil.StrCmp(A3UsuCod, Z3UsuCod) != 0 )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtUsuCod_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0P3( ) ;
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
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtUsuCod_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0P3( ) ;
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
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            getByPrimaryKey( ) ;
         }
         CloseOpenCursors();
      }

      protected void btn_get( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         getEqualNoModal( ) ;
         if ( RcdFound3 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "USUCOD");
            AnyError = 1;
            GX_FocusControl = edtUsuCod_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart0P3( ) ;
         if ( RcdFound3 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         ScanEnd0P3( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         move_previous( ) ;
         if ( RcdFound3 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         move_next( ) ;
         if ( RcdFound3 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart0P3( ) ;
         if ( RcdFound3 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound3 != 0 )
            {
               ScanNext0P3( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         ScanEnd0P3( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0P3( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000P5 */
            pr_default.execute(3, new Object[] {A3UsuCod});
            if ( (pr_default.getStatus(3) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Usuarios"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(3) == 101) || ( StringUtil.StrCmp(Z50UsuName, T000P5_A50UsuName[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z50UsuName, T000P5_A50UsuName[0]) != 0 )
               {
                  GXUtil.WriteLog("permisos:[seudo value changed for attri]"+"UsuName");
                  GXUtil.WriteLogRaw("Old: ",Z50UsuName);
                  GXUtil.WriteLogRaw("Current: ",T000P5_A50UsuName[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Usuarios"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0P3( )
      {
         BeforeValidate0P3( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0P3( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0P3( 0) ;
            CheckOptimisticConcurrency0P3( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0P3( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0P3( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000P11 */
                     pr_default.execute(9, new Object[] {A3UsuCod, n50UsuName, A50UsuName});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("Usuarios") ;
                     if ( (pr_default.getStatus(9) == 1) )
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
                           ProcessLevel0P3( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption0P0( ) ;
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
            else
            {
               Load0P3( ) ;
            }
            EndLevel0P3( ) ;
         }
         CloseExtendedTableCursors0P3( ) ;
      }

      protected void Update0P3( )
      {
         BeforeValidate0P3( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0P3( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0P3( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0P3( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0P3( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000P12 */
                     pr_default.execute(10, new Object[] {n50UsuName, A50UsuName, A3UsuCod});
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("Usuarios") ;
                     if ( (pr_default.getStatus(10) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Usuarios"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0P3( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0P3( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                              ResetCaption0P0( ) ;
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
            EndLevel0P3( ) ;
         }
         CloseExtendedTableCursors0P3( ) ;
      }

      protected void DeferredUpdate0P3( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0P3( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0P3( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0P3( ) ;
            AfterConfirm0P3( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0P3( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart0P44( ) ;
                  while ( RcdFound44 != 0 )
                  {
                     getByPrimaryKey0P44( ) ;
                     Delete0P44( ) ;
                     ScanNext0P44( ) ;
                  }
                  ScanEnd0P44( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000P13 */
                     pr_default.execute(11, new Object[] {A3UsuCod});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("Usuarios") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           move_next( ) ;
                           if ( RcdFound3 == 0 )
                           {
                              InitAll0P3( ) ;
                              Gx_mode = "INS";
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           }
                           else
                           {
                              getByPrimaryKey( ) ;
                              Gx_mode = "UPD";
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           }
                           GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted", ""), "SuccessfullyDeleted", 0, "", true);
                           ResetCaption0P0( ) ;
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
         }
         sMode3 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0P3( ) ;
         Gx_mode = sMode3;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0P3( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000P14 */
            pr_default.execute(12, new Object[] {A3UsuCod});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Periodos"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(12);
            /* Using cursor T000P15 */
            pr_default.execute(13, new Object[] {A3UsuCod});
            if ( (pr_default.getStatus(13) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Prod Precio"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(13);
            /* Using cursor T000P16 */
            pr_default.execute(14, new Object[] {A3UsuCod});
            if ( (pr_default.getStatus(14) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Emails"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(14);
         }
      }

      protected void ProcessNestedLevel0P44( )
      {
         nGXsfl_48_idx = 0;
         while ( nGXsfl_48_idx < nRC_GXsfl_48 )
         {
            ReadRow0P44( ) ;
            if ( ( nRcdExists_44 != 0 ) || ( nIsMod_44 != 0 ) )
            {
               standaloneNotModal0P44( ) ;
               GetKey0P44( ) ;
               if ( ( nRcdExists_44 == 0 ) && ( nRcdDeleted_44 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  Insert0P44( ) ;
               }
               else
               {
                  if ( RcdFound44 != 0 )
                  {
                     if ( ( nRcdDeleted_44 != 0 ) && ( nRcdExists_44 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        Delete0P44( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_44 != 0 ) && ( nRcdExists_44 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           Update0P44( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_44 == 0 )
                     {
                        GXCCtl = "EMPCOD_" + sGXsfl_48_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtempcod_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtempcod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A15empcod), 3, 0, ",", ""))) ;
            ChangePostValue( edtagecod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A16agecod), 3, 0, ",", ""))) ;
            ChangePostValue( edtModCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A11ModCod), 4, 0, ",", ""))) ;
            ChangePostValue( edtMenCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A12MenCod), 4, 0, ",", ""))) ;
            ChangePostValue( edtSubCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A13SubCod), 4, 0, ",", ""))) ;
            ChangePostValue( edtPermEst_Internalname, StringUtil.RTrim( A96PermEst)) ;
            ChangePostValue( "ZT_"+"Z15empcod_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z15empcod), 3, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z16agecod_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z16agecod), 3, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z11ModCod_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11ModCod), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z12MenCod_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z12MenCod), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z13SubCod_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z13SubCod), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z96PermEst_"+sGXsfl_48_idx, StringUtil.RTrim( Z96PermEst)) ;
            ChangePostValue( "nRcdDeleted_44_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_44), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_44_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_44), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_44_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_44), 4, 0, ",", ""))) ;
            if ( nIsMod_44 != 0 )
            {
               ChangePostValue( "EMPCOD_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtempcod_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "AGECOD_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtagecod_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "MODCOD_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtModCod_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "MENCOD_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMenCod_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCOD_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSubCod_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PERMEST_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPermEst_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0P44( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_44 = 0;
         nIsMod_44 = 0;
         nRcdDeleted_44 = 0;
      }

      protected void ProcessLevel0P3( )
      {
         /* Save parent mode. */
         sMode3 = Gx_mode;
         ProcessNestedLevel0P44( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode3;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel0P3( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(3);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0P3( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(4);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(2);
            context.CommitDataStores("permisos",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0P0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(4);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(2);
            context.RollbackDataStores("permisos",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0P3( )
      {
         /* Using cursor T000P17 */
         pr_default.execute(15);
         RcdFound3 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound3 = 1;
            A3UsuCod = T000P17_A3UsuCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0P3( )
      {
         /* Scan next routine */
         pr_default.readNext(15);
         RcdFound3 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound3 = 1;
            A3UsuCod = T000P17_A3UsuCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
         }
      }

      protected void ScanEnd0P3( )
      {
         pr_default.close(15);
      }

      protected void AfterConfirm0P3( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0P3( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0P3( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0P3( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0P3( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0P3( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0P3( )
      {
         edtUsuCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuCod_Enabled), 5, 0)), true);
         edtUsuNom_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuNom_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuNom_Enabled), 5, 0)), true);
      }

      protected void ZM0P44( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z96PermEst = T000P3_A96PermEst[0];
            }
            else
            {
               Z96PermEst = A96PermEst;
            }
         }
         if ( GX_JID == -3 )
         {
            Z3UsuCod = A3UsuCod;
            Z15empcod = A15empcod;
            Z16agecod = A16agecod;
            Z96PermEst = A96PermEst;
            Z11ModCod = A11ModCod;
            Z12MenCod = A12MenCod;
            Z13SubCod = A13SubCod;
         }
      }

      protected void standaloneNotModal0P44( )
      {
      }

      protected void standaloneModal0P44( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtempcod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempcod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempcod_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
         }
         else
         {
            edtempcod_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempcod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempcod_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtagecod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtagecod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtagecod_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
         }
         else
         {
            edtagecod_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtagecod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtagecod_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtModCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtModCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtModCod_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
         }
         else
         {
            edtModCod_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtModCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtModCod_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtMenCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMenCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMenCod_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
         }
         else
         {
            edtMenCod_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMenCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMenCod_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtSubCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSubCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSubCod_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
         }
         else
         {
            edtSubCod_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSubCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSubCod_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
         }
      }

      protected void Load0P44( )
      {
         /* Using cursor T000P18 */
         pr_default.execute(16, new Object[] {A3UsuCod, A15empcod, A16agecod, A11ModCod, A12MenCod, A13SubCod});
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound44 = 1;
            A96PermEst = T000P18_A96PermEst[0];
            n96PermEst = T000P18_n96PermEst[0];
            ZM0P44( -3) ;
         }
         pr_default.close(16);
         OnLoadActions0P44( ) ;
      }

      protected void OnLoadActions0P44( )
      {
      }

      protected void CheckExtendedTable0P44( )
      {
         Gx_BScreen = 1;
         standaloneModal0P44( ) ;
         /* Using cursor T000P4 */
         pr_default.execute(2, new Object[] {A11ModCod, A12MenCod, A13SubCod});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GXCCtl = "MODCOD_" + sGXsfl_48_idx;
            GX_msglist.addItem("No existe '1'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtModCod_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors0P44( )
      {
         pr_default.close(2);
      }

      protected void enableDisable0P44( )
      {
      }

      protected void gxLoad_4( short A11ModCod ,
                               short A12MenCod ,
                               short A13SubCod )
      {
         /* Using cursor T000P19 */
         pr_default.execute(17, new Object[] {A11ModCod, A12MenCod, A13SubCod});
         if ( (pr_default.getStatus(17) == 101) )
         {
            GXCCtl = "MODCOD_" + sGXsfl_48_idx;
            GX_msglist.addItem("No existe '1'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtModCod_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(17) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(17);
      }

      protected void GetKey0P44( )
      {
         /* Using cursor T000P20 */
         pr_default.execute(18, new Object[] {A3UsuCod, A15empcod, A16agecod, A11ModCod, A12MenCod, A13SubCod});
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound44 = 1;
         }
         else
         {
            RcdFound44 = 0;
         }
         pr_default.close(18);
      }

      protected void getByPrimaryKey0P44( )
      {
         /* Using cursor T000P3 */
         pr_default.execute(1, new Object[] {A3UsuCod, A15empcod, A16agecod, A11ModCod, A12MenCod, A13SubCod});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0P44( 3) ;
            RcdFound44 = 1;
            InitializeNonKey0P44( ) ;
            A15empcod = T000P3_A15empcod[0];
            A16agecod = T000P3_A16agecod[0];
            A96PermEst = T000P3_A96PermEst[0];
            n96PermEst = T000P3_n96PermEst[0];
            A11ModCod = T000P3_A11ModCod[0];
            A12MenCod = T000P3_A12MenCod[0];
            A13SubCod = T000P3_A13SubCod[0];
            Z3UsuCod = A3UsuCod;
            Z15empcod = A15empcod;
            Z16agecod = A16agecod;
            Z11ModCod = A11ModCod;
            Z12MenCod = A12MenCod;
            Z13SubCod = A13SubCod;
            sMode44 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal0P44( ) ;
            Load0P44( ) ;
            Gx_mode = sMode44;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound44 = 0;
            InitializeNonKey0P44( ) ;
            sMode44 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal0P44( ) ;
            Gx_mode = sMode44;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes0P44( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0P44( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000P2 */
            pr_default.execute(0, new Object[] {A3UsuCod, A15empcod, A16agecod, A11ModCod, A12MenCod, A13SubCod});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"PERMISOS"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z96PermEst, T000P2_A96PermEst[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z96PermEst, T000P2_A96PermEst[0]) != 0 )
               {
                  GXUtil.WriteLog("permisos:[seudo value changed for attri]"+"PermEst");
                  GXUtil.WriteLogRaw("Old: ",Z96PermEst);
                  GXUtil.WriteLogRaw("Current: ",T000P2_A96PermEst[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"PERMISOS"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0P44( )
      {
         BeforeValidate0P44( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0P44( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0P44( 0) ;
            CheckOptimisticConcurrency0P44( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0P44( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0P44( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000P21 */
                     pr_default.execute(19, new Object[] {A3UsuCod, A15empcod, A16agecod, n96PermEst, A96PermEst, A11ModCod, A12MenCod, A13SubCod});
                     pr_default.close(19);
                     dsDefault.SmartCacheProvider.SetUpdated("PERMISOS") ;
                     if ( (pr_default.getStatus(19) == 1) )
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
               Load0P44( ) ;
            }
            EndLevel0P44( ) ;
         }
         CloseExtendedTableCursors0P44( ) ;
      }

      protected void Update0P44( )
      {
         BeforeValidate0P44( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0P44( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0P44( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0P44( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0P44( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000P22 */
                     pr_default.execute(20, new Object[] {n96PermEst, A96PermEst, A3UsuCod, A15empcod, A16agecod, A11ModCod, A12MenCod, A13SubCod});
                     pr_default.close(20);
                     dsDefault.SmartCacheProvider.SetUpdated("PERMISOS") ;
                     if ( (pr_default.getStatus(20) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"PERMISOS"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0P44( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey0P44( ) ;
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
            EndLevel0P44( ) ;
         }
         CloseExtendedTableCursors0P44( ) ;
      }

      protected void DeferredUpdate0P44( )
      {
      }

      protected void Delete0P44( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0P44( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0P44( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0P44( ) ;
            AfterConfirm0P44( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0P44( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000P23 */
                  pr_default.execute(21, new Object[] {A3UsuCod, A15empcod, A16agecod, A11ModCod, A12MenCod, A13SubCod});
                  pr_default.close(21);
                  dsDefault.SmartCacheProvider.SetUpdated("PERMISOS") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode44 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0P44( ) ;
         Gx_mode = sMode44;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0P44( )
      {
         standaloneModal0P44( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0P44( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0P44( )
      {
         /* Scan By routine */
         /* Using cursor T000P24 */
         pr_default.execute(22, new Object[] {A3UsuCod});
         RcdFound44 = 0;
         if ( (pr_default.getStatus(22) != 101) )
         {
            RcdFound44 = 1;
            A15empcod = T000P24_A15empcod[0];
            A16agecod = T000P24_A16agecod[0];
            A11ModCod = T000P24_A11ModCod[0];
            A12MenCod = T000P24_A12MenCod[0];
            A13SubCod = T000P24_A13SubCod[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0P44( )
      {
         /* Scan next routine */
         pr_default.readNext(22);
         RcdFound44 = 0;
         if ( (pr_default.getStatus(22) != 101) )
         {
            RcdFound44 = 1;
            A15empcod = T000P24_A15empcod[0];
            A16agecod = T000P24_A16agecod[0];
            A11ModCod = T000P24_A11ModCod[0];
            A12MenCod = T000P24_A12MenCod[0];
            A13SubCod = T000P24_A13SubCod[0];
         }
      }

      protected void ScanEnd0P44( )
      {
         pr_default.close(22);
      }

      protected void AfterConfirm0P44( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0P44( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0P44( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0P44( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0P44( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0P44( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0P44( )
      {
         edtempcod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempcod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempcod_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
         edtagecod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtagecod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtagecod_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
         edtModCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtModCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtModCod_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
         edtMenCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMenCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMenCod_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
         edtSubCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSubCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSubCod_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
         edtPermEst_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPermEst_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPermEst_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
      }

      protected void send_integrity_lvl_hashes0P44( )
      {
      }

      protected void send_integrity_lvl_hashes0P3( )
      {
      }

      protected void SubsflControlProps_4844( )
      {
         edtempcod_Internalname = "EMPCOD_"+sGXsfl_48_idx;
         edtagecod_Internalname = "AGECOD_"+sGXsfl_48_idx;
         edtModCod_Internalname = "MODCOD_"+sGXsfl_48_idx;
         edtMenCod_Internalname = "MENCOD_"+sGXsfl_48_idx;
         edtSubCod_Internalname = "SUBCOD_"+sGXsfl_48_idx;
         imgprompt_11_12_13_Internalname = "PROMPT_11_12_13_"+sGXsfl_48_idx;
         edtPermEst_Internalname = "PERMEST_"+sGXsfl_48_idx;
      }

      protected void SubsflControlProps_fel_4844( )
      {
         edtempcod_Internalname = "EMPCOD_"+sGXsfl_48_fel_idx;
         edtagecod_Internalname = "AGECOD_"+sGXsfl_48_fel_idx;
         edtModCod_Internalname = "MODCOD_"+sGXsfl_48_fel_idx;
         edtMenCod_Internalname = "MENCOD_"+sGXsfl_48_fel_idx;
         edtSubCod_Internalname = "SUBCOD_"+sGXsfl_48_fel_idx;
         imgprompt_11_12_13_Internalname = "PROMPT_11_12_13_"+sGXsfl_48_fel_idx;
         edtPermEst_Internalname = "PERMEST_"+sGXsfl_48_fel_idx;
      }

      protected void AddRow0P44( )
      {
         nGXsfl_48_idx = (short)(nGXsfl_48_idx+1);
         sGXsfl_48_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_48_idx), 4, 0)), 4, "0");
         SubsflControlProps_4844( ) ;
         SendRow0P44( ) ;
      }

      protected void SendRow0P44( )
      {
         Gridpermisos_level1itemRow = GXWebRow.GetNew(context);
         if ( subGridpermisos_level1item_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridpermisos_level1item_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridpermisos_level1item_Class, "") != 0 )
            {
               subGridpermisos_level1item_Linesclass = subGridpermisos_level1item_Class+"Odd";
            }
         }
         else if ( subGridpermisos_level1item_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridpermisos_level1item_Backstyle = 0;
            subGridpermisos_level1item_Backcolor = subGridpermisos_level1item_Allbackcolor;
            if ( StringUtil.StrCmp(subGridpermisos_level1item_Class, "") != 0 )
            {
               subGridpermisos_level1item_Linesclass = subGridpermisos_level1item_Class+"Uniform";
            }
         }
         else if ( subGridpermisos_level1item_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridpermisos_level1item_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridpermisos_level1item_Class, "") != 0 )
            {
               subGridpermisos_level1item_Linesclass = subGridpermisos_level1item_Class+"Odd";
            }
            subGridpermisos_level1item_Backcolor = (int)(0x0);
         }
         else if ( subGridpermisos_level1item_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridpermisos_level1item_Backstyle = 1;
            if ( ((int)(((nGXsfl_48_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGridpermisos_level1item_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridpermisos_level1item_Class, "") != 0 )
               {
                  subGridpermisos_level1item_Linesclass = subGridpermisos_level1item_Class+"Odd";
               }
            }
            else
            {
               subGridpermisos_level1item_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridpermisos_level1item_Class, "") != 0 )
               {
                  subGridpermisos_level1item_Linesclass = subGridpermisos_level1item_Class+"Even";
               }
            }
         }
         imgprompt_11_12_13_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0)||(StringUtil.StrCmp(Gx_mode, "UPD")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00c0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"MODCOD_"+sGXsfl_48_idx+"'), id:'"+"MODCOD_"+sGXsfl_48_idx+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"MENCOD_"+sGXsfl_48_idx+"'), id:'"+"MENCOD_"+sGXsfl_48_idx+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"SUBCOD_"+sGXsfl_48_idx+"'), id:'"+"SUBCOD_"+sGXsfl_48_idx+"'"+",IOType:'out'}"+"],"+"gx.dom.form()."+"nIsMod_44_"+sGXsfl_48_idx+","+"'', false"+","+"false"+");");
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_44_" + sGXsfl_48_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 49,'',false,'" + sGXsfl_48_idx + "',48)\"";
         ROClassString = "Attribute";
         Gridpermisos_level1itemRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempcod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A15empcod), 3, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A15empcod), "ZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtempcod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtempcod_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)3,(short)0,(short)0,(short)48,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_44_" + sGXsfl_48_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 50,'',false,'" + sGXsfl_48_idx + "',48)\"";
         ROClassString = "Attribute";
         Gridpermisos_level1itemRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtagecod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A16agecod), 3, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A16agecod), "ZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtagecod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtagecod_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)3,(short)0,(short)0,(short)48,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_44_" + sGXsfl_48_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 51,'',false,'" + sGXsfl_48_idx + "',48)\"";
         ROClassString = "Attribute";
         Gridpermisos_level1itemRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtModCod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A11ModCod), 4, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A11ModCod), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtModCod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtModCod_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)48,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_44_" + sGXsfl_48_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 52,'',false,'" + sGXsfl_48_idx + "',48)\"";
         ROClassString = "Attribute";
         Gridpermisos_level1itemRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMenCod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A12MenCod), 4, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A12MenCod), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtMenCod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtMenCod_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)48,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_44_" + sGXsfl_48_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 53,'',false,'" + sGXsfl_48_idx + "',48)\"";
         ROClassString = "Attribute";
         Gridpermisos_level1itemRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSubCod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A13SubCod), 4, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A13SubCod), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSubCod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtSubCod_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)48,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         Gridpermisos_level1itemRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_11_12_13_Internalname,(String)sImgUrl,(String)imgprompt_11_12_13_Link,(String)"",(String)"",context.GetTheme( ),(int)imgprompt_11_12_13_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_44_" + sGXsfl_48_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_48_idx + "',48)\"";
         ROClassString = "Attribute";
         Gridpermisos_level1itemRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPermEst_Internalname,StringUtil.RTrim( A96PermEst),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPermEst_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtPermEst_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)1,(short)0,(short)0,(short)48,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         context.httpAjaxContext.ajax_sending_grid_row(Gridpermisos_level1itemRow);
         send_integrity_lvl_hashes0P44( ) ;
         GXCCtl = "Z15empcod_" + sGXsfl_48_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z15empcod), 3, 0, ",", "")));
         GXCCtl = "Z16agecod_" + sGXsfl_48_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z16agecod), 3, 0, ",", "")));
         GXCCtl = "Z11ModCod_" + sGXsfl_48_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11ModCod), 4, 0, ",", "")));
         GXCCtl = "Z12MenCod_" + sGXsfl_48_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z12MenCod), 4, 0, ",", "")));
         GXCCtl = "Z13SubCod_" + sGXsfl_48_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z13SubCod), 4, 0, ",", "")));
         GXCCtl = "Z96PermEst_" + sGXsfl_48_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z96PermEst));
         GXCCtl = "nRcdDeleted_44_" + sGXsfl_48_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_44), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_44_" + sGXsfl_48_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_44), 4, 0, ",", "")));
         GXCCtl = "nIsMod_44_" + sGXsfl_48_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_44), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "EMPCOD_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtempcod_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "AGECOD_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtagecod_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "MODCOD_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtModCod_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "MENCOD_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMenCod_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SUBCOD_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSubCod_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PERMEST_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPermEst_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_11_12_13_"+sGXsfl_48_idx+"Link", StringUtil.RTrim( imgprompt_11_12_13_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridpermisos_level1itemContainer.AddRow(Gridpermisos_level1itemRow);
      }

      protected void ReadRow0P44( )
      {
         nGXsfl_48_idx = (short)(nGXsfl_48_idx+1);
         sGXsfl_48_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_48_idx), 4, 0)), 4, "0");
         SubsflControlProps_4844( ) ;
         edtempcod_Enabled = (int)(context.localUtil.CToN( cgiGet( "EMPCOD_"+sGXsfl_48_idx+"Enabled"), ",", "."));
         edtagecod_Enabled = (int)(context.localUtil.CToN( cgiGet( "AGECOD_"+sGXsfl_48_idx+"Enabled"), ",", "."));
         edtModCod_Enabled = (int)(context.localUtil.CToN( cgiGet( "MODCOD_"+sGXsfl_48_idx+"Enabled"), ",", "."));
         edtMenCod_Enabled = (int)(context.localUtil.CToN( cgiGet( "MENCOD_"+sGXsfl_48_idx+"Enabled"), ",", "."));
         edtSubCod_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCOD_"+sGXsfl_48_idx+"Enabled"), ",", "."));
         edtPermEst_Enabled = (int)(context.localUtil.CToN( cgiGet( "PERMEST_"+sGXsfl_48_idx+"Enabled"), ",", "."));
         imgprompt_11_12_13_Link = cgiGet( "PROMPT_11_12_13_"+sGXsfl_48_idx+"Link");
         if ( ( ( context.localUtil.CToN( cgiGet( edtempcod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtempcod_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
         {
            GXCCtl = "EMPCOD_" + sGXsfl_48_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtempcod_Internalname;
            wbErr = true;
            A15empcod = 0;
         }
         else
         {
            A15empcod = (short)(context.localUtil.CToN( cgiGet( edtempcod_Internalname), ",", "."));
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtagecod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtagecod_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
         {
            GXCCtl = "AGECOD_" + sGXsfl_48_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtagecod_Internalname;
            wbErr = true;
            A16agecod = 0;
         }
         else
         {
            A16agecod = (short)(context.localUtil.CToN( cgiGet( edtagecod_Internalname), ",", "."));
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtModCod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtModCod_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "MODCOD_" + sGXsfl_48_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtModCod_Internalname;
            wbErr = true;
            A11ModCod = 0;
         }
         else
         {
            A11ModCod = (short)(context.localUtil.CToN( cgiGet( edtModCod_Internalname), ",", "."));
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtMenCod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtMenCod_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "MENCOD_" + sGXsfl_48_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtMenCod_Internalname;
            wbErr = true;
            A12MenCod = 0;
         }
         else
         {
            A12MenCod = (short)(context.localUtil.CToN( cgiGet( edtMenCod_Internalname), ",", "."));
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtSubCod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSubCod_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "SUBCOD_" + sGXsfl_48_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtSubCod_Internalname;
            wbErr = true;
            A13SubCod = 0;
         }
         else
         {
            A13SubCod = (short)(context.localUtil.CToN( cgiGet( edtSubCod_Internalname), ",", "."));
         }
         A96PermEst = cgiGet( edtPermEst_Internalname);
         n96PermEst = false;
         n96PermEst = (String.IsNullOrEmpty(StringUtil.RTrim( A96PermEst)) ? true : false);
         GXCCtl = "Z15empcod_" + sGXsfl_48_idx;
         Z15empcod = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z16agecod_" + sGXsfl_48_idx;
         Z16agecod = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z11ModCod_" + sGXsfl_48_idx;
         Z11ModCod = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z12MenCod_" + sGXsfl_48_idx;
         Z12MenCod = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z13SubCod_" + sGXsfl_48_idx;
         Z13SubCod = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z96PermEst_" + sGXsfl_48_idx;
         Z96PermEst = cgiGet( GXCCtl);
         n96PermEst = (String.IsNullOrEmpty(StringUtil.RTrim( A96PermEst)) ? true : false);
         GXCCtl = "nRcdDeleted_44_" + sGXsfl_48_idx;
         nRcdDeleted_44 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_44_" + sGXsfl_48_idx;
         nRcdExists_44 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_44_" + sGXsfl_48_idx;
         nIsMod_44 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void assign_properties_default( )
      {
         defedtSubCod_Enabled = edtSubCod_Enabled;
         defedtMenCod_Enabled = edtMenCod_Enabled;
         defedtModCod_Enabled = edtModCod_Enabled;
         defedtagecod_Enabled = edtagecod_Enabled;
         defedtempcod_Enabled = edtempcod_Enabled;
      }

      protected void ConfirmValues0P0( )
      {
         nGXsfl_48_idx = 0;
         sGXsfl_48_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_48_idx), 4, 0)), 4, "0");
         SubsflControlProps_4844( ) ;
         while ( nGXsfl_48_idx < nRC_GXsfl_48 )
         {
            nGXsfl_48_idx = (short)(nGXsfl_48_idx+1);
            sGXsfl_48_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_48_idx), 4, 0)), 4, "0");
            SubsflControlProps_4844( ) ;
            ChangePostValue( "Z15empcod_"+sGXsfl_48_idx, cgiGet( "ZT_"+"Z15empcod_"+sGXsfl_48_idx)) ;
            DeletePostValue( "ZT_"+"Z15empcod_"+sGXsfl_48_idx) ;
            ChangePostValue( "Z16agecod_"+sGXsfl_48_idx, cgiGet( "ZT_"+"Z16agecod_"+sGXsfl_48_idx)) ;
            DeletePostValue( "ZT_"+"Z16agecod_"+sGXsfl_48_idx) ;
            ChangePostValue( "Z11ModCod_"+sGXsfl_48_idx, cgiGet( "ZT_"+"Z11ModCod_"+sGXsfl_48_idx)) ;
            DeletePostValue( "ZT_"+"Z11ModCod_"+sGXsfl_48_idx) ;
            ChangePostValue( "Z12MenCod_"+sGXsfl_48_idx, cgiGet( "ZT_"+"Z12MenCod_"+sGXsfl_48_idx)) ;
            DeletePostValue( "ZT_"+"Z12MenCod_"+sGXsfl_48_idx) ;
            ChangePostValue( "Z13SubCod_"+sGXsfl_48_idx, cgiGet( "ZT_"+"Z13SubCod_"+sGXsfl_48_idx)) ;
            DeletePostValue( "ZT_"+"Z13SubCod_"+sGXsfl_48_idx) ;
            ChangePostValue( "Z96PermEst_"+sGXsfl_48_idx, cgiGet( "ZT_"+"Z96PermEst_"+sGXsfl_48_idx)) ;
            DeletePostValue( "ZT_"+"Z96PermEst_"+sGXsfl_48_idx) ;
         }
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
         context.SendWebValue( "PERMISOS") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20231110425313", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("permisos.aspx") +"\">") ;
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
         forbiddenHiddens = "hsh" + "PERMISOS";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A50UsuName, ""));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("permisos:[SendSecurityCheck value for]"+"UsuName:"+StringUtil.RTrim( context.localUtil.Format( A50UsuName, "")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z3UsuCod", StringUtil.RTrim( Z3UsuCod));
         GxWebStd.gx_hidden_field( context, "Z50UsuName", Z50UsuName);
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_48", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_48_idx), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "USUNAME", A50UsuName);
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
      }

      protected void RenderHtmlCloseForm0P3( )
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
         return "PERMISOS" ;
      }

      public override String GetPgmdesc( )
      {
         return "PERMISOS" ;
      }

      protected void InitializeNonKey0P3( )
      {
         A87UsuNom = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87UsuNom", A87UsuNom);
         A50UsuName = "";
         n50UsuName = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50UsuName", A50UsuName);
         Z50UsuName = "";
      }

      protected void InitAll0P3( )
      {
         A3UsuCod = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
         InitializeNonKey0P3( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey0P44( )
      {
         A96PermEst = "";
         n96PermEst = false;
         Z96PermEst = "";
      }

      protected void InitAll0P44( )
      {
         A15empcod = 0;
         A16agecod = 0;
         A11ModCod = 0;
         A12MenCod = 0;
         A13SubCod = 0;
         InitializeNonKey0P44( ) ;
      }

      protected void StandaloneModalInsert0P44( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20231110425317", true);
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
         context.AddJavascriptSource("permisos.js", "?20231110425319", false);
         /* End function include_jscripts */
      }

      protected void init_level_properties44( )
      {
         edtSubCod_Enabled = defedtSubCod_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSubCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSubCod_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
         edtMenCod_Enabled = defedtMenCod_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMenCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMenCod_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
         edtModCod_Enabled = defedtModCod_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtModCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtModCod_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
         edtagecod_Enabled = defedtagecod_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtagecod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtagecod_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
         edtempcod_Enabled = defedtempcod_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempcod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempcod_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
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
         edtUsuNom_Internalname = "USUNOM";
         lblTitlelevel1_Internalname = "TITLELEVEL1";
         edtempcod_Internalname = "EMPCOD";
         edtagecod_Internalname = "AGECOD";
         edtModCod_Internalname = "MODCOD";
         edtMenCod_Internalname = "MENCOD";
         edtSubCod_Internalname = "SUBCOD";
         edtPermEst_Internalname = "PERMEST";
         divLevel1table_Internalname = "LEVEL1TABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_11_12_13_Internalname = "PROMPT_11_12_13";
         subGridpermisos_level1item_Internalname = "GRIDPERMISOS_LEVEL1ITEM";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtPermEst_Jsonclick = "";
         imgprompt_11_12_13_Visible = 1;
         imgprompt_11_12_13_Link = "";
         imgprompt_11_12_13_Visible = 1;
         edtSubCod_Jsonclick = "";
         edtMenCod_Jsonclick = "";
         edtModCod_Jsonclick = "";
         edtagecod_Jsonclick = "";
         edtempcod_Jsonclick = "";
         subGridpermisos_level1item_Class = "Grid";
         subGridpermisos_level1item_Backcolorstyle = 0;
         subGridpermisos_level1item_Allowcollapsing = 0;
         subGridpermisos_level1item_Allowselection = 0;
         edtPermEst_Enabled = 1;
         edtSubCod_Enabled = 1;
         edtMenCod_Enabled = 1;
         edtModCod_Enabled = 1;
         edtagecod_Enabled = 1;
         edtempcod_Enabled = 1;
         subGridpermisos_level1item_Header = "";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtUsuNom_Jsonclick = "";
         edtUsuNom_Enabled = 0;
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

      protected void gxnrGridpermisos_level1item_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         SubsflControlProps_4844( ) ;
         while ( nGXsfl_48_idx <= nRC_GXsfl_48 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0P44( ) ;
            standaloneModal0P44( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow0P44( ) ;
            nGXsfl_48_idx = (short)(nGXsfl_48_idx+1);
            sGXsfl_48_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_48_idx), 4, 0)), 4, "0");
            SubsflControlProps_4844( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Gridpermisos_level1itemContainer));
         /* End function gxnrGridpermisos_level1item_newrow */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         getEqualNoModal( ) ;
         if ( AnyError == 0 )
         {
            GX_FocusControl = "";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Usucod( String GX_Parm1 ,
                                String GX_Parm2 ,
                                String GX_Parm3 )
      {
         Gx_mode = GX_Parm1;
         A3UsuCod = GX_Parm2;
         A50UsuName = GX_Parm3;
         n50UsuName = false;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(StringUtil.RTrim( A87UsuNom));
         isValidOutput.Add(A50UsuName);
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.RTrim( Z3UsuCod));
         isValidOutput.Add(StringUtil.RTrim( Z87UsuNom));
         isValidOutput.Add(Z50UsuName);
         isValidOutput.Add(Gridpermisos_level1itemContainer);
         isValidOutput.Add(bttBtn_delete_Enabled);
         isValidOutput.Add(bttBtn_enter_Enabled);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Subcod( short GX_Parm1 ,
                                short GX_Parm2 ,
                                short GX_Parm3 )
      {
         A11ModCod = GX_Parm1;
         A12MenCod = GX_Parm2;
         A13SubCod = GX_Parm3;
         /* Using cursor T000P25 */
         pr_default.execute(23, new Object[] {A11ModCod, A12MenCod, A13SubCod});
         if ( (pr_default.getStatus(23) == 101) )
         {
            GX_msglist.addItem("No existe '1'.", "ForeignKeyNotFound", 1, "MODCOD");
            AnyError = 1;
            GX_FocusControl = edtModCod_Internalname;
         }
         pr_default.close(23);
         dynload_actions( ) ;
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'A50UsuName',fld:'USUNAME',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[]}");
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
         pr_default.close(23);
         pr_default.close(4);
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z3UsuCod = "";
         Z50UsuName = "";
         Z96PermEst = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         Gx_mode = "";
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
         A3UsuCod = "";
         A87UsuNom = "";
         lblTitlelevel1_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridpermisos_level1itemContainer = new GXWebGrid( context);
         Gridpermisos_level1itemColumn = new GXWebColumn();
         A96PermEst = "";
         sMode44 = "";
         sStyleString = "";
         A50UsuName = "";
         forbiddenHiddens = "";
         hsh = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         T000P7_A3UsuCod = new String[] {""} ;
         T000P7_A50UsuName = new String[] {""} ;
         T000P7_n50UsuName = new bool[] {false} ;
         T000P8_A3UsuCod = new String[] {""} ;
         T000P6_A3UsuCod = new String[] {""} ;
         T000P6_A50UsuName = new String[] {""} ;
         T000P6_n50UsuName = new bool[] {false} ;
         sMode3 = "";
         T000P9_A3UsuCod = new String[] {""} ;
         T000P10_A3UsuCod = new String[] {""} ;
         T000P5_A3UsuCod = new String[] {""} ;
         T000P5_A50UsuName = new String[] {""} ;
         T000P5_n50UsuName = new bool[] {false} ;
         T000P14_A1EmpID = new short[1] ;
         T000P14_A327procesoCod = new String[] {""} ;
         T000P15_A1EmpID = new short[1] ;
         T000P15_A2AgeID = new short[1] ;
         T000P15_A310ProdPreID = new short[1] ;
         T000P15_A286PrdCod = new short[1] ;
         T000P16_A29emailID = new short[1] ;
         T000P16_A3UsuCod = new String[] {""} ;
         T000P17_A3UsuCod = new String[] {""} ;
         T000P18_A3UsuCod = new String[] {""} ;
         T000P18_A15empcod = new short[1] ;
         T000P18_A16agecod = new short[1] ;
         T000P18_A96PermEst = new String[] {""} ;
         T000P18_n96PermEst = new bool[] {false} ;
         T000P18_A11ModCod = new short[1] ;
         T000P18_A12MenCod = new short[1] ;
         T000P18_A13SubCod = new short[1] ;
         T000P4_A11ModCod = new short[1] ;
         T000P19_A11ModCod = new short[1] ;
         T000P20_A3UsuCod = new String[] {""} ;
         T000P20_A15empcod = new short[1] ;
         T000P20_A16agecod = new short[1] ;
         T000P20_A11ModCod = new short[1] ;
         T000P20_A12MenCod = new short[1] ;
         T000P20_A13SubCod = new short[1] ;
         T000P3_A3UsuCod = new String[] {""} ;
         T000P3_A15empcod = new short[1] ;
         T000P3_A16agecod = new short[1] ;
         T000P3_A96PermEst = new String[] {""} ;
         T000P3_n96PermEst = new bool[] {false} ;
         T000P3_A11ModCod = new short[1] ;
         T000P3_A12MenCod = new short[1] ;
         T000P3_A13SubCod = new short[1] ;
         T000P2_A3UsuCod = new String[] {""} ;
         T000P2_A15empcod = new short[1] ;
         T000P2_A16agecod = new short[1] ;
         T000P2_A96PermEst = new String[] {""} ;
         T000P2_n96PermEst = new bool[] {false} ;
         T000P2_A11ModCod = new short[1] ;
         T000P2_A12MenCod = new short[1] ;
         T000P2_A13SubCod = new short[1] ;
         T000P24_A3UsuCod = new String[] {""} ;
         T000P24_A15empcod = new short[1] ;
         T000P24_A16agecod = new short[1] ;
         T000P24_A11ModCod = new short[1] ;
         T000P24_A12MenCod = new short[1] ;
         T000P24_A13SubCod = new short[1] ;
         Gridpermisos_level1itemRow = new GXWebRow();
         subGridpermisos_level1item_Linesclass = "";
         ROClassString = "";
         sImgUrl = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         Z87UsuNom = "";
         isValidOutput = new GxUnknownObjectCollection();
         T000P25_A11ModCod = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.permisos__default(),
            new Object[][] {
                new Object[] {
               T000P2_A3UsuCod, T000P2_A15empcod, T000P2_A16agecod, T000P2_A96PermEst, T000P2_n96PermEst, T000P2_A11ModCod, T000P2_A12MenCod, T000P2_A13SubCod
               }
               , new Object[] {
               T000P3_A3UsuCod, T000P3_A15empcod, T000P3_A16agecod, T000P3_A96PermEst, T000P3_n96PermEst, T000P3_A11ModCod, T000P3_A12MenCod, T000P3_A13SubCod
               }
               , new Object[] {
               T000P4_A11ModCod
               }
               , new Object[] {
               T000P5_A3UsuCod, T000P5_A50UsuName, T000P5_n50UsuName
               }
               , new Object[] {
               T000P6_A3UsuCod, T000P6_A50UsuName, T000P6_n50UsuName
               }
               , new Object[] {
               T000P7_A3UsuCod, T000P7_A50UsuName, T000P7_n50UsuName
               }
               , new Object[] {
               T000P8_A3UsuCod
               }
               , new Object[] {
               T000P9_A3UsuCod
               }
               , new Object[] {
               T000P10_A3UsuCod
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000P14_A1EmpID, T000P14_A327procesoCod
               }
               , new Object[] {
               T000P15_A1EmpID, T000P15_A2AgeID, T000P15_A310ProdPreID, T000P15_A286PrdCod
               }
               , new Object[] {
               T000P16_A29emailID, T000P16_A3UsuCod
               }
               , new Object[] {
               T000P17_A3UsuCod
               }
               , new Object[] {
               T000P18_A3UsuCod, T000P18_A15empcod, T000P18_A16agecod, T000P18_A96PermEst, T000P18_n96PermEst, T000P18_A11ModCod, T000P18_A12MenCod, T000P18_A13SubCod
               }
               , new Object[] {
               T000P19_A11ModCod
               }
               , new Object[] {
               T000P20_A3UsuCod, T000P20_A15empcod, T000P20_A16agecod, T000P20_A11ModCod, T000P20_A12MenCod, T000P20_A13SubCod
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000P24_A3UsuCod, T000P24_A15empcod, T000P24_A16agecod, T000P24_A11ModCod, T000P24_A12MenCod, T000P24_A13SubCod
               }
               , new Object[] {
               T000P25_A11ModCod
               }
            }
         );
      }

      private short nIsMod_44 ;
      private short nRC_GXsfl_48 ;
      private short nGXsfl_48_idx=1 ;
      private short Z15empcod ;
      private short Z16agecod ;
      private short Z11ModCod ;
      private short Z12MenCod ;
      private short Z13SubCod ;
      private short nRcdDeleted_44 ;
      private short nRcdExists_44 ;
      private short GxWebError ;
      private short A11ModCod ;
      private short A12MenCod ;
      private short A13SubCod ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short subGridpermisos_level1item_Backcolorstyle ;
      private short A15empcod ;
      private short A16agecod ;
      private short subGridpermisos_level1item_Allowselection ;
      private short subGridpermisos_level1item_Allowhovering ;
      private short subGridpermisos_level1item_Allowcollapsing ;
      private short subGridpermisos_level1item_Collapsed ;
      private short nBlankRcdCount44 ;
      private short RcdFound44 ;
      private short nBlankRcdUsr44 ;
      private short GX_JID ;
      private short RcdFound3 ;
      private short Gx_BScreen ;
      private short subGridpermisos_level1item_Backstyle ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtUsuCod_Enabled ;
      private int edtUsuNom_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtempcod_Enabled ;
      private int edtagecod_Enabled ;
      private int edtModCod_Enabled ;
      private int edtMenCod_Enabled ;
      private int edtSubCod_Enabled ;
      private int edtPermEst_Enabled ;
      private int subGridpermisos_level1item_Selectedindex ;
      private int subGridpermisos_level1item_Selectioncolor ;
      private int subGridpermisos_level1item_Hoveringcolor ;
      private int fRowAdded ;
      private int subGridpermisos_level1item_Backcolor ;
      private int subGridpermisos_level1item_Allbackcolor ;
      private int imgprompt_11_12_13_Visible ;
      private int defedtSubCod_Enabled ;
      private int defedtMenCod_Enabled ;
      private int defedtModCod_Enabled ;
      private int defedtagecod_Enabled ;
      private int defedtempcod_Enabled ;
      private int idxLst ;
      private long GRIDPERMISOS_LEVEL1ITEM_nFirstRecordOnPage ;
      private String sPrefix ;
      private String sGXsfl_48_idx="0001" ;
      private String Z3UsuCod ;
      private String Z96PermEst ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtUsuCod_Internalname ;
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
      private String edtUsuNom_Internalname ;
      private String A87UsuNom ;
      private String edtUsuNom_Jsonclick ;
      private String divLevel1table_Internalname ;
      private String lblTitlelevel1_Internalname ;
      private String lblTitlelevel1_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridpermisos_level1item_Header ;
      private String A96PermEst ;
      private String sMode44 ;
      private String edtempcod_Internalname ;
      private String edtagecod_Internalname ;
      private String edtModCod_Internalname ;
      private String edtMenCod_Internalname ;
      private String edtSubCod_Internalname ;
      private String edtPermEst_Internalname ;
      private String imgprompt_11_12_13_Link ;
      private String sStyleString ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String sMode3 ;
      private String imgprompt_11_12_13_Internalname ;
      private String sGXsfl_48_fel_idx="0001" ;
      private String subGridpermisos_level1item_Class ;
      private String subGridpermisos_level1item_Linesclass ;
      private String ROClassString ;
      private String edtempcod_Jsonclick ;
      private String edtagecod_Jsonclick ;
      private String edtModCod_Jsonclick ;
      private String edtMenCod_Jsonclick ;
      private String edtSubCod_Jsonclick ;
      private String sImgUrl ;
      private String edtPermEst_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridpermisos_level1item_Internalname ;
      private String Z87UsuNom ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool bGXsfl_48_Refreshing=false ;
      private bool n50UsuName ;
      private bool n96PermEst ;
      private String Z50UsuName ;
      private String A50UsuName ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebGrid Gridpermisos_level1itemContainer ;
      private GXWebRow Gridpermisos_level1itemRow ;
      private GXWebColumn Gridpermisos_level1itemColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T000P7_A3UsuCod ;
      private String[] T000P7_A50UsuName ;
      private bool[] T000P7_n50UsuName ;
      private String[] T000P8_A3UsuCod ;
      private String[] T000P6_A3UsuCod ;
      private String[] T000P6_A50UsuName ;
      private bool[] T000P6_n50UsuName ;
      private String[] T000P9_A3UsuCod ;
      private String[] T000P10_A3UsuCod ;
      private String[] T000P5_A3UsuCod ;
      private String[] T000P5_A50UsuName ;
      private bool[] T000P5_n50UsuName ;
      private short[] T000P14_A1EmpID ;
      private String[] T000P14_A327procesoCod ;
      private short[] T000P15_A1EmpID ;
      private short[] T000P15_A2AgeID ;
      private short[] T000P15_A310ProdPreID ;
      private short[] T000P15_A286PrdCod ;
      private short[] T000P16_A29emailID ;
      private String[] T000P16_A3UsuCod ;
      private String[] T000P17_A3UsuCod ;
      private String[] T000P18_A3UsuCod ;
      private short[] T000P18_A15empcod ;
      private short[] T000P18_A16agecod ;
      private String[] T000P18_A96PermEst ;
      private bool[] T000P18_n96PermEst ;
      private short[] T000P18_A11ModCod ;
      private short[] T000P18_A12MenCod ;
      private short[] T000P18_A13SubCod ;
      private short[] T000P4_A11ModCod ;
      private short[] T000P19_A11ModCod ;
      private String[] T000P20_A3UsuCod ;
      private short[] T000P20_A15empcod ;
      private short[] T000P20_A16agecod ;
      private short[] T000P20_A11ModCod ;
      private short[] T000P20_A12MenCod ;
      private short[] T000P20_A13SubCod ;
      private String[] T000P3_A3UsuCod ;
      private short[] T000P3_A15empcod ;
      private short[] T000P3_A16agecod ;
      private String[] T000P3_A96PermEst ;
      private bool[] T000P3_n96PermEst ;
      private short[] T000P3_A11ModCod ;
      private short[] T000P3_A12MenCod ;
      private short[] T000P3_A13SubCod ;
      private String[] T000P2_A3UsuCod ;
      private short[] T000P2_A15empcod ;
      private short[] T000P2_A16agecod ;
      private String[] T000P2_A96PermEst ;
      private bool[] T000P2_n96PermEst ;
      private short[] T000P2_A11ModCod ;
      private short[] T000P2_A12MenCod ;
      private short[] T000P2_A13SubCod ;
      private String[] T000P24_A3UsuCod ;
      private short[] T000P24_A15empcod ;
      private short[] T000P24_A16agecod ;
      private short[] T000P24_A11ModCod ;
      private short[] T000P24_A12MenCod ;
      private short[] T000P24_A13SubCod ;
      private short[] T000P25_A11ModCod ;
   }

   public class permisos__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new UpdateCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new UpdateCursor(def[19])
         ,new UpdateCursor(def[20])
         ,new UpdateCursor(def[21])
         ,new ForEachCursor(def[22])
         ,new ForEachCursor(def[23])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000P7 ;
          prmT000P7 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000P8 ;
          prmT000P8 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000P6 ;
          prmT000P6 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000P9 ;
          prmT000P9 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000P10 ;
          prmT000P10 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000P5 ;
          prmT000P5 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000P11 ;
          prmT000P11 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0} ,
          new Object[] {"@UsuName",SqlDbType.VarChar,40,0}
          } ;
          Object[] prmT000P12 ;
          prmT000P12 = new Object[] {
          new Object[] {"@UsuName",SqlDbType.VarChar,40,0} ,
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000P13 ;
          prmT000P13 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000P14 ;
          prmT000P14 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000P15 ;
          prmT000P15 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000P16 ;
          prmT000P16 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000P17 ;
          prmT000P17 = new Object[] {
          } ;
          Object[] prmT000P18 ;
          prmT000P18 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0} ,
          new Object[] {"@empcod",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@agecod",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SubCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000P4 ;
          prmT000P4 = new Object[] {
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SubCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000P19 ;
          prmT000P19 = new Object[] {
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SubCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000P20 ;
          prmT000P20 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0} ,
          new Object[] {"@empcod",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@agecod",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SubCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000P3 ;
          prmT000P3 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0} ,
          new Object[] {"@empcod",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@agecod",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SubCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000P2 ;
          prmT000P2 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0} ,
          new Object[] {"@empcod",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@agecod",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SubCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000P21 ;
          prmT000P21 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0} ,
          new Object[] {"@empcod",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@agecod",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PermEst",SqlDbType.Char,1,0} ,
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SubCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000P22 ;
          prmT000P22 = new Object[] {
          new Object[] {"@PermEst",SqlDbType.Char,1,0} ,
          new Object[] {"@UsuCod",SqlDbType.Char,15,0} ,
          new Object[] {"@empcod",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@agecod",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SubCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000P23 ;
          prmT000P23 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0} ,
          new Object[] {"@empcod",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@agecod",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SubCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000P24 ;
          prmT000P24 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000P25 ;
          prmT000P25 = new Object[] {
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SubCod",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000P2", "SELECT [UsuCod], [empcod], [agecod], [PermEst], [ModCod], [MenCod], [SubCod] FROM [PERMISOS] WITH (UPDLOCK) WHERE [UsuCod] = @UsuCod AND [empcod] = @empcod AND [agecod] = @agecod AND [ModCod] = @ModCod AND [MenCod] = @MenCod AND [SubCod] = @SubCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000P2,1,0,true,false )
             ,new CursorDef("T000P3", "SELECT [UsuCod], [empcod], [agecod], [PermEst], [ModCod], [MenCod], [SubCod] FROM [PERMISOS] WITH (NOLOCK) WHERE [UsuCod] = @UsuCod AND [empcod] = @empcod AND [agecod] = @agecod AND [ModCod] = @ModCod AND [MenCod] = @MenCod AND [SubCod] = @SubCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000P3,1,0,true,false )
             ,new CursorDef("T000P4", "SELECT [ModCod] FROM [MENUSUB] WITH (NOLOCK) WHERE [ModCod] = @ModCod AND [MenCod] = @MenCod AND [SubCod] = @SubCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000P4,1,0,true,false )
             ,new CursorDef("T000P5", "SELECT [UsuCod], [UsuName] FROM [Usuarios] WITH (UPDLOCK) WHERE [UsuCod] = @UsuCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000P5,1,0,true,false )
             ,new CursorDef("T000P6", "SELECT [UsuCod], [UsuName] FROM [Usuarios] WITH (NOLOCK) WHERE [UsuCod] = @UsuCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000P6,1,0,true,false )
             ,new CursorDef("T000P7", "SELECT TM1.[UsuCod], TM1.[UsuName] FROM [Usuarios] TM1 WITH (NOLOCK) WHERE TM1.[UsuCod] = @UsuCod ORDER BY TM1.[UsuCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000P7,100,0,true,false )
             ,new CursorDef("T000P8", "SELECT [UsuCod] FROM [Usuarios] WITH (NOLOCK) WHERE [UsuCod] = @UsuCod  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000P8,1,0,true,false )
             ,new CursorDef("T000P9", "SELECT TOP 1 [UsuCod] FROM [Usuarios] WITH (NOLOCK) WHERE ( [UsuCod] > @UsuCod) ORDER BY [UsuCod]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000P9,1,0,true,true )
             ,new CursorDef("T000P10", "SELECT TOP 1 [UsuCod] FROM [Usuarios] WITH (NOLOCK) WHERE ( [UsuCod] < @UsuCod) ORDER BY [UsuCod] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000P10,1,0,true,true )
             ,new CursorDef("T000P11", "INSERT INTO [Usuarios]([UsuCod], [UsuName], [UsuPassword], [UsuEst], [UsuRol], [UsuNivel], [UsuObserv], [UsuCorreo], [UsuClaveCorreo], [UsuSMTP], [UsuPuerto], [UsuAlias]) VALUES(@UsuCod, @UsuName, '', '', '', '', '', '', '', '', convert(int, 0), '')", GxErrorMask.GX_NOMASK,prmT000P11)
             ,new CursorDef("T000P12", "UPDATE [Usuarios] SET [UsuName]=@UsuName  WHERE [UsuCod] = @UsuCod", GxErrorMask.GX_NOMASK,prmT000P12)
             ,new CursorDef("T000P13", "DELETE FROM [Usuarios]  WHERE [UsuCod] = @UsuCod", GxErrorMask.GX_NOMASK,prmT000P13)
             ,new CursorDef("T000P14", "SELECT TOP 1 [EmpID], [procesoCod] FROM [Periodos] WITH (NOLOCK) WHERE [PerUser] = @UsuCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000P14,1,0,true,true )
             ,new CursorDef("T000P15", "SELECT TOP 1 [EmpID], [AgeID], [ProdPreID], [PrdCod] FROM [ProdPrecio] WITH (NOLOCK) WHERE [UsuCod] = @UsuCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000P15,1,0,true,true )
             ,new CursorDef("T000P16", "SELECT TOP 1 [emailID], [UsuCod] FROM [Emails] WITH (NOLOCK) WHERE [UsuCod] = @UsuCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000P16,1,0,true,true )
             ,new CursorDef("T000P17", "SELECT [UsuCod] FROM [Usuarios] WITH (NOLOCK) ORDER BY [UsuCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000P17,100,0,true,false )
             ,new CursorDef("T000P18", "SELECT [UsuCod], [empcod], [agecod], [PermEst], [ModCod], [MenCod], [SubCod] FROM [PERMISOS] WITH (NOLOCK) WHERE [UsuCod] = @UsuCod and [empcod] = @empcod and [agecod] = @agecod and [ModCod] = @ModCod and [MenCod] = @MenCod and [SubCod] = @SubCod ORDER BY [UsuCod], [empcod], [agecod], [ModCod], [MenCod], [SubCod] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000P18,11,0,true,false )
             ,new CursorDef("T000P19", "SELECT [ModCod] FROM [MENUSUB] WITH (NOLOCK) WHERE [ModCod] = @ModCod AND [MenCod] = @MenCod AND [SubCod] = @SubCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000P19,1,0,true,false )
             ,new CursorDef("T000P20", "SELECT [UsuCod], [empcod], [agecod], [ModCod], [MenCod], [SubCod] FROM [PERMISOS] WITH (NOLOCK) WHERE [UsuCod] = @UsuCod AND [empcod] = @empcod AND [agecod] = @agecod AND [ModCod] = @ModCod AND [MenCod] = @MenCod AND [SubCod] = @SubCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000P20,1,0,true,false )
             ,new CursorDef("T000P21", "INSERT INTO [PERMISOS]([UsuCod], [empcod], [agecod], [PermEst], [ModCod], [MenCod], [SubCod]) VALUES(@UsuCod, @empcod, @agecod, @PermEst, @ModCod, @MenCod, @SubCod)", GxErrorMask.GX_NOMASK,prmT000P21)
             ,new CursorDef("T000P22", "UPDATE [PERMISOS] SET [PermEst]=@PermEst  WHERE [UsuCod] = @UsuCod AND [empcod] = @empcod AND [agecod] = @agecod AND [ModCod] = @ModCod AND [MenCod] = @MenCod AND [SubCod] = @SubCod", GxErrorMask.GX_NOMASK,prmT000P22)
             ,new CursorDef("T000P23", "DELETE FROM [PERMISOS]  WHERE [UsuCod] = @UsuCod AND [empcod] = @empcod AND [agecod] = @agecod AND [ModCod] = @ModCod AND [MenCod] = @MenCod AND [SubCod] = @SubCod", GxErrorMask.GX_NOMASK,prmT000P23)
             ,new CursorDef("T000P24", "SELECT [UsuCod], [empcod], [agecod], [ModCod], [MenCod], [SubCod] FROM [PERMISOS] WITH (NOLOCK) WHERE [UsuCod] = @UsuCod ORDER BY [UsuCod], [empcod], [agecod], [ModCod], [MenCod], [SubCod] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000P24,11,0,true,false )
             ,new CursorDef("T000P25", "SELECT [ModCod] FROM [MENUSUB] WITH (NOLOCK) WHERE [ModCod] = @ModCod AND [MenCod] = @MenCod AND [SubCod] = @SubCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000P25,1,0,true,false )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 1) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                ((short[]) buf[7])[0] = rslt.getShort(7) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 1) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                ((short[]) buf[7])[0] = rslt.getShort(7) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                return;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                return;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                return;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                return;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 14 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                return;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                return;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 1) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                ((short[]) buf[7])[0] = rslt.getShort(7) ;
                return;
             case 17 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 22 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 23 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
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
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
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
                return;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                return;
             case 10 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                stmt.SetParameter(2, (String)parms[2]);
                return;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 14 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 16 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 18 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 19 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 4 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[4]);
                }
                stmt.SetParameter(5, (short)parms[5]);
                stmt.SetParameter(6, (short)parms[6]);
                stmt.SetParameter(7, (short)parms[7]);
                return;
             case 20 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                stmt.SetParameter(2, (String)parms[2]);
                stmt.SetParameter(3, (short)parms[3]);
                stmt.SetParameter(4, (short)parms[4]);
                stmt.SetParameter(5, (short)parms[5]);
                stmt.SetParameter(6, (short)parms[6]);
                stmt.SetParameter(7, (short)parms[7]);
                return;
             case 21 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 22 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 23 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
       }
    }

 }

}
