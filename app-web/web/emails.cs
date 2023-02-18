/*
               File: Emails
        Description: Emails
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 2/12/2023 15:18:37.59
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
   public class emails : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel2"+"_"+"EMAILID") == 0 )
         {
            AV11emailID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11emailID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11emailID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMAILID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV11emailID), "ZZZ9"), context));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX2ASAEMAILID0L23( AV11emailID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_14") == 0 )
         {
            A3UsuCod = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_14( A3UsuCod) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridemails_level1") == 0 )
         {
            nRC_GXsfl_63 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_63_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_63_idx = GetNextPar( );
            A143emailUltNro = (short)(NumberUtil.Val( GetNextPar( ), "."));
            n143emailUltNro = false;
            Gx_BScreen = (short)(NumberUtil.Val( GetNextPar( ), "."));
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridemails_level1_newrow( ) ;
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
            Gx_mode = gxfirstwebparm;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV11emailID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11emailID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11emailID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMAILID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV11emailID), "ZZZ9"), context));
               AV7UsuCod = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7UsuCod", AV7UsuCod);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV7UsuCod, "")), context));
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
            Form.Meta.addItem("description", "Emails", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtemailID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public emails( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public emails( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_emailID ,
                           String aP2_UsuCod )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV11emailID = aP1_emailID;
         this.AV7UsuCod = aP2_UsuCod;
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Emails", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Emails.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Emails.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Emails.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Emails.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Emails.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx00n0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMAILID"+"'), id:'"+"EMAILID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"USUCOD"+"'), id:'"+"USUCOD"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_Emails.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtemailID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtemailID_Internalname, "ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtemailID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A29emailID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A29emailID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtemailID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtemailID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Emails.htm");
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
            GxWebStd.gx_label_element( context, edtUsuCod_Internalname, "Usuario", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsuCod_Internalname, StringUtil.RTrim( A3UsuCod), StringUtil.RTrim( context.localUtil.Format( A3UsuCod, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuCod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuCod_Enabled, 1, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Emails.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_3_Internalname, sImgUrl, imgprompt_3_Link, "", "", context.GetTheme( ), imgprompt_3_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Emails.htm");
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
            GxWebStd.gx_single_line_edit( context, edtUsuName_Internalname, A50UsuName, StringUtil.RTrim( context.localUtil.Format( A50UsuName, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuName_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Emails.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtemailReg_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtemailReg_Internalname, "Fecha Registro", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtemailReg_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtemailReg_Internalname, context.localUtil.Format(A139emailReg, "99/99/99"), context.localUtil.Format( A139emailReg, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtemailReg_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtemailReg_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Emails.htm");
            GxWebStd.gx_bitmap( context, edtemailReg_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtemailReg_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Emails.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtemailUltNro_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtemailUltNro_Internalname, "Ult. Nro", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtemailUltNro_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A143emailUltNro), 4, 0, ",", "")), ((edtemailUltNro_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A143emailUltNro), "ZZZ9")) : context.localUtil.Format( (decimal)(A143emailUltNro), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtemailUltNro_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtemailUltNro_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Emails.htm");
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
            GxWebStd.gx_label_ctrl( context, lblTitlelevel1_Internalname, "Destino", "", "", lblTitlelevel1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Emails.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Gridemails_level1( ) ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Emails.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Emails.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Emails.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm0L23( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void gxdraw_Gridemails_level1( )
      {
         /*  Grid Control  */
         Gridemails_level1Container.AddObjectProperty("GridName", "Gridemails_level1");
         Gridemails_level1Container.AddObjectProperty("Header", subGridemails_level1_Header);
         Gridemails_level1Container.AddObjectProperty("Class", "Grid");
         Gridemails_level1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridemails_level1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridemails_level1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridemails_level1_Backcolorstyle), 1, 0, ".", "")));
         Gridemails_level1Container.AddObjectProperty("CmpContext", "");
         Gridemails_level1Container.AddObjectProperty("InMasterPage", "false");
         Gridemails_level1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridemails_level1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A30sec), 4, 0, ".", "")));
         Gridemails_level1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsec_Enabled), 5, 0, ".", "")));
         Gridemails_level1Container.AddColumnProperties(Gridemails_level1Column);
         Gridemails_level1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridemails_level1Column.AddObjectProperty("Value", A140emailsDestinatarios);
         Gridemails_level1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtemailsDestinatarios_Enabled), 5, 0, ".", "")));
         Gridemails_level1Container.AddColumnProperties(Gridemails_level1Column);
         Gridemails_level1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridemails_level1Column.AddObjectProperty("Value", A141nameDestinatario);
         Gridemails_level1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtnameDestinatario_Enabled), 5, 0, ".", "")));
         Gridemails_level1Container.AddColumnProperties(Gridemails_level1Column);
         Gridemails_level1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridemails_level1Column.AddObjectProperty("Value", A142ccDestinatario);
         Gridemails_level1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtccDestinatario_Enabled), 5, 0, ".", "")));
         Gridemails_level1Container.AddColumnProperties(Gridemails_level1Column);
         Gridemails_level1Container.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridemails_level1_Selectedindex), 4, 0, ".", "")));
         Gridemails_level1Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridemails_level1_Allowselection), 1, 0, ".", "")));
         Gridemails_level1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridemails_level1_Selectioncolor), 9, 0, ".", "")));
         Gridemails_level1Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridemails_level1_Allowhovering), 1, 0, ".", "")));
         Gridemails_level1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridemails_level1_Hoveringcolor), 9, 0, ".", "")));
         Gridemails_level1Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridemails_level1_Allowcollapsing), 1, 0, ".", "")));
         Gridemails_level1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridemails_level1_Collapsed), 1, 0, ".", "")));
         nGXsfl_63_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount24 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_24 = 1;
               ScanStart0L24( ) ;
               while ( RcdFound24 != 0 )
               {
                  init_level_properties24( ) ;
                  getByPrimaryKey0L24( ) ;
                  AddRow0L24( ) ;
                  ScanNext0L24( ) ;
               }
               ScanEnd0L24( ) ;
               nBlankRcdCount24 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            B143emailUltNro = A143emailUltNro;
            n143emailUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143emailUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A143emailUltNro), 4, 0)));
            standaloneNotModal0L24( ) ;
            standaloneModal0L24( ) ;
            sMode24 = Gx_mode;
            while ( nGXsfl_63_idx < nRC_GXsfl_63 )
            {
               bGXsfl_63_Refreshing = true;
               ReadRow0L24( ) ;
               edtsec_Enabled = (int)(context.localUtil.CToN( cgiGet( "SEC_"+sGXsfl_63_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsec_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
               edtemailsDestinatarios_Enabled = (int)(context.localUtil.CToN( cgiGet( "EMAILSDESTINATARIOS_"+sGXsfl_63_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtemailsDestinatarios_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtemailsDestinatarios_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
               edtnameDestinatario_Enabled = (int)(context.localUtil.CToN( cgiGet( "NAMEDESTINATARIO_"+sGXsfl_63_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtnameDestinatario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtnameDestinatario_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
               edtccDestinatario_Enabled = (int)(context.localUtil.CToN( cgiGet( "CCDESTINATARIO_"+sGXsfl_63_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtccDestinatario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtccDestinatario_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
               if ( ( nRcdExists_24 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal0L24( ) ;
               }
               SendRow0L24( ) ;
               bGXsfl_63_Refreshing = false;
            }
            Gx_mode = sMode24;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A143emailUltNro = B143emailUltNro;
            n143emailUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143emailUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A143emailUltNro), 4, 0)));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount24 = 5;
            nRcdExists_24 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart0L24( ) ;
               while ( RcdFound24 != 0 )
               {
                  sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_6324( ) ;
                  init_level_properties24( ) ;
                  standaloneNotModal0L24( ) ;
                  getByPrimaryKey0L24( ) ;
                  standaloneModal0L24( ) ;
                  AddRow0L24( ) ;
                  ScanNext0L24( ) ;
               }
               ScanEnd0L24( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode24 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_6324( ) ;
            InitAll0L24( ) ;
            init_level_properties24( ) ;
            B143emailUltNro = A143emailUltNro;
            n143emailUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143emailUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A143emailUltNro), 4, 0)));
            standaloneNotModal0L24( ) ;
            standaloneModal0L24( ) ;
            nRcdExists_24 = 0;
            nIsMod_24 = 0;
            nRcdDeleted_24 = 0;
            nBlankRcdCount24 = (short)(nBlankRcdUsr24+nBlankRcdCount24);
            fRowAdded = 0;
            while ( nBlankRcdCount24 > 0 )
            {
               AddRow0L24( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtsec_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount24 = (short)(nBlankRcdCount24-1);
            }
            Gx_mode = sMode24;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A143emailUltNro = B143emailUltNro;
            n143emailUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143emailUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A143emailUltNro), 4, 0)));
         }
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridemails_level1Container"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridemails_level1", Gridemails_level1Container);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridemails_level1ContainerData", Gridemails_level1Container.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridemails_level1ContainerData"+"V", Gridemails_level1Container.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridemails_level1ContainerData"+"V"+"\" value='"+Gridemails_level1Container.GridValuesHidden()+"'/>") ;
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
         /* Execute user event: Start */
         E110L2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtemailID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtemailID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "EMAILID");
                  AnyError = 1;
                  GX_FocusControl = edtemailID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A29emailID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29emailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A29emailID), 4, 0)));
               }
               else
               {
                  A29emailID = (short)(context.localUtil.CToN( cgiGet( edtemailID_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29emailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A29emailID), 4, 0)));
               }
               A3UsuCod = cgiGet( edtUsuCod_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
               A50UsuName = cgiGet( edtUsuName_Internalname);
               n50UsuName = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50UsuName", A50UsuName);
               if ( context.localUtil.VCDate( cgiGet( edtemailReg_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"email Reg"}), 1, "EMAILREG");
                  AnyError = 1;
                  GX_FocusControl = edtemailReg_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A139emailReg = DateTime.MinValue;
                  n139emailReg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A139emailReg", context.localUtil.Format(A139emailReg, "99/99/99"));
               }
               else
               {
                  A139emailReg = context.localUtil.CToD( cgiGet( edtemailReg_Internalname), 2);
                  n139emailReg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A139emailReg", context.localUtil.Format(A139emailReg, "99/99/99"));
               }
               n139emailReg = ((DateTime.MinValue==A139emailReg) ? true : false);
               A143emailUltNro = (short)(context.localUtil.CToN( cgiGet( edtemailUltNro_Internalname), ",", "."));
               n143emailUltNro = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143emailUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A143emailUltNro), 4, 0)));
               /* Read saved values. */
               Z29emailID = (short)(context.localUtil.CToN( cgiGet( "Z29emailID"), ",", "."));
               Z3UsuCod = cgiGet( "Z3UsuCod");
               Z139emailReg = context.localUtil.CToD( cgiGet( "Z139emailReg"), 0);
               n139emailReg = ((DateTime.MinValue==A139emailReg) ? true : false);
               Z143emailUltNro = (short)(context.localUtil.CToN( cgiGet( "Z143emailUltNro"), ",", "."));
               n143emailUltNro = ((0==A143emailUltNro) ? true : false);
               O143emailUltNro = (short)(context.localUtil.CToN( cgiGet( "O143emailUltNro"), ",", "."));
               n143emailUltNro = ((0==A143emailUltNro) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_63 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_63"), ",", "."));
               AV11emailID = (short)(context.localUtil.CToN( cgiGet( "vEMAILID"), ",", "."));
               AV7UsuCod = cgiGet( "vUSUCOD");
               AV15Pgmname = cgiGet( "vPGMNAME");
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ",", "."));
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Emails";
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A29emailID != Z29emailID ) || ( StringUtil.StrCmp(A3UsuCod, Z3UsuCod) != 0 ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("emails:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  A29emailID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29emailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A29emailID), 4, 0)));
                  A3UsuCod = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
                  getEqualNoModal( ) ;
                  if ( ! (0==AV11emailID) )
                  {
                     A29emailID = AV11emailID;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29emailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A29emailID), 4, 0)));
                  }
                  else
                  {
                     if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
                     {
                        GXt_int1 = A29emailID;
                        new obtnewemailid(context ).execute( out  GXt_int1) ;
                        A29emailID = GXt_int1;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29emailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A29emailID), 4, 0)));
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
                     sMode23 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     if ( ! (0==AV11emailID) )
                     {
                        A29emailID = AV11emailID;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29emailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A29emailID), 4, 0)));
                     }
                     else
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
                        {
                           GXt_int1 = A29emailID;
                           new obtnewemailid(context ).execute( out  GXt_int1) ;
                           A29emailID = GXt_int1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29emailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A29emailID), 4, 0)));
                        }
                     }
                     Gx_mode = sMode23;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound23 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0L0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "EMAILID");
                        AnyError = 1;
                        GX_FocusControl = edtemailID_Internalname;
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
                        E110L2 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: After Trn */
                        E120L2 ();
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
            /* Execute user event: After Trn */
            E120L2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0L23( ) ;
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
            DisableAttributes0L23( ) ;
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

      protected void CONFIRM_0L0( )
      {
         BeforeValidate0L23( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0L23( ) ;
            }
            else
            {
               CheckExtendedTable0L23( ) ;
               CloseExtendedTableCursors0L23( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode23 = Gx_mode;
            CONFIRM_0L24( ) ;
            if ( AnyError == 0 )
            {
               /* Restore parent mode. */
               Gx_mode = sMode23;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
               IsConfirmed = 1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
            }
            /* Restore parent mode. */
            Gx_mode = sMode23;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
      }

      protected void CONFIRM_0L24( )
      {
         s143emailUltNro = O143emailUltNro;
         n143emailUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143emailUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A143emailUltNro), 4, 0)));
         nGXsfl_63_idx = 0;
         while ( nGXsfl_63_idx < nRC_GXsfl_63 )
         {
            ReadRow0L24( ) ;
            if ( ( nRcdExists_24 != 0 ) || ( nIsMod_24 != 0 ) )
            {
               GetKey0L24( ) ;
               if ( ( nRcdExists_24 == 0 ) && ( nRcdDeleted_24 == 0 ) )
               {
                  if ( RcdFound24 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate0L24( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0L24( ) ;
                        CloseExtendedTableCursors0L24( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                        O143emailUltNro = A143emailUltNro;
                        n143emailUltNro = false;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143emailUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A143emailUltNro), 4, 0)));
                     }
                  }
                  else
                  {
                     GXCCtl = "SEC_" + sGXsfl_63_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtsec_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound24 != 0 )
                  {
                     if ( nRcdDeleted_24 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey0L24( ) ;
                        Load0L24( ) ;
                        BeforeValidate0L24( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0L24( ) ;
                           O143emailUltNro = A143emailUltNro;
                           n143emailUltNro = false;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143emailUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A143emailUltNro), 4, 0)));
                        }
                     }
                     else
                     {
                        if ( nIsMod_24 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate0L24( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0L24( ) ;
                              CloseExtendedTableCursors0L24( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                              }
                              O143emailUltNro = A143emailUltNro;
                              n143emailUltNro = false;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143emailUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A143emailUltNro), 4, 0)));
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_24 == 0 )
                     {
                        GXCCtl = "SEC_" + sGXsfl_63_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtsec_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtsec_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A30sec), 4, 0, ",", ""))) ;
            ChangePostValue( edtemailsDestinatarios_Internalname, A140emailsDestinatarios) ;
            ChangePostValue( edtnameDestinatario_Internalname, A141nameDestinatario) ;
            ChangePostValue( edtccDestinatario_Internalname, A142ccDestinatario) ;
            ChangePostValue( "ZT_"+"Z30sec_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z30sec), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z140emailsDestinatarios_"+sGXsfl_63_idx, Z140emailsDestinatarios) ;
            ChangePostValue( "ZT_"+"Z141nameDestinatario_"+sGXsfl_63_idx, Z141nameDestinatario) ;
            ChangePostValue( "ZT_"+"Z142ccDestinatario_"+sGXsfl_63_idx, Z142ccDestinatario) ;
            ChangePostValue( "nRcdDeleted_24_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_24), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_24_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_24), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_24_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_24), 4, 0, ",", ""))) ;
            if ( nIsMod_24 != 0 )
            {
               ChangePostValue( "SEC_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsec_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "EMAILSDESTINATARIOS_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtemailsDestinatarios_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "NAMEDESTINATARIO_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtnameDestinatario_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CCDESTINATARIO_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtccDestinatario_Enabled), 5, 0, ".", ""))) ;
            }
         }
         O143emailUltNro = s143emailUltNro;
         n143emailUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143emailUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A143emailUltNro), 4, 0)));
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption0L0( )
      {
      }

      protected void E110L2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV15Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV15Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "KBCalpesa22");
      }

      protected void E120L2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwemails.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0L23( short GX_JID )
      {
         if ( ( GX_JID == 13 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z139emailReg = T000L5_A139emailReg[0];
               Z143emailUltNro = T000L5_A143emailUltNro[0];
            }
            else
            {
               Z139emailReg = A139emailReg;
               Z143emailUltNro = A143emailUltNro;
            }
         }
         if ( GX_JID == -13 )
         {
            Z29emailID = A29emailID;
            Z139emailReg = A139emailReg;
            Z143emailUltNro = A143emailUltNro;
            Z3UsuCod = A3UsuCod;
            Z50UsuName = A50UsuName;
         }
      }

      protected void standaloneNotModal( )
      {
         edtemailUltNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtemailUltNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtemailUltNro_Enabled), 5, 0)), true);
         Gx_BScreen = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         imgprompt_3_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0030.aspx"+"',["+"{Ctrl:gx.dom.el('"+"USUCOD"+"'), id:'"+"USUCOD"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");");
         edtemailUltNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtemailUltNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtemailUltNro_Enabled), 5, 0)), true);
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV11emailID) )
         {
            edtemailID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtemailID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtemailID_Enabled), 5, 0)), true);
         }
         else
         {
            edtemailID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtemailID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtemailID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV11emailID) )
         {
            edtemailID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtemailID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtemailID_Enabled), 5, 0)), true);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7UsuCod)) )
         {
            A3UsuCod = AV7UsuCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7UsuCod)) )
         {
            edtUsuCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuCod_Enabled), 5, 0)), true);
         }
         else
         {
            edtUsuCod_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuCod_Enabled), 5, 0)), true);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7UsuCod)) )
         {
            edtUsuCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuCod_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ! (0==AV11emailID) )
         {
            A29emailID = AV11emailID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29emailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A29emailID), 4, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               GXt_int1 = A29emailID;
               new obtnewemailid(context ).execute( out  GXt_int1) ;
               A29emailID = GXt_int1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29emailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A29emailID), 4, 0)));
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
            AV15Pgmname = "Emails";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
            /* Using cursor T000L6 */
            pr_default.execute(4, new Object[] {A3UsuCod});
            A50UsuName = T000L6_A50UsuName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50UsuName", A50UsuName);
            n50UsuName = T000L6_n50UsuName[0];
            pr_default.close(4);
         }
      }

      protected void Load0L23( )
      {
         /* Using cursor T000L7 */
         pr_default.execute(5, new Object[] {A29emailID, A3UsuCod});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound23 = 1;
            A50UsuName = T000L7_A50UsuName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50UsuName", A50UsuName);
            n50UsuName = T000L7_n50UsuName[0];
            A139emailReg = T000L7_A139emailReg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A139emailReg", context.localUtil.Format(A139emailReg, "99/99/99"));
            n139emailReg = T000L7_n139emailReg[0];
            A143emailUltNro = T000L7_A143emailUltNro[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143emailUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A143emailUltNro), 4, 0)));
            n143emailUltNro = T000L7_n143emailUltNro[0];
            ZM0L23( -13) ;
         }
         pr_default.close(5);
         OnLoadActions0L23( ) ;
      }

      protected void OnLoadActions0L23( )
      {
         AV15Pgmname = "Emails";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
      }

      protected void CheckExtendedTable0L23( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         AV15Pgmname = "Emails";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
         /* Using cursor T000L6 */
         pr_default.execute(4, new Object[] {A3UsuCod});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No existe 'Usuarios'.", "ForeignKeyNotFound", 1, "USUCOD");
            AnyError = 1;
            GX_FocusControl = edtUsuCod_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A50UsuName = T000L6_A50UsuName[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50UsuName", A50UsuName);
         n50UsuName = T000L6_n50UsuName[0];
         pr_default.close(4);
         if ( ! ( (DateTime.MinValue==A139emailReg) || ( A139emailReg >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo email Reg fuera de rango", "OutOfRange", 1, "EMAILREG");
            AnyError = 1;
            GX_FocusControl = edtemailReg_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0L23( )
      {
         pr_default.close(4);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_14( String A3UsuCod )
      {
         /* Using cursor T000L8 */
         pr_default.execute(6, new Object[] {A3UsuCod});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No existe 'Usuarios'.", "ForeignKeyNotFound", 1, "USUCOD");
            AnyError = 1;
            GX_FocusControl = edtUsuCod_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A50UsuName = T000L8_A50UsuName[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50UsuName", A50UsuName);
         n50UsuName = T000L8_n50UsuName[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A50UsuName)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(6);
      }

      protected void GetKey0L23( )
      {
         /* Using cursor T000L9 */
         pr_default.execute(7, new Object[] {A29emailID, A3UsuCod});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound23 = 1;
         }
         else
         {
            RcdFound23 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000L5 */
         pr_default.execute(3, new Object[] {A29emailID, A3UsuCod});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM0L23( 13) ;
            RcdFound23 = 1;
            A29emailID = T000L5_A29emailID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29emailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A29emailID), 4, 0)));
            A139emailReg = T000L5_A139emailReg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A139emailReg", context.localUtil.Format(A139emailReg, "99/99/99"));
            n139emailReg = T000L5_n139emailReg[0];
            A143emailUltNro = T000L5_A143emailUltNro[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143emailUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A143emailUltNro), 4, 0)));
            n143emailUltNro = T000L5_n143emailUltNro[0];
            A3UsuCod = T000L5_A3UsuCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
            O143emailUltNro = A143emailUltNro;
            n143emailUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143emailUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A143emailUltNro), 4, 0)));
            Z29emailID = A29emailID;
            Z3UsuCod = A3UsuCod;
            sMode23 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0L23( ) ;
            if ( AnyError == 1 )
            {
               RcdFound23 = 0;
               InitializeNonKey0L23( ) ;
            }
            Gx_mode = sMode23;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound23 = 0;
            InitializeNonKey0L23( ) ;
            sMode23 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode23;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(3);
      }

      protected void getEqualNoModal( )
      {
         GetKey0L23( ) ;
         if ( RcdFound23 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound23 = 0;
         /* Using cursor T000L10 */
         pr_default.execute(8, new Object[] {A29emailID, A3UsuCod});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000L10_A29emailID[0] < A29emailID ) || ( T000L10_A29emailID[0] == A29emailID ) && ( StringUtil.StrCmp(T000L10_A3UsuCod[0], A3UsuCod) < 0 ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000L10_A29emailID[0] > A29emailID ) || ( T000L10_A29emailID[0] == A29emailID ) && ( StringUtil.StrCmp(T000L10_A3UsuCod[0], A3UsuCod) > 0 ) ) )
            {
               A29emailID = T000L10_A29emailID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29emailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A29emailID), 4, 0)));
               A3UsuCod = T000L10_A3UsuCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
               RcdFound23 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound23 = 0;
         /* Using cursor T000L11 */
         pr_default.execute(9, new Object[] {A29emailID, A3UsuCod});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000L11_A29emailID[0] > A29emailID ) || ( T000L11_A29emailID[0] == A29emailID ) && ( StringUtil.StrCmp(T000L11_A3UsuCod[0], A3UsuCod) > 0 ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000L11_A29emailID[0] < A29emailID ) || ( T000L11_A29emailID[0] == A29emailID ) && ( StringUtil.StrCmp(T000L11_A3UsuCod[0], A3UsuCod) < 0 ) ) )
            {
               A29emailID = T000L11_A29emailID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29emailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A29emailID), 4, 0)));
               A3UsuCod = T000L11_A3UsuCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
               RcdFound23 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0L23( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            A143emailUltNro = O143emailUltNro;
            n143emailUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143emailUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A143emailUltNro), 4, 0)));
            GX_FocusControl = edtemailID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0L23( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound23 == 1 )
            {
               if ( ( A29emailID != Z29emailID ) || ( StringUtil.StrCmp(A3UsuCod, Z3UsuCod) != 0 ) )
               {
                  A29emailID = Z29emailID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29emailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A29emailID), 4, 0)));
                  A3UsuCod = Z3UsuCod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "EMAILID");
                  AnyError = 1;
                  GX_FocusControl = edtemailID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  A143emailUltNro = O143emailUltNro;
                  n143emailUltNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143emailUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A143emailUltNro), 4, 0)));
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtemailID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  A143emailUltNro = O143emailUltNro;
                  n143emailUltNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143emailUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A143emailUltNro), 4, 0)));
                  Update0L23( ) ;
                  GX_FocusControl = edtemailID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A29emailID != Z29emailID ) || ( StringUtil.StrCmp(A3UsuCod, Z3UsuCod) != 0 ) )
               {
                  /* Insert record */
                  A143emailUltNro = O143emailUltNro;
                  n143emailUltNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143emailUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A143emailUltNro), 4, 0)));
                  GX_FocusControl = edtemailID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0L23( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "EMAILID");
                     AnyError = 1;
                     GX_FocusControl = edtemailID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     A143emailUltNro = O143emailUltNro;
                     n143emailUltNro = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143emailUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A143emailUltNro), 4, 0)));
                     GX_FocusControl = edtemailID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0L23( ) ;
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
         if ( ( A29emailID != Z29emailID ) || ( StringUtil.StrCmp(A3UsuCod, Z3UsuCod) != 0 ) )
         {
            A29emailID = Z29emailID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29emailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A29emailID), 4, 0)));
            A3UsuCod = Z3UsuCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "EMAILID");
            AnyError = 1;
            GX_FocusControl = edtemailID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            A143emailUltNro = O143emailUltNro;
            n143emailUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143emailUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A143emailUltNro), 4, 0)));
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtemailID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0L23( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000L4 */
            pr_default.execute(2, new Object[] {A29emailID, A3UsuCod});
            if ( (pr_default.getStatus(2) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Emails"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(2) == 101) || ( Z139emailReg != T000L4_A139emailReg[0] ) || ( Z143emailUltNro != T000L4_A143emailUltNro[0] ) )
            {
               if ( Z139emailReg != T000L4_A139emailReg[0] )
               {
                  GXUtil.WriteLog("emails:[seudo value changed for attri]"+"emailReg");
                  GXUtil.WriteLogRaw("Old: ",Z139emailReg);
                  GXUtil.WriteLogRaw("Current: ",T000L4_A139emailReg[0]);
               }
               if ( Z143emailUltNro != T000L4_A143emailUltNro[0] )
               {
                  GXUtil.WriteLog("emails:[seudo value changed for attri]"+"emailUltNro");
                  GXUtil.WriteLogRaw("Old: ",Z143emailUltNro);
                  GXUtil.WriteLogRaw("Current: ",T000L4_A143emailUltNro[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Emails"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0L23( )
      {
         BeforeValidate0L23( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0L23( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0L23( 0) ;
            CheckOptimisticConcurrency0L23( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0L23( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0L23( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000L12 */
                     pr_default.execute(10, new Object[] {A29emailID, n139emailReg, A139emailReg, n143emailUltNro, A143emailUltNro, A3UsuCod});
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("Emails") ;
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
                           ProcessLevel0L23( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption0L0( ) ;
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
               Load0L23( ) ;
            }
            EndLevel0L23( ) ;
         }
         CloseExtendedTableCursors0L23( ) ;
      }

      protected void Update0L23( )
      {
         BeforeValidate0L23( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0L23( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0L23( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0L23( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0L23( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000L13 */
                     pr_default.execute(11, new Object[] {n139emailReg, A139emailReg, n143emailUltNro, A143emailUltNro, A29emailID, A3UsuCod});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("Emails") ;
                     if ( (pr_default.getStatus(11) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Emails"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0L23( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0L23( ) ;
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
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel0L23( ) ;
         }
         CloseExtendedTableCursors0L23( ) ;
      }

      protected void DeferredUpdate0L23( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0L23( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0L23( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0L23( ) ;
            AfterConfirm0L23( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0L23( ) ;
               if ( AnyError == 0 )
               {
                  A143emailUltNro = O143emailUltNro;
                  n143emailUltNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143emailUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A143emailUltNro), 4, 0)));
                  ScanStart0L24( ) ;
                  while ( RcdFound24 != 0 )
                  {
                     getByPrimaryKey0L24( ) ;
                     Delete0L24( ) ;
                     ScanNext0L24( ) ;
                     O143emailUltNro = A143emailUltNro;
                     n143emailUltNro = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143emailUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A143emailUltNro), 4, 0)));
                  }
                  ScanEnd0L24( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000L14 */
                     pr_default.execute(12, new Object[] {A29emailID, A3UsuCod});
                     pr_default.close(12);
                     dsDefault.SmartCacheProvider.SetUpdated("Emails") ;
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
         }
         sMode23 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0L23( ) ;
         Gx_mode = sMode23;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0L23( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV15Pgmname = "Emails";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
            /* Using cursor T000L15 */
            pr_default.execute(13, new Object[] {A3UsuCod});
            A50UsuName = T000L15_A50UsuName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50UsuName", A50UsuName);
            n50UsuName = T000L15_n50UsuName[0];
            pr_default.close(13);
         }
      }

      protected void ProcessNestedLevel0L24( )
      {
         s143emailUltNro = O143emailUltNro;
         n143emailUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143emailUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A143emailUltNro), 4, 0)));
         nGXsfl_63_idx = 0;
         while ( nGXsfl_63_idx < nRC_GXsfl_63 )
         {
            ReadRow0L24( ) ;
            if ( ( nRcdExists_24 != 0 ) || ( nIsMod_24 != 0 ) )
            {
               standaloneNotModal0L24( ) ;
               GetKey0L24( ) ;
               if ( ( nRcdExists_24 == 0 ) && ( nRcdDeleted_24 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert0L24( ) ;
               }
               else
               {
                  if ( RcdFound24 != 0 )
                  {
                     if ( ( nRcdDeleted_24 != 0 ) && ( nRcdExists_24 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete0L24( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_24 != 0 ) && ( nRcdExists_24 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update0L24( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_24 == 0 )
                     {
                        GXCCtl = "SEC_" + sGXsfl_63_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtsec_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
               O143emailUltNro = A143emailUltNro;
               n143emailUltNro = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143emailUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A143emailUltNro), 4, 0)));
            }
            ChangePostValue( edtsec_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A30sec), 4, 0, ",", ""))) ;
            ChangePostValue( edtemailsDestinatarios_Internalname, A140emailsDestinatarios) ;
            ChangePostValue( edtnameDestinatario_Internalname, A141nameDestinatario) ;
            ChangePostValue( edtccDestinatario_Internalname, A142ccDestinatario) ;
            ChangePostValue( "ZT_"+"Z30sec_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z30sec), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z140emailsDestinatarios_"+sGXsfl_63_idx, Z140emailsDestinatarios) ;
            ChangePostValue( "ZT_"+"Z141nameDestinatario_"+sGXsfl_63_idx, Z141nameDestinatario) ;
            ChangePostValue( "ZT_"+"Z142ccDestinatario_"+sGXsfl_63_idx, Z142ccDestinatario) ;
            ChangePostValue( "nRcdDeleted_24_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_24), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_24_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_24), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_24_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_24), 4, 0, ",", ""))) ;
            if ( nIsMod_24 != 0 )
            {
               ChangePostValue( "SEC_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsec_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "EMAILSDESTINATARIOS_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtemailsDestinatarios_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "NAMEDESTINATARIO_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtnameDestinatario_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CCDESTINATARIO_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtccDestinatario_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0L24( ) ;
         if ( AnyError != 0 )
         {
            O143emailUltNro = s143emailUltNro;
            n143emailUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143emailUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A143emailUltNro), 4, 0)));
         }
         nRcdExists_24 = 0;
         nIsMod_24 = 0;
         nRcdDeleted_24 = 0;
      }

      protected void ProcessLevel0L23( )
      {
         /* Save parent mode. */
         sMode23 = Gx_mode;
         ProcessNestedLevel0L24( ) ;
         if ( AnyError != 0 )
         {
            O143emailUltNro = s143emailUltNro;
            n143emailUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143emailUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A143emailUltNro), 4, 0)));
         }
         /* Restore parent mode. */
         Gx_mode = sMode23;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         /* ' Update level parameters */
         /* Using cursor T000L16 */
         pr_default.execute(14, new Object[] {n143emailUltNro, A143emailUltNro, A29emailID, A3UsuCod});
         pr_default.close(14);
         dsDefault.SmartCacheProvider.SetUpdated("Emails") ;
      }

      protected void EndLevel0L23( )
      {
         pr_default.close(2);
         if ( AnyError == 0 )
         {
            BeforeComplete0L23( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(3);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(13);
            context.CommitDataStores("emails",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0L0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(3);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(13);
            context.RollbackDataStores("emails",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0L23( )
      {
         /* Scan By routine */
         /* Using cursor T000L17 */
         pr_default.execute(15);
         RcdFound23 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound23 = 1;
            A29emailID = T000L17_A29emailID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29emailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A29emailID), 4, 0)));
            A3UsuCod = T000L17_A3UsuCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0L23( )
      {
         /* Scan next routine */
         pr_default.readNext(15);
         RcdFound23 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound23 = 1;
            A29emailID = T000L17_A29emailID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29emailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A29emailID), 4, 0)));
            A3UsuCod = T000L17_A3UsuCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
         }
      }

      protected void ScanEnd0L23( )
      {
         pr_default.close(15);
      }

      protected void AfterConfirm0L23( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0L23( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0L23( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0L23( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0L23( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0L23( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0L23( )
      {
         edtemailID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtemailID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtemailID_Enabled), 5, 0)), true);
         edtUsuCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuCod_Enabled), 5, 0)), true);
         edtUsuName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuName_Enabled), 5, 0)), true);
         edtemailReg_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtemailReg_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtemailReg_Enabled), 5, 0)), true);
         edtemailUltNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtemailUltNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtemailUltNro_Enabled), 5, 0)), true);
      }

      protected void ZM0L24( short GX_JID )
      {
         if ( ( GX_JID == 15 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z140emailsDestinatarios = T000L3_A140emailsDestinatarios[0];
               Z141nameDestinatario = T000L3_A141nameDestinatario[0];
               Z142ccDestinatario = T000L3_A142ccDestinatario[0];
            }
            else
            {
               Z140emailsDestinatarios = A140emailsDestinatarios;
               Z141nameDestinatario = A141nameDestinatario;
               Z142ccDestinatario = A142ccDestinatario;
            }
         }
         if ( GX_JID == -15 )
         {
            Z29emailID = A29emailID;
            Z3UsuCod = A3UsuCod;
            Z30sec = A30sec;
            Z140emailsDestinatarios = A140emailsDestinatarios;
            Z141nameDestinatario = A141nameDestinatario;
            Z142ccDestinatario = A142ccDestinatario;
         }
      }

      protected void standaloneNotModal0L24( )
      {
         edtemailUltNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtemailUltNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtemailUltNro_Enabled), 5, 0)), true);
         edtemailUltNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtemailUltNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtemailUltNro_Enabled), 5, 0)), true);
      }

      protected void standaloneModal0L24( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A143emailUltNro = (short)(O143emailUltNro+1);
            n143emailUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143emailUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A143emailUltNro), 4, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && ( Gx_BScreen == 1 ) )
         {
            A30sec = A143emailUltNro;
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtsec_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsec_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
         }
         else
         {
            edtsec_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsec_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
         }
      }

      protected void Load0L24( )
      {
         /* Using cursor T000L18 */
         pr_default.execute(16, new Object[] {A29emailID, A3UsuCod, A30sec});
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound24 = 1;
            A140emailsDestinatarios = T000L18_A140emailsDestinatarios[0];
            n140emailsDestinatarios = T000L18_n140emailsDestinatarios[0];
            A141nameDestinatario = T000L18_A141nameDestinatario[0];
            n141nameDestinatario = T000L18_n141nameDestinatario[0];
            A142ccDestinatario = T000L18_A142ccDestinatario[0];
            n142ccDestinatario = T000L18_n142ccDestinatario[0];
            ZM0L24( -15) ;
         }
         pr_default.close(16);
         OnLoadActions0L24( ) ;
      }

      protected void OnLoadActions0L24( )
      {
      }

      protected void CheckExtendedTable0L24( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal0L24( ) ;
         if ( ! ( GxRegex.IsMatch(A140emailsDestinatarios,"^((\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*)|(\\s*))$") || String.IsNullOrEmpty(StringUtil.RTrim( A140emailsDestinatarios)) ) )
         {
            GXCCtl = "EMAILSDESTINATARIOS_" + sGXsfl_63_idx;
            GX_msglist.addItem("El valor de Destinatarios no coincide con el patrón especificado", "OutOfRange", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtemailsDestinatarios_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0L24( )
      {
      }

      protected void enableDisable0L24( )
      {
      }

      protected void GetKey0L24( )
      {
         /* Using cursor T000L19 */
         pr_default.execute(17, new Object[] {A29emailID, A3UsuCod, A30sec});
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound24 = 1;
         }
         else
         {
            RcdFound24 = 0;
         }
         pr_default.close(17);
      }

      protected void getByPrimaryKey0L24( )
      {
         /* Using cursor T000L3 */
         pr_default.execute(1, new Object[] {A29emailID, A3UsuCod, A30sec});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0L24( 15) ;
            RcdFound24 = 1;
            InitializeNonKey0L24( ) ;
            A30sec = T000L3_A30sec[0];
            A140emailsDestinatarios = T000L3_A140emailsDestinatarios[0];
            n140emailsDestinatarios = T000L3_n140emailsDestinatarios[0];
            A141nameDestinatario = T000L3_A141nameDestinatario[0];
            n141nameDestinatario = T000L3_n141nameDestinatario[0];
            A142ccDestinatario = T000L3_A142ccDestinatario[0];
            n142ccDestinatario = T000L3_n142ccDestinatario[0];
            Z29emailID = A29emailID;
            Z3UsuCod = A3UsuCod;
            Z30sec = A30sec;
            sMode24 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0L24( ) ;
            Gx_mode = sMode24;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound24 = 0;
            InitializeNonKey0L24( ) ;
            sMode24 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal0L24( ) ;
            Gx_mode = sMode24;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes0L24( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0L24( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000L2 */
            pr_default.execute(0, new Object[] {A29emailID, A3UsuCod, A30sec});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"EmailsLevel1"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z140emailsDestinatarios, T000L2_A140emailsDestinatarios[0]) != 0 ) || ( StringUtil.StrCmp(Z141nameDestinatario, T000L2_A141nameDestinatario[0]) != 0 ) || ( StringUtil.StrCmp(Z142ccDestinatario, T000L2_A142ccDestinatario[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z140emailsDestinatarios, T000L2_A140emailsDestinatarios[0]) != 0 )
               {
                  GXUtil.WriteLog("emails:[seudo value changed for attri]"+"emailsDestinatarios");
                  GXUtil.WriteLogRaw("Old: ",Z140emailsDestinatarios);
                  GXUtil.WriteLogRaw("Current: ",T000L2_A140emailsDestinatarios[0]);
               }
               if ( StringUtil.StrCmp(Z141nameDestinatario, T000L2_A141nameDestinatario[0]) != 0 )
               {
                  GXUtil.WriteLog("emails:[seudo value changed for attri]"+"nameDestinatario");
                  GXUtil.WriteLogRaw("Old: ",Z141nameDestinatario);
                  GXUtil.WriteLogRaw("Current: ",T000L2_A141nameDestinatario[0]);
               }
               if ( StringUtil.StrCmp(Z142ccDestinatario, T000L2_A142ccDestinatario[0]) != 0 )
               {
                  GXUtil.WriteLog("emails:[seudo value changed for attri]"+"ccDestinatario");
                  GXUtil.WriteLogRaw("Old: ",Z142ccDestinatario);
                  GXUtil.WriteLogRaw("Current: ",T000L2_A142ccDestinatario[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"EmailsLevel1"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0L24( )
      {
         BeforeValidate0L24( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0L24( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0L24( 0) ;
            CheckOptimisticConcurrency0L24( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0L24( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0L24( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000L20 */
                     pr_default.execute(18, new Object[] {A29emailID, A3UsuCod, A30sec, n140emailsDestinatarios, A140emailsDestinatarios, n141nameDestinatario, A141nameDestinatario, n142ccDestinatario, A142ccDestinatario});
                     pr_default.close(18);
                     dsDefault.SmartCacheProvider.SetUpdated("EmailsLevel1") ;
                     if ( (pr_default.getStatus(18) == 1) )
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
               Load0L24( ) ;
            }
            EndLevel0L24( ) ;
         }
         CloseExtendedTableCursors0L24( ) ;
      }

      protected void Update0L24( )
      {
         BeforeValidate0L24( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0L24( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0L24( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0L24( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0L24( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000L21 */
                     pr_default.execute(19, new Object[] {n140emailsDestinatarios, A140emailsDestinatarios, n141nameDestinatario, A141nameDestinatario, n142ccDestinatario, A142ccDestinatario, A29emailID, A3UsuCod, A30sec});
                     pr_default.close(19);
                     dsDefault.SmartCacheProvider.SetUpdated("EmailsLevel1") ;
                     if ( (pr_default.getStatus(19) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"EmailsLevel1"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0L24( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey0L24( ) ;
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
            EndLevel0L24( ) ;
         }
         CloseExtendedTableCursors0L24( ) ;
      }

      protected void DeferredUpdate0L24( )
      {
      }

      protected void Delete0L24( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate0L24( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0L24( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0L24( ) ;
            AfterConfirm0L24( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0L24( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000L22 */
                  pr_default.execute(20, new Object[] {A29emailID, A3UsuCod, A30sec});
                  pr_default.close(20);
                  dsDefault.SmartCacheProvider.SetUpdated("EmailsLevel1") ;
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
         sMode24 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0L24( ) ;
         Gx_mode = sMode24;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0L24( )
      {
         standaloneModal0L24( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0L24( )
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

      public void ScanStart0L24( )
      {
         /* Scan By routine */
         /* Using cursor T000L23 */
         pr_default.execute(21, new Object[] {A29emailID, A3UsuCod});
         RcdFound24 = 0;
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound24 = 1;
            A30sec = T000L23_A30sec[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0L24( )
      {
         /* Scan next routine */
         pr_default.readNext(21);
         RcdFound24 = 0;
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound24 = 1;
            A30sec = T000L23_A30sec[0];
         }
      }

      protected void ScanEnd0L24( )
      {
         pr_default.close(21);
      }

      protected void AfterConfirm0L24( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0L24( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0L24( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0L24( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0L24( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0L24( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0L24( )
      {
         edtsec_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsec_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
         edtemailsDestinatarios_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtemailsDestinatarios_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtemailsDestinatarios_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
         edtnameDestinatario_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtnameDestinatario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtnameDestinatario_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
         edtccDestinatario_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtccDestinatario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtccDestinatario_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
      }

      protected void send_integrity_lvl_hashes0L24( )
      {
      }

      protected void send_integrity_lvl_hashes0L23( )
      {
      }

      protected void SubsflControlProps_6324( )
      {
         edtsec_Internalname = "SEC_"+sGXsfl_63_idx;
         edtemailsDestinatarios_Internalname = "EMAILSDESTINATARIOS_"+sGXsfl_63_idx;
         edtnameDestinatario_Internalname = "NAMEDESTINATARIO_"+sGXsfl_63_idx;
         edtccDestinatario_Internalname = "CCDESTINATARIO_"+sGXsfl_63_idx;
      }

      protected void SubsflControlProps_fel_6324( )
      {
         edtsec_Internalname = "SEC_"+sGXsfl_63_fel_idx;
         edtemailsDestinatarios_Internalname = "EMAILSDESTINATARIOS_"+sGXsfl_63_fel_idx;
         edtnameDestinatario_Internalname = "NAMEDESTINATARIO_"+sGXsfl_63_fel_idx;
         edtccDestinatario_Internalname = "CCDESTINATARIO_"+sGXsfl_63_fel_idx;
      }

      protected void AddRow0L24( )
      {
         nGXsfl_63_idx = (short)(nGXsfl_63_idx+1);
         sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx), 4, 0)), 4, "0");
         SubsflControlProps_6324( ) ;
         SendRow0L24( ) ;
      }

      protected void SendRow0L24( )
      {
         Gridemails_level1Row = GXWebRow.GetNew(context);
         if ( subGridemails_level1_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridemails_level1_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridemails_level1_Class, "") != 0 )
            {
               subGridemails_level1_Linesclass = subGridemails_level1_Class+"Odd";
            }
         }
         else if ( subGridemails_level1_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridemails_level1_Backstyle = 0;
            subGridemails_level1_Backcolor = subGridemails_level1_Allbackcolor;
            if ( StringUtil.StrCmp(subGridemails_level1_Class, "") != 0 )
            {
               subGridemails_level1_Linesclass = subGridemails_level1_Class+"Uniform";
            }
         }
         else if ( subGridemails_level1_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridemails_level1_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridemails_level1_Class, "") != 0 )
            {
               subGridemails_level1_Linesclass = subGridemails_level1_Class+"Odd";
            }
            subGridemails_level1_Backcolor = (int)(0x0);
         }
         else if ( subGridemails_level1_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridemails_level1_Backstyle = 1;
            if ( ((int)(((nGXsfl_63_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGridemails_level1_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridemails_level1_Class, "") != 0 )
               {
                  subGridemails_level1_Linesclass = subGridemails_level1_Class+"Odd";
               }
            }
            else
            {
               subGridemails_level1_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridemails_level1_Class, "") != 0 )
               {
                  subGridemails_level1_Linesclass = subGridemails_level1_Class+"Even";
               }
            }
         }
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_24_" + sGXsfl_63_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 64,'',false,'" + sGXsfl_63_idx + "',63)\"";
         ROClassString = "Attribute";
         Gridemails_level1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtsec_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A30sec), 4, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A30sec), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtsec_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtsec_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)63,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_24_" + sGXsfl_63_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 65,'',false,'" + sGXsfl_63_idx + "',63)\"";
         ROClassString = "Attribute";
         Gridemails_level1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtemailsDestinatarios_Internalname,(String)A140emailsDestinatarios,(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,65);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"mailto:"+A140emailsDestinatarios,(String)"",(String)"",(String)"",(String)edtemailsDestinatarios_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtemailsDestinatarios_Enabled,(short)0,(String)"email",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)63,(short)1,(short)-1,(short)0,(bool)true,(String)"GeneXus\\Email",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_24_" + sGXsfl_63_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_63_idx + "',63)\"";
         ROClassString = "Attribute";
         Gridemails_level1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtnameDestinatario_Internalname,(String)A141nameDestinatario,(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtnameDestinatario_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtnameDestinatario_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)63,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_24_" + sGXsfl_63_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 67,'',false,'" + sGXsfl_63_idx + "',63)\"";
         ROClassString = "Attribute";
         Gridemails_level1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtccDestinatario_Internalname,(String)A142ccDestinatario,(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,67);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtccDestinatario_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtccDestinatario_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)63,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         context.httpAjaxContext.ajax_sending_grid_row(Gridemails_level1Row);
         send_integrity_lvl_hashes0L24( ) ;
         GXCCtl = "Z30sec_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z30sec), 4, 0, ",", "")));
         GXCCtl = "Z140emailsDestinatarios_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, Z140emailsDestinatarios);
         GXCCtl = "Z141nameDestinatario_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, Z141nameDestinatario);
         GXCCtl = "Z142ccDestinatario_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, Z142ccDestinatario);
         GXCCtl = "nRcdDeleted_24_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_24), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_24_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_24), 4, 0, ",", "")));
         GXCCtl = "nIsMod_24_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_24), 4, 0, ",", "")));
         GXCCtl = "vMODE_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_63_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV9TrnContext);
         }
         GXCCtl = "vEMAILID_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11emailID), 4, 0, ",", "")));
         GXCCtl = "vUSUCOD_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( AV7UsuCod));
         GxWebStd.gx_hidden_field( context, "SEC_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsec_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "EMAILSDESTINATARIOS_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtemailsDestinatarios_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "NAMEDESTINATARIO_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtnameDestinatario_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CCDESTINATARIO_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtccDestinatario_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridemails_level1Container.AddRow(Gridemails_level1Row);
      }

      protected void ReadRow0L24( )
      {
         nGXsfl_63_idx = (short)(nGXsfl_63_idx+1);
         sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx), 4, 0)), 4, "0");
         SubsflControlProps_6324( ) ;
         edtsec_Enabled = (int)(context.localUtil.CToN( cgiGet( "SEC_"+sGXsfl_63_idx+"Enabled"), ",", "."));
         edtemailsDestinatarios_Enabled = (int)(context.localUtil.CToN( cgiGet( "EMAILSDESTINATARIOS_"+sGXsfl_63_idx+"Enabled"), ",", "."));
         edtnameDestinatario_Enabled = (int)(context.localUtil.CToN( cgiGet( "NAMEDESTINATARIO_"+sGXsfl_63_idx+"Enabled"), ",", "."));
         edtccDestinatario_Enabled = (int)(context.localUtil.CToN( cgiGet( "CCDESTINATARIO_"+sGXsfl_63_idx+"Enabled"), ",", "."));
         if ( ( ( context.localUtil.CToN( cgiGet( edtsec_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtsec_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "SEC_" + sGXsfl_63_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtsec_Internalname;
            wbErr = true;
            A30sec = 0;
         }
         else
         {
            A30sec = (short)(context.localUtil.CToN( cgiGet( edtsec_Internalname), ",", "."));
         }
         A140emailsDestinatarios = cgiGet( edtemailsDestinatarios_Internalname);
         n140emailsDestinatarios = false;
         n140emailsDestinatarios = (String.IsNullOrEmpty(StringUtil.RTrim( A140emailsDestinatarios)) ? true : false);
         A141nameDestinatario = cgiGet( edtnameDestinatario_Internalname);
         n141nameDestinatario = false;
         n141nameDestinatario = (String.IsNullOrEmpty(StringUtil.RTrim( A141nameDestinatario)) ? true : false);
         A142ccDestinatario = cgiGet( edtccDestinatario_Internalname);
         n142ccDestinatario = false;
         n142ccDestinatario = (String.IsNullOrEmpty(StringUtil.RTrim( A142ccDestinatario)) ? true : false);
         GXCCtl = "Z30sec_" + sGXsfl_63_idx;
         Z30sec = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z140emailsDestinatarios_" + sGXsfl_63_idx;
         Z140emailsDestinatarios = cgiGet( GXCCtl);
         n140emailsDestinatarios = (String.IsNullOrEmpty(StringUtil.RTrim( A140emailsDestinatarios)) ? true : false);
         GXCCtl = "Z141nameDestinatario_" + sGXsfl_63_idx;
         Z141nameDestinatario = cgiGet( GXCCtl);
         n141nameDestinatario = (String.IsNullOrEmpty(StringUtil.RTrim( A141nameDestinatario)) ? true : false);
         GXCCtl = "Z142ccDestinatario_" + sGXsfl_63_idx;
         Z142ccDestinatario = cgiGet( GXCCtl);
         n142ccDestinatario = (String.IsNullOrEmpty(StringUtil.RTrim( A142ccDestinatario)) ? true : false);
         GXCCtl = "nRcdDeleted_24_" + sGXsfl_63_idx;
         nRcdDeleted_24 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_24_" + sGXsfl_63_idx;
         nRcdExists_24 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_24_" + sGXsfl_63_idx;
         nIsMod_24 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void assign_properties_default( )
      {
         defedtsec_Enabled = edtsec_Enabled;
      }

      protected void ConfirmValues0L0( )
      {
         nGXsfl_63_idx = 0;
         sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx), 4, 0)), 4, "0");
         SubsflControlProps_6324( ) ;
         while ( nGXsfl_63_idx < nRC_GXsfl_63 )
         {
            nGXsfl_63_idx = (short)(nGXsfl_63_idx+1);
            sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx), 4, 0)), 4, "0");
            SubsflControlProps_6324( ) ;
            ChangePostValue( "Z30sec_"+sGXsfl_63_idx, cgiGet( "ZT_"+"Z30sec_"+sGXsfl_63_idx)) ;
            DeletePostValue( "ZT_"+"Z30sec_"+sGXsfl_63_idx) ;
            ChangePostValue( "Z140emailsDestinatarios_"+sGXsfl_63_idx, cgiGet( "ZT_"+"Z140emailsDestinatarios_"+sGXsfl_63_idx)) ;
            DeletePostValue( "ZT_"+"Z140emailsDestinatarios_"+sGXsfl_63_idx) ;
            ChangePostValue( "Z141nameDestinatario_"+sGXsfl_63_idx, cgiGet( "ZT_"+"Z141nameDestinatario_"+sGXsfl_63_idx)) ;
            DeletePostValue( "ZT_"+"Z141nameDestinatario_"+sGXsfl_63_idx) ;
            ChangePostValue( "Z142ccDestinatario_"+sGXsfl_63_idx, cgiGet( "ZT_"+"Z142ccDestinatario_"+sGXsfl_63_idx)) ;
            DeletePostValue( "ZT_"+"Z142ccDestinatario_"+sGXsfl_63_idx) ;
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
         context.SendWebValue( "Emails") ;
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
         context.AddJavascriptSource("gxcfg.js", "?202321215184540", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("emails.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV11emailID) + "," + UrlEncode(StringUtil.RTrim(AV7UsuCod))+"\">") ;
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
         forbiddenHiddens = "hsh" + "Emails";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("emails:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z29emailID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z29emailID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z3UsuCod", StringUtil.RTrim( Z3UsuCod));
         GxWebStd.gx_hidden_field( context, "Z139emailReg", context.localUtil.DToC( Z139emailReg, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z143emailUltNro", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z143emailUltNro), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "O143emailUltNro", StringUtil.LTrim( StringUtil.NToC( (decimal)(O143emailUltNro), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_63", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_63_idx), 4, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vEMAILID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11emailID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMAILID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV11emailID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vUSUCOD", StringUtil.RTrim( AV7UsuCod));
         GxWebStd.gx_hidden_field( context, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV7UsuCod, "")), context));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV15Pgmname));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void RenderHtmlCloseForm0L23( )
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
         return "Emails" ;
      }

      public override String GetPgmdesc( )
      {
         return "Emails" ;
      }

      protected void InitializeNonKey0L23( )
      {
         A50UsuName = "";
         n50UsuName = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50UsuName", A50UsuName);
         A139emailReg = DateTime.MinValue;
         n139emailReg = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A139emailReg", context.localUtil.Format(A139emailReg, "99/99/99"));
         n139emailReg = ((DateTime.MinValue==A139emailReg) ? true : false);
         A143emailUltNro = 0;
         n143emailUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143emailUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A143emailUltNro), 4, 0)));
         n143emailUltNro = ((0==A143emailUltNro) ? true : false);
         O143emailUltNro = A143emailUltNro;
         n143emailUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143emailUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A143emailUltNro), 4, 0)));
         Z139emailReg = DateTime.MinValue;
         Z143emailUltNro = 0;
      }

      protected void InitAll0L23( )
      {
         A29emailID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29emailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A29emailID), 4, 0)));
         A3UsuCod = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
         InitializeNonKey0L23( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey0L24( )
      {
         A140emailsDestinatarios = "";
         n140emailsDestinatarios = false;
         A141nameDestinatario = "";
         n141nameDestinatario = false;
         A142ccDestinatario = "";
         n142ccDestinatario = false;
         Z140emailsDestinatarios = "";
         Z141nameDestinatario = "";
         Z142ccDestinatario = "";
      }

      protected void InitAll0L24( )
      {
         A30sec = 0;
         InitializeNonKey0L24( ) ;
      }

      protected void StandaloneModalInsert0L24( )
      {
         A143emailUltNro = i143emailUltNro;
         n143emailUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143emailUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A143emailUltNro), 4, 0)));
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202321215184591", true);
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
         context.AddJavascriptSource("emails.js", "?202321215184592", false);
         /* End function include_jscripts */
      }

      protected void init_level_properties24( )
      {
         edtsec_Enabled = defedtsec_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsec_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
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
         edtemailID_Internalname = "EMAILID";
         edtUsuCod_Internalname = "USUCOD";
         edtUsuName_Internalname = "USUNAME";
         edtemailReg_Internalname = "EMAILREG";
         edtemailUltNro_Internalname = "EMAILULTNRO";
         lblTitlelevel1_Internalname = "TITLELEVEL1";
         edtsec_Internalname = "SEC";
         edtemailsDestinatarios_Internalname = "EMAILSDESTINATARIOS";
         edtnameDestinatario_Internalname = "NAMEDESTINATARIO";
         edtccDestinatario_Internalname = "CCDESTINATARIO";
         divLevel1table_Internalname = "LEVEL1TABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_3_Internalname = "PROMPT_3";
         subGridemails_level1_Internalname = "GRIDEMAILS_LEVEL1";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtccDestinatario_Jsonclick = "";
         edtnameDestinatario_Jsonclick = "";
         edtemailsDestinatarios_Jsonclick = "";
         edtsec_Jsonclick = "";
         subGridemails_level1_Class = "Grid";
         subGridemails_level1_Backcolorstyle = 0;
         subGridemails_level1_Allowcollapsing = 0;
         subGridemails_level1_Allowselection = 0;
         edtccDestinatario_Enabled = 1;
         edtnameDestinatario_Enabled = 1;
         edtemailsDestinatarios_Enabled = 1;
         edtsec_Enabled = 1;
         subGridemails_level1_Header = "";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtemailUltNro_Jsonclick = "";
         edtemailUltNro_Enabled = 0;
         edtemailReg_Jsonclick = "";
         edtemailReg_Enabled = 1;
         edtUsuName_Jsonclick = "";
         edtUsuName_Enabled = 0;
         imgprompt_3_Visible = 1;
         imgprompt_3_Link = "";
         edtUsuCod_Jsonclick = "";
         edtUsuCod_Enabled = 1;
         edtemailID_Jsonclick = "";
         edtemailID_Enabled = 1;
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

      protected void GX2ASAEMAILID0L23( short AV11emailID )
      {
         if ( ! (0==AV11emailID) )
         {
            A29emailID = AV11emailID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29emailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A29emailID), 4, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               GXt_int1 = A29emailID;
               new obtnewemailid(context ).execute( out  GXt_int1) ;
               A29emailID = GXt_int1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29emailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A29emailID), 4, 0)));
            }
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A29emailID), 4, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void gxnrGridemails_level1_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_6324( ) ;
         while ( nGXsfl_63_idx <= nRC_GXsfl_63 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0L24( ) ;
            standaloneModal0L24( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow0L24( ) ;
            nGXsfl_63_idx = (short)(nGXsfl_63_idx+1);
            sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx), 4, 0)), 4, "0");
            SubsflControlProps_6324( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Gridemails_level1Container));
         /* End function gxnrGridemails_level1_newrow */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      public void Valid_Usucod( String GX_Parm1 ,
                                String GX_Parm2 )
      {
         A3UsuCod = GX_Parm1;
         A50UsuName = GX_Parm2;
         n50UsuName = false;
         /* Using cursor T000L15 */
         pr_default.execute(13, new Object[] {A3UsuCod});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("No existe 'Usuarios'.", "ForeignKeyNotFound", 1, "USUCOD");
            AnyError = 1;
            GX_FocusControl = edtUsuCod_Internalname;
         }
         A50UsuName = T000L15_A50UsuName[0];
         n50UsuName = T000L15_n50UsuName[0];
         pr_default.close(13);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A50UsuName = "";
            n50UsuName = false;
         }
         isValidOutput.Add(A50UsuName);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11emailID',fld:'vEMAILID',pic:'ZZZ9',hsh:true},{av:'AV7UsuCod',fld:'vUSUCOD',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11emailID',fld:'vEMAILID',pic:'ZZZ9',hsh:true},{av:'AV7UsuCod',fld:'vUSUCOD',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120L2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(3);
         pr_default.close(13);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         wcpOAV7UsuCod = "";
         Z3UsuCod = "";
         Z139emailReg = DateTime.MinValue;
         Z140emailsDestinatarios = "";
         Z141nameDestinatario = "";
         Z142ccDestinatario = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         A3UsuCod = "";
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
         A50UsuName = "";
         A139emailReg = DateTime.MinValue;
         lblTitlelevel1_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridemails_level1Container = new GXWebGrid( context);
         Gridemails_level1Column = new GXWebColumn();
         A140emailsDestinatarios = "";
         A141nameDestinatario = "";
         A142ccDestinatario = "";
         sMode24 = "";
         sStyleString = "";
         AV15Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode23 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         Z50UsuName = "";
         T000L6_A50UsuName = new String[] {""} ;
         T000L6_n50UsuName = new bool[] {false} ;
         T000L7_A29emailID = new short[1] ;
         T000L7_A50UsuName = new String[] {""} ;
         T000L7_n50UsuName = new bool[] {false} ;
         T000L7_A139emailReg = new DateTime[] {DateTime.MinValue} ;
         T000L7_n139emailReg = new bool[] {false} ;
         T000L7_A143emailUltNro = new short[1] ;
         T000L7_n143emailUltNro = new bool[] {false} ;
         T000L7_A3UsuCod = new String[] {""} ;
         T000L8_A50UsuName = new String[] {""} ;
         T000L8_n50UsuName = new bool[] {false} ;
         T000L9_A29emailID = new short[1] ;
         T000L9_A3UsuCod = new String[] {""} ;
         T000L5_A29emailID = new short[1] ;
         T000L5_A139emailReg = new DateTime[] {DateTime.MinValue} ;
         T000L5_n139emailReg = new bool[] {false} ;
         T000L5_A143emailUltNro = new short[1] ;
         T000L5_n143emailUltNro = new bool[] {false} ;
         T000L5_A3UsuCod = new String[] {""} ;
         T000L10_A29emailID = new short[1] ;
         T000L10_A3UsuCod = new String[] {""} ;
         T000L11_A29emailID = new short[1] ;
         T000L11_A3UsuCod = new String[] {""} ;
         T000L4_A29emailID = new short[1] ;
         T000L4_A139emailReg = new DateTime[] {DateTime.MinValue} ;
         T000L4_n139emailReg = new bool[] {false} ;
         T000L4_A143emailUltNro = new short[1] ;
         T000L4_n143emailUltNro = new bool[] {false} ;
         T000L4_A3UsuCod = new String[] {""} ;
         T000L15_A50UsuName = new String[] {""} ;
         T000L15_n50UsuName = new bool[] {false} ;
         T000L17_A29emailID = new short[1] ;
         T000L17_A3UsuCod = new String[] {""} ;
         T000L18_A29emailID = new short[1] ;
         T000L18_A3UsuCod = new String[] {""} ;
         T000L18_A30sec = new short[1] ;
         T000L18_A140emailsDestinatarios = new String[] {""} ;
         T000L18_n140emailsDestinatarios = new bool[] {false} ;
         T000L18_A141nameDestinatario = new String[] {""} ;
         T000L18_n141nameDestinatario = new bool[] {false} ;
         T000L18_A142ccDestinatario = new String[] {""} ;
         T000L18_n142ccDestinatario = new bool[] {false} ;
         T000L19_A29emailID = new short[1] ;
         T000L19_A3UsuCod = new String[] {""} ;
         T000L19_A30sec = new short[1] ;
         T000L3_A29emailID = new short[1] ;
         T000L3_A3UsuCod = new String[] {""} ;
         T000L3_A30sec = new short[1] ;
         T000L3_A140emailsDestinatarios = new String[] {""} ;
         T000L3_n140emailsDestinatarios = new bool[] {false} ;
         T000L3_A141nameDestinatario = new String[] {""} ;
         T000L3_n141nameDestinatario = new bool[] {false} ;
         T000L3_A142ccDestinatario = new String[] {""} ;
         T000L3_n142ccDestinatario = new bool[] {false} ;
         T000L2_A29emailID = new short[1] ;
         T000L2_A3UsuCod = new String[] {""} ;
         T000L2_A30sec = new short[1] ;
         T000L2_A140emailsDestinatarios = new String[] {""} ;
         T000L2_n140emailsDestinatarios = new bool[] {false} ;
         T000L2_A141nameDestinatario = new String[] {""} ;
         T000L2_n141nameDestinatario = new bool[] {false} ;
         T000L2_A142ccDestinatario = new String[] {""} ;
         T000L2_n142ccDestinatario = new bool[] {false} ;
         T000L23_A29emailID = new short[1] ;
         T000L23_A3UsuCod = new String[] {""} ;
         T000L23_A30sec = new short[1] ;
         Gridemails_level1Row = new GXWebRow();
         subGridemails_level1_Linesclass = "";
         ROClassString = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.emails__default(),
            new Object[][] {
                new Object[] {
               T000L2_A29emailID, T000L2_A3UsuCod, T000L2_A30sec, T000L2_A140emailsDestinatarios, T000L2_n140emailsDestinatarios, T000L2_A141nameDestinatario, T000L2_n141nameDestinatario, T000L2_A142ccDestinatario, T000L2_n142ccDestinatario
               }
               , new Object[] {
               T000L3_A29emailID, T000L3_A3UsuCod, T000L3_A30sec, T000L3_A140emailsDestinatarios, T000L3_n140emailsDestinatarios, T000L3_A141nameDestinatario, T000L3_n141nameDestinatario, T000L3_A142ccDestinatario, T000L3_n142ccDestinatario
               }
               , new Object[] {
               T000L4_A29emailID, T000L4_A139emailReg, T000L4_n139emailReg, T000L4_A143emailUltNro, T000L4_n143emailUltNro, T000L4_A3UsuCod
               }
               , new Object[] {
               T000L5_A29emailID, T000L5_A139emailReg, T000L5_n139emailReg, T000L5_A143emailUltNro, T000L5_n143emailUltNro, T000L5_A3UsuCod
               }
               , new Object[] {
               T000L6_A50UsuName, T000L6_n50UsuName
               }
               , new Object[] {
               T000L7_A29emailID, T000L7_A50UsuName, T000L7_n50UsuName, T000L7_A139emailReg, T000L7_n139emailReg, T000L7_A143emailUltNro, T000L7_n143emailUltNro, T000L7_A3UsuCod
               }
               , new Object[] {
               T000L8_A50UsuName, T000L8_n50UsuName
               }
               , new Object[] {
               T000L9_A29emailID, T000L9_A3UsuCod
               }
               , new Object[] {
               T000L10_A29emailID, T000L10_A3UsuCod
               }
               , new Object[] {
               T000L11_A29emailID, T000L11_A3UsuCod
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000L15_A50UsuName, T000L15_n50UsuName
               }
               , new Object[] {
               }
               , new Object[] {
               T000L17_A29emailID, T000L17_A3UsuCod
               }
               , new Object[] {
               T000L18_A29emailID, T000L18_A3UsuCod, T000L18_A30sec, T000L18_A140emailsDestinatarios, T000L18_n140emailsDestinatarios, T000L18_A141nameDestinatario, T000L18_n141nameDestinatario, T000L18_A142ccDestinatario, T000L18_n142ccDestinatario
               }
               , new Object[] {
               T000L19_A29emailID, T000L19_A3UsuCod, T000L19_A30sec
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000L23_A29emailID, T000L23_A3UsuCod, T000L23_A30sec
               }
            }
         );
         AV15Pgmname = "Emails";
      }

      private short wcpOAV11emailID ;
      private short Z29emailID ;
      private short Z143emailUltNro ;
      private short O143emailUltNro ;
      private short nRC_GXsfl_63 ;
      private short nGXsfl_63_idx=1 ;
      private short Z30sec ;
      private short nRcdDeleted_24 ;
      private short nRcdExists_24 ;
      private short nIsMod_24 ;
      private short GxWebError ;
      private short AV11emailID ;
      private short A143emailUltNro ;
      private short Gx_BScreen ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short A29emailID ;
      private short subGridemails_level1_Backcolorstyle ;
      private short A30sec ;
      private short subGridemails_level1_Allowselection ;
      private short subGridemails_level1_Allowhovering ;
      private short subGridemails_level1_Allowcollapsing ;
      private short subGridemails_level1_Collapsed ;
      private short nBlankRcdCount24 ;
      private short RcdFound24 ;
      private short B143emailUltNro ;
      private short nBlankRcdUsr24 ;
      private short RcdFound23 ;
      private short s143emailUltNro ;
      private short GX_JID ;
      private short subGridemails_level1_Backstyle ;
      private short i143emailUltNro ;
      private short GXt_int1 ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtemailID_Enabled ;
      private int edtUsuCod_Enabled ;
      private int imgprompt_3_Visible ;
      private int edtUsuName_Enabled ;
      private int edtemailReg_Enabled ;
      private int edtemailUltNro_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtsec_Enabled ;
      private int edtemailsDestinatarios_Enabled ;
      private int edtnameDestinatario_Enabled ;
      private int edtccDestinatario_Enabled ;
      private int subGridemails_level1_Selectedindex ;
      private int subGridemails_level1_Selectioncolor ;
      private int subGridemails_level1_Hoveringcolor ;
      private int fRowAdded ;
      private int subGridemails_level1_Backcolor ;
      private int subGridemails_level1_Allbackcolor ;
      private int defedtsec_Enabled ;
      private int idxLst ;
      private long GRIDEMAILS_LEVEL1_nFirstRecordOnPage ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String wcpOAV7UsuCod ;
      private String Z3UsuCod ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String A3UsuCod ;
      private String sGXsfl_63_idx="0001" ;
      private String Gx_mode ;
      private String AV7UsuCod ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtemailID_Internalname ;
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
      private String edtemailID_Jsonclick ;
      private String edtUsuCod_Internalname ;
      private String edtUsuCod_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_3_Internalname ;
      private String imgprompt_3_Link ;
      private String edtUsuName_Internalname ;
      private String edtUsuName_Jsonclick ;
      private String edtemailReg_Internalname ;
      private String edtemailReg_Jsonclick ;
      private String edtemailUltNro_Internalname ;
      private String edtemailUltNro_Jsonclick ;
      private String divLevel1table_Internalname ;
      private String lblTitlelevel1_Internalname ;
      private String lblTitlelevel1_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridemails_level1_Header ;
      private String sMode24 ;
      private String edtsec_Internalname ;
      private String edtemailsDestinatarios_Internalname ;
      private String edtnameDestinatario_Internalname ;
      private String edtccDestinatario_Internalname ;
      private String sStyleString ;
      private String AV15Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode23 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String sGXsfl_63_fel_idx="0001" ;
      private String subGridemails_level1_Class ;
      private String subGridemails_level1_Linesclass ;
      private String ROClassString ;
      private String edtsec_Jsonclick ;
      private String edtemailsDestinatarios_Jsonclick ;
      private String edtnameDestinatario_Jsonclick ;
      private String edtccDestinatario_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridemails_level1_Internalname ;
      private DateTime Z139emailReg ;
      private DateTime A139emailReg ;
      private bool entryPointCalled ;
      private bool n143emailUltNro ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool bGXsfl_63_Refreshing=false ;
      private bool n50UsuName ;
      private bool n139emailReg ;
      private bool returnInSub ;
      private bool n140emailsDestinatarios ;
      private bool n141nameDestinatario ;
      private bool n142ccDestinatario ;
      private String Z140emailsDestinatarios ;
      private String Z141nameDestinatario ;
      private String Z142ccDestinatario ;
      private String A50UsuName ;
      private String A140emailsDestinatarios ;
      private String A141nameDestinatario ;
      private String A142ccDestinatario ;
      private String Z50UsuName ;
      private IGxSession AV10WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebGrid Gridemails_level1Container ;
      private GXWebRow Gridemails_level1Row ;
      private GXWebColumn Gridemails_level1Column ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T000L6_A50UsuName ;
      private bool[] T000L6_n50UsuName ;
      private short[] T000L7_A29emailID ;
      private String[] T000L7_A50UsuName ;
      private bool[] T000L7_n50UsuName ;
      private DateTime[] T000L7_A139emailReg ;
      private bool[] T000L7_n139emailReg ;
      private short[] T000L7_A143emailUltNro ;
      private bool[] T000L7_n143emailUltNro ;
      private String[] T000L7_A3UsuCod ;
      private String[] T000L8_A50UsuName ;
      private bool[] T000L8_n50UsuName ;
      private short[] T000L9_A29emailID ;
      private String[] T000L9_A3UsuCod ;
      private short[] T000L5_A29emailID ;
      private DateTime[] T000L5_A139emailReg ;
      private bool[] T000L5_n139emailReg ;
      private short[] T000L5_A143emailUltNro ;
      private bool[] T000L5_n143emailUltNro ;
      private String[] T000L5_A3UsuCod ;
      private short[] T000L10_A29emailID ;
      private String[] T000L10_A3UsuCod ;
      private short[] T000L11_A29emailID ;
      private String[] T000L11_A3UsuCod ;
      private short[] T000L4_A29emailID ;
      private DateTime[] T000L4_A139emailReg ;
      private bool[] T000L4_n139emailReg ;
      private short[] T000L4_A143emailUltNro ;
      private bool[] T000L4_n143emailUltNro ;
      private String[] T000L4_A3UsuCod ;
      private String[] T000L15_A50UsuName ;
      private bool[] T000L15_n50UsuName ;
      private short[] T000L17_A29emailID ;
      private String[] T000L17_A3UsuCod ;
      private short[] T000L18_A29emailID ;
      private String[] T000L18_A3UsuCod ;
      private short[] T000L18_A30sec ;
      private String[] T000L18_A140emailsDestinatarios ;
      private bool[] T000L18_n140emailsDestinatarios ;
      private String[] T000L18_A141nameDestinatario ;
      private bool[] T000L18_n141nameDestinatario ;
      private String[] T000L18_A142ccDestinatario ;
      private bool[] T000L18_n142ccDestinatario ;
      private short[] T000L19_A29emailID ;
      private String[] T000L19_A3UsuCod ;
      private short[] T000L19_A30sec ;
      private short[] T000L3_A29emailID ;
      private String[] T000L3_A3UsuCod ;
      private short[] T000L3_A30sec ;
      private String[] T000L3_A140emailsDestinatarios ;
      private bool[] T000L3_n140emailsDestinatarios ;
      private String[] T000L3_A141nameDestinatario ;
      private bool[] T000L3_n141nameDestinatario ;
      private String[] T000L3_A142ccDestinatario ;
      private bool[] T000L3_n142ccDestinatario ;
      private short[] T000L2_A29emailID ;
      private String[] T000L2_A3UsuCod ;
      private short[] T000L2_A30sec ;
      private String[] T000L2_A140emailsDestinatarios ;
      private bool[] T000L2_n140emailsDestinatarios ;
      private String[] T000L2_A141nameDestinatario ;
      private bool[] T000L2_n141nameDestinatario ;
      private String[] T000L2_A142ccDestinatario ;
      private bool[] T000L2_n142ccDestinatario ;
      private short[] T000L23_A29emailID ;
      private String[] T000L23_A3UsuCod ;
      private short[] T000L23_A30sec ;
      private SdtTransactionContext AV9TrnContext ;
   }

   public class emails__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new UpdateCursor(def[18])
         ,new UpdateCursor(def[19])
         ,new UpdateCursor(def[20])
         ,new ForEachCursor(def[21])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000L7 ;
          prmT000L7 = new Object[] {
          new Object[] {"@emailID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000L6 ;
          prmT000L6 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000L8 ;
          prmT000L8 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000L9 ;
          prmT000L9 = new Object[] {
          new Object[] {"@emailID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000L5 ;
          prmT000L5 = new Object[] {
          new Object[] {"@emailID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000L10 ;
          prmT000L10 = new Object[] {
          new Object[] {"@emailID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000L11 ;
          prmT000L11 = new Object[] {
          new Object[] {"@emailID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000L4 ;
          prmT000L4 = new Object[] {
          new Object[] {"@emailID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000L12 ;
          prmT000L12 = new Object[] {
          new Object[] {"@emailID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@emailReg",SqlDbType.DateTime,8,0} ,
          new Object[] {"@emailUltNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000L13 ;
          prmT000L13 = new Object[] {
          new Object[] {"@emailReg",SqlDbType.DateTime,8,0} ,
          new Object[] {"@emailUltNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@emailID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000L14 ;
          prmT000L14 = new Object[] {
          new Object[] {"@emailID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000L16 ;
          prmT000L16 = new Object[] {
          new Object[] {"@emailUltNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@emailID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000L17 ;
          prmT000L17 = new Object[] {
          } ;
          Object[] prmT000L18 ;
          prmT000L18 = new Object[] {
          new Object[] {"@emailID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@UsuCod",SqlDbType.Char,15,0} ,
          new Object[] {"@sec",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000L19 ;
          prmT000L19 = new Object[] {
          new Object[] {"@emailID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@UsuCod",SqlDbType.Char,15,0} ,
          new Object[] {"@sec",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000L3 ;
          prmT000L3 = new Object[] {
          new Object[] {"@emailID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@UsuCod",SqlDbType.Char,15,0} ,
          new Object[] {"@sec",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000L2 ;
          prmT000L2 = new Object[] {
          new Object[] {"@emailID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@UsuCod",SqlDbType.Char,15,0} ,
          new Object[] {"@sec",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000L20 ;
          prmT000L20 = new Object[] {
          new Object[] {"@emailID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@UsuCod",SqlDbType.Char,15,0} ,
          new Object[] {"@sec",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@emailsDestinatarios",SqlDbType.VarChar,100,0} ,
          new Object[] {"@nameDestinatario",SqlDbType.VarChar,50,0} ,
          new Object[] {"@ccDestinatario",SqlDbType.VarChar,100,0}
          } ;
          Object[] prmT000L21 ;
          prmT000L21 = new Object[] {
          new Object[] {"@emailsDestinatarios",SqlDbType.VarChar,100,0} ,
          new Object[] {"@nameDestinatario",SqlDbType.VarChar,50,0} ,
          new Object[] {"@ccDestinatario",SqlDbType.VarChar,100,0} ,
          new Object[] {"@emailID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@UsuCod",SqlDbType.Char,15,0} ,
          new Object[] {"@sec",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000L22 ;
          prmT000L22 = new Object[] {
          new Object[] {"@emailID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@UsuCod",SqlDbType.Char,15,0} ,
          new Object[] {"@sec",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000L23 ;
          prmT000L23 = new Object[] {
          new Object[] {"@emailID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000L15 ;
          prmT000L15 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000L2", "SELECT [emailID], [UsuCod], [sec], [emailsDestinatarios], [nameDestinatario], [ccDestinatario] FROM [EmailsLevel1] WITH (UPDLOCK) WHERE [emailID] = @emailID AND [UsuCod] = @UsuCod AND [sec] = @sec ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L2,1,0,true,false )
             ,new CursorDef("T000L3", "SELECT [emailID], [UsuCod], [sec], [emailsDestinatarios], [nameDestinatario], [ccDestinatario] FROM [EmailsLevel1] WITH (NOLOCK) WHERE [emailID] = @emailID AND [UsuCod] = @UsuCod AND [sec] = @sec ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L3,1,0,true,false )
             ,new CursorDef("T000L4", "SELECT [emailID], [emailReg], [emailUltNro], [UsuCod] FROM [Emails] WITH (UPDLOCK) WHERE [emailID] = @emailID AND [UsuCod] = @UsuCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L4,1,0,true,false )
             ,new CursorDef("T000L5", "SELECT [emailID], [emailReg], [emailUltNro], [UsuCod] FROM [Emails] WITH (NOLOCK) WHERE [emailID] = @emailID AND [UsuCod] = @UsuCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L5,1,0,true,false )
             ,new CursorDef("T000L6", "SELECT [UsuName] FROM [Usuarios] WITH (NOLOCK) WHERE [UsuCod] = @UsuCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L6,1,0,true,false )
             ,new CursorDef("T000L7", "SELECT TM1.[emailID], T2.[UsuName], TM1.[emailReg], TM1.[emailUltNro], TM1.[UsuCod] FROM ([Emails] TM1 WITH (NOLOCK) INNER JOIN [Usuarios] T2 WITH (NOLOCK) ON T2.[UsuCod] = TM1.[UsuCod]) WHERE TM1.[emailID] = @emailID and TM1.[UsuCod] = @UsuCod ORDER BY TM1.[emailID], TM1.[UsuCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000L7,100,0,true,false )
             ,new CursorDef("T000L8", "SELECT [UsuName] FROM [Usuarios] WITH (NOLOCK) WHERE [UsuCod] = @UsuCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L8,1,0,true,false )
             ,new CursorDef("T000L9", "SELECT [emailID], [UsuCod] FROM [Emails] WITH (NOLOCK) WHERE [emailID] = @emailID AND [UsuCod] = @UsuCod  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000L9,1,0,true,false )
             ,new CursorDef("T000L10", "SELECT TOP 1 [emailID], [UsuCod] FROM [Emails] WITH (NOLOCK) WHERE ( [emailID] > @emailID or [emailID] = @emailID and [UsuCod] > @UsuCod) ORDER BY [emailID], [UsuCod]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000L10,1,0,true,true )
             ,new CursorDef("T000L11", "SELECT TOP 1 [emailID], [UsuCod] FROM [Emails] WITH (NOLOCK) WHERE ( [emailID] < @emailID or [emailID] = @emailID and [UsuCod] < @UsuCod) ORDER BY [emailID] DESC, [UsuCod] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000L11,1,0,true,true )
             ,new CursorDef("T000L12", "INSERT INTO [Emails]([emailID], [emailReg], [emailUltNro], [UsuCod]) VALUES(@emailID, @emailReg, @emailUltNro, @UsuCod)", GxErrorMask.GX_NOMASK,prmT000L12)
             ,new CursorDef("T000L13", "UPDATE [Emails] SET [emailReg]=@emailReg, [emailUltNro]=@emailUltNro  WHERE [emailID] = @emailID AND [UsuCod] = @UsuCod", GxErrorMask.GX_NOMASK,prmT000L13)
             ,new CursorDef("T000L14", "DELETE FROM [Emails]  WHERE [emailID] = @emailID AND [UsuCod] = @UsuCod", GxErrorMask.GX_NOMASK,prmT000L14)
             ,new CursorDef("T000L15", "SELECT [UsuName] FROM [Usuarios] WITH (NOLOCK) WHERE [UsuCod] = @UsuCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L15,1,0,true,false )
             ,new CursorDef("T000L16", "UPDATE [Emails] SET [emailUltNro]=@emailUltNro  WHERE [emailID] = @emailID AND [UsuCod] = @UsuCod", GxErrorMask.GX_NOMASK,prmT000L16)
             ,new CursorDef("T000L17", "SELECT [emailID], [UsuCod] FROM [Emails] WITH (NOLOCK) ORDER BY [emailID], [UsuCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000L17,100,0,true,false )
             ,new CursorDef("T000L18", "SELECT [emailID], [UsuCod], [sec], [emailsDestinatarios], [nameDestinatario], [ccDestinatario] FROM [EmailsLevel1] WITH (NOLOCK) WHERE [emailID] = @emailID and [UsuCod] = @UsuCod and [sec] = @sec ORDER BY [emailID], [UsuCod], [sec] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L18,11,0,true,false )
             ,new CursorDef("T000L19", "SELECT [emailID], [UsuCod], [sec] FROM [EmailsLevel1] WITH (NOLOCK) WHERE [emailID] = @emailID AND [UsuCod] = @UsuCod AND [sec] = @sec ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L19,1,0,true,false )
             ,new CursorDef("T000L20", "INSERT INTO [EmailsLevel1]([emailID], [UsuCod], [sec], [emailsDestinatarios], [nameDestinatario], [ccDestinatario]) VALUES(@emailID, @UsuCod, @sec, @emailsDestinatarios, @nameDestinatario, @ccDestinatario)", GxErrorMask.GX_NOMASK,prmT000L20)
             ,new CursorDef("T000L21", "UPDATE [EmailsLevel1] SET [emailsDestinatarios]=@emailsDestinatarios, [nameDestinatario]=@nameDestinatario, [ccDestinatario]=@ccDestinatario  WHERE [emailID] = @emailID AND [UsuCod] = @UsuCod AND [sec] = @sec", GxErrorMask.GX_NOMASK,prmT000L21)
             ,new CursorDef("T000L22", "DELETE FROM [EmailsLevel1]  WHERE [emailID] = @emailID AND [UsuCod] = @UsuCod AND [sec] = @sec", GxErrorMask.GX_NOMASK,prmT000L22)
             ,new CursorDef("T000L23", "SELECT [emailID], [UsuCod], [sec] FROM [EmailsLevel1] WITH (NOLOCK) WHERE [emailID] = @emailID and [UsuCod] = @UsuCod ORDER BY [emailID], [UsuCod], [sec] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000L23,11,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((String[]) buf[7])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((String[]) buf[7])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 15) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 15) ;
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 15) ;
                return;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                return;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 15 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                return;
             case 16 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((String[]) buf[7])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                return;
             case 17 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 21 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
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
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[4]);
                }
                stmt.SetParameter(4, (String)parms[5]);
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
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[3]);
                }
                stmt.SetParameter(3, (short)parms[4]);
                stmt.SetParameter(4, (String)parms[5]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 14 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                stmt.SetParameter(2, (short)parms[2]);
                stmt.SetParameter(3, (String)parms[3]);
                return;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 18 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 4 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 5 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 6 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[8]);
                }
                return;
             case 19 :
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
                   stmt.setNull( 2 , SqlDbType.VarChar );
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
                stmt.SetParameter(4, (short)parms[6]);
                stmt.SetParameter(5, (String)parms[7]);
                stmt.SetParameter(6, (short)parms[8]);
                return;
             case 20 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 21 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
       }
    }

 }

}
