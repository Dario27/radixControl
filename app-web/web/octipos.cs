/*
               File: Octipos
        Description: Octipos
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 11/19/2022 22:53:45.78
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
   public class octipos : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_12") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_12( A1EmpID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_13") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_13( A1EmpID, A2AgeID) ;
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
               AV8AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8AgeID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8AgeID), "ZZZ9"), context));
               AV9OcTipoCod = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9OcTipoCod", AV9OcTipoCod);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vOCTIPOCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV9OcTipoCod, "")), context));
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
            Form.Meta.addItem("description", "Octipos", 0) ;
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

      public octipos( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public octipos( IGxContext context )
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
                           short aP2_AgeID ,
                           String aP3_OcTipoCod )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7EmpID = aP1_EmpID;
         this.AV8AgeID = aP2_AgeID;
         this.AV9OcTipoCod = aP3_OcTipoCod;
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Octipos", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Octipos.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Octipos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Octipos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Octipos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Octipos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0220.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"AGEID"+"'), id:'"+"AGEID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"OCTIPOCOD"+"'), id:'"+"OCTIPOCOD"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_Octipos.htm");
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
            GxWebStd.gx_single_line_edit( context, edtEmpID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEmpID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEmpID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Octipos.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_1_Internalname, sImgUrl, imgprompt_1_Link, "", "", context.GetTheme( ), imgprompt_1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Octipos.htm");
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
            GxWebStd.gx_single_line_edit( context, edtempdsc_Internalname, A44empdsc, StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempdsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtempdsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Octipos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtAgeID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtAgeID_Internalname, "Age ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtAgeID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A2AgeID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A2AgeID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAgeID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtAgeID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Octipos.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_2_Internalname, sImgUrl, imgprompt_2_Link, "", "", context.GetTheme( ), imgprompt_2_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Octipos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtAgeDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtAgeDsc_Internalname, "Age Dsc", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtAgeDsc_Internalname, StringUtil.RTrim( A46AgeDsc), StringUtil.RTrim( context.localUtil.Format( A46AgeDsc, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAgeDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtAgeDsc_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "Descripcion", "left", true, "HLP_Octipos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOcTipoCod_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOcTipoCod_Internalname, "Cod", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtOcTipoCod_Internalname, StringUtil.RTrim( A311OcTipoCod), StringUtil.RTrim( context.localUtil.Format( A311OcTipoCod, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOcTipoCod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOcTipoCod_Enabled, 1, "text", "", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Octipos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOctipFch_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOctipFch_Internalname, "Fecha", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtOctipFch_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtOctipFch_Internalname, context.localUtil.Format(A312OctipFch, "99/99/99"), context.localUtil.Format( A312OctipFch, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOctipFch_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOctipFch_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Octipos.htm");
            GxWebStd.gx_bitmap( context, edtOctipFch_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtOctipFch_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Octipos.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOctipDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOctipDsc_Internalname, "Dsc", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtOctipDsc_Internalname, StringUtil.RTrim( A313OctipDsc), StringUtil.RTrim( context.localUtil.Format( A313OctipDsc, "@!")), TempTags+" onchange=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOctipDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOctipDsc_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "nombres", "left", true, "HLP_Octipos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOctipEst_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOctipEst_Internalname, "Estado", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtOctipEst_Internalname, StringUtil.RTrim( A314OctipEst), StringUtil.RTrim( context.localUtil.Format( A314OctipEst, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,69);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOctipEst_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOctipEst_Enabled, 0, "text", "", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, -1, true, "estado", "left", true, "HLP_Octipos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOctipInvCod_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOctipInvCod_Internalname, "Inv Cod", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtOctipInvCod_Internalname, StringUtil.RTrim( A315OctipInvCod), StringUtil.RTrim( context.localUtil.Format( A315OctipInvCod, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,74);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOctipInvCod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOctipInvCod_Enabled, 0, "text", "", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Octipos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOctipInvFch_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOctipInvFch_Internalname, "fecha OC", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 79,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtOctipInvFch_Internalname, StringUtil.RTrim( A316OctipInvFch), StringUtil.RTrim( context.localUtil.Format( A316OctipInvFch, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,79);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOctipInvFch_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOctipInvFch_Enabled, 0, "text", "", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Octipos.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Octipos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Octipos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 88,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Octipos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm0W74( ) ;
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
         E110W2 ();
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtAgeID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtAgeID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "AGEID");
                  AnyError = 1;
                  GX_FocusControl = edtAgeID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A2AgeID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
               }
               else
               {
                  A2AgeID = (short)(context.localUtil.CToN( cgiGet( edtAgeID_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
               }
               A46AgeDsc = cgiGet( edtAgeDsc_Internalname);
               n46AgeDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
               A311OcTipoCod = cgiGet( edtOcTipoCod_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311OcTipoCod", A311OcTipoCod);
               if ( context.localUtil.VCDate( cgiGet( edtOctipFch_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha"}), 1, "OCTIPFCH");
                  AnyError = 1;
                  GX_FocusControl = edtOctipFch_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A312OctipFch = DateTime.MinValue;
                  n312OctipFch = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A312OctipFch", context.localUtil.Format(A312OctipFch, "99/99/99"));
               }
               else
               {
                  A312OctipFch = context.localUtil.CToD( cgiGet( edtOctipFch_Internalname), 2);
                  n312OctipFch = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A312OctipFch", context.localUtil.Format(A312OctipFch, "99/99/99"));
               }
               n312OctipFch = ((DateTime.MinValue==A312OctipFch) ? true : false);
               A313OctipDsc = StringUtil.Upper( cgiGet( edtOctipDsc_Internalname));
               n313OctipDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313OctipDsc", A313OctipDsc);
               n313OctipDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A313OctipDsc)) ? true : false);
               A314OctipEst = cgiGet( edtOctipEst_Internalname);
               n314OctipEst = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A314OctipEst", A314OctipEst);
               n314OctipEst = (String.IsNullOrEmpty(StringUtil.RTrim( A314OctipEst)) ? true : false);
               A315OctipInvCod = cgiGet( edtOctipInvCod_Internalname);
               n315OctipInvCod = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315OctipInvCod", A315OctipInvCod);
               n315OctipInvCod = (String.IsNullOrEmpty(StringUtil.RTrim( A315OctipInvCod)) ? true : false);
               A316OctipInvFch = cgiGet( edtOctipInvFch_Internalname);
               n316OctipInvFch = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A316OctipInvFch", A316OctipInvFch);
               n316OctipInvFch = (String.IsNullOrEmpty(StringUtil.RTrim( A316OctipInvFch)) ? true : false);
               /* Read saved values. */
               Z1EmpID = (short)(context.localUtil.CToN( cgiGet( "Z1EmpID"), ",", "."));
               Z2AgeID = (short)(context.localUtil.CToN( cgiGet( "Z2AgeID"), ",", "."));
               Z311OcTipoCod = cgiGet( "Z311OcTipoCod");
               Z312OctipFch = context.localUtil.CToD( cgiGet( "Z312OctipFch"), 0);
               n312OctipFch = ((DateTime.MinValue==A312OctipFch) ? true : false);
               Z313OctipDsc = cgiGet( "Z313OctipDsc");
               n313OctipDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A313OctipDsc)) ? true : false);
               Z314OctipEst = cgiGet( "Z314OctipEst");
               n314OctipEst = (String.IsNullOrEmpty(StringUtil.RTrim( A314OctipEst)) ? true : false);
               Z315OctipInvCod = cgiGet( "Z315OctipInvCod");
               n315OctipInvCod = (String.IsNullOrEmpty(StringUtil.RTrim( A315OctipInvCod)) ? true : false);
               Z316OctipInvFch = cgiGet( "Z316OctipInvFch");
               n316OctipInvFch = (String.IsNullOrEmpty(StringUtil.RTrim( A316OctipInvFch)) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               AV7EmpID = (short)(context.localUtil.CToN( cgiGet( "vEMPID"), ",", "."));
               AV8AgeID = (short)(context.localUtil.CToN( cgiGet( "vAGEID"), ",", "."));
               AV9OcTipoCod = cgiGet( "vOCTIPOCOD");
               AV13Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Octipos";
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( StringUtil.StrCmp(A311OcTipoCod, Z311OcTipoCod) != 0 ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("octipos:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A2AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
                  A311OcTipoCod = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311OcTipoCod", A311OcTipoCod);
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
                     sMode74 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode74;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound74 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0W0( ) ;
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
                        E110W2 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: After Trn */
                        E120W2 ();
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
            E120W2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0W74( ) ;
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
            DisableAttributes0W74( ) ;
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

      protected void CONFIRM_0W0( )
      {
         BeforeValidate0W74( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0W74( ) ;
            }
            else
            {
               CheckExtendedTable0W74( ) ;
               CloseExtendedTableCursors0W74( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0W0( )
      {
      }

      protected void E110W2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV13Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "TransactionContext", "KBCalpesa22");
      }

      protected void E120W2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV11TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwoctipos.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0W74( short GX_JID )
      {
         if ( ( GX_JID == 11 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z312OctipFch = T000W3_A312OctipFch[0];
               Z313OctipDsc = T000W3_A313OctipDsc[0];
               Z314OctipEst = T000W3_A314OctipEst[0];
               Z315OctipInvCod = T000W3_A315OctipInvCod[0];
               Z316OctipInvFch = T000W3_A316OctipInvFch[0];
            }
            else
            {
               Z312OctipFch = A312OctipFch;
               Z313OctipDsc = A313OctipDsc;
               Z314OctipEst = A314OctipEst;
               Z315OctipInvCod = A315OctipInvCod;
               Z316OctipInvFch = A316OctipInvFch;
            }
         }
         if ( GX_JID == -11 )
         {
            Z311OcTipoCod = A311OcTipoCod;
            Z312OctipFch = A312OctipFch;
            Z313OctipDsc = A313OctipDsc;
            Z314OctipEst = A314OctipEst;
            Z315OctipInvCod = A315OctipInvCod;
            Z316OctipInvFch = A316OctipInvFch;
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z44empdsc = A44empdsc;
            Z46AgeDsc = A46AgeDsc;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_1_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_2_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0021.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"AGEID"+"'), id:'"+"AGEID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
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
         if ( ! (0==AV8AgeID) )
         {
            A2AgeID = AV8AgeID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
         }
         if ( ! (0==AV8AgeID) )
         {
            edtAgeID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAgeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAgeID_Enabled), 5, 0)), true);
         }
         else
         {
            edtAgeID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAgeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAgeID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV8AgeID) )
         {
            edtAgeID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAgeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAgeID_Enabled), 5, 0)), true);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9OcTipoCod)) )
         {
            A311OcTipoCod = AV9OcTipoCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311OcTipoCod", A311OcTipoCod);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9OcTipoCod)) )
         {
            edtOcTipoCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOcTipoCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOcTipoCod_Enabled), 5, 0)), true);
         }
         else
         {
            edtOcTipoCod_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOcTipoCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOcTipoCod_Enabled), 5, 0)), true);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9OcTipoCod)) )
         {
            edtOcTipoCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOcTipoCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOcTipoCod_Enabled), 5, 0)), true);
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
            /* Using cursor T000W4 */
            pr_default.execute(2, new Object[] {A1EmpID});
            A44empdsc = T000W4_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000W4_n44empdsc[0];
            pr_default.close(2);
            AV13Pgmname = "Octipos";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
            /* Using cursor T000W5 */
            pr_default.execute(3, new Object[] {A1EmpID, A2AgeID});
            A46AgeDsc = T000W5_A46AgeDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
            n46AgeDsc = T000W5_n46AgeDsc[0];
            pr_default.close(3);
         }
      }

      protected void Load0W74( )
      {
         /* Using cursor T000W6 */
         pr_default.execute(4, new Object[] {A1EmpID, A2AgeID, A311OcTipoCod});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound74 = 1;
            A44empdsc = T000W6_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000W6_n44empdsc[0];
            A46AgeDsc = T000W6_A46AgeDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
            n46AgeDsc = T000W6_n46AgeDsc[0];
            A312OctipFch = T000W6_A312OctipFch[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A312OctipFch", context.localUtil.Format(A312OctipFch, "99/99/99"));
            n312OctipFch = T000W6_n312OctipFch[0];
            A313OctipDsc = T000W6_A313OctipDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313OctipDsc", A313OctipDsc);
            n313OctipDsc = T000W6_n313OctipDsc[0];
            A314OctipEst = T000W6_A314OctipEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A314OctipEst", A314OctipEst);
            n314OctipEst = T000W6_n314OctipEst[0];
            A315OctipInvCod = T000W6_A315OctipInvCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315OctipInvCod", A315OctipInvCod);
            n315OctipInvCod = T000W6_n315OctipInvCod[0];
            A316OctipInvFch = T000W6_A316OctipInvFch[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A316OctipInvFch", A316OctipInvFch);
            n316OctipInvFch = T000W6_n316OctipInvFch[0];
            ZM0W74( -11) ;
         }
         pr_default.close(4);
         OnLoadActions0W74( ) ;
      }

      protected void OnLoadActions0W74( )
      {
         AV13Pgmname = "Octipos";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
      }

      protected void CheckExtendedTable0W74( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV13Pgmname = "Octipos";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
         /* Using cursor T000W4 */
         pr_default.execute(2, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000W4_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T000W4_n44empdsc[0];
         pr_default.close(2);
         /* Using cursor T000W5 */
         pr_default.execute(3, new Object[] {A1EmpID, A2AgeID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("No existe 'Agencias'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A46AgeDsc = T000W5_A46AgeDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
         n46AgeDsc = T000W5_n46AgeDsc[0];
         pr_default.close(3);
         if ( ! ( (DateTime.MinValue==A312OctipFch) || ( A312OctipFch >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha fuera de rango", "OutOfRange", 1, "OCTIPFCH");
            AnyError = 1;
            GX_FocusControl = edtOctipFch_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0W74( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_12( short A1EmpID )
      {
         /* Using cursor T000W7 */
         pr_default.execute(5, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000W7_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T000W7_n44empdsc[0];
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

      protected void gxLoad_13( short A1EmpID ,
                                short A2AgeID )
      {
         /* Using cursor T000W8 */
         pr_default.execute(6, new Object[] {A1EmpID, A2AgeID});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No existe 'Agencias'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A46AgeDsc = T000W8_A46AgeDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
         n46AgeDsc = T000W8_n46AgeDsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A46AgeDsc))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(6);
      }

      protected void GetKey0W74( )
      {
         /* Using cursor T000W9 */
         pr_default.execute(7, new Object[] {A1EmpID, A2AgeID, A311OcTipoCod});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound74 = 1;
         }
         else
         {
            RcdFound74 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000W3 */
         pr_default.execute(1, new Object[] {A1EmpID, A2AgeID, A311OcTipoCod});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0W74( 11) ;
            RcdFound74 = 1;
            A311OcTipoCod = T000W3_A311OcTipoCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311OcTipoCod", A311OcTipoCod);
            A312OctipFch = T000W3_A312OctipFch[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A312OctipFch", context.localUtil.Format(A312OctipFch, "99/99/99"));
            n312OctipFch = T000W3_n312OctipFch[0];
            A313OctipDsc = T000W3_A313OctipDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313OctipDsc", A313OctipDsc);
            n313OctipDsc = T000W3_n313OctipDsc[0];
            A314OctipEst = T000W3_A314OctipEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A314OctipEst", A314OctipEst);
            n314OctipEst = T000W3_n314OctipEst[0];
            A315OctipInvCod = T000W3_A315OctipInvCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315OctipInvCod", A315OctipInvCod);
            n315OctipInvCod = T000W3_n315OctipInvCod[0];
            A316OctipInvFch = T000W3_A316OctipInvFch[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A316OctipInvFch", A316OctipInvFch);
            n316OctipInvFch = T000W3_n316OctipInvFch[0];
            A1EmpID = T000W3_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = T000W3_A2AgeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z311OcTipoCod = A311OcTipoCod;
            sMode74 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0W74( ) ;
            if ( AnyError == 1 )
            {
               RcdFound74 = 0;
               InitializeNonKey0W74( ) ;
            }
            Gx_mode = sMode74;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound74 = 0;
            InitializeNonKey0W74( ) ;
            sMode74 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode74;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0W74( ) ;
         if ( RcdFound74 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound74 = 0;
         /* Using cursor T000W10 */
         pr_default.execute(8, new Object[] {A1EmpID, A2AgeID, A311OcTipoCod});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000W10_A1EmpID[0] < A1EmpID ) || ( T000W10_A1EmpID[0] == A1EmpID ) && ( T000W10_A2AgeID[0] < A2AgeID ) || ( T000W10_A2AgeID[0] == A2AgeID ) && ( T000W10_A1EmpID[0] == A1EmpID ) && ( StringUtil.StrCmp(T000W10_A311OcTipoCod[0], A311OcTipoCod) < 0 ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000W10_A1EmpID[0] > A1EmpID ) || ( T000W10_A1EmpID[0] == A1EmpID ) && ( T000W10_A2AgeID[0] > A2AgeID ) || ( T000W10_A2AgeID[0] == A2AgeID ) && ( T000W10_A1EmpID[0] == A1EmpID ) && ( StringUtil.StrCmp(T000W10_A311OcTipoCod[0], A311OcTipoCod) > 0 ) ) )
            {
               A1EmpID = T000W10_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A2AgeID = T000W10_A2AgeID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
               A311OcTipoCod = T000W10_A311OcTipoCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311OcTipoCod", A311OcTipoCod);
               RcdFound74 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound74 = 0;
         /* Using cursor T000W11 */
         pr_default.execute(9, new Object[] {A1EmpID, A2AgeID, A311OcTipoCod});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000W11_A1EmpID[0] > A1EmpID ) || ( T000W11_A1EmpID[0] == A1EmpID ) && ( T000W11_A2AgeID[0] > A2AgeID ) || ( T000W11_A2AgeID[0] == A2AgeID ) && ( T000W11_A1EmpID[0] == A1EmpID ) && ( StringUtil.StrCmp(T000W11_A311OcTipoCod[0], A311OcTipoCod) > 0 ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000W11_A1EmpID[0] < A1EmpID ) || ( T000W11_A1EmpID[0] == A1EmpID ) && ( T000W11_A2AgeID[0] < A2AgeID ) || ( T000W11_A2AgeID[0] == A2AgeID ) && ( T000W11_A1EmpID[0] == A1EmpID ) && ( StringUtil.StrCmp(T000W11_A311OcTipoCod[0], A311OcTipoCod) < 0 ) ) )
            {
               A1EmpID = T000W11_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A2AgeID = T000W11_A2AgeID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
               A311OcTipoCod = T000W11_A311OcTipoCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311OcTipoCod", A311OcTipoCod);
               RcdFound74 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0W74( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0W74( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound74 == 1 )
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( StringUtil.StrCmp(A311OcTipoCod, Z311OcTipoCod) != 0 ) )
               {
                  A1EmpID = Z1EmpID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
                  A2AgeID = Z2AgeID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
                  A311OcTipoCod = Z311OcTipoCod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311OcTipoCod", A311OcTipoCod);
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
                  Update0W74( ) ;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( StringUtil.StrCmp(A311OcTipoCod, Z311OcTipoCod) != 0 ) )
               {
                  /* Insert record */
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0W74( ) ;
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
                     Insert0W74( ) ;
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
         if ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( StringUtil.StrCmp(A311OcTipoCod, Z311OcTipoCod) != 0 ) )
         {
            A1EmpID = Z1EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = Z2AgeID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A311OcTipoCod = Z311OcTipoCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311OcTipoCod", A311OcTipoCod);
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

      protected void CheckOptimisticConcurrency0W74( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000W2 */
            pr_default.execute(0, new Object[] {A1EmpID, A2AgeID, A311OcTipoCod});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Octipos"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z312OctipFch != T000W2_A312OctipFch[0] ) || ( StringUtil.StrCmp(Z313OctipDsc, T000W2_A313OctipDsc[0]) != 0 ) || ( StringUtil.StrCmp(Z314OctipEst, T000W2_A314OctipEst[0]) != 0 ) || ( StringUtil.StrCmp(Z315OctipInvCod, T000W2_A315OctipInvCod[0]) != 0 ) || ( StringUtil.StrCmp(Z316OctipInvFch, T000W2_A316OctipInvFch[0]) != 0 ) )
            {
               if ( Z312OctipFch != T000W2_A312OctipFch[0] )
               {
                  GXUtil.WriteLog("octipos:[seudo value changed for attri]"+"OctipFch");
                  GXUtil.WriteLogRaw("Old: ",Z312OctipFch);
                  GXUtil.WriteLogRaw("Current: ",T000W2_A312OctipFch[0]);
               }
               if ( StringUtil.StrCmp(Z313OctipDsc, T000W2_A313OctipDsc[0]) != 0 )
               {
                  GXUtil.WriteLog("octipos:[seudo value changed for attri]"+"OctipDsc");
                  GXUtil.WriteLogRaw("Old: ",Z313OctipDsc);
                  GXUtil.WriteLogRaw("Current: ",T000W2_A313OctipDsc[0]);
               }
               if ( StringUtil.StrCmp(Z314OctipEst, T000W2_A314OctipEst[0]) != 0 )
               {
                  GXUtil.WriteLog("octipos:[seudo value changed for attri]"+"OctipEst");
                  GXUtil.WriteLogRaw("Old: ",Z314OctipEst);
                  GXUtil.WriteLogRaw("Current: ",T000W2_A314OctipEst[0]);
               }
               if ( StringUtil.StrCmp(Z315OctipInvCod, T000W2_A315OctipInvCod[0]) != 0 )
               {
                  GXUtil.WriteLog("octipos:[seudo value changed for attri]"+"OctipInvCod");
                  GXUtil.WriteLogRaw("Old: ",Z315OctipInvCod);
                  GXUtil.WriteLogRaw("Current: ",T000W2_A315OctipInvCod[0]);
               }
               if ( StringUtil.StrCmp(Z316OctipInvFch, T000W2_A316OctipInvFch[0]) != 0 )
               {
                  GXUtil.WriteLog("octipos:[seudo value changed for attri]"+"OctipInvFch");
                  GXUtil.WriteLogRaw("Old: ",Z316OctipInvFch);
                  GXUtil.WriteLogRaw("Current: ",T000W2_A316OctipInvFch[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Octipos"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0W74( )
      {
         BeforeValidate0W74( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0W74( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0W74( 0) ;
            CheckOptimisticConcurrency0W74( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0W74( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0W74( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000W12 */
                     pr_default.execute(10, new Object[] {A311OcTipoCod, n312OctipFch, A312OctipFch, n313OctipDsc, A313OctipDsc, n314OctipEst, A314OctipEst, n315OctipInvCod, A315OctipInvCod, n316OctipInvFch, A316OctipInvFch, A1EmpID, A2AgeID});
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("Octipos") ;
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
                           ResetCaption0W0( ) ;
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
               Load0W74( ) ;
            }
            EndLevel0W74( ) ;
         }
         CloseExtendedTableCursors0W74( ) ;
      }

      protected void Update0W74( )
      {
         BeforeValidate0W74( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0W74( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0W74( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0W74( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0W74( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000W13 */
                     pr_default.execute(11, new Object[] {n312OctipFch, A312OctipFch, n313OctipDsc, A313OctipDsc, n314OctipEst, A314OctipEst, n315OctipInvCod, A315OctipInvCod, n316OctipInvFch, A316OctipInvFch, A1EmpID, A2AgeID, A311OcTipoCod});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("Octipos") ;
                     if ( (pr_default.getStatus(11) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Octipos"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0W74( ) ;
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
            EndLevel0W74( ) ;
         }
         CloseExtendedTableCursors0W74( ) ;
      }

      protected void DeferredUpdate0W74( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0W74( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0W74( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0W74( ) ;
            AfterConfirm0W74( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0W74( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000W14 */
                  pr_default.execute(12, new Object[] {A1EmpID, A2AgeID, A311OcTipoCod});
                  pr_default.close(12);
                  dsDefault.SmartCacheProvider.SetUpdated("Octipos") ;
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
         sMode74 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0W74( ) ;
         Gx_mode = sMode74;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0W74( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV13Pgmname = "Octipos";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
            /* Using cursor T000W15 */
            pr_default.execute(13, new Object[] {A1EmpID});
            A44empdsc = T000W15_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000W15_n44empdsc[0];
            pr_default.close(13);
            /* Using cursor T000W16 */
            pr_default.execute(14, new Object[] {A1EmpID, A2AgeID});
            A46AgeDsc = T000W16_A46AgeDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
            n46AgeDsc = T000W16_n46AgeDsc[0];
            pr_default.close(14);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000W17 */
            pr_default.execute(15, new Object[] {A1EmpID, A2AgeID, A311OcTipoCod});
            if ( (pr_default.getStatus(15) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Orden Compra"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(15);
         }
      }

      protected void EndLevel0W74( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0W74( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(13);
            pr_default.close(14);
            context.CommitDataStores("octipos",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0W0( ) ;
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
            context.RollbackDataStores("octipos",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0W74( )
      {
         /* Scan By routine */
         /* Using cursor T000W18 */
         pr_default.execute(16);
         RcdFound74 = 0;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound74 = 1;
            A1EmpID = T000W18_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = T000W18_A2AgeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A311OcTipoCod = T000W18_A311OcTipoCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311OcTipoCod", A311OcTipoCod);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0W74( )
      {
         /* Scan next routine */
         pr_default.readNext(16);
         RcdFound74 = 0;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound74 = 1;
            A1EmpID = T000W18_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = T000W18_A2AgeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A311OcTipoCod = T000W18_A311OcTipoCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311OcTipoCod", A311OcTipoCod);
         }
      }

      protected void ScanEnd0W74( )
      {
         pr_default.close(16);
      }

      protected void AfterConfirm0W74( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0W74( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0W74( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0W74( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0W74( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0W74( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0W74( )
      {
         edtEmpID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         edtempdsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempdsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempdsc_Enabled), 5, 0)), true);
         edtAgeID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAgeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAgeID_Enabled), 5, 0)), true);
         edtAgeDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAgeDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAgeDsc_Enabled), 5, 0)), true);
         edtOcTipoCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOcTipoCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOcTipoCod_Enabled), 5, 0)), true);
         edtOctipFch_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOctipFch_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOctipFch_Enabled), 5, 0)), true);
         edtOctipDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOctipDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOctipDsc_Enabled), 5, 0)), true);
         edtOctipEst_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOctipEst_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOctipEst_Enabled), 5, 0)), true);
         edtOctipInvCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOctipInvCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOctipInvCod_Enabled), 5, 0)), true);
         edtOctipInvFch_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOctipInvFch_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOctipInvFch_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0W74( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0W0( )
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
         context.SendWebValue( "Octipos") ;
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
         context.AddJavascriptSource("gxcfg.js", "?2022111922534821", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("octipos.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7EmpID) + "," + UrlEncode("" +AV8AgeID) + "," + UrlEncode(StringUtil.RTrim(AV9OcTipoCod))+"\">") ;
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
         forbiddenHiddens = "hsh" + "Octipos";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("octipos:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1EmpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z2AgeID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z2AgeID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z311OcTipoCod", StringUtil.RTrim( Z311OcTipoCod));
         GxWebStd.gx_hidden_field( context, "Z312OctipFch", context.localUtil.DToC( Z312OctipFch, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z313OctipDsc", StringUtil.RTrim( Z313OctipDsc));
         GxWebStd.gx_hidden_field( context, "Z314OctipEst", StringUtil.RTrim( Z314OctipEst));
         GxWebStd.gx_hidden_field( context, "Z315OctipInvCod", StringUtil.RTrim( Z315OctipInvCod));
         GxWebStd.gx_hidden_field( context, "Z316OctipInvFch", StringUtil.RTrim( Z316OctipInvFch));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV11TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV11TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EmpID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8AgeID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8AgeID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vOCTIPOCOD", StringUtil.RTrim( AV9OcTipoCod));
         GxWebStd.gx_hidden_field( context, "gxhash_vOCTIPOCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV9OcTipoCod, "")), context));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV13Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void RenderHtmlCloseForm0W74( )
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
         return "Octipos" ;
      }

      public override String GetPgmdesc( )
      {
         return "Octipos" ;
      }

      protected void InitializeNonKey0W74( )
      {
         A44empdsc = "";
         n44empdsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         A46AgeDsc = "";
         n46AgeDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
         A312OctipFch = DateTime.MinValue;
         n312OctipFch = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A312OctipFch", context.localUtil.Format(A312OctipFch, "99/99/99"));
         n312OctipFch = ((DateTime.MinValue==A312OctipFch) ? true : false);
         A313OctipDsc = "";
         n313OctipDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313OctipDsc", A313OctipDsc);
         n313OctipDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A313OctipDsc)) ? true : false);
         A314OctipEst = "";
         n314OctipEst = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A314OctipEst", A314OctipEst);
         n314OctipEst = (String.IsNullOrEmpty(StringUtil.RTrim( A314OctipEst)) ? true : false);
         A315OctipInvCod = "";
         n315OctipInvCod = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315OctipInvCod", A315OctipInvCod);
         n315OctipInvCod = (String.IsNullOrEmpty(StringUtil.RTrim( A315OctipInvCod)) ? true : false);
         A316OctipInvFch = "";
         n316OctipInvFch = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A316OctipInvFch", A316OctipInvFch);
         n316OctipInvFch = (String.IsNullOrEmpty(StringUtil.RTrim( A316OctipInvFch)) ? true : false);
         Z312OctipFch = DateTime.MinValue;
         Z313OctipDsc = "";
         Z314OctipEst = "";
         Z315OctipInvCod = "";
         Z316OctipInvFch = "";
      }

      protected void InitAll0W74( )
      {
         A1EmpID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         A2AgeID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
         A311OcTipoCod = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311OcTipoCod", A311OcTipoCod);
         InitializeNonKey0W74( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022111922534835", true);
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
         context.AddJavascriptSource("octipos.js", "?2022111922534835", false);
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
         edtAgeID_Internalname = "AGEID";
         edtAgeDsc_Internalname = "AGEDSC";
         edtOcTipoCod_Internalname = "OCTIPOCOD";
         edtOctipFch_Internalname = "OCTIPFCH";
         edtOctipDsc_Internalname = "OCTIPDSC";
         edtOctipEst_Internalname = "OCTIPEST";
         edtOctipInvCod_Internalname = "OCTIPINVCOD";
         edtOctipInvFch_Internalname = "OCTIPINVFCH";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_1_Internalname = "PROMPT_1";
         imgprompt_2_Internalname = "PROMPT_2";
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
         edtOctipInvFch_Jsonclick = "";
         edtOctipInvFch_Enabled = 1;
         edtOctipInvCod_Jsonclick = "";
         edtOctipInvCod_Enabled = 1;
         edtOctipEst_Jsonclick = "";
         edtOctipEst_Enabled = 1;
         edtOctipDsc_Jsonclick = "";
         edtOctipDsc_Enabled = 1;
         edtOctipFch_Jsonclick = "";
         edtOctipFch_Enabled = 1;
         edtOcTipoCod_Jsonclick = "";
         edtOcTipoCod_Enabled = 1;
         edtAgeDsc_Jsonclick = "";
         edtAgeDsc_Enabled = 0;
         imgprompt_2_Visible = 1;
         imgprompt_2_Link = "";
         edtAgeID_Jsonclick = "";
         edtAgeID_Enabled = 1;
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
         /* Using cursor T000W15 */
         pr_default.execute(13, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A44empdsc = T000W15_A44empdsc[0];
         n44empdsc = T000W15_n44empdsc[0];
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

      public void Valid_Ageid( short GX_Parm1 ,
                               short GX_Parm2 ,
                               String GX_Parm3 )
      {
         A1EmpID = GX_Parm1;
         A2AgeID = GX_Parm2;
         A46AgeDsc = GX_Parm3;
         n46AgeDsc = false;
         /* Using cursor T000W16 */
         pr_default.execute(14, new Object[] {A1EmpID, A2AgeID});
         if ( (pr_default.getStatus(14) == 101) )
         {
            GX_msglist.addItem("No existe 'Agencias'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A46AgeDsc = T000W16_A46AgeDsc[0];
         n46AgeDsc = T000W16_n46AgeDsc[0];
         pr_default.close(14);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A46AgeDsc = "";
            n46AgeDsc = false;
         }
         isValidOutput.Add(StringUtil.RTrim( A46AgeDsc));
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV8AgeID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV9OcTipoCod',fld:'vOCTIPOCOD',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV8AgeID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV9OcTipoCod',fld:'vOCTIPOCOD',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120W2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         wcpOAV9OcTipoCod = "";
         Z311OcTipoCod = "";
         Z312OctipFch = DateTime.MinValue;
         Z313OctipDsc = "";
         Z314OctipEst = "";
         Z315OctipInvCod = "";
         Z316OctipInvFch = "";
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
         A46AgeDsc = "";
         A311OcTipoCod = "";
         A312OctipFch = DateTime.MinValue;
         A313OctipDsc = "";
         A314OctipEst = "";
         A315OctipInvCod = "";
         A316OctipInvFch = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         AV13Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode74 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV11TrnContext = new SdtTransactionContext(context);
         AV12WebSession = context.GetSession();
         Z44empdsc = "";
         Z46AgeDsc = "";
         T000W4_A44empdsc = new String[] {""} ;
         T000W4_n44empdsc = new bool[] {false} ;
         T000W5_A46AgeDsc = new String[] {""} ;
         T000W5_n46AgeDsc = new bool[] {false} ;
         T000W6_A311OcTipoCod = new String[] {""} ;
         T000W6_A44empdsc = new String[] {""} ;
         T000W6_n44empdsc = new bool[] {false} ;
         T000W6_A46AgeDsc = new String[] {""} ;
         T000W6_n46AgeDsc = new bool[] {false} ;
         T000W6_A312OctipFch = new DateTime[] {DateTime.MinValue} ;
         T000W6_n312OctipFch = new bool[] {false} ;
         T000W6_A313OctipDsc = new String[] {""} ;
         T000W6_n313OctipDsc = new bool[] {false} ;
         T000W6_A314OctipEst = new String[] {""} ;
         T000W6_n314OctipEst = new bool[] {false} ;
         T000W6_A315OctipInvCod = new String[] {""} ;
         T000W6_n315OctipInvCod = new bool[] {false} ;
         T000W6_A316OctipInvFch = new String[] {""} ;
         T000W6_n316OctipInvFch = new bool[] {false} ;
         T000W6_A1EmpID = new short[1] ;
         T000W6_A2AgeID = new short[1] ;
         T000W7_A44empdsc = new String[] {""} ;
         T000W7_n44empdsc = new bool[] {false} ;
         T000W8_A46AgeDsc = new String[] {""} ;
         T000W8_n46AgeDsc = new bool[] {false} ;
         T000W9_A1EmpID = new short[1] ;
         T000W9_A2AgeID = new short[1] ;
         T000W9_A311OcTipoCod = new String[] {""} ;
         T000W3_A311OcTipoCod = new String[] {""} ;
         T000W3_A312OctipFch = new DateTime[] {DateTime.MinValue} ;
         T000W3_n312OctipFch = new bool[] {false} ;
         T000W3_A313OctipDsc = new String[] {""} ;
         T000W3_n313OctipDsc = new bool[] {false} ;
         T000W3_A314OctipEst = new String[] {""} ;
         T000W3_n314OctipEst = new bool[] {false} ;
         T000W3_A315OctipInvCod = new String[] {""} ;
         T000W3_n315OctipInvCod = new bool[] {false} ;
         T000W3_A316OctipInvFch = new String[] {""} ;
         T000W3_n316OctipInvFch = new bool[] {false} ;
         T000W3_A1EmpID = new short[1] ;
         T000W3_A2AgeID = new short[1] ;
         T000W10_A1EmpID = new short[1] ;
         T000W10_A2AgeID = new short[1] ;
         T000W10_A311OcTipoCod = new String[] {""} ;
         T000W11_A1EmpID = new short[1] ;
         T000W11_A2AgeID = new short[1] ;
         T000W11_A311OcTipoCod = new String[] {""} ;
         T000W2_A311OcTipoCod = new String[] {""} ;
         T000W2_A312OctipFch = new DateTime[] {DateTime.MinValue} ;
         T000W2_n312OctipFch = new bool[] {false} ;
         T000W2_A313OctipDsc = new String[] {""} ;
         T000W2_n313OctipDsc = new bool[] {false} ;
         T000W2_A314OctipEst = new String[] {""} ;
         T000W2_n314OctipEst = new bool[] {false} ;
         T000W2_A315OctipInvCod = new String[] {""} ;
         T000W2_n315OctipInvCod = new bool[] {false} ;
         T000W2_A316OctipInvFch = new String[] {""} ;
         T000W2_n316OctipInvFch = new bool[] {false} ;
         T000W2_A1EmpID = new short[1] ;
         T000W2_A2AgeID = new short[1] ;
         T000W15_A44empdsc = new String[] {""} ;
         T000W15_n44empdsc = new bool[] {false} ;
         T000W16_A46AgeDsc = new String[] {""} ;
         T000W16_n46AgeDsc = new bool[] {false} ;
         T000W17_A1EmpID = new short[1] ;
         T000W17_A2AgeID = new short[1] ;
         T000W17_A317OCompNro = new short[1] ;
         T000W17_A311OcTipoCod = new String[] {""} ;
         T000W18_A1EmpID = new short[1] ;
         T000W18_A2AgeID = new short[1] ;
         T000W18_A311OcTipoCod = new String[] {""} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.octipos__default(),
            new Object[][] {
                new Object[] {
               T000W2_A311OcTipoCod, T000W2_A312OctipFch, T000W2_n312OctipFch, T000W2_A313OctipDsc, T000W2_n313OctipDsc, T000W2_A314OctipEst, T000W2_n314OctipEst, T000W2_A315OctipInvCod, T000W2_n315OctipInvCod, T000W2_A316OctipInvFch,
               T000W2_n316OctipInvFch, T000W2_A1EmpID, T000W2_A2AgeID
               }
               , new Object[] {
               T000W3_A311OcTipoCod, T000W3_A312OctipFch, T000W3_n312OctipFch, T000W3_A313OctipDsc, T000W3_n313OctipDsc, T000W3_A314OctipEst, T000W3_n314OctipEst, T000W3_A315OctipInvCod, T000W3_n315OctipInvCod, T000W3_A316OctipInvFch,
               T000W3_n316OctipInvFch, T000W3_A1EmpID, T000W3_A2AgeID
               }
               , new Object[] {
               T000W4_A44empdsc, T000W4_n44empdsc
               }
               , new Object[] {
               T000W5_A46AgeDsc, T000W5_n46AgeDsc
               }
               , new Object[] {
               T000W6_A311OcTipoCod, T000W6_A44empdsc, T000W6_n44empdsc, T000W6_A46AgeDsc, T000W6_n46AgeDsc, T000W6_A312OctipFch, T000W6_n312OctipFch, T000W6_A313OctipDsc, T000W6_n313OctipDsc, T000W6_A314OctipEst,
               T000W6_n314OctipEst, T000W6_A315OctipInvCod, T000W6_n315OctipInvCod, T000W6_A316OctipInvFch, T000W6_n316OctipInvFch, T000W6_A1EmpID, T000W6_A2AgeID
               }
               , new Object[] {
               T000W7_A44empdsc, T000W7_n44empdsc
               }
               , new Object[] {
               T000W8_A46AgeDsc, T000W8_n46AgeDsc
               }
               , new Object[] {
               T000W9_A1EmpID, T000W9_A2AgeID, T000W9_A311OcTipoCod
               }
               , new Object[] {
               T000W10_A1EmpID, T000W10_A2AgeID, T000W10_A311OcTipoCod
               }
               , new Object[] {
               T000W11_A1EmpID, T000W11_A2AgeID, T000W11_A311OcTipoCod
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000W15_A44empdsc, T000W15_n44empdsc
               }
               , new Object[] {
               T000W16_A46AgeDsc, T000W16_n46AgeDsc
               }
               , new Object[] {
               T000W17_A1EmpID, T000W17_A2AgeID, T000W17_A317OCompNro, T000W17_A311OcTipoCod
               }
               , new Object[] {
               T000W18_A1EmpID, T000W18_A2AgeID, T000W18_A311OcTipoCod
               }
            }
         );
         AV13Pgmname = "Octipos";
      }

      private short wcpOAV7EmpID ;
      private short wcpOAV8AgeID ;
      private short Z1EmpID ;
      private short Z2AgeID ;
      private short GxWebError ;
      private short A1EmpID ;
      private short A2AgeID ;
      private short AV7EmpID ;
      private short AV8AgeID ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short RcdFound74 ;
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
      private int edtAgeID_Enabled ;
      private int imgprompt_2_Visible ;
      private int edtAgeDsc_Enabled ;
      private int edtOcTipoCod_Enabled ;
      private int edtOctipFch_Enabled ;
      private int edtOctipDsc_Enabled ;
      private int edtOctipEst_Enabled ;
      private int edtOctipInvCod_Enabled ;
      private int edtOctipInvFch_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String wcpOAV9OcTipoCod ;
      private String Z311OcTipoCod ;
      private String Z313OctipDsc ;
      private String Z314OctipEst ;
      private String Z315OctipInvCod ;
      private String Z316OctipInvFch ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String AV9OcTipoCod ;
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
      private String edtAgeID_Internalname ;
      private String edtAgeID_Jsonclick ;
      private String imgprompt_2_Internalname ;
      private String imgprompt_2_Link ;
      private String edtAgeDsc_Internalname ;
      private String A46AgeDsc ;
      private String edtAgeDsc_Jsonclick ;
      private String edtOcTipoCod_Internalname ;
      private String A311OcTipoCod ;
      private String edtOcTipoCod_Jsonclick ;
      private String edtOctipFch_Internalname ;
      private String edtOctipFch_Jsonclick ;
      private String edtOctipDsc_Internalname ;
      private String A313OctipDsc ;
      private String edtOctipDsc_Jsonclick ;
      private String edtOctipEst_Internalname ;
      private String A314OctipEst ;
      private String edtOctipEst_Jsonclick ;
      private String edtOctipInvCod_Internalname ;
      private String A315OctipInvCod ;
      private String edtOctipInvCod_Jsonclick ;
      private String edtOctipInvFch_Internalname ;
      private String A316OctipInvFch ;
      private String edtOctipInvFch_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String AV13Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode74 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z46AgeDsc ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private DateTime Z312OctipFch ;
      private DateTime A312OctipFch ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n44empdsc ;
      private bool n46AgeDsc ;
      private bool n312OctipFch ;
      private bool n313OctipDsc ;
      private bool n314OctipEst ;
      private bool n315OctipInvCod ;
      private bool n316OctipInvFch ;
      private bool returnInSub ;
      private String A44empdsc ;
      private String Z44empdsc ;
      private IGxSession AV12WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T000W4_A44empdsc ;
      private bool[] T000W4_n44empdsc ;
      private String[] T000W5_A46AgeDsc ;
      private bool[] T000W5_n46AgeDsc ;
      private String[] T000W6_A311OcTipoCod ;
      private String[] T000W6_A44empdsc ;
      private bool[] T000W6_n44empdsc ;
      private String[] T000W6_A46AgeDsc ;
      private bool[] T000W6_n46AgeDsc ;
      private DateTime[] T000W6_A312OctipFch ;
      private bool[] T000W6_n312OctipFch ;
      private String[] T000W6_A313OctipDsc ;
      private bool[] T000W6_n313OctipDsc ;
      private String[] T000W6_A314OctipEst ;
      private bool[] T000W6_n314OctipEst ;
      private String[] T000W6_A315OctipInvCod ;
      private bool[] T000W6_n315OctipInvCod ;
      private String[] T000W6_A316OctipInvFch ;
      private bool[] T000W6_n316OctipInvFch ;
      private short[] T000W6_A1EmpID ;
      private short[] T000W6_A2AgeID ;
      private String[] T000W7_A44empdsc ;
      private bool[] T000W7_n44empdsc ;
      private String[] T000W8_A46AgeDsc ;
      private bool[] T000W8_n46AgeDsc ;
      private short[] T000W9_A1EmpID ;
      private short[] T000W9_A2AgeID ;
      private String[] T000W9_A311OcTipoCod ;
      private String[] T000W3_A311OcTipoCod ;
      private DateTime[] T000W3_A312OctipFch ;
      private bool[] T000W3_n312OctipFch ;
      private String[] T000W3_A313OctipDsc ;
      private bool[] T000W3_n313OctipDsc ;
      private String[] T000W3_A314OctipEst ;
      private bool[] T000W3_n314OctipEst ;
      private String[] T000W3_A315OctipInvCod ;
      private bool[] T000W3_n315OctipInvCod ;
      private String[] T000W3_A316OctipInvFch ;
      private bool[] T000W3_n316OctipInvFch ;
      private short[] T000W3_A1EmpID ;
      private short[] T000W3_A2AgeID ;
      private short[] T000W10_A1EmpID ;
      private short[] T000W10_A2AgeID ;
      private String[] T000W10_A311OcTipoCod ;
      private short[] T000W11_A1EmpID ;
      private short[] T000W11_A2AgeID ;
      private String[] T000W11_A311OcTipoCod ;
      private String[] T000W2_A311OcTipoCod ;
      private DateTime[] T000W2_A312OctipFch ;
      private bool[] T000W2_n312OctipFch ;
      private String[] T000W2_A313OctipDsc ;
      private bool[] T000W2_n313OctipDsc ;
      private String[] T000W2_A314OctipEst ;
      private bool[] T000W2_n314OctipEst ;
      private String[] T000W2_A315OctipInvCod ;
      private bool[] T000W2_n315OctipInvCod ;
      private String[] T000W2_A316OctipInvFch ;
      private bool[] T000W2_n316OctipInvFch ;
      private short[] T000W2_A1EmpID ;
      private short[] T000W2_A2AgeID ;
      private String[] T000W15_A44empdsc ;
      private bool[] T000W15_n44empdsc ;
      private String[] T000W16_A46AgeDsc ;
      private bool[] T000W16_n46AgeDsc ;
      private short[] T000W17_A1EmpID ;
      private short[] T000W17_A2AgeID ;
      private short[] T000W17_A317OCompNro ;
      private String[] T000W17_A311OcTipoCod ;
      private short[] T000W18_A1EmpID ;
      private short[] T000W18_A2AgeID ;
      private String[] T000W18_A311OcTipoCod ;
      private SdtTransactionContext AV11TrnContext ;
   }

   public class octipos__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000W6 ;
          prmT000W6 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0}
          } ;
          Object[] prmT000W4 ;
          prmT000W4 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000W5 ;
          prmT000W5 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000W7 ;
          prmT000W7 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000W8 ;
          prmT000W8 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000W9 ;
          prmT000W9 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0}
          } ;
          Object[] prmT000W3 ;
          prmT000W3 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0}
          } ;
          Object[] prmT000W10 ;
          prmT000W10 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0}
          } ;
          Object[] prmT000W11 ;
          prmT000W11 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0}
          } ;
          Object[] prmT000W2 ;
          prmT000W2 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0}
          } ;
          Object[] prmT000W12 ;
          prmT000W12 = new Object[] {
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0} ,
          new Object[] {"@OctipFch",SqlDbType.DateTime,8,0} ,
          new Object[] {"@OctipDsc",SqlDbType.Char,40,0} ,
          new Object[] {"@OctipEst",SqlDbType.Char,1,0} ,
          new Object[] {"@OctipInvCod",SqlDbType.Char,3,0} ,
          new Object[] {"@OctipInvFch",SqlDbType.Char,1,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000W13 ;
          prmT000W13 = new Object[] {
          new Object[] {"@OctipFch",SqlDbType.DateTime,8,0} ,
          new Object[] {"@OctipDsc",SqlDbType.Char,40,0} ,
          new Object[] {"@OctipEst",SqlDbType.Char,1,0} ,
          new Object[] {"@OctipInvCod",SqlDbType.Char,3,0} ,
          new Object[] {"@OctipInvFch",SqlDbType.Char,1,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0}
          } ;
          Object[] prmT000W14 ;
          prmT000W14 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0}
          } ;
          Object[] prmT000W17 ;
          prmT000W17 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0}
          } ;
          Object[] prmT000W18 ;
          prmT000W18 = new Object[] {
          } ;
          Object[] prmT000W15 ;
          prmT000W15 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000W16 ;
          prmT000W16 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000W2", "SELECT [OcTipoCod], [OctipFch], [OctipDsc], [OctipEst], [OctipInvCod], [OctipInvFch], [EmpID], [AgeID] FROM [Octipos] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [OcTipoCod] = @OcTipoCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000W2,1,0,true,false )
             ,new CursorDef("T000W3", "SELECT [OcTipoCod], [OctipFch], [OctipDsc], [OctipEst], [OctipInvCod], [OctipInvFch], [EmpID], [AgeID] FROM [Octipos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [OcTipoCod] = @OcTipoCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000W3,1,0,true,false )
             ,new CursorDef("T000W4", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000W4,1,0,true,false )
             ,new CursorDef("T000W5", "SELECT [AgeDsc] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000W5,1,0,true,false )
             ,new CursorDef("T000W6", "SELECT TM1.[OcTipoCod], T2.[empdsc], T3.[AgeDsc], TM1.[OctipFch], TM1.[OctipDsc], TM1.[OctipEst], TM1.[OctipInvCod], TM1.[OctipInvFch], TM1.[EmpID], TM1.[AgeID] FROM (([Octipos] TM1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = TM1.[EmpID]) INNER JOIN [Agencias] T3 WITH (NOLOCK) ON T3.[EmpID] = TM1.[EmpID] AND T3.[AgeID] = TM1.[AgeID]) WHERE TM1.[EmpID] = @EmpID and TM1.[AgeID] = @AgeID and TM1.[OcTipoCod] = @OcTipoCod ORDER BY TM1.[EmpID], TM1.[AgeID], TM1.[OcTipoCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000W6,100,0,true,false )
             ,new CursorDef("T000W7", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000W7,1,0,true,false )
             ,new CursorDef("T000W8", "SELECT [AgeDsc] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000W8,1,0,true,false )
             ,new CursorDef("T000W9", "SELECT [EmpID], [AgeID], [OcTipoCod] FROM [Octipos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [OcTipoCod] = @OcTipoCod  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000W9,1,0,true,false )
             ,new CursorDef("T000W10", "SELECT TOP 1 [EmpID], [AgeID], [OcTipoCod] FROM [Octipos] WITH (NOLOCK) WHERE ( [EmpID] > @EmpID or [EmpID] = @EmpID and [AgeID] > @AgeID or [AgeID] = @AgeID and [EmpID] = @EmpID and [OcTipoCod] > @OcTipoCod) ORDER BY [EmpID], [AgeID], [OcTipoCod]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000W10,1,0,true,true )
             ,new CursorDef("T000W11", "SELECT TOP 1 [EmpID], [AgeID], [OcTipoCod] FROM [Octipos] WITH (NOLOCK) WHERE ( [EmpID] < @EmpID or [EmpID] = @EmpID and [AgeID] < @AgeID or [AgeID] = @AgeID and [EmpID] = @EmpID and [OcTipoCod] < @OcTipoCod) ORDER BY [EmpID] DESC, [AgeID] DESC, [OcTipoCod] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000W11,1,0,true,true )
             ,new CursorDef("T000W12", "INSERT INTO [Octipos]([OcTipoCod], [OctipFch], [OctipDsc], [OctipEst], [OctipInvCod], [OctipInvFch], [EmpID], [AgeID]) VALUES(@OcTipoCod, @OctipFch, @OctipDsc, @OctipEst, @OctipInvCod, @OctipInvFch, @EmpID, @AgeID)", GxErrorMask.GX_NOMASK,prmT000W12)
             ,new CursorDef("T000W13", "UPDATE [Octipos] SET [OctipFch]=@OctipFch, [OctipDsc]=@OctipDsc, [OctipEst]=@OctipEst, [OctipInvCod]=@OctipInvCod, [OctipInvFch]=@OctipInvFch  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [OcTipoCod] = @OcTipoCod", GxErrorMask.GX_NOMASK,prmT000W13)
             ,new CursorDef("T000W14", "DELETE FROM [Octipos]  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [OcTipoCod] = @OcTipoCod", GxErrorMask.GX_NOMASK,prmT000W14)
             ,new CursorDef("T000W15", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000W15,1,0,true,false )
             ,new CursorDef("T000W16", "SELECT [AgeDsc] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000W16,1,0,true,false )
             ,new CursorDef("T000W17", "SELECT TOP 1 [EmpID], [AgeID], [OCompNro], [OcTipoCod] FROM [OrdenCompra] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [OcTipoCod] = @OcTipoCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000W17,1,0,true,true )
             ,new CursorDef("T000W18", "SELECT [EmpID], [AgeID], [OcTipoCod] FROM [Octipos] WITH (NOLOCK) ORDER BY [EmpID], [AgeID], [OcTipoCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000W18,100,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 3) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 40) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 1) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 3) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getString(6, 1) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((short[]) buf[11])[0] = rslt.getShort(7) ;
                ((short[]) buf[12])[0] = rslt.getShort(8) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 3) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 40) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 1) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 3) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getString(6, 1) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((short[]) buf[11])[0] = rslt.getShort(7) ;
                ((short[]) buf[12])[0] = rslt.getShort(8) ;
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
                ((String[]) buf[0])[0] = rslt.getString(1, 3) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 40) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getString(6, 1) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getString(7, 3) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((String[]) buf[13])[0] = rslt.getString(8, 1) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((short[]) buf[15])[0] = rslt.getShort(9) ;
                ((short[]) buf[16])[0] = rslt.getShort(10) ;
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
                ((String[]) buf[2])[0] = rslt.getString(3, 3) ;
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 3) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 3) ;
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
                ((String[]) buf[3])[0] = rslt.getString(4, 3) ;
                return;
             case 16 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 3) ;
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
                stmt.SetParameter(3, (String)parms[2]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
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
                stmt.SetParameter(3, (String)parms[2]);
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
                stmt.SetParameter(3, (String)parms[2]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                return;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(2, (DateTime)parms[2]);
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
                stmt.SetParameter(7, (short)parms[11]);
                stmt.SetParameter(8, (short)parms[12]);
                return;
             case 11 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(1, (DateTime)parms[1]);
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
                stmt.SetParameter(6, (short)parms[10]);
                stmt.SetParameter(7, (short)parms[11]);
                stmt.SetParameter(8, (String)parms[12]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                return;
       }
    }

 }

}
