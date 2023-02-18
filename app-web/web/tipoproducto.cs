/*
               File: TipoProducto
        Description: Tipo Producto
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/29/2022 1:7:31.53
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
   public class tipoproducto : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_8") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_8( A1EmpID) ;
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
               AV7EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7EmpID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EmpID), "ZZZ9"), context));
               AV8tipoProdID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8tipoProdID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vTIPOPRODID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8tipoProdID), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Tipo Producto", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtEmpID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public tipoproducto( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public tipoproducto( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_EmpID ,
                           short aP2_tipoProdID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7EmpID = aP1_EmpID;
         this.AV8tipoProdID = aP2_tipoProdID;
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Tipo Producto", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_TipoProducto.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_TipoProducto.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_TipoProducto.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_TipoProducto.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_TipoProducto.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx00p0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"TIPOPRODID"+"'), id:'"+"TIPOPRODID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_TipoProducto.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEmpID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEmpID_Internalname, "Emp ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtEmpID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEmpID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEmpID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_TipoProducto.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_1_Internalname, sImgUrl, imgprompt_1_Link, "", "", context.GetTheme( ), imgprompt_1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_TipoProducto.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtempdsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtempdsc_Internalname, "Empresa", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtempdsc_Internalname, A44empdsc, StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempdsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtempdsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_TipoProducto.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edttipoProdID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edttipoProdID_Internalname, "Tipo Producto", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edttipoProdID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A31tipoProdID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A31tipoProdID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edttipoProdID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edttipoProdID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_TipoProducto.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edttipoProdDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edttipoProdDsc_Internalname, "Tipo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edttipoProdDsc_Internalname, StringUtil.RTrim( A144tipoProdDsc), StringUtil.RTrim( context.localUtil.Format( A144tipoProdDsc, "@!")), TempTags+" onchange=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edttipoProdDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edttipoProdDsc_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "nombres", "left", true, "HLP_TipoProducto.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edttipoProdEst_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edttipoProdEst_Internalname, "Estado", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edttipoProdEst_Internalname, StringUtil.RTrim( A145tipoProdEst), StringUtil.RTrim( context.localUtil.Format( A145tipoProdEst, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edttipoProdEst_Jsonclick, 0, "Attribute", "", "", "", "", 1, edttipoProdEst_Enabled, 0, "text", "", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, -1, true, "estado", "left", true, "HLP_TipoProducto.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_TipoProducto.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_TipoProducto.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_TipoProducto.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm0B25( ) ;
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
         E110B2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtEmpID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtEmpID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "EMPID");
                  AnyError = 1;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A1EmpID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               }
               else
               {
                  A1EmpID = (short)(context.localUtil.CToN( cgiGet( edtEmpID_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               }
               A44empdsc = StringUtil.Upper( cgiGet( edtempdsc_Internalname));
               n44empdsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
               if ( ( ( context.localUtil.CToN( cgiGet( edttipoProdID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edttipoProdID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "TIPOPRODID");
                  AnyError = 1;
                  GX_FocusControl = edttipoProdID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A31tipoProdID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A31tipoProdID), 4, 0)));
               }
               else
               {
                  A31tipoProdID = (short)(context.localUtil.CToN( cgiGet( edttipoProdID_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A31tipoProdID), 4, 0)));
               }
               A144tipoProdDsc = StringUtil.Upper( cgiGet( edttipoProdDsc_Internalname));
               n144tipoProdDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144tipoProdDsc", A144tipoProdDsc);
               n144tipoProdDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A144tipoProdDsc)) ? true : false);
               A145tipoProdEst = cgiGet( edttipoProdEst_Internalname);
               n145tipoProdEst = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A145tipoProdEst", A145tipoProdEst);
               n145tipoProdEst = (String.IsNullOrEmpty(StringUtil.RTrim( A145tipoProdEst)) ? true : false);
               /* Read saved values. */
               Z1EmpID = (short)(context.localUtil.CToN( cgiGet( "Z1EmpID"), ",", "."));
               Z31tipoProdID = (short)(context.localUtil.CToN( cgiGet( "Z31tipoProdID"), ",", "."));
               Z144tipoProdDsc = cgiGet( "Z144tipoProdDsc");
               n144tipoProdDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A144tipoProdDsc)) ? true : false);
               Z145tipoProdEst = cgiGet( "Z145tipoProdEst");
               n145tipoProdEst = (String.IsNullOrEmpty(StringUtil.RTrim( A145tipoProdEst)) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               AV7EmpID = (short)(context.localUtil.CToN( cgiGet( "vEMPID"), ",", "."));
               AV8tipoProdID = (short)(context.localUtil.CToN( cgiGet( "vTIPOPRODID"), ",", "."));
               AV12Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "TipoProducto";
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A1EmpID != Z1EmpID ) || ( A31tipoProdID != Z31tipoProdID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("tipoproducto:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
                  A31tipoProdID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A31tipoProdID), 4, 0)));
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
                     sMode25 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode25;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound25 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0B0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "EMPID");
                        AnyError = 1;
                        GX_FocusControl = edtEmpID_Internalname;
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
                        E110B2 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: After Trn */
                        E120B2 ();
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
            E120B2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0B25( ) ;
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
            DisableAttributes0B25( ) ;
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

      protected void CONFIRM_0B0( )
      {
         BeforeValidate0B25( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0B25( ) ;
            }
            else
            {
               CheckExtendedTable0B25( ) ;
               CloseExtendedTableCursors0B25( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0B0( )
      {
      }

      protected void E110B2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV12Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV10TrnContext.FromXml(AV11WebSession.Get("TrnContext"), null, "TransactionContext", "KBCalpesa22");
      }

      protected void E120B2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV10TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwtipoproducto.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0B25( short GX_JID )
      {
         if ( ( GX_JID == 7 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z144tipoProdDsc = T000B3_A144tipoProdDsc[0];
               Z145tipoProdEst = T000B3_A145tipoProdEst[0];
            }
            else
            {
               Z144tipoProdDsc = A144tipoProdDsc;
               Z145tipoProdEst = A145tipoProdEst;
            }
         }
         if ( GX_JID == -7 )
         {
            Z31tipoProdID = A31tipoProdID;
            Z144tipoProdDsc = A144tipoProdDsc;
            Z145tipoProdEst = A145tipoProdEst;
            Z1EmpID = A1EmpID;
            Z44empdsc = A44empdsc;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_1_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7EmpID) )
         {
            A1EmpID = AV7EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         }
         if ( ! (0==AV7EmpID) )
         {
            edtEmpID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         }
         else
         {
            edtEmpID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV7EmpID) )
         {
            edtEmpID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV8tipoProdID) )
         {
            A31tipoProdID = AV8tipoProdID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A31tipoProdID), 4, 0)));
         }
         if ( ! (0==AV8tipoProdID) )
         {
            edttipoProdID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edttipoProdID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edttipoProdID_Enabled), 5, 0)), true);
         }
         else
         {
            edttipoProdID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edttipoProdID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edttipoProdID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV8tipoProdID) )
         {
            edttipoProdID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edttipoProdID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edttipoProdID_Enabled), 5, 0)), true);
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
            /* Using cursor T000B4 */
            pr_default.execute(2, new Object[] {A1EmpID});
            A44empdsc = T000B4_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000B4_n44empdsc[0];
            pr_default.close(2);
            AV12Pgmname = "TipoProducto";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Pgmname", AV12Pgmname);
         }
      }

      protected void Load0B25( )
      {
         /* Using cursor T000B5 */
         pr_default.execute(3, new Object[] {A1EmpID, A31tipoProdID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound25 = 1;
            A44empdsc = T000B5_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000B5_n44empdsc[0];
            A144tipoProdDsc = T000B5_A144tipoProdDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144tipoProdDsc", A144tipoProdDsc);
            n144tipoProdDsc = T000B5_n144tipoProdDsc[0];
            A145tipoProdEst = T000B5_A145tipoProdEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A145tipoProdEst", A145tipoProdEst);
            n145tipoProdEst = T000B5_n145tipoProdEst[0];
            ZM0B25( -7) ;
         }
         pr_default.close(3);
         OnLoadActions0B25( ) ;
      }

      protected void OnLoadActions0B25( )
      {
         AV12Pgmname = "TipoProducto";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Pgmname", AV12Pgmname);
      }

      protected void CheckExtendedTable0B25( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV12Pgmname = "TipoProducto";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Pgmname", AV12Pgmname);
         /* Using cursor T000B4 */
         pr_default.execute(2, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000B4_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T000B4_n44empdsc[0];
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors0B25( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_8( short A1EmpID )
      {
         /* Using cursor T000B6 */
         pr_default.execute(4, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000B6_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T000B6_n44empdsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A44empdsc)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(4);
      }

      protected void GetKey0B25( )
      {
         /* Using cursor T000B7 */
         pr_default.execute(5, new Object[] {A1EmpID, A31tipoProdID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound25 = 1;
         }
         else
         {
            RcdFound25 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000B3 */
         pr_default.execute(1, new Object[] {A1EmpID, A31tipoProdID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0B25( 7) ;
            RcdFound25 = 1;
            A31tipoProdID = T000B3_A31tipoProdID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A31tipoProdID), 4, 0)));
            A144tipoProdDsc = T000B3_A144tipoProdDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144tipoProdDsc", A144tipoProdDsc);
            n144tipoProdDsc = T000B3_n144tipoProdDsc[0];
            A145tipoProdEst = T000B3_A145tipoProdEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A145tipoProdEst", A145tipoProdEst);
            n145tipoProdEst = T000B3_n145tipoProdEst[0];
            A1EmpID = T000B3_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            Z1EmpID = A1EmpID;
            Z31tipoProdID = A31tipoProdID;
            sMode25 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0B25( ) ;
            if ( AnyError == 1 )
            {
               RcdFound25 = 0;
               InitializeNonKey0B25( ) ;
            }
            Gx_mode = sMode25;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound25 = 0;
            InitializeNonKey0B25( ) ;
            sMode25 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode25;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0B25( ) ;
         if ( RcdFound25 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound25 = 0;
         /* Using cursor T000B8 */
         pr_default.execute(6, new Object[] {A1EmpID, A31tipoProdID});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T000B8_A1EmpID[0] < A1EmpID ) || ( T000B8_A1EmpID[0] == A1EmpID ) && ( T000B8_A31tipoProdID[0] < A31tipoProdID ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T000B8_A1EmpID[0] > A1EmpID ) || ( T000B8_A1EmpID[0] == A1EmpID ) && ( T000B8_A31tipoProdID[0] > A31tipoProdID ) ) )
            {
               A1EmpID = T000B8_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A31tipoProdID = T000B8_A31tipoProdID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A31tipoProdID), 4, 0)));
               RcdFound25 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound25 = 0;
         /* Using cursor T000B9 */
         pr_default.execute(7, new Object[] {A1EmpID, A31tipoProdID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T000B9_A1EmpID[0] > A1EmpID ) || ( T000B9_A1EmpID[0] == A1EmpID ) && ( T000B9_A31tipoProdID[0] > A31tipoProdID ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T000B9_A1EmpID[0] < A1EmpID ) || ( T000B9_A1EmpID[0] == A1EmpID ) && ( T000B9_A31tipoProdID[0] < A31tipoProdID ) ) )
            {
               A1EmpID = T000B9_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A31tipoProdID = T000B9_A31tipoProdID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A31tipoProdID), 4, 0)));
               RcdFound25 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0B25( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0B25( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound25 == 1 )
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A31tipoProdID != Z31tipoProdID ) )
               {
                  A1EmpID = Z1EmpID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
                  A31tipoProdID = Z31tipoProdID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A31tipoProdID), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "EMPID");
                  AnyError = 1;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0B25( ) ;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A31tipoProdID != Z31tipoProdID ) )
               {
                  /* Insert record */
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0B25( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "EMPID");
                     AnyError = 1;
                     GX_FocusControl = edtEmpID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtEmpID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0B25( ) ;
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
         if ( ( A1EmpID != Z1EmpID ) || ( A31tipoProdID != Z31tipoProdID ) )
         {
            A1EmpID = Z1EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A31tipoProdID = Z31tipoProdID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A31tipoProdID), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0B25( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000B2 */
            pr_default.execute(0, new Object[] {A1EmpID, A31tipoProdID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TipoProducto"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z144tipoProdDsc, T000B2_A144tipoProdDsc[0]) != 0 ) || ( StringUtil.StrCmp(Z145tipoProdEst, T000B2_A145tipoProdEst[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z144tipoProdDsc, T000B2_A144tipoProdDsc[0]) != 0 )
               {
                  GXUtil.WriteLog("tipoproducto:[seudo value changed for attri]"+"tipoProdDsc");
                  GXUtil.WriteLogRaw("Old: ",Z144tipoProdDsc);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A144tipoProdDsc[0]);
               }
               if ( StringUtil.StrCmp(Z145tipoProdEst, T000B2_A145tipoProdEst[0]) != 0 )
               {
                  GXUtil.WriteLog("tipoproducto:[seudo value changed for attri]"+"tipoProdEst");
                  GXUtil.WriteLogRaw("Old: ",Z145tipoProdEst);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A145tipoProdEst[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TipoProducto"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0B25( )
      {
         BeforeValidate0B25( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0B25( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0B25( 0) ;
            CheckOptimisticConcurrency0B25( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0B25( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0B25( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000B10 */
                     pr_default.execute(8, new Object[] {A31tipoProdID, n144tipoProdDsc, A144tipoProdDsc, n145tipoProdEst, A145tipoProdEst, A1EmpID});
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("TipoProducto") ;
                     if ( (pr_default.getStatus(8) == 1) )
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
                           ResetCaption0B0( ) ;
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
               Load0B25( ) ;
            }
            EndLevel0B25( ) ;
         }
         CloseExtendedTableCursors0B25( ) ;
      }

      protected void Update0B25( )
      {
         BeforeValidate0B25( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0B25( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0B25( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0B25( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0B25( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000B11 */
                     pr_default.execute(9, new Object[] {n144tipoProdDsc, A144tipoProdDsc, n145tipoProdEst, A145tipoProdEst, A1EmpID, A31tipoProdID});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("TipoProducto") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TipoProducto"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0B25( ) ;
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
            EndLevel0B25( ) ;
         }
         CloseExtendedTableCursors0B25( ) ;
      }

      protected void DeferredUpdate0B25( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0B25( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0B25( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0B25( ) ;
            AfterConfirm0B25( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0B25( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000B12 */
                  pr_default.execute(10, new Object[] {A1EmpID, A31tipoProdID});
                  pr_default.close(10);
                  dsDefault.SmartCacheProvider.SetUpdated("TipoProducto") ;
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
         sMode25 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0B25( ) ;
         Gx_mode = sMode25;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0B25( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV12Pgmname = "TipoProducto";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Pgmname", AV12Pgmname);
            /* Using cursor T000B13 */
            pr_default.execute(11, new Object[] {A1EmpID});
            A44empdsc = T000B13_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000B13_n44empdsc[0];
            pr_default.close(11);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000B14 */
            pr_default.execute(12, new Object[] {A1EmpID, A31tipoProdID});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Productos"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(12);
            /* Using cursor T000B15 */
            pr_default.execute(13, new Object[] {A1EmpID, A31tipoProdID});
            if ( (pr_default.getStatus(13) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Hist Precio Productos"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(13);
            /* Using cursor T000B16 */
            pr_default.execute(14, new Object[] {A1EmpID, A31tipoProdID});
            if ( (pr_default.getStatus(14) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"OPId"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(14);
            /* Using cursor T000B17 */
            pr_default.execute(15, new Object[] {A1EmpID, A31tipoProdID});
            if ( (pr_default.getStatus(15) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Level1"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(15);
            /* Using cursor T000B18 */
            pr_default.execute(16, new Object[] {A1EmpID, A31tipoProdID});
            if ( (pr_default.getStatus(16) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Categorias"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(16);
            /* Using cursor T000B19 */
            pr_default.execute(17, new Object[] {A1EmpID, A31tipoProdID});
            if ( (pr_default.getStatus(17) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Items"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(17);
         }
      }

      protected void EndLevel0B25( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0B25( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(11);
            context.CommitDataStores("tipoproducto",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0B0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(11);
            context.RollbackDataStores("tipoproducto",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0B25( )
      {
         /* Scan By routine */
         /* Using cursor T000B20 */
         pr_default.execute(18);
         RcdFound25 = 0;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound25 = 1;
            A1EmpID = T000B20_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A31tipoProdID = T000B20_A31tipoProdID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A31tipoProdID), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0B25( )
      {
         /* Scan next routine */
         pr_default.readNext(18);
         RcdFound25 = 0;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound25 = 1;
            A1EmpID = T000B20_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A31tipoProdID = T000B20_A31tipoProdID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A31tipoProdID), 4, 0)));
         }
      }

      protected void ScanEnd0B25( )
      {
         pr_default.close(18);
      }

      protected void AfterConfirm0B25( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0B25( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0B25( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0B25( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0B25( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0B25( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0B25( )
      {
         edtEmpID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         edtempdsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempdsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempdsc_Enabled), 5, 0)), true);
         edttipoProdID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edttipoProdID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edttipoProdID_Enabled), 5, 0)), true);
         edttipoProdDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edttipoProdDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edttipoProdDsc_Enabled), 5, 0)), true);
         edttipoProdEst_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edttipoProdEst_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edttipoProdEst_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0B25( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0B0( )
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
         context.SendWebValue( "Tipo Producto") ;
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
         context.AddJavascriptSource("gxcfg.js", "?2022102917331", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("tipoproducto.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7EmpID) + "," + UrlEncode("" +AV8tipoProdID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "TipoProducto";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("tipoproducto:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1EmpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z31tipoProdID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z31tipoProdID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z144tipoProdDsc", StringUtil.RTrim( Z144tipoProdDsc));
         GxWebStd.gx_hidden_field( context, "Z145tipoProdEst", StringUtil.RTrim( Z145tipoProdEst));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV10TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV10TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EmpID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vTIPOPRODID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8tipoProdID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vTIPOPRODID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8tipoProdID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV12Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void RenderHtmlCloseForm0B25( )
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
         return "TipoProducto" ;
      }

      public override String GetPgmdesc( )
      {
         return "Tipo Producto" ;
      }

      protected void InitializeNonKey0B25( )
      {
         A44empdsc = "";
         n44empdsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         A144tipoProdDsc = "";
         n144tipoProdDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144tipoProdDsc", A144tipoProdDsc);
         n144tipoProdDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A144tipoProdDsc)) ? true : false);
         A145tipoProdEst = "";
         n145tipoProdEst = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A145tipoProdEst", A145tipoProdEst);
         n145tipoProdEst = (String.IsNullOrEmpty(StringUtil.RTrim( A145tipoProdEst)) ? true : false);
         Z144tipoProdDsc = "";
         Z145tipoProdEst = "";
      }

      protected void InitAll0B25( )
      {
         A1EmpID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         A31tipoProdID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A31tipoProdID), 4, 0)));
         InitializeNonKey0B25( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022102917338", true);
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
         context.AddJavascriptSource("tipoproducto.js", "?2022102917338", false);
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
         edtEmpID_Internalname = "EMPID";
         edtempdsc_Internalname = "EMPDSC";
         edttipoProdID_Internalname = "TIPOPRODID";
         edttipoProdDsc_Internalname = "TIPOPRODDSC";
         edttipoProdEst_Internalname = "TIPOPRODEST";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_1_Internalname = "PROMPT_1";
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
         edttipoProdEst_Jsonclick = "";
         edttipoProdEst_Enabled = 1;
         edttipoProdDsc_Jsonclick = "";
         edttipoProdDsc_Enabled = 1;
         edttipoProdID_Jsonclick = "";
         edttipoProdID_Enabled = 1;
         edtempdsc_Jsonclick = "";
         edtempdsc_Enabled = 0;
         imgprompt_1_Visible = 1;
         imgprompt_1_Link = "";
         edtEmpID_Jsonclick = "";
         edtEmpID_Enabled = 1;
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

      public void Valid_Empid( short GX_Parm1 ,
                               String GX_Parm2 )
      {
         A1EmpID = GX_Parm1;
         A44empdsc = GX_Parm2;
         n44empdsc = false;
         /* Using cursor T000B13 */
         pr_default.execute(11, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(11) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A44empdsc = T000B13_A44empdsc[0];
         n44empdsc = T000B13_n44empdsc[0];
         pr_default.close(11);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A44empdsc = "";
            n44empdsc = false;
         }
         isValidOutput.Add(A44empdsc);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV8tipoProdID',fld:'vTIPOPRODID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV8tipoProdID',fld:'vTIPOPRODID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120B2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV10TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(11);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z144tipoProdDsc = "";
         Z145tipoProdEst = "";
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
         sImgUrl = "";
         A44empdsc = "";
         A144tipoProdDsc = "";
         A145tipoProdEst = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         AV12Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode25 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV10TrnContext = new SdtTransactionContext(context);
         AV11WebSession = context.GetSession();
         Z44empdsc = "";
         T000B4_A44empdsc = new String[] {""} ;
         T000B4_n44empdsc = new bool[] {false} ;
         T000B5_A31tipoProdID = new short[1] ;
         T000B5_A44empdsc = new String[] {""} ;
         T000B5_n44empdsc = new bool[] {false} ;
         T000B5_A144tipoProdDsc = new String[] {""} ;
         T000B5_n144tipoProdDsc = new bool[] {false} ;
         T000B5_A145tipoProdEst = new String[] {""} ;
         T000B5_n145tipoProdEst = new bool[] {false} ;
         T000B5_A1EmpID = new short[1] ;
         T000B6_A44empdsc = new String[] {""} ;
         T000B6_n44empdsc = new bool[] {false} ;
         T000B7_A1EmpID = new short[1] ;
         T000B7_A31tipoProdID = new short[1] ;
         T000B3_A31tipoProdID = new short[1] ;
         T000B3_A144tipoProdDsc = new String[] {""} ;
         T000B3_n144tipoProdDsc = new bool[] {false} ;
         T000B3_A145tipoProdEst = new String[] {""} ;
         T000B3_n145tipoProdEst = new bool[] {false} ;
         T000B3_A1EmpID = new short[1] ;
         T000B8_A1EmpID = new short[1] ;
         T000B8_A31tipoProdID = new short[1] ;
         T000B9_A1EmpID = new short[1] ;
         T000B9_A31tipoProdID = new short[1] ;
         T000B2_A31tipoProdID = new short[1] ;
         T000B2_A144tipoProdDsc = new String[] {""} ;
         T000B2_n144tipoProdDsc = new bool[] {false} ;
         T000B2_A145tipoProdEst = new String[] {""} ;
         T000B2_n145tipoProdEst = new bool[] {false} ;
         T000B2_A1EmpID = new short[1] ;
         T000B13_A44empdsc = new String[] {""} ;
         T000B13_n44empdsc = new bool[] {false} ;
         T000B14_A1EmpID = new short[1] ;
         T000B14_A2AgeID = new short[1] ;
         T000B14_A286PrdCod = new short[1] ;
         T000B15_A1EmpID = new short[1] ;
         T000B15_A227HistAnio = new short[1] ;
         T000B15_A228HistPeriodo = new short[1] ;
         T000B15_A36detTipoProdID = new short[1] ;
         T000B15_A32categID = new short[1] ;
         T000B15_A33subCatID = new short[1] ;
         T000B16_A1EmpID = new short[1] ;
         T000B16_A39PedCod = new int[1] ;
         T000B16_A40OPIdSec = new int[1] ;
         T000B17_A1EmpID = new short[1] ;
         T000B17_A34CotiID = new short[1] ;
         T000B17_A35secID = new short[1] ;
         T000B18_A1EmpID = new short[1] ;
         T000B18_A32categID = new short[1] ;
         T000B19_A1EmpID = new short[1] ;
         T000B19_A5ClienteID = new short[1] ;
         T000B19_A24OrdenPeriodo = new short[1] ;
         T000B19_A25OrdenAnio = new short[1] ;
         T000B19_A22OrdenID = new short[1] ;
         T000B19_A41OrdenSecId = new short[1] ;
         T000B20_A1EmpID = new short[1] ;
         T000B20_A31tipoProdID = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tipoproducto__default(),
            new Object[][] {
                new Object[] {
               T000B2_A31tipoProdID, T000B2_A144tipoProdDsc, T000B2_n144tipoProdDsc, T000B2_A145tipoProdEst, T000B2_n145tipoProdEst, T000B2_A1EmpID
               }
               , new Object[] {
               T000B3_A31tipoProdID, T000B3_A144tipoProdDsc, T000B3_n144tipoProdDsc, T000B3_A145tipoProdEst, T000B3_n145tipoProdEst, T000B3_A1EmpID
               }
               , new Object[] {
               T000B4_A44empdsc, T000B4_n44empdsc
               }
               , new Object[] {
               T000B5_A31tipoProdID, T000B5_A44empdsc, T000B5_n44empdsc, T000B5_A144tipoProdDsc, T000B5_n144tipoProdDsc, T000B5_A145tipoProdEst, T000B5_n145tipoProdEst, T000B5_A1EmpID
               }
               , new Object[] {
               T000B6_A44empdsc, T000B6_n44empdsc
               }
               , new Object[] {
               T000B7_A1EmpID, T000B7_A31tipoProdID
               }
               , new Object[] {
               T000B8_A1EmpID, T000B8_A31tipoProdID
               }
               , new Object[] {
               T000B9_A1EmpID, T000B9_A31tipoProdID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000B13_A44empdsc, T000B13_n44empdsc
               }
               , new Object[] {
               T000B14_A1EmpID, T000B14_A2AgeID, T000B14_A286PrdCod
               }
               , new Object[] {
               T000B15_A1EmpID, T000B15_A227HistAnio, T000B15_A228HistPeriodo, T000B15_A36detTipoProdID, T000B15_A32categID, T000B15_A33subCatID
               }
               , new Object[] {
               T000B16_A1EmpID, T000B16_A39PedCod, T000B16_A40OPIdSec
               }
               , new Object[] {
               T000B17_A1EmpID, T000B17_A34CotiID, T000B17_A35secID
               }
               , new Object[] {
               T000B18_A1EmpID, T000B18_A32categID
               }
               , new Object[] {
               T000B19_A1EmpID, T000B19_A5ClienteID, T000B19_A24OrdenPeriodo, T000B19_A25OrdenAnio, T000B19_A22OrdenID, T000B19_A41OrdenSecId
               }
               , new Object[] {
               T000B20_A1EmpID, T000B20_A31tipoProdID
               }
            }
         );
         AV12Pgmname = "TipoProducto";
      }

      private short wcpOAV7EmpID ;
      private short wcpOAV8tipoProdID ;
      private short Z1EmpID ;
      private short Z31tipoProdID ;
      private short GxWebError ;
      private short A1EmpID ;
      private short AV7EmpID ;
      private short AV8tipoProdID ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short A31tipoProdID ;
      private short RcdFound25 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtEmpID_Enabled ;
      private int imgprompt_1_Visible ;
      private int edtempdsc_Enabled ;
      private int edttipoProdID_Enabled ;
      private int edttipoProdDsc_Enabled ;
      private int edttipoProdEst_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z144tipoProdDsc ;
      private String Z145tipoProdEst ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtEmpID_Internalname ;
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
      private String edtEmpID_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_1_Internalname ;
      private String imgprompt_1_Link ;
      private String edtempdsc_Internalname ;
      private String edtempdsc_Jsonclick ;
      private String edttipoProdID_Internalname ;
      private String edttipoProdID_Jsonclick ;
      private String edttipoProdDsc_Internalname ;
      private String A144tipoProdDsc ;
      private String edttipoProdDsc_Jsonclick ;
      private String edttipoProdEst_Internalname ;
      private String A145tipoProdEst ;
      private String edttipoProdEst_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String AV12Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode25 ;
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
      private bool n44empdsc ;
      private bool n144tipoProdDsc ;
      private bool n145tipoProdEst ;
      private bool returnInSub ;
      private String A44empdsc ;
      private String Z44empdsc ;
      private IGxSession AV11WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T000B4_A44empdsc ;
      private bool[] T000B4_n44empdsc ;
      private short[] T000B5_A31tipoProdID ;
      private String[] T000B5_A44empdsc ;
      private bool[] T000B5_n44empdsc ;
      private String[] T000B5_A144tipoProdDsc ;
      private bool[] T000B5_n144tipoProdDsc ;
      private String[] T000B5_A145tipoProdEst ;
      private bool[] T000B5_n145tipoProdEst ;
      private short[] T000B5_A1EmpID ;
      private String[] T000B6_A44empdsc ;
      private bool[] T000B6_n44empdsc ;
      private short[] T000B7_A1EmpID ;
      private short[] T000B7_A31tipoProdID ;
      private short[] T000B3_A31tipoProdID ;
      private String[] T000B3_A144tipoProdDsc ;
      private bool[] T000B3_n144tipoProdDsc ;
      private String[] T000B3_A145tipoProdEst ;
      private bool[] T000B3_n145tipoProdEst ;
      private short[] T000B3_A1EmpID ;
      private short[] T000B8_A1EmpID ;
      private short[] T000B8_A31tipoProdID ;
      private short[] T000B9_A1EmpID ;
      private short[] T000B9_A31tipoProdID ;
      private short[] T000B2_A31tipoProdID ;
      private String[] T000B2_A144tipoProdDsc ;
      private bool[] T000B2_n144tipoProdDsc ;
      private String[] T000B2_A145tipoProdEst ;
      private bool[] T000B2_n145tipoProdEst ;
      private short[] T000B2_A1EmpID ;
      private String[] T000B13_A44empdsc ;
      private bool[] T000B13_n44empdsc ;
      private short[] T000B14_A1EmpID ;
      private short[] T000B14_A2AgeID ;
      private short[] T000B14_A286PrdCod ;
      private short[] T000B15_A1EmpID ;
      private short[] T000B15_A227HistAnio ;
      private short[] T000B15_A228HistPeriodo ;
      private short[] T000B15_A36detTipoProdID ;
      private short[] T000B15_A32categID ;
      private short[] T000B15_A33subCatID ;
      private short[] T000B16_A1EmpID ;
      private int[] T000B16_A39PedCod ;
      private int[] T000B16_A40OPIdSec ;
      private short[] T000B17_A1EmpID ;
      private short[] T000B17_A34CotiID ;
      private short[] T000B17_A35secID ;
      private short[] T000B18_A1EmpID ;
      private short[] T000B18_A32categID ;
      private short[] T000B19_A1EmpID ;
      private short[] T000B19_A5ClienteID ;
      private short[] T000B19_A24OrdenPeriodo ;
      private short[] T000B19_A25OrdenAnio ;
      private short[] T000B19_A22OrdenID ;
      private short[] T000B19_A41OrdenSecId ;
      private short[] T000B20_A1EmpID ;
      private short[] T000B20_A31tipoProdID ;
      private SdtTransactionContext AV10TrnContext ;
   }

   public class tipoproducto__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000B5 ;
          prmT000B5 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000B4 ;
          prmT000B4 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000B6 ;
          prmT000B6 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000B7 ;
          prmT000B7 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000B3 ;
          prmT000B3 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000B8 ;
          prmT000B8 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000B9 ;
          prmT000B9 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000B2 ;
          prmT000B2 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000B10 ;
          prmT000B10 = new Object[] {
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoProdDsc",SqlDbType.Char,40,0} ,
          new Object[] {"@tipoProdEst",SqlDbType.Char,1,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000B11 ;
          prmT000B11 = new Object[] {
          new Object[] {"@tipoProdDsc",SqlDbType.Char,40,0} ,
          new Object[] {"@tipoProdEst",SqlDbType.Char,1,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000B12 ;
          prmT000B12 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000B14 ;
          prmT000B14 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000B15 ;
          prmT000B15 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000B16 ;
          prmT000B16 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000B17 ;
          prmT000B17 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000B18 ;
          prmT000B18 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000B19 ;
          prmT000B19 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000B20 ;
          prmT000B20 = new Object[] {
          } ;
          Object[] prmT000B13 ;
          prmT000B13 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000B2", "SELECT [tipoProdID], [tipoProdDsc], [tipoProdEst], [EmpID] FROM [TipoProducto] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [tipoProdID] = @tipoProdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B2,1,0,true,false )
             ,new CursorDef("T000B3", "SELECT [tipoProdID], [tipoProdDsc], [tipoProdEst], [EmpID] FROM [TipoProducto] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [tipoProdID] = @tipoProdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B3,1,0,true,false )
             ,new CursorDef("T000B4", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B4,1,0,true,false )
             ,new CursorDef("T000B5", "SELECT TM1.[tipoProdID], T2.[empdsc], TM1.[tipoProdDsc], TM1.[tipoProdEst], TM1.[EmpID] FROM ([TipoProducto] TM1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = TM1.[EmpID]) WHERE TM1.[EmpID] = @EmpID and TM1.[tipoProdID] = @tipoProdID ORDER BY TM1.[EmpID], TM1.[tipoProdID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000B5,100,0,true,false )
             ,new CursorDef("T000B6", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B6,1,0,true,false )
             ,new CursorDef("T000B7", "SELECT [EmpID], [tipoProdID] FROM [TipoProducto] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [tipoProdID] = @tipoProdID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000B7,1,0,true,false )
             ,new CursorDef("T000B8", "SELECT TOP 1 [EmpID], [tipoProdID] FROM [TipoProducto] WITH (NOLOCK) WHERE ( [EmpID] > @EmpID or [EmpID] = @EmpID and [tipoProdID] > @tipoProdID) ORDER BY [EmpID], [tipoProdID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000B8,1,0,true,true )
             ,new CursorDef("T000B9", "SELECT TOP 1 [EmpID], [tipoProdID] FROM [TipoProducto] WITH (NOLOCK) WHERE ( [EmpID] < @EmpID or [EmpID] = @EmpID and [tipoProdID] < @tipoProdID) ORDER BY [EmpID] DESC, [tipoProdID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000B9,1,0,true,true )
             ,new CursorDef("T000B10", "INSERT INTO [TipoProducto]([tipoProdID], [tipoProdDsc], [tipoProdEst], [EmpID]) VALUES(@tipoProdID, @tipoProdDsc, @tipoProdEst, @EmpID)", GxErrorMask.GX_NOMASK,prmT000B10)
             ,new CursorDef("T000B11", "UPDATE [TipoProducto] SET [tipoProdDsc]=@tipoProdDsc, [tipoProdEst]=@tipoProdEst  WHERE [EmpID] = @EmpID AND [tipoProdID] = @tipoProdID", GxErrorMask.GX_NOMASK,prmT000B11)
             ,new CursorDef("T000B12", "DELETE FROM [TipoProducto]  WHERE [EmpID] = @EmpID AND [tipoProdID] = @tipoProdID", GxErrorMask.GX_NOMASK,prmT000B12)
             ,new CursorDef("T000B13", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B13,1,0,true,false )
             ,new CursorDef("T000B14", "SELECT TOP 1 [EmpID], [AgeID], [PrdCod] FROM [Productos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [tipoProdID] = @tipoProdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B14,1,0,true,true )
             ,new CursorDef("T000B15", "SELECT TOP 1 [EmpID], [HistAnio], [HistPeriodo], [detTipoProdID], [categID], [subCatID] FROM [HistPrecioProd] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [detTipoProdID] = @tipoProdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B15,1,0,true,true )
             ,new CursorDef("T000B16", "SELECT TOP 1 [EmpID], [PedCod], [OPIdSec] FROM [OrdenPedidoOPId] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [detTipoProdID] = @tipoProdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B16,1,0,true,true )
             ,new CursorDef("T000B17", "SELECT TOP 1 [EmpID], [CotiID], [secID] FROM [CotizadorLevel1] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [detTipoProdID] = @tipoProdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B17,1,0,true,true )
             ,new CursorDef("T000B18", "SELECT TOP 1 [EmpID], [categID] FROM [Categorias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [tipoProdID] = @tipoProdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B18,1,0,true,true )
             ,new CursorDef("T000B19", "SELECT TOP 1 [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID], [OrdenSecId] FROM [OrdenProduccionOpItems] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [detTipoProdID] = @tipoProdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B19,1,0,true,true )
             ,new CursorDef("T000B20", "SELECT [EmpID], [tipoProdID] FROM [TipoProducto] WITH (NOLOCK) ORDER BY [EmpID], [tipoProdID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000B20,100,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 40) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 40) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 40) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 1) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 14 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                return;
             case 15 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 16 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 17 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 18 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
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
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.Char );
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
                stmt.SetParameter(4, (short)parms[5]);
                return;
             case 9 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Char );
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
                stmt.SetParameter(3, (short)parms[4]);
                stmt.SetParameter(4, (short)parms[5]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
       }
    }

 }

}
