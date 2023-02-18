/*
               File: OrdenPedido
        Description: Orden Pedido
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 11/19/2022 22:53:2.68
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
   public class ordenpedido : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_18") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_18( A1EmpID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_20") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A36detTipoProdID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_20( A1EmpID, A36detTipoProdID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_21") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A32categID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_21( A1EmpID, A32categID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_22") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A32categID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            A33subCatID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_22( A1EmpID, A32categID, A33subCatID) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridordenpedido_opid") == 0 )
         {
            nRC_GXsfl_73 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_73_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_73_idx = GetNextPar( );
            A207PedUltNro = (int)(NumberUtil.Val( GetNextPar( ), "."));
            n207PedUltNro = false;
            Gx_BScreen = (short)(NumberUtil.Val( GetNextPar( ), "."));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridordenpedido_opid_newrow( ) ;
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
               AV10EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10EmpID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10EmpID), "ZZZ9"), context));
               AV7PedCod = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7PedCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7PedCod), 8, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vPEDCOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7PedCod), "ZZZZZZZ9"), context));
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
            Form.Meta.addItem("description", "Orden Pedido", 0) ;
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

      public ordenpedido( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public ordenpedido( IGxContext context )
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
                           int aP2_PedCod )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV10EmpID = aP1_EmpID;
         this.AV7PedCod = aP2_PedCod;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkPedEst = new GXCheckbox();
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2 col-lg-10 col-lg-offset-1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTitlecontainer_Internalname, 1, 0, "px", 0, "px", "TableTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Orden Pedido", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_OrdenPedido.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2 col-lg-10 col-lg-offset-1", "left", "top", "", "", "div");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenPedido.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenPedido.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenPedido.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenPedido.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx00w0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"PEDCOD"+"'), id:'"+"PEDCOD"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_OrdenPedido.htm");
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
            GxWebStd.gx_single_line_edit( context, edtEmpID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEmpID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEmpID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_OrdenPedido.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_1_Internalname, sImgUrl, imgprompt_1_Link, "", "", context.GetTheme( ), imgprompt_1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_OrdenPedido.htm");
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
            GxWebStd.gx_single_line_edit( context, edtempdsc_Internalname, A44empdsc, StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempdsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtempdsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_OrdenPedido.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPedCod_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPedCod_Internalname, "Codigo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPedCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A39PedCod), 8, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A39PedCod), "ZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPedCod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPedCod_Enabled, 1, "number", "1", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_OrdenPedido.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPedDescripcion_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPedDescripcion_Internalname, "Descripcion", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtPedDescripcion_Internalname, StringUtil.RTrim( A204PedDescripcion), "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", 0, 1, edtPedDescripcion_Enabled, 0, 50, "chr", 3, "row", StyleString, ClassString, "", "", "50", 1, 3, "", "", -1, true, "Descripcion", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_OrdenPedido.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPedFchReg_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPedFchReg_Internalname, "Registro", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtPedFchReg_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtPedFchReg_Internalname, context.localUtil.Format(A205PedFchReg, "99/99/9999"), context.localUtil.Format( A205PedFchReg, "99/99/9999"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPedFchReg_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPedFchReg_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_OrdenPedido.htm");
            GxWebStd.gx_bitmap( context, edtPedFchReg_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtPedFchReg_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_OrdenPedido.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkPedEst_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkPedEst_Internalname, "Estado", "col-sm-3 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkPedEst_Internalname, A206PedEst, "", "Estado", 1, chkPedEst.Enabled, "A", "Activo?", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(59, this, 'A', 'I');gx.evt.onchange(this, event);\" ");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPedUltNro_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPedUltNro_Internalname, "Nro", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtPedUltNro_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A207PedUltNro), 8, 0, ",", "")), ((edtPedUltNro_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A207PedUltNro), "ZZZZZZZ9")) : context.localUtil.Format( (decimal)(A207PedUltNro), "ZZZZZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPedUltNro_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPedUltNro_Enabled, 0, "number", "1", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_OrdenPedido.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divOpidtable_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitleopid_Internalname, "Items - Pedidos", "", "", lblTitleopid_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_OrdenPedido.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Gridordenpedido_opid( ) ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenPedido.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenPedido.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 95,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenPedido.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm0D32( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void gxdraw_Gridordenpedido_opid( )
      {
         /*  Grid Control  */
         Gridordenpedido_opidContainer.AddObjectProperty("GridName", "Gridordenpedido_opid");
         Gridordenpedido_opidContainer.AddObjectProperty("Header", subGridordenpedido_opid_Header);
         Gridordenpedido_opidContainer.AddObjectProperty("Class", "Grid");
         Gridordenpedido_opidContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridordenpedido_opidContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridordenpedido_opidContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridordenpedido_opid_Backcolorstyle), 1, 0, ".", "")));
         Gridordenpedido_opidContainer.AddObjectProperty("Sortable", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridordenpedido_opid_Sortable), 1, 0, ".", "")));
         Gridordenpedido_opidContainer.AddObjectProperty("CmpContext", "");
         Gridordenpedido_opidContainer.AddObjectProperty("InMasterPage", "false");
         Gridordenpedido_opidColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridordenpedido_opidColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A40OPIdSec), 8, 0, ".", "")));
         Gridordenpedido_opidColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOPIdSec_Enabled), 5, 0, ".", "")));
         Gridordenpedido_opidContainer.AddColumnProperties(Gridordenpedido_opidColumn);
         Gridordenpedido_opidColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridordenpedido_opidColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A36detTipoProdID), 4, 0, ".", "")));
         Gridordenpedido_opidColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetTipoProdID_Enabled), 5, 0, ".", "")));
         Gridordenpedido_opidContainer.AddColumnProperties(Gridordenpedido_opidColumn);
         Gridordenpedido_opidColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridordenpedido_opidContainer.AddColumnProperties(Gridordenpedido_opidColumn);
         Gridordenpedido_opidColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridordenpedido_opidColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A32categID), 4, 0, ".", "")));
         Gridordenpedido_opidColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcategID_Enabled), 5, 0, ".", "")));
         Gridordenpedido_opidContainer.AddColumnProperties(Gridordenpedido_opidColumn);
         Gridordenpedido_opidColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridordenpedido_opidContainer.AddColumnProperties(Gridordenpedido_opidColumn);
         Gridordenpedido_opidColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridordenpedido_opidColumn.AddObjectProperty("Value", StringUtil.RTrim( A146categDsc));
         Gridordenpedido_opidColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcategDsc_Enabled), 5, 0, ".", "")));
         Gridordenpedido_opidContainer.AddColumnProperties(Gridordenpedido_opidColumn);
         Gridordenpedido_opidColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridordenpedido_opidColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A33subCatID), 4, 0, ".", "")));
         Gridordenpedido_opidColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatID_Enabled), 5, 0, ".", "")));
         Gridordenpedido_opidContainer.AddColumnProperties(Gridordenpedido_opidColumn);
         Gridordenpedido_opidColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridordenpedido_opidContainer.AddColumnProperties(Gridordenpedido_opidColumn);
         Gridordenpedido_opidColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridordenpedido_opidColumn.AddObjectProperty("Value", StringUtil.RTrim( A148subCatDsc));
         Gridordenpedido_opidColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatDsc_Enabled), 5, 0, ".", "")));
         Gridordenpedido_opidContainer.AddColumnProperties(Gridordenpedido_opidColumn);
         Gridordenpedido_opidColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridordenpedido_opidColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A150subCatPrec, 8, 2, ".", "")));
         Gridordenpedido_opidColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatPrec_Enabled), 5, 0, ".", "")));
         Gridordenpedido_opidContainer.AddColumnProperties(Gridordenpedido_opidColumn);
         Gridordenpedido_opidColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridordenpedido_opidColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A151subCatPeso, 8, 2, ".", "")));
         Gridordenpedido_opidColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatPeso_Enabled), 5, 0, ".", "")));
         Gridordenpedido_opidContainer.AddColumnProperties(Gridordenpedido_opidColumn);
         Gridordenpedido_opidColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridordenpedido_opidColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A211subCatDisp), 8, 0, ".", "")));
         Gridordenpedido_opidColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatDisp_Enabled), 5, 0, ".", "")));
         Gridordenpedido_opidContainer.AddColumnProperties(Gridordenpedido_opidColumn);
         Gridordenpedido_opidColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridordenpedido_opidColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A212cantDetPed, 8, 2, ".", "")));
         Gridordenpedido_opidColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcantDetPed_Enabled), 5, 0, ".", "")));
         Gridordenpedido_opidContainer.AddColumnProperties(Gridordenpedido_opidColumn);
         Gridordenpedido_opidColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridordenpedido_opidColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A214PedDetSaldo, 9, 2, ".", "")));
         Gridordenpedido_opidColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPedDetSaldo_Enabled), 5, 0, ".", "")));
         Gridordenpedido_opidContainer.AddColumnProperties(Gridordenpedido_opidColumn);
         Gridordenpedido_opidColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridordenpedido_opidColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A213cantDetaPed, 8, 2, ".", "")));
         Gridordenpedido_opidColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcantDetaPed_Enabled), 5, 0, ".", "")));
         Gridordenpedido_opidContainer.AddColumnProperties(Gridordenpedido_opidColumn);
         Gridordenpedido_opidColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridordenpedido_opidColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A216PedTotal, 8, 2, ".", "")));
         Gridordenpedido_opidColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPedTotal_Enabled), 5, 0, ".", "")));
         Gridordenpedido_opidContainer.AddColumnProperties(Gridordenpedido_opidColumn);
         Gridordenpedido_opidContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridordenpedido_opid_Selectedindex), 4, 0, ".", "")));
         Gridordenpedido_opidContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridordenpedido_opid_Allowselection), 1, 0, ".", "")));
         Gridordenpedido_opidContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridordenpedido_opid_Selectioncolor), 9, 0, ".", "")));
         Gridordenpedido_opidContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridordenpedido_opid_Allowhovering), 1, 0, ".", "")));
         Gridordenpedido_opidContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridordenpedido_opid_Hoveringcolor), 9, 0, ".", "")));
         Gridordenpedido_opidContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridordenpedido_opid_Allowcollapsing), 1, 0, ".", "")));
         Gridordenpedido_opidContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridordenpedido_opid_Collapsed), 1, 0, ".", "")));
         nGXsfl_73_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount33 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_33 = 1;
               ScanStart0D33( ) ;
               while ( RcdFound33 != 0 )
               {
                  init_level_properties33( ) ;
                  getByPrimaryKey0D33( ) ;
                  AddRow0D33( ) ;
                  ScanNext0D33( ) ;
               }
               ScanEnd0D33( ) ;
               nBlankRcdCount33 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            B207PedUltNro = A207PedUltNro;
            n207PedUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PedUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PedUltNro), 8, 0)));
            standaloneNotModal0D33( ) ;
            standaloneModal0D33( ) ;
            sMode33 = Gx_mode;
            while ( nGXsfl_73_idx < nRC_GXsfl_73 )
            {
               bGXsfl_73_Refreshing = true;
               ReadRow0D33( ) ;
               edtOPIdSec_Enabled = (int)(context.localUtil.CToN( cgiGet( "OPIDSEC_"+sGXsfl_73_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOPIdSec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOPIdSec_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
               edtdetTipoProdID_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETTIPOPRODID_"+sGXsfl_73_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetTipoProdID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetTipoProdID_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
               edtcategID_Enabled = (int)(context.localUtil.CToN( cgiGet( "CATEGID_"+sGXsfl_73_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcategID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcategID_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
               edtcategDsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "CATEGDSC_"+sGXsfl_73_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcategDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcategDsc_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
               edtsubCatID_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATID_"+sGXsfl_73_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatID_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
               edtsubCatDsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATDSC_"+sGXsfl_73_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatDsc_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
               edtsubCatPrec_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATPREC_"+sGXsfl_73_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatPrec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatPrec_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
               edtsubCatPeso_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATPESO_"+sGXsfl_73_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatPeso_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatPeso_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
               edtsubCatDisp_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATDISP_"+sGXsfl_73_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatDisp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatDisp_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
               edtcantDetPed_Enabled = (int)(context.localUtil.CToN( cgiGet( "CANTDETPED_"+sGXsfl_73_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcantDetPed_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcantDetPed_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
               edtPedDetSaldo_Enabled = (int)(context.localUtil.CToN( cgiGet( "PEDDETSALDO_"+sGXsfl_73_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedDetSaldo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedDetSaldo_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
               edtcantDetaPed_Enabled = (int)(context.localUtil.CToN( cgiGet( "CANTDETAPED_"+sGXsfl_73_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcantDetaPed_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcantDetaPed_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
               edtPedTotal_Enabled = (int)(context.localUtil.CToN( cgiGet( "PEDTOTAL_"+sGXsfl_73_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedTotal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedTotal_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
               imgprompt_1_Link = cgiGet( "PROMPT_36_"+sGXsfl_73_idx+"Link");
               imgprompt_1_Link = cgiGet( "PROMPT_32_"+sGXsfl_73_idx+"Link");
               imgprompt_1_Link = cgiGet( "PROMPT_33_"+sGXsfl_73_idx+"Link");
               if ( ( nRcdExists_33 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal0D33( ) ;
               }
               SendRow0D33( ) ;
               bGXsfl_73_Refreshing = false;
            }
            Gx_mode = sMode33;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A207PedUltNro = B207PedUltNro;
            n207PedUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PedUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PedUltNro), 8, 0)));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount33 = 5;
            nRcdExists_33 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart0D33( ) ;
               while ( RcdFound33 != 0 )
               {
                  sGXsfl_73_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_73_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_7333( ) ;
                  init_level_properties33( ) ;
                  standaloneNotModal0D33( ) ;
                  getByPrimaryKey0D33( ) ;
                  standaloneModal0D33( ) ;
                  AddRow0D33( ) ;
                  ScanNext0D33( ) ;
               }
               ScanEnd0D33( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode33 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_73_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_73_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_7333( ) ;
            InitAll0D33( ) ;
            init_level_properties33( ) ;
            B207PedUltNro = A207PedUltNro;
            n207PedUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PedUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PedUltNro), 8, 0)));
            standaloneNotModal0D33( ) ;
            standaloneModal0D33( ) ;
            nRcdExists_33 = 0;
            nIsMod_33 = 0;
            nRcdDeleted_33 = 0;
            nBlankRcdCount33 = (short)(nBlankRcdUsr33+nBlankRcdCount33);
            fRowAdded = 0;
            while ( nBlankRcdCount33 > 0 )
            {
               AddRow0D33( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtdetTipoProdID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount33 = (short)(nBlankRcdCount33-1);
            }
            Gx_mode = sMode33;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A207PedUltNro = B207PedUltNro;
            n207PedUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PedUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PedUltNro), 8, 0)));
         }
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridordenpedido_opidContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridordenpedido_opid", Gridordenpedido_opidContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridordenpedido_opidContainerData", Gridordenpedido_opidContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridordenpedido_opidContainerData"+"V", Gridordenpedido_opidContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridordenpedido_opidContainerData"+"V"+"\" value='"+Gridordenpedido_opidContainer.GridValuesHidden()+"'/>") ;
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
         E110D2 ();
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtPedCod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtPedCod_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PEDCOD");
                  AnyError = 1;
                  GX_FocusControl = edtPedCod_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A39PedCod = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A39PedCod), 8, 0)));
               }
               else
               {
                  A39PedCod = (int)(context.localUtil.CToN( cgiGet( edtPedCod_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A39PedCod), 8, 0)));
               }
               A204PedDescripcion = cgiGet( edtPedDescripcion_Internalname);
               n204PedDescripcion = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A204PedDescripcion", A204PedDescripcion);
               n204PedDescripcion = (String.IsNullOrEmpty(StringUtil.RTrim( A204PedDescripcion)) ? true : false);
               if ( context.localUtil.VCDate( cgiGet( edtPedFchReg_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha Registro"}), 1, "PEDFCHREG");
                  AnyError = 1;
                  GX_FocusControl = edtPedFchReg_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A205PedFchReg = DateTime.MinValue;
                  n205PedFchReg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A205PedFchReg", context.localUtil.Format(A205PedFchReg, "99/99/9999"));
               }
               else
               {
                  A205PedFchReg = context.localUtil.CToD( cgiGet( edtPedFchReg_Internalname), 2);
                  n205PedFchReg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A205PedFchReg", context.localUtil.Format(A205PedFchReg, "99/99/9999"));
               }
               n205PedFchReg = ((DateTime.MinValue==A205PedFchReg) ? true : false);
               A206PedEst = ((StringUtil.StrCmp(cgiGet( chkPedEst_Internalname), "A")==0) ? "A" : "I");
               n206PedEst = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A206PedEst", A206PedEst);
               n206PedEst = (String.IsNullOrEmpty(StringUtil.RTrim( A206PedEst)) ? true : false);
               A207PedUltNro = (int)(context.localUtil.CToN( cgiGet( edtPedUltNro_Internalname), ",", "."));
               n207PedUltNro = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PedUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PedUltNro), 8, 0)));
               /* Read saved values. */
               Z1EmpID = (short)(context.localUtil.CToN( cgiGet( "Z1EmpID"), ",", "."));
               Z39PedCod = (int)(context.localUtil.CToN( cgiGet( "Z39PedCod"), ",", "."));
               Z204PedDescripcion = cgiGet( "Z204PedDescripcion");
               n204PedDescripcion = (String.IsNullOrEmpty(StringUtil.RTrim( A204PedDescripcion)) ? true : false);
               Z205PedFchReg = context.localUtil.CToD( cgiGet( "Z205PedFchReg"), 0);
               n205PedFchReg = ((DateTime.MinValue==A205PedFchReg) ? true : false);
               Z206PedEst = cgiGet( "Z206PedEst");
               n206PedEst = (String.IsNullOrEmpty(StringUtil.RTrim( A206PedEst)) ? true : false);
               Z207PedUltNro = (int)(context.localUtil.CToN( cgiGet( "Z207PedUltNro"), ",", "."));
               n207PedUltNro = ((0==A207PedUltNro) ? true : false);
               O207PedUltNro = (int)(context.localUtil.CToN( cgiGet( "O207PedUltNro"), ",", "."));
               n207PedUltNro = ((0==A207PedUltNro) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_73 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_73"), ",", "."));
               AV10EmpID = (short)(context.localUtil.CToN( cgiGet( "vEMPID"), ",", "."));
               AV7PedCod = (int)(context.localUtil.CToN( cgiGet( "vPEDCOD"), ",", "."));
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ",", "."));
               AV11fecha = context.localUtil.CToD( cgiGet( "vFECHA"), 0);
               AV24Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               A31tipoProdID = (short)(context.localUtil.CToN( cgiGet( "TIPOPRODID"), ",", "."));
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "OrdenPedido";
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format(AV11fecha, "99/99/9999");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A1EmpID != Z1EmpID ) || ( A39PedCod != Z39PedCod ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("ordenpedido:[SecurityCheckFailed value for]"+"fecha:"+context.localUtil.Format(AV11fecha, "99/99/9999"));
                  GXUtil.WriteLog("ordenpedido:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A39PedCod = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A39PedCod), 8, 0)));
                  getEqualNoModal( ) ;
                  if ( ! (0==AV7PedCod) )
                  {
                     A39PedCod = AV7PedCod;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A39PedCod), 8, 0)));
                  }
                  else
                  {
                     if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
                     {
                        A39PedCod = AV7PedCod;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A39PedCod), 8, 0)));
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
                     sMode32 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     if ( ! (0==AV7PedCod) )
                     {
                        A39PedCod = AV7PedCod;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A39PedCod), 8, 0)));
                     }
                     else
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
                        {
                           A39PedCod = AV7PedCod;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A39PedCod), 8, 0)));
                        }
                     }
                     Gx_mode = sMode32;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound32 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0D0( ) ;
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
                        E110D2 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: After Trn */
                        E120D2 ();
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
            E120D2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0D32( ) ;
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
            DisableAttributes0D32( ) ;
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

      protected void CONFIRM_0D0( )
      {
         BeforeValidate0D32( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0D32( ) ;
            }
            else
            {
               CheckExtendedTable0D32( ) ;
               CloseExtendedTableCursors0D32( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode32 = Gx_mode;
            CONFIRM_0D33( ) ;
            if ( AnyError == 0 )
            {
               /* Restore parent mode. */
               Gx_mode = sMode32;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
               IsConfirmed = 1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
            }
            /* Restore parent mode. */
            Gx_mode = sMode32;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
      }

      protected void CONFIRM_0D33( )
      {
         s207PedUltNro = O207PedUltNro;
         n207PedUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PedUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PedUltNro), 8, 0)));
         nGXsfl_73_idx = 0;
         while ( nGXsfl_73_idx < nRC_GXsfl_73 )
         {
            ReadRow0D33( ) ;
            if ( ( nRcdExists_33 != 0 ) || ( nIsMod_33 != 0 ) )
            {
               GetKey0D33( ) ;
               if ( ( nRcdExists_33 == 0 ) && ( nRcdDeleted_33 == 0 ) )
               {
                  if ( RcdFound33 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate0D33( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0D33( ) ;
                        CloseExtendedTableCursors0D33( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                        O207PedUltNro = A207PedUltNro;
                        n207PedUltNro = false;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PedUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PedUltNro), 8, 0)));
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "EMPID");
                     AnyError = 1;
                     GX_FocusControl = edtEmpID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound33 != 0 )
                  {
                     if ( nRcdDeleted_33 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey0D33( ) ;
                        Load0D33( ) ;
                        BeforeValidate0D33( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0D33( ) ;
                           O207PedUltNro = A207PedUltNro;
                           n207PedUltNro = false;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PedUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PedUltNro), 8, 0)));
                        }
                     }
                     else
                     {
                        if ( nIsMod_33 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate0D33( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0D33( ) ;
                              CloseExtendedTableCursors0D33( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                              }
                              O207PedUltNro = A207PedUltNro;
                              n207PedUltNro = false;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PedUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PedUltNro), 8, 0)));
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_33 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "EMPID");
                        AnyError = 1;
                        GX_FocusControl = edtEmpID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtOPIdSec_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A40OPIdSec), 8, 0, ",", ""))) ;
            ChangePostValue( edtdetTipoProdID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A36detTipoProdID), 4, 0, ",", ""))) ;
            ChangePostValue( edtcategID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A32categID), 4, 0, ",", ""))) ;
            ChangePostValue( edtcategDsc_Internalname, StringUtil.RTrim( A146categDsc)) ;
            ChangePostValue( edtsubCatID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A33subCatID), 4, 0, ",", ""))) ;
            ChangePostValue( edtsubCatDsc_Internalname, StringUtil.RTrim( A148subCatDsc)) ;
            ChangePostValue( edtsubCatPrec_Internalname, StringUtil.LTrim( StringUtil.NToC( A150subCatPrec, 8, 2, ",", ""))) ;
            ChangePostValue( edtsubCatPeso_Internalname, StringUtil.LTrim( StringUtil.NToC( A151subCatPeso, 8, 2, ",", ""))) ;
            ChangePostValue( edtsubCatDisp_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A211subCatDisp), 8, 0, ",", ""))) ;
            ChangePostValue( edtcantDetPed_Internalname, StringUtil.LTrim( StringUtil.NToC( A212cantDetPed, 8, 2, ",", ""))) ;
            ChangePostValue( edtPedDetSaldo_Internalname, StringUtil.LTrim( StringUtil.NToC( A214PedDetSaldo, 9, 2, ",", ""))) ;
            ChangePostValue( edtcantDetaPed_Internalname, StringUtil.LTrim( StringUtil.NToC( A213cantDetaPed, 8, 2, ",", ""))) ;
            ChangePostValue( edtPedTotal_Internalname, StringUtil.LTrim( StringUtil.NToC( A216PedTotal, 8, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z40OPIdSec_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z40OPIdSec), 8, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z212cantDetPed_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( Z212cantDetPed, 8, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z213cantDetaPed_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( Z213cantDetaPed, 8, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z36detTipoProdID_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z36detTipoProdID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z32categID_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z32categID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z33subCatID_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z33subCatID), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_33_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_33), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_33_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_33), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_33_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_33), 4, 0, ",", ""))) ;
            if ( nIsMod_33 != 0 )
            {
               ChangePostValue( "OPIDSEC_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOPIdSec_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETTIPOPRODID_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetTipoProdID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CATEGID_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcategID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CATEGDSC_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcategDsc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATID_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATDSC_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatDsc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATPREC_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatPrec_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATPESO_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatPeso_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATDISP_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatDisp_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CANTDETPED_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcantDetPed_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PEDDETSALDO_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPedDetSaldo_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CANTDETAPED_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcantDetaPed_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PEDTOTAL_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPedTotal_Enabled), 5, 0, ".", ""))) ;
            }
         }
         O207PedUltNro = s207PedUltNro;
         n207PedUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PedUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PedUltNro), 8, 0)));
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption0D0( )
      {
      }

      protected void E110D2( )
      {
         /* Start Routine */
         AV11fecha = DateTimeUtil.ResetTime(DateTimeUtil.ServerNow( context, pr_default));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11fecha", context.localUtil.Format(AV11fecha, "99/99/9999"));
         if ( ! new isauthorized(context).executeUdp(  AV24Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV24Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV20TrnContext.FromXml(AV22WebSession.Get("TrnContext"), null, "TransactionContext", "KBCalpesa22");
      }

      protected void E120D2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV20TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwordenpedido.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0D32( short GX_JID )
      {
         if ( ( GX_JID == 17 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z204PedDescripcion = T000D9_A204PedDescripcion[0];
               Z205PedFchReg = T000D9_A205PedFchReg[0];
               Z206PedEst = T000D9_A206PedEst[0];
               Z207PedUltNro = T000D9_A207PedUltNro[0];
            }
            else
            {
               Z204PedDescripcion = A204PedDescripcion;
               Z205PedFchReg = A205PedFchReg;
               Z206PedEst = A206PedEst;
               Z207PedUltNro = A207PedUltNro;
            }
         }
         if ( GX_JID == -17 )
         {
            Z39PedCod = A39PedCod;
            Z204PedDescripcion = A204PedDescripcion;
            Z205PedFchReg = A205PedFchReg;
            Z206PedEst = A206PedEst;
            Z207PedUltNro = A207PedUltNro;
            Z1EmpID = A1EmpID;
            Z44empdsc = A44empdsc;
         }
      }

      protected void standaloneNotModal( )
      {
         edtPedUltNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedUltNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedUltNro_Enabled), 5, 0)), true);
         Gx_BScreen = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         imgprompt_1_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         edtPedUltNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedUltNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedUltNro_Enabled), 5, 0)), true);
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV10EmpID) )
         {
            A1EmpID = AV10EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         }
         if ( ! (0==AV10EmpID) )
         {
            edtEmpID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         }
         else
         {
            edtEmpID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV10EmpID) )
         {
            edtEmpID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV7PedCod) )
         {
            edtPedCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedCod_Enabled), 5, 0)), true);
         }
         else
         {
            edtPedCod_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedCod_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV7PedCod) )
         {
            edtPedCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedCod_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ! (0==AV7PedCod) )
         {
            A39PedCod = AV7PedCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A39PedCod), 8, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
            {
               A39PedCod = AV7PedCod;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A39PedCod), 8, 0)));
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && String.IsNullOrEmpty(StringUtil.RTrim( A206PedEst)) && ( Gx_BScreen == 0 ) )
         {
            A206PedEst = "A";
            n206PedEst = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A206PedEst", A206PedEst);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (DateTime.MinValue==A205PedFchReg) && ( Gx_BScreen == 0 ) )
         {
            A205PedFchReg = AV11fecha;
            n205PedFchReg = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A205PedFchReg", context.localUtil.Format(A205PedFchReg, "99/99/9999"));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            /* Using cursor T000D10 */
            pr_default.execute(8, new Object[] {A1EmpID});
            A44empdsc = T000D10_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000D10_n44empdsc[0];
            pr_default.close(8);
            AV24Pgmname = "OrdenPedido";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24Pgmname", AV24Pgmname);
         }
      }

      protected void Load0D32( )
      {
         /* Using cursor T000D11 */
         pr_default.execute(9, new Object[] {A1EmpID, A39PedCod});
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound32 = 1;
            A44empdsc = T000D11_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000D11_n44empdsc[0];
            A204PedDescripcion = T000D11_A204PedDescripcion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A204PedDescripcion", A204PedDescripcion);
            n204PedDescripcion = T000D11_n204PedDescripcion[0];
            A205PedFchReg = T000D11_A205PedFchReg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A205PedFchReg", context.localUtil.Format(A205PedFchReg, "99/99/9999"));
            n205PedFchReg = T000D11_n205PedFchReg[0];
            A206PedEst = T000D11_A206PedEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A206PedEst", A206PedEst);
            n206PedEst = T000D11_n206PedEst[0];
            A207PedUltNro = T000D11_A207PedUltNro[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PedUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PedUltNro), 8, 0)));
            n207PedUltNro = T000D11_n207PedUltNro[0];
            ZM0D32( -17) ;
         }
         pr_default.close(9);
         OnLoadActions0D32( ) ;
      }

      protected void OnLoadActions0D32( )
      {
         AV24Pgmname = "OrdenPedido";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24Pgmname", AV24Pgmname);
      }

      protected void CheckExtendedTable0D32( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         AV24Pgmname = "OrdenPedido";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24Pgmname", AV24Pgmname);
         /* Using cursor T000D10 */
         pr_default.execute(8, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(8) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000D10_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T000D10_n44empdsc[0];
         pr_default.close(8);
         if ( ! ( (DateTime.MinValue==A205PedFchReg) || ( A205PedFchReg >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha Registro fuera de rango", "OutOfRange", 1, "PEDFCHREG");
            AnyError = 1;
            GX_FocusControl = edtPedFchReg_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0D32( )
      {
         pr_default.close(8);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_18( short A1EmpID )
      {
         /* Using cursor T000D12 */
         pr_default.execute(10, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(10) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000D12_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T000D12_n44empdsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A44empdsc)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(10) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(10);
      }

      protected void GetKey0D32( )
      {
         /* Using cursor T000D13 */
         pr_default.execute(11, new Object[] {A1EmpID, A39PedCod});
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound32 = 1;
         }
         else
         {
            RcdFound32 = 0;
         }
         pr_default.close(11);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000D9 */
         pr_default.execute(7, new Object[] {A1EmpID, A39PedCod});
         if ( (pr_default.getStatus(7) != 101) )
         {
            ZM0D32( 17) ;
            RcdFound32 = 1;
            A39PedCod = T000D9_A39PedCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A39PedCod), 8, 0)));
            A204PedDescripcion = T000D9_A204PedDescripcion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A204PedDescripcion", A204PedDescripcion);
            n204PedDescripcion = T000D9_n204PedDescripcion[0];
            A205PedFchReg = T000D9_A205PedFchReg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A205PedFchReg", context.localUtil.Format(A205PedFchReg, "99/99/9999"));
            n205PedFchReg = T000D9_n205PedFchReg[0];
            A206PedEst = T000D9_A206PedEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A206PedEst", A206PedEst);
            n206PedEst = T000D9_n206PedEst[0];
            A207PedUltNro = T000D9_A207PedUltNro[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PedUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PedUltNro), 8, 0)));
            n207PedUltNro = T000D9_n207PedUltNro[0];
            A1EmpID = T000D9_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            O207PedUltNro = A207PedUltNro;
            n207PedUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PedUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PedUltNro), 8, 0)));
            Z1EmpID = A1EmpID;
            Z39PedCod = A39PedCod;
            sMode32 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0D32( ) ;
            if ( AnyError == 1 )
            {
               RcdFound32 = 0;
               InitializeNonKey0D32( ) ;
            }
            Gx_mode = sMode32;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound32 = 0;
            InitializeNonKey0D32( ) ;
            sMode32 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode32;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(7);
      }

      protected void getEqualNoModal( )
      {
         GetKey0D32( ) ;
         if ( RcdFound32 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound32 = 0;
         /* Using cursor T000D14 */
         pr_default.execute(12, new Object[] {A1EmpID, A39PedCod});
         if ( (pr_default.getStatus(12) != 101) )
         {
            while ( (pr_default.getStatus(12) != 101) && ( ( T000D14_A1EmpID[0] < A1EmpID ) || ( T000D14_A1EmpID[0] == A1EmpID ) && ( T000D14_A39PedCod[0] < A39PedCod ) ) )
            {
               pr_default.readNext(12);
            }
            if ( (pr_default.getStatus(12) != 101) && ( ( T000D14_A1EmpID[0] > A1EmpID ) || ( T000D14_A1EmpID[0] == A1EmpID ) && ( T000D14_A39PedCod[0] > A39PedCod ) ) )
            {
               A1EmpID = T000D14_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A39PedCod = T000D14_A39PedCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A39PedCod), 8, 0)));
               RcdFound32 = 1;
            }
         }
         pr_default.close(12);
      }

      protected void move_previous( )
      {
         RcdFound32 = 0;
         /* Using cursor T000D15 */
         pr_default.execute(13, new Object[] {A1EmpID, A39PedCod});
         if ( (pr_default.getStatus(13) != 101) )
         {
            while ( (pr_default.getStatus(13) != 101) && ( ( T000D15_A1EmpID[0] > A1EmpID ) || ( T000D15_A1EmpID[0] == A1EmpID ) && ( T000D15_A39PedCod[0] > A39PedCod ) ) )
            {
               pr_default.readNext(13);
            }
            if ( (pr_default.getStatus(13) != 101) && ( ( T000D15_A1EmpID[0] < A1EmpID ) || ( T000D15_A1EmpID[0] == A1EmpID ) && ( T000D15_A39PedCod[0] < A39PedCod ) ) )
            {
               A1EmpID = T000D15_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A39PedCod = T000D15_A39PedCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A39PedCod), 8, 0)));
               RcdFound32 = 1;
            }
         }
         pr_default.close(13);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0D32( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            A207PedUltNro = O207PedUltNro;
            n207PedUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PedUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PedUltNro), 8, 0)));
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0D32( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound32 == 1 )
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A39PedCod != Z39PedCod ) )
               {
                  A1EmpID = Z1EmpID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
                  A39PedCod = Z39PedCod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A39PedCod), 8, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "EMPID");
                  AnyError = 1;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  A207PedUltNro = O207PedUltNro;
                  n207PedUltNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PedUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PedUltNro), 8, 0)));
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  A207PedUltNro = O207PedUltNro;
                  n207PedUltNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PedUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PedUltNro), 8, 0)));
                  Update0D32( ) ;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A39PedCod != Z39PedCod ) )
               {
                  /* Insert record */
                  A207PedUltNro = O207PedUltNro;
                  n207PedUltNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PedUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PedUltNro), 8, 0)));
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0D32( ) ;
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
                     A207PedUltNro = O207PedUltNro;
                     n207PedUltNro = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PedUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PedUltNro), 8, 0)));
                     GX_FocusControl = edtEmpID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0D32( ) ;
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
         if ( ( A1EmpID != Z1EmpID ) || ( A39PedCod != Z39PedCod ) )
         {
            A1EmpID = Z1EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A39PedCod = Z39PedCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A39PedCod), 8, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            A207PedUltNro = O207PedUltNro;
            n207PedUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PedUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PedUltNro), 8, 0)));
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0D32( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000D8 */
            pr_default.execute(6, new Object[] {A1EmpID, A39PedCod});
            if ( (pr_default.getStatus(6) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"OrdenPedido"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(6) == 101) || ( StringUtil.StrCmp(Z204PedDescripcion, T000D8_A204PedDescripcion[0]) != 0 ) || ( Z205PedFchReg != T000D8_A205PedFchReg[0] ) || ( StringUtil.StrCmp(Z206PedEst, T000D8_A206PedEst[0]) != 0 ) || ( Z207PedUltNro != T000D8_A207PedUltNro[0] ) )
            {
               if ( StringUtil.StrCmp(Z204PedDescripcion, T000D8_A204PedDescripcion[0]) != 0 )
               {
                  GXUtil.WriteLog("ordenpedido:[seudo value changed for attri]"+"PedDescripcion");
                  GXUtil.WriteLogRaw("Old: ",Z204PedDescripcion);
                  GXUtil.WriteLogRaw("Current: ",T000D8_A204PedDescripcion[0]);
               }
               if ( Z205PedFchReg != T000D8_A205PedFchReg[0] )
               {
                  GXUtil.WriteLog("ordenpedido:[seudo value changed for attri]"+"PedFchReg");
                  GXUtil.WriteLogRaw("Old: ",Z205PedFchReg);
                  GXUtil.WriteLogRaw("Current: ",T000D8_A205PedFchReg[0]);
               }
               if ( StringUtil.StrCmp(Z206PedEst, T000D8_A206PedEst[0]) != 0 )
               {
                  GXUtil.WriteLog("ordenpedido:[seudo value changed for attri]"+"PedEst");
                  GXUtil.WriteLogRaw("Old: ",Z206PedEst);
                  GXUtil.WriteLogRaw("Current: ",T000D8_A206PedEst[0]);
               }
               if ( Z207PedUltNro != T000D8_A207PedUltNro[0] )
               {
                  GXUtil.WriteLog("ordenpedido:[seudo value changed for attri]"+"PedUltNro");
                  GXUtil.WriteLogRaw("Old: ",Z207PedUltNro);
                  GXUtil.WriteLogRaw("Current: ",T000D8_A207PedUltNro[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"OrdenPedido"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0D32( )
      {
         BeforeValidate0D32( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0D32( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0D32( 0) ;
            CheckOptimisticConcurrency0D32( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0D32( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0D32( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000D16 */
                     pr_default.execute(14, new Object[] {A39PedCod, n204PedDescripcion, A204PedDescripcion, n205PedFchReg, A205PedFchReg, n206PedEst, A206PedEst, n207PedUltNro, A207PedUltNro, A1EmpID});
                     pr_default.close(14);
                     dsDefault.SmartCacheProvider.SetUpdated("OrdenPedido") ;
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
                           ProcessLevel0D32( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption0D0( ) ;
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
               Load0D32( ) ;
            }
            EndLevel0D32( ) ;
         }
         CloseExtendedTableCursors0D32( ) ;
      }

      protected void Update0D32( )
      {
         BeforeValidate0D32( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0D32( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0D32( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0D32( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0D32( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000D17 */
                     pr_default.execute(15, new Object[] {n204PedDescripcion, A204PedDescripcion, n205PedFchReg, A205PedFchReg, n206PedEst, A206PedEst, n207PedUltNro, A207PedUltNro, A1EmpID, A39PedCod});
                     pr_default.close(15);
                     dsDefault.SmartCacheProvider.SetUpdated("OrdenPedido") ;
                     if ( (pr_default.getStatus(15) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"OrdenPedido"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0D32( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0D32( ) ;
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
            EndLevel0D32( ) ;
         }
         CloseExtendedTableCursors0D32( ) ;
      }

      protected void DeferredUpdate0D32( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0D32( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0D32( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0D32( ) ;
            AfterConfirm0D32( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0D32( ) ;
               if ( AnyError == 0 )
               {
                  A207PedUltNro = O207PedUltNro;
                  n207PedUltNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PedUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PedUltNro), 8, 0)));
                  ScanStart0D33( ) ;
                  while ( RcdFound33 != 0 )
                  {
                     getByPrimaryKey0D33( ) ;
                     Delete0D33( ) ;
                     ScanNext0D33( ) ;
                     O207PedUltNro = A207PedUltNro;
                     n207PedUltNro = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PedUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PedUltNro), 8, 0)));
                  }
                  ScanEnd0D33( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000D18 */
                     pr_default.execute(16, new Object[] {A1EmpID, A39PedCod});
                     pr_default.close(16);
                     dsDefault.SmartCacheProvider.SetUpdated("OrdenPedido") ;
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
         sMode32 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0D32( ) ;
         Gx_mode = sMode32;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0D32( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV24Pgmname = "OrdenPedido";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24Pgmname", AV24Pgmname);
            /* Using cursor T000D19 */
            pr_default.execute(17, new Object[] {A1EmpID});
            A44empdsc = T000D19_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000D19_n44empdsc[0];
            pr_default.close(17);
         }
      }

      protected void ProcessNestedLevel0D33( )
      {
         s207PedUltNro = O207PedUltNro;
         n207PedUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PedUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PedUltNro), 8, 0)));
         nGXsfl_73_idx = 0;
         while ( nGXsfl_73_idx < nRC_GXsfl_73 )
         {
            ReadRow0D33( ) ;
            if ( ( nRcdExists_33 != 0 ) || ( nIsMod_33 != 0 ) )
            {
               standaloneNotModal0D33( ) ;
               GetKey0D33( ) ;
               if ( ( nRcdExists_33 == 0 ) && ( nRcdDeleted_33 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert0D33( ) ;
               }
               else
               {
                  if ( RcdFound33 != 0 )
                  {
                     if ( ( nRcdDeleted_33 != 0 ) && ( nRcdExists_33 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete0D33( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_33 != 0 ) && ( nRcdExists_33 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update0D33( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_33 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "EMPID");
                        AnyError = 1;
                        GX_FocusControl = edtEmpID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
               O207PedUltNro = A207PedUltNro;
               n207PedUltNro = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PedUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PedUltNro), 8, 0)));
            }
            ChangePostValue( edtOPIdSec_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A40OPIdSec), 8, 0, ",", ""))) ;
            ChangePostValue( edtdetTipoProdID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A36detTipoProdID), 4, 0, ",", ""))) ;
            ChangePostValue( edtcategID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A32categID), 4, 0, ",", ""))) ;
            ChangePostValue( edtcategDsc_Internalname, StringUtil.RTrim( A146categDsc)) ;
            ChangePostValue( edtsubCatID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A33subCatID), 4, 0, ",", ""))) ;
            ChangePostValue( edtsubCatDsc_Internalname, StringUtil.RTrim( A148subCatDsc)) ;
            ChangePostValue( edtsubCatPrec_Internalname, StringUtil.LTrim( StringUtil.NToC( A150subCatPrec, 8, 2, ",", ""))) ;
            ChangePostValue( edtsubCatPeso_Internalname, StringUtil.LTrim( StringUtil.NToC( A151subCatPeso, 8, 2, ",", ""))) ;
            ChangePostValue( edtsubCatDisp_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A211subCatDisp), 8, 0, ",", ""))) ;
            ChangePostValue( edtcantDetPed_Internalname, StringUtil.LTrim( StringUtil.NToC( A212cantDetPed, 8, 2, ",", ""))) ;
            ChangePostValue( edtPedDetSaldo_Internalname, StringUtil.LTrim( StringUtil.NToC( A214PedDetSaldo, 9, 2, ",", ""))) ;
            ChangePostValue( edtcantDetaPed_Internalname, StringUtil.LTrim( StringUtil.NToC( A213cantDetaPed, 8, 2, ",", ""))) ;
            ChangePostValue( edtPedTotal_Internalname, StringUtil.LTrim( StringUtil.NToC( A216PedTotal, 8, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z40OPIdSec_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z40OPIdSec), 8, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z212cantDetPed_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( Z212cantDetPed, 8, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z213cantDetaPed_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( Z213cantDetaPed, 8, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z36detTipoProdID_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z36detTipoProdID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z32categID_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z32categID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z33subCatID_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z33subCatID), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_33_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_33), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_33_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_33), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_33_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_33), 4, 0, ",", ""))) ;
            if ( nIsMod_33 != 0 )
            {
               ChangePostValue( "OPIDSEC_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOPIdSec_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETTIPOPRODID_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetTipoProdID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CATEGID_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcategID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CATEGDSC_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcategDsc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATID_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATDSC_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatDsc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATPREC_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatPrec_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATPESO_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatPeso_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATDISP_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatDisp_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CANTDETPED_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcantDetPed_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PEDDETSALDO_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPedDetSaldo_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CANTDETAPED_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcantDetaPed_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PEDTOTAL_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPedTotal_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0D33( ) ;
         if ( AnyError != 0 )
         {
            O207PedUltNro = s207PedUltNro;
            n207PedUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PedUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PedUltNro), 8, 0)));
         }
         nRcdExists_33 = 0;
         nIsMod_33 = 0;
         nRcdDeleted_33 = 0;
      }

      protected void ProcessLevel0D32( )
      {
         /* Save parent mode. */
         sMode32 = Gx_mode;
         ProcessNestedLevel0D33( ) ;
         if ( AnyError != 0 )
         {
            O207PedUltNro = s207PedUltNro;
            n207PedUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PedUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PedUltNro), 8, 0)));
         }
         /* Restore parent mode. */
         Gx_mode = sMode32;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         /* ' Update level parameters */
         /* Using cursor T000D20 */
         pr_default.execute(18, new Object[] {n207PedUltNro, A207PedUltNro, A1EmpID, A39PedCod});
         pr_default.close(18);
         dsDefault.SmartCacheProvider.SetUpdated("OrdenPedido") ;
      }

      protected void EndLevel0D32( )
      {
         pr_default.close(6);
         if ( AnyError == 0 )
         {
            BeforeComplete0D32( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(7);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(17);
            pr_default.close(5);
            pr_default.close(2);
            pr_default.close(3);
            pr_default.close(4);
            context.CommitDataStores("ordenpedido",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0D0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(7);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(17);
            pr_default.close(5);
            pr_default.close(2);
            pr_default.close(3);
            pr_default.close(4);
            context.RollbackDataStores("ordenpedido",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0D32( )
      {
         /* Scan By routine */
         /* Using cursor T000D21 */
         pr_default.execute(19);
         RcdFound32 = 0;
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound32 = 1;
            A1EmpID = T000D21_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A39PedCod = T000D21_A39PedCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A39PedCod), 8, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0D32( )
      {
         /* Scan next routine */
         pr_default.readNext(19);
         RcdFound32 = 0;
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound32 = 1;
            A1EmpID = T000D21_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A39PedCod = T000D21_A39PedCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A39PedCod), 8, 0)));
         }
      }

      protected void ScanEnd0D32( )
      {
         pr_default.close(19);
      }

      protected void AfterConfirm0D32( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0D32( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0D32( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0D32( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0D32( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0D32( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0D32( )
      {
         edtEmpID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         edtempdsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempdsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempdsc_Enabled), 5, 0)), true);
         edtPedCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedCod_Enabled), 5, 0)), true);
         edtPedDescripcion_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedDescripcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedDescripcion_Enabled), 5, 0)), true);
         edtPedFchReg_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedFchReg_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedFchReg_Enabled), 5, 0)), true);
         chkPedEst.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkPedEst_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkPedEst.Enabled), 5, 0)), true);
         edtPedUltNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedUltNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedUltNro_Enabled), 5, 0)), true);
      }

      protected void ZM0D33( short GX_JID )
      {
         if ( ( GX_JID == 19 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z212cantDetPed = T000D3_A212cantDetPed[0];
               Z213cantDetaPed = T000D3_A213cantDetaPed[0];
               Z36detTipoProdID = T000D3_A36detTipoProdID[0];
               Z32categID = T000D3_A32categID[0];
               Z33subCatID = T000D3_A33subCatID[0];
            }
            else
            {
               Z212cantDetPed = A212cantDetPed;
               Z213cantDetaPed = A213cantDetaPed;
               Z36detTipoProdID = A36detTipoProdID;
               Z32categID = A32categID;
               Z33subCatID = A33subCatID;
            }
         }
         if ( GX_JID == -19 )
         {
            Z39PedCod = A39PedCod;
            Z40OPIdSec = A40OPIdSec;
            Z212cantDetPed = A212cantDetPed;
            Z213cantDetaPed = A213cantDetaPed;
            Z1EmpID = A1EmpID;
            Z36detTipoProdID = A36detTipoProdID;
            Z32categID = A32categID;
            Z33subCatID = A33subCatID;
            Z146categDsc = A146categDsc;
            Z148subCatDsc = A148subCatDsc;
            Z150subCatPrec = A150subCatPrec;
            Z151subCatPeso = A151subCatPeso;
            Z211subCatDisp = A211subCatDisp;
         }
      }

      protected void standaloneNotModal0D33( )
      {
         edtOPIdSec_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOPIdSec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOPIdSec_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
         edtPedUltNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedUltNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedUltNro_Enabled), 5, 0)), true);
         edtPedUltNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedUltNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedUltNro_Enabled), 5, 0)), true);
      }

      protected void standaloneModal0D33( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A207PedUltNro = (int)(O207PedUltNro+1);
            n207PedUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PedUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PedUltNro), 8, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && ( Gx_BScreen == 1 ) )
         {
            A40OPIdSec = A207PedUltNro;
         }
      }

      protected void Load0D33( )
      {
         /* Using cursor T000D22 */
         pr_default.execute(20, new Object[] {A39PedCod, A40OPIdSec, A1EmpID});
         if ( (pr_default.getStatus(20) != 101) )
         {
            RcdFound33 = 1;
            A146categDsc = T000D22_A146categDsc[0];
            n146categDsc = T000D22_n146categDsc[0];
            A148subCatDsc = T000D22_A148subCatDsc[0];
            n148subCatDsc = T000D22_n148subCatDsc[0];
            A150subCatPrec = T000D22_A150subCatPrec[0];
            n150subCatPrec = T000D22_n150subCatPrec[0];
            A151subCatPeso = T000D22_A151subCatPeso[0];
            n151subCatPeso = T000D22_n151subCatPeso[0];
            A211subCatDisp = T000D22_A211subCatDisp[0];
            n211subCatDisp = T000D22_n211subCatDisp[0];
            A212cantDetPed = T000D22_A212cantDetPed[0];
            n212cantDetPed = T000D22_n212cantDetPed[0];
            A213cantDetaPed = T000D22_A213cantDetaPed[0];
            n213cantDetaPed = T000D22_n213cantDetaPed[0];
            A36detTipoProdID = T000D22_A36detTipoProdID[0];
            A32categID = T000D22_A32categID[0];
            A33subCatID = T000D22_A33subCatID[0];
            ZM0D33( -19) ;
         }
         pr_default.close(20);
         OnLoadActions0D33( ) ;
      }

      protected void OnLoadActions0D33( )
      {
         A214PedDetSaldo = NumberUtil.Round( (decimal)(A211subCatDisp-A212cantDetPed), 0);
         A216PedTotal = A213cantDetaPed;
      }

      protected void CheckExtendedTable0D33( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal0D33( ) ;
         /* Using cursor T000D4 */
         pr_default.execute(2, new Object[] {A1EmpID, A36detTipoProdID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GXCCtl = "DETTIPOPRODID_" + sGXsfl_73_idx;
            GX_msglist.addItem("No existe 'Tipo Producto'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtdetTipoProdID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(2);
         /* Using cursor T000D5 */
         pr_default.execute(3, new Object[] {A1EmpID, A32categID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GXCCtl = "CATEGID_" + sGXsfl_73_idx;
            GX_msglist.addItem("No existe 'Categorias'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtcategID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A146categDsc = T000D5_A146categDsc[0];
         n146categDsc = T000D5_n146categDsc[0];
         pr_default.close(3);
         /* Using cursor T000D6 */
         pr_default.execute(4, new Object[] {A1EmpID, A32categID, A33subCatID});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GXCCtl = "CATEGID_" + sGXsfl_73_idx;
            GX_msglist.addItem("No existe 'sub Cat'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtcategID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A148subCatDsc = T000D6_A148subCatDsc[0];
         n148subCatDsc = T000D6_n148subCatDsc[0];
         A150subCatPrec = T000D6_A150subCatPrec[0];
         n150subCatPrec = T000D6_n150subCatPrec[0];
         A151subCatPeso = T000D6_A151subCatPeso[0];
         n151subCatPeso = T000D6_n151subCatPeso[0];
         A211subCatDisp = T000D6_A211subCatDisp[0];
         n211subCatDisp = T000D6_n211subCatDisp[0];
         pr_default.close(4);
         A214PedDetSaldo = NumberUtil.Round( (decimal)(A211subCatDisp-A212cantDetPed), 0);
         A216PedTotal = A213cantDetaPed;
      }

      protected void CloseExtendedTableCursors0D33( )
      {
         pr_default.close(5);
         pr_default.close(3);
         pr_default.close(4);
      }

      protected void enableDisable0D33( )
      {
      }

      protected void gxLoad_20( short A1EmpID ,
                                short A36detTipoProdID )
      {
         /* Using cursor T000D4 */
         pr_default.execute(2, new Object[] {A1EmpID, A36detTipoProdID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GXCCtl = "DETTIPOPRODID_" + sGXsfl_73_idx;
            GX_msglist.addItem("No existe 'Tipo Producto'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtdetTipoProdID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(2) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(2);
      }

      protected void gxLoad_21( short A1EmpID ,
                                short A32categID )
      {
         /* Using cursor T000D23 */
         pr_default.execute(21, new Object[] {A1EmpID, A32categID});
         if ( (pr_default.getStatus(21) == 101) )
         {
            GXCCtl = "CATEGID_" + sGXsfl_73_idx;
            GX_msglist.addItem("No existe 'Categorias'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtcategID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A146categDsc = T000D23_A146categDsc[0];
         n146categDsc = T000D23_n146categDsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A146categDsc))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(21) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(21);
      }

      protected void gxLoad_22( short A1EmpID ,
                                short A32categID ,
                                short A33subCatID )
      {
         /* Using cursor T000D24 */
         pr_default.execute(22, new Object[] {A1EmpID, A32categID, A33subCatID});
         if ( (pr_default.getStatus(22) == 101) )
         {
            GXCCtl = "CATEGID_" + sGXsfl_73_idx;
            GX_msglist.addItem("No existe 'sub Cat'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtcategID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A148subCatDsc = T000D24_A148subCatDsc[0];
         n148subCatDsc = T000D24_n148subCatDsc[0];
         A150subCatPrec = T000D24_A150subCatPrec[0];
         n150subCatPrec = T000D24_n150subCatPrec[0];
         A151subCatPeso = T000D24_A151subCatPeso[0];
         n151subCatPeso = T000D24_n151subCatPeso[0];
         A211subCatDisp = T000D24_A211subCatDisp[0];
         n211subCatDisp = T000D24_n211subCatDisp[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A148subCatDsc))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A150subCatPrec, 8, 2, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A151subCatPeso, 8, 2, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A211subCatDisp), 8, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(22) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(22);
      }

      protected void GetKey0D33( )
      {
         /* Using cursor T000D25 */
         pr_default.execute(23, new Object[] {A1EmpID, A39PedCod, A40OPIdSec});
         if ( (pr_default.getStatus(23) != 101) )
         {
            RcdFound33 = 1;
         }
         else
         {
            RcdFound33 = 0;
         }
         pr_default.close(23);
      }

      protected void getByPrimaryKey0D33( )
      {
         /* Using cursor T000D3 */
         pr_default.execute(1, new Object[] {A1EmpID, A39PedCod, A40OPIdSec});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0D33( 19) ;
            RcdFound33 = 1;
            InitializeNonKey0D33( ) ;
            A40OPIdSec = T000D3_A40OPIdSec[0];
            A212cantDetPed = T000D3_A212cantDetPed[0];
            n212cantDetPed = T000D3_n212cantDetPed[0];
            A213cantDetaPed = T000D3_A213cantDetaPed[0];
            n213cantDetaPed = T000D3_n213cantDetaPed[0];
            A36detTipoProdID = T000D3_A36detTipoProdID[0];
            A32categID = T000D3_A32categID[0];
            A33subCatID = T000D3_A33subCatID[0];
            Z1EmpID = A1EmpID;
            Z39PedCod = A39PedCod;
            Z40OPIdSec = A40OPIdSec;
            sMode33 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0D33( ) ;
            Gx_mode = sMode33;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound33 = 0;
            InitializeNonKey0D33( ) ;
            sMode33 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal0D33( ) ;
            Gx_mode = sMode33;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes0D33( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0D33( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000D2 */
            pr_default.execute(0, new Object[] {A1EmpID, A39PedCod, A40OPIdSec});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"OrdenPedidoOPId"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z212cantDetPed != T000D2_A212cantDetPed[0] ) || ( Z213cantDetaPed != T000D2_A213cantDetaPed[0] ) || ( Z36detTipoProdID != T000D2_A36detTipoProdID[0] ) || ( Z32categID != T000D2_A32categID[0] ) || ( Z33subCatID != T000D2_A33subCatID[0] ) )
            {
               if ( Z212cantDetPed != T000D2_A212cantDetPed[0] )
               {
                  GXUtil.WriteLog("ordenpedido:[seudo value changed for attri]"+"cantDetPed");
                  GXUtil.WriteLogRaw("Old: ",Z212cantDetPed);
                  GXUtil.WriteLogRaw("Current: ",T000D2_A212cantDetPed[0]);
               }
               if ( Z213cantDetaPed != T000D2_A213cantDetaPed[0] )
               {
                  GXUtil.WriteLog("ordenpedido:[seudo value changed for attri]"+"cantDetaPed");
                  GXUtil.WriteLogRaw("Old: ",Z213cantDetaPed);
                  GXUtil.WriteLogRaw("Current: ",T000D2_A213cantDetaPed[0]);
               }
               if ( Z36detTipoProdID != T000D2_A36detTipoProdID[0] )
               {
                  GXUtil.WriteLog("ordenpedido:[seudo value changed for attri]"+"detTipoProdID");
                  GXUtil.WriteLogRaw("Old: ",Z36detTipoProdID);
                  GXUtil.WriteLogRaw("Current: ",T000D2_A36detTipoProdID[0]);
               }
               if ( Z32categID != T000D2_A32categID[0] )
               {
                  GXUtil.WriteLog("ordenpedido:[seudo value changed for attri]"+"categID");
                  GXUtil.WriteLogRaw("Old: ",Z32categID);
                  GXUtil.WriteLogRaw("Current: ",T000D2_A32categID[0]);
               }
               if ( Z33subCatID != T000D2_A33subCatID[0] )
               {
                  GXUtil.WriteLog("ordenpedido:[seudo value changed for attri]"+"subCatID");
                  GXUtil.WriteLogRaw("Old: ",Z33subCatID);
                  GXUtil.WriteLogRaw("Current: ",T000D2_A33subCatID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"OrdenPedidoOPId"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0D33( )
      {
         BeforeValidate0D33( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0D33( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0D33( 0) ;
            CheckOptimisticConcurrency0D33( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0D33( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0D33( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000D26 */
                     pr_default.execute(24, new Object[] {A39PedCod, A40OPIdSec, n212cantDetPed, A212cantDetPed, n213cantDetaPed, A213cantDetaPed, A1EmpID, A36detTipoProdID, A32categID, A33subCatID});
                     pr_default.close(24);
                     dsDefault.SmartCacheProvider.SetUpdated("OrdenPedidoOPId") ;
                     if ( (pr_default.getStatus(24) == 1) )
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
               Load0D33( ) ;
            }
            EndLevel0D33( ) ;
         }
         CloseExtendedTableCursors0D33( ) ;
      }

      protected void Update0D33( )
      {
         BeforeValidate0D33( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0D33( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0D33( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0D33( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0D33( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000D27 */
                     pr_default.execute(25, new Object[] {n212cantDetPed, A212cantDetPed, n213cantDetaPed, A213cantDetaPed, A36detTipoProdID, A32categID, A33subCatID, A1EmpID, A39PedCod, A40OPIdSec});
                     pr_default.close(25);
                     dsDefault.SmartCacheProvider.SetUpdated("OrdenPedidoOPId") ;
                     if ( (pr_default.getStatus(25) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"OrdenPedidoOPId"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0D33( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey0D33( ) ;
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
            EndLevel0D33( ) ;
         }
         CloseExtendedTableCursors0D33( ) ;
      }

      protected void DeferredUpdate0D33( )
      {
      }

      protected void Delete0D33( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate0D33( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0D33( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0D33( ) ;
            AfterConfirm0D33( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0D33( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000D28 */
                  pr_default.execute(26, new Object[] {A1EmpID, A39PedCod, A40OPIdSec});
                  pr_default.close(26);
                  dsDefault.SmartCacheProvider.SetUpdated("OrdenPedidoOPId") ;
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
         sMode33 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0D33( ) ;
         Gx_mode = sMode33;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0D33( )
      {
         standaloneModal0D33( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000D29 */
            pr_default.execute(27, new Object[] {A1EmpID, A32categID});
            A146categDsc = T000D29_A146categDsc[0];
            n146categDsc = T000D29_n146categDsc[0];
            pr_default.close(27);
            /* Using cursor T000D30 */
            pr_default.execute(28, new Object[] {A1EmpID, A32categID, A33subCatID});
            A148subCatDsc = T000D30_A148subCatDsc[0];
            n148subCatDsc = T000D30_n148subCatDsc[0];
            A150subCatPrec = T000D30_A150subCatPrec[0];
            n150subCatPrec = T000D30_n150subCatPrec[0];
            A151subCatPeso = T000D30_A151subCatPeso[0];
            n151subCatPeso = T000D30_n151subCatPeso[0];
            A211subCatDisp = T000D30_A211subCatDisp[0];
            n211subCatDisp = T000D30_n211subCatDisp[0];
            pr_default.close(28);
            A214PedDetSaldo = NumberUtil.Round( (decimal)(A211subCatDisp-A212cantDetPed), 0);
            A216PedTotal = A213cantDetaPed;
         }
      }

      protected void EndLevel0D33( )
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

      public void ScanStart0D33( )
      {
         /* Scan By routine */
         /* Using cursor T000D31 */
         pr_default.execute(29, new Object[] {A39PedCod, A1EmpID});
         RcdFound33 = 0;
         if ( (pr_default.getStatus(29) != 101) )
         {
            RcdFound33 = 1;
            A40OPIdSec = T000D31_A40OPIdSec[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0D33( )
      {
         /* Scan next routine */
         pr_default.readNext(29);
         RcdFound33 = 0;
         if ( (pr_default.getStatus(29) != 101) )
         {
            RcdFound33 = 1;
            A40OPIdSec = T000D31_A40OPIdSec[0];
         }
      }

      protected void ScanEnd0D33( )
      {
         pr_default.close(29);
      }

      protected void AfterConfirm0D33( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0D33( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0D33( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0D33( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0D33( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0D33( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0D33( )
      {
         edtOPIdSec_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOPIdSec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOPIdSec_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
         edtdetTipoProdID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetTipoProdID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetTipoProdID_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
         edtcategID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcategID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcategID_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
         edtcategDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcategDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcategDsc_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
         edtsubCatID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatID_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
         edtsubCatDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatDsc_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
         edtsubCatPrec_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatPrec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatPrec_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
         edtsubCatPeso_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatPeso_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatPeso_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
         edtsubCatDisp_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatDisp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatDisp_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
         edtcantDetPed_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcantDetPed_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcantDetPed_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
         edtPedDetSaldo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedDetSaldo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedDetSaldo_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
         edtcantDetaPed_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcantDetaPed_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcantDetaPed_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
         edtPedTotal_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedTotal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedTotal_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
      }

      protected void send_integrity_lvl_hashes0D33( )
      {
      }

      protected void send_integrity_lvl_hashes0D32( )
      {
      }

      protected void SubsflControlProps_7333( )
      {
         edtOPIdSec_Internalname = "OPIDSEC_"+sGXsfl_73_idx;
         edtdetTipoProdID_Internalname = "DETTIPOPRODID_"+sGXsfl_73_idx;
         imgprompt_36_Internalname = "PROMPT_36_"+sGXsfl_73_idx;
         edtcategID_Internalname = "CATEGID_"+sGXsfl_73_idx;
         imgprompt_32_Internalname = "PROMPT_32_"+sGXsfl_73_idx;
         edtcategDsc_Internalname = "CATEGDSC_"+sGXsfl_73_idx;
         edtsubCatID_Internalname = "SUBCATID_"+sGXsfl_73_idx;
         imgprompt_33_Internalname = "PROMPT_33_"+sGXsfl_73_idx;
         edtsubCatDsc_Internalname = "SUBCATDSC_"+sGXsfl_73_idx;
         edtsubCatPrec_Internalname = "SUBCATPREC_"+sGXsfl_73_idx;
         edtsubCatPeso_Internalname = "SUBCATPESO_"+sGXsfl_73_idx;
         edtsubCatDisp_Internalname = "SUBCATDISP_"+sGXsfl_73_idx;
         edtcantDetPed_Internalname = "CANTDETPED_"+sGXsfl_73_idx;
         edtPedDetSaldo_Internalname = "PEDDETSALDO_"+sGXsfl_73_idx;
         edtcantDetaPed_Internalname = "CANTDETAPED_"+sGXsfl_73_idx;
         edtPedTotal_Internalname = "PEDTOTAL_"+sGXsfl_73_idx;
      }

      protected void SubsflControlProps_fel_7333( )
      {
         edtOPIdSec_Internalname = "OPIDSEC_"+sGXsfl_73_fel_idx;
         edtdetTipoProdID_Internalname = "DETTIPOPRODID_"+sGXsfl_73_fel_idx;
         imgprompt_36_Internalname = "PROMPT_36_"+sGXsfl_73_fel_idx;
         edtcategID_Internalname = "CATEGID_"+sGXsfl_73_fel_idx;
         imgprompt_32_Internalname = "PROMPT_32_"+sGXsfl_73_fel_idx;
         edtcategDsc_Internalname = "CATEGDSC_"+sGXsfl_73_fel_idx;
         edtsubCatID_Internalname = "SUBCATID_"+sGXsfl_73_fel_idx;
         imgprompt_33_Internalname = "PROMPT_33_"+sGXsfl_73_fel_idx;
         edtsubCatDsc_Internalname = "SUBCATDSC_"+sGXsfl_73_fel_idx;
         edtsubCatPrec_Internalname = "SUBCATPREC_"+sGXsfl_73_fel_idx;
         edtsubCatPeso_Internalname = "SUBCATPESO_"+sGXsfl_73_fel_idx;
         edtsubCatDisp_Internalname = "SUBCATDISP_"+sGXsfl_73_fel_idx;
         edtcantDetPed_Internalname = "CANTDETPED_"+sGXsfl_73_fel_idx;
         edtPedDetSaldo_Internalname = "PEDDETSALDO_"+sGXsfl_73_fel_idx;
         edtcantDetaPed_Internalname = "CANTDETAPED_"+sGXsfl_73_fel_idx;
         edtPedTotal_Internalname = "PEDTOTAL_"+sGXsfl_73_fel_idx;
      }

      protected void AddRow0D33( )
      {
         nGXsfl_73_idx = (short)(nGXsfl_73_idx+1);
         sGXsfl_73_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_73_idx), 4, 0)), 4, "0");
         SubsflControlProps_7333( ) ;
         SendRow0D33( ) ;
      }

      protected void SendRow0D33( )
      {
         Gridordenpedido_opidRow = GXWebRow.GetNew(context);
         if ( subGridordenpedido_opid_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridordenpedido_opid_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridordenpedido_opid_Class, "") != 0 )
            {
               subGridordenpedido_opid_Linesclass = subGridordenpedido_opid_Class+"Odd";
            }
         }
         else if ( subGridordenpedido_opid_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridordenpedido_opid_Backstyle = 0;
            subGridordenpedido_opid_Backcolor = subGridordenpedido_opid_Allbackcolor;
            if ( StringUtil.StrCmp(subGridordenpedido_opid_Class, "") != 0 )
            {
               subGridordenpedido_opid_Linesclass = subGridordenpedido_opid_Class+"Uniform";
            }
         }
         else if ( subGridordenpedido_opid_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridordenpedido_opid_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridordenpedido_opid_Class, "") != 0 )
            {
               subGridordenpedido_opid_Linesclass = subGridordenpedido_opid_Class+"Odd";
            }
            subGridordenpedido_opid_Backcolor = (int)(0x0);
         }
         else if ( subGridordenpedido_opid_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridordenpedido_opid_Backstyle = 1;
            if ( ((int)(((nGXsfl_73_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGridordenpedido_opid_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridordenpedido_opid_Class, "") != 0 )
               {
                  subGridordenpedido_opid_Linesclass = subGridordenpedido_opid_Class+"Odd";
               }
            }
            else
            {
               subGridordenpedido_opid_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridordenpedido_opid_Class, "") != 0 )
               {
                  subGridordenpedido_opid_Linesclass = subGridordenpedido_opid_Class+"Even";
               }
            }
         }
         imgprompt_33_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00r2.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"CATEGID_"+sGXsfl_73_idx+"'), id:'"+"CATEGID_"+sGXsfl_73_idx+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"SUBCATID_"+sGXsfl_73_idx+"'), id:'"+"SUBCATID_"+sGXsfl_73_idx+"'"+",IOType:'out'}"+"],"+"gx.dom.form()."+"nIsMod_33_"+sGXsfl_73_idx+","+"'', false"+","+"false"+");");
         imgprompt_32_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00q1.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"CATEGID_"+sGXsfl_73_idx+"'), id:'"+"CATEGID_"+sGXsfl_73_idx+"'"+",IOType:'out'}"+"],"+"gx.dom.form()."+"nIsMod_33_"+sGXsfl_73_idx+","+"'', false"+","+"false"+");");
         imgprompt_36_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00p1.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"DETTIPOPRODID_"+sGXsfl_73_idx+"'), id:'"+"DETTIPOPRODID_"+sGXsfl_73_idx+"'"+",IOType:'out'}"+"],"+"gx.dom.form()."+"nIsMod_33_"+sGXsfl_73_idx+","+"'', false"+","+"false"+");");
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridordenpedido_opidRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOPIdSec_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A40OPIdSec), 8, 0, ",", "")),((edtOPIdSec_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A40OPIdSec), "ZZZZZZZ9")) : context.localUtil.Format( (decimal)(A40OPIdSec), "ZZZZZZZ9")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOPIdSec_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtOPIdSec_Enabled,(short)0,(String)"number",(String)"1",(short)50,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)73,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_33_" + sGXsfl_73_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 75,'',false,'" + sGXsfl_73_idx + "',73)\"";
         ROClassString = "Attribute";
         Gridordenpedido_opidRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtdetTipoProdID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A36detTipoProdID), 4, 0, ",", "")),((edtdetTipoProdID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A36detTipoProdID), "ZZZ9")) : context.localUtil.Format( (decimal)(A36detTipoProdID), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,75);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtdetTipoProdID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtdetTipoProdID_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)73,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         Gridordenpedido_opidRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_36_Internalname,(String)sImgUrl,(String)imgprompt_36_Link,(String)"",(String)"",context.GetTheme( ),(int)imgprompt_36_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_33_" + sGXsfl_73_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_73_idx + "',73)\"";
         ROClassString = "Attribute";
         Gridordenpedido_opidRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtcategID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A32categID), 4, 0, ",", "")),((edtcategID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A32categID), "ZZZ9")) : context.localUtil.Format( (decimal)(A32categID), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,76);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtcategID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtcategID_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)73,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         Gridordenpedido_opidRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_32_Internalname,(String)sImgUrl,(String)imgprompt_32_Link,(String)"",(String)"",context.GetTheme( ),(int)imgprompt_32_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridordenpedido_opidRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtcategDsc_Internalname,StringUtil.RTrim( A146categDsc),StringUtil.RTrim( context.localUtil.Format( A146categDsc, "@!")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtcategDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtcategDsc_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)73,(short)1,(short)-1,(short)-1,(bool)true,(String)"nombres",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_33_" + sGXsfl_73_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 78,'',false,'" + sGXsfl_73_idx + "',73)\"";
         ROClassString = "Attribute";
         Gridordenpedido_opidRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtsubCatID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A33subCatID), 4, 0, ",", "")),((edtsubCatID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A33subCatID), "ZZZ9")) : context.localUtil.Format( (decimal)(A33subCatID), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,78);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtsubCatID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtsubCatID_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)73,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         Gridordenpedido_opidRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_33_Internalname,(String)sImgUrl,(String)imgprompt_33_Link,(String)"",(String)"",context.GetTheme( ),(int)imgprompt_33_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridordenpedido_opidRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtsubCatDsc_Internalname,StringUtil.RTrim( A148subCatDsc),StringUtil.RTrim( context.localUtil.Format( A148subCatDsc, "@!")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtsubCatDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtsubCatDsc_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)73,(short)1,(short)-1,(short)-1,(bool)true,(String)"nombres",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridordenpedido_opidRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtsubCatPrec_Internalname,StringUtil.LTrim( StringUtil.NToC( A150subCatPrec, 8, 2, ",", "")),((edtsubCatPrec_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A150subCatPrec, "ZZZZ9.99")) : context.localUtil.Format( A150subCatPrec, "ZZZZ9.99")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtsubCatPrec_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtsubCatPrec_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)73,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridordenpedido_opidRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtsubCatPeso_Internalname,StringUtil.LTrim( StringUtil.NToC( A151subCatPeso, 8, 2, ",", "")),((edtsubCatPeso_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A151subCatPeso, "ZZZZ9.99")) : context.localUtil.Format( A151subCatPeso, "ZZZZ9.99")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtsubCatPeso_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtsubCatPeso_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)73,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridordenpedido_opidRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtsubCatDisp_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A211subCatDisp), 8, 0, ",", "")),((edtsubCatDisp_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A211subCatDisp), "ZZZZZZZ9")) : context.localUtil.Format( (decimal)(A211subCatDisp), "ZZZZZZZ9")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtsubCatDisp_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtsubCatDisp_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)73,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_33_" + sGXsfl_73_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 83,'',false,'" + sGXsfl_73_idx + "',73)\"";
         ROClassString = "Attribute";
         Gridordenpedido_opidRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtcantDetPed_Internalname,StringUtil.LTrim( StringUtil.NToC( A212cantDetPed, 8, 2, ",", "")),((edtcantDetPed_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A212cantDetPed, "ZZZZ9.99")) : context.localUtil.Format( A212cantDetPed, "ZZZZ9.99")),TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,83);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtcantDetPed_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtcantDetPed_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)73,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridordenpedido_opidRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPedDetSaldo_Internalname,StringUtil.LTrim( StringUtil.NToC( A214PedDetSaldo, 9, 2, ",", "")),((edtPedDetSaldo_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A214PedDetSaldo, "ZZ,ZZ9.99")) : context.localUtil.Format( A214PedDetSaldo, "ZZ,ZZ9.99")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPedDetSaldo_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtPedDetSaldo_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)73,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_33_" + sGXsfl_73_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 85,'',false,'" + sGXsfl_73_idx + "',73)\"";
         ROClassString = "Attribute";
         Gridordenpedido_opidRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtcantDetaPed_Internalname,StringUtil.LTrim( StringUtil.NToC( A213cantDetaPed, 8, 2, ",", "")),((edtcantDetaPed_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A213cantDetaPed, "ZZZZ9.99")) : context.localUtil.Format( A213cantDetaPed, "ZZZZ9.99")),TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,85);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtcantDetaPed_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtcantDetaPed_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)73,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridordenpedido_opidRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPedTotal_Internalname,StringUtil.LTrim( StringUtil.NToC( A216PedTotal, 8, 2, ",", "")),((edtPedTotal_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A216PedTotal, "ZZZZ9.99")) : context.localUtil.Format( A216PedTotal, "ZZZZ9.99")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPedTotal_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtPedTotal_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)73,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         context.httpAjaxContext.ajax_sending_grid_row(Gridordenpedido_opidRow);
         send_integrity_lvl_hashes0D33( ) ;
         GXCCtl = "Z40OPIdSec_" + sGXsfl_73_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z40OPIdSec), 8, 0, ",", "")));
         GXCCtl = "Z212cantDetPed_" + sGXsfl_73_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z212cantDetPed, 8, 2, ",", "")));
         GXCCtl = "Z213cantDetaPed_" + sGXsfl_73_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z213cantDetaPed, 8, 2, ",", "")));
         GXCCtl = "Z36detTipoProdID_" + sGXsfl_73_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z36detTipoProdID), 4, 0, ",", "")));
         GXCCtl = "Z32categID_" + sGXsfl_73_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z32categID), 4, 0, ",", "")));
         GXCCtl = "Z33subCatID_" + sGXsfl_73_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z33subCatID), 4, 0, ",", "")));
         GXCCtl = "nRcdDeleted_33_" + sGXsfl_73_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_33), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_33_" + sGXsfl_73_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_33), 4, 0, ",", "")));
         GXCCtl = "nIsMod_33_" + sGXsfl_73_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_33), 4, 0, ",", "")));
         GXCCtl = "vMODE_" + sGXsfl_73_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_73_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV20TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV20TrnContext);
         }
         GXCCtl = "vEMPID_" + sGXsfl_73_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10EmpID), 4, 0, ",", "")));
         GXCCtl = "vPEDCOD_" + sGXsfl_73_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7PedCod), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "OPIDSEC_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOPIdSec_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DETTIPOPRODID_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetTipoProdID_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CATEGID_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcategID_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CATEGDSC_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcategDsc_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SUBCATID_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatID_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SUBCATDSC_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatDsc_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SUBCATPREC_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatPrec_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SUBCATPESO_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatPeso_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SUBCATDISP_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatDisp_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CANTDETPED_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcantDetPed_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PEDDETSALDO_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPedDetSaldo_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CANTDETAPED_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcantDetaPed_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PEDTOTAL_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPedTotal_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_36_"+sGXsfl_73_idx+"Link", StringUtil.RTrim( imgprompt_36_Link));
         GxWebStd.gx_hidden_field( context, "PROMPT_32_"+sGXsfl_73_idx+"Link", StringUtil.RTrim( imgprompt_32_Link));
         GxWebStd.gx_hidden_field( context, "PROMPT_33_"+sGXsfl_73_idx+"Link", StringUtil.RTrim( imgprompt_33_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridordenpedido_opidContainer.AddRow(Gridordenpedido_opidRow);
      }

      protected void ReadRow0D33( )
      {
         nGXsfl_73_idx = (short)(nGXsfl_73_idx+1);
         sGXsfl_73_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_73_idx), 4, 0)), 4, "0");
         SubsflControlProps_7333( ) ;
         edtOPIdSec_Enabled = (int)(context.localUtil.CToN( cgiGet( "OPIDSEC_"+sGXsfl_73_idx+"Enabled"), ",", "."));
         edtdetTipoProdID_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETTIPOPRODID_"+sGXsfl_73_idx+"Enabled"), ",", "."));
         edtcategID_Enabled = (int)(context.localUtil.CToN( cgiGet( "CATEGID_"+sGXsfl_73_idx+"Enabled"), ",", "."));
         edtcategDsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "CATEGDSC_"+sGXsfl_73_idx+"Enabled"), ",", "."));
         edtsubCatID_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATID_"+sGXsfl_73_idx+"Enabled"), ",", "."));
         edtsubCatDsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATDSC_"+sGXsfl_73_idx+"Enabled"), ",", "."));
         edtsubCatPrec_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATPREC_"+sGXsfl_73_idx+"Enabled"), ",", "."));
         edtsubCatPeso_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATPESO_"+sGXsfl_73_idx+"Enabled"), ",", "."));
         edtsubCatDisp_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATDISP_"+sGXsfl_73_idx+"Enabled"), ",", "."));
         edtcantDetPed_Enabled = (int)(context.localUtil.CToN( cgiGet( "CANTDETPED_"+sGXsfl_73_idx+"Enabled"), ",", "."));
         edtPedDetSaldo_Enabled = (int)(context.localUtil.CToN( cgiGet( "PEDDETSALDO_"+sGXsfl_73_idx+"Enabled"), ",", "."));
         edtcantDetaPed_Enabled = (int)(context.localUtil.CToN( cgiGet( "CANTDETAPED_"+sGXsfl_73_idx+"Enabled"), ",", "."));
         edtPedTotal_Enabled = (int)(context.localUtil.CToN( cgiGet( "PEDTOTAL_"+sGXsfl_73_idx+"Enabled"), ",", "."));
         imgprompt_1_Link = cgiGet( "PROMPT_36_"+sGXsfl_73_idx+"Link");
         imgprompt_1_Link = cgiGet( "PROMPT_32_"+sGXsfl_73_idx+"Link");
         imgprompt_1_Link = cgiGet( "PROMPT_33_"+sGXsfl_73_idx+"Link");
         A40OPIdSec = (int)(context.localUtil.CToN( cgiGet( edtOPIdSec_Internalname), ",", "."));
         if ( ( ( context.localUtil.CToN( cgiGet( edtdetTipoProdID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtdetTipoProdID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "DETTIPOPRODID_" + sGXsfl_73_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtdetTipoProdID_Internalname;
            wbErr = true;
            A36detTipoProdID = 0;
         }
         else
         {
            A36detTipoProdID = (short)(context.localUtil.CToN( cgiGet( edtdetTipoProdID_Internalname), ",", "."));
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtcategID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtcategID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "CATEGID_" + sGXsfl_73_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtcategID_Internalname;
            wbErr = true;
            A32categID = 0;
         }
         else
         {
            A32categID = (short)(context.localUtil.CToN( cgiGet( edtcategID_Internalname), ",", "."));
         }
         A146categDsc = StringUtil.Upper( cgiGet( edtcategDsc_Internalname));
         n146categDsc = false;
         if ( ( ( context.localUtil.CToN( cgiGet( edtsubCatID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtsubCatID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "SUBCATID_" + sGXsfl_73_idx;
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
         A150subCatPrec = context.localUtil.CToN( cgiGet( edtsubCatPrec_Internalname), ",", ".");
         n150subCatPrec = false;
         A151subCatPeso = context.localUtil.CToN( cgiGet( edtsubCatPeso_Internalname), ",", ".");
         n151subCatPeso = false;
         A211subCatDisp = (int)(context.localUtil.CToN( cgiGet( edtsubCatDisp_Internalname), ",", "."));
         n211subCatDisp = false;
         if ( ( ( context.localUtil.CToN( cgiGet( edtcantDetPed_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtcantDetPed_Internalname), ",", ".") > 99999.99m ) ) )
         {
            GXCCtl = "CANTDETPED_" + sGXsfl_73_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtcantDetPed_Internalname;
            wbErr = true;
            A212cantDetPed = 0;
            n212cantDetPed = false;
         }
         else
         {
            A212cantDetPed = context.localUtil.CToN( cgiGet( edtcantDetPed_Internalname), ",", ".");
            n212cantDetPed = false;
         }
         n212cantDetPed = ((Convert.ToDecimal(0)==A212cantDetPed) ? true : false);
         A214PedDetSaldo = context.localUtil.CToN( cgiGet( edtPedDetSaldo_Internalname), ",", ".");
         if ( ( ( context.localUtil.CToN( cgiGet( edtcantDetaPed_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtcantDetaPed_Internalname), ",", ".") > 99999.99m ) ) )
         {
            GXCCtl = "CANTDETAPED_" + sGXsfl_73_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtcantDetaPed_Internalname;
            wbErr = true;
            A213cantDetaPed = 0;
            n213cantDetaPed = false;
         }
         else
         {
            A213cantDetaPed = context.localUtil.CToN( cgiGet( edtcantDetaPed_Internalname), ",", ".");
            n213cantDetaPed = false;
         }
         n213cantDetaPed = ((Convert.ToDecimal(0)==A213cantDetaPed) ? true : false);
         A216PedTotal = context.localUtil.CToN( cgiGet( edtPedTotal_Internalname), ",", ".");
         GXCCtl = "Z40OPIdSec_" + sGXsfl_73_idx;
         Z40OPIdSec = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z212cantDetPed_" + sGXsfl_73_idx;
         Z212cantDetPed = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n212cantDetPed = ((Convert.ToDecimal(0)==A212cantDetPed) ? true : false);
         GXCCtl = "Z213cantDetaPed_" + sGXsfl_73_idx;
         Z213cantDetaPed = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n213cantDetaPed = ((Convert.ToDecimal(0)==A213cantDetaPed) ? true : false);
         GXCCtl = "Z36detTipoProdID_" + sGXsfl_73_idx;
         Z36detTipoProdID = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z32categID_" + sGXsfl_73_idx;
         Z32categID = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z33subCatID_" + sGXsfl_73_idx;
         Z33subCatID = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdDeleted_33_" + sGXsfl_73_idx;
         nRcdDeleted_33 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_33_" + sGXsfl_73_idx;
         nRcdExists_33 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_33_" + sGXsfl_73_idx;
         nIsMod_33 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void assign_properties_default( )
      {
         defedtOPIdSec_Enabled = edtOPIdSec_Enabled;
      }

      protected void ConfirmValues0D0( )
      {
         nGXsfl_73_idx = 0;
         sGXsfl_73_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_73_idx), 4, 0)), 4, "0");
         SubsflControlProps_7333( ) ;
         while ( nGXsfl_73_idx < nRC_GXsfl_73 )
         {
            nGXsfl_73_idx = (short)(nGXsfl_73_idx+1);
            sGXsfl_73_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_73_idx), 4, 0)), 4, "0");
            SubsflControlProps_7333( ) ;
            ChangePostValue( "Z40OPIdSec_"+sGXsfl_73_idx, cgiGet( "ZT_"+"Z40OPIdSec_"+sGXsfl_73_idx)) ;
            DeletePostValue( "ZT_"+"Z40OPIdSec_"+sGXsfl_73_idx) ;
            ChangePostValue( "Z212cantDetPed_"+sGXsfl_73_idx, cgiGet( "ZT_"+"Z212cantDetPed_"+sGXsfl_73_idx)) ;
            DeletePostValue( "ZT_"+"Z212cantDetPed_"+sGXsfl_73_idx) ;
            ChangePostValue( "Z213cantDetaPed_"+sGXsfl_73_idx, cgiGet( "ZT_"+"Z213cantDetaPed_"+sGXsfl_73_idx)) ;
            DeletePostValue( "ZT_"+"Z213cantDetaPed_"+sGXsfl_73_idx) ;
            ChangePostValue( "Z36detTipoProdID_"+sGXsfl_73_idx, cgiGet( "ZT_"+"Z36detTipoProdID_"+sGXsfl_73_idx)) ;
            DeletePostValue( "ZT_"+"Z36detTipoProdID_"+sGXsfl_73_idx) ;
            ChangePostValue( "Z32categID_"+sGXsfl_73_idx, cgiGet( "ZT_"+"Z32categID_"+sGXsfl_73_idx)) ;
            DeletePostValue( "ZT_"+"Z32categID_"+sGXsfl_73_idx) ;
            ChangePostValue( "Z33subCatID_"+sGXsfl_73_idx, cgiGet( "ZT_"+"Z33subCatID_"+sGXsfl_73_idx)) ;
            DeletePostValue( "ZT_"+"Z33subCatID_"+sGXsfl_73_idx) ;
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
         context.SendWebValue( "Orden Pedido") ;
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
         context.AddJavascriptSource("gxcfg.js", "?202211192253977", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("ordenpedido.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV10EmpID) + "," + UrlEncode("" +AV7PedCod)+"\">") ;
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
         forbiddenHiddens = "hsh" + "OrdenPedido";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format(AV11fecha, "99/99/9999");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("ordenpedido:[SendSecurityCheck value for]"+"fecha:"+context.localUtil.Format(AV11fecha, "99/99/9999"));
         GXUtil.WriteLog("ordenpedido:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1EmpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z39PedCod", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z39PedCod), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z204PedDescripcion", StringUtil.RTrim( Z204PedDescripcion));
         GxWebStd.gx_hidden_field( context, "Z205PedFchReg", context.localUtil.DToC( Z205PedFchReg, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z206PedEst", StringUtil.RTrim( Z206PedEst));
         GxWebStd.gx_hidden_field( context, "Z207PedUltNro", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z207PedUltNro), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "O207PedUltNro", StringUtil.LTrim( StringUtil.NToC( (decimal)(O207PedUltNro), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_73", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_73_idx), 4, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV20TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV20TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10EmpID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vPEDCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7PedCod), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vPEDCOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7PedCod), "ZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vFECHA", context.localUtil.DToC( AV11fecha, 0, "/"));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV24Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "TIPOPRODID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A31tipoProdID), 4, 0, ",", "")));
      }

      protected void RenderHtmlCloseForm0D32( )
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
         return "OrdenPedido" ;
      }

      public override String GetPgmdesc( )
      {
         return "Orden Pedido" ;
      }

      protected void InitializeNonKey0D32( )
      {
         A44empdsc = "";
         n44empdsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         A204PedDescripcion = "";
         n204PedDescripcion = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A204PedDescripcion", A204PedDescripcion);
         n204PedDescripcion = (String.IsNullOrEmpty(StringUtil.RTrim( A204PedDescripcion)) ? true : false);
         A207PedUltNro = 0;
         n207PedUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PedUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PedUltNro), 8, 0)));
         n207PedUltNro = ((0==A207PedUltNro) ? true : false);
         A205PedFchReg = AV11fecha;
         n205PedFchReg = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A205PedFchReg", context.localUtil.Format(A205PedFchReg, "99/99/9999"));
         A206PedEst = "A";
         n206PedEst = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A206PedEst", A206PedEst);
         O207PedUltNro = A207PedUltNro;
         n207PedUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PedUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PedUltNro), 8, 0)));
         Z204PedDescripcion = "";
         Z205PedFchReg = DateTime.MinValue;
         Z206PedEst = "";
         Z207PedUltNro = 0;
      }

      protected void InitAll0D32( )
      {
         A1EmpID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         A39PedCod = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A39PedCod), 8, 0)));
         InitializeNonKey0D32( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A206PedEst = i206PedEst;
         n206PedEst = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A206PedEst", A206PedEst);
         A205PedFchReg = i205PedFchReg;
         n205PedFchReg = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A205PedFchReg", context.localUtil.Format(A205PedFchReg, "99/99/9999"));
      }

      protected void InitializeNonKey0D33( )
      {
         A31tipoProdID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A31tipoProdID), 4, 0)));
         A216PedTotal = 0;
         A214PedDetSaldo = 0;
         A36detTipoProdID = 0;
         A32categID = 0;
         A146categDsc = "";
         n146categDsc = false;
         A33subCatID = 0;
         A148subCatDsc = "";
         n148subCatDsc = false;
         A150subCatPrec = 0;
         n150subCatPrec = false;
         A151subCatPeso = 0;
         n151subCatPeso = false;
         A211subCatDisp = 0;
         n211subCatDisp = false;
         A212cantDetPed = 0;
         n212cantDetPed = false;
         A213cantDetaPed = 0;
         n213cantDetaPed = false;
         Z212cantDetPed = 0;
         Z213cantDetaPed = 0;
         Z36detTipoProdID = 0;
         Z32categID = 0;
         Z33subCatID = 0;
      }

      protected void InitAll0D33( )
      {
         A40OPIdSec = 0;
         InitializeNonKey0D33( ) ;
      }

      protected void StandaloneModalInsert0D33( )
      {
         A207PedUltNro = i207PedUltNro;
         n207PedUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207PedUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A207PedUltNro), 8, 0)));
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202211192253994", true);
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
         context.AddJavascriptSource("ordenpedido.js", "?202211192253994", false);
         /* End function include_jscripts */
      }

      protected void init_level_properties33( )
      {
         edtOPIdSec_Enabled = defedtOPIdSec_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOPIdSec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOPIdSec_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
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
         edtPedCod_Internalname = "PEDCOD";
         edtPedDescripcion_Internalname = "PEDDESCRIPCION";
         edtPedFchReg_Internalname = "PEDFCHREG";
         chkPedEst_Internalname = "PEDEST";
         edtPedUltNro_Internalname = "PEDULTNRO";
         lblTitleopid_Internalname = "TITLEOPID";
         edtOPIdSec_Internalname = "OPIDSEC";
         edtdetTipoProdID_Internalname = "DETTIPOPRODID";
         edtcategID_Internalname = "CATEGID";
         edtcategDsc_Internalname = "CATEGDSC";
         edtsubCatID_Internalname = "SUBCATID";
         edtsubCatDsc_Internalname = "SUBCATDSC";
         edtsubCatPrec_Internalname = "SUBCATPREC";
         edtsubCatPeso_Internalname = "SUBCATPESO";
         edtsubCatDisp_Internalname = "SUBCATDISP";
         edtcantDetPed_Internalname = "CANTDETPED";
         edtPedDetSaldo_Internalname = "PEDDETSALDO";
         edtcantDetaPed_Internalname = "CANTDETAPED";
         edtPedTotal_Internalname = "PEDTOTAL";
         divOpidtable_Internalname = "OPIDTABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_1_Internalname = "PROMPT_1";
         imgprompt_36_Internalname = "PROMPT_36";
         imgprompt_32_Internalname = "PROMPT_32";
         imgprompt_33_Internalname = "PROMPT_33";
         subGridordenpedido_opid_Internalname = "GRIDORDENPEDIDO_OPID";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtPedTotal_Jsonclick = "";
         edtcantDetaPed_Jsonclick = "";
         edtPedDetSaldo_Jsonclick = "";
         edtcantDetPed_Jsonclick = "";
         edtsubCatDisp_Jsonclick = "";
         edtsubCatPeso_Jsonclick = "";
         edtsubCatPrec_Jsonclick = "";
         edtsubCatDsc_Jsonclick = "";
         imgprompt_33_Visible = 1;
         imgprompt_33_Link = "";
         edtsubCatID_Jsonclick = "";
         edtcategDsc_Jsonclick = "";
         imgprompt_32_Visible = 1;
         imgprompt_32_Link = "";
         edtcategID_Jsonclick = "";
         imgprompt_36_Visible = 1;
         imgprompt_36_Link = "";
         imgprompt_1_Visible = 1;
         edtdetTipoProdID_Jsonclick = "";
         edtOPIdSec_Jsonclick = "";
         subGridordenpedido_opid_Class = "Grid";
         subGridordenpedido_opid_Backcolorstyle = 0;
         subGridordenpedido_opid_Allowcollapsing = 0;
         subGridordenpedido_opid_Allowselection = 0;
         edtPedTotal_Enabled = 0;
         edtcantDetaPed_Enabled = 1;
         edtPedDetSaldo_Enabled = 0;
         edtcantDetPed_Enabled = 1;
         edtsubCatDisp_Enabled = 0;
         edtsubCatPeso_Enabled = 0;
         edtsubCatPrec_Enabled = 0;
         edtsubCatDsc_Enabled = 0;
         edtsubCatID_Enabled = 1;
         edtcategDsc_Enabled = 0;
         edtcategID_Enabled = 1;
         edtdetTipoProdID_Enabled = 1;
         edtOPIdSec_Enabled = 0;
         subGridordenpedido_opid_Sortable = 0;
         subGridordenpedido_opid_Header = "";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtPedUltNro_Jsonclick = "";
         edtPedUltNro_Enabled = 0;
         chkPedEst.Enabled = 1;
         edtPedFchReg_Jsonclick = "";
         edtPedFchReg_Enabled = 1;
         edtPedDescripcion_Enabled = 1;
         edtPedCod_Jsonclick = "";
         edtPedCod_Enabled = 1;
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

      protected void gxnrGridordenpedido_opid_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_7333( ) ;
         while ( nGXsfl_73_idx <= nRC_GXsfl_73 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0D33( ) ;
            standaloneModal0D33( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow0D33( ) ;
            nGXsfl_73_idx = (short)(nGXsfl_73_idx+1);
            sGXsfl_73_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_73_idx), 4, 0)), 4, "0");
            SubsflControlProps_7333( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Gridordenpedido_opidContainer));
         /* End function gxnrGridordenpedido_opid_newrow */
      }

      protected void init_web_controls( )
      {
         chkPedEst.Name = "PEDEST";
         chkPedEst.WebTags = "";
         chkPedEst.Caption = "Activo?";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkPedEst_Internalname, "TitleCaption", chkPedEst.Caption, true);
         chkPedEst.CheckedValue = "I";
         /* End function init_web_controls */
      }

      public void Valid_Empid( short GX_Parm1 ,
                               String GX_Parm2 )
      {
         A1EmpID = GX_Parm1;
         A44empdsc = GX_Parm2;
         n44empdsc = false;
         /* Using cursor T000D19 */
         pr_default.execute(17, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(17) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A44empdsc = T000D19_A44empdsc[0];
         n44empdsc = T000D19_n44empdsc[0];
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

      public void Valid_Dettipoprodid( short GX_Parm1 ,
                                       short GX_Parm2 )
      {
         A1EmpID = GX_Parm1;
         A36detTipoProdID = GX_Parm2;
         /* Using cursor T000D32 */
         pr_default.execute(30, new Object[] {A1EmpID, A36detTipoProdID});
         if ( (pr_default.getStatus(30) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Producto'.", "ForeignKeyNotFound", 1, "DETTIPOPRODID");
            AnyError = 1;
            GX_FocusControl = edtdetTipoProdID_Internalname;
         }
         pr_default.close(30);
         dynload_actions( ) ;
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Categid( short GX_Parm1 ,
                                 short GX_Parm2 ,
                                 String GX_Parm3 )
      {
         A1EmpID = GX_Parm1;
         A32categID = GX_Parm2;
         A146categDsc = GX_Parm3;
         n146categDsc = false;
         /* Using cursor T000D29 */
         pr_default.execute(27, new Object[] {A1EmpID, A32categID});
         if ( (pr_default.getStatus(27) == 101) )
         {
            GX_msglist.addItem("No existe 'Categorias'.", "ForeignKeyNotFound", 1, "CATEGID");
            AnyError = 1;
            GX_FocusControl = edtcategID_Internalname;
         }
         A146categDsc = T000D29_A146categDsc[0];
         n146categDsc = T000D29_n146categDsc[0];
         pr_default.close(27);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A146categDsc = "";
            n146categDsc = false;
         }
         isValidOutput.Add(StringUtil.RTrim( A146categDsc));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Subcatid( short GX_Parm1 ,
                                  short GX_Parm2 ,
                                  short GX_Parm3 ,
                                  String GX_Parm4 ,
                                  decimal GX_Parm5 ,
                                  decimal GX_Parm6 ,
                                  int GX_Parm7 )
      {
         A1EmpID = GX_Parm1;
         A32categID = GX_Parm2;
         A33subCatID = GX_Parm3;
         A148subCatDsc = GX_Parm4;
         n148subCatDsc = false;
         A150subCatPrec = GX_Parm5;
         n150subCatPrec = false;
         A151subCatPeso = GX_Parm6;
         n151subCatPeso = false;
         A211subCatDisp = GX_Parm7;
         n211subCatDisp = false;
         /* Using cursor T000D30 */
         pr_default.execute(28, new Object[] {A1EmpID, A32categID, A33subCatID});
         if ( (pr_default.getStatus(28) == 101) )
         {
            GX_msglist.addItem("No existe 'sub Cat'.", "ForeignKeyNotFound", 1, "CATEGID");
            AnyError = 1;
            GX_FocusControl = edtcategID_Internalname;
         }
         A148subCatDsc = T000D30_A148subCatDsc[0];
         n148subCatDsc = T000D30_n148subCatDsc[0];
         A150subCatPrec = T000D30_A150subCatPrec[0];
         n150subCatPrec = T000D30_n150subCatPrec[0];
         A151subCatPeso = T000D30_A151subCatPeso[0];
         n151subCatPeso = T000D30_n151subCatPeso[0];
         A211subCatDisp = T000D30_A211subCatDisp[0];
         n211subCatDisp = T000D30_n211subCatDisp[0];
         pr_default.close(28);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A148subCatDsc = "";
            n148subCatDsc = false;
            A150subCatPrec = 0;
            n150subCatPrec = false;
            A151subCatPeso = 0;
            n151subCatPeso = false;
            A211subCatDisp = 0;
            n211subCatDisp = false;
         }
         isValidOutput.Add(StringUtil.RTrim( A148subCatDsc));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A150subCatPrec, 8, 2, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A151subCatPeso, 8, 2, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A211subCatDisp), 8, 0, ".", "")));
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV10EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV7PedCod',fld:'vPEDCOD',pic:'ZZZZZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV10EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV7PedCod',fld:'vPEDCOD',pic:'ZZZZZZZ9',hsh:true},{av:'AV11fecha',fld:'vFECHA',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120D2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV20TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(30);
         pr_default.close(27);
         pr_default.close(28);
         pr_default.close(7);
         pr_default.close(17);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z204PedDescripcion = "";
         Z205PedFchReg = DateTime.MinValue;
         Z206PedEst = "";
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
         A204PedDescripcion = "";
         A205PedFchReg = DateTime.MinValue;
         A206PedEst = "";
         lblTitleopid_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridordenpedido_opidContainer = new GXWebGrid( context);
         Gridordenpedido_opidColumn = new GXWebColumn();
         A146categDsc = "";
         A148subCatDsc = "";
         sMode33 = "";
         sStyleString = "";
         AV11fecha = DateTime.MinValue;
         AV24Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode32 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV20TrnContext = new SdtTransactionContext(context);
         AV22WebSession = context.GetSession();
         Z44empdsc = "";
         T000D10_A44empdsc = new String[] {""} ;
         T000D10_n44empdsc = new bool[] {false} ;
         T000D11_A39PedCod = new int[1] ;
         T000D11_A44empdsc = new String[] {""} ;
         T000D11_n44empdsc = new bool[] {false} ;
         T000D11_A204PedDescripcion = new String[] {""} ;
         T000D11_n204PedDescripcion = new bool[] {false} ;
         T000D11_A205PedFchReg = new DateTime[] {DateTime.MinValue} ;
         T000D11_n205PedFchReg = new bool[] {false} ;
         T000D11_A206PedEst = new String[] {""} ;
         T000D11_n206PedEst = new bool[] {false} ;
         T000D11_A207PedUltNro = new int[1] ;
         T000D11_n207PedUltNro = new bool[] {false} ;
         T000D11_A1EmpID = new short[1] ;
         T000D12_A44empdsc = new String[] {""} ;
         T000D12_n44empdsc = new bool[] {false} ;
         T000D13_A1EmpID = new short[1] ;
         T000D13_A39PedCod = new int[1] ;
         T000D9_A39PedCod = new int[1] ;
         T000D9_A204PedDescripcion = new String[] {""} ;
         T000D9_n204PedDescripcion = new bool[] {false} ;
         T000D9_A205PedFchReg = new DateTime[] {DateTime.MinValue} ;
         T000D9_n205PedFchReg = new bool[] {false} ;
         T000D9_A206PedEst = new String[] {""} ;
         T000D9_n206PedEst = new bool[] {false} ;
         T000D9_A207PedUltNro = new int[1] ;
         T000D9_n207PedUltNro = new bool[] {false} ;
         T000D9_A1EmpID = new short[1] ;
         T000D14_A1EmpID = new short[1] ;
         T000D14_A39PedCod = new int[1] ;
         T000D15_A1EmpID = new short[1] ;
         T000D15_A39PedCod = new int[1] ;
         T000D8_A39PedCod = new int[1] ;
         T000D8_A204PedDescripcion = new String[] {""} ;
         T000D8_n204PedDescripcion = new bool[] {false} ;
         T000D8_A205PedFchReg = new DateTime[] {DateTime.MinValue} ;
         T000D8_n205PedFchReg = new bool[] {false} ;
         T000D8_A206PedEst = new String[] {""} ;
         T000D8_n206PedEst = new bool[] {false} ;
         T000D8_A207PedUltNro = new int[1] ;
         T000D8_n207PedUltNro = new bool[] {false} ;
         T000D8_A1EmpID = new short[1] ;
         T000D19_A44empdsc = new String[] {""} ;
         T000D19_n44empdsc = new bool[] {false} ;
         T000D21_A1EmpID = new short[1] ;
         T000D21_A39PedCod = new int[1] ;
         Z146categDsc = "";
         Z148subCatDsc = "";
         T000D22_A39PedCod = new int[1] ;
         T000D22_A40OPIdSec = new int[1] ;
         T000D22_A146categDsc = new String[] {""} ;
         T000D22_n146categDsc = new bool[] {false} ;
         T000D22_A148subCatDsc = new String[] {""} ;
         T000D22_n148subCatDsc = new bool[] {false} ;
         T000D22_A150subCatPrec = new decimal[1] ;
         T000D22_n150subCatPrec = new bool[] {false} ;
         T000D22_A151subCatPeso = new decimal[1] ;
         T000D22_n151subCatPeso = new bool[] {false} ;
         T000D22_A211subCatDisp = new int[1] ;
         T000D22_n211subCatDisp = new bool[] {false} ;
         T000D22_A212cantDetPed = new decimal[1] ;
         T000D22_n212cantDetPed = new bool[] {false} ;
         T000D22_A213cantDetaPed = new decimal[1] ;
         T000D22_n213cantDetaPed = new bool[] {false} ;
         T000D22_A1EmpID = new short[1] ;
         T000D22_A36detTipoProdID = new short[1] ;
         T000D22_A32categID = new short[1] ;
         T000D22_A33subCatID = new short[1] ;
         T000D4_A31tipoProdID = new short[1] ;
         GXCCtl = "";
         T000D5_A146categDsc = new String[] {""} ;
         T000D5_n146categDsc = new bool[] {false} ;
         T000D6_A148subCatDsc = new String[] {""} ;
         T000D6_n148subCatDsc = new bool[] {false} ;
         T000D6_A150subCatPrec = new decimal[1] ;
         T000D6_n150subCatPrec = new bool[] {false} ;
         T000D6_A151subCatPeso = new decimal[1] ;
         T000D6_n151subCatPeso = new bool[] {false} ;
         T000D6_A211subCatDisp = new int[1] ;
         T000D6_n211subCatDisp = new bool[] {false} ;
         T000D23_A146categDsc = new String[] {""} ;
         T000D23_n146categDsc = new bool[] {false} ;
         T000D24_A148subCatDsc = new String[] {""} ;
         T000D24_n148subCatDsc = new bool[] {false} ;
         T000D24_A150subCatPrec = new decimal[1] ;
         T000D24_n150subCatPrec = new bool[] {false} ;
         T000D24_A151subCatPeso = new decimal[1] ;
         T000D24_n151subCatPeso = new bool[] {false} ;
         T000D24_A211subCatDisp = new int[1] ;
         T000D24_n211subCatDisp = new bool[] {false} ;
         T000D25_A1EmpID = new short[1] ;
         T000D25_A39PedCod = new int[1] ;
         T000D25_A40OPIdSec = new int[1] ;
         T000D3_A39PedCod = new int[1] ;
         T000D3_A40OPIdSec = new int[1] ;
         T000D3_A212cantDetPed = new decimal[1] ;
         T000D3_n212cantDetPed = new bool[] {false} ;
         T000D3_A213cantDetaPed = new decimal[1] ;
         T000D3_n213cantDetaPed = new bool[] {false} ;
         T000D3_A1EmpID = new short[1] ;
         T000D3_A36detTipoProdID = new short[1] ;
         T000D3_A32categID = new short[1] ;
         T000D3_A33subCatID = new short[1] ;
         T000D2_A39PedCod = new int[1] ;
         T000D2_A40OPIdSec = new int[1] ;
         T000D2_A212cantDetPed = new decimal[1] ;
         T000D2_n212cantDetPed = new bool[] {false} ;
         T000D2_A213cantDetaPed = new decimal[1] ;
         T000D2_n213cantDetaPed = new bool[] {false} ;
         T000D2_A1EmpID = new short[1] ;
         T000D2_A36detTipoProdID = new short[1] ;
         T000D2_A32categID = new short[1] ;
         T000D2_A33subCatID = new short[1] ;
         T000D29_A146categDsc = new String[] {""} ;
         T000D29_n146categDsc = new bool[] {false} ;
         T000D30_A148subCatDsc = new String[] {""} ;
         T000D30_n148subCatDsc = new bool[] {false} ;
         T000D30_A150subCatPrec = new decimal[1] ;
         T000D30_n150subCatPrec = new bool[] {false} ;
         T000D30_A151subCatPeso = new decimal[1] ;
         T000D30_n151subCatPeso = new bool[] {false} ;
         T000D30_A211subCatDisp = new int[1] ;
         T000D30_n211subCatDisp = new bool[] {false} ;
         T000D31_A1EmpID = new short[1] ;
         T000D31_A39PedCod = new int[1] ;
         T000D31_A40OPIdSec = new int[1] ;
         Gridordenpedido_opidRow = new GXWebRow();
         subGridordenpedido_opid_Linesclass = "";
         ROClassString = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         i206PedEst = "";
         i205PedFchReg = DateTime.MinValue;
         isValidOutput = new GxUnknownObjectCollection();
         T000D32_A31tipoProdID = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ordenpedido__default(),
            new Object[][] {
                new Object[] {
               T000D2_A39PedCod, T000D2_A40OPIdSec, T000D2_A212cantDetPed, T000D2_n212cantDetPed, T000D2_A213cantDetaPed, T000D2_n213cantDetaPed, T000D2_A1EmpID, T000D2_A36detTipoProdID, T000D2_A32categID, T000D2_A33subCatID
               }
               , new Object[] {
               T000D3_A39PedCod, T000D3_A40OPIdSec, T000D3_A212cantDetPed, T000D3_n212cantDetPed, T000D3_A213cantDetaPed, T000D3_n213cantDetaPed, T000D3_A1EmpID, T000D3_A36detTipoProdID, T000D3_A32categID, T000D3_A33subCatID
               }
               , new Object[] {
               T000D4_A31tipoProdID
               }
               , new Object[] {
               T000D5_A146categDsc, T000D5_n146categDsc
               }
               , new Object[] {
               T000D6_A148subCatDsc, T000D6_n148subCatDsc, T000D6_A150subCatPrec, T000D6_n150subCatPrec, T000D6_A151subCatPeso, T000D6_n151subCatPeso, T000D6_A211subCatDisp, T000D6_n211subCatDisp
               }
               , new Object[] {
               T000D7_A31tipoProdID
               }
               , new Object[] {
               T000D8_A39PedCod, T000D8_A204PedDescripcion, T000D8_n204PedDescripcion, T000D8_A205PedFchReg, T000D8_n205PedFchReg, T000D8_A206PedEst, T000D8_n206PedEst, T000D8_A207PedUltNro, T000D8_n207PedUltNro, T000D8_A1EmpID
               }
               , new Object[] {
               T000D9_A39PedCod, T000D9_A204PedDescripcion, T000D9_n204PedDescripcion, T000D9_A205PedFchReg, T000D9_n205PedFchReg, T000D9_A206PedEst, T000D9_n206PedEst, T000D9_A207PedUltNro, T000D9_n207PedUltNro, T000D9_A1EmpID
               }
               , new Object[] {
               T000D10_A44empdsc, T000D10_n44empdsc
               }
               , new Object[] {
               T000D11_A39PedCod, T000D11_A44empdsc, T000D11_n44empdsc, T000D11_A204PedDescripcion, T000D11_n204PedDescripcion, T000D11_A205PedFchReg, T000D11_n205PedFchReg, T000D11_A206PedEst, T000D11_n206PedEst, T000D11_A207PedUltNro,
               T000D11_n207PedUltNro, T000D11_A1EmpID
               }
               , new Object[] {
               T000D12_A44empdsc, T000D12_n44empdsc
               }
               , new Object[] {
               T000D13_A1EmpID, T000D13_A39PedCod
               }
               , new Object[] {
               T000D14_A1EmpID, T000D14_A39PedCod
               }
               , new Object[] {
               T000D15_A1EmpID, T000D15_A39PedCod
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000D19_A44empdsc, T000D19_n44empdsc
               }
               , new Object[] {
               }
               , new Object[] {
               T000D21_A1EmpID, T000D21_A39PedCod
               }
               , new Object[] {
               T000D22_A39PedCod, T000D22_A40OPIdSec, T000D22_A146categDsc, T000D22_n146categDsc, T000D22_A148subCatDsc, T000D22_n148subCatDsc, T000D22_A150subCatPrec, T000D22_n150subCatPrec, T000D22_A151subCatPeso, T000D22_n151subCatPeso,
               T000D22_A211subCatDisp, T000D22_n211subCatDisp, T000D22_A212cantDetPed, T000D22_n212cantDetPed, T000D22_A213cantDetaPed, T000D22_n213cantDetaPed, T000D22_A1EmpID, T000D22_A36detTipoProdID, T000D22_A32categID, T000D22_A33subCatID
               }
               , new Object[] {
               T000D23_A146categDsc, T000D23_n146categDsc
               }
               , new Object[] {
               T000D24_A148subCatDsc, T000D24_n148subCatDsc, T000D24_A150subCatPrec, T000D24_n150subCatPrec, T000D24_A151subCatPeso, T000D24_n151subCatPeso, T000D24_A211subCatDisp, T000D24_n211subCatDisp
               }
               , new Object[] {
               T000D25_A1EmpID, T000D25_A39PedCod, T000D25_A40OPIdSec
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000D29_A146categDsc, T000D29_n146categDsc
               }
               , new Object[] {
               T000D30_A148subCatDsc, T000D30_n148subCatDsc, T000D30_A150subCatPrec, T000D30_n150subCatPrec, T000D30_A151subCatPeso, T000D30_n151subCatPeso, T000D30_A211subCatDisp, T000D30_n211subCatDisp
               }
               , new Object[] {
               T000D31_A1EmpID, T000D31_A39PedCod, T000D31_A40OPIdSec
               }
               , new Object[] {
               T000D32_A31tipoProdID
               }
            }
         );
         AV24Pgmname = "OrdenPedido";
         Z205PedFchReg = DateTime.MinValue;
         n205PedFchReg = false;
         A205PedFchReg = DateTime.MinValue;
         n205PedFchReg = false;
         i205PedFchReg = DateTime.MinValue;
         n205PedFchReg = false;
         Z206PedEst = "A";
         n206PedEst = false;
         A206PedEst = "A";
         n206PedEst = false;
         i206PedEst = "A";
         n206PedEst = false;
      }

      private short nIsMod_33 ;
      private short wcpOAV10EmpID ;
      private short Z1EmpID ;
      private short nRC_GXsfl_73 ;
      private short nGXsfl_73_idx=1 ;
      private short Z36detTipoProdID ;
      private short Z32categID ;
      private short Z33subCatID ;
      private short nRcdDeleted_33 ;
      private short nRcdExists_33 ;
      private short GxWebError ;
      private short A1EmpID ;
      private short A36detTipoProdID ;
      private short A32categID ;
      private short A33subCatID ;
      private short Gx_BScreen ;
      private short AV10EmpID ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short subGridordenpedido_opid_Backcolorstyle ;
      private short subGridordenpedido_opid_Sortable ;
      private short subGridordenpedido_opid_Allowselection ;
      private short subGridordenpedido_opid_Allowhovering ;
      private short subGridordenpedido_opid_Allowcollapsing ;
      private short subGridordenpedido_opid_Collapsed ;
      private short nBlankRcdCount33 ;
      private short RcdFound33 ;
      private short nBlankRcdUsr33 ;
      private short A31tipoProdID ;
      private short RcdFound32 ;
      private short GX_JID ;
      private short subGridordenpedido_opid_Backstyle ;
      private short wbTemp ;
      private int wcpOAV7PedCod ;
      private int Z39PedCod ;
      private int Z207PedUltNro ;
      private int O207PedUltNro ;
      private int Z40OPIdSec ;
      private int A207PedUltNro ;
      private int AV7PedCod ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtEmpID_Enabled ;
      private int imgprompt_1_Visible ;
      private int edtempdsc_Enabled ;
      private int A39PedCod ;
      private int edtPedCod_Enabled ;
      private int edtPedDescripcion_Enabled ;
      private int edtPedFchReg_Enabled ;
      private int edtPedUltNro_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int A40OPIdSec ;
      private int edtOPIdSec_Enabled ;
      private int edtdetTipoProdID_Enabled ;
      private int edtcategID_Enabled ;
      private int edtcategDsc_Enabled ;
      private int edtsubCatID_Enabled ;
      private int edtsubCatDsc_Enabled ;
      private int edtsubCatPrec_Enabled ;
      private int edtsubCatPeso_Enabled ;
      private int A211subCatDisp ;
      private int edtsubCatDisp_Enabled ;
      private int edtcantDetPed_Enabled ;
      private int edtPedDetSaldo_Enabled ;
      private int edtcantDetaPed_Enabled ;
      private int edtPedTotal_Enabled ;
      private int subGridordenpedido_opid_Selectedindex ;
      private int subGridordenpedido_opid_Selectioncolor ;
      private int subGridordenpedido_opid_Hoveringcolor ;
      private int B207PedUltNro ;
      private int fRowAdded ;
      private int s207PedUltNro ;
      private int Z211subCatDisp ;
      private int subGridordenpedido_opid_Backcolor ;
      private int subGridordenpedido_opid_Allbackcolor ;
      private int imgprompt_36_Visible ;
      private int imgprompt_32_Visible ;
      private int imgprompt_33_Visible ;
      private int defedtOPIdSec_Enabled ;
      private int i207PedUltNro ;
      private int idxLst ;
      private long GRIDORDENPEDIDO_OPID_nFirstRecordOnPage ;
      private decimal Z212cantDetPed ;
      private decimal Z213cantDetaPed ;
      private decimal A150subCatPrec ;
      private decimal A151subCatPeso ;
      private decimal A212cantDetPed ;
      private decimal A214PedDetSaldo ;
      private decimal A213cantDetaPed ;
      private decimal A216PedTotal ;
      private decimal Z150subCatPrec ;
      private decimal Z151subCatPeso ;
      private String sPrefix ;
      private String sGXsfl_73_idx="0001" ;
      private String wcpOGx_mode ;
      private String Z204PedDescripcion ;
      private String Z206PedEst ;
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
      private String edtPedCod_Internalname ;
      private String edtPedCod_Jsonclick ;
      private String edtPedDescripcion_Internalname ;
      private String A204PedDescripcion ;
      private String edtPedFchReg_Internalname ;
      private String edtPedFchReg_Jsonclick ;
      private String chkPedEst_Internalname ;
      private String A206PedEst ;
      private String edtPedUltNro_Internalname ;
      private String edtPedUltNro_Jsonclick ;
      private String divOpidtable_Internalname ;
      private String lblTitleopid_Internalname ;
      private String lblTitleopid_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridordenpedido_opid_Header ;
      private String A146categDsc ;
      private String A148subCatDsc ;
      private String sMode33 ;
      private String edtOPIdSec_Internalname ;
      private String edtdetTipoProdID_Internalname ;
      private String edtcategID_Internalname ;
      private String edtcategDsc_Internalname ;
      private String edtsubCatID_Internalname ;
      private String edtsubCatDsc_Internalname ;
      private String edtsubCatPrec_Internalname ;
      private String edtsubCatPeso_Internalname ;
      private String edtsubCatDisp_Internalname ;
      private String edtcantDetPed_Internalname ;
      private String edtPedDetSaldo_Internalname ;
      private String edtcantDetaPed_Internalname ;
      private String edtPedTotal_Internalname ;
      private String sStyleString ;
      private String AV24Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode32 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z146categDsc ;
      private String Z148subCatDsc ;
      private String GXCCtl ;
      private String imgprompt_36_Internalname ;
      private String imgprompt_32_Internalname ;
      private String imgprompt_33_Internalname ;
      private String sGXsfl_73_fel_idx="0001" ;
      private String subGridordenpedido_opid_Class ;
      private String subGridordenpedido_opid_Linesclass ;
      private String imgprompt_33_Link ;
      private String imgprompt_32_Link ;
      private String imgprompt_36_Link ;
      private String ROClassString ;
      private String edtOPIdSec_Jsonclick ;
      private String edtdetTipoProdID_Jsonclick ;
      private String edtcategID_Jsonclick ;
      private String edtcategDsc_Jsonclick ;
      private String edtsubCatID_Jsonclick ;
      private String edtsubCatDsc_Jsonclick ;
      private String edtsubCatPrec_Jsonclick ;
      private String edtsubCatPeso_Jsonclick ;
      private String edtsubCatDisp_Jsonclick ;
      private String edtcantDetPed_Jsonclick ;
      private String edtPedDetSaldo_Jsonclick ;
      private String edtcantDetaPed_Jsonclick ;
      private String edtPedTotal_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String i206PedEst ;
      private String subGridordenpedido_opid_Internalname ;
      private DateTime Z205PedFchReg ;
      private DateTime A205PedFchReg ;
      private DateTime AV11fecha ;
      private DateTime i205PedFchReg ;
      private bool entryPointCalled ;
      private bool n207PedUltNro ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool bGXsfl_73_Refreshing=false ;
      private bool n44empdsc ;
      private bool n204PedDescripcion ;
      private bool n205PedFchReg ;
      private bool n206PedEst ;
      private bool returnInSub ;
      private bool n146categDsc ;
      private bool n148subCatDsc ;
      private bool n150subCatPrec ;
      private bool n151subCatPeso ;
      private bool n211subCatDisp ;
      private bool n212cantDetPed ;
      private bool n213cantDetaPed ;
      private String A44empdsc ;
      private String Z44empdsc ;
      private IGxSession AV22WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebGrid Gridordenpedido_opidContainer ;
      private GXWebRow Gridordenpedido_opidRow ;
      private GXWebColumn Gridordenpedido_opidColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCheckbox chkPedEst ;
      private IDataStoreProvider pr_default ;
      private String[] T000D10_A44empdsc ;
      private bool[] T000D10_n44empdsc ;
      private int[] T000D11_A39PedCod ;
      private String[] T000D11_A44empdsc ;
      private bool[] T000D11_n44empdsc ;
      private String[] T000D11_A204PedDescripcion ;
      private bool[] T000D11_n204PedDescripcion ;
      private DateTime[] T000D11_A205PedFchReg ;
      private bool[] T000D11_n205PedFchReg ;
      private String[] T000D11_A206PedEst ;
      private bool[] T000D11_n206PedEst ;
      private int[] T000D11_A207PedUltNro ;
      private bool[] T000D11_n207PedUltNro ;
      private short[] T000D11_A1EmpID ;
      private String[] T000D12_A44empdsc ;
      private bool[] T000D12_n44empdsc ;
      private short[] T000D13_A1EmpID ;
      private int[] T000D13_A39PedCod ;
      private int[] T000D9_A39PedCod ;
      private String[] T000D9_A204PedDescripcion ;
      private bool[] T000D9_n204PedDescripcion ;
      private DateTime[] T000D9_A205PedFchReg ;
      private bool[] T000D9_n205PedFchReg ;
      private String[] T000D9_A206PedEst ;
      private bool[] T000D9_n206PedEst ;
      private int[] T000D9_A207PedUltNro ;
      private bool[] T000D9_n207PedUltNro ;
      private short[] T000D9_A1EmpID ;
      private short[] T000D14_A1EmpID ;
      private int[] T000D14_A39PedCod ;
      private short[] T000D15_A1EmpID ;
      private int[] T000D15_A39PedCod ;
      private int[] T000D8_A39PedCod ;
      private String[] T000D8_A204PedDescripcion ;
      private bool[] T000D8_n204PedDescripcion ;
      private DateTime[] T000D8_A205PedFchReg ;
      private bool[] T000D8_n205PedFchReg ;
      private String[] T000D8_A206PedEst ;
      private bool[] T000D8_n206PedEst ;
      private int[] T000D8_A207PedUltNro ;
      private bool[] T000D8_n207PedUltNro ;
      private short[] T000D8_A1EmpID ;
      private String[] T000D19_A44empdsc ;
      private bool[] T000D19_n44empdsc ;
      private short[] T000D21_A1EmpID ;
      private int[] T000D21_A39PedCod ;
      private int[] T000D22_A39PedCod ;
      private int[] T000D22_A40OPIdSec ;
      private String[] T000D22_A146categDsc ;
      private bool[] T000D22_n146categDsc ;
      private String[] T000D22_A148subCatDsc ;
      private bool[] T000D22_n148subCatDsc ;
      private decimal[] T000D22_A150subCatPrec ;
      private bool[] T000D22_n150subCatPrec ;
      private decimal[] T000D22_A151subCatPeso ;
      private bool[] T000D22_n151subCatPeso ;
      private int[] T000D22_A211subCatDisp ;
      private bool[] T000D22_n211subCatDisp ;
      private decimal[] T000D22_A212cantDetPed ;
      private bool[] T000D22_n212cantDetPed ;
      private decimal[] T000D22_A213cantDetaPed ;
      private bool[] T000D22_n213cantDetaPed ;
      private short[] T000D22_A1EmpID ;
      private short[] T000D22_A36detTipoProdID ;
      private short[] T000D22_A32categID ;
      private short[] T000D22_A33subCatID ;
      private short[] T000D4_A31tipoProdID ;
      private String[] T000D5_A146categDsc ;
      private bool[] T000D5_n146categDsc ;
      private String[] T000D6_A148subCatDsc ;
      private bool[] T000D6_n148subCatDsc ;
      private decimal[] T000D6_A150subCatPrec ;
      private bool[] T000D6_n150subCatPrec ;
      private decimal[] T000D6_A151subCatPeso ;
      private bool[] T000D6_n151subCatPeso ;
      private int[] T000D6_A211subCatDisp ;
      private bool[] T000D6_n211subCatDisp ;
      private String[] T000D23_A146categDsc ;
      private bool[] T000D23_n146categDsc ;
      private String[] T000D24_A148subCatDsc ;
      private bool[] T000D24_n148subCatDsc ;
      private decimal[] T000D24_A150subCatPrec ;
      private bool[] T000D24_n150subCatPrec ;
      private decimal[] T000D24_A151subCatPeso ;
      private bool[] T000D24_n151subCatPeso ;
      private int[] T000D24_A211subCatDisp ;
      private bool[] T000D24_n211subCatDisp ;
      private short[] T000D25_A1EmpID ;
      private int[] T000D25_A39PedCod ;
      private int[] T000D25_A40OPIdSec ;
      private int[] T000D3_A39PedCod ;
      private int[] T000D3_A40OPIdSec ;
      private decimal[] T000D3_A212cantDetPed ;
      private bool[] T000D3_n212cantDetPed ;
      private decimal[] T000D3_A213cantDetaPed ;
      private bool[] T000D3_n213cantDetaPed ;
      private short[] T000D3_A1EmpID ;
      private short[] T000D3_A36detTipoProdID ;
      private short[] T000D3_A32categID ;
      private short[] T000D3_A33subCatID ;
      private int[] T000D2_A39PedCod ;
      private int[] T000D2_A40OPIdSec ;
      private decimal[] T000D2_A212cantDetPed ;
      private bool[] T000D2_n212cantDetPed ;
      private decimal[] T000D2_A213cantDetaPed ;
      private bool[] T000D2_n213cantDetaPed ;
      private short[] T000D2_A1EmpID ;
      private short[] T000D2_A36detTipoProdID ;
      private short[] T000D2_A32categID ;
      private short[] T000D2_A33subCatID ;
      private String[] T000D29_A146categDsc ;
      private bool[] T000D29_n146categDsc ;
      private String[] T000D30_A148subCatDsc ;
      private bool[] T000D30_n148subCatDsc ;
      private decimal[] T000D30_A150subCatPrec ;
      private bool[] T000D30_n150subCatPrec ;
      private decimal[] T000D30_A151subCatPeso ;
      private bool[] T000D30_n151subCatPeso ;
      private int[] T000D30_A211subCatDisp ;
      private bool[] T000D30_n211subCatDisp ;
      private short[] T000D31_A1EmpID ;
      private int[] T000D31_A39PedCod ;
      private int[] T000D31_A40OPIdSec ;
      private short[] T000D32_A31tipoProdID ;
      private short[] T000D7_A31tipoProdID ;
      private SdtTransactionContext AV20TrnContext ;
   }

   public class ordenpedido__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new ForEachCursor(def[22])
         ,new ForEachCursor(def[23])
         ,new UpdateCursor(def[24])
         ,new UpdateCursor(def[25])
         ,new UpdateCursor(def[26])
         ,new ForEachCursor(def[27])
         ,new ForEachCursor(def[28])
         ,new ForEachCursor(def[29])
         ,new ForEachCursor(def[30])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000D7 ;
          prmT000D7 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000D11 ;
          prmT000D11 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PedCod",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000D10 ;
          prmT000D10 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000D12 ;
          prmT000D12 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000D13 ;
          prmT000D13 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PedCod",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000D9 ;
          prmT000D9 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PedCod",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000D14 ;
          prmT000D14 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PedCod",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000D15 ;
          prmT000D15 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PedCod",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000D8 ;
          prmT000D8 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PedCod",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000D16 ;
          prmT000D16 = new Object[] {
          new Object[] {"@PedCod",SqlDbType.Int,8,0} ,
          new Object[] {"@PedDescripcion",SqlDbType.Char,50,0} ,
          new Object[] {"@PedFchReg",SqlDbType.DateTime,8,0} ,
          new Object[] {"@PedEst",SqlDbType.Char,1,0} ,
          new Object[] {"@PedUltNro",SqlDbType.Int,8,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000D17 ;
          prmT000D17 = new Object[] {
          new Object[] {"@PedDescripcion",SqlDbType.Char,50,0} ,
          new Object[] {"@PedFchReg",SqlDbType.DateTime,8,0} ,
          new Object[] {"@PedEst",SqlDbType.Char,1,0} ,
          new Object[] {"@PedUltNro",SqlDbType.Int,8,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PedCod",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000D18 ;
          prmT000D18 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PedCod",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000D20 ;
          prmT000D20 = new Object[] {
          new Object[] {"@PedUltNro",SqlDbType.Int,8,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PedCod",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000D21 ;
          prmT000D21 = new Object[] {
          } ;
          Object[] prmT000D22 ;
          prmT000D22 = new Object[] {
          new Object[] {"@PedCod",SqlDbType.Int,8,0} ,
          new Object[] {"@OPIdSec",SqlDbType.Int,8,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000D5 ;
          prmT000D5 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000D6 ;
          prmT000D6 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000D4 ;
          prmT000D4 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000D23 ;
          prmT000D23 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000D24 ;
          prmT000D24 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000D25 ;
          prmT000D25 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PedCod",SqlDbType.Int,8,0} ,
          new Object[] {"@OPIdSec",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000D3 ;
          prmT000D3 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PedCod",SqlDbType.Int,8,0} ,
          new Object[] {"@OPIdSec",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000D2 ;
          prmT000D2 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PedCod",SqlDbType.Int,8,0} ,
          new Object[] {"@OPIdSec",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000D26 ;
          prmT000D26 = new Object[] {
          new Object[] {"@PedCod",SqlDbType.Int,8,0} ,
          new Object[] {"@OPIdSec",SqlDbType.Int,8,0} ,
          new Object[] {"@cantDetPed",SqlDbType.Decimal,8,2} ,
          new Object[] {"@cantDetaPed",SqlDbType.Decimal,8,2} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000D27 ;
          prmT000D27 = new Object[] {
          new Object[] {"@cantDetPed",SqlDbType.Decimal,8,2} ,
          new Object[] {"@cantDetaPed",SqlDbType.Decimal,8,2} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PedCod",SqlDbType.Int,8,0} ,
          new Object[] {"@OPIdSec",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000D28 ;
          prmT000D28 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PedCod",SqlDbType.Int,8,0} ,
          new Object[] {"@OPIdSec",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000D31 ;
          prmT000D31 = new Object[] {
          new Object[] {"@PedCod",SqlDbType.Int,8,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000D19 ;
          prmT000D19 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000D32 ;
          prmT000D32 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000D29 ;
          prmT000D29 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000D30 ;
          prmT000D30 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000D2", "SELECT [PedCod], [OPIdSec], [cantDetPed], [cantDetaPed], [EmpID], [detTipoProdID], [categID], [subCatID] FROM [OrdenPedidoOPId] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [PedCod] = @PedCod AND [OPIdSec] = @OPIdSec ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D2,1,0,true,false )
             ,new CursorDef("T000D3", "SELECT [PedCod], [OPIdSec], [cantDetPed], [cantDetaPed], [EmpID], [detTipoProdID], [categID], [subCatID] FROM [OrdenPedidoOPId] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [PedCod] = @PedCod AND [OPIdSec] = @OPIdSec ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D3,1,0,true,false )
             ,new CursorDef("T000D4", "SELECT [tipoProdID] FROM [TipoProducto] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [tipoProdID] = @detTipoProdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D4,1,0,true,false )
             ,new CursorDef("T000D5", "SELECT [categDsc] FROM [Categorias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D5,1,0,true,false )
             ,new CursorDef("T000D6", "SELECT [subCatDsc], [subCatPrec], [subCatPeso], [subCatDisp] FROM [CategoriassubCat] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID AND [subCatID] = @subCatID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D6,1,0,true,false )
             ,new CursorDef("T000D7", "SELECT [tipoProdID] FROM [TipoProducto] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [tipoProdID] = @tipoProdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D7,1,0,true,false )
             ,new CursorDef("T000D8", "SELECT [PedCod], [PedDescripcion], [PedFchReg], [PedEst], [PedUltNro], [EmpID] FROM [OrdenPedido] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [PedCod] = @PedCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D8,1,0,true,false )
             ,new CursorDef("T000D9", "SELECT [PedCod], [PedDescripcion], [PedFchReg], [PedEst], [PedUltNro], [EmpID] FROM [OrdenPedido] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [PedCod] = @PedCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D9,1,0,true,false )
             ,new CursorDef("T000D10", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D10,1,0,true,false )
             ,new CursorDef("T000D11", "SELECT TM1.[PedCod], T2.[empdsc], TM1.[PedDescripcion], TM1.[PedFchReg], TM1.[PedEst], TM1.[PedUltNro], TM1.[EmpID] FROM ([OrdenPedido] TM1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = TM1.[EmpID]) WHERE TM1.[EmpID] = @EmpID and TM1.[PedCod] = @PedCod ORDER BY TM1.[EmpID], TM1.[PedCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000D11,100,0,true,false )
             ,new CursorDef("T000D12", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D12,1,0,true,false )
             ,new CursorDef("T000D13", "SELECT [EmpID], [PedCod] FROM [OrdenPedido] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [PedCod] = @PedCod  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000D13,1,0,true,false )
             ,new CursorDef("T000D14", "SELECT TOP 1 [EmpID], [PedCod] FROM [OrdenPedido] WITH (NOLOCK) WHERE ( [EmpID] > @EmpID or [EmpID] = @EmpID and [PedCod] > @PedCod) ORDER BY [EmpID], [PedCod]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000D14,1,0,true,true )
             ,new CursorDef("T000D15", "SELECT TOP 1 [EmpID], [PedCod] FROM [OrdenPedido] WITH (NOLOCK) WHERE ( [EmpID] < @EmpID or [EmpID] = @EmpID and [PedCod] < @PedCod) ORDER BY [EmpID] DESC, [PedCod] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000D15,1,0,true,true )
             ,new CursorDef("T000D16", "INSERT INTO [OrdenPedido]([PedCod], [PedDescripcion], [PedFchReg], [PedEst], [PedUltNro], [EmpID]) VALUES(@PedCod, @PedDescripcion, @PedFchReg, @PedEst, @PedUltNro, @EmpID)", GxErrorMask.GX_NOMASK,prmT000D16)
             ,new CursorDef("T000D17", "UPDATE [OrdenPedido] SET [PedDescripcion]=@PedDescripcion, [PedFchReg]=@PedFchReg, [PedEst]=@PedEst, [PedUltNro]=@PedUltNro  WHERE [EmpID] = @EmpID AND [PedCod] = @PedCod", GxErrorMask.GX_NOMASK,prmT000D17)
             ,new CursorDef("T000D18", "DELETE FROM [OrdenPedido]  WHERE [EmpID] = @EmpID AND [PedCod] = @PedCod", GxErrorMask.GX_NOMASK,prmT000D18)
             ,new CursorDef("T000D19", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D19,1,0,true,false )
             ,new CursorDef("T000D20", "UPDATE [OrdenPedido] SET [PedUltNro]=@PedUltNro  WHERE [EmpID] = @EmpID AND [PedCod] = @PedCod", GxErrorMask.GX_NOMASK,prmT000D20)
             ,new CursorDef("T000D21", "SELECT [EmpID], [PedCod] FROM [OrdenPedido] WITH (NOLOCK) ORDER BY [EmpID], [PedCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000D21,100,0,true,false )
             ,new CursorDef("T000D22", "SELECT T1.[PedCod], T1.[OPIdSec], T2.[categDsc], T3.[subCatDsc], T3.[subCatPrec], T3.[subCatPeso], T3.[subCatDisp], T1.[cantDetPed], T1.[cantDetaPed], T1.[EmpID], T1.[detTipoProdID], T1.[categID], T1.[subCatID] FROM (([OrdenPedidoOPId] T1 WITH (NOLOCK) INNER JOIN [Categorias] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[categID] = T1.[categID]) INNER JOIN [CategoriassubCat] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[categID] = T1.[categID] AND T3.[subCatID] = T1.[subCatID]) WHERE T1.[PedCod] = @PedCod and T1.[OPIdSec] = @OPIdSec and T1.[EmpID] = @EmpID ORDER BY T1.[EmpID], T1.[PedCod], T1.[OPIdSec] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D22,11,0,true,false )
             ,new CursorDef("T000D23", "SELECT [categDsc] FROM [Categorias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D23,1,0,true,false )
             ,new CursorDef("T000D24", "SELECT [subCatDsc], [subCatPrec], [subCatPeso], [subCatDisp] FROM [CategoriassubCat] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID AND [subCatID] = @subCatID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D24,1,0,true,false )
             ,new CursorDef("T000D25", "SELECT [EmpID], [PedCod], [OPIdSec] FROM [OrdenPedidoOPId] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [PedCod] = @PedCod AND [OPIdSec] = @OPIdSec ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D25,1,0,true,false )
             ,new CursorDef("T000D26", "INSERT INTO [OrdenPedidoOPId]([PedCod], [OPIdSec], [cantDetPed], [cantDetaPed], [EmpID], [detTipoProdID], [categID], [subCatID]) VALUES(@PedCod, @OPIdSec, @cantDetPed, @cantDetaPed, @EmpID, @detTipoProdID, @categID, @subCatID)", GxErrorMask.GX_NOMASK,prmT000D26)
             ,new CursorDef("T000D27", "UPDATE [OrdenPedidoOPId] SET [cantDetPed]=@cantDetPed, [cantDetaPed]=@cantDetaPed, [detTipoProdID]=@detTipoProdID, [categID]=@categID, [subCatID]=@subCatID  WHERE [EmpID] = @EmpID AND [PedCod] = @PedCod AND [OPIdSec] = @OPIdSec", GxErrorMask.GX_NOMASK,prmT000D27)
             ,new CursorDef("T000D28", "DELETE FROM [OrdenPedidoOPId]  WHERE [EmpID] = @EmpID AND [PedCod] = @PedCod AND [OPIdSec] = @OPIdSec", GxErrorMask.GX_NOMASK,prmT000D28)
             ,new CursorDef("T000D29", "SELECT [categDsc] FROM [Categorias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D29,1,0,true,false )
             ,new CursorDef("T000D30", "SELECT [subCatDsc], [subCatPrec], [subCatPeso], [subCatDisp] FROM [CategoriassubCat] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID AND [subCatID] = @subCatID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D30,1,0,true,false )
             ,new CursorDef("T000D31", "SELECT [EmpID], [PedCod], [OPIdSec] FROM [OrdenPedidoOPId] WITH (NOLOCK) WHERE [PedCod] = @PedCod and [EmpID] = @EmpID ORDER BY [EmpID], [PedCod], [OPIdSec] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D31,11,0,true,false )
             ,new CursorDef("T000D32", "SELECT [tipoProdID] FROM [TipoProducto] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [tipoProdID] = @detTipoProdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D32,1,0,true,false )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((short[]) buf[6])[0] = rslt.getShort(5) ;
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                ((short[]) buf[8])[0] = rslt.getShort(7) ;
                ((short[]) buf[9])[0] = rslt.getShort(8) ;
                return;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((short[]) buf[6])[0] = rslt.getShort(5) ;
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                ((short[]) buf[8])[0] = rslt.getShort(7) ;
                ((short[]) buf[9])[0] = rslt.getShort(8) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((decimal[]) buf[2])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((decimal[]) buf[4])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((int[]) buf[6])[0] = rslt.getInt(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 6 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 1) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((int[]) buf[7])[0] = rslt.getInt(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                return;
             case 7 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 1) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((int[]) buf[7])[0] = rslt.getInt(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                return;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 9 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 1) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((int[]) buf[9])[0] = rslt.getInt(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((short[]) buf[11])[0] = rslt.getShort(7) ;
                return;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                return;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                return;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 19 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                return;
             case 20 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 40) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getString(4, 40) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((decimal[]) buf[6])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((decimal[]) buf[8])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((int[]) buf[10])[0] = rslt.getInt(7) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(7);
                ((decimal[]) buf[12])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(8);
                ((decimal[]) buf[14])[0] = rslt.getDecimal(9) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(9);
                ((short[]) buf[16])[0] = rslt.getShort(10) ;
                ((short[]) buf[17])[0] = rslt.getShort(11) ;
                ((short[]) buf[18])[0] = rslt.getShort(12) ;
                ((short[]) buf[19])[0] = rslt.getShort(13) ;
                return;
             case 21 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 22 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((decimal[]) buf[2])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((decimal[]) buf[4])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((int[]) buf[6])[0] = rslt.getInt(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                return;
             case 23 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                return;
             case 27 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 28 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((decimal[]) buf[2])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((decimal[]) buf[4])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((int[]) buf[6])[0] = rslt.getInt(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                return;
             case 29 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
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
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
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
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                return;
             case 14 :
                stmt.SetParameter(1, (int)parms[0]);
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
                   stmt.setNull( 4 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 5 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(5, (int)parms[8]);
                }
                stmt.SetParameter(6, (short)parms[9]);
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
                   stmt.setNull( 2 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(2, (DateTime)parms[3]);
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
                   stmt.setNull( 4 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(4, (int)parms[7]);
                }
                stmt.SetParameter(5, (short)parms[8]);
                stmt.SetParameter(6, (int)parms[9]);
                return;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                return;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 18 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                stmt.SetParameter(2, (short)parms[2]);
                stmt.SetParameter(3, (int)parms[3]);
                return;
             case 20 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 21 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 22 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 23 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                return;
             case 24 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 3 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(3, (decimal)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 4 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(4, (decimal)parms[5]);
                }
                stmt.SetParameter(5, (short)parms[6]);
                stmt.SetParameter(6, (short)parms[7]);
                stmt.SetParameter(7, (short)parms[8]);
                stmt.SetParameter(8, (short)parms[9]);
                return;
             case 25 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (decimal)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(2, (decimal)parms[3]);
                }
                stmt.SetParameter(3, (short)parms[4]);
                stmt.SetParameter(4, (short)parms[5]);
                stmt.SetParameter(5, (short)parms[6]);
                stmt.SetParameter(6, (short)parms[7]);
                stmt.SetParameter(7, (int)parms[8]);
                stmt.SetParameter(8, (int)parms[9]);
                return;
             case 26 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                return;
             case 27 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 28 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 29 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
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
       }
    }

 }

}
