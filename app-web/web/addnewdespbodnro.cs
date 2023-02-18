/*
               File: addNewDespBodNro
        Description: add New Desp Bod Nro
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/21/2023 19:12:56.59
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
   public class addnewdespbodnro : GXProcedure
   {
      public addnewdespbodnro( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public addnewdespbodnro( IGxContext context )
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
                           short aP2_ClienteID ,
                           short aP3_OrdenAnio ,
                           short aP4_OrdenPeriodo ,
                           short aP5_OrdenID ,
                           short aP6_BodCod )
      {
         this.AV8EmpID = aP0_EmpID;
         this.AV14AgeID = aP1_AgeID;
         this.AV9ClienteID = aP2_ClienteID;
         this.AV10OrdenAnio = aP3_OrdenAnio;
         this.AV11OrdenPeriodo = aP4_OrdenPeriodo;
         this.AV12OrdenID = aP5_OrdenID;
         this.AV15BodCod = aP6_BodCod;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_EmpID ,
                                 short aP1_AgeID ,
                                 short aP2_ClienteID ,
                                 short aP3_OrdenAnio ,
                                 short aP4_OrdenPeriodo ,
                                 short aP5_OrdenID ,
                                 short aP6_BodCod )
      {
         addnewdespbodnro objaddnewdespbodnro;
         objaddnewdespbodnro = new addnewdespbodnro();
         objaddnewdespbodnro.AV8EmpID = aP0_EmpID;
         objaddnewdespbodnro.AV14AgeID = aP1_AgeID;
         objaddnewdespbodnro.AV9ClienteID = aP2_ClienteID;
         objaddnewdespbodnro.AV10OrdenAnio = aP3_OrdenAnio;
         objaddnewdespbodnro.AV11OrdenPeriodo = aP4_OrdenPeriodo;
         objaddnewdespbodnro.AV12OrdenID = aP5_OrdenID;
         objaddnewdespbodnro.AV15BodCod = aP6_BodCod;
         objaddnewdespbodnro.context.SetSubmitInitialConfig(context);
         objaddnewdespbodnro.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objaddnewdespbodnro);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((addnewdespbodnro)stateInfo).executePrivate();
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
         /* Execute user subroutine: 'BUSNEWID' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'BUSNEWID' Routine */
         AV13newID = 0;
         /* Using cursor P001R2 */
         pr_default.execute(0, new Object[] {AV8EmpID, AV14AgeID, AV9ClienteID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A5ClienteID = P001R2_A5ClienteID[0];
            A2AgeID = P001R2_A2AgeID[0];
            A1EmpID = P001R2_A1EmpID[0];
            A353DespBodNro = P001R2_A353DespBodNro[0];
            A22OrdenID = P001R2_A22OrdenID[0];
            AV13newID = A353DespBodNro;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV16DespBodNro = (short)(AV13newID+1);
         /* Execute user subroutine: 'INSERT' */
         S121 ();
         if (returnInSub) return;
         /* Execute user subroutine: 'ACTORDENDESPACHO' */
         S131 ();
         if (returnInSub) return;
      }

      protected void S121( )
      {
         /* 'INSERT' Routine */
         /*
            INSERT RECORD ON TABLE DespBodega

         */
         A1EmpID = AV8EmpID;
         A2AgeID = AV14AgeID;
         A42BodCod = AV15BodCod;
         A353DespBodNro = AV16DespBodNro;
         A22OrdenID = AV12OrdenID;
         A5ClienteID = AV9ClienteID;
         /* Using cursor P001R3 */
         pr_default.execute(1, new Object[] {A1EmpID, A2AgeID, A353DespBodNro, A22OrdenID, A5ClienteID, A42BodCod});
         pr_default.close(1);
         dsDefault.SmartCacheProvider.SetUpdated("DespBodega") ;
         if ( (pr_default.getStatus(1) == 1) )
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
      }

      protected void S131( )
      {
         /* 'ACTORDENDESPACHO' Routine */
         /* Optimized UPDATE. */
         /* Using cursor P001R4 */
         int AV16DespBodNro401Aux ;
         AV16DespBodNro401Aux = AV16DespBodNro;
         pr_default.execute(2, new Object[] {n401OrdenNroDesp, AV16DespBodNro401Aux, AV8EmpID, AV9ClienteID, AV11OrdenPeriodo, AV10OrdenAnio, AV12OrdenID});
         pr_default.close(2);
         dsDefault.SmartCacheProvider.SetUpdated("OrdenProduccion") ;
         /* End optimized UPDATE. */
      }

      public override void cleanup( )
      {
         context.CommitDataStores("addnewdespbodnro",pr_default);
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
         P001R2_A5ClienteID = new short[1] ;
         P001R2_A2AgeID = new short[1] ;
         P001R2_A1EmpID = new short[1] ;
         P001R2_A353DespBodNro = new short[1] ;
         P001R2_A22OrdenID = new short[1] ;
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.addnewdespbodnro__default(),
            new Object[][] {
                new Object[] {
               P001R2_A5ClienteID, P001R2_A2AgeID, P001R2_A1EmpID, P001R2_A353DespBodNro, P001R2_A22OrdenID
               }
               , new Object[] {
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8EmpID ;
      private short AV14AgeID ;
      private short AV9ClienteID ;
      private short AV10OrdenAnio ;
      private short AV11OrdenPeriodo ;
      private short AV12OrdenID ;
      private short AV15BodCod ;
      private short AV13newID ;
      private short A5ClienteID ;
      private short A2AgeID ;
      private short A1EmpID ;
      private short A353DespBodNro ;
      private short A22OrdenID ;
      private short AV16DespBodNro ;
      private short A42BodCod ;
      private int GX_INS93 ;
      private int A401OrdenNroDesp ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private bool returnInSub ;
      private bool n401OrdenNroDesp ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P001R2_A5ClienteID ;
      private short[] P001R2_A2AgeID ;
      private short[] P001R2_A1EmpID ;
      private short[] P001R2_A353DespBodNro ;
      private short[] P001R2_A22OrdenID ;
   }

   public class addnewdespbodnro__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
         ,new UpdateCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001R2 ;
          prmP001R2 = new Object[] {
          new Object[] {"@AV8EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV14AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001R3 ;
          prmP001R3 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001R4 ;
          prmP001R4 = new Object[] {
          new Object[] {"@OrdenNroDesp",SqlDbType.Int,6,0} ,
          new Object[] {"@AV8EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV10OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001R2", "SELECT TOP 1 [ClienteID], [AgeID], [EmpID], [DespBodNro], [OrdenID] FROM [DespBodega] WITH (NOLOCK) WHERE ([EmpID] = @AV8EmpID and [AgeID] = @AV14AgeID) AND ([ClienteID] = @AV9ClienteID) ORDER BY [EmpID] DESC, [AgeID] DESC, [DespBodNro] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001R2,1,0,false,true )
             ,new CursorDef("P001R3", "INSERT INTO [DespBodega]([EmpID], [AgeID], [DespBodNro], [OrdenID], [ClienteID], [BodCod], [DespBodUltReg], [DespachadoOK]) VALUES(@EmpID, @AgeID, @DespBodNro, @OrdenID, @ClienteID, @BodCod, convert(int, 0), '')", GxErrorMask.GX_NOMASK,prmP001R3)
             ,new CursorDef("P001R4", "UPDATE [OrdenProduccion] SET [OrdenNroDesp]=@OrdenNroDesp  WHERE [EmpID] = @AV8EmpID and [ClienteID] = @AV9ClienteID and [OrdenPeriodo] = @AV11OrdenPeriodo and [OrdenAnio] = @AV10OrdenAnio and [OrdenID] = @AV12OrdenID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001R4)
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
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 2 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                stmt.SetParameter(2, (short)parms[2]);
                stmt.SetParameter(3, (short)parms[3]);
                stmt.SetParameter(4, (short)parms[4]);
                stmt.SetParameter(5, (short)parms[5]);
                stmt.SetParameter(6, (short)parms[6]);
                return;
       }
    }

 }

}
