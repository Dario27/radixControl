/*
               File: pdfStockBodega
        Description: pdf Stock Bodega
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/9/2023 12:19:49.43
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
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class apdfstockbodega : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
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
               AV21fdesde = context.localUtil.ParseDateParm( gxfirstwebparm);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV22fHasta = context.localUtil.ParseDateParm( GetNextPar( ));
                  AV10EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV11AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV12BodCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV13prdCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV14usuCod = GetNextPar( );
               }
            }
         }
         if ( GxWebError == 0 )
         {
            executePrivate();
         }
         cleanup();
      }

      public apdfstockbodega( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public apdfstockbodega( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( DateTime aP0_fdesde ,
                           DateTime aP1_fHasta ,
                           short aP2_EmpID ,
                           short aP3_AgeID ,
                           short aP4_BodCod ,
                           short aP5_prdCod ,
                           String aP6_usuCod )
      {
         this.AV21fdesde = aP0_fdesde;
         this.AV22fHasta = aP1_fHasta;
         this.AV10EmpID = aP2_EmpID;
         this.AV11AgeID = aP3_AgeID;
         this.AV12BodCod = aP4_BodCod;
         this.AV13prdCod = aP5_prdCod;
         this.AV14usuCod = aP6_usuCod;
         initialize();
         executePrivate();
      }

      public void executeSubmit( DateTime aP0_fdesde ,
                                 DateTime aP1_fHasta ,
                                 short aP2_EmpID ,
                                 short aP3_AgeID ,
                                 short aP4_BodCod ,
                                 short aP5_prdCod ,
                                 String aP6_usuCod )
      {
         apdfstockbodega objapdfstockbodega;
         objapdfstockbodega = new apdfstockbodega();
         objapdfstockbodega.AV21fdesde = aP0_fdesde;
         objapdfstockbodega.AV22fHasta = aP1_fHasta;
         objapdfstockbodega.AV10EmpID = aP2_EmpID;
         objapdfstockbodega.AV11AgeID = aP3_AgeID;
         objapdfstockbodega.AV12BodCod = aP4_BodCod;
         objapdfstockbodega.AV13prdCod = aP5_prdCod;
         objapdfstockbodega.AV14usuCod = aP6_usuCod;
         objapdfstockbodega.context.SetSubmitInitialConfig(context);
         objapdfstockbodega.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objapdfstockbodega);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((apdfstockbodega)stateInfo).executePrivate();
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
            if (!initPrinter (Gx_out, gxXPage, gxYPage, "GXPRN.INI", "", "", 2, 1, 9, 16834, 11909, 0, 1, 1, 0, 1, 1) )
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
            /* Execute user subroutine: 'USERNAME' */
            S111 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
            /* Using cursor P001K2 */
            pr_default.execute(0, new Object[] {AV10EmpID, AV11AgeID});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A2AgeID = P001K2_A2AgeID[0];
               A1EmpID = P001K2_A1EmpID[0];
               A46AgeDsc = P001K2_A46AgeDsc[0];
               n46AgeDsc = P001K2_n46AgeDsc[0];
               A44empdsc = P001K2_A44empdsc[0];
               n44empdsc = P001K2_n44empdsc[0];
               A97emplogo = P001K2_A97emplogo[0];
               n97emplogo = P001K2_n97emplogo[0];
               A44empdsc = P001K2_A44empdsc[0];
               n44empdsc = P001K2_n44empdsc[0];
               A97emplogo = P001K2_A97emplogo[0];
               n97emplogo = P001K2_n97emplogo[0];
               AV16logo = StringUtil.Trim( A97emplogo);
               AV31Logo_GXI = GXDbFile.PathToUrl( StringUtil.Trim( A97emplogo));
               AV26totIng = 0;
               AV27TotEgr = 0;
               GxHdr3 = true;
               pr_default.dynParam(1, new Object[]{ new Object[]{
                                                    AV12BodCod ,
                                                    AV13prdCod ,
                                                    A42BodCod ,
                                                    A286PrdCod ,
                                                    A1EmpID ,
                                                    A2AgeID } ,
                                                    new int[]{
                                                    TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT
                                                    }
               } ) ;
               /* Using cursor P001K3 */
               pr_default.execute(1, new Object[] {A1EmpID, A2AgeID, AV12BodCod, AV13prdCod});
               while ( (pr_default.getStatus(1) != 101) )
               {
                  A286PrdCod = P001K3_A286PrdCod[0];
                  A42BodCod = P001K3_A42BodCod[0];
                  A291stockMes = P001K3_A291stockMes[0];
                  A290stockAnio = P001K3_A290stockAnio[0];
                  A288PrdPres = P001K3_A288PrdPres[0];
                  n288PrdPres = P001K3_n288PrdPres[0];
                  A293invFisico = P001K3_A293invFisico[0];
                  n293invFisico = P001K3_n293invFisico[0];
                  A309prdNombre = P001K3_A309prdNombre[0];
                  n309prdNombre = P001K3_n309prdNombre[0];
                  A217BodDsc = P001K3_A217BodDsc[0];
                  n217BodDsc = P001K3_n217BodDsc[0];
                  A288PrdPres = P001K3_A288PrdPres[0];
                  n288PrdPres = P001K3_n288PrdPres[0];
                  A309prdNombre = P001K3_A309prdNombre[0];
                  n309prdNombre = P001K3_n309prdNombre[0];
                  A217BodDsc = P001K3_A217BodDsc[0];
                  n217BodDsc = P001K3_n217BodDsc[0];
                  if ( A288PrdPres == 1 )
                  {
                     AV17presUni = "UNIDADES";
                  }
                  else if ( A288PrdPres == 2 )
                  {
                     AV17presUni = "LITROS";
                  }
                  else if ( A288PrdPres == 3 )
                  {
                     AV17presUni = "CAJA";
                  }
                  else if ( A288PrdPres == 4 )
                  {
                     AV17presUni = "BULTO";
                  }
                  else if ( A288PrdPres == 5 )
                  {
                     AV17presUni = "PACA";
                  }
                  else if ( A288PrdPres == 6 )
                  {
                     AV17presUni = "EMBALAJE";
                  }
                  else if ( A288PrdPres == 7 )
                  {
                     AV17presUni = "MTR. CUADRADO";
                  }
                  else if ( A288PrdPres == 8 )
                  {
                     AV17presUni = "GALON";
                  }
                  H1K0( false, 20) ;
                  getPrinter().GxDrawRect(0, Gx_line+0, 817, Gx_line+19, 0, 0, 0, 0, 1, 192, 192, 192, 0, 0, 0, 0, 0, 0, 0, 0) ;
                  getPrinter().GxDrawLine(6, Gx_line+18, 816, Gx_line+18, 1, 0, 0, 0, 0) ;
                  getPrinter().GxAttris("Qatar2022 Medium", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A286PrdCod), "ZZZ9")), 21, Gx_line+2, 68, Gx_line+17, 0, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A309prdNombre, "")), 92, Gx_line+2, 351, Gx_line+17, 0, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV17presUni, "")), 364, Gx_line+2, 487, Gx_line+17, 0, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( A293invFisico, "ZZ9.99")), 575, Gx_line+2, 620, Gx_line+17, 2+256, 0, 0, 1) ;
                  Gx_OldLine = Gx_line;
                  Gx_line = (int)(Gx_line+20);
                  H1K0( false, 24) ;
                  getPrinter().GxDrawLine(6, Gx_line+22, 816, Gx_line+22, 1, 0, 0, 0, 0) ;
                  getPrinter().GxAttris("Qatar2022 Medium", 9, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText("INGRESOS", 30, Gx_line+6, 103, Gx_line+21, 0+256, 0, 0, 0) ;
                  Gx_OldLine = Gx_line;
                  Gx_line = (int)(Gx_line+24);
                  AV23cantIng = 0;
                  AV36GXLvl49 = 0;
                  /* Using cursor P001K4 */
                  pr_default.execute(2, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod, AV21fdesde, AV22fHasta});
                  while ( (pr_default.getStatus(2) != 101) )
                  {
                     A387fchMovIng = P001K4_A387fchMovIng[0];
                     n387fchMovIng = P001K4_n387fchMovIng[0];
                     A390ingBodNroDoc = P001K4_A390ingBodNroDoc[0];
                     n390ingBodNroDoc = P001K4_n390ingBodNroDoc[0];
                     A184PrvDsc = P001K4_A184PrvDsc[0];
                     n184PrvDsc = P001K4_n184PrvDsc[0];
                     A37PrvRuc = P001K4_A37PrvRuc[0];
                     A386ingCantidad = P001K4_A386ingCantidad[0];
                     n386ingCantidad = P001K4_n386ingCantidad[0];
                     A383ingTipoInv = P001K4_A383ingTipoInv[0];
                     A389stockDetIngID = P001K4_A389stockDetIngID[0];
                     A184PrvDsc = P001K4_A184PrvDsc[0];
                     n184PrvDsc = P001K4_n184PrvDsc[0];
                     AV36GXLvl49 = 1;
                     H1K0( false, 19) ;
                     getPrinter().GxAttris("Qatar2022 Medium", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                     getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A383ingTipoInv, "")), 141, Gx_line+2, 188, Gx_line+17, 0+256, 0, 0, 1) ;
                     getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( A386ingCantidad, "ZZZZZ9.99")), 209, Gx_line+2, 276, Gx_line+17, 2+256, 0, 0, 1) ;
                     getPrinter().GxDrawText(context.localUtil.Format( A387fchMovIng, "99/99/9999"), 50, Gx_line+2, 118, Gx_line+17, 0, 0, 0, 1) ;
                     getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A37PrvRuc, "")), 302, Gx_line+2, 384, Gx_line+17, 0+256, 0, 0, 1) ;
                     getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A184PrvDsc, "")), 392, Gx_line+2, 664, Gx_line+17, 0, 0, 0, 1) ;
                     getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A390ingBodNroDoc), "ZZZ9")), 682, Gx_line+2, 712, Gx_line+17, 2+256, 0, 0, 1) ;
                     Gx_OldLine = Gx_line;
                     Gx_line = (int)(Gx_line+19);
                     AV23cantIng = (int)(AV23cantIng+A386ingCantidad);
                     AV26totIng = (int)(AV26totIng+A386ingCantidad);
                     pr_default.readNext(2);
                  }
                  pr_default.close(2);
                  if ( AV36GXLvl49 == 0 )
                  {
                     H1K0( false, 17) ;
                     getPrinter().GxAttris("Qatar2022 Medium", 9, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                     getPrinter().GxDrawText("Sin Movimientos", 60, Gx_line+1, 253, Gx_line+16, 0, 0, 0, 0) ;
                     Gx_OldLine = Gx_line;
                     Gx_line = (int)(Gx_line+17);
                  }
                  H1K0( false, 24) ;
                  getPrinter().GxDrawLine(4, Gx_line+21, 814, Gx_line+21, 1, 0, 0, 0, 0) ;
                  getPrinter().GxAttris("Qatar2022 Medium", 9, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText("EGRESOS", 28, Gx_line+5, 92, Gx_line+20, 0+256, 0, 0, 1) ;
                  Gx_OldLine = Gx_line;
                  Gx_line = (int)(Gx_line+24);
                  AV24cantEgr = 0;
                  AV37GXLvl61 = 0;
                  /* Using cursor P001K5 */
                  pr_default.execute(3, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod, AV21fdesde, AV22fHasta});
                  while ( (pr_default.getStatus(3) != 101) )
                  {
                     A374fchMovStock = P001K5_A374fchMovStock[0];
                     n374fchMovStock = P001K5_n374fchMovStock[0];
                     A351stockDetNroDoc = P001K5_A351stockDetNroDoc[0];
                     n351stockDetNroDoc = P001K5_n351stockDetNroDoc[0];
                     A57ClienteDsc = P001K5_A57ClienteDsc[0];
                     n57ClienteDsc = P001K5_n57ClienteDsc[0];
                     A5ClienteID = P001K5_A5ClienteID[0];
                     A296cantidad = P001K5_A296cantidad[0];
                     n296cantidad = P001K5_n296cantidad[0];
                     A43TipoInv = P001K5_A43TipoInv[0];
                     A348stockDetID = P001K5_A348stockDetID[0];
                     A57ClienteDsc = P001K5_A57ClienteDsc[0];
                     n57ClienteDsc = P001K5_n57ClienteDsc[0];
                     AV37GXLvl61 = 1;
                     H1K0( false, 17) ;
                     getPrinter().GxAttris("Qatar2022 Medium", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                     getPrinter().GxDrawText(context.localUtil.Format( A374fchMovStock, "99/99/9999"), 50, Gx_line+1, 120, Gx_line+16, 0+256, 0, 0, 1) ;
                     getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A43TipoInv, "")), 141, Gx_line+1, 188, Gx_line+16, 0+256, 0, 0, 1) ;
                     getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( A296cantidad, "ZZZ.ZZ9.99")), 215, Gx_line+1, 289, Gx_line+16, 2+256, 0, 0, 1) ;
                     getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A5ClienteID), "ZZZ9")), 302, Gx_line+1, 332, Gx_line+16, 0+256, 0, 0, 1) ;
                     getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A57ClienteDsc, "")), 344, Gx_line+1, 658, Gx_line+16, 0+256, 0, 0, 1) ;
                     getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A351stockDetNroDoc), "ZZZ9")), 682, Gx_line+2, 712, Gx_line+17, 2+256, 0, 0, 1) ;
                     Gx_OldLine = Gx_line;
                     Gx_line = (int)(Gx_line+17);
                     AV24cantEgr = (int)(AV24cantEgr+A296cantidad);
                     AV27TotEgr = (int)(AV27TotEgr+A296cantidad);
                     pr_default.readNext(3);
                  }
                  pr_default.close(3);
                  if ( AV37GXLvl61 == 0 )
                  {
                     H1K0( false, 17) ;
                     getPrinter().GxAttris("Qatar2022 Medium", 9, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                     getPrinter().GxDrawText("Sin Movimientos", 60, Gx_line+1, 253, Gx_line+16, 0, 0, 0, 0) ;
                     Gx_OldLine = Gx_line;
                     Gx_line = (int)(Gx_line+17);
                  }
                  pr_default.readNext(1);
               }
               pr_default.close(1);
               GxHdr3 = false;
               H1K0( false, 109) ;
               getPrinter().GxDrawLine(6, Gx_line+0, 816, Gx_line+0, 1, 0, 0, 0, 0) ;
               getPrinter().GxDrawRect(36, Gx_line+30, 271, Gx_line+99, 1, 196, 196, 196, 0, 255, 255, 255, 0, 0, 0, 0, 8, 8, 8, 8) ;
               getPrinter().GxAttris("Qatar2022 Medium", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(AV26totIng), "ZZZZZZZ9")), 165, Gx_line+41, 216, Gx_line+56, 2, 0, 0, 0) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(AV27TotEgr), "ZZZZZZZ9")), 165, Gx_line+70, 216, Gx_line+85, 2, 0, 0, 0) ;
               getPrinter().GxAttris("Qatar2022 Medium", 9, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Total Egresos: ", 47, Gx_line+70, 148, Gx_line+85, 0+256, 0, 0, 0) ;
               getPrinter().GxDrawText("Resumen", 38, Gx_line+9, 102, Gx_line+24, 0+256, 0, 0, 0) ;
               getPrinter().GxDrawText("Total Ingresos: ", 47, Gx_line+41, 155, Gx_line+56, 0+256, 0, 0, 0) ;
               Gx_OldLine = Gx_line;
               Gx_line = (int)(Gx_line+109);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1);
            H1K0( true, 0) ;
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

      protected void S111( )
      {
         /* 'USERNAME' Routine */
         /* Using cursor P001K6 */
         pr_default.execute(4, new Object[] {AV14usuCod});
         while ( (pr_default.getStatus(4) != 101) )
         {
            A3UsuCod = P001K6_A3UsuCod[0];
            A50UsuName = P001K6_A50UsuName[0];
            n50UsuName = P001K6_n50UsuName[0];
            AV25usuName = A50UsuName;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(4);
      }

      protected void H1K0( bool bFoot ,
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
               if ( GxHdr3 )
               {
                  if ( ! (0==AV12BodCod) )
                  {
                     AV15BodDsc = A217BodDsc;
                  }
                  else
                  {
                     AV15BodDsc = "Todas las Bodegas";
                  }
                  getPrinter().GxDrawRect(0, Gx_line+78, 149, Gx_line+119, 0, 0, 0, 0, 1, 192, 192, 192, 0, 0, 0, 0, 0, 0, 0, 0) ;
                  getPrinter().GxDrawRect(148, Gx_line+0, 817, Gx_line+119, 0, 0, 0, 0, 1, 192, 192, 192, 0, 0, 0, 0, 0, 0, 0, 0) ;
                  getPrinter().GxDrawLine(0, Gx_line+88, 817, Gx_line+88, 1, 0, 0, 0, 0) ;
                  getPrinter().GxDrawLine(6, Gx_line+148, 816, Gx_line+148, 1, 0, 0, 0, 0) ;
                  sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV16logo)) ? AV31Logo_GXI : AV16logo);
                  getPrinter().GxDrawBitMap(sImgUrl, 7, Gx_line+5, 140, Gx_line+76) ;
                  getPrinter().GxAttris("Qatar2022 Medium", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV25usuName, "")), 699, Gx_line+57, 802, Gx_line+73, 0, 0, 0, 0) ;
                  getPrinter().GxAttris("Qatar2022 Medium", 9, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText("Codigo", 21, Gx_line+133, 68, Gx_line+148, 0+256, 0, 0, 0) ;
                  getPrinter().GxDrawText("Producto", 92, Gx_line+133, 163, Gx_line+148, 0, 0, 0, 0) ;
                  getPrinter().GxDrawText("Unidades", 364, Gx_line+133, 429, Gx_line+148, 0+256, 0, 0, 0) ;
                  getPrinter().GxAttris("Qatar2022 Medium", 10, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV15BodDsc, "@!")), 151, Gx_line+60, 444, Gx_line+78, 0+256, 0, 0, 0) ;
                  getPrinter().GxAttris("Qatar2022 Medium", 12, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A46AgeDsc, "")), 151, Gx_line+36, 386, Gx_line+57, 0, 0, 0, 0) ;
                  getPrinter().GxAttris("Qatar2022 Medium", 16, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!")), 151, Gx_line+5, 609, Gx_line+33, 0, 0, 0, 0) ;
                  getPrinter().GxAttris("Times New Roman", 8, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText("Página:", 699, Gx_line+39, 742, Gx_line+53, 0+256, 0, 0, 0) ;
                  getPrinter().GxDrawText("Hora:", 699, Gx_line+22, 731, Gx_line+36, 0+256, 0, 0, 0) ;
                  getPrinter().GxDrawText("Fecha:", 699, Gx_line+5, 735, Gx_line+19, 0+256, 0, 0, 0) ;
                  getPrinter().GxAttris("Times New Roman", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(Gx_page), "ZZZZZ9")), 764, Gx_line+38, 808, Gx_line+54, 2, 0, 0, 0) ;
                  getPrinter().GxAttris("Times New Roman", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(context.localUtil.Format( Gx_date, "99/99/99"), 762, Gx_line+5, 807, Gx_line+22, 2+256, 0, 0, 0) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( Gx_time, "")), 764, Gx_line+21, 808, Gx_line+37, 2, 0, 0, 0) ;
                  getPrinter().GxAttris("Verdana", 11, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText("Resumen de Stock", 332, Gx_line+96, 492, Gx_line+115, 0+256, 0, 0, 0) ;
                  Gx_OldLine = Gx_line;
                  Gx_line = (int)(Gx_line+150);
               }
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
         add_metrics2( ) ;
         add_metrics3( ) ;
         add_metrics4( ) ;
      }

      protected void add_metrics0( )
      {
         getPrinter().setMetrics("Qatar2022 Medium", false, false, 58, 14, 72, 171,  new int[] {48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 18, 20, 23, 36, 36, 57, 43, 12, 21, 21, 25, 37, 18, 21, 18, 18, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 18, 18, 37, 37, 37, 36, 65, 43, 43, 46, 46, 43, 39, 50, 46, 18, 32, 43, 36, 53, 46, 50, 43, 50, 46, 43, 40, 46, 43, 64, 41, 42, 39, 18, 18, 18, 27, 36, 21, 36, 36, 32, 36, 36, 18, 36, 36, 14, 15, 33, 14, 55, 36, 36, 36, 36, 21, 32, 18, 36, 33, 47, 31, 31, 31, 21, 17, 21, 37, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 18, 20, 36, 36, 36, 36, 17, 36, 21, 47, 24, 36, 37, 21, 47, 35, 26, 35, 21, 21, 21, 37, 34, 21, 21, 21, 23, 36, 53, 53, 53, 39, 43, 43, 43, 43, 43, 43, 64, 46, 43, 43, 43, 43, 18, 18, 18, 18, 46, 46, 50, 50, 50, 50, 50, 37, 50, 46, 46, 46, 46, 43, 43, 39, 36, 36, 36, 36, 36, 36, 57, 32, 36, 36, 36, 36, 18, 18, 18, 18, 36, 36, 36, 36, 36, 36, 36, 35, 39, 36, 36, 36, 36, 32, 36, 32}) ;
      }

      protected void add_metrics1( )
      {
         getPrinter().setMetrics("Qatar2022 Medium", true, false, 57, 15, 72, 163,  new int[] {47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 17, 19, 29, 34, 34, 55, 45, 15, 21, 21, 24, 36, 17, 21, 17, 17, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 21, 21, 36, 36, 36, 38, 60, 43, 45, 45, 45, 41, 38, 48, 45, 17, 34, 45, 38, 53, 45, 48, 41, 48, 45, 41, 38, 45, 41, 57, 41, 41, 38, 21, 17, 21, 36, 34, 21, 34, 38, 34, 38, 34, 21, 38, 38, 17, 17, 34, 17, 55, 38, 38, 38, 38, 24, 34, 21, 38, 33, 49, 34, 34, 31, 24, 17, 24, 36, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 17, 21, 34, 34, 34, 34, 17, 34, 21, 46, 23, 34, 36, 21, 46, 34, 25, 34, 21, 21, 21, 36, 34, 21, 20, 21, 23, 34, 52, 52, 52, 38, 45, 45, 45, 45, 45, 45, 62, 45, 41, 41, 41, 41, 17, 17, 17, 17, 45, 45, 48, 48, 48, 48, 48, 36, 48, 45, 45, 45, 45, 41, 41, 38, 34, 34, 34, 34, 34, 34, 55, 34, 34, 34, 34, 34, 17, 17, 17, 17, 38, 38, 38, 38, 38, 38, 38, 34, 38, 38, 38, 38, 38, 34, 38, 34}) ;
      }

      protected void add_metrics2( )
      {
         getPrinter().setMetrics("Times New Roman", true, false, 57, 15, 72, 163,  new int[] {47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 17, 19, 29, 34, 34, 55, 45, 15, 21, 21, 24, 36, 17, 21, 17, 17, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 21, 21, 36, 36, 36, 38, 60, 43, 45, 45, 45, 41, 38, 48, 45, 17, 34, 45, 38, 53, 45, 48, 41, 48, 45, 41, 38, 45, 41, 57, 41, 41, 38, 21, 17, 21, 36, 34, 21, 34, 38, 34, 38, 34, 21, 38, 38, 17, 17, 34, 17, 55, 38, 38, 38, 38, 24, 34, 21, 38, 33, 49, 34, 34, 31, 24, 17, 24, 36, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 17, 21, 34, 34, 34, 34, 17, 34, 21, 46, 23, 34, 36, 21, 46, 34, 25, 34, 21, 21, 21, 36, 34, 21, 20, 21, 23, 34, 52, 52, 52, 38, 45, 45, 45, 45, 45, 45, 62, 45, 41, 41, 41, 41, 17, 17, 17, 17, 45, 45, 48, 48, 48, 48, 48, 36, 48, 45, 45, 45, 45, 41, 41, 38, 34, 34, 34, 34, 34, 34, 55, 34, 34, 34, 34, 34, 17, 17, 17, 17, 38, 38, 38, 38, 38, 38, 38, 34, 38, 38, 38, 38, 38, 34, 38, 34}) ;
      }

      protected void add_metrics3( )
      {
         getPrinter().setMetrics("Times New Roman", false, false, 58, 14, 72, 171,  new int[] {48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 18, 20, 23, 36, 36, 57, 43, 12, 21, 21, 25, 37, 18, 21, 18, 18, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 18, 18, 37, 37, 37, 36, 65, 43, 43, 46, 46, 43, 39, 50, 46, 18, 32, 43, 36, 53, 46, 50, 43, 50, 46, 43, 40, 46, 43, 64, 41, 42, 39, 18, 18, 18, 27, 36, 21, 36, 36, 32, 36, 36, 18, 36, 36, 14, 15, 33, 14, 55, 36, 36, 36, 36, 21, 32, 18, 36, 33, 47, 31, 31, 31, 21, 17, 21, 37, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 18, 20, 36, 36, 36, 36, 17, 36, 21, 47, 24, 36, 37, 21, 47, 35, 26, 35, 21, 21, 21, 37, 34, 21, 21, 21, 23, 36, 53, 53, 53, 39, 43, 43, 43, 43, 43, 43, 64, 46, 43, 43, 43, 43, 18, 18, 18, 18, 46, 46, 50, 50, 50, 50, 50, 37, 50, 46, 46, 46, 46, 43, 43, 39, 36, 36, 36, 36, 36, 36, 57, 32, 36, 36, 36, 36, 18, 18, 18, 18, 36, 36, 36, 36, 36, 36, 36, 35, 39, 36, 36, 36, 36, 32, 36, 32}) ;
      }

      protected void add_metrics4( )
      {
         getPrinter().setMetrics("Verdana", true, false, 57, 15, 72, 163,  new int[] {47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 17, 19, 29, 34, 34, 55, 45, 15, 21, 21, 24, 36, 17, 21, 17, 17, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 21, 21, 36, 36, 36, 38, 60, 43, 45, 45, 45, 41, 38, 48, 45, 17, 34, 45, 38, 53, 45, 48, 41, 48, 45, 41, 38, 45, 41, 57, 41, 41, 38, 21, 17, 21, 36, 34, 21, 34, 38, 34, 38, 34, 21, 38, 38, 17, 17, 34, 17, 55, 38, 38, 38, 38, 24, 34, 21, 38, 33, 49, 34, 34, 31, 24, 17, 24, 36, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 17, 21, 34, 34, 34, 34, 17, 34, 21, 46, 23, 34, 36, 21, 46, 34, 25, 34, 21, 21, 21, 36, 34, 21, 20, 21, 23, 34, 52, 52, 52, 38, 45, 45, 45, 45, 45, 45, 62, 45, 41, 41, 41, 41, 17, 17, 17, 17, 45, 45, 48, 48, 48, 48, 48, 36, 48, 45, 45, 45, 45, 41, 41, 38, 34, 34, 34, 34, 34, 34, 55, 34, 34, 34, 34, 34, 17, 17, 17, 17, 38, 38, 38, 38, 38, 38, 38, 34, 38, 38, 38, 38, 38, 34, 38, 34}) ;
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
         P001K2_A2AgeID = new short[1] ;
         P001K2_A1EmpID = new short[1] ;
         P001K2_A46AgeDsc = new String[] {""} ;
         P001K2_n46AgeDsc = new bool[] {false} ;
         P001K2_A44empdsc = new String[] {""} ;
         P001K2_n44empdsc = new bool[] {false} ;
         P001K2_A97emplogo = new String[] {""} ;
         P001K2_n97emplogo = new bool[] {false} ;
         A46AgeDsc = "";
         A44empdsc = "";
         A97emplogo = "";
         AV16logo = "";
         AV31Logo_GXI = "";
         P001K3_A1EmpID = new short[1] ;
         P001K3_A2AgeID = new short[1] ;
         P001K3_A286PrdCod = new short[1] ;
         P001K3_A42BodCod = new short[1] ;
         P001K3_A291stockMes = new short[1] ;
         P001K3_A290stockAnio = new short[1] ;
         P001K3_A288PrdPres = new short[1] ;
         P001K3_n288PrdPres = new bool[] {false} ;
         P001K3_A293invFisico = new decimal[1] ;
         P001K3_n293invFisico = new bool[] {false} ;
         P001K3_A309prdNombre = new String[] {""} ;
         P001K3_n309prdNombre = new bool[] {false} ;
         P001K3_A217BodDsc = new String[] {""} ;
         P001K3_n217BodDsc = new bool[] {false} ;
         A309prdNombre = "";
         A217BodDsc = "";
         AV17presUni = "";
         P001K4_A290stockAnio = new short[1] ;
         P001K4_A291stockMes = new short[1] ;
         P001K4_A1EmpID = new short[1] ;
         P001K4_A2AgeID = new short[1] ;
         P001K4_A42BodCod = new short[1] ;
         P001K4_A286PrdCod = new short[1] ;
         P001K4_A387fchMovIng = new DateTime[] {DateTime.MinValue} ;
         P001K4_n387fchMovIng = new bool[] {false} ;
         P001K4_A390ingBodNroDoc = new short[1] ;
         P001K4_n390ingBodNroDoc = new bool[] {false} ;
         P001K4_A184PrvDsc = new String[] {""} ;
         P001K4_n184PrvDsc = new bool[] {false} ;
         P001K4_A37PrvRuc = new String[] {""} ;
         P001K4_A386ingCantidad = new decimal[1] ;
         P001K4_n386ingCantidad = new bool[] {false} ;
         P001K4_A383ingTipoInv = new String[] {""} ;
         P001K4_A389stockDetIngID = new short[1] ;
         A387fchMovIng = DateTime.MinValue;
         A184PrvDsc = "";
         A37PrvRuc = "";
         A383ingTipoInv = "";
         P001K5_A290stockAnio = new short[1] ;
         P001K5_A291stockMes = new short[1] ;
         P001K5_A1EmpID = new short[1] ;
         P001K5_A2AgeID = new short[1] ;
         P001K5_A42BodCod = new short[1] ;
         P001K5_A286PrdCod = new short[1] ;
         P001K5_A374fchMovStock = new DateTime[] {DateTime.MinValue} ;
         P001K5_n374fchMovStock = new bool[] {false} ;
         P001K5_A351stockDetNroDoc = new short[1] ;
         P001K5_n351stockDetNroDoc = new bool[] {false} ;
         P001K5_A57ClienteDsc = new String[] {""} ;
         P001K5_n57ClienteDsc = new bool[] {false} ;
         P001K5_A5ClienteID = new short[1] ;
         P001K5_A296cantidad = new decimal[1] ;
         P001K5_n296cantidad = new bool[] {false} ;
         P001K5_A43TipoInv = new String[] {""} ;
         P001K5_A348stockDetID = new short[1] ;
         A374fchMovStock = DateTime.MinValue;
         A57ClienteDsc = "";
         A43TipoInv = "";
         P001K6_A3UsuCod = new String[] {""} ;
         P001K6_A50UsuName = new String[] {""} ;
         P001K6_n50UsuName = new bool[] {false} ;
         A3UsuCod = "";
         A50UsuName = "";
         AV25usuName = "";
         AV15BodDsc = "";
         AV16logo = "";
         sImgUrl = "";
         Gx_date = DateTime.MinValue;
         Gx_time = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.apdfstockbodega__default(),
            new Object[][] {
                new Object[] {
               P001K2_A2AgeID, P001K2_A1EmpID, P001K2_A46AgeDsc, P001K2_n46AgeDsc, P001K2_A44empdsc, P001K2_n44empdsc, P001K2_A97emplogo, P001K2_n97emplogo
               }
               , new Object[] {
               P001K3_A1EmpID, P001K3_A2AgeID, P001K3_A286PrdCod, P001K3_A42BodCod, P001K3_A291stockMes, P001K3_A290stockAnio, P001K3_A288PrdPres, P001K3_n288PrdPres, P001K3_A293invFisico, P001K3_n293invFisico,
               P001K3_A309prdNombre, P001K3_n309prdNombre, P001K3_A217BodDsc, P001K3_n217BodDsc
               }
               , new Object[] {
               P001K4_A290stockAnio, P001K4_A291stockMes, P001K4_A1EmpID, P001K4_A2AgeID, P001K4_A42BodCod, P001K4_A286PrdCod, P001K4_A387fchMovIng, P001K4_n387fchMovIng, P001K4_A390ingBodNroDoc, P001K4_n390ingBodNroDoc,
               P001K4_A184PrvDsc, P001K4_n184PrvDsc, P001K4_A37PrvRuc, P001K4_A386ingCantidad, P001K4_n386ingCantidad, P001K4_A383ingTipoInv, P001K4_A389stockDetIngID
               }
               , new Object[] {
               P001K5_A290stockAnio, P001K5_A291stockMes, P001K5_A1EmpID, P001K5_A2AgeID, P001K5_A42BodCod, P001K5_A286PrdCod, P001K5_A374fchMovStock, P001K5_n374fchMovStock, P001K5_A351stockDetNroDoc, P001K5_n351stockDetNroDoc,
               P001K5_A57ClienteDsc, P001K5_n57ClienteDsc, P001K5_A5ClienteID, P001K5_A296cantidad, P001K5_n296cantidad, P001K5_A43TipoInv, P001K5_A348stockDetID
               }
               , new Object[] {
               P001K6_A3UsuCod, P001K6_A50UsuName, P001K6_n50UsuName
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
      private short AV10EmpID ;
      private short AV11AgeID ;
      private short AV12BodCod ;
      private short AV13prdCod ;
      private short GxWebError ;
      private short A2AgeID ;
      private short A1EmpID ;
      private short A42BodCod ;
      private short A286PrdCod ;
      private short A291stockMes ;
      private short A290stockAnio ;
      private short A288PrdPres ;
      private short AV36GXLvl49 ;
      private short A390ingBodNroDoc ;
      private short A389stockDetIngID ;
      private short AV37GXLvl61 ;
      private short A351stockDetNroDoc ;
      private short A5ClienteID ;
      private short A348stockDetID ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int AV26totIng ;
      private int AV27TotEgr ;
      private int Gx_OldLine ;
      private int AV23cantIng ;
      private int AV24cantEgr ;
      private decimal A293invFisico ;
      private decimal A386ingCantidad ;
      private decimal A296cantidad ;
      private String GXKey ;
      private String gxfirstwebparm ;
      private String AV14usuCod ;
      private String scmdbuf ;
      private String A46AgeDsc ;
      private String A97emplogo ;
      private String A217BodDsc ;
      private String A37PrvRuc ;
      private String A383ingTipoInv ;
      private String A57ClienteDsc ;
      private String A43TipoInv ;
      private String A3UsuCod ;
      private String AV15BodDsc ;
      private String sImgUrl ;
      private String Gx_time ;
      private DateTime AV21fdesde ;
      private DateTime AV22fHasta ;
      private DateTime A387fchMovIng ;
      private DateTime A374fchMovStock ;
      private DateTime Gx_date ;
      private bool entryPointCalled ;
      private bool returnInSub ;
      private bool n46AgeDsc ;
      private bool n44empdsc ;
      private bool n97emplogo ;
      private bool GxHdr3 ;
      private bool n288PrdPres ;
      private bool n293invFisico ;
      private bool n309prdNombre ;
      private bool n217BodDsc ;
      private bool n387fchMovIng ;
      private bool n390ingBodNroDoc ;
      private bool n184PrvDsc ;
      private bool n386ingCantidad ;
      private bool n374fchMovStock ;
      private bool n351stockDetNroDoc ;
      private bool n57ClienteDsc ;
      private bool n296cantidad ;
      private bool n50UsuName ;
      private String A44empdsc ;
      private String AV31Logo_GXI ;
      private String A309prdNombre ;
      private String AV17presUni ;
      private String A184PrvDsc ;
      private String A50UsuName ;
      private String AV25usuName ;
      private String AV16logo ;
      private String Logo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P001K2_A2AgeID ;
      private short[] P001K2_A1EmpID ;
      private String[] P001K2_A46AgeDsc ;
      private bool[] P001K2_n46AgeDsc ;
      private String[] P001K2_A44empdsc ;
      private bool[] P001K2_n44empdsc ;
      private String[] P001K2_A97emplogo ;
      private bool[] P001K2_n97emplogo ;
      private short[] P001K3_A1EmpID ;
      private short[] P001K3_A2AgeID ;
      private short[] P001K3_A286PrdCod ;
      private short[] P001K3_A42BodCod ;
      private short[] P001K3_A291stockMes ;
      private short[] P001K3_A290stockAnio ;
      private short[] P001K3_A288PrdPres ;
      private bool[] P001K3_n288PrdPres ;
      private decimal[] P001K3_A293invFisico ;
      private bool[] P001K3_n293invFisico ;
      private String[] P001K3_A309prdNombre ;
      private bool[] P001K3_n309prdNombre ;
      private String[] P001K3_A217BodDsc ;
      private bool[] P001K3_n217BodDsc ;
      private short[] P001K4_A290stockAnio ;
      private short[] P001K4_A291stockMes ;
      private short[] P001K4_A1EmpID ;
      private short[] P001K4_A2AgeID ;
      private short[] P001K4_A42BodCod ;
      private short[] P001K4_A286PrdCod ;
      private DateTime[] P001K4_A387fchMovIng ;
      private bool[] P001K4_n387fchMovIng ;
      private short[] P001K4_A390ingBodNroDoc ;
      private bool[] P001K4_n390ingBodNroDoc ;
      private String[] P001K4_A184PrvDsc ;
      private bool[] P001K4_n184PrvDsc ;
      private String[] P001K4_A37PrvRuc ;
      private decimal[] P001K4_A386ingCantidad ;
      private bool[] P001K4_n386ingCantidad ;
      private String[] P001K4_A383ingTipoInv ;
      private short[] P001K4_A389stockDetIngID ;
      private short[] P001K5_A290stockAnio ;
      private short[] P001K5_A291stockMes ;
      private short[] P001K5_A1EmpID ;
      private short[] P001K5_A2AgeID ;
      private short[] P001K5_A42BodCod ;
      private short[] P001K5_A286PrdCod ;
      private DateTime[] P001K5_A374fchMovStock ;
      private bool[] P001K5_n374fchMovStock ;
      private short[] P001K5_A351stockDetNroDoc ;
      private bool[] P001K5_n351stockDetNroDoc ;
      private String[] P001K5_A57ClienteDsc ;
      private bool[] P001K5_n57ClienteDsc ;
      private short[] P001K5_A5ClienteID ;
      private decimal[] P001K5_A296cantidad ;
      private bool[] P001K5_n296cantidad ;
      private String[] P001K5_A43TipoInv ;
      private short[] P001K5_A348stockDetID ;
      private String[] P001K6_A3UsuCod ;
      private String[] P001K6_A50UsuName ;
      private bool[] P001K6_n50UsuName ;
   }

   public class apdfstockbodega__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P001K3( IGxContext context ,
                                             short AV12BodCod ,
                                             short AV13prdCod ,
                                             short A42BodCod ,
                                             short A286PrdCod ,
                                             short A1EmpID ,
                                             short A2AgeID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [4] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         scmdbuf = "SELECT T1.[EmpID], T1.[AgeID], T1.[PrdCod], T1.[BodCod], T1.[stockMes], T1.[stockAnio], T2.[PrdPres], T1.[invFisico], T2.[prdNombre], T3.[BodDsc] FROM (([ProdxBodega] T1 WITH (NOLOCK) INNER JOIN [Productos] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[AgeID] = T1.[AgeID] AND T2.[PrdCod] = T1.[PrdCod]) INNER JOIN [Bodegas] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[BodCod] = T1.[BodCod])";
         scmdbuf = scmdbuf + " WHERE (T1.[EmpID] = @EmpID)";
         scmdbuf = scmdbuf + " and (T1.[AgeID] = @AgeID)";
         if ( ! (0==AV12BodCod) )
         {
            sWhereString = sWhereString + " and (T1.[BodCod] = @AV12BodCod)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (0==AV13prdCod) )
         {
            sWhereString = sWhereString + " and (T1.[PrdCod] = @AV13prdCod)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY T1.[stockAnio], T1.[stockMes], T1.[EmpID], T1.[AgeID], T1.[PrdCod]";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 1 :
                     return conditional_P001K3(context, (short)dynConstraints[0] , (short)dynConstraints[1] , (short)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (short)dynConstraints[5] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

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
          Object[] prmP001K2 ;
          prmP001K2 = new Object[] {
          new Object[] {"@AV10EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11AgeID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001K4 ;
          prmP001K4 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV21fdesde",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV22fHasta",SqlDbType.DateTime,8,0}
          } ;
          Object[] prmP001K5 ;
          prmP001K5 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV21fdesde",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV22fHasta",SqlDbType.DateTime,8,0}
          } ;
          Object[] prmP001K6 ;
          prmP001K6 = new Object[] {
          new Object[] {"@AV14usuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmP001K3 ;
          prmP001K3 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV13prdCod",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001K2", "SELECT T1.[AgeID], T1.[EmpID], T1.[AgeDsc], T2.[empdsc], T2.[emplogo] FROM ([Agencias] T1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID]) WHERE T1.[EmpID] = @AV10EmpID and T1.[AgeID] = @AV11AgeID ORDER BY T1.[EmpID], T1.[AgeID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001K2,1,0,true,true )
             ,new CursorDef("P001K3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001K3,100,0,true,false )
             ,new CursorDef("P001K4", "SELECT T1.[stockAnio], T1.[stockMes], T1.[EmpID], T1.[AgeID], T1.[BodCod], T1.[PrdCod], T1.[fchMovIng], T1.[ingBodNroDoc], T2.[PrvDsc], T1.[PrvRuc], T1.[ingCantidad], T1.[ingTipoInv], T1.[stockDetIngID] FROM ([ProdStockBodegastockDetEgr] T1 WITH (NOLOCK) INNER JOIN [Proveedor] T2 WITH (NOLOCK) ON T2.[PrvRuc] = T1.[PrvRuc]) WHERE (T1.[stockAnio] = @stockAnio and T1.[stockMes] = @stockMes and T1.[EmpID] = @EmpID and T1.[AgeID] = @AgeID and T1.[BodCod] = @BodCod and T1.[PrdCod] = @PrdCod) AND (T1.[fchMovIng] >= @AV21fdesde and T1.[fchMovIng] <= @AV22fHasta) ORDER BY T1.[stockAnio], T1.[stockMes], T1.[EmpID], T1.[AgeID], T1.[BodCod], T1.[PrdCod] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001K4,100,0,false,false )
             ,new CursorDef("P001K5", "SELECT T1.[stockAnio], T1.[stockMes], T1.[EmpID], T1.[AgeID], T1.[BodCod], T1.[PrdCod], T1.[fchMovStock], T1.[stockDetNroDoc], T2.[ClienteDsc], T1.[ClienteID], T1.[cantidad], T1.[TipoInv], T1.[stockDetID] FROM ([ProdxBodegaTipoInv] T1 WITH (NOLOCK) INNER JOIN [Clientes] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[ClienteID] = T1.[ClienteID]) WHERE (T1.[stockAnio] = @stockAnio and T1.[stockMes] = @stockMes and T1.[EmpID] = @EmpID and T1.[AgeID] = @AgeID and T1.[BodCod] = @BodCod and T1.[PrdCod] = @PrdCod) AND (T1.[fchMovStock] >= @AV21fdesde and T1.[fchMovStock] <= @AV22fHasta) ORDER BY T1.[stockAnio], T1.[stockMes], T1.[EmpID], T1.[AgeID], T1.[BodCod], T1.[PrdCod] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001K5,100,0,false,false )
             ,new CursorDef("P001K6", "SELECT TOP 1 [UsuCod], [UsuName] FROM [Usuarios] WITH (NOLOCK) WHERE [UsuCod] = @AV14usuCod ORDER BY [UsuCod] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001K6,1,0,false,true )
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
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getString(5, 80) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                ((decimal[]) buf[8])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((String[]) buf[10])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((String[]) buf[12])[0] = rslt.getString(10, 40) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                ((short[]) buf[8])[0] = rslt.getShort(8) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((String[]) buf[10])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((String[]) buf[12])[0] = rslt.getString(10, 13) ;
                ((decimal[]) buf[13])[0] = rslt.getDecimal(11) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(11);
                ((String[]) buf[15])[0] = rslt.getString(12, 4) ;
                ((short[]) buf[16])[0] = rslt.getShort(13) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                ((short[]) buf[8])[0] = rslt.getShort(8) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((String[]) buf[10])[0] = rslt.getString(9, 50) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((short[]) buf[12])[0] = rslt.getShort(10) ;
                ((decimal[]) buf[13])[0] = rslt.getDecimal(11) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(11);
                ((String[]) buf[15])[0] = rslt.getString(12, 4) ;
                ((short[]) buf[16])[0] = rslt.getShort(13) ;
                return;
             case 4 :
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
       short sIdx ;
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[4]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[5]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[6]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[7]);
                }
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (DateTime)parms[6]);
                stmt.SetParameter(8, (DateTime)parms[7]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (DateTime)parms[6]);
                stmt.SetParameter(8, (DateTime)parms[7]);
                return;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
       }
    }

 }

}
