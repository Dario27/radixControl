/*
               File: BodegasBodTipoConversion
        Description: Conversion for table BodegasBodTipo
             Author: GeneXus C# Generator version 15_0_11-124690
       Generated on: 8/30/2022 22:36:2.78
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
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
using System.Web.Services;
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
using System.Xml.Serialization;
namespace GeneXus.Programs {
   public class bodegasbodtipoconversion : GXProcedure
   {
      public bodegasbodtipoconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public bodegasbodtipoconversion( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         bodegasbodtipoconversion objbodegasbodtipoconversion;
         objbodegasbodtipoconversion = new bodegasbodtipoconversion();
         objbodegasbodtipoconversion.context.SetSubmitInitialConfig(context);
         objbodegasbodtipoconversion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objbodegasbodtipoconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((bodegasbodtipoconversion)stateInfo).executePrivate();
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
         /* Using cursor BODEGASBOD2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A226BodTipoNro = BODEGASBOD2_A226BodTipoNro[0];
            n226BodTipoNro = BODEGASBOD2_n226BodTipoNro[0];
            A43TipoInv = BODEGASBOD2_A43TipoInv[0];
            A42BodCod = BODEGASBOD2_A42BodCod[0];
            A1EmpID = BODEGASBOD2_A1EmpID[0];
            /*
               INSERT RECORD ON TABLE GXA0053

            */
            AV2EmpID = A1EmpID;
            AV3BodCod = A42BodCod;
            AV4BodDetID = 0;
            AV5TipoInv = A43TipoInv;
            if ( BODEGASBOD2_n226BodTipoNro[0] )
            {
               AV6BodTipoNro = 0;
               nV6BodTipoNro = false;
               nV6BodTipoNro = true;
            }
            else
            {
               AV6BodTipoNro = A226BodTipoNro;
               nV6BodTipoNro = false;
            }
            /* Using cursor BODEGASBOD3 */
            pr_default.execute(1, new Object[] {AV2EmpID, AV3BodCod, AV4BodDetID, AV5TipoInv, nV6BodTipoNro, AV6BodTipoNro});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("GXA0053") ;
            if ( (pr_default.getStatus(1) == 1) )
            {
               context.Gx_err = 1;
               Gx_emsg = (String)(GXResourceManager.GetMessage("GXM_noupdate"));
            }
            else
            {
               context.Gx_err = 0;
               Gx_emsg = "";
            }
            /* End Insert */
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
         BODEGASBOD2_A226BodTipoNro = new int[1] ;
         BODEGASBOD2_n226BodTipoNro = new bool[] {false} ;
         BODEGASBOD2_A43TipoInv = new String[] {""} ;
         BODEGASBOD2_A42BodCod = new short[1] ;
         BODEGASBOD2_A1EmpID = new short[1] ;
         A43TipoInv = "";
         AV5TipoInv = "";
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.bodegasbodtipoconversion__default(),
            new Object[][] {
                new Object[] {
               BODEGASBOD2_A226BodTipoNro, BODEGASBOD2_n226BodTipoNro, BODEGASBOD2_A43TipoInv, BODEGASBOD2_A42BodCod, BODEGASBOD2_A1EmpID
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A42BodCod ;
      private short A1EmpID ;
      private short AV2EmpID ;
      private short AV3BodCod ;
      private short AV4BodDetID ;
      private int A226BodTipoNro ;
      private int GIGXA0053 ;
      private int AV6BodTipoNro ;
      private String scmdbuf ;
      private String A43TipoInv ;
      private String AV5TipoInv ;
      private String Gx_emsg ;
      private bool n226BodTipoNro ;
      private bool nV6BodTipoNro ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] BODEGASBOD2_A226BodTipoNro ;
      private bool[] BODEGASBOD2_n226BodTipoNro ;
      private String[] BODEGASBOD2_A43TipoInv ;
      private short[] BODEGASBOD2_A42BodCod ;
      private short[] BODEGASBOD2_A1EmpID ;
   }

   public class bodegasbodtipoconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmBODEGASBOD2 ;
          prmBODEGASBOD2 = new Object[] {
          } ;
          Object[] prmBODEGASBOD3 ;
          prmBODEGASBOD3 = new Object[] {
          new Object[] {"@AV2EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV3BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV4BodDetID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV5TipoInv",SqlDbType.Char,4,0} ,
          new Object[] {"@AV6BodTipoNro",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BODEGASBOD2", "SELECT [BodTipoNro], [TipoInv], [BodCod], [EmpID] FROM [BodegasBodTipo] ORDER BY [EmpID], [BodCod], [TipoInv] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmBODEGASBOD2,100,0,true,false )
             ,new CursorDef("BODEGASBOD3", "INSERT INTO [GXA0053]([EmpID], [BodCod], [BodDetID], [TipoInv], [BodTipoNro]) VALUES(@AV2EmpID, @AV3BodCod, @AV4BodDetID, @AV5TipoInv, @AV6BodTipoNro)", GxErrorMask.GX_NOMASK,prmBODEGASBOD3)
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 4) ;
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 5 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(5, (int)parms[5]);
                }
                return;
       }
    }

 }

}
