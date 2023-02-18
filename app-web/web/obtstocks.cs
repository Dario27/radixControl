/*
               File: obtStocks
        Description: obt Stocks
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/9/2023 12:19:44.2
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
   public class obtstocks : GXProcedure
   {
      public obtstocks( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public obtstocks( IGxContext context )
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
                           short aP2_empcod ,
                           short aP3_PrdCod ,
                           short aP4_agecod ,
                           short aP5_BodCod ,
                           out short aP6_DispBod )
      {
         this.A290stockAnio = aP0_stockAnio;
         this.A291stockMes = aP1_stockMes;
         this.A15empcod = aP2_empcod;
         this.A286PrdCod = aP3_PrdCod;
         this.A16agecod = aP4_agecod;
         this.A42BodCod = aP5_BodCod;
         this.AV8DispBod = 0 ;
         initialize();
         executePrivate();
         aP6_DispBod=this.AV8DispBod;
      }

      public short executeUdp( short aP0_stockAnio ,
                               short aP1_stockMes ,
                               short aP2_empcod ,
                               short aP3_PrdCod ,
                               short aP4_agecod ,
                               short aP5_BodCod )
      {
         this.A290stockAnio = aP0_stockAnio;
         this.A291stockMes = aP1_stockMes;
         this.A15empcod = aP2_empcod;
         this.A286PrdCod = aP3_PrdCod;
         this.A16agecod = aP4_agecod;
         this.A42BodCod = aP5_BodCod;
         this.AV8DispBod = 0 ;
         initialize();
         executePrivate();
         aP6_DispBod=this.AV8DispBod;
         return AV8DispBod ;
      }

      public void executeSubmit( short aP0_stockAnio ,
                                 short aP1_stockMes ,
                                 short aP2_empcod ,
                                 short aP3_PrdCod ,
                                 short aP4_agecod ,
                                 short aP5_BodCod ,
                                 out short aP6_DispBod )
      {
         obtstocks objobtstocks;
         objobtstocks = new obtstocks();
         objobtstocks.A290stockAnio = aP0_stockAnio;
         objobtstocks.A291stockMes = aP1_stockMes;
         objobtstocks.A15empcod = aP2_empcod;
         objobtstocks.A286PrdCod = aP3_PrdCod;
         objobtstocks.A16agecod = aP4_agecod;
         objobtstocks.A42BodCod = aP5_BodCod;
         objobtstocks.AV8DispBod = 0 ;
         objobtstocks.context.SetSubmitInitialConfig(context);
         objobtstocks.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objobtstocks);
         aP6_DispBod=this.AV8DispBod;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((obtstocks)stateInfo).executePrivate();
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
         AV8DispBod = 0;
         /* Using cursor P00164 */
         pr_default.execute(0, new Object[] {A290stockAnio, A291stockMes, A42BodCod, A286PrdCod});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A1EmpID = P00164_A1EmpID[0];
            A2AgeID = P00164_A2AgeID[0];
            A295egrBod = P00164_A295egrBod[0];
            n295egrBod = P00164_n295egrBod[0];
            A294ingBod = P00164_A294ingBod[0];
            n294ingBod = P00164_n294ingBod[0];
            A293invFisico = P00164_A293invFisico[0];
            n293invFisico = P00164_n293invFisico[0];
            A294ingBod = P00164_A294ingBod[0];
            n294ingBod = P00164_n294ingBod[0];
            A295egrBod = P00164_A295egrBod[0];
            n295egrBod = P00164_n295egrBod[0];
            A292stockBod = NumberUtil.Round( ((A293invFisico+A294ingBod)-A295egrBod), 2);
            AV8DispBod = (short)(A292stockBod);
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
         P00164_A1EmpID = new short[1] ;
         P00164_A2AgeID = new short[1] ;
         P00164_A290stockAnio = new short[1] ;
         P00164_A291stockMes = new short[1] ;
         P00164_A42BodCod = new short[1] ;
         P00164_A286PrdCod = new short[1] ;
         P00164_A295egrBod = new decimal[1] ;
         P00164_n295egrBod = new bool[] {false} ;
         P00164_A294ingBod = new decimal[1] ;
         P00164_n294ingBod = new bool[] {false} ;
         P00164_A293invFisico = new decimal[1] ;
         P00164_n293invFisico = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.obtstocks__default(),
            new Object[][] {
                new Object[] {
               P00164_A1EmpID, P00164_A2AgeID, P00164_A290stockAnio, P00164_A291stockMes, P00164_A42BodCod, P00164_A286PrdCod, P00164_A295egrBod, P00164_n295egrBod, P00164_A294ingBod, P00164_n294ingBod,
               P00164_A293invFisico, P00164_n293invFisico
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A290stockAnio ;
      private short A291stockMes ;
      private short A15empcod ;
      private short A286PrdCod ;
      private short A16agecod ;
      private short A42BodCod ;
      private short AV8DispBod ;
      private short A1EmpID ;
      private short A2AgeID ;
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
      private short[] P00164_A1EmpID ;
      private short[] P00164_A2AgeID ;
      private short[] P00164_A290stockAnio ;
      private short[] P00164_A291stockMes ;
      private short[] P00164_A42BodCod ;
      private short[] P00164_A286PrdCod ;
      private decimal[] P00164_A295egrBod ;
      private bool[] P00164_n295egrBod ;
      private decimal[] P00164_A294ingBod ;
      private bool[] P00164_n294ingBod ;
      private decimal[] P00164_A293invFisico ;
      private bool[] P00164_n293invFisico ;
      private short aP6_DispBod ;
   }

   public class obtstocks__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00164 ;
          prmP00164 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00164", "SELECT T1.[EmpID], T1.[AgeID], T1.[stockAnio], T1.[stockMes], T1.[BodCod], T1.[PrdCod], COALESCE( T3.[egrBod], 0) AS egrBod, COALESCE( T2.[ingBod], 0) AS ingBod, T1.[invFisico] FROM (([ProdxBodega] T1 WITH (NOLOCK) LEFT JOIN (SELECT SUM(CASE  WHEN COALESCE( T5.[TipoInvSigno], 0) = 1 THEN COALESCE( T4.[ingCantidad], 0) ELSE 0 END) AS ingBod, T4.[stockAnio], T4.[stockMes], T4.[EmpID], T4.[AgeID], T4.[BodCod], T4.[PrdCod] FROM ([ProdStockBodegastockDetEgr] T4 WITH (NOLOCK) INNER JOIN [TipoMovimiento] T5 WITH (NOLOCK) ON T5.[TipoInv] = T4.[ingTipoInv]) GROUP BY T4.[stockAnio], T4.[stockMes], T4.[EmpID], T4.[AgeID], T4.[BodCod], T4.[PrdCod] ) T2 ON T2.[stockAnio] = T1.[stockAnio] AND T2.[stockMes] = T1.[stockMes] AND T2.[EmpID] = T1.[EmpID] AND T2.[AgeID] = T1.[AgeID] AND T2.[BodCod] = T1.[BodCod] AND T2.[PrdCod] = T1.[PrdCod]) LEFT JOIN (SELECT SUM(CASE  WHEN COALESCE( T5.[TipoInvSigno], 0) = -1 THEN COALESCE( T4.[cantidad], 0) ELSE 0 END) AS egrBod, T4.[stockAnio], T4.[stockMes], T4.[EmpID], T4.[AgeID], T4.[BodCod], T4.[PrdCod] FROM ([ProdxBodegaTipoInv] T4 WITH (NOLOCK) INNER JOIN [TipoMovimiento] T5 WITH (NOLOCK) ON T5.[TipoInv] = T4.[TipoInv]) GROUP BY T4.[stockAnio], T4.[stockMes], T4.[EmpID], T4.[AgeID], T4.[BodCod], T4.[PrdCod] ) T3 ON T3.[stockAnio] = T1.[stockAnio] AND T3.[stockMes] = T1.[stockMes] AND T3.[EmpID] = T1.[EmpID] AND T3.[AgeID] = T1.[AgeID] AND T3.[BodCod] = T1.[BodCod] AND T3.[PrdCod] = T1.[PrdCod]) WHERE (T1.[stockAnio] = @stockAnio and T1.[stockMes] = @stockMes) AND (T1.[BodCod] = @BodCod) AND (T1.[PrdCod] = @PrdCod) ORDER BY T1.[stockAnio], T1.[stockMes] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00164,100,0,false,false )
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
