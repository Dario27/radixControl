/*
               File: Obreros
        Description: Obreros
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/26/2022 20:14:10.88
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
   public class obreros : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel5"+"_"+"OBREID") == 0 )
         {
            AV7ObreID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ObreID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ObreID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vOBREID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7ObreID), "ZZZ9"), context));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX5ASAOBREID0R42( AV7ObreID) ;
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
               AV7ObreID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ObreID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ObreID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vOBREID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7ObreID), "ZZZ9"), context));
               AV11ObreCedula = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11ObreCedula", AV11ObreCedula);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vOBRECEDULA", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV11ObreCedula, "")), context));
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
            Form.Meta.addItem("description", "Obreros", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtObreID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public obreros( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public obreros( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_ObreID ,
                           String aP2_ObreCedula )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7ObreID = aP1_ObreID;
         this.AV11ObreCedula = aP2_ObreCedula;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkObreEst = new GXCheckbox();
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Obreros", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Obreros.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Obreros.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Obreros.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Obreros.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Obreros.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 5, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Obreros.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtObreID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtObreID_Internalname, "ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtObreID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A238ObreID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A238ObreID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtObreID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtObreID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Obreros.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtObreCedula_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtObreCedula_Internalname, "Cedula", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtObreCedula_Internalname, StringUtil.RTrim( A239ObreCedula), StringUtil.RTrim( context.localUtil.Format( A239ObreCedula, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtObreCedula_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtObreCedula_Enabled, 1, "text", "", 13, "chr", 1, "row", 13, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Obreros.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3", "left", "Middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSeccape1_Internalname, 1, 0, "px", 0, "px", "FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtObrePrApellido_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtObrePrApellido_Internalname, "Primer Apellido", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtObrePrApellido_Internalname, A242ObrePrApellido, StringUtil.RTrim( context.localUtil.Format( A242ObrePrApellido, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtObrePrApellido_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtObrePrApellido_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Obreros.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "Middle", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3", "left", "Middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSeccape2_Internalname, 1, 0, "px", 0, "px", "FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtObreSegApellido_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtObreSegApellido_Internalname, "Segundo Apellido", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtObreSegApellido_Internalname, A243ObreSegApellido, StringUtil.RTrim( context.localUtil.Format( A243ObreSegApellido, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtObreSegApellido_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtObreSegApellido_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Obreros.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "Middle", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3", "left", "Middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSeccname1_Internalname, 1, 0, "px", 0, "px", "FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtObrePrNombre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtObrePrNombre_Internalname, "Primer Nombre", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtObrePrNombre_Internalname, A240ObrePrNombre, StringUtil.RTrim( context.localUtil.Format( A240ObrePrNombre, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtObrePrNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtObrePrNombre_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Obreros.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "Middle", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3", "left", "Middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSeccname2_Internalname, 1, 0, "px", 0, "px", "FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtObreSegNombre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtObreSegNombre_Internalname, "Segundo Nombre", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtObreSegNombre_Internalname, A241ObreSegNombre, StringUtil.RTrim( context.localUtil.Format( A241ObreSegNombre, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,60);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtObreSegNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtObreSegNombre_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Obreros.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "Middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtObreNombre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtObreNombre_Internalname, "Nombre Completo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtObreNombre_Internalname, A244ObreNombre, StringUtil.RTrim( context.localUtil.Format( A244ObreNombre, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtObreNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtObreNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Obreros.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtObreFchNac_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtObreFchNac_Internalname, "Fecha Nac.", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtObreFchNac_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtObreFchNac_Internalname, context.localUtil.Format(A245ObreFchNac, "99/99/9999"), context.localUtil.Format( A245ObreFchNac, "99/99/9999"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,70);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtObreFchNac_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtObreFchNac_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Obreros.htm");
            GxWebStd.gx_bitmap( context, edtObreFchNac_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtObreFchNac_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Obreros.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtObreEdad_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtObreEdad_Internalname, "Edad", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtObreEdad_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A246ObreEdad), 4, 0, ",", "")), ((edtObreEdad_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A246ObreEdad), "ZZZ9")) : context.localUtil.Format( (decimal)(A246ObreEdad), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtObreEdad_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtObreEdad_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Obreros.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtObreDir_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtObreDir_Internalname, "Direccion", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtObreDir_Internalname, A247ObreDir, StringUtil.RTrim( context.localUtil.Format( A247ObreDir, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,80);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtObreDir_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtObreDir_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Obreros.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtObreEmail_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtObreEmail_Internalname, "Email", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 85,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtObreEmail_Internalname, A250ObreEmail, StringUtil.RTrim( context.localUtil.Format( A250ObreEmail, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,85);\"", "'"+""+"'"+",false,"+"'"+""+"'", "mailto:"+A250ObreEmail, "", "", "", edtObreEmail_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtObreEmail_Enabled, 0, "email", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, 0, true, "GeneXus\\Email", "left", true, "HLP_Obreros.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtObreTelf_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtObreTelf_Internalname, "Telf/Celu", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 90,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtObreTelf_Internalname, StringUtil.RTrim( A248ObreTelf), StringUtil.RTrim( context.localUtil.Format( A248ObreTelf, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,90);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtObreTelf_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtObreTelf_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Obreros.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkObreEst_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkObreEst_Internalname, "Estado", "col-sm-3 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 95,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkObreEst_Internalname, A249ObreEst, "", "Estado", 1, chkObreEst.Enabled, "A", "Activo?", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(95, this, 'A', 'I');gx.evt.onchange(this, event);\" ");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 100,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Obreros.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 102,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Obreros.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 104,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Obreros.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm0R42( ) ;
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
         E110R2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtObreID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtObreID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "OBREID");
                  AnyError = 1;
                  GX_FocusControl = edtObreID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A238ObreID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A238ObreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A238ObreID), 4, 0)));
               }
               else
               {
                  A238ObreID = (short)(context.localUtil.CToN( cgiGet( edtObreID_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A238ObreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A238ObreID), 4, 0)));
               }
               A239ObreCedula = cgiGet( edtObreCedula_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A239ObreCedula", A239ObreCedula);
               A242ObrePrApellido = cgiGet( edtObrePrApellido_Internalname);
               n242ObrePrApellido = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A242ObrePrApellido", A242ObrePrApellido);
               n242ObrePrApellido = (String.IsNullOrEmpty(StringUtil.RTrim( A242ObrePrApellido)) ? true : false);
               A243ObreSegApellido = cgiGet( edtObreSegApellido_Internalname);
               n243ObreSegApellido = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A243ObreSegApellido", A243ObreSegApellido);
               n243ObreSegApellido = (String.IsNullOrEmpty(StringUtil.RTrim( A243ObreSegApellido)) ? true : false);
               A240ObrePrNombre = cgiGet( edtObrePrNombre_Internalname);
               n240ObrePrNombre = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A240ObrePrNombre", A240ObrePrNombre);
               n240ObrePrNombre = (String.IsNullOrEmpty(StringUtil.RTrim( A240ObrePrNombre)) ? true : false);
               A241ObreSegNombre = cgiGet( edtObreSegNombre_Internalname);
               n241ObreSegNombre = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A241ObreSegNombre", A241ObreSegNombre);
               n241ObreSegNombre = (String.IsNullOrEmpty(StringUtil.RTrim( A241ObreSegNombre)) ? true : false);
               A244ObreNombre = cgiGet( edtObreNombre_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A244ObreNombre", A244ObreNombre);
               if ( context.localUtil.VCDate( cgiGet( edtObreFchNac_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha Nac"}), 1, "OBREFCHNAC");
                  AnyError = 1;
                  GX_FocusControl = edtObreFchNac_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A245ObreFchNac = DateTime.MinValue;
                  n245ObreFchNac = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A245ObreFchNac", context.localUtil.Format(A245ObreFchNac, "99/99/9999"));
               }
               else
               {
                  A245ObreFchNac = context.localUtil.CToD( cgiGet( edtObreFchNac_Internalname), 2);
                  n245ObreFchNac = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A245ObreFchNac", context.localUtil.Format(A245ObreFchNac, "99/99/9999"));
               }
               n245ObreFchNac = ((DateTime.MinValue==A245ObreFchNac) ? true : false);
               A246ObreEdad = (short)(context.localUtil.CToN( cgiGet( edtObreEdad_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A246ObreEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(A246ObreEdad), 4, 0)));
               A247ObreDir = cgiGet( edtObreDir_Internalname);
               n247ObreDir = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247ObreDir", A247ObreDir);
               n247ObreDir = (String.IsNullOrEmpty(StringUtil.RTrim( A247ObreDir)) ? true : false);
               A250ObreEmail = cgiGet( edtObreEmail_Internalname);
               n250ObreEmail = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A250ObreEmail", A250ObreEmail);
               n250ObreEmail = (String.IsNullOrEmpty(StringUtil.RTrim( A250ObreEmail)) ? true : false);
               A248ObreTelf = cgiGet( edtObreTelf_Internalname);
               n248ObreTelf = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A248ObreTelf", A248ObreTelf);
               n248ObreTelf = (String.IsNullOrEmpty(StringUtil.RTrim( A248ObreTelf)) ? true : false);
               A249ObreEst = ((StringUtil.StrCmp(cgiGet( chkObreEst_Internalname), "A")==0) ? "A" : "I");
               n249ObreEst = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A249ObreEst", A249ObreEst);
               n249ObreEst = (String.IsNullOrEmpty(StringUtil.RTrim( A249ObreEst)) ? true : false);
               /* Read saved values. */
               Z238ObreID = (short)(context.localUtil.CToN( cgiGet( "Z238ObreID"), ",", "."));
               Z239ObreCedula = cgiGet( "Z239ObreCedula");
               Z240ObrePrNombre = cgiGet( "Z240ObrePrNombre");
               n240ObrePrNombre = (String.IsNullOrEmpty(StringUtil.RTrim( A240ObrePrNombre)) ? true : false);
               Z241ObreSegNombre = cgiGet( "Z241ObreSegNombre");
               n241ObreSegNombre = (String.IsNullOrEmpty(StringUtil.RTrim( A241ObreSegNombre)) ? true : false);
               Z242ObrePrApellido = cgiGet( "Z242ObrePrApellido");
               n242ObrePrApellido = (String.IsNullOrEmpty(StringUtil.RTrim( A242ObrePrApellido)) ? true : false);
               Z243ObreSegApellido = cgiGet( "Z243ObreSegApellido");
               n243ObreSegApellido = (String.IsNullOrEmpty(StringUtil.RTrim( A243ObreSegApellido)) ? true : false);
               Z245ObreFchNac = context.localUtil.CToD( cgiGet( "Z245ObreFchNac"), 0);
               n245ObreFchNac = ((DateTime.MinValue==A245ObreFchNac) ? true : false);
               Z247ObreDir = cgiGet( "Z247ObreDir");
               n247ObreDir = (String.IsNullOrEmpty(StringUtil.RTrim( A247ObreDir)) ? true : false);
               Z248ObreTelf = cgiGet( "Z248ObreTelf");
               n248ObreTelf = (String.IsNullOrEmpty(StringUtil.RTrim( A248ObreTelf)) ? true : false);
               Z250ObreEmail = cgiGet( "Z250ObreEmail");
               n250ObreEmail = (String.IsNullOrEmpty(StringUtil.RTrim( A250ObreEmail)) ? true : false);
               Z249ObreEst = cgiGet( "Z249ObreEst");
               n249ObreEst = (String.IsNullOrEmpty(StringUtil.RTrim( A249ObreEst)) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               AV7ObreID = (short)(context.localUtil.CToN( cgiGet( "vOBREID"), ",", "."));
               AV11ObreCedula = cgiGet( "vOBRECEDULA");
               AV13Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Obreros";
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A238ObreID != Z238ObreID ) || ( StringUtil.StrCmp(A239ObreCedula, Z239ObreCedula) != 0 ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("obreros:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A238ObreID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A238ObreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A238ObreID), 4, 0)));
                  A239ObreCedula = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A239ObreCedula", A239ObreCedula);
                  getEqualNoModal( ) ;
                  if ( ! (0==AV7ObreID) )
                  {
                     A238ObreID = AV7ObreID;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A238ObreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A238ObreID), 4, 0)));
                  }
                  else
                  {
                     if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
                     {
                        GXt_int1 = A238ObreID;
                        new obtulnroobrero(context ).execute( out  GXt_int1) ;
                        A238ObreID = GXt_int1;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A238ObreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A238ObreID), 4, 0)));
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
                     sMode42 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     if ( ! (0==AV7ObreID) )
                     {
                        A238ObreID = AV7ObreID;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A238ObreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A238ObreID), 4, 0)));
                     }
                     else
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
                        {
                           GXt_int1 = A238ObreID;
                           new obtulnroobrero(context ).execute( out  GXt_int1) ;
                           A238ObreID = GXt_int1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A238ObreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A238ObreID), 4, 0)));
                        }
                     }
                     Gx_mode = sMode42;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound42 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0R0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "OBREID");
                        AnyError = 1;
                        GX_FocusControl = edtObreID_Internalname;
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
                        E110R2 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: After Trn */
                        E120R2 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "OBRECEDULA.CONTROLVALUECHANGED") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        E130R2 ();
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
            E120R2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0R42( ) ;
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
            DisableAttributes0R42( ) ;
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

      protected void CONFIRM_0R0( )
      {
         BeforeValidate0R42( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0R42( ) ;
            }
            else
            {
               CheckExtendedTable0R42( ) ;
               CloseExtendedTableCursors0R42( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0R0( )
      {
      }

      protected void E110R2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV13Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "KBCalpesa22");
      }

      protected void E120R2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwobreros.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void E130R2( )
      {
         /* ObreCedula_Controlvaluechanged Routine */
         GXt_char2 = AV12existe;
         new validcedulaobreros(context ).execute(  A239ObreCedula, out  GXt_char2) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A239ObreCedula", A239ObreCedula);
         AV12existe = GXt_char2;
         if ( StringUtil.StrCmp(AV12existe, "SI") == 0 )
         {
            GX_msglist.addItem("Cedula ya está registrada");
         }
      }

      protected void ZM0R42( short GX_JID )
      {
         if ( ( GX_JID == 11 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z240ObrePrNombre = T000R3_A240ObrePrNombre[0];
               Z241ObreSegNombre = T000R3_A241ObreSegNombre[0];
               Z242ObrePrApellido = T000R3_A242ObrePrApellido[0];
               Z243ObreSegApellido = T000R3_A243ObreSegApellido[0];
               Z245ObreFchNac = T000R3_A245ObreFchNac[0];
               Z247ObreDir = T000R3_A247ObreDir[0];
               Z248ObreTelf = T000R3_A248ObreTelf[0];
               Z250ObreEmail = T000R3_A250ObreEmail[0];
               Z249ObreEst = T000R3_A249ObreEst[0];
            }
            else
            {
               Z240ObrePrNombre = A240ObrePrNombre;
               Z241ObreSegNombre = A241ObreSegNombre;
               Z242ObrePrApellido = A242ObrePrApellido;
               Z243ObreSegApellido = A243ObreSegApellido;
               Z245ObreFchNac = A245ObreFchNac;
               Z247ObreDir = A247ObreDir;
               Z248ObreTelf = A248ObreTelf;
               Z250ObreEmail = A250ObreEmail;
               Z249ObreEst = A249ObreEst;
            }
         }
         if ( GX_JID == -11 )
         {
            Z238ObreID = A238ObreID;
            Z239ObreCedula = A239ObreCedula;
            Z240ObrePrNombre = A240ObrePrNombre;
            Z241ObreSegNombre = A241ObreSegNombre;
            Z242ObrePrApellido = A242ObrePrApellido;
            Z243ObreSegApellido = A243ObreSegApellido;
            Z245ObreFchNac = A245ObreFchNac;
            Z247ObreDir = A247ObreDir;
            Z248ObreTelf = A248ObreTelf;
            Z250ObreEmail = A250ObreEmail;
            Z249ObreEst = A249ObreEst;
         }
      }

      protected void standaloneNotModal( )
      {
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7ObreID) )
         {
            edtObreID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtObreID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtObreID_Enabled), 5, 0)), true);
         }
         else
         {
            edtObreID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtObreID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtObreID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV7ObreID) )
         {
            edtObreID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtObreID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtObreID_Enabled), 5, 0)), true);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11ObreCedula)) )
         {
            A239ObreCedula = AV11ObreCedula;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A239ObreCedula", A239ObreCedula);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11ObreCedula)) )
         {
            edtObreCedula_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtObreCedula_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtObreCedula_Enabled), 5, 0)), true);
         }
         else
         {
            edtObreCedula_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtObreCedula_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtObreCedula_Enabled), 5, 0)), true);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11ObreCedula)) )
         {
            edtObreCedula_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtObreCedula_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtObreCedula_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ! (0==AV7ObreID) )
         {
            A238ObreID = AV7ObreID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A238ObreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A238ObreID), 4, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               GXt_int1 = A238ObreID;
               new obtulnroobrero(context ).execute( out  GXt_int1) ;
               A238ObreID = GXt_int1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A238ObreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A238ObreID), 4, 0)));
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
            AV13Pgmname = "Obreros";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
         }
      }

      protected void Load0R42( )
      {
         /* Using cursor T000R4 */
         pr_default.execute(2, new Object[] {A238ObreID, A239ObreCedula});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound42 = 1;
            A240ObrePrNombre = T000R4_A240ObrePrNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A240ObrePrNombre", A240ObrePrNombre);
            n240ObrePrNombre = T000R4_n240ObrePrNombre[0];
            A241ObreSegNombre = T000R4_A241ObreSegNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A241ObreSegNombre", A241ObreSegNombre);
            n241ObreSegNombre = T000R4_n241ObreSegNombre[0];
            A242ObrePrApellido = T000R4_A242ObrePrApellido[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A242ObrePrApellido", A242ObrePrApellido);
            n242ObrePrApellido = T000R4_n242ObrePrApellido[0];
            A243ObreSegApellido = T000R4_A243ObreSegApellido[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A243ObreSegApellido", A243ObreSegApellido);
            n243ObreSegApellido = T000R4_n243ObreSegApellido[0];
            A245ObreFchNac = T000R4_A245ObreFchNac[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A245ObreFchNac", context.localUtil.Format(A245ObreFchNac, "99/99/9999"));
            n245ObreFchNac = T000R4_n245ObreFchNac[0];
            A247ObreDir = T000R4_A247ObreDir[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247ObreDir", A247ObreDir);
            n247ObreDir = T000R4_n247ObreDir[0];
            A248ObreTelf = T000R4_A248ObreTelf[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A248ObreTelf", A248ObreTelf);
            n248ObreTelf = T000R4_n248ObreTelf[0];
            A250ObreEmail = T000R4_A250ObreEmail[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A250ObreEmail", A250ObreEmail);
            n250ObreEmail = T000R4_n250ObreEmail[0];
            A249ObreEst = T000R4_A249ObreEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A249ObreEst", A249ObreEst);
            n249ObreEst = T000R4_n249ObreEst[0];
            ZM0R42( -11) ;
         }
         pr_default.close(2);
         OnLoadActions0R42( ) ;
      }

      protected void OnLoadActions0R42( )
      {
         AV13Pgmname = "Obreros";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
         A244ObreNombre = StringUtil.Trim( A242ObrePrApellido) + " " + StringUtil.Trim( A243ObreSegApellido) + " " + StringUtil.Trim( A240ObrePrNombre) + " " + StringUtil.Trim( A241ObreSegNombre);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A244ObreNombre", A244ObreNombre);
         A246ObreEdad = (short)(DateTimeUtil.Year( DateTimeUtil.ServerNow( context, pr_default))-DateTimeUtil.Year( A245ObreFchNac));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A246ObreEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(A246ObreEdad), 4, 0)));
      }

      protected void CheckExtendedTable0R42( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV13Pgmname = "Obreros";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
         A244ObreNombre = StringUtil.Trim( A242ObrePrApellido) + " " + StringUtil.Trim( A243ObreSegApellido) + " " + StringUtil.Trim( A240ObrePrNombre) + " " + StringUtil.Trim( A241ObreSegNombre);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A244ObreNombre", A244ObreNombre);
         if ( ! ( (DateTime.MinValue==A245ObreFchNac) || ( A245ObreFchNac >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha Nac fuera de rango", "OutOfRange", 1, "OBREFCHNAC");
            AnyError = 1;
            GX_FocusControl = edtObreFchNac_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A246ObreEdad = (short)(DateTimeUtil.Year( DateTimeUtil.ServerNow( context, pr_default))-DateTimeUtil.Year( A245ObreFchNac));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A246ObreEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(A246ObreEdad), 4, 0)));
         if ( ! ( GxRegex.IsMatch(A250ObreEmail,"^((\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*)|(\\s*))$") || String.IsNullOrEmpty(StringUtil.RTrim( A250ObreEmail)) ) )
         {
            GX_msglist.addItem("El valor de Email no coincide con el patrón especificado", "OutOfRange", 1, "OBREEMAIL");
            AnyError = 1;
            GX_FocusControl = edtObreEmail_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0R42( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0R42( )
      {
         /* Using cursor T000R5 */
         pr_default.execute(3, new Object[] {A238ObreID, A239ObreCedula});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound42 = 1;
         }
         else
         {
            RcdFound42 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000R3 */
         pr_default.execute(1, new Object[] {A238ObreID, A239ObreCedula});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0R42( 11) ;
            RcdFound42 = 1;
            A238ObreID = T000R3_A238ObreID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A238ObreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A238ObreID), 4, 0)));
            A239ObreCedula = T000R3_A239ObreCedula[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A239ObreCedula", A239ObreCedula);
            A240ObrePrNombre = T000R3_A240ObrePrNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A240ObrePrNombre", A240ObrePrNombre);
            n240ObrePrNombre = T000R3_n240ObrePrNombre[0];
            A241ObreSegNombre = T000R3_A241ObreSegNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A241ObreSegNombre", A241ObreSegNombre);
            n241ObreSegNombre = T000R3_n241ObreSegNombre[0];
            A242ObrePrApellido = T000R3_A242ObrePrApellido[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A242ObrePrApellido", A242ObrePrApellido);
            n242ObrePrApellido = T000R3_n242ObrePrApellido[0];
            A243ObreSegApellido = T000R3_A243ObreSegApellido[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A243ObreSegApellido", A243ObreSegApellido);
            n243ObreSegApellido = T000R3_n243ObreSegApellido[0];
            A245ObreFchNac = T000R3_A245ObreFchNac[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A245ObreFchNac", context.localUtil.Format(A245ObreFchNac, "99/99/9999"));
            n245ObreFchNac = T000R3_n245ObreFchNac[0];
            A247ObreDir = T000R3_A247ObreDir[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247ObreDir", A247ObreDir);
            n247ObreDir = T000R3_n247ObreDir[0];
            A248ObreTelf = T000R3_A248ObreTelf[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A248ObreTelf", A248ObreTelf);
            n248ObreTelf = T000R3_n248ObreTelf[0];
            A250ObreEmail = T000R3_A250ObreEmail[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A250ObreEmail", A250ObreEmail);
            n250ObreEmail = T000R3_n250ObreEmail[0];
            A249ObreEst = T000R3_A249ObreEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A249ObreEst", A249ObreEst);
            n249ObreEst = T000R3_n249ObreEst[0];
            Z238ObreID = A238ObreID;
            Z239ObreCedula = A239ObreCedula;
            sMode42 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0R42( ) ;
            if ( AnyError == 1 )
            {
               RcdFound42 = 0;
               InitializeNonKey0R42( ) ;
            }
            Gx_mode = sMode42;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound42 = 0;
            InitializeNonKey0R42( ) ;
            sMode42 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode42;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0R42( ) ;
         if ( RcdFound42 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound42 = 0;
         /* Using cursor T000R6 */
         pr_default.execute(4, new Object[] {A238ObreID, A239ObreCedula});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T000R6_A238ObreID[0] < A238ObreID ) || ( T000R6_A238ObreID[0] == A238ObreID ) && ( StringUtil.StrCmp(T000R6_A239ObreCedula[0], A239ObreCedula) < 0 ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T000R6_A238ObreID[0] > A238ObreID ) || ( T000R6_A238ObreID[0] == A238ObreID ) && ( StringUtil.StrCmp(T000R6_A239ObreCedula[0], A239ObreCedula) > 0 ) ) )
            {
               A238ObreID = T000R6_A238ObreID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A238ObreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A238ObreID), 4, 0)));
               A239ObreCedula = T000R6_A239ObreCedula[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A239ObreCedula", A239ObreCedula);
               RcdFound42 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound42 = 0;
         /* Using cursor T000R7 */
         pr_default.execute(5, new Object[] {A238ObreID, A239ObreCedula});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T000R7_A238ObreID[0] > A238ObreID ) || ( T000R7_A238ObreID[0] == A238ObreID ) && ( StringUtil.StrCmp(T000R7_A239ObreCedula[0], A239ObreCedula) > 0 ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T000R7_A238ObreID[0] < A238ObreID ) || ( T000R7_A238ObreID[0] == A238ObreID ) && ( StringUtil.StrCmp(T000R7_A239ObreCedula[0], A239ObreCedula) < 0 ) ) )
            {
               A238ObreID = T000R7_A238ObreID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A238ObreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A238ObreID), 4, 0)));
               A239ObreCedula = T000R7_A239ObreCedula[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A239ObreCedula", A239ObreCedula);
               RcdFound42 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0R42( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtObreID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0R42( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound42 == 1 )
            {
               if ( ( A238ObreID != Z238ObreID ) || ( StringUtil.StrCmp(A239ObreCedula, Z239ObreCedula) != 0 ) )
               {
                  A238ObreID = Z238ObreID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A238ObreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A238ObreID), 4, 0)));
                  A239ObreCedula = Z239ObreCedula;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A239ObreCedula", A239ObreCedula);
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "OBREID");
                  AnyError = 1;
                  GX_FocusControl = edtObreID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtObreID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0R42( ) ;
                  GX_FocusControl = edtObreID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A238ObreID != Z238ObreID ) || ( StringUtil.StrCmp(A239ObreCedula, Z239ObreCedula) != 0 ) )
               {
                  /* Insert record */
                  GX_FocusControl = edtObreID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0R42( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "OBREID");
                     AnyError = 1;
                     GX_FocusControl = edtObreID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtObreID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0R42( ) ;
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
         if ( ( A238ObreID != Z238ObreID ) || ( StringUtil.StrCmp(A239ObreCedula, Z239ObreCedula) != 0 ) )
         {
            A238ObreID = Z238ObreID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A238ObreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A238ObreID), 4, 0)));
            A239ObreCedula = Z239ObreCedula;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A239ObreCedula", A239ObreCedula);
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "OBREID");
            AnyError = 1;
            GX_FocusControl = edtObreID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtObreID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0R42( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000R2 */
            pr_default.execute(0, new Object[] {A238ObreID, A239ObreCedula});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Obreros"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z240ObrePrNombre, T000R2_A240ObrePrNombre[0]) != 0 ) || ( StringUtil.StrCmp(Z241ObreSegNombre, T000R2_A241ObreSegNombre[0]) != 0 ) || ( StringUtil.StrCmp(Z242ObrePrApellido, T000R2_A242ObrePrApellido[0]) != 0 ) || ( StringUtil.StrCmp(Z243ObreSegApellido, T000R2_A243ObreSegApellido[0]) != 0 ) || ( Z245ObreFchNac != T000R2_A245ObreFchNac[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z247ObreDir, T000R2_A247ObreDir[0]) != 0 ) || ( StringUtil.StrCmp(Z248ObreTelf, T000R2_A248ObreTelf[0]) != 0 ) || ( StringUtil.StrCmp(Z250ObreEmail, T000R2_A250ObreEmail[0]) != 0 ) || ( StringUtil.StrCmp(Z249ObreEst, T000R2_A249ObreEst[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z240ObrePrNombre, T000R2_A240ObrePrNombre[0]) != 0 )
               {
                  GXUtil.WriteLog("obreros:[seudo value changed for attri]"+"ObrePrNombre");
                  GXUtil.WriteLogRaw("Old: ",Z240ObrePrNombre);
                  GXUtil.WriteLogRaw("Current: ",T000R2_A240ObrePrNombre[0]);
               }
               if ( StringUtil.StrCmp(Z241ObreSegNombre, T000R2_A241ObreSegNombre[0]) != 0 )
               {
                  GXUtil.WriteLog("obreros:[seudo value changed for attri]"+"ObreSegNombre");
                  GXUtil.WriteLogRaw("Old: ",Z241ObreSegNombre);
                  GXUtil.WriteLogRaw("Current: ",T000R2_A241ObreSegNombre[0]);
               }
               if ( StringUtil.StrCmp(Z242ObrePrApellido, T000R2_A242ObrePrApellido[0]) != 0 )
               {
                  GXUtil.WriteLog("obreros:[seudo value changed for attri]"+"ObrePrApellido");
                  GXUtil.WriteLogRaw("Old: ",Z242ObrePrApellido);
                  GXUtil.WriteLogRaw("Current: ",T000R2_A242ObrePrApellido[0]);
               }
               if ( StringUtil.StrCmp(Z243ObreSegApellido, T000R2_A243ObreSegApellido[0]) != 0 )
               {
                  GXUtil.WriteLog("obreros:[seudo value changed for attri]"+"ObreSegApellido");
                  GXUtil.WriteLogRaw("Old: ",Z243ObreSegApellido);
                  GXUtil.WriteLogRaw("Current: ",T000R2_A243ObreSegApellido[0]);
               }
               if ( Z245ObreFchNac != T000R2_A245ObreFchNac[0] )
               {
                  GXUtil.WriteLog("obreros:[seudo value changed for attri]"+"ObreFchNac");
                  GXUtil.WriteLogRaw("Old: ",Z245ObreFchNac);
                  GXUtil.WriteLogRaw("Current: ",T000R2_A245ObreFchNac[0]);
               }
               if ( StringUtil.StrCmp(Z247ObreDir, T000R2_A247ObreDir[0]) != 0 )
               {
                  GXUtil.WriteLog("obreros:[seudo value changed for attri]"+"ObreDir");
                  GXUtil.WriteLogRaw("Old: ",Z247ObreDir);
                  GXUtil.WriteLogRaw("Current: ",T000R2_A247ObreDir[0]);
               }
               if ( StringUtil.StrCmp(Z248ObreTelf, T000R2_A248ObreTelf[0]) != 0 )
               {
                  GXUtil.WriteLog("obreros:[seudo value changed for attri]"+"ObreTelf");
                  GXUtil.WriteLogRaw("Old: ",Z248ObreTelf);
                  GXUtil.WriteLogRaw("Current: ",T000R2_A248ObreTelf[0]);
               }
               if ( StringUtil.StrCmp(Z250ObreEmail, T000R2_A250ObreEmail[0]) != 0 )
               {
                  GXUtil.WriteLog("obreros:[seudo value changed for attri]"+"ObreEmail");
                  GXUtil.WriteLogRaw("Old: ",Z250ObreEmail);
                  GXUtil.WriteLogRaw("Current: ",T000R2_A250ObreEmail[0]);
               }
               if ( StringUtil.StrCmp(Z249ObreEst, T000R2_A249ObreEst[0]) != 0 )
               {
                  GXUtil.WriteLog("obreros:[seudo value changed for attri]"+"ObreEst");
                  GXUtil.WriteLogRaw("Old: ",Z249ObreEst);
                  GXUtil.WriteLogRaw("Current: ",T000R2_A249ObreEst[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Obreros"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0R42( )
      {
         BeforeValidate0R42( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0R42( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0R42( 0) ;
            CheckOptimisticConcurrency0R42( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0R42( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0R42( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000R8 */
                     pr_default.execute(6, new Object[] {A238ObreID, A239ObreCedula, n240ObrePrNombre, A240ObrePrNombre, n241ObreSegNombre, A241ObreSegNombre, n242ObrePrApellido, A242ObrePrApellido, n243ObreSegApellido, A243ObreSegApellido, n245ObreFchNac, A245ObreFchNac, n247ObreDir, A247ObreDir, n248ObreTelf, A248ObreTelf, n250ObreEmail, A250ObreEmail, n249ObreEst, A249ObreEst});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("Obreros") ;
                     if ( (pr_default.getStatus(6) == 1) )
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
                           ResetCaption0R0( ) ;
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
               Load0R42( ) ;
            }
            EndLevel0R42( ) ;
         }
         CloseExtendedTableCursors0R42( ) ;
      }

      protected void Update0R42( )
      {
         BeforeValidate0R42( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0R42( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0R42( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0R42( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0R42( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000R9 */
                     pr_default.execute(7, new Object[] {n240ObrePrNombre, A240ObrePrNombre, n241ObreSegNombre, A241ObreSegNombre, n242ObrePrApellido, A242ObrePrApellido, n243ObreSegApellido, A243ObreSegApellido, n245ObreFchNac, A245ObreFchNac, n247ObreDir, A247ObreDir, n248ObreTelf, A248ObreTelf, n250ObreEmail, A250ObreEmail, n249ObreEst, A249ObreEst, A238ObreID, A239ObreCedula});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("Obreros") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Obreros"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0R42( ) ;
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
            EndLevel0R42( ) ;
         }
         CloseExtendedTableCursors0R42( ) ;
      }

      protected void DeferredUpdate0R42( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0R42( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0R42( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0R42( ) ;
            AfterConfirm0R42( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0R42( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000R10 */
                  pr_default.execute(8, new Object[] {A238ObreID, A239ObreCedula});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("Obreros") ;
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
         sMode42 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0R42( ) ;
         Gx_mode = sMode42;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0R42( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV13Pgmname = "Obreros";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
            A244ObreNombre = StringUtil.Trim( A242ObrePrApellido) + " " + StringUtil.Trim( A243ObreSegApellido) + " " + StringUtil.Trim( A240ObrePrNombre) + " " + StringUtil.Trim( A241ObreSegNombre);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A244ObreNombre", A244ObreNombre);
            A246ObreEdad = (short)(DateTimeUtil.Year( DateTimeUtil.ServerNow( context, pr_default))-DateTimeUtil.Year( A245ObreFchNac));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A246ObreEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(A246ObreEdad), 4, 0)));
         }
      }

      protected void EndLevel0R42( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0R42( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("obreros",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0R0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("obreros",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0R42( )
      {
         /* Scan By routine */
         /* Using cursor T000R11 */
         pr_default.execute(9);
         RcdFound42 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound42 = 1;
            A238ObreID = T000R11_A238ObreID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A238ObreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A238ObreID), 4, 0)));
            A239ObreCedula = T000R11_A239ObreCedula[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A239ObreCedula", A239ObreCedula);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0R42( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound42 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound42 = 1;
            A238ObreID = T000R11_A238ObreID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A238ObreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A238ObreID), 4, 0)));
            A239ObreCedula = T000R11_A239ObreCedula[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A239ObreCedula", A239ObreCedula);
         }
      }

      protected void ScanEnd0R42( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm0R42( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0R42( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0R42( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0R42( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0R42( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0R42( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0R42( )
      {
         edtObreID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtObreID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtObreID_Enabled), 5, 0)), true);
         edtObreCedula_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtObreCedula_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtObreCedula_Enabled), 5, 0)), true);
         edtObrePrApellido_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtObrePrApellido_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtObrePrApellido_Enabled), 5, 0)), true);
         edtObreSegApellido_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtObreSegApellido_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtObreSegApellido_Enabled), 5, 0)), true);
         edtObrePrNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtObrePrNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtObrePrNombre_Enabled), 5, 0)), true);
         edtObreSegNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtObreSegNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtObreSegNombre_Enabled), 5, 0)), true);
         edtObreNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtObreNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtObreNombre_Enabled), 5, 0)), true);
         edtObreFchNac_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtObreFchNac_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtObreFchNac_Enabled), 5, 0)), true);
         edtObreEdad_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtObreEdad_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtObreEdad_Enabled), 5, 0)), true);
         edtObreDir_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtObreDir_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtObreDir_Enabled), 5, 0)), true);
         edtObreEmail_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtObreEmail_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtObreEmail_Enabled), 5, 0)), true);
         edtObreTelf_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtObreTelf_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtObreTelf_Enabled), 5, 0)), true);
         chkObreEst.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkObreEst_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkObreEst.Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0R42( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0R0( )
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
         context.SendWebValue( "Obreros") ;
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
         context.AddJavascriptSource("gxcfg.js", "?202210262014131", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("obreros.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7ObreID) + "," + UrlEncode(StringUtil.RTrim(AV11ObreCedula))+"\">") ;
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
         forbiddenHiddens = "hsh" + "Obreros";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("obreros:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z238ObreID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z238ObreID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z239ObreCedula", StringUtil.RTrim( Z239ObreCedula));
         GxWebStd.gx_hidden_field( context, "Z240ObrePrNombre", Z240ObrePrNombre);
         GxWebStd.gx_hidden_field( context, "Z241ObreSegNombre", Z241ObreSegNombre);
         GxWebStd.gx_hidden_field( context, "Z242ObrePrApellido", Z242ObrePrApellido);
         GxWebStd.gx_hidden_field( context, "Z243ObreSegApellido", Z243ObreSegApellido);
         GxWebStd.gx_hidden_field( context, "Z245ObreFchNac", context.localUtil.DToC( Z245ObreFchNac, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z247ObreDir", Z247ObreDir);
         GxWebStd.gx_hidden_field( context, "Z248ObreTelf", StringUtil.RTrim( Z248ObreTelf));
         GxWebStd.gx_hidden_field( context, "Z250ObreEmail", Z250ObreEmail);
         GxWebStd.gx_hidden_field( context, "Z249ObreEst", StringUtil.RTrim( Z249ObreEst));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vOBREID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7ObreID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vOBREID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7ObreID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vOBRECEDULA", StringUtil.RTrim( AV11ObreCedula));
         GxWebStd.gx_hidden_field( context, "gxhash_vOBRECEDULA", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV11ObreCedula, "")), context));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV13Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void RenderHtmlCloseForm0R42( )
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
         return "Obreros" ;
      }

      public override String GetPgmdesc( )
      {
         return "Obreros" ;
      }

      protected void InitializeNonKey0R42( )
      {
         A246ObreEdad = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A246ObreEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(A246ObreEdad), 4, 0)));
         A244ObreNombre = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A244ObreNombre", A244ObreNombre);
         A240ObrePrNombre = "";
         n240ObrePrNombre = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A240ObrePrNombre", A240ObrePrNombre);
         n240ObrePrNombre = (String.IsNullOrEmpty(StringUtil.RTrim( A240ObrePrNombre)) ? true : false);
         A241ObreSegNombre = "";
         n241ObreSegNombre = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A241ObreSegNombre", A241ObreSegNombre);
         n241ObreSegNombre = (String.IsNullOrEmpty(StringUtil.RTrim( A241ObreSegNombre)) ? true : false);
         A242ObrePrApellido = "";
         n242ObrePrApellido = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A242ObrePrApellido", A242ObrePrApellido);
         n242ObrePrApellido = (String.IsNullOrEmpty(StringUtil.RTrim( A242ObrePrApellido)) ? true : false);
         A243ObreSegApellido = "";
         n243ObreSegApellido = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A243ObreSegApellido", A243ObreSegApellido);
         n243ObreSegApellido = (String.IsNullOrEmpty(StringUtil.RTrim( A243ObreSegApellido)) ? true : false);
         A245ObreFchNac = DateTime.MinValue;
         n245ObreFchNac = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A245ObreFchNac", context.localUtil.Format(A245ObreFchNac, "99/99/9999"));
         n245ObreFchNac = ((DateTime.MinValue==A245ObreFchNac) ? true : false);
         A247ObreDir = "";
         n247ObreDir = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247ObreDir", A247ObreDir);
         n247ObreDir = (String.IsNullOrEmpty(StringUtil.RTrim( A247ObreDir)) ? true : false);
         A248ObreTelf = "";
         n248ObreTelf = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A248ObreTelf", A248ObreTelf);
         n248ObreTelf = (String.IsNullOrEmpty(StringUtil.RTrim( A248ObreTelf)) ? true : false);
         A250ObreEmail = "";
         n250ObreEmail = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A250ObreEmail", A250ObreEmail);
         n250ObreEmail = (String.IsNullOrEmpty(StringUtil.RTrim( A250ObreEmail)) ? true : false);
         A249ObreEst = "";
         n249ObreEst = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A249ObreEst", A249ObreEst);
         n249ObreEst = (String.IsNullOrEmpty(StringUtil.RTrim( A249ObreEst)) ? true : false);
         Z240ObrePrNombre = "";
         Z241ObreSegNombre = "";
         Z242ObrePrApellido = "";
         Z243ObreSegApellido = "";
         Z245ObreFchNac = DateTime.MinValue;
         Z247ObreDir = "";
         Z248ObreTelf = "";
         Z250ObreEmail = "";
         Z249ObreEst = "";
      }

      protected void InitAll0R42( )
      {
         A238ObreID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A238ObreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A238ObreID), 4, 0)));
         A239ObreCedula = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A239ObreCedula", A239ObreCedula);
         InitializeNonKey0R42( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022102620141310", true);
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
         context.AddJavascriptSource("obreros.js", "?2022102620141310", false);
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
         edtObreID_Internalname = "OBREID";
         edtObreCedula_Internalname = "OBRECEDULA";
         edtObrePrApellido_Internalname = "OBREPRAPELLIDO";
         divSeccape1_Internalname = "SECCAPE1";
         edtObreSegApellido_Internalname = "OBRESEGAPELLIDO";
         divSeccape2_Internalname = "SECCAPE2";
         edtObrePrNombre_Internalname = "OBREPRNOMBRE";
         divSeccname1_Internalname = "SECCNAME1";
         edtObreSegNombre_Internalname = "OBRESEGNOMBRE";
         divSeccname2_Internalname = "SECCNAME2";
         edtObreNombre_Internalname = "OBRENOMBRE";
         edtObreFchNac_Internalname = "OBREFCHNAC";
         edtObreEdad_Internalname = "OBREEDAD";
         edtObreDir_Internalname = "OBREDIR";
         edtObreEmail_Internalname = "OBREEMAIL";
         edtObreTelf_Internalname = "OBRETELF";
         chkObreEst_Internalname = "OBREEST";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
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
         chkObreEst.Enabled = 1;
         edtObreTelf_Jsonclick = "";
         edtObreTelf_Enabled = 1;
         edtObreEmail_Jsonclick = "";
         edtObreEmail_Enabled = 1;
         edtObreDir_Jsonclick = "";
         edtObreDir_Enabled = 1;
         edtObreEdad_Jsonclick = "";
         edtObreEdad_Enabled = 0;
         edtObreFchNac_Jsonclick = "";
         edtObreFchNac_Enabled = 1;
         edtObreNombre_Jsonclick = "";
         edtObreNombre_Enabled = 0;
         edtObreSegNombre_Jsonclick = "";
         edtObreSegNombre_Enabled = 1;
         edtObrePrNombre_Jsonclick = "";
         edtObrePrNombre_Enabled = 1;
         edtObreSegApellido_Jsonclick = "";
         edtObreSegApellido_Enabled = 1;
         edtObrePrApellido_Jsonclick = "";
         edtObrePrApellido_Enabled = 1;
         edtObreCedula_Jsonclick = "";
         edtObreCedula_Enabled = 1;
         edtObreID_Jsonclick = "";
         edtObreID_Enabled = 1;
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

      protected void GX5ASAOBREID0R42( short AV7ObreID )
      {
         if ( ! (0==AV7ObreID) )
         {
            A238ObreID = AV7ObreID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A238ObreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A238ObreID), 4, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               GXt_int1 = A238ObreID;
               new obtulnroobrero(context ).execute( out  GXt_int1) ;
               A238ObreID = GXt_int1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A238ObreID", StringUtil.LTrim( StringUtil.Str( (decimal)(A238ObreID), 4, 0)));
            }
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A238ObreID), 4, 0, ".", "")))+"\"");
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
         chkObreEst.Name = "OBREEST";
         chkObreEst.WebTags = "";
         chkObreEst.Caption = "Activo?";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkObreEst_Internalname, "TitleCaption", chkObreEst.Caption, true);
         chkObreEst.CheckedValue = "I";
         /* End function init_web_controls */
      }

      public void Valid_Obrefchnac( DateTime GX_Parm1 ,
                                    short GX_Parm2 )
      {
         A245ObreFchNac = GX_Parm1;
         n245ObreFchNac = false;
         A246ObreEdad = GX_Parm2;
         if ( ! ( (DateTime.MinValue==A245ObreFchNac) || ( A245ObreFchNac >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha Nac fuera de rango", "OutOfRange", 1, "OBREFCHNAC");
            AnyError = 1;
            GX_FocusControl = edtObreFchNac_Internalname;
         }
         A246ObreEdad = (short)(DateTimeUtil.Year( DateTimeUtil.ServerNow( context, pr_default))-DateTimeUtil.Year( A245ObreFchNac));
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A246ObreEdad), 4, 0, ".", "")));
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7ObreID',fld:'vOBREID',pic:'ZZZ9',hsh:true},{av:'AV11ObreCedula',fld:'vOBRECEDULA',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7ObreID',fld:'vOBREID',pic:'ZZZ9',hsh:true},{av:'AV11ObreCedula',fld:'vOBRECEDULA',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120R2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:''}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
         setEventMetadata("OBRECEDULA.CONTROLVALUECHANGED","{handler:'E130R2',iparms:[{av:'A239ObreCedula',fld:'OBRECEDULA',pic:''}]");
         setEventMetadata("OBRECEDULA.CONTROLVALUECHANGED",",oparms:[]}");
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
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         wcpOAV11ObreCedula = "";
         Z239ObreCedula = "";
         Z240ObrePrNombre = "";
         Z241ObreSegNombre = "";
         Z242ObrePrApellido = "";
         Z243ObreSegApellido = "";
         Z245ObreFchNac = DateTime.MinValue;
         Z247ObreDir = "";
         Z248ObreTelf = "";
         Z250ObreEmail = "";
         Z249ObreEst = "";
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
         A239ObreCedula = "";
         A242ObrePrApellido = "";
         A243ObreSegApellido = "";
         A240ObrePrNombre = "";
         A241ObreSegNombre = "";
         A244ObreNombre = "";
         A245ObreFchNac = DateTime.MinValue;
         A247ObreDir = "";
         A250ObreEmail = "";
         A248ObreTelf = "";
         A249ObreEst = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         AV13Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode42 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         AV12existe = "";
         GXt_char2 = "";
         T000R4_A238ObreID = new short[1] ;
         T000R4_A239ObreCedula = new String[] {""} ;
         T000R4_A240ObrePrNombre = new String[] {""} ;
         T000R4_n240ObrePrNombre = new bool[] {false} ;
         T000R4_A241ObreSegNombre = new String[] {""} ;
         T000R4_n241ObreSegNombre = new bool[] {false} ;
         T000R4_A242ObrePrApellido = new String[] {""} ;
         T000R4_n242ObrePrApellido = new bool[] {false} ;
         T000R4_A243ObreSegApellido = new String[] {""} ;
         T000R4_n243ObreSegApellido = new bool[] {false} ;
         T000R4_A245ObreFchNac = new DateTime[] {DateTime.MinValue} ;
         T000R4_n245ObreFchNac = new bool[] {false} ;
         T000R4_A247ObreDir = new String[] {""} ;
         T000R4_n247ObreDir = new bool[] {false} ;
         T000R4_A248ObreTelf = new String[] {""} ;
         T000R4_n248ObreTelf = new bool[] {false} ;
         T000R4_A250ObreEmail = new String[] {""} ;
         T000R4_n250ObreEmail = new bool[] {false} ;
         T000R4_A249ObreEst = new String[] {""} ;
         T000R4_n249ObreEst = new bool[] {false} ;
         T000R5_A238ObreID = new short[1] ;
         T000R5_A239ObreCedula = new String[] {""} ;
         T000R3_A238ObreID = new short[1] ;
         T000R3_A239ObreCedula = new String[] {""} ;
         T000R3_A240ObrePrNombre = new String[] {""} ;
         T000R3_n240ObrePrNombre = new bool[] {false} ;
         T000R3_A241ObreSegNombre = new String[] {""} ;
         T000R3_n241ObreSegNombre = new bool[] {false} ;
         T000R3_A242ObrePrApellido = new String[] {""} ;
         T000R3_n242ObrePrApellido = new bool[] {false} ;
         T000R3_A243ObreSegApellido = new String[] {""} ;
         T000R3_n243ObreSegApellido = new bool[] {false} ;
         T000R3_A245ObreFchNac = new DateTime[] {DateTime.MinValue} ;
         T000R3_n245ObreFchNac = new bool[] {false} ;
         T000R3_A247ObreDir = new String[] {""} ;
         T000R3_n247ObreDir = new bool[] {false} ;
         T000R3_A248ObreTelf = new String[] {""} ;
         T000R3_n248ObreTelf = new bool[] {false} ;
         T000R3_A250ObreEmail = new String[] {""} ;
         T000R3_n250ObreEmail = new bool[] {false} ;
         T000R3_A249ObreEst = new String[] {""} ;
         T000R3_n249ObreEst = new bool[] {false} ;
         T000R6_A238ObreID = new short[1] ;
         T000R6_A239ObreCedula = new String[] {""} ;
         T000R7_A238ObreID = new short[1] ;
         T000R7_A239ObreCedula = new String[] {""} ;
         T000R2_A238ObreID = new short[1] ;
         T000R2_A239ObreCedula = new String[] {""} ;
         T000R2_A240ObrePrNombre = new String[] {""} ;
         T000R2_n240ObrePrNombre = new bool[] {false} ;
         T000R2_A241ObreSegNombre = new String[] {""} ;
         T000R2_n241ObreSegNombre = new bool[] {false} ;
         T000R2_A242ObrePrApellido = new String[] {""} ;
         T000R2_n242ObrePrApellido = new bool[] {false} ;
         T000R2_A243ObreSegApellido = new String[] {""} ;
         T000R2_n243ObreSegApellido = new bool[] {false} ;
         T000R2_A245ObreFchNac = new DateTime[] {DateTime.MinValue} ;
         T000R2_n245ObreFchNac = new bool[] {false} ;
         T000R2_A247ObreDir = new String[] {""} ;
         T000R2_n247ObreDir = new bool[] {false} ;
         T000R2_A248ObreTelf = new String[] {""} ;
         T000R2_n248ObreTelf = new bool[] {false} ;
         T000R2_A250ObreEmail = new String[] {""} ;
         T000R2_n250ObreEmail = new bool[] {false} ;
         T000R2_A249ObreEst = new String[] {""} ;
         T000R2_n249ObreEst = new bool[] {false} ;
         T000R11_A238ObreID = new short[1] ;
         T000R11_A239ObreCedula = new String[] {""} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.obreros__default(),
            new Object[][] {
                new Object[] {
               T000R2_A238ObreID, T000R2_A239ObreCedula, T000R2_A240ObrePrNombre, T000R2_n240ObrePrNombre, T000R2_A241ObreSegNombre, T000R2_n241ObreSegNombre, T000R2_A242ObrePrApellido, T000R2_n242ObrePrApellido, T000R2_A243ObreSegApellido, T000R2_n243ObreSegApellido,
               T000R2_A245ObreFchNac, T000R2_n245ObreFchNac, T000R2_A247ObreDir, T000R2_n247ObreDir, T000R2_A248ObreTelf, T000R2_n248ObreTelf, T000R2_A250ObreEmail, T000R2_n250ObreEmail, T000R2_A249ObreEst, T000R2_n249ObreEst
               }
               , new Object[] {
               T000R3_A238ObreID, T000R3_A239ObreCedula, T000R3_A240ObrePrNombre, T000R3_n240ObrePrNombre, T000R3_A241ObreSegNombre, T000R3_n241ObreSegNombre, T000R3_A242ObrePrApellido, T000R3_n242ObrePrApellido, T000R3_A243ObreSegApellido, T000R3_n243ObreSegApellido,
               T000R3_A245ObreFchNac, T000R3_n245ObreFchNac, T000R3_A247ObreDir, T000R3_n247ObreDir, T000R3_A248ObreTelf, T000R3_n248ObreTelf, T000R3_A250ObreEmail, T000R3_n250ObreEmail, T000R3_A249ObreEst, T000R3_n249ObreEst
               }
               , new Object[] {
               T000R4_A238ObreID, T000R4_A239ObreCedula, T000R4_A240ObrePrNombre, T000R4_n240ObrePrNombre, T000R4_A241ObreSegNombre, T000R4_n241ObreSegNombre, T000R4_A242ObrePrApellido, T000R4_n242ObrePrApellido, T000R4_A243ObreSegApellido, T000R4_n243ObreSegApellido,
               T000R4_A245ObreFchNac, T000R4_n245ObreFchNac, T000R4_A247ObreDir, T000R4_n247ObreDir, T000R4_A248ObreTelf, T000R4_n248ObreTelf, T000R4_A250ObreEmail, T000R4_n250ObreEmail, T000R4_A249ObreEst, T000R4_n249ObreEst
               }
               , new Object[] {
               T000R5_A238ObreID, T000R5_A239ObreCedula
               }
               , new Object[] {
               T000R6_A238ObreID, T000R6_A239ObreCedula
               }
               , new Object[] {
               T000R7_A238ObreID, T000R7_A239ObreCedula
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000R11_A238ObreID, T000R11_A239ObreCedula
               }
            }
         );
         AV13Pgmname = "Obreros";
      }

      private short wcpOAV7ObreID ;
      private short Z238ObreID ;
      private short GxWebError ;
      private short AV7ObreID ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short A238ObreID ;
      private short A246ObreEdad ;
      private short RcdFound42 ;
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
      private int edtObreID_Enabled ;
      private int edtObreCedula_Enabled ;
      private int edtObrePrApellido_Enabled ;
      private int edtObreSegApellido_Enabled ;
      private int edtObrePrNombre_Enabled ;
      private int edtObreSegNombre_Enabled ;
      private int edtObreNombre_Enabled ;
      private int edtObreFchNac_Enabled ;
      private int edtObreEdad_Enabled ;
      private int edtObreDir_Enabled ;
      private int edtObreEmail_Enabled ;
      private int edtObreTelf_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String wcpOAV11ObreCedula ;
      private String Z239ObreCedula ;
      private String Z248ObreTelf ;
      private String Z249ObreEst ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String AV11ObreCedula ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtObreID_Internalname ;
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
      private String edtObreID_Jsonclick ;
      private String edtObreCedula_Internalname ;
      private String A239ObreCedula ;
      private String edtObreCedula_Jsonclick ;
      private String divSeccape1_Internalname ;
      private String edtObrePrApellido_Internalname ;
      private String edtObrePrApellido_Jsonclick ;
      private String divSeccape2_Internalname ;
      private String edtObreSegApellido_Internalname ;
      private String edtObreSegApellido_Jsonclick ;
      private String divSeccname1_Internalname ;
      private String edtObrePrNombre_Internalname ;
      private String edtObrePrNombre_Jsonclick ;
      private String divSeccname2_Internalname ;
      private String edtObreSegNombre_Internalname ;
      private String edtObreSegNombre_Jsonclick ;
      private String edtObreNombre_Internalname ;
      private String edtObreNombre_Jsonclick ;
      private String edtObreFchNac_Internalname ;
      private String edtObreFchNac_Jsonclick ;
      private String edtObreEdad_Internalname ;
      private String edtObreEdad_Jsonclick ;
      private String edtObreDir_Internalname ;
      private String edtObreDir_Jsonclick ;
      private String edtObreEmail_Internalname ;
      private String edtObreEmail_Jsonclick ;
      private String edtObreTelf_Internalname ;
      private String A248ObreTelf ;
      private String edtObreTelf_Jsonclick ;
      private String chkObreEst_Internalname ;
      private String A249ObreEst ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String AV13Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode42 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String AV12existe ;
      private String GXt_char2 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private DateTime Z245ObreFchNac ;
      private DateTime A245ObreFchNac ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n242ObrePrApellido ;
      private bool n243ObreSegApellido ;
      private bool n240ObrePrNombre ;
      private bool n241ObreSegNombre ;
      private bool n245ObreFchNac ;
      private bool n247ObreDir ;
      private bool n250ObreEmail ;
      private bool n248ObreTelf ;
      private bool n249ObreEst ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private String Z240ObrePrNombre ;
      private String Z241ObreSegNombre ;
      private String Z242ObrePrApellido ;
      private String Z243ObreSegApellido ;
      private String Z247ObreDir ;
      private String Z250ObreEmail ;
      private String A242ObrePrApellido ;
      private String A243ObreSegApellido ;
      private String A240ObrePrNombre ;
      private String A241ObreSegNombre ;
      private String A244ObreNombre ;
      private String A247ObreDir ;
      private String A250ObreEmail ;
      private IGxSession AV10WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCheckbox chkObreEst ;
      private IDataStoreProvider pr_default ;
      private short[] T000R4_A238ObreID ;
      private String[] T000R4_A239ObreCedula ;
      private String[] T000R4_A240ObrePrNombre ;
      private bool[] T000R4_n240ObrePrNombre ;
      private String[] T000R4_A241ObreSegNombre ;
      private bool[] T000R4_n241ObreSegNombre ;
      private String[] T000R4_A242ObrePrApellido ;
      private bool[] T000R4_n242ObrePrApellido ;
      private String[] T000R4_A243ObreSegApellido ;
      private bool[] T000R4_n243ObreSegApellido ;
      private DateTime[] T000R4_A245ObreFchNac ;
      private bool[] T000R4_n245ObreFchNac ;
      private String[] T000R4_A247ObreDir ;
      private bool[] T000R4_n247ObreDir ;
      private String[] T000R4_A248ObreTelf ;
      private bool[] T000R4_n248ObreTelf ;
      private String[] T000R4_A250ObreEmail ;
      private bool[] T000R4_n250ObreEmail ;
      private String[] T000R4_A249ObreEst ;
      private bool[] T000R4_n249ObreEst ;
      private short[] T000R5_A238ObreID ;
      private String[] T000R5_A239ObreCedula ;
      private short[] T000R3_A238ObreID ;
      private String[] T000R3_A239ObreCedula ;
      private String[] T000R3_A240ObrePrNombre ;
      private bool[] T000R3_n240ObrePrNombre ;
      private String[] T000R3_A241ObreSegNombre ;
      private bool[] T000R3_n241ObreSegNombre ;
      private String[] T000R3_A242ObrePrApellido ;
      private bool[] T000R3_n242ObrePrApellido ;
      private String[] T000R3_A243ObreSegApellido ;
      private bool[] T000R3_n243ObreSegApellido ;
      private DateTime[] T000R3_A245ObreFchNac ;
      private bool[] T000R3_n245ObreFchNac ;
      private String[] T000R3_A247ObreDir ;
      private bool[] T000R3_n247ObreDir ;
      private String[] T000R3_A248ObreTelf ;
      private bool[] T000R3_n248ObreTelf ;
      private String[] T000R3_A250ObreEmail ;
      private bool[] T000R3_n250ObreEmail ;
      private String[] T000R3_A249ObreEst ;
      private bool[] T000R3_n249ObreEst ;
      private short[] T000R6_A238ObreID ;
      private String[] T000R6_A239ObreCedula ;
      private short[] T000R7_A238ObreID ;
      private String[] T000R7_A239ObreCedula ;
      private short[] T000R2_A238ObreID ;
      private String[] T000R2_A239ObreCedula ;
      private String[] T000R2_A240ObrePrNombre ;
      private bool[] T000R2_n240ObrePrNombre ;
      private String[] T000R2_A241ObreSegNombre ;
      private bool[] T000R2_n241ObreSegNombre ;
      private String[] T000R2_A242ObrePrApellido ;
      private bool[] T000R2_n242ObrePrApellido ;
      private String[] T000R2_A243ObreSegApellido ;
      private bool[] T000R2_n243ObreSegApellido ;
      private DateTime[] T000R2_A245ObreFchNac ;
      private bool[] T000R2_n245ObreFchNac ;
      private String[] T000R2_A247ObreDir ;
      private bool[] T000R2_n247ObreDir ;
      private String[] T000R2_A248ObreTelf ;
      private bool[] T000R2_n248ObreTelf ;
      private String[] T000R2_A250ObreEmail ;
      private bool[] T000R2_n250ObreEmail ;
      private String[] T000R2_A249ObreEst ;
      private bool[] T000R2_n249ObreEst ;
      private short[] T000R11_A238ObreID ;
      private String[] T000R11_A239ObreCedula ;
      private SdtTransactionContext AV9TrnContext ;
   }

   public class obreros__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[6])
         ,new UpdateCursor(def[7])
         ,new UpdateCursor(def[8])
         ,new ForEachCursor(def[9])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000R4 ;
          prmT000R4 = new Object[] {
          new Object[] {"@ObreID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ObreCedula",SqlDbType.Char,13,0}
          } ;
          Object[] prmT000R5 ;
          prmT000R5 = new Object[] {
          new Object[] {"@ObreID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ObreCedula",SqlDbType.Char,13,0}
          } ;
          Object[] prmT000R3 ;
          prmT000R3 = new Object[] {
          new Object[] {"@ObreID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ObreCedula",SqlDbType.Char,13,0}
          } ;
          Object[] prmT000R6 ;
          prmT000R6 = new Object[] {
          new Object[] {"@ObreID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ObreCedula",SqlDbType.Char,13,0}
          } ;
          Object[] prmT000R7 ;
          prmT000R7 = new Object[] {
          new Object[] {"@ObreID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ObreCedula",SqlDbType.Char,13,0}
          } ;
          Object[] prmT000R2 ;
          prmT000R2 = new Object[] {
          new Object[] {"@ObreID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ObreCedula",SqlDbType.Char,13,0}
          } ;
          Object[] prmT000R8 ;
          prmT000R8 = new Object[] {
          new Object[] {"@ObreID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ObreCedula",SqlDbType.Char,13,0} ,
          new Object[] {"@ObrePrNombre",SqlDbType.VarChar,20,0} ,
          new Object[] {"@ObreSegNombre",SqlDbType.VarChar,20,0} ,
          new Object[] {"@ObrePrApellido",SqlDbType.VarChar,20,0} ,
          new Object[] {"@ObreSegApellido",SqlDbType.VarChar,20,0} ,
          new Object[] {"@ObreFchNac",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ObreDir",SqlDbType.VarChar,40,0} ,
          new Object[] {"@ObreTelf",SqlDbType.Char,20,0} ,
          new Object[] {"@ObreEmail",SqlDbType.VarChar,100,0} ,
          new Object[] {"@ObreEst",SqlDbType.Char,1,0}
          } ;
          Object[] prmT000R9 ;
          prmT000R9 = new Object[] {
          new Object[] {"@ObrePrNombre",SqlDbType.VarChar,20,0} ,
          new Object[] {"@ObreSegNombre",SqlDbType.VarChar,20,0} ,
          new Object[] {"@ObrePrApellido",SqlDbType.VarChar,20,0} ,
          new Object[] {"@ObreSegApellido",SqlDbType.VarChar,20,0} ,
          new Object[] {"@ObreFchNac",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ObreDir",SqlDbType.VarChar,40,0} ,
          new Object[] {"@ObreTelf",SqlDbType.Char,20,0} ,
          new Object[] {"@ObreEmail",SqlDbType.VarChar,100,0} ,
          new Object[] {"@ObreEst",SqlDbType.Char,1,0} ,
          new Object[] {"@ObreID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ObreCedula",SqlDbType.Char,13,0}
          } ;
          Object[] prmT000R10 ;
          prmT000R10 = new Object[] {
          new Object[] {"@ObreID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ObreCedula",SqlDbType.Char,13,0}
          } ;
          Object[] prmT000R11 ;
          prmT000R11 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T000R2", "SELECT [ObreID], [ObreCedula], [ObrePrNombre], [ObreSegNombre], [ObrePrApellido], [ObreSegApellido], [ObreFchNac], [ObreDir], [ObreTelf], [ObreEmail], [ObreEst] FROM [Obreros] WITH (UPDLOCK) WHERE [ObreID] = @ObreID AND [ObreCedula] = @ObreCedula ",true, GxErrorMask.GX_NOMASK, false, this,prmT000R2,1,0,true,false )
             ,new CursorDef("T000R3", "SELECT [ObreID], [ObreCedula], [ObrePrNombre], [ObreSegNombre], [ObrePrApellido], [ObreSegApellido], [ObreFchNac], [ObreDir], [ObreTelf], [ObreEmail], [ObreEst] FROM [Obreros] WITH (NOLOCK) WHERE [ObreID] = @ObreID AND [ObreCedula] = @ObreCedula ",true, GxErrorMask.GX_NOMASK, false, this,prmT000R3,1,0,true,false )
             ,new CursorDef("T000R4", "SELECT TM1.[ObreID], TM1.[ObreCedula], TM1.[ObrePrNombre], TM1.[ObreSegNombre], TM1.[ObrePrApellido], TM1.[ObreSegApellido], TM1.[ObreFchNac], TM1.[ObreDir], TM1.[ObreTelf], TM1.[ObreEmail], TM1.[ObreEst] FROM [Obreros] TM1 WITH (NOLOCK) WHERE TM1.[ObreID] = @ObreID and TM1.[ObreCedula] = @ObreCedula ORDER BY TM1.[ObreID], TM1.[ObreCedula]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000R4,100,0,true,false )
             ,new CursorDef("T000R5", "SELECT [ObreID], [ObreCedula] FROM [Obreros] WITH (NOLOCK) WHERE [ObreID] = @ObreID AND [ObreCedula] = @ObreCedula  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000R5,1,0,true,false )
             ,new CursorDef("T000R6", "SELECT TOP 1 [ObreID], [ObreCedula] FROM [Obreros] WITH (NOLOCK) WHERE ( [ObreID] > @ObreID or [ObreID] = @ObreID and [ObreCedula] > @ObreCedula) ORDER BY [ObreID], [ObreCedula]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000R6,1,0,true,true )
             ,new CursorDef("T000R7", "SELECT TOP 1 [ObreID], [ObreCedula] FROM [Obreros] WITH (NOLOCK) WHERE ( [ObreID] < @ObreID or [ObreID] = @ObreID and [ObreCedula] < @ObreCedula) ORDER BY [ObreID] DESC, [ObreCedula] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000R7,1,0,true,true )
             ,new CursorDef("T000R8", "INSERT INTO [Obreros]([ObreID], [ObreCedula], [ObrePrNombre], [ObreSegNombre], [ObrePrApellido], [ObreSegApellido], [ObreFchNac], [ObreDir], [ObreTelf], [ObreEmail], [ObreEst]) VALUES(@ObreID, @ObreCedula, @ObrePrNombre, @ObreSegNombre, @ObrePrApellido, @ObreSegApellido, @ObreFchNac, @ObreDir, @ObreTelf, @ObreEmail, @ObreEst)", GxErrorMask.GX_NOMASK,prmT000R8)
             ,new CursorDef("T000R9", "UPDATE [Obreros] SET [ObrePrNombre]=@ObrePrNombre, [ObreSegNombre]=@ObreSegNombre, [ObrePrApellido]=@ObrePrApellido, [ObreSegApellido]=@ObreSegApellido, [ObreFchNac]=@ObreFchNac, [ObreDir]=@ObreDir, [ObreTelf]=@ObreTelf, [ObreEmail]=@ObreEmail, [ObreEst]=@ObreEst  WHERE [ObreID] = @ObreID AND [ObreCedula] = @ObreCedula", GxErrorMask.GX_NOMASK,prmT000R9)
             ,new CursorDef("T000R10", "DELETE FROM [Obreros]  WHERE [ObreID] = @ObreID AND [ObreCedula] = @ObreCedula", GxErrorMask.GX_NOMASK,prmT000R10)
             ,new CursorDef("T000R11", "SELECT [ObreID], [ObreCedula] FROM [Obreros] WITH (NOLOCK) ORDER BY [ObreID], [ObreCedula]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000R11,100,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 13) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((String[]) buf[8])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[10])[0] = rslt.getGXDate(7) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(7);
                ((String[]) buf[12])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(8);
                ((String[]) buf[14])[0] = rslt.getString(9, 20) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(9);
                ((String[]) buf[16])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(10);
                ((String[]) buf[18])[0] = rslt.getString(11, 1) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(11);
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 13) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((String[]) buf[8])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[10])[0] = rslt.getGXDate(7) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(7);
                ((String[]) buf[12])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(8);
                ((String[]) buf[14])[0] = rslt.getString(9, 20) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(9);
                ((String[]) buf[16])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(10);
                ((String[]) buf[18])[0] = rslt.getString(11, 1) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(11);
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 13) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((String[]) buf[8])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[10])[0] = rslt.getGXDate(7) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(7);
                ((String[]) buf[12])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(8);
                ((String[]) buf[14])[0] = rslt.getString(9, 20) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(9);
                ((String[]) buf[16])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(10);
                ((String[]) buf[18])[0] = rslt.getString(11, 1) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(11);
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 13) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 13) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 13) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 13) ;
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
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
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
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 3 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 4 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 5 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 6 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 7 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(7, (DateTime)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 8 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[13]);
                }
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 9 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[15]);
                }
                if ( (bool)parms[16] )
                {
                   stmt.setNull( 10 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(10, (String)parms[17]);
                }
                if ( (bool)parms[18] )
                {
                   stmt.setNull( 11 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(11, (String)parms[19]);
                }
                return;
             case 7 :
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
                   stmt.setNull( 5 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(5, (DateTime)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 6 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 7 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[13]);
                }
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 8 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[15]);
                }
                if ( (bool)parms[16] )
                {
                   stmt.setNull( 9 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[17]);
                }
                stmt.SetParameter(10, (short)parms[18]);
                stmt.SetParameter(11, (String)parms[19]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
       }
    }

 }

}
