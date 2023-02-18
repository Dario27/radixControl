/*
               File: Vendedor
        Description: Vendedor
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/14/2023 1:15:39.23
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
   public class vendedor : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
               AV8vendedorID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8vendedorID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8vendedorID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vVENDEDORID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8vendedorID), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Vendedor", 0) ;
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

      public vendedor( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public vendedor( IGxContext context )
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
                           short aP2_vendedorID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7EmpID = aP1_EmpID;
         this.AV8vendedorID = aP2_vendedorID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbvendedorEst = new GXCombobox();
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
         if ( cmbvendedorEst.ItemCount > 0 )
         {
            A73vendedorEst = cmbvendedorEst.getValidValue(A73vendedorEst);
            n73vendedorEst = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A73vendedorEst", A73vendedorEst);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbvendedorEst.CurrentValue = StringUtil.RTrim( A73vendedorEst);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbvendedorEst_Internalname, "Values", cmbvendedorEst.ToJavascriptSource(), true);
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Vendedor", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Vendedor.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Vendedor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Vendedor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Vendedor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Vendedor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0090.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"VENDEDORID"+"'), id:'"+"VENDEDORID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_Vendedor.htm");
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
            GxWebStd.gx_single_line_edit( context, edtEmpID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEmpID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEmpID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Vendedor.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_1_Internalname, sImgUrl, imgprompt_1_Link, "", "", context.GetTheme( ), imgprompt_1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Vendedor.htm");
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
            GxWebStd.gx_single_line_edit( context, edtempdsc_Internalname, A44empdsc, StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempdsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtempdsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Vendedor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtvendedorID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtvendedorID_Internalname, "ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtvendedorID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A9vendedorID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A9vendedorID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtvendedorID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtvendedorID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Vendedor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtvendedorDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtvendedorDsc_Internalname, "vendedor", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtvendedorDsc_Internalname, StringUtil.RTrim( A72vendedorDsc), StringUtil.RTrim( context.localUtil.Format( A72vendedorDsc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtvendedorDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtvendedorDsc_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "Descripcion", "left", true, "HLP_Vendedor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtVendedorSiglas_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtVendedorSiglas_Internalname, "Siglas", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtVendedorSiglas_Internalname, A121VendedorSiglas, StringUtil.RTrim( context.localUtil.Format( A121VendedorSiglas, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVendedorSiglas_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtVendedorSiglas_Enabled, 0, "text", "", 5, "chr", 1, "row", 5, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Vendedor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbvendedorEst_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbvendedorEst_Internalname, "Estado", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbvendedorEst, cmbvendedorEst_Internalname, StringUtil.RTrim( A73vendedorEst), 1, cmbvendedorEst_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbvendedorEst.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", "", true, "HLP_Vendedor.htm");
            cmbvendedorEst.CurrentValue = StringUtil.RTrim( A73vendedorEst);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbvendedorEst_Internalname, "Values", (String)(cmbvendedorEst.ToJavascriptSource()), true);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Vendedor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Vendedor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Vendedor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm059( ) ;
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
         E11052 ();
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtvendedorID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtvendedorID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "VENDEDORID");
                  AnyError = 1;
                  GX_FocusControl = edtvendedorID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A9vendedorID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9vendedorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A9vendedorID), 4, 0)));
               }
               else
               {
                  A9vendedorID = (short)(context.localUtil.CToN( cgiGet( edtvendedorID_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9vendedorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A9vendedorID), 4, 0)));
               }
               A72vendedorDsc = cgiGet( edtvendedorDsc_Internalname);
               n72vendedorDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A72vendedorDsc", A72vendedorDsc);
               n72vendedorDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A72vendedorDsc)) ? true : false);
               A121VendedorSiglas = cgiGet( edtVendedorSiglas_Internalname);
               n121VendedorSiglas = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121VendedorSiglas", A121VendedorSiglas);
               n121VendedorSiglas = (String.IsNullOrEmpty(StringUtil.RTrim( A121VendedorSiglas)) ? true : false);
               cmbvendedorEst.CurrentValue = cgiGet( cmbvendedorEst_Internalname);
               A73vendedorEst = cgiGet( cmbvendedorEst_Internalname);
               n73vendedorEst = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A73vendedorEst", A73vendedorEst);
               n73vendedorEst = (String.IsNullOrEmpty(StringUtil.RTrim( A73vendedorEst)) ? true : false);
               /* Read saved values. */
               Z1EmpID = (short)(context.localUtil.CToN( cgiGet( "Z1EmpID"), ",", "."));
               Z9vendedorID = (short)(context.localUtil.CToN( cgiGet( "Z9vendedorID"), ",", "."));
               Z72vendedorDsc = cgiGet( "Z72vendedorDsc");
               n72vendedorDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A72vendedorDsc)) ? true : false);
               Z121VendedorSiglas = cgiGet( "Z121VendedorSiglas");
               n121VendedorSiglas = (String.IsNullOrEmpty(StringUtil.RTrim( A121VendedorSiglas)) ? true : false);
               Z73vendedorEst = cgiGet( "Z73vendedorEst");
               n73vendedorEst = (String.IsNullOrEmpty(StringUtil.RTrim( A73vendedorEst)) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               AV7EmpID = (short)(context.localUtil.CToN( cgiGet( "vEMPID"), ",", "."));
               AV8vendedorID = (short)(context.localUtil.CToN( cgiGet( "vVENDEDORID"), ",", "."));
               AV12Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Vendedor";
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A1EmpID != Z1EmpID ) || ( A9vendedorID != Z9vendedorID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("vendedor:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A9vendedorID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9vendedorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A9vendedorID), 4, 0)));
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
                     sMode9 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode9;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound9 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_050( ) ;
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
                        E11052 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: After Trn */
                        E12052 ();
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
            E12052 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll059( ) ;
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
            DisableAttributes059( ) ;
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

      protected void CONFIRM_050( )
      {
         BeforeValidate059( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls059( ) ;
            }
            else
            {
               CheckExtendedTable059( ) ;
               CloseExtendedTableCursors059( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption050( )
      {
      }

      protected void E11052( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV12Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV10TrnContext.FromXml(AV11WebSession.Get("TrnContext"), null, "TransactionContext", "KBCalpesa22");
      }

      protected void E12052( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV10TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwvendedor.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM059( short GX_JID )
      {
         if ( ( GX_JID == 7 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z72vendedorDsc = T00053_A72vendedorDsc[0];
               Z121VendedorSiglas = T00053_A121VendedorSiglas[0];
               Z73vendedorEst = T00053_A73vendedorEst[0];
            }
            else
            {
               Z72vendedorDsc = A72vendedorDsc;
               Z121VendedorSiglas = A121VendedorSiglas;
               Z73vendedorEst = A73vendedorEst;
            }
         }
         if ( GX_JID == -7 )
         {
            Z9vendedorID = A9vendedorID;
            Z72vendedorDsc = A72vendedorDsc;
            Z121VendedorSiglas = A121VendedorSiglas;
            Z73vendedorEst = A73vendedorEst;
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
         if ( ! (0==AV8vendedorID) )
         {
            A9vendedorID = AV8vendedorID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9vendedorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A9vendedorID), 4, 0)));
         }
         if ( ! (0==AV8vendedorID) )
         {
            edtvendedorID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtvendedorID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtvendedorID_Enabled), 5, 0)), true);
         }
         else
         {
            edtvendedorID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtvendedorID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtvendedorID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV8vendedorID) )
         {
            edtvendedorID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtvendedorID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtvendedorID_Enabled), 5, 0)), true);
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
            /* Using cursor T00054 */
            pr_default.execute(2, new Object[] {A1EmpID});
            A44empdsc = T00054_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T00054_n44empdsc[0];
            pr_default.close(2);
            AV12Pgmname = "Vendedor";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Pgmname", AV12Pgmname);
         }
      }

      protected void Load059( )
      {
         /* Using cursor T00055 */
         pr_default.execute(3, new Object[] {A1EmpID, A9vendedorID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound9 = 1;
            A44empdsc = T00055_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T00055_n44empdsc[0];
            A72vendedorDsc = T00055_A72vendedorDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A72vendedorDsc", A72vendedorDsc);
            n72vendedorDsc = T00055_n72vendedorDsc[0];
            A121VendedorSiglas = T00055_A121VendedorSiglas[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121VendedorSiglas", A121VendedorSiglas);
            n121VendedorSiglas = T00055_n121VendedorSiglas[0];
            A73vendedorEst = T00055_A73vendedorEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A73vendedorEst", A73vendedorEst);
            n73vendedorEst = T00055_n73vendedorEst[0];
            ZM059( -7) ;
         }
         pr_default.close(3);
         OnLoadActions059( ) ;
      }

      protected void OnLoadActions059( )
      {
         AV12Pgmname = "Vendedor";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Pgmname", AV12Pgmname);
      }

      protected void CheckExtendedTable059( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV12Pgmname = "Vendedor";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Pgmname", AV12Pgmname);
         /* Using cursor T00054 */
         pr_default.execute(2, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T00054_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T00054_n44empdsc[0];
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors059( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_8( short A1EmpID )
      {
         /* Using cursor T00056 */
         pr_default.execute(4, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T00056_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T00056_n44empdsc[0];
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

      protected void GetKey059( )
      {
         /* Using cursor T00057 */
         pr_default.execute(5, new Object[] {A1EmpID, A9vendedorID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound9 = 1;
         }
         else
         {
            RcdFound9 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00053 */
         pr_default.execute(1, new Object[] {A1EmpID, A9vendedorID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM059( 7) ;
            RcdFound9 = 1;
            A9vendedorID = T00053_A9vendedorID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9vendedorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A9vendedorID), 4, 0)));
            A72vendedorDsc = T00053_A72vendedorDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A72vendedorDsc", A72vendedorDsc);
            n72vendedorDsc = T00053_n72vendedorDsc[0];
            A121VendedorSiglas = T00053_A121VendedorSiglas[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121VendedorSiglas", A121VendedorSiglas);
            n121VendedorSiglas = T00053_n121VendedorSiglas[0];
            A73vendedorEst = T00053_A73vendedorEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A73vendedorEst", A73vendedorEst);
            n73vendedorEst = T00053_n73vendedorEst[0];
            A1EmpID = T00053_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            Z1EmpID = A1EmpID;
            Z9vendedorID = A9vendedorID;
            sMode9 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load059( ) ;
            if ( AnyError == 1 )
            {
               RcdFound9 = 0;
               InitializeNonKey059( ) ;
            }
            Gx_mode = sMode9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound9 = 0;
            InitializeNonKey059( ) ;
            sMode9 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey059( ) ;
         if ( RcdFound9 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound9 = 0;
         /* Using cursor T00058 */
         pr_default.execute(6, new Object[] {A1EmpID, A9vendedorID});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T00058_A1EmpID[0] < A1EmpID ) || ( T00058_A1EmpID[0] == A1EmpID ) && ( T00058_A9vendedorID[0] < A9vendedorID ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T00058_A1EmpID[0] > A1EmpID ) || ( T00058_A1EmpID[0] == A1EmpID ) && ( T00058_A9vendedorID[0] > A9vendedorID ) ) )
            {
               A1EmpID = T00058_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A9vendedorID = T00058_A9vendedorID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9vendedorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A9vendedorID), 4, 0)));
               RcdFound9 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound9 = 0;
         /* Using cursor T00059 */
         pr_default.execute(7, new Object[] {A1EmpID, A9vendedorID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00059_A1EmpID[0] > A1EmpID ) || ( T00059_A1EmpID[0] == A1EmpID ) && ( T00059_A9vendedorID[0] > A9vendedorID ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00059_A1EmpID[0] < A1EmpID ) || ( T00059_A1EmpID[0] == A1EmpID ) && ( T00059_A9vendedorID[0] < A9vendedorID ) ) )
            {
               A1EmpID = T00059_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A9vendedorID = T00059_A9vendedorID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9vendedorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A9vendedorID), 4, 0)));
               RcdFound9 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey059( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert059( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound9 == 1 )
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A9vendedorID != Z9vendedorID ) )
               {
                  A1EmpID = Z1EmpID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
                  A9vendedorID = Z9vendedorID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9vendedorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A9vendedorID), 4, 0)));
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
                  Update059( ) ;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A9vendedorID != Z9vendedorID ) )
               {
                  /* Insert record */
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert059( ) ;
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
                     Insert059( ) ;
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
         if ( ( A1EmpID != Z1EmpID ) || ( A9vendedorID != Z9vendedorID ) )
         {
            A1EmpID = Z1EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A9vendedorID = Z9vendedorID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9vendedorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A9vendedorID), 4, 0)));
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

      protected void CheckOptimisticConcurrency059( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00052 */
            pr_default.execute(0, new Object[] {A1EmpID, A9vendedorID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Vendedor"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z72vendedorDsc, T00052_A72vendedorDsc[0]) != 0 ) || ( StringUtil.StrCmp(Z121VendedorSiglas, T00052_A121VendedorSiglas[0]) != 0 ) || ( StringUtil.StrCmp(Z73vendedorEst, T00052_A73vendedorEst[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z72vendedorDsc, T00052_A72vendedorDsc[0]) != 0 )
               {
                  GXUtil.WriteLog("vendedor:[seudo value changed for attri]"+"vendedorDsc");
                  GXUtil.WriteLogRaw("Old: ",Z72vendedorDsc);
                  GXUtil.WriteLogRaw("Current: ",T00052_A72vendedorDsc[0]);
               }
               if ( StringUtil.StrCmp(Z121VendedorSiglas, T00052_A121VendedorSiglas[0]) != 0 )
               {
                  GXUtil.WriteLog("vendedor:[seudo value changed for attri]"+"VendedorSiglas");
                  GXUtil.WriteLogRaw("Old: ",Z121VendedorSiglas);
                  GXUtil.WriteLogRaw("Current: ",T00052_A121VendedorSiglas[0]);
               }
               if ( StringUtil.StrCmp(Z73vendedorEst, T00052_A73vendedorEst[0]) != 0 )
               {
                  GXUtil.WriteLog("vendedor:[seudo value changed for attri]"+"vendedorEst");
                  GXUtil.WriteLogRaw("Old: ",Z73vendedorEst);
                  GXUtil.WriteLogRaw("Current: ",T00052_A73vendedorEst[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Vendedor"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert059( )
      {
         BeforeValidate059( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable059( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM059( 0) ;
            CheckOptimisticConcurrency059( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm059( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert059( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000510 */
                     pr_default.execute(8, new Object[] {A9vendedorID, n72vendedorDsc, A72vendedorDsc, n121VendedorSiglas, A121VendedorSiglas, n73vendedorEst, A73vendedorEst, A1EmpID});
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("Vendedor") ;
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
                           ResetCaption050( ) ;
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
               Load059( ) ;
            }
            EndLevel059( ) ;
         }
         CloseExtendedTableCursors059( ) ;
      }

      protected void Update059( )
      {
         BeforeValidate059( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable059( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency059( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm059( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate059( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000511 */
                     pr_default.execute(9, new Object[] {n72vendedorDsc, A72vendedorDsc, n121VendedorSiglas, A121VendedorSiglas, n73vendedorEst, A73vendedorEst, A1EmpID, A9vendedorID});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("Vendedor") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Vendedor"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate059( ) ;
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
            EndLevel059( ) ;
         }
         CloseExtendedTableCursors059( ) ;
      }

      protected void DeferredUpdate059( )
      {
      }

      protected void delete( )
      {
         BeforeValidate059( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency059( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls059( ) ;
            AfterConfirm059( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete059( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000512 */
                  pr_default.execute(10, new Object[] {A1EmpID, A9vendedorID});
                  pr_default.close(10);
                  dsDefault.SmartCacheProvider.SetUpdated("Vendedor") ;
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
         sMode9 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel059( ) ;
         Gx_mode = sMode9;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls059( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV12Pgmname = "Vendedor";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Pgmname", AV12Pgmname);
            /* Using cursor T000513 */
            pr_default.execute(11, new Object[] {A1EmpID});
            A44empdsc = T000513_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000513_n44empdsc[0];
            pr_default.close(11);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000514 */
            pr_default.execute(12, new Object[] {A1EmpID, A9vendedorID});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Orden Produccion"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(12);
         }
      }

      protected void EndLevel059( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete059( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(11);
            context.CommitDataStores("vendedor",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues050( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(11);
            context.RollbackDataStores("vendedor",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart059( )
      {
         /* Scan By routine */
         /* Using cursor T000515 */
         pr_default.execute(13);
         RcdFound9 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound9 = 1;
            A1EmpID = T000515_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A9vendedorID = T000515_A9vendedorID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9vendedorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A9vendedorID), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext059( )
      {
         /* Scan next routine */
         pr_default.readNext(13);
         RcdFound9 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound9 = 1;
            A1EmpID = T000515_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A9vendedorID = T000515_A9vendedorID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9vendedorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A9vendedorID), 4, 0)));
         }
      }

      protected void ScanEnd059( )
      {
         pr_default.close(13);
      }

      protected void AfterConfirm059( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert059( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate059( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete059( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete059( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate059( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes059( )
      {
         edtEmpID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         edtempdsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempdsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempdsc_Enabled), 5, 0)), true);
         edtvendedorID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtvendedorID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtvendedorID_Enabled), 5, 0)), true);
         edtvendedorDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtvendedorDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtvendedorDsc_Enabled), 5, 0)), true);
         edtVendedorSiglas_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVendedorSiglas_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVendedorSiglas_Enabled), 5, 0)), true);
         cmbvendedorEst.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbvendedorEst_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbvendedorEst.Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes059( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues050( )
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
         context.SendWebValue( "Vendedor") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20231141154062", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("vendedor.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7EmpID) + "," + UrlEncode("" +AV8vendedorID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "Vendedor";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("vendedor:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1EmpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z9vendedorID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z9vendedorID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z72vendedorDsc", StringUtil.RTrim( Z72vendedorDsc));
         GxWebStd.gx_hidden_field( context, "Z121VendedorSiglas", Z121VendedorSiglas);
         GxWebStd.gx_hidden_field( context, "Z73vendedorEst", StringUtil.RTrim( Z73vendedorEst));
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
         GxWebStd.gx_hidden_field( context, "vVENDEDORID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8vendedorID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vVENDEDORID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8vendedorID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV12Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void RenderHtmlCloseForm059( )
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
         return "Vendedor" ;
      }

      public override String GetPgmdesc( )
      {
         return "Vendedor" ;
      }

      protected void InitializeNonKey059( )
      {
         A44empdsc = "";
         n44empdsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         A72vendedorDsc = "";
         n72vendedorDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A72vendedorDsc", A72vendedorDsc);
         n72vendedorDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A72vendedorDsc)) ? true : false);
         A121VendedorSiglas = "";
         n121VendedorSiglas = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121VendedorSiglas", A121VendedorSiglas);
         n121VendedorSiglas = (String.IsNullOrEmpty(StringUtil.RTrim( A121VendedorSiglas)) ? true : false);
         A73vendedorEst = "";
         n73vendedorEst = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A73vendedorEst", A73vendedorEst);
         n73vendedorEst = (String.IsNullOrEmpty(StringUtil.RTrim( A73vendedorEst)) ? true : false);
         Z72vendedorDsc = "";
         Z121VendedorSiglas = "";
         Z73vendedorEst = "";
      }

      protected void InitAll059( )
      {
         A1EmpID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         A9vendedorID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9vendedorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A9vendedorID), 4, 0)));
         InitializeNonKey059( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20231141154069", true);
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
         context.AddJavascriptSource("vendedor.js", "?20231141154069", false);
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
         edtvendedorID_Internalname = "VENDEDORID";
         edtvendedorDsc_Internalname = "VENDEDORDSC";
         edtVendedorSiglas_Internalname = "VENDEDORSIGLAS";
         cmbvendedorEst_Internalname = "VENDEDOREST";
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
         cmbvendedorEst_Jsonclick = "";
         cmbvendedorEst.Enabled = 1;
         edtVendedorSiglas_Jsonclick = "";
         edtVendedorSiglas_Enabled = 1;
         edtvendedorDsc_Jsonclick = "";
         edtvendedorDsc_Enabled = 1;
         edtvendedorID_Jsonclick = "";
         edtvendedorID_Enabled = 1;
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
         cmbvendedorEst.Name = "VENDEDOREST";
         cmbvendedorEst.WebTags = "";
         cmbvendedorEst.addItem("", "Seleccionar", 0);
         cmbvendedorEst.addItem("A", "Activo", 0);
         cmbvendedorEst.addItem("I", "Inactivo", 0);
         if ( cmbvendedorEst.ItemCount > 0 )
         {
            A73vendedorEst = cmbvendedorEst.getValidValue(A73vendedorEst);
            n73vendedorEst = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A73vendedorEst", A73vendedorEst);
         }
         /* End function init_web_controls */
      }

      public void Valid_Empid( short GX_Parm1 ,
                               String GX_Parm2 )
      {
         A1EmpID = GX_Parm1;
         A44empdsc = GX_Parm2;
         n44empdsc = false;
         /* Using cursor T000513 */
         pr_default.execute(11, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(11) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A44empdsc = T000513_A44empdsc[0];
         n44empdsc = T000513_n44empdsc[0];
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV8vendedorID',fld:'vVENDEDORID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV8vendedorID',fld:'vVENDEDORID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12052',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV10TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         Z72vendedorDsc = "";
         Z121VendedorSiglas = "";
         Z73vendedorEst = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         A73vendedorEst = "";
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
         A72vendedorDsc = "";
         A121VendedorSiglas = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         AV12Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode9 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV10TrnContext = new SdtTransactionContext(context);
         AV11WebSession = context.GetSession();
         Z44empdsc = "";
         T00054_A44empdsc = new String[] {""} ;
         T00054_n44empdsc = new bool[] {false} ;
         T00055_A9vendedorID = new short[1] ;
         T00055_A44empdsc = new String[] {""} ;
         T00055_n44empdsc = new bool[] {false} ;
         T00055_A72vendedorDsc = new String[] {""} ;
         T00055_n72vendedorDsc = new bool[] {false} ;
         T00055_A121VendedorSiglas = new String[] {""} ;
         T00055_n121VendedorSiglas = new bool[] {false} ;
         T00055_A73vendedorEst = new String[] {""} ;
         T00055_n73vendedorEst = new bool[] {false} ;
         T00055_A1EmpID = new short[1] ;
         T00056_A44empdsc = new String[] {""} ;
         T00056_n44empdsc = new bool[] {false} ;
         T00057_A1EmpID = new short[1] ;
         T00057_A9vendedorID = new short[1] ;
         T00053_A9vendedorID = new short[1] ;
         T00053_A72vendedorDsc = new String[] {""} ;
         T00053_n72vendedorDsc = new bool[] {false} ;
         T00053_A121VendedorSiglas = new String[] {""} ;
         T00053_n121VendedorSiglas = new bool[] {false} ;
         T00053_A73vendedorEst = new String[] {""} ;
         T00053_n73vendedorEst = new bool[] {false} ;
         T00053_A1EmpID = new short[1] ;
         T00058_A1EmpID = new short[1] ;
         T00058_A9vendedorID = new short[1] ;
         T00059_A1EmpID = new short[1] ;
         T00059_A9vendedorID = new short[1] ;
         T00052_A9vendedorID = new short[1] ;
         T00052_A72vendedorDsc = new String[] {""} ;
         T00052_n72vendedorDsc = new bool[] {false} ;
         T00052_A121VendedorSiglas = new String[] {""} ;
         T00052_n121VendedorSiglas = new bool[] {false} ;
         T00052_A73vendedorEst = new String[] {""} ;
         T00052_n73vendedorEst = new bool[] {false} ;
         T00052_A1EmpID = new short[1] ;
         T000513_A44empdsc = new String[] {""} ;
         T000513_n44empdsc = new bool[] {false} ;
         T000514_A1EmpID = new short[1] ;
         T000514_A5ClienteID = new short[1] ;
         T000514_A24OrdenPeriodo = new short[1] ;
         T000514_A25OrdenAnio = new short[1] ;
         T000514_A22OrdenID = new short[1] ;
         T000515_A1EmpID = new short[1] ;
         T000515_A9vendedorID = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.vendedor__default(),
            new Object[][] {
                new Object[] {
               T00052_A9vendedorID, T00052_A72vendedorDsc, T00052_n72vendedorDsc, T00052_A121VendedorSiglas, T00052_n121VendedorSiglas, T00052_A73vendedorEst, T00052_n73vendedorEst, T00052_A1EmpID
               }
               , new Object[] {
               T00053_A9vendedorID, T00053_A72vendedorDsc, T00053_n72vendedorDsc, T00053_A121VendedorSiglas, T00053_n121VendedorSiglas, T00053_A73vendedorEst, T00053_n73vendedorEst, T00053_A1EmpID
               }
               , new Object[] {
               T00054_A44empdsc, T00054_n44empdsc
               }
               , new Object[] {
               T00055_A9vendedorID, T00055_A44empdsc, T00055_n44empdsc, T00055_A72vendedorDsc, T00055_n72vendedorDsc, T00055_A121VendedorSiglas, T00055_n121VendedorSiglas, T00055_A73vendedorEst, T00055_n73vendedorEst, T00055_A1EmpID
               }
               , new Object[] {
               T00056_A44empdsc, T00056_n44empdsc
               }
               , new Object[] {
               T00057_A1EmpID, T00057_A9vendedorID
               }
               , new Object[] {
               T00058_A1EmpID, T00058_A9vendedorID
               }
               , new Object[] {
               T00059_A1EmpID, T00059_A9vendedorID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000513_A44empdsc, T000513_n44empdsc
               }
               , new Object[] {
               T000514_A1EmpID, T000514_A5ClienteID, T000514_A24OrdenPeriodo, T000514_A25OrdenAnio, T000514_A22OrdenID
               }
               , new Object[] {
               T000515_A1EmpID, T000515_A9vendedorID
               }
            }
         );
         AV12Pgmname = "Vendedor";
      }

      private short wcpOAV7EmpID ;
      private short wcpOAV8vendedorID ;
      private short Z1EmpID ;
      private short Z9vendedorID ;
      private short GxWebError ;
      private short A1EmpID ;
      private short AV7EmpID ;
      private short AV8vendedorID ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short A9vendedorID ;
      private short RcdFound9 ;
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
      private int edtvendedorID_Enabled ;
      private int edtvendedorDsc_Enabled ;
      private int edtVendedorSiglas_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z72vendedorDsc ;
      private String Z73vendedorEst ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtEmpID_Internalname ;
      private String A73vendedorEst ;
      private String cmbvendedorEst_Internalname ;
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
      private String edtvendedorID_Internalname ;
      private String edtvendedorID_Jsonclick ;
      private String edtvendedorDsc_Internalname ;
      private String A72vendedorDsc ;
      private String edtvendedorDsc_Jsonclick ;
      private String edtVendedorSiglas_Internalname ;
      private String edtVendedorSiglas_Jsonclick ;
      private String cmbvendedorEst_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String AV12Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode9 ;
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
      private bool n73vendedorEst ;
      private bool n44empdsc ;
      private bool n72vendedorDsc ;
      private bool n121VendedorSiglas ;
      private bool returnInSub ;
      private String Z121VendedorSiglas ;
      private String A44empdsc ;
      private String A121VendedorSiglas ;
      private String Z44empdsc ;
      private IGxSession AV11WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbvendedorEst ;
      private IDataStoreProvider pr_default ;
      private String[] T00054_A44empdsc ;
      private bool[] T00054_n44empdsc ;
      private short[] T00055_A9vendedorID ;
      private String[] T00055_A44empdsc ;
      private bool[] T00055_n44empdsc ;
      private String[] T00055_A72vendedorDsc ;
      private bool[] T00055_n72vendedorDsc ;
      private String[] T00055_A121VendedorSiglas ;
      private bool[] T00055_n121VendedorSiglas ;
      private String[] T00055_A73vendedorEst ;
      private bool[] T00055_n73vendedorEst ;
      private short[] T00055_A1EmpID ;
      private String[] T00056_A44empdsc ;
      private bool[] T00056_n44empdsc ;
      private short[] T00057_A1EmpID ;
      private short[] T00057_A9vendedorID ;
      private short[] T00053_A9vendedorID ;
      private String[] T00053_A72vendedorDsc ;
      private bool[] T00053_n72vendedorDsc ;
      private String[] T00053_A121VendedorSiglas ;
      private bool[] T00053_n121VendedorSiglas ;
      private String[] T00053_A73vendedorEst ;
      private bool[] T00053_n73vendedorEst ;
      private short[] T00053_A1EmpID ;
      private short[] T00058_A1EmpID ;
      private short[] T00058_A9vendedorID ;
      private short[] T00059_A1EmpID ;
      private short[] T00059_A9vendedorID ;
      private short[] T00052_A9vendedorID ;
      private String[] T00052_A72vendedorDsc ;
      private bool[] T00052_n72vendedorDsc ;
      private String[] T00052_A121VendedorSiglas ;
      private bool[] T00052_n121VendedorSiglas ;
      private String[] T00052_A73vendedorEst ;
      private bool[] T00052_n73vendedorEst ;
      private short[] T00052_A1EmpID ;
      private String[] T000513_A44empdsc ;
      private bool[] T000513_n44empdsc ;
      private short[] T000514_A1EmpID ;
      private short[] T000514_A5ClienteID ;
      private short[] T000514_A24OrdenPeriodo ;
      private short[] T000514_A25OrdenAnio ;
      private short[] T000514_A22OrdenID ;
      private short[] T000515_A1EmpID ;
      private short[] T000515_A9vendedorID ;
      private SdtTransactionContext AV10TrnContext ;
   }

   public class vendedor__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00055 ;
          prmT00055 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@vendedorID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00054 ;
          prmT00054 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00056 ;
          prmT00056 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00057 ;
          prmT00057 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@vendedorID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00053 ;
          prmT00053 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@vendedorID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00058 ;
          prmT00058 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@vendedorID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00059 ;
          prmT00059 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@vendedorID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00052 ;
          prmT00052 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@vendedorID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000510 ;
          prmT000510 = new Object[] {
          new Object[] {"@vendedorID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@vendedorDsc",SqlDbType.Char,50,0} ,
          new Object[] {"@VendedorSiglas",SqlDbType.VarChar,5,0} ,
          new Object[] {"@vendedorEst",SqlDbType.Char,1,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000511 ;
          prmT000511 = new Object[] {
          new Object[] {"@vendedorDsc",SqlDbType.Char,50,0} ,
          new Object[] {"@VendedorSiglas",SqlDbType.VarChar,5,0} ,
          new Object[] {"@vendedorEst",SqlDbType.Char,1,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@vendedorID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000512 ;
          prmT000512 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@vendedorID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000514 ;
          prmT000514 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@vendedorID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000515 ;
          prmT000515 = new Object[] {
          } ;
          Object[] prmT000513 ;
          prmT000513 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00052", "SELECT [vendedorID], [vendedorDsc], [VendedorSiglas], [vendedorEst], [EmpID] FROM [Vendedor] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [vendedorID] = @vendedorID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00052,1,0,true,false )
             ,new CursorDef("T00053", "SELECT [vendedorID], [vendedorDsc], [VendedorSiglas], [vendedorEst], [EmpID] FROM [Vendedor] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [vendedorID] = @vendedorID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00053,1,0,true,false )
             ,new CursorDef("T00054", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00054,1,0,true,false )
             ,new CursorDef("T00055", "SELECT TM1.[vendedorID], T2.[empdsc], TM1.[vendedorDsc], TM1.[VendedorSiglas], TM1.[vendedorEst], TM1.[EmpID] FROM ([Vendedor] TM1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = TM1.[EmpID]) WHERE TM1.[EmpID] = @EmpID and TM1.[vendedorID] = @vendedorID ORDER BY TM1.[EmpID], TM1.[vendedorID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00055,100,0,true,false )
             ,new CursorDef("T00056", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00056,1,0,true,false )
             ,new CursorDef("T00057", "SELECT [EmpID], [vendedorID] FROM [Vendedor] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [vendedorID] = @vendedorID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00057,1,0,true,false )
             ,new CursorDef("T00058", "SELECT TOP 1 [EmpID], [vendedorID] FROM [Vendedor] WITH (NOLOCK) WHERE ( [EmpID] > @EmpID or [EmpID] = @EmpID and [vendedorID] > @vendedorID) ORDER BY [EmpID], [vendedorID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00058,1,0,true,true )
             ,new CursorDef("T00059", "SELECT TOP 1 [EmpID], [vendedorID] FROM [Vendedor] WITH (NOLOCK) WHERE ( [EmpID] < @EmpID or [EmpID] = @EmpID and [vendedorID] < @vendedorID) ORDER BY [EmpID] DESC, [vendedorID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00059,1,0,true,true )
             ,new CursorDef("T000510", "INSERT INTO [Vendedor]([vendedorID], [vendedorDsc], [VendedorSiglas], [vendedorEst], [EmpID]) VALUES(@vendedorID, @vendedorDsc, @VendedorSiglas, @vendedorEst, @EmpID)", GxErrorMask.GX_NOMASK,prmT000510)
             ,new CursorDef("T000511", "UPDATE [Vendedor] SET [vendedorDsc]=@vendedorDsc, [VendedorSiglas]=@VendedorSiglas, [vendedorEst]=@vendedorEst  WHERE [EmpID] = @EmpID AND [vendedorID] = @vendedorID", GxErrorMask.GX_NOMASK,prmT000511)
             ,new CursorDef("T000512", "DELETE FROM [Vendedor]  WHERE [EmpID] = @EmpID AND [vendedorID] = @vendedorID", GxErrorMask.GX_NOMASK,prmT000512)
             ,new CursorDef("T000513", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000513,1,0,true,false )
             ,new CursorDef("T000514", "SELECT TOP 1 [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID] FROM [OrdenProduccion] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [vendedorID] = @vendedorID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000514,1,0,true,true )
             ,new CursorDef("T000515", "SELECT [EmpID], [vendedorID] FROM [Vendedor] WITH (NOLOCK) ORDER BY [EmpID], [vendedorID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000515,100,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 1) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 1) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 1) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
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
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 13 :
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
                   stmt.setNull( 3 , SqlDbType.VarChar );
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
                stmt.SetParameter(5, (short)parms[7]);
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
                   stmt.setNull( 2 , SqlDbType.VarChar );
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
                stmt.SetParameter(4, (short)parms[6]);
                stmt.SetParameter(5, (short)parms[7]);
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
       }
    }

 }

}
