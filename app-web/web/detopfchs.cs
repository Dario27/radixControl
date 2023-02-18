/*
               File: detOpFchs
        Description: control de fechas
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/26/2022 20:13:29.45
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
   public class detopfchs : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_17") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_17( A1EmpID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_18") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A19detOpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19detOpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19detOpID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_18( A1EmpID, A19detOpID) ;
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
               AV8detOpSec = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8detOpSec", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8detOpSec), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vDETOPSEC", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8detOpSec), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "control de fechas", 0) ;
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

      public detopfchs( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public detopfchs( IGxContext context )
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
                           short aP2_detOpSec )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7EmpID = aP1_EmpID;
         this.AV8detOpSec = aP2_detOpSec;
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "control de fechas", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_detOpFchs.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_detOpFchs.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_detOpFchs.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_detOpFchs.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_detOpFchs.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx00i0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"DETOPSEC"+"'), id:'"+"DETOPSEC"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_detOpFchs.htm");
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
            GxWebStd.gx_single_line_edit( context, edtEmpID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEmpID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEmpID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_detOpFchs.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_1_Internalname, sImgUrl, imgprompt_1_Link, "", "", context.GetTheme( ), imgprompt_1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_detOpFchs.htm");
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
            GxWebStd.gx_single_line_edit( context, edtempdsc_Internalname, A44empdsc, StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempdsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtempdsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_detOpFchs.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtdetOpSec_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtdetOpSec_Internalname, "Nro.", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtdetOpSec_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A18detOpSec), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A18detOpSec), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtdetOpSec_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtdetOpSec_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_detOpFchs.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOrdenID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOrdenID_Internalname, "Nro. Orden", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtOrdenID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A22OrdenID), 4, 0, ",", "")), ((edtOrdenID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A22OrdenID), "ZZZ9")) : context.localUtil.Format( (decimal)(A22OrdenID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOrdenID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOrdenID_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_detOpFchs.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtdetOpID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtdetOpID_Internalname, "ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtdetOpID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19detOpID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A19detOpID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtdetOpID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtdetOpID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_detOpFchs.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_19_Internalname, sImgUrl, imgprompt_19_Link, "", "", context.GetTheme( ), imgprompt_19_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_detOpFchs.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtdetOpDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtdetOpDsc_Internalname, "Tipo Orden", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtdetOpDsc_Internalname, StringUtil.RTrim( A123detOpDsc), StringUtil.RTrim( context.localUtil.Format( A123detOpDsc, "@!")), TempTags+" onchange=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtdetOpDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtdetOpDsc_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "nombres", "left", true, "HLP_detOpFchs.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtdetOpFchIng_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtdetOpFchIng_Internalname, "Ingreso Unidad", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtdetOpFchIng_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtdetOpFchIng_Internalname, context.localUtil.Format(A124detOpFchIng, "99/99/9999"), context.localUtil.Format( A124detOpFchIng, "99/99/9999"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtdetOpFchIng_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtdetOpFchIng_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_detOpFchs.htm");
            GxWebStd.gx_bitmap( context, edtdetOpFchIng_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtdetOpFchIng_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_detOpFchs.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtdetOpFchIni_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtdetOpFchIni_Internalname, "Obra", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtdetOpFchIni_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtdetOpFchIni_Internalname, context.localUtil.Format(A127detOpFchIni, "99/99/9999"), context.localUtil.Format( A127detOpFchIni, "99/99/9999"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,69);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtdetOpFchIni_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtdetOpFchIni_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_detOpFchs.htm");
            GxWebStd.gx_bitmap( context, edtdetOpFchIni_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtdetOpFchIni_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_detOpFchs.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtdetOpFchSalida_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtdetOpFchSalida_Internalname, "Salida Unidad", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtdetOpFchSalida_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtdetOpFchSalida_Internalname, context.localUtil.Format(A125detOpFchSalida, "99/99/9999"), context.localUtil.Format( A125detOpFchSalida, "99/99/9999"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,74);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtdetOpFchSalida_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtdetOpFchSalida_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_detOpFchs.htm");
            GxWebStd.gx_bitmap( context, edtdetOpFchSalida_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtdetOpFchSalida_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_detOpFchs.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtdetOpFchFin_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtdetOpFchFin_Internalname, "Fin de Obra", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 79,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtdetOpFchFin_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtdetOpFchFin_Internalname, context.localUtil.Format(A126detOpFchFin, "99/99/9999"), context.localUtil.Format( A126detOpFchFin, "99/99/9999"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,79);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtdetOpFchFin_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtdetOpFchFin_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_detOpFchs.htm");
            GxWebStd.gx_bitmap( context, edtdetOpFchFin_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtdetOpFchFin_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_detOpFchs.htm");
            context.WriteHtmlTextNl( "</div>") ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 84,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_detOpFchs.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_detOpFchs.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 88,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_detOpFchs.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm0818( ) ;
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
         E11082 ();
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtdetOpSec_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtdetOpSec_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "DETOPSEC");
                  AnyError = 1;
                  GX_FocusControl = edtdetOpSec_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A18detOpSec = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18detOpSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A18detOpSec), 4, 0)));
               }
               else
               {
                  A18detOpSec = (short)(context.localUtil.CToN( cgiGet( edtdetOpSec_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18detOpSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A18detOpSec), 4, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtOrdenID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtOrdenID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ORDENID");
                  AnyError = 1;
                  GX_FocusControl = edtOrdenID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A22OrdenID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
               }
               else
               {
                  A22OrdenID = (short)(context.localUtil.CToN( cgiGet( edtOrdenID_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtdetOpID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtdetOpID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "DETOPID");
                  AnyError = 1;
                  GX_FocusControl = edtdetOpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A19detOpID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19detOpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19detOpID), 4, 0)));
               }
               else
               {
                  A19detOpID = (short)(context.localUtil.CToN( cgiGet( edtdetOpID_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19detOpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19detOpID), 4, 0)));
               }
               A123detOpDsc = StringUtil.Upper( cgiGet( edtdetOpDsc_Internalname));
               n123detOpDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A123detOpDsc", A123detOpDsc);
               n123detOpDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A123detOpDsc)) ? true : false);
               if ( context.localUtil.VCDate( cgiGet( edtdetOpFchIng_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Ingreso Unidad"}), 1, "DETOPFCHING");
                  AnyError = 1;
                  GX_FocusControl = edtdetOpFchIng_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A124detOpFchIng = DateTime.MinValue;
                  n124detOpFchIng = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A124detOpFchIng", context.localUtil.Format(A124detOpFchIng, "99/99/9999"));
               }
               else
               {
                  A124detOpFchIng = context.localUtil.CToD( cgiGet( edtdetOpFchIng_Internalname), 2);
                  n124detOpFchIng = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A124detOpFchIng", context.localUtil.Format(A124detOpFchIng, "99/99/9999"));
               }
               n124detOpFchIng = ((DateTime.MinValue==A124detOpFchIng) ? true : false);
               if ( context.localUtil.VCDate( cgiGet( edtdetOpFchIni_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Inicio Obra"}), 1, "DETOPFCHINI");
                  AnyError = 1;
                  GX_FocusControl = edtdetOpFchIni_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A127detOpFchIni = DateTime.MinValue;
                  n127detOpFchIni = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127detOpFchIni", context.localUtil.Format(A127detOpFchIni, "99/99/9999"));
               }
               else
               {
                  A127detOpFchIni = context.localUtil.CToD( cgiGet( edtdetOpFchIni_Internalname), 2);
                  n127detOpFchIni = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127detOpFchIni", context.localUtil.Format(A127detOpFchIni, "99/99/9999"));
               }
               n127detOpFchIni = ((DateTime.MinValue==A127detOpFchIni) ? true : false);
               if ( context.localUtil.VCDate( cgiGet( edtdetOpFchSalida_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Salida Unidad"}), 1, "DETOPFCHSALIDA");
                  AnyError = 1;
                  GX_FocusControl = edtdetOpFchSalida_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A125detOpFchSalida = DateTime.MinValue;
                  n125detOpFchSalida = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A125detOpFchSalida", context.localUtil.Format(A125detOpFchSalida, "99/99/9999"));
               }
               else
               {
                  A125detOpFchSalida = context.localUtil.CToD( cgiGet( edtdetOpFchSalida_Internalname), 2);
                  n125detOpFchSalida = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A125detOpFchSalida", context.localUtil.Format(A125detOpFchSalida, "99/99/9999"));
               }
               n125detOpFchSalida = ((DateTime.MinValue==A125detOpFchSalida) ? true : false);
               if ( context.localUtil.VCDate( cgiGet( edtdetOpFchFin_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fin Obra"}), 1, "DETOPFCHFIN");
                  AnyError = 1;
                  GX_FocusControl = edtdetOpFchFin_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A126detOpFchFin = DateTime.MinValue;
                  n126detOpFchFin = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126detOpFchFin", context.localUtil.Format(A126detOpFchFin, "99/99/9999"));
               }
               else
               {
                  A126detOpFchFin = context.localUtil.CToD( cgiGet( edtdetOpFchFin_Internalname), 2);
                  n126detOpFchFin = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126detOpFchFin", context.localUtil.Format(A126detOpFchFin, "99/99/9999"));
               }
               n126detOpFchFin = ((DateTime.MinValue==A126detOpFchFin) ? true : false);
               /* Read saved values. */
               Z1EmpID = (short)(context.localUtil.CToN( cgiGet( "Z1EmpID"), ",", "."));
               Z18detOpSec = (short)(context.localUtil.CToN( cgiGet( "Z18detOpSec"), ",", "."));
               Z22OrdenID = (short)(context.localUtil.CToN( cgiGet( "Z22OrdenID"), ",", "."));
               Z123detOpDsc = cgiGet( "Z123detOpDsc");
               n123detOpDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A123detOpDsc)) ? true : false);
               Z124detOpFchIng = context.localUtil.CToD( cgiGet( "Z124detOpFchIng"), 0);
               n124detOpFchIng = ((DateTime.MinValue==A124detOpFchIng) ? true : false);
               Z127detOpFchIni = context.localUtil.CToD( cgiGet( "Z127detOpFchIni"), 0);
               n127detOpFchIni = ((DateTime.MinValue==A127detOpFchIni) ? true : false);
               Z125detOpFchSalida = context.localUtil.CToD( cgiGet( "Z125detOpFchSalida"), 0);
               n125detOpFchSalida = ((DateTime.MinValue==A125detOpFchSalida) ? true : false);
               Z126detOpFchFin = context.localUtil.CToD( cgiGet( "Z126detOpFchFin"), 0);
               n126detOpFchFin = ((DateTime.MinValue==A126detOpFchFin) ? true : false);
               Z19detOpID = (short)(context.localUtil.CToN( cgiGet( "Z19detOpID"), ",", "."));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               N19detOpID = (short)(context.localUtil.CToN( cgiGet( "N19detOpID"), ",", "."));
               AV7EmpID = (short)(context.localUtil.CToN( cgiGet( "vEMPID"), ",", "."));
               AV8detOpSec = (short)(context.localUtil.CToN( cgiGet( "vDETOPSEC"), ",", "."));
               AV12Insert_detOpID = (short)(context.localUtil.CToN( cgiGet( "vINSERT_DETOPID"), ",", "."));
               AV14Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "detOpFchs";
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV12Insert_detOpID), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A1EmpID != Z1EmpID ) || ( A18detOpSec != Z18detOpSec ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("detopfchs:[SecurityCheckFailed value for]"+"Insert_detOpID:"+context.localUtil.Format( (decimal)(AV12Insert_detOpID), "ZZZ9"));
                  GXUtil.WriteLog("detopfchs:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A18detOpSec = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18detOpSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A18detOpSec), 4, 0)));
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
                     sMode18 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode18;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound18 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_080( ) ;
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
                        E11082 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: After Trn */
                        E12082 ();
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
            E12082 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0818( ) ;
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
            DisableAttributes0818( ) ;
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

      protected void CONFIRM_080( )
      {
         BeforeValidate0818( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0818( ) ;
            }
            else
            {
               CheckExtendedTable0818( ) ;
               CloseExtendedTableCursors0818( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption080( )
      {
      }

      protected void E11082( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV14Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV14Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV10TrnContext.FromXml(AV11WebSession.Get("TrnContext"), null, "TransactionContext", "KBCalpesa22");
         AV12Insert_detOpID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Insert_detOpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12Insert_detOpID), 4, 0)));
         if ( ( StringUtil.StrCmp(AV10TrnContext.gxTpr_Transactionname, AV14Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV15GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15GXV1), 8, 0)));
            while ( AV15GXV1 <= AV10TrnContext.gxTpr_Attributes.Count )
            {
               AV13TrnContextAtt = ((SdtTransactionContext_Attribute)AV10TrnContext.gxTpr_Attributes.Item(AV15GXV1));
               if ( StringUtil.StrCmp(AV13TrnContextAtt.gxTpr_Attributename, "detOpID") == 0 )
               {
                  AV12Insert_detOpID = (short)(NumberUtil.Val( AV13TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Insert_detOpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12Insert_detOpID), 4, 0)));
               }
               AV15GXV1 = (int)(AV15GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15GXV1), 8, 0)));
            }
         }
      }

      protected void E12082( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV10TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwdetopfchs.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0818( short GX_JID )
      {
         if ( ( GX_JID == 16 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z22OrdenID = T00083_A22OrdenID[0];
               Z123detOpDsc = T00083_A123detOpDsc[0];
               Z124detOpFchIng = T00083_A124detOpFchIng[0];
               Z127detOpFchIni = T00083_A127detOpFchIni[0];
               Z125detOpFchSalida = T00083_A125detOpFchSalida[0];
               Z126detOpFchFin = T00083_A126detOpFchFin[0];
               Z19detOpID = T00083_A19detOpID[0];
            }
            else
            {
               Z22OrdenID = A22OrdenID;
               Z123detOpDsc = A123detOpDsc;
               Z124detOpFchIng = A124detOpFchIng;
               Z127detOpFchIni = A127detOpFchIni;
               Z125detOpFchSalida = A125detOpFchSalida;
               Z126detOpFchFin = A126detOpFchFin;
               Z19detOpID = A19detOpID;
            }
         }
         if ( GX_JID == -16 )
         {
            Z18detOpSec = A18detOpSec;
            Z22OrdenID = A22OrdenID;
            Z123detOpDsc = A123detOpDsc;
            Z124detOpFchIng = A124detOpFchIng;
            Z127detOpFchIni = A127detOpFchIni;
            Z125detOpFchSalida = A125detOpFchSalida;
            Z126detOpFchFin = A126detOpFchFin;
            Z1EmpID = A1EmpID;
            Z19detOpID = A19detOpID;
            Z44empdsc = A44empdsc;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_1_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_19_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00f1.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"DETOPID"+"'), id:'"+"DETOPID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
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
         if ( ! (0==AV8detOpSec) )
         {
            A18detOpSec = AV8detOpSec;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18detOpSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A18detOpSec), 4, 0)));
         }
         if ( ! (0==AV8detOpSec) )
         {
            edtdetOpSec_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetOpSec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetOpSec_Enabled), 5, 0)), true);
         }
         else
         {
            edtdetOpSec_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetOpSec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetOpSec_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV8detOpSec) )
         {
            edtdetOpSec_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetOpSec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetOpSec_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV12Insert_detOpID) )
         {
            edtdetOpID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetOpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetOpID_Enabled), 5, 0)), true);
         }
         else
         {
            edtdetOpID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetOpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetOpID_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV12Insert_detOpID) )
         {
            A19detOpID = AV12Insert_detOpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19detOpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19detOpID), 4, 0)));
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
            /* Using cursor T00084 */
            pr_default.execute(2, new Object[] {A1EmpID});
            A44empdsc = T00084_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T00084_n44empdsc[0];
            pr_default.close(2);
            AV14Pgmname = "detOpFchs";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
         }
      }

      protected void Load0818( )
      {
         /* Using cursor T00086 */
         pr_default.execute(4, new Object[] {A1EmpID, A18detOpSec});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound18 = 1;
            A44empdsc = T00086_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T00086_n44empdsc[0];
            A22OrdenID = T00086_A22OrdenID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
            A123detOpDsc = T00086_A123detOpDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A123detOpDsc", A123detOpDsc);
            n123detOpDsc = T00086_n123detOpDsc[0];
            A124detOpFchIng = T00086_A124detOpFchIng[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A124detOpFchIng", context.localUtil.Format(A124detOpFchIng, "99/99/9999"));
            n124detOpFchIng = T00086_n124detOpFchIng[0];
            A127detOpFchIni = T00086_A127detOpFchIni[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127detOpFchIni", context.localUtil.Format(A127detOpFchIni, "99/99/9999"));
            n127detOpFchIni = T00086_n127detOpFchIni[0];
            A125detOpFchSalida = T00086_A125detOpFchSalida[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A125detOpFchSalida", context.localUtil.Format(A125detOpFchSalida, "99/99/9999"));
            n125detOpFchSalida = T00086_n125detOpFchSalida[0];
            A126detOpFchFin = T00086_A126detOpFchFin[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126detOpFchFin", context.localUtil.Format(A126detOpFchFin, "99/99/9999"));
            n126detOpFchFin = T00086_n126detOpFchFin[0];
            A19detOpID = T00086_A19detOpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19detOpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19detOpID), 4, 0)));
            ZM0818( -16) ;
         }
         pr_default.close(4);
         OnLoadActions0818( ) ;
      }

      protected void OnLoadActions0818( )
      {
         AV14Pgmname = "detOpFchs";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
      }

      protected void CheckExtendedTable0818( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV14Pgmname = "detOpFchs";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
         /* Using cursor T00084 */
         pr_default.execute(2, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T00084_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T00084_n44empdsc[0];
         pr_default.close(2);
         /* Using cursor T00085 */
         pr_default.execute(3, new Object[] {A1EmpID, A19detOpID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Orden'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(3);
         if ( ! ( (DateTime.MinValue==A124detOpFchIng) || ( A124detOpFchIng >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Ingreso Unidad fuera de rango", "OutOfRange", 1, "DETOPFCHING");
            AnyError = 1;
            GX_FocusControl = edtdetOpFchIng_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A127detOpFchIni) || ( A127detOpFchIni >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Inicio Obra fuera de rango", "OutOfRange", 1, "DETOPFCHINI");
            AnyError = 1;
            GX_FocusControl = edtdetOpFchIni_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A125detOpFchSalida) || ( A125detOpFchSalida >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Salida Unidad fuera de rango", "OutOfRange", 1, "DETOPFCHSALIDA");
            AnyError = 1;
            GX_FocusControl = edtdetOpFchSalida_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A126detOpFchFin) || ( A126detOpFchFin >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fin Obra fuera de rango", "OutOfRange", 1, "DETOPFCHFIN");
            AnyError = 1;
            GX_FocusControl = edtdetOpFchFin_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0818( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_17( short A1EmpID )
      {
         /* Using cursor T00087 */
         pr_default.execute(5, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T00087_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T00087_n44empdsc[0];
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

      protected void gxLoad_18( short A1EmpID ,
                                short A19detOpID )
      {
         /* Using cursor T00088 */
         pr_default.execute(6, new Object[] {A1EmpID, A19detOpID});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Orden'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(6);
      }

      protected void GetKey0818( )
      {
         /* Using cursor T00089 */
         pr_default.execute(7, new Object[] {A1EmpID, A18detOpSec});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound18 = 1;
         }
         else
         {
            RcdFound18 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00083 */
         pr_default.execute(1, new Object[] {A1EmpID, A18detOpSec});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0818( 16) ;
            RcdFound18 = 1;
            A18detOpSec = T00083_A18detOpSec[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18detOpSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A18detOpSec), 4, 0)));
            A22OrdenID = T00083_A22OrdenID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
            A123detOpDsc = T00083_A123detOpDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A123detOpDsc", A123detOpDsc);
            n123detOpDsc = T00083_n123detOpDsc[0];
            A124detOpFchIng = T00083_A124detOpFchIng[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A124detOpFchIng", context.localUtil.Format(A124detOpFchIng, "99/99/9999"));
            n124detOpFchIng = T00083_n124detOpFchIng[0];
            A127detOpFchIni = T00083_A127detOpFchIni[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127detOpFchIni", context.localUtil.Format(A127detOpFchIni, "99/99/9999"));
            n127detOpFchIni = T00083_n127detOpFchIni[0];
            A125detOpFchSalida = T00083_A125detOpFchSalida[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A125detOpFchSalida", context.localUtil.Format(A125detOpFchSalida, "99/99/9999"));
            n125detOpFchSalida = T00083_n125detOpFchSalida[0];
            A126detOpFchFin = T00083_A126detOpFchFin[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126detOpFchFin", context.localUtil.Format(A126detOpFchFin, "99/99/9999"));
            n126detOpFchFin = T00083_n126detOpFchFin[0];
            A1EmpID = T00083_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A19detOpID = T00083_A19detOpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19detOpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19detOpID), 4, 0)));
            Z1EmpID = A1EmpID;
            Z18detOpSec = A18detOpSec;
            sMode18 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0818( ) ;
            if ( AnyError == 1 )
            {
               RcdFound18 = 0;
               InitializeNonKey0818( ) ;
            }
            Gx_mode = sMode18;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound18 = 0;
            InitializeNonKey0818( ) ;
            sMode18 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode18;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0818( ) ;
         if ( RcdFound18 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound18 = 0;
         /* Using cursor T000810 */
         pr_default.execute(8, new Object[] {A18detOpSec, A1EmpID});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000810_A18detOpSec[0] < A18detOpSec ) || ( T000810_A18detOpSec[0] == A18detOpSec ) && ( T000810_A1EmpID[0] < A1EmpID ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000810_A18detOpSec[0] > A18detOpSec ) || ( T000810_A18detOpSec[0] == A18detOpSec ) && ( T000810_A1EmpID[0] > A1EmpID ) ) )
            {
               A18detOpSec = T000810_A18detOpSec[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18detOpSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A18detOpSec), 4, 0)));
               A1EmpID = T000810_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               RcdFound18 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound18 = 0;
         /* Using cursor T000811 */
         pr_default.execute(9, new Object[] {A18detOpSec, A1EmpID});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000811_A18detOpSec[0] > A18detOpSec ) || ( T000811_A18detOpSec[0] == A18detOpSec ) && ( T000811_A1EmpID[0] > A1EmpID ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000811_A18detOpSec[0] < A18detOpSec ) || ( T000811_A18detOpSec[0] == A18detOpSec ) && ( T000811_A1EmpID[0] < A1EmpID ) ) )
            {
               A18detOpSec = T000811_A18detOpSec[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18detOpSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A18detOpSec), 4, 0)));
               A1EmpID = T000811_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               RcdFound18 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0818( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0818( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound18 == 1 )
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A18detOpSec != Z18detOpSec ) )
               {
                  A1EmpID = Z1EmpID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
                  A18detOpSec = Z18detOpSec;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18detOpSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A18detOpSec), 4, 0)));
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
                  Update0818( ) ;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A18detOpSec != Z18detOpSec ) )
               {
                  /* Insert record */
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0818( ) ;
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
                     Insert0818( ) ;
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
         if ( ( A1EmpID != Z1EmpID ) || ( A18detOpSec != Z18detOpSec ) )
         {
            A1EmpID = Z1EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A18detOpSec = Z18detOpSec;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18detOpSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A18detOpSec), 4, 0)));
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

      protected void CheckOptimisticConcurrency0818( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00082 */
            pr_default.execute(0, new Object[] {A1EmpID, A18detOpSec});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"detOpFchs"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( Z22OrdenID != T00082_A22OrdenID[0] ) || ( StringUtil.StrCmp(Z123detOpDsc, T00082_A123detOpDsc[0]) != 0 ) || ( Z124detOpFchIng != T00082_A124detOpFchIng[0] ) || ( Z127detOpFchIni != T00082_A127detOpFchIni[0] ) || ( Z125detOpFchSalida != T00082_A125detOpFchSalida[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z126detOpFchFin != T00082_A126detOpFchFin[0] ) || ( Z19detOpID != T00082_A19detOpID[0] ) )
            {
               if ( Z22OrdenID != T00082_A22OrdenID[0] )
               {
                  GXUtil.WriteLog("detopfchs:[seudo value changed for attri]"+"OrdenID");
                  GXUtil.WriteLogRaw("Old: ",Z22OrdenID);
                  GXUtil.WriteLogRaw("Current: ",T00082_A22OrdenID[0]);
               }
               if ( StringUtil.StrCmp(Z123detOpDsc, T00082_A123detOpDsc[0]) != 0 )
               {
                  GXUtil.WriteLog("detopfchs:[seudo value changed for attri]"+"detOpDsc");
                  GXUtil.WriteLogRaw("Old: ",Z123detOpDsc);
                  GXUtil.WriteLogRaw("Current: ",T00082_A123detOpDsc[0]);
               }
               if ( Z124detOpFchIng != T00082_A124detOpFchIng[0] )
               {
                  GXUtil.WriteLog("detopfchs:[seudo value changed for attri]"+"detOpFchIng");
                  GXUtil.WriteLogRaw("Old: ",Z124detOpFchIng);
                  GXUtil.WriteLogRaw("Current: ",T00082_A124detOpFchIng[0]);
               }
               if ( Z127detOpFchIni != T00082_A127detOpFchIni[0] )
               {
                  GXUtil.WriteLog("detopfchs:[seudo value changed for attri]"+"detOpFchIni");
                  GXUtil.WriteLogRaw("Old: ",Z127detOpFchIni);
                  GXUtil.WriteLogRaw("Current: ",T00082_A127detOpFchIni[0]);
               }
               if ( Z125detOpFchSalida != T00082_A125detOpFchSalida[0] )
               {
                  GXUtil.WriteLog("detopfchs:[seudo value changed for attri]"+"detOpFchSalida");
                  GXUtil.WriteLogRaw("Old: ",Z125detOpFchSalida);
                  GXUtil.WriteLogRaw("Current: ",T00082_A125detOpFchSalida[0]);
               }
               if ( Z126detOpFchFin != T00082_A126detOpFchFin[0] )
               {
                  GXUtil.WriteLog("detopfchs:[seudo value changed for attri]"+"detOpFchFin");
                  GXUtil.WriteLogRaw("Old: ",Z126detOpFchFin);
                  GXUtil.WriteLogRaw("Current: ",T00082_A126detOpFchFin[0]);
               }
               if ( Z19detOpID != T00082_A19detOpID[0] )
               {
                  GXUtil.WriteLog("detopfchs:[seudo value changed for attri]"+"detOpID");
                  GXUtil.WriteLogRaw("Old: ",Z19detOpID);
                  GXUtil.WriteLogRaw("Current: ",T00082_A19detOpID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"detOpFchs"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0818( )
      {
         BeforeValidate0818( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0818( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0818( 0) ;
            CheckOptimisticConcurrency0818( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0818( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0818( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000812 */
                     pr_default.execute(10, new Object[] {A18detOpSec, A22OrdenID, n123detOpDsc, A123detOpDsc, n124detOpFchIng, A124detOpFchIng, n127detOpFchIni, A127detOpFchIni, n125detOpFchSalida, A125detOpFchSalida, n126detOpFchFin, A126detOpFchFin, A1EmpID, A19detOpID});
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("detOpFchs") ;
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
                           ResetCaption080( ) ;
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
               Load0818( ) ;
            }
            EndLevel0818( ) ;
         }
         CloseExtendedTableCursors0818( ) ;
      }

      protected void Update0818( )
      {
         BeforeValidate0818( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0818( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0818( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0818( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0818( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000813 */
                     pr_default.execute(11, new Object[] {A22OrdenID, n123detOpDsc, A123detOpDsc, n124detOpFchIng, A124detOpFchIng, n127detOpFchIni, A127detOpFchIni, n125detOpFchSalida, A125detOpFchSalida, n126detOpFchFin, A126detOpFchFin, A19detOpID, A1EmpID, A18detOpSec});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("detOpFchs") ;
                     if ( (pr_default.getStatus(11) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"detOpFchs"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0818( ) ;
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
            EndLevel0818( ) ;
         }
         CloseExtendedTableCursors0818( ) ;
      }

      protected void DeferredUpdate0818( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0818( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0818( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0818( ) ;
            AfterConfirm0818( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0818( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000814 */
                  pr_default.execute(12, new Object[] {A1EmpID, A18detOpSec});
                  pr_default.close(12);
                  dsDefault.SmartCacheProvider.SetUpdated("detOpFchs") ;
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
         sMode18 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0818( ) ;
         Gx_mode = sMode18;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0818( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV14Pgmname = "detOpFchs";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
            /* Using cursor T000815 */
            pr_default.execute(13, new Object[] {A1EmpID});
            A44empdsc = T000815_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000815_n44empdsc[0];
            pr_default.close(13);
         }
      }

      protected void EndLevel0818( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0818( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(13);
            context.CommitDataStores("detopfchs",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues080( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(13);
            context.RollbackDataStores("detopfchs",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0818( )
      {
         /* Scan By routine */
         /* Using cursor T000816 */
         pr_default.execute(14);
         RcdFound18 = 0;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound18 = 1;
            A1EmpID = T000816_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A18detOpSec = T000816_A18detOpSec[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18detOpSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A18detOpSec), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0818( )
      {
         /* Scan next routine */
         pr_default.readNext(14);
         RcdFound18 = 0;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound18 = 1;
            A1EmpID = T000816_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A18detOpSec = T000816_A18detOpSec[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18detOpSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A18detOpSec), 4, 0)));
         }
      }

      protected void ScanEnd0818( )
      {
         pr_default.close(14);
      }

      protected void AfterConfirm0818( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0818( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0818( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0818( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0818( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0818( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0818( )
      {
         edtEmpID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         edtempdsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempdsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempdsc_Enabled), 5, 0)), true);
         edtdetOpSec_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetOpSec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetOpSec_Enabled), 5, 0)), true);
         edtOrdenID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenID_Enabled), 5, 0)), true);
         edtdetOpID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetOpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetOpID_Enabled), 5, 0)), true);
         edtdetOpDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetOpDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetOpDsc_Enabled), 5, 0)), true);
         edtdetOpFchIng_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetOpFchIng_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetOpFchIng_Enabled), 5, 0)), true);
         edtdetOpFchIni_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetOpFchIni_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetOpFchIni_Enabled), 5, 0)), true);
         edtdetOpFchSalida_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetOpFchSalida_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetOpFchSalida_Enabled), 5, 0)), true);
         edtdetOpFchFin_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetOpFchFin_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetOpFchFin_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0818( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues080( )
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
         context.SendWebValue( "control de fechas") ;
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
         context.AddJavascriptSource("gxcfg.js", "?2022102620133137", false);
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
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "";
         bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("detopfchs.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7EmpID) + "," + UrlEncode("" +AV8detOpSec)+"\">") ;
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
         forbiddenHiddens = "hsh" + "detOpFchs";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV12Insert_detOpID), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("detopfchs:[SendSecurityCheck value for]"+"Insert_detOpID:"+context.localUtil.Format( (decimal)(AV12Insert_detOpID), "ZZZ9"));
         GXUtil.WriteLog("detopfchs:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1EmpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z18detOpSec", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z18detOpSec), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z22OrdenID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z22OrdenID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z123detOpDsc", StringUtil.RTrim( Z123detOpDsc));
         GxWebStd.gx_hidden_field( context, "Z124detOpFchIng", context.localUtil.DToC( Z124detOpFchIng, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z127detOpFchIni", context.localUtil.DToC( Z127detOpFchIni, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z125detOpFchSalida", context.localUtil.DToC( Z125detOpFchSalida, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z126detOpFchFin", context.localUtil.DToC( Z126detOpFchFin, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z19detOpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z19detOpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N19detOpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19detOpID), 4, 0, ",", "")));
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
         GxWebStd.gx_hidden_field( context, "vDETOPSEC", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8detOpSec), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vDETOPSEC", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8detOpSec), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_DETOPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12Insert_detOpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV14Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void RenderHtmlCloseForm0818( )
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
         return "detOpFchs" ;
      }

      public override String GetPgmdesc( )
      {
         return "control de fechas" ;
      }

      protected void InitializeNonKey0818( )
      {
         A17tipOrdID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17tipOrdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A17tipOrdID), 4, 0)));
         A19detOpID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19detOpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19detOpID), 4, 0)));
         A44empdsc = "";
         n44empdsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         A22OrdenID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
         A123detOpDsc = "";
         n123detOpDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A123detOpDsc", A123detOpDsc);
         n123detOpDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A123detOpDsc)) ? true : false);
         A124detOpFchIng = DateTime.MinValue;
         n124detOpFchIng = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A124detOpFchIng", context.localUtil.Format(A124detOpFchIng, "99/99/9999"));
         n124detOpFchIng = ((DateTime.MinValue==A124detOpFchIng) ? true : false);
         A127detOpFchIni = DateTime.MinValue;
         n127detOpFchIni = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127detOpFchIni", context.localUtil.Format(A127detOpFchIni, "99/99/9999"));
         n127detOpFchIni = ((DateTime.MinValue==A127detOpFchIni) ? true : false);
         A125detOpFchSalida = DateTime.MinValue;
         n125detOpFchSalida = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A125detOpFchSalida", context.localUtil.Format(A125detOpFchSalida, "99/99/9999"));
         n125detOpFchSalida = ((DateTime.MinValue==A125detOpFchSalida) ? true : false);
         A126detOpFchFin = DateTime.MinValue;
         n126detOpFchFin = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126detOpFchFin", context.localUtil.Format(A126detOpFchFin, "99/99/9999"));
         n126detOpFchFin = ((DateTime.MinValue==A126detOpFchFin) ? true : false);
         Z22OrdenID = 0;
         Z123detOpDsc = "";
         Z124detOpFchIng = DateTime.MinValue;
         Z127detOpFchIni = DateTime.MinValue;
         Z125detOpFchSalida = DateTime.MinValue;
         Z126detOpFchFin = DateTime.MinValue;
         Z19detOpID = 0;
      }

      protected void InitAll0818( )
      {
         A1EmpID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         A18detOpSec = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18detOpSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A18detOpSec), 4, 0)));
         InitializeNonKey0818( ) ;
      }

      protected void StandaloneModalInsert( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022102620133146", true);
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
         context.AddJavascriptSource("detopfchs.js", "?2022102620133146", false);
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
         edtdetOpSec_Internalname = "DETOPSEC";
         edtOrdenID_Internalname = "ORDENID";
         edtdetOpID_Internalname = "DETOPID";
         edtdetOpDsc_Internalname = "DETOPDSC";
         edtdetOpFchIng_Internalname = "DETOPFCHING";
         edtdetOpFchIni_Internalname = "DETOPFCHINI";
         edtdetOpFchSalida_Internalname = "DETOPFCHSALIDA";
         edtdetOpFchFin_Internalname = "DETOPFCHFIN";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_1_Internalname = "PROMPT_1";
         imgprompt_19_Internalname = "PROMPT_19";
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
         edtdetOpFchFin_Jsonclick = "";
         edtdetOpFchFin_Enabled = 1;
         edtdetOpFchSalida_Jsonclick = "";
         edtdetOpFchSalida_Enabled = 1;
         edtdetOpFchIni_Jsonclick = "";
         edtdetOpFchIni_Enabled = 1;
         edtdetOpFchIng_Jsonclick = "";
         edtdetOpFchIng_Enabled = 1;
         edtdetOpDsc_Jsonclick = "";
         edtdetOpDsc_Enabled = 1;
         imgprompt_19_Visible = 1;
         imgprompt_19_Link = "";
         edtdetOpID_Jsonclick = "";
         edtdetOpID_Enabled = 1;
         edtOrdenID_Jsonclick = "";
         edtOrdenID_Enabled = 1;
         edtdetOpSec_Jsonclick = "";
         edtdetOpSec_Enabled = 1;
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
         /* Using cursor T000815 */
         pr_default.execute(13, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A44empdsc = T000815_A44empdsc[0];
         n44empdsc = T000815_n44empdsc[0];
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

      public void Valid_Detopid( short GX_Parm1 ,
                                 short GX_Parm2 )
      {
         A1EmpID = GX_Parm1;
         A19detOpID = GX_Parm2;
         /* Using cursor T000817 */
         pr_default.execute(15, new Object[] {A1EmpID, A19detOpID});
         if ( (pr_default.getStatus(15) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Orden'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         pr_default.close(15);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV8detOpSec',fld:'vDETOPSEC',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV8detOpSec',fld:'vDETOPSEC',pic:'ZZZ9',hsh:true},{av:'AV12Insert_detOpID',fld:'vINSERT_DETOPID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12082',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV10TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(15);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z123detOpDsc = "";
         Z124detOpFchIng = DateTime.MinValue;
         Z127detOpFchIni = DateTime.MinValue;
         Z125detOpFchSalida = DateTime.MinValue;
         Z126detOpFchFin = DateTime.MinValue;
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
         A123detOpDsc = "";
         A124detOpFchIng = DateTime.MinValue;
         A127detOpFchIni = DateTime.MinValue;
         A125detOpFchSalida = DateTime.MinValue;
         A126detOpFchFin = DateTime.MinValue;
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         AV14Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode18 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV10TrnContext = new SdtTransactionContext(context);
         AV11WebSession = context.GetSession();
         AV13TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z44empdsc = "";
         T00084_A44empdsc = new String[] {""} ;
         T00084_n44empdsc = new bool[] {false} ;
         T00086_A18detOpSec = new short[1] ;
         T00086_A44empdsc = new String[] {""} ;
         T00086_n44empdsc = new bool[] {false} ;
         T00086_A22OrdenID = new short[1] ;
         T00086_A123detOpDsc = new String[] {""} ;
         T00086_n123detOpDsc = new bool[] {false} ;
         T00086_A124detOpFchIng = new DateTime[] {DateTime.MinValue} ;
         T00086_n124detOpFchIng = new bool[] {false} ;
         T00086_A127detOpFchIni = new DateTime[] {DateTime.MinValue} ;
         T00086_n127detOpFchIni = new bool[] {false} ;
         T00086_A125detOpFchSalida = new DateTime[] {DateTime.MinValue} ;
         T00086_n125detOpFchSalida = new bool[] {false} ;
         T00086_A126detOpFchFin = new DateTime[] {DateTime.MinValue} ;
         T00086_n126detOpFchFin = new bool[] {false} ;
         T00086_A1EmpID = new short[1] ;
         T00086_A19detOpID = new short[1] ;
         T00085_A17tipOrdID = new short[1] ;
         T00087_A44empdsc = new String[] {""} ;
         T00087_n44empdsc = new bool[] {false} ;
         T00088_A17tipOrdID = new short[1] ;
         T00089_A1EmpID = new short[1] ;
         T00089_A18detOpSec = new short[1] ;
         T00083_A18detOpSec = new short[1] ;
         T00083_A22OrdenID = new short[1] ;
         T00083_A123detOpDsc = new String[] {""} ;
         T00083_n123detOpDsc = new bool[] {false} ;
         T00083_A124detOpFchIng = new DateTime[] {DateTime.MinValue} ;
         T00083_n124detOpFchIng = new bool[] {false} ;
         T00083_A127detOpFchIni = new DateTime[] {DateTime.MinValue} ;
         T00083_n127detOpFchIni = new bool[] {false} ;
         T00083_A125detOpFchSalida = new DateTime[] {DateTime.MinValue} ;
         T00083_n125detOpFchSalida = new bool[] {false} ;
         T00083_A126detOpFchFin = new DateTime[] {DateTime.MinValue} ;
         T00083_n126detOpFchFin = new bool[] {false} ;
         T00083_A1EmpID = new short[1] ;
         T00083_A19detOpID = new short[1] ;
         T000810_A18detOpSec = new short[1] ;
         T000810_A1EmpID = new short[1] ;
         T000811_A18detOpSec = new short[1] ;
         T000811_A1EmpID = new short[1] ;
         T00082_A18detOpSec = new short[1] ;
         T00082_A22OrdenID = new short[1] ;
         T00082_A123detOpDsc = new String[] {""} ;
         T00082_n123detOpDsc = new bool[] {false} ;
         T00082_A124detOpFchIng = new DateTime[] {DateTime.MinValue} ;
         T00082_n124detOpFchIng = new bool[] {false} ;
         T00082_A127detOpFchIni = new DateTime[] {DateTime.MinValue} ;
         T00082_n127detOpFchIni = new bool[] {false} ;
         T00082_A125detOpFchSalida = new DateTime[] {DateTime.MinValue} ;
         T00082_n125detOpFchSalida = new bool[] {false} ;
         T00082_A126detOpFchFin = new DateTime[] {DateTime.MinValue} ;
         T00082_n126detOpFchFin = new bool[] {false} ;
         T00082_A1EmpID = new short[1] ;
         T00082_A19detOpID = new short[1] ;
         T000815_A44empdsc = new String[] {""} ;
         T000815_n44empdsc = new bool[] {false} ;
         T000816_A1EmpID = new short[1] ;
         T000816_A18detOpSec = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         T000817_A17tipOrdID = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.detopfchs__default(),
            new Object[][] {
                new Object[] {
               T00082_A18detOpSec, T00082_A22OrdenID, T00082_A123detOpDsc, T00082_n123detOpDsc, T00082_A124detOpFchIng, T00082_n124detOpFchIng, T00082_A127detOpFchIni, T00082_n127detOpFchIni, T00082_A125detOpFchSalida, T00082_n125detOpFchSalida,
               T00082_A126detOpFchFin, T00082_n126detOpFchFin, T00082_A1EmpID, T00082_A19detOpID
               }
               , new Object[] {
               T00083_A18detOpSec, T00083_A22OrdenID, T00083_A123detOpDsc, T00083_n123detOpDsc, T00083_A124detOpFchIng, T00083_n124detOpFchIng, T00083_A127detOpFchIni, T00083_n127detOpFchIni, T00083_A125detOpFchSalida, T00083_n125detOpFchSalida,
               T00083_A126detOpFchFin, T00083_n126detOpFchFin, T00083_A1EmpID, T00083_A19detOpID
               }
               , new Object[] {
               T00084_A44empdsc, T00084_n44empdsc
               }
               , new Object[] {
               T00085_A17tipOrdID
               }
               , new Object[] {
               T00086_A18detOpSec, T00086_A44empdsc, T00086_n44empdsc, T00086_A22OrdenID, T00086_A123detOpDsc, T00086_n123detOpDsc, T00086_A124detOpFchIng, T00086_n124detOpFchIng, T00086_A127detOpFchIni, T00086_n127detOpFchIni,
               T00086_A125detOpFchSalida, T00086_n125detOpFchSalida, T00086_A126detOpFchFin, T00086_n126detOpFchFin, T00086_A1EmpID, T00086_A19detOpID
               }
               , new Object[] {
               T00087_A44empdsc, T00087_n44empdsc
               }
               , new Object[] {
               T00088_A17tipOrdID
               }
               , new Object[] {
               T00089_A1EmpID, T00089_A18detOpSec
               }
               , new Object[] {
               T000810_A18detOpSec, T000810_A1EmpID
               }
               , new Object[] {
               T000811_A18detOpSec, T000811_A1EmpID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000815_A44empdsc, T000815_n44empdsc
               }
               , new Object[] {
               T000816_A1EmpID, T000816_A18detOpSec
               }
               , new Object[] {
               T000817_A17tipOrdID
               }
            }
         );
         AV14Pgmname = "detOpFchs";
      }

      private short wcpOAV7EmpID ;
      private short wcpOAV8detOpSec ;
      private short Z1EmpID ;
      private short Z18detOpSec ;
      private short Z22OrdenID ;
      private short Z19detOpID ;
      private short N19detOpID ;
      private short GxWebError ;
      private short A1EmpID ;
      private short A19detOpID ;
      private short AV7EmpID ;
      private short AV8detOpSec ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short A18detOpSec ;
      private short A22OrdenID ;
      private short AV12Insert_detOpID ;
      private short RcdFound18 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short A17tipOrdID ;
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
      private int edtdetOpSec_Enabled ;
      private int edtOrdenID_Enabled ;
      private int edtdetOpID_Enabled ;
      private int imgprompt_19_Visible ;
      private int edtdetOpDsc_Enabled ;
      private int edtdetOpFchIng_Enabled ;
      private int edtdetOpFchIni_Enabled ;
      private int edtdetOpFchSalida_Enabled ;
      private int edtdetOpFchFin_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int AV15GXV1 ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z123detOpDsc ;
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
      private String edtdetOpSec_Internalname ;
      private String edtdetOpSec_Jsonclick ;
      private String edtOrdenID_Internalname ;
      private String edtOrdenID_Jsonclick ;
      private String edtdetOpID_Internalname ;
      private String edtdetOpID_Jsonclick ;
      private String imgprompt_19_Internalname ;
      private String imgprompt_19_Link ;
      private String edtdetOpDsc_Internalname ;
      private String A123detOpDsc ;
      private String edtdetOpDsc_Jsonclick ;
      private String edtdetOpFchIng_Internalname ;
      private String edtdetOpFchIng_Jsonclick ;
      private String edtdetOpFchIni_Internalname ;
      private String edtdetOpFchIni_Jsonclick ;
      private String edtdetOpFchSalida_Internalname ;
      private String edtdetOpFchSalida_Jsonclick ;
      private String edtdetOpFchFin_Internalname ;
      private String edtdetOpFchFin_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String AV14Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode18 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private DateTime Z124detOpFchIng ;
      private DateTime Z127detOpFchIni ;
      private DateTime Z125detOpFchSalida ;
      private DateTime Z126detOpFchFin ;
      private DateTime A124detOpFchIng ;
      private DateTime A127detOpFchIni ;
      private DateTime A125detOpFchSalida ;
      private DateTime A126detOpFchFin ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n44empdsc ;
      private bool n123detOpDsc ;
      private bool n124detOpFchIng ;
      private bool n127detOpFchIni ;
      private bool n125detOpFchSalida ;
      private bool n126detOpFchFin ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private String A44empdsc ;
      private String Z44empdsc ;
      private IGxSession AV11WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T00084_A44empdsc ;
      private bool[] T00084_n44empdsc ;
      private short[] T00086_A18detOpSec ;
      private String[] T00086_A44empdsc ;
      private bool[] T00086_n44empdsc ;
      private short[] T00086_A22OrdenID ;
      private String[] T00086_A123detOpDsc ;
      private bool[] T00086_n123detOpDsc ;
      private DateTime[] T00086_A124detOpFchIng ;
      private bool[] T00086_n124detOpFchIng ;
      private DateTime[] T00086_A127detOpFchIni ;
      private bool[] T00086_n127detOpFchIni ;
      private DateTime[] T00086_A125detOpFchSalida ;
      private bool[] T00086_n125detOpFchSalida ;
      private DateTime[] T00086_A126detOpFchFin ;
      private bool[] T00086_n126detOpFchFin ;
      private short[] T00086_A1EmpID ;
      private short[] T00086_A19detOpID ;
      private short[] T00085_A17tipOrdID ;
      private String[] T00087_A44empdsc ;
      private bool[] T00087_n44empdsc ;
      private short[] T00088_A17tipOrdID ;
      private short[] T00089_A1EmpID ;
      private short[] T00089_A18detOpSec ;
      private short[] T00083_A18detOpSec ;
      private short[] T00083_A22OrdenID ;
      private String[] T00083_A123detOpDsc ;
      private bool[] T00083_n123detOpDsc ;
      private DateTime[] T00083_A124detOpFchIng ;
      private bool[] T00083_n124detOpFchIng ;
      private DateTime[] T00083_A127detOpFchIni ;
      private bool[] T00083_n127detOpFchIni ;
      private DateTime[] T00083_A125detOpFchSalida ;
      private bool[] T00083_n125detOpFchSalida ;
      private DateTime[] T00083_A126detOpFchFin ;
      private bool[] T00083_n126detOpFchFin ;
      private short[] T00083_A1EmpID ;
      private short[] T00083_A19detOpID ;
      private short[] T000810_A18detOpSec ;
      private short[] T000810_A1EmpID ;
      private short[] T000811_A18detOpSec ;
      private short[] T000811_A1EmpID ;
      private short[] T00082_A18detOpSec ;
      private short[] T00082_A22OrdenID ;
      private String[] T00082_A123detOpDsc ;
      private bool[] T00082_n123detOpDsc ;
      private DateTime[] T00082_A124detOpFchIng ;
      private bool[] T00082_n124detOpFchIng ;
      private DateTime[] T00082_A127detOpFchIni ;
      private bool[] T00082_n127detOpFchIni ;
      private DateTime[] T00082_A125detOpFchSalida ;
      private bool[] T00082_n125detOpFchSalida ;
      private DateTime[] T00082_A126detOpFchFin ;
      private bool[] T00082_n126detOpFchFin ;
      private short[] T00082_A1EmpID ;
      private short[] T00082_A19detOpID ;
      private String[] T000815_A44empdsc ;
      private bool[] T000815_n44empdsc ;
      private short[] T000816_A1EmpID ;
      private short[] T000816_A18detOpSec ;
      private short[] T000817_A17tipOrdID ;
      private SdtTransactionContext AV10TrnContext ;
      private SdtTransactionContext_Attribute AV13TrnContextAtt ;
   }

   public class detopfchs__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00086 ;
          prmT00086 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detOpSec",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00084 ;
          prmT00084 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00085 ;
          prmT00085 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detOpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00087 ;
          prmT00087 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00088 ;
          prmT00088 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detOpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00089 ;
          prmT00089 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detOpSec",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00083 ;
          prmT00083 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detOpSec",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000810 ;
          prmT000810 = new Object[] {
          new Object[] {"@detOpSec",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000811 ;
          prmT000811 = new Object[] {
          new Object[] {"@detOpSec",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00082 ;
          prmT00082 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detOpSec",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000812 ;
          prmT000812 = new Object[] {
          new Object[] {"@detOpSec",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detOpDsc",SqlDbType.Char,40,0} ,
          new Object[] {"@detOpFchIng",SqlDbType.DateTime,8,0} ,
          new Object[] {"@detOpFchIni",SqlDbType.DateTime,8,0} ,
          new Object[] {"@detOpFchSalida",SqlDbType.DateTime,8,0} ,
          new Object[] {"@detOpFchFin",SqlDbType.DateTime,8,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detOpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000813 ;
          prmT000813 = new Object[] {
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detOpDsc",SqlDbType.Char,40,0} ,
          new Object[] {"@detOpFchIng",SqlDbType.DateTime,8,0} ,
          new Object[] {"@detOpFchIni",SqlDbType.DateTime,8,0} ,
          new Object[] {"@detOpFchSalida",SqlDbType.DateTime,8,0} ,
          new Object[] {"@detOpFchFin",SqlDbType.DateTime,8,0} ,
          new Object[] {"@detOpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detOpSec",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000814 ;
          prmT000814 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detOpSec",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000816 ;
          prmT000816 = new Object[] {
          } ;
          Object[] prmT000815 ;
          prmT000815 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000817 ;
          prmT000817 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detOpID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00082", "SELECT [detOpSec], [OrdenID], [detOpDsc], [detOpFchIng], [detOpFchIni], [detOpFchSalida], [detOpFchFin], [EmpID], [detOpID] FROM [detOpFchs] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [detOpSec] = @detOpSec ",true, GxErrorMask.GX_NOMASK, false, this,prmT00082,1,0,true,false )
             ,new CursorDef("T00083", "SELECT [detOpSec], [OrdenID], [detOpDsc], [detOpFchIng], [detOpFchIni], [detOpFchSalida], [detOpFchFin], [EmpID], [detOpID] FROM [detOpFchs] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [detOpSec] = @detOpSec ",true, GxErrorMask.GX_NOMASK, false, this,prmT00083,1,0,true,false )
             ,new CursorDef("T00084", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00084,1,0,true,false )
             ,new CursorDef("T00085", "SELECT [tipOrdID] FROM [TipoOrdenPro] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [tipOrdID] = @detOpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00085,1,0,true,false )
             ,new CursorDef("T00086", "SELECT TM1.[detOpSec], T2.[empdsc], TM1.[OrdenID], TM1.[detOpDsc], TM1.[detOpFchIng], TM1.[detOpFchIni], TM1.[detOpFchSalida], TM1.[detOpFchFin], TM1.[EmpID], TM1.[detOpID] FROM ([detOpFchs] TM1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = TM1.[EmpID]) WHERE TM1.[EmpID] = @EmpID and TM1.[detOpSec] = @detOpSec ORDER BY TM1.[EmpID], TM1.[detOpSec]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00086,100,0,true,false )
             ,new CursorDef("T00087", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00087,1,0,true,false )
             ,new CursorDef("T00088", "SELECT [tipOrdID] FROM [TipoOrdenPro] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [tipOrdID] = @detOpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00088,1,0,true,false )
             ,new CursorDef("T00089", "SELECT [EmpID], [detOpSec] FROM [detOpFchs] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [detOpSec] = @detOpSec  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00089,1,0,true,false )
             ,new CursorDef("T000810", "SELECT TOP 1 [detOpSec], [EmpID] FROM [detOpFchs] WITH (NOLOCK) WHERE ( [detOpSec] > @detOpSec or [detOpSec] = @detOpSec and [EmpID] > @EmpID) ORDER BY [EmpID], [detOpSec]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000810,1,0,true,true )
             ,new CursorDef("T000811", "SELECT TOP 1 [detOpSec], [EmpID] FROM [detOpFchs] WITH (NOLOCK) WHERE ( [detOpSec] < @detOpSec or [detOpSec] = @detOpSec and [EmpID] < @EmpID) ORDER BY [EmpID] DESC, [detOpSec] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000811,1,0,true,true )
             ,new CursorDef("T000812", "INSERT INTO [detOpFchs]([detOpSec], [OrdenID], [detOpDsc], [detOpFchIng], [detOpFchIni], [detOpFchSalida], [detOpFchFin], [EmpID], [detOpID]) VALUES(@detOpSec, @OrdenID, @detOpDsc, @detOpFchIng, @detOpFchIni, @detOpFchSalida, @detOpFchFin, @EmpID, @detOpID)", GxErrorMask.GX_NOMASK,prmT000812)
             ,new CursorDef("T000813", "UPDATE [detOpFchs] SET [OrdenID]=@OrdenID, [detOpDsc]=@detOpDsc, [detOpFchIng]=@detOpFchIng, [detOpFchIni]=@detOpFchIni, [detOpFchSalida]=@detOpFchSalida, [detOpFchFin]=@detOpFchFin, [detOpID]=@detOpID  WHERE [EmpID] = @EmpID AND [detOpSec] = @detOpSec", GxErrorMask.GX_NOMASK,prmT000813)
             ,new CursorDef("T000814", "DELETE FROM [detOpFchs]  WHERE [EmpID] = @EmpID AND [detOpSec] = @detOpSec", GxErrorMask.GX_NOMASK,prmT000814)
             ,new CursorDef("T000815", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000815,1,0,true,false )
             ,new CursorDef("T000816", "SELECT [EmpID], [detOpSec] FROM [detOpFchs] WITH (NOLOCK) ORDER BY [EmpID], [detOpSec]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000816,100,0,true,false )
             ,new CursorDef("T000817", "SELECT [tipOrdID] FROM [TipoOrdenPro] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [tipOrdID] = @detOpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000817,1,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getString(3, 40) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(6) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[10])[0] = rslt.getGXDate(7) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(7);
                ((short[]) buf[12])[0] = rslt.getShort(8) ;
                ((short[]) buf[13])[0] = rslt.getShort(9) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 40) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(6) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[10])[0] = rslt.getGXDate(7) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(7);
                ((short[]) buf[12])[0] = rslt.getShort(8) ;
                ((short[]) buf[13])[0] = rslt.getShort(9) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((String[]) buf[4])[0] = rslt.getString(4, 40) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(6) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[10])[0] = rslt.getGXDate(7) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[12])[0] = rslt.getGXDate(8) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(8);
                ((short[]) buf[14])[0] = rslt.getShort(9) ;
                ((short[]) buf[15])[0] = rslt.getShort(10) ;
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 15 :
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
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
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
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 3 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 4 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(4, (DateTime)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 5 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(5, (DateTime)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 6 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(6, (DateTime)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 7 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(7, (DateTime)parms[11]);
                }
                stmt.SetParameter(8, (short)parms[12]);
                stmt.SetParameter(9, (short)parms[13]);
                return;
             case 11 :
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
                   stmt.setNull( 3 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(3, (DateTime)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 4 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(4, (DateTime)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 5 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(5, (DateTime)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 6 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(6, (DateTime)parms[10]);
                }
                stmt.SetParameter(7, (short)parms[11]);
                stmt.SetParameter(8, (short)parms[12]);
                stmt.SetParameter(9, (short)parms[13]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
       }
    }

 }

}
