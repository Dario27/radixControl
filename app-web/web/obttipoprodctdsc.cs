/*
               File: obtTipoProdctDSC
        Description: obt Tipo Prodct DSC
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/26/2022 20:13:11.89
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
   public class obttipoprodctdsc : GXProcedure
   {
      public obttipoprodctdsc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public obttipoprodctdsc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_tipoProductID ,
                           out String aP1_tipoProdDsc )
      {
         this.AV8tipoProductID = aP0_tipoProductID;
         this.AV9tipoProdDsc = "" ;
         initialize();
         executePrivate();
         aP1_tipoProdDsc=this.AV9tipoProdDsc;
      }

      public String executeUdp( short aP0_tipoProductID )
      {
         this.AV8tipoProductID = aP0_tipoProductID;
         this.AV9tipoProdDsc = "" ;
         initialize();
         executePrivate();
         aP1_tipoProdDsc=this.AV9tipoProdDsc;
         return AV9tipoProdDsc ;
      }

      public void executeSubmit( short aP0_tipoProductID ,
                                 out String aP1_tipoProdDsc )
      {
         obttipoprodctdsc objobttipoprodctdsc;
         objobttipoprodctdsc = new obttipoprodctdsc();
         objobttipoprodctdsc.AV8tipoProductID = aP0_tipoProductID;
         objobttipoprodctdsc.AV9tipoProdDsc = "" ;
         objobttipoprodctdsc.context.SetSubmitInitialConfig(context);
         objobttipoprodctdsc.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objobttipoprodctdsc);
         aP1_tipoProdDsc=this.AV9tipoProdDsc;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((obttipoprodctdsc)stateInfo).executePrivate();
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
         /* Using cursor P000V2 */
         pr_default.execute(0, new Object[] {AV8tipoProductID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A31tipoProdID = P000V2_A31tipoProdID[0];
            A144tipoProdDsc = P000V2_A144tipoProdDsc[0];
            n144tipoProdDsc = P000V2_n144tipoProdDsc[0];
            A1EmpID = P000V2_A1EmpID[0];
            AV9tipoProdDsc = A144tipoProdDsc;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(0);
         }
         pr_default.close(0);
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
         P000V2_A31tipoProdID = new short[1] ;
         P000V2_A144tipoProdDsc = new String[] {""} ;
         P000V2_n144tipoProdDsc = new bool[] {false} ;
         P000V2_A1EmpID = new short[1] ;
         A144tipoProdDsc = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.obttipoprodctdsc__default(),
            new Object[][] {
                new Object[] {
               P000V2_A31tipoProdID, P000V2_A144tipoProdDsc, P000V2_n144tipoProdDsc, P000V2_A1EmpID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8tipoProductID ;
      private short A31tipoProdID ;
      private short A1EmpID ;
      private String AV9tipoProdDsc ;
      private String scmdbuf ;
      private String A144tipoProdDsc ;
      private bool n144tipoProdDsc ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P000V2_A31tipoProdID ;
      private String[] P000V2_A144tipoProdDsc ;
      private bool[] P000V2_n144tipoProdDsc ;
      private short[] P000V2_A1EmpID ;
      private String aP1_tipoProdDsc ;
   }

   public class obttipoprodctdsc__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000V2 ;
          prmP000V2 = new Object[] {
          new Object[] {"@AV8tipoProductID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000V2", "SELECT TOP 1 [tipoProdID], [tipoProdDsc], [EmpID] FROM [TipoProducto] WITH (NOLOCK) WHERE [tipoProdID] = @AV8tipoProductID ORDER BY [EmpID], [tipoProdID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000V2,1,0,false,true )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 40) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
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
                return;
       }
    }

 }

}
