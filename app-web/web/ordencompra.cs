/*
               File: OrdenCompra
        Description: Orden Compra
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/29/2022 1:7:58.30
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
   public class ordencompra : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_32") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_32( A1EmpID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_34") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A42BodCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_34( A1EmpID, A42BodCod) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_33") == 0 )
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
            gxLoad_33( A1EmpID, A2AgeID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_36") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A321ClaOCCod = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A321ClaOCCod", A321ClaOCCod);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_36( A1EmpID, A2AgeID, A321ClaOCCod) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_37") == 0 )
         {
            A37PrvRuc = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PrvRuc", A37PrvRuc);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_37( A37PrvRuc) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_35") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A311OcTipoCod = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311OcTipoCod", A311OcTipoCod);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_35( A1EmpID, A2AgeID, A311OcTipoCod) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_38") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A317OCompNro = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317OCompNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A317OCompNro), 4, 0)));
            A311OcTipoCod = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311OcTipoCod", A311OcTipoCod);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_38( A1EmpID, A2AgeID, A317OCompNro, A311OcTipoCod) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_40") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A286PrdCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_40( A1EmpID, A2AgeID, A286PrdCod) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridordencompra_ocdet") == 0 )
         {
            nRC_GXsfl_159 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_159_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_159_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridordencompra_ocdet_newrow( ) ;
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
               AV8AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8AgeID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8AgeID), "ZZZ9"), context));
               AV9OCompNro = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9OCompNro", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9OCompNro), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vOCOMPNRO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9OCompNro), "ZZZ9"), context));
               AV10OcTipoCod = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OcTipoCod", AV10OcTipoCod);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vOCTIPOCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV10OcTipoCod, "")), context));
               AV18usucod = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18usucod", AV18usucod);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV18usucod, "")), context));
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
            Form.Meta.addItem("description", "Orden Compra", 0) ;
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

      public ordencompra( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public ordencompra( IGxContext context )
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
                           short aP3_OCompNro ,
                           String aP4_OcTipoCod ,
                           String aP5_usucod )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7EmpID = aP1_EmpID;
         this.AV8AgeID = aP2_AgeID;
         this.AV9OCompNro = aP3_OCompNro;
         this.AV10OcTipoCod = aP4_OcTipoCod;
         this.AV18usucod = aP5_usucod;
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Orden Compra", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_OrdenCompra.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0230.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"AGEID"+"'), id:'"+"AGEID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"OCOMPNRO"+"'), id:'"+"OCOMPNRO"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"OCTIPOCOD"+"'), id:'"+"OCTIPOCOD"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtEmpID_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEmpID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEmpID_Internalname, "Emp ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtEmpID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEmpID_Jsonclick, 0, "Attribute", "", "", "", "", edtEmpID_Visible, edtEmpID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_OrdenCompra.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_1_Internalname, sImgUrl, imgprompt_1_Link, "", "", context.GetTheme( ), imgprompt_1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtAgeID_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtAgeID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtAgeID_Internalname, "Age ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtAgeID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A2AgeID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A2AgeID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAgeID_Jsonclick, 0, "Attribute", "", "", "", "", edtAgeID_Visible, edtAgeID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_OrdenCompra.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_2_Internalname, sImgUrl, imgprompt_2_Link, "", "", context.GetTheme( ), imgprompt_2_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtOCompUser_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOCompUser_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOCompUser_Internalname, "User", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtOCompUser_Internalname, A326OCompUser, StringUtil.RTrim( context.localUtil.Format( A326OCompUser, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,42);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOCompUser_Jsonclick, 0, "Attribute", "", "", "", "", edtOCompUser_Visible, edtOCompUser_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection1_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtempdsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtempdsc_Internalname, "Empresa", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtempdsc_Internalname, A44empdsc, StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempdsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtempdsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 col-lg-2 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection2_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtAgeDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtAgeDsc_Internalname, "Agencia", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtAgeDsc_Internalname, StringUtil.RTrim( A46AgeDsc), StringUtil.RTrim( context.localUtil.Format( A46AgeDsc, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAgeDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtAgeDsc_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "Descripcion", "left", true, "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection10_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtClaOCCod_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtClaOCCod_Internalname, "Codigo Clase", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtClaOCCod_Internalname, StringUtil.RTrim( A321ClaOCCod), StringUtil.RTrim( context.localUtil.Format( A321ClaOCCod, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtClaOCCod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtClaOCCod_Enabled, 1, "text", "", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_OrdenCompra.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_321_Internalname, sImgUrl, imgprompt_321_Link, "", "", context.GetTheme( ), imgprompt_321_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 col-lg-3 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection11_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtClaOCDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtClaOCDsc_Internalname, "Clase", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtClaOCDsc_Internalname, StringUtil.RTrim( A322ClaOCDsc), StringUtil.RTrim( context.localUtil.Format( A322ClaOCDsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtClaOCDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtClaOCDsc_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "nombres", "left", true, "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection3_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOCompFch_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOCompFch_Internalname, "Registrado", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtOCompFch_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtOCompFch_Internalname, context.localUtil.Format(A318OCompFch, "99/99/9999"), context.localUtil.Format( A318OCompFch, "99/99/9999"), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOCompFch_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOCompFch_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_OrdenCompra.htm");
            GxWebStd.gx_bitmap( context, edtOCompFch_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtOCompFch_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_OrdenCompra.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Control Group */
            GxWebStd.gx_group_start( context, grpGroup1_Internalname, "Datos Proveedor", 1, 0, "px", 0, "px", "GroupTitle", "", "HLP_OrdenCompra.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGroup1table_Internalname, 1, 0, "px", 0, "px", "FormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection4_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPrvRuc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPrvRuc_Internalname, "Ruc", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPrvRuc_Internalname, StringUtil.RTrim( A37PrvRuc), StringUtil.RTrim( context.localUtil.Format( A37PrvRuc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,78);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPrvRuc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPrvRuc_Enabled, 1, "text", "", 13, "chr", 1, "row", 13, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_OrdenCompra.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_37_Internalname, sImgUrl, imgprompt_37_Link, "", "", context.GetTheme( ), imgprompt_37_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection5_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPrvDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPrvDsc_Internalname, "Razon Social", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtPrvDsc_Internalname, A184PrvDsc, StringUtil.RTrim( context.localUtil.Format( A184PrvDsc, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPrvDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPrvDsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 150, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection6_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPrvEmail_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPrvEmail_Internalname, "Email", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtPrvEmail_Internalname, A187PrvEmail, StringUtil.RTrim( context.localUtil.Format( A187PrvEmail, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "mailto:"+A187PrvEmail, "", "", "", edtPrvEmail_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPrvEmail_Enabled, 0, "email", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, 0, true, "GeneXus\\Email", "left", true, "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOCompNro_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOCompNro_Internalname, "Nro", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtOCompNro_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A317OCompNro), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A317OCompNro), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,93);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOCompNro_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOCompNro_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOCompFchOC_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOCompFchOC_Internalname, "Fecha Compra", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtOCompFchOC_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtOCompFchOC_Internalname, context.localUtil.Format(A340OCompFchOC, "99/99/9999"), context.localUtil.Format( A340OCompFchOC, "99/99/9999"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,98);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOCompFchOC_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOCompFchOC_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_OrdenCompra.htm");
            GxWebStd.gx_bitmap( context, edtOCompFchOC_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtOCompFchOC_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_OrdenCompra.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOCompContac_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOCompContac_Internalname, "Contacto", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 103,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtOCompContac_Internalname, A320OCompContac, StringUtil.RTrim( context.localUtil.Format( A320OCompContac, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,103);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOCompContac_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOCompContac_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 col-lg-3 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection7_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOcTipoCod_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOcTipoCod_Internalname, "Tipo Cod", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 109,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtOcTipoCod_Internalname, StringUtil.RTrim( A311OcTipoCod), StringUtil.RTrim( context.localUtil.Format( A311OcTipoCod, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,109);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOcTipoCod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOcTipoCod_Enabled, 1, "text", "", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_OrdenCompra.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_311_Internalname, sImgUrl, imgprompt_311_Link, "", "", context.GetTheme( ), imgprompt_311_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 col-lg-6 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection8_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOctipDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOctipDsc_Internalname, "Tipo OC", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtOctipDsc_Internalname, StringUtil.RTrim( A313OctipDsc), StringUtil.RTrim( context.localUtil.Format( A313OctipDsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOctipDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOctipDsc_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "nombres", "left", true, "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 col-lg-3 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection9_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOctipEst_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOctipEst_Internalname, "Estado", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtOctipEst_Internalname, StringUtil.RTrim( A314OctipEst), StringUtil.RTrim( context.localUtil.Format( A314OctipEst, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOctipEst_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOctipEst_Enabled, 0, "text", "", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, -1, true, "estado", "left", true, "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection12_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBodCod_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBodCod_Internalname, "Bod Cod", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 125,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBodCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A42BodCod), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A42BodCod), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,125);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBodCod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBodCod_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_OrdenCompra.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_42_Internalname, sImgUrl, imgprompt_42_Link, "", "", context.GetTheme( ), imgprompt_42_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection13_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBodDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBodDsc_Internalname, "Nombre", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBodDsc_Internalname, StringUtil.RTrim( A217BodDsc), StringUtil.RTrim( context.localUtil.Format( A217BodDsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBodDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBodDsc_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "nombres", "left", true, "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection14_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBodEst_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBodEst_Internalname, "Estado", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBodEst_Internalname, StringUtil.RTrim( A218BodEst), StringUtil.RTrim( context.localUtil.Format( A218BodEst, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBodEst_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBodEst_Enabled, 0, "text", "", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, -1, true, "estado", "left", true, "HLP_OrdenCompra.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOCompFchEnt_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOCompFchEnt_Internalname, "Fecha Entrega", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 140,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtOCompFchEnt_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtOCompFchEnt_Internalname, context.localUtil.Format(A319OCompFchEnt, "99/99/9999"), context.localUtil.Format( A319OCompFchEnt, "99/99/9999"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,140);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOCompFchEnt_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOCompFchEnt_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_OrdenCompra.htm");
            GxWebStd.gx_bitmap( context, edtOCompFchEnt_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtOCompFchEnt_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_OrdenCompra.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOCompLote_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOCompLote_Internalname, "Lote", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 145,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtOCompLote_Internalname, A324OCompLote, StringUtil.RTrim( context.localUtil.Format( A324OCompLote, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,145);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOCompLote_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOCompLote_Enabled, 0, "text", "", 80, "chr", 1, "row", 80, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOCompObsv_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOCompObsv_Internalname, "Observaciones", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 150,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtOCompObsv_Internalname, A325OCompObsv, StringUtil.RTrim( context.localUtil.Format( A325OCompObsv, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,150);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOCompObsv_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOCompObsv_Enabled, 0, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divOcdettable_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitleocdet_Internalname, "Detalle de Productos", "", "", lblTitleocdet_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Gridordencompra_ocdet( ) ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 FormCell", "Right", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection15_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOCompTotCant_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOCompTotCant_Internalname, "Tot Cantidad", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtOCompTotCant_Internalname, StringUtil.LTrim( StringUtil.NToC( A347OCompTotCant, 13, 2, ",", "")), ((edtOCompTotCant_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A347OCompTotCant, "ZZ,ZZZ,ZZZ.ZZ")) : context.localUtil.Format( A347OCompTotCant, "ZZ,ZZZ,ZZZ.ZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOCompTotCant_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOCompTotCant_Enabled, 0, "text", "", 13, "chr", 1, "row", 13, 0, 0, 0, 1, -1, 0, true, "valores", "right", false, "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 FormCell", "Right", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection16_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOcompTotal_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOcompTotal_Internalname, "Total", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtOcompTotal_Internalname, StringUtil.LTrim( StringUtil.NToC( A345OcompTotal, 13, 2, ",", "")), ((edtOcompTotal_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A345OcompTotal, "ZZ,ZZZ,ZZZ.ZZ")) : context.localUtil.Format( A345OcompTotal, "ZZ,ZZZ,ZZZ.ZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOcompTotal_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOcompTotal_Enabled, 0, "text", "", 13, "chr", 1, "row", 13, 0, 0, 0, 1, -1, 0, true, "valores", "right", false, "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 180,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 182,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 184,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenCompra.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm0X75( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void gxdraw_Gridordencompra_ocdet( )
      {
         /*  Grid Control  */
         Gridordencompra_ocdetContainer.AddObjectProperty("GridName", "Gridordencompra_ocdet");
         Gridordencompra_ocdetContainer.AddObjectProperty("Header", subGridordencompra_ocdet_Header);
         Gridordencompra_ocdetContainer.AddObjectProperty("Class", "Grid");
         Gridordencompra_ocdetContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridordencompra_ocdetContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridordencompra_ocdetContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridordencompra_ocdet_Backcolorstyle), 1, 0, ".", "")));
         Gridordencompra_ocdetContainer.AddObjectProperty("CmpContext", "");
         Gridordencompra_ocdetContainer.AddObjectProperty("InMasterPage", "false");
         Gridordencompra_ocdetColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridordencompra_ocdetColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A342ocDetID), 4, 0, ".", "")));
         Gridordencompra_ocdetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtocDetID_Enabled), 5, 0, ".", "")));
         Gridordencompra_ocdetContainer.AddColumnProperties(Gridordencompra_ocdetColumn);
         Gridordencompra_ocdetColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridordencompra_ocdetColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A286PrdCod), 4, 0, ".", "")));
         Gridordencompra_ocdetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrdCod_Enabled), 5, 0, ".", "")));
         Gridordencompra_ocdetContainer.AddColumnProperties(Gridordencompra_ocdetColumn);
         Gridordencompra_ocdetColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridordencompra_ocdetContainer.AddColumnProperties(Gridordencompra_ocdetColumn);
         Gridordencompra_ocdetColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridordencompra_ocdetColumn.AddObjectProperty("Value", A309prdNombre);
         Gridordencompra_ocdetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtprdNombre_Enabled), 5, 0, ".", "")));
         Gridordencompra_ocdetContainer.AddColumnProperties(Gridordencompra_ocdetColumn);
         Gridordencompra_ocdetColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridordencompra_ocdetColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A343ocDetCant), 4, 0, ".", "")));
         Gridordencompra_ocdetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtocDetCant_Enabled), 5, 0, ".", "")));
         Gridordencompra_ocdetContainer.AddColumnProperties(Gridordencompra_ocdetColumn);
         Gridordencompra_ocdetColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridordencompra_ocdetColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A344ocDetValor, 13, 2, ".", "")));
         Gridordencompra_ocdetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtocDetValor_Enabled), 5, 0, ".", "")));
         Gridordencompra_ocdetContainer.AddColumnProperties(Gridordencompra_ocdetColumn);
         Gridordencompra_ocdetContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridordencompra_ocdet_Selectedindex), 4, 0, ".", "")));
         Gridordencompra_ocdetContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridordencompra_ocdet_Allowselection), 1, 0, ".", "")));
         Gridordencompra_ocdetContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridordencompra_ocdet_Selectioncolor), 9, 0, ".", "")));
         Gridordencompra_ocdetContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridordencompra_ocdet_Allowhovering), 1, 0, ".", "")));
         Gridordencompra_ocdetContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridordencompra_ocdet_Hoveringcolor), 9, 0, ".", "")));
         Gridordencompra_ocdetContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridordencompra_ocdet_Allowcollapsing), 1, 0, ".", "")));
         Gridordencompra_ocdetContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridordencompra_ocdet_Collapsed), 1, 0, ".", "")));
         nGXsfl_159_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount80 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_80 = 1;
               ScanStart0X80( ) ;
               while ( RcdFound80 != 0 )
               {
                  init_level_properties80( ) ;
                  getByPrimaryKey0X80( ) ;
                  AddRow0X80( ) ;
                  ScanNext0X80( ) ;
               }
               ScanEnd0X80( ) ;
               nBlankRcdCount80 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            B345OcompTotal = A345OcompTotal;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
            B347OCompTotCant = A347OCompTotCant;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
            standaloneNotModal0X80( ) ;
            standaloneModal0X80( ) ;
            sMode80 = Gx_mode;
            while ( nGXsfl_159_idx < nRC_GXsfl_159 )
            {
               bGXsfl_159_Refreshing = true;
               ReadRow0X80( ) ;
               edtocDetID_Enabled = (int)(context.localUtil.CToN( cgiGet( "OCDETID_"+sGXsfl_159_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtocDetID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtocDetID_Enabled), 5, 0)), !bGXsfl_159_Refreshing);
               edtPrdCod_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRDCOD_"+sGXsfl_159_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrdCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrdCod_Enabled), 5, 0)), !bGXsfl_159_Refreshing);
               edtprdNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRDNOMBRE_"+sGXsfl_159_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtprdNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtprdNombre_Enabled), 5, 0)), !bGXsfl_159_Refreshing);
               edtocDetCant_Enabled = (int)(context.localUtil.CToN( cgiGet( "OCDETCANT_"+sGXsfl_159_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtocDetCant_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtocDetCant_Enabled), 5, 0)), !bGXsfl_159_Refreshing);
               edtocDetValor_Enabled = (int)(context.localUtil.CToN( cgiGet( "OCDETVALOR_"+sGXsfl_159_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtocDetValor_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtocDetValor_Enabled), 5, 0)), !bGXsfl_159_Refreshing);
               imgprompt_1_Link = cgiGet( "PROMPT_286_"+sGXsfl_159_idx+"Link");
               if ( ( nRcdExists_80 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal0X80( ) ;
               }
               SendRow0X80( ) ;
               bGXsfl_159_Refreshing = false;
            }
            Gx_mode = sMode80;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A345OcompTotal = B345OcompTotal;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
            A347OCompTotCant = B347OCompTotCant;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount80 = 5;
            nRcdExists_80 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart0X80( ) ;
               while ( RcdFound80 != 0 )
               {
                  sGXsfl_159_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_159_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_15980( ) ;
                  init_level_properties80( ) ;
                  standaloneNotModal0X80( ) ;
                  getByPrimaryKey0X80( ) ;
                  standaloneModal0X80( ) ;
                  AddRow0X80( ) ;
                  ScanNext0X80( ) ;
               }
               ScanEnd0X80( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode80 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_159_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_159_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_15980( ) ;
            InitAll0X80( ) ;
            init_level_properties80( ) ;
            B345OcompTotal = A345OcompTotal;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
            B347OCompTotCant = A347OCompTotCant;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
            standaloneNotModal0X80( ) ;
            standaloneModal0X80( ) ;
            nRcdExists_80 = 0;
            nIsMod_80 = 0;
            nRcdDeleted_80 = 0;
            nBlankRcdCount80 = (short)(nBlankRcdUsr80+nBlankRcdCount80);
            fRowAdded = 0;
            while ( nBlankRcdCount80 > 0 )
            {
               AddRow0X80( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtocDetID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount80 = (short)(nBlankRcdCount80-1);
            }
            Gx_mode = sMode80;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A345OcompTotal = B345OcompTotal;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
            A347OCompTotCant = B347OCompTotCant;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
         }
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridordencompra_ocdetContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridordencompra_ocdet", Gridordencompra_ocdetContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridordencompra_ocdetContainerData", Gridordencompra_ocdetContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridordencompra_ocdetContainerData"+"V", Gridordencompra_ocdetContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridordencompra_ocdetContainerData"+"V"+"\" value='"+Gridordencompra_ocdetContainer.GridValuesHidden()+"'/>") ;
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
         E110X2 ();
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
               A326OCompUser = cgiGet( edtOCompUser_Internalname);
               n326OCompUser = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A326OCompUser", A326OCompUser);
               n326OCompUser = (String.IsNullOrEmpty(StringUtil.RTrim( A326OCompUser)) ? true : false);
               A44empdsc = StringUtil.Upper( cgiGet( edtempdsc_Internalname));
               n44empdsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
               A46AgeDsc = cgiGet( edtAgeDsc_Internalname);
               n46AgeDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
               A321ClaOCCod = cgiGet( edtClaOCCod_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A321ClaOCCod", A321ClaOCCod);
               A322ClaOCDsc = StringUtil.Upper( cgiGet( edtClaOCDsc_Internalname));
               n322ClaOCDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A322ClaOCDsc", A322ClaOCDsc);
               A318OCompFch = context.localUtil.CToD( cgiGet( edtOCompFch_Internalname), 2);
               n318OCompFch = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A318OCompFch", context.localUtil.Format(A318OCompFch, "99/99/9999"));
               A37PrvRuc = cgiGet( edtPrvRuc_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PrvRuc", A37PrvRuc);
               A184PrvDsc = cgiGet( edtPrvDsc_Internalname);
               n184PrvDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184PrvDsc", A184PrvDsc);
               A187PrvEmail = cgiGet( edtPrvEmail_Internalname);
               n187PrvEmail = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187PrvEmail", A187PrvEmail);
               if ( ( ( context.localUtil.CToN( cgiGet( edtOCompNro_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtOCompNro_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "OCOMPNRO");
                  AnyError = 1;
                  GX_FocusControl = edtOCompNro_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A317OCompNro = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317OCompNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A317OCompNro), 4, 0)));
               }
               else
               {
                  A317OCompNro = (short)(context.localUtil.CToN( cgiGet( edtOCompNro_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317OCompNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A317OCompNro), 4, 0)));
               }
               if ( context.localUtil.VCDate( cgiGet( edtOCompFchOC_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha Compra"}), 1, "OCOMPFCHOC");
                  AnyError = 1;
                  GX_FocusControl = edtOCompFchOC_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A340OCompFchOC = DateTime.MinValue;
                  n340OCompFchOC = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A340OCompFchOC", context.localUtil.Format(A340OCompFchOC, "99/99/9999"));
               }
               else
               {
                  A340OCompFchOC = context.localUtil.CToD( cgiGet( edtOCompFchOC_Internalname), 2);
                  n340OCompFchOC = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A340OCompFchOC", context.localUtil.Format(A340OCompFchOC, "99/99/9999"));
               }
               n340OCompFchOC = ((DateTime.MinValue==A340OCompFchOC) ? true : false);
               A320OCompContac = cgiGet( edtOCompContac_Internalname);
               n320OCompContac = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A320OCompContac", A320OCompContac);
               n320OCompContac = (String.IsNullOrEmpty(StringUtil.RTrim( A320OCompContac)) ? true : false);
               A311OcTipoCod = cgiGet( edtOcTipoCod_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311OcTipoCod", A311OcTipoCod);
               A313OctipDsc = StringUtil.Upper( cgiGet( edtOctipDsc_Internalname));
               n313OctipDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313OctipDsc", A313OctipDsc);
               A314OctipEst = cgiGet( edtOctipEst_Internalname);
               n314OctipEst = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A314OctipEst", A314OctipEst);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBodCod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBodCod_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BODCOD");
                  AnyError = 1;
                  GX_FocusControl = edtBodCod_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A42BodCod = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
               }
               else
               {
                  A42BodCod = (short)(context.localUtil.CToN( cgiGet( edtBodCod_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
               }
               A217BodDsc = StringUtil.Upper( cgiGet( edtBodDsc_Internalname));
               n217BodDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
               A218BodEst = cgiGet( edtBodEst_Internalname);
               n218BodEst = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218BodEst", A218BodEst);
               if ( context.localUtil.VCDate( cgiGet( edtOCompFchEnt_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha Entrega"}), 1, "OCOMPFCHENT");
                  AnyError = 1;
                  GX_FocusControl = edtOCompFchEnt_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A319OCompFchEnt = DateTime.MinValue;
                  n319OCompFchEnt = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A319OCompFchEnt", context.localUtil.Format(A319OCompFchEnt, "99/99/9999"));
               }
               else
               {
                  A319OCompFchEnt = context.localUtil.CToD( cgiGet( edtOCompFchEnt_Internalname), 2);
                  n319OCompFchEnt = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A319OCompFchEnt", context.localUtil.Format(A319OCompFchEnt, "99/99/9999"));
               }
               n319OCompFchEnt = ((DateTime.MinValue==A319OCompFchEnt) ? true : false);
               A324OCompLote = cgiGet( edtOCompLote_Internalname);
               n324OCompLote = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A324OCompLote", A324OCompLote);
               n324OCompLote = (String.IsNullOrEmpty(StringUtil.RTrim( A324OCompLote)) ? true : false);
               A325OCompObsv = cgiGet( edtOCompObsv_Internalname);
               n325OCompObsv = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A325OCompObsv", A325OCompObsv);
               n325OCompObsv = (String.IsNullOrEmpty(StringUtil.RTrim( A325OCompObsv)) ? true : false);
               A347OCompTotCant = context.localUtil.CToN( cgiGet( edtOCompTotCant_Internalname), ",", ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
               A345OcompTotal = context.localUtil.CToN( cgiGet( edtOcompTotal_Internalname), ",", ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
               /* Read saved values. */
               Z1EmpID = (short)(context.localUtil.CToN( cgiGet( "Z1EmpID"), ",", "."));
               Z2AgeID = (short)(context.localUtil.CToN( cgiGet( "Z2AgeID"), ",", "."));
               Z317OCompNro = (short)(context.localUtil.CToN( cgiGet( "Z317OCompNro"), ",", "."));
               Z311OcTipoCod = cgiGet( "Z311OcTipoCod");
               Z318OCompFch = context.localUtil.CToD( cgiGet( "Z318OCompFch"), 0);
               n318OCompFch = ((DateTime.MinValue==A318OCompFch) ? true : false);
               Z326OCompUser = cgiGet( "Z326OCompUser");
               n326OCompUser = (String.IsNullOrEmpty(StringUtil.RTrim( A326OCompUser)) ? true : false);
               Z320OCompContac = cgiGet( "Z320OCompContac");
               n320OCompContac = (String.IsNullOrEmpty(StringUtil.RTrim( A320OCompContac)) ? true : false);
               Z319OCompFchEnt = context.localUtil.CToD( cgiGet( "Z319OCompFchEnt"), 0);
               n319OCompFchEnt = ((DateTime.MinValue==A319OCompFchEnt) ? true : false);
               Z324OCompLote = cgiGet( "Z324OCompLote");
               n324OCompLote = (String.IsNullOrEmpty(StringUtil.RTrim( A324OCompLote)) ? true : false);
               Z325OCompObsv = cgiGet( "Z325OCompObsv");
               n325OCompObsv = (String.IsNullOrEmpty(StringUtil.RTrim( A325OCompObsv)) ? true : false);
               Z340OCompFchOC = context.localUtil.CToD( cgiGet( "Z340OCompFchOC"), 0);
               n340OCompFchOC = ((DateTime.MinValue==A340OCompFchOC) ? true : false);
               Z42BodCod = (short)(context.localUtil.CToN( cgiGet( "Z42BodCod"), ",", "."));
               Z321ClaOCCod = cgiGet( "Z321ClaOCCod");
               Z37PrvRuc = cgiGet( "Z37PrvRuc");
               O345OcompTotal = context.localUtil.CToN( cgiGet( "O345OcompTotal"), ",", ".");
               O347OCompTotCant = context.localUtil.CToN( cgiGet( "O347OCompTotCant"), ",", ".");
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_159 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_159"), ",", "."));
               N37PrvRuc = cgiGet( "N37PrvRuc");
               N321ClaOCCod = cgiGet( "N321ClaOCCod");
               N42BodCod = (short)(context.localUtil.CToN( cgiGet( "N42BodCod"), ",", "."));
               AV7EmpID = (short)(context.localUtil.CToN( cgiGet( "vEMPID"), ",", "."));
               AV8AgeID = (short)(context.localUtil.CToN( cgiGet( "vAGEID"), ",", "."));
               AV9OCompNro = (short)(context.localUtil.CToN( cgiGet( "vOCOMPNRO"), ",", "."));
               AV10OcTipoCod = cgiGet( "vOCTIPOCOD");
               AV14Insert_PrvRuc = cgiGet( "vINSERT_PRVRUC");
               AV15Insert_ClaOCCod = cgiGet( "vINSERT_CLAOCCOD");
               AV16Insert_BodCod = (short)(context.localUtil.CToN( cgiGet( "vINSERT_BODCOD"), ",", "."));
               AV18usucod = cgiGet( "vUSUCOD");
               AV19Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "OrdenCompra";
               A318OCompFch = context.localUtil.CToD( cgiGet( edtOCompFch_Internalname), 2);
               n318OCompFch = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A318OCompFch", context.localUtil.Format(A318OCompFch, "99/99/9999"));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format(A318OCompFch, "99/99/9999");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV14Insert_PrvRuc, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV15Insert_ClaOCCod, ""));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV16Insert_BodCod), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A317OCompNro != Z317OCompNro ) || ( StringUtil.StrCmp(A311OcTipoCod, Z311OcTipoCod) != 0 ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("ordencompra:[SecurityCheckFailed value for]"+"OCompFch:"+context.localUtil.Format(A318OCompFch, "99/99/9999"));
                  GXUtil.WriteLog("ordencompra:[SecurityCheckFailed value for]"+"Insert_PrvRuc:"+StringUtil.RTrim( context.localUtil.Format( AV14Insert_PrvRuc, "")));
                  GXUtil.WriteLog("ordencompra:[SecurityCheckFailed value for]"+"Insert_ClaOCCod:"+StringUtil.RTrim( context.localUtil.Format( AV15Insert_ClaOCCod, "")));
                  GXUtil.WriteLog("ordencompra:[SecurityCheckFailed value for]"+"Insert_BodCod:"+context.localUtil.Format( (decimal)(AV16Insert_BodCod), "ZZZ9"));
                  GXUtil.WriteLog("ordencompra:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A2AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
                  A317OCompNro = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317OCompNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A317OCompNro), 4, 0)));
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
                     sMode75 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode75;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound75 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0X0( ) ;
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
                        E110X2 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: After Trn */
                        E120X2 ();
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
            E120X2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0X75( ) ;
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
            DisableAttributes0X75( ) ;
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

      protected void CONFIRM_0X0( )
      {
         BeforeValidate0X75( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0X75( ) ;
            }
            else
            {
               CheckExtendedTable0X75( ) ;
               CloseExtendedTableCursors0X75( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode75 = Gx_mode;
            CONFIRM_0X80( ) ;
            if ( AnyError == 0 )
            {
               /* Restore parent mode. */
               Gx_mode = sMode75;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
               IsConfirmed = 1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
            }
            /* Restore parent mode. */
            Gx_mode = sMode75;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
      }

      protected void CONFIRM_0X80( )
      {
         s345OcompTotal = O345OcompTotal;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
         s347OCompTotCant = O347OCompTotCant;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
         nGXsfl_159_idx = 0;
         while ( nGXsfl_159_idx < nRC_GXsfl_159 )
         {
            ReadRow0X80( ) ;
            if ( ( nRcdExists_80 != 0 ) || ( nIsMod_80 != 0 ) )
            {
               GetKey0X80( ) ;
               if ( ( nRcdExists_80 == 0 ) && ( nRcdDeleted_80 == 0 ) )
               {
                  if ( RcdFound80 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate0X80( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0X80( ) ;
                        CloseExtendedTableCursors0X80( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                        O345OcompTotal = A345OcompTotal;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
                        O347OCompTotCant = A347OCompTotCant;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
                     }
                  }
                  else
                  {
                     GXCCtl = "OCDETID_" + sGXsfl_159_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtocDetID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound80 != 0 )
                  {
                     if ( nRcdDeleted_80 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey0X80( ) ;
                        Load0X80( ) ;
                        BeforeValidate0X80( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0X80( ) ;
                           O345OcompTotal = A345OcompTotal;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
                           O347OCompTotCant = A347OCompTotCant;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
                        }
                     }
                     else
                     {
                        if ( nIsMod_80 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate0X80( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0X80( ) ;
                              CloseExtendedTableCursors0X80( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                              }
                              O345OcompTotal = A345OcompTotal;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
                              O347OCompTotCant = A347OCompTotCant;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_80 == 0 )
                     {
                        GXCCtl = "OCDETID_" + sGXsfl_159_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtocDetID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtocDetID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A342ocDetID), 4, 0, ",", ""))) ;
            ChangePostValue( edtPrdCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A286PrdCod), 4, 0, ",", ""))) ;
            ChangePostValue( edtprdNombre_Internalname, A309prdNombre) ;
            ChangePostValue( edtocDetCant_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A343ocDetCant), 4, 0, ",", ""))) ;
            ChangePostValue( edtocDetValor_Internalname, StringUtil.LTrim( StringUtil.NToC( A344ocDetValor, 13, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z342ocDetID_"+sGXsfl_159_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z342ocDetID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z343ocDetCant_"+sGXsfl_159_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z343ocDetCant), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z344ocDetValor_"+sGXsfl_159_idx, StringUtil.LTrim( StringUtil.NToC( Z344ocDetValor, 10, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z286PrdCod_"+sGXsfl_159_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z286PrdCod), 4, 0, ",", ""))) ;
            ChangePostValue( "T344ocDetValor_"+sGXsfl_159_idx, StringUtil.LTrim( StringUtil.NToC( O344ocDetValor, 10, 2, ",", ""))) ;
            ChangePostValue( "T343ocDetCant_"+sGXsfl_159_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(O343ocDetCant), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_80_"+sGXsfl_159_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_80), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_80_"+sGXsfl_159_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_80), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_80_"+sGXsfl_159_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_80), 4, 0, ",", ""))) ;
            if ( nIsMod_80 != 0 )
            {
               ChangePostValue( "OCDETID_"+sGXsfl_159_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtocDetID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRDCOD_"+sGXsfl_159_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrdCod_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRDNOMBRE_"+sGXsfl_159_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtprdNombre_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "OCDETCANT_"+sGXsfl_159_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtocDetCant_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "OCDETVALOR_"+sGXsfl_159_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtocDetValor_Enabled), 5, 0, ".", ""))) ;
            }
         }
         O345OcompTotal = s345OcompTotal;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
         O347OCompTotCant = s347OCompTotCant;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption0X0( )
      {
      }

      protected void E110X2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV19Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV19Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV12TrnContext.FromXml(AV13WebSession.Get("TrnContext"), null, "TransactionContext", "KBCalpesa22");
         AV14Insert_PrvRuc = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Insert_PrvRuc", AV14Insert_PrvRuc);
         AV15Insert_ClaOCCod = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Insert_ClaOCCod", AV15Insert_ClaOCCod);
         AV16Insert_BodCod = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Insert_BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16Insert_BodCod), 4, 0)));
         if ( ( StringUtil.StrCmp(AV12TrnContext.gxTpr_Transactionname, AV19Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV20GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20GXV1), 8, 0)));
            while ( AV20GXV1 <= AV12TrnContext.gxTpr_Attributes.Count )
            {
               AV17TrnContextAtt = ((SdtTransactionContext_Attribute)AV12TrnContext.gxTpr_Attributes.Item(AV20GXV1));
               if ( StringUtil.StrCmp(AV17TrnContextAtt.gxTpr_Attributename, "PrvRuc") == 0 )
               {
                  AV14Insert_PrvRuc = AV17TrnContextAtt.gxTpr_Attributevalue;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Insert_PrvRuc", AV14Insert_PrvRuc);
               }
               else if ( StringUtil.StrCmp(AV17TrnContextAtt.gxTpr_Attributename, "ClaOCCod") == 0 )
               {
                  AV15Insert_ClaOCCod = AV17TrnContextAtt.gxTpr_Attributevalue;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Insert_ClaOCCod", AV15Insert_ClaOCCod);
               }
               else if ( StringUtil.StrCmp(AV17TrnContextAtt.gxTpr_Attributename, "BodCod") == 0 )
               {
                  AV16Insert_BodCod = (short)(NumberUtil.Val( AV17TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Insert_BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16Insert_BodCod), 4, 0)));
               }
               AV20GXV1 = (int)(AV20GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20GXV1), 8, 0)));
            }
         }
         edtEmpID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Visible), 5, 0)), true);
         edtAgeID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAgeID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAgeID_Visible), 5, 0)), true);
         edtOCompUser_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOCompUser_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOCompUser_Visible), 5, 0)), true);
      }

      protected void E120X2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV12TrnContext.gxTpr_Callerondelete )
         {
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0X75( short GX_JID )
      {
         if ( ( GX_JID == 31 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z318OCompFch = T000X6_A318OCompFch[0];
               Z326OCompUser = T000X6_A326OCompUser[0];
               Z320OCompContac = T000X6_A320OCompContac[0];
               Z319OCompFchEnt = T000X6_A319OCompFchEnt[0];
               Z324OCompLote = T000X6_A324OCompLote[0];
               Z325OCompObsv = T000X6_A325OCompObsv[0];
               Z340OCompFchOC = T000X6_A340OCompFchOC[0];
               Z42BodCod = T000X6_A42BodCod[0];
               Z321ClaOCCod = T000X6_A321ClaOCCod[0];
               Z37PrvRuc = T000X6_A37PrvRuc[0];
            }
            else
            {
               Z318OCompFch = A318OCompFch;
               Z326OCompUser = A326OCompUser;
               Z320OCompContac = A320OCompContac;
               Z319OCompFchEnt = A319OCompFchEnt;
               Z324OCompLote = A324OCompLote;
               Z325OCompObsv = A325OCompObsv;
               Z340OCompFchOC = A340OCompFchOC;
               Z42BodCod = A42BodCod;
               Z321ClaOCCod = A321ClaOCCod;
               Z37PrvRuc = A37PrvRuc;
            }
         }
         if ( GX_JID == -31 )
         {
            Z317OCompNro = A317OCompNro;
            Z318OCompFch = A318OCompFch;
            Z326OCompUser = A326OCompUser;
            Z320OCompContac = A320OCompContac;
            Z319OCompFchEnt = A319OCompFchEnt;
            Z324OCompLote = A324OCompLote;
            Z325OCompObsv = A325OCompObsv;
            Z340OCompFchOC = A340OCompFchOC;
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z42BodCod = A42BodCod;
            Z311OcTipoCod = A311OcTipoCod;
            Z321ClaOCCod = A321ClaOCCod;
            Z37PrvRuc = A37PrvRuc;
            Z44empdsc = A44empdsc;
            Z46AgeDsc = A46AgeDsc;
            Z184PrvDsc = A184PrvDsc;
            Z187PrvEmail = A187PrvEmail;
            Z313OctipDsc = A313OctipDsc;
            Z314OctipEst = A314OctipEst;
            Z345OcompTotal = A345OcompTotal;
            Z347OCompTotCant = A347OCompTotCant;
            Z322ClaOCDsc = A322ClaOCDsc;
            Z217BodDsc = A217BodDsc;
            Z218BodEst = A218BodEst;
         }
      }

      protected void standaloneNotModal( )
      {
         edtOCompFch_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOCompFch_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOCompFch_Enabled), 5, 0)), true);
         imgprompt_1_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_2_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0021.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"AGEID"+"'), id:'"+"AGEID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_321_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0242.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"AGEID"+"'), id:'"+"AGEID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"CLAOCCOD"+"'), id:'"+"CLAOCCOD"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_37_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00v0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PRVRUC"+"'), id:'"+"PRVRUC"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_311_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0222.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"AGEID"+"'), id:'"+"AGEID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"OCTIPOCOD"+"'), id:'"+"OCTIPOCOD"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_42_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00y1.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"BODCOD"+"'), id:'"+"BODCOD"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         edtOCompFch_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOCompFch_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOCompFch_Enabled), 5, 0)), true);
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
         if ( ! (0==AV9OCompNro) )
         {
            A317OCompNro = AV9OCompNro;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317OCompNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A317OCompNro), 4, 0)));
         }
         if ( ! (0==AV9OCompNro) )
         {
            edtOCompNro_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOCompNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOCompNro_Enabled), 5, 0)), true);
         }
         else
         {
            edtOCompNro_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOCompNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOCompNro_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV9OCompNro) )
         {
            edtOCompNro_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOCompNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOCompNro_Enabled), 5, 0)), true);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10OcTipoCod)) )
         {
            A311OcTipoCod = AV10OcTipoCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311OcTipoCod", A311OcTipoCod);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10OcTipoCod)) )
         {
            edtOcTipoCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOcTipoCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOcTipoCod_Enabled), 5, 0)), true);
         }
         else
         {
            edtOcTipoCod_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOcTipoCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOcTipoCod_Enabled), 5, 0)), true);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10OcTipoCod)) )
         {
            edtOcTipoCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOcTipoCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOcTipoCod_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV14Insert_PrvRuc)) )
         {
            edtPrvRuc_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrvRuc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrvRuc_Enabled), 5, 0)), true);
         }
         else
         {
            edtPrvRuc_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrvRuc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrvRuc_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV15Insert_ClaOCCod)) )
         {
            edtClaOCCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClaOCCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClaOCCod_Enabled), 5, 0)), true);
         }
         else
         {
            edtClaOCCod_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClaOCCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClaOCCod_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV16Insert_BodCod) )
         {
            edtBodCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodCod_Enabled), 5, 0)), true);
         }
         else
         {
            edtBodCod_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodCod_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A318OCompFch = DateTimeUtil.ResetTime(DateTimeUtil.ServerNow( context, pr_default));
            n318OCompFch = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A318OCompFch", context.localUtil.Format(A318OCompFch, "99/99/9999"));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV16Insert_BodCod) )
         {
            A42BodCod = AV16Insert_BodCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV15Insert_ClaOCCod)) )
         {
            A321ClaOCCod = AV15Insert_ClaOCCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A321ClaOCCod", A321ClaOCCod);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV14Insert_PrvRuc)) )
         {
            A37PrvRuc = AV14Insert_PrvRuc;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PrvRuc", A37PrvRuc);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A326OCompUser = AV18usucod;
            n326OCompUser = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A326OCompUser", A326OCompUser);
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
            /* Using cursor T000X7 */
            pr_default.execute(5, new Object[] {A1EmpID});
            A44empdsc = T000X7_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000X7_n44empdsc[0];
            pr_default.close(5);
            AV19Pgmname = "OrdenCompra";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Pgmname", AV19Pgmname);
            /* Using cursor T000X8 */
            pr_default.execute(6, new Object[] {A1EmpID, A2AgeID});
            A46AgeDsc = T000X8_A46AgeDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
            n46AgeDsc = T000X8_n46AgeDsc[0];
            pr_default.close(6);
            /* Using cursor T000X10 */
            pr_default.execute(8, new Object[] {A1EmpID, A2AgeID, A311OcTipoCod});
            A313OctipDsc = T000X10_A313OctipDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313OctipDsc", A313OctipDsc);
            n313OctipDsc = T000X10_n313OctipDsc[0];
            A314OctipEst = T000X10_A314OctipEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A314OctipEst", A314OctipEst);
            n314OctipEst = T000X10_n314OctipEst[0];
            pr_default.close(8);
            /* Using cursor T000X14 */
            pr_default.execute(11, new Object[] {A1EmpID, A2AgeID, A317OCompNro, A311OcTipoCod});
            if ( (pr_default.getStatus(11) != 101) )
            {
               A345OcompTotal = T000X14_A345OcompTotal[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
               A347OCompTotCant = T000X14_A347OCompTotCant[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
            }
            else
            {
               A345OcompTotal = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
               A347OCompTotCant = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
            }
            O345OcompTotal = A345OcompTotal;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
            O347OCompTotCant = A347OCompTotCant;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
            pr_default.close(11);
            /* Using cursor T000X9 */
            pr_default.execute(7, new Object[] {A1EmpID, A42BodCod});
            A217BodDsc = T000X9_A217BodDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
            n217BodDsc = T000X9_n217BodDsc[0];
            A218BodEst = T000X9_A218BodEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218BodEst", A218BodEst);
            n218BodEst = T000X9_n218BodEst[0];
            pr_default.close(7);
            /* Using cursor T000X11 */
            pr_default.execute(9, new Object[] {A1EmpID, A2AgeID, A321ClaOCCod});
            A322ClaOCDsc = T000X11_A322ClaOCDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A322ClaOCDsc", A322ClaOCDsc);
            n322ClaOCDsc = T000X11_n322ClaOCDsc[0];
            pr_default.close(9);
            /* Using cursor T000X12 */
            pr_default.execute(10, new Object[] {A37PrvRuc});
            A184PrvDsc = T000X12_A184PrvDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184PrvDsc", A184PrvDsc);
            n184PrvDsc = T000X12_n184PrvDsc[0];
            A187PrvEmail = T000X12_A187PrvEmail[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187PrvEmail", A187PrvEmail);
            n187PrvEmail = T000X12_n187PrvEmail[0];
            pr_default.close(10);
         }
      }

      protected void Load0X75( )
      {
         /* Using cursor T000X16 */
         pr_default.execute(12, new Object[] {A1EmpID, A2AgeID, A317OCompNro, A311OcTipoCod});
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound75 = 1;
            A318OCompFch = T000X16_A318OCompFch[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A318OCompFch", context.localUtil.Format(A318OCompFch, "99/99/9999"));
            n318OCompFch = T000X16_n318OCompFch[0];
            A326OCompUser = T000X16_A326OCompUser[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A326OCompUser", A326OCompUser);
            n326OCompUser = T000X16_n326OCompUser[0];
            A44empdsc = T000X16_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000X16_n44empdsc[0];
            A46AgeDsc = T000X16_A46AgeDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
            n46AgeDsc = T000X16_n46AgeDsc[0];
            A184PrvDsc = T000X16_A184PrvDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184PrvDsc", A184PrvDsc);
            n184PrvDsc = T000X16_n184PrvDsc[0];
            A187PrvEmail = T000X16_A187PrvEmail[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187PrvEmail", A187PrvEmail);
            n187PrvEmail = T000X16_n187PrvEmail[0];
            A320OCompContac = T000X16_A320OCompContac[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A320OCompContac", A320OCompContac);
            n320OCompContac = T000X16_n320OCompContac[0];
            A313OctipDsc = T000X16_A313OctipDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313OctipDsc", A313OctipDsc);
            n313OctipDsc = T000X16_n313OctipDsc[0];
            A314OctipEst = T000X16_A314OctipEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A314OctipEst", A314OctipEst);
            n314OctipEst = T000X16_n314OctipEst[0];
            A319OCompFchEnt = T000X16_A319OCompFchEnt[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A319OCompFchEnt", context.localUtil.Format(A319OCompFchEnt, "99/99/9999"));
            n319OCompFchEnt = T000X16_n319OCompFchEnt[0];
            A322ClaOCDsc = T000X16_A322ClaOCDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A322ClaOCDsc", A322ClaOCDsc);
            n322ClaOCDsc = T000X16_n322ClaOCDsc[0];
            A217BodDsc = T000X16_A217BodDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
            n217BodDsc = T000X16_n217BodDsc[0];
            A218BodEst = T000X16_A218BodEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218BodEst", A218BodEst);
            n218BodEst = T000X16_n218BodEst[0];
            A324OCompLote = T000X16_A324OCompLote[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A324OCompLote", A324OCompLote);
            n324OCompLote = T000X16_n324OCompLote[0];
            A325OCompObsv = T000X16_A325OCompObsv[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A325OCompObsv", A325OCompObsv);
            n325OCompObsv = T000X16_n325OCompObsv[0];
            A340OCompFchOC = T000X16_A340OCompFchOC[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A340OCompFchOC", context.localUtil.Format(A340OCompFchOC, "99/99/9999"));
            n340OCompFchOC = T000X16_n340OCompFchOC[0];
            A42BodCod = T000X16_A42BodCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
            A321ClaOCCod = T000X16_A321ClaOCCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A321ClaOCCod", A321ClaOCCod);
            A37PrvRuc = T000X16_A37PrvRuc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PrvRuc", A37PrvRuc);
            A345OcompTotal = T000X16_A345OcompTotal[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
            A347OCompTotCant = T000X16_A347OCompTotCant[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
            ZM0X75( -31) ;
         }
         pr_default.close(12);
         OnLoadActions0X75( ) ;
      }

      protected void OnLoadActions0X75( )
      {
         O345OcompTotal = A345OcompTotal;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
         O347OCompTotCant = A347OCompTotCant;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
         AV19Pgmname = "OrdenCompra";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Pgmname", AV19Pgmname);
      }

      protected void CheckExtendedTable0X75( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV19Pgmname = "OrdenCompra";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Pgmname", AV19Pgmname);
         /* Using cursor T000X7 */
         pr_default.execute(5, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000X7_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T000X7_n44empdsc[0];
         pr_default.close(5);
         /* Using cursor T000X9 */
         pr_default.execute(7, new Object[] {A1EmpID, A42BodCod});
         if ( (pr_default.getStatus(7) == 101) )
         {
            GX_msglist.addItem("No existe 'Bodegas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A217BodDsc = T000X9_A217BodDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
         n217BodDsc = T000X9_n217BodDsc[0];
         A218BodEst = T000X9_A218BodEst[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218BodEst", A218BodEst);
         n218BodEst = T000X9_n218BodEst[0];
         pr_default.close(7);
         /* Using cursor T000X8 */
         pr_default.execute(6, new Object[] {A1EmpID, A2AgeID});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No existe 'Agencias'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A46AgeDsc = T000X8_A46AgeDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
         n46AgeDsc = T000X8_n46AgeDsc[0];
         pr_default.close(6);
         /* Using cursor T000X11 */
         pr_default.execute(9, new Object[] {A1EmpID, A2AgeID, A321ClaOCCod});
         if ( (pr_default.getStatus(9) == 101) )
         {
            GX_msglist.addItem("No existe 'Clase OC'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A322ClaOCDsc = T000X11_A322ClaOCDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A322ClaOCDsc", A322ClaOCDsc);
         n322ClaOCDsc = T000X11_n322ClaOCDsc[0];
         pr_default.close(9);
         /* Using cursor T000X12 */
         pr_default.execute(10, new Object[] {A37PrvRuc});
         if ( (pr_default.getStatus(10) == 101) )
         {
            GX_msglist.addItem("No existe 'Proveedor'.", "ForeignKeyNotFound", 1, "PRVRUC");
            AnyError = 1;
            GX_FocusControl = edtPrvRuc_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A184PrvDsc = T000X12_A184PrvDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184PrvDsc", A184PrvDsc);
         n184PrvDsc = T000X12_n184PrvDsc[0];
         A187PrvEmail = T000X12_A187PrvEmail[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187PrvEmail", A187PrvEmail);
         n187PrvEmail = T000X12_n187PrvEmail[0];
         pr_default.close(10);
         /* Using cursor T000X10 */
         pr_default.execute(8, new Object[] {A1EmpID, A2AgeID, A311OcTipoCod});
         if ( (pr_default.getStatus(8) == 101) )
         {
            GX_msglist.addItem("No existe 'Octipos'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A313OctipDsc = T000X10_A313OctipDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313OctipDsc", A313OctipDsc);
         n313OctipDsc = T000X10_n313OctipDsc[0];
         A314OctipEst = T000X10_A314OctipEst[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A314OctipEst", A314OctipEst);
         n314OctipEst = T000X10_n314OctipEst[0];
         pr_default.close(8);
         /* Using cursor T000X14 */
         pr_default.execute(11, new Object[] {A1EmpID, A2AgeID, A317OCompNro, A311OcTipoCod});
         if ( (pr_default.getStatus(11) != 101) )
         {
            A345OcompTotal = T000X14_A345OcompTotal[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
            A347OCompTotCant = T000X14_A347OCompTotCant[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
         }
         else
         {
            A345OcompTotal = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
            A347OCompTotCant = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
         }
         pr_default.close(11);
         if ( ! ( (DateTime.MinValue==A319OCompFchEnt) || ( A319OCompFchEnt >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha Entrega fuera de rango", "OutOfRange", 1, "OCOMPFCHENT");
            AnyError = 1;
            GX_FocusControl = edtOCompFchEnt_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A340OCompFchOC) || ( A340OCompFchOC >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha Compra fuera de rango", "OutOfRange", 1, "OCOMPFCHOC");
            AnyError = 1;
            GX_FocusControl = edtOCompFchOC_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0X75( )
      {
         pr_default.close(5);
         pr_default.close(7);
         pr_default.close(6);
         pr_default.close(9);
         pr_default.close(10);
         pr_default.close(8);
         pr_default.close(11);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_32( short A1EmpID )
      {
         /* Using cursor T000X17 */
         pr_default.execute(13, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000X17_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T000X17_n44empdsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A44empdsc)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(13) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(13);
      }

      protected void gxLoad_34( short A1EmpID ,
                                short A42BodCod )
      {
         /* Using cursor T000X18 */
         pr_default.execute(14, new Object[] {A1EmpID, A42BodCod});
         if ( (pr_default.getStatus(14) == 101) )
         {
            GX_msglist.addItem("No existe 'Bodegas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A217BodDsc = T000X18_A217BodDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
         n217BodDsc = T000X18_n217BodDsc[0];
         A218BodEst = T000X18_A218BodEst[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218BodEst", A218BodEst);
         n218BodEst = T000X18_n218BodEst[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A217BodDsc))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A218BodEst))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(14) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(14);
      }

      protected void gxLoad_33( short A1EmpID ,
                                short A2AgeID )
      {
         /* Using cursor T000X19 */
         pr_default.execute(15, new Object[] {A1EmpID, A2AgeID});
         if ( (pr_default.getStatus(15) == 101) )
         {
            GX_msglist.addItem("No existe 'Agencias'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A46AgeDsc = T000X19_A46AgeDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
         n46AgeDsc = T000X19_n46AgeDsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A46AgeDsc))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(15) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(15);
      }

      protected void gxLoad_36( short A1EmpID ,
                                short A2AgeID ,
                                String A321ClaOCCod )
      {
         /* Using cursor T000X20 */
         pr_default.execute(16, new Object[] {A1EmpID, A2AgeID, A321ClaOCCod});
         if ( (pr_default.getStatus(16) == 101) )
         {
            GX_msglist.addItem("No existe 'Clase OC'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A322ClaOCDsc = T000X20_A322ClaOCDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A322ClaOCDsc", A322ClaOCDsc);
         n322ClaOCDsc = T000X20_n322ClaOCDsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A322ClaOCDsc))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(16) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(16);
      }

      protected void gxLoad_37( String A37PrvRuc )
      {
         /* Using cursor T000X21 */
         pr_default.execute(17, new Object[] {A37PrvRuc});
         if ( (pr_default.getStatus(17) == 101) )
         {
            GX_msglist.addItem("No existe 'Proveedor'.", "ForeignKeyNotFound", 1, "PRVRUC");
            AnyError = 1;
            GX_FocusControl = edtPrvRuc_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A184PrvDsc = T000X21_A184PrvDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184PrvDsc", A184PrvDsc);
         n184PrvDsc = T000X21_n184PrvDsc[0];
         A187PrvEmail = T000X21_A187PrvEmail[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187PrvEmail", A187PrvEmail);
         n187PrvEmail = T000X21_n187PrvEmail[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A184PrvDsc)+"\""+","+"\""+GXUtil.EncodeJSConstant( A187PrvEmail)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(17) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(17);
      }

      protected void gxLoad_35( short A1EmpID ,
                                short A2AgeID ,
                                String A311OcTipoCod )
      {
         /* Using cursor T000X22 */
         pr_default.execute(18, new Object[] {A1EmpID, A2AgeID, A311OcTipoCod});
         if ( (pr_default.getStatus(18) == 101) )
         {
            GX_msglist.addItem("No existe 'Octipos'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A313OctipDsc = T000X22_A313OctipDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313OctipDsc", A313OctipDsc);
         n313OctipDsc = T000X22_n313OctipDsc[0];
         A314OctipEst = T000X22_A314OctipEst[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A314OctipEst", A314OctipEst);
         n314OctipEst = T000X22_n314OctipEst[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A313OctipDsc))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A314OctipEst))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(18) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(18);
      }

      protected void gxLoad_38( short A1EmpID ,
                                short A2AgeID ,
                                short A317OCompNro ,
                                String A311OcTipoCod )
      {
         /* Using cursor T000X24 */
         pr_default.execute(19, new Object[] {A1EmpID, A2AgeID, A317OCompNro, A311OcTipoCod});
         if ( (pr_default.getStatus(19) != 101) )
         {
            A345OcompTotal = T000X24_A345OcompTotal[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
            A347OCompTotCant = T000X24_A347OCompTotCant[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
         }
         else
         {
            A345OcompTotal = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
            A347OCompTotCant = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A345OcompTotal, 10, 2, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A347OCompTotCant, 10, 2, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(19) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(19);
      }

      protected void GetKey0X75( )
      {
         /* Using cursor T000X25 */
         pr_default.execute(20, new Object[] {A1EmpID, A2AgeID, A317OCompNro, A311OcTipoCod});
         if ( (pr_default.getStatus(20) != 101) )
         {
            RcdFound75 = 1;
         }
         else
         {
            RcdFound75 = 0;
         }
         pr_default.close(20);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000X6 */
         pr_default.execute(4, new Object[] {A1EmpID, A2AgeID, A317OCompNro, A311OcTipoCod});
         if ( (pr_default.getStatus(4) != 101) )
         {
            ZM0X75( 31) ;
            RcdFound75 = 1;
            A317OCompNro = T000X6_A317OCompNro[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317OCompNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A317OCompNro), 4, 0)));
            A318OCompFch = T000X6_A318OCompFch[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A318OCompFch", context.localUtil.Format(A318OCompFch, "99/99/9999"));
            n318OCompFch = T000X6_n318OCompFch[0];
            A326OCompUser = T000X6_A326OCompUser[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A326OCompUser", A326OCompUser);
            n326OCompUser = T000X6_n326OCompUser[0];
            A320OCompContac = T000X6_A320OCompContac[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A320OCompContac", A320OCompContac);
            n320OCompContac = T000X6_n320OCompContac[0];
            A319OCompFchEnt = T000X6_A319OCompFchEnt[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A319OCompFchEnt", context.localUtil.Format(A319OCompFchEnt, "99/99/9999"));
            n319OCompFchEnt = T000X6_n319OCompFchEnt[0];
            A324OCompLote = T000X6_A324OCompLote[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A324OCompLote", A324OCompLote);
            n324OCompLote = T000X6_n324OCompLote[0];
            A325OCompObsv = T000X6_A325OCompObsv[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A325OCompObsv", A325OCompObsv);
            n325OCompObsv = T000X6_n325OCompObsv[0];
            A340OCompFchOC = T000X6_A340OCompFchOC[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A340OCompFchOC", context.localUtil.Format(A340OCompFchOC, "99/99/9999"));
            n340OCompFchOC = T000X6_n340OCompFchOC[0];
            A1EmpID = T000X6_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = T000X6_A2AgeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A42BodCod = T000X6_A42BodCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
            A311OcTipoCod = T000X6_A311OcTipoCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311OcTipoCod", A311OcTipoCod);
            A321ClaOCCod = T000X6_A321ClaOCCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A321ClaOCCod", A321ClaOCCod);
            A37PrvRuc = T000X6_A37PrvRuc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PrvRuc", A37PrvRuc);
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z317OCompNro = A317OCompNro;
            Z311OcTipoCod = A311OcTipoCod;
            sMode75 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0X75( ) ;
            if ( AnyError == 1 )
            {
               RcdFound75 = 0;
               InitializeNonKey0X75( ) ;
            }
            Gx_mode = sMode75;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound75 = 0;
            InitializeNonKey0X75( ) ;
            sMode75 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode75;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(4);
      }

      protected void getEqualNoModal( )
      {
         GetKey0X75( ) ;
         if ( RcdFound75 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound75 = 0;
         /* Using cursor T000X26 */
         pr_default.execute(21, new Object[] {A1EmpID, A2AgeID, A317OCompNro, A311OcTipoCod});
         if ( (pr_default.getStatus(21) != 101) )
         {
            while ( (pr_default.getStatus(21) != 101) && ( ( T000X26_A1EmpID[0] < A1EmpID ) || ( T000X26_A1EmpID[0] == A1EmpID ) && ( T000X26_A2AgeID[0] < A2AgeID ) || ( T000X26_A2AgeID[0] == A2AgeID ) && ( T000X26_A1EmpID[0] == A1EmpID ) && ( T000X26_A317OCompNro[0] < A317OCompNro ) || ( T000X26_A317OCompNro[0] == A317OCompNro ) && ( T000X26_A2AgeID[0] == A2AgeID ) && ( T000X26_A1EmpID[0] == A1EmpID ) && ( StringUtil.StrCmp(T000X26_A311OcTipoCod[0], A311OcTipoCod) < 0 ) ) )
            {
               pr_default.readNext(21);
            }
            if ( (pr_default.getStatus(21) != 101) && ( ( T000X26_A1EmpID[0] > A1EmpID ) || ( T000X26_A1EmpID[0] == A1EmpID ) && ( T000X26_A2AgeID[0] > A2AgeID ) || ( T000X26_A2AgeID[0] == A2AgeID ) && ( T000X26_A1EmpID[0] == A1EmpID ) && ( T000X26_A317OCompNro[0] > A317OCompNro ) || ( T000X26_A317OCompNro[0] == A317OCompNro ) && ( T000X26_A2AgeID[0] == A2AgeID ) && ( T000X26_A1EmpID[0] == A1EmpID ) && ( StringUtil.StrCmp(T000X26_A311OcTipoCod[0], A311OcTipoCod) > 0 ) ) )
            {
               A1EmpID = T000X26_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A2AgeID = T000X26_A2AgeID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
               A317OCompNro = T000X26_A317OCompNro[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317OCompNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A317OCompNro), 4, 0)));
               A311OcTipoCod = T000X26_A311OcTipoCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311OcTipoCod", A311OcTipoCod);
               RcdFound75 = 1;
            }
         }
         pr_default.close(21);
      }

      protected void move_previous( )
      {
         RcdFound75 = 0;
         /* Using cursor T000X27 */
         pr_default.execute(22, new Object[] {A1EmpID, A2AgeID, A317OCompNro, A311OcTipoCod});
         if ( (pr_default.getStatus(22) != 101) )
         {
            while ( (pr_default.getStatus(22) != 101) && ( ( T000X27_A1EmpID[0] > A1EmpID ) || ( T000X27_A1EmpID[0] == A1EmpID ) && ( T000X27_A2AgeID[0] > A2AgeID ) || ( T000X27_A2AgeID[0] == A2AgeID ) && ( T000X27_A1EmpID[0] == A1EmpID ) && ( T000X27_A317OCompNro[0] > A317OCompNro ) || ( T000X27_A317OCompNro[0] == A317OCompNro ) && ( T000X27_A2AgeID[0] == A2AgeID ) && ( T000X27_A1EmpID[0] == A1EmpID ) && ( StringUtil.StrCmp(T000X27_A311OcTipoCod[0], A311OcTipoCod) > 0 ) ) )
            {
               pr_default.readNext(22);
            }
            if ( (pr_default.getStatus(22) != 101) && ( ( T000X27_A1EmpID[0] < A1EmpID ) || ( T000X27_A1EmpID[0] == A1EmpID ) && ( T000X27_A2AgeID[0] < A2AgeID ) || ( T000X27_A2AgeID[0] == A2AgeID ) && ( T000X27_A1EmpID[0] == A1EmpID ) && ( T000X27_A317OCompNro[0] < A317OCompNro ) || ( T000X27_A317OCompNro[0] == A317OCompNro ) && ( T000X27_A2AgeID[0] == A2AgeID ) && ( T000X27_A1EmpID[0] == A1EmpID ) && ( StringUtil.StrCmp(T000X27_A311OcTipoCod[0], A311OcTipoCod) < 0 ) ) )
            {
               A1EmpID = T000X27_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A2AgeID = T000X27_A2AgeID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
               A317OCompNro = T000X27_A317OCompNro[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317OCompNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A317OCompNro), 4, 0)));
               A311OcTipoCod = T000X27_A311OcTipoCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311OcTipoCod", A311OcTipoCod);
               RcdFound75 = 1;
            }
         }
         pr_default.close(22);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0X75( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            A345OcompTotal = O345OcompTotal;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
            A347OCompTotCant = O347OCompTotCant;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0X75( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound75 == 1 )
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A317OCompNro != Z317OCompNro ) || ( StringUtil.StrCmp(A311OcTipoCod, Z311OcTipoCod) != 0 ) )
               {
                  A1EmpID = Z1EmpID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
                  A2AgeID = Z2AgeID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
                  A317OCompNro = Z317OCompNro;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317OCompNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A317OCompNro), 4, 0)));
                  A311OcTipoCod = Z311OcTipoCod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311OcTipoCod", A311OcTipoCod);
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "EMPID");
                  AnyError = 1;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  A345OcompTotal = O345OcompTotal;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
                  A347OCompTotCant = O347OCompTotCant;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  A345OcompTotal = O345OcompTotal;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
                  A347OCompTotCant = O347OCompTotCant;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
                  Update0X75( ) ;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A317OCompNro != Z317OCompNro ) || ( StringUtil.StrCmp(A311OcTipoCod, Z311OcTipoCod) != 0 ) )
               {
                  /* Insert record */
                  A345OcompTotal = O345OcompTotal;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
                  A347OCompTotCant = O347OCompTotCant;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0X75( ) ;
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
                     A345OcompTotal = O345OcompTotal;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
                     A347OCompTotCant = O347OCompTotCant;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
                     GX_FocusControl = edtEmpID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0X75( ) ;
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
         if ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A317OCompNro != Z317OCompNro ) || ( StringUtil.StrCmp(A311OcTipoCod, Z311OcTipoCod) != 0 ) )
         {
            A1EmpID = Z1EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = Z2AgeID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A317OCompNro = Z317OCompNro;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317OCompNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A317OCompNro), 4, 0)));
            A311OcTipoCod = Z311OcTipoCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311OcTipoCod", A311OcTipoCod);
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            A345OcompTotal = O345OcompTotal;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
            A347OCompTotCant = O347OCompTotCant;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0X75( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000X5 */
            pr_default.execute(3, new Object[] {A1EmpID, A2AgeID, A317OCompNro, A311OcTipoCod});
            if ( (pr_default.getStatus(3) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"OrdenCompra"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(3) == 101) || ( Z318OCompFch != T000X5_A318OCompFch[0] ) || ( StringUtil.StrCmp(Z326OCompUser, T000X5_A326OCompUser[0]) != 0 ) || ( StringUtil.StrCmp(Z320OCompContac, T000X5_A320OCompContac[0]) != 0 ) || ( Z319OCompFchEnt != T000X5_A319OCompFchEnt[0] ) || ( StringUtil.StrCmp(Z324OCompLote, T000X5_A324OCompLote[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z325OCompObsv, T000X5_A325OCompObsv[0]) != 0 ) || ( Z340OCompFchOC != T000X5_A340OCompFchOC[0] ) || ( Z42BodCod != T000X5_A42BodCod[0] ) || ( StringUtil.StrCmp(Z321ClaOCCod, T000X5_A321ClaOCCod[0]) != 0 ) || ( StringUtil.StrCmp(Z37PrvRuc, T000X5_A37PrvRuc[0]) != 0 ) )
            {
               if ( Z318OCompFch != T000X5_A318OCompFch[0] )
               {
                  GXUtil.WriteLog("ordencompra:[seudo value changed for attri]"+"OCompFch");
                  GXUtil.WriteLogRaw("Old: ",Z318OCompFch);
                  GXUtil.WriteLogRaw("Current: ",T000X5_A318OCompFch[0]);
               }
               if ( StringUtil.StrCmp(Z326OCompUser, T000X5_A326OCompUser[0]) != 0 )
               {
                  GXUtil.WriteLog("ordencompra:[seudo value changed for attri]"+"OCompUser");
                  GXUtil.WriteLogRaw("Old: ",Z326OCompUser);
                  GXUtil.WriteLogRaw("Current: ",T000X5_A326OCompUser[0]);
               }
               if ( StringUtil.StrCmp(Z320OCompContac, T000X5_A320OCompContac[0]) != 0 )
               {
                  GXUtil.WriteLog("ordencompra:[seudo value changed for attri]"+"OCompContac");
                  GXUtil.WriteLogRaw("Old: ",Z320OCompContac);
                  GXUtil.WriteLogRaw("Current: ",T000X5_A320OCompContac[0]);
               }
               if ( Z319OCompFchEnt != T000X5_A319OCompFchEnt[0] )
               {
                  GXUtil.WriteLog("ordencompra:[seudo value changed for attri]"+"OCompFchEnt");
                  GXUtil.WriteLogRaw("Old: ",Z319OCompFchEnt);
                  GXUtil.WriteLogRaw("Current: ",T000X5_A319OCompFchEnt[0]);
               }
               if ( StringUtil.StrCmp(Z324OCompLote, T000X5_A324OCompLote[0]) != 0 )
               {
                  GXUtil.WriteLog("ordencompra:[seudo value changed for attri]"+"OCompLote");
                  GXUtil.WriteLogRaw("Old: ",Z324OCompLote);
                  GXUtil.WriteLogRaw("Current: ",T000X5_A324OCompLote[0]);
               }
               if ( StringUtil.StrCmp(Z325OCompObsv, T000X5_A325OCompObsv[0]) != 0 )
               {
                  GXUtil.WriteLog("ordencompra:[seudo value changed for attri]"+"OCompObsv");
                  GXUtil.WriteLogRaw("Old: ",Z325OCompObsv);
                  GXUtil.WriteLogRaw("Current: ",T000X5_A325OCompObsv[0]);
               }
               if ( Z340OCompFchOC != T000X5_A340OCompFchOC[0] )
               {
                  GXUtil.WriteLog("ordencompra:[seudo value changed for attri]"+"OCompFchOC");
                  GXUtil.WriteLogRaw("Old: ",Z340OCompFchOC);
                  GXUtil.WriteLogRaw("Current: ",T000X5_A340OCompFchOC[0]);
               }
               if ( Z42BodCod != T000X5_A42BodCod[0] )
               {
                  GXUtil.WriteLog("ordencompra:[seudo value changed for attri]"+"BodCod");
                  GXUtil.WriteLogRaw("Old: ",Z42BodCod);
                  GXUtil.WriteLogRaw("Current: ",T000X5_A42BodCod[0]);
               }
               if ( StringUtil.StrCmp(Z321ClaOCCod, T000X5_A321ClaOCCod[0]) != 0 )
               {
                  GXUtil.WriteLog("ordencompra:[seudo value changed for attri]"+"ClaOCCod");
                  GXUtil.WriteLogRaw("Old: ",Z321ClaOCCod);
                  GXUtil.WriteLogRaw("Current: ",T000X5_A321ClaOCCod[0]);
               }
               if ( StringUtil.StrCmp(Z37PrvRuc, T000X5_A37PrvRuc[0]) != 0 )
               {
                  GXUtil.WriteLog("ordencompra:[seudo value changed for attri]"+"PrvRuc");
                  GXUtil.WriteLogRaw("Old: ",Z37PrvRuc);
                  GXUtil.WriteLogRaw("Current: ",T000X5_A37PrvRuc[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"OrdenCompra"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0X75( )
      {
         BeforeValidate0X75( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0X75( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0X75( 0) ;
            CheckOptimisticConcurrency0X75( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0X75( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0X75( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000X28 */
                     pr_default.execute(23, new Object[] {A317OCompNro, n318OCompFch, A318OCompFch, n326OCompUser, A326OCompUser, n320OCompContac, A320OCompContac, n319OCompFchEnt, A319OCompFchEnt, n324OCompLote, A324OCompLote, n325OCompObsv, A325OCompObsv, n340OCompFchOC, A340OCompFchOC, A1EmpID, A2AgeID, A42BodCod, A311OcTipoCod, A321ClaOCCod, A37PrvRuc});
                     pr_default.close(23);
                     dsDefault.SmartCacheProvider.SetUpdated("OrdenCompra") ;
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
                           ProcessLevel0X75( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption0X0( ) ;
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
               Load0X75( ) ;
            }
            EndLevel0X75( ) ;
         }
         CloseExtendedTableCursors0X75( ) ;
      }

      protected void Update0X75( )
      {
         BeforeValidate0X75( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0X75( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0X75( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0X75( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0X75( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000X29 */
                     pr_default.execute(24, new Object[] {n318OCompFch, A318OCompFch, n326OCompUser, A326OCompUser, n320OCompContac, A320OCompContac, n319OCompFchEnt, A319OCompFchEnt, n324OCompLote, A324OCompLote, n325OCompObsv, A325OCompObsv, n340OCompFchOC, A340OCompFchOC, A42BodCod, A321ClaOCCod, A37PrvRuc, A1EmpID, A2AgeID, A317OCompNro, A311OcTipoCod});
                     pr_default.close(24);
                     dsDefault.SmartCacheProvider.SetUpdated("OrdenCompra") ;
                     if ( (pr_default.getStatus(24) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"OrdenCompra"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0X75( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0X75( ) ;
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
            EndLevel0X75( ) ;
         }
         CloseExtendedTableCursors0X75( ) ;
      }

      protected void DeferredUpdate0X75( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0X75( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0X75( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0X75( ) ;
            AfterConfirm0X75( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0X75( ) ;
               if ( AnyError == 0 )
               {
                  A345OcompTotal = O345OcompTotal;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
                  A347OCompTotCant = O347OCompTotCant;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
                  ScanStart0X80( ) ;
                  while ( RcdFound80 != 0 )
                  {
                     getByPrimaryKey0X80( ) ;
                     Delete0X80( ) ;
                     ScanNext0X80( ) ;
                     O345OcompTotal = A345OcompTotal;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
                     O347OCompTotCant = A347OCompTotCant;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
                  }
                  ScanEnd0X80( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000X30 */
                     pr_default.execute(25, new Object[] {A1EmpID, A2AgeID, A317OCompNro, A311OcTipoCod});
                     pr_default.close(25);
                     dsDefault.SmartCacheProvider.SetUpdated("OrdenCompra") ;
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
         sMode75 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0X75( ) ;
         Gx_mode = sMode75;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0X75( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV19Pgmname = "OrdenCompra";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Pgmname", AV19Pgmname);
            /* Using cursor T000X31 */
            pr_default.execute(26, new Object[] {A1EmpID});
            A44empdsc = T000X31_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000X31_n44empdsc[0];
            pr_default.close(26);
            /* Using cursor T000X32 */
            pr_default.execute(27, new Object[] {A1EmpID, A2AgeID});
            A46AgeDsc = T000X32_A46AgeDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
            n46AgeDsc = T000X32_n46AgeDsc[0];
            pr_default.close(27);
            /* Using cursor T000X33 */
            pr_default.execute(28, new Object[] {A37PrvRuc});
            A184PrvDsc = T000X33_A184PrvDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184PrvDsc", A184PrvDsc);
            n184PrvDsc = T000X33_n184PrvDsc[0];
            A187PrvEmail = T000X33_A187PrvEmail[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187PrvEmail", A187PrvEmail);
            n187PrvEmail = T000X33_n187PrvEmail[0];
            pr_default.close(28);
            /* Using cursor T000X34 */
            pr_default.execute(29, new Object[] {A1EmpID, A2AgeID, A311OcTipoCod});
            A313OctipDsc = T000X34_A313OctipDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313OctipDsc", A313OctipDsc);
            n313OctipDsc = T000X34_n313OctipDsc[0];
            A314OctipEst = T000X34_A314OctipEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A314OctipEst", A314OctipEst);
            n314OctipEst = T000X34_n314OctipEst[0];
            pr_default.close(29);
            /* Using cursor T000X36 */
            pr_default.execute(30, new Object[] {A1EmpID, A2AgeID, A317OCompNro, A311OcTipoCod});
            if ( (pr_default.getStatus(30) != 101) )
            {
               A345OcompTotal = T000X36_A345OcompTotal[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
               A347OCompTotCant = T000X36_A347OCompTotCant[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
            }
            else
            {
               A345OcompTotal = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
               A347OCompTotCant = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
            }
            pr_default.close(30);
            /* Using cursor T000X37 */
            pr_default.execute(31, new Object[] {A1EmpID, A2AgeID, A321ClaOCCod});
            A322ClaOCDsc = T000X37_A322ClaOCDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A322ClaOCDsc", A322ClaOCDsc);
            n322ClaOCDsc = T000X37_n322ClaOCDsc[0];
            pr_default.close(31);
            /* Using cursor T000X38 */
            pr_default.execute(32, new Object[] {A1EmpID, A42BodCod});
            A217BodDsc = T000X38_A217BodDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
            n217BodDsc = T000X38_n217BodDsc[0];
            A218BodEst = T000X38_A218BodEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218BodEst", A218BodEst);
            n218BodEst = T000X38_n218BodEst[0];
            pr_default.close(32);
         }
      }

      protected void ProcessNestedLevel0X80( )
      {
         s345OcompTotal = O345OcompTotal;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
         s347OCompTotCant = O347OCompTotCant;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
         nGXsfl_159_idx = 0;
         while ( nGXsfl_159_idx < nRC_GXsfl_159 )
         {
            ReadRow0X80( ) ;
            if ( ( nRcdExists_80 != 0 ) || ( nIsMod_80 != 0 ) )
            {
               standaloneNotModal0X80( ) ;
               GetKey0X80( ) ;
               if ( ( nRcdExists_80 == 0 ) && ( nRcdDeleted_80 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert0X80( ) ;
               }
               else
               {
                  if ( RcdFound80 != 0 )
                  {
                     if ( ( nRcdDeleted_80 != 0 ) && ( nRcdExists_80 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete0X80( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_80 != 0 ) && ( nRcdExists_80 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update0X80( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_80 == 0 )
                     {
                        GXCCtl = "OCDETID_" + sGXsfl_159_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtocDetID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
               O345OcompTotal = A345OcompTotal;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
               O347OCompTotCant = A347OCompTotCant;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
            }
            ChangePostValue( edtocDetID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A342ocDetID), 4, 0, ",", ""))) ;
            ChangePostValue( edtPrdCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A286PrdCod), 4, 0, ",", ""))) ;
            ChangePostValue( edtprdNombre_Internalname, A309prdNombre) ;
            ChangePostValue( edtocDetCant_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A343ocDetCant), 4, 0, ",", ""))) ;
            ChangePostValue( edtocDetValor_Internalname, StringUtil.LTrim( StringUtil.NToC( A344ocDetValor, 13, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z342ocDetID_"+sGXsfl_159_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z342ocDetID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z343ocDetCant_"+sGXsfl_159_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z343ocDetCant), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z344ocDetValor_"+sGXsfl_159_idx, StringUtil.LTrim( StringUtil.NToC( Z344ocDetValor, 10, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z286PrdCod_"+sGXsfl_159_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z286PrdCod), 4, 0, ",", ""))) ;
            ChangePostValue( "T344ocDetValor_"+sGXsfl_159_idx, StringUtil.LTrim( StringUtil.NToC( O344ocDetValor, 10, 2, ",", ""))) ;
            ChangePostValue( "T343ocDetCant_"+sGXsfl_159_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(O343ocDetCant), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_80_"+sGXsfl_159_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_80), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_80_"+sGXsfl_159_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_80), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_80_"+sGXsfl_159_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_80), 4, 0, ",", ""))) ;
            if ( nIsMod_80 != 0 )
            {
               ChangePostValue( "OCDETID_"+sGXsfl_159_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtocDetID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRDCOD_"+sGXsfl_159_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrdCod_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRDNOMBRE_"+sGXsfl_159_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtprdNombre_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "OCDETCANT_"+sGXsfl_159_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtocDetCant_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "OCDETVALOR_"+sGXsfl_159_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtocDetValor_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0X80( ) ;
         if ( AnyError != 0 )
         {
            O345OcompTotal = s345OcompTotal;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
            O347OCompTotCant = s347OCompTotCant;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
         }
         nRcdExists_80 = 0;
         nIsMod_80 = 0;
         nRcdDeleted_80 = 0;
      }

      protected void ProcessLevel0X75( )
      {
         /* Save parent mode. */
         sMode75 = Gx_mode;
         ProcessNestedLevel0X80( ) ;
         if ( AnyError != 0 )
         {
            O345OcompTotal = s345OcompTotal;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
            O347OCompTotCant = s347OCompTotCant;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
         }
         /* Restore parent mode. */
         Gx_mode = sMode75;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         /* ' Update level parameters */
      }

      protected void EndLevel0X75( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(3);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0X75( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(4);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(26);
            pr_default.close(27);
            pr_default.close(32);
            pr_default.close(29);
            pr_default.close(31);
            pr_default.close(28);
            pr_default.close(30);
            pr_default.close(2);
            context.CommitDataStores("ordencompra",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0X0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(4);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(26);
            pr_default.close(27);
            pr_default.close(32);
            pr_default.close(29);
            pr_default.close(31);
            pr_default.close(28);
            pr_default.close(30);
            pr_default.close(2);
            context.RollbackDataStores("ordencompra",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0X75( )
      {
         /* Scan By routine */
         /* Using cursor T000X39 */
         pr_default.execute(33);
         RcdFound75 = 0;
         if ( (pr_default.getStatus(33) != 101) )
         {
            RcdFound75 = 1;
            A1EmpID = T000X39_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = T000X39_A2AgeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A317OCompNro = T000X39_A317OCompNro[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317OCompNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A317OCompNro), 4, 0)));
            A311OcTipoCod = T000X39_A311OcTipoCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311OcTipoCod", A311OcTipoCod);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0X75( )
      {
         /* Scan next routine */
         pr_default.readNext(33);
         RcdFound75 = 0;
         if ( (pr_default.getStatus(33) != 101) )
         {
            RcdFound75 = 1;
            A1EmpID = T000X39_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = T000X39_A2AgeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A317OCompNro = T000X39_A317OCompNro[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317OCompNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A317OCompNro), 4, 0)));
            A311OcTipoCod = T000X39_A311OcTipoCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311OcTipoCod", A311OcTipoCod);
         }
      }

      protected void ScanEnd0X75( )
      {
         pr_default.close(33);
      }

      protected void AfterConfirm0X75( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0X75( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0X75( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0X75( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0X75( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0X75( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0X75( )
      {
         edtEmpID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         edtAgeID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAgeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAgeID_Enabled), 5, 0)), true);
         edtOCompUser_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOCompUser_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOCompUser_Enabled), 5, 0)), true);
         edtempdsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempdsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempdsc_Enabled), 5, 0)), true);
         edtAgeDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAgeDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAgeDsc_Enabled), 5, 0)), true);
         edtClaOCCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClaOCCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClaOCCod_Enabled), 5, 0)), true);
         edtClaOCDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClaOCDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClaOCDsc_Enabled), 5, 0)), true);
         edtOCompFch_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOCompFch_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOCompFch_Enabled), 5, 0)), true);
         edtPrvRuc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrvRuc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrvRuc_Enabled), 5, 0)), true);
         edtPrvDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrvDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrvDsc_Enabled), 5, 0)), true);
         edtPrvEmail_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrvEmail_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrvEmail_Enabled), 5, 0)), true);
         edtOCompNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOCompNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOCompNro_Enabled), 5, 0)), true);
         edtOCompFchOC_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOCompFchOC_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOCompFchOC_Enabled), 5, 0)), true);
         edtOCompContac_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOCompContac_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOCompContac_Enabled), 5, 0)), true);
         edtOcTipoCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOcTipoCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOcTipoCod_Enabled), 5, 0)), true);
         edtOctipDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOctipDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOctipDsc_Enabled), 5, 0)), true);
         edtOctipEst_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOctipEst_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOctipEst_Enabled), 5, 0)), true);
         edtBodCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodCod_Enabled), 5, 0)), true);
         edtBodDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodDsc_Enabled), 5, 0)), true);
         edtBodEst_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodEst_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodEst_Enabled), 5, 0)), true);
         edtOCompFchEnt_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOCompFchEnt_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOCompFchEnt_Enabled), 5, 0)), true);
         edtOCompLote_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOCompLote_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOCompLote_Enabled), 5, 0)), true);
         edtOCompObsv_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOCompObsv_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOCompObsv_Enabled), 5, 0)), true);
         edtOCompTotCant_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOCompTotCant_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOCompTotCant_Enabled), 5, 0)), true);
         edtOcompTotal_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOcompTotal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOcompTotal_Enabled), 5, 0)), true);
      }

      protected void ZM0X80( short GX_JID )
      {
         if ( ( GX_JID == 39 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z343ocDetCant = T000X3_A343ocDetCant[0];
               Z344ocDetValor = T000X3_A344ocDetValor[0];
               Z286PrdCod = T000X3_A286PrdCod[0];
            }
            else
            {
               Z343ocDetCant = A343ocDetCant;
               Z344ocDetValor = A344ocDetValor;
               Z286PrdCod = A286PrdCod;
            }
         }
         if ( GX_JID == -39 )
         {
            Z317OCompNro = A317OCompNro;
            Z311OcTipoCod = A311OcTipoCod;
            Z342ocDetID = A342ocDetID;
            Z343ocDetCant = A343ocDetCant;
            Z344ocDetValor = A344ocDetValor;
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z286PrdCod = A286PrdCod;
            Z309prdNombre = A309prdNombre;
         }
      }

      protected void standaloneNotModal0X80( )
      {
      }

      protected void standaloneModal0X80( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtocDetID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtocDetID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtocDetID_Enabled), 5, 0)), !bGXsfl_159_Refreshing);
         }
         else
         {
            edtocDetID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtocDetID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtocDetID_Enabled), 5, 0)), !bGXsfl_159_Refreshing);
         }
      }

      protected void Load0X80( )
      {
         /* Using cursor T000X40 */
         pr_default.execute(34, new Object[] {A1EmpID, A2AgeID, A317OCompNro, A311OcTipoCod, A342ocDetID});
         if ( (pr_default.getStatus(34) != 101) )
         {
            RcdFound80 = 1;
            A309prdNombre = T000X40_A309prdNombre[0];
            n309prdNombre = T000X40_n309prdNombre[0];
            A343ocDetCant = T000X40_A343ocDetCant[0];
            n343ocDetCant = T000X40_n343ocDetCant[0];
            A344ocDetValor = T000X40_A344ocDetValor[0];
            n344ocDetValor = T000X40_n344ocDetValor[0];
            A286PrdCod = T000X40_A286PrdCod[0];
            ZM0X80( -39) ;
         }
         pr_default.close(34);
         OnLoadActions0X80( ) ;
      }

      protected void OnLoadActions0X80( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A347OCompTotCant = (decimal)(O347OCompTotCant+A343ocDetCant);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A347OCompTotCant = (decimal)(O347OCompTotCant+A343ocDetCant-O343ocDetCant);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A347OCompTotCant = (decimal)(O347OCompTotCant-O343ocDetCant);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
               }
            }
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A345OcompTotal = (decimal)(O345OcompTotal+A344ocDetValor);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A345OcompTotal = (decimal)(O345OcompTotal+A344ocDetValor-O344ocDetValor);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A345OcompTotal = (decimal)(O345OcompTotal-O344ocDetValor);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
               }
            }
         }
      }

      protected void CheckExtendedTable0X80( )
      {
         Gx_BScreen = 1;
         standaloneModal0X80( ) ;
         /* Using cursor T000X4 */
         pr_default.execute(2, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GXCCtl = "PRDCOD_" + sGXsfl_159_idx;
            GX_msglist.addItem("No existe 'Productos'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtPrdCod_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A309prdNombre = T000X4_A309prdNombre[0];
         n309prdNombre = T000X4_n309prdNombre[0];
         pr_default.close(2);
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A347OCompTotCant = (decimal)(O347OCompTotCant+A343ocDetCant);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A347OCompTotCant = (decimal)(O347OCompTotCant+A343ocDetCant-O343ocDetCant);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A347OCompTotCant = (decimal)(O347OCompTotCant-O343ocDetCant);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
               }
            }
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A345OcompTotal = (decimal)(O345OcompTotal+A344ocDetValor);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A345OcompTotal = (decimal)(O345OcompTotal+A344ocDetValor-O344ocDetValor);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A345OcompTotal = (decimal)(O345OcompTotal-O344ocDetValor);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
               }
            }
         }
      }

      protected void CloseExtendedTableCursors0X80( )
      {
         pr_default.close(2);
      }

      protected void enableDisable0X80( )
      {
      }

      protected void gxLoad_40( short A1EmpID ,
                                short A2AgeID ,
                                short A286PrdCod )
      {
         /* Using cursor T000X41 */
         pr_default.execute(35, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
         if ( (pr_default.getStatus(35) == 101) )
         {
            GXCCtl = "PRDCOD_" + sGXsfl_159_idx;
            GX_msglist.addItem("No existe 'Productos'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtPrdCod_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A309prdNombre = T000X41_A309prdNombre[0];
         n309prdNombre = T000X41_n309prdNombre[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A309prdNombre)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(35) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(35);
      }

      protected void GetKey0X80( )
      {
         /* Using cursor T000X42 */
         pr_default.execute(36, new Object[] {A1EmpID, A2AgeID, A317OCompNro, A311OcTipoCod, A342ocDetID});
         if ( (pr_default.getStatus(36) != 101) )
         {
            RcdFound80 = 1;
         }
         else
         {
            RcdFound80 = 0;
         }
         pr_default.close(36);
      }

      protected void getByPrimaryKey0X80( )
      {
         /* Using cursor T000X3 */
         pr_default.execute(1, new Object[] {A1EmpID, A2AgeID, A317OCompNro, A311OcTipoCod, A342ocDetID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0X80( 39) ;
            RcdFound80 = 1;
            InitializeNonKey0X80( ) ;
            A342ocDetID = T000X3_A342ocDetID[0];
            A343ocDetCant = T000X3_A343ocDetCant[0];
            n343ocDetCant = T000X3_n343ocDetCant[0];
            A344ocDetValor = T000X3_A344ocDetValor[0];
            n344ocDetValor = T000X3_n344ocDetValor[0];
            A286PrdCod = T000X3_A286PrdCod[0];
            O344ocDetValor = A344ocDetValor;
            n344ocDetValor = false;
            O343ocDetCant = A343ocDetCant;
            n343ocDetCant = false;
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z317OCompNro = A317OCompNro;
            Z311OcTipoCod = A311OcTipoCod;
            Z342ocDetID = A342ocDetID;
            sMode80 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0X80( ) ;
            Gx_mode = sMode80;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound80 = 0;
            InitializeNonKey0X80( ) ;
            sMode80 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal0X80( ) ;
            Gx_mode = sMode80;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes0X80( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0X80( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000X2 */
            pr_default.execute(0, new Object[] {A1EmpID, A2AgeID, A317OCompNro, A311OcTipoCod, A342ocDetID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"OrdenCompraocDet"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z343ocDetCant != T000X2_A343ocDetCant[0] ) || ( Z344ocDetValor != T000X2_A344ocDetValor[0] ) || ( Z286PrdCod != T000X2_A286PrdCod[0] ) )
            {
               if ( Z343ocDetCant != T000X2_A343ocDetCant[0] )
               {
                  GXUtil.WriteLog("ordencompra:[seudo value changed for attri]"+"ocDetCant");
                  GXUtil.WriteLogRaw("Old: ",Z343ocDetCant);
                  GXUtil.WriteLogRaw("Current: ",T000X2_A343ocDetCant[0]);
               }
               if ( Z344ocDetValor != T000X2_A344ocDetValor[0] )
               {
                  GXUtil.WriteLog("ordencompra:[seudo value changed for attri]"+"ocDetValor");
                  GXUtil.WriteLogRaw("Old: ",Z344ocDetValor);
                  GXUtil.WriteLogRaw("Current: ",T000X2_A344ocDetValor[0]);
               }
               if ( Z286PrdCod != T000X2_A286PrdCod[0] )
               {
                  GXUtil.WriteLog("ordencompra:[seudo value changed for attri]"+"PrdCod");
                  GXUtil.WriteLogRaw("Old: ",Z286PrdCod);
                  GXUtil.WriteLogRaw("Current: ",T000X2_A286PrdCod[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"OrdenCompraocDet"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0X80( )
      {
         BeforeValidate0X80( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0X80( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0X80( 0) ;
            CheckOptimisticConcurrency0X80( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0X80( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0X80( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000X43 */
                     pr_default.execute(37, new Object[] {A317OCompNro, A311OcTipoCod, A342ocDetID, n343ocDetCant, A343ocDetCant, n344ocDetValor, A344ocDetValor, A1EmpID, A2AgeID, A286PrdCod});
                     pr_default.close(37);
                     dsDefault.SmartCacheProvider.SetUpdated("OrdenCompraocDet") ;
                     if ( (pr_default.getStatus(37) == 1) )
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
               Load0X80( ) ;
            }
            EndLevel0X80( ) ;
         }
         CloseExtendedTableCursors0X80( ) ;
      }

      protected void Update0X80( )
      {
         BeforeValidate0X80( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0X80( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0X80( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0X80( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0X80( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000X44 */
                     pr_default.execute(38, new Object[] {n343ocDetCant, A343ocDetCant, n344ocDetValor, A344ocDetValor, A286PrdCod, A1EmpID, A2AgeID, A317OCompNro, A311OcTipoCod, A342ocDetID});
                     pr_default.close(38);
                     dsDefault.SmartCacheProvider.SetUpdated("OrdenCompraocDet") ;
                     if ( (pr_default.getStatus(38) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"OrdenCompraocDet"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0X80( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey0X80( ) ;
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
            EndLevel0X80( ) ;
         }
         CloseExtendedTableCursors0X80( ) ;
      }

      protected void DeferredUpdate0X80( )
      {
      }

      protected void Delete0X80( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate0X80( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0X80( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0X80( ) ;
            AfterConfirm0X80( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0X80( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000X45 */
                  pr_default.execute(39, new Object[] {A1EmpID, A2AgeID, A317OCompNro, A311OcTipoCod, A342ocDetID});
                  pr_default.close(39);
                  dsDefault.SmartCacheProvider.SetUpdated("OrdenCompraocDet") ;
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
         sMode80 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0X80( ) ;
         Gx_mode = sMode80;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0X80( )
      {
         standaloneModal0X80( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000X46 */
            pr_default.execute(40, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
            A309prdNombre = T000X46_A309prdNombre[0];
            n309prdNombre = T000X46_n309prdNombre[0];
            pr_default.close(40);
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               A347OCompTotCant = (decimal)(O347OCompTotCant+A343ocDetCant);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
               {
                  A347OCompTotCant = (decimal)(O347OCompTotCant+A343ocDetCant-O343ocDetCant);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
               }
               else
               {
                  if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
                  {
                     A347OCompTotCant = (decimal)(O347OCompTotCant-O343ocDetCant);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
                  }
               }
            }
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               A345OcompTotal = (decimal)(O345OcompTotal+A344ocDetValor);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
               {
                  A345OcompTotal = (decimal)(O345OcompTotal+A344ocDetValor-O344ocDetValor);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
               }
               else
               {
                  if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
                  {
                     A345OcompTotal = (decimal)(O345OcompTotal-O344ocDetValor);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
                  }
               }
            }
         }
      }

      protected void EndLevel0X80( )
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

      public void ScanStart0X80( )
      {
         /* Scan By routine */
         /* Using cursor T000X47 */
         pr_default.execute(41, new Object[] {A1EmpID, A2AgeID, A317OCompNro, A311OcTipoCod});
         RcdFound80 = 0;
         if ( (pr_default.getStatus(41) != 101) )
         {
            RcdFound80 = 1;
            A342ocDetID = T000X47_A342ocDetID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0X80( )
      {
         /* Scan next routine */
         pr_default.readNext(41);
         RcdFound80 = 0;
         if ( (pr_default.getStatus(41) != 101) )
         {
            RcdFound80 = 1;
            A342ocDetID = T000X47_A342ocDetID[0];
         }
      }

      protected void ScanEnd0X80( )
      {
         pr_default.close(41);
      }

      protected void AfterConfirm0X80( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0X80( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0X80( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0X80( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0X80( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0X80( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0X80( )
      {
         edtocDetID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtocDetID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtocDetID_Enabled), 5, 0)), !bGXsfl_159_Refreshing);
         edtPrdCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrdCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrdCod_Enabled), 5, 0)), !bGXsfl_159_Refreshing);
         edtprdNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtprdNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtprdNombre_Enabled), 5, 0)), !bGXsfl_159_Refreshing);
         edtocDetCant_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtocDetCant_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtocDetCant_Enabled), 5, 0)), !bGXsfl_159_Refreshing);
         edtocDetValor_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtocDetValor_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtocDetValor_Enabled), 5, 0)), !bGXsfl_159_Refreshing);
      }

      protected void send_integrity_lvl_hashes0X80( )
      {
      }

      protected void send_integrity_lvl_hashes0X75( )
      {
      }

      protected void SubsflControlProps_15980( )
      {
         edtocDetID_Internalname = "OCDETID_"+sGXsfl_159_idx;
         edtPrdCod_Internalname = "PRDCOD_"+sGXsfl_159_idx;
         imgprompt_286_Internalname = "PROMPT_286_"+sGXsfl_159_idx;
         edtprdNombre_Internalname = "PRDNOMBRE_"+sGXsfl_159_idx;
         edtocDetCant_Internalname = "OCDETCANT_"+sGXsfl_159_idx;
         edtocDetValor_Internalname = "OCDETVALOR_"+sGXsfl_159_idx;
      }

      protected void SubsflControlProps_fel_15980( )
      {
         edtocDetID_Internalname = "OCDETID_"+sGXsfl_159_fel_idx;
         edtPrdCod_Internalname = "PRDCOD_"+sGXsfl_159_fel_idx;
         imgprompt_286_Internalname = "PROMPT_286_"+sGXsfl_159_fel_idx;
         edtprdNombre_Internalname = "PRDNOMBRE_"+sGXsfl_159_fel_idx;
         edtocDetCant_Internalname = "OCDETCANT_"+sGXsfl_159_fel_idx;
         edtocDetValor_Internalname = "OCDETVALOR_"+sGXsfl_159_fel_idx;
      }

      protected void AddRow0X80( )
      {
         nGXsfl_159_idx = (short)(nGXsfl_159_idx+1);
         sGXsfl_159_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_159_idx), 4, 0)), 4, "0");
         SubsflControlProps_15980( ) ;
         SendRow0X80( ) ;
      }

      protected void SendRow0X80( )
      {
         Gridordencompra_ocdetRow = GXWebRow.GetNew(context);
         if ( subGridordencompra_ocdet_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridordencompra_ocdet_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridordencompra_ocdet_Class, "") != 0 )
            {
               subGridordencompra_ocdet_Linesclass = subGridordencompra_ocdet_Class+"Odd";
            }
         }
         else if ( subGridordencompra_ocdet_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridordencompra_ocdet_Backstyle = 0;
            subGridordencompra_ocdet_Backcolor = subGridordencompra_ocdet_Allbackcolor;
            if ( StringUtil.StrCmp(subGridordencompra_ocdet_Class, "") != 0 )
            {
               subGridordencompra_ocdet_Linesclass = subGridordencompra_ocdet_Class+"Uniform";
            }
         }
         else if ( subGridordencompra_ocdet_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridordencompra_ocdet_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridordencompra_ocdet_Class, "") != 0 )
            {
               subGridordencompra_ocdet_Linesclass = subGridordencompra_ocdet_Class+"Odd";
            }
            subGridordencompra_ocdet_Backcolor = (int)(0x0);
         }
         else if ( subGridordencompra_ocdet_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridordencompra_ocdet_Backstyle = 1;
            if ( ((int)(((nGXsfl_159_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGridordencompra_ocdet_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridordencompra_ocdet_Class, "") != 0 )
               {
                  subGridordencompra_ocdet_Linesclass = subGridordencompra_ocdet_Class+"Odd";
               }
            }
            else
            {
               subGridordencompra_ocdet_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridordencompra_ocdet_Class, "") != 0 )
               {
                  subGridordencompra_ocdet_Linesclass = subGridordencompra_ocdet_Class+"Even";
               }
            }
         }
         imgprompt_286_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0202.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"AGEID"+"'), id:'"+"AGEID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"PRDCOD_"+sGXsfl_159_idx+"'), id:'"+"PRDCOD_"+sGXsfl_159_idx+"'"+",IOType:'out'}"+"],"+"gx.dom.form()."+"nIsMod_80_"+sGXsfl_159_idx+","+"'', false"+","+"false"+");");
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_80_" + sGXsfl_159_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 160,'',false,'" + sGXsfl_159_idx + "',159)\"";
         ROClassString = "Attribute";
         Gridordencompra_ocdetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtocDetID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A342ocDetID), 4, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A342ocDetID), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,160);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtocDetID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtocDetID_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)159,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_80_" + sGXsfl_159_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 161,'',false,'" + sGXsfl_159_idx + "',159)\"";
         ROClassString = "Attribute";
         Gridordencompra_ocdetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPrdCod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A286PrdCod), 4, 0, ",", "")),((edtPrdCod_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A286PrdCod), "ZZZ9")) : context.localUtil.Format( (decimal)(A286PrdCod), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,161);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPrdCod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtPrdCod_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)159,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         Gridordencompra_ocdetRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_286_Internalname,(String)sImgUrl,(String)imgprompt_286_Link,(String)"",(String)"",context.GetTheme( ),(int)imgprompt_286_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridordencompra_ocdetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtprdNombre_Internalname,(String)A309prdNombre,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtprdNombre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtprdNombre_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)80,(short)0,(short)0,(short)159,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_80_" + sGXsfl_159_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 163,'',false,'" + sGXsfl_159_idx + "',159)\"";
         ROClassString = "Attribute";
         Gridordencompra_ocdetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtocDetCant_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A343ocDetCant), 4, 0, ",", "")),((edtocDetCant_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A343ocDetCant), "ZZZ9")) : context.localUtil.Format( (decimal)(A343ocDetCant), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,163);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtocDetCant_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtocDetCant_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)159,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_80_" + sGXsfl_159_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 164,'',false,'" + sGXsfl_159_idx + "',159)\"";
         ROClassString = "Attribute";
         Gridordencompra_ocdetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtocDetValor_Internalname,StringUtil.LTrim( StringUtil.NToC( A344ocDetValor, 13, 2, ",", "")),((edtocDetValor_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A344ocDetValor, "ZZ,ZZZ,ZZZ.ZZ")) : context.localUtil.Format( A344ocDetValor, "ZZ,ZZZ,ZZZ.ZZ")),TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,164);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtocDetValor_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtocDetValor_Enabled,(short)0,(String)"text",(String)"",(short)80,(String)"px",(short)17,(String)"px",(short)13,(short)0,(short)0,(short)159,(short)1,(short)-1,(short)0,(bool)true,(String)"valores",(String)"right",(bool)false});
         context.httpAjaxContext.ajax_sending_grid_row(Gridordencompra_ocdetRow);
         send_integrity_lvl_hashes0X80( ) ;
         GXCCtl = "Z342ocDetID_" + sGXsfl_159_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z342ocDetID), 4, 0, ",", "")));
         GXCCtl = "Z343ocDetCant_" + sGXsfl_159_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z343ocDetCant), 4, 0, ",", "")));
         GXCCtl = "Z344ocDetValor_" + sGXsfl_159_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z344ocDetValor, 10, 2, ",", "")));
         GXCCtl = "Z286PrdCod_" + sGXsfl_159_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z286PrdCod), 4, 0, ",", "")));
         GXCCtl = "O344ocDetValor_" + sGXsfl_159_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( O344ocDetValor, 10, 2, ",", "")));
         GXCCtl = "O343ocDetCant_" + sGXsfl_159_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(O343ocDetCant), 4, 0, ",", "")));
         GXCCtl = "nRcdDeleted_80_" + sGXsfl_159_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_80), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_80_" + sGXsfl_159_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_80), 4, 0, ",", "")));
         GXCCtl = "nIsMod_80_" + sGXsfl_159_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_80), 4, 0, ",", "")));
         GXCCtl = "vMODE_" + sGXsfl_159_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_159_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV12TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV12TrnContext);
         }
         GXCCtl = "vEMPID_" + sGXsfl_159_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7EmpID), 4, 0, ",", "")));
         GXCCtl = "vAGEID_" + sGXsfl_159_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8AgeID), 4, 0, ",", "")));
         GXCCtl = "vOCOMPNRO_" + sGXsfl_159_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9OCompNro), 4, 0, ",", "")));
         GXCCtl = "vOCTIPOCOD_" + sGXsfl_159_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( AV10OcTipoCod));
         GXCCtl = "vUSUCOD_" + sGXsfl_159_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( AV18usucod));
         GxWebStd.gx_hidden_field( context, "OCDETID_"+sGXsfl_159_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtocDetID_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PRDCOD_"+sGXsfl_159_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrdCod_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PRDNOMBRE_"+sGXsfl_159_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtprdNombre_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "OCDETCANT_"+sGXsfl_159_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtocDetCant_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "OCDETVALOR_"+sGXsfl_159_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtocDetValor_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_286_"+sGXsfl_159_idx+"Link", StringUtil.RTrim( imgprompt_286_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridordencompra_ocdetContainer.AddRow(Gridordencompra_ocdetRow);
      }

      protected void ReadRow0X80( )
      {
         nGXsfl_159_idx = (short)(nGXsfl_159_idx+1);
         sGXsfl_159_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_159_idx), 4, 0)), 4, "0");
         SubsflControlProps_15980( ) ;
         edtocDetID_Enabled = (int)(context.localUtil.CToN( cgiGet( "OCDETID_"+sGXsfl_159_idx+"Enabled"), ",", "."));
         edtPrdCod_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRDCOD_"+sGXsfl_159_idx+"Enabled"), ",", "."));
         edtprdNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRDNOMBRE_"+sGXsfl_159_idx+"Enabled"), ",", "."));
         edtocDetCant_Enabled = (int)(context.localUtil.CToN( cgiGet( "OCDETCANT_"+sGXsfl_159_idx+"Enabled"), ",", "."));
         edtocDetValor_Enabled = (int)(context.localUtil.CToN( cgiGet( "OCDETVALOR_"+sGXsfl_159_idx+"Enabled"), ",", "."));
         imgprompt_1_Link = cgiGet( "PROMPT_286_"+sGXsfl_159_idx+"Link");
         if ( ( ( context.localUtil.CToN( cgiGet( edtocDetID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtocDetID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "OCDETID_" + sGXsfl_159_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtocDetID_Internalname;
            wbErr = true;
            A342ocDetID = 0;
         }
         else
         {
            A342ocDetID = (short)(context.localUtil.CToN( cgiGet( edtocDetID_Internalname), ",", "."));
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtPrdCod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtPrdCod_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "PRDCOD_" + sGXsfl_159_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtPrdCod_Internalname;
            wbErr = true;
            A286PrdCod = 0;
         }
         else
         {
            A286PrdCod = (short)(context.localUtil.CToN( cgiGet( edtPrdCod_Internalname), ",", "."));
         }
         A309prdNombre = cgiGet( edtprdNombre_Internalname);
         n309prdNombre = false;
         if ( ( ( context.localUtil.CToN( cgiGet( edtocDetCant_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtocDetCant_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "OCDETCANT_" + sGXsfl_159_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtocDetCant_Internalname;
            wbErr = true;
            A343ocDetCant = 0;
            n343ocDetCant = false;
         }
         else
         {
            A343ocDetCant = (short)(context.localUtil.CToN( cgiGet( edtocDetCant_Internalname), ",", "."));
            n343ocDetCant = false;
         }
         n343ocDetCant = ((0==A343ocDetCant) ? true : false);
         if ( ( ( context.localUtil.CToN( cgiGet( edtocDetValor_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtocDetValor_Internalname), ",", ".") > 9999999.99m ) ) )
         {
            GXCCtl = "OCDETVALOR_" + sGXsfl_159_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtocDetValor_Internalname;
            wbErr = true;
            A344ocDetValor = 0;
            n344ocDetValor = false;
         }
         else
         {
            A344ocDetValor = context.localUtil.CToN( cgiGet( edtocDetValor_Internalname), ",", ".");
            n344ocDetValor = false;
         }
         n344ocDetValor = ((Convert.ToDecimal(0)==A344ocDetValor) ? true : false);
         GXCCtl = "Z342ocDetID_" + sGXsfl_159_idx;
         Z342ocDetID = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z343ocDetCant_" + sGXsfl_159_idx;
         Z343ocDetCant = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         n343ocDetCant = ((0==A343ocDetCant) ? true : false);
         GXCCtl = "Z344ocDetValor_" + sGXsfl_159_idx;
         Z344ocDetValor = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n344ocDetValor = ((Convert.ToDecimal(0)==A344ocDetValor) ? true : false);
         GXCCtl = "Z286PrdCod_" + sGXsfl_159_idx;
         Z286PrdCod = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "O344ocDetValor_" + sGXsfl_159_idx;
         O344ocDetValor = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n344ocDetValor = ((Convert.ToDecimal(0)==A344ocDetValor) ? true : false);
         GXCCtl = "O343ocDetCant_" + sGXsfl_159_idx;
         O343ocDetCant = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         n343ocDetCant = ((0==A343ocDetCant) ? true : false);
         GXCCtl = "nRcdDeleted_80_" + sGXsfl_159_idx;
         nRcdDeleted_80 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_80_" + sGXsfl_159_idx;
         nRcdExists_80 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_80_" + sGXsfl_159_idx;
         nIsMod_80 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void assign_properties_default( )
      {
         defedtocDetID_Enabled = edtocDetID_Enabled;
      }

      protected void ConfirmValues0X0( )
      {
         nGXsfl_159_idx = 0;
         sGXsfl_159_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_159_idx), 4, 0)), 4, "0");
         SubsflControlProps_15980( ) ;
         while ( nGXsfl_159_idx < nRC_GXsfl_159 )
         {
            nGXsfl_159_idx = (short)(nGXsfl_159_idx+1);
            sGXsfl_159_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_159_idx), 4, 0)), 4, "0");
            SubsflControlProps_15980( ) ;
            ChangePostValue( "Z342ocDetID_"+sGXsfl_159_idx, cgiGet( "ZT_"+"Z342ocDetID_"+sGXsfl_159_idx)) ;
            DeletePostValue( "ZT_"+"Z342ocDetID_"+sGXsfl_159_idx) ;
            ChangePostValue( "Z343ocDetCant_"+sGXsfl_159_idx, cgiGet( "ZT_"+"Z343ocDetCant_"+sGXsfl_159_idx)) ;
            DeletePostValue( "ZT_"+"Z343ocDetCant_"+sGXsfl_159_idx) ;
            ChangePostValue( "Z344ocDetValor_"+sGXsfl_159_idx, cgiGet( "ZT_"+"Z344ocDetValor_"+sGXsfl_159_idx)) ;
            DeletePostValue( "ZT_"+"Z344ocDetValor_"+sGXsfl_159_idx) ;
            ChangePostValue( "Z286PrdCod_"+sGXsfl_159_idx, cgiGet( "ZT_"+"Z286PrdCod_"+sGXsfl_159_idx)) ;
            DeletePostValue( "ZT_"+"Z286PrdCod_"+sGXsfl_159_idx) ;
         }
         ChangePostValue( "O344ocDetValor", cgiGet( "T344ocDetValor")) ;
         DeletePostValue( "T344ocDetValor") ;
         ChangePostValue( "O343ocDetCant", cgiGet( "T343ocDetCant")) ;
         DeletePostValue( "T343ocDetCant") ;
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
         context.SendWebValue( "Orden Compra") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20221029182147", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("ordencompra.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7EmpID) + "," + UrlEncode("" +AV8AgeID) + "," + UrlEncode("" +AV9OCompNro) + "," + UrlEncode(StringUtil.RTrim(AV10OcTipoCod)) + "," + UrlEncode(StringUtil.RTrim(AV18usucod))+"\">") ;
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
         forbiddenHiddens = "hsh" + "OrdenCompra";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format(A318OCompFch, "99/99/9999");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV14Insert_PrvRuc, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV15Insert_ClaOCCod, ""));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV16Insert_BodCod), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("ordencompra:[SendSecurityCheck value for]"+"OCompFch:"+context.localUtil.Format(A318OCompFch, "99/99/9999"));
         GXUtil.WriteLog("ordencompra:[SendSecurityCheck value for]"+"Insert_PrvRuc:"+StringUtil.RTrim( context.localUtil.Format( AV14Insert_PrvRuc, "")));
         GXUtil.WriteLog("ordencompra:[SendSecurityCheck value for]"+"Insert_ClaOCCod:"+StringUtil.RTrim( context.localUtil.Format( AV15Insert_ClaOCCod, "")));
         GXUtil.WriteLog("ordencompra:[SendSecurityCheck value for]"+"Insert_BodCod:"+context.localUtil.Format( (decimal)(AV16Insert_BodCod), "ZZZ9"));
         GXUtil.WriteLog("ordencompra:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1EmpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z2AgeID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z2AgeID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z317OCompNro", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z317OCompNro), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z311OcTipoCod", StringUtil.RTrim( Z311OcTipoCod));
         GxWebStd.gx_hidden_field( context, "Z318OCompFch", context.localUtil.DToC( Z318OCompFch, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z326OCompUser", Z326OCompUser);
         GxWebStd.gx_hidden_field( context, "Z320OCompContac", Z320OCompContac);
         GxWebStd.gx_hidden_field( context, "Z319OCompFchEnt", context.localUtil.DToC( Z319OCompFchEnt, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z324OCompLote", Z324OCompLote);
         GxWebStd.gx_hidden_field( context, "Z325OCompObsv", Z325OCompObsv);
         GxWebStd.gx_hidden_field( context, "Z340OCompFchOC", context.localUtil.DToC( Z340OCompFchOC, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z42BodCod", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z42BodCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z321ClaOCCod", StringUtil.RTrim( Z321ClaOCCod));
         GxWebStd.gx_hidden_field( context, "Z37PrvRuc", StringUtil.RTrim( Z37PrvRuc));
         GxWebStd.gx_hidden_field( context, "O345OcompTotal", StringUtil.LTrim( StringUtil.NToC( O345OcompTotal, 10, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "O347OCompTotCant", StringUtil.LTrim( StringUtil.NToC( O347OCompTotCant, 10, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_159", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_159_idx), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "N37PrvRuc", StringUtil.RTrim( A37PrvRuc));
         GxWebStd.gx_hidden_field( context, "N321ClaOCCod", StringUtil.RTrim( A321ClaOCCod));
         GxWebStd.gx_hidden_field( context, "N42BodCod", StringUtil.LTrim( StringUtil.NToC( (decimal)(A42BodCod), 4, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV12TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV12TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EmpID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8AgeID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8AgeID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vOCOMPNRO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9OCompNro), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vOCOMPNRO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9OCompNro), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vOCTIPOCOD", StringUtil.RTrim( AV10OcTipoCod));
         GxWebStd.gx_hidden_field( context, "gxhash_vOCTIPOCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV10OcTipoCod, "")), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_PRVRUC", StringUtil.RTrim( AV14Insert_PrvRuc));
         GxWebStd.gx_hidden_field( context, "vINSERT_CLAOCCOD", StringUtil.RTrim( AV15Insert_ClaOCCod));
         GxWebStd.gx_hidden_field( context, "vINSERT_BODCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16Insert_BodCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vUSUCOD", StringUtil.RTrim( AV18usucod));
         GxWebStd.gx_hidden_field( context, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV18usucod, "")), context));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV19Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void RenderHtmlCloseForm0X75( )
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
         return "OrdenCompra" ;
      }

      public override String GetPgmdesc( )
      {
         return "Orden Compra" ;
      }

      protected void InitializeNonKey0X75( )
      {
         A37PrvRuc = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PrvRuc", A37PrvRuc);
         A321ClaOCCod = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A321ClaOCCod", A321ClaOCCod);
         A42BodCod = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
         A318OCompFch = DateTime.MinValue;
         n318OCompFch = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A318OCompFch", context.localUtil.Format(A318OCompFch, "99/99/9999"));
         n318OCompFch = ((DateTime.MinValue==A318OCompFch) ? true : false);
         A326OCompUser = "";
         n326OCompUser = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A326OCompUser", A326OCompUser);
         n326OCompUser = (String.IsNullOrEmpty(StringUtil.RTrim( A326OCompUser)) ? true : false);
         A44empdsc = "";
         n44empdsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         A46AgeDsc = "";
         n46AgeDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
         A184PrvDsc = "";
         n184PrvDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184PrvDsc", A184PrvDsc);
         A187PrvEmail = "";
         n187PrvEmail = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187PrvEmail", A187PrvEmail);
         A320OCompContac = "";
         n320OCompContac = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A320OCompContac", A320OCompContac);
         n320OCompContac = (String.IsNullOrEmpty(StringUtil.RTrim( A320OCompContac)) ? true : false);
         A313OctipDsc = "";
         n313OctipDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313OctipDsc", A313OctipDsc);
         A314OctipEst = "";
         n314OctipEst = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A314OctipEst", A314OctipEst);
         A319OCompFchEnt = DateTime.MinValue;
         n319OCompFchEnt = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A319OCompFchEnt", context.localUtil.Format(A319OCompFchEnt, "99/99/9999"));
         n319OCompFchEnt = ((DateTime.MinValue==A319OCompFchEnt) ? true : false);
         A322ClaOCDsc = "";
         n322ClaOCDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A322ClaOCDsc", A322ClaOCDsc);
         A217BodDsc = "";
         n217BodDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
         A218BodEst = "";
         n218BodEst = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218BodEst", A218BodEst);
         A324OCompLote = "";
         n324OCompLote = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A324OCompLote", A324OCompLote);
         n324OCompLote = (String.IsNullOrEmpty(StringUtil.RTrim( A324OCompLote)) ? true : false);
         A325OCompObsv = "";
         n325OCompObsv = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A325OCompObsv", A325OCompObsv);
         n325OCompObsv = (String.IsNullOrEmpty(StringUtil.RTrim( A325OCompObsv)) ? true : false);
         A340OCompFchOC = DateTime.MinValue;
         n340OCompFchOC = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A340OCompFchOC", context.localUtil.Format(A340OCompFchOC, "99/99/9999"));
         n340OCompFchOC = ((DateTime.MinValue==A340OCompFchOC) ? true : false);
         A345OcompTotal = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
         A347OCompTotCant = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
         O345OcompTotal = A345OcompTotal;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345OcompTotal", StringUtil.LTrim( StringUtil.Str( A345OcompTotal, 10, 2)));
         O347OCompTotCant = A347OCompTotCant;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347OCompTotCant", StringUtil.LTrim( StringUtil.Str( A347OCompTotCant, 10, 2)));
         Z318OCompFch = DateTime.MinValue;
         Z326OCompUser = "";
         Z320OCompContac = "";
         Z319OCompFchEnt = DateTime.MinValue;
         Z324OCompLote = "";
         Z325OCompObsv = "";
         Z340OCompFchOC = DateTime.MinValue;
         Z42BodCod = 0;
         Z321ClaOCCod = "";
         Z37PrvRuc = "";
      }

      protected void InitAll0X75( )
      {
         A1EmpID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         A2AgeID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
         A317OCompNro = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317OCompNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A317OCompNro), 4, 0)));
         A311OcTipoCod = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311OcTipoCod", A311OcTipoCod);
         InitializeNonKey0X75( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A318OCompFch = i318OCompFch;
         n318OCompFch = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A318OCompFch", context.localUtil.Format(A318OCompFch, "99/99/9999"));
         A326OCompUser = i326OCompUser;
         n326OCompUser = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A326OCompUser", A326OCompUser);
      }

      protected void InitializeNonKey0X80( )
      {
         A286PrdCod = 0;
         A309prdNombre = "";
         n309prdNombre = false;
         A343ocDetCant = 0;
         n343ocDetCant = false;
         A344ocDetValor = 0;
         n344ocDetValor = false;
         O344ocDetValor = A344ocDetValor;
         n344ocDetValor = false;
         O343ocDetCant = A343ocDetCant;
         n343ocDetCant = false;
         Z343ocDetCant = 0;
         Z344ocDetValor = 0;
         Z286PrdCod = 0;
      }

      protected void InitAll0X80( )
      {
         A342ocDetID = 0;
         InitializeNonKey0X80( ) ;
      }

      protected void StandaloneModalInsert0X80( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20221029182276", true);
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
         context.AddJavascriptSource("ordencompra.js", "?20221029182277", false);
         /* End function include_jscripts */
      }

      protected void init_level_properties80( )
      {
         edtocDetID_Enabled = defedtocDetID_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtocDetID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtocDetID_Enabled), 5, 0)), !bGXsfl_159_Refreshing);
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
         edtAgeID_Internalname = "AGEID";
         edtOCompUser_Internalname = "OCOMPUSER";
         edtempdsc_Internalname = "EMPDSC";
         divSection1_Internalname = "SECTION1";
         edtAgeDsc_Internalname = "AGEDSC";
         divSection2_Internalname = "SECTION2";
         edtClaOCCod_Internalname = "CLAOCCOD";
         divSection10_Internalname = "SECTION10";
         edtClaOCDsc_Internalname = "CLAOCDSC";
         divSection11_Internalname = "SECTION11";
         edtOCompFch_Internalname = "OCOMPFCH";
         divSection3_Internalname = "SECTION3";
         edtPrvRuc_Internalname = "PRVRUC";
         divSection4_Internalname = "SECTION4";
         edtPrvDsc_Internalname = "PRVDSC";
         divSection5_Internalname = "SECTION5";
         edtPrvEmail_Internalname = "PRVEMAIL";
         divSection6_Internalname = "SECTION6";
         divGroup1table_Internalname = "GROUP1TABLE";
         grpGroup1_Internalname = "GROUP1";
         edtOCompNro_Internalname = "OCOMPNRO";
         edtOCompFchOC_Internalname = "OCOMPFCHOC";
         edtOCompContac_Internalname = "OCOMPCONTAC";
         edtOcTipoCod_Internalname = "OCTIPOCOD";
         divSection7_Internalname = "SECTION7";
         edtOctipDsc_Internalname = "OCTIPDSC";
         divSection8_Internalname = "SECTION8";
         edtOctipEst_Internalname = "OCTIPEST";
         divSection9_Internalname = "SECTION9";
         edtBodCod_Internalname = "BODCOD";
         divSection12_Internalname = "SECTION12";
         edtBodDsc_Internalname = "BODDSC";
         divSection13_Internalname = "SECTION13";
         edtBodEst_Internalname = "BODEST";
         divSection14_Internalname = "SECTION14";
         edtOCompFchEnt_Internalname = "OCOMPFCHENT";
         edtOCompLote_Internalname = "OCOMPLOTE";
         edtOCompObsv_Internalname = "OCOMPOBSV";
         lblTitleocdet_Internalname = "TITLEOCDET";
         edtocDetID_Internalname = "OCDETID";
         edtPrdCod_Internalname = "PRDCOD";
         edtprdNombre_Internalname = "PRDNOMBRE";
         edtocDetCant_Internalname = "OCDETCANT";
         edtocDetValor_Internalname = "OCDETVALOR";
         edtOCompTotCant_Internalname = "OCOMPTOTCANT";
         divSection15_Internalname = "SECTION15";
         edtOcompTotal_Internalname = "OCOMPTOTAL";
         divSection16_Internalname = "SECTION16";
         divOcdettable_Internalname = "OCDETTABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_1_Internalname = "PROMPT_1";
         imgprompt_2_Internalname = "PROMPT_2";
         imgprompt_321_Internalname = "PROMPT_321";
         imgprompt_37_Internalname = "PROMPT_37";
         imgprompt_311_Internalname = "PROMPT_311";
         imgprompt_42_Internalname = "PROMPT_42";
         imgprompt_286_Internalname = "PROMPT_286";
         subGridordencompra_ocdet_Internalname = "GRIDORDENCOMPRA_OCDET";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtocDetValor_Jsonclick = "";
         edtocDetCant_Jsonclick = "";
         edtprdNombre_Jsonclick = "";
         imgprompt_286_Visible = 1;
         imgprompt_286_Link = "";
         imgprompt_1_Visible = 1;
         edtPrdCod_Jsonclick = "";
         edtocDetID_Jsonclick = "";
         subGridordencompra_ocdet_Class = "Grid";
         subGridordencompra_ocdet_Backcolorstyle = 0;
         subGridordencompra_ocdet_Allowcollapsing = 0;
         subGridordencompra_ocdet_Allowselection = 0;
         edtocDetValor_Enabled = 1;
         edtocDetCant_Enabled = 1;
         edtprdNombre_Enabled = 0;
         edtPrdCod_Enabled = 1;
         edtocDetID_Enabled = 1;
         subGridordencompra_ocdet_Header = "";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtOcompTotal_Jsonclick = "";
         edtOcompTotal_Enabled = 0;
         edtOCompTotCant_Jsonclick = "";
         edtOCompTotCant_Enabled = 0;
         edtOCompObsv_Jsonclick = "";
         edtOCompObsv_Enabled = 1;
         edtOCompLote_Jsonclick = "";
         edtOCompLote_Enabled = 1;
         edtOCompFchEnt_Jsonclick = "";
         edtOCompFchEnt_Enabled = 1;
         edtBodEst_Jsonclick = "";
         edtBodEst_Enabled = 0;
         edtBodDsc_Jsonclick = "";
         edtBodDsc_Enabled = 0;
         imgprompt_42_Visible = 1;
         imgprompt_42_Link = "";
         edtBodCod_Jsonclick = "";
         edtBodCod_Enabled = 1;
         edtOctipEst_Jsonclick = "";
         edtOctipEst_Enabled = 0;
         edtOctipDsc_Jsonclick = "";
         edtOctipDsc_Enabled = 0;
         imgprompt_311_Visible = 1;
         imgprompt_311_Link = "";
         edtOcTipoCod_Jsonclick = "";
         edtOcTipoCod_Enabled = 1;
         edtOCompContac_Jsonclick = "";
         edtOCompContac_Enabled = 1;
         edtOCompFchOC_Jsonclick = "";
         edtOCompFchOC_Enabled = 1;
         edtOCompNro_Jsonclick = "";
         edtOCompNro_Enabled = 1;
         edtPrvEmail_Jsonclick = "";
         edtPrvEmail_Enabled = 0;
         edtPrvDsc_Jsonclick = "";
         edtPrvDsc_Enabled = 0;
         imgprompt_37_Visible = 1;
         imgprompt_37_Link = "";
         edtPrvRuc_Jsonclick = "";
         edtPrvRuc_Enabled = 1;
         edtOCompFch_Jsonclick = "";
         edtOCompFch_Enabled = 0;
         edtClaOCDsc_Jsonclick = "";
         edtClaOCDsc_Enabled = 0;
         imgprompt_321_Visible = 1;
         imgprompt_321_Link = "";
         edtClaOCCod_Jsonclick = "";
         edtClaOCCod_Enabled = 1;
         edtAgeDsc_Jsonclick = "";
         edtAgeDsc_Enabled = 0;
         edtempdsc_Jsonclick = "";
         edtempdsc_Enabled = 0;
         edtOCompUser_Jsonclick = "";
         edtOCompUser_Enabled = 1;
         edtOCompUser_Visible = 1;
         imgprompt_2_Link = "";
         edtAgeID_Jsonclick = "";
         edtAgeID_Enabled = 1;
         edtAgeID_Visible = 1;
         imgprompt_1_Link = "";
         edtEmpID_Jsonclick = "";
         edtEmpID_Enabled = 1;
         edtEmpID_Visible = 1;
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

      protected void gxnrGridordencompra_ocdet_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_15980( ) ;
         while ( nGXsfl_159_idx <= nRC_GXsfl_159 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0X80( ) ;
            standaloneModal0X80( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow0X80( ) ;
            nGXsfl_159_idx = (short)(nGXsfl_159_idx+1);
            sGXsfl_159_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_159_idx), 4, 0)), 4, "0");
            SubsflControlProps_15980( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Gridordencompra_ocdetContainer));
         /* End function gxnrGridordencompra_ocdet_newrow */
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
         /* Using cursor T000X31 */
         pr_default.execute(26, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(26) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A44empdsc = T000X31_A44empdsc[0];
         n44empdsc = T000X31_n44empdsc[0];
         pr_default.close(26);
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
         /* Using cursor T000X32 */
         pr_default.execute(27, new Object[] {A1EmpID, A2AgeID});
         if ( (pr_default.getStatus(27) == 101) )
         {
            GX_msglist.addItem("No existe 'Agencias'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A46AgeDsc = T000X32_A46AgeDsc[0];
         n46AgeDsc = T000X32_n46AgeDsc[0];
         pr_default.close(27);
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

      public void Valid_Octipocod( short GX_Parm1 ,
                                   short GX_Parm2 ,
                                   String GX_Parm3 ,
                                   short GX_Parm4 ,
                                   String GX_Parm5 ,
                                   String GX_Parm6 ,
                                   decimal GX_Parm7 ,
                                   decimal GX_Parm8 )
      {
         A1EmpID = GX_Parm1;
         A2AgeID = GX_Parm2;
         A311OcTipoCod = GX_Parm3;
         A317OCompNro = GX_Parm4;
         A313OctipDsc = GX_Parm5;
         n313OctipDsc = false;
         A314OctipEst = GX_Parm6;
         n314OctipEst = false;
         A345OcompTotal = GX_Parm7;
         A347OCompTotCant = GX_Parm8;
         /* Using cursor T000X34 */
         pr_default.execute(29, new Object[] {A1EmpID, A2AgeID, A311OcTipoCod});
         if ( (pr_default.getStatus(29) == 101) )
         {
            GX_msglist.addItem("No existe 'Octipos'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A313OctipDsc = T000X34_A313OctipDsc[0];
         n313OctipDsc = T000X34_n313OctipDsc[0];
         A314OctipEst = T000X34_A314OctipEst[0];
         n314OctipEst = T000X34_n314OctipEst[0];
         pr_default.close(29);
         /* Using cursor T000X36 */
         pr_default.execute(30, new Object[] {A1EmpID, A2AgeID, A317OCompNro, A311OcTipoCod});
         if ( (pr_default.getStatus(30) != 101) )
         {
            A345OcompTotal = T000X36_A345OcompTotal[0];
            A347OCompTotCant = T000X36_A347OCompTotCant[0];
         }
         else
         {
            A345OcompTotal = 0;
            A347OCompTotCant = 0;
         }
         pr_default.close(30);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A313OctipDsc = "";
            n313OctipDsc = false;
            A314OctipEst = "";
            n314OctipEst = false;
            A345OcompTotal = 0;
            A347OCompTotCant = 0;
         }
         isValidOutput.Add(StringUtil.RTrim( A313OctipDsc));
         isValidOutput.Add(StringUtil.RTrim( A314OctipEst));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A345OcompTotal, 10, 2, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A347OCompTotCant, 10, 2, ".", "")));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Claoccod( short GX_Parm1 ,
                                  short GX_Parm2 ,
                                  String GX_Parm3 ,
                                  String GX_Parm4 )
      {
         A1EmpID = GX_Parm1;
         A2AgeID = GX_Parm2;
         A321ClaOCCod = GX_Parm3;
         A322ClaOCDsc = GX_Parm4;
         n322ClaOCDsc = false;
         /* Using cursor T000X37 */
         pr_default.execute(31, new Object[] {A1EmpID, A2AgeID, A321ClaOCCod});
         if ( (pr_default.getStatus(31) == 101) )
         {
            GX_msglist.addItem("No existe 'Clase OC'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A322ClaOCDsc = T000X37_A322ClaOCDsc[0];
         n322ClaOCDsc = T000X37_n322ClaOCDsc[0];
         pr_default.close(31);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A322ClaOCDsc = "";
            n322ClaOCDsc = false;
         }
         isValidOutput.Add(StringUtil.RTrim( A322ClaOCDsc));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Prvruc( String GX_Parm1 ,
                                String GX_Parm2 ,
                                String GX_Parm3 )
      {
         A37PrvRuc = GX_Parm1;
         A184PrvDsc = GX_Parm2;
         n184PrvDsc = false;
         A187PrvEmail = GX_Parm3;
         n187PrvEmail = false;
         /* Using cursor T000X33 */
         pr_default.execute(28, new Object[] {A37PrvRuc});
         if ( (pr_default.getStatus(28) == 101) )
         {
            GX_msglist.addItem("No existe 'Proveedor'.", "ForeignKeyNotFound", 1, "PRVRUC");
            AnyError = 1;
            GX_FocusControl = edtPrvRuc_Internalname;
         }
         A184PrvDsc = T000X33_A184PrvDsc[0];
         n184PrvDsc = T000X33_n184PrvDsc[0];
         A187PrvEmail = T000X33_A187PrvEmail[0];
         n187PrvEmail = T000X33_n187PrvEmail[0];
         pr_default.close(28);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A184PrvDsc = "";
            n184PrvDsc = false;
            A187PrvEmail = "";
            n187PrvEmail = false;
         }
         isValidOutput.Add(A184PrvDsc);
         isValidOutput.Add(A187PrvEmail);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Bodcod( short GX_Parm1 ,
                                short GX_Parm2 ,
                                String GX_Parm3 ,
                                String GX_Parm4 )
      {
         A1EmpID = GX_Parm1;
         A42BodCod = GX_Parm2;
         A217BodDsc = GX_Parm3;
         n217BodDsc = false;
         A218BodEst = GX_Parm4;
         n218BodEst = false;
         /* Using cursor T000X38 */
         pr_default.execute(32, new Object[] {A1EmpID, A42BodCod});
         if ( (pr_default.getStatus(32) == 101) )
         {
            GX_msglist.addItem("No existe 'Bodegas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A217BodDsc = T000X38_A217BodDsc[0];
         n217BodDsc = T000X38_n217BodDsc[0];
         A218BodEst = T000X38_A218BodEst[0];
         n218BodEst = T000X38_n218BodEst[0];
         pr_default.close(32);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A217BodDsc = "";
            n217BodDsc = false;
            A218BodEst = "";
            n218BodEst = false;
         }
         isValidOutput.Add(StringUtil.RTrim( A217BodDsc));
         isValidOutput.Add(StringUtil.RTrim( A218BodEst));
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
         /* Using cursor T000X46 */
         pr_default.execute(40, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
         if ( (pr_default.getStatus(40) == 101) )
         {
            GX_msglist.addItem("No existe 'Productos'.", "ForeignKeyNotFound", 1, "PRDCOD");
            AnyError = 1;
            GX_FocusControl = edtPrdCod_Internalname;
         }
         A309prdNombre = T000X46_A309prdNombre[0];
         n309prdNombre = T000X46_n309prdNombre[0];
         pr_default.close(40);
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

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV8AgeID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV9OCompNro',fld:'vOCOMPNRO',pic:'ZZZ9',hsh:true},{av:'AV10OcTipoCod',fld:'vOCTIPOCOD',pic:'',hsh:true},{av:'AV18usucod',fld:'vUSUCOD',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV8AgeID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV9OCompNro',fld:'vOCOMPNRO',pic:'ZZZ9',hsh:true},{av:'AV10OcTipoCod',fld:'vOCTIPOCOD',pic:'',hsh:true},{av:'AV18usucod',fld:'vUSUCOD',pic:'',hsh:true},{av:'A318OCompFch',fld:'OCOMPFCH',pic:''},{av:'AV14Insert_PrvRuc',fld:'vINSERT_PRVRUC',pic:''},{av:'AV15Insert_ClaOCCod',fld:'vINSERT_CLAOCCOD',pic:''},{av:'AV16Insert_BodCod',fld:'vINSERT_BODCOD',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120X2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(40);
         pr_default.close(4);
         pr_default.close(26);
         pr_default.close(27);
         pr_default.close(32);
         pr_default.close(29);
         pr_default.close(31);
         pr_default.close(28);
         pr_default.close(30);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         wcpOAV10OcTipoCod = "";
         wcpOAV18usucod = "";
         Z311OcTipoCod = "";
         Z318OCompFch = DateTime.MinValue;
         Z326OCompUser = "";
         Z320OCompContac = "";
         Z319OCompFchEnt = DateTime.MinValue;
         Z324OCompLote = "";
         Z325OCompObsv = "";
         Z340OCompFchOC = DateTime.MinValue;
         Z321ClaOCCod = "";
         Z37PrvRuc = "";
         N37PrvRuc = "";
         N321ClaOCCod = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         A321ClaOCCod = "";
         A37PrvRuc = "";
         A311OcTipoCod = "";
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
         A326OCompUser = "";
         A44empdsc = "";
         A46AgeDsc = "";
         A322ClaOCDsc = "";
         A318OCompFch = DateTime.MinValue;
         A184PrvDsc = "";
         A187PrvEmail = "";
         A340OCompFchOC = DateTime.MinValue;
         A320OCompContac = "";
         A313OctipDsc = "";
         A314OctipEst = "";
         A217BodDsc = "";
         A218BodEst = "";
         A319OCompFchEnt = DateTime.MinValue;
         A324OCompLote = "";
         A325OCompObsv = "";
         lblTitleocdet_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridordencompra_ocdetContainer = new GXWebGrid( context);
         Gridordencompra_ocdetColumn = new GXWebColumn();
         A309prdNombre = "";
         sMode80 = "";
         sStyleString = "";
         AV14Insert_PrvRuc = "";
         AV15Insert_ClaOCCod = "";
         AV19Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode75 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         AV12TrnContext = new SdtTransactionContext(context);
         AV13WebSession = context.GetSession();
         AV17TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z44empdsc = "";
         Z46AgeDsc = "";
         Z184PrvDsc = "";
         Z187PrvEmail = "";
         Z313OctipDsc = "";
         Z314OctipEst = "";
         Z322ClaOCDsc = "";
         Z217BodDsc = "";
         Z218BodEst = "";
         T000X7_A44empdsc = new String[] {""} ;
         T000X7_n44empdsc = new bool[] {false} ;
         T000X8_A46AgeDsc = new String[] {""} ;
         T000X8_n46AgeDsc = new bool[] {false} ;
         T000X10_A313OctipDsc = new String[] {""} ;
         T000X10_n313OctipDsc = new bool[] {false} ;
         T000X10_A314OctipEst = new String[] {""} ;
         T000X10_n314OctipEst = new bool[] {false} ;
         T000X14_A345OcompTotal = new decimal[1] ;
         T000X14_A347OCompTotCant = new decimal[1] ;
         T000X9_A217BodDsc = new String[] {""} ;
         T000X9_n217BodDsc = new bool[] {false} ;
         T000X9_A218BodEst = new String[] {""} ;
         T000X9_n218BodEst = new bool[] {false} ;
         T000X11_A322ClaOCDsc = new String[] {""} ;
         T000X11_n322ClaOCDsc = new bool[] {false} ;
         T000X12_A184PrvDsc = new String[] {""} ;
         T000X12_n184PrvDsc = new bool[] {false} ;
         T000X12_A187PrvEmail = new String[] {""} ;
         T000X12_n187PrvEmail = new bool[] {false} ;
         T000X16_A317OCompNro = new short[1] ;
         T000X16_A318OCompFch = new DateTime[] {DateTime.MinValue} ;
         T000X16_n318OCompFch = new bool[] {false} ;
         T000X16_A326OCompUser = new String[] {""} ;
         T000X16_n326OCompUser = new bool[] {false} ;
         T000X16_A44empdsc = new String[] {""} ;
         T000X16_n44empdsc = new bool[] {false} ;
         T000X16_A46AgeDsc = new String[] {""} ;
         T000X16_n46AgeDsc = new bool[] {false} ;
         T000X16_A184PrvDsc = new String[] {""} ;
         T000X16_n184PrvDsc = new bool[] {false} ;
         T000X16_A187PrvEmail = new String[] {""} ;
         T000X16_n187PrvEmail = new bool[] {false} ;
         T000X16_A320OCompContac = new String[] {""} ;
         T000X16_n320OCompContac = new bool[] {false} ;
         T000X16_A313OctipDsc = new String[] {""} ;
         T000X16_n313OctipDsc = new bool[] {false} ;
         T000X16_A314OctipEst = new String[] {""} ;
         T000X16_n314OctipEst = new bool[] {false} ;
         T000X16_A319OCompFchEnt = new DateTime[] {DateTime.MinValue} ;
         T000X16_n319OCompFchEnt = new bool[] {false} ;
         T000X16_A322ClaOCDsc = new String[] {""} ;
         T000X16_n322ClaOCDsc = new bool[] {false} ;
         T000X16_A217BodDsc = new String[] {""} ;
         T000X16_n217BodDsc = new bool[] {false} ;
         T000X16_A218BodEst = new String[] {""} ;
         T000X16_n218BodEst = new bool[] {false} ;
         T000X16_A324OCompLote = new String[] {""} ;
         T000X16_n324OCompLote = new bool[] {false} ;
         T000X16_A325OCompObsv = new String[] {""} ;
         T000X16_n325OCompObsv = new bool[] {false} ;
         T000X16_A340OCompFchOC = new DateTime[] {DateTime.MinValue} ;
         T000X16_n340OCompFchOC = new bool[] {false} ;
         T000X16_A1EmpID = new short[1] ;
         T000X16_A2AgeID = new short[1] ;
         T000X16_A42BodCod = new short[1] ;
         T000X16_A311OcTipoCod = new String[] {""} ;
         T000X16_A321ClaOCCod = new String[] {""} ;
         T000X16_A37PrvRuc = new String[] {""} ;
         T000X16_A345OcompTotal = new decimal[1] ;
         T000X16_A347OCompTotCant = new decimal[1] ;
         T000X17_A44empdsc = new String[] {""} ;
         T000X17_n44empdsc = new bool[] {false} ;
         T000X18_A217BodDsc = new String[] {""} ;
         T000X18_n217BodDsc = new bool[] {false} ;
         T000X18_A218BodEst = new String[] {""} ;
         T000X18_n218BodEst = new bool[] {false} ;
         T000X19_A46AgeDsc = new String[] {""} ;
         T000X19_n46AgeDsc = new bool[] {false} ;
         T000X20_A322ClaOCDsc = new String[] {""} ;
         T000X20_n322ClaOCDsc = new bool[] {false} ;
         T000X21_A184PrvDsc = new String[] {""} ;
         T000X21_n184PrvDsc = new bool[] {false} ;
         T000X21_A187PrvEmail = new String[] {""} ;
         T000X21_n187PrvEmail = new bool[] {false} ;
         T000X22_A313OctipDsc = new String[] {""} ;
         T000X22_n313OctipDsc = new bool[] {false} ;
         T000X22_A314OctipEst = new String[] {""} ;
         T000X22_n314OctipEst = new bool[] {false} ;
         T000X24_A345OcompTotal = new decimal[1] ;
         T000X24_A347OCompTotCant = new decimal[1] ;
         T000X25_A1EmpID = new short[1] ;
         T000X25_A2AgeID = new short[1] ;
         T000X25_A317OCompNro = new short[1] ;
         T000X25_A311OcTipoCod = new String[] {""} ;
         T000X6_A317OCompNro = new short[1] ;
         T000X6_A318OCompFch = new DateTime[] {DateTime.MinValue} ;
         T000X6_n318OCompFch = new bool[] {false} ;
         T000X6_A326OCompUser = new String[] {""} ;
         T000X6_n326OCompUser = new bool[] {false} ;
         T000X6_A320OCompContac = new String[] {""} ;
         T000X6_n320OCompContac = new bool[] {false} ;
         T000X6_A319OCompFchEnt = new DateTime[] {DateTime.MinValue} ;
         T000X6_n319OCompFchEnt = new bool[] {false} ;
         T000X6_A324OCompLote = new String[] {""} ;
         T000X6_n324OCompLote = new bool[] {false} ;
         T000X6_A325OCompObsv = new String[] {""} ;
         T000X6_n325OCompObsv = new bool[] {false} ;
         T000X6_A340OCompFchOC = new DateTime[] {DateTime.MinValue} ;
         T000X6_n340OCompFchOC = new bool[] {false} ;
         T000X6_A1EmpID = new short[1] ;
         T000X6_A2AgeID = new short[1] ;
         T000X6_A42BodCod = new short[1] ;
         T000X6_A311OcTipoCod = new String[] {""} ;
         T000X6_A321ClaOCCod = new String[] {""} ;
         T000X6_A37PrvRuc = new String[] {""} ;
         T000X26_A1EmpID = new short[1] ;
         T000X26_A2AgeID = new short[1] ;
         T000X26_A317OCompNro = new short[1] ;
         T000X26_A311OcTipoCod = new String[] {""} ;
         T000X27_A1EmpID = new short[1] ;
         T000X27_A2AgeID = new short[1] ;
         T000X27_A317OCompNro = new short[1] ;
         T000X27_A311OcTipoCod = new String[] {""} ;
         T000X5_A317OCompNro = new short[1] ;
         T000X5_A318OCompFch = new DateTime[] {DateTime.MinValue} ;
         T000X5_n318OCompFch = new bool[] {false} ;
         T000X5_A326OCompUser = new String[] {""} ;
         T000X5_n326OCompUser = new bool[] {false} ;
         T000X5_A320OCompContac = new String[] {""} ;
         T000X5_n320OCompContac = new bool[] {false} ;
         T000X5_A319OCompFchEnt = new DateTime[] {DateTime.MinValue} ;
         T000X5_n319OCompFchEnt = new bool[] {false} ;
         T000X5_A324OCompLote = new String[] {""} ;
         T000X5_n324OCompLote = new bool[] {false} ;
         T000X5_A325OCompObsv = new String[] {""} ;
         T000X5_n325OCompObsv = new bool[] {false} ;
         T000X5_A340OCompFchOC = new DateTime[] {DateTime.MinValue} ;
         T000X5_n340OCompFchOC = new bool[] {false} ;
         T000X5_A1EmpID = new short[1] ;
         T000X5_A2AgeID = new short[1] ;
         T000X5_A42BodCod = new short[1] ;
         T000X5_A311OcTipoCod = new String[] {""} ;
         T000X5_A321ClaOCCod = new String[] {""} ;
         T000X5_A37PrvRuc = new String[] {""} ;
         T000X31_A44empdsc = new String[] {""} ;
         T000X31_n44empdsc = new bool[] {false} ;
         T000X32_A46AgeDsc = new String[] {""} ;
         T000X32_n46AgeDsc = new bool[] {false} ;
         T000X33_A184PrvDsc = new String[] {""} ;
         T000X33_n184PrvDsc = new bool[] {false} ;
         T000X33_A187PrvEmail = new String[] {""} ;
         T000X33_n187PrvEmail = new bool[] {false} ;
         T000X34_A313OctipDsc = new String[] {""} ;
         T000X34_n313OctipDsc = new bool[] {false} ;
         T000X34_A314OctipEst = new String[] {""} ;
         T000X34_n314OctipEst = new bool[] {false} ;
         T000X36_A345OcompTotal = new decimal[1] ;
         T000X36_A347OCompTotCant = new decimal[1] ;
         T000X37_A322ClaOCDsc = new String[] {""} ;
         T000X37_n322ClaOCDsc = new bool[] {false} ;
         T000X38_A217BodDsc = new String[] {""} ;
         T000X38_n217BodDsc = new bool[] {false} ;
         T000X38_A218BodEst = new String[] {""} ;
         T000X38_n218BodEst = new bool[] {false} ;
         T000X39_A1EmpID = new short[1] ;
         T000X39_A2AgeID = new short[1] ;
         T000X39_A317OCompNro = new short[1] ;
         T000X39_A311OcTipoCod = new String[] {""} ;
         Z309prdNombre = "";
         T000X40_A317OCompNro = new short[1] ;
         T000X40_A311OcTipoCod = new String[] {""} ;
         T000X40_A342ocDetID = new short[1] ;
         T000X40_A309prdNombre = new String[] {""} ;
         T000X40_n309prdNombre = new bool[] {false} ;
         T000X40_A343ocDetCant = new short[1] ;
         T000X40_n343ocDetCant = new bool[] {false} ;
         T000X40_A344ocDetValor = new decimal[1] ;
         T000X40_n344ocDetValor = new bool[] {false} ;
         T000X40_A1EmpID = new short[1] ;
         T000X40_A2AgeID = new short[1] ;
         T000X40_A286PrdCod = new short[1] ;
         T000X4_A309prdNombre = new String[] {""} ;
         T000X4_n309prdNombre = new bool[] {false} ;
         T000X41_A309prdNombre = new String[] {""} ;
         T000X41_n309prdNombre = new bool[] {false} ;
         T000X42_A1EmpID = new short[1] ;
         T000X42_A2AgeID = new short[1] ;
         T000X42_A317OCompNro = new short[1] ;
         T000X42_A311OcTipoCod = new String[] {""} ;
         T000X42_A342ocDetID = new short[1] ;
         T000X3_A317OCompNro = new short[1] ;
         T000X3_A311OcTipoCod = new String[] {""} ;
         T000X3_A342ocDetID = new short[1] ;
         T000X3_A343ocDetCant = new short[1] ;
         T000X3_n343ocDetCant = new bool[] {false} ;
         T000X3_A344ocDetValor = new decimal[1] ;
         T000X3_n344ocDetValor = new bool[] {false} ;
         T000X3_A1EmpID = new short[1] ;
         T000X3_A2AgeID = new short[1] ;
         T000X3_A286PrdCod = new short[1] ;
         T000X2_A317OCompNro = new short[1] ;
         T000X2_A311OcTipoCod = new String[] {""} ;
         T000X2_A342ocDetID = new short[1] ;
         T000X2_A343ocDetCant = new short[1] ;
         T000X2_n343ocDetCant = new bool[] {false} ;
         T000X2_A344ocDetValor = new decimal[1] ;
         T000X2_n344ocDetValor = new bool[] {false} ;
         T000X2_A1EmpID = new short[1] ;
         T000X2_A2AgeID = new short[1] ;
         T000X2_A286PrdCod = new short[1] ;
         T000X46_A309prdNombre = new String[] {""} ;
         T000X46_n309prdNombre = new bool[] {false} ;
         T000X47_A1EmpID = new short[1] ;
         T000X47_A2AgeID = new short[1] ;
         T000X47_A317OCompNro = new short[1] ;
         T000X47_A311OcTipoCod = new String[] {""} ;
         T000X47_A342ocDetID = new short[1] ;
         Gridordencompra_ocdetRow = new GXWebRow();
         subGridordencompra_ocdet_Linesclass = "";
         ROClassString = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         i318OCompFch = DateTime.MinValue;
         i326OCompUser = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ordencompra__default(),
            new Object[][] {
                new Object[] {
               T000X2_A317OCompNro, T000X2_A311OcTipoCod, T000X2_A342ocDetID, T000X2_A343ocDetCant, T000X2_n343ocDetCant, T000X2_A344ocDetValor, T000X2_n344ocDetValor, T000X2_A1EmpID, T000X2_A2AgeID, T000X2_A286PrdCod
               }
               , new Object[] {
               T000X3_A317OCompNro, T000X3_A311OcTipoCod, T000X3_A342ocDetID, T000X3_A343ocDetCant, T000X3_n343ocDetCant, T000X3_A344ocDetValor, T000X3_n344ocDetValor, T000X3_A1EmpID, T000X3_A2AgeID, T000X3_A286PrdCod
               }
               , new Object[] {
               T000X4_A309prdNombre, T000X4_n309prdNombre
               }
               , new Object[] {
               T000X5_A317OCompNro, T000X5_A318OCompFch, T000X5_n318OCompFch, T000X5_A326OCompUser, T000X5_n326OCompUser, T000X5_A320OCompContac, T000X5_n320OCompContac, T000X5_A319OCompFchEnt, T000X5_n319OCompFchEnt, T000X5_A324OCompLote,
               T000X5_n324OCompLote, T000X5_A325OCompObsv, T000X5_n325OCompObsv, T000X5_A340OCompFchOC, T000X5_n340OCompFchOC, T000X5_A1EmpID, T000X5_A2AgeID, T000X5_A42BodCod, T000X5_A311OcTipoCod, T000X5_A321ClaOCCod,
               T000X5_A37PrvRuc
               }
               , new Object[] {
               T000X6_A317OCompNro, T000X6_A318OCompFch, T000X6_n318OCompFch, T000X6_A326OCompUser, T000X6_n326OCompUser, T000X6_A320OCompContac, T000X6_n320OCompContac, T000X6_A319OCompFchEnt, T000X6_n319OCompFchEnt, T000X6_A324OCompLote,
               T000X6_n324OCompLote, T000X6_A325OCompObsv, T000X6_n325OCompObsv, T000X6_A340OCompFchOC, T000X6_n340OCompFchOC, T000X6_A1EmpID, T000X6_A2AgeID, T000X6_A42BodCod, T000X6_A311OcTipoCod, T000X6_A321ClaOCCod,
               T000X6_A37PrvRuc
               }
               , new Object[] {
               T000X7_A44empdsc, T000X7_n44empdsc
               }
               , new Object[] {
               T000X8_A46AgeDsc, T000X8_n46AgeDsc
               }
               , new Object[] {
               T000X9_A217BodDsc, T000X9_n217BodDsc, T000X9_A218BodEst, T000X9_n218BodEst
               }
               , new Object[] {
               T000X10_A313OctipDsc, T000X10_n313OctipDsc, T000X10_A314OctipEst, T000X10_n314OctipEst
               }
               , new Object[] {
               T000X11_A322ClaOCDsc, T000X11_n322ClaOCDsc
               }
               , new Object[] {
               T000X12_A184PrvDsc, T000X12_n184PrvDsc, T000X12_A187PrvEmail, T000X12_n187PrvEmail
               }
               , new Object[] {
               T000X14_A345OcompTotal, T000X14_A347OCompTotCant
               }
               , new Object[] {
               T000X16_A317OCompNro, T000X16_A318OCompFch, T000X16_n318OCompFch, T000X16_A326OCompUser, T000X16_n326OCompUser, T000X16_A44empdsc, T000X16_n44empdsc, T000X16_A46AgeDsc, T000X16_n46AgeDsc, T000X16_A184PrvDsc,
               T000X16_n184PrvDsc, T000X16_A187PrvEmail, T000X16_n187PrvEmail, T000X16_A320OCompContac, T000X16_n320OCompContac, T000X16_A313OctipDsc, T000X16_n313OctipDsc, T000X16_A314OctipEst, T000X16_n314OctipEst, T000X16_A319OCompFchEnt,
               T000X16_n319OCompFchEnt, T000X16_A322ClaOCDsc, T000X16_n322ClaOCDsc, T000X16_A217BodDsc, T000X16_n217BodDsc, T000X16_A218BodEst, T000X16_n218BodEst, T000X16_A324OCompLote, T000X16_n324OCompLote, T000X16_A325OCompObsv,
               T000X16_n325OCompObsv, T000X16_A340OCompFchOC, T000X16_n340OCompFchOC, T000X16_A1EmpID, T000X16_A2AgeID, T000X16_A42BodCod, T000X16_A311OcTipoCod, T000X16_A321ClaOCCod, T000X16_A37PrvRuc, T000X16_A345OcompTotal,
               T000X16_A347OCompTotCant
               }
               , new Object[] {
               T000X17_A44empdsc, T000X17_n44empdsc
               }
               , new Object[] {
               T000X18_A217BodDsc, T000X18_n217BodDsc, T000X18_A218BodEst, T000X18_n218BodEst
               }
               , new Object[] {
               T000X19_A46AgeDsc, T000X19_n46AgeDsc
               }
               , new Object[] {
               T000X20_A322ClaOCDsc, T000X20_n322ClaOCDsc
               }
               , new Object[] {
               T000X21_A184PrvDsc, T000X21_n184PrvDsc, T000X21_A187PrvEmail, T000X21_n187PrvEmail
               }
               , new Object[] {
               T000X22_A313OctipDsc, T000X22_n313OctipDsc, T000X22_A314OctipEst, T000X22_n314OctipEst
               }
               , new Object[] {
               T000X24_A345OcompTotal, T000X24_A347OCompTotCant
               }
               , new Object[] {
               T000X25_A1EmpID, T000X25_A2AgeID, T000X25_A317OCompNro, T000X25_A311OcTipoCod
               }
               , new Object[] {
               T000X26_A1EmpID, T000X26_A2AgeID, T000X26_A317OCompNro, T000X26_A311OcTipoCod
               }
               , new Object[] {
               T000X27_A1EmpID, T000X27_A2AgeID, T000X27_A317OCompNro, T000X27_A311OcTipoCod
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000X31_A44empdsc, T000X31_n44empdsc
               }
               , new Object[] {
               T000X32_A46AgeDsc, T000X32_n46AgeDsc
               }
               , new Object[] {
               T000X33_A184PrvDsc, T000X33_n184PrvDsc, T000X33_A187PrvEmail, T000X33_n187PrvEmail
               }
               , new Object[] {
               T000X34_A313OctipDsc, T000X34_n313OctipDsc, T000X34_A314OctipEst, T000X34_n314OctipEst
               }
               , new Object[] {
               T000X36_A345OcompTotal, T000X36_A347OCompTotCant
               }
               , new Object[] {
               T000X37_A322ClaOCDsc, T000X37_n322ClaOCDsc
               }
               , new Object[] {
               T000X38_A217BodDsc, T000X38_n217BodDsc, T000X38_A218BodEst, T000X38_n218BodEst
               }
               , new Object[] {
               T000X39_A1EmpID, T000X39_A2AgeID, T000X39_A317OCompNro, T000X39_A311OcTipoCod
               }
               , new Object[] {
               T000X40_A317OCompNro, T000X40_A311OcTipoCod, T000X40_A342ocDetID, T000X40_A309prdNombre, T000X40_n309prdNombre, T000X40_A343ocDetCant, T000X40_n343ocDetCant, T000X40_A344ocDetValor, T000X40_n344ocDetValor, T000X40_A1EmpID,
               T000X40_A2AgeID, T000X40_A286PrdCod
               }
               , new Object[] {
               T000X41_A309prdNombre, T000X41_n309prdNombre
               }
               , new Object[] {
               T000X42_A1EmpID, T000X42_A2AgeID, T000X42_A317OCompNro, T000X42_A311OcTipoCod, T000X42_A342ocDetID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000X46_A309prdNombre, T000X46_n309prdNombre
               }
               , new Object[] {
               T000X47_A1EmpID, T000X47_A2AgeID, T000X47_A317OCompNro, T000X47_A311OcTipoCod, T000X47_A342ocDetID
               }
            }
         );
         AV19Pgmname = "OrdenCompra";
      }

      private short nIsMod_80 ;
      private short wcpOAV7EmpID ;
      private short wcpOAV8AgeID ;
      private short wcpOAV9OCompNro ;
      private short Z1EmpID ;
      private short Z2AgeID ;
      private short Z317OCompNro ;
      private short Z42BodCod ;
      private short nRC_GXsfl_159 ;
      private short nGXsfl_159_idx=1 ;
      private short N42BodCod ;
      private short Z342ocDetID ;
      private short Z343ocDetCant ;
      private short Z286PrdCod ;
      private short O343ocDetCant ;
      private short nRcdDeleted_80 ;
      private short nRcdExists_80 ;
      private short GxWebError ;
      private short A1EmpID ;
      private short A42BodCod ;
      private short A2AgeID ;
      private short A317OCompNro ;
      private short A286PrdCod ;
      private short AV7EmpID ;
      private short AV8AgeID ;
      private short AV9OCompNro ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short subGridordencompra_ocdet_Backcolorstyle ;
      private short A342ocDetID ;
      private short A343ocDetCant ;
      private short subGridordencompra_ocdet_Allowselection ;
      private short subGridordencompra_ocdet_Allowhovering ;
      private short subGridordencompra_ocdet_Allowcollapsing ;
      private short subGridordencompra_ocdet_Collapsed ;
      private short nBlankRcdCount80 ;
      private short RcdFound80 ;
      private short nBlankRcdUsr80 ;
      private short AV16Insert_BodCod ;
      private short RcdFound75 ;
      private short T343ocDetCant ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short subGridordencompra_ocdet_Backstyle ;
      private short wbTemp ;
      private int edtEmpID_Visible ;
      private int edtAgeID_Visible ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtEmpID_Enabled ;
      private int imgprompt_1_Visible ;
      private int edtAgeID_Enabled ;
      private int imgprompt_2_Visible ;
      private int edtOCompUser_Visible ;
      private int edtOCompUser_Enabled ;
      private int edtempdsc_Enabled ;
      private int edtAgeDsc_Enabled ;
      private int edtClaOCCod_Enabled ;
      private int imgprompt_321_Visible ;
      private int edtClaOCDsc_Enabled ;
      private int edtOCompFch_Enabled ;
      private int edtPrvRuc_Enabled ;
      private int imgprompt_37_Visible ;
      private int edtPrvDsc_Enabled ;
      private int edtPrvEmail_Enabled ;
      private int edtOCompNro_Enabled ;
      private int edtOCompFchOC_Enabled ;
      private int edtOCompContac_Enabled ;
      private int edtOcTipoCod_Enabled ;
      private int imgprompt_311_Visible ;
      private int edtOctipDsc_Enabled ;
      private int edtOctipEst_Enabled ;
      private int edtBodCod_Enabled ;
      private int imgprompt_42_Visible ;
      private int edtBodDsc_Enabled ;
      private int edtBodEst_Enabled ;
      private int edtOCompFchEnt_Enabled ;
      private int edtOCompLote_Enabled ;
      private int edtOCompObsv_Enabled ;
      private int edtOCompTotCant_Enabled ;
      private int edtOcompTotal_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtocDetID_Enabled ;
      private int edtPrdCod_Enabled ;
      private int edtprdNombre_Enabled ;
      private int edtocDetCant_Enabled ;
      private int edtocDetValor_Enabled ;
      private int subGridordencompra_ocdet_Selectedindex ;
      private int subGridordencompra_ocdet_Selectioncolor ;
      private int subGridordencompra_ocdet_Hoveringcolor ;
      private int fRowAdded ;
      private int AV20GXV1 ;
      private int subGridordencompra_ocdet_Backcolor ;
      private int subGridordencompra_ocdet_Allbackcolor ;
      private int imgprompt_286_Visible ;
      private int defedtocDetID_Enabled ;
      private int idxLst ;
      private long GRIDORDENCOMPRA_OCDET_nFirstRecordOnPage ;
      private decimal O345OcompTotal ;
      private decimal O347OCompTotCant ;
      private decimal Z344ocDetValor ;
      private decimal O344ocDetValor ;
      private decimal A347OCompTotCant ;
      private decimal A345OcompTotal ;
      private decimal A344ocDetValor ;
      private decimal B345OcompTotal ;
      private decimal B347OCompTotCant ;
      private decimal s345OcompTotal ;
      private decimal s347OCompTotCant ;
      private decimal T344ocDetValor ;
      private decimal Z345OcompTotal ;
      private decimal Z347OCompTotCant ;
      private String sPrefix ;
      private String sGXsfl_159_idx="0001" ;
      private String wcpOGx_mode ;
      private String wcpOAV10OcTipoCod ;
      private String wcpOAV18usucod ;
      private String Z311OcTipoCod ;
      private String Z321ClaOCCod ;
      private String Z37PrvRuc ;
      private String N37PrvRuc ;
      private String N321ClaOCCod ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String A321ClaOCCod ;
      private String A37PrvRuc ;
      private String A311OcTipoCod ;
      private String Gx_mode ;
      private String AV10OcTipoCod ;
      private String AV18usucod ;
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
      private String edtAgeID_Internalname ;
      private String edtAgeID_Jsonclick ;
      private String imgprompt_2_Internalname ;
      private String imgprompt_2_Link ;
      private String edtOCompUser_Internalname ;
      private String edtOCompUser_Jsonclick ;
      private String divSection1_Internalname ;
      private String edtempdsc_Internalname ;
      private String edtempdsc_Jsonclick ;
      private String divSection2_Internalname ;
      private String edtAgeDsc_Internalname ;
      private String A46AgeDsc ;
      private String edtAgeDsc_Jsonclick ;
      private String divSection10_Internalname ;
      private String edtClaOCCod_Internalname ;
      private String edtClaOCCod_Jsonclick ;
      private String imgprompt_321_Internalname ;
      private String imgprompt_321_Link ;
      private String divSection11_Internalname ;
      private String edtClaOCDsc_Internalname ;
      private String A322ClaOCDsc ;
      private String edtClaOCDsc_Jsonclick ;
      private String divSection3_Internalname ;
      private String edtOCompFch_Internalname ;
      private String edtOCompFch_Jsonclick ;
      private String grpGroup1_Internalname ;
      private String divGroup1table_Internalname ;
      private String divSection4_Internalname ;
      private String edtPrvRuc_Internalname ;
      private String edtPrvRuc_Jsonclick ;
      private String imgprompt_37_Internalname ;
      private String imgprompt_37_Link ;
      private String divSection5_Internalname ;
      private String edtPrvDsc_Internalname ;
      private String edtPrvDsc_Jsonclick ;
      private String divSection6_Internalname ;
      private String edtPrvEmail_Internalname ;
      private String edtPrvEmail_Jsonclick ;
      private String edtOCompNro_Internalname ;
      private String edtOCompNro_Jsonclick ;
      private String edtOCompFchOC_Internalname ;
      private String edtOCompFchOC_Jsonclick ;
      private String edtOCompContac_Internalname ;
      private String edtOCompContac_Jsonclick ;
      private String divSection7_Internalname ;
      private String edtOcTipoCod_Internalname ;
      private String edtOcTipoCod_Jsonclick ;
      private String imgprompt_311_Internalname ;
      private String imgprompt_311_Link ;
      private String divSection8_Internalname ;
      private String edtOctipDsc_Internalname ;
      private String A313OctipDsc ;
      private String edtOctipDsc_Jsonclick ;
      private String divSection9_Internalname ;
      private String edtOctipEst_Internalname ;
      private String A314OctipEst ;
      private String edtOctipEst_Jsonclick ;
      private String divSection12_Internalname ;
      private String edtBodCod_Internalname ;
      private String edtBodCod_Jsonclick ;
      private String imgprompt_42_Internalname ;
      private String imgprompt_42_Link ;
      private String divSection13_Internalname ;
      private String edtBodDsc_Internalname ;
      private String A217BodDsc ;
      private String edtBodDsc_Jsonclick ;
      private String divSection14_Internalname ;
      private String edtBodEst_Internalname ;
      private String A218BodEst ;
      private String edtBodEst_Jsonclick ;
      private String edtOCompFchEnt_Internalname ;
      private String edtOCompFchEnt_Jsonclick ;
      private String edtOCompLote_Internalname ;
      private String edtOCompLote_Jsonclick ;
      private String edtOCompObsv_Internalname ;
      private String edtOCompObsv_Jsonclick ;
      private String divOcdettable_Internalname ;
      private String lblTitleocdet_Internalname ;
      private String lblTitleocdet_Jsonclick ;
      private String divSection15_Internalname ;
      private String edtOCompTotCant_Internalname ;
      private String edtOCompTotCant_Jsonclick ;
      private String divSection16_Internalname ;
      private String edtOcompTotal_Internalname ;
      private String edtOcompTotal_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridordencompra_ocdet_Header ;
      private String sMode80 ;
      private String edtocDetID_Internalname ;
      private String edtPrdCod_Internalname ;
      private String edtprdNombre_Internalname ;
      private String edtocDetCant_Internalname ;
      private String edtocDetValor_Internalname ;
      private String sStyleString ;
      private String AV14Insert_PrvRuc ;
      private String AV15Insert_ClaOCCod ;
      private String AV19Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode75 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String Z46AgeDsc ;
      private String Z313OctipDsc ;
      private String Z314OctipEst ;
      private String Z322ClaOCDsc ;
      private String Z217BodDsc ;
      private String Z218BodEst ;
      private String imgprompt_286_Internalname ;
      private String sGXsfl_159_fel_idx="0001" ;
      private String subGridordencompra_ocdet_Class ;
      private String subGridordencompra_ocdet_Linesclass ;
      private String imgprompt_286_Link ;
      private String ROClassString ;
      private String edtocDetID_Jsonclick ;
      private String edtPrdCod_Jsonclick ;
      private String edtprdNombre_Jsonclick ;
      private String edtocDetCant_Jsonclick ;
      private String edtocDetValor_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridordencompra_ocdet_Internalname ;
      private DateTime Z318OCompFch ;
      private DateTime Z319OCompFchEnt ;
      private DateTime Z340OCompFchOC ;
      private DateTime A318OCompFch ;
      private DateTime A340OCompFchOC ;
      private DateTime A319OCompFchEnt ;
      private DateTime i318OCompFch ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool bGXsfl_159_Refreshing=false ;
      private bool n326OCompUser ;
      private bool n44empdsc ;
      private bool n46AgeDsc ;
      private bool n322ClaOCDsc ;
      private bool n318OCompFch ;
      private bool n184PrvDsc ;
      private bool n187PrvEmail ;
      private bool n340OCompFchOC ;
      private bool n320OCompContac ;
      private bool n313OctipDsc ;
      private bool n314OctipEst ;
      private bool n217BodDsc ;
      private bool n218BodEst ;
      private bool n319OCompFchEnt ;
      private bool n324OCompLote ;
      private bool n325OCompObsv ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private bool n309prdNombre ;
      private bool n343ocDetCant ;
      private bool n344ocDetValor ;
      private String Z326OCompUser ;
      private String Z320OCompContac ;
      private String Z324OCompLote ;
      private String Z325OCompObsv ;
      private String A326OCompUser ;
      private String A44empdsc ;
      private String A184PrvDsc ;
      private String A187PrvEmail ;
      private String A320OCompContac ;
      private String A324OCompLote ;
      private String A325OCompObsv ;
      private String A309prdNombre ;
      private String Z44empdsc ;
      private String Z184PrvDsc ;
      private String Z187PrvEmail ;
      private String Z309prdNombre ;
      private String i326OCompUser ;
      private IGxSession AV13WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebGrid Gridordencompra_ocdetContainer ;
      private GXWebRow Gridordencompra_ocdetRow ;
      private GXWebColumn Gridordencompra_ocdetColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T000X7_A44empdsc ;
      private bool[] T000X7_n44empdsc ;
      private String[] T000X8_A46AgeDsc ;
      private bool[] T000X8_n46AgeDsc ;
      private String[] T000X10_A313OctipDsc ;
      private bool[] T000X10_n313OctipDsc ;
      private String[] T000X10_A314OctipEst ;
      private bool[] T000X10_n314OctipEst ;
      private decimal[] T000X14_A345OcompTotal ;
      private decimal[] T000X14_A347OCompTotCant ;
      private String[] T000X9_A217BodDsc ;
      private bool[] T000X9_n217BodDsc ;
      private String[] T000X9_A218BodEst ;
      private bool[] T000X9_n218BodEst ;
      private String[] T000X11_A322ClaOCDsc ;
      private bool[] T000X11_n322ClaOCDsc ;
      private String[] T000X12_A184PrvDsc ;
      private bool[] T000X12_n184PrvDsc ;
      private String[] T000X12_A187PrvEmail ;
      private bool[] T000X12_n187PrvEmail ;
      private short[] T000X16_A317OCompNro ;
      private DateTime[] T000X16_A318OCompFch ;
      private bool[] T000X16_n318OCompFch ;
      private String[] T000X16_A326OCompUser ;
      private bool[] T000X16_n326OCompUser ;
      private String[] T000X16_A44empdsc ;
      private bool[] T000X16_n44empdsc ;
      private String[] T000X16_A46AgeDsc ;
      private bool[] T000X16_n46AgeDsc ;
      private String[] T000X16_A184PrvDsc ;
      private bool[] T000X16_n184PrvDsc ;
      private String[] T000X16_A187PrvEmail ;
      private bool[] T000X16_n187PrvEmail ;
      private String[] T000X16_A320OCompContac ;
      private bool[] T000X16_n320OCompContac ;
      private String[] T000X16_A313OctipDsc ;
      private bool[] T000X16_n313OctipDsc ;
      private String[] T000X16_A314OctipEst ;
      private bool[] T000X16_n314OctipEst ;
      private DateTime[] T000X16_A319OCompFchEnt ;
      private bool[] T000X16_n319OCompFchEnt ;
      private String[] T000X16_A322ClaOCDsc ;
      private bool[] T000X16_n322ClaOCDsc ;
      private String[] T000X16_A217BodDsc ;
      private bool[] T000X16_n217BodDsc ;
      private String[] T000X16_A218BodEst ;
      private bool[] T000X16_n218BodEst ;
      private String[] T000X16_A324OCompLote ;
      private bool[] T000X16_n324OCompLote ;
      private String[] T000X16_A325OCompObsv ;
      private bool[] T000X16_n325OCompObsv ;
      private DateTime[] T000X16_A340OCompFchOC ;
      private bool[] T000X16_n340OCompFchOC ;
      private short[] T000X16_A1EmpID ;
      private short[] T000X16_A2AgeID ;
      private short[] T000X16_A42BodCod ;
      private String[] T000X16_A311OcTipoCod ;
      private String[] T000X16_A321ClaOCCod ;
      private String[] T000X16_A37PrvRuc ;
      private decimal[] T000X16_A345OcompTotal ;
      private decimal[] T000X16_A347OCompTotCant ;
      private String[] T000X17_A44empdsc ;
      private bool[] T000X17_n44empdsc ;
      private String[] T000X18_A217BodDsc ;
      private bool[] T000X18_n217BodDsc ;
      private String[] T000X18_A218BodEst ;
      private bool[] T000X18_n218BodEst ;
      private String[] T000X19_A46AgeDsc ;
      private bool[] T000X19_n46AgeDsc ;
      private String[] T000X20_A322ClaOCDsc ;
      private bool[] T000X20_n322ClaOCDsc ;
      private String[] T000X21_A184PrvDsc ;
      private bool[] T000X21_n184PrvDsc ;
      private String[] T000X21_A187PrvEmail ;
      private bool[] T000X21_n187PrvEmail ;
      private String[] T000X22_A313OctipDsc ;
      private bool[] T000X22_n313OctipDsc ;
      private String[] T000X22_A314OctipEst ;
      private bool[] T000X22_n314OctipEst ;
      private decimal[] T000X24_A345OcompTotal ;
      private decimal[] T000X24_A347OCompTotCant ;
      private short[] T000X25_A1EmpID ;
      private short[] T000X25_A2AgeID ;
      private short[] T000X25_A317OCompNro ;
      private String[] T000X25_A311OcTipoCod ;
      private short[] T000X6_A317OCompNro ;
      private DateTime[] T000X6_A318OCompFch ;
      private bool[] T000X6_n318OCompFch ;
      private String[] T000X6_A326OCompUser ;
      private bool[] T000X6_n326OCompUser ;
      private String[] T000X6_A320OCompContac ;
      private bool[] T000X6_n320OCompContac ;
      private DateTime[] T000X6_A319OCompFchEnt ;
      private bool[] T000X6_n319OCompFchEnt ;
      private String[] T000X6_A324OCompLote ;
      private bool[] T000X6_n324OCompLote ;
      private String[] T000X6_A325OCompObsv ;
      private bool[] T000X6_n325OCompObsv ;
      private DateTime[] T000X6_A340OCompFchOC ;
      private bool[] T000X6_n340OCompFchOC ;
      private short[] T000X6_A1EmpID ;
      private short[] T000X6_A2AgeID ;
      private short[] T000X6_A42BodCod ;
      private String[] T000X6_A311OcTipoCod ;
      private String[] T000X6_A321ClaOCCod ;
      private String[] T000X6_A37PrvRuc ;
      private short[] T000X26_A1EmpID ;
      private short[] T000X26_A2AgeID ;
      private short[] T000X26_A317OCompNro ;
      private String[] T000X26_A311OcTipoCod ;
      private short[] T000X27_A1EmpID ;
      private short[] T000X27_A2AgeID ;
      private short[] T000X27_A317OCompNro ;
      private String[] T000X27_A311OcTipoCod ;
      private short[] T000X5_A317OCompNro ;
      private DateTime[] T000X5_A318OCompFch ;
      private bool[] T000X5_n318OCompFch ;
      private String[] T000X5_A326OCompUser ;
      private bool[] T000X5_n326OCompUser ;
      private String[] T000X5_A320OCompContac ;
      private bool[] T000X5_n320OCompContac ;
      private DateTime[] T000X5_A319OCompFchEnt ;
      private bool[] T000X5_n319OCompFchEnt ;
      private String[] T000X5_A324OCompLote ;
      private bool[] T000X5_n324OCompLote ;
      private String[] T000X5_A325OCompObsv ;
      private bool[] T000X5_n325OCompObsv ;
      private DateTime[] T000X5_A340OCompFchOC ;
      private bool[] T000X5_n340OCompFchOC ;
      private short[] T000X5_A1EmpID ;
      private short[] T000X5_A2AgeID ;
      private short[] T000X5_A42BodCod ;
      private String[] T000X5_A311OcTipoCod ;
      private String[] T000X5_A321ClaOCCod ;
      private String[] T000X5_A37PrvRuc ;
      private String[] T000X31_A44empdsc ;
      private bool[] T000X31_n44empdsc ;
      private String[] T000X32_A46AgeDsc ;
      private bool[] T000X32_n46AgeDsc ;
      private String[] T000X33_A184PrvDsc ;
      private bool[] T000X33_n184PrvDsc ;
      private String[] T000X33_A187PrvEmail ;
      private bool[] T000X33_n187PrvEmail ;
      private String[] T000X34_A313OctipDsc ;
      private bool[] T000X34_n313OctipDsc ;
      private String[] T000X34_A314OctipEst ;
      private bool[] T000X34_n314OctipEst ;
      private decimal[] T000X36_A345OcompTotal ;
      private decimal[] T000X36_A347OCompTotCant ;
      private String[] T000X37_A322ClaOCDsc ;
      private bool[] T000X37_n322ClaOCDsc ;
      private String[] T000X38_A217BodDsc ;
      private bool[] T000X38_n217BodDsc ;
      private String[] T000X38_A218BodEst ;
      private bool[] T000X38_n218BodEst ;
      private short[] T000X39_A1EmpID ;
      private short[] T000X39_A2AgeID ;
      private short[] T000X39_A317OCompNro ;
      private String[] T000X39_A311OcTipoCod ;
      private short[] T000X40_A317OCompNro ;
      private String[] T000X40_A311OcTipoCod ;
      private short[] T000X40_A342ocDetID ;
      private String[] T000X40_A309prdNombre ;
      private bool[] T000X40_n309prdNombre ;
      private short[] T000X40_A343ocDetCant ;
      private bool[] T000X40_n343ocDetCant ;
      private decimal[] T000X40_A344ocDetValor ;
      private bool[] T000X40_n344ocDetValor ;
      private short[] T000X40_A1EmpID ;
      private short[] T000X40_A2AgeID ;
      private short[] T000X40_A286PrdCod ;
      private String[] T000X4_A309prdNombre ;
      private bool[] T000X4_n309prdNombre ;
      private String[] T000X41_A309prdNombre ;
      private bool[] T000X41_n309prdNombre ;
      private short[] T000X42_A1EmpID ;
      private short[] T000X42_A2AgeID ;
      private short[] T000X42_A317OCompNro ;
      private String[] T000X42_A311OcTipoCod ;
      private short[] T000X42_A342ocDetID ;
      private short[] T000X3_A317OCompNro ;
      private String[] T000X3_A311OcTipoCod ;
      private short[] T000X3_A342ocDetID ;
      private short[] T000X3_A343ocDetCant ;
      private bool[] T000X3_n343ocDetCant ;
      private decimal[] T000X3_A344ocDetValor ;
      private bool[] T000X3_n344ocDetValor ;
      private short[] T000X3_A1EmpID ;
      private short[] T000X3_A2AgeID ;
      private short[] T000X3_A286PrdCod ;
      private short[] T000X2_A317OCompNro ;
      private String[] T000X2_A311OcTipoCod ;
      private short[] T000X2_A342ocDetID ;
      private short[] T000X2_A343ocDetCant ;
      private bool[] T000X2_n343ocDetCant ;
      private decimal[] T000X2_A344ocDetValor ;
      private bool[] T000X2_n344ocDetValor ;
      private short[] T000X2_A1EmpID ;
      private short[] T000X2_A2AgeID ;
      private short[] T000X2_A286PrdCod ;
      private String[] T000X46_A309prdNombre ;
      private bool[] T000X46_n309prdNombre ;
      private short[] T000X47_A1EmpID ;
      private short[] T000X47_A2AgeID ;
      private short[] T000X47_A317OCompNro ;
      private String[] T000X47_A311OcTipoCod ;
      private short[] T000X47_A342ocDetID ;
      private SdtTransactionContext AV12TrnContext ;
      private SdtTransactionContext_Attribute AV17TrnContextAtt ;
   }

   public class ordencompra__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
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
         ,new ForEachCursor(def[33])
         ,new ForEachCursor(def[34])
         ,new ForEachCursor(def[35])
         ,new ForEachCursor(def[36])
         ,new UpdateCursor(def[37])
         ,new UpdateCursor(def[38])
         ,new UpdateCursor(def[39])
         ,new ForEachCursor(def[40])
         ,new ForEachCursor(def[41])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000X16 ;
          prmT000X16 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OCompNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0}
          } ;
          Object[] prmT000X7 ;
          prmT000X7 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000X9 ;
          prmT000X9 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000X8 ;
          prmT000X8 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000X11 ;
          prmT000X11 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClaOCCod",SqlDbType.Char,3,0}
          } ;
          Object[] prmT000X12 ;
          prmT000X12 = new Object[] {
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0}
          } ;
          Object[] prmT000X10 ;
          prmT000X10 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0}
          } ;
          Object[] prmT000X14 ;
          prmT000X14 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OCompNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0}
          } ;
          Object[] prmT000X17 ;
          prmT000X17 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000X18 ;
          prmT000X18 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000X19 ;
          prmT000X19 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000X20 ;
          prmT000X20 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClaOCCod",SqlDbType.Char,3,0}
          } ;
          Object[] prmT000X21 ;
          prmT000X21 = new Object[] {
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0}
          } ;
          Object[] prmT000X22 ;
          prmT000X22 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0}
          } ;
          Object[] prmT000X24 ;
          prmT000X24 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OCompNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0}
          } ;
          Object[] prmT000X25 ;
          prmT000X25 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OCompNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0}
          } ;
          Object[] prmT000X6 ;
          prmT000X6 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OCompNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0}
          } ;
          Object[] prmT000X26 ;
          prmT000X26 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OCompNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0}
          } ;
          Object[] prmT000X27 ;
          prmT000X27 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OCompNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0}
          } ;
          Object[] prmT000X5 ;
          prmT000X5 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OCompNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0}
          } ;
          Object[] prmT000X28 ;
          prmT000X28 = new Object[] {
          new Object[] {"@OCompNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OCompFch",SqlDbType.DateTime,8,0} ,
          new Object[] {"@OCompUser",SqlDbType.VarChar,15,0} ,
          new Object[] {"@OCompContac",SqlDbType.VarChar,60,0} ,
          new Object[] {"@OCompFchEnt",SqlDbType.DateTime,8,0} ,
          new Object[] {"@OCompLote",SqlDbType.VarChar,80,0} ,
          new Object[] {"@OCompObsv",SqlDbType.VarChar,120,0} ,
          new Object[] {"@OCompFchOC",SqlDbType.DateTime,8,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0} ,
          new Object[] {"@ClaOCCod",SqlDbType.Char,3,0} ,
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0}
          } ;
          Object[] prmT000X29 ;
          prmT000X29 = new Object[] {
          new Object[] {"@OCompFch",SqlDbType.DateTime,8,0} ,
          new Object[] {"@OCompUser",SqlDbType.VarChar,15,0} ,
          new Object[] {"@OCompContac",SqlDbType.VarChar,60,0} ,
          new Object[] {"@OCompFchEnt",SqlDbType.DateTime,8,0} ,
          new Object[] {"@OCompLote",SqlDbType.VarChar,80,0} ,
          new Object[] {"@OCompObsv",SqlDbType.VarChar,120,0} ,
          new Object[] {"@OCompFchOC",SqlDbType.DateTime,8,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClaOCCod",SqlDbType.Char,3,0} ,
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OCompNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0}
          } ;
          Object[] prmT000X30 ;
          prmT000X30 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OCompNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0}
          } ;
          Object[] prmT000X39 ;
          prmT000X39 = new Object[] {
          } ;
          Object[] prmT000X40 ;
          prmT000X40 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OCompNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0} ,
          new Object[] {"@ocDetID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000X4 ;
          prmT000X4 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000X41 ;
          prmT000X41 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000X42 ;
          prmT000X42 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OCompNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0} ,
          new Object[] {"@ocDetID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000X3 ;
          prmT000X3 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OCompNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0} ,
          new Object[] {"@ocDetID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000X2 ;
          prmT000X2 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OCompNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0} ,
          new Object[] {"@ocDetID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000X43 ;
          prmT000X43 = new Object[] {
          new Object[] {"@OCompNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0} ,
          new Object[] {"@ocDetID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ocDetCant",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ocDetValor",SqlDbType.Decimal,10,2} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000X44 ;
          prmT000X44 = new Object[] {
          new Object[] {"@ocDetCant",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ocDetValor",SqlDbType.Decimal,10,2} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OCompNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0} ,
          new Object[] {"@ocDetID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000X45 ;
          prmT000X45 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OCompNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0} ,
          new Object[] {"@ocDetID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000X47 ;
          prmT000X47 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OCompNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0}
          } ;
          Object[] prmT000X31 ;
          prmT000X31 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000X32 ;
          prmT000X32 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000X34 ;
          prmT000X34 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0}
          } ;
          Object[] prmT000X36 ;
          prmT000X36 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OCompNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OcTipoCod",SqlDbType.Char,3,0}
          } ;
          Object[] prmT000X37 ;
          prmT000X37 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClaOCCod",SqlDbType.Char,3,0}
          } ;
          Object[] prmT000X33 ;
          prmT000X33 = new Object[] {
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0}
          } ;
          Object[] prmT000X38 ;
          prmT000X38 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000X46 ;
          prmT000X46 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000X2", "SELECT [OCompNro], [OcTipoCod], [ocDetID], [ocDetCant], [ocDetValor], [EmpID], [AgeID], [PrdCod] FROM [OrdenCompraocDet] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [OCompNro] = @OCompNro AND [OcTipoCod] = @OcTipoCod AND [ocDetID] = @ocDetID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X2,1,0,true,false )
             ,new CursorDef("T000X3", "SELECT [OCompNro], [OcTipoCod], [ocDetID], [ocDetCant], [ocDetValor], [EmpID], [AgeID], [PrdCod] FROM [OrdenCompraocDet] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [OCompNro] = @OCompNro AND [OcTipoCod] = @OcTipoCod AND [ocDetID] = @ocDetID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X3,1,0,true,false )
             ,new CursorDef("T000X4", "SELECT [prdNombre] FROM [Productos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X4,1,0,true,false )
             ,new CursorDef("T000X5", "SELECT [OCompNro], [OCompFch], [OCompUser], [OCompContac], [OCompFchEnt], [OCompLote], [OCompObsv], [OCompFchOC], [EmpID], [AgeID], [BodCod], [OcTipoCod], [ClaOCCod], [PrvRuc] FROM [OrdenCompra] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [OCompNro] = @OCompNro AND [OcTipoCod] = @OcTipoCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X5,1,0,true,false )
             ,new CursorDef("T000X6", "SELECT [OCompNro], [OCompFch], [OCompUser], [OCompContac], [OCompFchEnt], [OCompLote], [OCompObsv], [OCompFchOC], [EmpID], [AgeID], [BodCod], [OcTipoCod], [ClaOCCod], [PrvRuc] FROM [OrdenCompra] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [OCompNro] = @OCompNro AND [OcTipoCod] = @OcTipoCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X6,1,0,true,false )
             ,new CursorDef("T000X7", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X7,1,0,true,false )
             ,new CursorDef("T000X8", "SELECT [AgeDsc] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X8,1,0,true,false )
             ,new CursorDef("T000X9", "SELECT [BodDsc], [BodEst] FROM [Bodegas] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X9,1,0,true,false )
             ,new CursorDef("T000X10", "SELECT [OctipDsc], [OctipEst] FROM [Octipos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [OcTipoCod] = @OcTipoCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X10,1,0,true,false )
             ,new CursorDef("T000X11", "SELECT [ClaOCDsc] FROM [ClaseOC] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [ClaOCCod] = @ClaOCCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X11,1,0,true,false )
             ,new CursorDef("T000X12", "SELECT [PrvDsc], [PrvEmail] FROM [Proveedor] WITH (NOLOCK) WHERE [PrvRuc] = @PrvRuc ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X12,1,0,true,false )
             ,new CursorDef("T000X14", "SELECT COALESCE( T1.[OcompTotal], 0) AS OcompTotal, COALESCE( T1.[OCompTotCant], 0) AS OCompTotCant FROM (SELECT SUM([ocDetValor]) AS OcompTotal, [EmpID], [AgeID], [OCompNro], [OcTipoCod], SUM([ocDetCant]) AS OCompTotCant FROM [OrdenCompraocDet] WITH (UPDLOCK) GROUP BY [EmpID], [AgeID], [OCompNro], [OcTipoCod] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[AgeID] = @AgeID AND T1.[OCompNro] = @OCompNro AND T1.[OcTipoCod] = @OcTipoCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X14,1,0,true,false )
             ,new CursorDef("T000X16", "SELECT TM1.[OCompNro], TM1.[OCompFch], TM1.[OCompUser], T2.[empdsc], T3.[AgeDsc], T4.[PrvDsc], T4.[PrvEmail], TM1.[OCompContac], T5.[OctipDsc], T5.[OctipEst], TM1.[OCompFchEnt], T7.[ClaOCDsc], T8.[BodDsc], T8.[BodEst], TM1.[OCompLote], TM1.[OCompObsv], TM1.[OCompFchOC], TM1.[EmpID], TM1.[AgeID], TM1.[BodCod], TM1.[OcTipoCod], TM1.[ClaOCCod], TM1.[PrvRuc], COALESCE( T6.[OcompTotal], 0) AS OcompTotal, COALESCE( T6.[OCompTotCant], 0) AS OCompTotCant FROM ((((((([OrdenCompra] TM1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = TM1.[EmpID]) INNER JOIN [Agencias] T3 WITH (NOLOCK) ON T3.[EmpID] = TM1.[EmpID] AND T3.[AgeID] = TM1.[AgeID]) INNER JOIN [Proveedor] T4 WITH (NOLOCK) ON T4.[PrvRuc] = TM1.[PrvRuc]) INNER JOIN [Octipos] T5 WITH (NOLOCK) ON T5.[EmpID] = TM1.[EmpID] AND T5.[AgeID] = TM1.[AgeID] AND T5.[OcTipoCod] = TM1.[OcTipoCod]) LEFT JOIN (SELECT SUM([ocDetValor]) AS OcompTotal, [EmpID], [AgeID], [OCompNro], [OcTipoCod], SUM([ocDetCant]) AS OCompTotCant FROM [OrdenCompraocDet] WITH (NOLOCK) GROUP BY [EmpID], [AgeID], [OCompNro], [OcTipoCod] ) T6 ON T6.[EmpID] = TM1.[EmpID] AND T6.[AgeID] = TM1.[AgeID] AND T6.[OCompNro] = TM1.[OCompNro] AND T6.[OcTipoCod] = TM1.[OcTipoCod]) INNER JOIN [ClaseOC] T7 WITH (NOLOCK) ON T7.[EmpID] = TM1.[EmpID] AND T7.[AgeID] = TM1.[AgeID] AND T7.[ClaOCCod] = TM1.[ClaOCCod]) INNER JOIN [Bodegas] T8 WITH (NOLOCK) ON T8.[EmpID] = TM1.[EmpID] AND T8.[BodCod] = TM1.[BodCod]) WHERE TM1.[EmpID] = @EmpID and TM1.[AgeID] = @AgeID and TM1.[OCompNro] = @OCompNro and TM1.[OcTipoCod] = @OcTipoCod ORDER BY TM1.[EmpID], TM1.[AgeID], TM1.[OCompNro], TM1.[OcTipoCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000X16,100,0,true,false )
             ,new CursorDef("T000X17", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X17,1,0,true,false )
             ,new CursorDef("T000X18", "SELECT [BodDsc], [BodEst] FROM [Bodegas] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X18,1,0,true,false )
             ,new CursorDef("T000X19", "SELECT [AgeDsc] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X19,1,0,true,false )
             ,new CursorDef("T000X20", "SELECT [ClaOCDsc] FROM [ClaseOC] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [ClaOCCod] = @ClaOCCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X20,1,0,true,false )
             ,new CursorDef("T000X21", "SELECT [PrvDsc], [PrvEmail] FROM [Proveedor] WITH (NOLOCK) WHERE [PrvRuc] = @PrvRuc ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X21,1,0,true,false )
             ,new CursorDef("T000X22", "SELECT [OctipDsc], [OctipEst] FROM [Octipos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [OcTipoCod] = @OcTipoCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X22,1,0,true,false )
             ,new CursorDef("T000X24", "SELECT COALESCE( T1.[OcompTotal], 0) AS OcompTotal, COALESCE( T1.[OCompTotCant], 0) AS OCompTotCant FROM (SELECT SUM([ocDetValor]) AS OcompTotal, [EmpID], [AgeID], [OCompNro], [OcTipoCod], SUM([ocDetCant]) AS OCompTotCant FROM [OrdenCompraocDet] WITH (UPDLOCK) GROUP BY [EmpID], [AgeID], [OCompNro], [OcTipoCod] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[AgeID] = @AgeID AND T1.[OCompNro] = @OCompNro AND T1.[OcTipoCod] = @OcTipoCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X24,1,0,true,false )
             ,new CursorDef("T000X25", "SELECT [EmpID], [AgeID], [OCompNro], [OcTipoCod] FROM [OrdenCompra] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [OCompNro] = @OCompNro AND [OcTipoCod] = @OcTipoCod  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000X25,1,0,true,false )
             ,new CursorDef("T000X26", "SELECT TOP 1 [EmpID], [AgeID], [OCompNro], [OcTipoCod] FROM [OrdenCompra] WITH (NOLOCK) WHERE ( [EmpID] > @EmpID or [EmpID] = @EmpID and [AgeID] > @AgeID or [AgeID] = @AgeID and [EmpID] = @EmpID and [OCompNro] > @OCompNro or [OCompNro] = @OCompNro and [AgeID] = @AgeID and [EmpID] = @EmpID and [OcTipoCod] > @OcTipoCod) ORDER BY [EmpID], [AgeID], [OCompNro], [OcTipoCod]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000X26,1,0,true,true )
             ,new CursorDef("T000X27", "SELECT TOP 1 [EmpID], [AgeID], [OCompNro], [OcTipoCod] FROM [OrdenCompra] WITH (NOLOCK) WHERE ( [EmpID] < @EmpID or [EmpID] = @EmpID and [AgeID] < @AgeID or [AgeID] = @AgeID and [EmpID] = @EmpID and [OCompNro] < @OCompNro or [OCompNro] = @OCompNro and [AgeID] = @AgeID and [EmpID] = @EmpID and [OcTipoCod] < @OcTipoCod) ORDER BY [EmpID] DESC, [AgeID] DESC, [OCompNro] DESC, [OcTipoCod] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000X27,1,0,true,true )
             ,new CursorDef("T000X28", "INSERT INTO [OrdenCompra]([OCompNro], [OCompFch], [OCompUser], [OCompContac], [OCompFchEnt], [OCompLote], [OCompObsv], [OCompFchOC], [EmpID], [AgeID], [BodCod], [OcTipoCod], [ClaOCCod], [PrvRuc]) VALUES(@OCompNro, @OCompFch, @OCompUser, @OCompContac, @OCompFchEnt, @OCompLote, @OCompObsv, @OCompFchOC, @EmpID, @AgeID, @BodCod, @OcTipoCod, @ClaOCCod, @PrvRuc)", GxErrorMask.GX_NOMASK,prmT000X28)
             ,new CursorDef("T000X29", "UPDATE [OrdenCompra] SET [OCompFch]=@OCompFch, [OCompUser]=@OCompUser, [OCompContac]=@OCompContac, [OCompFchEnt]=@OCompFchEnt, [OCompLote]=@OCompLote, [OCompObsv]=@OCompObsv, [OCompFchOC]=@OCompFchOC, [BodCod]=@BodCod, [ClaOCCod]=@ClaOCCod, [PrvRuc]=@PrvRuc  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [OCompNro] = @OCompNro AND [OcTipoCod] = @OcTipoCod", GxErrorMask.GX_NOMASK,prmT000X29)
             ,new CursorDef("T000X30", "DELETE FROM [OrdenCompra]  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [OCompNro] = @OCompNro AND [OcTipoCod] = @OcTipoCod", GxErrorMask.GX_NOMASK,prmT000X30)
             ,new CursorDef("T000X31", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X31,1,0,true,false )
             ,new CursorDef("T000X32", "SELECT [AgeDsc] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X32,1,0,true,false )
             ,new CursorDef("T000X33", "SELECT [PrvDsc], [PrvEmail] FROM [Proveedor] WITH (NOLOCK) WHERE [PrvRuc] = @PrvRuc ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X33,1,0,true,false )
             ,new CursorDef("T000X34", "SELECT [OctipDsc], [OctipEst] FROM [Octipos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [OcTipoCod] = @OcTipoCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X34,1,0,true,false )
             ,new CursorDef("T000X36", "SELECT COALESCE( T1.[OcompTotal], 0) AS OcompTotal, COALESCE( T1.[OCompTotCant], 0) AS OCompTotCant FROM (SELECT SUM([ocDetValor]) AS OcompTotal, [EmpID], [AgeID], [OCompNro], [OcTipoCod], SUM([ocDetCant]) AS OCompTotCant FROM [OrdenCompraocDet] WITH (UPDLOCK) GROUP BY [EmpID], [AgeID], [OCompNro], [OcTipoCod] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[AgeID] = @AgeID AND T1.[OCompNro] = @OCompNro AND T1.[OcTipoCod] = @OcTipoCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X36,1,0,true,false )
             ,new CursorDef("T000X37", "SELECT [ClaOCDsc] FROM [ClaseOC] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [ClaOCCod] = @ClaOCCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X37,1,0,true,false )
             ,new CursorDef("T000X38", "SELECT [BodDsc], [BodEst] FROM [Bodegas] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X38,1,0,true,false )
             ,new CursorDef("T000X39", "SELECT [EmpID], [AgeID], [OCompNro], [OcTipoCod] FROM [OrdenCompra] WITH (NOLOCK) ORDER BY [EmpID], [AgeID], [OCompNro], [OcTipoCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000X39,100,0,true,false )
             ,new CursorDef("T000X40", "SELECT T1.[OCompNro], T1.[OcTipoCod], T1.[ocDetID], T2.[prdNombre], T1.[ocDetCant], T1.[ocDetValor], T1.[EmpID], T1.[AgeID], T1.[PrdCod] FROM ([OrdenCompraocDet] T1 WITH (NOLOCK) INNER JOIN [Productos] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[AgeID] = T1.[AgeID] AND T2.[PrdCod] = T1.[PrdCod]) WHERE T1.[EmpID] = @EmpID and T1.[AgeID] = @AgeID and T1.[OCompNro] = @OCompNro and T1.[OcTipoCod] = @OcTipoCod and T1.[ocDetID] = @ocDetID ORDER BY T1.[EmpID], T1.[AgeID], T1.[OCompNro], T1.[OcTipoCod], T1.[ocDetID] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X40,11,0,true,false )
             ,new CursorDef("T000X41", "SELECT [prdNombre] FROM [Productos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X41,1,0,true,false )
             ,new CursorDef("T000X42", "SELECT [EmpID], [AgeID], [OCompNro], [OcTipoCod], [ocDetID] FROM [OrdenCompraocDet] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [OCompNro] = @OCompNro AND [OcTipoCod] = @OcTipoCod AND [ocDetID] = @ocDetID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X42,1,0,true,false )
             ,new CursorDef("T000X43", "INSERT INTO [OrdenCompraocDet]([OCompNro], [OcTipoCod], [ocDetID], [ocDetCant], [ocDetValor], [EmpID], [AgeID], [PrdCod]) VALUES(@OCompNro, @OcTipoCod, @ocDetID, @ocDetCant, @ocDetValor, @EmpID, @AgeID, @PrdCod)", GxErrorMask.GX_NOMASK,prmT000X43)
             ,new CursorDef("T000X44", "UPDATE [OrdenCompraocDet] SET [ocDetCant]=@ocDetCant, [ocDetValor]=@ocDetValor, [PrdCod]=@PrdCod  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [OCompNro] = @OCompNro AND [OcTipoCod] = @OcTipoCod AND [ocDetID] = @ocDetID", GxErrorMask.GX_NOMASK,prmT000X44)
             ,new CursorDef("T000X45", "DELETE FROM [OrdenCompraocDet]  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [OCompNro] = @OCompNro AND [OcTipoCod] = @OcTipoCod AND [ocDetID] = @ocDetID", GxErrorMask.GX_NOMASK,prmT000X45)
             ,new CursorDef("T000X46", "SELECT [prdNombre] FROM [Productos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X46,1,0,true,false )
             ,new CursorDef("T000X47", "SELECT [EmpID], [AgeID], [OCompNro], [OcTipoCod], [ocDetID] FROM [OrdenCompraocDet] WITH (NOLOCK) WHERE [EmpID] = @EmpID and [AgeID] = @AgeID and [OCompNro] = @OCompNro and [OcTipoCod] = @OcTipoCod ORDER BY [EmpID], [AgeID], [OCompNro], [OcTipoCod], [ocDetID] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X47,11,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 3) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((decimal[]) buf[5])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                ((short[]) buf[8])[0] = rslt.getShort(7) ;
                ((short[]) buf[9])[0] = rslt.getShort(8) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 3) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((decimal[]) buf[5])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                ((short[]) buf[8])[0] = rslt.getShort(7) ;
                ((short[]) buf[9])[0] = rslt.getShort(8) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[13])[0] = rslt.getGXDate(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((short[]) buf[15])[0] = rslt.getShort(9) ;
                ((short[]) buf[16])[0] = rslt.getShort(10) ;
                ((short[]) buf[17])[0] = rslt.getShort(11) ;
                ((String[]) buf[18])[0] = rslt.getString(12, 3) ;
                ((String[]) buf[19])[0] = rslt.getString(13, 3) ;
                ((String[]) buf[20])[0] = rslt.getString(14, 13) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[13])[0] = rslt.getGXDate(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((short[]) buf[15])[0] = rslt.getShort(9) ;
                ((short[]) buf[16])[0] = rslt.getShort(10) ;
                ((short[]) buf[17])[0] = rslt.getShort(11) ;
                ((String[]) buf[18])[0] = rslt.getString(12, 3) ;
                ((String[]) buf[19])[0] = rslt.getString(13, 3) ;
                ((String[]) buf[20])[0] = rslt.getString(14, 13) ;
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
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 1) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 1) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 11 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                return;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 50) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getString(9, 40) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((String[]) buf[17])[0] = rslt.getString(10, 1) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[19])[0] = rslt.getGXDate(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((String[]) buf[21])[0] = rslt.getString(12, 40) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                ((String[]) buf[23])[0] = rslt.getString(13, 40) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(13);
                ((String[]) buf[25])[0] = rslt.getString(14, 1) ;
                ((bool[]) buf[26])[0] = rslt.wasNull(14);
                ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[28])[0] = rslt.wasNull(15);
                ((String[]) buf[29])[0] = rslt.getVarchar(16) ;
                ((bool[]) buf[30])[0] = rslt.wasNull(16);
                ((DateTime[]) buf[31])[0] = rslt.getGXDate(17) ;
                ((bool[]) buf[32])[0] = rslt.wasNull(17);
                ((short[]) buf[33])[0] = rslt.getShort(18) ;
                ((short[]) buf[34])[0] = rslt.getShort(19) ;
                ((short[]) buf[35])[0] = rslt.getShort(20) ;
                ((String[]) buf[36])[0] = rslt.getString(21, 3) ;
                ((String[]) buf[37])[0] = rslt.getString(22, 3) ;
                ((String[]) buf[38])[0] = rslt.getString(23, 13) ;
                ((decimal[]) buf[39])[0] = rslt.getDecimal(24) ;
                ((decimal[]) buf[40])[0] = rslt.getDecimal(25) ;
                return;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 1) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 1) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 19 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                return;
             case 20 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 3) ;
                return;
             case 21 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 3) ;
                return;
             case 22 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 3) ;
                return;
             case 26 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 27 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 28 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 29 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 1) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
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
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                return;
             case 31 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 32 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 1) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 33 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 3) ;
                return;
             case 34 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 3) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((decimal[]) buf[7])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                ((short[]) buf[9])[0] = rslt.getShort(7) ;
                ((short[]) buf[10])[0] = rslt.getShort(8) ;
                ((short[]) buf[11])[0] = rslt.getShort(9) ;
                return;
             case 35 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 36 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 3) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 40 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 41 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 3) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
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
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
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
                stmt.SetParameter(4, (String)parms[3]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
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
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
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
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                return;
             case 17 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 18 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                return;
             case 19 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                return;
             case 20 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                return;
             case 21 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                return;
             case 22 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                return;
             case 23 :
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
                   stmt.setNull( 3 , SqlDbType.VarChar );
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
                   stmt.setNull( 5 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(5, (DateTime)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 6 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 7 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[12]);
                }
                if ( (bool)parms[13] )
                {
                   stmt.setNull( 8 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(8, (DateTime)parms[14]);
                }
                stmt.SetParameter(9, (short)parms[15]);
                stmt.SetParameter(10, (short)parms[16]);
                stmt.SetParameter(11, (short)parms[17]);
                stmt.SetParameter(12, (String)parms[18]);
                stmt.SetParameter(13, (String)parms[19]);
                stmt.SetParameter(14, (String)parms[20]);
                return;
             case 24 :
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
                   stmt.setNull( 4 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(4, (DateTime)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[9]);
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
                   stmt.setNull( 7 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(7, (DateTime)parms[13]);
                }
                stmt.SetParameter(8, (short)parms[14]);
                stmt.SetParameter(9, (String)parms[15]);
                stmt.SetParameter(10, (String)parms[16]);
                stmt.SetParameter(11, (short)parms[17]);
                stmt.SetParameter(12, (short)parms[18]);
                stmt.SetParameter(13, (short)parms[19]);
                stmt.SetParameter(14, (String)parms[20]);
                return;
             case 25 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                return;
             case 26 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 27 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 28 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 29 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
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
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                return;
             case 31 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                return;
             case 32 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 34 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 35 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 36 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 37 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 4 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(4, (short)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 5 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(5, (decimal)parms[6]);
                }
                stmt.SetParameter(6, (short)parms[7]);
                stmt.SetParameter(7, (short)parms[8]);
                stmt.SetParameter(8, (short)parms[9]);
                return;
             case 38 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
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
                stmt.SetParameter(7, (String)parms[8]);
                stmt.SetParameter(8, (short)parms[9]);
                return;
             case 39 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 40 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 41 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                return;
       }
    }

 }

}
