/*
               File: PNewMenuHor
        Description: NuevoMenuHor
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/26/2022 20:13:10.34
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
   public class pnewmenuhor : GXProcedure
   {
      public pnewmenuhor( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public pnewmenuhor( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_empcod ,
                           short aP1_agecod ,
                           String aP2_UsuCod ,
                           out String aP3_menu )
      {
         this.AV8empcod = aP0_empcod;
         this.AV9agecod = aP1_agecod;
         this.AV10UsuCod = aP2_UsuCod;
         this.AV11menu = "" ;
         initialize();
         executePrivate();
         aP3_menu=this.AV11menu;
      }

      public String executeUdp( short aP0_empcod ,
                                short aP1_agecod ,
                                String aP2_UsuCod )
      {
         this.AV8empcod = aP0_empcod;
         this.AV9agecod = aP1_agecod;
         this.AV10UsuCod = aP2_UsuCod;
         this.AV11menu = "" ;
         initialize();
         executePrivate();
         aP3_menu=this.AV11menu;
         return AV11menu ;
      }

      public void executeSubmit( short aP0_empcod ,
                                 short aP1_agecod ,
                                 String aP2_UsuCod ,
                                 out String aP3_menu )
      {
         pnewmenuhor objpnewmenuhor;
         objpnewmenuhor = new pnewmenuhor();
         objpnewmenuhor.AV8empcod = aP0_empcod;
         objpnewmenuhor.AV9agecod = aP1_agecod;
         objpnewmenuhor.AV10UsuCod = aP2_UsuCod;
         objpnewmenuhor.AV11menu = "" ;
         objpnewmenuhor.context.SetSubmitInitialConfig(context);
         objpnewmenuhor.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objpnewmenuhor);
         aP3_menu=this.AV11menu;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pnewmenuhor)stateInfo).executePrivate();
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
         AV12parametro = StringUtil.Trim( StringUtil.Str( (decimal)(AV8empcod), 3, 0)) + "," + StringUtil.Trim( StringUtil.Str( (decimal)(AV9agecod), 3, 0)) + "," + StringUtil.Trim( AV10UsuCod);
         AV12parametro = StringUtil.Trim( AV12parametro);
         AV13target1 = "ppal";
         AV11menu = "<div class=\"menu\">" + StringUtil.NewLine( );
         AV11menu = AV11menu + "<ul>" + StringUtil.NewLine( );
         /* Using cursor P000K2 */
         pr_default.execute(0, new Object[] {AV10UsuCod, AV8empcod, AV9agecod});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK0K2 = false;
            A80SubDsc = P000K2_A80SubDsc[0];
            n80SubDsc = P000K2_n80SubDsc[0];
            A81SubLink = P000K2_A81SubLink[0];
            n81SubLink = P000K2_n81SubLink[0];
            A13SubCod = P000K2_A13SubCod[0];
            A11ModCod = P000K2_A11ModCod[0];
            A16agecod = P000K2_A16agecod[0];
            A15empcod = P000K2_A15empcod[0];
            A3UsuCod = P000K2_A3UsuCod[0];
            A77MenDsc = P000K2_A77MenDsc[0];
            n77MenDsc = P000K2_n77MenDsc[0];
            A12MenCod = P000K2_A12MenCod[0];
            A96PermEst = P000K2_A96PermEst[0];
            n96PermEst = P000K2_n96PermEst[0];
            A77MenDsc = P000K2_A77MenDsc[0];
            n77MenDsc = P000K2_n77MenDsc[0];
            A80SubDsc = P000K2_A80SubDsc[0];
            n80SubDsc = P000K2_n80SubDsc[0];
            A81SubLink = P000K2_A81SubLink[0];
            n81SubLink = P000K2_n81SubLink[0];
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P000K2_A3UsuCod[0], A3UsuCod) == 0 ) && ( P000K2_A15empcod[0] == A15empcod ) && ( P000K2_A16agecod[0] == A16agecod ) && ( P000K2_A11ModCod[0] == A11ModCod ) )
            {
               BRK0K2 = false;
               A80SubDsc = P000K2_A80SubDsc[0];
               n80SubDsc = P000K2_n80SubDsc[0];
               A81SubLink = P000K2_A81SubLink[0];
               n81SubLink = P000K2_n81SubLink[0];
               A13SubCod = P000K2_A13SubCod[0];
               A77MenDsc = P000K2_A77MenDsc[0];
               n77MenDsc = P000K2_n77MenDsc[0];
               A12MenCod = P000K2_A12MenCod[0];
               A77MenDsc = P000K2_A77MenDsc[0];
               n77MenDsc = P000K2_n77MenDsc[0];
               A80SubDsc = P000K2_A80SubDsc[0];
               n80SubDsc = P000K2_n80SubDsc[0];
               A81SubLink = P000K2_A81SubLink[0];
               n81SubLink = P000K2_n81SubLink[0];
               AV11menu = AV11menu + "<li><a href='#'></a>" + StringUtil.Trim( A77MenDsc) + StringUtil.NewLine( );
               AV11menu = AV11menu + "<ul>" + StringUtil.NewLine( );
               AV14MenCod = A12MenCod;
               /* Execute user subroutine: 'TOTSUBMENUS' */
               S111 ();
               if ( returnInSub )
               {
                  pr_default.close(0);
                  this.cleanup();
                  if (true) return;
               }
               AV15control = 0;
               if ( ( AV16tot > 10 ) && ( AV15control == 0 ) )
               {
                  AV15control = 1;
                  AV11menu = AV11menu + "<table>";
                  AV11menu = AV11menu + "<tr>";
                  AV17n2 = (decimal)(AV16tot/ (decimal)(10));
                  if ( ( ( AV17n2 - NumberUtil.Int( (long)(AV17n2)) ) > Convert.ToDecimal( 0 )) )
                  {
                     AV18n = (short)(NumberUtil.Int( (long)(AV17n2))+1);
                  }
                  else
                  {
                     AV18n = (short)(AV17n2);
                  }
                  AV19n1 = 0;
               }
               while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P000K2_A3UsuCod[0], A3UsuCod) == 0 ) && ( P000K2_A15empcod[0] == A15empcod ) && ( P000K2_A16agecod[0] == A16agecod ) && ( P000K2_A11ModCod[0] == A11ModCod ) )
               {
                  if ( ! ( ( P000K2_A12MenCod[0] == A12MenCod ) ) )
                  {
                     if (true) break;
                  }
                  BRK0K2 = false;
                  A80SubDsc = P000K2_A80SubDsc[0];
                  n80SubDsc = P000K2_n80SubDsc[0];
                  A81SubLink = P000K2_A81SubLink[0];
                  n81SubLink = P000K2_n81SubLink[0];
                  A13SubCod = P000K2_A13SubCod[0];
                  A80SubDsc = P000K2_A80SubDsc[0];
                  n80SubDsc = P000K2_n80SubDsc[0];
                  A81SubLink = P000K2_A81SubLink[0];
                  n81SubLink = P000K2_n81SubLink[0];
                  if ( ( AV16tot > 10 ) && ( AV18n == AV19n1 ) )
                  {
                     AV17n2 = (decimal)(AV16tot/ (decimal)(10));
                     if ( ( ( AV17n2 - NumberUtil.Int( (long)(AV17n2)) ) > Convert.ToDecimal( 0 )) )
                     {
                        AV18n = (short)(NumberUtil.Int( (long)(AV17n2))+1);
                     }
                     else
                     {
                        AV18n = (short)(AV17n2);
                     }
                     AV19n1 = 0;
                     AV11menu = AV11menu + "</tr>";
                     AV11menu = AV11menu + "<tr>";
                  }
                  if ( ( AV15control == 1 ) && ( AV18n >= AV19n1 ) )
                  {
                     AV11menu = AV11menu + "<td><li><a href='" + StringUtil.Trim( A81SubLink) + AV12parametro + " " + "' target='" + AV13target1 + "'>" + StringUtil.Trim( A80SubDsc) + "</a></td>" + StringUtil.NewLine( );
                  }
                  else
                  {
                     if ( StringUtil.StrCmp(A81SubLink, "") != 0 )
                     {
                        AV11menu = AV11menu + "<li><a href='" + StringUtil.Trim( A81SubLink) + AV12parametro + " " + "' target='" + AV13target1 + "'>" + StringUtil.Trim( A80SubDsc) + "</a>" + StringUtil.NewLine( );
                     }
                     else
                     {
                        AV11menu = AV11menu + "<li><a href='#'>" + "</a>" + StringUtil.Trim( A80SubDsc) + StringUtil.NewLine( );
                        AV11menu = AV11menu + "<ul>";
                        /* Using cursor P000K3 */
                        pr_default.execute(1, new Object[] {A11ModCod, A12MenCod, A13SubCod});
                        while ( (pr_default.getStatus(1) != 101) )
                        {
                           A83Sub1Dsc = P000K3_A83Sub1Dsc[0];
                           n83Sub1Dsc = P000K3_n83Sub1Dsc[0];
                           A84Sub1Link = P000K3_A84Sub1Link[0];
                           n84Sub1Link = P000K3_n84Sub1Link[0];
                           A14Sub1Cod = P000K3_A14Sub1Cod[0];
                           AV11menu = AV11menu + "<li><a href='" + StringUtil.Trim( A84Sub1Link) + AV12parametro + "'>" + StringUtil.Trim( A83Sub1Dsc) + "</a></li>" + StringUtil.NewLine( );
                           pr_default.readNext(1);
                        }
                        pr_default.close(1);
                        AV11menu = AV11menu + "</ul>";
                        AV11menu = AV11menu + "</li>";
                     }
                  }
                  AV19n1 = (short)(AV19n1+1);
                  BRK0K2 = true;
                  pr_default.readNext(0);
               }
               if ( AV16tot > 10 )
               {
                  AV11menu = AV11menu + "</tr>";
                  AV11menu = AV11menu + "</table>";
               }
               AV11menu = AV11menu + "</ul>" + StringUtil.NewLine( );
               AV11menu = AV11menu + "</li>" + StringUtil.NewLine( );
               if ( ! BRK0K2 )
               {
                  BRK0K2 = true;
                  pr_default.readNext(0);
               }
            }
            if ( ! BRK0K2 )
            {
               BRK0K2 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
         AV11menu = AV11menu + "</ul>" + StringUtil.NewLine( );
         AV11menu = AV11menu + "</div>" + StringUtil.NewLine( );
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'TOTSUBMENUS' Routine */
         AV16tot = 0;
         /* Optimized group. */
         /* Using cursor P000K4 */
         pr_default.execute(2, new Object[] {AV14MenCod, AV10UsuCod});
         cV16tot = P000K4_AV16tot[0];
         pr_default.close(2);
         AV16tot = (short)(AV16tot+cV16tot*1);
         /* End optimized group. */
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
         AV12parametro = "";
         AV13target1 = "";
         scmdbuf = "";
         P000K2_A80SubDsc = new String[] {""} ;
         P000K2_n80SubDsc = new bool[] {false} ;
         P000K2_A81SubLink = new String[] {""} ;
         P000K2_n81SubLink = new bool[] {false} ;
         P000K2_A13SubCod = new short[1] ;
         P000K2_A11ModCod = new short[1] ;
         P000K2_A16agecod = new short[1] ;
         P000K2_A15empcod = new short[1] ;
         P000K2_A3UsuCod = new String[] {""} ;
         P000K2_A77MenDsc = new String[] {""} ;
         P000K2_n77MenDsc = new bool[] {false} ;
         P000K2_A12MenCod = new short[1] ;
         P000K2_A96PermEst = new String[] {""} ;
         P000K2_n96PermEst = new bool[] {false} ;
         A80SubDsc = "";
         A81SubLink = "";
         A3UsuCod = "";
         A77MenDsc = "";
         A96PermEst = "";
         P000K3_A11ModCod = new short[1] ;
         P000K3_A12MenCod = new short[1] ;
         P000K3_A13SubCod = new short[1] ;
         P000K3_A83Sub1Dsc = new String[] {""} ;
         P000K3_n83Sub1Dsc = new bool[] {false} ;
         P000K3_A84Sub1Link = new String[] {""} ;
         P000K3_n84Sub1Link = new bool[] {false} ;
         P000K3_A14Sub1Cod = new short[1] ;
         A83Sub1Dsc = "";
         A84Sub1Link = "";
         P000K4_AV16tot = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pnewmenuhor__default(),
            new Object[][] {
                new Object[] {
               P000K2_A80SubDsc, P000K2_n80SubDsc, P000K2_A81SubLink, P000K2_n81SubLink, P000K2_A13SubCod, P000K2_A11ModCod, P000K2_A16agecod, P000K2_A15empcod, P000K2_A3UsuCod, P000K2_A77MenDsc,
               P000K2_n77MenDsc, P000K2_A12MenCod, P000K2_A96PermEst, P000K2_n96PermEst
               }
               , new Object[] {
               P000K3_A11ModCod, P000K3_A12MenCod, P000K3_A13SubCod, P000K3_A83Sub1Dsc, P000K3_n83Sub1Dsc, P000K3_A84Sub1Link, P000K3_n84Sub1Link, P000K3_A14Sub1Cod
               }
               , new Object[] {
               P000K4_AV16tot
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8empcod ;
      private short AV9agecod ;
      private short A13SubCod ;
      private short A11ModCod ;
      private short A16agecod ;
      private short A15empcod ;
      private short A12MenCod ;
      private short AV14MenCod ;
      private short AV15control ;
      private short AV16tot ;
      private short AV18n ;
      private short AV19n1 ;
      private short A14Sub1Cod ;
      private short cV16tot ;
      private decimal AV17n2 ;
      private String AV10UsuCod ;
      private String AV11menu ;
      private String AV12parametro ;
      private String AV13target1 ;
      private String scmdbuf ;
      private String A80SubDsc ;
      private String A81SubLink ;
      private String A3UsuCod ;
      private String A77MenDsc ;
      private String A96PermEst ;
      private String A83Sub1Dsc ;
      private String A84Sub1Link ;
      private bool BRK0K2 ;
      private bool n80SubDsc ;
      private bool n81SubLink ;
      private bool n77MenDsc ;
      private bool n96PermEst ;
      private bool returnInSub ;
      private bool n83Sub1Dsc ;
      private bool n84Sub1Link ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P000K2_A80SubDsc ;
      private bool[] P000K2_n80SubDsc ;
      private String[] P000K2_A81SubLink ;
      private bool[] P000K2_n81SubLink ;
      private short[] P000K2_A13SubCod ;
      private short[] P000K2_A11ModCod ;
      private short[] P000K2_A16agecod ;
      private short[] P000K2_A15empcod ;
      private String[] P000K2_A3UsuCod ;
      private String[] P000K2_A77MenDsc ;
      private bool[] P000K2_n77MenDsc ;
      private short[] P000K2_A12MenCod ;
      private String[] P000K2_A96PermEst ;
      private bool[] P000K2_n96PermEst ;
      private short[] P000K3_A11ModCod ;
      private short[] P000K3_A12MenCod ;
      private short[] P000K3_A13SubCod ;
      private String[] P000K3_A83Sub1Dsc ;
      private bool[] P000K3_n83Sub1Dsc ;
      private String[] P000K3_A84Sub1Link ;
      private bool[] P000K3_n84Sub1Link ;
      private short[] P000K3_A14Sub1Cod ;
      private short[] P000K4_AV16tot ;
      private String aP3_menu ;
   }

   public class pnewmenuhor__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000K2 ;
          prmP000K2 = new Object[] {
          new Object[] {"@AV10UsuCod",SqlDbType.Char,15,0} ,
          new Object[] {"@AV8empcod",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV9agecod",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP000K3 ;
          prmP000K3 = new Object[] {
          new Object[] {"@ModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SubCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP000K4 ;
          prmP000K4 = new Object[] {
          new Object[] {"@AV14MenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10UsuCod",SqlDbType.Char,15,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000K2", "SELECT T3.[SubDsc], T3.[SubLink], T1.[SubCod], T1.[ModCod], T1.[agecod], T1.[empcod], T1.[UsuCod], T2.[MenDsc], T1.[MenCod], T1.[PermEst] FROM (([PERMISOS] T1 WITH (NOLOCK) INNER JOIN [MENU] T2 WITH (NOLOCK) ON T2.[ModCod] = T1.[ModCod] AND T2.[MenCod] = T1.[MenCod]) INNER JOIN [MENUSUB] T3 WITH (NOLOCK) ON T3.[ModCod] = T1.[ModCod] AND T3.[MenCod] = T1.[MenCod] AND T3.[SubCod] = T1.[SubCod]) WHERE T1.[UsuCod] = @AV10UsuCod and T1.[empcod] = @AV8empcod and T1.[agecod] = @AV9agecod and T1.[ModCod] = 1 ORDER BY T1.[UsuCod], T1.[empcod], T1.[agecod], T1.[ModCod], T1.[MenCod], T1.[SubCod] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000K2,100,0,true,false )
             ,new CursorDef("P000K3", "SELECT [ModCod], [MenCod], [SubCod], [Sub1Dsc], [Sub1Link], [Sub1Cod] FROM [MENUSUB1] WITH (NOLOCK) WHERE [ModCod] = @ModCod and [MenCod] = @MenCod and [SubCod] = @SubCod ORDER BY [ModCod], [MenCod], [SubCod] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000K3,100,0,false,false )
             ,new CursorDef("P000K4", "SELECT COUNT(*) FROM [PERMISOS] WITH (NOLOCK) WHERE ([ModCod] = 1 and [MenCod] = @AV14MenCod) AND ([UsuCod] = @AV10UsuCod) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000K4,1,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 30) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((short[]) buf[4])[0] = rslt.getShort(3) ;
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((short[]) buf[6])[0] = rslt.getShort(5) ;
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                ((String[]) buf[8])[0] = rslt.getString(7, 15) ;
                ((String[]) buf[9])[0] = rslt.getString(8, 30) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(8);
                ((short[]) buf[11])[0] = rslt.getShort(9) ;
                ((String[]) buf[12])[0] = rslt.getString(10, 1) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 30) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getString(5, 30) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                return;
             case 2 :
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
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
       }
    }

 }

}
