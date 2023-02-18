/*
               File: Marca
        Description: Marca
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/14/2023 1:15:36.4
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
   public class marca : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridmarca_modelo") == 0 )
         {
            nRC_GXsfl_63 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_63_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_63_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridmarca_modelo_newrow( ) ;
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
               AV7EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7EmpID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EmpID), "ZZZ9"), context));
               AV8MarcaID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8MarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8MarcaID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMARCAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8MarcaID), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Marca", 0) ;
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

      public marca( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public marca( IGxContext context )
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
                           short aP2_MarcaID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7EmpID = aP1_EmpID;
         this.AV8MarcaID = aP2_MarcaID;
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Marca", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Marca.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Marca.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Marca.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Marca.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Marca.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0060.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"MARCAID"+"'), id:'"+"MARCAID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_Marca.htm");
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
            GxWebStd.gx_single_line_edit( context, edtEmpID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEmpID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEmpID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Marca.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_1_Internalname, sImgUrl, imgprompt_1_Link, "", "", context.GetTheme( ), imgprompt_1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Marca.htm");
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
            GxWebStd.gx_single_line_edit( context, edtempdsc_Internalname, A44empdsc, StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempdsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtempdsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Marca.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtMarcaID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtMarcaID_Internalname, "ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtMarcaID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A6MarcaID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A6MarcaID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtMarcaID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtMarcaID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Marca.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtMarcaDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtMarcaDsc_Internalname, "Dsc", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtMarcaDsc_Internalname, StringUtil.RTrim( A62MarcaDsc), StringUtil.RTrim( context.localUtil.Format( A62MarcaDsc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtMarcaDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtMarcaDsc_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "Descripcion", "left", true, "HLP_Marca.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtMarcaEst_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtMarcaEst_Internalname, "Est", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtMarcaEst_Internalname, StringUtil.RTrim( A63MarcaEst), StringUtil.RTrim( context.localUtil.Format( A63MarcaEst, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtMarcaEst_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtMarcaEst_Enabled, 0, "text", "", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, -1, true, "estado", "left", true, "HLP_Marca.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divModelotable_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitlemodelo_Internalname, "Modelo", "", "", lblTitlemodelo_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Marca.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Gridmarca_modelo( ) ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Marca.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Marca.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 75,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Marca.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm046( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void gxdraw_Gridmarca_modelo( )
      {
         /*  Grid Control  */
         Gridmarca_modeloContainer.AddObjectProperty("GridName", "Gridmarca_modelo");
         Gridmarca_modeloContainer.AddObjectProperty("Header", subGridmarca_modelo_Header);
         Gridmarca_modeloContainer.AddObjectProperty("Class", "Grid");
         Gridmarca_modeloContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridmarca_modeloContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridmarca_modeloContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridmarca_modelo_Backcolorstyle), 1, 0, ".", "")));
         Gridmarca_modeloContainer.AddObjectProperty("CmpContext", "");
         Gridmarca_modeloContainer.AddObjectProperty("InMasterPage", "false");
         Gridmarca_modeloColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridmarca_modeloColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A7ModeloID), 4, 0, ".", "")));
         Gridmarca_modeloColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtModeloID_Enabled), 5, 0, ".", "")));
         Gridmarca_modeloContainer.AddColumnProperties(Gridmarca_modeloColumn);
         Gridmarca_modeloColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridmarca_modeloColumn.AddObjectProperty("Value", StringUtil.RTrim( A64ModeloDsc));
         Gridmarca_modeloColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtModeloDsc_Enabled), 5, 0, ".", "")));
         Gridmarca_modeloContainer.AddColumnProperties(Gridmarca_modeloColumn);
         Gridmarca_modeloColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridmarca_modeloColumn.AddObjectProperty("Value", StringUtil.RTrim( A65ModeloEst));
         Gridmarca_modeloColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtModeloEst_Enabled), 5, 0, ".", "")));
         Gridmarca_modeloContainer.AddColumnProperties(Gridmarca_modeloColumn);
         Gridmarca_modeloContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridmarca_modelo_Selectedindex), 4, 0, ".", "")));
         Gridmarca_modeloContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridmarca_modelo_Allowselection), 1, 0, ".", "")));
         Gridmarca_modeloContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridmarca_modelo_Selectioncolor), 9, 0, ".", "")));
         Gridmarca_modeloContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridmarca_modelo_Allowhovering), 1, 0, ".", "")));
         Gridmarca_modeloContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridmarca_modelo_Hoveringcolor), 9, 0, ".", "")));
         Gridmarca_modeloContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridmarca_modelo_Allowcollapsing), 1, 0, ".", "")));
         Gridmarca_modeloContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridmarca_modelo_Collapsed), 1, 0, ".", "")));
         nGXsfl_63_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount7 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_7 = 1;
               ScanStart047( ) ;
               while ( RcdFound7 != 0 )
               {
                  init_level_properties7( ) ;
                  getByPrimaryKey047( ) ;
                  AddRow047( ) ;
                  ScanNext047( ) ;
               }
               ScanEnd047( ) ;
               nBlankRcdCount7 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal047( ) ;
            standaloneModal047( ) ;
            sMode7 = Gx_mode;
            while ( nGXsfl_63_idx < nRC_GXsfl_63 )
            {
               bGXsfl_63_Refreshing = true;
               ReadRow047( ) ;
               edtModeloID_Enabled = (int)(context.localUtil.CToN( cgiGet( "MODELOID_"+sGXsfl_63_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtModeloID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtModeloID_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
               edtModeloDsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "MODELODSC_"+sGXsfl_63_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtModeloDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtModeloDsc_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
               edtModeloEst_Enabled = (int)(context.localUtil.CToN( cgiGet( "MODELOEST_"+sGXsfl_63_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtModeloEst_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtModeloEst_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
               if ( ( nRcdExists_7 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal047( ) ;
               }
               SendRow047( ) ;
               bGXsfl_63_Refreshing = false;
            }
            Gx_mode = sMode7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount7 = 5;
            nRcdExists_7 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart047( ) ;
               while ( RcdFound7 != 0 )
               {
                  sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_637( ) ;
                  init_level_properties7( ) ;
                  standaloneNotModal047( ) ;
                  getByPrimaryKey047( ) ;
                  standaloneModal047( ) ;
                  AddRow047( ) ;
                  ScanNext047( ) ;
               }
               ScanEnd047( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode7 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_637( ) ;
            InitAll047( ) ;
            init_level_properties7( ) ;
            standaloneNotModal047( ) ;
            standaloneModal047( ) ;
            nRcdExists_7 = 0;
            nIsMod_7 = 0;
            nRcdDeleted_7 = 0;
            nBlankRcdCount7 = (short)(nBlankRcdUsr7+nBlankRcdCount7);
            fRowAdded = 0;
            while ( nBlankRcdCount7 > 0 )
            {
               AddRow047( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtModeloID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount7 = (short)(nBlankRcdCount7-1);
            }
            Gx_mode = sMode7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridmarca_modeloContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridmarca_modelo", Gridmarca_modeloContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridmarca_modeloContainerData", Gridmarca_modeloContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridmarca_modeloContainerData"+"V", Gridmarca_modeloContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridmarca_modeloContainerData"+"V"+"\" value='"+Gridmarca_modeloContainer.GridValuesHidden()+"'/>") ;
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
         E11042 ();
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtMarcaID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtMarcaID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "MARCAID");
                  AnyError = 1;
                  GX_FocusControl = edtMarcaID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A6MarcaID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6MarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(A6MarcaID), 4, 0)));
               }
               else
               {
                  A6MarcaID = (short)(context.localUtil.CToN( cgiGet( edtMarcaID_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6MarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(A6MarcaID), 4, 0)));
               }
               A62MarcaDsc = cgiGet( edtMarcaDsc_Internalname);
               n62MarcaDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62MarcaDsc", A62MarcaDsc);
               n62MarcaDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A62MarcaDsc)) ? true : false);
               A63MarcaEst = cgiGet( edtMarcaEst_Internalname);
               n63MarcaEst = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63MarcaEst", A63MarcaEst);
               n63MarcaEst = (String.IsNullOrEmpty(StringUtil.RTrim( A63MarcaEst)) ? true : false);
               /* Read saved values. */
               Z1EmpID = (short)(context.localUtil.CToN( cgiGet( "Z1EmpID"), ",", "."));
               Z6MarcaID = (short)(context.localUtil.CToN( cgiGet( "Z6MarcaID"), ",", "."));
               Z62MarcaDsc = cgiGet( "Z62MarcaDsc");
               n62MarcaDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A62MarcaDsc)) ? true : false);
               Z63MarcaEst = cgiGet( "Z63MarcaEst");
               n63MarcaEst = (String.IsNullOrEmpty(StringUtil.RTrim( A63MarcaEst)) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_63 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_63"), ",", "."));
               AV7EmpID = (short)(context.localUtil.CToN( cgiGet( "vEMPID"), ",", "."));
               AV8MarcaID = (short)(context.localUtil.CToN( cgiGet( "vMARCAID"), ",", "."));
               AV12Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Marca";
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A1EmpID != Z1EmpID ) || ( A6MarcaID != Z6MarcaID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("marca:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
                  A6MarcaID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6MarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(A6MarcaID), 4, 0)));
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
                     sMode6 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode6;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound6 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_040( ) ;
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
                        E11042 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: After Trn */
                        E12042 ();
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
            E12042 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll046( ) ;
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
            DisableAttributes046( ) ;
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

      protected void CONFIRM_040( )
      {
         BeforeValidate046( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls046( ) ;
            }
            else
            {
               CheckExtendedTable046( ) ;
               CloseExtendedTableCursors046( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode6 = Gx_mode;
            CONFIRM_047( ) ;
            if ( AnyError == 0 )
            {
               /* Restore parent mode. */
               Gx_mode = sMode6;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
               IsConfirmed = 1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
            }
            /* Restore parent mode. */
            Gx_mode = sMode6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
      }

      protected void CONFIRM_047( )
      {
         nGXsfl_63_idx = 0;
         while ( nGXsfl_63_idx < nRC_GXsfl_63 )
         {
            ReadRow047( ) ;
            if ( ( nRcdExists_7 != 0 ) || ( nIsMod_7 != 0 ) )
            {
               GetKey047( ) ;
               if ( ( nRcdExists_7 == 0 ) && ( nRcdDeleted_7 == 0 ) )
               {
                  if ( RcdFound7 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate047( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable047( ) ;
                        CloseExtendedTableCursors047( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "MODELOID_" + sGXsfl_63_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtModeloID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound7 != 0 )
                  {
                     if ( nRcdDeleted_7 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey047( ) ;
                        Load047( ) ;
                        BeforeValidate047( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls047( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_7 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate047( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable047( ) ;
                              CloseExtendedTableCursors047( ) ;
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
                     if ( nRcdDeleted_7 == 0 )
                     {
                        GXCCtl = "MODELOID_" + sGXsfl_63_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtModeloID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtModeloID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A7ModeloID), 4, 0, ",", ""))) ;
            ChangePostValue( edtModeloDsc_Internalname, StringUtil.RTrim( A64ModeloDsc)) ;
            ChangePostValue( edtModeloEst_Internalname, StringUtil.RTrim( A65ModeloEst)) ;
            ChangePostValue( "ZT_"+"Z7ModeloID_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z7ModeloID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z64ModeloDsc_"+sGXsfl_63_idx, StringUtil.RTrim( Z64ModeloDsc)) ;
            ChangePostValue( "ZT_"+"Z65ModeloEst_"+sGXsfl_63_idx, StringUtil.RTrim( Z65ModeloEst)) ;
            ChangePostValue( "nRcdDeleted_7_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_7), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_7_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_7), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_7_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_7), 4, 0, ",", ""))) ;
            if ( nIsMod_7 != 0 )
            {
               ChangePostValue( "MODELOID_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtModeloID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "MODELODSC_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtModeloDsc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "MODELOEST_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtModeloEst_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption040( )
      {
      }

      protected void E11042( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV12Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV10TrnContext.FromXml(AV11WebSession.Get("TrnContext"), null, "TransactionContext", "KBCalpesa22");
      }

      protected void E12042( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV10TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwmarca.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM046( short GX_JID )
      {
         if ( ( GX_JID == 7 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z62MarcaDsc = T00045_A62MarcaDsc[0];
               Z63MarcaEst = T00045_A63MarcaEst[0];
            }
            else
            {
               Z62MarcaDsc = A62MarcaDsc;
               Z63MarcaEst = A63MarcaEst;
            }
         }
         if ( GX_JID == -7 )
         {
            Z6MarcaID = A6MarcaID;
            Z62MarcaDsc = A62MarcaDsc;
            Z63MarcaEst = A63MarcaEst;
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
         if ( ! (0==AV8MarcaID) )
         {
            A6MarcaID = AV8MarcaID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6MarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(A6MarcaID), 4, 0)));
         }
         if ( ! (0==AV8MarcaID) )
         {
            edtMarcaID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMarcaID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMarcaID_Enabled), 5, 0)), true);
         }
         else
         {
            edtMarcaID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMarcaID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMarcaID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV8MarcaID) )
         {
            edtMarcaID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMarcaID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMarcaID_Enabled), 5, 0)), true);
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
            /* Using cursor T00046 */
            pr_default.execute(4, new Object[] {A1EmpID});
            A44empdsc = T00046_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T00046_n44empdsc[0];
            pr_default.close(4);
            AV12Pgmname = "Marca";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Pgmname", AV12Pgmname);
         }
      }

      protected void Load046( )
      {
         /* Using cursor T00047 */
         pr_default.execute(5, new Object[] {A1EmpID, A6MarcaID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound6 = 1;
            A44empdsc = T00047_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T00047_n44empdsc[0];
            A62MarcaDsc = T00047_A62MarcaDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62MarcaDsc", A62MarcaDsc);
            n62MarcaDsc = T00047_n62MarcaDsc[0];
            A63MarcaEst = T00047_A63MarcaEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63MarcaEst", A63MarcaEst);
            n63MarcaEst = T00047_n63MarcaEst[0];
            ZM046( -7) ;
         }
         pr_default.close(5);
         OnLoadActions046( ) ;
      }

      protected void OnLoadActions046( )
      {
         AV12Pgmname = "Marca";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Pgmname", AV12Pgmname);
      }

      protected void CheckExtendedTable046( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV12Pgmname = "Marca";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Pgmname", AV12Pgmname);
         /* Using cursor T00046 */
         pr_default.execute(4, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T00046_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T00046_n44empdsc[0];
         pr_default.close(4);
      }

      protected void CloseExtendedTableCursors046( )
      {
         pr_default.close(4);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_8( short A1EmpID )
      {
         /* Using cursor T00048 */
         pr_default.execute(6, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T00048_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T00048_n44empdsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A44empdsc)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(6);
      }

      protected void GetKey046( )
      {
         /* Using cursor T00049 */
         pr_default.execute(7, new Object[] {A1EmpID, A6MarcaID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound6 = 1;
         }
         else
         {
            RcdFound6 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00045 */
         pr_default.execute(3, new Object[] {A1EmpID, A6MarcaID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM046( 7) ;
            RcdFound6 = 1;
            A6MarcaID = T00045_A6MarcaID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6MarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(A6MarcaID), 4, 0)));
            A62MarcaDsc = T00045_A62MarcaDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62MarcaDsc", A62MarcaDsc);
            n62MarcaDsc = T00045_n62MarcaDsc[0];
            A63MarcaEst = T00045_A63MarcaEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63MarcaEst", A63MarcaEst);
            n63MarcaEst = T00045_n63MarcaEst[0];
            A1EmpID = T00045_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            Z1EmpID = A1EmpID;
            Z6MarcaID = A6MarcaID;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load046( ) ;
            if ( AnyError == 1 )
            {
               RcdFound6 = 0;
               InitializeNonKey046( ) ;
            }
            Gx_mode = sMode6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound6 = 0;
            InitializeNonKey046( ) ;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(3);
      }

      protected void getEqualNoModal( )
      {
         GetKey046( ) ;
         if ( RcdFound6 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound6 = 0;
         /* Using cursor T000410 */
         pr_default.execute(8, new Object[] {A1EmpID, A6MarcaID});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000410_A1EmpID[0] < A1EmpID ) || ( T000410_A1EmpID[0] == A1EmpID ) && ( T000410_A6MarcaID[0] < A6MarcaID ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000410_A1EmpID[0] > A1EmpID ) || ( T000410_A1EmpID[0] == A1EmpID ) && ( T000410_A6MarcaID[0] > A6MarcaID ) ) )
            {
               A1EmpID = T000410_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A6MarcaID = T000410_A6MarcaID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6MarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(A6MarcaID), 4, 0)));
               RcdFound6 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound6 = 0;
         /* Using cursor T000411 */
         pr_default.execute(9, new Object[] {A1EmpID, A6MarcaID});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000411_A1EmpID[0] > A1EmpID ) || ( T000411_A1EmpID[0] == A1EmpID ) && ( T000411_A6MarcaID[0] > A6MarcaID ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000411_A1EmpID[0] < A1EmpID ) || ( T000411_A1EmpID[0] == A1EmpID ) && ( T000411_A6MarcaID[0] < A6MarcaID ) ) )
            {
               A1EmpID = T000411_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A6MarcaID = T000411_A6MarcaID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6MarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(A6MarcaID), 4, 0)));
               RcdFound6 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey046( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert046( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound6 == 1 )
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A6MarcaID != Z6MarcaID ) )
               {
                  A1EmpID = Z1EmpID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
                  A6MarcaID = Z6MarcaID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6MarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(A6MarcaID), 4, 0)));
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
                  Update046( ) ;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A6MarcaID != Z6MarcaID ) )
               {
                  /* Insert record */
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert046( ) ;
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
                     Insert046( ) ;
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
         if ( ( A1EmpID != Z1EmpID ) || ( A6MarcaID != Z6MarcaID ) )
         {
            A1EmpID = Z1EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A6MarcaID = Z6MarcaID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6MarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(A6MarcaID), 4, 0)));
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

      protected void CheckOptimisticConcurrency046( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00044 */
            pr_default.execute(2, new Object[] {A1EmpID, A6MarcaID});
            if ( (pr_default.getStatus(2) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Marca"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(2) == 101) || ( StringUtil.StrCmp(Z62MarcaDsc, T00044_A62MarcaDsc[0]) != 0 ) || ( StringUtil.StrCmp(Z63MarcaEst, T00044_A63MarcaEst[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z62MarcaDsc, T00044_A62MarcaDsc[0]) != 0 )
               {
                  GXUtil.WriteLog("marca:[seudo value changed for attri]"+"MarcaDsc");
                  GXUtil.WriteLogRaw("Old: ",Z62MarcaDsc);
                  GXUtil.WriteLogRaw("Current: ",T00044_A62MarcaDsc[0]);
               }
               if ( StringUtil.StrCmp(Z63MarcaEst, T00044_A63MarcaEst[0]) != 0 )
               {
                  GXUtil.WriteLog("marca:[seudo value changed for attri]"+"MarcaEst");
                  GXUtil.WriteLogRaw("Old: ",Z63MarcaEst);
                  GXUtil.WriteLogRaw("Current: ",T00044_A63MarcaEst[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Marca"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert046( )
      {
         BeforeValidate046( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable046( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM046( 0) ;
            CheckOptimisticConcurrency046( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm046( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert046( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000412 */
                     pr_default.execute(10, new Object[] {A6MarcaID, n62MarcaDsc, A62MarcaDsc, n63MarcaEst, A63MarcaEst, A1EmpID});
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("Marca") ;
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
                           ProcessLevel046( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption040( ) ;
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
               Load046( ) ;
            }
            EndLevel046( ) ;
         }
         CloseExtendedTableCursors046( ) ;
      }

      protected void Update046( )
      {
         BeforeValidate046( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable046( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency046( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm046( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate046( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000413 */
                     pr_default.execute(11, new Object[] {n62MarcaDsc, A62MarcaDsc, n63MarcaEst, A63MarcaEst, A1EmpID, A6MarcaID});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("Marca") ;
                     if ( (pr_default.getStatus(11) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Marca"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate046( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel046( ) ;
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
            EndLevel046( ) ;
         }
         CloseExtendedTableCursors046( ) ;
      }

      protected void DeferredUpdate046( )
      {
      }

      protected void delete( )
      {
         BeforeValidate046( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency046( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls046( ) ;
            AfterConfirm046( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete046( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart047( ) ;
                  while ( RcdFound7 != 0 )
                  {
                     getByPrimaryKey047( ) ;
                     Delete047( ) ;
                     ScanNext047( ) ;
                  }
                  ScanEnd047( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000414 */
                     pr_default.execute(12, new Object[] {A1EmpID, A6MarcaID});
                     pr_default.close(12);
                     dsDefault.SmartCacheProvider.SetUpdated("Marca") ;
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
         sMode6 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel046( ) ;
         Gx_mode = sMode6;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls046( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV12Pgmname = "Marca";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Pgmname", AV12Pgmname);
            /* Using cursor T000415 */
            pr_default.execute(13, new Object[] {A1EmpID});
            A44empdsc = T000415_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000415_n44empdsc[0];
            pr_default.close(13);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000416 */
            pr_default.execute(14, new Object[] {A1EmpID, A6MarcaID});
            if ( (pr_default.getStatus(14) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Orden Produccion"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(14);
            /* Using cursor T000417 */
            pr_default.execute(15, new Object[] {A1EmpID, A6MarcaID});
            if ( (pr_default.getStatus(15) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Vehiculos"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(15);
         }
      }

      protected void ProcessNestedLevel047( )
      {
         nGXsfl_63_idx = 0;
         while ( nGXsfl_63_idx < nRC_GXsfl_63 )
         {
            ReadRow047( ) ;
            if ( ( nRcdExists_7 != 0 ) || ( nIsMod_7 != 0 ) )
            {
               standaloneNotModal047( ) ;
               GetKey047( ) ;
               if ( ( nRcdExists_7 == 0 ) && ( nRcdDeleted_7 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert047( ) ;
               }
               else
               {
                  if ( RcdFound7 != 0 )
                  {
                     if ( ( nRcdDeleted_7 != 0 ) && ( nRcdExists_7 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete047( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_7 != 0 ) && ( nRcdExists_7 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update047( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_7 == 0 )
                     {
                        GXCCtl = "MODELOID_" + sGXsfl_63_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtModeloID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtModeloID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A7ModeloID), 4, 0, ",", ""))) ;
            ChangePostValue( edtModeloDsc_Internalname, StringUtil.RTrim( A64ModeloDsc)) ;
            ChangePostValue( edtModeloEst_Internalname, StringUtil.RTrim( A65ModeloEst)) ;
            ChangePostValue( "ZT_"+"Z7ModeloID_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z7ModeloID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z64ModeloDsc_"+sGXsfl_63_idx, StringUtil.RTrim( Z64ModeloDsc)) ;
            ChangePostValue( "ZT_"+"Z65ModeloEst_"+sGXsfl_63_idx, StringUtil.RTrim( Z65ModeloEst)) ;
            ChangePostValue( "nRcdDeleted_7_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_7), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_7_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_7), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_7_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_7), 4, 0, ",", ""))) ;
            if ( nIsMod_7 != 0 )
            {
               ChangePostValue( "MODELOID_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtModeloID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "MODELODSC_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtModeloDsc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "MODELOEST_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtModeloEst_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll047( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_7 = 0;
         nIsMod_7 = 0;
         nRcdDeleted_7 = 0;
      }

      protected void ProcessLevel046( )
      {
         /* Save parent mode. */
         sMode6 = Gx_mode;
         ProcessNestedLevel047( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode6;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         /* ' Update level parameters */
      }

      protected void EndLevel046( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(2);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete046( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(3);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(13);
            context.CommitDataStores("marca",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues040( ) ;
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
            context.RollbackDataStores("marca",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart046( )
      {
         /* Scan By routine */
         /* Using cursor T000418 */
         pr_default.execute(16);
         RcdFound6 = 0;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound6 = 1;
            A1EmpID = T000418_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A6MarcaID = T000418_A6MarcaID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6MarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(A6MarcaID), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext046( )
      {
         /* Scan next routine */
         pr_default.readNext(16);
         RcdFound6 = 0;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound6 = 1;
            A1EmpID = T000418_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A6MarcaID = T000418_A6MarcaID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6MarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(A6MarcaID), 4, 0)));
         }
      }

      protected void ScanEnd046( )
      {
         pr_default.close(16);
      }

      protected void AfterConfirm046( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert046( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate046( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete046( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete046( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate046( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes046( )
      {
         edtEmpID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         edtempdsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempdsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempdsc_Enabled), 5, 0)), true);
         edtMarcaID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMarcaID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMarcaID_Enabled), 5, 0)), true);
         edtMarcaDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMarcaDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMarcaDsc_Enabled), 5, 0)), true);
         edtMarcaEst_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMarcaEst_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMarcaEst_Enabled), 5, 0)), true);
      }

      protected void ZM047( short GX_JID )
      {
         if ( ( GX_JID == 9 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z64ModeloDsc = T00043_A64ModeloDsc[0];
               Z65ModeloEst = T00043_A65ModeloEst[0];
            }
            else
            {
               Z64ModeloDsc = A64ModeloDsc;
               Z65ModeloEst = A65ModeloEst;
            }
         }
         if ( GX_JID == -9 )
         {
            Z1EmpID = A1EmpID;
            Z6MarcaID = A6MarcaID;
            Z7ModeloID = A7ModeloID;
            Z64ModeloDsc = A64ModeloDsc;
            Z65ModeloEst = A65ModeloEst;
         }
      }

      protected void standaloneNotModal047( )
      {
      }

      protected void standaloneModal047( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtModeloID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtModeloID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtModeloID_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
         }
         else
         {
            edtModeloID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtModeloID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtModeloID_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
         }
      }

      protected void Load047( )
      {
         /* Using cursor T000419 */
         pr_default.execute(17, new Object[] {A1EmpID, A6MarcaID, A7ModeloID});
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound7 = 1;
            A64ModeloDsc = T000419_A64ModeloDsc[0];
            n64ModeloDsc = T000419_n64ModeloDsc[0];
            A65ModeloEst = T000419_A65ModeloEst[0];
            n65ModeloEst = T000419_n65ModeloEst[0];
            ZM047( -9) ;
         }
         pr_default.close(17);
         OnLoadActions047( ) ;
      }

      protected void OnLoadActions047( )
      {
      }

      protected void CheckExtendedTable047( )
      {
         Gx_BScreen = 1;
         standaloneModal047( ) ;
      }

      protected void CloseExtendedTableCursors047( )
      {
      }

      protected void enableDisable047( )
      {
      }

      protected void GetKey047( )
      {
         /* Using cursor T000420 */
         pr_default.execute(18, new Object[] {A1EmpID, A6MarcaID, A7ModeloID});
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound7 = 1;
         }
         else
         {
            RcdFound7 = 0;
         }
         pr_default.close(18);
      }

      protected void getByPrimaryKey047( )
      {
         /* Using cursor T00043 */
         pr_default.execute(1, new Object[] {A1EmpID, A6MarcaID, A7ModeloID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM047( 9) ;
            RcdFound7 = 1;
            InitializeNonKey047( ) ;
            A7ModeloID = T00043_A7ModeloID[0];
            A64ModeloDsc = T00043_A64ModeloDsc[0];
            n64ModeloDsc = T00043_n64ModeloDsc[0];
            A65ModeloEst = T00043_A65ModeloEst[0];
            n65ModeloEst = T00043_n65ModeloEst[0];
            Z1EmpID = A1EmpID;
            Z6MarcaID = A6MarcaID;
            Z7ModeloID = A7ModeloID;
            sMode7 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load047( ) ;
            Gx_mode = sMode7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound7 = 0;
            InitializeNonKey047( ) ;
            sMode7 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal047( ) ;
            Gx_mode = sMode7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes047( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency047( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00042 */
            pr_default.execute(0, new Object[] {A1EmpID, A6MarcaID, A7ModeloID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"MarcaModelo"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z64ModeloDsc, T00042_A64ModeloDsc[0]) != 0 ) || ( StringUtil.StrCmp(Z65ModeloEst, T00042_A65ModeloEst[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z64ModeloDsc, T00042_A64ModeloDsc[0]) != 0 )
               {
                  GXUtil.WriteLog("marca:[seudo value changed for attri]"+"ModeloDsc");
                  GXUtil.WriteLogRaw("Old: ",Z64ModeloDsc);
                  GXUtil.WriteLogRaw("Current: ",T00042_A64ModeloDsc[0]);
               }
               if ( StringUtil.StrCmp(Z65ModeloEst, T00042_A65ModeloEst[0]) != 0 )
               {
                  GXUtil.WriteLog("marca:[seudo value changed for attri]"+"ModeloEst");
                  GXUtil.WriteLogRaw("Old: ",Z65ModeloEst);
                  GXUtil.WriteLogRaw("Current: ",T00042_A65ModeloEst[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"MarcaModelo"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert047( )
      {
         BeforeValidate047( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable047( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM047( 0) ;
            CheckOptimisticConcurrency047( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm047( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert047( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000421 */
                     pr_default.execute(19, new Object[] {A1EmpID, A6MarcaID, A7ModeloID, n64ModeloDsc, A64ModeloDsc, n65ModeloEst, A65ModeloEst});
                     pr_default.close(19);
                     dsDefault.SmartCacheProvider.SetUpdated("MarcaModelo") ;
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
               Load047( ) ;
            }
            EndLevel047( ) ;
         }
         CloseExtendedTableCursors047( ) ;
      }

      protected void Update047( )
      {
         BeforeValidate047( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable047( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency047( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm047( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate047( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000422 */
                     pr_default.execute(20, new Object[] {n64ModeloDsc, A64ModeloDsc, n65ModeloEst, A65ModeloEst, A1EmpID, A6MarcaID, A7ModeloID});
                     pr_default.close(20);
                     dsDefault.SmartCacheProvider.SetUpdated("MarcaModelo") ;
                     if ( (pr_default.getStatus(20) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"MarcaModelo"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate047( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey047( ) ;
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
            EndLevel047( ) ;
         }
         CloseExtendedTableCursors047( ) ;
      }

      protected void DeferredUpdate047( )
      {
      }

      protected void Delete047( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate047( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency047( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls047( ) ;
            AfterConfirm047( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete047( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000423 */
                  pr_default.execute(21, new Object[] {A1EmpID, A6MarcaID, A7ModeloID});
                  pr_default.close(21);
                  dsDefault.SmartCacheProvider.SetUpdated("MarcaModelo") ;
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
         sMode7 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel047( ) ;
         Gx_mode = sMode7;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls047( )
      {
         standaloneModal047( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000424 */
            pr_default.execute(22, new Object[] {A1EmpID, A6MarcaID, A7ModeloID});
            if ( (pr_default.getStatus(22) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Vehiculos"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(22);
         }
      }

      protected void EndLevel047( )
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

      public void ScanStart047( )
      {
         /* Scan By routine */
         /* Using cursor T000425 */
         pr_default.execute(23, new Object[] {A1EmpID, A6MarcaID});
         RcdFound7 = 0;
         if ( (pr_default.getStatus(23) != 101) )
         {
            RcdFound7 = 1;
            A7ModeloID = T000425_A7ModeloID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext047( )
      {
         /* Scan next routine */
         pr_default.readNext(23);
         RcdFound7 = 0;
         if ( (pr_default.getStatus(23) != 101) )
         {
            RcdFound7 = 1;
            A7ModeloID = T000425_A7ModeloID[0];
         }
      }

      protected void ScanEnd047( )
      {
         pr_default.close(23);
      }

      protected void AfterConfirm047( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert047( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate047( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete047( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete047( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate047( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes047( )
      {
         edtModeloID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtModeloID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtModeloID_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
         edtModeloDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtModeloDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtModeloDsc_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
         edtModeloEst_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtModeloEst_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtModeloEst_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
      }

      protected void send_integrity_lvl_hashes047( )
      {
      }

      protected void send_integrity_lvl_hashes046( )
      {
      }

      protected void SubsflControlProps_637( )
      {
         edtModeloID_Internalname = "MODELOID_"+sGXsfl_63_idx;
         edtModeloDsc_Internalname = "MODELODSC_"+sGXsfl_63_idx;
         edtModeloEst_Internalname = "MODELOEST_"+sGXsfl_63_idx;
      }

      protected void SubsflControlProps_fel_637( )
      {
         edtModeloID_Internalname = "MODELOID_"+sGXsfl_63_fel_idx;
         edtModeloDsc_Internalname = "MODELODSC_"+sGXsfl_63_fel_idx;
         edtModeloEst_Internalname = "MODELOEST_"+sGXsfl_63_fel_idx;
      }

      protected void AddRow047( )
      {
         nGXsfl_63_idx = (short)(nGXsfl_63_idx+1);
         sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx), 4, 0)), 4, "0");
         SubsflControlProps_637( ) ;
         SendRow047( ) ;
      }

      protected void SendRow047( )
      {
         Gridmarca_modeloRow = GXWebRow.GetNew(context);
         if ( subGridmarca_modelo_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridmarca_modelo_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridmarca_modelo_Class, "") != 0 )
            {
               subGridmarca_modelo_Linesclass = subGridmarca_modelo_Class+"Odd";
            }
         }
         else if ( subGridmarca_modelo_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridmarca_modelo_Backstyle = 0;
            subGridmarca_modelo_Backcolor = subGridmarca_modelo_Allbackcolor;
            if ( StringUtil.StrCmp(subGridmarca_modelo_Class, "") != 0 )
            {
               subGridmarca_modelo_Linesclass = subGridmarca_modelo_Class+"Uniform";
            }
         }
         else if ( subGridmarca_modelo_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridmarca_modelo_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridmarca_modelo_Class, "") != 0 )
            {
               subGridmarca_modelo_Linesclass = subGridmarca_modelo_Class+"Odd";
            }
            subGridmarca_modelo_Backcolor = (int)(0x0);
         }
         else if ( subGridmarca_modelo_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridmarca_modelo_Backstyle = 1;
            if ( ((int)(((nGXsfl_63_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGridmarca_modelo_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridmarca_modelo_Class, "") != 0 )
               {
                  subGridmarca_modelo_Linesclass = subGridmarca_modelo_Class+"Odd";
               }
            }
            else
            {
               subGridmarca_modelo_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridmarca_modelo_Class, "") != 0 )
               {
                  subGridmarca_modelo_Linesclass = subGridmarca_modelo_Class+"Even";
               }
            }
         }
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_7_" + sGXsfl_63_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 64,'',false,'" + sGXsfl_63_idx + "',63)\"";
         ROClassString = "Attribute";
         Gridmarca_modeloRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtModeloID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A7ModeloID), 4, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A7ModeloID), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtModeloID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtModeloID_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)63,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_7_" + sGXsfl_63_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 65,'',false,'" + sGXsfl_63_idx + "',63)\"";
         ROClassString = "Attribute";
         Gridmarca_modeloRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtModeloDsc_Internalname,StringUtil.RTrim( A64ModeloDsc),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,65);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtModeloDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtModeloDsc_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)63,(short)1,(short)-1,(short)-1,(bool)true,(String)"Descripcion",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_7_" + sGXsfl_63_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_63_idx + "',63)\"";
         ROClassString = "Attribute";
         Gridmarca_modeloRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtModeloEst_Internalname,StringUtil.RTrim( A65ModeloEst),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtModeloEst_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtModeloEst_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)1,(short)0,(short)0,(short)63,(short)1,(short)-1,(short)-1,(bool)true,(String)"estado",(String)"left",(bool)true});
         context.httpAjaxContext.ajax_sending_grid_row(Gridmarca_modeloRow);
         send_integrity_lvl_hashes047( ) ;
         GXCCtl = "Z7ModeloID_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z7ModeloID), 4, 0, ",", "")));
         GXCCtl = "Z64ModeloDsc_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z64ModeloDsc));
         GXCCtl = "Z65ModeloEst_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z65ModeloEst));
         GXCCtl = "nRcdDeleted_7_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_7), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_7_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_7), 4, 0, ",", "")));
         GXCCtl = "nIsMod_7_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_7), 4, 0, ",", "")));
         GXCCtl = "vMODE_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_63_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV10TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV10TrnContext);
         }
         GXCCtl = "vEMPID_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7EmpID), 4, 0, ",", "")));
         GXCCtl = "vMARCAID_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8MarcaID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "MODELOID_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtModeloID_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "MODELODSC_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtModeloDsc_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "MODELOEST_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtModeloEst_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridmarca_modeloContainer.AddRow(Gridmarca_modeloRow);
      }

      protected void ReadRow047( )
      {
         nGXsfl_63_idx = (short)(nGXsfl_63_idx+1);
         sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx), 4, 0)), 4, "0");
         SubsflControlProps_637( ) ;
         edtModeloID_Enabled = (int)(context.localUtil.CToN( cgiGet( "MODELOID_"+sGXsfl_63_idx+"Enabled"), ",", "."));
         edtModeloDsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "MODELODSC_"+sGXsfl_63_idx+"Enabled"), ",", "."));
         edtModeloEst_Enabled = (int)(context.localUtil.CToN( cgiGet( "MODELOEST_"+sGXsfl_63_idx+"Enabled"), ",", "."));
         if ( ( ( context.localUtil.CToN( cgiGet( edtModeloID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtModeloID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "MODELOID_" + sGXsfl_63_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtModeloID_Internalname;
            wbErr = true;
            A7ModeloID = 0;
         }
         else
         {
            A7ModeloID = (short)(context.localUtil.CToN( cgiGet( edtModeloID_Internalname), ",", "."));
         }
         A64ModeloDsc = cgiGet( edtModeloDsc_Internalname);
         n64ModeloDsc = false;
         n64ModeloDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A64ModeloDsc)) ? true : false);
         A65ModeloEst = cgiGet( edtModeloEst_Internalname);
         n65ModeloEst = false;
         n65ModeloEst = (String.IsNullOrEmpty(StringUtil.RTrim( A65ModeloEst)) ? true : false);
         GXCCtl = "Z7ModeloID_" + sGXsfl_63_idx;
         Z7ModeloID = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z64ModeloDsc_" + sGXsfl_63_idx;
         Z64ModeloDsc = cgiGet( GXCCtl);
         n64ModeloDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A64ModeloDsc)) ? true : false);
         GXCCtl = "Z65ModeloEst_" + sGXsfl_63_idx;
         Z65ModeloEst = cgiGet( GXCCtl);
         n65ModeloEst = (String.IsNullOrEmpty(StringUtil.RTrim( A65ModeloEst)) ? true : false);
         GXCCtl = "nRcdDeleted_7_" + sGXsfl_63_idx;
         nRcdDeleted_7 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_7_" + sGXsfl_63_idx;
         nRcdExists_7 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_7_" + sGXsfl_63_idx;
         nIsMod_7 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void assign_properties_default( )
      {
         defedtModeloID_Enabled = edtModeloID_Enabled;
      }

      protected void ConfirmValues040( )
      {
         nGXsfl_63_idx = 0;
         sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx), 4, 0)), 4, "0");
         SubsflControlProps_637( ) ;
         while ( nGXsfl_63_idx < nRC_GXsfl_63 )
         {
            nGXsfl_63_idx = (short)(nGXsfl_63_idx+1);
            sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx), 4, 0)), 4, "0");
            SubsflControlProps_637( ) ;
            ChangePostValue( "Z7ModeloID_"+sGXsfl_63_idx, cgiGet( "ZT_"+"Z7ModeloID_"+sGXsfl_63_idx)) ;
            DeletePostValue( "ZT_"+"Z7ModeloID_"+sGXsfl_63_idx) ;
            ChangePostValue( "Z64ModeloDsc_"+sGXsfl_63_idx, cgiGet( "ZT_"+"Z64ModeloDsc_"+sGXsfl_63_idx)) ;
            DeletePostValue( "ZT_"+"Z64ModeloDsc_"+sGXsfl_63_idx) ;
            ChangePostValue( "Z65ModeloEst_"+sGXsfl_63_idx, cgiGet( "ZT_"+"Z65ModeloEst_"+sGXsfl_63_idx)) ;
            DeletePostValue( "ZT_"+"Z65ModeloEst_"+sGXsfl_63_idx) ;
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
         context.SendWebValue( "Marca") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20231141153848", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("marca.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7EmpID) + "," + UrlEncode("" +AV8MarcaID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "Marca";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("marca:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1EmpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z6MarcaID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z6MarcaID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z62MarcaDsc", StringUtil.RTrim( Z62MarcaDsc));
         GxWebStd.gx_hidden_field( context, "Z63MarcaEst", StringUtil.RTrim( Z63MarcaEst));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_63", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_63_idx), 4, 0, ",", "")));
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
         GxWebStd.gx_hidden_field( context, "vMARCAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8MarcaID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vMARCAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8MarcaID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV12Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void RenderHtmlCloseForm046( )
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
         return "Marca" ;
      }

      public override String GetPgmdesc( )
      {
         return "Marca" ;
      }

      protected void InitializeNonKey046( )
      {
         A44empdsc = "";
         n44empdsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         A62MarcaDsc = "";
         n62MarcaDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62MarcaDsc", A62MarcaDsc);
         n62MarcaDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A62MarcaDsc)) ? true : false);
         A63MarcaEst = "";
         n63MarcaEst = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63MarcaEst", A63MarcaEst);
         n63MarcaEst = (String.IsNullOrEmpty(StringUtil.RTrim( A63MarcaEst)) ? true : false);
         Z62MarcaDsc = "";
         Z63MarcaEst = "";
      }

      protected void InitAll046( )
      {
         A1EmpID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         A6MarcaID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6MarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(A6MarcaID), 4, 0)));
         InitializeNonKey046( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey047( )
      {
         A64ModeloDsc = "";
         n64ModeloDsc = false;
         A65ModeloEst = "";
         n65ModeloEst = false;
         Z64ModeloDsc = "";
         Z65ModeloEst = "";
      }

      protected void InitAll047( )
      {
         A7ModeloID = 0;
         InitializeNonKey047( ) ;
      }

      protected void StandaloneModalInsert047( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20231141153856", true);
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
         context.AddJavascriptSource("marca.js", "?20231141153857", false);
         /* End function include_jscripts */
      }

      protected void init_level_properties7( )
      {
         edtModeloID_Enabled = defedtModeloID_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtModeloID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtModeloID_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
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
         edtMarcaID_Internalname = "MARCAID";
         edtMarcaDsc_Internalname = "MARCADSC";
         edtMarcaEst_Internalname = "MARCAEST";
         lblTitlemodelo_Internalname = "TITLEMODELO";
         edtModeloID_Internalname = "MODELOID";
         edtModeloDsc_Internalname = "MODELODSC";
         edtModeloEst_Internalname = "MODELOEST";
         divModelotable_Internalname = "MODELOTABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_1_Internalname = "PROMPT_1";
         subGridmarca_modelo_Internalname = "GRIDMARCA_MODELO";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtModeloEst_Jsonclick = "";
         edtModeloDsc_Jsonclick = "";
         edtModeloID_Jsonclick = "";
         subGridmarca_modelo_Class = "Grid";
         subGridmarca_modelo_Backcolorstyle = 0;
         subGridmarca_modelo_Allowcollapsing = 0;
         subGridmarca_modelo_Allowselection = 0;
         edtModeloEst_Enabled = 1;
         edtModeloDsc_Enabled = 1;
         edtModeloID_Enabled = 1;
         subGridmarca_modelo_Header = "";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtMarcaEst_Jsonclick = "";
         edtMarcaEst_Enabled = 1;
         edtMarcaDsc_Jsonclick = "";
         edtMarcaDsc_Enabled = 1;
         edtMarcaID_Jsonclick = "";
         edtMarcaID_Enabled = 1;
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

      protected void gxnrGridmarca_modelo_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_637( ) ;
         while ( nGXsfl_63_idx <= nRC_GXsfl_63 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal047( ) ;
            standaloneModal047( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow047( ) ;
            nGXsfl_63_idx = (short)(nGXsfl_63_idx+1);
            sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx), 4, 0)), 4, "0");
            SubsflControlProps_637( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Gridmarca_modeloContainer));
         /* End function gxnrGridmarca_modelo_newrow */
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
         /* Using cursor T000415 */
         pr_default.execute(13, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A44empdsc = T000415_A44empdsc[0];
         n44empdsc = T000415_n44empdsc[0];
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

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV8MarcaID',fld:'vMARCAID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV8MarcaID',fld:'vMARCAID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12042',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV10TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         Z62MarcaDsc = "";
         Z63MarcaEst = "";
         Z64ModeloDsc = "";
         Z65ModeloEst = "";
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
         A62MarcaDsc = "";
         A63MarcaEst = "";
         lblTitlemodelo_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridmarca_modeloContainer = new GXWebGrid( context);
         Gridmarca_modeloColumn = new GXWebColumn();
         A64ModeloDsc = "";
         A65ModeloEst = "";
         sMode7 = "";
         sStyleString = "";
         AV12Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode6 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         AV10TrnContext = new SdtTransactionContext(context);
         AV11WebSession = context.GetSession();
         Z44empdsc = "";
         T00046_A44empdsc = new String[] {""} ;
         T00046_n44empdsc = new bool[] {false} ;
         T00047_A6MarcaID = new short[1] ;
         T00047_A44empdsc = new String[] {""} ;
         T00047_n44empdsc = new bool[] {false} ;
         T00047_A62MarcaDsc = new String[] {""} ;
         T00047_n62MarcaDsc = new bool[] {false} ;
         T00047_A63MarcaEst = new String[] {""} ;
         T00047_n63MarcaEst = new bool[] {false} ;
         T00047_A1EmpID = new short[1] ;
         T00048_A44empdsc = new String[] {""} ;
         T00048_n44empdsc = new bool[] {false} ;
         T00049_A1EmpID = new short[1] ;
         T00049_A6MarcaID = new short[1] ;
         T00045_A6MarcaID = new short[1] ;
         T00045_A62MarcaDsc = new String[] {""} ;
         T00045_n62MarcaDsc = new bool[] {false} ;
         T00045_A63MarcaEst = new String[] {""} ;
         T00045_n63MarcaEst = new bool[] {false} ;
         T00045_A1EmpID = new short[1] ;
         T000410_A1EmpID = new short[1] ;
         T000410_A6MarcaID = new short[1] ;
         T000411_A1EmpID = new short[1] ;
         T000411_A6MarcaID = new short[1] ;
         T00044_A6MarcaID = new short[1] ;
         T00044_A62MarcaDsc = new String[] {""} ;
         T00044_n62MarcaDsc = new bool[] {false} ;
         T00044_A63MarcaEst = new String[] {""} ;
         T00044_n63MarcaEst = new bool[] {false} ;
         T00044_A1EmpID = new short[1] ;
         T000415_A44empdsc = new String[] {""} ;
         T000415_n44empdsc = new bool[] {false} ;
         T000416_A1EmpID = new short[1] ;
         T000416_A5ClienteID = new short[1] ;
         T000416_A24OrdenPeriodo = new short[1] ;
         T000416_A25OrdenAnio = new short[1] ;
         T000416_A22OrdenID = new short[1] ;
         T000417_A1EmpID = new short[1] ;
         T000417_A8VehiculoID = new short[1] ;
         T000418_A1EmpID = new short[1] ;
         T000418_A6MarcaID = new short[1] ;
         T000419_A1EmpID = new short[1] ;
         T000419_A6MarcaID = new short[1] ;
         T000419_A7ModeloID = new short[1] ;
         T000419_A64ModeloDsc = new String[] {""} ;
         T000419_n64ModeloDsc = new bool[] {false} ;
         T000419_A65ModeloEst = new String[] {""} ;
         T000419_n65ModeloEst = new bool[] {false} ;
         T000420_A1EmpID = new short[1] ;
         T000420_A6MarcaID = new short[1] ;
         T000420_A7ModeloID = new short[1] ;
         T00043_A1EmpID = new short[1] ;
         T00043_A6MarcaID = new short[1] ;
         T00043_A7ModeloID = new short[1] ;
         T00043_A64ModeloDsc = new String[] {""} ;
         T00043_n64ModeloDsc = new bool[] {false} ;
         T00043_A65ModeloEst = new String[] {""} ;
         T00043_n65ModeloEst = new bool[] {false} ;
         T00042_A1EmpID = new short[1] ;
         T00042_A6MarcaID = new short[1] ;
         T00042_A7ModeloID = new short[1] ;
         T00042_A64ModeloDsc = new String[] {""} ;
         T00042_n64ModeloDsc = new bool[] {false} ;
         T00042_A65ModeloEst = new String[] {""} ;
         T00042_n65ModeloEst = new bool[] {false} ;
         T000424_A1EmpID = new short[1] ;
         T000424_A8VehiculoID = new short[1] ;
         T000425_A1EmpID = new short[1] ;
         T000425_A6MarcaID = new short[1] ;
         T000425_A7ModeloID = new short[1] ;
         Gridmarca_modeloRow = new GXWebRow();
         subGridmarca_modelo_Linesclass = "";
         ROClassString = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.marca__default(),
            new Object[][] {
                new Object[] {
               T00042_A1EmpID, T00042_A6MarcaID, T00042_A7ModeloID, T00042_A64ModeloDsc, T00042_n64ModeloDsc, T00042_A65ModeloEst, T00042_n65ModeloEst
               }
               , new Object[] {
               T00043_A1EmpID, T00043_A6MarcaID, T00043_A7ModeloID, T00043_A64ModeloDsc, T00043_n64ModeloDsc, T00043_A65ModeloEst, T00043_n65ModeloEst
               }
               , new Object[] {
               T00044_A6MarcaID, T00044_A62MarcaDsc, T00044_n62MarcaDsc, T00044_A63MarcaEst, T00044_n63MarcaEst, T00044_A1EmpID
               }
               , new Object[] {
               T00045_A6MarcaID, T00045_A62MarcaDsc, T00045_n62MarcaDsc, T00045_A63MarcaEst, T00045_n63MarcaEst, T00045_A1EmpID
               }
               , new Object[] {
               T00046_A44empdsc, T00046_n44empdsc
               }
               , new Object[] {
               T00047_A6MarcaID, T00047_A44empdsc, T00047_n44empdsc, T00047_A62MarcaDsc, T00047_n62MarcaDsc, T00047_A63MarcaEst, T00047_n63MarcaEst, T00047_A1EmpID
               }
               , new Object[] {
               T00048_A44empdsc, T00048_n44empdsc
               }
               , new Object[] {
               T00049_A1EmpID, T00049_A6MarcaID
               }
               , new Object[] {
               T000410_A1EmpID, T000410_A6MarcaID
               }
               , new Object[] {
               T000411_A1EmpID, T000411_A6MarcaID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000415_A44empdsc, T000415_n44empdsc
               }
               , new Object[] {
               T000416_A1EmpID, T000416_A5ClienteID, T000416_A24OrdenPeriodo, T000416_A25OrdenAnio, T000416_A22OrdenID
               }
               , new Object[] {
               T000417_A1EmpID, T000417_A8VehiculoID
               }
               , new Object[] {
               T000418_A1EmpID, T000418_A6MarcaID
               }
               , new Object[] {
               T000419_A1EmpID, T000419_A6MarcaID, T000419_A7ModeloID, T000419_A64ModeloDsc, T000419_n64ModeloDsc, T000419_A65ModeloEst, T000419_n65ModeloEst
               }
               , new Object[] {
               T000420_A1EmpID, T000420_A6MarcaID, T000420_A7ModeloID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000424_A1EmpID, T000424_A8VehiculoID
               }
               , new Object[] {
               T000425_A1EmpID, T000425_A6MarcaID, T000425_A7ModeloID
               }
            }
         );
         AV12Pgmname = "Marca";
      }

      private short wcpOAV7EmpID ;
      private short wcpOAV8MarcaID ;
      private short Z1EmpID ;
      private short Z6MarcaID ;
      private short nRC_GXsfl_63 ;
      private short nGXsfl_63_idx=1 ;
      private short Z7ModeloID ;
      private short nRcdDeleted_7 ;
      private short nRcdExists_7 ;
      private short nIsMod_7 ;
      private short GxWebError ;
      private short A1EmpID ;
      private short AV7EmpID ;
      private short AV8MarcaID ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short A6MarcaID ;
      private short subGridmarca_modelo_Backcolorstyle ;
      private short A7ModeloID ;
      private short subGridmarca_modelo_Allowselection ;
      private short subGridmarca_modelo_Allowhovering ;
      private short subGridmarca_modelo_Allowcollapsing ;
      private short subGridmarca_modelo_Collapsed ;
      private short nBlankRcdCount7 ;
      private short RcdFound7 ;
      private short nBlankRcdUsr7 ;
      private short RcdFound6 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short subGridmarca_modelo_Backstyle ;
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
      private int edtMarcaID_Enabled ;
      private int edtMarcaDsc_Enabled ;
      private int edtMarcaEst_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtModeloID_Enabled ;
      private int edtModeloDsc_Enabled ;
      private int edtModeloEst_Enabled ;
      private int subGridmarca_modelo_Selectedindex ;
      private int subGridmarca_modelo_Selectioncolor ;
      private int subGridmarca_modelo_Hoveringcolor ;
      private int fRowAdded ;
      private int subGridmarca_modelo_Backcolor ;
      private int subGridmarca_modelo_Allbackcolor ;
      private int defedtModeloID_Enabled ;
      private int idxLst ;
      private long GRIDMARCA_MODELO_nFirstRecordOnPage ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z62MarcaDsc ;
      private String Z63MarcaEst ;
      private String Z64ModeloDsc ;
      private String Z65ModeloEst ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_63_idx="0001" ;
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
      private String edtMarcaID_Internalname ;
      private String edtMarcaID_Jsonclick ;
      private String edtMarcaDsc_Internalname ;
      private String A62MarcaDsc ;
      private String edtMarcaDsc_Jsonclick ;
      private String edtMarcaEst_Internalname ;
      private String A63MarcaEst ;
      private String edtMarcaEst_Jsonclick ;
      private String divModelotable_Internalname ;
      private String lblTitlemodelo_Internalname ;
      private String lblTitlemodelo_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridmarca_modelo_Header ;
      private String A64ModeloDsc ;
      private String A65ModeloEst ;
      private String sMode7 ;
      private String edtModeloID_Internalname ;
      private String edtModeloDsc_Internalname ;
      private String edtModeloEst_Internalname ;
      private String sStyleString ;
      private String AV12Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode6 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String sGXsfl_63_fel_idx="0001" ;
      private String subGridmarca_modelo_Class ;
      private String subGridmarca_modelo_Linesclass ;
      private String ROClassString ;
      private String edtModeloID_Jsonclick ;
      private String edtModeloDsc_Jsonclick ;
      private String edtModeloEst_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridmarca_modelo_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool bGXsfl_63_Refreshing=false ;
      private bool n44empdsc ;
      private bool n62MarcaDsc ;
      private bool n63MarcaEst ;
      private bool returnInSub ;
      private bool n64ModeloDsc ;
      private bool n65ModeloEst ;
      private String A44empdsc ;
      private String Z44empdsc ;
      private IGxSession AV11WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebGrid Gridmarca_modeloContainer ;
      private GXWebRow Gridmarca_modeloRow ;
      private GXWebColumn Gridmarca_modeloColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T00046_A44empdsc ;
      private bool[] T00046_n44empdsc ;
      private short[] T00047_A6MarcaID ;
      private String[] T00047_A44empdsc ;
      private bool[] T00047_n44empdsc ;
      private String[] T00047_A62MarcaDsc ;
      private bool[] T00047_n62MarcaDsc ;
      private String[] T00047_A63MarcaEst ;
      private bool[] T00047_n63MarcaEst ;
      private short[] T00047_A1EmpID ;
      private String[] T00048_A44empdsc ;
      private bool[] T00048_n44empdsc ;
      private short[] T00049_A1EmpID ;
      private short[] T00049_A6MarcaID ;
      private short[] T00045_A6MarcaID ;
      private String[] T00045_A62MarcaDsc ;
      private bool[] T00045_n62MarcaDsc ;
      private String[] T00045_A63MarcaEst ;
      private bool[] T00045_n63MarcaEst ;
      private short[] T00045_A1EmpID ;
      private short[] T000410_A1EmpID ;
      private short[] T000410_A6MarcaID ;
      private short[] T000411_A1EmpID ;
      private short[] T000411_A6MarcaID ;
      private short[] T00044_A6MarcaID ;
      private String[] T00044_A62MarcaDsc ;
      private bool[] T00044_n62MarcaDsc ;
      private String[] T00044_A63MarcaEst ;
      private bool[] T00044_n63MarcaEst ;
      private short[] T00044_A1EmpID ;
      private String[] T000415_A44empdsc ;
      private bool[] T000415_n44empdsc ;
      private short[] T000416_A1EmpID ;
      private short[] T000416_A5ClienteID ;
      private short[] T000416_A24OrdenPeriodo ;
      private short[] T000416_A25OrdenAnio ;
      private short[] T000416_A22OrdenID ;
      private short[] T000417_A1EmpID ;
      private short[] T000417_A8VehiculoID ;
      private short[] T000418_A1EmpID ;
      private short[] T000418_A6MarcaID ;
      private short[] T000419_A1EmpID ;
      private short[] T000419_A6MarcaID ;
      private short[] T000419_A7ModeloID ;
      private String[] T000419_A64ModeloDsc ;
      private bool[] T000419_n64ModeloDsc ;
      private String[] T000419_A65ModeloEst ;
      private bool[] T000419_n65ModeloEst ;
      private short[] T000420_A1EmpID ;
      private short[] T000420_A6MarcaID ;
      private short[] T000420_A7ModeloID ;
      private short[] T00043_A1EmpID ;
      private short[] T00043_A6MarcaID ;
      private short[] T00043_A7ModeloID ;
      private String[] T00043_A64ModeloDsc ;
      private bool[] T00043_n64ModeloDsc ;
      private String[] T00043_A65ModeloEst ;
      private bool[] T00043_n65ModeloEst ;
      private short[] T00042_A1EmpID ;
      private short[] T00042_A6MarcaID ;
      private short[] T00042_A7ModeloID ;
      private String[] T00042_A64ModeloDsc ;
      private bool[] T00042_n64ModeloDsc ;
      private String[] T00042_A65ModeloEst ;
      private bool[] T00042_n65ModeloEst ;
      private short[] T000424_A1EmpID ;
      private short[] T000424_A8VehiculoID ;
      private short[] T000425_A1EmpID ;
      private short[] T000425_A6MarcaID ;
      private short[] T000425_A7ModeloID ;
      private SdtTransactionContext AV10TrnContext ;
   }

   public class marca__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT00047 ;
          prmT00047 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00046 ;
          prmT00046 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00048 ;
          prmT00048 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00049 ;
          prmT00049 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00045 ;
          prmT00045 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000410 ;
          prmT000410 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000411 ;
          prmT000411 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00044 ;
          prmT00044 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000412 ;
          prmT000412 = new Object[] {
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MarcaDsc",SqlDbType.Char,50,0} ,
          new Object[] {"@MarcaEst",SqlDbType.Char,1,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000413 ;
          prmT000413 = new Object[] {
          new Object[] {"@MarcaDsc",SqlDbType.Char,50,0} ,
          new Object[] {"@MarcaEst",SqlDbType.Char,1,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000414 ;
          prmT000414 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000416 ;
          prmT000416 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000417 ;
          prmT000417 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000418 ;
          prmT000418 = new Object[] {
          } ;
          Object[] prmT000419 ;
          prmT000419 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ModeloID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000420 ;
          prmT000420 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ModeloID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00043 ;
          prmT00043 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ModeloID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00042 ;
          prmT00042 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ModeloID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000421 ;
          prmT000421 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ModeloID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ModeloDsc",SqlDbType.Char,50,0} ,
          new Object[] {"@ModeloEst",SqlDbType.Char,1,0}
          } ;
          Object[] prmT000422 ;
          prmT000422 = new Object[] {
          new Object[] {"@ModeloDsc",SqlDbType.Char,50,0} ,
          new Object[] {"@ModeloEst",SqlDbType.Char,1,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ModeloID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000423 ;
          prmT000423 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ModeloID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000424 ;
          prmT000424 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ModeloID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000425 ;
          prmT000425 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000415 ;
          prmT000415 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00042", "SELECT [EmpID], [MarcaID], [ModeloID], [ModeloDsc], [ModeloEst] FROM [MarcaModelo] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [MarcaID] = @MarcaID AND [ModeloID] = @ModeloID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00042,1,0,true,false )
             ,new CursorDef("T00043", "SELECT [EmpID], [MarcaID], [ModeloID], [ModeloDsc], [ModeloEst] FROM [MarcaModelo] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [MarcaID] = @MarcaID AND [ModeloID] = @ModeloID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00043,1,0,true,false )
             ,new CursorDef("T00044", "SELECT [MarcaID], [MarcaDsc], [MarcaEst], [EmpID] FROM [Marca] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [MarcaID] = @MarcaID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00044,1,0,true,false )
             ,new CursorDef("T00045", "SELECT [MarcaID], [MarcaDsc], [MarcaEst], [EmpID] FROM [Marca] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [MarcaID] = @MarcaID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00045,1,0,true,false )
             ,new CursorDef("T00046", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00046,1,0,true,false )
             ,new CursorDef("T00047", "SELECT TM1.[MarcaID], T2.[empdsc], TM1.[MarcaDsc], TM1.[MarcaEst], TM1.[EmpID] FROM ([Marca] TM1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = TM1.[EmpID]) WHERE TM1.[EmpID] = @EmpID and TM1.[MarcaID] = @MarcaID ORDER BY TM1.[EmpID], TM1.[MarcaID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00047,100,0,true,false )
             ,new CursorDef("T00048", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00048,1,0,true,false )
             ,new CursorDef("T00049", "SELECT [EmpID], [MarcaID] FROM [Marca] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [MarcaID] = @MarcaID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00049,1,0,true,false )
             ,new CursorDef("T000410", "SELECT TOP 1 [EmpID], [MarcaID] FROM [Marca] WITH (NOLOCK) WHERE ( [EmpID] > @EmpID or [EmpID] = @EmpID and [MarcaID] > @MarcaID) ORDER BY [EmpID], [MarcaID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000410,1,0,true,true )
             ,new CursorDef("T000411", "SELECT TOP 1 [EmpID], [MarcaID] FROM [Marca] WITH (NOLOCK) WHERE ( [EmpID] < @EmpID or [EmpID] = @EmpID and [MarcaID] < @MarcaID) ORDER BY [EmpID] DESC, [MarcaID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000411,1,0,true,true )
             ,new CursorDef("T000412", "INSERT INTO [Marca]([MarcaID], [MarcaDsc], [MarcaEst], [EmpID]) VALUES(@MarcaID, @MarcaDsc, @MarcaEst, @EmpID)", GxErrorMask.GX_NOMASK,prmT000412)
             ,new CursorDef("T000413", "UPDATE [Marca] SET [MarcaDsc]=@MarcaDsc, [MarcaEst]=@MarcaEst  WHERE [EmpID] = @EmpID AND [MarcaID] = @MarcaID", GxErrorMask.GX_NOMASK,prmT000413)
             ,new CursorDef("T000414", "DELETE FROM [Marca]  WHERE [EmpID] = @EmpID AND [MarcaID] = @MarcaID", GxErrorMask.GX_NOMASK,prmT000414)
             ,new CursorDef("T000415", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000415,1,0,true,false )
             ,new CursorDef("T000416", "SELECT TOP 1 [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID] FROM [OrdenProduccion] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [OrdenMarcaID] = @MarcaID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000416,1,0,true,true )
             ,new CursorDef("T000417", "SELECT TOP 1 [EmpID], [VehiculoID] FROM [Vehiculos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [MarcaID] = @MarcaID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000417,1,0,true,true )
             ,new CursorDef("T000418", "SELECT [EmpID], [MarcaID] FROM [Marca] WITH (NOLOCK) ORDER BY [EmpID], [MarcaID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000418,100,0,true,false )
             ,new CursorDef("T000419", "SELECT [EmpID], [MarcaID], [ModeloID], [ModeloDsc], [ModeloEst] FROM [MarcaModelo] WITH (NOLOCK) WHERE [EmpID] = @EmpID and [MarcaID] = @MarcaID and [ModeloID] = @ModeloID ORDER BY [EmpID], [MarcaID], [ModeloID] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000419,11,0,true,false )
             ,new CursorDef("T000420", "SELECT [EmpID], [MarcaID], [ModeloID] FROM [MarcaModelo] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [MarcaID] = @MarcaID AND [ModeloID] = @ModeloID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000420,1,0,true,false )
             ,new CursorDef("T000421", "INSERT INTO [MarcaModelo]([EmpID], [MarcaID], [ModeloID], [ModeloDsc], [ModeloEst]) VALUES(@EmpID, @MarcaID, @ModeloID, @ModeloDsc, @ModeloEst)", GxErrorMask.GX_NOMASK,prmT000421)
             ,new CursorDef("T000422", "UPDATE [MarcaModelo] SET [ModeloDsc]=@ModeloDsc, [ModeloEst]=@ModeloEst  WHERE [EmpID] = @EmpID AND [MarcaID] = @MarcaID AND [ModeloID] = @ModeloID", GxErrorMask.GX_NOMASK,prmT000422)
             ,new CursorDef("T000423", "DELETE FROM [MarcaModelo]  WHERE [EmpID] = @EmpID AND [MarcaID] = @MarcaID AND [ModeloID] = @ModeloID", GxErrorMask.GX_NOMASK,prmT000423)
             ,new CursorDef("T000424", "SELECT TOP 1 [EmpID], [VehiculoID] FROM [Vehiculos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [MarcaID] = @MarcaID AND [ModeloID] = @ModeloID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000424,1,0,true,true )
             ,new CursorDef("T000425", "SELECT [EmpID], [MarcaID], [ModeloID] FROM [MarcaModelo] WITH (NOLOCK) WHERE [EmpID] = @EmpID and [MarcaID] = @MarcaID ORDER BY [EmpID], [MarcaID], [ModeloID] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000425,11,0,true,false )
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getString(5, 1) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getString(5, 1) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 1) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                return;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 15 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 16 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 17 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getString(5, 1) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                return;
             case 18 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 22 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 23 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
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
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
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
                stmt.SetParameter(4, (short)parms[5]);
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
                stmt.SetParameter(3, (short)parms[4]);
                stmt.SetParameter(4, (short)parms[5]);
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
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 18 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 19 :
                stmt.SetParameter(1, (short)parms[0]);
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
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 5 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[6]);
                }
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
                stmt.SetParameter(5, (short)parms[6]);
                return;
             case 21 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 22 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 23 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
       }
    }

 }

}
