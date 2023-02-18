/*
               File: excListaOrdenProduccion
        Description: exc Lista Orden Produccion
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/14/2023 1:15:32.60
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
using GeneXus.Procedure;
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
   public class exclistaordenproduccion : GXProcedure
   {
      public exclistaordenproduccion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public exclistaordenproduccion( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_empID ,
                           DateTime aP1_fchDesde ,
                           DateTime aP2_fchHasta ,
                           short aP3_clientID ,
                           short aP4_ordenID ,
                           short aP5_vendedorID ,
                           String aP6_OrdenProceso ,
                           out String aP7_archivo )
      {
         this.AV11empID = aP0_empID;
         this.AV14fchDesde = aP1_fchDesde;
         this.AV15fchHasta = aP2_fchHasta;
         this.AV10clientID = aP3_clientID;
         this.AV25ordenID = aP4_ordenID;
         this.AV30vendedorID = aP5_vendedorID;
         this.AV26OrdenProceso = aP6_OrdenProceso;
         this.AV9archivo = "" ;
         initialize();
         executePrivate();
         aP7_archivo=this.AV9archivo;
      }

      public String executeUdp( short aP0_empID ,
                                DateTime aP1_fchDesde ,
                                DateTime aP2_fchHasta ,
                                short aP3_clientID ,
                                short aP4_ordenID ,
                                short aP5_vendedorID ,
                                String aP6_OrdenProceso )
      {
         this.AV11empID = aP0_empID;
         this.AV14fchDesde = aP1_fchDesde;
         this.AV15fchHasta = aP2_fchHasta;
         this.AV10clientID = aP3_clientID;
         this.AV25ordenID = aP4_ordenID;
         this.AV30vendedorID = aP5_vendedorID;
         this.AV26OrdenProceso = aP6_OrdenProceso;
         this.AV9archivo = "" ;
         initialize();
         executePrivate();
         aP7_archivo=this.AV9archivo;
         return AV9archivo ;
      }

      public void executeSubmit( short aP0_empID ,
                                 DateTime aP1_fchDesde ,
                                 DateTime aP2_fchHasta ,
                                 short aP3_clientID ,
                                 short aP4_ordenID ,
                                 short aP5_vendedorID ,
                                 String aP6_OrdenProceso ,
                                 out String aP7_archivo )
      {
         exclistaordenproduccion objexclistaordenproduccion;
         objexclistaordenproduccion = new exclistaordenproduccion();
         objexclistaordenproduccion.AV11empID = aP0_empID;
         objexclistaordenproduccion.AV14fchDesde = aP1_fchDesde;
         objexclistaordenproduccion.AV15fchHasta = aP2_fchHasta;
         objexclistaordenproduccion.AV10clientID = aP3_clientID;
         objexclistaordenproduccion.AV25ordenID = aP4_ordenID;
         objexclistaordenproduccion.AV30vendedorID = aP5_vendedorID;
         objexclistaordenproduccion.AV26OrdenProceso = aP6_OrdenProceso;
         objexclistaordenproduccion.AV9archivo = "" ;
         objexclistaordenproduccion.context.SetSubmitInitialConfig(context);
         objexclistaordenproduccion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objexclistaordenproduccion);
         aP7_archivo=this.AV9archivo;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((exclistaordenproduccion)stateInfo).executePrivate();
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
         AV18idx = GXUtil.Sleep( 1);
         AV28ProgressIndicator.gxTpr_Type = 1;
         AV24nombre = "OrdenesProduccion";
         AV9archivo = AV24nombre + ".xlsx";
         AV16Hoja.Open(AV9archivo);
         AV16Hoja.Clear();
         AV18idx = GXUtil.Sleep( 2);
         AV28ProgressIndicator.showwithtitle( "Generando Columnas");
         AV28ProgressIndicator.gxTpr_Value = 10;
         AV17i = 1;
         AV16Hoja.get_Cells(AV17i, 1, 1, 1).Text = "Nro. Secuencia";
         AV16Hoja.get_Cells(AV17i, 2, 1, 1).Text = "Fecha Registro";
         AV16Hoja.get_Cells(AV17i, 3, 1, 1).Text = "RUC";
         AV16Hoja.get_Cells(AV17i, 4, 1, 1).Text = "Cliente";
         AV16Hoja.get_Cells(AV17i, 5, 1, 1).Text = "Factura";
         AV16Hoja.get_Cells(AV17i, 6, 1, 1).Text = "Chasis";
         AV16Hoja.get_Cells(AV17i, 7, 1, 1).Text = "Placa";
         AV16Hoja.get_Cells(AV17i, 8, 1, 1).Text = "Marca";
         AV16Hoja.get_Cells(AV17i, 9, 1, 1).Text = "Modelo";
         AV16Hoja.get_Cells(AV17i, 10, 1, 1).Text = "Prototipo";
         AV16Hoja.get_Cells(AV17i, 11, 1, 1).Text = "Tipo Orden";
         AV16Hoja.get_Cells(AV17i, 12, 1, 1).Text = "Vendedor";
         AV16Hoja.get_Cells(AV17i, 13, 1, 1).Text = "Proceso";
         AV16Hoja.get_Cells(AV17i, 14, 1, 1).Text = "Estado";
         AV16Hoja.get_Cells(AV17i, 15, 1, 1).Text = "Fecha Entrega";
         AV16Hoja.get_Cells(AV17i, 16, 1, 1).Text = "Mes";
         AV19j = 1;
         while ( AV19j <= 16 )
         {
            AV16Hoja.get_Cells(AV17i, AV19j, 1, 1).Bold = 1;
            AV19j = (short)(AV19j+1);
         }
         AV17i = (short)(AV17i+1);
         AV18idx = GXUtil.Sleep( 2);
         AV28ProgressIndicator.showwithtitle( "Generando Reporte: "+AV9archivo);
         AV28ProgressIndicator.gxTpr_Value = 20;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV10clientID ,
                                              AV25ordenID ,
                                              AV30vendedorID ,
                                              AV26OrdenProceso ,
                                              A5ClienteID ,
                                              A22OrdenID ,
                                              A9vendedorID ,
                                              A133OrdenProceso ,
                                              A119OrdenFch ,
                                              AV14fchDesde ,
                                              AV15fchHasta ,
                                              AV11empID ,
                                              A1EmpID } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE,
                                              TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.SHORT
                                              }
         } ) ;
         /* Using cursor P000N2 */
         pr_default.execute(0, new Object[] {AV11empID, AV14fchDesde, AV15fchHasta, AV10clientID, AV25ordenID, AV30vendedorID, AV26OrdenProceso});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A8VehiculoID = P000N2_A8VehiculoID[0];
            A10protID = P000N2_A10protID[0];
            A17tipOrdID = P000N2_A17tipOrdID[0];
            A133OrdenProceso = P000N2_A133OrdenProceso[0];
            n133OrdenProceso = P000N2_n133OrdenProceso[0];
            A9vendedorID = P000N2_A9vendedorID[0];
            A22OrdenID = P000N2_A22OrdenID[0];
            A5ClienteID = P000N2_A5ClienteID[0];
            A119OrdenFch = P000N2_A119OrdenFch[0];
            n119OrdenFch = P000N2_n119OrdenFch[0];
            A1EmpID = P000N2_A1EmpID[0];
            A56ClienteRUC = P000N2_A56ClienteRUC[0];
            n56ClienteRUC = P000N2_n56ClienteRUC[0];
            A57ClienteDsc = P000N2_A57ClienteDsc[0];
            n57ClienteDsc = P000N2_n57ClienteDsc[0];
            A106facturaNro = P000N2_A106facturaNro[0];
            n106facturaNro = P000N2_n106facturaNro[0];
            A69VehiculoChasis = P000N2_A69VehiculoChasis[0];
            n69VehiculoChasis = P000N2_n69VehiculoChasis[0];
            A68VehiculoPlaca = P000N2_A68VehiculoPlaca[0];
            n68VehiculoPlaca = P000N2_n68VehiculoPlaca[0];
            A26OrdenMarcaID = P000N2_A26OrdenMarcaID[0];
            A117OrdenModeloID = P000N2_A117OrdenModeloID[0];
            A74protDsc = P000N2_A74protDsc[0];
            n74protDsc = P000N2_n74protDsc[0];
            A104tipOrdDsc = P000N2_A104tipOrdDsc[0];
            n104tipOrdDsc = P000N2_n104tipOrdDsc[0];
            A72vendedorDsc = P000N2_A72vendedorDsc[0];
            n72vendedorDsc = P000N2_n72vendedorDsc[0];
            A115OrdenEst = P000N2_A115OrdenEst[0];
            n115OrdenEst = P000N2_n115OrdenEst[0];
            A172OrdenfchEnt = P000N2_A172OrdenfchEnt[0];
            n172OrdenfchEnt = P000N2_n172OrdenfchEnt[0];
            A24OrdenPeriodo = P000N2_A24OrdenPeriodo[0];
            A25OrdenAnio = P000N2_A25OrdenAnio[0];
            A56ClienteRUC = P000N2_A56ClienteRUC[0];
            n56ClienteRUC = P000N2_n56ClienteRUC[0];
            A57ClienteDsc = P000N2_A57ClienteDsc[0];
            n57ClienteDsc = P000N2_n57ClienteDsc[0];
            A69VehiculoChasis = P000N2_A69VehiculoChasis[0];
            n69VehiculoChasis = P000N2_n69VehiculoChasis[0];
            A68VehiculoPlaca = P000N2_A68VehiculoPlaca[0];
            n68VehiculoPlaca = P000N2_n68VehiculoPlaca[0];
            A72vendedorDsc = P000N2_A72vendedorDsc[0];
            n72vendedorDsc = P000N2_n72vendedorDsc[0];
            A74protDsc = P000N2_A74protDsc[0];
            n74protDsc = P000N2_n74protDsc[0];
            A104tipOrdDsc = P000N2_A104tipOrdDsc[0];
            n104tipOrdDsc = P000N2_n104tipOrdDsc[0];
            AV16Hoja.get_Cells(AV17i, 1, 1, 1).Number = A22OrdenID;
            AV16Hoja.get_Cells(AV17i, 2, 1, 1).Text = context.localUtil.DToC( A119OrdenFch, 4, "/");
            AV16Hoja.get_Cells(AV17i, 3, 1, 1).Text = A56ClienteRUC;
            AV16Hoja.get_Cells(AV17i, 4, 1, 1).Text = A57ClienteDsc;
            AV16Hoja.get_Cells(AV17i, 5, 1, 1).Text = StringUtil.Str( (decimal)(A106facturaNro), 8, 0);
            AV16Hoja.get_Cells(AV17i, 6, 1, 1).Text = A69VehiculoChasis;
            AV16Hoja.get_Cells(AV17i, 7, 1, 1).Text = A68VehiculoPlaca;
            AV21marcaID = A26OrdenMarcaID;
            AV23modelsID = A117OrdenModeloID;
            /* Execute user subroutine: 'MARCA' */
            S121 ();
            if ( returnInSub )
            {
               pr_default.close(0);
               this.cleanup();
               if (true) return;
            }
            /* Execute user subroutine: 'MODEL' */
            S131 ();
            if ( returnInSub )
            {
               pr_default.close(0);
               this.cleanup();
               if (true) return;
            }
            AV16Hoja.get_Cells(AV17i, 8, 1, 1).Text = AV20marcaDsc;
            AV16Hoja.get_Cells(AV17i, 9, 1, 1).Text = AV22modelDsc;
            AV16Hoja.get_Cells(AV17i, 10, 1, 1).Text = A74protDsc;
            AV16Hoja.get_Cells(AV17i, 11, 1, 1).Text = A104tipOrdDsc;
            AV16Hoja.get_Cells(AV17i, 12, 1, 1).Text = A72vendedorDsc;
            AV8abreProc = A133OrdenProceso;
            /* Execute user subroutine: 'PROCESOS' */
            S111 ();
            if ( returnInSub )
            {
               pr_default.close(0);
               this.cleanup();
               if (true) return;
            }
            AV16Hoja.get_Cells(AV17i, 13, 1, 1).Text = AV27proceso;
            if ( StringUtil.StrCmp(A115OrdenEst, "A") == 0 )
            {
               AV13estado = "ACTIVO";
            }
            else
            {
               AV13estado = "ANULADO";
            }
            AV16Hoja.get_Cells(AV17i, 14, 1, 1).Text = AV13estado;
            if ( StringUtil.StrCmp(A133OrdenProceso, "ENT") == 0 )
            {
               GXt_dtime1 = DateTimeUtil.ResetTime( A172OrdenfchEnt ) ;
               AV16Hoja.SetDateFormat(context, 8, 5, 0, 3, "/", ":", " ");
               AV16Hoja.get_Cells(AV17i, 15, 1, 1).Date = GXt_dtime1;
               AV31mesName = DateTimeUtil.CMonth( A172OrdenfchEnt, "spa");
               AV16Hoja.get_Cells(AV17i, 16, 1, 1).Text = StringUtil.Upper( AV31mesName);
            }
            else
            {
               AV16Hoja.get_Cells(AV17i, 15, 1, 1).Text = "";
               AV16Hoja.get_Cells(AV17i, 16, 1, 1).Text = "";
            }
            AV17i = (short)(AV17i+1);
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV18idx = GXUtil.Sleep( 2);
         AV28ProgressIndicator.showwithtitle( "Reporte Generado..");
         AV28ProgressIndicator.gxTpr_Value = 90;
         AV16Hoja.Save();
         /* Execute user subroutine: 'CHECKSTATUS' */
         S141 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV16Hoja.Close();
         AV28ProgressIndicator.hide();
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'PROCESOS' Routine */
         /* Using cursor P000N3 */
         pr_default.execute(1, new Object[] {AV8abreProc});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A129ProcAbre = P000N3_A129ProcAbre[0];
            n129ProcAbre = P000N3_n129ProcAbre[0];
            A130ProcEst = P000N3_A130ProcEst[0];
            n130ProcEst = P000N3_n130ProcEst[0];
            A128ProcDsc = P000N3_A128ProcDsc[0];
            n128ProcDsc = P000N3_n128ProcDsc[0];
            A20ProcID = P000N3_A20ProcID[0];
            AV27proceso = A128ProcDsc;
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void S121( )
      {
         /* 'MARCA' Routine */
         /* Using cursor P000N4 */
         pr_default.execute(2, new Object[] {AV11empID, AV21marcaID});
         while ( (pr_default.getStatus(2) != 101) )
         {
            A6MarcaID = P000N4_A6MarcaID[0];
            A1EmpID = P000N4_A1EmpID[0];
            A63MarcaEst = P000N4_A63MarcaEst[0];
            n63MarcaEst = P000N4_n63MarcaEst[0];
            A62MarcaDsc = P000N4_A62MarcaDsc[0];
            n62MarcaDsc = P000N4_n62MarcaDsc[0];
            AV20marcaDsc = A62MarcaDsc;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(2);
      }

      protected void S131( )
      {
         /* 'MODEL' Routine */
         /* Using cursor P000N5 */
         pr_default.execute(3, new Object[] {AV11empID, AV21marcaID, AV23modelsID});
         while ( (pr_default.getStatus(3) != 101) )
         {
            A7ModeloID = P000N5_A7ModeloID[0];
            A6MarcaID = P000N5_A6MarcaID[0];
            A1EmpID = P000N5_A1EmpID[0];
            A64ModeloDsc = P000N5_A64ModeloDsc[0];
            n64ModeloDsc = P000N5_n64ModeloDsc[0];
            AV22modelDsc = A64ModeloDsc;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(3);
      }

      protected void S141( )
      {
         /* 'CHECKSTATUS' Routine */
         if ( AV16Hoja.ErrCode != 0 )
         {
            AV9archivo = "";
            AV12ErrorMessage = AV16Hoja.ErrDescription;
            AV16Hoja.Close();
            returnInSub = true;
            if (true) return;
         }
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
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
         AV28ProgressIndicator = new GeneXus.Core.genexus.common.ui.SdtProgress(context);
         AV24nombre = "";
         AV16Hoja = new ExcelDocumentI();
         scmdbuf = "";
         A133OrdenProceso = "";
         A119OrdenFch = DateTime.MinValue;
         P000N2_A8VehiculoID = new short[1] ;
         P000N2_A10protID = new short[1] ;
         P000N2_A17tipOrdID = new short[1] ;
         P000N2_A133OrdenProceso = new String[] {""} ;
         P000N2_n133OrdenProceso = new bool[] {false} ;
         P000N2_A9vendedorID = new short[1] ;
         P000N2_A22OrdenID = new short[1] ;
         P000N2_A5ClienteID = new short[1] ;
         P000N2_A119OrdenFch = new DateTime[] {DateTime.MinValue} ;
         P000N2_n119OrdenFch = new bool[] {false} ;
         P000N2_A1EmpID = new short[1] ;
         P000N2_A56ClienteRUC = new String[] {""} ;
         P000N2_n56ClienteRUC = new bool[] {false} ;
         P000N2_A57ClienteDsc = new String[] {""} ;
         P000N2_n57ClienteDsc = new bool[] {false} ;
         P000N2_A106facturaNro = new int[1] ;
         P000N2_n106facturaNro = new bool[] {false} ;
         P000N2_A69VehiculoChasis = new String[] {""} ;
         P000N2_n69VehiculoChasis = new bool[] {false} ;
         P000N2_A68VehiculoPlaca = new String[] {""} ;
         P000N2_n68VehiculoPlaca = new bool[] {false} ;
         P000N2_A26OrdenMarcaID = new short[1] ;
         P000N2_A117OrdenModeloID = new short[1] ;
         P000N2_A74protDsc = new String[] {""} ;
         P000N2_n74protDsc = new bool[] {false} ;
         P000N2_A104tipOrdDsc = new String[] {""} ;
         P000N2_n104tipOrdDsc = new bool[] {false} ;
         P000N2_A72vendedorDsc = new String[] {""} ;
         P000N2_n72vendedorDsc = new bool[] {false} ;
         P000N2_A115OrdenEst = new String[] {""} ;
         P000N2_n115OrdenEst = new bool[] {false} ;
         P000N2_A172OrdenfchEnt = new DateTime[] {DateTime.MinValue} ;
         P000N2_n172OrdenfchEnt = new bool[] {false} ;
         P000N2_A24OrdenPeriodo = new short[1] ;
         P000N2_A25OrdenAnio = new short[1] ;
         A56ClienteRUC = "";
         A57ClienteDsc = "";
         A69VehiculoChasis = "";
         A68VehiculoPlaca = "";
         A74protDsc = "";
         A104tipOrdDsc = "";
         A72vendedorDsc = "";
         A115OrdenEst = "";
         A172OrdenfchEnt = DateTime.MinValue;
         AV20marcaDsc = "";
         AV22modelDsc = "";
         AV8abreProc = "";
         AV27proceso = "";
         AV13estado = "";
         GXt_dtime1 = (DateTime)(DateTime.MinValue);
         AV31mesName = "";
         P000N3_A129ProcAbre = new String[] {""} ;
         P000N3_n129ProcAbre = new bool[] {false} ;
         P000N3_A130ProcEst = new String[] {""} ;
         P000N3_n130ProcEst = new bool[] {false} ;
         P000N3_A128ProcDsc = new String[] {""} ;
         P000N3_n128ProcDsc = new bool[] {false} ;
         P000N3_A20ProcID = new short[1] ;
         A129ProcAbre = "";
         A130ProcEst = "";
         A128ProcDsc = "";
         P000N4_A6MarcaID = new short[1] ;
         P000N4_A1EmpID = new short[1] ;
         P000N4_A63MarcaEst = new String[] {""} ;
         P000N4_n63MarcaEst = new bool[] {false} ;
         P000N4_A62MarcaDsc = new String[] {""} ;
         P000N4_n62MarcaDsc = new bool[] {false} ;
         A63MarcaEst = "";
         A62MarcaDsc = "";
         P000N5_A7ModeloID = new short[1] ;
         P000N5_A6MarcaID = new short[1] ;
         P000N5_A1EmpID = new short[1] ;
         P000N5_A64ModeloDsc = new String[] {""} ;
         P000N5_n64ModeloDsc = new bool[] {false} ;
         A64ModeloDsc = "";
         AV12ErrorMessage = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.exclistaordenproduccion__default(),
            new Object[][] {
                new Object[] {
               P000N2_A8VehiculoID, P000N2_A10protID, P000N2_A17tipOrdID, P000N2_A133OrdenProceso, P000N2_n133OrdenProceso, P000N2_A9vendedorID, P000N2_A22OrdenID, P000N2_A5ClienteID, P000N2_A119OrdenFch, P000N2_n119OrdenFch,
               P000N2_A1EmpID, P000N2_A56ClienteRUC, P000N2_n56ClienteRUC, P000N2_A57ClienteDsc, P000N2_n57ClienteDsc, P000N2_A106facturaNro, P000N2_n106facturaNro, P000N2_A69VehiculoChasis, P000N2_n69VehiculoChasis, P000N2_A68VehiculoPlaca,
               P000N2_n68VehiculoPlaca, P000N2_A26OrdenMarcaID, P000N2_A117OrdenModeloID, P000N2_A74protDsc, P000N2_n74protDsc, P000N2_A104tipOrdDsc, P000N2_n104tipOrdDsc, P000N2_A72vendedorDsc, P000N2_n72vendedorDsc, P000N2_A115OrdenEst,
               P000N2_n115OrdenEst, P000N2_A172OrdenfchEnt, P000N2_n172OrdenfchEnt, P000N2_A24OrdenPeriodo, P000N2_A25OrdenAnio
               }
               , new Object[] {
               P000N3_A129ProcAbre, P000N3_n129ProcAbre, P000N3_A130ProcEst, P000N3_n130ProcEst, P000N3_A128ProcDsc, P000N3_n128ProcDsc, P000N3_A20ProcID
               }
               , new Object[] {
               P000N4_A6MarcaID, P000N4_A1EmpID, P000N4_A63MarcaEst, P000N4_n63MarcaEst, P000N4_A62MarcaDsc, P000N4_n62MarcaDsc
               }
               , new Object[] {
               P000N5_A7ModeloID, P000N5_A6MarcaID, P000N5_A1EmpID, P000N5_A64ModeloDsc, P000N5_n64ModeloDsc
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV11empID ;
      private short AV10clientID ;
      private short AV25ordenID ;
      private short AV30vendedorID ;
      private short AV18idx ;
      private short AV17i ;
      private short AV19j ;
      private short A5ClienteID ;
      private short A22OrdenID ;
      private short A9vendedorID ;
      private short A1EmpID ;
      private short A8VehiculoID ;
      private short A10protID ;
      private short A17tipOrdID ;
      private short A26OrdenMarcaID ;
      private short A117OrdenModeloID ;
      private short A24OrdenPeriodo ;
      private short A25OrdenAnio ;
      private short AV21marcaID ;
      private short AV23modelsID ;
      private short A20ProcID ;
      private short A6MarcaID ;
      private short A7ModeloID ;
      private int A106facturaNro ;
      private String scmdbuf ;
      private String A56ClienteRUC ;
      private String A57ClienteDsc ;
      private String A74protDsc ;
      private String A104tipOrdDsc ;
      private String A72vendedorDsc ;
      private String A115OrdenEst ;
      private String AV20marcaDsc ;
      private String AV22modelDsc ;
      private String AV27proceso ;
      private String AV13estado ;
      private String A130ProcEst ;
      private String A128ProcDsc ;
      private String A63MarcaEst ;
      private String A62MarcaDsc ;
      private String A64ModeloDsc ;
      private DateTime GXt_dtime1 ;
      private DateTime AV14fchDesde ;
      private DateTime AV15fchHasta ;
      private DateTime A119OrdenFch ;
      private DateTime A172OrdenfchEnt ;
      private bool n133OrdenProceso ;
      private bool n119OrdenFch ;
      private bool n56ClienteRUC ;
      private bool n57ClienteDsc ;
      private bool n106facturaNro ;
      private bool n69VehiculoChasis ;
      private bool n68VehiculoPlaca ;
      private bool n74protDsc ;
      private bool n104tipOrdDsc ;
      private bool n72vendedorDsc ;
      private bool n115OrdenEst ;
      private bool n172OrdenfchEnt ;
      private bool returnInSub ;
      private bool n129ProcAbre ;
      private bool n130ProcEst ;
      private bool n128ProcDsc ;
      private bool n63MarcaEst ;
      private bool n62MarcaDsc ;
      private bool n64ModeloDsc ;
      private String AV26OrdenProceso ;
      private String AV9archivo ;
      private String AV24nombre ;
      private String A133OrdenProceso ;
      private String A69VehiculoChasis ;
      private String A68VehiculoPlaca ;
      private String AV8abreProc ;
      private String AV31mesName ;
      private String A129ProcAbre ;
      private String AV12ErrorMessage ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P000N2_A8VehiculoID ;
      private short[] P000N2_A10protID ;
      private short[] P000N2_A17tipOrdID ;
      private String[] P000N2_A133OrdenProceso ;
      private bool[] P000N2_n133OrdenProceso ;
      private short[] P000N2_A9vendedorID ;
      private short[] P000N2_A22OrdenID ;
      private short[] P000N2_A5ClienteID ;
      private DateTime[] P000N2_A119OrdenFch ;
      private bool[] P000N2_n119OrdenFch ;
      private short[] P000N2_A1EmpID ;
      private String[] P000N2_A56ClienteRUC ;
      private bool[] P000N2_n56ClienteRUC ;
      private String[] P000N2_A57ClienteDsc ;
      private bool[] P000N2_n57ClienteDsc ;
      private int[] P000N2_A106facturaNro ;
      private bool[] P000N2_n106facturaNro ;
      private String[] P000N2_A69VehiculoChasis ;
      private bool[] P000N2_n69VehiculoChasis ;
      private String[] P000N2_A68VehiculoPlaca ;
      private bool[] P000N2_n68VehiculoPlaca ;
      private short[] P000N2_A26OrdenMarcaID ;
      private short[] P000N2_A117OrdenModeloID ;
      private String[] P000N2_A74protDsc ;
      private bool[] P000N2_n74protDsc ;
      private String[] P000N2_A104tipOrdDsc ;
      private bool[] P000N2_n104tipOrdDsc ;
      private String[] P000N2_A72vendedorDsc ;
      private bool[] P000N2_n72vendedorDsc ;
      private String[] P000N2_A115OrdenEst ;
      private bool[] P000N2_n115OrdenEst ;
      private DateTime[] P000N2_A172OrdenfchEnt ;
      private bool[] P000N2_n172OrdenfchEnt ;
      private short[] P000N2_A24OrdenPeriodo ;
      private short[] P000N2_A25OrdenAnio ;
      private String[] P000N3_A129ProcAbre ;
      private bool[] P000N3_n129ProcAbre ;
      private String[] P000N3_A130ProcEst ;
      private bool[] P000N3_n130ProcEst ;
      private String[] P000N3_A128ProcDsc ;
      private bool[] P000N3_n128ProcDsc ;
      private short[] P000N3_A20ProcID ;
      private short[] P000N4_A6MarcaID ;
      private short[] P000N4_A1EmpID ;
      private String[] P000N4_A63MarcaEst ;
      private bool[] P000N4_n63MarcaEst ;
      private String[] P000N4_A62MarcaDsc ;
      private bool[] P000N4_n62MarcaDsc ;
      private short[] P000N5_A7ModeloID ;
      private short[] P000N5_A6MarcaID ;
      private short[] P000N5_A1EmpID ;
      private String[] P000N5_A64ModeloDsc ;
      private bool[] P000N5_n64ModeloDsc ;
      private String aP7_archivo ;
      private ExcelDocumentI AV16Hoja ;
      private GeneXus.Core.genexus.common.ui.SdtProgress AV28ProgressIndicator ;
   }

   public class exclistaordenproduccion__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P000N2( IGxContext context ,
                                             short AV10clientID ,
                                             short AV25ordenID ,
                                             short AV30vendedorID ,
                                             String AV26OrdenProceso ,
                                             short A5ClienteID ,
                                             short A22OrdenID ,
                                             short A9vendedorID ,
                                             String A133OrdenProceso ,
                                             DateTime A119OrdenFch ,
                                             DateTime AV14fchDesde ,
                                             DateTime AV15fchHasta ,
                                             short AV11empID ,
                                             short A1EmpID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [7] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT T1.[VehiculoID], T1.[protID], T1.[tipOrdID], T1.[OrdenProceso], T1.[vendedorID], T1.[OrdenID], T1.[ClienteID], T1.[OrdenFch], T1.[EmpID], T2.[ClienteRUC], T2.[ClienteDsc], T1.[facturaNro], T3.[VehiculoChasis], T3.[VehiculoPlaca], T1.[OrdenMarcaID], T1.[OrdenModeloID], T5.[protDsc], T6.[tipOrdDsc], T4.[vendedorDsc], T1.[OrdenEst], T1.[OrdenfchEnt], T1.[OrdenPeriodo], T1.[OrdenAnio] FROM ((((([OrdenProduccion] T1 WITH (NOLOCK) INNER JOIN [Clientes] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[ClienteID] = T1.[ClienteID]) INNER JOIN [Vehiculos] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[VehiculoID] = T1.[VehiculoID]) INNER JOIN [Vendedor] T4 WITH (NOLOCK) ON T4.[EmpID] = T1.[EmpID] AND T4.[vendedorID] = T1.[vendedorID]) INNER JOIN [Prototipo] T5 WITH (NOLOCK) ON T5.[EmpID] = T1.[EmpID] AND T5.[protID] = T1.[protID]) INNER JOIN [TipoOrdenPro] T6 WITH (NOLOCK) ON T6.[EmpID] = T1.[EmpID] AND T6.[tipOrdID] = T1.[tipOrdID])";
         scmdbuf = scmdbuf + " WHERE (T1.[EmpID] = @AV11empID)";
         scmdbuf = scmdbuf + " and (T1.[OrdenFch] >= @AV14fchDesde and T1.[OrdenFch] <= @AV15fchHasta)";
         if ( ! (0==AV10clientID) )
         {
            sWhereString = sWhereString + " and (T1.[ClienteID] = @AV10clientID)";
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( ! (0==AV25ordenID) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenID] = @AV25ordenID)";
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( ! (0==AV30vendedorID) )
         {
            sWhereString = sWhereString + " and (T1.[vendedorID] = @AV30vendedorID)";
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26OrdenProceso)) )
         {
            sWhereString = sWhereString + " and (T1.[OrdenProceso] = @AV26OrdenProceso)";
         }
         else
         {
            GXv_int2[6] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY T1.[EmpID]";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P000N2(context, (short)dynConstraints[0] , (short)dynConstraints[1] , (short)dynConstraints[2] , (String)dynConstraints[3] , (short)dynConstraints[4] , (short)dynConstraints[5] , (short)dynConstraints[6] , (String)dynConstraints[7] , (DateTime)dynConstraints[8] , (DateTime)dynConstraints[9] , (DateTime)dynConstraints[10] , (short)dynConstraints[11] , (short)dynConstraints[12] );
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000N3 ;
          prmP000N3 = new Object[] {
          new Object[] {"@AV8abreProc",SqlDbType.VarChar,5,0}
          } ;
          Object[] prmP000N4 ;
          prmP000N4 = new Object[] {
          new Object[] {"@AV11empID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV21marcaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP000N5 ;
          prmP000N5 = new Object[] {
          new Object[] {"@AV11empID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV21marcaID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV23modelsID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP000N2 ;
          prmP000N2 = new Object[] {
          new Object[] {"@AV11empID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV14fchDesde",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV15fchHasta",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV10clientID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV25ordenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV30vendedorID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV26OrdenProceso",SqlDbType.VarChar,5,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000N2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000N2,100,0,true,false )
             ,new CursorDef("P000N3", "SELECT [ProcAbre], [ProcEst], [ProcDsc], [ProcID] FROM [Procesos] WITH (NOLOCK) WHERE [ProcAbre] = @AV8abreProc ORDER BY [ProcID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000N3,100,0,false,false )
             ,new CursorDef("P000N4", "SELECT [MarcaID], [EmpID], [MarcaEst], [MarcaDsc] FROM [Marca] WITH (NOLOCK) WHERE [EmpID] = @AV11empID and [MarcaID] = @AV21marcaID ORDER BY [EmpID], [MarcaID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000N4,1,0,false,true )
             ,new CursorDef("P000N5", "SELECT [ModeloID], [MarcaID], [EmpID], [ModeloDsc] FROM [MarcaModelo] WITH (NOLOCK) WHERE [EmpID] = @AV11empID and [MarcaID] = @AV21marcaID and [ModeloID] = @AV23modelsID ORDER BY [EmpID], [MarcaID], [ModeloID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000N5,1,0,false,true )
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
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                ((short[]) buf[7])[0] = rslt.getShort(7) ;
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(8) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((short[]) buf[10])[0] = rslt.getShort(9) ;
                ((String[]) buf[11])[0] = rslt.getString(10, 13) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(10);
                ((String[]) buf[13])[0] = rslt.getString(11, 50) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(11);
                ((int[]) buf[15])[0] = rslt.getInt(12) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(12);
                ((String[]) buf[17])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(13);
                ((String[]) buf[19])[0] = rslt.getVarchar(14) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(14);
                ((short[]) buf[21])[0] = rslt.getShort(15) ;
                ((short[]) buf[22])[0] = rslt.getShort(16) ;
                ((String[]) buf[23])[0] = rslt.getString(17, 50) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(17);
                ((String[]) buf[25])[0] = rslt.getString(18, 40) ;
                ((bool[]) buf[26])[0] = rslt.wasNull(18);
                ((String[]) buf[27])[0] = rslt.getString(19, 50) ;
                ((bool[]) buf[28])[0] = rslt.wasNull(19);
                ((String[]) buf[29])[0] = rslt.getString(20, 1) ;
                ((bool[]) buf[30])[0] = rslt.wasNull(20);
                ((DateTime[]) buf[31])[0] = rslt.getGXDate(21) ;
                ((bool[]) buf[32])[0] = rslt.wasNull(21);
                ((short[]) buf[33])[0] = rslt.getShort(22) ;
                ((short[]) buf[34])[0] = rslt.getShort(23) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 1) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getString(3, 40) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((short[]) buf[6])[0] = rslt.getShort(4) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getString(4, 50) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
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
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[7]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[8]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[9]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[10]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[11]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[12]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                return;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
       }
    }

 }

}
