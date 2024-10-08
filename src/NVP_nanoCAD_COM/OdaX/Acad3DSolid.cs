﻿using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a solid object with free-form surface support
///</summary>
namespace NVP_nanoCAD_COM._OdaX.Acad3DSolid 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Acad3DSolid_Constructor : INode 
	{
		public OdaX.IAcad3DSolid _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcad3DSolid;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Acad3DSolid_ConstructorCast : INode 
	{
		public OdaX.IAcad3DSolid _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcad3DSolid;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Returns the center of the area or mass for a 3D solid or region.", 
		ViewType = "Data")]
	[NodeInput("Acad3DSolid", typeof(object))]

	///<summary>
	///Not implemented. Returns the center of the area or mass for a 3D solid or region.
	///</summary>
	public class Centroid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Centroid);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Returns the moment of inertia for a 3D solid.", 
		ViewType = "Data")]
	[NodeInput("Acad3DSolid", typeof(object))]

	///<summary>
	///Not implemented. Returns the moment of inertia for a 3D solid.
	///</summary>
	public class MomentOfInertia : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MomentOfInertia);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Returns the principal directions of a 3D solid or region.", 
		ViewType = "Data")]
	[NodeInput("Acad3DSolid", typeof(object))]

	///<summary>
	///Not implemented. Returns the principal directions of a 3D solid or region.
	///</summary>
	public class PrincipalDirections : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PrincipalDirections);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Returns the principal moments of a 3D solid or region.", 
		ViewType = "Data")]
	[NodeInput("Acad3DSolid", typeof(object))]

	///<summary>
	///Not implemented. Returns the principal moments of a 3D solid or region.
	///</summary>
	public class PrincipalMoments : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PrincipalMoments);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Returns the product of inertia of a 3D solid or region.", 
		ViewType = "Data")]
	[NodeInput("Acad3DSolid", typeof(object))]

	///<summary>
	///Not implemented. Returns the product of inertia of a 3D solid or region.
	///</summary>
	public class ProductOfInertia : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ProductOfInertia);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Returns the radius of gyration of a 3D solid or region.", 
		ViewType = "Data")]
	[NodeInput("Acad3DSolid", typeof(object))]

	///<summary>
	///Not implemented. Returns the radius of gyration of a 3D solid or region.
	///</summary>
	public class RadiiOfGyration : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RadiiOfGyration);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Returns the volume of a 3D solid.", 
		ViewType = "Data")]
	[NodeInput("Acad3DSolid", typeof(object))]

	///<summary>
	///Not implemented. Returns the volume of a 3D solid.
	///</summary>
	public class Volume : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Volume);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Performs a boolean operation on an object and another 3D solid or region.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DSolid", typeof(object))]
	[NodeInput("OdaX.AcBoolean", typeof(System.Object))]
	[NodeInput("SolidObject", typeof(System.Object))]

	///<summary>
	///Not implemented. Performs a boolean operation on an object and another 3D solid or region.
	///</summary>
	public class Boolean : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Boolean(((OdaX.AcBoolean)inputs[1].Value),inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Checks the interference between two 3D solids.", 
		ViewType = "Data")]
	[NodeInput("Acad3DSolid", typeof(object))]
	[NodeInput("Object", typeof(System.Object))]
	[NodeInput("CreateInterferenceSolid", typeof(System.Object))]

	///<summary>
	///Not implemented. Checks the interference between two 3D solids.
	///</summary>
	public class CheckInterference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CheckInterference(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Creates a section of a 3D solid; the resulting section is a region.", 
		ViewType = "Data")]
	[NodeInput("Acad3DSolid", typeof(object))]
	[NodeInput("Point1", typeof(System.Object))]
	[NodeInput("Point2", typeof(System.Object))]
	[NodeInput("point3", typeof(System.Object))]

	///<summary>
	///Not implemented. Creates a section of a 3D solid; the resulting section is a region.
	///</summary>
	public class SectionSolid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SectionSolid(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Creates a slice of a 3D solid; the resulting slice is an array of the 3D solid.", 
		ViewType = "Data")]
	[NodeInput("Acad3DSolid", typeof(object))]
	[NodeInput("Point1", typeof(System.Object))]
	[NodeInput("Point2", typeof(System.Object))]
	[NodeInput("point3", typeof(System.Object))]
	[NodeInput("Negative", typeof(System.Object))]

	///<summary>
	///Not implemented. Creates a slice of a 3D solid; the resulting slice is an array of the 3D solid.
	///</summary>
	public class SliceSolid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SliceSolid(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value));

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Returns the type of 3D solid.", 
		ViewType = "Data")]
	[NodeInput("Acad3DSolid", typeof(object))]

	///<summary>
	///Not implemented. Returns the type of 3D solid.
	///</summary>
	public class SolidType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SolidType);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Specifies or returns the center of a 3D solid.", 
		ViewType = "Data")]
	[NodeInput("Acad3DSolid", typeof(object))]

	///<summary>
	///Not implemented. Specifies or returns the center of a 3D solid.
	///</summary>
	public class Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Specifies or returns the center of a 3D solid.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DSolid", typeof(object))]
	[NodeInput("Position", typeof(System.Object))]

	///<summary>
	///Not implemented. Specifies or returns the center of a 3D solid.
	///</summary>
	public class Set_Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Position = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Specifies or returns whether history is saved for a 3D solid.", 
		ViewType = "Data")]
	[NodeInput("Acad3DSolid", typeof(object))]

	///<summary>
	///Not implemented. Specifies or returns whether history is saved for a 3D solid.
	///</summary>
	public class History : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.History);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Specifies or returns whether history is saved for a 3D solid.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DSolid", typeof(object))]
	[NodeInput("bHistory", typeof(System.Object))]

	///<summary>
	///Not implemented. Specifies or returns whether history is saved for a 3D solid.
	///</summary>
	public class Set_History : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.History = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Specifies or returns whether to show the history of a 3D solid.", 
		ViewType = "Data")]
	[NodeInput("Acad3DSolid", typeof(object))]

	///<summary>
	///Not implemented. Specifies or returns whether to show the history of a 3D solid.
	///</summary>
	public class ShowHistory : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShowHistory);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Specifies or returns whether to show the history of a 3D solid.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DSolid", typeof(object))]
	[NodeInput("Position", typeof(System.Object))]

	///<summary>
	///Not implemented. Specifies or returns whether to show the history of a 3D solid.
	///</summary>
	public class Set_ShowHistory : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShowHistory = inputs[1].Value;
			return null;
		}
	}
}
