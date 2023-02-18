/*
               File: procesarProductos
        Description: procesar Productos
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 11/18/2022 2:8:24.98
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
   public class procesarproductos : GXProcedure
   {
      public procesarproductos( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public procesarproductos( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_EmpID ,
                           short aP1_tipoProdID )
      {
         this.AV9EmpID = aP0_EmpID;
         this.AV8tipoProdID = aP1_tipoProdID;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_EmpID ,
                                 short aP1_tipoProdID )
      {
         procesarproductos objprocesarproductos;
         objprocesarproductos = new procesarproductos();
         objprocesarproductos.AV9EmpID = aP0_EmpID;
         objprocesarproductos.AV8tipoProdID = aP1_tipoProdID;
         objprocesarproductos.context.SetSubmitInitialConfig(context);
         objprocesarproductos.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objprocesarproductos);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((procesarproductos)stateInfo).executePrivate();
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
         AV12AgeID = 1;
         /* Using cursor P001A2 */
         pr_default.execute(0, new Object[] {AV9EmpID, AV8tipoProdID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A31tipoProdID = P001A2_A31tipoProdID[0];
            A1EmpID = P001A2_A1EmpID[0];
            W31tipoProdID = A31tipoProdID;
            /* Using cursor P001A3 */
            pr_default.execute(1, new Object[] {A1EmpID, A31tipoProdID});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A148subCatDsc = P001A3_A148subCatDsc[0];
               n148subCatDsc = P001A3_n148subCatDsc[0];
               A32categID = P001A3_A32categID[0];
               A33subCatID = P001A3_A33subCatID[0];
               AV11prdNombre = A148subCatDsc;
               /* Execute user subroutine: 'INSERTARPRODUCTOS' */
               S111 ();
               if ( returnInSub )
               {
                  pr_default.close(1);
                  this.cleanup();
                  if (true) return;
               }
               pr_default.readNext(1);
            }
            pr_default.close(1);
            A31tipoProdID = W31tipoProdID;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'INSERTARPRODUCTOS' Routine */
         /* Execute user subroutine: 'NEXTPRODCID' */
         S121 ();
         if (returnInSub) return;
         /*
            INSERT RECORD ON TABLE Productos

         */
         A1EmpID = AV9EmpID;
         A2AgeID = AV12AgeID;
         A286PrdCod = AV10PrdCod;
         A309prdNombre = AV11prdNombre;
         n309prdNombre = false;
         A31tipoProdID = AV8tipoProdID;
         A306PrdDescCorta = AV11prdNombre;
         n306PrdDescCorta = false;
         A288PrdPres = 1;
         n288PrdPres = false;
         A289PrdEstado = "A";
         n289PrdEstado = false;
         /* Using cursor P001A4 */
         pr_default.execute(2, new Object[] {A1EmpID, A2AgeID, A286PrdCod, n288PrdPres, A288PrdPres, n289PrdEstado, A289PrdEstado, n306PrdDescCorta, A306PrdDescCorta, n309prdNombre, A309prdNombre, A31tipoProdID});
         pr_default.close(2);
         dsDefault.SmartCacheProvider.SetUpdated("Productos") ;
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
      }

      protected void S121( )
      {
         /* 'NEXTPRODCID' Routine */
         AV20GXLvl42 = 0;
         /* Using cursor P001A5 */
         pr_default.execute(3, new Object[] {AV9EmpID, AV12AgeID});
         while ( (pr_default.getStatus(3) != 101) )
         {
            A2AgeID = P001A5_A2AgeID[0];
            A1EmpID = P001A5_A1EmpID[0];
            A286PrdCod = P001A5_A286PrdCod[0];
            AV20GXLvl42 = 1;
            AV15PrdCod1 = A286PrdCod;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(3);
         }
         pr_default.close(3);
         if ( AV20GXLvl42 == 0 )
         {
            AV10PrdCod = 1;
         }
         AV10PrdCod = (short)(AV15PrdCod1+1);
      }

      public override void cleanup( )
      {
         context.CommitDataStores("procesarproductos",pr_default);
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
         P001A2_A31tipoProdID = new short[1] ;
         P001A2_A1EmpID = new short[1] ;
         P001A3_A1EmpID = new short[1] ;
         P001A3_A31tipoProdID = new short[1] ;
         P001A3_A148subCatDsc = new String[] {""} ;
         P001A3_n148subCatDsc = new bool[] {false} ;
         P001A3_A32categID = new short[1] ;
         P001A3_A33subCatID = new short[1] ;
         A148subCatDsc = "";
         AV11prdNombre = "";
         A309prdNombre = "";
         A306PrdDescCorta = "";
         A289PrdEstado = "";
         Gx_emsg = "";
         P001A5_A2AgeID = new short[1] ;
         P001A5_A1EmpID = new short[1] ;
         P001A5_A286PrdCod = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.procesarproductos__default(),
            new Object[][] {
                new Object[] {
               P001A2_A31tipoProdID, P001A2_A1EmpID
               }
               , new Object[] {
               P001A3_A1EmpID, P001A3_A31tipoProdID, P001A3_A148subCatDsc, P001A3_n148subCatDsc, P001A3_A32categID, P001A3_A33subCatID
               }
               , new Object[] {
               }
               , new Object[] {
               P001A5_A2AgeID, P001A5_A1EmpID, P001A5_A286PrdCod
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV9EmpID ;
      private short AV8tipoProdID ;
      private short AV12AgeID ;
      private short A31tipoProdID ;
      private short A1EmpID ;
      private short W31tipoProdID ;
      private short A32categID ;
      private short A33subCatID ;
      private short A2AgeID ;
      private short A286PrdCod ;
      private short AV10PrdCod ;
      private short A288PrdPres ;
      private short AV20GXLvl42 ;
      private short AV15PrdCod1 ;
      private int GX_INS72 ;
      private String scmdbuf ;
      private String A148subCatDsc ;
      private String A289PrdEstado ;
      private String Gx_emsg ;
      private bool n148subCatDsc ;
      private bool returnInSub ;
      private bool n309prdNombre ;
      private bool n306PrdDescCorta ;
      private bool n288PrdPres ;
      private bool n289PrdEstado ;
      private String AV11prdNombre ;
      private String A309prdNombre ;
      private String A306PrdDescCorta ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P001A2_A31tipoProdID ;
      private short[] P001A2_A1EmpID ;
      private short[] P001A3_A1EmpID ;
      private short[] P001A3_A31tipoProdID ;
      private String[] P001A3_A148subCatDsc ;
      private bool[] P001A3_n148subCatDsc ;
      private short[] P001A3_A32categID ;
      private short[] P001A3_A33subCatID ;
      private short[] P001A5_A2AgeID ;
      private short[] P001A5_A1EmpID ;
      private short[] P001A5_A286PrdCod ;
   }

   public class procesarproductos__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new UpdateCursor(def[2])
         ,new ForEachCursor(def[3])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001A2 ;
          prmP001A2 = new Object[] {
          new Object[] {"@AV9EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001A3 ;
          prmP001A3 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001A4 ;
          prmP001A4 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdPres",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@PrdEstado",SqlDbType.Char,1,0} ,
          new Object[] {"@PrdDescCorta",SqlDbType.VarChar,40,0} ,
          new Object[] {"@prdNombre",SqlDbType.VarChar,80,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001A5 ;
          prmP001A5 = new Object[] {
          new Object[] {"@AV9EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12AgeID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001A2", "SELECT [tipoProdID], [EmpID] FROM [TipoProducto] WITH (NOLOCK) WHERE [EmpID] = @AV9EmpID and [tipoProdID] = @AV8tipoProdID ORDER BY [EmpID], [tipoProdID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001A2,1,0,true,true )
             ,new CursorDef("P001A3", "SELECT T1.[EmpID], T2.[tipoProdID], T1.[subCatDsc], T1.[categID], T1.[subCatID] FROM ([CategoriassubCat] T1 WITH (NOLOCK) INNER JOIN [Categorias] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[categID] = T1.[categID]) WHERE (T1.[EmpID] = @EmpID) AND (T2.[tipoProdID] = @tipoProdID) ORDER BY T1.[EmpID], T1.[categID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001A3,100,0,true,false )
             ,new CursorDef("P001A4", "INSERT INTO [Productos]([EmpID], [AgeID], [PrdCod], [PrdPres], [PrdEstado], [PrdDescCorta], [prdNombre], [tipoProdID], [PrdTipPrd]) VALUES(@EmpID, @AgeID, @PrdCod, @PrdPres, @PrdEstado, @PrdDescCorta, @prdNombre, @tipoProdID, convert(int, 0))", GxErrorMask.GX_NOMASK,prmP001A4)
             ,new CursorDef("P001A5", "SELECT TOP 1 [AgeID], [EmpID], [PrdCod] FROM [Productos] WITH (NOLOCK) WHERE [EmpID] = @AV9EmpID and [AgeID] = @AV12AgeID ORDER BY [EmpID] DESC, [AgeID] DESC, [PrdCod] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001A5,1,0,false,true )
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
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 40) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
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
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 4 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(4, (short)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 5 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 6 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 7 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[10]);
                }
                stmt.SetParameter(8, (short)parms[11]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
       }
    }

 }

}
