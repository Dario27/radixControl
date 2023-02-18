/*
               File: DespBodega
        Description: Despacho Bodega
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/23/2023 1:6:42.92
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
   public class despbodega : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
            AV7empid = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7empid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7empid), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7empid), "ZZZ9"), context));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLAEMPID1293( AV7empid) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"AGEID") == 0 )
         {
            AV7empid = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7empid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7empid), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7empid), "ZZZ9"), context));
            AV8ageId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ageId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8ageId), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8ageId), "ZZZ9"), context));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLAAGEID1293( AV7empid, AV8ageId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel24"+"_"+"DESPBODSTOCK") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A42BodCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
            A355DespBodCodPrd = (short)(NumberUtil.Val( GetNextPar( ), "."));
            n355DespBodCodPrd = false;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX24ASADESPBODSTOCK1294( A1EmpID, A2AgeID, A42BodCod, A355DespBodCodPrd) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_35") == 0 )
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
            gxLoad_35( A1EmpID, A42BodCod) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_34") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A5ClienteID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_34( A1EmpID, A5ClienteID) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Griddespbodega_prd") == 0 )
         {
            nRC_GXsfl_108 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_108_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_108_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGriddespbodega_prd_newrow( ) ;
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
               AV7empid = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7empid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7empid), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7empid), "ZZZ9"), context));
               AV8ageId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ageId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8ageId), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8ageId), "ZZZ9"), context));
               AV10DespBodNro = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10DespBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10DespBodNro), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vDESPBODNRO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10DespBodNro), "ZZZ9"), context));
               AV17OrdenID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17OrdenID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vORDENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV17OrdenID), "ZZZ9"), context));
               AV21clienteID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21clienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21clienteID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vCLIENTEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV21clienteID), "ZZZ9"), context));
               AV20usuCod = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20usuCod", AV20usuCod);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV20usuCod, "")), context));
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
            Form.Meta.addItem("description", "Despacho Bodega", 0) ;
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

      public despbodega( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public despbodega( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_empid ,
                           short aP2_ageId ,
                           short aP3_DespBodNro ,
                           short aP4_OrdenID ,
                           short aP5_clienteID ,
                           String aP6_usuCod )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7empid = aP1_empid;
         this.AV8ageId = aP2_ageId;
         this.AV10DespBodNro = aP3_DespBodNro;
         this.AV17OrdenID = aP4_OrdenID;
         this.AV21clienteID = aP5_clienteID;
         this.AV20usuCod = aP6_usuCod;
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
         dynAgeID = new GXCombobox();
         chkDespachadoOK = new GXCheckbox();
         chkDespBodModifItem = new GXCheckbox();
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
         if ( dynAgeID.ItemCount > 0 )
         {
            A2AgeID = (short)(NumberUtil.Val( dynAgeID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A2AgeID), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            dynAgeID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A2AgeID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynAgeID_Internalname, "Values", dynAgeID.ToJavascriptSource(), true);
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2 col-lg-10 col-lg-offset-1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTitlecontainer_Internalname, 1, 0, "px", 0, "px", "TableTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Despacho Bodega", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_DespBodega.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_DespBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_DespBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_DespBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_DespBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx02l0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"AGEID"+"'), id:'"+"AGEID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"DESPBODNRO"+"'), id:'"+"DESPBODNRO"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"ORDENID"+"'), id:'"+"ORDENID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"CLIENTEID"+"'), id:'"+"CLIENTEID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_DespBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 FormCell", "left", "Middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection1_Internalname, 1, 0, "px", 0, "px", "FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynEmpID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynEmpID_Internalname, "Empresa", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynEmpID, dynEmpID_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)), 1, dynEmpID_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dynEmpID.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,35);\"", "", true, "HLP_DespBodega.htm");
            dynEmpID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A1EmpID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynEmpID_Internalname, "Values", (String)(dynEmpID.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "Middle", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 FormCell", "left", "Middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection2_Internalname, 1, 0, "px", 0, "px", "FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynAgeID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynAgeID_Internalname, "Agencia", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynAgeID, dynAgeID_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)), 1, dynAgeID_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dynAgeID.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,40);\"", "", true, "HLP_DespBodega.htm");
            dynAgeID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A2AgeID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynAgeID_Internalname, "Values", (String)(dynAgeID.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "Middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 FormCell", "left", "Middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection3_Internalname, 1, 0, "px", 0, "px", "FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOrdenID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOrdenID_Internalname, "Nro. Orden", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtOrdenID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A22OrdenID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A22OrdenID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOrdenID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOrdenID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_DespBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "Middle", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 FormCell", "left", "Middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection4_Internalname, 1, 0, "px", 0, "px", "FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtDespBodNro_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtDespBodNro_Internalname, "Nro. Despacho", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtDespBodNro_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A353DespBodNro), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A353DespBodNro), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtDespBodNro_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtDespBodNro_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_DespBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "Middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"TAB1Container"+"\"></div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB1Container"+"title1"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTabpage2_title_Internalname, "Datos Cliente", "", "", lblTabpage2_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_DespBodega.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "TabPage2") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB1Container"+"panel1"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabpage2table_Internalname, 1, 0, "px", 0, "px", "FormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable2_Internalname, 1, 0, "px", 0, "px", "Flex", "left", "top", " "+"data-gx-flex"+" ", "flex-direction:column;", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "FormCell", "left", "top", "", "flex-grow::1;", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtClienteID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtClienteID_Internalname, "Cliente ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtClienteID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A5ClienteID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A5ClienteID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtClienteID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtClienteID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_DespBodega.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_5_Internalname, sImgUrl, imgprompt_5_Link, "", "", context.GetTheme( ), imgprompt_5_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_DespBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "FormCell", "left", "top", "", "flex-grow::1;", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtClienteRUC_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtClienteRUC_Internalname, "RUC/CI", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtClienteRUC_Internalname, StringUtil.RTrim( A56ClienteRUC), StringUtil.RTrim( context.localUtil.Format( A56ClienteRUC, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtClienteRUC_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtClienteRUC_Enabled, 0, "text", "", 13, "chr", 1, "row", 13, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_DespBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "FormCell", "left", "top", "", "flex-grow::1;", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtClienteDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtClienteDsc_Internalname, "Nombre Cliente", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtClienteDsc_Internalname, StringUtil.RTrim( A57ClienteDsc), StringUtil.RTrim( context.localUtil.Format( A57ClienteDsc, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtClienteDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtClienteDsc_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "Descripcion", "left", true, "HLP_DespBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB1Container"+"title2"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTabpage1_title_Internalname, "Datos Bodegas", "", "", lblTabpage1_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_DespBodega.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "TabPage1") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TAB1Container"+"panel2"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabpage1table_Internalname, 1, 0, "px", 0, "px", "FormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable1_Internalname, 1, 0, "px", 0, "px", "Flex", "left", "top", " "+"data-gx-flex"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "FormCell", "left", "top", "", "flex-grow::1;", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBodCod_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBodCod_Internalname, "Bodega", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBodCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A42BodCod), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A42BodCod), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,86);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBodCod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBodCod_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_DespBodega.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_42_Internalname, sImgUrl, imgprompt_42_Link, "", "", context.GetTheme( ), imgprompt_42_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_DespBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "FormCell", "left", "top", "", "flex-grow::1;", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBodDsc_Internalname, "Nombre", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBodDsc_Internalname, StringUtil.RTrim( A217BodDsc), StringUtil.RTrim( context.localUtil.Format( A217BodDsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBodDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBodDsc_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "nombres", "left", true, "HLP_DespBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", chkDespachadoOK.Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkDespachadoOK_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkDespachadoOK_Internalname, "Despachado?", "col-sm-3 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 94,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkDespachadoOK_Internalname, A402DespachadoOK, "", "Despachado?", chkDespachadoOK.Visible, chkDespachadoOK.Enabled, "S", "Si", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(94, this, 'S', 'N');gx.evt.onchange(this, event);\" ");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtDespBodUltReg_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtDespBodUltReg_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtDespBodUltReg_Internalname, "Ult Reg", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 99,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtDespBodUltReg_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A399DespBodUltReg), 6, 0, ",", "")), ((edtDespBodUltReg_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A399DespBodUltReg), "ZZZZZ9")) : context.localUtil.Format( (decimal)(A399DespBodUltReg), "ZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,99);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtDespBodUltReg_Jsonclick, 0, "Attribute", "", "", "", "", edtDespBodUltReg_Visible, edtDespBodUltReg_Enabled, 0, "number", "1", 6, "chr", 1, "row", 6, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_DespBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divPrdtable_Internalname, divPrdtable_Visible, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitleprd_Internalname, "productos", "", "", lblTitleprd_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_DespBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Griddespbodega_prd( ) ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 126,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_DespBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 128,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_DespBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 130,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_DespBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm1293( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void gxdraw_Griddespbodega_prd( )
      {
         /*  Grid Control  */
         Griddespbodega_prdContainer.AddObjectProperty("GridName", "Griddespbodega_prd");
         Griddespbodega_prdContainer.AddObjectProperty("Header", subGriddespbodega_prd_Header);
         Griddespbodega_prdContainer.AddObjectProperty("Class", "Grid");
         Griddespbodega_prdContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Griddespbodega_prdContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Griddespbodega_prdContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriddespbodega_prd_Backcolorstyle), 1, 0, ".", "")));
         Griddespbodega_prdContainer.AddObjectProperty("Sortable", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriddespbodega_prd_Sortable), 1, 0, ".", "")));
         Griddespbodega_prdContainer.AddObjectProperty("CmpContext", "");
         Griddespbodega_prdContainer.AddObjectProperty("InMasterPage", "false");
         Griddespbodega_prdColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Griddespbodega_prdColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A400nroReg), 6, 0, ".", "")));
         Griddespbodega_prdColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtnroReg_Enabled), 5, 0, ".", "")));
         Griddespbodega_prdContainer.AddColumnProperties(Griddespbodega_prdColumn);
         Griddespbodega_prdColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Griddespbodega_prdColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A355DespBodCodPrd), 4, 0, ".", "")));
         Griddespbodega_prdColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodCodPrd_Enabled), 5, 0, ".", "")));
         Griddespbodega_prdContainer.AddColumnProperties(Griddespbodega_prdColumn);
         Griddespbodega_prdColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Griddespbodega_prdColumn.AddObjectProperty("Value", StringUtil.RTrim( A356DespBodPrdNombre));
         Griddespbodega_prdColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodPrdNombre_Enabled), 5, 0, ".", "")));
         Griddespbodega_prdContainer.AddColumnProperties(Griddespbodega_prdColumn);
         Griddespbodega_prdColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Griddespbodega_prdColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A357DespBodCant, 8, 2, ".", "")));
         Griddespbodega_prdColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodCant_Enabled), 5, 0, ".", "")));
         Griddespbodega_prdContainer.AddColumnProperties(Griddespbodega_prdColumn);
         Griddespbodega_prdColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Griddespbodega_prdColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A358DespBodValor, 8, 2, ".", "")));
         Griddespbodega_prdColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodValor_Enabled), 5, 0, ".", "")));
         Griddespbodega_prdContainer.AddColumnProperties(Griddespbodega_prdColumn);
         Griddespbodega_prdColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Griddespbodega_prdColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A359DespBodADesp, 8, 2, ".", "")));
         Griddespbodega_prdColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodADesp_Enabled), 5, 0, ".", "")));
         Griddespbodega_prdContainer.AddColumnProperties(Griddespbodega_prdColumn);
         Griddespbodega_prdColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Griddespbodega_prdColumn.AddObjectProperty("Value", StringUtil.RTrim( A376DespBodDetalle));
         Griddespbodega_prdColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodDetalle_Enabled), 5, 0, ".", "")));
         Griddespbodega_prdContainer.AddColumnProperties(Griddespbodega_prdColumn);
         Griddespbodega_prdColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Griddespbodega_prdColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A360DespBodStock, 6, 2, ".", "")));
         Griddespbodega_prdColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodStock_Enabled), 5, 0, ".", "")));
         Griddespbodega_prdContainer.AddColumnProperties(Griddespbodega_prdColumn);
         Griddespbodega_prdColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Griddespbodega_prdColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A361DespBodCatId), 4, 0, ".", "")));
         Griddespbodega_prdColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodCatId_Enabled), 5, 0, ".", "")));
         Griddespbodega_prdContainer.AddColumnProperties(Griddespbodega_prdColumn);
         Griddespbodega_prdColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Griddespbodega_prdColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A362DespBodDif), 4, 0, ".", "")));
         Griddespbodega_prdColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodDif_Enabled), 5, 0, ".", "")));
         Griddespbodega_prdContainer.AddColumnProperties(Griddespbodega_prdColumn);
         Griddespbodega_prdColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Griddespbodega_prdColumn.AddObjectProperty("Value", StringUtil.RTrim( A403DespBodModifItem));
         Griddespbodega_prdColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkDespBodModifItem.Enabled), 5, 0, ".", "")));
         Griddespbodega_prdContainer.AddColumnProperties(Griddespbodega_prdColumn);
         Griddespbodega_prdColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Griddespbodega_prdColumn.AddObjectProperty("Value", context.convertURL( AV19despachado));
         Griddespbodega_prdColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDespachado_Enabled), 5, 0, ".", "")));
         Griddespbodega_prdColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDespachado_Tooltiptext));
         Griddespbodega_prdColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDespachado_Visible), 5, 0, ".", "")));
         Griddespbodega_prdContainer.AddColumnProperties(Griddespbodega_prdColumn);
         Griddespbodega_prdColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Griddespbodega_prdColumn.AddObjectProperty("Value", StringUtil.RTrim( A392DespBodOK));
         Griddespbodega_prdColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodOK_Enabled), 5, 0, ".", "")));
         Griddespbodega_prdContainer.AddColumnProperties(Griddespbodega_prdColumn);
         Griddespbodega_prdContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriddespbodega_prd_Selectedindex), 4, 0, ".", "")));
         Griddespbodega_prdContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriddespbodega_prd_Allowselection), 1, 0, ".", "")));
         Griddespbodega_prdContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriddespbodega_prd_Selectioncolor), 9, 0, ".", "")));
         Griddespbodega_prdContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriddespbodega_prd_Allowhovering), 1, 0, ".", "")));
         Griddespbodega_prdContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriddespbodega_prd_Hoveringcolor), 9, 0, ".", "")));
         Griddespbodega_prdContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriddespbodega_prd_Allowcollapsing), 1, 0, ".", "")));
         Griddespbodega_prdContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriddespbodega_prd_Collapsed), 1, 0, ".", "")));
         nGXsfl_108_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount94 = 3;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_94 = 1;
               ScanStart1294( ) ;
               while ( RcdFound94 != 0 )
               {
                  init_level_properties94( ) ;
                  getByPrimaryKey1294( ) ;
                  AddRow1294( ) ;
                  ScanNext1294( ) ;
               }
               ScanEnd1294( ) ;
               nBlankRcdCount94 = 3;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal1294( ) ;
            standaloneModal1294( ) ;
            sMode94 = Gx_mode;
            while ( nGXsfl_108_idx < nRC_GXsfl_108 )
            {
               bGXsfl_108_Refreshing = true;
               ReadRow1294( ) ;
               edtnroReg_Enabled = (int)(context.localUtil.CToN( cgiGet( "NROREG_"+sGXsfl_108_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtnroReg_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtnroReg_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
               edtDespBodCodPrd_Enabled = (int)(context.localUtil.CToN( cgiGet( "DESPBODCODPRD_"+sGXsfl_108_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodCodPrd_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodCodPrd_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
               edtDespBodPrdNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "DESPBODPRDNOMBRE_"+sGXsfl_108_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodPrdNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodPrdNombre_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
               edtDespBodCant_Enabled = (int)(context.localUtil.CToN( cgiGet( "DESPBODCANT_"+sGXsfl_108_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodCant_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodCant_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
               edtDespBodValor_Enabled = (int)(context.localUtil.CToN( cgiGet( "DESPBODVALOR_"+sGXsfl_108_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodValor_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodValor_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
               edtDespBodADesp_Enabled = (int)(context.localUtil.CToN( cgiGet( "DESPBODADESP_"+sGXsfl_108_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodADesp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodADesp_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
               edtDespBodDetalle_Enabled = (int)(context.localUtil.CToN( cgiGet( "DESPBODDETALLE_"+sGXsfl_108_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodDetalle_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodDetalle_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
               edtDespBodStock_Enabled = (int)(context.localUtil.CToN( cgiGet( "DESPBODSTOCK_"+sGXsfl_108_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodStock_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodStock_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
               edtDespBodCatId_Enabled = (int)(context.localUtil.CToN( cgiGet( "DESPBODCATID_"+sGXsfl_108_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodCatId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodCatId_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
               edtDespBodDif_Enabled = (int)(context.localUtil.CToN( cgiGet( "DESPBODDIF_"+sGXsfl_108_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodDif_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodDif_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
               chkDespBodModifItem.Enabled = (int)(context.localUtil.CToN( cgiGet( "DESPBODMODIFITEM_"+sGXsfl_108_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkDespBodModifItem_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkDespBodModifItem.Enabled), 5, 0)), !bGXsfl_108_Refreshing);
               edtavDespachado_Enabled = (int)(context.localUtil.CToN( cgiGet( "vDESPACHADO_"+sGXsfl_108_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDespachado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDespachado_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
               edtavDespachado_Tooltiptext = cgiGet( "vDESPACHADO_"+sGXsfl_108_idx+"Tooltiptext");
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDespachado_Internalname, "Tooltiptext", edtavDespachado_Tooltiptext, !bGXsfl_108_Refreshing);
               edtavDespachado_Visible = (int)(context.localUtil.CToN( cgiGet( "vDESPACHADO_"+sGXsfl_108_idx+"Visible"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDespachado_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDespachado_Visible), 5, 0)), !bGXsfl_108_Refreshing);
               edtDespBodOK_Enabled = (int)(context.localUtil.CToN( cgiGet( "DESPBODOK_"+sGXsfl_108_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodOK_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodOK_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
               if ( ( nRcdExists_94 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal1294( ) ;
               }
               SendRow1294( ) ;
               bGXsfl_108_Refreshing = false;
            }
            Gx_mode = sMode94;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount94 = 3;
            nRcdExists_94 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart1294( ) ;
               while ( RcdFound94 != 0 )
               {
                  sGXsfl_108_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_108_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_10894( ) ;
                  init_level_properties94( ) ;
                  standaloneNotModal1294( ) ;
                  getByPrimaryKey1294( ) ;
                  standaloneModal1294( ) ;
                  AddRow1294( ) ;
                  ScanNext1294( ) ;
               }
               ScanEnd1294( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode94 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_108_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_108_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_10894( ) ;
            InitAll1294( ) ;
            init_level_properties94( ) ;
            standaloneNotModal1294( ) ;
            standaloneModal1294( ) ;
            nRcdExists_94 = 0;
            nIsMod_94 = 0;
            nRcdDeleted_94 = 0;
            nBlankRcdCount94 = (short)(nBlankRcdUsr94+nBlankRcdCount94);
            fRowAdded = 0;
            while ( nBlankRcdCount94 > 0 )
            {
               AddRow1294( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtnroReg_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount94 = (short)(nBlankRcdCount94-1);
            }
            Gx_mode = sMode94;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Griddespbodega_prdContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Griddespbodega_prd", Griddespbodega_prdContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Griddespbodega_prdContainerData", Griddespbodega_prdContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Griddespbodega_prdContainerData"+"V", Griddespbodega_prdContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Griddespbodega_prdContainerData"+"V"+"\" value='"+Griddespbodega_prdContainer.GridValuesHidden()+"'/>") ;
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
         E11122 ();
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
               dynAgeID.Name = dynAgeID_Internalname;
               dynAgeID.CurrentValue = cgiGet( dynAgeID_Internalname);
               A2AgeID = (short)(NumberUtil.Val( cgiGet( dynAgeID_Internalname), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
               if ( ( ( context.localUtil.CToN( cgiGet( edtOrdenID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtOrdenID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ORDENID");
                  AnyError = 1;
                  GX_FocusControl = edtOrdenID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A22OrdenID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
               }
               else
               {
                  A22OrdenID = (short)(context.localUtil.CToN( cgiGet( edtOrdenID_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtDespBodNro_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtDespBodNro_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "DESPBODNRO");
                  AnyError = 1;
                  GX_FocusControl = edtDespBodNro_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A353DespBodNro = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A353DespBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A353DespBodNro), 4, 0)));
               }
               else
               {
                  A353DespBodNro = (short)(context.localUtil.CToN( cgiGet( edtDespBodNro_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A353DespBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A353DespBodNro), 4, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtClienteID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtClienteID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CLIENTEID");
                  AnyError = 1;
                  GX_FocusControl = edtClienteID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A5ClienteID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
               }
               else
               {
                  A5ClienteID = (short)(context.localUtil.CToN( cgiGet( edtClienteID_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
               }
               A56ClienteRUC = cgiGet( edtClienteRUC_Internalname);
               n56ClienteRUC = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56ClienteRUC", A56ClienteRUC);
               A57ClienteDsc = cgiGet( edtClienteDsc_Internalname);
               n57ClienteDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A57ClienteDsc", A57ClienteDsc);
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
               A402DespachadoOK = ((StringUtil.StrCmp(cgiGet( chkDespachadoOK_Internalname), "S")==0) ? "S" : "N");
               n402DespachadoOK = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A402DespachadoOK", A402DespachadoOK);
               n402DespachadoOK = (String.IsNullOrEmpty(StringUtil.RTrim( A402DespachadoOK)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtDespBodUltReg_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtDespBodUltReg_Internalname), ",", ".") > Convert.ToDecimal( 999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "DESPBODULTREG");
                  AnyError = 1;
                  GX_FocusControl = edtDespBodUltReg_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A399DespBodUltReg = 0;
                  n399DespBodUltReg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A399DespBodUltReg", StringUtil.LTrim( StringUtil.Str( (decimal)(A399DespBodUltReg), 6, 0)));
               }
               else
               {
                  A399DespBodUltReg = (int)(context.localUtil.CToN( cgiGet( edtDespBodUltReg_Internalname), ",", "."));
                  n399DespBodUltReg = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A399DespBodUltReg", StringUtil.LTrim( StringUtil.Str( (decimal)(A399DespBodUltReg), 6, 0)));
               }
               n399DespBodUltReg = ((0==A399DespBodUltReg) ? true : false);
               /* Read saved values. */
               Z1EmpID = (short)(context.localUtil.CToN( cgiGet( "Z1EmpID"), ",", "."));
               Z2AgeID = (short)(context.localUtil.CToN( cgiGet( "Z2AgeID"), ",", "."));
               Z353DespBodNro = (short)(context.localUtil.CToN( cgiGet( "Z353DespBodNro"), ",", "."));
               Z22OrdenID = (short)(context.localUtil.CToN( cgiGet( "Z22OrdenID"), ",", "."));
               Z5ClienteID = (short)(context.localUtil.CToN( cgiGet( "Z5ClienteID"), ",", "."));
               Z399DespBodUltReg = (int)(context.localUtil.CToN( cgiGet( "Z399DespBodUltReg"), ",", "."));
               n399DespBodUltReg = ((0==A399DespBodUltReg) ? true : false);
               Z402DespachadoOK = cgiGet( "Z402DespachadoOK");
               n402DespachadoOK = (String.IsNullOrEmpty(StringUtil.RTrim( A402DespachadoOK)) ? true : false);
               Z42BodCod = (short)(context.localUtil.CToN( cgiGet( "Z42BodCod"), ",", "."));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_108 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_108"), ",", "."));
               N42BodCod = (short)(context.localUtil.CToN( cgiGet( "N42BodCod"), ",", "."));
               AV7empid = (short)(context.localUtil.CToN( cgiGet( "vEMPID"), ",", "."));
               AV8ageId = (short)(context.localUtil.CToN( cgiGet( "vAGEID"), ",", "."));
               AV10DespBodNro = (short)(context.localUtil.CToN( cgiGet( "vDESPBODNRO"), ",", "."));
               AV17OrdenID = (short)(context.localUtil.CToN( cgiGet( "vORDENID"), ",", "."));
               AV21clienteID = (short)(context.localUtil.CToN( cgiGet( "vCLIENTEID"), ",", "."));
               AV15Insert_BodCod = (short)(context.localUtil.CToN( cgiGet( "vINSERT_BODCOD"), ",", "."));
               A44empdsc = cgiGet( "EMPDSC");
               n44empdsc = false;
               A46AgeDsc = cgiGet( "AGEDSC");
               n46AgeDsc = false;
               AV23Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               Tab1_Objectcall = cgiGet( "TAB1_Objectcall");
               Tab1_Enabled = StringUtil.StrToBool( cgiGet( "TAB1_Enabled"));
               Tab1_Class = cgiGet( "TAB1_Class");
               Tab1_Activepage = (int)(context.localUtil.CToN( cgiGet( "TAB1_Activepage"), ",", "."));
               Tab1_Activepagecontrolname = cgiGet( "TAB1_Activepagecontrolname");
               Tab1_Pagecount = (int)(context.localUtil.CToN( cgiGet( "TAB1_Pagecount"), ",", "."));
               Tab1_Historymanagement = StringUtil.StrToBool( cgiGet( "TAB1_Historymanagement"));
               Tab1_Visible = StringUtil.StrToBool( cgiGet( "TAB1_Visible"));
               /* Read subfile selected row values. */
               nGXsfl_108_idx = (short)(context.localUtil.CToN( cgiGet( subGriddespbodega_prd_Internalname+"_ROW"), ",", "."));
               sGXsfl_108_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_108_idx), 4, 0)), 4, "0");
               SubsflControlProps_10894( ) ;
               if ( nGXsfl_108_idx > 0 )
               {
                  if ( ( ( context.localUtil.CToN( cgiGet( edtnroReg_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtnroReg_Internalname), ",", ".") > Convert.ToDecimal( 999999 )) ) )
                  {
                     GXCCtl = "NROREG_" + sGXsfl_108_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtnroReg_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     wbErr = true;
                     A400nroReg = 0;
                  }
                  else
                  {
                     A400nroReg = (int)(context.localUtil.CToN( cgiGet( edtnroReg_Internalname), ",", "."));
                  }
                  if ( ( ( context.localUtil.CToN( cgiGet( edtDespBodCodPrd_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtDespBodCodPrd_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
                  {
                     GXCCtl = "DESPBODCODPRD_" + sGXsfl_108_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtDespBodCodPrd_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     wbErr = true;
                     A355DespBodCodPrd = 0;
                     n355DespBodCodPrd = false;
                  }
                  else
                  {
                     A355DespBodCodPrd = (short)(context.localUtil.CToN( cgiGet( edtDespBodCodPrd_Internalname), ",", "."));
                     n355DespBodCodPrd = false;
                  }
                  n355DespBodCodPrd = ((0==A355DespBodCodPrd) ? true : false);
                  A356DespBodPrdNombre = StringUtil.Upper( cgiGet( edtDespBodPrdNombre_Internalname));
                  n356DespBodPrdNombre = false;
                  A357DespBodCant = context.localUtil.CToN( cgiGet( edtDespBodCant_Internalname), ",", ".");
                  n357DespBodCant = false;
                  A358DespBodValor = context.localUtil.CToN( cgiGet( edtDespBodValor_Internalname), ",", ".");
                  n358DespBodValor = false;
                  if ( ( ( context.localUtil.CToN( cgiGet( edtDespBodADesp_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtDespBodADesp_Internalname), ",", ".") > 99999.99m ) ) )
                  {
                     GXCCtl = "DESPBODADESP_" + sGXsfl_108_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtDespBodADesp_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     wbErr = true;
                     A359DespBodADesp = 0;
                     n359DespBodADesp = false;
                  }
                  else
                  {
                     A359DespBodADesp = context.localUtil.CToN( cgiGet( edtDespBodADesp_Internalname), ",", ".");
                     n359DespBodADesp = false;
                  }
                  n359DespBodADesp = ((Convert.ToDecimal(0)==A359DespBodADesp) ? true : false);
                  A376DespBodDetalle = cgiGet( edtDespBodDetalle_Internalname);
                  n376DespBodDetalle = false;
                  A360DespBodStock = context.localUtil.CToN( cgiGet( edtDespBodStock_Internalname), ",", ".");
                  A361DespBodCatId = (short)(context.localUtil.CToN( cgiGet( edtDespBodCatId_Internalname), ",", "."));
                  n361DespBodCatId = false;
                  A362DespBodDif = (short)(context.localUtil.CToN( cgiGet( edtDespBodDif_Internalname), ",", "."));
                  A403DespBodModifItem = ((StringUtil.StrCmp(cgiGet( chkDespBodModifItem_Internalname), "S")==0) ? "S" : "N");
                  n403DespBodModifItem = false;
                  n403DespBodModifItem = (String.IsNullOrEmpty(StringUtil.RTrim( A403DespBodModifItem)) ? true : false);
                  AV19despachado = cgiGet( edtavDespachado_Internalname);
                  A392DespBodOK = cgiGet( edtDespBodOK_Internalname);
                  n392DespBodOK = false;
                  GXCCtl = "Z400nroReg_" + sGXsfl_108_idx;
                  Z400nroReg = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
                  GXCCtl = "Z355DespBodCodPrd_" + sGXsfl_108_idx;
                  Z355DespBodCodPrd = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
                  n355DespBodCodPrd = ((0==A355DespBodCodPrd) ? true : false);
                  GXCCtl = "Z356DespBodPrdNombre_" + sGXsfl_108_idx;
                  Z356DespBodPrdNombre = cgiGet( GXCCtl);
                  n356DespBodPrdNombre = (String.IsNullOrEmpty(StringUtil.RTrim( A356DespBodPrdNombre)) ? true : false);
                  GXCCtl = "Z357DespBodCant_" + sGXsfl_108_idx;
                  Z357DespBodCant = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
                  n357DespBodCant = ((Convert.ToDecimal(0)==A357DespBodCant) ? true : false);
                  GXCCtl = "Z358DespBodValor_" + sGXsfl_108_idx;
                  Z358DespBodValor = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
                  n358DespBodValor = ((Convert.ToDecimal(0)==A358DespBodValor) ? true : false);
                  GXCCtl = "Z359DespBodADesp_" + sGXsfl_108_idx;
                  Z359DespBodADesp = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
                  n359DespBodADesp = ((Convert.ToDecimal(0)==A359DespBodADesp) ? true : false);
                  GXCCtl = "Z376DespBodDetalle_" + sGXsfl_108_idx;
                  Z376DespBodDetalle = cgiGet( GXCCtl);
                  n376DespBodDetalle = (String.IsNullOrEmpty(StringUtil.RTrim( A376DespBodDetalle)) ? true : false);
                  GXCCtl = "Z361DespBodCatId_" + sGXsfl_108_idx;
                  Z361DespBodCatId = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
                  n361DespBodCatId = ((0==A361DespBodCatId) ? true : false);
                  GXCCtl = "Z392DespBodOK_" + sGXsfl_108_idx;
                  Z392DespBodOK = cgiGet( GXCCtl);
                  n392DespBodOK = (String.IsNullOrEmpty(StringUtil.RTrim( A392DespBodOK)) ? true : false);
                  GXCCtl = "Z403DespBodModifItem_" + sGXsfl_108_idx;
                  Z403DespBodModifItem = cgiGet( GXCCtl);
                  n403DespBodModifItem = (String.IsNullOrEmpty(StringUtil.RTrim( A403DespBodModifItem)) ? true : false);
                  GXCCtl = "nRcdDeleted_94_" + sGXsfl_108_idx;
                  nRcdDeleted_94 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
                  GXCCtl = "nRcdExists_94_" + sGXsfl_108_idx;
                  nRcdExists_94 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
                  GXCCtl = "nIsMod_94_" + sGXsfl_108_idx;
                  nIsMod_94 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
               }
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "DespBodega";
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV15Insert_BodCod), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A353DespBodNro != Z353DespBodNro ) || ( A22OrdenID != Z22OrdenID ) || ( A5ClienteID != Z5ClienteID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("despbodega:[SecurityCheckFailed value for]"+"Insert_BodCod:"+context.localUtil.Format( (decimal)(AV15Insert_BodCod), "ZZZ9"));
                  GXUtil.WriteLog("despbodega:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A353DespBodNro = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A353DespBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A353DespBodNro), 4, 0)));
                  A22OrdenID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
                  A5ClienteID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
                  getEqualNoModal( ) ;
                  GXAEMPID_html1293( AV7empid) ;
                  GXAAGEID_html1293( AV7empid, AV8ageId) ;
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
                     sMode93 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     GXAEMPID_html1293( AV7empid) ;
                     GXAAGEID_html1293( AV7empid, AV8ageId) ;
                     Gx_mode = sMode93;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound93 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_120( ) ;
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
                        E11122 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: After Trn */
                        E12122 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "GRIDDESPBODEGA_PRD.ONLINEACTIVATE") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        E13122 ();
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
            E12122 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll1293( ) ;
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
            DisableAttributes1293( ) ;
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

      protected void CONFIRM_120( )
      {
         BeforeValidate1293( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1293( ) ;
            }
            else
            {
               CheckExtendedTable1293( ) ;
               CloseExtendedTableCursors1293( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode93 = Gx_mode;
            CONFIRM_1294( ) ;
            if ( AnyError == 0 )
            {
               /* Restore parent mode. */
               Gx_mode = sMode93;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
               IsConfirmed = 1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
            }
            /* Restore parent mode. */
            Gx_mode = sMode93;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
      }

      protected void CONFIRM_1294( )
      {
         nGXsfl_108_idx = 0;
         while ( nGXsfl_108_idx < nRC_GXsfl_108 )
         {
            ReadRow1294( ) ;
            if ( ( nRcdExists_94 != 0 ) || ( nIsMod_94 != 0 ) )
            {
               GetKey1294( ) ;
               if ( ( nRcdExists_94 == 0 ) && ( nRcdDeleted_94 == 0 ) )
               {
                  if ( RcdFound94 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate1294( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable1294( ) ;
                        CloseExtendedTableCursors1294( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "NROREG_" + sGXsfl_108_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtnroReg_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound94 != 0 )
                  {
                     if ( nRcdDeleted_94 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey1294( ) ;
                        Load1294( ) ;
                        BeforeValidate1294( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls1294( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_94 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate1294( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable1294( ) ;
                              CloseExtendedTableCursors1294( ) ;
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
                     if ( nRcdDeleted_94 == 0 )
                     {
                        GXCCtl = "NROREG_" + sGXsfl_108_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtnroReg_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtnroReg_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A400nroReg), 6, 0, ",", ""))) ;
            ChangePostValue( edtDespBodCodPrd_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A355DespBodCodPrd), 4, 0, ",", ""))) ;
            ChangePostValue( edtDespBodPrdNombre_Internalname, StringUtil.RTrim( A356DespBodPrdNombre)) ;
            ChangePostValue( edtDespBodCant_Internalname, StringUtil.LTrim( StringUtil.NToC( A357DespBodCant, 8, 2, ",", ""))) ;
            ChangePostValue( edtDespBodValor_Internalname, StringUtil.LTrim( StringUtil.NToC( A358DespBodValor, 8, 2, ",", ""))) ;
            ChangePostValue( edtDespBodADesp_Internalname, StringUtil.LTrim( StringUtil.NToC( A359DespBodADesp, 8, 2, ",", ""))) ;
            ChangePostValue( edtDespBodDetalle_Internalname, StringUtil.RTrim( A376DespBodDetalle)) ;
            ChangePostValue( edtDespBodStock_Internalname, StringUtil.LTrim( StringUtil.NToC( A360DespBodStock, 6, 2, ",", ""))) ;
            ChangePostValue( edtDespBodCatId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A361DespBodCatId), 4, 0, ",", ""))) ;
            ChangePostValue( edtDespBodDif_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A362DespBodDif), 4, 0, ",", ""))) ;
            ChangePostValue( chkDespBodModifItem_Internalname, ((StringUtil.StrCmp(A403DespBodModifItem, "N")==0) ? "N" : "S")) ;
            ChangePostValue( edtavDespachado_Internalname, AV19despachado) ;
            ChangePostValue( edtDespBodOK_Internalname, StringUtil.RTrim( A392DespBodOK)) ;
            ChangePostValue( "ZT_"+"Z400nroReg_"+sGXsfl_108_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z400nroReg), 6, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z355DespBodCodPrd_"+sGXsfl_108_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z355DespBodCodPrd), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z356DespBodPrdNombre_"+sGXsfl_108_idx, StringUtil.RTrim( Z356DespBodPrdNombre)) ;
            ChangePostValue( "ZT_"+"Z357DespBodCant_"+sGXsfl_108_idx, StringUtil.LTrim( StringUtil.NToC( Z357DespBodCant, 8, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z358DespBodValor_"+sGXsfl_108_idx, StringUtil.LTrim( StringUtil.NToC( Z358DespBodValor, 8, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z359DespBodADesp_"+sGXsfl_108_idx, StringUtil.LTrim( StringUtil.NToC( Z359DespBodADesp, 8, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z376DespBodDetalle_"+sGXsfl_108_idx, StringUtil.RTrim( Z376DespBodDetalle)) ;
            ChangePostValue( "ZT_"+"Z361DespBodCatId_"+sGXsfl_108_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z361DespBodCatId), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z392DespBodOK_"+sGXsfl_108_idx, StringUtil.RTrim( Z392DespBodOK)) ;
            ChangePostValue( "ZT_"+"Z403DespBodModifItem_"+sGXsfl_108_idx, StringUtil.RTrim( Z403DespBodModifItem)) ;
            ChangePostValue( "nRcdDeleted_94_"+sGXsfl_108_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_94), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_94_"+sGXsfl_108_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_94), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_94_"+sGXsfl_108_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_94), 4, 0, ",", ""))) ;
            if ( nIsMod_94 != 0 )
            {
               ChangePostValue( "NROREG_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtnroReg_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DESPBODCODPRD_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodCodPrd_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DESPBODPRDNOMBRE_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodPrdNombre_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DESPBODCANT_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodCant_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DESPBODVALOR_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodValor_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DESPBODADESP_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodADesp_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DESPBODDETALLE_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodDetalle_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DESPBODSTOCK_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodStock_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DESPBODCATID_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodCatId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DESPBODDIF_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodDif_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DESPBODMODIFITEM_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkDespBodModifItem.Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "vDESPACHADO_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDespachado_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "vDESPACHADO_"+sGXsfl_108_idx+"Tooltiptext", StringUtil.RTrim( edtavDespachado_Tooltiptext)) ;
               ChangePostValue( "vDESPACHADO_"+sGXsfl_108_idx+"Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDespachado_Visible), 5, 0, ".", ""))) ;
               ChangePostValue( "DESPBODOK_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodOK_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption120( )
      {
      }

      protected void E11122( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV23Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV23Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV13TrnContext.FromXml(AV14WebSession.Get("TrnContext"), null, "TransactionContext", "KBCalpesa22");
         AV15Insert_BodCod = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Insert_BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15Insert_BodCod), 4, 0)));
         if ( ( StringUtil.StrCmp(AV13TrnContext.gxTpr_Transactionname, AV23Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV24GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24GXV1), 8, 0)));
            while ( AV24GXV1 <= AV13TrnContext.gxTpr_Attributes.Count )
            {
               AV16TrnContextAtt = ((SdtTransactionContext_Attribute)AV13TrnContext.gxTpr_Attributes.Item(AV24GXV1));
               if ( StringUtil.StrCmp(AV16TrnContextAtt.gxTpr_Attributename, "BodCod") == 0 )
               {
                  AV15Insert_BodCod = (short)(NumberUtil.Val( AV16TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Insert_BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15Insert_BodCod), 4, 0)));
               }
               AV24GXV1 = (int)(AV24GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24GXV1), 8, 0)));
            }
         }
         edtDespBodUltReg_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodUltReg_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodUltReg_Visible), 5, 0)), true);
         chkDespachadoOK.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkDespachadoOK_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkDespachadoOK.Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            divPrdtable_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divPrdtable_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divPrdtable_Visible), 5, 0)), true);
         }
         else
         {
            divPrdtable_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divPrdtable_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divPrdtable_Visible), 5, 0)), true);
         }
         if ( StringUtil.StrCmp(A402DespachadoOK, "S") == 0 )
         {
            chkDespachadoOK.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkDespachadoOK_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkDespachadoOK.Visible), 5, 0)), true);
         }
      }

      protected void E12122( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV13TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwdespbodega.aspx") );
            context.wjLocDisableFrm = 1;
         }
         chkDespBodModifItem.Enabled = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkDespBodModifItem_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkDespBodModifItem.Enabled), 5, 0)), !bGXsfl_108_Refreshing);
         new actstockbodegaprd(context ).execute(  AV7empid,  AV8ageId,  A353DespBodNro,  A5ClienteID,  A42BodCod,  A22OrdenID) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7empid", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7empid), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7empid), "ZZZ9"), context));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ageId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8ageId), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8ageId), "ZZZ9"), context));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A353DespBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A353DespBodNro), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
         /*  Sending Event outputs  */
      }

      protected void E13122( )
      {
         /* Griddespbodega_prd_Onlineactivate Routine */
         if ( ( A359DespBodADesp > Convert.ToDecimal( 0 )) )
         {
            AV19despachado = "logos/success_ico.svg";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDespachado_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV19despachado)) ? AV25Despachado_GXI : context.convertURL( context.PathToRelativeUrl( AV19despachado))), !bGXsfl_108_Refreshing);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDespachado_Internalname, "SrcSet", context.GetImageSrcSet( AV19despachado), true);
            AV25Despachado_GXI = GXDbFile.PathToUrl( "logos/success_ico.svg");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDespachado_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV19despachado)) ? AV25Despachado_GXI : context.convertURL( context.PathToRelativeUrl( AV19despachado))), !bGXsfl_108_Refreshing);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDespachado_Internalname, "SrcSet", context.GetImageSrcSet( AV19despachado), true);
            edtavDespachado_Tooltiptext = "Despachado";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDespachado_Internalname, "Tooltiptext", edtavDespachado_Tooltiptext, !bGXsfl_108_Refreshing);
         }
         else
         {
            AV19despachado = "logos/pendient.png";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDespachado_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV19despachado)) ? AV25Despachado_GXI : context.convertURL( context.PathToRelativeUrl( AV19despachado))), !bGXsfl_108_Refreshing);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDespachado_Internalname, "SrcSet", context.GetImageSrcSet( AV19despachado), true);
            AV25Despachado_GXI = GXDbFile.PathToUrl( "logos/pendient.png");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDespachado_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV19despachado)) ? AV25Despachado_GXI : context.convertURL( context.PathToRelativeUrl( AV19despachado))), !bGXsfl_108_Refreshing);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDespachado_Internalname, "SrcSet", context.GetImageSrcSet( AV19despachado), true);
            edtavDespachado_Tooltiptext = "Por Despachar";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDespachado_Internalname, "Tooltiptext", edtavDespachado_Tooltiptext, !bGXsfl_108_Refreshing);
         }
         /*  Sending Event outputs  */
      }

      protected void ZM1293( short GX_JID )
      {
         if ( ( GX_JID == 31 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z399DespBodUltReg = T00125_A399DespBodUltReg[0];
               Z402DespachadoOK = T00125_A402DespachadoOK[0];
               Z42BodCod = T00125_A42BodCod[0];
            }
            else
            {
               Z399DespBodUltReg = A399DespBodUltReg;
               Z402DespachadoOK = A402DespachadoOK;
               Z42BodCod = A42BodCod;
            }
         }
         if ( GX_JID == -31 )
         {
            Z353DespBodNro = A353DespBodNro;
            Z22OrdenID = A22OrdenID;
            Z399DespBodUltReg = A399DespBodUltReg;
            Z402DespachadoOK = A402DespachadoOK;
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z5ClienteID = A5ClienteID;
            Z42BodCod = A42BodCod;
            Z44empdsc = A44empdsc;
            Z46AgeDsc = A46AgeDsc;
            Z217BodDsc = A217BodDsc;
            Z56ClienteRUC = A56ClienteRUC;
            Z57ClienteDsc = A57ClienteDsc;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_5_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0051.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"CLIENTEID"+"'), id:'"+"CLIENTEID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_42_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00y1.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"BODCOD"+"'), id:'"+"BODCOD"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         GXAEMPID_html1293( AV7empid) ;
         if ( ! (0==AV7empid) )
         {
            A1EmpID = AV7empid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         }
         if ( ! (0==AV7empid) )
         {
            dynEmpID.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynEmpID.Enabled), 5, 0)), true);
         }
         else
         {
            dynEmpID.Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynEmpID.Enabled), 5, 0)), true);
         }
         if ( ! (0==AV7empid) )
         {
            dynEmpID.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynEmpID.Enabled), 5, 0)), true);
         }
         GXAAGEID_html1293( AV7empid, AV8ageId) ;
         if ( ! (0==AV8ageId) )
         {
            A2AgeID = AV8ageId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
         }
         if ( ! (0==AV8ageId) )
         {
            dynAgeID.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynAgeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynAgeID.Enabled), 5, 0)), true);
         }
         else
         {
            dynAgeID.Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynAgeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynAgeID.Enabled), 5, 0)), true);
         }
         if ( ! (0==AV8ageId) )
         {
            dynAgeID.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynAgeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynAgeID.Enabled), 5, 0)), true);
         }
         if ( ! (0==AV10DespBodNro) )
         {
            A353DespBodNro = AV10DespBodNro;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A353DespBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A353DespBodNro), 4, 0)));
         }
         if ( ! (0==AV10DespBodNro) )
         {
            edtDespBodNro_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodNro_Enabled), 5, 0)), true);
         }
         else
         {
            edtDespBodNro_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodNro_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV10DespBodNro) )
         {
            edtDespBodNro_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodNro_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV17OrdenID) )
         {
            A22OrdenID = AV17OrdenID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
         }
         if ( ! (0==AV17OrdenID) )
         {
            edtOrdenID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenID_Enabled), 5, 0)), true);
         }
         else
         {
            edtOrdenID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV17OrdenID) )
         {
            edtOrdenID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV21clienteID) )
         {
            A5ClienteID = AV21clienteID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
         }
         if ( ! (0==AV21clienteID) )
         {
            edtClienteID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteID_Enabled), 5, 0)), true);
         }
         else
         {
            edtClienteID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV21clienteID) )
         {
            edtClienteID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteID_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV15Insert_BodCod) )
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV15Insert_BodCod) )
         {
            A42BodCod = AV15Insert_BodCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
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
            /* Using cursor T00126 */
            pr_default.execute(4, new Object[] {A1EmpID});
            A44empdsc = T00126_A44empdsc[0];
            n44empdsc = T00126_n44empdsc[0];
            pr_default.close(4);
            AV23Pgmname = "DespBodega";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23Pgmname", AV23Pgmname);
            /* Using cursor T00127 */
            pr_default.execute(5, new Object[] {A1EmpID, A2AgeID});
            A46AgeDsc = T00127_A46AgeDsc[0];
            n46AgeDsc = T00127_n46AgeDsc[0];
            pr_default.close(5);
            /* Using cursor T00128 */
            pr_default.execute(6, new Object[] {A1EmpID, A5ClienteID});
            A56ClienteRUC = T00128_A56ClienteRUC[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56ClienteRUC", A56ClienteRUC);
            n56ClienteRUC = T00128_n56ClienteRUC[0];
            A57ClienteDsc = T00128_A57ClienteDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A57ClienteDsc", A57ClienteDsc);
            n57ClienteDsc = T00128_n57ClienteDsc[0];
            pr_default.close(6);
            /* Using cursor T00129 */
            pr_default.execute(7, new Object[] {A1EmpID, A42BodCod});
            A217BodDsc = T00129_A217BodDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
            n217BodDsc = T00129_n217BodDsc[0];
            pr_default.close(7);
         }
      }

      protected void Load1293( )
      {
         /* Using cursor T001210 */
         pr_default.execute(8, new Object[] {A1EmpID, A2AgeID, A353DespBodNro, A22OrdenID, A5ClienteID});
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound93 = 1;
            A44empdsc = T001210_A44empdsc[0];
            n44empdsc = T001210_n44empdsc[0];
            A46AgeDsc = T001210_A46AgeDsc[0];
            n46AgeDsc = T001210_n46AgeDsc[0];
            A217BodDsc = T001210_A217BodDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
            n217BodDsc = T001210_n217BodDsc[0];
            A56ClienteRUC = T001210_A56ClienteRUC[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56ClienteRUC", A56ClienteRUC);
            n56ClienteRUC = T001210_n56ClienteRUC[0];
            A57ClienteDsc = T001210_A57ClienteDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A57ClienteDsc", A57ClienteDsc);
            n57ClienteDsc = T001210_n57ClienteDsc[0];
            A399DespBodUltReg = T001210_A399DespBodUltReg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A399DespBodUltReg", StringUtil.LTrim( StringUtil.Str( (decimal)(A399DespBodUltReg), 6, 0)));
            n399DespBodUltReg = T001210_n399DespBodUltReg[0];
            A402DespachadoOK = T001210_A402DespachadoOK[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A402DespachadoOK", A402DespachadoOK);
            n402DespachadoOK = T001210_n402DespachadoOK[0];
            A42BodCod = T001210_A42BodCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
            ZM1293( -31) ;
         }
         pr_default.close(8);
         OnLoadActions1293( ) ;
      }

      protected void OnLoadActions1293( )
      {
         AV23Pgmname = "DespBodega";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23Pgmname", AV23Pgmname);
      }

      protected void CheckExtendedTable1293( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV23Pgmname = "DespBodega";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23Pgmname", AV23Pgmname);
         /* Using cursor T00126 */
         pr_default.execute(4, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = dynEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T00126_A44empdsc[0];
         n44empdsc = T00126_n44empdsc[0];
         pr_default.close(4);
         /* Using cursor T00129 */
         pr_default.execute(7, new Object[] {A1EmpID, A42BodCod});
         if ( (pr_default.getStatus(7) == 101) )
         {
            GX_msglist.addItem("No existe 'Bodegas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = dynEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A217BodDsc = T00129_A217BodDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
         n217BodDsc = T00129_n217BodDsc[0];
         pr_default.close(7);
         /* Using cursor T00127 */
         pr_default.execute(5, new Object[] {A1EmpID, A2AgeID});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No existe 'Agencias'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = dynEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A46AgeDsc = T00127_A46AgeDsc[0];
         n46AgeDsc = T00127_n46AgeDsc[0];
         pr_default.close(5);
         /* Using cursor T00128 */
         pr_default.execute(6, new Object[] {A1EmpID, A5ClienteID});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No existe 'Clientes'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = dynEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A56ClienteRUC = T00128_A56ClienteRUC[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56ClienteRUC", A56ClienteRUC);
         n56ClienteRUC = T00128_n56ClienteRUC[0];
         A57ClienteDsc = T00128_A57ClienteDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A57ClienteDsc", A57ClienteDsc);
         n57ClienteDsc = T00128_n57ClienteDsc[0];
         pr_default.close(6);
      }

      protected void CloseExtendedTableCursors1293( )
      {
         pr_default.close(4);
         pr_default.close(7);
         pr_default.close(5);
         pr_default.close(6);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_32( short A1EmpID )
      {
         /* Using cursor T001211 */
         pr_default.execute(9, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(9) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = dynEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T001211_A44empdsc[0];
         n44empdsc = T001211_n44empdsc[0];
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

      protected void gxLoad_35( short A1EmpID ,
                                short A42BodCod )
      {
         /* Using cursor T001212 */
         pr_default.execute(10, new Object[] {A1EmpID, A42BodCod});
         if ( (pr_default.getStatus(10) == 101) )
         {
            GX_msglist.addItem("No existe 'Bodegas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = dynEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A217BodDsc = T001212_A217BodDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
         n217BodDsc = T001212_n217BodDsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A217BodDsc))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(10) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(10);
      }

      protected void gxLoad_33( short A1EmpID ,
                                short A2AgeID )
      {
         /* Using cursor T001213 */
         pr_default.execute(11, new Object[] {A1EmpID, A2AgeID});
         if ( (pr_default.getStatus(11) == 101) )
         {
            GX_msglist.addItem("No existe 'Agencias'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = dynEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A46AgeDsc = T001213_A46AgeDsc[0];
         n46AgeDsc = T001213_n46AgeDsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A46AgeDsc))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(11) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(11);
      }

      protected void gxLoad_34( short A1EmpID ,
                                short A5ClienteID )
      {
         /* Using cursor T001214 */
         pr_default.execute(12, new Object[] {A1EmpID, A5ClienteID});
         if ( (pr_default.getStatus(12) == 101) )
         {
            GX_msglist.addItem("No existe 'Clientes'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = dynEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A56ClienteRUC = T001214_A56ClienteRUC[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56ClienteRUC", A56ClienteRUC);
         n56ClienteRUC = T001214_n56ClienteRUC[0];
         A57ClienteDsc = T001214_A57ClienteDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A57ClienteDsc", A57ClienteDsc);
         n57ClienteDsc = T001214_n57ClienteDsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A56ClienteRUC))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A57ClienteDsc))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(12) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(12);
      }

      protected void GetKey1293( )
      {
         /* Using cursor T001215 */
         pr_default.execute(13, new Object[] {A1EmpID, A2AgeID, A353DespBodNro, A22OrdenID, A5ClienteID});
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound93 = 1;
         }
         else
         {
            RcdFound93 = 0;
         }
         pr_default.close(13);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00125 */
         pr_default.execute(3, new Object[] {A1EmpID, A2AgeID, A353DespBodNro, A22OrdenID, A5ClienteID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM1293( 31) ;
            RcdFound93 = 1;
            A353DespBodNro = T00125_A353DespBodNro[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A353DespBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A353DespBodNro), 4, 0)));
            A22OrdenID = T00125_A22OrdenID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
            A399DespBodUltReg = T00125_A399DespBodUltReg[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A399DespBodUltReg", StringUtil.LTrim( StringUtil.Str( (decimal)(A399DespBodUltReg), 6, 0)));
            n399DespBodUltReg = T00125_n399DespBodUltReg[0];
            A402DespachadoOK = T00125_A402DespachadoOK[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A402DespachadoOK", A402DespachadoOK);
            n402DespachadoOK = T00125_n402DespachadoOK[0];
            A1EmpID = T00125_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = T00125_A2AgeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A5ClienteID = T00125_A5ClienteID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
            A42BodCod = T00125_A42BodCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z353DespBodNro = A353DespBodNro;
            Z22OrdenID = A22OrdenID;
            Z5ClienteID = A5ClienteID;
            sMode93 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load1293( ) ;
            if ( AnyError == 1 )
            {
               RcdFound93 = 0;
               InitializeNonKey1293( ) ;
            }
            Gx_mode = sMode93;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound93 = 0;
            InitializeNonKey1293( ) ;
            sMode93 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode93;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(3);
      }

      protected void getEqualNoModal( )
      {
         GetKey1293( ) ;
         if ( RcdFound93 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound93 = 0;
         /* Using cursor T001216 */
         pr_default.execute(14, new Object[] {A1EmpID, A2AgeID, A353DespBodNro, A22OrdenID, A5ClienteID});
         if ( (pr_default.getStatus(14) != 101) )
         {
            while ( (pr_default.getStatus(14) != 101) && ( ( T001216_A1EmpID[0] < A1EmpID ) || ( T001216_A1EmpID[0] == A1EmpID ) && ( T001216_A2AgeID[0] < A2AgeID ) || ( T001216_A2AgeID[0] == A2AgeID ) && ( T001216_A1EmpID[0] == A1EmpID ) && ( T001216_A353DespBodNro[0] < A353DespBodNro ) || ( T001216_A353DespBodNro[0] == A353DespBodNro ) && ( T001216_A2AgeID[0] == A2AgeID ) && ( T001216_A1EmpID[0] == A1EmpID ) && ( T001216_A22OrdenID[0] < A22OrdenID ) || ( T001216_A22OrdenID[0] == A22OrdenID ) && ( T001216_A353DespBodNro[0] == A353DespBodNro ) && ( T001216_A2AgeID[0] == A2AgeID ) && ( T001216_A1EmpID[0] == A1EmpID ) && ( T001216_A5ClienteID[0] < A5ClienteID ) ) )
            {
               pr_default.readNext(14);
            }
            if ( (pr_default.getStatus(14) != 101) && ( ( T001216_A1EmpID[0] > A1EmpID ) || ( T001216_A1EmpID[0] == A1EmpID ) && ( T001216_A2AgeID[0] > A2AgeID ) || ( T001216_A2AgeID[0] == A2AgeID ) && ( T001216_A1EmpID[0] == A1EmpID ) && ( T001216_A353DespBodNro[0] > A353DespBodNro ) || ( T001216_A353DespBodNro[0] == A353DespBodNro ) && ( T001216_A2AgeID[0] == A2AgeID ) && ( T001216_A1EmpID[0] == A1EmpID ) && ( T001216_A22OrdenID[0] > A22OrdenID ) || ( T001216_A22OrdenID[0] == A22OrdenID ) && ( T001216_A353DespBodNro[0] == A353DespBodNro ) && ( T001216_A2AgeID[0] == A2AgeID ) && ( T001216_A1EmpID[0] == A1EmpID ) && ( T001216_A5ClienteID[0] > A5ClienteID ) ) )
            {
               A1EmpID = T001216_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A2AgeID = T001216_A2AgeID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
               A353DespBodNro = T001216_A353DespBodNro[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A353DespBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A353DespBodNro), 4, 0)));
               A22OrdenID = T001216_A22OrdenID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
               A5ClienteID = T001216_A5ClienteID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
               RcdFound93 = 1;
            }
         }
         pr_default.close(14);
      }

      protected void move_previous( )
      {
         RcdFound93 = 0;
         /* Using cursor T001217 */
         pr_default.execute(15, new Object[] {A1EmpID, A2AgeID, A353DespBodNro, A22OrdenID, A5ClienteID});
         if ( (pr_default.getStatus(15) != 101) )
         {
            while ( (pr_default.getStatus(15) != 101) && ( ( T001217_A1EmpID[0] > A1EmpID ) || ( T001217_A1EmpID[0] == A1EmpID ) && ( T001217_A2AgeID[0] > A2AgeID ) || ( T001217_A2AgeID[0] == A2AgeID ) && ( T001217_A1EmpID[0] == A1EmpID ) && ( T001217_A353DespBodNro[0] > A353DespBodNro ) || ( T001217_A353DespBodNro[0] == A353DespBodNro ) && ( T001217_A2AgeID[0] == A2AgeID ) && ( T001217_A1EmpID[0] == A1EmpID ) && ( T001217_A22OrdenID[0] > A22OrdenID ) || ( T001217_A22OrdenID[0] == A22OrdenID ) && ( T001217_A353DespBodNro[0] == A353DespBodNro ) && ( T001217_A2AgeID[0] == A2AgeID ) && ( T001217_A1EmpID[0] == A1EmpID ) && ( T001217_A5ClienteID[0] > A5ClienteID ) ) )
            {
               pr_default.readNext(15);
            }
            if ( (pr_default.getStatus(15) != 101) && ( ( T001217_A1EmpID[0] < A1EmpID ) || ( T001217_A1EmpID[0] == A1EmpID ) && ( T001217_A2AgeID[0] < A2AgeID ) || ( T001217_A2AgeID[0] == A2AgeID ) && ( T001217_A1EmpID[0] == A1EmpID ) && ( T001217_A353DespBodNro[0] < A353DespBodNro ) || ( T001217_A353DespBodNro[0] == A353DespBodNro ) && ( T001217_A2AgeID[0] == A2AgeID ) && ( T001217_A1EmpID[0] == A1EmpID ) && ( T001217_A22OrdenID[0] < A22OrdenID ) || ( T001217_A22OrdenID[0] == A22OrdenID ) && ( T001217_A353DespBodNro[0] == A353DespBodNro ) && ( T001217_A2AgeID[0] == A2AgeID ) && ( T001217_A1EmpID[0] == A1EmpID ) && ( T001217_A5ClienteID[0] < A5ClienteID ) ) )
            {
               A1EmpID = T001217_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A2AgeID = T001217_A2AgeID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
               A353DespBodNro = T001217_A353DespBodNro[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A353DespBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A353DespBodNro), 4, 0)));
               A22OrdenID = T001217_A22OrdenID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
               A5ClienteID = T001217_A5ClienteID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
               RcdFound93 = 1;
            }
         }
         pr_default.close(15);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey1293( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = dynEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert1293( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound93 == 1 )
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A353DespBodNro != Z353DespBodNro ) || ( A22OrdenID != Z22OrdenID ) || ( A5ClienteID != Z5ClienteID ) )
               {
                  A1EmpID = Z1EmpID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
                  A2AgeID = Z2AgeID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
                  A353DespBodNro = Z353DespBodNro;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A353DespBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A353DespBodNro), 4, 0)));
                  A22OrdenID = Z22OrdenID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
                  A5ClienteID = Z5ClienteID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
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
                  Update1293( ) ;
                  GX_FocusControl = dynEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A353DespBodNro != Z353DespBodNro ) || ( A22OrdenID != Z22OrdenID ) || ( A5ClienteID != Z5ClienteID ) )
               {
                  /* Insert record */
                  GX_FocusControl = dynEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert1293( ) ;
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
                     Insert1293( ) ;
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
         if ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A353DespBodNro != Z353DespBodNro ) || ( A22OrdenID != Z22OrdenID ) || ( A5ClienteID != Z5ClienteID ) )
         {
            A1EmpID = Z1EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = Z2AgeID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A353DespBodNro = Z353DespBodNro;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A353DespBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A353DespBodNro), 4, 0)));
            A22OrdenID = Z22OrdenID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
            A5ClienteID = Z5ClienteID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
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

      protected void CheckOptimisticConcurrency1293( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00124 */
            pr_default.execute(2, new Object[] {A1EmpID, A2AgeID, A353DespBodNro, A22OrdenID, A5ClienteID});
            if ( (pr_default.getStatus(2) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"DespBodega"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(2) == 101) || ( Z399DespBodUltReg != T00124_A399DespBodUltReg[0] ) || ( StringUtil.StrCmp(Z402DespachadoOK, T00124_A402DespachadoOK[0]) != 0 ) || ( Z42BodCod != T00124_A42BodCod[0] ) )
            {
               if ( Z399DespBodUltReg != T00124_A399DespBodUltReg[0] )
               {
                  GXUtil.WriteLog("despbodega:[seudo value changed for attri]"+"DespBodUltReg");
                  GXUtil.WriteLogRaw("Old: ",Z399DespBodUltReg);
                  GXUtil.WriteLogRaw("Current: ",T00124_A399DespBodUltReg[0]);
               }
               if ( StringUtil.StrCmp(Z402DespachadoOK, T00124_A402DespachadoOK[0]) != 0 )
               {
                  GXUtil.WriteLog("despbodega:[seudo value changed for attri]"+"DespachadoOK");
                  GXUtil.WriteLogRaw("Old: ",Z402DespachadoOK);
                  GXUtil.WriteLogRaw("Current: ",T00124_A402DespachadoOK[0]);
               }
               if ( Z42BodCod != T00124_A42BodCod[0] )
               {
                  GXUtil.WriteLog("despbodega:[seudo value changed for attri]"+"BodCod");
                  GXUtil.WriteLogRaw("Old: ",Z42BodCod);
                  GXUtil.WriteLogRaw("Current: ",T00124_A42BodCod[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"DespBodega"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1293( )
      {
         BeforeValidate1293( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1293( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1293( 0) ;
            CheckOptimisticConcurrency1293( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1293( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1293( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001218 */
                     pr_default.execute(16, new Object[] {A353DespBodNro, A22OrdenID, n399DespBodUltReg, A399DespBodUltReg, n402DespachadoOK, A402DespachadoOK, A1EmpID, A2AgeID, A5ClienteID, A42BodCod});
                     pr_default.close(16);
                     dsDefault.SmartCacheProvider.SetUpdated("DespBodega") ;
                     if ( (pr_default.getStatus(16) == 1) )
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
                           ProcessLevel1293( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption120( ) ;
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
               Load1293( ) ;
            }
            EndLevel1293( ) ;
         }
         CloseExtendedTableCursors1293( ) ;
      }

      protected void Update1293( )
      {
         BeforeValidate1293( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1293( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1293( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1293( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1293( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001219 */
                     pr_default.execute(17, new Object[] {n399DespBodUltReg, A399DespBodUltReg, n402DespachadoOK, A402DespachadoOK, A42BodCod, A1EmpID, A2AgeID, A353DespBodNro, A22OrdenID, A5ClienteID});
                     pr_default.close(17);
                     dsDefault.SmartCacheProvider.SetUpdated("DespBodega") ;
                     if ( (pr_default.getStatus(17) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"DespBodega"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1293( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel1293( ) ;
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
            EndLevel1293( ) ;
         }
         CloseExtendedTableCursors1293( ) ;
      }

      protected void DeferredUpdate1293( )
      {
      }

      protected void delete( )
      {
         BeforeValidate1293( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1293( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1293( ) ;
            AfterConfirm1293( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1293( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart1294( ) ;
                  while ( RcdFound94 != 0 )
                  {
                     getByPrimaryKey1294( ) ;
                     Delete1294( ) ;
                     ScanNext1294( ) ;
                  }
                  ScanEnd1294( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001220 */
                     pr_default.execute(18, new Object[] {A1EmpID, A2AgeID, A353DespBodNro, A22OrdenID, A5ClienteID});
                     pr_default.close(18);
                     dsDefault.SmartCacheProvider.SetUpdated("DespBodega") ;
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
         sMode93 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel1293( ) ;
         Gx_mode = sMode93;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls1293( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV23Pgmname = "DespBodega";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23Pgmname", AV23Pgmname);
            /* Using cursor T001221 */
            pr_default.execute(19, new Object[] {A1EmpID});
            A44empdsc = T001221_A44empdsc[0];
            n44empdsc = T001221_n44empdsc[0];
            pr_default.close(19);
            /* Using cursor T001222 */
            pr_default.execute(20, new Object[] {A1EmpID, A2AgeID});
            A46AgeDsc = T001222_A46AgeDsc[0];
            n46AgeDsc = T001222_n46AgeDsc[0];
            pr_default.close(20);
            /* Using cursor T001223 */
            pr_default.execute(21, new Object[] {A1EmpID, A42BodCod});
            A217BodDsc = T001223_A217BodDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
            n217BodDsc = T001223_n217BodDsc[0];
            pr_default.close(21);
            /* Using cursor T001224 */
            pr_default.execute(22, new Object[] {A1EmpID, A5ClienteID});
            A56ClienteRUC = T001224_A56ClienteRUC[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56ClienteRUC", A56ClienteRUC);
            n56ClienteRUC = T001224_n56ClienteRUC[0];
            A57ClienteDsc = T001224_A57ClienteDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A57ClienteDsc", A57ClienteDsc);
            n57ClienteDsc = T001224_n57ClienteDsc[0];
            pr_default.close(22);
         }
      }

      protected void ProcessNestedLevel1294( )
      {
         nGXsfl_108_idx = 0;
         while ( nGXsfl_108_idx < nRC_GXsfl_108 )
         {
            ReadRow1294( ) ;
            if ( ( nRcdExists_94 != 0 ) || ( nIsMod_94 != 0 ) )
            {
               standaloneNotModal1294( ) ;
               GetKey1294( ) ;
               if ( ( nRcdExists_94 == 0 ) && ( nRcdDeleted_94 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert1294( ) ;
               }
               else
               {
                  if ( RcdFound94 != 0 )
                  {
                     if ( ( nRcdDeleted_94 != 0 ) && ( nRcdExists_94 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete1294( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_94 != 0 ) && ( nRcdExists_94 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update1294( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_94 == 0 )
                     {
                        GXCCtl = "NROREG_" + sGXsfl_108_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtnroReg_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtnroReg_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A400nroReg), 6, 0, ",", ""))) ;
            ChangePostValue( edtDespBodCodPrd_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A355DespBodCodPrd), 4, 0, ",", ""))) ;
            ChangePostValue( edtDespBodPrdNombre_Internalname, StringUtil.RTrim( A356DespBodPrdNombre)) ;
            ChangePostValue( edtDespBodCant_Internalname, StringUtil.LTrim( StringUtil.NToC( A357DespBodCant, 8, 2, ",", ""))) ;
            ChangePostValue( edtDespBodValor_Internalname, StringUtil.LTrim( StringUtil.NToC( A358DespBodValor, 8, 2, ",", ""))) ;
            ChangePostValue( edtDespBodADesp_Internalname, StringUtil.LTrim( StringUtil.NToC( A359DespBodADesp, 8, 2, ",", ""))) ;
            ChangePostValue( edtDespBodDetalle_Internalname, StringUtil.RTrim( A376DespBodDetalle)) ;
            ChangePostValue( edtDespBodStock_Internalname, StringUtil.LTrim( StringUtil.NToC( A360DespBodStock, 6, 2, ",", ""))) ;
            ChangePostValue( edtDespBodCatId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A361DespBodCatId), 4, 0, ",", ""))) ;
            ChangePostValue( edtDespBodDif_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A362DespBodDif), 4, 0, ",", ""))) ;
            ChangePostValue( chkDespBodModifItem_Internalname, ((StringUtil.StrCmp(A403DespBodModifItem, "N")==0) ? "N" : "S")) ;
            ChangePostValue( edtavDespachado_Internalname, AV19despachado) ;
            ChangePostValue( edtDespBodOK_Internalname, StringUtil.RTrim( A392DespBodOK)) ;
            ChangePostValue( "ZT_"+"Z400nroReg_"+sGXsfl_108_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z400nroReg), 6, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z355DespBodCodPrd_"+sGXsfl_108_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z355DespBodCodPrd), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z356DespBodPrdNombre_"+sGXsfl_108_idx, StringUtil.RTrim( Z356DespBodPrdNombre)) ;
            ChangePostValue( "ZT_"+"Z357DespBodCant_"+sGXsfl_108_idx, StringUtil.LTrim( StringUtil.NToC( Z357DespBodCant, 8, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z358DespBodValor_"+sGXsfl_108_idx, StringUtil.LTrim( StringUtil.NToC( Z358DespBodValor, 8, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z359DespBodADesp_"+sGXsfl_108_idx, StringUtil.LTrim( StringUtil.NToC( Z359DespBodADesp, 8, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z376DespBodDetalle_"+sGXsfl_108_idx, StringUtil.RTrim( Z376DespBodDetalle)) ;
            ChangePostValue( "ZT_"+"Z361DespBodCatId_"+sGXsfl_108_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z361DespBodCatId), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z392DespBodOK_"+sGXsfl_108_idx, StringUtil.RTrim( Z392DespBodOK)) ;
            ChangePostValue( "ZT_"+"Z403DespBodModifItem_"+sGXsfl_108_idx, StringUtil.RTrim( Z403DespBodModifItem)) ;
            ChangePostValue( "nRcdDeleted_94_"+sGXsfl_108_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_94), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_94_"+sGXsfl_108_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_94), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_94_"+sGXsfl_108_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_94), 4, 0, ",", ""))) ;
            if ( nIsMod_94 != 0 )
            {
               ChangePostValue( "NROREG_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtnroReg_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DESPBODCODPRD_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodCodPrd_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DESPBODPRDNOMBRE_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodPrdNombre_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DESPBODCANT_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodCant_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DESPBODVALOR_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodValor_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DESPBODADESP_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodADesp_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DESPBODDETALLE_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodDetalle_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DESPBODSTOCK_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodStock_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DESPBODCATID_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodCatId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DESPBODDIF_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodDif_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DESPBODMODIFITEM_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkDespBodModifItem.Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "vDESPACHADO_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDespachado_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "vDESPACHADO_"+sGXsfl_108_idx+"Tooltiptext", StringUtil.RTrim( edtavDespachado_Tooltiptext)) ;
               ChangePostValue( "vDESPACHADO_"+sGXsfl_108_idx+"Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDespachado_Visible), 5, 0, ".", ""))) ;
               ChangePostValue( "DESPBODOK_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodOK_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll1294( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_94 = 0;
         nIsMod_94 = 0;
         nRcdDeleted_94 = 0;
      }

      protected void ProcessLevel1293( )
      {
         /* Save parent mode. */
         sMode93 = Gx_mode;
         ProcessNestedLevel1294( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode93;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         /* ' Update level parameters */
      }

      protected void EndLevel1293( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(2);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1293( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(3);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(19);
            pr_default.close(20);
            pr_default.close(22);
            pr_default.close(21);
            context.CommitDataStores("despbodega",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues120( ) ;
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
            pr_default.close(19);
            pr_default.close(20);
            pr_default.close(22);
            pr_default.close(21);
            context.RollbackDataStores("despbodega",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart1293( )
      {
         /* Scan By routine */
         /* Using cursor T001225 */
         pr_default.execute(23);
         RcdFound93 = 0;
         if ( (pr_default.getStatus(23) != 101) )
         {
            RcdFound93 = 1;
            A1EmpID = T001225_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = T001225_A2AgeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A353DespBodNro = T001225_A353DespBodNro[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A353DespBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A353DespBodNro), 4, 0)));
            A22OrdenID = T001225_A22OrdenID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
            A5ClienteID = T001225_A5ClienteID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1293( )
      {
         /* Scan next routine */
         pr_default.readNext(23);
         RcdFound93 = 0;
         if ( (pr_default.getStatus(23) != 101) )
         {
            RcdFound93 = 1;
            A1EmpID = T001225_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = T001225_A2AgeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A353DespBodNro = T001225_A353DespBodNro[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A353DespBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A353DespBodNro), 4, 0)));
            A22OrdenID = T001225_A22OrdenID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
            A5ClienteID = T001225_A5ClienteID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
         }
      }

      protected void ScanEnd1293( )
      {
         pr_default.close(23);
      }

      protected void AfterConfirm1293( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1293( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1293( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1293( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1293( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1293( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1293( )
      {
         dynEmpID.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynEmpID.Enabled), 5, 0)), true);
         dynAgeID.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynAgeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynAgeID.Enabled), 5, 0)), true);
         edtOrdenID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenID_Enabled), 5, 0)), true);
         edtDespBodNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodNro_Enabled), 5, 0)), true);
         edtClienteID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteID_Enabled), 5, 0)), true);
         edtClienteRUC_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteRUC_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteRUC_Enabled), 5, 0)), true);
         edtClienteDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteDsc_Enabled), 5, 0)), true);
         edtBodCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodCod_Enabled), 5, 0)), true);
         edtBodDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodDsc_Enabled), 5, 0)), true);
         chkDespachadoOK.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkDespachadoOK_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkDespachadoOK.Enabled), 5, 0)), true);
         edtDespBodUltReg_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodUltReg_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodUltReg_Enabled), 5, 0)), true);
      }

      protected void ZM1294( short GX_JID )
      {
         if ( ( GX_JID == 36 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z355DespBodCodPrd = T00123_A355DespBodCodPrd[0];
               Z356DespBodPrdNombre = T00123_A356DespBodPrdNombre[0];
               Z357DespBodCant = T00123_A357DespBodCant[0];
               Z358DespBodValor = T00123_A358DespBodValor[0];
               Z359DespBodADesp = T00123_A359DespBodADesp[0];
               Z376DespBodDetalle = T00123_A376DespBodDetalle[0];
               Z361DespBodCatId = T00123_A361DespBodCatId[0];
               Z392DespBodOK = T00123_A392DespBodOK[0];
               Z403DespBodModifItem = T00123_A403DespBodModifItem[0];
            }
            else
            {
               Z355DespBodCodPrd = A355DespBodCodPrd;
               Z356DespBodPrdNombre = A356DespBodPrdNombre;
               Z357DespBodCant = A357DespBodCant;
               Z358DespBodValor = A358DespBodValor;
               Z359DespBodADesp = A359DespBodADesp;
               Z376DespBodDetalle = A376DespBodDetalle;
               Z361DespBodCatId = A361DespBodCatId;
               Z392DespBodOK = A392DespBodOK;
               Z403DespBodModifItem = A403DespBodModifItem;
            }
         }
         if ( GX_JID == -36 )
         {
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z353DespBodNro = A353DespBodNro;
            Z22OrdenID = A22OrdenID;
            Z5ClienteID = A5ClienteID;
            Z400nroReg = A400nroReg;
            Z355DespBodCodPrd = A355DespBodCodPrd;
            Z356DespBodPrdNombre = A356DespBodPrdNombre;
            Z357DespBodCant = A357DespBodCant;
            Z358DespBodValor = A358DespBodValor;
            Z359DespBodADesp = A359DespBodADesp;
            Z376DespBodDetalle = A376DespBodDetalle;
            Z361DespBodCatId = A361DespBodCatId;
            Z392DespBodOK = A392DespBodOK;
            Z403DespBodModifItem = A403DespBodModifItem;
         }
      }

      protected void standaloneNotModal1294( )
      {
         edtDespBodPrdNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodPrdNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodPrdNombre_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
         edtDespBodCant_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodCant_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodCant_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
         edtDespBodValor_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodValor_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodValor_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
         edtDespBodDetalle_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodDetalle_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodDetalle_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
         edtDespBodCatId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodCatId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodCatId_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
         edtDespBodOK_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodOK_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodOK_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
      }

      protected void standaloneModal1294( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtnroReg_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtnroReg_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtnroReg_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
         }
         else
         {
            edtnroReg_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtnroReg_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtnroReg_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
         }
      }

      protected void Load1294( )
      {
         /* Using cursor T001226 */
         pr_default.execute(24, new Object[] {A1EmpID, A2AgeID, A353DespBodNro, A22OrdenID, A5ClienteID, A400nroReg});
         if ( (pr_default.getStatus(24) != 101) )
         {
            RcdFound94 = 1;
            A355DespBodCodPrd = T001226_A355DespBodCodPrd[0];
            n355DespBodCodPrd = T001226_n355DespBodCodPrd[0];
            A356DespBodPrdNombre = T001226_A356DespBodPrdNombre[0];
            n356DespBodPrdNombre = T001226_n356DespBodPrdNombre[0];
            A357DespBodCant = T001226_A357DespBodCant[0];
            n357DespBodCant = T001226_n357DespBodCant[0];
            A358DespBodValor = T001226_A358DespBodValor[0];
            n358DespBodValor = T001226_n358DespBodValor[0];
            A359DespBodADesp = T001226_A359DespBodADesp[0];
            n359DespBodADesp = T001226_n359DespBodADesp[0];
            A376DespBodDetalle = T001226_A376DespBodDetalle[0];
            n376DespBodDetalle = T001226_n376DespBodDetalle[0];
            A361DespBodCatId = T001226_A361DespBodCatId[0];
            n361DespBodCatId = T001226_n361DespBodCatId[0];
            A392DespBodOK = T001226_A392DespBodOK[0];
            n392DespBodOK = T001226_n392DespBodOK[0];
            A403DespBodModifItem = T001226_A403DespBodModifItem[0];
            n403DespBodModifItem = T001226_n403DespBodModifItem[0];
            ZM1294( -36) ;
         }
         pr_default.close(24);
         OnLoadActions1294( ) ;
      }

      protected void OnLoadActions1294( )
      {
         GXt_decimal1 = A360DespBodStock;
         new prcbusstock(context ).execute(  (short)(DateTimeUtil.Year( DateTimeUtil.ServerNow( context, pr_default))),  (short)(DateTimeUtil.Month( DateTimeUtil.ServerNow( context, pr_default))),  A1EmpID,  A2AgeID,  A42BodCod,  A355DespBodCodPrd, out  GXt_decimal1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
         A360DespBodStock = GXt_decimal1;
         A362DespBodDif = (short)((A357DespBodCant-A359DespBodADesp));
      }

      protected void CheckExtendedTable1294( )
      {
         Gx_BScreen = 1;
         standaloneModal1294( ) ;
         GXt_decimal1 = A360DespBodStock;
         new prcbusstock(context ).execute(  (short)(DateTimeUtil.Year( DateTimeUtil.ServerNow( context, pr_default))),  (short)(DateTimeUtil.Month( DateTimeUtil.ServerNow( context, pr_default))),  A1EmpID,  A2AgeID,  A42BodCod,  A355DespBodCodPrd, out  GXt_decimal1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
         A360DespBodStock = GXt_decimal1;
         A362DespBodDif = (short)((A357DespBodCant-A359DespBodADesp));
      }

      protected void CloseExtendedTableCursors1294( )
      {
      }

      protected void enableDisable1294( )
      {
      }

      protected void GetKey1294( )
      {
         /* Using cursor T001227 */
         pr_default.execute(25, new Object[] {A1EmpID, A2AgeID, A353DespBodNro, A22OrdenID, A5ClienteID, A400nroReg});
         if ( (pr_default.getStatus(25) != 101) )
         {
            RcdFound94 = 1;
         }
         else
         {
            RcdFound94 = 0;
         }
         pr_default.close(25);
      }

      protected void getByPrimaryKey1294( )
      {
         /* Using cursor T00123 */
         pr_default.execute(1, new Object[] {A1EmpID, A2AgeID, A353DespBodNro, A22OrdenID, A5ClienteID, A400nroReg});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1294( 36) ;
            RcdFound94 = 1;
            InitializeNonKey1294( ) ;
            A400nroReg = T00123_A400nroReg[0];
            A355DespBodCodPrd = T00123_A355DespBodCodPrd[0];
            n355DespBodCodPrd = T00123_n355DespBodCodPrd[0];
            A356DespBodPrdNombre = T00123_A356DespBodPrdNombre[0];
            n356DespBodPrdNombre = T00123_n356DespBodPrdNombre[0];
            A357DespBodCant = T00123_A357DespBodCant[0];
            n357DespBodCant = T00123_n357DespBodCant[0];
            A358DespBodValor = T00123_A358DespBodValor[0];
            n358DespBodValor = T00123_n358DespBodValor[0];
            A359DespBodADesp = T00123_A359DespBodADesp[0];
            n359DespBodADesp = T00123_n359DespBodADesp[0];
            A376DespBodDetalle = T00123_A376DespBodDetalle[0];
            n376DespBodDetalle = T00123_n376DespBodDetalle[0];
            A361DespBodCatId = T00123_A361DespBodCatId[0];
            n361DespBodCatId = T00123_n361DespBodCatId[0];
            A392DespBodOK = T00123_A392DespBodOK[0];
            n392DespBodOK = T00123_n392DespBodOK[0];
            A403DespBodModifItem = T00123_A403DespBodModifItem[0];
            n403DespBodModifItem = T00123_n403DespBodModifItem[0];
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z353DespBodNro = A353DespBodNro;
            Z22OrdenID = A22OrdenID;
            Z5ClienteID = A5ClienteID;
            Z400nroReg = A400nroReg;
            sMode94 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load1294( ) ;
            Gx_mode = sMode94;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound94 = 0;
            InitializeNonKey1294( ) ;
            sMode94 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal1294( ) ;
            Gx_mode = sMode94;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes1294( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency1294( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00122 */
            pr_default.execute(0, new Object[] {A1EmpID, A2AgeID, A353DespBodNro, A22OrdenID, A5ClienteID, A400nroReg});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"DespBodegaprd"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( Z355DespBodCodPrd != T00122_A355DespBodCodPrd[0] ) || ( StringUtil.StrCmp(Z356DespBodPrdNombre, T00122_A356DespBodPrdNombre[0]) != 0 ) || ( Z357DespBodCant != T00122_A357DespBodCant[0] ) || ( Z358DespBodValor != T00122_A358DespBodValor[0] ) || ( Z359DespBodADesp != T00122_A359DespBodADesp[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z376DespBodDetalle, T00122_A376DespBodDetalle[0]) != 0 ) || ( Z361DespBodCatId != T00122_A361DespBodCatId[0] ) || ( StringUtil.StrCmp(Z392DespBodOK, T00122_A392DespBodOK[0]) != 0 ) || ( StringUtil.StrCmp(Z403DespBodModifItem, T00122_A403DespBodModifItem[0]) != 0 ) )
            {
               if ( Z355DespBodCodPrd != T00122_A355DespBodCodPrd[0] )
               {
                  GXUtil.WriteLog("despbodega:[seudo value changed for attri]"+"DespBodCodPrd");
                  GXUtil.WriteLogRaw("Old: ",Z355DespBodCodPrd);
                  GXUtil.WriteLogRaw("Current: ",T00122_A355DespBodCodPrd[0]);
               }
               if ( StringUtil.StrCmp(Z356DespBodPrdNombre, T00122_A356DespBodPrdNombre[0]) != 0 )
               {
                  GXUtil.WriteLog("despbodega:[seudo value changed for attri]"+"DespBodPrdNombre");
                  GXUtil.WriteLogRaw("Old: ",Z356DespBodPrdNombre);
                  GXUtil.WriteLogRaw("Current: ",T00122_A356DespBodPrdNombre[0]);
               }
               if ( Z357DespBodCant != T00122_A357DespBodCant[0] )
               {
                  GXUtil.WriteLog("despbodega:[seudo value changed for attri]"+"DespBodCant");
                  GXUtil.WriteLogRaw("Old: ",Z357DespBodCant);
                  GXUtil.WriteLogRaw("Current: ",T00122_A357DespBodCant[0]);
               }
               if ( Z358DespBodValor != T00122_A358DespBodValor[0] )
               {
                  GXUtil.WriteLog("despbodega:[seudo value changed for attri]"+"DespBodValor");
                  GXUtil.WriteLogRaw("Old: ",Z358DespBodValor);
                  GXUtil.WriteLogRaw("Current: ",T00122_A358DespBodValor[0]);
               }
               if ( Z359DespBodADesp != T00122_A359DespBodADesp[0] )
               {
                  GXUtil.WriteLog("despbodega:[seudo value changed for attri]"+"DespBodADesp");
                  GXUtil.WriteLogRaw("Old: ",Z359DespBodADesp);
                  GXUtil.WriteLogRaw("Current: ",T00122_A359DespBodADesp[0]);
               }
               if ( StringUtil.StrCmp(Z376DespBodDetalle, T00122_A376DespBodDetalle[0]) != 0 )
               {
                  GXUtil.WriteLog("despbodega:[seudo value changed for attri]"+"DespBodDetalle");
                  GXUtil.WriteLogRaw("Old: ",Z376DespBodDetalle);
                  GXUtil.WriteLogRaw("Current: ",T00122_A376DespBodDetalle[0]);
               }
               if ( Z361DespBodCatId != T00122_A361DespBodCatId[0] )
               {
                  GXUtil.WriteLog("despbodega:[seudo value changed for attri]"+"DespBodCatId");
                  GXUtil.WriteLogRaw("Old: ",Z361DespBodCatId);
                  GXUtil.WriteLogRaw("Current: ",T00122_A361DespBodCatId[0]);
               }
               if ( StringUtil.StrCmp(Z392DespBodOK, T00122_A392DespBodOK[0]) != 0 )
               {
                  GXUtil.WriteLog("despbodega:[seudo value changed for attri]"+"DespBodOK");
                  GXUtil.WriteLogRaw("Old: ",Z392DespBodOK);
                  GXUtil.WriteLogRaw("Current: ",T00122_A392DespBodOK[0]);
               }
               if ( StringUtil.StrCmp(Z403DespBodModifItem, T00122_A403DespBodModifItem[0]) != 0 )
               {
                  GXUtil.WriteLog("despbodega:[seudo value changed for attri]"+"DespBodModifItem");
                  GXUtil.WriteLogRaw("Old: ",Z403DespBodModifItem);
                  GXUtil.WriteLogRaw("Current: ",T00122_A403DespBodModifItem[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"DespBodegaprd"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1294( )
      {
         BeforeValidate1294( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1294( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1294( 0) ;
            CheckOptimisticConcurrency1294( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1294( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1294( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001228 */
                     pr_default.execute(26, new Object[] {A1EmpID, A2AgeID, A353DespBodNro, A22OrdenID, A5ClienteID, A400nroReg, n355DespBodCodPrd, A355DespBodCodPrd, n356DespBodPrdNombre, A356DespBodPrdNombre, n357DespBodCant, A357DespBodCant, n358DespBodValor, A358DespBodValor, n359DespBodADesp, A359DespBodADesp, n376DespBodDetalle, A376DespBodDetalle, n361DespBodCatId, A361DespBodCatId, n392DespBodOK, A392DespBodOK, n403DespBodModifItem, A403DespBodModifItem});
                     pr_default.close(26);
                     dsDefault.SmartCacheProvider.SetUpdated("DespBodegaprd") ;
                     if ( (pr_default.getStatus(26) == 1) )
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
               Load1294( ) ;
            }
            EndLevel1294( ) ;
         }
         CloseExtendedTableCursors1294( ) ;
      }

      protected void Update1294( )
      {
         BeforeValidate1294( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1294( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1294( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1294( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1294( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001229 */
                     pr_default.execute(27, new Object[] {n355DespBodCodPrd, A355DespBodCodPrd, n356DespBodPrdNombre, A356DespBodPrdNombre, n357DespBodCant, A357DespBodCant, n358DespBodValor, A358DespBodValor, n359DespBodADesp, A359DespBodADesp, n376DespBodDetalle, A376DespBodDetalle, n361DespBodCatId, A361DespBodCatId, n392DespBodOK, A392DespBodOK, n403DespBodModifItem, A403DespBodModifItem, A1EmpID, A2AgeID, A353DespBodNro, A22OrdenID, A5ClienteID, A400nroReg});
                     pr_default.close(27);
                     dsDefault.SmartCacheProvider.SetUpdated("DespBodegaprd") ;
                     if ( (pr_default.getStatus(27) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"DespBodegaprd"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1294( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey1294( ) ;
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
            EndLevel1294( ) ;
         }
         CloseExtendedTableCursors1294( ) ;
      }

      protected void DeferredUpdate1294( )
      {
      }

      protected void Delete1294( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate1294( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1294( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1294( ) ;
            AfterConfirm1294( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1294( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001230 */
                  pr_default.execute(28, new Object[] {A1EmpID, A2AgeID, A353DespBodNro, A22OrdenID, A5ClienteID, A400nroReg});
                  pr_default.close(28);
                  dsDefault.SmartCacheProvider.SetUpdated("DespBodegaprd") ;
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
         sMode94 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel1294( ) ;
         Gx_mode = sMode94;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls1294( )
      {
         standaloneModal1294( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            GXt_decimal1 = A360DespBodStock;
            new prcbusstock(context ).execute(  (short)(DateTimeUtil.Year( DateTimeUtil.ServerNow( context, pr_default))),  (short)(DateTimeUtil.Month( DateTimeUtil.ServerNow( context, pr_default))),  A1EmpID,  A2AgeID,  A42BodCod,  A355DespBodCodPrd, out  GXt_decimal1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
            A360DespBodStock = GXt_decimal1;
            A362DespBodDif = (short)((A357DespBodCant-A359DespBodADesp));
         }
      }

      protected void EndLevel1294( )
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

      public void ScanStart1294( )
      {
         /* Scan By routine */
         /* Using cursor T001231 */
         pr_default.execute(29, new Object[] {A1EmpID, A2AgeID, A353DespBodNro, A22OrdenID, A5ClienteID});
         RcdFound94 = 0;
         if ( (pr_default.getStatus(29) != 101) )
         {
            RcdFound94 = 1;
            A400nroReg = T001231_A400nroReg[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1294( )
      {
         /* Scan next routine */
         pr_default.readNext(29);
         RcdFound94 = 0;
         if ( (pr_default.getStatus(29) != 101) )
         {
            RcdFound94 = 1;
            A400nroReg = T001231_A400nroReg[0];
         }
      }

      protected void ScanEnd1294( )
      {
         pr_default.close(29);
      }

      protected void AfterConfirm1294( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1294( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1294( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1294( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1294( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1294( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1294( )
      {
         edtnroReg_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtnroReg_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtnroReg_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
         edtDespBodCodPrd_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodCodPrd_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodCodPrd_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
         edtDespBodPrdNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodPrdNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodPrdNombre_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
         edtDespBodCant_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodCant_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodCant_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
         edtDespBodValor_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodValor_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodValor_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
         edtDespBodADesp_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodADesp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodADesp_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
         edtDespBodDetalle_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodDetalle_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodDetalle_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
         edtDespBodStock_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodStock_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodStock_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
         edtDespBodCatId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodCatId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodCatId_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
         edtDespBodDif_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodDif_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodDif_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
         chkDespBodModifItem.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkDespBodModifItem_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkDespBodModifItem.Enabled), 5, 0)), !bGXsfl_108_Refreshing);
         edtDespBodOK_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodOK_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodOK_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
      }

      protected void send_integrity_lvl_hashes1294( )
      {
      }

      protected void send_integrity_lvl_hashes1293( )
      {
      }

      protected void SubsflControlProps_10894( )
      {
         edtnroReg_Internalname = "NROREG_"+sGXsfl_108_idx;
         edtDespBodCodPrd_Internalname = "DESPBODCODPRD_"+sGXsfl_108_idx;
         edtDespBodPrdNombre_Internalname = "DESPBODPRDNOMBRE_"+sGXsfl_108_idx;
         edtDespBodCant_Internalname = "DESPBODCANT_"+sGXsfl_108_idx;
         edtDespBodValor_Internalname = "DESPBODVALOR_"+sGXsfl_108_idx;
         edtDespBodADesp_Internalname = "DESPBODADESP_"+sGXsfl_108_idx;
         edtDespBodDetalle_Internalname = "DESPBODDETALLE_"+sGXsfl_108_idx;
         edtDespBodStock_Internalname = "DESPBODSTOCK_"+sGXsfl_108_idx;
         edtDespBodCatId_Internalname = "DESPBODCATID_"+sGXsfl_108_idx;
         edtDespBodDif_Internalname = "DESPBODDIF_"+sGXsfl_108_idx;
         chkDespBodModifItem_Internalname = "DESPBODMODIFITEM_"+sGXsfl_108_idx;
         edtavDespachado_Internalname = "vDESPACHADO_"+sGXsfl_108_idx;
         edtDespBodOK_Internalname = "DESPBODOK_"+sGXsfl_108_idx;
      }

      protected void SubsflControlProps_fel_10894( )
      {
         edtnroReg_Internalname = "NROREG_"+sGXsfl_108_fel_idx;
         edtDespBodCodPrd_Internalname = "DESPBODCODPRD_"+sGXsfl_108_fel_idx;
         edtDespBodPrdNombre_Internalname = "DESPBODPRDNOMBRE_"+sGXsfl_108_fel_idx;
         edtDespBodCant_Internalname = "DESPBODCANT_"+sGXsfl_108_fel_idx;
         edtDespBodValor_Internalname = "DESPBODVALOR_"+sGXsfl_108_fel_idx;
         edtDespBodADesp_Internalname = "DESPBODADESP_"+sGXsfl_108_fel_idx;
         edtDespBodDetalle_Internalname = "DESPBODDETALLE_"+sGXsfl_108_fel_idx;
         edtDespBodStock_Internalname = "DESPBODSTOCK_"+sGXsfl_108_fel_idx;
         edtDespBodCatId_Internalname = "DESPBODCATID_"+sGXsfl_108_fel_idx;
         edtDespBodDif_Internalname = "DESPBODDIF_"+sGXsfl_108_fel_idx;
         chkDespBodModifItem_Internalname = "DESPBODMODIFITEM_"+sGXsfl_108_fel_idx;
         edtavDespachado_Internalname = "vDESPACHADO_"+sGXsfl_108_fel_idx;
         edtDespBodOK_Internalname = "DESPBODOK_"+sGXsfl_108_fel_idx;
      }

      protected void AddRow1294( )
      {
         nGXsfl_108_idx = (short)(nGXsfl_108_idx+1);
         sGXsfl_108_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_108_idx), 4, 0)), 4, "0");
         SubsflControlProps_10894( ) ;
         SendRow1294( ) ;
      }

      protected void SendRow1294( )
      {
         Griddespbodega_prdRow = GXWebRow.GetNew(context);
         if ( subGriddespbodega_prd_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGriddespbodega_prd_Backstyle = 0;
            if ( StringUtil.StrCmp(subGriddespbodega_prd_Class, "") != 0 )
            {
               subGriddespbodega_prd_Linesclass = subGriddespbodega_prd_Class+"Odd";
            }
         }
         else if ( subGriddespbodega_prd_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGriddespbodega_prd_Backstyle = 0;
            subGriddespbodega_prd_Backcolor = subGriddespbodega_prd_Allbackcolor;
            if ( StringUtil.StrCmp(subGriddespbodega_prd_Class, "") != 0 )
            {
               subGriddespbodega_prd_Linesclass = subGriddespbodega_prd_Class+"Uniform";
            }
         }
         else if ( subGriddespbodega_prd_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGriddespbodega_prd_Backstyle = 1;
            if ( StringUtil.StrCmp(subGriddespbodega_prd_Class, "") != 0 )
            {
               subGriddespbodega_prd_Linesclass = subGriddespbodega_prd_Class+"Odd";
            }
            subGriddespbodega_prd_Backcolor = (int)(0x0);
         }
         else if ( subGriddespbodega_prd_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGriddespbodega_prd_Backstyle = 1;
            if ( ((int)(((nGXsfl_108_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGriddespbodega_prd_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGriddespbodega_prd_Class, "") != 0 )
               {
                  subGriddespbodega_prd_Linesclass = subGriddespbodega_prd_Class+"Odd";
               }
            }
            else
            {
               subGriddespbodega_prd_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGriddespbodega_prd_Class, "") != 0 )
               {
                  subGriddespbodega_prd_Linesclass = subGriddespbodega_prd_Class+"Even";
               }
            }
         }
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_94_" + sGXsfl_108_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 109,'',false,'" + sGXsfl_108_idx + "',108)\"";
         ROClassString = "Attribute";
         Griddespbodega_prdRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtnroReg_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A400nroReg), 6, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A400nroReg), "ZZZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,109);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtnroReg_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtnroReg_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)6,(short)0,(short)0,(short)108,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_94_" + sGXsfl_108_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 110,'',false,'" + sGXsfl_108_idx + "',108)\"";
         ROClassString = "Attribute";
         Griddespbodega_prdRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodCodPrd_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A355DespBodCodPrd), 4, 0, ",", "")),((edtDespBodCodPrd_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A355DespBodCodPrd), "ZZZ9")) : context.localUtil.Format( (decimal)(A355DespBodCodPrd), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,110);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodCodPrd_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtDespBodCodPrd_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)108,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Griddespbodega_prdRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodPrdNombre_Internalname,StringUtil.RTrim( A356DespBodPrdNombre),StringUtil.RTrim( context.localUtil.Format( A356DespBodPrdNombre, "@!")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodPrdNombre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtDespBodPrdNombre_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)108,(short)1,(short)-1,(short)-1,(bool)true,(String)"nombres",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Griddespbodega_prdRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodCant_Internalname,StringUtil.LTrim( StringUtil.NToC( A357DespBodCant, 8, 2, ",", "")),((edtDespBodCant_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A357DespBodCant, "ZZZZ9.99")) : context.localUtil.Format( A357DespBodCant, "ZZZZ9.99")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodCant_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtDespBodCant_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)108,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Griddespbodega_prdRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodValor_Internalname,StringUtil.LTrim( StringUtil.NToC( A358DespBodValor, 8, 2, ",", "")),((edtDespBodValor_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A358DespBodValor, "ZZZZ9.99")) : context.localUtil.Format( A358DespBodValor, "ZZZZ9.99")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodValor_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtDespBodValor_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)108,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_94_" + sGXsfl_108_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 114,'',false,'" + sGXsfl_108_idx + "',108)\"";
         ROClassString = "Attribute";
         Griddespbodega_prdRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodADesp_Internalname,StringUtil.LTrim( StringUtil.NToC( A359DespBodADesp, 8, 2, ",", "")),((edtDespBodADesp_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A359DespBodADesp, "ZZZZ9.99")) : context.localUtil.Format( A359DespBodADesp, "ZZZZ9.99")),TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,114);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodADesp_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtDespBodADesp_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)108,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Griddespbodega_prdRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodDetalle_Internalname,StringUtil.RTrim( A376DespBodDetalle),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodDetalle_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtDespBodDetalle_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)108,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Griddespbodega_prdRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodStock_Internalname,StringUtil.LTrim( StringUtil.NToC( A360DespBodStock, 6, 2, ",", "")),((edtDespBodStock_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A360DespBodStock, "ZZ9.99")) : context.localUtil.Format( A360DespBodStock, "ZZ9.99")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodStock_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtDespBodStock_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)6,(short)0,(short)0,(short)108,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Griddespbodega_prdRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodCatId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A361DespBodCatId), 4, 0, ",", "")),((edtDespBodCatId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A361DespBodCatId), "ZZZ9")) : context.localUtil.Format( (decimal)(A361DespBodCatId), "ZZZ9")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodCatId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(int)edtDespBodCatId_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)108,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Griddespbodega_prdRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodDif_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A362DespBodDif), 4, 0, ",", "")),((edtDespBodDif_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A362DespBodDif), "ZZZ9")) : context.localUtil.Format( (decimal)(A362DespBodDif), "ZZZ9")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodDif_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtDespBodDif_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)108,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Check box */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_94_" + sGXsfl_108_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 119,'',false,'" + sGXsfl_108_idx + "',108)\"";
         ClassString = "Attribute";
         StyleString = "";
         Griddespbodega_prdRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkDespBodModifItem_Internalname,(String)A403DespBodModifItem,(String)"",(String)"",(short)-1,chkDespBodModifItem.Enabled,(String)"S",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",TempTags+" onclick=\"gx.fn.checkboxClick(119, this, 'S', 'N');gx.evt.onchange(this, event);\" "});
         /* Subfile cell */
         /* Static Bitmap Variable */
         ClassString = "ImageAttribute";
         StyleString = "";
         AV19despachado_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV19despachado))&&String.IsNullOrEmpty(StringUtil.RTrim( AV25Despachado_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV19despachado)));
         sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV19despachado)) ? AV25Despachado_GXI : context.PathToRelativeUrl( AV19despachado));
         Griddespbodega_prdRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDespachado_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(int)edtavDespachado_Visible,(int)edtavDespachado_Enabled,(String)"",(String)edtavDespachado_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV19despachado_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Griddespbodega_prdRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodOK_Internalname,StringUtil.RTrim( A392DespBodOK),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodOK_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(int)edtDespBodOK_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)1,(short)0,(short)0,(short)108,(short)1,(short)-1,(short)-1,(bool)true,(String)"estado",(String)"left",(bool)true});
         context.httpAjaxContext.ajax_sending_grid_row(Griddespbodega_prdRow);
         send_integrity_lvl_hashes1294( ) ;
         GXCCtl = "Z400nroReg_" + sGXsfl_108_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z400nroReg), 6, 0, ",", "")));
         GXCCtl = "Z355DespBodCodPrd_" + sGXsfl_108_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z355DespBodCodPrd), 4, 0, ",", "")));
         GXCCtl = "Z356DespBodPrdNombre_" + sGXsfl_108_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z356DespBodPrdNombre));
         GXCCtl = "Z357DespBodCant_" + sGXsfl_108_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z357DespBodCant, 8, 2, ",", "")));
         GXCCtl = "Z358DespBodValor_" + sGXsfl_108_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z358DespBodValor, 8, 2, ",", "")));
         GXCCtl = "Z359DespBodADesp_" + sGXsfl_108_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z359DespBodADesp, 8, 2, ",", "")));
         GXCCtl = "Z376DespBodDetalle_" + sGXsfl_108_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z376DespBodDetalle));
         GXCCtl = "Z361DespBodCatId_" + sGXsfl_108_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z361DespBodCatId), 4, 0, ",", "")));
         GXCCtl = "Z392DespBodOK_" + sGXsfl_108_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z392DespBodOK));
         GXCCtl = "Z403DespBodModifItem_" + sGXsfl_108_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z403DespBodModifItem));
         GXCCtl = "nRcdDeleted_94_" + sGXsfl_108_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_94), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_94_" + sGXsfl_108_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_94), 4, 0, ",", "")));
         GXCCtl = "nIsMod_94_" + sGXsfl_108_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_94), 4, 0, ",", "")));
         GXCCtl = "vMODE_" + sGXsfl_108_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_108_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV13TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV13TrnContext);
         }
         GXCCtl = "vEMPID_" + sGXsfl_108_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7empid), 4, 0, ",", "")));
         GXCCtl = "vAGEID_" + sGXsfl_108_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8ageId), 4, 0, ",", "")));
         GXCCtl = "vDESPBODNRO_" + sGXsfl_108_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10DespBodNro), 4, 0, ",", "")));
         GXCCtl = "vORDENID_" + sGXsfl_108_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17OrdenID), 4, 0, ",", "")));
         GXCCtl = "vCLIENTEID_" + sGXsfl_108_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21clienteID), 4, 0, ",", "")));
         GXCCtl = "vUSUCOD_" + sGXsfl_108_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( AV20usuCod));
         GxWebStd.gx_hidden_field( context, "NROREG_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtnroReg_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DESPBODCODPRD_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodCodPrd_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DESPBODPRDNOMBRE_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodPrdNombre_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DESPBODCANT_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodCant_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DESPBODVALOR_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodValor_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DESPBODADESP_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodADesp_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DESPBODDETALLE_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodDetalle_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DESPBODSTOCK_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodStock_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DESPBODCATID_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodCatId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DESPBODDIF_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodDif_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DESPBODMODIFITEM_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkDespBodModifItem.Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vDESPACHADO_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDespachado_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vDESPACHADO_"+sGXsfl_108_idx+"Tooltiptext", StringUtil.RTrim( edtavDespachado_Tooltiptext));
         GxWebStd.gx_hidden_field( context, "vDESPACHADO_"+sGXsfl_108_idx+"Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDespachado_Visible), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DESPBODOK_"+sGXsfl_108_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDespBodOK_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Griddespbodega_prdContainer.AddRow(Griddespbodega_prdRow);
      }

      protected void ReadRow1294( )
      {
         nGXsfl_108_idx = (short)(nGXsfl_108_idx+1);
         sGXsfl_108_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_108_idx), 4, 0)), 4, "0");
         SubsflControlProps_10894( ) ;
         edtnroReg_Enabled = (int)(context.localUtil.CToN( cgiGet( "NROREG_"+sGXsfl_108_idx+"Enabled"), ",", "."));
         edtDespBodCodPrd_Enabled = (int)(context.localUtil.CToN( cgiGet( "DESPBODCODPRD_"+sGXsfl_108_idx+"Enabled"), ",", "."));
         edtDespBodPrdNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "DESPBODPRDNOMBRE_"+sGXsfl_108_idx+"Enabled"), ",", "."));
         edtDespBodCant_Enabled = (int)(context.localUtil.CToN( cgiGet( "DESPBODCANT_"+sGXsfl_108_idx+"Enabled"), ",", "."));
         edtDespBodValor_Enabled = (int)(context.localUtil.CToN( cgiGet( "DESPBODVALOR_"+sGXsfl_108_idx+"Enabled"), ",", "."));
         edtDespBodADesp_Enabled = (int)(context.localUtil.CToN( cgiGet( "DESPBODADESP_"+sGXsfl_108_idx+"Enabled"), ",", "."));
         edtDespBodDetalle_Enabled = (int)(context.localUtil.CToN( cgiGet( "DESPBODDETALLE_"+sGXsfl_108_idx+"Enabled"), ",", "."));
         edtDespBodStock_Enabled = (int)(context.localUtil.CToN( cgiGet( "DESPBODSTOCK_"+sGXsfl_108_idx+"Enabled"), ",", "."));
         edtDespBodCatId_Enabled = (int)(context.localUtil.CToN( cgiGet( "DESPBODCATID_"+sGXsfl_108_idx+"Enabled"), ",", "."));
         edtDespBodDif_Enabled = (int)(context.localUtil.CToN( cgiGet( "DESPBODDIF_"+sGXsfl_108_idx+"Enabled"), ",", "."));
         chkDespBodModifItem.Enabled = (int)(context.localUtil.CToN( cgiGet( "DESPBODMODIFITEM_"+sGXsfl_108_idx+"Enabled"), ",", "."));
         edtavDespachado_Enabled = (int)(context.localUtil.CToN( cgiGet( "vDESPACHADO_"+sGXsfl_108_idx+"Enabled"), ",", "."));
         edtavDespachado_Tooltiptext = cgiGet( "vDESPACHADO_"+sGXsfl_108_idx+"Tooltiptext");
         edtavDespachado_Visible = (int)(context.localUtil.CToN( cgiGet( "vDESPACHADO_"+sGXsfl_108_idx+"Visible"), ",", "."));
         edtDespBodOK_Enabled = (int)(context.localUtil.CToN( cgiGet( "DESPBODOK_"+sGXsfl_108_idx+"Enabled"), ",", "."));
         if ( ( ( context.localUtil.CToN( cgiGet( edtnroReg_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtnroReg_Internalname), ",", ".") > Convert.ToDecimal( 999999 )) ) )
         {
            GXCCtl = "NROREG_" + sGXsfl_108_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtnroReg_Internalname;
            wbErr = true;
            A400nroReg = 0;
         }
         else
         {
            A400nroReg = (int)(context.localUtil.CToN( cgiGet( edtnroReg_Internalname), ",", "."));
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtDespBodCodPrd_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtDespBodCodPrd_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "DESPBODCODPRD_" + sGXsfl_108_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtDespBodCodPrd_Internalname;
            wbErr = true;
            A355DespBodCodPrd = 0;
            n355DespBodCodPrd = false;
         }
         else
         {
            A355DespBodCodPrd = (short)(context.localUtil.CToN( cgiGet( edtDespBodCodPrd_Internalname), ",", "."));
            n355DespBodCodPrd = false;
         }
         n355DespBodCodPrd = ((0==A355DespBodCodPrd) ? true : false);
         A356DespBodPrdNombre = StringUtil.Upper( cgiGet( edtDespBodPrdNombre_Internalname));
         n356DespBodPrdNombre = false;
         A357DespBodCant = context.localUtil.CToN( cgiGet( edtDespBodCant_Internalname), ",", ".");
         n357DespBodCant = false;
         A358DespBodValor = context.localUtil.CToN( cgiGet( edtDespBodValor_Internalname), ",", ".");
         n358DespBodValor = false;
         if ( ( ( context.localUtil.CToN( cgiGet( edtDespBodADesp_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtDespBodADesp_Internalname), ",", ".") > 99999.99m ) ) )
         {
            GXCCtl = "DESPBODADESP_" + sGXsfl_108_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtDespBodADesp_Internalname;
            wbErr = true;
            A359DespBodADesp = 0;
            n359DespBodADesp = false;
         }
         else
         {
            A359DespBodADesp = context.localUtil.CToN( cgiGet( edtDespBodADesp_Internalname), ",", ".");
            n359DespBodADesp = false;
         }
         n359DespBodADesp = ((Convert.ToDecimal(0)==A359DespBodADesp) ? true : false);
         A376DespBodDetalle = cgiGet( edtDespBodDetalle_Internalname);
         n376DespBodDetalle = false;
         A360DespBodStock = context.localUtil.CToN( cgiGet( edtDespBodStock_Internalname), ",", ".");
         A361DespBodCatId = (short)(context.localUtil.CToN( cgiGet( edtDespBodCatId_Internalname), ",", "."));
         n361DespBodCatId = false;
         A362DespBodDif = (short)(context.localUtil.CToN( cgiGet( edtDespBodDif_Internalname), ",", "."));
         A403DespBodModifItem = ((StringUtil.StrCmp(cgiGet( chkDespBodModifItem_Internalname), "S")==0) ? "S" : "N");
         n403DespBodModifItem = false;
         n403DespBodModifItem = (String.IsNullOrEmpty(StringUtil.RTrim( A403DespBodModifItem)) ? true : false);
         AV19despachado = cgiGet( edtavDespachado_Internalname);
         A392DespBodOK = cgiGet( edtDespBodOK_Internalname);
         n392DespBodOK = false;
         GXCCtl = "Z400nroReg_" + sGXsfl_108_idx;
         Z400nroReg = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z355DespBodCodPrd_" + sGXsfl_108_idx;
         Z355DespBodCodPrd = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         n355DespBodCodPrd = ((0==A355DespBodCodPrd) ? true : false);
         GXCCtl = "Z356DespBodPrdNombre_" + sGXsfl_108_idx;
         Z356DespBodPrdNombre = cgiGet( GXCCtl);
         n356DespBodPrdNombre = (String.IsNullOrEmpty(StringUtil.RTrim( A356DespBodPrdNombre)) ? true : false);
         GXCCtl = "Z357DespBodCant_" + sGXsfl_108_idx;
         Z357DespBodCant = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n357DespBodCant = ((Convert.ToDecimal(0)==A357DespBodCant) ? true : false);
         GXCCtl = "Z358DespBodValor_" + sGXsfl_108_idx;
         Z358DespBodValor = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n358DespBodValor = ((Convert.ToDecimal(0)==A358DespBodValor) ? true : false);
         GXCCtl = "Z359DespBodADesp_" + sGXsfl_108_idx;
         Z359DespBodADesp = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n359DespBodADesp = ((Convert.ToDecimal(0)==A359DespBodADesp) ? true : false);
         GXCCtl = "Z376DespBodDetalle_" + sGXsfl_108_idx;
         Z376DespBodDetalle = cgiGet( GXCCtl);
         n376DespBodDetalle = (String.IsNullOrEmpty(StringUtil.RTrim( A376DespBodDetalle)) ? true : false);
         GXCCtl = "Z361DespBodCatId_" + sGXsfl_108_idx;
         Z361DespBodCatId = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         n361DespBodCatId = ((0==A361DespBodCatId) ? true : false);
         GXCCtl = "Z392DespBodOK_" + sGXsfl_108_idx;
         Z392DespBodOK = cgiGet( GXCCtl);
         n392DespBodOK = (String.IsNullOrEmpty(StringUtil.RTrim( A392DespBodOK)) ? true : false);
         GXCCtl = "Z403DespBodModifItem_" + sGXsfl_108_idx;
         Z403DespBodModifItem = cgiGet( GXCCtl);
         n403DespBodModifItem = (String.IsNullOrEmpty(StringUtil.RTrim( A403DespBodModifItem)) ? true : false);
         GXCCtl = "nRcdDeleted_94_" + sGXsfl_108_idx;
         nRcdDeleted_94 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_94_" + sGXsfl_108_idx;
         nRcdExists_94 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_94_" + sGXsfl_108_idx;
         nIsMod_94 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void assign_properties_default( )
      {
         defedtDespBodOK_Enabled = edtDespBodOK_Enabled;
         defedtDespBodCatId_Enabled = edtDespBodCatId_Enabled;
         defedtDespBodDetalle_Enabled = edtDespBodDetalle_Enabled;
         defedtDespBodValor_Enabled = edtDespBodValor_Enabled;
         defedtDespBodCant_Enabled = edtDespBodCant_Enabled;
         defedtDespBodPrdNombre_Enabled = edtDespBodPrdNombre_Enabled;
         defedtnroReg_Enabled = edtnroReg_Enabled;
      }

      protected void ConfirmValues120( )
      {
         nGXsfl_108_idx = 0;
         sGXsfl_108_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_108_idx), 4, 0)), 4, "0");
         SubsflControlProps_10894( ) ;
         while ( nGXsfl_108_idx < nRC_GXsfl_108 )
         {
            nGXsfl_108_idx = (short)(nGXsfl_108_idx+1);
            sGXsfl_108_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_108_idx), 4, 0)), 4, "0");
            SubsflControlProps_10894( ) ;
            ChangePostValue( "Z400nroReg_"+sGXsfl_108_idx, cgiGet( "ZT_"+"Z400nroReg_"+sGXsfl_108_idx)) ;
            DeletePostValue( "ZT_"+"Z400nroReg_"+sGXsfl_108_idx) ;
            ChangePostValue( "Z355DespBodCodPrd_"+sGXsfl_108_idx, cgiGet( "ZT_"+"Z355DespBodCodPrd_"+sGXsfl_108_idx)) ;
            DeletePostValue( "ZT_"+"Z355DespBodCodPrd_"+sGXsfl_108_idx) ;
            ChangePostValue( "Z356DespBodPrdNombre_"+sGXsfl_108_idx, cgiGet( "ZT_"+"Z356DespBodPrdNombre_"+sGXsfl_108_idx)) ;
            DeletePostValue( "ZT_"+"Z356DespBodPrdNombre_"+sGXsfl_108_idx) ;
            ChangePostValue( "Z357DespBodCant_"+sGXsfl_108_idx, cgiGet( "ZT_"+"Z357DespBodCant_"+sGXsfl_108_idx)) ;
            DeletePostValue( "ZT_"+"Z357DespBodCant_"+sGXsfl_108_idx) ;
            ChangePostValue( "Z358DespBodValor_"+sGXsfl_108_idx, cgiGet( "ZT_"+"Z358DespBodValor_"+sGXsfl_108_idx)) ;
            DeletePostValue( "ZT_"+"Z358DespBodValor_"+sGXsfl_108_idx) ;
            ChangePostValue( "Z359DespBodADesp_"+sGXsfl_108_idx, cgiGet( "ZT_"+"Z359DespBodADesp_"+sGXsfl_108_idx)) ;
            DeletePostValue( "ZT_"+"Z359DespBodADesp_"+sGXsfl_108_idx) ;
            ChangePostValue( "Z376DespBodDetalle_"+sGXsfl_108_idx, cgiGet( "ZT_"+"Z376DespBodDetalle_"+sGXsfl_108_idx)) ;
            DeletePostValue( "ZT_"+"Z376DespBodDetalle_"+sGXsfl_108_idx) ;
            ChangePostValue( "Z361DespBodCatId_"+sGXsfl_108_idx, cgiGet( "ZT_"+"Z361DespBodCatId_"+sGXsfl_108_idx)) ;
            DeletePostValue( "ZT_"+"Z361DespBodCatId_"+sGXsfl_108_idx) ;
            ChangePostValue( "Z392DespBodOK_"+sGXsfl_108_idx, cgiGet( "ZT_"+"Z392DespBodOK_"+sGXsfl_108_idx)) ;
            DeletePostValue( "ZT_"+"Z392DespBodOK_"+sGXsfl_108_idx) ;
            ChangePostValue( "Z403DespBodModifItem_"+sGXsfl_108_idx, cgiGet( "ZT_"+"Z403DespBodModifItem_"+sGXsfl_108_idx)) ;
            DeletePostValue( "ZT_"+"Z403DespBodModifItem_"+sGXsfl_108_idx) ;
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
         context.SendWebValue( "Despacho Bodega") ;
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
         context.AddJavascriptSource("gxcfg.js", "?202312317628", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("despbodega.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7empid) + "," + UrlEncode("" +AV8ageId) + "," + UrlEncode("" +AV10DespBodNro) + "," + UrlEncode("" +AV17OrdenID) + "," + UrlEncode("" +AV21clienteID) + "," + UrlEncode(StringUtil.RTrim(AV20usuCod))+"\">") ;
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
         forbiddenHiddens = "hsh" + "DespBodega";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV15Insert_BodCod), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("despbodega:[SendSecurityCheck value for]"+"Insert_BodCod:"+context.localUtil.Format( (decimal)(AV15Insert_BodCod), "ZZZ9"));
         GXUtil.WriteLog("despbodega:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1EmpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z2AgeID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z2AgeID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z353DespBodNro", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z353DespBodNro), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z22OrdenID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z22OrdenID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z5ClienteID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z5ClienteID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z399DespBodUltReg", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z399DespBodUltReg), 6, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z402DespachadoOK", StringUtil.RTrim( Z402DespachadoOK));
         GxWebStd.gx_hidden_field( context, "Z42BodCod", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z42BodCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_108", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_108_idx), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "N42BodCod", StringUtil.LTrim( StringUtil.NToC( (decimal)(A42BodCod), 4, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV13TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV13TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vUSUCOD", StringUtil.RTrim( AV20usuCod));
         GxWebStd.gx_hidden_field( context, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV20usuCod, "")), context));
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7empid), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7empid), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8ageId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8ageId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vDESPBODNRO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10DespBodNro), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vDESPBODNRO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10DespBodNro), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vORDENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17OrdenID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vORDENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV17OrdenID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vCLIENTEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21clienteID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vCLIENTEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV21clienteID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_BODCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15Insert_BodCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "EMPDSC", A44empdsc);
         GxWebStd.gx_hidden_field( context, "AGEDSC", StringUtil.RTrim( A46AgeDsc));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV23Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "TAB1_Objectcall", StringUtil.RTrim( Tab1_Objectcall));
         GxWebStd.gx_hidden_field( context, "TAB1_Enabled", StringUtil.BoolToStr( Tab1_Enabled));
         GxWebStd.gx_hidden_field( context, "TAB1_Class", StringUtil.RTrim( Tab1_Class));
         GxWebStd.gx_hidden_field( context, "TAB1_Pagecount", StringUtil.LTrim( StringUtil.NToC( (decimal)(Tab1_Pagecount), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TAB1_Historymanagement", StringUtil.BoolToStr( Tab1_Historymanagement));
      }

      protected void RenderHtmlCloseForm1293( )
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
         return "DespBodega" ;
      }

      public override String GetPgmdesc( )
      {
         return "Despacho Bodega" ;
      }

      protected void InitializeNonKey1293( )
      {
         A42BodCod = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
         A44empdsc = "";
         n44empdsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         A46AgeDsc = "";
         n46AgeDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
         A217BodDsc = "";
         n217BodDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
         A56ClienteRUC = "";
         n56ClienteRUC = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56ClienteRUC", A56ClienteRUC);
         A57ClienteDsc = "";
         n57ClienteDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A57ClienteDsc", A57ClienteDsc);
         A399DespBodUltReg = 0;
         n399DespBodUltReg = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A399DespBodUltReg", StringUtil.LTrim( StringUtil.Str( (decimal)(A399DespBodUltReg), 6, 0)));
         n399DespBodUltReg = ((0==A399DespBodUltReg) ? true : false);
         A402DespachadoOK = "";
         n402DespachadoOK = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A402DespachadoOK", A402DespachadoOK);
         n402DespachadoOK = (String.IsNullOrEmpty(StringUtil.RTrim( A402DespachadoOK)) ? true : false);
         Z399DespBodUltReg = 0;
         Z402DespachadoOK = "";
         Z42BodCod = 0;
      }

      protected void InitAll1293( )
      {
         A1EmpID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         A2AgeID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
         A353DespBodNro = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A353DespBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A353DespBodNro), 4, 0)));
         A22OrdenID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
         A5ClienteID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
         InitializeNonKey1293( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey1294( )
      {
         A360DespBodStock = 0;
         A355DespBodCodPrd = 0;
         n355DespBodCodPrd = false;
         A356DespBodPrdNombre = "";
         n356DespBodPrdNombre = false;
         A357DespBodCant = 0;
         n357DespBodCant = false;
         A358DespBodValor = 0;
         n358DespBodValor = false;
         A359DespBodADesp = 0;
         n359DespBodADesp = false;
         A376DespBodDetalle = "";
         n376DespBodDetalle = false;
         A361DespBodCatId = 0;
         n361DespBodCatId = false;
         A362DespBodDif = 0;
         A392DespBodOK = "";
         n392DespBodOK = false;
         A403DespBodModifItem = "";
         n403DespBodModifItem = false;
         Z355DespBodCodPrd = 0;
         Z356DespBodPrdNombre = "";
         Z357DespBodCant = 0;
         Z358DespBodValor = 0;
         Z359DespBodADesp = 0;
         Z376DespBodDetalle = "";
         Z361DespBodCatId = 0;
         Z392DespBodOK = "";
         Z403DespBodModifItem = "";
      }

      protected void InitAll1294( )
      {
         A400nroReg = 0;
         InitializeNonKey1294( ) ;
      }

      protected void StandaloneModalInsert1294( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202312317718", true);
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
         context.AddJavascriptSource("despbodega.js", "?202312317719", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false);
         context.AddJavascriptSource("Tab/TabRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_level_properties94( )
      {
         edtDespBodOK_Enabled = defedtDespBodOK_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodOK_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodOK_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
         edtDespBodCatId_Enabled = defedtDespBodCatId_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodCatId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodCatId_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
         edtDespBodDetalle_Enabled = defedtDespBodDetalle_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodDetalle_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodDetalle_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
         edtDespBodValor_Enabled = defedtDespBodValor_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodValor_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodValor_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
         edtDespBodCant_Enabled = defedtDespBodCant_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodCant_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodCant_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
         edtDespBodPrdNombre_Enabled = defedtDespBodPrdNombre_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodPrdNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDespBodPrdNombre_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
         edtnroReg_Enabled = defedtnroReg_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtnroReg_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtnroReg_Enabled), 5, 0)), !bGXsfl_108_Refreshing);
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
         divSection1_Internalname = "SECTION1";
         dynAgeID_Internalname = "AGEID";
         divSection2_Internalname = "SECTION2";
         edtOrdenID_Internalname = "ORDENID";
         divSection3_Internalname = "SECTION3";
         edtDespBodNro_Internalname = "DESPBODNRO";
         divSection4_Internalname = "SECTION4";
         lblTabpage2_title_Internalname = "TABPAGE2_TITLE";
         edtClienteID_Internalname = "CLIENTEID";
         edtClienteRUC_Internalname = "CLIENTERUC";
         edtClienteDsc_Internalname = "CLIENTEDSC";
         divTable2_Internalname = "TABLE2";
         divTabpage2table_Internalname = "TABPAGE2TABLE";
         lblTabpage1_title_Internalname = "TABPAGE1_TITLE";
         edtBodCod_Internalname = "BODCOD";
         edtBodDsc_Internalname = "BODDSC";
         divTable1_Internalname = "TABLE1";
         divTabpage1table_Internalname = "TABPAGE1TABLE";
         Tab1_Internalname = "TAB1";
         chkDespachadoOK_Internalname = "DESPACHADOOK";
         edtDespBodUltReg_Internalname = "DESPBODULTREG";
         lblTitleprd_Internalname = "TITLEPRD";
         edtnroReg_Internalname = "NROREG";
         edtDespBodCodPrd_Internalname = "DESPBODCODPRD";
         edtDespBodPrdNombre_Internalname = "DESPBODPRDNOMBRE";
         edtDespBodCant_Internalname = "DESPBODCANT";
         edtDespBodValor_Internalname = "DESPBODVALOR";
         edtDespBodADesp_Internalname = "DESPBODADESP";
         edtDespBodDetalle_Internalname = "DESPBODDETALLE";
         edtDespBodStock_Internalname = "DESPBODSTOCK";
         edtDespBodCatId_Internalname = "DESPBODCATID";
         edtDespBodDif_Internalname = "DESPBODDIF";
         chkDespBodModifItem_Internalname = "DESPBODMODIFITEM";
         edtavDespachado_Internalname = "vDESPACHADO";
         edtDespBodOK_Internalname = "DESPBODOK";
         divPrdtable_Internalname = "PRDTABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_5_Internalname = "PROMPT_5";
         imgprompt_42_Internalname = "PROMPT_42";
         subGriddespbodega_prd_Internalname = "GRIDDESPBODEGA_PRD";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         Tab1_Historymanagement = Convert.ToBoolean( 0);
         Tab1_Pagecount = 2;
         Tab1_Class = "Tab";
         edtDespBodOK_Jsonclick = "";
         edtDespBodDif_Jsonclick = "";
         edtDespBodCatId_Jsonclick = "";
         edtDespBodStock_Jsonclick = "";
         edtDespBodDetalle_Jsonclick = "";
         edtDespBodADesp_Jsonclick = "";
         edtDespBodValor_Jsonclick = "";
         edtDespBodCant_Jsonclick = "";
         edtDespBodPrdNombre_Jsonclick = "";
         edtDespBodCodPrd_Jsonclick = "";
         edtnroReg_Jsonclick = "";
         subGriddespbodega_prd_Class = "Grid";
         subGriddespbodega_prd_Backcolorstyle = 0;
         subGriddespbodega_prd_Allowcollapsing = 0;
         subGriddespbodega_prd_Allowhovering = 0;
         subGriddespbodega_prd_Allowselection = 1;
         edtDespBodOK_Enabled = 0;
         edtavDespachado_Visible = 0;
         edtavDespachado_Tooltiptext = "";
         edtavDespachado_Enabled = 0;
         chkDespBodModifItem.Enabled = 1;
         edtDespBodDif_Enabled = 0;
         edtDespBodCatId_Enabled = 0;
         edtDespBodStock_Enabled = 0;
         edtDespBodDetalle_Enabled = 0;
         edtDespBodADesp_Enabled = 1;
         edtDespBodValor_Enabled = 0;
         edtDespBodCant_Enabled = 0;
         edtDespBodPrdNombre_Enabled = 0;
         edtDespBodCodPrd_Enabled = 1;
         edtnroReg_Enabled = 1;
         subGriddespbodega_prd_Sortable = 0;
         subGriddespbodega_prd_Header = "";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         divPrdtable_Visible = 1;
         edtDespBodUltReg_Jsonclick = "";
         edtDespBodUltReg_Enabled = 1;
         edtDespBodUltReg_Visible = 1;
         chkDespachadoOK.Enabled = 1;
         chkDespachadoOK.Visible = 1;
         edtBodDsc_Jsonclick = "";
         edtBodDsc_Enabled = 0;
         imgprompt_42_Visible = 1;
         imgprompt_42_Link = "";
         edtBodCod_Jsonclick = "";
         edtBodCod_Enabled = 1;
         edtClienteDsc_Jsonclick = "";
         edtClienteDsc_Enabled = 0;
         edtClienteRUC_Jsonclick = "";
         edtClienteRUC_Enabled = 0;
         imgprompt_5_Visible = 1;
         imgprompt_5_Link = "";
         edtClienteID_Jsonclick = "";
         edtClienteID_Enabled = 1;
         edtDespBodNro_Jsonclick = "";
         edtDespBodNro_Enabled = 1;
         edtOrdenID_Jsonclick = "";
         edtOrdenID_Enabled = 1;
         dynAgeID_Jsonclick = "";
         dynAgeID.Enabled = 1;
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

      protected void GXDLAEMPID1293( short AV7empid )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLAEMPID_data1293( AV7empid) ;
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

      protected void GXAEMPID_html1293( short AV7empid )
      {
         short gxdynajaxvalue ;
         GXDLAEMPID_data1293( AV7empid) ;
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

      protected void GXDLAEMPID_data1293( short AV7empid )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         /* Using cursor T001232 */
         pr_default.execute(30, new Object[] {AV7empid});
         while ( (pr_default.getStatus(30) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T001232_A1EmpID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(T001232_A44empdsc[0]);
            pr_default.readNext(30);
         }
         pr_default.close(30);
      }

      protected void GXDLAAGEID1293( short AV7empid ,
                                     short AV8ageId )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLAAGEID_data1293( AV7empid, AV8ageId) ;
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

      protected void GXAAGEID_html1293( short AV7empid ,
                                        short AV8ageId )
      {
         short gxdynajaxvalue ;
         GXDLAAGEID_data1293( AV7empid, AV8ageId) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynAgeID.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (short)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynAgeID.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 4, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLAAGEID_data1293( short AV7empid ,
                                          short AV8ageId )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         /* Using cursor T001233 */
         pr_default.execute(31, new Object[] {AV7empid, AV8ageId});
         while ( (pr_default.getStatus(31) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T001233_A2AgeID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T001233_A46AgeDsc[0]));
            pr_default.readNext(31);
         }
         pr_default.close(31);
      }

      protected void GX24ASADESPBODSTOCK1294( short A1EmpID ,
                                              short A2AgeID ,
                                              short A42BodCod ,
                                              short A355DespBodCodPrd )
      {
         GXt_decimal1 = A360DespBodStock;
         new prcbusstock(context ).execute(  (short)(DateTimeUtil.Year( DateTimeUtil.ServerNow( context, pr_default))),  (short)(DateTimeUtil.Month( DateTimeUtil.ServerNow( context, pr_default))),  A1EmpID,  A2AgeID,  A42BodCod,  A355DespBodCodPrd, out  GXt_decimal1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
         A360DespBodStock = GXt_decimal1;
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A360DespBodStock, 6, 2, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void gxnrGriddespbodega_prd_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_10894( ) ;
         while ( nGXsfl_108_idx <= nRC_GXsfl_108 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal1294( ) ;
            standaloneModal1294( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow1294( ) ;
            nGXsfl_108_idx = (short)(nGXsfl_108_idx+1);
            sGXsfl_108_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_108_idx), 4, 0)), 4, "0");
            SubsflControlProps_10894( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Griddespbodega_prdContainer));
         /* End function gxnrGriddespbodega_prd_newrow */
      }

      protected void init_web_controls( )
      {
         dynEmpID.Name = "EMPID";
         dynEmpID.WebTags = "";
         dynAgeID.Name = "AGEID";
         dynAgeID.WebTags = "";
         chkDespachadoOK.Name = "DESPACHADOOK";
         chkDespachadoOK.WebTags = "";
         chkDespachadoOK.Caption = "Si";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkDespachadoOK_Internalname, "TitleCaption", chkDespachadoOK.Caption, true);
         chkDespachadoOK.CheckedValue = "N";
         GXCCtl = "DESPBODMODIFITEM_" + sGXsfl_108_idx;
         chkDespBodModifItem.Name = GXCCtl;
         chkDespBodModifItem.WebTags = "";
         chkDespBodModifItem.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkDespBodModifItem_Internalname, "TitleCaption", chkDespBodModifItem.Caption, !bGXsfl_108_Refreshing);
         chkDespBodModifItem.CheckedValue = "N";
         /* End function init_web_controls */
      }

      public void Valid_Empid( GXCombobox dynGX_Parm1 ,
                               String GX_Parm2 )
      {
         dynEmpID = dynGX_Parm1;
         A1EmpID = (short)(NumberUtil.Val( dynEmpID.CurrentValue, "."));
         A44empdsc = GX_Parm2;
         n44empdsc = false;
         /* Using cursor T001234 */
         pr_default.execute(32, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(32) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = dynEmpID_Internalname;
         }
         A44empdsc = T001234_A44empdsc[0];
         n44empdsc = T001234_n44empdsc[0];
         pr_default.close(32);
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

      public void Valid_Ageid( GXCombobox dynGX_Parm1 ,
                               GXCombobox dynGX_Parm2 ,
                               String GX_Parm3 )
      {
         dynEmpID = dynGX_Parm1;
         A1EmpID = (short)(NumberUtil.Val( dynEmpID.CurrentValue, "."));
         dynAgeID = dynGX_Parm2;
         A2AgeID = (short)(NumberUtil.Val( dynAgeID.CurrentValue, "."));
         A46AgeDsc = GX_Parm3;
         n46AgeDsc = false;
         /* Using cursor T001235 */
         pr_default.execute(33, new Object[] {A1EmpID, A2AgeID});
         if ( (pr_default.getStatus(33) == 101) )
         {
            GX_msglist.addItem("No existe 'Agencias'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = dynEmpID_Internalname;
         }
         A46AgeDsc = T001235_A46AgeDsc[0];
         n46AgeDsc = T001235_n46AgeDsc[0];
         pr_default.close(33);
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

      public void Valid_Clienteid( GXCombobox dynGX_Parm1 ,
                                   short GX_Parm2 ,
                                   String GX_Parm3 ,
                                   String GX_Parm4 )
      {
         dynEmpID = dynGX_Parm1;
         A1EmpID = (short)(NumberUtil.Val( dynEmpID.CurrentValue, "."));
         A5ClienteID = GX_Parm2;
         A56ClienteRUC = GX_Parm3;
         n56ClienteRUC = false;
         A57ClienteDsc = GX_Parm4;
         n57ClienteDsc = false;
         /* Using cursor T001236 */
         pr_default.execute(34, new Object[] {A1EmpID, A5ClienteID});
         if ( (pr_default.getStatus(34) == 101) )
         {
            GX_msglist.addItem("No existe 'Clientes'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = dynEmpID_Internalname;
         }
         A56ClienteRUC = T001236_A56ClienteRUC[0];
         n56ClienteRUC = T001236_n56ClienteRUC[0];
         A57ClienteDsc = T001236_A57ClienteDsc[0];
         n57ClienteDsc = T001236_n57ClienteDsc[0];
         pr_default.close(34);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A56ClienteRUC = "";
            n56ClienteRUC = false;
            A57ClienteDsc = "";
            n57ClienteDsc = false;
         }
         isValidOutput.Add(StringUtil.RTrim( A56ClienteRUC));
         isValidOutput.Add(StringUtil.RTrim( A57ClienteDsc));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Bodcod( GXCombobox dynGX_Parm1 ,
                                short GX_Parm2 ,
                                String GX_Parm3 )
      {
         dynEmpID = dynGX_Parm1;
         A1EmpID = (short)(NumberUtil.Val( dynEmpID.CurrentValue, "."));
         A42BodCod = GX_Parm2;
         A217BodDsc = GX_Parm3;
         n217BodDsc = false;
         /* Using cursor T001237 */
         pr_default.execute(35, new Object[] {A1EmpID, A42BodCod});
         if ( (pr_default.getStatus(35) == 101) )
         {
            GX_msglist.addItem("No existe 'Bodegas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = dynEmpID_Internalname;
         }
         A217BodDsc = T001237_A217BodDsc[0];
         n217BodDsc = T001237_n217BodDsc[0];
         pr_default.close(35);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A217BodDsc = "";
            n217BodDsc = false;
         }
         isValidOutput.Add(StringUtil.RTrim( A217BodDsc));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Despbodcodprd( GXCombobox dynGX_Parm1 ,
                                       GXCombobox dynGX_Parm2 ,
                                       short GX_Parm3 ,
                                       short GX_Parm4 ,
                                       decimal GX_Parm5 )
      {
         dynEmpID = dynGX_Parm1;
         A1EmpID = (short)(NumberUtil.Val( dynEmpID.CurrentValue, "."));
         dynAgeID = dynGX_Parm2;
         A2AgeID = (short)(NumberUtil.Val( dynAgeID.CurrentValue, "."));
         A42BodCod = GX_Parm3;
         A355DespBodCodPrd = GX_Parm4;
         n355DespBodCodPrd = false;
         A360DespBodStock = GX_Parm5;
         GXt_decimal1 = A360DespBodStock;
         new prcbusstock(context ).execute(  (short)(DateTimeUtil.Year( DateTimeUtil.ServerNow( context, pr_default))),  (short)(DateTimeUtil.Month( DateTimeUtil.ServerNow( context, pr_default))),  A1EmpID,  A2AgeID,  A42BodCod,  A355DespBodCodPrd, out  GXt_decimal1) ;
         A360DespBodStock = GXt_decimal1;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A360DespBodStock, 6, 2, ".", "")));
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV10DespBodNro',fld:'vDESPBODNRO',pic:'ZZZ9',hsh:true},{av:'AV17OrdenID',fld:'vORDENID',pic:'ZZZ9',hsh:true},{av:'AV21clienteID',fld:'vCLIENTEID',pic:'ZZZ9',hsh:true},{av:'AV20usuCod',fld:'vUSUCOD',pic:'',hsh:true},{av:'AV7empid',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynEmpID'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'AV8ageId',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'dynAgeID'},{av:'A2AgeID',fld:'AGEID',pic:'ZZZ9'}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV7empid',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynEmpID'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'AV8ageId',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'dynAgeID'},{av:'A2AgeID',fld:'AGEID',pic:'ZZZ9'}]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV20usuCod',fld:'vUSUCOD',pic:'',hsh:true},{av:'AV10DespBodNro',fld:'vDESPBODNRO',pic:'ZZZ9',hsh:true},{av:'AV17OrdenID',fld:'vORDENID',pic:'ZZZ9',hsh:true},{av:'AV21clienteID',fld:'vCLIENTEID',pic:'ZZZ9',hsh:true},{av:'AV15Insert_BodCod',fld:'vINSERT_BODCOD',pic:'ZZZ9'},{av:'AV7empid',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynEmpID'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'AV8ageId',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'dynAgeID'},{av:'A2AgeID',fld:'AGEID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV7empid',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynEmpID'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'AV8ageId',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'dynAgeID'},{av:'A2AgeID',fld:'AGEID',pic:'ZZZ9'}]}");
         setEventMetadata("AFTER TRN","{handler:'E12122',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV13TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'A353DespBodNro',fld:'DESPBODNRO',pic:'ZZZ9'},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9'},{av:'A42BodCod',fld:'BODCOD',pic:'ZZZ9'},{av:'A22OrdenID',fld:'ORDENID',pic:'ZZZ9'},{av:'AV7empid',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynEmpID'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'AV8ageId',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'dynAgeID'},{av:'A2AgeID',fld:'AGEID',pic:'ZZZ9'}]");
         setEventMetadata("AFTER TRN",",oparms:[{av:'chkDespBodModifItem.Enabled',ctrl:'DESPBODMODIFITEM',prop:'Enabled'},{av:'AV7empid',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynEmpID'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'AV8ageId',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'dynAgeID'},{av:'A2AgeID',fld:'AGEID',pic:'ZZZ9'}]}");
         setEventMetadata("GRIDDESPBODEGA_PRD.ONLINEACTIVATE","{handler:'E13122',iparms:[{av:'A359DespBodADesp',fld:'DESPBODADESP',pic:'ZZZZ9.99'},{av:'AV7empid',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynEmpID'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'AV8ageId',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'dynAgeID'},{av:'A2AgeID',fld:'AGEID',pic:'ZZZ9'}]");
         setEventMetadata("GRIDDESPBODEGA_PRD.ONLINEACTIVATE",",oparms:[{av:'AV19despachado',fld:'vDESPACHADO',pic:''},{av:'edtavDespachado_Tooltiptext',ctrl:'vDESPACHADO',prop:'Tooltiptext'},{av:'AV7empid',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynEmpID'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'AV8ageId',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'dynAgeID'},{av:'A2AgeID',fld:'AGEID',pic:'ZZZ9'}]}");
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
         pr_default.close(32);
         pr_default.close(19);
         pr_default.close(33);
         pr_default.close(20);
         pr_default.close(34);
         pr_default.close(22);
         pr_default.close(35);
         pr_default.close(21);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         wcpOAV20usuCod = "";
         Z402DespachadoOK = "";
         Z356DespBodPrdNombre = "";
         Z376DespBodDetalle = "";
         Z392DespBodOK = "";
         Z403DespBodModifItem = "";
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
         lblTabpage2_title_Jsonclick = "";
         sImgUrl = "";
         A56ClienteRUC = "";
         A57ClienteDsc = "";
         lblTabpage1_title_Jsonclick = "";
         A217BodDsc = "";
         A402DespachadoOK = "";
         lblTitleprd_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Griddespbodega_prdContainer = new GXWebGrid( context);
         Griddespbodega_prdColumn = new GXWebColumn();
         A356DespBodPrdNombre = "";
         A376DespBodDetalle = "";
         A403DespBodModifItem = "";
         AV19despachado = "";
         A392DespBodOK = "";
         sMode94 = "";
         sStyleString = "";
         A44empdsc = "";
         A46AgeDsc = "";
         AV23Pgmname = "";
         Tab1_Objectcall = "";
         Tab1_Activepagecontrolname = "";
         GXCCtl = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode93 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV13TrnContext = new SdtTransactionContext(context);
         AV14WebSession = context.GetSession();
         AV16TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV25Despachado_GXI = "";
         Z44empdsc = "";
         Z46AgeDsc = "";
         Z217BodDsc = "";
         Z56ClienteRUC = "";
         Z57ClienteDsc = "";
         T00126_A44empdsc = new String[] {""} ;
         T00126_n44empdsc = new bool[] {false} ;
         T00127_A46AgeDsc = new String[] {""} ;
         T00127_n46AgeDsc = new bool[] {false} ;
         T00128_A56ClienteRUC = new String[] {""} ;
         T00128_n56ClienteRUC = new bool[] {false} ;
         T00128_A57ClienteDsc = new String[] {""} ;
         T00128_n57ClienteDsc = new bool[] {false} ;
         T00129_A217BodDsc = new String[] {""} ;
         T00129_n217BodDsc = new bool[] {false} ;
         T001210_A353DespBodNro = new short[1] ;
         T001210_A22OrdenID = new short[1] ;
         T001210_A44empdsc = new String[] {""} ;
         T001210_n44empdsc = new bool[] {false} ;
         T001210_A46AgeDsc = new String[] {""} ;
         T001210_n46AgeDsc = new bool[] {false} ;
         T001210_A217BodDsc = new String[] {""} ;
         T001210_n217BodDsc = new bool[] {false} ;
         T001210_A56ClienteRUC = new String[] {""} ;
         T001210_n56ClienteRUC = new bool[] {false} ;
         T001210_A57ClienteDsc = new String[] {""} ;
         T001210_n57ClienteDsc = new bool[] {false} ;
         T001210_A399DespBodUltReg = new int[1] ;
         T001210_n399DespBodUltReg = new bool[] {false} ;
         T001210_A402DespachadoOK = new String[] {""} ;
         T001210_n402DespachadoOK = new bool[] {false} ;
         T001210_A1EmpID = new short[1] ;
         T001210_A2AgeID = new short[1] ;
         T001210_A5ClienteID = new short[1] ;
         T001210_A42BodCod = new short[1] ;
         T001211_A44empdsc = new String[] {""} ;
         T001211_n44empdsc = new bool[] {false} ;
         T001212_A217BodDsc = new String[] {""} ;
         T001212_n217BodDsc = new bool[] {false} ;
         T001213_A46AgeDsc = new String[] {""} ;
         T001213_n46AgeDsc = new bool[] {false} ;
         T001214_A56ClienteRUC = new String[] {""} ;
         T001214_n56ClienteRUC = new bool[] {false} ;
         T001214_A57ClienteDsc = new String[] {""} ;
         T001214_n57ClienteDsc = new bool[] {false} ;
         T001215_A1EmpID = new short[1] ;
         T001215_A2AgeID = new short[1] ;
         T001215_A353DespBodNro = new short[1] ;
         T001215_A22OrdenID = new short[1] ;
         T001215_A5ClienteID = new short[1] ;
         T00125_A353DespBodNro = new short[1] ;
         T00125_A22OrdenID = new short[1] ;
         T00125_A399DespBodUltReg = new int[1] ;
         T00125_n399DespBodUltReg = new bool[] {false} ;
         T00125_A402DespachadoOK = new String[] {""} ;
         T00125_n402DespachadoOK = new bool[] {false} ;
         T00125_A1EmpID = new short[1] ;
         T00125_A2AgeID = new short[1] ;
         T00125_A5ClienteID = new short[1] ;
         T00125_A42BodCod = new short[1] ;
         T001216_A1EmpID = new short[1] ;
         T001216_A2AgeID = new short[1] ;
         T001216_A353DespBodNro = new short[1] ;
         T001216_A22OrdenID = new short[1] ;
         T001216_A5ClienteID = new short[1] ;
         T001217_A1EmpID = new short[1] ;
         T001217_A2AgeID = new short[1] ;
         T001217_A353DespBodNro = new short[1] ;
         T001217_A22OrdenID = new short[1] ;
         T001217_A5ClienteID = new short[1] ;
         T00124_A353DespBodNro = new short[1] ;
         T00124_A22OrdenID = new short[1] ;
         T00124_A399DespBodUltReg = new int[1] ;
         T00124_n399DespBodUltReg = new bool[] {false} ;
         T00124_A402DespachadoOK = new String[] {""} ;
         T00124_n402DespachadoOK = new bool[] {false} ;
         T00124_A1EmpID = new short[1] ;
         T00124_A2AgeID = new short[1] ;
         T00124_A5ClienteID = new short[1] ;
         T00124_A42BodCod = new short[1] ;
         T001221_A44empdsc = new String[] {""} ;
         T001221_n44empdsc = new bool[] {false} ;
         T001222_A46AgeDsc = new String[] {""} ;
         T001222_n46AgeDsc = new bool[] {false} ;
         T001223_A217BodDsc = new String[] {""} ;
         T001223_n217BodDsc = new bool[] {false} ;
         T001224_A56ClienteRUC = new String[] {""} ;
         T001224_n56ClienteRUC = new bool[] {false} ;
         T001224_A57ClienteDsc = new String[] {""} ;
         T001224_n57ClienteDsc = new bool[] {false} ;
         T001225_A1EmpID = new short[1] ;
         T001225_A2AgeID = new short[1] ;
         T001225_A353DespBodNro = new short[1] ;
         T001225_A22OrdenID = new short[1] ;
         T001225_A5ClienteID = new short[1] ;
         T001226_A1EmpID = new short[1] ;
         T001226_A2AgeID = new short[1] ;
         T001226_A353DespBodNro = new short[1] ;
         T001226_A22OrdenID = new short[1] ;
         T001226_A5ClienteID = new short[1] ;
         T001226_A400nroReg = new int[1] ;
         T001226_A355DespBodCodPrd = new short[1] ;
         T001226_n355DespBodCodPrd = new bool[] {false} ;
         T001226_A356DespBodPrdNombre = new String[] {""} ;
         T001226_n356DespBodPrdNombre = new bool[] {false} ;
         T001226_A357DespBodCant = new decimal[1] ;
         T001226_n357DespBodCant = new bool[] {false} ;
         T001226_A358DespBodValor = new decimal[1] ;
         T001226_n358DespBodValor = new bool[] {false} ;
         T001226_A359DespBodADesp = new decimal[1] ;
         T001226_n359DespBodADesp = new bool[] {false} ;
         T001226_A376DespBodDetalle = new String[] {""} ;
         T001226_n376DespBodDetalle = new bool[] {false} ;
         T001226_A361DespBodCatId = new short[1] ;
         T001226_n361DespBodCatId = new bool[] {false} ;
         T001226_A392DespBodOK = new String[] {""} ;
         T001226_n392DespBodOK = new bool[] {false} ;
         T001226_A403DespBodModifItem = new String[] {""} ;
         T001226_n403DespBodModifItem = new bool[] {false} ;
         T001227_A1EmpID = new short[1] ;
         T001227_A2AgeID = new short[1] ;
         T001227_A353DespBodNro = new short[1] ;
         T001227_A22OrdenID = new short[1] ;
         T001227_A5ClienteID = new short[1] ;
         T001227_A400nroReg = new int[1] ;
         T00123_A1EmpID = new short[1] ;
         T00123_A2AgeID = new short[1] ;
         T00123_A353DespBodNro = new short[1] ;
         T00123_A22OrdenID = new short[1] ;
         T00123_A5ClienteID = new short[1] ;
         T00123_A400nroReg = new int[1] ;
         T00123_A355DespBodCodPrd = new short[1] ;
         T00123_n355DespBodCodPrd = new bool[] {false} ;
         T00123_A356DespBodPrdNombre = new String[] {""} ;
         T00123_n356DespBodPrdNombre = new bool[] {false} ;
         T00123_A357DespBodCant = new decimal[1] ;
         T00123_n357DespBodCant = new bool[] {false} ;
         T00123_A358DespBodValor = new decimal[1] ;
         T00123_n358DespBodValor = new bool[] {false} ;
         T00123_A359DespBodADesp = new decimal[1] ;
         T00123_n359DespBodADesp = new bool[] {false} ;
         T00123_A376DespBodDetalle = new String[] {""} ;
         T00123_n376DespBodDetalle = new bool[] {false} ;
         T00123_A361DespBodCatId = new short[1] ;
         T00123_n361DespBodCatId = new bool[] {false} ;
         T00123_A392DespBodOK = new String[] {""} ;
         T00123_n392DespBodOK = new bool[] {false} ;
         T00123_A403DespBodModifItem = new String[] {""} ;
         T00123_n403DespBodModifItem = new bool[] {false} ;
         T00122_A1EmpID = new short[1] ;
         T00122_A2AgeID = new short[1] ;
         T00122_A353DespBodNro = new short[1] ;
         T00122_A22OrdenID = new short[1] ;
         T00122_A5ClienteID = new short[1] ;
         T00122_A400nroReg = new int[1] ;
         T00122_A355DespBodCodPrd = new short[1] ;
         T00122_n355DespBodCodPrd = new bool[] {false} ;
         T00122_A356DespBodPrdNombre = new String[] {""} ;
         T00122_n356DespBodPrdNombre = new bool[] {false} ;
         T00122_A357DespBodCant = new decimal[1] ;
         T00122_n357DespBodCant = new bool[] {false} ;
         T00122_A358DespBodValor = new decimal[1] ;
         T00122_n358DespBodValor = new bool[] {false} ;
         T00122_A359DespBodADesp = new decimal[1] ;
         T00122_n359DespBodADesp = new bool[] {false} ;
         T00122_A376DespBodDetalle = new String[] {""} ;
         T00122_n376DespBodDetalle = new bool[] {false} ;
         T00122_A361DespBodCatId = new short[1] ;
         T00122_n361DespBodCatId = new bool[] {false} ;
         T00122_A392DespBodOK = new String[] {""} ;
         T00122_n392DespBodOK = new bool[] {false} ;
         T00122_A403DespBodModifItem = new String[] {""} ;
         T00122_n403DespBodModifItem = new bool[] {false} ;
         T001231_A1EmpID = new short[1] ;
         T001231_A2AgeID = new short[1] ;
         T001231_A353DespBodNro = new short[1] ;
         T001231_A22OrdenID = new short[1] ;
         T001231_A5ClienteID = new short[1] ;
         T001231_A400nroReg = new int[1] ;
         Griddespbodega_prdRow = new GXWebRow();
         subGriddespbodega_prd_Linesclass = "";
         ROClassString = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         T001232_A1EmpID = new short[1] ;
         T001232_A44empdsc = new String[] {""} ;
         T001232_n44empdsc = new bool[] {false} ;
         T001233_A1EmpID = new short[1] ;
         T001233_A2AgeID = new short[1] ;
         T001233_A46AgeDsc = new String[] {""} ;
         T001233_n46AgeDsc = new bool[] {false} ;
         T001234_A44empdsc = new String[] {""} ;
         T001234_n44empdsc = new bool[] {false} ;
         isValidOutput = new GxUnknownObjectCollection();
         T001235_A46AgeDsc = new String[] {""} ;
         T001235_n46AgeDsc = new bool[] {false} ;
         T001236_A56ClienteRUC = new String[] {""} ;
         T001236_n56ClienteRUC = new bool[] {false} ;
         T001236_A57ClienteDsc = new String[] {""} ;
         T001236_n57ClienteDsc = new bool[] {false} ;
         T001237_A217BodDsc = new String[] {""} ;
         T001237_n217BodDsc = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.despbodega__default(),
            new Object[][] {
                new Object[] {
               T00122_A1EmpID, T00122_A2AgeID, T00122_A353DespBodNro, T00122_A22OrdenID, T00122_A5ClienteID, T00122_A400nroReg, T00122_A355DespBodCodPrd, T00122_n355DespBodCodPrd, T00122_A356DespBodPrdNombre, T00122_n356DespBodPrdNombre,
               T00122_A357DespBodCant, T00122_n357DespBodCant, T00122_A358DespBodValor, T00122_n358DespBodValor, T00122_A359DespBodADesp, T00122_n359DespBodADesp, T00122_A376DespBodDetalle, T00122_n376DespBodDetalle, T00122_A361DespBodCatId, T00122_n361DespBodCatId,
               T00122_A392DespBodOK, T00122_n392DespBodOK, T00122_A403DespBodModifItem, T00122_n403DespBodModifItem
               }
               , new Object[] {
               T00123_A1EmpID, T00123_A2AgeID, T00123_A353DespBodNro, T00123_A22OrdenID, T00123_A5ClienteID, T00123_A400nroReg, T00123_A355DespBodCodPrd, T00123_n355DespBodCodPrd, T00123_A356DespBodPrdNombre, T00123_n356DespBodPrdNombre,
               T00123_A357DespBodCant, T00123_n357DespBodCant, T00123_A358DespBodValor, T00123_n358DespBodValor, T00123_A359DespBodADesp, T00123_n359DespBodADesp, T00123_A376DespBodDetalle, T00123_n376DespBodDetalle, T00123_A361DespBodCatId, T00123_n361DespBodCatId,
               T00123_A392DespBodOK, T00123_n392DespBodOK, T00123_A403DespBodModifItem, T00123_n403DespBodModifItem
               }
               , new Object[] {
               T00124_A353DespBodNro, T00124_A22OrdenID, T00124_A399DespBodUltReg, T00124_n399DespBodUltReg, T00124_A402DespachadoOK, T00124_n402DespachadoOK, T00124_A1EmpID, T00124_A2AgeID, T00124_A5ClienteID, T00124_A42BodCod
               }
               , new Object[] {
               T00125_A353DespBodNro, T00125_A22OrdenID, T00125_A399DespBodUltReg, T00125_n399DespBodUltReg, T00125_A402DespachadoOK, T00125_n402DespachadoOK, T00125_A1EmpID, T00125_A2AgeID, T00125_A5ClienteID, T00125_A42BodCod
               }
               , new Object[] {
               T00126_A44empdsc, T00126_n44empdsc
               }
               , new Object[] {
               T00127_A46AgeDsc, T00127_n46AgeDsc
               }
               , new Object[] {
               T00128_A56ClienteRUC, T00128_n56ClienteRUC, T00128_A57ClienteDsc, T00128_n57ClienteDsc
               }
               , new Object[] {
               T00129_A217BodDsc, T00129_n217BodDsc
               }
               , new Object[] {
               T001210_A353DespBodNro, T001210_A22OrdenID, T001210_A44empdsc, T001210_n44empdsc, T001210_A46AgeDsc, T001210_n46AgeDsc, T001210_A217BodDsc, T001210_n217BodDsc, T001210_A56ClienteRUC, T001210_n56ClienteRUC,
               T001210_A57ClienteDsc, T001210_n57ClienteDsc, T001210_A399DespBodUltReg, T001210_n399DespBodUltReg, T001210_A402DespachadoOK, T001210_n402DespachadoOK, T001210_A1EmpID, T001210_A2AgeID, T001210_A5ClienteID, T001210_A42BodCod
               }
               , new Object[] {
               T001211_A44empdsc, T001211_n44empdsc
               }
               , new Object[] {
               T001212_A217BodDsc, T001212_n217BodDsc
               }
               , new Object[] {
               T001213_A46AgeDsc, T001213_n46AgeDsc
               }
               , new Object[] {
               T001214_A56ClienteRUC, T001214_n56ClienteRUC, T001214_A57ClienteDsc, T001214_n57ClienteDsc
               }
               , new Object[] {
               T001215_A1EmpID, T001215_A2AgeID, T001215_A353DespBodNro, T001215_A22OrdenID, T001215_A5ClienteID
               }
               , new Object[] {
               T001216_A1EmpID, T001216_A2AgeID, T001216_A353DespBodNro, T001216_A22OrdenID, T001216_A5ClienteID
               }
               , new Object[] {
               T001217_A1EmpID, T001217_A2AgeID, T001217_A353DespBodNro, T001217_A22OrdenID, T001217_A5ClienteID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001221_A44empdsc, T001221_n44empdsc
               }
               , new Object[] {
               T001222_A46AgeDsc, T001222_n46AgeDsc
               }
               , new Object[] {
               T001223_A217BodDsc, T001223_n217BodDsc
               }
               , new Object[] {
               T001224_A56ClienteRUC, T001224_n56ClienteRUC, T001224_A57ClienteDsc, T001224_n57ClienteDsc
               }
               , new Object[] {
               T001225_A1EmpID, T001225_A2AgeID, T001225_A353DespBodNro, T001225_A22OrdenID, T001225_A5ClienteID
               }
               , new Object[] {
               T001226_A1EmpID, T001226_A2AgeID, T001226_A353DespBodNro, T001226_A22OrdenID, T001226_A5ClienteID, T001226_A400nroReg, T001226_A355DespBodCodPrd, T001226_n355DespBodCodPrd, T001226_A356DespBodPrdNombre, T001226_n356DespBodPrdNombre,
               T001226_A357DespBodCant, T001226_n357DespBodCant, T001226_A358DespBodValor, T001226_n358DespBodValor, T001226_A359DespBodADesp, T001226_n359DespBodADesp, T001226_A376DespBodDetalle, T001226_n376DespBodDetalle, T001226_A361DespBodCatId, T001226_n361DespBodCatId,
               T001226_A392DespBodOK, T001226_n392DespBodOK, T001226_A403DespBodModifItem, T001226_n403DespBodModifItem
               }
               , new Object[] {
               T001227_A1EmpID, T001227_A2AgeID, T001227_A353DespBodNro, T001227_A22OrdenID, T001227_A5ClienteID, T001227_A400nroReg
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001231_A1EmpID, T001231_A2AgeID, T001231_A353DespBodNro, T001231_A22OrdenID, T001231_A5ClienteID, T001231_A400nroReg
               }
               , new Object[] {
               T001232_A1EmpID, T001232_A44empdsc, T001232_n44empdsc
               }
               , new Object[] {
               T001233_A1EmpID, T001233_A2AgeID, T001233_A46AgeDsc, T001233_n46AgeDsc
               }
               , new Object[] {
               T001234_A44empdsc, T001234_n44empdsc
               }
               , new Object[] {
               T001235_A46AgeDsc, T001235_n46AgeDsc
               }
               , new Object[] {
               T001236_A56ClienteRUC, T001236_n56ClienteRUC, T001236_A57ClienteDsc, T001236_n57ClienteDsc
               }
               , new Object[] {
               T001237_A217BodDsc, T001237_n217BodDsc
               }
            }
         );
         AV23Pgmname = "DespBodega";
      }

      private short wcpOAV7empid ;
      private short wcpOAV8ageId ;
      private short wcpOAV10DespBodNro ;
      private short wcpOAV17OrdenID ;
      private short wcpOAV21clienteID ;
      private short Z1EmpID ;
      private short Z2AgeID ;
      private short Z353DespBodNro ;
      private short Z22OrdenID ;
      private short Z5ClienteID ;
      private short Z42BodCod ;
      private short nRC_GXsfl_108 ;
      private short nGXsfl_108_idx=1 ;
      private short N42BodCod ;
      private short Z355DespBodCodPrd ;
      private short Z361DespBodCatId ;
      private short nRcdDeleted_94 ;
      private short nRcdExists_94 ;
      private short nIsMod_94 ;
      private short GxWebError ;
      private short AV7empid ;
      private short AV8ageId ;
      private short A1EmpID ;
      private short A2AgeID ;
      private short A42BodCod ;
      private short A355DespBodCodPrd ;
      private short A5ClienteID ;
      private short AV10DespBodNro ;
      private short AV17OrdenID ;
      private short AV21clienteID ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short A22OrdenID ;
      private short A353DespBodNro ;
      private short subGriddespbodega_prd_Backcolorstyle ;
      private short subGriddespbodega_prd_Sortable ;
      private short A361DespBodCatId ;
      private short A362DespBodDif ;
      private short subGriddespbodega_prd_Allowselection ;
      private short subGriddespbodega_prd_Allowhovering ;
      private short subGriddespbodega_prd_Allowcollapsing ;
      private short subGriddespbodega_prd_Collapsed ;
      private short nBlankRcdCount94 ;
      private short RcdFound94 ;
      private short nBlankRcdUsr94 ;
      private short AV15Insert_BodCod ;
      private short RcdFound93 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short subGriddespbodega_prd_Backstyle ;
      private short wbTemp ;
      private int Z399DespBodUltReg ;
      private int Z400nroReg ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtOrdenID_Enabled ;
      private int edtDespBodNro_Enabled ;
      private int edtClienteID_Enabled ;
      private int imgprompt_5_Visible ;
      private int edtClienteRUC_Enabled ;
      private int edtClienteDsc_Enabled ;
      private int edtBodCod_Enabled ;
      private int imgprompt_42_Visible ;
      private int edtBodDsc_Enabled ;
      private int edtDespBodUltReg_Visible ;
      private int A399DespBodUltReg ;
      private int edtDespBodUltReg_Enabled ;
      private int divPrdtable_Visible ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int A400nroReg ;
      private int edtnroReg_Enabled ;
      private int edtDespBodCodPrd_Enabled ;
      private int edtDespBodPrdNombre_Enabled ;
      private int edtDespBodCant_Enabled ;
      private int edtDespBodValor_Enabled ;
      private int edtDespBodADesp_Enabled ;
      private int edtDespBodDetalle_Enabled ;
      private int edtDespBodStock_Enabled ;
      private int edtDespBodCatId_Enabled ;
      private int edtDespBodDif_Enabled ;
      private int edtavDespachado_Enabled ;
      private int edtavDespachado_Visible ;
      private int edtDespBodOK_Enabled ;
      private int subGriddespbodega_prd_Selectedindex ;
      private int subGriddespbodega_prd_Selectioncolor ;
      private int subGriddespbodega_prd_Hoveringcolor ;
      private int fRowAdded ;
      private int Tab1_Activepage ;
      private int Tab1_Pagecount ;
      private int AV24GXV1 ;
      private int subGriddespbodega_prd_Backcolor ;
      private int subGriddespbodega_prd_Allbackcolor ;
      private int defedtDespBodOK_Enabled ;
      private int defedtDespBodCatId_Enabled ;
      private int defedtDespBodDetalle_Enabled ;
      private int defedtDespBodValor_Enabled ;
      private int defedtDespBodCant_Enabled ;
      private int defedtDespBodPrdNombre_Enabled ;
      private int defedtnroReg_Enabled ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private long GRIDDESPBODEGA_PRD_nFirstRecordOnPage ;
      private decimal Z357DespBodCant ;
      private decimal Z358DespBodValor ;
      private decimal Z359DespBodADesp ;
      private decimal A357DespBodCant ;
      private decimal A358DespBodValor ;
      private decimal A359DespBodADesp ;
      private decimal A360DespBodStock ;
      private decimal GXt_decimal1 ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String wcpOAV20usuCod ;
      private String Z402DespachadoOK ;
      private String Z356DespBodPrdNombre ;
      private String Z376DespBodDetalle ;
      private String Z392DespBodOK ;
      private String Z403DespBodModifItem ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_108_idx="0001" ;
      private String Gx_mode ;
      private String AV20usuCod ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String dynEmpID_Internalname ;
      private String dynAgeID_Internalname ;
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
      private String divSection1_Internalname ;
      private String dynEmpID_Jsonclick ;
      private String divSection2_Internalname ;
      private String dynAgeID_Jsonclick ;
      private String divSection3_Internalname ;
      private String edtOrdenID_Internalname ;
      private String edtOrdenID_Jsonclick ;
      private String divSection4_Internalname ;
      private String edtDespBodNro_Internalname ;
      private String edtDespBodNro_Jsonclick ;
      private String lblTabpage2_title_Internalname ;
      private String lblTabpage2_title_Jsonclick ;
      private String divTabpage2table_Internalname ;
      private String divTable2_Internalname ;
      private String edtClienteID_Internalname ;
      private String edtClienteID_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_5_Internalname ;
      private String imgprompt_5_Link ;
      private String edtClienteRUC_Internalname ;
      private String A56ClienteRUC ;
      private String edtClienteRUC_Jsonclick ;
      private String edtClienteDsc_Internalname ;
      private String A57ClienteDsc ;
      private String edtClienteDsc_Jsonclick ;
      private String lblTabpage1_title_Internalname ;
      private String lblTabpage1_title_Jsonclick ;
      private String divTabpage1table_Internalname ;
      private String divTable1_Internalname ;
      private String edtBodCod_Internalname ;
      private String edtBodCod_Jsonclick ;
      private String imgprompt_42_Internalname ;
      private String imgprompt_42_Link ;
      private String edtBodDsc_Internalname ;
      private String A217BodDsc ;
      private String edtBodDsc_Jsonclick ;
      private String chkDespachadoOK_Internalname ;
      private String A402DespachadoOK ;
      private String edtDespBodUltReg_Internalname ;
      private String edtDespBodUltReg_Jsonclick ;
      private String divPrdtable_Internalname ;
      private String lblTitleprd_Internalname ;
      private String lblTitleprd_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGriddespbodega_prd_Header ;
      private String A356DespBodPrdNombre ;
      private String A376DespBodDetalle ;
      private String A403DespBodModifItem ;
      private String edtavDespachado_Tooltiptext ;
      private String A392DespBodOK ;
      private String sMode94 ;
      private String edtnroReg_Internalname ;
      private String edtDespBodCodPrd_Internalname ;
      private String edtDespBodPrdNombre_Internalname ;
      private String edtDespBodCant_Internalname ;
      private String edtDespBodValor_Internalname ;
      private String edtDespBodADesp_Internalname ;
      private String edtDespBodDetalle_Internalname ;
      private String edtDespBodStock_Internalname ;
      private String edtDespBodCatId_Internalname ;
      private String edtDespBodDif_Internalname ;
      private String chkDespBodModifItem_Internalname ;
      private String edtavDespachado_Internalname ;
      private String edtDespBodOK_Internalname ;
      private String sStyleString ;
      private String A46AgeDsc ;
      private String AV23Pgmname ;
      private String Tab1_Objectcall ;
      private String Tab1_Class ;
      private String Tab1_Activepagecontrolname ;
      private String subGriddespbodega_prd_Internalname ;
      private String GXCCtl ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode93 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z46AgeDsc ;
      private String Z217BodDsc ;
      private String Z56ClienteRUC ;
      private String Z57ClienteDsc ;
      private String sGXsfl_108_fel_idx="0001" ;
      private String subGriddespbodega_prd_Class ;
      private String subGriddespbodega_prd_Linesclass ;
      private String ROClassString ;
      private String edtnroReg_Jsonclick ;
      private String edtDespBodCodPrd_Jsonclick ;
      private String edtDespBodPrdNombre_Jsonclick ;
      private String edtDespBodCant_Jsonclick ;
      private String edtDespBodValor_Jsonclick ;
      private String edtDespBodADesp_Jsonclick ;
      private String edtDespBodDetalle_Jsonclick ;
      private String edtDespBodStock_Jsonclick ;
      private String edtDespBodCatId_Jsonclick ;
      private String edtDespBodDif_Jsonclick ;
      private String edtDespBodOK_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String Tab1_Internalname ;
      private String gxwrpcisep ;
      private bool entryPointCalled ;
      private bool n355DespBodCodPrd ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool bGXsfl_108_Refreshing=false ;
      private bool n56ClienteRUC ;
      private bool n57ClienteDsc ;
      private bool n217BodDsc ;
      private bool n402DespachadoOK ;
      private bool n399DespBodUltReg ;
      private bool n44empdsc ;
      private bool n46AgeDsc ;
      private bool Tab1_Enabled ;
      private bool Tab1_Historymanagement ;
      private bool Tab1_Visible ;
      private bool n356DespBodPrdNombre ;
      private bool n357DespBodCant ;
      private bool n358DespBodValor ;
      private bool n359DespBodADesp ;
      private bool n376DespBodDetalle ;
      private bool n361DespBodCatId ;
      private bool n403DespBodModifItem ;
      private bool n392DespBodOK ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private bool AV19despachado_IsBlob ;
      private bool gxdyncontrolsrefreshing ;
      private String A44empdsc ;
      private String AV25Despachado_GXI ;
      private String Z44empdsc ;
      private String AV19despachado ;
      private IGxSession AV14WebSession ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebGrid Griddespbodega_prdContainer ;
      private GXWebRow Griddespbodega_prdRow ;
      private GXWebColumn Griddespbodega_prdColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynEmpID ;
      private GXCombobox dynAgeID ;
      private GXCheckbox chkDespachadoOK ;
      private GXCheckbox chkDespBodModifItem ;
      private IDataStoreProvider pr_default ;
      private String[] T00126_A44empdsc ;
      private bool[] T00126_n44empdsc ;
      private String[] T00127_A46AgeDsc ;
      private bool[] T00127_n46AgeDsc ;
      private String[] T00128_A56ClienteRUC ;
      private bool[] T00128_n56ClienteRUC ;
      private String[] T00128_A57ClienteDsc ;
      private bool[] T00128_n57ClienteDsc ;
      private String[] T00129_A217BodDsc ;
      private bool[] T00129_n217BodDsc ;
      private short[] T001210_A353DespBodNro ;
      private short[] T001210_A22OrdenID ;
      private String[] T001210_A44empdsc ;
      private bool[] T001210_n44empdsc ;
      private String[] T001210_A46AgeDsc ;
      private bool[] T001210_n46AgeDsc ;
      private String[] T001210_A217BodDsc ;
      private bool[] T001210_n217BodDsc ;
      private String[] T001210_A56ClienteRUC ;
      private bool[] T001210_n56ClienteRUC ;
      private String[] T001210_A57ClienteDsc ;
      private bool[] T001210_n57ClienteDsc ;
      private int[] T001210_A399DespBodUltReg ;
      private bool[] T001210_n399DespBodUltReg ;
      private String[] T001210_A402DespachadoOK ;
      private bool[] T001210_n402DespachadoOK ;
      private short[] T001210_A1EmpID ;
      private short[] T001210_A2AgeID ;
      private short[] T001210_A5ClienteID ;
      private short[] T001210_A42BodCod ;
      private String[] T001211_A44empdsc ;
      private bool[] T001211_n44empdsc ;
      private String[] T001212_A217BodDsc ;
      private bool[] T001212_n217BodDsc ;
      private String[] T001213_A46AgeDsc ;
      private bool[] T001213_n46AgeDsc ;
      private String[] T001214_A56ClienteRUC ;
      private bool[] T001214_n56ClienteRUC ;
      private String[] T001214_A57ClienteDsc ;
      private bool[] T001214_n57ClienteDsc ;
      private short[] T001215_A1EmpID ;
      private short[] T001215_A2AgeID ;
      private short[] T001215_A353DespBodNro ;
      private short[] T001215_A22OrdenID ;
      private short[] T001215_A5ClienteID ;
      private short[] T00125_A353DespBodNro ;
      private short[] T00125_A22OrdenID ;
      private int[] T00125_A399DespBodUltReg ;
      private bool[] T00125_n399DespBodUltReg ;
      private String[] T00125_A402DespachadoOK ;
      private bool[] T00125_n402DespachadoOK ;
      private short[] T00125_A1EmpID ;
      private short[] T00125_A2AgeID ;
      private short[] T00125_A5ClienteID ;
      private short[] T00125_A42BodCod ;
      private short[] T001216_A1EmpID ;
      private short[] T001216_A2AgeID ;
      private short[] T001216_A353DespBodNro ;
      private short[] T001216_A22OrdenID ;
      private short[] T001216_A5ClienteID ;
      private short[] T001217_A1EmpID ;
      private short[] T001217_A2AgeID ;
      private short[] T001217_A353DespBodNro ;
      private short[] T001217_A22OrdenID ;
      private short[] T001217_A5ClienteID ;
      private short[] T00124_A353DespBodNro ;
      private short[] T00124_A22OrdenID ;
      private int[] T00124_A399DespBodUltReg ;
      private bool[] T00124_n399DespBodUltReg ;
      private String[] T00124_A402DespachadoOK ;
      private bool[] T00124_n402DespachadoOK ;
      private short[] T00124_A1EmpID ;
      private short[] T00124_A2AgeID ;
      private short[] T00124_A5ClienteID ;
      private short[] T00124_A42BodCod ;
      private String[] T001221_A44empdsc ;
      private bool[] T001221_n44empdsc ;
      private String[] T001222_A46AgeDsc ;
      private bool[] T001222_n46AgeDsc ;
      private String[] T001223_A217BodDsc ;
      private bool[] T001223_n217BodDsc ;
      private String[] T001224_A56ClienteRUC ;
      private bool[] T001224_n56ClienteRUC ;
      private String[] T001224_A57ClienteDsc ;
      private bool[] T001224_n57ClienteDsc ;
      private short[] T001225_A1EmpID ;
      private short[] T001225_A2AgeID ;
      private short[] T001225_A353DespBodNro ;
      private short[] T001225_A22OrdenID ;
      private short[] T001225_A5ClienteID ;
      private short[] T001226_A1EmpID ;
      private short[] T001226_A2AgeID ;
      private short[] T001226_A353DespBodNro ;
      private short[] T001226_A22OrdenID ;
      private short[] T001226_A5ClienteID ;
      private int[] T001226_A400nroReg ;
      private short[] T001226_A355DespBodCodPrd ;
      private bool[] T001226_n355DespBodCodPrd ;
      private String[] T001226_A356DespBodPrdNombre ;
      private bool[] T001226_n356DespBodPrdNombre ;
      private decimal[] T001226_A357DespBodCant ;
      private bool[] T001226_n357DespBodCant ;
      private decimal[] T001226_A358DespBodValor ;
      private bool[] T001226_n358DespBodValor ;
      private decimal[] T001226_A359DespBodADesp ;
      private bool[] T001226_n359DespBodADesp ;
      private String[] T001226_A376DespBodDetalle ;
      private bool[] T001226_n376DespBodDetalle ;
      private short[] T001226_A361DespBodCatId ;
      private bool[] T001226_n361DespBodCatId ;
      private String[] T001226_A392DespBodOK ;
      private bool[] T001226_n392DespBodOK ;
      private String[] T001226_A403DespBodModifItem ;
      private bool[] T001226_n403DespBodModifItem ;
      private short[] T001227_A1EmpID ;
      private short[] T001227_A2AgeID ;
      private short[] T001227_A353DespBodNro ;
      private short[] T001227_A22OrdenID ;
      private short[] T001227_A5ClienteID ;
      private int[] T001227_A400nroReg ;
      private short[] T00123_A1EmpID ;
      private short[] T00123_A2AgeID ;
      private short[] T00123_A353DespBodNro ;
      private short[] T00123_A22OrdenID ;
      private short[] T00123_A5ClienteID ;
      private int[] T00123_A400nroReg ;
      private short[] T00123_A355DespBodCodPrd ;
      private bool[] T00123_n355DespBodCodPrd ;
      private String[] T00123_A356DespBodPrdNombre ;
      private bool[] T00123_n356DespBodPrdNombre ;
      private decimal[] T00123_A357DespBodCant ;
      private bool[] T00123_n357DespBodCant ;
      private decimal[] T00123_A358DespBodValor ;
      private bool[] T00123_n358DespBodValor ;
      private decimal[] T00123_A359DespBodADesp ;
      private bool[] T00123_n359DespBodADesp ;
      private String[] T00123_A376DespBodDetalle ;
      private bool[] T00123_n376DespBodDetalle ;
      private short[] T00123_A361DespBodCatId ;
      private bool[] T00123_n361DespBodCatId ;
      private String[] T00123_A392DespBodOK ;
      private bool[] T00123_n392DespBodOK ;
      private String[] T00123_A403DespBodModifItem ;
      private bool[] T00123_n403DespBodModifItem ;
      private short[] T00122_A1EmpID ;
      private short[] T00122_A2AgeID ;
      private short[] T00122_A353DespBodNro ;
      private short[] T00122_A22OrdenID ;
      private short[] T00122_A5ClienteID ;
      private int[] T00122_A400nroReg ;
      private short[] T00122_A355DespBodCodPrd ;
      private bool[] T00122_n355DespBodCodPrd ;
      private String[] T00122_A356DespBodPrdNombre ;
      private bool[] T00122_n356DespBodPrdNombre ;
      private decimal[] T00122_A357DespBodCant ;
      private bool[] T00122_n357DespBodCant ;
      private decimal[] T00122_A358DespBodValor ;
      private bool[] T00122_n358DespBodValor ;
      private decimal[] T00122_A359DespBodADesp ;
      private bool[] T00122_n359DespBodADesp ;
      private String[] T00122_A376DespBodDetalle ;
      private bool[] T00122_n376DespBodDetalle ;
      private short[] T00122_A361DespBodCatId ;
      private bool[] T00122_n361DespBodCatId ;
      private String[] T00122_A392DespBodOK ;
      private bool[] T00122_n392DespBodOK ;
      private String[] T00122_A403DespBodModifItem ;
      private bool[] T00122_n403DespBodModifItem ;
      private short[] T001231_A1EmpID ;
      private short[] T001231_A2AgeID ;
      private short[] T001231_A353DespBodNro ;
      private short[] T001231_A22OrdenID ;
      private short[] T001231_A5ClienteID ;
      private int[] T001231_A400nroReg ;
      private short[] T001232_A1EmpID ;
      private String[] T001232_A44empdsc ;
      private bool[] T001232_n44empdsc ;
      private short[] T001233_A1EmpID ;
      private short[] T001233_A2AgeID ;
      private String[] T001233_A46AgeDsc ;
      private bool[] T001233_n46AgeDsc ;
      private String[] T001234_A44empdsc ;
      private bool[] T001234_n44empdsc ;
      private String[] T001235_A46AgeDsc ;
      private bool[] T001235_n46AgeDsc ;
      private String[] T001236_A56ClienteRUC ;
      private bool[] T001236_n56ClienteRUC ;
      private String[] T001236_A57ClienteDsc ;
      private bool[] T001236_n57ClienteDsc ;
      private String[] T001237_A217BodDsc ;
      private bool[] T001237_n217BodDsc ;
      private SdtTransactionContext AV13TrnContext ;
      private SdtTransactionContext_Attribute AV16TrnContextAtt ;
   }

   public class despbodega__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[16])
         ,new UpdateCursor(def[17])
         ,new UpdateCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new ForEachCursor(def[22])
         ,new ForEachCursor(def[23])
         ,new ForEachCursor(def[24])
         ,new ForEachCursor(def[25])
         ,new UpdateCursor(def[26])
         ,new UpdateCursor(def[27])
         ,new UpdateCursor(def[28])
         ,new ForEachCursor(def[29])
         ,new ForEachCursor(def[30])
         ,new ForEachCursor(def[31])
         ,new ForEachCursor(def[32])
         ,new ForEachCursor(def[33])
         ,new ForEachCursor(def[34])
         ,new ForEachCursor(def[35])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT001210 ;
          prmT001210 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00126 ;
          prmT00126 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00129 ;
          prmT00129 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00127 ;
          prmT00127 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00128 ;
          prmT00128 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001211 ;
          prmT001211 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001212 ;
          prmT001212 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001213 ;
          prmT001213 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001214 ;
          prmT001214 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001215 ;
          prmT001215 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00125 ;
          prmT00125 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001216 ;
          prmT001216 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001217 ;
          prmT001217 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00124 ;
          prmT00124 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001218 ;
          prmT001218 = new Object[] {
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodUltReg",SqlDbType.Int,6,0} ,
          new Object[] {"@DespachadoOK",SqlDbType.Char,1,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001219 ;
          prmT001219 = new Object[] {
          new Object[] {"@DespBodUltReg",SqlDbType.Int,6,0} ,
          new Object[] {"@DespachadoOK",SqlDbType.Char,1,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001220 ;
          prmT001220 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001221 ;
          prmT001221 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001222 ;
          prmT001222 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001223 ;
          prmT001223 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001224 ;
          prmT001224 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001225 ;
          prmT001225 = new Object[] {
          } ;
          Object[] prmT001226 ;
          prmT001226 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@nroReg",SqlDbType.Int,6,0}
          } ;
          Object[] prmT001227 ;
          prmT001227 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@nroReg",SqlDbType.Int,6,0}
          } ;
          Object[] prmT00123 ;
          prmT00123 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@nroReg",SqlDbType.Int,6,0}
          } ;
          Object[] prmT00122 ;
          prmT00122 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@nroReg",SqlDbType.Int,6,0}
          } ;
          Object[] prmT001228 ;
          prmT001228 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@nroReg",SqlDbType.Int,6,0} ,
          new Object[] {"@DespBodCodPrd",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodPrdNombre",SqlDbType.Char,40,0} ,
          new Object[] {"@DespBodCant",SqlDbType.Decimal,8,2} ,
          new Object[] {"@DespBodValor",SqlDbType.Decimal,8,2} ,
          new Object[] {"@DespBodADesp",SqlDbType.Decimal,8,2} ,
          new Object[] {"@DespBodDetalle",SqlDbType.Char,50,0} ,
          new Object[] {"@DespBodCatId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodOK",SqlDbType.Char,1,0} ,
          new Object[] {"@DespBodModifItem",SqlDbType.Char,1,0}
          } ;
          Object[] prmT001229 ;
          prmT001229 = new Object[] {
          new Object[] {"@DespBodCodPrd",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodPrdNombre",SqlDbType.Char,40,0} ,
          new Object[] {"@DespBodCant",SqlDbType.Decimal,8,2} ,
          new Object[] {"@DespBodValor",SqlDbType.Decimal,8,2} ,
          new Object[] {"@DespBodADesp",SqlDbType.Decimal,8,2} ,
          new Object[] {"@DespBodDetalle",SqlDbType.Char,50,0} ,
          new Object[] {"@DespBodCatId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodOK",SqlDbType.Char,1,0} ,
          new Object[] {"@DespBodModifItem",SqlDbType.Char,1,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@nroReg",SqlDbType.Int,6,0}
          } ;
          Object[] prmT001230 ;
          prmT001230 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@nroReg",SqlDbType.Int,6,0}
          } ;
          Object[] prmT001231 ;
          prmT001231 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001232 ;
          prmT001232 = new Object[] {
          new Object[] {"@AV7empid",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001233 ;
          prmT001233 = new Object[] {
          new Object[] {"@AV7empid",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8ageId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001234 ;
          prmT001234 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001235 ;
          prmT001235 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001236 ;
          prmT001236 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001237 ;
          prmT001237 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00122", "SELECT [EmpID], [AgeID], [DespBodNro], [OrdenID], [ClienteID], [nroReg], [DespBodCodPrd], [DespBodPrdNombre], [DespBodCant], [DespBodValor], [DespBodADesp], [DespBodDetalle], [DespBodCatId], [DespBodOK], [DespBodModifItem] FROM [DespBodegaprd] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [DespBodNro] = @DespBodNro AND [OrdenID] = @OrdenID AND [ClienteID] = @ClienteID AND [nroReg] = @nroReg ",true, GxErrorMask.GX_NOMASK, false, this,prmT00122,1,0,true,false )
             ,new CursorDef("T00123", "SELECT [EmpID], [AgeID], [DespBodNro], [OrdenID], [ClienteID], [nroReg], [DespBodCodPrd], [DespBodPrdNombre], [DespBodCant], [DespBodValor], [DespBodADesp], [DespBodDetalle], [DespBodCatId], [DespBodOK], [DespBodModifItem] FROM [DespBodegaprd] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [DespBodNro] = @DespBodNro AND [OrdenID] = @OrdenID AND [ClienteID] = @ClienteID AND [nroReg] = @nroReg ",true, GxErrorMask.GX_NOMASK, false, this,prmT00123,1,0,true,false )
             ,new CursorDef("T00124", "SELECT [DespBodNro], [OrdenID], [DespBodUltReg], [DespachadoOK], [EmpID], [AgeID], [ClienteID], [BodCod] FROM [DespBodega] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [DespBodNro] = @DespBodNro AND [OrdenID] = @OrdenID AND [ClienteID] = @ClienteID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00124,1,0,true,false )
             ,new CursorDef("T00125", "SELECT [DespBodNro], [OrdenID], [DespBodUltReg], [DespachadoOK], [EmpID], [AgeID], [ClienteID], [BodCod] FROM [DespBodega] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [DespBodNro] = @DespBodNro AND [OrdenID] = @OrdenID AND [ClienteID] = @ClienteID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00125,1,0,true,false )
             ,new CursorDef("T00126", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00126,1,0,true,false )
             ,new CursorDef("T00127", "SELECT [AgeDsc] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00127,1,0,true,false )
             ,new CursorDef("T00128", "SELECT [ClienteRUC], [ClienteDsc] FROM [Clientes] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00128,1,0,true,false )
             ,new CursorDef("T00129", "SELECT [BodDsc] FROM [Bodegas] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT00129,1,0,true,false )
             ,new CursorDef("T001210", "SELECT TM1.[DespBodNro], TM1.[OrdenID], T2.[empdsc], T3.[AgeDsc], T4.[BodDsc], T5.[ClienteRUC], T5.[ClienteDsc], TM1.[DespBodUltReg], TM1.[DespachadoOK], TM1.[EmpID], TM1.[AgeID], TM1.[ClienteID], TM1.[BodCod] FROM (((([DespBodega] TM1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = TM1.[EmpID]) INNER JOIN [Agencias] T3 WITH (NOLOCK) ON T3.[EmpID] = TM1.[EmpID] AND T3.[AgeID] = TM1.[AgeID]) INNER JOIN [Bodegas] T4 WITH (NOLOCK) ON T4.[EmpID] = TM1.[EmpID] AND T4.[BodCod] = TM1.[BodCod]) INNER JOIN [Clientes] T5 WITH (NOLOCK) ON T5.[EmpID] = TM1.[EmpID] AND T5.[ClienteID] = TM1.[ClienteID]) WHERE TM1.[EmpID] = @EmpID and TM1.[AgeID] = @AgeID and TM1.[DespBodNro] = @DespBodNro and TM1.[OrdenID] = @OrdenID and TM1.[ClienteID] = @ClienteID ORDER BY TM1.[EmpID], TM1.[AgeID], TM1.[DespBodNro], TM1.[OrdenID], TM1.[ClienteID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001210,100,0,true,false )
             ,new CursorDef("T001211", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001211,1,0,true,false )
             ,new CursorDef("T001212", "SELECT [BodDsc] FROM [Bodegas] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT001212,1,0,true,false )
             ,new CursorDef("T001213", "SELECT [AgeDsc] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001213,1,0,true,false )
             ,new CursorDef("T001214", "SELECT [ClienteRUC], [ClienteDsc] FROM [Clientes] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001214,1,0,true,false )
             ,new CursorDef("T001215", "SELECT [EmpID], [AgeID], [DespBodNro], [OrdenID], [ClienteID] FROM [DespBodega] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [DespBodNro] = @DespBodNro AND [OrdenID] = @OrdenID AND [ClienteID] = @ClienteID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001215,1,0,true,false )
             ,new CursorDef("T001216", "SELECT TOP 1 [EmpID], [AgeID], [DespBodNro], [OrdenID], [ClienteID] FROM [DespBodega] WITH (NOLOCK) WHERE ( [EmpID] > @EmpID or [EmpID] = @EmpID and [AgeID] > @AgeID or [AgeID] = @AgeID and [EmpID] = @EmpID and [DespBodNro] > @DespBodNro or [DespBodNro] = @DespBodNro and [AgeID] = @AgeID and [EmpID] = @EmpID and [OrdenID] > @OrdenID or [OrdenID] = @OrdenID and [DespBodNro] = @DespBodNro and [AgeID] = @AgeID and [EmpID] = @EmpID and [ClienteID] > @ClienteID) ORDER BY [EmpID], [AgeID], [DespBodNro], [OrdenID], [ClienteID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001216,1,0,true,true )
             ,new CursorDef("T001217", "SELECT TOP 1 [EmpID], [AgeID], [DespBodNro], [OrdenID], [ClienteID] FROM [DespBodega] WITH (NOLOCK) WHERE ( [EmpID] < @EmpID or [EmpID] = @EmpID and [AgeID] < @AgeID or [AgeID] = @AgeID and [EmpID] = @EmpID and [DespBodNro] < @DespBodNro or [DespBodNro] = @DespBodNro and [AgeID] = @AgeID and [EmpID] = @EmpID and [OrdenID] < @OrdenID or [OrdenID] = @OrdenID and [DespBodNro] = @DespBodNro and [AgeID] = @AgeID and [EmpID] = @EmpID and [ClienteID] < @ClienteID) ORDER BY [EmpID] DESC, [AgeID] DESC, [DespBodNro] DESC, [OrdenID] DESC, [ClienteID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001217,1,0,true,true )
             ,new CursorDef("T001218", "INSERT INTO [DespBodega]([DespBodNro], [OrdenID], [DespBodUltReg], [DespachadoOK], [EmpID], [AgeID], [ClienteID], [BodCod]) VALUES(@DespBodNro, @OrdenID, @DespBodUltReg, @DespachadoOK, @EmpID, @AgeID, @ClienteID, @BodCod)", GxErrorMask.GX_NOMASK,prmT001218)
             ,new CursorDef("T001219", "UPDATE [DespBodega] SET [DespBodUltReg]=@DespBodUltReg, [DespachadoOK]=@DespachadoOK, [BodCod]=@BodCod  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [DespBodNro] = @DespBodNro AND [OrdenID] = @OrdenID AND [ClienteID] = @ClienteID", GxErrorMask.GX_NOMASK,prmT001219)
             ,new CursorDef("T001220", "DELETE FROM [DespBodega]  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [DespBodNro] = @DespBodNro AND [OrdenID] = @OrdenID AND [ClienteID] = @ClienteID", GxErrorMask.GX_NOMASK,prmT001220)
             ,new CursorDef("T001221", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001221,1,0,true,false )
             ,new CursorDef("T001222", "SELECT [AgeDsc] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001222,1,0,true,false )
             ,new CursorDef("T001223", "SELECT [BodDsc] FROM [Bodegas] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT001223,1,0,true,false )
             ,new CursorDef("T001224", "SELECT [ClienteRUC], [ClienteDsc] FROM [Clientes] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001224,1,0,true,false )
             ,new CursorDef("T001225", "SELECT [EmpID], [AgeID], [DespBodNro], [OrdenID], [ClienteID] FROM [DespBodega] WITH (NOLOCK) ORDER BY [EmpID], [AgeID], [DespBodNro], [OrdenID], [ClienteID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001225,100,0,true,false )
             ,new CursorDef("T001226", "SELECT [EmpID], [AgeID], [DespBodNro], [OrdenID], [ClienteID], [nroReg], [DespBodCodPrd], [DespBodPrdNombre], [DespBodCant], [DespBodValor], [DespBodADesp], [DespBodDetalle], [DespBodCatId], [DespBodOK], [DespBodModifItem] FROM [DespBodegaprd] WITH (NOLOCK) WHERE [EmpID] = @EmpID and [AgeID] = @AgeID and [DespBodNro] = @DespBodNro and [OrdenID] = @OrdenID and [ClienteID] = @ClienteID and [nroReg] = @nroReg ORDER BY [EmpID], [AgeID], [DespBodNro], [OrdenID], [ClienteID], [nroReg] ",true, GxErrorMask.GX_NOMASK, false, this,prmT001226,4,0,true,false )
             ,new CursorDef("T001227", "SELECT [EmpID], [AgeID], [DespBodNro], [OrdenID], [ClienteID], [nroReg] FROM [DespBodegaprd] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [DespBodNro] = @DespBodNro AND [OrdenID] = @OrdenID AND [ClienteID] = @ClienteID AND [nroReg] = @nroReg ",true, GxErrorMask.GX_NOMASK, false, this,prmT001227,1,0,true,false )
             ,new CursorDef("T001228", "INSERT INTO [DespBodegaprd]([EmpID], [AgeID], [DespBodNro], [OrdenID], [ClienteID], [nroReg], [DespBodCodPrd], [DespBodPrdNombre], [DespBodCant], [DespBodValor], [DespBodADesp], [DespBodDetalle], [DespBodCatId], [DespBodOK], [DespBodModifItem]) VALUES(@EmpID, @AgeID, @DespBodNro, @OrdenID, @ClienteID, @nroReg, @DespBodCodPrd, @DespBodPrdNombre, @DespBodCant, @DespBodValor, @DespBodADesp, @DespBodDetalle, @DespBodCatId, @DespBodOK, @DespBodModifItem)", GxErrorMask.GX_NOMASK,prmT001228)
             ,new CursorDef("T001229", "UPDATE [DespBodegaprd] SET [DespBodCodPrd]=@DespBodCodPrd, [DespBodPrdNombre]=@DespBodPrdNombre, [DespBodCant]=@DespBodCant, [DespBodValor]=@DespBodValor, [DespBodADesp]=@DespBodADesp, [DespBodDetalle]=@DespBodDetalle, [DespBodCatId]=@DespBodCatId, [DespBodOK]=@DespBodOK, [DespBodModifItem]=@DespBodModifItem  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [DespBodNro] = @DespBodNro AND [OrdenID] = @OrdenID AND [ClienteID] = @ClienteID AND [nroReg] = @nroReg", GxErrorMask.GX_NOMASK,prmT001229)
             ,new CursorDef("T001230", "DELETE FROM [DespBodegaprd]  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [DespBodNro] = @DespBodNro AND [OrdenID] = @OrdenID AND [ClienteID] = @ClienteID AND [nroReg] = @nroReg", GxErrorMask.GX_NOMASK,prmT001230)
             ,new CursorDef("T001231", "SELECT [EmpID], [AgeID], [DespBodNro], [OrdenID], [ClienteID], [nroReg] FROM [DespBodegaprd] WITH (NOLOCK) WHERE [EmpID] = @EmpID and [AgeID] = @AgeID and [DespBodNro] = @DespBodNro and [OrdenID] = @OrdenID and [ClienteID] = @ClienteID ORDER BY [EmpID], [AgeID], [DespBodNro], [OrdenID], [ClienteID], [nroReg] ",true, GxErrorMask.GX_NOMASK, false, this,prmT001231,4,0,true,false )
             ,new CursorDef("T001232", "SELECT [EmpID], [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @AV7empid ORDER BY [empdsc] ",true, GxErrorMask.GX_NOMASK, false, this,prmT001232,0,0,true,false )
             ,new CursorDef("T001233", "SELECT [EmpID], [AgeID], [AgeDsc] FROM [Agencias] WITH (NOLOCK) WHERE ([EmpID] = @AV7empid) AND ([AgeID] = @AV8ageId) ORDER BY [AgeDsc] ",true, GxErrorMask.GX_NOMASK, false, this,prmT001233,0,0,true,false )
             ,new CursorDef("T001234", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001234,1,0,true,false )
             ,new CursorDef("T001235", "SELECT [AgeDsc] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001235,1,0,true,false )
             ,new CursorDef("T001236", "SELECT [ClienteRUC], [ClienteDsc] FROM [Clientes] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001236,1,0,true,false )
             ,new CursorDef("T001237", "SELECT [BodDsc] FROM [Bodegas] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT001237,1,0,true,false )
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
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                ((String[]) buf[8])[0] = rslt.getString(8, 40) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((decimal[]) buf[12])[0] = rslt.getDecimal(10) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                ((decimal[]) buf[14])[0] = rslt.getDecimal(11) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(11);
                ((String[]) buf[16])[0] = rslt.getString(12, 50) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(12);
                ((short[]) buf[18])[0] = rslt.getShort(13) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(13);
                ((String[]) buf[20])[0] = rslt.getString(14, 1) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(14);
                ((String[]) buf[22])[0] = rslt.getString(15, 1) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(15);
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                ((String[]) buf[8])[0] = rslt.getString(8, 40) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((decimal[]) buf[12])[0] = rslt.getDecimal(10) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                ((decimal[]) buf[14])[0] = rslt.getDecimal(11) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(11);
                ((String[]) buf[16])[0] = rslt.getString(12, 50) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(12);
                ((short[]) buf[18])[0] = rslt.getShort(13) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(13);
                ((String[]) buf[20])[0] = rslt.getString(14, 1) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(14);
                ((String[]) buf[22])[0] = rslt.getString(15, 1) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(15);
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getString(4, 1) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((short[]) buf[6])[0] = rslt.getShort(5) ;
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                ((short[]) buf[8])[0] = rslt.getShort(7) ;
                ((short[]) buf[9])[0] = rslt.getShort(8) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getString(4, 1) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((short[]) buf[6])[0] = rslt.getShort(5) ;
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                ((short[]) buf[8])[0] = rslt.getShort(7) ;
                ((short[]) buf[9])[0] = rslt.getShort(8) ;
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 13) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getString(4, 50) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getString(5, 40) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((String[]) buf[8])[0] = rslt.getString(6, 13) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((String[]) buf[10])[0] = rslt.getString(7, 50) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(7);
                ((int[]) buf[12])[0] = rslt.getInt(8) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(8);
                ((String[]) buf[14])[0] = rslt.getString(9, 1) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(9);
                ((short[]) buf[16])[0] = rslt.getShort(10) ;
                ((short[]) buf[17])[0] = rslt.getShort(11) ;
                ((short[]) buf[18])[0] = rslt.getShort(12) ;
                ((short[]) buf[19])[0] = rslt.getShort(13) ;
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
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getString(1, 13) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 19 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 20 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 21 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 22 :
                ((String[]) buf[0])[0] = rslt.getString(1, 13) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 23 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 24 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                ((String[]) buf[8])[0] = rslt.getString(8, 40) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((decimal[]) buf[12])[0] = rslt.getDecimal(10) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                ((decimal[]) buf[14])[0] = rslt.getDecimal(11) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(11);
                ((String[]) buf[16])[0] = rslt.getString(12, 50) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(12);
                ((short[]) buf[18])[0] = rslt.getShort(13) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(13);
                ((String[]) buf[20])[0] = rslt.getString(14, 1) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(14);
                ((String[]) buf[22])[0] = rslt.getString(15, 1) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(15);
                return;
             case 25 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                return;
             case 29 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                return;
             case 31 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                return;
             case 32 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 33 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 34 :
                ((String[]) buf[0])[0] = rslt.getString(1, 13) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 35 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
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
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
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
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
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
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 3 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(3, (int)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 4 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[5]);
                }
                stmt.SetParameter(5, (short)parms[6]);
                stmt.SetParameter(6, (short)parms[7]);
                stmt.SetParameter(7, (short)parms[8]);
                stmt.SetParameter(8, (short)parms[9]);
                return;
             case 17 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
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
                stmt.SetParameter(7, (short)parms[8]);
                stmt.SetParameter(8, (short)parms[9]);
                return;
             case 18 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 19 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 20 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 21 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 22 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 24 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                return;
             case 25 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                return;
             case 26 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 7 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(7, (short)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 8 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 9 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(9, (decimal)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 10 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(10, (decimal)parms[13]);
                }
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 11 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(11, (decimal)parms[15]);
                }
                if ( (bool)parms[16] )
                {
                   stmt.setNull( 12 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(12, (String)parms[17]);
                }
                if ( (bool)parms[18] )
                {
                   stmt.setNull( 13 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(13, (short)parms[19]);
                }
                if ( (bool)parms[20] )
                {
                   stmt.setNull( 14 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(14, (String)parms[21]);
                }
                if ( (bool)parms[22] )
                {
                   stmt.setNull( 15 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(15, (String)parms[23]);
                }
                return;
             case 27 :
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
                   stmt.setNull( 2 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[3]);
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
                   stmt.setNull( 4 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(4, (decimal)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(5, (decimal)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 6 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 7 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(7, (short)parms[13]);
                }
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 8 , SqlDbType.Char );
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
                stmt.SetParameter(11, (short)parms[19]);
                stmt.SetParameter(12, (short)parms[20]);
                stmt.SetParameter(13, (short)parms[21]);
                stmt.SetParameter(14, (short)parms[22]);
                stmt.SetParameter(15, (int)parms[23]);
                return;
             case 28 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                return;
             case 29 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
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
                return;
             case 31 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 32 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 33 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 34 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 35 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
       }
    }

 }

}
