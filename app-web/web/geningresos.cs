/*
               File: genIngresos
        Description: gen Ingresos
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/9/2023 12:19:46.0
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
   public class geningresos : GXProcedure
   {
      public geningresos( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public geningresos( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_OrdenAnio ,
                           short aP1_OrdenPeriodo ,
                           String aP2_PrvRuc ,
                           short aP3_EmpID ,
                           short aP4_AgeID ,
                           short aP5_BodCod ,
                           short aP6_DespBodCodPrd ,
                           decimal aP7_cantidad ,
                           short aP8_OrdenID )
      {
         this.AV19OrdenAnio = aP0_OrdenAnio;
         this.AV20OrdenPeriodo = aP1_OrdenPeriodo;
         this.AV21PrvRuc = aP2_PrvRuc;
         this.AV10EmpID = aP3_EmpID;
         this.AV11AgeID = aP4_AgeID;
         this.AV12BodCod = aP5_BodCod;
         this.AV13DespBodCodPrd = aP6_DespBodCodPrd;
         this.AV15cantidad = aP7_cantidad;
         this.AV16OrdenID = aP8_OrdenID;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_OrdenAnio ,
                                 short aP1_OrdenPeriodo ,
                                 String aP2_PrvRuc ,
                                 short aP3_EmpID ,
                                 short aP4_AgeID ,
                                 short aP5_BodCod ,
                                 short aP6_DespBodCodPrd ,
                                 decimal aP7_cantidad ,
                                 short aP8_OrdenID )
      {
         geningresos objgeningresos;
         objgeningresos = new geningresos();
         objgeningresos.AV19OrdenAnio = aP0_OrdenAnio;
         objgeningresos.AV20OrdenPeriodo = aP1_OrdenPeriodo;
         objgeningresos.AV21PrvRuc = aP2_PrvRuc;
         objgeningresos.AV10EmpID = aP3_EmpID;
         objgeningresos.AV11AgeID = aP4_AgeID;
         objgeningresos.AV12BodCod = aP5_BodCod;
         objgeningresos.AV13DespBodCodPrd = aP6_DespBodCodPrd;
         objgeningresos.AV15cantidad = aP7_cantidad;
         objgeningresos.AV16OrdenID = aP8_OrdenID;
         objgeningresos.context.SetSubmitInitialConfig(context);
         objgeningresos.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objgeningresos);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((geningresos)stateInfo).executePrivate();
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
         /* Execute user subroutine: 'OBTPERIODO' */
         S121 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV24GXLvl2 = 0;
         /* Using cursor P001I2 */
         pr_default.execute(0, new Object[] {AV8stockAnio, AV9stockMes, AV10EmpID, AV11AgeID, AV12BodCod, AV13DespBodCodPrd});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A286PrdCod = P001I2_A286PrdCod[0];
            A42BodCod = P001I2_A42BodCod[0];
            A2AgeID = P001I2_A2AgeID[0];
            A1EmpID = P001I2_A1EmpID[0];
            A291stockMes = P001I2_A291stockMes[0];
            A290stockAnio = P001I2_A290stockAnio[0];
            A386ingCantidad = P001I2_A386ingCantidad[0];
            n386ingCantidad = P001I2_n386ingCantidad[0];
            A389stockDetIngID = P001I2_A389stockDetIngID[0];
            AV24GXLvl2 = 1;
            AV14newCodStock = (short)((A389stockDetIngID+1));
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( AV24GXLvl2 == 0 )
         {
            AV14newCodStock = 1;
         }
         /* Execute user subroutine: 'ACTUALIZASTOCK' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         GX_msglist.addItem("proceso ok"+StringUtil.Str( (decimal)(AV14newCodStock), 4, 0));
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'ACTUALIZASTOCK' Routine */
         /*
            INSERT RECORD ON TABLE ProdStockBodegastockDetEgr

         */
         A290stockAnio = AV8stockAnio;
         A291stockMes = AV9stockMes;
         A1EmpID = AV10EmpID;
         A2AgeID = AV11AgeID;
         A42BodCod = AV12BodCod;
         A286PrdCod = AV13DespBodCodPrd;
         A389stockDetIngID = AV14newCodStock;
         A383ingTipoInv = "ING";
         A386ingCantidad = AV15cantidad;
         n386ingCantidad = false;
         A37PrvRuc = AV21PrvRuc;
         A390ingBodNroDoc = AV16OrdenID;
         n390ingBodNroDoc = false;
         A391ingBodTipoDoc = "ING";
         n391ingBodTipoDoc = false;
         A387fchMovIng = DateTimeUtil.ResetTime(DateTimeUtil.ServerNow( context, pr_default));
         n387fchMovIng = false;
         A388hraMovIng = DateTimeUtil.ResetDate(DateTimeUtil.ServerNow( context, pr_default));
         n388hraMovIng = false;
         /* Using cursor P001I3 */
         pr_default.execute(1, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod, A389stockDetIngID, A383ingTipoInv, n386ingCantidad, A386ingCantidad, A37PrvRuc, n387fchMovIng, A387fchMovIng, n388hraMovIng, A388hraMovIng, n390ingBodNroDoc, A390ingBodNroDoc, n391ingBodTipoDoc, A391ingBodTipoDoc});
         pr_default.close(1);
         dsDefault.SmartCacheProvider.SetUpdated("ProdStockBodegastockDetEgr") ;
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

      protected void S121( )
      {
         /* 'OBTPERIODO' Routine */
         /* Using cursor P001I4 */
         pr_default.execute(2, new Object[] {AV10EmpID, AV11AgeID, AV13DespBodCodPrd, AV12BodCod});
         while ( (pr_default.getStatus(2) != 101) )
         {
            A286PrdCod = P001I4_A286PrdCod[0];
            A42BodCod = P001I4_A42BodCod[0];
            A2AgeID = P001I4_A2AgeID[0];
            A1EmpID = P001I4_A1EmpID[0];
            A290stockAnio = P001I4_A290stockAnio[0];
            A291stockMes = P001I4_A291stockMes[0];
            AV8stockAnio = A290stockAnio;
            AV9stockMes = A291stockMes;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(2);
         }
         pr_default.close(2);
      }

      protected void S131( )
      {
         /* 'OBTCANTITEMS' Routine */
         AV18totItems = 0;
         /* Optimized group. */
         /* Using cursor P001I5 */
         pr_default.execute(3, new Object[] {AV8stockAnio, AV9stockMes, AV10EmpID, AV11AgeID, AV12BodCod, AV13DespBodCodPrd});
         cV18totItems = P001I5_AV18totItems[0];
         pr_default.close(3);
         AV18totItems = (short)(AV18totItems+cV18totItems*1);
         /* End optimized group. */
      }

      protected void S141( )
      {
         /* 'ACTSTOCKULTNRO' Routine */
         /* Optimized UPDATE. */
         /* Using cursor P001I6 */
         pr_default.execute(4, new Object[] {n350stockUltNro, AV18totItems, AV8stockAnio, AV9stockMes, AV10EmpID, AV11AgeID, AV12BodCod, AV13DespBodCodPrd});
         pr_default.close(4);
         dsDefault.SmartCacheProvider.SetUpdated("ProdxBodega") ;
         /* End optimized UPDATE. */
      }

      public override void cleanup( )
      {
         context.CommitDataStores("geningresos",pr_default);
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
         P001I2_A286PrdCod = new short[1] ;
         P001I2_A42BodCod = new short[1] ;
         P001I2_A2AgeID = new short[1] ;
         P001I2_A1EmpID = new short[1] ;
         P001I2_A291stockMes = new short[1] ;
         P001I2_A290stockAnio = new short[1] ;
         P001I2_A386ingCantidad = new decimal[1] ;
         P001I2_n386ingCantidad = new bool[] {false} ;
         P001I2_A389stockDetIngID = new short[1] ;
         A383ingTipoInv = "";
         A37PrvRuc = "";
         A391ingBodTipoDoc = "";
         A387fchMovIng = DateTime.MinValue;
         A388hraMovIng = (DateTime)(DateTime.MinValue);
         Gx_emsg = "";
         P001I4_A286PrdCod = new short[1] ;
         P001I4_A42BodCod = new short[1] ;
         P001I4_A2AgeID = new short[1] ;
         P001I4_A1EmpID = new short[1] ;
         P001I4_A290stockAnio = new short[1] ;
         P001I4_A291stockMes = new short[1] ;
         P001I5_AV18totItems = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.geningresos__default(),
            new Object[][] {
                new Object[] {
               P001I2_A286PrdCod, P001I2_A42BodCod, P001I2_A2AgeID, P001I2_A1EmpID, P001I2_A291stockMes, P001I2_A290stockAnio, P001I2_A386ingCantidad, P001I2_n386ingCantidad, P001I2_A389stockDetIngID
               }
               , new Object[] {
               }
               , new Object[] {
               P001I4_A286PrdCod, P001I4_A42BodCod, P001I4_A2AgeID, P001I4_A1EmpID, P001I4_A290stockAnio, P001I4_A291stockMes
               }
               , new Object[] {
               P001I5_AV18totItems
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV19OrdenAnio ;
      private short AV20OrdenPeriodo ;
      private short AV10EmpID ;
      private short AV11AgeID ;
      private short AV12BodCod ;
      private short AV13DespBodCodPrd ;
      private short AV16OrdenID ;
      private short AV24GXLvl2 ;
      private short AV8stockAnio ;
      private short AV9stockMes ;
      private short A286PrdCod ;
      private short A42BodCod ;
      private short A2AgeID ;
      private short A1EmpID ;
      private short A291stockMes ;
      private short A290stockAnio ;
      private short A389stockDetIngID ;
      private short AV14newCodStock ;
      private short A390ingBodNroDoc ;
      private short AV18totItems ;
      private short cV18totItems ;
      private short A350stockUltNro ;
      private int GX_INS89 ;
      private decimal AV15cantidad ;
      private decimal A386ingCantidad ;
      private String AV21PrvRuc ;
      private String scmdbuf ;
      private String A383ingTipoInv ;
      private String A37PrvRuc ;
      private String A391ingBodTipoDoc ;
      private String Gx_emsg ;
      private DateTime A388hraMovIng ;
      private DateTime A387fchMovIng ;
      private bool returnInSub ;
      private bool n386ingCantidad ;
      private bool n390ingBodNroDoc ;
      private bool n391ingBodTipoDoc ;
      private bool n387fchMovIng ;
      private bool n388hraMovIng ;
      private bool n350stockUltNro ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P001I2_A286PrdCod ;
      private short[] P001I2_A42BodCod ;
      private short[] P001I2_A2AgeID ;
      private short[] P001I2_A1EmpID ;
      private short[] P001I2_A291stockMes ;
      private short[] P001I2_A290stockAnio ;
      private decimal[] P001I2_A386ingCantidad ;
      private bool[] P001I2_n386ingCantidad ;
      private short[] P001I2_A389stockDetIngID ;
      private short[] P001I4_A286PrdCod ;
      private short[] P001I4_A42BodCod ;
      private short[] P001I4_A2AgeID ;
      private short[] P001I4_A1EmpID ;
      private short[] P001I4_A290stockAnio ;
      private short[] P001I4_A291stockMes ;
      private short[] P001I5_AV18totItems ;
   }

   public class geningresos__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new UpdateCursor(def[4])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001I2 ;
          prmP001I2 = new Object[] {
          new Object[] {"@AV8stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV10EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV13DespBodCodPrd",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001I3 ;
          prmP001I3 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockDetIngID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingTipoInv",SqlDbType.Char,4,0} ,
          new Object[] {"@ingCantidad",SqlDbType.Decimal,9,2} ,
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0} ,
          new Object[] {"@fchMovIng",SqlDbType.DateTime,8,0} ,
          new Object[] {"@hraMovIng",SqlDbType.DateTime,0,5} ,
          new Object[] {"@ingBodNroDoc",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingBodTipoDoc",SqlDbType.Char,4,0}
          } ;
          Object[] prmP001I4 ;
          prmP001I4 = new Object[] {
          new Object[] {"@AV10EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV13DespBodCodPrd",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001I5 ;
          prmP001I5 = new Object[] {
          new Object[] {"@AV8stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV10EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV13DespBodCodPrd",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001I6 ;
          prmP001I6 = new Object[] {
          new Object[] {"@stockUltNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV10EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV13DespBodCodPrd",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001I2", "SELECT TOP 1 [PrdCod], [BodCod], [AgeID], [EmpID], [stockMes], [stockAnio], [ingCantidad], [stockDetIngID] FROM [ProdStockBodegastockDetEgr] WITH (NOLOCK) WHERE [stockAnio] = @AV8stockAnio and [stockMes] = @AV9stockMes and [EmpID] = @AV10EmpID and [AgeID] = @AV11AgeID and [BodCod] = @AV12BodCod and [PrdCod] = @AV13DespBodCodPrd ORDER BY [stockAnio] DESC, [stockMes] DESC, [EmpID] DESC, [AgeID] DESC, [BodCod] DESC, [PrdCod] DESC, [stockDetIngID] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001I2,1,0,false,true )
             ,new CursorDef("P001I3", "INSERT INTO [ProdStockBodegastockDetEgr]([stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod], [stockDetIngID], [ingTipoInv], [ingCantidad], [PrvRuc], [fchMovIng], [hraMovIng], [ingBodNroDoc], [ingBodTipoDoc]) VALUES(@stockAnio, @stockMes, @EmpID, @AgeID, @BodCod, @PrdCod, @stockDetIngID, @ingTipoInv, @ingCantidad, @PrvRuc, @fchMovIng, @hraMovIng, @ingBodNroDoc, @ingBodTipoDoc)", GxErrorMask.GX_NOMASK,prmP001I3)
             ,new CursorDef("P001I4", "SELECT TOP 1 [PrdCod], [BodCod], [AgeID], [EmpID], [stockAnio], [stockMes] FROM [ProdxBodega] WITH (NOLOCK) WHERE ([EmpID] = @AV10EmpID and [AgeID] = @AV11AgeID and [PrdCod] = @AV13DespBodCodPrd) AND ([BodCod] = @AV12BodCod) ORDER BY [EmpID], [AgeID], [PrdCod] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001I4,1,0,false,true )
             ,new CursorDef("P001I5", "SELECT COUNT(*) FROM [ProdxBodegaTipoInv] WITH (NOLOCK) WHERE [stockAnio] = @AV8stockAnio and [stockMes] = @AV9stockMes and [EmpID] = @AV10EmpID and [AgeID] = @AV11AgeID and [BodCod] = @AV12BodCod and [PrdCod] = @AV13DespBodCodPrd ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001I5,1,0,true,false )
             ,new CursorDef("P001I6", "UPDATE [ProdxBodega] SET [stockUltNro]=@stockUltNro  WHERE [stockAnio] = @AV8stockAnio and [stockMes] = @AV9stockMes and [EmpID] = @AV10EmpID and [AgeID] = @AV11AgeID and [BodCod] = @AV12BodCod and [PrdCod] = @AV13DespBodCodPrd", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001I6)
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
                ((short[]) buf[8])[0] = rslt.getShort(8) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
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
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 9 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(9, (decimal)parms[9]);
                }
                stmt.SetParameter(10, (String)parms[10]);
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 11 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(11, (DateTime)parms[12]);
                }
                if ( (bool)parms[13] )
                {
                   stmt.setNull( 12 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(12, (DateTime)parms[14]);
                }
                if ( (bool)parms[15] )
                {
                   stmt.setNull( 13 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(13, (short)parms[16]);
                }
                if ( (bool)parms[17] )
                {
                   stmt.setNull( 14 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(14, (String)parms[18]);
                }
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
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
