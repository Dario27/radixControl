/*
               File: ProdPrecio
        Description: Prod Precio
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/29/2022 1:7:46.13
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
   public class prodprecio : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_19") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_19( A1EmpID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_20") == 0 )
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
            gxLoad_20( A1EmpID, A2AgeID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_21") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A286PrdCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_21( A1EmpID, A2AgeID, A286PrdCod) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_22") == 0 )
         {
            A3UsuCod = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_22( A3UsuCod) ;
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
               AV17ProdPreID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17ProdPreID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17ProdPreID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vPRODPREID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV17ProdPreID), "ZZZ9"), context));
               AV7EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7EmpID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EmpID), "ZZZ9"), context));
               AV8AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8AgeID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8AgeID), "ZZZ9"), context));
               AV10PrdCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10PrdCod), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vPRDCOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10PrdCod), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Prod Precio", 0) ;
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

      public prodprecio( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public prodprecio( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_ProdPreID ,
                           short aP2_EmpID ,
                           short aP3_AgeID ,
                           short aP4_PrdCod )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV17ProdPreID = aP1_ProdPreID;
         this.AV7EmpID = aP2_EmpID;
         this.AV8AgeID = aP3_AgeID;
         this.AV10PrdCod = aP4_PrdCod;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynUsuCod = new GXCombobox();
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
         if ( dynUsuCod.ItemCount > 0 )
         {
            A3UsuCod = dynUsuCod.getValidValue(A3UsuCod);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynUsuCod.CurrentValue = StringUtil.RTrim( A3UsuCod);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynUsuCod_Internalname, "Values", dynUsuCod.ToJavascriptSource(), true);
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Precios", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_ProdPrecio.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_ProdPrecio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_ProdPrecio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_ProdPrecio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_ProdPrecio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0210.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"AGEID"+"'), id:'"+"AGEID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"PRODPREID"+"'), id:'"+"PRODPREID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"PRDCOD"+"'), id:'"+"PRDCOD"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_ProdPrecio.htm");
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
            GxWebStd.gx_div_start( context, divTable1_Internalname, 1, 0, "px", 0, "px", "MainContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection4_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEmpID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEmpID_Internalname, "Emp ID", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtEmpID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEmpID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEmpID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_ProdPrecio.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_1_Internalname, sImgUrl, imgprompt_1_Link, "", "", context.GetTheme( ), imgprompt_1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_ProdPrecio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtempdsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtempdsc_Internalname, "Empresa", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtempdsc_Internalname, A44empdsc, StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempdsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtempdsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_ProdPrecio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection1_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtAgeID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtAgeID_Internalname, "Age ID", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtAgeID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A2AgeID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A2AgeID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAgeID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtAgeID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_ProdPrecio.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_2_Internalname, sImgUrl, imgprompt_2_Link, "", "", context.GetTheme( ), imgprompt_2_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_ProdPrecio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtAgeDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtAgeDsc_Internalname, "Age Dsc", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtAgeDsc_Internalname, StringUtil.RTrim( A46AgeDsc), StringUtil.RTrim( context.localUtil.Format( A46AgeDsc, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAgeDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtAgeDsc_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "Descripcion", "left", true, "HLP_ProdPrecio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection3_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtfecha_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtfecha_Internalname, "fecha", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtfecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtfecha_Internalname, context.localUtil.Format(A302fecha, "99/99/99"), context.localUtil.Format( A302fecha, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtfecha_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtfecha_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ProdPrecio.htm");
            GxWebStd.gx_bitmap( context, edtfecha_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtfecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_ProdPrecio.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynUsuCod_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynUsuCod_Internalname, "Usuario", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynUsuCod, dynUsuCod_Internalname, StringUtil.RTrim( A3UsuCod), 1, dynUsuCod_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, dynUsuCod.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", "", "", true, "HLP_ProdPrecio.htm");
            dynUsuCod.CurrentValue = StringUtil.RTrim( A3UsuCod);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynUsuCod_Internalname, "Values", (String)(dynUsuCod.ToJavascriptSource()), true);
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Control Group */
            GxWebStd.gx_group_start( context, grpGroup1_Internalname, "Info. Producto", 1, 0, "px", 0, "px", "Group", "", "HLP_ProdPrecio.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGroup1table_Internalname, 1, 0, "px", 0, "px", "MainContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtProdPreID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtProdPreID_Internalname, "Codigo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtProdPreID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A310ProdPreID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A310ProdPreID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtProdPreID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtProdPreID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_ProdPrecio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPrdCod_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPrdCod_Internalname, "Codigo Producto", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPrdCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A286PrdCod), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A286PrdCod), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,70);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPrdCod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPrdCod_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ProdPrecio.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_286_Internalname, sImgUrl, imgprompt_286_Link, "", "", context.GetTheme( ), imgprompt_286_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_ProdPrecio.htm");
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
            GxWebStd.gx_label_element( context, edtprdNombre_Internalname, "Articulo/Producto", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtprdNombre_Internalname, A309prdNombre, StringUtil.RTrim( context.localUtil.Format( A309prdNombre, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtprdNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtprdNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 80, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_ProdPrecio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</fieldset>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtvalAnt_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtvalAnt_Internalname, "Precio Anterior", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtvalAnt_Internalname, StringUtil.LTrim( StringUtil.NToC( A303valAnt, 13, 2, ",", "")), ((edtvalAnt_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A303valAnt, "ZZ,ZZZ,ZZZ.ZZ")) : context.localUtil.Format( A303valAnt, "ZZ,ZZZ,ZZZ.ZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,80);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtvalAnt_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtvalAnt_Enabled, 0, "text", "", 13, "chr", 1, "row", 13, 0, 0, 0, 1, -1, 0, true, "valores", "right", false, "HLP_ProdPrecio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtvaloAct_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtvaloAct_Internalname, "Precio Actual", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 85,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtvaloAct_Internalname, StringUtil.LTrim( StringUtil.NToC( A304valoAct, 13, 2, ",", "")), ((edtvaloAct_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A304valoAct, "ZZ,ZZZ,ZZZ.ZZ")) : context.localUtil.Format( A304valoAct, "ZZ,ZZZ,ZZZ.ZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,85);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtvaloAct_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtvaloAct_Enabled, 0, "text", "", 13, "chr", 1, "row", 13, 0, 0, 0, 1, -1, 0, true, "valores", "right", false, "HLP_ProdPrecio.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 90,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_ProdPrecio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 92,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_ProdPrecio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 94,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_ProdPrecio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm0V73( ) ;
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
         E110V2 ();
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
               if ( context.localUtil.VCDate( cgiGet( edtfecha_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"fecha"}), 1, "FECHA");
                  AnyError = 1;
                  GX_FocusControl = edtfecha_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A302fecha = DateTime.MinValue;
                  n302fecha = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A302fecha", context.localUtil.Format(A302fecha, "99/99/99"));
               }
               else
               {
                  A302fecha = context.localUtil.CToD( cgiGet( edtfecha_Internalname), 2);
                  n302fecha = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A302fecha", context.localUtil.Format(A302fecha, "99/99/99"));
               }
               n302fecha = ((DateTime.MinValue==A302fecha) ? true : false);
               dynUsuCod.CurrentValue = cgiGet( dynUsuCod_Internalname);
               A3UsuCod = cgiGet( dynUsuCod_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
               if ( ( ( context.localUtil.CToN( cgiGet( edtProdPreID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtProdPreID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PRODPREID");
                  AnyError = 1;
                  GX_FocusControl = edtProdPreID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A310ProdPreID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A310ProdPreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A310ProdPreID), 4, 0)));
               }
               else
               {
                  A310ProdPreID = (short)(context.localUtil.CToN( cgiGet( edtProdPreID_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A310ProdPreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A310ProdPreID), 4, 0)));
               }
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtvalAnt_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtvalAnt_Internalname), ",", ".") > 9999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "VALANT");
                  AnyError = 1;
                  GX_FocusControl = edtvalAnt_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A303valAnt = 0;
                  n303valAnt = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A303valAnt", StringUtil.LTrim( StringUtil.Str( A303valAnt, 10, 2)));
               }
               else
               {
                  A303valAnt = context.localUtil.CToN( cgiGet( edtvalAnt_Internalname), ",", ".");
                  n303valAnt = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A303valAnt", StringUtil.LTrim( StringUtil.Str( A303valAnt, 10, 2)));
               }
               n303valAnt = ((Convert.ToDecimal(0)==A303valAnt) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtvaloAct_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtvaloAct_Internalname), ",", ".") > 9999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "VALOACT");
                  AnyError = 1;
                  GX_FocusControl = edtvaloAct_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A304valoAct = 0;
                  n304valoAct = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A304valoAct", StringUtil.LTrim( StringUtil.Str( A304valoAct, 10, 2)));
               }
               else
               {
                  A304valoAct = context.localUtil.CToN( cgiGet( edtvaloAct_Internalname), ",", ".");
                  n304valoAct = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A304valoAct", StringUtil.LTrim( StringUtil.Str( A304valoAct, 10, 2)));
               }
               n304valoAct = ((Convert.ToDecimal(0)==A304valoAct) ? true : false);
               /* Read saved values. */
               Z1EmpID = (short)(context.localUtil.CToN( cgiGet( "Z1EmpID"), ",", "."));
               Z2AgeID = (short)(context.localUtil.CToN( cgiGet( "Z2AgeID"), ",", "."));
               Z310ProdPreID = (short)(context.localUtil.CToN( cgiGet( "Z310ProdPreID"), ",", "."));
               Z286PrdCod = (short)(context.localUtil.CToN( cgiGet( "Z286PrdCod"), ",", "."));
               Z302fecha = context.localUtil.CToD( cgiGet( "Z302fecha"), 0);
               n302fecha = ((DateTime.MinValue==A302fecha) ? true : false);
               Z303valAnt = context.localUtil.CToN( cgiGet( "Z303valAnt"), ",", ".");
               n303valAnt = ((Convert.ToDecimal(0)==A303valAnt) ? true : false);
               Z304valoAct = context.localUtil.CToN( cgiGet( "Z304valoAct"), ",", ".");
               n304valoAct = ((Convert.ToDecimal(0)==A304valoAct) ? true : false);
               Z3UsuCod = cgiGet( "Z3UsuCod");
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               AV17ProdPreID = (short)(context.localUtil.CToN( cgiGet( "vPRODPREID"), ",", "."));
               AV7EmpID = (short)(context.localUtil.CToN( cgiGet( "vEMPID"), ",", "."));
               AV8AgeID = (short)(context.localUtil.CToN( cgiGet( "vAGEID"), ",", "."));
               AV10PrdCod = (short)(context.localUtil.CToN( cgiGet( "vPRDCOD"), ",", "."));
               AV14Insert_UsuCod = cgiGet( "vINSERT_USUCOD");
               AV18Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "ProdPrecio";
               A3UsuCod = cgiGet( dynUsuCod_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A3UsuCod, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV14Insert_UsuCod, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A310ProdPreID != Z310ProdPreID ) || ( A286PrdCod != Z286PrdCod ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("prodprecio:[SecurityCheckFailed value for]"+"UsuCod:"+StringUtil.RTrim( context.localUtil.Format( A3UsuCod, "")));
                  GXUtil.WriteLog("prodprecio:[SecurityCheckFailed value for]"+"Insert_UsuCod:"+StringUtil.RTrim( context.localUtil.Format( AV14Insert_UsuCod, "")));
                  GXUtil.WriteLog("prodprecio:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A310ProdPreID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A310ProdPreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A310ProdPreID), 4, 0)));
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
                     sMode73 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode73;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound73 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0V0( ) ;
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
                        E110V2 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: After Trn */
                        E120V2 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "PRDCOD.CONTROLVALUECHANGED") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        E130V2 ();
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
            E120V2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0V73( ) ;
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
            DisableAttributes0V73( ) ;
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

      protected void CONFIRM_0V0( )
      {
         BeforeValidate0V73( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0V73( ) ;
            }
            else
            {
               CheckExtendedTable0V73( ) ;
               CloseExtendedTableCursors0V73( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0V0( )
      {
      }

      protected void E110V2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV18Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV18Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV12TrnContext.FromXml(AV13WebSession.Get("TrnContext"), null, "TransactionContext", "KBCalpesa22");
         AV14Insert_UsuCod = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Insert_UsuCod", AV14Insert_UsuCod);
         if ( ( StringUtil.StrCmp(AV12TrnContext.gxTpr_Transactionname, AV18Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV19GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19GXV1), 8, 0)));
            while ( AV19GXV1 <= AV12TrnContext.gxTpr_Attributes.Count )
            {
               AV15TrnContextAtt = ((SdtTransactionContext_Attribute)AV12TrnContext.gxTpr_Attributes.Item(AV19GXV1));
               if ( StringUtil.StrCmp(AV15TrnContextAtt.gxTpr_Attributename, "UsuCod") == 0 )
               {
                  AV14Insert_UsuCod = AV15TrnContextAtt.gxTpr_Attributevalue;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Insert_UsuCod", AV14Insert_UsuCod);
               }
               AV19GXV1 = (int)(AV19GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19GXV1), 8, 0)));
            }
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_char1 = AV16PrdDscp;
            new obtdescproducto(context ).execute(  AV7EmpID,  AV8AgeID,  AV10PrdCod, out  GXt_char1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7EmpID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EmpID), "ZZZ9"), context));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8AgeID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8AgeID), "ZZZ9"), context));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10PrdCod), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vPRDCOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10PrdCod), "ZZZ9"), context));
            AV16PrdDscp = GXt_char1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16PrdDscp", AV16PrdDscp);
         }
      }

      protected void E120V2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV12TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwprodprecio.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void E130V2( )
      {
         /* PrdCod_Controlvaluechanged Routine */
         GXt_char1 = AV16PrdDscp;
         new obtdescproducto(context ).execute(  AV7EmpID,  AV8AgeID,  A286PrdCod, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7EmpID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EmpID), "ZZZ9"), context));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8AgeID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8AgeID), "ZZZ9"), context));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
         AV16PrdDscp = GXt_char1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16PrdDscp", AV16PrdDscp);
         /*  Sending Event outputs  */
      }

      protected void ZM0V73( short GX_JID )
      {
         if ( ( GX_JID == 18 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z302fecha = T000V3_A302fecha[0];
               Z303valAnt = T000V3_A303valAnt[0];
               Z304valoAct = T000V3_A304valoAct[0];
               Z3UsuCod = T000V3_A3UsuCod[0];
            }
            else
            {
               Z302fecha = A302fecha;
               Z303valAnt = A303valAnt;
               Z304valoAct = A304valoAct;
               Z3UsuCod = A3UsuCod;
            }
         }
         if ( GX_JID == -18 )
         {
            Z310ProdPreID = A310ProdPreID;
            Z302fecha = A302fecha;
            Z303valAnt = A303valAnt;
            Z304valoAct = A304valoAct;
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z286PrdCod = A286PrdCod;
            Z3UsuCod = A3UsuCod;
            Z44empdsc = A44empdsc;
            Z46AgeDsc = A46AgeDsc;
            Z309prdNombre = A309prdNombre;
         }
      }

      protected void standaloneNotModal( )
      {
         dynUsuCod.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynUsuCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynUsuCod.Enabled), 5, 0)), true);
         imgprompt_1_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_2_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0021.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"AGEID"+"'), id:'"+"AGEID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_286_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0202.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"AGEID"+"'), id:'"+"AGEID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"PRDCOD"+"'), id:'"+"PRDCOD"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");");
         dynUsuCod.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynUsuCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynUsuCod.Enabled), 5, 0)), true);
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV17ProdPreID) )
         {
            A310ProdPreID = AV17ProdPreID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A310ProdPreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A310ProdPreID), 4, 0)));
         }
         if ( ! (0==AV17ProdPreID) )
         {
            edtProdPreID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProdPreID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProdPreID_Enabled), 5, 0)), true);
         }
         else
         {
            edtProdPreID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProdPreID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProdPreID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV17ProdPreID) )
         {
            edtProdPreID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProdPreID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProdPreID_Enabled), 5, 0)), true);
         }
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
         if ( ! (0==AV10PrdCod) )
         {
            A286PrdCod = AV10PrdCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
         }
         if ( ! (0==AV10PrdCod) )
         {
            edtPrdCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrdCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrdCod_Enabled), 5, 0)), true);
         }
         else
         {
            edtPrdCod_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrdCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrdCod_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV10PrdCod) )
         {
            edtPrdCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrdCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrdCod_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV14Insert_UsuCod)) )
         {
            A3UsuCod = AV14Insert_UsuCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
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
            AV18Pgmname = "ProdPrecio";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Pgmname", AV18Pgmname);
            /* Using cursor T000V4 */
            pr_default.execute(2, new Object[] {A1EmpID});
            A44empdsc = T000V4_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000V4_n44empdsc[0];
            pr_default.close(2);
            /* Using cursor T000V5 */
            pr_default.execute(3, new Object[] {A1EmpID, A2AgeID});
            A46AgeDsc = T000V5_A46AgeDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
            n46AgeDsc = T000V5_n46AgeDsc[0];
            pr_default.close(3);
            /* Using cursor T000V6 */
            pr_default.execute(4, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
            A309prdNombre = T000V6_A309prdNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309prdNombre", A309prdNombre);
            n309prdNombre = T000V6_n309prdNombre[0];
            pr_default.close(4);
         }
      }

      protected void Load0V73( )
      {
         /* Using cursor T000V8 */
         pr_default.execute(6, new Object[] {A1EmpID, A2AgeID, A310ProdPreID, A286PrdCod});
         if ( (pr_default.getStatus(6) != 101) )
         {
            RcdFound73 = 1;
            A44empdsc = T000V8_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000V8_n44empdsc[0];
            A46AgeDsc = T000V8_A46AgeDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
            n46AgeDsc = T000V8_n46AgeDsc[0];
            A309prdNombre = T000V8_A309prdNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309prdNombre", A309prdNombre);
            n309prdNombre = T000V8_n309prdNombre[0];
            A302fecha = T000V8_A302fecha[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A302fecha", context.localUtil.Format(A302fecha, "99/99/99"));
            n302fecha = T000V8_n302fecha[0];
            A303valAnt = T000V8_A303valAnt[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A303valAnt", StringUtil.LTrim( StringUtil.Str( A303valAnt, 10, 2)));
            n303valAnt = T000V8_n303valAnt[0];
            A304valoAct = T000V8_A304valoAct[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A304valoAct", StringUtil.LTrim( StringUtil.Str( A304valoAct, 10, 2)));
            n304valoAct = T000V8_n304valoAct[0];
            A3UsuCod = T000V8_A3UsuCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
            ZM0V73( -18) ;
         }
         pr_default.close(6);
         OnLoadActions0V73( ) ;
      }

      protected void OnLoadActions0V73( )
      {
         AV18Pgmname = "ProdPrecio";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Pgmname", AV18Pgmname);
      }

      protected void CheckExtendedTable0V73( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV18Pgmname = "ProdPrecio";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Pgmname", AV18Pgmname);
         /* Using cursor T000V4 */
         pr_default.execute(2, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000V4_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T000V4_n44empdsc[0];
         pr_default.close(2);
         /* Using cursor T000V5 */
         pr_default.execute(3, new Object[] {A1EmpID, A2AgeID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("No existe 'Agencias'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A46AgeDsc = T000V5_A46AgeDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
         n46AgeDsc = T000V5_n46AgeDsc[0];
         pr_default.close(3);
         /* Using cursor T000V6 */
         pr_default.execute(4, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No existe 'Productos'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A309prdNombre = T000V6_A309prdNombre[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309prdNombre", A309prdNombre);
         n309prdNombre = T000V6_n309prdNombre[0];
         pr_default.close(4);
         if ( ! ( (DateTime.MinValue==A302fecha) || ( A302fecha >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo fecha fuera de rango", "OutOfRange", 1, "FECHA");
            AnyError = 1;
            GX_FocusControl = edtfecha_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         /* Using cursor T000V7 */
         pr_default.execute(5, new Object[] {A3UsuCod});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No existe 'Usuarios'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         pr_default.close(5);
      }

      protected void CloseExtendedTableCursors0V73( )
      {
         pr_default.close(2);
         pr_default.close(3);
         pr_default.close(4);
         pr_default.close(5);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_19( short A1EmpID )
      {
         /* Using cursor T000V9 */
         pr_default.execute(7, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(7) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000V9_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T000V9_n44empdsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A44empdsc)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(7) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(7);
      }

      protected void gxLoad_20( short A1EmpID ,
                                short A2AgeID )
      {
         /* Using cursor T000V10 */
         pr_default.execute(8, new Object[] {A1EmpID, A2AgeID});
         if ( (pr_default.getStatus(8) == 101) )
         {
            GX_msglist.addItem("No existe 'Agencias'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A46AgeDsc = T000V10_A46AgeDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
         n46AgeDsc = T000V10_n46AgeDsc[0];
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

      protected void gxLoad_21( short A1EmpID ,
                                short A2AgeID ,
                                short A286PrdCod )
      {
         /* Using cursor T000V11 */
         pr_default.execute(9, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
         if ( (pr_default.getStatus(9) == 101) )
         {
            GX_msglist.addItem("No existe 'Productos'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A309prdNombre = T000V11_A309prdNombre[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309prdNombre", A309prdNombre);
         n309prdNombre = T000V11_n309prdNombre[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A309prdNombre)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(9) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(9);
      }

      protected void gxLoad_22( String A3UsuCod )
      {
         /* Using cursor T000V12 */
         pr_default.execute(10, new Object[] {A3UsuCod});
         if ( (pr_default.getStatus(10) == 101) )
         {
            GX_msglist.addItem("No existe 'Usuarios'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(10) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(10);
      }

      protected void GetKey0V73( )
      {
         /* Using cursor T000V13 */
         pr_default.execute(11, new Object[] {A1EmpID, A2AgeID, A310ProdPreID, A286PrdCod});
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound73 = 1;
         }
         else
         {
            RcdFound73 = 0;
         }
         pr_default.close(11);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000V3 */
         pr_default.execute(1, new Object[] {A1EmpID, A2AgeID, A310ProdPreID, A286PrdCod});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0V73( 18) ;
            RcdFound73 = 1;
            A310ProdPreID = T000V3_A310ProdPreID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A310ProdPreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A310ProdPreID), 4, 0)));
            A302fecha = T000V3_A302fecha[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A302fecha", context.localUtil.Format(A302fecha, "99/99/99"));
            n302fecha = T000V3_n302fecha[0];
            A303valAnt = T000V3_A303valAnt[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A303valAnt", StringUtil.LTrim( StringUtil.Str( A303valAnt, 10, 2)));
            n303valAnt = T000V3_n303valAnt[0];
            A304valoAct = T000V3_A304valoAct[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A304valoAct", StringUtil.LTrim( StringUtil.Str( A304valoAct, 10, 2)));
            n304valoAct = T000V3_n304valoAct[0];
            A1EmpID = T000V3_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = T000V3_A2AgeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A286PrdCod = T000V3_A286PrdCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
            A3UsuCod = T000V3_A3UsuCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z310ProdPreID = A310ProdPreID;
            Z286PrdCod = A286PrdCod;
            sMode73 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0V73( ) ;
            if ( AnyError == 1 )
            {
               RcdFound73 = 0;
               InitializeNonKey0V73( ) ;
            }
            Gx_mode = sMode73;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound73 = 0;
            InitializeNonKey0V73( ) ;
            sMode73 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode73;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0V73( ) ;
         if ( RcdFound73 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound73 = 0;
         /* Using cursor T000V14 */
         pr_default.execute(12, new Object[] {A1EmpID, A2AgeID, A310ProdPreID, A286PrdCod});
         if ( (pr_default.getStatus(12) != 101) )
         {
            while ( (pr_default.getStatus(12) != 101) && ( ( T000V14_A1EmpID[0] < A1EmpID ) || ( T000V14_A1EmpID[0] == A1EmpID ) && ( T000V14_A2AgeID[0] < A2AgeID ) || ( T000V14_A2AgeID[0] == A2AgeID ) && ( T000V14_A1EmpID[0] == A1EmpID ) && ( T000V14_A310ProdPreID[0] < A310ProdPreID ) || ( T000V14_A310ProdPreID[0] == A310ProdPreID ) && ( T000V14_A2AgeID[0] == A2AgeID ) && ( T000V14_A1EmpID[0] == A1EmpID ) && ( T000V14_A286PrdCod[0] < A286PrdCod ) ) )
            {
               pr_default.readNext(12);
            }
            if ( (pr_default.getStatus(12) != 101) && ( ( T000V14_A1EmpID[0] > A1EmpID ) || ( T000V14_A1EmpID[0] == A1EmpID ) && ( T000V14_A2AgeID[0] > A2AgeID ) || ( T000V14_A2AgeID[0] == A2AgeID ) && ( T000V14_A1EmpID[0] == A1EmpID ) && ( T000V14_A310ProdPreID[0] > A310ProdPreID ) || ( T000V14_A310ProdPreID[0] == A310ProdPreID ) && ( T000V14_A2AgeID[0] == A2AgeID ) && ( T000V14_A1EmpID[0] == A1EmpID ) && ( T000V14_A286PrdCod[0] > A286PrdCod ) ) )
            {
               A1EmpID = T000V14_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A2AgeID = T000V14_A2AgeID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
               A310ProdPreID = T000V14_A310ProdPreID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A310ProdPreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A310ProdPreID), 4, 0)));
               A286PrdCod = T000V14_A286PrdCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
               RcdFound73 = 1;
            }
         }
         pr_default.close(12);
      }

      protected void move_previous( )
      {
         RcdFound73 = 0;
         /* Using cursor T000V15 */
         pr_default.execute(13, new Object[] {A1EmpID, A2AgeID, A310ProdPreID, A286PrdCod});
         if ( (pr_default.getStatus(13) != 101) )
         {
            while ( (pr_default.getStatus(13) != 101) && ( ( T000V15_A1EmpID[0] > A1EmpID ) || ( T000V15_A1EmpID[0] == A1EmpID ) && ( T000V15_A2AgeID[0] > A2AgeID ) || ( T000V15_A2AgeID[0] == A2AgeID ) && ( T000V15_A1EmpID[0] == A1EmpID ) && ( T000V15_A310ProdPreID[0] > A310ProdPreID ) || ( T000V15_A310ProdPreID[0] == A310ProdPreID ) && ( T000V15_A2AgeID[0] == A2AgeID ) && ( T000V15_A1EmpID[0] == A1EmpID ) && ( T000V15_A286PrdCod[0] > A286PrdCod ) ) )
            {
               pr_default.readNext(13);
            }
            if ( (pr_default.getStatus(13) != 101) && ( ( T000V15_A1EmpID[0] < A1EmpID ) || ( T000V15_A1EmpID[0] == A1EmpID ) && ( T000V15_A2AgeID[0] < A2AgeID ) || ( T000V15_A2AgeID[0] == A2AgeID ) && ( T000V15_A1EmpID[0] == A1EmpID ) && ( T000V15_A310ProdPreID[0] < A310ProdPreID ) || ( T000V15_A310ProdPreID[0] == A310ProdPreID ) && ( T000V15_A2AgeID[0] == A2AgeID ) && ( T000V15_A1EmpID[0] == A1EmpID ) && ( T000V15_A286PrdCod[0] < A286PrdCod ) ) )
            {
               A1EmpID = T000V15_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A2AgeID = T000V15_A2AgeID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
               A310ProdPreID = T000V15_A310ProdPreID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A310ProdPreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A310ProdPreID), 4, 0)));
               A286PrdCod = T000V15_A286PrdCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
               RcdFound73 = 1;
            }
         }
         pr_default.close(13);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0V73( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0V73( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound73 == 1 )
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A310ProdPreID != Z310ProdPreID ) || ( A286PrdCod != Z286PrdCod ) )
               {
                  A1EmpID = Z1EmpID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
                  A2AgeID = Z2AgeID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
                  A310ProdPreID = Z310ProdPreID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A310ProdPreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A310ProdPreID), 4, 0)));
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
                  Update0V73( ) ;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A310ProdPreID != Z310ProdPreID ) || ( A286PrdCod != Z286PrdCod ) )
               {
                  /* Insert record */
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0V73( ) ;
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
                     Insert0V73( ) ;
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
         if ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A310ProdPreID != Z310ProdPreID ) || ( A286PrdCod != Z286PrdCod ) )
         {
            A1EmpID = Z1EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = Z2AgeID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A310ProdPreID = Z310ProdPreID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A310ProdPreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A310ProdPreID), 4, 0)));
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

      protected void CheckOptimisticConcurrency0V73( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000V2 */
            pr_default.execute(0, new Object[] {A1EmpID, A2AgeID, A310ProdPreID, A286PrdCod});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ProdPrecio"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z302fecha != T000V2_A302fecha[0] ) || ( Z303valAnt != T000V2_A303valAnt[0] ) || ( Z304valoAct != T000V2_A304valoAct[0] ) || ( StringUtil.StrCmp(Z3UsuCod, T000V2_A3UsuCod[0]) != 0 ) )
            {
               if ( Z302fecha != T000V2_A302fecha[0] )
               {
                  GXUtil.WriteLog("prodprecio:[seudo value changed for attri]"+"fecha");
                  GXUtil.WriteLogRaw("Old: ",Z302fecha);
                  GXUtil.WriteLogRaw("Current: ",T000V2_A302fecha[0]);
               }
               if ( Z303valAnt != T000V2_A303valAnt[0] )
               {
                  GXUtil.WriteLog("prodprecio:[seudo value changed for attri]"+"valAnt");
                  GXUtil.WriteLogRaw("Old: ",Z303valAnt);
                  GXUtil.WriteLogRaw("Current: ",T000V2_A303valAnt[0]);
               }
               if ( Z304valoAct != T000V2_A304valoAct[0] )
               {
                  GXUtil.WriteLog("prodprecio:[seudo value changed for attri]"+"valoAct");
                  GXUtil.WriteLogRaw("Old: ",Z304valoAct);
                  GXUtil.WriteLogRaw("Current: ",T000V2_A304valoAct[0]);
               }
               if ( StringUtil.StrCmp(Z3UsuCod, T000V2_A3UsuCod[0]) != 0 )
               {
                  GXUtil.WriteLog("prodprecio:[seudo value changed for attri]"+"UsuCod");
                  GXUtil.WriteLogRaw("Old: ",Z3UsuCod);
                  GXUtil.WriteLogRaw("Current: ",T000V2_A3UsuCod[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"ProdPrecio"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0V73( )
      {
         BeforeValidate0V73( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0V73( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0V73( 0) ;
            CheckOptimisticConcurrency0V73( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0V73( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0V73( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000V16 */
                     pr_default.execute(14, new Object[] {A310ProdPreID, n302fecha, A302fecha, n303valAnt, A303valAnt, n304valoAct, A304valoAct, A1EmpID, A2AgeID, A286PrdCod, A3UsuCod});
                     pr_default.close(14);
                     dsDefault.SmartCacheProvider.SetUpdated("ProdPrecio") ;
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
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption0V0( ) ;
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
               Load0V73( ) ;
            }
            EndLevel0V73( ) ;
         }
         CloseExtendedTableCursors0V73( ) ;
      }

      protected void Update0V73( )
      {
         BeforeValidate0V73( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0V73( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0V73( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0V73( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0V73( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000V17 */
                     pr_default.execute(15, new Object[] {n302fecha, A302fecha, n303valAnt, A303valAnt, n304valoAct, A304valoAct, A3UsuCod, A1EmpID, A2AgeID, A310ProdPreID, A286PrdCod});
                     pr_default.close(15);
                     dsDefault.SmartCacheProvider.SetUpdated("ProdPrecio") ;
                     if ( (pr_default.getStatus(15) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ProdPrecio"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0V73( ) ;
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
            EndLevel0V73( ) ;
         }
         CloseExtendedTableCursors0V73( ) ;
      }

      protected void DeferredUpdate0V73( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0V73( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0V73( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0V73( ) ;
            AfterConfirm0V73( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0V73( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000V18 */
                  pr_default.execute(16, new Object[] {A1EmpID, A2AgeID, A310ProdPreID, A286PrdCod});
                  pr_default.close(16);
                  dsDefault.SmartCacheProvider.SetUpdated("ProdPrecio") ;
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
         sMode73 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0V73( ) ;
         Gx_mode = sMode73;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0V73( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV18Pgmname = "ProdPrecio";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Pgmname", AV18Pgmname);
            /* Using cursor T000V19 */
            pr_default.execute(17, new Object[] {A1EmpID});
            A44empdsc = T000V19_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000V19_n44empdsc[0];
            pr_default.close(17);
            /* Using cursor T000V20 */
            pr_default.execute(18, new Object[] {A1EmpID, A2AgeID});
            A46AgeDsc = T000V20_A46AgeDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
            n46AgeDsc = T000V20_n46AgeDsc[0];
            pr_default.close(18);
            /* Using cursor T000V21 */
            pr_default.execute(19, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
            A309prdNombre = T000V21_A309prdNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309prdNombre", A309prdNombre);
            n309prdNombre = T000V21_n309prdNombre[0];
            pr_default.close(19);
         }
      }

      protected void EndLevel0V73( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0V73( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(17);
            pr_default.close(18);
            pr_default.close(19);
            context.CommitDataStores("prodprecio",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0V0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(17);
            pr_default.close(18);
            pr_default.close(19);
            context.RollbackDataStores("prodprecio",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0V73( )
      {
         /* Scan By routine */
         /* Using cursor T000V22 */
         pr_default.execute(20);
         RcdFound73 = 0;
         if ( (pr_default.getStatus(20) != 101) )
         {
            RcdFound73 = 1;
            A1EmpID = T000V22_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = T000V22_A2AgeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A310ProdPreID = T000V22_A310ProdPreID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A310ProdPreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A310ProdPreID), 4, 0)));
            A286PrdCod = T000V22_A286PrdCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0V73( )
      {
         /* Scan next routine */
         pr_default.readNext(20);
         RcdFound73 = 0;
         if ( (pr_default.getStatus(20) != 101) )
         {
            RcdFound73 = 1;
            A1EmpID = T000V22_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = T000V22_A2AgeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A310ProdPreID = T000V22_A310ProdPreID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A310ProdPreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A310ProdPreID), 4, 0)));
            A286PrdCod = T000V22_A286PrdCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
         }
      }

      protected void ScanEnd0V73( )
      {
         pr_default.close(20);
      }

      protected void AfterConfirm0V73( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0V73( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0V73( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0V73( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0V73( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0V73( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0V73( )
      {
         edtEmpID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         edtempdsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempdsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempdsc_Enabled), 5, 0)), true);
         edtAgeID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAgeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAgeID_Enabled), 5, 0)), true);
         edtAgeDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAgeDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAgeDsc_Enabled), 5, 0)), true);
         edtfecha_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtfecha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtfecha_Enabled), 5, 0)), true);
         dynUsuCod.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynUsuCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynUsuCod.Enabled), 5, 0)), true);
         edtProdPreID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProdPreID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProdPreID_Enabled), 5, 0)), true);
         edtPrdCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrdCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrdCod_Enabled), 5, 0)), true);
         edtprdNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtprdNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtprdNombre_Enabled), 5, 0)), true);
         edtvalAnt_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtvalAnt_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtvalAnt_Enabled), 5, 0)), true);
         edtvaloAct_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtvaloAct_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtvaloAct_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0V73( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0V0( )
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
         context.SendWebValue( "Prod Precio") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20221029175491", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("prodprecio.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV17ProdPreID) + "," + UrlEncode("" +AV7EmpID) + "," + UrlEncode("" +AV8AgeID) + "," + UrlEncode("" +AV10PrdCod)+"\">") ;
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
         forbiddenHiddens = "hsh" + "ProdPrecio";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A3UsuCod, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV14Insert_UsuCod, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("prodprecio:[SendSecurityCheck value for]"+"UsuCod:"+StringUtil.RTrim( context.localUtil.Format( A3UsuCod, "")));
         GXUtil.WriteLog("prodprecio:[SendSecurityCheck value for]"+"Insert_UsuCod:"+StringUtil.RTrim( context.localUtil.Format( AV14Insert_UsuCod, "")));
         GXUtil.WriteLog("prodprecio:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1EmpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z2AgeID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z2AgeID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z310ProdPreID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z310ProdPreID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z286PrdCod", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z286PrdCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z302fecha", context.localUtil.DToC( Z302fecha, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z303valAnt", StringUtil.LTrim( StringUtil.NToC( Z303valAnt, 10, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z304valoAct", StringUtil.LTrim( StringUtil.NToC( Z304valoAct, 10, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z3UsuCod", StringUtil.RTrim( Z3UsuCod));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV12TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV12TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vPRODPREID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17ProdPreID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vPRODPREID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV17ProdPreID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EmpID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8AgeID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8AgeID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vPRDCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10PrdCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vPRDCOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10PrdCod), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_USUCOD", StringUtil.RTrim( AV14Insert_UsuCod));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV18Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void RenderHtmlCloseForm0V73( )
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
         return "ProdPrecio" ;
      }

      public override String GetPgmdesc( )
      {
         return "Prod Precio" ;
      }

      protected void InitializeNonKey0V73( )
      {
         A3UsuCod = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
         A44empdsc = "";
         n44empdsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         A46AgeDsc = "";
         n46AgeDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
         A309prdNombre = "";
         n309prdNombre = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309prdNombre", A309prdNombre);
         A302fecha = DateTime.MinValue;
         n302fecha = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A302fecha", context.localUtil.Format(A302fecha, "99/99/99"));
         n302fecha = ((DateTime.MinValue==A302fecha) ? true : false);
         A303valAnt = 0;
         n303valAnt = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A303valAnt", StringUtil.LTrim( StringUtil.Str( A303valAnt, 10, 2)));
         n303valAnt = ((Convert.ToDecimal(0)==A303valAnt) ? true : false);
         A304valoAct = 0;
         n304valoAct = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A304valoAct", StringUtil.LTrim( StringUtil.Str( A304valoAct, 10, 2)));
         n304valoAct = ((Convert.ToDecimal(0)==A304valoAct) ? true : false);
         Z302fecha = DateTime.MinValue;
         Z303valAnt = 0;
         Z304valoAct = 0;
         Z3UsuCod = "";
      }

      protected void InitAll0V73( )
      {
         A1EmpID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         A2AgeID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
         A310ProdPreID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A310ProdPreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A310ProdPreID), 4, 0)));
         A286PrdCod = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
         InitializeNonKey0V73( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20221029175549", true);
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
         context.AddJavascriptSource("prodprecio.js", "?20221029175549", false);
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
         divSection4_Internalname = "SECTION4";
         edtAgeID_Internalname = "AGEID";
         edtAgeDsc_Internalname = "AGEDSC";
         divSection1_Internalname = "SECTION1";
         edtfecha_Internalname = "FECHA";
         dynUsuCod_Internalname = "USUCOD";
         divSection3_Internalname = "SECTION3";
         divTable1_Internalname = "TABLE1";
         edtProdPreID_Internalname = "PRODPREID";
         edtPrdCod_Internalname = "PRDCOD";
         edtprdNombre_Internalname = "PRDNOMBRE";
         divGroup1table_Internalname = "GROUP1TABLE";
         grpGroup1_Internalname = "GROUP1";
         edtvalAnt_Internalname = "VALANT";
         edtvaloAct_Internalname = "VALOACT";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_1_Internalname = "PROMPT_1";
         imgprompt_2_Internalname = "PROMPT_2";
         imgprompt_286_Internalname = "PROMPT_286";
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
         edtvaloAct_Jsonclick = "";
         edtvaloAct_Enabled = 1;
         edtvalAnt_Jsonclick = "";
         edtvalAnt_Enabled = 1;
         edtprdNombre_Jsonclick = "";
         edtprdNombre_Enabled = 0;
         imgprompt_286_Visible = 1;
         imgprompt_286_Link = "";
         edtPrdCod_Jsonclick = "";
         edtPrdCod_Enabled = 1;
         edtProdPreID_Jsonclick = "";
         edtProdPreID_Enabled = 1;
         dynUsuCod_Jsonclick = "";
         dynUsuCod.Enabled = 0;
         edtfecha_Jsonclick = "";
         edtfecha_Enabled = 1;
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

      protected void GXDLAUSUCOD0V1( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLAUSUCOD_data0V1( ) ;
         gxdynajaxindex = 1;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{\"c\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)))+"\",\"d\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1);
            gxwrpcisep = ",";
         }
         context.GX_webresponse.AddString("]");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GXAUSUCOD_html0V1( )
      {
         String gxdynajaxvalue ;
         GXDLAUSUCOD_data0V1( ) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynUsuCod.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynUsuCod.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLAUSUCOD_data0V1( )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         /* Using cursor T000V23 */
         pr_default.execute(21);
         while ( (pr_default.getStatus(21) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( T000V23_A3UsuCod[0]));
            gxdynajaxctrldescr.Add(T000V23_A50UsuName[0]);
            pr_default.readNext(21);
         }
         pr_default.close(21);
      }

      protected void init_web_controls( )
      {
         dynUsuCod.Name = "USUCOD";
         dynUsuCod.WebTags = "";
         dynUsuCod.removeAllItems();
         /* Using cursor T000V24 */
         pr_default.execute(22);
         while ( (pr_default.getStatus(22) != 101) )
         {
            dynUsuCod.addItem(T000V24_A3UsuCod[0], T000V24_A50UsuName[0], 0);
            pr_default.readNext(22);
         }
         pr_default.close(22);
         if ( dynUsuCod.ItemCount > 0 )
         {
            A3UsuCod = dynUsuCod.getValidValue(A3UsuCod);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3UsuCod", A3UsuCod);
         }
         /* End function init_web_controls */
      }

      public void Valid_Empid( short GX_Parm1 ,
                               String GX_Parm2 )
      {
         A1EmpID = GX_Parm1;
         A44empdsc = GX_Parm2;
         n44empdsc = false;
         /* Using cursor T000V19 */
         pr_default.execute(17, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(17) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A44empdsc = T000V19_A44empdsc[0];
         n44empdsc = T000V19_n44empdsc[0];
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

      public void Valid_Ageid( short GX_Parm1 ,
                               short GX_Parm2 ,
                               String GX_Parm3 )
      {
         A1EmpID = GX_Parm1;
         A2AgeID = GX_Parm2;
         A46AgeDsc = GX_Parm3;
         n46AgeDsc = false;
         /* Using cursor T000V20 */
         pr_default.execute(18, new Object[] {A1EmpID, A2AgeID});
         if ( (pr_default.getStatus(18) == 101) )
         {
            GX_msglist.addItem("No existe 'Agencias'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A46AgeDsc = T000V20_A46AgeDsc[0];
         n46AgeDsc = T000V20_n46AgeDsc[0];
         pr_default.close(18);
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

      public void Valid_Prdcod( short GX_Parm1 ,
                                short GX_Parm2 ,
                                short GX_Parm3 ,
                                String GX_Parm4 )
      {
         A1EmpID = GX_Parm1;
         A2AgeID = GX_Parm2;
         A286PrdCod = GX_Parm3;
         A309prdNombre = GX_Parm4;
         n309prdNombre = false;
         /* Using cursor T000V21 */
         pr_default.execute(19, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
         if ( (pr_default.getStatus(19) == 101) )
         {
            GX_msglist.addItem("No existe 'Productos'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A309prdNombre = T000V21_A309prdNombre[0];
         n309prdNombre = T000V21_n309prdNombre[0];
         pr_default.close(19);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A309prdNombre = "";
            n309prdNombre = false;
         }
         isValidOutput.Add(A309prdNombre);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Usucod( GXCombobox dynGX_Parm1 )
      {
         dynUsuCod = dynGX_Parm1;
         A3UsuCod = dynUsuCod.CurrentValue;
         /* Using cursor T000V25 */
         pr_default.execute(23, new Object[] {A3UsuCod});
         if ( (pr_default.getStatus(23) == 101) )
         {
            GX_msglist.addItem("No existe 'Usuarios'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         pr_default.close(23);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV17ProdPreID',fld:'vPRODPREID',pic:'ZZZ9',hsh:true},{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV8AgeID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV10PrdCod',fld:'vPRDCOD',pic:'ZZZ9',hsh:true},{av:'dynUsuCod'},{av:'A3UsuCod',fld:'USUCOD',pic:''}]");
         setEventMetadata("ENTER",",oparms:[{av:'dynUsuCod'},{av:'A3UsuCod',fld:'USUCOD',pic:''}]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV17ProdPreID',fld:'vPRODPREID',pic:'ZZZ9',hsh:true},{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV8AgeID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV10PrdCod',fld:'vPRDCOD',pic:'ZZZ9',hsh:true},{av:'AV14Insert_UsuCod',fld:'vINSERT_USUCOD',pic:''},{av:'dynUsuCod'},{av:'A3UsuCod',fld:'USUCOD',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'dynUsuCod'},{av:'A3UsuCod',fld:'USUCOD',pic:''}]}");
         setEventMetadata("AFTER TRN","{handler:'E120V2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'dynUsuCod'},{av:'A3UsuCod',fld:'USUCOD',pic:''}]");
         setEventMetadata("AFTER TRN",",oparms:[{av:'dynUsuCod'},{av:'A3UsuCod',fld:'USUCOD',pic:''}]}");
         setEventMetadata("PRDCOD.CONTROLVALUECHANGED","{handler:'E130V2',iparms:[{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV8AgeID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'A286PrdCod',fld:'PRDCOD',pic:'ZZZ9'},{av:'dynUsuCod'},{av:'A3UsuCod',fld:'USUCOD',pic:''}]");
         setEventMetadata("PRDCOD.CONTROLVALUECHANGED",",oparms:[{av:'AV16PrdDscp',fld:'vPRDDSCP',pic:''},{av:'dynUsuCod'},{av:'A3UsuCod',fld:'USUCOD',pic:''}]}");
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
         pr_default.close(17);
         pr_default.close(18);
         pr_default.close(19);
         pr_default.close(23);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z302fecha = DateTime.MinValue;
         Z3UsuCod = "";
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
         A44empdsc = "";
         A46AgeDsc = "";
         A302fecha = DateTime.MinValue;
         A309prdNombre = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         AV14Insert_UsuCod = "";
         AV18Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode73 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV12TrnContext = new SdtTransactionContext(context);
         AV13WebSession = context.GetSession();
         AV15TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV16PrdDscp = "";
         GXt_char1 = "";
         Z44empdsc = "";
         Z46AgeDsc = "";
         Z309prdNombre = "";
         T000V4_A44empdsc = new String[] {""} ;
         T000V4_n44empdsc = new bool[] {false} ;
         T000V5_A46AgeDsc = new String[] {""} ;
         T000V5_n46AgeDsc = new bool[] {false} ;
         T000V6_A309prdNombre = new String[] {""} ;
         T000V6_n309prdNombre = new bool[] {false} ;
         T000V8_A310ProdPreID = new short[1] ;
         T000V8_A44empdsc = new String[] {""} ;
         T000V8_n44empdsc = new bool[] {false} ;
         T000V8_A46AgeDsc = new String[] {""} ;
         T000V8_n46AgeDsc = new bool[] {false} ;
         T000V8_A309prdNombre = new String[] {""} ;
         T000V8_n309prdNombre = new bool[] {false} ;
         T000V8_A302fecha = new DateTime[] {DateTime.MinValue} ;
         T000V8_n302fecha = new bool[] {false} ;
         T000V8_A303valAnt = new decimal[1] ;
         T000V8_n303valAnt = new bool[] {false} ;
         T000V8_A304valoAct = new decimal[1] ;
         T000V8_n304valoAct = new bool[] {false} ;
         T000V8_A1EmpID = new short[1] ;
         T000V8_A2AgeID = new short[1] ;
         T000V8_A286PrdCod = new short[1] ;
         T000V8_A3UsuCod = new String[] {""} ;
         T000V7_A3UsuCod = new String[] {""} ;
         T000V9_A44empdsc = new String[] {""} ;
         T000V9_n44empdsc = new bool[] {false} ;
         T000V10_A46AgeDsc = new String[] {""} ;
         T000V10_n46AgeDsc = new bool[] {false} ;
         T000V11_A309prdNombre = new String[] {""} ;
         T000V11_n309prdNombre = new bool[] {false} ;
         T000V12_A3UsuCod = new String[] {""} ;
         T000V13_A1EmpID = new short[1] ;
         T000V13_A2AgeID = new short[1] ;
         T000V13_A310ProdPreID = new short[1] ;
         T000V13_A286PrdCod = new short[1] ;
         T000V3_A310ProdPreID = new short[1] ;
         T000V3_A302fecha = new DateTime[] {DateTime.MinValue} ;
         T000V3_n302fecha = new bool[] {false} ;
         T000V3_A303valAnt = new decimal[1] ;
         T000V3_n303valAnt = new bool[] {false} ;
         T000V3_A304valoAct = new decimal[1] ;
         T000V3_n304valoAct = new bool[] {false} ;
         T000V3_A1EmpID = new short[1] ;
         T000V3_A2AgeID = new short[1] ;
         T000V3_A286PrdCod = new short[1] ;
         T000V3_A3UsuCod = new String[] {""} ;
         T000V14_A1EmpID = new short[1] ;
         T000V14_A2AgeID = new short[1] ;
         T000V14_A310ProdPreID = new short[1] ;
         T000V14_A286PrdCod = new short[1] ;
         T000V15_A1EmpID = new short[1] ;
         T000V15_A2AgeID = new short[1] ;
         T000V15_A310ProdPreID = new short[1] ;
         T000V15_A286PrdCod = new short[1] ;
         T000V2_A310ProdPreID = new short[1] ;
         T000V2_A302fecha = new DateTime[] {DateTime.MinValue} ;
         T000V2_n302fecha = new bool[] {false} ;
         T000V2_A303valAnt = new decimal[1] ;
         T000V2_n303valAnt = new bool[] {false} ;
         T000V2_A304valoAct = new decimal[1] ;
         T000V2_n304valoAct = new bool[] {false} ;
         T000V2_A1EmpID = new short[1] ;
         T000V2_A2AgeID = new short[1] ;
         T000V2_A286PrdCod = new short[1] ;
         T000V2_A3UsuCod = new String[] {""} ;
         T000V19_A44empdsc = new String[] {""} ;
         T000V19_n44empdsc = new bool[] {false} ;
         T000V20_A46AgeDsc = new String[] {""} ;
         T000V20_n46AgeDsc = new bool[] {false} ;
         T000V21_A309prdNombre = new String[] {""} ;
         T000V21_n309prdNombre = new bool[] {false} ;
         T000V22_A1EmpID = new short[1] ;
         T000V22_A2AgeID = new short[1] ;
         T000V22_A310ProdPreID = new short[1] ;
         T000V22_A286PrdCod = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         T000V23_A3UsuCod = new String[] {""} ;
         T000V23_A50UsuName = new String[] {""} ;
         T000V23_n50UsuName = new bool[] {false} ;
         T000V24_A3UsuCod = new String[] {""} ;
         T000V24_A50UsuName = new String[] {""} ;
         T000V24_n50UsuName = new bool[] {false} ;
         isValidOutput = new GxUnknownObjectCollection();
         T000V25_A3UsuCod = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.prodprecio__default(),
            new Object[][] {
                new Object[] {
               T000V2_A310ProdPreID, T000V2_A302fecha, T000V2_n302fecha, T000V2_A303valAnt, T000V2_n303valAnt, T000V2_A304valoAct, T000V2_n304valoAct, T000V2_A1EmpID, T000V2_A2AgeID, T000V2_A286PrdCod,
               T000V2_A3UsuCod
               }
               , new Object[] {
               T000V3_A310ProdPreID, T000V3_A302fecha, T000V3_n302fecha, T000V3_A303valAnt, T000V3_n303valAnt, T000V3_A304valoAct, T000V3_n304valoAct, T000V3_A1EmpID, T000V3_A2AgeID, T000V3_A286PrdCod,
               T000V3_A3UsuCod
               }
               , new Object[] {
               T000V4_A44empdsc, T000V4_n44empdsc
               }
               , new Object[] {
               T000V5_A46AgeDsc, T000V5_n46AgeDsc
               }
               , new Object[] {
               T000V6_A309prdNombre, T000V6_n309prdNombre
               }
               , new Object[] {
               T000V7_A3UsuCod
               }
               , new Object[] {
               T000V8_A310ProdPreID, T000V8_A44empdsc, T000V8_n44empdsc, T000V8_A46AgeDsc, T000V8_n46AgeDsc, T000V8_A309prdNombre, T000V8_n309prdNombre, T000V8_A302fecha, T000V8_n302fecha, T000V8_A303valAnt,
               T000V8_n303valAnt, T000V8_A304valoAct, T000V8_n304valoAct, T000V8_A1EmpID, T000V8_A2AgeID, T000V8_A286PrdCod, T000V8_A3UsuCod
               }
               , new Object[] {
               T000V9_A44empdsc, T000V9_n44empdsc
               }
               , new Object[] {
               T000V10_A46AgeDsc, T000V10_n46AgeDsc
               }
               , new Object[] {
               T000V11_A309prdNombre, T000V11_n309prdNombre
               }
               , new Object[] {
               T000V12_A3UsuCod
               }
               , new Object[] {
               T000V13_A1EmpID, T000V13_A2AgeID, T000V13_A310ProdPreID, T000V13_A286PrdCod
               }
               , new Object[] {
               T000V14_A1EmpID, T000V14_A2AgeID, T000V14_A310ProdPreID, T000V14_A286PrdCod
               }
               , new Object[] {
               T000V15_A1EmpID, T000V15_A2AgeID, T000V15_A310ProdPreID, T000V15_A286PrdCod
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000V19_A44empdsc, T000V19_n44empdsc
               }
               , new Object[] {
               T000V20_A46AgeDsc, T000V20_n46AgeDsc
               }
               , new Object[] {
               T000V21_A309prdNombre, T000V21_n309prdNombre
               }
               , new Object[] {
               T000V22_A1EmpID, T000V22_A2AgeID, T000V22_A310ProdPreID, T000V22_A286PrdCod
               }
               , new Object[] {
               T000V23_A3UsuCod, T000V23_A50UsuName, T000V23_n50UsuName
               }
               , new Object[] {
               T000V24_A3UsuCod, T000V24_A50UsuName, T000V24_n50UsuName
               }
               , new Object[] {
               T000V25_A3UsuCod
               }
            }
         );
         AV18Pgmname = "ProdPrecio";
      }

      private short wcpOAV17ProdPreID ;
      private short wcpOAV7EmpID ;
      private short wcpOAV8AgeID ;
      private short wcpOAV10PrdCod ;
      private short Z1EmpID ;
      private short Z2AgeID ;
      private short Z310ProdPreID ;
      private short Z286PrdCod ;
      private short GxWebError ;
      private short A1EmpID ;
      private short A2AgeID ;
      private short A286PrdCod ;
      private short AV17ProdPreID ;
      private short AV7EmpID ;
      private short AV8AgeID ;
      private short AV10PrdCod ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short A310ProdPreID ;
      private short RcdFound73 ;
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
      private int edtfecha_Enabled ;
      private int edtProdPreID_Enabled ;
      private int edtPrdCod_Enabled ;
      private int imgprompt_286_Visible ;
      private int edtprdNombre_Enabled ;
      private int edtvalAnt_Enabled ;
      private int edtvaloAct_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int AV19GXV1 ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private decimal Z303valAnt ;
      private decimal Z304valoAct ;
      private decimal A303valAnt ;
      private decimal A304valoAct ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z3UsuCod ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String A3UsuCod ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtEmpID_Internalname ;
      private String dynUsuCod_Internalname ;
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
      private String divTable1_Internalname ;
      private String divSection4_Internalname ;
      private String edtEmpID_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_1_Internalname ;
      private String imgprompt_1_Link ;
      private String edtempdsc_Internalname ;
      private String edtempdsc_Jsonclick ;
      private String divSection1_Internalname ;
      private String edtAgeID_Internalname ;
      private String edtAgeID_Jsonclick ;
      private String imgprompt_2_Internalname ;
      private String imgprompt_2_Link ;
      private String edtAgeDsc_Internalname ;
      private String A46AgeDsc ;
      private String edtAgeDsc_Jsonclick ;
      private String divSection3_Internalname ;
      private String edtfecha_Internalname ;
      private String edtfecha_Jsonclick ;
      private String dynUsuCod_Jsonclick ;
      private String grpGroup1_Internalname ;
      private String divGroup1table_Internalname ;
      private String edtProdPreID_Internalname ;
      private String edtProdPreID_Jsonclick ;
      private String edtPrdCod_Internalname ;
      private String edtPrdCod_Jsonclick ;
      private String imgprompt_286_Internalname ;
      private String imgprompt_286_Link ;
      private String edtprdNombre_Internalname ;
      private String edtprdNombre_Jsonclick ;
      private String edtvalAnt_Internalname ;
      private String edtvalAnt_Jsonclick ;
      private String edtvaloAct_Internalname ;
      private String edtvaloAct_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String AV14Insert_UsuCod ;
      private String AV18Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode73 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXt_char1 ;
      private String Z46AgeDsc ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String gxwrpcisep ;
      private DateTime Z302fecha ;
      private DateTime A302fecha ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n44empdsc ;
      private bool n46AgeDsc ;
      private bool n302fecha ;
      private bool n309prdNombre ;
      private bool n303valAnt ;
      private bool n304valoAct ;
      private bool returnInSub ;
      private bool gxdyncontrolsrefreshing ;
      private String A44empdsc ;
      private String A309prdNombre ;
      private String AV16PrdDscp ;
      private String Z44empdsc ;
      private String Z309prdNombre ;
      private IGxSession AV13WebSession ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynUsuCod ;
      private IDataStoreProvider pr_default ;
      private String[] T000V4_A44empdsc ;
      private bool[] T000V4_n44empdsc ;
      private String[] T000V5_A46AgeDsc ;
      private bool[] T000V5_n46AgeDsc ;
      private String[] T000V6_A309prdNombre ;
      private bool[] T000V6_n309prdNombre ;
      private short[] T000V8_A310ProdPreID ;
      private String[] T000V8_A44empdsc ;
      private bool[] T000V8_n44empdsc ;
      private String[] T000V8_A46AgeDsc ;
      private bool[] T000V8_n46AgeDsc ;
      private String[] T000V8_A309prdNombre ;
      private bool[] T000V8_n309prdNombre ;
      private DateTime[] T000V8_A302fecha ;
      private bool[] T000V8_n302fecha ;
      private decimal[] T000V8_A303valAnt ;
      private bool[] T000V8_n303valAnt ;
      private decimal[] T000V8_A304valoAct ;
      private bool[] T000V8_n304valoAct ;
      private short[] T000V8_A1EmpID ;
      private short[] T000V8_A2AgeID ;
      private short[] T000V8_A286PrdCod ;
      private String[] T000V8_A3UsuCod ;
      private String[] T000V7_A3UsuCod ;
      private String[] T000V9_A44empdsc ;
      private bool[] T000V9_n44empdsc ;
      private String[] T000V10_A46AgeDsc ;
      private bool[] T000V10_n46AgeDsc ;
      private String[] T000V11_A309prdNombre ;
      private bool[] T000V11_n309prdNombre ;
      private String[] T000V12_A3UsuCod ;
      private short[] T000V13_A1EmpID ;
      private short[] T000V13_A2AgeID ;
      private short[] T000V13_A310ProdPreID ;
      private short[] T000V13_A286PrdCod ;
      private short[] T000V3_A310ProdPreID ;
      private DateTime[] T000V3_A302fecha ;
      private bool[] T000V3_n302fecha ;
      private decimal[] T000V3_A303valAnt ;
      private bool[] T000V3_n303valAnt ;
      private decimal[] T000V3_A304valoAct ;
      private bool[] T000V3_n304valoAct ;
      private short[] T000V3_A1EmpID ;
      private short[] T000V3_A2AgeID ;
      private short[] T000V3_A286PrdCod ;
      private String[] T000V3_A3UsuCod ;
      private short[] T000V14_A1EmpID ;
      private short[] T000V14_A2AgeID ;
      private short[] T000V14_A310ProdPreID ;
      private short[] T000V14_A286PrdCod ;
      private short[] T000V15_A1EmpID ;
      private short[] T000V15_A2AgeID ;
      private short[] T000V15_A310ProdPreID ;
      private short[] T000V15_A286PrdCod ;
      private short[] T000V2_A310ProdPreID ;
      private DateTime[] T000V2_A302fecha ;
      private bool[] T000V2_n302fecha ;
      private decimal[] T000V2_A303valAnt ;
      private bool[] T000V2_n303valAnt ;
      private decimal[] T000V2_A304valoAct ;
      private bool[] T000V2_n304valoAct ;
      private short[] T000V2_A1EmpID ;
      private short[] T000V2_A2AgeID ;
      private short[] T000V2_A286PrdCod ;
      private String[] T000V2_A3UsuCod ;
      private String[] T000V19_A44empdsc ;
      private bool[] T000V19_n44empdsc ;
      private String[] T000V20_A46AgeDsc ;
      private bool[] T000V20_n46AgeDsc ;
      private String[] T000V21_A309prdNombre ;
      private bool[] T000V21_n309prdNombre ;
      private short[] T000V22_A1EmpID ;
      private short[] T000V22_A2AgeID ;
      private short[] T000V22_A310ProdPreID ;
      private short[] T000V22_A286PrdCod ;
      private String[] T000V23_A3UsuCod ;
      private String[] T000V23_A50UsuName ;
      private bool[] T000V23_n50UsuName ;
      private String[] T000V24_A3UsuCod ;
      private String[] T000V24_A50UsuName ;
      private bool[] T000V24_n50UsuName ;
      private String[] T000V25_A3UsuCod ;
      private SdtTransactionContext AV12TrnContext ;
      private SdtTransactionContext_Attribute AV15TrnContextAtt ;
   }

   public class prodprecio__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[23])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000V8 ;
          prmT000V8 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ProdPreID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000V4 ;
          prmT000V4 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000V5 ;
          prmT000V5 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000V6 ;
          prmT000V6 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000V7 ;
          prmT000V7 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000V9 ;
          prmT000V9 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000V10 ;
          prmT000V10 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000V11 ;
          prmT000V11 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000V12 ;
          prmT000V12 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000V13 ;
          prmT000V13 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ProdPreID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000V3 ;
          prmT000V3 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ProdPreID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000V14 ;
          prmT000V14 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ProdPreID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000V15 ;
          prmT000V15 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ProdPreID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000V2 ;
          prmT000V2 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ProdPreID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000V16 ;
          prmT000V16 = new Object[] {
          new Object[] {"@ProdPreID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@fecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@valAnt",SqlDbType.Decimal,10,2} ,
          new Object[] {"@valoAct",SqlDbType.Decimal,10,2} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000V17 ;
          prmT000V17 = new Object[] {
          new Object[] {"@fecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@valAnt",SqlDbType.Decimal,10,2} ,
          new Object[] {"@valoAct",SqlDbType.Decimal,10,2} ,
          new Object[] {"@UsuCod",SqlDbType.Char,15,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ProdPreID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000V18 ;
          prmT000V18 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ProdPreID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000V22 ;
          prmT000V22 = new Object[] {
          } ;
          Object[] prmT000V23 ;
          prmT000V23 = new Object[] {
          } ;
          Object[] prmT000V24 ;
          prmT000V24 = new Object[] {
          } ;
          Object[] prmT000V19 ;
          prmT000V19 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000V20 ;
          prmT000V20 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000V21 ;
          prmT000V21 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000V25 ;
          prmT000V25 = new Object[] {
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000V2", "SELECT [ProdPreID], [fecha], [valAnt], [valoAct], [EmpID], [AgeID], [PrdCod], [UsuCod] FROM [ProdPrecio] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [ProdPreID] = @ProdPreID AND [PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V2,1,0,true,false )
             ,new CursorDef("T000V3", "SELECT [ProdPreID], [fecha], [valAnt], [valoAct], [EmpID], [AgeID], [PrdCod], [UsuCod] FROM [ProdPrecio] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [ProdPreID] = @ProdPreID AND [PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V3,1,0,true,false )
             ,new CursorDef("T000V4", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V4,1,0,true,false )
             ,new CursorDef("T000V5", "SELECT [AgeDsc] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V5,1,0,true,false )
             ,new CursorDef("T000V6", "SELECT [prdNombre] FROM [Productos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V6,1,0,true,false )
             ,new CursorDef("T000V7", "SELECT [UsuCod] FROM [Usuarios] WITH (NOLOCK) WHERE [UsuCod] = @UsuCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V7,1,0,true,false )
             ,new CursorDef("T000V8", "SELECT TM1.[ProdPreID], T2.[empdsc], T3.[AgeDsc], T4.[prdNombre], TM1.[fecha], TM1.[valAnt], TM1.[valoAct], TM1.[EmpID], TM1.[AgeID], TM1.[PrdCod], TM1.[UsuCod] FROM ((([ProdPrecio] TM1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = TM1.[EmpID]) INNER JOIN [Agencias] T3 WITH (NOLOCK) ON T3.[EmpID] = TM1.[EmpID] AND T3.[AgeID] = TM1.[AgeID]) INNER JOIN [Productos] T4 WITH (NOLOCK) ON T4.[EmpID] = TM1.[EmpID] AND T4.[AgeID] = TM1.[AgeID] AND T4.[PrdCod] = TM1.[PrdCod]) WHERE TM1.[EmpID] = @EmpID and TM1.[AgeID] = @AgeID and TM1.[ProdPreID] = @ProdPreID and TM1.[PrdCod] = @PrdCod ORDER BY TM1.[EmpID], TM1.[AgeID], TM1.[ProdPreID], TM1.[PrdCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000V8,100,0,true,false )
             ,new CursorDef("T000V9", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V9,1,0,true,false )
             ,new CursorDef("T000V10", "SELECT [AgeDsc] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V10,1,0,true,false )
             ,new CursorDef("T000V11", "SELECT [prdNombre] FROM [Productos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V11,1,0,true,false )
             ,new CursorDef("T000V12", "SELECT [UsuCod] FROM [Usuarios] WITH (NOLOCK) WHERE [UsuCod] = @UsuCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V12,1,0,true,false )
             ,new CursorDef("T000V13", "SELECT [EmpID], [AgeID], [ProdPreID], [PrdCod] FROM [ProdPrecio] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [ProdPreID] = @ProdPreID AND [PrdCod] = @PrdCod  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000V13,1,0,true,false )
             ,new CursorDef("T000V14", "SELECT TOP 1 [EmpID], [AgeID], [ProdPreID], [PrdCod] FROM [ProdPrecio] WITH (NOLOCK) WHERE ( [EmpID] > @EmpID or [EmpID] = @EmpID and [AgeID] > @AgeID or [AgeID] = @AgeID and [EmpID] = @EmpID and [ProdPreID] > @ProdPreID or [ProdPreID] = @ProdPreID and [AgeID] = @AgeID and [EmpID] = @EmpID and [PrdCod] > @PrdCod) ORDER BY [EmpID], [AgeID], [ProdPreID], [PrdCod]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000V14,1,0,true,true )
             ,new CursorDef("T000V15", "SELECT TOP 1 [EmpID], [AgeID], [ProdPreID], [PrdCod] FROM [ProdPrecio] WITH (NOLOCK) WHERE ( [EmpID] < @EmpID or [EmpID] = @EmpID and [AgeID] < @AgeID or [AgeID] = @AgeID and [EmpID] = @EmpID and [ProdPreID] < @ProdPreID or [ProdPreID] = @ProdPreID and [AgeID] = @AgeID and [EmpID] = @EmpID and [PrdCod] < @PrdCod) ORDER BY [EmpID] DESC, [AgeID] DESC, [ProdPreID] DESC, [PrdCod] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000V15,1,0,true,true )
             ,new CursorDef("T000V16", "INSERT INTO [ProdPrecio]([ProdPreID], [fecha], [valAnt], [valoAct], [EmpID], [AgeID], [PrdCod], [UsuCod]) VALUES(@ProdPreID, @fecha, @valAnt, @valoAct, @EmpID, @AgeID, @PrdCod, @UsuCod)", GxErrorMask.GX_NOMASK,prmT000V16)
             ,new CursorDef("T000V17", "UPDATE [ProdPrecio] SET [fecha]=@fecha, [valAnt]=@valAnt, [valoAct]=@valoAct, [UsuCod]=@UsuCod  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [ProdPreID] = @ProdPreID AND [PrdCod] = @PrdCod", GxErrorMask.GX_NOMASK,prmT000V17)
             ,new CursorDef("T000V18", "DELETE FROM [ProdPrecio]  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [ProdPreID] = @ProdPreID AND [PrdCod] = @PrdCod", GxErrorMask.GX_NOMASK,prmT000V18)
             ,new CursorDef("T000V19", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V19,1,0,true,false )
             ,new CursorDef("T000V20", "SELECT [AgeDsc] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V20,1,0,true,false )
             ,new CursorDef("T000V21", "SELECT [prdNombre] FROM [Productos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V21,1,0,true,false )
             ,new CursorDef("T000V22", "SELECT [EmpID], [AgeID], [ProdPreID], [PrdCod] FROM [ProdPrecio] WITH (NOLOCK) ORDER BY [EmpID], [AgeID], [ProdPreID], [PrdCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000V22,100,0,true,false )
             ,new CursorDef("T000V23", "SELECT [UsuCod], [UsuName] FROM [Usuarios] WITH (NOLOCK) ORDER BY [UsuName] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V23,0,0,true,false )
             ,new CursorDef("T000V24", "SELECT [UsuCod], [UsuName] FROM [Usuarios] WITH (NOLOCK) ORDER BY [UsuName] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V24,0,0,true,false )
             ,new CursorDef("T000V25", "SELECT [UsuCod] FROM [Usuarios] WITH (NOLOCK) WHERE [UsuCod] = @UsuCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V25,1,0,true,false )
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
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((decimal[]) buf[3])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((decimal[]) buf[5])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                ((short[]) buf[8])[0] = rslt.getShort(6) ;
                ((short[]) buf[9])[0] = rslt.getShort(7) ;
                ((String[]) buf[10])[0] = rslt.getString(8, 15) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((decimal[]) buf[3])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((decimal[]) buf[5])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                ((short[]) buf[8])[0] = rslt.getShort(6) ;
                ((short[]) buf[9])[0] = rslt.getShort(7) ;
                ((String[]) buf[10])[0] = rslt.getString(8, 15) ;
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((decimal[]) buf[9])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((decimal[]) buf[11])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((short[]) buf[13])[0] = rslt.getShort(8) ;
                ((short[]) buf[14])[0] = rslt.getShort(9) ;
                ((short[]) buf[15])[0] = rslt.getShort(10) ;
                ((String[]) buf[16])[0] = rslt.getString(11, 15) ;
                return;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                return;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 19 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 20 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 21 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                return;
             case 22 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                return;
             case 23 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
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
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 14 :
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
                   stmt.setNull( 3 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(3, (decimal)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 4 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(4, (decimal)parms[6]);
                }
                stmt.SetParameter(5, (short)parms[7]);
                stmt.SetParameter(6, (short)parms[8]);
                stmt.SetParameter(7, (short)parms[9]);
                stmt.SetParameter(8, (String)parms[10]);
                return;
             case 15 :
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
                stmt.SetParameter(4, (String)parms[6]);
                stmt.SetParameter(5, (short)parms[7]);
                stmt.SetParameter(6, (short)parms[8]);
                stmt.SetParameter(7, (short)parms[9]);
                stmt.SetParameter(8, (short)parms[10]);
                return;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
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
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 23 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
       }
    }

 }

}
