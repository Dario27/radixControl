/*
               File: prcBusStock
        Description: prc Bus Stock
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/9/2023 12:19:43.83
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
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class prcbusstock : GXProcedure
   {
      public prcbusstock( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public prcbusstock( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_stockAnio ,
                           short aP1_stockMes ,
                           short aP2_EmpID ,
                           short aP3_AgeID ,
                           short aP4_BodCod ,
                           short aP5_PrdCod ,
                           out decimal aP6_BodStock )
      {
         this.AV9stockAnio = aP0_stockAnio;
         this.AV10stockMes = aP1_stockMes;
         this.A1EmpID = aP2_EmpID;
         this.A2AgeID = aP3_AgeID;
         this.A42BodCod = aP4_BodCod;
         this.A286PrdCod = aP5_PrdCod;
         this.AV8BodStock = 0 ;
         initialize();
         executePrivate();
         aP6_BodStock=this.AV8BodStock;
      }

      public decimal executeUdp( short aP0_stockAnio ,
                                 short aP1_stockMes ,
                                 short aP2_EmpID ,
                                 short aP3_AgeID ,
                                 short aP4_BodCod ,
                                 short aP5_PrdCod )
      {
         this.AV9stockAnio = aP0_stockAnio;
         this.AV10stockMes = aP1_stockMes;
         this.A1EmpID = aP2_EmpID;
         this.A2AgeID = aP3_AgeID;
         this.A42BodCod = aP4_BodCod;
         this.A286PrdCod = aP5_PrdCod;
         this.AV8BodStock = 0 ;
         initialize();
         executePrivate();
         aP6_BodStock=this.AV8BodStock;
         return AV8BodStock ;
      }

      public void executeSubmit( short aP0_stockAnio ,
                                 short aP1_stockMes ,
                                 short aP2_EmpID ,
                                 short aP3_AgeID ,
                                 short aP4_BodCod ,
                                 short aP5_PrdCod ,
                                 out decimal aP6_BodStock )
      {
         prcbusstock objprcbusstock;
         objprcbusstock = new prcbusstock();
         objprcbusstock.AV9stockAnio = aP0_stockAnio;
         objprcbusstock.AV10stockMes = aP1_stockMes;
         objprcbusstock.A1EmpID = aP2_EmpID;
         objprcbusstock.A2AgeID = aP3_AgeID;
         objprcbusstock.A42BodCod = aP4_BodCod;
         objprcbusstock.A286PrdCod = aP5_PrdCod;
         objprcbusstock.AV8BodStock = 0 ;
         objprcbusstock.context.SetSubmitInitialConfig(context);
         objprcbusstock.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objprcbusstock);
         aP6_BodStock=this.AV8BodStock;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((prcbusstock)stateInfo).executePrivate();
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
         /* Using cursor P001B4 */
         pr_default.execute(0, new Object[] {A1EmpID, A2AgeID, A286PrdCod, A42BodCod});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A290stockAnio = P001B4_A290stockAnio[0];
            A291stockMes = P001B4_A291stockMes[0];
            A295egrBod = P001B4_A295egrBod[0];
            n295egrBod = P001B4_n295egrBod[0];
            A294ingBod = P001B4_A294ingBod[0];
            n294ingBod = P001B4_n294ingBod[0];
            A293invFisico = P001B4_A293invFisico[0];
            n293invFisico = P001B4_n293invFisico[0];
            A294ingBod = P001B4_A294ingBod[0];
            n294ingBod = P001B4_n294ingBod[0];
            A295egrBod = P001B4_A295egrBod[0];
            n295egrBod = P001B4_n295egrBod[0];
            A292stockBod = NumberUtil.Round( ((A293invFisico+A294ingBod)-A295egrBod), 2);
            AV8BodStock = A292stockBod;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         this.cleanup();
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
         scmdbuf = "";
         P001B4_A290stockAnio = new short[1] ;
         P001B4_A291stockMes = new short[1] ;
         P001B4_A1EmpID = new short[1] ;
         P001B4_A2AgeID = new short[1] ;
         P001B4_A42BodCod = new short[1] ;
         P001B4_A286PrdCod = new short[1] ;
         P001B4_A295egrBod = new decimal[1] ;
         P001B4_n295egrBod = new bool[] {false} ;
         P001B4_A294ingBod = new decimal[1] ;
         P001B4_n294ingBod = new bool[] {false} ;
         P001B4_A293invFisico = new decimal[1] ;
         P001B4_n293invFisico = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.prcbusstock__default(),
            new Object[][] {
                new Object[] {
               P001B4_A290stockAnio, P001B4_A291stockMes, P001B4_A1EmpID, P001B4_A2AgeID, P001B4_A42BodCod, P001B4_A286PrdCod, P001B4_A295egrBod, P001B4_n295egrBod, P001B4_A294ingBod, P001B4_n294ingBod,
               P001B4_A293invFisico, P001B4_n293invFisico
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV9stockAnio ;
      private short AV10stockMes ;
      private short A1EmpID ;
      private short A2AgeID ;
      private short A42BodCod ;
      private short A286PrdCod ;
      private short A290stockAnio ;
      private short A291stockMes ;
      private decimal AV8BodStock ;
      private decimal A295egrBod ;
      private decimal A294ingBod ;
      private decimal A293invFisico ;
      private decimal A292stockBod ;
      private String scmdbuf ;
      private bool n295egrBod ;
      private bool n294ingBod ;
      private bool n293invFisico ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P001B4_A290stockAnio ;
      private short[] P001B4_A291stockMes ;
      private short[] P001B4_A1EmpID ;
      private short[] P001B4_A2AgeID ;
      private short[] P001B4_A42BodCod ;
      private short[] P001B4_A286PrdCod ;
      private decimal[] P001B4_A295egrBod ;
      private bool[] P001B4_n295egrBod ;
      private decimal[] P001B4_A294ingBod ;
      private bool[] P001B4_n294ingBod ;
      private decimal[] P001B4_A293invFisico ;
      private bool[] P001B4_n293invFisico ;
      private decimal aP6_BodStock ;
   }

   public class prcbusstock__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001B4 ;
          prmP001B4 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001B4", "SELECT T1.[stockAnio], T1.[stockMes], T1.[EmpID], T1.[AgeID], T1.[BodCod], T1.[PrdCod], COALESCE( T3.[egrBod], 0) AS egrBod, COALESCE( T2.[ingBod], 0) AS ingBod, T1.[invFisico] FROM (([ProdxBodega] T1 WITH (NOLOCK) LEFT JOIN (SELECT SUM(CASE  WHEN COALESCE( T5.[TipoInvSigno], 0) = 1 THEN COALESCE( T4.[ingCantidad], 0) ELSE 0 END) AS ingBod, T4.[stockAnio], T4.[stockMes], T4.[EmpID], T4.[AgeID], T4.[BodCod], T4.[PrdCod] FROM ([ProdStockBodegastockDetEgr] T4 WITH (NOLOCK) INNER JOIN [TipoMovimiento] T5 WITH (NOLOCK) ON T5.[TipoInv] = T4.[ingTipoInv]) GROUP BY T4.[stockAnio], T4.[stockMes], T4.[EmpID], T4.[AgeID], T4.[BodCod], T4.[PrdCod] ) T2 ON T2.[stockAnio] = T1.[stockAnio] AND T2.[stockMes] = T1.[stockMes] AND T2.[EmpID] = T1.[EmpID] AND T2.[AgeID] = T1.[AgeID] AND T2.[BodCod] = T1.[BodCod] AND T2.[PrdCod] = T1.[PrdCod]) LEFT JOIN (SELECT SUM(CASE  WHEN COALESCE( T5.[TipoInvSigno], 0) = -1 THEN COALESCE( T4.[cantidad], 0) ELSE 0 END) AS egrBod, T4.[stockAnio], T4.[stockMes], T4.[EmpID], T4.[AgeID], T4.[BodCod], T4.[PrdCod] FROM ([ProdxBodegaTipoInv] T4 WITH (NOLOCK) INNER JOIN [TipoMovimiento] T5 WITH (NOLOCK) ON T5.[TipoInv] = T4.[TipoInv]) GROUP BY T4.[stockAnio], T4.[stockMes], T4.[EmpID], T4.[AgeID], T4.[BodCod], T4.[PrdCod] ) T3 ON T3.[stockAnio] = T1.[stockAnio] AND T3.[stockMes] = T1.[stockMes] AND T3.[EmpID] = T1.[EmpID] AND T3.[AgeID] = T1.[AgeID] AND T3.[BodCod] = T1.[BodCod] AND T3.[PrdCod] = T1.[PrdCod]) WHERE (T1.[EmpID] = @EmpID and T1.[AgeID] = @AgeID and T1.[PrdCod] = @PrdCod) AND (T1.[BodCod] = @BodCod) ORDER BY T1.[EmpID], T1.[AgeID], T1.[PrdCod] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001B4,100,0,false,false )
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
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                ((decimal[]) buf[8])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
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
       }
    }

 }

}
