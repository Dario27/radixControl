/*
               File: prcDuplicarCotizacion
        Description: prc Duplicar Cotizacion
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 11/19/2022 22:52:49.23
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
   public class prcduplicarcotizacion : GXProcedure
   {
      public prcduplicarcotizacion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public prcduplicarcotizacion( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_empID ,
                           short aP1_cotiID ,
                           out short aP2_newCotiID )
      {
         this.AV10empID = aP0_empID;
         this.AV8cotiID = aP1_cotiID;
         this.AV11newCotiID = 0 ;
         initialize();
         executePrivate();
         aP2_newCotiID=this.AV11newCotiID;
      }

      public short executeUdp( short aP0_empID ,
                               short aP1_cotiID )
      {
         this.AV10empID = aP0_empID;
         this.AV8cotiID = aP1_cotiID;
         this.AV11newCotiID = 0 ;
         initialize();
         executePrivate();
         aP2_newCotiID=this.AV11newCotiID;
         return AV11newCotiID ;
      }

      public void executeSubmit( short aP0_empID ,
                                 short aP1_cotiID ,
                                 out short aP2_newCotiID )
      {
         prcduplicarcotizacion objprcduplicarcotizacion;
         objprcduplicarcotizacion = new prcduplicarcotizacion();
         objprcduplicarcotizacion.AV10empID = aP0_empID;
         objprcduplicarcotizacion.AV8cotiID = aP1_cotiID;
         objprcduplicarcotizacion.AV11newCotiID = 0 ;
         objprcduplicarcotizacion.context.SetSubmitInitialConfig(context);
         objprcduplicarcotizacion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objprcduplicarcotizacion);
         aP2_newCotiID=this.AV11newCotiID;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((prcduplicarcotizacion)stateInfo).executePrivate();
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
         /* Execute user subroutine: 'OBTNUEVOID' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         /* Execute user subroutine: 'OBTCOTIZADOR' */
         S121 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         /* Execute user subroutine: 'CREARCABECERANUEVACOTIZACION' */
         S131 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         /* Execute user subroutine: 'OBTDETCOTIZACION' */
         S141 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'OBTNUEVOID' Routine */
         AV11newCotiID = 0;
         /* Using cursor P000T2 */
         pr_default.execute(0, new Object[] {AV10empID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A1EmpID = P000T2_A1EmpID[0];
            A182CotiObs = P000T2_A182CotiObs[0];
            n182CotiObs = P000T2_n182CotiObs[0];
            A34CotiID = P000T2_A34CotiID[0];
            AV9cotiID1 = A34CotiID;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV11newCotiID = (short)(AV9cotiID1+1);
      }

      protected void S121( )
      {
         /* 'OBTCOTIZADOR' Routine */
         /* Using cursor P000T3 */
         pr_default.execute(1, new Object[] {AV10empID, AV8cotiID});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A34CotiID = P000T3_A34CotiID[0];
            A1EmpID = P000T3_A1EmpID[0];
            A154CotiDsc = P000T3_A154CotiDsc[0];
            n154CotiDsc = P000T3_n154CotiDsc[0];
            A10protID = P000T3_A10protID[0];
            A155CotiIVA = P000T3_A155CotiIVA[0];
            n155CotiIVA = P000T3_n155CotiIVA[0];
            A156CotiUltNro = P000T3_A156CotiUltNro[0];
            n156CotiUltNro = P000T3_n156CotiUltNro[0];
            A182CotiObs = P000T3_A182CotiObs[0];
            n182CotiObs = P000T3_n182CotiObs[0];
            A181TotNeto = P000T3_A181TotNeto[0];
            n181TotNeto = P000T3_n181TotNeto[0];
            AV12CotiDsc = A154CotiDsc;
            AV15protID = A10protID;
            AV13CotiIVA = A155CotiIVA;
            AV14CotiUltNro = A156CotiUltNro;
            AV16CotiObs = A182CotiObs;
            AV25TotNeto = A181TotNeto;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(1);
      }

      protected void S131( )
      {
         /* 'CREARCABECERANUEVACOTIZACION' Routine */
         /*
            INSERT RECORD ON TABLE Cotizador

         */
         A1EmpID = AV10empID;
         A34CotiID = AV11newCotiID;
         A154CotiDsc = AV12CotiDsc + "_copy";
         n154CotiDsc = false;
         A10protID = AV15protID;
         A155CotiIVA = AV13CotiIVA;
         n155CotiIVA = false;
         A156CotiUltNro = AV14CotiUltNro;
         n156CotiUltNro = false;
         A182CotiObs = AV16CotiObs;
         n182CotiObs = false;
         A181TotNeto = AV25TotNeto;
         n181TotNeto = false;
         /* Using cursor P000T4 */
         pr_default.execute(2, new Object[] {A1EmpID, A34CotiID, n154CotiDsc, A154CotiDsc, A10protID, n155CotiIVA, A155CotiIVA, n156CotiUltNro, A156CotiUltNro, n182CotiObs, A182CotiObs, n181TotNeto, A181TotNeto});
         pr_default.close(2);
         dsDefault.SmartCacheProvider.SetUpdated("Cotizador") ;
         if ( (pr_default.getStatus(2) == 1) )
         {
            context.Gx_err = 1;
            Gx_emsg = (String)(context.GetMessage( "GXM_noupdate", ""));
         }
         else
         {
            context.Gx_err = 0;
            Gx_emsg = "";
         }
         /* End Insert */
         context.CommitDataStores("prcduplicarcotizacion",pr_default);
      }

      protected void S141( )
      {
         /* 'OBTDETCOTIZACION' Routine */
         /* Using cursor P000T5 */
         pr_default.execute(3, new Object[] {AV10empID, AV8cotiID});
         while ( (pr_default.getStatus(3) != 101) )
         {
            A34CotiID = P000T5_A34CotiID[0];
            A1EmpID = P000T5_A1EmpID[0];
            A35secID = P000T5_A35secID[0];
            A36detTipoProdID = P000T5_A36detTipoProdID[0];
            A32categID = P000T5_A32categID[0];
            A33subCatID = P000T5_A33subCatID[0];
            A155CotiIVA = P000T5_A155CotiIVA[0];
            n155CotiIVA = P000T5_n155CotiIVA[0];
            A150subCatPrec = P000T5_A150subCatPrec[0];
            n150subCatPrec = P000T5_n150subCatPrec[0];
            A157CotiDetCant = P000T5_A157CotiDetCant[0];
            n157CotiDetCant = P000T5_n157CotiDetCant[0];
            A155CotiIVA = P000T5_A155CotiIVA[0];
            n155CotiIVA = P000T5_n155CotiIVA[0];
            A150subCatPrec = P000T5_A150subCatPrec[0];
            n150subCatPrec = P000T5_n150subCatPrec[0];
            A158CotiDetValor = (decimal)(A150subCatPrec*A157CotiDetCant);
            A159CotiDetIva = (decimal)(((A158CotiDetValor*A155CotiIVA)/ (decimal)(100)));
            A160CotiDetTotal = NumberUtil.Round( (A158CotiDetValor+A159CotiDetIva), 2);
            AV17secID = A35secID;
            AV18detTipoProdID = A36detTipoProdID;
            AV19categID = A32categID;
            AV20subCatID = A33subCatID;
            AV21CotiDetCant = A157CotiDetCant;
            AV22CotiDetValor = A158CotiDetValor;
            AV23CotiDetIva = A159CotiDetIva;
            AV24CotiDetTotal = A160CotiDetTotal;
            /* Execute user subroutine: 'CREARDETNUEVACOTIZACION' */
            S155 ();
            if ( returnInSub )
            {
               pr_default.close(3);
               returnInSub = true;
               if (true) return;
            }
            pr_default.readNext(3);
         }
         pr_default.close(3);
      }

      protected void S155( )
      {
         /* 'CREARDETNUEVACOTIZACION' Routine */
         /*
            INSERT RECORD ON TABLE CotizadorLevel1

         */
         A1EmpID = AV10empID;
         A34CotiID = AV11newCotiID;
         A35secID = AV17secID;
         A36detTipoProdID = AV18detTipoProdID;
         A32categID = AV19categID;
         A33subCatID = AV20subCatID;
         A157CotiDetCant = AV21CotiDetCant;
         n157CotiDetCant = false;
         /* Using cursor P000T6 */
         pr_default.execute(4, new Object[] {A1EmpID, A34CotiID, A35secID, A36detTipoProdID, A32categID, A33subCatID, n157CotiDetCant, A157CotiDetCant});
         pr_default.close(4);
         dsDefault.SmartCacheProvider.SetUpdated("CotizadorLevel1") ;
         if ( (pr_default.getStatus(4) == 1) )
         {
            context.Gx_err = 1;
            Gx_emsg = (String)(context.GetMessage( "GXM_noupdate", ""));
         }
         else
         {
            context.Gx_err = 0;
            Gx_emsg = "";
         }
         /* End Insert */
         context.CommitDataStores("prcduplicarcotizacion",pr_default);
      }

      public override void cleanup( )
      {
         context.CommitDataStores("prcduplicarcotizacion",pr_default);
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
         P000T2_A1EmpID = new short[1] ;
         P000T2_A182CotiObs = new String[] {""} ;
         P000T2_n182CotiObs = new bool[] {false} ;
         P000T2_A34CotiID = new short[1] ;
         A182CotiObs = "";
         P000T3_A34CotiID = new short[1] ;
         P000T3_A1EmpID = new short[1] ;
         P000T3_A154CotiDsc = new String[] {""} ;
         P000T3_n154CotiDsc = new bool[] {false} ;
         P000T3_A10protID = new short[1] ;
         P000T3_A155CotiIVA = new decimal[1] ;
         P000T3_n155CotiIVA = new bool[] {false} ;
         P000T3_A156CotiUltNro = new int[1] ;
         P000T3_n156CotiUltNro = new bool[] {false} ;
         P000T3_A182CotiObs = new String[] {""} ;
         P000T3_n182CotiObs = new bool[] {false} ;
         P000T3_A181TotNeto = new decimal[1] ;
         P000T3_n181TotNeto = new bool[] {false} ;
         A154CotiDsc = "";
         AV12CotiDsc = "";
         AV16CotiObs = "";
         Gx_emsg = "";
         P000T5_A34CotiID = new short[1] ;
         P000T5_A1EmpID = new short[1] ;
         P000T5_A35secID = new short[1] ;
         P000T5_A36detTipoProdID = new short[1] ;
         P000T5_A32categID = new short[1] ;
         P000T5_A33subCatID = new short[1] ;
         P000T5_A155CotiIVA = new decimal[1] ;
         P000T5_n155CotiIVA = new bool[] {false} ;
         P000T5_A150subCatPrec = new decimal[1] ;
         P000T5_n150subCatPrec = new bool[] {false} ;
         P000T5_A157CotiDetCant = new decimal[1] ;
         P000T5_n157CotiDetCant = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.prcduplicarcotizacion__default(),
            new Object[][] {
                new Object[] {
               P000T2_A1EmpID, P000T2_A182CotiObs, P000T2_n182CotiObs, P000T2_A34CotiID
               }
               , new Object[] {
               P000T3_A34CotiID, P000T3_A1EmpID, P000T3_A154CotiDsc, P000T3_n154CotiDsc, P000T3_A10protID, P000T3_A155CotiIVA, P000T3_n155CotiIVA, P000T3_A156CotiUltNro, P000T3_n156CotiUltNro, P000T3_A182CotiObs,
               P000T3_n182CotiObs, P000T3_A181TotNeto, P000T3_n181TotNeto
               }
               , new Object[] {
               }
               , new Object[] {
               P000T5_A34CotiID, P000T5_A1EmpID, P000T5_A35secID, P000T5_A36detTipoProdID, P000T5_A32categID, P000T5_A33subCatID, P000T5_A155CotiIVA, P000T5_n155CotiIVA, P000T5_A150subCatPrec, P000T5_n150subCatPrec,
               P000T5_A157CotiDetCant, P000T5_n157CotiDetCant
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV10empID ;
      private short AV8cotiID ;
      private short AV11newCotiID ;
      private short A1EmpID ;
      private short A34CotiID ;
      private short AV9cotiID1 ;
      private short A10protID ;
      private short AV15protID ;
      private short A35secID ;
      private short A36detTipoProdID ;
      private short A32categID ;
      private short A33subCatID ;
      private short AV17secID ;
      private short AV18detTipoProdID ;
      private short AV19categID ;
      private short AV20subCatID ;
      private int A156CotiUltNro ;
      private int AV14CotiUltNro ;
      private int GX_INS28 ;
      private int GX_INS29 ;
      private decimal A155CotiIVA ;
      private decimal A181TotNeto ;
      private decimal AV13CotiIVA ;
      private decimal AV25TotNeto ;
      private decimal A150subCatPrec ;
      private decimal A157CotiDetCant ;
      private decimal A158CotiDetValor ;
      private decimal A159CotiDetIva ;
      private decimal A160CotiDetTotal ;
      private decimal AV21CotiDetCant ;
      private decimal AV22CotiDetValor ;
      private decimal AV23CotiDetIva ;
      private decimal AV24CotiDetTotal ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private bool returnInSub ;
      private bool n182CotiObs ;
      private bool n154CotiDsc ;
      private bool n155CotiIVA ;
      private bool n156CotiUltNro ;
      private bool n181TotNeto ;
      private bool n150subCatPrec ;
      private bool n157CotiDetCant ;
      private String A182CotiObs ;
      private String A154CotiDsc ;
      private String AV12CotiDsc ;
      private String AV16CotiObs ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P000T2_A1EmpID ;
      private String[] P000T2_A182CotiObs ;
      private bool[] P000T2_n182CotiObs ;
      private short[] P000T2_A34CotiID ;
      private short[] P000T3_A34CotiID ;
      private short[] P000T3_A1EmpID ;
      private String[] P000T3_A154CotiDsc ;
      private bool[] P000T3_n154CotiDsc ;
      private short[] P000T3_A10protID ;
      private decimal[] P000T3_A155CotiIVA ;
      private bool[] P000T3_n155CotiIVA ;
      private int[] P000T3_A156CotiUltNro ;
      private bool[] P000T3_n156CotiUltNro ;
      private String[] P000T3_A182CotiObs ;
      private bool[] P000T3_n182CotiObs ;
      private decimal[] P000T3_A181TotNeto ;
      private bool[] P000T3_n181TotNeto ;
      private short[] P000T5_A34CotiID ;
      private short[] P000T5_A1EmpID ;
      private short[] P000T5_A35secID ;
      private short[] P000T5_A36detTipoProdID ;
      private short[] P000T5_A32categID ;
      private short[] P000T5_A33subCatID ;
      private decimal[] P000T5_A155CotiIVA ;
      private bool[] P000T5_n155CotiIVA ;
      private decimal[] P000T5_A150subCatPrec ;
      private bool[] P000T5_n150subCatPrec ;
      private decimal[] P000T5_A157CotiDetCant ;
      private bool[] P000T5_n157CotiDetCant ;
      private short aP2_newCotiID ;
   }

   public class prcduplicarcotizacion__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new UpdateCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new UpdateCursor(def[4])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000T2 ;
          prmP000T2 = new Object[] {
          new Object[] {"@AV10empID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP000T3 ;
          prmP000T3 = new Object[] {
          new Object[] {"@AV10empID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8cotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP000T4 ;
          prmP000T4 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiDsc",SqlDbType.VarChar,100,0} ,
          new Object[] {"@protID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiIVA",SqlDbType.Decimal,8,3} ,
          new Object[] {"@CotiUltNro",SqlDbType.Int,8,0} ,
          new Object[] {"@CotiObs",SqlDbType.VarChar,120,0} ,
          new Object[] {"@TotNeto",SqlDbType.Decimal,10,2}
          } ;
          Object[] prmP000T5 ;
          prmP000T5 = new Object[] {
          new Object[] {"@AV10empID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8cotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP000T6 ;
          prmP000T6 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@secID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiDetCant",SqlDbType.Decimal,10,2}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000T2", "SELECT TOP 1 [EmpID], [CotiObs], [CotiID] FROM [Cotizador] WITH (NOLOCK) WHERE [EmpID] = @AV10empID ORDER BY [EmpID] DESC, [CotiID] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000T2,1,0,false,true )
             ,new CursorDef("P000T3", "SELECT [CotiID], [EmpID], [CotiDsc], [protID], [CotiIVA], [CotiUltNro], [CotiObs], [TotNeto] FROM [Cotizador] WITH (NOLOCK) WHERE [EmpID] = @AV10empID and [CotiID] = @AV8cotiID ORDER BY [EmpID], [CotiID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000T3,1,0,false,true )
             ,new CursorDef("P000T4", "INSERT INTO [Cotizador]([EmpID], [CotiID], [CotiDsc], [protID], [CotiIVA], [CotiUltNro], [CotiObs], [TotNeto], [CotiUltNroObr]) VALUES(@EmpID, @CotiID, @CotiDsc, @protID, @CotiIVA, @CotiUltNro, @CotiObs, @TotNeto, convert(int, 0))", GxErrorMask.GX_NOMASK,prmP000T4)
             ,new CursorDef("P000T5", "SELECT T1.[CotiID], T1.[EmpID], T1.[secID], T1.[detTipoProdID], T1.[categID], T1.[subCatID], T2.[CotiIVA], T3.[subCatPrec], T1.[CotiDetCant] FROM (([CotizadorLevel1] T1 WITH (NOLOCK) INNER JOIN [Cotizador] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[CotiID] = T1.[CotiID]) INNER JOIN [CategoriassubCat] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[categID] = T1.[categID] AND T3.[subCatID] = T1.[subCatID]) WHERE T1.[EmpID] = @AV10empID and T1.[CotiID] = @AV8cotiID ORDER BY T1.[EmpID], T1.[CotiID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000T5,100,0,true,false )
             ,new CursorDef("P000T6", "INSERT INTO [CotizadorLevel1]([EmpID], [CotiID], [secID], [detTipoProdID], [categID], [subCatID], [CotiDetCant]) VALUES(@EmpID, @CotiID, @secID, @detTipoProdID, @categID, @subCatID, @CotiDetCant)", GxErrorMask.GX_NOMASK,prmP000T6)
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
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((int[]) buf[7])[0] = rslt.getInt(6) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                ((String[]) buf[9])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(7);
                ((decimal[]) buf[11])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(8);
                return;
             case 3 :
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
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 3 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[3]);
                }
                stmt.SetParameter(4, (short)parms[4]);
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 5 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(5, (decimal)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 6 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(6, (int)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 7 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 8 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(8, (decimal)parms[12]);
                }
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 7 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(7, (decimal)parms[7]);
                }
                return;
       }
    }

 }

}
