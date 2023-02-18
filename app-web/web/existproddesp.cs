/*
               File: existProdDesp
        Description: exist Prod Desp
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/11/2023 2:12:40.72
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
   public class existproddesp : GXProcedure
   {
      public existproddesp( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public existproddesp( IGxContext context )
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
                           short aP3_DespBodCodPrd ,
                           short aP4_DespBodOpId ,
                           out short aP5_exist )
      {
         this.AV8EmpID = aP0_EmpID;
         this.AV9AgeID = aP1_AgeID;
         this.AV10BodCod = aP2_BodCod;
         this.AV11DespBodCodPrd = aP3_DespBodCodPrd;
         this.AV12DespBodOpId = aP4_DespBodOpId;
         this.AV13exist = 0 ;
         initialize();
         executePrivate();
         aP5_exist=this.AV13exist;
      }

      public short executeUdp( short aP0_EmpID ,
                               short aP1_AgeID ,
                               short aP2_BodCod ,
                               short aP3_DespBodCodPrd ,
                               short aP4_DespBodOpId )
      {
         this.AV8EmpID = aP0_EmpID;
         this.AV9AgeID = aP1_AgeID;
         this.AV10BodCod = aP2_BodCod;
         this.AV11DespBodCodPrd = aP3_DespBodCodPrd;
         this.AV12DespBodOpId = aP4_DespBodOpId;
         this.AV13exist = 0 ;
         initialize();
         executePrivate();
         aP5_exist=this.AV13exist;
         return AV13exist ;
      }

      public void executeSubmit( short aP0_EmpID ,
                                 short aP1_AgeID ,
                                 short aP2_BodCod ,
                                 short aP3_DespBodCodPrd ,
                                 short aP4_DespBodOpId ,
                                 out short aP5_exist )
      {
         existproddesp objexistproddesp;
         objexistproddesp = new existproddesp();
         objexistproddesp.AV8EmpID = aP0_EmpID;
         objexistproddesp.AV9AgeID = aP1_AgeID;
         objexistproddesp.AV10BodCod = aP2_BodCod;
         objexistproddesp.AV11DespBodCodPrd = aP3_DespBodCodPrd;
         objexistproddesp.AV12DespBodOpId = aP4_DespBodOpId;
         objexistproddesp.AV13exist = 0 ;
         objexistproddesp.context.SetSubmitInitialConfig(context);
         objexistproddesp.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objexistproddesp);
         aP5_exist=this.AV13exist;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((existproddesp)stateInfo).executePrivate();
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
         AV16GXLvl1 = 0;
         /* Using cursor P001N2 */
         pr_default.execute(0, new Object[] {AV8EmpID, AV9AgeID, AV11DespBodCodPrd, AV12DespBodOpId, AV10BodCod});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A42BodCod = P001N2_A42BodCod[0];
            A354DespBodOpId = P001N2_A354DespBodOpId[0];
            A355DespBodCodPrd = P001N2_A355DespBodCodPrd[0];
            n355DespBodCodPrd = P001N2_n355DespBodCodPrd[0];
            A2AgeID = P001N2_A2AgeID[0];
            A1EmpID = P001N2_A1EmpID[0];
            A353DespBodNro = P001N2_A353DespBodNro[0];
            AV16GXLvl1 = 1;
            AV13exist = 1;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( AV16GXLvl1 == 0 )
         {
            AV13exist = 0;
         }
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
         P001N2_A42BodCod = new short[1] ;
         P001N2_A354DespBodOpId = new short[1] ;
         P001N2_A355DespBodCodPrd = new short[1] ;
         P001N2_n355DespBodCodPrd = new bool[] {false} ;
         P001N2_A2AgeID = new short[1] ;
         P001N2_A1EmpID = new short[1] ;
         P001N2_A353DespBodNro = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.existproddesp__default(),
            new Object[][] {
                new Object[] {
               P001N2_A42BodCod, P001N2_A354DespBodOpId, P001N2_A355DespBodCodPrd, P001N2_n355DespBodCodPrd, P001N2_A2AgeID, P001N2_A1EmpID, P001N2_A353DespBodNro
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8EmpID ;
      private short AV9AgeID ;
      private short AV10BodCod ;
      private short AV11DespBodCodPrd ;
      private short AV12DespBodOpId ;
      private short AV13exist ;
      private short AV16GXLvl1 ;
      private short A42BodCod ;
      private short A354DespBodOpId ;
      private short A355DespBodCodPrd ;
      private short A2AgeID ;
      private short A1EmpID ;
      private short A353DespBodNro ;
      private String scmdbuf ;
      private bool n355DespBodCodPrd ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P001N2_A42BodCod ;
      private short[] P001N2_A354DespBodOpId ;
      private short[] P001N2_A355DespBodCodPrd ;
      private bool[] P001N2_n355DespBodCodPrd ;
      private short[] P001N2_A2AgeID ;
      private short[] P001N2_A1EmpID ;
      private short[] P001N2_A353DespBodNro ;
      private short aP5_exist ;
   }

   public class existproddesp__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP001N2 ;
          prmP001N2 = new Object[] {
          new Object[] {"@AV8EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11DespBodCodPrd",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12DespBodOpId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10BodCod",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001N2", "SELECT [BodCod], [DespBodOpId], [DespBodCodPrd], [AgeID], [EmpID], [DespBodNro] FROM [DespBodega] WITH (NOLOCK) WHERE ([EmpID] = @AV8EmpID and [AgeID] = @AV9AgeID) AND ([DespBodCodPrd] = @AV11DespBodCodPrd) AND ([DespBodOpId] = @AV12DespBodOpId) AND ([BodCod] = @AV10BodCod) ORDER BY [EmpID], [AgeID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001N2,100,0,false,false )
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
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
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
                return;
       }
    }

 }

}
