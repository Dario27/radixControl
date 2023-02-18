/*
               File: prcAddDespBodega
        Description: prc Add Desp Bodega
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/12/2023 2:33:55.56
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
   public class prcadddespbodega : GXProcedure
   {
      public prcadddespbodega( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public prcadddespbodega( IGxContext context )
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
                           short aP3_OrdenPeriodo ,
                           short aP4_OrdenAnio ,
                           short aP5_OrdenID )
      {
         this.AV8EmpID = aP0_EmpID;
         this.AV16AgeID = aP1_AgeID;
         this.AV12ClienteID = aP2_ClienteID;
         this.AV11OrdenPeriodo = aP3_OrdenPeriodo;
         this.AV10OrdenAnio = aP4_OrdenAnio;
         this.AV9OrdenID = aP5_OrdenID;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_EmpID ,
                                 short aP1_AgeID ,
                                 short aP2_ClienteID ,
                                 short aP3_OrdenPeriodo ,
                                 short aP4_OrdenAnio ,
                                 short aP5_OrdenID )
      {
         prcadddespbodega objprcadddespbodega;
         objprcadddespbodega = new prcadddespbodega();
         objprcadddespbodega.AV8EmpID = aP0_EmpID;
         objprcadddespbodega.AV16AgeID = aP1_AgeID;
         objprcadddespbodega.AV12ClienteID = aP2_ClienteID;
         objprcadddespbodega.AV11OrdenPeriodo = aP3_OrdenPeriodo;
         objprcadddespbodega.AV10OrdenAnio = aP4_OrdenAnio;
         objprcadddespbodega.AV9OrdenID = aP5_OrdenID;
         objprcadddespbodega.context.SetSubmitInitialConfig(context);
         objprcadddespbodega.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objprcadddespbodega);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((prcadddespbodega)stateInfo).executePrivate();
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
         /* Using cursor P001O2 */
         pr_default.execute(0, new Object[] {AV8EmpID, AV11OrdenPeriodo, AV10OrdenAnio, AV9OrdenID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A32categID = P001O2_A32categID[0];
            A397OrdenDesp = P001O2_A397OrdenDesp[0];
            n397OrdenDesp = P001O2_n397OrdenDesp[0];
            A396OrdenDetDesp = P001O2_A396OrdenDetDesp[0];
            n396OrdenDetDesp = P001O2_n396OrdenDetDesp[0];
            A22OrdenID = P001O2_A22OrdenID[0];
            A25OrdenAnio = P001O2_A25OrdenAnio[0];
            A24OrdenPeriodo = P001O2_A24OrdenPeriodo[0];
            A1EmpID = P001O2_A1EmpID[0];
            A148subCatDsc = P001O2_A148subCatDsc[0];
            n148subCatDsc = P001O2_n148subCatDsc[0];
            A33subCatID = P001O2_A33subCatID[0];
            A251OrdenDetDetalle = P001O2_A251OrdenDetDetalle[0];
            n251OrdenDetDetalle = P001O2_n251OrdenDetDetalle[0];
            A150subCatPrec = P001O2_A150subCatPrec[0];
            n150subCatPrec = P001O2_n150subCatPrec[0];
            A208OrdenDetCant = P001O2_A208OrdenDetCant[0];
            n208OrdenDetCant = P001O2_n208OrdenDetCant[0];
            A5ClienteID = P001O2_A5ClienteID[0];
            A41OrdenSecId = P001O2_A41OrdenSecId[0];
            A148subCatDsc = P001O2_A148subCatDsc[0];
            n148subCatDsc = P001O2_n148subCatDsc[0];
            A150subCatPrec = P001O2_A150subCatPrec[0];
            n150subCatPrec = P001O2_n150subCatPrec[0];
            A209OrdenDetVal = (decimal)(A150subCatPrec*A208OrdenDetCant);
            AV17prdNombre = A148subCatDsc;
            /* Execute user subroutine: 'BUSCODPRDUCTO' */
            S111 ();
            if ( returnInSub )
            {
               pr_default.close(0);
               this.cleanup();
               if (true) return;
            }
            AV18DespBodCant = A208OrdenDetCant;
            AV15DespBodCatId = A33subCatID;
            AV19DespBodValor = A209OrdenDetVal;
            AV20DespBodDetalle = A251OrdenDetDetalle;
            AV21exist = 0;
            if ( AV21exist == 0 )
            {
               new adddespachoop(context ).execute(  AV8EmpID,  AV16AgeID,  1,  AV9OrdenID,  AV13DespBodCodPrd,  AV14DespBodPrdNombre,  AV18DespBodCant,  AV15DespBodCatId,  AV19DespBodValor,  AV20DespBodDetalle) ;
               AV24OrdenDesp = 1;
               /* Execute user subroutine: 'ACTORDENDESP' */
               S121 ();
               if ( returnInSub )
               {
                  pr_default.close(0);
                  this.cleanup();
                  if (true) return;
               }
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'BUSCODPRDUCTO' Routine */
         /* Using cursor P001O3 */
         pr_default.execute(1, new Object[] {AV8EmpID, AV16AgeID, AV17prdNombre});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A309prdNombre = P001O3_A309prdNombre[0];
            n309prdNombre = P001O3_n309prdNombre[0];
            A2AgeID = P001O3_A2AgeID[0];
            A1EmpID = P001O3_A1EmpID[0];
            A286PrdCod = P001O3_A286PrdCod[0];
            AV13DespBodCodPrd = A286PrdCod;
            AV14DespBodPrdNombre = A309prdNombre;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void S121( )
      {
         /* 'ACTORDENDESP' Routine */
         /* Using cursor P001O4 */
         pr_default.execute(2, new Object[] {AV8EmpID, AV12ClienteID, AV11OrdenPeriodo, AV10OrdenAnio, AV9OrdenID, AV15DespBodCatId});
         while ( (pr_default.getStatus(2) != 101) )
         {
            A33subCatID = P001O4_A33subCatID[0];
            A22OrdenID = P001O4_A22OrdenID[0];
            A25OrdenAnio = P001O4_A25OrdenAnio[0];
            A24OrdenPeriodo = P001O4_A24OrdenPeriodo[0];
            A5ClienteID = P001O4_A5ClienteID[0];
            A1EmpID = P001O4_A1EmpID[0];
            A251OrdenDetDetalle = P001O4_A251OrdenDetDetalle[0];
            n251OrdenDetDetalle = P001O4_n251OrdenDetDetalle[0];
            A397OrdenDesp = P001O4_A397OrdenDesp[0];
            n397OrdenDesp = P001O4_n397OrdenDesp[0];
            A41OrdenSecId = P001O4_A41OrdenSecId[0];
            A397OrdenDesp = AV24OrdenDesp;
            n397OrdenDesp = false;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            /* Using cursor P001O5 */
            pr_default.execute(3, new Object[] {n397OrdenDesp, A397OrdenDesp, A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID, A41OrdenSecId});
            pr_default.close(3);
            dsDefault.SmartCacheProvider.SetUpdated("OrdenProduccionOpItems") ;
            if (true) break;
            /* Using cursor P001O6 */
            pr_default.execute(4, new Object[] {n397OrdenDesp, A397OrdenDesp, A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID, A41OrdenSecId});
            pr_default.close(4);
            dsDefault.SmartCacheProvider.SetUpdated("OrdenProduccionOpItems") ;
            pr_default.readNext(2);
         }
         pr_default.close(2);
      }

      public override void cleanup( )
      {
         context.CommitDataStores("prcadddespbodega",pr_default);
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
         P001O2_A32categID = new short[1] ;
         P001O2_A397OrdenDesp = new short[1] ;
         P001O2_n397OrdenDesp = new bool[] {false} ;
         P001O2_A396OrdenDetDesp = new short[1] ;
         P001O2_n396OrdenDetDesp = new bool[] {false} ;
         P001O2_A22OrdenID = new short[1] ;
         P001O2_A25OrdenAnio = new short[1] ;
         P001O2_A24OrdenPeriodo = new short[1] ;
         P001O2_A1EmpID = new short[1] ;
         P001O2_A148subCatDsc = new String[] {""} ;
         P001O2_n148subCatDsc = new bool[] {false} ;
         P001O2_A33subCatID = new short[1] ;
         P001O2_A251OrdenDetDetalle = new String[] {""} ;
         P001O2_n251OrdenDetDetalle = new bool[] {false} ;
         P001O2_A150subCatPrec = new decimal[1] ;
         P001O2_n150subCatPrec = new bool[] {false} ;
         P001O2_A208OrdenDetCant = new decimal[1] ;
         P001O2_n208OrdenDetCant = new bool[] {false} ;
         P001O2_A5ClienteID = new short[1] ;
         P001O2_A41OrdenSecId = new short[1] ;
         A148subCatDsc = "";
         A251OrdenDetDetalle = "";
         AV17prdNombre = "";
         AV20DespBodDetalle = "";
         AV14DespBodPrdNombre = "";
         P001O3_A309prdNombre = new String[] {""} ;
         P001O3_n309prdNombre = new bool[] {false} ;
         P001O3_A2AgeID = new short[1] ;
         P001O3_A1EmpID = new short[1] ;
         P001O3_A286PrdCod = new short[1] ;
         A309prdNombre = "";
         P001O4_A33subCatID = new short[1] ;
         P001O4_A22OrdenID = new short[1] ;
         P001O4_A25OrdenAnio = new short[1] ;
         P001O4_A24OrdenPeriodo = new short[1] ;
         P001O4_A5ClienteID = new short[1] ;
         P001O4_A1EmpID = new short[1] ;
         P001O4_A251OrdenDetDetalle = new String[] {""} ;
         P001O4_n251OrdenDetDetalle = new bool[] {false} ;
         P001O4_A397OrdenDesp = new short[1] ;
         P001O4_n397OrdenDesp = new bool[] {false} ;
         P001O4_A41OrdenSecId = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.prcadddespbodega__default(),
            new Object[][] {
                new Object[] {
               P001O2_A32categID, P001O2_A397OrdenDesp, P001O2_n397OrdenDesp, P001O2_A396OrdenDetDesp, P001O2_n396OrdenDetDesp, P001O2_A22OrdenID, P001O2_A25OrdenAnio, P001O2_A24OrdenPeriodo, P001O2_A1EmpID, P001O2_A148subCatDsc,
               P001O2_n148subCatDsc, P001O2_A33subCatID, P001O2_A251OrdenDetDetalle, P001O2_n251OrdenDetDetalle, P001O2_A150subCatPrec, P001O2_n150subCatPrec, P001O2_A208OrdenDetCant, P001O2_n208OrdenDetCant, P001O2_A5ClienteID, P001O2_A41OrdenSecId
               }
               , new Object[] {
               P001O3_A309prdNombre, P001O3_n309prdNombre, P001O3_A2AgeID, P001O3_A1EmpID, P001O3_A286PrdCod
               }
               , new Object[] {
               P001O4_A33subCatID, P001O4_A22OrdenID, P001O4_A25OrdenAnio, P001O4_A24OrdenPeriodo, P001O4_A5ClienteID, P001O4_A1EmpID, P001O4_A251OrdenDetDetalle, P001O4_n251OrdenDetDetalle, P001O4_A397OrdenDesp, P001O4_n397OrdenDesp,
               P001O4_A41OrdenSecId
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
      private short AV16AgeID ;
      private short AV12ClienteID ;
      private short AV11OrdenPeriodo ;
      private short AV10OrdenAnio ;
      private short AV9OrdenID ;
      private short A32categID ;
      private short A397OrdenDesp ;
      private short A396OrdenDetDesp ;
      private short A22OrdenID ;
      private short A25OrdenAnio ;
      private short A24OrdenPeriodo ;
      private short A1EmpID ;
      private short A33subCatID ;
      private short A5ClienteID ;
      private short A41OrdenSecId ;
      private short AV15DespBodCatId ;
      private short AV21exist ;
      private short AV13DespBodCodPrd ;
      private short AV24OrdenDesp ;
      private short A2AgeID ;
      private short A286PrdCod ;
      private decimal A150subCatPrec ;
      private decimal A208OrdenDetCant ;
      private decimal A209OrdenDetVal ;
      private decimal AV18DespBodCant ;
      private decimal AV19DespBodValor ;
      private String scmdbuf ;
      private String A148subCatDsc ;
      private String AV20DespBodDetalle ;
      private String AV14DespBodPrdNombre ;
      private bool n397OrdenDesp ;
      private bool n396OrdenDetDesp ;
      private bool n148subCatDsc ;
      private bool n251OrdenDetDetalle ;
      private bool n150subCatPrec ;
      private bool n208OrdenDetCant ;
      private bool returnInSub ;
      private bool n309prdNombre ;
      private String A251OrdenDetDetalle ;
      private String AV17prdNombre ;
      private String A309prdNombre ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P001O2_A32categID ;
      private short[] P001O2_A397OrdenDesp ;
      private bool[] P001O2_n397OrdenDesp ;
      private short[] P001O2_A396OrdenDetDesp ;
      private bool[] P001O2_n396OrdenDetDesp ;
      private short[] P001O2_A22OrdenID ;
      private short[] P001O2_A25OrdenAnio ;
      private short[] P001O2_A24OrdenPeriodo ;
      private short[] P001O2_A1EmpID ;
      private String[] P001O2_A148subCatDsc ;
      private bool[] P001O2_n148subCatDsc ;
      private short[] P001O2_A33subCatID ;
      private String[] P001O2_A251OrdenDetDetalle ;
      private bool[] P001O2_n251OrdenDetDetalle ;
      private decimal[] P001O2_A150subCatPrec ;
      private bool[] P001O2_n150subCatPrec ;
      private decimal[] P001O2_A208OrdenDetCant ;
      private bool[] P001O2_n208OrdenDetCant ;
      private short[] P001O2_A5ClienteID ;
      private short[] P001O2_A41OrdenSecId ;
      private String[] P001O3_A309prdNombre ;
      private bool[] P001O3_n309prdNombre ;
      private short[] P001O3_A2AgeID ;
      private short[] P001O3_A1EmpID ;
      private short[] P001O3_A286PrdCod ;
      private short[] P001O4_A33subCatID ;
      private short[] P001O4_A22OrdenID ;
      private short[] P001O4_A25OrdenAnio ;
      private short[] P001O4_A24OrdenPeriodo ;
      private short[] P001O4_A5ClienteID ;
      private short[] P001O4_A1EmpID ;
      private String[] P001O4_A251OrdenDetDetalle ;
      private bool[] P001O4_n251OrdenDetDetalle ;
      private short[] P001O4_A397OrdenDesp ;
      private bool[] P001O4_n397OrdenDesp ;
      private short[] P001O4_A41OrdenSecId ;
   }

   public class prcadddespbodega__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new UpdateCursor(def[3])
         ,new UpdateCursor(def[4])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001O2 ;
          prmP001O2 = new Object[] {
          new Object[] {"@AV8EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV10OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001O3 ;
          prmP001O3 = new Object[] {
          new Object[] {"@AV8EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV16AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV17prdNombre",SqlDbType.VarChar,80,0}
          } ;
          Object[] prmP001O4 ;
          prmP001O4 = new Object[] {
          new Object[] {"@AV8EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV10OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV15DespBodCatId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001O5 ;
          prmP001O5 = new Object[] {
          new Object[] {"@OrdenDesp",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenSecId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001O6 ;
          prmP001O6 = new Object[] {
          new Object[] {"@OrdenDesp",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenSecId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001O2", "SELECT T1.[categID], T1.[OrdenDesp], T1.[OrdenDetDesp], T1.[OrdenID], T1.[OrdenAnio], T1.[OrdenPeriodo], T1.[EmpID], T2.[subCatDsc], T1.[subCatID], T1.[OrdenDetDetalle], T2.[subCatPrec], T1.[OrdenDetCant], T1.[ClienteID], T1.[OrdenSecId] FROM ([OrdenProduccionOpItems] T1 WITH (NOLOCK) INNER JOIN [CategoriassubCat] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[categID] = T1.[categID] AND T2.[subCatID] = T1.[subCatID]) WHERE (T1.[EmpID] = @AV8EmpID) AND (T1.[OrdenPeriodo] = @AV11OrdenPeriodo) AND (T1.[OrdenAnio] = @AV10OrdenAnio) AND (T1.[OrdenID] = @AV9OrdenID) AND (T1.[OrdenDetDesp] = 1) AND (T1.[OrdenDesp] = 0) ORDER BY T1.[EmpID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001O2,100,0,true,false )
             ,new CursorDef("P001O3", "SELECT TOP 1 [prdNombre], [AgeID], [EmpID], [PrdCod] FROM [Productos] WITH (NOLOCK) WHERE ([EmpID] = @AV8EmpID and [AgeID] = @AV16AgeID) AND ([prdNombre] = @AV17prdNombre) ORDER BY [EmpID], [AgeID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001O3,1,0,false,true )
             ,new CursorDef("P001O4", "SELECT TOP 1 [subCatID], [OrdenID], [OrdenAnio], [OrdenPeriodo], [ClienteID], [EmpID], [OrdenDetDetalle], [OrdenDesp], [OrdenSecId] FROM [OrdenProduccionOpItems] WITH (UPDLOCK) WHERE ([EmpID] = @AV8EmpID and [ClienteID] = @AV12ClienteID and [OrdenPeriodo] = @AV11OrdenPeriodo and [OrdenAnio] = @AV10OrdenAnio and [OrdenID] = @AV9OrdenID) AND ([subCatID] = @AV15DespBodCatId) ORDER BY [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001O4,1,0,true,true )
             ,new CursorDef("P001O5", "UPDATE [OrdenProduccionOpItems] SET [OrdenDesp]=@OrdenDesp  WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID AND [OrdenPeriodo] = @OrdenPeriodo AND [OrdenAnio] = @OrdenAnio AND [OrdenID] = @OrdenID AND [OrdenSecId] = @OrdenSecId", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001O5)
             ,new CursorDef("P001O6", "UPDATE [OrdenProduccionOpItems] SET [OrdenDesp]=@OrdenDesp  WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID AND [OrdenPeriodo] = @OrdenPeriodo AND [OrdenAnio] = @OrdenAnio AND [OrdenID] = @OrdenID AND [OrdenSecId] = @OrdenSecId", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001O6)
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
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((short[]) buf[6])[0] = rslt.getShort(5) ;
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                ((short[]) buf[8])[0] = rslt.getShort(7) ;
                ((String[]) buf[9])[0] = rslt.getString(8, 40) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(8);
                ((short[]) buf[11])[0] = rslt.getShort(9) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                ((decimal[]) buf[14])[0] = rslt.getDecimal(11) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(11);
                ((decimal[]) buf[16])[0] = rslt.getDecimal(12) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(12);
                ((short[]) buf[18])[0] = rslt.getShort(13) ;
                ((short[]) buf[19])[0] = rslt.getShort(14) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                ((short[]) buf[8])[0] = rslt.getShort(8) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((short[]) buf[10])[0] = rslt.getShort(9) ;
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
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 3 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                stmt.SetParameter(2, (short)parms[2]);
                stmt.SetParameter(3, (short)parms[3]);
                stmt.SetParameter(4, (short)parms[4]);
                stmt.SetParameter(5, (short)parms[5]);
                stmt.SetParameter(6, (short)parms[6]);
                stmt.SetParameter(7, (short)parms[7]);
                return;
             case 4 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                stmt.SetParameter(2, (short)parms[2]);
                stmt.SetParameter(3, (short)parms[3]);
                stmt.SetParameter(4, (short)parms[4]);
                stmt.SetParameter(5, (short)parms[5]);
                stmt.SetParameter(6, (short)parms[6]);
                stmt.SetParameter(7, (short)parms[7]);
                return;
       }
    }

 }

}
