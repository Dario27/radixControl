/*
               File: MENU
        Description: MENU
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/26/2022 20:14:4.69
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
   public class menu : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
         {
            nRC_GXsfl_45 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_45_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_45_idx = GetNextPar( );
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid2") == 0 )
         {
            nRC_GXsfl_72 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_72_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_72_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGrid2_newrow( ) ;
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
            Form.Meta.addItem("description", "MENU", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtModCod_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public menu( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public menu( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
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
            wb_table1_2_0O11( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0O11e( bool wbgen )
      {
         if ( wbgen )
         {
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm0O11( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0O11( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 5,'',false,'',0)\"";
            ClassString = "BtnFirst";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "<<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_MENU.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 6,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_MENU.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 7,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_MENU.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 8,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, ">>", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_MENU.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx00b0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"MODCOD"+"'), id:'"+"MODCOD"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"MENCOD"+"'), id:'"+"MENCOD"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_MENU.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_15_0O11( true) ;
         }
         return  ;
      }

      protected void wb_table2_15_0O11e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_MENU.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_MENU.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_MENU.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0O11e( true) ;
         }
         else
         {
            wb_table1_2_0O11e( false) ;
         }
      }

      protected void wb_table2_15_0O11( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Codigo", "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_MENU.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtModCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A11ModCod), 4, 0, ",", "")), ((edtModCod_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A11ModCod), "ZZZ9")) : context.localUtil.Format( (decimal)(A11ModCod), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,20);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtModCod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtModCod_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_MENU.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, "Código de Menú", "", "", lblTextblock2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_MENU.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtMenCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A12MenCod), 4, 0, ",", "")), ((edtMenCod_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A12MenCod), "ZZZ9")) : context.localUtil.Format( (decimal)(A12MenCod), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,25);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtMenCod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtMenCod_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_MENU.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"";
            ClassString = "BtnGet";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_get_Internalname, "", "=>", bttBtn_get_Jsonclick, 6, "=>", "", StyleString, ClassString, bttBtn_get_Visible, bttBtn_get_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EGET."+"'", TempTags, "", context.GetButtonType( ), "HLP_MENU.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, "Menu", "", "", lblTextblock3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_MENU.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtMenDsc_Internalname, StringUtil.RTrim( A77MenDsc), StringUtil.RTrim( context.localUtil.Format( A77MenDsc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,31);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtMenDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtMenDsc_Enabled, 0, "text", "", 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_MENU.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, "Link", "", "", lblTextblock4_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_MENU.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtMenLink_Internalname, StringUtil.RTrim( A78MenLink), StringUtil.RTrim( context.localUtil.Format( A78MenLink, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtMenLink_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtMenLink_Enabled, 0, "text", "", 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_MENU.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, "Ico", "", "", lblTextblock5_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_MENU.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtMenIco_Internalname, StringUtil.RTrim( A79MenIco), StringUtil.RTrim( context.localUtil.Format( A79MenIco, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,41);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtMenIco_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtMenIco_Enabled, 0, "text", "", 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_MENU.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /*  Grid Control  */
            Grid1Container.AddObjectProperty("GridName", "Grid1");
            Grid1Container.AddObjectProperty("Header", subGrid1_Header);
            Grid1Container.AddObjectProperty("Class", StringUtil.RTrim( "FreeStyleGrid"));
            Grid1Container.AddObjectProperty("Borderwidth", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
            Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 4, 0, ".", "")));
            Grid1Container.AddObjectProperty("Rules", StringUtil.RTrim( "none"));
            Grid1Container.AddObjectProperty("Class", "FreeStyleGrid");
            Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
            Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 4, 0, ".", "")));
            Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
            Grid1Container.AddObjectProperty("Borderwidth", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Borderwidth), 4, 0, ".", "")));
            Grid1Container.AddObjectProperty("CmpContext", "");
            Grid1Container.AddObjectProperty("InMasterPage", "false");
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Column.AddObjectProperty("Value", lblTextblock1_Caption);
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A13SubCod), 4, 0, ".", "")));
            Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSubCod_Enabled), 5, 0, ".", "")));
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Column.AddObjectProperty("Value", lblTextblock7_Caption);
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A80SubDsc));
            Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSubDsc_Enabled), 5, 0, ".", "")));
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Column.AddObjectProperty("Value", lblTextblock4_Caption);
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A81SubLink));
            Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSubLink_Enabled), 5, 0, ".", "")));
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Column.AddObjectProperty("Value", lblTextblock9_Caption);
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A82SubEti));
            Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSubEti_Enabled), 5, 0, ".", "")));
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid1Container.AddColumnProperties(Grid1Column);
            Grid1Container.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectedindex), 4, 0, ".", "")));
            Grid1Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowselection), 1, 0, ".", "")));
            Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
            Grid1Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowhovering), 1, 0, ".", "")));
            Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
            Grid1Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowcollapsing), 1, 0, ".", "")));
            Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 1, 0, ".", "")));
            /* Save parent mode. */
            sMode12 = Gx_mode;
            nGXsfl_45_idx = 0;
            if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
            {
               /* Enter key processing. */
               nBlankRcdCount12 = 5;
               if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
               {
                  /* Display confirmed (stored) records */
                  nRcdExists_12 = 1;
                  ScanStart0O12( ) ;
                  while ( RcdFound12 != 0 )
                  {
                     init_level_properties12( ) ;
                     getByPrimaryKey0O12( ) ;
                     AddRow0O12( ) ;
                     ScanNext0O12( ) ;
                  }
                  ScanEnd0O12( ) ;
                  nBlankRcdCount12 = 5;
               }
            }
            else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
            {
               /* Button check  or addlines. */
               standaloneNotModal0O12( ) ;
               standaloneModal0O12( ) ;
               sMode12 = Gx_mode;
               while ( nGXsfl_45_idx < nRC_GXsfl_45 )
               {
                  bGXsfl_45_Refreshing = true;
                  ReadRow0O12( ) ;
                  edtSubCod_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCOD_"+sGXsfl_45_idx+"Enabled"), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSubCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSubCod_Enabled), 5, 0)), !bGXsfl_45_Refreshing);
                  edtSubDsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBDSC_"+sGXsfl_45_idx+"Enabled"), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSubDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSubDsc_Enabled), 5, 0)), !bGXsfl_45_Refreshing);
                  edtSubLink_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBLINK_"+sGXsfl_45_idx+"Enabled"), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSubLink_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSubLink_Enabled), 5, 0)), !bGXsfl_45_Refreshing);
                  edtSubEti_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBETI_"+sGXsfl_45_idx+"Enabled"), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSubEti_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSubEti_Enabled), 5, 0)), !bGXsfl_45_Refreshing);
                  if ( ( nRcdExists_12 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     standaloneModal0O12( ) ;
                  }
                  SendRow0O12( ) ;
                  bGXsfl_45_Refreshing = false;
               }
               Gx_mode = sMode12;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            }
            else
            {
               /* Get or get-alike key processing. */
               nBlankRcdCount12 = 5;
               nRcdExists_12 = 1;
               if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
               {
                  ScanStart0O12( ) ;
                  while ( RcdFound12 != 0 )
                  {
                     sGXsfl_45_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_45_idx+1), 4, 0)), 4, "0");
                     SubsflControlProps_4512( ) ;
                     init_level_properties12( ) ;
                     standaloneNotModal0O12( ) ;
                     getByPrimaryKey0O12( ) ;
                     standaloneModal0O12( ) ;
                     AddRow0O12( ) ;
                     ScanNext0O12( ) ;
                  }
                  ScanEnd0O12( ) ;
               }
            }
            /* Initialize fields for 'new' records and send them. */
            sMode12 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            sGXsfl_45_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_45_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_4512( ) ;
            InitAll0O12( ) ;
            init_level_properties12( ) ;
            standaloneNotModal0O12( ) ;
            standaloneModal0O12( ) ;
            nRcdExists_12 = 0;
            nIsMod_12 = 0;
            nRcdDeleted_12 = 0;
            nBlankRcdCount12 = (short)(nBlankRcdUsr12+nBlankRcdCount12);
            fRowAdded = 0;
            while ( nBlankRcdCount12 > 0 )
            {
               AddRow0O12( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtSubCod_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount12 = (short)(nBlankRcdCount12-1);
            }
            Gx_mode = sMode12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            /* Restore parent mode. */
            Gx_mode = sMode12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            sStyleString = "";
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
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_15_0O11e( true) ;
         }
         else
         {
            wb_table2_15_0O11e( false) ;
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
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtModCod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtModCod_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "MODCOD");
                  AnyError = 1;
                  GX_FocusControl = edtModCod_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A11ModCod = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11ModCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A11ModCod), 4, 0)));
               }
               else
               {
                  A11ModCod = (short)(context.localUtil.CToN( cgiGet( edtModCod_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11ModCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A11ModCod), 4, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtMenCod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtMenCod_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "MENCOD");
                  AnyError = 1;
                  GX_FocusControl = edtMenCod_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A12MenCod = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12MenCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A12MenCod), 4, 0)));
               }
               else
               {
                  A12MenCod = (short)(context.localUtil.CToN( cgiGet( edtMenCod_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12MenCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A12MenCod), 4, 0)));
               }
               A77MenDsc = cgiGet( edtMenDsc_Internalname);
               n77MenDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A77MenDsc", A77MenDsc);
               n77MenDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A77MenDsc)) ? true : false);
               A78MenLink = cgiGet( edtMenLink_Internalname);
               n78MenLink = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A78MenLink", A78MenLink);
               n78MenLink = (String.IsNullOrEmpty(StringUtil.RTrim( A78MenLink)) ? true : false);
               A79MenIco = cgiGet( edtMenIco_Internalname);
               n79MenIco = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79MenIco", A79MenIco);
               n79MenIco = (String.IsNullOrEmpty(StringUtil.RTrim( A79MenIco)) ? true : false);
               /* Read saved values. */
               Z11ModCod = (short)(context.localUtil.CToN( cgiGet( "Z11ModCod"), ",", "."));
               Z12MenCod = (short)(context.localUtil.CToN( cgiGet( "Z12MenCod"), ",", "."));
               Z77MenDsc = cgiGet( "Z77MenDsc");
               n77MenDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A77MenDsc)) ? true : false);
               Z78MenLink = cgiGet( "Z78MenLink");
               n78MenLink = (String.IsNullOrEmpty(StringUtil.RTrim( A78MenLink)) ? true : false);
               Z79MenIco = cgiGet( "Z79MenIco");
               n79MenIco = (String.IsNullOrEmpty(StringUtil.RTrim( A79MenIco)) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_45 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_45"), ",", "."));
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
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
                  A11ModCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11ModCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A11ModCod), 4, 0)));
                  A12MenCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12MenCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A12MenCod), 4, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons_dsp( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  standaloneModal( ) ;
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
                     if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                     {
                        context.wbHandled = 1;
                        btn_enter( ) ;
                        /* No code required for Cancel button. It is implemented as the Reset button. */
                     }
                     else if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                     {
                        context.wbHandled = 1;
                        btn_first( ) ;
                     }
                     else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                     {
                        context.wbHandled = 1;
                        btn_previous( ) ;
                     }
                     else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                     {
                        context.wbHandled = 1;
                        btn_next( ) ;
                     }
                     else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                     {
                        context.wbHandled = 1;
                        btn_last( ) ;
                     }
                     else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                     {
                        context.wbHandled = 1;
                        btn_select( ) ;
                     }
                     else if ( StringUtil.StrCmp(sEvt, "GET") == 0 )
                     {
                        context.wbHandled = 1;
                        btn_get( ) ;
                     }
                     else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                     {
                        context.wbHandled = 1;
                        btn_delete( ) ;
                     }
                     else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                     {
                        context.wbHandled = 1;
                        AfterKeyLoadScreen( ) ;
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
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0O11( ) ;
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
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            bttBtn_delete_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         }
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavnRcdDeleted_13_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavnRcdDeleted_13_Enabled), 5, 0)), !bGXsfl_72_Refreshing);
      }

      protected void disable_std_buttons_dsp( )
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
         bttBtn_get_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_get_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_get_Visible), 5, 0)), true);
         bttBtn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)), true);
         }
         DisableAttributes0O11( ) ;
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

      protected void CONFIRM_0O13( )
      {
         nGXsfl_72_idx = 0;
         while ( nGXsfl_72_idx < nRC_GXsfl_72 )
         {
            ReadRow0O13( ) ;
            if ( ( nRcdExists_13 != 0 ) || ( nIsMod_13 != 0 ) )
            {
               GetKey0O13( ) ;
               if ( ( nRcdExists_13 == 0 ) && ( nRcdDeleted_13 == 0 ) )
               {
                  if ( RcdFound13 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate0O13( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0O13( ) ;
                        CloseExtendedTableCursors0O13( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "SUBCOD_" + sGXsfl_45_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtSubCod_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound13 != 0 )
                  {
                     if ( nRcdDeleted_13 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey0O13( ) ;
                        Load0O13( ) ;
                        BeforeValidate0O13( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0O13( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_13 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate0O13( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0O13( ) ;
                              CloseExtendedTableCursors0O13( ) ;
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
                     if ( nRcdDeleted_13 == 0 )
                     {
                        GXCCtl = "SUBCOD_" + sGXsfl_45_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtSubCod_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtavnRcdDeleted_13_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_13), 4, 0, ",", ""))) ;
            ChangePostValue( edtSub1Cod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A14Sub1Cod), 4, 0, ",", ""))) ;
            ChangePostValue( edtSub1Dsc_Internalname, StringUtil.RTrim( A83Sub1Dsc)) ;
            ChangePostValue( edtSub1Link_Internalname, StringUtil.RTrim( A84Sub1Link)) ;
            ChangePostValue( edtSub1Eti_Internalname, StringUtil.RTrim( A85Sub1Eti)) ;
            ChangePostValue( "ZT_"+"Z14Sub1Cod_"+sGXsfl_72_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z14Sub1Cod), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z83Sub1Dsc_"+sGXsfl_72_idx, StringUtil.RTrim( Z83Sub1Dsc)) ;
            ChangePostValue( "ZT_"+"Z84Sub1Link_"+sGXsfl_72_idx, StringUtil.RTrim( Z84Sub1Link)) ;
            ChangePostValue( "ZT_"+"Z85Sub1Eti_"+sGXsfl_72_idx, StringUtil.RTrim( Z85Sub1Eti)) ;
            ChangePostValue( "nRcdDeleted_13_"+sGXsfl_72_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_13), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_13_"+sGXsfl_72_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_13), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_13_"+sGXsfl_72_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_13), 4, 0, ",", ""))) ;
            if ( nIsMod_13 != 0 )
            {
               ChangePostValue( "vNRCDDELETED_13_"+sGXsfl_72_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavnRcdDeleted_13_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUB1COD_"+sGXsfl_72_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSub1Cod_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUB1DSC_"+sGXsfl_72_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSub1Dsc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUB1LINK_"+sGXsfl_72_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSub1Link_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUB1ETI_"+sGXsfl_72_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSub1Eti_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void CONFIRM_0O12( )
      {
         nGXsfl_45_idx = 0;
         while ( nGXsfl_45_idx < nRC_GXsfl_45 )
         {
            ReadRow0O12( ) ;
            if ( ( nRcdExists_12 != 0 ) || ( nIsMod_12 != 0 ) )
            {
               GetKey0O12( ) ;
               if ( ( nRcdExists_12 == 0 ) && ( nRcdDeleted_12 == 0 ) )
               {
                  if ( RcdFound12 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate0O12( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0O12( ) ;
                        CloseExtendedTableCursors0O12( ) ;
                        if ( AnyError == 0 )
                        {
                           /* Save parent mode. */
                           sMode12 = Gx_mode;
                           CONFIRM_0O13( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Restore parent mode. */
                              Gx_mode = sMode12;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                              IsConfirmed = 1;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                           }
                           /* Restore parent mode. */
                           Gx_mode = sMode12;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "SUBCOD_" + sGXsfl_45_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtSubCod_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound12 != 0 )
                  {
                     if ( nRcdDeleted_12 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey0O12( ) ;
                        Load0O12( ) ;
                        BeforeValidate0O12( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0O12( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_12 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate0O12( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0O12( ) ;
                              CloseExtendedTableCursors0O12( ) ;
                              if ( AnyError == 0 )
                              {
                                 /* Save parent mode. */
                                 sMode12 = Gx_mode;
                                 CONFIRM_0O13( ) ;
                                 if ( AnyError == 0 )
                                 {
                                    /* Restore parent mode. */
                                    Gx_mode = sMode12;
                                    context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                                    IsConfirmed = 1;
                                    context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                                 }
                                 /* Restore parent mode. */
                                 Gx_mode = sMode12;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_12 == 0 )
                     {
                        GXCCtl = "SUBCOD_" + sGXsfl_45_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtSubCod_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtSubCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A13SubCod), 4, 0, ",", ""))) ;
            ChangePostValue( edtSubDsc_Internalname, StringUtil.RTrim( A80SubDsc)) ;
            ChangePostValue( edtSubLink_Internalname, StringUtil.RTrim( A81SubLink)) ;
            ChangePostValue( edtSubEti_Internalname, StringUtil.RTrim( A82SubEti)) ;
            ChangePostValue( "ZT_"+"Z13SubCod_"+sGXsfl_45_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z13SubCod), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z80SubDsc_"+sGXsfl_45_idx, StringUtil.RTrim( Z80SubDsc)) ;
            ChangePostValue( "ZT_"+"Z81SubLink_"+sGXsfl_45_idx, StringUtil.RTrim( Z81SubLink)) ;
            ChangePostValue( "ZT_"+"Z82SubEti_"+sGXsfl_45_idx, StringUtil.RTrim( Z82SubEti)) ;
            ChangePostValue( "nRC_GXsfl_72_"+sGXsfl_45_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_72), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_12_"+sGXsfl_45_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_12), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_12_"+sGXsfl_45_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_12), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_12_"+sGXsfl_45_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_12), 4, 0, ",", ""))) ;
            if ( nIsMod_12 != 0 )
            {
               ChangePostValue( "SUBCOD_"+sGXsfl_45_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSubCod_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBDSC_"+sGXsfl_45_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSubDsc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBLINK_"+sGXsfl_45_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSubLink_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBETI_"+sGXsfl_45_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSubEti_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption0O0( )
      {
      }

      protected void ZM0O11( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z77MenDsc = T000O7_A77MenDsc[0];
               Z78MenLink = T000O7_A78MenLink[0];
               Z79MenIco = T000O7_A79MenIco[0];
            }
            else
            {
               Z77MenDsc = A77MenDsc;
               Z78MenLink = A78MenLink;
               Z79MenIco = A79MenIco;
            }
         }
         if ( GX_JID == -1 )
         {
            Z11ModCod = A11ModCod;
            Z12MenCod = A12MenCod;
            Z77MenDsc = A77MenDsc;
            Z78MenLink = A78MenLink;
            Z79MenIco = A79MenIco;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            bttBtn_get_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_get_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_get_Enabled), 5, 0)), true);
         }
         else
         {
            bttBtn_get_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_get_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_get_Enabled), 5, 0)), true);
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            bttBtn_delete_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         }
         else
         {
            bttBtn_delete_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
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
      }

      protected void Load0O11( )
      {
         /* Using cursor T000O8 */
         pr_default.execute(6, new Object[] {A11ModCod, A12MenCod});
         if ( (pr_default.getStatus(6) != 101) )
         {
            RcdFound11 = 1;
            A77MenDsc = T000O8_A77MenDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A77MenDsc", A77MenDsc);
            n77MenDsc = T000O8_n77MenDsc[0];
            A78MenLink = T000O8_A78MenLink[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A78MenLink", A78MenLink);
            n78MenLink = T000O8_n78MenLink[0];
            A79MenIco = T000O8_A79MenIco[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79MenIco", A79MenIco);
            n79MenIco = T000O8_n79MenIco[0];
            ZM0O11( -1) ;
         }
         pr_default.close(6);
         OnLoadActions0O11( ) ;
      }

      protected void OnLoadActions0O11( )
      {
      }

      protected void CheckExtendedTable0O11( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors0O11( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0O11( )
      {
         /* Using cursor T000O9 */
         pr_default.execute(7, new Object[] {A11ModCod, A12MenCod});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound11 = 1;
         }
         else
         {
            RcdFound11 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000O7 */
         pr_default.execute(5, new Object[] {A11ModCod, A12MenCod});
         if ( (pr_default.getStatus(5) != 101) )
         {
            ZM0O11( 1) ;
            RcdFound11 = 1;
            A11ModCod = T000O7_A11ModCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11ModCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A11ModCod), 4, 0)));
            A12MenCod = T000O7_A12MenCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12MenCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A12MenCod), 4, 0)));
            A77MenDsc = T000O7_A77MenDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A77MenDsc", A77MenDsc);
            n77MenDsc = T000O7_n77MenDsc[0];
            A78MenLink = T000O7_A78MenLink[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A78MenLink", A78MenLink);
            n78MenLink = T000O7_n78MenLink[0];
            A79MenIco = T000O7_A79MenIco[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79MenIco", A79MenIco);
            n79MenIco = T000O7_n79MenIco[0];
            Z11ModCod = A11ModCod;
            Z12MenCod = A12MenCod;
            sMode11 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0O11( ) ;
            if ( AnyError == 1 )
            {
               RcdFound11 = 0;
               InitializeNonKey0O11( ) ;
            }
            Gx_mode = sMode11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound11 = 0;
            InitializeNonKey0O11( ) ;
            sMode11 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(5);
      }

      protected void getEqualNoModal( )
      {
         GetKey0O11( ) ;
         if ( RcdFound11 == 0 )
         {
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound11 = 0;
         /* Using cursor T000O10 */
         pr_default.execute(8, new Object[] {A11ModCod, A12MenCod});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000O10_A11ModCod[0] < A11ModCod ) || ( T000O10_A11ModCod[0] == A11ModCod ) && ( T000O10_A12MenCod[0] < A12MenCod ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000O10_A11ModCod[0] > A11ModCod ) || ( T000O10_A11ModCod[0] == A11ModCod ) && ( T000O10_A12MenCod[0] > A12MenCod ) ) )
            {
               A11ModCod = T000O10_A11ModCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11ModCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A11ModCod), 4, 0)));
               A12MenCod = T000O10_A12MenCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12MenCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A12MenCod), 4, 0)));
               RcdFound11 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound11 = 0;
         /* Using cursor T000O11 */
         pr_default.execute(9, new Object[] {A11ModCod, A12MenCod});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000O11_A11ModCod[0] > A11ModCod ) || ( T000O11_A11ModCod[0] == A11ModCod ) && ( T000O11_A12MenCod[0] > A12MenCod ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000O11_A11ModCod[0] < A11ModCod ) || ( T000O11_A11ModCod[0] == A11ModCod ) && ( T000O11_A12MenCod[0] < A12MenCod ) ) )
            {
               A11ModCod = T000O11_A11ModCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11ModCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A11ModCod), 4, 0)));
               A12MenCod = T000O11_A12MenCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12MenCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A12MenCod), 4, 0)));
               RcdFound11 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0O11( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtModCod_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0O11( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound11 == 1 )
            {
               if ( ( A11ModCod != Z11ModCod ) || ( A12MenCod != Z12MenCod ) )
               {
                  A11ModCod = Z11ModCod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11ModCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A11ModCod), 4, 0)));
                  A12MenCod = Z12MenCod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12MenCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A12MenCod), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "MODCOD");
                  AnyError = 1;
                  GX_FocusControl = edtModCod_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtModCod_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update0O11( ) ;
                  GX_FocusControl = edtModCod_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A11ModCod != Z11ModCod ) || ( A12MenCod != Z12MenCod ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtModCod_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0O11( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "MODCOD");
                     AnyError = 1;
                     GX_FocusControl = edtModCod_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtModCod_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0O11( ) ;
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
      }

      protected void btn_delete( )
      {
         if ( ( A11ModCod != Z11ModCod ) || ( A12MenCod != Z12MenCod ) )
         {
            A11ModCod = Z11ModCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11ModCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A11ModCod), 4, 0)));
            A12MenCod = Z12MenCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12MenCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A12MenCod), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "MODCOD");
            AnyError = 1;
            GX_FocusControl = edtModCod_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtModCod_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            getByPrimaryKey( ) ;
         }
         CloseOpenCursors();
      }

      protected void btn_get( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         getEqualNoModal( ) ;
         if ( RcdFound11 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "MODCOD");
            AnyError = 1;
            GX_FocusControl = edtModCod_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtMenDsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart0O11( ) ;
         if ( RcdFound11 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtMenDsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0O11( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         move_previous( ) ;
         if ( RcdFound11 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtMenDsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         move_next( ) ;
         if ( RcdFound11 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtMenDsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart0O11( ) ;
         if ( RcdFound11 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound11 != 0 )
            {
               ScanNext0O11( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtMenDsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0O11( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0O11( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000O6 */
            pr_default.execute(4, new Object[] {A11ModCod, A12MenCod});
            if ( (pr_default.getStatus(4) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"MENU"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(4) == 101) || ( StringUtil.StrCmp(Z77MenDsc, T000O6_A77MenDsc[0]) != 0 ) || ( StringUtil.StrCmp(Z78MenLink, T000O6_A78MenLink[0]) != 0 ) || ( StringUtil.StrCmp(Z79MenIco, T000O6_A79MenIco[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z77MenDsc, T000O6_A77MenDsc[0]) != 0 )
               {
                  GXUtil.WriteLog("menu:[seudo value changed for attri]"+"MenDsc");
                  GXUtil.WriteLogRaw("Old: ",Z77MenDsc);
                  GXUtil.WriteLogRaw("Current: ",T000O6_A77MenDsc[0]);
               }
               if ( StringUtil.StrCmp(Z78MenLink, T000O6_A78MenLink[0]) != 0 )
               {
                  GXUtil.WriteLog("menu:[seudo value changed for attri]"+"MenLink");
                  GXUtil.WriteLogRaw("Old: ",Z78MenLink);
                  GXUtil.WriteLogRaw("Current: ",T000O6_A78MenLink[0]);
               }
               if ( StringUtil.StrCmp(Z79MenIco, T000O6_A79MenIco[0]) != 0 )
               {
                  GXUtil.WriteLog("menu:[seudo value changed for attri]"+"MenIco");
                  GXUtil.WriteLogRaw("Old: ",Z79MenIco);
                  GXUtil.WriteLogRaw("Current: ",T000O6_A79MenIco[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"MENU"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0O11( )
      {
         BeforeValidate0O11( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0O11( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0O11( 0) ;
            CheckOptimisticConcurrency0O11( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0O11( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0O11( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000O12 */
                     pr_default.execute(10, new Object[] {A11ModCod, A12MenCod, n77MenDsc, A77MenDsc, n78MenLink, A78MenLink, n79MenIco, A79MenIco});
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("MENU") ;
                     if ( (pr_default.getStatus(10) == 1) )
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
                           ProcessLevel0O11( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption0O0( ) ;
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
               Load0O11( ) ;
            }
            EndLevel0O11( ) ;
         }
         CloseExtendedTableCursors0O11( ) ;
      }

      protected void Update0O11( )
      {
         BeforeValidate0O11( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0O11( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0O11( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0O11( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0O11( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000O13 */
                     pr_default.execute(11, new Object[] {n77MenDsc, A77MenDsc, n78MenLink, A78MenLink, n79MenIco, A79MenIco, A11ModCod, A12MenCod});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("MENU") ;
                     if ( (pr_default.getStatus(11) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"MENU"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0O11( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0O11( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                              ResetCaption0O0( ) ;
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
            EndLevel0O11( ) ;
         }
         CloseExtendedTableCursors0O11( ) ;
      }

      protected void DeferredUpdate0O11( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0O11( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0O11( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0O11( ) ;
            AfterConfirm0O11( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0O11( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000O14 */
                  pr_default.execute(12, new Object[] {A11ModCod, A12MenCod});
                  pr_default.close(12);
                  dsDefault.SmartCacheProvider.SetUpdated("MENU") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound11 == 0 )
                        {
                           InitAll0O11( ) ;
                           Gx_mode = "INS";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        }
                        else
                        {
                           getByPrimaryKey( ) ;
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        }
                        GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted", ""), "SuccessfullyDeleted", 0, "", true);
                        ResetCaption0O0( ) ;
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
         sMode11 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0O11( ) ;
         Gx_mode = sMode11;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0O11( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000O15 */
            pr_default.execute(13, new Object[] {A11ModCod, A12MenCod});
            if ( (pr_default.getStatus(13) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"1"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(13);
         }
      }

      protected void ProcessNestedLevel0O12( )
      {
         nGXsfl_45_idx = 0;
         while ( nGXsfl_45_idx < nRC_GXsfl_45 )
         {
            ReadRow0O12( ) ;
            if ( ( nRcdExists_12 != 0 ) || ( nIsMod_12 != 0 ) )
            {
               standaloneNotModal0O12( ) ;
               GetKey0O12( ) ;
               if ( ( nRcdExists_12 == 0 ) && ( nRcdDeleted_12 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  Insert0O12( ) ;
               }
               else
               {
                  if ( RcdFound12 != 0 )
                  {
                     if ( ( nRcdDeleted_12 != 0 ) && ( nRcdExists_12 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        Delete0O12( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_12 != 0 ) && ( nRcdExists_12 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           Update0O12( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_12 == 0 )
                     {
                        GXCCtl = "SUBCOD_" + sGXsfl_45_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtSubCod_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtSubCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A13SubCod), 4, 0, ",", ""))) ;
            ChangePostValue( edtSubDsc_Internalname, StringUtil.RTrim( A80SubDsc)) ;
            ChangePostValue( edtSubLink_Internalname, StringUtil.RTrim( A81SubLink)) ;
            ChangePostValue( edtSubEti_Internalname, StringUtil.RTrim( A82SubEti)) ;
            ChangePostValue( "ZT_"+"Z13SubCod_"+sGXsfl_45_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z13SubCod), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z80SubDsc_"+sGXsfl_45_idx, StringUtil.RTrim( Z80SubDsc)) ;
            ChangePostValue( "ZT_"+"Z81SubLink_"+sGXsfl_45_idx, StringUtil.RTrim( Z81SubLink)) ;
            ChangePostValue( "ZT_"+"Z82SubEti_"+sGXsfl_45_idx, StringUtil.RTrim( Z82SubEti)) ;
            ChangePostValue( "nRC_GXsfl_72_"+sGXsfl_45_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_72), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_12_"+sGXsfl_45_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_12), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_12_"+sGXsfl_45_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_12), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_12_"+sGXsfl_45_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_12), 4, 0, ",", ""))) ;
            if ( nIsMod_12 != 0 )
            {
               ChangePostValue( "SUBCOD_"+sGXsfl_45_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSubCod_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBDSC_"+sGXsfl_45_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSubDsc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBLINK_"+sGXsfl_45_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSubLink_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBETI_"+sGXsfl_45_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSubEti_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0O12( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_12 = 0;
         nIsMod_12 = 0;
         nRcdDeleted_12 = 0;
      }

      protected void ProcessLevel0O11( )
      {
         /* Save parent mode. */
         sMode11 = Gx_mode;
         ProcessNestedLevel0O12( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode11;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel0O11( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(4);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0O11( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(5);
            pr_default.close(3);
            pr_default.close(2);
            pr_default.close(1);
            pr_default.close(0);
            context.CommitDataStores("menu",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0O0( ) ;
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
            context.RollbackDataStores("menu",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0O11( )
      {
         /* Using cursor T000O16 */
         pr_default.execute(14);
         RcdFound11 = 0;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound11 = 1;
            A11ModCod = T000O16_A11ModCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11ModCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A11ModCod), 4, 0)));
            A12MenCod = T000O16_A12MenCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12MenCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A12MenCod), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0O11( )
      {
         /* Scan next routine */
         pr_default.readNext(14);
         RcdFound11 = 0;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound11 = 1;
            A11ModCod = T000O16_A11ModCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11ModCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A11ModCod), 4, 0)));
            A12MenCod = T000O16_A12MenCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12MenCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A12MenCod), 4, 0)));
         }
      }

      protected void ScanEnd0O11( )
      {
         pr_default.close(14);
      }

      protected void AfterConfirm0O11( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0O11( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0O11( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0O11( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0O11( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0O11( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0O11( )
      {
         edtModCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtModCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtModCod_Enabled), 5, 0)), true);
         edtMenCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMenCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMenCod_Enabled), 5, 0)), true);
         edtMenDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMenDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMenDsc_Enabled), 5, 0)), true);
         edtMenLink_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMenLink_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMenLink_Enabled), 5, 0)), true);
         edtMenIco_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMenIco_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMenIco_Enabled), 5, 0)), true);
      }

      protected void ZM0O12( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z80SubDsc = T000O5_A80SubDsc[0];
               Z81SubLink = T000O5_A81SubLink[0];
               Z82SubEti = T000O5_A82SubEti[0];
            }
            else
            {
               Z80SubDsc = A80SubDsc;
               Z81SubLink = A81SubLink;
               Z82SubEti = A82SubEti;
            }
         }
         if ( GX_JID == -2 )
         {
            Z11ModCod = A11ModCod;
            Z12MenCod = A12MenCod;
            Z13SubCod = A13SubCod;
            Z80SubDsc = A80SubDsc;
            Z81SubLink = A81SubLink;
            Z82SubEti = A82SubEti;
         }
      }

      protected void standaloneNotModal0O12( )
      {
      }

      protected void standaloneModal0O12( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtSubCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSubCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSubCod_Enabled), 5, 0)), !bGXsfl_45_Refreshing);
         }
         else
         {
            edtSubCod_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSubCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSubCod_Enabled), 5, 0)), !bGXsfl_45_Refreshing);
         }
      }

      protected void Load0O12( )
      {
         /* Using cursor T000O17 */
         pr_default.execute(15, new Object[] {A11ModCod, A12MenCod, A13SubCod});
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound12 = 1;
            A80SubDsc = T000O17_A80SubDsc[0];
            n80SubDsc = T000O17_n80SubDsc[0];
            A81SubLink = T000O17_A81SubLink[0];
            n81SubLink = T000O17_n81SubLink[0];
            A82SubEti = T000O17_A82SubEti[0];
            n82SubEti = T000O17_n82SubEti[0];
            ZM0O12( -2) ;
         }
         pr_default.close(15);
         OnLoadActions0O12( ) ;
      }

      protected void OnLoadActions0O12( )
      {
      }

      protected void CheckExtendedTable0O12( )
      {
         Gx_BScreen = 1;
         standaloneModal0O12( ) ;
      }

      protected void CloseExtendedTableCursors0O12( )
      {
      }

      protected void enableDisable0O12( )
      {
      }

      protected void GetKey0O12( )
      {
         /* Using cursor T000O18 */
         pr_default.execute(16, new Object[] {A11ModCod, A12MenCod, A13SubCod});
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound12 = 1;
         }
         else
         {
            RcdFound12 = 0;
         }
         pr_default.close(16);
      }

      protected void getByPrimaryKey0O12( )
      {
         /* Using cursor T000O5 */
         pr_default.execute(3, new Object[] {A11ModCod, A12MenCod, A13SubCod});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM0O12( 2) ;
            RcdFound12 = 1;
            InitializeNonKey0O12( ) ;
            A13SubCod = T000O5_A13SubCod[0];
            A80SubDsc = T000O5_A80SubDsc[0];
            n80SubDsc = T000O5_n80SubDsc[0];
            A81SubLink = T000O5_A81SubLink[0];
            n81SubLink = T000O5_n81SubLink[0];
            A82SubEti = T000O5_A82SubEti[0];
            n82SubEti = T000O5_n82SubEti[0];
            Z11ModCod = A11ModCod;
            Z12MenCod = A12MenCod;
            Z13SubCod = A13SubCod;
            sMode12 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal0O12( ) ;
            Load0O12( ) ;
            Gx_mode = sMode12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound12 = 0;
            InitializeNonKey0O12( ) ;
            sMode12 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal0O12( ) ;
            Gx_mode = sMode12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes0O12( ) ;
         }
         pr_default.close(3);
      }

      protected void CheckOptimisticConcurrency0O12( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000O4 */
            pr_default.execute(2, new Object[] {A11ModCod, A12MenCod, A13SubCod});
            if ( (pr_default.getStatus(2) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"MENUSUB"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(2) == 101) || ( StringUtil.StrCmp(Z80SubDsc, T000O4_A80SubDsc[0]) != 0 ) || ( StringUtil.StrCmp(Z81SubLink, T000O4_A81SubLink[0]) != 0 ) || ( StringUtil.StrCmp(Z82SubEti, T000O4_A82SubEti[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z80SubDsc, T000O4_A80SubDsc[0]) != 0 )
               {
                  GXUtil.WriteLog("menu:[seudo value changed for attri]"+"SubDsc");
                  GXUtil.WriteLogRaw("Old: ",Z80SubDsc);
                  GXUtil.WriteLogRaw("Current: ",T000O4_A80SubDsc[0]);
               }
               if ( StringUtil.StrCmp(Z81SubLink, T000O4_A81SubLink[0]) != 0 )
               {
                  GXUtil.WriteLog("menu:[seudo value changed for attri]"+"SubLink");
                  GXUtil.WriteLogRaw("Old: ",Z81SubLink);
                  GXUtil.WriteLogRaw("Current: ",T000O4_A81SubLink[0]);
               }
               if ( StringUtil.StrCmp(Z82SubEti, T000O4_A82SubEti[0]) != 0 )
               {
                  GXUtil.WriteLog("menu:[seudo value changed for attri]"+"SubEti");
                  GXUtil.WriteLogRaw("Old: ",Z82SubEti);
                  GXUtil.WriteLogRaw("Current: ",T000O4_A82SubEti[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"MENUSUB"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0O12( )
      {
         BeforeValidate0O12( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0O12( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0O12( 0) ;
            CheckOptimisticConcurrency0O12( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0O12( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0O12( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000O19 */
                     pr_default.execute(17, new Object[] {A11ModCod, A12MenCod, A13SubCod, n80SubDsc, A80SubDsc, n81SubLink, A81SubLink, n82SubEti, A82SubEti});
                     pr_default.close(17);
                     dsDefault.SmartCacheProvider.SetUpdated("MENUSUB") ;
                     if ( (pr_default.getStatus(17) == 1) )
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
                           ProcessLevel0O12( ) ;
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
               Load0O12( ) ;
            }
            EndLevel0O12( ) ;
         }
         CloseExtendedTableCursors0O12( ) ;
      }

      protected void Update0O12( )
      {
         BeforeValidate0O12( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0O12( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0O12( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0O12( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0O12( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000O20 */
                     pr_default.execute(18, new Object[] {n80SubDsc, A80SubDsc, n81SubLink, A81SubLink, n82SubEti, A82SubEti, A11ModCod, A12MenCod, A13SubCod});
                     pr_default.close(18);
                     dsDefault.SmartCacheProvider.SetUpdated("MENUSUB") ;
                     if ( (pr_default.getStatus(18) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"MENUSUB"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0O12( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0O12( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey0O12( ) ;
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
            EndLevel0O12( ) ;
         }
         CloseExtendedTableCursors0O12( ) ;
      }

      protected void DeferredUpdate0O12( )
      {
      }

      protected void Delete0O12( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0O12( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0O12( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0O12( ) ;
            AfterConfirm0O12( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0O12( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart0O13( ) ;
                  while ( RcdFound13 != 0 )
                  {
                     getByPrimaryKey0O13( ) ;
                     Delete0O13( ) ;
                     ScanNext0O13( ) ;
                  }
                  ScanEnd0O13( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000O21 */
                     pr_default.execute(19, new Object[] {A11ModCod, A12MenCod, A13SubCod});
                     pr_default.close(19);
                     dsDefault.SmartCacheProvider.SetUpdated("MENUSUB") ;
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
         sMode12 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0O12( ) ;
         Gx_mode = sMode12;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0O12( )
      {
         standaloneModal0O12( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000O22 */
            pr_default.execute(20, new Object[] {A11ModCod, A12MenCod, A13SubCod});
            if ( (pr_default.getStatus(20) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Level1"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(20);
         }
      }

      protected void ProcessNestedLevel0O13( )
      {
         nGXsfl_72_idx = 0;
         while ( nGXsfl_72_idx < nRC_GXsfl_72 )
         {
            ReadRow0O13( ) ;
            if ( ( nRcdExists_13 != 0 ) || ( nIsMod_13 != 0 ) )
            {
               standaloneNotModal0O13( ) ;
               GetKey0O13( ) ;
               if ( ( nRcdExists_13 == 0 ) && ( nRcdDeleted_13 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  Insert0O13( ) ;
               }
               else
               {
                  if ( RcdFound13 != 0 )
                  {
                     if ( ( nRcdDeleted_13 != 0 ) && ( nRcdExists_13 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        Delete0O13( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_13 != 0 ) && ( nRcdExists_13 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           Update0O13( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_13 == 0 )
                     {
                        GXCCtl = "SUBCOD_" + sGXsfl_45_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtSubCod_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtavnRcdDeleted_13_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_13), 4, 0, ",", ""))) ;
            ChangePostValue( edtSub1Cod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A14Sub1Cod), 4, 0, ",", ""))) ;
            ChangePostValue( edtSub1Dsc_Internalname, StringUtil.RTrim( A83Sub1Dsc)) ;
            ChangePostValue( edtSub1Link_Internalname, StringUtil.RTrim( A84Sub1Link)) ;
            ChangePostValue( edtSub1Eti_Internalname, StringUtil.RTrim( A85Sub1Eti)) ;
            ChangePostValue( "ZT_"+"Z14Sub1Cod_"+sGXsfl_72_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z14Sub1Cod), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z83Sub1Dsc_"+sGXsfl_72_idx, StringUtil.RTrim( Z83Sub1Dsc)) ;
            ChangePostValue( "ZT_"+"Z84Sub1Link_"+sGXsfl_72_idx, StringUtil.RTrim( Z84Sub1Link)) ;
            ChangePostValue( "ZT_"+"Z85Sub1Eti_"+sGXsfl_72_idx, StringUtil.RTrim( Z85Sub1Eti)) ;
            ChangePostValue( "nRcdDeleted_13_"+sGXsfl_72_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_13), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_13_"+sGXsfl_72_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_13), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_13_"+sGXsfl_72_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_13), 4, 0, ",", ""))) ;
            if ( nIsMod_13 != 0 )
            {
               ChangePostValue( "vNRCDDELETED_13_"+sGXsfl_72_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavnRcdDeleted_13_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUB1COD_"+sGXsfl_72_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSub1Cod_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUB1DSC_"+sGXsfl_72_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSub1Dsc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUB1LINK_"+sGXsfl_72_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSub1Link_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUB1ETI_"+sGXsfl_72_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSub1Eti_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0O13( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_13 = 0;
         nIsMod_13 = 0;
         nRcdDeleted_13 = 0;
      }

      protected void ProcessLevel0O12( )
      {
         /* Save parent mode. */
         sMode12 = Gx_mode;
         ProcessNestedLevel0O13( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode12;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel0O12( )
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

      public void ScanStart0O12( )
      {
         /* Scan By routine */
         /* Using cursor T000O23 */
         pr_default.execute(21, new Object[] {A11ModCod, A12MenCod});
         RcdFound12 = 0;
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound12 = 1;
            A13SubCod = T000O23_A13SubCod[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0O12( )
      {
         /* Scan next routine */
         pr_default.readNext(21);
         RcdFound12 = 0;
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound12 = 1;
            A13SubCod = T000O23_A13SubCod[0];
         }
      }

      protected void ScanEnd0O12( )
      {
         pr_default.close(21);
      }

      protected void AfterConfirm0O12( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0O12( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0O12( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0O12( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0O12( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0O12( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0O12( )
      {
         edtSubCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSubCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSubCod_Enabled), 5, 0)), !bGXsfl_45_Refreshing);
         edtSubDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSubDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSubDsc_Enabled), 5, 0)), !bGXsfl_45_Refreshing);
         edtSubLink_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSubLink_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSubLink_Enabled), 5, 0)), !bGXsfl_45_Refreshing);
         edtSubEti_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSubEti_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSubEti_Enabled), 5, 0)), !bGXsfl_45_Refreshing);
      }

      protected void ZM0O13( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z83Sub1Dsc = T000O3_A83Sub1Dsc[0];
               Z84Sub1Link = T000O3_A84Sub1Link[0];
               Z85Sub1Eti = T000O3_A85Sub1Eti[0];
            }
            else
            {
               Z83Sub1Dsc = A83Sub1Dsc;
               Z84Sub1Link = A84Sub1Link;
               Z85Sub1Eti = A85Sub1Eti;
            }
         }
         if ( GX_JID == -3 )
         {
            Z11ModCod = A11ModCod;
            Z12MenCod = A12MenCod;
            Z13SubCod = A13SubCod;
            Z14Sub1Cod = A14Sub1Cod;
            Z83Sub1Dsc = A83Sub1Dsc;
            Z84Sub1Link = A84Sub1Link;
            Z85Sub1Eti = A85Sub1Eti;
         }
      }

      protected void standaloneNotModal0O13( )
      {
      }

      protected void standaloneModal0O13( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtSub1Cod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSub1Cod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSub1Cod_Enabled), 5, 0)), !bGXsfl_72_Refreshing);
         }
         else
         {
            edtSub1Cod_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSub1Cod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSub1Cod_Enabled), 5, 0)), !bGXsfl_72_Refreshing);
         }
      }

      protected void Load0O13( )
      {
         /* Using cursor T000O24 */
         pr_default.execute(22, new Object[] {A11ModCod, A12MenCod, A13SubCod, A14Sub1Cod});
         if ( (pr_default.getStatus(22) != 101) )
         {
            RcdFound13 = 1;
            A83Sub1Dsc = T000O24_A83Sub1Dsc[0];
            n83Sub1Dsc = T000O24_n83Sub1Dsc[0];
            A84Sub1Link = T000O24_A84Sub1Link[0];
            n84Sub1Link = T000O24_n84Sub1Link[0];
            A85Sub1Eti = T000O24_A85Sub1Eti[0];
            n85Sub1Eti = T000O24_n85Sub1Eti[0];
            ZM0O13( -3) ;
         }
         pr_default.close(22);
         OnLoadActions0O13( ) ;
      }

      protected void OnLoadActions0O13( )
      {
      }

      protected void CheckExtendedTable0O13( )
      {
         Gx_BScreen = 1;
         standaloneModal0O13( ) ;
      }

      protected void CloseExtendedTableCursors0O13( )
      {
      }

      protected void enableDisable0O13( )
      {
      }

      protected void GetKey0O13( )
      {
         /* Using cursor T000O25 */
         pr_default.execute(23, new Object[] {A11ModCod, A12MenCod, A13SubCod, A14Sub1Cod});
         if ( (pr_default.getStatus(23) != 101) )
         {
            RcdFound13 = 1;
         }
         else
         {
            RcdFound13 = 0;
         }
         pr_default.close(23);
      }

      protected void getByPrimaryKey0O13( )
      {
         /* Using cursor T000O3 */
         pr_default.execute(1, new Object[] {A11ModCod, A12MenCod, A13SubCod, A14Sub1Cod});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0O13( 3) ;
            RcdFound13 = 1;
            InitializeNonKey0O13( ) ;
            A14Sub1Cod = T000O3_A14Sub1Cod[0];
            A83Sub1Dsc = T000O3_A83Sub1Dsc[0];
            n83Sub1Dsc = T000O3_n83Sub1Dsc[0];
            A84Sub1Link = T000O3_A84Sub1Link[0];
            n84Sub1Link = T000O3_n84Sub1Link[0];
            A85Sub1Eti = T000O3_A85Sub1Eti[0];
            n85Sub1Eti = T000O3_n85Sub1Eti[0];
            Z11ModCod = A11ModCod;
            Z12MenCod = A12MenCod;
            Z13SubCod = A13SubCod;
            Z14Sub1Cod = A14Sub1Cod;
            sMode13 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal0O13( ) ;
            Load0O13( ) ;
            Gx_mode = sMode13;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound13 = 0;
            InitializeNonKey0O13( ) ;
            sMode13 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal0O13( ) ;
            Gx_mode = sMode13;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes0O13( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0O13( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000O2 */
            pr_default.execute(0, new Object[] {A11ModCod, A12MenCod, A13SubCod, A14Sub1Cod});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"MENUSUB1"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z83Sub1Dsc, T000O2_A83Sub1Dsc[0]) != 0 ) || ( StringUtil.StrCmp(Z84Sub1Link, T000O2_A84Sub1Link[0]) != 0 ) || ( StringUtil.StrCmp(Z85Sub1Eti, T000O2_A85Sub1Eti[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z83Sub1Dsc, T000O2_A83Sub1Dsc[0]) != 0 )
               {
                  GXUtil.WriteLog("menu:[seudo value changed for attri]"+"Sub1Dsc");
                  GXUtil.WriteLogRaw("Old: ",Z83Sub1Dsc);
                  GXUtil.WriteLogRaw("Current: ",T000O2_A83Sub1Dsc[0]);
               }
               if ( StringUtil.StrCmp(Z84Sub1Link, T000O2_A84Sub1Link[0]) != 0 )
               {
                  GXUtil.WriteLog("menu:[seudo value changed for attri]"+"Sub1Link");
                  GXUtil.WriteLogRaw("Old: ",Z84Sub1Link);
                  GXUtil.WriteLogRaw("Current: ",T000O2_A84Sub1Link[0]);
               }
               if ( StringUtil.StrCmp(Z85Sub1Eti, T000O2_A85Sub1Eti[0]) != 0 )
               {
                  GXUtil.WriteLog("menu:[seudo value changed for attri]"+"Sub1Eti");
                  GXUtil.WriteLogRaw("Old: ",Z85Sub1Eti);
                  GXUtil.WriteLogRaw("Current: ",T000O2_A85Sub1Eti[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"MENUSUB1"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0O13( )
      {
         BeforeValidate0O13( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0O13( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0O13( 0) ;
            CheckOptimisticConcurrency0O13( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0O13( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0O13( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000O26 */
                     pr_default.execute(24, new Object[] {A11ModCod, A12MenCod, A13SubCod, A14Sub1Cod, n83Sub1Dsc, A83Sub1Dsc, n84Sub1Link, A84Sub1Link, n85Sub1Eti, A85Sub1Eti});
                     pr_default.close(24);
                     dsDefault.SmartCacheProvider.SetUpdated("MENUSUB1") ;
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
               Load0O13( ) ;
            }
            EndLevel0O13( ) ;
         }
         CloseExtendedTableCursors0O13( ) ;
      }

      protected void Update0O13( )
      {
         BeforeValidate0O13( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0O13( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0O13( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0O13( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0O13( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000O27 */
                     pr_default.execute(25, new Object[] {n83Sub1Dsc, A83Sub1Dsc, n84Sub1Link, A84Sub1Link, n85Sub1Eti, A85Sub1Eti, A11ModCod, A12MenCod, A13SubCod, A14Sub1Cod});
                     pr_default.close(25);
                     dsDefault.SmartCacheProvider.SetUpdated("MENUSUB1") ;
                     if ( (pr_default.getStatus(25) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"MENUSUB1"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0O13( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey0O13( ) ;
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
            EndLevel0O13( ) ;
         }
         CloseExtendedTableCursors0O13( ) ;
      }

      protected void DeferredUpdate0O13( )
      {
      }

      protected void Delete0O13( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0O13( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0O13( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0O13( ) ;
            AfterConfirm0O13( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0O13( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000O28 */
                  pr_default.execute(26, new Object[] {A11ModCod, A12MenCod, A13SubCod, A14Sub1Cod});
                  pr_default.close(26);
                  dsDefault.SmartCacheProvider.SetUpdated("MENUSUB1") ;
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
         sMode13 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0O13( ) ;
         Gx_mode = sMode13;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0O13( )
      {
         standaloneModal0O13( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0O13( )
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

      public void ScanStart0O13( )
      {
         /* Scan By routine */
         /* Using cursor T000O29 */
         pr_default.execute(27, new Object[] {A11ModCod, A12MenCod, A13SubCod});
         RcdFound13 = 0;
         if ( (pr_default.getStatus(27) != 101) )
         {
            RcdFound13 = 1;
            A14Sub1Cod = T000O29_A14Sub1Cod[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0O13( )
      {
         /* Scan next routine */
         pr_default.readNext(27);
         RcdFound13 = 0;
         if ( (pr_default.getStatus(27) != 101) )
         {
            RcdFound13 = 1;
            A14Sub1Cod = T000O29_A14Sub1Cod[0];
         }
      }

      protected void ScanEnd0O13( )
      {
         pr_default.close(27);
      }

      protected void AfterConfirm0O13( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0O13( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0O13( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0O13( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0O13( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0O13( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0O13( )
      {
         edtSub1Cod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSub1Cod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSub1Cod_Enabled), 5, 0)), !bGXsfl_72_Refreshing);
         edtSub1Dsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSub1Dsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSub1Dsc_Enabled), 5, 0)), !bGXsfl_72_Refreshing);
         edtSub1Link_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSub1Link_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSub1Link_Enabled), 5, 0)), !bGXsfl_72_Refreshing);
         edtSub1Eti_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSub1Eti_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSub1Eti_Enabled), 5, 0)), !bGXsfl_72_Refreshing);
      }

      protected void send_integrity_lvl_hashes0O13( )
      {
      }

      protected void send_integrity_lvl_hashes0O12( )
      {
      }

      protected void send_integrity_lvl_hashes0O11( )
      {
      }

      protected void SubsflControlProps_4512( )
      {
         lblTextblock6_Internalname = "TEXTBLOCK6_"+sGXsfl_45_idx;
         edtSubCod_Internalname = "SUBCOD_"+sGXsfl_45_idx;
         lblTextblock7_Internalname = "TEXTBLOCK7_"+sGXsfl_45_idx;
         edtSubDsc_Internalname = "SUBDSC_"+sGXsfl_45_idx;
         lblTextblock8_Internalname = "TEXTBLOCK8_"+sGXsfl_45_idx;
         edtSubLink_Internalname = "SUBLINK_"+sGXsfl_45_idx;
         lblTextblock9_Internalname = "TEXTBLOCK9_"+sGXsfl_45_idx;
         edtSubEti_Internalname = "SUBETI_"+sGXsfl_45_idx;
         subGrid2_Internalname = "GRID2_"+sGXsfl_45_idx;
      }

      protected void SubsflControlProps_fel_4512( )
      {
         lblTextblock6_Internalname = "TEXTBLOCK6_"+sGXsfl_45_fel_idx;
         edtSubCod_Internalname = "SUBCOD_"+sGXsfl_45_fel_idx;
         lblTextblock7_Internalname = "TEXTBLOCK7_"+sGXsfl_45_fel_idx;
         edtSubDsc_Internalname = "SUBDSC_"+sGXsfl_45_fel_idx;
         lblTextblock8_Internalname = "TEXTBLOCK8_"+sGXsfl_45_fel_idx;
         edtSubLink_Internalname = "SUBLINK_"+sGXsfl_45_fel_idx;
         lblTextblock9_Internalname = "TEXTBLOCK9_"+sGXsfl_45_fel_idx;
         edtSubEti_Internalname = "SUBETI_"+sGXsfl_45_fel_idx;
         subGrid2_Internalname = "GRID2_"+sGXsfl_45_fel_idx;
      }

      protected void AddRow0O12( )
      {
         nRC_GXsfl_72 = 0;
         nGXsfl_45_idx = (short)(nGXsfl_45_idx+1);
         sGXsfl_45_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_45_idx), 4, 0)), 4, "0");
         SubsflControlProps_4512( ) ;
         SendRow0O12( ) ;
      }

      protected void SendRow0O12( )
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
            subGrid1_Backcolor = (int)(0xFFFFFF);
         }
         else if ( subGrid1_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGrid1_Backstyle = 1;
            if ( ((int)(((nGXsfl_45_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGrid1_Backcolor = (int)(0xFFFFFF);
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
         /* Start of Columns property logic. */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            if ( ( 1 == 0 ) && ( nGXsfl_45_idx == 1 ) )
            {
               context.WriteHtmlText( "<tr"+" class=\""+subGrid1_Linesclass+"\" style=\""+""+"\""+" data-gxrow=\""+sGXsfl_45_idx+"\">") ;
            }
            if ( 1 > 0 )
            {
               if ( ( 1 == 1 ) || ( ((int)((nGXsfl_45_idx) % (1))) - 1 == 0 ) )
               {
                  context.WriteHtmlText( "<tr"+" class=\""+subGrid1_Linesclass+"\" style=\""+""+"\""+" data-gxrow=\""+sGXsfl_45_idx+"\">") ;
               }
            }
         }
         if ( GRID1_IsPaging == 0 )
         {
            GXCCtl = "GRID2_nFirstRecordOnPage_" + sGXsfl_45_idx;
            GRID2_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         }
         else
         {
            GRID2_nFirstRecordOnPage = 0;
         }
         Grid1Row.AddColumnProperties("row", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)subGrid1_Linesclass,(String)""});
         Grid1Row.AddColumnProperties("cell", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)""});
         /* Table start */
         Grid1Row.AddColumnProperties("table", -1, isAjaxCallMode( ), new Object[] {(String)tblTable3_Internalname+"_"+sGXsfl_45_idx,(short)1,(String)"Table",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(short)2,(String)"",(String)"",(String)"",(String)"px",(String)"px",(String)""});
         Grid1Row.AddColumnProperties("row", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)"",(String)""});
         Grid1Row.AddColumnProperties("cell", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)""});
         /* Text block */
         Grid1Row.AddColumnProperties("label", 1, isAjaxCallMode( ), new Object[] {(String)lblTextblock6_Internalname,(String)"Codigo",(String)"",(String)"",(String)lblTextblock6_Jsonclick,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"TextBlock",(short)0,(String)"",(short)1,(short)1,(short)0});
         Grid1Row.AddColumnProperties("cell", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)""});
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_12_" + sGXsfl_45_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 53,'',false,'" + sGXsfl_45_idx + "',45)\"";
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSubCod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A13SubCod), 4, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A13SubCod), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSubCod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)1,(int)edtSubCod_Enabled,(short)1,(String)"number",(String)"1",(short)4,(String)"chr",(short)1,(String)"row",(short)4,(short)0,(short)0,(short)45,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         Grid1Row.AddColumnProperties("row", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)"",(String)""});
         Grid1Row.AddColumnProperties("cell", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)""});
         /* Text block */
         Grid1Row.AddColumnProperties("label", 1, isAjaxCallMode( ), new Object[] {(String)lblTextblock7_Internalname,(String)"Submenu",(String)"",(String)"",(String)lblTextblock7_Jsonclick,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"TextBlock",(short)0,(String)"",(short)1,(short)1,(short)0});
         Grid1Row.AddColumnProperties("cell", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)""});
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_12_" + sGXsfl_45_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 58,'',false,'" + sGXsfl_45_idx + "',45)\"";
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSubDsc_Internalname,StringUtil.RTrim( A80SubDsc),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSubDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)1,(int)edtSubDsc_Enabled,(short)0,(String)"text",(String)"",(short)30,(String)"chr",(short)1,(String)"row",(short)30,(short)0,(short)0,(short)45,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         Grid1Row.AddColumnProperties("row", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)"",(String)""});
         Grid1Row.AddColumnProperties("cell", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)""});
         /* Text block */
         Grid1Row.AddColumnProperties("label", 1, isAjaxCallMode( ), new Object[] {(String)lblTextblock8_Internalname,(String)"Link",(String)"",(String)"",(String)lblTextblock8_Jsonclick,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"TextBlock",(short)0,(String)"",(short)1,(short)1,(short)0});
         Grid1Row.AddColumnProperties("cell", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)""});
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_12_" + sGXsfl_45_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 63,'',false,'" + sGXsfl_45_idx + "',45)\"";
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSubLink_Internalname,StringUtil.RTrim( A81SubLink),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSubLink_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)1,(int)edtSubLink_Enabled,(short)0,(String)"text",(String)"",(short)30,(String)"chr",(short)1,(String)"row",(short)30,(short)0,(short)0,(short)45,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         Grid1Row.AddColumnProperties("row", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)"",(String)""});
         Grid1Row.AddColumnProperties("cell", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)""});
         /* Text block */
         Grid1Row.AddColumnProperties("label", 1, isAjaxCallMode( ), new Object[] {(String)lblTextblock9_Internalname,(String)"Etiqueta",(String)"",(String)"",(String)lblTextblock9_Jsonclick,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"TextBlock",(short)0,(String)"",(short)1,(short)1,(short)0});
         Grid1Row.AddColumnProperties("cell", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)""});
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_12_" + sGXsfl_45_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 68,'',false,'" + sGXsfl_45_idx + "',45)\"";
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSubEti_Internalname,StringUtil.RTrim( A82SubEti),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,68);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSubEti_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)1,(int)edtSubEti_Enabled,(short)0,(String)"text",(String)"",(short)30,(String)"chr",(short)1,(String)"row",(short)30,(short)0,(short)0,(short)45,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         Grid1Row.AddColumnProperties("row", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)"",(String)""});
         Grid1Row.AddColumnProperties("cell", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)""});
         Grid1Row.AddColumnProperties("cell", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)""});
         /*  Child Grid Control  */
         Grid1Row.AddColumnProperties("subfile", -1, isAjaxCallMode( ), new Object[] {(String)"Grid2Container"});
         if ( isAjaxCallMode( ) )
         {
            Grid2Container = new GXWebGrid( context);
         }
         else
         {
            Grid2Container.Clear();
         }
         Grid2Container.AddObjectProperty("GridName", "Grid2");
         Grid2Container.AddObjectProperty("Header", subGrid2_Header);
         Grid2Container.AddObjectProperty("Class", "Grid");
         Grid2Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Grid2Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Grid2Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Backcolorstyle), 1, 0, ".", "")));
         Grid2Container.AddObjectProperty("CmpContext", "");
         Grid2Container.AddObjectProperty("InMasterPage", "false");
         Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid2Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_13), 4, 0, ".", "")));
         Grid2Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavnRcdDeleted_13_Enabled), 5, 0, ".", "")));
         Grid2Container.AddColumnProperties(Grid2Column);
         Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid2Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A14Sub1Cod), 4, 0, ".", "")));
         Grid2Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSub1Cod_Enabled), 5, 0, ".", "")));
         Grid2Container.AddColumnProperties(Grid2Column);
         Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid2Column.AddObjectProperty("Value", StringUtil.RTrim( A83Sub1Dsc));
         Grid2Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSub1Dsc_Enabled), 5, 0, ".", "")));
         Grid2Container.AddColumnProperties(Grid2Column);
         Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid2Column.AddObjectProperty("Value", StringUtil.RTrim( A84Sub1Link));
         Grid2Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSub1Link_Enabled), 5, 0, ".", "")));
         Grid2Container.AddColumnProperties(Grid2Column);
         Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid2Column.AddObjectProperty("Value", StringUtil.RTrim( A85Sub1Eti));
         Grid2Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSub1Eti_Enabled), 5, 0, ".", "")));
         Grid2Container.AddColumnProperties(Grid2Column);
         Grid2Container.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Selectedindex), 4, 0, ".", "")));
         Grid2Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Allowselection), 1, 0, ".", "")));
         Grid2Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Selectioncolor), 9, 0, ".", "")));
         Grid2Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Allowhovering), 1, 0, ".", "")));
         Grid2Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Hoveringcolor), 9, 0, ".", "")));
         Grid2Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Allowcollapsing), 1, 0, ".", "")));
         Grid2Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Collapsed), 1, 0, ".", "")));
         nGXsfl_72_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount13 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_13 = 1;
               ScanStart0O13( ) ;
               while ( RcdFound13 != 0 )
               {
                  init_level_properties13( ) ;
                  getByPrimaryKey0O13( ) ;
                  AddRow0O13( ) ;
                  ScanNext0O13( ) ;
               }
               ScanEnd0O13( ) ;
               nBlankRcdCount13 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal0O13( ) ;
            standaloneModal0O13( ) ;
            sMode13 = Gx_mode;
            while ( nGXsfl_72_idx < nRC_GXsfl_72 )
            {
               bGXsfl_72_Refreshing = true;
               ReadRow0O13( ) ;
               edtavnRcdDeleted_13_Enabled = (int)(context.localUtil.CToN( cgiGet( "vNRCDDELETED_13_"+sGXsfl_72_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavnRcdDeleted_13_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavnRcdDeleted_13_Enabled), 5, 0)), !bGXsfl_72_Refreshing);
               edtSub1Cod_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUB1COD_"+sGXsfl_72_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSub1Cod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSub1Cod_Enabled), 5, 0)), !bGXsfl_72_Refreshing);
               edtSub1Dsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUB1DSC_"+sGXsfl_72_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSub1Dsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSub1Dsc_Enabled), 5, 0)), !bGXsfl_72_Refreshing);
               edtSub1Link_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUB1LINK_"+sGXsfl_72_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSub1Link_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSub1Link_Enabled), 5, 0)), !bGXsfl_72_Refreshing);
               edtSub1Eti_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUB1ETI_"+sGXsfl_72_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSub1Eti_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSub1Eti_Enabled), 5, 0)), !bGXsfl_72_Refreshing);
               if ( ( nRcdExists_13 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  standaloneModal0O13( ) ;
               }
               SendRow0O13( ) ;
               bGXsfl_72_Refreshing = false;
            }
            Gx_mode = sMode13;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount13 = 5;
            nRcdExists_13 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart0O13( ) ;
               while ( RcdFound13 != 0 )
               {
                  sGXsfl_72_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_72_idx+1), 4, 0)), 4, "0") + sGXsfl_45_idx;
                  SubsflControlProps_7213( ) ;
                  init_level_properties13( ) ;
                  standaloneNotModal0O13( ) ;
                  getByPrimaryKey0O13( ) ;
                  standaloneModal0O13( ) ;
                  AddRow0O13( ) ;
                  ScanNext0O13( ) ;
               }
               ScanEnd0O13( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         sMode13 = Gx_mode;
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         sGXsfl_72_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_72_idx+1), 4, 0)), 4, "0") + sGXsfl_45_idx;
         SubsflControlProps_7213( ) ;
         InitAll0O13( ) ;
         init_level_properties13( ) ;
         standaloneNotModal0O13( ) ;
         standaloneModal0O13( ) ;
         nRcdExists_13 = 0;
         nIsMod_13 = 0;
         nRcdDeleted_13 = 0;
         if ( ( NumberUtil.Val( EvtGridId, ".") + NumberUtil.Val( EvtRowId, ".") == Convert.ToDecimal( 0 )) || (Convert.ToDecimal( 45 ) == NumberUtil.Val( EvtGridId, ".") ) && ( NumberUtil.Val( EvtRowId, ".") == NumberUtil.Val( sGXsfl_45_idx, ".") ) )
         {
            nBlankRcdCount13 = (short)(nBlankRcdUsr13+nBlankRcdCount13);
         }
         fRowAdded = 0;
         while ( nBlankRcdCount13 > 0 )
         {
            AddRow0O13( ) ;
            if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
            {
               fRowAdded = 1;
               GX_FocusControl = edtSub1Cod_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nBlankRcdCount13 = (short)(nBlankRcdCount13-1);
         }
         Gx_mode = sMode13;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         if ( ! isAjaxCallMode( ) )
         {
            GxWebStd.gx_hidden_field( context, "Grid2ContainerData"+"_"+sGXsfl_45_idx, Grid2Container.ToJavascriptSource());
         }
         if ( isAjaxCallMode( ) )
         {
            Grid1Row.AddGrid("Grid2", Grid2Container);
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Grid2ContainerData"+"V_"+sGXsfl_45_idx, Grid2Container.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid2ContainerData"+"V_"+sGXsfl_45_idx+"\" value='"+Grid2Container.GridValuesHidden()+"'/>") ;
         }
         /* End of table */
         context.httpAjaxContext.ajax_sending_grid_row(Grid1Row);
         send_integrity_lvl_hashes0O12( ) ;
         GXCCtl = "Z13SubCod_" + sGXsfl_45_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z13SubCod), 4, 0, ",", "")));
         GXCCtl = "Z80SubDsc_" + sGXsfl_45_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z80SubDsc));
         GXCCtl = "Z81SubLink_" + sGXsfl_45_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z81SubLink));
         GXCCtl = "Z82SubEti_" + sGXsfl_45_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z82SubEti));
         GXCCtl = "nRC_GXsfl_72_" + sGXsfl_45_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_72_idx), 4, 0, ",", "")));
         GXCCtl = "nRcdDeleted_12_" + sGXsfl_45_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_12), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_12_" + sGXsfl_45_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_12), 4, 0, ",", "")));
         GXCCtl = "nIsMod_12_" + sGXsfl_45_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_12), 4, 0, ",", "")));
         GXCCtl = "vMODE_" + sGXsfl_45_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "SUBCOD_"+sGXsfl_45_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSubCod_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SUBDSC_"+sGXsfl_45_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSubDsc_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SUBLINK_"+sGXsfl_45_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSubLink_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SUBETI_"+sGXsfl_45_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSubEti_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         GRID2_nFirstRecordOnPage = 0;
         GRID2_nCurrentRecord = 0;
         /* End of Columns property logic. */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            if ( 1 > 0 )
            {
               if ( ((int)((nGXsfl_45_idx) % (1))) == 0 )
               {
                  context.WriteHtmlTextNl( "</tr>") ;
               }
            }
         }
         Grid1Container.AddRow(Grid1Row);
      }

      protected void ReadRow0O12( )
      {
         nGXsfl_45_idx = (short)(nGXsfl_45_idx+1);
         sGXsfl_45_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_45_idx), 4, 0)), 4, "0");
         SubsflControlProps_4512( ) ;
         edtSubCod_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCOD_"+sGXsfl_45_idx+"Enabled"), ",", "."));
         edtSubDsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBDSC_"+sGXsfl_45_idx+"Enabled"), ",", "."));
         edtSubLink_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBLINK_"+sGXsfl_45_idx+"Enabled"), ",", "."));
         edtSubEti_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBETI_"+sGXsfl_45_idx+"Enabled"), ",", "."));
         if ( ( ( context.localUtil.CToN( cgiGet( edtSubCod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSubCod_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "SUBCOD_" + sGXsfl_45_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtSubCod_Internalname;
            wbErr = true;
            A13SubCod = 0;
         }
         else
         {
            A13SubCod = (short)(context.localUtil.CToN( cgiGet( edtSubCod_Internalname), ",", "."));
         }
         A80SubDsc = cgiGet( edtSubDsc_Internalname);
         n80SubDsc = false;
         n80SubDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A80SubDsc)) ? true : false);
         A81SubLink = cgiGet( edtSubLink_Internalname);
         n81SubLink = false;
         n81SubLink = (String.IsNullOrEmpty(StringUtil.RTrim( A81SubLink)) ? true : false);
         A82SubEti = cgiGet( edtSubEti_Internalname);
         n82SubEti = false;
         n82SubEti = (String.IsNullOrEmpty(StringUtil.RTrim( A82SubEti)) ? true : false);
         GXCCtl = "Z13SubCod_" + sGXsfl_45_idx;
         Z13SubCod = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z80SubDsc_" + sGXsfl_45_idx;
         Z80SubDsc = cgiGet( GXCCtl);
         n80SubDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A80SubDsc)) ? true : false);
         GXCCtl = "Z81SubLink_" + sGXsfl_45_idx;
         Z81SubLink = cgiGet( GXCCtl);
         n81SubLink = (String.IsNullOrEmpty(StringUtil.RTrim( A81SubLink)) ? true : false);
         GXCCtl = "Z82SubEti_" + sGXsfl_45_idx;
         Z82SubEti = cgiGet( GXCCtl);
         n82SubEti = (String.IsNullOrEmpty(StringUtil.RTrim( A82SubEti)) ? true : false);
         GXCCtl = "nRC_GXsfl_72_" + sGXsfl_45_idx;
         nRC_GXsfl_72 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdDeleted_12_" + sGXsfl_45_idx;
         nRcdDeleted_12 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_12_" + sGXsfl_45_idx;
         nRcdExists_12 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_12_" + sGXsfl_45_idx;
         nIsMod_12 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRC_GXsfl_72_" + sGXsfl_45_idx;
         nRC_GXsfl_72 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void SubsflControlProps_7213( )
      {
         edtavnRcdDeleted_13_Internalname = "vNRCDDELETED_13_"+sGXsfl_72_idx;
         edtSub1Cod_Internalname = "SUB1COD_"+sGXsfl_72_idx;
         edtSub1Dsc_Internalname = "SUB1DSC_"+sGXsfl_72_idx;
         edtSub1Link_Internalname = "SUB1LINK_"+sGXsfl_72_idx;
         edtSub1Eti_Internalname = "SUB1ETI_"+sGXsfl_72_idx;
      }

      protected void SubsflControlProps_fel_7213( )
      {
         edtavnRcdDeleted_13_Internalname = "vNRCDDELETED_13_"+sGXsfl_72_fel_idx;
         edtSub1Cod_Internalname = "SUB1COD_"+sGXsfl_72_fel_idx;
         edtSub1Dsc_Internalname = "SUB1DSC_"+sGXsfl_72_fel_idx;
         edtSub1Link_Internalname = "SUB1LINK_"+sGXsfl_72_fel_idx;
         edtSub1Eti_Internalname = "SUB1ETI_"+sGXsfl_72_fel_idx;
      }

      protected void AddRow0O13( )
      {
         nGXsfl_72_idx = (short)(nGXsfl_72_idx+1);
         sGXsfl_72_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_72_idx), 4, 0)), 4, "0") + sGXsfl_45_idx;
         SubsflControlProps_7213( ) ;
         SendRow0O13( ) ;
      }

      protected void SendRow0O13( )
      {
         Grid2Row = GXWebRow.GetNew(context);
         if ( subGrid2_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGrid2_Backstyle = 0;
            if ( StringUtil.StrCmp(subGrid2_Class, "") != 0 )
            {
               subGrid2_Linesclass = subGrid2_Class+"Odd";
            }
         }
         else if ( subGrid2_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGrid2_Backstyle = 0;
            subGrid2_Backcolor = subGrid2_Allbackcolor;
            if ( StringUtil.StrCmp(subGrid2_Class, "") != 0 )
            {
               subGrid2_Linesclass = subGrid2_Class+"Uniform";
            }
         }
         else if ( subGrid2_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGrid2_Backstyle = 1;
            if ( StringUtil.StrCmp(subGrid2_Class, "") != 0 )
            {
               subGrid2_Linesclass = subGrid2_Class+"Odd";
            }
            subGrid2_Backcolor = (int)(0xFFFFFF);
         }
         else if ( subGrid2_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGrid2_Backstyle = 1;
            if ( ((int)(((nGXsfl_72_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGrid2_Backcolor = (int)(0xFFFFFF);
               if ( StringUtil.StrCmp(subGrid2_Class, "") != 0 )
               {
                  subGrid2_Linesclass = subGrid2_Class+"Odd";
               }
            }
            else
            {
               subGrid2_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGrid2_Class, "") != 0 )
               {
                  subGrid2_Linesclass = subGrid2_Class+"Even";
               }
            }
         }
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_13_" + sGXsfl_72_idx + "',1);gx.fn.setControlValue('nIsMod_12_" + sGXsfl_45_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 73,'',false,'" + sGXsfl_72_idx + "',72)\"";
         ROClassString = "Attribute";
         Grid2Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavnRcdDeleted_13_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_13), 4, 0, ",", "")),((edtavnRcdDeleted_13_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(nRcdDeleted_13), "9999")) : context.localUtil.Format( (decimal)(nRcdDeleted_13), "9999")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,73);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavnRcdDeleted_13_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtavnRcdDeleted_13_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)72,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_13_" + sGXsfl_72_idx + "',1);gx.fn.setControlValue('nIsMod_12_" + sGXsfl_45_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 74,'',false,'" + sGXsfl_72_idx + "',72)\"";
         ROClassString = "Attribute";
         Grid2Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSub1Cod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A14Sub1Cod), 4, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A14Sub1Cod), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,74);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSub1Cod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtSub1Cod_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)72,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_13_" + sGXsfl_72_idx + "',1);gx.fn.setControlValue('nIsMod_12_" + sGXsfl_45_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 75,'',false,'" + sGXsfl_72_idx + "',72)\"";
         ROClassString = "Attribute";
         Grid2Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSub1Dsc_Internalname,StringUtil.RTrim( A83Sub1Dsc),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,75);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSub1Dsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtSub1Dsc_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)30,(short)0,(short)0,(short)72,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_13_" + sGXsfl_72_idx + "',1);gx.fn.setControlValue('nIsMod_12_" + sGXsfl_45_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_72_idx + "',72)\"";
         ROClassString = "Attribute";
         Grid2Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSub1Link_Internalname,StringUtil.RTrim( A84Sub1Link),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,76);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSub1Link_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtSub1Link_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)30,(short)0,(short)0,(short)72,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_13_" + sGXsfl_72_idx + "',1);gx.fn.setControlValue('nIsMod_12_" + sGXsfl_45_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 77,'',false,'" + sGXsfl_72_idx + "',72)\"";
         ROClassString = "Attribute";
         Grid2Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSub1Eti_Internalname,StringUtil.RTrim( A85Sub1Eti),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,77);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSub1Eti_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtSub1Eti_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)30,(short)0,(short)0,(short)72,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         context.httpAjaxContext.ajax_sending_grid_row(Grid2Row);
         send_integrity_lvl_hashes0O13( ) ;
         GXCCtl = "Z14Sub1Cod_" + sGXsfl_72_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z14Sub1Cod), 4, 0, ",", "")));
         GXCCtl = "Z83Sub1Dsc_" + sGXsfl_72_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z83Sub1Dsc));
         GXCCtl = "Z84Sub1Link_" + sGXsfl_72_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z84Sub1Link));
         GXCCtl = "Z85Sub1Eti_" + sGXsfl_72_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z85Sub1Eti));
         GXCCtl = "nRcdDeleted_13_" + sGXsfl_72_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_13), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_13_" + sGXsfl_72_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_13), 4, 0, ",", "")));
         GXCCtl = "nIsMod_13_" + sGXsfl_72_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_13), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vNRCDDELETED_13_"+sGXsfl_72_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavnRcdDeleted_13_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SUB1COD_"+sGXsfl_72_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSub1Cod_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SUB1DSC_"+sGXsfl_72_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSub1Dsc_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SUB1LINK_"+sGXsfl_72_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSub1Link_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SUB1ETI_"+sGXsfl_72_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSub1Eti_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Grid2Container.AddRow(Grid2Row);
      }

      protected void ReadRow0O13( )
      {
         nGXsfl_72_idx = (short)(nGXsfl_72_idx+1);
         sGXsfl_72_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_72_idx), 4, 0)), 4, "0") + sGXsfl_45_idx;
         SubsflControlProps_7213( ) ;
         edtavnRcdDeleted_13_Enabled = (int)(context.localUtil.CToN( cgiGet( "vNRCDDELETED_13_"+sGXsfl_72_idx+"Enabled"), ",", "."));
         edtSub1Cod_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUB1COD_"+sGXsfl_72_idx+"Enabled"), ",", "."));
         edtSub1Dsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUB1DSC_"+sGXsfl_72_idx+"Enabled"), ",", "."));
         edtSub1Link_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUB1LINK_"+sGXsfl_72_idx+"Enabled"), ",", "."));
         edtSub1Eti_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUB1ETI_"+sGXsfl_72_idx+"Enabled"), ",", "."));
         if ( ( ( context.localUtil.CToN( cgiGet( edtavnRcdDeleted_13_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavnRcdDeleted_13_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vNRCDDELETED_13");
            AnyError = 1;
            GX_FocusControl = edtavnRcdDeleted_13_Internalname;
            wbErr = true;
            nRcdDeleted_13 = 0;
         }
         else
         {
            nRcdDeleted_13 = (short)(context.localUtil.CToN( cgiGet( edtavnRcdDeleted_13_Internalname), ",", "."));
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtSub1Cod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSub1Cod_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "SUB1COD_" + sGXsfl_72_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtSub1Cod_Internalname;
            wbErr = true;
            A14Sub1Cod = 0;
         }
         else
         {
            A14Sub1Cod = (short)(context.localUtil.CToN( cgiGet( edtSub1Cod_Internalname), ",", "."));
         }
         A83Sub1Dsc = cgiGet( edtSub1Dsc_Internalname);
         n83Sub1Dsc = false;
         n83Sub1Dsc = (String.IsNullOrEmpty(StringUtil.RTrim( A83Sub1Dsc)) ? true : false);
         A84Sub1Link = cgiGet( edtSub1Link_Internalname);
         n84Sub1Link = false;
         n84Sub1Link = (String.IsNullOrEmpty(StringUtil.RTrim( A84Sub1Link)) ? true : false);
         A85Sub1Eti = cgiGet( edtSub1Eti_Internalname);
         n85Sub1Eti = false;
         n85Sub1Eti = (String.IsNullOrEmpty(StringUtil.RTrim( A85Sub1Eti)) ? true : false);
         GXCCtl = "Z14Sub1Cod_" + sGXsfl_72_idx;
         Z14Sub1Cod = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z83Sub1Dsc_" + sGXsfl_72_idx;
         Z83Sub1Dsc = cgiGet( GXCCtl);
         n83Sub1Dsc = (String.IsNullOrEmpty(StringUtil.RTrim( A83Sub1Dsc)) ? true : false);
         GXCCtl = "Z84Sub1Link_" + sGXsfl_72_idx;
         Z84Sub1Link = cgiGet( GXCCtl);
         n84Sub1Link = (String.IsNullOrEmpty(StringUtil.RTrim( A84Sub1Link)) ? true : false);
         GXCCtl = "Z85Sub1Eti_" + sGXsfl_72_idx;
         Z85Sub1Eti = cgiGet( GXCCtl);
         n85Sub1Eti = (String.IsNullOrEmpty(StringUtil.RTrim( A85Sub1Eti)) ? true : false);
         GXCCtl = "nRcdDeleted_13_" + sGXsfl_72_idx;
         nRcdDeleted_13 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_13_" + sGXsfl_72_idx;
         nRcdExists_13 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_13_" + sGXsfl_72_idx;
         nIsMod_13 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void assign_properties_default( )
      {
         defedtSub1Cod_Enabled = edtSub1Cod_Enabled;
         defedtSubCod_Enabled = edtSubCod_Enabled;
      }

      protected void ConfirmValues0O0( )
      {
         nGXsfl_45_idx = 0;
         sGXsfl_45_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_45_idx), 4, 0)), 4, "0");
         SubsflControlProps_4512( ) ;
         while ( nGXsfl_45_idx < nRC_GXsfl_45 )
         {
            nGXsfl_45_idx = (short)(nGXsfl_45_idx+1);
            sGXsfl_45_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_45_idx), 4, 0)), 4, "0");
            SubsflControlProps_4512( ) ;
            ChangePostValue( "Z13SubCod_"+sGXsfl_45_idx, cgiGet( "ZT_"+"Z13SubCod_"+sGXsfl_45_idx)) ;
            DeletePostValue( "ZT_"+"Z13SubCod_"+sGXsfl_45_idx) ;
            ChangePostValue( "Z80SubDsc_"+sGXsfl_45_idx, cgiGet( "ZT_"+"Z80SubDsc_"+sGXsfl_45_idx)) ;
            DeletePostValue( "ZT_"+"Z80SubDsc_"+sGXsfl_45_idx) ;
            ChangePostValue( "Z81SubLink_"+sGXsfl_45_idx, cgiGet( "ZT_"+"Z81SubLink_"+sGXsfl_45_idx)) ;
            DeletePostValue( "ZT_"+"Z81SubLink_"+sGXsfl_45_idx) ;
            ChangePostValue( "Z82SubEti_"+sGXsfl_45_idx, cgiGet( "ZT_"+"Z82SubEti_"+sGXsfl_45_idx)) ;
            DeletePostValue( "ZT_"+"Z82SubEti_"+sGXsfl_45_idx) ;
         }
         nGXsfl_72_idx = 0;
         sGXsfl_72_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_72_idx), 4, 0)), 4, "0") + sGXsfl_45_idx;
         SubsflControlProps_7213( ) ;
         while ( nGXsfl_72_idx < nRC_GXsfl_72 )
         {
            nGXsfl_72_idx = (short)(nGXsfl_72_idx+1);
            sGXsfl_72_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_72_idx), 4, 0)), 4, "0") + sGXsfl_45_idx;
            SubsflControlProps_7213( ) ;
            ChangePostValue( "Z14Sub1Cod_"+sGXsfl_72_idx, cgiGet( "ZT_"+"Z14Sub1Cod_"+sGXsfl_72_idx)) ;
            DeletePostValue( "ZT_"+"Z14Sub1Cod_"+sGXsfl_72_idx) ;
            ChangePostValue( "Z83Sub1Dsc_"+sGXsfl_72_idx, cgiGet( "ZT_"+"Z83Sub1Dsc_"+sGXsfl_72_idx)) ;
            DeletePostValue( "ZT_"+"Z83Sub1Dsc_"+sGXsfl_72_idx) ;
            ChangePostValue( "Z84Sub1Link_"+sGXsfl_72_idx, cgiGet( "ZT_"+"Z84Sub1Link_"+sGXsfl_72_idx)) ;
            DeletePostValue( "ZT_"+"Z84Sub1Link_"+sGXsfl_72_idx) ;
            ChangePostValue( "Z85Sub1Eti_"+sGXsfl_72_idx, cgiGet( "ZT_"+"Z85Sub1Eti_"+sGXsfl_72_idx)) ;
            DeletePostValue( "ZT_"+"Z85Sub1Eti_"+sGXsfl_72_idx) ;
         }
      }

      protected void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, false);
      }

      protected void RenderHtmlOpenForm( )
      {
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( "MENU") ;
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
         context.AddJavascriptSource("gxcfg.js", "?202210262014731", false);
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
         context.WriteHtmlText( " "+"class=\"Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"Form\" data-gx-class=\"Form\" novalidate action=\""+formatLink("menu.aspx") +"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" style=\"display:none\">") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "Form", true);
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z11ModCod", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11ModCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z12MenCod", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z12MenCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z77MenDsc", StringUtil.RTrim( Z77MenDsc));
         GxWebStd.gx_hidden_field( context, "Z78MenLink", StringUtil.RTrim( Z78MenLink));
         GxWebStd.gx_hidden_field( context, "Z79MenIco", StringUtil.RTrim( Z79MenIco));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_45", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_45_idx), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
      }

      protected void RenderHtmlCloseForm0O11( )
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
         context.WriteHtmlTextNl( "</body>") ;
         context.WriteHtmlTextNl( "</html>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
      }

      public override String GetPgmname( )
      {
         return "MENU" ;
      }

      public override String GetPgmdesc( )
      {
         return "MENU" ;
      }

      protected void InitializeNonKey0O11( )
      {
         A77MenDsc = "";
         n77MenDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A77MenDsc", A77MenDsc);
         n77MenDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A77MenDsc)) ? true : false);
         A78MenLink = "";
         n78MenLink = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A78MenLink", A78MenLink);
         n78MenLink = (String.IsNullOrEmpty(StringUtil.RTrim( A78MenLink)) ? true : false);
         A79MenIco = "";
         n79MenIco = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79MenIco", A79MenIco);
         n79MenIco = (String.IsNullOrEmpty(StringUtil.RTrim( A79MenIco)) ? true : false);
         Z77MenDsc = "";
         Z78MenLink = "";
         Z79MenIco = "";
      }

      protected void InitAll0O11( )
      {
         A11ModCod = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11ModCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A11ModCod), 4, 0)));
         A12MenCod = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12MenCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A12MenCod), 4, 0)));
         InitializeNonKey0O11( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey0O12( )
      {
         A80SubDsc = "";
         n80SubDsc = false;
         A81SubLink = "";
         n81SubLink = false;
         A82SubEti = "";
         n82SubEti = false;
         Z80SubDsc = "";
         Z81SubLink = "";
         Z82SubEti = "";
      }

      protected void InitAll0O12( )
      {
         A13SubCod = 0;
         InitializeNonKey0O12( ) ;
      }

      protected void StandaloneModalInsert0O12( )
      {
      }

      protected void InitializeNonKey0O13( )
      {
         A83Sub1Dsc = "";
         n83Sub1Dsc = false;
         A84Sub1Link = "";
         n84Sub1Link = false;
         A85Sub1Eti = "";
         n85Sub1Eti = false;
         Z83Sub1Dsc = "";
         Z84Sub1Link = "";
         Z85Sub1Eti = "";
      }

      protected void InitAll0O13( )
      {
         A14Sub1Cod = 0;
         InitializeNonKey0O13( ) ;
      }

      protected void StandaloneModalInsert0O13( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ), false);
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202210262014737", true);
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
         context.AddJavascriptSource("menu.js", "?202210262014737", false);
         /* End function include_jscripts */
      }

      protected void init_level_properties12( )
      {
         edtSubCod_Enabled = defedtSubCod_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSubCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSubCod_Enabled), 5, 0)), !bGXsfl_45_Refreshing);
      }

      protected void init_level_properties13( )
      {
         edtSub1Cod_Enabled = defedtSub1Cod_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSub1Cod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSub1Cod_Enabled), 5, 0)), !bGXsfl_72_Refreshing);
      }

      protected void init_default_properties( )
      {
         bttBtn_first_Internalname = "BTN_FIRST";
         bttBtn_previous_Internalname = "BTN_PREVIOUS";
         bttBtn_next_Internalname = "BTN_NEXT";
         bttBtn_last_Internalname = "BTN_LAST";
         bttBtn_select_Internalname = "BTN_SELECT";
         lblTextblock1_Internalname = "TEXTBLOCK1";
         edtModCod_Internalname = "MODCOD";
         lblTextblock2_Internalname = "TEXTBLOCK2";
         edtMenCod_Internalname = "MENCOD";
         bttBtn_get_Internalname = "BTN_GET";
         lblTextblock3_Internalname = "TEXTBLOCK3";
         edtMenDsc_Internalname = "MENDSC";
         lblTextblock4_Internalname = "TEXTBLOCK4";
         edtMenLink_Internalname = "MENLINK";
         lblTextblock5_Internalname = "TEXTBLOCK5";
         edtMenIco_Internalname = "MENICO";
         lblTextblock6_Internalname = "TEXTBLOCK6";
         edtSubCod_Internalname = "SUBCOD";
         lblTextblock7_Internalname = "TEXTBLOCK7";
         edtSubDsc_Internalname = "SUBDSC";
         lblTextblock8_Internalname = "TEXTBLOCK8";
         edtSubLink_Internalname = "SUBLINK";
         lblTextblock9_Internalname = "TEXTBLOCK9";
         edtSubEti_Internalname = "SUBETI";
         edtavnRcdDeleted_13_Internalname = "vNRCDDELETED_13";
         edtSub1Cod_Internalname = "SUB1COD";
         edtSub1Dsc_Internalname = "SUB1DSC";
         edtSub1Link_Internalname = "SUB1LINK";
         edtSub1Eti_Internalname = "SUB1ETI";
         tblTable3_Internalname = "TABLE3";
         tblTable2_Internalname = "TABLE2";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         tblTable1_Internalname = "TABLE1";
         Form.Internalname = "FORM";
         subGrid1_Internalname = "GRID1";
         subGrid2_Internalname = "GRID2";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtSub1Eti_Jsonclick = "";
         edtSub1Link_Jsonclick = "";
         edtSub1Dsc_Jsonclick = "";
         edtSub1Cod_Jsonclick = "";
         edtavnRcdDeleted_13_Jsonclick = "";
         subGrid2_Class = "Grid";
         subGrid2_Allowcollapsing = 0;
         subGrid2_Allowselection = 0;
         subGrid2_Backcolorstyle = 2;
         subGrid2_Header = "";
         edtSubEti_Jsonclick = "";
         edtSubLink_Jsonclick = "";
         edtSubDsc_Jsonclick = "";
         edtSubCod_Jsonclick = "";
         subGrid1_Class = "FreeStyleGrid";
         edtSub1Eti_Enabled = 1;
         edtSub1Link_Enabled = 1;
         edtSub1Dsc_Enabled = 1;
         edtSub1Cod_Enabled = 1;
         edtavnRcdDeleted_13_Enabled = 1;
         subGrid1_Allowcollapsing = 0;
         edtSubEti_Enabled = 1;
         lblTextblock9_Caption = "Etiqueta";
         edtSubLink_Enabled = 1;
         lblTextblock4_Caption = "Link";
         edtSubDsc_Enabled = 1;
         lblTextblock7_Caption = "Submenu";
         edtSubCod_Enabled = 1;
         lblTextblock1_Caption = "Codigo";
         subGrid1_Borderwidth = 1;
         subGrid1_Backcolorstyle = 0;
         edtMenIco_Jsonclick = "";
         edtMenIco_Enabled = 1;
         edtMenLink_Jsonclick = "";
         edtMenLink_Enabled = 1;
         edtMenDsc_Jsonclick = "";
         edtMenDsc_Enabled = 1;
         bttBtn_get_Enabled = 1;
         bttBtn_get_Visible = 1;
         edtMenCod_Jsonclick = "";
         edtMenCod_Enabled = 1;
         edtModCod_Jsonclick = "";
         edtModCod_Enabled = 1;
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
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

      protected void gxnrGrid1_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         SubsflControlProps_4512( ) ;
         while ( nGXsfl_45_idx <= nRC_GXsfl_45 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0O12( ) ;
            standaloneModal0O12( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow0O12( ) ;
            Grid1Row.AddGrid("Grid2", Grid2Container);
            nGXsfl_45_idx = (short)(nGXsfl_45_idx+1);
            sGXsfl_45_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_45_idx), 4, 0)), 4, "0");
            SubsflControlProps_4512( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Grid1Container));
         /* End function gxnrGrid1_newrow */
      }

      protected void gxnrGrid2_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         SubsflControlProps_7213( ) ;
         while ( nGXsfl_72_idx <= nRC_GXsfl_72 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0O12( ) ;
            standaloneModal0O12( ) ;
            standaloneNotModal0O13( ) ;
            standaloneModal0O13( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow0O13( ) ;
            nGXsfl_72_idx = (short)(nGXsfl_72_idx+1);
            sGXsfl_72_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_72_idx), 4, 0)), 4, "0") + sGXsfl_45_idx;
            SubsflControlProps_7213( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Grid2Container));
         /* End function gxnrGrid2_newrow */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         getEqualNoModal( ) ;
         GX_FocusControl = edtMenDsc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Mencod( String GX_Parm1 ,
                                short GX_Parm2 ,
                                short GX_Parm3 ,
                                String GX_Parm4 ,
                                String GX_Parm5 ,
                                String GX_Parm6 )
      {
         Gx_mode = GX_Parm1;
         A11ModCod = GX_Parm2;
         A12MenCod = GX_Parm3;
         A77MenDsc = GX_Parm4;
         n77MenDsc = false;
         A78MenLink = GX_Parm5;
         n78MenLink = false;
         A79MenIco = GX_Parm6;
         n79MenIco = false;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(StringUtil.RTrim( A77MenDsc));
         isValidOutput.Add(StringUtil.RTrim( A78MenLink));
         isValidOutput.Add(StringUtil.RTrim( A79MenIco));
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11ModCod), 4, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z12MenCod), 4, 0, ",", "")));
         isValidOutput.Add(StringUtil.RTrim( Z77MenDsc));
         isValidOutput.Add(StringUtil.RTrim( Z78MenLink));
         isValidOutput.Add(StringUtil.RTrim( Z79MenIco));
         isValidOutput.Add(Grid1Container);
         isValidOutput.Add(bttBtn_get_Enabled);
         isValidOutput.Add(bttBtn_delete_Enabled);
         isValidOutput.Add(bttBtn_enter_Enabled);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[]");
         setEventMetadata("REFRESH",",oparms:[]}");
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
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z77MenDsc = "";
         Z78MenLink = "";
         Z79MenIco = "";
         Z80SubDsc = "";
         Z81SubLink = "";
         Z82SubEti = "";
         Z83Sub1Dsc = "";
         Z84Sub1Link = "";
         Z85Sub1Eti = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         Gx_mode = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         sStyleString = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         lblTextblock1_Jsonclick = "";
         lblTextblock2_Jsonclick = "";
         bttBtn_get_Jsonclick = "";
         lblTextblock3_Jsonclick = "";
         A77MenDsc = "";
         lblTextblock4_Jsonclick = "";
         A78MenLink = "";
         lblTextblock5_Jsonclick = "";
         A79MenIco = "";
         Grid1Container = new GXWebGrid( context);
         subGrid1_Header = "";
         Grid1Column = new GXWebColumn();
         A80SubDsc = "";
         A81SubLink = "";
         A82SubEti = "";
         sMode12 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         A83Sub1Dsc = "";
         A84Sub1Link = "";
         A85Sub1Eti = "";
         T000O8_A11ModCod = new short[1] ;
         T000O8_A12MenCod = new short[1] ;
         T000O8_A77MenDsc = new String[] {""} ;
         T000O8_n77MenDsc = new bool[] {false} ;
         T000O8_A78MenLink = new String[] {""} ;
         T000O8_n78MenLink = new bool[] {false} ;
         T000O8_A79MenIco = new String[] {""} ;
         T000O8_n79MenIco = new bool[] {false} ;
         T000O9_A11ModCod = new short[1] ;
         T000O9_A12MenCod = new short[1] ;
         T000O7_A11ModCod = new short[1] ;
         T000O7_A12MenCod = new short[1] ;
         T000O7_A77MenDsc = new String[] {""} ;
         T000O7_n77MenDsc = new bool[] {false} ;
         T000O7_A78MenLink = new String[] {""} ;
         T000O7_n78MenLink = new bool[] {false} ;
         T000O7_A79MenIco = new String[] {""} ;
         T000O7_n79MenIco = new bool[] {false} ;
         sMode11 = "";
         T000O10_A11ModCod = new short[1] ;
         T000O10_A12MenCod = new short[1] ;
         T000O11_A11ModCod = new short[1] ;
         T000O11_A12MenCod = new short[1] ;
         T000O6_A11ModCod = new short[1] ;
         T000O6_A12MenCod = new short[1] ;
         T000O6_A77MenDsc = new String[] {""} ;
         T000O6_n77MenDsc = new bool[] {false} ;
         T000O6_A78MenLink = new String[] {""} ;
         T000O6_n78MenLink = new bool[] {false} ;
         T000O6_A79MenIco = new String[] {""} ;
         T000O6_n79MenIco = new bool[] {false} ;
         T000O15_A11ModCod = new short[1] ;
         T000O15_A12MenCod = new short[1] ;
         T000O15_A13SubCod = new short[1] ;
         T000O16_A11ModCod = new short[1] ;
         T000O16_A12MenCod = new short[1] ;
         T000O17_A11ModCod = new short[1] ;
         T000O17_A12MenCod = new short[1] ;
         T000O17_A13SubCod = new short[1] ;
         T000O17_A80SubDsc = new String[] {""} ;
         T000O17_n80SubDsc = new bool[] {false} ;
         T000O17_A81SubLink = new String[] {""} ;
         T000O17_n81SubLink = new bool[] {false} ;
         T000O17_A82SubEti = new String[] {""} ;
         T000O17_n82SubEti = new bool[] {false} ;
         T000O18_A11ModCod = new short[1] ;
         T000O18_A12MenCod = new short[1] ;
         T000O18_A13SubCod = new short[1] ;
         T000O5_A11ModCod = new short[1] ;
         T000O5_A12MenCod = new short[1] ;
         T000O5_A13SubCod = new short[1] ;
         T000O5_A80SubDsc = new String[] {""} ;
         T000O5_n80SubDsc = new bool[] {false} ;
         T000O5_A81SubLink = new String[] {""} ;
         T000O5_n81SubLink = new bool[] {false} ;
         T000O5_A82SubEti = new String[] {""} ;
         T000O5_n82SubEti = new bool[] {false} ;
         T000O4_A11ModCod = new short[1] ;
         T000O4_A12MenCod = new short[1] ;
         T000O4_A13SubCod = new short[1] ;
         T000O4_A80SubDsc = new String[] {""} ;
         T000O4_n80SubDsc = new bool[] {false} ;
         T000O4_A81SubLink = new String[] {""} ;
         T000O4_n81SubLink = new bool[] {false} ;
         T000O4_A82SubEti = new String[] {""} ;
         T000O4_n82SubEti = new bool[] {false} ;
         T000O22_A3UsuCod = new String[] {""} ;
         T000O22_A15empcod = new short[1] ;
         T000O22_A16agecod = new short[1] ;
         T000O22_A11ModCod = new short[1] ;
         T000O22_A12MenCod = new short[1] ;
         T000O22_A13SubCod = new short[1] ;
         T000O23_A11ModCod = new short[1] ;
         T000O23_A12MenCod = new short[1] ;
         T000O23_A13SubCod = new short[1] ;
         T000O24_A11ModCod = new short[1] ;
         T000O24_A12MenCod = new short[1] ;
         T000O24_A13SubCod = new short[1] ;
         T000O24_A14Sub1Cod = new short[1] ;
         T000O24_A83Sub1Dsc = new String[] {""} ;
         T000O24_n83Sub1Dsc = new bool[] {false} ;
         T000O24_A84Sub1Link = new String[] {""} ;
         T000O24_n84Sub1Link = new bool[] {false} ;
         T000O24_A85Sub1Eti = new String[] {""} ;
         T000O24_n85Sub1Eti = new bool[] {false} ;
         T000O25_A11ModCod = new short[1] ;
         T000O25_A12MenCod = new short[1] ;
         T000O25_A13SubCod = new short[1] ;
         T000O25_A14Sub1Cod = new short[1] ;
         T000O3_A11ModCod = new short[1] ;
         T000O3_A12MenCod = new short[1] ;
         T000O3_A13SubCod = new short[1] ;
         T000O3_A14Sub1Cod = new short[1] ;
         T000O3_A83Sub1Dsc = new String[] {""} ;
         T000O3_n83Sub1Dsc = new bool[] {false} ;
         T000O3_A84Sub1Link = new String[] {""} ;
         T000O3_n84Sub1Link = new bool[] {false} ;
         T000O3_A85Sub1Eti = new String[] {""} ;
         T000O3_n85Sub1Eti = new bool[] {false} ;
         sMode13 = "";
         T000O2_A11ModCod = new short[1] ;
         T000O2_A12MenCod = new short[1] ;
         T000O2_A13SubCod = new short[1] ;
         T000O2_A14Sub1Cod = new short[1] ;
         T000O2_A83Sub1Dsc = new String[] {""} ;
         T000O2_n83Sub1Dsc = new bool[] {false} ;
         T000O2_A84Sub1Link = new String[] {""} ;
         T000O2_n84Sub1Link = new bool[] {false} ;
         T000O2_A85Sub1Eti = new String[] {""} ;
         T000O2_n85Sub1Eti = new bool[] {false} ;
         T000O29_A11ModCod = new short[1] ;
         T000O29_A12MenCod = new short[1] ;
         T000O29_A13SubCod = new short[1] ;
         T000O29_A14Sub1Cod = new short[1] ;
         Grid1Row = new GXWebRow();
         subGrid1_Linesclass = "";
         lblTextblock6_Jsonclick = "";
         ROClassString = "";
         lblTextblock7_Jsonclick = "";
         lblTextblock8_Jsonclick = "";
         lblTextblock9_Jsonclick = "";
         Grid2Container = new GXWebGrid( context);
         Grid2Column = new GXWebColumn();
         Grid2Row = new GXWebRow();
         subGrid2_Linesclass = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.menu__default(),
            new Object[][] {
                new Object[] {
               T000O2_A11ModCod, T000O2_A12MenCod, T000O2_A13SubCod, T000O2_A14Sub1Cod, T000O2_A83Sub1Dsc, T000O2_n83Sub1Dsc, T000O2_A84Sub1Link, T000O2_n84Sub1Link, T000O2_A85Sub1Eti, T000O2_n85Sub1Eti
               }
               , new Object[] {
               T000O3_A11ModCod, T000O3_A12MenCod, T000O3_A13SubCod, T000O3_A14Sub1Cod, T000O3_A83Sub1Dsc, T000O3_n83Sub1Dsc, T000O3_A84Sub1Link, T000O3_n84Sub1Link, T000O3_A85Sub1Eti, T000O3_n85Sub1Eti
               }
               , new Object[] {
               T000O4_A11ModCod, T000O4_A12MenCod, T000O4_A13SubCod, T000O4_A80SubDsc, T000O4_n80SubDsc, T000O4_A81SubLink, T000O4_n81SubLink, T000O4_A82SubEti, T000O4_n82SubEti
               }
               , new Object[] {
               T000O5_A11ModCod, T000O5_A12MenCod, T000O5_A13SubCod, T000O5_A80SubDsc, T000O5_n80SubDsc, T000O5_A81SubLink, T000O5_n81SubLink, T000O5_A82SubEti, T000O5_n82SubEti
               }
               , new Object[] {
               T000O6_A11ModCod, T000O6_A12MenCod, T000O6_A77MenDsc, T000O6_n77MenDsc, T000O6_A78MenLink, T000O6_n78MenLink, T000O6_A79MenIco, T000O6_n79MenIco
               }
               , new Object[] {
               T000O7_A11ModCod, T000O7_A12MenCod, T000O7_A77MenDsc, T000O7_n77MenDsc, T000O7_A78MenLink, T000O7_n78MenLink, T000O7_A79MenIco, T000O7_n79MenIco
               }
               , new Object[] {
               T000O8_A11ModCod, T000O8_A12MenCod, T000O8_A77MenDsc, T000O8_n77MenDsc, T000O8_A78MenLink, T000O8_n78MenLink, T000O8_A79MenIco, T000O8_n79MenIco
               }
               , new Object[] {
               T000O9_A11ModCod, T000O9_A12MenCod
               }
               , new Object[] {
               T000O10_A11ModCod, T000O10_A12MenCod
               }
               , new Object[] {
               T000O11_A11ModCod, T000O11_A12MenCod
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000O15_A11ModCod, T000O15_A12MenCod, T000O15_A13SubCod
               }
               , new Object[] {
               T000O16_A11ModCod, T000O16_A12MenCod
               }
               , new Object[] {
               T000O17_A11ModCod, T000O17_A12MenCod, T000O17_A13SubCod, T000O17_A80SubDsc, T000O17_n80SubDsc, T000O17_A81SubLink, T000O17_n81SubLink, T000O17_A82SubEti, T000O17_n82SubEti
               }
               , new Object[] {
               T000O18_A11ModCod, T000O18_A12MenCod, T000O18_A13SubCod
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000O22_A3UsuCod, T000O22_A15empcod, T000O22_A16agecod, T000O22_A11ModCod, T000O22_A12MenCod, T000O22_A13SubCod
               }
               , new Object[] {
               T000O23_A11ModCod, T000O23_A12MenCod, T000O23_A13SubCod
               }
               , new Object[] {
               T000O24_A11ModCod, T000O24_A12MenCod, T000O24_A13SubCod, T000O24_A14Sub1Cod, T000O24_A83Sub1Dsc, T000O24_n83Sub1Dsc, T000O24_A84Sub1Link, T000O24_n84Sub1Link, T000O24_A85Sub1Eti, T000O24_n85Sub1Eti
               }
               , new Object[] {
               T000O25_A11ModCod, T000O25_A12MenCod, T000O25_A13SubCod, T000O25_A14Sub1Cod
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000O29_A11ModCod, T000O29_A12MenCod, T000O29_A13SubCod, T000O29_A14Sub1Cod
               }
            }
         );
      }

      private short Z11ModCod ;
      private short Z12MenCod ;
      private short nRC_GXsfl_45 ;
      private short nGXsfl_45_idx=1 ;
      private short Z13SubCod ;
      private short nRC_GXsfl_72 ;
      private short nGXsfl_72_idx=1 ;
      private short nRcdDeleted_12 ;
      private short nRcdExists_12 ;
      private short nIsMod_12 ;
      private short Z14Sub1Cod ;
      private short nRcdDeleted_13 ;
      private short nRcdExists_13 ;
      private short nIsMod_13 ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short A11ModCod ;
      private short A12MenCod ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Borderwidth ;
      private short A13SubCod ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nBlankRcdCount12 ;
      private short RcdFound12 ;
      private short nBlankRcdUsr12 ;
      private short RcdFound13 ;
      private short A14Sub1Cod ;
      private short GX_JID ;
      private short RcdFound11 ;
      private short Gx_BScreen ;
      private short subGrid1_Backstyle ;
      private short subGrid2_Backcolorstyle ;
      private short subGrid2_Allowselection ;
      private short subGrid2_Allowhovering ;
      private short subGrid2_Allowcollapsing ;
      private short subGrid2_Collapsed ;
      private short nBlankRcdCount13 ;
      private short nBlankRcdUsr13 ;
      private short subGrid2_Backstyle ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtModCod_Enabled ;
      private int edtMenCod_Enabled ;
      private int bttBtn_get_Visible ;
      private int bttBtn_get_Enabled ;
      private int edtMenDsc_Enabled ;
      private int edtMenLink_Enabled ;
      private int edtMenIco_Enabled ;
      private int edtSubCod_Enabled ;
      private int edtSubDsc_Enabled ;
      private int edtSubLink_Enabled ;
      private int edtSubEti_Enabled ;
      private int subGrid1_Selectedindex ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int fRowAdded ;
      private int edtavnRcdDeleted_13_Enabled ;
      private int edtSub1Cod_Enabled ;
      private int edtSub1Dsc_Enabled ;
      private int edtSub1Link_Enabled ;
      private int edtSub1Eti_Enabled ;
      private int subGrid1_Backcolor ;
      private int subGrid1_Allbackcolor ;
      private int GRID1_IsPaging ;
      private int subGrid2_Selectedindex ;
      private int subGrid2_Selectioncolor ;
      private int subGrid2_Hoveringcolor ;
      private int subGrid2_Backcolor ;
      private int subGrid2_Allbackcolor ;
      private int defedtSub1Cod_Enabled ;
      private int defedtSubCod_Enabled ;
      private int idxLst ;
      private long GRID1_nFirstRecordOnPage ;
      private long GRID2_nFirstRecordOnPage ;
      private long GRID2_nCurrentRecord ;
      private String sPrefix ;
      private String Z77MenDsc ;
      private String Z78MenLink ;
      private String Z79MenIco ;
      private String Z80SubDsc ;
      private String Z81SubLink ;
      private String Z82SubEti ;
      private String Z83Sub1Dsc ;
      private String Z84Sub1Link ;
      private String Z85Sub1Eti ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_45_idx="0001" ;
      private String Gx_mode ;
      private String sGXsfl_72_idx="0001" ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtModCod_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
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
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String edtModCod_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String edtMenCod_Internalname ;
      private String edtMenCod_Jsonclick ;
      private String bttBtn_get_Internalname ;
      private String bttBtn_get_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String edtMenDsc_Internalname ;
      private String A77MenDsc ;
      private String edtMenDsc_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String edtMenLink_Internalname ;
      private String A78MenLink ;
      private String edtMenLink_Jsonclick ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String edtMenIco_Internalname ;
      private String A79MenIco ;
      private String edtMenIco_Jsonclick ;
      private String subGrid1_Header ;
      private String lblTextblock1_Caption ;
      private String lblTextblock7_Caption ;
      private String A80SubDsc ;
      private String lblTextblock4_Caption ;
      private String A81SubLink ;
      private String lblTextblock9_Caption ;
      private String A82SubEti ;
      private String sMode12 ;
      private String edtSubCod_Internalname ;
      private String edtSubDsc_Internalname ;
      private String edtSubLink_Internalname ;
      private String edtSubEti_Internalname ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavnRcdDeleted_13_Internalname ;
      private String GXCCtl ;
      private String edtSub1Cod_Internalname ;
      private String edtSub1Dsc_Internalname ;
      private String A83Sub1Dsc ;
      private String edtSub1Link_Internalname ;
      private String A84Sub1Link ;
      private String edtSub1Eti_Internalname ;
      private String A85Sub1Eti ;
      private String sMode11 ;
      private String sMode13 ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock7_Internalname ;
      private String lblTextblock8_Internalname ;
      private String lblTextblock9_Internalname ;
      private String subGrid2_Internalname ;
      private String sGXsfl_45_fel_idx="0001" ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String tblTable3_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String ROClassString ;
      private String edtSubCod_Jsonclick ;
      private String lblTextblock7_Jsonclick ;
      private String edtSubDsc_Jsonclick ;
      private String lblTextblock8_Jsonclick ;
      private String edtSubLink_Jsonclick ;
      private String lblTextblock9_Jsonclick ;
      private String edtSubEti_Jsonclick ;
      private String subGrid2_Header ;
      private String sGXsfl_72_fel_idx="0001" ;
      private String subGrid2_Class ;
      private String subGrid2_Linesclass ;
      private String edtavnRcdDeleted_13_Jsonclick ;
      private String edtSub1Cod_Jsonclick ;
      private String edtSub1Dsc_Jsonclick ;
      private String edtSub1Link_Jsonclick ;
      private String edtSub1Eti_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGrid1_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool bGXsfl_45_Refreshing=false ;
      private bool n77MenDsc ;
      private bool n78MenLink ;
      private bool n79MenIco ;
      private bool bGXsfl_72_Refreshing=false ;
      private bool n80SubDsc ;
      private bool n81SubLink ;
      private bool n82SubEti ;
      private bool n83Sub1Dsc ;
      private bool n84Sub1Link ;
      private bool n85Sub1Eti ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebGrid Grid1Container ;
      private GXWebGrid Grid2Container ;
      private GXWebRow Grid1Row ;
      private GXWebRow Grid2Row ;
      private GXWebColumn Grid1Column ;
      private GXWebColumn Grid2Column ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T000O8_A11ModCod ;
      private short[] T000O8_A12MenCod ;
      private String[] T000O8_A77MenDsc ;
      private bool[] T000O8_n77MenDsc ;
      private String[] T000O8_A78MenLink ;
      private bool[] T000O8_n78MenLink ;
      private String[] T000O8_A79MenIco ;
      private bool[] T000O8_n79MenIco ;
      private short[] T000O9_A11ModCod ;
      private short[] T000O9_A12MenCod ;
      private short[] T000O7_A11ModCod ;
      private short[] T000O7_A12MenCod ;
      private String[] T000O7_A77MenDsc ;
      private bool[] T000O7_n77MenDsc ;
      private String[] T000O7_A78MenLink ;
      private bool[] T000O7_n78MenLink ;
      private String[] T000O7_A79MenIco ;
      private bool[] T000O7_n79MenIco ;
      private short[] T000O10_A11ModCod ;
      private short[] T000O10_A12MenCod ;
      private short[] T000O11_A11ModCod ;
      private short[] T000O11_A12MenCod ;
      private short[] T000O6_A11ModCod ;
      private short[] T000O6_A12MenCod ;
      private String[] T000O6_A77MenDsc ;
      private bool[] T000O6_n77MenDsc ;
      private String[] T000O6_A78MenLink ;
      private bool[] T000O6_n78MenLink ;
      private String[] T000O6_A79MenIco ;
      private bool[] T000O6_n79MenIco ;
      private short[] T000O15_A11ModCod ;
      private short[] T000O15_A12MenCod ;
      private short[] T000O15_A13SubCod ;
      private short[] T000O16_A11ModCod ;
      private short[] T000O16_A12MenCod ;
      private short[] T000O17_A11ModCod ;
      private short[] T000O17_A12MenCod ;
      private short[] T000O17_A13SubCod ;
      private String[] T000O17_A80SubDsc ;
      private bool[] T000O17_n80SubDsc ;
      private String[] T000O17_A81SubLink ;
      private bool[] T000O17_n81SubLink ;
      private String[] T000O17_A82SubEti ;
      private bool[] T000O17_n82SubEti ;
      private short[] T000O18_A11ModCod ;
      private short[] T000O18_A12MenCod ;
      private short[] T000O18_A13SubCod ;
      private short[] T000O5_A11ModCod ;
      private short[] T000O5_A12MenCod ;
      private short[] T000O5_A13SubCod ;
      private String[] T000O5_A80SubDsc ;
      private bool[] T000O5_n80SubDsc ;
      private String[] T000O5_A81SubLink ;
      private bool[] T000O5_n81SubLink ;
      private String[] T000O5_A82SubEti ;
      private bool[] T000O5_n82SubEti ;
      private short[] T000O4_A11ModCod ;
      private short[] T000O4_A12MenCod ;
      private short[] T000O4_A13SubCod ;
      private String[] T000O4_A80SubDsc ;
      private bool[] T000O4_n80SubDsc ;
      private String[] T000O4_A81SubLink ;
      private bool[] T000O4_n81SubLink ;
      private String[] T000O4_A82SubEti ;
      private bool[] T000O4_n82SubEti ;
      private String[] T000O22_A3UsuCod ;
      private short[] T000O22_A15empcod ;
      private short[] T000O22_A16agecod ;
      private short[] T000O22_A11ModCod ;
      private short[] T000O22_A12MenCod ;
      private short[] T000O22_A13SubCod ;
      private short[] T000O23_A11ModCod ;
      private short[] T000O23_A12MenCod ;
      private short[] T000O23_A13SubCod ;
      private short[] T000O24_A11ModCod ;
      private short[] T000O24_A12MenCod ;
      private short[] T000O24_A13SubCod ;
      private short[] T000O24_A14Sub1Cod ;
      private String[] T000O24_A83Sub1Dsc ;
      private bool[] T000O24_n83Sub1Dsc ;
      private String[] T000O24_A84Sub1Link ;
      private bool[] T000O24_n84Sub1Link ;
      private String[] T000O24_A85Sub1Eti ;
      private bool[] T000O24_n85Sub1Eti ;
      private short[] T000O25_A11ModCod ;
      private short[] T000O25_A12MenCod ;
      private short[] T000O25_A13SubCod ;
      private short[] T000O25_A14Sub1Cod ;
      private short[] T000O3_A11ModCod ;
      private short[] T000O3_A12MenCod ;
      private short[] T000O3_A13SubCod ;
      private short[] T000O3_A14Sub1Cod ;
      private String[] T000O3_A83Sub1Dsc ;
      private bool[] T000O3_n83Sub1Dsc ;
      private String[] T000O3_A84Sub1Link ;
      private bool[] T000O3_n84Sub1Link ;
      private String[] T000O3_A85Sub1Eti ;
      private bool[] T000O3_n85Sub1Eti ;
      private short[] T000O2_A11ModCod ;
      private short[] T000O2_A12MenCod ;
      private short[] T000O2_A13SubCod ;
      private short[] T000O2_A14Sub1Cod ;
      private String[] T000O2_A83Sub1Dsc ;
      private bool[] T000O2_n83Sub1Dsc ;
      private String[] T000O2_A84Sub1Link ;
      private bool[] T000O2_n84Sub1Link ;
      private String[] T000O2_A85Sub1Eti ;
      private bool[] T000O2_n85Sub1Eti ;
      private short[] T000O29_A11ModCod ;
      private short[] T000O29_A12MenCod ;
      private short[] T000O29_A13SubCod ;
      private short[] T000O29_A14Sub1Cod ;
   }

   public class menu__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[10])
         ,new UpdateCursor(def[11])
         ,new UpdateCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new UpdateCursor(def[17])
         ,new UpdateCursor(def[18])
         ,new UpdateCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new ForEachCursor(def[22])
         ,new ForEachCursor(def[23])
         ,new UpdateCursor(def[24])
         ,new UpdateCursor(def[25])
         ,new UpdateCursor(def[26])
         ,new ForEachCursor(def[27])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000O8 ;
          prmT000O8 = new Object[] {
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000O9 ;
          prmT000O9 = new Object[] {
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000O7 ;
          prmT000O7 = new Object[] {
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000O10 ;
          prmT000O10 = new Object[] {
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000O11 ;
          prmT000O11 = new Object[] {
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000O6 ;
          prmT000O6 = new Object[] {
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000O12 ;
          prmT000O12 = new Object[] {
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenDsc",SqlDbType.Char,30,0} ,
          new Object[] {"@MenLink",SqlDbType.Char,30,0} ,
          new Object[] {"@MenIco",SqlDbType.Char,30,0}
          } ;
          Object[] prmT000O13 ;
          prmT000O13 = new Object[] {
          new Object[] {"@MenDsc",SqlDbType.Char,30,0} ,
          new Object[] {"@MenLink",SqlDbType.Char,30,0} ,
          new Object[] {"@MenIco",SqlDbType.Char,30,0} ,
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000O14 ;
          prmT000O14 = new Object[] {
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000O15 ;
          prmT000O15 = new Object[] {
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000O16 ;
          prmT000O16 = new Object[] {
          } ;
          Object[] prmT000O17 ;
          prmT000O17 = new Object[] {
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SubCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000O18 ;
          prmT000O18 = new Object[] {
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SubCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000O5 ;
          prmT000O5 = new Object[] {
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SubCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000O4 ;
          prmT000O4 = new Object[] {
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SubCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000O19 ;
          prmT000O19 = new Object[] {
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SubCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SubDsc",SqlDbType.Char,30,0} ,
          new Object[] {"@SubLink",SqlDbType.Char,30,0} ,
          new Object[] {"@SubEti",SqlDbType.Char,30,0}
          } ;
          Object[] prmT000O20 ;
          prmT000O20 = new Object[] {
          new Object[] {"@SubDsc",SqlDbType.Char,30,0} ,
          new Object[] {"@SubLink",SqlDbType.Char,30,0} ,
          new Object[] {"@SubEti",SqlDbType.Char,30,0} ,
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SubCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000O21 ;
          prmT000O21 = new Object[] {
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SubCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000O22 ;
          prmT000O22 = new Object[] {
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SubCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000O23 ;
          prmT000O23 = new Object[] {
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000O24 ;
          prmT000O24 = new Object[] {
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SubCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@Sub1Cod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000O25 ;
          prmT000O25 = new Object[] {
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SubCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@Sub1Cod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000O3 ;
          prmT000O3 = new Object[] {
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SubCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@Sub1Cod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000O2 ;
          prmT000O2 = new Object[] {
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SubCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@Sub1Cod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000O26 ;
          prmT000O26 = new Object[] {
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SubCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@Sub1Cod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@Sub1Dsc",SqlDbType.Char,30,0} ,
          new Object[] {"@Sub1Link",SqlDbType.Char,30,0} ,
          new Object[] {"@Sub1Eti",SqlDbType.Char,30,0}
          } ;
          Object[] prmT000O27 ;
          prmT000O27 = new Object[] {
          new Object[] {"@Sub1Dsc",SqlDbType.Char,30,0} ,
          new Object[] {"@Sub1Link",SqlDbType.Char,30,0} ,
          new Object[] {"@Sub1Eti",SqlDbType.Char,30,0} ,
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SubCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@Sub1Cod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000O28 ;
          prmT000O28 = new Object[] {
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SubCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@Sub1Cod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000O29 ;
          prmT000O29 = new Object[] {
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SubCod",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000O2", "SELECT [ModCod], [MenCod], [SubCod], [Sub1Cod], [Sub1Dsc], [Sub1Link], [Sub1Eti] FROM [MENUSUB1] WITH (UPDLOCK) WHERE [ModCod] = @ModCod AND [MenCod] = @MenCod AND [SubCod] = @SubCod AND [Sub1Cod] = @Sub1Cod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000O2,1,0,true,false )
             ,new CursorDef("T000O3", "SELECT [ModCod], [MenCod], [SubCod], [Sub1Cod], [Sub1Dsc], [Sub1Link], [Sub1Eti] FROM [MENUSUB1] WITH (NOLOCK) WHERE [ModCod] = @ModCod AND [MenCod] = @MenCod AND [SubCod] = @SubCod AND [Sub1Cod] = @Sub1Cod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000O3,1,0,true,false )
             ,new CursorDef("T000O4", "SELECT [ModCod], [MenCod], [SubCod], [SubDsc], [SubLink], [SubEti] FROM [MENUSUB] WITH (UPDLOCK) WHERE [ModCod] = @ModCod AND [MenCod] = @MenCod AND [SubCod] = @SubCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000O4,1,0,true,false )
             ,new CursorDef("T000O5", "SELECT [ModCod], [MenCod], [SubCod], [SubDsc], [SubLink], [SubEti] FROM [MENUSUB] WITH (NOLOCK) WHERE [ModCod] = @ModCod AND [MenCod] = @MenCod AND [SubCod] = @SubCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000O5,1,0,true,false )
             ,new CursorDef("T000O6", "SELECT [ModCod], [MenCod], [MenDsc], [MenLink], [MenIco] FROM [MENU] WITH (UPDLOCK) WHERE [ModCod] = @ModCod AND [MenCod] = @MenCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000O6,1,0,true,false )
             ,new CursorDef("T000O7", "SELECT [ModCod], [MenCod], [MenDsc], [MenLink], [MenIco] FROM [MENU] WITH (NOLOCK) WHERE [ModCod] = @ModCod AND [MenCod] = @MenCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000O7,1,0,true,false )
             ,new CursorDef("T000O8", "SELECT TM1.[ModCod], TM1.[MenCod], TM1.[MenDsc], TM1.[MenLink], TM1.[MenIco] FROM [MENU] TM1 WITH (NOLOCK) WHERE TM1.[ModCod] = @ModCod and TM1.[MenCod] = @MenCod ORDER BY TM1.[ModCod], TM1.[MenCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000O8,100,0,true,false )
             ,new CursorDef("T000O9", "SELECT [ModCod], [MenCod] FROM [MENU] WITH (NOLOCK) WHERE [ModCod] = @ModCod AND [MenCod] = @MenCod  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000O9,1,0,true,false )
             ,new CursorDef("T000O10", "SELECT TOP 1 [ModCod], [MenCod] FROM [MENU] WITH (NOLOCK) WHERE ( [ModCod] > @ModCod or [ModCod] = @ModCod and [MenCod] > @MenCod) ORDER BY [ModCod], [MenCod]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000O10,1,0,true,true )
             ,new CursorDef("T000O11", "SELECT TOP 1 [ModCod], [MenCod] FROM [MENU] WITH (NOLOCK) WHERE ( [ModCod] < @ModCod or [ModCod] = @ModCod and [MenCod] < @MenCod) ORDER BY [ModCod] DESC, [MenCod] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000O11,1,0,true,true )
             ,new CursorDef("T000O12", "INSERT INTO [MENU]([ModCod], [MenCod], [MenDsc], [MenLink], [MenIco]) VALUES(@ModCod, @MenCod, @MenDsc, @MenLink, @MenIco)", GxErrorMask.GX_NOMASK,prmT000O12)
             ,new CursorDef("T000O13", "UPDATE [MENU] SET [MenDsc]=@MenDsc, [MenLink]=@MenLink, [MenIco]=@MenIco  WHERE [ModCod] = @ModCod AND [MenCod] = @MenCod", GxErrorMask.GX_NOMASK,prmT000O13)
             ,new CursorDef("T000O14", "DELETE FROM [MENU]  WHERE [ModCod] = @ModCod AND [MenCod] = @MenCod", GxErrorMask.GX_NOMASK,prmT000O14)
             ,new CursorDef("T000O15", "SELECT TOP 1 [ModCod], [MenCod], [SubCod] FROM [MENUSUB] WITH (NOLOCK) WHERE [ModCod] = @ModCod AND [MenCod] = @MenCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000O15,1,0,true,true )
             ,new CursorDef("T000O16", "SELECT [ModCod], [MenCod] FROM [MENU] WITH (NOLOCK) ORDER BY [ModCod], [MenCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000O16,100,0,true,false )
             ,new CursorDef("T000O17", "SELECT [ModCod], [MenCod], [SubCod], [SubDsc], [SubLink], [SubEti] FROM [MENUSUB] WITH (NOLOCK) WHERE [ModCod] = @ModCod and [MenCod] = @MenCod and [SubCod] = @SubCod ORDER BY [ModCod], [MenCod], [SubCod] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000O17,11,0,true,false )
             ,new CursorDef("T000O18", "SELECT [ModCod], [MenCod], [SubCod] FROM [MENUSUB] WITH (NOLOCK) WHERE [ModCod] = @ModCod AND [MenCod] = @MenCod AND [SubCod] = @SubCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000O18,1,0,true,false )
             ,new CursorDef("T000O19", "INSERT INTO [MENUSUB]([ModCod], [MenCod], [SubCod], [SubDsc], [SubLink], [SubEti]) VALUES(@ModCod, @MenCod, @SubCod, @SubDsc, @SubLink, @SubEti)", GxErrorMask.GX_NOMASK,prmT000O19)
             ,new CursorDef("T000O20", "UPDATE [MENUSUB] SET [SubDsc]=@SubDsc, [SubLink]=@SubLink, [SubEti]=@SubEti  WHERE [ModCod] = @ModCod AND [MenCod] = @MenCod AND [SubCod] = @SubCod", GxErrorMask.GX_NOMASK,prmT000O20)
             ,new CursorDef("T000O21", "DELETE FROM [MENUSUB]  WHERE [ModCod] = @ModCod AND [MenCod] = @MenCod AND [SubCod] = @SubCod", GxErrorMask.GX_NOMASK,prmT000O21)
             ,new CursorDef("T000O22", "SELECT TOP 1 [UsuCod], [empcod], [agecod], [ModCod], [MenCod], [SubCod] FROM [PERMISOS] WITH (NOLOCK) WHERE [ModCod] = @ModCod AND [MenCod] = @MenCod AND [SubCod] = @SubCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000O22,1,0,true,true )
             ,new CursorDef("T000O23", "SELECT [ModCod], [MenCod], [SubCod] FROM [MENUSUB] WITH (NOLOCK) WHERE [ModCod] = @ModCod and [MenCod] = @MenCod ORDER BY [ModCod], [MenCod], [SubCod] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000O23,11,0,true,false )
             ,new CursorDef("T000O24", "SELECT [ModCod], [MenCod], [SubCod], [Sub1Cod], [Sub1Dsc], [Sub1Link], [Sub1Eti] FROM [MENUSUB1] WITH (NOLOCK) WHERE [ModCod] = @ModCod and [MenCod] = @MenCod and [SubCod] = @SubCod and [Sub1Cod] = @Sub1Cod ORDER BY [ModCod], [MenCod], [SubCod], [Sub1Cod] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000O24,11,0,true,false )
             ,new CursorDef("T000O25", "SELECT [ModCod], [MenCod], [SubCod], [Sub1Cod] FROM [MENUSUB1] WITH (NOLOCK) WHERE [ModCod] = @ModCod AND [MenCod] = @MenCod AND [SubCod] = @SubCod AND [Sub1Cod] = @Sub1Cod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000O25,1,0,true,false )
             ,new CursorDef("T000O26", "INSERT INTO [MENUSUB1]([ModCod], [MenCod], [SubCod], [Sub1Cod], [Sub1Dsc], [Sub1Link], [Sub1Eti]) VALUES(@ModCod, @MenCod, @SubCod, @Sub1Cod, @Sub1Dsc, @Sub1Link, @Sub1Eti)", GxErrorMask.GX_NOMASK,prmT000O26)
             ,new CursorDef("T000O27", "UPDATE [MENUSUB1] SET [Sub1Dsc]=@Sub1Dsc, [Sub1Link]=@Sub1Link, [Sub1Eti]=@Sub1Eti  WHERE [ModCod] = @ModCod AND [MenCod] = @MenCod AND [SubCod] = @SubCod AND [Sub1Cod] = @Sub1Cod", GxErrorMask.GX_NOMASK,prmT000O27)
             ,new CursorDef("T000O28", "DELETE FROM [MENUSUB1]  WHERE [ModCod] = @ModCod AND [MenCod] = @MenCod AND [SubCod] = @SubCod AND [Sub1Cod] = @Sub1Cod", GxErrorMask.GX_NOMASK,prmT000O28)
             ,new CursorDef("T000O29", "SELECT [ModCod], [MenCod], [SubCod], [Sub1Cod] FROM [MENUSUB1] WITH (NOLOCK) WHERE [ModCod] = @ModCod and [MenCod] = @MenCod and [SubCod] = @SubCod ORDER BY [ModCod], [MenCod], [SubCod], [Sub1Cod] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000O29,11,0,true,false )
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
                ((String[]) buf[4])[0] = rslt.getString(5, 30) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((String[]) buf[6])[0] = rslt.getString(6, 30) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(6);
                ((String[]) buf[8])[0] = rslt.getString(7, 30) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(7);
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 30) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((String[]) buf[6])[0] = rslt.getString(6, 30) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(6);
                ((String[]) buf[8])[0] = rslt.getString(7, 30) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(7);
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 30) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getString(5, 30) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((String[]) buf[7])[0] = rslt.getString(6, 30) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 30) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getString(5, 30) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((String[]) buf[7])[0] = rslt.getString(6, 30) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 30) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getString(4, 30) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getString(5, 30) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 30) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getString(4, 30) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getString(5, 30) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 30) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getString(4, 30) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getString(5, 30) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 14 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 15 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 30) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getString(5, 30) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((String[]) buf[7])[0] = rslt.getString(6, 30) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                return;
             case 16 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 20 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 21 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 22 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 30) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((String[]) buf[6])[0] = rslt.getString(6, 30) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(6);
                ((String[]) buf[8])[0] = rslt.getString(7, 30) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(7);
                return;
             case 23 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 27 :
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
                stmt.SetParameter(2, (short)parms[1]);
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
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 3 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 4 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 5 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[7]);
                }
                return;
             case 11 :
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
                   stmt.setNull( 3 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[5]);
                }
                stmt.SetParameter(4, (short)parms[6]);
                stmt.SetParameter(5, (short)parms[7]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 17 :
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
                   stmt.setNull( 5 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 6 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[8]);
                }
                return;
             case 18 :
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
                   stmt.setNull( 3 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[5]);
                }
                stmt.SetParameter(4, (short)parms[6]);
                stmt.SetParameter(5, (short)parms[7]);
                stmt.SetParameter(6, (short)parms[8]);
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
                return;
             case 22 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 23 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 24 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 5 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 6 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 7 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[9]);
                }
                return;
             case 25 :
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
                   stmt.setNull( 3 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[5]);
                }
                stmt.SetParameter(4, (short)parms[6]);
                stmt.SetParameter(5, (short)parms[7]);
                stmt.SetParameter(6, (short)parms[8]);
                stmt.SetParameter(7, (short)parms[9]);
                return;
             case 26 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 27 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
       }
    }

 }

}
