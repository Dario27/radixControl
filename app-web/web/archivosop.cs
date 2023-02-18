/*
               File: ArchivosOP
        Description: Archivos OP
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/11/2023 0:42:31.36
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
   public class archivosop : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"ORDENID") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            AV13UserCod = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLAORDENID0A22( A1EmpID, AV13UserCod) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"ARCHCLIENTEID") == 0 )
         {
            AV14empID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLAARCHCLIENTEID0A22( AV14empID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_20") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_20( A1EmpID) ;
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
               AV8ArchSec = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ArchSec", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8ArchSec), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vARCHSEC", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8ArchSec), "ZZZ9"), context));
               AV10OrdenID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrdenID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vORDENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10OrdenID), "ZZZ9"), context));
               AV7ArchClienteID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ArchClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ArchClienteID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vARCHCLIENTEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7ArchClienteID), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Archivos OP", 0) ;
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

      public archivosop( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public archivosop( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_ArchSec ,
                           short aP2_OrdenID ,
                           short aP3_ArchClienteID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV8ArchSec = aP1_ArchSec;
         this.AV10OrdenID = aP2_OrdenID;
         this.AV7ArchClienteID = aP3_ArchClienteID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynOrdenID = new GXCombobox();
         dynArchClienteID = new GXCombobox();
         dynArchUser = new GXCombobox();
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
         if ( dynOrdenID.ItemCount > 0 )
         {
            A22OrdenID = (short)(NumberUtil.Val( dynOrdenID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            dynOrdenID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynOrdenID_Internalname, "Values", dynOrdenID.ToJavascriptSource(), true);
         }
         if ( dynArchClienteID.ItemCount > 0 )
         {
            A28ArchClienteID = (short)(NumberUtil.Val( dynArchClienteID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A28ArchClienteID), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28ArchClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A28ArchClienteID), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            dynArchClienteID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A28ArchClienteID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynArchClienteID_Internalname, "Values", dynArchClienteID.ToJavascriptSource(), true);
         }
         if ( dynArchUser.ItemCount > 0 )
         {
            A135ArchUser = dynArchUser.getValidValue(A135ArchUser);
            n135ArchUser = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A135ArchUser", A135ArchUser);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynArchUser.CurrentValue = StringUtil.RTrim( A135ArchUser);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynArchUser_Internalname, "Values", dynArchUser.ToJavascriptSource(), true);
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Archivos OP", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_ArchivosOP.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_ArchivosOP.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_ArchivosOP.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_ArchivosOP.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_ArchivosOP.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 5, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_ArchivosOP.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 col-lg-4", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEmpID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEmpID_Internalname, "Empresa", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtEmpID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEmpID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEmpID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_ArchivosOP.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_1_Internalname, sImgUrl, imgprompt_1_Link, "", "", context.GetTheme( ), imgprompt_1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_ArchivosOP.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 col-lg-4", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtempdsc_Internalname, "Empresa", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtempdsc_Internalname, A44empdsc, StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempdsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtempdsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_ArchivosOP.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellAdvanced", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtArchSec_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtArchSec_Internalname, "Sec", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtArchSec_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A27ArchSec), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A27ArchSec), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,42);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtArchSec_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtArchSec_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_ArchivosOP.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynOrdenID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynOrdenID_Internalname, "Nro. Orden", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynOrdenID, dynOrdenID_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)), 1, dynOrdenID_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dynOrdenID.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", "", true, "HLP_ArchivosOP.htm");
            dynOrdenID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynOrdenID_Internalname, "Values", (String)(dynOrdenID.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynArchClienteID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynArchClienteID_Internalname, "Cliente ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynArchClienteID, dynArchClienteID_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A28ArchClienteID), 4, 0)), 1, dynArchClienteID_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dynArchClienteID.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", "", true, "HLP_ArchivosOP.htm");
            dynArchClienteID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A28ArchClienteID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynArchClienteID_Internalname, "Values", (String)(dynArchClienteID.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtArchUrl_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtArchUrl_Internalname, "Archivo PDF", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            ClassString = "Attribute";
            StyleString = "";
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'',0)\"";
            edtArchUrl_Filetype = "pdf";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArchUrl_Internalname, "Filetype", edtArchUrl_Filetype, true);
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A134ArchUrl)) )
            {
               gxblobfileaux.Source = A134ArchUrl;
               if ( ! gxblobfileaux.HasExtension() || ( StringUtil.StrCmp(edtArchUrl_Filetype, "tmp") != 0 ) )
               {
                  gxblobfileaux.SetExtension(StringUtil.Trim( edtArchUrl_Filetype));
               }
               if ( gxblobfileaux.ErrCode == 0 )
               {
                  A134ArchUrl = gxblobfileaux.GetURI();
                  n134ArchUrl = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A134ArchUrl", A134ArchUrl);
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArchUrl_Internalname, "URL", context.PathToRelativeUrl( A134ArchUrl), true);
                  edtArchUrl_Filetype = gxblobfileaux.GetExtension();
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArchUrl_Internalname, "Filetype", edtArchUrl_Filetype, true);
               }
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArchUrl_Internalname, "URL", context.PathToRelativeUrl( A134ArchUrl), true);
            }
            GxWebStd.gx_blob_field( context, edtArchUrl_Internalname, StringUtil.RTrim( A134ArchUrl), context.PathToRelativeUrl( A134ArchUrl), (String.IsNullOrEmpty(StringUtil.RTrim( edtArchUrl_Contenttype)) ? context.GetContentType( (String.IsNullOrEmpty(StringUtil.RTrim( edtArchUrl_Filetype)) ? A134ArchUrl : edtArchUrl_Filetype)) : edtArchUrl_Contenttype), false, "", edtArchUrl_Parameters, 1, edtArchUrl_Enabled, 1, "", "", 0, -1, 250, "px", 60, "px", 0, 0, 0, edtArchUrl_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", StyleString, ClassString, "", "", ""+TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", "", "", "HLP_ArchivosOP.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynArchUser_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynArchUser_Internalname, "Vendedor", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynArchUser, dynArchUser_Internalname, StringUtil.RTrim( A135ArchUser), 1, dynArchUser_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, dynArchUser.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,62);\"", "", true, "HLP_ArchivosOP.htm");
            dynArchUser.CurrentValue = StringUtil.RTrim( A135ArchUser);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynArchUser_Internalname, "Values", (String)(dynArchUser.ToJavascriptSource()), true);
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
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtavEmpid_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavEmpid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavEmpid_Internalname, "Emp ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavEmpid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14empID), 4, 0, ",", "")), ((edtavEmpid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV14empID), "ZZZ9")) : context.localUtil.Format( (decimal)(AV14empID), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavEmpid_Jsonclick, 0, "Attribute", "", "", "", "", edtavEmpid_Visible, edtavEmpid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ArchivosOP.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_ArchivosOP.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_ArchivosOP.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_ArchivosOP.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm0A22( ) ;
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
         E110A2 ();
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtArchSec_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtArchSec_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ARCHSEC");
                  AnyError = 1;
                  GX_FocusControl = edtArchSec_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A27ArchSec = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ArchSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ArchSec), 4, 0)));
               }
               else
               {
                  A27ArchSec = (short)(context.localUtil.CToN( cgiGet( edtArchSec_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ArchSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ArchSec), 4, 0)));
               }
               dynOrdenID.CurrentValue = cgiGet( dynOrdenID_Internalname);
               A22OrdenID = (short)(NumberUtil.Val( cgiGet( dynOrdenID_Internalname), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
               dynArchClienteID.CurrentValue = cgiGet( dynArchClienteID_Internalname);
               A28ArchClienteID = (short)(NumberUtil.Val( cgiGet( dynArchClienteID_Internalname), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28ArchClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A28ArchClienteID), 4, 0)));
               A134ArchUrl = cgiGet( edtArchUrl_Internalname);
               n134ArchUrl = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A134ArchUrl", A134ArchUrl);
               n134ArchUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A134ArchUrl)) ? true : false);
               dynArchUser.CurrentValue = cgiGet( dynArchUser_Internalname);
               A135ArchUser = cgiGet( dynArchUser_Internalname);
               n135ArchUser = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A135ArchUser", A135ArchUser);
               n135ArchUser = (String.IsNullOrEmpty(StringUtil.RTrim( A135ArchUser)) ? true : false);
               AV14empID = (short)(context.localUtil.CToN( cgiGet( edtavEmpid_Internalname), ",", "."));
               /* Read saved values. */
               Z27ArchSec = (short)(context.localUtil.CToN( cgiGet( "Z27ArchSec"), ",", "."));
               Z22OrdenID = (short)(context.localUtil.CToN( cgiGet( "Z22OrdenID"), ",", "."));
               Z28ArchClienteID = (short)(context.localUtil.CToN( cgiGet( "Z28ArchClienteID"), ",", "."));
               Z137ArchName = cgiGet( "Z137ArchName");
               n137ArchName = (String.IsNullOrEmpty(StringUtil.RTrim( A137ArchName)) ? true : false);
               Z135ArchUser = cgiGet( "Z135ArchUser");
               n135ArchUser = (String.IsNullOrEmpty(StringUtil.RTrim( A135ArchUser)) ? true : false);
               Z1EmpID = (short)(context.localUtil.CToN( cgiGet( "Z1EmpID"), ",", "."));
               A137ArchName = cgiGet( "Z137ArchName");
               n137ArchName = false;
               n137ArchName = (String.IsNullOrEmpty(StringUtil.RTrim( A137ArchName)) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               N1EmpID = (short)(context.localUtil.CToN( cgiGet( "N1EmpID"), ",", "."));
               AV8ArchSec = (short)(context.localUtil.CToN( cgiGet( "vARCHSEC"), ",", "."));
               AV10OrdenID = (short)(context.localUtil.CToN( cgiGet( "vORDENID"), ",", "."));
               AV7ArchClienteID = (short)(context.localUtil.CToN( cgiGet( "vARCHCLIENTEID"), ",", "."));
               AV15Insert_EmpID = (short)(context.localUtil.CToN( cgiGet( "vINSERT_EMPID"), ",", "."));
               A137ArchName = cgiGet( "ARCHNAME");
               n137ArchName = (String.IsNullOrEmpty(StringUtil.RTrim( A137ArchName)) ? true : false);
               AV13UserCod = cgiGet( "vUSERCOD");
               AV17Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               edtArchUrl_Filename = cgiGet( "ARCHURL_Filename");
               edtArchUrl_Filetype = cgiGet( "ARCHURL_Filetype");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A134ArchUrl)) )
               {
                  edtArchUrl_Filename = (String)(CGIGetFileName(edtArchUrl_Internalname));
                  edtArchUrl_Filetype = (String)(CGIGetFileType(edtArchUrl_Internalname));
               }
               if ( String.IsNullOrEmpty(StringUtil.RTrim( A134ArchUrl)) )
               {
                  GXCCtlgxBlob = "ARCHURL" + "_gxBlob";
                  A134ArchUrl = cgiGet( GXCCtlgxBlob);
                  n134ArchUrl = false;
                  n134ArchUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A134ArchUrl)) ? true : false);
               }
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "ArchivosOP";
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV15Insert_EmpID), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A27ArchSec != Z27ArchSec ) || ( A22OrdenID != Z22OrdenID ) || ( A28ArchClienteID != Z28ArchClienteID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("archivosop:[SecurityCheckFailed value for]"+"Insert_EmpID:"+context.localUtil.Format( (decimal)(AV15Insert_EmpID), "ZZZ9"));
                  GXUtil.WriteLog("archivosop:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A27ArchSec = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ArchSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ArchSec), 4, 0)));
                  A22OrdenID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
                  A28ArchClienteID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28ArchClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A28ArchClienteID), 4, 0)));
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
                     sMode22 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode22;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound22 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0A0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "ARCHSEC");
                        AnyError = 1;
                        GX_FocusControl = edtArchSec_Internalname;
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
                        E110A2 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: After Trn */
                        E120A2 ();
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
            E120A2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0A22( ) ;
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
            DisableAttributes0A22( ) ;
         }
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEmpid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEmpid_Enabled), 5, 0)), true);
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

      protected void CONFIRM_0A0( )
      {
         BeforeValidate0A22( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0A22( ) ;
            }
            else
            {
               CheckExtendedTable0A22( ) ;
               CloseExtendedTableCursors0A22( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0A0( )
      {
      }

      protected void E110A2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV17Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV17Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "TransactionContext", "KBCalpesa22");
         AV15Insert_EmpID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Insert_EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15Insert_EmpID), 4, 0)));
         if ( ( StringUtil.StrCmp(AV11TrnContext.gxTpr_Transactionname, AV17Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV18GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18GXV1), 8, 0)));
            while ( AV18GXV1 <= AV11TrnContext.gxTpr_Attributes.Count )
            {
               AV16TrnContextAtt = ((SdtTransactionContext_Attribute)AV11TrnContext.gxTpr_Attributes.Item(AV18GXV1));
               if ( StringUtil.StrCmp(AV16TrnContextAtt.gxTpr_Attributename, "EmpID") == 0 )
               {
                  AV15Insert_EmpID = (short)(NumberUtil.Val( AV16TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Insert_EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15Insert_EmpID), 4, 0)));
               }
               AV18GXV1 = (int)(AV18GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18GXV1), 8, 0)));
            }
         }
         edtavEmpid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEmpid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEmpid_Visible), 5, 0)), true);
      }

      protected void E120A2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV11TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwarchivosop.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0A22( short GX_JID )
      {
         if ( ( GX_JID == 19 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z137ArchName = T000A3_A137ArchName[0];
               Z135ArchUser = T000A3_A135ArchUser[0];
               Z1EmpID = T000A3_A1EmpID[0];
            }
            else
            {
               Z137ArchName = A137ArchName;
               Z135ArchUser = A135ArchUser;
               Z1EmpID = A1EmpID;
            }
         }
         if ( GX_JID == -19 )
         {
            Z27ArchSec = A27ArchSec;
            Z22OrdenID = A22OrdenID;
            Z28ArchClienteID = A28ArchClienteID;
            Z137ArchName = A137ArchName;
            Z134ArchUrl = A134ArchUrl;
            Z135ArchUser = A135ArchUser;
            Z1EmpID = A1EmpID;
            Z44empdsc = A44empdsc;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_1_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV8ArchSec) )
         {
            A27ArchSec = AV8ArchSec;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ArchSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ArchSec), 4, 0)));
         }
         if ( ! (0==AV8ArchSec) )
         {
            edtArchSec_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArchSec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtArchSec_Enabled), 5, 0)), true);
         }
         else
         {
            edtArchSec_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArchSec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtArchSec_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV8ArchSec) )
         {
            edtArchSec_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArchSec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtArchSec_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV10OrdenID) )
         {
            A22OrdenID = AV10OrdenID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
         }
         if ( ! (0==AV10OrdenID) )
         {
            dynOrdenID.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynOrdenID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynOrdenID.Enabled), 5, 0)), true);
         }
         else
         {
            dynOrdenID.Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynOrdenID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynOrdenID.Enabled), 5, 0)), true);
         }
         if ( ! (0==AV10OrdenID) )
         {
            dynOrdenID.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynOrdenID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynOrdenID.Enabled), 5, 0)), true);
         }
         if ( ! (0==AV7ArchClienteID) )
         {
            A28ArchClienteID = AV7ArchClienteID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28ArchClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A28ArchClienteID), 4, 0)));
         }
         if ( ! (0==AV7ArchClienteID) )
         {
            dynArchClienteID.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynArchClienteID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynArchClienteID.Enabled), 5, 0)), true);
         }
         else
         {
            dynArchClienteID.Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynArchClienteID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynArchClienteID.Enabled), 5, 0)), true);
         }
         if ( ! (0==AV7ArchClienteID) )
         {
            dynArchClienteID.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynArchClienteID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynArchClienteID.Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV15Insert_EmpID) )
         {
            edtEmpID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         }
         else
         {
            edtEmpID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV15Insert_EmpID) )
         {
            A1EmpID = AV15Insert_EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
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
            AV17Pgmname = "ArchivosOP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
            /* Using cursor T000A4 */
            pr_default.execute(2, new Object[] {A1EmpID});
            A44empdsc = T000A4_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000A4_n44empdsc[0];
            pr_default.close(2);
         }
      }

      protected void Load0A22( )
      {
         /* Using cursor T000A5 */
         pr_default.execute(3, new Object[] {A27ArchSec, A22OrdenID, A28ArchClienteID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound22 = 1;
            A137ArchName = T000A5_A137ArchName[0];
            n137ArchName = T000A5_n137ArchName[0];
            A44empdsc = T000A5_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000A5_n44empdsc[0];
            A135ArchUser = T000A5_A135ArchUser[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A135ArchUser", A135ArchUser);
            n135ArchUser = T000A5_n135ArchUser[0];
            A1EmpID = T000A5_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A134ArchUrl = T000A5_A134ArchUrl[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A134ArchUrl", A134ArchUrl);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArchUrl_Internalname, "URL", context.PathToRelativeUrl( A134ArchUrl), true);
            n134ArchUrl = T000A5_n134ArchUrl[0];
            ZM0A22( -19) ;
         }
         pr_default.close(3);
         OnLoadActions0A22( ) ;
      }

      protected void OnLoadActions0A22( )
      {
         AV17Pgmname = "ArchivosOP";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
      }

      protected void CheckExtendedTable0A22( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV17Pgmname = "ArchivosOP";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
         /* Using cursor T000A4 */
         pr_default.execute(2, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000A4_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T000A4_n44empdsc[0];
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors0A22( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_20( short A1EmpID )
      {
         /* Using cursor T000A6 */
         pr_default.execute(4, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000A6_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T000A6_n44empdsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A44empdsc)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(4);
      }

      protected void GetKey0A22( )
      {
         /* Using cursor T000A7 */
         pr_default.execute(5, new Object[] {A27ArchSec, A22OrdenID, A28ArchClienteID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound22 = 1;
         }
         else
         {
            RcdFound22 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000A3 */
         pr_default.execute(1, new Object[] {A27ArchSec, A22OrdenID, A28ArchClienteID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0A22( 19) ;
            RcdFound22 = 1;
            A27ArchSec = T000A3_A27ArchSec[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ArchSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ArchSec), 4, 0)));
            A22OrdenID = T000A3_A22OrdenID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
            A28ArchClienteID = T000A3_A28ArchClienteID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28ArchClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A28ArchClienteID), 4, 0)));
            A137ArchName = T000A3_A137ArchName[0];
            n137ArchName = T000A3_n137ArchName[0];
            A135ArchUser = T000A3_A135ArchUser[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A135ArchUser", A135ArchUser);
            n135ArchUser = T000A3_n135ArchUser[0];
            A1EmpID = T000A3_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A134ArchUrl = T000A3_A134ArchUrl[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A134ArchUrl", A134ArchUrl);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArchUrl_Internalname, "URL", context.PathToRelativeUrl( A134ArchUrl), true);
            n134ArchUrl = T000A3_n134ArchUrl[0];
            Z27ArchSec = A27ArchSec;
            Z22OrdenID = A22OrdenID;
            Z28ArchClienteID = A28ArchClienteID;
            sMode22 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0A22( ) ;
            if ( AnyError == 1 )
            {
               RcdFound22 = 0;
               InitializeNonKey0A22( ) ;
            }
            Gx_mode = sMode22;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound22 = 0;
            InitializeNonKey0A22( ) ;
            sMode22 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode22;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0A22( ) ;
         if ( RcdFound22 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound22 = 0;
         /* Using cursor T000A8 */
         pr_default.execute(6, new Object[] {A27ArchSec, A22OrdenID, A28ArchClienteID});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T000A8_A27ArchSec[0] < A27ArchSec ) || ( T000A8_A27ArchSec[0] == A27ArchSec ) && ( T000A8_A22OrdenID[0] < A22OrdenID ) || ( T000A8_A22OrdenID[0] == A22OrdenID ) && ( T000A8_A27ArchSec[0] == A27ArchSec ) && ( T000A8_A28ArchClienteID[0] < A28ArchClienteID ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T000A8_A27ArchSec[0] > A27ArchSec ) || ( T000A8_A27ArchSec[0] == A27ArchSec ) && ( T000A8_A22OrdenID[0] > A22OrdenID ) || ( T000A8_A22OrdenID[0] == A22OrdenID ) && ( T000A8_A27ArchSec[0] == A27ArchSec ) && ( T000A8_A28ArchClienteID[0] > A28ArchClienteID ) ) )
            {
               A27ArchSec = T000A8_A27ArchSec[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ArchSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ArchSec), 4, 0)));
               A22OrdenID = T000A8_A22OrdenID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
               A28ArchClienteID = T000A8_A28ArchClienteID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28ArchClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A28ArchClienteID), 4, 0)));
               RcdFound22 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound22 = 0;
         /* Using cursor T000A9 */
         pr_default.execute(7, new Object[] {A27ArchSec, A22OrdenID, A28ArchClienteID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T000A9_A27ArchSec[0] > A27ArchSec ) || ( T000A9_A27ArchSec[0] == A27ArchSec ) && ( T000A9_A22OrdenID[0] > A22OrdenID ) || ( T000A9_A22OrdenID[0] == A22OrdenID ) && ( T000A9_A27ArchSec[0] == A27ArchSec ) && ( T000A9_A28ArchClienteID[0] > A28ArchClienteID ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T000A9_A27ArchSec[0] < A27ArchSec ) || ( T000A9_A27ArchSec[0] == A27ArchSec ) && ( T000A9_A22OrdenID[0] < A22OrdenID ) || ( T000A9_A22OrdenID[0] == A22OrdenID ) && ( T000A9_A27ArchSec[0] == A27ArchSec ) && ( T000A9_A28ArchClienteID[0] < A28ArchClienteID ) ) )
            {
               A27ArchSec = T000A9_A27ArchSec[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ArchSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ArchSec), 4, 0)));
               A22OrdenID = T000A9_A22OrdenID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
               A28ArchClienteID = T000A9_A28ArchClienteID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28ArchClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A28ArchClienteID), 4, 0)));
               RcdFound22 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0A22( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0A22( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound22 == 1 )
            {
               if ( ( A27ArchSec != Z27ArchSec ) || ( A22OrdenID != Z22OrdenID ) || ( A28ArchClienteID != Z28ArchClienteID ) )
               {
                  A27ArchSec = Z27ArchSec;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ArchSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ArchSec), 4, 0)));
                  A22OrdenID = Z22OrdenID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
                  A28ArchClienteID = Z28ArchClienteID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28ArchClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A28ArchClienteID), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "ARCHSEC");
                  AnyError = 1;
                  GX_FocusControl = edtArchSec_Internalname;
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
                  Update0A22( ) ;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A27ArchSec != Z27ArchSec ) || ( A22OrdenID != Z22OrdenID ) || ( A28ArchClienteID != Z28ArchClienteID ) )
               {
                  /* Insert record */
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0A22( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "ARCHSEC");
                     AnyError = 1;
                     GX_FocusControl = edtArchSec_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtEmpID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0A22( ) ;
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
         if ( ( A27ArchSec != Z27ArchSec ) || ( A22OrdenID != Z22OrdenID ) || ( A28ArchClienteID != Z28ArchClienteID ) )
         {
            A27ArchSec = Z27ArchSec;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ArchSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ArchSec), 4, 0)));
            A22OrdenID = Z22OrdenID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
            A28ArchClienteID = Z28ArchClienteID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28ArchClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A28ArchClienteID), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "ARCHSEC");
            AnyError = 1;
            GX_FocusControl = edtArchSec_Internalname;
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

      protected void CheckOptimisticConcurrency0A22( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000A2 */
            pr_default.execute(0, new Object[] {A27ArchSec, A22OrdenID, A28ArchClienteID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ArchivosOP"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z137ArchName, T000A2_A137ArchName[0]) != 0 ) || ( StringUtil.StrCmp(Z135ArchUser, T000A2_A135ArchUser[0]) != 0 ) || ( Z1EmpID != T000A2_A1EmpID[0] ) )
            {
               if ( StringUtil.StrCmp(Z137ArchName, T000A2_A137ArchName[0]) != 0 )
               {
                  GXUtil.WriteLog("archivosop:[seudo value changed for attri]"+"ArchName");
                  GXUtil.WriteLogRaw("Old: ",Z137ArchName);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A137ArchName[0]);
               }
               if ( StringUtil.StrCmp(Z135ArchUser, T000A2_A135ArchUser[0]) != 0 )
               {
                  GXUtil.WriteLog("archivosop:[seudo value changed for attri]"+"ArchUser");
                  GXUtil.WriteLogRaw("Old: ",Z135ArchUser);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A135ArchUser[0]);
               }
               if ( Z1EmpID != T000A2_A1EmpID[0] )
               {
                  GXUtil.WriteLog("archivosop:[seudo value changed for attri]"+"EmpID");
                  GXUtil.WriteLogRaw("Old: ",Z1EmpID);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A1EmpID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"ArchivosOP"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0A22( )
      {
         BeforeValidate0A22( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0A22( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0A22( 0) ;
            CheckOptimisticConcurrency0A22( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0A22( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0A22( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000A10 */
                     pr_default.execute(8, new Object[] {A27ArchSec, A22OrdenID, A28ArchClienteID, n137ArchName, A137ArchName, n134ArchUrl, A134ArchUrl, n135ArchUser, A135ArchUser, A1EmpID});
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("ArchivosOP") ;
                     if ( (pr_default.getStatus(8) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        A137ArchName = edtArchUrl_Filename;
                        n137ArchName = false;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A137ArchName", A137ArchName);
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption0A0( ) ;
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
               Load0A22( ) ;
            }
            EndLevel0A22( ) ;
         }
         CloseExtendedTableCursors0A22( ) ;
      }

      protected void Update0A22( )
      {
         BeforeValidate0A22( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0A22( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0A22( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0A22( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0A22( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000A11 */
                     pr_default.execute(9, new Object[] {n137ArchName, A137ArchName, n135ArchUser, A135ArchUser, A1EmpID, A27ArchSec, A22OrdenID, A28ArchClienteID});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("ArchivosOP") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ArchivosOP"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0A22( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        A137ArchName = edtArchUrl_Filename;
                        n137ArchName = false;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A137ArchName", A137ArchName);
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
            EndLevel0A22( ) ;
         }
         CloseExtendedTableCursors0A22( ) ;
      }

      protected void DeferredUpdate0A22( )
      {
         if ( AnyError == 0 )
         {
            /* Using cursor T000A12 */
            pr_default.execute(10, new Object[] {n134ArchUrl, A134ArchUrl, A27ArchSec, A22OrdenID, A28ArchClienteID});
            pr_default.close(10);
            dsDefault.SmartCacheProvider.SetUpdated("ArchivosOP") ;
         }
      }

      protected void delete( )
      {
         BeforeValidate0A22( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0A22( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0A22( ) ;
            AfterConfirm0A22( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0A22( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000A13 */
                  pr_default.execute(11, new Object[] {A27ArchSec, A22OrdenID, A28ArchClienteID});
                  pr_default.close(11);
                  dsDefault.SmartCacheProvider.SetUpdated("ArchivosOP") ;
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
         sMode22 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0A22( ) ;
         Gx_mode = sMode22;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0A22( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV17Pgmname = "ArchivosOP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
            /* Using cursor T000A14 */
            pr_default.execute(12, new Object[] {A1EmpID});
            A44empdsc = T000A14_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000A14_n44empdsc[0];
            pr_default.close(12);
         }
      }

      protected void EndLevel0A22( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0A22( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(12);
            context.CommitDataStores("archivosop",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0A0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(12);
            context.RollbackDataStores("archivosop",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0A22( )
      {
         /* Scan By routine */
         /* Using cursor T000A15 */
         pr_default.execute(13);
         RcdFound22 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound22 = 1;
            A27ArchSec = T000A15_A27ArchSec[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ArchSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ArchSec), 4, 0)));
            A22OrdenID = T000A15_A22OrdenID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
            A28ArchClienteID = T000A15_A28ArchClienteID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28ArchClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A28ArchClienteID), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0A22( )
      {
         /* Scan next routine */
         pr_default.readNext(13);
         RcdFound22 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound22 = 1;
            A27ArchSec = T000A15_A27ArchSec[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ArchSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ArchSec), 4, 0)));
            A22OrdenID = T000A15_A22OrdenID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
            A28ArchClienteID = T000A15_A28ArchClienteID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28ArchClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A28ArchClienteID), 4, 0)));
         }
      }

      protected void ScanEnd0A22( )
      {
         pr_default.close(13);
      }

      protected void AfterConfirm0A22( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0A22( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0A22( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0A22( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0A22( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0A22( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0A22( )
      {
         edtEmpID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         edtempdsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempdsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempdsc_Enabled), 5, 0)), true);
         edtArchSec_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArchSec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtArchSec_Enabled), 5, 0)), true);
         dynOrdenID.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynOrdenID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynOrdenID.Enabled), 5, 0)), true);
         dynArchClienteID.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynArchClienteID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynArchClienteID.Enabled), 5, 0)), true);
         edtArchUrl_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArchUrl_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtArchUrl_Enabled), 5, 0)), true);
         dynArchUser.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynArchUser_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynArchUser.Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0A22( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0A0( )
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
         context.SendWebValue( "Archivos OP") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20231110423377", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("archivosop.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV8ArchSec) + "," + UrlEncode("" +AV10OrdenID) + "," + UrlEncode("" +AV7ArchClienteID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "ArchivosOP";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV15Insert_EmpID), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("archivosop:[SendSecurityCheck value for]"+"Insert_EmpID:"+context.localUtil.Format( (decimal)(AV15Insert_EmpID), "ZZZ9"));
         GXUtil.WriteLog("archivosop:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z27ArchSec", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z27ArchSec), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z22OrdenID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z22OrdenID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z28ArchClienteID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z28ArchClienteID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z137ArchName", StringUtil.RTrim( Z137ArchName));
         GxWebStd.gx_hidden_field( context, "Z135ArchUser", StringUtil.RTrim( Z135ArchUser));
         GxWebStd.gx_hidden_field( context, "Z1EmpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N1EmpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV11TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV11TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vARCHSEC", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8ArchSec), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vARCHSEC", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8ArchSec), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vORDENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10OrdenID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vORDENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10OrdenID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vARCHCLIENTEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7ArchClienteID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vARCHCLIENTEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7ArchClienteID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_EMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15Insert_EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ARCHNAME", StringUtil.RTrim( A137ArchName));
         GxWebStd.gx_hidden_field( context, "vUSERCOD", StringUtil.RTrim( AV13UserCod));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV17Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GXCCtlgxBlob = "ARCHURL" + "_gxBlob";
         GxWebStd.gx_hidden_field( context, GXCCtlgxBlob, A134ArchUrl);
         GxWebStd.gx_hidden_field( context, "ARCHURL_Filename", StringUtil.RTrim( edtArchUrl_Filename));
         GxWebStd.gx_hidden_field( context, "ARCHURL_Filetype", StringUtil.RTrim( edtArchUrl_Filetype));
      }

      protected void RenderHtmlCloseForm0A22( )
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
         return "ArchivosOP" ;
      }

      public override String GetPgmdesc( )
      {
         return "Archivos OP" ;
      }

      protected void InitializeNonKey0A22( )
      {
         A1EmpID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         A137ArchName = "";
         n137ArchName = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A137ArchName", A137ArchName);
         A44empdsc = "";
         n44empdsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         A134ArchUrl = "";
         n134ArchUrl = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A134ArchUrl", A134ArchUrl);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArchUrl_Internalname, "URL", context.PathToRelativeUrl( A134ArchUrl), true);
         n134ArchUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A134ArchUrl)) ? true : false);
         A135ArchUser = "";
         n135ArchUser = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A135ArchUser", A135ArchUser);
         n135ArchUser = (String.IsNullOrEmpty(StringUtil.RTrim( A135ArchUser)) ? true : false);
         Z137ArchName = "";
         Z135ArchUser = "";
         Z1EmpID = 0;
      }

      protected void InitAll0A22( )
      {
         A27ArchSec = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ArchSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ArchSec), 4, 0)));
         A22OrdenID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
         A28ArchClienteID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28ArchClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A28ArchClienteID), 4, 0)));
         InitializeNonKey0A22( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20231110423390", true);
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
         context.AddJavascriptSource("archivosop.js", "?20231110423390", false);
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
         edtArchSec_Internalname = "ARCHSEC";
         dynOrdenID_Internalname = "ORDENID";
         dynArchClienteID_Internalname = "ARCHCLIENTEID";
         edtArchUrl_Internalname = "ARCHURL";
         dynArchUser_Internalname = "ARCHUSER";
         divFormcontainer_Internalname = "FORMCONTAINER";
         edtavEmpid_Internalname = "vEMPID";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_1_Internalname = "PROMPT_1";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtArchUrl_Filename = "";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtavEmpid_Jsonclick = "";
         edtavEmpid_Enabled = 0;
         edtavEmpid_Visible = 1;
         dynArchUser_Jsonclick = "";
         dynArchUser.Enabled = 1;
         edtArchUrl_Jsonclick = "";
         edtArchUrl_Parameters = "";
         edtArchUrl_Contenttype = "";
         edtArchUrl_Filetype = "";
         edtArchUrl_Enabled = 1;
         dynArchClienteID_Jsonclick = "";
         dynArchClienteID.Enabled = 1;
         dynOrdenID_Jsonclick = "";
         dynOrdenID.Enabled = 1;
         edtArchSec_Jsonclick = "";
         edtArchSec_Enabled = 1;
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

      protected void GXDLAARCHUSER0A1( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLAARCHUSER_data0A1( ) ;
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

      protected void GXAARCHUSER_html0A1( )
      {
         String gxdynajaxvalue ;
         GXDLAARCHUSER_data0A1( ) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynArchUser.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynArchUser.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLAARCHUSER_data0A1( )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         /* Using cursor T000A16 */
         pr_default.execute(14);
         while ( (pr_default.getStatus(14) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( T000A16_A3UsuCod[0]));
            gxdynajaxctrldescr.Add(T000A16_A50UsuName[0]);
            pr_default.readNext(14);
         }
         pr_default.close(14);
      }

      protected void GXDLAORDENID0A22( short A1EmpID ,
                                       String AV13UserCod )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLAORDENID_data0A22( A1EmpID, AV13UserCod) ;
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

      protected void GXAORDENID_html0A22( short A1EmpID ,
                                          String AV13UserCod )
      {
         short gxdynajaxvalue ;
         GXDLAORDENID_data0A22( A1EmpID, AV13UserCod) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynOrdenID.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (short)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynOrdenID.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 4, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLAORDENID_data0A22( short A1EmpID ,
                                            String AV13UserCod )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Seleccionar");
         /* Using cursor T000A17 */
         pr_default.execute(15, new Object[] {A1EmpID, AV13UserCod});
         while ( (pr_default.getStatus(15) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T000A17_A22OrdenID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T000A17_A22OrdenID[0]), 4, 0, ".", "")));
            pr_default.readNext(15);
         }
         pr_default.close(15);
      }

      protected void GXDLAARCHCLIENTEID0A22( short AV14empID )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLAARCHCLIENTEID_data0A22( AV14empID) ;
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

      protected void GXAARCHCLIENTEID_html0A22( short AV14empID )
      {
         short gxdynajaxvalue ;
         GXDLAARCHCLIENTEID_data0A22( AV14empID) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynArchClienteID.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (short)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynArchClienteID.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 4, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLAARCHCLIENTEID_data0A22( short AV14empID )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Seleccionar");
         /* Using cursor T000A18 */
         pr_default.execute(16, new Object[] {AV14empID});
         while ( (pr_default.getStatus(16) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T000A18_A5ClienteID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T000A18_A57ClienteDsc[0]));
            pr_default.readNext(16);
         }
         pr_default.close(16);
      }

      protected void init_web_controls( )
      {
         dynOrdenID.Name = "ORDENID";
         dynOrdenID.WebTags = "";
         dynArchClienteID.Name = "ARCHCLIENTEID";
         dynArchClienteID.WebTags = "";
         dynArchUser.Name = "ARCHUSER";
         dynArchUser.WebTags = "";
         dynArchUser.removeAllItems();
         /* Using cursor T000A19 */
         pr_default.execute(17);
         while ( (pr_default.getStatus(17) != 101) )
         {
            dynArchUser.addItem(T000A19_A3UsuCod[0], T000A19_A50UsuName[0], 0);
            pr_default.readNext(17);
         }
         pr_default.close(17);
         if ( dynArchUser.ItemCount > 0 )
         {
            A135ArchUser = dynArchUser.getValidValue(A135ArchUser);
            n135ArchUser = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A135ArchUser", A135ArchUser);
         }
         /* End function init_web_controls */
      }

      public void Valid_Empid( short GX_Parm1 ,
                               String GX_Parm2 ,
                               String GX_Parm3 ,
                               GXCombobox dynGX_Parm4 )
      {
         A1EmpID = GX_Parm1;
         AV13UserCod = GX_Parm2;
         A44empdsc = GX_Parm3;
         n44empdsc = false;
         dynOrdenID = dynGX_Parm4;
         A22OrdenID = (short)(NumberUtil.Val( dynOrdenID.CurrentValue, "."));
         /* Using cursor T000A14 */
         pr_default.execute(12, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(12) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A44empdsc = T000A14_A44empdsc[0];
         n44empdsc = T000A14_n44empdsc[0];
         pr_default.close(12);
         GXAORDENID_html0A22( A1EmpID, AV13UserCod) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A44empdsc = "";
            n44empdsc = false;
         }
         dynOrdenID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0));
         isValidOutput.Add(A44empdsc);
         if ( dynOrdenID.ItemCount > 0 )
         {
            A22OrdenID = (short)(NumberUtil.Val( dynOrdenID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0))), "."));
         }
         dynOrdenID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0));
         isValidOutput.Add(dynOrdenID);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Validv_Empid( short GX_Parm1 ,
                                GXCombobox dynGX_Parm2 )
      {
         AV14empID = GX_Parm1;
         dynArchClienteID = dynGX_Parm2;
         A28ArchClienteID = (short)(NumberUtil.Val( dynArchClienteID.CurrentValue, "."));
         GXAARCHCLIENTEID_html0A22( AV14empID) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         dynArchClienteID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A28ArchClienteID), 4, 0));
         if ( dynArchClienteID.ItemCount > 0 )
         {
            A28ArchClienteID = (short)(NumberUtil.Val( dynArchClienteID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A28ArchClienteID), 4, 0))), "."));
         }
         dynArchClienteID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A28ArchClienteID), 4, 0));
         isValidOutput.Add(dynArchClienteID);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV8ArchSec',fld:'vARCHSEC',pic:'ZZZ9',hsh:true},{av:'AV10OrdenID',fld:'vORDENID',pic:'ZZZ9',hsh:true},{av:'AV7ArchClienteID',fld:'vARCHCLIENTEID',pic:'ZZZ9',hsh:true},{av:'dynArchUser'},{av:'A135ArchUser',fld:'ARCHUSER',pic:'@!'}]");
         setEventMetadata("ENTER",",oparms:[{av:'dynArchUser'},{av:'A135ArchUser',fld:'ARCHUSER',pic:'@!'}]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV8ArchSec',fld:'vARCHSEC',pic:'ZZZ9',hsh:true},{av:'AV10OrdenID',fld:'vORDENID',pic:'ZZZ9',hsh:true},{av:'AV7ArchClienteID',fld:'vARCHCLIENTEID',pic:'ZZZ9',hsh:true},{av:'AV15Insert_EmpID',fld:'vINSERT_EMPID',pic:'ZZZ9'},{av:'dynArchUser'},{av:'A135ArchUser',fld:'ARCHUSER',pic:'@!'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'dynArchUser'},{av:'A135ArchUser',fld:'ARCHUSER',pic:'@!'}]}");
         setEventMetadata("AFTER TRN","{handler:'E120A2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'dynArchUser'},{av:'A135ArchUser',fld:'ARCHUSER',pic:'@!'}]");
         setEventMetadata("AFTER TRN",",oparms:[{av:'dynArchUser'},{av:'A135ArchUser',fld:'ARCHUSER',pic:'@!'}]}");
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
         pr_default.close(12);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z137ArchName = "";
         Z135ArchUser = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV13UserCod = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         A135ArchUser = "";
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
         gxblobfileaux = new GxFile(context.GetPhysicalPath());
         A134ArchUrl = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         A137ArchName = "";
         AV17Pgmname = "";
         GXCCtlgxBlob = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode22 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV11TrnContext = new SdtTransactionContext(context);
         AV12WebSession = context.GetSession();
         AV16TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z134ArchUrl = "";
         Z44empdsc = "";
         T000A4_A44empdsc = new String[] {""} ;
         T000A4_n44empdsc = new bool[] {false} ;
         T000A5_A27ArchSec = new short[1] ;
         T000A5_A22OrdenID = new short[1] ;
         T000A5_A28ArchClienteID = new short[1] ;
         T000A5_A137ArchName = new String[] {""} ;
         T000A5_n137ArchName = new bool[] {false} ;
         T000A5_A44empdsc = new String[] {""} ;
         T000A5_n44empdsc = new bool[] {false} ;
         T000A5_A135ArchUser = new String[] {""} ;
         T000A5_n135ArchUser = new bool[] {false} ;
         T000A5_A1EmpID = new short[1] ;
         T000A5_A134ArchUrl = new String[] {""} ;
         T000A5_n134ArchUrl = new bool[] {false} ;
         T000A6_A44empdsc = new String[] {""} ;
         T000A6_n44empdsc = new bool[] {false} ;
         T000A7_A27ArchSec = new short[1] ;
         T000A7_A22OrdenID = new short[1] ;
         T000A7_A28ArchClienteID = new short[1] ;
         T000A3_A27ArchSec = new short[1] ;
         T000A3_A22OrdenID = new short[1] ;
         T000A3_A28ArchClienteID = new short[1] ;
         T000A3_A137ArchName = new String[] {""} ;
         T000A3_n137ArchName = new bool[] {false} ;
         T000A3_A135ArchUser = new String[] {""} ;
         T000A3_n135ArchUser = new bool[] {false} ;
         T000A3_A1EmpID = new short[1] ;
         T000A3_A134ArchUrl = new String[] {""} ;
         T000A3_n134ArchUrl = new bool[] {false} ;
         T000A8_A27ArchSec = new short[1] ;
         T000A8_A22OrdenID = new short[1] ;
         T000A8_A28ArchClienteID = new short[1] ;
         T000A9_A27ArchSec = new short[1] ;
         T000A9_A22OrdenID = new short[1] ;
         T000A9_A28ArchClienteID = new short[1] ;
         T000A2_A27ArchSec = new short[1] ;
         T000A2_A22OrdenID = new short[1] ;
         T000A2_A28ArchClienteID = new short[1] ;
         T000A2_A137ArchName = new String[] {""} ;
         T000A2_n137ArchName = new bool[] {false} ;
         T000A2_A135ArchUser = new String[] {""} ;
         T000A2_n135ArchUser = new bool[] {false} ;
         T000A2_A1EmpID = new short[1] ;
         T000A2_A134ArchUrl = new String[] {""} ;
         T000A2_n134ArchUrl = new bool[] {false} ;
         T000A14_A44empdsc = new String[] {""} ;
         T000A14_n44empdsc = new bool[] {false} ;
         T000A15_A27ArchSec = new short[1] ;
         T000A15_A22OrdenID = new short[1] ;
         T000A15_A28ArchClienteID = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         T000A16_A3UsuCod = new String[] {""} ;
         T000A16_A50UsuName = new String[] {""} ;
         T000A16_n50UsuName = new bool[] {false} ;
         T000A17_A1EmpID = new short[1] ;
         T000A17_A5ClienteID = new short[1] ;
         T000A17_A24OrdenPeriodo = new short[1] ;
         T000A17_A25OrdenAnio = new short[1] ;
         T000A17_A22OrdenID = new short[1] ;
         T000A17_A115OrdenEst = new String[] {""} ;
         T000A17_n115OrdenEst = new bool[] {false} ;
         T000A17_A116OrdenUser = new String[] {""} ;
         T000A17_n116OrdenUser = new bool[] {false} ;
         T000A18_A1EmpID = new short[1] ;
         T000A18_A5ClienteID = new short[1] ;
         T000A18_A57ClienteDsc = new String[] {""} ;
         T000A18_n57ClienteDsc = new bool[] {false} ;
         T000A19_A3UsuCod = new String[] {""} ;
         T000A19_A50UsuName = new String[] {""} ;
         T000A19_n50UsuName = new bool[] {false} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.archivosop__default(),
            new Object[][] {
                new Object[] {
               T000A2_A27ArchSec, T000A2_A22OrdenID, T000A2_A28ArchClienteID, T000A2_A137ArchName, T000A2_n137ArchName, T000A2_A135ArchUser, T000A2_n135ArchUser, T000A2_A1EmpID, T000A2_A134ArchUrl, T000A2_n134ArchUrl
               }
               , new Object[] {
               T000A3_A27ArchSec, T000A3_A22OrdenID, T000A3_A28ArchClienteID, T000A3_A137ArchName, T000A3_n137ArchName, T000A3_A135ArchUser, T000A3_n135ArchUser, T000A3_A1EmpID, T000A3_A134ArchUrl, T000A3_n134ArchUrl
               }
               , new Object[] {
               T000A4_A44empdsc, T000A4_n44empdsc
               }
               , new Object[] {
               T000A5_A27ArchSec, T000A5_A22OrdenID, T000A5_A28ArchClienteID, T000A5_A137ArchName, T000A5_n137ArchName, T000A5_A44empdsc, T000A5_n44empdsc, T000A5_A135ArchUser, T000A5_n135ArchUser, T000A5_A1EmpID,
               T000A5_A134ArchUrl, T000A5_n134ArchUrl
               }
               , new Object[] {
               T000A6_A44empdsc, T000A6_n44empdsc
               }
               , new Object[] {
               T000A7_A27ArchSec, T000A7_A22OrdenID, T000A7_A28ArchClienteID
               }
               , new Object[] {
               T000A8_A27ArchSec, T000A8_A22OrdenID, T000A8_A28ArchClienteID
               }
               , new Object[] {
               T000A9_A27ArchSec, T000A9_A22OrdenID, T000A9_A28ArchClienteID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000A14_A44empdsc, T000A14_n44empdsc
               }
               , new Object[] {
               T000A15_A27ArchSec, T000A15_A22OrdenID, T000A15_A28ArchClienteID
               }
               , new Object[] {
               T000A16_A3UsuCod, T000A16_A50UsuName, T000A16_n50UsuName
               }
               , new Object[] {
               T000A17_A1EmpID, T000A17_A5ClienteID, T000A17_A24OrdenPeriodo, T000A17_A25OrdenAnio, T000A17_A22OrdenID, T000A17_A115OrdenEst, T000A17_n115OrdenEst, T000A17_A116OrdenUser, T000A17_n116OrdenUser
               }
               , new Object[] {
               T000A18_A1EmpID, T000A18_A5ClienteID, T000A18_A57ClienteDsc, T000A18_n57ClienteDsc
               }
               , new Object[] {
               T000A19_A3UsuCod, T000A19_A50UsuName, T000A19_n50UsuName
               }
            }
         );
         AV17Pgmname = "ArchivosOP";
      }

      private short wcpOAV8ArchSec ;
      private short wcpOAV10OrdenID ;
      private short wcpOAV7ArchClienteID ;
      private short Z27ArchSec ;
      private short Z22OrdenID ;
      private short Z28ArchClienteID ;
      private short Z1EmpID ;
      private short N1EmpID ;
      private short GxWebError ;
      private short A1EmpID ;
      private short AV14empID ;
      private short AV8ArchSec ;
      private short AV10OrdenID ;
      private short AV7ArchClienteID ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short A22OrdenID ;
      private short A28ArchClienteID ;
      private short A27ArchSec ;
      private short AV15Insert_EmpID ;
      private short RcdFound22 ;
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
      private int edtArchSec_Enabled ;
      private int edtArchUrl_Enabled ;
      private int edtavEmpid_Visible ;
      private int edtavEmpid_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int AV18GXV1 ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z137ArchName ;
      private String Z135ArchUser ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String AV13UserCod ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtEmpID_Internalname ;
      private String dynOrdenID_Internalname ;
      private String dynArchClienteID_Internalname ;
      private String A135ArchUser ;
      private String dynArchUser_Internalname ;
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
      private String edtArchSec_Internalname ;
      private String edtArchSec_Jsonclick ;
      private String dynOrdenID_Jsonclick ;
      private String dynArchClienteID_Jsonclick ;
      private String edtArchUrl_Internalname ;
      private String edtArchUrl_Filetype ;
      private String edtArchUrl_Contenttype ;
      private String edtArchUrl_Parameters ;
      private String edtArchUrl_Jsonclick ;
      private String dynArchUser_Jsonclick ;
      private String edtavEmpid_Internalname ;
      private String edtavEmpid_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String A137ArchName ;
      private String AV17Pgmname ;
      private String edtArchUrl_Filename ;
      private String GXCCtlgxBlob ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode22 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String gxwrpcisep ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n135ArchUser ;
      private bool n134ArchUrl ;
      private bool n44empdsc ;
      private bool n137ArchName ;
      private bool returnInSub ;
      private bool gxdyncontrolsrefreshing ;
      private String A44empdsc ;
      private String Z44empdsc ;
      private String A134ArchUrl ;
      private String Z134ArchUrl ;
      private IGxSession AV12WebSession ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GxFile gxblobfileaux ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynOrdenID ;
      private GXCombobox dynArchClienteID ;
      private GXCombobox dynArchUser ;
      private IDataStoreProvider pr_default ;
      private String[] T000A4_A44empdsc ;
      private bool[] T000A4_n44empdsc ;
      private short[] T000A5_A27ArchSec ;
      private short[] T000A5_A22OrdenID ;
      private short[] T000A5_A28ArchClienteID ;
      private String[] T000A5_A137ArchName ;
      private bool[] T000A5_n137ArchName ;
      private String[] T000A5_A44empdsc ;
      private bool[] T000A5_n44empdsc ;
      private String[] T000A5_A135ArchUser ;
      private bool[] T000A5_n135ArchUser ;
      private short[] T000A5_A1EmpID ;
      private String[] T000A5_A134ArchUrl ;
      private bool[] T000A5_n134ArchUrl ;
      private String[] T000A6_A44empdsc ;
      private bool[] T000A6_n44empdsc ;
      private short[] T000A7_A27ArchSec ;
      private short[] T000A7_A22OrdenID ;
      private short[] T000A7_A28ArchClienteID ;
      private short[] T000A3_A27ArchSec ;
      private short[] T000A3_A22OrdenID ;
      private short[] T000A3_A28ArchClienteID ;
      private String[] T000A3_A137ArchName ;
      private bool[] T000A3_n137ArchName ;
      private String[] T000A3_A135ArchUser ;
      private bool[] T000A3_n135ArchUser ;
      private short[] T000A3_A1EmpID ;
      private String[] T000A3_A134ArchUrl ;
      private bool[] T000A3_n134ArchUrl ;
      private short[] T000A8_A27ArchSec ;
      private short[] T000A8_A22OrdenID ;
      private short[] T000A8_A28ArchClienteID ;
      private short[] T000A9_A27ArchSec ;
      private short[] T000A9_A22OrdenID ;
      private short[] T000A9_A28ArchClienteID ;
      private short[] T000A2_A27ArchSec ;
      private short[] T000A2_A22OrdenID ;
      private short[] T000A2_A28ArchClienteID ;
      private String[] T000A2_A137ArchName ;
      private bool[] T000A2_n137ArchName ;
      private String[] T000A2_A135ArchUser ;
      private bool[] T000A2_n135ArchUser ;
      private short[] T000A2_A1EmpID ;
      private String[] T000A2_A134ArchUrl ;
      private bool[] T000A2_n134ArchUrl ;
      private String[] T000A14_A44empdsc ;
      private bool[] T000A14_n44empdsc ;
      private short[] T000A15_A27ArchSec ;
      private short[] T000A15_A22OrdenID ;
      private short[] T000A15_A28ArchClienteID ;
      private String[] T000A16_A3UsuCod ;
      private String[] T000A16_A50UsuName ;
      private bool[] T000A16_n50UsuName ;
      private short[] T000A17_A1EmpID ;
      private short[] T000A17_A5ClienteID ;
      private short[] T000A17_A24OrdenPeriodo ;
      private short[] T000A17_A25OrdenAnio ;
      private short[] T000A17_A22OrdenID ;
      private String[] T000A17_A115OrdenEst ;
      private bool[] T000A17_n115OrdenEst ;
      private String[] T000A17_A116OrdenUser ;
      private bool[] T000A17_n116OrdenUser ;
      private short[] T000A18_A1EmpID ;
      private short[] T000A18_A5ClienteID ;
      private String[] T000A18_A57ClienteDsc ;
      private bool[] T000A18_n57ClienteDsc ;
      private String[] T000A19_A3UsuCod ;
      private String[] T000A19_A50UsuName ;
      private bool[] T000A19_n50UsuName ;
      private SdtTransactionContext AV11TrnContext ;
      private SdtTransactionContext_Attribute AV16TrnContextAtt ;
   }

   public class archivosop__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new UpdateCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000A5 ;
          prmT000A5 = new Object[] {
          new Object[] {"@ArchSec",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ArchClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000A4 ;
          prmT000A4 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000A6 ;
          prmT000A6 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000A7 ;
          prmT000A7 = new Object[] {
          new Object[] {"@ArchSec",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ArchClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000A3 ;
          prmT000A3 = new Object[] {
          new Object[] {"@ArchSec",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ArchClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000A8 ;
          prmT000A8 = new Object[] {
          new Object[] {"@ArchSec",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ArchClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000A9 ;
          prmT000A9 = new Object[] {
          new Object[] {"@ArchSec",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ArchClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000A2 ;
          prmT000A2 = new Object[] {
          new Object[] {"@ArchSec",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ArchClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000A10 ;
          prmT000A10 = new Object[] {
          new Object[] {"@ArchSec",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ArchClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ArchName",SqlDbType.Char,40,0} ,
          new Object[] {"@ArchUrl",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@ArchUser",SqlDbType.Char,40,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000A11 ;
          prmT000A11 = new Object[] {
          new Object[] {"@ArchName",SqlDbType.Char,40,0} ,
          new Object[] {"@ArchUser",SqlDbType.Char,40,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ArchSec",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ArchClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000A12 ;
          prmT000A12 = new Object[] {
          new Object[] {"@ArchUrl",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@ArchSec",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ArchClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000A13 ;
          prmT000A13 = new Object[] {
          new Object[] {"@ArchSec",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ArchClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000A15 ;
          prmT000A15 = new Object[] {
          } ;
          Object[] prmT000A16 ;
          prmT000A16 = new Object[] {
          } ;
          Object[] prmT000A17 ;
          prmT000A17 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV13UserCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000A18 ;
          prmT000A18 = new Object[] {
          new Object[] {"@AV14empID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000A19 ;
          prmT000A19 = new Object[] {
          } ;
          Object[] prmT000A14 ;
          prmT000A14 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000A2", "SELECT [ArchSec], [OrdenID], [ArchClienteID], [ArchName], [ArchUser], [EmpID], [ArchUrl] FROM [ArchivosOP] WITH (UPDLOCK) WHERE [ArchSec] = @ArchSec AND [OrdenID] = @OrdenID AND [ArchClienteID] = @ArchClienteID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A2,1,0,true,false )
             ,new CursorDef("T000A3", "SELECT [ArchSec], [OrdenID], [ArchClienteID], [ArchName], [ArchUser], [EmpID], [ArchUrl] FROM [ArchivosOP] WITH (NOLOCK) WHERE [ArchSec] = @ArchSec AND [OrdenID] = @OrdenID AND [ArchClienteID] = @ArchClienteID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A3,1,0,true,false )
             ,new CursorDef("T000A4", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A4,1,0,true,false )
             ,new CursorDef("T000A5", "SELECT TM1.[ArchSec], TM1.[OrdenID], TM1.[ArchClienteID], TM1.[ArchName], T2.[empdsc], TM1.[ArchUser], TM1.[EmpID], TM1.[ArchUrl] FROM ([ArchivosOP] TM1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = TM1.[EmpID]) WHERE TM1.[ArchSec] = @ArchSec and TM1.[OrdenID] = @OrdenID and TM1.[ArchClienteID] = @ArchClienteID ORDER BY TM1.[ArchSec], TM1.[OrdenID], TM1.[ArchClienteID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A5,100,0,true,false )
             ,new CursorDef("T000A6", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A6,1,0,true,false )
             ,new CursorDef("T000A7", "SELECT [ArchSec], [OrdenID], [ArchClienteID] FROM [ArchivosOP] WITH (NOLOCK) WHERE [ArchSec] = @ArchSec AND [OrdenID] = @OrdenID AND [ArchClienteID] = @ArchClienteID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A7,1,0,true,false )
             ,new CursorDef("T000A8", "SELECT TOP 1 [ArchSec], [OrdenID], [ArchClienteID] FROM [ArchivosOP] WITH (NOLOCK) WHERE ( [ArchSec] > @ArchSec or [ArchSec] = @ArchSec and [OrdenID] > @OrdenID or [OrdenID] = @OrdenID and [ArchSec] = @ArchSec and [ArchClienteID] > @ArchClienteID) ORDER BY [ArchSec], [OrdenID], [ArchClienteID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A8,1,0,true,true )
             ,new CursorDef("T000A9", "SELECT TOP 1 [ArchSec], [OrdenID], [ArchClienteID] FROM [ArchivosOP] WITH (NOLOCK) WHERE ( [ArchSec] < @ArchSec or [ArchSec] = @ArchSec and [OrdenID] < @OrdenID or [OrdenID] = @OrdenID and [ArchSec] = @ArchSec and [ArchClienteID] < @ArchClienteID) ORDER BY [ArchSec] DESC, [OrdenID] DESC, [ArchClienteID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A9,1,0,true,true )
             ,new CursorDef("T000A10", "INSERT INTO [ArchivosOP]([ArchSec], [OrdenID], [ArchClienteID], [ArchName], [ArchUrl], [ArchUser], [EmpID]) VALUES(@ArchSec, @OrdenID, @ArchClienteID, @ArchName, @ArchUrl, @ArchUser, @EmpID)", GxErrorMask.GX_NOMASK,prmT000A10)
             ,new CursorDef("T000A11", "UPDATE [ArchivosOP] SET [ArchName]=@ArchName, [ArchUser]=@ArchUser, [EmpID]=@EmpID  WHERE [ArchSec] = @ArchSec AND [OrdenID] = @OrdenID AND [ArchClienteID] = @ArchClienteID", GxErrorMask.GX_NOMASK,prmT000A11)
             ,new CursorDef("T000A12", "UPDATE [ArchivosOP] SET [ArchUrl]=@ArchUrl  WHERE [ArchSec] = @ArchSec AND [OrdenID] = @OrdenID AND [ArchClienteID] = @ArchClienteID", GxErrorMask.GX_NOMASK,prmT000A12)
             ,new CursorDef("T000A13", "DELETE FROM [ArchivosOP]  WHERE [ArchSec] = @ArchSec AND [OrdenID] = @OrdenID AND [ArchClienteID] = @ArchClienteID", GxErrorMask.GX_NOMASK,prmT000A13)
             ,new CursorDef("T000A14", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A14,1,0,true,false )
             ,new CursorDef("T000A15", "SELECT [ArchSec], [OrdenID], [ArchClienteID] FROM [ArchivosOP] WITH (NOLOCK) ORDER BY [ArchSec], [OrdenID], [ArchClienteID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A15,100,0,true,false )
             ,new CursorDef("T000A16", "SELECT [UsuCod], [UsuName] FROM [Usuarios] WITH (NOLOCK) ORDER BY [UsuName] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A16,0,0,true,false )
             ,new CursorDef("T000A17", "SELECT [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID], [OrdenEst], [OrdenUser] FROM [OrdenProduccion] WITH (NOLOCK) WHERE ([EmpID] = @EmpID) AND ([OrdenEst] = 'A') AND ([OrdenUser] = @AV13UserCod) ORDER BY [OrdenID] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A17,0,0,true,false )
             ,new CursorDef("T000A18", "SELECT [EmpID], [ClienteID], [ClienteDsc] FROM [Clientes] WITH (NOLOCK) WHERE [EmpID] = @AV14empID ORDER BY [ClienteDsc] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A18,0,0,true,false )
             ,new CursorDef("T000A19", "SELECT [UsuCod], [UsuName] FROM [Usuarios] WITH (NOLOCK) ORDER BY [UsuName] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A19,0,0,true,false )
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
                ((String[]) buf[3])[0] = rslt.getString(4, 40) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getString(5, 40) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                ((String[]) buf[8])[0] = rslt.getBLOBFile(7, "pdf", "") ;
                ((bool[]) buf[9])[0] = rslt.wasNull(7);
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 40) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getString(5, 40) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                ((String[]) buf[8])[0] = rslt.getBLOBFile(7, "pdf", "") ;
                ((bool[]) buf[9])[0] = rslt.wasNull(7);
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 40) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((String[]) buf[7])[0] = rslt.getString(6, 40) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                ((short[]) buf[9])[0] = rslt.getShort(7) ;
                ((String[]) buf[10])[0] = rslt.getBLOBFile(8, "pdf", "") ;
                ((bool[]) buf[11])[0] = rslt.wasNull(8);
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                return;
             case 15 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 1) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((String[]) buf[7])[0] = rslt.getString(7, 40) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                return;
             case 16 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                return;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
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
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 8 :
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
                   stmt.setNull( 5 , SqlDbType.VarBinary );
                }
                else
                {
                   stmt.SetParameterBlob(5, (String)parms[6], true);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 6 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[8]);
                }
                stmt.SetParameter(7, (short)parms[9]);
                return;
             case 9 :
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
                stmt.SetParameter(6, (short)parms[7]);
                return;
             case 10 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarBinary );
                }
                else
                {
                   stmt.SetParameterBlob(1, (String)parms[1], true);
                }
                stmt.SetParameter(2, (short)parms[2]);
                stmt.SetParameter(3, (short)parms[3]);
                stmt.SetParameter(4, (short)parms[4]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
