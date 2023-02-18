/*
				   File: type_SdtActionGroupItem
			Description: ActionGroupItem
				 Author: Nemo for C# version 15.0.12.126726
		   Generated on: 26/10/2022 20:18:56
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
using System.Web.Services.Protocols;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using GeneXus.Http.Server;
using System.Reflection;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;

namespace GeneXus.Programs{
	[XmlSerializerFormat]
	[XmlRoot(ElementName="ActionGroupItem")]
	[XmlType(TypeName="ActionGroupItem" , Namespace="KBCalpesa22" )]
	[Serializable]
	public class SdtActionGroupItem : GxUserType
	{
		public SdtActionGroupItem( )
		{
			/* Constructor for serialization */
			gxTv_SdtActionGroupItem_Caption = "";

			gxTv_SdtActionGroupItem_Link = "";

			gxTv_SdtActionGroupItem_Class = "";

			gxTv_SdtActionGroupItem_Tooltiptext = "";

		}

		public SdtActionGroupItem(IGxContext context)
		{
			this.context = context;
			initialize();
		}

		#region Json
		private static Hashtable mapper;
		public override String JsonMap(String value)
		{
			if (mapper == null)
			{
				mapper = new Hashtable();
			}
			return (String)mapper[value]; ;
		}

		public override void ToJSON()
		{
			ToJSON(true) ;
			return;
		}

		public override void ToJSON(bool includeState)
		{
			AddObjectProperty("Caption", gxTpr_Caption, false);
			AddObjectProperty("Link", gxTpr_Link, false);
			AddObjectProperty("Class", gxTpr_Class, false);
			AddObjectProperty("TooltipText", gxTpr_Tooltiptext, false);
			AddObjectProperty("Children", gxTv_SdtActionGroupItem_Children, false);  
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="Caption")]
		[XmlElement(ElementName="Caption")]
		public String gxTpr_Caption
		{
			get { 
				return gxTv_SdtActionGroupItem_Caption; 
			}
			set { 
				gxTv_SdtActionGroupItem_Caption = value;
				SetDirty("Caption");
			}
		}


		[SoapElement(ElementName="Link")]
		[XmlElement(ElementName="Link")]
		public String gxTpr_Link
		{
			get { 
				return gxTv_SdtActionGroupItem_Link; 
			}
			set { 
				gxTv_SdtActionGroupItem_Link = value;
				SetDirty("Link");
			}
		}


		[SoapElement(ElementName="Class")]
		[XmlElement(ElementName="Class")]
		public String gxTpr_Class
		{
			get { 
				return gxTv_SdtActionGroupItem_Class; 
			}
			set { 
				gxTv_SdtActionGroupItem_Class = value;
				SetDirty("Class");
			}
		}


		[SoapElement(ElementName="TooltipText")]
		[XmlElement(ElementName="TooltipText")]
		public String gxTpr_Tooltiptext
		{
			get { 
				return gxTv_SdtActionGroupItem_Tooltiptext; 
			}
			set { 
				gxTv_SdtActionGroupItem_Tooltiptext = value;
				SetDirty("Tooltiptext");
			}
		}


		[SoapElement(ElementName="Children" )]
		[XmlArray(ElementName="Children"  )]
		[XmlArrayItemAttribute(ElementName="Item" , IsNullable=false )]
		public GXBaseCollection<GeneXus.Programs.SdtActionGroupItem> gxTpr_Children_GXBaseCollection
		{
			get {
				if ( gxTv_SdtActionGroupItem_Children == null )
				{
					gxTv_SdtActionGroupItem_Children = new GXBaseCollection<GeneXus.Programs.SdtActionGroupItem>( context, "ActionGroupItem", "");
				}
				return gxTv_SdtActionGroupItem_Children;
			}
			set {
				if ( gxTv_SdtActionGroupItem_Children == null )
				{
					gxTv_SdtActionGroupItem_Children = new GXBaseCollection<GeneXus.Programs.SdtActionGroupItem>( context, "ActionGroupItem", "");
				}
				gxTv_SdtActionGroupItem_Children = value;
			}
		}

		[SoapIgnore]
		[XmlIgnore]
		public GXBaseCollection<GeneXus.Programs.SdtActionGroupItem> gxTpr_Children
		{
			get {
				if ( gxTv_SdtActionGroupItem_Children == null )
				{
					gxTv_SdtActionGroupItem_Children = new GXBaseCollection<GeneXus.Programs.SdtActionGroupItem>( context, "ActionGroupItem", "");
				}
				return gxTv_SdtActionGroupItem_Children ;
			}
			set {
				gxTv_SdtActionGroupItem_Children = value;
				SetDirty("Children");
			}
		}

		public void gxTv_SdtActionGroupItem_Children_SetNull()
		{
			gxTv_SdtActionGroupItem_Children = null;
			return  ;
		}

		public bool gxTv_SdtActionGroupItem_Children_IsNull()
		{
			if (gxTv_SdtActionGroupItem_Children == null)
			{
				return true ;
			}
			return false ;
		}



		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtActionGroupItem_Caption = "";
			gxTv_SdtActionGroupItem_Link = "";
			gxTv_SdtActionGroupItem_Class = "";
			gxTv_SdtActionGroupItem_Tooltiptext = "";

			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtActionGroupItem_Caption;
		protected String gxTv_SdtActionGroupItem_Link;
		protected String gxTv_SdtActionGroupItem_Class;
		protected String gxTv_SdtActionGroupItem_Tooltiptext;
		protected GXBaseCollection<GeneXus.Programs.SdtActionGroupItem> gxTv_SdtActionGroupItem_Children = null; 


		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"ActionGroupItem", Namespace="KBCalpesa22")]
	public class SdtActionGroupItem_RESTInterface : GxGenericCollectionItem<SdtActionGroupItem>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtActionGroupItem_RESTInterface( ) : base()
		{
		}

		public SdtActionGroupItem_RESTInterface( SdtActionGroupItem psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="Caption", Order=0)]
		public String gxTpr_Caption
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Caption);
			}
			set { 
				sdt.gxTpr_Caption = value;
			}
		}

		[DataMember(Name="Link", Order=1)]
		public String gxTpr_Link
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Link);
			}
			set { 
				sdt.gxTpr_Link = value;
			}
		}

		[DataMember(Name="Class", Order=2)]
		public String gxTpr_Class
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Class);
			}
			set { 
				sdt.gxTpr_Class = value;
			}
		}

		[DataMember(Name="TooltipText", Order=3)]
		public String gxTpr_Tooltiptext
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Tooltiptext);
			}
			set { 
				sdt.gxTpr_Tooltiptext = value;
			}
		}

		[DataMember(Name="Children", Order=4)]
		public  GxGenericCollection<GeneXus.Programs.SdtActionGroupItem_RESTInterface> gxTpr_Children
		{
			get { 
				return new GxGenericCollection<GeneXus.Programs.SdtActionGroupItem_RESTInterface>(sdt.gxTpr_Children);
			}
			set { 
				value.LoadCollection(sdt.gxTpr_Children);
			}
		}


		#endregion

		public SdtActionGroupItem sdt
		{
			get { 
				return (SdtActionGroupItem)Sdt;
			}
			set { 
				Sdt = value;
			}
		}

		[OnDeserializing]
		void checkSdt( StreamingContext ctx )
		{
			if ( sdt == null )
			{
				sdt = new SdtActionGroupItem() ;
			}
		}
	}
	#endregion
}