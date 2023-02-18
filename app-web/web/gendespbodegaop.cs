/*
               File: GenDespBodegaOP
        Description: Gen Desp Bodega OP
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/12/2023 22:49:43.38
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
   public class gendespbodegaop : GXProcedure
   {
      public gendespbodegaop( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gendespbodegaop( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_EmpID ,
                           short aP1_AgeID ,
                           short aP2_DespBodOpId ,
                           short aP3_BodCod ,
                           short aP4_DespBodCodPrd ,
                           decimal aP5_DespBodADesp )
      {
         this.AV8EmpID = aP0_EmpID;
         this.AV9AgeID = aP1_AgeID;
         this.AV15DespBodOpId = aP2_DespBodOpId;
         this.AV16BodCod = aP3_BodCod;
         this.AV17DespBodCodPrd = aP4_DespBodCodPrd;
         this.AV14DespBodADesp = aP5_DespBodADesp;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_EmpID ,
                                 short aP1_AgeID ,
                                 short aP2_DespBodOpId ,
                                 short aP3_BodCod ,
                                 short aP4_DespBodCodPrd ,
                                 decimal aP5_DespBodADesp )
      {
         gendespbodegaop objgendespbodegaop;
         objgendespbodegaop = new gendespbodegaop();
         objgendespbodegaop.AV8EmpID = aP0_EmpID;
         objgendespbodegaop.AV9AgeID = aP1_AgeID;
         objgendespbodegaop.AV15DespBodOpId = aP2_DespBodOpId;
         objgendespbodegaop.AV16BodCod = aP3_BodCod;
         objgendespbodegaop.AV17DespBodCodPrd = aP4_DespBodCodPrd;
         objgendespbodegaop.AV14DespBodADesp = aP5_DespBodADesp;
         objgendespbodegaop.context.SetSubmitInitialConfig(context);
         objgendespbodegaop.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objgendespbodegaop);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((gendespbodegaop)stateInfo).executePrivate();
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
         /* Using cursor P001G2 */
         pr_default.execute(0, new Object[] {AV8EmpID, AV9AgeID, AV16BodCod, AV15DespBodOpId, AV17DespBodCodPrd});
         while ( (pr_default.getStatus(0) != 101) )
         {
            GXT1G2 = 0;
            A353DespBodNro = P001G2_A353DespBodNro[0];
            A355DespBodCodPrd = P001G2_A355DespBodCodPrd[0];
            n355DespBodCodPrd = P001G2_n355DespBodCodPrd[0];
            A22OrdenID = P001G2_A22OrdenID[0];
            A42BodCod = P001G2_A42BodCod[0];
            A2AgeID = P001G2_A2AgeID[0];
            A1EmpID = P001G2_A1EmpID[0];
            A392DespBodOK = P001G2_A392DespBodOK[0];
            n392DespBodOK = P001G2_n392DespBodOK[0];
            A359DespBodADesp = P001G2_A359DespBodADesp[0];
            n359DespBodADesp = P001G2_n359DespBodADesp[0];
            A357DespBodCant = P001G2_A357DespBodCant[0];
            n357DespBodCant = P001G2_n357DespBodCant[0];
            A400nroReg = P001G2_A400nroReg[0];
            A42BodCod = P001G2_A42BodCod[0];
            A362DespBodDif = (short)((A357DespBodCant-A359DespBodADesp));
            A359DespBodADesp = AV14DespBodADesp;
            n359DespBodADesp = false;
            A392DespBodOK = "S";
            n392DespBodOK = false;
            GXT1G2 = 1;
            /* Using cursor P001G3 */
            pr_default.execute(1, new Object[] {n392DespBodOK, A392DespBodOK, n359DespBodADesp, A359DespBodADesp, A1EmpID, A2AgeID, A353DespBodNro, A22OrdenID, A400nroReg});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("DespBodegaprd") ;
            if ( GXT1G2 == 1 )
            {
               context.CommitDataStores("gendespbodegaop",pr_default);
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
         this.cleanup();
      }

      public override void cleanup( )
      {
         context.CommitDataStores("gendespbodegaop",pr_default);
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
         P001G2_A353DespBodNro = new short[1] ;
         P001G2_A355DespBodCodPrd = new short[1] ;
         P001G2_n355DespBodCodPrd = new bool[] {false} ;
         P001G2_A22OrdenID = new short[1] ;
         P001G2_A42BodCod = new short[1] ;
         P001G2_A2AgeID = new short[1] ;
         P001G2_A1EmpID = new short[1] ;
         P001G2_A392DespBodOK = new String[] {""} ;
         P001G2_n392DespBodOK = new bool[] {false} ;
         P001G2_A359DespBodADesp = new decimal[1] ;
         P001G2_n359DespBodADesp = new bool[] {false} ;
         P001G2_A357DespBodCant = new decimal[1] ;
         P001G2_n357DespBodCant = new bool[] {false} ;
         P001G2_A400nroReg = new int[1] ;
         A392DespBodOK = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gendespbodegaop__default(),
            new Object[][] {
                new Object[] {
               P001G2_A353DespBodNro, P001G2_A355DespBodCodPrd, P001G2_n355DespBodCodPrd, P001G2_A22OrdenID, P001G2_A42BodCod, P001G2_A2AgeID, P001G2_A1EmpID, P001G2_A392DespBodOK, P001G2_n392DespBodOK, P001G2_A359DespBodADesp,
               P001G2_n359DespBodADesp, P001G2_A357DespBodCant, P001G2_n357DespBodCant, P001G2_A400nroReg
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8EmpID ;
      private short AV9AgeID ;
      private short AV15DespBodOpId ;
      private short AV16BodCod ;
      private short AV17DespBodCodPrd ;
      private short GXT1G2 ;
      private short A353DespBodNro ;
      private short A355DespBodCodPrd ;
      private short A22OrdenID ;
      private short A42BodCod ;
      private short A2AgeID ;
      private short A1EmpID ;
      private short A362DespBodDif ;
      private int A400nroReg ;
      private decimal AV14DespBodADesp ;
      private decimal A359DespBodADesp ;
      private decimal A357DespBodCant ;
      private String scmdbuf ;
      private String A392DespBodOK ;
      private bool n355DespBodCodPrd ;
      private bool n392DespBodOK ;
      private bool n359DespBodADesp ;
      private bool n357DespBodCant ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P001G2_A353DespBodNro ;
      private short[] P001G2_A355DespBodCodPrd ;
      private bool[] P001G2_n355DespBodCodPrd ;
      private short[] P001G2_A22OrdenID ;
      private short[] P001G2_A42BodCod ;
      private short[] P001G2_A2AgeID ;
      private short[] P001G2_A1EmpID ;
      private String[] P001G2_A392DespBodOK ;
      private bool[] P001G2_n392DespBodOK ;
      private decimal[] P001G2_A359DespBodADesp ;
      private bool[] P001G2_n359DespBodADesp ;
      private decimal[] P001G2_A357DespBodCant ;
      private bool[] P001G2_n357DespBodCant ;
      private int[] P001G2_A400nroReg ;
   }

   public class gendespbodegaop__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001G2 ;
          prmP001G2 = new Object[] {
          new Object[] {"@AV8EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV16BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV15DespBodOpId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV17DespBodCodPrd",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001G3 ;
          prmP001G3 = new Object[] {
          new Object[] {"@DespBodOK",SqlDbType.Char,1,0} ,
          new Object[] {"@DespBodADesp",SqlDbType.Decimal,8,2} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@nroReg",SqlDbType.Int,6,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001G2", "SELECT T1.[DespBodNro], T1.[DespBodCodPrd], T1.[OrdenID], T2.[BodCod], T1.[AgeID], T1.[EmpID], T1.[DespBodOK], T1.[DespBodADesp], T1.[DespBodCant], T1.[nroReg] FROM ([DespBodegaprd] T1 WITH (UPDLOCK) INNER JOIN [DespBodega] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[AgeID] = T1.[AgeID] AND T2.[DespBodNro] = T1.[DespBodNro] AND T2.[OrdenID] = T1.[OrdenID]) WHERE (T1.[EmpID] = @AV8EmpID and T1.[AgeID] = @AV9AgeID) AND (T2.[BodCod] = @AV16BodCod) AND (T1.[OrdenID] = @AV15DespBodOpId) AND (T1.[DespBodCodPrd] = @AV17DespBodCodPrd) ORDER BY T1.[EmpID], T1.[AgeID] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001G2,1,0,true,false )
             ,new CursorDef("P001G3", "UPDATE [DespBodegaprd] SET [DespBodOK]=@DespBodOK, [DespBodADesp]=@DespBodADesp  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [DespBodNro] = @DespBodNro AND [OrdenID] = @OrdenID AND [nroReg] = @nroReg", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001G3)
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
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                ((String[]) buf[7])[0] = rslt.getString(7, 1) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((decimal[]) buf[9])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(8);
                ((decimal[]) buf[11])[0] = rslt.getDecimal(9) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(9);
                ((int[]) buf[13])[0] = rslt.getInt(10) ;
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
                   stmt.setNull( 2 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(2, (decimal)parms[3]);
                }
                stmt.SetParameter(3, (short)parms[4]);
                stmt.SetParameter(4, (short)parms[5]);
                stmt.SetParameter(5, (short)parms[6]);
                stmt.SetParameter(6, (short)parms[7]);
                stmt.SetParameter(7, (int)parms[8]);
                return;
       }
    }

 }

}
