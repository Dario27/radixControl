/*
               File: pdfStockBodegaResumen
        Description: pdf Stock Bodega Resumen
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/9/2023 12:19:46.38
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
   public class apdfstockbodegaresumen : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
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
               AV15fdesde = context.localUtil.ParseDateParm( gxfirstwebparm);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV16fHasta = context.localUtil.ParseDateParm( GetNextPar( ));
                  AV14EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV8AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV9BodCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV19prdCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV24usuCod = GetNextPar( );
               }
            }
         }
         if ( GxWebError == 0 )
         {
            executePrivate();
         }
         cleanup();
      }

      public apdfstockbodegaresumen( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public apdfstockbodegaresumen( IGxContext context )
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
         this.AV15fdesde = aP0_fdesde;
         this.AV16fHasta = aP1_fHasta;
         this.AV14EmpID = aP2_EmpID;
         this.AV8AgeID = aP3_AgeID;
         this.AV9BodCod = aP4_BodCod;
         this.AV19prdCod = aP5_prdCod;
         this.AV24usuCod = aP6_usuCod;
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
         apdfstockbodegaresumen objapdfstockbodegaresumen;
         objapdfstockbodegaresumen = new apdfstockbodegaresumen();
         objapdfstockbodegaresumen.AV15fdesde = aP0_fdesde;
         objapdfstockbodegaresumen.AV16fHasta = aP1_fHasta;
         objapdfstockbodegaresumen.AV14EmpID = aP2_EmpID;
         objapdfstockbodegaresumen.AV8AgeID = aP3_AgeID;
         objapdfstockbodegaresumen.AV9BodCod = aP4_BodCod;
         objapdfstockbodegaresumen.AV19prdCod = aP5_prdCod;
         objapdfstockbodegaresumen.AV24usuCod = aP6_usuCod;
         objapdfstockbodegaresumen.context.SetSubmitInitialConfig(context);
         objapdfstockbodegaresumen.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objapdfstockbodegaresumen);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((apdfstockbodegaresumen)stateInfo).executePrivate();
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
            if (!initPrinter (Gx_out, gxXPage, gxYPage, "GXPRN.INI", "", "", 2, 1, 256, 16834, 11909, 0, 1, 1, 0, 1, 1) )
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
            /* Using cursor P001L2 */
            pr_default.execute(0, new Object[] {AV14EmpID, AV8AgeID});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A2AgeID = P001L2_A2AgeID[0];
               A1EmpID = P001L2_A1EmpID[0];
               A46AgeDsc = P001L2_A46AgeDsc[0];
               n46AgeDsc = P001L2_n46AgeDsc[0];
               A44empdsc = P001L2_A44empdsc[0];
               n44empdsc = P001L2_n44empdsc[0];
               A97emplogo = P001L2_A97emplogo[0];
               n97emplogo = P001L2_n97emplogo[0];
               A44empdsc = P001L2_A44empdsc[0];
               n44empdsc = P001L2_n44empdsc[0];
               A97emplogo = P001L2_A97emplogo[0];
               n97emplogo = P001L2_n97emplogo[0];
               AV18logo = StringUtil.Trim( A97emplogo);
               AV35Logo_GXI = GXDbFile.PathToUrl( StringUtil.Trim( A97emplogo));
               AV26totIng = 0;
               AV27TotEgr = 0;
               AV31total = 0;
               GxHdr3 = true;
               pr_default.dynParam(1, new Object[]{ new Object[]{
                                                    AV9BodCod ,
                                                    AV19prdCod ,
                                                    A42BodCod ,
                                                    A286PrdCod ,
                                                    A1EmpID ,
                                                    A2AgeID } ,
                                                    new int[]{
                                                    TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT
                                                    }
               } ) ;
               /* Using cursor P001L3 */
               pr_default.execute(1, new Object[] {A1EmpID, A2AgeID, AV9BodCod, AV19prdCod});
               while ( (pr_default.getStatus(1) != 101) )
               {
                  A286PrdCod = P001L3_A286PrdCod[0];
                  A42BodCod = P001L3_A42BodCod[0];
                  A288PrdPres = P001L3_A288PrdPres[0];
                  n288PrdPres = P001L3_n288PrdPres[0];
                  A293invFisico = P001L3_A293invFisico[0];
                  n293invFisico = P001L3_n293invFisico[0];
                  A309prdNombre = P001L3_A309prdNombre[0];
                  n309prdNombre = P001L3_n309prdNombre[0];
                  A291stockMes = P001L3_A291stockMes[0];
                  A290stockAnio = P001L3_A290stockAnio[0];
                  A217BodDsc = P001L3_A217BodDsc[0];
                  n217BodDsc = P001L3_n217BodDsc[0];
                  A288PrdPres = P001L3_A288PrdPres[0];
                  n288PrdPres = P001L3_n288PrdPres[0];
                  A309prdNombre = P001L3_A309prdNombre[0];
                  n309prdNombre = P001L3_n309prdNombre[0];
                  A217BodDsc = P001L3_A217BodDsc[0];
                  n217BodDsc = P001L3_n217BodDsc[0];
                  if ( A288PrdPres == 1 )
                  {
                     AV20presUni = "UNIDADES";
                  }
                  else if ( A288PrdPres == 2 )
                  {
                     AV20presUni = "LITROS";
                  }
                  else if ( A288PrdPres == 3 )
                  {
                     AV20presUni = "CAJA";
                  }
                  else if ( A288PrdPres == 4 )
                  {
                     AV20presUni = "BULTO";
                  }
                  else if ( A288PrdPres == 5 )
                  {
                     AV20presUni = "PACA";
                  }
                  else if ( A288PrdPres == 6 )
                  {
                     AV20presUni = "EMBALAJE";
                  }
                  else if ( A288PrdPres == 7 )
                  {
                     AV20presUni = "MTR. CUADRADO";
                  }
                  else if ( A288PrdPres == 8 )
                  {
                     AV20presUni = "GALON";
                  }
                  AV30totMovPrd = 0;
                  AV29prodCodAux = A286PrdCod;
                  /* Execute user subroutine: 'CANTMOVING' */
                  S121 ();
                  if ( returnInSub )
                  {
                     pr_default.close(1);
                     this.cleanup();
                     if (true) return;
                  }
                  /* Execute user subroutine: 'CANTMOVEGR' */
                  S131 ();
                  if ( returnInSub )
                  {
                     pr_default.close(1);
                     this.cleanup();
                     if (true) return;
                  }
                  AV30totMovPrd = (int)((AV13cantIng+AV11cantEgr));
                  if ( AV28nroItems == 0 )
                  {
                     AV28nroItems = 1;
                     H1L0( false, 19) ;
                     getPrinter().GxDrawRect(0, Gx_line+0, 817, Gx_line+19, 0, 0, 0, 0, 1, 192, 192, 192, 0, 0, 0, 0, 0, 0, 0, 0) ;
                     getPrinter().GxAttris("Qatar2022 Medium", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                     getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A286PrdCod), "ZZZ9")), 21, Gx_line+2, 68, Gx_line+17, 0, 0, 0, 1) ;
                     getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A309prdNombre, "")), 92, Gx_line+2, 324, Gx_line+17, 0, 0, 0, 1) ;
                     getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV20presUni, "")), 346, Gx_line+2, 425, Gx_line+17, 0, 0, 0, 1) ;
                     getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( A293invFisico, "ZZ9.99")), 465, Gx_line+2, 510, Gx_line+17, 2+256, 0, 0, 1) ;
                     getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11cantEgr), "ZZZZZZZ9")), 645, Gx_line+2, 696, Gx_line+17, 2, 0, 0, 0) ;
                     getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13cantIng), "ZZZZZZZ9")), 541, Gx_line+2, 592, Gx_line+17, 2, 0, 0, 0) ;
                     getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(AV30totMovPrd), "ZZZZZZZ9")), 737, Gx_line+2, 796, Gx_line+17, 2+256, 0, 0, 0) ;
                     Gx_OldLine = Gx_line;
                     Gx_line = (int)(Gx_line+19);
                  }
                  else
                  {
                     AV28nroItems = 0;
                     H1L0( false, 19) ;
                     getPrinter().GxAttris("Qatar2022 Medium", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                     getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A286PrdCod), "ZZZ9")), 21, Gx_line+2, 68, Gx_line+17, 0, 0, 0, 1) ;
                     getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A309prdNombre, "")), 92, Gx_line+2, 324, Gx_line+17, 0, 0, 0, 1) ;
                     getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV20presUni, "")), 346, Gx_line+2, 425, Gx_line+17, 0, 0, 0, 1) ;
                     getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( A293invFisico, "ZZ9.99")), 465, Gx_line+2, 510, Gx_line+17, 2+256, 0, 0, 1) ;
                     getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13cantIng), "ZZZZZZZ9")), 541, Gx_line+2, 592, Gx_line+17, 2, 0, 0, 0) ;
                     getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11cantEgr), "ZZZZZZZ9")), 645, Gx_line+2, 696, Gx_line+17, 2, 0, 0, 0) ;
                     getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(AV30totMovPrd), "ZZZZZZZ9")), 737, Gx_line+3, 796, Gx_line+18, 2+256, 0, 0, 0) ;
                     Gx_OldLine = Gx_line;
                     Gx_line = (int)(Gx_line+19);
                  }
                  AV31total = (int)(AV31total+AV30totMovPrd);
                  pr_default.readNext(1);
               }
               pr_default.close(1);
               GxHdr3 = false;
               H1L0( false, 19) ;
               getPrinter().GxDrawLine(6, Gx_line+0, 816, Gx_line+0, 1, 0, 0, 0, 0) ;
               getPrinter().GxAttris("Verdana", 9, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Totales", 425, Gx_line+3, 476, Gx_line+18, 0+256, 0, 0, 0) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(AV26totIng), "ZZZZZZZ9")), 541, Gx_line+3, 592, Gx_line+19, 2, 0, 0, 0) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(AV27TotEgr), "ZZZZZZZ9")), 645, Gx_line+3, 696, Gx_line+19, 2, 0, 0, 0) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(AV31total), "ZZZZZZZ9")), 745, Gx_line+3, 796, Gx_line+19, 2, 0, 0, 0) ;
               Gx_OldLine = Gx_line;
               Gx_line = (int)(Gx_line+19);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1);
            H1L0( true, 0) ;
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
         /* Using cursor P001L4 */
         pr_default.execute(2, new Object[] {AV24usuCod});
         while ( (pr_default.getStatus(2) != 101) )
         {
            A3UsuCod = P001L4_A3UsuCod[0];
            A50UsuName = P001L4_A50UsuName[0];
            n50UsuName = P001L4_n50UsuName[0];
            AV25usuName = A50UsuName;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(2);
      }

      protected void S121( )
      {
         /* 'CANTMOVING' Routine */
         AV13cantIng = 0;
         /* Optimized group. */
         pr_default.dynParam(3, new Object[]{ new Object[]{
                                              AV9BodCod ,
                                              A42BodCod ,
                                              AV14EmpID ,
                                              AV8AgeID ,
                                              AV29prodCodAux } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT
                                              }
         } ) ;
         /* Using cursor P001L5 */
         pr_default.execute(3, new Object[] {AV15fdesde, AV16fHasta, AV14EmpID, AV8AgeID, AV29prodCodAux, AV9BodCod});
         c386ingCantidad = (int)((int)(P001L5_A386ingCantidad[0]));
         n386ingCantidad = P001L5_n386ingCantidad[0];
         c386ingCantidad = (int)((int)(P001L5_A386ingCantidad[0]));
         n386ingCantidad = P001L5_n386ingCantidad[0];
         pr_default.close(3);
         AV13cantIng = (int)(AV13cantIng+c386ingCantidad);
         AV26totIng = (int)(AV26totIng+c386ingCantidad);
         /* End optimized group. */
      }

      protected void S131( )
      {
         /* 'CANTMOVEGR' Routine */
         AV11cantEgr = 0;
         /* Optimized group. */
         pr_default.dynParam(4, new Object[]{ new Object[]{
                                              AV9BodCod ,
                                              A42BodCod ,
                                              AV14EmpID ,
                                              AV8AgeID ,
                                              AV29prodCodAux } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT
                                              }
         } ) ;
         /* Using cursor P001L6 */
         pr_default.execute(4, new Object[] {AV14EmpID, AV15fdesde, AV16fHasta, AV8AgeID, AV29prodCodAux, AV9BodCod});
         c296cantidad = (int)((int)(P001L6_A296cantidad[0]));
         n296cantidad = P001L6_n296cantidad[0];
         c296cantidad = (int)((int)(P001L6_A296cantidad[0]));
         n296cantidad = P001L6_n296cantidad[0];
         pr_default.close(4);
         AV11cantEgr = (int)(AV11cantEgr+c296cantidad);
         AV27TotEgr = (int)(AV27TotEgr+c296cantidad);
         /* End optimized group. */
      }

      protected void H1L0( bool bFoot ,
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
                  if ( ! (0==AV9BodCod) )
                  {
                     AV10BodDsc = A217BodDsc;
                  }
                  else
                  {
                     AV10BodDsc = "Todas las Bodegas";
                  }
                  getPrinter().GxDrawRect(0, Gx_line+78, 149, Gx_line+119, 0, 0, 0, 0, 1, 192, 192, 192, 0, 0, 0, 0, 0, 0, 0, 0) ;
                  getPrinter().GxDrawRect(148, Gx_line+0, 817, Gx_line+119, 0, 0, 0, 0, 1, 192, 192, 192, 0, 0, 0, 0, 0, 0, 0, 0) ;
                  getPrinter().GxDrawLine(0, Gx_line+88, 817, Gx_line+88, 1, 0, 0, 0, 0) ;
                  getPrinter().GxDrawLine(6, Gx_line+148, 816, Gx_line+148, 1, 0, 0, 0, 0) ;
                  sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV18logo)) ? AV35Logo_GXI : AV18logo);
                  getPrinter().GxDrawBitMap(sImgUrl, 7, Gx_line+5, 140, Gx_line+76) ;
                  getPrinter().GxAttris("Qatar2022 Medium", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV25usuName, "")), 699, Gx_line+57, 802, Gx_line+73, 0, 0, 0, 0) ;
                  getPrinter().GxAttris("Qatar2022 Medium", 10, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV10BodDsc, "@!")), 151, Gx_line+60, 444, Gx_line+78, 0+256, 0, 0, 0) ;
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
                  getPrinter().GxAttris("Verdana", 9, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText("Codigo", 21, Gx_line+133, 69, Gx_line+148, 0+256, 0, 0, 0) ;
                  getPrinter().GxDrawText("Producto", 92, Gx_line+133, 163, Gx_line+148, 0, 0, 0, 0) ;
                  getPrinter().GxDrawText("Unidades", 346, Gx_line+133, 411, Gx_line+148, 0+256, 0, 0, 0) ;
                  getPrinter().GxDrawText("Ingreso", 547, Gx_line+133, 597, Gx_line+148, 0, 0, 0, 0) ;
                  getPrinter().GxDrawText("Egresos", 648, Gx_line+133, 698, Gx_line+148, 0, 0, 0, 1) ;
                  getPrinter().GxDrawText("Inv. Fisico", 439, Gx_line+133, 511, Gx_line+148, 0+256, 0, 0, 0) ;
                  getPrinter().GxDrawText("Total", 765, Gx_line+133, 800, Gx_line+148, 0+256, 0, 0, 1) ;
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
      }

      protected void add_metrics0( )
      {
         getPrinter().setMetrics("Qatar2022 Medium", false, false, 58, 14, 72, 171,  new int[] {48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 18, 20, 23, 36, 36, 57, 43, 12, 21, 21, 25, 37, 18, 21, 18, 18, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 18, 18, 37, 37, 37, 36, 65, 43, 43, 46, 46, 43, 39, 50, 46, 18, 32, 43, 36, 53, 46, 50, 43, 50, 46, 43, 40, 46, 43, 64, 41, 42, 39, 18, 18, 18, 27, 36, 21, 36, 36, 32, 36, 36, 18, 36, 36, 14, 15, 33, 14, 55, 36, 36, 36, 36, 21, 32, 18, 36, 33, 47, 31, 31, 31, 21, 17, 21, 37, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 18, 20, 36, 36, 36, 36, 17, 36, 21, 47, 24, 36, 37, 21, 47, 35, 26, 35, 21, 21, 21, 37, 34, 21, 21, 21, 23, 36, 53, 53, 53, 39, 43, 43, 43, 43, 43, 43, 64, 46, 43, 43, 43, 43, 18, 18, 18, 18, 46, 46, 50, 50, 50, 50, 50, 37, 50, 46, 46, 46, 46, 43, 43, 39, 36, 36, 36, 36, 36, 36, 57, 32, 36, 36, 36, 36, 18, 18, 18, 18, 36, 36, 36, 36, 36, 36, 36, 35, 39, 36, 36, 36, 36, 32, 36, 32}) ;
      }

      protected void add_metrics1( )
      {
         getPrinter().setMetrics("Verdana", true, false, 57, 15, 72, 163,  new int[] {47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 17, 19, 29, 34, 34, 55, 45, 15, 21, 21, 24, 36, 17, 21, 17, 17, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 21, 21, 36, 36, 36, 38, 60, 43, 45, 45, 45, 41, 38, 48, 45, 17, 34, 45, 38, 53, 45, 48, 41, 48, 45, 41, 38, 45, 41, 57, 41, 41, 38, 21, 17, 21, 36, 34, 21, 34, 38, 34, 38, 34, 21, 38, 38, 17, 17, 34, 17, 55, 38, 38, 38, 38, 24, 34, 21, 38, 33, 49, 34, 34, 31, 24, 17, 24, 36, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 17, 21, 34, 34, 34, 34, 17, 34, 21, 46, 23, 34, 36, 21, 46, 34, 25, 34, 21, 21, 21, 36, 34, 21, 20, 21, 23, 34, 52, 52, 52, 38, 45, 45, 45, 45, 45, 45, 62, 45, 41, 41, 41, 41, 17, 17, 17, 17, 45, 45, 48, 48, 48, 48, 48, 36, 48, 45, 45, 45, 45, 41, 41, 38, 34, 34, 34, 34, 34, 34, 55, 34, 34, 34, 34, 34, 17, 17, 17, 17, 38, 38, 38, 38, 38, 38, 38, 34, 38, 38, 38, 38, 38, 34, 38, 34}) ;
      }

      protected void add_metrics2( )
      {
         getPrinter().setMetrics("Times New Roman", true, false, 57, 15, 72, 163,  new int[] {47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 17, 19, 29, 34, 34, 55, 45, 15, 21, 21, 24, 36, 17, 21, 17, 17, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 21, 21, 36, 36, 36, 38, 60, 43, 45, 45, 45, 41, 38, 48, 45, 17, 34, 45, 38, 53, 45, 48, 41, 48, 45, 41, 38, 45, 41, 57, 41, 41, 38, 21, 17, 21, 36, 34, 21, 34, 38, 34, 38, 34, 21, 38, 38, 17, 17, 34, 17, 55, 38, 38, 38, 38, 24, 34, 21, 38, 33, 49, 34, 34, 31, 24, 17, 24, 36, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 17, 21, 34, 34, 34, 34, 17, 34, 21, 46, 23, 34, 36, 21, 46, 34, 25, 34, 21, 21, 21, 36, 34, 21, 20, 21, 23, 34, 52, 52, 52, 38, 45, 45, 45, 45, 45, 45, 62, 45, 41, 41, 41, 41, 17, 17, 17, 17, 45, 45, 48, 48, 48, 48, 48, 36, 48, 45, 45, 45, 45, 41, 41, 38, 34, 34, 34, 34, 34, 34, 55, 34, 34, 34, 34, 34, 17, 17, 17, 17, 38, 38, 38, 38, 38, 38, 38, 34, 38, 38, 38, 38, 38, 34, 38, 34}) ;
      }

      protected void add_metrics3( )
      {
         getPrinter().setMetrics("Times New Roman", false, false, 58, 14, 72, 171,  new int[] {48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 18, 20, 23, 36, 36, 57, 43, 12, 21, 21, 25, 37, 18, 21, 18, 18, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 18, 18, 37, 37, 37, 36, 65, 43, 43, 46, 46, 43, 39, 50, 46, 18, 32, 43, 36, 53, 46, 50, 43, 50, 46, 43, 40, 46, 43, 64, 41, 42, 39, 18, 18, 18, 27, 36, 21, 36, 36, 32, 36, 36, 18, 36, 36, 14, 15, 33, 14, 55, 36, 36, 36, 36, 21, 32, 18, 36, 33, 47, 31, 31, 31, 21, 17, 21, 37, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 18, 20, 36, 36, 36, 36, 17, 36, 21, 47, 24, 36, 37, 21, 47, 35, 26, 35, 21, 21, 21, 37, 34, 21, 21, 21, 23, 36, 53, 53, 53, 39, 43, 43, 43, 43, 43, 43, 64, 46, 43, 43, 43, 43, 18, 18, 18, 18, 46, 46, 50, 50, 50, 50, 50, 37, 50, 46, 46, 46, 46, 43, 43, 39, 36, 36, 36, 36, 36, 36, 57, 32, 36, 36, 36, 36, 18, 18, 18, 18, 36, 36, 36, 36, 36, 36, 36, 35, 39, 36, 36, 36, 36, 32, 36, 32}) ;
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
         P001L2_A2AgeID = new short[1] ;
         P001L2_A1EmpID = new short[1] ;
         P001L2_A46AgeDsc = new String[] {""} ;
         P001L2_n46AgeDsc = new bool[] {false} ;
         P001L2_A44empdsc = new String[] {""} ;
         P001L2_n44empdsc = new bool[] {false} ;
         P001L2_A97emplogo = new String[] {""} ;
         P001L2_n97emplogo = new bool[] {false} ;
         A46AgeDsc = "";
         A44empdsc = "";
         A97emplogo = "";
         AV18logo = "";
         AV35Logo_GXI = "";
         P001L3_A1EmpID = new short[1] ;
         P001L3_A2AgeID = new short[1] ;
         P001L3_A286PrdCod = new short[1] ;
         P001L3_A42BodCod = new short[1] ;
         P001L3_A288PrdPres = new short[1] ;
         P001L3_n288PrdPres = new bool[] {false} ;
         P001L3_A293invFisico = new decimal[1] ;
         P001L3_n293invFisico = new bool[] {false} ;
         P001L3_A309prdNombre = new String[] {""} ;
         P001L3_n309prdNombre = new bool[] {false} ;
         P001L3_A291stockMes = new short[1] ;
         P001L3_A290stockAnio = new short[1] ;
         P001L3_A217BodDsc = new String[] {""} ;
         P001L3_n217BodDsc = new bool[] {false} ;
         A309prdNombre = "";
         A217BodDsc = "";
         AV20presUni = "";
         P001L4_A3UsuCod = new String[] {""} ;
         P001L4_A50UsuName = new String[] {""} ;
         P001L4_n50UsuName = new bool[] {false} ;
         A3UsuCod = "";
         A50UsuName = "";
         AV25usuName = "";
         P001L5_A386ingCantidad = new decimal[1] ;
         P001L5_n386ingCantidad = new bool[] {false} ;
         P001L6_A296cantidad = new decimal[1] ;
         P001L6_n296cantidad = new bool[] {false} ;
         AV10BodDsc = "";
         AV18logo = "";
         sImgUrl = "";
         Gx_date = DateTime.MinValue;
         Gx_time = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.apdfstockbodegaresumen__default(),
            new Object[][] {
                new Object[] {
               P001L2_A2AgeID, P001L2_A1EmpID, P001L2_A46AgeDsc, P001L2_n46AgeDsc, P001L2_A44empdsc, P001L2_n44empdsc, P001L2_A97emplogo, P001L2_n97emplogo
               }
               , new Object[] {
               P001L3_A1EmpID, P001L3_A2AgeID, P001L3_A286PrdCod, P001L3_A42BodCod, P001L3_A288PrdPres, P001L3_n288PrdPres, P001L3_A293invFisico, P001L3_n293invFisico, P001L3_A309prdNombre, P001L3_n309prdNombre,
               P001L3_A291stockMes, P001L3_A290stockAnio, P001L3_A217BodDsc, P001L3_n217BodDsc
               }
               , new Object[] {
               P001L4_A3UsuCod, P001L4_A50UsuName, P001L4_n50UsuName
               }
               , new Object[] {
               P001L5_A386ingCantidad, P001L5_n386ingCantidad
               }
               , new Object[] {
               P001L6_A296cantidad, P001L6_n296cantidad
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
      private short AV14EmpID ;
      private short AV8AgeID ;
      private short AV9BodCod ;
      private short AV19prdCod ;
      private short GxWebError ;
      private short A2AgeID ;
      private short A1EmpID ;
      private short A42BodCod ;
      private short A286PrdCod ;
      private short A288PrdPres ;
      private short A291stockMes ;
      private short A290stockAnio ;
      private short AV29prodCodAux ;
      private short AV28nroItems ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int AV26totIng ;
      private int AV27TotEgr ;
      private int AV31total ;
      private int AV30totMovPrd ;
      private int AV13cantIng ;
      private int AV11cantEgr ;
      private int Gx_OldLine ;
      private int c386ingCantidad ;
      private int c296cantidad ;
      private decimal A293invFisico ;
      private String GXKey ;
      private String gxfirstwebparm ;
      private String AV24usuCod ;
      private String scmdbuf ;
      private String A46AgeDsc ;
      private String A97emplogo ;
      private String A217BodDsc ;
      private String A3UsuCod ;
      private String AV10BodDsc ;
      private String sImgUrl ;
      private String Gx_time ;
      private DateTime AV15fdesde ;
      private DateTime AV16fHasta ;
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
      private bool n50UsuName ;
      private bool n386ingCantidad ;
      private bool n296cantidad ;
      private String A44empdsc ;
      private String AV35Logo_GXI ;
      private String A309prdNombre ;
      private String AV20presUni ;
      private String A50UsuName ;
      private String AV25usuName ;
      private String AV18logo ;
      private String Logo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P001L2_A2AgeID ;
      private short[] P001L2_A1EmpID ;
      private String[] P001L2_A46AgeDsc ;
      private bool[] P001L2_n46AgeDsc ;
      private String[] P001L2_A44empdsc ;
      private bool[] P001L2_n44empdsc ;
      private String[] P001L2_A97emplogo ;
      private bool[] P001L2_n97emplogo ;
      private short[] P001L3_A1EmpID ;
      private short[] P001L3_A2AgeID ;
      private short[] P001L3_A286PrdCod ;
      private short[] P001L3_A42BodCod ;
      private short[] P001L3_A288PrdPres ;
      private bool[] P001L3_n288PrdPres ;
      private decimal[] P001L3_A293invFisico ;
      private bool[] P001L3_n293invFisico ;
      private String[] P001L3_A309prdNombre ;
      private bool[] P001L3_n309prdNombre ;
      private short[] P001L3_A291stockMes ;
      private short[] P001L3_A290stockAnio ;
      private String[] P001L3_A217BodDsc ;
      private bool[] P001L3_n217BodDsc ;
      private String[] P001L4_A3UsuCod ;
      private String[] P001L4_A50UsuName ;
      private bool[] P001L4_n50UsuName ;
      private decimal[] P001L5_A386ingCantidad ;
      private bool[] P001L5_n386ingCantidad ;
      private decimal[] P001L6_A296cantidad ;
      private bool[] P001L6_n296cantidad ;
   }

   public class apdfstockbodegaresumen__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P001L3( IGxContext context ,
                                             short AV9BodCod ,
                                             short AV19prdCod ,
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
         scmdbuf = "SELECT T1.[EmpID], T1.[AgeID], T1.[PrdCod], T1.[BodCod], T2.[PrdPres], T1.[invFisico], T2.[prdNombre], T1.[stockMes], T1.[stockAnio], T3.[BodDsc] FROM (([ProdxBodega] T1 WITH (NOLOCK) INNER JOIN [Productos] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[AgeID] = T1.[AgeID] AND T2.[PrdCod] = T1.[PrdCod]) INNER JOIN [Bodegas] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[BodCod] = T1.[BodCod])";
         scmdbuf = scmdbuf + " WHERE (T1.[EmpID] = @EmpID)";
         scmdbuf = scmdbuf + " and (T1.[AgeID] = @AgeID)";
         if ( ! (0==AV9BodCod) )
         {
            sWhereString = sWhereString + " and (T1.[BodCod] = @AV9BodCod)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (0==AV19prdCod) )
         {
            sWhereString = sWhereString + " and (T1.[PrdCod] = @AV19prdCod)";
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

      protected Object[] conditional_P001L5( IGxContext context ,
                                             short AV9BodCod ,
                                             short A42BodCod ,
                                             short AV14EmpID ,
                                             short AV8AgeID ,
                                             short AV29prodCodAux )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [6] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT SUM([ingCantidad]) FROM [ProdStockBodegastockDetEgr] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([fchMovIng] >= @AV15fdesde and [fchMovIng] <= @AV16fHasta)";
         scmdbuf = scmdbuf + " and ([EmpID] = @AV14EmpID)";
         scmdbuf = scmdbuf + " and ([AgeID] = @AV8AgeID)";
         scmdbuf = scmdbuf + " and ([PrdCod] = @AV29prodCodAux)";
         if ( ! (0==AV9BodCod) )
         {
            sWhereString = sWhereString + " and ([BodCod] = @AV9BodCod)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + "";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_P001L6( IGxContext context ,
                                             short AV9BodCod ,
                                             short A42BodCod ,
                                             short AV14EmpID ,
                                             short AV8AgeID ,
                                             short AV29prodCodAux )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [6] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT SUM([cantidad]) FROM [ProdxBodegaTipoInv] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([EmpID] = @AV14EmpID)";
         scmdbuf = scmdbuf + " and ([fchMovStock] >= @AV15fdesde and [fchMovStock] <= @AV16fHasta)";
         scmdbuf = scmdbuf + " and ([AgeID] = @AV8AgeID)";
         scmdbuf = scmdbuf + " and ([PrdCod] = @AV29prodCodAux)";
         if ( ! (0==AV9BodCod) )
         {
            sWhereString = sWhereString + " and ([BodCod] = @AV9BodCod)";
         }
         else
         {
            GXv_int5[5] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + "";
         GXv_Object6[0] = scmdbuf;
         GXv_Object6[1] = GXv_int5;
         return GXv_Object6 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 1 :
                     return conditional_P001L3(context, (short)dynConstraints[0] , (short)dynConstraints[1] , (short)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (short)dynConstraints[5] );
               case 3 :
                     return conditional_P001L5(context, (short)dynConstraints[0] , (short)dynConstraints[1] , (short)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] );
               case 4 :
                     return conditional_P001L6(context, (short)dynConstraints[0] , (short)dynConstraints[1] , (short)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] );
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
          Object[] prmP001L2 ;
          prmP001L2 = new Object[] {
          new Object[] {"@AV14EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8AgeID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001L4 ;
          prmP001L4 = new Object[] {
          new Object[] {"@AV24usuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmP001L3 ;
          prmP001L3 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV19prdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001L5 ;
          prmP001L5 = new Object[] {
          new Object[] {"@AV15fdesde",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV16fHasta",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV14EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV29prodCodAux",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001L6 ;
          prmP001L6 = new Object[] {
          new Object[] {"@AV14EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV15fdesde",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV16fHasta",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV8AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV29prodCodAux",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9BodCod",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001L2", "SELECT T1.[AgeID], T1.[EmpID], T1.[AgeDsc], T2.[empdsc], T2.[emplogo] FROM ([Agencias] T1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID]) WHERE T1.[EmpID] = @AV14EmpID and T1.[AgeID] = @AV8AgeID ORDER BY T1.[EmpID], T1.[AgeID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001L2,1,0,true,true )
             ,new CursorDef("P001L3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001L3,100,0,true,false )
             ,new CursorDef("P001L4", "SELECT TOP 1 [UsuCod], [UsuName] FROM [Usuarios] WITH (NOLOCK) WHERE [UsuCod] = @AV24usuCod ORDER BY [UsuCod] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001L4,1,0,false,true )
             ,new CursorDef("P001L5", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001L5,1,0,true,false )
             ,new CursorDef("P001L6", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001L6,1,0,true,false )
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
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((decimal[]) buf[6])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(6);
                ((String[]) buf[8])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(7);
                ((short[]) buf[10])[0] = rslt.getShort(8) ;
                ((short[]) buf[11])[0] = rslt.getShort(9) ;
                ((String[]) buf[12])[0] = rslt.getString(10, 40) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                return;
             case 3 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 4 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
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
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 3 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[6]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[7]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[8]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[9]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[10]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[11]);
                }
                return;
             case 4 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[6]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[7]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[8]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[9]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[10]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[11]);
                }
                return;
       }
    }

 }

}
