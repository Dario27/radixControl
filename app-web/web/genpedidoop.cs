/*
               File: GenPedidoOP
        Description: Gen Pedido OP
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 11/27/2022 10:57:2.64
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
   public class genpedidoop : GXProcedure
   {
      public genpedidoop( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public genpedidoop( IGxContext context )
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
                           short aP2_BodCod ,
                           short aP3_DespBodOpId ,
                           short aP4_DespBodCodPrd ,
                           String aP5_DespBodPrdNombre ,
                           int aP6_DespBodCant ,
                           short aP7_DespBodCatId )
      {
         this.AV8EmpID = aP0_EmpID;
         this.AV9AgeID = aP1_AgeID;
         this.AV10BodCod = aP2_BodCod;
         this.AV12DespBodOpId = aP3_DespBodOpId;
         this.AV16DespBodCodPrd = aP4_DespBodCodPrd;
         this.AV13DespBodPrdNombre = aP5_DespBodPrdNombre;
         this.AV14DespBodCant = aP6_DespBodCant;
         this.AV15DespBodCatId = aP7_DespBodCatId;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_EmpID ,
                                 short aP1_AgeID ,
                                 short aP2_BodCod ,
                                 short aP3_DespBodOpId ,
                                 short aP4_DespBodCodPrd ,
                                 String aP5_DespBodPrdNombre ,
                                 int aP6_DespBodCant ,
                                 short aP7_DespBodCatId )
      {
         genpedidoop objgenpedidoop;
         objgenpedidoop = new genpedidoop();
         objgenpedidoop.AV8EmpID = aP0_EmpID;
         objgenpedidoop.AV9AgeID = aP1_AgeID;
         objgenpedidoop.AV10BodCod = aP2_BodCod;
         objgenpedidoop.AV12DespBodOpId = aP3_DespBodOpId;
         objgenpedidoop.AV16DespBodCodPrd = aP4_DespBodCodPrd;
         objgenpedidoop.AV13DespBodPrdNombre = aP5_DespBodPrdNombre;
         objgenpedidoop.AV14DespBodCant = aP6_DespBodCant;
         objgenpedidoop.AV15DespBodCatId = aP7_DespBodCatId;
         objgenpedidoop.context.SetSubmitInitialConfig(context);
         objgenpedidoop.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objgenpedidoop);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((genpedidoop)stateInfo).executePrivate();
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
         /* Execute user subroutine: 'NEXTID' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         /*
            INSERT RECORD ON TABLE DespBodega

         */
         A1EmpID = AV8EmpID;
         A2AgeID = AV9AgeID;
         A353DespBodNro = AV11DespBodNro;
         A42BodCod = AV10BodCod;
         A354DespBodOpId = AV12DespBodOpId;
         A355DespBodCodPrd = AV16DespBodCodPrd;
         n355DespBodCodPrd = false;
         A356DespBodPrdNombre = AV13DespBodPrdNombre;
         n356DespBodPrdNombre = false;
         A357DespBodCant = AV14DespBodCant;
         n357DespBodCant = false;
         A361DespBodCatId = AV15DespBodCatId;
         n361DespBodCatId = false;
         /* Using cursor P001C2 */
         pr_default.execute(0, new Object[] {A1EmpID, A2AgeID, A353DespBodNro, A354DespBodOpId, A42BodCod, n355DespBodCodPrd, A355DespBodCodPrd, n356DespBodPrdNombre, A356DespBodPrdNombre, n357DespBodCant, A357DespBodCant, n361DespBodCatId, A361DespBodCatId});
         pr_default.close(0);
         dsDefault.SmartCacheProvider.SetUpdated("DespBodega") ;
         if ( (pr_default.getStatus(0) == 1) )
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
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'NEXTID' Routine */
         AV20GXLvl20 = 0;
         /* Using cursor P001C3 */
         pr_default.execute(1, new Object[] {AV8EmpID, AV9AgeID, AV10BodCod, AV12DespBodOpId});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A354DespBodOpId = P001C3_A354DespBodOpId[0];
            A42BodCod = P001C3_A42BodCod[0];
            A2AgeID = P001C3_A2AgeID[0];
            A1EmpID = P001C3_A1EmpID[0];
            A356DespBodPrdNombre = P001C3_A356DespBodPrdNombre[0];
            n356DespBodPrdNombre = P001C3_n356DespBodPrdNombre[0];
            A353DespBodNro = P001C3_A353DespBodNro[0];
            AV20GXLvl20 = 1;
            AV17DespBodNro1 = A353DespBodNro;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(1);
         }
         pr_default.close(1);
         if ( AV20GXLvl20 == 0 )
         {
            AV11DespBodNro = 1;
         }
         AV11DespBodNro = (short)(AV17DespBodNro1+1);
      }

      public override void cleanup( )
      {
         context.CommitDataStores("genpedidoop",pr_default);
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
         A356DespBodPrdNombre = "";
         Gx_emsg = "";
         scmdbuf = "";
         P001C3_A354DespBodOpId = new short[1] ;
         P001C3_A42BodCod = new short[1] ;
         P001C3_A2AgeID = new short[1] ;
         P001C3_A1EmpID = new short[1] ;
         P001C3_A356DespBodPrdNombre = new String[] {""} ;
         P001C3_n356DespBodPrdNombre = new bool[] {false} ;
         P001C3_A353DespBodNro = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.genpedidoop__default(),
            new Object[][] {
                new Object[] {
               }
               , new Object[] {
               P001C3_A354DespBodOpId, P001C3_A42BodCod, P001C3_A2AgeID, P001C3_A1EmpID, P001C3_A356DespBodPrdNombre, P001C3_n356DespBodPrdNombre, P001C3_A353DespBodNro
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8EmpID ;
      private short AV9AgeID ;
      private short AV10BodCod ;
      private short AV12DespBodOpId ;
      private short AV16DespBodCodPrd ;
      private short AV15DespBodCatId ;
      private short A1EmpID ;
      private short A2AgeID ;
      private short A353DespBodNro ;
      private short AV11DespBodNro ;
      private short A42BodCod ;
      private short A354DespBodOpId ;
      private short A355DespBodCodPrd ;
      private short A361DespBodCatId ;
      private short AV20GXLvl20 ;
      private short AV17DespBodNro1 ;
      private int AV14DespBodCant ;
      private int GX_INS86 ;
      private int A357DespBodCant ;
      private String AV13DespBodPrdNombre ;
      private String A356DespBodPrdNombre ;
      private String Gx_emsg ;
      private String scmdbuf ;
      private bool returnInSub ;
      private bool n355DespBodCodPrd ;
      private bool n356DespBodPrdNombre ;
      private bool n357DespBodCant ;
      private bool n361DespBodCatId ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P001C3_A354DespBodOpId ;
      private short[] P001C3_A42BodCod ;
      private short[] P001C3_A2AgeID ;
      private short[] P001C3_A1EmpID ;
      private String[] P001C3_A356DespBodPrdNombre ;
      private bool[] P001C3_n356DespBodPrdNombre ;
      private short[] P001C3_A353DespBodNro ;
   }

   public class genpedidoop__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001C2 ;
          prmP001C2 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodOpId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodCodPrd",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodPrdNombre",SqlDbType.Char,40,0} ,
          new Object[] {"@DespBodCant",SqlDbType.Int,6,0} ,
          new Object[] {"@DespBodCatId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001C3 ;
          prmP001C3 = new Object[] {
          new Object[] {"@AV8EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12DespBodOpId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001C2", "INSERT INTO [DespBodega]([EmpID], [AgeID], [DespBodNro], [DespBodOpId], [BodCod], [DespBodCodPrd], [DespBodPrdNombre], [DespBodCant], [DespBodCatId], [DespBodValor], [DespBodADesp]) VALUES(@EmpID, @AgeID, @DespBodNro, @DespBodOpId, @BodCod, @DespBodCodPrd, @DespBodPrdNombre, @DespBodCant, @DespBodCatId, convert(int, 0), convert(int, 0))", GxErrorMask.GX_NOMASK,prmP001C2)
             ,new CursorDef("P001C3", "SELECT TOP 1 [DespBodOpId], [BodCod], [AgeID], [EmpID], [DespBodPrdNombre], [DespBodNro] FROM [DespBodega] WITH (NOLOCK) WHERE ([EmpID] = @AV8EmpID and [AgeID] = @AV9AgeID) AND ([BodCod] = @AV10BodCod) AND ([DespBodOpId] = @AV12DespBodOpId) ORDER BY [EmpID] DESC, [AgeID] DESC, [DespBodNro] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001C3,1,0,false,true )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 40) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
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
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 6 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(6, (short)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 7 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 8 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(8, (int)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 9 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(9, (short)parms[12]);
                }
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
       }
    }

 }

}
