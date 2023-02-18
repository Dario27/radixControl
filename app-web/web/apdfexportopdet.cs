/*
               File: pdfExportOPDet
        Description: pdf Export OPDet
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 11/19/2022 22:52:52.20
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
   public class apdfexportopdet : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
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
               AV12EmpID = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV10ClienteID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV20OrdenPeriodo = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV18OrdenAnio = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV19OrdenID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV23Usercod = GetNextPar( );
               }
            }
         }
         if ( GxWebError == 0 )
         {
            executePrivate();
         }
         cleanup();
      }

      public apdfexportopdet( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public apdfexportopdet( IGxContext context )
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
         this.AV12EmpID = aP0_EmpID;
         this.AV10ClienteID = aP1_ClienteID;
         this.AV20OrdenPeriodo = aP2_OrdenPeriodo;
         this.AV18OrdenAnio = aP3_OrdenAnio;
         this.AV19OrdenID = aP4_OrdenID;
         this.AV23Usercod = aP5_Usercod;
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
         apdfexportopdet objapdfexportopdet;
         objapdfexportopdet = new apdfexportopdet();
         objapdfexportopdet.AV12EmpID = aP0_EmpID;
         objapdfexportopdet.AV10ClienteID = aP1_ClienteID;
         objapdfexportopdet.AV20OrdenPeriodo = aP2_OrdenPeriodo;
         objapdfexportopdet.AV18OrdenAnio = aP3_OrdenAnio;
         objapdfexportopdet.AV19OrdenID = aP4_OrdenID;
         objapdfexportopdet.AV23Usercod = aP5_Usercod;
         objapdfexportopdet.context.SetSubmitInitialConfig(context);
         objapdfexportopdet.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objapdfexportopdet);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((apdfexportopdet)stateInfo).executePrivate();
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
            H120( false, 30) ;
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
            AV27totalValor = 0;
            AV26totCant = 0;
            AV28totalPrec = 0;
            AV33GXLvl16 = 0;
            /* Using cursor P00122 */
            pr_default.execute(0, new Object[] {AV12EmpID, AV10ClienteID, AV20OrdenPeriodo, AV18OrdenAnio, AV19OrdenID});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A32categID = P00122_A32categID[0];
               A33subCatID = P00122_A33subCatID[0];
               A22OrdenID = P00122_A22OrdenID[0];
               A25OrdenAnio = P00122_A25OrdenAnio[0];
               A24OrdenPeriodo = P00122_A24OrdenPeriodo[0];
               A5ClienteID = P00122_A5ClienteID[0];
               A1EmpID = P00122_A1EmpID[0];
               A36detTipoProdID = P00122_A36detTipoProdID[0];
               A148subCatDsc = P00122_A148subCatDsc[0];
               n148subCatDsc = P00122_n148subCatDsc[0];
               A146categDsc = P00122_A146categDsc[0];
               n146categDsc = P00122_n146categDsc[0];
               A41OrdenSecId = P00122_A41OrdenSecId[0];
               A150subCatPrec = P00122_A150subCatPrec[0];
               n150subCatPrec = P00122_n150subCatPrec[0];
               A208OrdenDetCant = P00122_A208OrdenDetCant[0];
               n208OrdenDetCant = P00122_n208OrdenDetCant[0];
               A146categDsc = P00122_A146categDsc[0];
               n146categDsc = P00122_n146categDsc[0];
               A148subCatDsc = P00122_A148subCatDsc[0];
               n148subCatDsc = P00122_n148subCatDsc[0];
               A150subCatPrec = P00122_A150subCatPrec[0];
               n150subCatPrec = P00122_n150subCatPrec[0];
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
               if ( AV22nroItems == 0 )
               {
                  AV22nroItems = 1;
                  H120( false, 17) ;
                  getPrinter().GxAttris("Qatar2022 Medium", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A41OrdenSecId), "ZZZ9")), 25, Gx_line+0, 55, Gx_line+15, 0+256, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV21tipoProd, "")), 61, Gx_line+0, 244, Gx_line+15, 0, 0, 0, 1) ;
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
                  AV22nroItems = 0;
                  H120( false, 22) ;
                  getPrinter().GxDrawRect(0, Gx_line+0, 1149, Gx_line+21, 1, 211, 211, 211, 1, 211, 211, 211, 0, 0, 0, 0, 0, 0, 0, 0) ;
                  getPrinter().GxAttris("Qatar2022 Medium", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( A209OrdenDetVal, "ZZZZ9.99")), 1005, Gx_line+3, 1064, Gx_line+18, 2+256, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( A208OrdenDetCant, "ZZZZ9.99")), 891, Gx_line+3, 950, Gx_line+18, 2+256, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( A150subCatPrec, "ZZZZ9.99")), 770, Gx_line+3, 829, Gx_line+18, 2+256, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A148subCatDsc, "@!")), 478, Gx_line+3, 729, Gx_line+18, 0+256, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A146categDsc, "@!")), 269, Gx_line+3, 449, Gx_line+18, 0, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV21tipoProd, "")), 61, Gx_line+3, 244, Gx_line+18, 0, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A41OrdenSecId), "ZZZ9")), 25, Gx_line+3, 55, Gx_line+18, 0+256, 0, 0, 1) ;
                  Gx_OldLine = Gx_line;
                  Gx_line = (int)(Gx_line+22);
               }
               AV27totalValor = (decimal)(AV27totalValor+A209OrdenDetVal);
               AV26totCant = (decimal)(AV26totCant+A208OrdenDetCant);
               AV28totalPrec = (decimal)(AV28totalPrec+A150subCatPrec);
               pr_default.readNext(0);
            }
            pr_default.close(0);
            if ( AV33GXLvl16 == 0 )
            {
               H120( false, 28) ;
               getPrinter().GxAttris("Qatar2022 Medium", 14, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("No se ha encontrado información", 12, Gx_line+4, 351, Gx_line+28, 0+256, 0, 0, 0) ;
               Gx_OldLine = Gx_line;
               Gx_line = (int)(Gx_line+28);
            }
            H120( false, 25) ;
            getPrinter().GxDrawLine(0, Gx_line+1, 1149, Gx_line+1, 1, 0, 0, 0, 0) ;
            getPrinter().GxAttris("Qatar2022 Medium", 8, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( AV27totalValor, "ZZZZZZ9.99")), 980, Gx_line+5, 1064, Gx_line+20, 2+256, 0, 0, 0) ;
            getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( AV26totCant, "ZZZZZZ9.99")), 866, Gx_line+5, 950, Gx_line+20, 2+256, 0, 0, 0) ;
            getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( AV28totalPrec, "ZZZZZZ9.99")), 745, Gx_line+5, 829, Gx_line+20, 2+256, 0, 0, 0) ;
            getPrinter().GxAttris("Qatar2022 Medium", 9, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText("Totales", 529, Gx_line+5, 580, Gx_line+20, 0+256, 0, 0, 0) ;
            Gx_OldLine = Gx_line;
            Gx_line = (int)(Gx_line+25);
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1);
            H120( true, 0) ;
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
         /* Using cursor P00123 */
         pr_default.execute(1, new Object[] {AV12EmpID});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A1EmpID = P00123_A1EmpID[0];
            A45EmpEst = P00123_A45EmpEst[0];
            n45EmpEst = P00123_n45EmpEst[0];
            A44empdsc = P00123_A44empdsc[0];
            n44empdsc = P00123_n44empdsc[0];
            AV11emp = StringUtil.Trim( A44empdsc);
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
         /* Using cursor P00124 */
         pr_default.execute(2, new Object[] {AV8tipId});
         while ( (pr_default.getStatus(2) != 101) )
         {
            A31tipoProdID = P00124_A31tipoProdID[0];
            A145tipoProdEst = P00124_A145tipoProdEst[0];
            n145tipoProdEst = P00124_n145tipoProdEst[0];
            A144tipoProdDsc = P00124_A144tipoProdDsc[0];
            n144tipoProdDsc = P00124_n144tipoProdDsc[0];
            A1EmpID = P00124_A1EmpID[0];
            AV21tipoProd = A144tipoProdDsc;
            pr_default.readNext(2);
         }
         pr_default.close(2);
      }

      protected void S122( )
      {
         /* 'USERNAME' Routine */
         /* Using cursor P00125 */
         pr_default.execute(3, new Object[] {AV23Usercod});
         while ( (pr_default.getStatus(3) != 101) )
         {
            A3UsuCod = P00125_A3UsuCod[0];
            A52UsuEst = P00125_A52UsuEst[0];
            n52UsuEst = P00125_n52UsuEst[0];
            A50UsuName = P00125_A50UsuName[0];
            n50UsuName = P00125_n50UsuName[0];
            if ( ( StringUtil.StrCmp(AV23Usercod, "ADM") == 0 ) || ( StringUtil.StrCmp(AV23Usercod, "adm") == 0 ) )
            {
               AV24userName = StringUtil.Trim( StringUtil.Upper( A50UsuName));
            }
            else
            {
               AV24userName = A3UsuCod;
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
         /* Using cursor P00126 */
         pr_default.execute(4, new Object[] {AV10ClienteID});
         while ( (pr_default.getStatus(4) != 101) )
         {
            A5ClienteID = P00126_A5ClienteID[0];
            A58ClienteTelf = P00126_A58ClienteTelf[0];
            n58ClienteTelf = P00126_n58ClienteTelf[0];
            A57ClienteDsc = P00126_A57ClienteDsc[0];
            n57ClienteDsc = P00126_n57ClienteDsc[0];
            A1EmpID = P00126_A1EmpID[0];
            AV25ClienteDscHead = StringUtil.Trim( A57ClienteDsc);
            pr_default.readNext(4);
         }
         pr_default.close(4);
      }

      protected void H120( bool bFoot ,
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
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV24userName, "")), 1031, Gx_line+51, 1132, Gx_line+67, 2, 0, 0, 1) ;
               getPrinter().GxAttris("Qatar2022 Medium", 9, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Fecha:", 975, Gx_line+10, 1030, Gx_line+26, 0, 0, 0, 0) ;
               getPrinter().GxDrawText("Hora:", 975, Gx_line+30, 1030, Gx_line+46, 0, 0, 0, 0) ;
               getPrinter().GxDrawText("Usuario:", 975, Gx_line+51, 1030, Gx_line+67, 0, 0, 0, 0) ;
               getPrinter().GxDrawText("Detalles - Items", 614, Gx_line+43, 728, Gx_line+61, 0, 0, 0, 0) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(AV19OrdenID), "ZZZ9")), 583, Gx_line+43, 613, Gx_line+61, 1, 0, 0, 1) ;
               getPrinter().GxAttris("Qatar2022 Medium", 10, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Requision Nro.", 474, Gx_line+43, 582, Gx_line+61, 0+256, 0, 0, 0) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV25ClienteDscHead, "")), 406, Gx_line+69, 805, Gx_line+87, 1, 0, 0, 1) ;
               getPrinter().GxAttris("Qatar2022 Medium", 16, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV11emp, "")), 355, Gx_line+11, 814, Gx_line+39, 1+256, 0, 0, 1) ;
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
         P00122_A32categID = new short[1] ;
         P00122_A33subCatID = new short[1] ;
         P00122_A22OrdenID = new short[1] ;
         P00122_A25OrdenAnio = new short[1] ;
         P00122_A24OrdenPeriodo = new short[1] ;
         P00122_A5ClienteID = new short[1] ;
         P00122_A1EmpID = new short[1] ;
         P00122_A36detTipoProdID = new short[1] ;
         P00122_A148subCatDsc = new String[] {""} ;
         P00122_n148subCatDsc = new bool[] {false} ;
         P00122_A146categDsc = new String[] {""} ;
         P00122_n146categDsc = new bool[] {false} ;
         P00122_A41OrdenSecId = new short[1] ;
         P00122_A150subCatPrec = new decimal[1] ;
         P00122_n150subCatPrec = new bool[] {false} ;
         P00122_A208OrdenDetCant = new decimal[1] ;
         P00122_n208OrdenDetCant = new bool[] {false} ;
         A148subCatDsc = "";
         A146categDsc = "";
         AV21tipoProd = "";
         P00123_A1EmpID = new short[1] ;
         P00123_A45EmpEst = new String[] {""} ;
         P00123_n45EmpEst = new bool[] {false} ;
         P00123_A44empdsc = new String[] {""} ;
         P00123_n44empdsc = new bool[] {false} ;
         A45EmpEst = "";
         A44empdsc = "";
         AV11emp = "";
         P00124_A31tipoProdID = new short[1] ;
         P00124_A145tipoProdEst = new String[] {""} ;
         P00124_n145tipoProdEst = new bool[] {false} ;
         P00124_A144tipoProdDsc = new String[] {""} ;
         P00124_n144tipoProdDsc = new bool[] {false} ;
         P00124_A1EmpID = new short[1] ;
         A145tipoProdEst = "";
         A144tipoProdDsc = "";
         P00125_A3UsuCod = new String[] {""} ;
         P00125_A52UsuEst = new String[] {""} ;
         P00125_n52UsuEst = new bool[] {false} ;
         P00125_A50UsuName = new String[] {""} ;
         P00125_n50UsuName = new bool[] {false} ;
         A3UsuCod = "";
         A52UsuEst = "";
         A50UsuName = "";
         AV24userName = "";
         P00126_A5ClienteID = new short[1] ;
         P00126_A58ClienteTelf = new String[] {""} ;
         P00126_n58ClienteTelf = new bool[] {false} ;
         P00126_A57ClienteDsc = new String[] {""} ;
         P00126_n57ClienteDsc = new bool[] {false} ;
         P00126_A1EmpID = new short[1] ;
         A58ClienteTelf = "";
         A57ClienteDsc = "";
         AV25ClienteDscHead = "";
         Gx_date = DateTime.MinValue;
         Gx_time = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.apdfexportopdet__default(),
            new Object[][] {
                new Object[] {
               P00122_A32categID, P00122_A33subCatID, P00122_A22OrdenID, P00122_A25OrdenAnio, P00122_A24OrdenPeriodo, P00122_A5ClienteID, P00122_A1EmpID, P00122_A36detTipoProdID, P00122_A148subCatDsc, P00122_n148subCatDsc,
               P00122_A146categDsc, P00122_n146categDsc, P00122_A41OrdenSecId, P00122_A150subCatPrec, P00122_n150subCatPrec, P00122_A208OrdenDetCant, P00122_n208OrdenDetCant
               }
               , new Object[] {
               P00123_A1EmpID, P00123_A45EmpEst, P00123_n45EmpEst, P00123_A44empdsc, P00123_n44empdsc
               }
               , new Object[] {
               P00124_A31tipoProdID, P00124_A145tipoProdEst, P00124_n145tipoProdEst, P00124_A144tipoProdDsc, P00124_n144tipoProdDsc, P00124_A1EmpID
               }
               , new Object[] {
               P00125_A3UsuCod, P00125_A52UsuEst, P00125_n52UsuEst, P00125_A50UsuName, P00125_n50UsuName
               }
               , new Object[] {
               P00126_A5ClienteID, P00126_A58ClienteTelf, P00126_n58ClienteTelf, P00126_A57ClienteDsc, P00126_n57ClienteDsc, P00126_A1EmpID
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
      private short AV12EmpID ;
      private short AV10ClienteID ;
      private short AV20OrdenPeriodo ;
      private short AV18OrdenAnio ;
      private short AV19OrdenID ;
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
      private short AV22nroItems ;
      private short A31tipoProdID ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int Gx_OldLine ;
      private decimal AV27totalValor ;
      private decimal AV26totCant ;
      private decimal AV28totalPrec ;
      private decimal A150subCatPrec ;
      private decimal A208OrdenDetCant ;
      private decimal A209OrdenDetVal ;
      private String GXKey ;
      private String gxfirstwebparm ;
      private String AV23Usercod ;
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
      private String AV21tipoProd ;
      private String A44empdsc ;
      private String AV11emp ;
      private String A50UsuName ;
      private String AV24userName ;
      private String A58ClienteTelf ;
      private String AV25ClienteDscHead ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00122_A32categID ;
      private short[] P00122_A33subCatID ;
      private short[] P00122_A22OrdenID ;
      private short[] P00122_A25OrdenAnio ;
      private short[] P00122_A24OrdenPeriodo ;
      private short[] P00122_A5ClienteID ;
      private short[] P00122_A1EmpID ;
      private short[] P00122_A36detTipoProdID ;
      private String[] P00122_A148subCatDsc ;
      private bool[] P00122_n148subCatDsc ;
      private String[] P00122_A146categDsc ;
      private bool[] P00122_n146categDsc ;
      private short[] P00122_A41OrdenSecId ;
      private decimal[] P00122_A150subCatPrec ;
      private bool[] P00122_n150subCatPrec ;
      private decimal[] P00122_A208OrdenDetCant ;
      private bool[] P00122_n208OrdenDetCant ;
      private short[] P00123_A1EmpID ;
      private String[] P00123_A45EmpEst ;
      private bool[] P00123_n45EmpEst ;
      private String[] P00123_A44empdsc ;
      private bool[] P00123_n44empdsc ;
      private short[] P00124_A31tipoProdID ;
      private String[] P00124_A145tipoProdEst ;
      private bool[] P00124_n145tipoProdEst ;
      private String[] P00124_A144tipoProdDsc ;
      private bool[] P00124_n144tipoProdDsc ;
      private short[] P00124_A1EmpID ;
      private String[] P00125_A3UsuCod ;
      private String[] P00125_A52UsuEst ;
      private bool[] P00125_n52UsuEst ;
      private String[] P00125_A50UsuName ;
      private bool[] P00125_n50UsuName ;
      private short[] P00126_A5ClienteID ;
      private String[] P00126_A58ClienteTelf ;
      private bool[] P00126_n58ClienteTelf ;
      private String[] P00126_A57ClienteDsc ;
      private bool[] P00126_n57ClienteDsc ;
      private short[] P00126_A1EmpID ;
   }

   public class apdfexportopdet__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00122 ;
          prmP00122 = new Object[] {
          new Object[] {"@AV12EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV20OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV18OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV19OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP00123 ;
          prmP00123 = new Object[] {
          new Object[] {"@AV12EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP00124 ;
          prmP00124 = new Object[] {
          new Object[] {"@AV8tipId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP00125 ;
          prmP00125 = new Object[] {
          new Object[] {"@AV23Usercod",SqlDbType.Char,15,0}
          } ;
          Object[] prmP00126 ;
          prmP00126 = new Object[] {
          new Object[] {"@AV10ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00122", "SELECT T1.[categID], T1.[subCatID], T1.[OrdenID], T1.[OrdenAnio], T1.[OrdenPeriodo], T1.[ClienteID], T1.[EmpID], T1.[detTipoProdID], T3.[subCatDsc], T2.[categDsc], T1.[OrdenSecId], T3.[subCatPrec], T1.[OrdenDetCant] FROM (([OrdenProduccionOpItems] T1 WITH (NOLOCK) INNER JOIN [Categorias] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[categID] = T1.[categID]) INNER JOIN [CategoriassubCat] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[categID] = T1.[categID] AND T3.[subCatID] = T1.[subCatID]) WHERE T1.[EmpID] = @AV12EmpID and T1.[ClienteID] = @AV10ClienteID and T1.[OrdenPeriodo] = @AV20OrdenPeriodo and T1.[OrdenAnio] = @AV18OrdenAnio and T1.[OrdenID] = @AV19OrdenID ORDER BY T1.[EmpID], T1.[ClienteID], T1.[OrdenPeriodo], T1.[OrdenAnio], T1.[OrdenID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00122,100,0,true,false )
             ,new CursorDef("P00123", "SELECT TOP 1 [EmpID], [EmpEst], [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @AV12EmpID ORDER BY [EmpID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00123,1,0,true,true )
             ,new CursorDef("P00124", "SELECT [tipoProdID], [tipoProdEst], [tipoProdDsc], [EmpID] FROM [TipoProducto] WITH (NOLOCK) WHERE [tipoProdID] = @AV8tipId ORDER BY [EmpID], [tipoProdID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00124,100,0,true,false )
             ,new CursorDef("P00125", "SELECT TOP 1 [UsuCod], [UsuEst], [UsuName] FROM [Usuarios] WITH (NOLOCK) WHERE [UsuCod] = @AV23Usercod ORDER BY [UsuCod] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00125,1,0,true,true )
             ,new CursorDef("P00126", "SELECT [ClienteID], [ClienteTelf], [ClienteDsc], [EmpID] FROM [Clientes] WITH (NOLOCK) WHERE [ClienteID] = @AV10ClienteID ORDER BY [EmpID], [ClienteID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00126,100,0,true,false )
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
