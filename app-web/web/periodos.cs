/*
               File: Periodos
        Description: Periodos
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/11/2023 0:42:54.11
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
   public class periodos : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"EMPID") == 0 )
         {
            AV18EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18EmpID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV18EmpID), "ZZZ9"), context));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLAEMPID0Z77( AV18EmpID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"PERUSER") == 0 )
         {
            AV10usucod = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10usucod", AV10usucod);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV10usucod, "")), context));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLAPERUSER0Z77( AV10usucod) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel4"+"_"+"PERMESACTUAL") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A327procesoCod = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327procesoCod", A327procesoCod);
            A328PerFchControl = context.localUtil.ParseDateParm( GetNextPar( ));
            n328PerFchControl = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328PerFchControl", context.localUtil.Format(A328PerFchControl, "99/99/9999"));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX4ASAPERMESACTUAL0Z77( A1EmpID, A327procesoCod, A328PerFchControl) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel5"+"_"+"PERANIOACTUAL") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A327procesoCod = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327procesoCod", A327procesoCod);
            A328PerFchControl = context.localUtil.ParseDateParm( GetNextPar( ));
            n328PerFchControl = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328PerFchControl", context.localUtil.Format(A328PerFchControl, "99/99/9999"));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX5ASAPERANIOACTUAL0Z77( A1EmpID, A327procesoCod, A328PerFchControl) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_19") == 0 )
         {
            A333PerUser = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A333PerUser", A333PerUser);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_19( A333PerUser) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridperiodos_per") == 0 )
         {
            nRC_GXsfl_75 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_75_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_75_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridperiodos_per_newrow( ) ;
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
               AV19procesoCod = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19procesoCod", AV19procesoCod);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vPROCESOCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV19procesoCod, "")), context));
               AV18EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18EmpID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV18EmpID), "ZZZ9"), context));
               AV9ageID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ageID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9ageID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9ageID), "ZZZ9"), context));
               AV10usucod = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10usucod", AV10usucod);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV10usucod, "")), context));
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
            Form.Meta.addItem("description", "Periodos", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = dynEmpID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public periodos( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public periodos( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           String aP1_procesoCod ,
                           short aP2_EmpID ,
                           short aP3_ageID ,
                           String aP4_usucod )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV19procesoCod = aP1_procesoCod;
         this.AV18EmpID = aP2_EmpID;
         this.AV9ageID = aP3_ageID;
         this.AV10usucod = aP4_usucod;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynEmpID = new GXCombobox();
         dynPerUser = new GXCombobox();
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
         if ( dynEmpID.ItemCount > 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( dynEmpID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A1EmpID), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            dynEmpID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A1EmpID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynEmpID_Internalname, "Values", dynEmpID.ToJavascriptSource(), true);
         }
         if ( dynPerUser.ItemCount > 0 )
         {
            A333PerUser = dynPerUser.getValidValue(A333PerUser);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A333PerUser", A333PerUser);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynPerUser.CurrentValue = StringUtil.RTrim( A333PerUser);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynPerUser_Internalname, "Values", dynPerUser.ToJavascriptSource(), true);
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Periodos", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Periodos.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Periodos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Periodos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Periodos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Periodos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0250.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"PROCESOCOD"+"'), id:'"+"PROCESOCOD"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_Periodos.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynEmpID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynEmpID_Internalname, "Empresa", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynEmpID, dynEmpID_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)), 1, dynEmpID_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dynEmpID.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "", true, "HLP_Periodos.htm");
            dynEmpID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A1EmpID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynEmpID_Internalname, "Values", (String)(dynEmpID.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable2_Internalname, 1, 0, "px", 0, "px", "Flex", "left", "top", " "+"data-gx-flex"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "", "left", "top", "", "flex-grow::1;", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPerAnioActual_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPerAnioActual_Internalname, "Año Actual", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtPerAnioActual_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A331PerAnioActual), 4, 0, ",", "")), ((edtPerAnioActual_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A331PerAnioActual), "ZZZ9")) : context.localUtil.Format( (decimal)(A331PerAnioActual), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPerAnioActual_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPerAnioActual_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Periodos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "", "left", "top", "", "flex-grow::1;", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPerMesActual_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPerMesActual_Internalname, "Mes Actual", "col-sm-3 AttributePaddingLeftLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtPerMesActual_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A332PerMesActual), 2, 0, ",", "")), ((edtPerMesActual_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A332PerMesActual), "Z9")) : context.localUtil.Format( (decimal)(A332PerMesActual), "Z9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPerMesActual_Jsonclick, 0, "AttributePaddingLeft", "", "", "", "", 1, edtPerMesActual_Enabled, 0, "number", "1", 2, "chr", 1, "row", 2, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Periodos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, divTable1_Internalname, 1, 0, "px", 0, "px", "Flex", "left", "top", " "+"data-gx-flex"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "", "left", "top", "", "flex-grow::1;", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtprocesoCod_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtprocesoCod_Internalname, "Proceso", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtprocesoCod_Internalname, A327procesoCod, StringUtil.RTrim( context.localUtil.Format( A327procesoCod, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtprocesoCod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtprocesoCod_Enabled, 1, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Periodos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "", "left", "top", "", "flex-grow::1;", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPerFchControl_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPerFchControl_Internalname, "Fecha Control", "col-sm-3 AttributePaddingLeftLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtPerFchControl_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtPerFchControl_Internalname, context.localUtil.Format(A328PerFchControl, "99/99/9999"), context.localUtil.Format( A328PerFchControl, "99/99/9999"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPerFchControl_Jsonclick, 0, "AttributePaddingLeft", "", "", "", "", 1, edtPerFchControl_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Periodos.htm");
            GxWebStd.gx_bitmap( context, edtPerFchControl_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtPerFchControl_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Periodos.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPerDiasPlazo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPerDiasPlazo_Internalname, "Plazo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPerDiasPlazo_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A329PerDiasPlazo), 2, 0, ",", "")), ((edtPerDiasPlazo_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A329PerDiasPlazo), "Z9")) : context.localUtil.Format( (decimal)(A329PerDiasPlazo), "Z9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,61);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPerDiasPlazo_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPerDiasPlazo_Enabled, 0, "number", "1", 2, "chr", 1, "row", 2, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Periodos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynPerUser_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynPerUser_Internalname, "User", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynPerUser, dynPerUser_Internalname, StringUtil.RTrim( A333PerUser), 1, dynPerUser_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, dynPerUser.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", "", true, "HLP_Periodos.htm");
            dynPerUser.CurrentValue = StringUtil.RTrim( A333PerUser);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynPerUser_Internalname, "Values", (String)(dynPerUser.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divPertable_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitleper_Internalname, "Periodos", "", "", lblTitleper_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Periodos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Gridperiodos_per( ) ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Periodos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 84,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Periodos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Periodos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm0Z77( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void gxdraw_Gridperiodos_per( )
      {
         /*  Grid Control  */
         Gridperiodos_perContainer.AddObjectProperty("GridName", "Gridperiodos_per");
         Gridperiodos_perContainer.AddObjectProperty("Header", subGridperiodos_per_Header);
         Gridperiodos_perContainer.AddObjectProperty("Class", "Grid");
         Gridperiodos_perContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridperiodos_perContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridperiodos_perContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridperiodos_per_Backcolorstyle), 1, 0, ".", "")));
         Gridperiodos_perContainer.AddObjectProperty("CmpContext", "");
         Gridperiodos_perContainer.AddObjectProperty("InMasterPage", "false");
         Gridperiodos_perColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridperiodos_perColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A335PerAnio), 4, 0, ".", "")));
         Gridperiodos_perColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPerAnio_Enabled), 5, 0, ".", "")));
         Gridperiodos_perContainer.AddColumnProperties(Gridperiodos_perColumn);
         Gridperiodos_perColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridperiodos_perColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A336PerUltMes), 2, 0, ".", "")));
         Gridperiodos_perColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPerUltMes_Enabled), 5, 0, ".", "")));
         Gridperiodos_perContainer.AddColumnProperties(Gridperiodos_perColumn);
         Gridperiodos_perContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridperiodos_per_Selectedindex), 4, 0, ".", "")));
         Gridperiodos_perContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridperiodos_per_Allowselection), 1, 0, ".", "")));
         Gridperiodos_perContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridperiodos_per_Selectioncolor), 9, 0, ".", "")));
         Gridperiodos_perContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridperiodos_per_Allowhovering), 1, 0, ".", "")));
         Gridperiodos_perContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridperiodos_per_Hoveringcolor), 9, 0, ".", "")));
         Gridperiodos_perContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridperiodos_per_Allowcollapsing), 1, 0, ".", "")));
         Gridperiodos_perContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridperiodos_per_Collapsed), 1, 0, ".", "")));
         nGXsfl_75_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount78 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_78 = 1;
               ScanStart0Z78( ) ;
               while ( RcdFound78 != 0 )
               {
                  init_level_properties78( ) ;
                  getByPrimaryKey0Z78( ) ;
                  AddRow0Z78( ) ;
                  ScanNext0Z78( ) ;
               }
               ScanEnd0Z78( ) ;
               nBlankRcdCount78 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal0Z78( ) ;
            standaloneModal0Z78( ) ;
            sMode78 = Gx_mode;
            while ( nGXsfl_75_idx < nRC_GXsfl_75 )
            {
               bGXsfl_75_Refreshing = true;
               ReadRow0Z78( ) ;
               edtPerAnio_Enabled = (int)(context.localUtil.CToN( cgiGet( "PERANIO_"+sGXsfl_75_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPerAnio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPerAnio_Enabled), 5, 0)), !bGXsfl_75_Refreshing);
               edtPerUltMes_Enabled = (int)(context.localUtil.CToN( cgiGet( "PERULTMES_"+sGXsfl_75_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPerUltMes_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPerUltMes_Enabled), 5, 0)), !bGXsfl_75_Refreshing);
               if ( ( nRcdExists_78 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal0Z78( ) ;
               }
               SendRow0Z78( ) ;
               bGXsfl_75_Refreshing = false;
            }
            Gx_mode = sMode78;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount78 = 5;
            nRcdExists_78 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart0Z78( ) ;
               while ( RcdFound78 != 0 )
               {
                  sGXsfl_75_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_75_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_7578( ) ;
                  init_level_properties78( ) ;
                  standaloneNotModal0Z78( ) ;
                  getByPrimaryKey0Z78( ) ;
                  standaloneModal0Z78( ) ;
                  AddRow0Z78( ) ;
                  ScanNext0Z78( ) ;
               }
               ScanEnd0Z78( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode78 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_75_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_75_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_7578( ) ;
            InitAll0Z78( ) ;
            init_level_properties78( ) ;
            standaloneNotModal0Z78( ) ;
            standaloneModal0Z78( ) ;
            nRcdExists_78 = 0;
            nIsMod_78 = 0;
            nRcdDeleted_78 = 0;
            nBlankRcdCount78 = (short)(nBlankRcdUsr78+nBlankRcdCount78);
            fRowAdded = 0;
            while ( nBlankRcdCount78 > 0 )
            {
               AddRow0Z78( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtPerAnio_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount78 = (short)(nBlankRcdCount78-1);
            }
            Gx_mode = sMode78;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridperiodos_perContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridperiodos_per", Gridperiodos_perContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridperiodos_perContainerData", Gridperiodos_perContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridperiodos_perContainerData"+"V", Gridperiodos_perContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridperiodos_perContainerData"+"V"+"\" value='"+Gridperiodos_perContainer.GridValuesHidden()+"'/>") ;
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
         E110Z2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               dynEmpID.Name = dynEmpID_Internalname;
               dynEmpID.CurrentValue = cgiGet( dynEmpID_Internalname);
               A1EmpID = (short)(NumberUtil.Val( cgiGet( dynEmpID_Internalname), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A331PerAnioActual = (short)(context.localUtil.CToN( cgiGet( edtPerAnioActual_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A331PerAnioActual", StringUtil.LTrim( StringUtil.Str( (decimal)(A331PerAnioActual), 4, 0)));
               A332PerMesActual = (short)(context.localUtil.CToN( cgiGet( edtPerMesActual_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A332PerMesActual", StringUtil.LTrim( StringUtil.Str( (decimal)(A332PerMesActual), 2, 0)));
               A327procesoCod = cgiGet( edtprocesoCod_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327procesoCod", A327procesoCod);
               if ( context.localUtil.VCDate( cgiGet( edtPerFchControl_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fch Control"}), 1, "PERFCHCONTROL");
                  AnyError = 1;
                  GX_FocusControl = edtPerFchControl_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A328PerFchControl = DateTime.MinValue;
                  n328PerFchControl = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328PerFchControl", context.localUtil.Format(A328PerFchControl, "99/99/9999"));
               }
               else
               {
                  A328PerFchControl = context.localUtil.CToD( cgiGet( edtPerFchControl_Internalname), 2);
                  n328PerFchControl = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328PerFchControl", context.localUtil.Format(A328PerFchControl, "99/99/9999"));
               }
               n328PerFchControl = ((DateTime.MinValue==A328PerFchControl) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtPerDiasPlazo_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtPerDiasPlazo_Internalname), ",", ".") > Convert.ToDecimal( 99 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PERDIASPLAZO");
                  AnyError = 1;
                  GX_FocusControl = edtPerDiasPlazo_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A329PerDiasPlazo = 0;
                  n329PerDiasPlazo = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A329PerDiasPlazo", StringUtil.LTrim( StringUtil.Str( (decimal)(A329PerDiasPlazo), 2, 0)));
               }
               else
               {
                  A329PerDiasPlazo = (short)(context.localUtil.CToN( cgiGet( edtPerDiasPlazo_Internalname), ",", "."));
                  n329PerDiasPlazo = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A329PerDiasPlazo", StringUtil.LTrim( StringUtil.Str( (decimal)(A329PerDiasPlazo), 2, 0)));
               }
               n329PerDiasPlazo = ((0==A329PerDiasPlazo) ? true : false);
               dynPerUser.Name = dynPerUser_Internalname;
               dynPerUser.CurrentValue = cgiGet( dynPerUser_Internalname);
               A333PerUser = cgiGet( dynPerUser_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A333PerUser", A333PerUser);
               /* Read saved values. */
               Z1EmpID = (short)(context.localUtil.CToN( cgiGet( "Z1EmpID"), ",", "."));
               Z327procesoCod = cgiGet( "Z327procesoCod");
               Z328PerFchControl = context.localUtil.CToD( cgiGet( "Z328PerFchControl"), 0);
               n328PerFchControl = ((DateTime.MinValue==A328PerFchControl) ? true : false);
               Z329PerDiasPlazo = (short)(context.localUtil.CToN( cgiGet( "Z329PerDiasPlazo"), ",", "."));
               n329PerDiasPlazo = ((0==A329PerDiasPlazo) ? true : false);
               Z333PerUser = cgiGet( "Z333PerUser");
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_75 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_75"), ",", "."));
               N333PerUser = cgiGet( "N333PerUser");
               AV18EmpID = (short)(context.localUtil.CToN( cgiGet( "vEMPID"), ",", "."));
               AV19procesoCod = cgiGet( "vPROCESOCOD");
               AV16Insert_PerUser = cgiGet( "vINSERT_PERUSER");
               AV10usucod = cgiGet( "vUSUCOD");
               A44empdsc = cgiGet( "EMPDSC");
               n44empdsc = false;
               A334PerUserName = cgiGet( "PERUSERNAME");
               n334PerUserName = false;
               AV20Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Periodos";
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV16Insert_PerUser, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A1EmpID != Z1EmpID ) || ( StringUtil.StrCmp(A327procesoCod, Z327procesoCod) != 0 ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("periodos:[SecurityCheckFailed value for]"+"Insert_PerUser:"+StringUtil.RTrim( context.localUtil.Format( AV16Insert_PerUser, "")));
                  GXUtil.WriteLog("periodos:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A327procesoCod = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327procesoCod", A327procesoCod);
                  getEqualNoModal( ) ;
                  GXAEMPID_html0Z77( AV18EmpID) ;
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
                     sMode77 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     GXAEMPID_html0Z77( AV18EmpID) ;
                     Gx_mode = sMode77;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound77 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0Z0( ) ;
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
                        GX_FocusControl = dynEmpID_Internalname;
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
                        E110Z2 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: After Trn */
                        E120Z2 ();
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
            E120Z2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0Z77( ) ;
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
            DisableAttributes0Z77( ) ;
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

      protected void CONFIRM_0Z0( )
      {
         BeforeValidate0Z77( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0Z77( ) ;
            }
            else
            {
               CheckExtendedTable0Z77( ) ;
               CloseExtendedTableCursors0Z77( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode77 = Gx_mode;
            CONFIRM_0Z78( ) ;
            if ( AnyError == 0 )
            {
               /* Restore parent mode. */
               Gx_mode = sMode77;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
               IsConfirmed = 1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
            }
            /* Restore parent mode. */
            Gx_mode = sMode77;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
      }

      protected void CONFIRM_0Z78( )
      {
         nGXsfl_75_idx = 0;
         while ( nGXsfl_75_idx < nRC_GXsfl_75 )
         {
            ReadRow0Z78( ) ;
            if ( ( nRcdExists_78 != 0 ) || ( nIsMod_78 != 0 ) )
            {
               GetKey0Z78( ) ;
               if ( ( nRcdExists_78 == 0 ) && ( nRcdDeleted_78 == 0 ) )
               {
                  if ( RcdFound78 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate0Z78( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0Z78( ) ;
                        CloseExtendedTableCursors0Z78( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "PERANIO_" + sGXsfl_75_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtPerAnio_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound78 != 0 )
                  {
                     if ( nRcdDeleted_78 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey0Z78( ) ;
                        Load0Z78( ) ;
                        BeforeValidate0Z78( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0Z78( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_78 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate0Z78( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0Z78( ) ;
                              CloseExtendedTableCursors0Z78( ) ;
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
                     if ( nRcdDeleted_78 == 0 )
                     {
                        GXCCtl = "PERANIO_" + sGXsfl_75_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtPerAnio_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtPerAnio_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A335PerAnio), 4, 0, ",", ""))) ;
            ChangePostValue( edtPerUltMes_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A336PerUltMes), 2, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z335PerAnio_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z335PerAnio), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z336PerUltMes_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z336PerUltMes), 2, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_78_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_78), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_78_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_78), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_78_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_78), 4, 0, ",", ""))) ;
            if ( nIsMod_78 != 0 )
            {
               ChangePostValue( "PERANIO_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPerAnio_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PERULTMES_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPerUltMes_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption0Z0( )
      {
      }

      protected void E110Z2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV20Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV20Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV14TrnContext.FromXml(AV15WebSession.Get("TrnContext"), null, "TransactionContext", "KBCalpesa22");
         AV16Insert_PerUser = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Insert_PerUser", AV16Insert_PerUser);
         if ( ( StringUtil.StrCmp(AV14TrnContext.gxTpr_Transactionname, AV20Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV21GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21GXV1), 8, 0)));
            while ( AV21GXV1 <= AV14TrnContext.gxTpr_Attributes.Count )
            {
               AV17TrnContextAtt = ((SdtTransactionContext_Attribute)AV14TrnContext.gxTpr_Attributes.Item(AV21GXV1));
               if ( StringUtil.StrCmp(AV17TrnContextAtt.gxTpr_Attributename, "PerUser") == 0 )
               {
                  AV16Insert_PerUser = AV17TrnContextAtt.gxTpr_Attributevalue;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Insert_PerUser", AV16Insert_PerUser);
               }
               AV21GXV1 = (int)(AV21GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21GXV1), 8, 0)));
            }
         }
      }

      protected void E120Z2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV14TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwperiodos.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0Z77( short GX_JID )
      {
         if ( ( GX_JID == 17 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z328PerFchControl = T000Z5_A328PerFchControl[0];
               Z329PerDiasPlazo = T000Z5_A329PerDiasPlazo[0];
               Z333PerUser = T000Z5_A333PerUser[0];
            }
            else
            {
               Z328PerFchControl = A328PerFchControl;
               Z329PerDiasPlazo = A329PerDiasPlazo;
               Z333PerUser = A333PerUser;
            }
         }
         if ( GX_JID == -17 )
         {
            Z327procesoCod = A327procesoCod;
            Z328PerFchControl = A328PerFchControl;
            Z329PerDiasPlazo = A329PerDiasPlazo;
            Z1EmpID = A1EmpID;
            Z333PerUser = A333PerUser;
            Z44empdsc = A44empdsc;
            Z334PerUserName = A334PerUserName;
         }
      }

      protected void standaloneNotModal( )
      {
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV19procesoCod)) )
         {
            A327procesoCod = AV19procesoCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327procesoCod", A327procesoCod);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV19procesoCod)) )
         {
            edtprocesoCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtprocesoCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtprocesoCod_Enabled), 5, 0)), true);
         }
         else
         {
            edtprocesoCod_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtprocesoCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtprocesoCod_Enabled), 5, 0)), true);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV19procesoCod)) )
         {
            edtprocesoCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtprocesoCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtprocesoCod_Enabled), 5, 0)), true);
         }
         GXAEMPID_html0Z77( AV18EmpID) ;
         if ( ! (0==AV18EmpID) )
         {
            A1EmpID = AV18EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         }
         if ( ! (0==AV18EmpID) )
         {
            dynEmpID.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynEmpID.Enabled), 5, 0)), true);
         }
         else
         {
            dynEmpID.Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynEmpID.Enabled), 5, 0)), true);
         }
         if ( ! (0==AV18EmpID) )
         {
            dynEmpID.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynEmpID.Enabled), 5, 0)), true);
         }
         GXAPERUSER_html0Z77( AV10usucod) ;
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV16Insert_PerUser)) )
         {
            dynPerUser.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynPerUser_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynPerUser.Enabled), 5, 0)), true);
         }
         else
         {
            dynPerUser.Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynPerUser_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynPerUser.Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV16Insert_PerUser)) )
         {
            A333PerUser = AV16Insert_PerUser;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A333PerUser", A333PerUser);
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
            AV20Pgmname = "Periodos";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Pgmname", AV20Pgmname);
            /* Using cursor T000Z6 */
            pr_default.execute(4, new Object[] {A1EmpID});
            A44empdsc = T000Z6_A44empdsc[0];
            n44empdsc = T000Z6_n44empdsc[0];
            pr_default.close(4);
            /* Using cursor T000Z7 */
            pr_default.execute(5, new Object[] {A333PerUser});
            A334PerUserName = T000Z7_A334PerUserName[0];
            n334PerUserName = T000Z7_n334PerUserName[0];
            pr_default.close(5);
         }
      }

      protected void Load0Z77( )
      {
         /* Using cursor T000Z8 */
         pr_default.execute(6, new Object[] {A1EmpID, A327procesoCod});
         if ( (pr_default.getStatus(6) != 101) )
         {
            RcdFound77 = 1;
            A44empdsc = T000Z8_A44empdsc[0];
            n44empdsc = T000Z8_n44empdsc[0];
            A328PerFchControl = T000Z8_A328PerFchControl[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328PerFchControl", context.localUtil.Format(A328PerFchControl, "99/99/9999"));
            n328PerFchControl = T000Z8_n328PerFchControl[0];
            A329PerDiasPlazo = T000Z8_A329PerDiasPlazo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A329PerDiasPlazo", StringUtil.LTrim( StringUtil.Str( (decimal)(A329PerDiasPlazo), 2, 0)));
            n329PerDiasPlazo = T000Z8_n329PerDiasPlazo[0];
            A334PerUserName = T000Z8_A334PerUserName[0];
            n334PerUserName = T000Z8_n334PerUserName[0];
            A333PerUser = T000Z8_A333PerUser[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A333PerUser", A333PerUser);
            ZM0Z77( -17) ;
         }
         pr_default.close(6);
         OnLoadActions0Z77( ) ;
      }

      protected void OnLoadActions0Z77( )
      {
         AV20Pgmname = "Periodos";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Pgmname", AV20Pgmname);
         GXt_int1 = A332PerMesActual;
         new obtperiodos(context ).execute(  A1EmpID,  A327procesoCod,  A328PerFchControl, out  GXt_int1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327procesoCod", A327procesoCod);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328PerFchControl", context.localUtil.Format(A328PerFchControl, "99/99/9999"));
         A332PerMesActual = GXt_int1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A332PerMesActual", StringUtil.LTrim( StringUtil.Str( (decimal)(A332PerMesActual), 2, 0)));
         GXt_int1 = A331PerAnioActual;
         new obtanio(context ).execute(  A1EmpID,  A327procesoCod,  A328PerFchControl, out  GXt_int1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327procesoCod", A327procesoCod);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328PerFchControl", context.localUtil.Format(A328PerFchControl, "99/99/9999"));
         A331PerAnioActual = GXt_int1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A331PerAnioActual", StringUtil.LTrim( StringUtil.Str( (decimal)(A331PerAnioActual), 4, 0)));
      }

      protected void CheckExtendedTable0Z77( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV20Pgmname = "Periodos";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Pgmname", AV20Pgmname);
         /* Using cursor T000Z6 */
         pr_default.execute(4, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = dynEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000Z6_A44empdsc[0];
         n44empdsc = T000Z6_n44empdsc[0];
         pr_default.close(4);
         GXt_int1 = A332PerMesActual;
         new obtperiodos(context ).execute(  A1EmpID,  A327procesoCod,  A328PerFchControl, out  GXt_int1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327procesoCod", A327procesoCod);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328PerFchControl", context.localUtil.Format(A328PerFchControl, "99/99/9999"));
         A332PerMesActual = GXt_int1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A332PerMesActual", StringUtil.LTrim( StringUtil.Str( (decimal)(A332PerMesActual), 2, 0)));
         GXt_int1 = A331PerAnioActual;
         new obtanio(context ).execute(  A1EmpID,  A327procesoCod,  A328PerFchControl, out  GXt_int1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327procesoCod", A327procesoCod);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328PerFchControl", context.localUtil.Format(A328PerFchControl, "99/99/9999"));
         A331PerAnioActual = GXt_int1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A331PerAnioActual", StringUtil.LTrim( StringUtil.Str( (decimal)(A331PerAnioActual), 4, 0)));
         if ( ! ( (DateTime.MinValue==A328PerFchControl) || ( A328PerFchControl >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fch Control fuera de rango", "OutOfRange", 1, "PERFCHCONTROL");
            AnyError = 1;
            GX_FocusControl = edtPerFchControl_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         /* Using cursor T000Z7 */
         pr_default.execute(5, new Object[] {A333PerUser});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No existe 'user Periodos'.", "ForeignKeyNotFound", 1, "PERUSER");
            AnyError = 1;
            GX_FocusControl = dynPerUser_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A334PerUserName = T000Z7_A334PerUserName[0];
         n334PerUserName = T000Z7_n334PerUserName[0];
         pr_default.close(5);
      }

      protected void CloseExtendedTableCursors0Z77( )
      {
         pr_default.close(4);
         pr_default.close(5);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_18( short A1EmpID )
      {
         /* Using cursor T000Z9 */
         pr_default.execute(7, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(7) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = dynEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000Z9_A44empdsc[0];
         n44empdsc = T000Z9_n44empdsc[0];
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

      protected void gxLoad_19( String A333PerUser )
      {
         /* Using cursor T000Z10 */
         pr_default.execute(8, new Object[] {A333PerUser});
         if ( (pr_default.getStatus(8) == 101) )
         {
            GX_msglist.addItem("No existe 'user Periodos'.", "ForeignKeyNotFound", 1, "PERUSER");
            AnyError = 1;
            GX_FocusControl = dynPerUser_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A334PerUserName = T000Z10_A334PerUserName[0];
         n334PerUserName = T000Z10_n334PerUserName[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A334PerUserName)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(8) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(8);
      }

      protected void GetKey0Z77( )
      {
         /* Using cursor T000Z11 */
         pr_default.execute(9, new Object[] {A1EmpID, A327procesoCod});
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound77 = 1;
         }
         else
         {
            RcdFound77 = 0;
         }
         pr_default.close(9);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000Z5 */
         pr_default.execute(3, new Object[] {A1EmpID, A327procesoCod});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM0Z77( 17) ;
            RcdFound77 = 1;
            A327procesoCod = T000Z5_A327procesoCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327procesoCod", A327procesoCod);
            A328PerFchControl = T000Z5_A328PerFchControl[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328PerFchControl", context.localUtil.Format(A328PerFchControl, "99/99/9999"));
            n328PerFchControl = T000Z5_n328PerFchControl[0];
            A329PerDiasPlazo = T000Z5_A329PerDiasPlazo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A329PerDiasPlazo", StringUtil.LTrim( StringUtil.Str( (decimal)(A329PerDiasPlazo), 2, 0)));
            n329PerDiasPlazo = T000Z5_n329PerDiasPlazo[0];
            A1EmpID = T000Z5_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A333PerUser = T000Z5_A333PerUser[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A333PerUser", A333PerUser);
            Z1EmpID = A1EmpID;
            Z327procesoCod = A327procesoCod;
            sMode77 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0Z77( ) ;
            if ( AnyError == 1 )
            {
               RcdFound77 = 0;
               InitializeNonKey0Z77( ) ;
            }
            Gx_mode = sMode77;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound77 = 0;
            InitializeNonKey0Z77( ) ;
            sMode77 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode77;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(3);
      }

      protected void getEqualNoModal( )
      {
         GetKey0Z77( ) ;
         if ( RcdFound77 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound77 = 0;
         /* Using cursor T000Z12 */
         pr_default.execute(10, new Object[] {A1EmpID, A327procesoCod});
         if ( (pr_default.getStatus(10) != 101) )
         {
            while ( (pr_default.getStatus(10) != 101) && ( ( T000Z12_A1EmpID[0] < A1EmpID ) || ( T000Z12_A1EmpID[0] == A1EmpID ) && ( StringUtil.StrCmp(T000Z12_A327procesoCod[0], A327procesoCod) < 0 ) ) )
            {
               pr_default.readNext(10);
            }
            if ( (pr_default.getStatus(10) != 101) && ( ( T000Z12_A1EmpID[0] > A1EmpID ) || ( T000Z12_A1EmpID[0] == A1EmpID ) && ( StringUtil.StrCmp(T000Z12_A327procesoCod[0], A327procesoCod) > 0 ) ) )
            {
               A1EmpID = T000Z12_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A327procesoCod = T000Z12_A327procesoCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327procesoCod", A327procesoCod);
               RcdFound77 = 1;
            }
         }
         pr_default.close(10);
      }

      protected void move_previous( )
      {
         RcdFound77 = 0;
         /* Using cursor T000Z13 */
         pr_default.execute(11, new Object[] {A1EmpID, A327procesoCod});
         if ( (pr_default.getStatus(11) != 101) )
         {
            while ( (pr_default.getStatus(11) != 101) && ( ( T000Z13_A1EmpID[0] > A1EmpID ) || ( T000Z13_A1EmpID[0] == A1EmpID ) && ( StringUtil.StrCmp(T000Z13_A327procesoCod[0], A327procesoCod) > 0 ) ) )
            {
               pr_default.readNext(11);
            }
            if ( (pr_default.getStatus(11) != 101) && ( ( T000Z13_A1EmpID[0] < A1EmpID ) || ( T000Z13_A1EmpID[0] == A1EmpID ) && ( StringUtil.StrCmp(T000Z13_A327procesoCod[0], A327procesoCod) < 0 ) ) )
            {
               A1EmpID = T000Z13_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A327procesoCod = T000Z13_A327procesoCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327procesoCod", A327procesoCod);
               RcdFound77 = 1;
            }
         }
         pr_default.close(11);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0Z77( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = dynEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0Z77( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound77 == 1 )
            {
               if ( ( A1EmpID != Z1EmpID ) || ( StringUtil.StrCmp(A327procesoCod, Z327procesoCod) != 0 ) )
               {
                  A1EmpID = Z1EmpID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
                  A327procesoCod = Z327procesoCod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327procesoCod", A327procesoCod);
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "EMPID");
                  AnyError = 1;
                  GX_FocusControl = dynEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = dynEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0Z77( ) ;
                  GX_FocusControl = dynEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A1EmpID != Z1EmpID ) || ( StringUtil.StrCmp(A327procesoCod, Z327procesoCod) != 0 ) )
               {
                  /* Insert record */
                  GX_FocusControl = dynEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0Z77( ) ;
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
                     GX_FocusControl = dynEmpID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = dynEmpID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0Z77( ) ;
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
         if ( ( A1EmpID != Z1EmpID ) || ( StringUtil.StrCmp(A327procesoCod, Z327procesoCod) != 0 ) )
         {
            A1EmpID = Z1EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A327procesoCod = Z327procesoCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327procesoCod", A327procesoCod);
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = dynEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = dynEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0Z77( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000Z4 */
            pr_default.execute(2, new Object[] {A1EmpID, A327procesoCod});
            if ( (pr_default.getStatus(2) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Periodos"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(2) == 101) || ( Z328PerFchControl != T000Z4_A328PerFchControl[0] ) || ( Z329PerDiasPlazo != T000Z4_A329PerDiasPlazo[0] ) || ( StringUtil.StrCmp(Z333PerUser, T000Z4_A333PerUser[0]) != 0 ) )
            {
               if ( Z328PerFchControl != T000Z4_A328PerFchControl[0] )
               {
                  GXUtil.WriteLog("periodos:[seudo value changed for attri]"+"PerFchControl");
                  GXUtil.WriteLogRaw("Old: ",Z328PerFchControl);
                  GXUtil.WriteLogRaw("Current: ",T000Z4_A328PerFchControl[0]);
               }
               if ( Z329PerDiasPlazo != T000Z4_A329PerDiasPlazo[0] )
               {
                  GXUtil.WriteLog("periodos:[seudo value changed for attri]"+"PerDiasPlazo");
                  GXUtil.WriteLogRaw("Old: ",Z329PerDiasPlazo);
                  GXUtil.WriteLogRaw("Current: ",T000Z4_A329PerDiasPlazo[0]);
               }
               if ( StringUtil.StrCmp(Z333PerUser, T000Z4_A333PerUser[0]) != 0 )
               {
                  GXUtil.WriteLog("periodos:[seudo value changed for attri]"+"PerUser");
                  GXUtil.WriteLogRaw("Old: ",Z333PerUser);
                  GXUtil.WriteLogRaw("Current: ",T000Z4_A333PerUser[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Periodos"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0Z77( )
      {
         BeforeValidate0Z77( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0Z77( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0Z77( 0) ;
            CheckOptimisticConcurrency0Z77( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0Z77( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0Z77( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000Z14 */
                     pr_default.execute(12, new Object[] {A327procesoCod, n328PerFchControl, A328PerFchControl, n329PerDiasPlazo, A329PerDiasPlazo, A1EmpID, A333PerUser});
                     pr_default.close(12);
                     dsDefault.SmartCacheProvider.SetUpdated("Periodos") ;
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
                           ProcessLevel0Z77( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption0Z0( ) ;
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
               Load0Z77( ) ;
            }
            EndLevel0Z77( ) ;
         }
         CloseExtendedTableCursors0Z77( ) ;
      }

      protected void Update0Z77( )
      {
         BeforeValidate0Z77( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0Z77( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0Z77( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0Z77( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0Z77( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000Z15 */
                     pr_default.execute(13, new Object[] {n328PerFchControl, A328PerFchControl, n329PerDiasPlazo, A329PerDiasPlazo, A333PerUser, A1EmpID, A327procesoCod});
                     pr_default.close(13);
                     dsDefault.SmartCacheProvider.SetUpdated("Periodos") ;
                     if ( (pr_default.getStatus(13) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Periodos"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0Z77( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0Z77( ) ;
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
            EndLevel0Z77( ) ;
         }
         CloseExtendedTableCursors0Z77( ) ;
      }

      protected void DeferredUpdate0Z77( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0Z77( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0Z77( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0Z77( ) ;
            AfterConfirm0Z77( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0Z77( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart0Z78( ) ;
                  while ( RcdFound78 != 0 )
                  {
                     getByPrimaryKey0Z78( ) ;
                     Delete0Z78( ) ;
                     ScanNext0Z78( ) ;
                  }
                  ScanEnd0Z78( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000Z16 */
                     pr_default.execute(14, new Object[] {A1EmpID, A327procesoCod});
                     pr_default.close(14);
                     dsDefault.SmartCacheProvider.SetUpdated("Periodos") ;
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
         sMode77 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0Z77( ) ;
         Gx_mode = sMode77;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0Z77( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV20Pgmname = "Periodos";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Pgmname", AV20Pgmname);
            /* Using cursor T000Z17 */
            pr_default.execute(15, new Object[] {A1EmpID});
            A44empdsc = T000Z17_A44empdsc[0];
            n44empdsc = T000Z17_n44empdsc[0];
            pr_default.close(15);
            GXt_int1 = A332PerMesActual;
            new obtperiodos(context ).execute(  A1EmpID,  A327procesoCod,  A328PerFchControl, out  GXt_int1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327procesoCod", A327procesoCod);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328PerFchControl", context.localUtil.Format(A328PerFchControl, "99/99/9999"));
            A332PerMesActual = GXt_int1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A332PerMesActual", StringUtil.LTrim( StringUtil.Str( (decimal)(A332PerMesActual), 2, 0)));
            GXt_int1 = A331PerAnioActual;
            new obtanio(context ).execute(  A1EmpID,  A327procesoCod,  A328PerFchControl, out  GXt_int1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327procesoCod", A327procesoCod);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328PerFchControl", context.localUtil.Format(A328PerFchControl, "99/99/9999"));
            A331PerAnioActual = GXt_int1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A331PerAnioActual", StringUtil.LTrim( StringUtil.Str( (decimal)(A331PerAnioActual), 4, 0)));
            /* Using cursor T000Z18 */
            pr_default.execute(16, new Object[] {A333PerUser});
            A334PerUserName = T000Z18_A334PerUserName[0];
            n334PerUserName = T000Z18_n334PerUserName[0];
            pr_default.close(16);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000Z19 */
            pr_default.execute(17, new Object[] {A1EmpID, A327procesoCod});
            if ( (pr_default.getStatus(17) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"det Fch"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(17);
         }
      }

      protected void ProcessNestedLevel0Z78( )
      {
         nGXsfl_75_idx = 0;
         while ( nGXsfl_75_idx < nRC_GXsfl_75 )
         {
            ReadRow0Z78( ) ;
            if ( ( nRcdExists_78 != 0 ) || ( nIsMod_78 != 0 ) )
            {
               standaloneNotModal0Z78( ) ;
               GetKey0Z78( ) ;
               if ( ( nRcdExists_78 == 0 ) && ( nRcdDeleted_78 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert0Z78( ) ;
               }
               else
               {
                  if ( RcdFound78 != 0 )
                  {
                     if ( ( nRcdDeleted_78 != 0 ) && ( nRcdExists_78 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete0Z78( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_78 != 0 ) && ( nRcdExists_78 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update0Z78( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_78 == 0 )
                     {
                        GXCCtl = "PERANIO_" + sGXsfl_75_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtPerAnio_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtPerAnio_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A335PerAnio), 4, 0, ",", ""))) ;
            ChangePostValue( edtPerUltMes_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A336PerUltMes), 2, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z335PerAnio_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z335PerAnio), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z336PerUltMes_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z336PerUltMes), 2, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_78_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_78), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_78_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_78), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_78_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_78), 4, 0, ",", ""))) ;
            if ( nIsMod_78 != 0 )
            {
               ChangePostValue( "PERANIO_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPerAnio_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PERULTMES_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPerUltMes_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0Z78( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_78 = 0;
         nIsMod_78 = 0;
         nRcdDeleted_78 = 0;
      }

      protected void ProcessLevel0Z77( )
      {
         /* Save parent mode. */
         sMode77 = Gx_mode;
         ProcessNestedLevel0Z78( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode77;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         /* ' Update level parameters */
      }

      protected void EndLevel0Z77( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(2);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0Z77( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(3);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(15);
            pr_default.close(16);
            context.CommitDataStores("periodos",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0Z0( ) ;
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
            pr_default.close(15);
            pr_default.close(16);
            context.RollbackDataStores("periodos",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0Z77( )
      {
         /* Scan By routine */
         /* Using cursor T000Z20 */
         pr_default.execute(18);
         RcdFound77 = 0;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound77 = 1;
            A1EmpID = T000Z20_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A327procesoCod = T000Z20_A327procesoCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327procesoCod", A327procesoCod);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0Z77( )
      {
         /* Scan next routine */
         pr_default.readNext(18);
         RcdFound77 = 0;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound77 = 1;
            A1EmpID = T000Z20_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A327procesoCod = T000Z20_A327procesoCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327procesoCod", A327procesoCod);
         }
      }

      protected void ScanEnd0Z77( )
      {
         pr_default.close(18);
      }

      protected void AfterConfirm0Z77( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0Z77( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0Z77( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0Z77( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0Z77( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0Z77( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0Z77( )
      {
         dynEmpID.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynEmpID.Enabled), 5, 0)), true);
         edtPerAnioActual_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPerAnioActual_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPerAnioActual_Enabled), 5, 0)), true);
         edtPerMesActual_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPerMesActual_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPerMesActual_Enabled), 5, 0)), true);
         edtprocesoCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtprocesoCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtprocesoCod_Enabled), 5, 0)), true);
         edtPerFchControl_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPerFchControl_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPerFchControl_Enabled), 5, 0)), true);
         edtPerDiasPlazo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPerDiasPlazo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPerDiasPlazo_Enabled), 5, 0)), true);
         dynPerUser.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynPerUser_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynPerUser.Enabled), 5, 0)), true);
      }

      protected void ZM0Z78( short GX_JID )
      {
         if ( ( GX_JID == 20 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z336PerUltMes = T000Z3_A336PerUltMes[0];
            }
            else
            {
               Z336PerUltMes = A336PerUltMes;
            }
         }
         if ( GX_JID == -20 )
         {
            Z1EmpID = A1EmpID;
            Z327procesoCod = A327procesoCod;
            Z335PerAnio = A335PerAnio;
            Z336PerUltMes = A336PerUltMes;
         }
      }

      protected void standaloneNotModal0Z78( )
      {
      }

      protected void standaloneModal0Z78( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtPerAnio_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPerAnio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPerAnio_Enabled), 5, 0)), !bGXsfl_75_Refreshing);
         }
         else
         {
            edtPerAnio_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPerAnio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPerAnio_Enabled), 5, 0)), !bGXsfl_75_Refreshing);
         }
      }

      protected void Load0Z78( )
      {
         /* Using cursor T000Z21 */
         pr_default.execute(19, new Object[] {A1EmpID, A327procesoCod, A335PerAnio});
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound78 = 1;
            A336PerUltMes = T000Z21_A336PerUltMes[0];
            n336PerUltMes = T000Z21_n336PerUltMes[0];
            ZM0Z78( -20) ;
         }
         pr_default.close(19);
         OnLoadActions0Z78( ) ;
      }

      protected void OnLoadActions0Z78( )
      {
      }

      protected void CheckExtendedTable0Z78( )
      {
         Gx_BScreen = 1;
         standaloneModal0Z78( ) ;
      }

      protected void CloseExtendedTableCursors0Z78( )
      {
      }

      protected void enableDisable0Z78( )
      {
      }

      protected void GetKey0Z78( )
      {
         /* Using cursor T000Z22 */
         pr_default.execute(20, new Object[] {A1EmpID, A327procesoCod, A335PerAnio});
         if ( (pr_default.getStatus(20) != 101) )
         {
            RcdFound78 = 1;
         }
         else
         {
            RcdFound78 = 0;
         }
         pr_default.close(20);
      }

      protected void getByPrimaryKey0Z78( )
      {
         /* Using cursor T000Z3 */
         pr_default.execute(1, new Object[] {A1EmpID, A327procesoCod, A335PerAnio});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0Z78( 20) ;
            RcdFound78 = 1;
            InitializeNonKey0Z78( ) ;
            A335PerAnio = T000Z3_A335PerAnio[0];
            A336PerUltMes = T000Z3_A336PerUltMes[0];
            n336PerUltMes = T000Z3_n336PerUltMes[0];
            Z1EmpID = A1EmpID;
            Z327procesoCod = A327procesoCod;
            Z335PerAnio = A335PerAnio;
            sMode78 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0Z78( ) ;
            Gx_mode = sMode78;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound78 = 0;
            InitializeNonKey0Z78( ) ;
            sMode78 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal0Z78( ) ;
            Gx_mode = sMode78;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes0Z78( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0Z78( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000Z2 */
            pr_default.execute(0, new Object[] {A1EmpID, A327procesoCod, A335PerAnio});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"PeriodosPer"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z336PerUltMes != T000Z2_A336PerUltMes[0] ) )
            {
               if ( Z336PerUltMes != T000Z2_A336PerUltMes[0] )
               {
                  GXUtil.WriteLog("periodos:[seudo value changed for attri]"+"PerUltMes");
                  GXUtil.WriteLogRaw("Old: ",Z336PerUltMes);
                  GXUtil.WriteLogRaw("Current: ",T000Z2_A336PerUltMes[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"PeriodosPer"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0Z78( )
      {
         BeforeValidate0Z78( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0Z78( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0Z78( 0) ;
            CheckOptimisticConcurrency0Z78( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0Z78( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0Z78( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000Z23 */
                     pr_default.execute(21, new Object[] {A1EmpID, A327procesoCod, A335PerAnio, n336PerUltMes, A336PerUltMes});
                     pr_default.close(21);
                     dsDefault.SmartCacheProvider.SetUpdated("PeriodosPer") ;
                     if ( (pr_default.getStatus(21) == 1) )
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
               Load0Z78( ) ;
            }
            EndLevel0Z78( ) ;
         }
         CloseExtendedTableCursors0Z78( ) ;
      }

      protected void Update0Z78( )
      {
         BeforeValidate0Z78( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0Z78( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0Z78( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0Z78( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0Z78( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000Z24 */
                     pr_default.execute(22, new Object[] {n336PerUltMes, A336PerUltMes, A1EmpID, A327procesoCod, A335PerAnio});
                     pr_default.close(22);
                     dsDefault.SmartCacheProvider.SetUpdated("PeriodosPer") ;
                     if ( (pr_default.getStatus(22) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"PeriodosPer"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0Z78( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey0Z78( ) ;
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
            EndLevel0Z78( ) ;
         }
         CloseExtendedTableCursors0Z78( ) ;
      }

      protected void DeferredUpdate0Z78( )
      {
      }

      protected void Delete0Z78( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate0Z78( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0Z78( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0Z78( ) ;
            AfterConfirm0Z78( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0Z78( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000Z25 */
                  pr_default.execute(23, new Object[] {A1EmpID, A327procesoCod, A335PerAnio});
                  pr_default.close(23);
                  dsDefault.SmartCacheProvider.SetUpdated("PeriodosPer") ;
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
         sMode78 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0Z78( ) ;
         Gx_mode = sMode78;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0Z78( )
      {
         standaloneModal0Z78( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000Z26 */
            pr_default.execute(24, new Object[] {A1EmpID, A327procesoCod, A335PerAnio});
            if ( (pr_default.getStatus(24) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"det Fch"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(24);
         }
      }

      protected void EndLevel0Z78( )
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

      public void ScanStart0Z78( )
      {
         /* Scan By routine */
         /* Using cursor T000Z27 */
         pr_default.execute(25, new Object[] {A1EmpID, A327procesoCod});
         RcdFound78 = 0;
         if ( (pr_default.getStatus(25) != 101) )
         {
            RcdFound78 = 1;
            A335PerAnio = T000Z27_A335PerAnio[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0Z78( )
      {
         /* Scan next routine */
         pr_default.readNext(25);
         RcdFound78 = 0;
         if ( (pr_default.getStatus(25) != 101) )
         {
            RcdFound78 = 1;
            A335PerAnio = T000Z27_A335PerAnio[0];
         }
      }

      protected void ScanEnd0Z78( )
      {
         pr_default.close(25);
      }

      protected void AfterConfirm0Z78( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0Z78( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0Z78( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0Z78( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0Z78( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0Z78( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0Z78( )
      {
         edtPerAnio_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPerAnio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPerAnio_Enabled), 5, 0)), !bGXsfl_75_Refreshing);
         edtPerUltMes_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPerUltMes_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPerUltMes_Enabled), 5, 0)), !bGXsfl_75_Refreshing);
      }

      protected void send_integrity_lvl_hashes0Z78( )
      {
      }

      protected void send_integrity_lvl_hashes0Z77( )
      {
      }

      protected void SubsflControlProps_7578( )
      {
         edtPerAnio_Internalname = "PERANIO_"+sGXsfl_75_idx;
         edtPerUltMes_Internalname = "PERULTMES_"+sGXsfl_75_idx;
      }

      protected void SubsflControlProps_fel_7578( )
      {
         edtPerAnio_Internalname = "PERANIO_"+sGXsfl_75_fel_idx;
         edtPerUltMes_Internalname = "PERULTMES_"+sGXsfl_75_fel_idx;
      }

      protected void AddRow0Z78( )
      {
         nGXsfl_75_idx = (short)(nGXsfl_75_idx+1);
         sGXsfl_75_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_75_idx), 4, 0)), 4, "0");
         SubsflControlProps_7578( ) ;
         SendRow0Z78( ) ;
      }

      protected void SendRow0Z78( )
      {
         Gridperiodos_perRow = GXWebRow.GetNew(context);
         if ( subGridperiodos_per_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridperiodos_per_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridperiodos_per_Class, "") != 0 )
            {
               subGridperiodos_per_Linesclass = subGridperiodos_per_Class+"Odd";
            }
         }
         else if ( subGridperiodos_per_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridperiodos_per_Backstyle = 0;
            subGridperiodos_per_Backcolor = subGridperiodos_per_Allbackcolor;
            if ( StringUtil.StrCmp(subGridperiodos_per_Class, "") != 0 )
            {
               subGridperiodos_per_Linesclass = subGridperiodos_per_Class+"Uniform";
            }
         }
         else if ( subGridperiodos_per_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridperiodos_per_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridperiodos_per_Class, "") != 0 )
            {
               subGridperiodos_per_Linesclass = subGridperiodos_per_Class+"Odd";
            }
            subGridperiodos_per_Backcolor = (int)(0x0);
         }
         else if ( subGridperiodos_per_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridperiodos_per_Backstyle = 1;
            if ( ((int)(((nGXsfl_75_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGridperiodos_per_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridperiodos_per_Class, "") != 0 )
               {
                  subGridperiodos_per_Linesclass = subGridperiodos_per_Class+"Odd";
               }
            }
            else
            {
               subGridperiodos_per_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridperiodos_per_Class, "") != 0 )
               {
                  subGridperiodos_per_Linesclass = subGridperiodos_per_Class+"Even";
               }
            }
         }
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_78_" + sGXsfl_75_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_75_idx + "',75)\"";
         ROClassString = "Attribute";
         Gridperiodos_perRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPerAnio_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A335PerAnio), 4, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A335PerAnio), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,76);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPerAnio_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtPerAnio_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)75,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_78_" + sGXsfl_75_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 77,'',false,'" + sGXsfl_75_idx + "',75)\"";
         ROClassString = "Attribute";
         Gridperiodos_perRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPerUltMes_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A336PerUltMes), 2, 0, ",", "")),((edtPerUltMes_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A336PerUltMes), "Z9")) : context.localUtil.Format( (decimal)(A336PerUltMes), "Z9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,77);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPerUltMes_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtPerUltMes_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)2,(short)0,(short)0,(short)75,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         context.httpAjaxContext.ajax_sending_grid_row(Gridperiodos_perRow);
         send_integrity_lvl_hashes0Z78( ) ;
         GXCCtl = "Z335PerAnio_" + sGXsfl_75_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z335PerAnio), 4, 0, ",", "")));
         GXCCtl = "Z336PerUltMes_" + sGXsfl_75_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z336PerUltMes), 2, 0, ",", "")));
         GXCCtl = "nRcdDeleted_78_" + sGXsfl_75_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_78), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_78_" + sGXsfl_75_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_78), 4, 0, ",", "")));
         GXCCtl = "nIsMod_78_" + sGXsfl_75_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_78), 4, 0, ",", "")));
         GXCCtl = "vMODE_" + sGXsfl_75_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_75_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV14TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV14TrnContext);
         }
         GXCCtl = "vPROCESOCOD_" + sGXsfl_75_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, AV19procesoCod);
         GXCCtl = "vEMPID_" + sGXsfl_75_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18EmpID), 4, 0, ",", "")));
         GXCCtl = "vAGEID_" + sGXsfl_75_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9ageID), 4, 0, ",", "")));
         GXCCtl = "vUSUCOD_" + sGXsfl_75_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( AV10usucod));
         GxWebStd.gx_hidden_field( context, "PERANIO_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPerAnio_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PERULTMES_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPerUltMes_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridperiodos_perContainer.AddRow(Gridperiodos_perRow);
      }

      protected void ReadRow0Z78( )
      {
         nGXsfl_75_idx = (short)(nGXsfl_75_idx+1);
         sGXsfl_75_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_75_idx), 4, 0)), 4, "0");
         SubsflControlProps_7578( ) ;
         edtPerAnio_Enabled = (int)(context.localUtil.CToN( cgiGet( "PERANIO_"+sGXsfl_75_idx+"Enabled"), ",", "."));
         edtPerUltMes_Enabled = (int)(context.localUtil.CToN( cgiGet( "PERULTMES_"+sGXsfl_75_idx+"Enabled"), ",", "."));
         if ( ( ( context.localUtil.CToN( cgiGet( edtPerAnio_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtPerAnio_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "PERANIO_" + sGXsfl_75_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtPerAnio_Internalname;
            wbErr = true;
            A335PerAnio = 0;
         }
         else
         {
            A335PerAnio = (short)(context.localUtil.CToN( cgiGet( edtPerAnio_Internalname), ",", "."));
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtPerUltMes_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtPerUltMes_Internalname), ",", ".") > Convert.ToDecimal( 99 )) ) )
         {
            GXCCtl = "PERULTMES_" + sGXsfl_75_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtPerUltMes_Internalname;
            wbErr = true;
            A336PerUltMes = 0;
            n336PerUltMes = false;
         }
         else
         {
            A336PerUltMes = (short)(context.localUtil.CToN( cgiGet( edtPerUltMes_Internalname), ",", "."));
            n336PerUltMes = false;
         }
         n336PerUltMes = ((0==A336PerUltMes) ? true : false);
         GXCCtl = "Z335PerAnio_" + sGXsfl_75_idx;
         Z335PerAnio = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z336PerUltMes_" + sGXsfl_75_idx;
         Z336PerUltMes = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         n336PerUltMes = ((0==A336PerUltMes) ? true : false);
         GXCCtl = "nRcdDeleted_78_" + sGXsfl_75_idx;
         nRcdDeleted_78 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_78_" + sGXsfl_75_idx;
         nRcdExists_78 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_78_" + sGXsfl_75_idx;
         nIsMod_78 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void assign_properties_default( )
      {
         defedtPerAnio_Enabled = edtPerAnio_Enabled;
      }

      protected void ConfirmValues0Z0( )
      {
         nGXsfl_75_idx = 0;
         sGXsfl_75_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_75_idx), 4, 0)), 4, "0");
         SubsflControlProps_7578( ) ;
         while ( nGXsfl_75_idx < nRC_GXsfl_75 )
         {
            nGXsfl_75_idx = (short)(nGXsfl_75_idx+1);
            sGXsfl_75_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_75_idx), 4, 0)), 4, "0");
            SubsflControlProps_7578( ) ;
            ChangePostValue( "Z335PerAnio_"+sGXsfl_75_idx, cgiGet( "ZT_"+"Z335PerAnio_"+sGXsfl_75_idx)) ;
            DeletePostValue( "ZT_"+"Z335PerAnio_"+sGXsfl_75_idx) ;
            ChangePostValue( "Z336PerUltMes_"+sGXsfl_75_idx, cgiGet( "ZT_"+"Z336PerUltMes_"+sGXsfl_75_idx)) ;
            DeletePostValue( "ZT_"+"Z336PerUltMes_"+sGXsfl_75_idx) ;
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
         context.SendWebValue( "Periodos") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20231110425745", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("periodos.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV19procesoCod)) + "," + UrlEncode("" +AV18EmpID) + "," + UrlEncode("" +AV9ageID) + "," + UrlEncode(StringUtil.RTrim(AV10usucod))+"\">") ;
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
         forbiddenHiddens = "hsh" + "Periodos";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV16Insert_PerUser, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("periodos:[SendSecurityCheck value for]"+"Insert_PerUser:"+StringUtil.RTrim( context.localUtil.Format( AV16Insert_PerUser, "")));
         GXUtil.WriteLog("periodos:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1EmpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z327procesoCod", Z327procesoCod);
         GxWebStd.gx_hidden_field( context, "Z328PerFchControl", context.localUtil.DToC( Z328PerFchControl, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z329PerDiasPlazo", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z329PerDiasPlazo), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z333PerUser", StringUtil.RTrim( Z333PerUser));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_75", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_75_idx), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "N333PerUser", StringUtil.RTrim( A333PerUser));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV14TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV14TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9ageID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9ageID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV18EmpID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vPROCESOCOD", AV19procesoCod);
         GxWebStd.gx_hidden_field( context, "gxhash_vPROCESOCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV19procesoCod, "")), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_PERUSER", StringUtil.RTrim( AV16Insert_PerUser));
         GxWebStd.gx_hidden_field( context, "vUSUCOD", StringUtil.RTrim( AV10usucod));
         GxWebStd.gx_hidden_field( context, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV10usucod, "")), context));
         GxWebStd.gx_hidden_field( context, "EMPDSC", A44empdsc);
         GxWebStd.gx_hidden_field( context, "PERUSERNAME", A334PerUserName);
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV20Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void RenderHtmlCloseForm0Z77( )
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
         return "Periodos" ;
      }

      public override String GetPgmdesc( )
      {
         return "Periodos" ;
      }

      protected void InitializeNonKey0Z77( )
      {
         A333PerUser = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A333PerUser", A333PerUser);
         A331PerAnioActual = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A331PerAnioActual", StringUtil.LTrim( StringUtil.Str( (decimal)(A331PerAnioActual), 4, 0)));
         A332PerMesActual = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A332PerMesActual", StringUtil.LTrim( StringUtil.Str( (decimal)(A332PerMesActual), 2, 0)));
         A44empdsc = "";
         n44empdsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         A328PerFchControl = DateTime.MinValue;
         n328PerFchControl = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328PerFchControl", context.localUtil.Format(A328PerFchControl, "99/99/9999"));
         n328PerFchControl = ((DateTime.MinValue==A328PerFchControl) ? true : false);
         A329PerDiasPlazo = 0;
         n329PerDiasPlazo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A329PerDiasPlazo", StringUtil.LTrim( StringUtil.Str( (decimal)(A329PerDiasPlazo), 2, 0)));
         n329PerDiasPlazo = ((0==A329PerDiasPlazo) ? true : false);
         A334PerUserName = "";
         n334PerUserName = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A334PerUserName", A334PerUserName);
         Z328PerFchControl = DateTime.MinValue;
         Z329PerDiasPlazo = 0;
         Z333PerUser = "";
      }

      protected void InitAll0Z77( )
      {
         A1EmpID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         A327procesoCod = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327procesoCod", A327procesoCod);
         InitializeNonKey0Z77( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey0Z78( )
      {
         A336PerUltMes = 0;
         n336PerUltMes = false;
         Z336PerUltMes = 0;
      }

      protected void InitAll0Z78( )
      {
         A335PerAnio = 0;
         InitializeNonKey0Z78( ) ;
      }

      protected void StandaloneModalInsert0Z78( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20231110425759", true);
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
         context.AddJavascriptSource("periodos.js", "?20231110425759", false);
         /* End function include_jscripts */
      }

      protected void init_level_properties78( )
      {
         edtPerAnio_Enabled = defedtPerAnio_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPerAnio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPerAnio_Enabled), 5, 0)), !bGXsfl_75_Refreshing);
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
         dynEmpID_Internalname = "EMPID";
         edtPerAnioActual_Internalname = "PERANIOACTUAL";
         edtPerMesActual_Internalname = "PERMESACTUAL";
         divTable2_Internalname = "TABLE2";
         edtprocesoCod_Internalname = "PROCESOCOD";
         edtPerFchControl_Internalname = "PERFCHCONTROL";
         divTable1_Internalname = "TABLE1";
         edtPerDiasPlazo_Internalname = "PERDIASPLAZO";
         dynPerUser_Internalname = "PERUSER";
         lblTitleper_Internalname = "TITLEPER";
         edtPerAnio_Internalname = "PERANIO";
         edtPerUltMes_Internalname = "PERULTMES";
         divPertable_Internalname = "PERTABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         subGridperiodos_per_Internalname = "GRIDPERIODOS_PER";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtPerUltMes_Jsonclick = "";
         edtPerAnio_Jsonclick = "";
         subGridperiodos_per_Class = "Grid";
         subGridperiodos_per_Backcolorstyle = 0;
         subGridperiodos_per_Allowcollapsing = 0;
         subGridperiodos_per_Allowselection = 0;
         edtPerUltMes_Enabled = 1;
         edtPerAnio_Enabled = 1;
         subGridperiodos_per_Header = "";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         dynPerUser_Jsonclick = "";
         dynPerUser.Enabled = 1;
         edtPerDiasPlazo_Jsonclick = "";
         edtPerDiasPlazo_Enabled = 1;
         edtPerFchControl_Jsonclick = "";
         edtPerFchControl_Enabled = 1;
         edtprocesoCod_Jsonclick = "";
         edtprocesoCod_Enabled = 1;
         edtPerMesActual_Jsonclick = "";
         edtPerMesActual_Enabled = 0;
         edtPerAnioActual_Jsonclick = "";
         edtPerAnioActual_Enabled = 0;
         dynEmpID_Jsonclick = "";
         dynEmpID.Enabled = 1;
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

      protected void GXDLAEMPID0Z77( short AV18EmpID )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLAEMPID_data0Z77( AV18EmpID) ;
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

      protected void GXAEMPID_html0Z77( short AV18EmpID )
      {
         short gxdynajaxvalue ;
         GXDLAEMPID_data0Z77( AV18EmpID) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynEmpID.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (short)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynEmpID.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 4, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLAEMPID_data0Z77( short AV18EmpID )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         /* Using cursor T000Z28 */
         pr_default.execute(26, new Object[] {AV18EmpID});
         while ( (pr_default.getStatus(26) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T000Z28_A1EmpID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(T000Z28_A44empdsc[0]);
            pr_default.readNext(26);
         }
         pr_default.close(26);
      }

      protected void GXDLAPERUSER0Z77( String AV10usucod )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLAPERUSER_data0Z77( AV10usucod) ;
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

      protected void GXAPERUSER_html0Z77( String AV10usucod )
      {
         String gxdynajaxvalue ;
         GXDLAPERUSER_data0Z77( AV10usucod) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynPerUser.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynPerUser.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLAPERUSER_data0Z77( String AV10usucod )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         /* Using cursor T000Z29 */
         pr_default.execute(27, new Object[] {AV10usucod});
         while ( (pr_default.getStatus(27) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( T000Z29_A3UsuCod[0]));
            gxdynajaxctrldescr.Add(T000Z29_A50UsuName[0]);
            pr_default.readNext(27);
         }
         pr_default.close(27);
      }

      protected void GX4ASAPERMESACTUAL0Z77( short A1EmpID ,
                                             String A327procesoCod ,
                                             DateTime A328PerFchControl )
      {
         GXt_int1 = A332PerMesActual;
         new obtperiodos(context ).execute(  A1EmpID,  A327procesoCod,  A328PerFchControl, out  GXt_int1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327procesoCod", A327procesoCod);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328PerFchControl", context.localUtil.Format(A328PerFchControl, "99/99/9999"));
         A332PerMesActual = GXt_int1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A332PerMesActual", StringUtil.LTrim( StringUtil.Str( (decimal)(A332PerMesActual), 2, 0)));
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A332PerMesActual), 2, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX5ASAPERANIOACTUAL0Z77( short A1EmpID ,
                                              String A327procesoCod ,
                                              DateTime A328PerFchControl )
      {
         GXt_int1 = A331PerAnioActual;
         new obtanio(context ).execute(  A1EmpID,  A327procesoCod,  A328PerFchControl, out  GXt_int1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327procesoCod", A327procesoCod);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328PerFchControl", context.localUtil.Format(A328PerFchControl, "99/99/9999"));
         A331PerAnioActual = GXt_int1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A331PerAnioActual", StringUtil.LTrim( StringUtil.Str( (decimal)(A331PerAnioActual), 4, 0)));
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A331PerAnioActual), 4, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void gxnrGridperiodos_per_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_7578( ) ;
         while ( nGXsfl_75_idx <= nRC_GXsfl_75 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0Z78( ) ;
            standaloneModal0Z78( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow0Z78( ) ;
            nGXsfl_75_idx = (short)(nGXsfl_75_idx+1);
            sGXsfl_75_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_75_idx), 4, 0)), 4, "0");
            SubsflControlProps_7578( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Gridperiodos_perContainer));
         /* End function gxnrGridperiodos_per_newrow */
      }

      protected void init_web_controls( )
      {
         dynEmpID.Name = "EMPID";
         dynEmpID.WebTags = "";
         dynPerUser.Name = "PERUSER";
         dynPerUser.WebTags = "";
         /* End function init_web_controls */
      }

      public void Valid_Empid( GXCombobox dynGX_Parm1 ,
                               String GX_Parm2 )
      {
         dynEmpID = dynGX_Parm1;
         A1EmpID = (short)(NumberUtil.Val( dynEmpID.CurrentValue, "."));
         A44empdsc = GX_Parm2;
         n44empdsc = false;
         /* Using cursor T000Z30 */
         pr_default.execute(28, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(28) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = dynEmpID_Internalname;
         }
         A44empdsc = T000Z30_A44empdsc[0];
         n44empdsc = T000Z30_n44empdsc[0];
         pr_default.close(28);
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

      public void Valid_Perfchcontrol( DateTime GX_Parm1 ,
                                       GXCombobox dynGX_Parm2 ,
                                       String GX_Parm3 ,
                                       short GX_Parm4 ,
                                       short GX_Parm5 )
      {
         A328PerFchControl = GX_Parm1;
         n328PerFchControl = false;
         dynEmpID = dynGX_Parm2;
         A1EmpID = (short)(NumberUtil.Val( dynEmpID.CurrentValue, "."));
         A327procesoCod = GX_Parm3;
         A332PerMesActual = GX_Parm4;
         A331PerAnioActual = GX_Parm5;
         if ( ! ( (DateTime.MinValue==A328PerFchControl) || ( A328PerFchControl >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fch Control fuera de rango", "OutOfRange", 1, "PERFCHCONTROL");
            AnyError = 1;
            GX_FocusControl = edtPerFchControl_Internalname;
         }
         GXt_int1 = A332PerMesActual;
         new obtperiodos(context ).execute(  A1EmpID,  A327procesoCod,  A328PerFchControl, out  GXt_int1) ;
         A332PerMesActual = GXt_int1;
         GXt_int1 = A331PerAnioActual;
         new obtanio(context ).execute(  A1EmpID,  A327procesoCod,  A328PerFchControl, out  GXt_int1) ;
         A331PerAnioActual = GXt_int1;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A332PerMesActual), 2, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A331PerAnioActual), 4, 0, ".", "")));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Peruser( GXCombobox dynGX_Parm1 ,
                                 String GX_Parm2 )
      {
         dynPerUser = dynGX_Parm1;
         A333PerUser = dynPerUser.CurrentValue;
         A334PerUserName = GX_Parm2;
         n334PerUserName = false;
         /* Using cursor T000Z31 */
         pr_default.execute(29, new Object[] {A333PerUser});
         if ( (pr_default.getStatus(29) == 101) )
         {
            GX_msglist.addItem("No existe 'user Periodos'.", "ForeignKeyNotFound", 1, "PERUSER");
            AnyError = 1;
            GX_FocusControl = dynPerUser_Internalname;
         }
         A334PerUserName = T000Z31_A334PerUserName[0];
         n334PerUserName = T000Z31_n334PerUserName[0];
         pr_default.close(29);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A334PerUserName = "";
            n334PerUserName = false;
         }
         isValidOutput.Add(A334PerUserName);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV19procesoCod',fld:'vPROCESOCOD',pic:'',hsh:true},{av:'AV9ageID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV18EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynEmpID'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'AV10usucod',fld:'vUSUCOD',pic:'',hsh:true},{av:'dynPerUser'},{av:'A333PerUser',fld:'PERUSER',pic:''}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV18EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynEmpID'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'AV10usucod',fld:'vUSUCOD',pic:'',hsh:true},{av:'dynPerUser'},{av:'A333PerUser',fld:'PERUSER',pic:''}]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9ageID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV19procesoCod',fld:'vPROCESOCOD',pic:'',hsh:true},{av:'AV16Insert_PerUser',fld:'vINSERT_PERUSER',pic:''},{av:'AV18EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynEmpID'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'AV10usucod',fld:'vUSUCOD',pic:'',hsh:true},{av:'dynPerUser'},{av:'A333PerUser',fld:'PERUSER',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV18EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynEmpID'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'AV10usucod',fld:'vUSUCOD',pic:'',hsh:true},{av:'dynPerUser'},{av:'A333PerUser',fld:'PERUSER',pic:''}]}");
         setEventMetadata("AFTER TRN","{handler:'E120Z2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV14TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'AV18EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynEmpID'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'AV10usucod',fld:'vUSUCOD',pic:'',hsh:true},{av:'dynPerUser'},{av:'A333PerUser',fld:'PERUSER',pic:''}]");
         setEventMetadata("AFTER TRN",",oparms:[{av:'AV18EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynEmpID'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'AV10usucod',fld:'vUSUCOD',pic:'',hsh:true},{av:'dynPerUser'},{av:'A333PerUser',fld:'PERUSER',pic:''}]}");
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
         pr_default.close(28);
         pr_default.close(15);
         pr_default.close(29);
         pr_default.close(16);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         wcpOAV19procesoCod = "";
         wcpOAV10usucod = "";
         Z327procesoCod = "";
         Z328PerFchControl = DateTime.MinValue;
         Z333PerUser = "";
         N333PerUser = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         A327procesoCod = "";
         A328PerFchControl = DateTime.MinValue;
         A333PerUser = "";
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
         lblTitleper_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridperiodos_perContainer = new GXWebGrid( context);
         Gridperiodos_perColumn = new GXWebColumn();
         sMode78 = "";
         sStyleString = "";
         AV16Insert_PerUser = "";
         A44empdsc = "";
         A334PerUserName = "";
         AV20Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode77 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         AV14TrnContext = new SdtTransactionContext(context);
         AV15WebSession = context.GetSession();
         AV17TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z44empdsc = "";
         Z334PerUserName = "";
         T000Z6_A44empdsc = new String[] {""} ;
         T000Z6_n44empdsc = new bool[] {false} ;
         T000Z7_A334PerUserName = new String[] {""} ;
         T000Z7_n334PerUserName = new bool[] {false} ;
         T000Z8_A327procesoCod = new String[] {""} ;
         T000Z8_A44empdsc = new String[] {""} ;
         T000Z8_n44empdsc = new bool[] {false} ;
         T000Z8_A328PerFchControl = new DateTime[] {DateTime.MinValue} ;
         T000Z8_n328PerFchControl = new bool[] {false} ;
         T000Z8_A329PerDiasPlazo = new short[1] ;
         T000Z8_n329PerDiasPlazo = new bool[] {false} ;
         T000Z8_A334PerUserName = new String[] {""} ;
         T000Z8_n334PerUserName = new bool[] {false} ;
         T000Z8_A1EmpID = new short[1] ;
         T000Z8_A333PerUser = new String[] {""} ;
         T000Z9_A44empdsc = new String[] {""} ;
         T000Z9_n44empdsc = new bool[] {false} ;
         T000Z10_A334PerUserName = new String[] {""} ;
         T000Z10_n334PerUserName = new bool[] {false} ;
         T000Z11_A1EmpID = new short[1] ;
         T000Z11_A327procesoCod = new String[] {""} ;
         T000Z5_A327procesoCod = new String[] {""} ;
         T000Z5_A328PerFchControl = new DateTime[] {DateTime.MinValue} ;
         T000Z5_n328PerFchControl = new bool[] {false} ;
         T000Z5_A329PerDiasPlazo = new short[1] ;
         T000Z5_n329PerDiasPlazo = new bool[] {false} ;
         T000Z5_A1EmpID = new short[1] ;
         T000Z5_A333PerUser = new String[] {""} ;
         T000Z12_A1EmpID = new short[1] ;
         T000Z12_A327procesoCod = new String[] {""} ;
         T000Z13_A1EmpID = new short[1] ;
         T000Z13_A327procesoCod = new String[] {""} ;
         T000Z4_A327procesoCod = new String[] {""} ;
         T000Z4_A328PerFchControl = new DateTime[] {DateTime.MinValue} ;
         T000Z4_n328PerFchControl = new bool[] {false} ;
         T000Z4_A329PerDiasPlazo = new short[1] ;
         T000Z4_n329PerDiasPlazo = new bool[] {false} ;
         T000Z4_A1EmpID = new short[1] ;
         T000Z4_A333PerUser = new String[] {""} ;
         T000Z17_A44empdsc = new String[] {""} ;
         T000Z17_n44empdsc = new bool[] {false} ;
         T000Z18_A334PerUserName = new String[] {""} ;
         T000Z18_n334PerUserName = new bool[] {false} ;
         T000Z19_A1EmpID = new short[1] ;
         T000Z19_A327procesoCod = new String[] {""} ;
         T000Z19_A335PerAnio = new short[1] ;
         T000Z19_A337detFchIni = new DateTime[] {DateTime.MinValue} ;
         T000Z20_A1EmpID = new short[1] ;
         T000Z20_A327procesoCod = new String[] {""} ;
         T000Z21_A1EmpID = new short[1] ;
         T000Z21_A327procesoCod = new String[] {""} ;
         T000Z21_A335PerAnio = new short[1] ;
         T000Z21_A336PerUltMes = new short[1] ;
         T000Z21_n336PerUltMes = new bool[] {false} ;
         T000Z22_A1EmpID = new short[1] ;
         T000Z22_A327procesoCod = new String[] {""} ;
         T000Z22_A335PerAnio = new short[1] ;
         T000Z3_A1EmpID = new short[1] ;
         T000Z3_A327procesoCod = new String[] {""} ;
         T000Z3_A335PerAnio = new short[1] ;
         T000Z3_A336PerUltMes = new short[1] ;
         T000Z3_n336PerUltMes = new bool[] {false} ;
         T000Z2_A1EmpID = new short[1] ;
         T000Z2_A327procesoCod = new String[] {""} ;
         T000Z2_A335PerAnio = new short[1] ;
         T000Z2_A336PerUltMes = new short[1] ;
         T000Z2_n336PerUltMes = new bool[] {false} ;
         T000Z26_A1EmpID = new short[1] ;
         T000Z26_A327procesoCod = new String[] {""} ;
         T000Z26_A335PerAnio = new short[1] ;
         T000Z26_A337detFchIni = new DateTime[] {DateTime.MinValue} ;
         T000Z27_A1EmpID = new short[1] ;
         T000Z27_A327procesoCod = new String[] {""} ;
         T000Z27_A335PerAnio = new short[1] ;
         Gridperiodos_perRow = new GXWebRow();
         subGridperiodos_per_Linesclass = "";
         ROClassString = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         T000Z28_A1EmpID = new short[1] ;
         T000Z28_A44empdsc = new String[] {""} ;
         T000Z28_n44empdsc = new bool[] {false} ;
         T000Z29_A3UsuCod = new String[] {""} ;
         T000Z29_A50UsuName = new String[] {""} ;
         T000Z29_n50UsuName = new bool[] {false} ;
         T000Z30_A44empdsc = new String[] {""} ;
         T000Z30_n44empdsc = new bool[] {false} ;
         isValidOutput = new GxUnknownObjectCollection();
         T000Z31_A334PerUserName = new String[] {""} ;
         T000Z31_n334PerUserName = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.periodos__default(),
            new Object[][] {
                new Object[] {
               T000Z2_A1EmpID, T000Z2_A327procesoCod, T000Z2_A335PerAnio, T000Z2_A336PerUltMes, T000Z2_n336PerUltMes
               }
               , new Object[] {
               T000Z3_A1EmpID, T000Z3_A327procesoCod, T000Z3_A335PerAnio, T000Z3_A336PerUltMes, T000Z3_n336PerUltMes
               }
               , new Object[] {
               T000Z4_A327procesoCod, T000Z4_A328PerFchControl, T000Z4_n328PerFchControl, T000Z4_A329PerDiasPlazo, T000Z4_n329PerDiasPlazo, T000Z4_A1EmpID, T000Z4_A333PerUser
               }
               , new Object[] {
               T000Z5_A327procesoCod, T000Z5_A328PerFchControl, T000Z5_n328PerFchControl, T000Z5_A329PerDiasPlazo, T000Z5_n329PerDiasPlazo, T000Z5_A1EmpID, T000Z5_A333PerUser
               }
               , new Object[] {
               T000Z6_A44empdsc, T000Z6_n44empdsc
               }
               , new Object[] {
               T000Z7_A334PerUserName, T000Z7_n334PerUserName
               }
               , new Object[] {
               T000Z8_A327procesoCod, T000Z8_A44empdsc, T000Z8_n44empdsc, T000Z8_A328PerFchControl, T000Z8_n328PerFchControl, T000Z8_A329PerDiasPlazo, T000Z8_n329PerDiasPlazo, T000Z8_A334PerUserName, T000Z8_n334PerUserName, T000Z8_A1EmpID,
               T000Z8_A333PerUser
               }
               , new Object[] {
               T000Z9_A44empdsc, T000Z9_n44empdsc
               }
               , new Object[] {
               T000Z10_A334PerUserName, T000Z10_n334PerUserName
               }
               , new Object[] {
               T000Z11_A1EmpID, T000Z11_A327procesoCod
               }
               , new Object[] {
               T000Z12_A1EmpID, T000Z12_A327procesoCod
               }
               , new Object[] {
               T000Z13_A1EmpID, T000Z13_A327procesoCod
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000Z17_A44empdsc, T000Z17_n44empdsc
               }
               , new Object[] {
               T000Z18_A334PerUserName, T000Z18_n334PerUserName
               }
               , new Object[] {
               T000Z19_A1EmpID, T000Z19_A327procesoCod, T000Z19_A335PerAnio, T000Z19_A337detFchIni
               }
               , new Object[] {
               T000Z20_A1EmpID, T000Z20_A327procesoCod
               }
               , new Object[] {
               T000Z21_A1EmpID, T000Z21_A327procesoCod, T000Z21_A335PerAnio, T000Z21_A336PerUltMes, T000Z21_n336PerUltMes
               }
               , new Object[] {
               T000Z22_A1EmpID, T000Z22_A327procesoCod, T000Z22_A335PerAnio
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000Z26_A1EmpID, T000Z26_A327procesoCod, T000Z26_A335PerAnio, T000Z26_A337detFchIni
               }
               , new Object[] {
               T000Z27_A1EmpID, T000Z27_A327procesoCod, T000Z27_A335PerAnio
               }
               , new Object[] {
               T000Z28_A1EmpID, T000Z28_A44empdsc, T000Z28_n44empdsc
               }
               , new Object[] {
               T000Z29_A3UsuCod, T000Z29_A50UsuName, T000Z29_n50UsuName
               }
               , new Object[] {
               T000Z30_A44empdsc, T000Z30_n44empdsc
               }
               , new Object[] {
               T000Z31_A334PerUserName, T000Z31_n334PerUserName
               }
            }
         );
         AV20Pgmname = "Periodos";
      }

      private short wcpOAV18EmpID ;
      private short wcpOAV9ageID ;
      private short Z1EmpID ;
      private short Z329PerDiasPlazo ;
      private short nRC_GXsfl_75 ;
      private short nGXsfl_75_idx=1 ;
      private short Z335PerAnio ;
      private short Z336PerUltMes ;
      private short nRcdDeleted_78 ;
      private short nRcdExists_78 ;
      private short nIsMod_78 ;
      private short GxWebError ;
      private short AV18EmpID ;
      private short A1EmpID ;
      private short AV9ageID ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short A331PerAnioActual ;
      private short A332PerMesActual ;
      private short A329PerDiasPlazo ;
      private short subGridperiodos_per_Backcolorstyle ;
      private short A335PerAnio ;
      private short A336PerUltMes ;
      private short subGridperiodos_per_Allowselection ;
      private short subGridperiodos_per_Allowhovering ;
      private short subGridperiodos_per_Allowcollapsing ;
      private short subGridperiodos_per_Collapsed ;
      private short nBlankRcdCount78 ;
      private short RcdFound78 ;
      private short nBlankRcdUsr78 ;
      private short RcdFound77 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short subGridperiodos_per_Backstyle ;
      private short wbTemp ;
      private short GXt_int1 ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtPerAnioActual_Enabled ;
      private int edtPerMesActual_Enabled ;
      private int edtprocesoCod_Enabled ;
      private int edtPerFchControl_Enabled ;
      private int edtPerDiasPlazo_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtPerAnio_Enabled ;
      private int edtPerUltMes_Enabled ;
      private int subGridperiodos_per_Selectedindex ;
      private int subGridperiodos_per_Selectioncolor ;
      private int subGridperiodos_per_Hoveringcolor ;
      private int fRowAdded ;
      private int AV21GXV1 ;
      private int subGridperiodos_per_Backcolor ;
      private int subGridperiodos_per_Allbackcolor ;
      private int defedtPerAnio_Enabled ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private long GRIDPERIODOS_PER_nFirstRecordOnPage ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String wcpOAV10usucod ;
      private String Z333PerUser ;
      private String N333PerUser ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String AV10usucod ;
      private String A333PerUser ;
      private String sGXsfl_75_idx="0001" ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String dynEmpID_Internalname ;
      private String dynPerUser_Internalname ;
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
      private String dynEmpID_Jsonclick ;
      private String divTable2_Internalname ;
      private String edtPerAnioActual_Internalname ;
      private String edtPerAnioActual_Jsonclick ;
      private String edtPerMesActual_Internalname ;
      private String edtPerMesActual_Jsonclick ;
      private String divTable1_Internalname ;
      private String edtprocesoCod_Internalname ;
      private String edtprocesoCod_Jsonclick ;
      private String edtPerFchControl_Internalname ;
      private String edtPerFchControl_Jsonclick ;
      private String edtPerDiasPlazo_Internalname ;
      private String edtPerDiasPlazo_Jsonclick ;
      private String dynPerUser_Jsonclick ;
      private String divPertable_Internalname ;
      private String lblTitleper_Internalname ;
      private String lblTitleper_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridperiodos_per_Header ;
      private String sMode78 ;
      private String edtPerAnio_Internalname ;
      private String edtPerUltMes_Internalname ;
      private String sStyleString ;
      private String AV16Insert_PerUser ;
      private String AV20Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode77 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String sGXsfl_75_fel_idx="0001" ;
      private String subGridperiodos_per_Class ;
      private String subGridperiodos_per_Linesclass ;
      private String ROClassString ;
      private String edtPerAnio_Jsonclick ;
      private String edtPerUltMes_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridperiodos_per_Internalname ;
      private String gxwrpcisep ;
      private DateTime Z328PerFchControl ;
      private DateTime A328PerFchControl ;
      private bool entryPointCalled ;
      private bool n328PerFchControl ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool bGXsfl_75_Refreshing=false ;
      private bool n329PerDiasPlazo ;
      private bool n44empdsc ;
      private bool n334PerUserName ;
      private bool returnInSub ;
      private bool n336PerUltMes ;
      private bool gxdyncontrolsrefreshing ;
      private String wcpOAV19procesoCod ;
      private String Z327procesoCod ;
      private String A327procesoCod ;
      private String AV19procesoCod ;
      private String A44empdsc ;
      private String A334PerUserName ;
      private String Z44empdsc ;
      private String Z334PerUserName ;
      private IGxSession AV15WebSession ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebGrid Gridperiodos_perContainer ;
      private GXWebRow Gridperiodos_perRow ;
      private GXWebColumn Gridperiodos_perColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynEmpID ;
      private GXCombobox dynPerUser ;
      private IDataStoreProvider pr_default ;
      private String[] T000Z6_A44empdsc ;
      private bool[] T000Z6_n44empdsc ;
      private String[] T000Z7_A334PerUserName ;
      private bool[] T000Z7_n334PerUserName ;
      private String[] T000Z8_A327procesoCod ;
      private String[] T000Z8_A44empdsc ;
      private bool[] T000Z8_n44empdsc ;
      private DateTime[] T000Z8_A328PerFchControl ;
      private bool[] T000Z8_n328PerFchControl ;
      private short[] T000Z8_A329PerDiasPlazo ;
      private bool[] T000Z8_n329PerDiasPlazo ;
      private String[] T000Z8_A334PerUserName ;
      private bool[] T000Z8_n334PerUserName ;
      private short[] T000Z8_A1EmpID ;
      private String[] T000Z8_A333PerUser ;
      private String[] T000Z9_A44empdsc ;
      private bool[] T000Z9_n44empdsc ;
      private String[] T000Z10_A334PerUserName ;
      private bool[] T000Z10_n334PerUserName ;
      private short[] T000Z11_A1EmpID ;
      private String[] T000Z11_A327procesoCod ;
      private String[] T000Z5_A327procesoCod ;
      private DateTime[] T000Z5_A328PerFchControl ;
      private bool[] T000Z5_n328PerFchControl ;
      private short[] T000Z5_A329PerDiasPlazo ;
      private bool[] T000Z5_n329PerDiasPlazo ;
      private short[] T000Z5_A1EmpID ;
      private String[] T000Z5_A333PerUser ;
      private short[] T000Z12_A1EmpID ;
      private String[] T000Z12_A327procesoCod ;
      private short[] T000Z13_A1EmpID ;
      private String[] T000Z13_A327procesoCod ;
      private String[] T000Z4_A327procesoCod ;
      private DateTime[] T000Z4_A328PerFchControl ;
      private bool[] T000Z4_n328PerFchControl ;
      private short[] T000Z4_A329PerDiasPlazo ;
      private bool[] T000Z4_n329PerDiasPlazo ;
      private short[] T000Z4_A1EmpID ;
      private String[] T000Z4_A333PerUser ;
      private String[] T000Z17_A44empdsc ;
      private bool[] T000Z17_n44empdsc ;
      private String[] T000Z18_A334PerUserName ;
      private bool[] T000Z18_n334PerUserName ;
      private short[] T000Z19_A1EmpID ;
      private String[] T000Z19_A327procesoCod ;
      private short[] T000Z19_A335PerAnio ;
      private DateTime[] T000Z19_A337detFchIni ;
      private short[] T000Z20_A1EmpID ;
      private String[] T000Z20_A327procesoCod ;
      private short[] T000Z21_A1EmpID ;
      private String[] T000Z21_A327procesoCod ;
      private short[] T000Z21_A335PerAnio ;
      private short[] T000Z21_A336PerUltMes ;
      private bool[] T000Z21_n336PerUltMes ;
      private short[] T000Z22_A1EmpID ;
      private String[] T000Z22_A327procesoCod ;
      private short[] T000Z22_A335PerAnio ;
      private short[] T000Z3_A1EmpID ;
      private String[] T000Z3_A327procesoCod ;
      private short[] T000Z3_A335PerAnio ;
      private short[] T000Z3_A336PerUltMes ;
      private bool[] T000Z3_n336PerUltMes ;
      private short[] T000Z2_A1EmpID ;
      private String[] T000Z2_A327procesoCod ;
      private short[] T000Z2_A335PerAnio ;
      private short[] T000Z2_A336PerUltMes ;
      private bool[] T000Z2_n336PerUltMes ;
      private short[] T000Z26_A1EmpID ;
      private String[] T000Z26_A327procesoCod ;
      private short[] T000Z26_A335PerAnio ;
      private DateTime[] T000Z26_A337detFchIni ;
      private short[] T000Z27_A1EmpID ;
      private String[] T000Z27_A327procesoCod ;
      private short[] T000Z27_A335PerAnio ;
      private short[] T000Z28_A1EmpID ;
      private String[] T000Z28_A44empdsc ;
      private bool[] T000Z28_n44empdsc ;
      private String[] T000Z29_A3UsuCod ;
      private String[] T000Z29_A50UsuName ;
      private bool[] T000Z29_n50UsuName ;
      private String[] T000Z30_A44empdsc ;
      private bool[] T000Z30_n44empdsc ;
      private String[] T000Z31_A334PerUserName ;
      private bool[] T000Z31_n334PerUserName ;
      private SdtTransactionContext AV14TrnContext ;
      private SdtTransactionContext_Attribute AV17TrnContextAtt ;
   }

   public class periodos__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[21])
         ,new UpdateCursor(def[22])
         ,new UpdateCursor(def[23])
         ,new ForEachCursor(def[24])
         ,new ForEachCursor(def[25])
         ,new ForEachCursor(def[26])
         ,new ForEachCursor(def[27])
         ,new ForEachCursor(def[28])
         ,new ForEachCursor(def[29])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000Z8 ;
          prmT000Z8 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000Z6 ;
          prmT000Z6 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Z7 ;
          prmT000Z7 = new Object[] {
          new Object[] {"@PerUser",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000Z9 ;
          prmT000Z9 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Z10 ;
          prmT000Z10 = new Object[] {
          new Object[] {"@PerUser",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000Z11 ;
          prmT000Z11 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000Z5 ;
          prmT000Z5 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000Z12 ;
          prmT000Z12 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000Z13 ;
          prmT000Z13 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000Z4 ;
          prmT000Z4 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000Z14 ;
          prmT000Z14 = new Object[] {
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PerFchControl",SqlDbType.DateTime,8,0} ,
          new Object[] {"@PerDiasPlazo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PerUser",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000Z15 ;
          prmT000Z15 = new Object[] {
          new Object[] {"@PerFchControl",SqlDbType.DateTime,8,0} ,
          new Object[] {"@PerDiasPlazo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@PerUser",SqlDbType.Char,15,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000Z16 ;
          prmT000Z16 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000Z17 ;
          prmT000Z17 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Z18 ;
          prmT000Z18 = new Object[] {
          new Object[] {"@PerUser",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000Z19 ;
          prmT000Z19 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000Z20 ;
          prmT000Z20 = new Object[] {
          } ;
          Object[] prmT000Z21 ;
          prmT000Z21 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PerAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Z22 ;
          prmT000Z22 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PerAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Z3 ;
          prmT000Z3 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PerAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Z2 ;
          prmT000Z2 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PerAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Z23 ;
          prmT000Z23 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PerAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PerUltMes",SqlDbType.SmallInt,2,0}
          } ;
          Object[] prmT000Z24 ;
          prmT000Z24 = new Object[] {
          new Object[] {"@PerUltMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PerAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Z25 ;
          prmT000Z25 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PerAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Z26 ;
          prmT000Z26 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PerAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Z27 ;
          prmT000Z27 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000Z28 ;
          prmT000Z28 = new Object[] {
          new Object[] {"@AV18EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Z29 ;
          prmT000Z29 = new Object[] {
          new Object[] {"@AV10usucod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000Z30 ;
          prmT000Z30 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Z31 ;
          prmT000Z31 = new Object[] {
          new Object[] {"@PerUser",SqlDbType.Char,15,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000Z2", "SELECT [EmpID], [procesoCod], [PerAnio], [PerUltMes] FROM [PeriodosPer] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [procesoCod] = @procesoCod AND [PerAnio] = @PerAnio ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z2,1,0,true,false )
             ,new CursorDef("T000Z3", "SELECT [EmpID], [procesoCod], [PerAnio], [PerUltMes] FROM [PeriodosPer] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [procesoCod] = @procesoCod AND [PerAnio] = @PerAnio ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z3,1,0,true,false )
             ,new CursorDef("T000Z4", "SELECT [procesoCod], [PerFchControl], [PerDiasPlazo], [EmpID], [PerUser] AS PerUser FROM [Periodos] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [procesoCod] = @procesoCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z4,1,0,true,false )
             ,new CursorDef("T000Z5", "SELECT [procesoCod], [PerFchControl], [PerDiasPlazo], [EmpID], [PerUser] AS PerUser FROM [Periodos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [procesoCod] = @procesoCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z5,1,0,true,false )
             ,new CursorDef("T000Z6", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z6,1,0,true,false )
             ,new CursorDef("T000Z7", "SELECT [UsuName] AS PerUserName FROM [Usuarios] WITH (NOLOCK) WHERE [UsuCod] = @PerUser ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z7,1,0,true,false )
             ,new CursorDef("T000Z8", "SELECT TM1.[procesoCod], T2.[empdsc], TM1.[PerFchControl], TM1.[PerDiasPlazo], T3.[UsuName] AS PerUserName, TM1.[EmpID], TM1.[PerUser] AS PerUser FROM (([Periodos] TM1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = TM1.[EmpID]) INNER JOIN [Usuarios] T3 WITH (NOLOCK) ON T3.[UsuCod] = TM1.[PerUser]) WHERE TM1.[EmpID] = @EmpID and TM1.[procesoCod] = @procesoCod ORDER BY TM1.[EmpID], TM1.[procesoCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z8,100,0,true,false )
             ,new CursorDef("T000Z9", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z9,1,0,true,false )
             ,new CursorDef("T000Z10", "SELECT [UsuName] AS PerUserName FROM [Usuarios] WITH (NOLOCK) WHERE [UsuCod] = @PerUser ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z10,1,0,true,false )
             ,new CursorDef("T000Z11", "SELECT [EmpID], [procesoCod] FROM [Periodos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [procesoCod] = @procesoCod  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z11,1,0,true,false )
             ,new CursorDef("T000Z12", "SELECT TOP 1 [EmpID], [procesoCod] FROM [Periodos] WITH (NOLOCK) WHERE ( [EmpID] > @EmpID or [EmpID] = @EmpID and [procesoCod] > @procesoCod) ORDER BY [EmpID], [procesoCod]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z12,1,0,true,true )
             ,new CursorDef("T000Z13", "SELECT TOP 1 [EmpID], [procesoCod] FROM [Periodos] WITH (NOLOCK) WHERE ( [EmpID] < @EmpID or [EmpID] = @EmpID and [procesoCod] < @procesoCod) ORDER BY [EmpID] DESC, [procesoCod] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z13,1,0,true,true )
             ,new CursorDef("T000Z14", "INSERT INTO [Periodos]([procesoCod], [PerFchControl], [PerDiasPlazo], [EmpID], [PerUser]) VALUES(@procesoCod, @PerFchControl, @PerDiasPlazo, @EmpID, @PerUser)", GxErrorMask.GX_NOMASK,prmT000Z14)
             ,new CursorDef("T000Z15", "UPDATE [Periodos] SET [PerFchControl]=@PerFchControl, [PerDiasPlazo]=@PerDiasPlazo, [PerUser]=@PerUser  WHERE [EmpID] = @EmpID AND [procesoCod] = @procesoCod", GxErrorMask.GX_NOMASK,prmT000Z15)
             ,new CursorDef("T000Z16", "DELETE FROM [Periodos]  WHERE [EmpID] = @EmpID AND [procesoCod] = @procesoCod", GxErrorMask.GX_NOMASK,prmT000Z16)
             ,new CursorDef("T000Z17", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z17,1,0,true,false )
             ,new CursorDef("T000Z18", "SELECT [UsuName] AS PerUserName FROM [Usuarios] WITH (NOLOCK) WHERE [UsuCod] = @PerUser ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z18,1,0,true,false )
             ,new CursorDef("T000Z19", "SELECT TOP 1 [EmpID], [procesoCod], [PerAnio], [detFchIni] FROM [PeriodosDetdetFch] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [procesoCod] = @procesoCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z19,1,0,true,true )
             ,new CursorDef("T000Z20", "SELECT [EmpID], [procesoCod] FROM [Periodos] WITH (NOLOCK) ORDER BY [EmpID], [procesoCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z20,100,0,true,false )
             ,new CursorDef("T000Z21", "SELECT [EmpID], [procesoCod], [PerAnio], [PerUltMes] FROM [PeriodosPer] WITH (NOLOCK) WHERE [EmpID] = @EmpID and [procesoCod] = @procesoCod and [PerAnio] = @PerAnio ORDER BY [EmpID], [procesoCod], [PerAnio] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z21,11,0,true,false )
             ,new CursorDef("T000Z22", "SELECT [EmpID], [procesoCod], [PerAnio] FROM [PeriodosPer] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [procesoCod] = @procesoCod AND [PerAnio] = @PerAnio ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z22,1,0,true,false )
             ,new CursorDef("T000Z23", "INSERT INTO [PeriodosPer]([EmpID], [procesoCod], [PerAnio], [PerUltMes]) VALUES(@EmpID, @procesoCod, @PerAnio, @PerUltMes)", GxErrorMask.GX_NOMASK,prmT000Z23)
             ,new CursorDef("T000Z24", "UPDATE [PeriodosPer] SET [PerUltMes]=@PerUltMes  WHERE [EmpID] = @EmpID AND [procesoCod] = @procesoCod AND [PerAnio] = @PerAnio", GxErrorMask.GX_NOMASK,prmT000Z24)
             ,new CursorDef("T000Z25", "DELETE FROM [PeriodosPer]  WHERE [EmpID] = @EmpID AND [procesoCod] = @procesoCod AND [PerAnio] = @PerAnio", GxErrorMask.GX_NOMASK,prmT000Z25)
             ,new CursorDef("T000Z26", "SELECT TOP 1 [EmpID], [procesoCod], [PerAnio], [detFchIni] FROM [PeriodosDetdetFch] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [procesoCod] = @procesoCod AND [PerAnio] = @PerAnio ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z26,1,0,true,true )
             ,new CursorDef("T000Z27", "SELECT [EmpID], [procesoCod], [PerAnio] FROM [PeriodosPer] WITH (NOLOCK) WHERE [EmpID] = @EmpID and [procesoCod] = @procesoCod ORDER BY [EmpID], [procesoCod], [PerAnio] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z27,11,0,true,false )
             ,new CursorDef("T000Z28", "SELECT [EmpID], [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @AV18EmpID ORDER BY [empdsc] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z28,0,0,true,false )
             ,new CursorDef("T000Z29", "SELECT [UsuCod], [UsuName] FROM [Usuarios] WITH (NOLOCK) WHERE [UsuCod] = @AV10usucod ORDER BY [UsuName] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z29,0,0,true,false )
             ,new CursorDef("T000Z30", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z30,1,0,true,false )
             ,new CursorDef("T000Z31", "SELECT [UsuName] AS PerUserName FROM [Usuarios] WITH (NOLOCK) WHERE [UsuCod] = @PerUser ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z31,1,0,true,false )
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((String[]) buf[6])[0] = rslt.getString(5, 15) ;
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((String[]) buf[6])[0] = rslt.getString(5, 15) ;
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                ((String[]) buf[10])[0] = rslt.getString(7, 15) ;
                return;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 17 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                return;
             case 18 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
             case 19 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                return;
             case 20 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 24 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                return;
             case 25 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 26 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                return;
             case 27 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                return;
             case 28 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 29 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
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
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
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
                stmt.SetParameter(4, (short)parms[5]);
                stmt.SetParameter(5, (String)parms[6]);
                return;
             case 13 :
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
                stmt.SetParameter(3, (String)parms[4]);
                stmt.SetParameter(4, (short)parms[5]);
                stmt.SetParameter(5, (String)parms[6]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 16 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 19 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 20 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 21 :
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
                return;
             case 22 :
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
                stmt.SetParameter(4, (short)parms[4]);
                return;
             case 23 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 24 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 25 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 26 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 27 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 28 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 29 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
       }
    }

 }

}
