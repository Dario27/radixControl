/*
               File: actStockBodegaPrd
        Description: act Stock Bodega Prd
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/23/2023 1:6:29.4
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
   public class actstockbodegaprd : GXProcedure
   {
      public actstockbodegaprd( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public actstockbodegaprd( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_empid ,
                           short aP1_ageId ,
                           short aP2_DespBodNro ,
                           short aP3_ClienteID ,
                           short aP4_bodcod ,
                           short aP5_OrdenID )
      {
         this.AV8empid = aP0_empid;
         this.AV9ageId = aP1_ageId;
         this.AV13DespBodNro = aP2_DespBodNro;
         this.AV10ClienteID = aP3_ClienteID;
         this.AV11bodcod = aP4_bodcod;
         this.AV12OrdenID = aP5_OrdenID;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_empid ,
                                 short aP1_ageId ,
                                 short aP2_DespBodNro ,
                                 short aP3_ClienteID ,
                                 short aP4_bodcod ,
                                 short aP5_OrdenID )
      {
         actstockbodegaprd objactstockbodegaprd;
         objactstockbodegaprd = new actstockbodegaprd();
         objactstockbodegaprd.AV8empid = aP0_empid;
         objactstockbodegaprd.AV9ageId = aP1_ageId;
         objactstockbodegaprd.AV13DespBodNro = aP2_DespBodNro;
         objactstockbodegaprd.AV10ClienteID = aP3_ClienteID;
         objactstockbodegaprd.AV11bodcod = aP4_bodcod;
         objactstockbodegaprd.AV12OrdenID = aP5_OrdenID;
         objactstockbodegaprd.context.SetSubmitInitialConfig(context);
         objactstockbodegaprd.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objactstockbodegaprd);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((actstockbodegaprd)stateInfo).executePrivate();
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
         /* Using cursor P001T2 */
         pr_default.execute(0, new Object[] {AV8empid, AV9ageId, AV13DespBodNro, AV12OrdenID, AV10ClienteID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A359DespBodADesp = P001T2_A359DespBodADesp[0];
            n359DespBodADesp = P001T2_n359DespBodADesp[0];
            A22OrdenID = P001T2_A22OrdenID[0];
            A5ClienteID = P001T2_A5ClienteID[0];
            A353DespBodNro = P001T2_A353DespBodNro[0];
            A2AgeID = P001T2_A2AgeID[0];
            A1EmpID = P001T2_A1EmpID[0];
            A400nroReg = P001T2_A400nroReg[0];
            A403DespBodModifItem = P001T2_A403DespBodModifItem[0];
            n403DespBodModifItem = P001T2_n403DespBodModifItem[0];
            A355DespBodCodPrd = P001T2_A355DespBodCodPrd[0];
            n355DespBodCodPrd = P001T2_n355DespBodCodPrd[0];
            A392DespBodOK = P001T2_A392DespBodOK[0];
            n392DespBodOK = P001T2_n392DespBodOK[0];
            if ( StringUtil.StrCmp(A403DespBodModifItem, "S") == 0 )
            {
               new actstock(context ).execute(  AV8empid,  AV9ageId,  AV10ClienteID,  AV11bodcod,  A355DespBodCodPrd,  A359DespBodADesp,  AV12OrdenID,  A403DespBodModifItem) ;
               A403DespBodModifItem = "N";
               n403DespBodModifItem = false;
            }
            else
            {
               if ( ( StringUtil.StrCmp(A392DespBodOK, "") == 0 ) || P001T2_n392DespBodOK[0] )
               {
                  new actstock(context ).execute(  AV8empid,  AV9ageId,  AV10ClienteID,  AV11bodcod,  A355DespBodCodPrd,  A359DespBodADesp,  AV12OrdenID,  A403DespBodModifItem) ;
                  A392DespBodOK = "S";
                  n392DespBodOK = false;
               }
            }
            GX_msglist.addItem("proceso OK");
            /* Using cursor P001T3 */
            pr_default.execute(1, new Object[] {n403DespBodModifItem, A403DespBodModifItem, n392DespBodOK, A392DespBodOK, A1EmpID, A2AgeID, A353DespBodNro, A22OrdenID, A5ClienteID, A400nroReg});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("DespBodegaprd") ;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         this.cleanup();
      }

      public override void cleanup( )
      {
         context.CommitDataStores("actstockbodegaprd",pr_default);
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
         P001T2_A359DespBodADesp = new decimal[1] ;
         P001T2_n359DespBodADesp = new bool[] {false} ;
         P001T2_A22OrdenID = new short[1] ;
         P001T2_A5ClienteID = new short[1] ;
         P001T2_A353DespBodNro = new short[1] ;
         P001T2_A2AgeID = new short[1] ;
         P001T2_A1EmpID = new short[1] ;
         P001T2_A400nroReg = new int[1] ;
         P001T2_A403DespBodModifItem = new String[] {""} ;
         P001T2_n403DespBodModifItem = new bool[] {false} ;
         P001T2_A355DespBodCodPrd = new short[1] ;
         P001T2_n355DespBodCodPrd = new bool[] {false} ;
         P001T2_A392DespBodOK = new String[] {""} ;
         P001T2_n392DespBodOK = new bool[] {false} ;
         A403DespBodModifItem = "";
         A392DespBodOK = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.actstockbodegaprd__default(),
            new Object[][] {
                new Object[] {
               P001T2_A359DespBodADesp, P001T2_n359DespBodADesp, P001T2_A22OrdenID, P001T2_A5ClienteID, P001T2_A353DespBodNro, P001T2_A2AgeID, P001T2_A1EmpID, P001T2_A400nroReg, P001T2_A403DespBodModifItem, P001T2_n403DespBodModifItem,
               P001T2_A355DespBodCodPrd, P001T2_n355DespBodCodPrd, P001T2_A392DespBodOK, P001T2_n392DespBodOK
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8empid ;
      private short AV9ageId ;
      private short AV13DespBodNro ;
      private short AV10ClienteID ;
      private short AV11bodcod ;
      private short AV12OrdenID ;
      private short A22OrdenID ;
      private short A5ClienteID ;
      private short A353DespBodNro ;
      private short A2AgeID ;
      private short A1EmpID ;
      private short A355DespBodCodPrd ;
      private int A400nroReg ;
      private decimal A359DespBodADesp ;
      private String scmdbuf ;
      private String A403DespBodModifItem ;
      private String A392DespBodOK ;
      private bool n359DespBodADesp ;
      private bool n403DespBodModifItem ;
      private bool n355DespBodCodPrd ;
      private bool n392DespBodOK ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private decimal[] P001T2_A359DespBodADesp ;
      private bool[] P001T2_n359DespBodADesp ;
      private short[] P001T2_A22OrdenID ;
      private short[] P001T2_A5ClienteID ;
      private short[] P001T2_A353DespBodNro ;
      private short[] P001T2_A2AgeID ;
      private short[] P001T2_A1EmpID ;
      private int[] P001T2_A400nroReg ;
      private String[] P001T2_A403DespBodModifItem ;
      private bool[] P001T2_n403DespBodModifItem ;
      private short[] P001T2_A355DespBodCodPrd ;
      private bool[] P001T2_n355DespBodCodPrd ;
      private String[] P001T2_A392DespBodOK ;
      private bool[] P001T2_n392DespBodOK ;
   }

   public class actstockbodegaprd__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP001T2 ;
          prmP001T2 = new Object[] {
          new Object[] {"@AV8empid",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9ageId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV13DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001T3 ;
          prmP001T3 = new Object[] {
          new Object[] {"@DespBodModifItem",SqlDbType.Char,1,0} ,
          new Object[] {"@DespBodOK",SqlDbType.Char,1,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@nroReg",SqlDbType.Int,6,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001T2", "SELECT [DespBodADesp], [OrdenID], [ClienteID], [DespBodNro], [AgeID], [EmpID], [nroReg], [DespBodModifItem], [DespBodCodPrd], [DespBodOK] FROM [DespBodegaprd] WITH (UPDLOCK) WHERE ([EmpID] = @AV8empid and [AgeID] = @AV9ageId and [DespBodNro] = @AV13DespBodNro and [OrdenID] = @AV12OrdenID and [ClienteID] = @AV10ClienteID) AND ([DespBodADesp] > 0) ORDER BY [EmpID], [AgeID], [DespBodNro], [OrdenID], [ClienteID] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001T2,1,0,true,false )
             ,new CursorDef("P001T3", "UPDATE [DespBodegaprd] SET [DespBodModifItem]=@DespBodModifItem, [DespBodOK]=@DespBodOK  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [DespBodNro] = @DespBodNro AND [OrdenID] = @OrdenID AND [ClienteID] = @ClienteID AND [nroReg] = @nroReg", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001T3)
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
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                ((int[]) buf[7])[0] = rslt.getInt(7) ;
                ((String[]) buf[8])[0] = rslt.getString(8, 1) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((short[]) buf[10])[0] = rslt.getShort(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((String[]) buf[12])[0] = rslt.getString(10, 1) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
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
                   stmt.setNull( 2 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[3]);
                }
                stmt.SetParameter(3, (short)parms[4]);
                stmt.SetParameter(4, (short)parms[5]);
                stmt.SetParameter(5, (short)parms[6]);
                stmt.SetParameter(6, (short)parms[7]);
                stmt.SetParameter(7, (short)parms[8]);
                stmt.SetParameter(8, (int)parms[9]);
                return;
       }
    }

 }

}
