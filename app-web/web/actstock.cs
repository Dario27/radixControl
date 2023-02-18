/*
               File: actStock
        Description: act Stock
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/23/2023 0:53:59.13
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
   public class actstock : GXProcedure
   {
      public actstock( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public actstock( IGxContext context )
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
                           short aP2_clienteiD ,
                           short aP3_BodCod ,
                           short aP4_DespBodCodPrd ,
                           decimal aP5_cantidad ,
                           short aP6_OrdenID ,
                           String aP7_DespBodModifItem )
      {
         this.AV10EmpID = aP0_EmpID;
         this.AV11AgeID = aP1_AgeID;
         this.AV18clienteiD = aP2_clienteiD;
         this.AV14BodCod = aP3_BodCod;
         this.AV13DespBodCodPrd = aP4_DespBodCodPrd;
         this.AV16cantidad = aP5_cantidad;
         this.AV17OrdenID = aP6_OrdenID;
         this.AV22DespBodModifItem = aP7_DespBodModifItem;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_EmpID ,
                                 short aP1_AgeID ,
                                 short aP2_clienteiD ,
                                 short aP3_BodCod ,
                                 short aP4_DespBodCodPrd ,
                                 decimal aP5_cantidad ,
                                 short aP6_OrdenID ,
                                 String aP7_DespBodModifItem )
      {
         actstock objactstock;
         objactstock = new actstock();
         objactstock.AV10EmpID = aP0_EmpID;
         objactstock.AV11AgeID = aP1_AgeID;
         objactstock.AV18clienteiD = aP2_clienteiD;
         objactstock.AV14BodCod = aP3_BodCod;
         objactstock.AV13DespBodCodPrd = aP4_DespBodCodPrd;
         objactstock.AV16cantidad = aP5_cantidad;
         objactstock.AV17OrdenID = aP6_OrdenID;
         objactstock.AV22DespBodModifItem = aP7_DespBodModifItem;
         objactstock.context.SetSubmitInitialConfig(context);
         objactstock.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objactstock);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((actstock)stateInfo).executePrivate();
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
         S141 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         if ( StringUtil.StrCmp(AV22DespBodModifItem, "S") == 0 )
         {
            /* Execute user subroutine: 'ACTUALIZASTOCK' */
            S131 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
         }
         else
         {
            /* Execute user subroutine: 'INSERTSTOCK' */
            S111 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
         }
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'INSERTSTOCK' Routine */
         AV25GXLvl11 = 0;
         /* Using cursor P001H2 */
         pr_default.execute(0, new Object[] {AV19stockAnio, AV20stockMes, AV10EmpID, AV11AgeID, AV14BodCod, AV13DespBodCodPrd});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A286PrdCod = P001H2_A286PrdCod[0];
            A42BodCod = P001H2_A42BodCod[0];
            A2AgeID = P001H2_A2AgeID[0];
            A1EmpID = P001H2_A1EmpID[0];
            A291stockMes = P001H2_A291stockMes[0];
            A290stockAnio = P001H2_A290stockAnio[0];
            A298costo = P001H2_A298costo[0];
            n298costo = P001H2_n298costo[0];
            A348stockDetID = P001H2_A348stockDetID[0];
            AV25GXLvl11 = 1;
            AV15newCodStock = (short)((A348stockDetID+1));
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( AV25GXLvl11 == 0 )
         {
            AV15newCodStock = 1;
         }
         /*
            INSERT RECORD ON TABLE ProdxBodegaTipoInv

         */
         A290stockAnio = AV19stockAnio;
         A291stockMes = AV20stockMes;
         A1EmpID = AV10EmpID;
         A2AgeID = AV11AgeID;
         A42BodCod = AV14BodCod;
         A286PrdCod = AV13DespBodCodPrd;
         A348stockDetID = AV15newCodStock;
         A43TipoInv = "EPRO";
         A296cantidad = AV16cantidad;
         n296cantidad = false;
         A351stockDetNroDoc = AV17OrdenID;
         n351stockDetNroDoc = false;
         A5ClienteID = AV18clienteiD;
         A352stockdetTipo = "OP";
         n352stockdetTipo = false;
         A374fchMovStock = DateTimeUtil.ResetTime(DateTimeUtil.ServerNow( context, pr_default));
         n374fchMovStock = false;
         A375hraMovStock = DateTimeUtil.ResetDate(DateTimeUtil.ServerNow( context, pr_default));
         n375hraMovStock = false;
         /* Using cursor P001H3 */
         pr_default.execute(1, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod, A348stockDetID, A43TipoInv, n296cantidad, A296cantidad, n351stockDetNroDoc, A351stockDetNroDoc, n352stockdetTipo, A352stockdetTipo, A5ClienteID, n374fchMovStock, A374fchMovStock, n375hraMovStock, A375hraMovStock});
         pr_default.close(1);
         dsDefault.SmartCacheProvider.SetUpdated("ProdxBodegaTipoInv") ;
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
         /* Execute user subroutine: 'OBTCANTITEMS' */
         S121 ();
         if (returnInSub) return;
      }

      protected void S131( )
      {
         /* 'ACTUALIZASTOCK' Routine */
         /* Using cursor P001H4 */
         pr_default.execute(2, new Object[] {AV19stockAnio, AV20stockMes, AV10EmpID, AV11AgeID, AV14BodCod, AV13DespBodCodPrd, AV17OrdenID});
         while ( (pr_default.getStatus(2) != 101) )
         {
            A351stockDetNroDoc = P001H4_A351stockDetNroDoc[0];
            n351stockDetNroDoc = P001H4_n351stockDetNroDoc[0];
            A286PrdCod = P001H4_A286PrdCod[0];
            A42BodCod = P001H4_A42BodCod[0];
            A2AgeID = P001H4_A2AgeID[0];
            A1EmpID = P001H4_A1EmpID[0];
            A291stockMes = P001H4_A291stockMes[0];
            A290stockAnio = P001H4_A290stockAnio[0];
            A296cantidad = P001H4_A296cantidad[0];
            n296cantidad = P001H4_n296cantidad[0];
            A348stockDetID = P001H4_A348stockDetID[0];
            A296cantidad = AV16cantidad;
            n296cantidad = false;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            /* Using cursor P001H5 */
            pr_default.execute(3, new Object[] {n296cantidad, A296cantidad, A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod, A348stockDetID});
            pr_default.close(3);
            dsDefault.SmartCacheProvider.SetUpdated("ProdxBodegaTipoInv") ;
            if (true) break;
            /* Using cursor P001H6 */
            pr_default.execute(4, new Object[] {n296cantidad, A296cantidad, A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod, A348stockDetID});
            pr_default.close(4);
            dsDefault.SmartCacheProvider.SetUpdated("ProdxBodegaTipoInv") ;
            pr_default.readNext(2);
         }
         pr_default.close(2);
      }

      protected void S141( )
      {
         /* 'OBTPERIODO' Routine */
         /* Using cursor P001H7 */
         pr_default.execute(5, new Object[] {AV10EmpID, AV11AgeID, AV13DespBodCodPrd, AV14BodCod});
         while ( (pr_default.getStatus(5) != 101) )
         {
            A286PrdCod = P001H7_A286PrdCod[0];
            A42BodCod = P001H7_A42BodCod[0];
            A2AgeID = P001H7_A2AgeID[0];
            A1EmpID = P001H7_A1EmpID[0];
            A290stockAnio = P001H7_A290stockAnio[0];
            A291stockMes = P001H7_A291stockMes[0];
            AV19stockAnio = A290stockAnio;
            AV20stockMes = A291stockMes;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(5);
         }
         pr_default.close(5);
      }

      protected void S121( )
      {
         /* 'OBTCANTITEMS' Routine */
         AV21totItems = 0;
         /* Optimized group. */
         /* Using cursor P001H8 */
         pr_default.execute(6, new Object[] {AV19stockAnio, AV20stockMes, AV10EmpID, AV11AgeID, AV14BodCod, AV13DespBodCodPrd});
         cV21totItems = P001H8_AV21totItems[0];
         pr_default.close(6);
         AV21totItems = (short)(AV21totItems+cV21totItems*1);
         /* End optimized group. */
         /* Execute user subroutine: 'ACTSTOCKULTNRO' */
         S151 ();
         if (returnInSub) return;
      }

      protected void S151( )
      {
         /* 'ACTSTOCKULTNRO' Routine */
         /* Optimized UPDATE. */
         /* Using cursor P001H9 */
         pr_default.execute(7, new Object[] {n350stockUltNro, AV21totItems, AV19stockAnio, AV20stockMes, AV10EmpID, AV11AgeID, AV14BodCod, AV13DespBodCodPrd});
         pr_default.close(7);
         dsDefault.SmartCacheProvider.SetUpdated("ProdxBodega") ;
         /* End optimized UPDATE. */
      }

      public override void cleanup( )
      {
         context.CommitDataStores("actstock",pr_default);
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
         P001H2_A286PrdCod = new short[1] ;
         P001H2_A42BodCod = new short[1] ;
         P001H2_A2AgeID = new short[1] ;
         P001H2_A1EmpID = new short[1] ;
         P001H2_A291stockMes = new short[1] ;
         P001H2_A290stockAnio = new short[1] ;
         P001H2_A298costo = new decimal[1] ;
         P001H2_n298costo = new bool[] {false} ;
         P001H2_A348stockDetID = new short[1] ;
         A43TipoInv = "";
         A352stockdetTipo = "";
         A374fchMovStock = DateTime.MinValue;
         A375hraMovStock = (DateTime)(DateTime.MinValue);
         Gx_emsg = "";
         P001H4_A351stockDetNroDoc = new short[1] ;
         P001H4_n351stockDetNroDoc = new bool[] {false} ;
         P001H4_A286PrdCod = new short[1] ;
         P001H4_A42BodCod = new short[1] ;
         P001H4_A2AgeID = new short[1] ;
         P001H4_A1EmpID = new short[1] ;
         P001H4_A291stockMes = new short[1] ;
         P001H4_A290stockAnio = new short[1] ;
         P001H4_A296cantidad = new decimal[1] ;
         P001H4_n296cantidad = new bool[] {false} ;
         P001H4_A348stockDetID = new short[1] ;
         P001H7_A286PrdCod = new short[1] ;
         P001H7_A42BodCod = new short[1] ;
         P001H7_A2AgeID = new short[1] ;
         P001H7_A1EmpID = new short[1] ;
         P001H7_A290stockAnio = new short[1] ;
         P001H7_A291stockMes = new short[1] ;
         P001H8_AV21totItems = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.actstock__default(),
            new Object[][] {
                new Object[] {
               P001H2_A286PrdCod, P001H2_A42BodCod, P001H2_A2AgeID, P001H2_A1EmpID, P001H2_A291stockMes, P001H2_A290stockAnio, P001H2_A298costo, P001H2_n298costo, P001H2_A348stockDetID
               }
               , new Object[] {
               }
               , new Object[] {
               P001H4_A351stockDetNroDoc, P001H4_n351stockDetNroDoc, P001H4_A286PrdCod, P001H4_A42BodCod, P001H4_A2AgeID, P001H4_A1EmpID, P001H4_A291stockMes, P001H4_A290stockAnio, P001H4_A296cantidad, P001H4_n296cantidad,
               P001H4_A348stockDetID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               P001H7_A286PrdCod, P001H7_A42BodCod, P001H7_A2AgeID, P001H7_A1EmpID, P001H7_A290stockAnio, P001H7_A291stockMes
               }
               , new Object[] {
               P001H8_AV21totItems
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV10EmpID ;
      private short AV11AgeID ;
      private short AV18clienteiD ;
      private short AV14BodCod ;
      private short AV13DespBodCodPrd ;
      private short AV17OrdenID ;
      private short AV25GXLvl11 ;
      private short AV19stockAnio ;
      private short AV20stockMes ;
      private short A286PrdCod ;
      private short A42BodCod ;
      private short A2AgeID ;
      private short A1EmpID ;
      private short A291stockMes ;
      private short A290stockAnio ;
      private short A348stockDetID ;
      private short AV15newCodStock ;
      private short A351stockDetNroDoc ;
      private short A5ClienteID ;
      private short AV21totItems ;
      private short cV21totItems ;
      private short A350stockUltNro ;
      private int GX_INS85 ;
      private decimal AV16cantidad ;
      private decimal A298costo ;
      private decimal A296cantidad ;
      private String AV22DespBodModifItem ;
      private String scmdbuf ;
      private String A43TipoInv ;
      private String A352stockdetTipo ;
      private String Gx_emsg ;
      private DateTime A375hraMovStock ;
      private DateTime A374fchMovStock ;
      private bool returnInSub ;
      private bool n298costo ;
      private bool n296cantidad ;
      private bool n351stockDetNroDoc ;
      private bool n352stockdetTipo ;
      private bool n374fchMovStock ;
      private bool n375hraMovStock ;
      private bool n350stockUltNro ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P001H2_A286PrdCod ;
      private short[] P001H2_A42BodCod ;
      private short[] P001H2_A2AgeID ;
      private short[] P001H2_A1EmpID ;
      private short[] P001H2_A291stockMes ;
      private short[] P001H2_A290stockAnio ;
      private decimal[] P001H2_A298costo ;
      private bool[] P001H2_n298costo ;
      private short[] P001H2_A348stockDetID ;
      private short[] P001H4_A351stockDetNroDoc ;
      private bool[] P001H4_n351stockDetNroDoc ;
      private short[] P001H4_A286PrdCod ;
      private short[] P001H4_A42BodCod ;
      private short[] P001H4_A2AgeID ;
      private short[] P001H4_A1EmpID ;
      private short[] P001H4_A291stockMes ;
      private short[] P001H4_A290stockAnio ;
      private decimal[] P001H4_A296cantidad ;
      private bool[] P001H4_n296cantidad ;
      private short[] P001H4_A348stockDetID ;
      private short[] P001H7_A286PrdCod ;
      private short[] P001H7_A42BodCod ;
      private short[] P001H7_A2AgeID ;
      private short[] P001H7_A1EmpID ;
      private short[] P001H7_A290stockAnio ;
      private short[] P001H7_A291stockMes ;
      private short[] P001H8_AV21totItems ;
   }

   public class actstock__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new UpdateCursor(def[3])
         ,new UpdateCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new UpdateCursor(def[7])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001H2 ;
          prmP001H2 = new Object[] {
          new Object[] {"@AV19stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV20stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV10EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV14BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV13DespBodCodPrd",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001H3 ;
          prmP001H3 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockDetID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0} ,
          new Object[] {"@cantidad",SqlDbType.Decimal,9,2} ,
          new Object[] {"@stockDetNroDoc",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockdetTipo",SqlDbType.Char,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@fchMovStock",SqlDbType.DateTime,8,0} ,
          new Object[] {"@hraMovStock",SqlDbType.DateTime,0,5}
          } ;
          Object[] prmP001H4 ;
          prmP001H4 = new Object[] {
          new Object[] {"@AV19stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV20stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV10EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV14BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV13DespBodCodPrd",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV17OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001H5 ;
          prmP001H5 = new Object[] {
          new Object[] {"@cantidad",SqlDbType.Decimal,9,2} ,
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockDetID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001H6 ;
          prmP001H6 = new Object[] {
          new Object[] {"@cantidad",SqlDbType.Decimal,9,2} ,
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockDetID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001H7 ;
          prmP001H7 = new Object[] {
          new Object[] {"@AV10EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV13DespBodCodPrd",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV14BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001H8 ;
          prmP001H8 = new Object[] {
          new Object[] {"@AV19stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV20stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV10EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV14BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV13DespBodCodPrd",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001H9 ;
          prmP001H9 = new Object[] {
          new Object[] {"@stockUltNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV19stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV20stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV10EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV14BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV13DespBodCodPrd",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001H2", "SELECT TOP 1 [PrdCod], [BodCod], [AgeID], [EmpID], [stockMes], [stockAnio], [costo], [stockDetID] FROM [ProdxBodegaTipoInv] WITH (NOLOCK) WHERE [stockAnio] = @AV19stockAnio and [stockMes] = @AV20stockMes and [EmpID] = @AV10EmpID and [AgeID] = @AV11AgeID and [BodCod] = @AV14BodCod and [PrdCod] = @AV13DespBodCodPrd ORDER BY [stockAnio] DESC, [stockMes] DESC, [EmpID] DESC, [AgeID] DESC, [BodCod] DESC, [PrdCod] DESC, [stockDetID] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001H2,1,0,false,true )
             ,new CursorDef("P001H3", "INSERT INTO [ProdxBodegaTipoInv]([stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod], [stockDetID], [TipoInv], [cantidad], [stockDetNroDoc], [stockdetTipo], [ClienteID], [fchMovStock], [hraMovStock], [stock], [costo]) VALUES(@stockAnio, @stockMes, @EmpID, @AgeID, @BodCod, @PrdCod, @stockDetID, @TipoInv, @cantidad, @stockDetNroDoc, @stockdetTipo, @ClienteID, @fchMovStock, @hraMovStock, convert(int, 0), convert(int, 0))", GxErrorMask.GX_NOMASK,prmP001H3)
             ,new CursorDef("P001H4", "SELECT TOP 1 [stockDetNroDoc], [PrdCod], [BodCod], [AgeID], [EmpID], [stockMes], [stockAnio], [cantidad], [stockDetID] FROM [ProdxBodegaTipoInv] WITH (UPDLOCK) WHERE ([stockAnio] = @AV19stockAnio and [stockMes] = @AV20stockMes and [EmpID] = @AV10EmpID and [AgeID] = @AV11AgeID and [BodCod] = @AV14BodCod and [PrdCod] = @AV13DespBodCodPrd) AND ([stockDetNroDoc] = @AV17OrdenID) ORDER BY [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001H4,1,0,true,true )
             ,new CursorDef("P001H5", "UPDATE [ProdxBodegaTipoInv] SET [cantidad]=@cantidad  WHERE [stockAnio] = @stockAnio AND [stockMes] = @stockMes AND [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [PrdCod] = @PrdCod AND [stockDetID] = @stockDetID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001H5)
             ,new CursorDef("P001H6", "UPDATE [ProdxBodegaTipoInv] SET [cantidad]=@cantidad  WHERE [stockAnio] = @stockAnio AND [stockMes] = @stockMes AND [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [PrdCod] = @PrdCod AND [stockDetID] = @stockDetID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001H6)
             ,new CursorDef("P001H7", "SELECT TOP 1 [PrdCod], [BodCod], [AgeID], [EmpID], [stockAnio], [stockMes] FROM [ProdxBodega] WITH (NOLOCK) WHERE ([EmpID] = @AV10EmpID and [AgeID] = @AV11AgeID and [PrdCod] = @AV13DespBodCodPrd) AND ([BodCod] = @AV14BodCod) ORDER BY [EmpID], [AgeID], [PrdCod] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001H7,1,0,false,true )
             ,new CursorDef("P001H8", "SELECT COUNT(*) FROM [ProdxBodegaTipoInv] WITH (NOLOCK) WHERE [stockAnio] = @AV19stockAnio and [stockMes] = @AV20stockMes and [EmpID] = @AV10EmpID and [AgeID] = @AV11AgeID and [BodCod] = @AV14BodCod and [PrdCod] = @AV13DespBodCodPrd ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001H8,1,0,true,false )
             ,new CursorDef("P001H9", "UPDATE [ProdxBodega] SET [stockUltNro]=@stockUltNro  WHERE [stockAnio] = @AV19stockAnio and [stockMes] = @AV20stockMes and [EmpID] = @AV10EmpID and [AgeID] = @AV11AgeID and [BodCod] = @AV14BodCod and [PrdCod] = @AV13DespBodCodPrd", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001H9)
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                ((short[]) buf[7])[0] = rslt.getShort(7) ;
                ((decimal[]) buf[8])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((short[]) buf[10])[0] = rslt.getShort(9) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 6 :
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
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 10 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(10, (short)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 11 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(11, (String)parms[13]);
                }
                stmt.SetParameter(12, (short)parms[14]);
                if ( (bool)parms[15] )
                {
                   stmt.setNull( 13 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(13, (DateTime)parms[16]);
                }
                if ( (bool)parms[17] )
                {
                   stmt.setNull( 14 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(14, (DateTime)parms[18]);
                }
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                return;
             case 3 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (decimal)parms[1]);
                }
                stmt.SetParameter(2, (short)parms[2]);
                stmt.SetParameter(3, (short)parms[3]);
                stmt.SetParameter(4, (short)parms[4]);
                stmt.SetParameter(5, (short)parms[5]);
                stmt.SetParameter(6, (short)parms[6]);
                stmt.SetParameter(7, (short)parms[7]);
                stmt.SetParameter(8, (short)parms[8]);
                return;
             case 4 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (decimal)parms[1]);
                }
                stmt.SetParameter(2, (short)parms[2]);
                stmt.SetParameter(3, (short)parms[3]);
                stmt.SetParameter(4, (short)parms[4]);
                stmt.SetParameter(5, (short)parms[5]);
                stmt.SetParameter(6, (short)parms[6]);
                stmt.SetParameter(7, (short)parms[7]);
                stmt.SetParameter(8, (short)parms[8]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 7 :
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
