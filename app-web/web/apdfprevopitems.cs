/*
               File: pdfPrevOPItems
        Description: pdf Prev OPItems
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 2/14/2023 22:5:42.69
       Program type: Main program
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
using GeneXus.Procedure;
using GeneXus.Printer;
using GeneXus.XML;
using GeneXus.Office;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class apdfprevopitems : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
   {
      public override void webExecute( )
      {
         context.SetDefaultTheme("Carmine");
         initialize();
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
         }
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         if ( nGotPars == 0 )
         {
            entryPointCalled = false;
            gxfirstwebparm = GetNextPar( );
            if ( ! entryPointCalled )
            {
               AV13EmpID = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV11ClienteID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV22OrdenPeriodo = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV20OrdenAnio = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV21OrdenID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV26Usercod = GetNextPar( );
               }
            }
         }
         if ( GxWebError == 0 )
         {
            executePrivate();
         }
         cleanup();
      }

      public apdfprevopitems( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public apdfprevopitems( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_EmpID ,
                           short aP1_ClienteID ,
                           short aP2_OrdenPeriodo ,
                           short aP3_OrdenAnio ,
                           short aP4_OrdenID ,
                           String aP5_Usercod )
      {
         this.AV13EmpID = aP0_EmpID;
         this.AV11ClienteID = aP1_ClienteID;
         this.AV22OrdenPeriodo = aP2_OrdenPeriodo;
         this.AV20OrdenAnio = aP3_OrdenAnio;
         this.AV21OrdenID = aP4_OrdenID;
         this.AV26Usercod = aP5_Usercod;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_EmpID ,
                                 short aP1_ClienteID ,
                                 short aP2_OrdenPeriodo ,
                                 short aP3_OrdenAnio ,
                                 short aP4_OrdenID ,
                                 String aP5_Usercod )
      {
         apdfprevopitems objapdfprevopitems;
         objapdfprevopitems = new apdfprevopitems();
         objapdfprevopitems.AV13EmpID = aP0_EmpID;
         objapdfprevopitems.AV11ClienteID = aP1_ClienteID;
         objapdfprevopitems.AV22OrdenPeriodo = aP2_OrdenPeriodo;
         objapdfprevopitems.AV20OrdenAnio = aP3_OrdenAnio;
         objapdfprevopitems.AV21OrdenID = aP4_OrdenID;
         objapdfprevopitems.AV26Usercod = aP5_Usercod;
         objapdfprevopitems.context.SetSubmitInitialConfig(context);
         objapdfprevopitems.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objapdfprevopitems);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((apdfprevopitems)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         M_top = 0;
         M_bot = 6;
         P_lines = (int)(66-M_bot);
         getPrinter().GxClearAttris() ;
         add_metrics( ) ;
         lineHeight = 15;
         PrtOffset = 0;
         gxXPage = 100;
         gxYPage = 100;
         getPrinter().GxSetDocName("") ;
         try
         {
            Gx_out = "FIL" ;
            if (!initPrinter (Gx_out, gxXPage, gxYPage, "GXPRN.INI", "", "", 2, 2, 256, 11909, 16704, 0, 1, 1, 0, 1, 1) )
            {
               cleanup();
               return;
            }
            getPrinter().setModal(false) ;
            P_lines = (int)(gxYPage-(lineHeight*6));
            Gx_line = (int)(P_lines+1);
            getPrinter().setPageLines(P_lines);
            getPrinter().setLineHeight(lineHeight);
            getPrinter().setM_top(M_top);
            getPrinter().setM_bot(M_bot);
            H1W0( false, 30) ;
            getPrinter().GxDrawLine(0, Gx_line+28, 1149, Gx_line+28, 1, 0, 0, 0, 0) ;
            getPrinter().GxAttris("Qatar2022 Medium", 10, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText("Nro.", 25, Gx_line+9, 58, Gx_line+26, 0+256, 0, 0, 0) ;
            getPrinter().GxDrawText("Tipo Producto", 66, Gx_line+9, 170, Gx_line+26, 0+256, 0, 0, 0) ;
            getPrinter().GxDrawText("Categoria", 269, Gx_line+9, 340, Gx_line+26, 0+256, 0, 0, 0) ;
            getPrinter().GxDrawText("Producto", 478, Gx_line+9, 547, Gx_line+26, 0+256, 0, 0, 0) ;
            getPrinter().GxDrawText("Precio", 781, Gx_line+9, 829, Gx_line+26, 0+256, 0, 0, 0) ;
            getPrinter().GxDrawText("Cantidad", 889, Gx_line+9, 953, Gx_line+26, 0+256, 0, 0, 0) ;
            getPrinter().GxDrawText("Valor", 1025, Gx_line+9, 1064, Gx_line+26, 0+256, 0, 0, 0) ;
            Gx_OldLine = Gx_line;
            Gx_line = (int)(Gx_line+30);
            AV24totalValor = 0;
            AV25totCant = 0;
            AV28totalPrec = 0;
            AV33GXLvl16 = 0;
            /* Using cursor P001W2 */
            pr_default.execute(0, new Object[] {AV13EmpID, AV11ClienteID, AV22OrdenPeriodo, AV20OrdenAnio, AV21OrdenID});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A32categID = P001W2_A32categID[0];
               A33subCatID = P001W2_A33subCatID[0];
               A22OrdenID = P001W2_A22OrdenID[0];
               A25OrdenAnio = P001W2_A25OrdenAnio[0];
               A24OrdenPeriodo = P001W2_A24OrdenPeriodo[0];
               A5ClienteID = P001W2_A5ClienteID[0];
               A1EmpID = P001W2_A1EmpID[0];
               A36detTipoProdID = P001W2_A36detTipoProdID[0];
               A148subCatDsc = P001W2_A148subCatDsc[0];
               n148subCatDsc = P001W2_n148subCatDsc[0];
               A146categDsc = P001W2_A146categDsc[0];
               n146categDsc = P001W2_n146categDsc[0];
               A41OrdenSecId = P001W2_A41OrdenSecId[0];
               A150subCatPrec = P001W2_A150subCatPrec[0];
               n150subCatPrec = P001W2_n150subCatPrec[0];
               A208OrdenDetCant = P001W2_A208OrdenDetCant[0];
               n208OrdenDetCant = P001W2_n208OrdenDetCant[0];
               A146categDsc = P001W2_A146categDsc[0];
               n146categDsc = P001W2_n146categDsc[0];
               A148subCatDsc = P001W2_A148subCatDsc[0];
               n148subCatDsc = P001W2_n148subCatDsc[0];
               A150subCatPrec = P001W2_A150subCatPrec[0];
               n150subCatPrec = P001W2_n150subCatPrec[0];
               A209OrdenDetVal = (decimal)(A150subCatPrec*A208OrdenDetCant);
               AV33GXLvl16 = 1;
               AV8tipId = A36detTipoProdID;
               /* Execute user subroutine: 'TIPOPRODDSC' */
               S141 ();
               if ( returnInSub )
               {
                  pr_default.close(0);
                  this.cleanup();
                  if (true) return;
               }
               if ( AV19nroItems == 0 )
               {
                  AV19nroItems = 1;
                  H1W0( false, 17) ;
                  getPrinter().GxAttris("Qatar2022 Medium", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A41OrdenSecId), "ZZZ9")), 25, Gx_line+0, 55, Gx_line+15, 0+256, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV23tipoProd, "")), 61, Gx_line+0, 244, Gx_line+15, 0, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A146categDsc, "@!")), 269, Gx_line+0, 449, Gx_line+15, 0, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A148subCatDsc, "@!")), 478, Gx_line+0, 729, Gx_line+15, 0+256, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( A150subCatPrec, "ZZZZ9.99")), 770, Gx_line+0, 829, Gx_line+15, 2+256, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( A208OrdenDetCant, "ZZZZ9.99")), 891, Gx_line+0, 950, Gx_line+15, 2+256, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( A209OrdenDetVal, "ZZZZ9.99")), 1005, Gx_line+0, 1064, Gx_line+15, 2+256, 0, 0, 1) ;
                  Gx_OldLine = Gx_line;
                  Gx_line = (int)(Gx_line+17);
               }
               else
               {
                  AV19nroItems = 0;
                  H1W0( false, 22) ;
                  getPrinter().GxDrawRect(0, Gx_line+0, 1149, Gx_line+21, 1, 211, 211, 211, 1, 211, 211, 211, 0, 0, 0, 0, 0, 0, 0, 0) ;
                  getPrinter().GxAttris("Qatar2022 Medium", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( A209OrdenDetVal, "ZZZZ9.99")), 1005, Gx_line+3, 1064, Gx_line+18, 2+256, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( A208OrdenDetCant, "ZZZZ9.99")), 891, Gx_line+3, 950, Gx_line+18, 2+256, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( A150subCatPrec, "ZZZZ9.99")), 770, Gx_line+3, 829, Gx_line+18, 2+256, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A148subCatDsc, "@!")), 478, Gx_line+3, 729, Gx_line+18, 0+256, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A146categDsc, "@!")), 269, Gx_line+3, 449, Gx_line+18, 0, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV23tipoProd, "")), 61, Gx_line+3, 244, Gx_line+18, 0, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A41OrdenSecId), "ZZZ9")), 25, Gx_line+3, 55, Gx_line+18, 0+256, 0, 0, 1) ;
                  Gx_OldLine = Gx_line;
                  Gx_line = (int)(Gx_line+22);
               }
               AV24totalValor = (decimal)(AV24totalValor+A209OrdenDetVal);
               AV25totCant = (decimal)(AV25totCant+A208OrdenDetCant);
               AV28totalPrec = (decimal)(AV28totalPrec+A150subCatPrec);
               pr_default.readNext(0);
            }
            pr_default.close(0);
            if ( AV33GXLvl16 == 0 )
            {
               H1W0( false, 28) ;
               getPrinter().GxAttris("Qatar2022 Medium", 14, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("No se ha encontrado información", 12, Gx_line+4, 351, Gx_line+28, 0+256, 0, 0, 0) ;
               Gx_OldLine = Gx_line;
               Gx_line = (int)(Gx_line+28);
            }
            H1W0( false, 25) ;
            getPrinter().GxDrawLine(0, Gx_line+1, 1149, Gx_line+1, 1, 0, 0, 0, 0) ;
            getPrinter().GxAttris("Qatar2022 Medium", 8, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( AV24totalValor, "ZZZZZZ9.99")), 980, Gx_line+5, 1064, Gx_line+20, 2+256, 0, 0, 0) ;
            getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( AV25totCant, "ZZZZZZ9.99")), 866, Gx_line+5, 950, Gx_line+20, 2+256, 0, 0, 0) ;
            getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( AV28totalPrec, "ZZZZZZ9.99")), 745, Gx_line+5, 829, Gx_line+20, 2+256, 0, 0, 0) ;
            getPrinter().GxAttris("Qatar2022 Medium", 9, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText("Totales", 529, Gx_line+5, 580, Gx_line+20, 0+256, 0, 0, 0) ;
            Gx_OldLine = Gx_line;
            Gx_line = (int)(Gx_line+25);
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1);
            H1W0( true, 0) ;
         }
         catch ( GeneXus.Printer.ProcessInterruptedException e )
         {
         }
         finally
         {
            /* Close printer file */
            try
            {
               getPrinter().GxEndPage() ;
               getPrinter().GxEndDocument() ;
            }
            catch ( GeneXus.Printer.ProcessInterruptedException e )
            {
            }
            endPrinter();
         }
         if ( context.WillRedirect( ) )
         {
            context.Redirect( context.wjLoc );
            context.wjLoc = "";
         }
         this.cleanup();
      }

      protected void S112( )
      {
         /* 'EMPDSC' Routine */
         /* Using cursor P001W3 */
         pr_default.execute(1, new Object[] {AV13EmpID});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A1EmpID = P001W3_A1EmpID[0];
            A45EmpEst = P001W3_A45EmpEst[0];
            n45EmpEst = P001W3_n45EmpEst[0];
            A44empdsc = P001W3_A44empdsc[0];
            n44empdsc = P001W3_n44empdsc[0];
            AV12emp = StringUtil.Trim( A44empdsc);
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(1);
      }

      protected void S141( )
      {
         /* 'TIPOPRODDSC' Routine */
         /* Using cursor P001W4 */
         pr_default.execute(2, new Object[] {AV8tipId});
         while ( (pr_default.getStatus(2) != 101) )
         {
            A31tipoProdID = P001W4_A31tipoProdID[0];
            A145tipoProdEst = P001W4_A145tipoProdEst[0];
            n145tipoProdEst = P001W4_n145tipoProdEst[0];
            A144tipoProdDsc = P001W4_A144tipoProdDsc[0];
            n144tipoProdDsc = P001W4_n144tipoProdDsc[0];
            A1EmpID = P001W4_A1EmpID[0];
            AV23tipoProd = A144tipoProdDsc;
            pr_default.readNext(2);
         }
         pr_default.close(2);
      }

      protected void S122( )
      {
         /* 'USERNAME' Routine */
         /* Using cursor P001W5 */
         pr_default.execute(3, new Object[] {AV26Usercod});
         while ( (pr_default.getStatus(3) != 101) )
         {
            A3UsuCod = P001W5_A3UsuCod[0];
            A52UsuEst = P001W5_A52UsuEst[0];
            n52UsuEst = P001W5_n52UsuEst[0];
            A50UsuName = P001W5_A50UsuName[0];
            n50UsuName = P001W5_n50UsuName[0];
            if ( ( StringUtil.StrCmp(AV26Usercod, "ADM") == 0 ) || ( StringUtil.StrCmp(AV26Usercod, "adm") == 0 ) )
            {
               AV27userName = StringUtil.Trim( StringUtil.Upper( A50UsuName));
            }
            else
            {
               AV27userName = A3UsuCod;
            }
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(3);
      }

      protected void S132( )
      {
         /* 'CLIENTEDSCHEAD' Routine */
         /* Using cursor P001W6 */
         pr_default.execute(4, new Object[] {AV11ClienteID});
         while ( (pr_default.getStatus(4) != 101) )
         {
            A5ClienteID = P001W6_A5ClienteID[0];
            A58ClienteTelf = P001W6_A58ClienteTelf[0];
            n58ClienteTelf = P001W6_n58ClienteTelf[0];
            A57ClienteDsc = P001W6_A57ClienteDsc[0];
            n57ClienteDsc = P001W6_n57ClienteDsc[0];
            A1EmpID = P001W6_A1EmpID[0];
            AV10ClienteDscHead = StringUtil.Trim( A57ClienteDsc);
            pr_default.readNext(4);
         }
         pr_default.close(4);
      }

      protected void H1W0( bool bFoot ,
                           int Inc )
      {
         /* Skip the required number of lines */
         while ( ( ToSkip > 0 ) || ( Gx_line + Inc > P_lines ) )
         {
            if ( Gx_line + Inc >= P_lines )
            {
               if ( Gx_page > 0 )
               {
                  /* Print footers */
                  Gx_line = P_lines;
                  getPrinter().GxEndPage() ;
                  if ( bFoot )
                  {
                     return  ;
                  }
               }
               ToSkip = 0;
               Gx_line = 0;
               Gx_page = (int)(Gx_page+1);
               /* Skip Margin Top Lines */
               Gx_line = (int)(Gx_line+(M_top*lineHeight));
               /* Print headers */
               getPrinter().GxStartPage() ;
               /* Execute user subroutine: 'EMPDSC' */
               S112 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
               /* Execute user subroutine: 'USERNAME' */
               S122 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
               /* Execute user subroutine: 'CLIENTEDSCHEAD' */
               S132 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
               getPrinter().GxDrawRect(0, Gx_line+1, 1149, Gx_line+101, 0, 0, 0, 0, 1, 220, 220, 220, 0, 0, 0, 0, 0, 0, 0, 0) ;
               getPrinter().GxAttris("Qatar2022 Medium", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(context.localUtil.Format( Gx_date, "99/99/99"), 1045, Gx_line+10, 1133, Gx_line+26, 2, 0, 0, 1) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( Gx_time, "")), 1045, Gx_line+30, 1133, Gx_line+46, 2, 0, 0, 1) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV27userName, "")), 1031, Gx_line+51, 1132, Gx_line+67, 2, 0, 0, 1) ;
               getPrinter().GxAttris("Qatar2022 Medium", 9, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Fecha:", 975, Gx_line+10, 1030, Gx_line+26, 0, 0, 0, 0) ;
               getPrinter().GxDrawText("Hora:", 975, Gx_line+30, 1030, Gx_line+46, 0, 0, 0, 0) ;
               getPrinter().GxDrawText("Usuario:", 975, Gx_line+51, 1030, Gx_line+67, 0, 0, 0, 0) ;
               getPrinter().GxDrawText("Detalles - Items", 614, Gx_line+43, 728, Gx_line+61, 0, 0, 0, 0) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(AV21OrdenID), "ZZZ9")), 583, Gx_line+43, 613, Gx_line+61, 1, 0, 0, 1) ;
               getPrinter().GxAttris("Qatar2022 Medium", 10, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Requision Nro.", 474, Gx_line+43, 582, Gx_line+61, 0+256, 0, 0, 0) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV10ClienteDscHead, "")), 406, Gx_line+69, 805, Gx_line+87, 1, 0, 0, 1) ;
               getPrinter().GxAttris("Qatar2022 Medium", 16, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV12emp, "")), 355, Gx_line+11, 814, Gx_line+39, 1+256, 0, 0, 1) ;
               Gx_OldLine = Gx_line;
               Gx_line = (int)(Gx_line+101);
               if (true) break;
            }
            else
            {
               PrtOffset = 0;
               Gx_line = (int)(Gx_line+1);
            }
            ToSkip = (int)(ToSkip-1);
         }
         getPrinter().setPage(Gx_page);
      }

      protected void add_metrics( )
      {
         add_metrics0( ) ;
         add_metrics1( ) ;
      }

      protected void add_metrics0( )
      {
         getPrinter().setMetrics("Qatar2022 Medium", true, false, 57, 15, 72, 163,  new int[] {47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 17, 19, 29, 34, 34, 55, 45, 15, 21, 21, 24, 36, 17, 21, 17, 17, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 21, 21, 36, 36, 36, 38, 60, 43, 45, 45, 45, 41, 38, 48, 45, 17, 34, 45, 38, 53, 45, 48, 41, 48, 45, 41, 38, 45, 41, 57, 41, 41, 38, 21, 17, 21, 36, 34, 21, 34, 38, 34, 38, 34, 21, 38, 38, 17, 17, 34, 17, 55, 38, 38, 38, 38, 24, 34, 21, 38, 33, 49, 34, 34, 31, 24, 17, 24, 36, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 17, 21, 34, 34, 34, 34, 17, 34, 21, 46, 23, 34, 36, 21, 46, 34, 25, 34, 21, 21, 21, 36, 34, 21, 20, 21, 23, 34, 52, 52, 52, 38, 45, 45, 45, 45, 45, 45, 62, 45, 41, 41, 41, 41, 17, 17, 17, 17, 45, 45, 48, 48, 48, 48, 48, 36, 48, 45, 45, 45, 45, 41, 41, 38, 34, 34, 34, 34, 34, 34, 55, 34, 34, 34, 34, 34, 17, 17, 17, 17, 38, 38, 38, 38, 38, 38, 38, 34, 38, 38, 38, 38, 38, 34, 38, 34}) ;
      }

      protected void add_metrics1( )
      {
         getPrinter().setMetrics("Qatar2022 Medium", false, false, 58, 14, 72, 171,  new int[] {48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 18, 20, 23, 36, 36, 57, 43, 12, 21, 21, 25, 37, 18, 21, 18, 18, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 18, 18, 37, 37, 37, 36, 65, 43, 43, 46, 46, 43, 39, 50, 46, 18, 32, 43, 36, 53, 46, 50, 43, 50, 46, 43, 40, 46, 43, 64, 41, 42, 39, 18, 18, 18, 27, 36, 21, 36, 36, 32, 36, 36, 18, 36, 36, 14, 15, 33, 14, 55, 36, 36, 36, 36, 21, 32, 18, 36, 33, 47, 31, 31, 31, 21, 17, 21, 37, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 18, 20, 36, 36, 36, 36, 17, 36, 21, 47, 24, 36, 37, 21, 47, 35, 26, 35, 21, 21, 21, 37, 34, 21, 21, 21, 23, 36, 53, 53, 53, 39, 43, 43, 43, 43, 43, 43, 64, 46, 43, 43, 43, 43, 18, 18, 18, 18, 46, 46, 50, 50, 50, 50, 50, 37, 50, 46, 46, 46, 46, 43, 43, 39, 36, 36, 36, 36, 36, 36, 57, 32, 36, 36, 36, 36, 18, 18, 18, 18, 36, 36, 36, 36, 36, 36, 36, 35, 39, 36, 36, 36, 36, 32, 36, 32}) ;
      }

      public override int getOutputType( )
      {
         return GxReportUtils.OUTPUT_PDF ;
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if (IsMain)	waitPrinterEnd();
         base.cleanup();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         GXKey = "";
         gxfirstwebparm = "";
         scmdbuf = "";
         P001W2_A32categID = new short[1] ;
         P001W2_A33subCatID = new short[1] ;
         P001W2_A22OrdenID = new short[1] ;
         P001W2_A25OrdenAnio = new short[1] ;
         P001W2_A24OrdenPeriodo = new short[1] ;
         P001W2_A5ClienteID = new short[1] ;
         P001W2_A1EmpID = new short[1] ;
         P001W2_A36detTipoProdID = new short[1] ;
         P001W2_A148subCatDsc = new String[] {""} ;
         P001W2_n148subCatDsc = new bool[] {false} ;
         P001W2_A146categDsc = new String[] {""} ;
         P001W2_n146categDsc = new bool[] {false} ;
         P001W2_A41OrdenSecId = new short[1] ;
         P001W2_A150subCatPrec = new decimal[1] ;
         P001W2_n150subCatPrec = new bool[] {false} ;
         P001W2_A208OrdenDetCant = new decimal[1] ;
         P001W2_n208OrdenDetCant = new bool[] {false} ;
         A148subCatDsc = "";
         A146categDsc = "";
         AV23tipoProd = "";
         P001W3_A1EmpID = new short[1] ;
         P001W3_A45EmpEst = new String[] {""} ;
         P001W3_n45EmpEst = new bool[] {false} ;
         P001W3_A44empdsc = new String[] {""} ;
         P001W3_n44empdsc = new bool[] {false} ;
         A45EmpEst = "";
         A44empdsc = "";
         AV12emp = "";
         P001W4_A31tipoProdID = new short[1] ;
         P001W4_A145tipoProdEst = new String[] {""} ;
         P001W4_n145tipoProdEst = new bool[] {false} ;
         P001W4_A144tipoProdDsc = new String[] {""} ;
         P001W4_n144tipoProdDsc = new bool[] {false} ;
         P001W4_A1EmpID = new short[1] ;
         A145tipoProdEst = "";
         A144tipoProdDsc = "";
         P001W5_A3UsuCod = new String[] {""} ;
         P001W5_A52UsuEst = new String[] {""} ;
         P001W5_n52UsuEst = new bool[] {false} ;
         P001W5_A50UsuName = new String[] {""} ;
         P001W5_n50UsuName = new bool[] {false} ;
         A3UsuCod = "";
         A52UsuEst = "";
         A50UsuName = "";
         AV27userName = "";
         P001W6_A5ClienteID = new short[1] ;
         P001W6_A58ClienteTelf = new String[] {""} ;
         P001W6_n58ClienteTelf = new bool[] {false} ;
         P001W6_A57ClienteDsc = new String[] {""} ;
         P001W6_n57ClienteDsc = new bool[] {false} ;
         P001W6_A1EmpID = new short[1] ;
         A58ClienteTelf = "";
         A57ClienteDsc = "";
         AV10ClienteDscHead = "";
         Gx_date = DateTime.MinValue;
         Gx_time = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.apdfprevopitems__default(),
            new Object[][] {
                new Object[] {
               P001W2_A32categID, P001W2_A33subCatID, P001W2_A22OrdenID, P001W2_A25OrdenAnio, P001W2_A24OrdenPeriodo, P001W2_A5ClienteID, P001W2_A1EmpID, P001W2_A36detTipoProdID, P001W2_A148subCatDsc, P001W2_n148subCatDsc,
               P001W2_A146categDsc, P001W2_n146categDsc, P001W2_A41OrdenSecId, P001W2_A150subCatPrec, P001W2_n150subCatPrec, P001W2_A208OrdenDetCant, P001W2_n208OrdenDetCant
               }
               , new Object[] {
               P001W3_A1EmpID, P001W3_A45EmpEst, P001W3_n45EmpEst, P001W3_A44empdsc, P001W3_n44empdsc
               }
               , new Object[] {
               P001W4_A31tipoProdID, P001W4_A145tipoProdEst, P001W4_n145tipoProdEst, P001W4_A144tipoProdDsc, P001W4_n144tipoProdDsc, P001W4_A1EmpID
               }
               , new Object[] {
               P001W5_A3UsuCod, P001W5_A52UsuEst, P001W5_n52UsuEst, P001W5_A50UsuName, P001W5_n50UsuName
               }
               , new Object[] {
               P001W6_A5ClienteID, P001W6_A58ClienteTelf, P001W6_n58ClienteTelf, P001W6_A57ClienteDsc, P001W6_n57ClienteDsc, P001W6_A1EmpID
               }
            }
         );
         Gx_time = context.localUtil.Time( );
         Gx_date = DateTimeUtil.Today( context);
         /* GeneXus formulas. */
         Gx_line = 0;
         Gx_time = context.localUtil.Time( );
         Gx_date = DateTimeUtil.Today( context);
         context.Gx_err = 0;
      }

      private short gxcookieaux ;
      private short nGotPars ;
      private short AV13EmpID ;
      private short AV11ClienteID ;
      private short AV22OrdenPeriodo ;
      private short AV20OrdenAnio ;
      private short AV21OrdenID ;
      private short GxWebError ;
      private short AV33GXLvl16 ;
      private short A32categID ;
      private short A33subCatID ;
      private short A22OrdenID ;
      private short A25OrdenAnio ;
      private short A24OrdenPeriodo ;
      private short A5ClienteID ;
      private short A1EmpID ;
      private short A36detTipoProdID ;
      private short A41OrdenSecId ;
      private short AV8tipId ;
      private short AV19nroItems ;
      private short A31tipoProdID ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int Gx_OldLine ;
      private decimal AV24totalValor ;
      private decimal AV25totCant ;
      private decimal AV28totalPrec ;
      private decimal A150subCatPrec ;
      private decimal A208OrdenDetCant ;
      private decimal A209OrdenDetVal ;
      private String GXKey ;
      private String gxfirstwebparm ;
      private String AV26Usercod ;
      private String scmdbuf ;
      private String A148subCatDsc ;
      private String A146categDsc ;
      private String A45EmpEst ;
      private String A145tipoProdEst ;
      private String A144tipoProdDsc ;
      private String A3UsuCod ;
      private String A52UsuEst ;
      private String A57ClienteDsc ;
      private String Gx_time ;
      private DateTime Gx_date ;
      private bool entryPointCalled ;
      private bool n148subCatDsc ;
      private bool n146categDsc ;
      private bool n150subCatPrec ;
      private bool n208OrdenDetCant ;
      private bool returnInSub ;
      private bool n45EmpEst ;
      private bool n44empdsc ;
      private bool n145tipoProdEst ;
      private bool n144tipoProdDsc ;
      private bool n52UsuEst ;
      private bool n50UsuName ;
      private bool n58ClienteTelf ;
      private bool n57ClienteDsc ;
      private String AV23tipoProd ;
      private String A44empdsc ;
      private String AV12emp ;
      private String A50UsuName ;
      private String AV27userName ;
      private String A58ClienteTelf ;
      private String AV10ClienteDscHead ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P001W2_A32categID ;
      private short[] P001W2_A33subCatID ;
      private short[] P001W2_A22OrdenID ;
      private short[] P001W2_A25OrdenAnio ;
      private short[] P001W2_A24OrdenPeriodo ;
      private short[] P001W2_A5ClienteID ;
      private short[] P001W2_A1EmpID ;
      private short[] P001W2_A36detTipoProdID ;
      private String[] P001W2_A148subCatDsc ;
      private bool[] P001W2_n148subCatDsc ;
      private String[] P001W2_A146categDsc ;
      private bool[] P001W2_n146categDsc ;
      private short[] P001W2_A41OrdenSecId ;
      private decimal[] P001W2_A150subCatPrec ;
      private bool[] P001W2_n150subCatPrec ;
      private decimal[] P001W2_A208OrdenDetCant ;
      private bool[] P001W2_n208OrdenDetCant ;
      private short[] P001W3_A1EmpID ;
      private String[] P001W3_A45EmpEst ;
      private bool[] P001W3_n45EmpEst ;
      private String[] P001W3_A44empdsc ;
      private bool[] P001W3_n44empdsc ;
      private short[] P001W4_A31tipoProdID ;
      private String[] P001W4_A145tipoProdEst ;
      private bool[] P001W4_n145tipoProdEst ;
      private String[] P001W4_A144tipoProdDsc ;
      private bool[] P001W4_n144tipoProdDsc ;
      private short[] P001W4_A1EmpID ;
      private String[] P001W5_A3UsuCod ;
      private String[] P001W5_A52UsuEst ;
      private bool[] P001W5_n52UsuEst ;
      private String[] P001W5_A50UsuName ;
      private bool[] P001W5_n50UsuName ;
      private short[] P001W6_A5ClienteID ;
      private String[] P001W6_A58ClienteTelf ;
      private bool[] P001W6_n58ClienteTelf ;
      private String[] P001W6_A57ClienteDsc ;
      private bool[] P001W6_n57ClienteDsc ;
      private short[] P001W6_A1EmpID ;
   }

   public class apdfprevopitems__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001W2 ;
          prmP001W2 = new Object[] {
          new Object[] {"@AV13EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV22OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV20OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV21OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001W3 ;
          prmP001W3 = new Object[] {
          new Object[] {"@AV13EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001W4 ;
          prmP001W4 = new Object[] {
          new Object[] {"@AV8tipId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001W5 ;
          prmP001W5 = new Object[] {
          new Object[] {"@AV26Usercod",SqlDbType.Char,15,0}
          } ;
          Object[] prmP001W6 ;
          prmP001W6 = new Object[] {
          new Object[] {"@AV11ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001W2", "SELECT T1.[categID], T1.[subCatID], T1.[OrdenID], T1.[OrdenAnio], T1.[OrdenPeriodo], T1.[ClienteID], T1.[EmpID], T1.[detTipoProdID], T3.[subCatDsc], T2.[categDsc], T1.[OrdenSecId], T3.[subCatPrec], T1.[OrdenDetCant] FROM (([OrdenProduccionOpItems] T1 WITH (NOLOCK) INNER JOIN [Categorias] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[categID] = T1.[categID]) INNER JOIN [CategoriassubCat] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[categID] = T1.[categID] AND T3.[subCatID] = T1.[subCatID]) WHERE T1.[EmpID] = @AV13EmpID and T1.[ClienteID] = @AV11ClienteID and T1.[OrdenPeriodo] = @AV22OrdenPeriodo and T1.[OrdenAnio] = @AV20OrdenAnio and T1.[OrdenID] = @AV21OrdenID ORDER BY T1.[EmpID], T1.[ClienteID], T1.[OrdenPeriodo], T1.[OrdenAnio], T1.[OrdenID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001W2,100,0,true,false )
             ,new CursorDef("P001W3", "SELECT TOP 1 [EmpID], [EmpEst], [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @AV13EmpID ORDER BY [EmpID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001W3,1,0,true,true )
             ,new CursorDef("P001W4", "SELECT [tipoProdID], [tipoProdEst], [tipoProdDsc], [EmpID] FROM [TipoProducto] WITH (NOLOCK) WHERE [tipoProdID] = @AV8tipId ORDER BY [EmpID], [tipoProdID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001W4,100,0,true,false )
             ,new CursorDef("P001W5", "SELECT TOP 1 [UsuCod], [UsuEst], [UsuName] FROM [Usuarios] WITH (NOLOCK) WHERE [UsuCod] = @AV26Usercod ORDER BY [UsuCod] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001W5,1,0,true,true )
             ,new CursorDef("P001W6", "SELECT [ClienteID], [ClienteTelf], [ClienteDsc], [EmpID] FROM [Clientes] WITH (NOLOCK) WHERE [ClienteID] = @AV11ClienteID ORDER BY [EmpID], [ClienteID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001W6,100,0,true,false )
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
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((String[]) buf[8])[0] = rslt.getString(9, 40) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(9);
                ((String[]) buf[10])[0] = rslt.getString(10, 40) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(10);
                ((short[]) buf[12])[0] = rslt.getShort(11) ;
                ((decimal[]) buf[13])[0] = rslt.getDecimal(12) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(12);
                ((decimal[]) buf[15])[0] = rslt.getDecimal(13) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(13);
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 1) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 1) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 40) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 1) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
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
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
