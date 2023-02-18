/*
               File: Vehiculos
        Description: Vehiculos
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/14/2023 1:15:42.28
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
   public class vehiculos : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel5"+"_"+"VEHICULOID") == 0 )
         {
            AV8VehiculoID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8VehiculoID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vVEHICULOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8VehiculoID), "ZZZ9"), context));
            AV7EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7EmpID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EmpID), "ZZZ9"), context));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX5ASAVEHICULOID0I8( AV8VehiculoID, AV7EmpID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_16") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_16( A1EmpID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_17") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A6MarcaID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6MarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(A6MarcaID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_17( A1EmpID, A6MarcaID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_18") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A6MarcaID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6MarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(A6MarcaID), 4, 0)));
            A7ModeloID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7ModeloID", StringUtil.LTrim( StringUtil.Str( (decimal)(A7ModeloID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_18( A1EmpID, A6MarcaID, A7ModeloID) ;
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
               AV8VehiculoID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8VehiculoID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vVEHICULOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8VehiculoID), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Vehiculos", 0) ;
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

      public vehiculos( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public vehiculos( IGxContext context )
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
                           short aP2_VehiculoID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7EmpID = aP1_EmpID;
         this.AV8VehiculoID = aP2_VehiculoID;
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Vehiculos", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Vehiculos.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Vehiculos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Vehiculos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Vehiculos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Vehiculos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0080.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"VEHICULOID"+"'), id:'"+"VEHICULOID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_Vehiculos.htm");
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
            GxWebStd.gx_single_line_edit( context, edtEmpID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEmpID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEmpID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Vehiculos.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_1_Internalname, sImgUrl, imgprompt_1_Link, "", "", context.GetTheme( ), imgprompt_1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Vehiculos.htm");
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
            GxWebStd.gx_single_line_edit( context, edtempdsc_Internalname, A44empdsc, StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempdsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtempdsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Vehiculos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtVehiculoID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtVehiculoID_Internalname, "ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtVehiculoID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A8VehiculoID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A8VehiculoID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVehiculoID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtVehiculoID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Vehiculos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtVehiculoDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtVehiculoDsc_Internalname, "Descripcion", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtVehiculoDsc_Internalname, StringUtil.RTrim( A66VehiculoDsc), StringUtil.RTrim( context.localUtil.Format( A66VehiculoDsc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVehiculoDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtVehiculoDsc_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "Descripcion", "left", true, "HLP_Vehiculos.htm");
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
            GxWebStd.gx_label_element( context, edtMarcaID_Internalname, "Marca ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtMarcaID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A6MarcaID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A6MarcaID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtMarcaID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtMarcaID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Vehiculos.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_6_Internalname, sImgUrl, imgprompt_6_Link, "", "", context.GetTheme( ), imgprompt_6_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Vehiculos.htm");
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
            GxWebStd.gx_label_element( context, edtMarcaDsc_Internalname, "Marca Dsc", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtMarcaDsc_Internalname, StringUtil.RTrim( A62MarcaDsc), StringUtil.RTrim( context.localUtil.Format( A62MarcaDsc, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtMarcaDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtMarcaDsc_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "Descripcion", "left", true, "HLP_Vehiculos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtModeloID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtModeloID_Internalname, "Modelo ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtModeloID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A7ModeloID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A7ModeloID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtModeloID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtModeloID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Vehiculos.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_7_Internalname, sImgUrl, imgprompt_7_Link, "", "", context.GetTheme( ), imgprompt_7_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Vehiculos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtModeloDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtModeloDsc_Internalname, "Modelo Dsc", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtModeloDsc_Internalname, StringUtil.RTrim( A64ModeloDsc), StringUtil.RTrim( context.localUtil.Format( A64ModeloDsc, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtModeloDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtModeloDsc_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "Descripcion", "left", true, "HLP_Vehiculos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtVehiculoEst_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtVehiculoEst_Internalname, "Est", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtVehiculoEst_Internalname, StringUtil.RTrim( A67VehiculoEst), StringUtil.RTrim( context.localUtil.Format( A67VehiculoEst, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,74);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVehiculoEst_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtVehiculoEst_Enabled, 0, "text", "", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, -1, true, "estado", "left", true, "HLP_Vehiculos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtVehiculoPlaca_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtVehiculoPlaca_Internalname, "Placa", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 79,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtVehiculoPlaca_Internalname, A68VehiculoPlaca, StringUtil.RTrim( context.localUtil.Format( A68VehiculoPlaca, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,79);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVehiculoPlaca_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtVehiculoPlaca_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Vehiculos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtVehiculoChasis_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtVehiculoChasis_Internalname, "Chasis", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 84,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtVehiculoChasis_Internalname, A69VehiculoChasis, StringUtil.RTrim( context.localUtil.Format( A69VehiculoChasis, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,84);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVehiculoChasis_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtVehiculoChasis_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Vehiculos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtVehiculoResponsable_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtVehiculoResponsable_Internalname, "Responsable", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 89,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtVehiculoResponsable_Internalname, StringUtil.RTrim( A70VehiculoResponsable), StringUtil.RTrim( context.localUtil.Format( A70VehiculoResponsable, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,89);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVehiculoResponsable_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtVehiculoResponsable_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "Descripcion", "left", true, "HLP_Vehiculos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtVehiculoCedResp_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtVehiculoCedResp_Internalname, "Responsable", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 94,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtVehiculoCedResp_Internalname, StringUtil.RTrim( A71VehiculoCedResp), StringUtil.RTrim( context.localUtil.Format( A71VehiculoCedResp, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,94);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVehiculoCedResp_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtVehiculoCedResp_Enabled, 0, "text", "", 13, "chr", 1, "row", 13, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Vehiculos.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 99,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Vehiculos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 101,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Vehiculos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 103,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Vehiculos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm0I8( ) ;
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
         E110I2 ();
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtVehiculoID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtVehiculoID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "VEHICULOID");
                  AnyError = 1;
                  GX_FocusControl = edtVehiculoID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A8VehiculoID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(A8VehiculoID), 4, 0)));
               }
               else
               {
                  A8VehiculoID = (short)(context.localUtil.CToN( cgiGet( edtVehiculoID_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(A8VehiculoID), 4, 0)));
               }
               A66VehiculoDsc = cgiGet( edtVehiculoDsc_Internalname);
               n66VehiculoDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A66VehiculoDsc", A66VehiculoDsc);
               n66VehiculoDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A66VehiculoDsc)) ? true : false);
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtModeloID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtModeloID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "MODELOID");
                  AnyError = 1;
                  GX_FocusControl = edtModeloID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A7ModeloID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7ModeloID", StringUtil.LTrim( StringUtil.Str( (decimal)(A7ModeloID), 4, 0)));
               }
               else
               {
                  A7ModeloID = (short)(context.localUtil.CToN( cgiGet( edtModeloID_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7ModeloID", StringUtil.LTrim( StringUtil.Str( (decimal)(A7ModeloID), 4, 0)));
               }
               A64ModeloDsc = cgiGet( edtModeloDsc_Internalname);
               n64ModeloDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64ModeloDsc", A64ModeloDsc);
               A67VehiculoEst = cgiGet( edtVehiculoEst_Internalname);
               n67VehiculoEst = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67VehiculoEst", A67VehiculoEst);
               n67VehiculoEst = (String.IsNullOrEmpty(StringUtil.RTrim( A67VehiculoEst)) ? true : false);
               A68VehiculoPlaca = cgiGet( edtVehiculoPlaca_Internalname);
               n68VehiculoPlaca = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68VehiculoPlaca", A68VehiculoPlaca);
               n68VehiculoPlaca = (String.IsNullOrEmpty(StringUtil.RTrim( A68VehiculoPlaca)) ? true : false);
               A69VehiculoChasis = cgiGet( edtVehiculoChasis_Internalname);
               n69VehiculoChasis = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A69VehiculoChasis", A69VehiculoChasis);
               n69VehiculoChasis = (String.IsNullOrEmpty(StringUtil.RTrim( A69VehiculoChasis)) ? true : false);
               A70VehiculoResponsable = cgiGet( edtVehiculoResponsable_Internalname);
               n70VehiculoResponsable = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A70VehiculoResponsable", A70VehiculoResponsable);
               n70VehiculoResponsable = (String.IsNullOrEmpty(StringUtil.RTrim( A70VehiculoResponsable)) ? true : false);
               A71VehiculoCedResp = cgiGet( edtVehiculoCedResp_Internalname);
               n71VehiculoCedResp = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A71VehiculoCedResp", A71VehiculoCedResp);
               n71VehiculoCedResp = (String.IsNullOrEmpty(StringUtil.RTrim( A71VehiculoCedResp)) ? true : false);
               /* Read saved values. */
               Z1EmpID = (short)(context.localUtil.CToN( cgiGet( "Z1EmpID"), ",", "."));
               Z8VehiculoID = (short)(context.localUtil.CToN( cgiGet( "Z8VehiculoID"), ",", "."));
               Z66VehiculoDsc = cgiGet( "Z66VehiculoDsc");
               n66VehiculoDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A66VehiculoDsc)) ? true : false);
               Z67VehiculoEst = cgiGet( "Z67VehiculoEst");
               n67VehiculoEst = (String.IsNullOrEmpty(StringUtil.RTrim( A67VehiculoEst)) ? true : false);
               Z68VehiculoPlaca = cgiGet( "Z68VehiculoPlaca");
               n68VehiculoPlaca = (String.IsNullOrEmpty(StringUtil.RTrim( A68VehiculoPlaca)) ? true : false);
               Z69VehiculoChasis = cgiGet( "Z69VehiculoChasis");
               n69VehiculoChasis = (String.IsNullOrEmpty(StringUtil.RTrim( A69VehiculoChasis)) ? true : false);
               Z70VehiculoResponsable = cgiGet( "Z70VehiculoResponsable");
               n70VehiculoResponsable = (String.IsNullOrEmpty(StringUtil.RTrim( A70VehiculoResponsable)) ? true : false);
               Z71VehiculoCedResp = cgiGet( "Z71VehiculoCedResp");
               n71VehiculoCedResp = (String.IsNullOrEmpty(StringUtil.RTrim( A71VehiculoCedResp)) ? true : false);
               Z6MarcaID = (short)(context.localUtil.CToN( cgiGet( "Z6MarcaID"), ",", "."));
               Z7ModeloID = (short)(context.localUtil.CToN( cgiGet( "Z7ModeloID"), ",", "."));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               N6MarcaID = (short)(context.localUtil.CToN( cgiGet( "N6MarcaID"), ",", "."));
               N7ModeloID = (short)(context.localUtil.CToN( cgiGet( "N7ModeloID"), ",", "."));
               AV7EmpID = (short)(context.localUtil.CToN( cgiGet( "vEMPID"), ",", "."));
               AV8VehiculoID = (short)(context.localUtil.CToN( cgiGet( "vVEHICULOID"), ",", "."));
               AV12Insert_MarcaID = (short)(context.localUtil.CToN( cgiGet( "vINSERT_MARCAID"), ",", "."));
               AV13Insert_ModeloID = (short)(context.localUtil.CToN( cgiGet( "vINSERT_MODELOID"), ",", "."));
               AV15Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Vehiculos";
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV12Insert_MarcaID), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV13Insert_ModeloID), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A1EmpID != Z1EmpID ) || ( A8VehiculoID != Z8VehiculoID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("vehiculos:[SecurityCheckFailed value for]"+"Insert_MarcaID:"+context.localUtil.Format( (decimal)(AV12Insert_MarcaID), "ZZZ9"));
                  GXUtil.WriteLog("vehiculos:[SecurityCheckFailed value for]"+"Insert_ModeloID:"+context.localUtil.Format( (decimal)(AV13Insert_ModeloID), "ZZZ9"));
                  GXUtil.WriteLog("vehiculos:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A8VehiculoID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(A8VehiculoID), 4, 0)));
                  getEqualNoModal( ) ;
                  if ( ! (0==AV8VehiculoID) )
                  {
                     A8VehiculoID = AV8VehiculoID;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(A8VehiculoID), 4, 0)));
                  }
                  else
                  {
                     if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
                     {
                        GXt_int1 = A8VehiculoID;
                        new obtultcodvehiculo(context ).execute(  AV7EmpID, out  GXt_int1) ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7EmpID), 4, 0)));
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EmpID), "ZZZ9"), context));
                        A8VehiculoID = GXt_int1;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(A8VehiculoID), 4, 0)));
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
                     sMode8 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     if ( ! (0==AV8VehiculoID) )
                     {
                        A8VehiculoID = AV8VehiculoID;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(A8VehiculoID), 4, 0)));
                     }
                     else
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
                        {
                           GXt_int1 = A8VehiculoID;
                           new obtultcodvehiculo(context ).execute(  AV7EmpID, out  GXt_int1) ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7EmpID), 4, 0)));
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EmpID), "ZZZ9"), context));
                           A8VehiculoID = GXt_int1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(A8VehiculoID), 4, 0)));
                        }
                     }
                     Gx_mode = sMode8;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound8 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0I0( ) ;
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
                        E110I2 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: After Trn */
                        E120I2 ();
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
            E120I2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0I8( ) ;
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
            DisableAttributes0I8( ) ;
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

      protected void CONFIRM_0I0( )
      {
         BeforeValidate0I8( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0I8( ) ;
            }
            else
            {
               CheckExtendedTable0I8( ) ;
               CloseExtendedTableCursors0I8( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0I0( )
      {
      }

      protected void E110I2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV15Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV15Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV10TrnContext.FromXml(AV11WebSession.Get("TrnContext"), null, "TransactionContext", "KBCalpesa22");
         AV12Insert_MarcaID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Insert_MarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12Insert_MarcaID), 4, 0)));
         AV13Insert_ModeloID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Insert_ModeloID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13Insert_ModeloID), 4, 0)));
         if ( ( StringUtil.StrCmp(AV10TrnContext.gxTpr_Transactionname, AV15Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV16GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16GXV1), 8, 0)));
            while ( AV16GXV1 <= AV10TrnContext.gxTpr_Attributes.Count )
            {
               AV14TrnContextAtt = ((SdtTransactionContext_Attribute)AV10TrnContext.gxTpr_Attributes.Item(AV16GXV1));
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "MarcaID") == 0 )
               {
                  AV12Insert_MarcaID = (short)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Insert_MarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12Insert_MarcaID), 4, 0)));
               }
               else if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "ModeloID") == 0 )
               {
                  AV13Insert_ModeloID = (short)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Insert_ModeloID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13Insert_ModeloID), 4, 0)));
               }
               AV16GXV1 = (int)(AV16GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16GXV1), 8, 0)));
            }
         }
      }

      protected void E120I2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV10TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwvehiculos.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0I8( short GX_JID )
      {
         if ( ( GX_JID == 15 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z66VehiculoDsc = T000I3_A66VehiculoDsc[0];
               Z67VehiculoEst = T000I3_A67VehiculoEst[0];
               Z68VehiculoPlaca = T000I3_A68VehiculoPlaca[0];
               Z69VehiculoChasis = T000I3_A69VehiculoChasis[0];
               Z70VehiculoResponsable = T000I3_A70VehiculoResponsable[0];
               Z71VehiculoCedResp = T000I3_A71VehiculoCedResp[0];
               Z6MarcaID = T000I3_A6MarcaID[0];
               Z7ModeloID = T000I3_A7ModeloID[0];
            }
            else
            {
               Z66VehiculoDsc = A66VehiculoDsc;
               Z67VehiculoEst = A67VehiculoEst;
               Z68VehiculoPlaca = A68VehiculoPlaca;
               Z69VehiculoChasis = A69VehiculoChasis;
               Z70VehiculoResponsable = A70VehiculoResponsable;
               Z71VehiculoCedResp = A71VehiculoCedResp;
               Z6MarcaID = A6MarcaID;
               Z7ModeloID = A7ModeloID;
            }
         }
         if ( GX_JID == -15 )
         {
            Z8VehiculoID = A8VehiculoID;
            Z66VehiculoDsc = A66VehiculoDsc;
            Z67VehiculoEst = A67VehiculoEst;
            Z68VehiculoPlaca = A68VehiculoPlaca;
            Z69VehiculoChasis = A69VehiculoChasis;
            Z70VehiculoResponsable = A70VehiculoResponsable;
            Z71VehiculoCedResp = A71VehiculoCedResp;
            Z1EmpID = A1EmpID;
            Z6MarcaID = A6MarcaID;
            Z7ModeloID = A7ModeloID;
            Z44empdsc = A44empdsc;
            Z62MarcaDsc = A62MarcaDsc;
            Z64ModeloDsc = A64ModeloDsc;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_1_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_6_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0061.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"MARCAID"+"'), id:'"+"MARCAID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_7_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0072.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"MARCAID"+"'), id:'"+"MARCAID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"MODELOID"+"'), id:'"+"MODELOID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
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
         if ( ! (0==AV8VehiculoID) )
         {
            edtVehiculoID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVehiculoID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVehiculoID_Enabled), 5, 0)), true);
         }
         else
         {
            edtVehiculoID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVehiculoID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVehiculoID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV8VehiculoID) )
         {
            edtVehiculoID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVehiculoID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVehiculoID_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV12Insert_MarcaID) )
         {
            edtMarcaID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMarcaID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMarcaID_Enabled), 5, 0)), true);
         }
         else
         {
            edtMarcaID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMarcaID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMarcaID_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_ModeloID) )
         {
            edtModeloID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtModeloID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtModeloID_Enabled), 5, 0)), true);
         }
         else
         {
            edtModeloID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtModeloID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtModeloID_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_ModeloID) )
         {
            A7ModeloID = AV13Insert_ModeloID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7ModeloID", StringUtil.LTrim( StringUtil.Str( (decimal)(A7ModeloID), 4, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV12Insert_MarcaID) )
         {
            A6MarcaID = AV12Insert_MarcaID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6MarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(A6MarcaID), 4, 0)));
         }
         if ( ! (0==AV8VehiculoID) )
         {
            A8VehiculoID = AV8VehiculoID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(A8VehiculoID), 4, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               GXt_int1 = A8VehiculoID;
               new obtultcodvehiculo(context ).execute(  AV7EmpID, out  GXt_int1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7EmpID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EmpID), "ZZZ9"), context));
               A8VehiculoID = GXt_int1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(A8VehiculoID), 4, 0)));
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
            /* Using cursor T000I4 */
            pr_default.execute(2, new Object[] {A1EmpID});
            A44empdsc = T000I4_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000I4_n44empdsc[0];
            pr_default.close(2);
            AV15Pgmname = "Vehiculos";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
            /* Using cursor T000I5 */
            pr_default.execute(3, new Object[] {A1EmpID, A6MarcaID});
            A62MarcaDsc = T000I5_A62MarcaDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62MarcaDsc", A62MarcaDsc);
            n62MarcaDsc = T000I5_n62MarcaDsc[0];
            pr_default.close(3);
            /* Using cursor T000I6 */
            pr_default.execute(4, new Object[] {A1EmpID, A6MarcaID, A7ModeloID});
            A64ModeloDsc = T000I6_A64ModeloDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64ModeloDsc", A64ModeloDsc);
            n64ModeloDsc = T000I6_n64ModeloDsc[0];
            pr_default.close(4);
         }
      }

      protected void Load0I8( )
      {
         /* Using cursor T000I7 */
         pr_default.execute(5, new Object[] {A1EmpID, A8VehiculoID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound8 = 1;
            A44empdsc = T000I7_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000I7_n44empdsc[0];
            A66VehiculoDsc = T000I7_A66VehiculoDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A66VehiculoDsc", A66VehiculoDsc);
            n66VehiculoDsc = T000I7_n66VehiculoDsc[0];
            A62MarcaDsc = T000I7_A62MarcaDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62MarcaDsc", A62MarcaDsc);
            n62MarcaDsc = T000I7_n62MarcaDsc[0];
            A64ModeloDsc = T000I7_A64ModeloDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64ModeloDsc", A64ModeloDsc);
            n64ModeloDsc = T000I7_n64ModeloDsc[0];
            A67VehiculoEst = T000I7_A67VehiculoEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67VehiculoEst", A67VehiculoEst);
            n67VehiculoEst = T000I7_n67VehiculoEst[0];
            A68VehiculoPlaca = T000I7_A68VehiculoPlaca[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68VehiculoPlaca", A68VehiculoPlaca);
            n68VehiculoPlaca = T000I7_n68VehiculoPlaca[0];
            A69VehiculoChasis = T000I7_A69VehiculoChasis[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A69VehiculoChasis", A69VehiculoChasis);
            n69VehiculoChasis = T000I7_n69VehiculoChasis[0];
            A70VehiculoResponsable = T000I7_A70VehiculoResponsable[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A70VehiculoResponsable", A70VehiculoResponsable);
            n70VehiculoResponsable = T000I7_n70VehiculoResponsable[0];
            A71VehiculoCedResp = T000I7_A71VehiculoCedResp[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A71VehiculoCedResp", A71VehiculoCedResp);
            n71VehiculoCedResp = T000I7_n71VehiculoCedResp[0];
            A6MarcaID = T000I7_A6MarcaID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6MarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(A6MarcaID), 4, 0)));
            A7ModeloID = T000I7_A7ModeloID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7ModeloID", StringUtil.LTrim( StringUtil.Str( (decimal)(A7ModeloID), 4, 0)));
            ZM0I8( -15) ;
         }
         pr_default.close(5);
         OnLoadActions0I8( ) ;
      }

      protected void OnLoadActions0I8( )
      {
         AV15Pgmname = "Vehiculos";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
      }

      protected void CheckExtendedTable0I8( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV15Pgmname = "Vehiculos";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
         /* Using cursor T000I4 */
         pr_default.execute(2, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000I4_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T000I4_n44empdsc[0];
         pr_default.close(2);
         /* Using cursor T000I5 */
         pr_default.execute(3, new Object[] {A1EmpID, A6MarcaID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("No existe 'Marca'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A62MarcaDsc = T000I5_A62MarcaDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62MarcaDsc", A62MarcaDsc);
         n62MarcaDsc = T000I5_n62MarcaDsc[0];
         pr_default.close(3);
         /* Using cursor T000I6 */
         pr_default.execute(4, new Object[] {A1EmpID, A6MarcaID, A7ModeloID});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No existe 'Modelo'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A64ModeloDsc = T000I6_A64ModeloDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64ModeloDsc", A64ModeloDsc);
         n64ModeloDsc = T000I6_n64ModeloDsc[0];
         pr_default.close(4);
      }

      protected void CloseExtendedTableCursors0I8( )
      {
         pr_default.close(2);
         pr_default.close(3);
         pr_default.close(4);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_16( short A1EmpID )
      {
         /* Using cursor T000I8 */
         pr_default.execute(6, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000I8_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T000I8_n44empdsc[0];
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

      protected void gxLoad_17( short A1EmpID ,
                                short A6MarcaID )
      {
         /* Using cursor T000I9 */
         pr_default.execute(7, new Object[] {A1EmpID, A6MarcaID});
         if ( (pr_default.getStatus(7) == 101) )
         {
            GX_msglist.addItem("No existe 'Marca'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A62MarcaDsc = T000I9_A62MarcaDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62MarcaDsc", A62MarcaDsc);
         n62MarcaDsc = T000I9_n62MarcaDsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A62MarcaDsc))+"\"");
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
                                short A6MarcaID ,
                                short A7ModeloID )
      {
         /* Using cursor T000I10 */
         pr_default.execute(8, new Object[] {A1EmpID, A6MarcaID, A7ModeloID});
         if ( (pr_default.getStatus(8) == 101) )
         {
            GX_msglist.addItem("No existe 'Modelo'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A64ModeloDsc = T000I10_A64ModeloDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64ModeloDsc", A64ModeloDsc);
         n64ModeloDsc = T000I10_n64ModeloDsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A64ModeloDsc))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(8) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(8);
      }

      protected void GetKey0I8( )
      {
         /* Using cursor T000I11 */
         pr_default.execute(9, new Object[] {A1EmpID, A8VehiculoID});
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound8 = 1;
         }
         else
         {
            RcdFound8 = 0;
         }
         pr_default.close(9);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000I3 */
         pr_default.execute(1, new Object[] {A1EmpID, A8VehiculoID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0I8( 15) ;
            RcdFound8 = 1;
            A8VehiculoID = T000I3_A8VehiculoID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(A8VehiculoID), 4, 0)));
            A66VehiculoDsc = T000I3_A66VehiculoDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A66VehiculoDsc", A66VehiculoDsc);
            n66VehiculoDsc = T000I3_n66VehiculoDsc[0];
            A67VehiculoEst = T000I3_A67VehiculoEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67VehiculoEst", A67VehiculoEst);
            n67VehiculoEst = T000I3_n67VehiculoEst[0];
            A68VehiculoPlaca = T000I3_A68VehiculoPlaca[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68VehiculoPlaca", A68VehiculoPlaca);
            n68VehiculoPlaca = T000I3_n68VehiculoPlaca[0];
            A69VehiculoChasis = T000I3_A69VehiculoChasis[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A69VehiculoChasis", A69VehiculoChasis);
            n69VehiculoChasis = T000I3_n69VehiculoChasis[0];
            A70VehiculoResponsable = T000I3_A70VehiculoResponsable[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A70VehiculoResponsable", A70VehiculoResponsable);
            n70VehiculoResponsable = T000I3_n70VehiculoResponsable[0];
            A71VehiculoCedResp = T000I3_A71VehiculoCedResp[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A71VehiculoCedResp", A71VehiculoCedResp);
            n71VehiculoCedResp = T000I3_n71VehiculoCedResp[0];
            A1EmpID = T000I3_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A6MarcaID = T000I3_A6MarcaID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6MarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(A6MarcaID), 4, 0)));
            A7ModeloID = T000I3_A7ModeloID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7ModeloID", StringUtil.LTrim( StringUtil.Str( (decimal)(A7ModeloID), 4, 0)));
            Z1EmpID = A1EmpID;
            Z8VehiculoID = A8VehiculoID;
            sMode8 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0I8( ) ;
            if ( AnyError == 1 )
            {
               RcdFound8 = 0;
               InitializeNonKey0I8( ) ;
            }
            Gx_mode = sMode8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound8 = 0;
            InitializeNonKey0I8( ) ;
            sMode8 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0I8( ) ;
         if ( RcdFound8 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound8 = 0;
         /* Using cursor T000I12 */
         pr_default.execute(10, new Object[] {A1EmpID, A8VehiculoID});
         if ( (pr_default.getStatus(10) != 101) )
         {
            while ( (pr_default.getStatus(10) != 101) && ( ( T000I12_A1EmpID[0] < A1EmpID ) || ( T000I12_A1EmpID[0] == A1EmpID ) && ( T000I12_A8VehiculoID[0] < A8VehiculoID ) ) )
            {
               pr_default.readNext(10);
            }
            if ( (pr_default.getStatus(10) != 101) && ( ( T000I12_A1EmpID[0] > A1EmpID ) || ( T000I12_A1EmpID[0] == A1EmpID ) && ( T000I12_A8VehiculoID[0] > A8VehiculoID ) ) )
            {
               A1EmpID = T000I12_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A8VehiculoID = T000I12_A8VehiculoID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(A8VehiculoID), 4, 0)));
               RcdFound8 = 1;
            }
         }
         pr_default.close(10);
      }

      protected void move_previous( )
      {
         RcdFound8 = 0;
         /* Using cursor T000I13 */
         pr_default.execute(11, new Object[] {A1EmpID, A8VehiculoID});
         if ( (pr_default.getStatus(11) != 101) )
         {
            while ( (pr_default.getStatus(11) != 101) && ( ( T000I13_A1EmpID[0] > A1EmpID ) || ( T000I13_A1EmpID[0] == A1EmpID ) && ( T000I13_A8VehiculoID[0] > A8VehiculoID ) ) )
            {
               pr_default.readNext(11);
            }
            if ( (pr_default.getStatus(11) != 101) && ( ( T000I13_A1EmpID[0] < A1EmpID ) || ( T000I13_A1EmpID[0] == A1EmpID ) && ( T000I13_A8VehiculoID[0] < A8VehiculoID ) ) )
            {
               A1EmpID = T000I13_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A8VehiculoID = T000I13_A8VehiculoID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(A8VehiculoID), 4, 0)));
               RcdFound8 = 1;
            }
         }
         pr_default.close(11);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0I8( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0I8( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound8 == 1 )
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A8VehiculoID != Z8VehiculoID ) )
               {
                  A1EmpID = Z1EmpID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
                  A8VehiculoID = Z8VehiculoID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(A8VehiculoID), 4, 0)));
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
                  Update0I8( ) ;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A8VehiculoID != Z8VehiculoID ) )
               {
                  /* Insert record */
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0I8( ) ;
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
                     Insert0I8( ) ;
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
         if ( ( A1EmpID != Z1EmpID ) || ( A8VehiculoID != Z8VehiculoID ) )
         {
            A1EmpID = Z1EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A8VehiculoID = Z8VehiculoID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(A8VehiculoID), 4, 0)));
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

      protected void CheckOptimisticConcurrency0I8( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000I2 */
            pr_default.execute(0, new Object[] {A1EmpID, A8VehiculoID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Vehiculos"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z66VehiculoDsc, T000I2_A66VehiculoDsc[0]) != 0 ) || ( StringUtil.StrCmp(Z67VehiculoEst, T000I2_A67VehiculoEst[0]) != 0 ) || ( StringUtil.StrCmp(Z68VehiculoPlaca, T000I2_A68VehiculoPlaca[0]) != 0 ) || ( StringUtil.StrCmp(Z69VehiculoChasis, T000I2_A69VehiculoChasis[0]) != 0 ) || ( StringUtil.StrCmp(Z70VehiculoResponsable, T000I2_A70VehiculoResponsable[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z71VehiculoCedResp, T000I2_A71VehiculoCedResp[0]) != 0 ) || ( Z6MarcaID != T000I2_A6MarcaID[0] ) || ( Z7ModeloID != T000I2_A7ModeloID[0] ) )
            {
               if ( StringUtil.StrCmp(Z66VehiculoDsc, T000I2_A66VehiculoDsc[0]) != 0 )
               {
                  GXUtil.WriteLog("vehiculos:[seudo value changed for attri]"+"VehiculoDsc");
                  GXUtil.WriteLogRaw("Old: ",Z66VehiculoDsc);
                  GXUtil.WriteLogRaw("Current: ",T000I2_A66VehiculoDsc[0]);
               }
               if ( StringUtil.StrCmp(Z67VehiculoEst, T000I2_A67VehiculoEst[0]) != 0 )
               {
                  GXUtil.WriteLog("vehiculos:[seudo value changed for attri]"+"VehiculoEst");
                  GXUtil.WriteLogRaw("Old: ",Z67VehiculoEst);
                  GXUtil.WriteLogRaw("Current: ",T000I2_A67VehiculoEst[0]);
               }
               if ( StringUtil.StrCmp(Z68VehiculoPlaca, T000I2_A68VehiculoPlaca[0]) != 0 )
               {
                  GXUtil.WriteLog("vehiculos:[seudo value changed for attri]"+"VehiculoPlaca");
                  GXUtil.WriteLogRaw("Old: ",Z68VehiculoPlaca);
                  GXUtil.WriteLogRaw("Current: ",T000I2_A68VehiculoPlaca[0]);
               }
               if ( StringUtil.StrCmp(Z69VehiculoChasis, T000I2_A69VehiculoChasis[0]) != 0 )
               {
                  GXUtil.WriteLog("vehiculos:[seudo value changed for attri]"+"VehiculoChasis");
                  GXUtil.WriteLogRaw("Old: ",Z69VehiculoChasis);
                  GXUtil.WriteLogRaw("Current: ",T000I2_A69VehiculoChasis[0]);
               }
               if ( StringUtil.StrCmp(Z70VehiculoResponsable, T000I2_A70VehiculoResponsable[0]) != 0 )
               {
                  GXUtil.WriteLog("vehiculos:[seudo value changed for attri]"+"VehiculoResponsable");
                  GXUtil.WriteLogRaw("Old: ",Z70VehiculoResponsable);
                  GXUtil.WriteLogRaw("Current: ",T000I2_A70VehiculoResponsable[0]);
               }
               if ( StringUtil.StrCmp(Z71VehiculoCedResp, T000I2_A71VehiculoCedResp[0]) != 0 )
               {
                  GXUtil.WriteLog("vehiculos:[seudo value changed for attri]"+"VehiculoCedResp");
                  GXUtil.WriteLogRaw("Old: ",Z71VehiculoCedResp);
                  GXUtil.WriteLogRaw("Current: ",T000I2_A71VehiculoCedResp[0]);
               }
               if ( Z6MarcaID != T000I2_A6MarcaID[0] )
               {
                  GXUtil.WriteLog("vehiculos:[seudo value changed for attri]"+"MarcaID");
                  GXUtil.WriteLogRaw("Old: ",Z6MarcaID);
                  GXUtil.WriteLogRaw("Current: ",T000I2_A6MarcaID[0]);
               }
               if ( Z7ModeloID != T000I2_A7ModeloID[0] )
               {
                  GXUtil.WriteLog("vehiculos:[seudo value changed for attri]"+"ModeloID");
                  GXUtil.WriteLogRaw("Old: ",Z7ModeloID);
                  GXUtil.WriteLogRaw("Current: ",T000I2_A7ModeloID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Vehiculos"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0I8( )
      {
         BeforeValidate0I8( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0I8( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0I8( 0) ;
            CheckOptimisticConcurrency0I8( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0I8( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0I8( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000I14 */
                     pr_default.execute(12, new Object[] {A8VehiculoID, n66VehiculoDsc, A66VehiculoDsc, n67VehiculoEst, A67VehiculoEst, n68VehiculoPlaca, A68VehiculoPlaca, n69VehiculoChasis, A69VehiculoChasis, n70VehiculoResponsable, A70VehiculoResponsable, n71VehiculoCedResp, A71VehiculoCedResp, A1EmpID, A6MarcaID, A7ModeloID});
                     pr_default.close(12);
                     dsDefault.SmartCacheProvider.SetUpdated("Vehiculos") ;
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
                           ResetCaption0I0( ) ;
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
               Load0I8( ) ;
            }
            EndLevel0I8( ) ;
         }
         CloseExtendedTableCursors0I8( ) ;
      }

      protected void Update0I8( )
      {
         BeforeValidate0I8( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0I8( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0I8( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0I8( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0I8( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000I15 */
                     pr_default.execute(13, new Object[] {n66VehiculoDsc, A66VehiculoDsc, n67VehiculoEst, A67VehiculoEst, n68VehiculoPlaca, A68VehiculoPlaca, n69VehiculoChasis, A69VehiculoChasis, n70VehiculoResponsable, A70VehiculoResponsable, n71VehiculoCedResp, A71VehiculoCedResp, A6MarcaID, A7ModeloID, A1EmpID, A8VehiculoID});
                     pr_default.close(13);
                     dsDefault.SmartCacheProvider.SetUpdated("Vehiculos") ;
                     if ( (pr_default.getStatus(13) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Vehiculos"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0I8( ) ;
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
            EndLevel0I8( ) ;
         }
         CloseExtendedTableCursors0I8( ) ;
      }

      protected void DeferredUpdate0I8( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0I8( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0I8( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0I8( ) ;
            AfterConfirm0I8( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0I8( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000I16 */
                  pr_default.execute(14, new Object[] {A1EmpID, A8VehiculoID});
                  pr_default.close(14);
                  dsDefault.SmartCacheProvider.SetUpdated("Vehiculos") ;
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
         sMode8 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0I8( ) ;
         Gx_mode = sMode8;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0I8( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV15Pgmname = "Vehiculos";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
            /* Using cursor T000I17 */
            pr_default.execute(15, new Object[] {A1EmpID});
            A44empdsc = T000I17_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000I17_n44empdsc[0];
            pr_default.close(15);
            /* Using cursor T000I18 */
            pr_default.execute(16, new Object[] {A1EmpID, A6MarcaID});
            A62MarcaDsc = T000I18_A62MarcaDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62MarcaDsc", A62MarcaDsc);
            n62MarcaDsc = T000I18_n62MarcaDsc[0];
            pr_default.close(16);
            /* Using cursor T000I19 */
            pr_default.execute(17, new Object[] {A1EmpID, A6MarcaID, A7ModeloID});
            A64ModeloDsc = T000I19_A64ModeloDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64ModeloDsc", A64ModeloDsc);
            n64ModeloDsc = T000I19_n64ModeloDsc[0];
            pr_default.close(17);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000I20 */
            pr_default.execute(18, new Object[] {A1EmpID, A8VehiculoID});
            if ( (pr_default.getStatus(18) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Orden Produccion"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(18);
         }
      }

      protected void EndLevel0I8( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0I8( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(15);
            pr_default.close(16);
            pr_default.close(17);
            context.CommitDataStores("vehiculos",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0I0( ) ;
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
            context.RollbackDataStores("vehiculos",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0I8( )
      {
         /* Scan By routine */
         /* Using cursor T000I21 */
         pr_default.execute(19);
         RcdFound8 = 0;
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound8 = 1;
            A1EmpID = T000I21_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A8VehiculoID = T000I21_A8VehiculoID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(A8VehiculoID), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0I8( )
      {
         /* Scan next routine */
         pr_default.readNext(19);
         RcdFound8 = 0;
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound8 = 1;
            A1EmpID = T000I21_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A8VehiculoID = T000I21_A8VehiculoID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(A8VehiculoID), 4, 0)));
         }
      }

      protected void ScanEnd0I8( )
      {
         pr_default.close(19);
      }

      protected void AfterConfirm0I8( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0I8( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0I8( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0I8( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0I8( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0I8( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0I8( )
      {
         edtEmpID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         edtempdsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempdsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempdsc_Enabled), 5, 0)), true);
         edtVehiculoID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVehiculoID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVehiculoID_Enabled), 5, 0)), true);
         edtVehiculoDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVehiculoDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVehiculoDsc_Enabled), 5, 0)), true);
         edtMarcaID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMarcaID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMarcaID_Enabled), 5, 0)), true);
         edtMarcaDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMarcaDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMarcaDsc_Enabled), 5, 0)), true);
         edtModeloID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtModeloID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtModeloID_Enabled), 5, 0)), true);
         edtModeloDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtModeloDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtModeloDsc_Enabled), 5, 0)), true);
         edtVehiculoEst_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVehiculoEst_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVehiculoEst_Enabled), 5, 0)), true);
         edtVehiculoPlaca_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVehiculoPlaca_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVehiculoPlaca_Enabled), 5, 0)), true);
         edtVehiculoChasis_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVehiculoChasis_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVehiculoChasis_Enabled), 5, 0)), true);
         edtVehiculoResponsable_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVehiculoResponsable_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVehiculoResponsable_Enabled), 5, 0)), true);
         edtVehiculoCedResp_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVehiculoCedResp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVehiculoCedResp_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0I8( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0I0( )
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
         context.SendWebValue( "Vehiculos") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20231141154552", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("vehiculos.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7EmpID) + "," + UrlEncode("" +AV8VehiculoID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "Vehiculos";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV12Insert_MarcaID), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV13Insert_ModeloID), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("vehiculos:[SendSecurityCheck value for]"+"Insert_MarcaID:"+context.localUtil.Format( (decimal)(AV12Insert_MarcaID), "ZZZ9"));
         GXUtil.WriteLog("vehiculos:[SendSecurityCheck value for]"+"Insert_ModeloID:"+context.localUtil.Format( (decimal)(AV13Insert_ModeloID), "ZZZ9"));
         GXUtil.WriteLog("vehiculos:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1EmpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z8VehiculoID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z8VehiculoID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z66VehiculoDsc", StringUtil.RTrim( Z66VehiculoDsc));
         GxWebStd.gx_hidden_field( context, "Z67VehiculoEst", StringUtil.RTrim( Z67VehiculoEst));
         GxWebStd.gx_hidden_field( context, "Z68VehiculoPlaca", Z68VehiculoPlaca);
         GxWebStd.gx_hidden_field( context, "Z69VehiculoChasis", Z69VehiculoChasis);
         GxWebStd.gx_hidden_field( context, "Z70VehiculoResponsable", StringUtil.RTrim( Z70VehiculoResponsable));
         GxWebStd.gx_hidden_field( context, "Z71VehiculoCedResp", StringUtil.RTrim( Z71VehiculoCedResp));
         GxWebStd.gx_hidden_field( context, "Z6MarcaID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z6MarcaID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z7ModeloID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z7ModeloID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N6MarcaID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A6MarcaID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "N7ModeloID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A7ModeloID), 4, 0, ",", "")));
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
         GxWebStd.gx_hidden_field( context, "vVEHICULOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8VehiculoID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vVEHICULOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8VehiculoID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_MARCAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12Insert_MarcaID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_MODELOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13Insert_ModeloID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV15Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void RenderHtmlCloseForm0I8( )
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
         return "Vehiculos" ;
      }

      public override String GetPgmdesc( )
      {
         return "Vehiculos" ;
      }

      protected void InitializeNonKey0I8( )
      {
         A6MarcaID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6MarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(A6MarcaID), 4, 0)));
         A7ModeloID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7ModeloID", StringUtil.LTrim( StringUtil.Str( (decimal)(A7ModeloID), 4, 0)));
         A44empdsc = "";
         n44empdsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         A66VehiculoDsc = "";
         n66VehiculoDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A66VehiculoDsc", A66VehiculoDsc);
         n66VehiculoDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A66VehiculoDsc)) ? true : false);
         A62MarcaDsc = "";
         n62MarcaDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62MarcaDsc", A62MarcaDsc);
         A64ModeloDsc = "";
         n64ModeloDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64ModeloDsc", A64ModeloDsc);
         A67VehiculoEst = "";
         n67VehiculoEst = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67VehiculoEst", A67VehiculoEst);
         n67VehiculoEst = (String.IsNullOrEmpty(StringUtil.RTrim( A67VehiculoEst)) ? true : false);
         A68VehiculoPlaca = "";
         n68VehiculoPlaca = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68VehiculoPlaca", A68VehiculoPlaca);
         n68VehiculoPlaca = (String.IsNullOrEmpty(StringUtil.RTrim( A68VehiculoPlaca)) ? true : false);
         A69VehiculoChasis = "";
         n69VehiculoChasis = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A69VehiculoChasis", A69VehiculoChasis);
         n69VehiculoChasis = (String.IsNullOrEmpty(StringUtil.RTrim( A69VehiculoChasis)) ? true : false);
         A70VehiculoResponsable = "";
         n70VehiculoResponsable = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A70VehiculoResponsable", A70VehiculoResponsable);
         n70VehiculoResponsable = (String.IsNullOrEmpty(StringUtil.RTrim( A70VehiculoResponsable)) ? true : false);
         A71VehiculoCedResp = "";
         n71VehiculoCedResp = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A71VehiculoCedResp", A71VehiculoCedResp);
         n71VehiculoCedResp = (String.IsNullOrEmpty(StringUtil.RTrim( A71VehiculoCedResp)) ? true : false);
         Z66VehiculoDsc = "";
         Z67VehiculoEst = "";
         Z68VehiculoPlaca = "";
         Z69VehiculoChasis = "";
         Z70VehiculoResponsable = "";
         Z71VehiculoCedResp = "";
         Z6MarcaID = 0;
         Z7ModeloID = 0;
      }

      protected void InitAll0I8( )
      {
         A1EmpID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         A8VehiculoID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(A8VehiculoID), 4, 0)));
         InitializeNonKey0I8( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20231141154568", true);
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
         context.AddJavascriptSource("vehiculos.js", "?20231141154569", false);
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
         edtVehiculoID_Internalname = "VEHICULOID";
         edtVehiculoDsc_Internalname = "VEHICULODSC";
         edtMarcaID_Internalname = "MARCAID";
         edtMarcaDsc_Internalname = "MARCADSC";
         edtModeloID_Internalname = "MODELOID";
         edtModeloDsc_Internalname = "MODELODSC";
         edtVehiculoEst_Internalname = "VEHICULOEST";
         edtVehiculoPlaca_Internalname = "VEHICULOPLACA";
         edtVehiculoChasis_Internalname = "VEHICULOCHASIS";
         edtVehiculoResponsable_Internalname = "VEHICULORESPONSABLE";
         edtVehiculoCedResp_Internalname = "VEHICULOCEDRESP";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_1_Internalname = "PROMPT_1";
         imgprompt_6_Internalname = "PROMPT_6";
         imgprompt_7_Internalname = "PROMPT_7";
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
         edtVehiculoCedResp_Jsonclick = "";
         edtVehiculoCedResp_Enabled = 1;
         edtVehiculoResponsable_Jsonclick = "";
         edtVehiculoResponsable_Enabled = 1;
         edtVehiculoChasis_Jsonclick = "";
         edtVehiculoChasis_Enabled = 1;
         edtVehiculoPlaca_Jsonclick = "";
         edtVehiculoPlaca_Enabled = 1;
         edtVehiculoEst_Jsonclick = "";
         edtVehiculoEst_Enabled = 1;
         edtModeloDsc_Jsonclick = "";
         edtModeloDsc_Enabled = 0;
         imgprompt_7_Visible = 1;
         imgprompt_7_Link = "";
         edtModeloID_Jsonclick = "";
         edtModeloID_Enabled = 1;
         edtMarcaDsc_Jsonclick = "";
         edtMarcaDsc_Enabled = 0;
         imgprompt_6_Visible = 1;
         imgprompt_6_Link = "";
         edtMarcaID_Jsonclick = "";
         edtMarcaID_Enabled = 1;
         edtVehiculoDsc_Jsonclick = "";
         edtVehiculoDsc_Enabled = 1;
         edtVehiculoID_Jsonclick = "";
         edtVehiculoID_Enabled = 1;
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

      protected void GX5ASAVEHICULOID0I8( short AV8VehiculoID ,
                                          short AV7EmpID )
      {
         if ( ! (0==AV8VehiculoID) )
         {
            A8VehiculoID = AV8VehiculoID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(A8VehiculoID), 4, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               GXt_int1 = A8VehiculoID;
               new obtultcodvehiculo(context ).execute(  AV7EmpID, out  GXt_int1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7EmpID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EmpID), "ZZZ9"), context));
               A8VehiculoID = GXt_int1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(A8VehiculoID), 4, 0)));
            }
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A8VehiculoID), 4, 0, ".", "")))+"\"");
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
         /* Using cursor T000I17 */
         pr_default.execute(15, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(15) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A44empdsc = T000I17_A44empdsc[0];
         n44empdsc = T000I17_n44empdsc[0];
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

      public void Valid_Marcaid( short GX_Parm1 ,
                                 short GX_Parm2 ,
                                 String GX_Parm3 )
      {
         A1EmpID = GX_Parm1;
         A6MarcaID = GX_Parm2;
         A62MarcaDsc = GX_Parm3;
         n62MarcaDsc = false;
         /* Using cursor T000I18 */
         pr_default.execute(16, new Object[] {A1EmpID, A6MarcaID});
         if ( (pr_default.getStatus(16) == 101) )
         {
            GX_msglist.addItem("No existe 'Marca'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A62MarcaDsc = T000I18_A62MarcaDsc[0];
         n62MarcaDsc = T000I18_n62MarcaDsc[0];
         pr_default.close(16);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A62MarcaDsc = "";
            n62MarcaDsc = false;
         }
         isValidOutput.Add(StringUtil.RTrim( A62MarcaDsc));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Modeloid( short GX_Parm1 ,
                                  short GX_Parm2 ,
                                  short GX_Parm3 ,
                                  String GX_Parm4 )
      {
         A1EmpID = GX_Parm1;
         A6MarcaID = GX_Parm2;
         A7ModeloID = GX_Parm3;
         A64ModeloDsc = GX_Parm4;
         n64ModeloDsc = false;
         /* Using cursor T000I19 */
         pr_default.execute(17, new Object[] {A1EmpID, A6MarcaID, A7ModeloID});
         if ( (pr_default.getStatus(17) == 101) )
         {
            GX_msglist.addItem("No existe 'Modelo'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A64ModeloDsc = T000I19_A64ModeloDsc[0];
         n64ModeloDsc = T000I19_n64ModeloDsc[0];
         pr_default.close(17);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A64ModeloDsc = "";
            n64ModeloDsc = false;
         }
         isValidOutput.Add(StringUtil.RTrim( A64ModeloDsc));
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV8VehiculoID',fld:'vVEHICULOID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV8VehiculoID',fld:'vVEHICULOID',pic:'ZZZ9',hsh:true},{av:'AV12Insert_MarcaID',fld:'vINSERT_MARCAID',pic:'ZZZ9'},{av:'AV13Insert_ModeloID',fld:'vINSERT_MODELOID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120I2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV10TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         Z66VehiculoDsc = "";
         Z67VehiculoEst = "";
         Z68VehiculoPlaca = "";
         Z69VehiculoChasis = "";
         Z70VehiculoResponsable = "";
         Z71VehiculoCedResp = "";
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
         A66VehiculoDsc = "";
         A62MarcaDsc = "";
         A64ModeloDsc = "";
         A67VehiculoEst = "";
         A68VehiculoPlaca = "";
         A69VehiculoChasis = "";
         A70VehiculoResponsable = "";
         A71VehiculoCedResp = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         AV15Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode8 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV10TrnContext = new SdtTransactionContext(context);
         AV11WebSession = context.GetSession();
         AV14TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z44empdsc = "";
         Z62MarcaDsc = "";
         Z64ModeloDsc = "";
         T000I4_A44empdsc = new String[] {""} ;
         T000I4_n44empdsc = new bool[] {false} ;
         T000I5_A62MarcaDsc = new String[] {""} ;
         T000I5_n62MarcaDsc = new bool[] {false} ;
         T000I6_A64ModeloDsc = new String[] {""} ;
         T000I6_n64ModeloDsc = new bool[] {false} ;
         T000I7_A8VehiculoID = new short[1] ;
         T000I7_A44empdsc = new String[] {""} ;
         T000I7_n44empdsc = new bool[] {false} ;
         T000I7_A66VehiculoDsc = new String[] {""} ;
         T000I7_n66VehiculoDsc = new bool[] {false} ;
         T000I7_A62MarcaDsc = new String[] {""} ;
         T000I7_n62MarcaDsc = new bool[] {false} ;
         T000I7_A64ModeloDsc = new String[] {""} ;
         T000I7_n64ModeloDsc = new bool[] {false} ;
         T000I7_A67VehiculoEst = new String[] {""} ;
         T000I7_n67VehiculoEst = new bool[] {false} ;
         T000I7_A68VehiculoPlaca = new String[] {""} ;
         T000I7_n68VehiculoPlaca = new bool[] {false} ;
         T000I7_A69VehiculoChasis = new String[] {""} ;
         T000I7_n69VehiculoChasis = new bool[] {false} ;
         T000I7_A70VehiculoResponsable = new String[] {""} ;
         T000I7_n70VehiculoResponsable = new bool[] {false} ;
         T000I7_A71VehiculoCedResp = new String[] {""} ;
         T000I7_n71VehiculoCedResp = new bool[] {false} ;
         T000I7_A1EmpID = new short[1] ;
         T000I7_A6MarcaID = new short[1] ;
         T000I7_A7ModeloID = new short[1] ;
         T000I8_A44empdsc = new String[] {""} ;
         T000I8_n44empdsc = new bool[] {false} ;
         T000I9_A62MarcaDsc = new String[] {""} ;
         T000I9_n62MarcaDsc = new bool[] {false} ;
         T000I10_A64ModeloDsc = new String[] {""} ;
         T000I10_n64ModeloDsc = new bool[] {false} ;
         T000I11_A1EmpID = new short[1] ;
         T000I11_A8VehiculoID = new short[1] ;
         T000I3_A8VehiculoID = new short[1] ;
         T000I3_A66VehiculoDsc = new String[] {""} ;
         T000I3_n66VehiculoDsc = new bool[] {false} ;
         T000I3_A67VehiculoEst = new String[] {""} ;
         T000I3_n67VehiculoEst = new bool[] {false} ;
         T000I3_A68VehiculoPlaca = new String[] {""} ;
         T000I3_n68VehiculoPlaca = new bool[] {false} ;
         T000I3_A69VehiculoChasis = new String[] {""} ;
         T000I3_n69VehiculoChasis = new bool[] {false} ;
         T000I3_A70VehiculoResponsable = new String[] {""} ;
         T000I3_n70VehiculoResponsable = new bool[] {false} ;
         T000I3_A71VehiculoCedResp = new String[] {""} ;
         T000I3_n71VehiculoCedResp = new bool[] {false} ;
         T000I3_A1EmpID = new short[1] ;
         T000I3_A6MarcaID = new short[1] ;
         T000I3_A7ModeloID = new short[1] ;
         T000I12_A1EmpID = new short[1] ;
         T000I12_A8VehiculoID = new short[1] ;
         T000I13_A1EmpID = new short[1] ;
         T000I13_A8VehiculoID = new short[1] ;
         T000I2_A8VehiculoID = new short[1] ;
         T000I2_A66VehiculoDsc = new String[] {""} ;
         T000I2_n66VehiculoDsc = new bool[] {false} ;
         T000I2_A67VehiculoEst = new String[] {""} ;
         T000I2_n67VehiculoEst = new bool[] {false} ;
         T000I2_A68VehiculoPlaca = new String[] {""} ;
         T000I2_n68VehiculoPlaca = new bool[] {false} ;
         T000I2_A69VehiculoChasis = new String[] {""} ;
         T000I2_n69VehiculoChasis = new bool[] {false} ;
         T000I2_A70VehiculoResponsable = new String[] {""} ;
         T000I2_n70VehiculoResponsable = new bool[] {false} ;
         T000I2_A71VehiculoCedResp = new String[] {""} ;
         T000I2_n71VehiculoCedResp = new bool[] {false} ;
         T000I2_A1EmpID = new short[1] ;
         T000I2_A6MarcaID = new short[1] ;
         T000I2_A7ModeloID = new short[1] ;
         T000I17_A44empdsc = new String[] {""} ;
         T000I17_n44empdsc = new bool[] {false} ;
         T000I18_A62MarcaDsc = new String[] {""} ;
         T000I18_n62MarcaDsc = new bool[] {false} ;
         T000I19_A64ModeloDsc = new String[] {""} ;
         T000I19_n64ModeloDsc = new bool[] {false} ;
         T000I20_A1EmpID = new short[1] ;
         T000I20_A5ClienteID = new short[1] ;
         T000I20_A24OrdenPeriodo = new short[1] ;
         T000I20_A25OrdenAnio = new short[1] ;
         T000I20_A22OrdenID = new short[1] ;
         T000I21_A1EmpID = new short[1] ;
         T000I21_A8VehiculoID = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.vehiculos__default(),
            new Object[][] {
                new Object[] {
               T000I2_A8VehiculoID, T000I2_A66VehiculoDsc, T000I2_n66VehiculoDsc, T000I2_A67VehiculoEst, T000I2_n67VehiculoEst, T000I2_A68VehiculoPlaca, T000I2_n68VehiculoPlaca, T000I2_A69VehiculoChasis, T000I2_n69VehiculoChasis, T000I2_A70VehiculoResponsable,
               T000I2_n70VehiculoResponsable, T000I2_A71VehiculoCedResp, T000I2_n71VehiculoCedResp, T000I2_A1EmpID, T000I2_A6MarcaID, T000I2_A7ModeloID
               }
               , new Object[] {
               T000I3_A8VehiculoID, T000I3_A66VehiculoDsc, T000I3_n66VehiculoDsc, T000I3_A67VehiculoEst, T000I3_n67VehiculoEst, T000I3_A68VehiculoPlaca, T000I3_n68VehiculoPlaca, T000I3_A69VehiculoChasis, T000I3_n69VehiculoChasis, T000I3_A70VehiculoResponsable,
               T000I3_n70VehiculoResponsable, T000I3_A71VehiculoCedResp, T000I3_n71VehiculoCedResp, T000I3_A1EmpID, T000I3_A6MarcaID, T000I3_A7ModeloID
               }
               , new Object[] {
               T000I4_A44empdsc, T000I4_n44empdsc
               }
               , new Object[] {
               T000I5_A62MarcaDsc, T000I5_n62MarcaDsc
               }
               , new Object[] {
               T000I6_A64ModeloDsc, T000I6_n64ModeloDsc
               }
               , new Object[] {
               T000I7_A8VehiculoID, T000I7_A44empdsc, T000I7_n44empdsc, T000I7_A66VehiculoDsc, T000I7_n66VehiculoDsc, T000I7_A62MarcaDsc, T000I7_n62MarcaDsc, T000I7_A64ModeloDsc, T000I7_n64ModeloDsc, T000I7_A67VehiculoEst,
               T000I7_n67VehiculoEst, T000I7_A68VehiculoPlaca, T000I7_n68VehiculoPlaca, T000I7_A69VehiculoChasis, T000I7_n69VehiculoChasis, T000I7_A70VehiculoResponsable, T000I7_n70VehiculoResponsable, T000I7_A71VehiculoCedResp, T000I7_n71VehiculoCedResp, T000I7_A1EmpID,
               T000I7_A6MarcaID, T000I7_A7ModeloID
               }
               , new Object[] {
               T000I8_A44empdsc, T000I8_n44empdsc
               }
               , new Object[] {
               T000I9_A62MarcaDsc, T000I9_n62MarcaDsc
               }
               , new Object[] {
               T000I10_A64ModeloDsc, T000I10_n64ModeloDsc
               }
               , new Object[] {
               T000I11_A1EmpID, T000I11_A8VehiculoID
               }
               , new Object[] {
               T000I12_A1EmpID, T000I12_A8VehiculoID
               }
               , new Object[] {
               T000I13_A1EmpID, T000I13_A8VehiculoID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000I17_A44empdsc, T000I17_n44empdsc
               }
               , new Object[] {
               T000I18_A62MarcaDsc, T000I18_n62MarcaDsc
               }
               , new Object[] {
               T000I19_A64ModeloDsc, T000I19_n64ModeloDsc
               }
               , new Object[] {
               T000I20_A1EmpID, T000I20_A5ClienteID, T000I20_A24OrdenPeriodo, T000I20_A25OrdenAnio, T000I20_A22OrdenID
               }
               , new Object[] {
               T000I21_A1EmpID, T000I21_A8VehiculoID
               }
            }
         );
         AV15Pgmname = "Vehiculos";
      }

      private short wcpOAV7EmpID ;
      private short wcpOAV8VehiculoID ;
      private short Z1EmpID ;
      private short Z8VehiculoID ;
      private short Z6MarcaID ;
      private short Z7ModeloID ;
      private short N6MarcaID ;
      private short N7ModeloID ;
      private short GxWebError ;
      private short AV8VehiculoID ;
      private short AV7EmpID ;
      private short A1EmpID ;
      private short A6MarcaID ;
      private short A7ModeloID ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short A8VehiculoID ;
      private short AV12Insert_MarcaID ;
      private short AV13Insert_ModeloID ;
      private short RcdFound8 ;
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
      private int edtVehiculoID_Enabled ;
      private int edtVehiculoDsc_Enabled ;
      private int edtMarcaID_Enabled ;
      private int imgprompt_6_Visible ;
      private int edtMarcaDsc_Enabled ;
      private int edtModeloID_Enabled ;
      private int imgprompt_7_Visible ;
      private int edtModeloDsc_Enabled ;
      private int edtVehiculoEst_Enabled ;
      private int edtVehiculoPlaca_Enabled ;
      private int edtVehiculoChasis_Enabled ;
      private int edtVehiculoResponsable_Enabled ;
      private int edtVehiculoCedResp_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int AV16GXV1 ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z66VehiculoDsc ;
      private String Z67VehiculoEst ;
      private String Z70VehiculoResponsable ;
      private String Z71VehiculoCedResp ;
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
      private String edtVehiculoID_Internalname ;
      private String edtVehiculoID_Jsonclick ;
      private String edtVehiculoDsc_Internalname ;
      private String A66VehiculoDsc ;
      private String edtVehiculoDsc_Jsonclick ;
      private String edtMarcaID_Internalname ;
      private String edtMarcaID_Jsonclick ;
      private String imgprompt_6_Internalname ;
      private String imgprompt_6_Link ;
      private String edtMarcaDsc_Internalname ;
      private String A62MarcaDsc ;
      private String edtMarcaDsc_Jsonclick ;
      private String edtModeloID_Internalname ;
      private String edtModeloID_Jsonclick ;
      private String imgprompt_7_Internalname ;
      private String imgprompt_7_Link ;
      private String edtModeloDsc_Internalname ;
      private String A64ModeloDsc ;
      private String edtModeloDsc_Jsonclick ;
      private String edtVehiculoEst_Internalname ;
      private String A67VehiculoEst ;
      private String edtVehiculoEst_Jsonclick ;
      private String edtVehiculoPlaca_Internalname ;
      private String edtVehiculoPlaca_Jsonclick ;
      private String edtVehiculoChasis_Internalname ;
      private String edtVehiculoChasis_Jsonclick ;
      private String edtVehiculoResponsable_Internalname ;
      private String A70VehiculoResponsable ;
      private String edtVehiculoResponsable_Jsonclick ;
      private String edtVehiculoCedResp_Internalname ;
      private String A71VehiculoCedResp ;
      private String edtVehiculoCedResp_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String AV15Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode8 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z62MarcaDsc ;
      private String Z64ModeloDsc ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n44empdsc ;
      private bool n66VehiculoDsc ;
      private bool n62MarcaDsc ;
      private bool n64ModeloDsc ;
      private bool n67VehiculoEst ;
      private bool n68VehiculoPlaca ;
      private bool n69VehiculoChasis ;
      private bool n70VehiculoResponsable ;
      private bool n71VehiculoCedResp ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private String Z68VehiculoPlaca ;
      private String Z69VehiculoChasis ;
      private String A44empdsc ;
      private String A68VehiculoPlaca ;
      private String A69VehiculoChasis ;
      private String Z44empdsc ;
      private IGxSession AV11WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T000I4_A44empdsc ;
      private bool[] T000I4_n44empdsc ;
      private String[] T000I5_A62MarcaDsc ;
      private bool[] T000I5_n62MarcaDsc ;
      private String[] T000I6_A64ModeloDsc ;
      private bool[] T000I6_n64ModeloDsc ;
      private short[] T000I7_A8VehiculoID ;
      private String[] T000I7_A44empdsc ;
      private bool[] T000I7_n44empdsc ;
      private String[] T000I7_A66VehiculoDsc ;
      private bool[] T000I7_n66VehiculoDsc ;
      private String[] T000I7_A62MarcaDsc ;
      private bool[] T000I7_n62MarcaDsc ;
      private String[] T000I7_A64ModeloDsc ;
      private bool[] T000I7_n64ModeloDsc ;
      private String[] T000I7_A67VehiculoEst ;
      private bool[] T000I7_n67VehiculoEst ;
      private String[] T000I7_A68VehiculoPlaca ;
      private bool[] T000I7_n68VehiculoPlaca ;
      private String[] T000I7_A69VehiculoChasis ;
      private bool[] T000I7_n69VehiculoChasis ;
      private String[] T000I7_A70VehiculoResponsable ;
      private bool[] T000I7_n70VehiculoResponsable ;
      private String[] T000I7_A71VehiculoCedResp ;
      private bool[] T000I7_n71VehiculoCedResp ;
      private short[] T000I7_A1EmpID ;
      private short[] T000I7_A6MarcaID ;
      private short[] T000I7_A7ModeloID ;
      private String[] T000I8_A44empdsc ;
      private bool[] T000I8_n44empdsc ;
      private String[] T000I9_A62MarcaDsc ;
      private bool[] T000I9_n62MarcaDsc ;
      private String[] T000I10_A64ModeloDsc ;
      private bool[] T000I10_n64ModeloDsc ;
      private short[] T000I11_A1EmpID ;
      private short[] T000I11_A8VehiculoID ;
      private short[] T000I3_A8VehiculoID ;
      private String[] T000I3_A66VehiculoDsc ;
      private bool[] T000I3_n66VehiculoDsc ;
      private String[] T000I3_A67VehiculoEst ;
      private bool[] T000I3_n67VehiculoEst ;
      private String[] T000I3_A68VehiculoPlaca ;
      private bool[] T000I3_n68VehiculoPlaca ;
      private String[] T000I3_A69VehiculoChasis ;
      private bool[] T000I3_n69VehiculoChasis ;
      private String[] T000I3_A70VehiculoResponsable ;
      private bool[] T000I3_n70VehiculoResponsable ;
      private String[] T000I3_A71VehiculoCedResp ;
      private bool[] T000I3_n71VehiculoCedResp ;
      private short[] T000I3_A1EmpID ;
      private short[] T000I3_A6MarcaID ;
      private short[] T000I3_A7ModeloID ;
      private short[] T000I12_A1EmpID ;
      private short[] T000I12_A8VehiculoID ;
      private short[] T000I13_A1EmpID ;
      private short[] T000I13_A8VehiculoID ;
      private short[] T000I2_A8VehiculoID ;
      private String[] T000I2_A66VehiculoDsc ;
      private bool[] T000I2_n66VehiculoDsc ;
      private String[] T000I2_A67VehiculoEst ;
      private bool[] T000I2_n67VehiculoEst ;
      private String[] T000I2_A68VehiculoPlaca ;
      private bool[] T000I2_n68VehiculoPlaca ;
      private String[] T000I2_A69VehiculoChasis ;
      private bool[] T000I2_n69VehiculoChasis ;
      private String[] T000I2_A70VehiculoResponsable ;
      private bool[] T000I2_n70VehiculoResponsable ;
      private String[] T000I2_A71VehiculoCedResp ;
      private bool[] T000I2_n71VehiculoCedResp ;
      private short[] T000I2_A1EmpID ;
      private short[] T000I2_A6MarcaID ;
      private short[] T000I2_A7ModeloID ;
      private String[] T000I17_A44empdsc ;
      private bool[] T000I17_n44empdsc ;
      private String[] T000I18_A62MarcaDsc ;
      private bool[] T000I18_n62MarcaDsc ;
      private String[] T000I19_A64ModeloDsc ;
      private bool[] T000I19_n64ModeloDsc ;
      private short[] T000I20_A1EmpID ;
      private short[] T000I20_A5ClienteID ;
      private short[] T000I20_A24OrdenPeriodo ;
      private short[] T000I20_A25OrdenAnio ;
      private short[] T000I20_A22OrdenID ;
      private short[] T000I21_A1EmpID ;
      private short[] T000I21_A8VehiculoID ;
      private SdtTransactionContext AV10TrnContext ;
      private SdtTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class vehiculos__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000I7 ;
          prmT000I7 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@VehiculoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000I4 ;
          prmT000I4 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000I5 ;
          prmT000I5 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000I6 ;
          prmT000I6 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ModeloID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000I8 ;
          prmT000I8 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000I9 ;
          prmT000I9 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000I10 ;
          prmT000I10 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ModeloID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000I11 ;
          prmT000I11 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@VehiculoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000I3 ;
          prmT000I3 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@VehiculoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000I12 ;
          prmT000I12 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@VehiculoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000I13 ;
          prmT000I13 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@VehiculoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000I2 ;
          prmT000I2 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@VehiculoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000I14 ;
          prmT000I14 = new Object[] {
          new Object[] {"@VehiculoID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@VehiculoDsc",SqlDbType.Char,50,0} ,
          new Object[] {"@VehiculoEst",SqlDbType.Char,1,0} ,
          new Object[] {"@VehiculoPlaca",SqlDbType.VarChar,15,0} ,
          new Object[] {"@VehiculoChasis",SqlDbType.VarChar,40,0} ,
          new Object[] {"@VehiculoResponsable",SqlDbType.Char,50,0} ,
          new Object[] {"@VehiculoCedResp",SqlDbType.Char,13,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ModeloID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000I15 ;
          prmT000I15 = new Object[] {
          new Object[] {"@VehiculoDsc",SqlDbType.Char,50,0} ,
          new Object[] {"@VehiculoEst",SqlDbType.Char,1,0} ,
          new Object[] {"@VehiculoPlaca",SqlDbType.VarChar,15,0} ,
          new Object[] {"@VehiculoChasis",SqlDbType.VarChar,40,0} ,
          new Object[] {"@VehiculoResponsable",SqlDbType.Char,50,0} ,
          new Object[] {"@VehiculoCedResp",SqlDbType.Char,13,0} ,
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ModeloID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@VehiculoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000I16 ;
          prmT000I16 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@VehiculoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000I20 ;
          prmT000I20 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@VehiculoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000I21 ;
          prmT000I21 = new Object[] {
          } ;
          Object[] prmT000I17 ;
          prmT000I17 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000I18 ;
          prmT000I18 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000I19 ;
          prmT000I19 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ModeloID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000I2", "SELECT [VehiculoID], [VehiculoDsc], [VehiculoEst], [VehiculoPlaca], [VehiculoChasis], [VehiculoResponsable], [VehiculoCedResp], [EmpID], [MarcaID], [ModeloID] FROM [Vehiculos] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [VehiculoID] = @VehiculoID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I2,1,0,true,false )
             ,new CursorDef("T000I3", "SELECT [VehiculoID], [VehiculoDsc], [VehiculoEst], [VehiculoPlaca], [VehiculoChasis], [VehiculoResponsable], [VehiculoCedResp], [EmpID], [MarcaID], [ModeloID] FROM [Vehiculos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [VehiculoID] = @VehiculoID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I3,1,0,true,false )
             ,new CursorDef("T000I4", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I4,1,0,true,false )
             ,new CursorDef("T000I5", "SELECT [MarcaDsc] FROM [Marca] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [MarcaID] = @MarcaID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I5,1,0,true,false )
             ,new CursorDef("T000I6", "SELECT [ModeloDsc] FROM [MarcaModelo] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [MarcaID] = @MarcaID AND [ModeloID] = @ModeloID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I6,1,0,true,false )
             ,new CursorDef("T000I7", "SELECT TM1.[VehiculoID], T2.[empdsc], TM1.[VehiculoDsc], T3.[MarcaDsc], T4.[ModeloDsc], TM1.[VehiculoEst], TM1.[VehiculoPlaca], TM1.[VehiculoChasis], TM1.[VehiculoResponsable], TM1.[VehiculoCedResp], TM1.[EmpID], TM1.[MarcaID], TM1.[ModeloID] FROM ((([Vehiculos] TM1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = TM1.[EmpID]) INNER JOIN [Marca] T3 WITH (NOLOCK) ON T3.[EmpID] = TM1.[EmpID] AND T3.[MarcaID] = TM1.[MarcaID]) INNER JOIN [MarcaModelo] T4 WITH (NOLOCK) ON T4.[EmpID] = TM1.[EmpID] AND T4.[MarcaID] = TM1.[MarcaID] AND T4.[ModeloID] = TM1.[ModeloID]) WHERE TM1.[EmpID] = @EmpID and TM1.[VehiculoID] = @VehiculoID ORDER BY TM1.[EmpID], TM1.[VehiculoID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000I7,100,0,true,false )
             ,new CursorDef("T000I8", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I8,1,0,true,false )
             ,new CursorDef("T000I9", "SELECT [MarcaDsc] FROM [Marca] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [MarcaID] = @MarcaID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I9,1,0,true,false )
             ,new CursorDef("T000I10", "SELECT [ModeloDsc] FROM [MarcaModelo] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [MarcaID] = @MarcaID AND [ModeloID] = @ModeloID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I10,1,0,true,false )
             ,new CursorDef("T000I11", "SELECT [EmpID], [VehiculoID] FROM [Vehiculos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [VehiculoID] = @VehiculoID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000I11,1,0,true,false )
             ,new CursorDef("T000I12", "SELECT TOP 1 [EmpID], [VehiculoID] FROM [Vehiculos] WITH (NOLOCK) WHERE ( [EmpID] > @EmpID or [EmpID] = @EmpID and [VehiculoID] > @VehiculoID) ORDER BY [EmpID], [VehiculoID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000I12,1,0,true,true )
             ,new CursorDef("T000I13", "SELECT TOP 1 [EmpID], [VehiculoID] FROM [Vehiculos] WITH (NOLOCK) WHERE ( [EmpID] < @EmpID or [EmpID] = @EmpID and [VehiculoID] < @VehiculoID) ORDER BY [EmpID] DESC, [VehiculoID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000I13,1,0,true,true )
             ,new CursorDef("T000I14", "INSERT INTO [Vehiculos]([VehiculoID], [VehiculoDsc], [VehiculoEst], [VehiculoPlaca], [VehiculoChasis], [VehiculoResponsable], [VehiculoCedResp], [EmpID], [MarcaID], [ModeloID]) VALUES(@VehiculoID, @VehiculoDsc, @VehiculoEst, @VehiculoPlaca, @VehiculoChasis, @VehiculoResponsable, @VehiculoCedResp, @EmpID, @MarcaID, @ModeloID)", GxErrorMask.GX_NOMASK,prmT000I14)
             ,new CursorDef("T000I15", "UPDATE [Vehiculos] SET [VehiculoDsc]=@VehiculoDsc, [VehiculoEst]=@VehiculoEst, [VehiculoPlaca]=@VehiculoPlaca, [VehiculoChasis]=@VehiculoChasis, [VehiculoResponsable]=@VehiculoResponsable, [VehiculoCedResp]=@VehiculoCedResp, [MarcaID]=@MarcaID, [ModeloID]=@ModeloID  WHERE [EmpID] = @EmpID AND [VehiculoID] = @VehiculoID", GxErrorMask.GX_NOMASK,prmT000I15)
             ,new CursorDef("T000I16", "DELETE FROM [Vehiculos]  WHERE [EmpID] = @EmpID AND [VehiculoID] = @VehiculoID", GxErrorMask.GX_NOMASK,prmT000I16)
             ,new CursorDef("T000I17", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I17,1,0,true,false )
             ,new CursorDef("T000I18", "SELECT [MarcaDsc] FROM [Marca] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [MarcaID] = @MarcaID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I18,1,0,true,false )
             ,new CursorDef("T000I19", "SELECT [ModeloDsc] FROM [MarcaModelo] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [MarcaID] = @MarcaID AND [ModeloID] = @ModeloID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I19,1,0,true,false )
             ,new CursorDef("T000I20", "SELECT TOP 1 [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID] FROM [OrdenProduccion] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [VehiculoID] = @VehiculoID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I20,1,0,true,true )
             ,new CursorDef("T000I21", "SELECT [EmpID], [VehiculoID] FROM [Vehiculos] WITH (NOLOCK) ORDER BY [EmpID], [VehiculoID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000I21,100,0,true,false )
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
                ((String[]) buf[3])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getString(6, 50) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getString(7, 13) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((short[]) buf[13])[0] = rslt.getShort(8) ;
                ((short[]) buf[14])[0] = rslt.getShort(9) ;
                ((short[]) buf[15])[0] = rslt.getShort(10) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getString(6, 50) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getString(7, 13) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((short[]) buf[13])[0] = rslt.getShort(8) ;
                ((short[]) buf[14])[0] = rslt.getShort(9) ;
                ((short[]) buf[15])[0] = rslt.getShort(10) ;
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
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 50) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 50) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getString(6, 1) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getString(9, 50) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((String[]) buf[17])[0] = rslt.getString(10, 13) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((short[]) buf[19])[0] = rslt.getShort(11) ;
                ((short[]) buf[20])[0] = rslt.getShort(12) ;
                ((short[]) buf[21])[0] = rslt.getShort(13) ;
                return;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
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
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 18 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 19 :
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
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
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
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
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
                   stmt.setNull( 5 , SqlDbType.VarChar );
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
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 7 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[12]);
                }
                stmt.SetParameter(8, (short)parms[13]);
                stmt.SetParameter(9, (short)parms[14]);
                stmt.SetParameter(10, (short)parms[15]);
                return;
             case 13 :
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
                   stmt.setNull( 4 , SqlDbType.VarChar );
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
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 6 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[11]);
                }
                stmt.SetParameter(7, (short)parms[12]);
                stmt.SetParameter(8, (short)parms[13]);
                stmt.SetParameter(9, (short)parms[14]);
                stmt.SetParameter(10, (short)parms[15]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
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
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 18 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
       }
    }

 }

}
