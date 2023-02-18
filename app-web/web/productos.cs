/*
               File: Productos
        Description: Productos
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 12/29/2022 23:50:32.0
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
   public class productos : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_19") == 0 )
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
            gxLoad_19( A1EmpID, A31tipoProdID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_18") == 0 )
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
            gxLoad_18( A1EmpID, A2AgeID) ;
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
               AV18EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18EmpID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV18EmpID), "ZZZ9"), context));
               AV19AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19AgeID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV19AgeID), "ZZZ9"), context));
               AV8PrdCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8PrdCod), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vPRDCOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8PrdCod), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Productos", 0) ;
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

      public productos( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public productos( IGxContext context )
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
                           short aP3_PrdCod )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV18EmpID = aP1_EmpID;
         this.AV19AgeID = aP2_AgeID;
         this.AV8PrdCod = aP3_PrdCod;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbPrdTipPrd = new GXCombobox();
         cmbPrdPres = new GXCombobox();
         chkPrdEstado = new GXCheckbox();
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
         if ( cmbPrdTipPrd.ItemCount > 0 )
         {
            A308PrdTipPrd = (short)(NumberUtil.Val( cmbPrdTipPrd.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A308PrdTipPrd), 1, 0))), "."));
            n308PrdTipPrd = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A308PrdTipPrd", StringUtil.Str( (decimal)(A308PrdTipPrd), 1, 0));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbPrdTipPrd.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A308PrdTipPrd), 1, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPrdTipPrd_Internalname, "Values", cmbPrdTipPrd.ToJavascriptSource(), true);
         }
         if ( cmbPrdPres.ItemCount > 0 )
         {
            A288PrdPres = (short)(NumberUtil.Val( cmbPrdPres.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A288PrdPres), 2, 0))), "."));
            n288PrdPres = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A288PrdPres", StringUtil.LTrim( StringUtil.Str( (decimal)(A288PrdPres), 2, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbPrdPres.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A288PrdPres), 2, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPrdPres_Internalname, "Values", cmbPrdPres.ToJavascriptSource(), true);
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Productos", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Productos.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Productos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Productos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Productos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Productos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0200.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"AGEID"+"'), id:'"+"AGEID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"PRDCOD"+"'), id:'"+"PRDCOD"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_Productos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable2_Internalname, 1, 0, "px", 0, "px", "MainContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 col-lg-3", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection2_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtempdsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtempdsc_Internalname, "Empresa", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtempdsc_Internalname, A44empdsc, StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempdsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtempdsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Productos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection3_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtAgeDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtAgeDsc_Internalname, "Agencia", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtAgeDsc_Internalname, StringUtil.RTrim( A46AgeDsc), StringUtil.RTrim( context.localUtil.Format( A46AgeDsc, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAgeDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtAgeDsc_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "Descripcion", "left", true, "HLP_Productos.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtEmpID_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEmpID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEmpID_Internalname, "Emp ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtEmpID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEmpID_Jsonclick, 0, "Attribute", "", "", "", "", edtEmpID_Visible, edtEmpID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Productos.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_1_Internalname, sImgUrl, imgprompt_1_Link, "", "", context.GetTheme( ), imgprompt_1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Productos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtAgeID_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtAgeID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtAgeID_Internalname, "Age ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtAgeID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A2AgeID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A2AgeID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAgeID_Jsonclick, 0, "Attribute", "", "", "", "", edtAgeID_Visible, edtAgeID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Productos.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_2_Internalname, sImgUrl, imgprompt_2_Link, "", "", context.GetTheme( ), imgprompt_2_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Productos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable1_Internalname, 1, 0, "px", 0, "px", "MainContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 col-lg-3", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection5_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edttipoProdID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edttipoProdID_Internalname, "Codigo", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edttipoProdID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A31tipoProdID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A31tipoProdID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,61);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edttipoProdID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edttipoProdID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Productos.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_31_Internalname, sImgUrl, imgprompt_31_Link, "", "", context.GetTheme( ), imgprompt_31_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Productos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection1_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edttipoProdDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edttipoProdDsc_Internalname, "Tipo Producto", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edttipoProdDsc_Internalname, StringUtil.RTrim( A144tipoProdDsc), StringUtil.RTrim( context.localUtil.Format( A144tipoProdDsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edttipoProdDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edttipoProdDsc_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "nombres", "left", true, "HLP_Productos.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellAdvanced", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPrdCod_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPrdCod_Internalname, "ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPrdCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A286PrdCod), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A286PrdCod), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,71);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPrdCod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPrdCod_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Productos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtprdNombre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtprdNombre_Internalname, "Producto/Articulo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtprdNombre_Internalname, A309prdNombre, StringUtil.RTrim( context.localUtil.Format( A309prdNombre, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "Articulo", edtprdNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtprdNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 80, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Productos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPrdDescCorta_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPrdDescCorta_Internalname, "Nombre Corto", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPrdDescCorta_Internalname, A306PrdDescCorta, StringUtil.RTrim( context.localUtil.Format( A306PrdDescCorta, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,81);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "Nombre corto", edtPrdDescCorta_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPrdDescCorta_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Productos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbPrdTipPrd_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbPrdTipPrd_Internalname, "Tipo Producto", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbPrdTipPrd, cmbPrdTipPrd_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A308PrdTipPrd), 1, 0)), 1, cmbPrdTipPrd_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbPrdTipPrd.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,86);\"", "", true, "HLP_Productos.htm");
            cmbPrdTipPrd.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A308PrdTipPrd), 1, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPrdTipPrd_Internalname, "Values", (String)(cmbPrdTipPrd.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbPrdPres_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbPrdPres_Internalname, "Presentacion", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbPrdPres, cmbPrdPres_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A288PrdPres), 2, 0)), 1, cmbPrdPres_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbPrdPres.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,91);\"", "", true, "HLP_Productos.htm");
            cmbPrdPres.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A288PrdPres), 2, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPrdPres_Internalname, "Values", (String)(cmbPrdPres.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkPrdEstado_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkPrdEstado_Internalname, "Estado", "col-sm-3 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 96,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkPrdEstado_Internalname, A289PrdEstado, "", "Estado", 1, chkPrdEstado.Enabled, "A", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(96, this, 'A', 'I');gx.evt.onchange(this, event);\" ");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 101,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Productos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 103,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Productos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 105,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Productos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm0T72( ) ;
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
         E110T2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A44empdsc = StringUtil.Upper( cgiGet( edtempdsc_Internalname));
               n44empdsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
               A46AgeDsc = cgiGet( edtAgeDsc_Internalname);
               n46AgeDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtPrdCod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtPrdCod_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PRDCOD");
                  AnyError = 1;
                  GX_FocusControl = edtPrdCod_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A286PrdCod = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
               }
               else
               {
                  A286PrdCod = (short)(context.localUtil.CToN( cgiGet( edtPrdCod_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
               }
               A309prdNombre = cgiGet( edtprdNombre_Internalname);
               n309prdNombre = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309prdNombre", A309prdNombre);
               n309prdNombre = (String.IsNullOrEmpty(StringUtil.RTrim( A309prdNombre)) ? true : false);
               A306PrdDescCorta = cgiGet( edtPrdDescCorta_Internalname);
               n306PrdDescCorta = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306PrdDescCorta", A306PrdDescCorta);
               n306PrdDescCorta = (String.IsNullOrEmpty(StringUtil.RTrim( A306PrdDescCorta)) ? true : false);
               cmbPrdTipPrd.CurrentValue = cgiGet( cmbPrdTipPrd_Internalname);
               A308PrdTipPrd = (short)(NumberUtil.Val( cgiGet( cmbPrdTipPrd_Internalname), "."));
               n308PrdTipPrd = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A308PrdTipPrd", StringUtil.Str( (decimal)(A308PrdTipPrd), 1, 0));
               n308PrdTipPrd = ((0==A308PrdTipPrd) ? true : false);
               cmbPrdPres.CurrentValue = cgiGet( cmbPrdPres_Internalname);
               A288PrdPres = (short)(NumberUtil.Val( cgiGet( cmbPrdPres_Internalname), "."));
               n288PrdPres = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A288PrdPres", StringUtil.LTrim( StringUtil.Str( (decimal)(A288PrdPres), 2, 0)));
               n288PrdPres = ((0==A288PrdPres) ? true : false);
               A289PrdEstado = ((StringUtil.StrCmp(cgiGet( chkPrdEstado_Internalname), "A")==0) ? "A" : "I");
               n289PrdEstado = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PrdEstado", A289PrdEstado);
               n289PrdEstado = (String.IsNullOrEmpty(StringUtil.RTrim( A289PrdEstado)) ? true : false);
               /* Read saved values. */
               Z1EmpID = (short)(context.localUtil.CToN( cgiGet( "Z1EmpID"), ",", "."));
               Z2AgeID = (short)(context.localUtil.CToN( cgiGet( "Z2AgeID"), ",", "."));
               Z286PrdCod = (short)(context.localUtil.CToN( cgiGet( "Z286PrdCod"), ",", "."));
               Z309prdNombre = cgiGet( "Z309prdNombre");
               n309prdNombre = (String.IsNullOrEmpty(StringUtil.RTrim( A309prdNombre)) ? true : false);
               Z306PrdDescCorta = cgiGet( "Z306PrdDescCorta");
               n306PrdDescCorta = (String.IsNullOrEmpty(StringUtil.RTrim( A306PrdDescCorta)) ? true : false);
               Z288PrdPres = (short)(context.localUtil.CToN( cgiGet( "Z288PrdPres"), ",", "."));
               n288PrdPres = ((0==A288PrdPres) ? true : false);
               Z289PrdEstado = cgiGet( "Z289PrdEstado");
               n289PrdEstado = (String.IsNullOrEmpty(StringUtil.RTrim( A289PrdEstado)) ? true : false);
               Z308PrdTipPrd = (short)(context.localUtil.CToN( cgiGet( "Z308PrdTipPrd"), ",", "."));
               n308PrdTipPrd = ((0==A308PrdTipPrd) ? true : false);
               Z31tipoProdID = (short)(context.localUtil.CToN( cgiGet( "Z31tipoProdID"), ",", "."));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               N31tipoProdID = (short)(context.localUtil.CToN( cgiGet( "N31tipoProdID"), ",", "."));
               AV18EmpID = (short)(context.localUtil.CToN( cgiGet( "vEMPID"), ",", "."));
               AV19AgeID = (short)(context.localUtil.CToN( cgiGet( "vAGEID"), ",", "."));
               AV8PrdCod = (short)(context.localUtil.CToN( cgiGet( "vPRDCOD"), ",", "."));
               AV14Insert_TipoProdID = (short)(context.localUtil.CToN( cgiGet( "vINSERT_TIPOPRODID"), ",", "."));
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ",", "."));
               AV22Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Productos";
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV14Insert_TipoProdID), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A286PrdCod != Z286PrdCod ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("productos:[SecurityCheckFailed value for]"+"Insert_TipoProdID:"+context.localUtil.Format( (decimal)(AV14Insert_TipoProdID), "ZZZ9"));
                  GXUtil.WriteLog("productos:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A286PrdCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
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
                     sMode72 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode72;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound72 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0T0( ) ;
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
                        E110T2 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: After Trn */
                        E120T2 ();
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
            E120T2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0T72( ) ;
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
            DisableAttributes0T72( ) ;
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

      protected void CONFIRM_0T0( )
      {
         BeforeValidate0T72( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0T72( ) ;
            }
            else
            {
               CheckExtendedTable0T72( ) ;
               CloseExtendedTableCursors0T72( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0T0( )
      {
      }

      protected void E110T2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV22Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV22Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV10TrnContext.FromXml(AV11WebSession.Get("TrnContext"), null, "TransactionContext", "KBCalpesa22");
         AV14Insert_TipoProdID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Insert_TipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14Insert_TipoProdID), 4, 0)));
         if ( ( StringUtil.StrCmp(AV10TrnContext.gxTpr_Transactionname, AV22Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV23GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV23GXV1), 8, 0)));
            while ( AV23GXV1 <= AV10TrnContext.gxTpr_Attributes.Count )
            {
               AV13TrnContextAtt = ((SdtTransactionContext_Attribute)AV10TrnContext.gxTpr_Attributes.Item(AV23GXV1));
               if ( StringUtil.StrCmp(AV13TrnContextAtt.gxTpr_Attributename, "tipoProdID") == 0 )
               {
                  AV14Insert_TipoProdID = (short)(NumberUtil.Val( AV13TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Insert_TipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14Insert_TipoProdID), 4, 0)));
               }
               AV23GXV1 = (int)(AV23GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV23GXV1), 8, 0)));
            }
         }
         edtEmpID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Visible), 5, 0)), true);
         edtAgeID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAgeID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAgeID_Visible), 5, 0)), true);
      }

      protected void E120T2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV10TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwproductos.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0T72( short GX_JID )
      {
         if ( ( GX_JID == 16 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z309prdNombre = T000T3_A309prdNombre[0];
               Z306PrdDescCorta = T000T3_A306PrdDescCorta[0];
               Z288PrdPres = T000T3_A288PrdPres[0];
               Z289PrdEstado = T000T3_A289PrdEstado[0];
               Z308PrdTipPrd = T000T3_A308PrdTipPrd[0];
               Z31tipoProdID = T000T3_A31tipoProdID[0];
            }
            else
            {
               Z309prdNombre = A309prdNombre;
               Z306PrdDescCorta = A306PrdDescCorta;
               Z288PrdPres = A288PrdPres;
               Z289PrdEstado = A289PrdEstado;
               Z308PrdTipPrd = A308PrdTipPrd;
               Z31tipoProdID = A31tipoProdID;
            }
         }
         if ( GX_JID == -16 )
         {
            Z286PrdCod = A286PrdCod;
            Z309prdNombre = A309prdNombre;
            Z306PrdDescCorta = A306PrdDescCorta;
            Z288PrdPres = A288PrdPres;
            Z289PrdEstado = A289PrdEstado;
            Z308PrdTipPrd = A308PrdTipPrd;
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z31tipoProdID = A31tipoProdID;
            Z44empdsc = A44empdsc;
            Z46AgeDsc = A46AgeDsc;
            Z144tipoProdDsc = A144tipoProdDsc;
         }
      }

      protected void standaloneNotModal( )
      {
         Gx_BScreen = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         imgprompt_1_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_2_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0021.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"AGEID"+"'), id:'"+"AGEID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_31_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00p1.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"TIPOPRODID"+"'), id:'"+"TIPOPRODID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV18EmpID) )
         {
            A1EmpID = AV18EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         }
         if ( ! (0==AV18EmpID) )
         {
            edtEmpID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         }
         else
         {
            edtEmpID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV18EmpID) )
         {
            edtEmpID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV19AgeID) )
         {
            A2AgeID = AV19AgeID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
         }
         if ( ! (0==AV19AgeID) )
         {
            edtAgeID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAgeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAgeID_Enabled), 5, 0)), true);
         }
         else
         {
            edtAgeID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAgeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAgeID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV19AgeID) )
         {
            edtAgeID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAgeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAgeID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV8PrdCod) )
         {
            A286PrdCod = AV8PrdCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
         }
         if ( ! (0==AV8PrdCod) )
         {
            edtPrdCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrdCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrdCod_Enabled), 5, 0)), true);
         }
         else
         {
            edtPrdCod_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrdCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrdCod_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV8PrdCod) )
         {
            edtPrdCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrdCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrdCod_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV14Insert_TipoProdID) )
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV14Insert_TipoProdID) )
         {
            A31tipoProdID = AV14Insert_TipoProdID;
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A308PrdTipPrd) && ( Gx_BScreen == 0 ) )
         {
            A308PrdTipPrd = 1;
            n308PrdTipPrd = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A308PrdTipPrd", StringUtil.Str( (decimal)(A308PrdTipPrd), 1, 0));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            /* Using cursor T000T4 */
            pr_default.execute(2, new Object[] {A1EmpID});
            A44empdsc = T000T4_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000T4_n44empdsc[0];
            pr_default.close(2);
            AV22Pgmname = "Productos";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22Pgmname", AV22Pgmname);
            /* Using cursor T000T5 */
            pr_default.execute(3, new Object[] {A1EmpID, A2AgeID});
            A46AgeDsc = T000T5_A46AgeDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
            n46AgeDsc = T000T5_n46AgeDsc[0];
            pr_default.close(3);
            /* Using cursor T000T6 */
            pr_default.execute(4, new Object[] {A1EmpID, A31tipoProdID});
            A144tipoProdDsc = T000T6_A144tipoProdDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144tipoProdDsc", A144tipoProdDsc);
            n144tipoProdDsc = T000T6_n144tipoProdDsc[0];
            pr_default.close(4);
         }
      }

      protected void Load0T72( )
      {
         /* Using cursor T000T7 */
         pr_default.execute(5, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound72 = 1;
            A44empdsc = T000T7_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000T7_n44empdsc[0];
            A46AgeDsc = T000T7_A46AgeDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
            n46AgeDsc = T000T7_n46AgeDsc[0];
            A309prdNombre = T000T7_A309prdNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309prdNombre", A309prdNombre);
            n309prdNombre = T000T7_n309prdNombre[0];
            A144tipoProdDsc = T000T7_A144tipoProdDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144tipoProdDsc", A144tipoProdDsc);
            n144tipoProdDsc = T000T7_n144tipoProdDsc[0];
            A306PrdDescCorta = T000T7_A306PrdDescCorta[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306PrdDescCorta", A306PrdDescCorta);
            n306PrdDescCorta = T000T7_n306PrdDescCorta[0];
            A288PrdPres = T000T7_A288PrdPres[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A288PrdPres", StringUtil.LTrim( StringUtil.Str( (decimal)(A288PrdPres), 2, 0)));
            n288PrdPres = T000T7_n288PrdPres[0];
            A289PrdEstado = T000T7_A289PrdEstado[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PrdEstado", A289PrdEstado);
            n289PrdEstado = T000T7_n289PrdEstado[0];
            A308PrdTipPrd = T000T7_A308PrdTipPrd[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A308PrdTipPrd", StringUtil.Str( (decimal)(A308PrdTipPrd), 1, 0));
            n308PrdTipPrd = T000T7_n308PrdTipPrd[0];
            A31tipoProdID = T000T7_A31tipoProdID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A31tipoProdID), 4, 0)));
            ZM0T72( -16) ;
         }
         pr_default.close(5);
         OnLoadActions0T72( ) ;
      }

      protected void OnLoadActions0T72( )
      {
         AV22Pgmname = "Productos";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22Pgmname", AV22Pgmname);
      }

      protected void CheckExtendedTable0T72( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         AV22Pgmname = "Productos";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22Pgmname", AV22Pgmname);
         /* Using cursor T000T4 */
         pr_default.execute(2, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000T4_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T000T4_n44empdsc[0];
         pr_default.close(2);
         /* Using cursor T000T6 */
         pr_default.execute(4, new Object[] {A1EmpID, A31tipoProdID});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Producto'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A144tipoProdDsc = T000T6_A144tipoProdDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144tipoProdDsc", A144tipoProdDsc);
         n144tipoProdDsc = T000T6_n144tipoProdDsc[0];
         pr_default.close(4);
         /* Using cursor T000T5 */
         pr_default.execute(3, new Object[] {A1EmpID, A2AgeID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("No existe 'Agencias'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A46AgeDsc = T000T5_A46AgeDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
         n46AgeDsc = T000T5_n46AgeDsc[0];
         pr_default.close(3);
      }

      protected void CloseExtendedTableCursors0T72( )
      {
         pr_default.close(2);
         pr_default.close(4);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_17( short A1EmpID )
      {
         /* Using cursor T000T8 */
         pr_default.execute(6, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000T8_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T000T8_n44empdsc[0];
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

      protected void gxLoad_19( short A1EmpID ,
                                short A31tipoProdID )
      {
         /* Using cursor T000T9 */
         pr_default.execute(7, new Object[] {A1EmpID, A31tipoProdID});
         if ( (pr_default.getStatus(7) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Producto'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A144tipoProdDsc = T000T9_A144tipoProdDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144tipoProdDsc", A144tipoProdDsc);
         n144tipoProdDsc = T000T9_n144tipoProdDsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A144tipoProdDsc))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(7) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(7);
      }

      protected void gxLoad_18( short A1EmpID ,
                                short A2AgeID )
      {
         /* Using cursor T000T10 */
         pr_default.execute(8, new Object[] {A1EmpID, A2AgeID});
         if ( (pr_default.getStatus(8) == 101) )
         {
            GX_msglist.addItem("No existe 'Agencias'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A46AgeDsc = T000T10_A46AgeDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
         n46AgeDsc = T000T10_n46AgeDsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A46AgeDsc))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(8) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(8);
      }

      protected void GetKey0T72( )
      {
         /* Using cursor T000T11 */
         pr_default.execute(9, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound72 = 1;
         }
         else
         {
            RcdFound72 = 0;
         }
         pr_default.close(9);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000T3 */
         pr_default.execute(1, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0T72( 16) ;
            RcdFound72 = 1;
            A286PrdCod = T000T3_A286PrdCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
            A309prdNombre = T000T3_A309prdNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309prdNombre", A309prdNombre);
            n309prdNombre = T000T3_n309prdNombre[0];
            A306PrdDescCorta = T000T3_A306PrdDescCorta[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306PrdDescCorta", A306PrdDescCorta);
            n306PrdDescCorta = T000T3_n306PrdDescCorta[0];
            A288PrdPres = T000T3_A288PrdPres[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A288PrdPres", StringUtil.LTrim( StringUtil.Str( (decimal)(A288PrdPres), 2, 0)));
            n288PrdPres = T000T3_n288PrdPres[0];
            A289PrdEstado = T000T3_A289PrdEstado[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PrdEstado", A289PrdEstado);
            n289PrdEstado = T000T3_n289PrdEstado[0];
            A308PrdTipPrd = T000T3_A308PrdTipPrd[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A308PrdTipPrd", StringUtil.Str( (decimal)(A308PrdTipPrd), 1, 0));
            n308PrdTipPrd = T000T3_n308PrdTipPrd[0];
            A1EmpID = T000T3_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = T000T3_A2AgeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A31tipoProdID = T000T3_A31tipoProdID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A31tipoProdID), 4, 0)));
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z286PrdCod = A286PrdCod;
            sMode72 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0T72( ) ;
            if ( AnyError == 1 )
            {
               RcdFound72 = 0;
               InitializeNonKey0T72( ) ;
            }
            Gx_mode = sMode72;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound72 = 0;
            InitializeNonKey0T72( ) ;
            sMode72 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode72;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0T72( ) ;
         if ( RcdFound72 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound72 = 0;
         /* Using cursor T000T12 */
         pr_default.execute(10, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
         if ( (pr_default.getStatus(10) != 101) )
         {
            while ( (pr_default.getStatus(10) != 101) && ( ( T000T12_A1EmpID[0] < A1EmpID ) || ( T000T12_A1EmpID[0] == A1EmpID ) && ( T000T12_A2AgeID[0] < A2AgeID ) || ( T000T12_A2AgeID[0] == A2AgeID ) && ( T000T12_A1EmpID[0] == A1EmpID ) && ( T000T12_A286PrdCod[0] < A286PrdCod ) ) )
            {
               pr_default.readNext(10);
            }
            if ( (pr_default.getStatus(10) != 101) && ( ( T000T12_A1EmpID[0] > A1EmpID ) || ( T000T12_A1EmpID[0] == A1EmpID ) && ( T000T12_A2AgeID[0] > A2AgeID ) || ( T000T12_A2AgeID[0] == A2AgeID ) && ( T000T12_A1EmpID[0] == A1EmpID ) && ( T000T12_A286PrdCod[0] > A286PrdCod ) ) )
            {
               A1EmpID = T000T12_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A2AgeID = T000T12_A2AgeID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
               A286PrdCod = T000T12_A286PrdCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
               RcdFound72 = 1;
            }
         }
         pr_default.close(10);
      }

      protected void move_previous( )
      {
         RcdFound72 = 0;
         /* Using cursor T000T13 */
         pr_default.execute(11, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
         if ( (pr_default.getStatus(11) != 101) )
         {
            while ( (pr_default.getStatus(11) != 101) && ( ( T000T13_A1EmpID[0] > A1EmpID ) || ( T000T13_A1EmpID[0] == A1EmpID ) && ( T000T13_A2AgeID[0] > A2AgeID ) || ( T000T13_A2AgeID[0] == A2AgeID ) && ( T000T13_A1EmpID[0] == A1EmpID ) && ( T000T13_A286PrdCod[0] > A286PrdCod ) ) )
            {
               pr_default.readNext(11);
            }
            if ( (pr_default.getStatus(11) != 101) && ( ( T000T13_A1EmpID[0] < A1EmpID ) || ( T000T13_A1EmpID[0] == A1EmpID ) && ( T000T13_A2AgeID[0] < A2AgeID ) || ( T000T13_A2AgeID[0] == A2AgeID ) && ( T000T13_A1EmpID[0] == A1EmpID ) && ( T000T13_A286PrdCod[0] < A286PrdCod ) ) )
            {
               A1EmpID = T000T13_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A2AgeID = T000T13_A2AgeID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
               A286PrdCod = T000T13_A286PrdCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
               RcdFound72 = 1;
            }
         }
         pr_default.close(11);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0T72( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0T72( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound72 == 1 )
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A286PrdCod != Z286PrdCod ) )
               {
                  A1EmpID = Z1EmpID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
                  A2AgeID = Z2AgeID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
                  A286PrdCod = Z286PrdCod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
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
                  Update0T72( ) ;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A286PrdCod != Z286PrdCod ) )
               {
                  /* Insert record */
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0T72( ) ;
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
                     Insert0T72( ) ;
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
         if ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A286PrdCod != Z286PrdCod ) )
         {
            A1EmpID = Z1EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = Z2AgeID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A286PrdCod = Z286PrdCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
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

      protected void CheckOptimisticConcurrency0T72( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000T2 */
            pr_default.execute(0, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Productos"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z309prdNombre, T000T2_A309prdNombre[0]) != 0 ) || ( StringUtil.StrCmp(Z306PrdDescCorta, T000T2_A306PrdDescCorta[0]) != 0 ) || ( Z288PrdPres != T000T2_A288PrdPres[0] ) || ( StringUtil.StrCmp(Z289PrdEstado, T000T2_A289PrdEstado[0]) != 0 ) || ( Z308PrdTipPrd != T000T2_A308PrdTipPrd[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z31tipoProdID != T000T2_A31tipoProdID[0] ) )
            {
               if ( StringUtil.StrCmp(Z309prdNombre, T000T2_A309prdNombre[0]) != 0 )
               {
                  GXUtil.WriteLog("productos:[seudo value changed for attri]"+"prdNombre");
                  GXUtil.WriteLogRaw("Old: ",Z309prdNombre);
                  GXUtil.WriteLogRaw("Current: ",T000T2_A309prdNombre[0]);
               }
               if ( StringUtil.StrCmp(Z306PrdDescCorta, T000T2_A306PrdDescCorta[0]) != 0 )
               {
                  GXUtil.WriteLog("productos:[seudo value changed for attri]"+"PrdDescCorta");
                  GXUtil.WriteLogRaw("Old: ",Z306PrdDescCorta);
                  GXUtil.WriteLogRaw("Current: ",T000T2_A306PrdDescCorta[0]);
               }
               if ( Z288PrdPres != T000T2_A288PrdPres[0] )
               {
                  GXUtil.WriteLog("productos:[seudo value changed for attri]"+"PrdPres");
                  GXUtil.WriteLogRaw("Old: ",Z288PrdPres);
                  GXUtil.WriteLogRaw("Current: ",T000T2_A288PrdPres[0]);
               }
               if ( StringUtil.StrCmp(Z289PrdEstado, T000T2_A289PrdEstado[0]) != 0 )
               {
                  GXUtil.WriteLog("productos:[seudo value changed for attri]"+"PrdEstado");
                  GXUtil.WriteLogRaw("Old: ",Z289PrdEstado);
                  GXUtil.WriteLogRaw("Current: ",T000T2_A289PrdEstado[0]);
               }
               if ( Z308PrdTipPrd != T000T2_A308PrdTipPrd[0] )
               {
                  GXUtil.WriteLog("productos:[seudo value changed for attri]"+"PrdTipPrd");
                  GXUtil.WriteLogRaw("Old: ",Z308PrdTipPrd);
                  GXUtil.WriteLogRaw("Current: ",T000T2_A308PrdTipPrd[0]);
               }
               if ( Z31tipoProdID != T000T2_A31tipoProdID[0] )
               {
                  GXUtil.WriteLog("productos:[seudo value changed for attri]"+"tipoProdID");
                  GXUtil.WriteLogRaw("Old: ",Z31tipoProdID);
                  GXUtil.WriteLogRaw("Current: ",T000T2_A31tipoProdID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Productos"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0T72( )
      {
         BeforeValidate0T72( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0T72( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0T72( 0) ;
            CheckOptimisticConcurrency0T72( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0T72( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0T72( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000T14 */
                     pr_default.execute(12, new Object[] {A286PrdCod, n309prdNombre, A309prdNombre, n306PrdDescCorta, A306PrdDescCorta, n288PrdPres, A288PrdPres, n289PrdEstado, A289PrdEstado, n308PrdTipPrd, A308PrdTipPrd, A1EmpID, A2AgeID, A31tipoProdID});
                     pr_default.close(12);
                     dsDefault.SmartCacheProvider.SetUpdated("Productos") ;
                     if ( (pr_default.getStatus(12) == 1) )
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
                           ResetCaption0T0( ) ;
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
               Load0T72( ) ;
            }
            EndLevel0T72( ) ;
         }
         CloseExtendedTableCursors0T72( ) ;
      }

      protected void Update0T72( )
      {
         BeforeValidate0T72( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0T72( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0T72( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0T72( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0T72( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000T15 */
                     pr_default.execute(13, new Object[] {n309prdNombre, A309prdNombre, n306PrdDescCorta, A306PrdDescCorta, n288PrdPres, A288PrdPres, n289PrdEstado, A289PrdEstado, n308PrdTipPrd, A308PrdTipPrd, A31tipoProdID, A1EmpID, A2AgeID, A286PrdCod});
                     pr_default.close(13);
                     dsDefault.SmartCacheProvider.SetUpdated("Productos") ;
                     if ( (pr_default.getStatus(13) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Productos"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0T72( ) ;
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
            EndLevel0T72( ) ;
         }
         CloseExtendedTableCursors0T72( ) ;
      }

      protected void DeferredUpdate0T72( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0T72( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0T72( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0T72( ) ;
            AfterConfirm0T72( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0T72( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000T16 */
                  pr_default.execute(14, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
                  pr_default.close(14);
                  dsDefault.SmartCacheProvider.SetUpdated("Productos") ;
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
         sMode72 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0T72( ) ;
         Gx_mode = sMode72;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0T72( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV22Pgmname = "Productos";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22Pgmname", AV22Pgmname);
            /* Using cursor T000T17 */
            pr_default.execute(15, new Object[] {A1EmpID});
            A44empdsc = T000T17_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000T17_n44empdsc[0];
            pr_default.close(15);
            /* Using cursor T000T18 */
            pr_default.execute(16, new Object[] {A1EmpID, A2AgeID});
            A46AgeDsc = T000T18_A46AgeDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
            n46AgeDsc = T000T18_n46AgeDsc[0];
            pr_default.close(16);
            /* Using cursor T000T19 */
            pr_default.execute(17, new Object[] {A1EmpID, A31tipoProdID});
            A144tipoProdDsc = T000T19_A144tipoProdDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144tipoProdDsc", A144tipoProdDsc);
            n144tipoProdDsc = T000T19_n144tipoProdDsc[0];
            pr_default.close(17);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000T20 */
            pr_default.execute(18, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
            if ( (pr_default.getStatus(18) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"ingre Bod Det"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(18);
            /* Using cursor T000T21 */
            pr_default.execute(19, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
            if ( (pr_default.getStatus(19) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Prodx Bodega"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(19);
            /* Using cursor T000T22 */
            pr_default.execute(20, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
            if ( (pr_default.getStatus(20) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"oc Det"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(20);
            /* Using cursor T000T23 */
            pr_default.execute(21, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
            if ( (pr_default.getStatus(21) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Prod Precio"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(21);
            /* Using cursor T000T24 */
            pr_default.execute(22, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
            if ( (pr_default.getStatus(22) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"det Inv"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(22);
         }
      }

      protected void EndLevel0T72( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0T72( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(15);
            pr_default.close(16);
            pr_default.close(17);
            context.CommitDataStores("productos",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0T0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(15);
            pr_default.close(16);
            pr_default.close(17);
            context.RollbackDataStores("productos",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0T72( )
      {
         /* Scan By routine */
         /* Using cursor T000T25 */
         pr_default.execute(23);
         RcdFound72 = 0;
         if ( (pr_default.getStatus(23) != 101) )
         {
            RcdFound72 = 1;
            A1EmpID = T000T25_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = T000T25_A2AgeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A286PrdCod = T000T25_A286PrdCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0T72( )
      {
         /* Scan next routine */
         pr_default.readNext(23);
         RcdFound72 = 0;
         if ( (pr_default.getStatus(23) != 101) )
         {
            RcdFound72 = 1;
            A1EmpID = T000T25_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = T000T25_A2AgeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A286PrdCod = T000T25_A286PrdCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
         }
      }

      protected void ScanEnd0T72( )
      {
         pr_default.close(23);
      }

      protected void AfterConfirm0T72( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0T72( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0T72( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0T72( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0T72( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0T72( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0T72( )
      {
         edtempdsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempdsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempdsc_Enabled), 5, 0)), true);
         edtAgeDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAgeDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAgeDsc_Enabled), 5, 0)), true);
         edtEmpID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         edtAgeID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAgeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAgeID_Enabled), 5, 0)), true);
         edttipoProdID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edttipoProdID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edttipoProdID_Enabled), 5, 0)), true);
         edttipoProdDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edttipoProdDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edttipoProdDsc_Enabled), 5, 0)), true);
         edtPrdCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrdCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrdCod_Enabled), 5, 0)), true);
         edtprdNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtprdNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtprdNombre_Enabled), 5, 0)), true);
         edtPrdDescCorta_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrdDescCorta_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrdDescCorta_Enabled), 5, 0)), true);
         cmbPrdTipPrd.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPrdTipPrd_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbPrdTipPrd.Enabled), 5, 0)), true);
         cmbPrdPres.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPrdPres_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbPrdPres.Enabled), 5, 0)), true);
         chkPrdEstado.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkPrdEstado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkPrdEstado.Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0T72( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0T0( )
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
         context.SendWebValue( "Productos") ;
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
         context.AddJavascriptSource("gxcfg.js", "?2022122923504063", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("productos.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV18EmpID) + "," + UrlEncode("" +AV19AgeID) + "," + UrlEncode("" +AV8PrdCod)+"\">") ;
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
         forbiddenHiddens = "hsh" + "Productos";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV14Insert_TipoProdID), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("productos:[SendSecurityCheck value for]"+"Insert_TipoProdID:"+context.localUtil.Format( (decimal)(AV14Insert_TipoProdID), "ZZZ9"));
         GXUtil.WriteLog("productos:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1EmpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z2AgeID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z2AgeID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z286PrdCod", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z286PrdCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z309prdNombre", Z309prdNombre);
         GxWebStd.gx_hidden_field( context, "Z306PrdDescCorta", Z306PrdDescCorta);
         GxWebStd.gx_hidden_field( context, "Z288PrdPres", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z288PrdPres), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z289PrdEstado", StringUtil.RTrim( Z289PrdEstado));
         GxWebStd.gx_hidden_field( context, "Z308PrdTipPrd", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z308PrdTipPrd), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z31tipoProdID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z31tipoProdID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N31tipoProdID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A31tipoProdID), 4, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV10TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV10TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV18EmpID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19AgeID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV19AgeID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vPRDCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8PrdCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vPRDCOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8PrdCod), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_TIPOPRODID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14Insert_TipoProdID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV22Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void RenderHtmlCloseForm0T72( )
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
         return "Productos" ;
      }

      public override String GetPgmdesc( )
      {
         return "Productos" ;
      }

      protected void InitializeNonKey0T72( )
      {
         A31tipoProdID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A31tipoProdID), 4, 0)));
         A44empdsc = "";
         n44empdsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         A46AgeDsc = "";
         n46AgeDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
         A309prdNombre = "";
         n309prdNombre = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309prdNombre", A309prdNombre);
         n309prdNombre = (String.IsNullOrEmpty(StringUtil.RTrim( A309prdNombre)) ? true : false);
         A144tipoProdDsc = "";
         n144tipoProdDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A144tipoProdDsc", A144tipoProdDsc);
         A306PrdDescCorta = "";
         n306PrdDescCorta = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306PrdDescCorta", A306PrdDescCorta);
         n306PrdDescCorta = (String.IsNullOrEmpty(StringUtil.RTrim( A306PrdDescCorta)) ? true : false);
         A288PrdPres = 0;
         n288PrdPres = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A288PrdPres", StringUtil.LTrim( StringUtil.Str( (decimal)(A288PrdPres), 2, 0)));
         n288PrdPres = ((0==A288PrdPres) ? true : false);
         A289PrdEstado = "";
         n289PrdEstado = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PrdEstado", A289PrdEstado);
         n289PrdEstado = (String.IsNullOrEmpty(StringUtil.RTrim( A289PrdEstado)) ? true : false);
         A308PrdTipPrd = 1;
         n308PrdTipPrd = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A308PrdTipPrd", StringUtil.Str( (decimal)(A308PrdTipPrd), 1, 0));
         Z309prdNombre = "";
         Z306PrdDescCorta = "";
         Z288PrdPres = 0;
         Z289PrdEstado = "";
         Z308PrdTipPrd = 0;
         Z31tipoProdID = 0;
      }

      protected void InitAll0T72( )
      {
         A1EmpID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         A2AgeID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
         A286PrdCod = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
         InitializeNonKey0T72( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A308PrdTipPrd = i308PrdTipPrd;
         n308PrdTipPrd = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A308PrdTipPrd", StringUtil.Str( (decimal)(A308PrdTipPrd), 1, 0));
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022122923504085", true);
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
         context.AddJavascriptSource("productos.js", "?2022122923504086", false);
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
         edtempdsc_Internalname = "EMPDSC";
         divSection2_Internalname = "SECTION2";
         edtAgeDsc_Internalname = "AGEDSC";
         divSection3_Internalname = "SECTION3";
         divTable2_Internalname = "TABLE2";
         edtEmpID_Internalname = "EMPID";
         edtAgeID_Internalname = "AGEID";
         edttipoProdID_Internalname = "TIPOPRODID";
         divSection5_Internalname = "SECTION5";
         edttipoProdDsc_Internalname = "TIPOPRODDSC";
         divSection1_Internalname = "SECTION1";
         divTable1_Internalname = "TABLE1";
         edtPrdCod_Internalname = "PRDCOD";
         edtprdNombre_Internalname = "PRDNOMBRE";
         edtPrdDescCorta_Internalname = "PRDDESCCORTA";
         cmbPrdTipPrd_Internalname = "PRDTIPPRD";
         cmbPrdPres_Internalname = "PRDPRES";
         chkPrdEstado_Internalname = "PRDESTADO";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_1_Internalname = "PROMPT_1";
         imgprompt_2_Internalname = "PROMPT_2";
         imgprompt_31_Internalname = "PROMPT_31";
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
         chkPrdEstado.Enabled = 1;
         cmbPrdPres_Jsonclick = "";
         cmbPrdPres.Enabled = 1;
         cmbPrdTipPrd_Jsonclick = "";
         cmbPrdTipPrd.Enabled = 1;
         edtPrdDescCorta_Jsonclick = "";
         edtPrdDescCorta_Enabled = 1;
         edtprdNombre_Jsonclick = "";
         edtprdNombre_Enabled = 1;
         edtPrdCod_Jsonclick = "";
         edtPrdCod_Enabled = 1;
         edttipoProdDsc_Jsonclick = "";
         edttipoProdDsc_Enabled = 0;
         imgprompt_31_Visible = 1;
         imgprompt_31_Link = "";
         edttipoProdID_Jsonclick = "";
         edttipoProdID_Enabled = 1;
         imgprompt_2_Link = "";
         edtAgeID_Jsonclick = "";
         edtAgeID_Enabled = 1;
         edtAgeID_Visible = 1;
         imgprompt_1_Link = "";
         edtEmpID_Jsonclick = "";
         edtEmpID_Enabled = 1;
         edtEmpID_Visible = 1;
         edtAgeDsc_Jsonclick = "";
         edtAgeDsc_Enabled = 0;
         edtempdsc_Jsonclick = "";
         edtempdsc_Enabled = 0;
         bttBtn_select_Visible = 1;
         bttBtn_last_Visible = 1;
         bttBtn_next_Visible = 1;
         bttBtn_previous_Visible = 1;
         bttBtn_first_Visible = 1;
         imgprompt_2_Visible = 1;
         imgprompt_1_Visible = 1;
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
         cmbPrdTipPrd.Name = "PRDTIPPRD";
         cmbPrdTipPrd.WebTags = "";
         cmbPrdTipPrd.addItem("0", "Seleccionar", 0);
         cmbPrdTipPrd.addItem("1", "BIEN", 0);
         cmbPrdTipPrd.addItem("2", "SERVICO", 0);
         cmbPrdTipPrd.addItem("3", "GARANTIA", 0);
         if ( cmbPrdTipPrd.ItemCount > 0 )
         {
            if ( (0==A308PrdTipPrd) )
            {
               A308PrdTipPrd = 1;
               n308PrdTipPrd = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A308PrdTipPrd", StringUtil.Str( (decimal)(A308PrdTipPrd), 1, 0));
            }
            A308PrdTipPrd = (short)(NumberUtil.Val( cmbPrdTipPrd.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A308PrdTipPrd), 1, 0))), "."));
            n308PrdTipPrd = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A308PrdTipPrd", StringUtil.Str( (decimal)(A308PrdTipPrd), 1, 0));
         }
         cmbPrdPres.Name = "PRDPRES";
         cmbPrdPres.WebTags = "";
         cmbPrdPres.addItem("0", "Seleccionar", 0);
         cmbPrdPres.addItem("1", "UNIDADES", 0);
         cmbPrdPres.addItem("2", "LITROS", 0);
         cmbPrdPres.addItem("3", "CAJA", 0);
         cmbPrdPres.addItem("4", "BULTO", 0);
         cmbPrdPres.addItem("5", "PACA", 0);
         cmbPrdPres.addItem("6", "EMBALAJE", 0);
         cmbPrdPres.addItem("7", "METRO CUADRADO", 0);
         cmbPrdPres.addItem("8", "GALON", 0);
         if ( cmbPrdPres.ItemCount > 0 )
         {
            A288PrdPres = (short)(NumberUtil.Val( cmbPrdPres.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A288PrdPres), 2, 0))), "."));
            n288PrdPres = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A288PrdPres", StringUtil.LTrim( StringUtil.Str( (decimal)(A288PrdPres), 2, 0)));
         }
         chkPrdEstado.Name = "PRDESTADO";
         chkPrdEstado.WebTags = "";
         chkPrdEstado.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkPrdEstado_Internalname, "TitleCaption", chkPrdEstado.Caption, true);
         chkPrdEstado.CheckedValue = "I";
         /* End function init_web_controls */
      }

      public void Valid_Empid( short GX_Parm1 ,
                               String GX_Parm2 )
      {
         A1EmpID = GX_Parm1;
         A44empdsc = GX_Parm2;
         n44empdsc = false;
         /* Using cursor T000T17 */
         pr_default.execute(15, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(15) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A44empdsc = T000T17_A44empdsc[0];
         n44empdsc = T000T17_n44empdsc[0];
         pr_default.close(15);
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
         /* Using cursor T000T18 */
         pr_default.execute(16, new Object[] {A1EmpID, A2AgeID});
         if ( (pr_default.getStatus(16) == 101) )
         {
            GX_msglist.addItem("No existe 'Agencias'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A46AgeDsc = T000T18_A46AgeDsc[0];
         n46AgeDsc = T000T18_n46AgeDsc[0];
         pr_default.close(16);
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

      public void Valid_Tipoprodid( short GX_Parm1 ,
                                    short GX_Parm2 ,
                                    String GX_Parm3 )
      {
         A1EmpID = GX_Parm1;
         A31tipoProdID = GX_Parm2;
         A144tipoProdDsc = GX_Parm3;
         n144tipoProdDsc = false;
         /* Using cursor T000T19 */
         pr_default.execute(17, new Object[] {A1EmpID, A31tipoProdID});
         if ( (pr_default.getStatus(17) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Producto'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A144tipoProdDsc = T000T19_A144tipoProdDsc[0];
         n144tipoProdDsc = T000T19_n144tipoProdDsc[0];
         pr_default.close(17);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV18EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV19AgeID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV8PrdCod',fld:'vPRDCOD',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV18EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV19AgeID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV8PrdCod',fld:'vPRDCOD',pic:'ZZZ9',hsh:true},{av:'AV14Insert_TipoProdID',fld:'vINSERT_TIPOPRODID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120T2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV10TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(15);
         pr_default.close(16);
         pr_default.close(17);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z309prdNombre = "";
         Z306PrdDescCorta = "";
         Z289PrdEstado = "";
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
         A44empdsc = "";
         A46AgeDsc = "";
         sImgUrl = "";
         A144tipoProdDsc = "";
         A309prdNombre = "";
         A306PrdDescCorta = "";
         A289PrdEstado = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         AV22Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode72 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV10TrnContext = new SdtTransactionContext(context);
         AV11WebSession = context.GetSession();
         AV13TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z44empdsc = "";
         Z46AgeDsc = "";
         Z144tipoProdDsc = "";
         T000T4_A44empdsc = new String[] {""} ;
         T000T4_n44empdsc = new bool[] {false} ;
         T000T5_A46AgeDsc = new String[] {""} ;
         T000T5_n46AgeDsc = new bool[] {false} ;
         T000T6_A144tipoProdDsc = new String[] {""} ;
         T000T6_n144tipoProdDsc = new bool[] {false} ;
         T000T7_A286PrdCod = new short[1] ;
         T000T7_A44empdsc = new String[] {""} ;
         T000T7_n44empdsc = new bool[] {false} ;
         T000T7_A46AgeDsc = new String[] {""} ;
         T000T7_n46AgeDsc = new bool[] {false} ;
         T000T7_A309prdNombre = new String[] {""} ;
         T000T7_n309prdNombre = new bool[] {false} ;
         T000T7_A144tipoProdDsc = new String[] {""} ;
         T000T7_n144tipoProdDsc = new bool[] {false} ;
         T000T7_A306PrdDescCorta = new String[] {""} ;
         T000T7_n306PrdDescCorta = new bool[] {false} ;
         T000T7_A288PrdPres = new short[1] ;
         T000T7_n288PrdPres = new bool[] {false} ;
         T000T7_A289PrdEstado = new String[] {""} ;
         T000T7_n289PrdEstado = new bool[] {false} ;
         T000T7_A308PrdTipPrd = new short[1] ;
         T000T7_n308PrdTipPrd = new bool[] {false} ;
         T000T7_A1EmpID = new short[1] ;
         T000T7_A2AgeID = new short[1] ;
         T000T7_A31tipoProdID = new short[1] ;
         T000T8_A44empdsc = new String[] {""} ;
         T000T8_n44empdsc = new bool[] {false} ;
         T000T9_A144tipoProdDsc = new String[] {""} ;
         T000T9_n144tipoProdDsc = new bool[] {false} ;
         T000T10_A46AgeDsc = new String[] {""} ;
         T000T10_n46AgeDsc = new bool[] {false} ;
         T000T11_A1EmpID = new short[1] ;
         T000T11_A2AgeID = new short[1] ;
         T000T11_A286PrdCod = new short[1] ;
         T000T3_A286PrdCod = new short[1] ;
         T000T3_A309prdNombre = new String[] {""} ;
         T000T3_n309prdNombre = new bool[] {false} ;
         T000T3_A306PrdDescCorta = new String[] {""} ;
         T000T3_n306PrdDescCorta = new bool[] {false} ;
         T000T3_A288PrdPres = new short[1] ;
         T000T3_n288PrdPres = new bool[] {false} ;
         T000T3_A289PrdEstado = new String[] {""} ;
         T000T3_n289PrdEstado = new bool[] {false} ;
         T000T3_A308PrdTipPrd = new short[1] ;
         T000T3_n308PrdTipPrd = new bool[] {false} ;
         T000T3_A1EmpID = new short[1] ;
         T000T3_A2AgeID = new short[1] ;
         T000T3_A31tipoProdID = new short[1] ;
         T000T12_A1EmpID = new short[1] ;
         T000T12_A2AgeID = new short[1] ;
         T000T12_A286PrdCod = new short[1] ;
         T000T13_A1EmpID = new short[1] ;
         T000T13_A2AgeID = new short[1] ;
         T000T13_A286PrdCod = new short[1] ;
         T000T2_A286PrdCod = new short[1] ;
         T000T2_A309prdNombre = new String[] {""} ;
         T000T2_n309prdNombre = new bool[] {false} ;
         T000T2_A306PrdDescCorta = new String[] {""} ;
         T000T2_n306PrdDescCorta = new bool[] {false} ;
         T000T2_A288PrdPres = new short[1] ;
         T000T2_n288PrdPres = new bool[] {false} ;
         T000T2_A289PrdEstado = new String[] {""} ;
         T000T2_n289PrdEstado = new bool[] {false} ;
         T000T2_A308PrdTipPrd = new short[1] ;
         T000T2_n308PrdTipPrd = new bool[] {false} ;
         T000T2_A1EmpID = new short[1] ;
         T000T2_A2AgeID = new short[1] ;
         T000T2_A31tipoProdID = new short[1] ;
         T000T17_A44empdsc = new String[] {""} ;
         T000T17_n44empdsc = new bool[] {false} ;
         T000T18_A46AgeDsc = new String[] {""} ;
         T000T18_n46AgeDsc = new bool[] {false} ;
         T000T19_A144tipoProdDsc = new String[] {""} ;
         T000T19_n144tipoProdDsc = new bool[] {false} ;
         T000T20_A1EmpID = new short[1] ;
         T000T20_A2AgeID = new short[1] ;
         T000T20_A364ingreBodNro = new short[1] ;
         T000T20_A369ingreBodDetId = new short[1] ;
         T000T21_A290stockAnio = new short[1] ;
         T000T21_A291stockMes = new short[1] ;
         T000T21_A1EmpID = new short[1] ;
         T000T21_A2AgeID = new short[1] ;
         T000T21_A42BodCod = new short[1] ;
         T000T21_A286PrdCod = new short[1] ;
         T000T22_A1EmpID = new short[1] ;
         T000T22_A2AgeID = new short[1] ;
         T000T22_A317OCompNro = new short[1] ;
         T000T22_A311OcTipoCod = new String[] {""} ;
         T000T22_A342ocDetID = new short[1] ;
         T000T23_A1EmpID = new short[1] ;
         T000T23_A2AgeID = new short[1] ;
         T000T23_A310ProdPreID = new short[1] ;
         T000T23_A286PrdCod = new short[1] ;
         T000T24_A1EmpID = new short[1] ;
         T000T24_A2AgeID = new short[1] ;
         T000T24_A42BodCod = new short[1] ;
         T000T24_A264invCod = new short[1] ;
         T000T24_A273detInvId = new short[1] ;
         T000T25_A1EmpID = new short[1] ;
         T000T25_A2AgeID = new short[1] ;
         T000T25_A286PrdCod = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.productos__default(),
            new Object[][] {
                new Object[] {
               T000T2_A286PrdCod, T000T2_A309prdNombre, T000T2_n309prdNombre, T000T2_A306PrdDescCorta, T000T2_n306PrdDescCorta, T000T2_A288PrdPres, T000T2_n288PrdPres, T000T2_A289PrdEstado, T000T2_n289PrdEstado, T000T2_A308PrdTipPrd,
               T000T2_n308PrdTipPrd, T000T2_A1EmpID, T000T2_A2AgeID, T000T2_A31tipoProdID
               }
               , new Object[] {
               T000T3_A286PrdCod, T000T3_A309prdNombre, T000T3_n309prdNombre, T000T3_A306PrdDescCorta, T000T3_n306PrdDescCorta, T000T3_A288PrdPres, T000T3_n288PrdPres, T000T3_A289PrdEstado, T000T3_n289PrdEstado, T000T3_A308PrdTipPrd,
               T000T3_n308PrdTipPrd, T000T3_A1EmpID, T000T3_A2AgeID, T000T3_A31tipoProdID
               }
               , new Object[] {
               T000T4_A44empdsc, T000T4_n44empdsc
               }
               , new Object[] {
               T000T5_A46AgeDsc, T000T5_n46AgeDsc
               }
               , new Object[] {
               T000T6_A144tipoProdDsc, T000T6_n144tipoProdDsc
               }
               , new Object[] {
               T000T7_A286PrdCod, T000T7_A44empdsc, T000T7_n44empdsc, T000T7_A46AgeDsc, T000T7_n46AgeDsc, T000T7_A309prdNombre, T000T7_n309prdNombre, T000T7_A144tipoProdDsc, T000T7_n144tipoProdDsc, T000T7_A306PrdDescCorta,
               T000T7_n306PrdDescCorta, T000T7_A288PrdPres, T000T7_n288PrdPres, T000T7_A289PrdEstado, T000T7_n289PrdEstado, T000T7_A308PrdTipPrd, T000T7_n308PrdTipPrd, T000T7_A1EmpID, T000T7_A2AgeID, T000T7_A31tipoProdID
               }
               , new Object[] {
               T000T8_A44empdsc, T000T8_n44empdsc
               }
               , new Object[] {
               T000T9_A144tipoProdDsc, T000T9_n144tipoProdDsc
               }
               , new Object[] {
               T000T10_A46AgeDsc, T000T10_n46AgeDsc
               }
               , new Object[] {
               T000T11_A1EmpID, T000T11_A2AgeID, T000T11_A286PrdCod
               }
               , new Object[] {
               T000T12_A1EmpID, T000T12_A2AgeID, T000T12_A286PrdCod
               }
               , new Object[] {
               T000T13_A1EmpID, T000T13_A2AgeID, T000T13_A286PrdCod
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000T17_A44empdsc, T000T17_n44empdsc
               }
               , new Object[] {
               T000T18_A46AgeDsc, T000T18_n46AgeDsc
               }
               , new Object[] {
               T000T19_A144tipoProdDsc, T000T19_n144tipoProdDsc
               }
               , new Object[] {
               T000T20_A1EmpID, T000T20_A2AgeID, T000T20_A364ingreBodNro, T000T20_A369ingreBodDetId
               }
               , new Object[] {
               T000T21_A290stockAnio, T000T21_A291stockMes, T000T21_A1EmpID, T000T21_A2AgeID, T000T21_A42BodCod, T000T21_A286PrdCod
               }
               , new Object[] {
               T000T22_A1EmpID, T000T22_A2AgeID, T000T22_A317OCompNro, T000T22_A311OcTipoCod, T000T22_A342ocDetID
               }
               , new Object[] {
               T000T23_A1EmpID, T000T23_A2AgeID, T000T23_A310ProdPreID, T000T23_A286PrdCod
               }
               , new Object[] {
               T000T24_A1EmpID, T000T24_A2AgeID, T000T24_A42BodCod, T000T24_A264invCod, T000T24_A273detInvId
               }
               , new Object[] {
               T000T25_A1EmpID, T000T25_A2AgeID, T000T25_A286PrdCod
               }
            }
         );
         AV22Pgmname = "Productos";
         Z308PrdTipPrd = 1;
         n308PrdTipPrd = false;
         A308PrdTipPrd = 1;
         n308PrdTipPrd = false;
         i308PrdTipPrd = 1;
         n308PrdTipPrd = false;
      }

      private short wcpOAV18EmpID ;
      private short wcpOAV19AgeID ;
      private short wcpOAV8PrdCod ;
      private short Z1EmpID ;
      private short Z2AgeID ;
      private short Z286PrdCod ;
      private short Z288PrdPres ;
      private short Z308PrdTipPrd ;
      private short Z31tipoProdID ;
      private short N31tipoProdID ;
      private short GxWebError ;
      private short A1EmpID ;
      private short A31tipoProdID ;
      private short A2AgeID ;
      private short AV18EmpID ;
      private short AV19AgeID ;
      private short AV8PrdCod ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short A308PrdTipPrd ;
      private short A288PrdPres ;
      private short A286PrdCod ;
      private short AV14Insert_TipoProdID ;
      private short Gx_BScreen ;
      private short RcdFound72 ;
      private short GX_JID ;
      private short i308PrdTipPrd ;
      private short wbTemp ;
      private int edtEmpID_Visible ;
      private int edtAgeID_Visible ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtempdsc_Enabled ;
      private int edtAgeDsc_Enabled ;
      private int edtEmpID_Enabled ;
      private int imgprompt_1_Visible ;
      private int edtAgeID_Enabled ;
      private int imgprompt_2_Visible ;
      private int edttipoProdID_Enabled ;
      private int imgprompt_31_Visible ;
      private int edttipoProdDsc_Enabled ;
      private int edtPrdCod_Enabled ;
      private int edtprdNombre_Enabled ;
      private int edtPrdDescCorta_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int AV23GXV1 ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z289PrdEstado ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtEmpID_Internalname ;
      private String cmbPrdTipPrd_Internalname ;
      private String cmbPrdPres_Internalname ;
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
      private String divTable2_Internalname ;
      private String divSection2_Internalname ;
      private String edtempdsc_Internalname ;
      private String edtempdsc_Jsonclick ;
      private String divSection3_Internalname ;
      private String edtAgeDsc_Internalname ;
      private String A46AgeDsc ;
      private String edtAgeDsc_Jsonclick ;
      private String edtEmpID_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_1_Internalname ;
      private String imgprompt_1_Link ;
      private String edtAgeID_Internalname ;
      private String edtAgeID_Jsonclick ;
      private String imgprompt_2_Internalname ;
      private String imgprompt_2_Link ;
      private String divTable1_Internalname ;
      private String divSection5_Internalname ;
      private String edttipoProdID_Internalname ;
      private String edttipoProdID_Jsonclick ;
      private String imgprompt_31_Internalname ;
      private String imgprompt_31_Link ;
      private String divSection1_Internalname ;
      private String edttipoProdDsc_Internalname ;
      private String A144tipoProdDsc ;
      private String edttipoProdDsc_Jsonclick ;
      private String edtPrdCod_Internalname ;
      private String edtPrdCod_Jsonclick ;
      private String edtprdNombre_Internalname ;
      private String edtprdNombre_Jsonclick ;
      private String edtPrdDescCorta_Internalname ;
      private String edtPrdDescCorta_Jsonclick ;
      private String cmbPrdTipPrd_Jsonclick ;
      private String cmbPrdPres_Jsonclick ;
      private String chkPrdEstado_Internalname ;
      private String A289PrdEstado ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String AV22Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode72 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z46AgeDsc ;
      private String Z144tipoProdDsc ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n308PrdTipPrd ;
      private bool n288PrdPres ;
      private bool n44empdsc ;
      private bool n46AgeDsc ;
      private bool n144tipoProdDsc ;
      private bool n309prdNombre ;
      private bool n306PrdDescCorta ;
      private bool n289PrdEstado ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private String Z309prdNombre ;
      private String Z306PrdDescCorta ;
      private String A44empdsc ;
      private String A309prdNombre ;
      private String A306PrdDescCorta ;
      private String Z44empdsc ;
      private IGxSession AV11WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbPrdTipPrd ;
      private GXCombobox cmbPrdPres ;
      private GXCheckbox chkPrdEstado ;
      private IDataStoreProvider pr_default ;
      private String[] T000T4_A44empdsc ;
      private bool[] T000T4_n44empdsc ;
      private String[] T000T5_A46AgeDsc ;
      private bool[] T000T5_n46AgeDsc ;
      private String[] T000T6_A144tipoProdDsc ;
      private bool[] T000T6_n144tipoProdDsc ;
      private short[] T000T7_A286PrdCod ;
      private String[] T000T7_A44empdsc ;
      private bool[] T000T7_n44empdsc ;
      private String[] T000T7_A46AgeDsc ;
      private bool[] T000T7_n46AgeDsc ;
      private String[] T000T7_A309prdNombre ;
      private bool[] T000T7_n309prdNombre ;
      private String[] T000T7_A144tipoProdDsc ;
      private bool[] T000T7_n144tipoProdDsc ;
      private String[] T000T7_A306PrdDescCorta ;
      private bool[] T000T7_n306PrdDescCorta ;
      private short[] T000T7_A288PrdPres ;
      private bool[] T000T7_n288PrdPres ;
      private String[] T000T7_A289PrdEstado ;
      private bool[] T000T7_n289PrdEstado ;
      private short[] T000T7_A308PrdTipPrd ;
      private bool[] T000T7_n308PrdTipPrd ;
      private short[] T000T7_A1EmpID ;
      private short[] T000T7_A2AgeID ;
      private short[] T000T7_A31tipoProdID ;
      private String[] T000T8_A44empdsc ;
      private bool[] T000T8_n44empdsc ;
      private String[] T000T9_A144tipoProdDsc ;
      private bool[] T000T9_n144tipoProdDsc ;
      private String[] T000T10_A46AgeDsc ;
      private bool[] T000T10_n46AgeDsc ;
      private short[] T000T11_A1EmpID ;
      private short[] T000T11_A2AgeID ;
      private short[] T000T11_A286PrdCod ;
      private short[] T000T3_A286PrdCod ;
      private String[] T000T3_A309prdNombre ;
      private bool[] T000T3_n309prdNombre ;
      private String[] T000T3_A306PrdDescCorta ;
      private bool[] T000T3_n306PrdDescCorta ;
      private short[] T000T3_A288PrdPres ;
      private bool[] T000T3_n288PrdPres ;
      private String[] T000T3_A289PrdEstado ;
      private bool[] T000T3_n289PrdEstado ;
      private short[] T000T3_A308PrdTipPrd ;
      private bool[] T000T3_n308PrdTipPrd ;
      private short[] T000T3_A1EmpID ;
      private short[] T000T3_A2AgeID ;
      private short[] T000T3_A31tipoProdID ;
      private short[] T000T12_A1EmpID ;
      private short[] T000T12_A2AgeID ;
      private short[] T000T12_A286PrdCod ;
      private short[] T000T13_A1EmpID ;
      private short[] T000T13_A2AgeID ;
      private short[] T000T13_A286PrdCod ;
      private short[] T000T2_A286PrdCod ;
      private String[] T000T2_A309prdNombre ;
      private bool[] T000T2_n309prdNombre ;
      private String[] T000T2_A306PrdDescCorta ;
      private bool[] T000T2_n306PrdDescCorta ;
      private short[] T000T2_A288PrdPres ;
      private bool[] T000T2_n288PrdPres ;
      private String[] T000T2_A289PrdEstado ;
      private bool[] T000T2_n289PrdEstado ;
      private short[] T000T2_A308PrdTipPrd ;
      private bool[] T000T2_n308PrdTipPrd ;
      private short[] T000T2_A1EmpID ;
      private short[] T000T2_A2AgeID ;
      private short[] T000T2_A31tipoProdID ;
      private String[] T000T17_A44empdsc ;
      private bool[] T000T17_n44empdsc ;
      private String[] T000T18_A46AgeDsc ;
      private bool[] T000T18_n46AgeDsc ;
      private String[] T000T19_A144tipoProdDsc ;
      private bool[] T000T19_n144tipoProdDsc ;
      private short[] T000T20_A1EmpID ;
      private short[] T000T20_A2AgeID ;
      private short[] T000T20_A364ingreBodNro ;
      private short[] T000T20_A369ingreBodDetId ;
      private short[] T000T21_A290stockAnio ;
      private short[] T000T21_A291stockMes ;
      private short[] T000T21_A1EmpID ;
      private short[] T000T21_A2AgeID ;
      private short[] T000T21_A42BodCod ;
      private short[] T000T21_A286PrdCod ;
      private short[] T000T22_A1EmpID ;
      private short[] T000T22_A2AgeID ;
      private short[] T000T22_A317OCompNro ;
      private String[] T000T22_A311OcTipoCod ;
      private short[] T000T22_A342ocDetID ;
      private short[] T000T23_A1EmpID ;
      private short[] T000T23_A2AgeID ;
      private short[] T000T23_A310ProdPreID ;
      private short[] T000T23_A286PrdCod ;
      private short[] T000T24_A1EmpID ;
      private short[] T000T24_A2AgeID ;
      private short[] T000T24_A42BodCod ;
      private short[] T000T24_A264invCod ;
      private short[] T000T24_A273detInvId ;
      private short[] T000T25_A1EmpID ;
      private short[] T000T25_A2AgeID ;
      private short[] T000T25_A286PrdCod ;
      private SdtTransactionContext AV10TrnContext ;
      private SdtTransactionContext_Attribute AV13TrnContextAtt ;
   }

   public class productos__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[12])
         ,new UpdateCursor(def[13])
         ,new UpdateCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new ForEachCursor(def[22])
         ,new ForEachCursor(def[23])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000T7 ;
          prmT000T7 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000T4 ;
          prmT000T4 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000T6 ;
          prmT000T6 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000T5 ;
          prmT000T5 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000T8 ;
          prmT000T8 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000T9 ;
          prmT000T9 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000T10 ;
          prmT000T10 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000T11 ;
          prmT000T11 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000T3 ;
          prmT000T3 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000T12 ;
          prmT000T12 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000T13 ;
          prmT000T13 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000T2 ;
          prmT000T2 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000T14 ;
          prmT000T14 = new Object[] {
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@prdNombre",SqlDbType.VarChar,80,0} ,
          new Object[] {"@PrdDescCorta",SqlDbType.VarChar,40,0} ,
          new Object[] {"@PrdPres",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@PrdEstado",SqlDbType.Char,1,0} ,
          new Object[] {"@PrdTipPrd",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000T15 ;
          prmT000T15 = new Object[] {
          new Object[] {"@prdNombre",SqlDbType.VarChar,80,0} ,
          new Object[] {"@PrdDescCorta",SqlDbType.VarChar,40,0} ,
          new Object[] {"@PrdPres",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@PrdEstado",SqlDbType.Char,1,0} ,
          new Object[] {"@PrdTipPrd",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000T16 ;
          prmT000T16 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000T20 ;
          prmT000T20 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000T21 ;
          prmT000T21 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000T22 ;
          prmT000T22 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000T23 ;
          prmT000T23 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000T24 ;
          prmT000T24 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000T25 ;
          prmT000T25 = new Object[] {
          } ;
          Object[] prmT000T17 ;
          prmT000T17 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000T18 ;
          prmT000T18 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000T19 ;
          prmT000T19 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000T2", "SELECT [PrdCod], [prdNombre], [PrdDescCorta], [PrdPres], [PrdEstado], [PrdTipPrd], [EmpID], [AgeID], [tipoProdID] FROM [Productos] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T2,1,0,true,false )
             ,new CursorDef("T000T3", "SELECT [PrdCod], [prdNombre], [PrdDescCorta], [PrdPres], [PrdEstado], [PrdTipPrd], [EmpID], [AgeID], [tipoProdID] FROM [Productos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T3,1,0,true,false )
             ,new CursorDef("T000T4", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T4,1,0,true,false )
             ,new CursorDef("T000T5", "SELECT [AgeDsc] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T5,1,0,true,false )
             ,new CursorDef("T000T6", "SELECT [tipoProdDsc] FROM [TipoProducto] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [tipoProdID] = @tipoProdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T6,1,0,true,false )
             ,new CursorDef("T000T7", "SELECT TM1.[PrdCod], T2.[empdsc], T3.[AgeDsc], TM1.[prdNombre], T4.[tipoProdDsc], TM1.[PrdDescCorta], TM1.[PrdPres], TM1.[PrdEstado], TM1.[PrdTipPrd], TM1.[EmpID], TM1.[AgeID], TM1.[tipoProdID] FROM ((([Productos] TM1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = TM1.[EmpID]) INNER JOIN [Agencias] T3 WITH (NOLOCK) ON T3.[EmpID] = TM1.[EmpID] AND T3.[AgeID] = TM1.[AgeID]) INNER JOIN [TipoProducto] T4 WITH (NOLOCK) ON T4.[EmpID] = TM1.[EmpID] AND T4.[tipoProdID] = TM1.[tipoProdID]) WHERE TM1.[EmpID] = @EmpID and TM1.[AgeID] = @AgeID and TM1.[PrdCod] = @PrdCod ORDER BY TM1.[EmpID], TM1.[AgeID], TM1.[PrdCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000T7,100,0,true,false )
             ,new CursorDef("T000T8", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T8,1,0,true,false )
             ,new CursorDef("T000T9", "SELECT [tipoProdDsc] FROM [TipoProducto] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [tipoProdID] = @tipoProdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T9,1,0,true,false )
             ,new CursorDef("T000T10", "SELECT [AgeDsc] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T10,1,0,true,false )
             ,new CursorDef("T000T11", "SELECT [EmpID], [AgeID], [PrdCod] FROM [Productos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [PrdCod] = @PrdCod  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000T11,1,0,true,false )
             ,new CursorDef("T000T12", "SELECT TOP 1 [EmpID], [AgeID], [PrdCod] FROM [Productos] WITH (NOLOCK) WHERE ( [EmpID] > @EmpID or [EmpID] = @EmpID and [AgeID] > @AgeID or [AgeID] = @AgeID and [EmpID] = @EmpID and [PrdCod] > @PrdCod) ORDER BY [EmpID], [AgeID], [PrdCod]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000T12,1,0,true,true )
             ,new CursorDef("T000T13", "SELECT TOP 1 [EmpID], [AgeID], [PrdCod] FROM [Productos] WITH (NOLOCK) WHERE ( [EmpID] < @EmpID or [EmpID] = @EmpID and [AgeID] < @AgeID or [AgeID] = @AgeID and [EmpID] = @EmpID and [PrdCod] < @PrdCod) ORDER BY [EmpID] DESC, [AgeID] DESC, [PrdCod] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000T13,1,0,true,true )
             ,new CursorDef("T000T14", "INSERT INTO [Productos]([PrdCod], [prdNombre], [PrdDescCorta], [PrdPres], [PrdEstado], [PrdTipPrd], [EmpID], [AgeID], [tipoProdID]) VALUES(@PrdCod, @prdNombre, @PrdDescCorta, @PrdPres, @PrdEstado, @PrdTipPrd, @EmpID, @AgeID, @tipoProdID)", GxErrorMask.GX_NOMASK,prmT000T14)
             ,new CursorDef("T000T15", "UPDATE [Productos] SET [prdNombre]=@prdNombre, [PrdDescCorta]=@PrdDescCorta, [PrdPres]=@PrdPres, [PrdEstado]=@PrdEstado, [PrdTipPrd]=@PrdTipPrd, [tipoProdID]=@tipoProdID  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [PrdCod] = @PrdCod", GxErrorMask.GX_NOMASK,prmT000T15)
             ,new CursorDef("T000T16", "DELETE FROM [Productos]  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [PrdCod] = @PrdCod", GxErrorMask.GX_NOMASK,prmT000T16)
             ,new CursorDef("T000T17", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T17,1,0,true,false )
             ,new CursorDef("T000T18", "SELECT [AgeDsc] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T18,1,0,true,false )
             ,new CursorDef("T000T19", "SELECT [tipoProdDsc] FROM [TipoProducto] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [tipoProdID] = @tipoProdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T19,1,0,true,false )
             ,new CursorDef("T000T20", "SELECT TOP 1 [EmpID], [AgeID], [ingreBodNro], [ingreBodDetId] FROM [IngresoBodegasingreBodDet] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T20,1,0,true,true )
             ,new CursorDef("T000T21", "SELECT TOP 1 [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod] FROM [ProdxBodega] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T21,1,0,true,true )
             ,new CursorDef("T000T22", "SELECT TOP 1 [EmpID], [AgeID], [OCompNro], [OcTipoCod], [ocDetID] FROM [OrdenCompraocDet] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T22,1,0,true,true )
             ,new CursorDef("T000T23", "SELECT TOP 1 [EmpID], [AgeID], [ProdPreID], [PrdCod] FROM [ProdPrecio] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T23,1,0,true,true )
             ,new CursorDef("T000T24", "SELECT TOP 1 [EmpID], [AgeID], [BodCod], [invCod], [detInvId] FROM [InventariodetInv] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T24,1,0,true,true )
             ,new CursorDef("T000T25", "SELECT [EmpID], [AgeID], [PrdCod] FROM [Productos] WITH (NOLOCK) ORDER BY [EmpID], [AgeID], [PrdCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000T25,100,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 1) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((short[]) buf[11])[0] = rslt.getShort(7) ;
                ((short[]) buf[12])[0] = rslt.getShort(8) ;
                ((short[]) buf[13])[0] = rslt.getShort(9) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 1) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((short[]) buf[11])[0] = rslt.getShort(7) ;
                ((short[]) buf[12])[0] = rslt.getShort(8) ;
                ((short[]) buf[13])[0] = rslt.getShort(9) ;
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
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 40) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((short[]) buf[11])[0] = rslt.getShort(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((String[]) buf[13])[0] = rslt.getString(8, 1) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((short[]) buf[15])[0] = rslt.getShort(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((short[]) buf[17])[0] = rslt.getShort(10) ;
                ((short[]) buf[18])[0] = rslt.getShort(11) ;
                ((short[]) buf[19])[0] = rslt.getShort(12) ;
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
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 18 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 19 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 20 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 3) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 21 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 22 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
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
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
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
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
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
                   stmt.setNull( 3 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 4 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(4, (short)parms[6]);
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
                   stmt.setNull( 6 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(6, (short)parms[10]);
                }
                stmt.SetParameter(7, (short)parms[11]);
                stmt.SetParameter(8, (short)parms[12]);
                stmt.SetParameter(9, (short)parms[13]);
                return;
             case 13 :
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
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[5]);
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
                   stmt.setNull( 5 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(5, (short)parms[9]);
                }
                stmt.SetParameter(6, (short)parms[10]);
                stmt.SetParameter(7, (short)parms[11]);
                stmt.SetParameter(8, (short)parms[12]);
                stmt.SetParameter(9, (short)parms[13]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
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
                return;
             case 20 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
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
       }
    }

 }

}
