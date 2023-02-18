/*
               File: Clientes
        Description: Clientes
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/19/2023 22:34:11.33
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
   public class clientes : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel6"+"_"+"CLIENTEID") == 0 )
         {
            AV8ClienteID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8ClienteID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vCLIENTEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8ClienteID), "ZZZ9"), context));
            AV7EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7EmpID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EmpID), "ZZZ9"), context));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX6ASACLIENTEID035( AV8ClienteID, AV7EmpID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_14") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_14( A1EmpID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_15") == 0 )
         {
            A4TipClientID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4TipClientID", StringUtil.LTrim( StringUtil.Str( (decimal)(A4TipClientID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_15( A4TipClientID) ;
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
               AV8ClienteID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8ClienteID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vCLIENTEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8ClienteID), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Clientes", 0) ;
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

      public clientes( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public clientes( IGxContext context )
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
                           short aP2_ClienteID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7EmpID = aP1_EmpID;
         this.AV8ClienteID = aP2_ClienteID;
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Clientes", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Clientes.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Clientes.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Clientes.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Clientes.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Clientes.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0050.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"CLIENTEID"+"'), id:'"+"CLIENTEID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_Clientes.htm");
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
            GxWebStd.gx_single_line_edit( context, edtEmpID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEmpID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEmpID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Clientes.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_1_Internalname, sImgUrl, imgprompt_1_Link, "", "", context.GetTheme( ), imgprompt_1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Clientes.htm");
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
            GxWebStd.gx_single_line_edit( context, edtempdsc_Internalname, A44empdsc, StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempdsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtempdsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Clientes.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtClienteID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtClienteID_Internalname, "ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtClienteID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A5ClienteID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A5ClienteID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtClienteID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtClienteID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Clientes.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtClienteRUC_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtClienteRUC_Internalname, "CI", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtClienteRUC_Internalname, StringUtil.RTrim( A56ClienteRUC), StringUtil.RTrim( context.localUtil.Format( A56ClienteRUC, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtClienteRUC_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtClienteRUC_Enabled, 0, "text", "", 13, "chr", 1, "row", 13, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Clientes.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtClienteDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtClienteDsc_Internalname, "Razon Social", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtClienteDsc_Internalname, StringUtil.RTrim( A57ClienteDsc), StringUtil.RTrim( context.localUtil.Format( A57ClienteDsc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtClienteDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtClienteDsc_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "Descripcion", "left", true, "HLP_Clientes.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtTipClientID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtTipClientID_Internalname, "Codigo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtTipClientID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A4TipClientID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A4TipClientID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtTipClientID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtTipClientID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Clientes.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_4_Internalname, sImgUrl, imgprompt_4_Link, "", "", context.GetTheme( ), imgprompt_4_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Clientes.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtTipClientDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtTipClientDsc_Internalname, "Tipo Cliente", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtTipClientDsc_Internalname, StringUtil.RTrim( A54TipClientDsc), StringUtil.RTrim( context.localUtil.Format( A54TipClientDsc, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtTipClientDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtTipClientDsc_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "Descripcion", "left", true, "HLP_Clientes.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtClienteTelf_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtClienteTelf_Internalname, "Telf", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtClienteTelf_Internalname, A58ClienteTelf, StringUtil.RTrim( context.localUtil.Format( A58ClienteTelf, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,69);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtClienteTelf_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtClienteTelf_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Clientes.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtClienteEst_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtClienteEst_Internalname, "Est", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtClienteEst_Internalname, StringUtil.RTrim( A59ClienteEst), StringUtil.RTrim( context.localUtil.Format( A59ClienteEst, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,74);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtClienteEst_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtClienteEst_Enabled, 0, "text", "", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, -1, true, "estado", "left", true, "HLP_Clientes.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtClienteDir_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtClienteDir_Internalname, "Direccion", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 79,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtClienteDir_Internalname, A60ClienteDir, StringUtil.RTrim( context.localUtil.Format( A60ClienteDir, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,79);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtClienteDir_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtClienteDir_Enabled, 0, "text", "", 80, "chr", 1, "row", 80, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Clientes.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtClienteEmail_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtClienteEmail_Internalname, "Email", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 84,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtClienteEmail_Internalname, A61ClienteEmail, StringUtil.RTrim( context.localUtil.Format( A61ClienteEmail, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,84);\"", "'"+""+"'"+",false,"+"'"+""+"'", "mailto:"+A61ClienteEmail, "", "", "", edtClienteEmail_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtClienteEmail_Enabled, 0, "email", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, 0, true, "GeneXus\\Email", "left", true, "HLP_Clientes.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 89,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Clientes.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Clientes.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Clientes.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm035( ) ;
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
         E11032 ();
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtClienteID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtClienteID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CLIENTEID");
                  AnyError = 1;
                  GX_FocusControl = edtClienteID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A5ClienteID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
               }
               else
               {
                  A5ClienteID = (short)(context.localUtil.CToN( cgiGet( edtClienteID_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
               }
               A56ClienteRUC = cgiGet( edtClienteRUC_Internalname);
               n56ClienteRUC = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56ClienteRUC", A56ClienteRUC);
               n56ClienteRUC = (String.IsNullOrEmpty(StringUtil.RTrim( A56ClienteRUC)) ? true : false);
               A57ClienteDsc = cgiGet( edtClienteDsc_Internalname);
               n57ClienteDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A57ClienteDsc", A57ClienteDsc);
               n57ClienteDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A57ClienteDsc)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtTipClientID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtTipClientID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "TIPCLIENTID");
                  AnyError = 1;
                  GX_FocusControl = edtTipClientID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A4TipClientID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4TipClientID", StringUtil.LTrim( StringUtil.Str( (decimal)(A4TipClientID), 4, 0)));
               }
               else
               {
                  A4TipClientID = (short)(context.localUtil.CToN( cgiGet( edtTipClientID_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4TipClientID", StringUtil.LTrim( StringUtil.Str( (decimal)(A4TipClientID), 4, 0)));
               }
               A54TipClientDsc = cgiGet( edtTipClientDsc_Internalname);
               n54TipClientDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54TipClientDsc", A54TipClientDsc);
               A58ClienteTelf = cgiGet( edtClienteTelf_Internalname);
               n58ClienteTelf = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58ClienteTelf", A58ClienteTelf);
               n58ClienteTelf = (String.IsNullOrEmpty(StringUtil.RTrim( A58ClienteTelf)) ? true : false);
               A59ClienteEst = cgiGet( edtClienteEst_Internalname);
               n59ClienteEst = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59ClienteEst", A59ClienteEst);
               n59ClienteEst = (String.IsNullOrEmpty(StringUtil.RTrim( A59ClienteEst)) ? true : false);
               A60ClienteDir = cgiGet( edtClienteDir_Internalname);
               n60ClienteDir = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60ClienteDir", A60ClienteDir);
               n60ClienteDir = (String.IsNullOrEmpty(StringUtil.RTrim( A60ClienteDir)) ? true : false);
               A61ClienteEmail = cgiGet( edtClienteEmail_Internalname);
               n61ClienteEmail = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61ClienteEmail", A61ClienteEmail);
               n61ClienteEmail = (String.IsNullOrEmpty(StringUtil.RTrim( A61ClienteEmail)) ? true : false);
               /* Read saved values. */
               Z1EmpID = (short)(context.localUtil.CToN( cgiGet( "Z1EmpID"), ",", "."));
               Z5ClienteID = (short)(context.localUtil.CToN( cgiGet( "Z5ClienteID"), ",", "."));
               Z56ClienteRUC = cgiGet( "Z56ClienteRUC");
               n56ClienteRUC = (String.IsNullOrEmpty(StringUtil.RTrim( A56ClienteRUC)) ? true : false);
               Z57ClienteDsc = cgiGet( "Z57ClienteDsc");
               n57ClienteDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A57ClienteDsc)) ? true : false);
               Z58ClienteTelf = cgiGet( "Z58ClienteTelf");
               n58ClienteTelf = (String.IsNullOrEmpty(StringUtil.RTrim( A58ClienteTelf)) ? true : false);
               Z59ClienteEst = cgiGet( "Z59ClienteEst");
               n59ClienteEst = (String.IsNullOrEmpty(StringUtil.RTrim( A59ClienteEst)) ? true : false);
               Z60ClienteDir = cgiGet( "Z60ClienteDir");
               n60ClienteDir = (String.IsNullOrEmpty(StringUtil.RTrim( A60ClienteDir)) ? true : false);
               Z61ClienteEmail = cgiGet( "Z61ClienteEmail");
               n61ClienteEmail = (String.IsNullOrEmpty(StringUtil.RTrim( A61ClienteEmail)) ? true : false);
               Z4TipClientID = (short)(context.localUtil.CToN( cgiGet( "Z4TipClientID"), ",", "."));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               N4TipClientID = (short)(context.localUtil.CToN( cgiGet( "N4TipClientID"), ",", "."));
               AV7EmpID = (short)(context.localUtil.CToN( cgiGet( "vEMPID"), ",", "."));
               AV8ClienteID = (short)(context.localUtil.CToN( cgiGet( "vCLIENTEID"), ",", "."));
               AV12Insert_TipClientID = (short)(context.localUtil.CToN( cgiGet( "vINSERT_TIPCLIENTID"), ",", "."));
               AV14Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Clientes";
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV12Insert_TipClientID), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A1EmpID != Z1EmpID ) || ( A5ClienteID != Z5ClienteID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("clientes:[SecurityCheckFailed value for]"+"Insert_TipClientID:"+context.localUtil.Format( (decimal)(AV12Insert_TipClientID), "ZZZ9"));
                  GXUtil.WriteLog("clientes:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A5ClienteID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
                  getEqualNoModal( ) ;
                  if ( ! (0==AV8ClienteID) )
                  {
                     A5ClienteID = AV8ClienteID;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
                  }
                  else
                  {
                     if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
                     {
                        GXt_int1 = A5ClienteID;
                        new obtultcodcliente(context ).execute(  AV7EmpID, out  GXt_int1) ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7EmpID), 4, 0)));
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EmpID), "ZZZ9"), context));
                        A5ClienteID = GXt_int1;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
                     }
                  }
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
                     sMode5 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     if ( ! (0==AV8ClienteID) )
                     {
                        A5ClienteID = AV8ClienteID;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
                     }
                     else
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
                        {
                           GXt_int1 = A5ClienteID;
                           new obtultcodcliente(context ).execute(  AV7EmpID, out  GXt_int1) ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7EmpID), 4, 0)));
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EmpID), "ZZZ9"), context));
                           A5ClienteID = GXt_int1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
                        }
                     }
                     Gx_mode = sMode5;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound5 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_030( ) ;
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
                        E11032 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: After Trn */
                        E12032 ();
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
            E12032 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll035( ) ;
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
            DisableAttributes035( ) ;
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

      protected void CONFIRM_030( )
      {
         BeforeValidate035( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls035( ) ;
            }
            else
            {
               CheckExtendedTable035( ) ;
               CloseExtendedTableCursors035( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption030( )
      {
      }

      protected void E11032( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV14Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV14Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV10TrnContext.FromXml(AV11WebSession.Get("TrnContext"), null, "TransactionContext", "KBCalpesa22");
         AV12Insert_TipClientID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Insert_TipClientID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12Insert_TipClientID), 4, 0)));
         if ( ( StringUtil.StrCmp(AV10TrnContext.gxTpr_Transactionname, AV14Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV15GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15GXV1), 8, 0)));
            while ( AV15GXV1 <= AV10TrnContext.gxTpr_Attributes.Count )
            {
               AV13TrnContextAtt = ((SdtTransactionContext_Attribute)AV10TrnContext.gxTpr_Attributes.Item(AV15GXV1));
               if ( StringUtil.StrCmp(AV13TrnContextAtt.gxTpr_Attributename, "TipClientID") == 0 )
               {
                  AV12Insert_TipClientID = (short)(NumberUtil.Val( AV13TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Insert_TipClientID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12Insert_TipClientID), 4, 0)));
               }
               AV15GXV1 = (int)(AV15GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15GXV1), 8, 0)));
            }
         }
      }

      protected void E12032( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV10TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwclientes.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM035( short GX_JID )
      {
         if ( ( GX_JID == 13 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z56ClienteRUC = T00033_A56ClienteRUC[0];
               Z57ClienteDsc = T00033_A57ClienteDsc[0];
               Z58ClienteTelf = T00033_A58ClienteTelf[0];
               Z59ClienteEst = T00033_A59ClienteEst[0];
               Z60ClienteDir = T00033_A60ClienteDir[0];
               Z61ClienteEmail = T00033_A61ClienteEmail[0];
               Z4TipClientID = T00033_A4TipClientID[0];
            }
            else
            {
               Z56ClienteRUC = A56ClienteRUC;
               Z57ClienteDsc = A57ClienteDsc;
               Z58ClienteTelf = A58ClienteTelf;
               Z59ClienteEst = A59ClienteEst;
               Z60ClienteDir = A60ClienteDir;
               Z61ClienteEmail = A61ClienteEmail;
               Z4TipClientID = A4TipClientID;
            }
         }
         if ( GX_JID == -13 )
         {
            Z5ClienteID = A5ClienteID;
            Z56ClienteRUC = A56ClienteRUC;
            Z57ClienteDsc = A57ClienteDsc;
            Z58ClienteTelf = A58ClienteTelf;
            Z59ClienteEst = A59ClienteEst;
            Z60ClienteDir = A60ClienteDir;
            Z61ClienteEmail = A61ClienteEmail;
            Z1EmpID = A1EmpID;
            Z4TipClientID = A4TipClientID;
            Z44empdsc = A44empdsc;
            Z54TipClientDsc = A54TipClientDsc;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_1_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_4_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0040.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TIPCLIENTID"+"'), id:'"+"TIPCLIENTID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
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
         if ( ! (0==AV8ClienteID) )
         {
            edtClienteID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteID_Enabled), 5, 0)), true);
         }
         else
         {
            edtClienteID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV8ClienteID) )
         {
            edtClienteID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteID_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV12Insert_TipClientID) )
         {
            edtTipClientID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipClientID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipClientID_Enabled), 5, 0)), true);
         }
         else
         {
            edtTipClientID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipClientID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipClientID_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV12Insert_TipClientID) )
         {
            A4TipClientID = AV12Insert_TipClientID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4TipClientID", StringUtil.LTrim( StringUtil.Str( (decimal)(A4TipClientID), 4, 0)));
         }
         if ( ! (0==AV8ClienteID) )
         {
            A5ClienteID = AV8ClienteID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               GXt_int1 = A5ClienteID;
               new obtultcodcliente(context ).execute(  AV7EmpID, out  GXt_int1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7EmpID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EmpID), "ZZZ9"), context));
               A5ClienteID = GXt_int1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
            }
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            /* Using cursor T00034 */
            pr_default.execute(2, new Object[] {A1EmpID});
            A44empdsc = T00034_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T00034_n44empdsc[0];
            pr_default.close(2);
            AV14Pgmname = "Clientes";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
            /* Using cursor T00035 */
            pr_default.execute(3, new Object[] {A4TipClientID});
            A54TipClientDsc = T00035_A54TipClientDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54TipClientDsc", A54TipClientDsc);
            n54TipClientDsc = T00035_n54TipClientDsc[0];
            pr_default.close(3);
         }
      }

      protected void Load035( )
      {
         /* Using cursor T00036 */
         pr_default.execute(4, new Object[] {A1EmpID, A5ClienteID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound5 = 1;
            A44empdsc = T00036_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T00036_n44empdsc[0];
            A56ClienteRUC = T00036_A56ClienteRUC[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56ClienteRUC", A56ClienteRUC);
            n56ClienteRUC = T00036_n56ClienteRUC[0];
            A57ClienteDsc = T00036_A57ClienteDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A57ClienteDsc", A57ClienteDsc);
            n57ClienteDsc = T00036_n57ClienteDsc[0];
            A54TipClientDsc = T00036_A54TipClientDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54TipClientDsc", A54TipClientDsc);
            n54TipClientDsc = T00036_n54TipClientDsc[0];
            A58ClienteTelf = T00036_A58ClienteTelf[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58ClienteTelf", A58ClienteTelf);
            n58ClienteTelf = T00036_n58ClienteTelf[0];
            A59ClienteEst = T00036_A59ClienteEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59ClienteEst", A59ClienteEst);
            n59ClienteEst = T00036_n59ClienteEst[0];
            A60ClienteDir = T00036_A60ClienteDir[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60ClienteDir", A60ClienteDir);
            n60ClienteDir = T00036_n60ClienteDir[0];
            A61ClienteEmail = T00036_A61ClienteEmail[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61ClienteEmail", A61ClienteEmail);
            n61ClienteEmail = T00036_n61ClienteEmail[0];
            A4TipClientID = T00036_A4TipClientID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4TipClientID", StringUtil.LTrim( StringUtil.Str( (decimal)(A4TipClientID), 4, 0)));
            ZM035( -13) ;
         }
         pr_default.close(4);
         OnLoadActions035( ) ;
      }

      protected void OnLoadActions035( )
      {
         AV14Pgmname = "Clientes";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
      }

      protected void CheckExtendedTable035( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV14Pgmname = "Clientes";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
         /* Using cursor T00034 */
         pr_default.execute(2, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T00034_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T00034_n44empdsc[0];
         pr_default.close(2);
         /* Using cursor T00035 */
         pr_default.execute(3, new Object[] {A4TipClientID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Cliente'.", "ForeignKeyNotFound", 1, "TIPCLIENTID");
            AnyError = 1;
            GX_FocusControl = edtTipClientID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A54TipClientDsc = T00035_A54TipClientDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54TipClientDsc", A54TipClientDsc);
         n54TipClientDsc = T00035_n54TipClientDsc[0];
         pr_default.close(3);
         if ( ! ( GxRegex.IsMatch(A61ClienteEmail,"^((\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*)|(\\s*))$") || String.IsNullOrEmpty(StringUtil.RTrim( A61ClienteEmail)) ) )
         {
            GX_msglist.addItem("El valor de Email no coincide con el patrón especificado", "OutOfRange", 1, "CLIENTEEMAIL");
            AnyError = 1;
            GX_FocusControl = edtClienteEmail_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors035( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_14( short A1EmpID )
      {
         /* Using cursor T00037 */
         pr_default.execute(5, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T00037_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T00037_n44empdsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A44empdsc)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(5) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(5);
      }

      protected void gxLoad_15( short A4TipClientID )
      {
         /* Using cursor T00038 */
         pr_default.execute(6, new Object[] {A4TipClientID});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Cliente'.", "ForeignKeyNotFound", 1, "TIPCLIENTID");
            AnyError = 1;
            GX_FocusControl = edtTipClientID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A54TipClientDsc = T00038_A54TipClientDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54TipClientDsc", A54TipClientDsc);
         n54TipClientDsc = T00038_n54TipClientDsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A54TipClientDsc))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(6);
      }

      protected void GetKey035( )
      {
         /* Using cursor T00039 */
         pr_default.execute(7, new Object[] {A1EmpID, A5ClienteID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound5 = 1;
         }
         else
         {
            RcdFound5 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00033 */
         pr_default.execute(1, new Object[] {A1EmpID, A5ClienteID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM035( 13) ;
            RcdFound5 = 1;
            A5ClienteID = T00033_A5ClienteID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
            A56ClienteRUC = T00033_A56ClienteRUC[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56ClienteRUC", A56ClienteRUC);
            n56ClienteRUC = T00033_n56ClienteRUC[0];
            A57ClienteDsc = T00033_A57ClienteDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A57ClienteDsc", A57ClienteDsc);
            n57ClienteDsc = T00033_n57ClienteDsc[0];
            A58ClienteTelf = T00033_A58ClienteTelf[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58ClienteTelf", A58ClienteTelf);
            n58ClienteTelf = T00033_n58ClienteTelf[0];
            A59ClienteEst = T00033_A59ClienteEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59ClienteEst", A59ClienteEst);
            n59ClienteEst = T00033_n59ClienteEst[0];
            A60ClienteDir = T00033_A60ClienteDir[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60ClienteDir", A60ClienteDir);
            n60ClienteDir = T00033_n60ClienteDir[0];
            A61ClienteEmail = T00033_A61ClienteEmail[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61ClienteEmail", A61ClienteEmail);
            n61ClienteEmail = T00033_n61ClienteEmail[0];
            A1EmpID = T00033_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A4TipClientID = T00033_A4TipClientID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4TipClientID", StringUtil.LTrim( StringUtil.Str( (decimal)(A4TipClientID), 4, 0)));
            Z1EmpID = A1EmpID;
            Z5ClienteID = A5ClienteID;
            sMode5 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load035( ) ;
            if ( AnyError == 1 )
            {
               RcdFound5 = 0;
               InitializeNonKey035( ) ;
            }
            Gx_mode = sMode5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound5 = 0;
            InitializeNonKey035( ) ;
            sMode5 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey035( ) ;
         if ( RcdFound5 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound5 = 0;
         /* Using cursor T000310 */
         pr_default.execute(8, new Object[] {A1EmpID, A5ClienteID});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000310_A1EmpID[0] < A1EmpID ) || ( T000310_A1EmpID[0] == A1EmpID ) && ( T000310_A5ClienteID[0] < A5ClienteID ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000310_A1EmpID[0] > A1EmpID ) || ( T000310_A1EmpID[0] == A1EmpID ) && ( T000310_A5ClienteID[0] > A5ClienteID ) ) )
            {
               A1EmpID = T000310_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A5ClienteID = T000310_A5ClienteID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
               RcdFound5 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound5 = 0;
         /* Using cursor T000311 */
         pr_default.execute(9, new Object[] {A1EmpID, A5ClienteID});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000311_A1EmpID[0] > A1EmpID ) || ( T000311_A1EmpID[0] == A1EmpID ) && ( T000311_A5ClienteID[0] > A5ClienteID ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000311_A1EmpID[0] < A1EmpID ) || ( T000311_A1EmpID[0] == A1EmpID ) && ( T000311_A5ClienteID[0] < A5ClienteID ) ) )
            {
               A1EmpID = T000311_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A5ClienteID = T000311_A5ClienteID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
               RcdFound5 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey035( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert035( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound5 == 1 )
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A5ClienteID != Z5ClienteID ) )
               {
                  A1EmpID = Z1EmpID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
                  A5ClienteID = Z5ClienteID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
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
                  Update035( ) ;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A5ClienteID != Z5ClienteID ) )
               {
                  /* Insert record */
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert035( ) ;
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
                     Insert035( ) ;
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
         if ( ( A1EmpID != Z1EmpID ) || ( A5ClienteID != Z5ClienteID ) )
         {
            A1EmpID = Z1EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A5ClienteID = Z5ClienteID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
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

      protected void CheckOptimisticConcurrency035( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00032 */
            pr_default.execute(0, new Object[] {A1EmpID, A5ClienteID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Clientes"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z56ClienteRUC, T00032_A56ClienteRUC[0]) != 0 ) || ( StringUtil.StrCmp(Z57ClienteDsc, T00032_A57ClienteDsc[0]) != 0 ) || ( StringUtil.StrCmp(Z58ClienteTelf, T00032_A58ClienteTelf[0]) != 0 ) || ( StringUtil.StrCmp(Z59ClienteEst, T00032_A59ClienteEst[0]) != 0 ) || ( StringUtil.StrCmp(Z60ClienteDir, T00032_A60ClienteDir[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z61ClienteEmail, T00032_A61ClienteEmail[0]) != 0 ) || ( Z4TipClientID != T00032_A4TipClientID[0] ) )
            {
               if ( StringUtil.StrCmp(Z56ClienteRUC, T00032_A56ClienteRUC[0]) != 0 )
               {
                  GXUtil.WriteLog("clientes:[seudo value changed for attri]"+"ClienteRUC");
                  GXUtil.WriteLogRaw("Old: ",Z56ClienteRUC);
                  GXUtil.WriteLogRaw("Current: ",T00032_A56ClienteRUC[0]);
               }
               if ( StringUtil.StrCmp(Z57ClienteDsc, T00032_A57ClienteDsc[0]) != 0 )
               {
                  GXUtil.WriteLog("clientes:[seudo value changed for attri]"+"ClienteDsc");
                  GXUtil.WriteLogRaw("Old: ",Z57ClienteDsc);
                  GXUtil.WriteLogRaw("Current: ",T00032_A57ClienteDsc[0]);
               }
               if ( StringUtil.StrCmp(Z58ClienteTelf, T00032_A58ClienteTelf[0]) != 0 )
               {
                  GXUtil.WriteLog("clientes:[seudo value changed for attri]"+"ClienteTelf");
                  GXUtil.WriteLogRaw("Old: ",Z58ClienteTelf);
                  GXUtil.WriteLogRaw("Current: ",T00032_A58ClienteTelf[0]);
               }
               if ( StringUtil.StrCmp(Z59ClienteEst, T00032_A59ClienteEst[0]) != 0 )
               {
                  GXUtil.WriteLog("clientes:[seudo value changed for attri]"+"ClienteEst");
                  GXUtil.WriteLogRaw("Old: ",Z59ClienteEst);
                  GXUtil.WriteLogRaw("Current: ",T00032_A59ClienteEst[0]);
               }
               if ( StringUtil.StrCmp(Z60ClienteDir, T00032_A60ClienteDir[0]) != 0 )
               {
                  GXUtil.WriteLog("clientes:[seudo value changed for attri]"+"ClienteDir");
                  GXUtil.WriteLogRaw("Old: ",Z60ClienteDir);
                  GXUtil.WriteLogRaw("Current: ",T00032_A60ClienteDir[0]);
               }
               if ( StringUtil.StrCmp(Z61ClienteEmail, T00032_A61ClienteEmail[0]) != 0 )
               {
                  GXUtil.WriteLog("clientes:[seudo value changed for attri]"+"ClienteEmail");
                  GXUtil.WriteLogRaw("Old: ",Z61ClienteEmail);
                  GXUtil.WriteLogRaw("Current: ",T00032_A61ClienteEmail[0]);
               }
               if ( Z4TipClientID != T00032_A4TipClientID[0] )
               {
                  GXUtil.WriteLog("clientes:[seudo value changed for attri]"+"TipClientID");
                  GXUtil.WriteLogRaw("Old: ",Z4TipClientID);
                  GXUtil.WriteLogRaw("Current: ",T00032_A4TipClientID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Clientes"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert035( )
      {
         BeforeValidate035( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable035( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM035( 0) ;
            CheckOptimisticConcurrency035( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm035( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert035( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000312 */
                     pr_default.execute(10, new Object[] {A5ClienteID, n56ClienteRUC, A56ClienteRUC, n57ClienteDsc, A57ClienteDsc, n58ClienteTelf, A58ClienteTelf, n59ClienteEst, A59ClienteEst, n60ClienteDir, A60ClienteDir, n61ClienteEmail, A61ClienteEmail, A1EmpID, A4TipClientID});
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("Clientes") ;
                     if ( (pr_default.getStatus(10) == 1) )
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
                           ResetCaption030( ) ;
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
               Load035( ) ;
            }
            EndLevel035( ) ;
         }
         CloseExtendedTableCursors035( ) ;
      }

      protected void Update035( )
      {
         BeforeValidate035( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable035( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency035( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm035( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate035( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000313 */
                     pr_default.execute(11, new Object[] {n56ClienteRUC, A56ClienteRUC, n57ClienteDsc, A57ClienteDsc, n58ClienteTelf, A58ClienteTelf, n59ClienteEst, A59ClienteEst, n60ClienteDir, A60ClienteDir, n61ClienteEmail, A61ClienteEmail, A4TipClientID, A1EmpID, A5ClienteID});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("Clientes") ;
                     if ( (pr_default.getStatus(11) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Clientes"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate035( ) ;
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
            EndLevel035( ) ;
         }
         CloseExtendedTableCursors035( ) ;
      }

      protected void DeferredUpdate035( )
      {
      }

      protected void delete( )
      {
         BeforeValidate035( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency035( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls035( ) ;
            AfterConfirm035( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete035( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000314 */
                  pr_default.execute(12, new Object[] {A1EmpID, A5ClienteID});
                  pr_default.close(12);
                  dsDefault.SmartCacheProvider.SetUpdated("Clientes") ;
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
         sMode5 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel035( ) ;
         Gx_mode = sMode5;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls035( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV14Pgmname = "Clientes";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
            /* Using cursor T000315 */
            pr_default.execute(13, new Object[] {A1EmpID});
            A44empdsc = T000315_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000315_n44empdsc[0];
            pr_default.close(13);
            /* Using cursor T000316 */
            pr_default.execute(14, new Object[] {A4TipClientID});
            A54TipClientDsc = T000316_A54TipClientDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54TipClientDsc", A54TipClientDsc);
            n54TipClientDsc = T000316_n54TipClientDsc[0];
            pr_default.close(14);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000317 */
            pr_default.execute(15, new Object[] {A1EmpID, A5ClienteID});
            if ( (pr_default.getStatus(15) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Despacho Bodega"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(15);
            /* Using cursor T000318 */
            pr_default.execute(16, new Object[] {A1EmpID, A5ClienteID});
            if ( (pr_default.getStatus(16) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"TipoInv"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(16);
            /* Using cursor T000319 */
            pr_default.execute(17, new Object[] {A1EmpID, A5ClienteID});
            if ( (pr_default.getStatus(17) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Orden Produccion"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(17);
         }
      }

      protected void EndLevel035( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete035( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(13);
            pr_default.close(14);
            context.CommitDataStores("clientes",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues030( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(13);
            pr_default.close(14);
            context.RollbackDataStores("clientes",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart035( )
      {
         /* Scan By routine */
         /* Using cursor T000320 */
         pr_default.execute(18);
         RcdFound5 = 0;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound5 = 1;
            A1EmpID = T000320_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A5ClienteID = T000320_A5ClienteID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext035( )
      {
         /* Scan next routine */
         pr_default.readNext(18);
         RcdFound5 = 0;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound5 = 1;
            A1EmpID = T000320_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A5ClienteID = T000320_A5ClienteID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
         }
      }

      protected void ScanEnd035( )
      {
         pr_default.close(18);
      }

      protected void AfterConfirm035( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert035( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate035( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete035( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete035( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate035( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes035( )
      {
         edtEmpID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         edtempdsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempdsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempdsc_Enabled), 5, 0)), true);
         edtClienteID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteID_Enabled), 5, 0)), true);
         edtClienteRUC_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteRUC_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteRUC_Enabled), 5, 0)), true);
         edtClienteDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteDsc_Enabled), 5, 0)), true);
         edtTipClientID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipClientID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipClientID_Enabled), 5, 0)), true);
         edtTipClientDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipClientDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipClientDsc_Enabled), 5, 0)), true);
         edtClienteTelf_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteTelf_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteTelf_Enabled), 5, 0)), true);
         edtClienteEst_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteEst_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteEst_Enabled), 5, 0)), true);
         edtClienteDir_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteDir_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteDir_Enabled), 5, 0)), true);
         edtClienteEmail_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteEmail_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteEmail_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes035( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues030( )
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
         context.SendWebValue( "Clientes") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20231192234155", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("clientes.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7EmpID) + "," + UrlEncode("" +AV8ClienteID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "Clientes";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV12Insert_TipClientID), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("clientes:[SendSecurityCheck value for]"+"Insert_TipClientID:"+context.localUtil.Format( (decimal)(AV12Insert_TipClientID), "ZZZ9"));
         GXUtil.WriteLog("clientes:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1EmpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z5ClienteID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z5ClienteID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z56ClienteRUC", StringUtil.RTrim( Z56ClienteRUC));
         GxWebStd.gx_hidden_field( context, "Z57ClienteDsc", StringUtil.RTrim( Z57ClienteDsc));
         GxWebStd.gx_hidden_field( context, "Z58ClienteTelf", Z58ClienteTelf);
         GxWebStd.gx_hidden_field( context, "Z59ClienteEst", StringUtil.RTrim( Z59ClienteEst));
         GxWebStd.gx_hidden_field( context, "Z60ClienteDir", Z60ClienteDir);
         GxWebStd.gx_hidden_field( context, "Z61ClienteEmail", Z61ClienteEmail);
         GxWebStd.gx_hidden_field( context, "Z4TipClientID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z4TipClientID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N4TipClientID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A4TipClientID), 4, 0, ",", "")));
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
         GxWebStd.gx_hidden_field( context, "vCLIENTEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8ClienteID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vCLIENTEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8ClienteID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_TIPCLIENTID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12Insert_TipClientID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV14Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void RenderHtmlCloseForm035( )
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
         return "Clientes" ;
      }

      public override String GetPgmdesc( )
      {
         return "Clientes" ;
      }

      protected void InitializeNonKey035( )
      {
         A4TipClientID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4TipClientID", StringUtil.LTrim( StringUtil.Str( (decimal)(A4TipClientID), 4, 0)));
         A44empdsc = "";
         n44empdsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         A56ClienteRUC = "";
         n56ClienteRUC = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56ClienteRUC", A56ClienteRUC);
         n56ClienteRUC = (String.IsNullOrEmpty(StringUtil.RTrim( A56ClienteRUC)) ? true : false);
         A57ClienteDsc = "";
         n57ClienteDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A57ClienteDsc", A57ClienteDsc);
         n57ClienteDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A57ClienteDsc)) ? true : false);
         A54TipClientDsc = "";
         n54TipClientDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54TipClientDsc", A54TipClientDsc);
         A58ClienteTelf = "";
         n58ClienteTelf = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58ClienteTelf", A58ClienteTelf);
         n58ClienteTelf = (String.IsNullOrEmpty(StringUtil.RTrim( A58ClienteTelf)) ? true : false);
         A59ClienteEst = "";
         n59ClienteEst = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59ClienteEst", A59ClienteEst);
         n59ClienteEst = (String.IsNullOrEmpty(StringUtil.RTrim( A59ClienteEst)) ? true : false);
         A60ClienteDir = "";
         n60ClienteDir = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60ClienteDir", A60ClienteDir);
         n60ClienteDir = (String.IsNullOrEmpty(StringUtil.RTrim( A60ClienteDir)) ? true : false);
         A61ClienteEmail = "";
         n61ClienteEmail = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61ClienteEmail", A61ClienteEmail);
         n61ClienteEmail = (String.IsNullOrEmpty(StringUtil.RTrim( A61ClienteEmail)) ? true : false);
         Z56ClienteRUC = "";
         Z57ClienteDsc = "";
         Z58ClienteTelf = "";
         Z59ClienteEst = "";
         Z60ClienteDir = "";
         Z61ClienteEmail = "";
         Z4TipClientID = 0;
      }

      protected void InitAll035( )
      {
         A1EmpID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         A5ClienteID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
         InitializeNonKey035( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202311922341522", true);
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
         context.AddJavascriptSource("clientes.js", "?202311922341523", false);
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
         edtClienteID_Internalname = "CLIENTEID";
         edtClienteRUC_Internalname = "CLIENTERUC";
         edtClienteDsc_Internalname = "CLIENTEDSC";
         edtTipClientID_Internalname = "TIPCLIENTID";
         edtTipClientDsc_Internalname = "TIPCLIENTDSC";
         edtClienteTelf_Internalname = "CLIENTETELF";
         edtClienteEst_Internalname = "CLIENTEEST";
         edtClienteDir_Internalname = "CLIENTEDIR";
         edtClienteEmail_Internalname = "CLIENTEEMAIL";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_1_Internalname = "PROMPT_1";
         imgprompt_4_Internalname = "PROMPT_4";
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
         edtClienteEmail_Jsonclick = "";
         edtClienteEmail_Enabled = 1;
         edtClienteDir_Jsonclick = "";
         edtClienteDir_Enabled = 1;
         edtClienteEst_Jsonclick = "";
         edtClienteEst_Enabled = 1;
         edtClienteTelf_Jsonclick = "";
         edtClienteTelf_Enabled = 1;
         edtTipClientDsc_Jsonclick = "";
         edtTipClientDsc_Enabled = 0;
         imgprompt_4_Visible = 1;
         imgprompt_4_Link = "";
         edtTipClientID_Jsonclick = "";
         edtTipClientID_Enabled = 1;
         edtClienteDsc_Jsonclick = "";
         edtClienteDsc_Enabled = 1;
         edtClienteRUC_Jsonclick = "";
         edtClienteRUC_Enabled = 1;
         edtClienteID_Jsonclick = "";
         edtClienteID_Enabled = 1;
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

      protected void GX6ASACLIENTEID035( short AV8ClienteID ,
                                         short AV7EmpID )
      {
         if ( ! (0==AV8ClienteID) )
         {
            A5ClienteID = AV8ClienteID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               GXt_int1 = A5ClienteID;
               new obtultcodcliente(context ).execute(  AV7EmpID, out  GXt_int1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7EmpID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EmpID), "ZZZ9"), context));
               A5ClienteID = GXt_int1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
            }
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A5ClienteID), 4, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
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
         /* Using cursor T000315 */
         pr_default.execute(13, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A44empdsc = T000315_A44empdsc[0];
         n44empdsc = T000315_n44empdsc[0];
         pr_default.close(13);
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

      public void Valid_Tipclientid( short GX_Parm1 ,
                                     String GX_Parm2 )
      {
         A4TipClientID = GX_Parm1;
         A54TipClientDsc = GX_Parm2;
         n54TipClientDsc = false;
         /* Using cursor T000316 */
         pr_default.execute(14, new Object[] {A4TipClientID});
         if ( (pr_default.getStatus(14) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Cliente'.", "ForeignKeyNotFound", 1, "TIPCLIENTID");
            AnyError = 1;
            GX_FocusControl = edtTipClientID_Internalname;
         }
         A54TipClientDsc = T000316_A54TipClientDsc[0];
         n54TipClientDsc = T000316_n54TipClientDsc[0];
         pr_default.close(14);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A54TipClientDsc = "";
            n54TipClientDsc = false;
         }
         isValidOutput.Add(StringUtil.RTrim( A54TipClientDsc));
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV8ClienteID',fld:'vCLIENTEID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV8ClienteID',fld:'vCLIENTEID',pic:'ZZZ9',hsh:true},{av:'AV12Insert_TipClientID',fld:'vINSERT_TIPCLIENTID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12032',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV10TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(13);
         pr_default.close(14);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z56ClienteRUC = "";
         Z57ClienteDsc = "";
         Z58ClienteTelf = "";
         Z59ClienteEst = "";
         Z60ClienteDir = "";
         Z61ClienteEmail = "";
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
         A56ClienteRUC = "";
         A57ClienteDsc = "";
         A54TipClientDsc = "";
         A58ClienteTelf = "";
         A59ClienteEst = "";
         A60ClienteDir = "";
         A61ClienteEmail = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         AV14Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode5 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV10TrnContext = new SdtTransactionContext(context);
         AV11WebSession = context.GetSession();
         AV13TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z44empdsc = "";
         Z54TipClientDsc = "";
         T00034_A44empdsc = new String[] {""} ;
         T00034_n44empdsc = new bool[] {false} ;
         T00035_A54TipClientDsc = new String[] {""} ;
         T00035_n54TipClientDsc = new bool[] {false} ;
         T00036_A5ClienteID = new short[1] ;
         T00036_A44empdsc = new String[] {""} ;
         T00036_n44empdsc = new bool[] {false} ;
         T00036_A56ClienteRUC = new String[] {""} ;
         T00036_n56ClienteRUC = new bool[] {false} ;
         T00036_A57ClienteDsc = new String[] {""} ;
         T00036_n57ClienteDsc = new bool[] {false} ;
         T00036_A54TipClientDsc = new String[] {""} ;
         T00036_n54TipClientDsc = new bool[] {false} ;
         T00036_A58ClienteTelf = new String[] {""} ;
         T00036_n58ClienteTelf = new bool[] {false} ;
         T00036_A59ClienteEst = new String[] {""} ;
         T00036_n59ClienteEst = new bool[] {false} ;
         T00036_A60ClienteDir = new String[] {""} ;
         T00036_n60ClienteDir = new bool[] {false} ;
         T00036_A61ClienteEmail = new String[] {""} ;
         T00036_n61ClienteEmail = new bool[] {false} ;
         T00036_A1EmpID = new short[1] ;
         T00036_A4TipClientID = new short[1] ;
         T00037_A44empdsc = new String[] {""} ;
         T00037_n44empdsc = new bool[] {false} ;
         T00038_A54TipClientDsc = new String[] {""} ;
         T00038_n54TipClientDsc = new bool[] {false} ;
         T00039_A1EmpID = new short[1] ;
         T00039_A5ClienteID = new short[1] ;
         T00033_A5ClienteID = new short[1] ;
         T00033_A56ClienteRUC = new String[] {""} ;
         T00033_n56ClienteRUC = new bool[] {false} ;
         T00033_A57ClienteDsc = new String[] {""} ;
         T00033_n57ClienteDsc = new bool[] {false} ;
         T00033_A58ClienteTelf = new String[] {""} ;
         T00033_n58ClienteTelf = new bool[] {false} ;
         T00033_A59ClienteEst = new String[] {""} ;
         T00033_n59ClienteEst = new bool[] {false} ;
         T00033_A60ClienteDir = new String[] {""} ;
         T00033_n60ClienteDir = new bool[] {false} ;
         T00033_A61ClienteEmail = new String[] {""} ;
         T00033_n61ClienteEmail = new bool[] {false} ;
         T00033_A1EmpID = new short[1] ;
         T00033_A4TipClientID = new short[1] ;
         T000310_A1EmpID = new short[1] ;
         T000310_A5ClienteID = new short[1] ;
         T000311_A1EmpID = new short[1] ;
         T000311_A5ClienteID = new short[1] ;
         T00032_A5ClienteID = new short[1] ;
         T00032_A56ClienteRUC = new String[] {""} ;
         T00032_n56ClienteRUC = new bool[] {false} ;
         T00032_A57ClienteDsc = new String[] {""} ;
         T00032_n57ClienteDsc = new bool[] {false} ;
         T00032_A58ClienteTelf = new String[] {""} ;
         T00032_n58ClienteTelf = new bool[] {false} ;
         T00032_A59ClienteEst = new String[] {""} ;
         T00032_n59ClienteEst = new bool[] {false} ;
         T00032_A60ClienteDir = new String[] {""} ;
         T00032_n60ClienteDir = new bool[] {false} ;
         T00032_A61ClienteEmail = new String[] {""} ;
         T00032_n61ClienteEmail = new bool[] {false} ;
         T00032_A1EmpID = new short[1] ;
         T00032_A4TipClientID = new short[1] ;
         T000315_A44empdsc = new String[] {""} ;
         T000315_n44empdsc = new bool[] {false} ;
         T000316_A54TipClientDsc = new String[] {""} ;
         T000316_n54TipClientDsc = new bool[] {false} ;
         T000317_A1EmpID = new short[1] ;
         T000317_A2AgeID = new short[1] ;
         T000317_A353DespBodNro = new short[1] ;
         T000317_A22OrdenID = new short[1] ;
         T000317_A5ClienteID = new short[1] ;
         T000318_A290stockAnio = new short[1] ;
         T000318_A291stockMes = new short[1] ;
         T000318_A1EmpID = new short[1] ;
         T000318_A2AgeID = new short[1] ;
         T000318_A42BodCod = new short[1] ;
         T000318_A286PrdCod = new short[1] ;
         T000318_A348stockDetID = new short[1] ;
         T000319_A1EmpID = new short[1] ;
         T000319_A5ClienteID = new short[1] ;
         T000319_A24OrdenPeriodo = new short[1] ;
         T000319_A25OrdenAnio = new short[1] ;
         T000319_A22OrdenID = new short[1] ;
         T000320_A1EmpID = new short[1] ;
         T000320_A5ClienteID = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.clientes__default(),
            new Object[][] {
                new Object[] {
               T00032_A5ClienteID, T00032_A56ClienteRUC, T00032_n56ClienteRUC, T00032_A57ClienteDsc, T00032_n57ClienteDsc, T00032_A58ClienteTelf, T00032_n58ClienteTelf, T00032_A59ClienteEst, T00032_n59ClienteEst, T00032_A60ClienteDir,
               T00032_n60ClienteDir, T00032_A61ClienteEmail, T00032_n61ClienteEmail, T00032_A1EmpID, T00032_A4TipClientID
               }
               , new Object[] {
               T00033_A5ClienteID, T00033_A56ClienteRUC, T00033_n56ClienteRUC, T00033_A57ClienteDsc, T00033_n57ClienteDsc, T00033_A58ClienteTelf, T00033_n58ClienteTelf, T00033_A59ClienteEst, T00033_n59ClienteEst, T00033_A60ClienteDir,
               T00033_n60ClienteDir, T00033_A61ClienteEmail, T00033_n61ClienteEmail, T00033_A1EmpID, T00033_A4TipClientID
               }
               , new Object[] {
               T00034_A44empdsc, T00034_n44empdsc
               }
               , new Object[] {
               T00035_A54TipClientDsc, T00035_n54TipClientDsc
               }
               , new Object[] {
               T00036_A5ClienteID, T00036_A44empdsc, T00036_n44empdsc, T00036_A56ClienteRUC, T00036_n56ClienteRUC, T00036_A57ClienteDsc, T00036_n57ClienteDsc, T00036_A54TipClientDsc, T00036_n54TipClientDsc, T00036_A58ClienteTelf,
               T00036_n58ClienteTelf, T00036_A59ClienteEst, T00036_n59ClienteEst, T00036_A60ClienteDir, T00036_n60ClienteDir, T00036_A61ClienteEmail, T00036_n61ClienteEmail, T00036_A1EmpID, T00036_A4TipClientID
               }
               , new Object[] {
               T00037_A44empdsc, T00037_n44empdsc
               }
               , new Object[] {
               T00038_A54TipClientDsc, T00038_n54TipClientDsc
               }
               , new Object[] {
               T00039_A1EmpID, T00039_A5ClienteID
               }
               , new Object[] {
               T000310_A1EmpID, T000310_A5ClienteID
               }
               , new Object[] {
               T000311_A1EmpID, T000311_A5ClienteID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000315_A44empdsc, T000315_n44empdsc
               }
               , new Object[] {
               T000316_A54TipClientDsc, T000316_n54TipClientDsc
               }
               , new Object[] {
               T000317_A1EmpID, T000317_A2AgeID, T000317_A353DespBodNro, T000317_A22OrdenID, T000317_A5ClienteID
               }
               , new Object[] {
               T000318_A290stockAnio, T000318_A291stockMes, T000318_A1EmpID, T000318_A2AgeID, T000318_A42BodCod, T000318_A286PrdCod, T000318_A348stockDetID
               }
               , new Object[] {
               T000319_A1EmpID, T000319_A5ClienteID, T000319_A24OrdenPeriodo, T000319_A25OrdenAnio, T000319_A22OrdenID
               }
               , new Object[] {
               T000320_A1EmpID, T000320_A5ClienteID
               }
            }
         );
         AV14Pgmname = "Clientes";
      }

      private short wcpOAV7EmpID ;
      private short wcpOAV8ClienteID ;
      private short Z1EmpID ;
      private short Z5ClienteID ;
      private short Z4TipClientID ;
      private short N4TipClientID ;
      private short GxWebError ;
      private short AV8ClienteID ;
      private short AV7EmpID ;
      private short A1EmpID ;
      private short A4TipClientID ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short A5ClienteID ;
      private short AV12Insert_TipClientID ;
      private short RcdFound5 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short GXt_int1 ;
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
      private int edtClienteID_Enabled ;
      private int edtClienteRUC_Enabled ;
      private int edtClienteDsc_Enabled ;
      private int edtTipClientID_Enabled ;
      private int imgprompt_4_Visible ;
      private int edtTipClientDsc_Enabled ;
      private int edtClienteTelf_Enabled ;
      private int edtClienteEst_Enabled ;
      private int edtClienteDir_Enabled ;
      private int edtClienteEmail_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int AV15GXV1 ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z56ClienteRUC ;
      private String Z57ClienteDsc ;
      private String Z59ClienteEst ;
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
      private String edtClienteID_Internalname ;
      private String edtClienteID_Jsonclick ;
      private String edtClienteRUC_Internalname ;
      private String A56ClienteRUC ;
      private String edtClienteRUC_Jsonclick ;
      private String edtClienteDsc_Internalname ;
      private String A57ClienteDsc ;
      private String edtClienteDsc_Jsonclick ;
      private String edtTipClientID_Internalname ;
      private String edtTipClientID_Jsonclick ;
      private String imgprompt_4_Internalname ;
      private String imgprompt_4_Link ;
      private String edtTipClientDsc_Internalname ;
      private String A54TipClientDsc ;
      private String edtTipClientDsc_Jsonclick ;
      private String edtClienteTelf_Internalname ;
      private String edtClienteTelf_Jsonclick ;
      private String edtClienteEst_Internalname ;
      private String A59ClienteEst ;
      private String edtClienteEst_Jsonclick ;
      private String edtClienteDir_Internalname ;
      private String edtClienteDir_Jsonclick ;
      private String edtClienteEmail_Internalname ;
      private String edtClienteEmail_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String AV14Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode5 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z54TipClientDsc ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n44empdsc ;
      private bool n56ClienteRUC ;
      private bool n57ClienteDsc ;
      private bool n54TipClientDsc ;
      private bool n58ClienteTelf ;
      private bool n59ClienteEst ;
      private bool n60ClienteDir ;
      private bool n61ClienteEmail ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private String Z58ClienteTelf ;
      private String Z60ClienteDir ;
      private String Z61ClienteEmail ;
      private String A44empdsc ;
      private String A58ClienteTelf ;
      private String A60ClienteDir ;
      private String A61ClienteEmail ;
      private String Z44empdsc ;
      private IGxSession AV11WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T00034_A44empdsc ;
      private bool[] T00034_n44empdsc ;
      private String[] T00035_A54TipClientDsc ;
      private bool[] T00035_n54TipClientDsc ;
      private short[] T00036_A5ClienteID ;
      private String[] T00036_A44empdsc ;
      private bool[] T00036_n44empdsc ;
      private String[] T00036_A56ClienteRUC ;
      private bool[] T00036_n56ClienteRUC ;
      private String[] T00036_A57ClienteDsc ;
      private bool[] T00036_n57ClienteDsc ;
      private String[] T00036_A54TipClientDsc ;
      private bool[] T00036_n54TipClientDsc ;
      private String[] T00036_A58ClienteTelf ;
      private bool[] T00036_n58ClienteTelf ;
      private String[] T00036_A59ClienteEst ;
      private bool[] T00036_n59ClienteEst ;
      private String[] T00036_A60ClienteDir ;
      private bool[] T00036_n60ClienteDir ;
      private String[] T00036_A61ClienteEmail ;
      private bool[] T00036_n61ClienteEmail ;
      private short[] T00036_A1EmpID ;
      private short[] T00036_A4TipClientID ;
      private String[] T00037_A44empdsc ;
      private bool[] T00037_n44empdsc ;
      private String[] T00038_A54TipClientDsc ;
      private bool[] T00038_n54TipClientDsc ;
      private short[] T00039_A1EmpID ;
      private short[] T00039_A5ClienteID ;
      private short[] T00033_A5ClienteID ;
      private String[] T00033_A56ClienteRUC ;
      private bool[] T00033_n56ClienteRUC ;
      private String[] T00033_A57ClienteDsc ;
      private bool[] T00033_n57ClienteDsc ;
      private String[] T00033_A58ClienteTelf ;
      private bool[] T00033_n58ClienteTelf ;
      private String[] T00033_A59ClienteEst ;
      private bool[] T00033_n59ClienteEst ;
      private String[] T00033_A60ClienteDir ;
      private bool[] T00033_n60ClienteDir ;
      private String[] T00033_A61ClienteEmail ;
      private bool[] T00033_n61ClienteEmail ;
      private short[] T00033_A1EmpID ;
      private short[] T00033_A4TipClientID ;
      private short[] T000310_A1EmpID ;
      private short[] T000310_A5ClienteID ;
      private short[] T000311_A1EmpID ;
      private short[] T000311_A5ClienteID ;
      private short[] T00032_A5ClienteID ;
      private String[] T00032_A56ClienteRUC ;
      private bool[] T00032_n56ClienteRUC ;
      private String[] T00032_A57ClienteDsc ;
      private bool[] T00032_n57ClienteDsc ;
      private String[] T00032_A58ClienteTelf ;
      private bool[] T00032_n58ClienteTelf ;
      private String[] T00032_A59ClienteEst ;
      private bool[] T00032_n59ClienteEst ;
      private String[] T00032_A60ClienteDir ;
      private bool[] T00032_n60ClienteDir ;
      private String[] T00032_A61ClienteEmail ;
      private bool[] T00032_n61ClienteEmail ;
      private short[] T00032_A1EmpID ;
      private short[] T00032_A4TipClientID ;
      private String[] T000315_A44empdsc ;
      private bool[] T000315_n44empdsc ;
      private String[] T000316_A54TipClientDsc ;
      private bool[] T000316_n54TipClientDsc ;
      private short[] T000317_A1EmpID ;
      private short[] T000317_A2AgeID ;
      private short[] T000317_A353DespBodNro ;
      private short[] T000317_A22OrdenID ;
      private short[] T000317_A5ClienteID ;
      private short[] T000318_A290stockAnio ;
      private short[] T000318_A291stockMes ;
      private short[] T000318_A1EmpID ;
      private short[] T000318_A2AgeID ;
      private short[] T000318_A42BodCod ;
      private short[] T000318_A286PrdCod ;
      private short[] T000318_A348stockDetID ;
      private short[] T000319_A1EmpID ;
      private short[] T000319_A5ClienteID ;
      private short[] T000319_A24OrdenPeriodo ;
      private short[] T000319_A25OrdenAnio ;
      private short[] T000319_A22OrdenID ;
      private short[] T000320_A1EmpID ;
      private short[] T000320_A5ClienteID ;
      private SdtTransactionContext AV10TrnContext ;
      private SdtTransactionContext_Attribute AV13TrnContextAtt ;
   }

   public class clientes__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new UpdateCursor(def[11])
         ,new UpdateCursor(def[12])
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
          Object[] prmT00036 ;
          prmT00036 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00034 ;
          prmT00034 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00035 ;
          prmT00035 = new Object[] {
          new Object[] {"@TipClientID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00037 ;
          prmT00037 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00038 ;
          prmT00038 = new Object[] {
          new Object[] {"@TipClientID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00039 ;
          prmT00039 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00033 ;
          prmT00033 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000310 ;
          prmT000310 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000311 ;
          prmT000311 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00032 ;
          prmT00032 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000312 ;
          prmT000312 = new Object[] {
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteRUC",SqlDbType.Char,13,0} ,
          new Object[] {"@ClienteDsc",SqlDbType.Char,50,0} ,
          new Object[] {"@ClienteTelf",SqlDbType.VarChar,20,0} ,
          new Object[] {"@ClienteEst",SqlDbType.Char,1,0} ,
          new Object[] {"@ClienteDir",SqlDbType.VarChar,80,0} ,
          new Object[] {"@ClienteEmail",SqlDbType.VarChar,100,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipClientID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000313 ;
          prmT000313 = new Object[] {
          new Object[] {"@ClienteRUC",SqlDbType.Char,13,0} ,
          new Object[] {"@ClienteDsc",SqlDbType.Char,50,0} ,
          new Object[] {"@ClienteTelf",SqlDbType.VarChar,20,0} ,
          new Object[] {"@ClienteEst",SqlDbType.Char,1,0} ,
          new Object[] {"@ClienteDir",SqlDbType.VarChar,80,0} ,
          new Object[] {"@ClienteEmail",SqlDbType.VarChar,100,0} ,
          new Object[] {"@TipClientID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000314 ;
          prmT000314 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000317 ;
          prmT000317 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000318 ;
          prmT000318 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000319 ;
          prmT000319 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000320 ;
          prmT000320 = new Object[] {
          } ;
          Object[] prmT000315 ;
          prmT000315 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000316 ;
          prmT000316 = new Object[] {
          new Object[] {"@TipClientID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00032", "SELECT [ClienteID], [ClienteRUC], [ClienteDsc], [ClienteTelf], [ClienteEst], [ClienteDir], [ClienteEmail], [EmpID], [TipClientID] FROM [Clientes] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00032,1,0,true,false )
             ,new CursorDef("T00033", "SELECT [ClienteID], [ClienteRUC], [ClienteDsc], [ClienteTelf], [ClienteEst], [ClienteDir], [ClienteEmail], [EmpID], [TipClientID] FROM [Clientes] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00033,1,0,true,false )
             ,new CursorDef("T00034", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00034,1,0,true,false )
             ,new CursorDef("T00035", "SELECT [TipClientDsc] FROM [TipoCliente] WITH (NOLOCK) WHERE [TipClientID] = @TipClientID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00035,1,0,true,false )
             ,new CursorDef("T00036", "SELECT TM1.[ClienteID], T2.[empdsc], TM1.[ClienteRUC], TM1.[ClienteDsc], T3.[TipClientDsc], TM1.[ClienteTelf], TM1.[ClienteEst], TM1.[ClienteDir], TM1.[ClienteEmail], TM1.[EmpID], TM1.[TipClientID] FROM (([Clientes] TM1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = TM1.[EmpID]) INNER JOIN [TipoCliente] T3 WITH (NOLOCK) ON T3.[TipClientID] = TM1.[TipClientID]) WHERE TM1.[EmpID] = @EmpID and TM1.[ClienteID] = @ClienteID ORDER BY TM1.[EmpID], TM1.[ClienteID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00036,100,0,true,false )
             ,new CursorDef("T00037", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00037,1,0,true,false )
             ,new CursorDef("T00038", "SELECT [TipClientDsc] FROM [TipoCliente] WITH (NOLOCK) WHERE [TipClientID] = @TipClientID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00038,1,0,true,false )
             ,new CursorDef("T00039", "SELECT [EmpID], [ClienteID] FROM [Clientes] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00039,1,0,true,false )
             ,new CursorDef("T000310", "SELECT TOP 1 [EmpID], [ClienteID] FROM [Clientes] WITH (NOLOCK) WHERE ( [EmpID] > @EmpID or [EmpID] = @EmpID and [ClienteID] > @ClienteID) ORDER BY [EmpID], [ClienteID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000310,1,0,true,true )
             ,new CursorDef("T000311", "SELECT TOP 1 [EmpID], [ClienteID] FROM [Clientes] WITH (NOLOCK) WHERE ( [EmpID] < @EmpID or [EmpID] = @EmpID and [ClienteID] < @ClienteID) ORDER BY [EmpID] DESC, [ClienteID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000311,1,0,true,true )
             ,new CursorDef("T000312", "INSERT INTO [Clientes]([ClienteID], [ClienteRUC], [ClienteDsc], [ClienteTelf], [ClienteEst], [ClienteDir], [ClienteEmail], [EmpID], [TipClientID]) VALUES(@ClienteID, @ClienteRUC, @ClienteDsc, @ClienteTelf, @ClienteEst, @ClienteDir, @ClienteEmail, @EmpID, @TipClientID)", GxErrorMask.GX_NOMASK,prmT000312)
             ,new CursorDef("T000313", "UPDATE [Clientes] SET [ClienteRUC]=@ClienteRUC, [ClienteDsc]=@ClienteDsc, [ClienteTelf]=@ClienteTelf, [ClienteEst]=@ClienteEst, [ClienteDir]=@ClienteDir, [ClienteEmail]=@ClienteEmail, [TipClientID]=@TipClientID  WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID", GxErrorMask.GX_NOMASK,prmT000313)
             ,new CursorDef("T000314", "DELETE FROM [Clientes]  WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID", GxErrorMask.GX_NOMASK,prmT000314)
             ,new CursorDef("T000315", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000315,1,0,true,false )
             ,new CursorDef("T000316", "SELECT [TipClientDsc] FROM [TipoCliente] WITH (NOLOCK) WHERE [TipClientID] = @TipClientID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000316,1,0,true,false )
             ,new CursorDef("T000317", "SELECT TOP 1 [EmpID], [AgeID], [DespBodNro], [OrdenID], [ClienteID] FROM [DespBodega] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000317,1,0,true,true )
             ,new CursorDef("T000318", "SELECT TOP 1 [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod], [stockDetID] FROM [ProdxBodegaTipoInv] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000318,1,0,true,true )
             ,new CursorDef("T000319", "SELECT TOP 1 [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID] FROM [OrdenProduccion] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000319,1,0,true,true )
             ,new CursorDef("T000320", "SELECT [EmpID], [ClienteID] FROM [Clientes] WITH (NOLOCK) ORDER BY [EmpID], [ClienteID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000320,100,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 13) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 1) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((short[]) buf[13])[0] = rslt.getShort(8) ;
                ((short[]) buf[14])[0] = rslt.getShort(9) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 13) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 1) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((short[]) buf[13])[0] = rslt.getShort(8) ;
                ((short[]) buf[14])[0] = rslt.getShort(9) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 13) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 50) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 50) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getString(7, 1) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((short[]) buf[17])[0] = rslt.getShort(10) ;
                ((short[]) buf[18])[0] = rslt.getShort(11) ;
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 15 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 16 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                return;
             case 17 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
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
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 10 :
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
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 4 , SqlDbType.VarChar );
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
                   stmt.setNull( 6 , SqlDbType.VarChar );
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
                stmt.SetParameter(8, (short)parms[13]);
                stmt.SetParameter(9, (short)parms[14]);
                return;
             case 11 :
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
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.VarChar );
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
                   stmt.setNull( 5 , SqlDbType.VarChar );
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
                stmt.SetParameter(7, (short)parms[12]);
                stmt.SetParameter(8, (short)parms[13]);
                stmt.SetParameter(9, (short)parms[14]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
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
