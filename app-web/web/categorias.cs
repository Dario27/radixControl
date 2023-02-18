/*
               File: Categorias
        Description: Categorias
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 11/19/2022 22:53:35.50
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
   public class categorias : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_13") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_13( A1EmpID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_14") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A31tipoProdID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A31tipoProdID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_14( A1EmpID, A31tipoProdID) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridcategorias_subcat") == 0 )
         {
            nRC_GXsfl_81 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_81_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_81_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridcategorias_subcat_newrow( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
         {
            nRC_GXsfl_90 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_90_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_90_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGrid1_newrow( ) ;
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
               AV8categID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8categID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8categID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vCATEGID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8categID), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Categorias", 0) ;
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

      public categorias( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public categorias( IGxContext context )
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
                           short aP2_categID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7EmpID = aP1_EmpID;
         this.AV8categID = aP2_categID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkcategEst = new GXCheckbox();
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Categorias", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Categorias.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Categorias.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Categorias.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Categorias.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Categorias.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx00q0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"CATEGID"+"'), id:'"+"CATEGID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_Categorias.htm");
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
            GxWebStd.gx_single_line_edit( context, edtEmpID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEmpID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEmpID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Categorias.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_1_Internalname, sImgUrl, imgprompt_1_Link, "", "", context.GetTheme( ), imgprompt_1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Categorias.htm");
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
            GxWebStd.gx_single_line_edit( context, edtempdsc_Internalname, A44empdsc, StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempdsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtempdsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Categorias.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtcategID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtcategID_Internalname, "Id Categoria", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtcategID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A32categID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A32categID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtcategID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtcategID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Categorias.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtcategDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtcategDsc_Internalname, "Categoria", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtcategDsc_Internalname, StringUtil.RTrim( A146categDsc), StringUtil.RTrim( context.localUtil.Format( A146categDsc, "@!")), TempTags+" onchange=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtcategDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtcategDsc_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "nombres", "left", true, "HLP_Categorias.htm");
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
            GxWebStd.gx_label_element( context, edttipoProdID_Internalname, "Tipo Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edttipoProdID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A31tipoProdID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A31tipoProdID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edttipoProdID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edttipoProdID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Categorias.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_31_Internalname, sImgUrl, imgprompt_31_Link, "", "", context.GetTheme( ), imgprompt_31_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Categorias.htm");
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
            GxWebStd.gx_label_element( context, edttipoProdDsc_Internalname, "Tipo Producto", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edttipoProdDsc_Internalname, StringUtil.RTrim( A144tipoProdDsc), StringUtil.RTrim( context.localUtil.Format( A144tipoProdDsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edttipoProdDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edttipoProdDsc_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "nombres", "left", true, "HLP_Categorias.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkcategEst_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkcategEst_Internalname, "Estado", "col-sm-3 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkcategEst_Internalname, A147categEst, "", "Estado", 1, chkcategEst.Enabled, "A", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(64, this, 'A', 'I');gx.evt.onchange(this, event);\" ");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"PRDTSContainer"+"\"></div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"PRDTSContainer"+"title1"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTabprodcts_title_Internalname, "Productos", "", "", lblTabprodcts_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Categorias.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "TabProdcts") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"PRDTSContainer"+"panel1"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabpage1table_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSubcattable_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitlesubcat_Internalname, "Productos", "", "", lblTitlesubcat_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Categorias.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Gridcategorias_subcat( ) ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Grid1( ) ;
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Categorias.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 99,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Categorias.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 101,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Categorias.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm0C26( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void gxdraw_Gridcategorias_subcat( )
      {
         /*  Grid Control  */
         Gridcategorias_subcatContainer.AddObjectProperty("GridName", "Gridcategorias_subcat");
         Gridcategorias_subcatContainer.AddObjectProperty("Header", subGridcategorias_subcat_Header);
         Gridcategorias_subcatContainer.AddObjectProperty("Class", "Grid");
         Gridcategorias_subcatContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridcategorias_subcatContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridcategorias_subcatContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcategorias_subcat_Backcolorstyle), 1, 0, ".", "")));
         Gridcategorias_subcatContainer.AddObjectProperty("CmpContext", "");
         Gridcategorias_subcatContainer.AddObjectProperty("InMasterPage", "false");
         Gridcategorias_subcatColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridcategorias_subcatColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A33subCatID), 4, 0, ".", "")));
         Gridcategorias_subcatColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatID_Enabled), 5, 0, ".", "")));
         Gridcategorias_subcatContainer.AddColumnProperties(Gridcategorias_subcatColumn);
         Gridcategorias_subcatColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridcategorias_subcatColumn.AddObjectProperty("Value", StringUtil.RTrim( A148subCatDsc));
         Gridcategorias_subcatColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatDsc_Enabled), 5, 0, ".", "")));
         Gridcategorias_subcatContainer.AddColumnProperties(Gridcategorias_subcatColumn);
         Gridcategorias_subcatColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridcategorias_subcatColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A150subCatPrec, 8, 2, ".", "")));
         Gridcategorias_subcatColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatPrec_Enabled), 5, 0, ".", "")));
         Gridcategorias_subcatContainer.AddColumnProperties(Gridcategorias_subcatColumn);
         Gridcategorias_subcatColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridcategorias_subcatColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A151subCatPeso, 8, 2, ".", "")));
         Gridcategorias_subcatColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatPeso_Enabled), 5, 0, ".", "")));
         Gridcategorias_subcatContainer.AddColumnProperties(Gridcategorias_subcatColumn);
         Gridcategorias_subcatColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridcategorias_subcatColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A211subCatDisp), 8, 0, ".", "")));
         Gridcategorias_subcatColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatDisp_Enabled), 5, 0, ".", "")));
         Gridcategorias_subcatContainer.AddColumnProperties(Gridcategorias_subcatColumn);
         Gridcategorias_subcatColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridcategorias_subcatColumn.AddObjectProperty("Value", StringUtil.RTrim( A149subCatEst));
         Gridcategorias_subcatColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatEst_Enabled), 5, 0, ".", "")));
         Gridcategorias_subcatContainer.AddColumnProperties(Gridcategorias_subcatColumn);
         Gridcategorias_subcatContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcategorias_subcat_Selectedindex), 4, 0, ".", "")));
         Gridcategorias_subcatContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcategorias_subcat_Allowselection), 1, 0, ".", "")));
         Gridcategorias_subcatContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcategorias_subcat_Selectioncolor), 9, 0, ".", "")));
         Gridcategorias_subcatContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcategorias_subcat_Allowhovering), 1, 0, ".", "")));
         Gridcategorias_subcatContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcategorias_subcat_Hoveringcolor), 9, 0, ".", "")));
         Gridcategorias_subcatContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcategorias_subcat_Allowcollapsing), 1, 0, ".", "")));
         Gridcategorias_subcatContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcategorias_subcat_Collapsed), 1, 0, ".", "")));
         /* Save parent mode. */
         sMode27 = Gx_mode;
         nGXsfl_81_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount27 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_27 = 1;
               ScanStart0C27( ) ;
               while ( RcdFound27 != 0 )
               {
                  init_level_properties27( ) ;
                  getByPrimaryKey0C27( ) ;
                  AddRow0C27( ) ;
                  ScanNext0C27( ) ;
               }
               ScanEnd0C27( ) ;
               nBlankRcdCount27 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal0C27( ) ;
            standaloneModal0C27( ) ;
            sMode27 = Gx_mode;
            while ( nGXsfl_81_idx < nRC_GXsfl_81 )
            {
               bGXsfl_81_Refreshing = true;
               ReadRow0C27( ) ;
               edtsubCatID_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATID_"+sGXsfl_81_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatID_Enabled), 5, 0)), !bGXsfl_81_Refreshing);
               edtsubCatDsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATDSC_"+sGXsfl_81_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatDsc_Enabled), 5, 0)), !bGXsfl_81_Refreshing);
               edtsubCatPrec_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATPREC_"+sGXsfl_81_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatPrec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatPrec_Enabled), 5, 0)), !bGXsfl_81_Refreshing);
               edtsubCatPeso_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATPESO_"+sGXsfl_81_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatPeso_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatPeso_Enabled), 5, 0)), !bGXsfl_81_Refreshing);
               edtsubCatDisp_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATDISP_"+sGXsfl_81_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatDisp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatDisp_Enabled), 5, 0)), !bGXsfl_81_Refreshing);
               edtsubCatEst_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATEST_"+sGXsfl_81_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatEst_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatEst_Enabled), 5, 0)), !bGXsfl_81_Refreshing);
               if ( ( nRcdExists_27 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal0C27( ) ;
               }
               SendRow0C27( ) ;
               bGXsfl_81_Refreshing = false;
            }
            Gx_mode = sMode27;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount27 = 5;
            nRcdExists_27 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart0C27( ) ;
               while ( RcdFound27 != 0 )
               {
                  sGXsfl_81_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_81_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_8127( ) ;
                  init_level_properties27( ) ;
                  standaloneNotModal0C27( ) ;
                  getByPrimaryKey0C27( ) ;
                  standaloneModal0C27( ) ;
                  AddRow0C27( ) ;
                  ScanNext0C27( ) ;
               }
               ScanEnd0C27( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode27 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_81_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_81_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_8127( ) ;
            InitAll0C27( ) ;
            init_level_properties27( ) ;
            standaloneNotModal0C27( ) ;
            standaloneModal0C27( ) ;
            nRcdExists_27 = 0;
            nIsMod_27 = 0;
            nRcdDeleted_27 = 0;
            nBlankRcdCount27 = (short)(nBlankRcdUsr27+nBlankRcdCount27);
            fRowAdded = 0;
            while ( nBlankRcdCount27 > 0 )
            {
               AddRow0C27( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtsubCatID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount27 = (short)(nBlankRcdCount27-1);
            }
            Gx_mode = sMode27;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         /* Restore parent mode. */
         Gx_mode = sMode27;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridcategorias_subcatContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridcategorias_subcat", Gridcategorias_subcatContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridcategorias_subcatContainerData", Gridcategorias_subcatContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridcategorias_subcatContainerData"+"V", Gridcategorias_subcatContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridcategorias_subcatContainerData"+"V"+"\" value='"+Gridcategorias_subcatContainer.GridValuesHidden()+"'/>") ;
         }
      }

      protected void gxdraw_Grid1( )
      {
         /*  Grid Control  */
         Grid1Container.AddObjectProperty("GridName", "Grid1");
         Grid1Container.AddObjectProperty("Header", subGrid1_Header);
         Grid1Container.AddObjectProperty("Class", "Grid");
         Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
         Grid1Container.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Visible), 5, 0, ".", "")));
         Grid1Container.AddObjectProperty("CmpContext", "");
         Grid1Container.AddObjectProperty("InMasterPage", "false");
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A257detSubID), 4, 0, ".", "")));
         Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetSubID_Enabled), 5, 0, ".", "")));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Column.AddObjectProperty("Value", A258detSubDsc);
         Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetSubDsc_Enabled), 5, 0, ".", "")));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Container.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectedindex), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowselection), 1, 0, ".", "")));
         Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
         Grid1Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowhovering), 1, 0, ".", "")));
         Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
         Grid1Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowcollapsing), 1, 0, ".", "")));
         Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 1, 0, ".", "")));
         nGXsfl_90_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount47 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_47 = 1;
               ScanStart0C47( ) ;
               while ( RcdFound47 != 0 )
               {
                  init_level_properties47( ) ;
                  getByPrimaryKey0C47( ) ;
                  AddRow0C47( ) ;
                  ScanNext0C47( ) ;
               }
               ScanEnd0C47( ) ;
               nBlankRcdCount47 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal0C47( ) ;
            standaloneModal0C47( ) ;
            sMode47 = Gx_mode;
            while ( nGXsfl_90_idx < nRC_GXsfl_90 )
            {
               bGXsfl_90_Refreshing = true;
               ReadRow0C47( ) ;
               edtdetSubID_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETSUBID_"+sGXsfl_90_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetSubID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetSubID_Enabled), 5, 0)), !bGXsfl_90_Refreshing);
               edtdetSubDsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETSUBDSC_"+sGXsfl_90_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetSubDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetSubDsc_Enabled), 5, 0)), !bGXsfl_90_Refreshing);
               if ( ( nRcdExists_47 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal0C47( ) ;
               }
               SendRow0C47( ) ;
               bGXsfl_90_Refreshing = false;
            }
            Gx_mode = sMode47;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount47 = 5;
            nRcdExists_47 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart0C47( ) ;
               while ( RcdFound47 != 0 )
               {
                  sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx+1), 4, 0)), 4, "0") + sGXsfl_81_idx;
                  SubsflControlProps_9047( ) ;
                  init_level_properties47( ) ;
                  standaloneNotModal0C47( ) ;
                  getByPrimaryKey0C47( ) ;
                  standaloneModal0C47( ) ;
                  AddRow0C47( ) ;
                  ScanNext0C47( ) ;
               }
               ScanEnd0C47( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode47 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx+1), 4, 0)), 4, "0") + sGXsfl_81_idx;
            SubsflControlProps_9047( ) ;
            InitAll0C47( ) ;
            init_level_properties47( ) ;
            standaloneNotModal0C47( ) ;
            standaloneModal0C47( ) ;
            nRcdExists_47 = 0;
            nIsMod_47 = 0;
            nRcdDeleted_47 = 0;
            if ( ( NumberUtil.Val( (String)(EvtGridId), ".") + NumberUtil.Val( (String)(EvtRowId), ".") == Convert.ToDecimal( 0 )) || (Convert.ToDecimal( 81 ) == NumberUtil.Val( (String)(EvtGridId), ".") ) && ( NumberUtil.Val( (String)(EvtRowId), ".") == NumberUtil.Val( sGXsfl_81_idx, ".") ) )
            {
               nBlankRcdCount47 = (short)(nBlankRcdUsr47+nBlankRcdCount47);
            }
            fRowAdded = 0;
            while ( nBlankRcdCount47 > 0 )
            {
               AddRow0C47( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtdetSubID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount47 = (short)(nBlankRcdCount47-1);
            }
            Gx_mode = sMode47;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( subGrid1_Visible != 0 )
         {
            sStyleString = "";
         }
         else
         {
            sStyleString = " style=\"display:none;\"";
         }
         context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", Grid1Container);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'/>") ;
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
         E110C2 ();
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtcategID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtcategID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CATEGID");
                  AnyError = 1;
                  GX_FocusControl = edtcategID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A32categID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32categID", StringUtil.LTrim( StringUtil.Str( (decimal)(A32categID), 4, 0)));
               }
               else
               {
                  A32categID = (short)(context.localUtil.CToN( cgiGet( edtcategID_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32categID", StringUtil.LTrim( StringUtil.Str( (decimal)(A32categID), 4, 0)));
               }
               A146categDsc = StringUtil.Upper( cgiGet( edtcategDsc_Internalname));
               n146categDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A146categDsc", A146categDsc);
               n146categDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A146categDsc)) ? true : false);
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
               A147categEst = ((StringUtil.StrCmp(cgiGet( chkcategEst_Internalname), "A")==0) ? "A" : "I");
               n147categEst = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A147categEst", A147categEst);
               n147categEst = (String.IsNullOrEmpty(StringUtil.RTrim( A147categEst)) ? true : false);
               /* Read saved values. */
               Z1EmpID = (short)(context.localUtil.CToN( cgiGet( "Z1EmpID"), ",", "."));
               Z32categID = (short)(context.localUtil.CToN( cgiGet( "Z32categID"), ",", "."));
               Z146categDsc = cgiGet( "Z146categDsc");
               n146categDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A146categDsc)) ? true : false);
               Z147categEst = cgiGet( "Z147categEst");
               n147categEst = (String.IsNullOrEmpty(StringUtil.RTrim( A147categEst)) ? true : false);
               Z31tipoProdID = (short)(context.localUtil.CToN( cgiGet( "Z31tipoProdID"), ",", "."));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_81 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_81"), ",", "."));
               N31tipoProdID = (short)(context.localUtil.CToN( cgiGet( "N31tipoProdID"), ",", "."));
               AV7EmpID = (short)(context.localUtil.CToN( cgiGet( "vEMPID"), ",", "."));
               AV8categID = (short)(context.localUtil.CToN( cgiGet( "vCATEGID"), ",", "."));
               AV12Insert_tipoProdID = (short)(context.localUtil.CToN( cgiGet( "vINSERT_TIPOPRODID"), ",", "."));
               AV18Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               A363subCatIDPrd = (short)(context.localUtil.CToN( cgiGet( "SUBCATIDPRD"), ",", "."));
               n363subCatIDPrd = false;
               n363subCatIDPrd = ((0==A363subCatIDPrd) ? true : false);
               Prdts_Objectcall = cgiGet( "PRDTS_Objectcall");
               Prdts_Enabled = StringUtil.StrToBool( cgiGet( "PRDTS_Enabled"));
               Prdts_Class = cgiGet( "PRDTS_Class");
               Prdts_Activepage = (int)(context.localUtil.CToN( cgiGet( "PRDTS_Activepage"), ",", "."));
               Prdts_Activepagecontrolname = cgiGet( "PRDTS_Activepagecontrolname");
               Prdts_Pagecount = (int)(context.localUtil.CToN( cgiGet( "PRDTS_Pagecount"), ",", "."));
               Prdts_Historymanagement = StringUtil.StrToBool( cgiGet( "PRDTS_Historymanagement"));
               Prdts_Visible = StringUtil.StrToBool( cgiGet( "PRDTS_Visible"));
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Categorias";
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV12Insert_tipoProdID), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A1EmpID != Z1EmpID ) || ( A32categID != Z32categID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("categorias:[SecurityCheckFailed value for]"+"Insert_tipoProdID:"+context.localUtil.Format( (decimal)(AV12Insert_tipoProdID), "ZZZ9"));
                  GXUtil.WriteLog("categorias:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A32categID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32categID", StringUtil.LTrim( StringUtil.Str( (decimal)(A32categID), 4, 0)));
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
                     sMode26 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode26;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound26 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0C0( ) ;
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
                        E110C2 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: After Trn */
                        E120C2 ();
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
            E120C2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0C26( ) ;
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
            DisableAttributes0C26( ) ;
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

      protected void CONFIRM_0C0( )
      {
         BeforeValidate0C26( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0C26( ) ;
            }
            else
            {
               CheckExtendedTable0C26( ) ;
               CloseExtendedTableCursors0C26( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode26 = Gx_mode;
            CONFIRM_0C27( ) ;
            if ( AnyError == 0 )
            {
               /* Restore parent mode. */
               Gx_mode = sMode26;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
               IsConfirmed = 1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
            }
            /* Restore parent mode. */
            Gx_mode = sMode26;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
      }

      protected void CONFIRM_0C47( )
      {
         nGXsfl_90_idx = 0;
         while ( nGXsfl_90_idx < nRC_GXsfl_90 )
         {
            ReadRow0C47( ) ;
            if ( ( nRcdExists_47 != 0 ) || ( nIsMod_47 != 0 ) )
            {
               GetKey0C47( ) ;
               if ( ( nRcdExists_47 == 0 ) && ( nRcdDeleted_47 == 0 ) )
               {
                  if ( RcdFound47 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate0C47( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0C47( ) ;
                        CloseExtendedTableCursors0C47( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "SUBCATID_" + sGXsfl_81_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtsubCatID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound47 != 0 )
                  {
                     if ( nRcdDeleted_47 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey0C47( ) ;
                        Load0C47( ) ;
                        BeforeValidate0C47( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0C47( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_47 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate0C47( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0C47( ) ;
                              CloseExtendedTableCursors0C47( ) ;
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
                     if ( nRcdDeleted_47 == 0 )
                     {
                        GXCCtl = "SUBCATID_" + sGXsfl_81_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtsubCatID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtdetSubID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A257detSubID), 4, 0, ",", ""))) ;
            ChangePostValue( edtdetSubDsc_Internalname, A258detSubDsc) ;
            ChangePostValue( "ZT_"+"Z257detSubID_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z257detSubID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z258detSubDsc_"+sGXsfl_90_idx, Z258detSubDsc) ;
            ChangePostValue( "ZT_"+"Z262detSubAnio_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z262detSubAnio), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z259detSubFch_"+sGXsfl_90_idx, context.localUtil.DToC( Z259detSubFch, 0, "/")) ;
            ChangePostValue( "ZT_"+"Z260detSubSldoIni_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( Z260detSubSldoIni, 10, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z261detSubActivo_"+sGXsfl_90_idx, StringUtil.RTrim( Z261detSubActivo)) ;
            ChangePostValue( "nRcdDeleted_47_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_47), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_47_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_47), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_47_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_47), 4, 0, ",", ""))) ;
            if ( nIsMod_47 != 0 )
            {
               ChangePostValue( "DETSUBID_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetSubID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETSUBDSC_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetSubDsc_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void CONFIRM_0C27( )
      {
         nGXsfl_81_idx = 0;
         while ( nGXsfl_81_idx < nRC_GXsfl_81 )
         {
            ReadRow0C27( ) ;
            if ( ( nRcdExists_27 != 0 ) || ( nIsMod_27 != 0 ) )
            {
               GetKey0C27( ) ;
               if ( ( nRcdExists_27 == 0 ) && ( nRcdDeleted_27 == 0 ) )
               {
                  if ( RcdFound27 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate0C27( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0C27( ) ;
                        CloseExtendedTableCursors0C27( ) ;
                        if ( AnyError == 0 )
                        {
                           /* Save parent mode. */
                           sMode27 = Gx_mode;
                           CONFIRM_0C47( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Restore parent mode. */
                              Gx_mode = sMode27;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                              IsConfirmed = 1;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                           }
                           /* Restore parent mode. */
                           Gx_mode = sMode27;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "SUBCATID_" + sGXsfl_81_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtsubCatID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound27 != 0 )
                  {
                     if ( nRcdDeleted_27 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey0C27( ) ;
                        Load0C27( ) ;
                        BeforeValidate0C27( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0C27( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_27 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate0C27( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0C27( ) ;
                              CloseExtendedTableCursors0C27( ) ;
                              if ( AnyError == 0 )
                              {
                                 /* Save parent mode. */
                                 sMode27 = Gx_mode;
                                 CONFIRM_0C47( ) ;
                                 if ( AnyError == 0 )
                                 {
                                    /* Restore parent mode. */
                                    Gx_mode = sMode27;
                                    context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                                    context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                                    IsConfirmed = 1;
                                    context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                                 }
                                 /* Restore parent mode. */
                                 Gx_mode = sMode27;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_27 == 0 )
                     {
                        GXCCtl = "SUBCATID_" + sGXsfl_81_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtsubCatID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtsubCatID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A33subCatID), 4, 0, ",", ""))) ;
            ChangePostValue( edtsubCatDsc_Internalname, StringUtil.RTrim( A148subCatDsc)) ;
            ChangePostValue( edtsubCatPrec_Internalname, StringUtil.LTrim( StringUtil.NToC( A150subCatPrec, 8, 2, ",", ""))) ;
            ChangePostValue( edtsubCatPeso_Internalname, StringUtil.LTrim( StringUtil.NToC( A151subCatPeso, 8, 2, ",", ""))) ;
            ChangePostValue( edtsubCatDisp_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A211subCatDisp), 8, 0, ",", ""))) ;
            ChangePostValue( edtsubCatEst_Internalname, StringUtil.RTrim( A149subCatEst)) ;
            ChangePostValue( "ZT_"+"Z33subCatID_"+sGXsfl_81_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z33subCatID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z148subCatDsc_"+sGXsfl_81_idx, StringUtil.RTrim( Z148subCatDsc)) ;
            ChangePostValue( "ZT_"+"Z150subCatPrec_"+sGXsfl_81_idx, StringUtil.LTrim( StringUtil.NToC( Z150subCatPrec, 8, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z151subCatPeso_"+sGXsfl_81_idx, StringUtil.LTrim( StringUtil.NToC( Z151subCatPeso, 8, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z211subCatDisp_"+sGXsfl_81_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z211subCatDisp), 8, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z149subCatEst_"+sGXsfl_81_idx, StringUtil.RTrim( Z149subCatEst)) ;
            ChangePostValue( "ZT_"+"Z363subCatIDPrd_"+sGXsfl_81_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z363subCatIDPrd), 4, 0, ",", ""))) ;
            ChangePostValue( "nRC_GXsfl_90_"+sGXsfl_81_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_90), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_27_"+sGXsfl_81_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_27), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_27_"+sGXsfl_81_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_27), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_27_"+sGXsfl_81_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_27), 4, 0, ",", ""))) ;
            if ( nIsMod_27 != 0 )
            {
               ChangePostValue( "SUBCATID_"+sGXsfl_81_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATDSC_"+sGXsfl_81_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatDsc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATPREC_"+sGXsfl_81_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatPrec_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATPESO_"+sGXsfl_81_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatPeso_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATDISP_"+sGXsfl_81_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatDisp_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATEST_"+sGXsfl_81_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatEst_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption0C0( )
      {
      }

      protected void E110C2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV18Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV18Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV10TrnContext.FromXml(AV11WebSession.Get("TrnContext"), null, "TransactionContext", "KBCalpesa22");
         AV12Insert_tipoProdID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Insert_tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12Insert_tipoProdID), 4, 0)));
         if ( ( StringUtil.StrCmp(AV10TrnContext.gxTpr_Transactionname, AV18Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV19GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19GXV1), 8, 0)));
            while ( AV19GXV1 <= AV10TrnContext.gxTpr_Attributes.Count )
            {
               AV13TrnContextAtt = ((SdtTransactionContext_Attribute)AV10TrnContext.gxTpr_Attributes.Item(AV19GXV1));
               if ( StringUtil.StrCmp(AV13TrnContextAtt.gxTpr_Attributename, "tipoProdID") == 0 )
               {
                  AV12Insert_tipoProdID = (short)(NumberUtil.Val( AV13TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Insert_tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12Insert_tipoProdID), 4, 0)));
               }
               AV19GXV1 = (int)(AV19GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19GXV1), 8, 0)));
            }
         }
         subGrid1_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Visible), 5, 0)), true);
      }

      protected void E120C2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV10TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwcategorias.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0C26( short GX_JID )
      {
         if ( ( GX_JID == 12 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z146categDsc = T000C7_A146categDsc[0];
               Z147categEst = T000C7_A147categEst[0];
               Z31tipoProdID = T000C7_A31tipoProdID[0];
            }
            else
            {
               Z146categDsc = A146categDsc;
               Z147categEst = A147categEst;
               Z31tipoProdID = A31tipoProdID;
            }
         }
         if ( GX_JID == -12 )
         {
            Z32categID = A32categID;
            Z146categDsc = A146categDsc;
            Z147categEst = A147categEst;
            Z1EmpID = A1EmpID;
            Z31tipoProdID = A31tipoProdID;
            Z44empdsc = A44empdsc;
            Z144tipoProdDsc = A144tipoProdDsc;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_1_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_31_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00p1.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"TIPOPRODID"+"'), id:'"+"TIPOPRODID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
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
         if ( ! (0==AV8categID) )
         {
            A32categID = AV8categID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32categID", StringUtil.LTrim( StringUtil.Str( (decimal)(A32categID), 4, 0)));
         }
         if ( ! (0==AV8categID) )
         {
            edtcategID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcategID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcategID_Enabled), 5, 0)), true);
         }
         else
         {
            edtcategID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcategID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcategID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV8categID) )
         {
            edtcategID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcategID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcategID_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV12Insert_tipoProdID) )
         {
            edttipoProdID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edttipoProdID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edttipoProdID_Enabled), 5, 0)), true);
         }
         else
         {
            edttipoProdID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edttipoProdID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edttipoProdID_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV12Insert_tipoProdID) )
         {
            A31tipoProdID = AV12Insert_tipoProdID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A31tipoProdID), 4, 0)));
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
            /* Using cursor T000C8 */
            pr_default.execute(6, new Object[] {A1EmpID});
            A44empdsc = T000C8_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000C8_n44empdsc[0];
            pr_default.close(6);
            AV18Pgmname = "Categorias";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Pgmname", AV18Pgmname);
            /* Using cursor T000C9 */
            pr_default.execute(7, new Object[] {A1EmpID, A31tipoProdID});
            A144tipoProdDsc = T000C9_A144tipoProdDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144tipoProdDsc", A144tipoProdDsc);
            n144tipoProdDsc = T000C9_n144tipoProdDsc[0];
            pr_default.close(7);
         }
      }

      protected void Load0C26( )
      {
         /* Using cursor T000C10 */
         pr_default.execute(8, new Object[] {A1EmpID, A32categID});
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound26 = 1;
            A44empdsc = T000C10_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000C10_n44empdsc[0];
            A146categDsc = T000C10_A146categDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A146categDsc", A146categDsc);
            n146categDsc = T000C10_n146categDsc[0];
            A144tipoProdDsc = T000C10_A144tipoProdDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144tipoProdDsc", A144tipoProdDsc);
            n144tipoProdDsc = T000C10_n144tipoProdDsc[0];
            A147categEst = T000C10_A147categEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A147categEst", A147categEst);
            n147categEst = T000C10_n147categEst[0];
            A31tipoProdID = T000C10_A31tipoProdID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A31tipoProdID), 4, 0)));
            ZM0C26( -12) ;
         }
         pr_default.close(8);
         OnLoadActions0C26( ) ;
      }

      protected void OnLoadActions0C26( )
      {
         AV18Pgmname = "Categorias";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Pgmname", AV18Pgmname);
      }

      protected void CheckExtendedTable0C26( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV18Pgmname = "Categorias";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Pgmname", AV18Pgmname);
         /* Using cursor T000C8 */
         pr_default.execute(6, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000C8_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T000C8_n44empdsc[0];
         pr_default.close(6);
         /* Using cursor T000C9 */
         pr_default.execute(7, new Object[] {A1EmpID, A31tipoProdID});
         if ( (pr_default.getStatus(7) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Producto'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A144tipoProdDsc = T000C9_A144tipoProdDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144tipoProdDsc", A144tipoProdDsc);
         n144tipoProdDsc = T000C9_n144tipoProdDsc[0];
         pr_default.close(7);
      }

      protected void CloseExtendedTableCursors0C26( )
      {
         pr_default.close(6);
         pr_default.close(7);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_13( short A1EmpID )
      {
         /* Using cursor T000C11 */
         pr_default.execute(9, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(9) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000C11_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T000C11_n44empdsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A44empdsc)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(9) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(9);
      }

      protected void gxLoad_14( short A1EmpID ,
                                short A31tipoProdID )
      {
         /* Using cursor T000C12 */
         pr_default.execute(10, new Object[] {A1EmpID, A31tipoProdID});
         if ( (pr_default.getStatus(10) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Producto'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A144tipoProdDsc = T000C12_A144tipoProdDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144tipoProdDsc", A144tipoProdDsc);
         n144tipoProdDsc = T000C12_n144tipoProdDsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A144tipoProdDsc))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(10) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(10);
      }

      protected void GetKey0C26( )
      {
         /* Using cursor T000C13 */
         pr_default.execute(11, new Object[] {A1EmpID, A32categID});
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound26 = 1;
         }
         else
         {
            RcdFound26 = 0;
         }
         pr_default.close(11);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000C7 */
         pr_default.execute(5, new Object[] {A1EmpID, A32categID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            ZM0C26( 12) ;
            RcdFound26 = 1;
            A32categID = T000C7_A32categID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32categID", StringUtil.LTrim( StringUtil.Str( (decimal)(A32categID), 4, 0)));
            A146categDsc = T000C7_A146categDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A146categDsc", A146categDsc);
            n146categDsc = T000C7_n146categDsc[0];
            A147categEst = T000C7_A147categEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A147categEst", A147categEst);
            n147categEst = T000C7_n147categEst[0];
            A1EmpID = T000C7_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A31tipoProdID = T000C7_A31tipoProdID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A31tipoProdID), 4, 0)));
            Z1EmpID = A1EmpID;
            Z32categID = A32categID;
            sMode26 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0C26( ) ;
            if ( AnyError == 1 )
            {
               RcdFound26 = 0;
               InitializeNonKey0C26( ) ;
            }
            Gx_mode = sMode26;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound26 = 0;
            InitializeNonKey0C26( ) ;
            sMode26 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode26;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(5);
      }

      protected void getEqualNoModal( )
      {
         GetKey0C26( ) ;
         if ( RcdFound26 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound26 = 0;
         /* Using cursor T000C14 */
         pr_default.execute(12, new Object[] {A1EmpID, A32categID});
         if ( (pr_default.getStatus(12) != 101) )
         {
            while ( (pr_default.getStatus(12) != 101) && ( ( T000C14_A1EmpID[0] < A1EmpID ) || ( T000C14_A1EmpID[0] == A1EmpID ) && ( T000C14_A32categID[0] < A32categID ) ) )
            {
               pr_default.readNext(12);
            }
            if ( (pr_default.getStatus(12) != 101) && ( ( T000C14_A1EmpID[0] > A1EmpID ) || ( T000C14_A1EmpID[0] == A1EmpID ) && ( T000C14_A32categID[0] > A32categID ) ) )
            {
               A1EmpID = T000C14_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A32categID = T000C14_A32categID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32categID", StringUtil.LTrim( StringUtil.Str( (decimal)(A32categID), 4, 0)));
               RcdFound26 = 1;
            }
         }
         pr_default.close(12);
      }

      protected void move_previous( )
      {
         RcdFound26 = 0;
         /* Using cursor T000C15 */
         pr_default.execute(13, new Object[] {A1EmpID, A32categID});
         if ( (pr_default.getStatus(13) != 101) )
         {
            while ( (pr_default.getStatus(13) != 101) && ( ( T000C15_A1EmpID[0] > A1EmpID ) || ( T000C15_A1EmpID[0] == A1EmpID ) && ( T000C15_A32categID[0] > A32categID ) ) )
            {
               pr_default.readNext(13);
            }
            if ( (pr_default.getStatus(13) != 101) && ( ( T000C15_A1EmpID[0] < A1EmpID ) || ( T000C15_A1EmpID[0] == A1EmpID ) && ( T000C15_A32categID[0] < A32categID ) ) )
            {
               A1EmpID = T000C15_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A32categID = T000C15_A32categID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32categID", StringUtil.LTrim( StringUtil.Str( (decimal)(A32categID), 4, 0)));
               RcdFound26 = 1;
            }
         }
         pr_default.close(13);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0C26( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0C26( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound26 == 1 )
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A32categID != Z32categID ) )
               {
                  A1EmpID = Z1EmpID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
                  A32categID = Z32categID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32categID", StringUtil.LTrim( StringUtil.Str( (decimal)(A32categID), 4, 0)));
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
                  Update0C26( ) ;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A32categID != Z32categID ) )
               {
                  /* Insert record */
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0C26( ) ;
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
                     Insert0C26( ) ;
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
         if ( ( A1EmpID != Z1EmpID ) || ( A32categID != Z32categID ) )
         {
            A1EmpID = Z1EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A32categID = Z32categID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32categID", StringUtil.LTrim( StringUtil.Str( (decimal)(A32categID), 4, 0)));
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

      protected void CheckOptimisticConcurrency0C26( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000C6 */
            pr_default.execute(4, new Object[] {A1EmpID, A32categID});
            if ( (pr_default.getStatus(4) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Categorias"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(4) == 101) || ( StringUtil.StrCmp(Z146categDsc, T000C6_A146categDsc[0]) != 0 ) || ( StringUtil.StrCmp(Z147categEst, T000C6_A147categEst[0]) != 0 ) || ( Z31tipoProdID != T000C6_A31tipoProdID[0] ) )
            {
               if ( StringUtil.StrCmp(Z146categDsc, T000C6_A146categDsc[0]) != 0 )
               {
                  GXUtil.WriteLog("categorias:[seudo value changed for attri]"+"categDsc");
                  GXUtil.WriteLogRaw("Old: ",Z146categDsc);
                  GXUtil.WriteLogRaw("Current: ",T000C6_A146categDsc[0]);
               }
               if ( StringUtil.StrCmp(Z147categEst, T000C6_A147categEst[0]) != 0 )
               {
                  GXUtil.WriteLog("categorias:[seudo value changed for attri]"+"categEst");
                  GXUtil.WriteLogRaw("Old: ",Z147categEst);
                  GXUtil.WriteLogRaw("Current: ",T000C6_A147categEst[0]);
               }
               if ( Z31tipoProdID != T000C6_A31tipoProdID[0] )
               {
                  GXUtil.WriteLog("categorias:[seudo value changed for attri]"+"tipoProdID");
                  GXUtil.WriteLogRaw("Old: ",Z31tipoProdID);
                  GXUtil.WriteLogRaw("Current: ",T000C6_A31tipoProdID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Categorias"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0C26( )
      {
         BeforeValidate0C26( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0C26( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0C26( 0) ;
            CheckOptimisticConcurrency0C26( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0C26( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0C26( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000C16 */
                     pr_default.execute(14, new Object[] {A32categID, n146categDsc, A146categDsc, n147categEst, A147categEst, A1EmpID, A31tipoProdID});
                     pr_default.close(14);
                     dsDefault.SmartCacheProvider.SetUpdated("Categorias") ;
                     if ( (pr_default.getStatus(14) == 1) )
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
                           ProcessLevel0C26( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption0C0( ) ;
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
               Load0C26( ) ;
            }
            EndLevel0C26( ) ;
         }
         CloseExtendedTableCursors0C26( ) ;
      }

      protected void Update0C26( )
      {
         BeforeValidate0C26( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0C26( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0C26( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0C26( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0C26( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000C17 */
                     pr_default.execute(15, new Object[] {n146categDsc, A146categDsc, n147categEst, A147categEst, A31tipoProdID, A1EmpID, A32categID});
                     pr_default.close(15);
                     dsDefault.SmartCacheProvider.SetUpdated("Categorias") ;
                     if ( (pr_default.getStatus(15) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Categorias"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0C26( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0C26( ) ;
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
            EndLevel0C26( ) ;
         }
         CloseExtendedTableCursors0C26( ) ;
      }

      protected void DeferredUpdate0C26( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0C26( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0C26( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0C26( ) ;
            AfterConfirm0C26( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0C26( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000C18 */
                  pr_default.execute(16, new Object[] {A1EmpID, A32categID});
                  pr_default.close(16);
                  dsDefault.SmartCacheProvider.SetUpdated("Categorias") ;
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
         sMode26 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0C26( ) ;
         Gx_mode = sMode26;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0C26( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV18Pgmname = "Categorias";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Pgmname", AV18Pgmname);
            /* Using cursor T000C19 */
            pr_default.execute(17, new Object[] {A1EmpID});
            A44empdsc = T000C19_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000C19_n44empdsc[0];
            pr_default.close(17);
            /* Using cursor T000C20 */
            pr_default.execute(18, new Object[] {A1EmpID, A31tipoProdID});
            A144tipoProdDsc = T000C20_A144tipoProdDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144tipoProdDsc", A144tipoProdDsc);
            n144tipoProdDsc = T000C20_n144tipoProdDsc[0];
            pr_default.close(18);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000C21 */
            pr_default.execute(19, new Object[] {A1EmpID, A32categID});
            if ( (pr_default.getStatus(19) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"sub Cat"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(19);
         }
      }

      protected void ProcessNestedLevel0C27( )
      {
         nGXsfl_81_idx = 0;
         while ( nGXsfl_81_idx < nRC_GXsfl_81 )
         {
            ReadRow0C27( ) ;
            if ( ( nRcdExists_27 != 0 ) || ( nIsMod_27 != 0 ) )
            {
               standaloneNotModal0C27( ) ;
               GetKey0C27( ) ;
               if ( ( nRcdExists_27 == 0 ) && ( nRcdDeleted_27 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert0C27( ) ;
               }
               else
               {
                  if ( RcdFound27 != 0 )
                  {
                     if ( ( nRcdDeleted_27 != 0 ) && ( nRcdExists_27 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete0C27( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_27 != 0 ) && ( nRcdExists_27 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update0C27( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_27 == 0 )
                     {
                        GXCCtl = "SUBCATID_" + sGXsfl_81_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtsubCatID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtsubCatID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A33subCatID), 4, 0, ",", ""))) ;
            ChangePostValue( edtsubCatDsc_Internalname, StringUtil.RTrim( A148subCatDsc)) ;
            ChangePostValue( edtsubCatPrec_Internalname, StringUtil.LTrim( StringUtil.NToC( A150subCatPrec, 8, 2, ",", ""))) ;
            ChangePostValue( edtsubCatPeso_Internalname, StringUtil.LTrim( StringUtil.NToC( A151subCatPeso, 8, 2, ",", ""))) ;
            ChangePostValue( edtsubCatDisp_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A211subCatDisp), 8, 0, ",", ""))) ;
            ChangePostValue( edtsubCatEst_Internalname, StringUtil.RTrim( A149subCatEst)) ;
            ChangePostValue( "ZT_"+"Z33subCatID_"+sGXsfl_81_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z33subCatID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z148subCatDsc_"+sGXsfl_81_idx, StringUtil.RTrim( Z148subCatDsc)) ;
            ChangePostValue( "ZT_"+"Z150subCatPrec_"+sGXsfl_81_idx, StringUtil.LTrim( StringUtil.NToC( Z150subCatPrec, 8, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z151subCatPeso_"+sGXsfl_81_idx, StringUtil.LTrim( StringUtil.NToC( Z151subCatPeso, 8, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z211subCatDisp_"+sGXsfl_81_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z211subCatDisp), 8, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z149subCatEst_"+sGXsfl_81_idx, StringUtil.RTrim( Z149subCatEst)) ;
            ChangePostValue( "ZT_"+"Z363subCatIDPrd_"+sGXsfl_81_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z363subCatIDPrd), 4, 0, ",", ""))) ;
            ChangePostValue( "nRC_GXsfl_90_"+sGXsfl_81_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_90), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_27_"+sGXsfl_81_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_27), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_27_"+sGXsfl_81_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_27), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_27_"+sGXsfl_81_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_27), 4, 0, ",", ""))) ;
            if ( nIsMod_27 != 0 )
            {
               ChangePostValue( "SUBCATID_"+sGXsfl_81_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATDSC_"+sGXsfl_81_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatDsc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATPREC_"+sGXsfl_81_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatPrec_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATPESO_"+sGXsfl_81_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatPeso_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATDISP_"+sGXsfl_81_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatDisp_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATEST_"+sGXsfl_81_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatEst_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0C27( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_27 = 0;
         nIsMod_27 = 0;
         nRcdDeleted_27 = 0;
      }

      protected void ProcessLevel0C26( )
      {
         /* Save parent mode. */
         sMode26 = Gx_mode;
         ProcessNestedLevel0C27( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode26;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         /* ' Update level parameters */
      }

      protected void EndLevel0C26( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(4);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0C26( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(5);
            pr_default.close(3);
            pr_default.close(2);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(17);
            pr_default.close(18);
            context.CommitDataStores("categorias",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0C0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(5);
            pr_default.close(3);
            pr_default.close(2);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(17);
            pr_default.close(18);
            context.RollbackDataStores("categorias",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0C26( )
      {
         /* Scan By routine */
         /* Using cursor T000C22 */
         pr_default.execute(20);
         RcdFound26 = 0;
         if ( (pr_default.getStatus(20) != 101) )
         {
            RcdFound26 = 1;
            A1EmpID = T000C22_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A32categID = T000C22_A32categID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32categID", StringUtil.LTrim( StringUtil.Str( (decimal)(A32categID), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0C26( )
      {
         /* Scan next routine */
         pr_default.readNext(20);
         RcdFound26 = 0;
         if ( (pr_default.getStatus(20) != 101) )
         {
            RcdFound26 = 1;
            A1EmpID = T000C22_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A32categID = T000C22_A32categID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32categID", StringUtil.LTrim( StringUtil.Str( (decimal)(A32categID), 4, 0)));
         }
      }

      protected void ScanEnd0C26( )
      {
         pr_default.close(20);
      }

      protected void AfterConfirm0C26( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0C26( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0C26( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0C26( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0C26( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0C26( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0C26( )
      {
         edtEmpID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         edtempdsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempdsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempdsc_Enabled), 5, 0)), true);
         edtcategID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcategID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcategID_Enabled), 5, 0)), true);
         edtcategDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcategDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcategDsc_Enabled), 5, 0)), true);
         edttipoProdID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edttipoProdID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edttipoProdID_Enabled), 5, 0)), true);
         edttipoProdDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edttipoProdDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edttipoProdDsc_Enabled), 5, 0)), true);
         chkcategEst.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkcategEst_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkcategEst.Enabled), 5, 0)), true);
      }

      protected void ZM0C27( short GX_JID )
      {
         if ( ( GX_JID == 15 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z148subCatDsc = T000C5_A148subCatDsc[0];
               Z150subCatPrec = T000C5_A150subCatPrec[0];
               Z151subCatPeso = T000C5_A151subCatPeso[0];
               Z211subCatDisp = T000C5_A211subCatDisp[0];
               Z149subCatEst = T000C5_A149subCatEst[0];
               Z363subCatIDPrd = T000C5_A363subCatIDPrd[0];
            }
            else
            {
               Z148subCatDsc = A148subCatDsc;
               Z150subCatPrec = A150subCatPrec;
               Z151subCatPeso = A151subCatPeso;
               Z211subCatDisp = A211subCatDisp;
               Z149subCatEst = A149subCatEst;
               Z363subCatIDPrd = A363subCatIDPrd;
            }
         }
         if ( GX_JID == -15 )
         {
            Z1EmpID = A1EmpID;
            Z32categID = A32categID;
            Z33subCatID = A33subCatID;
            Z148subCatDsc = A148subCatDsc;
            Z150subCatPrec = A150subCatPrec;
            Z151subCatPeso = A151subCatPeso;
            Z211subCatDisp = A211subCatDisp;
            Z149subCatEst = A149subCatEst;
            Z363subCatIDPrd = A363subCatIDPrd;
         }
      }

      protected void standaloneNotModal0C27( )
      {
      }

      protected void standaloneModal0C27( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtsubCatID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatID_Enabled), 5, 0)), !bGXsfl_81_Refreshing);
         }
         else
         {
            edtsubCatID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatID_Enabled), 5, 0)), !bGXsfl_81_Refreshing);
         }
      }

      protected void Load0C27( )
      {
         /* Using cursor T000C23 */
         pr_default.execute(21, new Object[] {A1EmpID, A32categID, A33subCatID});
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound27 = 1;
            A148subCatDsc = T000C23_A148subCatDsc[0];
            n148subCatDsc = T000C23_n148subCatDsc[0];
            A150subCatPrec = T000C23_A150subCatPrec[0];
            n150subCatPrec = T000C23_n150subCatPrec[0];
            A151subCatPeso = T000C23_A151subCatPeso[0];
            n151subCatPeso = T000C23_n151subCatPeso[0];
            A211subCatDisp = T000C23_A211subCatDisp[0];
            n211subCatDisp = T000C23_n211subCatDisp[0];
            A149subCatEst = T000C23_A149subCatEst[0];
            n149subCatEst = T000C23_n149subCatEst[0];
            A363subCatIDPrd = T000C23_A363subCatIDPrd[0];
            n363subCatIDPrd = T000C23_n363subCatIDPrd[0];
            ZM0C27( -15) ;
         }
         pr_default.close(21);
         OnLoadActions0C27( ) ;
      }

      protected void OnLoadActions0C27( )
      {
      }

      protected void CheckExtendedTable0C27( )
      {
         Gx_BScreen = 1;
         standaloneModal0C27( ) ;
      }

      protected void CloseExtendedTableCursors0C27( )
      {
      }

      protected void enableDisable0C27( )
      {
      }

      protected void GetKey0C27( )
      {
         /* Using cursor T000C24 */
         pr_default.execute(22, new Object[] {A1EmpID, A32categID, A33subCatID});
         if ( (pr_default.getStatus(22) != 101) )
         {
            RcdFound27 = 1;
         }
         else
         {
            RcdFound27 = 0;
         }
         pr_default.close(22);
      }

      protected void getByPrimaryKey0C27( )
      {
         /* Using cursor T000C5 */
         pr_default.execute(3, new Object[] {A1EmpID, A32categID, A33subCatID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM0C27( 15) ;
            RcdFound27 = 1;
            InitializeNonKey0C27( ) ;
            A33subCatID = T000C5_A33subCatID[0];
            A148subCatDsc = T000C5_A148subCatDsc[0];
            n148subCatDsc = T000C5_n148subCatDsc[0];
            A150subCatPrec = T000C5_A150subCatPrec[0];
            n150subCatPrec = T000C5_n150subCatPrec[0];
            A151subCatPeso = T000C5_A151subCatPeso[0];
            n151subCatPeso = T000C5_n151subCatPeso[0];
            A211subCatDisp = T000C5_A211subCatDisp[0];
            n211subCatDisp = T000C5_n211subCatDisp[0];
            A149subCatEst = T000C5_A149subCatEst[0];
            n149subCatEst = T000C5_n149subCatEst[0];
            A363subCatIDPrd = T000C5_A363subCatIDPrd[0];
            n363subCatIDPrd = T000C5_n363subCatIDPrd[0];
            Z1EmpID = A1EmpID;
            Z32categID = A32categID;
            Z33subCatID = A33subCatID;
            sMode27 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0C27( ) ;
            Gx_mode = sMode27;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound27 = 0;
            InitializeNonKey0C27( ) ;
            sMode27 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal0C27( ) ;
            Gx_mode = sMode27;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes0C27( ) ;
         }
         pr_default.close(3);
      }

      protected void CheckOptimisticConcurrency0C27( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000C4 */
            pr_default.execute(2, new Object[] {A1EmpID, A32categID, A33subCatID});
            if ( (pr_default.getStatus(2) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CategoriassubCat"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(2) == 101) || ( StringUtil.StrCmp(Z148subCatDsc, T000C4_A148subCatDsc[0]) != 0 ) || ( Z150subCatPrec != T000C4_A150subCatPrec[0] ) || ( Z151subCatPeso != T000C4_A151subCatPeso[0] ) || ( Z211subCatDisp != T000C4_A211subCatDisp[0] ) || ( StringUtil.StrCmp(Z149subCatEst, T000C4_A149subCatEst[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z363subCatIDPrd != T000C4_A363subCatIDPrd[0] ) )
            {
               if ( StringUtil.StrCmp(Z148subCatDsc, T000C4_A148subCatDsc[0]) != 0 )
               {
                  GXUtil.WriteLog("categorias:[seudo value changed for attri]"+"subCatDsc");
                  GXUtil.WriteLogRaw("Old: ",Z148subCatDsc);
                  GXUtil.WriteLogRaw("Current: ",T000C4_A148subCatDsc[0]);
               }
               if ( Z150subCatPrec != T000C4_A150subCatPrec[0] )
               {
                  GXUtil.WriteLog("categorias:[seudo value changed for attri]"+"subCatPrec");
                  GXUtil.WriteLogRaw("Old: ",Z150subCatPrec);
                  GXUtil.WriteLogRaw("Current: ",T000C4_A150subCatPrec[0]);
               }
               if ( Z151subCatPeso != T000C4_A151subCatPeso[0] )
               {
                  GXUtil.WriteLog("categorias:[seudo value changed for attri]"+"subCatPeso");
                  GXUtil.WriteLogRaw("Old: ",Z151subCatPeso);
                  GXUtil.WriteLogRaw("Current: ",T000C4_A151subCatPeso[0]);
               }
               if ( Z211subCatDisp != T000C4_A211subCatDisp[0] )
               {
                  GXUtil.WriteLog("categorias:[seudo value changed for attri]"+"subCatDisp");
                  GXUtil.WriteLogRaw("Old: ",Z211subCatDisp);
                  GXUtil.WriteLogRaw("Current: ",T000C4_A211subCatDisp[0]);
               }
               if ( StringUtil.StrCmp(Z149subCatEst, T000C4_A149subCatEst[0]) != 0 )
               {
                  GXUtil.WriteLog("categorias:[seudo value changed for attri]"+"subCatEst");
                  GXUtil.WriteLogRaw("Old: ",Z149subCatEst);
                  GXUtil.WriteLogRaw("Current: ",T000C4_A149subCatEst[0]);
               }
               if ( Z363subCatIDPrd != T000C4_A363subCatIDPrd[0] )
               {
                  GXUtil.WriteLog("categorias:[seudo value changed for attri]"+"subCatIDPrd");
                  GXUtil.WriteLogRaw("Old: ",Z363subCatIDPrd);
                  GXUtil.WriteLogRaw("Current: ",T000C4_A363subCatIDPrd[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"CategoriassubCat"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0C27( )
      {
         BeforeValidate0C27( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0C27( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0C27( 0) ;
            CheckOptimisticConcurrency0C27( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0C27( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0C27( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000C25 */
                     pr_default.execute(23, new Object[] {A1EmpID, A32categID, A33subCatID, n148subCatDsc, A148subCatDsc, n150subCatPrec, A150subCatPrec, n151subCatPeso, A151subCatPeso, n211subCatDisp, A211subCatDisp, n149subCatEst, A149subCatEst, n363subCatIDPrd, A363subCatIDPrd});
                     pr_default.close(23);
                     dsDefault.SmartCacheProvider.SetUpdated("CategoriassubCat") ;
                     if ( (pr_default.getStatus(23) == 1) )
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
                           ProcessLevel0C27( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
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
               Load0C27( ) ;
            }
            EndLevel0C27( ) ;
         }
         CloseExtendedTableCursors0C27( ) ;
      }

      protected void Update0C27( )
      {
         BeforeValidate0C27( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0C27( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0C27( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0C27( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0C27( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000C26 */
                     pr_default.execute(24, new Object[] {n148subCatDsc, A148subCatDsc, n150subCatPrec, A150subCatPrec, n151subCatPeso, A151subCatPeso, n211subCatDisp, A211subCatDisp, n149subCatEst, A149subCatEst, n363subCatIDPrd, A363subCatIDPrd, A1EmpID, A32categID, A33subCatID});
                     pr_default.close(24);
                     dsDefault.SmartCacheProvider.SetUpdated("CategoriassubCat") ;
                     if ( (pr_default.getStatus(24) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CategoriassubCat"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0C27( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0C27( ) ;
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
            EndLevel0C27( ) ;
         }
         CloseExtendedTableCursors0C27( ) ;
      }

      protected void DeferredUpdate0C27( )
      {
      }

      protected void Delete0C27( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate0C27( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0C27( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0C27( ) ;
            AfterConfirm0C27( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0C27( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart0C47( ) ;
                  while ( RcdFound47 != 0 )
                  {
                     getByPrimaryKey0C47( ) ;
                     Delete0C47( ) ;
                     ScanNext0C47( ) ;
                  }
                  ScanEnd0C47( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000C27 */
                     pr_default.execute(25, new Object[] {A1EmpID, A32categID, A33subCatID});
                     pr_default.close(25);
                     dsDefault.SmartCacheProvider.SetUpdated("CategoriassubCat") ;
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
         }
         sMode27 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0C27( ) ;
         Gx_mode = sMode27;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0C27( )
      {
         standaloneModal0C27( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000C28 */
            pr_default.execute(26, new Object[] {A1EmpID, A32categID, A33subCatID});
            if ( (pr_default.getStatus(26) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Hist Precio Productos"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(26);
            /* Using cursor T000C29 */
            pr_default.execute(27, new Object[] {A1EmpID, A32categID, A33subCatID});
            if ( (pr_default.getStatus(27) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"OPId"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(27);
            /* Using cursor T000C30 */
            pr_default.execute(28, new Object[] {A1EmpID, A32categID, A33subCatID});
            if ( (pr_default.getStatus(28) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Level1"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(28);
            /* Using cursor T000C31 */
            pr_default.execute(29, new Object[] {A1EmpID, A32categID, A33subCatID});
            if ( (pr_default.getStatus(29) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Items"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(29);
         }
      }

      protected void ProcessNestedLevel0C47( )
      {
         nGXsfl_90_idx = 0;
         while ( nGXsfl_90_idx < nRC_GXsfl_90 )
         {
            ReadRow0C47( ) ;
            if ( ( nRcdExists_47 != 0 ) || ( nIsMod_47 != 0 ) )
            {
               standaloneNotModal0C47( ) ;
               GetKey0C47( ) ;
               if ( ( nRcdExists_47 == 0 ) && ( nRcdDeleted_47 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert0C47( ) ;
               }
               else
               {
                  if ( RcdFound47 != 0 )
                  {
                     if ( ( nRcdDeleted_47 != 0 ) && ( nRcdExists_47 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete0C47( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_47 != 0 ) && ( nRcdExists_47 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update0C47( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_47 == 0 )
                     {
                        GXCCtl = "SUBCATID_" + sGXsfl_81_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtsubCatID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtdetSubID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A257detSubID), 4, 0, ",", ""))) ;
            ChangePostValue( edtdetSubDsc_Internalname, A258detSubDsc) ;
            ChangePostValue( "ZT_"+"Z257detSubID_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z257detSubID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z258detSubDsc_"+sGXsfl_90_idx, Z258detSubDsc) ;
            ChangePostValue( "ZT_"+"Z262detSubAnio_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z262detSubAnio), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z259detSubFch_"+sGXsfl_90_idx, context.localUtil.DToC( Z259detSubFch, 0, "/")) ;
            ChangePostValue( "ZT_"+"Z260detSubSldoIni_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( Z260detSubSldoIni, 10, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z261detSubActivo_"+sGXsfl_90_idx, StringUtil.RTrim( Z261detSubActivo)) ;
            ChangePostValue( "nRcdDeleted_47_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_47), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_47_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_47), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_47_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_47), 4, 0, ",", ""))) ;
            if ( nIsMod_47 != 0 )
            {
               ChangePostValue( "DETSUBID_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetSubID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETSUBDSC_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetSubDsc_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0C47( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_47 = 0;
         nIsMod_47 = 0;
         nRcdDeleted_47 = 0;
      }

      protected void ProcessLevel0C27( )
      {
         /* Save parent mode. */
         sMode27 = Gx_mode;
         ProcessNestedLevel0C47( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode27;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         /* ' Update level parameters */
      }

      protected void EndLevel0C27( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(2);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0C27( )
      {
         /* Scan By routine */
         /* Using cursor T000C32 */
         pr_default.execute(30, new Object[] {A1EmpID, A32categID});
         RcdFound27 = 0;
         if ( (pr_default.getStatus(30) != 101) )
         {
            RcdFound27 = 1;
            A33subCatID = T000C32_A33subCatID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0C27( )
      {
         /* Scan next routine */
         pr_default.readNext(30);
         RcdFound27 = 0;
         if ( (pr_default.getStatus(30) != 101) )
         {
            RcdFound27 = 1;
            A33subCatID = T000C32_A33subCatID[0];
         }
      }

      protected void ScanEnd0C27( )
      {
         pr_default.close(30);
      }

      protected void AfterConfirm0C27( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0C27( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0C27( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0C27( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0C27( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0C27( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0C27( )
      {
         edtsubCatID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatID_Enabled), 5, 0)), !bGXsfl_81_Refreshing);
         edtsubCatDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatDsc_Enabled), 5, 0)), !bGXsfl_81_Refreshing);
         edtsubCatPrec_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatPrec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatPrec_Enabled), 5, 0)), !bGXsfl_81_Refreshing);
         edtsubCatPeso_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatPeso_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatPeso_Enabled), 5, 0)), !bGXsfl_81_Refreshing);
         edtsubCatDisp_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatDisp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatDisp_Enabled), 5, 0)), !bGXsfl_81_Refreshing);
         edtsubCatEst_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatEst_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatEst_Enabled), 5, 0)), !bGXsfl_81_Refreshing);
      }

      protected void ZM0C47( short GX_JID )
      {
         if ( ( GX_JID == 16 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z258detSubDsc = T000C3_A258detSubDsc[0];
               Z262detSubAnio = T000C3_A262detSubAnio[0];
               Z259detSubFch = T000C3_A259detSubFch[0];
               Z260detSubSldoIni = T000C3_A260detSubSldoIni[0];
               Z261detSubActivo = T000C3_A261detSubActivo[0];
            }
            else
            {
               Z258detSubDsc = A258detSubDsc;
               Z262detSubAnio = A262detSubAnio;
               Z259detSubFch = A259detSubFch;
               Z260detSubSldoIni = A260detSubSldoIni;
               Z261detSubActivo = A261detSubActivo;
            }
         }
         if ( GX_JID == -16 )
         {
            Z1EmpID = A1EmpID;
            Z32categID = A32categID;
            Z33subCatID = A33subCatID;
            Z257detSubID = A257detSubID;
            Z258detSubDsc = A258detSubDsc;
            Z262detSubAnio = A262detSubAnio;
            Z259detSubFch = A259detSubFch;
            Z260detSubSldoIni = A260detSubSldoIni;
            Z261detSubActivo = A261detSubActivo;
         }
      }

      protected void standaloneNotModal0C47( )
      {
      }

      protected void standaloneModal0C47( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtdetSubID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetSubID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetSubID_Enabled), 5, 0)), !bGXsfl_90_Refreshing);
         }
         else
         {
            edtdetSubID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetSubID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetSubID_Enabled), 5, 0)), !bGXsfl_90_Refreshing);
         }
      }

      protected void Load0C47( )
      {
         /* Using cursor T000C33 */
         pr_default.execute(31, new Object[] {A1EmpID, A32categID, A33subCatID, A257detSubID});
         if ( (pr_default.getStatus(31) != 101) )
         {
            RcdFound47 = 1;
            A258detSubDsc = T000C33_A258detSubDsc[0];
            n258detSubDsc = T000C33_n258detSubDsc[0];
            A262detSubAnio = T000C33_A262detSubAnio[0];
            n262detSubAnio = T000C33_n262detSubAnio[0];
            A259detSubFch = T000C33_A259detSubFch[0];
            n259detSubFch = T000C33_n259detSubFch[0];
            A260detSubSldoIni = T000C33_A260detSubSldoIni[0];
            n260detSubSldoIni = T000C33_n260detSubSldoIni[0];
            A261detSubActivo = T000C33_A261detSubActivo[0];
            n261detSubActivo = T000C33_n261detSubActivo[0];
            ZM0C47( -16) ;
         }
         pr_default.close(31);
         OnLoadActions0C47( ) ;
      }

      protected void OnLoadActions0C47( )
      {
      }

      protected void CheckExtendedTable0C47( )
      {
         Gx_BScreen = 1;
         standaloneModal0C47( ) ;
      }

      protected void CloseExtendedTableCursors0C47( )
      {
      }

      protected void enableDisable0C47( )
      {
      }

      protected void GetKey0C47( )
      {
         /* Using cursor T000C34 */
         pr_default.execute(32, new Object[] {A1EmpID, A32categID, A33subCatID, A257detSubID});
         if ( (pr_default.getStatus(32) != 101) )
         {
            RcdFound47 = 1;
         }
         else
         {
            RcdFound47 = 0;
         }
         pr_default.close(32);
      }

      protected void getByPrimaryKey0C47( )
      {
         /* Using cursor T000C3 */
         pr_default.execute(1, new Object[] {A1EmpID, A32categID, A33subCatID, A257detSubID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0C47( 16) ;
            RcdFound47 = 1;
            InitializeNonKey0C47( ) ;
            A257detSubID = T000C3_A257detSubID[0];
            A258detSubDsc = T000C3_A258detSubDsc[0];
            n258detSubDsc = T000C3_n258detSubDsc[0];
            A262detSubAnio = T000C3_A262detSubAnio[0];
            n262detSubAnio = T000C3_n262detSubAnio[0];
            A259detSubFch = T000C3_A259detSubFch[0];
            n259detSubFch = T000C3_n259detSubFch[0];
            A260detSubSldoIni = T000C3_A260detSubSldoIni[0];
            n260detSubSldoIni = T000C3_n260detSubSldoIni[0];
            A261detSubActivo = T000C3_A261detSubActivo[0];
            n261detSubActivo = T000C3_n261detSubActivo[0];
            Z1EmpID = A1EmpID;
            Z32categID = A32categID;
            Z33subCatID = A33subCatID;
            Z257detSubID = A257detSubID;
            sMode47 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0C47( ) ;
            Gx_mode = sMode47;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound47 = 0;
            InitializeNonKey0C47( ) ;
            sMode47 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal0C47( ) ;
            Gx_mode = sMode47;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes0C47( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0C47( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000C2 */
            pr_default.execute(0, new Object[] {A1EmpID, A32categID, A33subCatID, A257detSubID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CategoriassubCatSldos"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z258detSubDsc, T000C2_A258detSubDsc[0]) != 0 ) || ( Z262detSubAnio != T000C2_A262detSubAnio[0] ) || ( Z259detSubFch != T000C2_A259detSubFch[0] ) || ( Z260detSubSldoIni != T000C2_A260detSubSldoIni[0] ) || ( StringUtil.StrCmp(Z261detSubActivo, T000C2_A261detSubActivo[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z258detSubDsc, T000C2_A258detSubDsc[0]) != 0 )
               {
                  GXUtil.WriteLog("categorias:[seudo value changed for attri]"+"detSubDsc");
                  GXUtil.WriteLogRaw("Old: ",Z258detSubDsc);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A258detSubDsc[0]);
               }
               if ( Z262detSubAnio != T000C2_A262detSubAnio[0] )
               {
                  GXUtil.WriteLog("categorias:[seudo value changed for attri]"+"detSubAnio");
                  GXUtil.WriteLogRaw("Old: ",Z262detSubAnio);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A262detSubAnio[0]);
               }
               if ( Z259detSubFch != T000C2_A259detSubFch[0] )
               {
                  GXUtil.WriteLog("categorias:[seudo value changed for attri]"+"detSubFch");
                  GXUtil.WriteLogRaw("Old: ",Z259detSubFch);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A259detSubFch[0]);
               }
               if ( Z260detSubSldoIni != T000C2_A260detSubSldoIni[0] )
               {
                  GXUtil.WriteLog("categorias:[seudo value changed for attri]"+"detSubSldoIni");
                  GXUtil.WriteLogRaw("Old: ",Z260detSubSldoIni);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A260detSubSldoIni[0]);
               }
               if ( StringUtil.StrCmp(Z261detSubActivo, T000C2_A261detSubActivo[0]) != 0 )
               {
                  GXUtil.WriteLog("categorias:[seudo value changed for attri]"+"detSubActivo");
                  GXUtil.WriteLogRaw("Old: ",Z261detSubActivo);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A261detSubActivo[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"CategoriassubCatSldos"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0C47( )
      {
         BeforeValidate0C47( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0C47( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0C47( 0) ;
            CheckOptimisticConcurrency0C47( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0C47( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0C47( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000C35 */
                     pr_default.execute(33, new Object[] {A1EmpID, A32categID, A33subCatID, A257detSubID, n258detSubDsc, A258detSubDsc, n262detSubAnio, A262detSubAnio, n259detSubFch, A259detSubFch, n260detSubSldoIni, A260detSubSldoIni, n261detSubActivo, A261detSubActivo});
                     pr_default.close(33);
                     dsDefault.SmartCacheProvider.SetUpdated("CategoriassubCatSldos") ;
                     if ( (pr_default.getStatus(33) == 1) )
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
               Load0C47( ) ;
            }
            EndLevel0C47( ) ;
         }
         CloseExtendedTableCursors0C47( ) ;
      }

      protected void Update0C47( )
      {
         BeforeValidate0C47( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0C47( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0C47( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0C47( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0C47( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000C36 */
                     pr_default.execute(34, new Object[] {n258detSubDsc, A258detSubDsc, n262detSubAnio, A262detSubAnio, n259detSubFch, A259detSubFch, n260detSubSldoIni, A260detSubSldoIni, n261detSubActivo, A261detSubActivo, A1EmpID, A32categID, A33subCatID, A257detSubID});
                     pr_default.close(34);
                     dsDefault.SmartCacheProvider.SetUpdated("CategoriassubCatSldos") ;
                     if ( (pr_default.getStatus(34) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CategoriassubCatSldos"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0C47( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey0C47( ) ;
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
            EndLevel0C47( ) ;
         }
         CloseExtendedTableCursors0C47( ) ;
      }

      protected void DeferredUpdate0C47( )
      {
      }

      protected void Delete0C47( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate0C47( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0C47( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0C47( ) ;
            AfterConfirm0C47( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0C47( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000C37 */
                  pr_default.execute(35, new Object[] {A1EmpID, A32categID, A33subCatID, A257detSubID});
                  pr_default.close(35);
                  dsDefault.SmartCacheProvider.SetUpdated("CategoriassubCatSldos") ;
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
         sMode47 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0C47( ) ;
         Gx_mode = sMode47;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0C47( )
      {
         standaloneModal0C47( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0C47( )
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

      public void ScanStart0C47( )
      {
         /* Scan By routine */
         /* Using cursor T000C38 */
         pr_default.execute(36, new Object[] {A1EmpID, A32categID, A33subCatID});
         RcdFound47 = 0;
         if ( (pr_default.getStatus(36) != 101) )
         {
            RcdFound47 = 1;
            A257detSubID = T000C38_A257detSubID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0C47( )
      {
         /* Scan next routine */
         pr_default.readNext(36);
         RcdFound47 = 0;
         if ( (pr_default.getStatus(36) != 101) )
         {
            RcdFound47 = 1;
            A257detSubID = T000C38_A257detSubID[0];
         }
      }

      protected void ScanEnd0C47( )
      {
         pr_default.close(36);
      }

      protected void AfterConfirm0C47( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0C47( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0C47( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0C47( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0C47( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0C47( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0C47( )
      {
         edtdetSubID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetSubID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetSubID_Enabled), 5, 0)), !bGXsfl_90_Refreshing);
         edtdetSubDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetSubDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetSubDsc_Enabled), 5, 0)), !bGXsfl_90_Refreshing);
      }

      protected void send_integrity_lvl_hashes0C47( )
      {
      }

      protected void send_integrity_lvl_hashes0C27( )
      {
      }

      protected void send_integrity_lvl_hashes0C26( )
      {
      }

      protected void SubsflControlProps_8127( )
      {
         edtsubCatID_Internalname = "SUBCATID_"+sGXsfl_81_idx;
         edtsubCatDsc_Internalname = "SUBCATDSC_"+sGXsfl_81_idx;
         edtsubCatPrec_Internalname = "SUBCATPREC_"+sGXsfl_81_idx;
         edtsubCatPeso_Internalname = "SUBCATPESO_"+sGXsfl_81_idx;
         edtsubCatDisp_Internalname = "SUBCATDISP_"+sGXsfl_81_idx;
         edtsubCatEst_Internalname = "SUBCATEST_"+sGXsfl_81_idx;
      }

      protected void SubsflControlProps_fel_8127( )
      {
         edtsubCatID_Internalname = "SUBCATID_"+sGXsfl_81_fel_idx;
         edtsubCatDsc_Internalname = "SUBCATDSC_"+sGXsfl_81_fel_idx;
         edtsubCatPrec_Internalname = "SUBCATPREC_"+sGXsfl_81_fel_idx;
         edtsubCatPeso_Internalname = "SUBCATPESO_"+sGXsfl_81_fel_idx;
         edtsubCatDisp_Internalname = "SUBCATDISP_"+sGXsfl_81_fel_idx;
         edtsubCatEst_Internalname = "SUBCATEST_"+sGXsfl_81_fel_idx;
      }

      protected void AddRow0C27( )
      {
         nRC_GXsfl_90 = 0;
         nGXsfl_81_idx = (short)(nGXsfl_81_idx+1);
         sGXsfl_81_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_81_idx), 4, 0)), 4, "0");
         SubsflControlProps_8127( ) ;
         SendRow0C27( ) ;
      }

      protected void SendRow0C27( )
      {
         Gridcategorias_subcatRow = GXWebRow.GetNew(context);
         if ( subGridcategorias_subcat_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridcategorias_subcat_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridcategorias_subcat_Class, "") != 0 )
            {
               subGridcategorias_subcat_Linesclass = subGridcategorias_subcat_Class+"Odd";
            }
         }
         else if ( subGridcategorias_subcat_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridcategorias_subcat_Backstyle = 0;
            subGridcategorias_subcat_Backcolor = subGridcategorias_subcat_Allbackcolor;
            if ( StringUtil.StrCmp(subGridcategorias_subcat_Class, "") != 0 )
            {
               subGridcategorias_subcat_Linesclass = subGridcategorias_subcat_Class+"Uniform";
            }
         }
         else if ( subGridcategorias_subcat_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridcategorias_subcat_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridcategorias_subcat_Class, "") != 0 )
            {
               subGridcategorias_subcat_Linesclass = subGridcategorias_subcat_Class+"Odd";
            }
            subGridcategorias_subcat_Backcolor = (int)(0x0);
         }
         else if ( subGridcategorias_subcat_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridcategorias_subcat_Backstyle = 1;
            if ( ((int)(((nGXsfl_81_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGridcategorias_subcat_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridcategorias_subcat_Class, "") != 0 )
               {
                  subGridcategorias_subcat_Linesclass = subGridcategorias_subcat_Class+"Odd";
               }
            }
            else
            {
               subGridcategorias_subcat_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridcategorias_subcat_Class, "") != 0 )
               {
                  subGridcategorias_subcat_Linesclass = subGridcategorias_subcat_Class+"Even";
               }
            }
         }
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_27_" + sGXsfl_81_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 82,'',false,'" + sGXsfl_81_idx + "',81)\"";
         ROClassString = "Attribute";
         Gridcategorias_subcatRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtsubCatID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A33subCatID), 4, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A33subCatID), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,82);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtsubCatID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtsubCatID_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)81,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_27_" + sGXsfl_81_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 83,'',false,'" + sGXsfl_81_idx + "',81)\"";
         ROClassString = "Attribute";
         Gridcategorias_subcatRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtsubCatDsc_Internalname,StringUtil.RTrim( A148subCatDsc),StringUtil.RTrim( context.localUtil.Format( A148subCatDsc, "@!")),TempTags+" onchange=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,83);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtsubCatDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtsubCatDsc_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)81,(short)1,(short)-1,(short)-1,(bool)true,(String)"nombres",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_27_" + sGXsfl_81_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 84,'',false,'" + sGXsfl_81_idx + "',81)\"";
         ROClassString = "Attribute";
         Gridcategorias_subcatRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtsubCatPrec_Internalname,StringUtil.LTrim( StringUtil.NToC( A150subCatPrec, 8, 2, ",", "")),((edtsubCatPrec_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A150subCatPrec, "ZZZZ9.99")) : context.localUtil.Format( A150subCatPrec, "ZZZZ9.99")),TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,84);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtsubCatPrec_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtsubCatPrec_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)81,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_27_" + sGXsfl_81_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 85,'',false,'" + sGXsfl_81_idx + "',81)\"";
         ROClassString = "Attribute";
         Gridcategorias_subcatRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtsubCatPeso_Internalname,StringUtil.LTrim( StringUtil.NToC( A151subCatPeso, 8, 2, ",", "")),((edtsubCatPeso_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A151subCatPeso, "ZZZZ9.99")) : context.localUtil.Format( A151subCatPeso, "ZZZZ9.99")),TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,85);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtsubCatPeso_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtsubCatPeso_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)81,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_27_" + sGXsfl_81_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 86,'',false,'" + sGXsfl_81_idx + "',81)\"";
         ROClassString = "Attribute";
         Gridcategorias_subcatRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtsubCatDisp_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A211subCatDisp), 8, 0, ",", "")),((edtsubCatDisp_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A211subCatDisp), "ZZZZZZZ9")) : context.localUtil.Format( (decimal)(A211subCatDisp), "ZZZZZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,86);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtsubCatDisp_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtsubCatDisp_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)81,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_27_" + sGXsfl_81_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 87,'',false,'" + sGXsfl_81_idx + "',81)\"";
         ROClassString = "Attribute";
         Gridcategorias_subcatRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtsubCatEst_Internalname,StringUtil.RTrim( A149subCatEst),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,87);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtsubCatEst_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtsubCatEst_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)1,(short)0,(short)0,(short)81,(short)1,(short)-1,(short)-1,(bool)true,(String)"estado",(String)"left",(bool)true});
         context.httpAjaxContext.ajax_sending_grid_row(Gridcategorias_subcatRow);
         send_integrity_lvl_hashes0C27( ) ;
         GXCCtl = "Z33subCatID_" + sGXsfl_81_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z33subCatID), 4, 0, ",", "")));
         GXCCtl = "Z148subCatDsc_" + sGXsfl_81_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z148subCatDsc));
         GXCCtl = "Z150subCatPrec_" + sGXsfl_81_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z150subCatPrec, 8, 2, ",", "")));
         GXCCtl = "Z151subCatPeso_" + sGXsfl_81_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z151subCatPeso, 8, 2, ",", "")));
         GXCCtl = "Z211subCatDisp_" + sGXsfl_81_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z211subCatDisp), 8, 0, ",", "")));
         GXCCtl = "Z149subCatEst_" + sGXsfl_81_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z149subCatEst));
         GXCCtl = "Z363subCatIDPrd_" + sGXsfl_81_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z363subCatIDPrd), 4, 0, ",", "")));
         GXCCtl = "nRC_GXsfl_90_" + sGXsfl_81_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_90_idx), 4, 0, ",", "")));
         GXCCtl = "nRcdDeleted_27_" + sGXsfl_81_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_27), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_27_" + sGXsfl_81_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_27), 4, 0, ",", "")));
         GXCCtl = "nIsMod_27_" + sGXsfl_81_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_27), 4, 0, ",", "")));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_81_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV10TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV10TrnContext);
         }
         GXCCtl = "vEMPID_" + sGXsfl_81_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7EmpID), 4, 0, ",", "")));
         GXCCtl = "vCATEGID_" + sGXsfl_81_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8categID), 4, 0, ",", "")));
         GXCCtl = "DETSUBANIO_" + sGXsfl_81_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(A262detSubAnio), 4, 0, ",", "")));
         GXCCtl = "DETSUBFCH_" + sGXsfl_81_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, context.localUtil.DToC( A259detSubFch, 0, "/"));
         GXCCtl = "DETSUBSLDOINI_" + sGXsfl_81_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( A260detSubSldoIni, 10, 2, ",", "")));
         GXCCtl = "DETSUBACTIVO_" + sGXsfl_81_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( A261detSubActivo));
         GXCCtl = "vMODE_" + sGXsfl_81_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "SUBCATID_"+sGXsfl_81_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatID_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SUBCATDSC_"+sGXsfl_81_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatDsc_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SUBCATPREC_"+sGXsfl_81_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatPrec_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SUBCATPESO_"+sGXsfl_81_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatPeso_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SUBCATDISP_"+sGXsfl_81_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatDisp_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SUBCATEST_"+sGXsfl_81_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatEst_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridcategorias_subcatContainer.AddRow(Gridcategorias_subcatRow);
      }

      protected void ReadRow0C27( )
      {
         nGXsfl_81_idx = (short)(nGXsfl_81_idx+1);
         sGXsfl_81_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_81_idx), 4, 0)), 4, "0");
         SubsflControlProps_8127( ) ;
         edtsubCatID_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATID_"+sGXsfl_81_idx+"Enabled"), ",", "."));
         edtsubCatDsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATDSC_"+sGXsfl_81_idx+"Enabled"), ",", "."));
         edtsubCatPrec_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATPREC_"+sGXsfl_81_idx+"Enabled"), ",", "."));
         edtsubCatPeso_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATPESO_"+sGXsfl_81_idx+"Enabled"), ",", "."));
         edtsubCatDisp_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATDISP_"+sGXsfl_81_idx+"Enabled"), ",", "."));
         edtsubCatEst_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATEST_"+sGXsfl_81_idx+"Enabled"), ",", "."));
         if ( ( ( context.localUtil.CToN( cgiGet( edtsubCatID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtsubCatID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "SUBCATID_" + sGXsfl_81_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtsubCatID_Internalname;
            wbErr = true;
            A33subCatID = 0;
         }
         else
         {
            A33subCatID = (short)(context.localUtil.CToN( cgiGet( edtsubCatID_Internalname), ",", "."));
         }
         A148subCatDsc = StringUtil.Upper( cgiGet( edtsubCatDsc_Internalname));
         n148subCatDsc = false;
         n148subCatDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A148subCatDsc)) ? true : false);
         if ( ( ( context.localUtil.CToN( cgiGet( edtsubCatPrec_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtsubCatPrec_Internalname), ",", ".") > 99999.99m ) ) )
         {
            GXCCtl = "SUBCATPREC_" + sGXsfl_81_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtsubCatPrec_Internalname;
            wbErr = true;
            A150subCatPrec = 0;
            n150subCatPrec = false;
         }
         else
         {
            A150subCatPrec = context.localUtil.CToN( cgiGet( edtsubCatPrec_Internalname), ",", ".");
            n150subCatPrec = false;
         }
         n150subCatPrec = ((Convert.ToDecimal(0)==A150subCatPrec) ? true : false);
         if ( ( ( context.localUtil.CToN( cgiGet( edtsubCatPeso_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtsubCatPeso_Internalname), ",", ".") > 99999.99m ) ) )
         {
            GXCCtl = "SUBCATPESO_" + sGXsfl_81_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtsubCatPeso_Internalname;
            wbErr = true;
            A151subCatPeso = 0;
            n151subCatPeso = false;
         }
         else
         {
            A151subCatPeso = context.localUtil.CToN( cgiGet( edtsubCatPeso_Internalname), ",", ".");
            n151subCatPeso = false;
         }
         n151subCatPeso = ((Convert.ToDecimal(0)==A151subCatPeso) ? true : false);
         if ( ( ( context.localUtil.CToN( cgiGet( edtsubCatDisp_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtsubCatDisp_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
         {
            GXCCtl = "SUBCATDISP_" + sGXsfl_81_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtsubCatDisp_Internalname;
            wbErr = true;
            A211subCatDisp = 0;
            n211subCatDisp = false;
         }
         else
         {
            A211subCatDisp = (int)(context.localUtil.CToN( cgiGet( edtsubCatDisp_Internalname), ",", "."));
            n211subCatDisp = false;
         }
         n211subCatDisp = ((0==A211subCatDisp) ? true : false);
         A149subCatEst = cgiGet( edtsubCatEst_Internalname);
         n149subCatEst = false;
         n149subCatEst = (String.IsNullOrEmpty(StringUtil.RTrim( A149subCatEst)) ? true : false);
         GXCCtl = "Z33subCatID_" + sGXsfl_81_idx;
         Z33subCatID = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z148subCatDsc_" + sGXsfl_81_idx;
         Z148subCatDsc = cgiGet( GXCCtl);
         n148subCatDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A148subCatDsc)) ? true : false);
         GXCCtl = "Z150subCatPrec_" + sGXsfl_81_idx;
         Z150subCatPrec = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n150subCatPrec = ((Convert.ToDecimal(0)==A150subCatPrec) ? true : false);
         GXCCtl = "Z151subCatPeso_" + sGXsfl_81_idx;
         Z151subCatPeso = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n151subCatPeso = ((Convert.ToDecimal(0)==A151subCatPeso) ? true : false);
         GXCCtl = "Z211subCatDisp_" + sGXsfl_81_idx;
         Z211subCatDisp = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         n211subCatDisp = ((0==A211subCatDisp) ? true : false);
         GXCCtl = "Z149subCatEst_" + sGXsfl_81_idx;
         Z149subCatEst = cgiGet( GXCCtl);
         n149subCatEst = (String.IsNullOrEmpty(StringUtil.RTrim( A149subCatEst)) ? true : false);
         GXCCtl = "Z363subCatIDPrd_" + sGXsfl_81_idx;
         Z363subCatIDPrd = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         n363subCatIDPrd = ((0==A363subCatIDPrd) ? true : false);
         GXCCtl = "Z363subCatIDPrd_" + sGXsfl_81_idx;
         A363subCatIDPrd = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         n363subCatIDPrd = false;
         n363subCatIDPrd = ((0==A363subCatIDPrd) ? true : false);
         GXCCtl = "nRC_GXsfl_90_" + sGXsfl_81_idx;
         nRC_GXsfl_90 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdDeleted_27_" + sGXsfl_81_idx;
         nRcdDeleted_27 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_27_" + sGXsfl_81_idx;
         nRcdExists_27 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_27_" + sGXsfl_81_idx;
         nIsMod_27 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "DETSUBANIO_" + sGXsfl_81_idx;
         A262detSubAnio = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         n262detSubAnio = ((0==A262detSubAnio) ? true : false);
         GXCCtl = "DETSUBFCH_" + sGXsfl_81_idx;
         A259detSubFch = context.localUtil.CToD( cgiGet( GXCCtl), 0);
         n259detSubFch = ((DateTime.MinValue==A259detSubFch) ? true : false);
         GXCCtl = "DETSUBSLDOINI_" + sGXsfl_81_idx;
         A260detSubSldoIni = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n260detSubSldoIni = ((Convert.ToDecimal(0)==A260detSubSldoIni) ? true : false);
         GXCCtl = "DETSUBACTIVO_" + sGXsfl_81_idx;
         A261detSubActivo = cgiGet( GXCCtl);
         n261detSubActivo = (String.IsNullOrEmpty(StringUtil.RTrim( A261detSubActivo)) ? true : false);
         GXCCtl = "nRC_GXsfl_90_" + sGXsfl_81_idx;
         nRC_GXsfl_90 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void SubsflControlProps_9047( )
      {
         edtdetSubID_Internalname = "DETSUBID_"+sGXsfl_90_idx;
         edtdetSubDsc_Internalname = "DETSUBDSC_"+sGXsfl_90_idx;
      }

      protected void SubsflControlProps_fel_9047( )
      {
         edtdetSubID_Internalname = "DETSUBID_"+sGXsfl_90_fel_idx;
         edtdetSubDsc_Internalname = "DETSUBDSC_"+sGXsfl_90_fel_idx;
      }

      protected void AddRow0C47( )
      {
         nGXsfl_90_idx = (short)(nGXsfl_90_idx+1);
         sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx), 4, 0)), 4, "0") + sGXsfl_81_idx;
         SubsflControlProps_9047( ) ;
         SendRow0C47( ) ;
      }

      protected void SendRow0C47( )
      {
         Grid1Row = GXWebRow.GetNew(context);
         if ( subGrid1_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGrid1_Backstyle = 0;
            if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
            {
               subGrid1_Linesclass = subGrid1_Class+"Odd";
            }
         }
         else if ( subGrid1_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGrid1_Backstyle = 0;
            subGrid1_Backcolor = subGrid1_Allbackcolor;
            if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
            {
               subGrid1_Linesclass = subGrid1_Class+"Uniform";
            }
         }
         else if ( subGrid1_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGrid1_Backstyle = 1;
            if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
            {
               subGrid1_Linesclass = subGrid1_Class+"Odd";
            }
            subGrid1_Backcolor = (int)(0x0);
         }
         else if ( subGrid1_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGrid1_Backstyle = 1;
            if ( ((int)(((nGXsfl_90_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGrid1_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd";
               }
            }
            else
            {
               subGrid1_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Even";
               }
            }
         }
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_47_" + sGXsfl_90_idx + "',1);gx.fn.setControlValue('nIsMod_27_" + sGXsfl_81_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 91,'',false,'" + sGXsfl_90_idx + "',90)\"";
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtdetSubID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A257detSubID), 4, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A257detSubID), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,91);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtdetSubID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtdetSubID_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)90,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_47_" + sGXsfl_90_idx + "',1);gx.fn.setControlValue('nIsMod_27_" + sGXsfl_81_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 92,'',false,'" + sGXsfl_90_idx + "',90)\"";
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtdetSubDsc_Internalname,(String)A258detSubDsc,(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,92);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtdetSubDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtdetSubDsc_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)90,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         context.httpAjaxContext.ajax_sending_grid_row(Grid1Row);
         send_integrity_lvl_hashes0C47( ) ;
         GXCCtl = "Z257detSubID_" + sGXsfl_90_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z257detSubID), 4, 0, ",", "")));
         GXCCtl = "Z258detSubDsc_" + sGXsfl_90_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, Z258detSubDsc);
         GXCCtl = "Z262detSubAnio_" + sGXsfl_90_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z262detSubAnio), 4, 0, ",", "")));
         GXCCtl = "Z259detSubFch_" + sGXsfl_90_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, context.localUtil.DToC( Z259detSubFch, 0, "/"));
         GXCCtl = "Z260detSubSldoIni_" + sGXsfl_90_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z260detSubSldoIni, 10, 2, ",", "")));
         GXCCtl = "Z261detSubActivo_" + sGXsfl_90_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z261detSubActivo));
         GXCCtl = "nRcdDeleted_47_" + sGXsfl_90_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_47), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_47_" + sGXsfl_90_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_47), 4, 0, ",", "")));
         GXCCtl = "nIsMod_47_" + sGXsfl_90_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_47), 4, 0, ",", "")));
         GXCCtl = "vMODE_" + sGXsfl_90_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_90_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV10TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV10TrnContext);
         }
         GXCCtl = "vEMPID_" + sGXsfl_90_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7EmpID), 4, 0, ",", "")));
         GXCCtl = "vCATEGID_" + sGXsfl_90_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8categID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "DETSUBID_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetSubID_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DETSUBDSC_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetSubDsc_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Grid1Container.AddRow(Grid1Row);
      }

      protected void ReadRow0C47( )
      {
         nGXsfl_90_idx = (short)(nGXsfl_90_idx+1);
         sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx), 4, 0)), 4, "0") + sGXsfl_81_idx;
         SubsflControlProps_9047( ) ;
         edtdetSubID_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETSUBID_"+sGXsfl_90_idx+"Enabled"), ",", "."));
         edtdetSubDsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETSUBDSC_"+sGXsfl_90_idx+"Enabled"), ",", "."));
         if ( ( ( context.localUtil.CToN( cgiGet( edtdetSubID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtdetSubID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "DETSUBID_" + sGXsfl_90_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtdetSubID_Internalname;
            wbErr = true;
            A257detSubID = 0;
         }
         else
         {
            A257detSubID = (short)(context.localUtil.CToN( cgiGet( edtdetSubID_Internalname), ",", "."));
         }
         A258detSubDsc = cgiGet( edtdetSubDsc_Internalname);
         n258detSubDsc = false;
         n258detSubDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A258detSubDsc)) ? true : false);
         GXCCtl = "Z257detSubID_" + sGXsfl_90_idx;
         Z257detSubID = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z258detSubDsc_" + sGXsfl_90_idx;
         Z258detSubDsc = cgiGet( GXCCtl);
         n258detSubDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A258detSubDsc)) ? true : false);
         GXCCtl = "Z262detSubAnio_" + sGXsfl_90_idx;
         Z262detSubAnio = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         n262detSubAnio = ((0==A262detSubAnio) ? true : false);
         GXCCtl = "Z259detSubFch_" + sGXsfl_90_idx;
         Z259detSubFch = context.localUtil.CToD( cgiGet( GXCCtl), 0);
         n259detSubFch = ((DateTime.MinValue==A259detSubFch) ? true : false);
         GXCCtl = "Z260detSubSldoIni_" + sGXsfl_90_idx;
         Z260detSubSldoIni = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n260detSubSldoIni = ((Convert.ToDecimal(0)==A260detSubSldoIni) ? true : false);
         GXCCtl = "Z261detSubActivo_" + sGXsfl_90_idx;
         Z261detSubActivo = cgiGet( GXCCtl);
         n261detSubActivo = (String.IsNullOrEmpty(StringUtil.RTrim( A261detSubActivo)) ? true : false);
         GXCCtl = "Z262detSubAnio_" + sGXsfl_90_idx;
         A262detSubAnio = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         n262detSubAnio = false;
         n262detSubAnio = ((0==A262detSubAnio) ? true : false);
         GXCCtl = "Z259detSubFch_" + sGXsfl_90_idx;
         A259detSubFch = context.localUtil.CToD( cgiGet( GXCCtl), 0);
         n259detSubFch = false;
         n259detSubFch = ((DateTime.MinValue==A259detSubFch) ? true : false);
         GXCCtl = "Z260detSubSldoIni_" + sGXsfl_90_idx;
         A260detSubSldoIni = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n260detSubSldoIni = false;
         n260detSubSldoIni = ((Convert.ToDecimal(0)==A260detSubSldoIni) ? true : false);
         GXCCtl = "Z261detSubActivo_" + sGXsfl_90_idx;
         A261detSubActivo = cgiGet( GXCCtl);
         n261detSubActivo = false;
         n261detSubActivo = (String.IsNullOrEmpty(StringUtil.RTrim( A261detSubActivo)) ? true : false);
         GXCCtl = "nRcdDeleted_47_" + sGXsfl_90_idx;
         nRcdDeleted_47 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_47_" + sGXsfl_90_idx;
         nRcdExists_47 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_47_" + sGXsfl_90_idx;
         nIsMod_47 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void assign_properties_default( )
      {
         defedtdetSubID_Enabled = edtdetSubID_Enabled;
         defedtsubCatID_Enabled = edtsubCatID_Enabled;
      }

      protected void ConfirmValues0C0( )
      {
         nGXsfl_81_idx = 0;
         sGXsfl_81_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_81_idx), 4, 0)), 4, "0");
         SubsflControlProps_8127( ) ;
         while ( nGXsfl_81_idx < nRC_GXsfl_81 )
         {
            nGXsfl_81_idx = (short)(nGXsfl_81_idx+1);
            sGXsfl_81_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_81_idx), 4, 0)), 4, "0");
            SubsflControlProps_8127( ) ;
            ChangePostValue( "Z33subCatID_"+sGXsfl_81_idx, cgiGet( "ZT_"+"Z33subCatID_"+sGXsfl_81_idx)) ;
            DeletePostValue( "ZT_"+"Z33subCatID_"+sGXsfl_81_idx) ;
            ChangePostValue( "Z148subCatDsc_"+sGXsfl_81_idx, cgiGet( "ZT_"+"Z148subCatDsc_"+sGXsfl_81_idx)) ;
            DeletePostValue( "ZT_"+"Z148subCatDsc_"+sGXsfl_81_idx) ;
            ChangePostValue( "Z150subCatPrec_"+sGXsfl_81_idx, cgiGet( "ZT_"+"Z150subCatPrec_"+sGXsfl_81_idx)) ;
            DeletePostValue( "ZT_"+"Z150subCatPrec_"+sGXsfl_81_idx) ;
            ChangePostValue( "Z151subCatPeso_"+sGXsfl_81_idx, cgiGet( "ZT_"+"Z151subCatPeso_"+sGXsfl_81_idx)) ;
            DeletePostValue( "ZT_"+"Z151subCatPeso_"+sGXsfl_81_idx) ;
            ChangePostValue( "Z211subCatDisp_"+sGXsfl_81_idx, cgiGet( "ZT_"+"Z211subCatDisp_"+sGXsfl_81_idx)) ;
            DeletePostValue( "ZT_"+"Z211subCatDisp_"+sGXsfl_81_idx) ;
            ChangePostValue( "Z149subCatEst_"+sGXsfl_81_idx, cgiGet( "ZT_"+"Z149subCatEst_"+sGXsfl_81_idx)) ;
            DeletePostValue( "ZT_"+"Z149subCatEst_"+sGXsfl_81_idx) ;
            ChangePostValue( "Z363subCatIDPrd_"+sGXsfl_81_idx, cgiGet( "ZT_"+"Z363subCatIDPrd_"+sGXsfl_81_idx)) ;
            DeletePostValue( "ZT_"+"Z363subCatIDPrd_"+sGXsfl_81_idx) ;
         }
         nGXsfl_90_idx = 0;
         sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx), 4, 0)), 4, "0") + sGXsfl_81_idx;
         SubsflControlProps_9047( ) ;
         while ( nGXsfl_90_idx < nRC_GXsfl_90 )
         {
            nGXsfl_90_idx = (short)(nGXsfl_90_idx+1);
            sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx), 4, 0)), 4, "0") + sGXsfl_81_idx;
            SubsflControlProps_9047( ) ;
            ChangePostValue( "Z257detSubID_"+sGXsfl_90_idx, cgiGet( "ZT_"+"Z257detSubID_"+sGXsfl_90_idx)) ;
            DeletePostValue( "ZT_"+"Z257detSubID_"+sGXsfl_90_idx) ;
            ChangePostValue( "Z258detSubDsc_"+sGXsfl_90_idx, cgiGet( "ZT_"+"Z258detSubDsc_"+sGXsfl_90_idx)) ;
            DeletePostValue( "ZT_"+"Z258detSubDsc_"+sGXsfl_90_idx) ;
            ChangePostValue( "Z262detSubAnio_"+sGXsfl_90_idx, cgiGet( "ZT_"+"Z262detSubAnio_"+sGXsfl_90_idx)) ;
            DeletePostValue( "ZT_"+"Z262detSubAnio_"+sGXsfl_90_idx) ;
            ChangePostValue( "Z259detSubFch_"+sGXsfl_90_idx, cgiGet( "ZT_"+"Z259detSubFch_"+sGXsfl_90_idx)) ;
            DeletePostValue( "ZT_"+"Z259detSubFch_"+sGXsfl_90_idx) ;
            ChangePostValue( "Z260detSubSldoIni_"+sGXsfl_90_idx, cgiGet( "ZT_"+"Z260detSubSldoIni_"+sGXsfl_90_idx)) ;
            DeletePostValue( "ZT_"+"Z260detSubSldoIni_"+sGXsfl_90_idx) ;
            ChangePostValue( "Z261detSubActivo_"+sGXsfl_90_idx, cgiGet( "ZT_"+"Z261detSubActivo_"+sGXsfl_90_idx)) ;
            DeletePostValue( "ZT_"+"Z261detSubActivo_"+sGXsfl_90_idx) ;
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
         context.SendWebValue( "Categorias") ;
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
         context.AddJavascriptSource("gxcfg.js", "?202211192253413", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("categorias.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7EmpID) + "," + UrlEncode("" +AV8categID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "Categorias";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV12Insert_tipoProdID), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("categorias:[SendSecurityCheck value for]"+"Insert_tipoProdID:"+context.localUtil.Format( (decimal)(AV12Insert_tipoProdID), "ZZZ9"));
         GXUtil.WriteLog("categorias:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1EmpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z32categID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z32categID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z146categDsc", StringUtil.RTrim( Z146categDsc));
         GxWebStd.gx_hidden_field( context, "Z147categEst", StringUtil.RTrim( Z147categEst));
         GxWebStd.gx_hidden_field( context, "Z31tipoProdID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z31tipoProdID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_81", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_81_idx), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "N31tipoProdID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A31tipoProdID), 4, 0, ",", "")));
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
         GxWebStd.gx_hidden_field( context, "vCATEGID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8categID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vCATEGID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8categID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_TIPOPRODID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12Insert_tipoProdID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV18Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "SUBCATIDPRD", StringUtil.LTrim( StringUtil.NToC( (decimal)(A363subCatIDPrd), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "PRDTS_Objectcall", StringUtil.RTrim( Prdts_Objectcall));
         GxWebStd.gx_hidden_field( context, "PRDTS_Enabled", StringUtil.BoolToStr( Prdts_Enabled));
         GxWebStd.gx_hidden_field( context, "PRDTS_Class", StringUtil.RTrim( Prdts_Class));
         GxWebStd.gx_hidden_field( context, "PRDTS_Pagecount", StringUtil.LTrim( StringUtil.NToC( (decimal)(Prdts_Pagecount), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PRDTS_Historymanagement", StringUtil.BoolToStr( Prdts_Historymanagement));
      }

      protected void RenderHtmlCloseForm0C26( )
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
         return "Categorias" ;
      }

      public override String GetPgmdesc( )
      {
         return "Categorias" ;
      }

      protected void InitializeNonKey0C26( )
      {
         A31tipoProdID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A31tipoProdID), 4, 0)));
         A44empdsc = "";
         n44empdsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         A146categDsc = "";
         n146categDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A146categDsc", A146categDsc);
         n146categDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A146categDsc)) ? true : false);
         A144tipoProdDsc = "";
         n144tipoProdDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144tipoProdDsc", A144tipoProdDsc);
         A147categEst = "";
         n147categEst = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A147categEst", A147categEst);
         n147categEst = (String.IsNullOrEmpty(StringUtil.RTrim( A147categEst)) ? true : false);
         Z146categDsc = "";
         Z147categEst = "";
         Z31tipoProdID = 0;
      }

      protected void InitAll0C26( )
      {
         A1EmpID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         A32categID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32categID", StringUtil.LTrim( StringUtil.Str( (decimal)(A32categID), 4, 0)));
         InitializeNonKey0C26( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey0C27( )
      {
         A148subCatDsc = "";
         n148subCatDsc = false;
         A150subCatPrec = 0;
         n150subCatPrec = false;
         A151subCatPeso = 0;
         n151subCatPeso = false;
         A211subCatDisp = 0;
         n211subCatDisp = false;
         A149subCatEst = "";
         n149subCatEst = false;
         A363subCatIDPrd = 0;
         n363subCatIDPrd = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A363subCatIDPrd", StringUtil.LTrim( StringUtil.Str( (decimal)(A363subCatIDPrd), 4, 0)));
         Z148subCatDsc = "";
         Z150subCatPrec = 0;
         Z151subCatPeso = 0;
         Z211subCatDisp = 0;
         Z149subCatEst = "";
         Z363subCatIDPrd = 0;
      }

      protected void InitAll0C27( )
      {
         A33subCatID = 0;
         InitializeNonKey0C27( ) ;
      }

      protected void StandaloneModalInsert0C27( )
      {
      }

      protected void InitializeNonKey0C47( )
      {
         A258detSubDsc = "";
         n258detSubDsc = false;
         A262detSubAnio = 0;
         n262detSubAnio = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A262detSubAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A262detSubAnio), 4, 0)));
         A259detSubFch = DateTime.MinValue;
         n259detSubFch = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259detSubFch", context.localUtil.Format(A259detSubFch, "99/99/9999"));
         A260detSubSldoIni = 0;
         n260detSubSldoIni = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260detSubSldoIni", StringUtil.LTrim( StringUtil.Str( A260detSubSldoIni, 10, 2)));
         A261detSubActivo = "";
         n261detSubActivo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A261detSubActivo", A261detSubActivo);
         Z258detSubDsc = "";
         Z262detSubAnio = 0;
         Z259detSubFch = DateTime.MinValue;
         Z260detSubSldoIni = 0;
         Z261detSubActivo = "";
      }

      protected void InitAll0C47( )
      {
         A257detSubID = 0;
         InitializeNonKey0C47( ) ;
      }

      protected void StandaloneModalInsert0C47( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022111922534161", true);
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
         context.AddJavascriptSource("categorias.js", "?2022111922534162", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false);
         context.AddJavascriptSource("Tab/TabRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_level_properties27( )
      {
         edtsubCatID_Enabled = defedtsubCatID_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatID_Enabled), 5, 0)), !bGXsfl_81_Refreshing);
      }

      protected void init_level_properties47( )
      {
         edtdetSubID_Enabled = defedtdetSubID_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetSubID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetSubID_Enabled), 5, 0)), !bGXsfl_90_Refreshing);
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
         edtcategID_Internalname = "CATEGID";
         edtcategDsc_Internalname = "CATEGDSC";
         edttipoProdID_Internalname = "TIPOPRODID";
         edttipoProdDsc_Internalname = "TIPOPRODDSC";
         chkcategEst_Internalname = "CATEGEST";
         lblTabprodcts_title_Internalname = "TABPRODCTS_TITLE";
         lblTitlesubcat_Internalname = "TITLESUBCAT";
         edtsubCatID_Internalname = "SUBCATID";
         edtsubCatDsc_Internalname = "SUBCATDSC";
         edtsubCatPrec_Internalname = "SUBCATPREC";
         edtsubCatPeso_Internalname = "SUBCATPESO";
         edtsubCatDisp_Internalname = "SUBCATDISP";
         edtsubCatEst_Internalname = "SUBCATEST";
         divSubcattable_Internalname = "SUBCATTABLE";
         divTabpage1table_Internalname = "TABPAGE1TABLE";
         Prdts_Internalname = "PRDTS";
         divFormcontainer_Internalname = "FORMCONTAINER";
         edtdetSubID_Internalname = "DETSUBID";
         edtdetSubDsc_Internalname = "DETSUBDSC";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_1_Internalname = "PROMPT_1";
         imgprompt_31_Internalname = "PROMPT_31";
         subGridcategorias_subcat_Internalname = "GRIDCATEGORIAS_SUBCAT";
         subGrid1_Internalname = "GRID1";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         Prdts_Historymanagement = Convert.ToBoolean( 0);
         Prdts_Pagecount = 1;
         Prdts_Class = "Tab";
         edtdetSubDsc_Jsonclick = "";
         edtdetSubID_Jsonclick = "";
         subGrid1_Class = "Grid";
         subGrid1_Backcolorstyle = 0;
         edtsubCatEst_Jsonclick = "";
         edtsubCatDisp_Jsonclick = "";
         edtsubCatPeso_Jsonclick = "";
         edtsubCatPrec_Jsonclick = "";
         edtsubCatDsc_Jsonclick = "";
         edtsubCatID_Jsonclick = "";
         subGridcategorias_subcat_Class = "Grid";
         subGridcategorias_subcat_Backcolorstyle = 0;
         subGrid1_Visible = 1;
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtdetSubDsc_Enabled = 1;
         edtdetSubID_Enabled = 1;
         subGrid1_Header = "";
         subGridcategorias_subcat_Allowcollapsing = 0;
         subGridcategorias_subcat_Allowselection = 0;
         edtsubCatEst_Enabled = 1;
         edtsubCatDisp_Enabled = 1;
         edtsubCatPeso_Enabled = 1;
         edtsubCatPrec_Enabled = 1;
         edtsubCatDsc_Enabled = 1;
         edtsubCatID_Enabled = 1;
         subGridcategorias_subcat_Header = "";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         chkcategEst.Enabled = 1;
         edttipoProdDsc_Jsonclick = "";
         edttipoProdDsc_Enabled = 0;
         imgprompt_31_Visible = 1;
         imgprompt_31_Link = "";
         edttipoProdID_Jsonclick = "";
         edttipoProdID_Enabled = 1;
         edtcategDsc_Jsonclick = "";
         edtcategDsc_Enabled = 1;
         edtcategID_Jsonclick = "";
         edtcategID_Enabled = 1;
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

      protected void gxnrGridcategorias_subcat_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_8127( ) ;
         while ( nGXsfl_81_idx <= nRC_GXsfl_81 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0C27( ) ;
            standaloneModal0C27( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow0C27( ) ;
            Gridcategorias_subcatRow.AddGrid("Grid1", Grid1Container);
            nGXsfl_81_idx = (short)(nGXsfl_81_idx+1);
            sGXsfl_81_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_81_idx), 4, 0)), 4, "0");
            SubsflControlProps_8127( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Gridcategorias_subcatContainer));
         /* End function gxnrGridcategorias_subcat_newrow */
      }

      protected void gxnrGrid1_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_9047( ) ;
         while ( nGXsfl_90_idx <= nRC_GXsfl_90 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0C27( ) ;
            standaloneModal0C27( ) ;
            standaloneNotModal0C47( ) ;
            standaloneModal0C47( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow0C47( ) ;
            nGXsfl_90_idx = (short)(nGXsfl_90_idx+1);
            sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx), 4, 0)), 4, "0") + sGXsfl_81_idx;
            SubsflControlProps_9047( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Grid1Container));
         /* End function gxnrGrid1_newrow */
      }

      protected void init_web_controls( )
      {
         chkcategEst.Name = "CATEGEST";
         chkcategEst.WebTags = "";
         chkcategEst.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkcategEst_Internalname, "TitleCaption", chkcategEst.Caption, true);
         chkcategEst.CheckedValue = "I";
         /* End function init_web_controls */
      }

      public void Valid_Empid( short GX_Parm1 ,
                               String GX_Parm2 )
      {
         A1EmpID = GX_Parm1;
         A44empdsc = GX_Parm2;
         n44empdsc = false;
         /* Using cursor T000C19 */
         pr_default.execute(17, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(17) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A44empdsc = T000C19_A44empdsc[0];
         n44empdsc = T000C19_n44empdsc[0];
         pr_default.close(17);
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

      public void Valid_Tipoprodid( short GX_Parm1 ,
                                    short GX_Parm2 ,
                                    String GX_Parm3 )
      {
         A1EmpID = GX_Parm1;
         A31tipoProdID = GX_Parm2;
         A144tipoProdDsc = GX_Parm3;
         n144tipoProdDsc = false;
         /* Using cursor T000C20 */
         pr_default.execute(18, new Object[] {A1EmpID, A31tipoProdID});
         if ( (pr_default.getStatus(18) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Producto'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A144tipoProdDsc = T000C20_A144tipoProdDsc[0];
         n144tipoProdDsc = T000C20_n144tipoProdDsc[0];
         pr_default.close(18);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A144tipoProdDsc = "";
            n144tipoProdDsc = false;
         }
         isValidOutput.Add(StringUtil.RTrim( A144tipoProdDsc));
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV8categID',fld:'vCATEGID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV8categID',fld:'vCATEGID',pic:'ZZZ9',hsh:true},{av:'AV12Insert_tipoProdID',fld:'vINSERT_TIPOPRODID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120C2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV10TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(5);
         pr_default.close(17);
         pr_default.close(18);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z146categDsc = "";
         Z147categEst = "";
         Z148subCatDsc = "";
         Z149subCatEst = "";
         Z258detSubDsc = "";
         Z259detSubFch = DateTime.MinValue;
         Z261detSubActivo = "";
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
         A146categDsc = "";
         A144tipoProdDsc = "";
         A147categEst = "";
         lblTabprodcts_title_Jsonclick = "";
         lblTitlesubcat_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridcategorias_subcatContainer = new GXWebGrid( context);
         Gridcategorias_subcatColumn = new GXWebColumn();
         A148subCatDsc = "";
         A149subCatEst = "";
         sMode27 = "";
         sStyleString = "";
         Grid1Container = new GXWebGrid( context);
         Grid1Column = new GXWebColumn();
         A258detSubDsc = "";
         sMode47 = "";
         AV18Pgmname = "";
         Prdts_Objectcall = "";
         Prdts_Activepagecontrolname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode26 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         AV10TrnContext = new SdtTransactionContext(context);
         AV11WebSession = context.GetSession();
         AV13TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z44empdsc = "";
         Z144tipoProdDsc = "";
         T000C8_A44empdsc = new String[] {""} ;
         T000C8_n44empdsc = new bool[] {false} ;
         T000C9_A144tipoProdDsc = new String[] {""} ;
         T000C9_n144tipoProdDsc = new bool[] {false} ;
         T000C10_A32categID = new short[1] ;
         T000C10_A44empdsc = new String[] {""} ;
         T000C10_n44empdsc = new bool[] {false} ;
         T000C10_A146categDsc = new String[] {""} ;
         T000C10_n146categDsc = new bool[] {false} ;
         T000C10_A144tipoProdDsc = new String[] {""} ;
         T000C10_n144tipoProdDsc = new bool[] {false} ;
         T000C10_A147categEst = new String[] {""} ;
         T000C10_n147categEst = new bool[] {false} ;
         T000C10_A1EmpID = new short[1] ;
         T000C10_A31tipoProdID = new short[1] ;
         T000C11_A44empdsc = new String[] {""} ;
         T000C11_n44empdsc = new bool[] {false} ;
         T000C12_A144tipoProdDsc = new String[] {""} ;
         T000C12_n144tipoProdDsc = new bool[] {false} ;
         T000C13_A1EmpID = new short[1] ;
         T000C13_A32categID = new short[1] ;
         T000C7_A32categID = new short[1] ;
         T000C7_A146categDsc = new String[] {""} ;
         T000C7_n146categDsc = new bool[] {false} ;
         T000C7_A147categEst = new String[] {""} ;
         T000C7_n147categEst = new bool[] {false} ;
         T000C7_A1EmpID = new short[1] ;
         T000C7_A31tipoProdID = new short[1] ;
         T000C14_A1EmpID = new short[1] ;
         T000C14_A32categID = new short[1] ;
         T000C15_A1EmpID = new short[1] ;
         T000C15_A32categID = new short[1] ;
         T000C6_A32categID = new short[1] ;
         T000C6_A146categDsc = new String[] {""} ;
         T000C6_n146categDsc = new bool[] {false} ;
         T000C6_A147categEst = new String[] {""} ;
         T000C6_n147categEst = new bool[] {false} ;
         T000C6_A1EmpID = new short[1] ;
         T000C6_A31tipoProdID = new short[1] ;
         T000C19_A44empdsc = new String[] {""} ;
         T000C19_n44empdsc = new bool[] {false} ;
         T000C20_A144tipoProdDsc = new String[] {""} ;
         T000C20_n144tipoProdDsc = new bool[] {false} ;
         T000C21_A1EmpID = new short[1] ;
         T000C21_A32categID = new short[1] ;
         T000C21_A33subCatID = new short[1] ;
         T000C22_A1EmpID = new short[1] ;
         T000C22_A32categID = new short[1] ;
         T000C23_A1EmpID = new short[1] ;
         T000C23_A32categID = new short[1] ;
         T000C23_A33subCatID = new short[1] ;
         T000C23_A148subCatDsc = new String[] {""} ;
         T000C23_n148subCatDsc = new bool[] {false} ;
         T000C23_A150subCatPrec = new decimal[1] ;
         T000C23_n150subCatPrec = new bool[] {false} ;
         T000C23_A151subCatPeso = new decimal[1] ;
         T000C23_n151subCatPeso = new bool[] {false} ;
         T000C23_A211subCatDisp = new int[1] ;
         T000C23_n211subCatDisp = new bool[] {false} ;
         T000C23_A149subCatEst = new String[] {""} ;
         T000C23_n149subCatEst = new bool[] {false} ;
         T000C23_A363subCatIDPrd = new short[1] ;
         T000C23_n363subCatIDPrd = new bool[] {false} ;
         T000C24_A1EmpID = new short[1] ;
         T000C24_A32categID = new short[1] ;
         T000C24_A33subCatID = new short[1] ;
         T000C5_A1EmpID = new short[1] ;
         T000C5_A32categID = new short[1] ;
         T000C5_A33subCatID = new short[1] ;
         T000C5_A148subCatDsc = new String[] {""} ;
         T000C5_n148subCatDsc = new bool[] {false} ;
         T000C5_A150subCatPrec = new decimal[1] ;
         T000C5_n150subCatPrec = new bool[] {false} ;
         T000C5_A151subCatPeso = new decimal[1] ;
         T000C5_n151subCatPeso = new bool[] {false} ;
         T000C5_A211subCatDisp = new int[1] ;
         T000C5_n211subCatDisp = new bool[] {false} ;
         T000C5_A149subCatEst = new String[] {""} ;
         T000C5_n149subCatEst = new bool[] {false} ;
         T000C5_A363subCatIDPrd = new short[1] ;
         T000C5_n363subCatIDPrd = new bool[] {false} ;
         T000C4_A1EmpID = new short[1] ;
         T000C4_A32categID = new short[1] ;
         T000C4_A33subCatID = new short[1] ;
         T000C4_A148subCatDsc = new String[] {""} ;
         T000C4_n148subCatDsc = new bool[] {false} ;
         T000C4_A150subCatPrec = new decimal[1] ;
         T000C4_n150subCatPrec = new bool[] {false} ;
         T000C4_A151subCatPeso = new decimal[1] ;
         T000C4_n151subCatPeso = new bool[] {false} ;
         T000C4_A211subCatDisp = new int[1] ;
         T000C4_n211subCatDisp = new bool[] {false} ;
         T000C4_A149subCatEst = new String[] {""} ;
         T000C4_n149subCatEst = new bool[] {false} ;
         T000C4_A363subCatIDPrd = new short[1] ;
         T000C4_n363subCatIDPrd = new bool[] {false} ;
         T000C28_A1EmpID = new short[1] ;
         T000C28_A227HistAnio = new short[1] ;
         T000C28_A228HistPeriodo = new short[1] ;
         T000C28_A36detTipoProdID = new short[1] ;
         T000C28_A32categID = new short[1] ;
         T000C28_A33subCatID = new short[1] ;
         T000C29_A1EmpID = new short[1] ;
         T000C29_A39PedCod = new int[1] ;
         T000C29_A40OPIdSec = new int[1] ;
         T000C30_A1EmpID = new short[1] ;
         T000C30_A34CotiID = new short[1] ;
         T000C30_A35secID = new short[1] ;
         T000C31_A1EmpID = new short[1] ;
         T000C31_A5ClienteID = new short[1] ;
         T000C31_A24OrdenPeriodo = new short[1] ;
         T000C31_A25OrdenAnio = new short[1] ;
         T000C31_A22OrdenID = new short[1] ;
         T000C31_A41OrdenSecId = new short[1] ;
         T000C32_A1EmpID = new short[1] ;
         T000C32_A32categID = new short[1] ;
         T000C32_A33subCatID = new short[1] ;
         A259detSubFch = DateTime.MinValue;
         A261detSubActivo = "";
         T000C33_A1EmpID = new short[1] ;
         T000C33_A32categID = new short[1] ;
         T000C33_A33subCatID = new short[1] ;
         T000C33_A257detSubID = new short[1] ;
         T000C33_A258detSubDsc = new String[] {""} ;
         T000C33_n258detSubDsc = new bool[] {false} ;
         T000C33_A262detSubAnio = new short[1] ;
         T000C33_n262detSubAnio = new bool[] {false} ;
         T000C33_A259detSubFch = new DateTime[] {DateTime.MinValue} ;
         T000C33_n259detSubFch = new bool[] {false} ;
         T000C33_A260detSubSldoIni = new decimal[1] ;
         T000C33_n260detSubSldoIni = new bool[] {false} ;
         T000C33_A261detSubActivo = new String[] {""} ;
         T000C33_n261detSubActivo = new bool[] {false} ;
         T000C34_A1EmpID = new short[1] ;
         T000C34_A32categID = new short[1] ;
         T000C34_A33subCatID = new short[1] ;
         T000C34_A257detSubID = new short[1] ;
         T000C3_A1EmpID = new short[1] ;
         T000C3_A32categID = new short[1] ;
         T000C3_A33subCatID = new short[1] ;
         T000C3_A257detSubID = new short[1] ;
         T000C3_A258detSubDsc = new String[] {""} ;
         T000C3_n258detSubDsc = new bool[] {false} ;
         T000C3_A262detSubAnio = new short[1] ;
         T000C3_n262detSubAnio = new bool[] {false} ;
         T000C3_A259detSubFch = new DateTime[] {DateTime.MinValue} ;
         T000C3_n259detSubFch = new bool[] {false} ;
         T000C3_A260detSubSldoIni = new decimal[1] ;
         T000C3_n260detSubSldoIni = new bool[] {false} ;
         T000C3_A261detSubActivo = new String[] {""} ;
         T000C3_n261detSubActivo = new bool[] {false} ;
         T000C2_A1EmpID = new short[1] ;
         T000C2_A32categID = new short[1] ;
         T000C2_A33subCatID = new short[1] ;
         T000C2_A257detSubID = new short[1] ;
         T000C2_A258detSubDsc = new String[] {""} ;
         T000C2_n258detSubDsc = new bool[] {false} ;
         T000C2_A262detSubAnio = new short[1] ;
         T000C2_n262detSubAnio = new bool[] {false} ;
         T000C2_A259detSubFch = new DateTime[] {DateTime.MinValue} ;
         T000C2_n259detSubFch = new bool[] {false} ;
         T000C2_A260detSubSldoIni = new decimal[1] ;
         T000C2_n260detSubSldoIni = new bool[] {false} ;
         T000C2_A261detSubActivo = new String[] {""} ;
         T000C2_n261detSubActivo = new bool[] {false} ;
         T000C38_A1EmpID = new short[1] ;
         T000C38_A32categID = new short[1] ;
         T000C38_A33subCatID = new short[1] ;
         T000C38_A257detSubID = new short[1] ;
         Gridcategorias_subcatRow = new GXWebRow();
         subGridcategorias_subcat_Linesclass = "";
         ROClassString = "";
         Grid1Row = new GXWebRow();
         subGrid1_Linesclass = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.categorias__default(),
            new Object[][] {
                new Object[] {
               T000C2_A1EmpID, T000C2_A32categID, T000C2_A33subCatID, T000C2_A257detSubID, T000C2_A258detSubDsc, T000C2_n258detSubDsc, T000C2_A262detSubAnio, T000C2_n262detSubAnio, T000C2_A259detSubFch, T000C2_n259detSubFch,
               T000C2_A260detSubSldoIni, T000C2_n260detSubSldoIni, T000C2_A261detSubActivo, T000C2_n261detSubActivo
               }
               , new Object[] {
               T000C3_A1EmpID, T000C3_A32categID, T000C3_A33subCatID, T000C3_A257detSubID, T000C3_A258detSubDsc, T000C3_n258detSubDsc, T000C3_A262detSubAnio, T000C3_n262detSubAnio, T000C3_A259detSubFch, T000C3_n259detSubFch,
               T000C3_A260detSubSldoIni, T000C3_n260detSubSldoIni, T000C3_A261detSubActivo, T000C3_n261detSubActivo
               }
               , new Object[] {
               T000C4_A1EmpID, T000C4_A32categID, T000C4_A33subCatID, T000C4_A148subCatDsc, T000C4_n148subCatDsc, T000C4_A150subCatPrec, T000C4_n150subCatPrec, T000C4_A151subCatPeso, T000C4_n151subCatPeso, T000C4_A211subCatDisp,
               T000C4_n211subCatDisp, T000C4_A149subCatEst, T000C4_n149subCatEst, T000C4_A363subCatIDPrd, T000C4_n363subCatIDPrd
               }
               , new Object[] {
               T000C5_A1EmpID, T000C5_A32categID, T000C5_A33subCatID, T000C5_A148subCatDsc, T000C5_n148subCatDsc, T000C5_A150subCatPrec, T000C5_n150subCatPrec, T000C5_A151subCatPeso, T000C5_n151subCatPeso, T000C5_A211subCatDisp,
               T000C5_n211subCatDisp, T000C5_A149subCatEst, T000C5_n149subCatEst, T000C5_A363subCatIDPrd, T000C5_n363subCatIDPrd
               }
               , new Object[] {
               T000C6_A32categID, T000C6_A146categDsc, T000C6_n146categDsc, T000C6_A147categEst, T000C6_n147categEst, T000C6_A1EmpID, T000C6_A31tipoProdID
               }
               , new Object[] {
               T000C7_A32categID, T000C7_A146categDsc, T000C7_n146categDsc, T000C7_A147categEst, T000C7_n147categEst, T000C7_A1EmpID, T000C7_A31tipoProdID
               }
               , new Object[] {
               T000C8_A44empdsc, T000C8_n44empdsc
               }
               , new Object[] {
               T000C9_A144tipoProdDsc, T000C9_n144tipoProdDsc
               }
               , new Object[] {
               T000C10_A32categID, T000C10_A44empdsc, T000C10_n44empdsc, T000C10_A146categDsc, T000C10_n146categDsc, T000C10_A144tipoProdDsc, T000C10_n144tipoProdDsc, T000C10_A147categEst, T000C10_n147categEst, T000C10_A1EmpID,
               T000C10_A31tipoProdID
               }
               , new Object[] {
               T000C11_A44empdsc, T000C11_n44empdsc
               }
               , new Object[] {
               T000C12_A144tipoProdDsc, T000C12_n144tipoProdDsc
               }
               , new Object[] {
               T000C13_A1EmpID, T000C13_A32categID
               }
               , new Object[] {
               T000C14_A1EmpID, T000C14_A32categID
               }
               , new Object[] {
               T000C15_A1EmpID, T000C15_A32categID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000C19_A44empdsc, T000C19_n44empdsc
               }
               , new Object[] {
               T000C20_A144tipoProdDsc, T000C20_n144tipoProdDsc
               }
               , new Object[] {
               T000C21_A1EmpID, T000C21_A32categID, T000C21_A33subCatID
               }
               , new Object[] {
               T000C22_A1EmpID, T000C22_A32categID
               }
               , new Object[] {
               T000C23_A1EmpID, T000C23_A32categID, T000C23_A33subCatID, T000C23_A148subCatDsc, T000C23_n148subCatDsc, T000C23_A150subCatPrec, T000C23_n150subCatPrec, T000C23_A151subCatPeso, T000C23_n151subCatPeso, T000C23_A211subCatDisp,
               T000C23_n211subCatDisp, T000C23_A149subCatEst, T000C23_n149subCatEst, T000C23_A363subCatIDPrd, T000C23_n363subCatIDPrd
               }
               , new Object[] {
               T000C24_A1EmpID, T000C24_A32categID, T000C24_A33subCatID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000C28_A1EmpID, T000C28_A227HistAnio, T000C28_A228HistPeriodo, T000C28_A36detTipoProdID, T000C28_A32categID, T000C28_A33subCatID
               }
               , new Object[] {
               T000C29_A1EmpID, T000C29_A39PedCod, T000C29_A40OPIdSec
               }
               , new Object[] {
               T000C30_A1EmpID, T000C30_A34CotiID, T000C30_A35secID
               }
               , new Object[] {
               T000C31_A1EmpID, T000C31_A5ClienteID, T000C31_A24OrdenPeriodo, T000C31_A25OrdenAnio, T000C31_A22OrdenID, T000C31_A41OrdenSecId
               }
               , new Object[] {
               T000C32_A1EmpID, T000C32_A32categID, T000C32_A33subCatID
               }
               , new Object[] {
               T000C33_A1EmpID, T000C33_A32categID, T000C33_A33subCatID, T000C33_A257detSubID, T000C33_A258detSubDsc, T000C33_n258detSubDsc, T000C33_A262detSubAnio, T000C33_n262detSubAnio, T000C33_A259detSubFch, T000C33_n259detSubFch,
               T000C33_A260detSubSldoIni, T000C33_n260detSubSldoIni, T000C33_A261detSubActivo, T000C33_n261detSubActivo
               }
               , new Object[] {
               T000C34_A1EmpID, T000C34_A32categID, T000C34_A33subCatID, T000C34_A257detSubID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000C38_A1EmpID, T000C38_A32categID, T000C38_A33subCatID, T000C38_A257detSubID
               }
            }
         );
         AV18Pgmname = "Categorias";
      }

      private short wcpOAV7EmpID ;
      private short wcpOAV8categID ;
      private short Z1EmpID ;
      private short Z32categID ;
      private short Z31tipoProdID ;
      private short nRC_GXsfl_81 ;
      private short nGXsfl_81_idx=1 ;
      private short N31tipoProdID ;
      private short Z33subCatID ;
      private short Z363subCatIDPrd ;
      private short nRC_GXsfl_90 ;
      private short nGXsfl_90_idx=1 ;
      private short nRcdDeleted_27 ;
      private short nRcdExists_27 ;
      private short nIsMod_27 ;
      private short Z257detSubID ;
      private short Z262detSubAnio ;
      private short nRcdDeleted_47 ;
      private short nRcdExists_47 ;
      private short nIsMod_47 ;
      private short GxWebError ;
      private short A1EmpID ;
      private short A31tipoProdID ;
      private short AV7EmpID ;
      private short AV8categID ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short A32categID ;
      private short subGridcategorias_subcat_Backcolorstyle ;
      private short A33subCatID ;
      private short subGridcategorias_subcat_Allowselection ;
      private short subGridcategorias_subcat_Allowhovering ;
      private short subGridcategorias_subcat_Allowcollapsing ;
      private short subGridcategorias_subcat_Collapsed ;
      private short nBlankRcdCount27 ;
      private short RcdFound27 ;
      private short nBlankRcdUsr27 ;
      private short subGrid1_Backcolorstyle ;
      private short A257detSubID ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nBlankRcdCount47 ;
      private short RcdFound47 ;
      private short nBlankRcdUsr47 ;
      private short AV12Insert_tipoProdID ;
      private short A363subCatIDPrd ;
      private short RcdFound26 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short A262detSubAnio ;
      private short subGridcategorias_subcat_Backstyle ;
      private short subGrid1_Backstyle ;
      private short wbTemp ;
      private int Z211subCatDisp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtEmpID_Enabled ;
      private int imgprompt_1_Visible ;
      private int edtempdsc_Enabled ;
      private int edtcategID_Enabled ;
      private int edtcategDsc_Enabled ;
      private int edttipoProdID_Enabled ;
      private int imgprompt_31_Visible ;
      private int edttipoProdDsc_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtsubCatID_Enabled ;
      private int edtsubCatDsc_Enabled ;
      private int edtsubCatPrec_Enabled ;
      private int edtsubCatPeso_Enabled ;
      private int A211subCatDisp ;
      private int edtsubCatDisp_Enabled ;
      private int edtsubCatEst_Enabled ;
      private int subGridcategorias_subcat_Selectedindex ;
      private int subGridcategorias_subcat_Selectioncolor ;
      private int subGridcategorias_subcat_Hoveringcolor ;
      private int fRowAdded ;
      private int subGrid1_Visible ;
      private int edtdetSubID_Enabled ;
      private int edtdetSubDsc_Enabled ;
      private int subGrid1_Selectedindex ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int Prdts_Activepage ;
      private int Prdts_Pagecount ;
      private int AV19GXV1 ;
      private int subGridcategorias_subcat_Backcolor ;
      private int subGridcategorias_subcat_Allbackcolor ;
      private int subGrid1_Backcolor ;
      private int subGrid1_Allbackcolor ;
      private int defedtdetSubID_Enabled ;
      private int defedtsubCatID_Enabled ;
      private int idxLst ;
      private long GRIDCATEGORIAS_SUBCAT_nFirstRecordOnPage ;
      private long GRID1_nFirstRecordOnPage ;
      private decimal Z150subCatPrec ;
      private decimal Z151subCatPeso ;
      private decimal Z260detSubSldoIni ;
      private decimal A150subCatPrec ;
      private decimal A151subCatPeso ;
      private decimal A260detSubSldoIni ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z146categDsc ;
      private String Z147categEst ;
      private String Z148subCatDsc ;
      private String Z149subCatEst ;
      private String Z261detSubActivo ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_81_idx="0001" ;
      private String Gx_mode ;
      private String sGXsfl_90_idx="0001" ;
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
      private String edtcategID_Internalname ;
      private String edtcategID_Jsonclick ;
      private String edtcategDsc_Internalname ;
      private String A146categDsc ;
      private String edtcategDsc_Jsonclick ;
      private String edttipoProdID_Internalname ;
      private String edttipoProdID_Jsonclick ;
      private String imgprompt_31_Internalname ;
      private String imgprompt_31_Link ;
      private String edttipoProdDsc_Internalname ;
      private String A144tipoProdDsc ;
      private String edttipoProdDsc_Jsonclick ;
      private String chkcategEst_Internalname ;
      private String A147categEst ;
      private String lblTabprodcts_title_Internalname ;
      private String lblTabprodcts_title_Jsonclick ;
      private String divTabpage1table_Internalname ;
      private String divSubcattable_Internalname ;
      private String lblTitlesubcat_Internalname ;
      private String lblTitlesubcat_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridcategorias_subcat_Header ;
      private String A148subCatDsc ;
      private String A149subCatEst ;
      private String sMode27 ;
      private String edtsubCatID_Internalname ;
      private String edtsubCatDsc_Internalname ;
      private String edtsubCatPrec_Internalname ;
      private String edtsubCatPeso_Internalname ;
      private String edtsubCatDisp_Internalname ;
      private String edtsubCatEst_Internalname ;
      private String sStyleString ;
      private String subGrid1_Header ;
      private String sMode47 ;
      private String edtdetSubID_Internalname ;
      private String edtdetSubDsc_Internalname ;
      private String AV18Pgmname ;
      private String Prdts_Objectcall ;
      private String Prdts_Class ;
      private String Prdts_Activepagecontrolname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode26 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String Z144tipoProdDsc ;
      private String A261detSubActivo ;
      private String sGXsfl_81_fel_idx="0001" ;
      private String subGridcategorias_subcat_Class ;
      private String subGridcategorias_subcat_Linesclass ;
      private String ROClassString ;
      private String edtsubCatID_Jsonclick ;
      private String edtsubCatDsc_Jsonclick ;
      private String edtsubCatPrec_Jsonclick ;
      private String edtsubCatPeso_Jsonclick ;
      private String edtsubCatDisp_Jsonclick ;
      private String edtsubCatEst_Jsonclick ;
      private String sGXsfl_90_fel_idx="0001" ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String edtdetSubID_Jsonclick ;
      private String edtdetSubDsc_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String Prdts_Internalname ;
      private String subGridcategorias_subcat_Internalname ;
      private String subGrid1_Internalname ;
      private DateTime Z259detSubFch ;
      private DateTime A259detSubFch ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool bGXsfl_81_Refreshing=false ;
      private bool bGXsfl_90_Refreshing=false ;
      private bool n44empdsc ;
      private bool n146categDsc ;
      private bool n144tipoProdDsc ;
      private bool n147categEst ;
      private bool n363subCatIDPrd ;
      private bool Prdts_Enabled ;
      private bool Prdts_Historymanagement ;
      private bool Prdts_Visible ;
      private bool returnInSub ;
      private bool n148subCatDsc ;
      private bool n150subCatPrec ;
      private bool n151subCatPeso ;
      private bool n211subCatDisp ;
      private bool n149subCatEst ;
      private bool Gx_longc ;
      private bool n258detSubDsc ;
      private bool n262detSubAnio ;
      private bool n259detSubFch ;
      private bool n260detSubSldoIni ;
      private bool n261detSubActivo ;
      private String Z258detSubDsc ;
      private String A44empdsc ;
      private String A258detSubDsc ;
      private String Z44empdsc ;
      private IGxSession AV11WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebGrid Gridcategorias_subcatContainer ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Gridcategorias_subcatRow ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Gridcategorias_subcatColumn ;
      private GXWebColumn Grid1Column ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCheckbox chkcategEst ;
      private IDataStoreProvider pr_default ;
      private String[] T000C8_A44empdsc ;
      private bool[] T000C8_n44empdsc ;
      private String[] T000C9_A144tipoProdDsc ;
      private bool[] T000C9_n144tipoProdDsc ;
      private short[] T000C10_A32categID ;
      private String[] T000C10_A44empdsc ;
      private bool[] T000C10_n44empdsc ;
      private String[] T000C10_A146categDsc ;
      private bool[] T000C10_n146categDsc ;
      private String[] T000C10_A144tipoProdDsc ;
      private bool[] T000C10_n144tipoProdDsc ;
      private String[] T000C10_A147categEst ;
      private bool[] T000C10_n147categEst ;
      private short[] T000C10_A1EmpID ;
      private short[] T000C10_A31tipoProdID ;
      private String[] T000C11_A44empdsc ;
      private bool[] T000C11_n44empdsc ;
      private String[] T000C12_A144tipoProdDsc ;
      private bool[] T000C12_n144tipoProdDsc ;
      private short[] T000C13_A1EmpID ;
      private short[] T000C13_A32categID ;
      private short[] T000C7_A32categID ;
      private String[] T000C7_A146categDsc ;
      private bool[] T000C7_n146categDsc ;
      private String[] T000C7_A147categEst ;
      private bool[] T000C7_n147categEst ;
      private short[] T000C7_A1EmpID ;
      private short[] T000C7_A31tipoProdID ;
      private short[] T000C14_A1EmpID ;
      private short[] T000C14_A32categID ;
      private short[] T000C15_A1EmpID ;
      private short[] T000C15_A32categID ;
      private short[] T000C6_A32categID ;
      private String[] T000C6_A146categDsc ;
      private bool[] T000C6_n146categDsc ;
      private String[] T000C6_A147categEst ;
      private bool[] T000C6_n147categEst ;
      private short[] T000C6_A1EmpID ;
      private short[] T000C6_A31tipoProdID ;
      private String[] T000C19_A44empdsc ;
      private bool[] T000C19_n44empdsc ;
      private String[] T000C20_A144tipoProdDsc ;
      private bool[] T000C20_n144tipoProdDsc ;
      private short[] T000C21_A1EmpID ;
      private short[] T000C21_A32categID ;
      private short[] T000C21_A33subCatID ;
      private short[] T000C22_A1EmpID ;
      private short[] T000C22_A32categID ;
      private short[] T000C23_A1EmpID ;
      private short[] T000C23_A32categID ;
      private short[] T000C23_A33subCatID ;
      private String[] T000C23_A148subCatDsc ;
      private bool[] T000C23_n148subCatDsc ;
      private decimal[] T000C23_A150subCatPrec ;
      private bool[] T000C23_n150subCatPrec ;
      private decimal[] T000C23_A151subCatPeso ;
      private bool[] T000C23_n151subCatPeso ;
      private int[] T000C23_A211subCatDisp ;
      private bool[] T000C23_n211subCatDisp ;
      private String[] T000C23_A149subCatEst ;
      private bool[] T000C23_n149subCatEst ;
      private short[] T000C23_A363subCatIDPrd ;
      private bool[] T000C23_n363subCatIDPrd ;
      private short[] T000C24_A1EmpID ;
      private short[] T000C24_A32categID ;
      private short[] T000C24_A33subCatID ;
      private short[] T000C5_A1EmpID ;
      private short[] T000C5_A32categID ;
      private short[] T000C5_A33subCatID ;
      private String[] T000C5_A148subCatDsc ;
      private bool[] T000C5_n148subCatDsc ;
      private decimal[] T000C5_A150subCatPrec ;
      private bool[] T000C5_n150subCatPrec ;
      private decimal[] T000C5_A151subCatPeso ;
      private bool[] T000C5_n151subCatPeso ;
      private int[] T000C5_A211subCatDisp ;
      private bool[] T000C5_n211subCatDisp ;
      private String[] T000C5_A149subCatEst ;
      private bool[] T000C5_n149subCatEst ;
      private short[] T000C5_A363subCatIDPrd ;
      private bool[] T000C5_n363subCatIDPrd ;
      private short[] T000C4_A1EmpID ;
      private short[] T000C4_A32categID ;
      private short[] T000C4_A33subCatID ;
      private String[] T000C4_A148subCatDsc ;
      private bool[] T000C4_n148subCatDsc ;
      private decimal[] T000C4_A150subCatPrec ;
      private bool[] T000C4_n150subCatPrec ;
      private decimal[] T000C4_A151subCatPeso ;
      private bool[] T000C4_n151subCatPeso ;
      private int[] T000C4_A211subCatDisp ;
      private bool[] T000C4_n211subCatDisp ;
      private String[] T000C4_A149subCatEst ;
      private bool[] T000C4_n149subCatEst ;
      private short[] T000C4_A363subCatIDPrd ;
      private bool[] T000C4_n363subCatIDPrd ;
      private short[] T000C28_A1EmpID ;
      private short[] T000C28_A227HistAnio ;
      private short[] T000C28_A228HistPeriodo ;
      private short[] T000C28_A36detTipoProdID ;
      private short[] T000C28_A32categID ;
      private short[] T000C28_A33subCatID ;
      private short[] T000C29_A1EmpID ;
      private int[] T000C29_A39PedCod ;
      private int[] T000C29_A40OPIdSec ;
      private short[] T000C30_A1EmpID ;
      private short[] T000C30_A34CotiID ;
      private short[] T000C30_A35secID ;
      private short[] T000C31_A1EmpID ;
      private short[] T000C31_A5ClienteID ;
      private short[] T000C31_A24OrdenPeriodo ;
      private short[] T000C31_A25OrdenAnio ;
      private short[] T000C31_A22OrdenID ;
      private short[] T000C31_A41OrdenSecId ;
      private short[] T000C32_A1EmpID ;
      private short[] T000C32_A32categID ;
      private short[] T000C32_A33subCatID ;
      private short[] T000C33_A1EmpID ;
      private short[] T000C33_A32categID ;
      private short[] T000C33_A33subCatID ;
      private short[] T000C33_A257detSubID ;
      private String[] T000C33_A258detSubDsc ;
      private bool[] T000C33_n258detSubDsc ;
      private short[] T000C33_A262detSubAnio ;
      private bool[] T000C33_n262detSubAnio ;
      private DateTime[] T000C33_A259detSubFch ;
      private bool[] T000C33_n259detSubFch ;
      private decimal[] T000C33_A260detSubSldoIni ;
      private bool[] T000C33_n260detSubSldoIni ;
      private String[] T000C33_A261detSubActivo ;
      private bool[] T000C33_n261detSubActivo ;
      private short[] T000C34_A1EmpID ;
      private short[] T000C34_A32categID ;
      private short[] T000C34_A33subCatID ;
      private short[] T000C34_A257detSubID ;
      private short[] T000C3_A1EmpID ;
      private short[] T000C3_A32categID ;
      private short[] T000C3_A33subCatID ;
      private short[] T000C3_A257detSubID ;
      private String[] T000C3_A258detSubDsc ;
      private bool[] T000C3_n258detSubDsc ;
      private short[] T000C3_A262detSubAnio ;
      private bool[] T000C3_n262detSubAnio ;
      private DateTime[] T000C3_A259detSubFch ;
      private bool[] T000C3_n259detSubFch ;
      private decimal[] T000C3_A260detSubSldoIni ;
      private bool[] T000C3_n260detSubSldoIni ;
      private String[] T000C3_A261detSubActivo ;
      private bool[] T000C3_n261detSubActivo ;
      private short[] T000C2_A1EmpID ;
      private short[] T000C2_A32categID ;
      private short[] T000C2_A33subCatID ;
      private short[] T000C2_A257detSubID ;
      private String[] T000C2_A258detSubDsc ;
      private bool[] T000C2_n258detSubDsc ;
      private short[] T000C2_A262detSubAnio ;
      private bool[] T000C2_n262detSubAnio ;
      private DateTime[] T000C2_A259detSubFch ;
      private bool[] T000C2_n259detSubFch ;
      private decimal[] T000C2_A260detSubSldoIni ;
      private bool[] T000C2_n260detSubSldoIni ;
      private String[] T000C2_A261detSubActivo ;
      private bool[] T000C2_n261detSubActivo ;
      private short[] T000C38_A1EmpID ;
      private short[] T000C38_A32categID ;
      private short[] T000C38_A33subCatID ;
      private short[] T000C38_A257detSubID ;
      private SdtTransactionContext AV10TrnContext ;
      private SdtTransactionContext_Attribute AV13TrnContextAtt ;
   }

   public class categorias__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new UpdateCursor(def[14])
         ,new UpdateCursor(def[15])
         ,new UpdateCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new ForEachCursor(def[22])
         ,new UpdateCursor(def[23])
         ,new UpdateCursor(def[24])
         ,new UpdateCursor(def[25])
         ,new ForEachCursor(def[26])
         ,new ForEachCursor(def[27])
         ,new ForEachCursor(def[28])
         ,new ForEachCursor(def[29])
         ,new ForEachCursor(def[30])
         ,new ForEachCursor(def[31])
         ,new ForEachCursor(def[32])
         ,new UpdateCursor(def[33])
         ,new UpdateCursor(def[34])
         ,new UpdateCursor(def[35])
         ,new ForEachCursor(def[36])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000C10 ;
          prmT000C10 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C8 ;
          prmT000C8 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C9 ;
          prmT000C9 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C11 ;
          prmT000C11 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C12 ;
          prmT000C12 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C13 ;
          prmT000C13 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C7 ;
          prmT000C7 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C14 ;
          prmT000C14 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C15 ;
          prmT000C15 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C6 ;
          prmT000C6 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C16 ;
          prmT000C16 = new Object[] {
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categDsc",SqlDbType.Char,40,0} ,
          new Object[] {"@categEst",SqlDbType.Char,1,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C17 ;
          prmT000C17 = new Object[] {
          new Object[] {"@categDsc",SqlDbType.Char,40,0} ,
          new Object[] {"@categEst",SqlDbType.Char,1,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C18 ;
          prmT000C18 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C21 ;
          prmT000C21 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C22 ;
          prmT000C22 = new Object[] {
          } ;
          Object[] prmT000C23 ;
          prmT000C23 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C24 ;
          prmT000C24 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C5 ;
          prmT000C5 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C4 ;
          prmT000C4 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C25 ;
          prmT000C25 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatDsc",SqlDbType.Char,40,0} ,
          new Object[] {"@subCatPrec",SqlDbType.Decimal,8,2} ,
          new Object[] {"@subCatPeso",SqlDbType.Decimal,8,2} ,
          new Object[] {"@subCatDisp",SqlDbType.Int,8,0} ,
          new Object[] {"@subCatEst",SqlDbType.Char,1,0} ,
          new Object[] {"@subCatIDPrd",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C26 ;
          prmT000C26 = new Object[] {
          new Object[] {"@subCatDsc",SqlDbType.Char,40,0} ,
          new Object[] {"@subCatPrec",SqlDbType.Decimal,8,2} ,
          new Object[] {"@subCatPeso",SqlDbType.Decimal,8,2} ,
          new Object[] {"@subCatDisp",SqlDbType.Int,8,0} ,
          new Object[] {"@subCatEst",SqlDbType.Char,1,0} ,
          new Object[] {"@subCatIDPrd",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C27 ;
          prmT000C27 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C28 ;
          prmT000C28 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C29 ;
          prmT000C29 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C30 ;
          prmT000C30 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C31 ;
          prmT000C31 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C32 ;
          prmT000C32 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C33 ;
          prmT000C33 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detSubID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C34 ;
          prmT000C34 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detSubID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C3 ;
          prmT000C3 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detSubID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C2 ;
          prmT000C2 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detSubID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C35 ;
          prmT000C35 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detSubID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detSubDsc",SqlDbType.VarChar,50,0} ,
          new Object[] {"@detSubAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detSubFch",SqlDbType.DateTime,8,0} ,
          new Object[] {"@detSubSldoIni",SqlDbType.Decimal,10,2} ,
          new Object[] {"@detSubActivo",SqlDbType.Char,1,0}
          } ;
          Object[] prmT000C36 ;
          prmT000C36 = new Object[] {
          new Object[] {"@detSubDsc",SqlDbType.VarChar,50,0} ,
          new Object[] {"@detSubAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detSubFch",SqlDbType.DateTime,8,0} ,
          new Object[] {"@detSubSldoIni",SqlDbType.Decimal,10,2} ,
          new Object[] {"@detSubActivo",SqlDbType.Char,1,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detSubID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C37 ;
          prmT000C37 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detSubID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C38 ;
          prmT000C38 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C19 ;
          prmT000C19 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000C20 ;
          prmT000C20 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000C2", "SELECT [EmpID], [categID], [subCatID], [detSubID], [detSubDsc], [detSubAnio], [detSubFch], [detSubSldoIni], [detSubActivo] FROM [CategoriassubCatSldos] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID AND [subCatID] = @subCatID AND [detSubID] = @detSubID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C2,1,0,true,false )
             ,new CursorDef("T000C3", "SELECT [EmpID], [categID], [subCatID], [detSubID], [detSubDsc], [detSubAnio], [detSubFch], [detSubSldoIni], [detSubActivo] FROM [CategoriassubCatSldos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID AND [subCatID] = @subCatID AND [detSubID] = @detSubID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C3,1,0,true,false )
             ,new CursorDef("T000C4", "SELECT [EmpID], [categID], [subCatID], [subCatDsc], [subCatPrec], [subCatPeso], [subCatDisp], [subCatEst], [subCatIDPrd] FROM [CategoriassubCat] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID AND [subCatID] = @subCatID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C4,1,0,true,false )
             ,new CursorDef("T000C5", "SELECT [EmpID], [categID], [subCatID], [subCatDsc], [subCatPrec], [subCatPeso], [subCatDisp], [subCatEst], [subCatIDPrd] FROM [CategoriassubCat] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID AND [subCatID] = @subCatID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C5,1,0,true,false )
             ,new CursorDef("T000C6", "SELECT [categID], [categDsc], [categEst], [EmpID], [tipoProdID] FROM [Categorias] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C6,1,0,true,false )
             ,new CursorDef("T000C7", "SELECT [categID], [categDsc], [categEst], [EmpID], [tipoProdID] FROM [Categorias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C7,1,0,true,false )
             ,new CursorDef("T000C8", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C8,1,0,true,false )
             ,new CursorDef("T000C9", "SELECT [tipoProdDsc] FROM [TipoProducto] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [tipoProdID] = @tipoProdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C9,1,0,true,false )
             ,new CursorDef("T000C10", "SELECT TM1.[categID], T2.[empdsc], TM1.[categDsc], T3.[tipoProdDsc], TM1.[categEst], TM1.[EmpID], TM1.[tipoProdID] FROM (([Categorias] TM1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = TM1.[EmpID]) INNER JOIN [TipoProducto] T3 WITH (NOLOCK) ON T3.[EmpID] = TM1.[EmpID] AND T3.[tipoProdID] = TM1.[tipoProdID]) WHERE TM1.[EmpID] = @EmpID and TM1.[categID] = @categID ORDER BY TM1.[EmpID], TM1.[categID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000C10,100,0,true,false )
             ,new CursorDef("T000C11", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C11,1,0,true,false )
             ,new CursorDef("T000C12", "SELECT [tipoProdDsc] FROM [TipoProducto] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [tipoProdID] = @tipoProdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C12,1,0,true,false )
             ,new CursorDef("T000C13", "SELECT [EmpID], [categID] FROM [Categorias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000C13,1,0,true,false )
             ,new CursorDef("T000C14", "SELECT TOP 1 [EmpID], [categID] FROM [Categorias] WITH (NOLOCK) WHERE ( [EmpID] > @EmpID or [EmpID] = @EmpID and [categID] > @categID) ORDER BY [EmpID], [categID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000C14,1,0,true,true )
             ,new CursorDef("T000C15", "SELECT TOP 1 [EmpID], [categID] FROM [Categorias] WITH (NOLOCK) WHERE ( [EmpID] < @EmpID or [EmpID] = @EmpID and [categID] < @categID) ORDER BY [EmpID] DESC, [categID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000C15,1,0,true,true )
             ,new CursorDef("T000C16", "INSERT INTO [Categorias]([categID], [categDsc], [categEst], [EmpID], [tipoProdID]) VALUES(@categID, @categDsc, @categEst, @EmpID, @tipoProdID)", GxErrorMask.GX_NOMASK,prmT000C16)
             ,new CursorDef("T000C17", "UPDATE [Categorias] SET [categDsc]=@categDsc, [categEst]=@categEst, [tipoProdID]=@tipoProdID  WHERE [EmpID] = @EmpID AND [categID] = @categID", GxErrorMask.GX_NOMASK,prmT000C17)
             ,new CursorDef("T000C18", "DELETE FROM [Categorias]  WHERE [EmpID] = @EmpID AND [categID] = @categID", GxErrorMask.GX_NOMASK,prmT000C18)
             ,new CursorDef("T000C19", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C19,1,0,true,false )
             ,new CursorDef("T000C20", "SELECT [tipoProdDsc] FROM [TipoProducto] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [tipoProdID] = @tipoProdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C20,1,0,true,false )
             ,new CursorDef("T000C21", "SELECT TOP 1 [EmpID], [categID], [subCatID] FROM [CategoriassubCat] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C21,1,0,true,true )
             ,new CursorDef("T000C22", "SELECT [EmpID], [categID] FROM [Categorias] WITH (NOLOCK) ORDER BY [EmpID], [categID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000C22,100,0,true,false )
             ,new CursorDef("T000C23", "SELECT [EmpID], [categID], [subCatID], [subCatDsc], [subCatPrec], [subCatPeso], [subCatDisp], [subCatEst], [subCatIDPrd] FROM [CategoriassubCat] WITH (NOLOCK) WHERE [EmpID] = @EmpID and [categID] = @categID and [subCatID] = @subCatID ORDER BY [EmpID], [categID], [subCatID] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C23,11,0,true,false )
             ,new CursorDef("T000C24", "SELECT [EmpID], [categID], [subCatID] FROM [CategoriassubCat] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID AND [subCatID] = @subCatID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C24,1,0,true,false )
             ,new CursorDef("T000C25", "INSERT INTO [CategoriassubCat]([EmpID], [categID], [subCatID], [subCatDsc], [subCatPrec], [subCatPeso], [subCatDisp], [subCatEst], [subCatIDPrd]) VALUES(@EmpID, @categID, @subCatID, @subCatDsc, @subCatPrec, @subCatPeso, @subCatDisp, @subCatEst, @subCatIDPrd)", GxErrorMask.GX_NOMASK,prmT000C25)
             ,new CursorDef("T000C26", "UPDATE [CategoriassubCat] SET [subCatDsc]=@subCatDsc, [subCatPrec]=@subCatPrec, [subCatPeso]=@subCatPeso, [subCatDisp]=@subCatDisp, [subCatEst]=@subCatEst, [subCatIDPrd]=@subCatIDPrd  WHERE [EmpID] = @EmpID AND [categID] = @categID AND [subCatID] = @subCatID", GxErrorMask.GX_NOMASK,prmT000C26)
             ,new CursorDef("T000C27", "DELETE FROM [CategoriassubCat]  WHERE [EmpID] = @EmpID AND [categID] = @categID AND [subCatID] = @subCatID", GxErrorMask.GX_NOMASK,prmT000C27)
             ,new CursorDef("T000C28", "SELECT TOP 1 [EmpID], [HistAnio], [HistPeriodo], [detTipoProdID], [categID], [subCatID] FROM [HistPrecioProd] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID AND [subCatID] = @subCatID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C28,1,0,true,true )
             ,new CursorDef("T000C29", "SELECT TOP 1 [EmpID], [PedCod], [OPIdSec] FROM [OrdenPedidoOPId] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID AND [subCatID] = @subCatID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C29,1,0,true,true )
             ,new CursorDef("T000C30", "SELECT TOP 1 [EmpID], [CotiID], [secID] FROM [CotizadorLevel1] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID AND [subCatID] = @subCatID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C30,1,0,true,true )
             ,new CursorDef("T000C31", "SELECT TOP 1 [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID], [OrdenSecId] FROM [OrdenProduccionOpItems] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID AND [subCatID] = @subCatID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C31,1,0,true,true )
             ,new CursorDef("T000C32", "SELECT [EmpID], [categID], [subCatID] FROM [CategoriassubCat] WITH (NOLOCK) WHERE [EmpID] = @EmpID and [categID] = @categID ORDER BY [EmpID], [categID], [subCatID] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C32,11,0,true,false )
             ,new CursorDef("T000C33", "SELECT [EmpID], [categID], [subCatID], [detSubID], [detSubDsc], [detSubAnio], [detSubFch], [detSubSldoIni], [detSubActivo] FROM [CategoriassubCatSldos] WITH (NOLOCK) WHERE [EmpID] = @EmpID and [categID] = @categID and [subCatID] = @subCatID and [detSubID] = @detSubID ORDER BY [EmpID], [categID], [subCatID], [detSubID] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C33,11,0,true,false )
             ,new CursorDef("T000C34", "SELECT [EmpID], [categID], [subCatID], [detSubID] FROM [CategoriassubCatSldos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID AND [subCatID] = @subCatID AND [detSubID] = @detSubID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C34,1,0,true,false )
             ,new CursorDef("T000C35", "INSERT INTO [CategoriassubCatSldos]([EmpID], [categID], [subCatID], [detSubID], [detSubDsc], [detSubAnio], [detSubFch], [detSubSldoIni], [detSubActivo]) VALUES(@EmpID, @categID, @subCatID, @detSubID, @detSubDsc, @detSubAnio, @detSubFch, @detSubSldoIni, @detSubActivo)", GxErrorMask.GX_NOMASK,prmT000C35)
             ,new CursorDef("T000C36", "UPDATE [CategoriassubCatSldos] SET [detSubDsc]=@detSubDsc, [detSubAnio]=@detSubAnio, [detSubFch]=@detSubFch, [detSubSldoIni]=@detSubSldoIni, [detSubActivo]=@detSubActivo  WHERE [EmpID] = @EmpID AND [categID] = @categID AND [subCatID] = @subCatID AND [detSubID] = @detSubID", GxErrorMask.GX_NOMASK,prmT000C36)
             ,new CursorDef("T000C37", "DELETE FROM [CategoriassubCatSldos]  WHERE [EmpID] = @EmpID AND [categID] = @categID AND [subCatID] = @subCatID AND [detSubID] = @detSubID", GxErrorMask.GX_NOMASK,prmT000C37)
             ,new CursorDef("T000C38", "SELECT [EmpID], [categID], [subCatID], [detSubID] FROM [CategoriassubCatSldos] WITH (NOLOCK) WHERE [EmpID] = @EmpID and [categID] = @categID and [subCatID] = @subCatID ORDER BY [EmpID], [categID], [subCatID], [detSubID] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C38,11,0,true,false )
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
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(7) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(7);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(8);
                ((String[]) buf[12])[0] = rslt.getString(9, 1) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(9);
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(7) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(7);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(8);
                ((String[]) buf[12])[0] = rslt.getString(9, 1) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(9);
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 40) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((decimal[]) buf[5])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((decimal[]) buf[7])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                ((int[]) buf[9])[0] = rslt.getInt(7) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(7);
                ((String[]) buf[11])[0] = rslt.getString(8, 1) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(8);
                ((short[]) buf[13])[0] = rslt.getShort(9) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(9);
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 40) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((decimal[]) buf[5])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((decimal[]) buf[7])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                ((int[]) buf[9])[0] = rslt.getInt(7) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(7);
                ((String[]) buf[11])[0] = rslt.getString(8, 1) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(8);
                ((short[]) buf[13])[0] = rslt.getShort(9) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(9);
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 40) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((short[]) buf[6])[0] = rslt.getShort(5) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 40) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((short[]) buf[6])[0] = rslt.getShort(5) ;
                return;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 40) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 40) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 1) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                ((short[]) buf[10])[0] = rslt.getShort(7) ;
                return;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 19 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 20 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 21 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 40) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((decimal[]) buf[5])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((decimal[]) buf[7])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                ((int[]) buf[9])[0] = rslt.getInt(7) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(7);
                ((String[]) buf[11])[0] = rslt.getString(8, 1) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(8);
                ((short[]) buf[13])[0] = rslt.getShort(9) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(9);
                return;
             case 22 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 26 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 27 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                return;
             case 28 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 29 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
       }
       getresults30( cursor, rslt, buf) ;
    }

    public void getresults30( int cursor ,
                              IFieldGetter rslt ,
                              Object[] buf )
    {
       switch ( cursor )
       {
             case 30 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 31 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(7) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(7);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(8);
                ((String[]) buf[12])[0] = rslt.getString(9, 1) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(9);
                return;
             case 32 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 36 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
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
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
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
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
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
                stmt.SetParameter(5, (short)parms[6]);
                return;
             case 15 :
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
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 18 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 19 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
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
                   stmt.setNull( 5 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(5, (decimal)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 6 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(6, (decimal)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 7 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(7, (int)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 8 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[12]);
                }
                if ( (bool)parms[13] )
                {
                   stmt.setNull( 9 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(9, (short)parms[14]);
                }
                return;
             case 24 :
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
                   stmt.setNull( 2 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(2, (decimal)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(3, (decimal)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(4, (int)parms[7]);
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
                   stmt.setNull( 6 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(6, (short)parms[11]);
                }
                stmt.SetParameter(7, (short)parms[12]);
                stmt.SetParameter(8, (short)parms[13]);
                stmt.SetParameter(9, (short)parms[14]);
                return;
             case 25 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 26 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 27 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 28 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 29 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
       }
       setparameters30( cursor, stmt, parms) ;
    }

    public void setparameters30( int cursor ,
                                 IFieldSetter stmt ,
                                 Object[] parms )
    {
       switch ( cursor )
       {
             case 30 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 31 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 32 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 33 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 5 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 6 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(6, (short)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 7 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(7, (DateTime)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 8 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(8, (decimal)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 9 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[13]);
                }
                return;
             case 34 :
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
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(3, (DateTime)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(4, (decimal)parms[7]);
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
                stmt.SetParameter(8, (short)parms[12]);
                stmt.SetParameter(9, (short)parms[13]);
                return;
             case 35 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 36 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
       }
    }

 }

}
