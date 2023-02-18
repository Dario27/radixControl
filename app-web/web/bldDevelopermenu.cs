using System;
using GeneXus.Builder;
using System.IO;
public class bldDevelopermenu : GxBaseBuilder
{
   string cs_path = "." ;
   public bldDevelopermenu( ) : base()
   {
   }

   public override int BeforeCompile( )
   {
      return 0 ;
   }

   public override int AfterCompile( )
   {
      int ErrCode ;
      ErrCode = 0;
      if ( ! File.Exists(@"bin\client.exe.config") || checkTime(@"bin\client.exe.config",cs_path + @"\client.exe.config") )
      {
         File.Copy( cs_path + @"\client.exe.config", @"bin\client.exe.config", true);
      }
      return ErrCode ;
   }

   static public int Main( string[] args )
   {
      bldDevelopermenu x = new bldDevelopermenu() ;
      x.SetMainSourceFile( "bldDevelopermenu.cs");
      x.LoadVariables( args);
      return x.CompileAll( );
   }

   public override ItemCollection GetSortedBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\GeneXus.Programs.Common.dll", cs_path + @"\genexus.programs.common.rsp");
      return sc ;
   }

   public override TargetCollection GetRuntimeBuildList( )
   {
      TargetCollection sc = new TargetCollection() ;
      sc.Add( @"apdfexportopdet", "dll");
      sc.Add( @"apdfexportopdet", "dll");
      sc.Add( @"apdfstockbodega", "dll");
      sc.Add( @"apdfstockbodega", "dll");
      sc.Add( @"apdfstockbodegaresumen", "dll");
      sc.Add( @"apdfstockbodegaresumen", "dll");
      sc.Add( @"apdfprevopitems", "dll");
      sc.Add( @"apdfprevopitems", "dll");
      sc.Add( @"appmasterpage", "dll");
      sc.Add( @"recentlinks", "dll");
      sc.Add( @"promptmasterpage", "dll");
      sc.Add( @"rwdmasterpage", "dll");
      sc.Add( @"rwdrecentlinks", "dll");
      sc.Add( @"rwdpromptmasterpage", "dll");
      sc.Add( @"home", "dll");
      sc.Add( @"home", "dll");
      sc.Add( @"notauthorized", "dll");
      sc.Add( @"tabbedview", "dll");
      sc.Add( @"auth", "dll");
      sc.Add( @"auth", "dll");
      sc.Add( @"wwempresas", "dll");
      sc.Add( @"empresasgeneral", "dll");
      sc.Add( @"empresasagenciaswc", "dll");
      sc.Add( @"empresasclienteswc", "dll");
      sc.Add( @"empresasmarcawc", "dll");
      sc.Add( @"empresasvendedorwc", "dll");
      sc.Add( @"empresasprototipowc", "dll");
      sc.Add( @"empresastipoordenprowc", "dll");
      sc.Add( @"empresasdetopfchswc", "dll");
      sc.Add( @"empresasordenprocesoswc", "dll");
      sc.Add( @"empresasarchivosopwc", "dll");
      sc.Add( @"empresastipoproductowc", "dll");
      sc.Add( @"empresassubcatwc", "dll");
      sc.Add( @"empresasordenpedidowc", "dll");
      sc.Add( @"empresasobreroswc", "dll");
      sc.Add( @"empresasbodegaswc", "dll");
      sc.Add( @"viewempresas", "dll");
      sc.Add( @"wwusuarios", "dll");
      sc.Add( @"wwagencias", "dll");
      sc.Add( @"agenciasgeneral", "dll");
      sc.Add( @"viewagencias", "dll");
      sc.Add( @"wwprototipo", "dll");
      sc.Add( @"prototipogeneral", "dll");
      sc.Add( @"prototipoordenproduccionwc", "dll");
      sc.Add( @"prototipocotizadorwc", "dll");
      sc.Add( @"viewprototipo", "dll");
      sc.Add( @"wwmarca", "dll");
      sc.Add( @"marcageneral", "dll");
      sc.Add( @"marcamodelowc", "dll");
      sc.Add( @"marcaordenproduccionwc", "dll");
      sc.Add( @"viewmarca", "dll");
      sc.Add( @"wwvehiculos", "dll");
      sc.Add( @"wwvendedor", "dll");
      sc.Add( @"vendedorgeneral", "dll");
      sc.Add( @"vendedorordenproduccionwc", "dll");
      sc.Add( @"viewvendedor", "dll");
      sc.Add( @"wwtipocliente", "dll");
      sc.Add( @"tipoclientegeneral", "dll");
      sc.Add( @"tipoclienteclienteswc", "dll");
      sc.Add( @"viewtipocliente", "dll");
      sc.Add( @"wwclientes", "dll");
      sc.Add( @"clientesgeneral", "dll");
      sc.Add( @"clientesordenproduccionwc", "dll");
      sc.Add( @"viewclientes", "dll");
      sc.Add( @"wwtipoordenpro", "dll");
      sc.Add( @"wwordenproduccion", "dll");
      sc.Add( @"wwdetopfchs", "dll");
      sc.Add( @"wwprocesos", "dll");
      sc.Add( @"wwarchivosop", "dll");
      sc.Add( @"wwemails", "dll");
      sc.Add( @"wwtipoproducto", "dll");
      sc.Add( @"wwcategorias", "dll");
      sc.Add( @"wwcotizador", "dll");
      sc.Add( @"cotizadorgeneral", "dll");
      sc.Add( @"cotizadordetwc", "dll");
      sc.Add( @"cotizadorobreroswc", "dll");
      sc.Add( @"viewcotizador", "dll");
      sc.Add( @"wwproveedor", "dll");
      sc.Add( @"wwordenpedido", "dll");
      sc.Add( @"ordenpedidogeneral", "dll");
      sc.Add( @"viewordenpedido", "dll");
      sc.Add( @"wwbodegas", "dll");
      sc.Add( @"wwtipomovimiento", "dll");
      sc.Add( @"hmain", "dll");
      sc.Add( @"wcheader1", "dll");
      sc.Add( @"wcmenuhor", "dll");
      sc.Add( @"ppal", "dll");
      sc.Add( @"gx0051", "dll");
      sc.Add( @"enviarorden", "dll");
      sc.Add( @"procesosordenprod", "dll");
      sc.Add( @"mantordenproduccion", "dll");
      sc.Add( @"rptordenproduccion", "dll");
      sc.Add( @"mantarchivosop", "dll");
      sc.Add( @"rptordenproduccioncostos", "dll");
      sc.Add( @"wcocent", "dll");
      sc.Add( @"mantordenprod", "dll");
      sc.Add( @"rptcotizaciones", "dll");
      sc.Add( @"gx0010", "dll");
      sc.Add( @"gx0020", "dll");
      sc.Add( @"gx0040", "dll");
      sc.Add( @"gx0050", "dll");
      sc.Add( @"gx0060", "dll");
      sc.Add( @"gx0072", "dll");
      sc.Add( @"gx0090", "dll");
      sc.Add( @"gx00a0", "dll");
      sc.Add( @"gx00f0", "dll");
      sc.Add( @"gx00f1", "dll");
      sc.Add( @"gx00i0", "dll");
      sc.Add( @"gx00j0", "dll");
      sc.Add( @"gx00k0", "dll");
      sc.Add( @"gx00l3", "dll");
      sc.Add( @"gx00p0", "dll");
      sc.Add( @"gx00p1", "dll");
      sc.Add( @"gx00q0", "dll");
      sc.Add( @"gx00r2", "dll");
      sc.Add( @"gx00q1", "dll");
      sc.Add( @"gx00w0", "dll");
      sc.Add( @"gx00x2", "dll");
      sc.Add( @"gx00a1", "dll");
      sc.Add( @"gx00s0", "dll");
      sc.Add( @"gx00t2", "dll");
      sc.Add( @"gx00u2", "dll");
      sc.Add( @"gx00y0", "dll");
      sc.Add( @"gx0100", "dll");
      sc.Add( @"gx0061", "dll");
      sc.Add( @"gx0080", "dll");
      sc.Add( @"gx0030", "dll");
      sc.Add( @"gx00n0", "dll");
      sc.Add( @"gx00o2", "dll");
      sc.Add( @"gx00b0", "dll");
      sc.Add( @"gx00c2", "dll");
      sc.Add( @"gx00d3", "dll");
      sc.Add( @"gx00c0", "dll");
      sc.Add( @"gx0081", "dll");
      sc.Add( @"gx0091", "dll");
      sc.Add( @"gx00g0", "dll");
      sc.Add( @"gx00h5", "dll");
      sc.Add( @"wwhistprecioprod", "dll");
      sc.Add( @"gx0130", "dll");
      sc.Add( @"gx0146", "dll");
      sc.Add( @"wwobreros", "dll");
      sc.Add( @"gx0181", "dll");
      sc.Add( @"wwsaldosproductos", "dll");
      sc.Add( @"gx01b3", "dll");
      sc.Add( @"agenciasinventariowc", "dll");
      sc.Add( @"gx0021", "dll");
      sc.Add( @"gx00v0", "dll");
      sc.Add( @"gx00y1", "dll");
      sc.Add( @"gx01c0", "dll");
      sc.Add( @"gx01e4", "dll");
      sc.Add( @"gx01g5", "dll");
      sc.Add( @"wwinventario", "dll");
      sc.Add( @"gx01h2", "dll");
      sc.Add( @"hmainsistema", "dll");
      sc.Add( @"wcmenuhor1", "dll");
      sc.Add( @"wwproductos", "dll");
      sc.Add( @"wwprodxbodega", "dll");
      sc.Add( @"wwprodprecio", "dll");
      sc.Add( @"gx0200", "dll");
      sc.Add( @"gx0202", "dll");
      sc.Add( @"gx0210", "dll");
      sc.Add( @"wwoctipos", "dll");
      sc.Add( @"wwclaseoc", "dll");
      sc.Add( @"wwperiodos", "dll");
      sc.Add( @"gx0220", "dll");
      sc.Add( @"gx0222", "dll");
      sc.Add( @"gx0230", "dll");
      sc.Add( @"gx0240", "dll");
      sc.Add( @"gx0242", "dll");
      sc.Add( @"gx0250", "dll");
      sc.Add( @"gx0262", "dll");
      sc.Add( @"gx0273", "dll");
      sc.Add( @"wwordencompra", "dll");
      sc.Add( @"gx01f4", "dll");
      sc.Add( @"wcsweetalert", "dll");
      sc.Add( @"gx0284", "dll");
      sc.Add( @"wpprocesos", "dll");
      sc.Add( @"wwprodstockbodega", "dll");
      sc.Add( @"gx02c0", "dll");
      sc.Add( @"gx02d6", "dll");
      sc.Add( @"wcdespachoop", "dll");
      sc.Add( @"wwingresobodegas", "dll");
      sc.Add( @"gx02f0", "dll");
      sc.Add( @"gx02g3", "dll");
      sc.Add( @"clientestipoinvwc", "dll");
      sc.Add( @"gx02h6", "dll");
      sc.Add( @"rptstockbodega", "dll");
      sc.Add( @"hadddespbodegaop", "dll");
      sc.Add( @"wwdespbodega", "dll");
      sc.Add( @"clientesdespbodegawc", "dll");
      sc.Add( @"gx02l0", "dll");
      sc.Add( @"gx02m5", "dll");
      sc.Add( @"empresas", "dll");
      sc.Add( @"agencias", "dll");
      sc.Add( @"clientes", "dll");
      sc.Add( @"marca", "dll");
      sc.Add( @"vendedor", "dll");
      sc.Add( @"prototipo", "dll");
      sc.Add( @"tipoordenpro", "dll");
      sc.Add( @"detopfchs", "dll");
      sc.Add( @"ordenprocesos", "dll");
      sc.Add( @"archivosop", "dll");
      sc.Add( @"tipoproducto", "dll");
      sc.Add( @"categorias", "dll");
      sc.Add( @"ordenpedido", "dll");
      sc.Add( @"cotizador", "dll");
      sc.Add( @"bodegas", "dll");
      sc.Add( @"usuarios", "dll");
      sc.Add( @"ordenproduccion", "dll");
      sc.Add( @"vehiculos", "dll");
      sc.Add( @"tipocliente", "dll");
      sc.Add( @"procesos", "dll");
      sc.Add( @"emails", "dll");
      sc.Add( @"proveedor", "dll");
      sc.Add( @"tipomovimiento", "dll");
      sc.Add( @"menu", "dll");
      sc.Add( @"permisos", "dll");
      sc.Add( @"histprecioprod", "dll");
      sc.Add( @"obreros", "dll");
      sc.Add( @"inventario", "dll");
      sc.Add( @"productos", "dll");
      sc.Add( @"prodprecio", "dll");
      sc.Add( @"octipos", "dll");
      sc.Add( @"ordencompra", "dll");
      sc.Add( @"claseoc", "dll");
      sc.Add( @"periodos", "dll");
      sc.Add( @"periodosdet", "dll");
      sc.Add( @"prodstockbodega", "dll");
      sc.Add( @"despbodega", "dll");
      sc.Add( @"ingresobodegas", "dll");
      return sc ;
   }

   public override ItemCollection GetResBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\messages.spa.dll", cs_path + @"\messages.spa.txt");
      return sc ;
   }

   public override bool ToBuild( String obj )
   {
      if (checkTime(obj, cs_path + @"\bin\GxClasses.dll" ))
         return true;
      if ( obj == @"bin\GeneXus.Programs.Common.dll" )
      {
         if (checkTime(obj, cs_path + @"\GxObjectCollection.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\SoapParm.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxWebStd.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxFullTextSearchReindexer.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxModelInfoProvider.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\genexus.programs.sdt.rsp" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINPage.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINsw_type.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINsw_position.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINsw_grow.cs" ))
            return true;
      }
      if ( obj == @"bin\messages.spa.dll" )
      {
         if (checkTime(obj, cs_path + @"\messages.spa.txt" ))
            return true;
      }
      return false ;
   }

}

