/*
               File: validCedulaObreros
        Description: valid Cedula Obreros
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/26/2022 20:13:13.13
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
   public class validcedulaobreros : GXProcedure
   {
      public validcedulaobreros( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public validcedulaobreros( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_ObreCedula ,
                           out String aP1_existe )
      {
         this.AV8ObreCedula = aP0_ObreCedula;
         this.AV9existe = "" ;
         initialize();
         executePrivate();
         aP1_existe=this.AV9existe;
      }

      public String executeUdp( String aP0_ObreCedula )
      {
         this.AV8ObreCedula = aP0_ObreCedula;
         this.AV9existe = "" ;
         initialize();
         executePrivate();
         aP1_existe=this.AV9existe;
         return AV9existe ;
      }

      public void executeSubmit( String aP0_ObreCedula ,
                                 out String aP1_existe )
      {
         validcedulaobreros objvalidcedulaobreros;
         objvalidcedulaobreros = new validcedulaobreros();
         objvalidcedulaobreros.AV8ObreCedula = aP0_ObreCedula;
         objvalidcedulaobreros.AV9existe = "" ;
         objvalidcedulaobreros.context.SetSubmitInitialConfig(context);
         objvalidcedulaobreros.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objvalidcedulaobreros);
         aP1_existe=this.AV9existe;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((validcedulaobreros)stateInfo).executePrivate();
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
         AV12GXLvl1 = 0;
         /* Using cursor P00142 */
         pr_default.execute(0, new Object[] {AV8ObreCedula});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A239ObreCedula = P00142_A239ObreCedula[0];
            A238ObreID = P00142_A238ObreID[0];
            AV12GXLvl1 = 1;
            AV9existe = "SI";
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( AV12GXLvl1 == 0 )
         {
            AV9existe = "NO";
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
         P00142_A239ObreCedula = new String[] {""} ;
         P00142_A238ObreID = new short[1] ;
         A239ObreCedula = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.validcedulaobreros__default(),
            new Object[][] {
                new Object[] {
               P00142_A239ObreCedula, P00142_A238ObreID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV12GXLvl1 ;
      private short A238ObreID ;
      private String AV8ObreCedula ;
      private String AV9existe ;
      private String scmdbuf ;
      private String A239ObreCedula ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P00142_A239ObreCedula ;
      private short[] P00142_A238ObreID ;
      private String aP1_existe ;
   }

   public class validcedulaobreros__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00142 ;
          prmP00142 = new Object[] {
          new Object[] {"@AV8ObreCedula",SqlDbType.Char,13,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00142", "SELECT [ObreCedula], [ObreID] FROM [Obreros] WITH (NOLOCK) WHERE [ObreCedula] = @AV8ObreCedula ORDER BY [ObreID], [ObreCedula] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00142,100,0,false,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 13) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                return;
       }
    }

 }

}
