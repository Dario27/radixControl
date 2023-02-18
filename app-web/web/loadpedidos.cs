/*
               File: loadPedidos
        Description: load Pedidos
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/26/2022 20:13:12.53
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
   public class loadpedidos : GXProcedure
   {
      public loadpedidos( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public loadpedidos( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_EmpID ,
                           int aP1_PedCod ,
                           DateTime aP2_FechReg ,
                           String aP3_PedEst ,
                           String aP4_PedDescripcion ,
                           int aP5_PedUltNro ,
                           GXBaseCollection<SdtSDTPedidos_SDTPedidosItem> aP6_SDTPedidos )
      {
         this.AV8EmpID = aP0_EmpID;
         this.AV12PedCod = aP1_PedCod;
         this.AV9FechReg = aP2_FechReg;
         this.AV13PedEst = aP3_PedEst;
         this.AV17PedDescripcion = aP4_PedDescripcion;
         this.AV16PedUltNro = aP5_PedUltNro;
         this.AV14SDTPedidos = aP6_SDTPedidos;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_EmpID ,
                                 int aP1_PedCod ,
                                 DateTime aP2_FechReg ,
                                 String aP3_PedEst ,
                                 String aP4_PedDescripcion ,
                                 int aP5_PedUltNro ,
                                 GXBaseCollection<SdtSDTPedidos_SDTPedidosItem> aP6_SDTPedidos )
      {
         loadpedidos objloadpedidos;
         objloadpedidos = new loadpedidos();
         objloadpedidos.AV8EmpID = aP0_EmpID;
         objloadpedidos.AV12PedCod = aP1_PedCod;
         objloadpedidos.AV9FechReg = aP2_FechReg;
         objloadpedidos.AV13PedEst = aP3_PedEst;
         objloadpedidos.AV17PedDescripcion = aP4_PedDescripcion;
         objloadpedidos.AV16PedUltNro = aP5_PedUltNro;
         objloadpedidos.AV14SDTPedidos = aP6_SDTPedidos;
         objloadpedidos.context.SetSubmitInitialConfig(context);
         objloadpedidos.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objloadpedidos);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((loadpedidos)stateInfo).executePrivate();
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
         /* Execute user subroutine: 'INSERTCABPED' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         GX_msglist.addItem(StringUtil.Str( (decimal)(AV14SDTPedidos.Count), 10, 0));
         AV20GXV1 = 1;
         while ( AV20GXV1 <= AV14SDTPedidos.Count )
         {
            AV15SDTPedidosItems = ((SdtSDTPedidos_SDTPedidosItem)AV14SDTPedidos.Item(AV20GXV1));
            /*
               INSERT RECORD ON TABLE OrdenPedidoOPId

            */
            A1EmpID = AV8EmpID;
            A39PedCod = AV12PedCod;
            A40OPIdSec = AV15SDTPedidosItems.gxTpr_Nro;
            A36detTipoProdID = AV15SDTPedidosItems.gxTpr_Tipprod;
            A32categID = AV15SDTPedidosItems.gxTpr_Catid;
            A33subCatID = AV15SDTPedidosItems.gxTpr_Subcatid;
            A212cantDetPed = AV15SDTPedidosItems.gxTpr_Cant;
            n212cantDetPed = false;
            /* Using cursor P000Y2 */
            pr_default.execute(0, new Object[] {A1EmpID, A39PedCod, A40OPIdSec, A36detTipoProdID, A32categID, A33subCatID, n212cantDetPed, A212cantDetPed});
            pr_default.close(0);
            dsDefault.SmartCacheProvider.SetUpdated("OrdenPedidoOPId") ;
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
            context.CommitDataStores("loadpedidos",pr_default);
            AV20GXV1 = (int)(AV20GXV1+1);
         }
         GX_msglist.addItem("ingresamos al prc de insersion");
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'INSERTCABPED' Routine */
         /*
            INSERT RECORD ON TABLE OrdenPedido

         */
         A1EmpID = AV8EmpID;
         A39PedCod = AV12PedCod;
         A205PedFchReg = AV9FechReg;
         n205PedFchReg = false;
         A206PedEst = AV13PedEst;
         n206PedEst = false;
         A207PedUltNro = AV16PedUltNro;
         n207PedUltNro = false;
         A204PedDescripcion = AV17PedDescripcion;
         n204PedDescripcion = false;
         /* Using cursor P000Y3 */
         pr_default.execute(1, new Object[] {A1EmpID, A39PedCod, n204PedDescripcion, A204PedDescripcion, n205PedFchReg, A205PedFchReg, n206PedEst, A206PedEst, n207PedUltNro, A207PedUltNro});
         pr_default.close(1);
         dsDefault.SmartCacheProvider.SetUpdated("OrdenPedido") ;
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
         context.CommitDataStores("loadpedidos",pr_default);
      }

      public override void cleanup( )
      {
         context.CommitDataStores("loadpedidos",pr_default);
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
         AV15SDTPedidosItems = new SdtSDTPedidos_SDTPedidosItem(context);
         Gx_emsg = "";
         A205PedFchReg = DateTime.MinValue;
         A206PedEst = "";
         A204PedDescripcion = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.loadpedidos__default(),
            new Object[][] {
                new Object[] {
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8EmpID ;
      private short A1EmpID ;
      private short A36detTipoProdID ;
      private short A32categID ;
      private short A33subCatID ;
      private int AV12PedCod ;
      private int AV16PedUltNro ;
      private int AV20GXV1 ;
      private int GX_INS33 ;
      private int A39PedCod ;
      private int A40OPIdSec ;
      private int GX_INS32 ;
      private int A207PedUltNro ;
      private decimal A212cantDetPed ;
      private String AV13PedEst ;
      private String AV17PedDescripcion ;
      private String Gx_emsg ;
      private String A206PedEst ;
      private String A204PedDescripcion ;
      private DateTime AV9FechReg ;
      private DateTime A205PedFchReg ;
      private bool returnInSub ;
      private bool n212cantDetPed ;
      private bool n205PedFchReg ;
      private bool n206PedEst ;
      private bool n207PedUltNro ;
      private bool n204PedDescripcion ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private GXBaseCollection<SdtSDTPedidos_SDTPedidosItem> AV14SDTPedidos ;
      private SdtSDTPedidos_SDTPedidosItem AV15SDTPedidosItems ;
   }

   public class loadpedidos__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000Y2 ;
          prmP000Y2 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PedCod",SqlDbType.Int,8,0} ,
          new Object[] {"@OPIdSec",SqlDbType.Int,8,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@cantDetPed",SqlDbType.Decimal,8,2}
          } ;
          Object[] prmP000Y3 ;
          prmP000Y3 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PedCod",SqlDbType.Int,8,0} ,
          new Object[] {"@PedDescripcion",SqlDbType.Char,50,0} ,
          new Object[] {"@PedFchReg",SqlDbType.DateTime,8,0} ,
          new Object[] {"@PedEst",SqlDbType.Char,1,0} ,
          new Object[] {"@PedUltNro",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000Y2", "INSERT INTO [OrdenPedidoOPId]([EmpID], [PedCod], [OPIdSec], [detTipoProdID], [categID], [subCatID], [cantDetPed], [cantDetaPed]) VALUES(@EmpID, @PedCod, @OPIdSec, @detTipoProdID, @categID, @subCatID, @cantDetPed, convert(int, 0))", GxErrorMask.GX_NOMASK,prmP000Y2)
             ,new CursorDef("P000Y3", "INSERT INTO [OrdenPedido]([EmpID], [PedCod], [PedDescripcion], [PedFchReg], [PedEst], [PedUltNro]) VALUES(@EmpID, @PedCod, @PedDescripcion, @PedFchReg, @PedEst, @PedUltNro)", GxErrorMask.GX_NOMASK,prmP000Y3)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
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
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
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
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 3 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 4 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(4, (DateTime)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 5 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 6 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(6, (int)parms[9]);
                }
                return;
       }
    }

 }

}
